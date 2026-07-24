// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.HelperExtensions
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core;

public static class HelperExtensions
{
  public static void ComboboxDatasetCreator(
    this MGASimpleComboBox comboBox,
    List<string> optionsDisplayList,
    string propertiesName = "")
  {
    string str = propertiesName != "" ? propertiesName : ((Control) comboBox).Name;
    string columnName1 = str + "Id";
    string columnName2 = str;
    string tableName = str + "s";
    DataSet dataSet = new DataSet();
    DataTable dt = new DataTable(tableName);
    dt.Columns.Add(new DataColumn(columnName1, typeof (string)));
    dt.Columns.Add(new DataColumn(columnName2, typeof (string)));
    List<string> keys = new List<string>();
    optionsDisplayList.ForEach((Action<string>) (option =>
    {
      foreach (char ch in option)
      {
        if (!keys.Contains(ch.ToString()))
        {
          keys.Add(ch.ToString().ToUpper());
          break;
        }
      }
      dt.Rows.Add((object) keys[keys.Count - 1], (object) option);
    }));
    dataSet.Tables.Add(dt);
    ((UltraGridBase) comboBox).DataSource = (object) dataSet;
    ((UltraDropDownBase) comboBox).ValueMember = columnName1;
    ((UltraDropDownBase) comboBox).DisplayMember = columnName2;
  }

  public static void AddSelectParameters(
    this SqlDataAdapter da,
    Dictionary<string, object> parameters)
  {
    foreach (KeyValuePair<string, object> parameter in parameters)
      da.SelectCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
  }

  public static void AddInsertParameters(
    this SqlDataAdapter da,
    Dictionary<string, object> parameters)
  {
    foreach (KeyValuePair<string, object> parameter in parameters)
      da.InsertCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
  }

  public static void AddDeleteParameters(
    this SqlDataAdapter da,
    Dictionary<string, object> parameters)
  {
    foreach (KeyValuePair<string, object> parameter in parameters)
      da.DeleteCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
  }

  public static void AddUpdateParameters(
    this SqlDataAdapter da,
    Dictionary<string, object> parameters)
  {
    foreach (KeyValuePair<string, object> parameter in parameters)
      da.UpdateCommand.Parameters.AddWithValue(parameter.Key, parameter.Value);
  }

  public static void ClearParameters(this SqlDataAdapter da) => da.SelectCommand.Parameters.Clear();

  public static string GetSelectedValueId(this MGASimpleComboBox comboBox)
  {
    return ((UltraDropDownBase) comboBox).SelectedRow.Cells[0].Value.ToString();
  }

  public static bool IsMgaDateTimePickerValid(
    this MGADateTimePicker fromDatePicker,
    MGADateTimePicker toDatePicker,
    out MessageBoxProperties msgBoxProperties)
  {
    msgBoxProperties = new MessageBoxProperties();
    if (fromDatePicker.Value == null || toDatePicker.Value == null)
    {
      msgBoxProperties.Caption = "Required Field Missing!";
      msgBoxProperties.Message = "Both a starting date and an ending date must be supplied to continue.";
      msgBoxProperties.Button = MessageBoxButtons.OK;
      msgBoxProperties.Icon = MessageBoxIcon.Exclamation;
      return false;
    }
    if (!(fromDatePicker.DateTime.Date > toDatePicker.DateTime.Date))
      return true;
    msgBoxProperties.Caption = "Invalid Date Range";
    msgBoxProperties.Message = "Starting date can not be greater than ending date.";
    msgBoxProperties.Button = MessageBoxButtons.OK;
    msgBoxProperties.Icon = MessageBoxIcon.Exclamation;
    return false;
  }

  public static string GetSelectedValueString(this UltraGrid grid, string columnName)
  {
    return HelperExtensions.GetUltraGridSelectedValue(grid, columnName).ToString();
  }

  public static int GetSelectedValueInt(this UltraGrid grid, string columnName)
  {
    return Convert.ToInt32(HelperExtensions.GetUltraGridSelectedValue(grid, columnName));
  }

  public static Decimal GetSelectedValueDecimal(this UltraGrid grid, string columnName)
  {
    return Convert.ToDecimal(HelperExtensions.GetUltraGridSelectedValue(grid, columnName));
  }

  public static bool GetSelectedValueBool(this UltraGrid grid, string columnName)
  {
    return Convert.ToBoolean(HelperExtensions.GetUltraGridSelectedValue(grid, columnName));
  }

  public static Guid GetSelectedValueGuid(this UltraGrid grid, string columnName)
  {
    Guid.Parse(HelperExtensions.GetUltraGridSelectedValue(grid, columnName).ToString());
    return Guid.Parse(HelperExtensions.GetUltraGridSelectedValue(grid, columnName).ToString());
  }

  public static object GetUltraGridSelectedValue(UltraGrid grid, string columnName)
  {
    return grid.Selected.Rows[0].Cells[columnName].Value;
  }
}
