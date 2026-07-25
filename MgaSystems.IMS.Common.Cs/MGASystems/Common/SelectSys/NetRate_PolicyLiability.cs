// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRate_PolicyLiability
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRate_PolicyLiability
{
  [JsonProperty("EndorsePremium")]
  public string EndorsePremium { get; set; }

  [JsonProperty("Terrorism")]
  public string Terrorism { get; set; }

  [JsonProperty("EndorseTerrorism")]
  public string EndorseTerrorism { get; set; }

  [JsonProperty("LiabilityTotal")]
  public string LiabilityTotal { get; set; }

  [JsonProperty("MultiLocationDispersalCredit")]
  public string MultiLocationDispersalCredit { get; set; }

  [JsonProperty("LiabilityTotalBeforeSOP")]
  public string LiabilityTotalBeforeSOP { get; set; }

  [JsonProperty("Premises")]
  public string Premises { get; set; }

  [JsonProperty("Products")]
  public string Products { get; set; }

  [JsonProperty("StopGap")]
  public string StopGap { get; set; }

  [JsonProperty("HiredAuto")]
  public string HiredAuto { get; set; }

  [JsonProperty("EmpBenefits")]
  public string EmpBenefits { get; set; }

  [JsonProperty("NonOwned")]
  public string NonOwned { get; set; }

  [JsonProperty("ExtendedPeriodPremium")]
  public string ExtendedPeriodPremium { get; set; }

  [JsonProperty("OCP")]
  public string OCP { get; set; }

  [JsonProperty("AssaultBatteryExcl")]
  public string AssaultBatteryExcl { get; set; }

  [JsonProperty("ExtensionofCoverage")]
  public string ExtensionofCoverage { get; set; }

  [JsonProperty("AddlInsured")]
  public string AddlInsured { get; set; }

  [JsonProperty("Liquor")]
  public string Liquor { get; set; }

  [JsonProperty("Garage")]
  public string Garage { get; set; }

  [JsonProperty("LiabilitySubTotal")]
  public string LiabilitySubTotal { get; set; }

  [JsonProperty("CSLCredit")]
  public string CSLCredit { get; set; }

  [JsonProperty("CSLCreditPremium")]
  public string CSLCreditPremium { get; set; }

  [JsonProperty("ProductsOnly")]
  public string ProductsOnly { get; set; }

  [JsonProperty("OCPcbx")]
  public string OCPcbx { get; set; }
}
