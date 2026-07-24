// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formEditTransactionComment
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formEditTransactionComment : FormBase
{
  private int _transactionNumber;
  private IContainer components;
  private MGATextBox textComment;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;

  private formEditTransactionComment() => this.InitializeComponent();

  public formEditTransactionComment(int transactionNumber)
  {
    this.InitializeComponent();
    this._transactionNumber = transactionNumber;
  }

  private void LoadTransactionComment()
  {
    ((Control) this.textComment).Text = DefaultDatabase.ExecuteScalar<string>("spFin_GetTransactionComment", new object[2]
    {
      (object) "@transactNum",
      (object) this._transactionNumber
    });
  }

  private void UpdateTransactionComment()
  {
    DefaultDatabase.ExecuteScalar<string>("spFin_UpdateTransactionComment", new object[4]
    {
      (object) "@transactNum",
      (object) this._transactionNumber,
      (object) "@comments",
      (object) ((Control) this.textComment).Text
    });
  }

  private void formEditTransactionComment_Load(object sender, EventArgs e)
  {
    this.LoadTransactionComment();
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will change the comment on the specified transaction.", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.UpdateTransactionComment();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
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
    this.textComment = new MGATextBox();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    ((ISupportInitialize) this.textComment).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComment).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textComment).BackColor = Color.White;
    ((Control) this.textComment).Location = new Point(5, 6);
    this.textComment.MGAStyle = MGAStyles.Blue;
    this.textComment.Multiline = true;
    ((Control) this.textComment).Name = "textComment";
    ((Control) this.textComment).Size = new Size(511 /*0x01FF*/, 289);
    ((Control) this.textComment).TabIndex = 0;
    ((UltraControlBase) this.textComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComment).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = (object) Resources.disk;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(312, 303);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(99, 26);
    ((Control) this.buttonSave).TabIndex = 1;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).Image = (object) Resources.delete;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonCancel).Location = new Point(417, 303);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(99, 26);
    ((Control) this.buttonCancel).TabIndex = 2;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(521, 332);
    this.ControlBox = false;
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.textComment);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formEditTransactionComment);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Edit Transaction Comment";
    this.Load += new EventHandler(this.formEditTransactionComment_Load);
    ((ISupportInitialize) this.textComment).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
