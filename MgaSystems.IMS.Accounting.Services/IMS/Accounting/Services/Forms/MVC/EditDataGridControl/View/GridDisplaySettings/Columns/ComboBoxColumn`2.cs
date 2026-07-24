// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns.ComboBoxColumn`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;

public class ComboBoxColumn<TDisplayItem, TComboSelection> : 
  ComboBoxColumnBase<TDisplayItem, TComboSelection>
  where TComboSelection : class
{
  private readonly IValueList _valueList;

  protected override ColumnStyle ColumnDisplayStyle => (ColumnStyle) 6;

  public ComboBoxColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, TComboSelection> getBoundValueFromDisplayItemFunc,
    Action<TDisplayItem, TComboSelection> setValueAction,
    IEnumerable<TComboSelection> selectableValues,
    Func<TComboSelection, string> getComboItemDisplayNameFunc,
    bool allowEmptySelection = false,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, getBoundValueFromDisplayItemFunc, setValueAction, getComboItemDisplayNameFunc, allowEmptySelection, getCellColorFromDisplayItemFunc)
  {
    if (selectableValues == null)
      throw new ArgumentNullException(nameof (selectableValues));
    if (!selectableValues.Any<TComboSelection>() && !allowEmptySelection)
      throw new ArgumentException("Must have at least one selectable value or allow for no selection.");
    this._valueList = !selectableValues.Any<TComboSelection>((Func<TComboSelection, bool>) (value => (object) value == null)) ? (IValueList) this.CreateValueList(selectableValues) : throw new ArgumentException("Cannot have null values in a combo box. If you wish to have a way for the user not to set a selection then set allowEmptySelection = true");
  }

  public ComboBoxColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, TComboSelection> getBoundValueFromDisplayItemFunc,
    Action<TDisplayItem, TComboSelection> setValueAction,
    IEnumerable<TComboSelection> selectableValues,
    Func<TComboSelection, string> getComboItemDisplayNameFunc,
    bool allowEmptySelection = false,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, getBoundValueFromDisplayItemFunc, setValueAction, getComboItemDisplayNameFunc, allowEmptySelection, getCellColorFromDisplayItemFunc)
  {
    if (selectableValues == null)
      throw new ArgumentNullException(nameof (selectableValues));
    if (!selectableValues.Any<TComboSelection>() && !allowEmptySelection)
      throw new ArgumentException("Must have at least one selectable value or allow for no selection.");
    this._valueList = !selectableValues.Any<TComboSelection>((Func<TComboSelection, bool>) (value => (object) value == null)) ? (IValueList) this.CreateValueList(selectableValues) : throw new ArgumentException("Cannot have null values in a combo box. If you wish to have a way for the user not to set a selection then set allowEmptySelection = true");
  }

  protected override void ChildSetInitialCellValue(UltraGridCell cell, TDisplayItem displayItem)
  {
    cell.ValueList = this._valueList;
    (cell.ValueList as MGASimpleComboBox).Value = (object) this.GetDisplayValueFunc(displayItem);
  }
}
