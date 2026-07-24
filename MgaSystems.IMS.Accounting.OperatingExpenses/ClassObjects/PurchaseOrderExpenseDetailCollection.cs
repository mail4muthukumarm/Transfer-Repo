// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.PurchaseOrderExpenseDetailCollection
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;
using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

public class PurchaseOrderExpenseDetailCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable
{
  public PurchaseOrderExpenseDetail this[int index]
  {
    get => (PurchaseOrderExpenseDetail) this.List[index];
  }

  public int IndexOf(PurchaseOrderExpenseDetail value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, PurchaseOrderExpenseDetail value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(PurchaseOrderExpenseDetail value) => this.Contains(value);

  public void CopyTo(
    PurchaseOrderExpenseDetailCollection detailCollection,
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

  public void Add(
    PurchaseOrderExpenseDetail purchaseOrderExpenseDetail)
  {
    foreach (Expense expense in (IEnumerable) this.List)
    {
      if (expense.ExpenseCode == purchaseOrderExpenseDetail.ExpenseCode)
        throw new ExpenseDetailItemAlreadyExists(StringResourceManager.GetString("EXPENSE_DETAILITEM_EXISTS_EXCEPTION"));
    }
    this.List.Add((object) purchaseOrderExpenseDetail);
  }

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new PurchaseOrderExpenseDetailNotFoundException($"{StringResourceManager.GetString("PURCHASEORDER_EXPENSE_DETAIL_NOTFOUND_EXCEPTION")} {index.ToString()}.");
    this.List.RemoveAt(index);
  }
}
