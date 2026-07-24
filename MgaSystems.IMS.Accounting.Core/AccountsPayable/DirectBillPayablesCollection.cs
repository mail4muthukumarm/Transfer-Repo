// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.DirectBillPayablesCollection
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Collections;
using System.ComponentModel;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class DirectBillPayablesCollection : 
  CollectionBase,
  IBindingList,
  IList,
  ICollection,
  IEnumerable
{
  public DirectBillPayable this[int index] => (DirectBillPayable) this.List[index];

  public int IndexOf(DirectBillPayable value) => this.InnerList.IndexOf((object) value);

  public void Insert(int index, DirectBillPayable value)
  {
    this.InnerList.Insert(index, (object) value);
  }

  public bool Contains(DirectBillPayable value) => this.Contains(value);

  public void CopyTo(
    DirectBillPayablesCollection directBillPayablesCollection,
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

  public void Add(DirectBillPayable directBillPayable) => this.List.Add((object) directBillPayable);

  public void Remove(int index)
  {
    if (index > this.Count - 1 || index < 0)
      return;
    this.List.RemoveAt(index);
  }

  public bool ControlNumberExists(int controlNumber)
  {
    bool flag = false;
    foreach (DirectBillPayable directBillPayable in (CollectionBase) this)
    {
      if (directBillPayable != null && directBillPayable.ControlNumber == controlNumber)
      {
        flag = true;
        break;
      }
    }
    return flag;
  }

  public dsGetAccountsPayable GenerateDataset()
  {
    dsGetAccountsPayable dataset = new dsGetAccountsPayable();
    foreach (DirectBillPayable directBillPayable in (CollectionBase) this)
    {
      dsGetAccountsPayable.AcctsPayableRow row = dataset.AcctsPayable.NewAcctsPayableRow();
      row.invoicenum = 0;
      row.glcompanyid = 0;
      row.payeeguid = Guid.Empty.ToString();
      row.companylineguid = Guid.Empty.ToString();
      row.chargecode = 0;
      row.policynumber = directBillPayable.PolicyNumber;
      row.insuredpolicyname = directBillPayable.InsuredName;
      row.effectivedate = directBillPayable.EffectiveDate;
      row.expirationdate = directBillPayable.ExpirationDate;
      row.officeinvoicenum = 0;
      row.payee = string.Empty;
      row.chargename = string.Empty;
      row.gross_payable = directBillPayable.GetGrossPayableBalanceSum();
      row.amtptd = directBillPayable.GetAmountPaidToDateSum();
      row.net_payable = directBillPayable.GetNetPayableSum();
      row.amt_rcvd = directBillPayable.GetAmountReceivedSum();
      row.exch_balance = directBillPayable.GetExchangeBalanceSum();
      row.unacct_balance = directBillPayable.GetUnAccountedBalanceSum();
      row.quotecontrolnum = directBillPayable.ControlNumber;
      row.apgl = 0;
      row.exgl = 0;
      row.uagl = 0;
      row.propamt = directBillPayable.GetProportionalAmountDueSum();
      row.CurrencyCode = directBillPayable.CurrencyCode;
      dataset.AcctsPayable.AddAcctsPayableRow(row);
    }
    return dataset;
  }

  public dsOpenPayables GeneratePayableDataSet()
  {
    dsOpenPayables payableDataSet = new dsOpenPayables();
    foreach (DirectBillPayable directBillPayable in (CollectionBase) this)
    {
      dsOpenPayables.OpenPayablesRow row = payableDataSet.OpenPayables.NewOpenPayablesRow();
      row.InvoiceNum = 0;
      row.GLCompanyId = 0;
      row.PayeeGuid = Guid.Empty.ToString();
      row.CompanyLineGuid = Guid.Empty.ToString();
      row.ChargeCode = 0;
      row.PolicyNumber = directBillPayable.PolicyNumber;
      row.InsuredPolicyName = directBillPayable.InsuredName;
      row.EffectiveDate = directBillPayable.EffectiveDate;
      row.ExpirationDate = directBillPayable.ExpirationDate;
      row.OfficeInvoiceNum = 0;
      row.Payee = string.Empty;
      row.ChargeName = string.Empty;
      row.Gross_Payable = directBillPayable.GetGrossPayableBalanceSum();
      row.AmtPtd = directBillPayable.GetAmountPaidToDateSum();
      row.Net_Payable = directBillPayable.GetNetPayableSum();
      row.Amt_Rcvd = directBillPayable.GetAmountReceivedSum();
      row.Exch_Balance = directBillPayable.GetExchangeBalanceSum();
      row.UnAcct_Balance = directBillPayable.GetUnAccountedBalanceSum();
      row.QuoteControlNum = directBillPayable.ControlNumber;
      row.APGL = 0;
      row.EXGL = 0;
      row.UAGL = 0;
      row.PropAmt = directBillPayable.GetProportionalAmountDueSum();
      row.CurrencyCode = directBillPayable.CurrencyCode;
      payableDataSet.OpenPayables.AddOpenPayablesRow(row);
    }
    return payableDataSet;
  }

  private DirectBillPayable GetByControlNumber(int controlNumber)
  {
    DirectBillPayable directBillPayable1 = (DirectBillPayable) null;
    foreach (DirectBillPayable directBillPayable2 in (CollectionBase) this)
    {
      if (directBillPayable2.ControlNumber == controlNumber)
      {
        directBillPayable1 = directBillPayable2;
        break;
      }
    }
    return directBillPayable1 != null ? directBillPayable1 : throw new ObjectNotFoundException("The specified direct bill payable control number could not be found!");
  }

  public void UpdatePolicyApApplied(int controlNumber, bool isPayingAll)
  {
    this.GetByControlNumber(controlNumber).UpdateAllChildApAmounts(isPayingAll);
  }

  public void UpdatePolicyApApplied(int controlNumber, Decimal newAmount, Decimal oldAmount)
  {
    this.GetByControlNumber(controlNumber).UpdateChildApAmounts(newAmount);
  }
}
