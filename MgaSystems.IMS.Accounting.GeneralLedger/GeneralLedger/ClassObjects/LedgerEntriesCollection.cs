// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.LedgerEntriesCollection
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.IMS.Accounting.GeneralLedger.Exceptions;
using System;
using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;

public class LedgerEntriesCollection : CollectionBase, IBindingList, IList, ICollection, IEnumerable
{
  public LedgerEntry this[int index] => (LedgerEntry) this.List[index];

  public void Add(LedgerEntry ledgerEntry) => this.List.Add((object) ledgerEntry);

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new LedgerEntryNotFoundException($"{StringResourceManager.GetString("IndexExceptionString")} {index.ToString()}.");
    this.List.RemoveAt(index);
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

  public Decimal Total()
  {
    Decimal num = 0M;
    foreach (LedgerEntry ledgerEntry in (CollectionBase) this)
      num += ledgerEntry.Amount;
    return num;
  }

  public int IndexOf(LedgerEntry value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, LedgerEntry value) => this.InnerList.Insert(index, (object) value);

  public bool Contains(LedgerEntry value) => this.Contains(value);

  public void CopyTo(LedgerEntriesCollection ledgerCollection, int index)
  {
  }
}
