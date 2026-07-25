// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.FilingTransaction
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;

public class FilingTransaction
{
  [JsonProperty("id")]
  public string UniqueID { get; set; }

  [JsonProperty("policy_number")]
  public string PolicyNumber { get; set; }

  [JsonProperty("policy_effective_date")]
  [JsonConverter(typeof (DateFormatConverter), new object[] {"yyyy-MM-dd"})]
  public DateTime? PolicyEffective { get; set; }

  [JsonProperty("policy_expiration_date")]
  [JsonConverter(typeof (DateFormatConverter), new object[] {"yyyy-MM-dd"})]
  public DateTime? PolicyExpiration { get; set; }

  [JsonProperty("transaction_effective_date")]
  [JsonConverter(typeof (DateFormatConverter), new object[] {"yyyy-MM-dd"})]
  public DateTime? TransactionEffectiveDate { get; set; }

  [JsonProperty("expiring_policy_number")]
  public string ExpiringPolicyNumber { get; set; }

  [JsonProperty("invoice_date")]
  [JsonConverter(typeof (DateFormatConverter), new object[] {"yyyy-MM-dd"})]
  public DateTime? InvoiceDate { get; set; }

  [JsonProperty("invoice_number")]
  public string InvoiceNumber { get; set; }

  [JsonProperty("transaction_type")]
  public string InvoiceTransactionType { get; set; }

  [JsonProperty("policy_type")]
  public string SLPolicyType { get; set; }

  [JsonProperty("account_written_as")]
  public string WrittenAs { get; set; }

  [JsonProperty("rpg")]
  [JsonConverter(typeof (BooleanIntConverter))]
  public bool? RPG { get; set; }

