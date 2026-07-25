// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.SpeedGauge.VehicleDetails.Attributes
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;
using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.Telematics.SpeedGauge.VehicleDetails;

public class Attributes
{
  public string alias { get; set; }

  [JsonProperty("alias-is-editable")]
  public bool AliasIsEditable { get; set; }

  public int category { get; set; }

  [JsonProperty("body-class")]
  public string BodyClass { get; set; }

  public string vin { get; set; }

  public string year { get; set; }

  public string make { get; set; }

  public string model { get; set; }

  public string plate { get; set; }

  public string region { get; set; }

  public object odo { get; set; }

  public string source { get; set; }

  [JsonProperty("created-at")]
  public DateTime CreatedAt { get; set; }

  [JsonProperty("updated-at")]
  public DateTime UpdatedAt { get; set; }

  [JsonProperty("last-crumb-time")]
  public object LastCrumbTime { get; set; }

  public List<Vpic> vpic { get; set; }

  [JsonProperty("has-telematics")]
  public bool HasTelematics { get; set; }

  [JsonProperty("telematics-providers")]
  public List<object> TelematicsProviders { get; set; }

  public string uuid { get; set; }

  public string disposition { get; set; }

  [JsonProperty("is-assigned")]
  public bool IsAssigned { get; set; }

  [JsonProperty("is-locked")]
  public bool IsLocked { get; set; }
}
