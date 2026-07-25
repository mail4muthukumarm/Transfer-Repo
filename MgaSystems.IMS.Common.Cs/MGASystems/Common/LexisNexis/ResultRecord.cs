// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ResultRecord
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ResultRecord
{
  [JsonProperty("AttachmentIDs")]
  public ICollection<long> AttachmentIDs { get; set; }

  [JsonProperty("FraudPoint")]
  public FraudPointResults FraudPoint { get; set; }

  [JsonProperty("InstantIDBusiness")]
  public InstantIDBusinessResults InstantIDBusiness { get; set; }

  [JsonProperty("InstantIDIndividual")]
  public InstantIDIndividualResults InstantIDIndividual { get; set; }

  [JsonProperty("InstantIDIntlIndividual")]
  public InstantIDIntlIndividualResults InstantIDIntlIndividual { get; set; }

  [JsonProperty("Record")]
  public long? Record { get; set; }

  [JsonProperty("RecordDetails")]
  public ResultRecordDetails RecordDetails { get; set; }

  [JsonProperty("ResultID")]
  public long? ResultID { get; set; }

  [JsonProperty("RunID")]
  public long? RunID { get; set; }

  [JsonProperty("Watchlist")]
  public WatchlistResults Watchlist { get; set; }

  [JsonProperty("HasScreeningListMatches")]
  public bool? HasScreeningListMatches { get; set; }

  [JsonProperty("RecordStatus")]
  public string RecordStatus { get; set; }

  [JsonProperty("EFTID")]
  public string EFTID { get; set; }
}
