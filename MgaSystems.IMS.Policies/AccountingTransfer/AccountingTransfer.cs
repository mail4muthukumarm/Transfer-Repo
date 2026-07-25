// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Logging;
using MGASystems.IMS.Logging.Administration;
using MGASystems.IMS.Policies.BindPolicy;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Policies.AccountingTransfer;

[LogCategory("Policies.AccountingTransfer.InvoiceCreation", "Policies.AccountingTransfer.InvoiceCreation")]
public class AccountingTransfer : IDisposable
{
  private Guid _quoteGuid;
  private MGASystems.IMS.Policies.Invoices.Invoices _invoices;
  private List<int> _invoiceNumbers;
  private List<int> _officeInvoiceNumbers;
  private dsBindQuote.TransferFeesDataTable _transferFees;
  private SqlTransaction _trans;
  private object _isAccountingPackageActive;
  private SqlCommand _spAccountingTransfer;
  private SqlCommand _spAccountingTransferFees;
  private bool _debug;
  private bool _blackBoxMode;
  internal const string LogKey = "Policies.AccountingTransfer.InvoiceCreation";

  public AccountingTransfer(
    bool debug,
    SqlTransaction trans,
    Guid quoteGuid,
    MGASystems.IMS.Policies.Invoices.Invoices i,
    dsBindQuote.TransferFeesDataTable transferFees)
  {
    this._invoiceNumbers = new List<int>();
    this._officeInvoiceNumbers = new List<int>();
    this._debug = debug;
    this._quoteGuid = quoteGuid;
    this._invoices = i;
    this._transferFees = transferFees;
    this._trans = trans;
  }

  protected SqlTransaction Transaction => this._trans;

  public bool BlackBoxMode
  {
    get => this._blackBoxMode;
    set => this._blackBoxMode = value;
  }

  public List<int> InvoicesNumbers => this._invoiceNumbers;

  public List<int> OfficeInvoiceNumbers => this._officeInvoiceNumbers;

  public bool IsAccountingPackageActive
  {
    get
    {
      if (this._isAccountingPackageActive == null)
        this._isAccountingPackageActive = (object) CurrentUser.Instance.IsAccountingPackageActive;
      return (bool) this._isAccountingPackageActive;
    }
  }

  private static void WriteLog(string message)
  {
    Log.Write(message, new string[1]
    {
      "Policies.AccountingTransfer.InvoiceCreation"
    });
  }

