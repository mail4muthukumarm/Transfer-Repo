// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.Quote
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.BusinessObjects.Exceptions;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.CustomExceptions;
using MGASystems.Common.Enums;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.LexisNexis;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using MGASystems.IMS.NoteDocuments;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.BusinessObjects;

[SecureResource("{CA4F4132-813E-4db9-B16D-6627D648ABF1}", "Un-Issue Policy", "Allows a user to un-issue a policy.", "Policy")]
[SecureResource("{1831B532-0BAA-4831-B986-F3FA3B16297E}", "Unbind Policy", "Allows a user to unbind a policy on days other than the day it was bound.", "Policy")]
[TableMapping("dbo.tblQuotes")]
public class Quote : OfacEntity, ISupportNoteSystem, ISupportDocumentSystem
{
  public const string UnissuePolicy = "{CA4F4132-813E-4db9-B16D-6627D648ABF1}";
  public const string UnbindPolicyAfterFirstDay = "{1831B532-0BAA-4831-B986-F3FA3B16297E}";
  private Guid _quoteGuid;
  private List<QuoteDetail> _quoteDetails;
  private List<QuoteOption> _quoteOptions;
  private Quote _previousQuote;
  private Quote _nextQuote;
  protected const int CHECK_CONSTRAINT_VIOLATION = 547;
  private static readonly ConcurrentDictionary<int, Guid> _quoteGuidDictionary = new ConcurrentDictionary<int, Guid>();
  private Guid _renewedQuoteGuid;
  private Exception _renewException;
  private const int CLOSED_ACCOUNTING_MONTH = 55;

  public Quote(Guid quoteGuid) => this._quoteGuid = quoteGuid;

  public Quote(int quoteID)
  {
    this._quoteGuid = Quote._quoteGuidDictionary.GetOrAdd(quoteID, new System.Func<int, Guid>(this.ReturnQuoteGuid));
  }

  protected Guid ReturnQuoteGuid(int quoteID)
  {
    Guid guid = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT QuoteGuid FROM dbo.tblQuotes (NOLOCK) WHERE QuoteID=@QID", new object[2]
    {
      (object) "@QID",
      (object) quoteID
    }) ?? Guid.Empty;
    return !guid.Equals(Guid.Empty) ? guid : throw new QuoteGuidNotFoundException(quoteID);
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  [Browsable(false)]
  public Quote()
  {
  }

  protected override Exception BaseDataObjectException(string errorMessage)
  {
    return (Exception) new QuoteGuidNotFoundException(this.QuoteGuid);
  }

  protected override void OnDataRefresh(bool refreshed)
  {
    if (refreshed && (!this.HasValue("CompanyLine") || !this.HasValue("CompanyLineGuid") || this.CompanyLine.CompanyLineGuid.Equals((object) this.CompanyLineGuid)))
      return;
    this._quoteDetails = (List<QuoteDetail>) null;
  }

  public ProducerLocation Retailer
  {
    get
    {
      return this.CacheManualValue<ProducerLocation>(nameof (Retailer), (Func<ProducerLocation>) ([SpecialName] () =>
      {
        if (!this.HasRetailer)
          return (ProducerLocation) null;
        return ObjectFactory.Instance.CreateObjectAs<ProducerLocation>((object) this.RetailerGuid.Value);
      }));
    }
  }

  public SubmissionGroup SubmissionGroup
  {
    get
    {
      return this.CacheManualValue<SubmissionGroup>(nameof (SubmissionGroup), (Func<SubmissionGroup>) ([SpecialName] () => ObjectFactory.Instance.CreateObjectAs<SubmissionGroup>((object) this.SubmissionGroupGuid)));
    }
  }

  public CompanyLine CompanyLine
  {
    get
    {
      return this.CacheManualValue<CompanyLine>(nameof (CompanyLine), (Func<CompanyLine>) ([SpecialName] () => ObjectFactory.Instance.CreateObjectAs<CompanyLine>((object) this.CompanyLineGuid.Value)));
    }
  }

  public CompanyLocation CompanyLocation
  {
    get
    {
      return this.CacheManualValue<CompanyLocation>(nameof (CompanyLocation), (Func<CompanyLocation>) ([SpecialName] () =>
      {
        if (!this.HasCompanyLocationGuid)
          return (CompanyLocation) null;
        return ObjectFactory.Instance.CreateObjectAs<CompanyLocation>((object) this.CompanyLocationGuid);
      }));
    }
  }

  public Quote PreviousQuote
  {
    get
    {
      if (this._previousQuote == null && this.OriginalQuoteGuid.HasValue)
        this._previousQuote = Quote.CreateNew(this.OriginalQuoteGuid.Value);
      return this._previousQuote;
    }
  }

  public Quote NextQuote
  {
    get
    {
      return this.CacheManualValue<Quote>(nameof (NextQuote), (Func<Quote>) ([SpecialName] () =>
      {
        if (!this.NextQuoteGuid.HasValue)
          return (Quote) null;
        return ObjectFactory.Instance.CreateObjectAs<Quote>((object) this.NextQuoteGuid.Value);
      }));
    }
  }

  public User Underwriter
  {
    get
    {
      return this.CacheManualValue<User>(nameof (Underwriter), (Func<User>) ([SpecialName] () =>
      {
        if (!this.UnderwriterUserGuid.HasValue)
          return (User) null;
        return ObjectFactory.Instance.CreateObjectAs<User>((object) this.UnderwriterUserGuid.Value);
      }));
    }
  }

  public User TACSR
  {
    get
    {
      return this.CacheManualValue<User>(nameof (TACSR), (Func<User>) ([SpecialName] () =>
      {
        if (!this.TACSRUserGuid.HasValue)
          return (User) null;
        return ObjectFactory.Instance.CreateObjectAs<User>((object) this.TACSRUserGuid.Value);
      }));
    }
  }

  public User UnderwriterAssistant
  {
    get
    {
      return this.CacheManualValue<User>(nameof (UnderwriterAssistant), (Func<User>) ([SpecialName] () =>
      {
        if (!this.HasUnderwriterAssistant)
          return (User) null;
        return ObjectFactory.Instance.CreateObjectAs<User>((object) this.UnderwritingAssistantGuid.Value);
      }));
    }
  }

  public List<QuoteDetail> QuoteDetails
  {
    get
    {
      if (this._quoteDetails == null || this._quoteDetails.Count == 0)
        this._quoteDetails = BaseDataObject.SelectManyAndSet<QuoteDetail>("QuoteGuid=@QuoteGuid", (Action<QuoteDetail>) ([SpecialName] (qd) => qd.Quote = this), (object) "@QuoteGuid", (object) this.QuoteGuid);
      return this._quoteDetails;
    }
  }

  public List<QuoteOption> QuoteOptions
  {
    get
    {
      if (this._quoteOptions == null || this._quoteOptions.Count == 0)
        this._quoteOptions = BaseDataObject.SelectManyAndSet<QuoteOption>("QuoteGuid=@QuoteGuid", (Action<QuoteOption>) ([SpecialName] (qo) => qo.Quote = this), (object) "@QuoteGuid", (object) this.QuoteGuid);
      return this._quoteOptions;
    }
  }

