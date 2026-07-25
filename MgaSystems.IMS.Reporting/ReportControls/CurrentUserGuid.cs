// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.CurrentUserGuid
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using MGASystems.Common;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class CurrentUserGuid : BaseReportControl
{
  private IContainer components;
  private Guid loCurrentUserGuid;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.SuspendLayout();
    this.Name = nameof (CurrentUserGuid);
    this.Size = new Size(392, 32 /*0x20*/);
    this.ResumeLayout(false);
  }

  public CurrentUserGuid()
  {
    this.InitializeComponent();
    this.Description = "";
    this.Height = 0;
    this.InitialSize = this.Size;
    this.loCurrentUserGuid = CurrentUser.Instance.UserGUID;
  }

  public override object Value
  {
    get => (object) this.loCurrentUserGuid;
    set => this.loCurrentUserGuid = CurrentUser.Instance.UserGUID;
  }

  public override void Compress()
  {
  }
}
