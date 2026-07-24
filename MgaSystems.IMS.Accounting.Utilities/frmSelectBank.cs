// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Utilities.frmSelectBank
// Assembly: MgaSystems.IMS.Accounting.Utilities, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 0980F864-5BDB-427E-98EE-09B90661DBB2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Utilities.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Utilities;

[SecureResource("{B4247FCA-E779-4898-80E1-A940AC046790}", "Posting Bank Override Rights", "This security option gives the user rights to override the default bank account when posting a receivable.", "Accounting")]
public sealed class frmSelectBank : FormBase
{
  private int _glCompanyId;
  private bool _hasRights;
  private int _bankAccountId;
  private IContainer components;

  internal virtual MGAButton buttonOk
  {
    get => this._buttonOk;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOK_Click);
      MGAButton buttonOk1 = this._buttonOk;
      if (buttonOk1 != null)
        ((Control) buttonOk1).Click -= eventHandler;
      this._buttonOk = value;
      MGAButton buttonOk2 = this._buttonOk;
      if (buttonOk2 == null)
        return;
      ((Control) buttonOk2).Click += eventHandler;
    }
  }

  internal virtual MGAButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      MGAButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  public int GLCompanyId
  {
    get => this._glCompanyId;
    set => this._glCompanyId = value;
  }

  public int BankAccountId
  {
    get => this._bankAccountId;
    set => this._bankAccountId = value;
  }

  public frmSelectBank(int GLCompanyId)
  {
    this.Load += new EventHandler(this.frmSelectBank_Load);
    this._hasRights = false;
    this.InitializeComponent();
    this._glCompanyId = GLCompanyId;
    this._bankAccountId = -1;
  }

  public frmSelectBank(int GLCompanyId, bool hasPostingBankRights)
  {
    this.Load += new EventHandler(this.frmSelectBank_Load);
    this._hasRights = false;
    this.InitializeComponent();
    this._glCompanyId = GLCompanyId;
    this._bankAccountId = -1;
    this._hasRights = hasPostingBankRights;
  }

  public frmSelectBank(int GLCompanyId, int BankAccount)
  {
    this.Load += new EventHandler(this.frmSelectBank_Load);
    this._hasRights = false;
    this.InitializeComponent();
    this._glCompanyId = GLCompanyId;
    this._bankAccountId = BankAccount;
  }

  public frmSelectBank(int GLCompanyId, int BankAccount, bool hasPostingBankRights)
  {
    this.Load += new EventHandler(this.frmSelectBank_Load);
    this._hasRights = false;
    this.InitializeComponent();
    this._glCompanyId = GLCompanyId;
    this._bankAccountId = BankAccount;
    this._hasRights = hasPostingBankRights;
  }

  private frmSelectBank()
  {
    this.Load += new EventHandler(this.frmSelectBank_Load);
    this._hasRights = false;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankAccounts1")]
  internal virtual dsBankAccounts DsBankAccounts1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraCombo cmbBankAccounts
  {
    get => this._cmbBankAccounts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.cmbBankAccounts_RowSelected);
      UltraCombo cmbBankAccounts1 = this._cmbBankAccounts;
      if (cmbBankAccounts1 != null)
        cmbBankAccounts1.RowSelected -= selectedEventHandler;
      this._cmbBankAccounts = value;
      UltraCombo cmbBankAccounts2 = this._cmbBankAccounts;
      if (cmbBankAccounts2 == null)
        return;
      cmbBankAccounts2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("daGetBankAccounts")]
  internal virtual SqlDataAdapter daGetBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBankInfo")]
  internal virtual Label lblBankInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmSelectBank));
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_GetBankAccounts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GLACCTID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("BANKNAME");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CLOSED");
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    this.Label1 = new Label();
    this.ImageList1 = new ImageList(this.components);
    this.lblBankInfo = new Label();
    this.cmbBankAccounts = new UltraCombo();
    this.DsBankAccounts1 = new dsBankAccounts();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.buttonOk = new MGAButton();
    this.buttonCancel = new MGAButton();
    ((ISupportInitialize) this.cmbBankAccounts).BeginInit();
    this.DsBankAccounts1.BeginInit();
    ((ISupportInitialize) this.buttonOk).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.SuspendLayout();
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Dock = DockStyle.Top;
    this.Label1.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(0, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(290, 32 /*0x20*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "This transaction will be booked against the following bank account:";
    this.Label1.TextAlign = ContentAlignment.TopCenter;
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "");
    this.lblBankInfo.BackColor = Color.Transparent;
    this.lblBankInfo.Location = new Point(8, 64 /*0x40*/);
    this.lblBankInfo.Name = "lblBankInfo";
    this.lblBankInfo.Size = new Size(280, 88);
    this.lblBankInfo.TabIndex = 3;
    ((UltraGridBase) this.cmbBankAccounts).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.cmbBankAccounts).DataSource = (object) this.DsBankAccounts1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 261;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridBand.GroupHeadersVisible = false;
    ultraGridBand.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraDropDownBase) this.cmbBankAccounts).DisplayMember = "BANKNAME";
    this.cmbBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbBankAccounts).Location = new Point(8, 40);
    ((Control) this.cmbBankAccounts).Name = "cmbBankAccounts";
    ((Control) this.cmbBankAccounts).Size = new Size(280, 23);
    ((Control) this.cmbBankAccounts).TabIndex = 4;
    ((UltraDropDownBase) this.cmbBankAccounts).ValueMember = "GLACCTID";
    this.DsBankAccounts1.DataSetName = "dsBankAccounts";
    this.DsBankAccounts1.Locale = new CultureInfo("en-US");
    this.daGetBankAccounts.SelectCommand = this.SqlSelectCommand1;
    this.daGetBankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccounts", new DataColumnMapping[3]
      {
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("BANKNAME", "BANKNAME"),
        new DataColumnMapping("CLOSED", "CLOSED")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetBankAccounts]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonOk).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonOk).Location = new Point(208 /*0xD0*/, 152);
    ((Control) this.buttonOk).Name = "buttonOk";
    ((Control) this.buttonOk).Size = new Size(75, 26);
    ((Control) this.buttonOk).TabIndex = 5;
    ((ControlBase) this.buttonOk).Text = "Ok";
    this.buttonOk.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonCancel).Location = new Point((int) sbyte.MaxValue, 152);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(75, 26);
    ((Control) this.buttonCancel).TabIndex = 6;
    ((ControlBase) this.buttonCancel).Text = "Cancel";
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(290, 184);
    this.ControlBox = false;
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonOk);
    this.Controls.Add((Control) this.cmbBankAccounts);
    this.Controls.Add((Control) this.lblBankInfo);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmSelectBank);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Confirm Bank Account?";
    ((ISupportInitialize) this.cmbBankAccounts).EndInit();
    this.DsBankAccounts1.EndInit();
    ((ISupportInitialize) this.buttonOk).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void frmSelectBank_Load(object sender, EventArgs e)
  {
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.LoadBankAccounts();
    if (this.BankAccountId == -1)
      this._bankAccountId = this.GetPrimaryBankAccount();
    this.SetSelectedBankAccount();
    if (this._hasRights)
      return;
    ((Control) this.cmbBankAccounts).Enabled = SecurityManager.Instance.AssertPermission("{B4247FCA-E779-4898-80E1-A940AC046790}");
  }

  private void LoadBankAccounts()
  {
    this.daGetBankAccounts.SelectCommand.Parameters["@GlCompanyId"].Value = (object) this.GLCompanyId;
    this.DsBankAccounts1.Clear();
    this.daGetBankAccounts.Fill((DataTable) this.DsBankAccounts1.spFin_GetBankAccounts);
  }

  private void SetSelectedBankAccount()
  {
    this.cmbBankAccounts.Value = (object) this._bankAccountId;
    this.GetBankAccountInfo(this._bankAccountId);
  }

  private void GetBankAccountInfo(int BankAccountId)
  {
    this.lblBankInfo.Text = Database.Instance.QuerySP.PerformScalarQueryString("spFin_GetBankAccountInfo", (object) "@bankAcctId", (object) BankAccountId);
  }

  private void cmbBankAccounts_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (e.Row == null)
      return;
    this.GetBankAccountInfo(Conversions.ToInteger(e.Row.Cells["GLACCTID"].Value));
    this.BankAccountId = Conversions.ToInteger(e.Row.Cells["GLACCTID"].Value);
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.BankAccountId = -1;
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnOK_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private int GetPrimaryBankAccount()
  {
    int primaryBankAccount;
    try
    {
      primaryBankAccount = MGASystems.IMS.Accounting.Utilities.Tools.GetGLPrimaryBankAccount(this._glCompanyId);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      primaryBankAccount = -1;
      ProjectData.ClearProjectError();
    }
    return primaryBankAccount;
  }
}
