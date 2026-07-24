// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.Database
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Web;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

[Obsolete("Use MGASystems.Data.DefaultDatabase instead")]
public sealed class Database : IDisposable
{
  private static bool _initialized;
  private static string _connectionString;
  private static Control _uiContext;
  private SqlConnection _connection;
  private SqlCommand _command;
  private DatabaseQueryMultithreadedText _QueryTextMultithreaded;
  private DatabaseQueryMultithreadedSP _QuerySPMultithreaded;
  private DatabaseQueryMultithreadedDataAdapter _daQueryMultithreaded;
  private static Database _database;
  private DatabaseQueryText _QueryText;
  private DatabaseQuerySP _QuerySP;
  internal const int SQL_FAILURE_RETRIES = 5;

  private void Cleanup()
  {
    if (this._command != null)
    {
      this._command.Dispose();
      this._command = (SqlCommand) null;
    }
    if (this._connection != null)
    {
      this._connection.Close();
      this._connection.Dispose();
      this._connection = (SqlConnection) null;
    }
    if (this._QueryTextMultithreaded == null)
      return;
    this._QueryTextMultithreaded = (DatabaseQueryMultithreadedText) null;
  }

  public void Dispose()
  {
    this.Cleanup();
    GC.SuppressFinalize((object) this);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public Database()
  {
    this._connection = new SqlConnection(Database._connectionString);
    this._command = new SqlCommand();
    this._command.Connection = this._connection;
    this._command.CommandTimeout = 300;
  }

  public static bool IsRetryableException(Exception ex)
  {
    bool flag;
    switch (ex)
    {
      case null:
        throw new ArgumentNullException(nameof (ex));
      case SqlException _:
        flag = ex.Message.Contains("General network error") || ex.Message.Contains("Timeout expired") || ex.Message.Contains("deadlocked on lock") || ex.Message.Contains("SQL Server does not exist or access denied") || ex.Message.Contains("Internal connection fatal error") || ex.Message.Contains("A transport-level error has occurred") || ex.Message.Contains("establishing a connection to the server") || ex.Message.Contains("Could not continue scan with NOLOCK") || ex.Message.Contains("The specified network name is no longer available");
        break;
      case InvalidOperationException _:
        flag = ex.Message.Contains("Timeout expired") || ex.Message.Contains("Internal connection fatal error") || ex.Message.Contains("Invalid attempt to Read when reader is closed");
        break;
      default:
        flag = false;
        break;
    }
    return flag;
  }

  public static bool IsValueNull(object value)
  {
    return value == null || value.Equals((object) DBNull.Value);
  }

  public static object IsNull(object value, object nullValue)
  {
    return !Database.IsValueNull(RuntimeHelpers.GetObjectValue(value)) ? value : nullValue;
  }

  public static int IsNull(object value, int nullValue)
  {
    return value == null || value.Equals((object) DBNull.Value) ? nullValue : Conversions.ToInteger(value);
  }

  public static double IsNull(object value, double nullValue)
  {
    return value == null || value.Equals((object) DBNull.Value) ? nullValue : Conversions.ToDouble(value);
  }

  public static Decimal IsNull(object value, Decimal nullValue)
  {
    return value == null || value.Equals((object) DBNull.Value) ? nullValue : Conversions.ToDecimal(value);
  }

  public static float IsNull(object value, float nullValue)
  {
    return value == null || value.Equals((object) DBNull.Value) ? nullValue : Conversions.ToSingle(value);
  }

  public static long IsNull(object value, long nullValue)
  {
    return value == null || value.Equals((object) DBNull.Value) ? nullValue : Conversions.ToLong(value);
  }

  public static string IsNull(object value, string nullValue)
  {
    return value == null || value.Equals((object) DBNull.Value) ? nullValue : value.ToString();
  }

  public static Guid IsNull(object value, Guid nullValue)
  {
    return value == null || value.Equals((object) DBNull.Value) ? nullValue : (Guid) value;
  }

  public static bool IsNull(object value, bool nullValue)
  {
    return value == null || value.Equals((object) DBNull.Value) ? nullValue : Conversions.ToBoolean(value);
  }

  public static byte IsNull(object value, byte nullValue)
  {
    return value == null || value.Equals((object) DBNull.Value) ? nullValue : Conversions.ToByte(value);
  }

  public static DateTime IsNull(object value, DateTime nullValue)
  {
    return value == null || value.Equals((object) DBNull.Value) ? nullValue : Conversions.ToDate(value);
  }

  [Obsolete("Use DbCommand version instead.")]
  public static void InitializeParameters(SqlCommand command, params object[] nameValueArgs)
  {
    Database.InitializeParameters((DbCommand) command, nameValueArgs);
  }

  public static void InitializeParameters(DbCommand command, params object[] nameValueArgs)
  {
    if (command == null)
      throw new ArgumentNullException(nameof (command));
    command.Parameters.Clear();
    DbParameter[] namevalueArgs = (DbParameter[]) Database.ParseNamevalueArgs(nameValueArgs);
    int index = 0;
    while (index < namevalueArgs.Length)
    {
      DbParameter dbParameter = namevalueArgs[index];
      command.Parameters.Add((object) dbParameter);
      checked { ++index; }
    }
  }

  public static void InitializeCommand(
    SqlCommand command,
    SqlConnection connection,
    CommandType commandType,
    SqlTransaction transaction,
    string commandText,
    params object[] nameValueArgs)
  {
    if (command == null)
      throw new ArgumentNullException(nameof (command));
    command.Transaction = transaction;
    Database.InitializeCommand(command, connection, commandType, commandText, nameValueArgs);
  }

  public static void InitializeCommand(
    SqlCommand command,
    SqlConnection connection,
    string commandText,
    params object[] nameValueArgs)
  {
    if (command == null)
      throw new ArgumentNullException(nameof (command));
    Database.InitializeCommand(command, connection, command.CommandType, commandText, nameValueArgs);
  }

  public static void InitializeCommand(
    SqlCommand command,
    string commandText,
    params object[] nameValueArgs)
  {
    if (command == null)
      throw new ArgumentNullException(nameof (command));
    Database.InitializeCommand(command, command.Connection, command.CommandType, commandText, nameValueArgs);
  }

  public static void InitializeCommand(
    SqlCommand command,
    SqlConnection connection,
    CommandType commandType,
    string commandText,
    params object[] nameValueArgs)
  {
    if (command == null)
      throw new ArgumentNullException(nameof (command));
    command.Parameters.Clear();
    if (command.CommandType != commandType)
      command.CommandType = commandType;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(command.CommandText, commandText, false) != 0)
      command.CommandText = commandText;
    if (command.Connection != connection)
      command.Connection = connection;
    SqlParameter[] namevalueArgs = Database.ParseNamevalueArgs(nameValueArgs);
    int index = 0;
    while (index < namevalueArgs.Length)
    {
      SqlParameter sqlParameter = namevalueArgs[index];
      command.Parameters.Add(sqlParameter);
      checked { ++index; }
    }
  }

