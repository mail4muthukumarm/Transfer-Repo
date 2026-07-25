// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.TelematicsSendVehicleResponse
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;
using System.Collections.Generic;

#nullable disable
namespace MGASystems.Common.Telematics;

public class TelematicsSendVehicleResponse
{
  public string FairScore { get; set; }

  public string Mileage { get; set; }

  public DateTime LastUpdate { get; set; }

  public bool IsError { get; set; }

  public List<string> Vehicles { get; set; }

  public TelematicsSendVehicleResponse(
    string fairScore,
    string mileage,
    DateTime lastUpdate,
    bool isError)
  {
    this.FairScore = fairScore;
    this.Mileage = mileage;
    this.LastUpdate = lastUpdate;
    this.IsError = isError;
    this.Vehicles = new List<string>();
  }
}
