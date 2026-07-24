// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.BankDeposit
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Banking.CustomExceptions;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class BankDeposit
{
  private int _depositId;
  private DateTime _depositDate;
  private Guid _userGuid;
  private int _bankglaccountid;
  private string _depositReference;
  private bool _reconciled;
  private DateTime _reconcileDate;
  private BankDepositDetails _depositDetails;

  internal int DepositId => this._depositId;

  internal DateTime DepositDate
  {
    get => this._depositDate;
    set => this._depositDate = value;
  }

  internal int BankGLAccountID
  {
    get => this._bankglaccountid;
    set => this._bankglaccountid = value;
  }

  internal string DepositReference
  {
    get => this._depositReference;
    set => this._depositReference = value;
  }

  internal Guid UserGuid => this._userGuid;

  internal bool Reconciled => this._reconciled;

  internal DateTime ReconcileDate => this._reconcileDate;

  internal BankDepositDetails DepositDetails
  {
    get
    {
      if (this._depositDetails == null)
        this._depositDetails = new BankDepositDetails();
      return this._depositDetails;
    }
  }

  internal BankDeposit()
  {
  }

  internal BankDeposit(int DepositID)
  {
    this._depositId = DepositID;
    this.LoadBankDeposit();
  }

  internal BankDeposit(
    DateTime DepositDate,
    Guid UserGuid,
    string DepositReference,
    params BankDepositDetail[] DepositDetailObjects)
  {
    this._depositDate = DepositDate;
    this._userGuid = UserGuid;
    this._depositReference = DepositReference;
    BankDepositDetail[] bankDepositDetailArray = DepositDetailObjects;
    int index = 0;
    while (index < bankDepositDetailArray.Length)
    {
      BankDepositDetail BankDepositDetail = bankDepositDetailArray[index];
      this.DepositDetails.AddBankDepositDetail(BankDepositDetail.transactionNumber.ToString(), BankDepositDetail);
      checked { ++index; }
    }
  }

  private void LoadBankDeposit()
  {
    this.LoadDepositHeader(this.DepositId);
    this.LoadDepositDetail(this.DepositId);
  }

  private void LoadDepositHeader(int DepositID)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_GeBankDepositHeader", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@depositid", (object) DepositID);
      sqlCommand2.Connection.Open();
      SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader(CommandBehavior.CloseConnection);
      this._depositDate = sqlDataReader.Read() ? Conversions.ToDate(sqlDataReader["depositDate"]) : throw new BankDepositIdNotFoundException($"The system could not find the deposit information for deposit id {DepositID}");
      this._userGuid = new Guid(sqlDataReader["userguid"].ToString());
      this._bankglaccountid = Conversions.ToInteger(sqlDataReader["bankgl"]);
      this._depositReference = sqlDataReader["depositreference"].ToString();
      this._reconciled = Conversions.ToBoolean(sqlDataReader["recociled"]);
      if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader["reconiledDate"])))
        this._reconcileDate = Conversions.ToDate(sqlDataReader["reconciledDate"]);
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      throw new LoadBankDepositException(ex.Errors[0].Message);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw new LoadBankDepositException(ex.Message);
    }
    finally
    {
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  private void LoadDepositDetail(int DepositId)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_GetBankDepositDetail", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@depositId", (object) DepositId);
      sqlCommand2.Connection.Open();
      SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader(CommandBehavior.CloseConnection);
      while (sqlDataReader.Read())
        this.DepositDetails.AddBankDepositDetail(Conversions.ToString(this.DepositDetails.Count() + 1), new BankDepositDetail(Conversions.ToInteger(sqlDataReader["transactNum"])));
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      throw new LoadBankDepositException(ex.Errors[0].Message);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw new LoadBankDepositException(ex.Message);
    }
    finally
    {
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  internal static void CreateSingleCashReceiptDeposit(
    DateTime DepositDate,
    int BankGLAccountNumber,
    string DepositReference,
    int TransactionNumber,
    Decimal Amount)
  {
    SqlCommand sqlCommand1 = new SqlCommand("dbo.spFin_AddBankDeposit", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandText = "spFin_AddBankDeposit";
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.Parameters.Clear();
      sqlCommand2.Parameters.AddWithValue("@depositDate", (object) DepositDate);
      sqlCommand2.Parameters.AddWithValue("@userGuid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand2.Parameters.AddWithValue("@bankgl", (object) BankGLAccountNumber);
      sqlCommand2.Parameters.AddWithValue("@depositReference", (object) DepositReference);
      int integer = Conversions.ToInteger(sqlCommand2.ExecuteScalar());
      sqlCommand2.CommandText = "spFin_AddBankDepositDetail";
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.Clear();
      sqlCommand2.Parameters.AddWithValue("@depositId", (object) integer);
      sqlCommand2.Parameters.AddWithValue("@transactNum", (object) TransactionNumber);
      sqlCommand2.Parameters.AddWithValue("@amount", (object) Amount);
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
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  internal static void CreateSingleCashReceiptDeposit(
    SqlCommand cmd,
    DateTime DepositDate,
    int BankGLAccountNumber,
    string DepositReference,
    int TransactionNumber,
    Decimal Amount)
  {
    SqlCommand sqlCommand = cmd;
    sqlCommand.CommandText = "spFin_AddBankDeposit";
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.Parameters.Clear();
    sqlCommand.Parameters.AddWithValue("@depositDate", (object) DepositDate);
    sqlCommand.Parameters.AddWithValue("@userGuid", (object) CurrentUser.Instance.UserGUID);
    sqlCommand.Parameters.AddWithValue("@bankgl", (object) BankGLAccountNumber);
    sqlCommand.Parameters.AddWithValue("@depositReference", (object) DepositReference);
    int integer = Conversions.ToInteger(sqlCommand.ExecuteScalar());
    sqlCommand.CommandText = "spFin_AddBankDepositDetail";
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.Parameters.Clear();
    sqlCommand.Parameters.AddWithValue("@depositId", (object) integer);
    sqlCommand.Parameters.AddWithValue("@transactNum", (object) TransactionNumber);
    sqlCommand.Parameters.AddWithValue("@amount", (object) Amount);
    sqlCommand.ExecuteNonQuery();
  }

  internal static void InsertCashReceiptIntoDepositTicket(
    int DepositID,
    int TransactionNumber,
    Decimal Amount)
  {
    SqlCommand sqlCommand1 = new SqlCommand("dbo.spFin_AddBankDepositDetail", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.Parameters.Clear();
      sqlCommand2.Parameters.AddWithValue("@depositId", (object) DepositID);
      sqlCommand2.Parameters.AddWithValue("@transactNum", (object) TransactionNumber);
      sqlCommand2.Parameters.AddWithValue("@amount", (object) Amount);
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
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  internal static void InsertCashReceiptIntoDepositTicket(
    SqlCommand cmd,
    int DepositID,
    int TransactionNumber,
    Decimal Amount)
  {
    SqlCommand sqlCommand = cmd;
    sqlCommand.CommandText = "spFin_AddBankDepositDetail";
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.Parameters.Clear();
    sqlCommand.Parameters.AddWithValue("@depositId", (object) DepositID);
    sqlCommand.Parameters.AddWithValue("@transactNum", (object) TransactionNumber);
    sqlCommand.Parameters.AddWithValue("@amount", (object) Amount);
    sqlCommand.ExecuteNonQuery();
  }
}