  public static void OpenConnection(SqlConnection cn)
  {
    if (cn == null)
      throw new ArgumentNullException(nameof (cn));
    if (cn.State == ConnectionState.Closed || cn.State == ConnectionState.Broken)
    {
      int num = 0;
      do
      {
        try
        {
          cn.Open();
          return;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          if (!Database.IsRetryableException(ex) || num == 4)
          {
            if (num == 4)
            {
              cn.Close();
              throw new DatabaseRetryException($"Could not open a connection to the database after {(num + 1).ToString()} retries.");
            }
            cn.Close();
            throw;
          }
          Thread.Sleep(1000);
          ProjectData.ClearProjectError();
        }
        ++num;
      }
      while (num <= 4);
      throw new InvalidOperationException("No code paths should get here.");
    }
  }

  public static SqlTransaction StartTransaction(SqlConnection cn)
  {
    if (cn == null)
      throw new ArgumentNullException(nameof (cn));
    if (cn.State == ConnectionState.Closed)
      Database.OpenConnection(cn);
    int num = 0;
    SqlTransaction sqlTransaction;
    do
    {
      try
      {
        Database.OpenConnection(cn);
        sqlTransaction = cn.BeginTransaction();
        goto label_14;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (!Database.IsRetryableException(ex) || num == 4)
        {
          if (num == 4)
            throw new DatabaseRetryException($"Could not open a connection to the database after {(num + 1).ToString()} retries.");
          throw;
        }
        Thread.Sleep(1000);
        ProjectData.ClearProjectError();
      }
      ++num;
    }
    while (num <= 4);
    sqlTransaction = (SqlTransaction) null;
label_14:
    return sqlTransaction;
  }

