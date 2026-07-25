// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRate_PolicyTotals
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRate_PolicyTotals
{
  [JsonProperty("Company")]
  public string Company { get; set; }

  [JsonProperty("CompanyCode")]
  public string CompanyCode { get; set; }

  [JsonProperty("TerrorismPrevious")]
  public string TerrorismPrevious { get; set; }

  [JsonProperty("TaxesPrevious")]
  public string TaxesPrevious { get; set; }

  [JsonProperty("ExcessLiabilityMinimumApplies")]
  public string ExcessLiabilityMinimumApplies { get; set; }

  [JsonProperty("TargetPremium")]
  public string TargetPremium { get; set; }

  [JsonProperty("CompositePremium")]
  public string CompositePremium { get; set; }

  [JsonProperty("OriginalPremium")]
  public string OriginalPremium { get; set; }

  [JsonProperty("ExposureAmount")]
  public string ExposureAmount { get; set; }

  [JsonProperty("ExposureBasis")]
  public string ExposureBasis { get; set; }

  [JsonProperty("RatePer")]
  public string RatePer { get; set; }

  [JsonProperty("SurchargePremium")]
  public string SurchargePremium { get; set; }

  [JsonProperty("TerrorismPremium")]
  public string TerrorismPremium { get; set; }

  [JsonProperty("TotalPremium")]
  public string TotalPremium { get; set; }

  [JsonProperty("TotalwoSurchargePremium")]
  public string TotalwoSurchargePremium { get; set; }

  [JsonProperty("TotalwoSurchargePremiumTerrorismOpposite")]
  public string TotalwoSurchargePremiumTerrorismOpposite { get; set; }

  [JsonProperty("TotalPremiumTerrorismOpposite")]
  public string TotalPremiumTerrorismOpposite { get; set; }

  [JsonProperty("TerrorismOpposite")]
  public string TerrorismOpposite { get; set; }

  [JsonProperty("TaxesEndorse")]
  public string TaxesEndorse { get; set; }

  [JsonProperty("LiabExperience")]
  public NetRate_LiabExperience LiabExperience { get; set; }

  [JsonProperty("PolicyLiability")]
  public NetRate_PolicyLiability PolicyLiability { get; set; }
}
