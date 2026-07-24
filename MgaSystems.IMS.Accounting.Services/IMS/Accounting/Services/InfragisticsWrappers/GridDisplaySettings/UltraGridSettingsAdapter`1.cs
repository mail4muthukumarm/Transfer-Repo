// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.UltraGridSettingsAdapter`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using GrapeCity.Viewer.Common;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;

public class UltraGridSettingsAdapter<TDisplayItem> : 
  IUltraGridAdapter<TDisplayItem>,
  IUltraGridAdapter
{
  private UltraGrid _appliedToGrid;
  private object _selectedObjectInGrid;

  public event EventHandler SelectedObjectInGridChanged;

  public event Action<object> RowDoubleClicked;

  public HAlign HeaderTextAlignment { get; set; } = (HAlign) 1;

  public HAlign CaptionTextAlignment { get; set; } = (HAlign) 1;

  public IUltraGridTableSettings<TDisplayItem> TopLevelTable { get; }

  public object SelectedObjectInGrid
  {
    get
    {
      if (this._appliedToGrid == null)
        throw new InvalidOperationException("Must apply settings to a grid before this operation!");
      return this._selectedObjectInGrid;
    }
    set
    {
      this.ClearGridSelected();
      if (!this.TopLevelTable.SetSelectedObjectInTableOrSubTable(value))
        throw new InvalidOperationException("Could not find matching value in grid to set to provided value to be selected.");
      this.SetSelectedObjectInGrid(value);
    }
  }

  public UltraGridSettingsAdapter(
    IUltraGridTableSettings<TDisplayItem> topLevelTable)
  {
    this.TopLevelTable = topLevelTable ?? throw new ArgumentNullException(nameof (topLevelTable));
  }

  public void ApplySettingsToGrid(UltraGrid grid)
  {
    UltraGrid ultraGrid = this._appliedToGrid == null ? this._appliedToGrid : throw new InvalidOperationException("Cannot apply to a grid! This adapter has already been applied.");
    this._appliedToGrid = grid ?? throw new ArgumentNullException(nameof (grid));
    this._appliedToGrid.UpdateMode = (UpdateMode) 2;
    this.SetGridDisplaySettings();
    this.SetGridAppearance();
    this.TopLevelTable.ApplyToGridAsTopLevelTable((UltraGridBase) this._appliedToGrid);
    this.ClearSelected();
  }

  public void InitializeListerners()
  {
    ((Control) this._appliedToGrid).MouseClick += new MouseEventHandler(this._grid_MouseClick);
    this._appliedToGrid.AfterEnterEditMode += new EventHandler(this._appliedToGrid_AfterEnterEditMode);
    this._appliedToGrid.DoubleClickRow += new DoubleClickRowEventHandler(this.Grid_DoubleClickRow);
    this._appliedToGrid.AfterRowActivate += new EventHandler(this.Grid_AfterRowActivate);
  }

  public void ClearSelected()
  {
    this.ClearGridSelected();
    this.SetSelectedObjectInGrid((object) null);
  }

  public void UpdateDisplayValuesForItem(object item)
  {
    if (this._appliedToGrid == null)
      throw new InvalidOperationException("Must apply settings to a grid before this operation!");
    IUltraGridTableSettings<TDisplayItem> topLevelTable = this.TopLevelTable;
    object obj = item;
    if (obj == null)
      throw new ArgumentNullException(nameof (item));
    if (!topLevelTable.UpdateValuesForItem(obj))
      throw new InvalidOperationException($"Object to update was not found in list. {item}");
    ((UltraControlBase) this._appliedToGrid).Update();
  }

  public void MoveRowToTopOfTable(object item)
  {
    ((UltraControlBase) this._appliedToGrid).Update();
    if (!this.TopLevelTable.MoveRowToTop(item))
      throw new InvalidOperationException("Cannot move row for display item that is not visible or does not exist.");
  }

  public void ReMapObjectsToRows()
  {
    IUltraGridTableSettings<TDisplayItem> topLevelTable = this.TopLevelTable;
    topLevelTable.ReMapObjectsToRows(this._appliedToGrid ?? throw new InvalidOperationException("Must apply settings to a grid before this operation!"));
  }

  private void Grid_AfterRowActivate(object sender, EventArgs e)
  {
    this.SetSelectedObjectInGrid(((UltraGridBase) this._appliedToGrid).ActiveRow.ListObject);
  }

  private void Grid_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    Action<object> rowDoubleClicked = this.RowDoubleClicked;
    if (rowDoubleClicked == null)
      return;
    rowDoubleClicked(e.Row.ListObject);
  }

  private void ClearGridSelected()
  {
    if (this._appliedToGrid == null)
      throw new InvalidOperationException("Must apply settings to a grid before this operation!");
    ((UltraGridBase) this._appliedToGrid).ActiveRow = (UltraGridRow) null;
    this._appliedToGrid.Selected.Rows.Clear();
  }

  private void SetSelectedObjectInGrid(object value)
  {
    this._selectedObjectInGrid = value;
    EventHandler objectInGridChanged = this.SelectedObjectInGridChanged;
    if (objectInGridChanged == null)
      return;
    objectInGridChanged((object) this, EventArgs.Empty);
  }

  private void SetGridDisplaySettings()
  {
    UltraGridLayout displayLayout = ((UltraGridBase) this._appliedToGrid).DisplayLayout;
    displayLayout.Override.HeaderAppearance.TextHAlign = this.HeaderTextAlignment;
    displayLayout.Override.RowFilterMode = (RowFilterMode) 1;
    displayLayout.CaptionAppearance.TextHAlign = this.CaptionTextAlignment;
    displayLayout.Override.MaxSelectedRows = 1;
    EnumerableExtensions.ForEach<object>((IEnumerable<object>) ((SubObjectsCollectionBase) displayLayout.Bands).All, (Action<object>) (band => (band as UltraGridBand).Hidden = true));
  }

  private void _appliedToGrid_AfterEnterEditMode(object sender, EventArgs e)
  {
    this.SetSelectedObjectInGrid(this.TopLevelTable.GetSelectedObjectInTableOrSubTable());
  }

  private void SetGridAppearance()
  {
    Appearance appearance = new Appearance();
    ((AppearanceBase) appearance).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this._appliedToGrid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance;
  }

  private void _grid_MouseClick(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right)
      return;
    this.HandleRightClick();
  }

  private void HandleRightClick()
  {
    UltraGridRow selectedRow = this._appliedToGrid.SetContextActiveRow();
    if (selectedRow != null)
    {
      this.SetSelectedObjectInGrid(selectedRow.ListObject);
      if (!this.TopLevelTable.ShowContextMenuForRow(selectedRow))
        throw new Exception("could not determine context menu to show!");
    }
    else
      this.SetSelectedObjectInGrid((object) null);
  }
}