  public static object PerformScalarQuery(SqlCommand cmd)
  {
    if (cmd == null)
      throw new ArgumentNullException(nameof (cmd));
    bool flag = cmd.Transaction != null;
    int num = 0;
    do
    {
      try
      {
        Utility.WriteLegacyCommandTextToLog(nameof (PerformScalarQuery), cmd.CommandText, false);
        return cmd.ExecuteScalar();
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        Exception ex2 = ex1;
        if (flag && cmd.Transaction == null)
          throw;
        if (!Database.IsRetryableException(ex2) || num == 4)
        {
          if (num == 4)
            throw new DatabaseRetryException($"Could not complete PerformScalarQueryWithFailureRetry after {(num + 1).ToString()} retries.");
          throw;
        }
        Thread.Sleep(1000);
        if (cmd.Connection.State == ConnectionState.Closed || cmd.Connection.State == ConnectionState.Broken)
        {
          if (flag)
            throw;
          Database.OpenConnection(cmd.Connection);
        }
        ProjectData.ClearProjectError();
      }
      finally
      {
        Utility.Dump((DbCommand) cmd);
        Utility.WriteLegacyCommandTextToLog(nameof (PerformScalarQuery), cmd.CommandText, true);
      }
      ++num;
    }
    while (num <= 4);
    throw new InvalidOperationException("No code paths should get here.");
  }

  public static int PerformNonQueryWithFailureRetry(SqlCommand cmd)
  {
    if (cmd == null)
      throw new ArgumentNullException(nameof (cmd));
    bool flag = cmd.Transaction != null;
    int num = 0;
    do
    {
      try
      {
        Utility.WriteLegacyCommandTextToLog("PerformNonQueryWithRetry", cmd.CommandText, false);
        return cmd.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (!Database.IsRetryableException(ex) || num == 4)
        {
          if (num == 4)
            throw new DatabaseRetryException($"Could not complete PerformNonQueryWithFailureRetry after {(num + 1).ToString()} retries.");
          throw;
        }
        Thread.Sleep(1000);
        if (cmd.Connection.State == ConnectionState.Closed || cmd.Connection.State == ConnectionState.Broken)
        {
          if (flag)
            throw;
          Database.OpenConnection(cmd.Connection);
        }
        else if (cmd.Transaction == null && flag)
          throw;
        ProjectData.ClearProjectError();
      }
      finally
      {
        Utility.Dump((DbCommand) cmd);
        Utility.WriteLegacyCommandTextToLog("PerformNonQueryWithRetry", cmd.CommandText, true);
      }
      ++num;
    }
    while (num <= 4);
    throw new InvalidOperationException("No code paths should get here.");
  }

  public static void SafeDataAdapterFill(SqlDataAdapter dataAdapter, DataSet ds)
  {
    if (dataAdapter == null)
      throw new ArgumentNullException(nameof (dataAdapter));
    if (ds == null)
      throw new ArgumentNullException(nameof (ds));
    dataAdapter.SelectCommand.CommandTimeout = 300;
    bool enforceConstraints = ds.EnforceConstraints;
    int num = 0;
    do
    {
      try
      {
        ds.EnforceConstraints = false;
        Utility.WriteLegacyCommandTextToLog(nameof (SafeDataAdapterFill), dataAdapter.SelectCommand.CommandText, false);
        dataAdapter.Fill(ds);
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (!Database.IsRetryableException(ex) || num == 4)
        {
          if (num == 4)
            throw new DatabaseRetryException($"Could not fill the datatable after {(num + 1).ToString()} retries.");
          throw;
        }
        Thread.Sleep(1000);
        ProjectData.ClearProjectError();
      }
      finally
      {
        Utility.Dump((DbCommand) dataAdapter.SelectCommand);
        Utility.WriteLegacyCommandTextToLog(nameof (SafeDataAdapterFill), dataAdapter.SelectCommand.CommandText, true);
        if (enforceConstraints)
          ds.EnforceConstraints = true;
      }
      ++num;
    }
    while (num <= 4);
    throw new InvalidOperationException("No code paths should get here.");
  }

