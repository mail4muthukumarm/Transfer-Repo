// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.MGAReportData
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class MGAReportData : List<MGAReportDataParameter>
{
  private bool _slowButAccurate;
  private bool _addCurrentUserGuid;
  public CommandType CommandType;
  public int CommandTimeout;
  public string CommandText;
  private DataSet _DS;
  private bool ChangesMade;
  private MGAReportDataParameter tmpItem;

  public MGAReportData()
  {
    this._slowButAccurate = false;
    this._addCurrentUserGuid = true;
    this.CommandType = CommandType.StoredProcedure;
    this.CommandTimeout = -1;
    this._DS = new DataSet();
    this.ChangesMade = true;
    this.ChangesMade = true;
  }

  public new MGAReportDataParameter this[int index]
  {
    get => base[index];
    set
    {
      base[index] = value;
      this.ChangesMade = true;
    }
  }

  public MGAReportDataParameter this[string SQLParameterName]
  {
    get
    {
      return this.Find((Predicate<MGAReportDataParameter>) ([SpecialName] (x) => Microsoft.VisualBasic.CompilerServices.Operators.CompareString(x.SQLParameterName, SQLParameterName, false) == 0));
    }
    set
    {
      this.tmpItem = this.Find((Predicate<MGAReportDataParameter>) ([SpecialName] (x) => Microsoft.VisualBasic.CompilerServices.Operators.CompareString(x.SQLParameterName, SQLParameterName, false) == 0));
      this.tmpItem = value;
      this.ChangesMade = true;
    }
  }

  public object get_Value(int index) => this[index].SQLParameterValue;

  public void set_Value(int index, object value)
  {
    this[index].SQLParameterValue = RuntimeHelpers.GetObjectValue(value);
    this.ChangesMade = true;
  }

  public object get_Value(string SQLParameterName)
  {
    return this.Find((Predicate<MGAReportDataParameter>) ([SpecialName] (x) => Microsoft.VisualBasic.CompilerServices.Operators.CompareString(x.SQLParameterName, SQLParameterName, false) == 0)).SQLParameterValue;
  }

  public void set_Value(string SQLParameterName, object value)
  {
    this.Find((Predicate<MGAReportDataParameter>) ([SpecialName] (x) => Microsoft.VisualBasic.CompilerServices.Operators.CompareString(x.SQLParameterName, SQLParameterName, false) == 0)).SQLParameterValue = RuntimeHelpers.GetObjectValue(value);
    this.ChangesMade = true;
  }

  public bool SlowButAccurate
  {
    get => this._slowButAccurate;
    set
    {
      this._slowButAccurate = value;
      this.ChangesMade = true;
    }
  }

  public bool AddCurrentUserGuid
  {
    get => this._addCurrentUserGuid;
    set
    {
      this._addCurrentUserGuid = value;
      this.ChangesMade = true;
    }
  }

  public void AddParameterWithValue(string SQLParameterName, object SQLParameterValue)
  {
    this.Add(new MGAReportDataParameter(SQLParameterName.Trim(), RuntimeHelpers.GetObjectValue(SQLParameterValue)));
    this.ChangesMade = true;
  }

  public void AddParameter(string SQLParameterName)
  {
    this.Add(new MGAReportDataParameter(SQLParameterName.Trim()));
    this.ChangesMade = true;
  }

  public void AddParameters(params string[] SQLParameters)
  {
    // ISSUE: variable of a compiler-generated type
    MGAReportData._Closure\u0024__29\u002D0 closure290_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    MGAReportData._Closure\u0024__29\u002D0 closure290_2 = new MGAReportData._Closure\u0024__29\u002D0(closure290_1);
    // ISSUE: reference to a compiler-generated field
    closure290_2.\u0024VB\u0024Local_SQLParameters = SQLParameters;
    // ISSUE: reference to a compiler-generated field
    int num = Information.UBound((Array) closure290_2.\u0024VB\u0024Local_SQLParameters);
    for (int index = 0; index <= num; ++index)
    {
      // ISSUE: object of a compiler-generated type is created
      // ISSUE: variable of a compiler-generated type
      MGAReportData._Closure\u0024__29\u002D1 closure291 = new MGAReportData._Closure\u0024__29\u002D1(closure291);
      // ISSUE: reference to a compiler-generated field
      closure291.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure290_2;
      // ISSUE: reference to a compiler-generated field
      closure291.\u0024VB\u0024Local__i = index;
      // ISSUE: reference to a compiler-generated method
      if (!this.Exists(new Predicate<MGAReportDataParameter>(closure291._Lambda\u0024__0)))
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        this.Add(new MGAReportDataParameter(closure291.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_SQLParameters[closure291.\u0024VB\u0024Local__i].Trim()));
      }
    }
    this.ChangesMade = true;
  }

  public void AddValues(params object[] SQLValues)
  {
    int num = Information.UBound((Array) SQLValues);
    for (int index1 = 0; index1 <= num; ++index1)
    {
      int index2 = index1;
      if (!Information.IsNothing(RuntimeHelpers.GetObjectValue(SQLValues[index2])))
        this.set_Value(index2, RuntimeHelpers.GetObjectValue(SQLValues[index2]));
    }
    this.ChangesMade = true;
  }

  public DataTable GetDataTable()
  {
    this.GetDataSet();
    return this._DS.Tables[0];
  }

  public DataTable GetDataTable(int Index)
  {
    this.GetDataSet();
    return this._DS.Tables[Index];
  }

  public DataSet GetDataSet()
  {
    DataSet ds;
    if (!this.ChangesMade && this._DS.Tables.Count > 0)
    {
      ds = this._DS;
    }
    else
    {
      SqlCommand selectCommand = new SqlCommand(this.CommandText, new SqlConnection(DefaultDatabase.ConnectionString));
      selectCommand.CommandType = this.CommandType;
      if (this.CommandTimeout >= 0)
        selectCommand.CommandTimeout = this.CommandTimeout;
      selectCommand.Parameters.AddRange(this.PrepareParameters());
      DataSet dataSet = new DataSet();
      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
      try
      {
        DefaultDatabase.DataAdapterFill((DbDataAdapter) sqlDataAdapter, dataSet);
        this._DS = dataSet;
        this.ChangesMade = false;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
        ProjectData.ClearProjectError();
      }
      ds = this._DS;
    }
    return ds;
  }

  private SqlParameter[] PrepareParameters()
  {
    if (this._slowButAccurate)
      this.ScrutinizeParameters();
    List<SqlParameter> sqlParameterList = new List<SqlParameter>();
    try
    {
      foreach (MGAReportDataParameter reportDataParameter in (List<MGAReportDataParameter>) this)
      {
        if (reportDataParameter.IsWorthy && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(reportDataParameter.SQLParameterName.Trim().ToLower(), "@IgnoreThisParameter".ToLower(), false) != 0)
        {
          SqlParameter sqlParameter = new SqlParameter(reportDataParameter.SQLParameterName, reportDataParameter.SQLParameterType);
          if (reportDataParameter.SQLParameterSize > 0)
            sqlParameter.Size = reportDataParameter.SQLParameterSize;
          if (reportDataParameter.SQLParameterPrecision > (byte) 0)
            sqlParameter.Precision = reportDataParameter.SQLParameterPrecision;
          if (reportDataParameter.SQLParameterScale > (byte) 0)
            sqlParameter.Scale = reportDataParameter.SQLParameterScale;
          sqlParameter.Value = RuntimeHelpers.GetObjectValue(reportDataParameter.SQLParameterValue);
          sqlParameterList.Add(sqlParameter);
        }
      }
    }
    finally
    {
      List<MGAReportDataParameter>.Enumerator enumerator;
      enumerator.Dispose();
    }
    if (SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid") && this._addCurrentUserGuid && !CurrentUser.Instance.UserGUID.Equals((object) string.Empty))
      sqlParameterList.Add(new SqlParameter("@CurrentUserGuid", SqlDbType.UniqueIdentifier)
      {
        Value = (object) CurrentUser.Instance.UserGUID
      });
    return sqlParameterList.ToArray();
  }

  private void ScrutinizeParameters()
  {
    SqlConnection connection = new SqlConnection(DefaultDatabase.ConnectionString);
    SqlCommand command = new SqlCommand(this.CommandText, connection);
    command.CommandType = this.CommandType;
    try
    {
      connection.Open();
      SqlCommandBuilder.DeriveParameters(command);
      connection.Close();
      try
      {
        foreach (SqlParameter parameter in command.Parameters)
        {
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: variable of a compiler-generated type
          MGAReportData._Closure\u0024__35\u002D0 closure350 = new MGAReportData._Closure\u0024__35\u002D0(closure350);
          // ISSUE: reference to a compiler-generated field
          closure350.\u0024VB\u0024Local_Parameter = parameter;
          // ISSUE: reference to a compiler-generated method
          int index = this.FindIndex(new Predicate<MGAReportDataParameter>(closure350._Lambda\u0024__0));
          if (index >= 0)
          {
            // ISSUE: reference to a compiler-generated field
            this[index].SQLParameterType = closure350.\u0024VB\u0024Local_Parameter.SqlDbType;
            // ISSUE: reference to a compiler-generated field
            this[index].SQLParameterSize = closure350.\u0024VB\u0024Local_Parameter.Size;
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
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
    }
  }
}
