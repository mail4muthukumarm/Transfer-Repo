// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.OperatingExpenseServices
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;
using System;
using System.Collections;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;

public class OperatingExpenseServices
{
  internal static TransactionSet CreateTransactionSet(PurchaseOrderExpense PoObject)
  {
    TransactionSet transactionSet = new TransactionSet();
    if (PoObject.Schedule == null)
    {
      transactionSet.Add((AccountingTransaction) OperatingExpenseServices.CreateTransaction(PoObject));
    }
    else
    {
      foreach (ScheduleDetail detailObject in (CollectionBase) PoObject.Schedule.ScheduleBreakout)
        transactionSet.Add((AccountingTransaction) OperatingExpenseServices.CreateTransaction(PoObject, detailObject));
    }
    return transactionSet;
  }

  private static OperatingTransaction CreateTransaction(PurchaseOrderExpense PoObject)
  {
    OperatingTransaction transaction = !(PoObject.GetExpenseTotal() > 0M) ? new OperatingTransaction(CurrentUser.Instance.UserGUID, false, false) : (PoObject.CheckData != null ? new OperatingTransaction(CurrentUser.Instance.UserGUID, true, false) : new OperatingTransaction(CurrentUser.Instance.UserGUID, false, false));
    switch (PoObject.PaymentType)
    {
      case MGASystems.IMS.Accounting.OperatingExpenses.Utilities.PurchaseOrderPaymentType.PayNow:
        IEnumerator enumerator1 = PoObject.ExpenseDetails.GetEnumerator();
        try
        {
          while (enumerator1.MoveNext())
          {
            PurchaseOrderExpenseDetail current = (PurchaseOrderExpenseDetail) enumerator1.Current;
            if (current.ExpenseTotal > 0M)
            {
              transaction.Debits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(current.GlAccountId), Guid.Empty, PoObject.PayeeGuid, current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
              transaction.Credits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(PoObject.BankGlAccountId), Guid.Empty, PoObject.PayeeGuid, -current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
            }
            else
            {
              transaction.Debits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(PoObject.BankGlAccountId), Guid.Empty, PoObject.PayeeGuid, -current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
              transaction.Credits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(current.GlAccountId), Guid.Empty, PoObject.PayeeGuid, current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
            }
          }
          break;
        }
        finally
        {
          if (enumerator1 is IDisposable disposable)
            disposable.Dispose();
        }
      case MGASystems.IMS.Accounting.OperatingExpenses.Utilities.PurchaseOrderPaymentType.PayNowPrePaid:
        if (AccountingCache.Instance.GlCompany(PoObject.GlCompanyId).PrepaidExpenseAutomationAccount == null)
        {
          transaction.Dispose();
          throw new ExpenseAutomationAccountNotFound("The pre-paid expense account for this office location has not been defined. This operation can not continue.");
        }
        IEnumerator enumerator2 = PoObject.ExpenseDetails.GetEnumerator();
        try
        {
          while (enumerator2.MoveNext())
          {
            PurchaseOrderExpenseDetail current = (PurchaseOrderExpenseDetail) enumerator2.Current;
            if (current.ExpenseTotal > 0M)
            {
              transaction.Debits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, AccountingCache.Instance.GlCompany(PoObject.GlCompanyId).PrepaidExpenseAutomationAccount, Guid.Empty, PoObject.PayeeGuid, current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
              transaction.Credits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(PoObject.BankGlAccountId), Guid.Empty, PoObject.PayeeGuid, -current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
            }
            else
            {
              transaction.Debits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(PoObject.BankGlAccountId), Guid.Empty, PoObject.PayeeGuid, -current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
              transaction.Credits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, AccountingCache.Instance.GlCompany(PoObject.GlCompanyId).PrepaidExpenseAutomationAccount, Guid.Empty, PoObject.PayeeGuid, current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
            }
          }
          break;
        }
        finally
        {
          if (enumerator2 is IDisposable disposable)
            disposable.Dispose();
        }
      case MGASystems.IMS.Accounting.OperatingExpenses.Utilities.PurchaseOrderPaymentType.PayLater:
        IEnumerator enumerator3 = PoObject.ExpenseDetails.GetEnumerator();
        try
        {
          while (enumerator3.MoveNext())
          {
            PurchaseOrderExpenseDetail current = (PurchaseOrderExpenseDetail) enumerator3.Current;
            if (current.ExpenseTotal > 0M)
            {
              transaction.Debits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(current.GlAccountId), Guid.Empty, PoObject.PayeeGuid, current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
              transaction.Credits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(PoObject.GlOffset), Guid.Empty, PoObject.PayeeGuid, -current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
            }
            else
            {
              transaction.Debits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(PoObject.GlOffset), Guid.Empty, PoObject.PayeeGuid, -current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
              transaction.Credits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(current.GlAccountId), Guid.Empty, PoObject.PayeeGuid, current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
            }
          }
          break;
        }
        finally
        {
          if (enumerator3 is IDisposable disposable)
            disposable.Dispose();
        }
      default:
        throw new InvalidOperationException("The purchase order payment type is invalid for this method!");
    }
    transaction.PostDate = PoObject.PurchaseOrderDate;
    transaction.TransactionComments = PoObject.PurchaseOrderComments;
    transaction.TransactionType = Utility.AccountingTransactionType.Operating;
    if (PoObject.CheckData != null)
      transaction.CheckData = PoObject.CheckData;
    return transaction;
  }

