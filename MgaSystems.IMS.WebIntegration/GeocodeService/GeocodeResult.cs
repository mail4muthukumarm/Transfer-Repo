// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.GeocodeService.GeocodeResult
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
public class GeocodeResult
{
  private Address addressField;
  private Rectangle bestViewField;
  private Confidence confidenceField;
  private bool confidenceFieldSpecified;
  private string displayNameField;
  private string entityTypeField;
  private GeocodeLocation[] locationsField;
  private string[] matchCodesField;

  [XmlElement(IsNullable = true)]
  public Address Address
  {
    get => this.addressField;
    set => this.addressField = value;
  }

  [XmlElement(IsNullable = true)]
  public Rectangle BestView
  {
    get => this.bestViewField;
    set => this.bestViewField = value;
  }

  public Confidence Confidence
  {
    get => this.confidenceField;
    set => this.confidenceField = value;
  }

  [XmlIgnore]
  public bool ConfidenceSpecified
  {
    get => this.confidenceFieldSpecified;
    set => this.confidenceFieldSpecified = value;
  }

  [XmlElement(IsNullable = true)]
  public string DisplayName
  {
    get => this.displayNameField;
    set => this.displayNameField = value;
  }

  [XmlElement(IsNullable = true)]
  public string EntityType
  {
    get => this.entityTypeField;
    set => this.entityTypeField = value;
  }

  [XmlArray(IsNullable = true)]
  public GeocodeLocation[] Locations
  {
    get => this.locationsField;
    set => this.locationsField = value;
  }

  [XmlArray(IsNullable = true)]
  [XmlArrayItem(Namespace = "http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
  public string[] MatchCodes
  {
    get => this.matchCodesField;
    set => this.matchCodesField = value;
  }
}
