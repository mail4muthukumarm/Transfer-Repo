// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WatchlistAutomaticFalsePositiveRules
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class WatchlistAutomaticFalsePositiveRules
{
  [JsonProperty("Addresses")]
  public bool? Addresses { get; set; }

  [JsonProperty("Citizenship")]
  public bool? Citizenship { get; set; }

  [JsonProperty("Countries")]
  public bool? Countries { get; set; }

  [JsonProperty("DisplayAFPMatches")]
  public bool? DisplayAFPMatches { get; set; }

  [JsonProperty("DOB")]
  public bool? DOB { get; set; }

  [JsonProperty("DOBTolerance")]
  public int? DOBTolerance { get; set; }

  [JsonProperty("EntityType")]
  public bool? EntityType { get; set; }

  [JsonProperty("Gender")]
  public bool? Gender { get; set; }

  [JsonProperty("GenerateResultRecord")]
  public bool? GenerateResultRecord { get; set; }

  [JsonProperty("IDs")]
  public bool? IDs { get; set; }

  [JsonProperty("Phones")]
  public bool? Phones { get; set; }

  [JsonProperty("ShowResultAsAlert")]
  public bool? ShowResultAsAlert { get; set; }

  [JsonProperty("WhiteList")]
  public bool? WhiteList { get; set; }
}
