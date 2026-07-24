// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.Controls.DateSpanPicker
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using MGASystems.Common.MVC.Utility;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.Controls;

public class DateSpanPicker : UserControl
{
  private readonly BlockingRunner _setValueRunner = new BlockingRunner()
  {
    IgnoreInvocationIfRunning = true
  };
  private IContainer components;
  private MGADateTimePicker dStart;
  private FlowLayoutPanel flowLayoutPanel1;
  private Label lTo;
  private MGADateTimePicker dEnd;

  public DateSpanPicker() => this.InitializeComponent();

  public DateTime StartDate
  {
    get => this.dStart.DateTime;
    set => this.dStart.DateTime = value;
  }

  public DateTime EndDate
  {
    get => this.dEnd.DateTime;
    set => this.dEnd.DateTime = value;
  }

  public DateSpan DateSpan
  {
    get => new DateSpan(this.StartDate, this.EndDate);
    set
    {
      this._setValueRunner.Run((Action) (() =>
      {
        this.StartDate = value.Start;
        this.EndDate = value.End;
      }));
    }
  }

  private void Start_ValueChanged(object sender, EventArgs e)
  {
    this._setValueRunner.Run((Action) (() =>
    {
      EventHandler valueChanged = this.ValueChanged;
      if (valueChanged == null)
        return;
      valueChanged((object) this, EventArgs.Empty);
    }));
  }

  private void End_ValueChanged(object sender, EventArgs e)
  {
    this._setValueRunner.Run((Action) (() =>
    {
      EventHandler valueChanged = this.ValueChanged;
      if (valueChanged == null)
        return;
      valueChanged((object) this, EventArgs.Empty);
    }));
  }

  public event EventHandler ValueChanged;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.dStart = new MGADateTimePicker();
    this.flowLayoutPanel1 = new FlowLayoutPanel();
    this.lTo = new Label();
    this.dEnd = new MGADateTimePicker();
    ((ISupportInitialize) this.dStart).BeginInit();
    this.flowLayoutPanel1.SuspendLayout();
    ((ISupportInitialize) this.dEnd).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dStart.Appearance = (AppearanceBase) appearance1;
    ((AppearanceBase) appearance2).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance2).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance2).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance2).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    this.dStart.ButtonAppearance = (AppearanceBase) appearance2;
    this.dStart.DateTime = new DateTime(2023, 6, 3, 0, 0, 0, 0);
    ((Control) this.dStart).Location = new Point(3, 0);
    ((Control) this.dStart).Margin = new Padding(3, 0, 3, 0);
    this.dStart.MGAStyle = MGAStyles.Blue;
    ((Control) this.dStart).Name = "dStart";
    ((Control) this.dStart).Size = new Size(83, 19);
    ((Control) this.dStart).TabIndex = 7;
    ((UltraControlBase) this.dStart).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dStart).UseOsThemes = (DefaultableBoolean) 2;
    this.dStart.Value = (object) new DateTime(2023, 6, 3, 0, 0, 0, 0);
    this.dStart.ValueChanged += new EventHandler(this.Start_ValueChanged);
    this.flowLayoutPanel1.Controls.Add((Control) this.dStart);
    this.flowLayoutPanel1.Controls.Add((Control) this.lTo);
    this.flowLayoutPanel1.Controls.Add((Control) this.dEnd);
    this.flowLayoutPanel1.Dock = DockStyle.Fill;
    this.flowLayoutPanel1.Location = new Point(0, 0);
    this.flowLayoutPanel1.Margin = new Padding(3, 0, 3, 0);
    this.flowLayoutPanel1.Name = "flowLayoutPanel1";
    this.flowLayoutPanel1.Size = new Size(210, 21);
    this.flowLayoutPanel1.TabIndex = 8;
    this.lTo.AutoSize = true;
    this.lTo.Location = new Point(92, 1);
    this.lTo.Margin = new Padding(3, 1, 3, 1);
    this.lTo.Name = "lTo";
    this.lTo.Size = new Size(16 /*0x10*/, 13);
    this.lTo.TabIndex = 8;
    this.lTo.Text = "to";
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dEnd.Appearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance4).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance4).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance4).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance4).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance4).ForegroundAlpha = (Alpha) 2;
    this.dEnd.ButtonAppearance = (AppearanceBase) appearance4;
    this.dEnd.DateTime = new DateTime(2023, 6, 3, 0, 0, 0, 0);
    ((Control) this.dEnd).Location = new Point(114, 0);
    ((Control) this.dEnd).Margin = new Padding(3, 0, 3, 0);
    this.dEnd.MGAStyle = MGAStyles.Blue;
    ((Control) this.dEnd).Name = "dEnd";
    ((Control) this.dEnd).Size = new Size(83, 19);
    ((Control) this.dEnd).TabIndex = 9;
    ((UltraControlBase) this.dEnd).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dEnd).UseOsThemes = (DefaultableBoolean) 2;
    this.dEnd.Value = (object) new DateTime(2023, 6, 3, 0, 0, 0, 0);
    this.dEnd.ValueChanged += new EventHandler(this.End_ValueChanged);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.flowLayoutPanel1);
    this.Name = nameof (DateSpanPicker);
    this.Size = new Size(210, 21);
    ((ISupportInitialize) this.dStart).EndInit();
    this.flowLayoutPanel1.ResumeLayout(false);
    this.flowLayoutPanel1.PerformLayout();
    ((ISupportInitialize) this.dEnd).EndInit();
    this.ResumeLayout(false);
  }
}
