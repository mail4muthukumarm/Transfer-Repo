// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.UpdateSearch
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public class UpdateSearch
{
  [JsonProperty("match_status")]
  public string MatchStatus { get; set; }

  [JsonProperty("risk_level")]
  public string RiskLevel { get; set; }

  [JsonProperty("assignee_id")]
  public int? AssigneeID { get; set; }

  [JsonProperty("limit")]
  public int? Limit { get; set; }

  [JsonProperty("tags")]
  public Dictionary<string, string> Tags { get; set; }
}
