// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.GeocodeService.SizeOfint
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.GeocodeService;

[GeneratedCode("System.Xml", "4.7.2102.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://dev.virtualearth.net/webservices/v1/common")]
[Serializable]
public class SizeOfint
{
  private int heightField;
  private bool heightFieldSpecified;
  private int widthField;
  private bool widthFieldSpecified;

  public int Height
  {
    get => this.heightField;
    set => this.heightField = value;
  }

  [XmlIgnore]
  public bool HeightSpecified
  {
    get => this.heightFieldSpecified;
    set => this.heightFieldSpecified = value;
  }

  public int Width
  {
    get => this.widthField;
    set => this.widthField = value;
  }

  [XmlIgnore]
  public bool WidthSpecified
  {
    get => this.widthFieldSpecified;
    set => this.widthFieldSpecified = value;
  }
}
