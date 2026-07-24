// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.DataAccess.TableQueryMultithreadEventArgs
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Common.DataAccess;

public sealed class TableQueryMultithreadEventArgs : KeyedThreadEventArgs
{
  private DataTable _table;

  public TableQueryMultithreadEventArgs(DataTable table, object key)
    : base(RuntimeHelpers.GetObjectValue(key))
  {
    this._table = table;
  }

  public DataTable Table => this._table;

  public void CopyToDataSetTable(DataTable destinationDataSetTable)
  {
    if (destinationDataSetTable == null)
      throw new ArgumentNullException(nameof (destinationDataSetTable));
    DataTable table = this.Table;
    if (table == null)
      return;
    DataSet dataSet = this.Table.GetType().Equals(destinationDataSetTable.GetType()) ? destinationDataSetTable.DataSet : throw new DatabaseException(MGASystems.Common.SR.GetString("DB_TypeMustMatch"));
    if (dataSet != null)
      dataSet.EnforceConstraints = false;
    if (destinationDataSetTable.Rows.Count > 0)
      destinationDataSetTable.Clear();
    destinationDataSetTable.BeginLoadData();
    try
    {
      foreach (DataRow row in table.Rows)
      {
        object[] itemArray = row.ItemArray;
        destinationDataSetTable.LoadDataRow(itemArray, true);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    destinationDataSetTable.EndLoadData();
    if (dataSet == null)
      return;
    dataSet.EnforceConstraints = true;
  }
}
