// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedSWIFTParty
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedSWIFTParty
{
  [JsonProperty("AdditionalInfo")]
  public ICollection<ParsedSWIFTAdditionalInfo> AdditionalInfo { get; set; }

  [JsonProperty("Addresses")]
  public ICollection<ParsedSWIFTAddress> Addresses { get; set; }

  [JsonProperty("IDs")]
  public ICollection<ParsedSWIFTID> IDs { get; set; }

  [JsonProperty("Name")]
  public string Name { get; set; }

  [JsonProperty("Qualifier")]
  public string Qualifier { get; set; }

  [JsonProperty("SubSequence")]
  public string SubSequence { get; set; }

  [JsonProperty("Sequence")]
  public string Sequence { get; set; }

  [JsonProperty("Tag")]
  public string Tag { get; set; }

  [JsonProperty("Type")]
  public string Type { get; set; }
}
