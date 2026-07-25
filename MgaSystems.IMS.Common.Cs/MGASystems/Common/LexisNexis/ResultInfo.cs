// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ResultInfo
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
public class ResultInfo
{
  [JsonProperty("NewAlertState")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultInfoNewAlertState? NewAlertState { get; set; }

  [JsonProperty("NewMatchStates")]
  public ICollection<WatchlistMatchState> NewMatchStates { get; set; }

  [JsonProperty("NewStatus")]
  public string NewStatus { get; set; }

  [JsonProperty("Note")]
  public string Note { get; set; }

  [JsonProperty("Record")]
  public ResultRecord Record { get; set; }

  [JsonProperty("ResultID")]
  public long? ResultID { get; set; }
}
