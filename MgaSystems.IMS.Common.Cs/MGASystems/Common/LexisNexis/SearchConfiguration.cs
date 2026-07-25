// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.SearchConfiguration
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class SearchConfiguration
{
  [JsonProperty("AssignResultTo")]
  public AssignmentInfo AssignResultTo { get; set; }

  [JsonProperty("FraudPoint")]
  public FraudPointConfiguration FraudPoint { get; set; }

  [JsonProperty("InstantID")]
  public InstantIDConfiguration InstantID { get; set; }

  [JsonProperty("InstantIDIntl")]
  public InstantIDIntlConfiguration InstantIDIntl { get; set; }

  [JsonProperty("PredefinedSearchName")]
  public string PredefinedSearchName { get; set; }

  [JsonProperty("Watchlist")]
  public WatchlistConfiguration Watchlist { get; set; }

  [JsonProperty("WriteResultsToDatabase")]
  public bool? WriteResultsToDatabase { get; set; }

  [JsonProperty("ExcludeScreeningListMatches")]
  public bool? ExcludeScreeningListMatches { get; set; }

  [JsonProperty("DuplicateMatchSuppression")]
  public bool? DuplicateMatchSuppression { get; set; }

  [JsonProperty("DuplicateMatchSuppressionSameDivisionOnly")]
  public bool? DuplicateMatchSuppressionSameDivisionOnly { get; set; }
}
