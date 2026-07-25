// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WatchlistConfiguration
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class WatchlistConfiguration
{
  [JsonProperty("AutomaticFalsePositiveRules")]
  public WatchlistAutomaticFalsePositiveRules AutomaticFalsePositiveRules { get; set; }

  [JsonProperty("IMDS")]
  public WatchlistIntelligentMatchDecisionSolution IMDS { get; set; }

  [JsonProperty("DataFiles")]
  public ICollection<WatchlistDataFile> DataFiles { get; set; }

  [JsonProperty("GeneralOptions")]
  public WatchlistGeneralOptions GeneralOptions { get; set; }

  [JsonProperty("MatchDispositionRules")]
  public WatchlistMatchDispositionRules MatchDispositionRules { get; set; }

  [JsonProperty("MatchOptions")]
  public WatchlistMatchOptions MatchOptions { get; set; }

  [JsonProperty("FalseMatchSettings")]
  public WatchlistFalseMatchSettings FalseMatchSettings { get; set; }
}
