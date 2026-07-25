// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRate_Vehicle
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRate_Vehicle
{
  [JsonProperty("VehicleUnitNumber")]
  public int VehicleUnitNumber { get; set; }

  [JsonProperty("InceptionDate")]
  public string InceptionDate { get; set; }

  [JsonProperty("Transaction")]
  public string Transaction { get; set; }

  [JsonProperty("VehicleCoverages")]
  public NetRate_VehicleCoverages VehicleCoverages { get; set; }

  [JsonProperty("ClassCode")]
  public string ClassCode { get; set; }

  [JsonProperty("VehicleType")]
  public int VehicleType { get; set; }

  [JsonProperty("ModelYear")]
  public int ModelYear { get; set; }

  [JsonProperty("Make")]
  public string Make { get; set; }

  [JsonProperty("Model")]
  public string Model { get; set; }

  [JsonProperty("VIN")]
  public string VIN { get; set; }

  [JsonProperty("RegState")]
  public string RegState { get; set; }

  [JsonProperty("CostNew")]
  public string CostNew { get; set; }

  [JsonProperty("LowMSRP")]
  public double LowMSRP { get; set; }

  [JsonProperty("HighMSRP")]
  public double HighMSRP { get; set; }

  [JsonProperty("Secondary")]
  public int Secondary { get; set; }

  [JsonProperty("Use")]
  public string Use { get; set; }

  [JsonProperty("Operator")]
  public string Operator { get; set; }

  [JsonProperty("WeightClass")]
  public string WeightClass { get; set; }

  [JsonProperty("SubjectToNoFault")]
  public string SubjectToNoFault { get; set; }

  [JsonProperty("OperatingRadius")]
  public string OperatingRadius { get; set; }

  [JsonProperty("VehicleTypeDesc")]
  public string VehicleTypeDesc { get; set; }

  [JsonProperty("FullClassCode")]
  public int FullClassCode { get; set; }

  [JsonProperty("Current")]
  public bool Current { get; set; }

  [JsonProperty("UnitNumber")]
  public int UnitNumber { get; set; }

  [JsonProperty("Text")]
  public string Text { get; set; }
}
