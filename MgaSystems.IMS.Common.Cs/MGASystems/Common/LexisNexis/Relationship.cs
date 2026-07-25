// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.Relationship
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class Relationship
{
  [JsonProperty("Group")]
  public string Group { get; set; }

  [JsonProperty("Source")]
  public string Source { get; set; }

  [JsonProperty("Type")]
  public string Type { get; set; }

  [JsonProperty("SubCategories")]
  public ICollection<string> SubCategories { get; set; }

  [JsonProperty("EntityId")]
  public int? EntityId { get; set; }

  [JsonProperty("DateModified")]
  public DateTimeOffset? DateModified { get; set; }

  [JsonProperty("EntityName")]
  public string EntityName { get; set; }

  [JsonProperty("OwnershipPercentage")]
  public double? OwnershipPercentage { get; set; }

  [JsonProperty("Segments")]
  public string Segments { get; set; }
}
