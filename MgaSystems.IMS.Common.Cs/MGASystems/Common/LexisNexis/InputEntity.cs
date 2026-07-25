// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.InputEntity
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
public class InputEntity
{
  [JsonProperty("Account")]
  public InputAccount Account { get; set; }

  [JsonProperty("AdditionalInfo")]
  public ICollection<InputAdditionalInfo> AdditionalInfo { get; set; }

  [JsonProperty("Addresses")]
  public ICollection<InputAddress> Addresses { get; set; }

  [JsonConverter(typeof (BridgerEnumConverter))]
  [JsonProperty("EntityType")]
  public InputEntityEntityType? EntityType { get; set; }

  [JsonProperty("Gender")]
  [JsonConverter(typeof (StringEnumConverter))]
  public InputEntityGender? Gender { get; set; }

  [JsonProperty("IDs")]
  public ICollection<InputID> IDs { get; set; }

  [JsonProperty("Name")]
  public InputName Name { get; set; }

  [JsonProperty("Phones")]
  public ICollection<InputPhone> Phones { get; set; }
}
