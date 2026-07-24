// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.PolicyServices.formPolicyInquiryComment
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.PolicyServices;

public class formPolicyInquiryComment : Form
{
  private MGATextBox textComment;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private System.ComponentModel.Container components;
  private int _commentId;
  private int _controlNumber;

  public formPolicyInquiryComment(int controlNumber)
  {
    this.InitializeComponent();
    this._controlNumber = controlNumber;
  }

  public formPolicyInquiryComment(int commentId, int controlNumber)
  {
    this.InitializeComponent();
    this._commentId = commentId;
    this._controlNumber = controlNumber;
    this.LoadComment();
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
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb(78, 122, 171);
    ((TextEditorControlBase) this.textComment).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textComment).Location = new Point(8, 8);
    ((TextEditorControlBase) this.textComment).MaxLength = 8000;
    this.textComment.MGAStyle = MGAStyles.Blue;
    this.textComment.Multiline = true;
    ((Control) this.textComment).Name = "textComment";
    ((Control) this.textComment).Size = new Size(400, 288);
    ((Control) this.textComment).TabIndex = 0;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(208 /*0xD0*/, 304);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(96 /*0x60*/, 32 /*0x20*/);
    ((Control) this.buttonSave).TabIndex = 1;
    ((Control) this.buttonSave).Text = "&Save Comment";
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance3;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(312, 304);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(96 /*0x60*/, 32 /*0x20*/);
    ((Control) this.buttonCancel).TabIndex = 2;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.FromArgb(239, 247, 253);
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(416, 344);
    this.ControlBox = false;
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.textComment);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formPolicyInquiryComment);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Add Comment";
    ((ISupportInitialize) this.textComment).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    if (this._commentId == 0)
      this.SaveComment();
    else
      this.UpdateComment();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private bool ValidateForm()
  {
    if (!((Control) this.textComment).Text.Equals(string.Empty))
      return true;
    int num = (int) MessageBox.Show("You must enter a comment to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void SaveComment()
  {
    DefaultDatabase.ExecuteNonQuery("spFin_InsertPolicyInquiryComment", new object[8]
    {
      (object) "@controlNumber",
      (object) this._controlNumber,
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@commentDate",
      (object) DateTime.Now,
      (object) "@comment",
      (object) ((Control) this.textComment).Text
    });
    CurrentUser.Instance.LogAction($"Added comment to the policy inquiry screen for control #{this._controlNumber}", "Accounting Logs");
  }

  private void UpdateComment()
  {
    DefaultDatabase.ExecuteNonQuery("spFin_UpdatePolicyInquiryComment", new object[8]
    {
      (object) "@commentId",
      (object) this._commentId,
      (object) "@userGuid",
      (object) CurrentUser.Instance.UserGUID,
      (object) "@commentDate",
      (object) DateTime.Now,
      (object) "@comment",
      (object) ((Control) this.textComment).Text
    });
    CurrentUser.Instance.LogAction($"Edited comment on the policy inquiry screen for control #{this._controlNumber}", "Accounting Logs");
  }

  private void LoadComment()
  {
    ((Control) this.textComment).Text = DefaultDatabase.ExecuteScalar<string>("spFin_GetPolicyInquiryComment", new object[2]
    {
      (object) "@commentId",
      (object) this._commentId
    });
  }
}
