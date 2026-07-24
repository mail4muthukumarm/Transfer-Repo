// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.TextEditButtonColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns;

public class TextEditButtonColumn<TDisplayItem> : TextEditColumn<TDisplayItem>
{
  private readonly object _buttonImage;
  private readonly Action<TDisplayItem> _buttonAction;
  private readonly bool _disableButtonWithRow;

  protected override ColumnStyle ColumnDisplayStyle { get; } = (ColumnStyle) 2;

  public TextEditButtonColumn(
    string headerCaption,
    int width,
    bool selectWhenEdit,
    Func<TDisplayItem, string> getBoundValueFromDisplayItemFunc,
    Action<TDisplayItem, string> setValueAction,
    object buttonImage,
    Action<TDisplayItem> buttonAction,
    bool disableButtonWithRow = true,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, selectWhenEdit, getBoundValueFromDisplayItemFunc, setValueAction, getCellColorFromDisplayItemFunc)
  {
    this._buttonImage = buttonImage ?? throw new ArgumentNullException(nameof (buttonImage));
    this._buttonAction = buttonAction ?? throw new ArgumentNullException(nameof (buttonAction));
    this._disableButtonWithRow = disableButtonWithRow;
  }

  public TextEditButtonColumn(
    string identifier,
    string headerCaption,
    int width,
    bool selectWhenEdit,
    Func<TDisplayItem, string> getBoundValueFromDisplayItemFunc,
    Action<TDisplayItem, string> setValueAction,
    object buttonImage,
    Action<TDisplayItem> buttonAction,
    bool disableButtonWithRow = true,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, selectWhenEdit, getBoundValueFromDisplayItemFunc, setValueAction, getCellColorFromDisplayItemFunc)
  {
    this._buttonImage = buttonImage ?? throw new ArgumentNullException(nameof (buttonImage));
    this._buttonAction = buttonAction ?? throw new ArgumentNullException(nameof (buttonAction));
    this._disableButtonWithRow = disableButtonWithRow;
  }

  protected override void ChildApplyToColumn(UltraGridColumn column)
  {
    base.ChildApplyToColumn(column);
    Appearance appearance = new Appearance();
    ((AppearanceBase) appearance).Image = this._buttonImage;
    column.CellButtonAppearance = (AppearanceBase) appearance;
  }

  protected override void ChildAttachListeners(UltraGrid grid)
  {
    grid.ClickCellButton += new CellEventHandler(((ColumnBase<TDisplayItem>) this).HandlePostCellInteraction);
  }

  protected override void OnUserInteractionComplete(TDisplayItem displayItem, UltraGridCell cell)
  {
    this._buttonAction(displayItem);
  }

  protected override bool GetEnabledState(TDisplayItem displayItem)
  {
    return base.GetEnabledState(displayItem) || !this._disableButtonWithRow;
  }
}
