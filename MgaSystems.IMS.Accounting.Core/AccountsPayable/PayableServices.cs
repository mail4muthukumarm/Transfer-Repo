// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.PayableServices
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using GrapeCity.ActiveReports;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class PayableServices
{
  private static int _transactionNumber;

  public static bool WriteOffTransaction(
    int gLAccountID,
    Decimal writeOffAmount,
    int chargeCode,
    int invoiceNumber,
    Guid companyLineGuid,
    int glCompanyId,
    Guid payeeGuid)
  {
    if (!SecurityManager.Instance.AssertPermission("{0D8AB572-A12A-4386-8B58-EA1390F5EF81}"))
    {
      int num = (int) MessageBox.Show("You do not have rights to write-off this transaction!", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (MessageBox.Show($"This will permantly write-off the selected transaction against income in the amount of {writeOffAmount.ToString("c")}, do you wish to continue?", "Write-Off Transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return false;
    try
    {
      Decimal writeOffThreshold = Utility.GetWriteOffThreshold(Utility.TransactionType.AccountsPayable, glCompanyId);
      if ((writeOffAmount > 0M && !(writeOffAmount <= writeOffThreshold) || writeOffAmount < 0M && !(writeOffAmount >= Math.Abs(writeOffThreshold) * -1M)) && !SecurityManager.Instance.AssertPermission("{756F0D0D-A87C-4d4a-887E-B6A265CEEF1F}"))
      {
        string text = string.Empty;
        Decimal num1;
        if (writeOffAmount > 0M)
        {
          num1 = writeOffAmount - writeOffThreshold;
          text = $"The system has determined that the amount you trying to write-off exceeds the write-off threshold set by the system administrator by {num1.ToString("c")}. Your current permissions do not allow you access to override the write-off threshold.";
        }
        if (writeOffAmount < 0M)
        {
          num1 = writeOffThreshold + writeOffAmount;
          text = $"The system has determined that the amount you trying to write-off exceeds the write-off threshold set by the system administrator by {num1.ToString("c")}. Your current permissions do not allow you access to override the write-off threshold.";
        }
        if (!SecurityManager.Instance.AssertPermissionWithPrompt("{756F0D0D-A87C-4d4a-887E-B6A265CEEF1F}"))
        {
          int num2 = (int) MessageBox.Show(text, "Write-Off Exceeds Threshold", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          return false;
        }
      }
      Utility.WriteOffTransaction(glCompanyId, invoiceNumber, chargeCode, companyLineGuid, writeOffAmount, gLAccountID, string.Empty, Utility.TransactionType.AccountsPayable, payeeGuid, payeeGuid);
      return true;
    }
    catch (SqlException ex)
    {
      int num = (int) MessageBox.Show("An error has occurred while trying to write-off the specified transaction. " + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      return false;
    }
  }

  public static void CreateCheckDetails(int transactionNumber)
  {
    PayableServices._transactionNumber = transactionNumber;
    new Thread(new ThreadStart(PayableServices.DoCreateCheckDetails))
    {
      IsBackground = true,
      Name = nameof (CreateCheckDetails)
    }.Start();
  }

  private static void DoCreateCheckDetails()
  {
    using (SqlCommand sqlCommand = new SqlCommand("OPT_spCreateCheckDetails", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      sqlCommand.CommandTimeout = 120;
      sqlCommand.Parameters.AddWithValue("@transactnum", (object) PayableServices._transactionNumber);
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Connection.Open();
      sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
      try
      {
        sqlCommand.ExecuteNonQuery();
        sqlCommand.Transaction.Commit();
      }
      catch
      {
        sqlCommand.Transaction.Rollback();
      }
    }
  }

  public static void PrintPaymentSummary(int TransactionNumber)
  {
    SectionReport rpt = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptPaymentStatement), new object[1]
    {
      (object) TransactionNumber
    });
    rpt.Run();
    ReportFactory.Instance.ShowReport(rpt);
  }
}
