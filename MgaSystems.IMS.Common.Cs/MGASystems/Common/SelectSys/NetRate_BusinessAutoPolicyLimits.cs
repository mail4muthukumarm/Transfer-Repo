// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRate_BusinessAutoPolicyLimits
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRate_BusinessAutoPolicyLimits
{
  [JsonProperty("Liability")]
  public string Liability { get; set; }

  [JsonProperty("RiskQuality")]
  public string RiskQuality { get; set; }

  [JsonProperty("Fleet")]
  public string Fleet { get; set; }

  [JsonProperty("LiabilityDeductible")]
  public string LiabilityDeductible { get; set; }

  [JsonProperty("LiabilityDedPDOnly")]
  public string LiabilityDedPDOnly { get; set; }
}
