// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys._125_PolicyInfo
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class _125_PolicyInfo
{
  [JsonProperty("Proposed_EFF_Date")]
  public string Proposed_EFF_Date { get; set; }

  [JsonProperty("Proposed_EXP_Date")]
  public string Proposed_EXP_Date { get; set; }

  [JsonProperty("Billing_Plan")]
  public string Billing_Plan { get; set; }

  [JsonProperty("Payment_Plan")]
  public string Payment_Plan { get; set; }

  [JsonProperty("Method_Of_Payment")]
  public string Method_Of_Payment { get; set; }

  [JsonProperty("Audit")]
  public string Audit { get; set; }

  [JsonProperty("Deposit")]
  public string Deposit { get; set; }

  [JsonProperty("Minimum_Premium")]
  public string Minimum_Premium { get; set; }

  [JsonProperty("Policy_Premium")]
  public string Policy_Premium { get; set; }
}
