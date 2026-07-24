// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.Reliable.SOAPHeaderAuth
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.Reliable;

[GeneratedCode("System.Xml", "4.6.1586.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://tempuri.org/ReliableInspectionsService/Request")]
[XmlRoot(Namespace = "http://tempuri.org/ReliableInspectionsService/Request", IsNullable = false)]
[Serializable]
public class SOAPHeaderAuth : SoapHeader
{
  private string userNameField;
  private string passwordField;

  public string UserName
  {
    get => this.userNameField;
    set => this.userNameField = value;
  }

  public string Password
  {
    get => this.passwordField;
    set => this.passwordField = value;
  }
}
