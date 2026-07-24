// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Services.ISTWatchWebService.WsAccountInfo
// Assembly: MgaSystems.IMS.Common, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 46CE8D79-2C19-419C-BC23-F8C69E623B17
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.Common.Services.ISTWatchWebService;

[GeneratedCode("System.Xml", "4.7.2556.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://www.intelligentsearch.com/HostedWebServices/")]
[Serializable]
public class WsAccountInfo
{
  private int searchesLeftField;
  private int returnCodeField;

  public int SearchesLeft
  {
    get => this.searchesLeftField;
    set => this.searchesLeftField = value;
  }

  public int ReturnCode
  {
    get => this.returnCodeField;
    set => this.returnCodeField = value;
  }
}
