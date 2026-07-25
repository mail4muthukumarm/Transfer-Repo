// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ResultCriteriaRecordState
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
public class ResultCriteriaRecordState
{
  [JsonProperty("AlertAge")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultCriteriaRecordStateAlertAge? AlertAge { get; set; }

  [JsonProperty("AlertState")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultCriteriaRecordStateAlertState? AlertState { get; set; }

  [JsonProperty("AnyErrors")]
  public bool? AnyErrors { get; set; }

  [JsonProperty("AssignedTo")]
  public string AssignedTo { get; set; }

  [JsonProperty("AssignmentType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultCriteriaRecordStateAssignmentType? AssignmentType { get; set; }

  [JsonProperty("CurrentStatus")]
  public string CurrentStatus { get; set; }

  [JsonProperty("Divisions")]
  public ICollection<string> Divisions { get; set; }

  [JsonProperty("DateStateAssignedEnd")]
  public Date DateStateAssignedEnd { get; set; }

  [JsonProperty("DateStateAssignedStart")]
  public Date DateStateAssignedStart { get; set; }

  [JsonProperty("DateStatusAssignedEnd")]
  public Date DateStatusAssignedEnd { get; set; }

  [JsonProperty("DateStatusAssignedStart")]
  public Date DateStatusAssignedStart { get; set; }

  [JsonProperty("GeneralSearchErrorsOnly")]
  public bool? GeneralSearchErrorsOnly { get; set; }

  [JsonProperty("PredefinedSearch")]
  public string PredefinedSearch { get; set; }

  [JsonProperty("RecordChangedBy")]
  public string RecordChangedBy { get; set; }

  [JsonProperty("RecordHasAttachments")]
  public bool? RecordHasAttachments { get; set; }

  [JsonProperty("ResultsWithoutDivision")]
  public bool? ResultsWithoutDivision { get; set; }

  [JsonProperty("ResultsWithoutStatus")]
  public bool? ResultsWithoutStatus { get; set; }

  [JsonProperty("StatusHistory")]
  public string StatusHistory { get; set; }
}
