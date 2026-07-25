// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.FraudPointResultCriteria
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class FraudPointResultCriteria
{
  [JsonProperty("ErrorText")]
  public string ErrorText { get; set; }

  [JsonProperty("ProviderErrorsOnly")]
  public bool? ProviderErrorsOnly { get; set; }

  [JsonProperty("RedFlags")]
  public ICollection<FPResultCriteriaRedFlag> RedFlags { get; set; }

  [JsonProperty("RiskIndicators")]
  public ICollection<int> RiskIndicators { get; set; }

  [JsonProperty("ScoreEnd")]
  public int? ScoreEnd { get; set; }

  [JsonProperty("ScoreStart")]
  public int? ScoreStart { get; set; }

  [JsonProperty("SyntheticIdentityIndexStart")]
  public int? SyntheticIdentityIndexStart { get; set; }

  [JsonProperty("SyntheticIdentityIndexEnd")]
  public int? SyntheticIdentityIndexEnd { get; set; }

  [JsonProperty("StolenIdentityIndexStart")]
  public int? StolenIdentityIndexStart { get; set; }

  [JsonProperty("StolenIdentityIndexEnd")]
  public int? StolenIdentityIndexEnd { get; set; }

  [JsonProperty("ManipulatedIdentityIndexStart")]
  public int? ManipulatedIdentityIndexStart { get; set; }

  [JsonProperty("ManipulatedIdentityIndexEnd")]
  public int? ManipulatedIdentityIndexEnd { get; set; }

  [JsonProperty("VulnerableVictimIndexStart")]
  public int? VulnerableVictimIndexStart { get; set; }

  [JsonProperty("VulnerableVictimIndexEnd")]
  public int? VulnerableVictimIndexEnd { get; set; }

  [JsonProperty("FriendlyFraudIndexStart")]
  public int? FriendlyFraudIndexStart { get; set; }

  [JsonProperty("FriendlyFraudIndexEnd")]
  public int? FriendlyFraudIndexEnd { get; set; }

  [JsonProperty("SuspiciousActivityIndexStart")]
  public int? SuspiciousActivityIndexStart { get; set; }

  [JsonProperty("SuspiciousActivityIndexEnd")]
  public int? SuspiciousActivityIndexEnd { get; set; }
}
