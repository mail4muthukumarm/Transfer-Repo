// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.AccountingReportControls.EffectiveOrBillingDateRange
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using Infragistics.Win;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports.AccountingReportControls;

public class EffectiveOrBillingDateRange : BaseReportControl
{
  private DateTime _fromDate;
  private DateTime _toDate;
  private EffectiveOrBillingDateRange.DateType _billingOrEffective;
  private bool _datesOptional;
  private IContainer components;

  public EffectiveOrBillingDateRange()
  {
    this._datesOptional = true;
    this.InitializeComponent();
    this._billingOrEffective = EffectiveOrBillingDateRange.DateType.None;
    this.InitialSize = this.Size;
  }

  public EffectiveOrBillingDateRange(bool DatesRequired)
  {
    this._datesOptional = true;
    this.InitializeComponent();
    this._billingOrEffective = EffectiveOrBillingDateRange.DateType.None;
    this._datesOptional = !DatesRequired;
    this.InitialSize = this.Size;
  }

  private void DateTimePicker1or2_ValueChanged(object sender, EventArgs e)
  {
    if (this.DateTimePicker1.Value == null & this.DateTimePicker2.Value == null)
    {
      ((Control) this.DateTimePicker3).Enabled = true;
      ((Control) this.DateTimePicker4).Enabled = true;
      this._billingOrEffective = EffectiveOrBillingDateRange.DateType.None;
    }
    else
    {
      ((Control) this.DateTimePicker3).Enabled = false;
      ((Control) this.DateTimePicker4).Enabled = false;
      this._billingOrEffective = EffectiveOrBillingDateRange.DateType.Billing;
    }
  }

  private void DateTimePicker3or4_ValueChanged(object sender, EventArgs e)
  {
    if (this.DateTimePicker3.Value == null & this.DateTimePicker4.Value == null)
    {
      ((Control) this.DateTimePicker1).Enabled = true;
      ((Control) this.DateTimePicker2).Enabled = true;
      this._billingOrEffective = EffectiveOrBillingDateRange.DateType.None;
    }
    else
    {
      ((Control) this.DateTimePicker1).Enabled = false;
      ((Control) this.DateTimePicker2).Enabled = false;
      this._billingOrEffective = EffectiveOrBillingDateRange.DateType.Effective;
    }
  }

  private void Clear1_Click(object sender, EventArgs e)
  {
    this.DateTimePicker1.Value = (object) null;
    this.DateTimePicker2.Value = (object) null;
    this._billingOrEffective = EffectiveOrBillingDateRange.DateType.None;
  }

