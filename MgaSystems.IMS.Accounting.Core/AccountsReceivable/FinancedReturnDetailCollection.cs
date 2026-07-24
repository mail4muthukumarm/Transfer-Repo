// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.FinancedReturnDetailCollection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

[Serializable]
public class FinancedReturnDetailCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable
{
  public FinancedReturnDetail this[int index] => (FinancedReturnDetail) this.List[index];

  public int IndexOf(FinancedReturnDetail value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, FinancedReturnDetail value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(FinancedReturnDetail value) => this.Contains(value);

  public void CopyTo(FinancedReturnDetailCollection detailCollection, int index)
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

  [field: NonSerialized]
  public event ListChangedEventHandler ListChanged;

  public bool SupportsChangeNotification => true;

  public void RemoveSort()
  {
  }

  public object AddNew() => (object) null;

  public bool AllowEdit => true;

  public void RemoveIndex(PropertyDescriptor property)
  {
  }

  public void Add(FinancedReturnDetail financedReturnDetail)
  {
    this.List.Add((object) financedReturnDetail);
  }

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new FinancedReturnDetailNotFoundException($"The system could not find a financed return detail object at index  {index.ToString()}.");
    this.List.RemoveAt(index);
  }

  public Decimal ReturnTotal()
  {
    if (this.Count == 0)
      return 0M;
    Decimal num = 0M;
    foreach (FinancedReturnDetail financedReturnDetail in (CollectionBase) this)
      num += financedReturnDetail.Amount;
    return num;
  }
}
