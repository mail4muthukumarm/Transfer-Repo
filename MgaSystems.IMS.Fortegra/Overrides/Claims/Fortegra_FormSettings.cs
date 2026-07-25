// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormSettings
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

[Override(typeof (MGASystems.IMS.Claims.FormSettings))]
public class Fortegra_FormSettings : MGASystems.IMS.Claims.FormSettings
{
  private const string VIEWINGRIGHTS_SETTING = "CLAIMS_ENFORCEVIEWING_RIGHTS";
  private IContainer components;
  private MGASimpleComboBox cboBankAccount;
  private UltraLabel ultraLabel4;

  public Fortegra_FormSettings() => this.InitializeComponent();

  private void Fortegra_FormSettings_Load(object sender, EventArgs e) => this.LoadBankAccounts();

  private void LoadBankAccounts()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("Fortegra_GetBankAccountList");
    ((UltraDropDownBase) this.cboBankAccount).DisplayMember = "bank";
    ((UltraDropDownBase) this.cboBankAccount).ValueMember = "glacctid";
    ((UltraGridBase) this.cboBankAccount).DataSource = (object) dataTable;
    this.FilterBankAccounts((int) this.comboOfficeLocation.Value);
  }

  protected override void Save()
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((senderEx, eArgs) =>
    {
      DefaultDatabase.ExecuteNonQuery("Fortegra_SaveTransferSettings", new object[8]
      {
        (object) "@GLCompanyId",
        this.comboOfficeLocation.Value,
        (object) "@glacctId",
        (object) this.extendedTreeViewDropDown1.GLAccountID,
        (object) "@costCenterId",
        this.comboCostCenter.Value,
        (object) "@bankaccountId",
        this.cboBankAccount.Value
      });
      eArgs.Transaction.Commit();
    }));
    SystemSettings.SetBoolSetting("CLAIMS_ENFORCEVIEWING_RIGHTS", ((UltraToggleEditorBase) this.checkEnforceViewingRights).Checked);
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  protected override void LoadOfficeSettings(int glCompanyId)
  {
    this.cboBankAccount.Value = (object) null;
    this.FilterBankAccounts(glCompanyId);
    DataRow dataRow = DefaultDatabase.ExecuteDataRow("Fortegra_GetTransferSettings", new object[2]
    {
      (object) "@glcompanyId",
      (object) glCompanyId
    });
    if (dataRow["glacctid"] == DBNull.Value)
      return;
    this.extendedTreeViewDropDown1.SetSelectedNodeByKey(dataRow["glacctid"].ToString());
    if (dataRow["costcenterid"] != DBNull.Value)
      this.comboCostCenter.Value = (object) dataRow["costcenterid"].ToString();
    if (dataRow["bankaccountid"] != DBNull.Value)
      this.cboBankAccount.Value = (object) dataRow["bankaccountid"].ToString();
    this.GetViewingRightsSetting();
  }

  private void FilterBankAccounts(int glcompanyId)
  {
    if (this.cboBankAccount == null || ((UltraGridBase) this.cboBankAccount).DataSource == null)
      return;
    this.cboBankAccount.DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    this.cboBankAccount.DisplayLayout.Bands[0].ColumnFilters["GLCompanyId"].FilterConditions.Add((FilterComparisionOperator) 14, (object) glcompanyId);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    this.cboBankAccount = new MGASimpleComboBox();
    this.ultraLabel4 = new UltraLabel();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.checkEnforceViewingRights).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.comboCostCenter).BeginInit();
    ((ISupportInitialize) this.cboBankAccount).BeginInit();
    this.SuspendLayout();
    ((Control) this.buttonSave).Location = new Point(195, 166);
    ((Control) this.buttonCancel).Location = new Point(289, 166);
    ((Control) this.checkEnforceViewingRights).Location = new Point(133, 133);
    this.cboBankAccount.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraDropDownBase) this.cboBankAccount).DisplayMember = "Office Location";
    this.cboBankAccount.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboBankAccount).Location = new Point(133, 90);
    this.cboBankAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboBankAccount).Name = "cboBankAccount";
    ((Control) this.cboBankAccount).Size = new Size(245, 21);
    ((Control) this.cboBankAccount).TabIndex = 10;
    ((UltraControlBase) this.cboBankAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboBankAccount).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboBankAccount).ValueMember = "ID";
    ((AppearanceBase) appearance).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(12, 90);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(76, 15);
    ((Control) this.ultraLabel4).TabIndex = 9;
    ((Control) this.ultraLabel4).Text = "Bank Account:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(395, 204);
    this.Controls.Add((Control) this.cboBankAccount);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Name = nameof (Fortegra_FormSettings);
    this.Text = "Claim Automation Settings (Fortegra)";
    this.Load += new EventHandler(this.Fortegra_FormSettings_Load);
    this.Controls.SetChildIndex((Control) this.comboOfficeLocation, 0);
    this.Controls.SetChildIndex((Control) this.extendedTreeViewDropDown1, 0);
    this.Controls.SetChildIndex((Control) this.comboCostCenter, 0);
    this.Controls.SetChildIndex((Control) this.buttonSave, 0);
    this.Controls.SetChildIndex((Control) this.buttonCancel, 0);
    this.Controls.SetChildIndex((Control) this.checkEnforceViewingRights, 0);
    this.Controls.SetChildIndex((Control) this.ultraLabel4, 0);
    this.Controls.SetChildIndex((Control) this.cboBankAccount, 0);
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.checkEnforceViewingRights).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.comboCostCenter).EndInit();
    ((ISupportInitialize) this.cboBankAccount).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