  public static void SafeDataAdapterUpdate(SqlDataAdapter dataAdapter, DataTable table)
  {
    if (table == null)
      throw new ArgumentNullException(nameof (table));
    int count = table.Rows.Count;
    if (dataAdapter == null)
      throw new ArgumentNullException(nameof (dataAdapter));
    dataAdapter.SelectCommand.CommandTimeout = 300;
    int num = 0;
    do
    {
      try
      {
        dataAdapter.Update(table);
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (!Database.IsRetryableException(ex) || num == 4 || count != table.Rows.Count)
        {
          if (num == 4)
            throw new DatabaseRetryException($"Could not update the database after {(num + 1).ToString()} retries.");
          throw;
        }
        Thread.Sleep(1000);
        ProjectData.ClearProjectError();
      }
      ++num;
    }
    while (num <= 4);
    throw new InvalidOperationException("No code paths should get here.");
  }

  public static void SafeDataAdapterFill(SqlDataAdapter dataAdapter, DataTable table)
  {
    if (dataAdapter == null)
      throw new ArgumentNullException(nameof (dataAdapter));
    if (table == null)
      throw new ArgumentNullException(nameof (table));
    int count = table.Rows.Count;
    int num = 0;
    do
    {
      try
      {
        Utility.WriteLegacyCommandTextToLog(nameof (SafeDataAdapterFill), dataAdapter.SelectCommand.CommandText, false);
        dataAdapter.Fill(table);
        return;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        if (!Database.IsRetryableException(ex) || num == 4 || count != table.Rows.Count)
        {
          if (num == 4)
            throw new DatabaseRetryException($"Could not fill the datatable after {(num + 1).ToString()} retries.");
          throw;
        }
        Thread.Sleep(1000);
        ProjectData.ClearProjectError();
      }
      finally
      {
        Utility.Dump((DbCommand) dataAdapter.SelectCommand);
        Utility.WriteLegacyCommandTextToLog(nameof (SafeDataAdapterFill), dataAdapter.SelectCommand.CommandText, true);
      }
      ++num;
    }
    while (num <= 4);
    throw new InvalidOperationException("No code paths should get here.");
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  internal static SqlParameter[] ParseNamevalueArgs(params object[] nameValueArgs)
  {
    List<SqlParameter> sqlParameterList = new List<SqlParameter>();
    bool flag = true;
    string parameterName = string.Empty;
    int num = nameValueArgs.Length - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (flag)
        parameterName = nameValueArgs[index] is string ? Conversions.ToString(nameValueArgs[index]) : throw new DatabaseException(MGASystems.Common.SR.GetString("DB_ArgMustBeString"));
      else
        sqlParameterList.Add(new SqlParameter(parameterName, RuntimeHelpers.GetObjectValue(Database.IsNull(RuntimeHelpers.GetObjectValue(nameValueArgs[index]), (object) DBNull.Value))));
      flag = !flag;
    }
    return sqlParameterList.Count <= 0 ? (SqlParameter[]) null : sqlParameterList.ToArray();
  }

  public object PerformQuerySet(Database.QuerySetEventHandler querySetHandler)
  {
    return this.PerformQuerySet(querySetHandler, (object[]) null);
  }

  public object PerformQuerySet(Database.QuerySetEventHandler querySetHandler, object[] args)
  {
    bool flag = false;
    if (querySetHandler == null)
      throw new ArgumentNullException(nameof (querySetHandler));
    try
    {
      int num = 0;
      do
      {
        if (this._connection.State == ConnectionState.Closed || this._connection.State == ConnectionState.Broken)
        {
          try
          {
            Database.OpenConnection(this._connection);
            flag = true;
            break;
          }
          catch (SqlException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            if (!Database.IsRetryableException((Exception) ex) || num == 4)
            {
              if (num == 4)
                throw new DatabaseRetryException($"Could not open a connection the database after {(num + 1).ToString()} retries.");
              throw;
            }
            Thread.Sleep(1000);
            ProjectData.ClearProjectError();
          }
          catch (InvalidOperationException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            if (num == 4)
            {
              if (num == 4)
                throw new DatabaseRetryException($"Could not open a connection the database after {(num + 1).ToString()} retries.");
              throw;
            }
            Thread.Sleep(1000);
            ProjectData.ClearProjectError();
          }
        }
        ++num;
      }
      while (num <= 4);
      QuerySetHandlerEventArgs e = new QuerySetHandlerEventArgs(this._connection, (SqlTransaction) null, this, args);
      return querySetHandler((object) this, e);
    }
    finally
    {
      if (flag)
        this._connection.Close();
    }
  }

