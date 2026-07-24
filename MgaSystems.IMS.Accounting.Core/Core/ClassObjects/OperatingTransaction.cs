// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.OperatingTransaction
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.Exceptions;
using MGASystems.IMS.Accounting.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

public class OperatingTransaction : AccountingTransaction
{
  private bool createCheck;
  private bool createRemittance;
  private bool isExpensedCommission;

  public OperatingTransaction(Guid UserGuid)
    : base(UserGuid, Utility.AccountingTransactionType.Operating, Utility.AccountingJournalEntryType.Operating)
  {
    this.createCheck = false;
    this.createRemittance = false;
    this.isExpensedCommission = false;
  }

  public OperatingTransaction(Guid UserGuid, bool CreateCheck, bool CreateRemittance)
    : base(UserGuid, Utility.AccountingTransactionType.Operating, Utility.AccountingJournalEntryType.Operating)
  {
    this.createCheck = CreateCheck;
    this.createRemittance = CreateRemittance;
    this.isExpensedCommission = false;
  }

  public OperatingTransaction(
    Guid UserGuid,
    bool CreateCheck,
    bool CreateRemittance,
    bool IsExpensedCommission)
    : base(UserGuid, Utility.AccountingTransactionType.Operating, Utility.AccountingJournalEntryType.Operating)
  {
    this.createCheck = CreateCheck;
    this.createRemittance = CreateRemittance;
    this.isExpensedCommission = IsExpensedCommission;
  }

  public OperatingTransaction(Guid UserGuid, bool IsExpensedCommission)
    : base(UserGuid, Utility.AccountingTransactionType.Operating, Utility.AccountingJournalEntryType.Operating)
  {
    this.createCheck = false;
    this.createRemittance = false;
    this.isExpensedCommission = IsExpensedCommission;
  }

  public bool CreateCheck
  {
    get => this.createCheck;
    set => this.createCheck = value;
  }

  public bool CreateRemittance
  {
    get => this.createRemittance;
    set => this.createRemittance = value;
  }

  public bool IsExpensedCommission => this.isExpensedCommission;

  public override void Save()
  {
    using (SqlCommand cmd = new SqlCommand())
    {
      cmd.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
      try
      {
        cmd.Connection.Open();
        cmd.Transaction = cmd.Connection.BeginTransaction();
        this.Save(cmd);
        cmd.Transaction.Commit();
        CurrentUser.Instance.LogAction($"Created operating check, transaction #{this.TransactionNumber}", "Accounting Logs");
      }
      catch
      {
        if (cmd.Transaction != null)
          cmd.Transaction.Rollback();
        throw;
      }
    }
  }

  public override void Save(SqlCommand cmd)
  {
    this.SaveHeader(cmd);
    this.SaveDetails(cmd, this.TransactionNumber);
    if (this.CreateCheck)
      this.CreateCheckPosting(cmd, this.TransactionNumber, this.CheckData);
    else if (this.CreateRemittance)
      this.CreateRemittancePosting(cmd, this.TransactionNumber);
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_CheckTheBooks";
    cmd.Parameters.Clear();
    if ((Decimal) cmd.ExecuteScalar() != 0M)
      throw new TransactionOutOfBalanceException("Saving the current transaction would leave the books in an unbalanced state. This transaction can not be saves. Please check the transaction and try again.");
  }

