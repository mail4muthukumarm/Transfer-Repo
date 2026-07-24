// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormChangeReservePaymentDate
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormChangeReservePaymentDate : FormBase
{
  private IContainer components;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private Label label1;
  protected MGADateTimePicker dateTimeDate;

  public int ResPayId { get; set; }

  public DateTime OldDate { get; set; }

  public DateTime NewDate { get; set; }

  public FormChangeReservePaymentDate() => this.InitializeComponent();

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  protected virtual void Save()
  {
    if (!this.VerifyForm())
      return;
    DefaultDatabase.ExecuteNonQuery("spClaims_UpdateReservePaymentDate", new object[4]
    {
      (object) "@ResPayId",
      (object) this.ResPayId,
      (object) "@newDate",
      (object) ((UltraDateTimeEditor) this.dateTimeDate).DateTime
    });
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will permanently change the date of the selected reserve/payment, continue?", "Change Reserve/Payment Date?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.Save();
    CurrentUser.Instance.LogAction($"Changed reserve/payment date. ResPayId {this.ResPayId.ToString()}", "Claims");
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  protected virtual bool VerifyForm() => true;

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
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.dateTimeDate = new MGADateTimePicker();
    this.label1 = new Label();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.dateTimeDate).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).Image = (object) Resources.Save;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonSave).Location = new Point(13, 40);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonSave).TabIndex = 0;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = (object) Resources.DeleteClaimSmall;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(99, 40);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateTimeDate).Appearance = (AppearanceBase) appearance3;
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
    ((UltraDateTimeEditor) this.dateTimeDate).ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dateTimeDate).Location = new Point(90, 13);
    this.dateTimeDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateTimeDate).Name = "dateTimeDate";
    ((Control) this.dateTimeDate).Size = new Size(89, 20);
    ((Control) this.dateTimeDate).TabIndex = 2;
    ((UltraControlBase) this.dateTimeDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeDate).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(13, 13);
    this.label1.Name = "label1";
    this.label1.Size = new Size(66, 13);
    this.label1.TabIndex = 3;
    this.label1.Text = "Select Date:";
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(194, 76);
    this.ControlBox = false;
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.dateTimeDate);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormChangeReservePaymentDate);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Change Date?";
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.dateTimeDate).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
