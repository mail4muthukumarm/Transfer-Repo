// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedISO20022
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedISO20022
{
  [JsonProperty("Fields")]
  public ICollection<ParsedISO20022Field> Fields { get; set; }

  [JsonProperty("Notes")]
  public ICollection<ParsedISO20022Note> Notes { get; set; }

  [JsonProperty("Parties")]
  public ICollection<ParsedISO20022Party> Parties { get; set; }
}
