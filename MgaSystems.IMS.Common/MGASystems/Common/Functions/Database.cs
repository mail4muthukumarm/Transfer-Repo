// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Functions.Database
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.Common.Functions;

[StandardModule]
public sealed class Database
{
  public static bool DataHasChanged(DataRow row)
  {
    if (row == null)
      throw new ArgumentNullException(nameof (row));
    bool flag;
    if (row.RowState == DataRowState.Deleted)
      flag = false;
    else if (!row.HasVersion(DataRowVersion.Original))
    {
      flag = true;
    }
    else
    {
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) row.Table.Columns)
        {
          if (row[column] != DBNull.Value && Database.DataHasChanged(row, column))
          {
            flag = true;
            goto label_14;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      flag = false;
    }
label_14:
    return flag;
  }

  public static bool DataHasChanged(DataRow row, DataColumn column)
  {
    if (row == null)
      throw new ArgumentNullException(nameof (row));
    return row.HasVersion(DataRowVersion.Original) && !row[column, DataRowVersion.Original].Equals(RuntimeHelpers.GetObjectValue(row[column, DataRowVersion.Current]));
  }

  public static int GetRowIndexFromvalue(object value, int colIndex, DataTable table)
  {
    if (table == null)
      throw new ArgumentNullException(nameof (table));
    int num = 0;
    int rowIndexFromvalue;
    try
    {
      foreach (DataRow row in table.Rows)
      {
        if (row.RowState != DataRowState.Deleted && row[colIndex].Equals(RuntimeHelpers.GetObjectValue(value)))
        {
          rowIndexFromvalue = num;
          goto label_12;
        }
        ++num;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    rowIndexFromvalue = -1;
label_12:
    return rowIndexFromvalue;
  }

  public static int GetRowIndexFromvalue(object value, string colName, DataTable table)
  {
    if (table == null)
      throw new ArgumentNullException(nameof (table));
    int colIndex = table.Columns.IndexOf(colName);
    return Database.GetRowIndexFromvalue(RuntimeHelpers.GetObjectValue(value), colIndex, table);
  }

  public static void MoveTo(object value, string colName, DataTable table, BindingManagerBase bm)
  {
    if (bm == null)
      throw new ArgumentNullException(nameof (bm));
    bm.Position = Database.GetRowIndexFromvalue(RuntimeHelpers.GetObjectValue(value), colName, table);
  }

  public static void MoveTo(object value, int colindex, DataTable table, BindingManagerBase bm)
  {
    if (bm == null)
      throw new ArgumentNullException(nameof (bm));
    bm.Position = Database.GetRowIndexFromvalue(RuntimeHelpers.GetObjectValue(value), colindex, table);
  }
}
