// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.EntityID
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class EntityID
{
  [JsonProperty("Comments")]
  public string Comments { get; set; }

  [JsonProperty("DateExpires")]
  public Date DateExpires { get; set; }

  [JsonProperty("DateIssued")]
  public Date DateIssued { get; set; }

  [JsonProperty("ID")]
  public long? ID { get; set; }

  [JsonProperty("Issuer")]
  public string Issuer { get; set; }

  [JsonProperty("Label")]
  public string Label { get; set; }

  [JsonProperty("Number")]
  public string Number { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public EntityIDType? Type { get; set; }
}
