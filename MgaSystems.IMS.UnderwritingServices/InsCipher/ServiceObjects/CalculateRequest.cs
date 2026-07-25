// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.CalculateRequest
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;

public class CalculateRequest
{
  [JsonProperty("physical_state")]
  public string PhysicalState { get; set; }

  [JsonProperty("physical_address")]
  public string PhysicalAddress { get; set; }

  [JsonProperty("physical_city")]
  public string PhysicalCity { get; set; }

  [JsonProperty("physical_zip_code")]
  public string PhysicalZipCode { get; set; }

  [JsonProperty("line_of_business")]
  public string LineOfBusiness { get; set; }

  [JsonProperty("premium")]
  public Decimal? Premium { get; set; }

  [JsonProperty("transaction_line_of_business_list")]
  public string TransactionLineOfBusinessList { get; set; }

  [JsonProperty("transaction_line_of_business_coverage")]
  public string TransactionLineOfBusinessCoverage { get; set; }

  [JsonProperty("policy_effective_date")]
  [JsonConverter(typeof (DateFormatConverter), new object[] {"yyyy-MM-dd"})]
  public DateTime PolicyEffectiveDate { get; set; }

  [JsonProperty("transaction_type")]
  public string TransactionType { get; set; }

  [JsonProperty("agency_fee")]
  public Decimal AgencyFee { get; set; }

  [JsonProperty("inspection_fee")]
  public Decimal InspectionFee { get; set; }

  [JsonProperty("commission_received")]
  [JsonConverter(typeof (BooleanIntConverter))]
  public bool? CommissionReceived { get; set; }

  [JsonProperty("rpg")]
  [JsonConverter(typeof (BooleanIntConverter))]
  public bool? IsRiskPurchasingGroup { get; set; }

  [JsonProperty("ecp")]
  [JsonConverter(typeof (BooleanIntConverter))]
  public bool? IsExemptCommercialPurchaser { get; set; }

  [JsonProperty("account_written_as")]
  public string AccountWrittenAs { get; set; }
}
