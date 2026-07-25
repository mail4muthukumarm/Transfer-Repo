// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRate_LiabExperience
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRate_LiabExperience
{
  [JsonProperty("EPL")]
  public string EPL { get; set; }

  [JsonProperty("PremisesLoss")]
  public string PremisesLoss { get; set; }

  [JsonProperty("ProductsLoss")]
  public string ProductsLoss { get; set; }

  [JsonProperty("Applied")]
  public string Applied { get; set; }

  [JsonProperty("CleanRisk")]
  public string CleanRisk { get; set; }

  [JsonProperty("Recent")]
  public string Recent { get; set; }
}
