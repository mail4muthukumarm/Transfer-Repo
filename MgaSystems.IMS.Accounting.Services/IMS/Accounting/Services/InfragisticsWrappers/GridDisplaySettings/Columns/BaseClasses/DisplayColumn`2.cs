// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses.DisplayColumn`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data.CommonInterface;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;

public abstract class DisplayColumn<TDisplayItem, TColumn> : 
  ColumnBase<TDisplayItem>,
  IDisplayColumn<TDisplayItem, TColumn>,
  IDisplayColumn<TDisplayItem>,
  IUltraGridColumnSettings<TDisplayItem>,
  IUltraGridColumnSettings,
  IUniqueObject<string>,
  IUniqueObject
{
  protected override bool AllowEdit => false;

  protected override CellClickAction CellClickAction => (CellClickAction) 2;

  protected override ColumnStyle ColumnDisplayStyle => (ColumnStyle) 0;

  protected override Activation CellActivation { get; } = (Activation) 1;

  public Func<TDisplayItem, TColumn> GetDisplayValueFunc { get; }

  protected DisplayColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, TColumn> getDisplayValueFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, getCellColorFromDisplayItemFunc)
  {
    this.GetDisplayValueFunc = getDisplayValueFunc ?? throw new ArgumentNullException(nameof (getDisplayValueFunc));
  }

  protected DisplayColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, TColumn> getDisplayValueFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, getCellColorFromDisplayItemFunc)
  {
    this.GetDisplayValueFunc = getDisplayValueFunc ?? throw new ArgumentNullException(nameof (getDisplayValueFunc));
  }

  protected override void SetCellDisplayValue(UltraGridCell cell, TDisplayItem dataObject)
  {
    cell.Value = (object) this.GetDisplayValueFunc(dataObject);
    ((AppearanceBase) cell.Appearance).ForeColor = this.GetCellColorFromDisplayItemFunc(dataObject);
  }

  protected override void ChildApplyToColumn(UltraGridColumn column)
  {
    base.ChildApplyToColumn(column);
    column.DataType = typeof (TColumn);
  }
}
