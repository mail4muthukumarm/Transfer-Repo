// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib.Quote
// Assembly: MgaSystems.IMS.Policies.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0490D932-1980-4BA9-8AB9-51DC95793BA0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Policies.Cs.dll

using Mga.Wpf.Ims.Collections;
using MGASystems.Data;
using MGASystems.Data.Binding;
using MGASystems.IMS.NoteDocuments;
using MgaSystems.IMS.Policies.SimpleQuoteEntry.SharedModels;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;

#nullable disable
namespace MgaSystems.IMS.Policies.SimpleQuoteEntry.Lib;

public abstract class Quote : BindingObject
{
  public SimpleQuote Parent { get; set; }

  [NotificationProperty]
  public virtual Guid QuotingOfficeGuid { get; set; }

  [NotificationProperty]
  public virtual Guid LineGuid { get; set; }

  [NotificationProperty]
  public virtual DateTime EffectiveDate { get; set; }

  [NotificationProperty]
  public virtual DateTime ExpirationDate { get; set; }

  [NotificationProperty]
  public virtual string StateID { get; set; }

  [NotificationProperty]
  public virtual Guid UnderwriterGuid { get; set; }

  [NotificationProperty]
  public virtual Guid CompanyLocationGuid { get; set; }

  [NotificationProperty]
  public virtual int BillingTypeID { get; set; }

  [NotificationProperty]
  public virtual Guid IssuingOfficeGuid { get; set; }

  public Guid CompanyLineGuid { get; set; }

  [NotificationProperty]
  public virtual byte PolicyTypeID { get; set; }

  public Decimal? MinimumEarnedPercentage { get; set; }

  public string Line { get; set; }

  public string Company { get; set; }

  [NotificationProperty]
  public virtual bool UseIntermediary { get; set; }

  public bool IsRenewal => this.PolicyTypeID == (byte) 2;

  [NotificationProperty]
  public virtual bool UseMulticurrency { get; set; }

  [NotificationProperty]
  public virtual int CostCenterID { get; set; }

  [NotificationProperty]
  public virtual string CurrencyCode { get; set; }

  [NotificationProperty]
  public virtual bool CanEditCostCenter { get; set; }

  public virtual bool IsCommissionRenewal => this.IsRenewal;

  [NotificationProperty]
  public virtual ObservableCollection<CostCenter> CostCenters { get; set; }

  public BulkObservableCollection<QuoteDetail> QuoteDetails { get; } = new BulkObservableCollection<QuoteDetail>();

  internal static Quote Create(SimpleQuote parent)
  {
    return NotifyProxyTypeManager.Allocate<Quote>(new object[1]
    {
      (object) parent
    });
  }

  public Quote(SimpleQuote parent)
  {
    this.Parent = parent;
    this.EffectiveDate = DateTime.Now;
    this.ExpirationDate = DateTime.Now.AddYears(1);
    this.PolicyTypeID = (byte) 1;
    this.UseMulticurrency = MultiCurrencyUtilities.IsMultiCurrencyActive();
    if (this.UseMulticurrency)
      return;
    this.CurrencyCode = "USD";
  }

  protected override void OnPropertyChanged(string propertyName)
  {
    base.OnPropertyChanged(propertyName);
    switch (propertyName)
    {
      case "CompanyLocationGuid":
        if (this.CompanyLocationGuid.Equals(Guid.Empty))
          break;
        this.CompanyLineGuid = CodeRetrieval.GetCompanyLineGuid(this.CompanyLocationGuid, this.LineGuid, this.StateID);
        this.ShowParticipants();
        break;
      case "EffectiveDate":
        this.Parent.SetProgramCode();
        this.LoadCostCenters();
        this.ExpirationDate = this.EffectiveDate.AddYears(1);
        break;
      case "QuotingOfficeGuid":
      case "UnderwriterGuid":
      case "CompanyLineGuid":
      case "BillingTypeID":
      case "IssuingOfficeGuid":
      case "StateID":
      case "ExpirationDate":
        this.LoadCostCenters();
        break;
    }
  }

  private void LoadCostCenters()
  {
    this.CanEditCostCenter = this.QuotingOfficeGuid != Guid.Empty && this.UnderwriterGuid != Guid.Empty && this.CompanyLineGuid != Guid.Empty;
    if (!this.CanEditCostCenter)
      return;
    this.CostCenters = CodeRetrieval.GetCostCenters(this.QuotingOfficeGuid, this.UnderwriterGuid, this.CompanyLineGuid, this.EffectiveDate);
    if (this.CostCenters == null)
      return;
    this.CostCenterID = this.CostCenters.Where<CostCenter>((System.Func<CostCenter, bool>) (c => c.IsDefault)).SingleOrDefault<CostCenter>() == null ? 0 : this.CostCenters.Where<CostCenter>((System.Func<CostCenter, bool>) (c => c.IsDefault)).SingleOrDefault<CostCenter>().GroupId;
    base.OnPropertyChanged("CostCenterID");
  }

  private void ShowParticipants()
  {
    DataTable source = DefaultDatabase.ExecuteDataTable("dbo.QuoteEditData_GetPolicyParticipants", new object[6]
    {
      (object) "@CompanyLineGuid",
      (object) this.CompanyLineGuid,
      (object) "@IsNewQuote",
      (object) true,
      (object) "@PolicyEffective",
      (object) this.EffectiveDate
    });
    if (source.Rows.Count != 0)
    {
      if (source.Columns.Count > 2)
        this.QuoteDetails.AddRange((IEnumerable<QuoteDetail>) source.AsEnumerable().Select<DataRow, QuoteDetail>((System.Func<DataRow, QuoteDetail>) (row => QuoteDetail.Create(this, row.Field<Guid>("CompanyLineGuid"), row.Field<string>("CompanyLine"), row.Field<short>("TermsOfPayment"), row.Field<bool>("UsingAdditiveCommission")))));
      else
        ((Collection<QuoteDetail>) this.QuoteDetails).Add(QuoteDetail.Create(this, this.CompanyLineGuid, $"{this.Company} - {this.Line} - {this.StateID}", source.Rows[0].Field<short>("TermsOfPayment"), (source.Rows[0].Field<bool>("UsingAdditiveCommission") ? 1 : 0) != 0));
    }
    this.UseIntermediary = ((IEnumerable<QuoteDetail>) this.QuoteDetails).Where<QuoteDetail>((System.Func<QuoteDetail, bool>) (q => q.UsingIntermediary)).Count<QuoteDetail>() == ((Collection<QuoteDetail>) this.QuoteDetails).Count;
    this.SetInitialContact();
  }

  private void SetInitialContact()
  {
    foreach (QuoteDetail quoteDetail in (Collection<QuoteDetail>) this.QuoteDetails)
    {
      if (this.UseIntermediary)
        quoteDetail.IntermediaryContactGuid = quoteDetail.IntermediaryContacts[0].IntermediaryContactGuid;
      else
        quoteDetail.CompanyContactGuid = quoteDetail.CompanyContacts[0].CompanyContactGuid;
    }
  }

  public void SetMinimumEarned()
  {
    if (!SystemSettings.GetSetting<bool>("ResetMinimumEarnedOnCarrierChanged", false) && this.MinimumEarnedPercentage.HasValue)
      return;
    this.MinimumEarnedPercentage = DefaultDatabase.ExecuteScalar<Decimal?>(CommandType.Text, "SELECT MinimumEarnedPercentage FROM tblCompanyLines WITH (NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) this.CompanyLineGuid
    });
  }
}
