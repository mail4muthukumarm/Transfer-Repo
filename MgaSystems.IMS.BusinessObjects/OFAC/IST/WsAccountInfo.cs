// Decompiled with JetBrains decompiler
// Type: MGASystems.BusinessObjects.OFAC.IST.WsAccountInfo
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
