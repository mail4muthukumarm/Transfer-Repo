// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.FormMasterAccounts
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Analysis.Properties;
using MGASystems.IMS.Accounting.Analysis.Reports;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.GeneralLedger.Forms;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

[Override(typeof (formGLAccountManagement))]
[SecureResource("{78462800-A74A-459A-88AC-95B26E0E2ED9}", "Add GL Account Rights (GL Master)", "Determines whether or not the user can add GL Accounts.", "Accounting")]
[SecureResource("{860DAF67-CA5C-49D7-A155-10C21F3356D9}", "Generate Chart Of Accounts Rights (GL Master)", "Determines whether or not the user can generate a chart of accounts.", "Accounting")]
[SecureResource("{76B43C61-475D-492E-B06C-6D79EF73DBF6}", "View Account Tree (GL Master)", "Determines whether or not the user can view the GL account tree.", "Accounting")]
[SecureResource("{97119C1B-26C5-4B58-9C1B-7482E982C9F2}", "Fiscal Configuration Rights (GL Master)", "Determines whether or not the user can access the Fiscal Confiuration Screen.", "Accounting")]
[SecureResource("{BF14C079-3A6A-46D0-A99F-22C27CD69224}", "Journal Entry Rights (GL Master)", "Determines whether or not the user can enter a journal entry.", "Accounting")]
[SecureResource("{D04F6EB4-46FA-4CE6-A431-C7B5ABD21297}", "View/Edit Bank Rights (GL Master)", "Determines whether or not the user can access the View/Edit Bank Account Screen.", "Accounting")]
[SecureResource("{966528FB-2AB4-4057-A083-E2706EF1B3A6}", "Delete GL Account Rights (GL Master)", "Determines whether or not the user can delete a GL account.", "Accounting")]
[SecureResource("{11E1B254-4DD3-4AC2-A029-F5A8DDF31BA6}", "Account Classification Rights (GL Master)", "Determines whether or not the user can view/edit the account classifications.", "Accounting")]
public class FormMasterAccounts : FormBase
{
  private bool _isGenerateMode;
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private Panel FormBackground_Fill_Panel;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormBackground_Toolbars_Dock_Area_Bottom;
  private dsGLAccountMaster dsGLAccountMaster1;
  private UltraDropDown dropDownAccountTypes;
  private dsGLAccountTypes dsGLAccountTypes1;
  private dsGLMasterAutomationSettings dsGLMasterAutomationSettings1;
  private UltraDropDown dropDownAutomationSettings;
  internal UltraGrid gridMasterAccounts;
  private MGASimpleComboBox comboGLCompany;
  private UltraCheckEditor chkFiltered;
  private EllipsePanel panelLoadingCompany;
  private UltraLabel ultraLabel1;
  private PictureBox pictureBox1;

  public FormMasterAccounts() => this.InitializeComponent();

