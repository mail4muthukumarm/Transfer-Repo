// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Sircon.LicenseData
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using System;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Sircon;

public class LicenseData
{
  private DateTime _ExpirationDate;

  public string Type { get; set; }

  public string State { get; set; }

  public string Status { get; set; }

  public DateTime ExpirationDate
  {
    get => this._ExpirationDate;
    set => this._ExpirationDate = Utilities.defaultInvalidDate(value);
  }

  public string Number { get; set; }
}
