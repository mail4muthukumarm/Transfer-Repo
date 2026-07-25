// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRate_LiabilityExposures
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRate_LiabilityExposures
{
  [JsonProperty("UnitNumber")]
  public string UnitNumber { get; set; }

  [JsonProperty("_UnitNumber")]
  public string _UnitNumber { get; set; }

  [JsonProperty("Description")]
  public string Description { get; set; }

  [JsonProperty("ClassCode")]
  public string ClassCode { get; set; }

  [JsonProperty("QCClassCode")]
  public string QCClassCode { get; set; }

  [JsonProperty("Exposure")]
  public string Exposure { get; set; }

  [JsonProperty("Current")]
  public string Current { get; set; }

  [JsonProperty("PremisesRate")]
  public string PremisesRate { get; set; }

  [JsonProperty("ProductsRate")]
  public string ProductsRate { get; set; }
}
