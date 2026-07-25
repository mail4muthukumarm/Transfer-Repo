// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedACHField
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedACHField
{
  [JsonProperty("AddendaTypeCode")]
  public string AddendaTypeCode { get; set; }

  [JsonProperty("Contested")]
  public bool? Contested { get; set; }

  [JsonProperty("Dishonored")]
  public bool? Dishonored { get; set; }

  [JsonProperty("Field")]
  public int? Field { get; set; }

  [JsonProperty("RecordTypeCode")]
  public int? RecordTypeCode { get; set; }

  [JsonProperty("Refused")]
  public bool? Refused { get; set; }

  [JsonProperty("Value")]
  public string Value { get; set; }
}
