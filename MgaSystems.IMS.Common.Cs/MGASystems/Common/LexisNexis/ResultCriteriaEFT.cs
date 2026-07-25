// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ResultCriteriaEFT
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ResultCriteriaEFT
{
  [JsonProperty("DollarAmount")]
  public string DollarAmount { get; set; }

  [JsonProperty("DollarAmountComparison")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultCriteriaEFTDollarAmountComparison? DollarAmountComparison { get; set; }

  [JsonProperty("DUNS")]
  public string DUNS { get; set; }

  [JsonProperty("ExternalOFACIndicator")]
  public bool? ExternalOFACIndicator { get; set; }

  [JsonProperty("TransactionID")]
  public string TransactionID { get; set; }

  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultCriteriaEFTType? Type { get; set; }
}
