// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formOperatingAutomationAccounts
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

[SecureResource("{98D8D393-D2D3-4a91-943C-FDD3D369B3E9}", "Operating Automation Management Rights", "Determines whether or not a user is allowed access to the operating expense automation account management module.", "Accounting")]
public class formOperatingAutomationAccounts : AccountingNoteDocumentSupport
{
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  private Label label1;
  private Label label2;
  private Label label3;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private MGASimpleComboBox comboOfficeLocations;
  private ExtendedTreeViewDropDown dropTreePrePaid;
  private ExtendedTreeViewDropDown dropTreeAccrued;
  private System.ComponentModel.Container components;

  public formOperatingAutomationAccounts()
  {
    this.InitializeComponent();
    this.LoadOfficeLocations();
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
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formOperatingAutomationAccounts));
    Appearance appearance6 = new Appearance();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.label3 = new Label();
    this.comboOfficeLocations = new MGASimpleComboBox();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.dropTreeAccrued = new ExtendedTreeViewDropDown();
    this.dropTreePrePaid = new ExtendedTreeViewDropDown();
    this.label2 = new Label();
    this.label1 = new Label();
    this.ultraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocations).BeginInit();
    ((Control) this.ultraExplorerBarContainerControl2).SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl3).SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label3);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboOfficeLocations);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(18, 39);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(371, 23);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(0, 0);
    this.label3.Name = "label3";
    this.label3.Size = new Size(83, 17);
    this.label3.TabIndex = 1;
    this.label3.Text = "Office Location:";
    this.comboOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocations.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "";
    this.comboOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocations).Location = new Point(96 /*0x60*/, 0);
    this.comboOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocations).Name = "comboOfficeLocations";
    ((Control) this.comboOfficeLocations).Size = new Size(272, 20);
    ((Control) this.comboOfficeLocations).TabIndex = 0;
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "";
    this.comboOfficeLocations.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocations_RowSelected);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.dropTreeAccrued);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.dropTreePrePaid);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.label2);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.label1);
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(18, 118);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(371, 48 /*0x30*/);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 1;
    this.dropTreeAccrued.DropDownHeight = 300;
    this.dropTreeAccrued.DropDownWidth = 300;
    this.dropTreeAccrued.Location = new Point(112 /*0x70*/, 24);
    this.dropTreeAccrued.Name = "dropTreeAccrued";
    this.dropTreeAccrued.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeAccrued.Size = new Size(256 /*0x0100*/, 20);
    this.dropTreeAccrued.TabIndex = 3;
    this.dropTreeAccrued.UseCheckedStateSelectionOverride = false;
    this.dropTreePrePaid.DropDownHeight = 300;
    this.dropTreePrePaid.DropDownWidth = 300;
    this.dropTreePrePaid.Location = new Point(112 /*0x70*/, 0);
    this.dropTreePrePaid.Name = "dropTreePrePaid";
    this.dropTreePrePaid.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreePrePaid.Size = new Size(256 /*0x0100*/, 20);
    this.dropTreePrePaid.TabIndex = 2;
    this.dropTreePrePaid.UseCheckedStateSelectionOverride = false;
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(0, 24);
    this.label2.Name = "label2";
    this.label2.Size = new Size(98, 17);
    this.label2.TabIndex = 1;
    this.label2.Text = "Accrued Expenses:";
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(0, 0);
    this.label1.Name = "label1";
    this.label1.TabIndex = 0;
    this.label1.Text = "Pre-Paid Expenses:";
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonSave);
    ((Control) this.ultraExplorerBarContainerControl3).Location = new Point(18, 197);
    ((Control) this.ultraExplorerBarContainerControl3).Name = "ultraExplorerBarContainerControl3";
    ((Control) this.ultraExplorerBarContainerControl3).Size = new Size(371, 25);
    ((Control) this.ultraExplorerBarContainerControl3).TabIndex = 2;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonCancel).Location = new Point(272, 0);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 24);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(176 /*0xB0*/, 0);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(88, 24);
    ((Control) this.buttonSave).TabIndex = 0;
    ((Control) this.buttonSave).Text = "Save Settings";
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BackColor2 = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance3;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl2);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl3);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 25;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "GL Office Location";
    explorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 50;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Expense Automation Accounts";
    explorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
    explorerBarGroup3.Settings.ContainerHeight = 27;
    explorerBarGroup3.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    explorerBarGroup3.Text = "Save";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance5).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.White;
    ((AppearanceBase) appearance5).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance5).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance5).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance5).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance5).ImageBackground = (Image) resourceManager.GetObject("appearance5.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance6;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSpacing = 10;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 0);
    this.ultraExplorerBar1.Margins.Bottom = 4;
    this.ultraExplorerBar1.Margins.Left = 4;
    this.ultraExplorerBar1.Margins.Right = 4;
    this.ultraExplorerBar1.Margins.Top = 4;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(400, 240 /*0xF0*/);
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBar1).TabIndex = 0;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.ultraExplorerBar1.GroupCollapsing += new GroupCollapsingEventHandler(this.ultraExplorerBar1_GroupCollapsing);
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(400, 240 /*0xF0*/);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formOperatingAutomationAccounts);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Operating Expense Automation Accounts";
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((ISupportInitialize) this.comboOfficeLocations).EndInit();
    ((Control) this.ultraExplorerBarContainerControl2).ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl3).ResumeLayout(false);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void ultraExplorerBar1_GroupCollapsing(object sender, CancelableGroupEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private void comboOfficeLocations_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocations).SelectedRow == null)
      return;
    this.dropTreePrePaid.LoadGLAccounts(int.Parse(((UltraDropDownBase) this.comboOfficeLocations).SelectedRow.Cells["id"].Value.ToString()));
    this.dropTreeAccrued.LoadGLAccounts(int.Parse(((UltraDropDownBase) this.comboOfficeLocations).SelectedRow.Cells["id"].Value.ToString()));
    this.DisplayCurrentSettings(int.Parse(((UltraDropDownBase) this.comboOfficeLocations).SelectedRow.Cells["id"].Value.ToString()));
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    this.SaveSettings();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocations).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "ID";
  }

  private bool ValidateForm()
  {
    if (((UltraDropDownBase) this.comboOfficeLocations).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a valid office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dropTreeAccrued.GLAccountID == -1 || this.dropTreeAccrued.GLAccountID == 0)
    {
      int num = (int) MessageBox.Show("You must select a valid GL account for accrued expenses.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dropTreePrePaid.GLAccountID != -1 && this.dropTreePrePaid.GLAccountID != 0)
      return true;
    int num1 = (int) MessageBox.Show("You must select a valid GL account for pre-paid expenses.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void SaveSettings()
  {
    if (!this.ValidateForm())
      return;
    SqlCommand cmd = new SqlCommand();
    try
    {
      cmd.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
      cmd.Connection.Open();
      cmd.Transaction = cmd.Connection.BeginTransaction();
      this.SavePrePaidExpenseAccountSetting(cmd, this.dropTreePrePaid.GLAccountID);
      this.SaveAccruedExpenseAccountSetting(cmd, this.dropTreeAccrued.GLAccountID);
      cmd.Transaction.Commit();
    }
    catch (SqlException ex)
    {
      if (cmd.Transaction != null)
        cmd.Transaction.Rollback();
      int num = (int) MessageBox.Show("An error has occurred while trying to save this account setting. " + ex.Errors[0].Message, "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    finally
    {
      if (cmd != null)
      {
        if (cmd.Connection != null)
        {
          if (cmd.Connection.State != ConnectionState.Closed)
            cmd.Connection.Close();
          cmd.Connection.Dispose();
          cmd.Connection = (SqlConnection) null;
        }
        cmd.Dispose();
      }
    }
  }

  private void SavePrePaidExpenseAccountSetting(SqlCommand cmd, int GlAccountId)
  {
    cmd.CommandText = "spFin_InsertPrepaidAutomationAccount";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glacctid", (object) GlAccountId);
    cmd.ExecuteNonQuery();
  }

  private void SaveAccruedExpenseAccountSetting(SqlCommand cmd, int GlAccountId)
  {
    cmd.CommandText = "spFin_InsertAccrualAutomationAccount";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glacctid", (object) GlAccountId);
    cmd.ExecuteNonQuery();
  }

  private void DisplayCurrentSettings(int GlCompanyId)
  {
    using (DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("spFin_GetExpenseAutomationSettings", (object) "@glcompanyid", (object) GlCompanyId))
    {
      if (dataTable == null)
        return;
      foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
      {
        switch (row["acctroleid"].ToString())
        {
          case "ACE":
            this.dropTreeAccrued.SetSelectedNodeByKey(row["glacctid"].ToString());
            continue;
          case "PPE":
            this.dropTreePrePaid.SetSelectedNodeByKey(row["glacctid"].ToString());
            continue;
          default:
            continue;
        }
      }
    }
  }
}
