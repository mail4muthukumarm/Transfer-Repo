// Decompiled with JetBrains decompiler
// Type: CancellationNotices.LogonService.LoginReturn
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace CancellationNotices.LogonService;

[GeneratedCode("System.Xml", "4.7.2556.0")]
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
