// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.CreateAndScreenRequest
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class CreateAndScreenRequest
{
  public CreateAndScreenRequest(
    Guid searchConfiguration,
    string entityIdentifier,
    string firstName,
    string lastName,
    string middleName = null,
    DateTime? dateOfBirth = null,
    string address1 = null,
    string address2 = null,
    string city = null,
    string country = null,
    string postal = null,
    AddressType addressType = AddressType.None)
  {
    this.Configuration = new Configuration()
    {
      ScreeningConfigurationIdentifier = new Guid?(searchConfiguration)
    };
    this.Customer = new Customer()
    {
      Person = new Person()
      {
        FirstName = firstName,
        LastName = lastName,
        MiddleName = middleName,
        DateOfBirth = (DateValue) dateOfBirth,
        Addresses = Address.SingleIfSpecified(address1, address2, city, country, postal, addressType)
      }
    };
  }

  public CreateAndScreenRequest(
    Guid searchConfiguration,
    string entityIdentifier,
    string legalName,
    string[] aliases = null,
    string address1 = null,
    string address2 = null,
    string city = null,
    string country = null,
    string postal = null,
    AddressType addressType = AddressType.None)
  {
    this.Configuration = new Configuration()
    {
      ScreeningConfigurationIdentifier = new Guid?(searchConfiguration)
    };
    this.Customer = new Customer()
    {
      Company = new Company()
      {
        LegalName = legalName,
        Aliases = aliases,
        Addresses = Address.SingleIfSpecified(address1, address2, city, country, postal, addressType)
      }
    };
  }

  [JsonProperty("customer")]
  public Customer Customer { get; set; }

  [JsonProperty("configuration")]
  public Configuration Configuration { get; set; }

  [JsonProperty("monitoring")]
  public Monitoring Monitoring { get; set; }

  [JsonProperty("product")]
  public MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.Product[] Product { get; set; }

  [JsonIgnore]
  public string LastSyncStep { get; set; }
}
