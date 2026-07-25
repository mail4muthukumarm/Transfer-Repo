// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedFedwireParty
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
public class ParsedFedwireParty
{
  [JsonProperty("AdditionalInfo")]
  public ICollection<ParsedFedwireAdditionalInfo> AdditionalInfo { get; set; }

  [JsonProperty("Addresses")]
  public ICollection<ParsedFedwireAddress> Addresses { get; set; }

  [JsonProperty("Element")]
  public int? Element { get; set; }

  [JsonProperty("EntityType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ParsedFedwirePartyEntityType? EntityType { get; set; }

  [JsonProperty("Fields")]
  public ICollection<ParsedFedwireNote> Fields { get; set; }

  [JsonProperty("IDs")]
  public ICollection<ParsedFedwireID> IDs { get; set; }

  [JsonProperty("Name")]
  public string Name { get; set; }

  [JsonProperty("Phones")]
  public ICollection<ParsedFedwirePhone> Phones { get; set; }

  [JsonProperty("Tag")]
  public string Tag { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ParsedFedwirePartyType? Type { get; set; }
}
