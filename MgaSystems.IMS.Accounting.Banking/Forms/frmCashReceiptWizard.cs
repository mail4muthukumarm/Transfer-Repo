// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmCashReceiptWizard
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.Tools;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

public sealed class frmCashReceiptWizard : Form
{
  private IContainer components;

  public frmCashReceiptWizard() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Panel4")]
  internal virtual Panel Panel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox9")]
  internal virtual PictureBox PictureBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel7")]
  internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox10")]
  internal virtual PictureBox PictureBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel11")]
  internal virtual Panel Panel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnConfirmationBack")]
  internal virtual MGAButton btnConfirmationBack { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnFinish")]
  internal virtual MGAButton btnFinish { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnConfirmationCancel")]
  internal virtual MGAButton btnConfirmationCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox3")]
  internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel12")]
  internal virtual Panel Panel12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox11")]
  internal virtual PictureBox PictureBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  internal virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  internal virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbInvoiceCorrection")]
  internal virtual RadioButton rbInvoiceCorrection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelSourceAccountFooter")]
  internal virtual Panel panelSourceAccountFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  internal virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelSourceAccountHeader")]
  internal virtual Panel panelSourceAccountHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox4")]
  internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox2")]
  internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox6")]
  internal virtual PictureBox PictureBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel5")]
  internal virtual Panel Panel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox7")]
  internal virtual PictureBox PictureBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel6")]
  internal virtual Panel Panel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox8")]
  internal virtual PictureBox PictureBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelStart")]
  internal virtual Panel panelStart { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel9")]
  internal virtual Panel Panel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox5")]
  internal virtual PictureBox PictureBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  internal virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  internal virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel8")]
  internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnStartNext")]
  internal virtual MGAButton btnStartNext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnStartCancel")]
  internal virtual MGAButton btnStartCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  internal virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  internal virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbOwnersEquityCashReceipt")]
  internal virtual RadioButton rbOwnersEquityCashReceipt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelManualGL")]
  internal virtual Panel panelManualGL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnManualGLBack")]
  internal virtual MGAButton btnManualGLBack { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnManualGLNext")]
  internal virtual MGAButton btnManualGLNext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnManualGLCancel")]
  internal virtual MGAButton btnManualGLCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelConfirm")]
  internal virtual Panel panelConfirm { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCashReceiptType")]
  internal virtual Panel panelCashReceiptType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnCashReceiptTypeBack")]
  internal virtual MGAButton btnCashReceiptTypeBack { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnCashReceiptTypeNext")]
  internal virtual MGAButton btnCashReceiptTypeNext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnCashReceiptTypeCancel")]
  internal virtual MGAButton btnCashReceiptTypeCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelInterCompany")]
  internal virtual Panel panelInterCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnInterCopanyBack")]
  internal virtual MGAButton btnInterCopanyBack { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnInterCompanyNext")]
  internal virtual MGAButton btnInterCompanyNext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnInterCompanyCancel")]
  internal virtual MGAButton btnInterCompanyCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelCheckInfo")]
  internal virtual Panel panelCheckInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnCheckInfoBack")]
  internal virtual MGAButton btnCheckInfoBack { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tnCheckInfoNext")]
  internal virtual MGAButton tnCheckInfoNext { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnCheckInfoCancel")]
  internal virtual MGAButton btnCheckInfoCancel { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbManualAccountSelect")]
  internal virtual RadioButton rbManualAccountSelect { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtRemitterName")]
  internal virtual MGATextBox txtRemitterName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnSearchRemitter")]
  internal virtual MGAButton btnSearchRemitter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbOfficeLocation")]
  internal virtual MGASimpleComboBox cmbOfficeLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  internal virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbBankAccount")]
  internal virtual MGASimpleComboBox cmbBankAccount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCheckAmount")]
  internal virtual MGATextBox txtCheckAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  internal virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCheckNumber")]
  internal virtual MGATextBox txtCheckNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  internal virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  internal virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDepositDate")]
  internal virtual MGADateTimePicker dtpDepositDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridInterCompanyTransactions")]
  internal virtual UltraGrid gridInterCompanyTransactions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("etvInterCompanyGL")]
  internal virtual ExtendedTreeViewDropDown etvInterCompanyGL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("etvManualGL")]
  internal virtual ExtendedTreeViewDropDown etvManualGL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label29")]
  internal virtual Label Label29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (frmCashReceiptWizard));
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
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    this.panelManualGL = new Panel();
    this.etvManualGL = new ExtendedTreeViewDropDown();
    this.Label29 = new Label();
    this.Panel4 = new Panel();
    this.btnManualGLBack = new MGAButton();
    this.btnManualGLNext = new MGAButton();
    this.btnManualGLCancel = new MGAButton();
    this.PictureBox9 = new PictureBox();
    this.Panel7 = new Panel();
    this.PictureBox10 = new PictureBox();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.panelConfirm = new Panel();
    this.Panel11 = new Panel();
    this.btnConfirmationBack = new MGAButton();
    this.btnFinish = new MGAButton();
    this.btnConfirmationCancel = new MGAButton();
    this.PictureBox3 = new PictureBox();
    this.Panel12 = new Panel();
    this.PictureBox11 = new PictureBox();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.panelCashReceiptType = new Panel();
    this.rbManualAccountSelect = new RadioButton();
    this.rbInvoiceCorrection = new RadioButton();
    this.rbOwnersEquityCashReceipt = new RadioButton();
    this.panelSourceAccountFooter = new Panel();
    this.btnCashReceiptTypeBack = new MGAButton();
    this.btnCashReceiptTypeNext = new MGAButton();
    this.btnCashReceiptTypeCancel = new MGAButton();
    this.PictureBox1 = new PictureBox();
    this.panelSourceAccountHeader = new Panel();
    this.PictureBox4 = new PictureBox();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.panelInterCompany = new Panel();
    this.Label6 = new Label();
    this.etvInterCompanyGL = new ExtendedTreeViewDropDown();
    this.Label5 = new Label();
    this.gridInterCompanyTransactions = new UltraGrid();
    this.Panel2 = new Panel();
    this.btnInterCopanyBack = new MGAButton();
    this.btnInterCompanyNext = new MGAButton();
    this.btnInterCompanyCancel = new MGAButton();
    this.PictureBox2 = new PictureBox();
    this.Panel3 = new Panel();
    this.PictureBox6 = new PictureBox();
    this.Label1 = new Label();
    this.Label4 = new Label();
    this.panelCheckInfo = new Panel();
    this.dtpDepositDate = new MGADateTimePicker();
    this.Label27 = new Label();
    this.txtCheckNumber = new MGATextBox();
    this.Label26 = new Label();
    this.txtCheckAmount = new MGATextBox();
    this.Label25 = new Label();
    this.cmbBankAccount = new MGASimpleComboBox();
    this.Label22 = new Label();
    this.cmbOfficeLocation = new MGASimpleComboBox();
    this.Label7 = new Label();
    this.btnSearchRemitter = new MGAButton();
    this.txtRemitterName = new MGATextBox();
    this.Label8 = new Label();
    this.Panel5 = new Panel();
    this.btnCheckInfoBack = new MGAButton();
    this.tnCheckInfoNext = new MGAButton();
    this.btnCheckInfoCancel = new MGAButton();
    this.PictureBox7 = new PictureBox();
    this.Panel6 = new Panel();
    this.PictureBox8 = new PictureBox();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.panelStart = new Panel();
    this.Panel9 = new Panel();
    this.PictureBox5 = new PictureBox();
    this.Label20 = new Label();
    this.Label19 = new Label();
    this.Panel8 = new Panel();
    this.btnStartNext = new MGAButton();
    this.btnStartCancel = new MGAButton();
    this.Label24 = new Label();
    this.Label23 = new Label();
    this.panelManualGL.SuspendLayout();
    this.Panel4.SuspendLayout();
    ((ISupportInitialize) this.btnManualGLBack).BeginInit();
    ((ISupportInitialize) this.btnManualGLNext).BeginInit();
    ((ISupportInitialize) this.btnManualGLCancel).BeginInit();
    this.Panel7.SuspendLayout();
    this.panelConfirm.SuspendLayout();
    this.Panel11.SuspendLayout();
    ((ISupportInitialize) this.btnConfirmationBack).BeginInit();
    ((ISupportInitialize) this.btnFinish).BeginInit();
    ((ISupportInitialize) this.btnConfirmationCancel).BeginInit();
    this.Panel12.SuspendLayout();
    this.panelCashReceiptType.SuspendLayout();
    this.panelSourceAccountFooter.SuspendLayout();
    ((ISupportInitialize) this.btnCashReceiptTypeBack).BeginInit();
    ((ISupportInitialize) this.btnCashReceiptTypeNext).BeginInit();
    ((ISupportInitialize) this.btnCashReceiptTypeCancel).BeginInit();
    this.panelSourceAccountHeader.SuspendLayout();
    this.panelInterCompany.SuspendLayout();
    ((ISupportInitialize) this.gridInterCompanyTransactions).BeginInit();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.btnInterCopanyBack).BeginInit();
    ((ISupportInitialize) this.btnInterCompanyNext).BeginInit();
    ((ISupportInitialize) this.btnInterCompanyCancel).BeginInit();
    this.Panel3.SuspendLayout();
    this.panelCheckInfo.SuspendLayout();
    ((ISupportInitialize) this.dtpDepositDate).BeginInit();
    ((ISupportInitialize) this.txtCheckNumber).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount).BeginInit();
    ((ISupportInitialize) this.cmbBankAccount).BeginInit();
    ((ISupportInitialize) this.cmbOfficeLocation).BeginInit();
    ((ISupportInitialize) this.btnSearchRemitter).BeginInit();
    ((ISupportInitialize) this.txtRemitterName).BeginInit();
    this.Panel5.SuspendLayout();
    ((ISupportInitialize) this.btnCheckInfoBack).BeginInit();
    ((ISupportInitialize) this.tnCheckInfoNext).BeginInit();
    ((ISupportInitialize) this.btnCheckInfoCancel).BeginInit();
    this.Panel6.SuspendLayout();
    this.panelStart.SuspendLayout();
    this.Panel9.SuspendLayout();
    this.Panel8.SuspendLayout();
    ((ISupportInitialize) this.btnStartNext).BeginInit();
    ((ISupportInitialize) this.btnStartCancel).BeginInit();
    this.SuspendLayout();
    this.panelManualGL.BackColor = Color.White;
    this.panelManualGL.Controls.Add((Control) this.etvManualGL);
    this.panelManualGL.Controls.Add((Control) this.Label29);
    this.panelManualGL.Controls.Add((Control) this.Panel4);
    this.panelManualGL.Controls.Add((Control) this.Panel7);
    this.panelManualGL.Location = new Point(0, 0);
    this.panelManualGL.Name = "panelManualGL";
    this.panelManualGL.Size = new Size(674, 336);
    this.panelManualGL.TabIndex = 4;
    this.panelManualGL.Visible = false;
    this.etvManualGL.DropDownHeight = 250;
    this.etvManualGL.DropDownWidth = 325;
    this.etvManualGL.Enabled = false;
    this.etvManualGL.Location = new Point(200, 160 /*0xA0*/);
    this.etvManualGL.Name = "etvManualGL";
    this.etvManualGL.ShortNamesCollection.Add((object) "A/PC");
    this.etvManualGL.ShortNamesCollection.Add((object) "MCI");
    this.etvManualGL.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.AR;
    this.etvManualGL.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.None;
    this.etvManualGL.Size = new Size(256 /*0x0100*/, 24);
    this.etvManualGL.TabIndex = 2;
    this.etvManualGL.UseCheckedStateSelectionOverride = false;
    this.Label29.AutoSize = true;
    this.Label29.ForeColor = Color.DimGray;
    this.Label29.Location = new Point(200, 144 /*0x90*/);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(65, 17);
    this.Label29.TabIndex = 1;
    this.Label29.Text = "GL Account:";
    this.Panel4.Controls.Add((Control) this.btnManualGLBack);
    this.Panel4.Controls.Add((Control) this.btnManualGLNext);
    this.Panel4.Controls.Add((Control) this.btnManualGLCancel);
    this.Panel4.Controls.Add((Control) this.PictureBox9);
    this.Panel4.Dock = DockStyle.Bottom;
    this.Panel4.Location = new Point(0, 296);
    this.Panel4.Name = "Panel4";
    this.Panel4.Size = new Size(674, 40);
    this.Panel4.TabIndex = 3;
    ((Control) this.btnManualGLBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance1.BackColor = Color.Gainsboro;
    appearance1.BackColor2 = Color.White;
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.Gray;
    ((ControlBase) this.btnManualGLBack).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnManualGLBack).Location = new Point(376, 8);
    ((Control) this.btnManualGLBack).Name = "btnManualGLBack";
    ((Control) this.btnManualGLBack).Size = new Size(100, 24);
    ((Control) this.btnManualGLBack).TabIndex = 0;
    ((ControlBase) this.btnManualGLBack).Text = "< &Back";
    ((Control) this.btnManualGLNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    ((ControlBase) this.btnManualGLNext).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnManualGLNext).Location = new Point(480, 8);
    ((Control) this.btnManualGLNext).Name = "btnManualGLNext";
    ((Control) this.btnManualGLNext).Size = new Size(100, 24);
    ((Control) this.btnManualGLNext).TabIndex = 1;
    ((ControlBase) this.btnManualGLNext).Text = "&Next >";
    ((Control) this.btnManualGLCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.Gray;
    ((ControlBase) this.btnManualGLCancel).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnManualGLCancel).Location = new Point(592, 8);
    ((Control) this.btnManualGLCancel).Name = "btnManualGLCancel";
    ((Control) this.btnManualGLCancel).Size = new Size(75, 24);
    ((Control) this.btnManualGLCancel).TabIndex = 2;
    ((ControlBase) this.btnManualGLCancel).Text = "&Cancel";
    this.PictureBox9.Dock = DockStyle.Fill;
    this.PictureBox9.Image = (Image) resourceManager.GetObject("PictureBox9.Image");
    this.PictureBox9.Location = new Point(0, 0);
    this.PictureBox9.Name = "PictureBox9";
    this.PictureBox9.Size = new Size(674, 40);
    this.PictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox9.TabIndex = 3;
    this.PictureBox9.TabStop = false;
    this.Panel7.BackColor = Color.Transparent;
    this.Panel7.BackgroundImage = (Image) resourceManager.GetObject("Panel7.BackgroundImage");
    this.Panel7.Controls.Add((Control) this.PictureBox10);
    this.Panel7.Controls.Add((Control) this.Label13);
    this.Panel7.Controls.Add((Control) this.Label14);
    this.Panel7.Dock = DockStyle.Top;
    this.Panel7.Location = new Point(0, 0);
    this.Panel7.Name = "Panel7";
    this.Panel7.Size = new Size(674, 80 /*0x50*/);
    this.Panel7.TabIndex = 0;
    this.PictureBox10.Image = (Image) resourceManager.GetObject("PictureBox10.Image");
    this.PictureBox10.Location = new Point(600, 8);
    this.PictureBox10.Name = "PictureBox10";
    this.PictureBox10.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox10.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox10.TabIndex = 3;
    this.PictureBox10.TabStop = false;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.ForeColor = Color.White;
    this.Label13.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(552, 32 /*0x20*/);
    this.Label13.TabIndex = 1;
    this.Label13.Text = "Please select the general ledger account you would like to apply this cash receipt to.";
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.White;
    this.Label14.Location = new Point(16 /*0x10*/, 0);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(431, 26);
    this.Label14.TabIndex = 0;
    this.Label14.Text = "Cash Receipt - Manual GL Account Selection";
    this.panelConfirm.BackColor = Color.White;
    this.panelConfirm.Controls.Add((Control) this.Panel11);
    this.panelConfirm.Controls.Add((Control) this.Panel12);
    this.panelConfirm.Location = new Point(0, 0);
    this.panelConfirm.Name = "panelConfirm";
    this.panelConfirm.Size = new Size(674, 336);
    this.panelConfirm.TabIndex = 5;
    this.panelConfirm.Visible = false;
    this.Panel11.Controls.Add((Control) this.btnConfirmationBack);
    this.Panel11.Controls.Add((Control) this.btnFinish);
    this.Panel11.Controls.Add((Control) this.btnConfirmationCancel);
    this.Panel11.Controls.Add((Control) this.PictureBox3);
    this.Panel11.Dock = DockStyle.Bottom;
    this.Panel11.Location = new Point(0, 296);
    this.Panel11.Name = "Panel11";
    this.Panel11.Size = new Size(674, 40);
    this.Panel11.TabIndex = 0;
    ((Control) this.btnConfirmationBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.Gray;
    ((ControlBase) this.btnConfirmationBack).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnConfirmationBack).Location = new Point(376, 8);
    ((Control) this.btnConfirmationBack).Name = "btnConfirmationBack";
    ((Control) this.btnConfirmationBack).Size = new Size(100, 24);
    ((Control) this.btnConfirmationBack).TabIndex = 0;
    ((ControlBase) this.btnConfirmationBack).Text = "< &Back";
    ((Control) this.btnFinish).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance5.BackColor = Color.Gainsboro;
    appearance5.BackColor2 = Color.White;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.Gray;
    ((ControlBase) this.btnFinish).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnFinish).Location = new Point(480, 8);
    ((Control) this.btnFinish).Name = "btnFinish";
    ((Control) this.btnFinish).Size = new Size(100, 24);
    ((Control) this.btnFinish).TabIndex = 1;
    ((ControlBase) this.btnFinish).Text = "&Finish";
    ((Control) this.btnConfirmationCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance6.BackColor = Color.Gainsboro;
    appearance6.BackColor2 = Color.White;
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.Gray;
    ((ControlBase) this.btnConfirmationCancel).Appearance = (AppearanceBase) appearance6;
    ((Control) this.btnConfirmationCancel).Location = new Point(592, 8);
    ((Control) this.btnConfirmationCancel).Name = "btnConfirmationCancel";
    ((Control) this.btnConfirmationCancel).Size = new Size(75, 24);
    ((Control) this.btnConfirmationCancel).TabIndex = 2;
    ((ControlBase) this.btnConfirmationCancel).Text = "&Cancel";
    this.PictureBox3.Dock = DockStyle.Fill;
    this.PictureBox3.Image = (Image) resourceManager.GetObject("PictureBox3.Image");
    this.PictureBox3.Location = new Point(0, 0);
    this.PictureBox3.Name = "PictureBox3";
    this.PictureBox3.Size = new Size(674, 40);
    this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox3.TabIndex = 3;
    this.PictureBox3.TabStop = false;
    this.Panel12.BackColor = Color.Transparent;
    this.Panel12.BackgroundImage = (Image) resourceManager.GetObject("Panel12.BackgroundImage");
    this.Panel12.Controls.Add((Control) this.PictureBox11);
    this.Panel12.Controls.Add((Control) this.Label17);
    this.Panel12.Controls.Add((Control) this.Label18);
    this.Panel12.Dock = DockStyle.Top;
    this.Panel12.Location = new Point(0, 0);
    this.Panel12.Name = "Panel12";
    this.Panel12.Size = new Size(674, 80 /*0x50*/);
    this.Panel12.TabIndex = 0;
    this.PictureBox11.Image = (Image) resourceManager.GetObject("PictureBox11.Image");
    this.PictureBox11.Location = new Point(600, 8);
    this.PictureBox11.Name = "PictureBox11";
    this.PictureBox11.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox11.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox11.TabIndex = 3;
    this.PictureBox11.TabStop = false;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.ForeColor = Color.White;
    this.Label17.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(552, 32 /*0x20*/);
    this.Label17.TabIndex = 1;
    this.Label17.Text = "Please review the transaction list. If the transaction is correct, click the 'Finish' button to complete the wizard.";
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label18.ForeColor = Color.White;
    this.Label18.Location = new Point(16 /*0x10*/, 0);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(345, 26);
    this.Label18.TabIndex = 0;
    this.Label18.Text = "Cash Receipt Wizard - Confrmation";
    this.panelCashReceiptType.BackColor = Color.White;
    this.panelCashReceiptType.Controls.Add((Control) this.rbManualAccountSelect);
    this.panelCashReceiptType.Controls.Add((Control) this.rbInvoiceCorrection);
    this.panelCashReceiptType.Controls.Add((Control) this.rbOwnersEquityCashReceipt);
    this.panelCashReceiptType.Controls.Add((Control) this.panelSourceAccountFooter);
    this.panelCashReceiptType.Controls.Add((Control) this.panelSourceAccountHeader);
    this.panelCashReceiptType.Location = new Point(0, 0);
    this.panelCashReceiptType.Name = "panelCashReceiptType";
    this.panelCashReceiptType.Size = new Size(674, 336);
    this.panelCashReceiptType.TabIndex = 1;
    this.panelCashReceiptType.Visible = false;
    this.rbManualAccountSelect.FlatStyle = FlatStyle.Flat;
    this.rbManualAccountSelect.ForeColor = Color.DarkSlateGray;
    this.rbManualAccountSelect.Location = new Point(40, 216);
    this.rbManualAccountSelect.Name = "rbManualAccountSelect";
    this.rbManualAccountSelect.Size = new Size(592, 40);
    this.rbManualAccountSelect.TabIndex = 3;
    this.rbManualAccountSelect.Text = "I would like to manually select the cash receipt offset account from a list.";
    this.rbInvoiceCorrection.FlatStyle = FlatStyle.Flat;
    this.rbInvoiceCorrection.ForeColor = Color.DarkSlateGray;
    this.rbInvoiceCorrection.Location = new Point(40, 176 /*0xB0*/);
    this.rbInvoiceCorrection.Name = "rbInvoiceCorrection";
    this.rbInvoiceCorrection.Size = new Size(592, 40);
    this.rbInvoiceCorrection.TabIndex = 2;
    this.rbInvoiceCorrection.Text = "I am creating a Inter-Company Transfer cash receipt.";
    this.rbOwnersEquityCashReceipt.Checked = true;
    this.rbOwnersEquityCashReceipt.FlatStyle = FlatStyle.Flat;
    this.rbOwnersEquityCashReceipt.ForeColor = Color.DarkSlateGray;
    this.rbOwnersEquityCashReceipt.Location = new Point(40, 136);
    this.rbOwnersEquityCashReceipt.Name = "rbOwnersEquityCashReceipt";
    this.rbOwnersEquityCashReceipt.Size = new Size(592, 40);
    this.rbOwnersEquityCashReceipt.TabIndex = 1;
    this.rbOwnersEquityCashReceipt.TabStop = true;
    this.rbOwnersEquityCashReceipt.Text = "I am creating an Owner's Equity cash receipt.";
    this.panelSourceAccountFooter.Controls.Add((Control) this.btnCashReceiptTypeBack);
    this.panelSourceAccountFooter.Controls.Add((Control) this.btnCashReceiptTypeNext);
    this.panelSourceAccountFooter.Controls.Add((Control) this.btnCashReceiptTypeCancel);
    this.panelSourceAccountFooter.Controls.Add((Control) this.PictureBox1);
    this.panelSourceAccountFooter.Dock = DockStyle.Bottom;
    this.panelSourceAccountFooter.Location = new Point(0, 296);
    this.panelSourceAccountFooter.Name = "panelSourceAccountFooter";
    this.panelSourceAccountFooter.Size = new Size(674, 40);
    this.panelSourceAccountFooter.TabIndex = 4;
    ((Control) this.btnCashReceiptTypeBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance7.BackColor = Color.Gainsboro;
    appearance7.BackColor2 = Color.White;
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.Gray;
    ((ControlBase) this.btnCashReceiptTypeBack).Appearance = (AppearanceBase) appearance7;
    ((Control) this.btnCashReceiptTypeBack).Location = new Point(376, 8);
    ((Control) this.btnCashReceiptTypeBack).Name = "btnCashReceiptTypeBack";
    ((Control) this.btnCashReceiptTypeBack).Size = new Size(100, 24);
    ((Control) this.btnCashReceiptTypeBack).TabIndex = 0;
    ((ControlBase) this.btnCashReceiptTypeBack).Text = "< &Back";
    ((Control) this.btnCashReceiptTypeNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance8.BackColor = Color.Gainsboro;
    appearance8.BackColor2 = Color.White;
    appearance8.BackGradientStyle = (GradientStyle) 2;
    appearance8.BorderColor = Color.Gray;
    ((ControlBase) this.btnCashReceiptTypeNext).Appearance = (AppearanceBase) appearance8;
    ((Control) this.btnCashReceiptTypeNext).Location = new Point(480, 8);
    ((Control) this.btnCashReceiptTypeNext).Name = "btnCashReceiptTypeNext";
    ((Control) this.btnCashReceiptTypeNext).Size = new Size(100, 24);
    ((Control) this.btnCashReceiptTypeNext).TabIndex = 1;
    ((ControlBase) this.btnCashReceiptTypeNext).Text = "&Next >";
    ((Control) this.btnCashReceiptTypeCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance9.BackColor = Color.Gainsboro;
    appearance9.BackColor2 = Color.White;
    appearance9.BackGradientStyle = (GradientStyle) 2;
    appearance9.BorderColor = Color.Gray;
    ((ControlBase) this.btnCashReceiptTypeCancel).Appearance = (AppearanceBase) appearance9;
    ((Control) this.btnCashReceiptTypeCancel).Location = new Point(592, 8);
    ((Control) this.btnCashReceiptTypeCancel).Name = "btnCashReceiptTypeCancel";
    ((Control) this.btnCashReceiptTypeCancel).Size = new Size(75, 24);
    ((Control) this.btnCashReceiptTypeCancel).TabIndex = 2;
    ((ControlBase) this.btnCashReceiptTypeCancel).Text = "&Cancel";
    this.PictureBox1.Dock = DockStyle.Fill;
    this.PictureBox1.Image = (Image) resourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(0, 0);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(674, 40);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox1.TabIndex = 3;
    this.PictureBox1.TabStop = false;
    this.panelSourceAccountHeader.BackColor = Color.Transparent;
    this.panelSourceAccountHeader.BackgroundImage = (Image) resourceManager.GetObject("panelSourceAccountHeader.BackgroundImage");
    this.panelSourceAccountHeader.Controls.Add((Control) this.PictureBox4);
    this.panelSourceAccountHeader.Controls.Add((Control) this.Label3);
    this.panelSourceAccountHeader.Controls.Add((Control) this.Label2);
    this.panelSourceAccountHeader.Dock = DockStyle.Top;
    this.panelSourceAccountHeader.Location = new Point(0, 0);
    this.panelSourceAccountHeader.Name = "panelSourceAccountHeader";
    this.panelSourceAccountHeader.Size = new Size(674, 80 /*0x50*/);
    this.panelSourceAccountHeader.TabIndex = 0;
    this.PictureBox4.Image = (Image) resourceManager.GetObject("PictureBox4.Image");
    this.PictureBox4.Location = new Point(592, 8);
    this.PictureBox4.Name = "PictureBox4";
    this.PictureBox4.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox4.TabIndex = 2;
    this.PictureBox4.TabStop = false;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.ForeColor = Color.White;
    this.Label3.Location = new Point(16 /*0x10*/, 40);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(309, 17);
    this.Label3.TabIndex = 1;
    this.Label3.Text = "Please specify the type of cash receipt entry you are making.";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.White;
    this.Label2.Location = new Point(16 /*0x10*/, 0);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(184, 26);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Cash Receipt Type";
    this.panelInterCompany.BackColor = Color.White;
    this.panelInterCompany.Controls.Add((Control) this.Label6);
    this.panelInterCompany.Controls.Add((Control) this.etvInterCompanyGL);
    this.panelInterCompany.Controls.Add((Control) this.Label5);
    this.panelInterCompany.Controls.Add((Control) this.gridInterCompanyTransactions);
    this.panelInterCompany.Controls.Add((Control) this.Panel2);
    this.panelInterCompany.Controls.Add((Control) this.Panel3);
    this.panelInterCompany.Location = new Point(0, 0);
    this.panelInterCompany.Name = "panelInterCompany";
    this.panelInterCompany.Size = new Size(674, 336);
    this.panelInterCompany.TabIndex = 3;
    this.panelInterCompany.Visible = false;
    this.Label6.AutoSize = true;
    this.Label6.ForeColor = Color.DimGray;
    this.Label6.Location = new Point(120, 136);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(67, 17);
    this.Label6.TabIndex = 3;
    this.Label6.Text = "Transactions";
    this.etvInterCompanyGL.DropDownHeight = 250;
    this.etvInterCompanyGL.DropDownWidth = 325;
    this.etvInterCompanyGL.Enabled = false;
    this.etvInterCompanyGL.Location = new Point(120, 104);
    this.etvInterCompanyGL.Name = "etvInterCompanyGL";
    this.etvInterCompanyGL.ShortNamesCollection.Add((object) "A/PC");
    this.etvInterCompanyGL.ShortNamesCollection.Add((object) "MCI");
    this.etvInterCompanyGL.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.AR;
    this.etvInterCompanyGL.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.None;
    this.etvInterCompanyGL.Size = new Size(256 /*0x0100*/, 24);
    this.etvInterCompanyGL.TabIndex = 2;
    this.etvInterCompanyGL.UseCheckedStateSelectionOverride = false;
    this.Label5.AutoSize = true;
    this.Label5.ForeColor = Color.DimGray;
    this.Label5.Location = new Point(120, 88);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(123, 17);
    this.Label5.TabIndex = 1;
    this.Label5.Text = "Inter-Company Account";
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.Gray;
    ((UltraGridBase) this.gridInterCompanyTransactions).DisplayLayout.Appearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridInterCompanyTransactions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((Control) this.gridInterCompanyTransactions).Location = new Point(128 /*0x80*/, 160 /*0xA0*/);
    ((Control) this.gridInterCompanyTransactions).Name = "gridInterCompanyTransactions";
    ((Control) this.gridInterCompanyTransactions).Size = new Size(400, 128 /*0x80*/);
    ((Control) this.gridInterCompanyTransactions).TabIndex = 4;
    this.Panel2.Controls.Add((Control) this.btnInterCopanyBack);
    this.Panel2.Controls.Add((Control) this.btnInterCompanyNext);
    this.Panel2.Controls.Add((Control) this.btnInterCompanyCancel);
    this.Panel2.Controls.Add((Control) this.PictureBox2);
    this.Panel2.Dock = DockStyle.Bottom;
    this.Panel2.Location = new Point(0, 296);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(674, 40);
    this.Panel2.TabIndex = 5;
    ((Control) this.btnInterCopanyBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance11.BackColor = Color.Gainsboro;
    appearance11.BackColor2 = Color.White;
    appearance11.BackGradientStyle = (GradientStyle) 2;
    appearance11.BorderColor = Color.Gray;
    ((ControlBase) this.btnInterCopanyBack).Appearance = (AppearanceBase) appearance11;
    ((Control) this.btnInterCopanyBack).Location = new Point(376, 8);
    ((Control) this.btnInterCopanyBack).Name = "btnInterCopanyBack";
    ((Control) this.btnInterCopanyBack).Size = new Size(100, 24);
    ((Control) this.btnInterCopanyBack).TabIndex = 0;
    ((ControlBase) this.btnInterCopanyBack).Text = "< &Back";
    ((Control) this.btnInterCompanyNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance12.BackColor = Color.Gainsboro;
    appearance12.BackColor2 = Color.White;
    appearance12.BackGradientStyle = (GradientStyle) 2;
    appearance12.BorderColor = Color.Gray;
    ((ControlBase) this.btnInterCompanyNext).Appearance = (AppearanceBase) appearance12;
    ((Control) this.btnInterCompanyNext).Location = new Point(480, 8);
    ((Control) this.btnInterCompanyNext).Name = "btnInterCompanyNext";
    ((Control) this.btnInterCompanyNext).Size = new Size(100, 24);
    ((Control) this.btnInterCompanyNext).TabIndex = 1;
    ((ControlBase) this.btnInterCompanyNext).Text = "&Next >";
    ((Control) this.btnInterCompanyCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance13.BackColor = Color.Gainsboro;
    appearance13.BackColor2 = Color.White;
    appearance13.BackGradientStyle = (GradientStyle) 2;
    appearance13.BorderColor = Color.Gray;
    ((ControlBase) this.btnInterCompanyCancel).Appearance = (AppearanceBase) appearance13;
    ((Control) this.btnInterCompanyCancel).Location = new Point(592, 8);
    ((Control) this.btnInterCompanyCancel).Name = "btnInterCompanyCancel";
    ((Control) this.btnInterCompanyCancel).Size = new Size(75, 24);
    ((Control) this.btnInterCompanyCancel).TabIndex = 2;
    ((ControlBase) this.btnInterCompanyCancel).Text = "&Cancel";
    this.PictureBox2.Dock = DockStyle.Fill;
    this.PictureBox2.Image = (Image) resourceManager.GetObject("PictureBox2.Image");
    this.PictureBox2.Location = new Point(0, 0);
    this.PictureBox2.Name = "PictureBox2";
    this.PictureBox2.Size = new Size(674, 40);
    this.PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox2.TabIndex = 3;
    this.PictureBox2.TabStop = false;
    this.Panel3.BackColor = Color.Transparent;
    this.Panel3.BackgroundImage = (Image) resourceManager.GetObject("Panel3.BackgroundImage");
    this.Panel3.Controls.Add((Control) this.PictureBox6);
    this.Panel3.Controls.Add((Control) this.Label1);
    this.Panel3.Controls.Add((Control) this.Label4);
    this.Panel3.Dock = DockStyle.Top;
    this.Panel3.Location = new Point(0, 0);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(674, 80 /*0x50*/);
    this.Panel3.TabIndex = 0;
    this.PictureBox6.Image = (Image) resourceManager.GetObject("PictureBox6.Image");
    this.PictureBox6.Location = new Point(600, 8);
    this.PictureBox6.Name = "PictureBox6";
    this.PictureBox6.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox6.TabIndex = 3;
    this.PictureBox6.TabStop = false;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.ForeColor = Color.White;
    this.Label1.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(504, 32 /*0x20*/);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Pleae select the inter-company transfer account you would like to apply this cash receipt to. You can also specify an individual transaction to apply the cash receipt to.";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.White;
    this.Label4.Location = new Point(16 /*0x10*/, 0);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(466, 26);
    this.Label4.TabIndex = 0;
    this.Label4.Text = "Cash Receipt - Inter Company Transfer Account";
    this.panelCheckInfo.BackColor = Color.White;
    this.panelCheckInfo.Controls.Add((Control) this.dtpDepositDate);
    this.panelCheckInfo.Controls.Add((Control) this.Label27);
    this.panelCheckInfo.Controls.Add((Control) this.txtCheckNumber);
    this.panelCheckInfo.Controls.Add((Control) this.Label26);
    this.panelCheckInfo.Controls.Add((Control) this.txtCheckAmount);
    this.panelCheckInfo.Controls.Add((Control) this.Label25);
    this.panelCheckInfo.Controls.Add((Control) this.cmbBankAccount);
    this.panelCheckInfo.Controls.Add((Control) this.Label22);
    this.panelCheckInfo.Controls.Add((Control) this.cmbOfficeLocation);
    this.panelCheckInfo.Controls.Add((Control) this.Label7);
    this.panelCheckInfo.Controls.Add((Control) this.btnSearchRemitter);
    this.panelCheckInfo.Controls.Add((Control) this.txtRemitterName);
    this.panelCheckInfo.Controls.Add((Control) this.Label8);
    this.panelCheckInfo.Controls.Add((Control) this.Panel5);
    this.panelCheckInfo.Controls.Add((Control) this.Panel6);
    this.panelCheckInfo.Location = new Point(0, 0);
    this.panelCheckInfo.Name = "panelCheckInfo";
    this.panelCheckInfo.Size = new Size(674, 336);
    this.panelCheckInfo.TabIndex = 2;
    this.panelCheckInfo.Visible = false;
    appearance14.BorderColor = Color.Gray;
    this.dtpDepositDate.Appearance = (AppearanceBase) appearance14;
    appearance15.BackColor = Color.LightGray;
    appearance15.BackColor2 = Color.White;
    appearance15.BackGradientStyle = (GradientStyle) 2;
    appearance15.BorderColor = Color.LightGray;
    appearance15.ForeColor = Color.FromArgb(60, 60, 60);
    this.dtpDepositDate.ButtonAppearance = (AppearanceBase) appearance15;
    this.dtpDepositDate.FormatString = "D";
    ((Control) this.dtpDepositDate).Location = new Point(352, 224 /*0xE0*/);
    ((Control) this.dtpDepositDate).Name = "dtpDepositDate";
    ((Control) this.dtpDepositDate).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.dtpDepositDate).TabIndex = 13;
    this.Label27.AutoSize = true;
    this.Label27.ForeColor = Color.DimGray;
    this.Label27.Location = new Point(352, 208 /*0xD0*/);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(69, 17);
    this.Label27.TabIndex = 12;
    this.Label27.Text = "Deposit Date";
    appearance16.BackColor = Color.White;
    appearance16.BorderColor = Color.Gray;
    appearance16.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCheckNumber).Appearance = (AppearanceBase) appearance16;
    ((Control) this.txtCheckNumber).Enabled = false;
    ((Control) this.txtCheckNumber).Location = new Point(352, 176 /*0xB0*/);
    ((Control) this.txtCheckNumber).Name = "txtCheckNumber";
    ((EditorButtonControlBase) this.txtCheckNumber).ReadOnly = true;
    ((Control) this.txtCheckNumber).Size = new Size(184, 20);
    ((Control) this.txtCheckNumber).TabIndex = 11;
    ((Control) this.txtCheckNumber).TabStop = false;
    this.Label26.AutoSize = true;
    this.Label26.ForeColor = Color.DimGray;
    this.Label26.Location = new Point(352, 160 /*0xA0*/);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(77, 17);
    this.Label26.TabIndex = 10;
    this.Label26.Text = "Check Number";
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.Gray;
    appearance17.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCheckAmount).Appearance = (AppearanceBase) appearance17;
    ((Control) this.txtCheckAmount).Enabled = false;
    ((Control) this.txtCheckAmount).Location = new Point(352, 128 /*0x80*/);
    ((Control) this.txtCheckAmount).Name = "txtCheckAmount";
    ((EditorButtonControlBase) this.txtCheckAmount).ReadOnly = true;
    ((Control) this.txtCheckAmount).Size = new Size(184, 20);
    ((Control) this.txtCheckAmount).TabIndex = 9;
    ((Control) this.txtCheckAmount).TabStop = false;
    this.Label25.AutoSize = true;
    this.Label25.ForeColor = Color.DimGray;
    this.Label25.Location = new Point(352, 112 /*0x70*/);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(77, 17);
    this.Label25.TabIndex = 8;
    this.Label25.Text = "Check Amount";
    this.cmbBankAccount.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.cmbBankAccount).DisplayMember = "";
    this.cmbBankAccount.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbBankAccount).Location = new Point(48 /*0x30*/, 176 /*0xB0*/);
    ((Control) this.cmbBankAccount).Name = "cmbBankAccount";
    ((Control) this.cmbBankAccount).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.cmbBankAccount).TabIndex = 4;
    ((UltraDropDownBase) this.cmbBankAccount).ValueMember = "";
    this.Label22.AutoSize = true;
    this.Label22.ForeColor = Color.DimGray;
    this.Label22.Location = new Point(48 /*0x30*/, 160 /*0xA0*/);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(72, 17);
    this.Label22.TabIndex = 3;
    this.Label22.Text = "Bank Account";
    this.cmbOfficeLocation.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.cmbOfficeLocation).DisplayMember = "";
    this.cmbOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbOfficeLocation).Location = new Point(48 /*0x30*/, 128 /*0x80*/);
    ((Control) this.cmbOfficeLocation).Name = "cmbOfficeLocation";
    ((Control) this.cmbOfficeLocation).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.cmbOfficeLocation).TabIndex = 2;
    ((UltraDropDownBase) this.cmbOfficeLocation).ValueMember = "";
    this.Label7.AutoSize = true;
    this.Label7.ForeColor = Color.DimGray;
    this.Label7.Location = new Point(48 /*0x30*/, 112 /*0x70*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(79, 17);
    this.Label7.TabIndex = 1;
    this.Label7.Text = "Office Location";
    appearance18.BackColor = Color.Gainsboro;
    appearance18.BackColor2 = Color.White;
    appearance18.BackGradientStyle = (GradientStyle) 2;
    appearance18.BorderColor = Color.Gray;
    appearance18.Image = RuntimeHelpers.GetObjectValue(resourceManager.GetObject("Appearance18.Image"));
    appearance18.ImageHAlign = (HAlign) 2;
    appearance18.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearchRemitter).Appearance = (AppearanceBase) appearance18;
    ((Control) this.btnSearchRemitter).Location = new Point(306, 224 /*0xE0*/);
    ((Control) this.btnSearchRemitter).Name = "btnSearchRemitter";
    ((Control) this.btnSearchRemitter).Size = new Size(20, 20);
    ((Control) this.btnSearchRemitter).TabIndex = 7;
    appearance19.BackColor = Color.White;
    appearance19.BorderColor = Color.Gray;
    appearance19.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtRemitterName).Appearance = (AppearanceBase) appearance19;
    ((Control) this.txtRemitterName).Enabled = false;
    ((Control) this.txtRemitterName).Location = new Point(48 /*0x30*/, 224 /*0xE0*/);
    ((Control) this.txtRemitterName).Name = "txtRemitterName";
    ((EditorButtonControlBase) this.txtRemitterName).ReadOnly = true;
    ((Control) this.txtRemitterName).Size = new Size(256 /*0x0100*/, 20);
    ((Control) this.txtRemitterName).TabIndex = 6;
    ((Control) this.txtRemitterName).TabStop = false;
    this.Label8.AutoSize = true;
    this.Label8.ForeColor = Color.DimGray;
    this.Label8.Location = new Point(48 /*0x30*/, 208 /*0xD0*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(111, 17);
    this.Label8.TabIndex = 5;
    this.Label8.Text = "Check Received From";
    this.Panel5.Controls.Add((Control) this.btnCheckInfoBack);
    this.Panel5.Controls.Add((Control) this.tnCheckInfoNext);
    this.Panel5.Controls.Add((Control) this.btnCheckInfoCancel);
    this.Panel5.Controls.Add((Control) this.PictureBox7);
    this.Panel5.Dock = DockStyle.Bottom;
    this.Panel5.Location = new Point(0, 296);
    this.Panel5.Name = "Panel5";
    this.Panel5.Size = new Size(674, 40);
    this.Panel5.TabIndex = 14;
    ((Control) this.btnCheckInfoBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance20.BackColor = Color.Gainsboro;
    appearance20.BackColor2 = Color.White;
    appearance20.BackGradientStyle = (GradientStyle) 2;
    appearance20.BorderColor = Color.Gray;
    ((ControlBase) this.btnCheckInfoBack).Appearance = (AppearanceBase) appearance20;
    ((Control) this.btnCheckInfoBack).Location = new Point(376, 8);
    ((Control) this.btnCheckInfoBack).Name = "btnCheckInfoBack";
    ((Control) this.btnCheckInfoBack).Size = new Size(100, 24);
    ((Control) this.btnCheckInfoBack).TabIndex = 0;
    ((ControlBase) this.btnCheckInfoBack).Text = "< &Back";
    ((Control) this.tnCheckInfoNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance21.BackColor = Color.Gainsboro;
    appearance21.BackColor2 = Color.White;
    appearance21.BackGradientStyle = (GradientStyle) 2;
    appearance21.BorderColor = Color.Gray;
    ((ControlBase) this.tnCheckInfoNext).Appearance = (AppearanceBase) appearance21;
    ((Control) this.tnCheckInfoNext).Location = new Point(480, 8);
    ((Control) this.tnCheckInfoNext).Name = "tnCheckInfoNext";
    ((Control) this.tnCheckInfoNext).Size = new Size(100, 24);
    ((Control) this.tnCheckInfoNext).TabIndex = 1;
    ((ControlBase) this.tnCheckInfoNext).Text = "&Next >";
    ((Control) this.btnCheckInfoCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance22.BackColor = Color.Gainsboro;
    appearance22.BackColor2 = Color.White;
    appearance22.BackGradientStyle = (GradientStyle) 2;
    appearance22.BorderColor = Color.Gray;
    ((ControlBase) this.btnCheckInfoCancel).Appearance = (AppearanceBase) appearance22;
    ((Control) this.btnCheckInfoCancel).Location = new Point(592, 8);
    ((Control) this.btnCheckInfoCancel).Name = "btnCheckInfoCancel";
    ((Control) this.btnCheckInfoCancel).Size = new Size(75, 24);
    ((Control) this.btnCheckInfoCancel).TabIndex = 2;
    ((ControlBase) this.btnCheckInfoCancel).Text = "&Cancel";
    this.PictureBox7.Dock = DockStyle.Fill;
    this.PictureBox7.Image = (Image) resourceManager.GetObject("PictureBox7.Image");
    this.PictureBox7.Location = new Point(0, 0);
    this.PictureBox7.Name = "PictureBox7";
    this.PictureBox7.Size = new Size(674, 40);
    this.PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox7.TabIndex = 3;
    this.PictureBox7.TabStop = false;
    this.Panel6.BackColor = Color.Transparent;
    this.Panel6.BackgroundImage = (Image) resourceManager.GetObject("Panel6.BackgroundImage");
    this.Panel6.Controls.Add((Control) this.PictureBox8);
    this.Panel6.Controls.Add((Control) this.Label9);
    this.Panel6.Controls.Add((Control) this.Label10);
    this.Panel6.Dock = DockStyle.Top;
    this.Panel6.Location = new Point(0, 0);
    this.Panel6.Name = "Panel6";
    this.Panel6.Size = new Size(674, 80 /*0x50*/);
    this.Panel6.TabIndex = 0;
    this.PictureBox8.Image = (Image) resourceManager.GetObject("PictureBox8.Image");
    this.PictureBox8.Location = new Point(600, 8);
    this.PictureBox8.Name = "PictureBox8";
    this.PictureBox8.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.PictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox8.TabIndex = 3;
    this.PictureBox8.TabStop = false;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.ForeColor = Color.White;
    this.Label9.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(504, 24);
    this.Label9.TabIndex = 1;
    this.Label9.Text = "Please select the transaction type you are looking for. Then select the transaction you would like to reverse.";
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.White;
    this.Label10.Location = new Point(16 /*0x10*/, 0);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(332, 26);
    this.Label10.TabIndex = 0;
    this.Label10.Text = "Cash Receipt - Check Information";
    this.panelStart.BackColor = Color.White;
    this.panelStart.Controls.Add((Control) this.Panel9);
    this.panelStart.Controls.Add((Control) this.Label20);
    this.panelStart.Controls.Add((Control) this.Label19);
    this.panelStart.Controls.Add((Control) this.Panel8);
    this.panelStart.Controls.Add((Control) this.Label24);
    this.panelStart.Controls.Add((Control) this.Label23);
    this.panelStart.Location = new Point(0, 0);
    this.panelStart.Name = "panelStart";
    this.panelStart.Size = new Size(674, 336);
    this.panelStart.TabIndex = 0;
    this.Panel9.BackColor = Color.LightSlateGray;
    this.Panel9.Controls.Add((Control) this.PictureBox5);
    this.Panel9.Dock = DockStyle.Left;
    this.Panel9.Location = new Point(0, 0);
    this.Panel9.Name = "Panel9";
    this.Panel9.Size = new Size(152, 296);
    this.Panel9.TabIndex = 0;
    this.PictureBox5.Dock = DockStyle.Fill;
    this.PictureBox5.Image = (Image) resourceManager.GetObject("PictureBox5.Image");
    this.PictureBox5.Location = new Point(0, 0);
    this.PictureBox5.Name = "PictureBox5";
    this.PictureBox5.Size = new Size(152, 296);
    this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox5.TabIndex = 0;
    this.PictureBox5.TabStop = false;
    this.Label20.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label20.Location = new Point(168, 184);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(488, 64 /*0x40*/);
    this.Label20.TabIndex = 3;
    this.Label20.Text = "If at any time you wish to cancel this transaction, simply click the 'Cancel' button.";
    this.Label19.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label19.Location = new Point(168, 112 /*0x70*/);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(488, 64 /*0x40*/);
    this.Label19.TabIndex = 2;
    this.Label19.Text = "If at any time you make a mistake or you want to change a value, you can click the 'Back' button to go back to a previous step.";
    this.Panel8.BackgroundImage = (Image) resourceManager.GetObject("Panel8.BackgroundImage");
    this.Panel8.Controls.Add((Control) this.btnStartNext);
    this.Panel8.Controls.Add((Control) this.btnStartCancel);
    this.Panel8.Dock = DockStyle.Bottom;
    this.Panel8.Location = new Point(0, 296);
    this.Panel8.Name = "Panel8";
    this.Panel8.Size = new Size(674, 40);
    this.Panel8.TabIndex = 4;
    ((Control) this.btnStartNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance23.BackColor = Color.White;
    appearance23.BackColor2 = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    appearance23.BackGradientStyle = (GradientStyle) 2;
    appearance23.BorderColor = Color.DimGray;
    ((ControlBase) this.btnStartNext).Appearance = (AppearanceBase) appearance23;
    ((Control) this.btnStartNext).Location = new Point(472, 8);
    ((Control) this.btnStartNext).Name = "btnStartNext";
    ((Control) this.btnStartNext).Size = new Size(100, 24);
    ((Control) this.btnStartNext).TabIndex = 0;
    ((ControlBase) this.btnStartNext).Text = "&Next >";
    ((Control) this.btnStartCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance24.BackColor = Color.Gainsboro;
    appearance24.BackColor2 = Color.White;
    appearance24.BackGradientStyle = (GradientStyle) 2;
    appearance24.BorderColor = Color.Gray;
    ((ControlBase) this.btnStartCancel).Appearance = (AppearanceBase) appearance24;
    ((Control) this.btnStartCancel).Location = new Point(584, 8);
    ((Control) this.btnStartCancel).Name = "btnStartCancel";
    ((Control) this.btnStartCancel).Size = new Size(75, 24);
    ((Control) this.btnStartCancel).TabIndex = 1;
    ((ControlBase) this.btnStartCancel).Text = "&Cancel";
    this.Label24.AutoSize = true;
    this.Label24.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label24.Location = new Point(168, 8);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(205, 26);
    this.Label24.TabIndex = 0;
    this.Label24.Text = "Cash Receipt Wizard";
    this.Label23.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label23.Location = new Point(168, 48 /*0x30*/);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(488, 64 /*0x40*/);
    this.Label23.TabIndex = 1;
    this.Label23.Text = "Welcome to the cash receipt wizard. This wizard will walk you through the steps necessary to create a cash receipt transaction.";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.ClientSize = new Size(672, 334);
    this.Controls.Add((Control) this.panelStart);
    this.Controls.Add((Control) this.panelCashReceiptType);
    this.Controls.Add((Control) this.panelCheckInfo);
    this.Controls.Add((Control) this.panelInterCompany);
    this.Controls.Add((Control) this.panelManualGL);
    this.Controls.Add((Control) this.panelConfirm);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (frmCashReceiptWizard);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Cash Receipt Wizard";
    this.panelManualGL.ResumeLayout(false);
    this.Panel4.ResumeLayout(false);
    ((ISupportInitialize) this.btnManualGLBack).EndInit();
    ((ISupportInitialize) this.btnManualGLNext).EndInit();
    ((ISupportInitialize) this.btnManualGLCancel).EndInit();
    this.Panel7.ResumeLayout(false);
    this.panelConfirm.ResumeLayout(false);
    this.Panel11.ResumeLayout(false);
    ((ISupportInitialize) this.btnConfirmationBack).EndInit();
    ((ISupportInitialize) this.btnFinish).EndInit();
    ((ISupportInitialize) this.btnConfirmationCancel).EndInit();
    this.Panel12.ResumeLayout(false);
    this.panelCashReceiptType.ResumeLayout(false);
    this.panelSourceAccountFooter.ResumeLayout(false);
    ((ISupportInitialize) this.btnCashReceiptTypeBack).EndInit();
    ((ISupportInitialize) this.btnCashReceiptTypeNext).EndInit();
    ((ISupportInitialize) this.btnCashReceiptTypeCancel).EndInit();
    this.panelSourceAccountHeader.ResumeLayout(false);
    this.panelInterCompany.ResumeLayout(false);
    ((ISupportInitialize) this.gridInterCompanyTransactions).EndInit();
    this.Panel2.ResumeLayout(false);
    ((ISupportInitialize) this.btnInterCopanyBack).EndInit();
    ((ISupportInitialize) this.btnInterCompanyNext).EndInit();
    ((ISupportInitialize) this.btnInterCompanyCancel).EndInit();
    this.Panel3.ResumeLayout(false);
    this.panelCheckInfo.ResumeLayout(false);
    ((ISupportInitialize) this.dtpDepositDate).EndInit();
    ((ISupportInitialize) this.txtCheckNumber).EndInit();
    ((ISupportInitialize) this.txtCheckAmount).EndInit();
    ((ISupportInitialize) this.cmbBankAccount).EndInit();
    ((ISupportInitialize) this.cmbOfficeLocation).EndInit();
    ((ISupportInitialize) this.btnSearchRemitter).EndInit();
    ((ISupportInitialize) this.txtRemitterName).EndInit();
    this.Panel5.ResumeLayout(false);
    ((ISupportInitialize) this.btnCheckInfoBack).EndInit();
    ((ISupportInitialize) this.tnCheckInfoNext).EndInit();
    ((ISupportInitialize) this.btnCheckInfoCancel).EndInit();
    this.Panel6.ResumeLayout(false);
    this.panelStart.ResumeLayout(false);
    this.Panel9.ResumeLayout(false);
    this.Panel8.ResumeLayout(false);
    ((ISupportInitialize) this.btnStartNext).EndInit();
    ((ISupportInitialize) this.btnStartCancel).EndInit();
    this.ResumeLayout(false);
  }
}
