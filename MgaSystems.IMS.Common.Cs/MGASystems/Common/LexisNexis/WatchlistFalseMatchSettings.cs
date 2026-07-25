// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WatchlistFalseMatchSettings
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class WatchlistFalseMatchSettings
{
  [JsonProperty("Name")]
  public bool? Name { get; set; }

  [JsonProperty("Dob")]
  public bool? Dob { get; set; }

  [JsonProperty("Gender")]
  public bool? Gender { get; set; }

  [JsonProperty("Aka")]
  public bool? Aka { get; set; }

  [JsonProperty("IdNumbers")]
  public bool? IdNumbers { get; set; }

  [JsonProperty("Address")]
  public bool? Address { get; set; }

  [JsonProperty("Phone")]
  public bool? Phone { get; set; }

  [JsonProperty("Citizenship")]
  public bool? Citizenship { get; set; }

  [JsonProperty("GenerateFalseMatchUpdate")]
  public bool? GenerateFalseMatchUpdate { get; set; }
}
