// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.ResultMedium
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public class ResultMedium
{
  [JsonProperty("date")]
  public DateTimeOffset Date { get; set; }

  [JsonProperty("snippet")]
  public string Snippet { get; set; }

  [JsonProperty("title")]
  public string Title { get; set; }

  [JsonProperty("url")]
  public string Url { get; set; }
}
