// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.AppliedGridValueCollection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Collections;
using System.ComponentModel;
using System.Globalization;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

[Serializable]
internal class AppliedGridValueCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable
{
  public bool ItemExists(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    int controlNumber)
  {
    bool flag = false;
    foreach (AppliedGridValue appliedGridValue in (CollectionBase) this)
    {
      if (appliedGridValue.InvoiceNumber == invoiceNumber && appliedGridValue.ChargeCode == chargeCode && appliedGridValue.ControlNumber == controlNumber && appliedGridValue.CompanyLineGuid.Equals(companyLineGuid))
      {
        flag = true;
        break;
      }
    }
    return flag;
  }

  public AppliedGridValue GetItem(
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    int controlNumber)
  {
    AppliedGridValue appliedGridValue1 = (AppliedGridValue) null;
    foreach (AppliedGridValue appliedGridValue2 in (CollectionBase) this)
    {
      if (appliedGridValue2.InvoiceNumber == invoiceNumber && appliedGridValue2.ChargeCode == chargeCode && appliedGridValue2.ControlNumber == controlNumber && appliedGridValue2.CompanyLineGuid.Equals(companyLineGuid))
      {
        appliedGridValue1 = appliedGridValue2;
        break;
      }
    }
    return appliedGridValue1;
  }

  public Decimal GetArAppliedSum(int controlNumber)
  {
    Decimal arAppliedSum = 0M;
    foreach (AppliedGridValue appliedGridValue in (CollectionBase) this)
    {
      if (appliedGridValue.ControlNumber == controlNumber)
        arAppliedSum += appliedGridValue.ArApplied;
    }
    return arAppliedSum;
  }

  public Decimal GetExchangeAppliedSum(int controlNumber)
  {
    Decimal exchangeAppliedSum = 0M;
    foreach (AppliedGridValue appliedGridValue in (CollectionBase) this)
    {
      if (appliedGridValue.ControlNumber == controlNumber)
        exchangeAppliedSum += appliedGridValue.ExApplied;
    }
    return exchangeAppliedSum;
  }

  public Decimal GetUnAccountedAppliedSum(int controlNumber)
  {
    Decimal accountedAppliedSum = 0M;
    foreach (AppliedGridValue appliedGridValue in (CollectionBase) this)
    {
      if (appliedGridValue.ControlNumber == controlNumber)
        accountedAppliedSum += appliedGridValue.UaApplied;
    }
    return accountedAppliedSum;
  }

  public AppliedGridValue this[int index] => (AppliedGridValue) this.List[index];

  public int IndexOf(AppliedGridValue value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, AppliedGridValue value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(AppliedGridValue value) => this.Contains(value);

  public void CopyTo(AppliedGridValueCollection detailCollection, int index)
  {
  }

  public void CopyTo(AppliedGridValueCollection detailCollection)
  {
    foreach (AppliedGridValue appliedGridValue in (CollectionBase) this)
      detailCollection.Add(new AppliedGridValue(appliedGridValue.InvoiceNumber, appliedGridValue.ChargeCode, appliedGridValue.CompanyLineGuid, appliedGridValue.ArApplied, appliedGridValue.ExApplied, appliedGridValue.UaApplied, appliedGridValue.ControlNumber));
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

  public void Add(AppliedGridValue appliedGridValue) => this.List.Add((object) appliedGridValue);

  public void Add(UltraGridRow rowObject)
  {
    int invoiceNumber = int.Parse(rowObject.Cells["invoicenum"].Value.ToString(), NumberStyles.Currency);
    int chargeCode = int.Parse(rowObject.Cells["chargecode"].Value.ToString(), NumberStyles.Currency);
    Guid companyLineGuid = new Guid(rowObject.Cells["companylineguid"].Value.ToString());
    Decimal arApplied = 0M;
    Decimal exApplied = 0M;
    Decimal uaApplied = 0M;
    if (rowObject.Cells["arApplied"].Value != null && !rowObject.Cells["arApplied"].Value.Equals((object) DBNull.Value))
      arApplied = Decimal.Parse(rowObject.Cells["arApplied"].Value.ToString(), NumberStyles.Currency);
    if (rowObject.Cells["exchApplied"].Value != null && !rowObject.Cells["exchApplied"].Value.Equals((object) DBNull.Value))
      exApplied = Decimal.Parse(rowObject.Cells["exchApplied"].Value.ToString(), NumberStyles.Currency);
    if (rowObject.Cells["unacctapplied"].Value != null && !rowObject.Cells["unacctapplied"].Value.Equals((object) DBNull.Value))
      uaApplied = Decimal.Parse(rowObject.Cells["unacctapplied"].Value.ToString(), NumberStyles.Currency);
    int controlNumber = int.Parse(rowObject.Cells["quotecontrolnum"].Value.ToString());
    this.List.Add((object) new AppliedGridValue(invoiceNumber, chargeCode, companyLineGuid, arApplied, exApplied, uaApplied, controlNumber));
  }

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      throw new ObjectNotFoundException($"The system could not find an applied grid value object at index  {index.ToString()}.");
    this.List.RemoveAt(index);
  }
}
