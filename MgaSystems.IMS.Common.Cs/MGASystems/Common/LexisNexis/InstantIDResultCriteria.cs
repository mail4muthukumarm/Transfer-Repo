// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.InstantIDResultCriteria
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class InstantIDResultCriteria
{
  [JsonProperty("Business")]
  public IIDResultCriteriaBusiness Business { get; set; }

  [JsonProperty("ErrorText")]
  public string ErrorText { get; set; }

  [JsonProperty("Individual")]
  public IIDResultCriteriaIndividual Individual { get; set; }

  [JsonProperty("ProviderErrorsOnly")]
  public bool? ProviderErrorsOnly { get; set; }
}
