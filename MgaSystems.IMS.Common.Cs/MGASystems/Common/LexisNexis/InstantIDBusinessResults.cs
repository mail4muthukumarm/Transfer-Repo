// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.InstantIDBusinessResults
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class InstantIDBusinessResults
{
  [JsonProperty("BankruptcyFilingsCount")]
  public int? BankruptcyFilingsCount { get; set; }

  [JsonProperty("ComprehensiveVerificationIndex")]
  public int? ComprehensiveVerificationIndex { get; set; }

  [JsonProperty("CorrectedCompanyName")]
  public string CorrectedCompanyName { get; set; }

  [JsonProperty("Errors")]
  public ICollection<ResultError> Errors { get; set; }

  [JsonProperty("FEINMatches")]
  public ICollection<IIDFEINMatch> FEINMatches { get; set; }

  [JsonProperty("Input")]
  public IIDInput Input { get; set; }

  [JsonProperty("MostRecentBankrupctyFiling")]
  public IIDFiling MostRecentBankrupctyFiling { get; set; }

  [JsonProperty("MostRecentJudgmentLienFiling")]
  public IIDFiling MostRecentJudgmentLienFiling { get; set; }

  [JsonProperty("NameAddressFEINIndicator")]
  public int? NameAddressFEINIndicator { get; set; }

  [JsonProperty("NameAddressPhoneIndicator")]
  public int? NameAddressPhoneIndicator { get; set; }

  [JsonProperty("NameAddressSSNIndicator")]
  public int? NameAddressSSNIndicator { get; set; }

  [JsonProperty("PhoneOfNameAddress")]
  public string PhoneOfNameAddress { get; set; }

  [JsonProperty("PhoneType")]
  public string PhoneType { get; set; }

  [JsonProperty("ReleasedJudgmentLienCount")]
  public int? ReleasedJudgmentLienCount { get; set; }

  [JsonProperty("ReversePhone")]
  public IIDReversePhone ReversePhone { get; set; }

  [JsonProperty("RiskIndicators")]
  public ICollection<IIDRiskIndicator> RiskIndicators { get; set; }

  [JsonProperty("UnreleasedJudgmentLienCount")]
  public int? UnreleasedJudgmentLienCount { get; set; }

  [JsonProperty("VerificationIndicators")]
  public IIDVerificationIndicators VerificationIndicators { get; set; }

  [JsonProperty("VerifiedInput")]
  public IIDInput VerifiedInput { get; set; }

  [JsonProperty("Watchlist")]
  public IIDWatchlist Watchlist { get; set; }
}
