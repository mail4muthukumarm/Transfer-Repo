// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.AccountingTransfer.AccountingTransferInvoice
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Policies.AccountingTransfer;

public class AccountingTransferInvoice
{
  private static Dictionary<int, string> _billingTypeMap;
  private DateTime _dueDate;
  private DateTime _dateBilled;
  private Decimal _premiumModFactor;
  private int _invoiceNumber;
  private Fees _fees;
  private Decimal _amount;
  private bool _downpaymentInvoice;
  private int _billingTypeID;
  private int _officeID;
  private int _modifiesInvoiceNum;
  private string _comment;
  private int _billToAdditionalInterestID;

  public static Dictionary<int, string> BillingTypeMap
  {
    get
    {
      if (AccountingTransferInvoice._billingTypeMap == null)
      {
        try
        {
          AccountingTransferInvoice._billingTypeMap = new Dictionary<int, string>();
          DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT BillingTypeID, BillingCode FROM dbo.lstBillingTypes");
          try
          {
            foreach (DataRow row in dataTable.Rows)
              AccountingTransferInvoice._billingTypeMap.Add(Conversions.ToInteger(row["BillingTypeID"]), row.Field<string>("BillingCode"));
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          AccountingTransferInvoice._billingTypeMap.Clear();
          AccountingTransferInvoice._billingTypeMap.Add(1, "DBCOM");
          AccountingTransferInvoice._billingTypeMap.Add(2, "DBMGA");
          AccountingTransferInvoice._billingTypeMap.Add(3, "AGNCY");
          AccountingTransferInvoice._billingTypeMap.Add(4, "AGNCE");
          AccountingTransferInvoice._billingTypeMap.Add(5, "AGNCN");
          AccountingTransferInvoice._billingTypeMap.Add(6, "DPCOM");
          AccountingTransferInvoice._billingTypeMap.Add(7, "AGNGD");
          AccountingTransferInvoice._billingTypeMap.Add(8, "DBFUL");
          ProjectData.ClearProjectError();
        }
      }
      return AccountingTransferInvoice._billingTypeMap;
    }
  }

  public bool BillToAdditionalInterest => this._billToAdditionalInterestID != -1;

  public int BillToAdditionalInterestID
  {
    get => this._billToAdditionalInterestID;
    set => this._billToAdditionalInterestID = value;
  }

  public int ModifiesInvoiceNum
  {
    get => this._modifiesInvoiceNum;
    set => this._modifiesInvoiceNum = value;
  }

  public string BillingCode
  {
    get
    {
      if (this._billingTypeID <= 0)
        throw new InvalidOperationException("BillingTypeID was not set before reading BillingCode property.");
      string billingCode = (string) null;
      AccountingTransferInvoice.BillingTypeMap.TryGetValue(this._billingTypeID, out billingCode);
      return billingCode;
    }
  }

  public string Comment
  {
    get => this._comment;
    set => this._comment = value;
  }

  public int BillingTypeID
  {
    get => this._billingTypeID;
    set => this._billingTypeID = value;
  }

  public int OfficeID
  {
    get => this._officeID;
    set => this._officeID = value;
  }

  public bool DownpaymentInvoice
  {
    get => this._downpaymentInvoice;
    set => this._downpaymentInvoice = value;
  }

  public DateTime DateBilled
  {
    get => this._dateBilled;
    set => this._dateBilled = value;
  }

  public DateTime DueDate
  {
    get => this._dueDate;
    set => this._dueDate = value;
  }

  public Decimal Amount
  {
    get => this._amount;
    set => this._amount = value;
  }

  public Decimal PremiumModFactor
  {
    get => this._premiumModFactor;
    set => this._premiumModFactor = value;
  }

  public int InvoiceNumber
  {
    get => this._invoiceNumber;
    set => this._invoiceNumber = value;
  }

  public Fees Fees => this._fees;

  public void AddFee(Fee f) => this._fees.AddFee(f);

  public AccountingTransferInvoice()
  {
    this._fees = new Fees();
    this._modifiesInvoiceNum = -1;
    this._billToAdditionalInterestID = -1;
  }

  public AccountingTransferInvoice(AccountingTransferInvoice otherInvoice)
  {
    this._fees = new Fees();
    this._modifiesInvoiceNum = -1;
    this._billToAdditionalInterestID = -1;
    this.BillToAdditionalInterestID = otherInvoice.BillToAdditionalInterestID;
    this.ModifiesInvoiceNum = otherInvoice.ModifiesInvoiceNum;
    this.Comment = otherInvoice.Comment;
    this.BillingTypeID = otherInvoice.BillingTypeID;
    this.OfficeID = otherInvoice.OfficeID;
    this.DownpaymentInvoice = otherInvoice.DownpaymentInvoice;
    this.DateBilled = otherInvoice.DateBilled;
    this.DueDate = otherInvoice.DueDate;
    this.Amount = otherInvoice.Amount;
    this.PremiumModFactor = otherInvoice.PremiumModFactor;
    this.InvoiceNumber = otherInvoice.InvoiceNumber;
    try
    {
      foreach (Fee fee in (List<Fee>) otherInvoice.Fees)
        this.Fees.Add(fee);
    }
    finally
    {
      List<Fee>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }
}
