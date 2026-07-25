// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.GeocodeService.Circle
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
public class Circle : ShapeBase
{
  private Location centerField;
  private DistanceUnit distanceUnitField;
  private bool distanceUnitFieldSpecified;
  private double radiusField;
  private bool radiusFieldSpecified;

  [XmlElement(IsNullable = true)]
  public Location Center
  {
    get => this.centerField;
    set => this.centerField = value;
  }

  public DistanceUnit DistanceUnit
  {
    get => this.distanceUnitField;
    set => this.distanceUnitField = value;
  }

  [XmlIgnore]
  public bool DistanceUnitSpecified
  {
    get => this.distanceUnitFieldSpecified;
    set => this.distanceUnitFieldSpecified = value;
  }

  public double Radius
  {
    get => this.radiusField;
    set => this.radiusField = value;
  }

  [XmlIgnore]
  public bool RadiusSpecified
  {
    get => this.radiusFieldSpecified;
    set => this.radiusFieldSpecified = value;
  }
}
