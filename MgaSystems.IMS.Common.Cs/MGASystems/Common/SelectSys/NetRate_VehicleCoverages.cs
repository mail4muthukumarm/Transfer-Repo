// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRate_VehicleCoverages
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRate_VehicleCoverages
{
  [JsonProperty("Medical")]
  public string Medical { get; set; }

  [JsonProperty("SpecialLiability")]
  public string SpecialLiability { get; set; }

  [JsonProperty("Uninsured")]
  public double Uninsured { get; set; }

  [JsonProperty("Comprehensive")]
  public int Comprehensive { get; set; }

  [JsonProperty("Collision")]
  public int Collision { get; set; }

  [JsonProperty("UMCoverage")]
  public NetRate_UMCoverage UMCoverage { get; set; }

  [JsonProperty("PIPDeductible")]
  public int PIPDeductible { get; set; }

  [JsonProperty("PPIDeductible")]
  public int PPIDeductible { get; set; }

  [JsonProperty("IncomeBenefits")]
  public string IncomeBenefits { get; set; }

  [JsonProperty("ExtendedPIP")]
  public string ExtendedPIP { get; set; }

  [JsonProperty("TypeOfCollision")]
  public string TypeOfCollision { get; set; }
}
