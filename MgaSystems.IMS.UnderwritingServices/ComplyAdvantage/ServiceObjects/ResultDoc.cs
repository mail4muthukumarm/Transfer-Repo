// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects.ResultDoc
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.ComplyAdvantage.ServiceObjects;

public class ResultDoc
{
  [JsonProperty("id")]
  public string ID { get; set; }

  [JsonProperty("entity_type")]
  public string EntityType { get; set; }

  [JsonProperty("last_updated_utc")]
  public DateTimeOffset LastUpdatedUtc { get; set; }

  [JsonProperty("name")]
  public string Name { get; set; }

  [JsonProperty("first_name")]
  public string FirstName { get; set; }

  [JsonProperty("middle_names")]
  public string MiddleNames { get; set; }

  [JsonProperty("last_name")]
  public string LastName { get; set; }

  [JsonProperty("sources")]
  public List<string> Sources { get; set; }

  [JsonProperty("types")]
  public List<string> Types { get; set; }

  [JsonProperty("aka")]
  public List<ResultName> Aliases { get; set; }

  [JsonProperty("associates")]
  public List<ResultName> Associates { get; set; }

  [JsonProperty("fields")]
  public List<ResultField> Fields { get; set; }

  [JsonProperty("media")]
  public List<ResultMedium> Media { get; set; }
}
