// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Sircon.SirconLog
// Assembly: MgaSystems.IMS.IPC.Cs, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 902BD8FA-9BAE-43A4-A4AA-C9585D23F16B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.Cs.dll

using MGASystems.Common;
using System;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Sircon;

public class SirconLog
{
  private readonly Guid _sirconLogEntryGuid = new Guid("CE286A2D-B6D1-4461-BDBA-D1135197DB85");

  public bool IsEnabled { get; }

  private string Section { get; set; } = string.Empty;

  public SirconLog() => this.IsEnabled = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("SirconLogEnabled");

  public void WriteMsg(string message)
  {
    if (!this.IsEnabled)
      return;
    CurrentUser.Instance.LogAction($"Sircon: {this.Section} - {message}", this._sirconLogEntryGuid);
  }

  public void WriteSeparator(string header) => this.Section = header;
}
