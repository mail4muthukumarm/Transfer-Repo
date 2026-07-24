// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.IMS_Overrides.ClaimInsuranceTransaction
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Claims.DataAccess.CheckRegister;
using MGASystems.IMS.Claims.DataAccess.GridClaimsArHeader;
using MGASystems.IMS.Claims.DataAccess.ReceiveTransactionExpense;
using MGASystems.IMS.Claims.DataAccess.RemitterJournal;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

#nullable disable
namespace MGASystems.IMS.Claims.IMS_Overrides;

[Override(typeof (InsuranceTransaction))]
[Serializable]
public class ClaimInsuranceTransaction : InsuranceTransaction
{
  public CheckRegisterDto CheckRegisterDto { get; set; }

  public RemitterJournalDto RemitterJournalDto { get; set; }

  public ReceiveExpenseHeaderDto ReceiveExpenseHeaderDto { get; set; }

  public List<ReceiveTransactionExpenseDto> ReceiveTransactionExpenseDtos { get; set; }

  public ClaimInsuranceTransaction()
  {
  }

  public ClaimInsuranceTransaction(Guid UserGuid, Utility.AccountingTransactionType TransactionType)
    : base(UserGuid, TransactionType)
  {
  }

  public ClaimInsuranceTransaction(
    Guid UserGuid,
    Utility.AccountingTransactionType TransactionType,
    int glCompanyId)
    : base(UserGuid, TransactionType, glCompanyId)
  {
  }

