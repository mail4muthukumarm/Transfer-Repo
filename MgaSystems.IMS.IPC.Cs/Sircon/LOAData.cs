// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Sircon.LOAData
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Sircon;

public class LOAData
{
  private DateTime _StatusDate;
  private DateTime _ExpirationDate;

  public string Type { get; set; }

  public string State { get; set; }

  public string Status { get; set; }

  public DateTime StatusDate
  {
    get => this._StatusDate;
    set => this._StatusDate = Utilities.defaultInvalidDate(value);
  }

  public DateTime ExpirationDate
  {
    get => this._ExpirationDate;
    set => this._ExpirationDate = Utilities.defaultInvalidDate(value);
  }
}
