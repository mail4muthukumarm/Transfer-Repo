// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.ClassObjects.Utility
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.Exceptions;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Core.Utilities;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.PolicyServices;
using MGASystems.IMS.Accounting.SharedForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.ClassObjects;

[SecureResource("{0B58895D-6E5A-4d87-AC38-278050163B7D}", "GL Access Rights", "Users with this permission are granted access to the general ledger functions within the accounting system.", "Accounting")]
[SecureResource("{7554946B-BE1A-40dc-ADDE-39DFED664F8A}", "Billing Date Change Rights", "Grants permission to change the billing date of an invoice through the accounting policy inquiry screen.", "Accounting")]
[SecureResource("{90D526A0-268E-4a6b-8BFC-ABF743361AA4}", "Due Date Change Rights", "Grants permission to change the due date of an invoice through the policy inquiry screen.", "Accounting")]
[SecureResource("{5AE7C614-A609-4ab5-A960-171E18062414}", "Transaction Date Change Rights", "Grants permission to change the transaction date of an invoice through the policy inquiry screen.", "Accounting")]
[SecureResource("{6A42AE28-3617-4dfe-BC40-AC979EA71ADC}", "Posting Bank Override Rights", "Determines whether a user has rights to change the bank to which a transaction is posted.", "Accounting")]
[SecureResource("{2FD97FF8-9A8C-4b9e-8D2B-88603D43D796}", "Change Accounting Periods", "Determines whether a user has rights to change the accounting periods.", "Accounting")]
[SecureResource("{D7D3EE93-2CC6-45d7-B3D8-78394F438910}", "Reinstate Underwriting NOC", "Determines whether a user has rights to reinstate a policy that is under notice for underwriting reasons from the accounting policy inquiry screen.", "Accounting")]
[SecureResource("{EBDEB8A0-B1BC-4c82-AA7E-43DD435F0243}", "Negative Posting Rights", "Determines whether a user has rights to post negative amounts against positive balances or vice versa.", "Accounting")]
[SecureResource("{091A13EC-A3E5-4c41-A72A-B3C0901064E6}", "Check Printer Administration Rights", "Determines whether a users has rights to view and edit the check printer settings.", "Accounting")]
[SecureResource("{AB8DF485-AE93-450f-A34A-CC79B361F59A}", "Post Transaction Rights", "Determines whether or not a user has rights to post a/r and a/p within the IMS.", "Accounting")]
[SecureResource("{FE58A2D8-3233-4E0B-A649-88BF41958575}", "Post AP Transaction Rights", "Determines whether or not a user has rights to post a/p within the IMS.", "Accounting")]
[SecureResource("{1CA15155-6B68-4851-A62B-B2F071BE2293}", "Post AR Transaction Rights", "Determines whether or not a user has rights to post a/r within the IMS.", "Accounting")]
[SecureResource("{3107D19D-141A-4d05-9870-74956C181765}", "Write-Off Settings Management", "Determines whether or not the user can use the direct bill payables utility.", "Accounting")]
[SecureResource("{3A8C6F34-D03A-449E-9DB1-BBC43F26B8D8}", "Excel AP/AR Import Rights", "Determines whether or not the user can use the Excel Import Wizard.", "Accounting")]
[SecureResource("{E4D5F3A2-78FF-4628-8DAE-4CCD0EA466FD}", " Direct Bill Excel AP/AR Import Rights", "Determines whether or not the user can use the Direct Bill Excel Import Wizard.", "Accounting")]
[SecureResource("{F4EA2CF0-C1F6-44F0-AB91-35CCB20E9CD1}", "Search Transaction Rights", "Determines whether or not the user can use the search transaction utility from within IMS Accounting.", "Accounting")]
[SecureResource("{950FB803-408B-460F-A9D0-238435BF3203}", "Direct Bill Payable Utility Rights", "Determines whether or not the user can use the direct bill payables utility.", "Accounting")]
[SecureResource("{4189A3B5-B157-4284-8B73-3DDFDE602B85}", "ACH Settings Management Rights", "Determines if users can access the ACH Settings Management screen.", "Accounting")]
[SecureResource("{DA6E30C6-7098-4CF6-863A-3B07F5FD10A4}", "ACH Export Rights", "Determines if users can access the ACH Export screen to export.", "Accounting")]
[SecureResource("{D0C06931-0DC8-408F-95D0-5BC2C3B1D750}", "ACH Statement Utility Rights", "Determines if users can access the ACH Statement Utility screen to send ACH payment reports.", "Accounting")]
[SecureResource("{F77001F8-786D-48D8-9C32-2EFA7CAD4FEA}", "ACH Statment Utility Report Change Rights", "Determines whether or not the user can change statement utility report used.", "Accounting")]
[SecureResource("{B5B5FE6B-D355-4746-B8BB-5BE2D78DDB04}", "W9 Entity Edit Rights", "Determines whether or not the user can access the W9 entity settings screen.", "Accounting")]
public sealed class Utility
{
  private const int CommandTimeout = 300;
  public const string GLACCESSRIGHTS = "{0B58895D-6E5A-4d87-AC38-278050163B7D}";
  public const string REOPENACCOUNTINGPERIOD = "{7BB4E1A8-F44D-49d6-913A-494A8C63FA46}";
  public const string WRITEOFFRIGHTS = "{0D8AB572-A12A-4386-8B58-EA1390F5EF81}";
  public const string WRITEOFFTHRESHOLDOVERRIDE = "{756F0D0D-A87C-4d4a-887E-B6A265CEEF1F}";
  public const string BILLINGDATECHANGERIGHTS = "{7554946B-BE1A-40dc-ADDE-39DFED664F8A}";
  public const string DUEDATECHANGERIGHTS = "{90D526A0-268E-4a6b-8BFC-ABF743361AA4}";
  public const string TRANSACTIONDATECHANGERIGHTS = "{5AE7C614-A609-4ab5-A960-171E18062414}";
  public const string ZERORECEIVABLEOVERRIDE = "{B0032CCA-AE39-4fcc-A6E8-51811B8F7EF7}";
  public const string POSTINGBANKOVERRIDE = "{6A42AE28-3617-4dfe-BC40-AC979EA71ADC}";
  public const string EXTENDEDSETTINGSMANAGEMENT = "{3519F03A-EFAD-440d-8105-037D44565571}";
  public const string CHANGEACCOUNTINGPERIODS = "{2FD97FF8-9A8C-4b9e-8D2B-88603D43D796}";
  public const string REINSTATEUNDERWRITING = "{D7D3EE93-2CC6-45d7-B3D8-78394F438910}";
  public const string POSTINGSIGNREVERSALRIGHTS = "{EBDEB8A0-B1BC-4c82-AA7E-43DD435F0243}";
  public const string CHECKPRINTERSETTINGRIGHTS = "{091A13EC-A3E5-4c41-A72A-B3C0901064E6}";
  public const string POSTTRANSACTIONRIGHTS = "{AB8DF485-AE93-450f-A34A-CC79B361F59A}";
  public const string AP_POSTTRANSACTIONRIGHTS = "{FE58A2D8-3233-4E0B-A649-88BF41958575}";
  public const string AR_POSTTRANSACTIONRIGHTS = "{1CA15155-6B68-4851-A62B-B2F071BE2293}";
  public const string TRANSACTIONBUILDERRIGHTS = "{5389EE28-AD3B-4233-B7A1-557D29CEB138}";
  public const string WRITEOFFSETTINGSRIGHTS = "{3107D19D-141A-4d05-9870-74956C181765}";
  public const string AR_SUMMARYVIEW = "AR_SUMMARYVIEW_v3.lyt";
  public const string AR_DETAILVIEW = "AR_DETAILVIEW_v3.lyt";
  public const string AP_SUMMARYVIEW = "AP_SUMMARYVIEW_v3.lyt";
  public const string AP_DETAILVIEW = "AP_DETAILVIEW_v3.lyt";
  public const string ADVANCEDPOLICYSEARCHRIGHTS = "{C6E6F51E-79FC-42DE-A122-D497F2CF4F55}";
  public const string OVERRIDECHECKADDRESSPAYEE = "{DF7A724E-33F9-445B-901C-CF77C8251F3F}";
  public const string DIRECTBILLPAYABLEUTILITYRIGHTS = "{950FB803-408B-460F-A9D0-238435BF3203}";
  public const string EXCELIMPORTRIGHTS = "{3A8C6F34-D03A-449E-9DB1-BBC43F26B8D8}";
  public const string DB_EXCELIMPORTRIGHTS = "{E4D5F3A2-78FF-4628-8DAE-4CCD0EA466FD}";
  public const string EXCEEDRECEIVABLERIGHTS = "{BA74605C-2DAA-462A-B167-D38E29BF9E61}";
  public const string BATCHLOCKSETTINGNAME = "InvoiceIssueBatchLock";
  public const string POLICYINQUIRY_FORCECOMMRIGHTS = "{EFC403E9-855D-43E0-8068-FD2AA7E813CF}";
  public const string POLICYINQUIRY_VIEWINVOICEACTIVITY = "{515B1DDA-7681-4739-9A5A-58253EB463F5}";
  public const string POLICYINQUIRY_REINSTATEPOLICY = "{16C4CBCA-7EDE-411D-A697-014313B0F4BA}";
  public const string POLICYINQUIRY_ISSUEMANUALNOC = "{26BCD36F-B9A5-43AC-8AA4-A0968C0C1984}";
  public const string POLICYINQUIRY_VIEWINVOICE = "{16BEA76B-5F19-4B0C-A8C3-61CAD052E843}";
  public const string POLICYINQUIRY_REPRINTNOC = "{D31A5BA4-8991-4F6A-8DA1-0144565BB1AD}";
  public const string SEARCHTRANSACTION_RIGHTS = "{F4EA2CF0-C1F6-44F0-AB91-35CCB20E9CD1}";
  public const string VEIWINVOICEPAYEE_RIGHTS = "{C728610C-7B96-4779-99BC-934C791E05BF}";
  public const string PRINTPOLICYINQUIRY_RIGHTS = "{7F7A3D9F-DBC1-4910-BAC2-F70326E6D7B4}";
  public const string COSTCENTERDATASERVICE_RIGHTS = "{6EA9ECFF-49EB-49A4-8076-0D2ED6147DE7}";
  public const string REBUILDWORKING_RIGHTS = "{F8A3D1A6-84C0-4296-93AC-B0F95F5446ED}";
  public const string REFRESHENTITYLOOKUP_RIGHTS = "{C1832FBF-7793-4844-9211-708267099FEA}";
  public const string ACHSETTINGSMANAGEMENT_RIGHTS = "{4189A3B5-B157-4284-8B73-3DDFDE602B85}";
  public const string ACHEXPORTMANAGEMENT_RIGHTS = "{DA6E30C6-7098-4CF6-863A-3B07F5FD10A4}";
  public const string ACHSTATEMENTUTILITYRPTCHG_RIGHTS = "{F77001F8-786D-48D8-9C32-2EFA7CAD4FEA}";
  public const string ACHSTATEMENTUTILITY_RIGHTS = "{D0C06931-0DC8-408F-95D0-5BC2C3B1D750}";
  public const string USEBANKCURRENCY_RIGHTS = "{7870E532-9754-4EF7-8271-AD3BD7EBB942}";
  public const string W9ENTITYVIEWER_RIGHTS = "{B5B5FE6B-D355-4746-B8BB-5BE2D78DDB04}";
  public const string SETTLEMENTAPPROVALVIEW_RIGHTS = "{0B82413E-D6D3-4F80-81E2-27BC5D5D3EEC}";
  public const string FLATCANCELCONFIG_RIGHTS = "{9F7DFA24-F2E6-419B-A7B3-FFA16F2A98B3}";

