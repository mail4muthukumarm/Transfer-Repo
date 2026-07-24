// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.DatabaseQuery
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace MGASystems.Common.DataAccess;

[EditorBrowsable(EditorBrowsableState.Never)]
public abstract class DatabaseQuery
{
  private Database _localDatabase;
  private TableFillingEventHandler _fillingHandler;
  private const int SQL_FAILURE_RETRIES = 5;

  [EditorBrowsable(EditorBrowsableState.Never)]
  internal DatabaseQuery(Database db) => this._localDatabase = db;

  public int PerformNonQuery(string queryText)
  {
    return this.PerformNonQuery(false, queryText, (SqlParameter[]) null);
  }

  public int PerformNonQuery(string queryText, params object[] namevalueArgs)
  {
    return this.PerformNonQuery(false, queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public int PerformNonQuery(string queryText, SqlParameter[] sqlParameters)
  {
    return this.PerformNonQuery(false, queryText, sqlParameters);
  }

  public int PerformNonQuery(bool useTransaction, string queryText)
  {
    return this.PerformNonQuery(useTransaction, queryText, (SqlParameter[]) null);
  }

  public int PerformNonQuery(bool useTransaction, string queryText, params object[] namevalueArgs)
  {
    return this.PerformNonQuery(useTransaction, queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public int PerformNonQuery(bool useTransaction, string queryText, SqlParameter[] sqlParameters)
  {
    this.Command.CommandType = this.CommandType;
    this.Command.CommandText = queryText;
    this.Command.Parameters.Clear();
    if (sqlParameters != null)
    {
      SqlParameter[] sqlParameterArray = sqlParameters;
      int index = 0;
      while (index < sqlParameterArray.Length)
      {
        this.Command.Parameters.Add(sqlParameterArray[index]);
        checked { ++index; }
      }
    }
    return !useTransaction ? Conversions.ToInteger(this.PerformQuerySet(new Database.QuerySetEventHandler(this.PerformNonQueryHandler))) : Conversions.ToInteger(this.PerformTransactionedQuerySet(new Database.TransactionQuerySetEventHandler(this.PerformNonQueryHandlerTransactioned)));
  }

  private object PerformNonQueryHandler(object sender, QuerySetHandlerEventArgs e)
  {
    return (object) this.PerformNonQueryWithFailureRetry();
  }

  private object PerformNonQueryHandlerTransactioned(object sender, QuerySetHandlerEventArgs e)
  {
    try
    {
      this.Command.Transaction = e.Transaction;
      return (object) this.PerformNonQueryWithFailureRetry();
    }
    finally
    {
      this.Command.Transaction = (SqlTransaction) null;
    }
  }

  private int PerformNonQueryWithFailureRetry()
  {
    return Database.PerformNonQueryWithFailureRetry(this.Command);
  }

  public object PerformScalarQuery(string queryText)
  {
    return this.PerformScalarQuery(queryText, (SqlParameter[]) null);
  }

  public object PerformScalarQuery(string queryText, params object[] namevalueArgs)
  {
    return this.PerformScalarQuery(queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public object PerformScalarQuery(string queryText, SqlParameter[] sqlParameters)
  {
    this.Command.CommandType = this.CommandType;
    this.Command.CommandText = queryText;
    this.Command.Parameters.Clear();
    if (sqlParameters != null)
    {
      SqlParameter[] sqlParameterArray = sqlParameters;
      int index = 0;
      while (index < sqlParameterArray.Length)
      {
        this.Command.Parameters.Add(sqlParameterArray[index]);
        checked { ++index; }
      }
    }
    return this.PerformQuerySet(new Database.QuerySetEventHandler(this.PerformScalarQueryHandler));
  }

  private object PerformScalarQueryHandler(object sender, QuerySetHandlerEventArgs e)
  {
    return this.PerformScalarQueryWithFailureRetry();
  }

  private object PerformScalarQueryWithFailureRetry() => Database.PerformScalarQuery(this.Command);

  public Guid PerformScalarQueryGuid(string queryText)
  {
    return this.PerformScalarQueryGuid(queryText, (SqlParameter[]) null);
  }

  public Guid PerformScalarQueryGuid(string queryText, params object[] namevalueArgs)
  {
    return this.PerformScalarQueryGuid(queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public Guid PerformScalarQueryGuid(string queryText, SqlParameter[] sqlParameters)
  {
    return (Guid) (RuntimeHelpers.GetObjectValue(this.PerformScalarQuery(queryText, sqlParameters)) ?? throw new InvalidCastException("Expected Guid but got no result."));
  }

  public DateTime PerformScalarQueryDate(string queryText)
  {
    return this.PerformScalarQueryDate(queryText, (SqlParameter[]) null);
  }

  public DateTime PerformScalarQueryDate(string queryText, params object[] namevalueArgs)
  {
    return this.PerformScalarQueryDate(queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public DateTime PerformScalarQueryDate(string queryText, SqlParameter[] sqlParameters)
  {
    return (DateTime) this.PerformScalarQuery(queryText, sqlParameters);
  }

  public int PerformScalarQueryInt(string queryText)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.PerformScalarQuery(queryText));
    return Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(objectValue)) ? Conversions.ToInteger(objectValue) : throw new InvalidCastException();
  }

  public int PerformScalarQueryInt(string queryText, params object[] namevalueArgs)
  {
    return this.PerformScalarQueryInt(queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public int PerformScalarQueryInt(string queryText, SqlParameter[] sqlParameters)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.PerformScalarQuery(queryText, sqlParameters));
    return !Database.IsValueNull(RuntimeHelpers.GetObjectValue(objectValue)) ? Conversions.ToInteger(objectValue) : throw new DatabaseException(MGASystems.Common.SR.GetString("DB_NullScalarQuery"));
  }

  public int PerformScalarQueryInt(string queryText, int nullValue)
  {
    return this.PerformScalarQueryInt(queryText, nullValue, (SqlParameter[]) null);
  }

  public int PerformScalarQueryInt(string queryText, int nullValue, params object[] namevalueArgs)
  {
    return this.PerformScalarQueryInt(queryText, nullValue, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public int PerformScalarQueryInt(string queryText, int nullValue, SqlParameter[] sqlParameters)
  {
    return Database.IsNull(RuntimeHelpers.GetObjectValue(this.PerformScalarQuery(queryText, sqlParameters)), nullValue);
  }

  public bool PerformScalarQueryBool(string queryText)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.PerformScalarQuery(queryText));
    return objectValue != DBNull.Value && objectValue != null ? Conversions.ToBoolean(objectValue) : throw new InvalidCastException();
  }

  public bool PerformScalarQueryBool(string queryText, params object[] namevalueArgs)
  {
    return this.PerformScalarQueryBool(queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public bool PerformScalarQueryBool(string queryText, SqlParameter[] sqlParameters)
  {
    object objectValue = RuntimeHelpers.GetObjectValue(this.PerformScalarQuery(queryText, sqlParameters));
    return objectValue != DBNull.Value && objectValue != null ? Conversions.ToBoolean(objectValue) : throw new InvalidCastException();
  }

  public bool PerformScalarQueryBool(string queryText, bool nullValue)
  {
    return this.PerformScalarQueryBool(queryText, nullValue, (SqlParameter[]) null);
  }

  public bool PerformScalarQueryBool(
    string queryText,
    bool nullValue,
    params object[] namevalueArgs)
  {
    return this.PerformScalarQueryBool(queryText, nullValue, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public bool PerformScalarQueryBool(
    string queryText,
    bool nullValue,
    SqlParameter[] sqlParameters)
  {
    return Database.IsNull(RuntimeHelpers.GetObjectValue(this.PerformScalarQuery(queryText, sqlParameters)), nullValue);
  }

  public string PerformScalarQueryString(string queryText)
  {
    return (string) this.PerformScalarQuery(queryText);
  }

  public string PerformScalarQueryString(string queryText, params object[] namevalueArgs)
  {
    if (namevalueArgs.Length > 0 && namevalueArgs[0] is string && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(namevalueArgs[0]), string.Empty, false) == 0)
      throw new InvalidOperationException("PerformScalarQueryString namevalue args must be even in number");
    return this.PerformScalarQueryString(queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public string PerformScalarQueryString(string queryText, SqlParameter[] sqlParameters)
  {
    return (string) this.PerformScalarQuery(queryText, sqlParameters);
  }

  public DataSet PerformAdHocQuery(string queryText)
  {
    return this.PerformAdHocQuery(queryText, new object[2]);
  }

  public DataSet PerformAdHocQuery(string queryText, params object[] namevalueArgs)
  {
    return this.PerformAdHocQuery(queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public DataSet PerformAdHocQuery(string queryText, SqlParameter[] sqlParameters)
  {
    this.Command.CommandType = this.CommandType;
    this.Command.CommandText = queryText;
    this.Command.Parameters.Clear();
    if (sqlParameters != null)
    {
      SqlParameter[] sqlParameterArray = sqlParameters;
      int index = 0;
      while (index < sqlParameterArray.Length)
      {
        this.Command.Parameters.Add(sqlParameterArray[index]);
        checked { ++index; }
      }
    }
    return (DataSet) this.PerformQuerySet(new Database.QuerySetEventHandler(this.PerformAdHocQuery));
  }

  private object PerformAdHocQuery(object sender, QuerySetHandlerEventArgs e)
  {
    DataSet ds = new DataSet();
    SqlDataAdapter dataAdapter = (SqlDataAdapter) null;
    try
    {
      ds.EnforceConstraints = false;
      dataAdapter = new SqlDataAdapter(this.Command);
      Database.SafeDataAdapterFill(dataAdapter, ds);
      return (object) ds;
    }
    finally
    {
      if (dataAdapter != null)
      {
        dataAdapter.SelectCommand = (SqlCommand) null;
        dataAdapter.Dispose();
      }
      ds.EnforceConstraints = true;
    }
  }

  public void PerformTableQuery(string queryText, DataTable tableToFill)
  {
    this.PerformTableQuery(queryText, tableToFill, (SqlParameter[]) null, (TableFillingEventHandler) null);
  }

  public void PerformTableQuery(
    string queryText,
    DataTable tableToFill,
    params object[] namevalueArgs)
  {
    this.PerformTableQuery(queryText, tableToFill, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public void PerformTableQuery(
    string queryText,
    DataTable tableToFill,
    SqlParameter[] sqlParameters)
  {
    this.PerformTableQuery(queryText, tableToFill, sqlParameters, (TableFillingEventHandler) null);
  }

  public void PerformTableQuery(
    string queryText,
    DataTable tableToFill,
    SqlParameter[] sqlParameters,
    TableFillingEventHandler fillingHandler)
  {
    if (tableToFill == null)
      throw new ArgumentNullException(nameof (tableToFill));
    this.Command.CommandType = this.CommandType;
    this.Command.CommandText = queryText;
    this.Command.Parameters.Clear();
    if (sqlParameters != null)
    {
      SqlParameter[] sqlParameterArray = sqlParameters;
      int index = 0;
      while (index < sqlParameterArray.Length)
      {
        this.Command.Parameters.Add(sqlParameterArray[index]);
        checked { ++index; }
      }
    }
    this._fillingHandler = fillingHandler;
    DataTable dataTable = (DataTable) this.PerformQuerySet(new Database.QuerySetEventHandler(this.PerformTableQueryHandler));
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) dataTable.Columns)
      {
        if (!tableToFill.Columns.Contains(column.ColumnName))
          tableToFill.Columns.Add(column.ColumnName, column.DataType);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (DataRow row in dataTable.Rows)
        tableToFill.ImportRow(row);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    tableToFill.AcceptChanges();
  }

  public DataTable PerformTableQuery(string queryText)
  {
    SqlParameter[] sqlParameters = (SqlParameter[]) null;
    return this.PerformTableQuery(queryText, sqlParameters, (TableFillingEventHandler) null);
  }

  public DataTable PerformTableQuery(string queryText, params object[] namevalueArgs)
  {
    return this.PerformTableQuery(queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public DataTable PerformTableQuery(string queryText, SqlParameter[] sqlParameters)
  {
    return this.PerformTableQuery(queryText, sqlParameters, (TableFillingEventHandler) null);
  }

  public DataTable PerformTableQuery(
    string queryText,
    SqlParameter[] sqlParameters,
    TableFillingEventHandler fillingHandler)
  {
    SqlCommand command = this.Command;
    command.CommandType = this.CommandType;
    command.CommandText = queryText;
    command.Parameters.Clear();
    if (sqlParameters != null)
    {
      SqlParameter[] sqlParameterArray = sqlParameters;
      int index = 0;
      while (index < sqlParameterArray.Length)
      {
        this.Command.Parameters.Add(sqlParameterArray[index]);
        checked { ++index; }
      }
    }
    this._fillingHandler = fillingHandler;
    return (DataTable) this.PerformQuerySet(new Database.QuerySetEventHandler(this.PerformTableQueryHandler));
  }

  private object PerformTableQueryHandler(object sender, QuerySetHandlerEventArgs e)
  {
    SqlDataReader sqlDataReader = (SqlDataReader) null;
    DataTable dataTable = new DataTable();
    this.Command.CommandTimeout = 300;
    int num1 = 0;
    do
    {
      try
      {
        if (this.Command.Connection.State == ConnectionState.Closed)
          Database.OpenConnection(this.Command.Connection);
        Utility.WriteLegacyCommandTextToLog(nameof (PerformTableQueryHandler), this.Command.CommandText, false);
        sqlDataReader = this.Command.ExecuteReader(CommandBehavior.SingleResult);
        int num2 = sqlDataReader.FieldCount - 1;
        int num3 = num2;
        for (int i = 0; i <= num3; ++i)
          dataTable.Columns.Add(sqlDataReader.GetName(i), sqlDataReader.GetFieldType(i));
        if (sqlDataReader.HasRows)
        {
          int currentRow = 0;
          dataTable.BeginLoadData();
          object[] values = new object[num2 + 1];
          while (sqlDataReader.Read())
          {
            sqlDataReader.GetValues(values);
            DataRow row = dataTable.Rows.Add(values);
            if (this._fillingHandler != null)
            {
              TableFillingEventArgs e1 = new TableFillingEventArgs((long) currentRow, row);
              this._fillingHandler((object) this, e1);
              ++currentRow;
              if (e1.StopFill)
                break;
            }
          }
          dataTable.EndLoadData();
          break;
        }
        break;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (!Database.IsRetryableException(ex) || num1 == 5)
        {
          if (num1 == 5)
            throw new DatabaseRetryException($"Could not complete PerformTableQueryHandler after {(num1 + 1).ToString()} retries.");
          throw;
        }
        Thread.Sleep(1000);
        dataTable.Columns.Clear();
        dataTable.Rows.Clear();
        ProjectData.ClearProjectError();
      }
      finally
      {
        if (sqlDataReader != null)
        {
          sqlDataReader.Close();
          sqlDataReader = (SqlDataReader) null;
        }
        Utility.Dump((DbCommand) this.Command);
        Utility.WriteLegacyCommandTextToLog(nameof (PerformTableQueryHandler), this.Command.CommandText, true);
      }
      ++num1;
    }
    while (num1 <= 4);
    return (object) dataTable;
  }

  public DataRow PerformRowQuery(string queryText)
  {
    return this.PerformRowQuery(queryText, (SqlParameter[]) null);
  }

  public DataRow PerformRowQuery(string queryText, params object[] namevalueArgs)
  {
    return this.PerformRowQuery(queryText, Database.ParseNamevalueArgs(namevalueArgs));
  }

  public DataRow PerformRowQuery(string queryText, params SqlParameter[] sqlParameters)
  {
    this.Command.CommandType = this.CommandType;
    this.Command.CommandText = queryText;
    this.Command.Parameters.Clear();
    if (sqlParameters != null)
    {
      SqlParameter[] sqlParameterArray = sqlParameters;
      int index = 0;
      while (index < sqlParameterArray.Length)
      {
        this.Command.Parameters.Add(sqlParameterArray[index]);
        checked { ++index; }
      }
    }
    return (DataRow) this.PerformQuerySet(new Database.QuerySetEventHandler(this.PerformRowQueryHandler));
  }

  private object PerformRowQueryHandler(object sender, QuerySetHandlerEventArgs e)
  {
    SqlDataReader sqlDataReader = (SqlDataReader) null;
    int num1 = 0;
    object obj;
    do
    {
      try
      {
        try
        {
          if (this.Command.Connection.State == ConnectionState.Closed)
            Database.OpenConnection(this.Command.Connection);
          Utility.WriteLegacyCommandTextToLog(nameof (PerformRowQueryHandler), this.Command.CommandText, false);
          sqlDataReader = this.Command.ExecuteReader();
          DataTable dataTable = (DataTable) null;
          if (sqlDataReader.HasRows)
          {
            dataTable = new DataTable();
            dataTable.BeginLoadData();
            int num2 = sqlDataReader.FieldCount - 1;
            int num3 = num2;
            for (int i = 0; i <= num3; ++i)
              dataTable.Columns.Add(sqlDataReader.GetName(i), sqlDataReader.GetFieldType(i));
            object[] values = new object[num2 + 1];
            while (sqlDataReader.Read())
            {
              sqlDataReader.GetValues(values);
              dataTable.Rows.Add(values);
            }
            dataTable.EndLoadData();
          }
          obj = dataTable == null || dataTable.Rows.Count <= 0 ? (object) null : (object) dataTable.Rows[0];
          goto label_23;
        }
        finally
        {
          if (sqlDataReader != null)
          {
            sqlDataReader.Close();
            sqlDataReader = (SqlDataReader) null;
          }
          Utility.Dump((DbCommand) this.Command);
          Utility.WriteLegacyCommandTextToLog("PerforRowQueryHandler", this.Command.CommandText, true);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (!Database.IsRetryableException(ex) || num1 == 5)
        {
          if (num1 == 5)
            throw new DatabaseRetryException($"Could not complete PerformRowQueryHandler after {(num1 + 1).ToString()} retries.");
          throw;
        }
        Thread.Sleep(1000);
        ProjectData.ClearProjectError();
      }
      ++num1;
    }
    while (num1 <= 4);
    obj = (object) null;
label_23:
    return obj;
  }

  protected abstract CommandType CommandType { get; }

  protected SqlCommand Command => this._localDatabase.Command;

  protected object PerformQuerySet(Database.QuerySetEventHandler querySetHandler)
  {
    return this._localDatabase.PerformQuerySet(querySetHandler);
  }

  protected object PerformTransactionedQuerySet(
    Database.TransactionQuerySetEventHandler querySetHandler)
  {
    return this._localDatabase.PerformTransactionQuerySet(querySetHandler);
  }
}
