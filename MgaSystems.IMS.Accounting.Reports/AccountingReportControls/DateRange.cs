// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.DateRange
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports.AccountingReportControls;

public sealed class DateRange : BaseReportControl
{
  private IContainer components;
  private DataTable _dt;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("dtpFrom")]
  internal virtual MGADateTimePicker dtpFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpTo")]
  internal virtual MGADateTimePicker dtpTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox combo
  {
    get => this._combo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.combo_ValueChanged);
      MGASimpleComboBox combo1 = this._combo;
      if (combo1 != null)
        combo1.ValueChanged -= eventHandler;
      this._combo = value;
      MGASimpleComboBox combo2 = this._combo;
      if (combo2 == null)
        return;
      combo2.ValueChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.dtpFrom = new MGADateTimePicker();
    this.dtpTo = new MGADateTimePicker();
    this.Label1 = new Label();
    this.combo = new MGASimpleComboBox();
    ((ISupportInitialize) this.dtpFrom).BeginInit();
    ((ISupportInitialize) this.dtpTo).BeginInit();
    ((ISupportInitialize) this.combo).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Location = new Point(0, 1);
    this.lblDescription.Size = new Size(88, 55);
    this.lblDescription.TextAlign = ContentAlignment.TopLeft;
    appearance1.BackColor = Color.LightGray;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.LightGray;
    appearance1.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtpFrom.ButtonAppearance = (AppearanceBase) appearance1;
    ((Control) this.dtpFrom).Enabled = false;
    ((Control) this.dtpFrom).Location = new Point(88, 32 /*0x20*/);
    ((Control) this.dtpFrom).Name = "dtpFrom";
    ((Control) this.dtpFrom).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.dtpFrom).TabIndex = 2;
    ((UltraControlBase) this.dtpFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpFrom).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.LightGray;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.LightGray;
    appearance2.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtpTo.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtpTo).Enabled = false;
    ((Control) this.dtpTo).Location = new Point(216, 32 /*0x20*/);
    ((Control) this.dtpTo).Name = "dtpTo";
    ((Control) this.dtpTo).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.dtpTo).TabIndex = 3;
    ((UltraControlBase) this.dtpTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpTo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(192 /*0xC0*/, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(16 /*0x10*/, 19);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "to";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.combo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.combo.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.combo).Location = new Point(88, 6);
    ((Control) this.combo).Name = "combo";
    ((Control) this.combo).Size = new Size(300, 20);
    ((Control) this.combo).TabIndex = 5;
    ((UltraControlBase) this.combo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.combo).UseOsThemes = (DefaultableBoolean) 2;
    this.Controls.Add((Control) this.combo);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.dtpTo);
    this.Controls.Add((Control) this.dtpFrom);
    this.Name = nameof (DateRange);
    this.Size = new Size(392, 56);
    this.Controls.SetChildIndex((Control) this.dtpFrom, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.dtpTo, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.combo, 0);
    ((ISupportInitialize) this.dtpFrom).EndInit();
    ((ISupportInitialize) this.dtpTo).EndInit();
    ((ISupportInitialize) this.combo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public DateRange(string LabelText)
  {
    this.InitializeComponent();
    this.Description = LabelText;
    this._dt = new DataTable();
    this._dt.Columns.Add("RangeID", typeof (int));
    this._dt.Columns.Add(nameof (DateRange), typeof (string));
    this._dt.Rows.Add((object) 0, (object) "Current Month");
    this._dt.Rows.Add((object) 1, (object) "Current Quarter");
    this._dt.Rows.Add((object) 2, (object) "Current Year");
    this._dt.Rows.Add((object) 3, (object) "Custom");
    ((UltraDropDownBase) this.combo).DisplayMember = nameof (DateRange);
    ((UltraDropDownBase) this.combo).ValueMember = "RangeID";
    ((UltraGridBase) this.combo).DataSource = (object) this._dt;
    this.combo.SelectedIndex = 1;
    this.InitialSize = this.Size;
  }

  public override object Value
  {
    get
    {
      DateTime dateTime = DateTime.MinValue;
      switch (Conversions.ToInteger(this.combo.Value))
      {
        case 0:
          ref DateTime local1 = ref dateTime;
          DateTime now1 = DateAndTime.Now;
          int year1 = now1.Year;
          now1 = DateAndTime.Now;
          int month = now1.Month;
          int day = DateTime.DaysInMonth(DateAndTime.Now.Year, DateAndTime.Now.Month);
          local1 = new DateTime(year1, month, day);
          break;
        case 1:
          DateTime now2 = DateAndTime.Now;
          if (now2.Month <= 3)
          {
            ref DateTime local2 = ref dateTime;
            now2 = DateAndTime.Now;
            int year2 = now2.Year;
            local2 = new DateTime(year2, 3, 31 /*0x1F*/);
            break;
          }
          now2 = DateAndTime.Now;
          if (now2.Month <= 6)
          {
            ref DateTime local3 = ref dateTime;
            now2 = DateAndTime.Now;
            int year3 = now2.Year;
            local3 = new DateTime(year3, 6, 30);
            break;
          }
          now2 = DateAndTime.Now;
          if (now2.Month <= 9)
          {
            ref DateTime local4 = ref dateTime;
            now2 = DateAndTime.Now;
            int year4 = now2.Year;
            local4 = new DateTime(year4, 9, 30);
            break;
          }
          now2 = DateAndTime.Now;
          if (now2.Month <= 12)
          {
            ref DateTime local5 = ref dateTime;
            now2 = DateAndTime.Now;
            int year5 = now2.Year;
            local5 = new DateTime(year5, 12, 31 /*0x1F*/);
            break;
          }
          break;
        case 2:
          dateTime = new DateTime(DateAndTime.Now.Year, 12, 31 /*0x1F*/);
          break;
        case 3:
          if (this.dtpTo.Value != null)
          {
            dateTime = this.dtpTo.DateTime.Date;
            break;
          }
          break;
      }
      return (object) new object[1]{ (object) dateTime };
    }
    set => this.dtpTo.Value = (object) (DateTime) ((object[]) value)[0];
  }

  public override void Compress()
  {
    ((Control) this.combo).Top = 0;
    ((Control) this.dtpFrom).Top = ((Control) this.combo).Height;
    ((Control) this.dtpTo).Top = ((Control) this.combo).Height;
    this.Label1.Top = ((Control) this.combo).Height;
    this.lblDescription.Height = checked (((Control) this.combo).Height + ((Control) this.dtpFrom).Height);
    this.lblDescription.Top = 0;
    this.Height = checked (((Control) this.combo).Height + ((Control) this.dtpFrom).Height);
  }

  public override string InputErrorMessage => string.Empty;

  private void combo_ValueChanged(object sender, EventArgs e)
  {
    ((Control) this.dtpFrom).Enabled = Conversions.ToInteger(this.combo.Value) == 3;
    ((Control) this.dtpTo).Enabled = Conversions.ToInteger(this.combo.Value) == 3;
  }
}
