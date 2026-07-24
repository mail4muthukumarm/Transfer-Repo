// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.DataAdapterQueryThread
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.DataAccess;

public sealed class DataAdapterQueryThread : QueryThread
{
  private DataTable _tableToFill;
  private SqlDataAdapter _da;
  private TableQueryMultithreadEventHandler _completedHandler;
  private DataTable _originalTable;
  private DatabaseQueryMultithreadedDataAdapter _parentDatabaseQueryMultithreadedDataAdapter;

  public string TableToFillName => this._tableToFill.TableName;

  public DataAdapterQueryThread(
    DatabaseQueryMultithreadedDataAdapter parentDatabaseQueryMultithreadedDataAdapter,
    Control uiContext,
    SqlDataAdapter da,
    object key,
    DataTable tableToFill,
    TableQueryMultithreadEventHandler completedHandler)
    : base(uiContext, RuntimeHelpers.GetObjectValue(key), string.Empty)
  {
    this._originalTable = tableToFill != null ? tableToFill : throw new ArgumentNullException(nameof (tableToFill));
    this._tableToFill = tableToFill.Clone();
    this._completedHandler = completedHandler;
    this._da = da;
    this._parentDatabaseQueryMultithreadedDataAdapter = parentDatabaseQueryMultithreadedDataAdapter;
    if (this._tableToFill.Rows.Count <= 0)
      return;
    this._tableToFill.Rows.Clear();
  }

  protected override void ThreadCompletedUI()
  {
    this._originalTable.Clear();
    if (this._originalTable.Columns.Count != this._tableToFill.Columns.Count)
    {
      this._originalTable.BeginLoadData();
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) this._tableToFill.Columns)
        {
          if (!this._originalTable.Columns.Contains(column.ColumnName))
            this._originalTable.Columns.Add(column.ColumnName, column.DataType, column.Expression);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this._originalTable.EndLoadData();
    }
    DataRow dataRow = (DataRow) null;
    try
    {
      try
      {
        foreach (DataRow row in this._tableToFill.Rows)
        {
          dataRow = row;
          this._originalTable.Rows.Add(row.ItemArray);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this._originalTable.AcceptChanges();
    }
    catch (ArgumentException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ArgumentException innerException = ex;
      if (dataRow.Table.Columns.Count != this._originalTable.Columns.Count)
        throw new ArgumentException("Please check your dataset, the columns in your select do not match the columns in your table", (Exception) innerException);
      ProjectData.ClearProjectError();
    }
    this._completedHandler((object) this, new TableQueryMultithreadEventArgs(this._originalTable, RuntimeHelpers.GetObjectValue(this.Key)));
    this._parentDatabaseQueryMultithreadedDataAdapter.OnTableFillComplete(this._originalTable);
    this._tableToFill.Clear();
    this._tableToFill.Dispose();
    this._tableToFill = (DataTable) null;
  }

  protected override void ThreadProcBG()
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    SqlCommand sqlCommand = new SqlCommand(this._da.SelectCommand.CommandText);
    try
    {
      try
      {
        foreach (DataTableMapping tableMapping in this._da.TableMappings)
        {
          DataTableMapping dataTableMapping = new DataTableMapping(tableMapping.SourceTable, tableMapping.DataSetTable);
          try
          {
            foreach (DataColumnMapping columnMapping in tableMapping.ColumnMappings)
            {
              DataColumnMapping dataColumnMapping = new DataColumnMapping(columnMapping.SourceColumn, columnMapping.DataSetColumn);
              dataTableMapping.ColumnMappings.Add((object) dataColumnMapping);
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          sqlDataAdapter.TableMappings.Add((object) dataTableMapping);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      sqlCommand.CommandTimeout = 300;
      try
      {
        foreach (SqlParameter parameter in this._da.SelectCommand.Parameters)
          sqlCommand.Parameters.Add(new SqlParameter(parameter.ParameterName, parameter.SqlDbType, parameter.Size, parameter.SourceColumn)
          {
            Value = RuntimeHelpers.GetObjectValue(parameter.Value)
          });
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      sqlCommand.CommandType = this._da.SelectCommand.CommandType;
      sqlCommand.Connection = this.DB.Connection;
      sqlDataAdapter.SelectCommand = sqlCommand;
      int num = 0;
      do
      {
        try
        {
          sqlDataAdapter.Fill(this._tableToFill);
          break;
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          if (!Database.IsRetryableException((Exception) ex) || num == 4)
          {
            if (num == 4)
              throw new DatabaseRetryException($"Could not fill table after {num.ToString()} retries.");
            throw;
          }
          Thread.Sleep(2000);
          ProjectData.ClearProjectError();
        }
        catch (InvalidOperationException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          if (!Database.IsRetryableException((Exception) ex) || num == 4)
          {
            if (num == 4)
              throw new DatabaseRetryException($"Could not fill table after {num.ToString()} retries.");
            throw;
          }
          Thread.Sleep(2000);
          ProjectData.ClearProjectError();
        }
        ++num;
      }
      while (num <= 4);
    }
    finally
    {
      this._da.SelectCommand.Connection.Close();
      sqlCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }
}
