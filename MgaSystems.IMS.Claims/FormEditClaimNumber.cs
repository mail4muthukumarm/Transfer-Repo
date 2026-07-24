// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormEditClaimNumber
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

public class FormEditClaimNumber : FormBase
{
  private int _claimid;
  private string _currentClaimNumber;
  private IContainer components;
  private Label label1;
  private Label labelCurrentClaimNumber;
  private Label label3;
  private MGATextBox textNewClaimNumber;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;

  public FormEditClaimNumber(int claimId, string currentClaimNumber)
  {
    this.InitializeComponent();
    this._claimid = claimId;
    this._currentClaimNumber = currentClaimNumber;
  }

  private void FormEditClaimNumber_Load(object sender, EventArgs e)
  {
    this.labelCurrentClaimNumber.Text = this._currentClaimNumber;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm() || MessageBox.Show("You are about to change the claim number on this claim. Any documents created and saved to the document handler with the old claim number will have to be regenerated to reflect the new claim number. Are you sure you wish to continue?", "Change Claim Number?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    string newClaimNumber = ((Control) this.textNewClaimNumber).Text;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, etea) =>
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("dbo.spClaims_UpdateClaimNumber", new object[4]
        {
          (object) "@claimId",
          (object) this._claimid,
          (object) "@newClaimNumber",
          (object) newClaimNumber
        });
        CurrentUser.Instance.LogAction($"Changed claim number from {this._currentClaimNumber} to {newClaimNumber}. Claim Id: {this._claimid}", "Claims");
        etea.Transaction.Commit();
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      catch (Exception ex)
      {
        etea.Transaction.Rollback();
        int num = (int) MessageBox.Show(ex.Message, "Cannot Change Claim Number!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
    }));
  }

  private bool VerifyForm()
  {
    if (string.IsNullOrEmpty(((Control) this.textNewClaimNumber).Text))
    {
      int num = (int) MessageBox.Show("You must specify a claim number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textNewClaimNumber).Text.Length <= 50)
      return true;
    int num1 = (int) MessageBox.Show("Invalid claim number entered.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    this.label1 = new Label();
    this.labelCurrentClaimNumber = new Label();
    this.label3 = new Label();
    this.textNewClaimNumber = new MGATextBox();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    ((ISupportInitialize) this.textNewClaimNumber).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(4, 13);
    this.label1.Name = "label1";
    this.label1.Size = new Size(112 /*0x70*/, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Current Claim Number";
    this.labelCurrentClaimNumber.AutoSize = true;
    this.labelCurrentClaimNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    this.labelCurrentClaimNumber.Location = new Point(4, 30);
    this.labelCurrentClaimNumber.Name = "labelCurrentClaimNumber";
    this.labelCurrentClaimNumber.Size = new Size(150, 13);
    this.labelCurrentClaimNumber.TabIndex = 1;
    this.labelCurrentClaimNumber.Text = "[CURRENTCLAIMNUMBER]";
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(4, 53);
    this.label3.Name = "label3";
    this.label3.Size = new Size(96 /*0x60*/, 13);
    this.label3.TabIndex = 2;
    this.label3.Text = "New Claim Number";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textNewClaimNumber).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textNewClaimNumber).BackColor = Color.White;
    ((Control) this.textNewClaimNumber).Location = new Point(4, 70);
    this.textNewClaimNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.textNewClaimNumber).Name = "textNewClaimNumber";
    ((Control) this.textNewClaimNumber).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.textNewClaimNumber).TabIndex = 3;
    ((UltraControlBase) this.textNewClaimNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textNewClaimNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = (object) Resources.Save;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(4, 102);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(109, 24);
    ((Control) this.buttonSave).TabIndex = 4;
    ((Control) this.buttonSave).Text = "Save Changes";
    ((UltraControlBase) this.buttonSave).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).Image = (object) Resources.DeleteClaimSmall;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonCancel).Location = new Point(119, 102);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(93, 24);
    ((Control) this.buttonCancel).TabIndex = 5;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(216, 138);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.textNewClaimNumber);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.labelCurrentClaimNumber);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormEditClaimNumber);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Edit Claim Number";
    this.Load += new EventHandler(this.FormEditClaimNumber_Load);
    ((ISupportInitialize) this.textNewClaimNumber).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
