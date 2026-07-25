// Decompiled with JetBrains decompiler
// Type: MgaSystems.IMS.UnderwritingServices.GeoCode.ServiceObjects.DistanceResult
// Assembly: MgaSystems.IMS.UnderwritingServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 4E63F408-1B27-4004-B8D3-2C6361F8A9AF
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.UnderwritingServices.dll

using Newtonsoft.Json;
using System;

#nullable disable
namespace MgaSystems.IMS.UnderwritingServices.GeoCode.ServiceObjects;

public class DistanceResult
{
  [JsonProperty("status")]
  public string Status { get; set; }

  [JsonProperty("fromlatitude")]
  public Decimal? Latitude { get; set; }

  [JsonProperty("fromlongitude")]
  public Decimal? FromLongitude { get; set; }

  [JsonProperty("locationtype")]
  public string LocationType { get; set; }

  [JsonProperty("distancecoastmiles")]
  public Decimal? DistanceCoastMiles { get; set; }

  [JsonProperty("closestdistancelatitude")]
  public Decimal? ClosestDistanceLatitude { get; set; }

  [JsonProperty("closestdistancelongitude")]
  public Decimal? ClosestDistanceLongitude { get; set; }

  [JsonProperty("elevationstart")]
  public Decimal? ElevationStart { get; set; }

  [JsonProperty("elevationend")]
  public Decimal? ElevationEnd { get; set; }

  [JsonProperty("underwriting")]
  public string Underwriting { get; set; }

  [JsonIgnore]
  public Exception Error { get; set; }

  [JsonIgnore]
  public string RawResponse { get; set; }
}
