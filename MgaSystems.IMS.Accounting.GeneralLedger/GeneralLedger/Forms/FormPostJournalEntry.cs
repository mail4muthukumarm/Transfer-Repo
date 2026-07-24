// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.FormPostJournalEntry
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

public class FormPostJournalEntry : FormBase
{
  private IContainer components;
  private MGADateTimePicker dateTimePostDate;
  private Label label1;
  private MGATextBox textComments;
  private Label label2;
  private MGAButton buttonCancel;
  private MGAButton buttonPost;

  public FormPostJournalEntry()
  {
    this.InitializeComponent();
    this.dateTimePostDate.DateTime = DateTime.Now;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void buttonPost_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

  internal DateTime PostDate => this.dateTimePostDate.DateTime;

  internal string PostingComments => ((Control) this.textComments).Text;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormPostJournalEntry));
    Appearance appearance5 = new Appearance();
    this.dateTimePostDate = new MGADateTimePicker();
    this.label1 = new Label();
    this.textComments = new MGATextBox();
    this.label2 = new Label();
    this.buttonCancel = new MGAButton();
    this.buttonPost = new MGAButton();
    ((ISupportInitialize) this.dateTimePostDate).BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonPost).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimePostDate.Appearance = (AppearanceBase) appearance1;
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
    this.dateTimePostDate.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dateTimePostDate).Location = new Point(77, 13);
    this.dateTimePostDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimePostDate).Name = "dateTimePostDate";
    ((Control) this.dateTimePostDate).Size = new Size(89, 20);
    ((Control) this.dateTimePostDate).TabIndex = 0;
    ((UltraControlBase) this.dateTimePostDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimePostDate).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(13, 13);
    this.label1.Name = "label1";
    this.label1.Size = new Size(58, 13);
    this.label1.TabIndex = 1;
    this.label1.Text = "Post Date:";
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textComments).BackColor = Color.White;
    ((Control) this.textComments).Location = new Point(77, 40);
    this.textComments.MGAStyle = MGAStyles.Blue;
    this.textComments.Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(266, 162);
    ((Control) this.textComments).TabIndex = 2;
    ((UltraControlBase) this.textComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComments).UseOsThemes = (DefaultableBoolean) 2;
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(13, 40);
    this.label2.Name = "label2";
    this.label2.Size = new Size(61, 13);
    this.label2.TabIndex = 3;
    this.label2.Text = "Comments:";
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).Image = componentResourceManager.GetObject("appearance5.Image");
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance4;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(262, 209);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(80 /*0x50*/, 28);
    ((Control) this.buttonCancel).TabIndex = 4;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance5).Image = componentResourceManager.GetObject("appearance4.Image");
    ((AppearanceBase) appearance5).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance5).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonPost).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonPost).Location = new Point(176 /*0xB0*/, 209);
    ((Control) this.buttonPost).Name = "buttonPost";
    ((Control) this.buttonPost).Size = new Size(80 /*0x50*/, 28);
    ((Control) this.buttonPost).TabIndex = 5;
    ((Control) this.buttonPost).Text = "Post";
    ((UltraControlBase) this.buttonPost).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonPost).Click += new EventHandler(this.buttonPost_Click);
    this.AcceptButton = (IButtonControl) this.buttonPost;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(355, 242);
    this.ControlBox = false;
    this.Controls.Add((Control) this.buttonPost);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.textComments);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.dateTimePostDate);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormPostJournalEntry);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Post Journal Entry";
    ((ISupportInitialize) this.dateTimePostDate).EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonPost).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
