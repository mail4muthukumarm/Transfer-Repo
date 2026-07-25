// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.ImageryService.RangeOfdateTime
// Assembly: MgaSystems.IMS.WebIntegration, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 82DEE314-E11A-4163-B1B3-C42062AE6494
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.WebIntegration.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MgaSystems.IMS.WebIntegration.ImageryService;

[GeneratedCode("System.Xml", "4.6.1586.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://dev.virtualearth.net/webservices/v1/common")]
[Serializable]
public class RangeOfdateTime
{
  private DateTime fromField;
  private bool fromFieldSpecified;
  private DateTime toField;
  private bool toFieldSpecified;

  public DateTime From
  {
    get => this.fromField;
    set => this.fromField = value;
  }

  [XmlIgnore]
  public bool FromSpecified
  {
    get => this.fromFieldSpecified;
    set => this.fromFieldSpecified = value;
  }

  public DateTime To
  {
    get => this.toField;
    set => this.toField = value;
  }

  [XmlIgnore]
  public bool ToSpecified
  {
    get => this.toFieldSpecified;
    set => this.toFieldSpecified = value;
  }
}
