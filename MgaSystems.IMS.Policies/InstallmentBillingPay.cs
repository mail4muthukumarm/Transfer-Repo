// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.InstallmentBillingPay
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.BusinessObjects;
using MGASystems.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

#nullable disable
namespace MGASystems.IMS.Policies;

public class InstallmentBillingPay
{
  private readonly Guid _quoteOptionGuid;
  private readonly int? _companyInstallmentId;
  private readonly byte? _numPayments;
  private readonly Decimal? _downpayment;
  private readonly byte? _downpaymentBillingTypeId;
  private readonly bool? _singleInvoice;
  private readonly Guid _quoteGuid;

  public InstallmentBillingPay(Guid quoteOptionGuid)
  {
    this._quoteOptionGuid = quoteOptionGuid;
    this._quoteGuid = new QuoteOption(quoteOptionGuid).QuoteGuid;
    DataRow row = DefaultDatabase.ExecuteDataRow("GetOptionInstallmentBillingInfo", new object[2]
    {
      (object) "@QuoteOptionGuid",
      (object) quoteOptionGuid
    });
    this._companyInstallmentId = row.Field<int?>("CompanyInstallmentID");
    this._numPayments = row.Field<byte?>(nameof (NumPayments));
    this._downpayment = row.Field<Decimal?>(nameof (Downpayment));
    this._downpaymentBillingTypeId = row.Field<byte?>("DownpaymentBillingTypeID");
    this._singleInvoice = row.Field<bool?>(nameof (SingleInvoice));
  }

  public Guid QuoteOptionGuid => this._quoteOptionGuid;

  public int? CompanyInstallmentId => this._companyInstallmentId;

  public byte? NumPayments => this._numPayments;

  public Decimal? Downpayment => this._downpayment;

  public byte? DownpaymentBillingTypeId => this._downpaymentBillingTypeId;

  public bool? SingleInvoice => this._singleInvoice;

  public List<InstallmentBillingPay> GetOtherInstallmentBillingOptions
  {
    get
    {
      List<InstallmentBillingPay> installmentBillingOptions = new List<InstallmentBillingPay>();
      try
      {
        foreach (DataRow row in DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteOptionGuid FROM tblQuoteOptions WITH (NOLOCK) WHERE QuoteGuid = @QG AND QuoteOptionGuid <> @QOG", new object[4]
        {
          (object) "@QG",
          (object) this._quoteGuid,
          (object) "@QOG",
          (object) this._quoteOptionGuid
        }).Rows)
        {
          InstallmentBillingPay installmentBillingPay = new InstallmentBillingPay(row.Field<Guid>("QuoteOptionGuid"));
          installmentBillingOptions.Add(installmentBillingPay);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return installmentBillingOptions;
    }
  }

  public bool HasChanges(InstallmentBillingPay other)
  {
    return other == null || !(other.GetType() != typeof (InstallmentBillingPay)) && (Utility.IsNull<int>((object) this.CompanyInstallmentId, -1) != Utility.IsNull<int>((object) other.CompanyInstallmentId, -1) || (int) Utility.IsNull<byte>((object) this.NumPayments, (byte) 0) != (int) Utility.IsNull<byte>((object) other.NumPayments, (byte) 0) || Decimal.Compare(Utility.IsNull<Decimal>((object) this.Downpayment, Decimal.MinValue), Utility.IsNull<Decimal>((object) other.Downpayment, Decimal.MinValue)) != 0 || Utility.IsNull<int>((object) this.DownpaymentBillingTypeId, 0) != Utility.IsNull<int>((object) other.DownpaymentBillingTypeId, 0) || Utility.IsNull<bool>((object) this.SingleInvoice, false) != Utility.IsNull<bool>((object) other.SingleInvoice, false));
  }

  public static void UpdateOtherInstallmentBilling(
    Guid quoteOptionGuid,
    List<InstallmentBillingPay> lst)
  {
    try
    {
      foreach (InstallmentBillingPay installmentBillingPay in lst)
        DefaultDatabase.ExecuteNonQuery("UpdateOptionInstallmentBillingInfo", new object[4]
        {
          (object) "@FromQuoteOptionGuid",
          (object) quoteOptionGuid,
          (object) "@ToQuoteOptionGuid",
          (object) installmentBillingPay.QuoteOptionGuid
        });
    }
    finally
    {
      List<InstallmentBillingPay>.Enumerator enumerator;
      enumerator.Dispose();
    }
  }
}
