// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedISO20022Address
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedISO20022Address
{
  [JsonProperty("AddrType")]
  public string AddrType { get; set; }

  [JsonProperty("AddrTypeXPath")]
  public string AddrTypeXPath { get; set; }

  [JsonProperty("BuildingName")]
  public string BuildingName { get; set; }

  [JsonProperty("BuildingNameXpath")]
  public string BuildingNameXpath { get; set; }

  [JsonProperty("BuildingNumber")]
  public string BuildingNumber { get; set; }

  [JsonProperty("BuildingNumberXPath")]
  public string BuildingNumberXPath { get; set; }

  [JsonProperty("City")]
  public string City { get; set; }

  [JsonProperty("CityXPath")]
  public string CityXPath { get; set; }

  [JsonProperty("Country")]
  public string Country { get; set; }

  [JsonProperty("CountryXPath")]
  public string CountryXPath { get; set; }

  [JsonProperty("Department")]
  public string Department { get; set; }

  [JsonProperty("DepartmentXPath")]
  public string DepartmentXPath { get; set; }

  [JsonProperty("DistrictName")]
  public string DistrictName { get; set; }

  [JsonProperty("DistrictNameXpath")]
  public string DistrictNameXpath { get; set; }

  [JsonProperty("Floor")]
  public string Floor { get; set; }

  [JsonProperty("FloorXPath")]
  public string FloorXPath { get; set; }

  [JsonProperty("Lines")]
  public ICollection<string> Lines { get; set; }

  [JsonProperty("LineXPaths")]
  public ICollection<string> LineXPaths { get; set; }

  [JsonProperty("PostalCode")]
  public string PostalCode { get; set; }

  [JsonProperty("PostalCodeXPath")]
  public string PostalCodeXPath { get; set; }

  [JsonProperty("PostBox")]
  public string PostBox { get; set; }

  [JsonProperty("PostBoxXpath")]
  public string PostBoxXpath { get; set; }

  [JsonProperty("Room")]
  public string Room { get; set; }

  [JsonProperty("RoomXPath")]
  public string RoomXPath { get; set; }

  [JsonProperty("StateProvince")]
  public string StateProvince { get; set; }

  [JsonProperty("StateProvinceXPath")]
  public string StateProvinceXPath { get; set; }

  [JsonProperty("StreetName")]
  public string StreetName { get; set; }

  [JsonProperty("StreetNameXPath")]
  public string StreetNameXPath { get; set; }

  [JsonProperty("SubDepartment")]
  public string SubDepartment { get; set; }

  [JsonProperty("SubDepartmentXPath")]
  public string SubDepartmentXPath { get; set; }

  [JsonProperty("TownLocationName")]
  public string TownLocationName { get; set; }

  [JsonProperty("TownLocationNameXpath")]
  public string TownLocationNameXpath { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ParsedISO20022AddressType? Type { get; set; }
}