  protected virtual void SaveDebits(SqlCommand cmd, int transactionNumber)
  {
    foreach (TransactionDetail debit in (CollectionBase) ((AccountingTransaction) this).Debits)
    {
      if (!(debit.Amount == 0M))
      {
        cmd.Parameters.Clear();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spClaims_PostJournalDetail";
        cmd.Parameters.AddWithValue("@transactnum", (object) transactionNumber);
        cmd.Parameters.AddWithValue("@glacctid", (object) (debit.GLAccount == null ? debit.GLAccountId : debit.GLAccount.GLAccountID));
        Guid guid;
        if (debit.InvoiceNumber == 0 && debit.ChargeCode == 0)
        {
          guid = debit.CompanyLineGuid;
          if (guid.Equals(Guid.Empty))
          {
            cmd.Parameters.AddWithValue("@sourcedoctype", (object) "J");
            goto label_7;
          }
        }
        cmd.Parameters.AddWithValue("@sourcedoctype", this.IsReturnPremium ? (object) "N" : (object) "I");
label_7:
        if (debit.InvoiceNumber != 0)
          cmd.Parameters.AddWithValue("@invoicenum", (object) debit.InvoiceNumber);
        if (debit.ChargeCode != 0)
          cmd.Parameters.AddWithValue("@chargeCode", (object) debit.ChargeCode);
        guid = debit.CompanyLineGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@companylineguid", (object) debit.CompanyLineGuid);
        cmd.Parameters.AddWithValue("@amount", (object) debit.Amount);
        guid = debit.PayeeGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@payeeguid", (object) debit.PayeeGuid);
        if (debit.AppliedFrom > 0)
          cmd.Parameters.AddWithValue("@appliedFrom", (object) debit.AppliedFrom);
        if (debit.Comments != null && !debit.Equals((object) string.Empty))
          cmd.Parameters.AddWithValue("@comment", (object) debit.Comments);
        SqlParameterCollection parameters = cmd.Parameters;
        guid = debit.EntityGuid;
        // ISSUE: variable of a boxed type
        __Boxed<SqlGuid> local = (System.ValueType) (guid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) debit.EntityGuid);
        parameters.AddWithValue("@entityGuid", (object) local);
        if (debit is AccountingTransactionDetail)
        {
          if ((debit as AccountingTransactionDetail).ClaimId != 0)
            cmd.Parameters.AddWithValue("@claimId", (object) (debit as AccountingTransactionDetail).ClaimId);
          if ((debit as AccountingTransactionDetail).ResPayId != 0)
            cmd.Parameters.AddWithValue("@resPayId", (object) (debit as AccountingTransactionDetail).ResPayId);
          if ((debit as AccountingTransactionDetail).UAExpenseId != 0)
            cmd.Parameters.AddWithValue("@UAExpenseId", (object) (debit as AccountingTransactionDetail).UAExpenseId);
        }
        int num = int.Parse(cmd.ExecuteScalar().ToString());
        if (debit != null && debit.CostCenterAllocations != null)
        {
          foreach (CostCenterAllocation centerAllocation in (CollectionBase) debit.CostCenterAllocations)
            centerAllocation.Save(cmd, num, false);
        }
      }
    }
  }

  protected virtual void SaveCredits(SqlCommand cmd, int transactionNumber)
  {
    foreach (TransactionDetail credit in (CollectionBase) ((AccountingTransaction) this).Credits)
    {
      if (!(credit.Amount == 0M))
      {
        cmd.Parameters.Clear();
        cmd.CommandType = CommandType.StoredProcedure;
        cmd.CommandText = "spClaims_PostJournalDetail";
        cmd.Parameters.AddWithValue("@transactnum", (object) transactionNumber);
        cmd.Parameters.AddWithValue("@glacctid", (object) (credit.GLAccount == null ? credit.GLAccountId : credit.GLAccount.GLAccountID));
        Guid guid;
        if (credit.InvoiceNumber == 0 && credit.ChargeCode == 0)
        {
          guid = credit.CompanyLineGuid;
          if (guid.Equals(Guid.Empty))
          {
            cmd.Parameters.AddWithValue("@sourcedoctype", (object) "J");
            goto label_7;
          }
        }
        cmd.Parameters.AddWithValue("@sourcedoctype", this.IsReturnPremium ? (object) "N" : (object) "I");
label_7:
        if (credit.InvoiceNumber != 0)
          cmd.Parameters.AddWithValue("@invoicenum", (object) credit.InvoiceNumber);
        if (credit.ChargeCode != 0)
          cmd.Parameters.AddWithValue("@chargeCode", (object) credit.ChargeCode);
        guid = credit.CompanyLineGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@companylineguid", (object) credit.CompanyLineGuid);
        cmd.Parameters.AddWithValue("@amount", (object) -credit.Amount);
        guid = credit.PayeeGuid;
        if (!guid.Equals(Guid.Empty))
          cmd.Parameters.AddWithValue("@payeeguid", (object) credit.PayeeGuid);
        if (credit.Comments != null && !credit.Equals((object) string.Empty))
          cmd.Parameters.AddWithValue("@comment", (object) credit.Comments);
        if (credit is AccountingTransactionDetail)
        {
          if ((credit as AccountingTransactionDetail).ClaimId != 0)
            cmd.Parameters.AddWithValue("@claimId", (object) (credit as AccountingTransactionDetail).ClaimId);
          if ((credit as AccountingTransactionDetail).ResPayId != 0)
            cmd.Parameters.AddWithValue("@resPayId", (object) (credit as AccountingTransactionDetail).ResPayId);
          if ((credit as AccountingTransactionDetail).UAExpenseId != 0)
            cmd.Parameters.AddWithValue("@UAExpenseId", (object) (credit as AccountingTransactionDetail).UAExpenseId);
        }
        SqlParameterCollection parameters = cmd.Parameters;
        guid = credit.EntityGuid;
        // ISSUE: variable of a boxed type
        __Boxed<SqlGuid> local = (System.ValueType) (guid.Equals(Guid.Empty) ? SqlGuid.Null : (SqlGuid) credit.EntityGuid);
        parameters.AddWithValue("@entityGuid", (object) local);
        int num = int.Parse(cmd.ExecuteScalar().ToString());
        if (credit != null && credit.CostCenterAllocations != null)
        {
          foreach (CostCenterAllocation centerAllocation in (CollectionBase) credit.CostCenterAllocations)
            centerAllocation.Save(cmd, num, true);
        }
      }
    }
  }
}
