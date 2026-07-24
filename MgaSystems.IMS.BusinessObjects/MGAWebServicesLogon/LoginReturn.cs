// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.MGAWebServicesLogon.LoginReturn
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.BusinessObjects.MGAWebServicesLogon;

[GeneratedCode("System.Xml", "4.7.2053.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://tempuri.org/IMSWebServices/Logon")]
[Serializable]
public class LoginReturn
{
  private Guid userGuidField;
  private Guid tokenField;

  public Guid UserGuid
  {
    get => this.userGuidField;
    set => this.userGuidField = value;
  }

  public Guid Token
  {
    get => this.tokenField;
    set => this.tokenField = value;
  }
}
