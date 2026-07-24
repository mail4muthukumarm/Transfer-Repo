// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.UniqueComboBoxColumn`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;

public class UniqueComboBoxColumn<TDisplayItem, TComboSelection> : 
  ComboBoxColumnBase<TDisplayItem, TComboSelection>
  where TComboSelection : class
{
  private readonly Func<TDisplayItem, IEnumerable<TComboSelection>> _getSelectableValues;

  public UniqueComboBoxColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, TComboSelection> getDisplayValueFunc,
    Action<TDisplayItem, TComboSelection> setFromDisplayValueAction,
    Func<TDisplayItem, IEnumerable<TComboSelection>> getSelectableValues,
    Func<TComboSelection, string> getComboItemDisplayNameFunc,
    bool allowEmptySelection = false,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, getDisplayValueFunc, setFromDisplayValueAction, getComboItemDisplayNameFunc, allowEmptySelection, getCellColorFromDisplayItemFunc)
  {
    this._getSelectableValues = getSelectableValues ?? throw new ArgumentNullException(nameof (getSelectableValues));
  }

  public UniqueComboBoxColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, TComboSelection> getDisplayValueFunc,
    Action<TDisplayItem, TComboSelection> setFromDisplayValueAction,
    Func<TDisplayItem, IEnumerable<TComboSelection>> getSelectableValues,
    Func<TComboSelection, string> getComboItemDisplayNameFunc,
    bool allowEmptySelection = false,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, getDisplayValueFunc, setFromDisplayValueAction, getComboItemDisplayNameFunc, allowEmptySelection, getCellColorFromDisplayItemFunc)
  {
    this._getSelectableValues = getSelectableValues ?? throw new ArgumentNullException(nameof (getSelectableValues));
  }

  protected override TComboSelection CastToEditType(object newCellValue)
  {
    return (TComboSelection) newCellValue;
  }

  protected override void ChildSetInitialCellValue(UltraGridCell cell, TDisplayItem displayItem)
  {
    cell.ValueList = (IValueList) this.CreateValueList(this._getSelectableValues(displayItem));
    (cell.ValueList as MGASimpleComboBox).Value = (object) this.GetDisplayValueFunc(displayItem);
  }
}
