// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedISO20022AdditionalInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedISO20022AdditionalInfo
{
  [JsonProperty("CountryOfBirth")]
  public string CountryOfBirth { get; set; }

  [JsonProperty("CountryOfBirthXPath")]
  public string CountryOfBirthXPath { get; set; }

  [JsonProperty("Info")]
  public string Info { get; set; }

  [JsonProperty("ParsedInfo")]
  public string ParsedInfo { get; set; }

  [JsonProperty("ProvinceOfBirth")]
  public string ProvinceOfBirth { get; set; }

  [JsonProperty("ProvinceOfBirthXPath")]
  public string ProvinceOfBirthXPath { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ParsedISO20022AdditionalInfoType? Type { get; set; }

  [JsonProperty("XPath")]
  public string XPath { get; set; }
}
