// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.controlOperatingAutomationAccounts
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using System;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class controlOperatingAutomationAccounts : UserControl
{
  private Label lblCompanyLocation;
  private Label labelAccrualFound;
  private Label labelCashFound;
  private Label labelStatus;
  private Label labelGlAccount;
  private Label label1;
  private ExtendedTreeViewDropDown dropTreeAccounts;
  private System.ComponentModel.Container components;
  private int glCompanyId;
  private MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.AccountingMethod accountingMethod;
  private GLAccount glAccount;

  public controlOperatingAutomationAccounts(int GlCompanyId)
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    this.UpdateStyles();
    this.BackColor = Color.Transparent;
    this.glCompanyId = GlCompanyId;
    this.dropTreeAccounts.LoadGLAccounts(this.GlCompanyId);
    this.lblCompanyLocation.Text = Utility.GetGLOfficeName(this.GlCompanyId);
    this.accountingMethod = MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.GetAccountingMethod(this.GlCompanyId);
    this.labelAccrualFound.Visible = this.AccountingMethod == MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.AccountingMethod.Accrual;
    this.labelCashFound.Visible = this.AccountingMethod == MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.AccountingMethod.Cash;
    try
    {
      switch (this.AccountingMethod)
      {
        case MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.AccountingMethod.Accrual:
          if (MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.GetAccruedExpenseAccount(this.GlCompanyId) != null)
          {
            this.glAccount = MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.GetAccruedExpenseAccount(this.GlCompanyId);
            break;
          }
          break;
        case MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.AccountingMethod.Cash:
          if (MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.GetPrepaidExpenseAccount(this.GlCompanyId) != null)
          {
            this.glAccount = MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.GetPrepaidExpenseAccount(this.GlCompanyId);
            break;
          }
          break;
        default:
          this.glAccount = (GLAccount) null;
          break;
      }
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show(ex.Message, "test");
    }
    if (this.glAccount == null)
    {
      this.labelStatus.Text = "UNSPECIFIED";
    }
    else
    {
      this.labelStatus.Text = "";
      this.dropTreeAccounts.SetSelectedNodeByKey(this.glAccount.GLAccountID.ToString());
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
    this.lblCompanyLocation = new Label();
    this.labelAccrualFound = new Label();
    this.labelCashFound = new Label();
    this.labelStatus = new Label();
    this.labelGlAccount = new Label();
    this.label1 = new Label();
    this.dropTreeAccounts = new ExtendedTreeViewDropDown();
    this.SuspendLayout();
    this.lblCompanyLocation.AutoSize = true;
    this.lblCompanyLocation.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCompanyLocation.ForeColor = Color.DarkSlateGray;
    this.lblCompanyLocation.Location = new Point(8, 0);
    this.lblCompanyLocation.Name = "lblCompanyLocation";
    this.lblCompanyLocation.Size = new Size(151, 23);
    this.lblCompanyLocation.TabIndex = 0;
    this.lblCompanyLocation.Text = "[Company Name]";
    this.labelAccrualFound.Location = new Point(8, 24);
    this.labelAccrualFound.Name = "labelAccrualFound";
    this.labelAccrualFound.Size = new Size(504, 32 /*0x20*/);
    this.labelAccrualFound.TabIndex = 1;
    this.labelAccrualFound.Text = "The system has determined that the accounting methodology used for this office location is accrual basis accounting. Please specify an accrued expense account.";
    this.labelCashFound.Location = new Point(8, 24);
    this.labelCashFound.Name = "labelCashFound";
    this.labelCashFound.Size = new Size(512 /*0x0200*/, 32 /*0x20*/);
    this.labelCashFound.TabIndex = 2;
    this.labelCashFound.Text = "The system has determined that the accounting methodology used for this office location is cash basis accounting. Please specify a prepaid expense account.";
    this.labelStatus.AutoSize = true;
    this.labelStatus.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelStatus.ForeColor = Color.Red;
    this.labelStatus.Location = new Point(424, 0);
    this.labelStatus.Name = "labelStatus";
    this.labelStatus.Size = new Size(84, 17);
    this.labelStatus.TabIndex = 3;
    this.labelStatus.Text = "UNSPECIFIED";
    this.labelGlAccount.AutoSize = true;
    this.labelGlAccount.Location = new Point(80 /*0x50*/, 64 /*0x40*/);
    this.labelGlAccount.Name = "labelGlAccount";
    this.labelGlAccount.Size = new Size(65, 17);
    this.labelGlAccount.TabIndex = 4;
    this.labelGlAccount.Text = "GL Account:";
    this.label1.BackColor = Color.Gainsboro;
    this.label1.Location = new Point(8, 104);
    this.label1.Name = "label1";
    this.label1.Size = new Size(504, 1);
    this.label1.TabIndex = 6;
    this.label1.Text = "label1";
    this.dropTreeAccounts.DropDownHeight = 300;
    this.dropTreeAccounts.DropDownWidth = 300;
    this.dropTreeAccounts.Location = new Point(152, 64 /*0x40*/);
    this.dropTreeAccounts.Name = "dropTreeAccounts";
    this.dropTreeAccounts.ShowEquityAccounts = true;
    this.dropTreeAccounts.ShowExpenseAccounts = true;
    this.dropTreeAccounts.ShowIncomeAccounts = true;
    this.dropTreeAccounts.ShowSystemDefinedAccounts = true;
    this.dropTreeAccounts.Size = new Size(280, 20);
    this.dropTreeAccounts.TabIndex = 7;
    this.dropTreeAccounts.UseCheckedStateSelectionOverride = false;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.dropTreeAccounts);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this.labelGlAccount);
    this.Controls.Add((Control) this.labelStatus);
    this.Controls.Add((Control) this.labelCashFound);
    this.Controls.Add((Control) this.labelAccrualFound);
    this.Controls.Add((Control) this.lblCompanyLocation);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (controlOperatingAutomationAccounts);
    this.Size = new Size(526, 112 /*0x70*/);
    this.ResumeLayout(false);
  }

  public int GlCompanyId => this.glCompanyId;

  public MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.AccountingMethod AccountingMethod
  {
    get => this.accountingMethod;
  }

  public GLAccount GlAccount => this.glAccount == null ? (GLAccount) null : this.glAccount;

  public void Save()
  {
    if (this.dropTreeAccounts.GLAccountID == -1 || this.GlAccount != null && this.GlAccount.GLAccountID == this.dropTreeAccounts.GLAccountID)
      return;
    switch (this.accountingMethod)
    {
      case MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.AccountingMethod.Accrual:
        Database.Instance.QuerySP.PerformNonQuery("spFin_InsertAccrualAutomationAccount", (object) "@glacctid", (object) this.dropTreeAccounts.GLAccountID);
        break;
      case MGASystems.IMS.Accounting.GeneralLedger.ClassObjects.Utilities.AccountingMethod.Cash:
        Database.Instance.QuerySP.PerformNonQuery("spFin_InsertPrepaidAutomationAccount", (object) "@glacctid", (object) this.dropTreeAccounts.GLAccountID);
        break;
    }
  }
}