  public object PerformTransactionQuerySet(
    Database.TransactionQuerySetEventHandler querySetHandler)
  {
    return this.PerformTransactionQuerySet(querySetHandler, (object[]) null);
  }

  public object PerformTransactionQuerySet(
    Database.TransactionQuerySetEventHandler querySetHandler,
    object[] args)
  {
    if (querySetHandler == null)
      throw new ArgumentNullException(nameof (querySetHandler));
    SqlTransaction t = (SqlTransaction) null;
    object obj = (object) null;
    int num = 0;
    do
    {
      bool flag;
      try
      {
        if (this._connection.State == ConnectionState.Closed)
        {
          Database.OpenConnection(this._connection);
          flag = true;
        }
        t = this._connection.BeginTransaction();
        this._command.Transaction = t;
        obj = RuntimeHelpers.GetObjectValue(querySetHandler((object) this, new QuerySetHandlerEventArgs(this._connection, t, this, args)));
        t.Commit();
        break;
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        if (!Database.IsRetryableException(ex1) || num == 4)
        {
          try
          {
            t.Rollback();
          }
          catch (InvalidOperationException ex2)
          {
            ProjectData.SetProjectError((Exception) ex2);
            ProjectData.ClearProjectError();
          }
          if (num == 4)
            throw new DatabaseRetryException($"Could not complete PerformTransactionQuerySet after {(num + 1).ToString()} retries.");
          throw;
        }
        Thread.Sleep(1000);
        ProjectData.ClearProjectError();
      }
      finally
      {
        this._command.Transaction = (SqlTransaction) null;
        t?.Dispose();
        if (flag)
        {
          this._connection.Close();
          flag = false;
        }
      }
      ++num;
    }
    while (num <= 4);
    return obj;
  }

  public event Database.RowUpdatedEventHandler RowUpdated;

  public void UpdateWithProgress(SqlDataAdapter da, DataTable dt)
  {
    if (da == null)
      throw new ArgumentNullException(nameof (da));
    DataTable dataTable = dt != null ? dt.GetChanges() : throw new ArgumentNullException(nameof (dt));
    if (dataTable == null)
      return;
    int count = dataTable.Rows.Count;
    for (int index = dataTable.Rows.Count - 1; index >= 0; index += -1)
    {
      int progress;
      ++progress;
      DataRow[] dataRows = new DataRow[1]
      {
        dataTable.Rows[index]
      };
      da.Update(dataRows);
      // ISSUE: reference to a compiler-generated field
      Database.RowUpdatedEventHandler rowUpdatedEvent = this.RowUpdatedEvent;
      if (rowUpdatedEvent != null)
        rowUpdatedEvent((object) this, new Database.UpdateWithProgressEventArgs(count, progress));
    }
  }

