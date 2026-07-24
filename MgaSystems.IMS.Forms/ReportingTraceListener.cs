// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.ReportingTraceListener
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using GrapeCity.ActiveReports;
using MGASystems.Data;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Forms;

public class ReportingTraceListener : TraceListener
{
  private const string CatCommandDetail = "MGASystems.Data.Utility.CommandDetail";
  private const string CommandTextString = "Command.CommandText:";
  private string CommandTypeString;
  private readonly bool _isAdHoc;

  public ReportingTraceListener(bool isAdHoc)
  {
    this.CommandTypeString = $", {Environment.NewLine}Command.CommandType:";
    this._isAdHoc = false;
    this.ProcedureList = new List<string>();
    this.IsThreadSafe = false;
    this._isAdHoc = isAdHoc;
  }

  private List<string> ProcedureList { get; }

  public override void Write(string message, string category)
  {
    try
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(category, "MGASystems.Data.Utility.CommandDetail", false) != 0)
        return;
      string procedureName = "";
      if (!this.TryParseProcedureName(message, ref procedureName) || procedureName.IndexOf("LogReportAction", StringComparison.InvariantCultureIgnoreCase) != -1 || procedureName.IndexOf("FROM tblSystemSettings WHERE Setting", StringComparison.InvariantCultureIgnoreCase) != -1 || procedureName.IndexOf("SELECT { fn NOW() }", StringComparison.InvariantCultureIgnoreCase) != -1 || procedureName.IndexOf("SELECT [ReportGUID],[ReportName],[GroupName],[Description]", StringComparison.InvariantCultureIgnoreCase) != -1)
        return;
      this.ProcedureList.Add(procedureName.Trim());
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
  }

  public bool TryParseProcedureName(string message, ref string procedureName)
  {
    procedureName = "";
    try
    {
      int num = message.IndexOf("Command.CommandText:", StringComparison.InvariantCultureIgnoreCase);
      if (num > -1)
      {
        int startIndex = num + "Command.CommandText:".Length;
        procedureName = message.Substring(startIndex, message.IndexOf(this.CommandTypeString) - startIndex);
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    return !string.IsNullOrEmpty(procedureName);
  }

  public override bool IsThreadSafe { get; }

  internal static void RunCannedReportAndLogSqlDetails(SectionReport report)
  {
    SecureReportResourceAttribute resourceAttribute = (SecureReportResourceAttribute) null;
    try
    {
      resourceAttribute = ((IEnumerable<object>) report.GetType().GetCustomAttributes(typeof (SecureReportResourceAttribute), true)).SingleOrDefault<object>() as SecureReportResourceAttribute;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    if (resourceAttribute != null && resourceAttribute.UniqueIdentifier != Guid.Empty)
      ReportingTraceListener.RunReportAndLogSqlDetails(report, resourceAttribute.Name, resourceAttribute.UniqueIdentifier, false);
    else
      report.Run();
  }

  internal static void RunAdHocReportAndLogSqlDetails(
    SectionReport report,
    string reportName,
    Guid reportGuid)
  {
    ReportingTraceListener.RunReportAndLogSqlDetails(report, reportName, reportGuid, true);
  }

  private static void RunReportAndLogSqlDetails(
    SectionReport report,
    string reportName,
    Guid reportGuid,
    bool isAdHoc)
  {
    bool flag = false;
    int num = -1;
    try
    {
      if (ReportingTraceListener.IsLogEnabled("MGASystems.Data.Utility.CommandDetail"))
      {
        DataRow row = DefaultDatabase.ExecuteDataTable("FetchReportProcedureLog", new object[2]
        {
          (object) "@reportGuid",
          (object) reportGuid
        }).AsEnumerable().SingleOrDefault<DataRow>();
        num = row != null ? row.Field<int>("ID") : -1;
        DateTime t2 = row != null ? row.Field<DateTime>("LastUpdated") : DateTime.MinValue;
        if (num != -1)
        {
          if (DateTime.Compare(DateTime.Now.AddDays(-30.0), t2) <= 0)
            goto label_6;
        }
        flag = true;
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
label_6:
    if (!flag)
    {
      report.Run();
    }
    else
    {
      using (ReportingTraceListener listener = new ReportingTraceListener(isAdHoc))
      {
        try
        {
          Trace.Listeners.Add((TraceListener) listener);
          report.Run();
        }
        finally
        {
          try
          {
            Trace.Listeners.Remove((TraceListener) listener);
            string str = "Developer is not using database library for this report.";
            if (listener.ProcedureList.Count > 0)
              str = string.Join($"{Environment.NewLine}/*---------------*/{Environment.NewLine}", (IEnumerable<string>) listener.ProcedureList);
            if (num == -1)
              DefaultDatabase.ExecuteNonQuery("InsertReportProcedureLog", new object[8]
              {
                (object) "@ReportGuid",
                (object) reportGuid,
                (object) "@IsAdHoc",
                (object) isAdHoc,
                (object) "@ReportName",
                (object) reportName,
                (object) "@ProceduresCalled",
                (object) str
              });
            else
              DefaultDatabase.ExecuteNonQuery("UpdateReportProcedureLog", new object[4]
              {
                (object) "@ID",
                (object) num,
                (object) "@ProceduresCalled",
                (object) str
              });
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
    }
  }

  public override void Write(string message)
  {
  }

  public override void WriteLine(string message)
  {
  }

  private static bool IsLogEnabled(string logKey)
  {
    LogDestination logDestination;
    return MGASystems.IMS.Logging.Log.LogCategoryDestinations != null && MGASystems.IMS.Logging.Log.LogCategoryDestinations.TryGetValue(logKey, out logDestination) && logDestination != LogDestination.Disabled;
  }
}