  public List<Quote.AffidavitNumber> AffidavitNumbers
  {
    get
    {
      return this.CacheManualValue<List<Quote.AffidavitNumber>>(nameof (AffidavitNumbers), (Func<List<Quote.AffidavitNumber>>) ([SpecialName] () =>
      {
        EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT StateID, AffidavitNumber FROM dbo.tblQuoteAffidavitNumbers WITH(NOLOCK) WHERE QuoteID=@QuoteID", new object[2]
        {
          (object) "@QuoteID",
          (object) this.QuoteID
        }).AsEnumerable();
        System.Func<DataRow, Quote.AffidavitNumber> selector;
        if (Quote._Closure\u0024__.\u0024I40\u002D1 != null)
          selector = Quote._Closure\u0024__.\u0024I40\u002D1;
        else
          Quote._Closure\u0024__.\u0024I40\u002D1 = selector = (System.Func<DataRow, Quote.AffidavitNumber>) ([SpecialName] (dr) => new Quote.AffidavitNumber()
          {
            StateID = dr.Field<string>(0),
            AffidavitNumber = dr.Field<string>(1)
          });
        return source.Select<DataRow, Quote.AffidavitNumber>(selector).ToList<Quote.AffidavitNumber>();
      }));
    }
  }

  public ProducerLocation ProducerLocation
  {
    get
    {
      return this.CacheManualValue<ProducerLocation>(nameof (ProducerLocation), (Func<ProducerLocation>) ([SpecialName] () => ObjectFactory.Instance.CreateObjectAs<ProducerLocation>((object) this.ProducerLocationID)));
    }
  }

  public ProducerContact ProducerContact
  {
    get
    {
      return this.CacheManualValue<ProducerContact>(nameof (ProducerContact), (Func<ProducerContact>) ([SpecialName] () => ObjectFactory.Instance.CreateObjectAs<ProducerContact>((object) this.ProducerContactGuid)));
    }
  }

  public OfficeLocation QuotingLocation
  {
    get
    {
      return this.CacheManualValue<OfficeLocation>(nameof (QuotingLocation), (Func<OfficeLocation>) ([SpecialName] () => ObjectFactory.Instance.CreateObjectAs<OfficeLocation>((object) this.QuotingLocationGuid)));
    }
  }

  public OfficeLocation IssuingLocation
  {
    get
    {
      return this.CacheManualValue<OfficeLocation>(nameof (IssuingLocation), (Func<OfficeLocation>) ([SpecialName] () => ObjectFactory.Instance.CreateObjectAs<OfficeLocation>((object) this.IssuingLocationGuid)));
    }
  }

  [DataKey]
  public Guid QuoteGuid
  {
    get => this._quoteGuid;
    protected set
    {
      this._quoteGuid = this._quoteGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified Quote {this._quoteGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public int QuoteID => this.GetField<int>(nameof (QuoteID), nameof (QuoteID));

  [TableFieldMapping]
  public Guid? OriginalQuoteGuid
  {
    get => this.GetField<Guid?>(nameof (OriginalQuoteGuid), nameof (OriginalQuoteGuid));
  }

  [TableFieldMapping("RenewalOfQuoteGuid TransactionRenewalOfQuoteGuid")]
  public Guid? TransactionRenewalOfQuoteGuid
  {
    get
    {
      return this.GetField<Guid?>(nameof (TransactionRenewalOfQuoteGuid), nameof (TransactionRenewalOfQuoteGuid));
    }
  }

  public bool IsTrueImsRenewal => this.TransactionRenewalOfQuoteGuid.HasValue;

  [TableFieldMapping]
  public Guid RewriteOfQuoteGuid
  {
    get => this.GetField<Guid>(nameof (RewriteOfQuoteGuid), nameof (RewriteOfQuoteGuid));
  }

  [TableFieldMapping]
  public int ControlNo => this.GetField<int>(nameof (ControlNo), nameof (ControlNo));

  [TableFieldMapping]
  Guid IRecreatableEntity.ControlGuid
  {
    get => this.GetField<Guid>(nameof (ControlGuid), nameof (ControlGuid));
  }

  [TableFieldMapping]
  public int EndorsementNum
  {
    get
    {
      return Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.GetField<object>(nameof (EndorsementNum), nameof (EndorsementNum))));
    }
  }

  [TableFieldMapping]
  public Guid? RetailerGuid => this.GetField<Guid?>(nameof (RetailerGuid), nameof (RetailerGuid));

  public bool HasRetailer => this.RetailerGuid.HasValue;

  [TableFieldMapping]
  public Guid CompanyLocationGuid
  {
    get
    {
      return this.GetField<Guid?>(nameof (CompanyLocationGuid), nameof (CompanyLocationGuid)) ?? Guid.Empty;
    }
  }

  public bool HasCompanyLocationGuid => !this.CompanyLocationGuid.Equals(Guid.Empty);

  [TableFieldMapping]
  public string StateID => this.GetField<string>(nameof (StateID), nameof (StateID));

  public bool HasStateID => !string.IsNullOrEmpty(this.StateID);

  [TableFieldMapping]
  public bool PolicyFormsAutoApplied
  {
    get => this.GetUncachedField<bool>(nameof (PolicyFormsAutoApplied));
  }

  [TableFieldMapping("NetRate_QuoteID")]
  public int NetRateQuoteID
  {
    get => this.GetField<int?>("NetRate_QuoteID", nameof (NetRateQuoteID)).GetValueOrDefault();
  }

  public string LineName
  {
    get
    {
      return this.CacheManualValue<string>(nameof (LineName), (Func<string>) ([SpecialName] () => new Line(this.LineGuid).LineName));
    }
  }

  [TableFieldMapping("EndorsementCalculationType")]
  public string EndorsementCalcType
  {
    get => this.GetField<string>("EndorsementCalculationType", nameof (EndorsementCalcType));
  }

  [TableFieldMapping]
  public Guid QuotingLocationGuid
  {
    get => this.GetField<Guid>(nameof (QuotingLocationGuid), nameof (QuotingLocationGuid));
  }

  [TableFieldMapping]
  public Guid IssuingLocationGuid
  {
    get => this.GetField<Guid>(nameof (IssuingLocationGuid), nameof (IssuingLocationGuid));
  }

  [TableFieldMapping]
  public DateTime? DateBound => this.GetField<DateTime?>(nameof (DateBound), nameof (DateBound));

  [TableFieldMapping]
  public DateTime DateCreated
  {
    get => this.GetField<DateTime>(nameof (DateCreated), nameof (DateCreated));
  }

  [TableFieldMapping]
  public DateTime? DateIssued => this.GetField<DateTime?>(nameof (DateIssued), nameof (DateIssued));

  [TableFieldMapping]
  public Guid? TACSRUserGuid
  {
    get => this.GetField<Guid?>(nameof (TACSRUserGuid), nameof (TACSRUserGuid));
  }

  [TableFieldMapping]
  public string SIC_Code => this.GetField<string>(nameof (SIC_Code), nameof (SIC_Code));

  [TableFieldMapping]
  public string NAICSCode => this.GetField<string>(nameof (NAICSCode), nameof (NAICSCode));

  [TableFieldMapping]
  public string AccountNumber
  {
    get => this.GetField<string>(nameof (AccountNumber), nameof (AccountNumber));
  }

  public bool IsShortTerm
  {
    get
    {
      DateTime dateTime = this.EffectiveDate;
      dateTime = dateTime.AddYears(1);
      DateTime date1 = dateTime.Date;
      dateTime = this.ExpirationDate;
      DateTime date2 = dateTime.Date;
      return DateTime.Compare(date1, date2) != 0;
    }
  }

  public bool IsCurrent => !this.NextQuoteGuid.HasValue;

  public bool IsIssued => this.DateIssued.HasValue;

  public bool PolicyIsIssued => this.PolicyDateIssued.HasValue;

  public bool IsRiskClassNull => this.SIC_Code == null;

  public bool IsNaicsCodeNull => this.NAICSCode == null;

  public bool IsAccountNumberNull => this.AccountNumber == null;

  public bool IsRetailerNull => !this.HasRetailer;

  [TableFieldMapping]
  public string InsuredPolicyName
  {
    get => this.GetField<string>(nameof (InsuredPolicyName), nameof (InsuredPolicyName));
  }

  [TableFieldMapping]
  public string PolicyNumber => this.GetField<string>(nameof (PolicyNumber), nameof (PolicyNumber));

  public bool HasPolicyNumber => this.PolicyNumber != null;

  [TableFieldMapping]
  public int? PolicyNumberRuleID
  {
    get
    {
      short? field = this.GetField<short?>(nameof (PolicyNumberRuleID), nameof (PolicyNumberRuleID));
      return !field.HasValue ? new int?() : new int?((int) field.GetValueOrDefault());
    }
  }

  public int? CalculatedPolicyNumberRuleID
  {
    get
    {
      return this.CacheManualValue<int?>(nameof (CalculatedPolicyNumberRuleID), (Func<int?>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<int?>("dbo.GetPolicyNumberRule", new object[4]
      {
        (object) "@quoteGuid",
        (object) this.QuoteGuid,
        (object) "@companyLineGuid",
        null
      })));
    }
  }

  public int? ResolvedPolicyNumberRuleID
  {
    get
    {
      int? policyNumberRuleId;
      return !(policyNumberRuleId = this.PolicyNumberRuleID).HasValue ? this.CalculatedPolicyNumberRuleID : policyNumberRuleId;
    }
  }

  public bool HasPolicyNumberRuleID => this.PolicyNumberRuleID.HasValue;

  [TableFieldMapping]
  public bool QuickQuote => this.GetField<bool>(nameof (QuickQuote), nameof (QuickQuote));

  public bool IsQuickQuote => this.QuickQuote;

  [TableFieldMapping]
  public Guid? UnderwriterUserGuid
  {
    get => this.GetField<Guid?>(nameof (UnderwriterUserGuid), nameof (UnderwriterUserGuid));
  }

  [TableFieldMapping]
  public DateTime EffectiveDate
  {
    get => this.GetField<DateTime>(nameof (EffectiveDate), nameof (EffectiveDate));
  }

  [TableFieldMapping]
  public DateTime ExpirationDate
  {
    get => this.GetField<DateTime>(nameof (ExpirationDate), nameof (ExpirationDate));
  }

  [TableFieldMapping("EndorsementEffective")]
  public DateTime? EndorsementEffectiveDate
  {
    get => this.GetField<DateTime?>("EndorsementEffective", nameof (EndorsementEffectiveDate));
  }

  public DateTime EndorsementEffective
  {
    get
    {
      return this.EndorsementEffectiveDate.HasValue ? this.EndorsementEffectiveDate.Value : throw new InvalidOperationException($"{nameof (EndorsementEffective)} is null");
    }
  }

  public bool HasEndorsementEffectiveDate => this.EndorsementEffectiveDate.HasValue;

  [TableFieldMapping]
  public string ProducerName => this.GetField<string>(nameof (ProducerName), nameof (ProducerName));

  [TableFieldMapping]
  public Guid? UnderwritingAssistantGuid
  {
    get
    {
      return this.GetField<Guid?>(nameof (UnderwritingAssistantGuid), nameof (UnderwritingAssistantGuid));
    }
  }

  public bool HasUnderwriterAssistant => this.UnderwritingAssistantGuid.HasValue;

  bool IRecreatableEntity.HasControlGUID => true;

  public QuoteStatus NextBoundStatus
  {
    get
    {
      if (this.IsBound)
        throw new InvalidOperationException("Quote is already bound");
      return !this.IsEndorsement ? QuoteStatus.Bound : (this.QuoteStatus != QuoteStatus.PendingCancellation ? (this.QuoteStatus != QuoteStatus.UnboundNonRenewal ? (this.QuoteStatus != QuoteStatus.UnboundNonRenewalRescinded ? (this.PreviousQuoteStatus != QuoteStatus.NoticeofCancellation ? (this.PreviousQuoteStatus != QuoteStatus.LostOnBOR ? (this.PreviousQuoteStatus != QuoteStatus.Cancelled || this.QuoteStatus != QuoteStatus.UnboundEndorsement && this.QuoteStatus != QuoteStatus.UnboundCorrection ? QuoteStatus.Bound : QuoteStatus.Cancelled) : QuoteStatus.LostOnBOR) : QuoteStatus.NoticeofCancellation) : QuoteStatus.NonRenewalRescinded) : QuoteStatus.NonRenewed) : QuoteStatus.Cancelled);
    }
  }

  public QuoteStatus PreviousQuoteStatus
  {
    get
    {
      if (!this.OriginalQuoteGuid.HasValue)
        throw new InvalidOperationException("Can not call PreviousQuoteStatus on original policy record");
      return this.PreviousQuote.QuoteStatus;
    }
  }

  public QuoteStatus OriginalQuoteStatus
  {
    get
    {
      return this.OriginalQuoteStatusID.HasValue ? (QuoteStatus) Enum.ToObject(typeof (QuoteStatus), this.OriginalQuoteStatusID.Value) : throw new InvalidOperationException("Can not call OriginalQuoteStatus on original policy transaction");
    }
  }

  public bool PolicyIsNonRenewed => this.IsNonRenewal && !this.IsPolicyCancelled;

  [TableFieldMapping]
  public Decimal? MinimumEarnedPercentage
  {
    get
    {
      return this.GetField<Decimal?>(nameof (MinimumEarnedPercentage), nameof (MinimumEarnedPercentage));
    }
  }

  public Decimal MinimumEarned => this.MinimumEarnedPercentage.GetValueOrDefault();

  public EndorsementCalcTypes EndorsementCalculationType
  {
    get
    {
      string endorsementCalcType = this.EndorsementCalcType;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(endorsementCalcType, "F", false) == 0)
        return EndorsementCalcTypes.Flat;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(endorsementCalcType, "P", false) == 0)
        return EndorsementCalcTypes.ProRata;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(endorsementCalcType, "S", false) == 0)
        return EndorsementCalcTypes.ShortRate;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(endorsementCalcType, "M", false) == 0)
        return EndorsementCalcTypes.MinimumEarned;
      throw new InvalidOperationException("Unexpected EndorsementCalculationType: " + this.EndorsementCalcType);
    }
  }

  public bool UnderNotice => this.QuoteStatus == QuoteStatus.NoticeofCancellation;

  public bool IsCancelled => this.QuoteStatus == QuoteStatus.Cancelled;

  public bool IsFlatCancellation
  {
    get
    {
      return this.IsEndorsement && this.EndorsementTransactionType == TransactionTypeIDs.Cancellation && DateTime.Compare(this.EffectiveDate.Date, this.EndorsementEffective.Date) == 0;
    }
  }

  public bool IsReinstated
  {
    get
    {
      return this.EndorsementTransactionType == TransactionTypeIDs.Reinstatement && this.IsTransactionBound;
    }
  }

  [TableFieldMapping("dbo.IsQuoteBound(QuoteGuid) IsBound")]
  public bool IsBound => this.GetField<bool>(nameof (IsBound), nameof (IsBound));

  public bool IsTransactionBound => this.IsBound;

  public bool IsNonMonetaryEndorsement
  {
    get => this.IsEndorsement && this.IsBound && !this.HasBoundOptions();
  }

  public bool IsNonMonetaryEndorsementWithZeroPremium
  {
    get
    {
      if (!this.IsEndorsement || !this.IsBound)
        return false;
      return !this.HasBoundOptions() || Decimal.Compare(this.Premium, 0M) == 0;
    }
  }

  public bool IsEndorsementWithoutNonZeroPremiums => this.IsEndorsement && !this.HasNonZeroPremiums;

  public CompanyLicenseType CompanyLicenseType
  {
    get
    {
      return (CompanyLicenseType) Enum.ToObject(typeof (CompanyLicenseType), this.CompanyLine.CompanyLicenseTypeID);
    }
  }

  [TableFieldMapping]
  public string EndorsementComment
  {
    get => this.GetField<string>(nameof (EndorsementComment), nameof (EndorsementComment));
  }

  [TableFieldMapping]
  public int QuoteStatusID
  {
    get => (int) this.GetField<byte>(nameof (QuoteStatusID), nameof (QuoteStatusID));
  }

  [TableFieldMapping]
  public int? QuoteStatusReasonID
  {
    get
    {
      short? field = this.GetField<short?>(nameof (QuoteStatusReasonID), nameof (QuoteStatusReasonID));
      return !field.HasValue ? new int?() : new int?((int) field.GetValueOrDefault());
    }
  }

  public bool HasQuoteStatusReason => this.QuoteStatusReasonID.HasValue;

  [TableFieldMapping]
  public Guid SubmissionGroupGuid
  {
    get => this.GetField<Guid>(nameof (SubmissionGroupGuid), nameof (SubmissionGroupGuid));
  }

  public string DefaultInvoiceComment => this.CompanyLine.DefaultInvoiceComments;

  [TableFieldMapping]
  public Guid? CompanyLineGuid
  {
    get => this.GetField<Guid?>(nameof (CompanyLineGuid), nameof (CompanyLineGuid));
  }

  [TableFieldMapping]
  public int ProducerLocationID
  {
    get => this.GetField<int>(nameof (ProducerLocationID), nameof (ProducerLocationID));
  }

  public Guid ProducerLocationGuid
  {
    get
    {
      ProducerLocation producerLocation = this.ProducerLocation;
      return producerLocation == null ? this.SubmissionGroup.ProducerLocationGuid : producerLocation.ProducerLocationGuid;
    }
  }

  public bool IsCredit => Decimal.Compare(this.Premium, 0M) < 0;

  [TableFieldMapping]
  public Guid ProducerContactGuid
  {
    get => this.GetField<Guid>(nameof (ProducerContactGuid), nameof (ProducerContactGuid));
  }

  [TableFieldMapping]
  public Guid? SecProducerContactGuid
  {
    get => this.GetField<Guid?>(nameof (SecProducerContactGuid), nameof (SecProducerContactGuid));
  }

  public string ProducerContactSalutation => this.ProducerContact.Salutation;

  public string ProducerContactFirst => this.ProducerContact.FName;

  public string ProducerContactPhone => this.ProducerContact.Phone;

  public string ProducerContactLast => this.ProducerContact.LName;

  public string ProducerContactEmail => this.ProducerContact.Email;

  public string TACSRFirst => this.TACSR?.FirstName ?? string.Empty;

  public string TACSRLast => this.TACSR?.LastName ?? string.Empty;

  [TableFieldMapping]
  public char? TransactionTypeID
  {
    get
    {
      string field = this.GetField<string>(nameof (TransactionTypeID), nameof (TransactionTypeID));
      return field == null ? new char?() : new char?(field.FirstOrDefault<char>());
    }
  }

  public bool IsEndorsement => this.TransactionTypeID.HasValue;

  public TransactionTypeIDs EndorsementTransactionType
  {
    get
    {
      return !this.TransactionTypeID.HasValue ? TransactionTypeIDs.None : (TransactionTypeIDs) Strings.AscW(this.TransactionTypeID.ToString());
    }
  }

  [TableFieldMapping]
  public int PolicyTypeID
  {
    get => (int) this.GetField<byte>(nameof (PolicyTypeID), nameof (PolicyTypeID));
  }

  [TableFieldMapping]
  public int? BillingTypeID
  {
    get
    {
      byte? field = this.GetField<byte?>(nameof (BillingTypeID), nameof (BillingTypeID));
      return !field.HasValue ? new int?() : new int?((int) field.GetValueOrDefault());
    }
  }

  public bool IsBillingTypeNull => !this.BillingTypeID.HasValue;

  public PolicyTypes PolicyType => (PolicyTypes) this.PolicyTypeID;

  public Decimal EndorsementFactor
  {
    get
    {
      return this.IsEndorsement ? this.GetLazyField<Decimal>(nameof (EndorsementFactor), "dbo.CalculateQuoteEndorsementFactor(QuoteGUID, EndorsementCalculationType, EndorsementEffective)") : 1M;
    }
  }

  public string InsuredAddressFull
  {
    get
    {
      return this.GetLazyField<string>(nameof (InsuredAddressFull), "REPLACE(dbo.FormatAddress(InsuredAddress1,InsuredAddress2,InsuredCity,InsuredState,InsuredZipCode,InsuredZipPlus),char(10),char(32))");
    }
  }

  public string InsuredName
  {
    get
    {
      return this.CacheManualValue<string>(nameof (InsuredName), (Func<string>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT dbo.GetInsuredName(sg.InsuredGUID) FROM dbo.tblSubmissionGroup sg WITH(NOLOCK) WHERE sg.SubmissionGroupGuid = @SG", new object[2]
      {
        (object) "@SG",
        (object) this.SubmissionGroupGuid
      })));
    }
  }

  public string InsuredAddress1
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredAddress1), nameof (InsuredAddress1));
    }
  }

  public string InsuredAddress2
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredAddress2), nameof (InsuredAddress2));
    }
  }

  public string InsuredCity
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredCity), nameof (InsuredCity));
    }
  }

  public string InsuredCounty
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredCounty), nameof (InsuredCounty));
    }
  }

  public string InsuredState
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredState), nameof (InsuredState));
    }
  }

  public string InsuredISOCountryCode
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredISOCountryCode), nameof (InsuredISOCountryCode));
    }
  }

  public string InsuredCountryName
  {
    get
    {
      return this.CacheManualValue<string>(nameof (InsuredCountryName), (Func<string>) ([SpecialName] () =>
      {
        string insuredCountryName;
        if (!string.IsNullOrEmpty(this.InsuredISOCountryCode))
          insuredCountryName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Country FROM dbo.tblAddressResolver_Countries WITH(NOLOCK) WHERE ISOCode = @ISO", new object[2]
          {
            (object) "@ISO",
            (object) this.InsuredISOCountryCode
          });
        else
          insuredCountryName = (string) null;
        return insuredCountryName;
      }));
    }
  }

  public string InsuredZipCode
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredZipCode), nameof (InsuredZipCode));
    }
  }

  public string InsuredZipPlus
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredZipPlus), nameof (InsuredZipPlus));
    }
  }

  public string InsuredDBA
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredDBA), nameof (InsuredDBA));
    }
  }

  public string InsuredPhone
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredPhone), nameof (InsuredPhone));
    }
  }

  public string InsuredMobileNumber
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredMobileNumber), nameof (InsuredMobileNumber));
    }
  }

  public string InsuredFax
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredFax), nameof (InsuredFax));
    }
  }

  public string InsuredAddress1_Billing
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredAddress1_Billing), nameof (InsuredAddress1_Billing));
    }
  }

  public string InsuredAddress2_Billing
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredAddress2_Billing), nameof (InsuredAddress2_Billing));
    }
  }

  public string InsuredCity_Billing
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredCity_Billing), nameof (InsuredCity_Billing));
    }
  }

  public string InsuredState_Billing
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredState_Billing), nameof (InsuredState_Billing));
    }
  }

  public string InsuredZipCode_Billing
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredZipCode_Billing), nameof (InsuredZipCode_Billing));
    }
  }

  public string InsuredZipPlus_Billing
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredZipPlus_Billing), nameof (InsuredZipPlus_Billing));
    }
  }

  public string InsuredISOCountryCode_Billing
  {
    get
    {
      return !this.GetAddressFields() ? (string) null : this.GetField<string>(nameof (InsuredISOCountryCode_Billing), nameof (InsuredISOCountryCode_Billing));
    }
  }

  public bool CanUnbind => this.GetCanUnbind();

  public bool IsOriginalQuoteRecord => !this.OriginalQuoteGuid.HasValue;

  public bool HasEndorsements => this.NextQuoteGuid.HasValue;

  public bool OriginalPolicyTransactionIssued => this.PolicyDateIssued.HasValue;

  public bool IsUnboundEndorsementTransaction => this.IsEndorsement && !this.IsTransactionBound;

  public bool PreviousTransactionIsDownwardInternalCorrection
  {
    get => this.IsEndorsement && this.PreviousQuote.IsDownwardInternalCorrectionTransaction;
  }

  public bool IsInternalCorrectionTransaction
  {
    get
    {
      return this.IsDownwardInternalCorrectionTransaction || this.IsUpwardInternalCorrectionTransaction;
    }
  }

  public bool IsDownwardInternalCorrectionTransaction
  {
    get => this.IsEndorsement && this.TransactionTypeID.Equals((object) 'D');
  }

  public bool IsUpwardInternalCorrectionTransaction
  {
    get => this.IsEndorsement && this.TransactionTypeID.Equals((object) 'U');
  }

  public bool IsAuditTransaction
  {
    get => this.IsEndorsement && this.TransactionTypeID.Equals((object) 'A');
  }

  public bool IsRenewal => this.PolicyType == PolicyTypes.Renewal;

  [TableFieldMapping]
  public Guid? FinanceCompanyGuid
  {
    get => this.GetField<Guid?>(nameof (FinanceCompanyGuid), nameof (FinanceCompanyGuid));
  }

  [TableFieldMapping]
  public int? InspectionCompanyID
  {
    get => this.GetField<int?>(nameof (InspectionCompanyID), nameof (InspectionCompanyID));
  }

  public Guid NewCompanyLocationGuid { get; set; }

  public Guid NewCompanyContactGuid { get; set; }

  public Guid? RenewalOfQuoteGuid
  {
    get
    {
      return this.CacheManualValue<Guid?>(nameof (RenewalOfQuoteGuid), (Func<Guid?>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<Guid?>("dbo.spGetRenewalOfQuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      })));
    }
  }

  public bool IsPackagePolicy
  {
    get => this.GetLazyField<bool>(nameof (IsPackagePolicy), "dbo.IsPackagePolicy(QuoteID)");
  }

  public bool IsMultiCompanyPolicy
  {
    get
    {
      return this.GetLazyField<bool>(nameof (IsMultiCompanyPolicy), "dbo.IsMultipleCompaniesOnPolicy(QuoteGUID)");
    }
  }

  public bool IsNonRenewal
  {
    get => this.GetLazyField<bool>(nameof (IsNonRenewal), "dbo.QuoteIsNonRenewal(QuoteGuid)");
  }

  public Guid? NextQuoteGuid
  {
    get
    {
      return this.CacheManualValue<Guid?>(nameof (NextQuoteGuid), (Func<Guid?>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT TOP(1) QuoteGUID FROM dbo.tblQuotes WITH(NOLOCK) WHERE OriginalQuoteGuid = @QG", new object[2]
      {
        (object) "@QG",
        (object) this.QuoteGuid
      })));
    }
  }

  public int UnissuedInvoiceCount
  {
    get
    {
      return this.GetLazyField<int>(nameof (UnissuedInvoiceCount), "dbo.UnissuedInvoiceCount(ControlNo)");
    }
  }

  public DateTime? PolicyDateIssued
  {
    get
    {
      return !this.IsOriginalQuoteRecord ? this.CacheManualValue<DateTime?>(nameof (PolicyDateIssued), (Func<DateTime?>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<DateTime?>(CommandType.Text, "SELECT DateIssued FROM tblQuotes WITH(NOLOCK) WHERE ControlNo=@ControlNo AND OriginalQuoteGUID IS NULL", new object[2]
      {
        (object) "@ControlNo",
        (object) this.ControlNo
      }))) : this.DateIssued;
    }
  }

  public bool IsPolicyCancelled
  {
    get => this.GetLazyField<bool>(nameof (IsPolicyCancelled), "dbo.IsPolicyCancelled(ControlNo)");
  }

  public int? OriginalQuoteStatusID
  {
    get
    {
      byte? nullable = DefaultDatabase.ExecuteScalar<byte?>(CommandType.Text, "SELECT TOP 1 OriginalQuoteStatusID FROM tblQuoteStatusChangeLog WITH(NOLOCK) WHERE ControlNo=@ControlNo ORDER BY ID DESC", new object[2]
      {
        (object) "@ControlNo",
        (object) this.ControlNo
      });
      return !nullable.HasValue ? new int?() : new int?((int) nullable.GetValueOrDefault());
    }
  }

  public bool IsImsRenewal => this.RenewalOfQuoteGuid.HasValue;

  public bool IsImsRewrite
  {
    get => this.GetLazyField<bool>(nameof (IsImsRewrite), "dbo.IsImsRewrite(QuoteGuid)");
  }

  public int OptionCount
  {
    get
    {
      return this.CacheManualValue<int>(nameof (OptionCount), (Func<int>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(QuoteOptionID) FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteGuid=@QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      })));
    }
  }

  public int InvoiceCount
  {
    get
    {
      return this.CacheManualValue<int>(nameof (InvoiceCount), (Func<int>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT COUNT(I.InvoiceNum) FROM dbo.tblQuotes Q WITH(NOLOCK) JOIN dbo.tblFin_Invoices I WITH(NOLOCK) ON I.QuoteID = Q.QuoteID WHERE Q.QuoteGuid=@QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      }) ?? 0));
    }
  }

  public int ValidInvoiceCount
  {
    get
    {
      return this.CacheManualValue<int>(nameof (ValidInvoiceCount), (Func<int>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT COUNT(I.InvoiceNum) FROM dbo.tblQuotes Q WITH(NOLOCK) JOIN dbo.tblFin_Invoices I WITH(NOLOCK) ON I.QuoteID = Q.QuoteID WHERE Q.QuoteGuid=@QuoteGuid AND I.Failed=0", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      }) ?? 0));
    }
  }

  public string PolicyTypeType
  {
    get
    {
      return this.CacheManualValue<string>(nameof (PolicyTypeType), (Func<string>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Type FROM dbo.lstPolicyTypes WITH(NOLOCK) WHERE PolicyTypeID = @typeId", new object[2]
      {
        (object) "@typeId",
        (object) this.PolicyTypeID
      })));
    }
  }

  public bool IsProducerBor
  {
    get
    {
      return this.IsEndorsement && this.CacheManualValue<bool>(nameof (IsProducerBor), (Func<bool>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<bool>("IsProducerBOR", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      })));
    }
  }

  public Guid[] BoundQuoteOptionGuids
  {
    get
    {
      Guid[] quoteOptionGuids;
      if (this.IsTransactionBound && this.HasValue(nameof (BoundQuoteOptionGuids)))
      {
        quoteOptionGuids = this.GetField<Guid[]>(nameof (BoundQuoteOptionGuids), nameof (BoundQuoteOptionGuids));
      }
      else
      {
        EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT QuoteOptionGuid FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE Bound=1 AND QuoteGuid=@QuoteGuid", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this._quoteGuid
        }).AsEnumerable();
        System.Func<DataRow, Guid> selector;
        if (Quote._Closure\u0024__.\u0024I359\u002D0 != null)
          selector = Quote._Closure\u0024__.\u0024I359\u002D0;
        else
          Quote._Closure\u0024__.\u0024I359\u002D0 = selector = (System.Func<DataRow, Guid>) ([SpecialName] (dr) => dr.Field<Guid>("QuoteOptionGuid"));
        Guid[] array = source.Select<DataRow, Guid>(selector).ToArray<Guid>();
        quoteOptionGuids = this.IsBound ? this.CacheManualValue<Guid[]>(nameof (BoundQuoteOptionGuids), (Func<Guid[]>) ([SpecialName] () => array)) : array;
      }
      return quoteOptionGuids;
    }
  }

  public string Company
  {
    get
    {
      return this.CacheManualValue<string>(nameof (Company), (Func<string>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT CompanyName FROM dbo.tblCompanyLocations cl WITH(NOLOCK) JOIN dbo.tblCompanies c With(NOLOCK) ON cl.CompanyGuid = c.CompanyGuid WHERE cl.CompanyLocationGuid = @CLG", new object[2]
      {
        (object) "@CLG",
        (object) this.CompanyLocationGuid
      })));
    }
  }

  public Decimal Premium
  {
    get
    {
      return this.GetLazyField<Decimal?>(nameof (Premium), "dbo.GetQuotePremium(QuoteGuid, NULL)").GetValueOrDefault();
    }
  }

  public Decimal TotalPremium
  {
    get
    {
      return this.GetLazyField<Decimal?>(nameof (TotalPremium), "dbo.GetTotalPremium(QuoteGuid, NULL)").GetValueOrDefault();
    }
  }

  [TableFieldMapping]
  public Decimal? PreviousPremium
  {
    get => this.GetField<Decimal?>(nameof (PreviousPremium), nameof (PreviousPremium));
  }

  public bool HasBeenQuoted
  {
    get
    {
      return this.CacheManualValue<bool>(nameof (HasBeenQuoted), (Func<bool>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM dbo.tblQuoteStatusChangeLog tscl WITH (NOLOCK) JOIN dbo.lstQuoteStatus lsq WITH (NOLOCK) ON tscl.NewQuoteStatusID = lsq.QuoteStatusID WHERE tscl.ControlNo = @ControlNo and lsq.[Description] = @Description", new object[4]
      {
        (object) "@ControlNo",
        (object) this.ControlNo,
        (object) "@Description",
        (object) "Quoted"
      }) > 0));
    }
  }

  public string ExpiringPolicyNumber => this.GetLazyField<string>(nameof (ExpiringPolicyNumber));

  public string RiskDescription => this.GetLazyField<string>(nameof (RiskDescription));

  public Guid PolicyOriginalQuoteGuid
  {
    get
    {
      return this.CacheManualValue<Guid>(nameof (PolicyOriginalQuoteGuid), (Func<Guid>) ([SpecialName] () =>
      {
        Guid originalQuoteGuid;
        if (this.IsOriginalQuoteRecord)
          originalQuoteGuid = this.QuoteGuid;
        else
          originalQuoteGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT QuoteGUID FROM dbo.tblQuotes WITH(NOLOCK) WHERE ControlNo = @CN AND OriginalQuoteGuid IS NULL", new object[2]
          {
            (object) "@CN",
            (object) this.ControlNo
          });
        return originalQuoteGuid;
      }));
    }
  }

  public byte? InsuredBusinessTypeID => this.GetLazyField<byte?>(nameof (InsuredBusinessTypeID));

  public bool IsBatchIssuance
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(DISTINCT q2.BatchIssuePrintTypeID) FROM dbo.tblQuotes q1 WITH(NOLOCK) JOIN dbo.tblQuotes2 q2 WITH(NOLOCK) ON q1.QuoteID = q2.QuoteID WHERE q1.ControlNo = @ControlNo AND q1.OriginalQuoteGuid IS NULL AND q1.DateIssued IS NULL", new object[2]
      {
        (object) "@ControlNo",
        (object) this.ControlNo
      }) > 0;
    }
  }

  public bool HasFees
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM dbo.tblQuoteOptionCharges qoc WITH(NOLOCK) INNER JOIN dbo.tblQuoteOptions qo WITH(NOLOCK) ON qoc.QuoteOptionGuid = qo.QuoteOptionGUID WHERE qo.QuoteGUID = @QuoteGuid AND qoc.WaivedByUserGuid IS NULL AND qoc.Amount <> 0", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      }) != 0;
    }
  }

  public bool UsingExcelRating
  {
    get
    {
      DataTable excelRatingIds = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT RatingTypeId FROM dbo.tblExcelRating_Raters WITH(NOLOCK)");
      bool usingExcelRating;
      try
      {
        foreach (QuoteDetail quoteDetail in this.QuoteDetails)
        {
          int? nullable = quoteDetail.RaterID;
          if (!nullable.HasValue)
          {
            DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT RatingTypeID FROM dbo.tblCompanyRaters WITH(NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
            {
              (object) "@CompanyLineGuid",
              (object) quoteDetail.CompanyLineGuid
            });
            if (dataTable.Rows.Count == 1)
              nullable = new int?(dataTable.Rows[0].Field<int>("RatingTypeID"));
          }
          if (nullable.HasValue && !this.IsExcelRatingTypeID(nullable.Value, excelRatingIds))
          {
            usingExcelRating = false;
            goto label_10;
          }
        }
      }
      finally
      {
        List<QuoteDetail>.Enumerator enumerator;
        enumerator.Dispose();
      }
      usingExcelRating = true;
label_10:
      return usingExcelRating;
    }
  }

  private bool IsExcelRatingTypeID(int ratingTypeId, DataTable excelRatingIds)
  {
    bool flag;
    try
    {
      foreach (DataRow row in excelRatingIds.Rows)
      {
        int num = row.Field<int>("RatingTypeID");
        if (ratingTypeId == num)
        {
          flag = true;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = false;
label_8:
    return flag;
  }

  public bool UsingNetRate
  {
    get
    {
      bool usingNetRate;
      try
      {
        foreach (QuoteDetail quoteDetail in this.QuoteDetails)
        {
          if (!quoteDetail.IsRaterAssigned())
          {
            DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT RatingTypeID FROM dbo.tblCompanyRaters WITH(NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
            {
              (object) "@CompanyLineGuid",
              (object) quoteDetail.CompanyLineGuid
            });
            if (dataTable.Rows.Count != 1 || dataTable.Rows[0].Field<int>("RatingTypeID") != 100)
            {
              usingNetRate = false;
              goto label_9;
            }
          }
          else if (!quoteDetail.UsingNetRate)
          {
            usingNetRate = false;
            goto label_9;
          }
        }
      }
      finally
      {
        List<QuoteDetail>.Enumerator enumerator;
        enumerator.Dispose();
      }
      usingNetRate = true;
label_9:
      return usingNetRate;
    }
  }

  public bool UsingGenericMultiCarrierRater
  {
    get
    {
      bool multiCarrierRater;
      try
      {
        foreach (QuoteDetail quoteDetail in this.QuoteDetails)
        {
          if (!quoteDetail.IsRaterAssigned())
          {
            EnumerableRowCollection<DataRow> source = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT RatingTypeID FROM dbo.tblCompanyRaters WITH(NOLOCK) WHERE CompanyLineGuid=@CompanyLineGuid", new object[2]
            {
              (object) "@CompanyLineGuid",
              (object) quoteDetail.CompanyLineGuid
            }).AsEnumerable();
            System.Func<DataRow, bool> predicate;
            if (Quote._Closure\u0024__.\u0024I388\u002D0 != null)
              predicate = Quote._Closure\u0024__.\u0024I388\u002D0;
            else
              Quote._Closure\u0024__.\u0024I388\u002D0 = predicate = (System.Func<DataRow, bool>) ([SpecialName] (dr) => dr.Field<int>("RatingTypeID") == 89);
            if (!source.Any<DataRow>(predicate))
            {
              multiCarrierRater = false;
              goto label_12;
            }
          }
          else
          {
            int? raterId = quoteDetail.RaterID;
            if ((raterId.HasValue ? new bool?(raterId.GetValueOrDefault() != 89) : new bool?()).GetValueOrDefault())
            {
              multiCarrierRater = false;
              goto label_12;
            }
          }
        }
      }
      finally
      {
        List<QuoteDetail>.Enumerator enumerator;
        enumerator.Dispose();
      }
      multiCarrierRater = true;
label_12:
      return multiCarrierRater;
    }
  }

  public bool NetRateRatedOptionExists
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<bool>(nameof (NetRateRatedOptionExists), new object[2]
      {
        (object) "@QuoteGuid",
        (object) this._quoteGuid
      });
    }
  }

  public bool RatedInNetRate => this.GetUncachedField<bool>("dbo.IsRatedInNetRate(QuoteGuid)");

  public Decimal AggregatePremium => this.GetUncachedField<Decimal>("dbo.PolicyPremium(ControlNo)");

  public Decimal AggregateFees => this.GetUncachedField<Decimal>("dbo.PolicyFees(ControlNo)");

  public Decimal TerrorismPremium
  {
    get => this.GetUncachedField<Decimal>("dbo.GetTerrorismPremium(QuoteID)");
  }

  public int UnderwritingLocationsCount
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM dbo.tblUnderwritingLocations WITH(NOLOCK) WHERE QuoteGuid=@QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      });
    }
  }

  public bool HasPremium
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM dbo.tblQuoteOptions qo WITH(NOLOCK) JOIN dbo.tblQuoteOptionPremiums qop WITH(NOLOCK) ON qo.QuoteOptionGUID = qop.QuoteOptionGuid WHERE qo.QuoteGUID=@QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      }) > 0;
    }
  }

  public bool HasNonZeroPremiums
  {
    get
    {
      return DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(1) FROM dbo.tblQuoteOptions qo WITH(NOLOCK) JOIN dbo.tblQuoteOptionPremiums qop WITH(NOLOCK) ON qo.QuoteOptionGUID = qop.QuoteOptionGuid WHERE qo.QuoteGUID=@QuoteGuid AND qop.Premium <> 0", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      }) > 0;
    }
  }

  public Quote Current
  {
    get
    {
      Guid quoteGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 QuoteGUID FROM tblQuotes WITH (NOLOCK) WHERE ControlNo=@CN ORDER BY QuoteID DESC", new object[2]
      {
        (object) "@CN",
        (object) this.ControlNo
      });
      return !quoteGuid.Equals(this.QuoteGuid) ? Quote.CreateNew(quoteGuid) : this;
    }
  }

  public bool HasValidCompanyLineGuid
  {
    get
    {
      return this.CompanyLineGuid.HasValue && !this.CompanyLineGuid.Value.Equals(Guid.Empty) || this.HasLineGuid && this.HasCompanyLocationGuid && this.HasStateID && CompanyLine.IsValidCompanyLine(this.CompanyLocationGuid, this.LineGuid, this.StateID, new Guid?());
    }
  }

  public bool IsRated => this.HasPremium;

  public bool RelatedQuotes
  {
    get
    {
      return this.CacheManualValue<bool?>(nameof (RelatedQuotes), (Func<bool?>) ([SpecialName] () =>
      {
        DataRow row = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT COUNT(DISTINCT q.ControlNo) SubmissionQuotes, COUNT(DISTINCT iq.ControlNo) InsuredQuotes FROM dbo.tblSubmissionGroup sg JOIN dbo.tblQuotes q ON q.SubmissionGroupGuid = sg.SubmissionGroupGUID JOIN dbo.tblSubmissionGroup ig ON ig.InsuredGuid = sg.InsuredGuid LEFT JOIN dbo.tblQuotes iq ON iq.SubmissionGroupGuid = ig.SubmissionGroupGUID WHERE sg.SubmissionGroupGUID = @SG", new object[2]
        {
          (object) "@SG",
          (object) this.SubmissionGroupGuid
        });
        return new bool?(row.Field<int>("SubmissionQuotes") != 1 || row.Field<int>("InsuredQuotes") != 1);
      })) ?? false;
    }
  }

  public string DisplayStatus => this.GetUncachedField<string>(nameof (DisplayStatus));

  public string CurrencyCode
  {
    get => this.GetLazyField<string>(nameof (CurrencyCode), "dbo.GetQuoteCurrencyCode(QuoteID)");
  }

  public virtual bool DefaultToFirstPolicyDetailItem
  {
    get
    {
      DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT DISTINCT tcr.RatingTypeId FROM dbo.tblQuoteDetails tqd WITH(NOLOCK) JOIN dbo.tblCompanyRaters tcr WITH(NOLOCK) on tcr.CompanyLineGuid = tqd.CompanyLineGuid WHERE tqd.QuoteGuid=@QuoteGuid", new object[2]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      });
      bool policyDetailItem;
      if (dataTable != null && dataTable.Rows.Count == 1)
      {
        int num = dataTable.Rows[0].Field<int>("RatingTypeId");
        if (num != 0)
        {
          if (DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuoteDetails SET RaterID = @raterId WHERE QuoteGUID = @quoteguid AND RaterID IS NULL", new object[4]
          {
            (object) "@raterId",
            (object) num,
            (object) "@quoteguid",
            (object) this.QuoteGuid
          }) > 0)
            this._quoteDetails?.Clear();
          policyDetailItem = true;
          goto label_7;
        }
      }
      policyDetailItem = false;
label_7:
      return policyDetailItem;
    }
  }

  public QuoteStatus QuoteStatus
  {
    get => (QuoteStatus) this.QuoteStatusID;
    set
    {
      if (value == QuoteStatus.Unknown)
        this.ObjectDataStore.SetField<byte>("QuoteStatusID", this.GetUncachedField<byte>("QuoteStatusID"));
      else
        this.ChangeStatus((int) value);
    }
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  public BillingTypes BillingType
  {
    get => (BillingTypes) this.BillingTypeID.GetValueOrDefault();
    set
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET BillingTypeID = @BillingTypeID WHERE QuoteID = @QuoteID", new object[4]
      {
        (object) "@QuoteID",
        (object) this.QuoteID,
        (object) "@BillingTypeID",
        (object) value
      });
      this.ObjectDataStore.SetField<int>("BillingTypeID", (int) value);
    }
  }

  [TableFieldMapping]
  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard return from RefreshData.")]
  public Guid LineGuid
  {
    get => this.GetField<Guid?>(nameof (LineGuid), nameof (LineGuid)) ?? Guid.Empty;
    set
    {
      if (DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET LineGuid = @LineGuid WHERE QuoteGuid=@QuoteGuid", new object[4]
      {
        (object) "@LineGuid",
        (object) value,
        (object) "@QuoteGuid",
        (object) this.QuoteGuid
      }) == 0)
        throw new IncorrectNumberOfRowsAffectedException();
      this.RefreshData();
    }
  }

  public bool HasLineGuid => !this.LineGuid.Equals(Guid.Empty);

  public virtual bool PolicyNameDiffers => !this.InsuredPolicyName.EqualsNoCase(this.InsuredName);

  public virtual bool PolicyAddressDiffers
  {
    get
    {
      return !this.InsuredAddress1.EqualsNoCase(this.SubmissionGroup.InsuredLocation.Address1) || !this.InsuredAddress2.EqualsNoCase(this.SubmissionGroup.InsuredLocation.Address2) || !this.InsuredCity.EqualsNoCase(this.SubmissionGroup.InsuredLocation.City) || !this.InsuredState.EqualsNoCase(this.SubmissionGroup.InsuredLocation.State) || !this.InsuredZipCode.EqualsNoCase(this.SubmissionGroup.InsuredLocation.ZipCode) || !this.InsuredISOCountryCode.EqualsNoCase(this.SubmissionGroup.InsuredLocation.ISOCountryCode);
    }
  }

  public event Quote.QuoteDeletedEventHandler QuoteDeleted;

  public event Quote.PolicyUnboundEventHandler PolicyUnbound;

  public static Quote CreateNew(Guid quoteGuid) => Quote.CreateNewAs<Quote>(quoteGuid);

  public static Quote CreateNew(int quoteId) => Quote.CreateNewAs<Quote>(quoteId);

  public static T CreateNewAs<T>(Guid quoteGuid) where T : Quote
  {
    return ObjectFactory.Instance.CreateObjectAs<T>((object) quoteGuid);
  }

  public static T CreateNewAs<T>(int quoteId) where T : Quote
  {
    return ObjectFactory.Instance.CreateObjectAs<T>((object) quoteId);
  }

  public static bool ControlNumberExists(int controlNo)
  {
    return DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT TOP 1 1 FROM tblQuotes WHERE ControlNo=@controlNo", new object[2]
    {
      (object) "@controlNo",
      (object) controlNo
    }).HasValue;
  }

  public static Guid GetQuoteGuidFromControlGuid(Guid controlGuid)
  {
    return (DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT TOP 1 QuoteGuid FROM tblQuotes WHERE ControlGuid = @ControlGuid ORDER BY QuoteID DESC", new object[2]
    {
      (object) "@ControlGuid",
      (object) controlGuid
    }) ?? throw new InvalidOperationException("Specified ControlGuid does not exist")).Value;
  }

  public static Guid GetQuoteGuidFromEntityGuid(Guid entityGuid)
  {
    return (DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT TOP(1) QuoteGUID FROM (SELECT QuoteGUID FROM dbo.tblQuotes WITH(NOLOCK) WHERE QuoteGUID = @entityGuid UNION SELECT TOP(1) QuoteGUID FROM dbo.tblQuotes WITH(NOLOCK) WHERE ControlGuid = @entityGuid ORDER BY QuoteID DESC) t", new object[2]
    {
      (object) "@entityGuid",
      (object) entityGuid
    }) ?? throw new InvalidOperationException("Specified Quote does not exist")).Value;
  }

  public static Quote FromEntity(object entity)
  {
    return entity is IRecreatableEntity entity1 ? Quote.FromEntity(entity1) : throw new InvalidCastException("Entity does not implement IRecreatableEntity.");
  }

  public static Quote FromEntity(IRecreatableEntity entity)
  {
    Guid quoteGuid;
    if (entity.HasControlGUID)
    {
      quoteGuid = Quote.GetQuoteGuidFromControlGuid(entity.ControlGUID);
    }
    else
    {
      Guid entityGuid = entity.EntityGuid;
      if (entityGuid == Guid.Empty)
        throw new InvalidOperationException("Could not determine EntityGuid from entity in it's current state.");
      quoteGuid = !Quote.IsControlGuidValid(entityGuid) ? entityGuid : Quote.GetQuoteGuidFromControlGuid(entityGuid);
    }
    try
    {
      return Quote.CreateNew(quoteGuid);
    }
    catch (QuoteGuidNotFoundException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      throw new InvalidOperationException("Could not determine Quote Guid from entity in it's current state.");
    }
  }

  public static bool IsControlGuidValid(Guid controlGuid)
  {
    return DefaultDatabase.ExecuteScalar<bool?>("dbo.IsControlGuidValid", new object[2]
    {
      (object) "@controlGuid",
      (object) controlGuid
    }) ?? false;
  }

  public static Quote FromControlGuid(Guid controlGuid)
  {
    return Quote.CreateNew(Quote.GetQuoteGuidFromControlGuid(controlGuid));
  }

  public static Quote FromControlNo(int controlNo)
  {
    Guid? nullable = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT TOP 1 QuoteGUID FROM dbo.tblQuotes WITH(NOLOCK) WHERE ControlNo=@ControlNo ORDER BY QuoteID DESC", new object[2]
    {
      (object) "@ControlNo",
      (object) controlNo
    });
    return nullable.HasValue ? Quote.CreateNew(nullable.Value) : (Quote) null;
  }

  public static Quote FromQuoteOptionGuid(Guid quoteOptionGuid)
  {
    Guid? nullable = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT QuoteGUID FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteOptionGuid = @QOG", new object[2]
    {
      (object) "@QOG",
      (object) quoteOptionGuid
    });
    return nullable.HasValue ? Quote.CreateNew(nullable.Value) : (Quote) null;
  }

  public static Quote FromQuoteOptionID(int quoteOptionID)
  {
    Guid? nullable = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT QuoteGUID FROM dbo.tblQuoteOptions WITH(NOLOCK) WHERE QuoteOptionID = @QOID", new object[2]
    {
      (object) "@QOID",
      (object) quoteOptionID
    });
    return nullable.HasValue ? Quote.CreateNew(nullable.Value) : (Quote) null;
  }

  public static TransactionTypes GetEndorsementTransactionType(
    QuoteStatus quoteStatus,
    bool forAudit,
    bool isInternalCorrection,
    bool forInstallment)
  {
    TransactionTypes endorsementTransactionType;
    switch (quoteStatus)
    {
      case QuoteStatus.PendingCancellation:
        endorsementTransactionType = TransactionTypes.Cancellation;
        break;
      case QuoteStatus.PendingReinstatement:
        endorsementTransactionType = TransactionTypes.Reinstatement;
        break;
      case QuoteStatus.UnboundCorrection:
        endorsementTransactionType = TransactionTypes.Correction;
        break;
      case QuoteStatus.UnboundInternalCorrection:
        endorsementTransactionType = isInternalCorrection ? TransactionTypes.UpwardInternalCorrection : TransactionTypes.DownwardInternalCorrection;
        break;
      default:
        endorsementTransactionType = forAudit ? TransactionTypes.Audit : (forInstallment ? TransactionTypes.Installment : TransactionTypes.Endorsement);
        break;
    }
    return endorsementTransactionType;
  }

  public bool HasBoundOptions() => this.HasBoundOptions((SqlTransaction) null);

  public bool HasBoundOptions(SqlTransaction t)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__460\u002D0 closure4600 = new Quote._Closure\u0024__460\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure4600.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure4600.\u0024VB\u0024Local_t = t;
    // ISSUE: reference to a compiler-generated field
    if (closure4600.\u0024VB\u0024Local_t != null && !DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure4600.\u0024VB\u0024Local_t, new ExecuteHandler((object) closure4600, __methodptr(_Lambda\u0024__0)));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      closure4600.\u0024VB\u0024Local_HasBoundOptions = closure4600.\u0024VB\u0024Local_HasBoundOptions;
    }
    else
    {
      this._quoteOptions = (List<QuoteOption>) null;
      List<QuoteOption> quoteOptions = this.QuoteOptions;
      System.Func<QuoteOption, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (Quote._Closure\u0024__.\u0024I460\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = Quote._Closure\u0024__.\u0024I460\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Quote._Closure\u0024__.\u0024I460\u002D1 = predicate = (System.Func<QuoteOption, bool>) ([SpecialName] (qo) => qo.Bound);
      }
      int num = quoteOptions.Any<QuoteOption>(predicate) ? 1 : 0;
      // ISSUE: reference to a compiler-generated field
      closure4600.\u0024VB\u0024Local_HasBoundOptions = num != 0;
    }
    // ISSUE: reference to a compiler-generated field
    return closure4600.\u0024VB\u0024Local_HasBoundOptions;
  }

  public Guid GetBoundOptionGuid() => this.GetBoundOptionGuid((SqlTransaction) null);

  public Guid GetBoundOptionGuid(SqlTransaction t)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__462\u002D0 closure4620 = new Quote._Closure\u0024__462\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure4620.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure4620.\u0024VB\u0024Local_t = t;
    // ISSUE: reference to a compiler-generated field
    if (closure4620.\u0024VB\u0024Local_t != null && !DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure4620.\u0024VB\u0024Local_t, new ExecuteHandler((object) closure4620, __methodptr(_Lambda\u0024__0)));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      closure4620.\u0024VB\u0024Local_GetBoundOptionGuid = closure4620.\u0024VB\u0024Local_GetBoundOptionGuid;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      if (!this.HasBoundOptions(closure4620.\u0024VB\u0024Local_t))
        throw new InvalidOperationException("No Bound Option For this QuoteGuid, Call HasBoundOptions prior to calling this function");
      List<QuoteOption> quoteOptions = this.QuoteOptions;
      System.Func<QuoteOption, bool> predicate;
      // ISSUE: reference to a compiler-generated field
      if (Quote._Closure\u0024__.\u0024I462\u002D1 != null)
      {
        // ISSUE: reference to a compiler-generated field
        predicate = Quote._Closure\u0024__.\u0024I462\u002D1;
      }
      else
      {
        // ISSUE: reference to a compiler-generated field
        Quote._Closure\u0024__.\u0024I462\u002D1 = predicate = (System.Func<QuoteOption, bool>) ([SpecialName] (qo) => qo.Bound);
      }
      QuoteOption[] array = quoteOptions.Where<QuoteOption>(predicate).ToArray<QuoteOption>();
      // ISSUE: reference to a compiler-generated field
      closure4620.\u0024VB\u0024Local_GetBoundOptionGuid = array.Length <= 1 ? array[0].QuoteOptionGuid : throw new InvalidOperationException("More than one bound option exists on this policy.");
    }
    // ISSUE: reference to a compiler-generated field
    return closure4620.\u0024VB\u0024Local_GetBoundOptionGuid;
  }

  public Guid[] GetBoundOptionGuids() => this.GetBoundOptionGuids(Guid.Empty);

  public Guid[] GetBoundOptionGuids(Guid lineGuid)
  {
    List<QuoteOption> quoteOptions = this.QuoteOptions;
    if (quoteOptions == null)
      return (Guid[]) null;
    IEnumerable<QuoteOption> source = quoteOptions.Where<QuoteOption>((System.Func<QuoteOption, bool>) ([SpecialName] (qo) =>
    {
      if (!qo.Bound)
        return false;
      Guid guid = Guid.Empty;
      if (guid.Equals(lineGuid))
        return true;
      guid = qo.LineGuid;
      return guid.Equals(lineGuid);
    }));
    System.Func<QuoteOption, Guid> selector;
    // ISSUE: reference to a compiler-generated field
    if (Quote._Closure\u0024__.\u0024I464\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector = Quote._Closure\u0024__.\u0024I464\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      Quote._Closure\u0024__.\u0024I464\u002D1 = selector = (System.Func<QuoteOption, Guid>) ([SpecialName] (qo) => qo.QuoteOptionGuid);
    }
    return source.Select<QuoteOption, Guid>(selector).ToArray<Guid>();
  }

  public void ClearPremiumCache()
  {
    if (this.ObjectDataStore == null)
      return;
    this.ClearValues("Premium", "TotalPremium", "TerrorismPremium", "AggregatePremium");
  }

  public void LogPolicyReinstatementDates(DateTime reinstatementDate, DateTime effectiveDate)
  {
    this.LogPolicyReinstatementDates(reinstatementDate, effectiveDate, new int?());
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  public void LogPolicyReinstatementDates(
    DateTime reinstatementDate,
    DateTime effectiveDate,
    int? IssuanceBatchID)
  {
    Quote quote = this;
    DateTime dateTime1 = reinstatementDate;
    DateTime dateTime2 = effectiveDate;
    int? nullable = IssuanceBatchID;
    DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, (EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (sender, etea) =>
    {
      DefaultDatabase.ExecuteNonQuery("dbo.spFin_LogPolicyReinstatement", new object[8]
      {
        (object) "@controlNumber",
        (object) quote.ControlNo,
        (object) "@reinstatementDate",
        (object) dateTime1,
        (object) "@reinstatementEffective",
        (object) dateTime2,
        (object) "@issuanceBatchId",
        (object) nullable
      });
      etea.Transaction.Commit();
    }));
  }

  public void ChangeStatus(int statusID)
  {
    this.ChangeStatusInternal(statusID, new int?(), (string) null);
  }

  public void ChangeStatus(int statusID, string comments)
  {
    this.ChangeStatusInternal(statusID, new int?(), string.IsNullOrEmpty(comments) ? (string) null : comments);
  }

  public void ChangeStatus(int statusID, int reasonID)
  {
    this.ChangeStatusInternal(statusID, reasonID == -1 ? new int?() : new int?(reasonID), (string) null);
  }

  public void ChangeStatus(int statusId, int reasonID, string comments)
  {
    this.ChangeStatusInternal(statusId, reasonID == -1 ? new int?() : new int?(reasonID), string.IsNullOrEmpty(comments) ? (string) null : comments);
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  private void ChangeStatusInternal(int statusID, int? reasonID, string comments)
  {
    string Left = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Description FROM dbo.lstQuoteStatus WITH(NOLOCK) WHERE QuoteStatusID = @QSID", new object[2]
    {
      (object) "@QSID",
      (object) this.QuoteStatusID
    });
    bool policyIsNonRenewed = this.PolicyIsNonRenewed;
    DefaultDatabase.ExecuteNonQuery("dbo.spChangeQuoteStatus", new object[8]
    {
      (object) "@quoteGuid",
      (object) this.QuoteGuid,
      (object) "@NewStatusID",
      (object) statusID,
      (object) "@NewReasonID",
      (object) reasonID,
      (object) "@Comment",
      (object) comments
    });
    string Right = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Description FROM dbo.lstQuoteStatus WITH(NOLOCK) WHERE QuoteStatusID = @QSID", new object[2]
    {
      (object) "@QSID",
      (object) statusID
    });
    this.ObjectDataStore.SetField<int>("QuoteStatusID", statusID);
    this.ObjectDataStore.SetField<int?>("QuoteStatusReasonID", reasonID);
    Messaging.SendBroadcastMessage(BroadcastMessages.QuoteStatusChanged, (object) this);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) != 0)
    {
      CurrentUser.Instance.LogAction($"Changed status from {Left} to {Right}.", this.QuoteGuid);
    }
    else
    {
      if (statusID != 3 || !policyIsNonRenewed)
        return;
      this.ClearValues("IsPolicyCancelled", "IsNonRenewal");
      if (this.IsNonRenewal)
        return;
      Messaging.SendBroadcastMessage(BroadcastMessages.NonRenewedRescindedNotice, (object) this.QuoteGuid);
      CurrentUser.Instance.LogAction("Non-renewal rescinded.", this.QuoteGuid);
    }
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "OFAC check is fire and forget here. We do not need the return.")]
  public virtual Guid Renew()
  {
    DefaultDatabase.ExecuteTransaction(new EventHandler<ExecuteTransactionEventArgs>(this.RenewTransaction));
    Guid renewedQuoteGuid;
    if (this._renewException != null)
    {
      ExceptionDispatchInfo.Capture(this._renewException).Throw();
    }
    else
    {
      Quote quote = Quote.CreateNew(this._renewedQuoteGuid);
      CurrentUser.Instance.LogAction($"Renewed policy (new control #: {quote.ControlNo})", this.ControlGuid);
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.Policy.Renewal.RunCompliance"))
      {
        bool setting = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.Policy.Renewal.ForceSearch");
        List<IOfacEntity> ofacEntityList = new List<IOfacEntity>();
        OfacSystem.OfacStatus ofacStatus = quote.SubmissionGroup.InsuredLocation.GetOfacStatus();
        if (setting || (ofacStatus != null ? (ofacStatus.IsValid ? 1 : 0) : 0) == 0)
          ofacEntityList.Add((IOfacEntity) quote.SubmissionGroup.InsuredLocation);
        if (quote.SearchQuoteOfac)
        {
          if (!setting)
          {
            OfacSystem.OfacStatus complianceStatus = quote.ComplianceStatus;
            if ((complianceStatus != null ? (complianceStatus.IsValid ? 1 : 0) : 0) != 0)
              goto label_9;
          }
          ofacEntityList.Add((IOfacEntity) quote);
        }
label_9:
        if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.AdditionalInterests.Renewal.RunCompliance"))
        {
          HashSet<string> ofacSearchTypes = AdditionalInterest.OfacSearchTypes;
          closure_0 = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.AdditionalInterests.Renewal.ForceSearch");
          if (ofacSearchTypes.Any<string>())
          {
            Dictionary<AdditionalInterest, OfacSystem.OfacStatus> entityDictionary = OfacSystem.Instance.GetMultipleEntityDictionary<AdditionalInterest>((ICollection<AdditionalInterest>) BaseDataObject.SelectMany<AdditionalInterest>("QuoteID = @QID", (object) "@QID", (object) quote.QuoteID));
            List<IOfacEntity> ofacEntityList1 = closure_1;
            Dictionary<AdditionalInterest, OfacSystem.OfacStatus> source = entityDictionary;
            System.Func<KeyValuePair<AdditionalInterest, OfacSystem.OfacStatus>, bool> predicate = (System.Func<KeyValuePair<AdditionalInterest, OfacSystem.OfacStatus>, bool>) ([SpecialName] (ai) => ai.Key.SupportsRenewalSearch(ai.Value, (ISet<string>) ofacSearchTypes, closure_0));
            System.Func<KeyValuePair<AdditionalInterest, OfacSystem.OfacStatus>, AdditionalInterest> selector;
            // ISSUE: reference to a compiler-generated field
            if (Quote._Closure\u0024__.\u0024I475\u002D1 != null)
            {
              // ISSUE: reference to a compiler-generated field
              selector = Quote._Closure\u0024__.\u0024I475\u002D1;
            }
            else
            {
              // ISSUE: reference to a compiler-generated field
              Quote._Closure\u0024__.\u0024I475\u002D1 = selector = (System.Func<KeyValuePair<AdditionalInterest, OfacSystem.OfacStatus>, AdditionalInterest>) ([SpecialName] (ai) => ai.Key);
            }
            IEnumerable<AdditionalInterest> collection = source.WhereSelect<KeyValuePair<AdditionalInterest, OfacSystem.OfacStatus>, AdditionalInterest>(predicate, selector);
            ofacEntityList1.AddRange((IEnumerable<IOfacEntity>) collection);
          }
        }
        if (ofacEntityList.Any<IOfacEntity>())
        {
          Task task = (Task) Task.Run<bool>((Func<bool>) ([SpecialName] () => OfacSystem.Instance.CheckMultiple(ofacEntityList, (Action<string, string>) null)));
          MDIControls instance = MDIControls.Instance;
          if ((instance != null ? (instance.BlackBoxMode ? 1 : 0) : 0) != 0)
            task.Wait();
        }
      }
      Messaging.SendBroadcastMessage(BroadcastMessages.NewRenewal, (object) this._renewedQuoteGuid);
      renewedQuoteGuid = this._renewedQuoteGuid;
    }
    return renewedQuoteGuid;
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  private void RenewTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    try
    {
      bool flag = false;
      Guid? nullable = DefaultDatabase.ExecuteScalar<Guid?>("dbo.spGetRenewalSubmissionGuid", new object[4]
      {
        (object) "@subGroupGuid",
        (object) this.SubmissionGroupGuid,
        (object) "@prodLocGuid",
        (object) this.ProducerLocationGuid
      });
      Guid guid;
      if (nullable.HasValue)
      {
        guid = nullable.Value;
      }
      else
      {
        guid = DefaultDatabase.ExecuteScalar<Guid>("dbo.CopySubmission", new object[6]
        {
          (object) "@submissionGroupGuid",
          (object) this.SubmissionGroupGuid,
          (object) "@userGuid",
          (object) CurrentUser.Instance.UserGUID,
          (object) "@dateSubmitted",
          (object) CurrentUser.ServerTime
        });
        flag = true;
      }
      Guid newQuoteGuid = DefaultDatabase.ExecuteScalar<Guid>("dbo.spCopyQuote", new object[10]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid,
        (object) "@QuoteStatusID",
        (object) QuoteStatus.Submitted,
        (object) "@newSubmissionGroupGuid",
        (object) guid,
        (object) "@isRenewal",
        (object) true,
        (object) "@copyOptions",
        (object) true
      });
      if (flag)
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblSubmissionGroup SET RenewalOfSubmissionGroupGuid = @renewalOfSubGroupGuid WHERE SubmissionGroupGUID = @subGroupGuid", new object[4]
        {
          (object) "@renewalOfSubGroupGuid",
          (object) this.SubmissionGroupGuid,
          (object) "@subGroupGuid",
          (object) guid
        });
      SqlTransaction transaction = (SqlTransaction) e.Transaction;
      this.CopyRaterInfo(transaction, newQuoteGuid);
      this.CopyQuoteExtended(transaction, newQuoteGuid);
      if (DefaultDatabase.ExecuteScalar<bool>("IsDuplicateRenewal", new object[12]
      {
        (object) "@NewQuoteGuid",
        (object) newQuoteGuid,
        (object) "@OldQuoteGuid",
        (object) this.QuoteGuid,
        (object) "@NewSubmissionGroupGuid",
        (object) guid,
        (object) "@CompanyLocationGuid",
        (object) this.CompanyLocationGuid,
        (object) "@LineGuid",
        (object) this.LineGuid,
        (object) "@PolicyNumber",
        (object) this.PolicyNumber
      }))
        throw new IncorrectNumberOfRenewalsException();
      e.Transaction.Commit();
      this._renewedQuoteGuid = newQuoteGuid;
    }
    catch (IncorrectNumberOfRenewalsException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      this._renewException = (Exception) ex;
      ProjectData.ClearProjectError();
    }
  }

  public Guid Rewrite() => this.Rewrite(3);

  public virtual Guid Rewrite(int newPolicyTypeID)
  {
    Quote quote = this;
    Guid guid = Guid.Empty;
    DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, (EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (sender, etea) =>
    {
      guid = quote.RewriteTransaction(RuntimeHelpers.GetObjectValue(sender), etea);
      etea.Transaction.Commit();
    }), (object) newPolicyTypeID);
    return guid;
  }

  private Guid RewriteTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    Guid newQuoteGuid = DefaultDatabase.ExecuteScalar<Guid>("dbo.spCopyQuote", new object[12]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid,
      (object) "@QuoteStatusID",
      (object) QuoteStatus.Submitted,
      (object) "@newSubmissionGroupGuid",
      (object) this.SubmissionGroupGuid,
      (object) "@isRenewal",
      (object) false,
      (object) "@isRewrite",
      (object) true,
      (object) "@PolicyTypeID",
      e.Context
    });
    SqlTransaction transaction = (SqlTransaction) e.Transaction;
    this.CopyRaterInfo(transaction, newQuoteGuid);
    this.CopyQuoteExtended(transaction, newQuoteGuid);
    return newQuoteGuid;
  }

  public Guid Copy() => this.Copy(Guid.Empty);

  public Guid CopyWithoutOptions(Guid newSubmissionGroupGuid)
  {
    return this.Copy(newSubmissionGroupGuid, false);
  }

  public Guid Copy(Guid newSubmissionGroupGuid) => this.Copy(newSubmissionGroupGuid, true);

  public Guid Copy(Guid newSubmissionGroupGuid, bool copyOptions)
  {
    Quote quote = this;
    Guid guid = Guid.Empty;
    DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, (EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (sender, etea) =>
    {
      guid = quote.CopyTransaction(RuntimeHelpers.GetObjectValue(sender), etea);
      etea.Transaction.Commit();
    }), (object) new object[2]
    {
      (object) newSubmissionGroupGuid,
      (object) copyOptions
    });
    return guid;
  }

  protected virtual Guid CopyTransaction(object sender, ExecuteTransactionEventArgs e)
  {
    object[] context = (object[]) e.Context;
    Guid? nullable;
    if (context[0] is Guid && !((Guid) context[0]).Equals(Guid.Empty))
      nullable = new Guid?((Guid) context[0]);
    bool flag = (bool) context[1];
    Guid newQuoteGuid = DefaultDatabase.ExecuteScalar<Guid>("dbo.spCopyQuote", new object[6]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid,
      (object) "@newSubmissionGroupGuid",
      (object) nullable,
      (object) "@copyOptions",
      (object) flag
    });
    this.CopyQuoteExtended((SqlTransaction) e.Transaction, newQuoteGuid);
    return !newQuoteGuid.Equals(Guid.Empty) ? newQuoteGuid : throw new InvalidOperationException("Failed to copy quote");
  }

  protected virtual void CopyQuoteExtended(SqlTransaction t, Guid newQuoteGuid)
  {
  }

  public virtual bool CreateAfterClientValidation(Guid submissionGroupGuid) => true;

  public void ConvertQuickToFull()
  {
    this.ConvertQuickToFull((Quote.ConvertQuickToFullContact[]) null);
  }

  public void ConvertQuickToFull(Quote.ConvertQuickToFullContact[] contacts)
  {
    if (!this.IsQuickQuote)
      throw new InvalidOperationException("ConvertQuickToFull can only be called when the quote is a QuickQuote");
    if (!this.HasValidCompanyLineGuid)
      throw new InvalidOperationException("ConvertQuickToFull requires that the quote have a valid company/line guid");
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.QuoteEditData_GetPolicyParticipants", new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) this.CompanyLineGuid
    });
    dsQuickToFull.tblQuoteDetailsDataTable detailsDataTable = new dsQuickToFull.tblQuoteDetailsDataTable();
    if (dataTable.Columns.Count > 2)
    {
      try
      {
        foreach (DataRow row1 in dataTable.Rows)
        {
          dsQuickToFull.tblQuoteDetailsRow row2 = detailsDataTable.NewtblQuoteDetailsRow();
          dsQuickToFull.tblQuoteDetailsRow tblQuoteDetailsRow = row2;
          tblQuoteDetailsRow.QuoteGuid = this.QuoteGuid;
          tblQuoteDetailsRow.CompanyLineGuid = row1.Field<Guid>("CompanyLineGuid");
          tblQuoteDetailsRow.TermsOfPayment = row1.Field<int>("TermsOfPayment");
          detailsDataTable.AddtblQuoteDetailsRow(row2);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
    {
      DataRow row3 = dataTable.Rows[0];
      dsQuickToFull.tblQuoteDetailsRow row4 = detailsDataTable.NewtblQuoteDetailsRow();
      dsQuickToFull.tblQuoteDetailsRow tblQuoteDetailsRow = row4;
      tblQuoteDetailsRow.QuoteGuid = this.QuoteGuid;
      tblQuoteDetailsRow.CompanyLineGuid = this.CompanyLineGuid.Value;
      tblQuoteDetailsRow.TermsOfPayment = Convert.ToInt32(RuntimeHelpers.GetObjectValue(row3["TermsOfPayment"]));
      detailsDataTable.AddtblQuoteDetailsRow(row4);
    }
    ProducerLocation producerLocation = this.ProducerLocation;
    try
    {
      foreach (dsQuickToFull.tblQuoteDetailsRow tblQuoteDetailsRow in (TypedTableBase<dsQuickToFull.tblQuoteDetailsRow>) detailsDataTable)
      {
        CompanyLine objectAs = ObjectFactory.Instance.CreateObjectAs<CompanyLine>((object) tblQuoteDetailsRow.CompanyLineGuid);
        tblQuoteDetailsRow.ProducerCommission = producerLocation.GetCommission(tblQuoteDetailsRow.CompanyLineGuid, this.IsRenewal, this.EffectiveDate, (SqlTransaction) null, (object) this.PolicyTypeID, (object) null, this.QuotingLocationGuid);
        tblQuoteDetailsRow.CompanyCommission = objectAs.GetCommission(this.IsRenewal, this.ProducerLocationGuid, tblQuoteDetailsRow.ProducerCommission, this.EffectiveDate, 1, (SqlTransaction) null, Guid.Empty, (object) null, this.QuotingLocationGuid);
        bool usingIntermediary = objectAs.CompanyLocation.UsingIntermediary;
        Quote.ConvertQuickToFullContact contact = Quote.GetContact(contacts, tblQuoteDetailsRow.CompanyLineGuid);
        if (contacts == null || contact == null)
        {
          if (usingIntermediary)
            tblQuoteDetailsRow.IntermediaryContactGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 IntermediaryContactGuid FROM dbo.tblIntermediaryContacts WITH(NOLOCK) WHERE IntermediaryID = @intermediaryID", new object[2]
            {
              (object) "@intermediaryID",
              (object) objectAs.CompanyLocation.IntermediaryID
            });
          else
            tblQuoteDetailsRow.CompanyContactGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT TOP 1 CompanyContactGuid FROM dbo.tblCompanyContacts WITH(NOLOCK) WHERE CompanyLocationGuid = @CompanyLocationGuid", new object[2]
            {
              (object) "@CompanyLocationGuid",
              (object) objectAs.CompanyLocationGuid
            });
        }
        else
        {
          if (usingIntermediary ^ contact.IsIntermediaryContact)
            throw new InvalidOperationException("Company Location / Intermediary Contact Type Mismatch");
          if (usingIntermediary)
            tblQuoteDetailsRow.IntermediaryContactGuid = contact.ContactGuid;
          else
            tblQuoteDetailsRow.CompanyContactGuid = contact.ContactGuid;
        }
      }
    }
    finally
    {
      IEnumerator<dsQuickToFull.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
    DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, new EventHandler<ExecuteTransactionEventArgs>(this.InsertDetailRows), (object) detailsDataTable);
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  private void InsertDetailRows(object sender, ExecuteTransactionEventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET QuickQuote = 0 WHERE QuoteGuid = @QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    });
    dsQuickToFull.tblQuoteDetailsDataTable context = (dsQuickToFull.tblQuoteDetailsDataTable) e.Context;
    try
    {
      foreach (dsQuickToFull.tblQuoteDetailsRow tblQuoteDetailsRow in (TypedTableBase<dsQuickToFull.tblQuoteDetailsRow>) context)
      {
        Guid? nullable1 = new Guid?();
        Guid? nullable2 = new Guid?();
        if (!tblQuoteDetailsRow.IsIntermediaryContactGuidNull())
          nullable1 = new Guid?(tblQuoteDetailsRow.IntermediaryContactGuid);
        if (!tblQuoteDetailsRow.IsCompanyCommissionNull())
          nullable2 = new Guid?(tblQuoteDetailsRow.CompanyContactGuid);
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblQuoteDetails(QuoteGuid, CompanyLineGuid, TermsOfPayment, ProducerCommission, CompanyCommission, CompanyContactGuid, IntermediaryContactGuid) VALUES(@QuoteGuid, @CompanyLineGuid, @TermsOfPayment, @ProducerCommission, @CompanyCommission, @CompanyContactGuid, @IntermediaryContactGuid)", new object[14]
        {
          (object) "@QuoteGuid",
          (object) this.QuoteGuid,
          (object) "@CompanyLineGuid",
          (object) tblQuoteDetailsRow.CompanyLineGuid,
          (object) "@TermsOfPayment",
          (object) tblQuoteDetailsRow.TermsOfPayment,
          (object) "@ProducerCommission",
          (object) tblQuoteDetailsRow.ProducerCommission,
          (object) "@CompanyCommission",
          (object) tblQuoteDetailsRow.CompanyCommission,
          (object) "@CompanyContactGuid",
          (object) nullable2,
          (object) "@IntermediaryContactGuid",
          (object) nullable1
        });
      }
    }
    finally
    {
      IEnumerator<dsQuickToFull.tblQuoteDetailsRow> enumerator;
      enumerator?.Dispose();
    }
    e.Transaction.Commit();
  }

  private static Quote.ConvertQuickToFullContact GetContact(
    Quote.ConvertQuickToFullContact[] contacts,
    Guid companyLineGuid)
  {
    Quote.ConvertQuickToFullContact contact;
    if (contacts == null)
    {
      contact = (Quote.ConvertQuickToFullContact) null;
    }
    else
    {
      Quote.ConvertQuickToFullContact[] quickToFullContactArray = contacts;
      int index = 0;
      while (index < quickToFullContactArray.Length)
      {
        Quote.ConvertQuickToFullContact quickToFullContact = quickToFullContactArray[index];
        if (quickToFullContact.CompanyLineGuid.Equals(companyLineGuid))
        {
          contact = quickToFullContact;
          goto label_8;
        }
        checked { ++index; }
      }
      contact = (Quote.ConvertQuickToFullContact) null;
    }
label_8:
    return contact;
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  public virtual bool UnIssue()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET DateIssued=NULL, IssuedByUserID=NULL WHERE QuoteGuid=@QuoteGuid", new object[2]
    {
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    });
    return true;
  }

  public void IssueEndorsement(int userID)
  {
    if (!this.IsEndorsement)
      throw new InvalidOperationException("Not an endorsement");
    if (this.DateIssued.HasValue)
      return;
    this.IssueTransaction(userID, CurrentUser.ServerTime);
  }

  public virtual void IssuePolicy(int userID)
  {
    if (!this.IsBound && !this.IsEndorsement)
      throw new InvalidOperationException("Can not issue an unbound policy");
    if (this.PolicyIsIssued)
      throw new InvalidOperationException("Policy has already been issued");
    if (this.IsIssued)
      return;
    this.IssueTransaction(userID, CurrentUser.ServerTime);
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  private void IssueTransaction(int userId, DateTime curDate)
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET DateIssued=@DateIssued, IssuedByUserID=@IssuedByUserID WHERE QuoteGuid=@QuoteGuid", new object[6]
    {
      (object) "@DateIssued",
      (object) curDate,
      (object) "@IssuedByUserID",
      (object) userId,
      (object) "@QuoteGuid",
      (object) this.QuoteGuid
    });
    this.ObjectDataStore.SetField<DateTime>("DateIssued", curDate);
    this.ClearValues("PolicyDateIssued");
  }

  public void UpdateBoundStatus(SqlTransaction trans) => this.UpdateBoundStatus(trans, true);

  public void UpdateBoundStatus(SqlTransaction trans, bool sendBroadcastMessage)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__497\u002D0 closure4970 = new Quote._Closure\u0024__497\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure4970.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure4970.\u0024VB\u0024Local_trans = trans;
    // ISSUE: reference to a compiler-generated field
    closure4970.\u0024VB\u0024Local_sendBroadcastMessage = sendBroadcastMessage;
    if (!DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      if (closure4970.\u0024VB\u0024Local_trans == null)
        throw new ArgumentNullException(nameof (trans));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure4970.\u0024VB\u0024Local_trans, new ExecuteHandler((object) closure4970, __methodptr(_Lambda\u0024__0)));
    }
    else
    {
      int num;
      if (CurrentUser.Instance.UserID == 0)
        num = ConfigurationManager.AppSettings["BoundByUserID"] != null ? Conversions.ToInteger(ConfigurationManager.AppSettings["BoundByUserID"]) : throw new InvalidOperationException("Could not determine the current user ID");
      else
        num = CurrentUser.Instance.UserID;
      if (DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET QuoteStatusID=@QSID, DateBound=GETDATE(), BoundByUserID=@UID WHERE QuoteGuid=@QGUID", new object[6]
      {
        (object) "@QSID",
        (object) (int) this.NextBoundStatus,
        (object) "@UID",
        (object) num,
        (object) "@QGUID",
        (object) this.QuoteGuid
      }) == 0)
        throw new InvalidOperationException("Could not update the policy status during the update status.");
      if (!this.IsOriginalQuoteRecord && this.PreviousQuoteStatus == QuoteStatus.NoticeofCancellation)
      {
        short? nullable1 = DefaultDatabase.ExecuteScalar<short?>(CommandType.Text, "SELECT ID FROM dbo.lstQuoteStatusReasons WITH(NOLOCK) WHERE AutomationID=@NonPayReason", new object[2]
        {
          (object) "@NonPayReason",
          (object) "NONPAY"
        });
        int? nullable2 = nullable1.HasValue ? new int?((int) nullable1.GetValueOrDefault()) : new int?();
        if (!nullable2.HasValue)
          throw new InvalidOperationException("Could not find non-payment status (NONPAY)");
        if (this.PreviousQuote.HasQuoteStatusReason)
        {
          int? quoteStatusReasonId = this.PreviousQuote.QuoteStatusReasonID;
          if (!(quoteStatusReasonId.HasValue & nullable2.HasValue ? new bool?(quoteStatusReasonId.GetValueOrDefault() == nullable2.GetValueOrDefault()) : new bool?()).GetValueOrDefault())
            goto label_18;
        }
        if (DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET QuoteStatusReasonID=@RID WHERE QuoteGuid=@QGUID", new object[4]
        {
          (object) "@RID",
          (object) nullable2,
          (object) "@QGUID",
          (object) this.QuoteGuid
        }) == 0)
          throw new InvalidOperationException("Could not update the policy reason ID during the update of quote status reasonID.");
      }
