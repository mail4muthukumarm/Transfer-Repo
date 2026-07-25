// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.Vessel
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class Vessel
{
  [JsonProperty("Type")]
  [JsonConverter(typeof (StringEnumConverter))]
  public MGASystems.Common.LexisNexis.VesselType? Type { get; set; }

  [JsonProperty("Source")]
  public string Source { get; set; }

  [JsonProperty("VesselType")]
  public string VesselType { get; set; }

  [JsonProperty("SubCategories")]
  public ICollection<string> SubCategories { get; set; }

  [JsonProperty("GrossTonnage")]
  public string GrossTonnage { get; set; }

  [JsonProperty("DateModified")]
  public DateTimeOffset? DateModified { get; set; }

  [JsonProperty("Weight")]
  public string Weight { get; set; }

  [JsonProperty("Owner")]
  public string Owner { get; set; }

  [JsonProperty("FormerVesselName")]
  public string FormerVesselName { get; set; }

  [JsonProperty("FlagEffectiveDate")]
  public string FlagEffectiveDate { get; set; }

  [JsonProperty("ShipStatus")]
  public string ShipStatus { get; set; }

  [JsonProperty("ShipStatusEffectiveDate")]
  public string ShipStatusEffectiveDate { get; set; }

  [JsonProperty("PortOfRegistry")]
  public string PortOfRegistry { get; set; }

  [JsonProperty("YearOfBuild")]
  public string YearOfBuild { get; set; }

  [JsonProperty("YardNumber")]
  public string YardNumber { get; set; }

  [JsonProperty("Shipbuilder")]
  public string Shipbuilder { get; set; }

  [JsonProperty("ShipbuilderSubContractorYardHull")]
  public string ShipbuilderSubContractorYardHull { get; set; }

  [JsonProperty("ShipbuilderSubContractor")]
  public string ShipbuilderSubContractor { get; set; }

  [JsonProperty("GroupBeneficialOwner")]
  public string GroupBeneficialOwner { get; set; }

  [JsonProperty("GroupBeneficialOwnerCompanyCode")]
  public string GroupBeneficialOwnerCompanyCode { get; set; }

  [JsonProperty("GroupBeneficialOwnerCountryOfControl")]
  public string GroupBeneficialOwnerCountryOfControl { get; set; }

  [JsonProperty("GroupBeneficialOwnerCountryOfDomicile")]
  public string GroupBeneficialOwnerCountryOfDomicile { get; set; }

  [JsonProperty("GroupBeneficialOwnerCountryOfRegistration")]
  public string GroupBeneficialOwnerCountryOfRegistration { get; set; }

  [JsonProperty("Operator")]
  public string Operator { get; set; }

  [JsonProperty("OperatorCompanyCode")]
  public string OperatorCompanyCode { get; set; }

  [JsonProperty("OperatorCountryOfControl")]
  public string OperatorCountryOfControl { get; set; }

  [JsonProperty("OperatorCountryOfDomicile")]
  public string OperatorCountryOfDomicile { get; set; }

  [JsonProperty("OperatorCountryOfRegistration")]
  public string OperatorCountryOfRegistration { get; set; }

  [JsonProperty("RegisteredOwnerCompanyCode")]
  public string RegisteredOwnerCompanyCode { get; set; }

  [JsonProperty("RegisteredOwnerCountryOfControl")]
  public string RegisteredOwnerCountryOfControl { get; set; }

  [JsonProperty("RegisteredOwnerCountryOfDomicile")]
  public string RegisteredOwnerCountryOfDomicile { get; set; }

  [JsonProperty("RegisteredOwnerCountryOfRegistration")]
  public string RegisteredOwnerCountryOfRegistration { get; set; }

  [JsonProperty("ShipManager")]
  public string ShipManager { get; set; }

  [JsonProperty("ShipManagerCompanyCode")]
  public string ShipManagerCompanyCode { get; set; }

  [JsonProperty("ShipManagerCountryOfControl")]
  public string ShipManagerCountryOfControl { get; set; }

  [JsonProperty("ShipManagerCountryOfDomicile")]
  public string ShipManagerCountryOfDomicile { get; set; }

  [JsonProperty("ShipManagerCountryOfRegistration")]
  public string ShipManagerCountryOfRegistration { get; set; }

  [JsonProperty("TechnicalManager")]
  public string TechnicalManager { get; set; }

  [JsonProperty("TechnicalManagerCompanyCode")]
  public string TechnicalManagerCompanyCode { get; set; }

  [JsonProperty("TechnicalManagerCountryOfControl")]
  public string TechnicalManagerCountryOfControl { get; set; }

  [JsonProperty("TechnicalManagerCountryOfDomicile")]
  public string TechnicalManagerCountryOfDomicile { get; set; }

  [JsonProperty("TechnicalManagerCountryOfRegistration")]
  public string TechnicalManagerCountryOfRegistration { get; set; }

  [JsonProperty("DOCCompany")]
  public string DOCCompany { get; set; }

  [JsonProperty("DOCCompanyCode")]
  public string DOCCompanyCode { get; set; }

  [JsonProperty("DOCCompanyCountryOfControl")]
  public string DOCCompanyCountryOfControl { get; set; }

  [JsonProperty("DOCCompanyCountryOfDomicile")]
  public string DOCCompanyCountryOfDomicile { get; set; }

  [JsonProperty("DOCCompanyCountryOfRegistration")]
  public string DOCCompanyCountryOfRegistration { get; set; }
}
