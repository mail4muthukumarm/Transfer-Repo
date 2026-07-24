// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.GLAccount
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Common;
using MGASystems.IMS.Accounting.GeneralLedger.Exceptions;
using System;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;

[Serializable]
public sealed class GLAccount
{
  private int glAccountId;
  private string accountFullName;
  private string accountShortName;
  private bool isControlAccount;
  private int parentGLAccount;
  private string glAccountClassName;
  private Guid linkedEntityGuid;
  private bool isSystemDefined;
  private bool isClosed;
  private int glCompanyId;
  private string glAccountNumber;
  private string linkedEntityName;
  private int rollUpTo;
  private int financialAcctTypeId;
  private string financialAcctTypeName;
  private Decimal currentBalance;
  private string accountNumber;

  private GLAccount()
  {
  }

  public GLAccount(int glAccountId)
  {
    this.glAccountId = glAccountId;
    this.LoadGLAccount();
  }

  public GLAccount(int glAccountId, SqlCommand cmd)
  {
    this.glAccountId = glAccountId;
    this.LoadGLAccount(cmd);
  }

  public int GLAccountID => this.glAccountId;

  public string AccountFullName => this.accountFullName;

  public string AccountShortName => this.accountShortName;

  public bool IsControlAccount => this.isControlAccount;

  public int ParentGLAccount => this.parentGLAccount;

  public string GLAccountClassName => this.glAccountClassName;

  public Guid LinkedEntityGuid => this.linkedEntityGuid;

  public bool IsSystemDefined => this.isSystemDefined;

  public bool IsClosed => this.isClosed;

  public int GLCompanyId => this.glCompanyId;

  public string GlAccountNumber => this.glAccountNumber;

  public string LinkedEntityName => this.linkedEntityName;

  public int RollUpTo => this.rollUpTo;

  public int FinancialAccountTypeId => this.financialAcctTypeId;

  public string FinancialAccountTypeName => this.financialAcctTypeName;

  public string CurrentBalance => this.currentBalance.ToString("c");

  public string AccountNumber => this.accountNumber;

  private void LoadGLAccount()
  {
    try
    {
      using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
      {
        using (SqlCommand sqlCommand = new SqlCommand("spFin_GetGLAccountObject", connection))
        {
          sqlCommand.Parameters.AddWithValue("@glacctid", (object) this.GLAccountID);
          sqlCommand.CommandType = CommandType.StoredProcedure;
          sqlCommand.CommandTimeout = 0;
          sqlCommand.Connection.Open();
          SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
          this.accountFullName = sqlDataReader.Read() ? sqlDataReader["fullName"].ToString() : throw new GLAccountNotFoundException(StringResourceManager.GetString("GLAccountNotFound"));
          this.accountShortName = sqlDataReader["shortName"].ToString();
          this.glAccountClassName = sqlDataReader["className"].ToString();
          this.isControlAccount = (bool) sqlDataReader["controlAcct"];
          this.isSystemDefined = (bool) sqlDataReader["systemdefined"];
          this.isClosed = (bool) sqlDataReader["closed"];
          this.linkedEntityGuid = new Guid(sqlDataReader["linkedentity"].ToString());
          this.parentGLAccount = int.Parse(sqlDataReader["parentGL"].ToString());
          this.glCompanyId = int.Parse(sqlDataReader["GlCompanyId"].ToString());
          this.glAccountNumber = sqlDataReader["GLAccountNumber"].ToString();
          this.linkedEntityName = sqlDataReader["LinkedEntityName"].ToString();
          this.rollUpTo = int.Parse(sqlDataReader["rollUpto"].ToString());
          this.financialAcctTypeId = int.Parse(sqlDataReader["FinancialAcctTypeId"].ToString());
          this.financialAcctTypeName = sqlDataReader["FinancialAcctTypeDescription"].ToString();
          this.currentBalance = Decimal.Parse(sqlDataReader["CurrentBalance"].ToString());
          this.accountNumber = sqlDataReader["acctNum"].ToString();
        }
      }
    }
    catch (SqlException ex)
    {
      throw new LoadGLAccountException($"{StringResourceManager.GetString("GLAccountLoadException")} {ex.Errors[0].Message}");
    }
  }

  private void LoadGLAccount(SqlCommand cmd)
  {
    SqlDataReader sqlDataReader = (SqlDataReader) null;
    try
    {
      cmd.Parameters.Clear();
      cmd.Parameters.AddWithValue("@glacctid", (object) this.GLAccountID);
      cmd.CommandText = "spFin_GetGLAccountObject";
      cmd.CommandType = CommandType.StoredProcedure;
      if (cmd.Connection.State != ConnectionState.Open)
        cmd.Connection.Open();
      sqlDataReader = cmd.ExecuteReader();
      this.accountFullName = sqlDataReader.Read() ? sqlDataReader["fullName"].ToString() : throw new GLAccountNotFoundException(StringResourceManager.GetString("GLAccountNotFound"));
      this.accountShortName = sqlDataReader["shortName"].ToString();
      this.glAccountClassName = sqlDataReader["className"].ToString();
      this.isControlAccount = (bool) sqlDataReader["controlAcct"];
      this.isSystemDefined = (bool) sqlDataReader["systemdefined"];
      this.isClosed = (bool) sqlDataReader["closed"];
      this.linkedEntityGuid = new Guid(sqlDataReader["linkedentity"].ToString());
      this.parentGLAccount = int.Parse(sqlDataReader["parentGL"].ToString());
      this.glCompanyId = int.Parse(sqlDataReader["GlCompanyId"].ToString());
      this.glAccountNumber = sqlDataReader["GLAccountNumber"].ToString();
      this.linkedEntityName = sqlDataReader["LinkedEntityName"].ToString();
      this.rollUpTo = int.Parse(sqlDataReader["rollUpto"].ToString());
      this.financialAcctTypeId = int.Parse(sqlDataReader["FinancialAcctTypeId"].ToString());
      this.financialAcctTypeName = sqlDataReader["FinancialAcctTypeDescription"].ToString();
      this.currentBalance = Decimal.Parse(sqlDataReader["CurrentBalance"].ToString());
    }
    catch (SqlException ex)
    {
      throw new LoadGLAccountException($"{StringResourceManager.GetString("GLAccountLoadException")} {ex.Errors[0].Message}");
    }
    finally
    {
      if (!sqlDataReader.IsClosed)
        sqlDataReader.Close();
    }
  }

  public static bool GlAccountExists(int accountNumber, int rollUpTo, int classId)
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand($"Select dbo.CheckGLAccountExists({accountNumber}, {rollUpTo}, {classId})", connection))
      {
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Connection.Open();
        return bool.Parse(sqlCommand.ExecuteScalar().ToString());
      }
    }
  }
}
