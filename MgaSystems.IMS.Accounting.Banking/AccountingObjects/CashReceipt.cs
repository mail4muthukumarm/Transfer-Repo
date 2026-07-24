// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.AccountingObjects.CashReceipt
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Banking.AccountingObjects.Transactions;
using MGASystems.IMS.Accounting.Banking.CustomExceptions;
using MGASystems.IMS.Accounting.Shared;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.AccountingObjects;

internal sealed class CashReceipt : AccountingTransaction
{
  private Decimal _checkAmount;
  private string _checkNumber;
  private DateTime _receivedDate;
  private DateTime _depositDate;

  internal CashReceipt()
  {
  }

  [Obsolete("This constructor is obsolete. Please use a constructor with out the cost center id, Cost center allcoation is handled by the trasnaction entry class.", false)]
  internal CashReceipt(
    Decimal CashReceiptCheckAmount,
    string CashReceiptCheckNumber,
    DateTime CashReceiptReceivedDate,
    DateTime CashReceiptDepositDate,
    int CashReceiptCostCenterId)
  {
    this._checkAmount = CashReceiptCheckAmount;
    this._checkNumber = CashReceiptCheckNumber;
    this._receivedDate = CashReceiptReceivedDate;
    this._depositDate = CashReceiptDepositDate;
  }

  internal CashReceipt(
    Decimal CashReceiptCheckAmount,
    string CashReceiptCheckNumber,
    DateTime CashReceiptReceivedDate,
    DateTime CashReceiptDepositDate)
  {
    this._checkAmount = CashReceiptCheckAmount;
    this._checkNumber = CashReceiptCheckNumber;
    this._receivedDate = CashReceiptReceivedDate;
    this._depositDate = CashReceiptDepositDate;
  }

  internal Decimal CheckAmount
  {
    get => this._checkAmount;
    set => this._checkAmount = value;
  }

  internal string CheckNumber
  {
    get => this._checkNumber;
    set => this._checkNumber = value;
  }

  internal DateTime ReceivedDate
  {
    get => this._receivedDate;
    set => this._receivedDate = value;
  }

  internal DateTime DepositDate
  {
    get => this._depositDate;
    set => this._depositDate = value;
  }

