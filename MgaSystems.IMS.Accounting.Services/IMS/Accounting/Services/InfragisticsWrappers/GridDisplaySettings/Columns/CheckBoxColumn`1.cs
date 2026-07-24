// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.CheckBoxColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;

public class CheckBoxColumn<TDisplayItem> : EditColumn<TDisplayItem, bool>
{
  private const string _checkboxTrueValue = "true";
  private const string _checkboxFalseValue = "false";

  protected override ColumnStyle ColumnDisplayStyle => (ColumnStyle) 3;

  protected override Activation CellActivation { get; } = (Activation) 3;

  protected override Activation CellDisableActivation { get; } = (Activation) 2;

  public CheckBoxColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, bool> getBoundValueFromDisplayItemFunc,
    Action<TDisplayItem, bool> setValueAction)
    : base(headerCaption, width, getBoundValueFromDisplayItemFunc, setValueAction)
  {
  }

  public CheckBoxColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, bool> getBoundValueFromDisplayItemFunc,
    Action<TDisplayItem, bool> setValueAction)
    : base(identifier, headerCaption, width, getBoundValueFromDisplayItemFunc, setValueAction)
  {
  }

  protected override bool CastToEditType(object newCellValue)
  {
    return newCellValue.ToString().ToLower().Equals("true");
  }

  protected override void ChildAttachListeners(UltraGrid grid)
  {
    grid.ClickCell += new ClickCellEventHandler(this.Grid_ClickCell);
  }

  private void Grid_ClickCell(object sender, ClickCellEventArgs e)
  {
    UltraGridCell cell = e.Cell;
    if (!(cell.Row.ListObject is TDisplayItem listObject) || !cell.Column.Equals((object) this.AppliedToColumn) || !this.GetEnabledState(listObject))
      return;
    bool flag = this.GetDisplayValueFunc(listObject);
    cell.Value = flag ? (object) "false" : (object) "true";
    this.OnUserInteractionComplete(listObject, cell);
    ((GridItemBase) cell).Activated = false;
  }

  protected override void ChildUserSetValue(UltraGridCell cell, bool newValue)
  {
    cell.Value = newValue ? (object) "true" : (object) "false";
  }
}
