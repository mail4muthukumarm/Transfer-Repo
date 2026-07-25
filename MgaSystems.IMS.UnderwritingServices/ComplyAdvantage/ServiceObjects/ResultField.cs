// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.ResultField
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public class ResultField
{
  [JsonProperty("locale")]
  public string Locale { get; set; }

  [JsonProperty("name")]
  public string Name { get; set; }

  [JsonProperty("source")]
  public string Source { get; set; }

  [JsonProperty("value")]
  public string Value { get; set; }

  [JsonProperty("tag")]
  public string Tag { get; set; }
}
