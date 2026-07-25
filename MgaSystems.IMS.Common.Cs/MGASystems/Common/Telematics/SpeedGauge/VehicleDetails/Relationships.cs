// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.SpeedGauge.VehicleDetails.Relationships
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using Newtonsoft.Json;

#nullable disable
namespace MGASystems.Common.Telematics.SpeedGauge.VehicleDetails;

public class Relationships
{
  public Company company { get; set; }

  [JsonProperty("device-registrations")]
  public DeviceRegistrations DeviceRegistrations { get; set; }

  [JsonProperty("vehicle-policies")]
  public VehiclePolicies VehiclePolicies { get; set; }
}
