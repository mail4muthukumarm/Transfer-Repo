// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ComplyAdvantage.Data.SearchResult
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;

#nullable disable
namespace MGASystems.Common.ComplyAdvantage.Data;

public class SearchResult
{
  [JsonProperty("code")]
  public int Code { get; set; }

  [JsonProperty("status")]
  public string Status { get; set; }

  public SearchContent Content { get; set; } = new SearchContent();
}
