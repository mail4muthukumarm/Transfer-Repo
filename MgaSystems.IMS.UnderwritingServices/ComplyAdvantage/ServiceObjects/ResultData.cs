// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.ResultData
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public class ResultData
{
  [JsonProperty("id")]
  public int ID { get; set; }

  [JsonProperty("ref")]
  public string Ref { get; set; }

  [JsonProperty("searcher_id")]
  public int SearcherID { get; set; }

  [JsonProperty("assignee_id")]
  public int AssigneeID { get; set; }

  [JsonProperty("search_profile")]
  public ResultSearchProfile SearchProfile { get; set; }

  [JsonProperty("filters")]
  public SearchFilters Filters { get; set; }

  [JsonProperty("match_status")]
  public string MatchStatus { get; set; }

  [JsonProperty("risk_level")]
  public string RiskLevel { get; set; }

  [JsonProperty("search_term")]
  public string SearchTerm { get; set; }

  [JsonProperty("total_hits")]
  public int TotalHits { get; set; }

  [JsonProperty("total_matches")]
  public int TotalMatches { get; set; }

  [JsonProperty("created_at")]
  public DateTimeOffset CreatedAt { get; set; }

  [JsonProperty("updated_at")]
  public DateTimeOffset UpdatedAt { get; set; }

  [JsonProperty("tags")]
  [JsonConverter(typeof (EmptyDictionaryConverter))]
  public Dictionary<string, string> Tags { get; set; }

  [JsonProperty("hits")]
  public List<ResultHit> Hits { get; set; }

  [JsonProperty("labels")]
  public List<ResultLabel> Labels { get; set; }

  [JsonProperty("share_url")]
  public string ShareUrl { get; set; }
}
