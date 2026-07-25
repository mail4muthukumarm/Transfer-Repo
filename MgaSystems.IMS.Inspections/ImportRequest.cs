// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.ImportRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[Serializable]
public class ImportRequest
{
  [XmlArray("Inspections")]
  [XmlArrayItem("Inspection")]
  public ImportRequest.Inspection[] Inspections;

  [Serializable]
  public class Inspection
  {
    [XmlElement("PolicyNumber")]
    public string PolicyNumber;
    [XmlElement("DivisionLookupID")]
    public string DivisionLookupID;
    [XmlElement("InspectionTypeLookupID")]
    public string InspectionTypeLookupID;
    [XmlElement("Location")]
    public ImportRequest.Location Location;
    [XmlElement("Mailing")]
    public ImportRequest.Mailing Mailing;
    [XmlElement("PolicyHolder")]
    public ImportRequest.PolicyHolder PolicyHolder;
    [XmlArray("AdditionalContacts")]
    [XmlArrayItem("Contact")]
    public ImportRequest.Contact[] AdditionalContacts;
    [XmlElement("Agent")]
    public ImportRequest.Agent Agent;
    [XmlElement("Underwriter")]
    public ImportRequest.Underwriter Underwriter;
    [XmlElement("CarrierID")]
    public Guid? CarrierID;
    [XmlElement("Rush")]
    public bool Rush;
    [XmlElement("OrderNotes")]
    public string OrderNotes;
    [XmlElement("CurrentPremium")]
    public Decimal CurrentPremium;
    [XmlElement("DueDate")]
    public string DueDate;
    [XmlElement("InspectorDueDate")]
    public string InspectorDueDate;
    [XmlElement("EffectiveDate")]
    public string EffectiveDate;
    [XmlElement("PolicyExpirationDate")]
    public string PolicyExpirationDate;
    [XmlElement("PolicyRenewalDate")]
    public string PolicyRenewalDate;
    [XmlElement("CreatedByUserName")]
    public string CreatedByUserName;
    [XmlElement("CurrencyISO")]
    public string CurrencyISO;
    [XmlArray("GenericFields")]
    [XmlArrayItem("GenericField")]
    public ImportRequest.GenericField[] GenericFields;
    [XmlArray("Coverages")]
    [XmlArrayItem("Residential")]
    public ImportRequest.Residential[] Coverages;
    [XmlArray("Buildings")]
    [XmlArrayItem("Building")]
    public ImportRequest.Building[] Buildings;
    [XmlElement("IndustryCodes")]
    public ImportRequest.IndustryCodes IndustryCodes;
  }

  public class Location
  {
    [XmlElement("Country")]
    public string Country;
    [XmlElement("Street1")]
    public string Street1;
    [XmlElement("Street2")]
    public string Street2;
    [XmlElement("Street3")]
    public string Street3;
    [XmlElement("City")]
    public string City;
    [XmlElement("Region1")]
    public string Region1;
    [XmlElement("Region2")]
    public string Region2;
    [XmlElement("Region3")]
    public string Region3;
    [XmlElement("Region4")]
    public string Region4;
    [XmlElement("ZipCode")]
    public string ZipCode;
  }

  public class Mailing
  {
    [XmlElement("Country")]
    public string Country;
    [XmlElement("Street1")]
    public string Street1;
    [XmlElement("Street2")]
    public string Street2;
    [XmlElement("Street3")]
    public string Street3;
    [XmlElement("City")]
    public string City;
    [XmlElement("Region1")]
    public string Region1;
    [XmlElement("Region2")]
    public string Region2;
    [XmlElement("Region3")]
    public string Region3;
    [XmlElement("Region4")]
    public string Region4;
    [XmlElement("ZipCode")]
    public string ZipCode;
  }

