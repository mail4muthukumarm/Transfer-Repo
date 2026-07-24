// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.TransactionDetail
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.IMS.Accounting.GeneralLedger;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.Shared;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[Serializable]
public class TransactionDetail : ISupportCostCenterAllocation, ICloneable
{
  public TransactionDetail()
  {
  }

  public TransactionDetail(
    int transactionNumber,
    int invoiceNumber,
    int chargeCode,
    int purchaseOrderNumber,
    int expenseCode,
    int appliedFrom,
    int exchangeFrom,
    GLAccount glAccount,
    Guid companyLineGuid,
    Guid payeeGuid,
    Decimal transactionAmount,
    Guid entityGuid,
    CostCenterAllocationCollection allocations)
  {
    this.TransactionNumber = transactionNumber;
    this.InvoiceNumber = invoiceNumber;
    this.ChargeCode = chargeCode;
    this.PurchaseOrderNumber = purchaseOrderNumber;
    this.ExpenseCode = expenseCode;
    this.AppliedFrom = appliedFrom;
    this.ExchangeFrom = exchangeFrom;
    this.GLAccount = glAccount;
    this.CompanyLineGuid = companyLineGuid;
    this.PayeeGuid = payeeGuid;
    this.Amount = transactionAmount;
    this.CostCenterAllocations = allocations;
    this.EntityGuid = entityGuid;
  }

  public TransactionDetail(
    int transactionNumber,
    int invoiceNumber,
    int chargeCode,
    int purchaseOrderNumber,
    int expenseCode,
    int appliedFrom,
    int exchangeFrom,
    GLAccount glAccount,
    Guid companyLineGuid,
    Guid payeeGuid,
    Decimal transactionAmount,
    Guid entityGuid,
    string postingComments,
    CostCenterAllocationCollection allocations)
  {
    this.TransactionNumber = transactionNumber;
    this.InvoiceNumber = invoiceNumber;
    this.ChargeCode = chargeCode;
    this.PurchaseOrderNumber = purchaseOrderNumber;
    this.ExpenseCode = expenseCode;
    this.AppliedFrom = appliedFrom;
    this.ExchangeFrom = exchangeFrom;
    this.GLAccount = glAccount;
    this.CompanyLineGuid = companyLineGuid;
    this.PayeeGuid = payeeGuid;
    this.Amount = transactionAmount;
    this.Comments = postingComments;
    this.CostCenterAllocations = allocations;
    this.EntityGuid = entityGuid;
  }

  public TransactionDetail(
    int transactionNumber,
    int invoiceNumber,
    int chargeCode,
    int purchaseOrderNumber,
    int expenseCode,
    int appliedFrom,
    int exchangeFrom,
    int glAccountId,
    Guid companyLineGuid,
    Guid payeeGuid,
    Decimal transactionAmount,
    Guid entityGuid,
    CostCenterAllocationCollection allocations)
  {
    this.TransactionNumber = transactionNumber;
    this.InvoiceNumber = invoiceNumber;
    this.ChargeCode = chargeCode;
    this.PurchaseOrderNumber = purchaseOrderNumber;
    this.ExpenseCode = expenseCode;
    this.AppliedFrom = appliedFrom;
    this.ExchangeFrom = exchangeFrom;
    this.GLAccountId = glAccountId;
    this.CompanyLineGuid = companyLineGuid;
    this.PayeeGuid = payeeGuid;
    this.Amount = transactionAmount;
    this.CostCenterAllocations = allocations;
    this.EntityGuid = entityGuid;
  }

  public TransactionDetail(
    int transactionNumber,
    int invoiceNumber,
    int chargeCode,
    int purchaseOrderNumber,
    int expenseCode,
    int appliedFrom,
    int exchangeFrom,
    int glAccountId,
    Guid companyLineGuid,
    Guid payeeGuid,
    Decimal transactionAmount,
    Guid entityGuid,
    string postingComments,
    CostCenterAllocationCollection allocations)
  {
    this.TransactionNumber = transactionNumber;
    this.InvoiceNumber = invoiceNumber;
    this.ChargeCode = chargeCode;
    this.PurchaseOrderNumber = purchaseOrderNumber;
    this.ExpenseCode = expenseCode;
    this.AppliedFrom = appliedFrom;
    this.ExchangeFrom = exchangeFrom;
    this.GLAccountId = glAccountId;
    this.CompanyLineGuid = companyLineGuid;
    this.PayeeGuid = payeeGuid;
    this.Amount = transactionAmount;
    this.Comments = postingComments;
    this.CostCenterAllocations = allocations;
    this.EntityGuid = entityGuid;
  }

  public TransactionDetail(
    int invoiceNumber,
    int chargeCode,
    int purchaseOrderNumber,
    int expenseCode,
    int appliedFrom,
    int exchangeFrom,
    GLAccount glAccount,
    Guid companyLineGuid,
    Guid payeeGuid,
    Decimal transactionAmount,
    Guid entityGuid,
    CostCenterAllocationCollection allocations)
  {
    this.InvoiceNumber = invoiceNumber;
    this.ChargeCode = chargeCode;
    this.PurchaseOrderNumber = purchaseOrderNumber;
    this.ExpenseCode = expenseCode;
    this.AppliedFrom = appliedFrom;
    this.ExchangeFrom = exchangeFrom;
    this.GLAccount = glAccount;
    this.CompanyLineGuid = companyLineGuid;
    this.PayeeGuid = payeeGuid;
    this.Amount = transactionAmount;
    this.CostCenterAllocations = allocations;
    this.EntityGuid = entityGuid;
  }

