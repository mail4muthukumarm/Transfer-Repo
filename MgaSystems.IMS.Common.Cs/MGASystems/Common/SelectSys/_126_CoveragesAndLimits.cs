// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._126_CoveragesAndLimits
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _126_CoveragesAndLimits
{
  [JsonProperty("Commercial_General_Liability")]
  public bool Commercial_General_Liability { get; set; }

  [JsonProperty("Claims_Made")]
  public bool Claims_Made { get; set; }

  [JsonProperty("Occurrence")]
  public bool Occurrence { get; set; }

  [JsonProperty("Owners_Contracts_Protective")]
  public bool Owners_Contracts_Protective { get; set; }

  [JsonProperty("Other_CoverageOption")]
  public bool Other_CoverageOption { get; set; }

  [JsonProperty("Limits_Applies_Per")]
  public ICollection<string> Limits_Applies_Per { get; set; }

  [JsonProperty("General_Aggregate")]
  public string General_Aggregate { get; set; }

  [JsonProperty("Products_And_Completed_Operations_Aggregate")]
  public string Products_And_Completed_Operations_Aggregate { get; set; }

  [JsonProperty("Personal_And_Advertising_Injury")]
  public string Personal_And_Advertising_Injury { get; set; }

  [JsonProperty("Each_Occurrence")]
  public string Each_Occurrence { get; set; }

  [JsonProperty("Damage_To_Rented_Premises")]
  public string Damage_To_Rented_Premises { get; set; }

  [JsonProperty("Medical_Expense")]
  public string Medical_Expense { get; set; }

  [JsonProperty("Employee_Benefits")]
  public string Employee_Benefits { get; set; }

  [JsonProperty("Other")]
  public string Other { get; set; }

  [JsonProperty("Other_Value")]
  public string Other_Value { get; set; }

  [JsonProperty("Deductible_Property_Damage")]
  public bool Deductible_Property_Damage { get; set; }

  [JsonProperty("Deductible_Property_Damage_Premium")]
  public string Deductible_Property_Damage_Premium { get; set; }

  [JsonProperty("Deductible_Bodily_Injury")]
  public bool Deductible_Bodily_Injury { get; set; }

  [JsonProperty("Deductible_Bodily_Injury_Premium")]
  public string Deductible_Bodily_Injury_Premium { get; set; }

  [JsonProperty("Deductible_Other")]
  public bool Deductible_Other { get; set; }

  [JsonProperty("Deductible_Other_Type")]
  public string Deductible_Other_Type { get; set; }

  [JsonProperty("Deductible_Other_Premium")]
  public string Deductible_Other_Premium { get; set; }

  [JsonProperty("Per_Claim")]
  public bool Per_Claim { get; set; }

  [JsonProperty("Per_Occurrence")]
  public bool Per_Occurrence { get; set; }

  [JsonProperty("Premises_Premium")]
  public string Premises_Premium { get; set; }

  [JsonProperty("Products_Premium")]
  public string Products_Premium { get; set; }

  [JsonProperty("Other_Premium")]
  public string Other_Premium { get; set; }

  [JsonProperty("Total_Premium")]
  public string Total_Premium { get; set; }
}
