// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormSettings
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Claims.Properties;
using MGASystems.IMS.NoteDocuments;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormSettings : FormBase
{
  private const string VIEWINGRIGHTS_SETTING = "CLAIMS_ENFORCEVIEWING_RIGHTS";
  private IContainer components;
  private UltraLabel ultraLabel1;
  private UltraLabel ultraLabel2;
  private dsOfficeLocations dsOfficeLocations1;
  private UltraLabel ultraLabel3;
  protected MGAButton buttonSave;
  protected MGAButton buttonCancel;
  protected MGACheckBox checkEnforceViewingRights;
  protected MGASimpleComboBox comboOfficeLocation;
  protected ExtendedTreeViewDropDown extendedTreeViewDropDown1;
  protected MGASimpleComboBox comboCostCenter;

  public FormSettings() => this.InitializeComponent();

  private void LoadOfficeLocations()
  {
    DefaultDatabase.LoadDataTable((DataTable) this.dsOfficeLocations1.spFin_GetOfficeLocations, "spFin_GetOfficeLocations");
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.extendedTreeViewDropDown1.DropDownWidth = 300;
    this.extendedTreeViewDropDown1.DropDownHeight = 300;
    this.extendedTreeViewDropDown1.LoadGLAccounts((int) ((UltraCombo) this.comboOfficeLocation).Value);
    this.LoadCostCenters();
    this.LoadOfficeSettings((int) ((UltraCombo) this.comboOfficeLocation).Value);
  }

  protected virtual void LoadOfficeSettings(int glCompanyId)
  {
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("spClaims_GetTransferSettings", new object[2]
    {
      (object) "@glcompanyId",
      (object) glCompanyId
    });
    if (dataRow == null)
      return;
    if (dataRow["glacctid"] != DBNull.Value)
      this.extendedTreeViewDropDown1.SetSelectedNodeByKey(dataRow["glacctid"].ToString());
    if (dataRow["costcenterid"] != DBNull.Value)
      ((UltraCombo) this.comboCostCenter).Value = (object) dataRow["costcenterid"].ToString();
    this.GetViewingRightsSetting();
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num1 = (int) MessageBox.Show(Resources.SETTINGSERROR1, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this.extendedTreeViewDropDown1.SelectedNodeCount == 0 || !this.extendedTreeViewDropDown1.GLAccountSelected || this.extendedTreeViewDropDown1.GLAccountID == -1)
    {
      int num2 = (int) MessageBox.Show(Resources.SETTINGSERROR2, Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (((UltraDropDownBase) this.comboCostCenter).SelectedRow == null)
      {
        int num3 = (int) MessageBox.Show("You must select a cost center to continue.", Resources.ERROR_REQUIREDFIELD_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      this.Save();
    }
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  protected virtual void Save()
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((senderEx, eArgs) =>
    {
      DefaultDatabase.ExecuteNonQuery("spClaims_SaveTransferSettings", new object[6]
      {
        (object) "@GLCompanyId",
        ((UltraCombo) this.comboOfficeLocation).Value,
        (object) "@glacctId",
        (object) this.extendedTreeViewDropDown1.GLAccountID,
        (object) "@costCenterId",
        ((UltraCombo) this.comboCostCenter).Value
      });
      eArgs.Transaction.Commit();
    }));
    SystemSettings.SetBoolSetting("CLAIMS_ENFORCEVIEWING_RIGHTS", ((UltraToggleEditorBase) this.checkEnforceViewingRights).Checked);
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void LoadCurrentSettings()
  {
    ((UltraCombo) this.comboOfficeLocation).Value = (object) Utility.GetSetting("GLCO");
    this.extendedTreeViewDropDown1.SetSelectedNodeByKey(Utility.GetSetting("GLAC").ToString());
    ((UltraCombo) this.comboCostCenter).Value = (object) Utility.GetSetting("COCE");
    this.GetViewingRightsSetting();
  }

  protected void GetViewingRightsSetting()
  {
    ((UltraToggleEditorBase) this.checkEnforceViewingRights).Checked = SystemSettings.GetSetting<bool>("CLAIMS_ENFORCEVIEWING_RIGHTS");
  }

  private void LoadCostCenters()
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
      return;
    ((UltraGridBase) this.comboCostCenter).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetCostCentersList", new object[2]
    {
      (object) "@glCompanyId",
      ((UltraCombo) this.comboOfficeLocation).Value
    });
    ((UltraDropDownBase) this.comboCostCenter).DisplayMember = "Name";
    ((UltraDropDownBase) this.comboCostCenter).ValueMember = "CostCenterId";
  }

  private void FormSettings_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadOfficeLocations();
    this.LoadCurrentSettings();
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
    this.ultraLabel1 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    this.extendedTreeViewDropDown1 = new ExtendedTreeViewDropDown();
    this.buttonSave = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.checkEnforceViewingRights = new MGACheckBox();
    this.comboCostCenter = new MGASimpleComboBox();
    this.ultraLabel3 = new UltraLabel();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.dsOfficeLocations1.BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.checkEnforceViewingRights).BeginInit();
    ((ISupportInitialize) this.comboCostCenter).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(12, 12);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(83, 15);
    ((Control) this.ultraLabel1).TabIndex = 0;
    ((Control) this.ultraLabel1).Text = "Office Location:";
    ((AppearanceBase) appearance2).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance2;
    ((Control) this.ultraLabel2).Location = new Point(12, 38);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(100, 23);
    ((Control) this.ultraLabel2).TabIndex = 2;
    ((Control) this.ultraLabel2).Text = "GL Offset Account:";
    ((UltraCombo) this.comboOfficeLocation).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) this.dsOfficeLocations1;
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraCombo) this.comboOfficeLocation).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(133, 12);
    this.comboOfficeLocation.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(245, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 1;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    ((UltraCombo) this.comboOfficeLocation).RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.extendedTreeViewDropDown1.DropDownHeight = 0;
    this.extendedTreeViewDropDown1.DropDownWidth = 0;
    this.extendedTreeViewDropDown1.Font = new Font("Tahoma", 8f);
    this.extendedTreeViewDropDown1.Location = new Point(133, 38);
    this.extendedTreeViewDropDown1.Name = "extendedTreeViewDropDown1";
    this.extendedTreeViewDropDown1.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.extendedTreeViewDropDown1.ShowEquityAccounts = true;
    this.extendedTreeViewDropDown1.ShowExpenseAccounts = true;
    this.extendedTreeViewDropDown1.ShowIncomeAccounts = true;
    this.extendedTreeViewDropDown1.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.extendedTreeViewDropDown1.ShowSystemDefinedAccounts = true;
    this.extendedTreeViewDropDown1.Size = new Size(245, 20);
    this.extendedTreeViewDropDown1.TabIndex = 3;
    this.extendedTreeViewDropDown1.UseCheckedStateSelectionOverride = false;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonSave).Location = new Point(195, 139);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(88, 28);
    ((Control) this.buttonSave).TabIndex = 7;
    ((Control) this.buttonSave).Text = "Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance4;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(289, 139);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 28);
    ((Control) this.buttonCancel).TabIndex = 8;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance5).BorderColor = Color.Gray;
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkEnforceViewingRights).Appearance = (AppearanceBase) appearance5;
    ((Control) this.checkEnforceViewingRights).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkEnforceViewingRights).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkEnforceViewingRights).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkEnforceViewingRights).Location = new Point(133, 106);
    ((Control) this.checkEnforceViewingRights).Name = "checkEnforceViewingRights";
    ((Control) this.checkEnforceViewingRights).Size = new Size(193, 20);
    ((Control) this.checkEnforceViewingRights).TabIndex = 6;
    ((Control) this.checkEnforceViewingRights).Text = "Enforce User Viewing Rights";
    ((UltraCombo) this.comboCostCenter).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboCostCenter).DataSource = (object) this.dsOfficeLocations1;
    ((UltraDropDownBase) this.comboCostCenter).DisplayMember = "Office Location";
    ((UltraCombo) this.comboCostCenter).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenter).Location = new Point(133, 64 /*0x40*/);
    this.comboCostCenter.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboCostCenter).Name = "comboCostCenter";
    ((Control) this.comboCostCenter).Size = new Size(245, 21);
    ((Control) this.comboCostCenter).TabIndex = 5;
    ((UltraControlBase) this.comboCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboCostCenter).ValueMember = "ID";
    ((AppearanceBase) appearance6).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance6;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Location = new Point(12, 64 /*0x40*/);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(66, 15);
    ((Control) this.ultraLabel3).TabIndex = 4;
    ((Control) this.ultraLabel3).Text = "Cost Center:";
    this.AcceptButton = (IButtonControl) this.buttonSave;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(395, 173);
    this.ControlBox = false;
    this.Controls.Add((Control) this.comboCostCenter);
    this.Controls.Add((Control) this.ultraLabel3);
    this.Controls.Add((Control) this.checkEnforceViewingRights);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.extendedTreeViewDropDown1);
    this.Controls.Add((Control) this.comboOfficeLocation);
    this.Controls.Add((Control) this.ultraLabel2);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormSettings);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Claim Automation Settings";
    this.Load += new EventHandler(this.FormSettings_Load);
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.dsOfficeLocations1.EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.checkEnforceViewingRights).EndInit();
    ((ISupportInitialize) this.comboCostCenter).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
