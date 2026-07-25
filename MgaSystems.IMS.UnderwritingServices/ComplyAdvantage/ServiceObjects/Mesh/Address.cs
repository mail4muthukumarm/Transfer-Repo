// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.Address
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class Address
{
  [JsonProperty("address_line1")]
  public string Address1 { get; set; }

  [JsonProperty("address_line2")]
  public string Address2 { get; set; }

  [JsonProperty("country")]
  public string CountryCode { get; set; }

  [JsonProperty("country_subdivision")]
  public string CountrySubdivision { get; set; }

  [JsonProperty("postal_code")]
  public string PostalCode { get; set; }

  [JsonProperty("town_name")]
  public string TownName { get; set; }

  [JsonProperty("type")]
  [JsonConverter(typeof (StringNullEnumConverter), new object[] {AddressType.None})]
  public AddressType Type { get; set; }

  public static Address[] SingleIfSpecified(
    string address1 = null,
    string address2 = null,
    string city = null,
    string country = null,
    string postal = null,
    AddressType addressType = AddressType.None)
  {
    if (addressType == AddressType.None)
      return (Address[]) null;
    return new Address[1]
    {
      new Address()
      {
        Address1 = address1,
        Address2 = address2,
        TownName = city,
        PostalCode = postal,
        CountryCode = country,
        Type = addressType
      }
    };
  }
}
