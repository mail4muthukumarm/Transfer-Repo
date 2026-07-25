// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.RunInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class RunInfo
{
  [JsonProperty("AlertCount")]
  public int? AlertCount { get; set; }

  [JsonProperty("Division")]
  public string Division { get; set; }

  [JsonProperty("DivisionID")]
  public int? DivisionID { get; set; }

  [JsonProperty("DPPA")]
  [JsonConverter(typeof (StringEnumConverter))]
  public RunInfoDPPA? DPPA { get; set; }

  [JsonProperty("EFTType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public RunInfoEFTType? EFTType { get; set; }

  [JsonProperty("EntityType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public RunInfoEntityType? EntityType { get; set; }

  [JsonProperty("ErrorCount")]
  public int? ErrorCount { get; set; }

  [JsonProperty("ErrorMessage")]
  public string ErrorMessage { get; set; }

  [JsonProperty("FileName")]
  public string FileName { get; set; }

  [JsonProperty("FileFormatName")]
  public string FileFormatName { get; set; }

  [JsonProperty("GLB")]
  public int? GLB { get; set; }

  [JsonProperty("LastUpdateTime")]
  public DateTimeOffset? LastUpdateTime { get; set; }

  [JsonProperty("NumRecordsProcessed")]
  public int? NumRecordsProcessed { get; set; }

  [JsonProperty("PredefinedSearchName")]
  public string PredefinedSearchName { get; set; }

  [JsonProperty("ProcessingState")]
  [JsonConverter(typeof (StringEnumConverter))]
  public RunInfoProcessingState? ProcessingState { get; set; }

  [JsonProperty("ResultsFile1")]
  public string ResultsFile1 { get; set; }

  [JsonProperty("ResultsFile2")]
  public string ResultsFile2 { get; set; }

  [JsonProperty("RunID")]
  public long? RunID { get; set; }

  [JsonProperty("StartTime")]
  public DateTimeOffset? StartTime { get; set; }

  [JsonProperty("SubmitType")]
  public string SubmitType { get; set; }

  [JsonProperty("TotalNumRecords")]
  public int? TotalNumRecords { get; set; }

  [JsonProperty("TotalNumRows")]
  public int? TotalNumRows { get; set; }

  [JsonProperty("UserName")]
  public string UserName { get; set; }

  [JsonProperty("WLMatchCount")]
  public int? WLMatchCount { get; set; }
}
