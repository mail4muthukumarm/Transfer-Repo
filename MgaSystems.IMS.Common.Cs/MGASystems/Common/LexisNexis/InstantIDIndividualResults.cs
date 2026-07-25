// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.InstantIDIndividualResults
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class InstantIDIndividualResults
{
  [JsonProperty("AddressCMRA")]
  public string AddressCMRA { get; set; }

  [JsonProperty("AddressHistory")]
  public ICollection<IIDAddressHistory> AddressHistory { get; set; }

  [JsonProperty("AddressPOBox")]
  public string AddressPOBox { get; set; }

  [JsonProperty("AlternateNames")]
  public ICollection<IIDAlternateName> AlternateNames { get; set; }

  [JsonProperty("ComprehensiveVerificationIndex")]
  public int? ComprehensiveVerificationIndex { get; set; }

  [JsonProperty("DOBMatchLevel")]
  public int? DOBMatchLevel { get; set; }

  [JsonProperty("Errors")]
  public ICollection<ResultError> Errors { get; set; }

  [JsonProperty("Input")]
  public IIDInput Input { get; set; }

  [JsonProperty("LexID")]
  public string LexID { get; set; }

  [JsonProperty("NameAddressPhone")]
  public IIDRiskIndicator NameAddressPhone { get; set; }

  [JsonProperty("NameAddressSSN")]
  public IIDRiskIndicator NameAddressSSN { get; set; }

  [JsonProperty("PhoneOfNameAddress")]
  public string PhoneOfNameAddress { get; set; }

  [JsonProperty("PotentialFollowupActions")]
  public ICollection<IIDRiskIndicator> PotentialFollowupActions { get; set; }

  [JsonProperty("RedFlags")]
  public ICollection<IIDRedFlag> RedFlags { get; set; }

  [JsonProperty("ReversePhone")]
  public IIDReversePhone ReversePhone { get; set; }

  [JsonProperty("RiskIndicators")]
  public ICollection<IIDRiskIndicator> RiskIndicators { get; set; }

  [JsonProperty("SSNInfo")]
  public IIDSSNInfo SSNInfo { get; set; }

  [JsonProperty("VerifiedInput")]
  public IIDInput VerifiedInput { get; set; }

  [JsonProperty("Version")]
  public string Version { get; set; }

  [JsonProperty("Watchlist")]
  public IIDWatchlist Watchlist { get; set; }
}
