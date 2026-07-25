// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.EntityName
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class EntityName
{
  [JsonProperty("First")]
  public string First { get; set; }

  [JsonProperty("Full")]
  public string Full { get; set; }

  [JsonProperty("Generation")]
  public string Generation { get; set; }

  [JsonProperty("Last")]
  public string Last { get; set; }

  [JsonProperty("Middle")]
  public string Middle { get; set; }

  [JsonProperty("Title")]
  public string Title { get; set; }
}
