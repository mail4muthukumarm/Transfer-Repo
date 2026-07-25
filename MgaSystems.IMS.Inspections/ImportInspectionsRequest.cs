// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.ImportInspectionsRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[Serializable]
public class ImportInspectionsRequest
{
  [XmlElement("Password")]
  public string Password;
  [XmlElement("UserName")]
  public string UserName;
  [XmlArray("Inspections")]
  [XmlArrayItem("Inspection")]
  public ImportInspectionsRequest.Inspection[] Inspections;

  [Serializable]
  public class Inspection
  {
    [XmlElement("Agent")]
    public ImportInspectionsRequest.Agent InspectionAgent;
    [XmlElement("Attributes")]
    public ImportInspectionsRequest.Attributes InspectionAttributes;
    [XmlElement("CustomerKey")]
    public string CustomerKey;
    [XmlElement("EffectiveDate")]
    public string EffectiveDate;
    [XmlElement("ExtraFields")]
    public ImportInspectionsRequest.ExtraFields[] InspectionExtraFields;
    [XmlElement("IgnoreDuplicates")]
    public bool IgnoreDuplicates;
    [XmlElement("InspectionType")]
    public string InspectionType;
    [XmlElement("IsRush")]
    public bool IsRush;
    [XmlElement("Location")]
    public ImportInspectionsRequest.Location InspectionLocation;
    [XmlElement("Mailing")]
    public ImportInspectionsRequest.Mailing InspectionMailing;
    [XmlElement("Notes")]
    public string Notes;
    [XmlElement("PolicyHolder")]
    public ImportInspectionsRequest.PolicyHolder InspectionPolicyHolder;
    [XmlElement("PolicyNumber")]
    public string PolicyNumber;
    [XmlElement("Underwriter")]
    public ImportInspectionsRequest.Underwriter InspectionUnderwriter;
  }

  public class Agent
  {
    [XmlElement("Address")]
    public ImportInspectionsRequest.Address AgentAddress;
    [XmlElement("AgencyName")]
    public string AgencyName;
    [XmlElement("AgentCode")]
    public string AgentCode;
    [XmlElement("ContactEmail")]
    public string ContactEmail;
    [XmlElement("ContactName")]
    public string ContactName;
    [XmlElement("Fax")]
    public string Fax;
    [XmlElement("Phone")]
    public string Phone;
  }

  public class Address
  {
    [XmlElement("City")]
    public string City;
    [XmlElement("StateOrProvince")]
    public string StateOrProvince;
    [XmlElement("Street1")]
    public string Street1;
    [XmlElement("Street2")]
    public string Street2;
    [XmlElement("ZipCode")]
    public string ZipCode;
  }

  public class Attributes
  {
    [XmlElement("BuildingCost")]
    public Decimal BuildingCost;
    [XmlElement("BusinessTotalRevenue")]
    public Decimal BusinessTotalRevenue;
    [XmlElement("BusinessType")]
    public string BusinessType;
    [XmlElement("ContentsCost")]
    public Decimal ContentsCost;
    [XmlElement("CoverageAIn")]
    public Decimal CoverageAIn;
    [XmlElement("IsoClass")]
    public string IsoClass;
    [XmlElement("Occupancy")]
    public string Occupancy;
    [XmlElement("YearBuilt")]
    public int YearBuilt;
  }

  public class ExtraFields
  {
    [XmlElement("KeyValueOfstringstring", Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    public ImportInspectionsRequest.KeyValues[] KeyValueOfstringstring;
  }

  [Serializable]
  public class KeyValues
  {
    [XmlElement("Key")]
    public string Key;
    [XmlElement("Value")]
    public string Value;
  }

  public class Location
  {
    [XmlElement("City")]
    public string City;
    [XmlElement("StateOrProvince")]
    public string StateOrProvince;
    [XmlElement("Street1")]
    public string Street1;
    [XmlElement("Street2")]
    public string Street2;
    [XmlElement("ZipCode")]
    public string ZipCode;
  }

  public class Mailing
  {
    [XmlElement("City")]
    public string City;
    [XmlElement("StateOrProvince")]
    public string StateOrProvince;
    [XmlElement("Street1")]
    public string Street1;
    [XmlElement("Street2")]
    public string Street2;
    [XmlElement("ZipCode")]
    public string ZipCode;
  }

  public class PolicyHolder
  {
    [XmlElement("CellPhone")]
    public string CellPhone;
    [XmlElement("HomePhone")]
    public string HomePhone;
    [XmlElement("PolicyHolderContact")]
    public string PolicyHolderContact;
    [XmlElement("PolicyHolderName")]
    public string PolicyHolderName;
    [XmlElement("WorkPhone")]
    public string WorkPhone;
  }

  public class Underwriter
  {
    [XmlElement("CorrespondanceEmail")]
    public string CorrespondanceEmail;
    [XmlElement("FirstName")]
    public string FirstName;
    [XmlElement("IgnoreDuplicate")]
    public bool IgnoreDuplicate;
    [XmlElement("LastName")]
    public string LastName;
    [XmlElement("Phone")]
    public string Phone;
    [XmlElement("ReportEmail")]
    public string ReportEmail;
    [XmlElement("UnderwriterCode")]
    public string UnderwriterCode;
  }
}
