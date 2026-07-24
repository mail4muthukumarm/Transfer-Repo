// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.TransactionDetailCollection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[Serializable]
public class TransactionDetailCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable,
  IEnumerable<TransactionDetail>
{
  public TransactionDetail this[int index] => (TransactionDetail) this.List[index];

  public int IndexOf(TransactionDetail value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, TransactionDetail value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(TransactionDetail value) => this.Contains(value);

  public void CopyTo(TransactionDetailCollection detailCollection, int index)
  {
  }

  protected override void OnInsertComplete(int index, object value)
  {
    base.OnInsertComplete(index, value);
    ListChangedEventHandler listChanged = this.ListChanged;
    if (listChanged == null)
      return;
    listChanged((object) this, new ListChangedEventArgs(ListChangedType.ItemAdded, index));
  }

  protected override void OnRemoveComplete(int index, object value)
  {
    base.OnRemoveComplete(index, value);
    ListChangedEventHandler listChanged = this.ListChanged;
    if (listChanged == null)
      return;
    listChanged((object) this, new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
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

  public void Add(TransactionDetail transactionDetail) => this.List.Add((object) transactionDetail);

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new TransactionDetailNotFound($"{StringResourceManager.GetString("TRANSACTION_DETAIL_NOTFOUND")} {index.ToString()}.");
    this.List.RemoveAt(index);
  }

  public Decimal TransactionsTotal()
  {
    if (this.Count == 0)
      return 0M;
    Decimal num = 0M;
    foreach (TransactionDetail transactionDetail in (CollectionBase) this)
      num += transactionDetail.Amount;
    return Math.Abs(num);
  }

  public ArrayList PostedInvoiceList()
  {
    ArrayList arrayList = new ArrayList();
    foreach (TransactionDetail transactionDetail in (CollectionBase) this)
    {
      if (transactionDetail.InvoiceNumber != 0 && !arrayList.Contains((object) transactionDetail.InvoiceNumber))
        arrayList.Add((object) transactionDetail.InvoiceNumber);
    }
    return arrayList;
  }

  IEnumerator<TransactionDetail> IEnumerable<TransactionDetail>.GetEnumerator()
  {
    return this.OfType<TransactionDetail>().GetEnumerator();
  }
}
