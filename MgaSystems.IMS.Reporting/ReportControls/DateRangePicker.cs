// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.ReportControls.DateRangePicker
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

public class DateRangePicker : 
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

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.dtpFrom = new MGADateTimePicker();
    this.dtpTo = new MGADateTimePicker();
    this.Label1 = new Label();
    ((ISupportInitialize) this.dtpFrom).BeginInit();
    ((ISupportInitialize) this.dtpTo).BeginInit();
    this.SuspendLayout();
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
    ((Control) this.dtpFrom).Size = new Size(104, 19);
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
    ((Control) this.dtpTo).Size = new Size(104, 19);
    ((Control) this.dtpTo).TabIndex = 1;
    ((UltraControlBase) this.dtpTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpTo).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(200, 2);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(16 /*0x10*/, 30);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "to";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.dtpTo);
    this.Controls.Add((Control) this.dtpFrom);
    this.Name = nameof (DateRangePicker);
    this.Size = new Size(336, 32 /*0x20*/);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.dtpFrom, 0);
    this.Controls.SetChildIndex((Control) this.dtpTo, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    ((ISupportInitialize) this.dtpFrom).EndInit();
    ((ISupportInitialize) this.dtpTo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public DateRangePicker(string labelText, bool datesOptional)
  {
    this._datesOptional = false;
    this.InitializeComponent();
    this.Description = labelText;
    if (datesOptional)
    {
      this.dtpFrom.Value = (object) null;
      this.dtpTo.Value = (object) null;
    }
    else
    {
      MGADateTimePicker dtpFrom = this.dtpFrom;
      DateTime now = DateAndTime.Now;
      // ISSUE: variable of a boxed type
      __Boxed<DateTime> date1 = (ValueType) now.Date;
      dtpFrom.Value = (object) date1;
      MGADateTimePicker dtpTo = this.dtpTo;
      now = DateAndTime.Now;
      // ISSUE: variable of a boxed type
      __Boxed<DateTime> date2 = (ValueType) now.Date;
      dtpTo.Value = (object) date2;
    }
    this._datesOptional = datesOptional;
    this.InitialSize = this.Size;
  }

  public DateRangePicker(string labelText, DateTime dateFrom, DateTime dateTo)
  {
    this._datesOptional = false;
    this.InitializeComponent();
    this.Description = labelText;
    this.dtpFrom.Value = (object) dateFrom;
    this.dtpTo.Value = (object) dateTo;
    this._datesOptional = false;
    this.InitialSize = this.Size;
  }

  public DateRangePicker(string labelText, DateTime dateFrom, DateTime dateTo, bool datesOptional)
  {
    this._datesOptional = false;
    this.InitializeComponent();
    this.Description = labelText;
    this.dtpFrom.Value = (object) dateFrom;
    this.dtpTo.Value = (object) dateTo;
    this._datesOptional = datesOptional;
    this.InitialSize = this.Size;
  }

  public override string InputErrorMessage
  {
    get
    {
      string inputErrorMessage;
      if (this._datesOptional)
      {
        if (this.dtpFrom.Value == null || this.dtpTo.Value == null)
        {
          inputErrorMessage = string.Empty;
          goto label_10;
        }
        if (this.dtpFrom.Value != null && this.dtpTo.Value != null && DateTime.Compare(this.dtpFrom.DateTime.Date, this.dtpTo.DateTime.Date) > 0)
        {
          inputErrorMessage = "From Date Must Be Before To Date";
          goto label_10;
        }
      }
      else
      {
        if (this.dtpFrom.Value == null || this.dtpTo.Value == null)
        {
          inputErrorMessage = "Both dates are required";
          goto label_10;
        }
        if (DateTime.Compare(this.dtpFrom.DateTime.Date, this.dtpTo.DateTime.Date) > 0)
        {
          inputErrorMessage = "From Date Must Be Before To Date";
          goto label_10;
        }
      }
      inputErrorMessage = (string) null;
label_10:
      return inputErrorMessage;
    }
  }

  public override object Value
  {
    get
    {
      return (object) new object[2]
      {
        Interaction.IIf(this.dtpFrom.Value == null, (object) null, (object) this.dtpFrom.DateTime.Date),
        Interaction.IIf(this.dtpTo.Value == null, (object) null, (object) this.dtpTo.DateTime.Date)
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
    }
  }

  public override void Compress()
  {
    ((Control) this.dtpFrom).Top = 0;
    ((Control) this.dtpTo).Top = 0;
    this.lblDescription.Top = 0;
    this.Label1.Top = 0;
    this.lblDescription.Height = ((Control) this.dtpTo).Height;
    this.Label1.Height = ((Control) this.dtpTo).Height;
    this.Height = ((Control) this.dtpTo).Height;
  }

  public bool SupportsDate => false;

  public bool SupportsDateRange => true;

  public void SetReportControlValue(object value)
  {
    if (!(value is object[] objArray))
      return;
    if (objArray[0] != null)
      this.dtpFrom.DateTime = Conversions.ToDate(objArray[0]);
    if (objArray[1] == null)
      return;
    this.dtpTo.DateTime = Conversions.ToDate(objArray[1]);
  }
}
