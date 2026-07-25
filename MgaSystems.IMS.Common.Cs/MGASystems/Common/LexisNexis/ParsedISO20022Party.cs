// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedISO20022Party
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
public class ParsedISO20022Party
{
  [JsonProperty("AdditionalInfo")]
  public ICollection<ParsedISO20022AdditionalInfo> AdditionalInfo { get; set; }

  [JsonProperty("Addresses")]
  public ICollection<ParsedISO20022Address> Addresses { get; set; }

  [JsonProperty("EntityType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ParsedISO20022PartyEntityType? EntityType { get; set; }

  [JsonProperty("IDs")]
  public ICollection<ParsedISO20022ID> IDs { get; set; }

  [JsonProperty("Name")]
  public string Name { get; set; }

  [JsonProperty("Notes")]
  public ICollection<ParsedISO20022Note> Notes { get; set; }

  [JsonProperty("Phones")]
  public ICollection<ParsedISO20022Phone> Phones { get; set; }

  [JsonProperty("Title")]
  public string Title { get; set; }

  [JsonProperty("TitleXPath")]
  public string TitleXPath { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ParsedISO20022PartyType? Type { get; set; }

  [JsonProperty("XPath")]
  public string XPath { get; set; }
}
