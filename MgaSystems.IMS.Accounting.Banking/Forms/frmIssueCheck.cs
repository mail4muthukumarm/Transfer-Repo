// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmIssueCheck
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Utilities;
using Microsoft.VisualBasic;
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

public sealed class frmIssueCheck : Form
{
  private IContainer components;
  private Guid _payeeguid;
  private int _glcompanyid;

  public frmIssueCheck()
  {
    this.Load += new EventHandler(this.frmIssueCheck_Load);
    this.InitializeComponent();
  }

  public frmIssueCheck(Guid PayeeGuid, string PayeeName, int GLCompanyID)
  {
    this.Load += new EventHandler(this.frmIssueCheck_Load);
    this.InitializeComponent();
    this._payeeguid = PayeeGuid;
    this.txtPayee.Text = PayeeName;
    this.lblCheck1Payee.Text = PayeeName;
    this._glcompanyid = GLCompanyID;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("panelCheck1")]
  internal virtual Panel panelCheck1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblVoidCheck1")]
  internal virtual Label lblVoidCheck1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTransactNum1")]
  internal virtual TextBox txtTransactNum1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblVoid1")]
  internal virtual Label lblVoid1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1BankAddress")]
  internal virtual Label lblCheck1BankAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1BankName")]
  internal virtual Label lblCheck1BankName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pic1SearchDate")]
  internal virtual PictureBox pic1SearchDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pic1SearchPayee")]
  internal virtual PictureBox pic1SearchPayee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1Date")]
  internal virtual Label lblCheck1Date { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1AmountCurrency")]
  internal virtual Label lblCheck1AmountCurrency { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1CheckNumber")]
  internal virtual Label lblCheck1CheckNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1Payee")]
  internal virtual Label lblCheck1Payee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1AmountEnglish")]
  internal virtual Label lblCheck1AmountEnglish { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1MGAName")]
  internal virtual Label lblCheck1MGAName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pictCheck1Background")]
  internal virtual PictureBox pictCheck1Background { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheckMemo")]
  internal virtual Label lblCheckMemo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPayee")]
  internal virtual TextBox txtPayee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual TextBox txtCheckAmount
  {
    get => this._txtCheckAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.txtCheckAmount_TextChanged);
      EventHandler eventHandler2 = new EventHandler(this.txtCheckAmount_Leave);
      TextBox txtCheckAmount1 = this._txtCheckAmount;
      if (txtCheckAmount1 != null)
      {
        txtCheckAmount1.TextChanged -= eventHandler1;
        txtCheckAmount1.Leave -= eventHandler2;
      }
      this._txtCheckAmount = value;
      TextBox txtCheckAmount2 = this._txtCheckAmount;
      if (txtCheckAmount2 == null)
        return;
      txtCheckAmount2.TextChanged += eventHandler1;
      txtCheckAmount2.Leave += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ComboBox cmbOfficeLocation
  {
    get => this._cmbOfficeLocation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbOfficeLocation_SelectedValueChanged);
      ComboBox cmbOfficeLocation1 = this._cmbOfficeLocation;
      if (cmbOfficeLocation1 != null)
        cmbOfficeLocation1.SelectedValueChanged -= eventHandler;
      this._cmbOfficeLocation = value;
      ComboBox cmbOfficeLocation2 = this._cmbOfficeLocation;
      if (cmbOfficeLocation2 == null)
        return;
      cmbOfficeLocation2.SelectedValueChanged += eventHandler;
    }
  }

  internal virtual ComboBox cmbBankAccount
  {
    get => this._cmbBankAccount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmbBankAccount_SelectedValueChanged);
      ComboBox cmbBankAccount1 = this._cmbBankAccount;
      if (cmbBankAccount1 != null)
        cmbBankAccount1.SelectedValueChanged -= eventHandler;
      this._cmbBankAccount = value;
      ComboBox cmbBankAccount2 = this._cmbBankAccount;
      if (cmbBankAccount2 == null)
        return;
      cmbBankAccount2.SelectedValueChanged += eventHandler;
    }
  }

