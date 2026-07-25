// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.BAAdditionalCoveragesInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class BAAdditionalCoveragesInfo
{
  [JsonProperty("LocNo")]
  public int LocNo { get; set; }

  [JsonProperty("StateCode")]
  public string StateCode { get; set; }

  [JsonProperty("CoverCode")]
  public string CoverCode { get; set; }

  [JsonProperty("Description")]
  public string Description { get; set; }

  [JsonProperty("TypeOfCoverage")]
  public string TypeOfCoverage { get; set; }

  [JsonProperty("FormNo")]
  public string FormNo { get; set; }

  [JsonProperty("EditionDate")]
  public string EditionDate { get; set; }

  [JsonProperty("Rate")]
  public string Rate { get; set; }

  [JsonProperty("OptionCodes")]
  public string OptionCodes { get; set; }

  [JsonProperty("Limit1")]
  public double Limit1 { get; set; }

  [JsonProperty("Limit2")]
  public double Limit2 { get; set; }

  [JsonProperty("Limit3")]
  public double Limit3 { get; set; }

  [JsonProperty("Deductible1")]
  public double Deductible1 { get; set; }

  [JsonProperty("DeductibleType1")]
  public string DeductibleType1 { get; set; }

  [JsonProperty("Deductible2")]
  public double Deductible2 { get; set; }

  [JsonProperty("DeductibleType2")]
  public string DeductibleType2 { get; set; }

  [JsonProperty("Premium")]
  public double Premium { get; set; }
}
