// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.IMS_Overrides.AccountingTransactionDetail
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Shared;
using System;

#nullable disable
namespace MGASystems.IMS.Claims.IMS_Overrides;

[Override(typeof (TransactionDetail))]
[Serializable]
public class AccountingTransactionDetail : TransactionDetail
{
  public virtual int ClaimId { get; set; }

  public virtual int ResPayId { get; set; }

  public virtual int UAExpenseId { get; set; }

  public AccountingTransactionDetail()
  {
  }

  public AccountingTransactionDetail(
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
    : base(transactionNumber, invoiceNumber, chargeCode, purchaseOrderNumber, expenseCode, appliedFrom, exchangeFrom, glAccount, companyLineGuid, payeeGuid, transactionAmount, entityGuid, allocations)
  {
  }

  public AccountingTransactionDetail(
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
    : base(transactionNumber, invoiceNumber, chargeCode, purchaseOrderNumber, expenseCode, appliedFrom, exchangeFrom, glAccount, companyLineGuid, payeeGuid, transactionAmount, entityGuid, postingComments, allocations)
  {
  }

  public AccountingTransactionDetail(
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
    : base(transactionNumber, invoiceNumber, chargeCode, purchaseOrderNumber, expenseCode, appliedFrom, exchangeFrom, glAccountId, companyLineGuid, payeeGuid, transactionAmount, entityGuid, allocations)
  {
  }

  public AccountingTransactionDetail(
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
    : base(transactionNumber, invoiceNumber, chargeCode, purchaseOrderNumber, expenseCode, appliedFrom, exchangeFrom, glAccountId, companyLineGuid, payeeGuid, transactionAmount, entityGuid, postingComments, allocations)
  {
  }

  public AccountingTransactionDetail(
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
    : base(invoiceNumber, chargeCode, purchaseOrderNumber, expenseCode, appliedFrom, exchangeFrom, glAccount, companyLineGuid, payeeGuid, transactionAmount, entityGuid, allocations)
  {
  }

  public AccountingTransactionDetail(
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
    : base(invoiceNumber, chargeCode, purchaseOrderNumber, expenseCode, appliedFrom, exchangeFrom, glAccount, companyLineGuid, payeeGuid, transactionAmount, entityGuid, postingComments, allocations)
  {
  }

  public AccountingTransactionDetail(
    int claimId,
    int resPayId,
    int uaExpenseid,
    int glAccountId,
    Guid entityGuid,
    Decimal transactionAmount,
    CostCenterAllocationCollection allocations)
    : base(0, 0, 0, 0, 0, 0, glAccountId, Guid.Empty, entityGuid, transactionAmount, entityGuid, allocations)
  {
    this.ClaimId = claimId;
    this.ResPayId = resPayId;
    this.UAExpenseId = uaExpenseid;
  }

  public AccountingTransactionDetail(
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
    : base(invoiceNumber, chargeCode, purchaseOrderNumber, expenseCode, appliedFrom, exchangeFrom, glAccountId, companyLineGuid, payeeGuid, transactionAmount, entityGuid, allocations)
  {
  }

  public AccountingTransactionDetail(
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
    : base(invoiceNumber, chargeCode, purchaseOrderNumber, expenseCode, appliedFrom, exchangeFrom, glAccountId, companyLineGuid, payeeGuid, transactionAmount, entityGuid, postingComments, allocations)
  {
  }

  public virtual TransactionDetail Copy()
  {
    return (TransactionDetail) new AccountingTransactionDetail(this.ClaimId, this.ResPayId, this.UAExpenseId, this.GLAccountId, this.EntityGuid, this.Amount, this.CostCenterAllocations);
  }
}
