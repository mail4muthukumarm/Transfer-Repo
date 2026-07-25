// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.RCT.Address
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections.RCT;

[GeneratedCode("xsd", "4.8.3928.0")]
[DebuggerStepThrough]
[DesignerCategory("code")]
[XmlType(AnonymousType = true)]
[XmlRoot(Namespace = "", IsNullable = false)]
[Serializable]
public class Address
{
  private string addressLineField;
  private string cityField;
  private object itemField;
  private string countyField;
  private string item1Field;
  private Item1ChoiceType item1ElementNameField;
  private AddressCountry countryField;

  public string AddressLine
  {
    get => this.addressLineField;
    set => this.addressLineField = value;
  }

  public string City
  {
    get => this.cityField;
    set => this.cityField = value;
  }

  [XmlElement("CA-Province", typeof (CAProvince))]
  [XmlElement("INTL-Province", typeof (string))]
  [XmlElement("US-Province", typeof (USProvince))]
  public object Item
  {
    get => this.itemField;
    set => this.itemField = RuntimeHelpers.GetObjectValue(value);
  }

  public string County
  {
    get => this.countyField;
    set => this.countyField = value;
  }

  [XmlElement("CA-PostalCode", typeof (string))]
  [XmlElement("INTL-PostalCode", typeof (string))]
  [XmlElement("US-PostalCode", typeof (string))]
  [XmlChoiceIdentifier("Item1ElementName")]
  public string Item1
  {
    get => this.item1Field;
    set => this.item1Field = value;
  }

  [XmlIgnore]
  public Item1ChoiceType Item1ElementName
  {
    get => this.item1ElementNameField;
    set => this.item1ElementNameField = value;
  }

  public AddressCountry Country
  {
    get => this.countryField;
    set => this.countryField = value;
  }
}
