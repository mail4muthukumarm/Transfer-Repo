// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.GeneralLedger.Exceptions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;

public class Utilities
{
  public const string AUTOMATIONSETTINGSRIGHTS = "{5FB0F07D-0F17-47e0-82F3-B65AEB20BB07}";
  public const string JOURNALENTRYRIGHTS = "{C2FD50F8-2B5C-44b6-A521-12EA29B24FC1}";
  public const string INVOICELEDGERENTRYRIGHTS = "{840AB406-22A8-41a2-B7E6-71AF171E2C75}";
  public const string GENERALLEDGER_MANGEMENTRIGHTS = "{E5A20506-6E0C-49b0-BD04-31C0BC68D00B}";
  public const string FISCALCONFIGURATION_RIGHTS = "{C61CFA14-8F4A-4cbe-95F3-9773FA38F96F}";
  public const string CLOSEFISCAL_RIGHTS = "{1D6326A2-7300-4f39-A531-4A119F657C5F}";
  public const string JOURNALVIEWER_RIGHTS = "{FE42072A-5A73-4035-B48E-E5E7FBFC59C1}";
  public const string AGINGBUCKET_RIGHTS = "{30C38296-8098-4a12-9768-5AD6C183CD87}";

  public static bool IsNumericValue(object val)
  {
    try
    {
      int.Parse(val.ToString());
      return true;
    }
    catch (FormatException ex)
    {
      return false;
    }
    catch (OverflowException ex)
    {
      return false;
    }
  }

  public static bool IsDecimalValue(object val)
  {
    try
    {
      Decimal.Parse(val.ToString(), NumberStyles.Currency);
      return true;
    }
    catch (FormatException ex)
    {
      return false;
    }
    catch (OverflowException ex)
    {
      return false;
    }
  }

  public static Utilities.AccountingMethod GetAccountingMethod(int GlCompanyID)
  {
    return (Utilities.AccountingMethod) Database.Instance.QueryText.PerformScalarQueryInt($"Select dbo.GetAccountingMethod({GlCompanyID})");
  }

  public static GLAccount GetPrepaidExpenseAccount(int GlCompanyId)
  {
    int glAccountId = Database.IsNull(Database.Instance.QueryText.PerformScalarQuery($"select isNull(glAcctId, -1) from tblFin_MgaAutomationAccounts where AcctRoleId = 'PPE' and dbo.GetGlCompanyId(glacctid) = {GlCompanyId}"), -1);
    return glAccountId == -1 ? (GLAccount) null : new GLAccount(glAccountId);
  }

  public static GLAccount GetAccruedExpenseAccount(int GlCompanyId)
  {
    int glAccountId = Database.IsNull(Database.Instance.QueryText.PerformScalarQuery($"select isNull(glAcctId, -1) from tblFin_MgaAutomationAccounts where AcctRoleId  = 'ACE' and dbo.GetGlCompanyId(glacctid) = {GlCompanyId}"), -1);
    return glAccountId == -1 ? (GLAccount) null : new GLAccount(glAccountId);
  }

  [Obsolete("This method has been deprecated due to the accounting overhaul and will no longer return a credible value.")]
  public static int GetEntityPayableAccount(Guid entityGuid, int glCompanyId)
  {
    return Database.Instance.QueryText.PerformScalarQueryInt(string.Format("Select dbo.GetEntitySpecificAccount({0}, '{1}')", (object) entityGuid.ToString(), (object) glCompanyId, (object) "P"));
  }

  public static int GetEntityPayableAccount(int glCompanyId)
  {
    return Database.Instance.QueryText.PerformScalarQueryInt($"Select dbo.GetEntitySpecificAccount({glCompanyId}, '{"P"}')");
  }

  [Obsolete("This method has been deprecated due to the accounting overhaul and will no longer return a credible value.")]
  public static int GetEntityExchangeAccount(Guid entityGuid, int glCompanyId)
  {
    return Database.Instance.QueryText.PerformScalarQueryInt($"Select dbo.GetEntitySpecificAccount('{entityGuid.ToString()}', {glCompanyId}, '{"X"}')");
  }

  public static int GetEntityExchangeAccount(int glCompanyId)
  {
    return Database.Instance.QueryText.PerformScalarQueryInt($"Select dbo.GetEntitySpecificAccount({glCompanyId}, '{"X"}')");
  }

  [Obsolete("This method has been deprecated due to the accounting overhaul and will no longer return a credible value.")]
  public static int GetEntityReceivableAccount(Guid entityGuid, int glCompanyId)
  {
    return Database.Instance.QueryText.PerformScalarQueryInt($"Select dbo.GetEntitySpecificAccount('{entityGuid.ToString()}', {glCompanyId}, '{"R"}')");
  }

