// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.WebIntegration.GeocodeService.Address
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
public class Address
{
  private string addressLineField;
  private string adminDistrictField;
  private string countryRegionField;
  private string districtField;
  private string formattedAddressField;
  private string localityField;
  private string postalCodeField;
  private string postalTownField;

  [XmlElement(IsNullable = true)]
  public string AddressLine
  {
    get => this.addressLineField;
    set => this.addressLineField = value;
  }

  [XmlElement(IsNullable = true)]
  public string AdminDistrict
  {
    get => this.adminDistrictField;
    set => this.adminDistrictField = value;
  }

  [XmlElement(IsNullable = true)]
  public string CountryRegion
  {
    get => this.countryRegionField;
    set => this.countryRegionField = value;
  }

  [XmlElement(IsNullable = true)]
  public string District
  {
    get => this.districtField;
    set => this.districtField = value;
  }

  [XmlElement(IsNullable = true)]
  public string FormattedAddress
  {
    get => this.formattedAddressField;
    set => this.formattedAddressField = value;
  }

  [XmlElement(IsNullable = true)]
  public string Locality
  {
    get => this.localityField;
    set => this.localityField = value;
  }

  [XmlElement(IsNullable = true)]
  public string PostalCode
  {
    get => this.postalCodeField;
    set => this.postalCodeField = value;
  }

  [XmlElement(IsNullable = true)]
  public string PostalTown
  {
    get => this.postalTownField;
    set => this.postalTownField = value;
  }
}
