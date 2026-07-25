// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.OFACReportInfo
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
public class OFACReportInfo
{
  [JsonProperty("ActionDate")]
  public string ActionDate { get; set; }

  [JsonProperty("AdditionalData")]
  public string AdditionalData { get; set; }

  [JsonProperty("AdditionalRelevantInfo")]
  public string AdditionalRelevantInfo { get; set; }

  [JsonProperty("Amount")]
  public string Amount { get; set; }

  [JsonProperty("Institutions")]
  public ICollection<OFACInstitutionInfo> Institutions { get; set; }

  [JsonProperty("NameOfSigner")]
  public string NameOfSigner { get; set; }

  [JsonProperty("PreparerDate")]
  public string PreparerDate { get; set; }

  [JsonProperty("Reason")]
  public string Reason { get; set; }

  [JsonProperty("ReportType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public OFACReportInfoReportType? ReportType { get; set; }

  [JsonProperty("TitleOfSigner")]
  public string TitleOfSigner { get; set; }

  [JsonProperty("TransactionDate")]
  public string TransactionDate { get; set; }
}
