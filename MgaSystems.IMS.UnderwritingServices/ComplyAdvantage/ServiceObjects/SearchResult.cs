// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.SearchResult
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public class SearchResult : BaseResult
{
  [JsonProperty("code")]
  public int Code { get; set; }

  [JsonProperty("status")]
  public string Status { get; set; }

  [JsonProperty("content")]
  public ResultContent Content { get; set; }

  [JsonProperty("links")]
  public ResultLinks Links { get; set; }
}
