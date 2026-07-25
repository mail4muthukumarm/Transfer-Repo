// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WatchlistMatchOptions
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class WatchlistMatchOptions
{
  [JsonProperty("Addresses")]
  public bool? Addresses { get; set; }

  [JsonProperty("IDs")]
  public bool? IDs { get; set; }

  [JsonProperty("InfluencedByInitials")]
  public bool? InfluencedByInitials { get; set; }

  [JsonProperty("InfluencedBySingleWords")]
  public bool? InfluencedBySingleWords { get; set; }

  [JsonProperty("PaymentScreeningOptions")]
  public WatchlistPaymentScreeningOptions PaymentScreeningOptions { get; set; }

  [JsonProperty("Phones")]
  public bool? Phones { get; set; }
}
