// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.BillItNow.ServiceObjects.BillItNowPoliciesResponse
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.BillItNow.ServiceObjects;

public class BillItNowPoliciesResponse
{
  [JsonProperty("mga_policy_id")]
  public string MGAPolicyId { get; set; }

  [JsonProperty("program_id")]
  public int ProgramID { get; set; }

  [JsonProperty("effective_date")]
  public DateTime EffectiveDate { get; set; }

  [JsonProperty("expiration_date")]
  public DateTime ExpirationDate { get; set; }

  [JsonProperty("premium_amount")]
  public Decimal PremiumAmount { get; set; }

  [JsonProperty("description")]
  public string Description { get; set; }

  [JsonProperty("reference_number")]
  public string ReferenceNo { get; set; }

  [JsonProperty("policy_type")]
  public string PolicyType { get; set; }

  [JsonProperty("pay_plan_code")]
  public string PayPlanCode { get; set; }

  [JsonProperty("broker_id")]
  public string BrokerID { get; set; }

  [JsonProperty("issue_company_id")]
  public string IssueCompanyID { get; set; }

  [JsonProperty("policy_holder_id")]
  public int PolicyHolderID { get; set; }

  [JsonProperty("is_noc_suppressed")]
  public bool IsNOCSuppressed { get; set; }

  [JsonProperty("noc_release_date")]
  public string NOCReleaseDate { get; set; }

  [JsonProperty("is_active")]
  public bool IsActive { get; set; }

  [JsonProperty("carrier_policy_id")]
  public int CarrierPolicyID { get; set; }

  public bool IsSuccessStatusCode { get; set; }
}
