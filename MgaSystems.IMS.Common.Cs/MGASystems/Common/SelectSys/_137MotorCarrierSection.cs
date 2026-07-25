// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._137MotorCarrierSection
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _137MotorCarrierSection
{
  [JsonProperty("Liability")]
  public _137Motor_Liability Liability { get; set; }

  [JsonProperty("MedicalPayments")]
  public _137Motor_MedicalPayments MedicalPayments { get; set; }

  [JsonProperty("UnInsuredOrUnderInsuredMotorist")]
  public _137Motor_Liability UnInsuredOrUnderInsuredMotorist { get; set; }

  [JsonProperty("NonTruckersHiredBorrowed")]
  public _137Motor_HiredBorrowed NonTruckersHiredBorrowed { get; set; }

  [JsonProperty("TruckersHiredBorrowed")]
  public _137Motor_HiredBorrowed TruckersHiredBorrowed { get; set; }

  [JsonProperty("NonOwnAutoLiability")]
  public _137Motor_NonOwnAutoLiability NonOwnAutoLiability { get; set; }

  [JsonProperty("PhysicalDamage_COMPOROTC")]
  public _137Motor_PhysicalDamage PhysicalDamage_COMPOROTC { get; set; }

  [JsonProperty("PhysicalDamage_Collision")]
  public _137Motor_PhysicalDamage PhysicalDamage_Collision { get; set; }
}
