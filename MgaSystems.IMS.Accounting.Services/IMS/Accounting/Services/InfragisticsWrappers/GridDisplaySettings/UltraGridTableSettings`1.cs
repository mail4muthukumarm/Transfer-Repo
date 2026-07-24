// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.UltraGridTableSettings`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using GrapeCity.Viewer.Common;
using Infragistics.Shared;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data.CommonInterface;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.Filter;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.PopupMenu;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Utility;
using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings;

public class UltraGridTableSettings<TDisplayItem> : 
  UniqueObject<string>,
  IUltraGridTableSettings<TDisplayItem>,
  IUltraGridTableSettings,
  IUltraGridTableAdapter,
  IUniqueObject<string>,
  IUniqueObject,
  IUltraGridTableAdapter<TDisplayItem>
{
  private UltraGridBand _appliedToBand;
  private UltraGridBase _grid;
  private IUltraGridColumnSettings<TDisplayItem>[] _columnSettings;
  private Dictionary<TDisplayItem, UltraGridRow> _objectRowMap = new Dictionary<TDisplayItem, UltraGridRow>();
  private readonly IUltraGridTableSettings[] _subTables = new IUltraGridTableSettings[0];

  public override string UniqueIdentifier { get; }

  public bool IsTopLevelTable => base.UniqueIdentifier == null;

  public UltraGridFilterAdapter<TDisplayItem> FilterAdapter { get; set; }

  public RightClickMenu RightClickMenuSettings { get; set; }

  public Func<TDisplayItem, bool> RowEnabledFunc { get; set; } = (Func<TDisplayItem, bool>) (displayItem => true);

  public UltraGridTableSettings(
    IUltraGridColumnSettings<TDisplayItem>[] columnSettings)
  {
    this._columnSettings = columnSettings ?? throw new ArgumentNullException(nameof (columnSettings));
    this.ValidateColumnSettings();
  }

  public UltraGridTableSettings(
    IUltraGridColumnSettings<TDisplayItem>[] columnSettings,
    IUltraGridTableSettings[] subTables)
    : this(columnSettings)
  {
    this._subTables = subTables ?? throw new ArgumentNullException(nameof (subTables));
    this.ValidateSubTables();
  }

  public UltraGridTableSettings(
    IUltraGridColumnSettings<TDisplayItem>[] columnSettings,
    IUltraGridTableSettings subTable)
    : this(columnSettings, new IUltraGridTableSettings[1]
    {
      subTable
    })
  {
  }

  public UltraGridTableSettings(
    string identifier,
    IUltraGridColumnSettings<TDisplayItem>[] columnSettings)
    : this(columnSettings)
  {
    this.UniqueIdentifier = identifier ?? throw new ArgumentNullException(nameof (identifier));
    if (string.IsNullOrWhiteSpace(identifier))
      throw new ArgumentException("Identifier must be not be whitespace or empty.");
  }

  public UltraGridTableSettings(
    string identifier,
    IUltraGridColumnSettings<TDisplayItem>[] columnSettings,
    IUltraGridTableSettings[] subTables)
    : this(columnSettings, subTables)
  {
    this.UniqueIdentifier = identifier ?? throw new ArgumentNullException(nameof (identifier));
    if (string.IsNullOrWhiteSpace(identifier))
      throw new ArgumentException("Identifier must be not be whitespace or empty.");
  }

  public UltraGridTableSettings(
    string identifier,
    IUltraGridColumnSettings<TDisplayItem>[] columnSettings,
    IUltraGridTableSettings subTable)
    : this(identifier, columnSettings, new IUltraGridTableSettings[1]
    {
      subTable
    })
  {
  }

  public bool HasFilterAdapter() => this.FilterAdapter != null;

  public void ApplyToGridAsTopLevelTable(UltraGridBase grid)
  {
    if (grid == null)
      throw new ArgumentNullException(nameof (grid));
    this.SetColumns(((IEnumerable<object>) ((SubObjectsCollectionBase) grid.DisplayLayout.Bands).All).Select<object, UltraGridBand>((Func<object, UltraGridBand>) (x => x as UltraGridBand)).ToSimpleTree<UltraGridBand>((Func<UltraGridBand, UltraGridBand>) (x => x.ParentBand), (Func<UltraGridBand, string>) (x => ((KeyedSubObjectBase) x).Key)), grid);
    this.PopulateRows(grid.Rows);
    this.AttachListeners(grid);
    this.SetRightClickMenu(grid);
    this.AttachRowCreationListerners(grid);
  }

  private void AttachRowCreationListerners(UltraGridBase grid)
  {
    if (!(grid is UltraGrid ultraGrid))
      return;
    ultraGrid.InitializeRow += new InitializeRowEventHandler(this.Grid_InitializeRow);
  }

  public void ReMapObjectsToRows(UltraGrid appliedToGrid)
  {
    if (appliedToGrid == null)
      throw new ArgumentNullException(nameof (appliedToGrid));
    this._objectRowMap = new Dictionary<TDisplayItem, UltraGridRow>();
    this.PopulateRows(((UltraGridBase) appliedToGrid).Rows);
  }

  public void SetRightClickMenu(UltraGridBase grid)
  {
    if (grid == null)
      throw new ArgumentNullException(nameof (grid));
    this.RightClickMenuSettings?.ApplyToGrid(grid);
    EnumerableExtensions.ForEach<IUltraGridTableSettings>((IEnumerable<IUltraGridTableSettings>) this._subTables, (Action<IUltraGridTableSettings>) (table => table.SetRightClickMenu(grid)));
  }

  public void SetColumns(SimpleTreeNode<UltraGridBand> bandNode, UltraGridBase grid)
  {
    if (this.IsAppliedToGrid())
      throw new InvalidOperationException("Cannot set columns more than once.");
    this._appliedToBand = bandNode?.Node ?? throw new ArgumentNullException(nameof (bandNode));
    this._grid = grid ?? throw new ArgumentNullException(nameof (grid));
    this._appliedToBand.Hidden = false;
    this.HideAllColumns();
    this.CreateColumns();
    this.FilterAdapter?.ApplyToBand(this._appliedToBand);
    this.CreateSubTableColumns(bandNode, grid);
  }

  public void SubTablePopulate(UltraGridChildBand childBand)
  {
    this.PopulateRows(childBand?.Rows ?? throw new ArgumentNullException(nameof (childBand)));
  }

  public void AttachListeners(UltraGridBase grid)
  {
    if (grid == null)
      throw new ArgumentNullException(nameof (grid));
    EnumerableExtensions.ForEach<IUltraGridColumnSettings<TDisplayItem>>((IEnumerable<IUltraGridColumnSettings<TDisplayItem>>) this._columnSettings, (Action<IUltraGridColumnSettings<TDisplayItem>>) (setting => setting.AttachListeners(grid)));
    EnumerableExtensions.ForEach<IUltraGridTableSettings>((IEnumerable<IUltraGridTableSettings>) this._subTables, (Action<IUltraGridTableSettings>) (table => table.AttachListeners(grid)));
  }

  public bool IsObjectVisibleAsRow(object obj)
  {
    if (!this.IsAppliedToGrid())
      throw new InvalidOperationException("Unable to check visibility for an object pre grid application.");
    if (obj == null)
      throw new ArgumentNullException(nameof (obj));
    if (obj is TDisplayItem key && this._objectRowMap.ContainsKey(key))
      return !this._objectRowMap[key].IsFilteredOut;
    foreach (IUltraGridTableAdapter subTable in this._subTables)
    {
      if (subTable.IsObjectVisibleAsRow(obj))
        return true;
    }
    return false;
  }

  public bool UpdateValuesForItem(object obj)
  {
    if (!this.IsAppliedToGrid())
      throw new InvalidOperationException("Unable to update values for item pre grid application.");
    if (obj == null)
      return false;
    if (obj is TDisplayItem key && this._objectRowMap.ContainsKey(key))
    {
      this.UpdateValuesForDisplayItem(key);
      return true;
    }
    foreach (IUltraGridTableAdapter subTable in this._subTables)
    {
      if (subTable.UpdateValuesForItem(obj))
        return true;
    }
    return false;
  }

  private void UpdateValuesForDisplayItem(IMvcModel model)
  {
    this.UpdateValuesForDisplayItem((TDisplayItem) model);
  }

  private void UpdateValuesForDisplayItem(TDisplayItem item)
  {
    if ((object) item == null)
      return;
    UltraGridRow objectRow = this._objectRowMap[item];
    foreach (IUltraGridColumnSettings<TDisplayItem> columnSetting in this._columnSettings)
    {
      columnSetting.UpdateCellValue(objectRow.Cells[((IUniqueObject<string>) columnSetting).UniqueIdentifier], item);
      columnSetting.RefreshEnabledState(objectRow, item);
    }
  }

  public bool ShowContextMenuForRow(UltraGridRow row)
  {
    if (!this.IsAppliedToGrid())
      throw new InvalidOperationException("Unable to show context menu for a row pre grid application.");
    if (row == null)
      throw new ArgumentNullException(nameof (row));
    if (row.ListObject is TDisplayItem listObject && this._objectRowMap.ContainsKey(listObject))
    {
      this.RightClickMenuSettings?.DisplayContextMenu();
      return true;
    }
    foreach (IUltraGridTableAdapter subTable in this._subTables)
    {
      if (subTable.ShowContextMenuForRow(row))
        return true;
    }
    return false;
  }

  public object GetSelectedObjectInTableOrSubTable()
  {
    if (!this.IsAppliedToGrid())
      throw new InvalidOperationException("Unable to get selected object in grid pre grid application.");
    foreach (UltraGridRow ultraGridRow in this._objectRowMap.Values)
    {
      if (((GridItemBase) ultraGridRow).Selected || ((IEnumerable<object>) ((SubObjectsCollectionBase) ultraGridRow.Cells).All).Select<object, UltraGridCell>((Func<object, UltraGridCell>) (x => x as UltraGridCell)).Any<UltraGridCell>((Func<UltraGridCell, bool>) (cell => ((GridItemBase) cell).Selected || cell.IsInEditMode)))
        return ultraGridRow.ListObject;
    }
    foreach (IUltraGridTableAdapter subTable in this._subTables)
    {
      object inTableOrSubTable = subTable.GetSelectedObjectInTableOrSubTable();
      if (inTableOrSubTable != null)
        return inTableOrSubTable;
    }
    return (object) null;
  }

  public bool SetSelectedObjectInTableOrSubTable(object selected)
  {
    if (!this.IsAppliedToGrid())
      throw new InvalidOperationException("Unable to set selected row in grid pre grid application.");
    if (selected == null)
      throw new ArgumentNullException(nameof (selected));
    foreach (TDisplayItem key in this._objectRowMap.Keys)
    {
      if (key.Equals(selected))
      {
        UltraGridRow objectRow = this._objectRowMap[key];
        ((GridItemBase) objectRow).Selected = true;
        this._grid.ActiveRowScrollRegion.FirstRow = objectRow;
        return true;
      }
    }
    foreach (IUltraGridTableAdapter subTable in this._subTables)
    {
      if (subTable.SetSelectedObjectInTableOrSubTable(selected))
        return true;
    }
    return false;
  }

  public bool MoveRowToTop(object displayItem)
  {
    if (!this.IsAppliedToGrid())
      throw new InvalidOperationException("Unable to set selected row in grid pre grid application.");
    if (displayItem is TDisplayItem key && this._objectRowMap.ContainsKey(key))
    {
      this._grid.Rows.Move(this._objectRowMap[key], 0);
      return true;
    }
    foreach (IUltraGridTableSettings subTable in this._subTables)
    {
      if (subTable.MoveRowToTop(displayItem))
        return true;
    }
    return false;
  }

  public void SetFilter(Func<TDisplayItem, bool> filter)
  {
    if (!this.HasFilterAdapter())
      throw new InvalidOperationException("You must define a filter adapter before setting the filter.");
    UltraGridFilterAdapter<TDisplayItem> filterAdapter = this.FilterAdapter;
    filterAdapter.SetFilter(filter ?? throw new ArgumentNullException(nameof (filter)));
  }

  public void ClearFilter()
  {
    if (!this.HasFilterAdapter())
      throw new InvalidOperationException("You must define a filter adapter before setting the filter.");
    this.FilterAdapter.ClearFilter();
  }

  public int GetPreferredWidth()
  {
    return ((IEnumerable<IUltraGridColumnSettings<TDisplayItem>>) this._columnSettings).Where<IUltraGridColumnSettings<TDisplayItem>>((Func<IUltraGridColumnSettings<TDisplayItem>, bool>) (column => column.Visible)).Sum<IUltraGridColumnSettings<TDisplayItem>>((Func<IUltraGridColumnSettings<TDisplayItem>, int>) (column => column.Width));
  }

  public void AddColumn(IUltraGridColumnSettings<TDisplayItem> column, int index)
  {
    if (this.IsAppliedToGrid())
      throw new InvalidOperationException("Unable to remove columns post grid application.");
    if (index < 0)
      throw new ArgumentOutOfRangeException("index must be >= 0.");
    if (index > this._columnSettings.Length)
      index = this._columnSettings.Length;
    List<IUltraGridColumnSettings<TDisplayItem>> list = ((IEnumerable<IUltraGridColumnSettings<TDisplayItem>>) this._columnSettings).ToList<IUltraGridColumnSettings<TDisplayItem>>();
    List<IUltraGridColumnSettings<TDisplayItem>> gridColumnSettingsList = list;
    int index1 = index;
    gridColumnSettingsList.Insert(index1, column ?? throw new ArgumentNullException(nameof (column)));
    this._columnSettings = list.ToArray();
  }

  public IUltraGridColumnSettings<TDisplayItem> GetColumnByKey(string columnKey)
  {
    if (columnKey == null)
      throw new ArgumentNullException(nameof (columnKey));
    if (string.IsNullOrWhiteSpace(columnKey))
      throw new ArgumentException("Column key must be non empty non whitespace.");
    return ((IEnumerable<IUltraGridColumnSettings<TDisplayItem>>) this._columnSettings).FirstOrDefault<IUltraGridColumnSettings<TDisplayItem>>((Func<IUltraGridColumnSettings<TDisplayItem>, bool>) (c => ((IUniqueObject<string>) c).UniqueIdentifier.Equals(columnKey))) ?? throw new InvalidOperationException($"Could not find column with key: {columnKey}.");
  }

  public void AddColumn(IUltraGridColumnSettings<TDisplayItem> column)
  {
    this.AddColumn(column, this._columnSettings.Length);
  }

  public void AddColumnAfter(
    IUltraGridColumnSettings<TDisplayItem> columnToAdd,
    string afterColumnWithKey)
  {
    int columnLocation = this.GetColumnLocation(afterColumnWithKey);
    this.AddColumn(columnToAdd, columnLocation + 1);
  }

  public void AddColumnsAfter(
    IUltraGridColumnSettings<TDisplayItem>[] columnsToAdd,
    string afterColumnWithKey)
  {
    int num = this.GetColumnLocation(afterColumnWithKey) + 1;
    for (int index = 0; index < columnsToAdd.Length; ++index)
      this.AddColumn(columnsToAdd[index], num + index);
  }

  public void AddColumnBefore(
    IUltraGridColumnSettings<TDisplayItem> columnToAdd,
    string beforeColumnWithKey)
  {
    int columnLocation = this.GetColumnLocation(beforeColumnWithKey);
    this.AddColumn(columnToAdd, columnLocation);
  }

  public void AddColumnsBefore(
    IUltraGridColumnSettings<TDisplayItem>[] columnsToAdd,
    string beforeColumnWithKey)
  {
    int columnLocation = this.GetColumnLocation(beforeColumnWithKey);
    for (int index = columnsToAdd.Length - 1; index >= 0; --index)
      this.AddColumn(columnsToAdd[index], columnLocation);
  }

  public int GetColumnLocation(string columnKey)
  {
    IUltraGridColumnSettings<TDisplayItem> column = this.GetColumnByKey(columnKey);
    return Array.FindIndex<IUltraGridColumnSettings<TDisplayItem>>(this._columnSettings, (Predicate<IUltraGridColumnSettings<TDisplayItem>>) (setting => setting.Equals((object) column)));
  }

  public void RemoveColumn(string columnKey)
  {
    if (this.IsAppliedToGrid())
      throw new InvalidOperationException("Unable to remove columns post grid application.");
    IUltraGridColumnSettings<TDisplayItem> columnByKey = this.GetColumnByKey(columnKey);
    List<IUltraGridColumnSettings<TDisplayItem>> list = ((IEnumerable<IUltraGridColumnSettings<TDisplayItem>>) this._columnSettings).ToList<IUltraGridColumnSettings<TDisplayItem>>();
    list.Remove(columnByKey);
    this._columnSettings = list.ToArray();
  }

  private void CreateSubTableColumns(SimpleTreeNode<UltraGridBand> bandNode, UltraGridBase grid)
  {
    foreach (IUltraGridTableSettings subTable1 in this._subTables)
    {
      IUltraGridTableSettings subTable = subTable1;
      SimpleTreeNode<UltraGridBand> band = bandNode.ChildNodes.SingleOrDefault<SimpleTreeNode<UltraGridBand>>((Func<SimpleTreeNode<UltraGridBand>, bool>) (x => ((UniqueObject<string>) x).UniqueIdentifier.Equals(((IUniqueObject<string>) subTable).UniqueIdentifier))) ?? throw new InvalidOperationException("Cannot find band with key " + ((IUniqueObject<string>) subTable).UniqueIdentifier);
      subTable.SetColumns(band, grid);
    }
  }

  private void CreateColumns()
  {
    foreach (IUltraGridColumnSettings<TDisplayItem> columnSetting in this._columnSettings)
    {
      UltraGridColumn column = this._appliedToBand.Columns.Add(((IUniqueObject<string>) columnSetting).UniqueIdentifier, columnSetting.HeaderText);
      columnSetting.ApplyToColumn(column, this.RowEnabledFunc);
    }
  }

  private void PopulateChildBands(ChildBandsCollection childBand)
  {
    foreach (IUltraGridTableSettings subTable1 in this._subTables)
    {
      IUltraGridTableSettings subTable = subTable1;
      UltraGridChildBand childBand1 = ((IEnumerable<object>) ((SubObjectsCollectionBase) childBand).All).Select<object, UltraGridChildBand>((Func<object, UltraGridChildBand>) (band => band as UltraGridChildBand)).SingleOrDefault<UltraGridChildBand>((Func<UltraGridChildBand, bool>) (band => ((KeyedSubObjectBase) band).Key.Equals(((IUniqueObject<string>) subTable).UniqueIdentifier))) ?? throw new InvalidOperationException("Could not find band with key " + ((IUniqueObject<string>) subTable).UniqueIdentifier);
      subTable.SubTablePopulate(childBand1);
    }
  }

  private void PopulateRows(RowsCollection rows)
  {
    foreach (UltraGridRow row in rows)
    {
      TDisplayItem listObject = (TDisplayItem) row.ListObject;
      if ((object) listObject != null && !this._objectRowMap.ContainsKey(listObject))
      {
        this._objectRowMap.Add(listObject, row);
        this.PopulateCellsInRow(row, listObject);
        if (listObject is IMvcModel mvcModel)
          mvcModel.AddObserver((IModelObserver) new GridRowModelObserver(new Action<IMvcModel>(this.UpdateValuesForDisplayItem)));
        ChildBandsCollection childBands = row.ChildBands;
        if (row.ChildBands != null)
          this.PopulateChildBands(childBands);
      }
    }
  }

  private void Grid_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    UltraGridRow row = e.Row;
    if (!((GridItemBase) row).Band.Equals((object) this._appliedToBand))
      return;
    TDisplayItem listObject = (TDisplayItem) row.ListObject;
    if ((object) listObject == null || this._objectRowMap.ContainsKey(listObject))
      return;
    this._objectRowMap.Add(listObject, row);
    if (listObject is IMvcModel mvcModel)
      mvcModel.AddObserver((IModelObserver) new GridRowModelObserver(new Action<IMvcModel>(this.UpdateValuesForDisplayItem)));
    this.UpdateValuesForDisplayItem(listObject);
  }

  private void PopulateCellsInRow(UltraGridRow row, TDisplayItem obj)
  {
    EnumerableExtensions.ForEach<IUltraGridColumnSettings<TDisplayItem>>((IEnumerable<IUltraGridColumnSettings<TDisplayItem>>) this._columnSettings, (Action<IUltraGridColumnSettings<TDisplayItem>>) (setting => setting.SetInitialCellValue(row, obj)));
  }

  private void HideAllColumns()
  {
    EnumerableExtensions.ForEach<object>((IEnumerable<object>) ((SubObjectsCollectionBase) this._appliedToBand.Columns).All, (Action<object>) (column => (column as UltraGridColumn).Hidden = true));
  }

  private void ValidateSubTables()
  {
    if (!((IEnumerable<IUltraGridTableSettings>) this._subTables).Any<IUltraGridTableSettings>())
      throw new ArgumentException("Must supply at least one sub-table");
    if (((IEnumerable<IUltraGridTableSettings>) this._subTables).Any<IUltraGridTableSettings>((Func<IUltraGridTableSettings, bool>) (table => table == null)))
      throw new ArgumentException("Table settings must not contain a null value.");
    if (((IEnumerable<IUltraGridTableSettings>) this._subTables).GroupBy<IUltraGridTableSettings, string>((Func<IUltraGridTableSettings, string>) (table => ((IUniqueObject<string>) table).UniqueIdentifier)).Where<IGrouping<string, IUltraGridTableSettings>>((Func<IGrouping<string, IUltraGridTableSettings>, bool>) (group => group.Count<IUltraGridTableSettings>() > 1)).Any<IGrouping<string, IUltraGridTableSettings>>())
      throw new ArgumentException("Cannot have duplicate sub tables.");
  }

  private void ValidateColumnSettings()
  {
    if (!((IEnumerable<IUltraGridColumnSettings<TDisplayItem>>) this._columnSettings).Any<IUltraGridColumnSettings<TDisplayItem>>())
      throw new ArgumentException("Must supply at least one column setting.");
    if (((IEnumerable<IUltraGridColumnSettings<TDisplayItem>>) this._columnSettings).Any<IUltraGridColumnSettings<TDisplayItem>>((Func<IUltraGridColumnSettings<TDisplayItem>, bool>) (setting => setting == null)))
      throw new ArgumentException("Column settings must not contain a null value.");
    if (((IEnumerable<IUltraGridColumnSettings<TDisplayItem>>) this._columnSettings).GroupBy<IUltraGridColumnSettings<TDisplayItem>, string>((Func<IUltraGridColumnSettings<TDisplayItem>, string>) (column => ((IUniqueObject<string>) column).UniqueIdentifier)).Where<IGrouping<string, IUltraGridColumnSettings<TDisplayItem>>>((Func<IGrouping<string, IUltraGridColumnSettings<TDisplayItem>>, bool>) (group => group.Count<IUltraGridColumnSettings<TDisplayItem>>() > 1)).Any<IGrouping<string, IUltraGridColumnSettings<TDisplayItem>>>())
      throw new ArgumentException("Cannot have duplicate column settings.");
  }

  private bool IsAppliedToGrid() => this._appliedToBand != null;
}
