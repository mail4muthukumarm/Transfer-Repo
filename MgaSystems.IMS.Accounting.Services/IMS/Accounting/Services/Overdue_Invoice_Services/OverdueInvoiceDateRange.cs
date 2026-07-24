// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Overdue_Invoice_Services.OverdueInvoiceDateRange
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Overdue_Invoice_Services;

public class OverdueInvoiceDateRange : UserControl
{
  private IContainer components;
  private MGADateTimePicker dateTimeFrom;
  private MGADateTimePicker dateTimeTo;
  private UltraLabel ultraLabel1;
  private UltraLabel ultraLabel2;

  public OverdueInvoiceDateRange()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
  }

  public DateTime DateFrom => this.dateTimeFrom.DateTime;

  public DateTime DateTo => this.dateTimeTo.DateTime;

  public event OverdueInvoiceDateRange.DateRangeChangedHandler DateRangeChanged;

  protected void OnDateRangeChanged()
  {
    if (this.DateRangeChanged == null)
      return;
    this.DateRangeChanged((object) this, new EventArgs());
  }

  public void SetDates(DateTime from, DateTime to)
  {
    this.dateTimeFrom.Value = (object) from;
    this.dateTimeTo.Value = (object) to;
  }

  private void DateValueChanged(object sender, EventArgs e)
  {
    if (!this.ValidateDates())
      return;
    this.OnDateRangeChanged();
  }

  private bool ValidateDates()
  {
    DateTime dateTime = this.dateTimeFrom.DateTime;
    DateTime date1 = dateTime.Date;
    dateTime = this.dateTimeTo.DateTime;
    DateTime date2 = dateTime.Date;
    if (!(date1 > date2))
      return true;
    int num = (int) MessageBox.Show("Invalid date range.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

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
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.dateTimeFrom = new MGADateTimePicker();
    this.dateTimeTo = new MGADateTimePicker();
    this.ultraLabel1 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    ((ISupportInitialize) this.dateTimeFrom).BeginInit();
    ((ISupportInitialize) this.dateTimeTo).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeFrom.Appearance = (AppearanceBase) appearance1;
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
    this.dateTimeFrom.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dateTimeFrom).Location = new Point(43, 3);
    this.dateTimeFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeFrom).Name = "dateTimeFrom";
    ((Control) this.dateTimeFrom).Size = new Size(84, 20);
    ((Control) this.dateTimeFrom).TabIndex = 0;
    ((UltraControlBase) this.dateTimeFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTimeFrom.AfterExitEditMode += new EventHandler(this.DateValueChanged);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeTo.Appearance = (AppearanceBase) appearance3;
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
    this.dateTimeTo.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dateTimeTo).Location = new Point(164, 3);
    this.dateTimeTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeTo).Name = "dateTimeTo";
    ((Control) this.dateTimeTo).Size = new Size(84, 20);
    ((Control) this.dateTimeTo).TabIndex = 1;
    ((UltraControlBase) this.dateTimeTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTimeTo.AfterExitEditMode += new EventHandler(this.DateValueChanged);
    ((AppearanceBase) appearance5).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance5;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(3, 3);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(34, 15);
    ((Control) this.ultraLabel1).TabIndex = 2;
    ((Control) this.ultraLabel1).Text = "From:";
    ((AppearanceBase) appearance6).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance6;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(137, 3);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(21, 15);
    ((Control) this.ultraLabel2).TabIndex = 3;
    ((Control) this.ultraLabel2).Text = "To:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.ultraLabel2);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Controls.Add((Control) this.dateTimeTo);
    this.Controls.Add((Control) this.dateTimeFrom);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.MaximumSize = new Size((int) byte.MaxValue, 26);
    this.MinimumSize = new Size((int) byte.MaxValue, 26);
    this.Name = nameof (OverdueInvoiceDateRange);
    this.Size = new Size((int) byte.MaxValue, 26);
    ((ISupportInitialize) this.dateTimeFrom).EndInit();
    ((ISupportInitialize) this.dateTimeTo).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public delegate void DateRangeChangedHandler(object sender, EventArgs e);
}
