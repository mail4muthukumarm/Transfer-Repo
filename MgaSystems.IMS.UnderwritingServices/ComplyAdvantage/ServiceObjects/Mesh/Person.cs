// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.Person
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh;

public class Person
{
  [JsonProperty("last_name")]
  public string LastName { get; set; }

  [JsonProperty("address")]
  public Address[] Addresses { get; set; }

  [JsonProperty("contact_information")]
  public ContactInformation ContactInformation { get; set; }

  [JsonProperty("country_of_birth")]
  public string CountryOfBirth { get; set; }

  [JsonProperty("date_of_birth")]
  public DateValue DateOfBirth { get; set; }

  [JsonProperty("fathers_name")]
  public string FathersName { get; set; }

  [JsonProperty("first_name")]
  public string FirstName { get; set; }

  [JsonProperty("full_name")]
  public string FullName { get; set; }

  [JsonProperty("gender")]
  public Gender Gender { get; set; }

  [JsonProperty("middle_name")]
  public string MiddleName { get; set; }

  [JsonProperty("mothers_name")]
  public string MothersName { get; set; }

  [JsonProperty("nationality")]
  public string[] Nationalities { get; set; }

  [JsonProperty("personal_identification")]
  public PersonalIdentification[] PersonalIdentifications { get; set; }

  [JsonProperty("profession")]
  public string[] Professions { get; set; }

  [JsonProperty("residential_information")]
  public MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.Mesh.ResidentialInformation[] ResidentialInformation { get; set; }

  [JsonProperty("salary")]
  public Salary Salary { get; set; }

  [JsonProperty("source_of_wealth")]
  public string SourceOfWealth { get; set; }

  [JsonProperty("suffix")]
  public string Suffix { get; set; }

  [JsonProperty("title")]
  public string Title { get; set; }
}
