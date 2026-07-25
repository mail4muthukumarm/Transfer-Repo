// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ComplyAdvantage.Data.CheckResult
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MGASystems.Common.ComplyAdvantage.Data;

public class CheckResult
{
  [JsonProperty("success")]
  public bool Success { get; set; }

  [JsonProperty("exact_match")]
  public bool ExactMatch { get; set; }

  [JsonProperty("created")]
  public DateTime Created { get; set; }

  [JsonProperty("updated")]
  public DateTime Updated { get; set; }

  [JsonProperty("searchTerm")]
  public string SearchTerm { get; set; }

  [JsonProperty("totalHits")]
  public int TotalHits { get; set; }

  [JsonProperty("id")]
  public string Id { get; set; }

  [JsonProperty("reference")]
  public string Reference { get; set; }

  [JsonProperty("matchStatus")]
  public string MatchStatus { get; set; }

  [JsonProperty("riskLevel")]
  public string RiskLevel { get; set; }

  [JsonProperty("url")]
  public string Url { get; set; }
}
