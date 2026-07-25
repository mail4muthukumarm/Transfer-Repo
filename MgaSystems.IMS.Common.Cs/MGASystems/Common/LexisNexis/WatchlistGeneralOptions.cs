// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WatchlistGeneralOptions
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class WatchlistGeneralOptions
{
  [JsonProperty("GenerateAlertsForAllRecords")]
  public bool? GenerateAlertsForAllRecords { get; set; }

  [JsonProperty("GenerateAlertsForErrors")]
  public bool? GenerateAlertsForErrors { get; set; }

  [JsonProperty("IgnoreMatchesAgainstVessels")]
  public bool? IgnoreMatchesAgainstVessels { get; set; }

  [JsonProperty("ScanAddressForBlockedCountries")]
  public bool? ScanAddressForBlockedCountries { get; set; }

  [JsonProperty("ScanNameForBlockedCountries")]
  public bool? ScanNameForBlockedCountries { get; set; }

  [JsonProperty("ScanRunTogetherWordsForBlockedCountries")]
  public bool? ScanRunTogetherWordsForBlockedCountries { get; set; }
}
