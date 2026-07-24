// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.DirectBillReceivableCollection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

internal class DirectBillReceivableCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable
{
  internal DirectBillReceivableCollection()
  {
  }

  public DirectBillReceivable this[int index] => (DirectBillReceivable) this.List[index];

  public int IndexOf(DirectBillReceivable value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, DirectBillReceivable value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(DirectBillReceivable value) => this.Contains(value);

  public void CopyTo(
    DirectBillReceivableCollection directBillReceivableCollection,
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

  public void Add(DirectBillReceivable directBillReceivable)
  {
    this.List.Add((object) directBillReceivable);
  }

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      return;
    this.List.RemoveAt(index);
  }

  internal bool ControlNumberExists(int controlNumber)
  {
    bool flag = false;
    if (this.Count != 0)
    {
      foreach (DirectBillReceivable directBillReceivable in (CollectionBase) this)
      {
        if (directBillReceivable != null && directBillReceivable.ControlNumber == controlNumber)
        {
          flag = true;
          break;
        }
      }
    }
    return flag;
  }

  internal dsGetAccountsReceivable GenerateDataset()
  {
    dsGetAccountsReceivable dataset = new dsGetAccountsReceivable();
    foreach (DirectBillReceivable directBillReceivable in (CollectionBase) this)
    {
      dsGetAccountsReceivable.AccountsReceivableRow row = dataset.AccountsReceivable.NewAccountsReceivableRow();
      row.invoicenum = 0;
      row.officeinvoicenum = 0;
      row.quoteid = 0;
      row.quotecontrolnum = directBillReceivable.ControlNumber;
      row.policynumber = directBillReceivable.PolicyNumber;
      row.insuredpolicyname = directBillReceivable.InsuredName;
      row.effectivedate = directBillReceivable.EffectiveDate;
      row.expirationdate = directBillReceivable.ExpirationDate;
      row.invoicedate = DateTime.Now;
      row.chargename = string.Empty;
      row.chargecode = 0;
      row.companylineguid = Guid.Empty;
      row.amtbilled = directBillReceivable.GetAmtBilled();
      row.AmtPTD = directBillReceivable.GetAmtPTD();
      row.NetDue = directBillReceivable.GetNetDue();
      row.AmtPTC = directBillReceivable.GetAmtPTC();
      row.UnacctBalance = directBillReceivable.GetUnAccountedBalance();
      row.ExchBalance = directBillReceivable.GetExchangeBalance();
      row.ARGL = 0;
      row.EXGL = 0;
      row.UAGL = 0;
      row.AccountNumber = string.Empty;
      row.CurrentStatus = directBillReceivable.CurrentStatus;
      dataset.AccountsReceivable.AddAccountsReceivableRow(row);
    }
    return dataset;
  }

  internal dsOpenReceivables GenerateReceivableDataset()
  {
    dsOpenReceivables receivableDataset = new dsOpenReceivables();
    foreach (DirectBillReceivable directBillReceivable in (CollectionBase) this)
    {
      dsOpenReceivables.OpenReceivablesRow row = receivableDataset.OpenReceivables.NewOpenReceivablesRow();
      row.InvoiceNum = 0;
      row.OfficeInvoiceNum = 0;
      row.QuoteId = 0;
      row.QuoteControlNum = directBillReceivable.ControlNumber;
      row.PolicyNumber = directBillReceivable.PolicyNumber;
      row.InsuredPolicyName = directBillReceivable.InsuredName;
      row.EffectiveDate = directBillReceivable.EffectiveDate;
      row.ExpirationDate = directBillReceivable.ExpirationDate;
      row.InvoiceDate = DateTime.Now;
      row.ChargeName = string.Empty;
      row.ChargeCode = 0;
      row.CompanyLineGuid = Guid.Empty.ToString();
      row.AmtBilled = directBillReceivable.GetAmtBilled();
      row.AmtRTD = directBillReceivable.GetAmtRTD();
      row.NetDue = directBillReceivable.GetNetDue();
      row.AmtPTC = directBillReceivable.GetAmtPTC();
      row.UnacctBalance = directBillReceivable.GetUnAccountedBalance();
      row.ExchBalance = directBillReceivable.GetExchangeBalance();
      row.ARGL = 0;
      row.EXGL = 0;
      row.UAGL = 0;
      row.AccountNumber = string.Empty;
      row.CurrentStatus = directBillReceivable.CurrentStatus;
      receivableDataset.OpenReceivables.AddOpenReceivablesRow(row);
    }
    return receivableDataset;
  }

  private DirectBillReceivable GetByControlNumber(int controlNumber)
  {
    DirectBillReceivable directBillReceivable1 = (DirectBillReceivable) null;
    foreach (DirectBillReceivable directBillReceivable2 in (CollectionBase) this)
    {
      if (directBillReceivable2.ControlNumber == controlNumber)
      {
        directBillReceivable1 = directBillReceivable2;
        break;
      }
    }
    return directBillReceivable1 != null ? directBillReceivable1 : throw new DirectBillReceivableObjectNotFoundException("The specified direct bill receivable control number could not be found!");
  }

  internal void UpdatePolicyArApplied(int controlNumber, bool isPayAll)
  {
    this.GetByControlNumber(controlNumber).UpdateAllChildArAmounts(isPayAll);
  }

  internal void UpdatePolicyArApplied(int controlNumber, Decimal newAmount, Decimal oldAmount)
  {
    this.GetByControlNumber(controlNumber).UpdateChildArAmounts(newAmount);
  }

  internal void UpdatePolicyExApplied(int controlNumber, Decimal newAmount, Decimal oldAmount)
  {
    this.GetByControlNumber(controlNumber).UpdateChildExchangeAmounts(newAmount);
  }

  internal void UpdatePolicyUaApplied(int controlNumber, Decimal newAmount, Decimal oldAmount)
  {
    this.GetByControlNumber(controlNumber).UpdateChildUnAccountedAmounts(newAmount);
  }
}
