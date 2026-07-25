// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ResultRecordDetails
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ResultRecordDetails
{
  [JsonProperty("AcceptListID")]
  public long? AcceptListID { get; set; }

  [JsonProperty("AccountAmount")]
  public string AccountAmount { get; set; }

  [JsonProperty("AccountDate")]
  public string AccountDate { get; set; }

  [JsonProperty("AccountGroupID")]
  public string AccountGroupID { get; set; }

  [JsonProperty("AccountOtherData")]
  public string AccountOtherData { get; set; }

  [JsonProperty("AccountProviderID")]
  public string AccountProviderID { get; set; }

  [JsonProperty("AccountType")]
  public string AccountType { get; set; }

  [JsonProperty("AddedToAcceptList")]
  public bool? AddedToAcceptList { get; set; }

  [JsonProperty("AdditionalInfo")]
  public ICollection<InputAdditionalInfo> AdditionalInfo { get; set; }

  [JsonProperty("Addresses")]
  public ICollection<InputAddress> Addresses { get; set; }

  [JsonProperty("CustomWatchlistIDs")]
  public ICollection<int> CustomWatchlistIDs { get; set; }

  [JsonProperty("Division")]
  public string Division { get; set; }

  [JsonProperty("DPPA")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultRecordDetailsDPPA? DPPA { get; set; }

  [JsonProperty("EFTContext")]
  public string EFTContext { get; set; }

  [JsonProperty("EFTType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultRecordDetailsEFTType? EFTType { get; set; }

  [JsonProperty("EntityType")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultRecordDetailsEntityType? EntityType { get; set; }

  [JsonProperty("Error")]
  public ResultError Error { get; set; }

  [JsonProperty("Gender")]
  [JsonConverter(typeof (StringEnumConverter))]
  public ResultRecordDetailsGender? Gender { get; set; }

  [JsonProperty("GLB")]
  public int? GLB { get; set; }

  [JsonProperty("IDs")]
  public ICollection<InputID> IDs { get; set; }

  [JsonProperty("LastUpdatedDate")]
  public DateTimeOffset? LastUpdatedDate { get; set; }

  [JsonProperty("Name")]
  public InputName Name { get; set; }

  [JsonProperty("ParsedACH")]
  public ParsedACH ParsedACH { get; set; }

  [JsonProperty("ParsedFedwire")]
  public ParsedFedwire ParsedFedwire { get; set; }

  [JsonProperty("ParsedISO20022")]
  public ParsedISO20022 ParsedISO20022 { get; set; }

  [JsonProperty("ParsedSWIFT")]
  public ParsedSWIFT ParsedSWIFT { get; set; }

  [JsonProperty("Phones")]
  public ICollection<InputPhone> Phones { get; set; }

  [JsonProperty("RecordState")]
  public RecordState RecordState { get; set; }

  [JsonProperty("SearchDate")]
  public DateTimeOffset? SearchDate { get; set; }

  [JsonProperty("Text")]
  public string Text { get; set; }
}