  private void Clear2_Click(object sender, EventArgs e)
  {
    this.DateTimePicker3.Value = (object) null;
    this.DateTimePicker4.Value = (object) null;
    this._billingOrEffective = EffectiveOrBillingDateRange.DateType.None;
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGADateTimePicker DateTimePicker3
  {
    get => this._DateTimePicker3;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DateTimePicker3or4_ValueChanged);
      MGADateTimePicker dateTimePicker3_1 = this._DateTimePicker3;
      if (dateTimePicker3_1 != null)
        dateTimePicker3_1.ValueChanged -= eventHandler;
      this._DateTimePicker3 = value;
      MGADateTimePicker dateTimePicker3_2 = this._DateTimePicker3;
      if (dateTimePicker3_2 == null)
        return;
      dateTimePicker3_2.ValueChanged += eventHandler;
    }
  }

  internal virtual MGADateTimePicker DateTimePicker4
  {
    get => this._DateTimePicker4;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DateTimePicker3or4_ValueChanged);
      MGADateTimePicker dateTimePicker4_1 = this._DateTimePicker4;
      if (dateTimePicker4_1 != null)
        dateTimePicker4_1.ValueChanged -= eventHandler;
      this._DateTimePicker4 = value;
      MGADateTimePicker dateTimePicker4_2 = this._DateTimePicker4;
      if (dateTimePicker4_2 == null)
        return;
      dateTimePicker4_2.ValueChanged += eventHandler;
    }
  }

  internal virtual MGADateTimePicker DateTimePicker1
  {
    get => this._DateTimePicker1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DateTimePicker1or2_ValueChanged);
      MGADateTimePicker dateTimePicker1_1 = this._DateTimePicker1;
      if (dateTimePicker1_1 != null)
        dateTimePicker1_1.ValueChanged -= eventHandler;
      this._DateTimePicker1 = value;
      MGADateTimePicker dateTimePicker1_2 = this._DateTimePicker1;
      if (dateTimePicker1_2 == null)
        return;
      dateTimePicker1_2.ValueChanged += eventHandler;
    }
  }

  internal virtual MGADateTimePicker DateTimePicker2
  {
    get => this._DateTimePicker2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.DateTimePicker1or2_ValueChanged);
      MGADateTimePicker dateTimePicker2_1 = this._DateTimePicker2;
      if (dateTimePicker2_1 != null)
        dateTimePicker2_1.ValueChanged -= eventHandler;
      this._DateTimePicker2 = value;
      MGADateTimePicker dateTimePicker2_2 = this._DateTimePicker2;
      if (dateTimePicker2_2 == null)
        return;
      dateTimePicker2_2.ValueChanged += eventHandler;
    }
  }

  internal virtual LinkLabel Clear1
  {
    get => this._Clear1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Clear1_Click);
      LinkLabel clear1_1 = this._Clear1;
      if (clear1_1 != null)
        clear1_1.Click -= eventHandler;
      this._Clear1 = value;
      LinkLabel clear1_2 = this._Clear1;
      if (clear1_2 == null)
        return;
      clear1_2.Click += eventHandler;
    }
  }

  internal virtual LinkLabel Clear2
  {
    get => this._Clear2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Clear2_Click);
      LinkLabel clear2_1 = this._Clear2;
      if (clear2_1 != null)
        clear2_1.Click -= eventHandler;
      this._Clear2 = value;
      LinkLabel clear2_2 = this._Clear2;
      if (clear2_2 == null)
        return;
      clear2_2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
    this.Label1 = new Label();
    this.DateTimePicker1 = new MGADateTimePicker();
    this.DateTimePicker2 = new MGADateTimePicker();
    this.Label4 = new Label();
    this.Label6 = new Label();
    this.DateTimePicker3 = new MGADateTimePicker();
    this.DateTimePicker4 = new MGADateTimePicker();
    this.Clear1 = new LinkLabel();
    this.Clear2 = new LinkLabel();
    this.Label2 = new Label();
    ((ISupportInitialize) this.DateTimePicker1).BeginInit();
    ((ISupportInitialize) this.DateTimePicker2).BeginInit();
    ((ISupportInitialize) this.DateTimePicker3).BeginInit();
    ((ISupportInitialize) this.DateTimePicker4).BeginInit();
    this.SuspendLayout();
    this.lblDescription.Name = "lblDescription";
    this.lblDescription.Size = new Size(88, 0);
    this.lblDescription.Text = "Billing Date";
    this.Label1.Location = new Point(192 /*0xC0*/, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(24, 16 /*0x10*/);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "To";
    this.Label1.TextAlign = ContentAlignment.BottomLeft;
    appearance1.BorderColor = Color.Gray;
    this.DateTimePicker1.Appearance = (AppearanceBase) appearance1;
    appearance2.BackColor = Color.LightGray;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.LightGray;
    appearance2.ForeColor = Color.FromArgb(60, 60, 60);
    this.DateTimePicker1.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.DateTimePicker1).Location = new Point(88, 8);
    ((Control) this.DateTimePicker1).Name = "DateTimePicker1";
    ((Control) this.DateTimePicker1).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.DateTimePicker1).TabIndex = 1;
    this.DateTimePicker1.Value = (object) null;
    appearance3.BorderColor = Color.Gray;
    this.DateTimePicker2.Appearance = (AppearanceBase) appearance3;
    appearance4.BackColor = Color.LightGray;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.LightGray;
    appearance4.ForeColor = Color.FromArgb(60, 60, 60);
    this.DateTimePicker2.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.DateTimePicker2).Location = new Point(224 /*0xE0*/, 8);
    ((Control) this.DateTimePicker2).Name = "DateTimePicker2";
    ((Control) this.DateTimePicker2).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.DateTimePicker2).TabIndex = 0;
    this.DateTimePicker2.Value = (object) null;
    this.Label4.Location = new Point(0, 40);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label4.TabIndex = 9;
    this.Label4.Text = "Effective Date";
    this.Label4.TextAlign = ContentAlignment.BottomLeft;
    this.Label6.Location = new Point(192 /*0xC0*/, 40);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(24, 16 /*0x10*/);
    this.Label6.TabIndex = 7;
    this.Label6.Text = "To";
    this.Label6.TextAlign = ContentAlignment.BottomLeft;
    appearance5.BorderColor = Color.Gray;
    this.DateTimePicker3.Appearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.LightGray;
    appearance6.BackColor2 = Color.White;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.LightGray;
    appearance6.ForeColor = Color.FromArgb(60, 60, 60);
    this.DateTimePicker3.ButtonAppearance = (AppearanceBase) appearance6;
    ((Control) this.DateTimePicker3).Location = new Point(88, 40);
    ((Control) this.DateTimePicker3).Name = "DateTimePicker3";
    ((Control) this.DateTimePicker3).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.DateTimePicker3).TabIndex = 6;
    this.DateTimePicker3.Value = (object) null;
    appearance7.BorderColor = Color.Gray;
    this.DateTimePicker4.Appearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.LightGray;
    appearance8.BackColor2 = Color.White;
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.LightGray;
    appearance8.ForeColor = Color.FromArgb(60, 60, 60);
    this.DateTimePicker4.ButtonAppearance = (AppearanceBase) appearance8;
    ((Control) this.DateTimePicker4).Location = new Point(224 /*0xE0*/, 40);
    ((Control) this.DateTimePicker4).Name = "DateTimePicker4";
    ((Control) this.DateTimePicker4).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.DateTimePicker4).TabIndex = 5;
    this.DateTimePicker4.Value = (object) null;
    this.Clear1.Location = new Point(320, 8);
    this.Clear1.Name = "Clear1";
    this.Clear1.Size = new Size(32 /*0x20*/, 24);
    this.Clear1.TabIndex = 10;
    this.Clear1.TabStop = true;
    this.Clear1.Text = "Clear";
    this.Clear1.TextAlign = ContentAlignment.MiddleLeft;
    this.Clear2.Location = new Point(320, 40);
    this.Clear2.Name = "Clear2";
    this.Clear2.Size = new Size(32 /*0x20*/, 24);
    this.Clear2.TabIndex = 13;
    this.Clear2.TabStop = true;
    this.Clear2.Text = "Clear";
    this.Clear2.TextAlign = ContentAlignment.MiddleLeft;
    this.Label2.Location = new Point(0, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label2.TabIndex = 14;
    this.Label2.Text = "Billing Date";
    this.Label2.TextAlign = ContentAlignment.BottomLeft;
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Clear2);
    this.Controls.Add((Control) this.Clear1);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.DateTimePicker3);
    this.Controls.Add((Control) this.DateTimePicker4);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.DateTimePicker1);
    this.Controls.Add((Control) this.DateTimePicker2);
    this.Description = "Billing Date";
    this.Name = nameof (EffectiveOrBillingDateRange);
    this.Size = new Size(352, 64 /*0x40*/);
    this.Controls.SetChildIndex((Control) this.DateTimePicker2, 0);
    this.Controls.SetChildIndex((Control) this.DateTimePicker1, 0);
    this.Controls.SetChildIndex((Control) this.Label1, 0);
    this.Controls.SetChildIndex((Control) this.DateTimePicker4, 0);
    this.Controls.SetChildIndex((Control) this.DateTimePicker3, 0);
    this.Controls.SetChildIndex((Control) this.Label6, 0);
    this.Controls.SetChildIndex((Control) this.Label4, 0);
    this.Controls.SetChildIndex((Control) this.Clear1, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.Controls.SetChildIndex((Control) this.Clear2, 0);
    this.Controls.SetChildIndex((Control) this.Label2, 0);
    ((ISupportInitialize) this.DateTimePicker1).EndInit();
    ((ISupportInitialize) this.DateTimePicker2).EndInit();
    ((ISupportInitialize) this.DateTimePicker3).EndInit();
    ((ISupportInitialize) this.DateTimePicker4).EndInit();
    this.ResumeLayout(false);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  public override object Value
  {
    get
    {
      if (this._billingOrEffective.Equals((object) EffectiveOrBillingDateRange.DateType.Billing))
      {
        this._fromDate = this.DateTimePicker1.DateTime;
        this._toDate = this.DateTimePicker2.DateTime;
      }
      else if (this._billingOrEffective.Equals((object) EffectiveOrBillingDateRange.DateType.Effective))
      {
        this._fromDate = this.DateTimePicker3.DateTime;
        this._toDate = this.DateTimePicker4.DateTime;
      }
      else
      {
        this._fromDate = DateTime.MinValue;
        this._toDate = DateTime.MinValue;
      }
      return (object) new object[3]
      {
        (object) this._fromDate,
        (object) this._toDate,
        (object) this._billingOrEffective
      };
    }
    set
    {
      object[] objArray = (object[]) value;
      this._fromDate = (DateTime) objArray[0];
      this._toDate = (DateTime) objArray[1];
      this._billingOrEffective = (EffectiveOrBillingDateRange.DateType) objArray[2];
      if (this._billingOrEffective.Equals((object) EffectiveOrBillingDateRange.DateType.Billing))
      {
        this.DateTimePicker1.DateTime = this._fromDate;
        this.DateTimePicker2.DateTime = this._toDate;
      }
      else if (this._billingOrEffective.Equals((object) EffectiveOrBillingDateRange.DateType.Effective))
      {
        this.DateTimePicker3.DateTime = this._fromDate;
        this.DateTimePicker4.DateTime = this._toDate;
      }
      else
      {
        this._fromDate = DateTime.MinValue;
        this._toDate = DateTime.MinValue;
      }
    }
  }

  public override void Compress()
  {
    this.Label1.Top = 0;
    this.Label2.Top = 0;
    ((Control) this.DateTimePicker1).Top = 0;
    ((Control) this.DateTimePicker2).Top = 0;
    this.Clear1.Top = 0;
    this.Label4.Top = ((Control) this.DateTimePicker1).Height;
    this.Label6.Top = ((Control) this.DateTimePicker1).Height;
    ((Control) this.DateTimePicker3).Top = ((Control) this.DateTimePicker1).Height;
    ((Control) this.DateTimePicker4).Top = ((Control) this.DateTimePicker1).Height;
    this.Clear2.Top = ((Control) this.DateTimePicker1).Height;
    this.Height = checked (((Control) this.DateTimePicker1).Height + ((Control) this.DateTimePicker3).Height);
  }

  public override string InputErrorMessage
  {
    get
    {
      string inputErrorMessage;
      if (this._datesOptional)
        inputErrorMessage = (string) null;
      else if (this._billingOrEffective.Equals((object) EffectiveOrBillingDateRange.DateType.None))
      {
        inputErrorMessage = "One of the two date ranges should have value";
      }
      else
      {
        if (this._billingOrEffective.Equals((object) EffectiveOrBillingDateRange.DateType.Billing))
        {
          this._fromDate = this.DateTimePicker1.DateTime;
          this._toDate = this.DateTimePicker2.DateTime;
        }
        if (this._billingOrEffective.Equals((object) EffectiveOrBillingDateRange.DateType.Effective))
        {
          this._fromDate = this.DateTimePicker3.DateTime;
          this._toDate = this.DateTimePicker4.DateTime;
        }
        inputErrorMessage = !(this._fromDate.Equals(DateTime.MinValue) | this._toDate.Equals(DateTime.MinValue)) ? (DateTime.Compare(this._fromDate, this._toDate) <= 0 ? (string) null : "From Date Must Be Before To Date") : "One of the two date ranges should have value";
      }
      return inputErrorMessage;
    }
  }

  private enum DateType
  {
    None = -1, // 0xFFFFFFFF
    Billing = 0,
    Effective = 1,
  }
}
