// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.ReceivableTransaction
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Exceptions;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

public class ReceivableTransaction(Guid UserGuid, int glCompanyId) : InsuranceTransaction(UserGuid, Utility.AccountingTransactionType.Receivable, glCompanyId)
{
  public override void Save()
  {
    using (SqlCommand cmd = new SqlCommand())
    {
      try
      {
        cmd.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
        cmd.CommandTimeout = 300;
        cmd.Connection.Open();
        cmd.Transaction = cmd.Connection.BeginTransaction();
        this.SaveHeader(cmd);
        if (this.FinancedReceivables.HasSelectedReturns())
        {
          foreach (FinancedReturn financedReceivable in (CollectionBase) this.FinancedReceivables)
          {
            if (financedReceivable.HasSelectedDetails())
              this.TransactionsCreated.Add((object) financedReceivable.Save(cmd, this.TransactionNumber, this.CheckData.CheckMemo, financedReceivable.FinanceCompanyGuid, this.CheckData.BankGlAccount.GLAccountID, this.PaymentMethodChar));
          }
        }
        cmd.Transaction.Commit();
      }
      catch
      {
        cmd.Transaction.Rollback();
        throw;
      }
    }
  }

  private void SaveHeader(SqlCommand cmd)
  {
    int num1 = 0;
    cmd.CommandText = "spFin_PostReceivablesHeader";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@userguid", (object) this.UserGuid);
    cmd.Parameters.AddWithValue("@comments", (object) this.TransactionComments);
    cmd.Parameters.AddWithValue("@remitterguid", (object) this.RemitterGuid);
    cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GlCompanyId);
    if (!this.IsReturnPremium)
    {
      cmd.Parameters.AddWithValue("@receiveddate", (object) this.ReceivedDate);
      cmd.Parameters.AddWithValue("@depositdate", (object) this.DepositDate);
    }
    else
      cmd.Parameters.AddWithValue("@checkDate", (object) this.CheckDate);
    if (this.CheckNumber != null && !this.CheckNumber.Equals(string.Empty))
      cmd.Parameters.AddWithValue("@checknumber", (object) this.CheckNumber);
    cmd.Parameters.AddWithValue("@amount", (object) this.CheckAmount);
    cmd.Parameters.AddWithValue("@refund", (object) this.IsReturnPremium);
    if (!this.ReceivedFromGuid.Equals(Guid.Empty))
      cmd.Parameters.AddWithValue("@remittedFrom", (object) this.ReceivedFromGuid);
    try
    {
      num1 = int.Parse(cmd.ExecuteScalar().ToString());
      if (this.Debits.Count != 0 && this.Credits.Count != 0)
        this.TransactionsCreated.Add((object) num1);
      this.SetTransactionNumber(num1);
    }
    catch (SqlException ex)
    {
      if (ex.Number != 50000 || ex.State != (byte) 1)
        throw ex;
      int num2 = (int) MessageBox.Show(ex.Errors[0].Message);
    }
    this.SaveDebits(cmd, num1);
    this.SaveCredits(cmd, num1);
    if (this.IsReturnPremium && this.Debits.Count != 0 && this.Credits.Count != 0)
      this.CreateCheckPosting(cmd, num1, this.CheckData);
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_ExecutePropIncome";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@transactnum", (object) num1);
    cmd.Parameters.AddWithValue("@rollupto", (object) "A/R");
    cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GlCompanyId);
    cmd.ExecuteNonQuery();
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_PostCommissionableFees";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@transactnum", (object) num1);
    cmd.Parameters.AddWithValue("@transtype", (object) "AR");
    cmd.Parameters.AddWithValue("@glcompanyid", (object) this.GlCompanyId);
    if (!this.IsReturnPremium)
      cmd.Parameters.AddWithValue("@postDate", (object) this.DepositDate);
    else
      cmd.Parameters.AddWithValue("@postDate", (object) this.CheckDate);
    cmd.ExecuteNonQuery();
    cmd.CommandType = CommandType.Text;
    cmd.CommandText = $"Select dbo.CheckDistributionBalance({num1})";
    cmd.Parameters.Clear();
    if (int.Parse(cmd.ExecuteScalar().ToString()) != 1)
      throw new TransactionOutOfBalanceException("An error has occurred while trying to post this receivables transaction. The posting distribution would not balance. To ensure data integrity this transaction has been rolled back.");
    Messaging.SendBroadcastMessage(Utility.RemittancePosted, (object) this.Debits.PostedInvoiceList().ToArray(typeof (int)));
  }
}
