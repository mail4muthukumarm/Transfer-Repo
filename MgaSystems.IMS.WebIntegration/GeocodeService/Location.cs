// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.GeocodeService.Location
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

[XmlInclude(typeof (GeocodeLocation))]
[XmlInclude(typeof (UserLocation))]
[GeneratedCode("System.Xml", "4.7.2102.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://dev.virtualearth.net/webservices/v1/common")]
[Serializable]
public class Location
{
  private double altitudeField;
  private bool altitudeFieldSpecified;
  private double latitudeField;
  private bool latitudeFieldSpecified;
  private double longitudeField;
  private bool longitudeFieldSpecified;

  public double Altitude
  {
    get => this.altitudeField;
    set => this.altitudeField = value;
  }

  [XmlIgnore]
  public bool AltitudeSpecified
  {
    get => this.altitudeFieldSpecified;
    set => this.altitudeFieldSpecified = value;
  }

  public double Latitude
  {
    get => this.latitudeField;
    set => this.latitudeField = value;
  }

  [XmlIgnore]
  public bool LatitudeSpecified
  {
    get => this.latitudeFieldSpecified;
    set => this.latitudeFieldSpecified = value;
  }

  public double Longitude
  {
    get => this.longitudeField;
    set => this.longitudeField = value;
  }

  [XmlIgnore]
  public bool LongitudeSpecified
  {
    get => this.longitudeFieldSpecified;
    set => this.longitudeFieldSpecified = value;
  }
}
