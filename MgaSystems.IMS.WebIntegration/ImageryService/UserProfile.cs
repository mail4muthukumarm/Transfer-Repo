// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.ImageryService.UserProfile
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
public class UserProfile
{
  private Heading currentHeadingField;
  private UserLocation currentLocationField;
  private DeviceType deviceTypeField;
  private bool deviceTypeFieldSpecified;
  private DistanceUnit distanceUnitField;
  private bool distanceUnitFieldSpecified;
  private string iPAddressField;
  private ShapeBase mapViewField;
  private SizeOfint screenSizeField;

  [XmlElement(IsNullable = true)]
  public Heading CurrentHeading
  {
    get => this.currentHeadingField;
    set => this.currentHeadingField = value;
  }

  [XmlElement(IsNullable = true)]
  public UserLocation CurrentLocation
  {
    get => this.currentLocationField;
    set => this.currentLocationField = value;
  }

  public DeviceType DeviceType
  {
    get => this.deviceTypeField;
    set => this.deviceTypeField = value;
  }

  [XmlIgnore]
  public bool DeviceTypeSpecified
  {
    get => this.deviceTypeFieldSpecified;
    set => this.deviceTypeFieldSpecified = value;
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

  [XmlElement(IsNullable = true)]
  public string IPAddress
  {
    get => this.iPAddressField;
    set => this.iPAddressField = value;
  }

  [XmlElement(IsNullable = true)]
  public ShapeBase MapView
  {
    get => this.mapViewField;
    set => this.mapViewField = value;
  }

  [XmlElement(IsNullable = true)]
  public SizeOfint ScreenSize
  {
    get => this.screenSizeField;
    set => this.screenSizeField = value;
  }
}
