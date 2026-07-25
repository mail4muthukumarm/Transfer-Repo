// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedSWIFTAmount
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class ParsedSWIFTAmount
{
  [JsonProperty("AdditionalInformation")]
  public string AdditionalInformation { get; set; }

  [JsonProperty("Amount")]
  public string Amount { get; set; }

  [JsonProperty("Amount2")]
  public string Amount2 { get; set; }

  [JsonProperty("Code")]
  public string Code { get; set; }

  [JsonProperty("CurrencyCode")]
  public string CurrencyCode { get; set; }

  [JsonProperty("CurrencyCode2")]
  public string CurrencyCode2 { get; set; }

  [JsonProperty("DataSourceScheme")]
  public string DataSourceScheme { get; set; }

  [JsonProperty("Date")]
  public string Date { get; set; }

  [JsonProperty("DebitCreditMark")]
  public string DebitCreditMark { get; set; }

  [JsonProperty("MaturityPeriodType")]
  public string MaturityPeriodType { get; set; }

  [JsonProperty("Number")]
  public string Number { get; set; }

  [JsonProperty("NumberOfDaysOrMonths")]
  public string NumberOfDaysOrMonths { get; set; }

  [JsonProperty("Period")]
  public string Period { get; set; }

  [JsonProperty("Type")]
  public string Type { get; set; }

  [JsonProperty("Type2")]
  public string Type2 { get; set; }

  [JsonProperty("Units")]
  public string Units { get; set; }
}
