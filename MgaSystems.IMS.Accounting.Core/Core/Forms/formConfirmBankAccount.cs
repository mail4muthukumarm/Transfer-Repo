// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formConfirmBankAccount
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formConfirmBankAccount : AccountingNoteDocumentSupport
{
  private System.ComponentModel.Container components;
  private int glCompanyId;
  internal Label lblBankInfo;
  internal Label Label1;
  private MGAButton buttonSelectBank;
  private MGAButton buttonCancel;
  private MGASimpleComboBox comboBankAccounts;
  private dsBankAccounts dsBankAccounts1;
  private SqlDataAdapter daGetBankAccounts;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection FormDataConnection;
  private int bankAccountId;

  public formConfirmBankAccount(int glCompanyId)
  {
    this.InitializeComponent();
    this.glCompanyId = glCompanyId;
    this.LoadBankAccounts();
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
    this.lblBankInfo = new Label();
    this.Label1 = new Label();
    this.comboBankAccounts = new MGASimpleComboBox();
    this.buttonSelectBank = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.dsBankAccounts1 = new dsBankAccounts();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    ((ISupportInitialize) this.comboBankAccounts).BeginInit();
    ((ISupportInitialize) this.buttonSelectBank).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.dsBankAccounts1.BeginInit();
    this.SuspendLayout();
    this.lblBankInfo.Location = new Point(8, 56);
    this.lblBankInfo.Name = "lblBankInfo";
    this.lblBankInfo.Size = new Size(280, 88);
    this.lblBankInfo.TabIndex = 5;
    this.Label1.Dock = DockStyle.Top;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(0, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(288, 32 /*0x20*/);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "This transaction will be booked against the following bank account:";
    this.Label1.TextAlign = ContentAlignment.TopCenter;
    this.comboBankAccounts.BorderStyle = (UIElementBorderStyle) 4;
    this.comboBankAccounts.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboBankAccounts).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.comboBankAccounts).DataSource = (object) this.dsBankAccounts1;
    ((UltraDropDownBase) this.comboBankAccounts).DisplayMember = "BANKNAME";
    this.comboBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboBankAccounts).Location = new Point(8, 32 /*0x20*/);
    this.comboBankAccounts.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccounts).Name = "comboBankAccounts";
    ((Control) this.comboBankAccounts).Size = new Size(272, 20);
    ((Control) this.comboBankAccounts).TabIndex = 6;
    ((UltraDropDownBase) this.comboBankAccounts).ValueMember = "GLACCTID";
    this.comboBankAccounts.RowSelected += new RowSelectedEventHandler(this.comboBankAccounts_RowSelected);
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonSelectBank).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonSelectBank).Location = new Point(64 /*0x40*/, 152);
    ((Control) this.buttonSelectBank).Name = "buttonSelectBank";
    ((Control) this.buttonSelectBank).Size = new Size(104, 24);
    ((Control) this.buttonSelectBank).TabIndex = 7;
    ((Control) this.buttonSelectBank).Text = "Select Bank";
    ((Control) this.buttonSelectBank).Click += new EventHandler(this.buttonSelectBank_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(176 /*0xB0*/, 152);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(104, 24);
    ((Control) this.buttonCancel).TabIndex = 8;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.dsBankAccounts1.DataSetName = "dsBankAccounts";
    this.dsBankAccounts1.Locale = new CultureInfo("en-US");
    this.daGetBankAccounts.SelectCommand = this.sqlSelectCommand1;
    this.daGetBankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccounts", new DataColumnMapping[3]
      {
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("BANKNAME", "BANKNAME"),
        new DataColumnMapping("CLOSED", "CLOSED")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_GetBankAccounts]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4));
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.AcceptButton = (IButtonControl) this.buttonSelectBank;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(288, 182);
    this.ControlBox = false;
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonSelectBank);
    this.Controls.Add((Control) this.comboBankAccounts);
    this.Controls.Add((Control) this.lblBankInfo);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formConfirmBankAccount);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Confirm Bank Account...";
    ((ISupportInitialize) this.comboBankAccounts).EndInit();
    ((ISupportInitialize) this.buttonSelectBank).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.dsBankAccounts1.EndInit();
    this.ResumeLayout(false);
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  internal int GLCompanyId
  {
    get => this.glCompanyId;
    set => this.glCompanyId = value;
  }

  internal int BankAccountId => this.bankAccountId;

  private void LoadBankAccounts()
  {
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetBankAccounts.SelectCommand.Parameters["@glcompanyid"].Value = (object) this.glCompanyId;
    this.daGetBankAccounts.Fill((DataTable) this.dsBankAccounts1.spFin_GetBankAccounts);
    this.bankAccountId = AccountingCache.Instance.GlCompany(this.glCompanyId).PrimaryBankAccount.GLAccountID;
    this.comboBankAccounts.Value = (object) this.bankAccountId;
    ((Control) this.comboBankAccounts).Enabled = SecurityManager.Instance.AssertPermission("{6A42AE28-3617-4dfe-BC40-AC979EA71ADC}");
  }

  private void comboBankAccounts_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboBankAccounts).SelectedRow == null)
    {
      this.bankAccountId = -1;
    }
    else
    {
      this.bankAccountId = int.Parse(((UltraDropDownBase) this.comboBankAccounts).SelectedRow.Cells["glacctid"].Value.ToString());
      this.GetBankInfo(this.bankAccountId);
    }
  }

  private void GetBankInfo(int bankGlAccountId)
  {
    this.lblBankInfo.Text = DefaultDatabase.ExecuteScalar<string>("spFin_GetBankAccountInfo", new object[2]
    {
      (object) "@bankAcctId",
      (object) bankGlAccountId
    });
  }

  private void buttonSelectBank_Click(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.comboBankAccounts).SelectedRow == null || int.Parse(this.comboBankAccounts.Value.ToString()) <= 0)
    {
      int num = (int) MessageBox.Show("You must select a bank to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }
}
