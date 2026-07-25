// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.ImageryService.ImageryMetadataResult
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

[XmlInclude(typeof (ImageryMetadataBirdseyeResult))]
[GeneratedCode("System.Xml", "4.6.1586.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(Namespace = "http://dev.virtualearth.net/webservices/v1/imagery")]
[Serializable]
public class ImageryMetadataResult
{
  private SizeOfint imageSizeField;
  private string imageUriField;
  private string[] imageUriSubdomainsField;
  private ImageryProvider[] imageryProvidersField;
  private RangeOfdateTime vintageField;
  private RangeOfint zoomRangeField;

  [XmlElement(IsNullable = true)]
  public SizeOfint ImageSize
  {
    get => this.imageSizeField;
    set => this.imageSizeField = value;
  }

  [XmlElement(IsNullable = true)]
  public string ImageUri
  {
    get => this.imageUriField;
    set => this.imageUriField = value;
  }

  [XmlArray(IsNullable = true)]
  [XmlArrayItem(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
  public string[] ImageUriSubdomains
  {
    get => this.imageUriSubdomainsField;
    set => this.imageUriSubdomainsField = value;
  }

  [XmlArray(IsNullable = true)]
  public ImageryProvider[] ImageryProviders
  {
    get => this.imageryProvidersField;
    set => this.imageryProvidersField = value;
  }

  [XmlElement(IsNullable = true)]
  public RangeOfdateTime Vintage
  {
    get => this.vintageField;
    set => this.vintageField = value;
  }

  [XmlElement(IsNullable = true)]
  public RangeOfint ZoomRange
  {
    get => this.zoomRangeField;
    set => this.zoomRangeField = value;
  }
}
