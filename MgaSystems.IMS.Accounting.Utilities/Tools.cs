// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Utilities.Tools
// Assembly: MgaSystems.IMS.Accounting.Utilities, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0980F864-5BDB-427E-98EE-09B90661DBB2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Utilities.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Utilities;

[StandardModule]
public sealed class Tools
{
  private const string GridLayoutSubFolder = "GridLayout";
  private static SqlConnection mConIMSDB;
  private static int OpenCount;
  private const int CommandTimeout = 300;
  public const string AccountingAdminOptionsSecurityID = "{7FA00CF9-DAB0-49e9-B756-C320F8676D2E}";
  public const string JournalViewSecurityID = "{8A2A5928-F83B-458e-9606-B67E05BE00E4}";
  public const string IssueCheckSecurityID = "{412A5BE2-4102-4f53-A6AC-2E3DBF29ABC0}";
  public const string ARWriteOff = "{1F605391-C4FE-4032-AF21-3F221F39EA7C}";
  public const string APWriteOff = "{274CDCBE-BAE6-4524-B92A-47330DA36D0F}";
  public const string OperatingSecurityID = "{0EBAE87D-0EA1-4b67-A740-D2E39B60E457}";
  public const string TransactionalVoidSecurityID = "{442BEE41-14B3-4c71-99CC-4739B111C8F3}";
  public const string WriteOffOverride = "{72D9C44C-7024-4094-BB56-9E4907617FA8}";
  public const string PostingBankOverrideSecurityID = "{B4247FCA-E779-4898-80E1-A940AC046790}";

  public static SqlConnection DBConnection
  {
    get
    {
      if (Tools.mConIMSDB == null)
        Tools.mConIMSDB = new SqlConnection(CurrentUser.Instance.ConnectionString);
      return Tools.mConIMSDB;
    }
  }

  public static bool OpenConnection()
  {
    if (Tools.mConIMSDB == null)
      Tools.mConIMSDB = new SqlConnection();
    bool flag;
    if (Tools.mConIMSDB.State == ConnectionState.Closed || Tools.mConIMSDB.State == ConnectionState.Broken)
    {
      try
      {
        Tools.mConIMSDB.ConnectionString = CurrentUser.Instance.ConnectionString;
        Tools.mConIMSDB.Open();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) MessageBox.Show("Cannot access database.\r\n\r\n" + ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
        flag = false;
        ProjectData.ClearProjectError();
        goto label_6;
      }
    }
    ++Tools.OpenCount;
    flag = true;
label_6:
    return flag;
  }

  public static void CloseConnection()
  {
    if (Tools.OpenCount == 1)
      Tools.mConIMSDB.Close();
    if (Tools.OpenCount <= 0)
      return;
    --Tools.OpenCount;
  }

