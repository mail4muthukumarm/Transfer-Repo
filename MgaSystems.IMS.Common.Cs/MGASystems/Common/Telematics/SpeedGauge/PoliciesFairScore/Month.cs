// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.SpeedGauge.PoliciesFairScore.Month
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

using System;

#nullable disable
namespace MGASystems.Common.Telematics.SpeedGauge.PoliciesFairScore;

public class Month
{
  public int? score { get; set; }

  public double mileage { get; set; }

  public string url { get; set; }

  public DateTime date { get; set; }
}