  public static int GetEntityReceivableAccount(int glCompanyId)
  {
    return Database.Instance.QueryText.PerformScalarQueryInt($"Select dbo.GetEntitySpecificAccount({glCompanyId}, '{"R"}')");
  }

  [Obsolete("This method has been deprecated due to the acocunting overhaul and will no longer return a credible value.")]
  public static int GetEntityUnaccountedAccount(Guid entityGuid, int glCompanyId)
  {
    return Database.Instance.QueryText.PerformScalarQueryInt($"Select dbo.GetEntitySpecificAccount('{entityGuid.ToString()}', {glCompanyId}, '{"U"}')");
  }

  public static int GetEntityUnaccountedAccount(int glCompanyId)
  {
    return Database.Instance.QueryText.PerformScalarQueryInt($"Select dbo.GetEntitySpecificAccount({glCompanyId}, '{"U"}')");
  }

  public static void VerifyEntityGlAccounts(Guid entityGuid, int glCompanyId)
  {
    if (Database.Instance.QueryText.PerformScalarQueryInt($"Select Count(*) from tblfin_Entity_Ap_Ar_list where entityGuid = '{entityGuid.ToString()}' and dbo.getGlCompanyId(glacctid) = {glCompanyId}") != 0)
      return;
    using (SqlCommand sqlCommand = new SqlCommand("spFin_AutomateAccountLinking", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@entityguid", (object) entityGuid);
      sqlCommand.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
      sqlCommand.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand.Connection.Open();
      sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
      try
      {
        sqlCommand.ExecuteNonQuery();
        sqlCommand.Transaction.Commit();
      }
      catch (SqlException ex)
      {
        sqlCommand.Transaction.Rollback();
        throw ex;
      }
    }
  }

  public static int GetInvoiceCorrectionChargeCode()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("Select dbo.GetCommissionCorrectionChargeCode()", connection))
      {
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Connection.Open();
        int num = int.Parse(sqlCommand.ExecuteScalar().ToString());
        return num != 0 ? num : throw new CorrectionChargeCodeNotFound("The invoice correction could not be found. Please contact your system administrator to ensure the invoice correction charge code is created.");
      }
    }
  }

  public static GLAccount GetMasterAccount(Utilities.MasterAccountType accountType, int glCompanyId)
  {
    string empty = string.Empty;
    string str1;
    switch (accountType)
    {
      case Utilities.MasterAccountType.Cash:
        str1 = "CASH";
        break;
      case Utilities.MasterAccountType.Exchange:
        str1 = "X/F";
        break;
      case Utilities.MasterAccountType.Payables:
        str1 = "A/P";
        break;
      case Utilities.MasterAccountType.Receivables:
        str1 = "A/R";
        break;
      case Utilities.MasterAccountType.UnAccounted:
        str1 = "S/R";
        break;
      default:
        str1 = "";
        break;
    }
    string str2 = str1;
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand($"Select dbo.GetGLAccountIDFromShortName('{str2}', {glCompanyId})", connection))
      {
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Connection.Open();
        int glAccountId = int.Parse(sqlCommand.ExecuteScalar().ToString());
        return glAccountId > 0 ? new GLAccount(glAccountId) : throw new GLAccountNotFoundException("The master account for the specifed GL Company Id could not be found!");
      }
    }
  }

  public static int GetAutomationSetting(string accountRoleId, int glCompanyId)
  {
    return Database.Instance.QuerySP.PerformScalarQueryInt("spFin_GetAutomationSetting", 0, (object) "@acctroleId", (object) accountRoleId, (object) "@glcompanyid", (object) glCompanyId);
  }

  public static void DeleteChartOfAccounts(int glCompanyId, bool showPrompt)
  {
    if (showPrompt && MessageBox.Show("This will permanently delete this chart of accounts, are you sure you wish to continue?", "Delete Chart of Accounts?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("spFin_DeleteGLCompany", connection))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@glCoId", (object) glCompanyId);
        sqlCommand.Connection.Open();
        sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
        try
        {
          sqlCommand.ExecuteNonQuery();
          sqlCommand.Transaction.Commit();
        }
        catch (SqlException ex)
        {
          sqlCommand.Transaction.Rollback();
          throw ex;
        }
      }
    }
  }

  public enum AccountingMethod
  {
    Accrual,
    Cash,
    NotDefined,
  }

  public enum CommissionRecognition
  {
    None,
    Proportional,
    Full,
  }

  public enum CommissionReconciliation
  {
    None,
    Receivables,
    Payables,
  }

  public enum InvoiceCorrectionType
  {
    None,
    APDecrease,
    APIncrease,
    ARDecrease,
    ARIncrease,
  }

  public enum InvoiceCorrectionEntity
  {
    None,
    Company,
    Insured,
    Producer,
  }

  public enum MasterAccountType
  {
    Cash,
    Exchange,
    Payables,
    Receivables,
    UnAccounted,
  }
}