  public static void ResizeGridFillerColumn(UltraGrid Grid)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns).Count == 0)
      return;
    Grid.EventManager.SetEnabled((GridEventIds) 5, false);
    Grid.EventManager.SetEnabled((GridEventIds) 29, false);
    ((UltraGridBase) Grid).Refresh();
    int num1;
    int index;
    foreach (UltraGridBand band in ((UltraGridBase) Grid).DisplayLayout.Bands)
    {
      int num2 = band.GetExtent() + band.GetOrigin() - band.Columns["Filler"].Width;
      if (num2 > num1)
      {
        num1 = num2;
        index = band.Index;
      }
    }
    UIElementBorderStyle borderStyle = ((UltraGridBase) Grid).DisplayLayout.BorderStyle;
    int num3 = borderStyle == 1 ? 0 : (borderStyle - 5 <= 1 || borderStyle == 9 ? 2 * SystemInformation.Border3DSize.Width : 2 * SystemInformation.BorderSize.Width);
    int val2_1 = ((Control) Grid).DisplayRectangle.Width - num1 - num3;
    ((UltraGridBase) Grid).DisplayLayout.Bands[index].Columns["Filler"].Width = Math.Max(0, val2_1);
    ((UltraGridBase) Grid).Refresh();
    int num4 = ((UltraGridBase) Grid).DisplayLayout.Bands[index].GetOrigin() + ((UltraGridBase) Grid).DisplayLayout.Bands[index].GetExtent();
    foreach (UltraGridBand band in ((UltraGridBase) Grid).DisplayLayout.Bands)
    {
      int num5 = band.GetOrigin() + band.GetExtent() - band.Columns["Filler"].Width;
      int val2_2 = num4 - num5;
      band.Columns["Filler"].Width = Math.Max(0, val2_2);
    }
    Grid.EventManager.SetEnabled((GridEventIds) 5, true);
    Grid.EventManager.SetEnabled((GridEventIds) 29, true);
  }

  public static bool RoutingNumberIsValid(string RoutingNumber)
  {
    bool flag;
    try
    {
      int num;
      flag = Versioned.IsNumeric((object) RoutingNumber) && Strings.Len(RoutingNumber) == 9 && (num + Conversions.ToInteger(Strings.Mid(RoutingNumber, 1, 1)) * 3 + Conversions.ToInteger(Strings.Mid(RoutingNumber, 2, 1)) * 7 + Conversions.ToInteger(Strings.Mid(RoutingNumber, 3, 1)) * 1 + Conversions.ToInteger(Strings.Mid(RoutingNumber, 4, 1)) * 3 + Conversions.ToInteger(Strings.Mid(RoutingNumber, 5, 1)) * 7 + Conversions.ToInteger(Strings.Mid(RoutingNumber, 6, 1)) * 1 + Conversions.ToInteger(Strings.Mid(RoutingNumber, 7, 1)) * 3 + Conversions.ToInteger(Strings.Mid(RoutingNumber, 8, 1)) * 7 + Conversions.ToInteger(Strings.Mid(RoutingNumber, 9, 1))) % 10 == 0;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    return flag;
  }

  public static string GetEntityName(Guid EntityGUID)
  {
    return Database.Instance.QueryText.PerformScalarQueryString("Select dbo.GetEntityName(@EntityGUID)", (object) "@EntityGUID", (object) EntityGUID);
  }

  public static Assembly LoadComponentAssembly(object sender, ResolveEventArgs args)
  {
    return Assembly.GetExecutingAssembly();
  }

  public static bool ApplyUnaccounted(
    SqlTransaction Transaction,
    ArrayList AppliedCollection,
    AppliedUnAccounted.UnAccountedTransactionType TransactionType,
    int TransactionLink,
    string Comments = "")
  {
    bool flag;
    if (AppliedCollection.Count == 0)
    {
      flag = true;
    }
    else
    {
      SqlCommand sqlCommand1 = new SqlCommand("spFin_PostAppliedUnaccountedHeader");
      try
      {
        SqlCommand sqlCommand2 = sqlCommand1;
        sqlCommand2.CommandType = CommandType.StoredProcedure;
        sqlCommand2.Parameters.AddWithValue("@transtype", RuntimeHelpers.GetObjectValue(Interaction.IIf(TransactionType == AppliedUnAccounted.UnAccountedTransactionType.Payables, (object) "P", (object) "R")));
        sqlCommand2.Parameters.AddWithValue("@transactlink", (object) TransactionLink);
        sqlCommand2.Parameters.AddWithValue("@comments", (object) Comments);
        sqlCommand2.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
        sqlCommand2.Transaction = Transaction;
        int integer = Conversions.ToInteger(sqlCommand2.ExecuteScalar());
        int num = AppliedCollection.Count - 1;
        for (int index = 0; index <= num; ++index)
        {
          if (AppliedCollection[index] is AppliedUnAccounted)
          {
            SqlCommand sqlCommand3 = sqlCommand1;
            sqlCommand3.CommandType = CommandType.StoredProcedure;
            sqlCommand3.CommandText = Conversions.ToString(Interaction.IIf(TransactionType == AppliedUnAccounted.UnAccountedTransactionType.Payables, (object) "spFin_PostAppliedUnAccountedDetail_Payables", (object) "spFin_PostAppliedUnAccountedDetail_Receivables"));
            sqlCommand3.Parameters.Clear();
            sqlCommand3.Parameters.AddWithValue("@transactnum", (object) integer);
            sqlCommand3.Parameters.AddWithValue("@invoicenum", (object) ((AppliedUnAccounted) AppliedCollection[index]).InvoiceNumber);
            sqlCommand3.Parameters.AddWithValue("@chargecode", (object) ((AppliedUnAccounted) AppliedCollection[index]).ChargeCode);
            sqlCommand3.Parameters.AddWithValue("@companylineguid", (object) ((AppliedUnAccounted) AppliedCollection[index]).CompanyLineGuid);
            sqlCommand3.Parameters.AddWithValue("@entityguid", (object) ((AppliedUnAccounted) AppliedCollection[index]).EntityGuid);
            sqlCommand3.Parameters.AddWithValue("@glcompanyid", (object) ((AppliedUnAccounted) AppliedCollection[index]).GLCompanyID);
            sqlCommand3.Parameters.AddWithValue("@amount", (object) ((AppliedUnAccounted) AppliedCollection[index]).Amount);
            sqlCommand3.ExecuteNonQuery();
          }
        }
      }
      finally
      {
        sqlCommand1.Dispose();
      }
    }
    return flag;
  }

  public static bool VerifyMonthClosed(DateTime VerifyDate)
  {
    bool flag;
    if (DateTime.Compare(VerifyDate, Tools.GetCloseDate()) <= 0)
    {
      int num = (int) MessageBox.Show("The transaction you are trying to post violate the accounting closing period. This transaction can not post.", "Closing Perod Violation!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private static DateTime GetCloseDate()
  {
    return Database.Instance.QuerySP.PerformScalarQueryDate("spFin_GetClosedDate");
  }

  public static Tools.ControlVisibility ResolveControlVisibility(Control parent, Control ctl)
  {
    return !parent.ClientRectangle.Contains(ctl.Bounds) ? (!parent.ClientRectangle.IntersectsWith(ctl.Bounds) ? Tools.ControlVisibility.Hidden : Tools.ControlVisibility.PartiallyObscurred) : Tools.ControlVisibility.Visible;
  }

  public static void FormatCurrencyTextbox(ref TextBox sender)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(sender.Text, string.Empty, false) == 0 || !Versioned.IsNumeric((object) sender.Text))
      return;
    sender.Text = Strings.Format((object) sender.Text, "Currency");
  }

  public static void SetGridCellForeColor(ref UltraGridCell cell)
  {
    if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(cell.Value)) || !Versioned.IsNumeric(RuntimeHelpers.GetObjectValue(cell.Value)))
      cell.Appearance.ForeColor = Color.Black;
    else if (Decimal.Compare(Conversions.ToDecimal(cell.Value), 0M) < 0)
      cell.Appearance.ForeColor = Color.Red;
    else
      cell.Appearance.ForeColor = Color.Black;
  }

  public static string ConvertNumericToEnglish(Decimal N)
  {
    string english;
    if (Decimal.Compare(N, 0M) == 0)
    {
      english = "Zero";
    }
    else
    {
      string str1 = Decimal.Compare(N, 0M) >= 0 ? string.Empty : "Negative ";
      Decimal d1 = Math.Abs(Decimal.Subtract(N, Conversion.Fix(N)));
      if (Decimal.Compare(N, 0M) < 0 || Decimal.Compare(d1, 0M) != 0)
        N = Math.Abs(Conversion.Fix(N));
      bool flag = Decimal.Compare(N, 1M) >= 0;
      if (Decimal.Compare(N, 1000000000000M) >= 0)
      {
        str1 = $"{str1}{Tools.EnglishDigitGroup(new Decimal(Convert.ToInt32(Decimal.Divide(N, 1000000000000M))))} Trillion";
        N = Decimal.Subtract(N, Decimal.Multiply(Conversion.Int(Decimal.Divide(N, 1000000000000M)), 1000000000000M));
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1000000000M) >= 0)
      {
        str1 = $"{str1}{Tools.EnglishDigitGroup(new Decimal(Convert.ToInt32(Decimal.Divide(N, 1000000000M))))} Billion";
        N = Decimal.Subtract(N, Decimal.Multiply(Conversion.Int(Decimal.Divide(N, 1000000000M)), 1000000000M));
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1000000M) >= 0)
      {
        str1 = $"{str1}{Tools.EnglishDigitGroup(new Decimal(Convert.ToInt32(N) / 1000000))} Million";
        N = Decimal.Remainder(N, 1000000M);
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1000M) >= 0)
      {
        str1 = $"{str1}{Tools.EnglishDigitGroup(new Decimal(Convert.ToInt32(N) / 1000))} Thousand";
        N = Decimal.Remainder(N, 1000M);
        if (Decimal.Compare(N, 1M) >= 0)
          str1 += " ";
      }
      if (Decimal.Compare(N, 1M) >= 0)
        str1 += Tools.EnglishDigitGroup(N);
      if (Decimal.Compare(N, 1M) > 0)
        str1 = Decimal.Compare(N, 2M) >= 0 ? str1 + " Dollars" : str1 + " Dollar";
      string str2;
      if (Decimal.Compare(d1, 0M) == 0)
        str2 = str1 ?? "";
      else if (Decimal.Compare(Conversion.Int(Decimal.Multiply(d1, 100M)), Decimal.Multiply(d1, 100M)) == 0)
      {
        str2 = $"{(!flag ? str1 + "Zero Dollars And " : str1 + " and ")}{Strings.Format((object) Decimal.Multiply(d1, 100M), "00")}/100";
      }
      else
      {
        if (flag)
          str1 += " and ";
        str2 = $"{str1}{Strings.Format((object) Decimal.Multiply(d1, 10000M), "0000")}/10000";
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2.ToUpper(), "ONE", false) == 0)
        str2 += " Dollars and 00/100 Cents";
      english = str2;
    }
    return english;
  }

  public static string EnglishDigitGroup(Decimal N)
  {
    string str1 = string.Empty;
    bool flag = false;
    switch (Convert.ToInt32(N) / 100)
    {
      case 0:
        str1 = string.Empty;
        flag = false;
        break;
      case 1:
        str1 = "One Hundred";
        flag = true;
        break;
      case 2:
        str1 = "Two Hundred";
        flag = true;
        break;
      case 3:
        str1 = "Three Hundred";
        flag = true;
        break;
      case 4:
        str1 = "Four Hundred";
        flag = true;
        break;
      case 5:
        str1 = "Five Hundred";
        flag = true;
        break;
      case 6:
        str1 = "Six Hundred";
        flag = true;
        break;
      case 7:
        str1 = "Seven Hundred";
        flag = true;
        break;
      case 8:
        str1 = "Eight Hundred";
        flag = true;
        break;
      case 9:
        str1 = "Nine Hundred";
        flag = true;
        break;
    }
    if (flag)
      N = Decimal.Remainder(N, 100M);
    string str2;
    if (Decimal.Compare(N, 0M) > 0)
    {
      if (flag)
        str1 += " ";
      switch (Convert.ToInt32(N) / 10)
      {
        case 0:
        case 1:
          flag = false;
          break;
        case 2:
          str1 += "Twenty";
          flag = true;
          break;
        case 3:
          str1 += "Thirty";
          flag = true;
          break;
        case 4:
          str1 += "Forty";
          flag = true;
          break;
        case 5:
          str1 += "Fifty";
          flag = true;
          break;
        case 6:
          str1 += "Sixty";
          flag = true;
          break;
        case 7:
          str1 += "Seventy";
          flag = true;
          break;
        case 8:
          str1 += "Eighty";
          flag = true;
          break;
        case 9:
          str1 += "Ninety";
          flag = true;
          break;
      }
      if (flag)
        N = Decimal.Remainder(N, 10M);
      if (Decimal.Compare(N, 0M) > 0)
      {
        if (flag)
          str1 += "-";
        Decimal d1 = N;
        if (Decimal.Compare(d1, 0M) != 0)
        {
          if (Decimal.Compare(d1, 1M) == 0)
            str1 += "One";
          else if (Decimal.Compare(d1, 2M) == 0)
            str1 += "Two";
          else if (Decimal.Compare(d1, 3M) == 0)
            str1 += "Three";
          else if (Decimal.Compare(d1, 4M) == 0)
            str1 += "Four";
          else if (Decimal.Compare(d1, 5M) == 0)
            str1 += "Five";
          else if (Decimal.Compare(d1, 6M) == 0)
            str1 += "Six";
          else if (Decimal.Compare(d1, 7M) == 0)
            str1 += "Seven";
          else if (Decimal.Compare(d1, 8M) == 0)
            str1 += "Eight";
          else if (Decimal.Compare(d1, 9M) == 0)
            str1 += "Nine";
          else if (Decimal.Compare(d1, 10M) == 0)
            str1 += "Ten";
          else if (Decimal.Compare(d1, 11M) == 0)
            str1 += "Eleven";
          else if (Decimal.Compare(d1, 12M) == 0)
            str1 += "Twelve";
          else if (Decimal.Compare(d1, 13M) == 0)
            str1 += "Thirteen";
          else if (Decimal.Compare(d1, 14M) == 0)
            str1 += "Fourteen";
          else if (Decimal.Compare(d1, 15M) == 0)
            str1 += "Fifteen";
          else if (Decimal.Compare(d1, 16M) == 0)
            str1 += "Sixteen";
          else if (Decimal.Compare(d1, 17M) == 0)
            str1 += "Seventeen";
          else if (Decimal.Compare(d1, 18M) == 0)
            str1 += "Eighteen";
          else if (Decimal.Compare(d1, 19M) == 0)
            str1 += "Nineteen";
        }
        str2 = str1;
      }
      else
        str2 = str1;
    }
    else
      str2 = str1;
    return str2;
  }

  public static Decimal GetGLAccountBalance(int GLAccountID)
  {
    return Conversions.ToDecimal(Database.Instance.QueryText.PerformScalarQuery($"Select dbo.GetGLAccountBalance({GLAccountID})"));
  }

  public static string GetFinanceCompanyName(int invoiceNumber)
  {
    return Database.Instance.QueryText.PerformScalarQuery($"select dbo.GetFinanceCompanyName_Invoice({invoiceNumber})").ToString();
  }

  public static string GetFinanceCompanyGuid(int invoiceNumber)
  {
    return Database.Instance.QueryText.PerformScalarQueryString("select dbo.GetFinanceCompanyGuid_Invoice(@invoiceNumber)", (object) "@invoiceNumber", (object) invoiceNumber);
  }

  public static int GetDefaultCostCenterId(Guid payeeGuid, int glCompanyId)
  {
    return Conversions.ToInteger(Database.Instance.QueryText.PerformScalarQuery($"select dbo.GetDefaultCostCenter('{payeeGuid.ToString()}', {glCompanyId})"));
  }

  public static int GetExpenseDefaultGLAccount(int expenseCode, int glCompanyId)
  {
    return Conversions.ToInteger(Database.Instance.QueryText.PerformScalarQuery($"select dbo.GetExpenseDefaultGlAcct({expenseCode}, {glCompanyId})"));
  }

  public static string GetGLAccountFullName(int glAcctId)
  {
    return Database.Instance.QueryText.PerformScalarQuery(string.Format("Select fullname from tblFin_GlAccounts where glAcctId = @glAcctId", (object) "@glAcctId", (object) glAcctId)).ToString();
  }

  public static int GetInvoiceControlNumber(int invoiceNumber)
  {
    return Conversions.ToInteger(Database.Instance.QueryText.PerformScalarQuery($"Select quotecontrolnum from tblFin_Invoices where invoiceNum = {invoiceNumber}"));
  }

  public static int GetCurrentInvoiceQuoteId(int controlNumber)
  {
    return Conversions.ToInteger(Database.Instance.QueryText.PerformScalarQuery($"select dbo.PolicyLastBoundQuote_Monetary({controlNumber})"));
  }

  public static int GetInvoiceGLCompanyId(int invoiceNumber)
  {
    return Conversions.ToInteger(Database.Instance.QueryText.PerformScalarQuery($"Select glCompanyId from tblFin_Invoices where invoiceNum = {invoiceNumber}"));
  }

  public static string GetGLAccountType(int glAccountId)
  {
    return Database.Instance.QueryText.PerformScalarQuery($"select dbo.GetGLAccountType({glAccountId})").ToString();
  }

  public static int VerifyBankAccount(int GLCompany)
  {
    frmSelectBank frmSelectBank = new frmSelectBank(GLCompany);
    int num1;
    try
    {
      int num2 = (int) frmSelectBank.ShowDialog();
      num1 = frmSelectBank.DialogResult != DialogResult.OK ? -1 : frmSelectBank.BankAccountId;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num3 = (int) MessageBox.Show("An error has occurred while trying to launch the bank verification form.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    finally
    {
      frmSelectBank.Dispose();
    }
    return num1;
  }

  public static int VerifyBankAccount(int GLCompany, int BankAccountGL)
  {
    frmSelectBank frmSelectBank = new frmSelectBank(GLCompany, BankAccountGL);
    int num1;
    try
    {
      int num2 = (int) frmSelectBank.ShowDialog();
      num1 = frmSelectBank.DialogResult != DialogResult.OK ? -1 : frmSelectBank.BankAccountId;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      int num3 = (int) MessageBox.Show("An error has occurred while trying to launch the bank verification form.\r\n\r\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      ProjectData.ClearProjectError();
    }
    finally
    {
      frmSelectBank.Dispose();
    }
    return num1;
  }

  public static int GetGLPrimaryBankAccount(int GLCompanyId)
  {
    return Database.Instance.QuerySP.PerformScalarQueryInt("spFin_GetPrimaryBankAccount", (object) "@glCompanyID", (object) GLCompanyId);
  }

  public static Tools.AccountingMethods GetAccountingMethod(int glCompanyId)
  {
    return (Tools.AccountingMethods) Conversions.ToInteger(Database.Instance.QueryText.PerformScalarQuery("select dbo.GetAccountingMethod({0})", (object) glCompanyId));
  }

  public static int GetOperatingAccount(int glCompanyId)
  {
    return Conversions.ToInteger(Database.Instance.QueryText.PerformScalarQuery($"select dbo.getoperatingaccount({glCompanyId})"));
  }

  internal static bool WriteOffTransaction(
    int glCompanyId,
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal Amount,
    int glAccountId,
    string Comments,
    Tools.TransactionType transactionType)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_WriteOffTransaction", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.Connection.InfoMessage += new SqlInfoMessageEventHandler(Tools.SQLDebuggingHelper);
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@invoiceNum", (object) invoiceNumber);
      sqlCommand2.Parameters.AddWithValue("@chargeCode", (object) chargeCode);
      sqlCommand2.Parameters.AddWithValue("@companyLineGuid", (object) companyLineGuid);
      sqlCommand2.Parameters.AddWithValue("@glAcctId", (object) glAccountId);
      sqlCommand2.Parameters.AddWithValue("@amount", (object) Amount);
      sqlCommand2.Parameters.AddWithValue("@glCompanyId", (object) glCompanyId);
      sqlCommand2.Parameters.AddWithValue("@comments", (object) Comments);
      sqlCommand2.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand2.Parameters.AddWithValue("@writeOffType", RuntimeHelpers.GetObjectValue(Interaction.IIf(transactionType == Tools.TransactionType.AccountsReceivable, (object) "AR", (object) "AP")));
      int num1;
      sqlCommand2.Parameters.AddWithValue("@transactNum", (object) num1);
      sqlCommand2.Parameters["@transactNum"].Direction = ParameterDirection.Output;
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      sqlCommand2.ExecuteNonQuery();
      int integer = Conversions.ToInteger(sqlCommand2.Parameters["@transactNum"].Value);
      sqlCommand2.CommandType = CommandType.Text;
      sqlCommand2.Parameters.Clear();
      sqlCommand2.CommandText = $"Select dbo.CheckDistributionBalance({integer})";
      if (Conversions.ToInteger(sqlCommand2.ExecuteScalar()) != 1)
      {
        sqlCommand2.Transaction.Rollback();
        sqlCommand2.Connection.Close();
        int num2 = (int) MessageBox.Show("An error has occurred while trying to post this payables transaction. The posting distribution would not balance. To ensure data integrity this transaction has been rolled back.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
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
        if (sqlCommand1.Transaction != null)
          sqlCommand1.Transaction.Dispose();
        sqlCommand1.Dispose();
      }
    }
    bool flag;
    return flag;
  }

  internal static Decimal GetWriteOffThreshold(
    Tools.TransactionType transactionType,
    int glCompanyId)
  {
    return Conversions.ToDecimal(Database.Instance.QueryText.PerformScalarQuery($"Select dbo.GetWriteOffThreshold({glCompanyId}, '{RuntimeHelpers.GetObjectValue(Interaction.IIf(transactionType == Tools.TransactionType.AccountsReceivable, (object) "R", (object) "P"))}')"));
  }

  public static void SQLDebuggingHelper(object sender, SqlInfoMessageEventArgs e)
  {
    int num = (int) MessageBox.Show(e.Message);
  }

  internal static bool IsUnderNotice(int InvoiceNumber)
  {
    return Conversions.ToBoolean(Database.Instance.QueryText.PerformScalarQuery($"Select dbo.AccountingIsUnderNotice({InvoiceNumber})"));
  }

  public static void VoidTransaction(int TransactionNumber)
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_VoidJournalTransaction", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandTimeout = 300;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@TRANSACTNUM_VOIDEE", (object) TransactionNumber);
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
      sqlCommand2.CommandText = "spFin_VoidLinkedManualEntries";
      sqlCommand2.CommandType = CommandType.StoredProcedure;
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

  public static int GetOfficeLocationID(Guid OfficeGuid)
  {
    return Conversions.ToInteger(Database.Instance.QueryText.PerformScalarQuery($"Select dbo.GetOfficeLocationID('{OfficeGuid.ToString()}')"));
  }

  public static bool HasSpecialCharacters(string testValue, bool showMessage)
  {
    string[] strArray = new string[31 /*0x1F*/]
    {
      "~",
      "`",
      "!",
      "@",
      "#",
      "$",
      "%",
      "^",
      "&",
      "*",
      "(",
      ")",
      "_",
      "+",
      "=",
      "{",
      "}",
      "[",
      "]",
      "|",
      "\\",
      ":",
      ";",
      "\"",
      "'",
      "<",
      ">",
      ",",
      ".",
      "?",
      "/"
    };
    int index = 0;
    bool flag = false;
    for (; index < strArray.Length; ++index)
    {
      if (Strings.InStr(testValue, strArray[index]) != 0)
      {
        if (showMessage)
        {
          int num = (int) MessageBox.Show("The specified string can not contain special characters!", "Invalid Characters!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        flag = true;
        break;
      }
    }
    return flag;
  }

  public static string Truncate(this string value, int maxLength)
  {
    string str;
    if (string.IsNullOrWhiteSpace(value))
    {
      str = string.Empty;
    }
    else
    {
      value = value.Trim();
      str = value.Length <= maxLength ? value : value.Substring(0, maxLength);
    }
    return str;
  }

  public static string TruncateToLastFour(this string value, char prefixChar = '*')
  {
    string lastFour;
    if (string.IsNullOrWhiteSpace(value))
    {
      lastFour = string.Empty;
    }
    else
    {
      value = value.Trim();
      object obj = (object) (value.Length > 4 ? value.Length - 4 : 0);
      lastFour = $"{prefixChar}{value.Substring(Conversions.ToInteger(obj))}";
    }
    return lastFour;
  }

  public enum EntitySearchType
  {
    None,
    Company,
    CompanyLocations,
    CompanyLines,
    ExpensePayees,
    Insured,
    Intermediary,
    Producer,
    ProducerLocation,
    ThirdParty,
    Users,
    UserGroups,
    CompanyGroup,
    InspectionCompany,
  }

  public enum InterCompanyType
  {
    Payable,
    Receivable,
  }

  public enum ControlVisibility
  {
    Hidden,
    PartiallyObscurred,
    Visible,
  }

  public enum AccountingReportType
  {
    TrialBalance,
    IncomeStatement,
    SixColumnWorksheet,
    BalanceSheet,
    AgingReceivables,
    AgingPayables,
    Schedule1099,
    PremiumLiabilityReport,
  }

  public enum AccountingReportDateRange
  {
    AllDates,
    CurrentMonth,
    CurrentQuarter,
    CurrentYear,
    FiscalToDate,
    UserDefined,
  }

  public enum ExpenseScheduleOccurrenceFrequency
  {
    Daily,
    Weekly,
    EveryTwoWeeks,
    Monthly,
    EveryTwoMonths,
    Quarterly,
    SemiAnnually,
    Annually,
  }

  public enum AccountingMethods
  {
    AccrualBasis,
    CashBasis,
    NoneSpecified,
  }

  internal enum TransactionType
  {
    AccountsReceivable,
    AccountsPayable,
  }
}
