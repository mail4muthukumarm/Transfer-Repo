// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WLCountryDetails
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class WLCountryDetails
{
  [JsonProperty("AKAs")]
  public ICollection<string> AKAs { get; set; }

  [JsonProperty("Cities")]
  public ICollection<string> Cities { get; set; }

  [JsonProperty("Codes")]
  public ICollection<string> Codes { get; set; }

  [JsonProperty("Comments")]
  public string Comments { get; set; }

  [JsonProperty("Country")]
  public string Country { get; set; }

  [JsonProperty("DateListed")]
  public string DateListed { get; set; }

  [JsonProperty("ListReferenceNumber")]
  public string ListReferenceNumber { get; set; }

  [JsonProperty("Ports")]
  public ICollection<string> Ports { get; set; }

  [JsonProperty("ReasonListed")]
  public string ReasonListed { get; set; }

  [JsonProperty("Terms")]
  public ICollection<string> Terms { get; set; }
}
