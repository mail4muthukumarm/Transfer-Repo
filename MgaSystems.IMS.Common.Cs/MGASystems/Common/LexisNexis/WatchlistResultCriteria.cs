// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WatchlistResultCriteria
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class WatchlistResultCriteria
{
  [JsonProperty("ErrorText")]
  public string ErrorText { get; set; }

  [JsonProperty("ExcludeIfTrueMatchUpdatesOnly")]
  public bool? ExcludeIfTrueMatchUpdatesOnly { get; set; }

  [JsonProperty("ExcludeIfFalseMatchUpdatesOnly")]
  public bool? ExcludeIfFalseMatchUpdatesOnly { get; set; }

  [JsonProperty("FalseMatchUpdatesOnly")]
  public bool? FalseMatchUpdatesOnly { get; set; }

  [JsonProperty("MatchDispositionFalsePositive")]
  public bool? MatchDispositionFalsePositive { get; set; }

  [JsonProperty("MatchDispositionTrueMatch")]
  public bool? MatchDispositionTrueMatch { get; set; }

  [JsonProperty("ReasonListed")]
  public string ReasonListed { get; set; }

  [JsonProperty("ScoreEnd")]
  public int? ScoreEnd { get; set; }

  [JsonProperty("ScoreStart")]
  public int? ScoreStart { get; set; }

  [JsonProperty("SearchOnErrors")]
  public bool? SearchOnErrors { get; set; }

  [JsonProperty("SourceName")]
  public string SourceName { get; set; }

  [JsonProperty("TrueMatchUpdatesOnly")]
  public bool? TrueMatchUpdatesOnly { get; set; }
}
