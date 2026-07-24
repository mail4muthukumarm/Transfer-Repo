// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Controls.AutomationAccountControl
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Exceptions;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Controls;

public class AutomationAccountControl : UserControl
{
  private Label labelAccountRole;
  private Label labelAccountRoleDescription;
  private ExtendedTreeViewDropDown dropTreeGLAccounts;
  private System.ComponentModel.Container components;
  private string _accountRoleId;
  private int _glCompanyId;
  private int _currentGl;

  public AutomationAccountControl(string accountRoleID, int glCompanyId)
  {
    this.InitializeComponent();
    this._accountRoleId = accountRoleID;
    this._glCompanyId = glCompanyId;
    this.GetAccountRole();
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
    this.dropTreeGLAccounts = new ExtendedTreeViewDropDown();
    this.labelAccountRole = new Label();
    this.labelAccountRoleDescription = new Label();
    this.SuspendLayout();
    this.dropTreeGLAccounts.DropDownHeight = 300;
    this.dropTreeGLAccounts.DropDownWidth = 300;
    this.dropTreeGLAccounts.Font = new Font("Tahoma", 8f);
    this.dropTreeGLAccounts.Location = new Point(8, 32 /*0x20*/);
    this.dropTreeGLAccounts.Name = "dropTreeGLAccounts";
    this.dropTreeGLAccounts.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.Cash;
    this.dropTreeGLAccounts.ShowSystemDefinedAccounts = true;
    this.dropTreeGLAccounts.Size = new Size(208 /*0xD0*/, 20);
    this.dropTreeGLAccounts.TabIndex = 0;
    this.dropTreeGLAccounts.UseCheckedStateSelectionOverride = false;
    this.labelAccountRole.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.labelAccountRole.ForeColor = Color.SteelBlue;
    this.labelAccountRole.Location = new Point(8, 8);
    this.labelAccountRole.Name = "labelAccountRole";
    this.labelAccountRole.Size = new Size(216, 23);
    this.labelAccountRole.TabIndex = 1;
    this.labelAccountRole.Text = "label1";
    this.labelAccountRoleDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.labelAccountRoleDescription.Location = new Point(232, 8);
    this.labelAccountRoleDescription.Name = "labelAccountRoleDescription";
    this.labelAccountRoleDescription.Size = new Size(352, 48 /*0x30*/);
    this.labelAccountRoleDescription.TabIndex = 2;
    this.labelAccountRoleDescription.Text = "label1";
    this.labelAccountRoleDescription.TextAlign = ContentAlignment.MiddleLeft;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.labelAccountRoleDescription);
    this.Controls.Add((Control) this.labelAccountRole);
    this.Controls.Add((Control) this.dropTreeGLAccounts);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (AutomationAccountControl);
    this.Size = new Size(592, 64 /*0x40*/);
    this.ResumeLayout(false);
  }

  public bool HasChanges => this.dropTreeGLAccounts.GLAccountID != this._currentGl;

  private void GetAccountRole()
  {
    DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("SpFin_GetAutomationAccountRole", (object) "@AccountRoleId", (object) this._accountRoleId);
    if (dataTable == null || dataTable.Rows.Count == 0)
      throw new AutomationAccountRoleNotFoundExceptions($"The account role {this._accountRoleId} could not be found.");
    this.labelAccountRole.Text = dataTable.Rows[0]["RoleName"].ToString();
    this.labelAccountRoleDescription.Text = dataTable.Rows[0]["Description"].ToString();
    this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyId);
  }

  private void LoadCurrentSettings()
  {
    int automationSetting = Utilities.GetAutomationSetting(this._accountRoleId, this._glCompanyId);
    if (automationSetting == 0)
      return;
    this.dropTreeGLAccounts.SetSelectedNodeByKey(automationSetting.ToString());
    this._currentGl = automationSetting;
  }

  public void SaveSetting()
  {
    if (!this.dropTreeGLAccounts.GLAccountSelected || this.dropTreeGLAccounts.GLAccountID == -1)
      return;
    Database.Instance.QuerySP.PerformNonQuery("spFin_SaveAutomationAccountSettings", (object) "@acctroleid", (object) this._accountRoleId, (object) "@glcompanyid", (object) this._glCompanyId, (object) "@glacctid", (object) this.dropTreeGLAccounts.GLAccountID);
  }
}