  private static OperatingTransaction CreateTransaction(
    PurchaseOrderExpense PoObject,
    ScheduleDetail detailObject)
  {
    OperatingTransaction transaction = !detailObject.ExpenseDate.Equals(DateTime.Now) ? new OperatingTransaction(CurrentUser.Instance.UserGUID, false, false) : (PoObject.CheckData != null ? new OperatingTransaction(CurrentUser.Instance.UserGUID, true, false) : new OperatingTransaction(CurrentUser.Instance.UserGUID, false, false));
    OperatingTransaction operatingTransaction;
    switch (PoObject.Schedule.ScheduleJournalType)
    {
      case MGASystems.IMS.Accounting.OperatingExpenses.Utilities.ExpenseScheduleJournalType.Accrued:
        if (AccountingCache.Instance.GlCompany(PoObject.GlCompanyId).AccruedExpenseAutomationAccount == null)
        {
          transaction.Dispose();
          operatingTransaction = (OperatingTransaction) null;
          throw new ExpenseAutomationAccountNotFound("The accrued expense account for this office location has not been defined. This operation can not continue.");
        }
        foreach (PurchaseOrderExpenseDetail expenseDetail in (CollectionBase) PoObject.ExpenseDetails)
          transaction.Debits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, expenseDetail.ExpenseCode, 0, 0, new GLAccount(expenseDetail.GlAccountId), Guid.Empty, PoObject.PayeeGuid, expenseDetail.ExpenseTotal, PoObject.PayeeGuid, expenseDetail.CostCenterAllocations));
        IEnumerator enumerator1 = PoObject.ExpenseDetails.GetEnumerator();
        try
        {
          while (enumerator1.MoveNext())
          {
            PurchaseOrderExpenseDetail current = (PurchaseOrderExpenseDetail) enumerator1.Current;
            transaction.Credits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, AccountingCache.Instance.GlCompany(PoObject.GlCompanyId).AccruedExpenseAutomationAccount, Guid.Empty, PoObject.PayeeGuid, -current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
          }
          break;
        }
        finally
        {
          if (enumerator1 is IDisposable disposable)
            disposable.Dispose();
        }
      case MGASystems.IMS.Accounting.OperatingExpenses.Utilities.ExpenseScheduleJournalType.Prepaid:
        if (AccountingCache.Instance.GlCompany(PoObject.GlCompanyId).PrepaidExpenseAutomationAccount == null)
        {
          transaction.Dispose();
          operatingTransaction = (OperatingTransaction) null;
          throw new ExpenseAutomationAccountNotFound("The pre-paid expense account for this office location has not been defined. This operation can not continue.");
        }
        foreach (PurchaseOrderExpenseDetail expenseDetail in (CollectionBase) PoObject.ExpenseDetails)
          transaction.Debits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, expenseDetail.ExpenseCode, 0, 0, AccountingCache.Instance.GlCompany(PoObject.GlCompanyId).PrepaidExpenseAutomationAccount, Guid.Empty, PoObject.PayeeGuid, expenseDetail.ExpenseTotal, PoObject.PayeeGuid, expenseDetail.CostCenterAllocations));
        IEnumerator enumerator2 = PoObject.ExpenseDetails.GetEnumerator();
        try
        {
          while (enumerator2.MoveNext())
          {
            PurchaseOrderExpenseDetail current = (PurchaseOrderExpenseDetail) enumerator2.Current;
            transaction.Credits.Add(new TransactionDetail(0, 0, PoObject.PoNumber, current.ExpenseCode, 0, 0, new GLAccount(PoObject.BankGlAccountId), Guid.Empty, PoObject.PayeeGuid, -current.ExpenseTotal, PoObject.PayeeGuid, current.CostCenterAllocations));
          }
          break;
        }
        finally
        {
          if (enumerator2 is IDisposable disposable)
            disposable.Dispose();
        }
      default:
        throw new InvalidOperationException("The purchase order payment type is invalid for this method!");
    }
    transaction.PostDate = detailObject.ExpenseDate;
    transaction.TransactionComments = PoObject.PurchaseOrderComments;
    transaction.TransactionType = Utility.AccountingTransactionType.Operating;
    if (PoObject.CheckData != null)
      transaction.CheckData = PoObject.CheckData;
    return transaction;
  }
}
