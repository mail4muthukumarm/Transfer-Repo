// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ResultsCriteria
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
public class ResultsCriteria
{
  [JsonProperty("Account")]
  public ResultCriteriaAccount Account { get; set; }

  [JsonProperty("AdditionalInfo")]
  public EntityCriteriaAdditionalInfo AdditionalInfo { get; set; }

  [JsonProperty("Address")]
  public EntityCriteriaAddress Address { get; set; }

  [JsonProperty("Context")]
  public string Context { get; set; }

  [JsonProperty("DateEnd")]
  public Date DateEnd { get; set; }

  [JsonProperty("DateStart")]
  public Date DateStart { get; set; }

  [JsonProperty("EFT")]
  public ResultCriteriaEFT EFT { get; set; }

  [JsonProperty("EntityType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultsCriteriaEntityType? EntityType { get; set; }

  [JsonProperty("FirstName")]
  public string FirstName { get; set; }

  [JsonProperty("FraudPoint")]
  public FraudPointResultCriteria FraudPoint { get; set; }

  [JsonProperty("FullName")]
  public string FullName { get; set; }

  [JsonProperty("ID")]
  public EntityCriteriaID ID { get; set; }

  [JsonProperty("InstantID")]
  public InstantIDResultCriteria InstantID { get; set; }

  [JsonProperty("InstantIDIntl")]
  public InstantIDIntlResultCriteria InstantIDIntl { get; set; }

  [JsonProperty("LastName")]
  public string LastName { get; set; }

  [JsonProperty("MatchText")]
  public string MatchText { get; set; }

  [JsonProperty("MiddleName")]
  public string MiddleName { get; set; }

  [JsonProperty("SecondSurname")]
  public string SecondSurname { get; set; }

  [JsonProperty("MaidenName")]
  public string MaidenName { get; set; }

  [JsonProperty("RecordState")]
  public ResultCriteriaRecordState RecordState { get; set; }

  [JsonProperty("RunIDs")]
  public ICollection<long> RunIDs { get; set; }

  [JsonProperty("SSNEIN")]
  public string SSNEIN { get; set; }

  [JsonProperty("TimeEnd")]
  public Time TimeEnd { get; set; }

  [JsonProperty("TimeStart")]
  public Time TimeStart { get; set; }

  [JsonProperty("AlertDecisionName")]
  public string AlertDecisionName { get; set; }

  [JsonProperty("Watchlist")]
  public WatchlistResultCriteria Watchlist { get; set; }
}
