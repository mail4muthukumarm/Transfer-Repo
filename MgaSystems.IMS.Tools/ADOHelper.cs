// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.ADOHelper
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using System;
using System.Data;

#nullable disable
namespace MGASystems.Tools;

public sealed class ADOHelper
{
  private ADOHelper()
  {
  }

  public static DataTable DataViewToDataTable(DataView source, DataViewRowState rowState)
  {
    if (source == null)
      throw new ArgumentNullException(nameof (source));
    DataTable dataTable = new DataTable();
    DataRow[] dataRowArray = source.Table.Select(source.RowFilter, source.Sort, rowState);
    if (dataRowArray.Length > 0)
    {
      int num1 = dataRowArray[0].Table.Columns.Count - 1;
      for (int index = 0; index <= num1; ++index)
        dataTable.Columns.Add(dataRowArray[0].Table.Columns[index].ColumnName, dataRowArray[0].Table.Columns[index].DataType);
      int num2 = dataRowArray.Length - 1;
      for (int index = 0; index <= num2; ++index)
        dataTable.Rows.Add(dataRowArray[index].ItemArray);
    }
    return dataTable;
  }
}
