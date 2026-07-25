// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.SpeedGauge.Data
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

#nullable disable
namespace MGASystems.Common.Telematics.SpeedGauge;

public class Data
{
  public Attributes attributes { get; set; }

  public Relationships relationships { get; set; }

  public string type { get; set; }

  public string id { get; set; }
}
