// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyBusinessObjects.QuoteExtendedData
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data.DataMapping;
using System;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyBusinessObjects;

[TableMapping("dbo.tblQuotes2")]
public class QuoteExtendedData : BaseDataObject
{
  private int _quoteId;
  private Quote _quote;

  public QuoteExtendedData(int quoteId)
  {
    this._quoteId = -1;
    this.AllowMissingRecord = true;
    this._quoteId = quoteId;
  }

  public QuoteExtendedData(Quote quote)
    : this(quote.QuoteID)
  {
    this._quote = quote;
  }

  public int QuoteID
  {
    get => this._quoteId;
    set
    {
      this._quoteId = this._quoteId != -1 ? value : throw new InvalidOperationException($"Specified {nameof (QuoteExtendedData)} {this._quoteId} has already been initialized");
    }
  }

  public Quote ParentQuote
  {
    get
    {
      if (this._quote == null && this._quoteId > -1)
        this._quote = ObjectFactory.Instance.CreateObjectAs<Quote>(new object[1]
        {
          (object) this.QuoteID
        });
      return this._quote;
    }
    set
    {
      if (value == null || !this._quoteId.Equals(value.QuoteID))
        return;
      this._quote = value;
    }
  }

  [TableFieldMapping]
  public Guid? ExpiringCompanyLocationGuid
  {
    get
    {
      return this.GetField<Guid?>(nameof (ExpiringCompanyLocationGuid), nameof (ExpiringCompanyLocationGuid));
    }
  }

  [TableFieldMapping]
  public int? NewProducerContactOnBOR
  {
    get => this.GetField<int?>(nameof (NewProducerContactOnBOR), nameof (NewProducerContactOnBOR));
  }

  [TableFieldMapping]
  public string OriginalPolicyNumber
  {
    get => this.GetField<string>(nameof (OriginalPolicyNumber), nameof (OriginalPolicyNumber));
  }

  [TableFieldMapping]
  public Guid? RetailerContactGuid
  {
    get => this.GetField<Guid?>(nameof (RetailerContactGuid), nameof (RetailerContactGuid));
  }

  [TableFieldMapping]
  public string CurrencyCode => this.GetField<string>(nameof (CurrencyCode), nameof (CurrencyCode));

  [TableFieldMapping]
  public string SettlementCurrencyCode
  {
    get => this.GetField<string>(nameof (SettlementCurrencyCode), nameof (SettlementCurrencyCode));
  }

  [TableFieldMapping]
  public bool WaivedOriginalPremium
  {
    get => this.GetField<bool>(nameof (WaivedOriginalPremium), nameof (WaivedOriginalPremium));
  }

  private bool GetAddressFields()
  {
    return this.RetrieveFields(new string[6]
    {
      "TaxAddress1",
      "TaxAddress2",
      "TaxCity",
      "TaxCounty",
      "TaxState",
      "TaxZip"
    });
  }

  public string TaxAddress1
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (TaxAddress1), nameof (TaxAddress1));
    }
  }

  public string TaxAddress2
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (TaxAddress2), nameof (TaxAddress2));
    }
  }

  public string TaxCity
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (TaxCity), nameof (TaxCity));
    }
  }

  public string TaxCounty
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (TaxCounty), nameof (TaxCounty));
    }
  }

  public string TaxState
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (TaxState), nameof (TaxState));
    }
  }

  public string TaxZip
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (TaxZip), nameof (TaxZip));
    }
  }
}
