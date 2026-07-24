// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Shared.CostCenterAllocationCollection
// Assembly: MgaSystems.IMS.Accounting.Shared, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2F2619CC-F01B-4DB6-A722-33DC5B19310E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Shared.dll

using MGASystems.IMS.Accounting.Exceptions;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Accounting.Shared;

[Serializable]
public class CostCenterAllocationCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable
{
  public static CostCenterAllocationCollection CreateWithAllocation(
    int costCenterId,
    Decimal transactionTotal)
  {
    return new CostCenterAllocationCollection()
    {
      {
        new CostCenterAllocation(costCenterId, transactionTotal),
        transactionTotal
      }
    };
  }

  public event CostCenterAllocationCollection.AllocationsChangedHandler CostCenterAllocationsChanged;

  protected void OnCostCenterAllocationsChanged()
  {
    if (this.CostCenterAllocationsChanged == null)
      return;
    this.CostCenterAllocationsChanged((object) this, new EventArgs());
  }

  public CostCenterAllocation this[int index] => (CostCenterAllocation) this.List[index];

  public int IndexOf(CostCenterAllocation value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, CostCenterAllocation value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(CostCenterAllocation value) => this.Contains(value);

  public void CopyTo(
    CostCenterAllocationCollection allocationCollection,
    int index)
  {
  }

  protected override void OnInsertComplete(int index, object value)
  {
    base.OnInsertComplete(index, value);
    if (this.ListChanged == null)
      return;
    this.ListChanged((object) this, new ListChangedEventArgs(ListChangedType.ItemAdded, index));
  }

  protected override void OnRemoveComplete(int index, object value)
  {
    base.OnRemoveComplete(index, value);
    if (this.ListChanged == null)
      return;
    this.ListChanged((object) this, new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
  }

  public void AddIndex(PropertyDescriptor property)
  {
  }

  public bool AllowNew => false;

  public void ApplySort(PropertyDescriptor property, ListSortDirection direction)
  {
  }

  public PropertyDescriptor SortProperty => (PropertyDescriptor) null;

  public int Find(PropertyDescriptor property, object key) => 0;

  public bool SupportsSorting => false;

  public bool IsSorted => false;

  public bool AllowRemove => true;

  public bool SupportsSearching => false;

  public ListSortDirection SortDirection => ListSortDirection.Ascending;

  public event ListChangedEventHandler ListChanged;

  public bool SupportsChangeNotification => true;

  public void RemoveSort()
  {
  }

  public object AddNew() => (object) null;

  public bool AllowEdit => false;

  public void RemoveIndex(PropertyDescriptor property)
  {
  }

  public void Add(CostCenterAllocation costCenterAllocation, Decimal transactionTotal)
  {
    if (costCenterAllocation.AllocatedAmount + this.AllocationsTotal() > transactionTotal)
      throw new AllocationExceedsExpenseException(StringResourceManager.GetString("ALLOCATIONEXCEEDSEXPENSEEXCEPTION"));
    this.List.Add((object) costCenterAllocation);
    this.OnCostCenterAllocationsChanged();
  }

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new ArgumentOutOfRangeException($"{StringResourceManager.GetString("COSTCENTER_ALLOCATION_NOTFOUND_EXCEPTION")} {index.ToString()}.");
    this.List.RemoveAt(index);
    this.OnCostCenterAllocationsChanged();
  }

  public Decimal AllocationsTotal()
  {
    Decimal num = 0M;
    foreach (CostCenterAllocation centerAllocation in (IEnumerable) this.List)
      num += centerAllocation.AllocatedAmount;
    return num;
  }

  public Decimal UnAllocatedTotal(Decimal transactionTotal)
  {
    return transactionTotal - this.AllocationsTotal();
  }

  public DataTable ToChartDataTable(Decimal transactionTotal)
  {
    DataTable chartDataTable = new DataTable();
    chartDataTable.Columns.Add(new DataColumn("Amount", Type.GetType("System.Decimal")));
    chartDataTable.Columns.Add(new DataColumn("CostCenter", Type.GetType("System.String")));
    if (this.Count == 0)
    {
      chartDataTable.Rows.Add((object) transactionTotal, (object) "Un-Allocated");
    }
    else
    {
      foreach (CostCenterAllocation centerAllocation in (CollectionBase) this)
        chartDataTable.Rows.Add((object) centerAllocation.AllocatedAmount, (object) centerAllocation.CostCenterName);
      if (this.AllocationsTotal() < transactionTotal)
        chartDataTable.Rows.Add((object) (transactionTotal - this.AllocationsTotal()), (object) "Un-Allocated");
    }
    return chartDataTable;
  }

  public delegate void AllocationsChangedHandler(object sender, EventArgs e);
}
