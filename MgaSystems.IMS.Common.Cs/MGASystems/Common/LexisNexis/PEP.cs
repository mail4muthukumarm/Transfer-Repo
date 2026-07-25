// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.PEP
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class PEP
{
  [JsonProperty("Country")]
  public string Country { get; set; }

  [JsonProperty("Source")]
  public string Source { get; set; }

  [JsonProperty("AdminUnit1")]
  public string AdminUnit1 { get; set; }

  [JsonProperty("AdminUnit2")]
  public string AdminUnit2 { get; set; }

  [JsonProperty("AdminUnit3")]
  public string AdminUnit3 { get; set; }

  [JsonProperty("AdminUnit4")]
  public string AdminUnit4 { get; set; }

  [JsonProperty("SubCategories")]
  public ICollection<string> SubCategories { get; set; }

  [JsonProperty("AdminLevel")]
  public string AdminLevel { get; set; }

  [JsonProperty("DateModified")]
  public DateTimeOffset? DateModified { get; set; }

  [JsonProperty("Status")]
  [JsonConverter(typeof (StringEnumConverter))]
  public PEPStatus? Status { get; set; }

  [JsonProperty("IsPrimary")]
  public bool? IsPrimary { get; set; }

  [JsonProperty("CountryRole")]
  [JsonConverter(typeof (StringEnumConverter))]
  public PEPCountryRole? CountryRole { get; set; }

  [JsonProperty("GoverningInstitution")]
  public string GoverningInstitution { get; set; }

  [JsonProperty("GoverningRole")]
  public string GoverningRole { get; set; }

  [JsonProperty("EffectiveDateType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public PEPEffectiveDateType? EffectiveDateType { get; set; }

  [JsonProperty("EffectiveDate")]
  public string EffectiveDate { get; set; }

  [JsonProperty("ExpirationDateType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public PEPExpirationDateType? ExpirationDateType { get; set; }

  [JsonProperty("ExpirationDate")]
  public string ExpirationDate { get; set; }
}