  [JsonProperty("layered_risk")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? LayeredRisk { get; set; }

  [JsonProperty("broker_of_record")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? BORChange { get; set; }

  [JsonProperty("risk_retention_group")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? RiskRetentionGroup { get; set; }

  [JsonProperty("purchasing_group_name")]
  public string PurchasingGroupName { get; set; }

  [JsonProperty("risk_description")]
  public string RiskDescription { get; set; }

  [JsonProperty("ecp")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? ExemptCommercialPurchaser { get; set; }

  [JsonProperty("exempt")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? TaxExempt { get; set; }

  [JsonProperty("multi_state")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? MultiState { get; set; }

  [JsonProperty("policy_limit")]
  public long? PolicyLimit { get; set; }

  [JsonProperty("property_limit")]
  public long? PropertyLimit { get; set; }

  [JsonProperty("transaction_line_of_business_list")]
  public string LOBList { get; set; }

  [JsonProperty("transaction_line_of_business_coverage")]
  public string LOBCoverages { get; set; }

  [JsonProperty("non_admitted_insurer_code_list")]
  public string NAICList { get; set; }

  [JsonProperty("non_admitted_insurer_code_coverage")]
  public string NAICCoverage { get; set; }

  [JsonProperty("syndicate_list")]
  public string SyndicatesList { get; set; }

  [JsonProperty("syndicate_list_coverage")]
  public string SyndicatesCoverage { get; set; }

  [JsonProperty("premium")]
  public Decimal? TotalPremium { get; set; }

  [JsonProperty("agency_fee")]
  public Decimal? AgencyFee { get; set; }

  [JsonProperty("inspection_fee")]
  public Decimal? InspectionFee { get; set; }

  [JsonProperty("sl_tax")]
  public Decimal? SLTax { get; set; }

  [JsonProperty("stamping_fee")]
  public Decimal? StampingFee { get; set; }

  [JsonProperty("sl_service_charge")]
  public Decimal? SLService { get; set; }

  [JsonProperty("municipal_fee")]
  public Decimal? MunicipalTax { get; set; }

  [JsonProperty("fm_tax")]
  public Decimal? FMTax { get; set; }

  [JsonProperty("empa_tax")]
  public Decimal? EMPATax { get; set; }

  [JsonProperty("total")]
  public Decimal? TotalInvoice { get; set; }

  [JsonProperty("commission_received")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? CommissionReceived { get; set; }

  [JsonProperty("mailing_insured_name")]
  public string MailingName { get; set; }

  [JsonProperty("mailing_address")]
  public string MailingAddress1 { get; set; }

  [JsonProperty("mailing_address2")]
  public string MailingAddress2 { get; set; }

  [JsonProperty("mailing_city")]
  public string MailingCity { get; set; }

  [JsonProperty("mailing_zip_code")]
  public string MailingZipCode { get; set; }

  [JsonProperty("mailing_state_code")]
  public string MailingState { get; set; }

  [JsonProperty("insured_entity")]
  public string InsuredEntityType { get; set; }

  [JsonProperty("insured_email")]
  public string InsuredEmail { get; set; }

  [JsonProperty("insured_phone")]
  public string InsuredPhone { get; set; }

  [JsonProperty("insured_county")]
  public string InsuredCounty { get; set; }

  [JsonProperty("physical_same_as_mailing")]
  [JsonConverter(typeof (BooleanIntConverter))]
  public bool SamePhysicalAndMailingState { get; set; }

  [JsonProperty("physical_address")]
  public string PhysicalAddress1 { get; set; }

  [JsonProperty("physical_address2")]
  public string PhysicalAddress2 { get; set; }

  [JsonProperty("physical_city")]
  public string PhysicalCity { get; set; }

  [JsonProperty("physical_zip_code")]
  public string PhysicalZipCode { get; set; }

  [JsonProperty("physical_state_code")]
  public string PhysicalState { get; set; }

  [JsonProperty("retail_producer_name")]
  public string RetailProducerName { get; set; }

  [JsonProperty("retail_producer_license")]
  public string RetailProducerLicense { get; set; }

  [JsonProperty("retail_agency_name")]
  public string RetailAgency { get; set; }

  [JsonProperty("retail_agency_license")]
  public string RetailAgencyLicense { get; set; }

  [JsonProperty("retail_address")]
  public string RetailAddress1 { get; set; }

  [JsonProperty("retail_address2")]
  public string RetailAddress2 { get; set; }

  [JsonProperty("retail_city")]
  public string RetailCity { get; set; }

  [JsonProperty("retail_state")]
  public string RetailState { get; set; }

  [JsonProperty("retail_zip")]
  public string RetailZipCode { get; set; }

  [JsonProperty("retail_phone_number")]
  public string RetailPhone { get; set; }

  [JsonProperty("retail_email_address")]
  public string RetailEmail { get; set; }

  [JsonProperty("business_group_id")]
  public string BusinessGroupID { get; set; }

  [JsonProperty("customer_code")]
  public string CustomerCode { get; set; }

  [JsonProperty("sop_name")]
  public string SOPName { get; set; }

  [JsonProperty("sop_address")]
  public string SOPAddress1 { get; set; }

  [JsonProperty("sop_address_2")]
  public string SOPAddress2 { get; set; }

  [JsonProperty("sop_city")]
  public string SOPCity { get; set; }

  [JsonProperty("sop_state")]
  public string SOPState { get; set; }

  [JsonProperty("sop_zip")]
  public string SOPZipCode { get; set; }

  [JsonProperty("dc_naic")]
  public string DCNAICCodes { get; set; }

  [JsonProperty("dc_date_declined")]
  [JsonConverter(typeof (DateFormatConverter), new object[] {"yyyy-MM-dd"})]
  public DateTime? DCDateDeclined { get; set; }

  [JsonProperty("dc_declining_reason")]
  public string DCDecliningReason { get; set; }

  [JsonProperty("dc_underwriting_consideration")]
  public string DCUnderwritingConsideration { get; set; }

  [JsonProperty("dc_representative_name")]
  public string DCRepresentativeName { get; set; }

  [JsonProperty("dc_representative_title")]
  public string DCRepresentativeTitle { get; set; }

  [JsonProperty("dc_representative_email")]
  public string DCRepresentativeEmail { get; set; }

  [JsonProperty("dc_representative_phone_number")]
  public string DCRepresentativePhone { get; set; }

  [JsonProperty("agent_id")]
  public int AgentID { get; set; }

  [JsonProperty("agent_notes")]
  public string AgentNotes { get; set; }

  [JsonProperty("umr_number")]
  public string UMRNumber { get; set; }

  [JsonProperty("sla_transaction_number")]
  public string SLATransactionNumber { get; set; }

  [JsonProperty("wind_storm_exclusion")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? WindstormExclusion { get; set; }

  [JsonProperty("wind_storm_eligible_for_pool")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? WindstormPoolEligible { get; set; }

  [JsonProperty("wind_storm_deductible")]
  public Decimal? WindstormDeductible { get; set; }

  [JsonProperty("wind_storm_primary_amount")]
  public Decimal? WindstormPrimaryAmount { get; set; }

  [JsonProperty("wind_storm_other_coverages_deductible")]
  public Decimal? WindstormOtherCoverages { get; set; }

  [JsonProperty("lloyds_cover_holder_number")]
  public string LloydsCoverHolderNumber { get; set; }

  [JsonProperty("lloyds_cover_holder_name")]
  public string LloydsCoverHolderName { get; set; }

  [JsonProperty("transaction_documents")]
  public TransactionDocument[] TransactionDocuments { get; set; }

  [JsonProperty("stamping_fee_invoice_id")]
  public string StampingFeeInvoiceID { get; set; }

  [JsonProperty("stamping_fee_date_paid")]
  [JsonConverter(typeof (DateFormatConverter), new object[] {"yyyy-MM-dd"})]
  public DateTime? StampingFeeDatePaid { get; set; }

  [JsonProperty("sl_tax_invoice_id")]
  public string SLTaxInvoiceID { get; set; }

  [JsonProperty("sl_tax_paid_date")]
  [JsonConverter(typeof (DateFormatConverter), new object[] {"yyyy-MM-dd"})]
  public DateTime? SLTaxPaidDate { get; set; }

  [JsonProperty("other_taxes_paid_date")]
  [JsonConverter(typeof (DateFormatConverter), new object[] {"yyyy-MM-dd"})]
  public DateTime? OtherTaxesPaidDate { get; set; }

  [JsonProperty("unique_id")]
  public string StateUniqueID { get; set; }

  [JsonProperty("transaction_status")]
  public int? TransactionStatus { get; set; }

  [JsonProperty("date_filed")]
  [JsonConverter(typeof (DateFormatConverter), new object[] {"yyyy-MM-dd"})]
  public DateTime? DateFiled { get; set; }

  [JsonProperty("license_number")]
  public string LicenseNumber { get; set; }

  [JsonProperty("filing_admin")]
  public string FilingAdmin { get; set; }

  [JsonProperty("migrated")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? Migrated { get; set; }
}