  internal override void PostTransaction()
  {
    SqlCommand cmd = new SqlCommand("spFin_PostJournalTransaction_Header", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand = cmd;
      cmd.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@transactNum", (object) SqlDbType.Int);
      sqlCommand.Parameters["@transactNum"].Direction = ParameterDirection.Output;
      sqlCommand.Parameters.AddWithValue("@postDate", (object) this.TransactionDate);
      sqlCommand.Parameters.AddWithValue("@transDescId", (object) "A");
      sqlCommand.Parameters.AddWithValue("@journalEntryType", (object) "O");
      sqlCommand.Parameters.AddWithValue("@comments", (object) "");
      sqlCommand.Parameters.AddWithValue("@userGuid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand.Connection.Open();
      sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
      sqlCommand.ExecuteNonQuery();
      int integer = Conversions.ToInteger(sqlCommand.Parameters["@transactNum"].Value);
      this.mTransactionId = integer;
      this.PostTransactionDetail(cmd, integer);
      this.PostRemitterJournal(cmd, integer);
      sqlCommand.CommandType = CommandType.Text;
      sqlCommand.CommandText = $"Select dbo.CheckDistributionBalance({integer})";
      sqlCommand.Parameters.Clear();
      if (Conversions.ToInteger(sqlCommand.ExecuteScalar()) != 1)
      {
        sqlCommand.Transaction.Rollback();
        int num = (int) MessageBox.Show("An error has occurred while trying to post this payables transaction. The posting distribution would not balance. To ensure data integrity this transaction has been rolled back.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
        sqlCommand.Transaction.Commit();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (cmd.Transaction != null)
        cmd.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (cmd != null)
      {
        if (cmd.Transaction != null)
        {
          cmd.Transaction.Dispose();
          cmd.Transaction = (SqlTransaction) null;
        }
        if (cmd.Connection != null)
        {
          cmd.Connection.Close();
          cmd.Connection.Dispose();
          cmd.Connection = (SqlConnection) null;
        }
        cmd.Dispose();
      }
    }
  }

  internal void PostTransaction(
    int DepositBankGLAccountId,
    CashReceipt.CashReceiptDepositType DepositType,
    int DepositId = 0)
  {
    if (DepositType == CashReceipt.CashReceiptDepositType.ExistingDepositTicket && DepositId == 0)
      throw new InvalidArgumentException("You have chosen to add this cash receipt to an existing deposit ticket, but you ave not specified the deposit ticket ID.");
    SqlCommand cmd = new SqlCommand("spFin_PostJournalTransaction_Header", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand = cmd;
      cmd.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@transactNum", (object) SqlDbType.Int);
      sqlCommand.Parameters["@transactNum"].Direction = ParameterDirection.Output;
      sqlCommand.Parameters.AddWithValue("@postDate", (object) this.TransactionDate);
      sqlCommand.Parameters.AddWithValue("@transDescId", (object) "A");
      sqlCommand.Parameters.AddWithValue("@journalEntryType", (object) "O");
      sqlCommand.Parameters.AddWithValue("@comments", (object) this.Comments);
      sqlCommand.Parameters.AddWithValue("@userGuid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand.Connection.Open();
      sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
      sqlCommand.ExecuteNonQuery();
      int integer = Conversions.ToInteger(sqlCommand.Parameters["@transactNum"].Value);
      this.mTransactionId = integer;
      this.PostTransactionDetail(cmd, integer);
      this.PostRemitterJournal(cmd, integer);
      sqlCommand.CommandType = CommandType.Text;
      sqlCommand.CommandText = $"Select dbo.CheckDistributionBalance({integer})";
      sqlCommand.Parameters.Clear();
      if (Conversions.ToInteger(sqlCommand.ExecuteScalar()) != 1)
      {
        sqlCommand.Transaction.Rollback();
        int num = (int) MessageBox.Show("An error has occurred while trying to post this payables transaction. The posting distribution would not balance. To ensure data integrity this transaction has been rolled back.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        try
        {
          switch (DepositType)
          {
            case CashReceipt.CashReceiptDepositType.NewDepositTicket:
              BankDeposit.CreateSingleCashReceiptDeposit(cmd, this.TransactionDate, DepositBankGLAccountId, "", this.TransactionId, this.CheckAmount);
              break;
            case CashReceipt.CashReceiptDepositType.ExistingDepositTicket:
              BankDeposit.InsertCashReceiptIntoDepositTicket(cmd, DepositId, this.TransactionId, this.CheckAmount);
              break;
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          sqlCommand.Transaction.Rollback();
          throw;
        }
        sqlCommand.Transaction.Commit();
      }
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (cmd.Transaction != null)
        cmd.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (cmd != null)
      {
        if (cmd.Transaction != null)
        {
          cmd.Transaction.Dispose();
          cmd.Transaction = (SqlTransaction) null;
        }
        if (cmd.Connection != null)
        {
          cmd.Connection.Close();
          cmd.Connection.Dispose();
          cmd.Connection = (SqlConnection) null;
        }
        cmd.Dispose();
      }
    }
  }

  private void PostTransactionDetail(SqlCommand cmd, int transactNum)
  {
    SqlCommand sqlCommand = cmd;
    sqlCommand.CommandText = "spFin_PostJournalTransaction_DetailSingle";
    sqlCommand.CommandType = CommandType.StoredProcedure;
    IEnumerator enumerator1;
    try
    {
      enumerator1 = this.Debits.GetEnumerator();
      while (enumerator1.MoveNext())
      {
        TransactionEntry current = (TransactionEntry) enumerator1.Current;
        sqlCommand.Parameters.Clear();
        sqlCommand.CommandText = "spFin_PostJournalTransaction_DetailSingle";
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@transactNum", (object) transactNum);
        sqlCommand.Parameters.AddWithValue("@GlAcct", (object) current.GLAccount);
        sqlCommand.Parameters.AddWithValue("@amount", (object) current.Amount);
        sqlCommand.Parameters.AddWithValue("@sourceDocType", (object) "J");
        if (current.ExchangeFrom != -1)
          sqlCommand.Parameters.AddWithValue("@exchangeFrom", (object) current.ExchangeFrom);
        int PostingNumber = int.Parse(sqlCommand.ExecuteScalar().ToString());
        try
        {
          foreach (CostCenterAllocation centerAllocation in (CollectionBase) current.CostCenterAllocations)
            centerAllocation.Save(cmd, PostingNumber, false);
        }
        finally
        {
          IEnumerator enumerator2;
          if (enumerator2 is IDisposable)
            (enumerator2 as IDisposable).Dispose();
        }
      }
    }
    finally
    {
      if (enumerator1 is IDisposable)
        (enumerator1 as IDisposable).Dispose();
    }
    IEnumerator enumerator3;
    try
    {
      enumerator3 = this.Credits.GetEnumerator();
      while (enumerator3.MoveNext())
      {
        TransactionEntry current = (TransactionEntry) enumerator3.Current;
        sqlCommand.Parameters.Clear();
        sqlCommand.CommandText = "spFin_PostJournalTransaction_DetailSingle";
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@transactNum", (object) transactNum);
        sqlCommand.Parameters.AddWithValue("@GlAcct", (object) current.GLAccount);
        sqlCommand.Parameters.AddWithValue("@amount", (object) Decimal.Negate(Math.Abs(current.Amount)));
        sqlCommand.Parameters.AddWithValue("@sourceDocType", (object) "J");
        if (current.ExchangeFrom != -1)
          sqlCommand.Parameters.AddWithValue("@exchangeFrom", (object) current.ExchangeFrom);
        int PostingNumber = int.Parse(sqlCommand.ExecuteScalar().ToString());
        try
        {
          foreach (CostCenterAllocation centerAllocation in (CollectionBase) current.CostCenterAllocations)
            centerAllocation.Save(cmd, PostingNumber, true);
        }
        finally
        {
          IEnumerator enumerator4;
          if (enumerator4 is IDisposable)
            (enumerator4 as IDisposable).Dispose();
        }
      }
    }
    finally
    {
      if (enumerator3 is IDisposable)
        (enumerator3 as IDisposable).Dispose();
    }
  }

  private void PostRemitterJournal(SqlCommand cmd, int transactNum)
  {
    SqlCommand sqlCommand = cmd;
    sqlCommand.CommandText = "spFin_PostRemitterJournal";
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.Parameters.Clear();
    sqlCommand.Parameters.AddWithValue("@TransNum", (object) transactNum);
    sqlCommand.Parameters.AddWithValue("@RemitterGUID", (object) this.TransactionEntityGuid);
    sqlCommand.Parameters.AddWithValue("@RecDate", (object) this.ReceivedDate);
    sqlCommand.Parameters.AddWithValue("@DepDate", (object) this.DepositDate);
    sqlCommand.Parameters.AddWithValue("@CheckNum", (object) this.CheckNumber);
    sqlCommand.Parameters.AddWithValue("@Amt", (object) this.CheckAmount);
    sqlCommand.Parameters.AddWithValue("@Cmts", (object) this.Comments);
    sqlCommand.ExecuteNonQuery();
  }

  public enum CashReceiptDepositType
  {
    NewDepositTicket,
    ExistingDepositTicket,
  }
}