  private void LoadMasterAccounts()
  {
    this.dsGLAccountMaster1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsGLAccountMaster1, new string[1]
    {
      "MasterAccounts"
    }, "spFin_GetGLMasterAccounts");
  }

  private void masterAccountControl1_MasterAccountsUpdated()
  {
    this.dsGLAccountMaster1.Clear();
    this.LoadMasterAccounts();
  }

  private void LoadAccountTypes()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsGLAccountTypes1, new string[1]
    {
      this.dsGLAccountTypes1.Tables[0].TableName
    }, "[spFin_GetFinancialAcctTypes]");
  }

  private void LoadAutomationSettings()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsGLMasterAutomationSettings1, new string[1]
    {
      this.dsGLMasterAutomationSettings1.Tables[0].TableName
    }, "[spFin_GetAccountMasterAutomationSettingsList]");
  }

  private void gridMasterAccounts_BeforeCellListDropDown(object sender, CancelableCellEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "AutomationSetting"))
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.dropDownAutomationSettings).Rows)
    {
      if (row.GetCellValue(row.Cells[0].Column) != null && !string.IsNullOrEmpty(row.GetCellValue(row.Cells[0].Column).ToString()))
        row.Hidden = this.dsGLAccountMaster1.MasterAccounts.Select($"AutomationSettingID = '{row.Cells[0].Value.ToString()}'").Length != 0;
    }
  }

  private void gridMasterAccounts_CellListSelect(object sender, CellEventArgs e)
  {
    if (e.Cell.Column.ValueList.GetValue(e.Cell.Column.ValueList.SelectedItemIndex) != null && !string.IsNullOrEmpty(e.Cell.Column.ValueList.GetValue(e.Cell.Column.ValueList.SelectedItemIndex).ToString()))
    {
      object financialTypeId = e.Cell.Column.ValueList.GetValue(e.Cell.Column.ValueList.SelectedItemIndex);
      e.Cell.Row.Cells[e.Cell.Column.Index - 1].Value = financialTypeId;
      if (((KeyedSubObjectBase) e.Cell.Column).Key == "AutomationSetting")
      {
        e.Cell.Row.Cells["GLAccountShortName"].Value = financialTypeId;
        e.Cell.Row.Cells["GLAccountShortName"].Activation = (Activation) 3;
      }
      if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "AcctTypeDescription"))
        return;
      MGASystems.IMS.Accounting.Analysis.Utilities.Utilities.UpdateGLFinancialType(e.Cell.Row.Cells["GLAccountNumber"].Value.ToString(), (int) financialTypeId);
    }
    else
    {
      e.Cell.Row.Cells[e.Cell.Column.Index - 1].Value = (object) DBNull.Value;
      string str = e.Cell.Row.Cells["GLAccountName"].Value.ToString();
      if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "AutomationSetting"))
        return;
      e.Cell.Row.Cells["GLAccountShortName"].Activation = (Activation) 0;
      e.Cell.Row.Cells["GLAccountShortName"].Value = str.Length >= 15 ? (object) $"{str.Substring(0, 10)}-{e.Cell.Row.Cells["GLAccountNumber"].Value.ToString()}" : (object) str;
    }
  }

  private void gridMasterAccounts_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Cells["AutomationSettingId"].Value != null && !string.IsNullOrEmpty(e.Row.Cells["AutomationSettingId"].Value.ToString()))
      e.Row.Cells["GLAccountShortName"].Activation = (Activation) 3;
    else
      e.Row.Cells["GLAccountShortName"].Activation = (Activation) 0;
  }

  private void gridMasterAccounts_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
  {
    if (this._isGenerateMode)
      return;
    if (string.IsNullOrEmpty(e.Row.Cells["GLAccountNumber"].Value.ToString()))
    {
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      try
      {
        string empty = string.Empty;
        int glMasterId = e.Row.Cells["GLMasterId"].Value.Equals((object) DBNull.Value) ? -1 : (int) e.Row.Cells["GLMasterId"].Value;
        bool isBankAccount = (bool) e.Row.Cells["IsBankAccount"].Value;
        if (e.Row.Cells["AutomationSettingId"].Value != null)
          empty = e.Row.Cells["AutomationSettingId"].Value.ToString();
        if (!this.VerifyAccount(glMasterId, e.Row.Cells["GLAccountName"].Value.ToString(), e.Row.Cells["GLAccountShortName"].Value.ToString(), e.Row.Cells["GLAccountNumber"].Value.ToString(), empty, isBankAccount))
        {
          ((CancelEventArgs) e).Cancel = true;
        }
        else
        {
          if (isBankAccount)
            this.ShowBankInformation(e.Row);
          else
            this.Save(e.Row);
          this.LoadMasterAccounts();
        }
      }
      catch (Exception ex)
      {
        ((CancelEventArgs) e).Cancel = true;
        throw;
      }
    }
  }

  private bool VerifyAccount(
    int glMasterId,
    string glAccountName,
    string glAccountShortName,
    string glAccountNumber,
    string automationSetting,
    bool isBankAccount)
  {
    if (glAccountName.Contains("'") || glAccountShortName.Contains("'"))
    {
      int num = (int) MessageBox.Show("You cannot use a apostrophe within a GL account name or short name.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.gridMasterAccounts.RowUpdateCancelAction = (RowUpdateCancelAction) 1;
      return false;
    }
    if (this.dsGLAccountMaster1.MasterAccounts.Select($"GLAccountName = '{glAccountName}' AND GLMasterID <> {glMasterId}").Length != 0)
    {
      int num = (int) MessageBox.Show(Resources.ERROR_GLACCOUNTNAME_EXISTS, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dsGLAccountMaster1.MasterAccounts.Select($"GLAccountShortName = '{glAccountShortName}' AND GLMasterID <> {glMasterId}").Length != 0)
    {
      int num = (int) MessageBox.Show(Resources.ERROR_GLACCOUNTSHORTNAME_EXISTS, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dsGLAccountMaster1.MasterAccounts.Select($"GLAccountNumber = '{glAccountNumber}' AND GLMasterID <> {glMasterId}").Length != 0)
    {
      int num = (int) MessageBox.Show(Resources.ERROR_GLACCOUNTNUMBER_EXISTS, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dsGLAccountMaster1.MasterAccounts.Select($"AutomationSettingId = '{automationSetting}' AND GLMasterID <> {glMasterId}").Length == 0)
      return true;
    int num1 = (int) MessageBox.Show(Resources.ERROR_GLAUTOMATION_ALREADYEXISTS, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private bool VerifyAcctNumToClass(
    string glAccountNumber,
    string glFinancialAccountNumber,
    string glCompanyId)
  {
    if (MGASystems.IMS.Accounting.Analysis.Utilities.Utilities.AccountNumToClassIsValid(int.Parse(glFinancialAccountNumber), int.Parse(glAccountNumber), int.Parse(glCompanyId)))
      return true;
    int num = (int) MessageBox.Show(Resources.ERROR_GLACCOUNTCLASSTOACCTNUM_INVALID, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key == null)
      return;
    switch (key.Length)
    {
      case 4:
        switch (key[0])
        {
          case 'H':
            if (!(key == "Help"))
              return;
            Help.ShowHelp((Control) this, "imsaccountinghelp.chm", HelpNavigator.Topic, (object) "AddiGeneANewCharOfAcco.htm");
            return;
          case 'S':
            if (!(key == "SYNC"))
              return;
            using (FormMasterChartSync formMasterChartSync = new FormMasterChartSync())
            {
              int num = (int) formMasterChartSync.ShowDialog();
              return;
            }
          default:
            return;
        }
      case 5:
        if (!(key == "PRINT"))
          break;
        this.Print();
        break;
      case 6:
        switch (key[1])
        {
          case 'R':
            if (!(key == "CREATE"))
              return;
            if (this.HasTwoBankAccounts())
            {
              this.CreateChartOfAccounts();
              return;
            }
            int num1 = (int) MessageBox.Show("Two or more bank accounts must be selected to create a chart of accounts", "Not Enough Bank Accounts", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
          case 'a':
            if (!(key == "Cancel"))
              return;
            ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["Generate Chart Of Accounts"].SharedProps.Visible = true;
            this.ToggleGenerateOptions(false);
            this.ToggleMainOptions(true);
            this.DeselectAutomationAccounts();
            this.ToggleAssignedBankAccounts(false);
            return;
          default:
            return;
        }
      case 8:
        switch (key[0])
        {
          case 'B':
            if (!(key == "BANKINFO"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{D04F6EB4-46FA-4CE6-A431-C7B5ABD21297}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num2 = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            this.ViewBankInformation();
            return;
          case 'D':
            if (!(key == "DESELECT"))
              return;
            this.ToggleSelectAll(false);
            return;
          case 'V':
            if (!(key == "VIEWTREE"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{76B43C61-475D-492E-B06C-6D79EF73DBF6}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num3 = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            using (formGLAccountManagement accountManagement = new formGLAccountManagement())
            {
              accountManagement.ToggleToolbarVisible(false);
              int num4 = (int) accountManagement.ShowDialog();
              return;
            }
          default:
            return;
        }
      case 9:
        if (!(key == "SELECTALL"))
          break;
        this.ToggleSelectAll(true);
        break;
      case 12:
        switch (key[0])
        {
          case 'J':
            if (!(key == "JOURNALENTRY"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{BF14C079-3A6A-46D0-A99F-22C27CD69224}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num5 = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            using (Form form = ObjectFactory.Instance.CreateForm(typeof (FormJournalEntry_Advanced)))
            {
              int num6 = (int) form.ShowDialog();
              return;
            }
          case 'S':
            int num7 = key == "Save Changes" ? 1 : 0;
            return;
          default:
            return;
        }
      case 13:
        switch (key[0])
        {
          case 'C':
            if (!(key == "CLASS_MANAGER"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{11E1B254-4DD3-4AC2-A029-F5A8DDF31BA6}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num8 = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            using (FormAccountClassifications accountClassifications = new FormAccountClassifications())
            {
              int num9 = (int) accountClassifications.ShowDialog();
              return;
            }
          case 'D':
            if (!(key == "DELETEACCOUNT"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{966528FB-2AB4-4057-A083-E2706EF1B3A6}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num10 = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            if (((UltraGridBase) this.gridMasterAccounts).ActiveRow == null)
              return;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("This action cannot be undone, are you sure you wish to delete the ");
            stringBuilder.Append(((UltraGridBase) this.gridMasterAccounts).ActiveRow.Cells["GLAccountName"].Value.ToString());
            stringBuilder.Append(" account?");
            if (MessageBox.Show(stringBuilder.ToString(), "Permanently Delete Account?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
              return;
            DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((d_sender, d_e) =>
            {
              try
              {
                this.DeleteAccount((int) ((UltraGridBase) this.gridMasterAccounts).ActiveRow.Cells["GLMasterId"].Value);
              }
              catch (Exception ex)
              {
                d_e.Transaction.Rollback();
                throw;
              }
              d_e.Transaction.Commit();
            }));
            this.LoadMasterAccounts();
            return;
          default:
            return;
        }
      case 14:
        int num11 = key == "Cancel Changes" ? 1 : 0;
        break;
      case 20:
        switch (key[0])
        {
          case 'A':
            if (!(key == "AUTOMATIONEXCEPTIONS"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{08DB4861-647F-4EBD-9563-0EB7A3282969}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num12 = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            using (FormAccountMappings formAccountMappings = new FormAccountMappings())
            {
              int num13 = (int) formAccountMappings.ShowDialog();
              return;
            }
          case 'O':
            if (!(key == "OFFICE_CLASS_MANAGER"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{11E1B254-4DD3-4AC2-A029-F5A8DDF31BA6}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num14 = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            using (FormOfficeAccountClassifications accountClassifications = new FormOfficeAccountClassifications())
            {
              int num15 = (int) accountClassifications.ShowDialog();
              return;
            }
          default:
            return;
        }
      case 21:
        if (!(key == "Fiscal Configurations"))
          break;
        if (!SecurityManager.Instance.AssertPermission("{97119C1B-26C5-4B58-9C1B-7482E982C9F2}"))
        {
          using (formAccessDenied formAccessDenied = new formAccessDenied())
          {
            int num16 = (int) formAccessDenied.ShowDialog();
            break;
          }
        }
        using (formFiscalConfiguration fiscalConfiguration = new formFiscalConfiguration())
        {
          int num17 = (int) fiscalConfiguration.ShowDialog();
          break;
        }
      case 26:
        if (!(key == "Generate Chart Of Accounts"))
          break;
        if (!SecurityManager.Instance.AssertPermission("{860DAF67-CA5C-49D7-A155-10C21F3356D9}"))
        {
          using (formAccessDenied formAccessDenied = new formAccessDenied())
          {
            int num18 = (int) formAccessDenied.ShowDialog();
            break;
          }
        }
        if (!this.VerifyGenerateChart())
          break;
        ((UltraToggleEditorBase) this.chkFiltered).Checked = false;
        ((ToolEventArgs) e).Tool.SharedProps.Visible = false;
        this.ToggleGenerateOptions(true);
        this.ToggleMainOptions(false);
        this.AutoselectAutomationAccounts();
        this.ToggleAssignedBankAccounts(true);
        break;
    }
  }

  private void Print()
  {
    rptMasterChart report = new rptMasterChart(this.dsGLAccountMaster1);
    report.Run();
    new frmPrint((SectionReport) report).Show();
  }

  private void EnforceSecurity()
  {
    ((Control) this.gridMasterAccounts).Enabled = SecurityManager.Instance.AssertPermission("{78462800-A74A-459A-88AC-95B26E0E2ED9}");
  }

  private void ViewBankInformation()
  {
    if (((UltraGridBase) this.gridMasterAccounts).ActiveRow == null || !(bool) ((UltraGridBase) this.gridMasterAccounts).ActiveRow.Cells["IsBankAccount"].Value)
      return;
    using (FormMasterBankAccount masterBankAccount = new FormMasterBankAccount((int) ((UltraGridBase) this.gridMasterAccounts).ActiveRow.Cells["GLMasterId"].Value))
    {
      if (masterBankAccount.ShowDialog() != DialogResult.OK)
        return;
      this.Save(((UltraGridBase) this.gridMasterAccounts).ActiveRow, true, masterBankAccount.BankName, masterBankAccount.AccountType, masterBankAccount.AccountNumber, masterBankAccount.CheckRoutingNumber, masterBankAccount.DepositRoutingNumber, masterBankAccount.DepositSlipSuffix, masterBankAccount.AbaFractional, masterBankAccount.NextCheckNumber, masterBankAccount.ISOCountryCode, masterBankAccount.Address1, masterBankAccount.Address2, masterBankAccount.City, masterBankAccount.State, masterBankAccount.ZipCode, masterBankAccount.ZipPlus, masterBankAccount.County, masterBankAccount.ContactName, masterBankAccount.ContactEmail, masterBankAccount.ContactPhone, masterBankAccount.ContactFax, masterBankAccount.CurrencyCode, masterBankAccount.CheckText1, masterBankAccount.CheckText2, masterBankAccount.CheckText3, masterBankAccount.CheckText4, masterBankAccount.UseACH, masterBankAccount.CompanyID, masterBankAccount.CompanyName, masterBankAccount.ImmediateDest, masterBankAccount.ImmediateDestName, masterBankAccount.ImmediateOrgin, masterBankAccount.ImmediateOrginName, masterBankAccount.OrginatingDFI);
    }
  }

  private void ToggleGenerateOptions(bool value)
  {
    this._isGenerateMode = value;
    foreach (ToolBase tool in (ToolsCollectionBase) this.ultraToolbarsManager1.Tools)
    {
      if (tool.SharedProps.Category == "GenerateOptions")
        tool.SharedProps.Visible = value;
    }
    if (value)
      ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Load(((UltraGridBase) this.gridMasterAccounts).Layouts["Layout2"], (PropertyCategories) -1);
    else
      ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Load(((UltraGridBase) this.gridMasterAccounts).Layouts["Layout1"], (PropertyCategories) -1);
  }

  private void ToggleMainOptions(bool value)
  {
    foreach (ToolBase tool in (ToolsCollectionBase) this.ultraToolbarsManager1.Tools)
    {
      if (tool.SharedProps.Category == "MainOptions")
        tool.SharedProps.Visible = value;
    }
  }

  private bool ShowBankInformation(UltraGridRow row)
  {
    bool flag = false;
    if (row.Cells["GLMasterId"].Value == null || row.Cells["GLMasterId"].Value == DBNull.Value)
    {
      using (FormMasterBankAccount masterBankAccount = new FormMasterBankAccount())
      {
        if (masterBankAccount.ShowDialog() == DialogResult.OK)
        {
          this.Save(row, true, masterBankAccount.BankName, masterBankAccount.AccountType, masterBankAccount.AccountNumber, masterBankAccount.CheckRoutingNumber, masterBankAccount.DepositRoutingNumber, masterBankAccount.DepositSlipSuffix, masterBankAccount.AbaFractional, masterBankAccount.NextCheckNumber, masterBankAccount.ISOCountryCode, masterBankAccount.Address1, masterBankAccount.Address2, masterBankAccount.City, masterBankAccount.State, masterBankAccount.ZipCode, masterBankAccount.ZipPlus, masterBankAccount.County, masterBankAccount.ContactName, masterBankAccount.ContactEmail, masterBankAccount.ContactPhone, masterBankAccount.ContactFax, masterBankAccount.CurrencyCode, masterBankAccount.CheckText1, masterBankAccount.CheckText2, masterBankAccount.CheckText3, masterBankAccount.CheckText4, masterBankAccount.UseACH, masterBankAccount.CompanyID, masterBankAccount.CompanyName, masterBankAccount.ImmediateDest, masterBankAccount.ImmediateDestName, masterBankAccount.ImmediateOrgin, masterBankAccount.ImmediateOrginName, masterBankAccount.OrginatingDFI);
          flag = true;
        }
      }
    }
    else
    {
      using (FormMasterBankAccount masterBankAccount = new FormMasterBankAccount((int) row.Cells["GLMasterId"].Value))
      {
        if (masterBankAccount.ShowDialog() == DialogResult.OK)
        {
          this.Save(row, true, masterBankAccount.BankName, masterBankAccount.AccountType, masterBankAccount.AccountNumber, masterBankAccount.CheckRoutingNumber, masterBankAccount.DepositRoutingNumber, masterBankAccount.DepositSlipSuffix, masterBankAccount.AbaFractional, masterBankAccount.NextCheckNumber, masterBankAccount.ISOCountryCode, masterBankAccount.Address1, masterBankAccount.Address2, masterBankAccount.City, masterBankAccount.State, masterBankAccount.ZipCode, masterBankAccount.ZipPlus, masterBankAccount.County, masterBankAccount.ContactName, masterBankAccount.ContactEmail, masterBankAccount.ContactPhone, masterBankAccount.ContactFax, masterBankAccount.CurrencyCode, masterBankAccount.CheckText1, masterBankAccount.CheckText2, masterBankAccount.CheckText3, masterBankAccount.CheckText4, masterBankAccount.UseACH, masterBankAccount.CompanyID, masterBankAccount.CompanyName, masterBankAccount.ImmediateDest, masterBankAccount.ImmediateDestName, masterBankAccount.ImmediateOrgin, masterBankAccount.ImmediateOrginName, masterBankAccount.OrginatingDFI);
          flag = true;
        }
      }
    }
    return flag;
  }

  private void Save(UltraGridRow row)
  {
    this.Save(row, false, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, 0, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, false, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
  }

  private void Save(
    UltraGridRow row,
    bool isBankAccount,
    string bankName,
    string accountType,
    string accountNumber,
    string checkRoutingNumber,
    string depositRoutingNumber,
    string depositSlipSuffix,
    string abaFractional,
    int nextCheckNumber,
    string isoCountryCode,
    string address1,
    string address2,
    string city,
    string state,
    string zipCode,
    string zipPlus,
    string county,
    string contactName,
    string contactEmail,
    string contactPhone,
    string contactFax,
    string currencyCode,
    string checkText1,
    string checkText2,
    string checkText3,
    string checkText4,
    bool UseACH,
    string CompanyID,
    string CompanyName,
    string ImmediateDest,
    string ImmediateDestName,
    string ImmediateOrgin,
    string ImmediateOrginName,
    string OrginatingDFI)
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      try
      {
        if (row.Cells["GlMasterId"].Value.Equals((object) DBNull.Value))
        {
          int num1 = (int) DefaultDatabase.ExecuteScalar("spFin_InsertGLMasterAccount", new object[62]
          {
            (object) "@GLAccountName",
            (object) row.Cells["GLAccountName"].Value.ToString(),
            (object) "@GLAccountShortName",
            string.IsNullOrEmpty(row.Cells["GLAccountShortName"].Value.ToString()) ? (object) row.Cells["GLAccountName"].Value.ToString().Substring(0, row.Cells["GLAccountName"].Value.ToString().Length >= 15 ? 15 : row.Cells["GLAccountName"].Value.ToString().Length) : (object) row.Cells["GLAccountShortName"].Value.ToString(),
            (object) "@GLAccountNumber",
            (object) row.Cells["GLAccountNumber"].Value.ToString(),
            (object) "@GLFinancialAccountNumber",
            (object) row.Cells["GLFinancialAccountNumber"].Value.ToString(),
            (object) "@AutomationSetting",
            string.IsNullOrEmpty(row.Cells["AutomationSetting"].Value.ToString()) ? (object) DBNull.Value : row.Cells["AutomationSetting"].Value,
            (object) "@IsBankAccount",
            (object) isBankAccount,
            (object) "@BankName",
            (object) bankName,
            (object) "@BankAcctTypeId",
            (object) accountType,
            (object) "@BankAcctNum",
            (object) accountNumber,
            (object) "@ABARouteNum",
            (object) checkRoutingNumber,
            (object) "@DepositRoutingNumber",
            (object) depositRoutingNumber,
            (object) "@ABAFractionalTransitNum",
            (object) abaFractional,
            (object) "@NextCheckNum",
            (object) nextCheckNumber,
            (object) "@Addr1",
            (object) address1,
            (object) "@Addr2",
            (object) address2,
            (object) "@City",
            (object) city,
            (object) "@State",
            (object) state,
            (object) "@Zip",
            (object) zipCode,
            (object) "@ZipPlus",
            (object) zipPlus,
            (object) "@ContactName",
            (object) contactName,
            (object) "@ContactFax",
            (object) contactFax,
            (object) "@ContactPhone",
            (object) contactPhone,
            (object) "@ContactEmail",
            (object) contactEmail,
            (object) "@ISOCountryCode",
            (object) isoCountryCode,
            (object) "@DepositSlipSuffix",
            (object) depositSlipSuffix,
            (object) "@UserGuid",
            (object) CurrentUser.Instance.UserGUID,
            (object) "@CurrencyCode",
            (object) currencyCode,
            (object) "@CheckText1",
            (object) checkText1,
            (object) "@CheckText2",
            (object) checkText2,
            (object) "@CheckText3",
            (object) checkText3,
            (object) "@CheckText4",
            (object) checkText4
          });
          if (UseACH && isBankAccount)
          {
            DefaultDatabase.ExecuteNonQuery("spFin_UpdateACHBankInformation", new object[10]
            {
              (object) "@GLMasterId",
              (object) num1,
              (object) "@IsBankAccount",
              (object) isBankAccount,
              (object) "@UseACH",
              (object) UseACH,
              (object) "@ACHCompanyID",
              (object) CompanyID,
              (object) "@ACHCompanyName",
              (object) CompanyName
            });
            DefaultDatabase.ExecuteNonQuery("spFin_InsertACHFileInformation", new object[16 /*0x10*/]
            {
              (object) "@GLMasterId",
              (object) num1,
              (object) "@IsBankAccount",
              (object) isBankAccount,
              (object) "@ImmediateDestination",
              (object) ImmediateDest,
              (object) "@ImmediateOrigin",
              (object) ImmediateOrgin,
              (object) "@ImmediateDestName",
              (object) ImmediateDestName,
              (object) "@ImmediateOrginName",
              (object) ImmediateOrginName,
              (object) "@OriginatingDFI",
              (object) OrginatingDFI,
              (object) "@UserGuid",
              (object) CurrentUser.Instance.UserGUID
            });
          }
          if (MessageBox.Show(Resources.QUESTION_PROPAGATECHANGES, Resources.QUESTION_PROPAGATECHANGES_HEADER, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          {
            using (FormOfficeLocations formOfficeLocations = new FormOfficeLocations())
            {
              if (formOfficeLocations.ShowDialog() == DialogResult.OK)
              {
                if (formOfficeLocations.SelectedOffices.Count != 0)
                {
                  if (isBankAccount && formOfficeLocations.SelectedOffices.Count > 1)
                  {
                    int num2 = (int) MessageBox.Show("Banks Accounts can only be added to one Chart of Accounts. Please try adding the account again.", "Bank Account Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Transaction.Rollback();
                    return;
                  }
                  for (int index = 0; index < formOfficeLocations.SelectedOffices.Count; ++index)
                  {
                    if (this.VerifyAcctNumToClass(row.Cells["GLAccountNumber"].Value.ToString(), row.Cells["GLFinancialAccountNumber"].Value.ToString(), formOfficeLocations.SelectedOffices[index].ToString()))
                    {
                      DefaultDatabase.ExecuteNonQuery("spFin_GLMasterCreateGLAccount", new object[6]
                      {
                        (object) "@GLCompanyId",
                        (object) formOfficeLocations.SelectedOffices[index],
                        (object) "@GLMasterAccountId",
                        (object) num1,
                        (object) "@UserGuid",
                        (object) CurrentUser.Instance.UserGUID
                      });
                    }
                    else
                    {
                      e.Transaction.Rollback();
                      return;
                    }
                  }
                }
              }
            }
          }
        }
        else
        {
          DefaultDatabase.ExecuteNonQuery("spFin_UpdateGLMasterAccount", new object[64 /*0x40*/]
          {
            (object) "@GLMasterId",
            row.Cells["GLMasterId"].Value,
            (object) "@GLAccountName",
            (object) row.Cells["GLAccountName"].Value.ToString(),
            (object) "@GLAccountShortName",
            string.IsNullOrEmpty(row.Cells["GLAccountShortName"].Value.ToString()) ? (object) row.Cells["GLAccountName"].Value.ToString().Substring(0, 15) : (object) row.Cells["GLAccountShortName"].Value.ToString(),
            (object) "@GLAccountNumber",
            (object) row.Cells["GLAccountNumber"].Value.ToString(),
            (object) "@GLFinancialAccountNumber",
            (object) row.Cells["GLFinancialAccountNumber"].Value.ToString(),
            (object) "@AutomationSetting",
            string.IsNullOrEmpty(row.Cells["AutomationSettingId"].Value.ToString()) ? (object) DBNull.Value : row.Cells["AutomationSettingId"].Value,
            (object) "@IsBankAccount",
            (object) isBankAccount,
            (object) "@BankName",
            (object) bankName,
            (object) "@BankAcctTypeId",
            (object) accountType,
            (object) "@BankAcctNum",
            (object) accountNumber,
            (object) "@ABARouteNum",
            (object) checkRoutingNumber,
            (object) "@DepositRoutingNumber",
            (object) depositRoutingNumber,
            (object) "@ABAFractionalTransitNum",
            (object) abaFractional,
            (object) "@NextCheckNum",
            (object) nextCheckNumber,
            (object) "@Addr1",
            (object) address1,
            (object) "@Addr2",
            (object) address2,
            (object) "@City",
            (object) city,
            (object) "@State",
            (object) state,
            (object) "@Zip",
            (object) zipCode,
            (object) "@ZipPlus",
            (object) zipPlus,
            (object) "@ContactName",
            (object) contactName,
            (object) "@ContactFax",
            (object) contactFax,
            (object) "@ContactPhone",
            (object) contactPhone,
            (object) "@ContactEmail",
            (object) contactEmail,
            (object) "@ISOCountryCode",
            (object) isoCountryCode,
            (object) "@DepositSlipSuffix",
            (object) depositSlipSuffix,
            (object) "@UserGuid",
            (object) CurrentUser.Instance.UserGUID,
            (object) "@CurrencyCode",
            (object) currencyCode,
            (object) "@CheckText1",
            (object) checkText1,
            (object) "@CheckText2",
            (object) checkText2,
            (object) "@CheckText3",
            (object) checkText3,
            (object) "@CheckText4",
            (object) checkText4
          });
          if (UseACH)
          {
            DefaultDatabase.ExecuteNonQuery("spFin_UpdateACHBankInformation", new object[10]
            {
              (object) "@GLMasterID",
              row.Cells["GLMasterId"].Value,
              (object) "@IsBankAccount",
              (object) isBankAccount,
              (object) "@UseACH",
              (object) UseACH,
              (object) "@ACHCompanyID",
              (object) CompanyID,
              (object) "@ACHCompanyName",
              (object) CompanyName
            });
            DefaultDatabase.ExecuteNonQuery("spFin_UpdateACHFileInformation", new object[16 /*0x10*/]
            {
              (object) "@GLMasterID",
              row.Cells["GLMasterId"].Value,
              (object) "@IsBankAccount",
              (object) isBankAccount,
              (object) "@ImmediateDestination",
              (object) ImmediateDest,
              (object) "@ImmediateOrigin",
              (object) ImmediateOrgin,
              (object) "@ImmediateDestName",
              (object) ImmediateDestName,
              (object) "@ImmediateOrginName",
              (object) ImmediateOrginName,
              (object) "@OriginatingDFI",
              (object) OrginatingDFI,
              (object) "@UserGuid",
              (object) CurrentUser.Instance.UserGUID
            });
          }
        }
        e.Transaction.Commit();
      }
      catch (Exception ex)
      {
        e.Transaction.Rollback();
        throw;
      }
    }));
  }

  private void ToggleSelectAll(bool value)
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridMasterAccounts).Rows)
      {
        if (!row.Hidden)
          row.Cells["Select"].Value = (object) value;
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private bool VerifyGenerateChart()
  {
    if (this.dsGLAccountMaster1.MasterAccounts.Select("AutomationSettingID IS NOT NULL").Length != this.dsGLMasterAutomationSettings1.AutomationSettings.Select("AutomationSettingID IS NOT NULL").Length - 1)
    {
      int num = (int) MessageBox.Show(Resources.ERROR_AUTOMATIONSETTING_ASSIGNMENT, Resources.ERROR_REQUIRED_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (DefaultDatabase.ExecuteDataSet("spFin_GetOfficesWithNoChart").Tables[0].Rows.Count != 0)
      return true;
    int num1 = (int) MessageBox.Show(Resources.ERROR_ALLOFFICESHAVECHART, Resources.ERROR_INVALIDENTRY_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void CreateChartOfAccounts()
  {
    using (FormGenerateChart formGenerateChart = new FormGenerateChart(this))
    {
      if (formGenerateChart.ShowDialog() != DialogResult.OK)
        return;
      ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["Generate Chart Of Accounts"].SharedProps.Visible = true;
      this.ToggleGenerateOptions(false);
      this.ToggleMainOptions(true);
      this.DeselectAutomationAccounts();
      this.ToggleAssignedBankAccounts(false);
    }
  }

  private void AutoselectAutomationAccounts()
  {
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Bands[0].ColumnFilters["AutomationSettingId"].FilterConditions.Add((FilterComparisionOperator) 7, (object) "^[A-Z]");
    foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridMasterAccounts).Rows.GetFilteredInNonGroupByRows())
    {
      filteredInNonGroupByRow.Cells["Select"].Value = (object) true;
      filteredInNonGroupByRow.Activation = (Activation) 3;
    }
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
  }

  private void DeselectAutomationAccounts()
  {
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Bands[0].ColumnFilters["AutomationSetting"].FilterConditions.Add((FilterComparisionOperator) 0, (SpecialFilterOperand) null);
    foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridMasterAccounts).Rows.GetFilteredInNonGroupByRows())
    {
      filteredInNonGroupByRow.Cells["Select"].Value = (object) false;
      filteredInNonGroupByRow.Activation = (Activation) 0;
    }
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
  }

  private void GetOfficeLocations()
  {
    ((UltraGridBase) this.comboGLCompany).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetOfficeLocations");
    ((UltraDropDownBase) this.comboGLCompany).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboGLCompany).ValueMember = "ID";
  }

  private void comboGLCompany_RowSelected(object sender, RowSelectedEventArgs e)
  {
    ((UltraToggleEditorBase) this.chkFiltered).Checked = ((UltraDropDownBase) this.comboGLCompany).SelectedRow != null;
    if (((UltraDropDownBase) this.comboGLCompany).SelectedRow == null)
      return;
    this.panelLoadingCompany.Visible = true;
    this.DisplayCompanyAccounts((int) this.comboGLCompany.Value);
    this.panelLoadingCompany.Visible = false;
  }

  private void chkFiltered_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.chkFiltered).Checked)
      return;
    ((UltraDropDownBase) this.comboGLCompany).SelectedRow = (UltraGridRow) null;
    ((Control) this.comboGLCompany).ResetText();
    this.ToggleMainOptions(true);
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMasterAccounts).Rows)
    {
      if (row.Hidden)
      {
        row.Hidden = false;
        row.Activation = (Activation) 0;
      }
    }
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 4;
  }

  private void DisplayCompanyAccounts(int glCompanyId)
  {
    DataSet dataSet = DefaultDatabase.ExecuteDataSet("spFin_GetMasterGLCompanyAccounts", new object[2]
    {
      (object) "@GlCompanyId",
      (object) glCompanyId
    });
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMasterAccounts).Rows)
    {
      row.Hidden = dataSet.Tables[0].Select($"AcctNum = '{row.Cells["GLAccountNumber"].Value.ToString()}'").Length == 0;
      row.Activation = (Activation) 3;
    }
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
  }

  private void DeleteAccount(int glMasterId)
  {
    List<int> glAccountIds = MGASystems.IMS.Accounting.Analysis.Utilities.Utilities.GetGlAccountIds(glMasterId);
    for (int index = 0; index < glAccountIds.Count; ++index)
    {
      if (MGASystems.IMS.Accounting.Analysis.Utilities.Utilities.AccountIsAutomationAccount(glAccountIds[index]))
      {
        int num = (int) MessageBox.Show(Resources.ERROR_AUTOMATIONACCOUNT, Resources.ERRORHEADER_AUTOMATIONACCOUNT, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
    }
    DefaultDatabase.ExecuteNonQuery("spFin_GLMasterDeleteAccount", new object[2]
    {
      (object) "@GLMasterId",
      (object) glMasterId
    });
  }

  protected virtual void ToggleAssignedBankAccounts(bool value)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GLMasterGetAssignedBankAccounts");
    if (dataTable.Rows.Count == 0)
      return;
    foreach (DataRow row1 in (InternalDataCollectionBase) dataTable.Rows)
    {
      foreach (UltraGridRow row2 in ((UltraGridBase) this.gridMasterAccounts).Rows)
      {
        if (row2.Cells["GLAccountNumber"].Value.ToString() == row1[0].ToString())
        {
          row2.Hidden = value;
          break;
        }
      }
    }
  }

  private void FormMasterAccounts_Load(object sender, EventArgs e)
  {
    this.Cursor = MgaCursors.Default;
    this.GetOfficeLocations();
    this.LoadMasterAccounts();
    this.LoadAccountTypes();
    this.LoadAutomationSettings();
    this.ToggleGenerateOptions(false);
    this.EnforceSecurity();
  }

  private bool HasTwoBankAccounts()
  {
    ((UltraGridBase) this.gridMasterAccounts).UpdateData();
    int num = 0;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMasterAccounts).Rows)
    {
      if (!row.Hidden && (bool) row.Cells["Select"].Value && (bool) row.Cells["IsBankAccount"].Value)
      {
        ++num;
        if (num >= 2)
          return true;
      }
    }
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
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormMasterAccounts));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("AutomationSettings", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("AutomationSetting");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("TypesList", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("AcctTypeId");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("AcctTypeDescription");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("MasterAccounts", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("GLMasterId");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("GLAccountName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("GLAccountShortName");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("GLAccountNumber");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("GLFinancialAccountNumber");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("AcctTypeDescription", -1, (object) "dropDownAccountTypes");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("AutomationSetting", -1, (object) "dropDownAutomationSettings");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("IsBankAccount");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Select", 0);
    ColScrollRegion colScrollRegion1 = new ColScrollRegion(985);
    ColScrollRegion colScrollRegion2 = new ColScrollRegion(985);
    ColScrollRegion colScrollRegion3 = new ColScrollRegion(985);
    ColScrollRegion colScrollRegion4 = new ColScrollRegion(985);
    ColScrollRegion colScrollRegion5 = new ColScrollRegion(676);
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("Layout1");
    Appearance appearance41 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("MasterAccounts", -1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("GLMasterId");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("GLAccountName");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("GLAccountShortName");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("GLAccountNumber");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("GLFinancialAccountNumber");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("AcctTypeDescription", -1, (object) "dropDownAccountTypes");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("AutomationSetting", -1, (object) "dropDownAutomationSettings");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("IsBankAccount");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("Select", 0);
    ColScrollRegion colScrollRegion6 = new ColScrollRegion(985);
    ColScrollRegion colScrollRegion7 = new ColScrollRegion(676);
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("Layout2");
    Appearance appearance51 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("MasterAccounts", -1);
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("GLMasterId");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("GLAccountName");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("GLAccountShortName");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("GLAccountNumber");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("GLFinancialAccountNumber");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("AcctTypeDescription", -1, (object) "dropDownAccountTypes");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("AutomationSetting", -1, (object) "dropDownAutomationSettings");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("IsBankAccount");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("Select", 0);
    ColScrollRegion colScrollRegion8 = new ColScrollRegion(985);
    ColScrollRegion colScrollRegion9 = new ColScrollRegion(676);
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainBar");
    ButtonTool buttonTool1 = new ButtonTool("Save Changes");
    ButtonTool buttonTool2 = new ButtonTool("Cancel Changes");
    ButtonTool buttonTool3 = new ButtonTool("Generate Chart Of Accounts");
    ButtonTool buttonTool4 = new ButtonTool("CREATE");
    ButtonTool buttonTool5 = new ButtonTool("Cancel");
    ButtonTool buttonTool6 = new ButtonTool("DELETEACCOUNT");
    ButtonTool buttonTool7 = new ButtonTool("SELECTALL");
    ButtonTool buttonTool8 = new ButtonTool("DESELECT");
    ButtonTool buttonTool9 = new ButtonTool("Fiscal Configurations");
    ButtonTool buttonTool10 = new ButtonTool("JOURNALENTRY");
    ButtonTool buttonTool11 = new ButtonTool("BANKINFO");
    ButtonTool buttonTool12 = new ButtonTool("CLASS_MANAGER");
    ButtonTool buttonTool13 = new ButtonTool("OFFICE_CLASS_MANAGER");
    ButtonTool buttonTool14 = new ButtonTool("VIEWTREE");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("ControlContainerTool1");
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("ControlContainerTool2");
    ButtonTool buttonTool15 = new ButtonTool("PRINT");
    ButtonTool buttonTool16 = new ButtonTool("SYNC");
    ButtonTool buttonTool17 = new ButtonTool("Help");
    ButtonTool buttonTool18 = new ButtonTool("AUTOMATIONEXCEPTIONS");
    Appearance appearance60 = new Appearance();
    ButtonTool buttonTool19 = new ButtonTool("Generate Chart Of Accounts");
    Appearance appearance61 = new Appearance();
    ButtonTool buttonTool20 = new ButtonTool("DELETEACCOUNT");
    Appearance appearance62 = new Appearance();
    ButtonTool buttonTool21 = new ButtonTool("Fiscal Configurations");
    Appearance appearance63 = new Appearance();
    ButtonTool buttonTool22 = new ButtonTool("JOURNALENTRY");
    Appearance appearance64 = new Appearance();
    ButtonTool buttonTool23 = new ButtonTool("Save Changes");
    Appearance appearance65 = new Appearance();
    ButtonTool buttonTool24 = new ButtonTool("Cancel Changes");
    Appearance appearance66 = new Appearance();
    ButtonTool buttonTool25 = new ButtonTool("Cancel");
    Appearance appearance67 = new Appearance();
    ButtonTool buttonTool26 = new ButtonTool("SELECTALL");
    Appearance appearance68 = new Appearance();
    ButtonTool buttonTool27 = new ButtonTool("DESELECT");
    Appearance appearance69 = new Appearance();
    ButtonTool buttonTool28 = new ButtonTool("CLASS_MANAGER");
    Appearance appearance70 = new Appearance();
    ButtonTool buttonTool29 = new ButtonTool("CREATE");
    Appearance appearance71 = new Appearance();
    ControlContainerTool controlContainerTool3 = new ControlContainerTool("ControlContainerTool1");
    ControlContainerTool controlContainerTool4 = new ControlContainerTool("ControlContainerTool2");
    ButtonTool buttonTool30 = new ButtonTool("BANKINFO");
    Appearance appearance72 = new Appearance();
    ButtonTool buttonTool31 = new ButtonTool("VIEWTREE");
    Appearance appearance73 = new Appearance();
    ButtonTool buttonTool32 = new ButtonTool("PRINT");
    Appearance appearance74 = new Appearance();
    ButtonTool buttonTool33 = new ButtonTool("SYNC");
    Appearance appearance75 = new Appearance();
    ButtonTool buttonTool34 = new ButtonTool("Help");
    Appearance appearance76 = new Appearance();
    ButtonTool buttonTool35 = new ButtonTool("AUTOMATIONEXCEPTIONS");
    Appearance appearance77 = new Appearance();
    ButtonTool buttonTool36 = new ButtonTool("OFFICE_CLASS_MANAGER");
    Appearance appearance78 = new Appearance();
    ButtonTool buttonTool37 = new ButtonTool("ButtonTool1");
    this.FormBackground_Fill_Panel = new Panel();
    this.panelLoadingCompany = new EllipsePanel();
    this.pictureBox1 = new PictureBox();
    this.ultraLabel1 = new UltraLabel();
    this.chkFiltered = new UltraCheckEditor();
    this.comboGLCompany = new MGASimpleComboBox();
    this.dropDownAutomationSettings = new UltraDropDown();
    this.dsGLMasterAutomationSettings1 = new dsGLMasterAutomationSettings();
    this.dropDownAccountTypes = new UltraDropDown();
    this.dsGLAccountTypes1 = new dsGLAccountTypes();
    this.gridMasterAccounts = new UltraGrid();
    this.dsGLAccountMaster1 = new dsGLAccountMaster();
    this._FormBackground_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormBackground_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormBackground_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormBackground_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.FormBackground_Fill_Panel.SuspendLayout();
    this.panelLoadingCompany.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    ((ISupportInitialize) this.chkFiltered).BeginInit();
    ((ISupportInitialize) this.comboGLCompany).BeginInit();
    ((ISupportInitialize) this.dropDownAutomationSettings).BeginInit();
    this.dsGLMasterAutomationSettings1.BeginInit();
    ((ISupportInitialize) this.dropDownAccountTypes).BeginInit();
    this.dsGLAccountTypes1.BeginInit();
    ((ISupportInitialize) this.gridMasterAccounts).BeginInit();
    this.dsGLAccountMaster1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.FormBackground_Fill_Panel.BackColor = Color.Transparent;
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.panelLoadingCompany);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.chkFiltered);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.comboGLCompany);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.dropDownAutomationSettings);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.dropDownAccountTypes);
    this.FormBackground_Fill_Panel.Controls.Add((Control) this.gridMasterAccounts);
    this.FormBackground_Fill_Panel.Cursor = Cursors.Default;
    this.FormBackground_Fill_Panel.Dock = DockStyle.Fill;
    this.FormBackground_Fill_Panel.Location = new Point(0, 91);
    this.FormBackground_Fill_Panel.Name = "FormBackground_Fill_Panel";
    this.FormBackground_Fill_Panel.Size = new Size(987, 465);
    this.FormBackground_Fill_Panel.TabIndex = 0;
    this.panelLoadingCompany.Anchor = AnchorStyles.Top;
    this.panelLoadingCompany.Controls.Add((Control) this.pictureBox1);
    this.panelLoadingCompany.Controls.Add((Control) this.ultraLabel1);
    this.panelLoadingCompany.Location = new Point(302, 151);
    this.panelLoadingCompany.Name = "panelLoadingCompany";
    this.panelLoadingCompany.Size = new Size(406, 100);
    this.panelLoadingCompany.TabIndex = 7;
    this.panelLoadingCompany.Visible = false;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(0, 47);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(404, 50);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox1.TabIndex = 1;
    this.pictureBox1.TabStop = false;
    ((AppearanceBase) appearance1).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance1).FontData.SizeInPoints = 14f;
    ((AppearanceBase) appearance1).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance1).TextVAlignAsString = "Middle";
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel1).Location = new Point(3, 19);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(400, 23);
    ((Control) this.ultraLabel1).TabIndex = 0;
    ((Control) this.ultraLabel1).Text = "Retreiving GL Company Information....";
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 210);
    ((UltraToggleEditorBase) this.chkFiltered).Appearance = (AppearanceBase) appearance2;
    ((Control) this.chkFiltered).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFiltered).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFiltered).CheckAlign = ContentAlignment.MiddleRight;
    ((Control) this.chkFiltered).Location = new Point(82, 187);
    ((Control) this.chkFiltered).Name = "chkFiltered";
    ((Control) this.chkFiltered).Size = new Size(69, 20);
    ((Control) this.chkFiltered).TabIndex = 6;
    ((Control) this.chkFiltered).Text = "  Filtered";
    ((UltraToggleEditorBase) this.chkFiltered).CheckedChanged += new EventHandler(this.chkFiltered_CheckedChanged);
    this.comboGLCompany.BorderStyle = (UIElementBorderStyle) 4;
    this.comboGLCompany.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboGLCompany).DropDownWidth = 300;
    ((Control) this.comboGLCompany).Location = new Point(82, 213);
    this.comboGLCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLCompany).Name = "comboGLCompany";
    ((Control) this.comboGLCompany).Size = new Size(151, 20);
    ((Control) this.comboGLCompany).TabIndex = 5;
    ((UltraControlBase) this.comboGLCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLCompany).UseOsThemes = (DefaultableBoolean) 2;
    this.comboGLCompany.RowSelected += new RowSelectedEventHandler(this.comboGLCompany_RowSelected);
    ((UltraGridBase) this.dropDownAutomationSettings).DataMember = "AutomationSettings";
    ((UltraGridBase) this.dropDownAutomationSettings).DataSource = (object) this.dsGLMasterAutomationSettings1;
    ((AppearanceBase) appearance3).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 210);
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 285;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridBand1.Override.CellAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridBand1.Override.RowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance6).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance7;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance8).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance8).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance8).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance9).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance9).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance10).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance11).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BorderColor = Color.Silver;
    ((AppearanceBase) appearance12).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance13).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance13).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance13).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance13).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance15).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance15).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownAutomationSettings).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropDownAutomationSettings).DisplayMember = "AutomationSetting";
    ((Control) this.dropDownAutomationSettings).Location = new Point(596, 65);
    ((Control) this.dropDownAutomationSettings).Name = "dropDownAutomationSettings";
    ((Control) this.dropDownAutomationSettings).Size = new Size(290, 80 /*0x50*/);
    ((Control) this.dropDownAutomationSettings).TabIndex = 2;
    ((UltraDropDownBase) this.dropDownAutomationSettings).ValueMember = "AutomationSettingId";
    ((Control) this.dropDownAutomationSettings).Visible = false;
    this.dsGLMasterAutomationSettings1.DataSetName = "dsGLMasterAutomationSettings";
    this.dsGLMasterAutomationSettings1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.dropDownAccountTypes).DataMember = "TypesList";
    ((UltraGridBase) this.dropDownAccountTypes).DataSource = (object) this.dsGLAccountTypes1;
    ((AppearanceBase) appearance17).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 210);
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Appearance = (AppearanceBase) appearance17;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 1;
    ultraGridColumn4.Width = 272;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridBand2.Override.CellAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridBand2.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance20).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance20).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance20).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance21;
    ((SpecialBoxBase) ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance22).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance22).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance22).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance23).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance23).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance24).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance25).BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).BorderColor = Color.Silver;
    ((AppearanceBase) appearance26).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance27).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance27).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance27).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance27).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance27).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance29).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance29).BorderColor = Color.Silver;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance30).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropDownAccountTypes).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropDownAccountTypes).DisplayMember = "AcctTypeDescription";
    ((Control) this.dropDownAccountTypes).Location = new Point(333, 65);
    ((Control) this.dropDownAccountTypes).Name = "dropDownAccountTypes";
    ((Control) this.dropDownAccountTypes).Size = new Size(280, 80 /*0x50*/);
    ((Control) this.dropDownAccountTypes).TabIndex = 1;
    ((Control) this.dropDownAccountTypes).Text = "ultraDropDown1";
    ((UltraDropDownBase) this.dropDownAccountTypes).ValueMember = "AcctTypeId";
    ((Control) this.dropDownAccountTypes).Visible = false;
    this.dsGLAccountTypes1.DataSetName = "dsGLAccountTypes";
    this.dsGLAccountTypes1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.gridMasterAccounts).DataSource = (object) this.dsGLAccountMaster1;
    ((AppearanceBase) appearance31).BackColor = Color.White;
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Appearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Master ID";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 1;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 152;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 2;
    ultraGridColumn6.Width = 232;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Account Short Name";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 3;
    ultraGridColumn7.MaxLength = 15;
    ultraGridColumn7.Width = 152;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 4;
    ultraGridColumn8.Width = 103;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 5;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 189;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 6;
    ultraGridColumn10.Style = (ColumnStyle) 6;
    ultraGridColumn10.Width = 232;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 7;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 96 /*0x60*/;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Automation Setting";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 8;
    ultraGridColumn12.Style = (ColumnStyle) 6;
    ultraGridColumn12.Width = 162;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.DefaultCellValue = (object) "False";
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Bank Account";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 9;
    ultraGridColumn13.Width = 104;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn14.Header).Caption = "";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 0;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Style = (ColumnStyle) 3;
    ultraGridColumn14.Width = 28;
    ultraGridBand3.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion1);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion2);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion3);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion4);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.ColScrollRegions.Add((object) colScrollRegion5);
    ((AppearanceBase) appearance32).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance32).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance32).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 4;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance33).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance34).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance35).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance35;
    ((AppearanceBase) appearance36).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance37).BackColor = Color.Transparent;
    ((AppearanceBase) appearance37).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.Override.TemplateAddRowPrompt = "Please type here to add a new GL Account...";
    ((AppearanceBase) appearance39).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance39).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance39;
    ((AppearanceBase) appearance40).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.gridMasterAccounts).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridMasterAccounts).Dock = DockStyle.Fill;
    ((Control) this.gridMasterAccounts).Font = new Font("Tahoma", 8.25f);
    ((AppearanceBase) appearance41).BackColor = Color.White;
    ((AppearanceBase) appearance41).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance41;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Master ID";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 1;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 152;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 2;
    ultraGridColumn16.Width = 232;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Account Short Name";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 3;
    ultraGridColumn17.MaxLength = 15;
    ultraGridColumn17.Width = 152;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 4;
    ultraGridColumn18.Width = 103;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 5;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 189;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 6;
    ultraGridColumn20.Style = (ColumnStyle) 6;
    ultraGridColumn20.Width = 232;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 7;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 96 /*0x60*/;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Automation Setting";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 8;
    ultraGridColumn22.Style = (ColumnStyle) 6;
    ultraGridColumn22.Width = 162;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn23.DefaultCellValue = (object) "False";
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Bank Account";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 9;
    ultraGridColumn23.Width = 104;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn24.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn24.Header).Caption = "";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 0;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Style = (ColumnStyle) 3;
    ultraGridColumn24.Width = 28;
    ultraGridBand4.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24
    });
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand4);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout1.ColScrollRegions.Add((object) colScrollRegion6);
    ultraGridLayout1.ColScrollRegions.Add((object) colScrollRegion7);
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "Layout1";
    ((AppearanceBase) appearance42).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance42).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance42).ForeColor = Color.Black;
    ultraGridLayout1.Override.ActiveRowAppearance = (AppearanceBase) appearance42;
    ultraGridLayout1.Override.AllowAddNew = (AllowAddNew) 4;
    ultraGridLayout1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout1.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance43).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.CellAppearance = (AppearanceBase) appearance43;
    ((AppearanceBase) appearance44).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance44).TextHAlignAsString = "Left";
    ultraGridLayout1.Override.HeaderAppearance = (AppearanceBase) appearance44;
    ultraGridLayout1.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance45).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout1.Override.RowAlternateAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance46;
    ultraGridLayout1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance47).BackColor = Color.Transparent;
    ((AppearanceBase) appearance47).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).BackColor = Color.LightSteelBlue;
    ultraGridLayout1.Override.TemplateAddRowAppearance = (AppearanceBase) appearance48;
    ultraGridLayout1.Override.TemplateAddRowPrompt = "Please type here to add a new GL Account...";
    ((AppearanceBase) appearance49).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance49).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance49;
    ((AppearanceBase) appearance50).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance50;
    ultraGridLayout1.ScrollBarLook = scrollBarLook2;
    ((AppearanceBase) appearance51).BackColor = Color.White;
    ((AppearanceBase) appearance51).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout2.Appearance = (AppearanceBase) appearance51;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Master ID";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 1;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 152;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 2;
    ultraGridColumn26.Width = 280;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn27.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Account Short Name";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 3;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 146;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn28.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 4;
    ultraGridColumn28.Width = 153;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn29.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 5;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 189;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn30.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 6;
    ultraGridColumn30.Style = (ColumnStyle) 6;
    ultraGridColumn30.Width = 238;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn31.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 7;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 96 /*0x60*/;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn32.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Automation Setting";
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 8;
    ultraGridColumn32.Style = (ColumnStyle) 6;
    ultraGridColumn32.Width = 174;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn33.CellActivation = (Activation) 3;
    ultraGridColumn33.DefaultCellValue = (object) "False";
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Bank Account";
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 9;
    ultraGridColumn33.Width = 109;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn34.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn34.Header).Caption = "";
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 0;
    ultraGridColumn34.Style = (ColumnStyle) 3;
    ultraGridColumn34.Width = 31 /*0x1F*/;
    ultraGridBand5.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34
    });
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand5);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout2.ColScrollRegions.Add((object) colScrollRegion8);
    ultraGridLayout2.ColScrollRegions.Add((object) colScrollRegion9);
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "Layout2";
    ((AppearanceBase) appearance52).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance52).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance52).ForeColor = Color.Black;
    ultraGridLayout2.Override.ActiveRowAppearance = (AppearanceBase) appearance52;
    ultraGridLayout2.Override.AllowAddNew = (AllowAddNew) 4;
    ultraGridLayout2.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout2.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout2.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance53).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.CellAppearance = (AppearanceBase) appearance53;
    ((AppearanceBase) appearance54).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance54).TextHAlignAsString = "Left";
    ultraGridLayout2.Override.HeaderAppearance = (AppearanceBase) appearance54;
    ultraGridLayout2.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance55).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout2.Override.RowAlternateAppearance = (AppearanceBase) appearance55;
    ((AppearanceBase) appearance56).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance56;
    ultraGridLayout2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance57).BackColor = Color.Transparent;
    ((AppearanceBase) appearance57).ForeColor = Color.Black;
    ultraGridLayout2.Override.SelectedRowAppearance = (AppearanceBase) appearance57;
    ((AppearanceBase) appearance58).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance58).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance58;
    ((AppearanceBase) appearance59).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance59;
    ultraGridLayout2.ScrollBarLook = scrollBarLook3;
    ((UltraGridBase) this.gridMasterAccounts).Layouts.Add(ultraGridLayout1);
    ((UltraGridBase) this.gridMasterAccounts).Layouts.Add(ultraGridLayout2);
    ((Control) this.gridMasterAccounts).Location = new Point(0, 0);
    ((Control) this.gridMasterAccounts).Name = "gridMasterAccounts";
    ((Control) this.gridMasterAccounts).Size = new Size(987, 465);
    ((Control) this.gridMasterAccounts).TabIndex = 0;
    this.gridMasterAccounts.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridMasterAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridMasterAccounts).UseOsThemes = (DefaultableBoolean) 2;
    this.gridMasterAccounts.InitializeRow += new InitializeRowEventHandler(this.gridMasterAccounts_InitializeRow);
    this.gridMasterAccounts.BeforeRowUpdate += new CancelableRowEventHandler(this.gridMasterAccounts_BeforeRowUpdate);
    this.gridMasterAccounts.CellListSelect += new CellEventHandler(this.gridMasterAccounts_CellListSelect);
    this.gridMasterAccounts.BeforeCellListDropDown += new CancelableCellEventHandler(this.gridMasterAccounts_BeforeCellListDropDown);
    this.dsGLAccountMaster1.DataSetName = "dsGLAccountMaster";
    this.dsGLAccountMaster1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._FormBackground_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).Location = new Point(0, 91);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).Name = "_FormBackground_Toolbars_Dock_Area_Left";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Left).Size = new Size(0, 465);
    this._FormBackground_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool7).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool9).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool10).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool11).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool12).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool14).InstanceProps.IsFirstInGroup = true;
    controlContainerTool1.ControlName = "comboGLCompany";
    ((ToolPropsBase) ((ToolBase) controlContainerTool1).InstanceProps).Width = 151;
    controlContainerTool2.ControlName = "chkFiltered";
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).InstanceProps).Width = 69;
    ((ToolBase) buttonTool15).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool16).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool17).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool18).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[20]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) controlContainerTool1,
      (ToolBase) controlContainerTool2,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18
    });
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Text = "MainBar";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.ultraToolbarsManager1.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockBottom = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockLeft = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockRight = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowDockTop = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance60).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance60).BackColor2 = Color.White;
    ((AppearanceBase) appearance60).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance60).BackGradientStyle = (GradientStyle) 14;
    ((SettingsBase) this.ultraToolbarsManager1.ToolbarSettings).Appearance = (AppearanceBase) appearance60;
    ((AppearanceBase) appearance61).Image = (object) Resources.NewChartOfAccounts;
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance61;
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).Caption = "Generate Chart Of Accounts";
    ((ToolBase) buttonTool19).SharedPropsInternal.Category = "Generate";
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance62).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance62;
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).Caption = "Delete Account";
    ((ToolBase) buttonTool20).SharedPropsInternal.Category = "MainOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance63).Image = (object) Resources.calendar;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance63;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).Caption = "Fiscal Configurations";
    ((ToolBase) buttonTool21).SharedPropsInternal.Category = "MainOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance64).Image = (object) Resources.pencil;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance64;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).Caption = "Journal Entry";
    ((ToolBase) buttonTool22).SharedPropsInternal.Category = "MainOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance65).Image = (object) Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance65;
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).Caption = "Save Changes";
    ((ToolPropsBase) ((ToolBase) buttonTool23).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool23).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance66).Image = (object) Resources.cross;
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance66;
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).Caption = "Cancel Changes";
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool24).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance67).Image = (object) Resources.cross;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance67;
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).Caption = "Cancel";
    ((ToolBase) buttonTool25).SharedPropsInternal.Category = "GenerateOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool25).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance68).Image = (object) Resources.accept;
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance68;
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).Caption = "Select All";
    ((ToolBase) buttonTool26).SharedPropsInternal.Category = "GenerateOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance69).Image = (object) Resources.refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance69;
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).Caption = "De-Select All";
    ((ToolBase) buttonTool27).SharedPropsInternal.Category = "GenerateOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance70).Image = (object) Resources.flag_orange;
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance70;
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).Caption = "Account Class Manager";
    ((ToolBase) buttonTool28).SharedPropsInternal.Category = "MainOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance71).Image = (object) Resources.createchart;
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance71;
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).Caption = "Create Chart";
    ((ToolBase) buttonTool29).SharedPropsInternal.Category = "GenerateOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool3.ControlName = "comboGLCompany";
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).Caption = "ControlContainerTool1";
    ((ToolBase) controlContainerTool3).SharedPropsInternal.Category = "MainOptions";
    ((ToolBase) controlContainerTool3).SharedPropsInternal.StatusText = "Filter Company";
    ((ToolBase) controlContainerTool3).SharedPropsInternal.ToolTipText = "Filter Company";
    ((ToolPropsBase) ((ToolBase) controlContainerTool3).SharedPropsInternal).Width = 151;
    controlContainerTool4.ControlName = "chkFiltered";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Caption = "ControlContainerTool2";
    ((ToolBase) controlContainerTool4).SharedPropsInternal.Category = "MainOptions";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Width = 69;
    ((AppearanceBase) appearance72).Image = (object) Resources.bank;
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance72;
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).Caption = "View/Edit Bank Information";
    ((ToolBase) buttonTool30).SharedPropsInternal.Category = "MainOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance73).Image = (object) Resources.app_tree;
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance73;
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedPropsInternal).Caption = "View Account Tree";
    ((ToolBase) buttonTool31).SharedPropsInternal.Category = "MainOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance74).Image = (object) Resources.printer;
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance74;
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedPropsInternal).Caption = "Print";
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance75).Image = (object) Resources.table_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool33).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance75;
    ((ToolPropsBase) ((ToolBase) buttonTool33).SharedPropsInternal).Caption = "Sync Charts";
    ((ToolPropsBase) ((ToolBase) buttonTool33).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance76).Image = componentResourceManager.GetObject("appearance76.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool34).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance76;
    ((ToolPropsBase) ((ToolBase) buttonTool34).SharedPropsInternal).Caption = "Help";
    ((AppearanceBase) appearance77).Image = (object) Resources.exclamation;
    ((ToolPropsBase) ((ToolBase) buttonTool35).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance77;
    ((ToolPropsBase) ((ToolBase) buttonTool35).SharedPropsInternal).Caption = "Automation Rule Exceptions";
    ((ToolPropsBase) ((ToolBase) buttonTool35).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool35).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance78).Image = (object) Resources.flag_blue;
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance78;
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedPropsInternal).Caption = "Office Account Class Manager";
    ((ToolBase) buttonTool36).SharedPropsInternal.Category = "MainOptions";
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedPropsInternal).Caption = "ButtonTool1";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[21]
    {
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27,
      (ToolBase) buttonTool28,
      (ToolBase) buttonTool29,
      (ToolBase) controlContainerTool3,
      (ToolBase) controlContainerTool4,
      (ToolBase) buttonTool30,
      (ToolBase) buttonTool31,
      (ToolBase) buttonTool32,
      (ToolBase) buttonTool33,
      (ToolBase) buttonTool34,
      (ToolBase) buttonTool35,
      (ToolBase) buttonTool36,
      (ToolBase) buttonTool37
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._FormBackground_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).Location = new Point(987, 91);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).Name = "_FormBackground_Toolbars_Dock_Area_Right";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Right).Size = new Size(0, 465);
    this._FormBackground_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormBackground_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).Name = "_FormBackground_Toolbars_Dock_Area_Top";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Top).Size = new Size(987, 91);
    this._FormBackground_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._FormBackground_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).Location = new Point(0, 556);
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).Name = "_FormBackground_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormBackground_Toolbars_Dock_Area_Bottom).Size = new Size(987, 0);
    this._FormBackground_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(987, 556);
    this.Controls.Add((Control) this.FormBackground_Fill_Panel);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormBackground_Toolbars_Dock_Area_Top);
    this.MinimizeBox = false;
    this.MinimumSize = new Size(995, 590);
    this.Name = nameof (FormMasterAccounts);
    this.Text = "General Ledger Account Management";
    this.Load += new EventHandler(this.FormMasterAccounts_Load);
    this.FormBackground_Fill_Panel.ResumeLayout(false);
    this.FormBackground_Fill_Panel.PerformLayout();
    this.panelLoadingCompany.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    ((ISupportInitialize) this.chkFiltered).EndInit();
    ((ISupportInitialize) this.comboGLCompany).EndInit();
    ((ISupportInitialize) this.dropDownAutomationSettings).EndInit();
    this.dsGLMasterAutomationSettings1.EndInit();
    ((ISupportInitialize) this.dropDownAccountTypes).EndInit();
    this.dsGLAccountTypes1.EndInit();
    ((ISupportInitialize) this.gridMasterAccounts).EndInit();
    this.dsGLAccountMaster1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
