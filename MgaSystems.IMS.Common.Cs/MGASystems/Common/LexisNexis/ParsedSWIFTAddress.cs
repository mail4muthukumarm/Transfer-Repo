// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedSWIFTAddress
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedSWIFTAddress
{
  [JsonProperty("AddressLine1")]
  public string AddressLine1 { get; set; }

  [JsonProperty("AddressLine2")]
  public string AddressLine2 { get; set; }

  [JsonProperty("AddressLine3")]
  public string AddressLine3 { get; set; }

  [JsonProperty("AddressLine4")]
  public string AddressLine4 { get; set; }

  [JsonProperty("City")]
  public string City { get; set; }

  [JsonProperty("Country")]
  public string Country { get; set; }

  [JsonProperty("StateProvince")]
  public string StateProvince { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ParsedSWIFTAddressType? Type { get; set; }
}
