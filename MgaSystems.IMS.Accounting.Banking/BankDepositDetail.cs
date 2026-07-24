// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.BankDepositDetail
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.Banking.CustomExceptions;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

internal sealed class BankDepositDetail
{
  private int _depositId;
  private Guid _remitterGuid;
  private string _remitterName;
  private DateTime _postDate;
  private Decimal _checkAmount;
  private int _transactNum;
  private bool _voided;
  private string _checkNumber;
  private string _checkComments;

  public int DepositID
  {
    get => this._depositId;
    set => this._depositId = value;
  }

  public int transactionNumber => this._transactNum;

  public Guid RemitterGuid => this._remitterGuid;

  public string RemitterName
  {
    get
    {
      string remitterName;
      if (this._remitterGuid.Equals(Guid.Empty))
      {
        this._remitterName = "";
        remitterName = "";
      }
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._remitterName, "", false) != 0)
      {
        remitterName = this._remitterName;
      }
      else
      {
        this._remitterName = this.GetRemitterName();
        remitterName = this._remitterName;
      }
      return remitterName;
    }
  }

  public DateTime PostDate => this._postDate;

  public Decimal CheckAmount => this._checkAmount;

  public bool IsVoided => this._voided;

  public string PostingComments => this._checkComments;

  public string CheckNumber => this._checkNumber;

  internal event BankDepositDetail.BankDepositUpdatedEventDelegate BankDepositUpdated;

  public BankDepositDetail()
  {
  }

  public BankDepositDetail(int transactionNumber) => this.LoadTransaction(transactionNumber);

  private string GetRemitterName()
  {
    if (this._remitterGuid.Equals(Guid.Empty))
      return "";
    SqlCommand sqlCommand1 = new SqlCommand($"Select dbo.GetEntityName('{this._remitterGuid.ToString()}')", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.Text;
      sqlCommand2.Connection.Open();
      return Conversions.ToString(sqlCommand2.ExecuteScalar());
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      throw new GetRemitterNameException(ex.Errors[0].Message);
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

  public void LoadTransaction(int transactionNumber)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_GetTransactionForBankDeposit", new SqlConnection(CurrentUser.Instance.ConnectionString));
    SqlDataReader sqlDataReader = (SqlDataReader) null;
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@trxNum", (object) transactionNumber);
      sqlCommand2.Connection.Open();
      sqlDataReader = sqlCommand2.ExecuteReader(CommandBehavior.CloseConnection);
      if (sqlDataReader.Read())
      {
        this._remitterGuid = new Guid(sqlDataReader["remitterGuid"].ToString());
        this._postDate = Conversions.ToDate(sqlDataReader["postDate"]);
        this._checkAmount = Conversions.ToDecimal(sqlDataReader["checkAmount"]);
        this._transactNum = transactionNumber;
        this._voided = Conversions.ToInteger(sqlDataReader["voided"]) == 1;
        this._checkNumber = Conversions.ToString(sqlDataReader["checkNumber"]);
        this._checkComments = Conversions.ToString(sqlDataReader["comments"]);
      }
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      throw new GetRemitterNameException(ex.Errors[0].Message);
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
      if (sqlDataReader != null)
      {
        if (!sqlDataReader.IsClosed)
          sqlDataReader.Close();
      }
    }
  }

  [Browsable(false)]
  [EditorBrowsable(EditorBrowsableState.Never)]
  internal delegate void BankDepositUpdatedEventDelegate(object sender, EventArgs e);
}
