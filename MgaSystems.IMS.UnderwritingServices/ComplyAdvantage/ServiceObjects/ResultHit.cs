// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.ResultHit
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public class ResultHit
{
  [JsonProperty("doc")]
  public ResultDoc Doc { get; set; }

  [JsonProperty("is_whitelisted")]
  public bool IsWhitelisted { get; set; }

  [JsonProperty("match_types")]
  public List<string> MatchTypes { get; set; }

  [JsonProperty("match_types_details")]
  public List<ResultMatchTypesDetail> MatchTypesDetails { get; set; }

  [JsonProperty("score")]
  public Decimal Score { get; set; }
}
