// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedACHAddress
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedACHAddress
{
  [JsonProperty("City")]
  public string City { get; set; }

  [JsonProperty("CityField")]
  public int? CityField { get; set; }

  [JsonProperty("CityRecordTypeCode")]
  public int? CityRecordTypeCode { get; set; }

  [JsonProperty("CityStateProvince")]
  public string CityStateProvince { get; set; }

  [JsonProperty("CSPField")]
  public int? CSPField { get; set; }

  [JsonProperty("CSPRecordTypeCode")]
  public int? CSPRecordTypeCode { get; set; }

  [JsonProperty("Country")]
  public string Country { get; set; }

  [JsonProperty("CountryField")]
  public int? CountryField { get; set; }

  [JsonProperty("CountryRecordTypeCode")]
  public int? CountryRecordTypeCode { get; set; }

  [JsonProperty("CountryPostalCode")]
  public string CountryPostalCode { get; set; }

  [JsonProperty("CPCField")]
  public int? CPCField { get; set; }

  [JsonProperty("CPCRecordTypeCode")]
  public int? CPCRecordTypeCode { get; set; }

  [JsonProperty("Field")]
  public int? Field { get; set; }

  [JsonProperty("PostalCode")]
  public string PostalCode { get; set; }

  [JsonProperty("PostalCodeField")]
  public int? PostalCodeField { get; set; }

  [JsonProperty("PostalCodeRecordTypeCode")]
  public int? PostalCodeRecordTypeCode { get; set; }

  [JsonProperty("RecordTypeCode")]
  public int? RecordTypeCode { get; set; }

  [JsonProperty("StateProvince")]
  public string StateProvince { get; set; }

  [JsonProperty("StateProvinceField")]
  public int? StateProvinceField { get; set; }

  [JsonProperty("StateProvinceRecordTypeCode")]
  public int? StateProvinceRecordTypeCode { get; set; }

  [JsonProperty("StreetAddress")]
  public string StreetAddress { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ParsedACHAddressType? Type { get; set; }
}