  public class PolicyHolder
  {
    [XmlElement("CellPhone")]
    public string CellPhone;
    [XmlElement("CompanyName")]
    public string CompanyName;
    [XmlElement("Email")]
    public string Email;
    [XmlElement("FirstName")]
    public string FirstName;
    [XmlElement("HomePhone")]
    public string HomePhone;
    [XmlElement("LastName")]
    public string LastName;
    [XmlElement("Occupation")]
    public string Occupation;
    [XmlElement("UseCompanyName")]
    public bool UseCompanyName;
    [XmlElement("WorkPhone")]
    public string WorkPhone;
    [XmlElement("Location")]
    public string Location;
    [XmlElement("ContactType")]
    public string ContactType;
    [XmlElement("IsPrimary")]
    public bool IsPrimary;
  }

  [Serializable]
  public class Contact
  {
    [XmlElement("CellPhone")]
    public string CellPhone;
    [XmlElement("CompanyName")]
    public string CompanyName;
    [XmlElement("Email")]
    public string Email;
    [XmlElement("FirstName")]
    public string FirstName;
    [XmlElement("HomePhone")]
    public string HomePhone;
    [XmlElement("LastName")]
    public string LastName;
    [XmlElement("Occupation")]
    public string Occupation;
    [XmlElement("UseCompanyName")]
    public bool UseCompanyName;
    [XmlElement("WorkPhone")]
    public string WorkPhone;
    [XmlElement("Location>")]
    public string Location;
    [XmlElement("ContactType")]
    public string ContactType;
    [XmlElement("Notes")]
    public string Notes;
    [XmlElement("IsPrimary")]
    public bool IsPrimary;
    [XmlElement("ContactID")]
    public string ContactID;
  }

  public class Agent
  {
    [XmlElement("AgencyCode")]
    public string AgencyCode;
    [XmlElement("AgencyName")]
    public string AgencyName;
    [XmlElement("AgentCode")]
    public string AgentCode;
    [XmlElement("AgentName")]
    public string AgentName;
    [XmlElement("Email")]
    public string Email;
    [XmlElement("FaxNumber")]
    public string FaxNumber;
    [XmlElement("PhoneNumber")]
    public string PhoneNumber;
    [XmlElement("Address")]
    public ImportRequest.Address AgentAddress;
    [XmlElement("AgentType")]
    public string AgentType;
  }

  public class Address
  {
    [XmlElement("City")]
    public string City;
    [XmlElement("Country")]
    public string Country;
    [XmlElement("Region1")]
    public string Region1;
    [XmlElement("Region2")]
    public string Region2;
    [XmlElement("Region3")]
    public string Region3;
    [XmlElement("Region4")]
    public string Region4;
    [XmlElement("Street1")]
    public string Street1;
    [XmlElement("Street2")]
    public string Street2;
    [XmlElement("ZipCode")]
    public string ZipCode;
    [XmlElement("Latitude")]
    public string Latitude;
    [XmlElement("Longitude")]
    public string Longitude;
    [XmlElement("StateID")]
    public string StateID;
  }

  [Serializable]
  public class Underwriter
  {
    [XmlElement("Company")]
    public string Company;
    [XmlElement("Email")]
    public string Email;
    [XmlElement("FirstName")]
    public string FirstName;
    [XmlElement("LastName")]
    public string LastName;
    [XmlElement("PhoneNumber")]
    public string PhoneNumber;
    [XmlElement("UnderwriterCode")]
    public string UnderwriterCode;
  }

  [Serializable]
  public class GenericField
  {
    [XmlElement("Key")]
    public string Key;
    [XmlElement("Text")]
    public string Text;
    [XmlElement("GenericFieldValueType")]
    public string GenericFieldValueType;
    [XmlElement("DateTime")]
    public string DateTime;
    [XmlElement("Number")]
    public string Number;
    [XmlElement("TrueFalse")]
    public string TrueFalse;
  }

  [Serializable]
  public class Residential
  {
    [XmlElement("CoverageAIn")]
    public string CoverageAIn;
  }

  [Serializable]
  public class Building
  {
    [XmlElement("Name")]
    public string Name;
    [XmlArray("AdditionalForms")]
    [XmlArrayItem("string")]
    public string[] AdditionalForms;
  }

  [Serializable]
  public class IndustryCodes
  {
    [XmlElement("SICCode")]
    public string SICCode;
  }
}
