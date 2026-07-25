// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.RunsCriteria
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class RunsCriteria
{
  [JsonProperty("DateEnd")]
  public Date DateEnd { get; set; }

  [JsonProperty("DateStart")]
  public Date DateStart { get; set; }

  [JsonProperty("EFTType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public RunsCriteriaEFTType? EFTType { get; set; }

  [JsonProperty("EntityType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public RunsCriteriaEntityType? EntityType { get; set; }

  [JsonProperty("FileName")]
  public string FileName { get; set; }

  [JsonProperty("PredefinedSearch")]
  public string PredefinedSearch { get; set; }

  [JsonProperty("ProcessingState")]
  [JsonConverter(typeof (StringEnumConverter))]
  public RunsCriteriaProcessingState? ProcessingState { get; set; }

  [JsonProperty("SubmitType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public RunsCriteriaSubmitType? SubmitType { get; set; }
}
