// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedFedwireAddress
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedFedwireAddress
{
  [JsonProperty("AddressLine1")]
  public string AddressLine1 { get; set; }

  [JsonProperty("AddressLine1Element")]
  public int? AddressLine1Element { get; set; }

  [JsonProperty("AddressLine2")]
  public string AddressLine2 { get; set; }

  [JsonProperty("AddressLine2Element")]
  public int? AddressLine2Element { get; set; }

  [JsonProperty("AddressLine3")]
  public string AddressLine3 { get; set; }

  [JsonProperty("AddressLine3Element")]
  public int? AddressLine3Element { get; set; }

  [JsonProperty("AddressLine4")]
  public string AddressLine4 { get; set; }

  [JsonProperty("AddressLine4Element")]
  public int? AddressLine4Element { get; set; }

  [JsonProperty("AddressLine5")]
  public string AddressLine5 { get; set; }

  [JsonProperty("AddressLine5Element")]
  public int? AddressLine5Element { get; set; }

  [JsonProperty("AddressLine6")]
  public string AddressLine6 { get; set; }

  [JsonProperty("AddressLine6Element")]
  public int? AddressLine6Element { get; set; }

  [JsonProperty("AddressLine7")]
  public string AddressLine7 { get; set; }

  [JsonProperty("AddressLine7Element")]
  public int? AddressLine7Element { get; set; }

  [JsonProperty("BuildingNumber")]
  public string BuildingNumber { get; set; }

  [JsonProperty("BuildingNumberElement")]
  public int? BuildingNumberElement { get; set; }

  [JsonProperty("City")]
  public string City { get; set; }

  [JsonProperty("CityElement")]
  public int? CityElement { get; set; }

  [JsonProperty("Country")]
  public string Country { get; set; }

  [JsonProperty("CountryElement")]
  public int? CountryElement { get; set; }

  [JsonProperty("Department")]
  public string Department { get; set; }

  [JsonProperty("DepartmentElement")]
  public int? DepartmentElement { get; set; }

  [JsonProperty("PostalCode")]
  public string PostalCode { get; set; }

  [JsonProperty("PostalCodeElement")]
  public int? PostalCodeElement { get; set; }

  [JsonProperty("StateProvince")]
  public string StateProvince { get; set; }

  [JsonProperty("StateProvinceElement")]
  public int? StateProvinceElement { get; set; }

  [JsonProperty("StreetName")]
  public string StreetName { get; set; }

  [JsonProperty("StreetNameElement")]
  public int? StreetNameElement { get; set; }

  [JsonProperty("SubDepartment")]
  public string SubDepartment { get; set; }

  [JsonProperty("SubDepartmentElement")]
  public int? SubDepartmentElement { get; set; }

  [JsonProperty("Tag")]
  public string Tag { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ParsedFedwireAddressType? Type { get; set; }
}