  internal virtual ExtendedTreeViewDropDown DropTreeOffset
  {
    get => this._DropTreeOffset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ExtendedTreeViewDropDown.AfterSelectDelegate afterSelectDelegate = new ExtendedTreeViewDropDown.AfterSelectDelegate(this.DropTreeOffset_AfterSelect);
      ExtendedTreeViewDropDown dropTreeOffset1 = this._DropTreeOffset;
      if (dropTreeOffset1 != null)
        dropTreeOffset1.AfterSelect -= afterSelectDelegate;
      this._DropTreeOffset = value;
      ExtendedTreeViewDropDown dropTreeOffset2 = this._DropTreeOffset;
      if (dropTreeOffset2 == null)
        return;
      dropTreeOffset2.AfterSelect += afterSelectDelegate;
    }
  }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual DateTimePicker dtCheckDate
  {
    get => this._dtCheckDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dtCheckDate_ValueChanged);
      DateTimePicker dtCheckDate1 = this._dtCheckDate;
      if (dtCheckDate1 != null)
        dtCheckDate1.ValueChanged -= eventHandler;
      this._dtCheckDate = value;
      DateTimePicker dtCheckDate2 = this._dtCheckDate;
      if (dtCheckDate2 == null)
        return;
      dtCheckDate2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCheckMemo")]
  internal virtual TextBox txtCheckMemo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnSearchPayees
  {
    get => this._btnSearchPayees;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearchPayees_Click);
      Button btnSearchPayees1 = this._btnSearchPayees;
      if (btnSearchPayees1 != null)
        btnSearchPayees1.Click -= eventHandler;
      this._btnSearchPayees = value;
      Button btnSearchPayees2 = this._btnSearchPayees;
      if (btnSearchPayees2 == null)
        return;
      btnSearchPayees2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("DsOfficeLocations1")]
  internal virtual dsOfficeLocations DsOfficeLocations1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetOfficeLocations")]
  internal virtual SqlDataAdapter daGetOfficeLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankAccounts")]
  internal virtual SqlDataAdapter daGetBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  internal virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankAccounts1")]
  internal virtual dsBankAccounts DsBankAccounts1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCheck1CheckMemo")]
  internal virtual Label lblCheck1CheckMemo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnCreateCheck
  {
    get => this._btnCreateCheck;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCreateCheck_Click);
      Button btnCreateCheck1 = this._btnCreateCheck;
      if (btnCreateCheck1 != null)
        btnCreateCheck1.Click -= eventHandler;
      this._btnCreateCheck = value;
      Button btnCreateCheck2 = this._btnCreateCheck;
      if (btnCreateCheck2 == null)
        return;
      btnCreateCheck2.Click += eventHandler;
    }
  }

  internal virtual Button btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      Button btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        btnCancel1.Click -= eventHandler;
      this._btnCancel = value;
      Button btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      btnCancel2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gridEntries")]
  internal virtual UltraGrid gridEntries { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsIssueCheckEntries1")]
  internal virtual dsIssueCheckEntries DsIssueCheckEntries1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDebitAmount")]
  internal virtual TextBox txtDebitAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnAddDebitAcct
  {
    get => this._btnAddDebitAcct;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddDebitAcct_Click);
      Button btnAddDebitAcct1 = this._btnAddDebitAcct;
      if (btnAddDebitAcct1 != null)
        btnAddDebitAcct1.Click -= eventHandler;
      this._btnAddDebitAcct = value;
      Button btnAddDebitAcct2 = this._btnAddDebitAcct;
      if (btnAddDebitAcct2 == null)
        return;
      btnAddDebitAcct2.Click += eventHandler;
    }
  }

  internal virtual Button btnCancelCredit
  {
    get => this._btnCancelCredit;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancelCredit_Click);
      Button btnCancelCredit1 = this._btnCancelCredit;
      if (btnCancelCredit1 != null)
        btnCancelCredit1.Click -= eventHandler;
      this._btnCancelCredit = value;
      Button btnCancelCredit2 = this._btnCancelCredit;
      if (btnCancelCredit2 == null)
        return;
      btnCancelCredit2.Click += eventHandler;
    }
  }

  internal virtual Button btnAddDebitAccount
  {
    get => this._btnAddDebitAccount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddDebitAccount_Click);
      Button btnAddDebitAccount1 = this._btnAddDebitAccount;
      if (btnAddDebitAccount1 != null)
        btnAddDebitAccount1.Click -= eventHandler;
      this._btnAddDebitAccount = value;
      Button btnAddDebitAccount2 = this._btnAddDebitAccount;
      if (btnAddDebitAccount2 == null)
        return;
      btnAddDebitAccount2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("pnlAddDebit")]
  internal virtual Panel pnlAddDebit { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  internal virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAccountBalance")]
  internal virtual Label lblAccountBalance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPostingComment")]
  internal virtual TextBox txtPostingComment { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Entries", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Description");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Debit Amt.");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Credit Amt.");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("invoicenum");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("chargecode");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("companylineguid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("glacctid");
    Appearance appearance8 = new Appearance();
    this.panelCheck1 = new Panel();
    this.Label8 = new Label();
    this.lblCheck1CheckMemo = new Label();
    this.lblCheckMemo = new Label();
    this.txtTransactNum1 = new TextBox();
    this.Label12 = new Label();
    this.lblCheck1BankAddress = new Label();
    this.Label4 = new Label();
    this.lblCheck1BankName = new Label();
    this.Label5 = new Label();
    this.lblCheck1Date = new Label();
    this.Label1 = new Label();
    this.lblCheck1AmountCurrency = new Label();
    this.lblCheck1CheckNumber = new Label();
    this.lblCheck1Payee = new Label();
    this.lblCheck1AmountEnglish = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.lblCheck1MGAName = new Label();
    this.pictCheck1Background = new PictureBox();
    this.lblVoidCheck1 = new Label();
    this.lblVoid1 = new Label();
    this.pic1SearchDate = new PictureBox();
    this.pic1SearchPayee = new PictureBox();
    this.Panel1 = new Panel();
    this.txtPostingComment = new TextBox();
    this.Label17 = new Label();
    this.btnAddDebitAccount = new Button();
    this.pnlAddDebit = new Panel();
    this.Label18 = new Label();
    this.lblAccountBalance = new Label();
    this.Label16 = new Label();
    this.btnCancelCredit = new Button();
    this.btnAddDebitAcct = new Button();
    this.Label15 = new Label();
    this.txtDebitAmount = new TextBox();
    this.Label7 = new Label();
    this.DropTreeOffset = new ExtendedTreeViewDropDown();
    this.gridEntries = new UltraGrid();
    this.DsIssueCheckEntries1 = new dsIssueCheckEntries();
    this.btnCancel = new Button();
    this.btnCreateCheck = new Button();
    this.txtCheckMemo = new TextBox();
    this.Label14 = new Label();
    this.dtCheckDate = new DateTimePicker();
    this.Label11 = new Label();
    this.cmbBankAccount = new ComboBox();
    this.DsBankAccounts1 = new dsBankAccounts();
    this.cmbOfficeLocation = new ComboBox();
    this.DsOfficeLocations1 = new dsOfficeLocations();
    this.btnSearchPayees = new Button();
    this.txtCheckAmount = new TextBox();
    this.txtPayee = new TextBox();
    this.Label13 = new Label();
    this.Label10 = new Label();
    this.Label9 = new Label();
    this.Label6 = new Label();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.panelCheck1.SuspendLayout();
    this.Panel1.SuspendLayout();
    this.pnlAddDebit.SuspendLayout();
    ((ISupportInitialize) this.gridEntries).BeginInit();
    this.DsIssueCheckEntries1.BeginInit();
    this.DsBankAccounts1.BeginInit();
    this.DsOfficeLocations1.BeginInit();
    this.SuspendLayout();
    this.panelCheck1.BackColor = Color.SteelBlue;
    this.panelCheck1.BorderStyle = BorderStyle.FixedSingle;
    this.panelCheck1.Controls.Add((Control) this.Label8);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1CheckMemo);
    this.panelCheck1.Controls.Add((Control) this.lblCheckMemo);
    this.panelCheck1.Controls.Add((Control) this.txtTransactNum1);
    this.panelCheck1.Controls.Add((Control) this.Label12);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1BankAddress);
    this.panelCheck1.Controls.Add((Control) this.Label4);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1BankName);
    this.panelCheck1.Controls.Add((Control) this.Label5);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1Date);
    this.panelCheck1.Controls.Add((Control) this.Label1);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1AmountCurrency);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1CheckNumber);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1Payee);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1AmountEnglish);
    this.panelCheck1.Controls.Add((Control) this.Label3);
    this.panelCheck1.Controls.Add((Control) this.Label2);
    this.panelCheck1.Controls.Add((Control) this.lblCheck1MGAName);
    this.panelCheck1.Controls.Add((Control) this.pictCheck1Background);
    this.panelCheck1.Controls.Add((Control) this.lblVoidCheck1);
    this.panelCheck1.Controls.Add((Control) this.lblVoid1);
    this.panelCheck1.Controls.Add((Control) this.pic1SearchDate);
    this.panelCheck1.Controls.Add((Control) this.pic1SearchPayee);
    this.panelCheck1.Dock = DockStyle.Top;
    this.panelCheck1.Location = new Point(0, 0);
    this.panelCheck1.Name = "panelCheck1";
    this.panelCheck1.Size = new Size(744, 176 /*0xB0*/);
    this.panelCheck1.TabIndex = 0;
    this.Label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label8.BackColor = Color.Black;
    this.Label8.Location = new Point(50, 163);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(300, 1);
    this.Label8.TabIndex = 8;
    this.Label8.Tag = (object) "LINE";
    this.Label8.Text = "Pay:";
    this.lblCheck1CheckMemo.BackColor = Color.White;
    this.lblCheck1CheckMemo.Location = new Point(48 /*0x30*/, 150);
    this.lblCheck1CheckMemo.Name = "lblCheck1CheckMemo";
    this.lblCheck1CheckMemo.Size = new Size(304, 16 /*0x10*/);
    this.lblCheck1CheckMemo.TabIndex = 7;
    this.lblCheckMemo.AutoSize = true;
    this.lblCheckMemo.BackColor = Color.White;
    this.lblCheckMemo.Location = new Point(8, 152);
    this.lblCheckMemo.Name = "lblCheckMemo";
    this.lblCheckMemo.Size = new Size(39, 17);
    this.lblCheckMemo.TabIndex = 6;
    this.lblCheckMemo.Text = "Memo:";
    this.txtTransactNum1.Location = new Point(704, 24);
    this.txtTransactNum1.Name = "txtTransactNum1";
    this.txtTransactNum1.Size = new Size(32 /*0x20*/, 21);
    this.txtTransactNum1.TabIndex = 14;
    this.txtTransactNum1.Text = "";
    this.txtTransactNum1.Visible = false;
    this.Label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label12.BackColor = Color.Black;
    this.Label12.Location = new Point(64 /*0x40*/, 78);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(576, 1);
    this.Label12.TabIndex = 4;
    this.Label12.Tag = (object) "LINE";
    this.Label12.Text = "Pay:";
    this.lblCheck1BankAddress.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1BankAddress.BackColor = Color.White;
    this.lblCheck1BankAddress.Font = new Font("Tahoma", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1BankAddress.Location = new Point(100, 120);
    this.lblCheck1BankAddress.Name = "lblCheck1BankAddress";
    this.lblCheck1BankAddress.Size = new Size(240 /*0xF0*/, 24);
    this.lblCheck1BankAddress.TabIndex = 9;
    this.Label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label4.BackColor = Color.Black;
    this.Label4.Location = new Point(64 /*0x40*/, 98);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(582, 1);
    this.Label4.TabIndex = 5;
    this.Label4.Tag = (object) "LINE";
    this.Label4.Text = "Pay:";
    this.lblCheck1BankName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1BankName.BackColor = Color.White;
    this.lblCheck1BankName.Font = new Font("Tahoma", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1BankName.Location = new Point(100, 104);
    this.lblCheck1BankName.Name = "lblCheck1BankName";
    this.lblCheck1BankName.Size = new Size(264, 16 /*0x10*/);
    this.lblCheck1BankName.TabIndex = 10;
    this.lblCheck1BankName.TextAlign = ContentAlignment.BottomLeft;
    this.Label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label5.BackColor = Color.Black;
    this.Label5.Location = new Point(558, 56);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(82, 1);
    this.Label5.TabIndex = 15;
    this.Label5.Tag = (object) "LINE";
    this.Label5.Text = "Pay:";
    this.lblCheck1Date.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1Date.BackColor = Color.White;
    this.lblCheck1Date.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1Date.Location = new Point(560, 41);
    this.lblCheck1Date.Name = "lblCheck1Date";
    this.lblCheck1Date.Size = new Size(80 /*0x50*/, 14);
    this.lblCheck1Date.TabIndex = 12;
    this.lblCheck1Date.TextAlign = ContentAlignment.MiddleCenter;
    this.Label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.White;
    this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(528, 40);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(35, 17);
    this.Label1.TabIndex = 11;
    this.Label1.Text = "Date:";
    this.lblCheck1AmountCurrency.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1AmountCurrency.BackColor = Color.White;
    this.lblCheck1AmountCurrency.BorderStyle = BorderStyle.FixedSingle;
    this.lblCheck1AmountCurrency.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1AmountCurrency.Location = new Point(640, 83);
    this.lblCheck1AmountCurrency.Name = "lblCheck1AmountCurrency";
    this.lblCheck1AmountCurrency.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.lblCheck1AmountCurrency.TabIndex = 17;
    this.lblCheck1AmountCurrency.Text = "$0.00";
    this.lblCheck1AmountCurrency.TextAlign = ContentAlignment.TopRight;
    this.lblCheck1CheckNumber.BackColor = Color.White;
    this.lblCheck1CheckNumber.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1CheckNumber.ForeColor = Color.Black;
    this.lblCheck1CheckNumber.Location = new Point(600, 8);
    this.lblCheck1CheckNumber.Name = "lblCheck1CheckNumber";
    this.lblCheck1CheckNumber.Size = new Size(136, 16 /*0x10*/);
    this.lblCheck1CheckNumber.TabIndex = 13;
    this.lblCheck1CheckNumber.TextAlign = ContentAlignment.MiddleRight;
    this.lblCheck1Payee.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1Payee.BackColor = Color.White;
    this.lblCheck1Payee.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1Payee.Location = new Point(62, 64 /*0x40*/);
    this.lblCheck1Payee.Name = "lblCheck1Payee";
    this.lblCheck1Payee.Size = new Size(458, 16 /*0x10*/);
    this.lblCheck1Payee.TabIndex = 3;
    this.lblCheck1AmountEnglish.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.lblCheck1AmountEnglish.BackColor = Color.White;
    this.lblCheck1AmountEnglish.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1AmountEnglish.Location = new Point(64 /*0x40*/, 82);
    this.lblCheck1AmountEnglish.Name = "lblCheck1AmountEnglish";
    this.lblCheck1AmountEnglish.Size = new Size(572, 16 /*0x10*/);
    this.lblCheck1AmountEnglish.TabIndex = 3;
    this.lblCheck1AmountEnglish.TextAlign = ContentAlignment.BottomLeft;
    this.Label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.White;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(8, 84);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(53, 17);
    this.Label3.TabIndex = 2;
    this.Label3.Text = "Amount:";
    this.Label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.White;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(8, 64 /*0x40*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(42, 17);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Payee:";
    this.lblCheck1MGAName.BackColor = Color.White;
    this.lblCheck1MGAName.Font = new Font("Tahoma", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCheck1MGAName.ForeColor = Color.Black;
    this.lblCheck1MGAName.Location = new Point(8, 8);
    this.lblCheck1MGAName.Name = "lblCheck1MGAName";
    this.lblCheck1MGAName.Size = new Size(360, 55);
    this.lblCheck1MGAName.TabIndex = 0;
    this.pictCheck1Background.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pictCheck1Background.BackColor = Color.White;
    this.pictCheck1Background.Location = new Point(2, 2);
    this.pictCheck1Background.Name = "pictCheck1Background";
    this.pictCheck1Background.Size = new Size(738, 170);
    this.pictCheck1Background.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictCheck1Background.TabIndex = 0;
    this.pictCheck1Background.TabStop = false;
    this.lblVoidCheck1.Cursor = Cursors.Hand;
    this.lblVoidCheck1.Font = new Font("Arial", 8.25f, FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.lblVoidCheck1.Location = new Point(664, 152);
    this.lblVoidCheck1.Name = "lblVoidCheck1";
    this.lblVoidCheck1.Size = new Size(72, 16 /*0x10*/);
    this.lblVoidCheck1.TabIndex = 18;
    this.lblVoidCheck1.Text = "Void Check";
    this.lblVoidCheck1.TextAlign = ContentAlignment.MiddleRight;
    this.lblVoidCheck1.Visible = false;
    this.lblVoid1.BackColor = Color.White;
    this.lblVoid1.Font = new Font("Arial", 24f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblVoid1.ForeColor = Color.Red;
    this.lblVoid1.Location = new Point(544, 104);
    this.lblVoid1.Name = "lblVoid1";
    this.lblVoid1.Size = new Size(192 /*0xC0*/, 32 /*0x20*/);
    this.lblVoid1.TabIndex = 16 /*0x10*/;
    this.lblVoid1.Text = "VOID";
    this.lblVoid1.TextAlign = ContentAlignment.TopRight;
    this.lblVoid1.Visible = false;
    this.pic1SearchDate.Location = new Point(648, 40);
    this.pic1SearchDate.Name = "pic1SearchDate";
    this.pic1SearchDate.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic1SearchDate.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic1SearchDate.TabIndex = 14;
    this.pic1SearchDate.TabStop = false;
    this.pic1SearchDate.Visible = false;
    this.pic1SearchPayee.Location = new Point(648, 64 /*0x40*/);
    this.pic1SearchPayee.Name = "pic1SearchPayee";
    this.pic1SearchPayee.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.pic1SearchPayee.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pic1SearchPayee.TabIndex = 13;
    this.pic1SearchPayee.TabStop = false;
    this.pic1SearchPayee.Visible = false;
    this.Panel1.BackColor = Color.WhiteSmoke;
    this.Panel1.Controls.Add((Control) this.txtPostingComment);
    this.Panel1.Controls.Add((Control) this.Label17);
    this.Panel1.Controls.Add((Control) this.btnAddDebitAccount);
    this.Panel1.Controls.Add((Control) this.pnlAddDebit);
    this.Panel1.Controls.Add((Control) this.gridEntries);
    this.Panel1.Controls.Add((Control) this.btnCancel);
    this.Panel1.Controls.Add((Control) this.btnCreateCheck);
    this.Panel1.Controls.Add((Control) this.txtCheckMemo);
    this.Panel1.Controls.Add((Control) this.Label14);
    this.Panel1.Controls.Add((Control) this.dtCheckDate);
    this.Panel1.Controls.Add((Control) this.Label11);
    this.Panel1.Controls.Add((Control) this.cmbBankAccount);
    this.Panel1.Controls.Add((Control) this.cmbOfficeLocation);
    this.Panel1.Controls.Add((Control) this.btnSearchPayees);
    this.Panel1.Controls.Add((Control) this.txtCheckAmount);
    this.Panel1.Controls.Add((Control) this.txtPayee);
    this.Panel1.Controls.Add((Control) this.Label13);
    this.Panel1.Controls.Add((Control) this.Label10);
    this.Panel1.Controls.Add((Control) this.Label9);
    this.Panel1.Controls.Add((Control) this.Label6);
    this.Panel1.Dock = DockStyle.Fill;
    this.Panel1.Location = new Point(0, 176 /*0xB0*/);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(744, 168);
    this.Panel1.TabIndex = 1;
    this.txtPostingComment.BorderStyle = BorderStyle.FixedSingle;
    this.txtPostingComment.Location = new Point(104, 88);
    this.txtPostingComment.Multiline = true;
    this.txtPostingComment.Name = "txtPostingComment";
    this.txtPostingComment.Size = new Size(280, 72);
    this.txtPostingComment.TabIndex = 7;
    this.txtPostingComment.Text = "";
    this.Label17.AutoSize = true;
    this.Label17.Location = new Point(8, 88);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(96 /*0x60*/, 17);
    this.Label17.TabIndex = 6;
    this.Label17.Text = "Posting Comment:";
    this.btnAddDebitAccount.Cursor = Cursors.Hand;
    this.btnAddDebitAccount.FlatStyle = FlatStyle.Flat;
    this.btnAddDebitAccount.Location = new Point(528, 112 /*0x70*/);
    this.btnAddDebitAccount.Name = "btnAddDebitAccount";
    this.btnAddDebitAccount.Size = new Size(208 /*0xD0*/, 23);
    this.btnAddDebitAccount.TabIndex = 15;
    this.btnAddDebitAccount.Text = "Add Debit Account";
    this.pnlAddDebit.BackColor = Color.WhiteSmoke;
    this.pnlAddDebit.BorderStyle = BorderStyle.FixedSingle;
    this.pnlAddDebit.Controls.Add((Control) this.Label18);
    this.pnlAddDebit.Controls.Add((Control) this.lblAccountBalance);
    this.pnlAddDebit.Controls.Add((Control) this.Label16);
    this.pnlAddDebit.Controls.Add((Control) this.btnCancelCredit);
    this.pnlAddDebit.Controls.Add((Control) this.btnAddDebitAcct);
    this.pnlAddDebit.Controls.Add((Control) this.Label15);
    this.pnlAddDebit.Controls.Add((Control) this.txtDebitAmount);
    this.pnlAddDebit.Controls.Add((Control) this.Label7);
    this.pnlAddDebit.Controls.Add((Control) this.DropTreeOffset);
    this.pnlAddDebit.Location = new Point(224 /*0xE0*/, 184);
    this.pnlAddDebit.Name = "pnlAddDebit";
    this.pnlAddDebit.Size = new Size(336, 144 /*0x90*/);
    this.pnlAddDebit.TabIndex = 18;
    this.pnlAddDebit.Visible = false;
    this.Label18.AutoSize = true;
    this.Label18.Location = new Point(8, 56);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(90, 17);
    this.Label18.TabIndex = 2;
    this.Label18.Text = "Account Balance:";
    this.lblAccountBalance.BackColor = Color.Gainsboro;
    this.lblAccountBalance.BorderStyle = BorderStyle.FixedSingle;
    this.lblAccountBalance.Location = new Point(112 /*0x70*/, 56);
    this.lblAccountBalance.Name = "lblAccountBalance";
    this.lblAccountBalance.Size = new Size(216, 21);
    this.lblAccountBalance.TabIndex = 5;
    this.lblAccountBalance.Text = "$0.00";
    this.Label16.BackColor = Color.LightSteelBlue;
    this.Label16.BorderStyle = BorderStyle.FixedSingle;
    this.Label16.Dock = DockStyle.Top;
    this.Label16.Font = new Font("Arial Black", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.White;
    this.Label16.Location = new Point(0, 0);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(334, 22);
    this.Label16.TabIndex = 0;
    this.Label16.Text = "DEBIT ACCOUNT";
    this.btnCancelCredit.Cursor = Cursors.Hand;
    this.btnCancelCredit.FlatStyle = FlatStyle.Flat;
    this.btnCancelCredit.Location = new Point(256 /*0x0100*/, 112 /*0x70*/);
    this.btnCancelCredit.Name = "btnCancelCredit";
    this.btnCancelCredit.TabIndex = 8;
    this.btnCancelCredit.Text = "Cancel";
    this.btnAddDebitAcct.Cursor = Cursors.Hand;
    this.btnAddDebitAcct.FlatStyle = FlatStyle.Flat;
    this.btnAddDebitAcct.Location = new Point(152, 112 /*0x70*/);
    this.btnAddDebitAcct.Name = "btnAddDebitAcct";
    this.btnAddDebitAcct.Size = new Size(96 /*0x60*/, 23);
    this.btnAddDebitAcct.TabIndex = 7;
    this.btnAddDebitAcct.Text = "Add Debit..";
    this.Label15.AutoSize = true;
    this.Label15.Location = new Point(8, 80 /*0x50*/);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(77, 17);
    this.Label15.TabIndex = 3;
    this.Label15.Text = "Debit Amount:";
    this.txtDebitAmount.BorderStyle = BorderStyle.FixedSingle;
    this.txtDebitAmount.Location = new Point(112 /*0x70*/, 80 /*0x50*/);
    this.txtDebitAmount.MaxLength = 16 /*0x10*/;
    this.txtDebitAmount.Name = "txtDebitAmount";
    this.txtDebitAmount.Size = new Size(216, 21);
    this.txtDebitAmount.TabIndex = 6;
    this.txtDebitAmount.Text = "";
    this.txtDebitAmount.TextAlign = HorizontalAlignment.Right;
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(8, 32 /*0x20*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(78, 17);
    this.Label7.TabIndex = 1;
    this.Label7.Text = "Debit Account:";
    this.DropTreeOffset.DropDownHeight = 250;
    this.DropTreeOffset.DropDownWidth = 325;
    this.DropTreeOffset.Enabled = false;
    this.DropTreeOffset.Location = new Point(112 /*0x70*/, 32 /*0x20*/);
    this.DropTreeOffset.Name = "DropTreeOffset";
    this.DropTreeOffset.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.None;
    this.DropTreeOffset.ShowIncomeAccounts = true;
    this.DropTreeOffset.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.DropTreeOffset.ShowSystemDefinedAccounts = true;
    this.DropTreeOffset.Size = new Size(216, 24);
    this.DropTreeOffset.TabIndex = 4;
    this.DropTreeOffset.UseCheckedStateSelectionOverride = true;
    ((UltraControlBase) this.gridEntries).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridEntries).DataMember = "Entries";
    ((UltraGridBase) this.gridEntries).DataSource = (object) this.DsIssueCheckEntries1;
    appearance1.BackColor = Color.White;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.TextHAlign = (HAlign) 1;
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance2;
    appearance3.TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance3;
    ultraGridColumn1.Width = 426;
    appearance4.BackColor = Color.WhiteSmoke;
    appearance4.TextHAlign = (HAlign) 3;
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn2.Format = "c";
    appearance5.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance5;
    ultraGridColumn2.Width = 152;
    appearance6.BackColor = Color.WhiteSmoke;
    appearance6.TextHAlign = (HAlign) 3;
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn3.Format = "c";
    appearance7.TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance7;
    ultraGridColumn3.Width = 148;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 67;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 84;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 108;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 87;
    ultraGridBand.Columns.Add((object) ultraGridColumn1);
    ultraGridBand.Columns.Add((object) ultraGridColumn2);
    ultraGridBand.Columns.Add((object) ultraGridColumn3);
    ultraGridBand.Columns.Add((object) ultraGridColumn4);
    ultraGridBand.Columns.Add((object) ultraGridColumn5);
    ultraGridBand.Columns.Add((object) ultraGridColumn6);
    ultraGridBand.Columns.Add((object) ultraGridColumn7);
    ultraGridBand.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.CellPadding = 0;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.CellSpacing = 0;
    appearance8.BorderAlpha = (Alpha) 3;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.RowSpacingAfter = 0;
    ((UltraGridBase) this.gridEntries).DisplayLayout.Override.RowSpacingBefore = 0;
    ((UltraControlBase) this.gridEntries).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridEntries).Location = new Point(8, 176 /*0xB0*/);
    ((Control) this.gridEntries).Name = "gridEntries";
    ((Control) this.gridEntries).Size = new Size(728, 216);
    ((Control) this.gridEntries).TabIndex = 17;
    this.DsIssueCheckEntries1.DataSetName = "dsIssueCheckEntries";
    this.DsIssueCheckEntries1.Locale = new CultureInfo("en-US");
    this.btnCancel.Cursor = Cursors.Hand;
    this.btnCancel.FlatStyle = FlatStyle.Flat;
    this.btnCancel.Location = new Point(648, 136);
    this.btnCancel.Name = "btnCancel";
    this.btnCancel.Size = new Size(88, 23);
    this.btnCancel.TabIndex = 18;
    this.btnCancel.Text = "Cancel";
    this.btnCreateCheck.Cursor = Cursors.Hand;
    this.btnCreateCheck.FlatStyle = FlatStyle.Flat;
    this.btnCreateCheck.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.btnCreateCheck.Location = new Point(528, 136);
    this.btnCreateCheck.Name = "btnCreateCheck";
    this.btnCreateCheck.Size = new Size(112 /*0x70*/, 23);
    this.btnCreateCheck.TabIndex = 16 /*0x10*/;
    this.btnCreateCheck.Text = "Create Check..";
    this.txtCheckMemo.BorderStyle = BorderStyle.FixedSingle;
    this.txtCheckMemo.Location = new Point(528, 64 /*0x40*/);
    this.txtCheckMemo.MaxLength = 100;
    this.txtCheckMemo.Multiline = true;
    this.txtCheckMemo.Name = "txtCheckMemo";
    this.txtCheckMemo.Size = new Size(208 /*0xD0*/, 40);
    this.txtCheckMemo.TabIndex = 14;
    this.txtCheckMemo.Text = "";
    this.Label14.AutoSize = true;
    this.Label14.Location = new Point(440, 64 /*0x40*/);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(72, 17);
    this.Label14.TabIndex = 13;
    this.Label14.Text = "Check Memo:";
    this.dtCheckDate.Format = DateTimePickerFormat.Short;
    this.dtCheckDate.Location = new Point(104, 64 /*0x40*/);
    this.dtCheckDate.Name = "dtCheckDate";
    this.dtCheckDate.Size = new Size(96 /*0x60*/, 21);
    this.dtCheckDate.TabIndex = 5;
    this.Label11.AutoSize = true;
    this.Label11.Location = new Point(8, 64 /*0x40*/);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(65, 17);
    this.Label11.TabIndex = 4;
    this.Label11.Text = "Check Date:";
    this.cmbBankAccount.DataSource = (object) this.DsBankAccounts1;
    this.cmbBankAccount.DisplayMember = "spFin_GetBankAccounts.BANKNAME";
    this.cmbBankAccount.DropDownStyle = ComboBoxStyle.DropDownList;
    this.cmbBankAccount.Location = new Point(528, 40);
    this.cmbBankAccount.Name = "cmbBankAccount";
    this.cmbBankAccount.Size = new Size(208 /*0xD0*/, 21);
    this.cmbBankAccount.TabIndex = 12;
    this.cmbBankAccount.ValueMember = "spFin_GetBankAccounts.GLACCTID";
    this.DsBankAccounts1.DataSetName = "dsBankAccounts";
    this.DsBankAccounts1.Locale = new CultureInfo("en-US");
    this.cmbOfficeLocation.DataSource = (object) this.DsOfficeLocations1.spFin_GetOfficeLocations;
    this.cmbOfficeLocation.DisplayMember = "Office Location";
    this.cmbOfficeLocation.Location = new Point(528, 16 /*0x10*/);
    this.cmbOfficeLocation.Name = "cmbOfficeLocation";
    this.cmbOfficeLocation.Size = new Size(208 /*0xD0*/, 21);
    this.cmbOfficeLocation.TabIndex = 10;
    this.cmbOfficeLocation.ValueMember = "ID";
    this.DsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.DsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.btnSearchPayees.Cursor = Cursors.Hand;
    this.btnSearchPayees.Location = new Point(392, 16 /*0x10*/);
    this.btnSearchPayees.Name = "btnSearchPayees";
    this.btnSearchPayees.Size = new Size(24, 20);
    this.btnSearchPayees.TabIndex = 8;
    this.btnSearchPayees.Text = "..";
    this.txtCheckAmount.BorderStyle = BorderStyle.FixedSingle;
    this.txtCheckAmount.Location = new Point(104, 40);
    this.txtCheckAmount.MaxLength = 16 /*0x10*/;
    this.txtCheckAmount.Name = "txtCheckAmount";
    this.txtCheckAmount.Size = new Size(128 /*0x80*/, 21);
    this.txtCheckAmount.TabIndex = 3;
    this.txtCheckAmount.Text = "";
    this.txtCheckAmount.TextAlign = HorizontalAlignment.Right;
    this.txtPayee.BackColor = Color.White;
    this.txtPayee.BorderStyle = BorderStyle.FixedSingle;
    this.txtPayee.Location = new Point(104, 16 /*0x10*/);
    this.txtPayee.Name = "txtPayee";
    this.txtPayee.ReadOnly = true;
    this.txtPayee.Size = new Size(280, 21);
    this.txtPayee.TabIndex = 1;
    this.txtPayee.TabStop = false;
    this.txtPayee.Text = "";
    this.Label13.AutoSize = true;
    this.Label13.Location = new Point(440, 16 /*0x10*/);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(83, 17);
    this.Label13.TabIndex = 9;
    this.Label13.Text = "Office Location:";
    this.Label10.AutoSize = true;
    this.Label10.Location = new Point(8, 40);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(81, 17);
    this.Label10.TabIndex = 2;
    this.Label10.Text = "Check Amount:";
    this.Label9.AutoSize = true;
    this.Label9.Location = new Point(440, 40);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(76, 17);
    this.Label9.TabIndex = 11;
    this.Label9.Text = "Bank Account:";
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(8, 16 /*0x10*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(38, 17);
    this.Label6.TabIndex = 0;
    this.Label6.Text = "Payee:";
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
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
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
    this.SqlSelectCommand2.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand2.Parameters.Add(new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4));
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.WhiteSmoke;
    this.ClientSize = new Size(744, 344);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.panelCheck1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmIssueCheck);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Create Check..";
    this.panelCheck1.ResumeLayout(false);
    this.Panel1.ResumeLayout(false);
    this.pnlAddDebit.ResumeLayout(false);
    ((ISupportInitialize) this.gridEntries).EndInit();
    this.DsIssueCheckEntries1.EndInit();
    this.DsBankAccounts1.EndInit();
    this.DsOfficeLocations1.EndInit();
    this.ResumeLayout(false);
  }

  private void frmIssueCheck_Load(object sender, EventArgs e)
  {
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.dtCheckDate.Value = DateTime.Now;
    this.lblCheck1Date.Text = Strings.Format((object) DateTime.Now, "Short Date");
    this.daGetOfficeLocations.Fill((DataTable) this.DsOfficeLocations1.spFin_GetOfficeLocations);
    this.cmbOfficeLocation.SelectedValue = (object) this._glcompanyid;
    if (this.cmbOfficeLocation.SelectedItem != null)
    {
      this.GetOfficeLocation(Conversions.ToInteger(this.cmbOfficeLocation.SelectedValue));
      this.GetBankAccounts(Conversions.ToInteger(this.cmbOfficeLocation.SelectedValue));
      this.LoadGLAccounts(Conversions.ToInteger(this.cmbOfficeLocation.SelectedValue));
    }
    this.lblCheck1CheckMemo.DataBindings.Add("Text", (object) this.txtCheckMemo, "Text");
  }

  private void dtCheckDate_ValueChanged(object sender, EventArgs e)
  {
    if (!Information.IsDate((object) this.dtCheckDate.Value))
      return;
    this.lblCheck1Date.Text = Strings.Format((object) this.dtCheckDate.Value, "Short Date");
  }

  private void GetBankAccounts(int GLCompanyID)
  {
    this.DsBankAccounts1.spFin_GetBankAccounts.Clear();
    this.daGetBankAccounts.SelectCommand.Parameters["@glcompanyid"].Value = (object) GLCompanyID;
    this.daGetBankAccounts.Fill((DataTable) this.DsBankAccounts1.spFin_GetBankAccounts);
  }

  private void LoadGLAccounts(int GLCompanyID) => this.DropTreeOffset.LoadGLAccounts(GLCompanyID);

  private void GetOfficeLocation(int GLCompanyID)
  {
    SqlCommand sqlCommand1 = new SqlCommand($"Select dbo.getofficelocationaddress({GLCompanyID})", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.Text;
      sqlCommand2.Connection.Open();
      this.lblCheck1MGAName.Text = Conversions.ToString(sqlCommand2.ExecuteScalar());
    }
    finally
    {
      sqlCommand1.Connection.Close();
      sqlCommand1.Connection.Dispose();
      sqlCommand1.Dispose();
    }
  }

  private void GetBankAccountInformation(int GLAccountID)
  {
    SqlCommand sqlCommand1 = new SqlCommand($"Select dbo.getbankaddress({GLAccountID})", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.Text;
      sqlCommand2.Connection.Open();
      this.lblCheck1BankAddress.Text = Conversions.ToString(sqlCommand2.ExecuteScalar());
    }
    finally
    {
      sqlCommand1.Connection.Close();
      sqlCommand1.Connection.Dispose();
      sqlCommand1.Dispose();
    }
  }

  private void cmbOfficeLocation_SelectedValueChanged(object sender, EventArgs e)
  {
    if (this.cmbOfficeLocation.SelectedItem != null)
    {
      this.GetOfficeLocation(Conversions.ToInteger(this.cmbOfficeLocation.SelectedValue));
      this.GetBankAccounts(Conversions.ToInteger(this.cmbOfficeLocation.SelectedValue));
      this.LoadGLAccounts(Conversions.ToInteger(this.cmbOfficeLocation.SelectedValue));
      this.btnAddDebitAccount.Enabled = true;
    }
    else
      this.btnAddDebitAccount.Enabled = false;
  }

  private void txtCheckAmount_TextChanged(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCheckAmount.Text.Trim(), "", false) == 0)
    {
      this.lblCheck1AmountEnglish.Text = "";
      this.lblCheck1AmountCurrency.Text = "$0.00";
    }
    else if (!Versioned.IsNumeric((object) this.txtCheckAmount.Text))
    {
      this.lblCheck1AmountEnglish.Text = "";
      this.lblCheck1AmountCurrency.Text = "$0.00";
    }
    else
    {
      this.lblCheck1AmountCurrency.Text = Strings.Format((object) this.txtCheckAmount.Text, "Currency");
      this.lblCheck1AmountEnglish.Text = Tools.ConvertNumericToEnglish(Conversions.ToDecimal(this.txtCheckAmount.Text));
      this.AddCashEntry();
    }
  }

  private void txtCheckAmount_Leave(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCheckAmount.Text.Trim(), "", false) == 0)
    {
      this.lblCheck1AmountEnglish.Text = "";
      this.lblCheck1AmountCurrency.Text = "$0.00";
    }
    else if (!Versioned.IsNumeric((object) this.txtCheckAmount.Text))
    {
      this.lblCheck1AmountEnglish.Text = "";
      this.lblCheck1AmountCurrency.Text = "$0.00";
    }
    else
    {
      this.txtCheckAmount.Text = Strings.Format((object) this.txtCheckAmount.Text, "Currency");
      this.lblCheck1AmountCurrency.Text = Strings.Format((object) this.txtCheckAmount.Text, "Currency");
      this.lblCheck1AmountEnglish.Text = Tools.ConvertNumericToEnglish(Conversions.ToDecimal(this.txtCheckAmount.Text));
    }
  }

  private void btnSearchPayees_Click(object sender, EventArgs e)
  {
    FormSearchEntity formSearchEntity1 = new FormSearchEntity(MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SearchEntityTypes.All);
    try
    {
      FormSearchEntity formSearchEntity2 = formSearchEntity1;
      if (formSearchEntity2.ShowDialog() == DialogResult.OK)
      {
        this.txtPayee.Text = formSearchEntity2.EntityName;
        this.lblCheck1Payee.Text = formSearchEntity2.EntityName;
        this._payeeguid = formSearchEntity2.EntityGuid;
      }
    }
    finally
    {
      formSearchEntity1.Dispose();
    }
  }

  private void cmbBankAccount_SelectedValueChanged(object sender, EventArgs e)
  {
    if (this.cmbBankAccount.SelectedItem == null)
    {
      this.lblCheck1BankName.Text = "";
      this.lblCheck1BankAddress.Text = "";
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBankAccount.Text.Trim(), "", false) == 0)
    {
      this.lblCheck1BankName.Text = "";
      this.lblCheck1BankAddress.Text = "";
    }
    else
    {
      this.lblCheck1BankName.Text = this.cmbBankAccount.Text;
      this.GetBankAccountInformation(Conversions.ToInteger(this.cmbBankAccount.SelectedValue));
      this.AddCashEntry();
    }
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private bool VerifyForm()
  {
    bool flag;
    if (this._payeeguid.Equals(Guid.Empty) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPayee.Text.Trim(), "", false) == 0)
    {
      int num = (int) MessageBox.Show("You must select a payee to continue!", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.btnSearchPayees.Focus();
      flag = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCheckAmount.Text.Trim(), "", false) == 0)
    {
      int num = (int) MessageBox.Show("You must enter a check amount to continue!", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.txtCheckAmount.Focus();
      flag = false;
    }
    else if (!Versioned.IsNumeric((object) this.txtCheckAmount.Text))
    {
      int num = (int) MessageBox.Show("Check amount must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.txtCheckAmount.Focus();
      flag = false;
    }
    else if (Decimal.Compare(Conversions.ToDecimal(this.txtCheckAmount.Text), 0M) < 0)
    {
      int num = (int) MessageBox.Show("Check amount must be greater than zero.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.txtCheckAmount.Focus();
      flag = false;
    }
    else if (this.cmbOfficeLocation.SelectedItem == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbOfficeLocation.Text.Trim(), "", false) == 0)
    {
      int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.cmbOfficeLocation.Focus();
      flag = false;
    }
    else
    {
      if (this.cmbBankAccount.SelectedItem != null)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBankAccount.Text.Trim(), "", false) != 0)
        {
          Decimal d1;
          try
          {
            foreach (dsIssueCheckEntries.EntriesRow entry in this.DsIssueCheckEntries1.Entries)
            {
              if (!Information.IsDBNull((object) entry._Debit_Amt_))
                d1 = Decimal.Add(d1, entry._Debit_Amt_);
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
          if (Decimal.Compare(d1, Conversions.ToDecimal(this.txtCheckAmount.Text)) != 0)
          {
            int num = (int) MessageBox.Show("The current debits do not match the credit amount. You must apply the full check amount to offsetting debit accounts to continue.", "Invalid Debits!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_23;
          }
          flag = true;
          goto label_23;
        }
      }
      int num1 = (int) MessageBox.Show("You must select a bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.cmbBankAccount.Focus();
      flag = false;
    }
label_23:
    return flag;
  }

  private void Post()
  {
    SqlCommand sqlCommand1 = new SqlCommand("spFin_PostCheckIssuance_Header", new SqlConnection(CurrentUser.Instance.ConnectionString));
    try
    {
      SqlCommand sqlCommand2 = sqlCommand1;
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      sqlCommand2.Parameters.AddWithValue("@payeeguid", (object) this._payeeguid);
      sqlCommand2.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
      sqlCommand2.Parameters.AddWithValue("@frombankgl", (object) Conversions.ToInteger(this.cmbBankAccount.SelectedValue));
      sqlCommand2.Parameters.AddWithValue("@amount", (object) Conversions.ToDecimal(this.txtCheckAmount.Text));
      sqlCommand2.Parameters.AddWithValue("@checkmemo", (object) this.txtCheckMemo.Text);
      sqlCommand2.Parameters.AddWithValue("@checkdate", (object) this.dtCheckDate.Value);
      sqlCommand2.Parameters.AddWithValue("@comments", (object) this.txtPostingComment.Text);
      sqlCommand2.Connection.Open();
      sqlCommand2.Transaction = sqlCommand2.Connection.BeginTransaction();
      int integer = Conversions.ToInteger(sqlCommand2.ExecuteScalar());
      try
      {
        foreach (dsIssueCheckEntries.EntriesRow entry in this.DsIssueCheckEntries1.Entries)
        {
          if (entry.RowState != DataRowState.Deleted || entry.RowState == DataRowState.Detached)
          {
            sqlCommand2.CommandText = "spFin_PostCheckIssuance_Detail";
            sqlCommand2.CommandType = CommandType.StoredProcedure;
            sqlCommand2.Parameters.Clear();
            sqlCommand2.Parameters.AddWithValue("@transactnum", (object) integer);
            sqlCommand2.Parameters.AddWithValue("@glacctid", (object) entry.glacctid);
            sqlCommand2.Parameters.AddWithValue("@payeeguid", (object) this._payeeguid);
            if (entry._Debit_Amt_.Equals((object) DBNull.Value) || Information.IsDBNull((object) entry._Debit_Amt_) || Decimal.Compare(entry._Debit_Amt_, 0M) == 0)
              sqlCommand2.Parameters.AddWithValue("@amount", (object) Decimal.Multiply(entry._Credit_Amt_, -1M));
            else
              sqlCommand2.Parameters.AddWithValue("@amount", (object) entry._Debit_Amt_);
            sqlCommand2.ExecuteNonQuery();
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      sqlCommand2.Parameters.Clear();
      sqlCommand2.CommandText = "SPFIN_CheckTheBooks";
      sqlCommand2.CommandType = CommandType.StoredProcedure;
      if (Conversions.ToInteger(sqlCommand2.ExecuteScalar()) != 0)
      {
        int num = (int) MessageBox.Show("Posting the current transaction will leave the books in an un-balance state. This transaction can not be posted.", "Transaction Invalid!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        sqlCommand2.Transaction.Rollback();
      }
      else
        sqlCommand2.Transaction.Commit();
      int num1 = (int) MessageBox.Show("Check has been created successfully!", "Check Created Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.Close();
    }
    catch (Exception ex1)
    {
      ProjectData.SetProjectError(ex1);
      Exception ex2 = ex1;
      if (sqlCommand1.Transaction != null)
        sqlCommand1.Transaction.Rollback();
      sqlCommand1.Connection.Close();
      ErrorHandler.HandleError(ex2);
      ProjectData.ClearProjectError();
    }
    finally
    {
      if (sqlCommand1 != null)
      {
        if (sqlCommand1.Connection != null)
        {
          sqlCommand1.Connection.Close();
          sqlCommand1.Connection.Dispose();
          sqlCommand1.Connection = (SqlConnection) null;
        }
        sqlCommand1.Dispose();
      }
    }
  }

  private void btnAddDebitAccount_Click(object sender, EventArgs e)
  {
    if (this.Size.Height == 376 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblCheck1AmountCurrency.Text, "", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.lblCheck1AmountCurrency.Text, "$0.00", false) == 0)
    {
      int num = (int) MessageBox.Show("Please enter a check amount and select a bank to continue.", "Check Amount and Bank Required!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      this.pnlAddDebit.Visible = true;
      this.pnlAddDebit.BringToFront();
      ((Control) this.gridEntries).Enabled = false;
      this.Refresh();
    }
  }

  private void btnAddDebitAcct_Click(object sender, EventArgs e)
  {
    if (!this.VerifyDebit())
      return;
    this.AddIssuanceEntry(this.DropTreeOffset.GLAccountShortName, DebitAmount: Conversions.ToDecimal(this.txtDebitAmount.Text), GLAccountID: this.DropTreeOffset.GLAccountID);
    this.txtDebitAmount.Text = "";
    this.DropTreeOffset.LoadGLAccounts(Conversions.ToInteger(this.cmbOfficeLocation.SelectedValue));
    this.lblAccountBalance.Text = "$0.00";
  }

  private bool VerifyDebit()
  {
    bool flag;
    if (this.DropTreeOffset.GLAccountID == -1)
    {
      int num = (int) MessageBox.Show("You must select a GL offset account to continue!", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDebitAmount.Text, "", false) == 0)
    {
      int num = (int) MessageBox.Show("You must enter a debit amount to continue!", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (!Versioned.IsNumeric((object) this.txtDebitAmount.Text))
    {
      int num = (int) MessageBox.Show("Debit amount must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (Decimal.Compare(Conversions.ToDecimal(this.txtDebitAmount.Text), Conversions.ToDecimal(this.lblAccountBalance.Text)) > 0)
    {
      int num = (int) MessageBox.Show("Debit applied can not exceed the GL Accouht balance.", "Invalid Debit Amount!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void btnCancelCredit_Click(object sender, EventArgs e)
  {
    this.pnlAddDebit.Visible = false;
    ((Control) this.gridEntries).Enabled = true;
    this.Refresh();
  }

  public void AddIssuanceEntry(
    string Description,
    Decimal CreditAmount = 0M,
    Decimal DebitAmount = 0M,
    int InvoiceNumber = -1,
    int ChargeCode = -1,
    string CompanyLineGuid = "",
    int GLAccountID = -1)
  {
    this.DsIssueCheckEntries1.Entries.AddEntriesRow(Description, DebitAmount, CreditAmount, InvoiceNumber, ChargeCode, CompanyLineGuid, GLAccountID);
    if (((UltraGridBase) this.gridEntries).Rows.Count > 0)
      this.Size = new Size(this.Width, 608);
    else
      this.Size = new Size(this.Width, 376);
    this.RefreshGridSummaries();
  }

  private void AddCashEntry()
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtCheckAmount.Text, "", false) == 0 || !Versioned.IsNumeric((object) this.txtCheckAmount.Text) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cmbBankAccount.Text.Trim(), "", false) == 0)
      return;
    bool flag = false;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridEntries).Rows)
    {
      if (row.Cells["Description"].Value.ToString().StartsWith("CASH"))
      {
        row.Cells["Credit Amt."].Value = (object) Conversions.ToDecimal(this.txtCheckAmount.Text);
        row.Cells["Debit Amt."].Value = (object) 0M;
        flag = true;
        break;
      }
    }
    if (flag)
      return;
    this.AddIssuanceEntry("CASH-" + this.cmbBankAccount.Text, Conversions.ToDecimal(this.txtCheckAmount.Text), GLAccountID: Conversions.ToInteger(this.cmbBankAccount.SelectedValue));
  }

  private void RefreshGridSummaries()
  {
    ((UltraGridBase) this.gridEntries).DisplayLayout.Bands[0].SortedColumns.Add("Debit Amt.", true);
    ((UltraGridBase) this.gridEntries).DisplayLayout.Bands[0].Summaries.Clear();
    UltraGridLayout displayLayout = ((UltraGridBase) this.gridEntries).DisplayLayout;
    displayLayout.Bands[0].Summaries.Add("DebitSum", (SummaryType) 1, displayLayout.Bands[0].Columns["Debit Amt."], (SummaryPosition) 3);
    displayLayout.Bands[0].Summaries.Add("CreditSum", (SummaryType) 1, displayLayout.Bands[0].Columns["Credit Amt."], (SummaryPosition) 3);
    try
    {
      foreach (SummarySettings summary in (IEnumerable) displayLayout.Bands[0].Summaries)
        summary.DisplayFormat = "{0:c}";
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    displayLayout.Override.SummaryValueAppearance.TextHAlign = (HAlign) 3;
  }

  private void btnCreateCheck_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    this.Post();
  }

  private void DropTreeOffset_AfterSelect(object sender, ExtendedDropTree_EventArgs e)
  {
    if (this.DropTreeOffset.GLAccountID == 0 || this.DropTreeOffset.GLAccountID == -1)
      return;
    this.lblAccountBalance.Text = Strings.Format((object) Decimal.Multiply(Tools.GetGLAccountBalance(this.DropTreeOffset.GLAccountID), -1M), "Currency");
  }
}
