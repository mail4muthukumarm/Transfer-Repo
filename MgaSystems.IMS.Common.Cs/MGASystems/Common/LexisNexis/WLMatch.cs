// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WLMatch
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class WLMatch
{
  [JsonProperty("AcceptListID")]
  public long? AcceptListID { get; set; }

  [JsonProperty("AddedToAcceptList")]
  public bool? AddedToAcceptList { get; set; }

  [JsonProperty("Addresses")]
  public ICollection<WLAddressMatch> Addresses { get; set; }

  [JsonProperty("AddressName")]
  public bool? AddressName { get; set; }

  [JsonProperty("AutoFalsePositive")]
  public bool? AutoFalsePositive { get; set; }

  [JsonProperty("BestAddressIsPartial")]
  public bool? BestAddressIsPartial { get; set; }

  [JsonProperty("BestCountry")]
  public string BestCountry { get; set; }

  [JsonProperty("BestCountryScore")]
  public int? BestCountryScore { get; set; }

  [JsonProperty("BestCountryType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public WLMatchBestCountryType? BestCountryType { get; set; }

  [JsonProperty("BestDOBIsPartial")]
  public bool? BestDOBIsPartial { get; set; }

  [JsonProperty("BestName")]
  public string BestName { get; set; }

  [JsonProperty("BestNameScore")]
  public int? BestNameScore { get; set; }

  [JsonProperty("CheckSum")]
  public int? CheckSum { get; set; }

  [JsonProperty("Citizenships")]
  public ICollection<WLCitizenshipMatch> Citizenships { get; set; }

  [JsonProperty("Conflicts")]
  public WLMatchConflicts Conflicts { get; set; }

  [JsonProperty("CountryDetails")]
  public WLCountryDetails CountryDetails { get; set; }

  [JsonProperty("DOBs")]
  public ICollection<WLDOBMatch> DOBs { get; set; }

  [JsonProperty("EntityDetails")]
  public WLEntityDetails EntityDetails { get; set; }

  [JsonProperty("EntityName")]
  public string EntityName { get; set; }

  [JsonProperty("EntityScore")]
  public int? EntityScore { get; set; }

  [JsonProperty("EntityUniqueID")]
  public string EntityUniqueID { get; set; }

  [JsonProperty("Error")]
  public ResultError Error { get; set; }

  [JsonProperty("FalsePositive")]
  public bool? FalsePositive { get; set; }

  [JsonProperty("File")]
  public WLMatchFile File { get; set; }

  [JsonProperty("GatewayOFACScreeningIndicatorMatch")]
  public bool? GatewayOFACScreeningIndicatorMatch { get; set; }

  [JsonProperty("ID")]
  public long? ID { get; set; }

  [JsonProperty("IDs")]
  public ICollection<WLIDMatch> IDs { get; set; }

  [JsonProperty("MatchReAlert")]
  public bool? MatchReAlert { get; set; }

  [JsonProperty("MatchXML")]
  public WLMatchSummary MatchXML { get; set; }

  [JsonProperty("MatchIMDSDetails")]
  public WLMatchFprDetails MatchIMDSDetails { get; set; }

  [JsonProperty("OFACInfo")]
  public OFACReportInfo OFACInfo { get; set; }

  [JsonProperty("Phones")]
  public ICollection<WLPhoneMatch> Phones { get; set; }

  [JsonProperty("PreviousResultID")]
  public long? PreviousResultID { get; set; }

  [JsonProperty("ReasonListed")]
  public string ReasonListed { get; set; }

  [JsonProperty("ResultDate")]
  public DateTimeOffset? ResultDate { get; set; }

  [JsonProperty("SecondaryOFACScreeningIndicatorMatch")]
  public bool? SecondaryOFACScreeningIndicatorMatch { get; set; }

  [JsonProperty("TrueMatch")]
  public bool? TrueMatch { get; set; }

  [JsonProperty("CountryAssociations")]
  public ICollection<CountryAssociation> CountryAssociations { get; set; }

  [JsonProperty("Vessels")]
  public ICollection<Vessel> Vessels { get; set; }

  [JsonProperty("MSBs")]
  public ICollection<MSB> MSBs { get; set; }

  [JsonProperty("Sanctions")]
  public ICollection<Sanction> Sanctions { get; set; }

  [JsonProperty("Relationships")]
  public ICollection<Relationship> Relationships { get; set; }

  [JsonProperty("PEPs")]
  public ICollection<PEP> PEPs { get; set; }

  [JsonProperty("SOEs")]
  public ICollection<SOE> SOEs { get; set; }

  [JsonProperty("Enforcements")]
  public ICollection<Enforcement> Enforcements { get; set; }

  [JsonProperty("AdverseMedias")]
  public ICollection<AdverseMedia> AdverseMedias { get; set; }

  [JsonProperty("OtherSegments")]
  public ICollection<OtherSegment> OtherSegments { get; set; }

  [JsonProperty("Registrations")]
  public ICollection<Registration> Registrations { get; set; }

  [JsonProperty("SourceItems")]
  public ICollection<SourceItem> SourceItems { get; set; }

  [JsonProperty("DeceasedDate")]
  public string DeceasedDate { get; set; }

  [JsonProperty("DateModified")]
  public DateTimeOffset? DateModified { get; set; }

  [JsonProperty("Status")]
  [JsonConverter(typeof (StringEnumConverter))]
  public WLMatchStatus? Status { get; set; }
}
