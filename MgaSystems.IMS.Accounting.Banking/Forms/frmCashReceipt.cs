// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmCashReceipt
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Banking.AccountingObjects;
using MGASystems.IMS.Accounting.Banking.AccountingObjects.Transactions;
using MGASystems.IMS.Accounting.Banking.CustomExceptions;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{EE3AFC8D-71C9-4594-95CB-19889DF74C98}", "New Cash Receipt", "Determines whether or not a user can create cash receipt.", "Accounting")]
public sealed class frmCashReceipt : Form
{
  private int _BankAcctGL;
  private int _GLCompanyID;
  private int _depositId;
  private string NewDepositString;
  private string DepositTicketSelected;
  private Guid _currentRemitterGuid;
  private CashReceipt _cashReceiptObject;

  [field: AccessedThroughProperty("pnlBottom")]
  internal virtual Panel pnlBottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnFinish
  {
    get => this._btnFinish;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnFinish_Click);
      MGAButton btnFinish1 = this._btnFinish;
      if (btnFinish1 != null)
        ((Control) btnFinish1).Click -= eventHandler;
      this._btnFinish = value;
      MGAButton btnFinish2 = this._btnFinish;
      if (btnFinish2 == null)
        return;
      ((Control) btnFinish2).Click += eventHandler;
    }
  }

  internal virtual MGAButton btnCancel
  {
    get => this._btnCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCancel_Click);
      MGAButton btnCancel1 = this._btnCancel;
      if (btnCancel1 != null)
        ((Control) btnCancel1).Click -= eventHandler;
      this._btnCancel = value;
      MGAButton btnCancel2 = this._btnCancel;
      if (btnCancel2 == null)
        return;
      ((Control) btnCancel2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("panelTop")]
  internal virtual Panel panelTop { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLine")]
  internal virtual Label lblLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label1")]
  internal virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pictureBox1")]
  internal virtual PictureBox pictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSideBar")]
  internal virtual UltraLabel lblSideBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel9")]
  internal virtual UltraLabel ultraLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlMain")]
  internal virtual Panel pnlMain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlStepOne")]
  internal virtual Panel pnlStepOne { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlStepTwo")]
  internal virtual Panel pnlStepTwo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel7")]
  internal virtual UltraLabel ultraLabel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblDepositTicketStatus")]
  internal virtual Label lblDepositTicketStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbSelectDepositTicket")]
  internal virtual RadioButton rbSelectDepositTicket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbNewDepositTicket")]
  internal virtual RadioButton rbNewDepositTicket { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboCreditCostCenter")]
  internal virtual MGASimpleComboBox comboCreditCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dropTreeGlAccount")]
  internal virtual ExtendedTreeViewDropDown dropTreeGlAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSearchDepositTickets
  {
    get => this._btnSearchDepositTickets;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearchDepositTickets_Click);
      MGAButton searchDepositTickets1 = this._btnSearchDepositTickets;
      if (searchDepositTickets1 != null)
        ((Control) searchDepositTickets1).Click -= eventHandler;
      this._btnSearchDepositTickets = value;
      MGAButton searchDepositTickets2 = this._btnSearchDepositTickets;
      if (searchDepositTickets2 == null)
        return;
      ((Control) searchDepositTickets2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("radioUserDefined")]
  internal virtual RadioButton radioUserDefined { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("radioInterCompany")]
  internal virtual RadioButton radioInterCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("radioEquity")]
  internal virtual RadioButton radioEquity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankAccounts")]
  internal virtual SqlDataAdapter daGetBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  internal virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ControlDataConnection")]
  internal virtual SqlConnection ControlDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetOfficeLocations")]
  internal virtual SqlDataAdapter daGetOfficeLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand4")]
  internal virtual SqlCommand SqlSelectCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsOfficeLocations1")]
  internal virtual dsOfficeLocations DsOfficeLocations1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankAccounts1")]
  internal virtual dsBankAccounts DsBankAccounts1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankDeposits")]
  internal virtual SqlDataAdapter daGetBankDeposits { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  internal virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetInterCompanyExchange")]
  internal virtual SqlDataAdapter daGetInterCompanyExchange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankDeposits1")]
  internal virtual dsBankDeposits DsBankDeposits1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsExchangeAcctBreakout1")]
  internal virtual dsExchangeAcctBreakout DsExchangeAcctBreakout1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboDebitCostCenter")]
  internal virtual MGASimpleComboBox comboDebitCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtReceivedDate")]
  internal virtual MGADateTimePicker dtReceivedDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual MGATextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCheckNumber")]
  internal virtual MGATextBox txtCheckNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDepositDate")]
  internal virtual MGADateTimePicker dtDepositDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRemitter")]
  internal virtual MGATextBox txtRemitter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtCheckAmount
  {
    get => this._txtCheckAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.txtCheckAmount_Validating);
      MGATextBox txtCheckAmount1 = this._txtCheckAmount;
      if (txtCheckAmount1 != null)
        ((Control) txtCheckAmount1).Validating -= cancelEventHandler;
      this._txtCheckAmount = value;
      MGATextBox txtCheckAmount2 = this._txtCheckAmount;
      if (txtCheckAmount2 == null)
        return;
      ((Control) txtCheckAmount2).Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSearchRemitter
  {
    get => this._btnSearchRemitter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearchRemitter_Click);
      MGAButton btnSearchRemitter1 = this._btnSearchRemitter;
      if (btnSearchRemitter1 != null)
        ((Control) btnSearchRemitter1).Click -= eventHandler;
      this._btnSearchRemitter = value;
      MGAButton btnSearchRemitter2 = this._btnSearchRemitter;
      if (btnSearchRemitter2 == null)
        return;
      ((Control) btnSearchRemitter2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbBankAccounts")]
  internal virtual MGASimpleComboBox cmbBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbOfficeLocations")]
  internal virtual MGASimpleComboBox cmbOfficeLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmCashReceipt));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
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
    this.pnlMain = new Panel();
    this.pnlStepTwo = new Panel();
    this.Label4 = new Label();
    this.cmbBankAccounts = new MGASimpleComboBox();
    this.Label6 = new Label();
    this.cmbOfficeLocations = new MGASimpleComboBox();
    this.btnSearchRemitter = new MGAButton();
    this.Label12 = new Label();
    this.comboDebitCostCenter = new MGASimpleComboBox();
    this.dtReceivedDate = new MGADateTimePicker();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.TextBox1 = new MGATextBox();
    this.txtCheckNumber = new MGATextBox();
    this.Label5 = new Label();
    this.Label9 = new Label();
    this.dtDepositDate = new MGADateTimePicker();
    this.Label2 = new Label();
    this.txtRemitter = new MGATextBox();
    this.txtCheckAmount = new MGATextBox();
    this.Label3 = new Label();
    this.GroupBox2 = new GroupBox();
    this.btnSearchDepositTickets = new MGAButton();
    this.rbNewDepositTicket = new RadioButton();
    this.rbSelectDepositTicket = new RadioButton();
    this.lblDepositTicketStatus = new Label();
    this.Label11 = new Label();
    this.comboCreditCostCenter = new MGASimpleComboBox();
    this.dropTreeGlAccount = new ExtendedTreeViewDropDown();
    this.Label10 = new Label();
    this.ultraLabel7 = new UltraLabel();
    this.ultraLabel9 = new UltraLabel();
    this.lblSideBar = new UltraLabel();
    this.panelTop = new Panel();
    this.lblLine = new Label();
    this.label1 = new Label();
    this.pictureBox1 = new PictureBox();
    this.pnlBottom = new Panel();
    this.btnFinish = new MGAButton();
    this.btnCancel = new MGAButton();
    this.pnlStepOne = new Panel();
    this.radioInterCompany = new RadioButton();
    this.radioEquity = new RadioButton();
    this.radioUserDefined = new RadioButton();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.ControlDataConnection = new SqlConnection();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.SqlSelectCommand4 = new SqlCommand();
    this.DsOfficeLocations1 = new dsOfficeLocations();
    this.DsBankAccounts1 = new dsBankAccounts();
    this.daGetBankDeposits = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.daGetInterCompanyExchange = new SqlDataAdapter();
    this.DsBankDeposits1 = new dsBankDeposits();
    this.DsExchangeAcctBreakout1 = new dsExchangeAcctBreakout();
    this.pnlMain.SuspendLayout();
    this.pnlStepTwo.SuspendLayout();
    ((ISupportInitialize) this.cmbBankAccounts).BeginInit();
    ((ISupportInitialize) this.cmbOfficeLocations).BeginInit();
    ((ISupportInitialize) this.btnSearchRemitter).BeginInit();
    ((ISupportInitialize) this.comboDebitCostCenter).BeginInit();
    ((ISupportInitialize) this.dtReceivedDate).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.txtCheckNumber).BeginInit();
    ((ISupportInitialize) this.dtDepositDate).BeginInit();
    ((ISupportInitialize) this.txtRemitter).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.btnSearchDepositTickets).BeginInit();
    ((ISupportInitialize) this.comboCreditCostCenter).BeginInit();
    this.panelTop.SuspendLayout();
    this.pnlBottom.SuspendLayout();
    ((ISupportInitialize) this.btnFinish).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.pnlStepOne.SuspendLayout();
    this.DsOfficeLocations1.BeginInit();
    this.DsBankAccounts1.BeginInit();
    this.DsBankDeposits1.BeginInit();
    this.DsExchangeAcctBreakout1.BeginInit();
    this.SuspendLayout();
    this.pnlMain.Controls.Add((Control) this.pnlStepTwo);
    this.pnlMain.Controls.Add((Control) this.ultraLabel7);
    this.pnlMain.Controls.Add((Control) this.ultraLabel9);
    this.pnlMain.Controls.Add((Control) this.lblSideBar);
    this.pnlMain.Controls.Add((Control) this.panelTop);
    this.pnlMain.Controls.Add((Control) this.pnlBottom);
    this.pnlMain.Controls.Add((Control) this.pnlStepOne);
    this.pnlMain.Dock = DockStyle.Fill;
    this.pnlMain.Location = new Point(0, 0);
    this.pnlMain.Name = "pnlMain";
    this.pnlMain.Size = new Size(666, 560);
    this.pnlMain.TabIndex = 0;
    this.pnlStepTwo.Controls.Add((Control) this.Label4);
    this.pnlStepTwo.Controls.Add((Control) this.cmbBankAccounts);
    this.pnlStepTwo.Controls.Add((Control) this.Label6);
    this.pnlStepTwo.Controls.Add((Control) this.cmbOfficeLocations);
    this.pnlStepTwo.Controls.Add((Control) this.btnSearchRemitter);
    this.pnlStepTwo.Controls.Add((Control) this.Label12);
    this.pnlStepTwo.Controls.Add((Control) this.comboDebitCostCenter);
    this.pnlStepTwo.Controls.Add((Control) this.dtReceivedDate);
    this.pnlStepTwo.Controls.Add((Control) this.Label8);
    this.pnlStepTwo.Controls.Add((Control) this.Label7);
    this.pnlStepTwo.Controls.Add((Control) this.TextBox1);
    this.pnlStepTwo.Controls.Add((Control) this.txtCheckNumber);
    this.pnlStepTwo.Controls.Add((Control) this.Label5);
    this.pnlStepTwo.Controls.Add((Control) this.Label9);
    this.pnlStepTwo.Controls.Add((Control) this.dtDepositDate);
    this.pnlStepTwo.Controls.Add((Control) this.Label2);
    this.pnlStepTwo.Controls.Add((Control) this.txtRemitter);
    this.pnlStepTwo.Controls.Add((Control) this.txtCheckAmount);
    this.pnlStepTwo.Controls.Add((Control) this.Label3);
    this.pnlStepTwo.Controls.Add((Control) this.GroupBox2);
    this.pnlStepTwo.Controls.Add((Control) this.Label11);
    this.pnlStepTwo.Controls.Add((Control) this.comboCreditCostCenter);
    this.pnlStepTwo.Controls.Add((Control) this.dropTreeGlAccount);
    this.pnlStepTwo.Controls.Add((Control) this.Label10);
    this.pnlStepTwo.Dock = DockStyle.Fill;
    this.pnlStepTwo.Location = new Point(208 /*0xD0*/, 80 /*0x50*/);
    this.pnlStepTwo.Name = "pnlStepTwo";
    this.pnlStepTwo.Size = new Size(458, 440);
    this.pnlStepTwo.TabIndex = 0;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.ForeColor = Color.Black;
    this.Label4.Location = new Point(16 /*0x10*/, 40);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(74, 16 /*0x10*/);
    this.Label4.TabIndex = 99;
    this.Label4.Text = "Bank Account:";
    this.cmbBankAccounts.BorderStyle = (UIElementBorderStyle) 4;
    this.cmbBankAccounts.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbBankAccounts).DataMember = "spFin_GetBankAccounts";
    ((UltraDropDownBase) this.cmbBankAccounts).DisplayMember = "BANKNAME";
    this.cmbBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbBankAccounts).Enabled = false;
    ((Control) this.cmbBankAccounts).Location = new Point(120, 40);
    this.cmbBankAccounts.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbBankAccounts).Name = "cmbBankAccounts";
    ((Control) this.cmbBankAccounts).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.cmbBankAccounts).TabIndex = 1;
    ((UltraDropDownBase) this.cmbBankAccounts).ValueMember = "GLACCTID";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.ForeColor = Color.Black;
    this.Label6.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label6.TabIndex = 98;
    this.Label6.Text = "Office Location:";
    this.cmbOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.cmbOfficeLocations.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbOfficeLocations).DataMember = "spFin_GetOfficeLocations";
    ((UltraDropDownBase) this.cmbOfficeLocations).DisplayMember = "Office Location";
    this.cmbOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbOfficeLocations).Enabled = false;
    ((Control) this.cmbOfficeLocations).Location = new Point(120, 16 /*0x10*/);
    this.cmbOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.cmbOfficeLocations).Name = "cmbOfficeLocations";
    ((Control) this.cmbOfficeLocations).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.cmbOfficeLocations).TabIndex = 0;
    ((UltraDropDownBase) this.cmbOfficeLocations).ValueMember = "ID";
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearchRemitter).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSearchRemitter).Location = new Point(360, 64 /*0x40*/);
    ((Control) this.btnSearchRemitter).Name = "btnSearchRemitter";
    ((Control) this.btnSearchRemitter).Size = new Size(27, 20);
    ((Control) this.btnSearchRemitter).TabIndex = 3;
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.ForeColor = Color.Black;
    this.Label12.Location = new Point(16 /*0x10*/, 112 /*0x70*/);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(93, 16 /*0x10*/);
    this.Label12.TabIndex = 91;
    this.Label12.Text = "Debit Cost Center:";
    this.comboDebitCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDebitCostCenter.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboDebitCostCenter).DisplayMember = "";
    this.comboDebitCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDebitCostCenter).Location = new Point(120, 112 /*0x70*/);
    this.comboDebitCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDebitCostCenter).Name = "comboDebitCostCenter";
    ((Control) this.comboDebitCostCenter).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.comboDebitCostCenter).TabIndex = 5;
    ((UltraDropDownBase) this.comboDebitCostCenter).ValueMember = "";
    appearance2.BackColor = SystemColors.Window;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtReceivedDate.Appearance = (AppearanceBase) appearance2;
    this.dtReceivedDate.BackColor = SystemColors.Window;
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
    this.dtReceivedDate.ButtonAppearance = (AppearanceBase) appearance3;
    ((Control) this.dtReceivedDate).Location = new Point(120, 208 /*0xD0*/);
    this.dtReceivedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtReceivedDate).Name = "dtReceivedDate";
    ((Control) this.dtReceivedDate).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtReceivedDate).TabIndex = 9;
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.ForeColor = Color.Black;
    this.Label8.Location = new Point(16 /*0x10*/, 256 /*0x0100*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(59, 16 /*0x10*/);
    this.Label8.TabIndex = 90;
    this.Label8.Text = "Comments:";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.ForeColor = Color.Black;
    this.Label7.Location = new Point(16 /*0x10*/, 184);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(48 /*0x30*/, 16 /*0x10*/);
    this.Label7.TabIndex = 79;
    this.Label7.Text = "Check #:";
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    appearance4.TextHAlign = (HAlign) 1;
    ((TextEditorControlBase) this.TextBox1).Appearance = (AppearanceBase) appearance4;
    ((Control) this.TextBox1).Location = new Point(120, 256 /*0x0100*/);
    this.TextBox1.MGAStyle = MGAStyles.Blue;
    this.TextBox1.Multiline = true;
    ((Control) this.TextBox1).Name = "TextBox1";
    ((Control) this.TextBox1).Size = new Size(328, 48 /*0x30*/);
    ((Control) this.TextBox1).TabIndex = 11;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCheckNumber).Appearance = (AppearanceBase) appearance5;
    ((Control) this.txtCheckNumber).Location = new Point(120, 184);
    this.txtCheckNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCheckNumber).Name = "txtCheckNumber";
    ((Control) this.txtCheckNumber).Size = new Size(120, 20);
    ((Control) this.txtCheckNumber).TabIndex = 8;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.ForeColor = Color.Black;
    this.Label5.Location = new Point(16 /*0x10*/, 232);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(70, 16 /*0x10*/);
    this.Label5.TabIndex = 87;
    this.Label5.Text = "Deposit Date:";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.ForeColor = Color.Black;
    this.Label9.Location = new Point(16 /*0x10*/, 208 /*0xD0*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(77, 16 /*0x10*/);
    this.Label9.TabIndex = 85;
    this.Label9.Text = "Received Date:";
    appearance6.BackColor = SystemColors.Window;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtDepositDate.Appearance = (AppearanceBase) appearance6;
    this.dtDepositDate.BackColor = SystemColors.Window;
    appearance7.AlphaLevel = (short) 14;
    appearance7.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance7.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance7.BackColorAlpha = (Alpha) 2;
    appearance7.BackGradientAlignment = (GradientAlignment) 4;
    appearance7.BackGradientStyle = (GradientStyle) 5;
    appearance7.BorderAlpha = (Alpha) 1;
    appearance7.BorderColor = Color.FromArgb(78, 122, 171);
    appearance7.ForeColor = Color.FromArgb(49, 85, 153);
    appearance7.ForegroundAlpha = (Alpha) 2;
    this.dtDepositDate.ButtonAppearance = (AppearanceBase) appearance7;
    ((Control) this.dtDepositDate).Location = new Point(120, 232);
    this.dtDepositDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtDepositDate).Name = "dtDepositDate";
    ((Control) this.dtDepositDate).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.dtDepositDate).TabIndex = 10;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.ForeColor = Color.Black;
    this.Label2.Location = new Point(16 /*0x10*/, 160 /*0xA0*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(78, 16 /*0x10*/);
    this.Label2.TabIndex = 77;
    this.Label2.Text = "Check Amount:";
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRemitter).Appearance = (AppearanceBase) appearance8;
    ((TextEditorControlBase) this.txtRemitter).BackColor = Color.WhiteSmoke;
    ((Control) this.txtRemitter).Enabled = false;
    ((Control) this.txtRemitter).Location = new Point(120, 64 /*0x40*/);
    this.txtRemitter.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtRemitter).Name = "txtRemitter";
    ((EditorButtonControlBase) this.txtRemitter).ReadOnly = true;
    ((Control) this.txtRemitter).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.txtRemitter).TabIndex = 2;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    appearance9.TextHAlign = (HAlign) 3;
    ((TextEditorControlBase) this.txtCheckAmount).Appearance = (AppearanceBase) appearance9;
    ((Control) this.txtCheckAmount).Location = new Point(120, 160 /*0xA0*/);
    this.txtCheckAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCheckAmount).Name = "txtCheckAmount";
    ((Control) this.txtCheckAmount).Size = new Size(120, 20);
    ((Control) this.txtCheckAmount).TabIndex = 7;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.ForeColor = Color.Black;
    this.Label3.Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(65, 16 /*0x10*/);
    this.Label3.TabIndex = 75;
    this.Label3.Text = "Check From:";
    this.GroupBox2.Controls.Add((Control) this.btnSearchDepositTickets);
    this.GroupBox2.Controls.Add((Control) this.rbNewDepositTicket);
    this.GroupBox2.Controls.Add((Control) this.rbSelectDepositTicket);
    this.GroupBox2.Controls.Add((Control) this.lblDepositTicketStatus);
    this.GroupBox2.Location = new Point(20, 312);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(432, 120);
    this.GroupBox2.TabIndex = 62;
    this.GroupBox2.TabStop = false;
    ((Control) this.btnSearchDepositTickets).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance10.BackColor = Color.FromArgb(248, 248, 248);
    appearance10.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.BorderColor = Color.DarkGray;
    appearance10.ImageHAlign = (HAlign) 2;
    appearance10.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearchDepositTickets).Appearance = (AppearanceBase) appearance10;
    ((ControlBase) this.btnSearchDepositTickets).BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((Control) this.btnSearchDepositTickets).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnSearchDepositTickets).ForeColor = Color.Black;
    ((Control) this.btnSearchDepositTickets).Location = new Point(200, 32 /*0x20*/);
    ((Control) this.btnSearchDepositTickets).Name = "btnSearchDepositTickets";
    ((Control) this.btnSearchDepositTickets).Size = new Size(88, 24);
    ((Control) this.btnSearchDepositTickets).TabIndex = 2;
    ((ControlBase) this.btnSearchDepositTickets).Text = "Deposit Tickets";
    this.rbNewDepositTicket.Checked = true;
    this.rbNewDepositTicket.FlatStyle = FlatStyle.Flat;
    this.rbNewDepositTicket.Location = new Point(16 /*0x10*/, 8);
    this.rbNewDepositTicket.Name = "rbNewDepositTicket";
    this.rbNewDepositTicket.Size = new Size(176 /*0xB0*/, 24);
    this.rbNewDepositTicket.TabIndex = 0;
    this.rbNewDepositTicket.TabStop = true;
    this.rbNewDepositTicket.Text = "Create New Deposit Ticket";
    this.rbSelectDepositTicket.FlatStyle = FlatStyle.Flat;
    this.rbSelectDepositTicket.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.rbSelectDepositTicket.Name = "rbSelectDepositTicket";
    this.rbSelectDepositTicket.Size = new Size(176 /*0xB0*/, 24);
    this.rbSelectDepositTicket.TabIndex = 1;
    this.rbSelectDepositTicket.Text = "Add To Existing Deposit Ticket";
    this.lblDepositTicketStatus.ForeColor = Color.SlateGray;
    this.lblDepositTicketStatus.Location = new Point(8, 64 /*0x40*/);
    this.lblDepositTicketStatus.Name = "lblDepositTicketStatus";
    this.lblDepositTicketStatus.Size = new Size(416, 48 /*0x30*/);
    this.lblDepositTicketStatus.TabIndex = 3;
    this.lblDepositTicketStatus.Text = "This cash receipt will be added to a new deposit ticket generated by the system.";
    this.lblDepositTicketStatus.TextAlign = ContentAlignment.TopCenter;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(16 /*0x10*/, 136);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.Label11.TabIndex = 60;
    this.Label11.Text = "Credit Cost Center:";
    this.comboCreditCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCreditCostCenter.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboCreditCostCenter).DisplayMember = "";
    this.comboCreditCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCreditCostCenter).Location = new Point(120, 136);
    this.comboCreditCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCreditCostCenter).Name = "comboCreditCostCenter";
    ((Control) this.comboCreditCostCenter).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.comboCreditCostCenter).TabIndex = 6;
    ((UltraDropDownBase) this.comboCreditCostCenter).ValueMember = "";
    this.dropTreeGlAccount.DropDownHeight = 300;
    this.dropTreeGlAccount.DropDownWidth = 300;
    this.dropTreeGlAccount.Font = new Font("Tahoma", 8f);
    this.dropTreeGlAccount.Location = new Point(120, 88);
    this.dropTreeGlAccount.Name = "dropTreeGlAccount";
    this.dropTreeGlAccount.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeGlAccount.ShowEquityAccounts = true;
    this.dropTreeGlAccount.ShowExpenseAccounts = true;
    this.dropTreeGlAccount.ShowIncomeAccounts = true;
    this.dropTreeGlAccount.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeGlAccount.ShowSystemDefinedAccounts = true;
    this.dropTreeGlAccount.Size = new Size(240 /*0xF0*/, 20);
    this.dropTreeGlAccount.TabIndex = 4;
    this.dropTreeGlAccount.UseCheckedStateSelectionOverride = false;
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(16 /*0x10*/, 88);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(63 /*0x3F*/, 16 /*0x10*/);
    this.Label10.TabIndex = 58;
    this.Label10.Text = "GL Account:";
    appearance11.BackColor = Color.White;
    appearance11.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.BackGradientAlignment = (GradientAlignment) 3;
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance11;
    ((ControlBase) this.ultraLabel7).BackColor = Color.White;
    ((Control) this.ultraLabel7).Font = new Font("Arial", 8f);
    ((ControlBase) this.ultraLabel7).ForeColor = Color.Black;
    ((Control) this.ultraLabel7).Location = new Point(16 /*0x10*/, 104);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(168, 128 /*0x80*/);
    ((Control) this.ultraLabel7).TabIndex = 211;
    ((ControlBase) this.ultraLabel7).Text = "This screen allows you to enter Cash Receipt/Deposit.";
    appearance12.BackColor = Color.White;
    appearance12.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.BackGradientAlignment = (GradientAlignment) 3;
    appearance12.BackGradientStyle = (GradientStyle) 2;
    appearance12.ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel9).Appearance = (AppearanceBase) appearance12;
    ((AutoSizeControlBase) this.ultraLabel9).AutoSize = true;
    ((ControlBase) this.ultraLabel9).BackColor = Color.White;
    ((Control) this.ultraLabel9).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((ControlBase) this.ultraLabel9).ForeColor = Color.Black;
    ((Control) this.ultraLabel9).Location = new Point(8, 88);
    ((Control) this.ultraLabel9).Name = "ultraLabel9";
    ((Control) this.ultraLabel9).Size = new Size(124, 15);
    ((Control) this.ultraLabel9).TabIndex = 208 /*0xD0*/;
    ((ControlBase) this.ultraLabel9).Text = "Cash Receipt/Deposit";
    appearance13.BackColor = Color.White;
    appearance13.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance13.BackGradientAlignment = (GradientAlignment) 3;
    appearance13.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.lblSideBar).Appearance = (AppearanceBase) appearance13;
    ((ControlBase) this.lblSideBar).BackColor = Color.White;
    this.lblSideBar.BorderStyleOuter = (UIElementBorderStyle) 1;
    ((Control) this.lblSideBar).Dock = DockStyle.Left;
    ((Control) this.lblSideBar).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.lblSideBar).ForeColor = Color.Black;
    ((Control) this.lblSideBar).Location = new Point(0, 80 /*0x50*/);
    ((Control) this.lblSideBar).Name = "lblSideBar";
    ((Control) this.lblSideBar).Size = new Size(208 /*0xD0*/, 440);
    ((Control) this.lblSideBar).TabIndex = 191;
    this.panelTop.BackColor = Color.White;
    this.panelTop.Controls.Add((Control) this.lblLine);
    this.panelTop.Controls.Add((Control) this.label1);
    this.panelTop.Controls.Add((Control) this.pictureBox1);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(666, 80 /*0x50*/);
    this.panelTop.TabIndex = 190;
    this.lblLine.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.lblLine.Dock = DockStyle.Bottom;
    this.lblLine.Location = new Point(0, 79);
    this.lblLine.Name = "lblLine";
    this.lblLine.Size = new Size(666, 1);
    this.lblLine.TabIndex = 1;
    this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(458, 48 /*0x30*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(204, 25);
    this.label1.TabIndex = 0;
    this.label1.Text = "Cash Receipt/Deposit";
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(0, -8);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(96 /*0x60*/, 88);
    this.pictureBox1.TabIndex = 2;
    this.pictureBox1.TabStop = false;
    this.pnlBottom.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.pnlBottom.Controls.Add((Control) this.btnFinish);
    this.pnlBottom.Controls.Add((Control) this.btnCancel);
    this.pnlBottom.Dock = DockStyle.Bottom;
    this.pnlBottom.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.pnlBottom.ForeColor = Color.Black;
    this.pnlBottom.Location = new Point(0, 520);
    this.pnlBottom.Name = "pnlBottom";
    this.pnlBottom.Size = new Size(666, 40);
    this.pnlBottom.TabIndex = 189;
    ((Control) this.btnFinish).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance14.BackColor = Color.FromArgb(248, 248, 248);
    appearance14.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = Color.DarkGray;
    appearance14.ImageHAlign = (HAlign) 2;
    appearance14.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnFinish).Appearance = (AppearanceBase) appearance14;
    ((Control) this.btnFinish).Location = new Point(471, 8);
    ((Control) this.btnFinish).Name = "btnFinish";
    ((Control) this.btnFinish).Size = new Size(88, 24);
    ((Control) this.btnFinish).TabIndex = 0;
    ((ControlBase) this.btnFinish).Text = "Finish";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance15.BackColor = Color.FromArgb(248, 248, 248);
    appearance15.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.BorderColor = Color.DarkGray;
    appearance15.ImageHAlign = (HAlign) 2;
    appearance15.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance15;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(562, 8);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(88, 24);
    ((Control) this.btnCancel).TabIndex = 1;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.pnlStepOne.Controls.Add((Control) this.radioInterCompany);
    this.pnlStepOne.Controls.Add((Control) this.radioEquity);
    this.pnlStepOne.Controls.Add((Control) this.radioUserDefined);
    this.pnlStepOne.Dock = DockStyle.Fill;
    this.pnlStepOne.Location = new Point(0, 0);
    this.pnlStepOne.Name = "pnlStepOne";
    this.pnlStepOne.Size = new Size(666, 560);
    this.pnlStepOne.TabIndex = 209;
    this.radioInterCompany.FlatStyle = FlatStyle.Flat;
    this.radioInterCompany.Location = new Point(112 /*0x70*/, 152);
    this.radioInterCompany.Name = "radioInterCompany";
    this.radioInterCompany.Size = new Size(200, 24);
    this.radioInterCompany.TabIndex = 1;
    this.radioInterCompany.Text = "Inter-Company Exchange Account";
    this.radioEquity.Checked = true;
    this.radioEquity.FlatStyle = FlatStyle.Flat;
    this.radioEquity.Location = new Point(112 /*0x70*/, 128 /*0x80*/);
    this.radioEquity.Name = "radioEquity";
    this.radioEquity.Size = new Size(184, 24);
    this.radioEquity.TabIndex = 0;
    this.radioEquity.TabStop = true;
    this.radioEquity.Text = "I am Equity Account";
    this.radioUserDefined.FlatStyle = FlatStyle.Flat;
    this.radioUserDefined.Location = new Point(112 /*0x70*/, 176 /*0xB0*/);
    this.radioUserDefined.Name = "radioUserDefined";
    this.radioUserDefined.Size = new Size(192 /*0xC0*/, 24);
    this.radioUserDefined.TabIndex = 2;
    this.radioUserDefined.Text = "User Defined";
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
    this.SqlSelectCommand2.Connection = this.ControlDataConnection;
    this.SqlSelectCommand2.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand2.Parameters.Add(new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4));
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
    this.SqlSelectCommand1.Connection = this.ControlDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand4.CommandText = "[spFin_GetInterCompanyExhange]";
    this.SqlSelectCommand4.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand4.Connection = this.ControlDataConnection;
    this.SqlSelectCommand4.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand4.Parameters.Add(new SqlParameter("@glacctid", SqlDbType.Int, 4));
    this.DsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.DsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.DsBankAccounts1.DataSetName = "dsBankAccounts";
    this.DsBankAccounts1.Locale = new CultureInfo("en-US");
    this.daGetBankDeposits.SelectCommand = this.SqlSelectCommand3;
    this.daGetBankDeposits.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankDeposits", new DataColumnMapping[9]
      {
        new DataColumnMapping("remitter", "remitter"),
        new DataColumnMapping("postdate", "postdate"),
        new DataColumnMapping("receiveddate", "receiveddate"),
        new DataColumnMapping("depositdate", "depositdate"),
        new DataColumnMapping("checknumber", "checknumber"),
        new DataColumnMapping("amount", "amount"),
        new DataColumnMapping("comments", "comments"),
        new DataColumnMapping("Bank", "Bank"),
        new DataColumnMapping("OffsetAccount", "OffsetAccount")
      })
    });
    this.SqlSelectCommand3.CommandText = "[spFin_GetBankDeposits]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.ControlDataConnection;
    this.SqlSelectCommand3.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.daGetInterCompanyExchange.SelectCommand = this.SqlSelectCommand4;
    this.daGetInterCompanyExchange.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetInterCompanyExhange", new DataColumnMapping[5]
      {
        new DataColumnMapping("Date", "Date"),
        new DataColumnMapping("transactnum", "transactnum"),
        new DataColumnMapping("amount", "amount"),
        new DataColumnMapping("ParentTransactionType", "ParentTransactionType"),
        new DataColumnMapping("Comments", "Comments")
      })
    });
    this.DsBankDeposits1.DataSetName = "dsBankDeposits";
    this.DsBankDeposits1.Locale = new CultureInfo("en-US");
    this.DsExchangeAcctBreakout1.DataSetName = "dsExchangeAcctBreakout";
    this.DsExchangeAcctBreakout1.Locale = new CultureInfo("en-US");
    this.AcceptButton = (IButtonControl) this.btnFinish;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(666, 560);
    this.ControlBox = false;
    this.Controls.Add((Control) this.pnlMain);
    this.Font = new Font("Tahoma", 8f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (frmCashReceipt);
    this.ShowInTaskbar = false;
    this.Text = "Cash Receipt / Deposit";
    this.pnlMain.ResumeLayout(false);
    this.pnlStepTwo.ResumeLayout(false);
    ((ISupportInitialize) this.cmbBankAccounts).EndInit();
    ((ISupportInitialize) this.cmbOfficeLocations).EndInit();
    ((ISupportInitialize) this.btnSearchRemitter).EndInit();
    ((ISupportInitialize) this.comboDebitCostCenter).EndInit();
    ((ISupportInitialize) this.dtReceivedDate).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.txtCheckNumber).EndInit();
    ((ISupportInitialize) this.dtDepositDate).EndInit();
    ((ISupportInitialize) this.txtRemitter).EndInit();
    ((ISupportInitialize) this.txtCheckAmount).EndInit();
    this.GroupBox2.ResumeLayout(false);
    ((ISupportInitialize) this.btnSearchDepositTickets).EndInit();
    ((ISupportInitialize) this.comboCreditCostCenter).EndInit();
    this.panelTop.ResumeLayout(false);
    this.pnlBottom.ResumeLayout(false);
    ((ISupportInitialize) this.btnFinish).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.pnlStepOne.ResumeLayout(false);
    this.DsOfficeLocations1.EndInit();
    this.DsBankAccounts1.EndInit();
    this.DsBankDeposits1.EndInit();
    this.DsExchangeAcctBreakout1.EndInit();
    this.ResumeLayout(false);
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnSearchRemitter_Click(object sender, EventArgs e)
  {
    FormSearchEntity formSearchEntity = new FormSearchEntity(MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SearchEntityTypes.All);
    try
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      ((TextEditorControlBase) this.txtRemitter).Text = formSearchEntity.EntityName;
      this._currentRemitterGuid = formSearchEntity.EntityGuid;
    }
    finally
    {
      formSearchEntity.Dispose();
    }
  }

  private void LoadCostCenters()
  {
    DataSet dataSet = new DataSet();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetCostCentersList", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    try
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) this._GLCompanyID);
      sqlDataAdapter.Fill(dataSet);
      ((UltraGridBase) this.comboCreditCostCenter).DataSource = (object) dataSet;
      ((UltraDropDownBase) this.comboCreditCostCenter).DisplayMember = "Name";
      ((UltraDropDownBase) this.comboCreditCostCenter).ValueMember = "CostCenterID";
      ((UltraGridBase) this.comboDebitCostCenter).DataSource = (object) dataSet;
      ((UltraDropDownBase) this.comboDebitCostCenter).DisplayMember = "Name";
      ((UltraDropDownBase) this.comboDebitCostCenter).ValueMember = "CostCenterID";
      if (dataSet.Tables.Count <= 1 || dataSet.Tables[1].Rows.Count <= 0)
        return;
      this.comboDebitCostCenter.Value = RuntimeHelpers.GetObjectValue(dataSet.Tables[1].Rows[0][0]);
      this.comboCreditCostCenter.Value = RuntimeHelpers.GetObjectValue(dataSet.Tables[1].Rows[0][0]);
    }
    finally
    {
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  private frmCashReceipt()
  {
    this.Load += new EventHandler(this.Deposit_Load);
    this.Resize += new EventHandler(this.frmCashReceipt_Resize);
    this.NewDepositString = "This cash receipt will be added to a new deposit ticket generated by the system.";
    this.DepositTicketSelected = "This cash receipt will be added to the specified deposit ticket. The deposit ticket date is {0} and the cash receipt amount will be added to the current amount of {1}.";
    this.InitializeComponent();
  }

  public frmCashReceipt(int BankGLAccountID, int GLCompanyID)
  {
    this.Load += new EventHandler(this.Deposit_Load);
    this.Resize += new EventHandler(this.frmCashReceipt_Resize);
    this.NewDepositString = "This cash receipt will be added to a new deposit ticket generated by the system.";
    this.DepositTicketSelected = "This cash receipt will be added to the specified deposit ticket. The deposit ticket date is {0} and the cash receipt amount will be added to the current amount of {1}.";
    this.InitializeComponent();
    this._BankAcctGL = BankGLAccountID;
    this._GLCompanyID = GLCompanyID;
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.LoadCostCenters();
    ((Control) this.btnSearchDepositTickets).DataBindings.Add("Enabled", (object) this.rbSelectDepositTicket, "Checked");
    this.dropTreeGlAccount.LoadGLAccounts(GLCompanyID);
  }

  private void LoadOfficeLocationDefaults(int GlCompanyId)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.LoadBankAccounts(GlCompanyId);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.cmbOfficeLocations).DataSource = (object) Methods.GetOfficeLocationDataset();
    foreach (UltraGridRow row in ((UltraGridBase) this.cmbOfficeLocations).Rows)
    {
      if (Conversions.ToInteger(row.Cells["id"].Value) == this._GLCompanyID)
      {
        ((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow = row;
        this.LoadOfficeLocationDefaults(this._GLCompanyID);
        ((Control) this.cmbOfficeLocations).Enabled = false;
        break;
      }
    }
  }

  private void LoadBankAccounts(int glCompanyId)
  {
    this.DsBankAccounts1.Clear();
    this.daGetBankAccounts.SelectCommand.Parameters["@GLCOMPANYID"].Value = (object) glCompanyId;
    this.daGetBankAccounts.Fill((DataTable) this.DsBankAccounts1.spFin_GetBankAccounts);
    ((UltraGridBase) this.cmbBankAccounts).DataSource = (object) this.DsBankAccounts1;
    this.cmbBankAccounts.Value = (object) this._BankAcctGL;
    ((Control) this.cmbBankAccounts).Enabled = false;
  }

  private void txtCheckAmount_Validating(object sender, CancelEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtCheckAmount).Text, "", false) == 0)
      return;
    if (!Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtCheckAmount).Text))
    {
      int num = (int) MessageBox.Show("Transfer amount must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
      ((TextEditorControlBase) this.txtCheckAmount).Text = Microsoft.VisualBasic.Strings.Format((object) ((TextEditorControlBase) this.txtCheckAmount).Text, "Currency");
  }

  private void Deposit_Load(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{EE3AFC8D-71C9-4594-95CB-19889DF74C98}"))
    {
      MGASystems.IMS.Accounting.Banking.Utility.DenyAccess();
      this.BeginInvoke((Delegate) new MethodInvoker(((Form) this).Close));
    }
    else
    {
      this.dtReceivedDate.Value = (object) DateTime.Now;
      this.dtDepositDate.Value = (object) DateTime.Now;
      this.LoadOfficeLocations();
    }
  }

  private void btnSearchDepositTickets_Click(object sender, EventArgs e)
  {
    frmOpenDepositTickets openDepositTickets = new frmOpenDepositTickets(this._BankAcctGL);
    try
    {
      if (openDepositTickets.ShowDialog() == DialogResult.OK)
      {
        this._depositId = openDepositTickets.DepositID;
        this.lblDepositTicketStatus.Text = string.Format(this.DepositTicketSelected, (object) Microsoft.VisualBasic.Strings.Format((object) openDepositTickets.DepositDate, "Short Date"), (object) Microsoft.VisualBasic.Strings.Format((object) openDepositTickets.DepositAmount, "Currency"));
      }
      else
      {
        this.lblDepositTicketStatus.Text = this.NewDepositString;
        this.rbNewDepositTicket.Checked = true;
      }
    }
    finally
    {
      openDepositTickets.Dispose();
    }
  }

  private void btnFinish_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.PostCashReceipt();
    this.DialogResult = DialogResult.OK;
    this.Close();
    int num = (int) MessageBox.Show("Cash Receipt has been posted succesfully.", "Posted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
  }

  private bool ValidateForm()
  {
    bool flag;
    if (this._currentRemitterGuid.Equals(Guid.Empty) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtRemitter).Text, "", false) == 0)
    {
      int num = (int) MessageBox.Show("You must select a remitter to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtCheckAmount).Text, "", false) == 0 || !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtCheckAmount).Text))
    {
      int num = (int) MessageBox.Show("You must enter a check amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtCheckNumber).Text, "", false) == 0)
    {
      int num = (int) MessageBox.Show("You must enter a check number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (((UltraDropDownBase) this.cmbOfficeLocations).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (((UltraDropDownBase) this.cmbBankAccounts).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboDebitCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a debit cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboCreditCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a credit cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
    {
      DateTime dateTime = this.dtDepositDate.DateTime;
      DateTime date1 = dateTime.Date;
      dateTime = this.dtReceivedDate.DateTime;
      DateTime date2 = dateTime.Date;
      if (DateTime.Compare(date1, date2) < 0)
      {
        int num = (int) MessageBox.Show("Deposit date must be greater than or equal to received date.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = false;
      }
      else if (this.rbSelectDepositTicket.Checked & this._depositId == 0)
      {
        int num = (int) MessageBox.Show("You have chosen to add this cash receipt to an existing deposit ticket, but you ave not specified the deposit ticket ID.", "Can Not Post Cash Receipt!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        flag = false;
      }
      else
        flag = true;
    }
    return flag;
  }

  private void PostCashReceipt()
  {
    Decimal num1 = Decimal.Parse(((TextEditorControlBase) this.txtCheckAmount).Text, NumberStyles.Any);
    if (this._cashReceiptObject == null)
      this._cashReceiptObject = new CashReceipt(Conversions.ToDecimal(((TextEditorControlBase) this.txtCheckAmount).Text), ((TextEditorControlBase) this.txtCheckNumber).Text, Conversions.ToDate(this.dtReceivedDate.Value), Conversions.ToDate(this.dtDepositDate.Value));
    int CostCenterId1 = int.Parse(this.comboDebitCostCenter.Value.ToString());
    int CostCenterId2 = int.Parse(this.comboCreditCostCenter.Value.ToString());
    try
    {
      CashReceipt cashReceiptObject = this._cashReceiptObject;
      cashReceiptObject.TransactionType = AccountingTransactionTypes.JournalEntry;
      cashReceiptObject.TransactionDate = this.dtDepositDate.DateTime;
      cashReceiptObject.TransactionEntityGuid = this._currentRemitterGuid;
      cashReceiptObject.AddDebit("CashEntry", new TransactionEntry(num1, Conversions.ToInteger(((UltraDropDownBase) this.cmbBankAccounts).SelectedRow.Cells["GLACCTID"].Value), new CostCenterAllocationCollection()
      {
        {
          new CostCenterAllocation(CostCenterId1, num1),
          num1
        }
      }));
      cashReceiptObject.AddCredit("CreditEntry", new TransactionEntry(Conversions.ToDecimal(((TextEditorControlBase) this.txtCheckAmount).Text), this.dropTreeGlAccount.GLAccountID, new CostCenterAllocationCollection()
      {
        {
          new CostCenterAllocation(CostCenterId2, num1),
          num1
        }
      }));
      cashReceiptObject.Comments = ((TextEditorControlBase) this.TextBox1).Text;
      if (cashReceiptObject.TransactionIsBalanced)
      {
        if (this.rbNewDepositTicket.Checked)
          cashReceiptObject.PostTransaction(this._BankAcctGL, CashReceipt.CashReceiptDepositType.NewDepositTicket);
        else
          cashReceiptObject.PostTransaction(this._BankAcctGL, CashReceipt.CashReceiptDepositType.ExistingDepositTicket, this._depositId);
      }
    }
    catch (InvalidArgumentException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num2 = (int) MessageBox.Show(ex.Message, "Can Not Post Cash Receipt!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
  }

  private void frmCashReceipt_Resize(object sender, EventArgs e) => this.Refresh();
}