  public TransactionDetail(
    int invoiceNumber,
    int chargeCode,
    int purchaseOrderNumber,
    int expenseCode,
    int appliedFrom,
    int exchangeFrom,
    GLAccount glAccount,
    Guid companyLineGuid,
    Guid payeeGuid,
    Decimal transactionAmount,
    Guid entityGuid,
    string postingComments,
    CostCenterAllocationCollection allocations)
  {
    this.InvoiceNumber = invoiceNumber;
    this.ChargeCode = chargeCode;
    this.PurchaseOrderNumber = purchaseOrderNumber;
    this.ExpenseCode = expenseCode;
    this.AppliedFrom = appliedFrom;
    this.ExchangeFrom = exchangeFrom;
    this.GLAccount = glAccount;
    this.CompanyLineGuid = companyLineGuid;
    this.PayeeGuid = payeeGuid;
    this.Amount = transactionAmount;
    this.Comments = postingComments;
    this.CostCenterAllocations = allocations;
    this.EntityGuid = entityGuid;
  }

  public TransactionDetail(
    int invoiceNumber,
    int chargeCode,
    int purchaseOrderNumber,
    int expenseCode,
    int appliedFrom,
    int exchangeFrom,
    int glAccountId,
    Guid companyLineGuid,
    Guid payeeGuid,
    Decimal transactionAmount,
    Guid entityGuid,
    CostCenterAllocationCollection allocations)
  {
    this.InvoiceNumber = invoiceNumber;
    this.ChargeCode = chargeCode;
    this.PurchaseOrderNumber = purchaseOrderNumber;
    this.ExpenseCode = expenseCode;
    this.AppliedFrom = appliedFrom;
    this.ExchangeFrom = exchangeFrom;
    this.GLAccountId = glAccountId;
    this.CompanyLineGuid = companyLineGuid;
    this.PayeeGuid = payeeGuid;
    this.Amount = transactionAmount;
    this.CostCenterAllocations = allocations;
    this.EntityGuid = entityGuid;
  }

  public TransactionDetail(
    int invoiceNumber,
    int chargeCode,
    int purchaseOrderNumber,
    int expenseCode,
    int appliedFrom,
    int exchangeFrom,
    int glAccountId,
    Guid companyLineGuid,
    Guid payeeGuid,
    Decimal transactionAmount,
    Guid entityGuid,
    string postingComments,
    CostCenterAllocationCollection allocations)
  {
    this.InvoiceNumber = invoiceNumber;
    this.ChargeCode = chargeCode;
    this.PurchaseOrderNumber = purchaseOrderNumber;
    this.ExpenseCode = expenseCode;
    this.AppliedFrom = appliedFrom;
    this.ExchangeFrom = exchangeFrom;
    this.GLAccountId = glAccountId;
    this.CompanyLineGuid = companyLineGuid;
    this.PayeeGuid = payeeGuid;
    this.Amount = transactionAmount;
    this.CostCenterAllocations = allocations;
    this.EntityGuid = entityGuid;
    this.Comments = postingComments;
  }

  public TransactionDetail(
    int claimId,
    int resPayId,
    int uaExpenseid,
    int glAccountId,
    Guid entityGuid,
    Decimal transactionAmount,
    CostCenterAllocationCollection allocations)
  {
  }

  public virtual int TransactionNumber { get; protected set; }

  public virtual int InvoiceNumber { get; set; }

  public virtual int ChargeCode { get; set; }

  public virtual int PurchaseOrderNumber { get; set; }

  public virtual int ExpenseCode { get; set; }

  public virtual Guid CompanyLineGuid { get; set; }

  public virtual Decimal Amount { get; set; }

  public virtual Guid PayeeGuid { get; set; }

  public virtual int AppliedFrom { get; set; }

  public virtual int ExchangeFrom { get; set; }

  public virtual GLAccount GLAccount { get; set; }

  public virtual int GLAccountId { get; set; }

  public virtual string Comments { get; set; }

  public virtual Guid EntityGuid { get; set; }

  public virtual CostCenterAllocationCollection CostCenterAllocations { get; set; }

  public virtual TransactionDetail Copy()
  {
    return new TransactionDetail(this.InvoiceNumber, this.ChargeCode, this.PurchaseOrderNumber, this.ExpenseCode, this.AppliedFrom, this.ExchangeFrom, this.GLAccountId, this.CompanyLineGuid, this.PayeeGuid, this.Amount, this.EntityGuid, this.Comments, this.CostCenterAllocations);
  }

  public virtual string GLAccountName => SharedMembers.GetGLAccountFullName(this.GLAccountId);

  public virtual DateTime TransactionDate => new DateTime();

  public virtual int PostingNumber => 0;

  public virtual Decimal TransactionTotal => this.Amount;

  public virtual object Clone() => (object) null;
}