  public static string GetEntityName(Guid EntityGUID)
  {
    using (SqlCommand sqlCommand = new SqlCommand($"Select dbo.GetEntityName('{EntityGUID.ToString()}')", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      try
      {
        sqlCommand.Connection.Open();
        sqlCommand.CommandType = CommandType.Text;
        object obj = sqlCommand.ExecuteScalar();
        return obj.Equals((object) DBNull.Value) ? string.Empty : (string) obj;
      }
      catch (SqlException ex)
      {
        throw new AccountingCoreGeneralError($"{StringResourceManager.GetString("GET_ENTITYNAME_ERROR")} {ex.Errors[0].Message}");
      }
    }
  }

  public static string GetGLOfficeName(int GlCompanyId)
  {
    return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT location from tblClientOffices where OfficeId = @glco", new object[2]
    {
      (object) "@glco",
      (object) GlCompanyId
    });
  }

  public void CheckTheBooks(SqlCommand cmd)
  {
    cmd.Parameters.Clear();
    cmd.CommandText = "spFin_CheckTheBooks";
    cmd.CommandType = CommandType.StoredProcedure;
    if ((Decimal) cmd.ExecuteScalar() != 0M)
      throw new TransactionOutOfBalanceException("The transaction you are trying to save will leave the books in an unbalanced state. This transaction will be rolled back.");
  }

