// Decompiled with JetBrains decompiler
// Type: MGASystems.Tools.IGHelperModule
// Assembly: MgaSystems.IMS.Tools, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1287D1AD-C908-42E9-BE8F-4574B2D0AB9E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Tools.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.Tools;

[StandardModule]
public sealed class IGHelperModule
{
  [SuppressMessage("Microsoft.Design", "CA1011:ConsiderPassingBaseTypesAsParameters")]
  public static void AddPopulatedListToGrid(
    UltraGrid uGrid,
    string key,
    string displayMember,
    string dataMember,
    DataTable sourceTable)
  {
    if (sourceTable == null)
      throw new ArgumentNullException(nameof (sourceTable));
    if (uGrid == null)
      throw new ArgumentNullException(nameof (uGrid));
    ((UltraGridBase) uGrid).DisplayLayout.ValueLists.Add(key);
    ValueListItemsCollection valueListItems = ((UltraGridBase) uGrid).DisplayLayout.ValueLists[key].ValueListItems;
    int num = sourceTable.Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
      valueListItems.Add(RuntimeHelpers.GetObjectValue(sourceTable.Rows[index][dataMember]), Conversions.ToString(sourceTable.Rows[index][displayMember]));
  }

  public static void PopulateValueList(
    ValueList valueList,
    string displayMember,
    string dataMember,
    DataTable sourceTable)
  {
    if (valueList == null)
      throw new ArgumentNullException(nameof (valueList));
    if (sourceTable == null)
      throw new ArgumentNullException(nameof (sourceTable));
    int num = sourceTable.Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
      valueList.ValueListItems.Add(RuntimeHelpers.GetObjectValue(sourceTable.Rows[index][dataMember]), Conversions.ToString(sourceTable.Rows[index][displayMember]));
  }

  public static ValueList CreateIGValueList(
    string key,
    string displayMember,
    string dataMember,
    DataTable sourceTable)
  {
    if (sourceTable == null)
      throw new ArgumentNullException(nameof (sourceTable));
    ValueList igValueList = new ValueList();
    int num = sourceTable.Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
      igValueList.ValueListItems.Add(RuntimeHelpers.GetObjectValue(sourceTable.Rows[index][dataMember]), Conversions.ToString(sourceTable.Rows[index][displayMember]));
    ((KeyedSubObjectBase) igValueList).Key = key;
    return igValueList;
  }

  public static ValueList CreateIGValueList(
    string key,
    string displayMember,
    string dataMember,
    DataView sourceView)
  {
    if (sourceView == null)
      throw new ArgumentNullException(nameof (sourceView));
    ValueList igValueList = new ValueList();
    try
    {
      foreach (DataRowView dataRowView in sourceView)
        igValueList.ValueListItems.Add(RuntimeHelpers.GetObjectValue(dataRowView.Row[dataMember]), Conversions.ToString(dataRowView.Row[displayMember]));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((KeyedSubObjectBase) igValueList).Key = key;
    return igValueList;
  }

  public static void RePopulateValueList(
    UltraGridColumn col,
    string displayMember,
    string dataMember,
    DataTable sourceTable)
  {
    if (col == null)
      throw new ArgumentNullException(nameof (col));
    if (sourceTable == null)
      throw new ArgumentNullException(nameof (sourceTable));
    ValueList valueList = (ValueList) col.ValueList;
    if (valueList == null)
    {
      ValueList igValueList = IGHelperModule.CreateIGValueList(col.Key + "_VLIST", displayMember, dataMember, sourceTable);
      col.ValueList = (IValueList) igValueList;
    }
    else
    {
      valueList.ValueListItems.Clear();
      int num = sourceTable.Rows.Count - 1;
      for (int index = 0; index <= num; ++index)
        valueList.ValueListItems.Add(RuntimeHelpers.GetObjectValue(sourceTable.Rows[index][dataMember]), Conversions.ToString(sourceTable.Rows[index][displayMember]));
    }
  }

  public static void RePopulateValueList(
    string key,
    UltraGrid grid,
    string displayMember,
    string dataMember,
    DataView sourceView)
  {
  }

  public static ValueList CreateIGValueList(
    string key,
    string displayMember,
    string dataMember,
    string tableName,
    SqlConnection connection)
  {
    if (connection == null)
      throw new ArgumentNullException(nameof (connection));
    SqlCommand sqlCommand = new SqlCommand($"SELECT {displayMember}, {dataMember} FROM {tableName}", connection);
    connection.Open();
    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.SingleResult);
    ValueList igValueList = new ValueList();
    while (sqlDataReader.Read())
      igValueList.ValueListItems.Add(RuntimeHelpers.GetObjectValue(sqlDataReader[1]), sqlDataReader.GetString(0));
    sqlDataReader.Close();
    connection.Close();
    sqlCommand.Dispose();
    ((KeyedSubObjectBase) igValueList).Key = key;
    return igValueList;
  }

  public static void InitializeGridRowValues(UltraGridRow row, string[] excludeColsKeys)
  {
    if (row == null)
      throw new ArgumentNullException(nameof (row));
    foreach (UltraGridCell cell in row.Cells)
    {
      bool flag = false;
      string[] strArray = excludeColsKeys;
      int index = 0;
      while (index < strArray.Length)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray[index], cell.Column.Key, false) == 0)
        {
          flag = true;
          break;
        }
        checked { ++index; }
      }
      if (!flag)
      {
        if (cell.Column.DataType.Equals(typeof (Decimal)))
          cell.Value = (object) 0M;
        else if (cell.Column.DataType.Equals(typeof (int)))
          cell.Value = (object) 0;
        else if (cell.Column.DataType.Equals(typeof (double)))
          cell.Value = (object) 0.0;
        else if (cell.Column.DataType.Equals(typeof (float)))
          cell.Value = (object) 0.0f;
        else if (cell.Column.DataType.Equals(typeof (string)))
          cell.Value = (object) " ";
        else if (cell.Column.DataType.Equals(typeof (bool)))
          cell.Value = (object) false;
        else if (cell.Column.DataType.Equals(typeof (Guid)))
          cell.Value = (object) Guid.Empty;
      }
    }
  }
}
