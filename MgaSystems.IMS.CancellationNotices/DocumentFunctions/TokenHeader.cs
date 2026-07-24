// Decompiled with JetBrains decompiler
// Type: CancellationNotices.DocumentFunctions.TokenHeader
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace CancellationNotices.DocumentFunctions;

[GeneratedCode("System.Xml", "4.7.2556.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://tempuri.org/IMSWebServices/DocumentFunctions")]
[XmlRoot(Namespace = "http://tempuri.org/IMSWebServices/DocumentFunctions", IsNullable = false)]
[Serializable]
public class TokenHeader : SoapHeader
{
  private Guid tokenField;
  private XmlAttribute[] anyAttrField;

  public Guid Token
  {
    get => this.tokenField;
    set => this.tokenField = value;
  }

  [XmlAnyAttribute]
  public XmlAttribute[] AnyAttr
  {
    get => this.anyAttrField;
    set => this.anyAttrField = value;
  }
}
