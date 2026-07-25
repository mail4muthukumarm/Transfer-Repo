// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.SearchFilters
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using MgaSystems.IMS.UnderwritingServices.Serializer;
using Newtonsoft.Json;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public class SearchFilters
{
  public static readonly SearchFilters DefaultFilters = new SearchFilters()
  {
    Types = new List<string>() { "sanction", "pep" }
  };

  [JsonProperty("types")]
  public List<string> Types { get; set; }

  [JsonProperty("birth_year")]
  public string BirthYear { get; set; }

  [JsonProperty("remove_deceased")]
  [JsonConverter(typeof (BooleanIntConverter), new object[] {true})]
  public bool? RemoveDeceased { get; set; }

  [JsonProperty("country_codes")]
  public List<string> CountryCodes { get; set; }

  [JsonProperty("entity_type")]
  public string EntityType { get; set; }

  [JsonProperty("passport")]
  public string Passport { get; set; }
}
