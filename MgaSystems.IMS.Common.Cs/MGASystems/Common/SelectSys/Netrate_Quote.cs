// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.Netrate_Quote
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class Netrate_Quote
{
  [JsonProperty("LOBLiability")]
  public string LOBLiability { get; set; }

  [JsonProperty("DatePrepared")]
  public string DatePrepared { get; set; }

  [JsonProperty("EffectiveDate")]
  public string EffectiveDate { get; set; }

  [JsonProperty("ExpirationDate")]
  public string ExpirationDate { get; set; }

  [JsonProperty("RatingBasisDate")]
  public string RatingBasisDate { get; set; }

  [JsonProperty("Company")]
  public string Company { get; set; }

  [JsonProperty("CompanyCode")]
  public string CompanyCode { get; set; }

  [JsonProperty("ProgramCode")]
  public string ProgramCode { get; set; }

  [JsonProperty("ProgramName")]
  public string ProgramName { get; set; }

  [JsonProperty("OriginalEffectiveDate")]
  public string OriginalEffectiveDate { get; set; }

  [JsonProperty("AgencyUpdateCode")]
  public string AgencyUpdateCode { get; set; }

  [JsonProperty("Location")]
  public ICollection<NetRate_Location> Location { get; set; }

  [JsonProperty("LiabilityLimits")]
  public NetRate_LiabilityLimits LiabilityLimits { get; set; }

  [JsonProperty("UnitNumber")]
  public string UnitNumber { get; set; }

  [JsonProperty("TypeOfBusiness")]
  public string TypeOfBusiness { get; set; }

  [JsonProperty("LegalEntity")]
  public string LegalEntity { get; set; }

  [JsonProperty("Terrorism")]
  public string Terrorism { get; set; }

  [JsonProperty("PolicyTotals")]
  public NetRate_PolicyTotals PolicyTotals { get; set; }

  [JsonProperty("Description")]
  public string Description { get; set; }

  [JsonProperty("BusinessAutoPolicyLimits")]
  public NetRate_BusinessAutoPolicyLimits BusinessAutoPolicyLimits { get; set; }
}
