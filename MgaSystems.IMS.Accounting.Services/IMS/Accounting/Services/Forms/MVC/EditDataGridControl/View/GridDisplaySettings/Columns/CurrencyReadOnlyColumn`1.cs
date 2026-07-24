// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns.CurrencyReadOnlyColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;

public class CurrencyReadOnlyColumn<TDisplayItem> : 
  DisplayColumn<TDisplayItem, Decimal>,
  INumberColumn<TDisplayItem>
{
  private string _summaryId;

  protected override HAlign TextAlignment { get; } = (HAlign) 3;

  protected override HAlign HeaderAlignment { get; } = (HAlign) 3;

  protected override string Format { get; } = "c";

  public bool ShowSumSummary { get; set; }

  public CurrencyReadOnlyColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, Decimal> getBoundValueFromDisplayItemFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, getBoundValueFromDisplayItemFunc, getCellColorFromDisplayItemFunc)
  {
  }

  public CurrencyReadOnlyColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, double> getBoundValueFromDisplayItemFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, (Func<TDisplayItem, Decimal>) (item => Decimal.Parse(getBoundValueFromDisplayItemFunc(item).ToString())), getCellColorFromDisplayItemFunc)
  {
  }

  public CurrencyReadOnlyColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, Decimal> getBoundValueFromDisplayItemFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, getBoundValueFromDisplayItemFunc, getCellColorFromDisplayItemFunc)
  {
  }

  public CurrencyReadOnlyColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, double> getBoundValueFromDisplayItemFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, (Func<TDisplayItem, Decimal>) (item => Decimal.Parse(getBoundValueFromDisplayItemFunc(item).ToString())), getCellColorFromDisplayItemFunc)
  {
  }

  protected override void ChildApplyToColumn(UltraGridColumn column)
  {
    base.ChildApplyToColumn(column);
    if (!this.ShowSumSummary)
      return;
    this._summaryId = this._summaryId == null ? Guid.NewGuid().ToString() : throw new InvalidOperationException("Cannot show a summary if one is already shown.");
    GridExtensions.CreateSummary(column, this._summaryId, column.Band);
    column.Band.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((UltraGrid) null).ApplySummaryMGAStyle(column.Band);
  }
}
