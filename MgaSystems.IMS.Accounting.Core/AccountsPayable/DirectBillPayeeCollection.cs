// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.DirectBillPayeeCollection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using System;
using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class DirectBillPayeeCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable
{
  public DirectBillPayee this[int index] => (DirectBillPayee) this.List[index];

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

  public int IndexOf(DirectBillPayee value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, DirectBillPayee value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(DirectBillPayee value) => this.Contains(value);

  public void CopyTo(
    DirectBillPayeeCollection directBillPayeeCollection,
    int index)
  {
  }

  public void Add(DirectBillPayee directBillPayee) => this.List.Add((object) directBillPayee);

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      return;
    this.List.RemoveAt(index);
  }

  public bool Exists(Guid PayeeGuid)
  {
    if (this.Count == 0)
      return false;
    foreach (DirectBillPayee directBillPayee in (CollectionBase) this)
    {
      if (directBillPayee.PayeeGuid.Equals(PayeeGuid))
        return true;
    }
    return false;
  }
}
