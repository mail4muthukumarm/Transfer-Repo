// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.ParsedFedwireIDType
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System.CodeDom.Compiler;
using System.Runtime.Serialization;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public enum ParsedFedwireIDType
{
  [EnumMember(Value = "None")] None,
  [EnumMember(Value = "ABARouting")] ABARouting,
  [EnumMember(Value = "Account")] Account,
  [EnumMember(Value = "AlienRegistration")] AlienRegistration,
  [EnumMember(Value = "BankIdentifierCode")] BankIdentifierCode,
  [EnumMember(Value = "BankPartyID")] BankPartyID,
  [EnumMember(Value = "Cedula")] Cedula,
  [EnumMember(Value = "ChipsUID")] ChipsUID,
  [EnumMember(Value = "CustomerNumber")] CustomerNumber,
  [EnumMember(Value = "DriversLicense")] DriversLicense,
  [EnumMember(Value = "DUNS")] DUNS,
  [EnumMember(Value = "EFTCode")] EFTCode,
  [EnumMember(Value = "EIN")] EIN,
  [EnumMember(Value = "GLN")] GLN,
  [EnumMember(Value = "IBAN")] IBAN,
  [EnumMember(Value = "IBEI")] IBEI,
  [EnumMember(Value = "Member")] Member,
  [EnumMember(Value = "Military")] Military,
  [EnumMember(Value = "National")] National,
  [EnumMember(Value = "NIT")] NIT,
  [EnumMember(Value = "Other")] Other,
  [EnumMember(Value = "Passport")] Passport,
  [EnumMember(Value = "ProprietaryUID")] ProprietaryUID,
  [EnumMember(Value = "SSN")] SSN,
  [EnumMember(Value = "SwiftBEI")] SwiftBEI,
  [EnumMember(Value = "SwiftBIC")] SwiftBIC,
  [EnumMember(Value = "TaxID")] TaxID,
  [EnumMember(Value = "VISA")] VISA,
  [EnumMember(Value = "MedicareID")] MedicareID,
  [EnumMember(Value = "RTACardNumber")] RTACardNumber,
  [EnumMember(Value = "MedicareReference")] MedicareReference,
  [EnumMember(Value = "ProviderID")] ProviderID,
  [EnumMember(Value = "AircraftConstructionNumber")] AircraftConstructionNumber,
  [EnumMember(Value = "AircraftManufacturerSerialNumber")] AircraftManufacturerSerialNumber,
  [EnumMember(Value = "BusinessRegistrationNumber")] BusinessRegistrationNumber,
  [EnumMember(Value = "EuropeanHealthInsuranceCard")] EuropeanHealthInsuranceCard,
  [EnumMember(Value = "ExpeditedEntryCard")] ExpeditedEntryCard,
  [EnumMember(Value = "FishingNumber")] FishingNumber,
  [EnumMember(Value = "GIIN")] GIIN,
  [EnumMember(Value = "IMO")] IMO,
  [EnumMember(Value = "ISIN")] ISIN,
  [EnumMember(Value = "MSB")] MSB,
  [EnumMember(Value = "OFAC")] OFAC,
  [EnumMember(Value = "SEC")] SEC,
  [EnumMember(Value = "SocialServicesNumber")] SocialServicesNumber,
  [EnumMember(Value = "UnitedNations")] UnitedNations,
  [EnumMember(Value = "Voter")] Voter,
  [EnumMember(Value = "MMSI")] MMSI,
  [EnumMember(Value = "LegalEntity")] LegalEntity,
  [EnumMember(Value = "CRD")] CRD,
  [EnumMember(Value = "LexID")] LexID,
}
