// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.SpeedGauge.VehiclePolicies.VehiclePolicies
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.Telematics.SpeedGauge.VehiclePolicies;

public class VehiclePolicies
{
  public Links links { get; set; }

  public List<Data> data { get; set; }

  public List<Included> included { get; set; }

  public Meta meta { get; set; }
}
