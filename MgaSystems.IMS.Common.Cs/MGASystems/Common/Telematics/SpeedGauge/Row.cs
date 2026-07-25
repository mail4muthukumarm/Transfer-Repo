// Decompiled with JetBrains decompiler
// Type: MGASystems.Common.Telematics.SpeedGauge.Row
// Assembly: MgaSystems.IMS.Common.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EACF02E4-8DD7-4409-97BA-15D5CFE3FE59
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Common.Cs.dll

#nullable disable
namespace MGASystems.Common.Telematics.SpeedGauge;

public class Row
{
  public int id { get; set; }

  public string account { get; set; }

  public int max_vehicles { get; set; }

  public int vehicle_count { get; set; }

  public int reporting_vehicles { get; set; }

  public string status { get; set; }

  public int fair_score { get; set; }

  public int carrier__id { get; set; }

  public string carrier__name { get; set; }

  public int company__id { get; set; }

  public string company__name { get; set; }

  public string company__region { get; set; }

  public string company__naics { get; set; }

  public string company__status { get; set; }

  public string dsa_status { get; set; }

  public bool agency_agreement_is_active { get; set; }

  public object agent__last_name { get; set; }
}
