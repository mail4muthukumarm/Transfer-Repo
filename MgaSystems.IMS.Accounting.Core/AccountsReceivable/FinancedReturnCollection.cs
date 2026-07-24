// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.FinancedReturnCollection
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
public class FinancedReturnCollection : CollectionBase, IBindingList, IList, ICollection, IEnumerable
{
  private FinancedReturnDetailCollection detailCollection;

  public FinancedReturnDetailCollection DetailCollection
  {
    get
    {
      if (this.detailCollection == null)
        this.CreateDetailCollection();
      return this.detailCollection;
    }
  }

  public FinancedReturn this[int index] => (FinancedReturn) this.List[index];

  public FinancedReturn this[Guid key]
  {
    get
    {
      foreach (FinancedReturn financedReturn in (CollectionBase) this)
      {
        if (financedReturn.FinanceCompanyGuid.Equals(key))
          return financedReturn;
      }
      return (FinancedReturn) null;
    }
  }

  public int IndexOf(FinancedReturn value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, FinancedReturn value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(FinancedReturn value) => this.Contains(value);

  public void CopyTo(FinancedReturnCollection financedReturnCollection, int index)
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

  public bool AllowEdit => false;

  public void RemoveIndex(PropertyDescriptor property)
  {
  }

  public void Add(FinancedReturn financedReturn) => this.List.Add((object) financedReturn);

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new FinancedReturnObjectNotFoundException($"The system could not find a financed return object at index  {index.ToString()}.");
    this.List.RemoveAt(index);
  }

  public bool KeyExists(Guid key)
  {
    foreach (FinancedReturn financedReturn in (CollectionBase) this)
    {
      if (financedReturn.FinanceCompanyGuid.Equals(key))
        return true;
    }
    return false;
  }

  private void CreateDetailCollection()
  {
    this.detailCollection = new FinancedReturnDetailCollection();
    foreach (FinancedReturn financedReturn in (CollectionBase) this)
    {
      foreach (FinancedReturnDetail detail in (CollectionBase) financedReturn.Details)
        this.detailCollection.Add(detail);
    }
  }

  public bool HasSelectedReturns()
  {
    foreach (FinancedReturn financedReturn in (CollectionBase) this)
    {
      if (financedReturn.HasSelectedDetails())
        return true;
    }
    return false;
  }

  public bool IsItemSelected(int invoiceNumber, int chargeCode, Guid companyLineGuid)
  {
    foreach (FinancedReturn financedReturn in (CollectionBase) this)
    {
      if (financedReturn.HasSelectedDetails())
      {
        foreach (FinancedReturnDetail detail in (CollectionBase) financedReturn.Details)
        {
          if (detail.Selected && detail.InvoiceNumber == invoiceNumber && detail.ChargeCode == chargeCode && detail.CompanyLineGuid.Equals(companyLineGuid))
            return true;
        }
      }
    }
    return false;
  }

  public void UpdateRelatedItems(int controlNumber, bool selected)
  {
    foreach (FinancedReturn financedReturn in (CollectionBase) this)
    {
      foreach (FinancedReturnDetail detail in (CollectionBase) financedReturn.Details)
      {
        if (detail.ControlNumber == controlNumber)
          detail.Selected = selected;
      }
    }
  }
}
