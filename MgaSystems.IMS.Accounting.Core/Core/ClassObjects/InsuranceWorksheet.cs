// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.InsuranceWorksheet
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.Core.Forms;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[Serializable]
public class InsuranceWorksheet
{
  internal int glCompanyId;
  internal Guid entityGuid;
  internal string entityName;
  internal bool isCashDisbursement;
  internal string checkNumber;
  internal Decimal checkAmount;
  internal DateTime depositdate;
  internal DateTime receivedDate;
  internal Decimal totalAmount;
  internal DateTime checkDate;
  internal string paymentMethod;
  internal SearchCriteriaCollection searchOptions;
  internal InterCompanyTransferCollection interCompanyTransfers;
  internal string postingMemo;
  internal Decimal unAccountedBalance;
  internal Decimal appliedUnAccounted;
  internal bool isReturnPremimum;
  internal formTransactionSearch.SearchTypes searchType;
  internal MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValueCollection payableGridValues;
  internal Utility.PayablesSearchType payableSearchType;
  internal int searchInteger;
  internal string searchString;
  internal DateTime searchDate;
  internal int glAcctId;
  internal Guid receivedFromGuid;
  internal string receivedFromName;
  internal MGASystems.IMS.Accounting.AccountsReceivable.AppliedGridValueCollection receivableGridValues;
  internal Utility.ReceivablesSearchType receivableSearchType;

  public InsuranceWorksheet()
  {
    this.payableGridValues = new MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValueCollection();
    this.receivableGridValues = new MGASystems.IMS.Accounting.AccountsReceivable.AppliedGridValueCollection();
    this.interCompanyTransfers = new InterCompanyTransferCollection();
  }

  public Guid ReceivedFromGuid
  {
    get => this.receivedFromGuid;
    set => this.receivedFromGuid = value;
  }

  public string ReceivedFromName
  {
    get => this.receivedFromName;
    set => this.receivedFromName = value;
  }

  public Decimal TotalAmount
  {
    get => this.totalAmount;
    set => this.totalAmount = value;
  }

  public int GlCompanyId
  {
    get => this.glCompanyId;
    set => this.glCompanyId = value;
  }

  public Guid EntityGuid
  {
    get => this.entityGuid;
    set => this.entityGuid = value;
  }

  public string EntityName
  {
    get => this.entityName;
    set => this.entityName = value;
  }

  public bool IsCashDisbursement
  {
    get => this.isCashDisbursement;
    set => this.isCashDisbursement = value;
  }

  public bool IsReturnPremium
  {
    get => this.isReturnPremimum;
    set => this.isReturnPremimum = value;
  }

  public string CheckNumber
  {
    get => this.checkNumber;
    set => this.checkNumber = value;
  }

  public Decimal CheckAmount
  {
    get => this.checkAmount;
    set => this.checkAmount = value;
  }

  public DateTime DepositDate
  {
    get => this.depositdate;
    set => this.depositdate = value;
  }

  public DateTime ReceivedDate
  {
    get => this.receivedDate;
    set => this.receivedDate = value;
  }

  public DateTime CheckDate
  {
    get => this.checkDate;
    set => this.checkDate = value;
  }

  public string PayableCheckNumber
  {
    get => this.CheckNumber;
    set => this.CheckNumber = value;
  }

  public string ReceivableCheckNumber
  {
    get => this.CheckNumber;
    set => this.CheckNumber = value;
  }

  public InterCompanyTransferCollection InterCompanyTransfers
  {
    get
    {
      if (this.interCompanyTransfers == null)
        this.interCompanyTransfers = new InterCompanyTransferCollection();
      return this.interCompanyTransfers;
    }
    set => this.interCompanyTransfers = value;
  }

  public SearchCriteriaCollection SearchCriteria
  {
    get
    {
      if (this.searchOptions == null)
        this.searchOptions = new SearchCriteriaCollection();
      return this.searchOptions;
    }
    set => this.searchOptions = value;
  }

  public string PostingMemo
  {
    get => this.postingMemo;
    set => this.postingMemo = value;
  }

  public Decimal UnAccountedBalance
  {
    get => this.unAccountedBalance;
    set => this.unAccountedBalance = value;
  }

  public Decimal AppliedUnAccounted
  {
    get => this.appliedUnAccounted;
    set => this.appliedUnAccounted = value;
  }

  public string PaymentMethod
  {
    get => this.paymentMethod;
    set => this.paymentMethod = value;
  }
}
