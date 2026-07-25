// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.SearchRequest
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public class SearchRequest
{
  [JsonProperty("search_term")]
  public string SearchTerm { get; set; }

  [JsonProperty("client_ref")]
  public string ClientRef { get; set; }

  [JsonProperty("search_profile")]
  public string SearchProfile { get; set; }

  [JsonProperty("fuzziness")]
  public Decimal? Fuzziness { get; set; }

  [JsonProperty("exact_match")]
  public bool? ExactMatch { get; set; } = new bool?(false);

  [JsonProperty("share_url")]
  [JsonConverter(typeof (BooleanIntConverter))]
  public bool ShareUrl { get; set; } = true;

  [JsonProperty("limit")]
  public int? Limit { get; set; } = new int?(10);

  [JsonProperty("offset")]
  public int? Offset { get; set; } = new int?(0);

  [JsonProperty("filters")]
  public SearchFilters Filters { get; set; }
}
