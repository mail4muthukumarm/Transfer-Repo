// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.AdHocReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.AutomationReports;
using MGASystems.IMS.Reporting.ReportControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using System.Xml;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class AdHocReport
{
  private const string AdHocLogGUID = "{BCD1C964-CF95-44CB-AB61-F37D10747222}";
  private Guid _ReportGUID;
  private DataTable _dtReportData;
  private DataTable _dtCriteria;
  private bool _Saved;
  private readonly bool _NewReport;
  private AdHocReport.AdHocReportType _ReportType;
  private SqlDataAdapter _da;
  private SqlConnection _cnSQL;
  private SqlCommand _cmdSelect;
  private SqlCommand _cmdInsert;
  private SqlCommand _cmdUpdate;
  private SqlCommand _cmdDelete;
  private bool RequiresQuoteOptionGuids;
  private bool RequiresCompanyLineID;
  private SqlConnection _cn;

  public AdHocReport()
  {
    this._Saved = true;
    this._NewReport = true;
    this._ReportType = AdHocReport.AdHocReportType.NoType;
    this.RequiresQuoteOptionGuids = false;
    this.RequiresCompanyLineID = false;
    this._ReportGUID = Guid.NewGuid();
    this._cn = DefaultDatabase.CreateConnection();
    this._NewReport = true;
    this.SetUpDataAdapter();
    this._da.SelectCommand.Parameters["@ReportGUID"].Value = (object) Guid.Empty;
    this._dtReportData = new DataTable();
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this._da, this._dtReportData);
    this._dtReportData.Rows.Add();
    this._dtReportData.Rows[0]["ReportGUID"] = (object) this._ReportGUID;
    this._dtCriteria = this.SetUpCriteriaDataTable();
    this._ReportType = AdHocReport.AdHocReportType.Report;
  }

  public AdHocReport(Guid ReportGuid)
  {
    this._Saved = true;
    this._NewReport = true;
    this._ReportType = AdHocReport.AdHocReportType.NoType;
    this.RequiresQuoteOptionGuids = false;
    this.RequiresCompanyLineID = false;
    this._ReportGUID = ReportGuid;
    this._cn = DefaultDatabase.CreateConnection();
    this._NewReport = false;
    this.SetUpDataAdapter();
    this._da.SelectCommand.Parameters["@ReportGUID"].Value = (object) this._ReportGUID;
    this._dtReportData = new DataTable();
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this._da, this._dtReportData);
    if (this._dtReportData.Rows.Count < 1)
      throw new Exception($"Report {this._ReportGUID.ToString()}does not exists.");
    if (!this._dtReportData.Rows[0]["Parameters"].Equals((object) DBNull.Value))
    {
      StringReader reader = new StringReader((string) this._dtReportData.Rows[0]["Parameters"]);
      DataSet dataSet = new DataSet();
      int num = (int) dataSet.ReadXml((TextReader) reader);
      this._dtCriteria = dataSet.Tables[0];
      this._dtCriteria.TableName = nameof (Criteria);
    }
    else
      this._dtCriteria = this.SetUpCriteriaDataTable();
    this.RequiresQuoteOptionGuids = this.QuoteOptionRequirement;
    this._ReportType = this.GetReportType;
  }

  private AdHocReport.AdHocReportType GetReportType
  {
    get
    {
      switch (this.DocumentAutomationGroup)
      {
        case 0:
          this._ReportType = AdHocReport.AdHocReportType.Report;
          break;
        case 1:
          this._ReportType = AdHocReport.AdHocReportType.PolicyDoc;
          break;
        default:
          this._ReportType = AdHocReport.AdHocReportType.NoType;
          break;
      }
      return this._ReportType;
    }
  }

  public bool Save()
  {
    StringWriter writer = new StringWriter();
    string Left = this.ValidateSQL(this._dtReportData.Rows[0]["SQL"].ToString());
    bool flag;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) != 0)
    {
      int num = (int) MessageBox.Show($"Incorrect SQL. Use of reserved word {Left}.\r\nReport was not saved.", "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      flag = false;
    }
    else
    {
      this._dtCriteria.WriteXml((TextWriter) writer, XmlWriteMode.WriteSchema);
      this._dtReportData.Rows[0]["Parameters"] = (object) writer.ToString();
      object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT Count(*) FROM dbo.tblAdHocReports WHERE ReportGUID=@ReportGUID", new object[2]
      {
        (object) "@ReportGUID",
        (object) this._ReportGUID
      }));
      if (objectValue != null && !objectValue.Equals((object) DBNull.Value))
      {
        this._dtReportData.AcceptChanges();
        if ((int) objectValue == 0)
          this._dtReportData.Rows[0].SetAdded();
        else
          this._dtReportData.Rows[0].SetModified();
      }
      this._da.Update(this._dtReportData);
      CurrentUser.Instance.LogAction($"{$"AdHoc report '{this.ReportName}' was modified by user:'{CurrentUser.Instance.DisplayNameLastFirst}"}' logged in as '{Environment.UserDomainName}.{Environment.UserName}'", new Guid("{BCD1C964-CF95-44CB-AB61-F37D10747222}"), this.GUID.ToString());
      this._Saved = true;
      flag = true;
    }
    return flag;
  }

  public void SaveToFile(string FileName)
  {
    this._dtReportData.TableName = "report";
    this._dtReportData.WriteXml(FileName, XmlWriteMode.WriteSchema);
    this._Saved = true;
  }

  public void ReadFromFile(string FileName)
  {
    DataSet dataSet1 = new DataSet();
    int num1 = (int) dataSet1.ReadXml(FileName, XmlReadMode.ReadSchema);
    this._dtReportData.Rows.Clear();
    this._dtReportData.ImportRow(dataSet1.Tables[0].Rows[0]);
    if (!this._dtReportData.Rows[0]["Parameters"].Equals((object) DBNull.Value))
    {
      StringReader reader = new StringReader((string) this._dtReportData.Rows[0]["Parameters"]);
      DataSet dataSet2 = new DataSet();
      int num2 = (int) dataSet2.ReadXml((TextReader) reader);
      this._dtCriteria = dataSet2.Tables[0];
      this._dtCriteria.TableName = "Criteria";
      this._ReportGUID = (Guid) this._dtReportData.Rows[0]["ReportGUID"];
    }
    else
      this._dtCriteria = this.SetUpCriteriaDataTable();
    this._Saved = true;
  }

  public void ExportToSQL(string FileName)
  {
    StreamWriter streamWriter = new StreamWriter(FileName);
    streamWriter.Write(this._getReportAsSQL());
    streamWriter.Close();
  }

  public void Duplicate()
  {
    this._ReportGUID = Guid.NewGuid();
    this._dtReportData.Rows[0]["ReportGUID"] = (object) this._ReportGUID;
    this.Save();
  }

  public string ReportName
  {
    get => this._dtReportData.Rows[0][nameof (ReportName)].ToString();
    set
    {
      this._dtReportData.Rows[0][nameof (ReportName)] = (object) value;
      this._Saved = false;
    }
  }

  public string GroupName
  {
    get => this._dtReportData.Rows[0][nameof (GroupName)].ToString();
    set
    {
      this._dtReportData.Rows[0][nameof (GroupName)] = (object) value;
      this._Saved = false;
    }
  }

  public string Description
  {
    get => this._dtReportData.Rows[0][nameof (Description)].ToString();
    set
    {
      this._dtReportData.Rows[0][nameof (Description)] = (object) value;
      this._Saved = false;
    }
  }

  public string Title
  {
    get => this._dtReportData.Rows[0][nameof (Title)].ToString();
    set
    {
      this._dtReportData.Rows[0][nameof (Title)] = (object) value;
      this._Saved = false;
    }
  }

  public string SQL
  {
    get => this._dtReportData.Rows[0][nameof (SQL)].ToString();
    set
    {
      this._dtReportData.Rows[0][nameof (SQL)] = (object) value;
      this._Saved = false;
    }
  }

  public bool AllowPrint
  {
    get
    {
      if (this._dtReportData.Rows[0][nameof (AllowPrint)].Equals((object) DBNull.Value))
        this._dtReportData.Rows[0][nameof (AllowPrint)] = (object) 1;
      return bool.Parse(this._dtReportData.Rows[0][nameof (AllowPrint)].ToString());
    }
    set
    {
      this._dtReportData.Rows[0][nameof (AllowPrint)] = !value ? (object) 0 : (object) 1;
      this._Saved = false;
    }
  }

  public bool Published
  {
    get
    {
      if (this._dtReportData.Rows[0][nameof (Published)].Equals((object) DBNull.Value))
        this._dtReportData.Rows[0][nameof (Published)] = (object) 0;
      return bool.Parse(this._dtReportData.Rows[0][nameof (Published)].ToString());
    }
    set
    {
      this._dtReportData.Rows[0][nameof (Published)] = !value ? (object) 0 : (object) 1;
      this._Saved = false;
    }
  }

  public Guid GUID => this._ReportGUID;

  public DataTable Criteria
  {
    get => this._dtCriteria;
    set
    {
      this._dtCriteria = value;
      StringWriter writer = new StringWriter();
      this._dtCriteria.WriteXml((TextWriter) writer, XmlWriteMode.WriteSchema);
      this._dtReportData.Rows[0]["Parameters"] = (object) writer.ToString();
      this._Saved = false;
    }
  }

  public string ColumnWidth
  {
    get => this._dtReportData.Rows[0][nameof (ColumnWidth)].ToString();
    set
    {
      this._dtReportData.Rows[0][nameof (ColumnWidth)] = (object) value;
      this._Saved = false;
    }
  }

  public string SummaryFields
  {
    get => this._dtReportData.Rows[0][nameof (SummaryFields)].ToString();
    set
    {
      this._dtReportData.Rows[0][nameof (SummaryFields)] = (object) value;
      this._Saved = false;
    }
  }

  public string TableNames
  {
    get => this._dtReportData.Rows[0].Field<string>(nameof (TableNames)) ?? "";
    set
    {
      this._dtReportData.Rows[0][nameof (TableNames)] = (object) value;
      this._Saved = false;
    }
  }

  public string SubTitle
  {
    get => this._dtReportData.Rows[0][nameof (SubTitle)].ToString();
    set
    {
      this._dtReportData.Rows[0][nameof (SubTitle)] = (object) value;
      this._Saved = false;
    }
  }

  public Decimal MarginTop
  {
    get
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dtReportData.Rows[0][nameof (MarginTop)])))
        this._dtReportData.Rows[0][nameof (MarginTop)] = (object) 0.5;
      return Conversions.ToDecimal(this._dtReportData.Rows[0][nameof (MarginTop)]);
    }
    set
    {
      this._dtReportData.Rows[0][nameof (MarginTop)] = (object) value;
      this._Saved = false;
    }
  }

  public Decimal MarginBottom
  {
    get
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dtReportData.Rows[0][nameof (MarginBottom)])))
        this._dtReportData.Rows[0][nameof (MarginBottom)] = (object) 0.5;
      return Conversions.ToDecimal(this._dtReportData.Rows[0][nameof (MarginBottom)]);
    }
    set
    {
      this._dtReportData.Rows[0][nameof (MarginBottom)] = (object) value;
      this._Saved = false;
    }
  }

  public Decimal MarginLeft
  {
    get
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dtReportData.Rows[0][nameof (MarginLeft)])))
        this._dtReportData.Rows[0][nameof (MarginLeft)] = (object) 0.5;
      return Conversions.ToDecimal(this._dtReportData.Rows[0][nameof (MarginLeft)]);
    }
    set
    {
      this._dtReportData.Rows[0][nameof (MarginLeft)] = (object) value;
      this._Saved = false;
    }
  }

  public Decimal MarginRight
  {
    get
    {
      if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dtReportData.Rows[0][nameof (MarginRight)])))
        this._dtReportData.Rows[0][nameof (MarginRight)] = (object) 0.5;
      return Conversions.ToDecimal(this._dtReportData.Rows[0][nameof (MarginRight)]);
    }
    set
    {
      this._dtReportData.Rows[0][nameof (MarginRight)] = (object) value;
      this._Saved = false;
    }
  }

  public bool isPaperOrientationPortrait
  {
    get
    {
      if (this._dtReportData.Rows[0]["PaperOrientationPortrait"].Equals((object) DBNull.Value))
        this._dtReportData.Rows[0]["PaperOrientationPortrait"] = (object) 0;
      return bool.Parse(this._dtReportData.Rows[0]["PaperOrientationPortrait"].ToString());
    }
    set
    {
      this._dtReportData.Rows[0]["PaperOrientationPortrait"] = !value ? (object) 0 : (object) 1;
      this._Saved = false;
    }
  }

  public bool isPaperOrientationLandscape
  {
    get
    {
      if (this._dtReportData.Rows[0]["PaperOrientationPortrait"].Equals((object) DBNull.Value))
        this._dtReportData.Rows[0]["PaperOrientationPortrait"] = (object) 0;
      return !bool.Parse(this._dtReportData.Rows[0]["PaperOrientationPortrait"].ToString());
    }
    set
    {
      this._dtReportData.Rows[0]["PaperOrientationPortrait"] = !value ? (object) 1 : (object) 0;
      this._Saved = false;
    }
  }

  public bool isAutomationDoc
  {
    get
    {
      if (this._dtReportData.Rows[0]["AutomationDoc"].Equals((object) DBNull.Value))
        this._dtReportData.Rows[0]["AutomationDoc"] = (object) 0;
      return bool.Parse(this._dtReportData.Rows[0]["AutomationDoc"].ToString());
    }
    set
    {
      this._dtReportData.Rows[0]["AutomationDoc"] = !value ? (object) 0 : (object) 1;
      this._Saved = false;
    }
  }

  public bool isThreaded
  {
    get
    {
      if (this._dtReportData.Rows[0]["IsThreaded"].Equals((object) DBNull.Value))
        this._dtReportData.Rows[0]["IsThreaded"] = (object) 0;
      return bool.Parse(this._dtReportData.Rows[0]["IsThreaded"].ToString());
    }
    set
    {
      this._dtReportData.Rows[0]["IsThreaded"] = !value ? (object) 0 : (object) 1;
      this._Saved = false;
    }
  }

  public bool isLargeExport
  {
    get
    {
      if (this._dtReportData.Rows[0][nameof (isLargeExport)].Equals((object) DBNull.Value))
        this._dtReportData.Rows[0][nameof (isLargeExport)] = (object) 0;
      return bool.Parse(this._dtReportData.Rows[0][nameof (isLargeExport)].ToString());
    }
    set
    {
      this._dtReportData.Rows[0][nameof (isLargeExport)] = !value ? (object) 0 : (object) 1;
      this._Saved = false;
    }
  }

  public bool isLayoutDefined
  {
    get
    {
      return !Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dtReportData.Rows[0]["Layout"])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this._dtReportData.Rows[0]["Layout"].ToString()), "", false) != 0;
    }
  }

  public string Layout
  {
    get
    {
      string layout = "";
      XmlDocument xmlDocument = new XmlDocument();
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(this._dtReportData.Rows[0][nameof (Layout)])) && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this._dtReportData.Rows[0][nameof (Layout)].ToString()), "", false) != 0)
        layout = this._dtReportData.Rows[0][nameof (Layout)].ToString();
      return layout;
    }
    set
    {
      this._dtReportData.Rows[0][nameof (Layout)] = (object) value;
      this._Saved = false;
    }
  }

  public int DocumentAutomationGroup
  {
    get
    {
      if (this._dtReportData.Rows[0][nameof (DocumentAutomationGroup)].Equals((object) DBNull.Value))
        this._dtReportData.Rows[0][nameof (DocumentAutomationGroup)] = (object) 0;
      return int.Parse(this._dtReportData.Rows[0][nameof (DocumentAutomationGroup)].ToString());
    }
    set
    {
      this._dtReportData.Rows[0][nameof (DocumentAutomationGroup)] = (object) value;
      this._Saved = false;
    }
  }

  public bool Saved => this._Saved;

  public BaseReportControl[] getReportControls => this.loReportControls().ToArray();

  public string getReportAsSQL => this._getReportAsSQL();

  public AutomationReportAttribute AutomationReportAttribute
  {
    get
    {
      AutomationReportAttribute automationReportAttribute;
      if (this._ReportType < AdHocReport.AdHocReportType.PolicyDoc)
      {
        automationReportAttribute = (AutomationReportAttribute) null;
      }
      else
      {
        Enums.AutomationDocGroups reportType = (Enums.AutomationDocGroups) this._ReportType;
        automationReportAttribute = new AutomationReportAttribute(this._ReportGUID.ToString(), reportType, this.ReportName, this.Description);
      }
      return automationReportAttribute;
    }
  }

  public Type ReportType
  {
    get
    {
      Type reportType;
      switch (this._ReportType)
      {
        case AdHocReport.AdHocReportType.Report:
          reportType = typeof (AdHocReportDisplay);
          break;
        case AdHocReport.AdHocReportType.PolicyDoc:
          reportType = typeof (AdHocQuoteDocumentDisplay);
          break;
        default:
          reportType = (Type) null;
          break;
      }
      return reportType;
    }
  }

  public Enums.AutomationDocGroups AutomationDocumentGroup
  {
    get
    {
      return this._ReportType != AdHocReport.AdHocReportType.PolicyDoc ? (Enums.AutomationDocGroups) 0 : Enums.AutomationDocGroups.PolicyDoc;
    }
  }

  public bool QuoteOptionRequirement
  {
    get
    {
      if (!this.RequiresQuoteOptionGuids)
      {
        if (this._dtCriteria != null)
        {
          try
          {
            foreach (DataRow row in this._dtCriteria.Rows)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row["CriteriaID"].ToString(), "201", false) == 0)
              {
                this.RequiresQuoteOptionGuids = true;
                break;
              }
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
      }
      return this.RequiresQuoteOptionGuids;
    }
  }

  public bool CompanyLineIDRequirement
  {
    get
    {
      if (!this.RequiresCompanyLineID)
      {
        if (this._dtCriteria != null)
        {
          try
          {
            foreach (DataRow row in this._dtCriteria.Rows)
            {
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row["CriteriaID"].ToString(), "203", false) == 0)
              {
                this.RequiresCompanyLineID = true;
                break;
              }
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
      }
      return this.RequiresCompanyLineID;
    }
  }

  private string ValidateSQL(string sSQL)
  {
    string[] strArray1 = "INSERT;UPDATE;DELETE;DROP;TRUNCATE;ALTER;EXEC".Split(';');
    string str1 = "";
    string upper = sSQL.ToUpper();
    string[] strArray2 = strArray1;
    int index = 0;
    string str2;
    while (index < strArray2.Length)
    {
      string str3 = strArray2[index];
      int num = upper.IndexOf(str3, 0);
      if (num == 0)
      {
        str2 = str3;
        goto label_10;
      }
      for (; num > -1; num = upper.IndexOf(str3, num + 1))
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(upper.Substring(num - 1, 1), " ", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(upper.Substring(num + str3.Length, 1), " ", false) == 0)
        {
          str2 = str3;
          goto label_10;
        }
      }
      checked { ++index; }
    }
    str2 = str1;
label_10:
    return str2;
  }

  private string _getReportAsSQL()
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.AppendLine($"DELETE FROM tblAdHocReports WHERE ReportGUID='{this._ReportGUID.ToString()}'");
    stringBuilder.AppendLine("GO");
    stringBuilder.AppendLine();
    stringBuilder.AppendLine("INSERT tblAdHocReports ([ReportGUID], [ReportName], [GroupName], [Description], [Title], [SubTitle], [AllowPrint], [Published],[ColumnWidth],[SummaryFields],[TableNames], [SQL], [MarginTop],[MarginBottom],[MarginLeft],[MarginRight],[PaperOrientationPortrait],[Layout],[AutomationDoc], [DocumentAutomationGroup], [IsThreaded], [isLargeExport], [Parameters], [ReportProperties]) ");
    stringBuilder.AppendLine("VALUES (");
    stringBuilder.AppendLine($"'{this._ReportGUID.ToString()}',");
    stringBuilder.AppendLine($"'{this.ReportName}',");
    stringBuilder.AppendLine($"'{this.GroupName}',");
    stringBuilder.AppendLine($"'{this.Description}',");
    stringBuilder.AppendLine($"'{this.Title}',");
    stringBuilder.AppendLine($"'{this.SubTitle}',");
    stringBuilder.AppendLine((this.AllowPrint ? "1" : "0").ToString() + ",");
    stringBuilder.AppendLine((this.Published ? "1" : "0").ToString() + ",");
    stringBuilder.AppendLine($"'{this.ColumnWidth}',");
    stringBuilder.AppendLine($"'{this.SummaryFields}',");
    stringBuilder.AppendLine($"'{this.TableNames}',");
    stringBuilder.AppendLine($"'{Strings.Replace(this.SQL, "'", "''")}',");
    stringBuilder.AppendLine(this.MarginTop.ToString() + ",");
    stringBuilder.AppendLine(this.MarginBottom.ToString() + ",");
    stringBuilder.AppendLine(this.MarginLeft.ToString() + ",");
    stringBuilder.AppendLine(this.MarginRight.ToString() + ",");
    stringBuilder.AppendLine((this.isPaperOrientationPortrait ? "1" : "0").ToString() + ",");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._dtReportData.Rows[0]["Layout"].ToString(), "", false) == 0)
      stringBuilder.AppendLine("'',");
    else
      stringBuilder.AppendLine($"'{Strings.Replace(this._dtReportData.Rows[0]["Layout"].ToString(), "'", "''")}',");
    stringBuilder.AppendLine((this.isAutomationDoc ? "1" : "0").ToString() + ",");
    stringBuilder.AppendLine(this.DocumentAutomationGroup.ToString() + ",");
    stringBuilder.AppendLine((this.isThreaded ? "1" : "0").ToString() + ",");
    stringBuilder.AppendLine((this.isLargeExport ? "1" : "0").ToString() + ",");
    stringBuilder.AppendLine($"'{Strings.Replace(this._dtReportData.Rows[0]["Parameters"].ToString(), "'", "''")}',");
    stringBuilder.AppendLine($"'{Strings.Replace(this._dtReportData.Rows[0]["ReportProperties"].ToString(), "'", "''")}',");
    stringBuilder.AppendLine(")");
    stringBuilder.AppendLine("GO");
    stringBuilder.AppendLine();
    stringBuilder.AppendLine();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Left(this.SQL, 6).ToUpper(), "SELECT", false) != 0 && this.SQL.Length > 5)
    {
      stringBuilder.AppendLine($"If EXISTS( SELECT * From sysobjects Where id = object_id(N'{this.SQL}') And OBJECTPROPERTY(id, N'IsProcedure') = 1 )");
      stringBuilder.AppendLine("   DROP PROCEDURE " + this.SQL);
      stringBuilder.AppendLine("");
      stringBuilder.AppendLine("GO");
      stringBuilder.AppendLine();
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "sp_helptext", new object[2]
      {
        (object) "@objname",
        (object) this.SQL
      });
      try
      {
        foreach (DataRow row in dataTable.Rows)
          stringBuilder.Append(row[0].ToString());
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      stringBuilder.AppendLine("GO");
      stringBuilder.AppendLine();
    }
    return stringBuilder.ToString();
  }

  private List<BaseReportControl> loReportControls()
  {
    List<BaseReportControl> baseReportControlList = new List<BaseReportControl>();
    BaseReportControl baseReportControl = (BaseReportControl) null;
    DataRow[] dataRowArray = this._dtCriteria.Select("", "LineNo ASC");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      DataRow dataRow = dataRowArray[index];
      switch (Conversions.ToInteger(dataRow["CriteriaID"]))
      {
        case 1:
        case 9:
        case 36:
        case 37:
        case 40:
        case 47:
        case 53:
          baseReportControlList.Add(baseReportControl);
          checked { ++index; }
          continue;
        case 2:
          baseReportControl = (BaseReportControl) new BillingTypesListBox(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 3:
          baseReportControl = (BaseReportControl) new BusinessTypes(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 4:
          baseReportControl = (BaseReportControl) new Companies_Multi(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 5:
          baseReportControl = (BaseReportControl) new CompanyGroups(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 6:
          baseReportControl = (BaseReportControl) new CompanyGroups(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 7:
          baseReportControl = (BaseReportControl) new CompanyLines(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 8:
          baseReportControl = (BaseReportControl) new CompanyLocations(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 10:
          baseReportControl = (BaseReportControl) new CoverageLines(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 11:
          baseReportControl = (BaseReportControl) new DatePicker(dataRow["Parameter00"].ToString(), this.ProcDate(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 12:
          baseReportControl = (BaseReportControl) new DatePicker(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 13:
          baseReportControl = (BaseReportControl) new DateRangePicker(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 14:
          baseReportControl = (BaseReportControl) new DateRangePicker(dataRow["Parameter00"].ToString(), this.ProcDate(dataRow["Parameter01"].ToString()), this.ProcDate(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 15:
          baseReportControl = (BaseReportControl) new DateRangePicker(dataRow["Parameter00"].ToString(), this.ProcDate(dataRow["Parameter01"].ToString()), this.ProcDate(dataRow["Parameter02"].ToString()), this.StringToBoolean(dataRow["Parameter03"].ToString()));
          goto case 1;
        case 16 /*0x10*/:
          baseReportControl = (BaseReportControl) new EntitySelection(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 17:
          baseReportControl = (BaseReportControl) new EntitySelection(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 18:
          baseReportControl = (BaseReportControl) new GenericCheckBox(dataRow["Parameter00"].ToString(), dataRow["Parameter01"].ToString());
          goto case 1;
        case 19:
          baseReportControl = (BaseReportControl) new GenericCheckBox(dataRow["Parameter00"].ToString(), dataRow["Parameter01"].ToString(), this.StringToBoolean(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 20:
          baseReportControl = (BaseReportControl) new GenericComboBox(dataRow["Parameter00"].ToString(), dataRow["Parameter01"].ToString(), dataRow["Parameter02"].ToString(), dataRow["Parameter03"].ToString(), this.StringToType(dataRow["Parameter04"].ToString()), int.Parse(dataRow["Parameter05"].ToString()), int.Parse(dataRow["Parameter06"].ToString()));
          goto case 1;
        case 21:
          baseReportControl = (BaseReportControl) new GenericComboBox(dataRow["Parameter00"].ToString(), dataRow["Parameter01"].ToString(), dataRow["Parameter02"].ToString(), dataRow["Parameter03"].ToString(), this.StringToType(dataRow["Parameter04"].ToString()));
          goto case 1;
        case 22:
          baseReportControl = (BaseReportControl) new GenericListBox(dataRow["Parameter00"].ToString(), dataRow["Parameter01"].ToString(), dataRow["Parameter02"].ToString(), dataRow["Parameter03"].ToString(), int.Parse(dataRow["Parameter04"].ToString()), this.StringToBoolean(dataRow["Parameter05"].ToString()));
          goto case 1;
        case 23:
          baseReportControl = (BaseReportControl) new GenericListBox(dataRow["Parameter00"].ToString(), dataRow["Parameter01"].ToString(), dataRow["Parameter02"].ToString(), dataRow["Parameter03"].ToString(), this.StringToBoolean(dataRow["Parameter04"].ToString()));
          goto case 1;
        case 24:
          baseReportControl = (BaseReportControl) new GenericListBox(dataRow["Parameter00"].ToString(), dataRow["Parameter01"].ToString(), dataRow["Parameter02"].ToString(), dataRow["Parameter03"].ToString(), this.StringToBoolean(dataRow["Parameter04"].ToString()), this.StringToType(dataRow["Parameter05"].ToString()));
          goto case 1;
        case 25:
          baseReportControl = (BaseReportControl) new GenericListBox(dataRow["Parameter00"].ToString(), dataRow["Parameter01"].ToString(), dataRow["Parameter02"].ToString(), dataRow["Parameter03"].ToString(), this.StringToBoolean(dataRow["Parameter04"].ToString()), this.StringToType(dataRow["Parameter05"].ToString()), this.StringToBoolean(dataRow["Parameter06"].ToString()));
          goto case 1;
        case 26:
          baseReportControl = (BaseReportControl) new GenericListBox(dataRow["Parameter00"].ToString(), dataRow["Parameter01"].ToString(), dataRow["Parameter02"].ToString(), dataRow["Parameter03"].ToString(), this.StringToBoolean(dataRow["Parameter04"].ToString()), this.StringToType(dataRow["Parameter05"].ToString()), this.StringToBoolean(dataRow["Parameter06"].ToString()), this.StringToBoolean(dataRow["Parameter07"].ToString()));
          goto case 1;
        case 27:
          baseReportControl = (BaseReportControl) new GenericListBox(dataRow["Parameter00"].ToString(), dataRow["Parameter01"].ToString(), dataRow["Parameter02"].ToString(), dataRow["Parameter03"].ToString(), this.StringToBoolean(dataRow["Parameter04"].ToString()), this.StringToType(dataRow["Parameter05"].ToString()), this.StringToBoolean(dataRow["Parameter06"].ToString()), this.StringToBoolean(dataRow["Parameter07"].ToString()), int.Parse(dataRow["Parameter08"].ToString()));
          goto case 1;
        case 28:
          baseReportControl = (BaseReportControl) new Insureds(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 29:
          baseReportControl = (BaseReportControl) new LicenseTypes(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 30:
          baseReportControl = (BaseReportControl) new MoneyRange(dataRow["Parameter00"].ToString());
          goto case 1;
        case 31 /*0x1F*/:
          baseReportControl = (BaseReportControl) new MoneyRange(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 32 /*0x20*/:
          baseReportControl = (BaseReportControl) new NoteType(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 33:
          baseReportControl = (BaseReportControl) new Occupancy(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 34:
          baseReportControl = (BaseReportControl) new OfficeLocations(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 35:
          baseReportControl = (BaseReportControl) new OfficeLocations(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 38:
          baseReportControl = (BaseReportControl) new OfficesAndProducerSelection();
          goto case 1;
        case 39:
          baseReportControl = (BaseReportControl) new OptionalDateRange(dataRow["Parameter00"].ToString(), this.ProcDate(dataRow["Parameter01"].ToString()), this.ProcDate(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 41:
          baseReportControl = (BaseReportControl) new ProducerLocations(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 42:
          baseReportControl = (BaseReportControl) new ProducerLocations_Multi(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 43:
          baseReportControl = (BaseReportControl) new Producers(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 44:
          baseReportControl = (BaseReportControl) new Producers_Multi(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 45:
          baseReportControl = (BaseReportControl) new Producers_Multi_Ex(dataRow["Parameter00"].ToString());
          goto case 1;
        case 46:
          baseReportControl = (BaseReportControl) new QuoteStatus(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 48 /*0x30*/:
          baseReportControl = (BaseReportControl) new States(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 49:
          baseReportControl = (BaseReportControl) new StateThenCitySelection();
          goto case 1;
        case 50:
          baseReportControl = (BaseReportControl) new TextInput(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 51:
          baseReportControl = (BaseReportControl) new TextInput(dataRow["Parameter00"].ToString(), this.StringToTextInputType(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 52:
          baseReportControl = (BaseReportControl) new Underwriters(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 54:
          baseReportControl = (BaseReportControl) new CompanyTree(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 55:
          baseReportControl = (BaseReportControl) new CompanyTree(dataRow["Parameter00"].ToString(), int.Parse(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 56:
          baseReportControl = (BaseReportControl) new CompanyTree(dataRow["Parameter00"].ToString(), int.Parse(dataRow["Parameter01"].ToString()), int.Parse(dataRow["Parameter02"].ToString()), this.StringToBoolean(dataRow["Parameter03"].ToString()));
          goto case 1;
        case 57:
          baseReportControl = (BaseReportControl) new CostCenter(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 58:
          baseReportControl = (BaseReportControl) new CostCenter(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), int.Parse(dataRow["Parameter02"].ToString()), int.Parse(dataRow["Parameter03"].ToString()));
          goto case 1;
        case 59:
          baseReportControl = (BaseReportControl) new Users(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 60:
          baseReportControl = (BaseReportControl) new Users(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), int.Parse(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 61:
          baseReportControl = (BaseReportControl) new DatePickerSpin(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 62:
          baseReportControl = (BaseReportControl) new DatePickerSpin(dataRow["Parameter00"].ToString(), this.ProcDate(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 63 /*0x3F*/:
          baseReportControl = (BaseReportControl) new DatePickerSpin(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), dataRow["Parameter02"].ToString());
          goto case 1;
        case 64 /*0x40*/:
          baseReportControl = (BaseReportControl) new DatePickerSpin(dataRow["Parameter00"].ToString(), this.ProcDate(dataRow["Parameter01"].ToString()), dataRow["Parameter02"].ToString());
          goto case 1;
        case 65:
          baseReportControl = (BaseReportControl) new DateRangePickerSpin(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 66:
          baseReportControl = (BaseReportControl) new DateRangePickerSpin(dataRow["Parameter00"].ToString(), this.ProcDate(dataRow["Parameter01"].ToString()), this.ProcDate(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 67:
          baseReportControl = (BaseReportControl) new DateRangePickerSpin(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), dataRow["Parameter02"].ToString());
          goto case 1;
        case 68:
          baseReportControl = (BaseReportControl) new DateRangePickerSpin(dataRow["Parameter00"].ToString(), this.ProcDate(dataRow["Parameter01"].ToString()), this.ProcDate(dataRow["Parameter02"].ToString()), dataRow["Parameter03"].ToString());
          goto case 1;
        case 69:
          baseReportControl = (BaseReportControl) new DateRangePickerSpin(dataRow["Parameter00"].ToString(), this.ProcDate(dataRow["Parameter01"].ToString()), this.ProcDate(dataRow["Parameter02"].ToString()), this.StringToBoolean(dataRow["Parameter03"].ToString()), dataRow["Parameter04"].ToString());
          goto case 1;
        case 70:
          baseReportControl = (BaseReportControl) new ProducersLocationsContacts();
          goto case 1;
        case 71:
          baseReportControl = (BaseReportControl) new ProducersLocationsContacts(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()));
          goto case 1;
        case 72:
          baseReportControl = (BaseReportControl) new ProducersLocationsContacts(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()), this.StringToBoolean(dataRow["Parameter03"].ToString()));
          goto case 1;
        case 73:
          baseReportControl = (BaseReportControl) new ProducersLocationsContacts(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()), this.StringToBoolean(dataRow["Parameter03"].ToString()), this.StringToBoolean(dataRow["Parameter04"].ToString()));
          goto case 1;
        case 74:
          baseReportControl = (BaseReportControl) new CostCenters_Multi(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()));
          goto case 1;
        case 75:
          baseReportControl = (BaseReportControl) new CompanyGroupsCompaniesCompanyLocations(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()), this.StringToBoolean(dataRow["Parameter03"].ToString()), this.StringToBoolean(dataRow["Parameter04"].ToString()), this.StringToBoolean(dataRow["Parameter05"].ToString()));
          goto case 1;
        case 76:
          baseReportControl = (BaseReportControl) new CompanyGroupsCompaniesCompanyLocations(dataRow["Parameter00"].ToString(), this.StringToBoolean(dataRow["Parameter01"].ToString()), this.StringToBoolean(dataRow["Parameter02"].ToString()), this.StringToBoolean(dataRow["Parameter03"].ToString()), this.StringToBoolean(dataRow["Parameter04"].ToString()), this.StringToBoolean(dataRow["Parameter05"].ToString()), int.Parse(dataRow["Parameter06"].ToString()));
          goto case 1;
        case 77:
          baseReportControl = (BaseReportControl) new CurrentUserGuid();
          goto case 1;
        default:
          baseReportControl = (BaseReportControl) null;
          goto case 1;
      }
    }
    return baseReportControlList;
  }

  private bool StringToBoolean(string s)
  {
    bool boolean;
    if (s.Equals(string.Empty))
    {
      boolean = false;
    }
    else
    {
      string Left = s.ToUpper().Trim();
      boolean = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "1", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "TRUE", false) == 0;
    }
    return boolean;
  }

  private Type StringToType(string s)
  {
    Type type1 = Type.GetType("System.String");
    Type type2;
    if (s.Equals(string.Empty))
    {
      type2 = (Type) Type.Missing;
    }
    else
    {
      string typeName = "System." + s.Trim().ToLower().Replace("System.", "");
      try
      {
        type1 = Type.GetType(typeName, false, true);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show("Type converting error", "Type error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        ProjectData.ClearProjectError();
      }
      type2 = type1;
    }
    return type2;
  }

  private TextInput.ReturnType StringToTextInputType(string s)
  {
    TextInput.ReturnType returnType = TextInput.ReturnType.Str;
    TextInput.ReturnType textInputType;
    if (s.Equals(string.Empty))
    {
      textInputType = returnType;
    }
    else
    {
      string Left = s.Trim().ToLower().Replace("System.", "");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "str", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "dbl", false) != 0)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "dec", false) != 0)
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "int", false) == 0)
              returnType = TextInput.ReturnType.Int;
          }
          else
            returnType = TextInput.ReturnType.Dec;
        }
        else
          returnType = TextInput.ReturnType.Dbl;
      }
      else
        returnType = TextInput.ReturnType.Str;
      textInputType = returnType;
    }
    return textInputType;
  }

  private DateTime ProcDate(string strDate)
  {
    return !this.IsDate(strDate) ? DateTime.Now.Date : DateTime.Parse(strDate);
  }

  private bool IsDate(string InpDate) => DateTime.TryParse(InpDate, out DateTime _);

  private void SetUpDataAdapter()
  {
    this._cmdSelect = new SqlCommand();
    this._cmdSelect.CommandText = "SELECT [ReportGUID],[ReportName],[GroupName],[Description],[Title],[AllowPrint],[Published],[SQL],[Parameters],[ColumnWidth],[SummaryFields],[TableNames],[SubTitle],[MarginTop],[MarginBottom],[MarginLeft],[MarginRight],[PaperOrientationPortrait],[Layout],[AutomationDoc],[DocumentAutomationGroup],[IsThreaded],[isLargeExport],[ReportProperties] FROM dbo.tblAdHocReports WHERE ReportGUID=@ReportGUID";
    this._cmdSelect.Parameters.Add("@ReportGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ReportGUID");
    this._cmdSelect.CommandType = CommandType.Text;
    this._cmdSelect.Connection = this._cn;
    this._cmdInsert = new SqlCommand();
    this._cmdInsert.CommandText = "INSERT INTO dbo.tblAdHocReports ([ReportGUID],[ReportName],[GroupName],[Description],[Title],[AllowPrint],[Published],[SQL],[Parameters],[ColumnWidth],[SummaryFields],[TableNames],[SubTitle],[MarginTop],[MarginBottom],[MarginLeft],[MarginRight],[PaperOrientationPortrait],[Layout],[AutomationDoc],[DocumentAutomationGroup],[IsThreaded],[isLargeExport],[ReportProperties]) VALUES (@ReportGUID,@ReportName,@GroupName,@Description,@Title,@AllowPrint,@Published,@SQL,@Parameters,@ColumnWidth,@SummaryFields,@TableNames,@SubTitle,@MarginTop,@MarginBottom,@MarginLeft,@MarginRight,@PaperOrientationPortrait,@Layout,@AutomationDoc,@DocumentAutomationGroup,@IsThreaded,@isLargeExport,@ReportProperties)";
    this._cmdInsert.Parameters.Add("@ReportGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ReportGUID");
    this._cmdInsert.Parameters.Add("@ReportName", SqlDbType.VarChar, 8000, "ReportName");
    this._cmdInsert.Parameters.Add("@GroupName", SqlDbType.VarChar, 50, "GroupName");
    this._cmdInsert.Parameters.Add("@Description", SqlDbType.VarChar, 8000, "Description");
    this._cmdInsert.Parameters.Add("@Title", SqlDbType.VarChar, 8000, "Title");
    this._cmdInsert.Parameters.Add("@Published", SqlDbType.Bit, 1, "Published");
    this._cmdInsert.Parameters.Add("@AllowPrint", SqlDbType.Bit, 1, "AllowPrint");
    this._cmdInsert.Parameters.Add("@SQL", SqlDbType.Text, 8000, "SQL");
    this._cmdInsert.Parameters.Add("@Parameters", SqlDbType.Text, -1, "Parameters");
    this._cmdInsert.Parameters.Add("@ColumnWidth", SqlDbType.VarChar, 8000, "ColumnWidth");
    this._cmdInsert.Parameters.Add("@SummaryFields", SqlDbType.VarChar, 8000, "SummaryFields");
    this._cmdInsert.Parameters.Add("@TableNames", SqlDbType.VarChar, 8000, "TableNames");
    this._cmdInsert.Parameters.Add("@SubTitle", SqlDbType.VarChar, 8000, "SubTitle");
    this._cmdInsert.Parameters.Add("@MarginTop", SqlDbType.Decimal, 5, "MarginTop");
    this._cmdInsert.Parameters.Add("@MarginBottom", SqlDbType.Decimal, 5, "MarginBottom");
    this._cmdInsert.Parameters.Add("@MarginLeft", SqlDbType.Decimal, 5, "MarginLeft");
    this._cmdInsert.Parameters.Add("@MarginRight", SqlDbType.Decimal, 5, "MarginRight");
    this._cmdInsert.Parameters.Add("@PaperOrientationPortrait", SqlDbType.Bit, 1, "PaperOrientationPortrait");
    this._cmdInsert.Parameters.Add("@Layout", SqlDbType.Text, -1, "Layout");
    this._cmdInsert.Parameters.Add("@AutomationDoc", SqlDbType.Bit, 1, "AutomationDoc");
    this._cmdInsert.Parameters.Add("@DocumentAutomationGroup", SqlDbType.TinyInt, 5, "DocumentAutomationGroup");
    this._cmdInsert.Parameters.Add("@IsThreaded", SqlDbType.Bit, 1, "IsThreaded");
    this._cmdInsert.Parameters.Add("@isLargeExport", SqlDbType.Bit, 1, "isLargeExport");
    this._cmdInsert.Parameters.Add("@ReportProperties", SqlDbType.Text, 8000, "ReportProperties");
    this._cmdInsert.CommandType = CommandType.Text;
    this._cmdInsert.Connection = this._cn;
    this._cmdUpdate = new SqlCommand();
    this._cmdUpdate.CommandText = "UPDATE dbo.tblAdHocReports SET [ReportName]=@ReportName,[GroupName]=@GroupName,[Description]=@Description,[Title]=@Title,[AllowPrint]=@AllowPrint,[Published]=@Published,[SQL]=@SQL,[Parameters]=@Parameters,[ColumnWidth]=@ColumnWidth, [SummaryFields]=@SummaryFields, [TableNames]=@TableNames, [SubTitle]=@SubTitle,[MarginTop]=@MarginTop,[MarginBottom]=@MarginBottom,[MarginLeft]=@MarginLeft,[MarginRight]=@MarginRight,[PaperOrientationPortrait]=@PaperOrientationPortrait,[Layout]=@Layout,[AutomationDoc]=@AutomationDoc, [DocumentAutomationGroup]=@DocumentAutomationGroup, [IsThreaded]=@IsThreaded, [isLargeExport]=@isLargeExport, [ReportProperties]=@ReportProperties WHERE [ReportGUID] = @ReportGUID";
    this._cmdUpdate.Parameters.Add("@ReportGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ReportGUID");
    this._cmdUpdate.Parameters.Add("@ReportName", SqlDbType.VarChar, 8000, "ReportName");
    this._cmdUpdate.Parameters.Add("@GroupName", SqlDbType.VarChar, 50, "GroupName");
    this._cmdUpdate.Parameters.Add("@Description", SqlDbType.VarChar, 8000, "Description");
    this._cmdUpdate.Parameters.Add("@Title", SqlDbType.VarChar, 8000, "Title");
    this._cmdUpdate.Parameters.Add("@Published", SqlDbType.Bit, 1, "Published");
    this._cmdUpdate.Parameters.Add("@AllowPrint", SqlDbType.Bit, 1, "AllowPrint");
    this._cmdUpdate.Parameters.Add("@SQL", SqlDbType.Text, 8000, "SQL");
    this._cmdUpdate.Parameters.Add("@Parameters", SqlDbType.Text, -1, "Parameters");
    this._cmdUpdate.Parameters.Add("@ColumnWidth", SqlDbType.VarChar, 8000, "ColumnWidth");
    this._cmdUpdate.Parameters.Add("@SummaryFields", SqlDbType.VarChar, 8000, "SummaryFields");
    this._cmdUpdate.Parameters.Add("@TableNames", SqlDbType.VarChar, 8000, "TableNames");
    this._cmdUpdate.Parameters.Add("@SubTitle", SqlDbType.VarChar, 8000, "SubTitle");
    this._cmdUpdate.Parameters.Add("@MarginTop", SqlDbType.Decimal, 5, "MarginTop");
    this._cmdUpdate.Parameters.Add("@MarginBottom", SqlDbType.Decimal, 5, "MarginBottom");
    this._cmdUpdate.Parameters.Add("@MarginLeft", SqlDbType.Decimal, 5, "MarginLeft");
    this._cmdUpdate.Parameters.Add("@MarginRight", SqlDbType.Decimal, 5, "MarginRight");
    this._cmdUpdate.Parameters.Add("@PaperOrientationPortrait", SqlDbType.Bit, 1, "PaperOrientationPortrait");
    this._cmdUpdate.Parameters.Add("@Layout", SqlDbType.Text, -1, "Layout");
    this._cmdUpdate.Parameters.Add("@AutomationDoc", SqlDbType.Bit, 1, "AutomationDoc");
    this._cmdUpdate.Parameters.Add("@DocumentAutomationGroup", SqlDbType.Bit, 1, "DocumentAutomationGroup");
    this._cmdUpdate.Parameters.Add("@IsThreaded", SqlDbType.Bit, 1, "IsThreaded");
    this._cmdUpdate.Parameters.Add("@isLargeExport", SqlDbType.Bit, 1, "isLargeExport");
    this._cmdUpdate.Parameters.Add("@ReportProperties", SqlDbType.Text, 8000, "ReportProperties");
    this._cmdUpdate.CommandType = CommandType.Text;
    this._cmdUpdate.Connection = this._cn;
    this._cmdDelete = new SqlCommand();
    this._cmdDelete.CommandText = "DELETE FROM dbo.tblAdHocReports WHERE [ReportGUID] = @ReportGUID";
    this._cmdDelete.Parameters.Add("@ReportGUID", SqlDbType.UniqueIdentifier, 16 /*0x10*/, "ReportGUID");
    this._cmdDelete.CommandType = CommandType.Text;
    this._cmdDelete.Connection = this._cn;
    this._da = new SqlDataAdapter();
    this._da.DeleteCommand = this._cmdDelete;
    this._da.SelectCommand = this._cmdSelect;
    this._da.UpdateCommand = this._cmdUpdate;
    this._da.InsertCommand = this._cmdInsert;
  }

  private DataTable SetUpCriteriaDataTable()
  {
    return new DataTable("Criteria")
    {
      Columns = {
        {
          "LineNo",
          typeof (int)
        },
        {
          "Description",
          typeof (string)
        },
        {
          "CriteriaID",
          typeof (int)
        },
        {
          "ParametersCount",
          typeof (int)
        },
        {
          "Parameter00",
          typeof (string)
        },
        {
          "Parameter01",
          typeof (string)
        },
        {
          "Parameter02",
          typeof (string)
        },
        {
          "Parameter03",
          typeof (string)
        },
        {
          "Parameter04",
          typeof (string)
        },
        {
          "Parameter05",
          typeof (string)
        },
        {
          "Parameter06",
          typeof (string)
        },
        {
          "Parameter07",
          typeof (string)
        },
        {
          "Parameter08",
          typeof (string)
        },
        {
          "Parameter09",
          typeof (string)
        },
        {
          "ReturnType1",
          typeof (string)
        },
        {
          "ReturnType2",
          typeof (string)
        },
        {
          "SQLParam1Name",
          typeof (string)
        },
        {
          "SQLParam2Name",
          typeof (string)
        }
      }
    };
  }

  public enum AdHocReportType
  {
    [System.ComponentModel.Description("No Type")] NoType = -1, // 0xFFFFFFFF
    [System.ComponentModel.Description("AdHoc Report")] Report = 0,
    [System.ComponentModel.Description("AdHoc Policy Document")] PolicyDoc = 1,
  }
}