label_18:
      if (this.NextBoundStatus == QuoteStatus.Cancelled && this.QuoteStatus == QuoteStatus.PendingCancellation || this.NextBoundStatus == QuoteStatus.Bound && this.QuoteStatus == QuoteStatus.PendingReinstatement)
      {
        // ISSUE: reference to a compiler-generated field
        this.PostCancellationSteps(closure4970.\u0024VB\u0024Local_trans);
      }
      // ISSUE: reference to a compiler-generated field
      if (!closure4970.\u0024VB\u0024Local_sendBroadcastMessage)
        return;
      Quote context = Quote.CreateNew(this.QuoteGuid);
      Messaging.SendBroadcastMessage(BroadcastMessages.QuoteStatusChanged, (object) context);
    }
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  public void PostCancellationSteps(SqlTransaction trans)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__498\u002D0 closure4980 = new Quote._Closure\u0024__498\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure4980.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure4980.\u0024VB\u0024Local_trans = trans;
    if (!DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      if (closure4980.\u0024VB\u0024Local_trans == null)
        throw new ArgumentNullException(nameof (trans));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure4980.\u0024VB\u0024Local_trans, new ExecuteHandler((object) closure4980, __methodptr(_Lambda\u0024__0)));
    }
    else if (this.QuoteStatus != QuoteStatus.PendingReinstatement)
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET ExpirationDate=EndorsementEffective WHERE QuoteGuid=@QGUID", new object[2]
      {
        (object) "@QGUID",
        (object) this.QuoteGuid
      });
    else
      DefaultDatabase.ExecuteNonQuery("dbo.[SetExpDateOnReInstatedPolicy]", new object[4]
      {
        (object) "@controlNo",
        (object) this.ControlNo,
        (object) "@quoteID",
        (object) this.QuoteID
      });
  }

  public virtual void AutoApplyFees(Guid quoteOptionGuid)
  {
    this.AutoApplyFees(quoteOptionGuid, (SqlTransaction) null);
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  public virtual void AutoApplyFees(Guid quoteOptionGuid, SqlTransaction trans)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__500\u002D0 closure5000 = new Quote._Closure\u0024__500\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure5000.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure5000.\u0024VB\u0024Local_quoteOptionGuid = quoteOptionGuid;
    // ISSUE: reference to a compiler-generated field
    closure5000.\u0024VB\u0024Local_trans = trans;
    // ISSUE: reference to a compiler-generated field
    if (closure5000.\u0024VB\u0024Local_trans != null && !DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure5000.\u0024VB\u0024Local_trans, new ExecuteHandler((object) closure5000, __methodptr(_Lambda\u0024__0)));
    }
    else
    {
      try
      {
        // ISSUE: reference to a compiler-generated field
        DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spAutoApplyFees", 300, (CommandArgumentType) 0, new object[2]
        {
          (object) "@QuoteOptionGuid",
          (object) closure5000.\u0024VB\u0024Local_quoteOptionGuid
        });
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        SqlException innerException = ex;
        if (innerException.State == (byte) 50 && !this.UsingNetRate)
        {
          MDIControls instance = MDIControls.Instance;
          if ((instance != null ? (instance.BlackBoxMode ? 1 : 0) : 0) == 0)
            throw new Exception("Exception during AutoApplyFees process. Error: " + innerException.Message, (Exception) innerException);
          MGASystems.Common.ThreadingFunctions.MessageBox.Show(innerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ProjectData.ClearProjectError();
        }
        else
          throw;
      }
    }
  }

  public virtual bool HasRater(params int[] raterIDs)
  {
    if (raterIDs == null || raterIDs.Length == 0)
      raterIDs = new int[0];
    List<QuoteDetail> quoteDetails = this.QuoteDetails;
    int? raterId;
    return quoteDetails != null && quoteDetails.Any<QuoteDetail>((System.Func<QuoteDetail, bool>) ([SpecialName] (qd) => ((IEnumerable<int>) raterIDs).Contains<int>((raterId = qd.RaterID).HasValue ? raterId.GetValueOrDefault() : -1)));
  }

  public virtual void InternalCreate(Guid submissionGroupGuid)
  {
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  public void ResetPolicyForms()
  {
    if (this.IsBound)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET PolicyFormsAutoApplied = 0 WHERE QuoteGuid = @QG", new object[2]
    {
      (object) "@QG",
      (object) this.QuoteGuid
    });
  }

  public virtual void Delete()
  {
    if (this.ValidInvoiceCount > 0)
      throw new InvoicesExistException();
    this.DeleteControl();
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  public void DeleteControl()
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (sender, etea) =>
    {
      DefaultDatabase.ExecuteNonQuery("dbo.spDeleteQuote", new object[4]
      {
        (object) "@controlNo",
        (object) this.ControlNo,
        (object) "@specifiedQuoteGuid",
        (object) this.QuoteGuid
      });
      // ISSUE: reference to a compiler-generated field
      Quote.QuoteDeletedEventHandler quoteDeletedEvent = this.QuoteDeletedEvent;
      if (quoteDeletedEvent != null)
        quoteDeletedEvent(RuntimeHelpers.GetObjectValue(sender), new QuoteEventArgs(this));
      etea.Transaction.Commit();
    }));
  }

  public Decimal CalculateFactor(EndorsementCalcTypes calcType, DateTime effectiveDate)
  {
    string str = string.Empty;
    switch (calcType)
    {
      case EndorsementCalcTypes.ProRata:
        str = "P";
        break;
      case EndorsementCalcTypes.ShortRate:
        str = "S";
        break;
      case EndorsementCalcTypes.Flat:
        str = "F";
        break;
    }
    return DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT dbo.CalculateEndorsementFactor(@policyDays, @calculationType, @effectiveDate, @expirationDate)", new object[8]
    {
      (object) "@policyDays",
      (object) this.PolicyDays,
      (object) "@calculationType",
      (object) str,
      (object) "@effectiveDate",
      (object) effectiveDate,
      (object) "@expirationDate",
      (object) this.ExpirationDate
    });
  }

  public int PolicyDays
  {
    get
    {
      int policyDays;
      if (DateAndTime.DateDiff(DateInterval.Day, this.EffectiveDate, this.ExpirationDate) >= 366L)
      {
        DateTime dateTime = this.ExpirationDate;
        if (!DateTime.IsLeapYear(dateTime.Year))
        {
          dateTime = this.EffectiveDate;
          if (!DateTime.IsLeapYear(dateTime.Year))
            goto label_4;
        }
        policyDays = (int) DateAndTime.DateDiff(DateInterval.Day, this.EffectiveDate, this.ExpirationDate) - 1;
        goto label_5;
      }
label_4:
      policyDays = !this.IsEndorsement ? 365 : (int) DateAndTime.DateDiff(DateInterval.Day, this.EffectiveDate, this.ExpirationDate);
label_5:
      return policyDays;
    }
  }

  public Decimal DefaultFactor()
  {
    return DefaultDatabase.ExecuteScalar<Decimal>(CommandType.Text, "SELECT dbo.CalculateQuoteEndorsementFactor(@quoteGuid, @endorsementCalcType, @endorsementEffective)", new object[6]
    {
      (object) "@quoteGuid",
      (object) this.QuoteGuid,
      (object) "@endorsementCalcType",
      this.IsEndorsement ? (object) this.EndorsementCalcType : (object) "P",
      (object) "@endorsementEffective",
      (object) (this.IsEndorsement ? this.EndorsementEffective : this.EffectiveDate)
    });
  }

  public bool QuoteIsManualPolicyNumberEntry
  {
    get
    {
      return this.GetLazyField<bool>(nameof (QuoteIsManualPolicyNumberEntry), $"dbo.IsManualPolicyNumberEntry({"QuoteID"})");
    }
  }

  public bool IsManualPolicyNumberEntry()
  {
    return this.CacheManualValue<bool>(nameof (IsManualPolicyNumberEntry), (Func<bool>) ([SpecialName] () => this.IsManualPolicyNumberEntry(this.ResolvedPolicyNumberRuleID)));
  }

  public bool IsManualPolicyNumberEntry(int? RuleID)
  {
    bool flag;
    if (RuleID.HasValue)
      flag = DefaultDatabase.ExecuteScalar<bool?>(CommandType.Text, "SELECT Manual FROM dbo.tblPolicyNumberRules WITH (NOLOCK) WHERE RuleID = @RuleID", new object[2]
      {
        (object) "@RuleID",
        (object) RuleID
      }) ?? true;
    else
      flag = this.QuoteIsManualPolicyNumberEntry;
    return flag;
  }

  public void BindWithZeroPremium(int userID)
  {
    if (!DefaultDatabase.HasTransaction)
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (sender, etea) =>
      {
        this.UpdateBoundStatus((SqlTransaction) etea.Transaction);
        etea.Transaction.Commit();
      }));
    else
      this.UpdateBoundStatus((SqlTransaction) DefaultDatabase.Transaction);
    if (this.IsEndorsement)
    {
      CurrentUser.Instance.LogAction("Bind Endorsement. Control# " + this.ControlNo.ToString(), this.QuoteGuid);
      this.IssueEndorsement(userID);
      this.SendPostBinderBroadcastMessages();
    }
    else
      Messaging.SendBroadcastMessage(BroadcastMessages.ZeroPremiumBinder, (object) this.QuoteGuid);
  }

  public virtual void BindNonMonetaryEndorsement(int userID)
  {
    if (!this.IsEndorsement)
      throw new InvalidOperationException("Can not bind a non-monetary endorsement when the quote is not an endorsement");
    this.BindWithZeroPremium(userID);
  }

  public void ResetQuoteStatus() => this.QuoteStatus = QuoteStatus.Unknown;

  public void Unbind(bool keepExistingAffidavitNumbers, bool keepPolicyNumber, Guid userGuid)
  {
    DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, new EventHandler<ExecuteTransactionEventArgs>(this.UnbindTransactionHandler), (object) new object[3]
    {
      (object) keepExistingAffidavitNumbers,
      (object) keepPolicyNumber,
      (object) userGuid
    });
  }

  public void Unbind(
    bool keepExistingAffidavitNumbers,
    bool keepPolicyNumber,
    Guid userGuid,
    int[] clearPNFromQuoteDetailIds)
  {
    DefaultDatabase.ExecuteTransaction(IsolationLevel.ReadCommitted, new EventHandler<ExecuteTransactionEventArgs>(this.UnbindTransactionHandler), (object) new object[4]
    {
      (object) keepExistingAffidavitNumbers,
      (object) keepPolicyNumber,
      (object) userGuid,
      (object) clearPNFromQuoteDetailIds
    });
    Quote context = Quote.CreateNew(this.QuoteGuid);
    Messaging.SendBroadcastMessage(BroadcastMessages.QuoteStatusChanged, (object) context);
    Messaging.SendBroadcastMessage(BroadcastMessages.TransactionUnbound, (object) context.QuoteGuid);
  }

  protected virtual int UnbindCommandTimeout => 90;

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  private void UnbindTransactionHandler(object sender, ExecuteTransactionEventArgs e)
  {
    QuoteStatus quoteStatus1 = this.QuoteStatus;
    int quoteStatusId = this.QuoteStatusID;
    QuoteStatus quoteStatus2;
    if (this.IsEndorsement)
    {
      if (this.OriginalQuoteStatusID.Value == 8)
      {
        quoteStatus2 = QuoteStatus.PendingReinstatement;
      }
      else
      {
        switch (quoteStatus1)
        {
          case QuoteStatus.Cancelled:
            quoteStatus2 = QuoteStatus.PendingCancellation;
            break;
          case QuoteStatus.NonRenewed:
            quoteStatus2 = QuoteStatus.UnboundNonRenewal;
            break;
          case QuoteStatus.NonRenewalRescinded:
            quoteStatus2 = QuoteStatus.UnboundNonRenewalRescinded;
            break;
          default:
            quoteStatus2 = QuoteStatus.UnboundEndorsement;
            break;
        }
      }
    }
    else
      quoteStatus2 = QuoteStatus.Submitted;
    object[] context = (object[]) e.Context;
    bool flag1 = (bool) context[0];
    bool flag2 = (bool) context[1];
    Guid guid = (Guid) context[2];
    int[] numArray = context.Length != 4 ? new int[0] : (int[]) context[3];
    try
    {
      DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, this.GetUnbindProcedureName(), this.UnbindCommandTimeout, (CommandArgumentType) 0, new object[10]
      {
        (object) "@quoteGuid",
        (object) this._quoteGuid,
        (object) "@userGuid",
        (object) guid,
        (object) "@newQuoteStatusID",
        (object) (int) quoteStatus2,
        (object) "@keepPolicyNumber",
        (object) flag2,
        (object) "@keepExistingAffidavitNumbers",
        (object) flag1
      });
      this.ResetQuoteStatus();
      if (!flag2)
        DefaultDatabase.ExecuteNonQuery("dbo.spPolicyNumberingClearUsedTablePolicyNumber", new object[2]
        {
          (object) "@QuoteGuid",
          (object) this.QuoteGuid
        });
      try
      {
        object[] objArray = new object[1]
        {
          (object) numArray
        };
        foreach (QuoteDetail quoteDetail in BaseDataObject.SelectMultiple<QuoteDetail>(objArray))
        {
          DefaultDatabase.ExecuteNonQuery("dbo.spClearUsedPolicyNumberFromQuoteDetail", new object[2]
          {
            (object) "@QuoteDetailId",
            (object) quoteDetail.QuoteDetailID
          });
          CurrentUser.Instance.LogAction($"Unbinding. Clear child policy # {quoteDetail.PolicyNumber} on {quoteDetail.CompanyLine.CompanyLineState}", this.QuoteGuid);
        }
      }
      finally
      {
        List<QuoteDetail>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (ex.State == (byte) 55)
        throw new UnbindClosedAccountingMonthException();
      throw;
    }
    e.Transaction.Commit();
  }

  protected virtual string GetUnbindProcedureName() => "dbo.spUnbindPolicy";

  protected virtual bool GetCanUnbind() => this.IsBound && !this.IsCancelled && !this.UnderNotice;

  public void SendPostBinderBroadcastMessages()
  {
    this.ResetQuoteStatus();
    if (this.IsEndorsement)
    {
      if (this.IsAuditTransaction)
      {
        Messaging.SendBroadcastMessage(BroadcastMessages.AuditCreated, (object) this.QuoteGuid);
        Messaging.SendBroadcastMessage(BroadcastMessages.AuditBound, (object) this.QuoteGuid);
      }
      else if (this.QuoteStatus == QuoteStatus.Cancelled)
        Messaging.SendBroadcastMessage(BroadcastMessages.PolicyCancelled, (object) this.QuoteGuid);
      else if (this.IsReinstated)
        Messaging.SendBroadcastMessage(BroadcastMessages.PolicyReinstated, (object) this.QuoteGuid);
      else
        Messaging.SendBroadcastMessage(BroadcastMessages.EndorsementBound, (object) this.QuoteGuid);
    }
    else
    {
      if (this.IsRenewal)
        Messaging.SendBroadcastMessage(BroadcastMessages.RenewalBound, (object) this.QuoteGuid);
      else
        Messaging.SendBroadcastMessage(BroadcastMessages.PolicyBound, (object) this.QuoteGuid);
      CurrentUser.Instance.LogAction("Print Binder", this.QuoteGuid);
    }
  }

  public bool ValidEndorsementEffectiveDate()
  {
    return !this.HasEndorsementEffectiveDate || this.ValidEndorsementEffectiveDate(this.EndorsementEffective);
  }

  public bool ValidEndorsementEffectiveDate(DateTime endorsementEffectiveDate)
  {
    bool flag;
    if (!this.IsEndorsement)
      flag = true;
    else if (this.QuoteStatus == QuoteStatus.PendingReinstatement)
      flag = true;
    else
      flag = DefaultDatabase.ExecuteScalar<bool>("dbo.spValidateEndorsementEffectiveDate", new object[4]
      {
        (object) "@QuoteID",
        (object) this.QuoteID,
        (object) "@EndorsementEffective",
        (object) endorsementEffectiveDate
      });
    return flag;
  }

  public virtual bool CanRemoveRenewalLink() => true;

  public bool ChangeCompanyLine(
    Guid NewCompanyLocationGuid,
    Guid NewLineGuid,
    string NewStateID,
    bool? KeepRenewalSequence,
    bool? KeepPolicyNumber)
  {
    return this.ChangeCompanyLine(new CompanyLine(NewCompanyLocationGuid, NewLineGuid, NewStateID, new Guid?()), KeepRenewalSequence, KeepPolicyNumber);
  }

  public bool ChangeCompanyLine(
    CompanyLine NewCompanyLine,
    bool? KeepRenewalSequence,
    bool? KeepPolicyNumber)
  {
    return this.ChangeCompanyLineEffective(NewCompanyLine, new DateTime?(), new DateTime?(), KeepRenewalSequence, KeepPolicyNumber);
  }

  public bool ChangeEffectiveDate(
    DateTime NewEffective,
    DateTime NewExpiration,
    bool? KeepPolicyNumber)
  {
    return this.ChangeCompanyLineEffective((CompanyLine) null, new DateTime?(NewEffective), new DateTime?(NewExpiration), new bool?(), KeepPolicyNumber);
  }

  public bool ChangeCompanyLineEffective(
    CompanyLine NewCompanyLine,
    DateTime? NewEffective,
    DateTime? NewExpiration,
    bool? KeepRenewalSequence,
    bool? KeepPolicyNumber)
  {
    Quote quote = this;
    CompanyLine companyLine = NewCompanyLine;
    DateTime? nullable1 = NewEffective;
    DateTime? nullable2 = NewExpiration;
    bool? nullable3 = KeepRenewalSequence;
    bool? nullable4 = KeepPolicyNumber;
    if (!DefaultDatabase.HasTransaction)
    {
      bool flag = false;
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ([SpecialName] (obj, eth) =>
      {
        flag = closure_5.ChangeCompanyLineEffective(closure_0, closure_1, closure_2, closure_3, closure_4);
        if (!flag)
          return;
        eth.Transaction.Commit();
      }));
      return flag;
    }
    if (this.IsTransactionBound)
      return false;
    if (this.IsEndorsement && nullable1.HasValue)
      throw new InvalidOperationException("Cannot update Effective on endorsements");
    DateTime date;
    int num1;
    if (nullable1.HasValue)
    {
      date = nullable1.Value;
      date = date.Date;
      num1 = !date.Equals(this.EffectiveDate.Date) ? 1 : 0;
    }
    else
      num1 = 0;
    bool flag1 = num1 != 0;
    int num2;
    if (nullable2.HasValue)
    {
      date = nullable2.Value;
      date = date.Date;
      num2 = !date.Equals(this.ExpirationDate.Date) ? 1 : 0;
    }
    else
      num2 = 0;
    bool flag2 = num2 != 0;
    bool flag3 = flag1 || flag2;
    bool flag4 = companyLine != null && companyLine.RecordExists() && !companyLine.CompanyLineGuid.Equals((object) this.CompanyLineGuid);
    if (!flag3 && !flag4)
      return false;
    try
    {
      if (!nullable3.HasValue)
        nullable3 = new bool?(MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("QuoteInformation.KeepSequenceOnCompanyChange"));
      if (!nullable4.HasValue)
        nullable4 = new bool?(!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("QuoteInformation.PromptResetPolicy"));
      int? policyNumberRuleId1 = this.ResolvedPolicyNumberRuleID;
      if (flag4 || flag1)
      {
        DefaultDatabase.ExecuteNonQuery("dbo.DeleteOptionsOnChangeOfCompany", new object[2]
        {
          (object) "@quoteGuid",
          (object) this.QuoteGuid
        });
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM dbo.tblQuoteDetails WHERE QuoteGuid = @QG", new object[2]
        {
          (object) "@QG",
          (object) this.QuoteGuid
        });
        this._quoteDetails?.Clear();
        this._quoteOptions?.Clear();
      }
      bool? nullable;
      if (flag4)
      {
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET LineGuid = @LG, CompanyLocationGuid = @CLG, StateID = @SID WHERE QuoteGUID = @QG", new object[8]
        {
          (object) "@LG",
          (object) companyLine.LineGuid,
          (object) "@CLG",
          (object) companyLine.CompanyLocationGuid,
          (object) "@SID",
          (object) companyLine.StateID,
          (object) "@QG",
          (object) this.QuoteGuid
        });
        CurrentUser.Instance.LogAction($"Updating Company Line from \"{this.CompanyLine.CompanyLineState}\" to \"{companyLine.CompanyLineState}\".", this.QuoteGuid, "BusinessObjects.Quote");
        if (this.IsTrueImsRenewal && this.CanRemoveRenewalLink())
        {
          nullable = nullable3.HasValue ? new bool?(!nullable3.GetValueOrDefault()) : nullable3;
          if (nullable.GetValueOrDefault())
          {
            DefaultDatabase.ExecuteNonQuery("dbo.spUpdateQuoteRenewalLinkandSequence", new object[4]
            {
              (object) "@quoteGuid",
              (object) this.QuoteGuid,
              (object) "@RS",
              (object) false
            });
            CurrentUser.Instance.LogAction("Not keeping renewal link and policy number sequence on change of company", this.QuoteGuid, "BusinessObjects.Quote");
          }
          else
          {
            DefaultDatabase.ExecuteNonQuery("dbo.spUpdatePolicyNumberingSequence", new object[4]
            {
              (object) "@quoteID",
              (object) this.QuoteID,
              (object) "@RS",
              (object) true
            });
            CurrentUser.Instance.LogAction("Keeping renewal link and policy number sequence on change of company", this.QuoteGuid, "BusinessObjects.Quote");
          }
        }
        this.RefreshFields("CompanyLineGuid", "LineGuid", "CompanyLocationGuid", "StateID", "PolicyNumberRuleID");
        this.ClearValues("CalculatedPolicyNumberRuleID", "CompanyLine", "CompanyLocation");
      }
      if (flag3)
      {
        CurrentUser.Instance.LogAction($"Updated policy period from {this.EffectiveDate:yyyy-MM-dd}-{this.ExpirationDate:yyyy-MM-dd} to {nullable1:yyyy-MM-dd}-{nullable2:yyyy-MM-dd}.", this.QuoteGuid, "BusinessObjects.Quote");
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE dbo.tblQuotes SET EffectiveDate = ISNULL(@EffDate, EffectiveDate), ExpirationDate = ISNULL(@ExpDate, ExpirationDate) WHERE QuoteGuid = @QG", new object[6]
        {
          (object) "@QG",
          (object) this.QuoteGuid,
          (object) "@EffDate",
          (object) nullable1,
          (object) "@ExpDate",
          (object) nullable2
        });
        this.RefreshFields("ExpirationDate", "EffectiveDate");
        this.ClearValues("CalculatedPolicyNumberRuleID");
        int? policyNumberRuleId2;
        if (flag1 && !(policyNumberRuleId1 ?? -1).Equals((policyNumberRuleId2 = this.CalculatedPolicyNumberRuleID).HasValue ? policyNumberRuleId2.GetValueOrDefault() : -1))
        {
          nullable = nullable4.HasValue ? new bool?(!nullable4.GetValueOrDefault()) : nullable4;
          if (nullable.GetValueOrDefault())
          {
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblQuotes SET PolicyNumberRuleID = NULL, PolicyNumberIndex = NULL, PolicyNumber = NULL WHERE QuoteGuid = @QG", new object[2]
            {
              (object) "@QuoteGuid",
              (object) this.QuoteGuid
            });
            this.RefreshFields("PolicyNumberRuleID");
            string str1 = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT RuleName FROM dbo.tblPolicyNumberRules WITH (NOLOCK) WHERE RuleID = @ID", new object[2]
            {
              (object) "@ID",
              (object) policyNumberRuleId1
            });
            string str2 = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT RuleName FROM dbo.tblPolicyNumberRules WITH (NOLOCK) WHERE RuleID = @ID", new object[2]
            {
              (object) "@ID",
              (object) this.CalculatedPolicyNumberRuleID
            });
            CurrentUser.Instance.LogAction($"Not maintaining policy number information. Clearing the old policy number with rule ({str1 ?? "{BLANK}"}); new rule {str2} available.", this.QuoteGuid, "BusinessObjects.Quote");
          }
        }
      }
      return true;
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      throw;
    }
  }

  private void CopyRaterInfo(SqlTransaction trans, Guid newQuoteGuid)
  {
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__533\u002D0 closure5330_1;
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__533\u002D0 closure5330_2 = new Quote._Closure\u0024__533\u002D0(closure5330_1);
    // ISSUE: reference to a compiler-generated field
    closure5330_2.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure5330_2.\u0024VB\u0024Local_trans = trans;
    // ISSUE: reference to a compiler-generated field
    closure5330_2.\u0024VB\u0024Local_newQuoteGuid = newQuoteGuid;
    // ISSUE: reference to a compiler-generated field
    if (closure5330_2.\u0024VB\u0024Local_trans != null && !DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure5330_2.\u0024VB\u0024Local_trans, new ExecuteHandler((object) closure5330_2, __methodptr(_Lambda\u0024__0)));
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      Quote quote = Quote.CreateNew(closure5330_2.\u0024VB\u0024Local_newQuoteGuid);
      List<int> intList = new List<int>();
      try
      {
        foreach (QuoteDetail quoteDetail in quote.QuoteDetails)
        {
          if (quoteDetail.IsRaterAssigned() && !intList.Contains(quoteDetail.RaterID.Value))
          {
            IRater rater = RaterFactory.GetRater(quoteDetail.RaterID.Value);
            if (rater == null)
              throw new RaterNotFoundException();
            rater.InitializeState(this.QuoteGuid, quoteDetail.CompanyLineGuid);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            rater.CopyQuoteData(this.QuoteGuid, closure5330_2.\u0024VB\u0024Local_newQuoteGuid, closure5330_2.\u0024VB\u0024Local_trans);
            // ISSUE: reference to a compiler-generated field
            // ISSUE: reference to a compiler-generated field
            rater.CopyBoundOptions(this.QuoteGuid, closure5330_2.\u0024VB\u0024Local_newQuoteGuid, closure5330_2.\u0024VB\u0024Local_trans);
            intList.Add(quoteDetail.RaterID.Value);
          }
        }
      }
      finally
      {
        List<QuoteDetail>.Enumerator enumerator;
        enumerator.Dispose();
      }
    }
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  private void DownwardInternalCorrectionPremiumFill(SqlTransaction trans, Guid newQuoteGuid)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__534\u002D0 closure5340 = new Quote._Closure\u0024__534\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure5340.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure5340.\u0024VB\u0024Local_trans = trans;
    // ISSUE: reference to a compiler-generated field
    closure5340.\u0024VB\u0024Local_newQuoteGuid = newQuoteGuid;
    // ISSUE: reference to a compiler-generated field
    if (closure5340.\u0024VB\u0024Local_trans != null && !DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure5340.\u0024VB\u0024Local_trans, new ExecuteHandler((object) closure5340, __methodptr(_Lambda\u0024__0)));
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      DefaultDatabase.ExecuteNonQuery("dbo.spDownwardInternalCorrectionPremiumFill", new object[2]
      {
        (object) "@QuoteGuid",
        (object) closure5340.\u0024VB\u0024Local_newQuoteGuid
      });
    }
  }

  [SuppressMessage("Style", "IDE0058:Expression value is never used", Justification = "Disregard rowcount returned by query.")]
  private void UpwardInternalCorrectionPremiumFill(SqlTransaction trans, Guid newQuoteGuid)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__535\u002D0 closure5350 = new Quote._Closure\u0024__535\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure5350.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure5350.\u0024VB\u0024Local_trans = trans;
    // ISSUE: reference to a compiler-generated field
    closure5350.\u0024VB\u0024Local_newQuoteGuid = newQuoteGuid;
    // ISSUE: reference to a compiler-generated field
    if (closure5350.\u0024VB\u0024Local_trans != null && !DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure5350.\u0024VB\u0024Local_trans, new ExecuteHandler((object) closure5350, __methodptr(_Lambda\u0024__0)));
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      DefaultDatabase.ExecuteNonQuery("dbo.spUpwardInternalCorrectionPremiumFill", new object[2]
      {
        (object) "@QuoteGuid",
        (object) closure5350.\u0024VB\u0024Local_newQuoteGuid
      });
    }
  }

  private bool GetAddressFields()
  {
    return this.RetrieveFields("InsuredAddress1", "InsuredAddress2", "InsuredZipCode", "InsuredZipPlus", "InsuredCity", "InsuredState", "InsuredCounty", "InsuredISOCountryCode", "InsuredAddress1_Billing", "InsuredAddress2_Billing", "InsuredCity_Billing", "InsuredState_Billing", "InsuredZipCode_Billing", "InsuredDBA", "InsuredZipPlus_Billing", "InsuredISOCountryCode_Billing", "InsuredPhone", "InsuredFax", "InsuredMobileNumber");
  }

  bool IRecreatableEntity.CanReCreateEntity => true;

  Guid IRecreatableEntity.EntityGuid => this.QuoteGuid;

  string IRecreatableEntity.EntityName
  {
    get
    {
      return !this.HasPolicyNumber ? $"{this.InsuredPolicyName} / Control #: {this.ControlNo.ToString()}" : $"Policy: {this.PolicyNumber} / {this.InsuredPolicyName} / Control #: {this.ControlNo.ToString()}";
    }
  }

  string IRecreatableEntity.FriendlyEntityName
  {
    get => !this.IsQuickQuote ? "Policy Detail" : "Quote Edit";
  }

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    throw new InvalidOperationException("The Quote object does not directly support RecreateEntityInitialize");
  }

  string IRecreatableEntity.RecreateTypeName
  {
    get
    {
      return !this.IsQuickQuote ? "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail " : "MGASystems.IMS.Policies.frmQuoteEdit";
    }
  }

  public bool CanCreateNewNote => true;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  public bool AllowAddNewDocument => true;

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged1;

  protected Guid CreateEndorsement(
    SqlTransaction t,
    TransactionTypes transactionType,
    QuoteStatus status,
    DateTime endorsementEffective,
    string endorsementComment,
    EndorsementCalcTypes endorsementCalcType)
  {
    return this.CreateEndorsement(t, transactionType, status, endorsementEffective, endorsementComment, endorsementCalcType, new int?(), new DateTime?());
  }

  protected Guid CreateEndorsement(
    SqlTransaction t,
    TransactionTypes transactionType,
    QuoteStatus status,
    DateTime endorsementEffective,
    string endorsementComment,
    EndorsementCalcTypes endorsementCalcType,
    int? quoteStatusReasonID,
    DateTime? endtRequestDate)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    Quote._Closure\u0024__561\u002D0 closure5610 = new Quote._Closure\u0024__561\u002D0();
    // ISSUE: reference to a compiler-generated field
    closure5610.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure5610.\u0024VB\u0024Local_t = t;
    // ISSUE: reference to a compiler-generated field
    closure5610.\u0024VB\u0024Local_transactionType = transactionType;
    // ISSUE: reference to a compiler-generated field
    closure5610.\u0024VB\u0024Local_status = status;
    // ISSUE: reference to a compiler-generated field
    closure5610.\u0024VB\u0024Local_endorsementEffective = endorsementEffective;
    // ISSUE: reference to a compiler-generated field
    closure5610.\u0024VB\u0024Local_endorsementComment = endorsementComment;
    // ISSUE: reference to a compiler-generated field
    closure5610.\u0024VB\u0024Local_endorsementCalcType = endorsementCalcType;
    // ISSUE: reference to a compiler-generated field
    closure5610.\u0024VB\u0024Local_quoteStatusReasonID = quoteStatusReasonID;
    // ISSUE: reference to a compiler-generated field
    closure5610.\u0024VB\u0024Local_endtRequestDate = endtRequestDate;
    // ISSUE: reference to a compiler-generated field
    if (closure5610.\u0024VB\u0024Local_t != null && !DefaultDatabase.HasTransaction)
    {
      // ISSUE: reference to a compiler-generated field
      // ISSUE: method pointer
      DefaultDatabase.EnlistTransaction((DbTransaction) closure5610.\u0024VB\u0024Local_t, new ExecuteHandler((object) closure5610, __methodptr(_Lambda\u0024__0)));
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      closure5610.\u0024VB\u0024Local_CreateEndorsement = closure5610.\u0024VB\u0024Local_CreateEndorsement;
    }
    else
    {
      if (this.QuoteGuid.Equals(Guid.Empty))
        throw new InvalidOperationException("QuoteGuid Not Initialized");
      // ISSUE: reference to a compiler-generated field
      if (string.IsNullOrEmpty(closure5610.\u0024VB\u0024Local_endorsementComment))
      {
        // ISSUE: reference to a compiler-generated field
        closure5610.\u0024VB\u0024Local_endorsementComment = (string) null;
      }
      // ISSUE: reference to a compiler-generated field
      if ((closure5610.\u0024VB\u0024Local_quoteStatusReasonID ?? -1) <= 0)
      {
        // ISSUE: reference to a compiler-generated field
        closure5610.\u0024VB\u0024Local_quoteStatusReasonID = new int?();
      }
      // ISSUE: reference to a compiler-generated field
      if (DateTime.Compare(closure5610.\u0024VB\u0024Local_endtRequestDate ?? DateTime.MinValue, DateTime.MinValue) == 0)
      {
        // ISSUE: reference to a compiler-generated field
        closure5610.\u0024VB\u0024Local_endtRequestDate = new DateTime?();
      }
      Guid empty1 = Guid.Empty;
      string str1 = string.Empty;
      // ISSUE: reference to a compiler-generated field
      switch (closure5610.\u0024VB\u0024Local_transactionType)
      {
        case TransactionTypes.Endorsement:
          str1 = "E";
          break;
        case TransactionTypes.Reinstatement:
          str1 = "R";
          break;
        case TransactionTypes.Correction:
          str1 = "N";
          break;
        case TransactionTypes.Audit:
          str1 = "A";
          break;
        case TransactionTypes.Cancellation:
          str1 = "C";
          break;
        case TransactionTypes.DownwardInternalCorrection:
          str1 = "D";
          break;
        case TransactionTypes.UpwardInternalCorrection:
          str1 = "U";
          break;
        case TransactionTypes.Installment:
          str1 = "I";
          break;
      }
      string empty2 = string.Empty;
      string str2;
      // ISSUE: reference to a compiler-generated field
      switch (closure5610.\u0024VB\u0024Local_endorsementCalcType)
      {
        case EndorsementCalcTypes.ProRata:
          str2 = "P";
          break;
        case EndorsementCalcTypes.ShortRate:
          str2 = "S";
          break;
        case EndorsementCalcTypes.Flat:
          str2 = "F";
          break;
        case EndorsementCalcTypes.MinimumEarned:
          str2 = "M";
          break;
        default:
          throw new InvalidOperationException("Unexpected EndorsementCalculationType");
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      Guid newQuoteGuid = DefaultDatabase.ExecuteScalar<Guid>(CommandType.StoredProcedure, "dbo.[spCopyQuote]", 120, (CommandArgumentType) 0, new object[16 /*0x10*/]
      {
        (object) "@QuoteGuid",
        (object) this.QuoteGuid,
        (object) "@TransactionTypeID",
        (object) str1,
        (object) "@QuoteStatusID",
        (object) (int) closure5610.\u0024VB\u0024Local_status,
        (object) "@EndorsementEffective",
        (object) closure5610.\u0024VB\u0024Local_endorsementEffective,
        (object) "@EndorsementComment",
        (object) closure5610.\u0024VB\u0024Local_endorsementComment,
        (object) "@QuoteStatusReasonID",
        (object) closure5610.\u0024VB\u0024Local_quoteStatusReasonID,
        (object) "@EndorsementCalculationType",
        (object) str2,
        (object) "@EndtRequestDate",
        (object) closure5610.\u0024VB\u0024Local_endtRequestDate
      });
      // ISSUE: reference to a compiler-generated field
      this.CopyRaterInfo(closure5610.\u0024VB\u0024Local_t, newQuoteGuid);
      // ISSUE: reference to a compiler-generated field
      if (closure5610.\u0024VB\u0024Local_transactionType == TransactionTypes.DownwardInternalCorrection)
      {
        // ISSUE: reference to a compiler-generated field
        this.DownwardInternalCorrectionPremiumFill(closure5610.\u0024VB\u0024Local_t, newQuoteGuid);
      }
      // ISSUE: reference to a compiler-generated field
      if (closure5610.\u0024VB\u0024Local_transactionType == TransactionTypes.UpwardInternalCorrection)
      {
        // ISSUE: reference to a compiler-generated field
        this.UpwardInternalCorrectionPremiumFill(closure5610.\u0024VB\u0024Local_t, newQuoteGuid);
      }
      // ISSUE: reference to a compiler-generated field
      this.CopyQuoteExtended(closure5610.\u0024VB\u0024Local_t, newQuoteGuid);
      this.ClearValues("NextQuoteGuid");
      this._nextQuote = (Quote) null;
      // ISSUE: reference to a compiler-generated field
      closure5610.\u0024VB\u0024Local_CreateEndorsement = newQuoteGuid;
    }
    // ISSUE: reference to a compiler-generated field
    return closure5610.\u0024VB\u0024Local_CreateEndorsement;
  }

  public List<CreateEndorsementOptions> GetCreateEndorsementOptions()
  {
    List<QuoteDetail> quoteDetails = this.QuoteDetails;
    System.Func<QuoteDetail, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (Quote._Closure\u0024__.\u0024I562\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = Quote._Closure\u0024__.\u0024I562\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      Quote._Closure\u0024__.\u0024I562\u002D0 = predicate = (System.Func<QuoteDetail, bool>) ([SpecialName] (qd) => qd.IsRaterAssigned());
    }
    IEnumerable<QuoteDetail> source1 = quoteDetails.Where<QuoteDetail>(predicate);
    System.Func<QuoteDetail, int> selector1;
    // ISSUE: reference to a compiler-generated field
    if (Quote._Closure\u0024__.\u0024I562\u002D1 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector1 = Quote._Closure\u0024__.\u0024I562\u002D1;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      Quote._Closure\u0024__.\u0024I562\u002D1 = selector1 = (System.Func<QuoteDetail, int>) ([SpecialName] (qd) => qd.RaterID.Value);
    }
    IEnumerable<int> source2 = source1.Select<QuoteDetail, int>(selector1).Distinct<int>();
    System.Func<int, CreateEndorsementOptions> selector2;
    // ISSUE: reference to a compiler-generated field
    if (Quote._Closure\u0024__.\u0024I562\u002D2 != null)
    {
      // ISSUE: reference to a compiler-generated field
      selector2 = Quote._Closure\u0024__.\u0024I562\u002D2;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      Quote._Closure\u0024__.\u0024I562\u002D2 = selector2 = (System.Func<int, CreateEndorsementOptions>) ([SpecialName] (rid) => (RaterFactory.GetRater(rid) is IRaterEndorsementOptions rater ? rater.GetCreateEndorsementOptions() : (CreateEndorsementOptions) null) ?? new CreateEndorsementOptions());
    }
    return source2.Select<int, CreateEndorsementOptions>(selector2).DefaultIfEmpty<CreateEndorsementOptions>(new CreateEndorsementOptions()).ToList<CreateEndorsementOptions>();
  }

  public override Guid? ParentEntityGuid => new Guid?(this.ControlGuid);

  public override OfacSystem.OfacCriteria GetSearchCriteria(IOfacSetting setting)
  {
    OfacSystem.OfacCriteria searchCriteria = this.AsOfacCriteria(nameof (Quote), "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail");
    searchCriteria.LastName = this.InsuredPolicyName;
    if (!(setting is IntelligentSearch))
    {
      searchCriteria.Address = this.InsuredAddress1;
      searchCriteria.Address2 = this.InsuredAddress2;
      searchCriteria.City = this.InsuredCity;
      searchCriteria.State = this.InsuredState;
      searchCriteria.ZipCode = this.InsuredZipCode;
      if (!string.IsNullOrEmpty(this.InsuredISOCountryCode))
      {
        searchCriteria.IsoCountryCode = this.InsuredISOCountryCode;
        if (setting is PublicWebServices && !string.IsNullOrEmpty(this.InsuredCountryName))
          searchCriteria.IsoCountryCode = this.InsuredCountryName;
      }
      if (setting is MGASystems.BusinessObjects.LexisNexis)
      {
        ConcurrentDictionary<byte, bool> individualBusinessTypes = Insured.IndividualBusinessTypes;
        int key = (int) (this.InsuredBusinessTypeID ?? (byte) 0);
        System.Func<byte, bool> valueFactory;
        // ISSUE: reference to a compiler-generated field
        if (Quote._Closure\u0024__.\u0024I565\u002D0 != null)
        {
          // ISSUE: reference to a compiler-generated field
          valueFactory = Quote._Closure\u0024__.\u0024I565\u002D0;
        }
        else
        {
          // ISSUE: reference to a compiler-generated field
          Quote._Closure\u0024__.\u0024I565\u002D0 = valueFactory = (System.Func<byte, bool>) ([SpecialName] (btid) => DefaultDatabase.ExecuteScalar<bool?>(CommandType.Text, "SELECT Individual FROM dbo.lstBusinessTypes WHERE BusinessTypeID = @ID", new object[2]
          {
            (object) "@ID",
            (object) btid
          }) ?? false);
        }
        bool orAdd = individualBusinessTypes.GetOrAdd((byte) key, valueFactory);
        searchCriteria.Data["SearchEntityType"] = (orAdd ? InputEntityEntityType.Individual : InputEntityEntityType.Business).ToString();
      }
    }
    return searchCriteria;
  }

  public OfacSystem.OfacStatus ComplianceStatus
  {
    get
    {
      return this.CacheManualValue<OfacSystem.OfacStatus>(nameof (ComplianceStatus), new Func<OfacSystem.OfacStatus>(((OfacEntity) this).GetOfacStatus));
    }
  }

  public static bool SupportsPolicySearch
  {
    get => MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.Policy.RunCompliance");
  }

  public static bool SupportsAddressSearch
  {
    get
    {
      return Quote.SupportsPolicySearch && MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("OFAC.Policy.RunAddressChange");
    }
  }

  public virtual bool SearchQuoteOfac
  {
    get
    {
      return Quote.SupportsPolicySearch && this.PolicyNameDiffers || Quote.SupportsAddressSearch && this.PolicyAddressDiffers || this.ComplianceStatus != null;
    }
  }

  public struct AffidavitNumber
  {
    public string StateID;
    public string AffidavitNumber;
  }

  public delegate void QuoteDeletedEventHandler(object sender, QuoteEventArgs e);

  public delegate void PolicyUnboundEventHandler(object sender, QuoteEventArgs e);

  public class ConvertQuickToFullContact
  {
    public Guid CompanyLineGuid { get; set; }

    public Guid ContactGuid { get; set; }

    public bool IsIntermediaryContact { get; set; }

    public ConvertQuickToFullContact(
      Guid companyLineGuid,
      Guid contactGuid,
      bool isIntermediaryContact)
    {
      this.CompanyLineGuid = companyLineGuid;
      this.ContactGuid = contactGuid;
      this.IsIntermediaryContact = isIntermediaryContact;
    }
  }
}
