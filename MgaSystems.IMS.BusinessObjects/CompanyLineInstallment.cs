// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.CompanyLineInstallment
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Data.DataMapping;
using System;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblCompanyLineInstallments")]
public class CompanyLineInstallment : BaseDataObject
{
  private int? _companyInstallmentID;
  private readonly QuoteOption _quoteOption;
  private CompanyLine _companyLine;
  private InstallmentTransactionDates _transactionDates;

  public CompanyLineInstallment(int companyInstallmentId)
  {
    this._companyInstallmentID = new int?(companyInstallmentId);
  }

  public CompanyLineInstallment(QuoteOption qo)
    : this(qo.CompanyInstallmentID)
  {
    this.AllowMissingRecord = true;
    this._quoteOption = qo;
  }

  internal CompanyLineInstallment(QuoteOption qo, InstallmentTransactionDates transDates)
    : this(qo)
  {
    this._transactionDates = transDates;
  }

  public QuoteOption QuoteOption => this._quoteOption;

  public Quote Quote => this._quoteOption?.Quote;

  public CompanyLine CompanyLine
  {
    get
    {
      if (this._companyLine == null && this.CompanyLineID.HasValue)
        this._companyLine = ObjectFactory.Instance.CreateObjectAs<CompanyLine>((object) this.CompanyLineID.Value);
      return this._companyLine;
    }
  }

  public InstallmentTransactionDates TransactionDates
  {
    get
    {
      if (this._transactionDates == null)
        this._transactionDates = ObjectFactory.Instance.CreateObjectAs<InstallmentTransactionDates>((object) this);
      return this._transactionDates;
    }
    internal set
    {
      if (this._transactionDates != null)
        return;
      this._transactionDates = value;
    }
  }

  [DataKey]
  public int ID
  {
    get
    {
      int? companyInstallmentId;
      return !(companyInstallmentId = this._companyInstallmentID).HasValue ? -1 : companyInstallmentId.GetValueOrDefault();
    }
    protected set
    {
      this._companyInstallmentID = !this._companyInstallmentID.HasValue ? new int?(value) : throw new InvalidOperationException($"Specified CompanyLineInstallment ({this._companyInstallmentID}) has already been initialized");
    }
  }

  internal int? CompanyInstallmentID => this._companyInstallmentID;

  public bool HasInstallmentSetup => this.ID != -1;

  [TableFieldMapping]
  public int? CompanyLineID => this.GetField<int?>(nameof (CompanyLineID), nameof (CompanyLineID));

  [TableFieldMapping]
  public string OptionName => this.GetField<string>(nameof (OptionName), nameof (OptionName));

  [TableFieldMapping]
  public short? BillingDateDaysFromDueDate
  {
    get
    {
      return this.GetField<short?>(nameof (BillingDateDaysFromDueDate), nameof (BillingDateDaysFromDueDate));
    }
  }

