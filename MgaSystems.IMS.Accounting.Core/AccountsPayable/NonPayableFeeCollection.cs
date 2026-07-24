// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.NonPayableFeeCollection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class NonPayableFeeCollection : CollectionBase, IBindingList, IList, ICollection, IEnumerable
{
  private dsNonPayableFees _dataNonPayableFees;

  public NonPayableFeeCollection()
  {
  }

  public NonPayableFeeCollection(dsNonPayableFees dataNonPayableFees)
  {
    this._dataNonPayableFees = dataNonPayableFees;
    this.BuildCollection();
  }

  public NonPayableFee this[int index] => (NonPayableFee) this.List[index];

  public int IndexOf(NonPayableFee value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, NonPayableFee value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(NonPayableFee value) => this.Contains(value);

  public void CopyTo(NonPayableFeeCollection nonPayableFeeCollection, int index)
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

  public bool AllowEdit => true;

  public void RemoveIndex(PropertyDescriptor property)
  {
  }

  public void Add(NonPayableFee nonPayableFee) => this.List.Add((object) nonPayableFee);

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new NonPayableFeeObjectNotFoundException($"The system could not find a non payable fee object at index  {index.ToString()}.");
    this.List.RemoveAt(index);
  }

  private void BuildCollection()
  {
    if (this._dataNonPayableFees == null || this._dataNonPayableFees.NonPayableFees.Rows.Count == 0)
      return;
    foreach (dsNonPayableFees.NonPayableFeesRow nonPayableFee in (TypedTableBase<dsNonPayableFees.NonPayableFeesRow>) this._dataNonPayableFees.NonPayableFees)
      this.Add(new NonPayableFee(nonPayableFee.QuoteControlNum, nonPayableFee.InvoiceNum, nonPayableFee.OfficeInvoiceNum, nonPayableFee.PolicyNumber, nonPayableFee.Insured, nonPayableFee.ChargeCode, new Guid(nonPayableFee.CompanyLineGuid), nonPayableFee.Amount, nonPayableFee.CostCenterId));
  }

  private Decimal NonPayableFeeTotal()
  {
    Decimal num = 0M;
    foreach (NonPayableFee nonPayableFee in (CollectionBase) this)
      num += nonPayableFee.Amount;
    return num;
  }

  public Decimal SelectedNonPayableFeeTotal()
  {
    Decimal num = 0M;
    foreach (NonPayableFee nonPayableFee in (CollectionBase) this)
    {
      if (nonPayableFee.IsSelected)
        num += nonPayableFee.Amount;
    }
    return num;
  }

  public bool HasNonSelectedFees()
  {
    bool flag = false;
    foreach (NonPayableFee nonPayableFee in (CollectionBase) this)
    {
      if (!nonPayableFee.IsSelected)
      {
        flag = true;
        break;
      }
    }
    return flag;
  }
}
