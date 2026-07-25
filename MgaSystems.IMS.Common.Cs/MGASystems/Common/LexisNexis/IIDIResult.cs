// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.IIDIResult
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class IIDIResult
{
  [JsonProperty("ComplianceLevel")]
  public string ComplianceLevel { get; set; }

  [JsonProperty("DataSourceResults")]
  public ICollection<IIDIDataSource> DataSourceResults { get; set; }

  [JsonProperty("InputEcho")]
  public IIDIInput InputEcho { get; set; }

  [JsonProperty("PassportNumberValidated")]
  public string PassportNumberValidated { get; set; }

  [JsonProperty("RiskIndicators")]
  public ICollection<IIDIRiskIndicator> RiskIndicators { get; set; }

  [JsonProperty("VerificationIndex")]
  public IIDIVerificationIndex VerificationIndex { get; set; }

  [JsonProperty("VerificationResults")]
  public ICollection<IIDIVerificationResult> VerificationResults { get; set; }

  [JsonProperty("VisaNumberValidated")]
  public string VisaNumberValidated { get; set; }

  [JsonProperty("Watchlist")]
  public IIDWatchlist Watchlist { get; set; }
}
