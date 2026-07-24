// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.Mueller.MuellerRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.Mueller;

[Serializable]
public class MuellerRequest
{
  [XmlArray("Inspections")]
  [XmlArrayItem("Inspection")]
  public MuellerRequest.Inspection[] Inspections;

  [Serializable]
  public class Inspection
  {
    [XmlElement("PolicyID")]
    public string PolicyID;
    [XmlElement("PolicyNumber")]
    public string PolicyNumber;
    [XmlElement("InsuredName")]
    public string InsuredName;
    [XmlElement("MailingAddress1")]
    public string MailingAddress1;
    [XmlElement("MailingAddress2")]
    public string MailingAddress2;
    [XmlElement("MailingCity")]
    public string MailingCity;
    [XmlElement("MailingState")]
    public string MailingState;
    [XmlElement("MailingZip")]
    public string MailingZip;
    [XmlElement("SurveyAddress1")]
    public string SurveyAddress1;
    [XmlElement("SurveyAddress2")]
    public string SurveyAddress2;
    [XmlElement("SurveyCity")]
    public string SurveyCity;
    [XmlElement("SurveyState")]
    public string SurveyState;
    [XmlElement("SurveyZip")]
    public string SurveyZip;
    [XmlElement("InsuredPhone")]
    public string InsuredPhone;
    [XmlElement("InsuredPhone2")]
    public string InsuredPhone2;
    [XmlElement("BusinessType")]
    public string BusinessType;
    [XmlElement("SurveyType")]
    public string SurveyType;
    [XmlElement("EffectiveDate")]
    public string EffectiveDate;
    [XmlElement("CoverageIn")]
    public string CoverageIn;
    [XmlElement("AgentCode")]
    public string AgentCode;
    [XmlElement("AgentName")]
    public string AgentName;
    [XmlElement("AgentPhone")]
    public string AgentPhone;
    [XmlElement("YearBuilt")]
    public string YearBuilt;
    [XmlElement("UnderwriterCode")]
    public string UnderwriterCode;
    [XmlElement("Comments")]
    public string Comments;
    [XmlArray("Supplements")]
    [XmlArrayItem("Supplement")]
    public MuellerRequest.Supplement[] Supplements;
    [XmlElement("OrderCodeIn")]
    public string OrderCodeIn;
  }

  [Serializable]
  public class Supplement
  {
    [XmlElement("Name")]
    public string Name;
  }
}
