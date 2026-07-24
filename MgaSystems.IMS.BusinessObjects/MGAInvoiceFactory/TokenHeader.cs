// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.MGAInvoiceFactory.TokenHeader
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.BusinessObjects.MGAInvoiceFactory;

[GeneratedCode("System.Xml", "4.8.3761.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://tempuri.org/Invoicing/InvoiceFactory")]
[XmlRoot(Namespace = "http://tempuri.org/Invoicing/InvoiceFactory", IsNullable = false)]
[Serializable]
public class TokenHeader : SoapHeader
{
  private Guid tokenField;
  private string contextField;
  private XmlAttribute[] anyAttrField;

  public Guid Token
  {
    get => this.tokenField;
    set => this.tokenField = value;
  }

  public string Context
  {
    get => this.contextField;
    set => this.contextField = value;
  }

  [XmlAnyAttribute]
  public XmlAttribute[] AnyAttr
  {
    get => this.anyAttrField;
    set => this.anyAttrField = value;
  }
}
