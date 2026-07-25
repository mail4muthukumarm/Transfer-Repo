// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.ImageryService.MapUriOptions
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
public class MapUriOptions
{
  private string[] displayLayersField;
  private SizeOfint imageSizeField;
  private ImageType imageTypeField;
  private bool imageTypeFieldSpecified;
  private bool preventIconCollisionField;
  private bool preventIconCollisionFieldSpecified;
  private MapStyle styleField;
  private bool styleFieldSpecified;
  private UriScheme uriSchemeField;
  private bool uriSchemeFieldSpecified;
  private int? zoomLevelField;
  private bool zoomLevelFieldSpecified;

  [XmlArray(IsNullable = true)]
  [XmlArrayItem(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
  public string[] DisplayLayers
  {
    get => this.displayLayersField;
    set => this.displayLayersField = value;
  }

  [XmlElement(IsNullable = true)]
  public SizeOfint ImageSize
  {
    get => this.imageSizeField;
    set => this.imageSizeField = value;
  }

  public ImageType ImageType
  {
    get => this.imageTypeField;
    set => this.imageTypeField = value;
  }

  [XmlIgnore]
  public bool ImageTypeSpecified
  {
    get => this.imageTypeFieldSpecified;
    set => this.imageTypeFieldSpecified = value;
  }

  public bool PreventIconCollision
  {
    get => this.preventIconCollisionField;
    set => this.preventIconCollisionField = value;
  }

  [XmlIgnore]
  public bool PreventIconCollisionSpecified
  {
    get => this.preventIconCollisionFieldSpecified;
    set => this.preventIconCollisionFieldSpecified = value;
  }

  public MapStyle Style
  {
    get => this.styleField;
    set => this.styleField = value;
  }

  [XmlIgnore]
  public bool StyleSpecified
  {
    get => this.styleFieldSpecified;
    set => this.styleFieldSpecified = value;
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
