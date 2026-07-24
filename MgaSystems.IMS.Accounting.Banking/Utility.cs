// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Utility
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using GrapeCity.ActiveReports;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Reporting;
using System;
using System.Data;
using System.Data.SqlClient;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public class Utility
{
  public const int CheckDetailMax = 20;
  public const string CheckPrintingSecurityID = "{A1DC147C-597A-43f8-8763-1E95305C3330}";
  public const string ViewCheckRegisterSecurityID = "{D5D93FFA-AED6-4175-B1F7-09984E2205BE}";
  internal const string PrintChecksSecurityID = "{879830FE-04FA-4a48-9FE6-0626CF095A85}";
  internal const string ReprintChecksSecurityID = "{d64aeaf5-0b2a-4321-9b41-efe6c412d779}";
  internal const string BankingSecurityID = "{E7CE118D-D5DD-4e32-BB79-A486589A92AE}";
  internal const string BounceCheckRights = "{17ADC292-7269-4a90-AF7A-7B0200571153}";
  internal const string ReconcileUnReconcile = "{724FE13B-6F3C-4c8b-B6B4-B41BBF157C55}";
  internal const string CreateDepositTicketSecurityID = "{E8D47833-BBC3-43a9-8E95-F0A3290D996A}";
  internal const string ViewDepositDetailSecurityID = "{F0B7BA7B-AB2D-4ac8-A7AE-DC57991D3E3B}";
  internal const string CashReceiptSecurityID = "{EE3AFC8D-71C9-4594-95CB-19889DF74C98}";
  internal const string BankFeesSecurityID = "{202B7580-2D2C-4d24-9C9C-9DF92A97EFC4}";
  internal const string CreateCheckSecurityID = "{064AAFC5-45F0-4ecc-BA29-7D7002DA85B6}";
  internal const string BankTransferSecurityID = "{1A2183F1-8CEF-47b4-97D0-573AF021AD16}";
  public const string PayeeInstructionSecurityId = "{E7D0695A-0C0C-42D7-830E-0BD1128BA182}";
  internal const string SWEEPWIZARDSecurityID = "{D269A4DA-B77B-4021-9AE6-43FAC3C2C5BE}";
  public const string CHECKPRINTER_PREFERENCE = "Accounting.CheckPrinter";

  internal static void PrintDepositTicket(int depositId)
  {
    SqlCommand selectCommand = new SqlCommand("spfin_rptbankdeposit", new SqlConnection(CurrentUser.Instance.ConnectionString));
    DataSet dataSet = new DataSet();
    try
    {
      SqlCommand sqlCommand = selectCommand;
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@depositId", (object) depositId);
      new SqlDataAdapter(selectCommand).Fill(dataSet);
      SectionReport rpt = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptBankDepositTicket), new object[3]
      {
        (object) dataSet.Tables[0],
        (object) dataSet.Tables[1],
        (object) dataSet.Tables[2]
      });
      rpt.Run();
      ReportFactory.Instance.ShowReport(rpt);
    }
    finally
    {
      if (selectCommand != null)
      {
        if (selectCommand.Connection != null)
        {
          selectCommand.Connection.Close();
          selectCommand.Connection.Dispose();
          selectCommand.Connection = (SqlConnection) null;
        }
        selectCommand.Dispose();
      }
    }
  }

  internal static void DenyAccess()
  {
    formAccessDenied formAccessDenied = new formAccessDenied();
    int num = (int) formAccessDenied.ShowDialog();
    formAccessDenied.Dispose();
  }

  internal static void SaveUserPreference(
    string preferenceName,
    string preferenceValue,
    string preferenceType)
  {
    DefaultDatabase.ExecuteNonQuery("SetPreference_UserGuid", new object[8]
    {
      (object) "@PreferenceName",
      (object) preferenceName,
      (object) "@PreferenceValue",
      (object) preferenceValue,
      (object) "@PreferenceType",
      (object) preferenceType,
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
  }

  public static Decimal GetAccountStartingBalance(int BankGLAccountID, DateTime PeriodDate)
  {
    return Decimal.Parse(DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "Select dbo.GetBankStartingBalance(@gl, @d)", new object[4]
    {
      (object) "@gl",
      (object) BankGLAccountID,
      (object) "@d",
      (object) PeriodDate
    }).ToString());
  }

  public static object GetTransactionReconciliationDate(
    int transactionNumber,
    bool isDeposit,
    int glAccountId)
  {
    return DefaultDatabase.ExecuteScalar<object>(CommandType.Text, "SELECT reconciledDate FROM tblFin_ReconciliationJournal WHERE TransactionId = @trx AND IsDeposit = @isDep AND GLAcctId = @gl", new object[6]
    {
      (object) "@trx",
      (object) transactionNumber,
      (object) "@isDep",
      (object) isDeposit,
      (object) "@gl",
      (object) glAccountId
    });
  }

  public static DataTable GetBankAccounts(int glCompanyId)
  {
    return DefaultDatabase.ExecuteDataTable("spFin_GetBankAccounts", new object[2]
    {
      (object) "@GLCompanyId",
      (object) glCompanyId
    });
  }

  public static DataTable GetBankAccounts(string procedureName, int glCompanyId)
  {
    return DefaultDatabase.ExecuteDataTable(procedureName, new object[2]
    {
      (object) "@GLCompanyId",
      (object) glCompanyId
    });
  }
}
