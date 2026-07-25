// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WLEntityDetails
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
public class WLEntityDetails
{
  [JsonProperty("AdditionalInfo")]
  public ICollection<EntityAdditionalInfo> AdditionalInfo { get; set; }

  [JsonProperty("Addresses")]
  public ICollection<EntityAddress> Addresses { get; set; }

  [JsonProperty("AKAs")]
  public ICollection<EntityAKA> AKAs { get; set; }

  [JsonProperty("Comments")]
  public string Comments { get; set; }

  [JsonProperty("DateListed")]
  public string DateListed { get; set; }

  [JsonProperty("EntityType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public WLEntityDetailsEntityType? EntityType { get; set; }

  [JsonProperty("Gender")]
  public string Gender { get; set; }

  [JsonProperty("IDs")]
  public ICollection<EntityID> IDs { get; set; }

  [JsonProperty("ListReferenceNumber")]
  public string ListReferenceNumber { get; set; }

  [JsonProperty("Name")]
  public EntityName Name { get; set; }

  [JsonProperty("Phones")]
  public ICollection<EntityPhone> Phones { get; set; }

  [JsonProperty("ReasonListed")]
  public string ReasonListed { get; set; }
}
