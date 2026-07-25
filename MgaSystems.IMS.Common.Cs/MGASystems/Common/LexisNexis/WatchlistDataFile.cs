// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.LexisNexis.WatchlistDataFile
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;

#nullable disable
namespace MGASystems.Common.LexisNexis;

[GeneratedCode("NJsonSchema", "10.2.1.0 (Newtonsoft.Json v11.0.0.0)")]
public class WatchlistDataFile
{
  [JsonProperty("AlwaysGenerateMatchesForCitiesAndPorts")]
  public bool? AlwaysGenerateMatchesForCitiesAndPorts { get; set; }

  [JsonProperty("Custom")]
  public bool? Custom { get; set; }

  [JsonProperty("ID")]
  public Guid? ID { get; set; }

  [JsonProperty("IgnoreWeakAKAs")]
  public bool? IgnoreWeakAKAs { get; set; }

  [JsonProperty("MinScore")]
  public int? MinScore { get; set; }

  [JsonProperty("Name")]
  public string Name { get; set; }

  [JsonProperty("SearchCriteria")]
  public WatchlistSearchCriteria SearchCriteria { get; set; }

  [JsonProperty("TopLevelOperatorIsOr")]
  public bool? TopLevelOperatorIsOr { get; set; }
}
