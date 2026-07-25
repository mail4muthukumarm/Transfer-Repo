// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.OrderDTO
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

public class OrderDTO
{
  [JsonProperty("BizUnitId")]
  public int BizUnitId { get; set; }

  [JsonProperty("ProdLineId")]
  public int ProdLineId { get; set; }

  [JsonProperty("ReasonForSurvey")]
  public int ReasonForSurvey { get; set; }

  [JsonProperty("DueDate")]
  public DateTime DueDate { get; set; }

  [JsonProperty("ReturnCode")]
  public string ReturnCode { get; set; }

  [JsonProperty("PolicyNumber")]
  public string PolicyNumber { get; set; }

  [JsonProperty("InsuredName")]
  public string InsuredName { get; set; }

  [JsonProperty("SecondaryName")]
  public string SecondaryName { get; set; }

  [JsonProperty("SurveyAddress1")]
  public string SurveyAddress1 { get; set; }

  [JsonProperty("SurveyAddress2")]
  public string SurveyAddress2 { get; set; }

  [JsonProperty("SurveyCity")]
  public string SurveyCity { get; set; }

  [JsonProperty("SurveyState")]
  public string SurveyState { get; set; }

  [JsonProperty("SurveyZip")]
  public string SurveyZip { get; set; }

  [JsonProperty("ContactName")]
  public string ContactName { get; set; }

  [JsonProperty("ContactPhone")]
  public string ContactPhone { get; set; }

  [JsonProperty("AlternateContactPhone")]
  public string AlternateContactPhone { get; set; }

  [JsonProperty("EmailAddress")]
  public string EmailAddress { get; set; }

  [JsonProperty("Agency")]
  public string Agency { get; set; }

  [JsonProperty("AgentName")]
  public string AgentName { get; set; }

  [JsonProperty("AgentPhone")]
  public string AgentPhone { get; set; }

  [JsonProperty("AgentEmailAddress")]
  public string AgentEmailAddress { get; set; }

  [JsonProperty("Underwriter")]
  public string Underwriter { get; set; }

  [JsonProperty("UnderwriterPhone")]
  public string UnderwriterPhone { get; set; }

  [JsonProperty("UnderwriterEmail")]
  public string UnderwriterEmail { get; set; }

  [JsonProperty("AdditionalNotes")]
  public string AdditionalNotes { get; set; }

  [JsonProperty("Guid")]
  public Guid Guid { get; set; }

  [JsonProperty("VendorID")]
  public int VendorID { get; set; }

  [JsonProperty("TypeOfOperation")]
  public string TypeOfOperation { get; set; }
}
