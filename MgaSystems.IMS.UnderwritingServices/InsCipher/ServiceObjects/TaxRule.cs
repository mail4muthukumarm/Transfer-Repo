// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects.TaxRule
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.InsCipher.ServiceObjects;

public class TaxRule
{
  [JsonProperty("is_sl_tax_active")]
  public bool IsSurplusLinesTaxActive { get; set; }

  [JsonProperty("sl_tax_amount_type")]
  public int SurplusLinesTaxAmountType { get; set; }

  [JsonProperty("sl_tax_amount")]
  public Decimal SurplusLinesTaxAmount { get; set; }

  [JsonProperty("is_sl_tax_input_manual")]
  public bool IsSurplusLinesTaxInputManual { get; set; }

  [JsonProperty("is_stamping_fee_active")]
  public bool IsStampingFeeActive { get; set; }

  [JsonProperty("stamping_fee_amount_type")]
  public int StampingFeeAmountType { get; set; }

  [JsonProperty("stamping_fee_amount")]
  public Decimal StampingFeeAmount { get; set; }

  [JsonProperty("is_stamping_fee_input_manual")]
  public bool IsStampingFeeInputManual { get; set; }

  [JsonProperty("exclude_stamping_fee_when_negative_premium")]
  public bool ExcludeStampingFeeWhenNegativePremium { get; set; }

  [JsonProperty("is_sl_service_charge_active")]
  public bool IsServiceChargeActive { get; set; }

  [JsonProperty("sl_service_charge_amount_type")]
  public int ServiceChargeAmountType { get; set; }

  [JsonProperty("sl_service_charge_amount")]
  public Decimal ServiceChargeAmount { get; set; }

  [JsonProperty("is_sl_service_charge_input_manual")]
  public bool IsServiceChargeInputManual { get; set; }

  [JsonProperty("is_municipal_fee_active")]
  public bool IsMunicipalFeeActive { get; set; }

  [JsonProperty("municipal_fee_amount_type")]
  public int MunicipalFeeAmountType { get; set; }

  [JsonProperty("municipal_fee_amount")]
  public int MunicipalFeeAmount { get; set; }

  [JsonProperty("is_municipal_fee_input_manual")]
  public bool IsMunicipalFeeInputManual { get; set; }

  [JsonProperty("fee_restrictions")]
  public bool HasFeeRestrictions { get; set; }

  [JsonProperty("fee_restriction_amount_fixed_active")]
  public bool IsFeeRestrictionAmountFixedActive { get; set; }

  [JsonProperty("fee_restriction_amount_fixed")]
  public Decimal FeeRestrictionAmountFixed { get; set; }

  [JsonProperty("fee_restriction_amount_percentage_active")]
  public bool IsFeeRestrictionAmountPercentageActive { get; set; }

  [JsonProperty("fee_restriction_amount_percentage")]
  public object FeeRestrictionAmountPercentage { get; set; }

  [JsonProperty("max_fee")]
  public bool MaxFee { get; set; }

  [JsonProperty("max_fee_amount_type")]
  public int MaxFeeAmountType { get; set; }

  [JsonProperty("max_fee_amount")]
  public Decimal MaxFeeAmount { get; set; }

  [JsonProperty("fee_restriction_apply_to")]
  public int[] FeeRestrictionAppliesTo { get; set; }

  [JsonProperty("fee_restriction_apply_from")]
  public int[] FeeRestrictionAppliesFrom { get; set; }

  [JsonProperty("both_fees_allowed")]
  public bool BothFeesAllowed { get; set; }

  [JsonProperty("ask_if_commission_received")]
  public bool AskIfCommissionReceived { get; set; }

  [JsonProperty("sl_tax_title")]
  public object SurplusLinesTaxTitle { get; set; }

  [JsonProperty("sl_service_charge_title")]
  public object ServiceChargeTitle { get; set; }

  [JsonProperty("stamping_fee_title")]
  public string StampingFeeTitle { get; set; }

  [JsonProperty("municipal_fee_title")]
  public string MunicipalFeeTitle { get; set; }

  [JsonProperty("state_notes")]
  public StateNote[] StateNotes { get; set; }

  [JsonProperty("state_documents")]
  public StateDocument[] StateDocuments { get; set; }

  [JsonProperty("round_up_fees_to_the_nearest_dollar")]
  public bool RoundUpFeesToNearestDollar { get; set; }

  [JsonProperty("round_up_taxes_to_the_nearest_dollar")]
  public bool RoundUpTaxesToNearestDollar { get; set; }

  [JsonProperty("round_up_premium_to_the_nearest_dollar")]
  public bool RoundUpPremiumToNearestDollar { get; set; }

  [JsonProperty("round_fees_to_the_nearest_dollar")]
  public bool RoundFeesToNearestDollar { get; set; }

  [JsonProperty("round_taxes_to_the_nearest_dollar")]
  public bool RoundTaxesToNearestDollar { get; set; }

  [JsonProperty("round_premium_to_the_nearest_dollar")]
  public bool RoundPremiumToNearestDollar { get; set; }
}
