// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.AttachCaseFileRequest
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[Serializable]
public class AttachCaseFileRequest
{
  [XmlElement("Password")]
  public string Password;
  [XmlElement("UserName")]
  public string UserName;
  [XmlElement("CaseNumber")]
  public int CaseNumber;
  [XmlElement("CollateIntoReport")]
  public bool CollateIntoReport;
  [XmlElement("FileData")]
  public string FileData;
  [XmlElement("FileName")]
  public string FileName;
  [XmlElement("PolicyNumber")]
  public string PolicyNumber;
  [XmlElement("ShowToCustomer")]
  public bool ShowToCustomer;
}
