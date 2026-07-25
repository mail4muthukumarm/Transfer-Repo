// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.RecordState
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
public class RecordState
{
  [JsonProperty("AddedToAcceptList")]
  public bool? AddedToAcceptList { get; set; }

  [JsonProperty("AlertState")]
  [JsonConverter(typeof (StringEnumConverter))]
  public RecordStateAlertState? AlertState { get; set; }

  [JsonProperty("AssignedTo")]
  public ICollection<string> AssignedTo { get; set; }

  [JsonProperty("AssignmentType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public RecordStateAssignmentType? AssignmentType { get; set; }

  [JsonProperty("Division")]
  public string Division { get; set; }

  [JsonProperty("History")]
  public ICollection<AuditItem> History { get; set; }

  [JsonProperty("MatchStates")]
  public ICollection<WatchlistMatchState> MatchStates { get; set; }

  [JsonProperty("Note")]
  public string Note { get; set; }

  [JsonProperty("Status")]
  public string Status { get; set; }
}
