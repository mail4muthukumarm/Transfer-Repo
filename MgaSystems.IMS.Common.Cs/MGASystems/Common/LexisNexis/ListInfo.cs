// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ListInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ListInfo
{
  [JsonProperty("AccountNumbersUniqueIDs")]
  public bool? AccountNumbersUniqueIDs { get; set; }

  [JsonProperty("AutoIndex")]
  public bool? AutoIndex { get; set; }

  [JsonProperty("Comments")]
  public string Comments { get; set; }

  [JsonProperty("Description")]
  public string Description { get; set; }

  [JsonProperty("Divisions")]
  public ICollection<string> Divisions { get; set; }

  [JsonProperty("Encrypt")]
  public bool? Encrypt { get; set; }

  [JsonProperty("EntityUniqueIDType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ListInfoEntityUniqueIDType? EntityUniqueIDType { get; set; }

  [JsonProperty("ID")]
  public long? ID { get; set; }

  [JsonProperty("Name")]
  public string Name { get; set; }

  [JsonProperty("Publication")]
  public DateTimeOffset? Publication { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ListInfoType? Type { get; set; }

  [JsonProperty("UniqueID")]
  public Guid? UniqueID { get; set; }

  [JsonProperty("UserSelectedStatusRequired")]
  public bool? UserSelectedStatusRequired { get; set; }
}
