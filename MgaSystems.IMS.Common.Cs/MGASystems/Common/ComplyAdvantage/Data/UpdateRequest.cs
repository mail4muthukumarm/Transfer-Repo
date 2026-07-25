// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ComplyAdvantage.Data.UpdateRequest
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.ComplyAdvantage.Data;

public class UpdateRequest
{
  [JsonProperty("match_status")]
  public string MatchStatus { get; set; }

  [JsonProperty("risk_level")]
  public string RiskLevel { get; set; }

  [JsonProperty("id")]
  public int Id { get; set; }

  [JsonProperty("tags")]
  public Dictionary<string, string> Tags { get; set; }
}
