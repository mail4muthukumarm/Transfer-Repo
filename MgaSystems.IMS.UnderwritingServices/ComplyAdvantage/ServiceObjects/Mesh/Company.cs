// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.Company
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class Company
{
  [JsonProperty("legal_name")]
  public string LegalName { get; set; }

  [JsonProperty("address")]
  public Address[] Addresses { get; set; }

  [JsonProperty("alias")]
  public string[] Aliases { get; set; }

  [JsonProperty("company_type")]
  public string CompanyType { get; set; }

  [JsonProperty("incorporation_date")]
  public DateValue IncorporationDate { get; set; }

  [JsonProperty("industry")]
  public string Industry { get; set; }

  [JsonProperty("place_of_registration")]
  public string PlaceOfRegistration { get; set; }

  [JsonProperty("registration_authority_identification")]
  public string RegistrationAuthorityIdentification { get; set; }

  [JsonProperty("status_summary")]
  public string StatusSummary { get; set; }
}
