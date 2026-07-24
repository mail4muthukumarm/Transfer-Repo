// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Services.BankingServices
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Services;

public class BankingServices
{
  protected const int CommandTimeout = 300;

  [Obsolete("This method is obselete. Please use the over loaded method with debit and credit cost centers", false)]
  internal static void PostBankFees(
    int BankGLAccountNumber,
    int FeesGLAccountNumber,
    Decimal TransactionAmount,
    DateTime postDate)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_PostBankFees", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@bankglacct", (object) BankGLAccountNumber);
      sqlCommand2.Parameters.AddWithValue("@feesglacct", (object) FeesGLAccountNumber);
      sqlCommand2.Parameters.AddWithValue("@amount", (object) TransactionAmount);
      sqlCommand2.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand2.Parameters.AddWithValue("@postDate", (object) postDate);
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.Transaction.Commit();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          if (sqlCommand1.Connection.State != ConnectionState.Closed)
            sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  internal static void PostBankFees(
    int BankGLAccountNumber,
    int FeesGLAccountNumber,
    Decimal TransactionAmount,
    DateTime postDate,
    int debitCostCenter,
    int creditCostCenter)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_PostBankFees", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@bankglacct", (object) BankGLAccountNumber);
      sqlCommand2.Parameters.AddWithValue("@feesglacct", (object) FeesGLAccountNumber);
      sqlCommand2.Parameters.AddWithValue("@amount", (object) TransactionAmount);
      sqlCommand2.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand2.Parameters.AddWithValue("@postDate", (object) postDate);
      sqlCommand2.Parameters.AddWithValue("@debitCostCenter", (object) debitCostCenter);
      sqlCommand2.Parameters.AddWithValue("@CreditCostCenter", (object) creditCostCenter);
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.Transaction.Commit();
      CurrentUser.Instance.LogAction($"Posted bank fees to bank GL account # {BankGLAccountNumber}", "Banking Logs");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          if (sqlCommand1.Connection.State != ConnectionState.Closed)
            sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  [Obsolete("This method is obselete. Please use the over loaded method with debit and credit cost centers", false)]
  internal static void PostBankInterestIncome(
    int BankGLAccountNumber,
    int InterestIncomeAccountNumber,
    Decimal TransactionAmount,
    DateTime postDate)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_PostAccruedInterest", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@bankglacct", (object) BankGLAccountNumber);
      sqlCommand2.Parameters.AddWithValue("@interestGL", (object) InterestIncomeAccountNumber);
      sqlCommand2.Parameters.AddWithValue("@amount", (object) TransactionAmount);
      sqlCommand2.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand2.Parameters.AddWithValue("@postDate", (object) postDate);
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.Transaction.Commit();
      CurrentUser.Instance.LogAction($"Posted bank interest income to bank GL account # {BankGLAccountNumber}", "Banking Logs");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          if (sqlCommand1.Connection.State != ConnectionState.Closed)
            sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  internal static void PostBankInterestIncome(
    int BankGLAccountNumber,
    int InterestIncomeAccountNumber,
    Decimal TransactionAmount,
    DateTime postDate,
    int debitCostCenter,
    int creditCostCenter)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_PostAccruedInterest", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@bankglacct", (object) BankGLAccountNumber);
      sqlCommand2.Parameters.AddWithValue("@interestGL", (object) InterestIncomeAccountNumber);
      sqlCommand2.Parameters.AddWithValue("@amount", (object) TransactionAmount);
      sqlCommand2.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand2.Parameters.AddWithValue("@postDate", (object) postDate);
      sqlCommand2.Parameters.AddWithValue("@debitCostCenter", (object) debitCostCenter);
      sqlCommand2.Parameters.AddWithValue("@CreditCostCenter", (object) creditCostCenter);
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.Transaction.Commit();
      CurrentUser.Instance.LogAction($"Posted bank interest income to bank GL account # {BankGLAccountNumber}", "Banking Logs");
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          if (sqlCommand1.Connection.State != ConnectionState.Closed)
            sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  internal static int GetBankFeesAccount(int BankGLAccountNumber)
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "select dbo.GetBankFeesGLAcct(@bankacctnum)", new object[2]
    {
      (object) "@bankacctnum",
      (object) BankGLAccountNumber
    });
  }

  internal static int GetBankInterestAccount(int BankGLAccountNumber)
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "select dbo.GetBankInterestGLAcct(@bankacctnum)", new object[2]
    {
      (object) "@bankacctnum",
      (object) BankGLAccountNumber
    });
  }

  internal static string GetBankName(int BankGLAccountNumber)
  {
    return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select dbo.getbankname(@bankacctnum)", new object[2]
    {
      (object) "@bankacctnum",
      (object) BankGLAccountNumber
    });
  }

  internal static Decimal GetBankStartingBalance(int bankGLAccount)
  {
    return DefaultDatabase.ExecuteScalar<Decimal>("spFin_GetBankStartingBalance", new object[2]
    {
      (object) "@bankGLAccount",
      (object) bankGLAccount
    });
  }

  internal static DateTime GetBankStartingBalanceDate(int BankGLAccount)
  {
    return DefaultDatabase.ExecuteScalar<DateTime>("spFin_GetBankStartingBalanceDate", new object[2]
    {
      (object) "@bankGLAccount",
      (object) BankGLAccount
    });
  }

  internal static string GetBankAccountAddress(int BankGLAccountID)
  {
    return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select dbo.GetBankAddress(@bankacctid)", new object[2]
    {
      (object) "@bankacctid",
      (object) BankGLAccountID
    });
  }

  internal static string GetBankAccountNumber(int BankGLAccountID)
  {
    return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select bankacctnum from tblfin_bankaccounts where glacctid = @bankacctid", new object[2]
    {
      (object) "@bankacctid",
      (object) BankGLAccountID
    });
  }

  internal static int GetBankGLCompanyID(int GLAccountID)
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "select dbo.GetGLCompanyID(@glcompanyid)", new object[2]
    {
      (object) "@glcompanyid",
      (object) GLAccountID
    });
  }

  internal static void ReconciledCheck(int TransactionNumber)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_ReconcileCheck", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@transactnum", (object) TransactionNumber);
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.Transaction.Commit();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          if (sqlCommand1.Connection.State != ConnectionState.Closed)
            sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  internal static void ReconcileDeposit(int DepositId)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_ReconcileDeposit", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@depositId", (object) DepositId);
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.Transaction.Commit();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          if (sqlCommand1.Connection.State != ConnectionState.Closed)
            sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  public static int BounceCheck(int TransactionNumber, DateTime TransactionDate)
  {
    int num;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (s, e) =>
    {
      try
      {
        DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "dbo.spFin_BounceCheck", 300, (CommandArgumentType) 0, new List<object>()
        {
          (object) "@TRANSACTNUM_VOIDEE",
          (object) TransactionNumber,
          (object) "@USERGUID",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@TRANSACTIONDATE",
          (object) TransactionDate
        }.ToArray());
        CurrentUser.Instance.LogAction($"Bounced check transaction # {TransactionNumber}", "Banking Logs");
        num = ExtensionsMethods.FieldAs<int>(dataTable.Rows[0], "TransactNum", DataRowVersion.Current);
        e.Transaction.Commit();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        throw;
      }
    }));
    return num;
  }

  internal static void UnGroupDeposit(int DepositID)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_UngroupDeposit", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@depositid", (object) DepositID);
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.ExecuteNonQuery();
      sqlCommand2.Transaction.Commit();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          if (sqlCommand1.Connection.State != ConnectionState.Closed)
            sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  internal static int TransferFunds(
    int SourceGLAccount,
    int DestinationGLAccount,
    DateTime TransactionDate,
    Decimal TransactionAmount,
    string Comments,
    Guid UserGuid)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_BankTransfer", new SqlConnection(CurrentUser.Instance.ConnectionString));
    SqlCommand sqlCommand2 = sqlCommand1;
    sqlCommand2.CommandType = CommandType.StoredProcedure;
    sqlCommand2.Parameters.AddWithValue("@journalentrytype", (object) "I");
    sqlCommand2.Parameters.AddWithValue("@comments", (object) Comments);
    sqlCommand2.Parameters.AddWithValue("@userguid", (object) UserGuid);
    sqlCommand2.Parameters.AddWithValue("@fromglacctid", (object) SourceGLAccount);
    sqlCommand2.Parameters.AddWithValue("@toglacctid", (object) DestinationGLAccount);
    sqlCommand2.Parameters.AddWithValue("@amount", (object) TransactionAmount);
    sqlCommand2.Parameters.AddWithValue("@paymethodid", (object) "M");
    sqlCommand2.Parameters.AddWithValue("@transactionDate", (object) TransactionDate);
    int num;
    try
    {
      sqlCommand1.Connection.Open();
      sqlCommand1.Transaction = sqlCommand1.Connection.BeginTransaction();
      int integer = Conversions.ToInteger(sqlCommand1.ExecuteScalar());
      sqlCommand1.Transaction.Commit();
      CurrentUser.Instance.LogAction($"Bank transfer from {SourceGLAccount} bank GL Account to {DestinationGLAccount} bank GL Account", "Banking Logs");
      num = integer;
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      sqlCommand1?.Transaction?.Rollback();
      sqlCommand1?.Connection?.Close();
      ErrorHandler.HandleError(ex2);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          if (sqlCommand1.Connection.State != ConnectionState.Closed)
            sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
    return num;
  }

  internal static int TransferFunds(
    int SourceGLAccount,
    int DestinationGLAccount,
    DateTime TransactionDate,
    Decimal TransactionAmount,
    string Comments,
    Guid UserGuid,
    int creditCostCenter,
    int debitCostCenter)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_BankTransfer", new SqlConnection(CurrentUser.Instance.ConnectionString));
    SqlCommand sqlCommand2 = sqlCommand1;
    sqlCommand2.CommandType = CommandType.StoredProcedure;
    sqlCommand2.Parameters.AddWithValue("@journalentrytype", (object) "I");
    sqlCommand2.Parameters.AddWithValue("@comments", (object) Comments);
    sqlCommand2.Parameters.AddWithValue("@userguid", (object) UserGuid);
    sqlCommand2.Parameters.AddWithValue("@fromglacctid", (object) SourceGLAccount);
    sqlCommand2.Parameters.AddWithValue("@toglacctid", (object) DestinationGLAccount);
    sqlCommand2.Parameters.AddWithValue("@amount", (object) TransactionAmount);
    sqlCommand2.Parameters.AddWithValue("@paymethodid", (object) "M");
    sqlCommand2.Parameters.AddWithValue("@transactionDate", (object) TransactionDate);
    sqlCommand2.Parameters.AddWithValue("@debitCostCenterId", (object) debitCostCenter);
    sqlCommand2.Parameters.AddWithValue("@creditCostCenterId", (object) creditCostCenter);
    try
    {
      sqlCommand1.Connection.Open();
      sqlCommand1.Transaction = sqlCommand1.Connection.BeginTransaction();
      int integer = Conversions.ToInteger(sqlCommand1.ExecuteScalar());
      sqlCommand1.Transaction.Commit();
      return integer;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      Exception exception = ex;
      sqlCommand1?.Transaction?.Rollback();
      sqlCommand1?.Connection?.Close();
      throw exception;
    }
    finally
    {
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Dispose();
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          if (sqlCommand1.Connection.State != ConnectionState.Closed)
            sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  public static void UnReconcileTransaction(int transactionID, string transactionType)
  {
    SqlCommand sqlCommand = new SqlCommand("spfin_unreconciletransaction", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@numericID", (object) transactionID);
      sqlCommand.Parameters.AddWithValue("@transactionType", (object) transactionType);
      sqlCommand.Connection.Open();
      sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
      sqlCommand.ExecuteNonQuery();
      sqlCommand.Transaction.Commit();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SqlException sqlException = ex;
      sqlCommand.Transaction.Rollback();
      throw sqlException;
    }
    finally
    {
      if (sqlCommand != null)
      {
        if (sqlCommand.Connection != null)
        {
          if (sqlCommand.Connection.State != ConnectionState.Closed)
            sqlCommand.Connection.Close();
          sqlCommand.Connection.Dispose();
          sqlCommand.Connection = (SqlConnection) null;
        }
        sqlCommand.Dispose();
      }
    }
  }

  public static void UnReconcileTransaction(
    int transactionID,
    string transactionType,
    int BankGLAcct)
  {
    SqlCommand sqlCommand = new SqlCommand("spfin_unreconciletransaction", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@TransactionId", (object) transactionID);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(transactionType, "D", false) == 0)
        sqlCommand.Parameters.AddWithValue("@isDeposit", (object) 1);
      else
        sqlCommand.Parameters.AddWithValue("@isDeposit", (object) 0);
      sqlCommand.Parameters.AddWithValue("@bankGLAcct", (object) BankGLAcct);
      sqlCommand.Connection.Open();
      sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
      sqlCommand.ExecuteNonQuery();
      CurrentUser.Instance.LogAction(string.Format("Un-reconciled bank transaction {0}.", (object) transactionID, (object) transactionID));
      sqlCommand.Transaction.Commit();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      SqlException sqlException = ex;
      sqlCommand.Transaction.Rollback();
      throw sqlException;
    }
    finally
    {
      if (sqlCommand != null)
      {
        if (sqlCommand.Connection != null)
        {
          if (sqlCommand.Connection.State != ConnectionState.Closed)
            sqlCommand.Connection.Close();
          sqlCommand.Connection.Dispose();
          sqlCommand.Connection = (SqlConnection) null;
        }
        sqlCommand.Dispose();
      }
    }
  }
}
