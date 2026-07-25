// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.CalculateResponse
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;

public class CalculateResponse
{
  [JsonProperty("line_of_business_id")]
  public int LineOfBusinessId { get; set; }

  [JsonProperty("fm_tax_percentage")]
  public Decimal FMTaxPercentage { get; set; }

  [JsonProperty("line_of_business_list")]
  public MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.LineOfBusiness[] LineOfBusinessList { get; set; }

  [JsonProperty("line_of_business")]
  public string LineOfBusiness { get; set; }

  [JsonProperty("state_properties")]
  public StateStampProperties StateProperties { get; set; }

  [JsonProperty("account_written_as")]
  public string AccountWrittenAs { get; set; }

  [JsonProperty("transaction_type")]
  public string TransactionType { get; set; }

  [JsonProperty("premium")]
  public Decimal Premium { get; set; }

  [JsonProperty("agency_fee")]
  public Decimal AgencyFee { get; set; }

  [JsonProperty("inspection_fee")]
  public Decimal InspectionFee { get; set; }

  [JsonProperty("sl_tax")]
  public Decimal SurplusLinesTtax { get; set; }

  [JsonProperty("stamping_fee")]
  public Decimal StampingFee { get; set; }

  [JsonProperty("sl_service_charge")]
  public Decimal SurplusLinesServiceCharge { get; set; }

  [JsonProperty("municipal_fee")]
  public Decimal MunicipalFee { get; set; }

  [JsonProperty("county_fee")]
  public Decimal CountyFee { get; set; }

  [JsonProperty("fm_tax")]
  public Decimal FireMarshallTax { get; set; }

  [JsonProperty("empa_tax")]
  public Decimal EmpaTax { get; set; }

  [JsonProperty("rpg")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? IsRiskPurchasingGroup { get; set; }

  [JsonProperty("tax_rule")]
  public TaxRule TaxRule { get; set; }

  [JsonProperty("commission_received")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? CommissionReceived { get; set; }

  [JsonProperty("tax_exempt")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? TaxExempt { get; set; }

  [JsonProperty("export_list")]
  public int ExportList { get; set; }

  [JsonProperty("municipal_tax_settings")]
  public MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.MunicipalTaxSettings[] MunicipalTaxSettings { get; set; }

  [JsonProperty("county_tax_settings")]
  public CountyTaxSetting[] CountyTaxSettings { get; set; }

  [JsonProperty("collection_fee")]
  public int CollectionFee { get; set; }

  [JsonProperty("physical_address")]
  public string PhysicalAddress { get; set; }

  [JsonProperty("physical_city")]
  public string PhysicalCity { get; set; }

  [JsonProperty("physical_zip_code")]
  public string PhysicalZipCode { get; set; }

  [JsonProperty("physical_state")]
  public string PhysicalState { get; set; }

  [JsonProperty("message")]
  public string Message { get; set; }

  [JsonIgnore]
  public Exception ApiException { get; set; }
}
