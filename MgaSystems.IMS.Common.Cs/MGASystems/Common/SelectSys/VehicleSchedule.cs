// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.VehicleSchedule
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class VehicleSchedule
{
  [JsonProperty("No")]
  public int No { get; set; }

  [JsonProperty("Year")]
  public int Year { get; set; }

  [JsonProperty("Make")]
  public string Make { get; set; }

  [JsonProperty("Model")]
  public string Model { get; set; }

  [JsonProperty("VIN")]
  public string VIN { get; set; }

  [JsonProperty("BodyType")]
  public string BodyType { get; set; }

  [JsonProperty("VehicleType")]
  public string VehicleType { get; set; }

  [JsonProperty("SYMOrAGE")]
  public string SYMOrAGE { get; set; }

  [JsonProperty("COMPOROTCSYM")]
  public string COMPOROTCSYM { get; set; }

  [JsonProperty("COLLSYM")]
  public string COLLSYM { get; set; }

  [JsonProperty("GaragingAddress")]
  public Acord_AddressInfo GaragingAddress { get; set; }

  [JsonProperty("LICState")]
  public string LICState { get; set; }

  [JsonProperty("TERR")]
  public string TERR { get; set; }

  [JsonProperty("GVMOrGCW")]
  public string GVMOrGCW { get; set; }

  [JsonProperty("Class")]
  public string Class { get; set; }

  [JsonProperty("SIC")]
  public string SIC { get; set; }

  [JsonProperty("Factor")]
  public string Factor { get; set; }

  [JsonProperty("SeatCP")]
  public string SeatCP { get; set; }

  [JsonProperty("Radius")]
  public string Radius { get; set; }

  [JsonProperty("FarthestTerminal")]
  public string FarthestTerminal { get; set; }

  [JsonProperty("CostNew")]
  public string CostNew { get; set; }

  [JsonProperty("USE")]
  public string USE { get; set; }

  [JsonProperty("CheckCoverages")]
  public ICollection<int> CheckCoverages { get; set; }

  [JsonProperty("Deductibles")]
  public double Deductibles { get; set; }

  [JsonProperty("DriveToSchool_LessThan15")]
  public bool DriveToSchool_LessThan15 { get; set; }

  [JsonProperty("DriveToSchool_GreaterThan15")]
  public bool DriveToSchool_GreaterThan15 { get; set; }

  [JsonProperty("NetVehCRORDR")]
  public double NetVehCRORDR { get; set; }

  [JsonProperty("TotalPremium")]
  public double TotalPremium { get; set; }
}
