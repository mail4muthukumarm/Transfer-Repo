// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns.IntegerReadOnlyColumn`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using System;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;

public class IntegerReadOnlyColumn<TDisplayItem> : 
  DisplayColumn<TDisplayItem, int?>,
  INumberColumn<TDisplayItem>,
  IComboBoxColumn<TDisplayItem>,
  IComboBoxColumn,
  IReadOnlyColumn,
  IUltraGridColumnSettings,
  IUniqueObject<string>,
  IUniqueObject,
  IReadOnlyColumn<TDisplayItem>,
  IUltraGridColumnSettings<TDisplayItem>
{
  private string _summaryId;

  public bool ShowSumSummary { get; set; }

  public bool IsComboBoxSelectionDisplayColumn { get; set; }

  public IntegerReadOnlyColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, int?> getBoundValueFromDisplayItemFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, IntegerReadOnlyColumn<TDisplayItem>.GetBoundValue(getBoundValueFromDisplayItemFunc), getCellColorFromDisplayItemFunc)
  {
  }

  public IntegerReadOnlyColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, int?> getBoundValueFromDisplayItemFunc,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, IntegerReadOnlyColumn<TDisplayItem>.GetBoundValue(getBoundValueFromDisplayItemFunc), getCellColorFromDisplayItemFunc)
  {
  }

  private static Func<TDisplayItem, int?> GetBoundValue(
    Func<TDisplayItem, int?> getBoundValueFromDisplayItemFunc)
  {
    return getBoundValueFromDisplayItemFunc != null ? (Func<TDisplayItem, int?>) (item => (object) item == null ? new int?() : getBoundValueFromDisplayItemFunc(item)) : throw new ArgumentNullException(nameof (getBoundValueFromDisplayItemFunc));
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
