// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.AccountingObjects.AccountingTransaction
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.Accounting.Banking.AccountingObjects.Transactions;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.AccountingObjects;

[DefaultProperty("TransactionId")]
internal abstract class AccountingTransaction
{
  protected int mTransactionId;
  protected DateTime mTransactionDate;
  protected AccountingTransactionTypes mTransactionType;
  protected TransactionEntries mDebits;
  protected TransactionEntries mCredits;
  protected Guid mTransactionEntityGuid;
  protected string mTransactionComments;
  protected const int CommandTimeout = 300;

  internal int TransactionId => this.mTransactionId;

  internal DateTime TransactionDate
  {
    get => this.mTransactionDate;
    set => this.mTransactionDate = value;
  }

  protected internal AccountingTransactionTypes TransactionType
  {
    get => this.mTransactionType;
    set => this.mTransactionType = value;
  }

  public TransactionEntries Debits
  {
    get
    {
      if (this.mDebits == null)
        this.mDebits = new TransactionEntries();
      return this.mDebits;
    }
  }

  public TransactionEntries Credits
  {
    get
    {
      if (this.mCredits == null)
        this.mCredits = new TransactionEntries();
      return this.mCredits;
    }
  }

  public bool TransactionIsBalanced
  {
    get => Decimal.Compare(this.mCredits.Sum(), this.mDebits.Sum()) == 0;
  }

  internal Guid TransactionEntityGuid
  {
    get => this.mTransactionEntityGuid;
    set => this.mTransactionEntityGuid = value;
  }

  internal string Comments
  {
    get => this.mTransactionComments;
    set => this.mTransactionComments = value;
  }

  protected AccountingTransaction() => this.mTransactionEntityGuid = Guid.Empty;

  internal abstract void PostTransaction();

  internal void VoidTransaction()
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_VoidJournalTransaction", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandTimeout = 300;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@TRANSACTNUM_VOIDEE", (object) this.TransactionId);
      sqlCommand2.Parameters.AddWithValue("@USERGUID", (object) CurrentUser.Instance.UserGUID);
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.CommandText = "spFin_VoidLinkedManualEntries";
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.CommandText = "spFin_VoidAppliedUnAccountedLinkedTransactions";
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.CommandText = "spFin_VoidLinkedCommissionTransactions";
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.CommandText = "spFin_VoidLinkedTransactionReference";
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.Transaction.Commit();
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Rollback();
      sqlCommand1.Connection.Close();
      ErrorHandler.HandleError(ex2);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
      sqlCommand1.Connection.Close();
      sqlCommand1.Connection.Dispose();
      sqlCommand1.Connection = (SqlConnection) null;
      sqlCommand1.Dispose();
    }
  }

  internal void AddDebit(string key, TransactionEntry TransactionEntry)
  {
    this.Debits.AddTransactionEntry(key, TransactionEntry);
  }

  internal Decimal DebitsAmount() => this.Debits.Sum();

  internal int DebitTransactionsCount() => this.Debits.Count();

  internal void AddCredit(string key, TransactionEntry TransactionEntry)
  {
    this.Credits.AddTransactionEntry(key, TransactionEntry);
  }

  internal Decimal CreditsAmount() => this.Credits.Sum();

  internal int CreditTransactionsCount() => this.Credits.Count();
}
