// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.FraudPointConfiguration
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class FraudPointConfiguration
{
  [JsonProperty("Password")]
  public string Password { get; set; }

  [JsonProperty("UserID")]
  public string UserID { get; set; }

  [JsonProperty("SyntheticIdentityIndex")]
  public int? SyntheticIdentityIndex { get; set; }

  [JsonProperty("StolenIdentityIndex")]
  public int? StolenIdentityIndex { get; set; }

  [JsonProperty("ManipulatedIdentityIndex")]
  public int? ManipulatedIdentityIndex { get; set; }

  [JsonProperty("VulnerableVictimIndex")]
  public int? VulnerableVictimIndex { get; set; }

  [JsonProperty("FriendlyFraudIndex")]
  public int? FriendlyFraudIndex { get; set; }

  [JsonProperty("SuspiciousActivityIndex")]
  public int? SuspiciousActivityIndex { get; set; }
}
