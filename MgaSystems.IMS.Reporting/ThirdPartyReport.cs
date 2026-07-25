// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ThirdPartyReport
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
public class ThirdPartyReport : Form
{
  private IContainer components;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.SuspendLayout();
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(504, 273);
    this.Name = nameof (ThirdPartyReport);
    this.ShowIcon = false;
    this.ShowInTaskbar = false;
    this.Text = nameof (ThirdPartyReport);
    this.ResumeLayout(false);
  }

  public ThirdPartyReport() => this.InitializeComponent();
}
