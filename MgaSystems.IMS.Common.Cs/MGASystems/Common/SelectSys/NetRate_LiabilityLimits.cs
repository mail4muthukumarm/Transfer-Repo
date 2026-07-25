// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.SelectSys.NetRate_LiabilityLimits
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.SelectSys;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class NetRate_LiabilityLimits
{
  [JsonProperty("EachOccurrence")]
  public string EachOccurrence { get; set; }

  [JsonProperty("GeneralAggregate")]
  public string GeneralAggregate { get; set; }

  [JsonProperty("ProductsAggregate")]
  public string ProductsAggregate { get; set; }

  [JsonProperty("Deductible")]
  public string Deductible { get; set; }

  [JsonProperty("DeductibleType")]
  public string DeductibleType { get; set; }

  [JsonProperty("MedicalPayments")]
  public string MedicalPayments { get; set; }

  [JsonProperty("FireLegal")]
  public string FireLegal { get; set; }

  [JsonProperty("PersonalAdvInjury")]
  public string PersonalAdvInjury { get; set; }

  [JsonProperty("PolicyType")]
  public string PolicyType { get; set; }

  [JsonProperty("EBPolicyType")]
  public string EBPolicyType { get; set; }
}
