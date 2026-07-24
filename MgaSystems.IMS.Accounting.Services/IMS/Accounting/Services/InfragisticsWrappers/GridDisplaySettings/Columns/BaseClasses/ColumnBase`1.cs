// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses.ColumnBase`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.Data.CommonInterface;
using System;
using System.Collections.Generic;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;

public abstract class ColumnBase<TDisplayItem> : 
  IUltraGridColumnSettings<TDisplayItem>,
  IUltraGridColumnSettings,
  IUniqueObject<string>,
  IUniqueObject
{
  private bool _hasAttachedListeners;
  private readonly BlockingRunner _setCellValueRunner = new BlockingRunner();
  private Func<TDisplayItem, bool> _rowEnabledFunc;
  private Dictionary<TDisplayItem, UltraGridCell> _appliedToCells = new Dictionary<TDisplayItem, UltraGridCell>();

  object IUniqueObject.UniqueIdentifier => (object) this.UniqueIdentifier;

  protected Func<TDisplayItem, Color> GetCellColorFromDisplayItemFunc { get; }

  private static Func<TDisplayItem, Color> _getColorDefault { get; } = (Func<TDisplayItem, Color>) (_ => Color.Black);

  protected abstract bool AllowEdit { get; }

  protected abstract Activation CellActivation { get; }

  protected virtual bool AllowFilter => true;

  protected abstract ColumnStyle ColumnDisplayStyle { get; }

  protected abstract CellClickAction CellClickAction { get; }

  protected UltraGridColumn AppliedToColumn { get; private set; }

  protected UltraGridBase AppliedToGrid { get; private set; }

  protected virtual HAlign TextAlignment { get; } = (HAlign) 1;

  protected virtual HAlign HeaderAlignment { get; } = (HAlign) 1;

  protected virtual string Format { get; } = string.Empty;

  public string HeaderText { get; }

  public string UniqueIdentifier { get; }

  public int Width { get; }

  public bool Visible { get; set; } = true;

  public Func<TDisplayItem, string> GetToolTipText { get; set; }

  protected ColumnBase(
    string headerText,
    int width,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : this(Guid.NewGuid().ToString(), headerText, width, getCellColorFromDisplayItemFunc)
  {
  }

  protected ColumnBase(
    string identifier,
    string headerText,
    int width,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
  {
    if (string.IsNullOrEmpty(headerText))
      throw new ArgumentException("headerText must have a value that is not null, empty, or white space.");
    if (width <= 0)
      throw new ArgumentOutOfRangeException("Width must be > 0.");
    this.UniqueIdentifier = identifier ?? throw new ArgumentNullException(nameof (identifier));
    this.HeaderText = headerText;
    this.Width = width;
    this.GetCellColorFromDisplayItemFunc = this.GetCellColorFunc(getCellColorFromDisplayItemFunc ?? ColumnBase<TDisplayItem>._getColorDefault);
  }

  public void AttachListeners(UltraGridBase grid)
  {
    if (this._hasAttachedListeners)
      throw new InvalidOperationException("Cannot attach to more than one grid!");
    if (grid == null)
      throw new ArgumentNullException(nameof (grid));
    if (grid is UltraGrid grid1)
      this.ChildAttachListeners(grid1);
    this._hasAttachedListeners = true;
  }

  public void ApplyToColumn(UltraGridColumn column, Func<TDisplayItem, bool> rowEnabledFunc)
  {
    this.AppliedToColumn = this.AppliedToColumn == null ? column : throw new InvalidOperationException("Cannot apply to more than one column.");
    this._rowEnabledFunc = rowEnabledFunc ?? throw new ArgumentNullException(nameof (rowEnabledFunc));
    column.Hidden = !this.Visible;
    column.Width = this.Width;
    column.AutoEditMode = this.AllowEdit ? (DefaultableBoolean) 1 : (DefaultableBoolean) 2;
    column.AllowRowFiltering = this.AllowFilter ? (DefaultableBoolean) 1 : (DefaultableBoolean) 2;
    column.Style = this.ColumnDisplayStyle;
    column.CellClickAction = this.CellClickAction;
    column.TipStyleCell = (TipStyle) 1;
    column.CellAppearance.TextHAlign = this.TextAlignment;
    ((HeaderBase) column.Header).Appearance.TextHAlign = this.HeaderAlignment;
    column.Format = this.Format;
    this.ChildApplyToColumn(column);
  }

  public void SetInitialCellValue(UltraGridRow row, TDisplayItem displayItem)
  {
    this.SetInitialCellValue(this.GetCellFromRow(row), displayItem);
  }

  public void SetInitialCellValue(UltraGridCell cell, TDisplayItem displayItem)
  {
    this.RefreshEnabledState(cell, displayItem);
    if (this._appliedToCells.ContainsKey(displayItem))
      throw new ArgumentException("cannot apply to cell more than once!");
    this._appliedToCells.Add(displayItem, cell);
    this.UpdateCellValue(cell, displayItem);
    this.ChildSetInitialCellValue(cell, displayItem);
  }

  public void UpdateCellValue(UltraGridRow row, TDisplayItem displayItem)
  {
    this.UpdateCellValue(this.GetCellFromRow(row), displayItem);
  }

  public void UpdateCellValue(UltraGridCell cell, TDisplayItem displayItem)
  {
    if (cell == null)
      throw new ArgumentNullException(nameof (cell));
    TDisplayItem displayItem1 = (object) displayItem != null ? displayItem : throw new ArgumentNullException(nameof (displayItem));
    this._setCellValueRunner.Run((Action) (() =>
    {
      this.SetToolTipText(cell, displayItem);
      this.SetCellDisplayValue(cell, displayItem);
    }));
  }

  public void RefreshEnabledState(UltraGridRow row, TDisplayItem displayItem)
  {
    this.RefreshEnabledState(this.GetCellFromRow(row), displayItem);
  }

  public void RefreshEnabledState(UltraGridCell cell, TDisplayItem displayItem)
  {
    if (cell == null)
      throw new ArgumentNullException(nameof (cell));
    cell.Activation = (object) displayItem != null ? this.GetCellActivation(displayItem) : throw new ArgumentNullException();
  }

  public UltraGridCell GetCellFromRow(UltraGridRow row)
  {
    if (row == null)
      throw new ArgumentNullException(nameof (row));
    try
    {
      return row.Cells[this.UniqueIdentifier];
    }
    catch (Exception ex)
    {
      throw new InvalidOperationException($"Could not find a cell in the row that has the same key as this column {this.UniqueIdentifier}. Has ApplyToColumn been called?");
    }
  }

  protected virtual void ChildAttachListeners(UltraGrid grid)
  {
  }

  protected UltraGridCell GetCellForDisplayItem(TDisplayItem item)
  {
    UltraGridCell cellForDisplayItem;
    if (!this._appliedToCells.TryGetValue(item, out cellForDisplayItem))
      throw new InvalidOperationException("Cannot determine cell in this column for provided item.");
    return cellForDisplayItem;
  }

  protected void HandlePostCellInteraction(object sender, CellEventArgs e)
  {
    UltraGridCell cell = e.Cell;
    if (this._setCellValueRunner.IsRunning || !(cell.Row.ListObject is TDisplayItem listObject) || !cell.Column.Equals((object) this.AppliedToColumn) || !this.GetEnabledState(listObject))
      return;
    this.OnUserInteractionComplete(listObject, cell);
  }

  protected virtual void ChildSetInitialCellValue(UltraGridCell cell, TDisplayItem displayItem)
  {
  }

  protected virtual Activation GetCellActivation(TDisplayItem displayItem) => this.CellActivation;

  protected virtual void OnUserInteractionComplete(TDisplayItem displayItem, UltraGridCell cell)
  {
  }

  protected virtual void ChildApplyToColumn(UltraGridColumn column)
  {
  }

  protected abstract void SetCellDisplayValue(UltraGridCell cell, TDisplayItem dataObject);

  protected virtual bool GetEnabledState(TDisplayItem displayItem)
  {
    if ((object) displayItem == null)
      throw new ArgumentNullException(nameof (displayItem));
    Func<TDisplayItem, bool> rowEnabledFunc = this._rowEnabledFunc;
    if (rowEnabledFunc == null)
      throw new InvalidOperationException("Must Apply to a column before getting the enabled state.");
    return rowEnabledFunc(displayItem);
  }

  private Func<TDisplayItem, Color> GetCellColorFunc(
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc)
  {
    return (Func<TDisplayItem, Color>) (item => (object) item == null ? Color.Black : getCellColorFromDisplayItemFunc(item));
  }

  private void SetToolTipText(UltraGridCell cell, TDisplayItem displayItem)
  {
    UltraGridCell ultraGridCell = cell;
    Func<TDisplayItem, string> getToolTipText = this.GetToolTipText;
    string str = (getToolTipText != null ? getToolTipText(displayItem) : (string) null) ?? string.Empty;
    ultraGridCell.ToolTipText = str;
  }
}
