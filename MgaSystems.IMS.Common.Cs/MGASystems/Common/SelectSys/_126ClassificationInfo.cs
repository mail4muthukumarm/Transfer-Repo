// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._126ClassificationInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _126ClassificationInfo
{
  [JsonProperty("LocationNo")]
  public string LocationNo { get; set; }

  [JsonProperty("HAZNo")]
  public int HAZNo { get; set; }

  [JsonProperty("Classification")]
  public string Classification { get; set; }

  [JsonProperty("ClassCode")]
  public string ClassCode { get; set; }

  [JsonProperty("Premium_Basis")]
  public string Premium_Basis { get; set; }

  [JsonProperty("Exposure")]
  public string Exposure { get; set; }

  [JsonProperty("TerritoryCode")]
  public string TerritoryCode { get; set; }

  [JsonProperty("Premises_Rate")]
  public double Premises_Rate { get; set; }

  [JsonProperty("Products_Rate")]
  public double Products_Rate { get; set; }

  [JsonProperty("Premises_Premium")]
  public double Premises_Premium { get; set; }

  [JsonProperty("Products_Premium")]
  public double Products_Premium { get; set; }

  [JsonProperty("State")]
  public string State { get; set; }
}
