// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedSWIFTNote
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedSWIFTNote
{
  [JsonProperty("AdditionalTextSearch")]
  public bool? AdditionalTextSearch { get; set; }

  [JsonProperty("Note")]
  public string Note { get; set; }

  [JsonProperty("Qualifier")]
  public string Qualifier { get; set; }

  [JsonProperty("SubSequence")]
  public string SubSequence { get; set; }

  [JsonProperty("Sequence")]
  public string Sequence { get; set; }

  [JsonProperty("Tag")]
  public string Tag { get; set; }
}
