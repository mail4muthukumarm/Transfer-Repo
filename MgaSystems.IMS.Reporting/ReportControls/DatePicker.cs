// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.DatePicker
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting.ReportControls;

public class DatePicker : BaseReportControl, IOfflineReportIncrementSupport, IOfflineReportControl
{
  private IContainer components;
  private bool _DateOptional;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("dtp")]
  internal virtual MGADateTimePicker dtp { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.dtp = new MGADateTimePicker();
    ((ISupportInitialize) this.dtp).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(88, 28);
    appearance1.BorderColor = Color.Gray;
    this.dtp.Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.LightGray;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.LightGray;
    appearance2.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtp.ButtonAppearance = (AppearanceBase) appearance2;
    this.dtp.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtp).Location = new Point(88, 6);
    ((Control) this.dtp).Name = "dtp";
    ((Control) this.dtp).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.dtp).TabIndex = 1;
    ((UltraControlBase) this.dtp).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtp).UseOsThemes = (DefaultableBoolean) 2;
    this.dtp.Value = (object) null;
    this.Controls.Add((Control) this.dtp);
    this.Name = nameof (DatePicker);
    this.Size = new Size(192 /*0xC0*/, 30);
    this.Controls.SetChildIndex((Control) this.dtp, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    ((ISupportInitialize) this.dtp).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public DatePicker(string labelText, DateTime InitialDate, bool dateOptional)
  {
    this.InitializeComponent();
    this.Description = labelText;
    this.dtp.Value = (object) InitialDate;
    this._DateOptional = dateOptional;
    this.InitialSize = this.Size;
  }

  public DatePicker(string labelText, bool dateOptional)
  {
    this.InitializeComponent();
    this.Description = labelText;
    this._DateOptional = dateOptional;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get => Interaction.IIf(this.dtp.Value == null, (object) null, (object) this.dtp.DateTime.Date);
    set
    {
      if (value == null)
        this.dtp.Value = (object) null;
      else
        this.dtp.Value = (object) (DateTime) value;
    }
  }

  public override string InputErrorMessage
  {
    get
    {
      return this._DateOptional || this.dtp.Value != null ? string.Empty : "Please enter a valid date.";
    }
  }

  public override void Compress()
  {
    ((Control) this.dtp).Top = 0;
    this.lblDescription.Height = ((Control) this.dtp).Height;
    this.lblDescription.Top = 0;
    this.Height = ((Control) this.dtp).Height;
  }

  public bool SupportsDate => true;

  public bool SupportsDateRange => false;

  public void SetReportControlValue(object value)
  {
    if (value is object[] || value == null)
      return;
    this.dtp.DateTime = Conversions.ToDate(value);
  }
}
