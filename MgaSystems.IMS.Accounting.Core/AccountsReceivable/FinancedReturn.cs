// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.FinancedReturn
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

[Serializable]
public class FinancedReturn
{
  private Guid financeCompanyGuid;
  private FinancedReturnDetailCollection details;
  private readonly int glCompanyId;
  private DateTime checkDate;
  private readonly string financeCompanyName;

  public FinancedReturn(Guid FinanceCompanyGuid, int GlCompanyId, DateTime CheckDate)
  {
    this.financeCompanyGuid = FinanceCompanyGuid;
    this.glCompanyId = GlCompanyId;
    this.checkDate = CheckDate;
    this.financeCompanyName = Utility.GetEntityName(this.financeCompanyGuid);
  }

  public Guid FinanceCompanyGuid => this.financeCompanyGuid;

  public FinancedReturnDetailCollection Details
  {
    get
    {
      if (this.details == null)
        this.details = new FinancedReturnDetailCollection();
      return this.details;
    }
  }

  public int GlCompanyId => this.glCompanyId;

  public DateTime CheckDate
  {
    get => this.checkDate;
    set => this.checkDate = value;
  }

  public string FinanceCompanyName => this.financeCompanyName;

  [Obsolete("This method is deprecated, please use the method that does not require the SqlCommand object instead.")]
  public int Save(
    SqlCommand cmd,
    int TransactionNumber,
    string CheckMemo,
    Guid RemitterGuid,
    int BankGLAccountId,
    char paymentMethod)
  {
    if (!this.VerifyCheckAmount())
      throw new NegativeCheckException();
    if (this.VerifyZeroAmount())
      throw new ZeroCheckException();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_PostReceivablesHeader";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
    cmd.Parameters.AddWithValue("@comments", (object) CheckMemo);
    cmd.Parameters.AddWithValue("@remitterguid", (object) RemitterGuid);
    cmd.Parameters.AddWithValue("@refund", (object) 1);
    int num = int.Parse(cmd.ExecuteScalar().ToString());
    foreach (FinancedReturnDetail detail in (CollectionBase) this.Details)
    {
      if (detail.Selected)
      {
        cmd.CommandText = "spFin_PostReceivablesDetails";
        cmd.Parameters.Clear();
        cmd.Parameters.AddWithValue("@transactnum", (object) num);
        cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GlCompanyId);
        cmd.Parameters.AddWithValue("@glacctid", (object) detail.GlAccountId);
        cmd.Parameters.AddWithValue("@bankglacctid", (object) BankGLAccountId);
        cmd.Parameters.AddWithValue("@invoicenum", (object) detail.InvoiceNumber);
        cmd.Parameters.AddWithValue("@chargecode", (object) detail.ChargeCode);
        cmd.Parameters.AddWithValue("@companylineguid", (object) detail.CompanyLineGuid);
        cmd.Parameters.AddWithValue("@amount", (object) detail.Amount);
        cmd.Parameters.AddWithValue("@comments", (object) "");
        cmd.Parameters.AddWithValue("@entityGuid", (object) detail.EntityGuid);
        cmd.ExecuteNonQuery();
      }
    }
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_ExecutePropIncome";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@transactnum", (object) num);
    cmd.Parameters.AddWithValue("@rollupto", (object) "A/R");
    cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GlCompanyId);
    cmd.ExecuteNonQuery();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_PostCommissionableFees";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@transactnum", (object) num);
    cmd.Parameters.AddWithValue("@transtype", (object) "AR");
    cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GlCompanyId);
    cmd.ExecuteNonQuery();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_PostPayables_CheckRegister";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@PAYMENTMETHODID", (object) paymentMethod);
    cmd.Parameters.AddWithValue("@TRANSACTNUM", (object) num);
    cmd.Parameters.AddWithValue("@PAYEEGUID", (object) this.FinanceCompanyGuid);
    cmd.Parameters.AddWithValue("@CHECKDATE", (object) this.CheckDate);
    cmd.Parameters.AddWithValue("@CHECKMEMO", (object) CheckMemo);
    cmd.Parameters.AddWithValue("@COMMENTS", (object) DBNull.Value);
    cmd.Parameters.AddWithValue("@FROMBANKGLACCTID", (object) BankGLAccountId);
    cmd.ExecuteNonQuery();
    cmd.Parameters.Clear();
    cmd.CommandType = CommandType.Text;
    cmd.CommandText = $"Select dbo.CheckDistributionBalance({num})";
    cmd.Parameters.Clear();
    if (int.Parse(cmd.ExecuteScalar().ToString()) != 1)
      throw new TransactionOutOfBalanceException("An error has occurred while trying to post this receivables transaction. The posting distribution would not balance. To ensure data integrity this transaction has been rolled back.");
    return num;
  }

  public int Save(string checkMemo, Guid remitterGuid, int bankGLAccountId, int commandTimeout = 30)
  {
    if (!this.VerifyCheckAmount())
      throw new NegativeCheckException();
    if (this.VerifyZeroAmount())
      throw new ZeroCheckException();
    int num = DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, "spFin_PostReceivablesHeader", commandTimeout, (CommandArgumentType) 0, new object[8]
    {
      (object) "@userguid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@comments",
      (object) checkMemo,
      (object) "@remitterguid",
      (object) remitterGuid,
      (object) "@refund",
      (object) 1
    });
    foreach (FinancedReturnDetail detail in (CollectionBase) this.Details)
    {
      if (detail.Selected)
        DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spFin_PostReceivablesDetails", commandTimeout, (CommandArgumentType) 0, new object[20]
        {
          (object) "@transactnum",
          (object) num,
          (object) "@glcompanyid",
          (object) this.GlCompanyId,
          (object) "@glacctid",
          (object) detail.GlAccountId,
          (object) "@bankglacctid",
          (object) bankGLAccountId,
          (object) "@invoicenum",
          (object) detail.InvoiceNumber,
          (object) "@chargecode",
          (object) detail.ChargeCode,
          (object) "@companylineguid",
          (object) detail.CompanyLineGuid,
          (object) "@amount",
          (object) detail.Amount,
          (object) "@comments",
          (object) string.Empty,
          (object) "@entityGuid",
          (object) detail.EntityGuid
        });
    }
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spFin_ExecutePropIncome", commandTimeout, (CommandArgumentType) 0, new object[6]
    {
      (object) "@transactnum",
      (object) num,
      (object) "@rollupto",
      (object) "A/R",
      (object) "@glcompanyid",
      (object) this.GlCompanyId
    });
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spFin_PostCommissionableFees", commandTimeout, (CommandArgumentType) 0, new object[6]
    {
      (object) "@transactnum",
      (object) num,
      (object) "@transtype",
      (object) "AR",
      (object) "@glcompanyid",
      (object) this.GlCompanyId
    });
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spFin_PostPayables_CheckRegister", commandTimeout, (CommandArgumentType) 0, new object[14]
    {
      (object) "@PAYMENTMETHODID",
      (object) "C",
      (object) "@TRANSACTNUM",
      (object) num,
      (object) "@PAYEEGUID",
      (object) this.FinanceCompanyGuid,
      (object) "@CHECKDATE",
      (object) this.CheckDate,
      (object) "@CHECKMEMO",
      (object) checkMemo,
      (object) "@COMMENTS",
      (object) DBNull.Value,
      (object) "@FROMBANKGLACCTID",
      (object) bankGLAccountId
    });
    return DefaultDatabase.ExecuteFunction<int>("CheckDistributionBalance", new object[1]
    {
      (object) num
    }) == 1 ? num : throw new TransactionOutOfBalanceException("An error has occurred while trying to post this receivables transaction. The posting distribution would not balance. To ensure data integrity, this transaction has been rolled back.");
  }

  public bool HasSelectedDetails()
  {
    foreach (FinancedReturnDetail detail in (CollectionBase) this.Details)
    {
      if (detail.Selected)
        return true;
    }
    return false;
  }

  private bool VerifyCheckAmount()
  {
    Decimal num = 0M;
    foreach (FinancedReturnDetail detail in (CollectionBase) this.Details)
      num += detail.Amount;
    return !(num > 0M);
  }

  private bool VerifyZeroAmount()
  {
    Decimal num = 0M;
    foreach (FinancedReturnDetail detail in (CollectionBase) this.Details)
      num += detail.Amount;
    return num == 0M;
  }
}
