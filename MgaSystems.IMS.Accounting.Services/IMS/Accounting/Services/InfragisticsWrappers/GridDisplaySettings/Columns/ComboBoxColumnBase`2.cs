// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.ComboBoxColumnBase`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;

public abstract class ComboBoxColumnBase<TDisplayItem, TComboSelection> : 
  EditColumn<TDisplayItem, TComboSelection>
  where TComboSelection : class
{
  private readonly Func<TComboSelection, string> _getComboItemDisplayNameFunc;
  private readonly bool _showEmptySelection;

  protected static string ComboDisplayMemberName { get; } = "DisplayName";

  protected static string ComboValueMemberName { get; } = "ValueMember";

  protected ComboBoxColumnBase(
    string headerCaption,
    int width,
    Func<TDisplayItem, TComboSelection> getDisplayValueFunc,
    Action<TDisplayItem, TComboSelection> setFromDisplayValueAction,
    Func<TComboSelection, string> getComboItemDisplayNameFunc,
    bool allowEmptySelection = false,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, getDisplayValueFunc, setFromDisplayValueAction, getCellColorFromDisplayItemFunc)
  {
    this._showEmptySelection = allowEmptySelection;
    this._getComboItemDisplayNameFunc = getComboItemDisplayNameFunc ?? throw new ArgumentNullException(nameof (getComboItemDisplayNameFunc));
  }

  protected ComboBoxColumnBase(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, TComboSelection> getDisplayValueFunc,
    Action<TDisplayItem, TComboSelection> setFromDisplayValueAction,
    Func<TComboSelection, string> getComboItemDisplayNameFunc,
    bool allowEmptySelection = false,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, getDisplayValueFunc, setFromDisplayValueAction, getCellColorFromDisplayItemFunc)
  {
    this._showEmptySelection = allowEmptySelection;
    this._getComboItemDisplayNameFunc = getComboItemDisplayNameFunc ?? throw new ArgumentNullException(nameof (getComboItemDisplayNameFunc));
  }

  protected override TComboSelection CastToEditType(object newCellValue)
  {
    return (TComboSelection) newCellValue;
  }

  protected override TComboSelection GetCellValue(UltraGridCell cell)
  {
    return this.CastToEditType((cell.ValueList as MGASimpleComboBox).Value);
  }

  protected override void ChildAttachListeners(UltraGrid grid)
  {
    grid.AfterCellListCloseUp += new CellEventHandler(((ColumnBase<TDisplayItem>) this).HandlePostCellInteraction);
  }

  protected override void OnUserInteractionComplete(TDisplayItem displayItem, UltraGridCell cell)
  {
    base.OnUserInteractionComplete(displayItem, cell);
    ((GridItemBase) cell).Activated = false;
  }

  private ComboBoxSelection<TComboSelection>[] BuildComboSelections(
    IEnumerable<TComboSelection> values)
  {
    List<ComboBoxSelection<TComboSelection>> list = values.Select<TComboSelection, ComboBoxSelection<TComboSelection>>((Func<TComboSelection, ComboBoxSelection<TComboSelection>>) (item => new ComboBoxSelection<TComboSelection>(item, this._getComboItemDisplayNameFunc(item)))).OrderBy<ComboBoxSelection<TComboSelection>, string>((Func<ComboBoxSelection<TComboSelection>, string>) (x => x.DisplayName)).ToList<ComboBoxSelection<TComboSelection>>();
    if (this._showEmptySelection)
      list.Insert(0, (ComboBoxSelection<TComboSelection>) null);
    return list.ToArray();
  }

  protected MGASimpleComboBox CreateValueList(IEnumerable<TComboSelection> values)
  {
    MGASimpleComboBox valueList = new MGASimpleComboBox();
    ComboBoxColumnBase<TDisplayItem, TComboSelection>.StyleComboBox(valueList);
    this.SetComboBoxData(values, valueList);
    ComboBoxColumnBase<TDisplayItem, TComboSelection>.HideAllNonNameColumns(valueList);
    return valueList;
  }

  private void SetComboBoxData(IEnumerable<TComboSelection> values, MGASimpleComboBox comboBox)
  {
    ((UltraGridBase) comboBox).DataSource = (object) this.BuildComboSelections(values);
    ((UltraDropDownBase) comboBox).ValueMember = ComboBoxColumnBase<TDisplayItem, TComboSelection>.ComboValueMemberName;
    ((UltraDropDownBase) comboBox).DisplayMember = ComboBoxColumnBase<TDisplayItem, TComboSelection>.ComboDisplayMemberName;
    ((Control) comboBox).Enabled = true;
  }

  private static void StyleComboBox(MGASimpleComboBox valueList)
  {
    valueList.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) valueList).Dock = DockStyle.Fill;
    valueList.DropDownStyle = (UltraComboStyle) 1;
    valueList.MGAStyle = MGAStyles.Blue;
    ((UltraDropDownBase) valueList).DropDownWidth = 0;
    ((UltraControlBase) valueList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) valueList).UseOsThemes = (DefaultableBoolean) 2;
  }

  private static void HideAllNonNameColumns(MGASimpleComboBox dropDown)
  {
    foreach (UltraGridColumn column in dropDown.DisplayLayout.Bands[0].Columns)
      column.Hidden = ((KeyedSubObjectBase) column).Key != ComboBoxColumnBase<TDisplayItem, TComboSelection>.ComboDisplayMemberName;
  }
}
