// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.DataAccess.ChargeCode.ChargeCodeDto
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using MGASystems.Data.DataMapping;
using MGASystems.Data.Dto;
using System;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.DataAccess.ChargeCode;

public class ChargeCodeDto : DtoBase<int>
{
  public override int UniqueIdentifier => this.ChargeCode;

  [TableFieldMapping("ChargeCode")]
  public int ChargeCode { get; set; }

  [TableFieldMapping("ChargeType")]
  public char ChargeType { get; set; }

  [TableFieldMapping("ChargeName")]
  public string ChargeName { get; set; }

  [TableFieldMapping("Description")]
  public string Description { get; set; }

  [TableFieldMapping("Commissionable")]
  public bool? Commissionable { get; set; }

  [TableFieldMapping("SystemDefined")]
  public bool SystemDefined { get; set; }

  [TableFieldMapping("ChargeID")]
  public string ChargeID { get; set; }

  [TableFieldMapping("LastUpdated")]
  public DateTime LastUpdated { get; set; }

  [TableFieldMapping("StateID")]
  public string StateID { get; set; }

  [TableFieldMapping("Tax")]
  public bool Tax { get; set; }

  [TableFieldMapping("NetRateLOB")]
  public string NetRateLOB { get; set; }

  [TableFieldMapping("DaysTaxDue")]
  public int? DaysTaxDue { get; set; }

  [TableFieldMapping("DaysFilingDue")]
  public int? DaysFilingDue { get; set; }

  [TableFieldMapping("DaysTaxDueType")]
  public char? DaysTaxDueType { get; set; }

  [TableFieldMapping("DaysFilingDueType")]
  public char? DaysFilingDueType { get; set; }

  [TableFieldMapping("TaxDueMonthAndDay")]
  public DateTime? TaxDueMonthAndDay { get; set; }

  [TableFieldMapping("TaxDueSemiAnnual1")]
  public DateTime? TaxDueSemiAnnual1 { get; set; }

  [TableFieldMapping("TaxDueSemiAnnual2")]
  public DateTime? TaxDueSemiAnnual2 { get; set; }

  [TableFieldMapping("FilingDueSemiAnnual1")]
  public DateTime? FilingDueSemiAnnual1 { get; set; }

  [TableFieldMapping("FilingDueSemiAnnual2")]
  public DateTime? FilingDueSemiAnnual2 { get; set; }

  [TableFieldMapping("NetRateFeeID")]
  public string NetRateFeeID { get; set; }

  [TableFieldMapping("RaterDrivenFee")]
  public bool? RaterDrivenFee { get; set; }

  [TableFieldMapping("SurplusLinesTax")]
  public bool SurplusLinesTax { get; set; }

  [TableFieldMapping("SLPriority")]
  public int? SLPriority { get; set; }

  [TableFieldMapping("SendAsDownpayment")]
  public bool SendAsDownpayment { get; set; }

  [TableFieldMapping("DirectBillEligible")]
  public bool DirectBillEligible { get; set; }

  [TableFieldMapping("FeeClassID")]
  public int? FeeClassID { get; set; }
}
