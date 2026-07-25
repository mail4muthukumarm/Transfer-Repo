// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedACHNote
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedACHNote
{
  [JsonProperty("AdditionalTextSearch")]
  public bool? AdditionalTextSearch { get; set; }

  [JsonProperty("EDITRNDataSegmentIdentifier")]
  public string EDITRNDataSegmentIdentifier { get; set; }

  [JsonProperty("Field")]
  public int? Field { get; set; }

  [JsonProperty("IDField")]
  public int? IDField { get; set; }

  [JsonProperty("IDRecordTypeCode")]
  public int? IDRecordTypeCode { get; set; }

  [JsonProperty("Note")]
  public string Note { get; set; }

  [JsonProperty("OriginalReceivingDFIIdentification")]
  public string OriginalReceivingDFIIdentification { get; set; }

  [JsonProperty("OriginatingCompanyID")]
  public string OriginatingCompanyID { get; set; }

  [JsonProperty("RecordTypeCode")]
  public int? RecordTypeCode { get; set; }

  [JsonProperty("ReferenceID1")]
  public string ReferenceID1 { get; set; }

  [JsonProperty("ReferenceID2")]
  public string ReferenceID2 { get; set; }

  [JsonProperty("SequenceNumber")]
  public string SequenceNumber { get; set; }

  [JsonProperty("TraceTypeCode")]
  public string TraceTypeCode { get; set; }

  [JsonProperty("TypeCode")]
  public string TypeCode { get; set; }
}
