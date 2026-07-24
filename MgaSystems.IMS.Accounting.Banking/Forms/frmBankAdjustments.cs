// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmBankAdjustments
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Banking.Enumerations;
using MGASystems.IMS.Accounting.Banking.Services;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{202B7580-2D2C-4d24-9C9C-9DF92A97EFC4}", "Bank Adjustments / Transactions", "Determines whether or not the user can add bank fees or interest income adjustments.", "Accounting")]
public sealed class frmBankAdjustments : Form
{
  private IContainer components;
  private string _bankName;
  private string _bankAcctNumber;
  private int _bankGLAcct;
  private int _bankFeesGLAcct;
  private int _bankInterestGLAcct;
  private int _glcompanyid;
  private BankingTransactionType _adjustmentType;

  private frmBankAdjustments()
  {
    this.Load += new EventHandler(this.frmBankAdjustments_Load);
    this.Resize += new EventHandler(this.frmBankAdjustments_Resize);
    this.InitializeComponent();
  }

  internal frmBankAdjustments(
    int GLCompanyID,
    string BankName,
    string BankAccountNumber,
    int BankGLAccountNumber,
    BankingTransactionType TransactionType)
  {
    this.Load += new EventHandler(this.frmBankAdjustments_Load);
    this.Resize += new EventHandler(this.frmBankAdjustments_Resize);
    this.InitializeComponent();
    this._glcompanyid = GLCompanyID;
    this._bankName = BankName;
    this._bankAcctNumber = BankAccountNumber;
    this._bankGLAcct = BankGLAccountNumber;
    this._adjustmentType = TransactionType;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel7")]
  internal virtual UltraLabel ultraLabel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel9")]
  internal virtual UltraLabel ultraLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel4")]
  internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtBankFeesAccount")]
  internal virtual ExtendedTreeViewDropDown dtBankFeesAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dateTimeTransactionDate")]
  internal virtual MGADateTimePicker dateTimeTransactionDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGATextBox txtTransactionAmount
  {
    get => this._txtTransactionAmount;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.txtTransactionAmount_Validating);
      MGATextBox transactionAmount1 = this._txtTransactionAmount;
      if (transactionAmount1 != null)
        ((Control) transactionAmount1).Validating -= cancelEventHandler;
      this._txtTransactionAmount = value;
      MGATextBox transactionAmount2 = this._txtTransactionAmount;
      if (transactionAmount2 == null)
        return;
      ((Control) transactionAmount2).Validating += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBankAccountNumber")]
  internal virtual Label lblBankAccountNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBankName")]
  internal virtual Label lblBankName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel2")]
  internal virtual UltraLabel UltraLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSideBar")]
  internal virtual UltraLabel lblSideBar { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel1")]
  internal virtual UltraLabel UltraLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboDebitCostCenter")]
  internal virtual MGASimpleComboBox comboDebitCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboCreditCostCenter")]
  internal virtual MGASimpleComboBox comboCreditCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (frmBankAdjustments));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    this.Label5 = new Label();
    this.PictureBox1 = new PictureBox();
    this.Panel1 = new Panel();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.ultraLabel7 = new UltraLabel();
    this.ultraLabel9 = new UltraLabel();
    this.Panel2 = new Panel();
    this.comboCreditCostCenter = new MGASimpleComboBox();
    this.Label10 = new Label();
    this.dtBankFeesAccount = new ExtendedTreeViewDropDown();
    this.dateTimeTransactionDate = new MGADateTimePicker();
    this.txtTransactionAmount = new MGATextBox();
    this.comboDebitCostCenter = new MGASimpleComboBox();
    this.Label9 = new Label();
    this.Label6 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.lblBankAccountNumber = new Label();
    this.lblBankName = new Label();
    this.Panel4 = new Panel();
    this.UltraLabel1 = new UltraLabel();
    this.UltraLabel2 = new UltraLabel();
    this.lblSideBar = new UltraLabel();
    this.Panel3 = new Panel();
    this.btnSave = new MGAButton();
    this.btnCancel = new MGAButton();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.comboCreditCostCenter).BeginInit();
    ((ISupportInitialize) this.dateTimeTransactionDate).BeginInit();
    ((ISupportInitialize) this.txtTransactionAmount).BeginInit();
    ((ISupportInitialize) this.comboDebitCostCenter).BeginInit();
    this.Panel4.SuspendLayout();
    this.Panel3.SuspendLayout();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    this.SuspendLayout();
    this.Label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.White;
    this.Label5.Font = new Font("Arial", 12f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label5.Location = new Point(336, 56);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(267, 22);
    this.Label5.TabIndex = 0;
    this.Label5.Text = "Bank Adjustments / Transactions";
    this.Label5.TextAlign = ContentAlignment.MiddleRight;
    this.PictureBox1.BackColor = Color.White;
    this.PictureBox1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(8, 8);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.Panel1.BackColor = Color.White;
    this.Panel1.Controls.Add((Control) this.Label7);
    this.Panel1.Controls.Add((Control) this.Label5);
    this.Panel1.Controls.Add((Control) this.PictureBox1);
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(610, 80 /*0x50*/);
    this.Panel1.TabIndex = 0;
    this.Label7.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label7.Dock = DockStyle.Bottom;
    this.Label7.ForeColor = Color.FromArgb(239, 247, 253);
    this.Label7.Location = new Point(0, 79);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(610, 1);
    this.Label7.TabIndex = 1;
    this.Label8.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label8.Dock = DockStyle.Left;
    this.Label8.ForeColor = Color.FromArgb(239, 247, 253);
    this.Label8.Location = new Point(0, 80 /*0x50*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(1, 272);
    this.Label8.TabIndex = 18;
    appearance1.BackColor = Color.White;
    appearance1.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance1.BackGradientAlignment = (GradientAlignment) 3;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.ultraLabel7).BackColor = Color.White;
    ((Control) this.ultraLabel7).Font = new Font("Arial", 8f);
    ((ControlBase) this.ultraLabel7).ForeColor = Color.Black;
    ((Control) this.ultraLabel7).Location = new Point(16 /*0x10*/, 96 /*0x60*/);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(168, 128 /*0x80*/);
    ((Control) this.ultraLabel7).TabIndex = 214;
    ((ControlBase) this.ultraLabel7).Text = "Use this screen to enter adjustments made by your bank. Select the offsetting ledger account, transaction amount and transaction date. You should also assign bank adjustments to a cost center by selecting one from the drop-down box.";
    appearance2.BackColor = Color.White;
    appearance2.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.BackGradientAlignment = (GradientAlignment) 3;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel9).Appearance = (AppearanceBase) appearance2;
    ((AutoSizeControlBase) this.ultraLabel9).AutoSize = true;
    ((ControlBase) this.ultraLabel9).BackColor = Color.White;
    ((Control) this.ultraLabel9).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((ControlBase) this.ultraLabel9).ForeColor = Color.Black;
    ((Control) this.ultraLabel9).Location = new Point(8, 80 /*0x50*/);
    ((Control) this.ultraLabel9).Name = "ultraLabel9";
    ((Control) this.ultraLabel9).Size = new Size(120, 15);
    ((Control) this.ultraLabel9).TabIndex = 213;
    ((ControlBase) this.ultraLabel9).Text = "BANK ADJUSTMENTS";
    this.Panel2.Controls.Add((Control) this.comboCreditCostCenter);
    this.Panel2.Controls.Add((Control) this.Label10);
    this.Panel2.Controls.Add((Control) this.dtBankFeesAccount);
    this.Panel2.Controls.Add((Control) this.dateTimeTransactionDate);
    this.Panel2.Controls.Add((Control) this.txtTransactionAmount);
    this.Panel2.Controls.Add((Control) this.comboDebitCostCenter);
    this.Panel2.Controls.Add((Control) this.Label9);
    this.Panel2.Controls.Add((Control) this.Label6);
    this.Panel2.Controls.Add((Control) this.Label4);
    this.Panel2.Controls.Add((Control) this.Label3);
    this.Panel2.Controls.Add((Control) this.Label2);
    this.Panel2.Controls.Add((Control) this.Label1);
    this.Panel2.Controls.Add((Control) this.lblBankAccountNumber);
    this.Panel2.Controls.Add((Control) this.lblBankName);
    this.Panel2.Controls.Add((Control) this.Panel4);
    this.Panel2.Controls.Add((Control) this.Panel3);
    this.Panel2.Dock = DockStyle.Fill;
    this.Panel2.Location = new Point(1, 80 /*0x50*/);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(609, 272);
    this.Panel2.TabIndex = 215;
    this.comboCreditCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCreditCostCenter.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboCreditCostCenter).DisplayMember = "Name";
    this.comboCreditCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCreditCostCenter).Location = new Point(344, 136);
    this.comboCreditCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCreditCostCenter).Name = "comboCreditCostCenter";
    ((Control) this.comboCreditCostCenter).Size = new Size(248, 20);
    ((Control) this.comboCreditCostCenter).TabIndex = 47;
    ((UltraDropDownBase) this.comboCreditCostCenter).ValueMember = "CostCenterID";
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.Location = new Point(208 /*0xD0*/, 136);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(99, 17);
    this.Label10.TabIndex = 46;
    this.Label10.Text = "Credit Cost Center:";
    this.Label10.TextAlign = ContentAlignment.MiddleLeft;
    this.dtBankFeesAccount.DropDownHeight = 300;
    this.dtBankFeesAccount.DropDownWidth = 300;
    this.dtBankFeesAccount.Font = new Font("Tahoma", 8f);
    this.dtBankFeesAccount.Location = new Point(344, 72);
    this.dtBankFeesAccount.Name = "dtBankFeesAccount";
    this.dtBankFeesAccount.Size = new Size(248, 20);
    this.dtBankFeesAccount.TabIndex = 39;
    this.dtBankFeesAccount.UseCheckedStateSelectionOverride = false;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeTransactionDate.Appearance = (AppearanceBase) appearance3;
    appearance4.AlphaLevel = (short) 14;
    appearance4.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance4.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance4.BackColorAlpha = (Alpha) 2;
    appearance4.BackGradientAlignment = (GradientAlignment) 4;
    appearance4.BackGradientStyle = (GradientStyle) 5;
    appearance4.BorderAlpha = (Alpha) 1;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    appearance4.ForeColor = Color.FromArgb(49, 85, 153);
    appearance4.ForegroundAlpha = (Alpha) 2;
    this.dateTimeTransactionDate.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dateTimeTransactionDate).Location = new Point(344, 200);
    this.dateTimeTransactionDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeTransactionDate).Name = "dateTimeTransactionDate";
    ((Control) this.dateTimeTransactionDate).Size = new Size(144 /*0x90*/, 20);
    ((Control) this.dateTimeTransactionDate).TabIndex = 45;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTransactionAmount).Appearance = (AppearanceBase) appearance5;
    ((Control) this.txtTransactionAmount).Location = new Point(344, 168);
    this.txtTransactionAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTransactionAmount).Name = "txtTransactionAmount";
    ((Control) this.txtTransactionAmount).Size = new Size(248, 20);
    ((Control) this.txtTransactionAmount).TabIndex = 43;
    this.comboDebitCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDebitCostCenter.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboDebitCostCenter).DisplayMember = "Name";
    this.comboDebitCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDebitCostCenter).Location = new Point(344, 104);
    this.comboDebitCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDebitCostCenter).Name = "comboDebitCostCenter";
    ((Control) this.comboDebitCostCenter).Size = new Size(248, 20);
    ((Control) this.comboDebitCostCenter).TabIndex = 41;
    ((UltraDropDownBase) this.comboDebitCostCenter).ValueMember = "CostCenterID";
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(208 /*0xD0*/, 104);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(96 /*0x60*/, 17);
    this.Label9.TabIndex = 40;
    this.Label9.Text = "Debit Cost Center:";
    this.Label9.TextAlign = ContentAlignment.MiddleLeft;
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(208 /*0xD0*/, 72);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(86, 17);
    this.Label6.TabIndex = 38;
    this.Label6.Text = "Ledger Account:";
    this.Label6.TextAlign = ContentAlignment.MiddleLeft;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(208 /*0xD0*/, 40);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(60, 17);
    this.Label4.TabIndex = 36;
    this.Label4.Text = "Account #:";
    this.Label4.TextAlign = ContentAlignment.MiddleLeft;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(208 /*0xD0*/, 168);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(109, 17);
    this.Label3.TabIndex = 42;
    this.Label3.Text = "Transaction Amount:";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.Location = new Point(208 /*0xD0*/, 200);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(93, 17);
    this.Label2.TabIndex = 44;
    this.Label2.Text = "Transaction Date:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(208 /*0xD0*/, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(65, 17);
    this.Label1.TabIndex = 34;
    this.Label1.Text = "Bank Name:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.lblBankAccountNumber.Location = new Point(344, 40);
    this.lblBankAccountNumber.Name = "lblBankAccountNumber";
    this.lblBankAccountNumber.Size = new Size(248, 16 /*0x10*/);
    this.lblBankAccountNumber.TabIndex = 37;
    this.lblBankAccountNumber.TextAlign = ContentAlignment.MiddleLeft;
    this.lblBankName.Location = new Point(344, 8);
    this.lblBankName.Name = "lblBankName";
    this.lblBankName.Size = new Size(248, 16 /*0x10*/);
    this.lblBankName.TabIndex = 35;
    this.lblBankName.TextAlign = ContentAlignment.MiddleLeft;
    this.Panel4.Controls.Add((Control) this.UltraLabel1);
    this.Panel4.Controls.Add((Control) this.UltraLabel2);
    this.Panel4.Controls.Add((Control) this.lblSideBar);
    this.Panel4.Dock = DockStyle.Left;
    this.Panel4.Location = new Point(0, 0);
    this.Panel4.Name = "Panel4";
    this.Panel4.Size = new Size(200, 232);
    this.Panel4.TabIndex = 33;
    appearance6.BackColor = Color.White;
    appearance6.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.BackGradientAlignment = (GradientAlignment) 3;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.ForeColor = Color.DimGray;
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance6;
    ((ControlBase) this.UltraLabel1).BackColor = Color.White;
    ((Control) this.UltraLabel1).Font = new Font("Arial", 8f);
    ((ControlBase) this.UltraLabel1).ForeColor = Color.Black;
    ((Control) this.UltraLabel1).Location = new Point(8, 24);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(184, 104);
    ((Control) this.UltraLabel1).TabIndex = 214;
    ((ControlBase) this.UltraLabel1).Text = "Use this screen to enter adjustments made by your bank. Select the offsetting ledger account, transaction amount and transaction date. You should also assign bank adjustments to a cost center by selecting one from the drop-down box.";
    appearance7.BackColor = Color.White;
    appearance7.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.BackGradientAlignment = (GradientAlignment) 3;
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.ForeColor = Color.DimGray;
    ((ControlBase) this.UltraLabel2).Appearance = (AppearanceBase) appearance7;
    ((AutoSizeControlBase) this.UltraLabel2).AutoSize = true;
    ((ControlBase) this.UltraLabel2).BackColor = Color.White;
    ((Control) this.UltraLabel2).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((ControlBase) this.UltraLabel2).ForeColor = Color.Black;
    ((Control) this.UltraLabel2).Location = new Point(8, 8);
    ((Control) this.UltraLabel2).Name = "UltraLabel2";
    ((Control) this.UltraLabel2).Size = new Size(120, 15);
    ((Control) this.UltraLabel2).TabIndex = 213;
    ((ControlBase) this.UltraLabel2).Text = "BANK ADJUSTMENTS";
    appearance8.BackColor = Color.White;
    appearance8.BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance8.BackGradientAlignment = (GradientAlignment) 3;
    appearance8.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.lblSideBar).Appearance = (AppearanceBase) appearance8;
    ((ControlBase) this.lblSideBar).BackColor = Color.White;
    this.lblSideBar.BorderStyleOuter = (UIElementBorderStyle) 1;
    ((Control) this.lblSideBar).Dock = DockStyle.Fill;
    ((Control) this.lblSideBar).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.lblSideBar).ForeColor = Color.Black;
    ((Control) this.lblSideBar).Location = new Point(0, 0);
    ((Control) this.lblSideBar).Name = "lblSideBar";
    ((Control) this.lblSideBar).Size = new Size(200, 232);
    ((Control) this.lblSideBar).TabIndex = 212;
    this.Panel3.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Panel3.Controls.Add((Control) this.btnSave);
    this.Panel3.Controls.Add((Control) this.btnCancel);
    this.Panel3.Dock = DockStyle.Bottom;
    this.Panel3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Panel3.Location = new Point(0, 232);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(609, 40);
    this.Panel3.TabIndex = 32 /*0x20*/;
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance9.BackColor = Color.FromArgb(248, 248, 248);
    appearance9.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.DarkGray;
    appearance9.ImageHAlign = (HAlign) 2;
    appearance9.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance9;
    ((Control) this.btnSave).Location = new Point(408, 8);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(88, 24);
    ((Control) this.btnSave).TabIndex = 4;
    ((ControlBase) this.btnSave).Text = "Save";
    ((Control) this.btnCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance10.BackColor = Color.FromArgb(248, 248, 248);
    appearance10.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.BorderColor = Color.DarkGray;
    appearance10.ImageHAlign = (HAlign) 2;
    appearance10.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance10;
    ((UltraButtonBase) this.btnCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.btnCancel).Location = new Point(504, 8);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(88, 24);
    ((Control) this.btnCancel).TabIndex = 5;
    ((ControlBase) this.btnCancel).Text = "Cancel";
    this.AcceptButton = (IButtonControl) this.btnSave;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.btnCancel;
    this.ClientSize = new Size(610, 352);
    this.ControlBox = false;
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.ultraLabel7);
    this.Controls.Add((Control) this.ultraLabel9);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Panel1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedSingle;
    this.Name = nameof (frmBankAdjustments);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Bank Adjustments / Transactions";
    this.Panel1.ResumeLayout(false);
    this.Panel2.ResumeLayout(false);
    ((ISupportInitialize) this.comboCreditCostCenter).EndInit();
    ((ISupportInitialize) this.dateTimeTransactionDate).EndInit();
    ((ISupportInitialize) this.txtTransactionAmount).EndInit();
    ((ISupportInitialize) this.comboDebitCostCenter).EndInit();
    this.Panel4.ResumeLayout(false);
    this.Panel3.ResumeLayout(false);
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    this.ResumeLayout(false);
  }

  private void frmBankAdjustments_Load(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{202B7580-2D2C-4d24-9C9C-9DF92A97EFC4}"))
    {
      Utility.DenyAccess();
      this.BeginInvoke((Delegate) new MethodInvoker(((Form) this).Close));
    }
    else
    {
      this.lblBankName.Text = this._bankName;
      this.lblBankAccountNumber.Text = this._bankAcctNumber;
      this.LoadCostCenters();
      switch (this._adjustmentType)
      {
        case BankingTransactionType.BankFees:
          ExtendedTreeViewDropDown dtBankFeesAccount1 = this.dtBankFeesAccount;
          dtBankFeesAccount1.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.None;
          dtBankFeesAccount1.ShowEquityAccounts = false;
          dtBankFeesAccount1.ShowExpenseAccounts = true;
          dtBankFeesAccount1.ShowIncomeAccounts = false;
          dtBankFeesAccount1.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.None;
          dtBankFeesAccount1.ShowSystemDefinedAccounts = true;
          dtBankFeesAccount1.LoadGLAccounts(this._glcompanyid);
          this.LoadBankFeesAccount();
          break;
        case BankingTransactionType.BankInterest:
          ExtendedTreeViewDropDown dtBankFeesAccount2 = this.dtBankFeesAccount;
          dtBankFeesAccount2.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.None;
          dtBankFeesAccount2.ShowEquityAccounts = false;
          dtBankFeesAccount2.ShowExpenseAccounts = false;
          dtBankFeesAccount2.ShowIncomeAccounts = true;
          dtBankFeesAccount2.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.None;
          dtBankFeesAccount2.ShowSystemDefinedAccounts = false;
          dtBankFeesAccount2.LoadGLAccounts(this._glcompanyid);
          this.LoadBankInterestAccount();
          break;
      }
    }
  }

  private bool VerifyForm()
  {
    bool flag;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.txtTransactionAmount).Text, "", false) == 0 || !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtTransactionAmount).Text))
    {
      int num = (int) MessageBox.Show("You must enter a valid numeric starting balance to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (!Information.IsDate(RuntimeHelpers.GetObjectValue(this.dateTimeTransactionDate.Value)))
    {
      int num = (int) MessageBox.Show("You must select a valid transaction balance date to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (this.dtBankFeesAccount.SelectedNodeCount == 0 || this.dtBankFeesAccount.GLAccountID == -1)
    {
      int num = (int) MessageBox.Show("You must select a ledger account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboCreditCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a credit cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else if (((UltraDropDownBase) this.comboDebitCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a debit cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void SaveTransaction()
  {
    int creditCostCenter = int.Parse(this.comboCreditCostCenter.Value.ToString());
    int debitCostCenter = int.Parse(this.comboDebitCostCenter.Value.ToString());
    switch (this._adjustmentType)
    {
      case BankingTransactionType.BankFees:
        BankingServices.PostBankFees(this._bankGLAcct, this.dtBankFeesAccount.GLAccountID, Conversions.ToDecimal(((TextEditorControlBase) this.txtTransactionAmount).Text), this.dateTimeTransactionDate.DateTime, debitCostCenter, creditCostCenter);
        break;
      case BankingTransactionType.BankInterest:
        BankingServices.PostBankInterestIncome(this._bankGLAcct, this.dtBankFeesAccount.GLAccountID, Conversions.ToDecimal(((TextEditorControlBase) this.txtTransactionAmount).Text), this.dateTimeTransactionDate.DateTime, debitCostCenter, creditCostCenter);
        break;
    }
  }

  private void LoadBankFeesAccount()
  {
    this._bankFeesGLAcct = BankingServices.GetBankFeesAccount(this._bankGLAcct);
    if (this._bankFeesGLAcct == -1)
      return;
    this.dtBankFeesAccount.SetSelectedNodeByKey(this._bankFeesGLAcct.ToString());
  }

  private void LoadBankInterestAccount()
  {
    this._bankInterestGLAcct = BankingServices.GetBankInterestAccount(this._bankGLAcct);
    if (this._bankInterestGLAcct == -1)
      return;
    this.dtBankFeesAccount.SetSelectedNodeByKey(this._bankInterestGLAcct.ToString());
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    this.SaveTransaction();
    this.DialogResult = DialogResult.OK;
  }

  private void LoadCostCenters()
  {
    DataSet dataSet = new DataSet();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetCostCentersList", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    try
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) this._glcompanyid);
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

  private void txtTransactionAmount_Validating(object sender, CancelEventArgs e)
  {
    if (((TextEditorControlBase) this.txtTransactionAmount).Text.Trim().Equals(string.Empty))
      return;
    if (Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtTransactionAmount).Text))
    {
      ((TextEditorControlBase) this.txtTransactionAmount).Text = Strings.Format((object) ((TextEditorControlBase) this.txtTransactionAmount).Text, "Currency");
    }
    else
    {
      int num = (int) MessageBox.Show("Transfer amount must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
  }

  private void frmBankAdjustments_Resize(object sender, EventArgs e) => this.Refresh();
}
