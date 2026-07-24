// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Controls.DateRangeOptionPicker
// Assembly: MgaSystems.IMS.Accounting.Controls, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 69E8E7CF-F3E0-45A9-94CD-B8A0D33430C8
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.Controls.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Controls;

public class DateRangeOptionPicker : UserControl
{
  private IContainer components;
  private DateRangeOptions _dateOption;
  private DateTime _DateRangeFrom;
  private DateTime _DateRangeTo;

  public DateRangeOptionPicker()
  {
    this.InitializeComponent();
    ((UltraGridBase) this.MgaSimpleComboBox1).DataSource = (object) this.GetDataSetForComboBoxDataBinding().Tables[0];
    ((UltraDropDownBase) this.MgaSimpleComboBox1).DisplayMember = "Value";
    this.MgaDateRangeFrom.DateTime = DateTime.Today;
    this.MgaDateRangeTo.DateTime = DateTime.Today;
    this._DateRangeFrom = DateTime.Today;
    this._DateRangeTo = DateTime.Today;
    this._dateOption = DateRangeOptions.Today;
    this.MgaSimpleComboBox1.SelectedIndex = 0;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGADateTimePicker MgaDateRangeFrom
  {
    get => this._MgaDateRangeFrom;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Enter_Enter);
      MGADateTimePicker mgaDateRangeFrom1 = this._MgaDateRangeFrom;
      if (mgaDateRangeFrom1 != null)
        ((Control) mgaDateRangeFrom1).Enter -= eventHandler;
      this._MgaDateRangeFrom = value;
      MGADateTimePicker mgaDateRangeFrom2 = this._MgaDateRangeFrom;
      if (mgaDateRangeFrom2 == null)
        return;
      ((Control) mgaDateRangeFrom2).Enter += eventHandler;
    }
  }

  internal virtual MGADateTimePicker MgaDateRangeTo
  {
    get => this._MgaDateRangeTo;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Enter_Enter);
      MGADateTimePicker mgaDateRangeTo1 = this._MgaDateRangeTo;
      if (mgaDateRangeTo1 != null)
        ((Control) mgaDateRangeTo1).Enter -= eventHandler;
      this._MgaDateRangeTo = value;
      MGADateTimePicker mgaDateRangeTo2 = this._MgaDateRangeTo;
      if (mgaDateRangeTo2 == null)
        return;
      ((Control) mgaDateRangeTo2).Enter += eventHandler;
    }
  }

  public virtual MGASimpleComboBox MgaSimpleComboBox1
  {
    get => this._MgaSimpleComboBox1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Enter_Enter);
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.MgaSimpleComboBox1_RowSelected);
      MGASimpleComboBox mgaSimpleComboBox1_1 = this._MgaSimpleComboBox1;
      if (mgaSimpleComboBox1_1 != null)
      {
        ((Control) mgaSimpleComboBox1_1).Enter -= eventHandler;
        mgaSimpleComboBox1_1.RowSelected -= selectedEventHandler;
      }
      this._MgaSimpleComboBox1 = value;
      MGASimpleComboBox mgaSimpleComboBox1_2 = this._MgaSimpleComboBox1;
      if (mgaSimpleComboBox1_2 == null)
        return;
      ((Control) mgaSimpleComboBox1_2).Enter += eventHandler;
      mgaSimpleComboBox1_2.RowSelected += selectedEventHandler;
    }
  }

  internal virtual MGAButton MgaButtonSelect
  {
    get => this._MgaButtonSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgaButtonSelect_Click);
      MGAButton mgaButtonSelect1 = this._MgaButtonSelect;
      if (mgaButtonSelect1 != null)
        ((Control) mgaButtonSelect1).Click -= eventHandler;
      this._MgaButtonSelect = value;
      MGAButton mgaButtonSelect2 = this._MgaButtonSelect;
      if (mgaButtonSelect2 == null)
        return;
      ((Control) mgaButtonSelect2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (DateRangeOptionPicker));
    this.MgaDateRangeFrom = new MGADateTimePicker();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.MgaDateRangeTo = new MGADateTimePicker();
    this.MgaSimpleComboBox1 = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.MgaButtonSelect = new MGAButton();
    ((ISupportInitialize) this.MgaDateRangeFrom).BeginInit();
    ((ISupportInitialize) this.MgaDateRangeTo).BeginInit();
    ((ISupportInitialize) this.MgaSimpleComboBox1).BeginInit();
    ((ISupportInitialize) this.MgaButtonSelect).BeginInit();
    this.SuspendLayout();
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaDateRangeFrom.Appearance = (AppearanceBase) appearance1;
    appearance2.AlphaLevel = (short) 14;
    appearance2.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance2.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance2.BackColorAlpha = (Alpha) 2;
    appearance2.BackGradientAlignment = (GradientAlignment) 4;
    appearance2.BackGradientStyle = (GradientStyle) 5;
    appearance2.BorderAlpha = (Alpha) 1;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    appearance2.ForeColor = Color.FromArgb(49, 85, 153);
    appearance2.ForegroundAlpha = (Alpha) 2;
    this.MgaDateRangeFrom.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaDateRangeFrom).Enabled = false;
    ((Control) this.MgaDateRangeFrom).Location = new Point(304, 2);
    this.MgaDateRangeFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaDateRangeFrom).Name = "MgaDateRangeFrom";
    ((Control) this.MgaDateRangeFrom).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.MgaDateRangeFrom).TabIndex = 0;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(232, 4);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(68, 16 /*0x10*/);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Date Range:";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(8, 4);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(41, 16 /*0x10*/);
    this.Label3.TabIndex = 3;
    this.Label3.Text = "Option:";
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaDateRangeTo.Appearance = (AppearanceBase) appearance3;
    appearance4.AlphaLevel = (short) 14;
    appearance4.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance4.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance4.BackColorAlpha = (Alpha) 2;
    appearance4.BackGradientAlignment = (GradientAlignment) 4;
    appearance4.BackGradientStyle = (GradientStyle) 5;
    appearance4.BorderAlpha = (Alpha) 1;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    appearance4.ForeColor = Color.FromArgb(49, 85, 153);
    appearance4.ForegroundAlpha = (Alpha) 2;
    this.MgaDateRangeTo.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.MgaDateRangeTo).Enabled = false;
    ((Control) this.MgaDateRangeTo).Location = new Point(412, 2);
    this.MgaDateRangeTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaDateRangeTo).Name = "MgaDateRangeTo";
    ((Control) this.MgaDateRangeTo).Size = new Size(96 /*0x60*/, 19);
    ((Control) this.MgaDateRangeTo).TabIndex = 4;
    this.MgaSimpleComboBox1.BorderStyle = (UIElementBorderStyle) 4;
    this.MgaSimpleComboBox1.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).DisplayMember = "";
    this.MgaSimpleComboBox1.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.MgaSimpleComboBox1).Location = new Point(48 /*0x30*/, 2);
    this.MgaSimpleComboBox1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaSimpleComboBox1).Name = "MgaSimpleComboBox1";
    ((Control) this.MgaSimpleComboBox1).Size = new Size(176 /*0xB0*/, 19);
    ((Control) this.MgaSimpleComboBox1).TabIndex = 5;
    ((UltraDropDownBase) this.MgaSimpleComboBox1).ValueMember = "";
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(400, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(12, 22);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "-";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance5.Image"));
    appearance5.ImageHAlign = (HAlign) 1;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.MgaButtonSelect).Appearance = (AppearanceBase) appearance5;
    ((Control) this.MgaButtonSelect).Enabled = false;
    ((Control) this.MgaButtonSelect).Location = new Point(512 /*0x0200*/, 1);
    ((Control) this.MgaButtonSelect).Name = "MgaButtonSelect";
    ((Control) this.MgaButtonSelect).Size = new Size(64 /*0x40*/, 21);
    ((Control) this.MgaButtonSelect).TabIndex = 6;
    ((ControlBase) this.MgaButtonSelect).Text = "Select";
    this.Controls.Add((Control) this.MgaButtonSelect);
    this.Controls.Add((Control) this.MgaSimpleComboBox1);
    this.Controls.Add((Control) this.MgaDateRangeTo);
    this.Controls.Add((Control) this.MgaDateRangeFrom);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Name = nameof (DateRangeOptionPicker);
    this.Size = new Size(584, 24);
    ((ISupportInitialize) this.MgaDateRangeFrom).EndInit();
    ((ISupportInitialize) this.MgaDateRangeTo).EndInit();
    ((ISupportInitialize) this.MgaSimpleComboBox1).EndInit();
    ((ISupportInitialize) this.MgaButtonSelect).EndInit();
    this.ResumeLayout(false);
  }

  public event DateRangeOptionPicker.DateChangedEventHandler DateChanged;

  private DataSet GetDataSetForComboBoxDataBinding()
  {
    DataSet comboBoxDataBinding = new DataSet();
    comboBoxDataBinding.Tables.Add(new DataTable("DataSource")
    {
      Columns = {
        {
          "Value",
          Type.GetType("System.String")
        }
      },
      Rows = {
        new object[1]{ (object) "Show Today" },
        new object[1]{ (object) "Show Current Week" },
        new object[1]{ (object) "Show Last 2 Week" },
        new object[1]{ (object) "Show Current Month" },
        new object[1]{ (object) "Show Last 3 Months" },
        new object[1]{ (object) "Show Last 6 Months" },
        new object[1]{ (object) "Show Year" },
        new object[1]{ (object) "Show Custom" }
      }
    });
    comboBoxDataBinding.AcceptChanges();
    return comboBoxDataBinding;
  }

  private void RaiseDateChangedEvent()
  {
    this.MgaDateRangeFrom.DateTime = this.getDateRangeFrom();
    this.MgaDateRangeTo.DateTime = this.getDateRangeTo();
    DateRangeEventArgs e = new DateRangeEventArgs((DateRangeOptions) this.MgaSimpleComboBox1.SelectedIndex, this.MgaDateRangeFrom.DateTime, this.MgaDateRangeTo.DateTime);
    // ISSUE: reference to a compiler-generated field
    DateRangeOptionPicker.DateChangedEventHandler dateChangedEvent = this.DateChangedEvent;
    if (dateChangedEvent != null)
      dateChangedEvent((object) this, e);
    if (e.Cancel)
    {
      this.MgaDateRangeFrom.DateTime = this._DateRangeFrom;
      this.MgaDateRangeTo.DateTime = this._DateRangeTo;
      this.MgaSimpleComboBox1.SelectedIndex = (int) this._dateOption;
    }
    else
    {
      this._DateRangeFrom = this.MgaDateRangeFrom.DateTime;
      this._DateRangeTo = this.MgaDateRangeTo.DateTime;
      this._dateOption = (DateRangeOptions) this.MgaSimpleComboBox1.SelectedIndex;
    }
  }

  private void Enter_Enter(object sender, EventArgs e)
  {
    this._dateOption = (DateRangeOptions) this.MgaSimpleComboBox1.SelectedIndex;
    this._DateRangeFrom = this.MgaDateRangeFrom.DateTime;
    this._DateRangeTo = this.MgaDateRangeTo.DateTime;
  }

  private void MgaSimpleComboBox1_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (this.MgaSimpleComboBox1.SelectedIndex == 7)
    {
      ((Control) this.MgaDateRangeFrom).Enabled = true;
      ((Control) this.MgaDateRangeTo).Enabled = true;
      ((Control) this.MgaButtonSelect).Enabled = true;
    }
    else
    {
      ((Control) this.MgaDateRangeFrom).Enabled = false;
      ((Control) this.MgaDateRangeTo).Enabled = false;
      ((Control) this.MgaButtonSelect).Enabled = false;
      this.RaiseDateChangedEvent();
    }
  }

  private void MgaButtonSelect_Click(object sender, EventArgs e) => this.RaiseDateChangedEvent();

  private DateTime getDateRangeFrom()
  {
    DateTime dateRangeFrom;
    switch (this.MgaSimpleComboBox1.SelectedIndex)
    {
      case 0:
        dateRangeFrom = DateTime.Today;
        break;
      case 1:
        dateRangeFrom = this.FindWeekBeginningDate();
        break;
      case 2:
        dateRangeFrom = this.FindWeekBeginningDate().AddDays(-7.0);
        break;
      case 3:
        dateRangeFrom = DateTime.Today.AddDays((double) (1 - DateTime.Today.Day));
        break;
      case 4:
        dateRangeFrom = DateTime.Today.AddMonths(-2).AddDays((double) (1 - DateTime.Today.Day));
        break;
      case 5:
        dateRangeFrom = DateTime.Today.AddMonths(-5).AddDays((double) (1 - DateTime.Today.Day));
        break;
      case 6:
        DateTime today1 = DateTime.Today;
        ref DateTime local1 = ref today1;
        DateTime today2 = DateTime.Today;
        int months = 1 - today2.Month;
        DateTime dateTime = local1.AddMonths(months);
        ref DateTime local2 = ref dateTime;
        today2 = DateTime.Today;
        double num = (double) (1 - today2.Day);
        dateRangeFrom = local2.AddDays(num);
        break;
      case 7:
        dateRangeFrom = this.MgaDateRangeFrom.DateTime;
        break;
    }
    return dateRangeFrom;
  }

  private DateTime FindWeekBeginningDate()
  {
    DateTime weekBeginningDate;
    switch (DateTime.Today.DayOfWeek)
    {
      case DayOfWeek.Sunday:
        weekBeginningDate = DateTime.Today;
        break;
      case DayOfWeek.Monday:
        weekBeginningDate = DateTime.Today.AddDays(-1.0);
        break;
      case DayOfWeek.Tuesday:
        weekBeginningDate = DateTime.Today.AddDays(-2.0);
        break;
      case DayOfWeek.Wednesday:
        weekBeginningDate = DateTime.Today.AddDays(-3.0);
        break;
      case DayOfWeek.Thursday:
        weekBeginningDate = DateTime.Today.AddDays(-4.0);
        break;
      case DayOfWeek.Friday:
        weekBeginningDate = DateTime.Today.AddDays(-5.0);
        break;
      case DayOfWeek.Saturday:
        weekBeginningDate = DateTime.Today.AddDays(-6.0);
        break;
    }
    return weekBeginningDate;
  }

  private DateTime getDateRangeTo()
  {
    DateTime dateRangeTo;
    switch (this.MgaSimpleComboBox1.SelectedIndex)
    {
      case 0:
        dateRangeTo = DateTime.Today;
        break;
      case 1:
        dateRangeTo = this.FindWeekEndingDate();
        break;
      case 2:
        dateRangeTo = this.FindWeekEndingDate();
        break;
      case 3:
        dateRangeTo = this.FindMonthEndingDate();
        break;
      case 4:
        dateRangeTo = this.FindMonthEndingDate();
        break;
      case 5:
        dateRangeTo = this.FindMonthEndingDate();
        break;
      case 6:
        DateTime today1 = DateTime.Today;
        ref DateTime local1 = ref today1;
        DateTime today2 = DateTime.Today;
        int months = 12 - today2.Month;
        DateTime dateTime = local1.AddMonths(months);
        ref DateTime local2 = ref dateTime;
        today2 = DateTime.Today;
        double num = (double) (31 /*0x1F*/ - today2.Day);
        dateRangeTo = local2.AddDays(num);
        break;
      case 7:
        dateRangeTo = this.MgaDateRangeTo.DateTime;
        break;
    }
    return dateRangeTo;
  }

  private DateTime FindWeekEndingDate()
  {
    DateTime weekEndingDate;
    switch (DateTime.Today.DayOfWeek)
    {
      case DayOfWeek.Sunday:
        weekEndingDate = DateTime.Today.AddDays(6.0);
        break;
      case DayOfWeek.Monday:
        weekEndingDate = DateTime.Today.AddDays(5.0);
        break;
      case DayOfWeek.Tuesday:
        weekEndingDate = DateTime.Today.AddDays(4.0);
        break;
      case DayOfWeek.Wednesday:
        weekEndingDate = DateTime.Today.AddDays(3.0);
        break;
      case DayOfWeek.Thursday:
        weekEndingDate = DateTime.Today.AddDays(2.0);
        break;
      case DayOfWeek.Friday:
        weekEndingDate = DateTime.Today.AddDays(1.0);
        break;
      case DayOfWeek.Saturday:
        weekEndingDate = DateTime.Today;
        break;
    }
    return weekEndingDate;
  }

  private DateTime FindMonthEndingDate()
  {
    DateTime today = DateTime.Today;
    int year = today.Year;
    today = DateTime.Today;
    int month = today.Month;
    return DateTime.Today.AddDays((double) ((int) (short) DateTime.DaysInMonth(year, month) - DateTime.Today.Day));
  }

  public DateRangeOptions DateRangeOption => this._dateOption;

  public DateTime DateRangeFrom => this.MgaDateRangeFrom.DateTime;

  public DateTime DateRangeTo => this.MgaDateRangeTo.DateTime;

  public delegate void DateChangedEventHandler(object sender, DateRangeEventArgs e);
}
