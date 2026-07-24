// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RCT.LocationsLocation
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.RCT;

[GeneratedCode("xsd", "4.8.3928.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[Serializable]
public class LocationsLocation
{
  private string locationUniqueIDField;
  private string locationNumberField;
  private string locationCode2Field;
  private string locationTypeField;
  private string locationDescriptionField;
  private Address addressField;

  public string LocationUniqueID
  {
    get => this.locationUniqueIDField;
    set => this.locationUniqueIDField = value;
  }

  public string LocationNumber
  {
    get => this.locationNumberField;
    set => this.locationNumberField = value;
  }

  public string LocationCode2
  {
    get => this.locationCode2Field;
    set => this.locationCode2Field = value;
  }

  public string LocationType
  {
    get => this.locationTypeField;
    set => this.locationTypeField = value;
  }

  public string LocationDescription
  {
    get => this.locationDescriptionField;
    set => this.locationDescriptionField = value;
  }

  public Address Address
  {
    get => this.addressField;
    set => this.addressField = value;
  }
}