  private void SaveHeader(SqlCommand cmd)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "dbo.spFin_PostJournalHeader";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@postdate", (object) this.PostDate);
    if (this.CreateCheck)
      cmd.Parameters.AddWithValue("@transdescid", (object) "D");
    else
      cmd.Parameters.AddWithValue("@transdescid", (object) "O");
    cmd.Parameters.AddWithValue("@journalentrytype", (object) "O");
    cmd.Parameters.AddWithValue("@comments", (object) this.TransactionComments);
    cmd.Parameters.AddWithValue("@userguid", (object) this.UserGuid);
    this.TransNumber = int.Parse(cmd.ExecuteScalar().ToString());
  }

  private void SaveDetails(SqlCommand cmd, int TransactionNumber)
  {
    foreach (TransactionDetail debit in (CollectionBase) this.Debits)
    {
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.CommandText = "dbo.spfin_PostJournalDetail";
      cmd.Parameters.Clear();
      cmd.Parameters.AddWithValue("@transactnum", (object) TransactionNumber);
      if (debit.GLAccount != null)
        cmd.Parameters.AddWithValue("@glacctid", (object) debit.GLAccount.GLAccountID);
      else
        cmd.Parameters.AddWithValue("@glacctid", (object) debit.GLAccountId);
      if (!this.IsExpensedCommission)
        cmd.Parameters.AddWithValue("@sourcedoctype", (object) "P");
      else
        cmd.Parameters.AddWithValue("@sourcedoctype", (object) "S");
      if (debit.InvoiceNumber != 0)
        cmd.Parameters.AddWithValue("@invoicenum", (object) debit.InvoiceNumber);
      if (debit.ChargeCode != 0)
        cmd.Parameters.AddWithValue("@chargecode", (object) debit.ChargeCode);
      if (!debit.CompanyLineGuid.Equals(Guid.Empty))
        cmd.Parameters.AddWithValue("@companylineguid", (object) debit.CompanyLineGuid);
      if (debit.PurchaseOrderNumber != 0)
        cmd.Parameters.AddWithValue("@ponum", (object) debit.PurchaseOrderNumber);
      if (debit.ExpenseCode != 0)
        cmd.Parameters.AddWithValue("@expensecode", (object) debit.ExpenseCode);
      cmd.Parameters.AddWithValue("@amount", (object) Math.Abs(debit.Amount));
      if (!debit.PayeeGuid.Equals(Guid.Empty))
        cmd.Parameters.AddWithValue("@payeeguid", (object) debit.PayeeGuid);
      int PostingNumber = int.Parse(cmd.ExecuteScalar().ToString());
      if (debit.CostCenterAllocations != null)
      {
        foreach (CostCenterAllocation centerAllocation in (CollectionBase) debit.CostCenterAllocations)
          centerAllocation.Save(cmd, PostingNumber, false);
      }
    }
    foreach (TransactionDetail credit in (CollectionBase) this.Credits)
    {
      cmd.CommandType = CommandType.StoredProcedure;
      cmd.CommandText = "dbo.spfin_PostJournalDetail";
      cmd.Parameters.Clear();
      cmd.Parameters.AddWithValue("@transactnum", (object) TransactionNumber);
      if (credit.GLAccount != null)
        cmd.Parameters.AddWithValue("@glacctid", (object) credit.GLAccount.GLAccountID);
      else
        cmd.Parameters.AddWithValue("@glacctid", (object) credit.GLAccountId);
      if (!this.IsExpensedCommission)
        cmd.Parameters.AddWithValue("@sourcedoctype", (object) "P");
      else
        cmd.Parameters.AddWithValue("@sourcedoctype", (object) "S");
      if (credit.InvoiceNumber != 0)
        cmd.Parameters.AddWithValue("@invoicenum", (object) credit.InvoiceNumber);
      if (credit.ChargeCode != 0)
        cmd.Parameters.AddWithValue("@chargecode", (object) credit.ChargeCode);
      Guid guid = credit.CompanyLineGuid;
      if (!guid.Equals(Guid.Empty))
        cmd.Parameters.AddWithValue("@companylineguid", (object) credit.CompanyLineGuid);
      if (credit.PurchaseOrderNumber != 0)
        cmd.Parameters.AddWithValue("@ponum", (object) credit.PurchaseOrderNumber);
      if (credit.ExpenseCode != 0)
        cmd.Parameters.AddWithValue("@expensecode", (object) credit.ExpenseCode);
      cmd.Parameters.AddWithValue("@amount", (object) -Math.Abs(credit.Amount));
      guid = credit.PayeeGuid;
      if (!guid.Equals(Guid.Empty))
        cmd.Parameters.AddWithValue("@payeeguid", (object) credit.PayeeGuid);
      int PostingNumber = int.Parse(cmd.ExecuteScalar().ToString());
      if (credit.CostCenterAllocations != null)
      {
        foreach (CostCenterAllocation centerAllocation in (CollectionBase) credit.CostCenterAllocations)
          centerAllocation.Save(cmd, PostingNumber, true);
      }
    }
  }

  private void SaveScheduledExpense()
  {
  }

  private void CreateRemittancePosting(SqlCommand cmd, int TransactionNumber)
  {
  }

  protected override bool ChildSave(Dictionary<string, object> parameters) => false;
}
