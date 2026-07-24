// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formEditWriteOffSettings
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formEditWriteOffSettings : Form
{
  private UltraGridRow _row;
  private IContainer components;
  private Label label1;
  private Label label2;
  private Label label3;
  private Label label4;
  private Label label5;
  private Label labelOfficeLocation;
  private ExtendedTreeViewDropDown dropTreeAR;
  private ExtendedTreeViewDropDown dropTreeAP;
  private ExtendedTreeViewDropDown dropTreeEX;
  private ExtendedTreeViewDropDown dropTreeUA;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;

  public formEditWriteOffSettings(UltraGridRow row)
  {
    this.InitializeComponent();
    this._row = row;
    this.InitializeForm();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void InitializeForm()
  {
    this.labelOfficeLocation.Text = this._row.Cells["Officelocation"].Value.ToString();
    this.InitializeGLDropTrees();
    this.DisplayCurrentValues();
  }

  private void InitializeGLDropTrees()
  {
    int GLCompany = int.Parse(this._row.Cells["glcompanyid"].Value.ToString());
    this.dropTreeAR.LoadGLAccounts(GLCompany);
    this.dropTreeAP.LoadGLAccounts(GLCompany);
    this.dropTreeEX.LoadGLAccounts(GLCompany);
    this.dropTreeUA.LoadGLAccounts(GLCompany);
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_SaveWriteOffSetting", new object[10]
    {
      (object) "@glcompanyId",
      (object) int.Parse(this._row.Cells["glcompanyid"].Value.ToString()),
      (object) "@glAcctId_AR",
      (object) this.dropTreeAR.GLAccountID,
      (object) "@glAcctId_AP",
      (object) this.dropTreeAP.GLAccountID,
      (object) "@glAcctId_EX",
      (object) this.dropTreeEX.GLAccountID,
      (object) "@glAcctId_UA",
      (object) this.dropTreeUA.GLAccountID
    });
    this.DialogResult = DialogResult.OK;
  }

  private void DisplayCurrentValues()
  {
    if (this._row.Cells["glacctid_ar"].Value != DBNull.Value)
      this.dropTreeAR.SetSelectedNodeByKey(this._row.Cells["glacctid_ar"].Value.ToString());
    if (this._row.Cells["glacctid_ap"].Value != DBNull.Value)
      this.dropTreeAP.SetSelectedNodeByKey(this._row.Cells["glacctid_ap"].Value.ToString());
    if (this._row.Cells["glacctid_ar"].Value != DBNull.Value)
      this.dropTreeEX.SetSelectedNodeByKey(this._row.Cells["glacctid_ex"].Value.ToString());
    if (this._row.Cells["glacctid_ar"].Value == DBNull.Value)
      return;
    this.dropTreeUA.SetSelectedNodeByKey(this._row.Cells["glacctid_ua"].Value.ToString());
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
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.labelOfficeLocation = new Label();
    this.dropTreeAR = new ExtendedTreeViewDropDown();
    this.dropTreeAP = new ExtendedTreeViewDropDown();
    this.dropTreeEX = new ExtendedTreeViewDropDown();
    this.dropTreeUA = new ExtendedTreeViewDropDown();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.Location = new Point(12, 9);
    this.label1.Name = "label1";
    this.label1.Size = new Size(82, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Office Location:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(12, 112 /*0x70*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(79, 13);
    this.label2.TabIndex = 1;
    this.label2.Text = "Un-Accounted:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(12, 84);
    this.label3.Name = "label3";
    this.label3.Size = new Size(58, 13);
    this.label3.TabIndex = 2;
    this.label3.Text = "Exchange:";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(12, 59);
    this.label4.Name = "label4";
    this.label4.Size = new Size(53, 13);
    this.label4.TabIndex = 3;
    this.label4.Text = "Payables:";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(12, 33);
    this.label5.Name = "label5";
    this.label5.Size = new Size(69, 13);
    this.label5.TabIndex = 4;
    this.label5.Text = "Receivables:";
    this.labelOfficeLocation.Location = new Point(100, 9);
    this.labelOfficeLocation.Name = "labelOfficeLocation";
    this.labelOfficeLocation.Size = new Size(209, 25);
    this.labelOfficeLocation.TabIndex = 5;
    this.labelOfficeLocation.Text = "Office Location:";
    this.dropTreeAR.DropDownHeight = 300;
    this.dropTreeAR.DropDownWidth = 300;
    this.dropTreeAR.Font = new Font("Tahoma", 8f);
    this.dropTreeAR.Location = new Point(103, 37);
    this.dropTreeAR.Name = "dropTreeAR";
    this.dropTreeAR.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeAR.ShowEquityAccounts = true;
    this.dropTreeAR.ShowExpenseAccounts = true;
    this.dropTreeAR.ShowIncomeAccounts = true;
    this.dropTreeAR.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeAR.ShowSystemDefinedAccounts = true;
    this.dropTreeAR.Size = new Size(218, 19);
    this.dropTreeAR.TabIndex = 6;
    this.dropTreeAR.UseCheckedStateSelectionOverride = false;
    this.dropTreeAP.DropDownHeight = 300;
    this.dropTreeAP.DropDownWidth = 300;
    this.dropTreeAP.Font = new Font("Tahoma", 8f);
    this.dropTreeAP.Location = new Point(103, 63 /*0x3F*/);
    this.dropTreeAP.Name = "dropTreeAP";
    this.dropTreeAP.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeAP.ShowEquityAccounts = true;
    this.dropTreeAP.ShowExpenseAccounts = true;
    this.dropTreeAP.ShowIncomeAccounts = true;
    this.dropTreeAP.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeAP.ShowSystemDefinedAccounts = true;
    this.dropTreeAP.Size = new Size(218, 19);
    this.dropTreeAP.TabIndex = 7;
    this.dropTreeAP.UseCheckedStateSelectionOverride = false;
    this.dropTreeEX.DropDownHeight = 300;
    this.dropTreeEX.DropDownWidth = 300;
    this.dropTreeEX.Font = new Font("Tahoma", 8f);
    this.dropTreeEX.Location = new Point(103, 87);
    this.dropTreeEX.Name = "dropTreeEX";
    this.dropTreeEX.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeEX.ShowEquityAccounts = true;
    this.dropTreeEX.ShowExpenseAccounts = true;
    this.dropTreeEX.ShowIncomeAccounts = true;
    this.dropTreeEX.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeEX.ShowSystemDefinedAccounts = true;
    this.dropTreeEX.Size = new Size(218, 19);
    this.dropTreeEX.TabIndex = 8;
    this.dropTreeEX.UseCheckedStateSelectionOverride = false;
    this.dropTreeUA.DropDownHeight = 300;
    this.dropTreeUA.DropDownWidth = 300;
    this.dropTreeUA.Font = new Font("Tahoma", 8f);
    this.dropTreeUA.Location = new Point(103, 112 /*0x70*/);
    this.dropTreeUA.Name = "dropTreeUA";
    this.dropTreeUA.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeUA.ShowEquityAccounts = true;
    this.dropTreeUA.ShowExpenseAccounts = true;
    this.dropTreeUA.ShowIncomeAccounts = true;
    this.dropTreeUA.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeUA.ShowSystemDefinedAccounts = true;
    this.dropTreeUA.Size = new Size(218, 19);
    this.dropTreeUA.TabIndex = 9;
    this.dropTreeUA.UseCheckedStateSelectionOverride = false;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance1;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(233, 137);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(89, 34);
    ((Control) this.buttonCancel).TabIndex = 10;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(138, 137);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(89, 34);
    ((Control) this.buttonSave).TabIndex = 11;
    ((Control) this.buttonSave).Text = "Save Settings";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(332, 178);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.dropTreeUA);
    this.Controls.Add((Control) this.dropTreeEX);
    this.Controls.Add((Control) this.dropTreeAP);
    this.Controls.Add((Control) this.dropTreeAR);
    this.Controls.Add((Control) this.labelOfficeLocation);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.label1);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formEditWriteOffSettings);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Edit Settings";
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
