// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.ButtonColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;

public class ButtonColumn<TDisplayItem> : ColumnBase<TDisplayItem>
{
  private readonly string _buttonText;

  private Action<TDisplayItem> _onClickAction { get; }

  protected override ColumnStyle ColumnDisplayStyle => (ColumnStyle) 8;

  protected override CellClickAction CellClickAction => (CellClickAction) 0;

  protected override bool AllowEdit => false;

  protected override Activation CellActivation => (Activation) 0;

  public ButtonColumn(
    string headerCaption,
    int width,
    string buttonText,
    Action<TDisplayItem> onClickAction,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, getCellColorFromDisplayItemFunc)
  {
    this._buttonText = buttonText ?? throw new ArgumentNullException(nameof (buttonText));
    this._onClickAction = onClickAction ?? throw new ArgumentNullException(nameof (onClickAction));
  }

  public ButtonColumn(
    string identifier,
    string headerCaption,
    int width,
    string buttonText,
    Action<TDisplayItem> onClickAction,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, getCellColorFromDisplayItemFunc)
  {
    this._buttonText = buttonText ?? throw new ArgumentNullException(nameof (buttonText));
    this._onClickAction = onClickAction ?? throw new ArgumentNullException(nameof (onClickAction));
  }

  protected override void ChildAttachListeners(UltraGrid grid)
  {
    grid.ClickCellButton += new CellEventHandler(((ColumnBase<TDisplayItem>) this).HandlePostCellInteraction);
  }

  protected override void SetCellDisplayValue(UltraGridCell cell, TDisplayItem model)
  {
    ((AppearanceBase) cell.Appearance).ForeColor = this.GetCellColorFromDisplayItemFunc(model);
    cell.Value = (object) this._buttonText;
  }

  protected override void OnUserInteractionComplete(TDisplayItem displayItem, UltraGridCell cell)
  {
    this._onClickAction(displayItem);
  }
}
