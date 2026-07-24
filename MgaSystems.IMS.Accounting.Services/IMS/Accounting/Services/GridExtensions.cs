// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.GridExtensions
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Accounting.Services;

public static class GridExtensions
{
  public static T Field<T>(this UltraGridRow row, string columnKey)
  {
    bool flag = Nullable.GetUnderlyingType(typeof (T)) != (Type) null;
    object obj;
    try
    {
      obj = row.Cells[columnKey].Value;
    }
    catch (Exception ex)
    {
      if (flag || typeof (T) == typeof (string))
        return default (T);
      throw;
    }
    switch (obj)
    {
      case null:
      case DBNull _:
        if (Nullable.GetUnderlyingType(typeof (T)) != (Type) null)
          return default (T);
        throw new InvalidOperationException("T must support nullable if the value contained in the collumn is null.");
      default:
        return (T) obj;
    }
  }

  public static Guid FieldGuid(this UltraGridRow row, string columnKey)
  {
    return new Guid(row.Field<string>(columnKey));
  }

  public static UltraGridRow SetContextActiveRow(this UltraGrid grid)
  {
    UltraGridLayout displayLayout = ((UltraGridBase) grid).DisplayLayout;
    if (displayLayout.UIElement == null || ((ControlUIElementBase) displayLayout.UIElement).LastElementEntered == null)
      return (UltraGridRow) null;
    if (!(((ControlUIElementBase) displayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow)) is UltraGridRow context))
      return (UltraGridRow) null;
    ((GridItemBase) context).Selected = true;
    ((UltraGridBase) grid).ActiveRow = context;
    return context;
  }

  public static void CreateGridCurrencySummaries(
    this UltraGrid grid,
    params GridSummaryDefinition[] summaryDefinitions)
  {
    foreach (GridSummaryDefinition summaryDefinition in summaryDefinitions)
    {
      UltraGridColumn gridColumn = GridExtensions.GetGridColumn(grid, summaryDefinition.ColumnKey);
      UltraGridBand band = gridColumn.Band;
      GridExtensions.CreateSummary(gridColumn, summaryDefinition.SummaryKey, band);
    }
  }

  public static void SetSummaryCaption(this UltraGrid grid, UltraGridBand bnd, string summaryText)
  {
    if (string.IsNullOrEmpty(summaryText))
    {
      bnd.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    }
    else
    {
      bnd.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 1;
      bnd.SummaryFooterCaption = summaryText;
    }
  }

  public static void ApplySummaryMGAStyle(this UltraGrid grid, UltraGridBand bnd)
  {
    Color color = Color.FromArgb(207, 221, 240 /*0xF0*/);
    bnd.Override.SummaryFooterAppearance.BackColor = color;
    foreach (SummarySettings summary in (IEnumerable) bnd.Summaries)
      summary.Appearance.BackColor = color;
  }

  private static UltraGridColumn GetGridColumn(UltraGrid grid, string columnKey)
  {
    foreach (UltraGridBand band in ((UltraGridBase) grid).DisplayLayout.Bands)
    {
      if (((KeyedSubObjectsCollectionBase) band.Columns).Exists(columnKey))
        return band.Columns[columnKey];
    }
    throw new ArgumentException(columnKey + " not found.");
  }

  public static void CreateSummary(UltraGridColumn col, string summaryName, UltraGridBand bnd)
  {
    if (((KeyedSubObjectsCollectionBase) bnd.Summaries).Exists(summaryName))
    {
      SummarySettings summary = bnd.Summaries[summaryName];
      bnd.Summaries.Remove(summary);
    }
    SummarySettings summarySettings = bnd.Summaries.Add(summaryName, (SummaryType) 1, col);
    summarySettings.SummaryPosition = (SummaryPosition) 3;
    summarySettings.SummaryPositionColumn = col;
    summarySettings.DisplayFormat = "{0:c}";
    summarySettings.Appearance.TextHAlign = (HAlign) 3;
    summarySettings.Appearance.FontData.Bold = (DefaultableBoolean) 1;
  }

  public static void FormatCurrencyColumns(this UltraGrid grid, params string[] columnKeys)
  {
    foreach (string columnKey in columnKeys)
      GridExtensions.FormatCurrencyColumn(GridExtensions.GetGridColumn(grid, columnKey));
  }

  public static void FormatCurrencyColumn(UltraGridColumn column)
  {
    ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 3;
    column.CellAppearance.TextHAlign = (HAlign) 3;
    column.Format = "c";
  }

  public static void FilterColumn(this UltraGrid grid, string columnKey, object filterValue)
  {
    GridExtensions.GetGridColumn(grid, columnKey).AddFilterOn(filterValue, (FilterComparisionOperator) 0);
  }

  public static FilterCondition AddFilterOn(
    this UltraGridColumn column,
    object filterValue,
    FilterComparisionOperator op)
  {
    return column.Band.ColumnFilters[((KeyedSubObjectBase) column).Key].FilterConditions.Add(op, filterValue);
  }

  public static void RemoveFilter(this UltraGridColumn column, FilterCondition filter)
  {
    column.Band.ColumnFilters[((KeyedSubObjectBase) column).Key].FilterConditions.Remove(filter);
  }

  public static void ClearColumnFilter(this UltraGrid grid, string columnKey)
  {
    GridExtensions.GetGridColumn(grid, columnKey).Band.ColumnFilters[columnKey].FilterConditions.Clear();
  }
}
