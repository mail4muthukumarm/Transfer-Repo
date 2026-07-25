// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRateRequestInput
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRateRequestInput
{
  [JsonProperty("CompanyCode")]
  [Required(AllowEmptyStrings = true)]
  public string CompanyCode { get; set; }

  [JsonProperty("Company")]
  [Required(AllowEmptyStrings = true)]
  public string Company { get; set; }

  [JsonProperty("AgencyUpdateCode")]
  [Required(AllowEmptyStrings = true)]
  public string AgencyUpdateCode { get; set; }

  [JsonProperty("ProgramName")]
  [Required(AllowEmptyStrings = true)]
  public string ProgramName { get; set; }

  [JsonProperty("ProgramCode")]
  [Required(AllowEmptyStrings = true)]
  public string ProgramCode { get; set; }

  [JsonProperty("Underwriter")]
  [Required(AllowEmptyStrings = true)]
  public string Underwriter { get; set; }

  [JsonProperty("EffectiveDate")]
  public string EffectiveDate { get; set; }

  [JsonProperty("InsuredDetails")]
  public NetRateRequestInput_InsuredDetails InsuredDetails { get; set; }
}
