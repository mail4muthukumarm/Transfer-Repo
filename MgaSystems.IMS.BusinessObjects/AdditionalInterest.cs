// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.AdditionalInterest
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using MGASystems.Common;
using MGASystems.Common.Attributes;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.Data.DataMapping;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.BusinessObjects;

[TableMapping("dbo.tblQuoteAdditionalInterests")]
[OfacEntity("Additional Interest")]
public class AdditionalInterest : OfacEntity
{
  public const string EntityTypeName = "Additional Interest";
  private Guid _additionalInterestGuid;
  private Quote _quote;
  private static readonly ConcurrentDictionary<int, Guid> _additionalInterestIDToGuidCache = new ConcurrentDictionary<int, Guid>();

  public AdditionalInterest(Guid additionalInterestGuid)
  {
    this._quote = (Quote) null;
    this.AdditionalInterestGuid = additionalInterestGuid;
  }

  public AdditionalInterest(int ID)
  {
    this._quote = (Quote) null;
    ConcurrentDictionary<int, Guid> interestIdToGuidCache = AdditionalInterest._additionalInterestIDToGuidCache;
    int key1 = ID;
    System.Func<int, Guid> valueFactory;
    // ISSUE: reference to a compiler-generated field
    if (AdditionalInterest._Closure\u0024__.\u0024I6\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      valueFactory = AdditionalInterest._Closure\u0024__.\u0024I6\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      AdditionalInterest._Closure\u0024__.\u0024I6\u002D0 = valueFactory = (System.Func<int, Guid>) ([SpecialName] (key) => DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT AdditionalInterestGuid FROM dbo.tblQuoteAdditionalInterests WITH(NOLOCK) WHERE ID=@ID", new object[2]
      {
        (object) "@ID",
        (object) key
      }) ?? Guid.Empty);
    }
    this.AdditionalInterestGuid = interestIdToGuidCache.GetOrAdd(key1, valueFactory);
    if (this.AdditionalInterestGuid.Equals(Guid.Empty))
      throw this.BaseDataObjectException($"Specified {this.GetType().Name} (ID {ID}) does not exist");
  }

  [DataKey]
  public Guid AdditionalInterestGuid
  {
    get => this._additionalInterestGuid;
    protected set
    {
      this._additionalInterestGuid = this._additionalInterestGuid.Equals(Guid.Empty) ? value : throw new InvalidOperationException($"Specified AdditionalInterest {this._additionalInterestGuid} has already been initialized");
    }
  }

  [TableFieldMapping]
  public Guid? PreviousAdditionalInterestGuid
  {
    get
    {
      return this.GetField<Guid?>(nameof (PreviousAdditionalInterestGuid), nameof (PreviousAdditionalInterestGuid));
    }
  }

  public Guid? OriginalAdditionalInterestGuid
  {
    get
    {
      return this.CacheManualValue<Guid?>(nameof (OriginalAdditionalInterestGuid), (Func<Guid?>) ([SpecialName] () => DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT qai.AdditionalInterestGuid FROM dbo.tblQuotes q WITH(NOLOCK) JOIN dbo.tblQuoteAdditionalInterests qai WITH(NOLOCK) ON q.QuoteID = qai.QuoteID " + $"WHERE q.{"ControlGuid"} = @CG AND qai.{"AdditionalInterestControlID"} = @AIID AND qai.{"PreviousAdditionalInterestGuid"} IS NULL", new object[4]
      {
        (object) "@CG",
        (object) this.Quote.ControlGuid,
        (object) "@AIID",
        (object) this.AdditionalInterestControlID
      })));
    }
  }

  [TableFieldMapping]
  public int ID => this.GetField<int>(nameof (ID), nameof (ID));

  [TableFieldMapping]
  public int QuoteID => this.GetField<int>(nameof (QuoteID), nameof (QuoteID));

  [TableFieldMapping]
  public string InterestName => this.GetField<string>(nameof (InterestName), nameof (InterestName));

  [TableFieldMapping]
  public string FirstName => this.GetField<string>(nameof (FirstName), nameof (FirstName));

  [TableFieldMapping]
  public string LastName => this.GetField<string>(nameof (LastName), nameof (LastName));

  [TableFieldMapping]
  public string Interest => this.GetField<string>(nameof (Interest), nameof (Interest));

  [TableFieldMapping]
  public bool Billable => this.GetField<bool>(nameof (Billable), nameof (Billable));

  [TableFieldMapping]
  public DateTime? OfacCleared
  {
    get => this.GetField<DateTime?>(nameof (OfacCleared), nameof (OfacCleared));
  }

  [TableFieldMapping]
  public int AdditionalInterestControlID
  {
    get
    {
      return this.GetField<int>(nameof (AdditionalInterestControlID), nameof (AdditionalInterestControlID));
    }
  }

  [TableFieldMapping("dbo.GetAdditionalInterestTypes(ID) InterestTypesString")]
  public string InterestTypesString
  {
    get => this.GetField<string>(nameof (InterestTypesString), nameof (InterestTypesString));
  }

  public string[] AdditionalInterestTypes
  {
    get
    {
      return this.CacheManualValue<string[]>(nameof (AdditionalInterestTypes), (Func<string[]>) ([SpecialName] () => ((IEnumerable<string>) (this.InterestTypesString ?? string.Empty).Split(',')).WhereNotNullOrWhitespace().ToArray<string>()));
    }
  }

  public Quote Quote
  {
    get
    {
      if (this._quote == null)
        this._quote = ObjectFactory.Instance.CreateObjectAs<Quote>((object) this.QuoteID);
      return this._quote;
    }
  }

  public string Address1
  {
    get
    {
      return !this.GetExtendedFields() ? (string) null : this.GetField<string>(nameof (Address1), nameof (Address1));
    }
  }

  public string Address2
  {
    get
    {
      return !this.GetExtendedFields() ? (string) null : this.GetField<string>(nameof (Address2), nameof (Address2));
    }
  }

  public string City
  {
    get
    {
      return !this.GetExtendedFields() ? (string) null : this.GetField<string>(nameof (City), nameof (City));
    }
  }

  public string StateID
  {
    get
    {
      return !this.GetExtendedFields() ? (string) null : this.GetField<string>(nameof (StateID), nameof (StateID));
    }
  }

  public string ZipCode
  {
    get
    {
      return !this.GetExtendedFields() ? (string) null : this.GetField<string>(nameof (ZipCode), nameof (ZipCode));
    }
  }

  public DateTime? DateOfBirth
  {
    get
    {
      return !this.GetExtendedFields() ? new DateTime?() : this.GetField<DateTime?>(nameof (DateOfBirth), nameof (DateOfBirth));
    }
  }

  public string ISOCountryCode
  {
    get
    {
      return !this.GetExtendedFields() ? (string) null : this.GetField<string>(nameof (ISOCountryCode), nameof (ISOCountryCode));
    }
  }

  public string CountryName
  {
    get
    {
      return this.CacheManualValue<string>(nameof (CountryName), (Func<string>) ([SpecialName] () =>
      {
        string countryName;
        if (!string.IsNullOrEmpty(this.ISOCountryCode))
          countryName = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Country FROM dbo.tblAddressResolver_Countries WITH(NOLOCK) WHERE ISOCode = @ISO", new object[2]
          {
            (object) "@ISO",
            (object) this.ISOCountryCode
          });
        else
          countryName = (string) null;
        return countryName;
      }));
    }
  }

  private bool GetExtendedFields()
  {
    return this.RetrieveFields("Address1", "Address2", "City", "StateID", "ZipCode", "DateOfBirth", "ISOCountryCode");
  }

  public override Guid EntityGuid => this.AdditionalInterestGuid;

  public override Guid? ParentEntityGuid => new Guid?(this.Quote.ControlGuid);

  public override OfacSystem.OfacCriteria GetSearchCriteria(IOfacSetting setting)
  {
    OfacSystem.OfacCriteria searchCriteria = this.AsOfacCriteria("Additional Interest", "MGASystems.IMS.Policies.PolicyDetail.frmPolicyDetail");
    if (string.IsNullOrEmpty(this.InterestName?.Trim()))
    {
      if (!string.IsNullOrEmpty(this.LastName?.Trim()))
        searchCriteria.LastName = this.LastName;
      if (!string.IsNullOrEmpty(this.FirstName?.Trim()))
        searchCriteria.FirstName = this.FirstName;
    }
    else
      searchCriteria.LastName = this.InterestName;
    if (!(setting is IntelligentSearch))
    {
      searchCriteria.Address = this.Address1;
      searchCriteria.Address2 = this.Address2;
      searchCriteria.City = this.City;
      searchCriteria.State = this.StateID;
      searchCriteria.ZipCode = this.ZipCode;
      if (this.DateOfBirth.HasValue)
        searchCriteria.DateOfBirth = this.DateOfBirth.Value.ToShortDateString();
      if (!string.IsNullOrEmpty(this.ISOCountryCode))
      {
        searchCriteria.IsoCountryCode = this.ISOCountryCode;
        if (setting is PublicWebServices && !string.IsNullOrEmpty(this.CountryName))
          searchCriteria.IsoCountryCode = this.CountryName;
      }
    }
    return searchCriteria;
  }

  public bool InCompliance
  {
    get
    {
      return this.CacheManualValue<bool>(nameof (InCompliance), new Func<bool>(this.GetComplianceStatus));
    }
  }

  public DateTime? OfacSearchDate => this.ComplianceStatus?.LogDate;

  private OfacSystem.OfacStatus ComplianceStatus
  {
    get
    {
      return this.CacheManualValue<OfacSystem.OfacStatus>(nameof (ComplianceStatus), new Func<OfacSystem.OfacStatus>(((OfacEntity) this).GetOfacStatus));
    }
  }

  private bool GetComplianceStatus()
  {
    OfacSystem.OfacStatus complianceStatus1 = this.ComplianceStatus;
    if ((complianceStatus1 != null ? (complianceStatus1.ClearDate.HasValue ? 1 : 0) : 0) != 0)
      this.TryAddValue<DateTime?>("OfacCleared", (DateTime?) this.ComplianceStatus?.ClearDate);
    if (!OfacSystem.Instance.HasValidSetting)
      return true;
    OfacSystem.OfacStatus complianceStatus2 = this.ComplianceStatus;
    return complianceStatus2 == null || complianceStatus2.OFACCleared;
  }

  public static HashSet<string> OfacSearchTypes
  {
    get
    {
      string str1 = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("OFAC.AdditionalInterest.ComplianceTypes");
      HashSet<string> ofacSearchTypes = new HashSet<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
      if (str1 == null)
        str1 = "";
      string[] strArray = str1.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
      int index = 0;
      while (index < strArray.Length)
      {
        string str2 = strArray[index];
        if (!string.IsNullOrEmpty(str2?.Trim()))
          ofacSearchTypes.Add(str2.Trim());
        checked { ++index; }
      }
      return ofacSearchTypes;
    }
  }

  public virtual bool SupportsRenewalSearch(
    OfacSystem.OfacStatus ofacStatus,
    ISet<string> aiTypes,
    bool forceCheckSetting)
  {
    if (ofacStatus == null && aiTypes.Intersect<string>((IEnumerable<string>) this.AdditionalInterestTypes).Any<string>())
      return true;
    if (ofacStatus == null)
      return false;
    return !ofacStatus.IsValid || forceCheckSetting;
  }
}
