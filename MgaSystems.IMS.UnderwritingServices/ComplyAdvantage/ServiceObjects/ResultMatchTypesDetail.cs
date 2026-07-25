// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.ResultMatchTypesDetail
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public class ResultMatchTypesDetail
{
  [JsonProperty("matching_name")]
  public string MatchingName { get; set; }

  [JsonProperty("sources")]
  public List<string> Sources { get; set; }

  [JsonProperty("aml_types")]
  public List<string> AmlTypes { get; set; }

  [JsonProperty("name_matches")]
  public List<ResultMatch> NameMatches { get; set; }

  [JsonProperty("secondary_matches")]
  public List<ResultMatch> SecondaryMatches { get; set; }
}
