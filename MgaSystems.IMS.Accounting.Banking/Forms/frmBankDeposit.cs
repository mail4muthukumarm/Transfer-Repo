// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmBankDeposit
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Banking.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{E8D47833-BBC3-43a9-8E95-F0A3290D996A}", "Create Deposit Ticket", "Determines whether or not a user can create deposit tickets.", "Accounting")]
public sealed class frmBankDeposit : Form
{
  private int _glCompanyId;
  private int _bankGLAccount;
  private IContainer components;

  public int GLCompanyId => this._glCompanyId;

  public int BankGLAccount => this._bankGLAccount;

  public frmBankDeposit()
  {
    this.Load += new EventHandler(this.frmBankDeposit_Load);
    this.InitializeComponent();
  }

  public frmBankDeposit(int glCompanyId)
  {
    this.Load += new EventHandler(this.frmBankDeposit_Load);
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
  }

  public frmBankDeposit(int GLCompanyId, int BankAccountGL)
  {
    this.Load += new EventHandler(this.frmBankDeposit_Load);
    this.InitializeComponent();
    this._glCompanyId = GLCompanyId;
    this._bankGLAccount = this.BankGLAccount;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAccountNumber")]
  internal virtual Label lblAccountNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlViewDeposits")]
  internal virtual Panel pnlViewDeposits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox cmbBankAccounts
  {
    get => this._cmbBankAccounts;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.cmbBankAccounts_RowSelected);
      MGASimpleComboBox cmbBankAccounts1 = this._cmbBankAccounts;
      if (cmbBankAccounts1 != null)
        cmbBankAccounts1.RowSelected -= selectedEventHandler;
      this._cmbBankAccounts = value;
      MGASimpleComboBox cmbBankAccounts2 = this._cmbBankAccounts;
      if (cmbBankAccounts2 == null)
        return;
      cmbBankAccounts2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDepositDate")]
  internal virtual MGADateTimePicker dtpDepositDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDepositReference")]
  internal virtual MGATextBox txtDepositReference { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBankAddress")]
  internal virtual Label lblBankAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridAssignedCashReceipts")]
  internal virtual UltraGrid gridAssignedCashReceipts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsAssignedCashReceipts1")]
  internal virtual dsAssignedCashReceipts DsAssignedCashReceipts1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankAccounts1")]
  internal virtual dsBankAccounts DsBankAccounts1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetOfficeLocations")]
  internal virtual SqlDataAdapter daGetOfficeLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox cmbOfficeLocations
  {
    get => this._cmbOfficeLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.cmbOfficeLocations_RowSelected);
      MGASimpleComboBox cmbOfficeLocations1 = this._cmbOfficeLocations;
      if (cmbOfficeLocations1 != null)
        cmbOfficeLocations1.RowSelected -= selectedEventHandler;
      this._cmbOfficeLocations = value;
      MGASimpleComboBox cmbOfficeLocations2 = this._cmbOfficeLocations;
      if (cmbOfficeLocations2 == null)
        return;
      cmbOfficeLocations2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsOfficeLocations1")]
  internal virtual dsOfficeLocations DsOfficeLocations1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsAssignedCashReceipts2")]
  internal virtual dsAssignedCashReceipts DsAssignedCashReceipts2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridOpenCashReceipts")]
  internal virtual UltraGrid gridOpenCashReceipts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankAccounts")]
  internal virtual SqlDataAdapter daGetBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  internal virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetOpenCashReceipts")]
  internal virtual SqlDataAdapter daGetOpenCashReceipts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  internal virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnRemoveAll
  {
    get => this._btnRemoveAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRemoveAll_Click);
      MGAButton btnRemoveAll1 = this._btnRemoveAll;
      if (btnRemoveAll1 != null)
        ((Control) btnRemoveAll1).Click -= eventHandler;
      this._btnRemoveAll = value;
      MGAButton btnRemoveAll2 = this._btnRemoveAll;
      if (btnRemoveAll2 == null)
        return;
      ((Control) btnRemoveAll2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnAddAll
  {
    get => this._btnAddAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddAll_Click);
      MGAButton btnAddAll1 = this._btnAddAll;
      if (btnAddAll1 != null)
        ((Control) btnAddAll1).Click -= eventHandler;
      this._btnAddAll = value;
      MGAButton btnAddAll2 = this._btnAddAll;
      if (btnAddAll2 == null)
        return;
      ((Control) btnAddAll2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnRemove
  {
    get => this._btnRemove;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRemove_Click);
      MGAButton btnRemove1 = this._btnRemove;
      if (btnRemove1 != null)
        ((Control) btnRemove1).Click -= eventHandler;
      this._btnRemove = value;
      MGAButton btnRemove2 = this._btnRemove;
      if (btnRemove2 == null)
        return;
      ((Control) btnRemove2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnAdd
  {
    get => this._btnAdd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAdd_Click);
      MGAButton btnAdd1 = this._btnAdd;
      if (btnAdd1 != null)
        ((Control) btnAdd1).Click -= eventHandler;
      this._btnAdd = value;
      MGAButton btnAdd2 = this._btnAdd;
      if (btnAdd2 == null)
        return;
      ((Control) btnAdd2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraExplorerBar1")]
  internal virtual UltraExplorerBar UltraExplorerBar1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraExplorerBarContainerControl1")]
  internal virtual UltraExplorerBarContainerControl UltraExplorerBarContainerControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraExplorerBarContainerControl2")]
  internal virtual UltraExplorerBarContainerControl UltraExplorerBarContainerControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraExplorerBarContainerControl3")]
  internal virtual UltraExplorerBarContainerControl UltraExplorerBarContainerControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("AssignedCashReceipts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("transactNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("postDate");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("remitterGuid");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Remitter", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CheckNumber");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Amount");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("AssignedCashReceipts", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("transactNum");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("postDate");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("remitterGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Remitter", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CheckNumber");
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Amount");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmBankDeposit));
    Appearance appearance43 = new Appearance();
    this.UltraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.btnSave = new MGAButton();
    this.dtpDepositDate = new MGADateTimePicker();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.txtDepositReference = new MGATextBox();
    this.Label4 = new Label();
    this.lblBankAddress = new Label();
    this.Label5 = new Label();
    this.lblAccountNumber = new Label();
    this.Label10 = new Label();
    this.Label8 = new Label();
    this.cmbBankAccounts = new MGASimpleComboBox();
    this.DsBankAccounts1 = new dsBankAccounts();
    this.cmbOfficeLocations = new MGASimpleComboBox();
    this.DsOfficeLocations1 = new dsOfficeLocations();
    this.UltraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.gridOpenCashReceipts = new UltraGrid();
    this.DsAssignedCashReceipts1 = new dsAssignedCashReceipts();
    this.Panel1 = new Panel();
    this.btnRemove = new MGAButton();
    this.btnRemoveAll = new MGAButton();
    this.btnAdd = new MGAButton();
    this.btnAddAll = new MGAButton();
    this.UltraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.gridAssignedCashReceipts = new UltraGrid();
    this.DsAssignedCashReceipts2 = new dsAssignedCashReceipts();
    this.pnlViewDeposits = new Panel();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daGetOpenCashReceipts = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.ImageList1 = new ImageList(this.components);
    ((Control) this.UltraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.dtpDepositDate).BeginInit();
    ((ISupportInitialize) this.txtDepositReference).BeginInit();
    ((ISupportInitialize) this.cmbBankAccounts).BeginInit();
    this.DsBankAccounts1.BeginInit();
    ((ISupportInitialize) this.cmbOfficeLocations).BeginInit();
    this.DsOfficeLocations1.BeginInit();
    ((Control) this.UltraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.gridOpenCashReceipts).BeginInit();
    this.DsAssignedCashReceipts1.BeginInit();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.btnRemove).BeginInit();
    ((ISupportInitialize) this.btnRemoveAll).BeginInit();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.btnAddAll).BeginInit();
    ((Control) this.UltraExplorerBarContainerControl3).SuspendLayout();
    ((ISupportInitialize) this.gridAssignedCashReceipts).BeginInit();
    this.DsAssignedCashReceipts2.BeginInit();
    this.pnlViewDeposits.SuspendLayout();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    ((Control) this.UltraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.btnSave);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.dtpDepositDate);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label2);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label1);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.txtDepositReference);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label4);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.lblBankAddress);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label5);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.lblAccountNumber);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label10);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.Label8);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.cmbBankAccounts);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.cmbOfficeLocations);
    ((Control) this.UltraExplorerBarContainerControl1).Location = new Point(14, 38);
    ((Control) this.UltraExplorerBarContainerControl1).Name = "UltraExplorerBarContainerControl1";
    ((Control) this.UltraExplorerBarContainerControl1).Size = new Size(438, 192 /*0xC0*/);
    ((Control) this.UltraExplorerBarContainerControl1).TabIndex = 0;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSave).Location = new Point(352, 160 /*0xA0*/);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(72, 24);
    ((Control) this.btnSave).TabIndex = 16 /*0x10*/;
    ((ControlBase) this.btnSave).Text = "&Save";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.Window;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpDepositDate.Appearance = (AppearanceBase) appearance2;
    this.dtpDepositDate.BackColor = SystemColors.Window;
    appearance3.AlphaLevel = (short) 14;
    appearance3.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance3.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance3.BackColorAlpha = (Alpha) 2;
    appearance3.BackGradientAlignment = (GradientAlignment) 4;
    appearance3.BackGradientStyle = (GradientStyle) 5;
    appearance3.BorderAlpha = (Alpha) 1;
    appearance3.BorderColor = Color.FromArgb(78, 122, 171);
    appearance3.ForeColor = Color.FromArgb(49, 85, 153);
    appearance3.ForegroundAlpha = (Alpha) 2;
    this.dtpDepositDate.ButtonAppearance = (AppearanceBase) appearance3;
    ((Control) this.dtpDepositDate).Location = new Point(88, 136);
    this.dtpDepositDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpDepositDate).Name = "dtpDepositDate";
    ((Control) this.dtpDepositDate).Size = new Size(104, 20);
    ((Control) this.dtpDepositDate).TabIndex = 3;
    ((UltraControlBase) this.dtpDepositDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpDepositDate).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(0, 136);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(73, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Deposit Date:";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(0, 24);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Bank Name:";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(0, 160 /*0xA0*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(72, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "Reference #:";
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtDepositReference).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtDepositReference).BackColor = Color.White;
    ((Control) this.txtDepositReference).Location = new Point(88, 160 /*0xA0*/);
    this.txtDepositReference.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtDepositReference).Name = "txtDepositReference";
    ((Control) this.txtDepositReference).Size = new Size(168, 20);
    ((Control) this.txtDepositReference).TabIndex = 5;
    ((UltraControlBase) this.txtDepositReference).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtDepositReference).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Tahoma", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.Red;
    this.Label4.Location = new Point(264, 168);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(89, 12);
    this.Label4.TabIndex = 6;
    this.Label4.Text = "( For Internal Use)";
    this.lblBankAddress.BackColor = Color.Transparent;
    this.lblBankAddress.Location = new Point(88, 48 /*0x30*/);
    this.lblBankAddress.Name = "lblBankAddress";
    this.lblBankAddress.Size = new Size(312, 64 /*0x40*/);
    this.lblBankAddress.TabIndex = 7;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(0, 112 /*0x70*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(61, 13);
    this.Label5.TabIndex = 8;
    this.Label5.Text = "Account #:";
    this.lblAccountNumber.BackColor = Color.Transparent;
    this.lblAccountNumber.Location = new Point(88, 112 /*0x70*/);
    this.lblAccountNumber.Name = "lblAccountNumber";
    this.lblAccountNumber.Size = new Size(312, 23);
    this.lblAccountNumber.TabIndex = 12;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(0, 48 /*0x30*/);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(76, 13);
    this.Label10.TabIndex = 15;
    this.Label10.Text = "Bank Address:";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(0, 0);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(83, 13);
    this.Label8.TabIndex = 13;
    this.Label8.Text = "Office Location:";
    this.cmbBankAccounts.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraControlBase) this.cmbBankAccounts).Cursor = Cursors.Default;
    ((UltraGridBase) this.cmbBankAccounts).DataSource = (object) this.DsBankAccounts1;
    ((UltraDropDownBase) this.cmbBankAccounts).DisplayMember = "BANKNAME";
    this.cmbBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbBankAccounts).Location = new Point(88, 24);
    this.cmbBankAccounts.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbBankAccounts).Name = "cmbBankAccounts";
    ((Control) this.cmbBankAccounts).Size = new Size(312, 21);
    ((Control) this.cmbBankAccounts).TabIndex = 1;
    ((UltraControlBase) this.cmbBankAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbBankAccounts).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbBankAccounts).ValueMember = "GLACCTID";
    this.DsBankAccounts1.DataSetName = "dsBankAccounts";
    this.DsBankAccounts1.Locale = new CultureInfo("en-US");
    this.cmbOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraControlBase) this.cmbOfficeLocations).Cursor = Cursors.Default;
    ((UltraGridBase) this.cmbOfficeLocations).DataMember = "spFin_GetOfficeLocations";
    ((UltraGridBase) this.cmbOfficeLocations).DataSource = (object) this.DsOfficeLocations1;
    ((UltraDropDownBase) this.cmbOfficeLocations).DisplayMember = "Office Location";
    this.cmbOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbOfficeLocations).Location = new Point(88, 0);
    this.cmbOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbOfficeLocations).Name = "cmbOfficeLocations";
    ((Control) this.cmbOfficeLocations).Size = new Size(312, 21);
    ((Control) this.cmbOfficeLocations).TabIndex = 14;
    ((UltraControlBase) this.cmbOfficeLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cmbOfficeLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cmbOfficeLocations).ValueMember = "ID";
    this.DsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.DsOfficeLocations1.Locale = new CultureInfo("en-US");
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.gridOpenCashReceipts);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Panel1);
    ((Control) this.UltraExplorerBarContainerControl2).Location = new Point(471, 38);
    ((Control) this.UltraExplorerBarContainerControl2).Name = "UltraExplorerBarContainerControl2";
    ((Control) this.UltraExplorerBarContainerControl2).Size = new Size(437, 616);
    ((Control) this.UltraExplorerBarContainerControl2).TabIndex = 1;
    ((UltraControlBase) this.gridOpenCashReceipts).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridOpenCashReceipts).DataMember = "AssignedCashReceipts";
    ((UltraGridBase) this.gridOpenCashReceipts).DataSource = (object) this.DsAssignedCashReceipts1;
    appearance5.BackColor = Color.White;
    appearance5.BackGradientStyle = (GradientStyle) 1;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 83;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Post Date";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 88;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 64 /*0x40*/;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance9;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 189;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Check #";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 67;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance13;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 91;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    appearance14.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance15.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance15.FontData.BoldAsString = "True";
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance16.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance16;
    appearance17.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance18.BackColor = Color.White;
    appearance18.BackColor2 = Color.LightSteelBlue;
    appearance18.BackGradientStyle = (GradientStyle) 2;
    appearance18.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance18;
    ((Control) this.gridOpenCashReceipts).Dock = DockStyle.Fill;
    ((Control) this.gridOpenCashReceipts).Location = new Point(0, 0);
    ((Control) this.gridOpenCashReceipts).Name = "gridOpenCashReceipts";
    ((Control) this.gridOpenCashReceipts).Size = new Size(437, 576);
    ((Control) this.gridOpenCashReceipts).TabIndex = 12;
    ((UltraControlBase) this.gridOpenCashReceipts).UseOsThemes = (DefaultableBoolean) 2;
    this.DsAssignedCashReceipts1.DataSetName = "dsAssignedCashReceipts";
    this.DsAssignedCashReceipts1.Locale = new CultureInfo("en-US");
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.btnRemove);
    this.Panel1.Controls.Add((Control) this.btnRemoveAll);
    this.Panel1.Controls.Add((Control) this.btnAdd);
    this.Panel1.Controls.Add((Control) this.btnAddAll);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 576);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(437, 40);
    this.Panel1.TabIndex = 13;
    appearance19.BackColor = Color.FromArgb(248, 248, 248);
    appearance19.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance19.BackGradientStyle = (GradientStyle) 2;
    appearance19.BorderColor = Color.DarkGray;
    appearance19.ImageHAlign = (HAlign) 2;
    appearance19.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRemove).Appearance = (AppearanceBase) appearance19;
    ((Control) this.btnRemove).Location = new Point(206, 8);
    ((Control) this.btnRemove).Name = "btnRemove";
    ((Control) this.btnRemove).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnRemove).TabIndex = 4;
    ((ControlBase) this.btnRemove).Text = "&Remove";
    this.btnRemove.UseOSThemes = (DefaultableBoolean) 2;
    appearance20.BackColor = Color.FromArgb(248, 248, 248);
    appearance20.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance20.BackGradientStyle = (GradientStyle) 2;
    appearance20.BorderColor = Color.DarkGray;
    appearance20.ImageHAlign = (HAlign) 2;
    appearance20.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRemoveAll).Appearance = (AppearanceBase) appearance20;
    ((Control) this.btnRemoveAll).Location = new Point(304, 8);
    ((Control) this.btnRemoveAll).Name = "btnRemoveAll";
    ((Control) this.btnRemoveAll).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnRemoveAll).TabIndex = 6;
    ((ControlBase) this.btnRemoveAll).Text = "Re&move  All ";
    this.btnRemoveAll.UseOSThemes = (DefaultableBoolean) 2;
    appearance21.BackColor = Color.FromArgb(248, 248, 248);
    appearance21.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance21.BackGradientStyle = (GradientStyle) 2;
    appearance21.BorderColor = Color.DarkGray;
    appearance21.ImageHAlign = (HAlign) 2;
    appearance21.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnAdd).Appearance = (AppearanceBase) appearance21;
    ((Control) this.btnAdd).Location = new Point(8, 8);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnAdd).TabIndex = 3;
    ((ControlBase) this.btnAdd).Text = "&Add";
    this.btnAdd.UseOSThemes = (DefaultableBoolean) 2;
    appearance22.BackColor = Color.FromArgb(248, 248, 248);
    appearance22.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance22.BackGradientStyle = (GradientStyle) 2;
    appearance22.BorderColor = Color.DarkGray;
    appearance22.ImageHAlign = (HAlign) 2;
    appearance22.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnAddAll).Appearance = (AppearanceBase) appearance22;
    ((Control) this.btnAddAll).Location = new Point(106, 8);
    ((Control) this.btnAddAll).Name = "btnAddAll";
    ((Control) this.btnAddAll).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnAddAll).TabIndex = 5;
    ((ControlBase) this.btnAddAll).Text = "A&dd All";
    this.btnAddAll.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraExplorerBarContainerControl3).Controls.Add((Control) this.gridAssignedCashReceipts);
    ((Control) this.UltraExplorerBarContainerControl3).Location = new Point(14, 276);
    ((Control) this.UltraExplorerBarContainerControl3).Name = "UltraExplorerBarContainerControl3";
    ((Control) this.UltraExplorerBarContainerControl3).Size = new Size(438, 378);
    ((Control) this.UltraExplorerBarContainerControl3).TabIndex = 2;
    ((UltraControlBase) this.gridAssignedCashReceipts).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridAssignedCashReceipts).DataMember = "AssignedCashReceipts";
    ((UltraGridBase) this.gridAssignedCashReceipts).DataSource = (object) this.DsAssignedCashReceipts2;
    appearance23.BackColor = Color.White;
    appearance23.BackColor2 = Color.White;
    appearance23.BackGradientStyle = (GradientStyle) 1;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Appearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 83;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Post Date";
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 88;
    ultraGridColumn9.Header.VisiblePosition = 2;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 64 /*0x40*/;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance27;
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridColumn10.Width = 190;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Left";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Check #";
    ultraGridColumn11.Header.VisiblePosition = 4;
    ultraGridColumn11.Width = 67;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance30;
    ultraGridColumn12.Format = "c";
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance31;
    ultraGridColumn12.Header.VisiblePosition = 5;
    ultraGridColumn12.Width = 91;
    ultraGridBand2.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance32.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance33.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance33.FontData.BoldAsString = "True";
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance34.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance34;
    appearance35.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance36.BackColor = Color.White;
    appearance36.BackColor2 = Color.LightSteelBlue;
    appearance36.BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance36;
    appearance37.BackColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    appearance37.FontData.BoldAsString = "True";
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance37;
    appearance38.BackColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.SummaryFooterCaptionAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    appearance39.BackColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    appearance39.FontData.BoldAsString = "True";
    ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance39;
    ((Control) this.gridAssignedCashReceipts).Dock = DockStyle.Fill;
    ((Control) this.gridAssignedCashReceipts).Location = new Point(0, 0);
    ((Control) this.gridAssignedCashReceipts).Name = "gridAssignedCashReceipts";
    ((Control) this.gridAssignedCashReceipts).Size = new Size(438, 378);
    ((Control) this.gridAssignedCashReceipts).TabIndex = 11;
    ((UltraControlBase) this.gridAssignedCashReceipts).UseOsThemes = (DefaultableBoolean) 2;
    this.DsAssignedCashReceipts2.DataSetName = "dsAssignedCashReceipts";
    this.DsAssignedCashReceipts2.Locale = new CultureInfo("en-US");
    this.pnlViewDeposits.Controls.Add((Control) this.UltraExplorerBar1);
    this.pnlViewDeposits.Cursor = Cursors.Default;
    this.pnlViewDeposits.Dock = DockStyle.Fill;
    this.pnlViewDeposits.Location = new Point(0, 0);
    this.pnlViewDeposits.Name = "pnlViewDeposits";
    this.pnlViewDeposits.Size = new Size(922, 671);
    this.pnlViewDeposits.TabIndex = 0;
    appearance40.BackColor = Color.White;
    appearance40.BackColor2 = Color.White;
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.Appearance = (AppearanceBase) appearance40;
    this.UltraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.UltraExplorerBar1.ColumnCount = 2;
    this.UltraExplorerBar1.ColumnSpacing = 7;
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl1);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl2);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl3);
    ((Control) this.UltraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.UltraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 194;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Deposit Header Information";
    explorerBarGroup2.Container = this.UltraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 618;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Open Cash Receipts";
    explorerBarGroup3.Container = this.UltraExplorerBarContainerControl3;
    explorerBarGroup3.Settings.ContainerHeight = 380;
    explorerBarGroup3.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    explorerBarGroup3.Text = "Deposit Cash Receipts";
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    appearance41.BackColor = Color.FromArgb(239, 247, 253);
    appearance41.BackColor2 = Color.FromArgb(239, 247, 253);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance41;
    appearance42.AlphaLevel = (short) 38;
    appearance42.BackColor = Color.FromArgb(166, 202, 238);
    appearance42.BackColor2 = Color.FromArgb(166, 202, 238);
    appearance42.BackColorAlpha = (Alpha) 2;
    appearance42.BorderColor = Color.White;
    appearance42.FontData.Name = "Tahoma";
    appearance42.FontData.SizeInPoints = 8f;
    appearance42.ForeColor = Color.DarkBlue;
    appearance42.ForegroundAlpha = (Alpha) 2;
    appearance42.ImageBackground = (Image) componentResourceManager.GetObject("Appearance42.ImageBackground");
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance42;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance43;
    this.UltraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Bottom = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Left = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Right = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Top = 4;
    this.UltraExplorerBar1.GroupSpacing = 10;
    ((Control) this.UltraExplorerBar1).Location = new Point(0, 0);
    this.UltraExplorerBar1.Margins.Bottom = 8;
    this.UltraExplorerBar1.Margins.Left = 8;
    this.UltraExplorerBar1.Margins.Right = 8;
    this.UltraExplorerBar1.Margins.Top = 8;
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.NavigationAllowGroupReorder = false;
    this.UltraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.UltraExplorerBar1).Size = new Size(922, 671);
    ((Control) this.UltraExplorerBar1).TabIndex = 8;
    this.UltraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    ((UltraControlBase) this.UltraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.daGetOfficeLocations.SelectCommand = this.SqlSelectCommand1;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetOfficeLocations]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.daGetBankAccounts.SelectCommand = this.SqlSelectCommand2;
    this.daGetBankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccounts", new DataColumnMapping[3]
      {
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("BANKNAME", "BANKNAME"),
        new DataColumnMapping("CLOSED", "CLOSED")
      })
    });
    this.SqlSelectCommand2.CommandText = "[spFin_GetBankAccounts]";
    this.SqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand2.Connection = this.FormDataConnection;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4)
    });
    this.daGetOpenCashReceipts.SelectCommand = this.SqlSelectCommand3;
    this.daGetOpenCashReceipts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOpenCashReceipts", new DataColumnMapping[6]
      {
        new DataColumnMapping("transactNum", "transactNum"),
        new DataColumnMapping("postDate", "postDate"),
        new DataColumnMapping("remitterGuid", "remitterGuid"),
        new DataColumnMapping("Remitter", "Remitter"),
        new DataColumnMapping("checkNumber", "checkNumber"),
        new DataColumnMapping("Amount", "Amount")
      })
    });
    this.SqlSelectCommand3.CommandText = "[spFin_GetOpenCashReceipts]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.FormDataConnection;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@bankglacctid", SqlDbType.Int, 4)
    });
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "");
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(922, 671);
    this.Controls.Add((Control) this.pnlViewDeposits);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmBankDeposit);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bank Deposits";
    ((Control) this.UltraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.UltraExplorerBarContainerControl1).PerformLayout();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.dtpDepositDate).EndInit();
    ((ISupportInitialize) this.txtDepositReference).EndInit();
    ((ISupportInitialize) this.cmbBankAccounts).EndInit();
    this.DsBankAccounts1.EndInit();
    ((ISupportInitialize) this.cmbOfficeLocations).EndInit();
    this.DsOfficeLocations1.EndInit();
    ((Control) this.UltraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.gridOpenCashReceipts).EndInit();
    this.DsAssignedCashReceipts1.EndInit();
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.btnRemove).EndInit();
    ((ISupportInitialize) this.btnRemoveAll).EndInit();
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.btnAddAll).EndInit();
    ((Control) this.UltraExplorerBarContainerControl3).ResumeLayout(false);
    ((ISupportInitialize) this.gridAssignedCashReceipts).EndInit();
    this.DsAssignedCashReceipts2.EndInit();
    this.pnlViewDeposits.ResumeLayout(false);
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    ((Control) this.UltraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void frmBankDeposit_Load(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{E8D47833-BBC3-43a9-8E95-F0A3290D996A}"))
    {
      Utility.DenyAccess();
      this.BeginInvoke((Delegate) new MethodInvoker(((Form) this).Close));
    }
    else
    {
      this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
      this.LoadOfficeLocations();
    }
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.cmbOfficeLocations).DataSource = (object) Methods.GetOfficeLocationDataset();
    if (((UltraGridBase) this.cmbOfficeLocations).Rows.Count != 0)
      ((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow = ((UltraGridBase) this.cmbOfficeLocations).Rows[0];
    if (this._glCompanyId == 0)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.cmbOfficeLocations).Rows)
    {
      if (Conversions.ToInteger(row.Cells["id"].Value) == this._glCompanyId)
      {
        ((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow = ((UltraGridBase) this.cmbOfficeLocations).Rows[row.Index];
        break;
      }
    }
  }

  private void GetBankAccounts(int GLCompanyId)
  {
    this.Cursor = Cursors.WaitCursor;
    this.DsBankAccounts1.spFin_GetBankAccounts.Clear();
    this.daGetBankAccounts.SelectCommand.Parameters["@GLCOMPANYID"].Value = (object) GLCompanyId;
    this.daGetBankAccounts.Fill((DataTable) this.DsBankAccounts1.spFin_GetBankAccounts);
    this.Cursor = Cursors.Default;
  }

  private void GetBankInformation(int BankGLAccountID)
  {
    this.lblBankAddress.Text = BankingServices.GetBankAccountAddress(BankGLAccountID);
    this.lblAccountNumber.Text = BankingServices.GetBankAccountNumber(BankGLAccountID);
  }

  private void cmbOfficeLocations_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow == null)
      return;
    this.VerifyChange();
    this.GetBankAccounts(Conversions.ToInteger(((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow.Cells["ID"].Value));
  }

  private void VerifyChange()
  {
    if (((UltraGridBase) this.gridAssignedCashReceipts).Rows.Count == 0 || MessageBox.Show("This will cause the current bank deposit changes to be lost. Do you wish to continue?", "Changes Will Be Lost, Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
      return;
    this.ClearCurrentBankDeposit();
  }

  private void ClearCurrentBankDeposit()
  {
    this.DsAssignedCashReceipts1.Clear();
    this.DsAssignedCashReceipts2.Clear();
  }

  private void cmbBankAccounts_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.cmbBankAccounts).SelectedRow == null)
      return;
    this.VerifyChange();
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.GetBankInformation(Conversions.ToInteger(((UltraDropDownBase) this.cmbBankAccounts).SelectedRow.Cells["GLACCTID"].Value));
      this.LoadOpenCashReceipts(Conversions.ToInteger(((UltraDropDownBase) this.cmbBankAccounts).SelectedRow.Cells["GLACCTID"].Value));
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void LoadOpenCashReceipts(int BankGLAccountID)
  {
    if (BankGLAccountID == -1)
      return;
    this.daGetOpenCashReceipts.SelectCommand.Parameters["@bankglacctid"].Value = (object) BankGLAccountID;
    this.DsAssignedCashReceipts1.AssignedCashReceipts.Clear();
    this.daGetOpenCashReceipts.SelectCommand.CommandTimeout = 0;
    this.daGetOpenCashReceipts.Fill((DataTable) this.DsAssignedCashReceipts1.AssignedCashReceipts);
    if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Bands[0].Columns).Exists("User"))
      return;
    UltraGridColumn column = ((UltraGridBase) this.gridOpenCashReceipts).DisplayLayout.Bands[0].Columns["User"];
    column.CellAppearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 1;
  }

  private void btnAddAll_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.DsAssignedCashReceipts2.AssignedCashReceipts.Clear();
      RowEnumerator enumerator = ((UltraGridBase) this.gridOpenCashReceipts).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        dsAssignedCashReceipts.AssignedCashReceiptsRow row = this.DsAssignedCashReceipts2.AssignedCashReceipts.NewAssignedCashReceiptsRow();
        row.transactNum = Conversions.ToInteger(current.Cells["transactnum"].Value);
        row.Amount = Conversions.ToDecimal(current.Cells["amount"].Value);
        row.CheckNumber = current.Cells["checknumber"].Value.ToString();
        row.postDate = Conversions.ToDate(current.Cells["postDate"].Value);
        row.Remitter = current.Cells["remitter"].Value.ToString();
        row.remitterGuid = current.Cells["remitterGuid"].Value.ToString();
        this.DsAssignedCashReceipts2.AssignedCashReceipts.Rows.Add((DataRow) row);
        current.Appearance.BackColor = Color.LightSteelBlue;
      }
      this.BuildDepositSummary();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void btnRemoveAll_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.DsAssignedCashReceipts2.Clear();
      RowEnumerator enumerator = ((UltraGridBase) this.gridOpenCashReceipts).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        if (current.Appearance.BackColor.Equals((object) Color.LightSteelBlue))
          current.Appearance.BackColor = Color.White;
      }
      this.BuildDepositSummary();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void btnRemove_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    int num = ((UltraGridBase) this.gridAssignedCashReceipts).Rows.Count - 1;
    try
    {
      for (; num >= 0; --num)
      {
        if (((UltraGridBase) this.gridAssignedCashReceipts).Rows[num].Selected)
        {
          foreach (UltraGridRow row in ((UltraGridBase) this.gridOpenCashReceipts).Rows)
          {
            if (Conversions.ToInteger(row.Cells["TransactNum"].Value) == Conversions.ToInteger(((UltraGridBase) this.gridAssignedCashReceipts).Rows[num].Cells["TransactNum"].Value))
            {
              row.Appearance.BackColor = Color.White;
              break;
            }
          }
          ((UltraGridBase) this.gridAssignedCashReceipts).Rows[num].Delete(false);
        }
      }
      if (((UltraGridBase) this.gridAssignedCashReceipts).Rows.Count == 0)
        this.DsAssignedCashReceipts2.AssignedCashReceipts.Clear();
      this.BuildDepositSummary();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      RowEnumerator enumerator = ((UltraGridBase) this.gridOpenCashReceipts).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        if (current.Selected && this.DsAssignedCashReceipts2.AssignedCashReceipts.Select($"transactNum = {Conversions.ToInteger(current.Cells["TransactNum"].Value)}").Length == 0)
        {
          dsAssignedCashReceipts.AssignedCashReceiptsRow row = this.DsAssignedCashReceipts2.AssignedCashReceipts.NewAssignedCashReceiptsRow();
          row.transactNum = Conversions.ToInteger(current.Cells["transactnum"].Value);
          row.Amount = Conversions.ToDecimal(current.Cells["amount"].Value);
          row.CheckNumber = current.Cells["checknumber"].Value.ToString();
          row.postDate = Conversions.ToDate(current.Cells["postDate"].Value);
          row.Remitter = current.Cells["remitter"].Value.ToString();
          row.remitterGuid = current.Cells["remitterGuid"].Value.ToString();
          this.DsAssignedCashReceipts2.AssignedCashReceipts.Rows.Add((DataRow) row);
          current.Appearance.BackColor = Color.LightSteelBlue;
          current.Selected = false;
        }
      }
      this.BuildDepositSummary();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void SaveHeader(DateTime DepositDate, int BankGLAccount, string DepositRef = "")
  {
    SqlCommand cmd = new SqlCommand("spFin_AddBankDeposit", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand = cmd;
      sqlCommand.CommandType = CommandType.StoredProcedure;
      sqlCommand.Connection.Open();
      sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
      sqlCommand.Parameters.AddWithValue("@depositDate", (object) DepositDate);
      sqlCommand.Parameters.AddWithValue("@userGuid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand.Parameters.AddWithValue("@depositReference", (object) DepositRef);
      sqlCommand.Parameters.AddWithValue("@bankgl", (object) BankGLAccount);
      int integer = Conversions.ToInteger(sqlCommand.ExecuteScalar());
      this.SaveDetail(cmd, integer);
      sqlCommand.Transaction.Commit();
      CurrentUser.Instance.LogAction($"Created bank deposit id # {integer}", "Banking Logs");
      Utility.PrintDepositTicket(integer);
      this.Close();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      if (cmd != null & cmd.Transaction != null)
        cmd.Transaction.Rollback();
      throw;
    }
    finally
    {
      if (cmd != null)
      {
        if (cmd.Transaction != null)
          cmd.Transaction.Dispose();
        if (cmd.Connection != null)
        {
          cmd.Connection.Close();
          cmd.Connection.Dispose();
        }
        cmd.Dispose();
      }
    }
  }

  private void SaveDetail(SqlCommand cmd, int DepositId)
  {
    SqlCommand sqlCommand = cmd;
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.CommandText = "spFin_AddBankDepositDetail";
    foreach (UltraGridRow row in ((UltraGridBase) this.gridAssignedCashReceipts).Rows)
    {
      sqlCommand.Parameters.Clear();
      sqlCommand.Parameters.AddWithValue("@depositId", (object) DepositId);
      sqlCommand.Parameters.AddWithValue("@transactNum", (object) Conversions.ToInteger(row.Cells["transactNum"].Value));
      sqlCommand.Parameters.AddWithValue("@amount", (object) Conversions.ToDecimal(row.Cells["amount"].Value));
      sqlCommand.ExecuteNonQuery();
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.SaveHeader(Conversions.ToDate(this.dtpDepositDate.Value), Conversions.ToInteger(((UltraDropDownBase) this.cmbBankAccounts).SelectedRow.Cells["GLACCTID"].Value), ((TextEditorControlBase) this.txtDepositReference).Text);
      this.ClearScreen();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void ClearScreen()
  {
    ((Control) this.cmbOfficeLocations).ResetText();
    this.DsAssignedCashReceipts1.AssignedCashReceipts.Clear();
    this.DsAssignedCashReceipts2.AssignedCashReceipts.Clear();
    this.DsBankAccounts1.spFin_GetBankAccounts.Clear();
    this.lblAccountNumber.Text = "";
    this.lblBankAddress.Text = "";
    this.dtpDepositDate.Value = (object) DateTime.Now;
    ((TextEditorControlBase) this.txtDepositReference).Text = "";
  }

  private void BuildDepositSummary()
  {
    SummarySettingsCollection summaries = ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Bands[0].Summaries;
    summaries.Clear();
    summaries.Add("amountSum", (SummaryType) 1, ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Bands[0].Columns["amount"], (SummaryPosition) 3);
    try
    {
      foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.gridAssignedCashReceipts).DisplayLayout.Bands[0].Summaries)
      {
        summary.Appearance.TextHAlign = (HAlign) 3;
        summary.DisplayFormat = "{0:c}";
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private bool VerifyForm()
  {
    bool flag1;
    if (((UltraGridBase) this.gridAssignedCashReceipts).Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("You have not added any cash receipts to this deposit.", "No Cash Receipts Added!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag1 = false;
    }
    else
    {
      DateTime date = this.dtpDepositDate.DateTime.Date;
      bool flag2 = false;
      foreach (UltraGridRow row in ((UltraGridBase) this.gridAssignedCashReceipts).Rows)
      {
        if (DateTime.Compare(Conversions.ToDate(row.Cells["postDate"].Value).Date, date.Date) > 0)
        {
          row.CellAppearance.FontData.Bold = (DefaultableBoolean) 1;
          flag2 = true;
        }
      }
      if (flag2)
      {
        if (MessageBox.Show("The system has determined that you have added cash receipts with a post date that is greater than the specified deposit date. This will likely cause reconcilaition issue and is not recommended. Are you sure you want to do this?", "Deposit With Date Mismatch?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
          foreach (UltraGridRow row in ((UltraGridBase) this.gridAssignedCashReceipts).Rows)
            row.CellAppearance.FontData.Bold = (DefaultableBoolean) 0;
          flag1 = false;
        }
        else
          flag1 = true;
      }
      else
        flag1 = true;
    }
    return flag1;
  }
}