  public static Decimal GetWriteOffThreshold(
    Utility.TransactionType transactionType,
    int glCompanyId)
  {
    return DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "Select dbo.GetWriteOffThreshold(@glco, @trxType)", new object[4]
    {
      (object) "@glco",
      (object) glCompanyId,
      (object) "@trxType",
      transactionType == Utility.TransactionType.AccountsReceivable ? (object) "R" : (object) "P"
    });
  }

  internal static void WriteOffTransaction(
    int glCompanyId,
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal Amount,
    int glAccountId,
    string Comments,
    Utility.TransactionType transactionType,
    Guid entityGuid)
  {
    Utility.WriteOffTransaction_TransactNum(glCompanyId, invoiceNumber, chargeCode, companyLineGuid, Amount, glAccountId, Comments, transactionType, Guid.Empty, entityGuid);
  }

  internal static void WriteOffTransaction(
    int glCompanyId,
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal Amount,
    int glAccountId,
    string Comments,
    Utility.TransactionType transactionType,
    Guid payeeGuid,
    Guid entityGuid)
  {
    Utility.WriteOffTransaction_TransactNum(glCompanyId, invoiceNumber, chargeCode, companyLineGuid, Amount, glAccountId, Comments, transactionType, payeeGuid, entityGuid);
  }

  internal static void WriteOffTransaction(
    int glCompanyId,
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal Amount,
    int glAccountId,
    string Comments,
    Utility.TransactionType transactionType,
    Guid entityGuid,
    out int transactNum)
  {
    transactNum = Utility.WriteOffTransaction_TransactNum(glCompanyId, invoiceNumber, chargeCode, companyLineGuid, Amount, glAccountId, Comments, transactionType, Guid.Empty, entityGuid);
  }

  internal static void WriteOffTransaction(
    int glCompanyId,
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal Amount,
    int glAccountId,
    string Comments,
    Utility.TransactionType transactionType,
    Guid payeeGuid,
    Guid entityGuid,
    out int transactNum)
  {
    transactNum = Utility.WriteOffTransaction_TransactNum(glCompanyId, invoiceNumber, chargeCode, companyLineGuid, Amount, glAccountId, Comments, transactionType, payeeGuid, entityGuid);
  }

  private static int WriteOffTransaction_TransactNum(
    int glCompanyId,
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Decimal Amount,
    int glAccountId,
    string Comments,
    Utility.TransactionType transactionType,
    Guid payeeGuid,
    Guid entityGuid)
  {
    int num1 = -1;
    DateTime dateTime = DateTime.Now;
    using (formSelectDate formSelectDate = new formSelectDate())
    {
      if (formSelectDate.ShowDialog() != DialogResult.OK)
        return -1;
      dateTime = formSelectDate.SelectedDate;
    }
    using (SqlCommand sqlCommand = new SqlCommand("spFin_WriteOffTransaction", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      try
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@invoiceNum", (object) invoiceNumber);
        sqlCommand.Parameters.AddWithValue("@chargeCode", (object) chargeCode);
        sqlCommand.Parameters.AddWithValue("@companyLineGuid", (object) companyLineGuid);
        sqlCommand.Parameters.AddWithValue("@glAcctId", (object) glAccountId);
        sqlCommand.Parameters.AddWithValue("@amount", (object) Amount);
        sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) glCompanyId);
        sqlCommand.Parameters.AddWithValue("@comments", (object) Comments);
        sqlCommand.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
        sqlCommand.Parameters.AddWithValue("@writeOffType", transactionType == Utility.TransactionType.AccountsReceivable ? (object) "AR" : (object) "AP");
        sqlCommand.Parameters.AddWithValue("@transactNum", (object) num1);
        sqlCommand.Parameters.AddWithValue("@payeeGuid", (object) payeeGuid);
        sqlCommand.Parameters.AddWithValue("@writeOffDate", (object) dateTime);
        sqlCommand.Parameters.AddWithValue("@entityGuid", (object) entityGuid);
        sqlCommand.Parameters["@transactNum"].Direction = ParameterDirection.Output;
        sqlCommand.Connection.Open();
        sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
        sqlCommand.ExecuteNonQuery();
        int int32 = Convert.ToInt32(sqlCommand.Parameters["@transactNum"].Value);
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Parameters.Clear();
        sqlCommand.CommandText = $"Select dbo.CheckDistributionBalance({int32})";
        if (Convert.ToInt32(sqlCommand.ExecuteScalar()) != 1)
        {
          sqlCommand.Transaction.Rollback();
          sqlCommand.Connection.Close();
          int num2 = (int) MessageBox.Show("An error has occurred while trying to post this transaction. The posting distribution would not balance. To ensure data integrity this transaction has been rolled back.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return -1;
        }
        sqlCommand.Transaction.Commit();
        if (MessageBox.Show("Do you wish to add a comment to the write-off transaction", "Add Comment?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          using (formEditTransactionComment transactionComment = new formEditTransactionComment(int32))
          {
            int num3 = (int) transactionComment.ShowDialog();
          }
        }
        return int32;
      }
      catch
      {
        if (sqlCommand.Transaction != null)
          sqlCommand.Transaction.Rollback();
        throw;
      }
    }
  }

  public static Utility.EntityType GetEntityType(Guid entityGuid)
  {
    string empty = string.Empty;
    string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetEntityType(@eg)", new object[2]
    {
      (object) "eg",
      (object) entityGuid.ToString()
    }).Trim();
    Utility.EntityType entityType;
    if (str != null)
    {
      switch (str.Length)
      {
        case 1:
          switch (str[0])
          {
            case '3':
              entityType = Utility.EntityType.ThirdParty;
              goto label_23;
            case 'B':
              entityType = Utility.EntityType.ProducerLocation;
              goto label_23;
            case 'C':
              entityType = Utility.EntityType.CompanyLine;
              goto label_23;
            case 'F':
              entityType = Utility.EntityType.FinanceCompany;
              goto label_23;
            case 'G':
              entityType = Utility.EntityType.UserGroup;
              goto label_23;
            case 'I':
              entityType = Utility.EntityType.Insured;
              goto label_23;
            case 'P':
              entityType = Utility.EntityType.Producer;
              goto label_23;
            case 'S':
              entityType = Utility.EntityType.InspectionCompany;
              goto label_23;
            case 'U':
              entityType = Utility.EntityType.User;
              goto label_23;
            case 'X':
              entityType = Utility.EntityType.ExpensePayee;
              goto label_23;
          }
          break;
        case 2:
          switch (str[1])
          {
            case 'G':
              if (str == "CG")
              {
                entityType = Utility.EntityType.CompanyGroup;
                goto label_23;
              }
              break;
            case 'L':
              if (str == "CL")
              {
                entityType = Utility.EntityType.CompanyLocation;
                goto label_23;
              }
              break;
            case 'N':
              if (str == "IN")
              {
                entityType = Utility.EntityType.Intermediary;
                goto label_23;
              }
              break;
            case 'O':
              if (str == "CO")
              {
                entityType = Utility.EntityType.Company;
                goto label_23;
              }
              break;
          }
          break;
      }
    }
    entityType = Utility.EntityType.None;
