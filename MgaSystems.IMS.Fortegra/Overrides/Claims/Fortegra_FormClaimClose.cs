// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormClaimClose
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

public class Fortegra_FormClaimClose : Form
{
  private Claimant _currentClaimant;
  private IContainer components;
  private Label label1;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private MGASimpleComboBox comboClaimCloseReason;

  public Fortegra_FormClaimClose(Claimant currentClaimant)
  {
    this._currentClaimant = currentClaimant;
    this.InitializeComponent();
  }

  private void Fortegra_FormClaimClose_Load(object sender, EventArgs e)
  {
    this.LoadClaimCloseReasons();
  }

  private void LoadClaimCloseReasons()
  {
    ((UltraGridBase) this.comboClaimCloseReason).DataSource = (object) DefaultDatabase.ExecuteDataTable("Fortegra_spClaims_GetCloseReasonList");
    ((UltraDropDownBase) this.comboClaimCloseReason).DisplayMember = "ClaimCloseReason";
    ((UltraDropDownBase) this.comboClaimCloseReason).ValueMember = "ClaimCloseReasonId";
  }

  private void ButtonSave_Click(object sender, EventArgs e)
  {
    if (!this.VerifyEntry())
      return;
    this.SaveClaimClose();
    this.ClearScreen();
  }

  private void ClearScreen()
  {
    ((UltraDropDownBase) this.comboClaimCloseReason).SelectedRow = (UltraGridRow) null;
  }

  private bool VerifyEntry()
  {
    if (((UltraDropDownBase) this.comboClaimCloseReason).SelectedRow != null)
      return true;
    int num = (int) MessageBox.Show("You must specify a claim close reason to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void SaveClaimClose()
  {
    try
    {
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
      {
        try
        {
          DefaultDatabase.ExecuteScalar("dbo.Fortegra_SaveClaimClose", new object[10]
          {
            (object) "@ClaimId",
            (object) this._currentClaimant.ClaimId,
            (object) "@ClaimantGuid",
            (object) this._currentClaimant.ClaimantGuid,
            (object) "@UserGuid",
            (object) CurrentUser.Instance.UserGUID,
            (object) "@ClaimCloseReasonId",
            this.comboClaimCloseReason.Value,
            (object) "@ClaimCloseDate",
            (object) DateTime.Now
          });
          e.Transaction.Commit();
        }
        catch (Exception ex)
        {
          e.Transaction.Rollback();
          throw;
        }
      }));
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
    catch (Exception ex)
    {
      throw;
    }
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Fortegra_FormClaimClose));
    Appearance appearance2 = new Appearance();
    this.label1 = new Label();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.comboClaimCloseReason = new MGASimpleComboBox();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.comboClaimCloseReason).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(12, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(104, 13);
    this.label1.TabIndex = 40;
    this.label1.Text = "Claim Close Reason:";
    this.label1.UseMnemonic = false;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).Image = componentResourceManager.GetObject("appearance1.Image");
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(236, 37);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 31 /*0x1F*/);
    ((Control) this.buttonCancel).TabIndex = 42;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance2.Image");
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(142, 37);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(88, 31 /*0x1F*/);
    ((Control) this.buttonSave).TabIndex = 43;
    ((Control) this.buttonSave).Text = "&Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.ButtonSave_Click);
    this.comboClaimCloseReason.BorderStyle = (UIElementBorderStyle) 4;
    this.comboClaimCloseReason.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboClaimCloseReason).Location = new Point(121, 9);
    this.comboClaimCloseReason.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboClaimCloseReason).Name = "comboClaimCloseReason";
    ((Control) this.comboClaimCloseReason).Size = new Size(203, 20);
    ((Control) this.comboClaimCloseReason).TabIndex = 44;
    ((UltraControlBase) this.comboClaimCloseReason).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboClaimCloseReason).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(336, 77);
    this.Controls.Add((Control) this.comboClaimCloseReason);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.label1);
    this.Name = nameof (Fortegra_FormClaimClose);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Fortegra Claim Close";
    this.Load += new EventHandler(this.Fortegra_FormClaimClose_Load);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.comboClaimCloseReason).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