  public string ConnectionString
  {
    get
    {
      return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Database._connectionString, string.Empty, false) != 0 ? Database._connectionString : throw new DatabaseException("Connection String is Empty, please call database.Initialize");
    }
  }

  public DatabaseQueryMultithreadedText QueryMultithreadedText
  {
    get
    {
      if (this._QueryTextMultithreaded == null)
        this._QueryTextMultithreaded = new DatabaseQueryMultithreadedText();
      return this._QueryTextMultithreaded;
    }
  }

  public DatabaseQueryMultithreadedDataAdapter QueryMultithreadedDataAdapter
  {
    get
    {
      if (this._daQueryMultithreaded == null)
        this._daQueryMultithreaded = new DatabaseQueryMultithreadedDataAdapter();
      return this._daQueryMultithreaded;
    }
  }

  public DatabaseQueryMultithreadedSP QueryMultithreadedSP
  {
    get
    {
      if (this._QuerySPMultithreaded == null)
        this._QuerySPMultithreaded = new DatabaseQueryMultithreadedSP();
      return this._QuerySPMultithreaded;
    }
  }

  public static bool IsInitialized => Database._initialized;

  public static void Initialize(Control uiContext, string connectionString)
  {
    Database._connectionString = connectionString;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Database._connectionString, string.Empty, false) == 0)
      throw new ArgumentException("Invalid empty connectioning string", nameof (connectionString));
    Database.VerifyDatabaseExists();
    Database._uiContext = uiContext;
    Database._initialized = true;
  }

  public static void Initialize(string connectionString)
  {
    Database.Initialize((Control) null, connectionString);
  }

  private static bool VerifyDatabaseExists()
  {
    SqlConnection sqlConnection = new SqlConnection(Database._connectionString);
    try
    {
      sqlConnection.Open();
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
    }
    bool flag;
    return flag;
  }

  public static Database Instance
  {
    get
    {
      if (!Database._initialized)
        throw new DatabaseException(MGASystems.Common.SR.GetString("DB_MustInitialize"));
      if (Database._uiContext != null && Database._uiContext.InvokeRequired)
        return new Database();
      if (HttpContext.Current == null)
      {
        if (Database._database == null)
          Database._database = new Database();
        return Database._database;
      }
      if (!HttpContext.Current.Items.Contains((object) nameof (Database)))
        HttpContext.Current.Items.Add((object) nameof (Database), (object) new Database());
      return (Database) HttpContext.Current.Items[(object) nameof (Database)];
    }
  }

  public DatabaseQueryText QueryText
  {
    get
    {
      if (this._QueryText == null)
        this._QueryText = new DatabaseQueryText(this);
      return this._QueryText;
    }
  }

  public DatabaseQuerySP QuerySP
  {
    get
    {
      if (this._QuerySP == null)
        this._QuerySP = new DatabaseQuerySP(this);
      return this._QuerySP;
    }
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  internal SqlCommand Command => this._command;

  [EditorBrowsable(EditorBrowsableState.Never)]
  internal SqlConnection Connection => this._connection;

  public static DataTable SelectDistinct(DataTable sourceTable, params string[] fieldNames)
  {
    if (sourceTable == null)
      throw new ArgumentNullException(nameof (sourceTable));
    object[] lastValues = fieldNames != null && fieldNames.Length != 0 ? new object[fieldNames.Length - 1 + 1] : throw new ArgumentNullException(nameof (fieldNames));
    DataTable dataTable = new DataTable();
    string[] strArray = fieldNames;
    int index1 = 0;
    while (index1 < strArray.Length)
    {
      string str = strArray[index1];
      dataTable.Columns.Add(str, sourceTable.Columns[str].DataType);
      checked { ++index1; }
    }
    DataRow[] dataRowArray = sourceTable.Select("", string.Join(", ", fieldNames));
    int index2 = 0;
    while (index2 < dataRowArray.Length)
    {
      DataRow dataRow = dataRowArray[index2];
      if (!Database.fieldValuesAreEqual(lastValues, dataRow, fieldNames))
      {
        dataTable.Rows.Add(Database.createRowClone(dataRow, dataTable.NewRow(), fieldNames));
        Database.setLastValues(lastValues, dataRow, fieldNames);
      }
      checked { ++index2; }
    }
    return dataTable;
  }

  private static bool fieldValuesAreEqual(
    object[] lastValues,
    DataRow currentRow,
    string[] fieldNames)
  {
    bool flag = true;
    int num = fieldNames.Length - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (lastValues[index] == null || !lastValues[index].Equals(RuntimeHelpers.GetObjectValue(currentRow[fieldNames[index]])))
      {
        flag = false;
        break;
      }
    }
    return flag;
  }

  private static DataRow createRowClone(DataRow sourceRow, DataRow newRow, string[] fieldNames)
  {
    string[] strArray = fieldNames;
    int index = 0;
    while (index < strArray.Length)
    {
      string columnName = strArray[index];
      newRow[columnName] = RuntimeHelpers.GetObjectValue(sourceRow[columnName]);
      checked { ++index; }
    }
    return newRow;
  }

  private static void setLastValues(object[] lastValues, DataRow sourceRow, string[] fieldNames)
  {
    int num = fieldNames.Length - 1;
    for (int index = 0; index <= num; ++index)
      lastValues[index] = RuntimeHelpers.GetObjectValue(sourceRow[fieldNames[index]]);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public delegate object TransactionQuerySetEventHandler(object sender, QuerySetHandlerEventArgs e);

  [EditorBrowsable(EditorBrowsableState.Never)]
  public delegate object QuerySetEventHandler(object sender, QuerySetHandlerEventArgs e);

  public delegate void RowUpdatedEventHandler(object sender, Database.UpdateWithProgressEventArgs e);

  public sealed class UpdateWithProgressEventArgs : EventArgs
  {
    private int _maximum;
    private int _progress;

    public int Progress => this._progress;

    public int Maximum => this._maximum;

    public UpdateWithProgressEventArgs(int maximum, int progress)
    {
      this._maximum = maximum;
      this._progress = progress;
    }
  }
}
