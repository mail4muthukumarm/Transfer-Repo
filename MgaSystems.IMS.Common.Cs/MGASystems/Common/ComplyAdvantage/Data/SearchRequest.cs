// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ComplyAdvantage.Data.SearchRequest
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MGASystems.Common.ComplyAdvantage.Data;

public class SearchRequest
{
  [JsonProperty("search_term")]
  public string SearchTerm { get; set; }

  [JsonProperty("client_ref")]
  public string ClientRef { get; set; }

  [JsonProperty("fuzziness")]
  public Decimal Fuzziness { get; set; }

  [JsonProperty("share_url")]
  public int ShareUrl { get; set; } = 1;

  [JsonProperty("filters")]
  public SearchFilters Filters { get; set; }

  [JsonProperty("limit")]
  public int Limit { get; set; } = 10;
}
