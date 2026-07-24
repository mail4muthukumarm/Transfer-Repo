// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.InsuranceScoreProxy
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common;

[Serializable]
public class InsuranceScoreProxy
{
  [XmlElement("name")]
  public string name;
  [XmlElement("dateOfBirth")]
  public DateTime dateOfBirth;
  [XmlElement("address1")]
  public string address1;
  [XmlElement("address2")]
  public string address2;
  [XmlElement("city")]
  public string city;
  [XmlElement("state")]
  public string state;
  [XmlElement("zip")]
  public string zip;
}
