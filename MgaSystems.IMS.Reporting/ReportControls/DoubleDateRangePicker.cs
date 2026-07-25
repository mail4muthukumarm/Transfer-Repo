// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.DoubleDateRangePicker
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

public class DoubleDateRangePicker : 
  BaseReportControl,
  IOfflineReportIncrementSupport,
  IOfflineReportControl
{
  private IContainer components;
  private bool _datesOptional;

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

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpTo2")]
  internal virtual MGADateTimePicker dtpTo2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpFrom2")]
  internal virtual MGADateTimePicker dtpFrom2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Description2")]
  internal virtual Label Description2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    this.dtpFrom = new MGADateTimePicker();
    this.dtpTo = new MGADateTimePicker();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.dtpTo2 = new MGADateTimePicker();
    this.dtpFrom2 = new MGADateTimePicker();
    this.Description2 = new Label();
    ((ISupportInitialize) this.dtpFrom).BeginInit();
    ((ISupportInitialize) this.dtpTo).BeginInit();
    ((ISupportInitialize) this.dtpTo2).BeginInit();
    ((ISupportInitialize) this.dtpFrom2).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Location = new Point(-2, 9);
    this.lblDescription.Size = new Size(88, 16 /*0x10*/);
    appearance1.BorderColor = Color.Gray;
    this.dtpFrom.Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.LightGray;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.LightGray;
    appearance2.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtpFrom.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtpFrom).Location = new Point(88, 6);
    ((Control) this.dtpFrom).Name = "dtpFrom";
    ((Control) this.dtpFrom).Size = new Size(104, 22);
    ((Control) this.dtpFrom).TabIndex = 0;
    ((UltraControlBase) this.dtpFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpFrom).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.Gray;
    this.dtpTo.Appearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.LightGray;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.LightGray;
    appearance4.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtpTo.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dtpTo).Location = new Point(224 /*0xE0*/, 6);
    ((Control) this.dtpTo).Name = "dtpTo";
    ((Control) this.dtpTo).Size = new Size(104, 22);
    ((Control) this.dtpTo).TabIndex = 1;
    ((UltraControlBase) this.dtpTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpTo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(200, 2);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(16 /*0x10*/, 30);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "to";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    this.Label2.Location = new Point(200, 31 /*0x1F*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(16 /*0x10*/, 30);
    this.Label2.TabIndex = 5;
    this.Label2.Text = "to";
    this.Label2.TextAlign = ContentAlignment.MiddleCenter;
    appearance5.BorderColor = Color.Gray;
    this.dtpTo2.Appearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.LightGray;
    appearance6.BackColor2 = Color.White;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.LightGray;
    appearance6.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtpTo2.ButtonAppearance = (AppearanceBase) appearance6;
    ((Control) this.dtpTo2).Location = new Point(224 /*0xE0*/, 35);
    ((Control) this.dtpTo2).Name = "dtpTo2";
    ((Control) this.dtpTo2).Size = new Size(104, 22);
    ((Control) this.dtpTo2).TabIndex = 4;
    ((UltraControlBase) this.dtpTo2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpTo2).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.Gray;
    this.dtpFrom2.Appearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.LightGray;
    appearance8.BackColor2 = Color.White;
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.LightGray;
    appearance8.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtpFrom2.ButtonAppearance = (AppearanceBase) appearance8;
    ((Control) this.dtpFrom2).Location = new Point(88, 35);
    ((Control) this.dtpFrom2).Name = "dtpFrom2";
    ((Control) this.dtpFrom2).Size = new Size(104, 22);
    ((Control) this.dtpFrom2).TabIndex = 3;
    ((UltraControlBase) this.dtpFrom2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpFrom2).UseOsThemes = (DefaultableBoolean) 2;
    this.Description2.AutoSize = true;
    this.Description2.Location = new Point(-2, 38);
    this.Description2.Name = "Description2";
    this.Description2.Size = new Size(87, 17);
    this.Description2.TabIndex = 6;
    this.Description2.Text = "[Description]";
    this.Controls.Add((Control) this.Description2);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.dtpTo2);
    this.Controls.Add((Control) this.dtpFrom2);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.dtpTo);
    this.Controls.Add((Control) this.dtpFrom);
    this.Name = "DateRangePickerTwo";
    this.Size = new Size(336, 58);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.dtpFrom, 0);
    this.Controls.SetChildIndex((Control) this.dtpTo, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.dtpFrom2, 0);
    this.Controls.SetChildIndex((Control) this.dtpTo2, 0);
    this.Controls.SetChildIndex((Control) this.Label2, 0);
    this.Controls.SetChildIndex((Control) this.Description2, 0);
    ((ISupportInitialize) this.dtpFrom).EndInit();
    ((ISupportInitialize) this.dtpTo).EndInit();
    ((ISupportInitialize) this.dtpTo2).EndInit();
    ((ISupportInitialize) this.dtpFrom2).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public DoubleDateRangePicker(string labelText, string labelText2, bool datesOptional)
  {
    this._datesOptional = false;
    this.InitializeComponent();
    this.Description = labelText;
    this.Description2.Text = labelText2;
    this.dtpFrom.Value = (object) null;
    this.dtpTo.Value = (object) null;
    this.dtpTo2.Value = (object) null;
    this.dtpFrom2.Value = (object) null;
    this._datesOptional = datesOptional;
    this.InitialSize = this.Size;
  }

  public DoubleDateRangePicker(
    string labelText,
    string labelText2,
    DateTime dateFrom,
    DateTime dateTo,
    DateTime dateFrom2,
    DateTime dateTo2)
  {
    this._datesOptional = false;
    this.InitializeComponent();
    this.Description = labelText;
    this.Description2.Text = labelText2;
    this.dtpFrom.Value = (object) dateFrom;
    this.dtpTo.Value = (object) dateTo;
    this.dtpTo2.Value = (object) dateFrom2;
    this.dtpFrom2.Value = (object) dateTo2;
    this._datesOptional = false;
    this.InitialSize = this.Size;
  }

  public DoubleDateRangePicker(
    string labelText,
    string labelText2,
    DateTime dateFrom,
    DateTime dateTo,
    bool datesOptional,
    DateTime dateFrom2,
    DateTime dateTo2)
  {
    this._datesOptional = false;
    this.InitializeComponent();
    this.Description = labelText;
    this.Description2.Text = labelText2;
    this.dtpFrom.Value = (object) dateFrom;
    this.dtpTo.Value = (object) dateTo;
    this.dtpTo2.Value = (object) dateFrom2;
    this.dtpFrom2.Value = (object) dateTo2;
    this._datesOptional = datesOptional;
    this.InitialSize = this.Size;
  }

  public override string InputErrorMessage
  {
    get
    {
      string inputErrorMessage = (string) null;
      if (this._datesOptional)
      {
        DateTime dateTime;
        if (this.dtpFrom.Value != null && this.dtpTo.Value != null)
        {
          dateTime = this.dtpFrom.DateTime;
          DateTime date1 = dateTime.Date;
          dateTime = this.dtpTo.DateTime;
          DateTime date2 = dateTime.Date;
          if (DateTime.Compare(date1, date2) > 0)
            inputErrorMessage = "From Date Must Be Before To Date";
        }
        if (this.dtpTo2.Value != null && this.dtpFrom2.Value != null)
        {
          dateTime = this.dtpFrom2.DateTime;
          DateTime date3 = dateTime.Date;
          dateTime = this.dtpTo2.DateTime;
          DateTime date4 = dateTime.Date;
          if (DateTime.Compare(date3, date4) > 0)
            inputErrorMessage = "From Date Must Be Before To Date";
        }
      }
      else
      {
        if (this.dtpFrom.Value == null & this.dtpTo.Value == null & this.dtpTo2.Value == null & this.dtpFrom2.Value == null)
          inputErrorMessage = "At Least One Full Date Range Is Required";
        if ((this.dtpFrom.Value == null | this.dtpTo.Value == null) & (this.dtpFrom2.Value == null | this.dtpTo2.Value == null))
          inputErrorMessage = "At Least One Full Date Range Is Required";
        DateTime dateTime;
        if (this.dtpTo.Value != null & this.dtpFrom.Value != null)
        {
          dateTime = this.dtpFrom.DateTime;
          DateTime date5 = dateTime.Date;
          dateTime = this.dtpTo.DateTime;
          DateTime date6 = dateTime.Date;
          if (DateTime.Compare(date5, date6) > 0)
            inputErrorMessage = "From Date Must Be Before To Date";
        }
        if (this.dtpTo2.Value != null & this.dtpFrom2.Value != null)
        {
          dateTime = this.dtpFrom2.DateTime;
          DateTime date7 = dateTime.Date;
          dateTime = this.dtpTo2.DateTime;
          DateTime date8 = dateTime.Date;
          if (DateTime.Compare(date7, date8) > 0)
            inputErrorMessage = "From Date Must Be Before To Date";
        }
      }
      return inputErrorMessage;
    }
  }

  public override object Value
  {
    get
    {
      return (object) new object[4]
      {
        Interaction.IIf(this.dtpFrom.Value == null, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.dtpTo.Value != null, (object) DateTime.MinValue, (object) null)), (object) this.dtpFrom.DateTime.Date),
        Interaction.IIf(this.dtpTo.Value == null, (object) null, (object) this.dtpTo.DateTime.Date),
        Interaction.IIf(this.dtpFrom2.Value == null, RuntimeHelpers.GetObjectValue(Interaction.IIf(this.dtpTo.Value != null, (object) DateTime.MinValue, (object) null)), (object) this.dtpFrom2.DateTime.Date),
        Interaction.IIf(this.dtpTo2.Value == null, (object) null, (object) this.dtpTo2.DateTime.Date)
      };
    }
    set
    {
      object[] objArray = (object[]) value;
      if (objArray[0] == null)
        this.dtpFrom.Value = (object) null;
      else
        this.dtpFrom.Value = (object) (DateTime) objArray[0];
      if (objArray[1] == null)
        this.dtpTo.Value = (object) null;
      else
        this.dtpTo.Value = (object) (DateTime) objArray[1];
      if (objArray[3] == null)
        this.dtpFrom2.Value = (object) null;
      else
        this.dtpFrom2.Value = (object) (DateTime) objArray[2];
      if (objArray[2] == null)
        this.dtpTo2.Value = (object) null;
      else
        this.dtpTo2.Value = (object) (DateTime) objArray[3];
    }
  }

  public override void Compress()
  {
    ((Control) this.dtpFrom).Top = 0;
    ((Control) this.dtpTo).Top = 0;
    this.lblDescription.Top = 0;
    ((Control) this.dtpTo2).Top = 35;
    ((Control) this.dtpFrom2).Top = 35;
    this.Description2.Top = 35;
    this.Label1.Top = 0;
    this.Label2.Top = 35;
    this.lblDescription.Height = ((Control) this.dtpTo).Height;
    this.Description2.Height = ((Control) this.dtpFrom2).Height;
    this.Label1.Height = ((Control) this.dtpTo).Height;
    this.Label2.Height = ((Control) this.dtpFrom2).Height;
    Point location = ((Control) this.dtpFrom2).Location;
    int y1 = location.Y;
    location = ((Control) this.dtpFrom).Location;
    int y2 = location.Y;
    this.Height = y1 - y2 + ((Control) this.dtpFrom2).Height;
  }

  public bool SupportsDate => false;

  public bool SupportsDateRange => true;

  public void SetReportControlValue(object value)
  {
    if (!(value is object[] objArray))
      return;
    if (objArray[0] != null)
      this.dtpFrom.DateTime = Conversions.ToDate(objArray[0]);
    if (objArray[1] != null)
      this.dtpTo.DateTime = Conversions.ToDate(objArray[1]);
    if (objArray[2] != null)
      this.dtpFrom2.DateTime = Conversions.ToDate(objArray[2]);
    if (objArray[3] == null)
      return;
    this.dtpTo2.DateTime = Conversions.ToDate(objArray[3]);
  }
}