label_23:
    return entityType;
  }

  public static dsPaymentMethods GetEntityPaymentMethods(Guid entityGuid, int glCompanyId)
  {
    dsPaymentMethods entityPaymentMethods = new dsPaymentMethods();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    using (SqlCommand sqlCommand = new SqlCommand("spFin_GetEntityPaymentMethods", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@entityGuid", (object) entityGuid);
      sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) glCompanyId);
      sqlDataAdapter.SelectCommand = sqlCommand;
      try
      {
        sqlDataAdapter.Fill((DataTable) entityPaymentMethods.PaymentMethods);
      }
      finally
      {
        sqlDataAdapter.Dispose();
      }
    }
    return entityPaymentMethods;
  }

  public static dsPaymentMethods GetEntityPaymentMethods(
    Guid entityGuid,
    int glCompanyId,
    int bankGlAccountId)
  {
    dsPaymentMethods entityPaymentMethods = new dsPaymentMethods();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    using (SqlCommand sqlCommand = new SqlCommand("spFin_GetEntityPaymentMethods", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Parameters.AddWithValue("@entityGuid", (object) entityGuid);
      sqlCommand.Parameters.AddWithValue("@glCompanyId", (object) glCompanyId);
      sqlCommand.Parameters.AddWithValue("@bankGlAcctId", (object) bankGlAccountId);
      sqlDataAdapter.SelectCommand = sqlCommand;
      try
      {
        sqlDataAdapter.Fill((DataTable) entityPaymentMethods.PaymentMethods);
      }
      finally
      {
        sqlDataAdapter.Dispose();
      }
    }
    return entityPaymentMethods;
  }

  public static void ShowPolicyInquiry(int quoteControlNumber, int glCompanyId)
  {
    Form form = ObjectFactory.Instance.CreateForm(typeof (formPolicyInquiry), new object[2]
    {
      (object) quoteControlNumber,
      (object) glCompanyId
    });
    form.MdiParent = MDIControls.Instance.MDIParent;
    form.Show();
  }

  public static Assembly LoadComponentAssembly(object sender, ResolveEventArgs args)
  {
    return Assembly.GetExecutingAssembly();
  }

  public static void DeleteReceivableWorksheet(int entryId)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_DeleteSavedRemittanceWorksheet", new object[2]
    {
      (object) "@entryid",
      (object) entryId
    });
  }

  public static void DeletePayablesWorksheet(int entryId)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_DeleteSavedPayablesWorksheet", new object[2]
    {
      (object) "@entryid",
      (object) entryId
    });
  }

  public static void DeleteAccountingWorksheet(int entryId)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_DeleteAccountingWorksheet", new object[2]
    {
      (object) "@entryid",
      (object) entryId
    });
  }

  public static void DeleteAccountingWorksheet(int entryId, bool isBulk)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_DeleteAccountingWorksheet", new object[4]
    {
      (object) "@entryid",
      (object) entryId,
      (object) "@isBulk",
      (object) isBulk
    });
  }

  [Obsolete("This method has been deprecated. The results it resturns are no longer credible due tio the accounting overhaul.")]
  public static Decimal GetEntityUnAccountedBalance(int glAccountId)
  {
    return Decimal.Parse(Database.Instance.QuerySP.PerformScalarQuery("spFin_UnAccountedAccountBalance", (object) "@glacctid", (object) glAccountId).ToString());
  }

  public static Decimal GetEntityUnAccountedBalance(Guid entityGuid, int glCompanyId)
  {
    return DefaultDatabase.ExecuteScalar<Decimal>("spFin_GetEntityUnaccountedBucketBalance", new object[4]
    {
      (object) "@entityGuid",
      (object) entityGuid,
      (object) "@glcompanyid",
      (object) glCompanyId
    });
  }

  private static bool InternalVoidTransaction(int transactionNumber, bool isOverridingPostDate)
  {
    DateTime voidDate = DateTime.Now;
    if (MessageBox.Show("This will permanently void this transaction, this action can not be undone. Continue?", "Void Transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return false;
    if (isOverridingPostDate && MessageBox.Show("Do you want to override the transaction void date?", "Override Transaction Void Date?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
      using (formSelectDate formSelectDate = new formSelectDate())
      {
        int num = (int) formSelectDate.ShowDialog();
        if (formSelectDate.DialogResult == DialogResult.OK)
          voidDate = formSelectDate.SelectedDate;
      }
    }
    if (DefaultDatabase.HasTransaction)
    {
      Utility.VoidTransaction(transactionNumber, voidDate);
      return true;
    }
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      Utility.VoidTransaction(transactionNumber, voidDate);
      e.Transaction.Commit();
    }));
    return true;
  }

  private static bool VoidTransaction(int transactionNumber, DateTime voidDate)
  {
    List<object> objectList = new List<object>()
    {
      (object) "@TRANSACTNUM_VOIDEE",
      (object) transactionNumber,
      (object) "@USERGUID",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@POSTDATE",
      (object) voidDate
    };
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidJournalTransaction", 300, (CommandArgumentType) 0, objectList.ToArray());
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidLinkedManualEntries", 300, (CommandArgumentType) 0, objectList.ToArray());
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidAppliedUnAccountedLinkedTransactions", 300, (CommandArgumentType) 0, objectList.ToArray());
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidLinkedCommissionTransactions", 300, (CommandArgumentType) 0, objectList.ToArray());
    DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spFin_VoidLinkedTransactionReference", 300, (CommandArgumentType) 0, objectList.ToArray());
    return true;
  }

  public static bool VoidTransaction(int transactionNumber, bool isOverridingPostDate)
  {
    return Utility.InternalVoidTransaction(transactionNumber, isOverridingPostDate);
  }

  public static bool VoidTransaction(int transactionNumber)
  {
    return Utility.InternalVoidTransaction(transactionNumber, false);
  }

  public static Guid GetInsuredFromCode(int insuredId)
  {
    return DefaultDatabase.ExecuteScalar<Guid>("spFin_GetInsuredFromInsuredId", new object[2]
    {
      (object) "@insuredId",
      (object) insuredId
    });
  }

  public static Guid GetDirectBillInsuredRemitterGUID(int controlNumber = -1, string policyNumber = "")
  {
    return DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "select dbo.GetRemitterGuid_ControlOrPolicyNumber(@controlNumber, @policyNumber)", new object[4]
    {
      (object) "@controlNumber",
      (object) (controlNumber == -1 ? SqlInt32.Null : (SqlInt32) controlNumber),
      (object) "@policyNumber",
      (object) (string.IsNullOrEmpty(policyNumber) ? SqlString.Null : (SqlString) policyNumber)
    });
  }

  public static Guid GetProducerLocationFromCode(string producerLocationCode)
  {
    return DefaultDatabase.ExecuteScalar<Guid>("spFin_GetProducerLocationFromProducerLocationCode", new object[2]
    {
      (object) "@producerLocationCode",
      (object) producerLocationCode
    });
  }

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
      Decimal.Parse(val.ToString(), NumberStyles.Any);
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

  public static string RemoveStringSpecialCharacters(string val)
  {
    return DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "Select dbo.RemoveStringSpecialChars(@val)", new object[2]
    {
      (object) "@val",
      (object) val
    });
  }

  public static CheckInformation GetCheckInformation(
    Guid entityGuid,
    int bankGlAccountId,
    string paymentMethod,
    DateTime checkDate,
    bool showWarning)
  {
    formPayeeAddressSelection addressSelection = new formPayeeAddressSelection(entityGuid, showWarning);
    try
    {
      if (addressSelection.ShowDialog() == DialogResult.OK)
      {
        Utility.PaymentMethod paymentMethod1;
        switch (paymentMethod.ToString().ToUpper())
        {
          case "A":
            paymentMethod1 = Utility.PaymentMethod.AutoEFT;
            break;
          case "C":
            paymentMethod1 = Utility.PaymentMethod.Check;
            break;
          case "D":
            paymentMethod1 = Utility.PaymentMethod.Check;
            break;
          case "M":
            paymentMethod1 = Utility.PaymentMethod.ManualTransfer;
            break;
          case "O":
            paymentMethod1 = Utility.PaymentMethod.Offset;
            break;
          default:
            paymentMethod1 = Utility.PaymentMethod.Check;
            break;
        }
        return new CheckInformation(paymentMethod1, entityGuid, checkDate, new GLAccount(bankGlAccountId), Utility.GetEntityName(entityGuid), addressSelection.Address1, addressSelection.Address2, addressSelection.City, addressSelection.State, addressSelection.ZipCode, addressSelection.ZipPlus, addressSelection.PayeeName, addressSelection.CheckMemo);
      }
    }
    finally
    {
      addressSelection.Dispose();
    }
    return (CheckInformation) null;
  }

  public static bool IsReasonNonPayment(int quoteStatusReasonId)
  {
    return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "Select dbo.ReasonIsNonPayment(@qsr)", new object[2]
    {
      (object) "@qsr",
      (object) quoteStatusReasonId
    });
  }

  public static int GetNOCReason(int controlNumber)
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "Select dbo.GetQuoteNOCReasonId(@cn)", new object[2]
    {
      (object) "@cn",
      (object) controlNumber
    });
  }

  public static int GetInvoiceCostCenterId(int invoiceNumber)
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "Select dbo.GetInvoiceCostCenterId(@inv)", new object[2]
    {
      (object) "@inv",
      (object) invoiceNumber
    });
  }

  public static int GetInvoiceControlNumber(int invoiceNumber)
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "Select QuoteControlNum from tblFin_invoices where invoiceNum = @inv", new object[2]
    {
      (object) "@inv",
      (object) invoiceNumber
    });
  }

  public static Guid CloseAccounting => new Guid("{9B9FBC42-68E5-4ad4-9F22-9D725B91066C}");

  public static Guid CloseAllForms => new Guid("{126B923E-6753-4aac-912B-59364CB304AB}");

  public static Guid RemittancePosted => new Guid("{B234AFC2-BF8A-4350-9D0D-8B6C46480A6B}");

  public static Guid ReceivablePosted => new Guid("{29FF21DD-EFCB-4876-85BF-FC601201B5B7}");

  internal static int GetTransactionGLCompanyId(int transactionId)
  {
    return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT dbo.GetTransactionGLCompanyId(@transactNum)", new object[2]
    {
      (object) "@transactNum",
      (object) transactionId
    });
  }

  internal static int GetGLCompanyIdFromControlNumber(int controlNumber)
  {
    return (int) DefaultDatabase.ExecuteScalar(CommandType.Text, "select top 1 officeid from tblclientoffices where officeGuid = (select top 1 QuotingLocationGuid from tblquotes where ControlNo = @controlNo)", new object[2]
    {
      (object) "@controlNo",
      (object) controlNumber
    });
  }

  internal static void SaveLayoutPreference(string fileName, UltraGridLayout layout)
  {
    if (SystemSettings.KeyExists("SAVE_LAYOUT_TODB") && SystemSettings.GetBoolSetting("SAVE_LAYOUT_TODB"))
    {
      Utility.SaveLayoutPreferenceToDatabase(fileName, layout);
    }
    else
    {
      string path1 = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\IMS";
      string path2;
      if (!Directory.Exists(path1))
      {
        Directory.CreateDirectory(path1);
        path2 = $"{path1}\\{fileName}";
      }
      else
      {
        path2 = $"{path1}\\{fileName}";
        if (File.Exists(path2))
          File.Delete(path2);
      }
      layout?.Save(path2);
    }
  }

  private static void SaveLayoutPreferenceToDatabase(string fileName, UltraGridLayout layout)
  {
    MemoryStream memoryStream = new MemoryStream();
    layout.Save((Stream) memoryStream);
    try
    {
      DefaultDatabase.ExecuteNonQuery("spFin_SaveUserLayout", new object[6]
      {
        (object) "@userGUID",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@layoutType",
        (object) fileName,
        (object) "@layoutObject",
        (object) memoryStream.ToArray()
      });
    }
    finally
    {
      memoryStream.Dispose();
    }
  }

  internal static string GetTransactionBuilderLayoutFilePath(string fileName)
  {
    string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\IMS\\{fileName}";
    return File.Exists(path) ? path : string.Empty;
  }

  internal static UltraGridLayout GetTransactionBuilderLayout(string fileName)
  {
    if (SystemSettings.KeyExists("SAVE_LAYOUT_TODB") && SystemSettings.GetBoolSetting("SAVE_LAYOUT_TODB"))
      return Utility.GetTransactionBuilderLayoutDatabase(fileName);
    string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\IMS\\{fileName}";
    UltraGridLayout transactionBuilderLayout = new UltraGridLayout();
    if (!File.Exists(path))
      return (UltraGridLayout) null;
    transactionBuilderLayout.Load(path, (PropertyCategories) -1);
    return transactionBuilderLayout;
  }

  internal static UltraGridLayout GetTransactionBuilderLayoutDatabase(string fileName)
  {
    byte[] buffer = DefaultDatabase.ExecuteScalar<byte[]>("spFin_GetUserLayout", new object[4]
    {
      (object) "@userGUID",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@layoutType",
      (object) fileName
    });
    if (buffer == null || buffer.Length == 0)
      return (UltraGridLayout) null;
    MemoryStream memoryStream = new MemoryStream(buffer);
    try
    {
      UltraGridLayout builderLayoutDatabase = new UltraGridLayout();
      memoryStream.Seek(0L, SeekOrigin.Begin);
      builderLayoutDatabase.Load((Stream) memoryStream, (PropertyCategories) -1);
      return builderLayoutDatabase;
    }
    finally
    {
      memoryStream.Dispose();
    }
  }

  internal static void ResetTransactionBuilderLayouts(params string[] layouts)
  {
    if (SystemSettings.KeyExists("SAVE_LAYOUT_TODB") && SystemSettings.GetBoolSetting("SAVE_LAYOUT_TODB"))
    {
      Utility.ResetTransactionBuilderLayoutsDatabase(layouts);
    }
    else
    {
      string empty = string.Empty;
      for (int index = 0; index < layouts.Length; ++index)
      {
        string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\IMS\\{layouts[index]}";
        if (File.Exists(path))
          File.Delete(path);
      }
    }
  }

  internal static void ResetTransactionBuilderLayoutsDatabase(params string[] layouts)
  {
    for (int index = 0; index < layouts.Length; ++index)
      DefaultDatabase.ExecuteNonQuery("spFin_DeleteUserLayout", new object[4]
      {
        (object) "@userGUID",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@layoutType",
        (object) layouts[index]
      });
  }

  public static bool IssueBatchLock()
  {
    return SystemSettings.KeyExists("InvoiceIssueBatchLock") && SystemSettings.GetBoolSetting("InvoiceIssueBatchLock");
  }

  public static bool TryGetCurrencySymbol(string isoCountryCode, out string symbol)
  {
    symbol = ((IEnumerable<CultureInfo>) CultureInfo.GetCultures(CultureTypes.AllCultures)).Where<CultureInfo>((System.Func<CultureInfo, bool>) (c => !c.IsNeutralCulture)).Select<CultureInfo, RegionInfo>((System.Func<CultureInfo, RegionInfo>) (culture =>
    {
      try
      {
        return new RegionInfo(culture.LCID);
      }
      catch
      {
        return (RegionInfo) null;
      }
    })).Where<RegionInfo>((System.Func<RegionInfo, bool>) (ri => ri != null && ri.ISOCurrencySymbol == isoCountryCode)).Select<RegionInfo, string>((System.Func<RegionInfo, string>) (ri => ri.CurrencySymbol)).FirstOrDefault<string>();
    return symbol != null;
  }

  public static string DataTableToXML(DataTable dt)
  {
    MemoryStream memoryStream = new MemoryStream();
    dt.WriteXml((Stream) memoryStream, XmlWriteMode.WriteSchema);
    memoryStream.Seek(0L, SeekOrigin.Begin);
    return new StreamReader((Stream) memoryStream).ReadToEnd();
  }

  public static DataTable XMLToDataTable(string xmlData)
  {
    StringReader reader = new StringReader(xmlData);
    DataSet dataSet = new DataSet();
    int num = (int) dataSet.ReadXml((TextReader) reader);
    return dataSet.Tables[0];
  }

  public static DateTime GetCurrentQuarterStart()
  {
    DateTime now = DateTime.Now;
    int num = (now.Month - 1) / 3 + 1;
    return new DateTime(now.Year, (num - 1) * 3 + 1, 1);
  }

  public static DateTime GetCurrentQuarterEnd()
  {
    DateTime now = DateTime.Now;
    int num = (now.Month - 1) / 3 + 1;
    return new DateTime(now.Year, (num - 1) * 3 + 1, 1).AddMonths(3).AddDays(-1.0);
  }

  public static string GetManualNOCProcedure()
  {
    return Utility.GetUtilityOverride().GetManualNOCProcedure();
  }

  public static bool IsBase64(string base64String)
  {
    if (!string.IsNullOrEmpty(base64String) && base64String.Length % 4 == 0 && !base64String.Contains(" ") && !base64String.Contains("\t") && !base64String.Contains("\r"))
    {
      if (!base64String.Contains("\n"))
      {
        try
        {
          Convert.FromBase64String(base64String);
          return true;
        }
        catch (Exception ex)
        {
        }
        return false;
      }
    }
    return false;
  }

  private static AccountingCoreUtilityOverrides GetUtilityOverride()
  {
    return ObjectFactory.Instance.CreateObjectAs<AccountingCoreUtilityOverrides>();
  }

  [Flags]
  public enum SearchEntityTypes
  {
    None = 0,
    ShowCompanyGroup = 2,
    ShowCompany = 4,
    ShowCompanyLocations = 8,
    ShowCompanyLines = 16, // 0x00000010
    ShowInsured = 32, // 0x00000020
    ShowIntermediary = 64, // 0x00000040
    ShowProducer = 128, // 0x00000080
    ShowProducerLocation = 256, // 0x00000100
    ShowUsers = 512, // 0x00000200
    ShowUserGroups = 1024, // 0x00000400
    ShowExpensePayees = 2048, // 0x00000800
    Show3rdParty = 4096, // 0x00001000
    ShowFinanceCompanies = 8192, // 0x00002000
    ShowInspectionCompanies = 16384, // 0x00004000
    All = ShowInspectionCompanies | ShowFinanceCompanies | Show3rdParty | ShowExpensePayees | ShowUserGroups | ShowUsers | ShowProducerLocation | ShowProducer | ShowIntermediary | ShowInsured | ShowCompanyLines | ShowCompanyLocations | ShowCompany | ShowCompanyGroup, // 0x00007FFE
  }

  public enum AccountingTransactionType
  {
    None,
    Commission,
    JournalEntry,
    Payable,
    PayableReturnPremium,
    Receivable,
    ReceivableReturnPremium,
    Operating,
  }

  public enum AccountingJournalEntryType
  {
    Invoicing,
    Operating,
  }

  public enum PaymentMethod
  {
    None,
    AutoEFT,
    Check,
    ManualTransfer,
    Offset,
    ACH,
  }

  public enum ReceivablesSearchType
  {
    None,
    ControlNumber,
    InsuredCode,
    InvoiceNumber,
    PolicyNumber,
    ProducerLocationCode,
    Remitter,
    Excel,
  }

  public enum PayablesSearchType
  {
    None,
    ControlNumber,
    InvoiceNumber,
    PolicyNumber,
    Bordereau,
    BordereauPayee,
    Payee,
    FeesFiling,
    Excel,
  }

  public enum TransactionType
  {
    AccountsReceivable,
    AccountsPayable,
  }

  public enum EntityType
  {
    Company,
    CompanyLocation,
    CompanyLine,
    ProducerLocation,
    Insured,
    User,
    UserGroup,
    ExpensePayee,
    ThirdParty,
    Intermediary,
    CompanyGroup,
    Producer,
    FinanceCompany,
    InspectionCompany,
    None,
  }
}
