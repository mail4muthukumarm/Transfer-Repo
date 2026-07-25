// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.ComplyAdvantage.Data.SearchFilters
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.ComplyAdvantage.Data;

public class SearchFilters
{
  public const string Sanction = "sanction";
  public const string PoliticallyExposedPersons = "pep";
  public static readonly List<string> DefaultSearchTypes = new List<string>()
  {
    "sanction",
    "pep"
  };

  [JsonProperty("types")]
  public List<string> Types { get; set; } = SearchFilters.DefaultSearchTypes;
}
