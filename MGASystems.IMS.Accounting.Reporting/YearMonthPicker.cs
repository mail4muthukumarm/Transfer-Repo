// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.YearMonthPicker
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using MGASystems.IMS.Reporting.ReportControls;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting;

public class YearMonthPicker : BaseReportControl
{
  private IContainer components;
  private ComboBox monthComboBox;
  private ComboBox yearComboBox;

  public YearMonthPicker() => this.InitializeComponent();

  public YearMonthPicker(string LabelText)
  {
    this.InitializeComponent();
    this.lblDescription.Text = LabelText;
    for (int month = 1; month <= 12; ++month)
      this.monthComboBox.Items.Add((object) new DateTime(2000, month, 1).ToString("MMMM"));
    int year = DateTime.Now.Year;
    for (int index = year - 100; index <= year + 100; ++index)
      this.yearComboBox.Items.Add((object) index.ToString());
    this.monthComboBox.SelectedIndex = DateTime.Now.Month - 1;
    this.yearComboBox.SelectedItem = (object) DateTime.Now.Year.ToString();
  }

  public override object Value
  {
    get
    {
      return (object) new object[2]
      {
        (object) (this.monthComboBox.SelectedIndex + 1),
        (object) int.Parse(this.yearComboBox.SelectedItem.ToString())
      };
    }
    set
    {
    }
  }

  public override void Compress()
  {
    this.monthComboBox.Top = 0;
    this.lblDescription.Height = this.monthComboBox.Height;
    this.lblDescription.Top = 0;
    this.Height = this.monthComboBox.Height;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.monthComboBox = new ComboBox();
    this.yearComboBox = new ComboBox();
    this.SuspendLayout();
    this.lblDescription.Size = new Size(175, 32 /*0x20*/);
    this.lblDescription.Text = "";
    this.monthComboBox.FormattingEnabled = true;
    this.monthComboBox.Location = new Point(192 /*0xC0*/, 3);
    this.monthComboBox.Name = "monthComboBox";
    this.monthComboBox.Size = new Size(176 /*0xB0*/, 33);
    this.monthComboBox.TabIndex = 1;
    this.yearComboBox.FormattingEnabled = true;
    this.yearComboBox.Location = new Point(396, 3);
    this.yearComboBox.Name = "yearComboBox";
    this.yearComboBox.Size = new Size(107, 33);
    this.yearComboBox.TabIndex = 2;
    this.AutoScaleDimensions = new SizeF(12f, 25f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.Controls.Add((Control) this.yearComboBox);
    this.Controls.Add((Control) this.monthComboBox);
    this.Description = "";
    this.Name = nameof (YearMonthPicker);
    this.Size = new Size(660, 313);
    this.Controls.SetChildIndex((Control) this.monthComboBox, 0);
    this.Controls.SetChildIndex((Control) this.yearComboBox, 0);
    this.Controls.SetChildIndex((Control) this.lblDescription, 0);
    this.ResumeLayout(false);
  }
}
