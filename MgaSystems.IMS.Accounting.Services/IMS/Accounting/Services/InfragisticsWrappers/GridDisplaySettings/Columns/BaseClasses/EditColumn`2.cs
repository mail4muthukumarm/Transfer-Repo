// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses.EditColumn`2
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data;
using MGASystems.Data.CommonInterface;
using System;
using System.Collections.Generic;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;

public abstract class EditColumn<TDisplayItem, TColumn> : 
  DisplayColumn<TDisplayItem, TColumn>,
  IEditColumn<TDisplayItem, TColumn>,
  IDisplayColumn<TDisplayItem, TColumn>,
  IDisplayColumn<TDisplayItem>,
  IUltraGridColumnSettings<TDisplayItem>,
  IUltraGridColumnSettings,
  IUniqueObject<string>,
  IUniqueObject,
  IEditColumn<TDisplayItem>
{
  private Func<TDisplayItem, bool> _isCellEnabled = (Func<TDisplayItem, bool>) (displayItem => true);

  protected sealed override bool AllowEdit => true;

  protected override CellClickAction CellClickAction => (CellClickAction) 1;

  protected override Activation CellActivation => (Activation) 0;

  protected virtual Activation CellDisableActivation { get; } = (Activation) 3;

  protected Action<TDisplayItem, TColumn> SetFromDisplayValueAction { get; }

  protected BlockingRunner UpdateRunner { get; }

  protected UniqueObjectList<IDisplayColumn<TDisplayItem>> ColumnsAffectedByValueChange { get; private set; } = new UniqueObjectList<IDisplayColumn<TDisplayItem>>();

  public Func<TDisplayItem, bool> IsCellEnabledFunc
  {
    get => this._isCellEnabled;
    set
    {
      this._isCellEnabled = value ?? throw new InvalidOperationException($"Cannot set {this.IsCellEnabledFunc} to null.");
    }
  }

  protected EditColumn(
    string headerCaption,
    int width,
    Func<TDisplayItem, TColumn> getDisplayValueFunc,
    Action<TDisplayItem, TColumn> setFromDisplayValueAction,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(headerCaption, width, getDisplayValueFunc, getCellColorFromDisplayItemFunc)
  {
    this.SetFromDisplayValueAction = setFromDisplayValueAction ?? throw new ArgumentNullException(nameof (setFromDisplayValueAction));
    this.UpdateRunner = new BlockingRunner()
    {
      IgnoreInvocationIfRunning = true
    };
  }

  protected EditColumn(
    string identifier,
    string headerCaption,
    int width,
    Func<TDisplayItem, TColumn> getDisplayValueFunc,
    Action<TDisplayItem, TColumn> setFromDisplayValueAction,
    Func<TDisplayItem, Color> getCellColorFromDisplayItemFunc = null)
    : base(identifier, headerCaption, width, getDisplayValueFunc, getCellColorFromDisplayItemFunc)
  {
    this.SetFromDisplayValueAction = setFromDisplayValueAction ?? throw new ArgumentNullException(nameof (setFromDisplayValueAction));
    this.UpdateRunner = new BlockingRunner()
    {
      IgnoreInvocationIfRunning = true
    };
  }

  public void AddColumnAffectedByValueChanged(IDisplayColumn<TDisplayItem> column)
  {
    this.ColumnsAffectedByValueChange.Add(column);
  }

  public void AddColumnsAffectedByValueChanged(IEnumerable<IDisplayColumn<TDisplayItem>> columns)
  {
    this.ColumnsAffectedByValueChange.AddRange(columns);
  }

  public void UserSetValue(TDisplayItem displayItem, TColumn newValue)
  {
    UltraGridCell cell = (object) displayItem != null ? this.GetCellForDisplayItem(displayItem) : throw new ArgumentNullException(nameof (displayItem));
    this.ChildUserSetValue(cell, newValue);
    this.OnUserInteractionComplete(displayItem, cell);
  }

  protected override Activation GetCellActivation(TDisplayItem displayItem)
  {
    return !this.GetEnabledState(displayItem) ? this.CellDisableActivation : this.CellActivation;
  }

  protected override bool GetEnabledState(TDisplayItem displayItem)
  {
    return base.GetEnabledState(displayItem) && this.IsCellEnabledFunc(displayItem);
  }

  protected override void ChildAttachListeners(UltraGrid grid)
  {
    grid.AfterCellUpdate += new CellEventHandler(((ColumnBase<TDisplayItem>) this).HandlePostCellInteraction);
  }

  protected abstract TColumn CastToEditType(object newCellValue);

  protected virtual void ChildUserSetValue(UltraGridCell cell, TColumn newValue)
  {
    cell.Value = (object) newValue;
  }

  protected override void OnUserInteractionComplete(TDisplayItem displayItem, UltraGridCell cell)
  {
    this.UpdateRunner.Run((Action) (() =>
    {
      UltraGridRow row = cell.Row;
      TColumn cellValue = this.GetCellValue(cell);
      if (displayItem is ITrackChanges trackChanges2)
        trackChanges2.MarkChanged();
      this.SetFromDisplayValueAction(displayItem, cellValue);
      this.UpdateCellValues(displayItem, row);
      this.UpdateDisplayedCell(displayItem, row);
      cell.Refresh();
    }));
  }

  protected virtual TColumn GetCellValue(UltraGridCell cell) => this.CastToEditType(cell.Value);

  private void UpdateDisplayedCell(TDisplayItem displayItem, UltraGridRow row)
  {
    foreach (IDisplayColumn<TDisplayItem> displayColumn in (List<IDisplayColumn<TDisplayItem>>) this.ColumnsAffectedByValueChange)
    {
      if (displayColumn is EditColumn<TDisplayItem, TColumn> editColumn)
        editColumn.RefreshEnabledState(row, displayItem);
      row.Cells[((IUniqueObject<string>) displayColumn).UniqueIdentifier].Refresh();
    }
  }

  private void UpdateCellValues(TDisplayItem displayItem, UltraGridRow row)
  {
    foreach (IUltraGridColumnSettings<TDisplayItem> gridColumnSettings in (List<IDisplayColumn<TDisplayItem>>) this.ColumnsAffectedByValueChange)
      gridColumnSettings.UpdateCellValue(row, displayItem);
  }
}