  [TableFieldMapping]
  public bool DateBilledEqualToDueDate
  {
    get
    {
      return this.GetField<bool?>(nameof (DateBilledEqualToDueDate), nameof (DateBilledEqualToDueDate)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool DayOfMonth => this.GetField<bool?>(nameof (DayOfMonth), nameof (DayOfMonth)) ?? false;

  [TableFieldMapping]
  public short? DayOfMonthAltFirstInstallDays
  {
    get
    {
      return this.GetField<short?>(nameof (DayOfMonthAltFirstInstallDays), nameof (DayOfMonthAltFirstInstallDays));
    }
  }

  [TableFieldMapping]
  public short? DayOfMonthInstallmentTerm
  {
    get
    {
      return this.GetField<short?>(nameof (DayOfMonthInstallmentTerm), nameof (DayOfMonthInstallmentTerm));
    }
  }

  [TableFieldMapping]
  public byte? DayOfMonthNumber
  {
    get => this.GetField<byte?>(nameof (DayOfMonthNumber), nameof (DayOfMonthNumber));
  }

  [TableFieldMapping]
  public bool Disabled => this.GetField<bool?>(nameof (Disabled), nameof (Disabled)) ?? false;

  [TableFieldMapping]
  public DateTime? DisabledDate
  {
    get => this.GetField<DateTime?>(nameof (DisabledDate), nameof (DisabledDate));
  }

  [TableFieldMapping]
  public bool DisallowAutomatedNOC
  {
    get
    {
      return this.GetField<bool?>(nameof (DisallowAutomatedNOC), nameof (DisallowAutomatedNOC)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool DisallowAutomatedPrinting
  {
    get
    {
      return this.GetField<bool?>(nameof (DisallowAutomatedPrinting), nameof (DisallowAutomatedPrinting)) ?? false;
    }
  }

  [TableFieldMapping]
  public byte? DownpaymentBillingTypeID
  {
    get
    {
      return this.GetField<byte?>(nameof (DownpaymentBillingTypeID), nameof (DownpaymentBillingTypeID));
    }
  }

  [TableFieldMapping]
  public int? DownPaymentDayofMonth
  {
    get => this.GetField<int?>(nameof (DownPaymentDayofMonth), nameof (DownPaymentDayofMonth));
  }

  [TableFieldMapping]
  public bool DownpaymentFromDateBilled
  {
    get
    {
      return this.GetField<bool?>(nameof (DownpaymentFromDateBilled), nameof (DownpaymentFromDateBilled)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool DownpaymentFromEffectiveDate
  {
    get
    {
      return this.GetField<bool?>(nameof (DownpaymentFromEffectiveDate), nameof (DownpaymentFromEffectiveDate)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool DownPaymentFromEffEndMonth
  {
    get
    {
      return this.GetField<bool?>(nameof (DownPaymentFromEffEndMonth), nameof (DownPaymentFromEffEndMonth)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool DownpaymentFromExpirationDate
  {
    get
    {
      return this.GetField<bool?>(nameof (DownpaymentFromExpirationDate), nameof (DownpaymentFromExpirationDate)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool DownPaymentGAAP
  {
    get => this.GetField<bool?>(nameof (DownPaymentGAAP), nameof (DownPaymentGAAP)) ?? false;
  }

  [TableFieldMapping]
  public Decimal? DownpaymentPercentage
  {
    get => this.GetField<Decimal?>(nameof (DownpaymentPercentage), nameof (DownpaymentPercentage));
  }

  [TableFieldMapping]
  public short? DownpaymentTerm
  {
    get => this.GetField<short?>(nameof (DownpaymentTerm), nameof (DownpaymentTerm));
  }

  [TableFieldMapping]
  public bool DownPaymentUsingBusinessDays
  {
    get
    {
      return this.GetField<bool?>(nameof (DownPaymentUsingBusinessDays), nameof (DownPaymentUsingBusinessDays)) ?? false;
    }
  }

  [TableFieldMapping]
  public short? EffDateBilledAltFirstInstallDays
  {
    get
    {
      return this.GetField<short?>(nameof (EffDateBilledAltFirstInstallDays), nameof (EffDateBilledAltFirstInstallDays));
    }
  }

  [TableFieldMapping]
  public short? EffectiveAltFirstInstallDays
  {
    get
    {
      return this.GetField<short?>(nameof (EffectiveAltFirstInstallDays), nameof (EffectiveAltFirstInstallDays));
    }
  }

  [TableFieldMapping]
  public bool EffectiveDateBilled
  {
    get
    {
      return this.GetField<bool?>(nameof (EffectiveDateBilled), nameof (EffectiveDateBilled)) ?? false;
    }
  }

  [TableFieldMapping]
  public short? ExpirationAltFirstInstallDays
  {
    get
    {
      return this.GetField<short?>(nameof (ExpirationAltFirstInstallDays), nameof (ExpirationAltFirstInstallDays));
    }
  }

  [TableFieldMapping]
  public bool Financed => this.GetField<bool?>(nameof (Financed), nameof (Financed)) ?? false;

  [TableFieldMapping]
  public bool IncludeOnDownpayment
  {
    get
    {
      return this.GetField<bool?>(nameof (IncludeOnDownpayment), nameof (IncludeOnDownpayment)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool InstallmentFromDateBilled
  {
    get
    {
      return this.GetField<bool?>(nameof (InstallmentFromDateBilled), nameof (InstallmentFromDateBilled)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool InstallmentFromEffectiveDate
  {
    get
    {
      return this.GetField<bool?>(nameof (InstallmentFromEffectiveDate), nameof (InstallmentFromEffectiveDate)) ?? false;
    }
  }

  [TableFieldMapping]
  public short? InstallmentTerms
  {
    get => this.GetField<short?>(nameof (InstallmentTerms), nameof (InstallmentTerms));
  }

  [TableFieldMapping]
  public Decimal? MaximumPremium
  {
    get => this.GetField<Decimal?>(nameof (MaximumPremium), nameof (MaximumPremium));
  }

  [TableFieldMapping]
  public Decimal? MinimumDownPayment
  {
    get => this.GetField<Decimal?>(nameof (MinimumDownPayment), nameof (MinimumDownPayment));
  }

  [TableFieldMapping]
  public Decimal? MinimumPremium
  {
    get => this.GetField<Decimal?>(nameof (MinimumPremium), nameof (MinimumPremium));
  }

  [TableFieldMapping]
  public bool MonthFollowingDownPayment
  {
    get
    {
      return this.GetField<bool?>(nameof (MonthFollowingDownPayment), nameof (MonthFollowingDownPayment)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool MonthFollowingDownPayment_Eff
  {
    get
    {
      return this.GetField<bool?>(nameof (MonthFollowingDownPayment_Eff), nameof (MonthFollowingDownPayment_Eff)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool MonthFollowingDownPayment_Eff_DateBilled
  {
    get
    {
      return this.GetField<bool?>(nameof (MonthFollowingDownPayment_Eff_DateBilled), nameof (MonthFollowingDownPayment_Eff_DateBilled)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool MonthFollowingDownPayment_Exp
  {
    get
    {
      return this.GetField<bool?>(nameof (MonthFollowingDownPayment_Exp), nameof (MonthFollowingDownPayment_Exp)) ?? false;
    }
  }

  [TableFieldMapping]
  public byte? NumPayments => this.GetField<byte?>(nameof (NumPayments), nameof (NumPayments));

  [TableFieldMapping]
  public Decimal? PerInstallmentCharge
  {
    get => this.GetField<Decimal?>(nameof (PerInstallmentCharge), nameof (PerInstallmentCharge));
  }

  [TableFieldMapping]
  public int? PerInstallmentChargeCode
  {
    get
    {
      return this.GetField<int?>(nameof (PerInstallmentChargeCode), nameof (PerInstallmentChargeCode));
    }
  }

  [TableFieldMapping]
  public bool PolicyEffective
  {
    get => this.GetField<bool?>(nameof (PolicyEffective), nameof (PolicyEffective)) ?? false;
  }

  [TableFieldMapping]
  public short? PolicyEffectiveInstallmentTerm
  {
    get
    {
      return this.GetField<short?>(nameof (PolicyEffectiveInstallmentTerm), nameof (PolicyEffectiveInstallmentTerm));
    }
  }

  [TableFieldMapping]
  public bool PolicyExpiration
  {
    get => this.GetField<bool?>(nameof (PolicyExpiration), nameof (PolicyExpiration)) ?? false;
  }

  [TableFieldMapping]
  public short? PolicyExpirationInstallmentTerm
  {
    get
    {
      return this.GetField<short?>(nameof (PolicyExpirationInstallmentTerm), nameof (PolicyExpirationInstallmentTerm));
    }
  }

  [TableFieldMapping]
  public bool SinglePay => this.GetField<bool?>(nameof (SinglePay), nameof (SinglePay)) ?? false;

  [TableFieldMapping]
  public bool UseEffectiveDateForBilling
  {
    get
    {
      return this.GetField<bool?>(nameof (UseEffectiveDateForBilling), nameof (UseEffectiveDateForBilling)) ?? false;
    }
  }

  [TableFieldMapping]
  public bool UseMonth => this.GetField<bool?>(nameof (UseMonth), nameof (UseMonth)) ?? false;

  [TableFieldMapping]
  public bool UseMonthForAltFirstInstallment
  {
    get
    {
      return this.GetField<bool?>(nameof (UseMonthForAltFirstInstallment), nameof (UseMonthForAltFirstInstallment)) ?? false;
    }
  }
}
