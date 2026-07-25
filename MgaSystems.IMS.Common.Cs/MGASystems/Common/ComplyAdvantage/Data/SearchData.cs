// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ComplyAdvantage.Data.SearchData
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using MGASystems.Data.DataMapping;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.ComplyAdvantage.Data;

[TableMapping("tblComplyAdvantageResults")]
public class SearchData
{
  public static HashSet<string> GoodStatuses = new HashSet<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase)
  {
    "no_match",
    "false_positive",
    "true_positive_approve"
  };

  [DataKey]
  [TableFieldMapping]
  [JsonProperty("id")]
  public int Id { get; set; }

  [TableFieldMapping]
  [JsonProperty("total_hits")]
  public int TotalHits { get; set; }

  [TableFieldMapping]
  [JsonProperty("ref")]
  public string Ref { get; set; }

  [TableFieldMapping]
  [JsonProperty("match_status")]
  public string MatchStatus { get; set; }

  [TableFieldMapping]
  [JsonProperty("risk_level")]
  public string RiskLevel { get; set; }

  [TableFieldMapping]
  [JsonProperty("share_url")]
  public string ShareUrl { get; set; }

  [TableFieldMapping]
  [JsonProperty("created_at")]
  public DateTimeOffset CreatedAt { get; set; }

  [TableFieldMapping]
  [JsonProperty("updated_at")]
  public DateTimeOffset UpdatedAt { get; set; }

  [TableFieldMapping]
  [JsonProperty("search_term")]
  public string SearchTerm { get; set; }

  [TableFieldMapping]
  public Guid EntityGuid { get; set; }

  [TableFieldMapping]
  public DateTimeOffset? LastSearched { get; set; }

  public DateTimeOffset LastUpdated => this.LastSearched ?? this.UpdatedAt;

  public bool IsOk() => this.TotalHits < 1 || SearchData.GoodStatuses.Contains(this.MatchStatus);

  public bool OlderThan(TimeSpan maxAge)
  {
    return DateTimeOffset.Now - (DateTimeOffset) this.LastUpdated.LocalDateTime > maxAge;
  }
}
