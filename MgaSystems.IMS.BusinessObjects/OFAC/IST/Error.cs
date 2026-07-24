// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.OFAC.IST.Error
// Assembly: MgaSystems.IMS.BusinessObjects, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: BAE231E6-4F60-443A-9930-E3F7CC50C186
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.BusinessObjects.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.BusinessObjects.OFAC.IST;

[GeneratedCode("System.Xml", "4.8.3752.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.intelligentsearch.com/HostedWebServices/")]
[Serializable]
public class Error
{
  private string nameField;
  private string stackTraceField;
  private string messageField;
  private bool showMessageInUserInterfaceField;

  public string Name
  {
    get => this.nameField;
    set => this.nameField = value;
  }

  public string StackTrace
  {
    get => this.stackTraceField;
    set => this.stackTraceField = value;
  }

  public string Message
  {
    get => this.messageField;
    set => this.messageField = value;
  }

  public bool ShowMessageInUserInterface
  {
    get => this.showMessageInUserInterfaceField;
    set => this.showMessageInUserInterfaceField = value;
  }
}
