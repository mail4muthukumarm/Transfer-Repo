// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.ImageryService.ImageryMetadataOptions
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
[XmlType(Namespace = "http://dev.virtualearth.net/webservices/v1/imagery")]
[Serializable]
public class ImageryMetadataOptions
{
  private Heading headingField;
  private Location locationField;
  private bool returnImageryProvidersField;
  private bool returnImageryProvidersFieldSpecified;
  private UriScheme uriSchemeField;
  private bool uriSchemeFieldSpecified;
  private int? zoomLevelField;
  private bool zoomLevelFieldSpecified;

  [XmlElement(IsNullable = true)]
  public Heading Heading
  {
    get => this.headingField;
    set => this.headingField = value;
  }

  [XmlElement(IsNullable = true)]
  public Location Location
  {
    get => this.locationField;
    set => this.locationField = value;
  }

  public bool ReturnImageryProviders
  {
    get => this.returnImageryProvidersField;
    set => this.returnImageryProvidersField = value;
  }

  [XmlIgnore]
  public bool ReturnImageryProvidersSpecified
  {
    get => this.returnImageryProvidersFieldSpecified;
    set => this.returnImageryProvidersFieldSpecified = value;
  }

  public UriScheme UriScheme
  {
    get => this.uriSchemeField;
    set => this.uriSchemeField = value;
  }

  [XmlIgnore]
  public bool UriSchemeSpecified
  {
    get => this.uriSchemeFieldSpecified;
    set => this.uriSchemeFieldSpecified = value;
  }

  [XmlElement(IsNullable = true)]
  public int? ZoomLevel
  {
    get => this.zoomLevelField;
    set => this.zoomLevelField = value;
  }

  [XmlIgnore]
  public bool ZoomLevelSpecified
  {
    get => this.zoomLevelFieldSpecified;
    set => this.zoomLevelFieldSpecified = value;
  }
}
