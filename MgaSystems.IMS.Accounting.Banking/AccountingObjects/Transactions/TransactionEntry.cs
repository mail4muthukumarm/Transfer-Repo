// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.AccountingObjects.Transactions.TransactionEntry
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.IMS.Accounting.Shared;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.AccountingObjects.Transactions;

internal sealed class TransactionEntry
{
  private Decimal mAmount;
  private int mGLAccount;
  private int mChargeCode;
  private Guid mCompanyLineGuid;
  private int mInvoiceNumber;
  private int mPoNum;
  private int mExpenseCode;
  private TransactionEntryTypes mTransactionType;
  private Guid mPayeeGuid;
  private int mExchangeFrom;
  private CostCenterAllocationCollection mcostCenterAllocations;

  internal Decimal Amount => this.mAmount;

  internal int GLAccount => this.mGLAccount;

  internal int ChargeCode => this.mChargeCode;

  internal Guid CompanyLineGuid => this.mCompanyLineGuid;

  internal int InvoiceNumber => this.mInvoiceNumber;

  internal int PurchaseOrderNumber => this.mPoNum;

  internal int ExpenseCode => this.mExpenseCode;

  internal TransactionEntryTypes TransactionType => this.mTransactionType;

  internal Guid PayeeGuid => this.mPayeeGuid;

  internal int ExchangeFrom
  {
    get => this.mExchangeFrom;
    set => this.mExchangeFrom = value;
  }

  internal CostCenterAllocationCollection CostCenterAllocations => this.mcostCenterAllocations;

  private TransactionEntry()
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
  }

  [Obsolete("This constructor is obsolete. Please use a constructor that provides the object with a cost center allocation collection", false)]
  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    int TransactionChargeCode,
    Guid TransactionCompanyLineGuid,
    int TransactionInvoiceNumber)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mChargeCode = TransactionChargeCode;
    this.mCompanyLineGuid = TransactionCompanyLineGuid;
    this.mInvoiceNumber = TransactionInvoiceNumber;
    this.mTransactionType = TransactionEntryTypes.InvoiceTransaction;
  }

  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    int TransactionChargeCode,
    Guid TransactionCompanyLineGuid,
    int TransactionInvoiceNumber,
    CostCenterAllocationCollection costCenterAllocations)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mChargeCode = TransactionChargeCode;
    this.mCompanyLineGuid = TransactionCompanyLineGuid;
    this.mInvoiceNumber = TransactionInvoiceNumber;
    this.mTransactionType = TransactionEntryTypes.InvoiceTransaction;
    this.mcostCenterAllocations = costCenterAllocations;
  }

  [Obsolete("This constructor is obsolete. Please use a constructor that provides the object with a cost center allocation collection", false)]
  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    int TransactionChargeCode,
    Guid TransactionCompanyLineGuid,
    int TransactionInvoiceNumber,
    Guid TransactionPayeeGuid)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mChargeCode = TransactionChargeCode;
    this.mCompanyLineGuid = TransactionCompanyLineGuid;
    this.mInvoiceNumber = TransactionInvoiceNumber;
    this.mPayeeGuid = TransactionPayeeGuid;
    this.mTransactionType = TransactionEntryTypes.InvoiceTransaction;
  }

  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    int TransactionChargeCode,
    Guid TransactionCompanyLineGuid,
    int TransactionInvoiceNumber,
    Guid TransactionPayeeGuid,
    CostCenterAllocationCollection costCenterAllocations)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mChargeCode = TransactionChargeCode;
    this.mCompanyLineGuid = TransactionCompanyLineGuid;
    this.mInvoiceNumber = TransactionInvoiceNumber;
    this.mPayeeGuid = TransactionPayeeGuid;
    this.mTransactionType = TransactionEntryTypes.InvoiceTransaction;
    this.mcostCenterAllocations = costCenterAllocations;
  }

  [Obsolete("This constructor is obsolete. Please use a constructor that provides the object with a cost center allocation collection", false)]
  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    int TransactionPurchaseOrderNumber,
    int TransactionExpenseCode)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mPoNum = TransactionPurchaseOrderNumber;
    this.mExpenseCode = TransactionExpenseCode;
    this.mTransactionType = TransactionEntryTypes.OperatingTransaction;
  }

  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    int TransactionPurchaseOrderNumber,
    int TransactionExpenseCode,
    CostCenterAllocationCollection costCenterAllocations)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mPoNum = TransactionPurchaseOrderNumber;
    this.mExpenseCode = TransactionExpenseCode;
    this.mTransactionType = TransactionEntryTypes.OperatingTransaction;
    this.mcostCenterAllocations = costCenterAllocations;
  }

  [Obsolete("This constructor is obsolete. Please use a constructor that provides the object with a cost center allocation collection", false)]
  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    int TransactionPurchaseOrderNumber,
    int TransactionExpenseCode,
    Guid TransactionPayeeGuid)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mPoNum = TransactionPurchaseOrderNumber;
    this.mExpenseCode = TransactionExpenseCode;
    this.mPayeeGuid = TransactionPayeeGuid;
    this.mTransactionType = TransactionEntryTypes.OperatingTransaction;
  }

  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    int TransactionPurchaseOrderNumber,
    int TransactionExpenseCode,
    Guid TransactionPayeeGuid,
    CostCenterAllocationCollection costCenterAllocations)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mPoNum = TransactionPurchaseOrderNumber;
    this.mExpenseCode = TransactionExpenseCode;
    this.mPayeeGuid = TransactionPayeeGuid;
    this.mTransactionType = TransactionEntryTypes.OperatingTransaction;
    this.mcostCenterAllocations = costCenterAllocations;
  }

  [Obsolete("This constructor is obsolete. Please use a constructor that provides the object with a cost center allocation collection", false)]
  internal TransactionEntry(Decimal TransactionAmount, int TransactionGLAccount)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mTransactionType = TransactionEntryTypes.OperatingTransaction;
  }

  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    CostCenterAllocationCollection costCenterAllocations)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mTransactionType = TransactionEntryTypes.OperatingTransaction;
    this.mcostCenterAllocations = costCenterAllocations;
  }

  [Obsolete("This constructor is obsolete. Please use a constructor that provides the object with a cost center allocation collection", false)]
  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    int AppliedAgainst)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mExchangeFrom = AppliedAgainst;
    this.mTransactionType = TransactionEntryTypes.OperatingTransaction;
  }

  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    int AppliedAgainst,
    CostCenterAllocationCollection costCenterAllocations)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mExchangeFrom = AppliedAgainst;
    this.mTransactionType = TransactionEntryTypes.OperatingTransaction;
    this.mcostCenterAllocations = costCenterAllocations;
  }

  [Obsolete("This constructor is obsolete. Please use a constructor that provides the object with a cost center allocation collection", false)]
  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    Guid TransactionPayeeGuid)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mPayeeGuid = TransactionPayeeGuid;
    this.mTransactionType = TransactionEntryTypes.OperatingTransaction;
  }

  internal TransactionEntry(
    Decimal TransactionAmount,
    int TransactionGLAccount,
    Guid TransactionPayeeGuid,
    CostCenterAllocationCollection costCenterAllocations)
  {
    this.mPayeeGuid = Guid.Empty;
    this.mExchangeFrom = -1;
    this.mAmount = TransactionAmount;
    this.mGLAccount = TransactionGLAccount;
    this.mPayeeGuid = TransactionPayeeGuid;
    this.mTransactionType = TransactionEntryTypes.OperatingTransaction;
    this.mcostCenterAllocations = costCenterAllocations;
  }
}