  public void SendInvoices()
  {
    int num1 = 0;
    try
    {
      foreach (AccountingTransferInvoice invoice in (ArrayList) this._invoices)
      {
        ++num1;
        string str1 = Conversions.ToString(num1);
        DateTime now = DateAndTime.Now;
        string str2 = now.ToString();
        MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog($"Transferring invoice #{str1} to accounting ... {str2}");
        invoice.InvoiceNumber = this.TransferInvoice(invoice);
        this._invoiceNumbers.Add(invoice.InvoiceNumber);
        string str3 = Conversions.ToString(invoice.InvoiceNumber);
        now = DateAndTime.Now;
        string str4 = now.ToString();
        MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog($"Invoice #{str3} transferred. {str4}");
        this._officeInvoiceNumbers.Add(DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT OfficeInvoiceNum FROM dbo.tblFin_Invoices WITH(NOLOCK) WHERE InvoiceNum= @invNum", new object[2]
        {
          (object) "@invNum",
          (object) invoice.InvoiceNumber
        }));
        try
        {
          foreach (dsBindQuote.TransferFeesRow transferFee in (TypedTableBase<dsBindQuote.TransferFeesRow>) this._transferFees)
          {
            SqlCommand sqlCommand1 = this.GetspAccountingTransferFees();
            Fee fee = invoice.Fees.FindFee(transferFee.OptionFeeID);
            if (fee != null)
            {
              SqlCommand sqlCommand2 = sqlCommand1;
              int optionFeeId = transferFee.OptionFeeID;
              string str5 = optionFeeId.ToString();
              now = DateAndTime.Now;
              string str6 = now.ToString();
              MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog($"Sending fee #{str5} ... {str6}");
              sqlCommand2.Parameters["@Debug"].Value = (object) this._debug;
              sqlCommand2.Parameters["@OptionFeeID"].Value = (object) transferFee.OptionFeeID;
              sqlCommand2.Parameters["@InvoiceNum"].Value = (object) invoice.InvoiceNumber;
              sqlCommand2.Parameters["@Amount"].Value = (object) Decimal.Multiply(transferFee.Amount, fee.ModFactor);
              sqlCommand2.Parameters["@BillingCode"].Value = (object) invoice.BillingCode;
              optionFeeId = transferFee.OptionFeeID;
              string str7 = optionFeeId.ToString();
              now = DateAndTime.Now;
              string str8 = now.ToString();
              MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog($"Fee #{str7} sent. {str8}");
              DefaultDatabase.ExecuteNonQuery(sqlCommand1.CommandType, sqlCommand1.CommandText, sqlCommand1.CommandTimeout, (CommandArgumentType) 2, new object[1]
              {
                (object) sqlCommand1.Parameters
              });
            }
          }
        }
        finally
        {
          IEnumerator<dsBindQuote.TransferFeesRow> enumerator;
          enumerator?.Dispose();
        }
        MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog("Getting detail count ... " + DateAndTime.Now.ToString());
        int num2 = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM dbo.tblFin_InvoiceDetails WITH(NOLOCK) WHERE InvoiceNum=@invNum", new object[2]
        {
          (object) "@invNum",
          (object) invoice.InvoiceNumber
        });
        string str9 = num2 != 0 ? num2.ToString() : throw new NoInvoiceDetailItemsCreatedException();
        now = DateAndTime.Now;
        string str10 = now.ToString();
        MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog($"Detail count is {str9}... {str10}");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog("Verify premiums ..." + DateAndTime.Now.ToString());
    DefaultDatabase.ExecuteNonQuery("dbo.spAccountingTransfer_VerifyPremiumsTransferred", new object[6]
    {
      (object) "@quoteGuid",
      (object) this._quoteGuid,
      (object) "@debug",
      (object) this._debug,
      (object) "@reVerify",
      (object) false
    });
    DefaultDatabase.ExecuteNonQuery("dbo.spAccountingTransfer_VerifyPremiumsTransferred", new object[6]
    {
      (object) "@quoteGuid",
      (object) this._quoteGuid,
      (object) "@debug",
      (object) this._debug,
      (object) "@reVerify",
      (object) true
    });
    MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog("Verify fees ..." + DateAndTime.Now.ToString());
    DefaultDatabase.ExecuteNonQuery("spAccountingTransfer_VerifyFeesTransferred", new object[2]
    {
      (object) "@quoteGuid",
      (object) this._quoteGuid
    });
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM dbo.tblFin_Invoices WITH(NOLOCK) WHERE QuoteID = (SELECT QuoteID FROM tblQuotes WHERE QuoteGuid = @QG) AND Failed = 0", new object[2]
    {
      (object) "@QG",
      (object) this._quoteGuid
    }) != this._invoices.Count)
      throw new InvalidOperationException("Unexpected number of invoices created");
    MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog("Done! " + DateAndTime.Now.ToString());
  }

  public virtual void PostToJournal()
  {
    if (!this.IsAccountingPackageActive)
      return;
    SqlCommand journalPostingCommand = this.GetJournalPostingCommand();
    int num = 0;
    try
    {
      try
      {
        foreach (int invoicesNumber in this.InvoicesNumbers)
        {
          if (this.PostInvoiceToJournal(invoicesNumber))
          {
            if (invoicesNumber == 0)
              throw new InvalidOperationException("An invoice #0 was detected when trying to post to the journal.");
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._invoices.FindByInvoiceNumber(invoicesNumber).BillingCode, "DPCOM", false) != 0)
            {
              ++num;
              MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog("Posting invoice #" + num.ToString());
              journalPostingCommand.Parameters["@INVOICENUM"].Value = (object) invoicesNumber;
              DefaultDatabase.ExecuteNonQuery(journalPostingCommand.CommandType, journalPostingCommand.CommandText, journalPostingCommand.CommandTimeout, (CommandArgumentType) 2, new object[1]
              {
                (object) journalPostingCommand.Parameters
              });
              MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog($"After post invoice #{num.ToString()}.");
              this.AfterPostInvoice(invoicesNumber, this._trans);
              MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer.WriteLog($"Invoice #{num.ToString()} posted.");
            }
          }
        }
      }
      finally
      {
        List<int>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    finally
    {
      journalPostingCommand.Dispose();
    }
  }

  protected virtual void AfterPostInvoice(int invoiceNum, SqlTransaction trans)
  {
  }

  protected virtual bool PostInvoiceToJournal(int invoiceNum) => true;

  private int TransferInvoice(AccountingTransferInvoice i)
  {
    SqlCommand transferCommmandObject = this.CreateAccountingTransferCommmandObject();
    SqlCommand sqlCommand = transferCommmandObject;
    sqlCommand.Parameters["@Debug"].Value = (object) this._debug;
    sqlCommand.Parameters["@QuoteGuid"].Value = (object) this._quoteGuid;
    Guid guid = CurrentUser.Instance.UserGUID;
    if (guid.Equals(Guid.Empty))
    {
      if (!this.BlackBoxMode)
        throw new InvalidOperationException("CurrentUser.Instance.UserGUID not set");
      guid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT UserGuid FROM dbo.tblUsers WITH(NOLOCK) WHERE UserID = @ID", new object[2]
      {
        (object) "@ID",
        (object) ConfigurationManager.AppSettings["BoundByUserID"] ?? throw new InvalidOperationException("Could not determine the binding user in black box mode")
      });
    }
    sqlCommand.Parameters["@UserGuid"].Value = (object) guid;
    sqlCommand.Parameters["@OfficeID"].Value = (object) i.OfficeID;
    sqlCommand.Parameters["@IsEndorsement"].Value = (object) false;
    sqlCommand.Parameters["@DueDate"].Value = (object) i.DueDate;
    sqlCommand.Parameters["@DateBilled"].Value = (object) i.DateBilled;
    sqlCommand.Parameters["@InstallmentBillingPremiumModFactor"].Value = (object) i.PremiumModFactor;
    sqlCommand.Parameters["@InvoiceComments"].Value = (object) i.Comment;
    sqlCommand.Parameters["@BillingCode"].Value = (object) i.BillingCode;
    if (i.BillToAdditionalInterest)
      sqlCommand.Parameters["@BillToAdditionalInterestID"].Value = (object) i.BillToAdditionalInterestID;
    sqlCommand.CommandTimeout = 300;
    sqlCommand.Parameters["@ModifiesInvoiceNum"].Value = i.ModifiesInvoiceNum == -1 ? (object) null : (object) i.ModifiesInvoiceNum;
    sqlCommand.Parameters["@Amount"].Value = !i.DownpaymentInvoice ? (object) null : (object) i.Amount;
    this.ClientAccountingTransferParameters(transferCommmandObject, i);
    List<DbParameter> parameterList = ExtensionsMethods.ToParameterList((DbParameterCollection) transferCommmandObject.Parameters);
    System.Func<DbParameter, string> keySelector;
    // ISSUE: reference to a compiler-generated field
    if (MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer._Closure\u0024__.\u0024I29\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      keySelector = MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer._Closure\u0024__.\u0024I29\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      MGASystems.IMS.Policies.AccountingTransfer.AccountingTransfer._Closure\u0024__.\u0024I29\u002D0 = keySelector = (System.Func<DbParameter, string>) ([SpecialName] (db) => db.ParameterName);
    }
    Dictionary<string, DbParameter> dictionary = parameterList.ToDictionary<DbParameter, string>(keySelector);
    DefaultDatabase.ExecuteNonQuery(transferCommmandObject.CommandType, transferCommmandObject.CommandText, transferCommmandObject.CommandTimeout, (CommandArgumentType) 2, new object[1]
    {
      (object) dictionary
    });
    return Conversions.ToInteger(dictionary["@InvoiceNum"].Value);
  }

  protected virtual SqlCommand CreateAccountingTransferCommmandObject()
  {
    if (this._spAccountingTransfer == null)
    {
      this._spAccountingTransfer = new SqlCommand("dbo.[spAccountingTransfer]", this._trans.Connection);
      SqlCommand accountingTransfer = this._spAccountingTransfer;
      accountingTransfer.Transaction = this._trans;
      accountingTransfer.CommandType = CommandType.StoredProcedure;
      accountingTransfer.CommandTimeout = 300;
      accountingTransfer.Parameters.Add(new SqlParameter("@Debug", SqlDbType.Bit, 1));
      accountingTransfer.Parameters.Add(new SqlParameter("@QuoteGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/));
      accountingTransfer.Parameters.Add(new SqlParameter("@UserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/));
      accountingTransfer.Parameters.Add(new SqlParameter("@OfficeID", SqlDbType.Int, 4));
      accountingTransfer.Parameters.Add(new SqlParameter("@IsEndorsement", SqlDbType.Bit, 1));
      accountingTransfer.Parameters.Add(new SqlParameter("@InstallmentBillingPremiumModFactor", SqlDbType.Decimal, 9, ParameterDirection.Input, false, (byte) 20, (byte) 19, string.Empty, DataRowVersion.Current, (object) null));
      accountingTransfer.Parameters.Add(new SqlParameter("@DueDate", SqlDbType.DateTime, 8));
      accountingTransfer.Parameters.Add(new SqlParameter("@DateBilled", SqlDbType.DateTime, 8));
      accountingTransfer.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Money, 4));
      accountingTransfer.Parameters.Add(new SqlParameter("@BillingCode", SqlDbType.VarChar, 5));
      accountingTransfer.Parameters.Add(new SqlParameter("@InvoiceNum", SqlDbType.Int, 4, ParameterDirection.Output, false, (byte) 0, (byte) 0, string.Empty, DataRowVersion.Current, (object) null));
      accountingTransfer.Parameters.Add(new SqlParameter("@InvoiceComments", SqlDbType.VarChar, 500));
      accountingTransfer.Parameters.Add(new SqlParameter("@ModifiesInvoiceNum", SqlDbType.Int, 4));
      accountingTransfer.Parameters.Add(new SqlParameter("@BillToAdditionalInterestID", SqlDbType.Int, 4));
    }
    return this._spAccountingTransfer;
  }

  protected virtual void ClientAccountingTransferParameters(
    SqlCommand cmd,
    AccountingTransferInvoice i)
  {
  }

  protected virtual SqlCommand GetJournalPostingCommand()
  {
    return new SqlCommand("dbo.[spFin_PostInvoice]", this._trans.Connection)
    {
      CommandType = CommandType.StoredProcedure,
      Transaction = this._trans,
      CommandTimeout = 300,
      Parameters = {
        new SqlParameter("@INVOICENUM", SqlDbType.Int, 4)
      }
    };
  }

  private SqlCommand GetspAccountingTransferFees()
  {
    if (this._spAccountingTransferFees == null)
    {
      this._spAccountingTransferFees = new SqlCommand("dbo.[spAccountingTransfer_Fees]", this._trans.Connection);
      SqlCommand accountingTransferFees = this._spAccountingTransferFees;
      accountingTransferFees.CommandType = CommandType.StoredProcedure;
      accountingTransferFees.Transaction = this._trans;
      accountingTransferFees.CommandTimeout = 300;
      accountingTransferFees.Parameters.Add(new SqlParameter("@Debug", SqlDbType.Bit, 1));
      accountingTransferFees.Parameters.Add(new SqlParameter("@OptionFeeID", SqlDbType.Int, 4));
      accountingTransferFees.Parameters.Add(new SqlParameter("@InvoiceNum", SqlDbType.Int, 4));
      accountingTransferFees.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Money, 4));
      accountingTransferFees.Parameters.Add(new SqlParameter("@BillingCode", SqlDbType.VarChar, 5));
    }
    return this._spAccountingTransferFees;
  }

  public void Dispose()
  {
    if (this._spAccountingTransfer != null)
      this._spAccountingTransfer.Dispose();
    if (this._spAccountingTransferFees == null)
      return;
    this._spAccountingTransferFees.Dispose();
  }
}
