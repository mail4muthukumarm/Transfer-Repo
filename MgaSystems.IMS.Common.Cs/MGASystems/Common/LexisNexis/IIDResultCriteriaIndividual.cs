// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.IIDResultCriteriaIndividual
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
public class IIDResultCriteriaIndividual
{
  [JsonProperty("IndexEnd")]
  [JsonConverter(typeof (StringEnumConverter))]
  public IIDResultCriteriaIndividualIndexEnd? IndexEnd { get; set; }

  [JsonProperty("IndexStart")]
  [JsonConverter(typeof (StringEnumConverter))]
  public IIDResultCriteriaIndividualIndexStart? IndexStart { get; set; }

  [JsonProperty("NAPCriteria")]
  public int? NAPCriteria { get; set; }

  [JsonProperty("NASCriteria")]
  public int? NASCriteria { get; set; }

  [JsonProperty("RedFlags")]
  public ICollection<IIDResultCriteriaRedFlag> RedFlags { get; set; }

  [JsonProperty("RiskIndicators")]
  public ICollection<int> RiskIndicators { get; set; }
}
