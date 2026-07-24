// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.Filter.UltraGridFilterAdapter`1
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win.UltraWinGrid;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Addons.Filter;

public class UltraGridFilterAdapter<TDisplayItem>
{
  private readonly FilterLogicalOperator _logicalOperator;
  private FilterConditionsCollection _appliedFilters;
  private CustomUltraGridFilterCondition<TDisplayItem> _currentFilter;
  private UltraGridColumn _filterColumn;

  public Func<TDisplayItem, bool> NoFilterFilter { get; }

  public UltraGridFilterAdapter(FilterLogicalOperator logicalOperator, bool showAllOnNoFilter)
  {
    this._logicalOperator = logicalOperator;
    this.NoFilterFilter = (Func<TDisplayItem, bool>) (_ => showAllOnNoFilter);
  }

  public virtual void SetFilter(Func<TDisplayItem, bool> filterFunction)
  {
    if (!this.IsAppliedToBand())
      throw new InvalidOperationException("Must be applied to a band before you can set the filter.");
    this._appliedFilters?.Remove((FilterCondition) this._currentFilter);
    this.ApplyFilter(filterFunction);
  }

  public virtual void ClearFilter()
  {
    if (!this.IsAppliedToBand())
      throw new InvalidOperationException("Must be applied to a band before you can set the filter.");
    this._appliedFilters?.Remove((FilterCondition) this._currentFilter);
    this.ApplyFilter(this.NoFilterFilter);
  }

  public virtual void ApplyToBand(UltraGridBand band)
  {
    if (this.IsAppliedToBand())
      throw new InvalidOperationException("Cannot already be applied to a band.");
    if (band == null)
      throw new ArgumentNullException(nameof (band));
    string str = "FilterColumn: B23C5D5F-7231-489E-BBA9-1FDD00831541";
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists(str))
    {
      this._filterColumn = band.Columns[str];
    }
    else
    {
      this._filterColumn = band.Columns.Add(str, "Filter Column (You shouldn't be able to see this)");
      band.ColumnFilters.LogicalOperator = this._logicalOperator;
      this._filterColumn.Hidden = true;
    }
    this._appliedFilters = band.ColumnFilters[str].FilterConditions;
    band.ColumnFilters[str].LogicalOperator = this._logicalOperator;
    this.ClearFilter();
  }

  private void ApplyFilter(Func<TDisplayItem, bool> filterFunction)
  {
    this._currentFilter = new CustomUltraGridFilterCondition<TDisplayItem>(filterFunction);
    this._appliedFilters.Add((FilterCondition) this._currentFilter);
  }

  private bool IsAppliedToBand() => this._filterColumn != null;
}
