// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formAccountClassificationAutomation
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

[TestForm]
public class formAccountClassificationAutomation : Form
{
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  private MGAButton buttonSave;
  private MGAButton buttonCancel;
  private MGASimpleComboBox comboReceivable;
  private MGASimpleComboBox comboExchange;
  private MGASimpleComboBox comboUnaccounted;
  private MGASimpleComboBox comboPayable;
  private Label label1;
  private Label label2;
  private Label label3;
  private Label label4;
  private SqlDataAdapter daGetFinancialAccountTypes;
  private dsGetGLAcctTypesFinancialReports dsGetGLAcctTypesFinancialReports1;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection FormDataConnection;
  private System.ComponentModel.Container components;

  public formAccountClassificationAutomation()
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.LoadAccountClassifications();
    this.DisplayCurrentSettings();
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
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (formAccountClassificationAutomation));
    Appearance appearance6 = new Appearance();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.label4 = new Label();
    this.label3 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.comboPayable = new MGASimpleComboBox();
    this.comboUnaccounted = new MGASimpleComboBox();
    this.comboExchange = new MGASimpleComboBox();
    this.comboReceivable = new MGASimpleComboBox();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this.daGetFinancialAccountTypes = new SqlDataAdapter();
    this.dsGetGLAcctTypesFinancialReports1 = new dsGetGLAcctTypesFinancialReports();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.comboPayable).BeginInit();
    ((ISupportInitialize) this.comboUnaccounted).BeginInit();
    ((ISupportInitialize) this.comboExchange).BeginInit();
    ((ISupportInitialize) this.comboReceivable).BeginInit();
    ((Control) this.ultraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    this.dsGetGLAcctTypesFinancialReports1.BeginInit();
    this.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label4);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label3);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label2);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.label1);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboPayable);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboUnaccounted);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboExchange);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboReceivable);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(18, 39);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(411, 135);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(8, 72);
    this.label4.Name = "label4";
    this.label4.Size = new Size(123, 16 /*0x10*/);
    this.label4.TabIndex = 4;
    this.label4.Text = "Un-Accounted Accounts:";
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(8, 104);
    this.label3.Name = "label3";
    this.label3.Size = new Size(101, 16 /*0x10*/);
    this.label3.TabIndex = 6;
    this.label3.Text = "Exchange Accounts:";
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(8, 40);
    this.label2.Name = "label2";
    this.label2.Size = new Size(92, 16 /*0x10*/);
    this.label2.TabIndex = 2;
    this.label2.Text = "Payable Accounts:";
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(8, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(106, 16 /*0x10*/);
    this.label1.TabIndex = 0;
    this.label1.Text = "Receivable Accounts:";
    this.comboPayable.BorderStyle = (UIElementBorderStyle) 4;
    this.comboPayable.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboPayable).DataSource = (object) this.dsGetGLAcctTypesFinancialReports1;
    ((UltraDropDownBase) this.comboPayable).DisplayMember = "AcctTypeDescription";
    this.comboPayable.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboPayable).Location = new Point(136, 40);
    this.comboPayable.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPayable).Name = "comboPayable";
    ((Control) this.comboPayable).Size = new Size(272, 20);
    ((Control) this.comboPayable).TabIndex = 3;
    ((UltraDropDownBase) this.comboPayable).ValueMember = "AcctTypeId";
    this.comboUnaccounted.BorderStyle = (UIElementBorderStyle) 4;
    this.comboUnaccounted.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboUnaccounted).DataSource = (object) this.dsGetGLAcctTypesFinancialReports1;
    ((UltraDropDownBase) this.comboUnaccounted).DisplayMember = "AcctTypeDescription";
    this.comboUnaccounted.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboUnaccounted).Location = new Point(136, 72);
    this.comboUnaccounted.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboUnaccounted).Name = "comboUnaccounted";
    ((Control) this.comboUnaccounted).Size = new Size(272, 20);
    ((Control) this.comboUnaccounted).TabIndex = 5;
    ((UltraDropDownBase) this.comboUnaccounted).ValueMember = "AcctTypeId";
    this.comboExchange.BorderStyle = (UIElementBorderStyle) 4;
    this.comboExchange.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboExchange).DataSource = (object) this.dsGetGLAcctTypesFinancialReports1;
    ((UltraDropDownBase) this.comboExchange).DisplayMember = "AcctTypeDescription";
    this.comboExchange.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboExchange).Location = new Point(136, 104);
    this.comboExchange.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboExchange).Name = "comboExchange";
    ((Control) this.comboExchange).Size = new Size(272, 20);
    ((Control) this.comboExchange).TabIndex = 7;
    ((UltraDropDownBase) this.comboExchange).ValueMember = "AcctTypeId";
    this.comboReceivable.BorderStyle = (UIElementBorderStyle) 4;
    this.comboReceivable.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboReceivable).DataSource = (object) this.dsGetGLAcctTypesFinancialReports1;
    ((UltraDropDownBase) this.comboReceivable).DisplayMember = "AcctTypeDescription";
    this.comboReceivable.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboReceivable).Location = new Point(136, 8);
    this.comboReceivable.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboReceivable).Name = "comboReceivable";
    ((Control) this.comboReceivable).Size = new Size(272, 20);
    ((Control) this.comboReceivable).TabIndex = 1;
    ((UltraDropDownBase) this.comboReceivable).ValueMember = "AcctTypeId";
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.buttonSave);
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(18, 205);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(411, 41);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 1;
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance1).BackColor2 = Color.White;
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonCancel).Location = new Point(312, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(96 /*0x60*/, 32 /*0x20*/);
    ((Control) this.buttonCancel).TabIndex = 1;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((Control) this.buttonSave).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance2).BackColor2 = Color.White;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(208 /*0xD0*/, 8);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(96 /*0x60*/, 32 /*0x20*/);
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
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 137;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Account Classification";
    explorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 43;
    explorerBarGroup2.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[2]
    {
      explorerBarGroup1,
      explorerBarGroup2
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
    ((Control) this.ultraExplorerBar1).Size = new Size(440, 264);
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBar1).TabIndex = 0;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.daGetFinancialAccountTypes.SelectCommand = this.sqlSelectCommand1;
    this.daGetFinancialAccountTypes.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetFinancialAcctTypes", new DataColumnMapping[2]
      {
        new DataColumnMapping("AcctTypeId", "AcctTypeId"),
        new DataColumnMapping("AcctTypeDescription", "AcctTypeDescription")
      })
    });
    this.dsGetGLAcctTypesFinancialReports1.DataSetName = "dsGetGLAcctTypesFinancialReports";
    this.dsGetGLAcctTypesFinancialReports1.Locale = new CultureInfo("en-US");
    this.sqlSelectCommand1.CommandText = "[spFin_GetFinancialAcctTypes]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(440, 264);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formAccountClassificationAutomation);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "GL Classification Automation";
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((ISupportInitialize) this.comboPayable).EndInit();
    ((ISupportInitialize) this.comboUnaccounted).EndInit();
    ((ISupportInitialize) this.comboExchange).EndInit();
    ((ISupportInitialize) this.comboReceivable).EndInit();
    ((Control) this.ultraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    this.dsGetGLAcctTypesFinancialReports1.EndInit();
    this.ResumeLayout(false);
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private void LoadAccountClassifications()
  {
    this.daGetFinancialAccountTypes.Fill((DataTable) this.dsGetGLAcctTypesFinancialReports1.AccountTypes);
  }

  private void SaveClassificationSettings(int ArValue, int ApValue, int UaValue, int ExValue)
  {
    Database.Instance.QuerySP.PerformNonQuery("spFin_InsertClassificationAutomation", (object) "@arvalue", (object) ArValue, (object) "@apvalue", (object) ApValue, (object) "@uavalue", (object) UaValue, (object) "@exvalue", (object) ExValue);
  }

  private bool ValidateForm()
  {
    if (((UltraDropDownBase) this.comboReceivable).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a receivable account classification to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.comboReceivable.Focus();
      return false;
    }
    if (((UltraDropDownBase) this.comboPayable).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a payable account classification to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.comboPayable.Focus();
      return false;
    }
    if (((UltraDropDownBase) this.comboUnaccounted).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an unaccounted account classification to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.comboUnaccounted.Focus();
      return false;
    }
    if (((UltraDropDownBase) this.comboExchange).SelectedRow != null)
      return true;
    int num1 = (int) MessageBox.Show("You must select an exchange account classification to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    this.comboExchange.Focus();
    return false;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.SaveClassificationSettings(int.Parse(((UltraDropDownBase) this.comboReceivable).SelectedRow.Cells["AcctTypeId"].Value.ToString()), int.Parse(((UltraDropDownBase) this.comboPayable).SelectedRow.Cells["AcctTypeId"].Value.ToString()), int.Parse(((UltraDropDownBase) this.comboUnaccounted).SelectedRow.Cells["AcctTypeId"].Value.ToString()), int.Parse(((UltraDropDownBase) this.comboExchange).SelectedRow.Cells["AcctTypeId"].Value.ToString()));
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void DisplayCurrentSettings()
  {
    using (DataTable dataTable = Database.Instance.QuerySP.PerformTableQuery("spFin_GetCurrentClassificationSettings"))
    {
      if (dataTable == null || dataTable.Rows.Count == 0)
        return;
      foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
      {
        switch (row["AccountType"].ToString())
        {
          case "AR":
            this.comboReceivable.Value = row["AcctTypeId"];
            continue;
          case "AP":
            this.comboPayable.Value = row["AcctTypeId"];
            continue;
          case "UA":
            this.comboUnaccounted.Value = row["AcctTypeId"];
            continue;
          case "EX":
            this.comboExchange.Value = row["AcctTypeId"];
            continue;
          default:
            continue;
        }
      }
    }
  }
}
