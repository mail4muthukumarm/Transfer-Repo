// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.PayableTransaction
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class PayableTransaction : InsuranceTransaction
{
  private bool createCheck;
  private bool createRemittance;

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

  public PayableTransaction(Guid UserGuid)
    : base(UserGuid, Utility.AccountingTransactionType.Payable)
  {
    this.createCheck = true;
    this.createRemittance = false;
  }

  public PayableTransaction(Guid UserGuid, bool CreateCheck, bool CreateRemittance)
    : base(UserGuid, Utility.AccountingTransactionType.Payable)
  {
    this.createCheck = CreateCheck;
    this.createRemittance = CreateRemittance;
  }

  public PayableTransaction(
    Guid UserGuid,
    bool CreateCheck,
    bool CreateRemittance,
    CheckInformation CheckData)
    : base(UserGuid, Utility.AccountingTransactionType.Payable)
  {
    this.createCheck = CreateCheck;
    this.createRemittance = CreateRemittance;
    this.CheckData = CheckData;
  }

  public PayableTransaction(Guid UserGuid, int glCompanyId)
    : base(UserGuid, Utility.AccountingTransactionType.Payable, glCompanyId)
  {
    this.createCheck = true;
    this.createRemittance = false;
  }

  public PayableTransaction(
    Guid UserGuid,
    bool CreateCheck,
    bool CreateRemittance,
    int glCompanyId)
    : base(UserGuid, Utility.AccountingTransactionType.Payable, glCompanyId)
  {
    this.createCheck = CreateCheck;
    this.createRemittance = CreateRemittance;
  }

  public PayableTransaction(
    Guid UserGuid,
    bool CreateCheck,
    bool CreateRemittance,
    CheckInformation CheckData,
    int glCompanyId)
    : base(UserGuid, Utility.AccountingTransactionType.Payable, glCompanyId)
  {
    this.createCheck = CreateCheck;
    this.createRemittance = CreateRemittance;
    this.CheckData = CheckData;
  }

  public override void Save()
  {
    using (SqlCommand cmd = new SqlCommand())
    {
      try
      {
        cmd.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
        cmd.Connection.Open();
        cmd.Transaction = cmd.Connection.BeginTransaction();
        this.SaveHeader(cmd, this.GlCompanyId);
        cmd.Transaction.Commit();
        CurrentUser.Instance.LogAction($"Posted transaction #{this.TransactionNumber}", "Accounting Logs");
      }
      catch
      {
        if (cmd.Transaction != null)
          cmd.Transaction.Rollback();
        throw;
      }
    }
  }

  public int Save(SqlCommand cmd, int GlCompanyId) => this.SaveHeader(cmd, GlCompanyId);

  private int SaveHeader(SqlCommand cmd, int GlCompanyId)
  {
    int num1 = 0;
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@comments", (object) this.TransactionComments);
    cmd.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
    if (!this.IsReturnPremium)
    {
      cmd.CommandText = "spFin_PostPayables_Journal";
      cmd.Parameters.AddWithValue("@postdate", (object) this.CheckDate);
    }
    else
    {
      cmd.CommandText = "spFin_InsertPayablesRefundHeader";
      cmd.Parameters.AddWithValue("@postdate", (object) this.DepositDate);
      cmd.Parameters.AddWithValue("@payeeguid", (object) this.PayeeGuid);
      cmd.Parameters.AddWithValue("@checkamount", (object) this.CheckAmount);
      cmd.Parameters.AddWithValue("@checknumber", (object) this.CheckNumber);
      cmd.Parameters.AddWithValue("@receiveddate", (object) this.ReceivedDate);
      cmd.Parameters.AddWithValue("@depositdate", (object) this.DepositDate);
    }
    int num2 = int.Parse(cmd.ExecuteScalar().ToString());
    this.SetTransactionNumber(num2);
    this.SaveDebits(cmd, num2);
    this.SaveCredits(cmd, num2);
    if (!this.IsReturnPremium)
      num1 = this.CreateCheckPosting(cmd, num2, this.CheckData);
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_ExecutePropIncome";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@transactnum", (object) num2);
    cmd.Parameters.AddWithValue("@rollupto", (object) "A/P");
    cmd.Parameters.AddWithValue("@glcompanyid", (object) GlCompanyId);
    cmd.ExecuteNonQuery();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_PostCommissionableFees";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@transactnum", (object) num2);
    cmd.Parameters.AddWithValue("@transtype", (object) "AP");
    cmd.Parameters.AddWithValue("@glcompanyid", (object) GlCompanyId);
    cmd.Parameters.AddWithValue("@postDate", (object) (this.IsReturnPremium ? this.DepositDate : this.CheckDate));
    cmd.ExecuteNonQuery();
    cmd.CommandType = CommandType.Text;
    cmd.CommandText = $"Select dbo.CheckDistributionBalance({num2})";
    cmd.Parameters.Clear();
    if (int.Parse(cmd.ExecuteScalar().ToString()) != 1)
      throw new TransactionOutOfBalanceException("An error has occurred while trying to post this payables transaction. The posting distribution would not balance. To ensure data integrity this transaction has been rolled back.");
    return num1;
  }

  private void SaveRemitterJournal(SqlCommand cmd, int TransactionNumber)
  {
  }
}
