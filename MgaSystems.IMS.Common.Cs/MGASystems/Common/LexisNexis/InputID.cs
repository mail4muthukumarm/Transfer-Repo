// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.InputID
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class InputID
{
  [JsonProperty("DateExpires")]
  public Date DateExpires { get; set; }

  [JsonProperty("DateIssued")]
  public Date DateIssued { get; set; }

  [JsonProperty("Issuer")]
  public string Issuer { get; set; }

  [JsonProperty("Label")]
  public string Label { get; set; }

  [JsonProperty("MachineReadableLine1")]
  public string MachineReadableLine1 { get; set; }

  [JsonProperty("MachineReadableLine2")]
  public string MachineReadableLine2 { get; set; }

  [JsonProperty("Number")]
  public string Number { get; set; }

  [JsonProperty("PlaceOfBirth")]
  public string PlaceOfBirth { get; set; }

  [JsonProperty("CountryOfBirth")]
  public string CountryOfBirth { get; set; }

  [JsonProperty("FamilyNameAtBirth")]
  public string FamilyNameAtBirth { get; set; }

  [JsonProperty("FamilyNameAtCitizenship")]
  public string FamilyNameAtCitizenship { get; set; }

  [JsonProperty("CityOfIssue")]
  public string CityOfIssue { get; set; }

  [JsonProperty("CountyOfIssue")]
  public string CountyOfIssue { get; set; }

  [JsonProperty("DistrictOfIssue")]
  public string DistrictOfIssue { get; set; }

  [JsonProperty("ProvinceOfIssue")]
  public string ProvinceOfIssue { get; set; }

  [JsonProperty("StateOfBirth")]
  public string StateOfBirth { get; set; }

  [JsonProperty("DriverLicenceVersionNumber")]
  public string DriverLicenceVersionNumber { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public InputIDType? Type { get; set; }

  [JsonProperty("AccountType")]
  public string AccountType { get; set; }
}
