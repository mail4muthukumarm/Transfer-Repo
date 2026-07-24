// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.LedgerEntry
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.IMS.Accounting.Shared;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;

public class LedgerEntry
{
  private int transactionNumber;
  private int postingNumber;
  private int ledgerAccount;
  private Decimal amount;
  private int invoiceNumber;
  private int chargeCode;
  private Guid companyLineGuid = Guid.Empty;
  private string sourceDocType = string.Empty;
  private int purchaseOrderNumber;
  private int expenseCode;
  private string comments = string.Empty;
  private int appliedFrom;
  private int exchangeFrom;
  private string accountFullName = string.Empty;
  private string accountType = string.Empty;
  private CostCenterAllocationCollection _costCenterAllocation;

  public LedgerEntry()
  {
  }

  public LedgerEntry(int ledgerAccount, Decimal amount)
  {
    this.ledgerAccount = ledgerAccount;
    this.amount = amount;
  }

  public LedgerEntry(int ledgerAccount, Decimal amount, CostCenterAllocationCollection costCenters)
  {
    this.ledgerAccount = ledgerAccount;
    this.amount = amount;
    this._costCenterAllocation = costCenters;
  }

  public LedgerEntry(
    int ledgerAccount,
    Decimal amount,
    string comments,
    CostCenterAllocationCollection costCenters)
  {
    this._costCenterAllocation = costCenters;
    this.ledgerAccount = ledgerAccount;
    this.amount = amount;
    this.comments = comments;
  }

  public LedgerEntry(
    int ledgerAccount,
    Decimal amount,
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid)
  {
    this.ledgerAccount = ledgerAccount;
    this.amount = amount;
    this.invoiceNumber = invoiceNumber;
    this.chargeCode = chargeCode;
    this.companyLineGuid = companyLineGuid;
  }

  public LedgerEntry(int ledgerAccount, Decimal amount, int purchaseOrderNumber, int expenseCode)
  {
    this.ledgerAccount = ledgerAccount;
    this.amount = amount;
    this.purchaseOrderNumber = purchaseOrderNumber;
    this.expenseCode = expenseCode;
  }

  public CostCenterAllocationCollection CostCenterAllocation
  {
    get => this._costCenterAllocation;
    set => this._costCenterAllocation = value;
  }

  public int TransactionNumber
  {
    get => this.transactionNumber;
    set => this.transactionNumber = value;
  }

  public int PostingNumber
  {
    get => this.postingNumber;
    set => this.postingNumber = value;
  }

  public int LedgerAccount
  {
    get => this.ledgerAccount;
    set => this.ledgerAccount = value;
  }

  public Decimal Amount
  {
    get => this.amount;
    set => this.amount = value;
  }

  public int InvoiceNumber
  {
    get => this.invoiceNumber;
    set => this.invoiceNumber = value;
  }

  public int ChargeCode
  {
    get => this.chargeCode;
    set => this.chargeCode = value;
  }

  public Guid CompanyLineGuid
  {
    get => this.companyLineGuid;
    set => this.companyLineGuid = value;
  }

  public string SourceDocType
  {
    get => this.sourceDocType;
    set => this.sourceDocType = value;
  }

  public int PurchaseOrderNumber
  {
    get => this.purchaseOrderNumber;
    set => this.purchaseOrderNumber = value;
  }

  public int ExpenseCode
  {
    get => this.expenseCode;
    set => this.expenseCode = value;
  }

  public string Comments
  {
    get => this.comments;
    set => this.comments = value;
  }

  public int AppliedFrom
  {
    get => this.appliedFrom;
    set => this.appliedFrom = value;
  }

  public int ExchangeFrom
  {
    get => this.exchangeFrom;
    set => this.exchangeFrom = value;
  }

  public string AccountFullName
  {
    get
    {
      try
      {
        if (this.accountFullName.Length != 0)
          return this.accountFullName;
        this.accountFullName = SharedMembers.GetGLAccountFullName(this.LedgerAccount);
        return this.accountFullName;
      }
      catch (NullReferenceException ex)
      {
        this.accountFullName = SharedMembers.GetGLAccountFullName(this.LedgerAccount);
        return this.accountFullName;
      }
    }
    set => this.accountFullName = value;
  }

  public string AccountType
  {
    get
    {
      if (!this.accountType.Equals(string.Empty) && this.accountType.Length != 0)
        return this.accountType;
      this.accountType = SharedMembers.GetGLAccountTypeName(this.LedgerAccount);
      return this.accountType;
    }
    set => this.accountType = value;
  }
}
