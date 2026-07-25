// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.BillItNow.ServiceObjects.BillItNowPoliciesModel
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.BillItNow.ServiceObjects;

internal class BillItNowPoliciesModel
{
  [JsonProperty("mga_id")]
  public int MgaId { get; set; }

  [JsonProperty("carrier_policy_id")]
  public int CarrierPolicyID { get; set; }

  [JsonProperty("carrierPolicyData")]
  public int CarrierPolicyData { get; set; }

  [JsonProperty("api-version")]
  public int APIVersion { get; set; }
}
