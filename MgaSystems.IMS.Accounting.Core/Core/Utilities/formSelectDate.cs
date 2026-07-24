// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Utilities.formSelectDate
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using MGASystems.IMS.Accounting.Services;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Utilities;

public class formSelectDate : AccountingNoteDocumentSupport
{
  private EllipsePanel ellipsePanel1;
  private Label label1;
  private MGAButton buttonSelect;
  private MGAButton buttonCancel;
  private MGADateTimePicker dateSelectedDate;
  private System.ComponentModel.Container components;
  private DateTime selectedDate;

  public formSelectDate()
  {
    this.InitializeComponent();
    this.selectedDate = DateTime.Now;
    this.dateSelectedDate.DateTime = DateTime.Now;
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
    this.ellipsePanel1 = new EllipsePanel();
    this.label1 = new Label();
    this.dateSelectedDate = new MGADateTimePicker();
    this.buttonSelect = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.dateSelectedDate).BeginInit();
    ((ISupportInitialize) this.buttonSelect).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    this.ellipsePanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.buttonCancel);
    this.ellipsePanel1.Controls.Add((Control) this.buttonSelect);
    this.ellipsePanel1.Controls.Add((Control) this.dateSelectedDate);
    this.ellipsePanel1.Controls.Add((Control) this.label1);
    this.ellipsePanel1.CornerOffset = 1;
    this.ellipsePanel1.Location = new Point(4, 4);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(202, 78);
    this.ellipsePanel1.TabIndex = 0;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(24, 16 /*0x10*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(31 /*0x1F*/, 16 /*0x10*/);
    this.label1.TabIndex = 0;
    this.label1.Text = "Date:";
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateSelectedDate.Appearance = (AppearanceBase) appearance1;
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
    this.dateSelectedDate.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dateSelectedDate).Location = new Point(64 /*0x40*/, 16 /*0x10*/);
    this.dateSelectedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateSelectedDate).Name = "dateSelectedDate";
    ((Control) this.dateSelectedDate).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.dateSelectedDate).TabIndex = 1;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSelect).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonSelect).Location = new Point(16 /*0x10*/, 48 /*0x30*/);
    ((Control) this.buttonSelect).Name = "buttonSelect";
    ((Control) this.buttonSelect).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonSelect).TabIndex = 2;
    ((Control) this.buttonSelect).Text = "Select Date";
    ((Control) this.buttonSelect).Click += new EventHandler(this.buttonSelect_Click);
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonCancel).Location = new Point(104, 48 /*0x30*/);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(210, 88);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ellipsePanel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formSelectDate);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Select Date";
    this.ellipsePanel1.ResumeLayout(false);
    ((ISupportInitialize) this.dateSelectedDate).EndInit();
    ((ISupportInitialize) this.buttonSelect).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
  }

  private void buttonSelect_Click(object sender, EventArgs e)
  {
    this.selectedDate = this.dateSelectedDate.DateTime;
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  public DateTime SelectedDate => this.selectedDate;
}
