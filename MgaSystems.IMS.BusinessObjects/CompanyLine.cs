// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.CompanyLine
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.Enums;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblCompanyLines")]
public class CompanyLine : BaseDataObject
{
  private Guid _companyLineGuid;
  private CompanyLocation _companyLocation;
  private Line _line;
  private List<CompanyLine> _childLines;
  private static readonly ConcurrentDictionary<int, Guid> _companyLineIDToGuidCache = new ConcurrentDictionary<int, Guid>();
  private static readonly ConcurrentDictionary<(Guid?, Guid, Guid, string), Guid?> _validCompanyLines = new ConcurrentDictionary<(Guid?, Guid, Guid, string), Guid?>();
  private static readonly Lazy<bool> _returnCompanyCommissionOnMaxProdComm = MGASystems.Common.Settings.SystemSettings.GetLazySetting<bool>("ReturnCompanyCommissionOnMaxProdComm", false, true);

  public CompanyLine(Guid companyLineGuid) => this.CompanyLineGuid = companyLineGuid;

  public CompanyLine(int companyLineID)
  {
    ConcurrentDictionary<int, Guid> lineIdToGuidCache = CompanyLine._companyLineIDToGuidCache;
    int key1 = companyLineID;
    System.Func<int, Guid> valueFactory;
    // ISSUE: reference to a compiler-generated field
    if (CompanyLine._Closure\u0024__.\u0024I8\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      valueFactory = CompanyLine._Closure\u0024__.\u0024I8\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      CompanyLine._Closure\u0024__.\u0024I8\u002D0 = valueFactory = (System.Func<int, Guid>) ([SpecialName] (key) => DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT CompanyLineGuid FROM dbo.tblCompanyLines WITH(NOLOCK) WHERE CompanyLineID=@CLID", new object[2]
      {
        (object) "@CLID",
        (object) key
      }) ?? Guid.Empty);
    }
    this.CompanyLineGuid = lineIdToGuidCache.GetOrAdd(key1, valueFactory);
    if (this.CompanyLineGuid.Equals(Guid.Empty))
      throw new CompanyLine.CompanyLineGuidNotFoundException();
  }

  [Obsolete("This constructor fails to take the parent line into consideration. Could return a child line where a parent line was expected (or vice versa).")]
  public CompanyLine(Guid companyLocationGuid, Guid lineGuid, string stateID)
  {
    this.CompanyLineGuid = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT CompanyLineGuid FROM dbo.tblCompanyLines WITH(NOLOCK) WHERE CompanyLocationGuid=@CLG AND LineGuid=@LG AND StateID=@SID", new object[6]
    {
      (object) "@CLG",
      (object) companyLocationGuid,
      (object) "@LG",
      (object) lineGuid,
      (object) "@SID",
      (object) stateID
    }) ?? Guid.Empty;
    if (this.CompanyLineGuid.Equals(Guid.Empty))
      throw new CompanyLine.CompanyLineGuidNotFoundException();
  }

  public CompanyLine(
    Guid companyLocationGuid,
    Guid lineGuid,
    string stateID,
    Guid? parentLineGuid)
  {
    this.CompanyLineGuid = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT CompanyLineGuid FROM dbo.tblCompanyLines WITH(NOLOCK) WHERE CompanyLocationGuid=@CLG AND LineGuid=@LG AND StateID=@SID AND ISNULL(ParentCompanyLineGUID, 0x0) = @PLG", new object[8]
    {
      (object) "@CLG",
      (object) companyLocationGuid,
      (object) "@LG",
      (object) lineGuid,
      (object) "@SID",
      (object) stateID,
      (object) "@PLG",
      (object) (parentLineGuid.HasValue ? parentLineGuid.GetValueOrDefault() : Guid.Empty)
    }) ?? Guid.Empty;
    if (this.CompanyLineGuid.Equals(Guid.Empty))
      throw new CompanyLine.CompanyLineGuidNotFoundException();
  }

  public CompanyLocation CompanyLocation
  {
    get
    {
      if (this._companyLocation == null)
        this._companyLocation = new CompanyLocation(this.CompanyLocationGuid);
      return this._companyLocation;
    }
  }

  public Line Line
  {
    get
    {
      if (this._line == null)
        this._line = new Line(this.LineGuid);
      return this._line;
    }
  }

  public List<CompanyLine> ChildLines
  {
    get
    {
      if (this._childLines == null)
        this._childLines = BaseDataObject.SelectMany<CompanyLine>($"{"ParentCompanyLineGuid"} = @PL", (object) "@PL", (object) this.CompanyLineGuid);
      return this._childLines;
    }
  }

  [DataKey]
  public Guid CompanyLineGuid
  {
    get => this._companyLineGuid;
    protected set
    {
      this._companyLineGuid = this._companyLineGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified CompanyLine {this._companyLineGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public bool EnforceUniquePolicyNumbers
  {
    get
    {
      return this.GetField<bool?>(nameof (EnforceUniquePolicyNumbers), nameof (EnforceUniquePolicyNumbers)) ?? true;
    }
  }

  [TableFieldMapping("DefaultInvoiceComment")]
  public string DefaultInvoiceComments
  {
    get => this.GetField<string>("DefaultInvoiceComment", nameof (DefaultInvoiceComments));
  }

  [TableFieldMapping]
  public string QuoteAdditionalComments
  {
    get
    {
      return this.GetField<string>(nameof (QuoteAdditionalComments), nameof (QuoteAdditionalComments));
    }
  }

  [TableFieldMapping]
  public int CompanyLicenseTypeID
  {
    get => (int) this.GetField<byte>(nameof (CompanyLicenseTypeID), nameof (CompanyLicenseTypeID));
  }

  public bool IsAdmitted => this.CompanyLicenseTypeID == 1;

  public Guid CompanyGuid
  {
    get
    {
      return this.CacheManualValue<Guid>(nameof (CompanyGuid), (Func<Guid>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<Guid>(CommandType.Text, "SELECT CompanyGuid FROM tblCompanyLocations WHERE CompanyLocationGuid=@CLG", new object[2]
      {
        (object) "@CLG",
        (object) this.CompanyLocationGuid
      })));
    }
  }

  public int DefaultProducerTermsOfPayment
  {
    get
    {
      return (int) (this.CacheManualValue<short?>(nameof (DefaultProducerTermsOfPayment), (Func<short?>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<short?>(CommandType.Text, "SELECT DefaultProducerTermsOfPayment FROM tblCompanyLineTermsOfPayment WHERE CompanyLineID=@CompanyLineID", new object[2]
      {
        (object) "@CompanyLineID",
        (object) this.CompanyLineID
      }))) ?? (short) 0);
    }
  }

  [TableFieldMapping]
  public Guid CompanyLocationGuid
  {
    get => this.GetField<Guid>(nameof (CompanyLocationGuid), nameof (CompanyLocationGuid));
  }

  [TableFieldMapping]
  public string StateID => this.GetField<string>(nameof (StateID), nameof (StateID));

  [TableFieldMapping]
  public Guid LineGuid => this.GetField<Guid>(nameof (LineGuid), nameof (LineGuid));

  [TableFieldMapping("CompanyLine")]
  public string CompanyLineState
  {
    get => this.GetField<string>(nameof (CompanyLine), nameof (CompanyLineState));
  }

  [TableFieldMapping]
  public int CompanyLineID => this.GetField<int>(nameof (CompanyLineID), nameof (CompanyLineID));

  [TableFieldMapping]
  public int InvoiceMailingDays
  {
    get => (int) this.GetField<byte>(nameof (InvoiceMailingDays), nameof (InvoiceMailingDays));
  }

  [TableFieldMapping]
  public int StatusID => (int) this.GetField<byte>(nameof (StatusID), nameof (StatusID));

  public bool IsActive => this.StatusID == 1;

  [TableFieldMapping]
  public bool BlockXSPremium
  {
    get => this.GetField<bool>(nameof (BlockXSPremium), nameof (BlockXSPremium));
  }

  [TableFieldMapping("AllowLapseOnRenewal")]
  public bool AllowLapseInCoverageOnRenewal
  {
    get => this.GetField<bool>("AllowLapseOnRenewal", nameof (AllowLapseInCoverageOnRenewal));
  }

  [TableFieldMapping]
  public bool AllowEndorsementsWithoutIssuance
  {
    get
    {
      return this.GetField<bool>(nameof (AllowEndorsementsWithoutIssuance), nameof (AllowEndorsementsWithoutIssuance));
    }
  }

  public bool IsParentLine => !this.IsChildLine;

  public bool IsChildLine => this.ParentCompanyLineGuid.HasValue;

  public bool IsPackage => !this.IsChildLine && this.ChildLines.Count > 0;

  [TableFieldMapping]
  public bool WaivePremium => this.GetField<bool>(nameof (WaivePremium), nameof (WaivePremium));

  [TableFieldMapping]
  public Guid? ParentCompanyLineGuid
  {
    get => this.GetField<Guid?>(nameof (ParentCompanyLineGuid), nameof (ParentCompanyLineGuid));
  }

  public string LineName => this.Line.LineName;

  public string LineCode => this.Line.LineCode ?? string.Empty;

  public int LineID => this.Line.LineID;

  public bool IsNonAdmitted => this.CompanyLicenseTypeID == 2;

  public bool HasRequirements
  {
    get
    {
      return this.CacheManualValue<bool>(nameof (HasRequirements), (Func<bool>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM dbo.tblCompanyLineBindingRequirements WITH(NOLOCK) WHERE CompanyLineID = @CLID", new object[2]
      {
        (object) "@CLID",
        (object) this.CompanyLineID
      }) > 0));
    }
  }

  [TableFieldMapping]
  public bool KeepPolicyNumberOnRewrites
  {
    get
    {
      return this.GetField<bool?>(nameof (KeepPolicyNumberOnRewrites), nameof (KeepPolicyNumberOnRewrites)) ?? false;
    }
  }

  [TableFieldMapping]
  public string Filing => this.GetField<string>(nameof (Filing), nameof (Filing));

  public int GetDaysDue(Quote q)
  {
    if (q == null)
      throw new ArgumentNullException(nameof (q));
    CompanyLine.PaymentTerms objectAs = ObjectFactory.Instance.CreateObjectAs<CompanyLine.PaymentTerms>((object) this.CompanyLineID, (object) q.EffectiveDate);
    return !q.IsEndorsement ? (int) objectAs.DefaultProducerTermsOfPayment : (int) objectAs.DefaultProducerTermsOfPayment_Endorsement;
  }

  public string GetProducerPaymentMeasuredFrom(Quote q)
  {
    if (q == null)
      throw new ArgumentNullException(nameof (q));
    CompanyLine.PaymentTerms objectAs = ObjectFactory.Instance.CreateObjectAs<CompanyLine.PaymentTerms>((object) this.CompanyLineID, (object) q.EffectiveDate);
    return !q.IsEndorsement ? objectAs.ProducerPaymentMeasuredFrom : objectAs.ProducerPaymentMeasuredFrom_Endorsement;
  }

  public bool IsRequiredForBind(CompanyLine.BindingRequirements requirement)
  {
    return this.IsRequiredForBind((int) requirement);
  }

  public bool IsRequiredForBind(int requirementID)
  {
    return Convert.ToBoolean(DefaultDatabase.ExecuteScalar<int>("dbo.IsBindingRequirement", new object[4]
    {
      (object) "@companyLineGuid",
      (object) this._companyLineGuid,
      (object) "@requirementID",
      (object) requirementID
    }));
  }

  public bool IsRaterAvailable(RatingTypes rater)
  {
    return DefaultDatabase.ExecuteDataTable("CompanyLineAvailableRaters", new object[2]
    {
      (object) "@CompanyLineGuid",
      (object) this._companyLineGuid
    }).Select($"RatingTypeID = {(int) rater}").Length > 0;
  }

  public Decimal GetCommission(
    bool renewal,
    Guid producerLocationGuid,
    DateTime effectiveDate,
    int policyTypeID,
    Guid expiringCompanyLocationGuid)
  {
    Decimal commission = ObjectFactory.Instance.CreateObjectAs<ProducerLocation>((object) producerLocationGuid).GetCommission(this.CompanyLineGuid, renewal, effectiveDate);
    return this.GetCommission(renewal, producerLocationGuid, commission, effectiveDate, policyTypeID, expiringCompanyLocationGuid);
  }

  public Decimal GetCommission(
    bool renewal,
    Guid producerLocationGuid,
    Decimal producerCommission,
    DateTime effectiveDate,
    int policyTypeID,
    Guid expiringCompanyLocationGuid)
  {
    return this.GetCommission(renewal, producerLocationGuid, producerCommission, effectiveDate, policyTypeID, (SqlTransaction) null, expiringCompanyLocationGuid);
  }

  [Obsolete("Please use the GetCommission overload that accepts an expiring company location")]
  public Decimal GetCommission(
    bool renewal,
    Guid producerLocationGuid,
    Decimal producerCommission,
    DateTime effectiveDate,
    int policyTypeID,
    SqlTransaction trans)
  {
    return this.GetCommission(renewal, producerLocationGuid, producerCommission, effectiveDate, policyTypeID, trans, Guid.Empty);
  }

  [Obsolete("Please use the GetCommission overload that accepts an expiring company location")]
  public Decimal GetCommission(
    bool renewal,
    Guid producerLocationGuid,
    Decimal producerCommission,
    DateTime effectiveDate,
    int policyTypeID)
  {
    SqlTransaction trans = (SqlTransaction) null;
    return this.GetCommission(renewal, producerLocationGuid, producerCommission, effectiveDate, policyTypeID, trans);
  }

  [Obsolete("Please use the GetCommission overload that accepts an expiring company location")]
  public Decimal GetCommission(
    bool renewal,
    Guid producerLocationGuid,
    DateTime effectiveDate,
    int policyTypeID)
  {
    Decimal commission = ObjectFactory.Instance.CreateObjectAs<ProducerLocation>((object) producerLocationGuid).GetCommission(this.CompanyLineGuid, renewal, effectiveDate);
    return this.GetCommission(renewal, producerLocationGuid, commission, effectiveDate, policyTypeID);
  }

  public Decimal GetCommission(
    bool renewal,
    Guid producerLocationGuid,
    Decimal producerCommission,
    DateTime effectiveDate,
    int policyTypeID,
    SqlTransaction trans,
    Guid expiringCompanyLocationGuid)
  {
    return this.GetCommission(renewal, producerLocationGuid, producerCommission, effectiveDate, policyTypeID, trans, expiringCompanyLocationGuid, (object) null);
  }

  public Decimal GetCommission(
    bool renewal,
    Guid producerLocationGuid,
    Decimal producerCommission,
    DateTime effectiveDate,
    int policyTypeID,
    SqlTransaction trans,
    Guid expiringCompanyLocationGuid,
    object programID)
  {
    return this.GetCommission(renewal, producerLocationGuid, producerCommission, effectiveDate, policyTypeID, trans, expiringCompanyLocationGuid, RuntimeHelpers.GetObjectValue(programID), Guid.Empty);
  }

  public Decimal GetCommission(
    bool renewal,
    Guid producerLocationGuid,
    Decimal producerCommission,
    DateTime effectiveDate,
    int policyTypeID,
    SqlTransaction trans,
    Guid expiringCompanyLocationGuid,
    object programID,
    Guid quotingOfficeGuid)
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    CompanyLine._Closure\u0024__92\u002D1 closure921 = new CompanyLine._Closure\u0024__92\u002D1();
    // ISSUE: reference to a compiler-generated field
    closure921.\u0024VB\u0024Me = this;
    // ISSUE: reference to a compiler-generated field
    closure921.\u0024VB\u0024Local_renewal = renewal;
    // ISSUE: reference to a compiler-generated field
    closure921.\u0024VB\u0024Local_producerLocationGuid = producerLocationGuid;
    // ISSUE: reference to a compiler-generated field
    closure921.\u0024VB\u0024Local_producerCommission = producerCommission;
    // ISSUE: reference to a compiler-generated field
    closure921.\u0024VB\u0024Local_effectiveDate = effectiveDate;
    // ISSUE: reference to a compiler-generated field
    closure921.\u0024VB\u0024Local_policyTypeID = policyTypeID;
    // ISSUE: reference to a compiler-generated field
    closure921.\u0024VB\u0024Local_trans = trans;
    // ISSUE: reference to a compiler-generated field
    closure921.\u0024VB\u0024Local_expiringCompanyLocationGuid = expiringCompanyLocationGuid;
    // ISSUE: reference to a compiler-generated field
    closure921.\u0024VB\u0024Local_programID = programID;
    // ISSUE: reference to a compiler-generated field
    closure921.\u0024VB\u0024Local_quotingOfficeGuid = quotingOfficeGuid;
    Decimal commission;
    // ISSUE: reference to a compiler-generated field
    if (Decimal.Compare(closure921.\u0024VB\u0024Local_producerCommission, 1M) >= 0 && !CompanyLine.ReturnCompanyCommissionOnMaxProdComm())
    {
      commission = 0M;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      if (closure921.\u0024VB\u0024Local_trans != null && !DefaultDatabase.HasTransaction)
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        CompanyLine._Closure\u0024__92\u002D0 closure920 = new CompanyLine._Closure\u0024__92\u002D0();
        // ISSUE: reference to a compiler-generated field
        closure920.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2 = closure921;
        // ISSUE: reference to a compiler-generated field
        closure920.\u0024VB\u0024Local_commissionVal = 0M;
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated field
        // ISSUE: method pointer
        DefaultDatabase.EnlistTransaction((DbTransaction) closure920.\u0024VB\u0024NonLocal_\u0024VB\u0024Closure_2.\u0024VB\u0024Local_trans, new ExecuteHandler((object) closure920, __methodptr(_Lambda\u0024__0)));
        // ISSUE: reference to a compiler-generated field
        commission = closure920.\u0024VB\u0024Local_commissionVal;
      }
      else
      {
        Dictionary<string, DbParameter> dictionary = DefaultDatabase.DiscoverParameters("dbo.spGetCompanyCommission");
        // ISSUE: reference to a compiler-generated field
        dictionary["@ProducerLocationGuid"].Value = (object) closure921.\u0024VB\u0024Local_producerLocationGuid;
        dictionary["@CompanyLineGuid"].Value = (object) this.CompanyLineGuid;
        // ISSUE: reference to a compiler-generated field
        dictionary["@Renewal"].Value = (object) closure921.\u0024VB\u0024Local_renewal;
        // ISSUE: reference to a compiler-generated field
        dictionary["@QuoteEffectiveDate"].Value = (object) closure921.\u0024VB\u0024Local_effectiveDate;
        // ISSUE: reference to a compiler-generated field
        dictionary["@ProducerCommIn"].Value = (object) closure921.\u0024VB\u0024Local_producerCommission;
        // ISSUE: reference to a compiler-generated field
        dictionary["@PolicyTypeID"].Value = (object) closure921.\u0024VB\u0024Local_policyTypeID;
        // ISSUE: reference to a compiler-generated field
        dictionary["@ProgramID"].Value = RuntimeHelpers.GetObjectValue(closure921.\u0024VB\u0024Local_programID);
        // ISSUE: reference to a compiler-generated field
        if (!closure921.\u0024VB\u0024Local_quotingOfficeGuid.Equals(Guid.Empty))
        {
          // ISSUE: reference to a compiler-generated field
          dictionary["@QuotingOfficeGuid"].Value = (object) closure921.\u0024VB\u0024Local_quotingOfficeGuid;
        }
        // ISSUE: reference to a compiler-generated field
        if (!closure921.\u0024VB\u0024Local_expiringCompanyLocationGuid.Equals(Guid.Empty))
        {
          // ISSUE: reference to a compiler-generated field
          dictionary["@expiringCompanyLocationGuid"].Value = (object) closure921.\u0024VB\u0024Local_expiringCompanyLocationGuid;
        }
        DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "dbo.spGetCompanyCommission", 180, (CommandArgumentType) 2, new object[1]
        {
          (object) dictionary
        });
        DbParameter dbParameter = dictionary["@Commission"];
        commission = !Utility.IsNull(RuntimeHelpers.GetObjectValue(dbParameter.Value)) ? Conversions.ToDecimal(dbParameter.Value) : throw new InvalidOperationException("The system was unable to determine the company commission");
      }
    }
    return commission;
  }

  public static CompanyLine FromCompanyLineGuid(Guid companyLineGuid)
  {
    return ObjectFactory.Instance.CreateObjectAs<CompanyLine>((object) companyLineGuid);
  }

  [Obsolete("This method fails to take the parent line into consideration. Could return a child line where a parent line was expected (or vice versa).")]
  public static bool IsValidCompanyLine(Guid companyLocationGuid, Guid lineGuid, string stateID)
  {
    return CompanyLine.ResolveCompanyLineGuid(companyLocationGuid, lineGuid, stateID, new Guid?(Guid.Empty)).HasValue;
  }

  public static bool IsValidCompanyLine(
    Guid companyLocationGuid,
    Guid lineGuid,
    string stateID,
    Guid? parentLine)
  {
    if (Guid.Empty.Equals((object) parentLine))
      parentLine = new Guid?();
    return CompanyLine.ResolveCompanyLineGuid(companyLocationGuid, lineGuid, stateID, parentLine).HasValue;
  }

  public static Guid? ResolveCompanyLineGuid(
    Guid companyLocationGuid,
    Guid lineGuid,
    string stateID,
    Guid? parentLine)
  {
    (Guid?, Guid, Guid, string) key = (parentLine, companyLocationGuid, lineGuid, stateID);
    return CompanyLine._validCompanyLines.GetOrAdd(key, (System.Func<(Guid?, Guid, Guid, string), Guid?>) ([SpecialName] (inputKey) => DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT CompanyLineGuid FROM dbo.tblCompanyLines WITH(NOLOCK) WHERE CompanyLocationGuid=@CLG AND LineGuid=@LG AND StateID=@SID" + (Guid.Empty.Equals((object) parentLine) ? string.Empty : " AND ISNULL(ParentCompanyLineGuid, @EG) = ISNULL(@PCL, @EG)"), new object[10]
    {
      (object) "@PCL",
      (object) inputKey.Item1,
      (object) "@CLG",
      (object) inputKey.Item2,
      (object) "@LG",
      (object) inputKey.Item3,
      (object) "@SID",
      (object) inputKey.Item4,
      (object) "@EG",
      (object) Guid.Empty
    })));
  }

  public static bool ReturnCompanyCommissionOnMaxProdComm()
  {
    return CompanyLine._returnCompanyCommissionOnMaxProdComm.Value;
  }

  public enum BindingRequirements
  {
    Retailer = 1,
    AccountNumber = 2,
    RiskClass = 3,
    LocationClassCodes = 4,
    LocationTerritoryCodes = 5,
    PropertyRaterPriorRate = 6,
    SLANumber = 7,
    InstallmentOption = 9,
    NaicsCode = 10, // 0x0000000A
  }

  public class CompanyLineGuidNotFoundException : Exception
  {
  }

  [TableMapping("dbo.tblCompanyLineTermsOfPayment")]
  public class PaymentTerms : BaseDataObject
  {
    private int _paymentTermsId;

    public PaymentTerms(int paymentTermsID) => this._paymentTermsId = paymentTermsID;

    public PaymentTerms(int companyLineID, DateTime effective)
    {
      this._paymentTermsId = (DefaultDatabase.ExecuteScalar<int?>(CommandType.Text, "SELECT TOP(1) PaymentTermsID FROM dbo.tblCompanyLineTermsOfPayment WITH(NOLOCK) WHERE CompanyLineID = @CLID AND cast(Effective as Date) <= @Eff ORDER BY Effective DESC", new object[4]
      {
        (object) "@CLID",
        (object) companyLineID,
        (object) "@Eff",
        (object) effective
      }) ?? throw new InvalidOperationException("No PaymentTerms found for specified Company/Effective combination.")).Value;
    }

    [DataKey]
    public int PaymentTermsID
    {
      get => this._paymentTermsId;
      protected set
      {
        this._paymentTermsId = this._paymentTermsId <= 0 ? value : throw new InvalidOperationException($"Specified PaymentTerms {this._paymentTermsId} has already been initialized");
      }
    }

    [TableFieldMapping]
    public string ProducerPaymentMeasuredFrom
    {
      get
      {
        return this.GetField<string>(nameof (ProducerPaymentMeasuredFrom), nameof (ProducerPaymentMeasuredFrom));
      }
    }

    [TableFieldMapping]
    public string ProducerPaymentMeasuredFrom_Endorsement
    {
      get
      {
        return this.GetField<string>(nameof (ProducerPaymentMeasuredFrom_Endorsement), nameof (ProducerPaymentMeasuredFrom_Endorsement));
      }
    }

    [TableFieldMapping]
    public short DefaultProducerTermsOfPayment
    {
      get
      {
        return this.GetField<short>(nameof (DefaultProducerTermsOfPayment), nameof (DefaultProducerTermsOfPayment));
      }
    }

    [TableFieldMapping]
    public short DefaultProducerTermsOfPayment_Endorsement
    {
      get
      {
        return this.GetField<short>(nameof (DefaultProducerTermsOfPayment_Endorsement), nameof (DefaultProducerTermsOfPayment_Endorsement));
      }
    }
  }
}
