// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formCreateCompany
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using MGASystems.AddressResolver;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

public class formCreateCompany : Form
{
  private PictureBox pictureBox1;
  private Label label1;
  private Panel panel1;
  private Label label2;
  private UltraLabel ultraLabel1;
  private Panel panel2;
  private Label label4;
  private UltraLabel ultraLabel2;
  private UltraLabel ultraLabel3;
  private UltraLabel ultraLabel4;
  private UltraLabel ultraLabel5;
  private UltraLabel ultraLabel6;
  private UltraLabel ultraLabel7;
  private UltraLabel ultraLabel8;
  private UltraLabel ultraLabel9;
  private UltraLabel ultraLabel11;
  private UltraLabel ultraLabel12;
  private UltraLabel ultraLabel10;
  private UltraLabel ultraLabel13;
  private PictureBox pictureBox12;
  private Label label3;
  private Label label5;
  private PictureBox pictureIntroCheck;
  private PictureBox pictureOperatingBankCheck;
  private PictureBox picturePrimaryBankCheck;
  private PictureBox pictureCreateGLCheck;
  private PictureBox pictureGLSettingsCheck;
  private PictureBox pictureOfficeCheck;
  private PictureBox pictureWriteOffCheck;
  private PictureBox pictureCommRecCheck;
  private PictureBox pictureCashAccrualCheck;
  private Panel panelIntro;
  private Label label6;
  private Label label7;
  private PictureBox pictureBox2;
  private PictureBox pictureBox3;
  private Label label8;
  private Label label12;
  private Label label13;
  private Label label9;
  private Panel panelGLCreationSettings;
  private Label label11;
  private Label label14;
  private RadioButton radioCreateExpenseAccounts;
  private RadioButton radioDoNotCreateExpenseAccounts;
  private Label label10;
  private MGAButton buttonFinish;
  private MGAButton buttonBack;
  private MGAButton buttonNext;
  private MGAButton buttonCancel;
  private Panel panelOfficeLocation;
  private Label label15;
  private MGASimpleComboBox comboOfficeLocations;
  private dsGetOfficesLocationWithNoChartOfAccounts dsGetOfficesLocationWithNoChartOfAccounts1;
  private Panel panelPrimaryBank;
  private Label label17;
  private Label label18;
  private Label label16;
  private Label label19;
  private Label label20;
  private Label label21;
  private Label label22;
  private Label label23;
  private Label label24;
  private Label label25;
  private Label label26;
  private Label label27;
  private Label label28;
  private Label label29;
  private MGATextBox textPrimaryBankName;
  private AddressResolver_MULTI addressPrimaryBankAddress;
  private MGATextBox textPrimaryABAFractional;
  private NumericUpDown numericPrimaryNextCheckNumber;
  private CheckBox checkPrimaryNextCheckNumber;
  private MGATextBox textPrimaryBankContactFax;
  private MGATextBox textPrimaryBankContactPhone;
  private MGATextBox textPrimaryBankContactEmail;
  private MGATextBox textPrimaryBankContactName;
  private MGATextBox textPrimaryDepositSlipSuffix;
  private MGATextBox textPrimaryABARoutingNumber;
  private MGATextBox textPrimaryAccountNumber;
  private MGASimpleComboBox comboPrimaryAccountType;
  private Label label42;
  private Label label43;
  private Panel panelOperatingBank;
  private MGATextBox textOperatingBankName;
  private AddressResolver_MULTI addressOperatingBankAddress;
  private Label label30;
  private Label label31;
  private Label label32;
  private Label label33;
  private Label label34;
  private Label label35;
  private Label label36;
  private Label label37;
  private MGATextBox textOperatingABAFractional;
  private NumericUpDown numericOperatingNextCheckNumber;
  private CheckBox checkOperatingNextCheckNumber;
  private Label label38;
  private Label label39;
  private Label label40;
  private Label label41;
  private MGATextBox textOperatingBankContactPhone;
  private MGATextBox textOperatingBankContactEmail;
  private MGATextBox textOperatingBankContactName;
  private MGATextBox textOperatingDepositSlipSuffix;
  private MGATextBox textOperatingABARoutingNumber;
  private MGATextBox textOperatingAccountNumber;
  private MGASimpleComboBox comboOperatingAccountType;
  private Label label44;
  private Label label45;
  private Label label46;
  private MGATextBox textPrimaryBankGLShortName;
  private MGATextBox textPrimaryBankGLFullName;
  private Label label47;
  private MGATextBox textOperatingBankGLFullName;
  private MGATextBox textOperatingBankGLShortName;
  private Label label62;
  private Label label63;
  private Label label49;
  private RadioButton radioCashBasis;
  private RadioButton radioAccrualBasis;
  private Panel panelCashOrAccrual;
  private Panel panelPostTiming;
  private Label label50;
  private Panel panelCommissionReconciliation;
  private RadioButton radioFully;
  private RadioButton radioProportionally;
  private Label label48;
  private Label label52;
  private Panel panelWriteOffThreshold;
  private MGATextBox textPayableWriteOffThreshold;
  private Label label56;
  private MGATextBox textReceivableWriteOffThreshold;
  private Label label55;
  private Label label53;
  private Label label54;
  private Panel panel3;
  private Panel panel4;
  private Label label57;
  private Label label51;
  private PictureBox pictureInviocePostDateCheck;
  private Label label58;
  private Panel panelConfirmation;
  private PictureBox pictureBox4;
  private UltraLabel ultraLabel14;
  private Label label59;
  private Label label60;
  private Label label61;
  private Label label64;
  private Label label65;
  private Panel panelSettingsBreakout;
  private RadioButton radioReconPayables;
  private RadioButton radioReconReceivables;
  private RadioButton radioUseEffectiveDate;
  private RadioButton radioUseBillingdate;
  private MGATextBox textOperatingtBankContactFax;
  private dsBankAccountTypes dsBankAccountTypes1;
  private dsBankAccountTypes dsBankAccountTypes2;
  private UltraProgressBar progressProcessing;
  private Panel panelProcessing;
  private Label labelProgressHeader;
  private Label labelProgress;
  private System.ComponentModel.Container components;
  private Panel _currentPanel;
  private BankAccount _primaryBank;
  private BankAccount _operatingBank;

  public formCreateCompany()
  {
    this.InitializeComponent();
    this.InitializeFormSettings();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (formCreateCompany));
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
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
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
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    this.pictureBox1 = new PictureBox();
    this.label1 = new Label();
    this.panel1 = new Panel();
    this.label2 = new Label();
    this.ultraLabel1 = new UltraLabel();
    this.panel2 = new Panel();
    this.buttonFinish = new MGAButton();
    this.buttonBack = new MGAButton();
    this.buttonNext = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.label4 = new Label();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel5 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.ultraLabel7 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.ultraLabel9 = new UltraLabel();
    this.ultraLabel11 = new UltraLabel();
    this.ultraLabel12 = new UltraLabel();
    this.pictureIntroCheck = new PictureBox();
    this.pictureOperatingBankCheck = new PictureBox();
    this.picturePrimaryBankCheck = new PictureBox();
    this.pictureCreateGLCheck = new PictureBox();
    this.pictureGLSettingsCheck = new PictureBox();
    this.pictureOfficeCheck = new PictureBox();
    this.pictureWriteOffCheck = new PictureBox();
    this.pictureInviocePostDateCheck = new PictureBox();
    this.pictureCommRecCheck = new PictureBox();
    this.ultraLabel10 = new UltraLabel();
    this.ultraLabel13 = new UltraLabel();
    this.pictureCashAccrualCheck = new PictureBox();
    this.panelIntro = new Panel();
    this.label8 = new Label();
    this.pictureBox3 = new PictureBox();
    this.pictureBox2 = new PictureBox();
    this.label7 = new Label();
    this.label6 = new Label();
    this.label5 = new Label();
    this.label3 = new Label();
    this.pictureBox12 = new PictureBox();
    this.panelOfficeLocation = new Panel();
    this.label15 = new Label();
    this.comboOfficeLocations = new MGASimpleComboBox();
    this.dsGetOfficesLocationWithNoChartOfAccounts1 = new dsGetOfficesLocationWithNoChartOfAccounts();
    this.label9 = new Label();
    this.label12 = new Label();
    this.label13 = new Label();
    this.panelGLCreationSettings = new Panel();
    this.label10 = new Label();
    this.radioDoNotCreateExpenseAccounts = new RadioButton();
    this.radioCreateExpenseAccounts = new RadioButton();
    this.label11 = new Label();
    this.label14 = new Label();
    this.panelPrimaryBank = new Panel();
    this.label46 = new Label();
    this.textPrimaryBankGLShortName = new MGATextBox();
    this.textPrimaryBankGLFullName = new MGATextBox();
    this.label47 = new Label();
    this.textPrimaryBankName = new MGATextBox();
    this.addressPrimaryBankAddress = new AddressResolver_MULTI();
    this.label16 = new Label();
    this.label19 = new Label();
    this.label20 = new Label();
    this.label21 = new Label();
    this.label22 = new Label();
    this.label23 = new Label();
    this.label24 = new Label();
    this.label25 = new Label();
    this.textPrimaryABAFractional = new MGATextBox();
    this.numericPrimaryNextCheckNumber = new NumericUpDown();
    this.checkPrimaryNextCheckNumber = new CheckBox();
    this.label26 = new Label();
    this.label27 = new Label();
    this.label28 = new Label();
    this.label29 = new Label();
    this.textPrimaryBankContactFax = new MGATextBox();
    this.textPrimaryBankContactPhone = new MGATextBox();
    this.textPrimaryBankContactEmail = new MGATextBox();
    this.textPrimaryBankContactName = new MGATextBox();
    this.textPrimaryDepositSlipSuffix = new MGATextBox();
    this.textPrimaryABARoutingNumber = new MGATextBox();
    this.textPrimaryAccountNumber = new MGATextBox();
    this.comboPrimaryAccountType = new MGASimpleComboBox();
    this.dsBankAccountTypes1 = new dsBankAccountTypes();
    this.label17 = new Label();
    this.label18 = new Label();
    this.panelOperatingBank = new Panel();
    this.label45 = new Label();
    this.textOperatingBankGLShortName = new MGATextBox();
    this.textOperatingBankGLFullName = new MGATextBox();
    this.label44 = new Label();
    this.textOperatingBankName = new MGATextBox();
    this.addressOperatingBankAddress = new AddressResolver_MULTI();
    this.label30 = new Label();
    this.label31 = new Label();
    this.label32 = new Label();
    this.label33 = new Label();
    this.label34 = new Label();
    this.label35 = new Label();
    this.label36 = new Label();
    this.label37 = new Label();
    this.textOperatingABAFractional = new MGATextBox();
    this.numericOperatingNextCheckNumber = new NumericUpDown();
    this.checkOperatingNextCheckNumber = new CheckBox();
    this.label38 = new Label();
    this.label39 = new Label();
    this.label40 = new Label();
    this.label41 = new Label();
    this.textOperatingtBankContactFax = new MGATextBox();
    this.textOperatingBankContactPhone = new MGATextBox();
    this.textOperatingBankContactEmail = new MGATextBox();
    this.textOperatingBankContactName = new MGATextBox();
    this.textOperatingDepositSlipSuffix = new MGATextBox();
    this.textOperatingABARoutingNumber = new MGATextBox();
    this.textOperatingAccountNumber = new MGATextBox();
    this.comboOperatingAccountType = new MGASimpleComboBox();
    this.dsBankAccountTypes2 = new dsBankAccountTypes();
    this.label42 = new Label();
    this.label43 = new Label();
    this.panelCashOrAccrual = new Panel();
    this.radioAccrualBasis = new RadioButton();
    this.radioCashBasis = new RadioButton();
    this.label49 = new Label();
    this.label62 = new Label();
    this.label63 = new Label();
    this.panelPostTiming = new Panel();
    this.radioUseEffectiveDate = new RadioButton();
    this.radioUseBillingdate = new RadioButton();
    this.label58 = new Label();
    this.label50 = new Label();
    this.panelCommissionReconciliation = new Panel();
    this.label51 = new Label();
    this.label57 = new Label();
    this.panel4 = new Panel();
    this.radioFully = new RadioButton();
    this.radioProportionally = new RadioButton();
    this.panel3 = new Panel();
    this.radioReconPayables = new RadioButton();
    this.radioReconReceivables = new RadioButton();
    this.label48 = new Label();
    this.label52 = new Label();
    this.panelWriteOffThreshold = new Panel();
    this.textPayableWriteOffThreshold = new MGATextBox();
    this.label56 = new Label();
    this.textReceivableWriteOffThreshold = new MGATextBox();
    this.label55 = new Label();
    this.label53 = new Label();
    this.label54 = new Label();
    this.panelConfirmation = new Panel();
    this.panelProcessing = new Panel();
    this.labelProgress = new Label();
    this.progressProcessing = new UltraProgressBar();
    this.labelProgressHeader = new Label();
    this.panelSettingsBreakout = new Panel();
    this.label65 = new Label();
    this.label64 = new Label();
    this.label61 = new Label();
    this.label60 = new Label();
    this.label59 = new Label();
    this.pictureBox4 = new PictureBox();
    this.ultraLabel14 = new UltraLabel();
    this.panel1.SuspendLayout();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.buttonFinish).BeginInit();
    ((ISupportInitialize) this.buttonBack).BeginInit();
    ((ISupportInitialize) this.buttonNext).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.panelIntro.SuspendLayout();
    this.panelOfficeLocation.SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocations).BeginInit();
    this.dsGetOfficesLocationWithNoChartOfAccounts1.BeginInit();
    this.panelGLCreationSettings.SuspendLayout();
    this.panelPrimaryBank.SuspendLayout();
    ((ISupportInitialize) this.textPrimaryBankGLShortName).BeginInit();
    ((ISupportInitialize) this.textPrimaryBankGLFullName).BeginInit();
    ((ISupportInitialize) this.textPrimaryBankName).BeginInit();
    ((ISupportInitialize) this.textPrimaryABAFractional).BeginInit();
    this.numericPrimaryNextCheckNumber.BeginInit();
    ((ISupportInitialize) this.textPrimaryBankContactFax).BeginInit();
    ((ISupportInitialize) this.textPrimaryBankContactPhone).BeginInit();
    ((ISupportInitialize) this.textPrimaryBankContactEmail).BeginInit();
    ((ISupportInitialize) this.textPrimaryBankContactName).BeginInit();
    ((ISupportInitialize) this.textPrimaryDepositSlipSuffix).BeginInit();
    ((ISupportInitialize) this.textPrimaryABARoutingNumber).BeginInit();
    ((ISupportInitialize) this.textPrimaryAccountNumber).BeginInit();
    ((ISupportInitialize) this.comboPrimaryAccountType).BeginInit();
    this.dsBankAccountTypes1.BeginInit();
    this.panelOperatingBank.SuspendLayout();
    ((ISupportInitialize) this.textOperatingBankGLShortName).BeginInit();
    ((ISupportInitialize) this.textOperatingBankGLFullName).BeginInit();
    ((ISupportInitialize) this.textOperatingBankName).BeginInit();
    ((ISupportInitialize) this.textOperatingABAFractional).BeginInit();
    this.numericOperatingNextCheckNumber.BeginInit();
    ((ISupportInitialize) this.textOperatingtBankContactFax).BeginInit();
    ((ISupportInitialize) this.textOperatingBankContactPhone).BeginInit();
    ((ISupportInitialize) this.textOperatingBankContactEmail).BeginInit();
    ((ISupportInitialize) this.textOperatingBankContactName).BeginInit();
    ((ISupportInitialize) this.textOperatingDepositSlipSuffix).BeginInit();
    ((ISupportInitialize) this.textOperatingABARoutingNumber).BeginInit();
    ((ISupportInitialize) this.textOperatingAccountNumber).BeginInit();
    ((ISupportInitialize) this.comboOperatingAccountType).BeginInit();
    this.dsBankAccountTypes2.BeginInit();
    this.panelCashOrAccrual.SuspendLayout();
    this.panelPostTiming.SuspendLayout();
    this.panelCommissionReconciliation.SuspendLayout();
    this.panel4.SuspendLayout();
    this.panel3.SuspendLayout();
    this.panelWriteOffThreshold.SuspendLayout();
    ((ISupportInitialize) this.textPayableWriteOffThreshold).BeginInit();
    ((ISupportInitialize) this.textReceivableWriteOffThreshold).BeginInit();
    this.panelConfirmation.SuspendLayout();
    this.panelProcessing.SuspendLayout();
    this.SuspendLayout();
    this.pictureBox1.Image = (Image) resourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(-24, -24);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(160 /*0xA0*/, 136);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(432, 48 /*0x30*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(306, 25);
    this.label1.TabIndex = 0;
    this.label1.Text = "Create A New Chart Of Accounts";
    this.panel1.BackColor = Color.White;
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.pictureBox1);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(746, 80 /*0x50*/);
    this.panel1.TabIndex = 0;
    this.label2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Dock = DockStyle.Bottom;
    this.label2.ForeColor = Color.Gray;
    this.label2.Location = new Point(0, 79);
    this.label2.Name = "label2";
    this.label2.Size = new Size(746, 1);
    this.label2.TabIndex = 1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel1).Dock = DockStyle.Left;
    ((Control) this.ultraLabel1).Location = new Point(0, 80 /*0x50*/);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(224 /*0xE0*/, 416);
    ((Control) this.ultraLabel1).TabIndex = 1;
    this.panel2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panel2.Controls.Add((Control) this.buttonFinish);
    this.panel2.Controls.Add((Control) this.buttonBack);
    this.panel2.Controls.Add((Control) this.buttonNext);
    this.panel2.Controls.Add((Control) this.buttonCancel);
    this.panel2.Controls.Add((Control) this.label4);
    this.panel2.Dock = DockStyle.Bottom;
    this.panel2.Location = new Point(0, 496);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(746, 56);
    this.panel2.TabIndex = 16 /*0x10*/;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonFinish).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonFinish).Enabled = false;
    ((Control) this.buttonFinish).Location = new Point(552, 16 /*0x10*/);
    ((Control) this.buttonFinish).Name = "buttonFinish";
    ((Control) this.buttonFinish).Size = new Size(88, 24);
    ((Control) this.buttonFinish).TabIndex = 2;
    ((Control) this.buttonFinish).Text = "Finish";
    ((Control) this.buttonFinish).Click += new EventHandler(this.buttonFinish_Click);
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonBack).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonBack).Enabled = false;
    ((Control) this.buttonBack).Location = new Point(360, 16 /*0x10*/);
    ((Control) this.buttonBack).Name = "buttonBack";
    ((Control) this.buttonBack).Size = new Size(88, 24);
    ((Control) this.buttonBack).TabIndex = 0;
    ((Control) this.buttonBack).Text = "Back";
    ((Control) this.buttonBack).Click += new EventHandler(this.buttonBack_Click);
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonNext).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonNext).Location = new Point(456, 16 /*0x10*/);
    ((Control) this.buttonNext).Name = "buttonNext";
    ((Control) this.buttonNext).Size = new Size(88, 24);
    ((Control) this.buttonNext).TabIndex = 1;
    ((Control) this.buttonNext).Text = "Next";
    ((Control) this.buttonNext).Click += new EventHandler(this.buttonNext_Click);
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance5).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance5).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonCancel).Location = new Point(648, 16 /*0x10*/);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 24);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.label4.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label4.BorderStyle = BorderStyle.Fixed3D;
    this.label4.Dock = DockStyle.Top;
    this.label4.ForeColor = Color.Gray;
    this.label4.Location = new Point(0, 0);
    this.label4.Name = "label4";
    this.label4.Size = new Size(746, 1);
    this.label4.TabIndex = 3;
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance6).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance6;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Location = new Point(32 /*0x20*/, 240 /*0xF0*/);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(160 /*0xA0*/, 14);
    ((Control) this.ultraLabel2).TabIndex = 7;
    ((Control) this.ultraLabel2).Text = "Primary Bank Account Settings";
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance7).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance7;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Location = new Point(32 /*0x20*/, 144 /*0x90*/);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(130, 14);
    ((Control) this.ultraLabel3).TabIndex = 4;
    ((Control) this.ultraLabel3).Text = "Select an Office Location";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance8).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance8;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(32 /*0x20*/, 112 /*0x70*/);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(63 /*0x3F*/, 14);
    ((Control) this.ultraLabel4).TabIndex = 3;
    ((Control) this.ultraLabel4).Text = "Introduction";
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance9).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance9).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance9;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Location = new Point(32 /*0x20*/, 176 /*0xB0*/);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(193, 14);
    ((Control) this.ultraLabel5).TabIndex = 5;
    ((Control) this.ultraLabel5).Text = "Specify GL Account Creation Settings";
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance10).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel6).Appearance = (AppearanceBase) appearance10;
    ((Control) this.ultraLabel6).AutoSize = true;
    ((Control) this.ultraLabel6).Location = new Point(32 /*0x20*/, 208 /*0xD0*/);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(115, 14);
    ((Control) this.ultraLabel6).TabIndex = 6;
    ((Control) this.ultraLabel6).Text = "Creating GL Accounts";
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance11).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance11;
    ((Control) this.ultraLabel7).AutoSize = true;
    ((Control) this.ultraLabel7).Location = new Point(32 /*0x20*/, 272);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(171, 14);
    ((Control) this.ultraLabel7).TabIndex = 8;
    ((Control) this.ultraLabel7).Text = "Operating Bank Account Settings";
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance12).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance12).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance12;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(8, 88);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(115, 15);
    ((Control) this.ultraLabel8).TabIndex = 2;
    ((Control) this.ultraLabel8).Text = "GENERAL SETTINGS";
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance13).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance13).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel9).Appearance = (AppearanceBase) appearance13;
    ((Control) this.ultraLabel9).AutoSize = true;
    ((Control) this.ultraLabel9).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel9).Location = new Point(8, 336);
    ((Control) this.ultraLabel9).Name = "ultraLabel9";
    ((Control) this.ultraLabel9).Size = new Size(123, 15);
    ((Control) this.ultraLabel9).TabIndex = 10;
    ((Control) this.ultraLabel9).Text = "EXTENDED SETTINGS";
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance14).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance14).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel11).Appearance = (AppearanceBase) appearance14;
    ((Control) this.ultraLabel11).AutoSize = true;
    ((Control) this.ultraLabel11).Location = new Point(32 /*0x20*/, 424);
    ((Control) this.ultraLabel11).Name = "ultraLabel11";
    ((Control) this.ultraLabel11).Size = new Size(172, 14);
    ((Control) this.ultraLabel11).TabIndex = 13;
    ((Control) this.ultraLabel11).Text = "Invoice Posting Date Preferences";
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance15).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance15).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance15).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel12).Appearance = (AppearanceBase) appearance15;
    ((Control) this.ultraLabel12).AutoSize = true;
    ((Control) this.ultraLabel12).Location = new Point(32 /*0x20*/, 392);
    ((Control) this.ultraLabel12).Name = "ultraLabel12";
    ((Control) this.ultraLabel12).Size = new Size(109, 14);
    ((Control) this.ultraLabel12).TabIndex = 12;
    ((Control) this.ultraLabel12).Text = "Write-Off Thresholds";
    this.pictureIntroCheck.BackColor = Color.Transparent;
    this.pictureIntroCheck.Image = (Image) resourceManager.GetObject("pictureIntroCheck.Image");
    this.pictureIntroCheck.Location = new Point(16 /*0x10*/, 112 /*0x70*/);
    this.pictureIntroCheck.Name = "pictureIntroCheck";
    this.pictureIntroCheck.Size = new Size(16 /*0x10*/, 15);
    this.pictureIntroCheck.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureIntroCheck.TabIndex = 22;
    this.pictureIntroCheck.TabStop = false;
    this.pictureIntroCheck.Visible = false;
    this.pictureOperatingBankCheck.BackColor = Color.FromArgb(245, 247, 253);
    this.pictureOperatingBankCheck.Image = (Image) resourceManager.GetObject("pictureOperatingBankCheck.Image");
    this.pictureOperatingBankCheck.Location = new Point(16 /*0x10*/, 272);
    this.pictureOperatingBankCheck.Name = "pictureOperatingBankCheck";
    this.pictureOperatingBankCheck.Size = new Size(16 /*0x10*/, 15);
    this.pictureOperatingBankCheck.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureOperatingBankCheck.TabIndex = 23;
    this.pictureOperatingBankCheck.TabStop = false;
    this.pictureOperatingBankCheck.Visible = false;
    this.picturePrimaryBankCheck.BackColor = Color.FromArgb(245, 247, 253);
    this.picturePrimaryBankCheck.Image = (Image) resourceManager.GetObject("picturePrimaryBankCheck.Image");
    this.picturePrimaryBankCheck.Location = new Point(16 /*0x10*/, 240 /*0xF0*/);
    this.picturePrimaryBankCheck.Name = "picturePrimaryBankCheck";
    this.picturePrimaryBankCheck.Size = new Size(16 /*0x10*/, 15);
    this.picturePrimaryBankCheck.SizeMode = PictureBoxSizeMode.AutoSize;
    this.picturePrimaryBankCheck.TabIndex = 24;
    this.picturePrimaryBankCheck.TabStop = false;
    this.picturePrimaryBankCheck.Visible = false;
    this.pictureCreateGLCheck.Image = (Image) resourceManager.GetObject("pictureCreateGLCheck.Image");
    this.pictureCreateGLCheck.Location = new Point(16 /*0x10*/, 208 /*0xD0*/);
    this.pictureCreateGLCheck.Name = "pictureCreateGLCheck";
    this.pictureCreateGLCheck.Size = new Size(16 /*0x10*/, 15);
    this.pictureCreateGLCheck.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureCreateGLCheck.TabIndex = 25;
    this.pictureCreateGLCheck.TabStop = false;
    this.pictureCreateGLCheck.Visible = false;
    this.pictureGLSettingsCheck.Image = (Image) resourceManager.GetObject("pictureGLSettingsCheck.Image");
    this.pictureGLSettingsCheck.Location = new Point(16 /*0x10*/, 176 /*0xB0*/);
    this.pictureGLSettingsCheck.Name = "pictureGLSettingsCheck";
    this.pictureGLSettingsCheck.Size = new Size(16 /*0x10*/, 15);
    this.pictureGLSettingsCheck.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureGLSettingsCheck.TabIndex = 26;
    this.pictureGLSettingsCheck.TabStop = false;
    this.pictureGLSettingsCheck.Visible = false;
    this.pictureOfficeCheck.BackColor = Color.FromArgb(250, 247, 253);
    this.pictureOfficeCheck.Image = (Image) resourceManager.GetObject("pictureOfficeCheck.Image");
    this.pictureOfficeCheck.Location = new Point(16 /*0x10*/, 144 /*0x90*/);
    this.pictureOfficeCheck.Name = "pictureOfficeCheck";
    this.pictureOfficeCheck.Size = new Size(16 /*0x10*/, 15);
    this.pictureOfficeCheck.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureOfficeCheck.TabIndex = 27;
    this.pictureOfficeCheck.TabStop = false;
    this.pictureOfficeCheck.Visible = false;
    this.pictureWriteOffCheck.BackColor = Color.FromArgb(239, 247, 253);
    this.pictureWriteOffCheck.Image = (Image) resourceManager.GetObject("pictureWriteOffCheck.Image");
    this.pictureWriteOffCheck.Location = new Point(16 /*0x10*/, 392);
    this.pictureWriteOffCheck.Name = "pictureWriteOffCheck";
    this.pictureWriteOffCheck.Size = new Size(16 /*0x10*/, 15);
    this.pictureWriteOffCheck.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureWriteOffCheck.TabIndex = 28;
    this.pictureWriteOffCheck.TabStop = false;
    this.pictureWriteOffCheck.Visible = false;
    this.pictureInviocePostDateCheck.BackColor = Color.FromArgb(239, 247, 253);
    this.pictureInviocePostDateCheck.Image = (Image) resourceManager.GetObject("pictureInviocePostDateCheck.Image");
    this.pictureInviocePostDateCheck.Location = new Point(16 /*0x10*/, 424);
    this.pictureInviocePostDateCheck.Name = "pictureInviocePostDateCheck";
    this.pictureInviocePostDateCheck.Size = new Size(16 /*0x10*/, 15);
    this.pictureInviocePostDateCheck.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureInviocePostDateCheck.TabIndex = 29;
    this.pictureInviocePostDateCheck.TabStop = false;
    this.pictureInviocePostDateCheck.Visible = false;
    this.pictureCommRecCheck.BackColor = Color.FromArgb(239, 247, 253);
    this.pictureCommRecCheck.Image = (Image) resourceManager.GetObject("pictureCommRecCheck.Image");
    this.pictureCommRecCheck.Location = new Point(16 /*0x10*/, 360);
    this.pictureCommRecCheck.Name = "pictureCommRecCheck";
    this.pictureCommRecCheck.Size = new Size(16 /*0x10*/, 15);
    this.pictureCommRecCheck.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureCommRecCheck.TabIndex = 30;
    this.pictureCommRecCheck.TabStop = false;
    this.pictureCommRecCheck.Visible = false;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance16).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance16).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel10).Appearance = (AppearanceBase) appearance16;
    ((Control) this.ultraLabel10).AutoSize = true;
    ((Control) this.ultraLabel10).BackColor = Color.White;
    ((Control) this.ultraLabel10).Font = new Font("Tahoma", 8f);
    ((Control) this.ultraLabel10).ForeColor = Color.Black;
    ((Control) this.ultraLabel10).Location = new Point(32 /*0x20*/, 360);
    ((Control) this.ultraLabel10).Name = "ultraLabel10";
    ((Control) this.ultraLabel10).Size = new Size(193, 15);
    ((Control) this.ultraLabel10).TabIndex = 11;
    ((Control) this.ultraLabel10).Text = "Commission Recognition/Reconciliation";
    ((AppearanceBase) appearance17).BackColor = Color.White;
    ((AppearanceBase) appearance17).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance17).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance17).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel13).Appearance = (AppearanceBase) appearance17;
    ((Control) this.ultraLabel13).AutoSize = true;
    ((Control) this.ultraLabel13).Location = new Point(32 /*0x20*/, 304);
    ((Control) this.ultraLabel13).Name = "ultraLabel13";
    ((Control) this.ultraLabel13).Size = new Size(87, 14);
    ((Control) this.ultraLabel13).TabIndex = 9;
    ((Control) this.ultraLabel13).Text = "Cash Or Accural";
    this.pictureCashAccrualCheck.BackColor = Color.FromArgb(239, 247, 253);
    this.pictureCashAccrualCheck.Image = (Image) resourceManager.GetObject("pictureCashAccrualCheck.Image");
    this.pictureCashAccrualCheck.Location = new Point(16 /*0x10*/, 304);
    this.pictureCashAccrualCheck.Name = "pictureCashAccrualCheck";
    this.pictureCashAccrualCheck.Size = new Size(16 /*0x10*/, 15);
    this.pictureCashAccrualCheck.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureCashAccrualCheck.TabIndex = 32 /*0x20*/;
    this.pictureCashAccrualCheck.TabStop = false;
    this.pictureCashAccrualCheck.Visible = false;
    this.panelIntro.Controls.Add((Control) this.label8);
    this.panelIntro.Controls.Add((Control) this.pictureBox3);
    this.panelIntro.Controls.Add((Control) this.pictureBox2);
    this.panelIntro.Controls.Add((Control) this.label7);
    this.panelIntro.Controls.Add((Control) this.label6);
    this.panelIntro.Controls.Add((Control) this.label5);
    this.panelIntro.Controls.Add((Control) this.label3);
    this.panelIntro.Controls.Add((Control) this.pictureBox12);
    this.panelIntro.Dock = DockStyle.Fill;
    this.panelIntro.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.panelIntro.Name = "panelIntro";
    this.panelIntro.Size = new Size(522, 416);
    this.panelIntro.TabIndex = 15;
    this.label8.Location = new Point(16 /*0x10*/, 320);
    this.label8.Name = "label8";
    this.label8.Size = new Size(464, 56);
    this.label8.TabIndex = 4;
    this.label8.Text = "After creating this new chart of accounts you can then add new GL accounts through the GL Account Management console. You can also change your commission recognition and reconciliation settings using the extended settings utility. Cash or Accrual base settings can NOT be changed at anytime after this wizard is complete.";
    this.pictureBox3.Image = (Image) resourceManager.GetObject("pictureBox3.Image");
    this.pictureBox3.Location = new Point(88, 240 /*0xF0*/);
    this.pictureBox3.Name = "pictureBox3";
    this.pictureBox3.Size = new Size(25, 10);
    this.pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox3.TabIndex = 6;
    this.pictureBox3.TabStop = false;
    this.pictureBox2.Image = (Image) resourceManager.GetObject("pictureBox2.Image");
    this.pictureBox2.Location = new Point(88, 208 /*0xD0*/);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(25, 10);
    this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox2.TabIndex = 5;
    this.pictureBox2.TabStop = false;
    this.label7.AutoSize = true;
    this.label7.Location = new Point(112 /*0x70*/, 240 /*0xF0*/);
    this.label7.Name = "label7";
    this.label7.Size = new Size(230, 16 /*0x10*/);
    this.label7.TabIndex = 3;
    this.label7.Text = "Operating Bank Account and Routing Numbers";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(112 /*0x70*/, 208 /*0xD0*/);
    this.label6.Name = "label6";
    this.label6.Size = new Size(219, 16 /*0x10*/);
    this.label6.TabIndex = 2;
    this.label6.Text = "Primary Bank Account and Routing Numbers";
    this.label5.Location = new Point(32 /*0x20*/, 136);
    this.label5.Name = "label5";
    this.label5.Size = new Size(464, 32 /*0x20*/);
    this.label5.TabIndex = 1;
    this.label5.Text = "Once you begin this wizard you will have to compete it in it's entirety. You should have the following information available before beginning this wizard.";
    this.label3.Location = new Point(32 /*0x20*/, 64 /*0x40*/);
    this.label3.Name = "label3";
    this.label3.Size = new Size(464, 40);
    this.label3.TabIndex = 0;
    this.label3.Text = "This 10 step wizard will walk you through the steps necessary to create a functioning IMS Accounting chart of accounts. You must complete all the steps in this wizard to use the chart of accounts created.  ";
    this.pictureBox12.Image = (Image) resourceManager.GetObject("pictureBox12.Image");
    this.pictureBox12.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.pictureBox12.Name = "pictureBox12";
    this.pictureBox12.Size = new Size(350, 40);
    this.pictureBox12.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox12.TabIndex = 0;
    this.pictureBox12.TabStop = false;
    this.panelOfficeLocation.Controls.Add((Control) this.label15);
    this.panelOfficeLocation.Controls.Add((Control) this.comboOfficeLocations);
    this.panelOfficeLocation.Controls.Add((Control) this.label9);
    this.panelOfficeLocation.Controls.Add((Control) this.label12);
    this.panelOfficeLocation.Controls.Add((Control) this.label13);
    this.panelOfficeLocation.Dock = DockStyle.Fill;
    this.panelOfficeLocation.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.panelOfficeLocation.Name = "panelOfficeLocation";
    this.panelOfficeLocation.Size = new Size(522, 416);
    this.panelOfficeLocation.TabIndex = 17;
    this.label15.Location = new Point(28, 368);
    this.label15.Name = "label15";
    this.label15.Size = new Size(464, 32 /*0x20*/);
    this.label15.TabIndex = 4;
    this.label15.Text = "* This is the last opportunity to cancel the wizard. After this point you will have to finish this wizard in it's entirety.";
    this.label15.Visible = false;
    this.comboOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocations.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboOfficeLocations).DataMember = "tblClientOffices";
    ((UltraGridBase) this.comboOfficeLocations).DataSource = (object) this.dsGetOfficesLocationWithNoChartOfAccounts1;
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "Office Location";
    this.comboOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocations).Location = new Point(40, 224 /*0xE0*/);
    this.comboOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocations).Name = "comboOfficeLocations";
    ((Control) this.comboOfficeLocations).Size = new Size(424, 20);
    ((Control) this.comboOfficeLocations).TabIndex = 3;
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "ID";
    this.dsGetOfficesLocationWithNoChartOfAccounts1.DataSetName = "dsGetOfficesLocationWithNoChartOfAccounts";
    this.dsGetOfficesLocationWithNoChartOfAccounts1.Locale = new CultureInfo("en-US");
    this.label9.AutoSize = true;
    this.label9.Location = new Point(40, 200);
    this.label9.Name = "label9";
    this.label9.Size = new Size(76, 16 /*0x10*/);
    this.label9.TabIndex = 2;
    this.label9.Text = "Office Location";
    this.label12.AutoSize = true;
    this.label12.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label12.Location = new Point(32 /*0x20*/, 24);
    this.label12.Name = "label12";
    this.label12.Size = new Size(158, 18);
    this.label12.TabIndex = 0;
    this.label12.Text = "Select an Office Location";
    this.label13.Location = new Point(32 /*0x20*/, 88);
    this.label13.Name = "label13";
    this.label13.Size = new Size(464, 64 /*0x40*/);
    this.label13.TabIndex = 1;
    this.label13.Text = "The drop-down menu below provides you with a listing of the office locations available within the system that do now have a chart of accounts created for them. Please select the Office Lcoation for which you want to create a chart of accounts from the drop-down list below.";
    this.panelGLCreationSettings.Controls.Add((Control) this.label10);
    this.panelGLCreationSettings.Controls.Add((Control) this.radioDoNotCreateExpenseAccounts);
    this.panelGLCreationSettings.Controls.Add((Control) this.radioCreateExpenseAccounts);
    this.panelGLCreationSettings.Controls.Add((Control) this.label11);
    this.panelGLCreationSettings.Controls.Add((Control) this.label14);
    this.panelGLCreationSettings.Dock = DockStyle.Fill;
    this.panelGLCreationSettings.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.panelGLCreationSettings.Name = "panelGLCreationSettings";
    this.panelGLCreationSettings.Size = new Size(522, 416);
    this.panelGLCreationSettings.TabIndex = 18;
    this.label10.Location = new Point(32 /*0x20*/, 352);
    this.label10.Name = "label10";
    this.label10.Size = new Size(464, 16 /*0x10*/);
    this.label10.TabIndex = 4;
    this.label10.Text = "You will NOT have the option to create these built in expense accounts again.";
    this.radioDoNotCreateExpenseAccounts.FlatStyle = FlatStyle.Flat;
    this.radioDoNotCreateExpenseAccounts.Location = new Point(72, 248);
    this.radioDoNotCreateExpenseAccounts.Name = "radioDoNotCreateExpenseAccounts";
    this.radioDoNotCreateExpenseAccounts.Size = new Size(280, 24);
    this.radioDoNotCreateExpenseAccounts.TabIndex = 3;
    this.radioDoNotCreateExpenseAccounts.Text = "I would not like to use the built in expense accounts.";
    this.radioCreateExpenseAccounts.FlatStyle = FlatStyle.Flat;
    this.radioCreateExpenseAccounts.Location = new Point(72, 208 /*0xD0*/);
    this.radioCreateExpenseAccounts.Name = "radioCreateExpenseAccounts";
    this.radioCreateExpenseAccounts.Size = new Size(312, 24);
    this.radioCreateExpenseAccounts.TabIndex = 2;
    this.radioCreateExpenseAccounts.Text = "I would like to use the built in expense accounts.";
    this.label11.AutoSize = true;
    this.label11.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label11.Location = new Point(32 /*0x20*/, 24);
    this.label11.Name = "label11";
    this.label11.Size = new Size(186, 18);
    this.label11.TabIndex = 0;
    this.label11.Text = "GL Account Creation Settings";
    this.label14.Location = new Point(32 /*0x20*/, 88);
    this.label14.Name = "label14";
    this.label14.Size = new Size(464, 64 /*0x40*/);
    this.label14.TabIndex = 1;
    this.label14.Text = "The IMS Integrated Accounting system can create a standardized expense GL account list. If you do not want to use the built in expense accounts, specify that by selecting the appropriate option below.";
    this.panelPrimaryBank.Controls.Add((Control) this.label46);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryBankGLShortName);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryBankGLFullName);
    this.panelPrimaryBank.Controls.Add((Control) this.label47);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryBankName);
    this.panelPrimaryBank.Controls.Add((Control) this.addressPrimaryBankAddress);
    this.panelPrimaryBank.Controls.Add((Control) this.label16);
    this.panelPrimaryBank.Controls.Add((Control) this.label19);
    this.panelPrimaryBank.Controls.Add((Control) this.label20);
    this.panelPrimaryBank.Controls.Add((Control) this.label21);
    this.panelPrimaryBank.Controls.Add((Control) this.label22);
    this.panelPrimaryBank.Controls.Add((Control) this.label23);
    this.panelPrimaryBank.Controls.Add((Control) this.label24);
    this.panelPrimaryBank.Controls.Add((Control) this.label25);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryABAFractional);
    this.panelPrimaryBank.Controls.Add((Control) this.numericPrimaryNextCheckNumber);
    this.panelPrimaryBank.Controls.Add((Control) this.checkPrimaryNextCheckNumber);
    this.panelPrimaryBank.Controls.Add((Control) this.label26);
    this.panelPrimaryBank.Controls.Add((Control) this.label27);
    this.panelPrimaryBank.Controls.Add((Control) this.label28);
    this.panelPrimaryBank.Controls.Add((Control) this.label29);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryBankContactFax);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryBankContactPhone);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryBankContactEmail);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryBankContactName);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryDepositSlipSuffix);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryABARoutingNumber);
    this.panelPrimaryBank.Controls.Add((Control) this.textPrimaryAccountNumber);
    this.panelPrimaryBank.Controls.Add((Control) this.comboPrimaryAccountType);
    this.panelPrimaryBank.Controls.Add((Control) this.label17);
    this.panelPrimaryBank.Controls.Add((Control) this.label18);
    this.panelPrimaryBank.Dock = DockStyle.Fill;
    this.panelPrimaryBank.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.panelPrimaryBank.Name = "panelPrimaryBank";
    this.panelPrimaryBank.Size = new Size(522, 416);
    this.panelPrimaryBank.TabIndex = 19;
    this.label46.AutoSize = true;
    this.label46.BackColor = Color.Transparent;
    this.label46.ForeColor = Color.Black;
    this.label46.Location = new Point(32 /*0x20*/, 120);
    this.label46.Name = "label46";
    this.label46.Size = new Size(82, 16 /*0x10*/);
    this.label46.TabIndex = 4;
    this.label46.Text = "GL Short Name:";
    ((AppearanceBase) appearance18).BackColor = Color.White;
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryBankGLShortName).Appearance = (AppearanceBase) appearance18;
    ((Control) this.textPrimaryBankGLShortName).Location = new Point(136, 120);
    ((TextEditorControlBase) this.textPrimaryBankGLShortName).MaxLength = 15;
    this.textPrimaryBankGLShortName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryBankGLShortName).Name = "textPrimaryBankGLShortName";
    ((Control) this.textPrimaryBankGLShortName).Size = new Size(368, 20);
    ((Control) this.textPrimaryBankGLShortName).TabIndex = 5;
    ((AppearanceBase) appearance19).BackColor = Color.White;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance19).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryBankGLFullName).Appearance = (AppearanceBase) appearance19;
    ((Control) this.textPrimaryBankGLFullName).Location = new Point(136, 96 /*0x60*/);
    ((TextEditorControlBase) this.textPrimaryBankGLFullName).MaxLength = 100;
    this.textPrimaryBankGLFullName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryBankGLFullName).Name = "textPrimaryBankGLFullName";
    ((Control) this.textPrimaryBankGLFullName).Size = new Size(368, 20);
    ((Control) this.textPrimaryBankGLFullName).TabIndex = 3;
    this.label47.AutoSize = true;
    this.label47.BackColor = Color.Transparent;
    this.label47.ForeColor = Color.Black;
    this.label47.Location = new Point(32 /*0x20*/, 96 /*0x60*/);
    this.label47.Name = "label47";
    this.label47.Size = new Size(73, 16 /*0x10*/);
    this.label47.TabIndex = 2;
    this.label47.Text = "GL Full Name:";
    ((AppearanceBase) appearance20).BackColor = Color.White;
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryBankName).Appearance = (AppearanceBase) appearance20;
    ((Control) this.textPrimaryBankName).Location = new Point(136, 144 /*0x90*/);
    ((TextEditorControlBase) this.textPrimaryBankName).MaxLength = 100;
    this.textPrimaryBankName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryBankName).Name = "textPrimaryBankName";
    ((Control) this.textPrimaryBankName).Size = new Size(368, 20);
    ((Control) this.textPrimaryBankName).TabIndex = 7;
    this.addressPrimaryBankAddress.Address1 = "";
    this.addressPrimaryBankAddress.Address2 = "";
    this.addressPrimaryBankAddress.City = "";
    this.addressPrimaryBankAddress.County = "";
    ((Control) this.addressPrimaryBankAddress).Font = new Font("Tahoma", 8f);
    ((Control) this.addressPrimaryBankAddress).Location = new Point(272, 160 /*0xA0*/);
    this.addressPrimaryBankAddress.MGAStyle = MGAStyles.Blue;
    ((Control) this.addressPrimaryBankAddress).Name = "addressPrimaryBankAddress";
    this.addressPrimaryBankAddress.Password = (string) null;
    ((Control) this.addressPrimaryBankAddress).Size = new Size(240 /*0xF0*/, 152);
    this.addressPrimaryBankAddress.State = "";
    ((Control) this.addressPrimaryBankAddress).TabIndex = 21;
    this.addressPrimaryBankAddress.TextAlign = ContentAlignment.MiddleLeft;
    this.addressPrimaryBankAddress.UserID = (string) null;
    this.addressPrimaryBankAddress.WebserviceUrl = (string) null;
    this.addressPrimaryBankAddress.ZipCode = "";
    this.addressPrimaryBankAddress.ZipCodeExtension = "";
    this.label16.AutoSize = true;
    this.label16.BackColor = Color.Transparent;
    this.label16.ForeColor = Color.Black;
    this.label16.Location = new Point(32 /*0x20*/, 368);
    this.label16.Name = "label16";
    this.label16.Size = new Size(34, 16 /*0x10*/);
    this.label16.TabIndex = 25;
    this.label16.Text = "Email:";
    this.label19.AutoSize = true;
    this.label19.BackColor = Color.Transparent;
    this.label19.ForeColor = Color.Black;
    this.label19.Location = new Point(288, 368);
    this.label19.Name = "label19";
    this.label19.Size = new Size(25, 16 /*0x10*/);
    this.label19.TabIndex = 29;
    this.label19.Text = "Fax:";
    this.label20.AutoSize = true;
    this.label20.BackColor = Color.Transparent;
    this.label20.ForeColor = Color.Black;
    this.label20.Location = new Point(288, 344);
    this.label20.Name = "label20";
    this.label20.Size = new Size(38, 16 /*0x10*/);
    this.label20.TabIndex = 27;
    this.label20.Text = "Phone:";
    this.label21.AutoSize = true;
    this.label21.BackColor = Color.Transparent;
    this.label21.ForeColor = Color.Black;
    this.label21.Location = new Point(32 /*0x20*/, 344);
    this.label21.Name = "label21";
    this.label21.Size = new Size(36, 16 /*0x10*/);
    this.label21.TabIndex = 23;
    this.label21.Text = "Name:";
    this.label22.AutoSize = true;
    this.label22.BackColor = Color.Transparent;
    this.label22.Font = new Font("Tahoma", 8f, FontStyle.Underline);
    this.label22.ForeColor = Color.Black;
    this.label22.Location = new Point(32 /*0x20*/, 320);
    this.label22.Name = "label22";
    this.label22.Size = new Size(129, 16 /*0x10*/);
    this.label22.TabIndex = 22;
    this.label22.Text = "Bank Contact Information";
    this.label23.AutoSize = true;
    this.label23.BackColor = Color.Transparent;
    this.label23.ForeColor = Color.Black;
    this.label23.Location = new Point(32 /*0x20*/, 288);
    this.label23.Name = "label23";
    this.label23.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.label23.TabIndex = 19;
    this.label23.Text = "Deposit Slip Suffix:";
    this.label24.AutoSize = true;
    this.label24.BackColor = Color.Transparent;
    this.label24.ForeColor = Color.Black;
    this.label24.Location = new Point(32 /*0x20*/, 264);
    this.label24.Name = "label24";
    this.label24.Size = new Size(90, 16 /*0x10*/);
    this.label24.TabIndex = 17;
    this.label24.Text = "ABA Fractional #:";
    this.label25.AutoSize = true;
    this.label25.BackColor = Color.Transparent;
    this.label25.ForeColor = Color.Black;
    this.label25.Location = new Point(32 /*0x20*/, 240 /*0xF0*/);
    this.label25.Name = "label25";
    this.label25.Size = new Size(74, 16 /*0x10*/);
    this.label25.TabIndex = 14;
    this.label25.Text = "Next Check #:";
    ((AppearanceBase) appearance21).BackColor = Color.White;
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance21).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryABAFractional).Appearance = (AppearanceBase) appearance21;
    ((Control) this.textPrimaryABAFractional).Location = new Point(136, 264);
    ((TextEditorControlBase) this.textPrimaryABAFractional).MaxLength = 20;
    this.textPrimaryABAFractional.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryABAFractional).Name = "textPrimaryABAFractional";
    ((Control) this.textPrimaryABAFractional).Size = new Size(136, 20);
    ((Control) this.textPrimaryABAFractional).TabIndex = 18;
    this.numericPrimaryNextCheckNumber.BorderStyle = BorderStyle.FixedSingle;
    this.numericPrimaryNextCheckNumber.ForeColor = Color.Black;
    this.numericPrimaryNextCheckNumber.Location = new Point(160 /*0xA0*/, 240 /*0xF0*/);
    this.numericPrimaryNextCheckNumber.Maximum = new Decimal(new int[4]
    {
      999999999,
      0,
      0,
      0
    });
    this.numericPrimaryNextCheckNumber.Minimum = new Decimal(new int[4]
    {
      101,
      0,
      0,
      0
    });
    this.numericPrimaryNextCheckNumber.Name = "numericPrimaryNextCheckNumber";
    this.numericPrimaryNextCheckNumber.Size = new Size(72, 20);
    this.numericPrimaryNextCheckNumber.TabIndex = 16 /*0x10*/;
    this.numericPrimaryNextCheckNumber.TextAlign = HorizontalAlignment.Right;
    this.numericPrimaryNextCheckNumber.Value = new Decimal(new int[4]
    {
      101,
      0,
      0,
      0
    });
    this.checkPrimaryNextCheckNumber.Checked = true;
    this.checkPrimaryNextCheckNumber.CheckState = CheckState.Checked;
    this.checkPrimaryNextCheckNumber.FlatStyle = FlatStyle.Flat;
    this.checkPrimaryNextCheckNumber.Location = new Point(136, 240 /*0xF0*/);
    this.checkPrimaryNextCheckNumber.Name = "checkPrimaryNextCheckNumber";
    this.checkPrimaryNextCheckNumber.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.checkPrimaryNextCheckNumber.TabIndex = 15;
    this.label26.AutoSize = true;
    this.label26.BackColor = Color.Transparent;
    this.label26.ForeColor = Color.Black;
    this.label26.Location = new Point(32 /*0x20*/, 192 /*0xC0*/);
    this.label26.Name = "label26";
    this.label26.Size = new Size(88, 16 /*0x10*/);
    this.label26.TabIndex = 10;
    this.label26.Text = "Account Number:";
    this.label27.AutoSize = true;
    this.label27.BackColor = Color.Transparent;
    this.label27.ForeColor = Color.Black;
    this.label27.Location = new Point(32 /*0x20*/, 216);
    this.label27.Name = "label27";
    this.label27.Size = new Size(87, 16 /*0x10*/);
    this.label27.TabIndex = 12;
    this.label27.Text = "Routing Number:";
    this.label28.AutoSize = true;
    this.label28.BackColor = Color.Transparent;
    this.label28.ForeColor = Color.Black;
    this.label28.Location = new Point(32 /*0x20*/, 168);
    this.label28.Name = "label28";
    this.label28.Size = new Size(74, 16 /*0x10*/);
    this.label28.TabIndex = 8;
    this.label28.Text = "Account Type:";
    this.label29.AutoSize = true;
    this.label29.BackColor = Color.Transparent;
    this.label29.ForeColor = Color.Black;
    this.label29.Location = new Point(32 /*0x20*/, 144 /*0x90*/);
    this.label29.Name = "label29";
    this.label29.Size = new Size(63 /*0x3F*/, 16 /*0x10*/);
    this.label29.TabIndex = 6;
    this.label29.Text = "Bank Name:";
    ((AppearanceBase) appearance22).BackColor = Color.White;
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryBankContactFax).Appearance = (AppearanceBase) appearance22;
    ((Control) this.textPrimaryBankContactFax).Location = new Point(328, 368);
    ((TextEditorControlBase) this.textPrimaryBankContactFax).MaxLength = 20;
    this.textPrimaryBankContactFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryBankContactFax).Name = "textPrimaryBankContactFax";
    ((Control) this.textPrimaryBankContactFax).Size = new Size(176 /*0xB0*/, 20);
    ((Control) this.textPrimaryBankContactFax).TabIndex = 30;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryBankContactPhone).Appearance = (AppearanceBase) appearance23;
    ((Control) this.textPrimaryBankContactPhone).Location = new Point(328, 344);
    ((TextEditorControlBase) this.textPrimaryBankContactPhone).MaxLength = 20;
    this.textPrimaryBankContactPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryBankContactPhone).Name = "textPrimaryBankContactPhone";
    ((Control) this.textPrimaryBankContactPhone).Size = new Size(176 /*0xB0*/, 20);
    ((Control) this.textPrimaryBankContactPhone).TabIndex = 28;
    ((AppearanceBase) appearance24).BackColor = Color.White;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance24).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryBankContactEmail).Appearance = (AppearanceBase) appearance24;
    ((Control) this.textPrimaryBankContactEmail).Location = new Point(80 /*0x50*/, 368);
    ((TextEditorControlBase) this.textPrimaryBankContactEmail).MaxLength = 40;
    this.textPrimaryBankContactEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryBankContactEmail).Name = "textPrimaryBankContactEmail";
    ((Control) this.textPrimaryBankContactEmail).Size = new Size(184, 20);
    ((Control) this.textPrimaryBankContactEmail).TabIndex = 26;
    ((AppearanceBase) appearance25).BackColor = Color.White;
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance25).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryBankContactName).Appearance = (AppearanceBase) appearance25;
    ((Control) this.textPrimaryBankContactName).Location = new Point(80 /*0x50*/, 344);
    ((TextEditorControlBase) this.textPrimaryBankContactName).MaxLength = 25;
    this.textPrimaryBankContactName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryBankContactName).Name = "textPrimaryBankContactName";
    ((Control) this.textPrimaryBankContactName).Size = new Size(184, 20);
    ((Control) this.textPrimaryBankContactName).TabIndex = 24;
    ((AppearanceBase) appearance26).BackColor = Color.White;
    ((AppearanceBase) appearance26).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance26).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryDepositSlipSuffix).Appearance = (AppearanceBase) appearance26;
    ((Control) this.textPrimaryDepositSlipSuffix).Location = new Point(136, 288);
    ((TextEditorControlBase) this.textPrimaryDepositSlipSuffix).MaxLength = 5;
    this.textPrimaryDepositSlipSuffix.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryDepositSlipSuffix).Name = "textPrimaryDepositSlipSuffix";
    ((Control) this.textPrimaryDepositSlipSuffix).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.textPrimaryDepositSlipSuffix).TabIndex = 20;
    ((AppearanceBase) appearance27).BackColor = Color.White;
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryABARoutingNumber).Appearance = (AppearanceBase) appearance27;
    ((Control) this.textPrimaryABARoutingNumber).Location = new Point(136, 216);
    ((TextEditorControlBase) this.textPrimaryABARoutingNumber).MaxLength = 9;
    this.textPrimaryABARoutingNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryABARoutingNumber).Name = "textPrimaryABARoutingNumber";
    ((Control) this.textPrimaryABARoutingNumber).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.textPrimaryABARoutingNumber).TabIndex = 13;
    ((AppearanceBase) appearance28).BackColor = Color.White;
    ((AppearanceBase) appearance28).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance28).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPrimaryAccountNumber).Appearance = (AppearanceBase) appearance28;
    ((Control) this.textPrimaryAccountNumber).Location = new Point(136, 192 /*0xC0*/);
    ((TextEditorControlBase) this.textPrimaryAccountNumber).MaxLength = 25;
    this.textPrimaryAccountNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPrimaryAccountNumber).Name = "textPrimaryAccountNumber";
    ((Control) this.textPrimaryAccountNumber).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.textPrimaryAccountNumber).TabIndex = 11;
    this.comboPrimaryAccountType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboPrimaryAccountType.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboPrimaryAccountType).DataMember = "BankAccountTypes";
    ((UltraGridBase) this.comboPrimaryAccountType).DataSource = (object) this.dsBankAccountTypes1;
    ((UltraDropDownBase) this.comboPrimaryAccountType).DisplayMember = "BankAcctType";
    this.comboPrimaryAccountType.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboPrimaryAccountType).DropDownWidth = 150;
    ((Control) this.comboPrimaryAccountType).Location = new Point(136, 168);
    this.comboPrimaryAccountType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPrimaryAccountType).Name = "comboPrimaryAccountType";
    ((Control) this.comboPrimaryAccountType).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.comboPrimaryAccountType).TabIndex = 9;
    ((UltraDropDownBase) this.comboPrimaryAccountType).ValueMember = "BankAcctTypeId";
    this.dsBankAccountTypes1.DataSetName = "dsBankAccountTypes";
    this.dsBankAccountTypes1.Locale = new CultureInfo("en-US");
    this.label17.AutoSize = true;
    this.label17.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label17.Location = new Point(32 /*0x20*/, 16 /*0x10*/);
    this.label17.Name = "label17";
    this.label17.Size = new Size(197, 18);
    this.label17.TabIndex = 0;
    this.label17.Text = "Primary Bank Account Settings";
    this.label18.Location = new Point(32 /*0x20*/, 40);
    this.label18.Name = "label18";
    this.label18.Size = new Size(464, 40);
    this.label18.TabIndex = 1;
    this.label18.Text = "Please specify the primary bank account information that will be used with this office location. The primary bank account can be overriden by users with the proper permissions at the time of posting.";
    this.panelOperatingBank.Controls.Add((Control) this.label45);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingBankGLShortName);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingBankGLFullName);
    this.panelOperatingBank.Controls.Add((Control) this.label44);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingBankName);
    this.panelOperatingBank.Controls.Add((Control) this.addressOperatingBankAddress);
    this.panelOperatingBank.Controls.Add((Control) this.label30);
    this.panelOperatingBank.Controls.Add((Control) this.label31);
    this.panelOperatingBank.Controls.Add((Control) this.label32);
    this.panelOperatingBank.Controls.Add((Control) this.label33);
    this.panelOperatingBank.Controls.Add((Control) this.label34);
    this.panelOperatingBank.Controls.Add((Control) this.label35);
    this.panelOperatingBank.Controls.Add((Control) this.label36);
    this.panelOperatingBank.Controls.Add((Control) this.label37);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingABAFractional);
    this.panelOperatingBank.Controls.Add((Control) this.numericOperatingNextCheckNumber);
    this.panelOperatingBank.Controls.Add((Control) this.checkOperatingNextCheckNumber);
    this.panelOperatingBank.Controls.Add((Control) this.label38);
    this.panelOperatingBank.Controls.Add((Control) this.label39);
    this.panelOperatingBank.Controls.Add((Control) this.label40);
    this.panelOperatingBank.Controls.Add((Control) this.label41);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingtBankContactFax);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingBankContactPhone);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingBankContactEmail);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingBankContactName);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingDepositSlipSuffix);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingABARoutingNumber);
    this.panelOperatingBank.Controls.Add((Control) this.textOperatingAccountNumber);
    this.panelOperatingBank.Controls.Add((Control) this.comboOperatingAccountType);
    this.panelOperatingBank.Controls.Add((Control) this.label42);
    this.panelOperatingBank.Controls.Add((Control) this.label43);
    this.panelOperatingBank.Dock = DockStyle.Fill;
    this.panelOperatingBank.Location = new Point(0, 0);
    this.panelOperatingBank.Name = "panelOperatingBank";
    this.panelOperatingBank.Size = new Size(746, 552);
    this.panelOperatingBank.TabIndex = 20;
    this.label45.AutoSize = true;
    this.label45.BackColor = Color.Transparent;
    this.label45.ForeColor = Color.Black;
    this.label45.Location = new Point(32 /*0x20*/, 120);
    this.label45.Name = "label45";
    this.label45.Size = new Size(82, 16 /*0x10*/);
    this.label45.TabIndex = 4;
    this.label45.Text = "GL Short Name:";
    ((AppearanceBase) appearance29).BackColor = Color.White;
    ((AppearanceBase) appearance29).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance29).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingBankGLShortName).Appearance = (AppearanceBase) appearance29;
    ((Control) this.textOperatingBankGLShortName).Location = new Point(136, 120);
    ((TextEditorControlBase) this.textOperatingBankGLShortName).MaxLength = 15;
    this.textOperatingBankGLShortName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingBankGLShortName).Name = "textOperatingBankGLShortName";
    ((Control) this.textOperatingBankGLShortName).Size = new Size(360, 20);
    ((Control) this.textOperatingBankGLShortName).TabIndex = 5;
    ((AppearanceBase) appearance30).BackColor = Color.White;
    ((AppearanceBase) appearance30).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance30).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingBankGLFullName).Appearance = (AppearanceBase) appearance30;
    ((Control) this.textOperatingBankGLFullName).Location = new Point(136, 96 /*0x60*/);
    ((TextEditorControlBase) this.textOperatingBankGLFullName).MaxLength = 100;
    this.textOperatingBankGLFullName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingBankGLFullName).Name = "textOperatingBankGLFullName";
    ((Control) this.textOperatingBankGLFullName).Size = new Size(360, 20);
    ((Control) this.textOperatingBankGLFullName).TabIndex = 3;
    this.label44.AutoSize = true;
    this.label44.BackColor = Color.Transparent;
    this.label44.ForeColor = Color.Black;
    this.label44.Location = new Point(32 /*0x20*/, 96 /*0x60*/);
    this.label44.Name = "label44";
    this.label44.Size = new Size(73, 16 /*0x10*/);
    this.label44.TabIndex = 2;
    this.label44.Text = "GL Full Name:";
    ((AppearanceBase) appearance31).BackColor = Color.White;
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance31).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingBankName).Appearance = (AppearanceBase) appearance31;
    ((Control) this.textOperatingBankName).Location = new Point(136, 144 /*0x90*/);
    ((TextEditorControlBase) this.textOperatingBankName).MaxLength = 100;
    this.textOperatingBankName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingBankName).Name = "textOperatingBankName";
    ((Control) this.textOperatingBankName).Size = new Size(360, 20);
    ((Control) this.textOperatingBankName).TabIndex = 7;
    this.addressOperatingBankAddress.Address1 = "";
    this.addressOperatingBankAddress.Address2 = "";
    this.addressOperatingBankAddress.City = "";
    this.addressOperatingBankAddress.County = "";
    ((Control) this.addressOperatingBankAddress).Font = new Font("Tahoma", 8f);
    ((Control) this.addressOperatingBankAddress).Location = new Point(264, 160 /*0xA0*/);
    this.addressOperatingBankAddress.MGAStyle = MGAStyles.Blue;
    ((Control) this.addressOperatingBankAddress).Name = "addressOperatingBankAddress";
    this.addressOperatingBankAddress.Password = (string) null;
    ((Control) this.addressOperatingBankAddress).Size = new Size(240 /*0xF0*/, 152);
    this.addressOperatingBankAddress.State = "";
    ((Control) this.addressOperatingBankAddress).TabIndex = 21;
    this.addressOperatingBankAddress.TextAlign = ContentAlignment.MiddleLeft;
    this.addressOperatingBankAddress.UserID = (string) null;
    this.addressOperatingBankAddress.WebserviceUrl = (string) null;
    this.addressOperatingBankAddress.ZipCode = "";
    this.addressOperatingBankAddress.ZipCodeExtension = "";
    this.label30.AutoSize = true;
    this.label30.BackColor = Color.Transparent;
    this.label30.ForeColor = Color.Black;
    this.label30.Location = new Point(32 /*0x20*/, 368);
    this.label30.Name = "label30";
    this.label30.Size = new Size(34, 16 /*0x10*/);
    this.label30.TabIndex = 25;
    this.label30.Text = "Email:";
    this.label31.AutoSize = true;
    this.label31.BackColor = Color.Transparent;
    this.label31.ForeColor = Color.Black;
    this.label31.Location = new Point(280, 368);
    this.label31.Name = "label31";
    this.label31.Size = new Size(25, 16 /*0x10*/);
    this.label31.TabIndex = 29;
    this.label31.Text = "Fax:";
    this.label32.AutoSize = true;
    this.label32.BackColor = Color.Transparent;
    this.label32.ForeColor = Color.Black;
    this.label32.Location = new Point(280, 344);
    this.label32.Name = "label32";
    this.label32.Size = new Size(38, 16 /*0x10*/);
    this.label32.TabIndex = 27;
    this.label32.Text = "Phone:";
    this.label33.AutoSize = true;
    this.label33.BackColor = Color.Transparent;
    this.label33.ForeColor = Color.Black;
    this.label33.Location = new Point(32 /*0x20*/, 344);
    this.label33.Name = "label33";
    this.label33.Size = new Size(36, 16 /*0x10*/);
    this.label33.TabIndex = 23;
    this.label33.Text = "Name:";
    this.label34.AutoSize = true;
    this.label34.BackColor = Color.Transparent;
    this.label34.Font = new Font("Tahoma", 8f, FontStyle.Underline);
    this.label34.ForeColor = Color.Black;
    this.label34.Location = new Point(32 /*0x20*/, 320);
    this.label34.Name = "label34";
    this.label34.Size = new Size(129, 16 /*0x10*/);
    this.label34.TabIndex = 22;
    this.label34.Text = "Bank Contact Information";
    this.label35.AutoSize = true;
    this.label35.BackColor = Color.Transparent;
    this.label35.ForeColor = Color.Black;
    this.label35.Location = new Point(32 /*0x20*/, 288);
    this.label35.Name = "label35";
    this.label35.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.label35.TabIndex = 19;
    this.label35.Text = "Deposit Slip Suffix:";
    this.label36.AutoSize = true;
    this.label36.BackColor = Color.Transparent;
    this.label36.ForeColor = Color.Black;
    this.label36.Location = new Point(32 /*0x20*/, 264);
    this.label36.Name = "label36";
    this.label36.Size = new Size(90, 16 /*0x10*/);
    this.label36.TabIndex = 17;
    this.label36.Text = "ABA Fractional #:";
    this.label37.AutoSize = true;
    this.label37.BackColor = Color.Transparent;
    this.label37.ForeColor = Color.Black;
    this.label37.Location = new Point(32 /*0x20*/, 240 /*0xF0*/);
    this.label37.Name = "label37";
    this.label37.Size = new Size(74, 16 /*0x10*/);
    this.label37.TabIndex = 14;
    this.label37.Text = "Next Check #:";
    ((AppearanceBase) appearance32).BackColor = Color.White;
    ((AppearanceBase) appearance32).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance32).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingABAFractional).Appearance = (AppearanceBase) appearance32;
    ((Control) this.textOperatingABAFractional).Location = new Point(136, 264);
    ((TextEditorControlBase) this.textOperatingABAFractional).MaxLength = 20;
    this.textOperatingABAFractional.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingABAFractional).Name = "textOperatingABAFractional";
    ((Control) this.textOperatingABAFractional).Size = new Size(128 /*0x80*/, 20);
    ((Control) this.textOperatingABAFractional).TabIndex = 18;
    this.numericOperatingNextCheckNumber.BorderStyle = BorderStyle.FixedSingle;
    this.numericOperatingNextCheckNumber.ForeColor = Color.Black;
    this.numericOperatingNextCheckNumber.Location = new Point(160 /*0xA0*/, 240 /*0xF0*/);
    this.numericOperatingNextCheckNumber.Maximum = new Decimal(new int[4]
    {
      999999999,
      0,
      0,
      0
    });
    this.numericOperatingNextCheckNumber.Minimum = new Decimal(new int[4]
    {
      101,
      0,
      0,
      0
    });
    this.numericOperatingNextCheckNumber.Name = "numericOperatingNextCheckNumber";
    this.numericOperatingNextCheckNumber.Size = new Size(72, 20);
    this.numericOperatingNextCheckNumber.TabIndex = 16 /*0x10*/;
    this.numericOperatingNextCheckNumber.TextAlign = HorizontalAlignment.Right;
    this.numericOperatingNextCheckNumber.Value = new Decimal(new int[4]
    {
      101,
      0,
      0,
      0
    });
    this.checkOperatingNextCheckNumber.Checked = true;
    this.checkOperatingNextCheckNumber.CheckState = CheckState.Checked;
    this.checkOperatingNextCheckNumber.FlatStyle = FlatStyle.Flat;
    this.checkOperatingNextCheckNumber.Location = new Point(136, 240 /*0xF0*/);
    this.checkOperatingNextCheckNumber.Name = "checkOperatingNextCheckNumber";
    this.checkOperatingNextCheckNumber.Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.checkOperatingNextCheckNumber.TabIndex = 15;
    this.label38.AutoSize = true;
    this.label38.BackColor = Color.Transparent;
    this.label38.ForeColor = Color.Black;
    this.label38.Location = new Point(32 /*0x20*/, 192 /*0xC0*/);
    this.label38.Name = "label38";
    this.label38.Size = new Size(88, 16 /*0x10*/);
    this.label38.TabIndex = 10;
    this.label38.Text = "Account Number:";
    this.label39.AutoSize = true;
    this.label39.BackColor = Color.Transparent;
    this.label39.ForeColor = Color.Black;
    this.label39.Location = new Point(32 /*0x20*/, 216);
    this.label39.Name = "label39";
    this.label39.Size = new Size(87, 16 /*0x10*/);
    this.label39.TabIndex = 12;
    this.label39.Text = "Routing Number:";
    this.label40.AutoSize = true;
    this.label40.BackColor = Color.Transparent;
    this.label40.ForeColor = Color.Black;
    this.label40.Location = new Point(32 /*0x20*/, 168);
    this.label40.Name = "label40";
    this.label40.Size = new Size(74, 16 /*0x10*/);
    this.label40.TabIndex = 8;
    this.label40.Text = "Account Type:";
    this.label41.AutoSize = true;
    this.label41.BackColor = Color.Transparent;
    this.label41.ForeColor = Color.Black;
    this.label41.Location = new Point(32 /*0x20*/, 144 /*0x90*/);
    this.label41.Name = "label41";
    this.label41.Size = new Size(63 /*0x3F*/, 16 /*0x10*/);
    this.label41.TabIndex = 6;
    this.label41.Text = "Bank Name:";
    ((AppearanceBase) appearance33).BackColor = Color.White;
    ((AppearanceBase) appearance33).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance33).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingtBankContactFax).Appearance = (AppearanceBase) appearance33;
    ((Control) this.textOperatingtBankContactFax).Location = new Point(320, 368);
    ((TextEditorControlBase) this.textOperatingtBankContactFax).MaxLength = 20;
    this.textOperatingtBankContactFax.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingtBankContactFax).Name = "textOperatingtBankContactFax";
    ((Control) this.textOperatingtBankContactFax).Size = new Size(168, 20);
    ((Control) this.textOperatingtBankContactFax).TabIndex = 30;
    ((AppearanceBase) appearance34).BackColor = Color.White;
    ((AppearanceBase) appearance34).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance34).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingBankContactPhone).Appearance = (AppearanceBase) appearance34;
    ((Control) this.textOperatingBankContactPhone).Location = new Point(320, 344);
    ((TextEditorControlBase) this.textOperatingBankContactPhone).MaxLength = 20;
    this.textOperatingBankContactPhone.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingBankContactPhone).Name = "textOperatingBankContactPhone";
    ((Control) this.textOperatingBankContactPhone).Size = new Size(168, 20);
    ((Control) this.textOperatingBankContactPhone).TabIndex = 28;
    ((AppearanceBase) appearance35).BackColor = Color.White;
    ((AppearanceBase) appearance35).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance35).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingBankContactEmail).Appearance = (AppearanceBase) appearance35;
    ((Control) this.textOperatingBankContactEmail).Location = new Point(80 /*0x50*/, 368);
    ((TextEditorControlBase) this.textOperatingBankContactEmail).MaxLength = 40;
    this.textOperatingBankContactEmail.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingBankContactEmail).Name = "textOperatingBankContactEmail";
    ((Control) this.textOperatingBankContactEmail).Size = new Size(184, 20);
    ((Control) this.textOperatingBankContactEmail).TabIndex = 26;
    ((AppearanceBase) appearance36).BackColor = Color.White;
    ((AppearanceBase) appearance36).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance36).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingBankContactName).Appearance = (AppearanceBase) appearance36;
    ((Control) this.textOperatingBankContactName).Location = new Point(80 /*0x50*/, 344);
    ((TextEditorControlBase) this.textOperatingBankContactName).MaxLength = 25;
    this.textOperatingBankContactName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingBankContactName).Name = "textOperatingBankContactName";
    ((Control) this.textOperatingBankContactName).Size = new Size(184, 20);
    ((Control) this.textOperatingBankContactName).TabIndex = 24;
    ((AppearanceBase) appearance37).BackColor = Color.White;
    ((AppearanceBase) appearance37).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance37).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingDepositSlipSuffix).Appearance = (AppearanceBase) appearance37;
    ((Control) this.textOperatingDepositSlipSuffix).Location = new Point(136, 288);
    ((TextEditorControlBase) this.textOperatingDepositSlipSuffix).MaxLength = 5;
    this.textOperatingDepositSlipSuffix.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingDepositSlipSuffix).Name = "textOperatingDepositSlipSuffix";
    ((Control) this.textOperatingDepositSlipSuffix).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.textOperatingDepositSlipSuffix).TabIndex = 20;
    ((AppearanceBase) appearance38).BackColor = Color.White;
    ((AppearanceBase) appearance38).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance38).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingABARoutingNumber).Appearance = (AppearanceBase) appearance38;
    ((Control) this.textOperatingABARoutingNumber).Location = new Point(136, 216);
    ((TextEditorControlBase) this.textOperatingABARoutingNumber).MaxLength = 9;
    this.textOperatingABARoutingNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingABARoutingNumber).Name = "textOperatingABARoutingNumber";
    ((Control) this.textOperatingABARoutingNumber).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.textOperatingABARoutingNumber).TabIndex = 13;
    ((AppearanceBase) appearance39).BackColor = Color.White;
    ((AppearanceBase) appearance39).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance39).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textOperatingAccountNumber).Appearance = (AppearanceBase) appearance39;
    ((Control) this.textOperatingAccountNumber).Location = new Point(136, 192 /*0xC0*/);
    ((TextEditorControlBase) this.textOperatingAccountNumber).MaxLength = 25;
    this.textOperatingAccountNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textOperatingAccountNumber).Name = "textOperatingAccountNumber";
    ((Control) this.textOperatingAccountNumber).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.textOperatingAccountNumber).TabIndex = 11;
    this.comboOperatingAccountType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOperatingAccountType.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboOperatingAccountType).DataMember = "BankAccountTypes";
    ((UltraGridBase) this.comboOperatingAccountType).DataSource = (object) this.dsBankAccountTypes2;
    ((UltraDropDownBase) this.comboOperatingAccountType).DisplayMember = "BankAcctType";
    this.comboOperatingAccountType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOperatingAccountType).Location = new Point(136, 168);
    this.comboOperatingAccountType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOperatingAccountType).Name = "comboOperatingAccountType";
    ((Control) this.comboOperatingAccountType).Size = new Size(96 /*0x60*/, 20);
    ((Control) this.comboOperatingAccountType).TabIndex = 9;
    ((UltraDropDownBase) this.comboOperatingAccountType).ValueMember = "BankAcctTypeId";
    this.dsBankAccountTypes2.DataSetName = "dsBankAccountTypes";
    this.dsBankAccountTypes2.Locale = new CultureInfo("en-US");
    this.label42.AutoSize = true;
    this.label42.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label42.Location = new Point(32 /*0x20*/, 16 /*0x10*/);
    this.label42.Name = "label42";
    this.label42.Size = new Size(210, 18);
    this.label42.TabIndex = 0;
    this.label42.Text = "Operating Bank Account Settings";
    this.label43.Location = new Point(32 /*0x20*/, 40);
    this.label43.Name = "label43";
    this.label43.Size = new Size(464, 40);
    this.label43.TabIndex = 1;
    this.label43.Text = "Please specify the operating bank account information that will be used with this office location. The operating bank account can be overriden by users with the proper permissions at the time of posting.";
    this.panelCashOrAccrual.Controls.Add((Control) this.radioAccrualBasis);
    this.panelCashOrAccrual.Controls.Add((Control) this.radioCashBasis);
    this.panelCashOrAccrual.Controls.Add((Control) this.label49);
    this.panelCashOrAccrual.Controls.Add((Control) this.label62);
    this.panelCashOrAccrual.Controls.Add((Control) this.label63);
    this.panelCashOrAccrual.Dock = DockStyle.Fill;
    this.panelCashOrAccrual.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.panelCashOrAccrual.Name = "panelCashOrAccrual";
    this.panelCashOrAccrual.Size = new Size(522, 416);
    this.panelCashOrAccrual.TabIndex = 21;
    this.radioAccrualBasis.FlatStyle = FlatStyle.Flat;
    this.radioAccrualBasis.Location = new Point(96 /*0x60*/, 192 /*0xC0*/);
    this.radioAccrualBasis.Name = "radioAccrualBasis";
    this.radioAccrualBasis.Size = new Size(264, 24);
    this.radioAccrualBasis.TabIndex = 3;
    this.radioAccrualBasis.Text = "This chart of accounts is on a ACCRUAL basis.";
    this.radioCashBasis.FlatStyle = FlatStyle.Flat;
    this.radioCashBasis.Location = new Point(96 /*0x60*/, 160 /*0xA0*/);
    this.radioCashBasis.Name = "radioCashBasis";
    this.radioCashBasis.Size = new Size(264, 24);
    this.radioCashBasis.TabIndex = 2;
    this.radioCashBasis.Text = "This chart of accounts is on a CASH basis.";
    this.label49.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label49.ForeColor = Color.Red;
    this.label49.Location = new Point(24, 360);
    this.label49.Name = "label49";
    this.label49.Size = new Size(464, 32 /*0x20*/);
    this.label49.TabIndex = 4;
    this.label49.Text = "NOTE: This setting is a accounting framework setting for the specified chart of accounts and can not be changed after it has been saved.";
    this.label62.AutoSize = true;
    this.label62.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label62.Location = new Point(32 /*0x20*/, 16 /*0x10*/);
    this.label62.Name = "label62";
    this.label62.Size = new Size(109, 18);
    this.label62.TabIndex = 0;
    this.label62.Text = "Cash Or Accrual?";
    this.label63.Location = new Point(32 /*0x20*/, 40);
    this.label63.Name = "label63";
    this.label63.Size = new Size(464, 32 /*0x20*/);
    this.label63.TabIndex = 1;
    this.label63.Text = "Please specify your GL companies accounting methodology. This important setting will determine when the accounting system will recognize commissions for this chart of accounts. ";
    this.panelPostTiming.Controls.Add((Control) this.radioUseEffectiveDate);
    this.panelPostTiming.Controls.Add((Control) this.radioUseBillingdate);
    this.panelPostTiming.Controls.Add((Control) this.label58);
    this.panelPostTiming.Controls.Add((Control) this.label50);
    this.panelPostTiming.Dock = DockStyle.Fill;
    this.panelPostTiming.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.panelPostTiming.Name = "panelPostTiming";
    this.panelPostTiming.Size = new Size(522, 416);
    this.panelPostTiming.TabIndex = 24;
    this.radioUseEffectiveDate.FlatStyle = FlatStyle.Flat;
    this.radioUseEffectiveDate.Location = new Point(104, 176 /*0xB0*/);
    this.radioUseEffectiveDate.Name = "radioUseEffectiveDate";
    this.radioUseEffectiveDate.Size = new Size(264, 24);
    this.radioUseEffectiveDate.TabIndex = 3;
    this.radioUseEffectiveDate.Text = "I prefer to use the EFFECTIVE date of coverage.";
    this.radioUseBillingdate.FlatStyle = FlatStyle.Flat;
    this.radioUseBillingdate.Location = new Point(104, 144 /*0x90*/);
    this.radioUseBillingdate.Name = "radioUseBillingdate";
    this.radioUseBillingdate.Size = new Size(208 /*0xD0*/, 24);
    this.radioUseBillingdate.TabIndex = 2;
    this.radioUseBillingdate.Text = "I prefer to use the BILLING date.";
    this.label58.Location = new Point(32 /*0x20*/, 56);
    this.label58.Name = "label58";
    this.label58.Size = new Size(472, 40);
    this.label58.TabIndex = 1;
    this.label58.Text = "Specify whether you would prefer the system to use the billing date of the invoice or the effective date of coverage as the posting date of the invoice transactions in the ledger.";
    this.label50.AutoSize = true;
    this.label50.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label50.Location = new Point(32 /*0x20*/, 24);
    this.label50.Name = "label50";
    this.label50.Size = new Size(211, 18);
    this.label50.TabIndex = 0;
    this.label50.Text = "Invoice Posting Date Preferences";
    this.panelCommissionReconciliation.Controls.Add((Control) this.label51);
    this.panelCommissionReconciliation.Controls.Add((Control) this.label57);
    this.panelCommissionReconciliation.Controls.Add((Control) this.panel4);
    this.panelCommissionReconciliation.Controls.Add((Control) this.panel3);
    this.panelCommissionReconciliation.Controls.Add((Control) this.label48);
    this.panelCommissionReconciliation.Controls.Add((Control) this.label52);
    this.panelCommissionReconciliation.Dock = DockStyle.Fill;
    this.panelCommissionReconciliation.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.panelCommissionReconciliation.Name = "panelCommissionReconciliation";
    this.panelCommissionReconciliation.Size = new Size(522, 416);
    this.panelCommissionReconciliation.TabIndex = 23;
    this.label51.Location = new Point(32 /*0x20*/, 48 /*0x30*/);
    this.label51.Name = "label51";
    this.label51.Size = new Size(472, 32 /*0x20*/);
    this.label51.TabIndex = 1;
    this.label51.Text = "Specify whether this chart of accounts should recoginize commissions at the time of receivables or payables.";
    this.label57.AutoSize = true;
    this.label57.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label57.Location = new Point(16 /*0x10*/, 224 /*0xE0*/);
    this.label57.Name = "label57";
    this.label57.Size = new Size(226, 18);
    this.label57.TabIndex = 3;
    this.label57.Text = "Commission Reconciliation Settings";
    this.panel4.Controls.Add((Control) this.radioFully);
    this.panel4.Controls.Add((Control) this.radioProportionally);
    this.panel4.Location = new Point(136, 304);
    this.panel4.Name = "panel4";
    this.panel4.Size = new Size(208 /*0xD0*/, 72);
    this.panel4.TabIndex = 5;
    this.radioFully.FlatStyle = FlatStyle.Flat;
    this.radioFully.Location = new Point(8, 40);
    this.radioFully.Name = "radioFully";
    this.radioFully.Size = new Size(168, 24);
    this.radioFully.TabIndex = 1;
    this.radioFully.Text = "Reconcile commission fully.";
    this.radioProportionally.FlatStyle = FlatStyle.Flat;
    this.radioProportionally.Location = new Point(8, 8);
    this.radioProportionally.Name = "radioProportionally";
    this.radioProportionally.Size = new Size(224 /*0xE0*/, 24);
    this.radioProportionally.TabIndex = 0;
    this.radioProportionally.Text = "Reconcile commission proportionally.";
    this.panel3.Controls.Add((Control) this.radioReconPayables);
    this.panel3.Controls.Add((Control) this.radioReconReceivables);
    this.panel3.Location = new Point(136, 96 /*0x60*/);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(272, 88);
    this.panel3.TabIndex = 2;
    this.radioReconPayables.FlatStyle = FlatStyle.Flat;
    this.radioReconPayables.Location = new Point(8, 48 /*0x30*/);
    this.radioReconPayables.Name = "radioReconPayables";
    this.radioReconPayables.Size = new Size(264, 24);
    this.radioReconPayables.TabIndex = 1;
    this.radioReconPayables.Text = "Recognize commission at the time of payables.";
    this.radioReconReceivables.FlatStyle = FlatStyle.Flat;
    this.radioReconReceivables.Location = new Point(8, 16 /*0x10*/);
    this.radioReconReceivables.Name = "radioReconReceivables";
    this.radioReconReceivables.Size = new Size(264, 24);
    this.radioReconReceivables.TabIndex = 0;
    this.radioReconReceivables.Text = "Recognize commission at the time of receivables.";
    this.label48.AutoSize = true;
    this.label48.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label48.Location = new Point(32 /*0x20*/, 24);
    this.label48.Name = "label48";
    this.label48.Size = new Size(226, 18);
    this.label48.TabIndex = 0;
    this.label48.Text = "Commission Reconciliation Settings";
    this.label52.Location = new Point(16 /*0x10*/, 256 /*0x0100*/);
    this.label52.Name = "label52";
    this.label52.Size = new Size(480, 32 /*0x20*/);
    this.label52.TabIndex = 4;
    this.label52.Text = "Specify whether this chart of accounts should reconcile commissions proportionally based on the AR received or fully.";
    this.panelWriteOffThreshold.Controls.Add((Control) this.textPayableWriteOffThreshold);
    this.panelWriteOffThreshold.Controls.Add((Control) this.label56);
    this.panelWriteOffThreshold.Controls.Add((Control) this.textReceivableWriteOffThreshold);
    this.panelWriteOffThreshold.Controls.Add((Control) this.label55);
    this.panelWriteOffThreshold.Controls.Add((Control) this.label53);
    this.panelWriteOffThreshold.Controls.Add((Control) this.label54);
    this.panelWriteOffThreshold.Dock = DockStyle.Fill;
    this.panelWriteOffThreshold.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.panelWriteOffThreshold.Name = "panelWriteOffThreshold";
    this.panelWriteOffThreshold.Size = new Size(522, 416);
    this.panelWriteOffThreshold.TabIndex = 22;
    ((AppearanceBase) appearance40).BackColor = Color.White;
    ((AppearanceBase) appearance40).BorderColor = Color.Gray;
    ((AppearanceBase) appearance40).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPayableWriteOffThreshold).Appearance = (AppearanceBase) appearance40;
    ((Control) this.textPayableWriteOffThreshold).Location = new Point(136, 240 /*0xF0*/);
    ((Control) this.textPayableWriteOffThreshold).Name = "textPayableWriteOffThreshold";
    ((Control) this.textPayableWriteOffThreshold).Size = new Size(232, 20);
    ((Control) this.textPayableWriteOffThreshold).TabIndex = 5;
    this.label56.AutoSize = true;
    this.label56.Location = new Point(136, 224 /*0xE0*/);
    this.label56.Name = "label56";
    this.label56.Size = new Size(88, 16 /*0x10*/);
    this.label56.TabIndex = 4;
    this.label56.Text = "Accounts Payable";
    ((AppearanceBase) appearance41).BackColor = Color.White;
    ((AppearanceBase) appearance41).BorderColor = Color.Gray;
    ((AppearanceBase) appearance41).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textReceivableWriteOffThreshold).Appearance = (AppearanceBase) appearance41;
    ((Control) this.textReceivableWriteOffThreshold).Location = new Point(136, 192 /*0xC0*/);
    ((Control) this.textReceivableWriteOffThreshold).Name = "textReceivableWriteOffThreshold";
    ((Control) this.textReceivableWriteOffThreshold).Size = new Size(232, 20);
    ((Control) this.textReceivableWriteOffThreshold).TabIndex = 3;
    this.label55.AutoSize = true;
    this.label55.Location = new Point(136, 176 /*0xB0*/);
    this.label55.Name = "label55";
    this.label55.Size = new Size(103, 16 /*0x10*/);
    this.label55.TabIndex = 2;
    this.label55.Text = "Accounts Receivable";
    this.label53.AutoSize = true;
    this.label53.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label53.Location = new Point(32 /*0x20*/, 24);
    this.label53.Name = "label53";
    this.label53.Size = new Size(135, 18);
    this.label53.TabIndex = 0;
    this.label53.Text = "Write-Off Thresholds";
    this.label54.Location = new Point(32 /*0x20*/, 64 /*0x40*/);
    this.label54.Name = "label54";
    this.label54.Size = new Size(464, 32 /*0x20*/);
    this.label54.TabIndex = 1;
    this.label54.Text = "Specify the amount of a receivable and payable respectively, users with security rights can write-off without administrative override. ";
    this.panelConfirmation.Controls.Add((Control) this.panelProcessing);
    this.panelConfirmation.Controls.Add((Control) this.panelSettingsBreakout);
    this.panelConfirmation.Controls.Add((Control) this.label65);
    this.panelConfirmation.Controls.Add((Control) this.label64);
    this.panelConfirmation.Controls.Add((Control) this.label61);
    this.panelConfirmation.Controls.Add((Control) this.label60);
    this.panelConfirmation.Controls.Add((Control) this.label59);
    this.panelConfirmation.Dock = DockStyle.Fill;
    this.panelConfirmation.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.panelConfirmation.Name = "panelConfirmation";
    this.panelConfirmation.Size = new Size(522, 416);
    this.panelConfirmation.TabIndex = 25;
    this.panelProcessing.Controls.Add((Control) this.labelProgress);
    this.panelProcessing.Controls.Add((Control) this.progressProcessing);
    this.panelProcessing.Controls.Add((Control) this.labelProgressHeader);
    this.panelProcessing.Location = new Point(40, 288);
    this.panelProcessing.Name = "panelProcessing";
    this.panelProcessing.Size = new Size(440, 64 /*0x40*/);
    this.panelProcessing.TabIndex = 8;
    this.panelProcessing.Visible = false;
    this.labelProgress.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.labelProgress.Location = new Point(240 /*0xF0*/, 40);
    this.labelProgress.Name = "labelProgress";
    this.labelProgress.Size = new Size(192 /*0xC0*/, 16 /*0x10*/);
    this.labelProgress.TabIndex = 8;
    this.labelProgress.Text = "Generating Chart Of Accounts...";
    this.labelProgress.TextAlign = ContentAlignment.MiddleRight;
    ((AppearanceBase) appearance42).ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.progressProcessing.FillAppearance = (AppearanceBase) appearance42;
    ((Control) this.progressProcessing).Location = new Point(8, 24);
    this.progressProcessing.Maximum = 13;
    ((Control) this.progressProcessing).Name = "progressProcessing";
    ((Control) this.progressProcessing).Size = new Size(424, 16 /*0x10*/);
    ((Control) this.progressProcessing).TabIndex = 6;
    ((Control) this.progressProcessing).Text = "[Formatted]";
    this.labelProgressHeader.AutoSize = true;
    this.labelProgressHeader.Location = new Point(8, 8);
    this.labelProgressHeader.Name = "labelProgressHeader";
    this.labelProgressHeader.Size = new Size(210, 16 /*0x10*/);
    this.labelProgressHeader.TabIndex = 7;
    this.labelProgressHeader.Text = "Processing, this may take several minutes.";
    this.panelSettingsBreakout.AutoScroll = true;
    this.panelSettingsBreakout.Location = new Point(40, 112 /*0x70*/);
    this.panelSettingsBreakout.Name = "panelSettingsBreakout";
    this.panelSettingsBreakout.Size = new Size(424, 168);
    this.panelSettingsBreakout.TabIndex = 3;
    this.label65.Location = new Point(40, 200);
    this.label65.Name = "label65";
    this.label65.Size = new Size(408, 48 /*0x30*/);
    this.label65.TabIndex = 5;
    this.label64.Location = new Point(40, 360);
    this.label64.Name = "label64";
    this.label64.Size = new Size(440, 40);
    this.label64.TabIndex = 4;
    this.label64.Text = "These settings, with the exception of your accounting method and the expense accounts, can be modified at anytime using the utilities provided in the administrative options section of the main accounting portal.";
    this.label61.Location = new Point(40, 40);
    this.label61.Name = "label61";
    this.label61.Size = new Size(448, 80 /*0x50*/);
    this.label61.TabIndex = 2;
    this.label61.Text = "Congratulations! You have successfully completed all the steps in the New Chart of Accounts wizard. Please confirm the settings you have specified below. If you wish to change any of the settings, please use the 'Back' button to navigate to the appropriate setting. When you are satisfied with your selections click the 'Finish' button to save your settings and exit the wizard.";
    this.label60.AutoSize = true;
    this.label60.Location = new Point(40, 64 /*0x40*/);
    this.label60.Name = "label60";
    this.label60.Size = new Size(0, 16 /*0x10*/);
    this.label60.TabIndex = 0;
    this.label59.AutoSize = true;
    this.label59.Font = new Font("Tahoma", 9f, FontStyle.Bold);
    this.label59.Location = new Point(40, 16 /*0x10*/);
    this.label59.Name = "label59";
    this.label59.Size = new Size(146, 18);
    this.label59.TabIndex = 0;
    this.label59.Text = "Confirm Your Settings!";
    this.pictureBox4.BackColor = Color.FromArgb(239, 247, 253);
    this.pictureBox4.Image = (Image) resourceManager.GetObject("pictureBox4.Image");
    this.pictureBox4.Location = new Point(16 /*0x10*/, 456);
    this.pictureBox4.Name = "pictureBox4";
    this.pictureBox4.Size = new Size(16 /*0x10*/, 15);
    this.pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox4.TabIndex = 40;
    this.pictureBox4.TabStop = false;
    this.pictureBox4.Visible = false;
    ((AppearanceBase) appearance43).BackColor = Color.White;
    ((AppearanceBase) appearance43).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance43).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance43).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance43).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel14).Appearance = (AppearanceBase) appearance43;
    ((Control) this.ultraLabel14).AutoSize = true;
    ((Control) this.ultraLabel14).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel14).Location = new Point(32 /*0x20*/, 456);
    ((Control) this.ultraLabel14).Name = "ultraLabel14";
    ((Control) this.ultraLabel14).Size = new Size(76, 15);
    ((Control) this.ultraLabel14).TabIndex = 14;
    ((Control) this.ultraLabel14).Text = "Confirmation";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(746, 552);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panelPrimaryBank);
    this.Controls.Add((Control) this.panelWriteOffThreshold);
    this.Controls.Add((Control) this.panelConfirmation);
    this.Controls.Add((Control) this.panelOfficeLocation);
    this.Controls.Add((Control) this.panelGLCreationSettings);
    this.Controls.Add((Control) this.panelPostTiming);
    this.Controls.Add((Control) this.panelCommissionReconciliation);
    this.Controls.Add((Control) this.panelCashOrAccrual);
    this.Controls.Add((Control) this.pictureBox4);
    this.Controls.Add((Control) this.ultraLabel14);
    this.Controls.Add((Control) this.panelIntro);
    this.Controls.Add((Control) this.pictureCashAccrualCheck);
    this.Controls.Add((Control) this.ultraLabel13);
    this.Controls.Add((Control) this.pictureCommRecCheck);
    this.Controls.Add((Control) this.pictureInviocePostDateCheck);
    this.Controls.Add((Control) this.pictureWriteOffCheck);
    this.Controls.Add((Control) this.pictureOfficeCheck);
    this.Controls.Add((Control) this.pictureGLSettingsCheck);
    this.Controls.Add((Control) this.pictureCreateGLCheck);
    this.Controls.Add((Control) this.picturePrimaryBankCheck);
    this.Controls.Add((Control) this.pictureOperatingBankCheck);
    this.Controls.Add((Control) this.pictureIntroCheck);
    this.Controls.Add((Control) this.ultraLabel12);
    this.Controls.Add((Control) this.ultraLabel11);
    this.Controls.Add((Control) this.ultraLabel10);
    this.Controls.Add((Control) this.ultraLabel9);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.ultraLabel7);
    this.Controls.Add((Control) this.ultraLabel6);
    this.Controls.Add((Control) this.ultraLabel5);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.ultraLabel3);
    this.Controls.Add((Control) this.ultraLabel2);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.panel2);
    this.Controls.Add((Control) this.panelOperatingBank);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formCreateCompany);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "IMS Integrated Accounting Utility";
    this.panel1.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    ((ISupportInitialize) this.buttonFinish).EndInit();
    ((ISupportInitialize) this.buttonBack).EndInit();
    ((ISupportInitialize) this.buttonNext).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.panelIntro.ResumeLayout(false);
    this.panelOfficeLocation.ResumeLayout(false);
    ((ISupportInitialize) this.comboOfficeLocations).EndInit();
    this.dsGetOfficesLocationWithNoChartOfAccounts1.EndInit();
    this.panelGLCreationSettings.ResumeLayout(false);
    this.panelPrimaryBank.ResumeLayout(false);
    ((ISupportInitialize) this.textPrimaryBankGLShortName).EndInit();
    ((ISupportInitialize) this.textPrimaryBankGLFullName).EndInit();
    ((ISupportInitialize) this.textPrimaryBankName).EndInit();
    ((ISupportInitialize) this.textPrimaryABAFractional).EndInit();
    this.numericPrimaryNextCheckNumber.EndInit();
    ((ISupportInitialize) this.textPrimaryBankContactFax).EndInit();
    ((ISupportInitialize) this.textPrimaryBankContactPhone).EndInit();
    ((ISupportInitialize) this.textPrimaryBankContactEmail).EndInit();
    ((ISupportInitialize) this.textPrimaryBankContactName).EndInit();
    ((ISupportInitialize) this.textPrimaryDepositSlipSuffix).EndInit();
    ((ISupportInitialize) this.textPrimaryABARoutingNumber).EndInit();
    ((ISupportInitialize) this.textPrimaryAccountNumber).EndInit();
    ((ISupportInitialize) this.comboPrimaryAccountType).EndInit();
    this.dsBankAccountTypes1.EndInit();
    this.panelOperatingBank.ResumeLayout(false);
    ((ISupportInitialize) this.textOperatingBankGLShortName).EndInit();
    ((ISupportInitialize) this.textOperatingBankGLFullName).EndInit();
    ((ISupportInitialize) this.textOperatingBankName).EndInit();
    ((ISupportInitialize) this.textOperatingABAFractional).EndInit();
    this.numericOperatingNextCheckNumber.EndInit();
    ((ISupportInitialize) this.textOperatingtBankContactFax).EndInit();
    ((ISupportInitialize) this.textOperatingBankContactPhone).EndInit();
    ((ISupportInitialize) this.textOperatingBankContactEmail).EndInit();
    ((ISupportInitialize) this.textOperatingBankContactName).EndInit();
    ((ISupportInitialize) this.textOperatingDepositSlipSuffix).EndInit();
    ((ISupportInitialize) this.textOperatingABARoutingNumber).EndInit();
    ((ISupportInitialize) this.textOperatingAccountNumber).EndInit();
    ((ISupportInitialize) this.comboOperatingAccountType).EndInit();
    this.dsBankAccountTypes2.EndInit();
    this.panelCashOrAccrual.ResumeLayout(false);
    this.panelPostTiming.ResumeLayout(false);
    this.panelCommissionReconciliation.ResumeLayout(false);
    this.panel4.ResumeLayout(false);
    this.panel3.ResumeLayout(false);
    this.panelWriteOffThreshold.ResumeLayout(false);
    ((ISupportInitialize) this.textPayableWriteOffThreshold).EndInit();
    ((ISupportInitialize) this.textReceivableWriteOffThreshold).EndInit();
    this.panelConfirmation.ResumeLayout(false);
    this.panelProcessing.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void InitializeFormSettings()
  {
    this.panelIntro.BringToFront();
    this._currentPanel = this.panelIntro;
    this.GetOfficeLocations();
    this.GetBankAccountTypes();
    this.numericPrimaryNextCheckNumber.DataBindings.Add("Enabled", (object) this.checkPrimaryNextCheckNumber, "Checked");
    this.numericOperatingNextCheckNumber.DataBindings.Add("Enabled", (object) this.checkOperatingNextCheckNumber, "Checked");
    this.addressPrimaryBankAddress.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
    this.addressPrimaryBankAddress.UserID = AddressResolverSettings.AddressResolveUserName;
    this.addressPrimaryBankAddress.Password = AddressResolverSettings.AddressResolverPassword;
    this.addressOperatingBankAddress.WebserviceUrl = AddressResolverSettings.AddressResolverURL;
    this.addressOperatingBankAddress.UserID = AddressResolverSettings.AddressResolveUserName;
    this.addressOperatingBankAddress.Password = AddressResolverSettings.AddressResolverPassword;
  }

  private void buttonNext_Click(object sender, EventArgs e)
  {
    if (this._currentPanel == this.panelIntro)
    {
      this.panelOfficeLocation.BringToFront();
      this.pictureIntroCheck.Visible = true;
      this._currentPanel = this.panelOfficeLocation;
    }
    else if (this._currentPanel == this.panelOfficeLocation)
    {
      if (!this.ValidateSettings())
        return;
      ((Control) this.buttonBack).Enabled = true;
      this.panelGLCreationSettings.BringToFront();
      this.pictureOfficeCheck.Visible = true;
      this._currentPanel = this.panelGLCreationSettings;
    }
    else if (this._currentPanel == this.panelGLCreationSettings)
    {
      if (!this.ValidateSettings())
        return;
      this.pictureCreateGLCheck.Visible = true;
      this.panelPrimaryBank.BringToFront();
      this.pictureGLSettingsCheck.Visible = true;
      this._currentPanel = this.panelPrimaryBank;
    }
    else if (this._currentPanel == this.panelPrimaryBank)
    {
      if (!this.ValidateSettings())
        return;
      ((Control) this.buttonBack).Enabled = true;
      this.panelOperatingBank.BringToFront();
      this.picturePrimaryBankCheck.Visible = true;
      this._currentPanel = this.panelOperatingBank;
    }
    else if (this._currentPanel == this.panelOperatingBank)
    {
      if (!this.ValidateSettings())
        return;
      this.panelCashOrAccrual.BringToFront();
      this.pictureOperatingBankCheck.Visible = true;
      this._currentPanel = this.panelCashOrAccrual;
    }
    else if (this._currentPanel == this.panelCashOrAccrual)
    {
      if (!this.ValidateSettings())
        return;
      this.panelCommissionReconciliation.BringToFront();
      this.pictureCashAccrualCheck.Visible = true;
      this._currentPanel = this.panelCommissionReconciliation;
    }
    else if (this._currentPanel == this.panelCommissionReconciliation)
    {
      if (!this.ValidateSettings())
        return;
      this.panelWriteOffThreshold.BringToFront();
      this.pictureCommRecCheck.Visible = true;
      this._currentPanel = this.panelWriteOffThreshold;
    }
    else if (this._currentPanel == this.panelWriteOffThreshold)
    {
      if (!this.ValidateSettings())
        return;
      this.panelPostTiming.BringToFront();
      this.pictureWriteOffCheck.Visible = true;
      this._currentPanel = this.panelPostTiming;
    }
    else
    {
      if (this._currentPanel != this.panelPostTiming || !this.ValidateSettings())
        return;
      this.BuildConfirmationScreen();
      this.panelConfirmation.BringToFront();
      this.pictureInviocePostDateCheck.Visible = true;
      ((Control) this.buttonNext).Enabled = false;
      ((Control) this.buttonFinish).Enabled = true;
      this._currentPanel = this.panelConfirmation;
    }
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("The will close the New Chart of Accounts wizard, are you sure you wish to continue?", "Cancel Wizard?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void GetOfficeLocations()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("spFin_GetOfficesWithNoChart", connection))
      {
        selectCommand.CommandType = CommandType.StoredProcedure;
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
          sqlDataAdapter.Fill((DataTable) this.dsGetOfficesLocationWithNoChartOfAccounts1.tblClientOffices);
      }
    }
  }

  private bool ValidateSettings()
  {
    if (this._currentPanel == this.panelOfficeLocation && ((UltraDropDownBase) this.comboOfficeLocations).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this._currentPanel == this.panelGLCreationSettings && !this.radioCreateExpenseAccounts.Checked && !this.radioDoNotCreateExpenseAccounts.Checked)
    {
      int num = (int) MessageBox.Show("You must select eith to create or not to create the built in expense accounts.", "Required Option Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this._currentPanel == this.panelPrimaryBank)
      return this.ValidateBankSettings(true);
    if (this._currentPanel == this.panelOperatingBank)
      return this.ValidateBankSettings(false);
    if (this._currentPanel == this.panelCashOrAccrual)
    {
      if (!this.radioAccrualBasis.Checked && !this.radioCashBasis.Checked)
      {
        int num = (int) MessageBox.Show("You must select an accounting method to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (this.radioAccrualBasis.Checked)
      {
        this.radioReconReceivables.Checked = true;
        this.radioFully.Checked = true;
        this.radioReconReceivables.Enabled = false;
        this.radioReconPayables.Enabled = false;
        this.radioFully.Enabled = false;
        this.radioProportionally.Enabled = false;
      }
      else
      {
        this.radioReconReceivables.Checked = false;
        this.radioReconPayables.Checked = false;
        this.radioFully.Checked = false;
        this.radioProportionally.Checked = false;
        this.radioReconReceivables.Enabled = true;
        this.radioReconPayables.Enabled = true;
        this.radioFully.Enabled = true;
        this.radioProportionally.Enabled = true;
      }
    }
    if (this._currentPanel == this.panelCommissionReconciliation)
    {
      if (!this.radioReconReceivables.Checked && !this.radioReconPayables.Checked)
      {
        int num = (int) MessageBox.Show("You must specify whether to recognize commissions at the time of payables or receivables to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (!this.radioFully.Checked && !this.radioProportionally.Checked)
      {
        int num = (int) MessageBox.Show("You must specify whether to reconcile commissions fully or proportionally to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    if (this._currentPanel == this.panelWriteOffThreshold)
    {
      if (!Methods.IsDecimalValue((object) ((Control) this.textReceivableWriteOffThreshold).Text))
      {
        int num = (int) MessageBox.Show("Receivable threshold amount must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      MGATextBox writeOffThreshold1 = this.textReceivableWriteOffThreshold;
      Decimal num1 = Decimal.Parse(((Control) this.textReceivableWriteOffThreshold).Text, NumberStyles.Currency);
      string str1 = num1.ToString("c");
      ((Control) writeOffThreshold1).Text = str1;
      if (!Methods.IsDecimalValue((object) ((Control) this.textPayableWriteOffThreshold).Text))
      {
        int num2 = (int) MessageBox.Show("Payable threshold amount must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      MGATextBox writeOffThreshold2 = this.textPayableWriteOffThreshold;
      num1 = Decimal.Parse(((Control) this.textPayableWriteOffThreshold).Text, NumberStyles.Currency);
      string str2 = num1.ToString("c");
      ((Control) writeOffThreshold2).Text = str2;
    }
    if (this._currentPanel != this.panelPostTiming || this.radioUseBillingdate.Checked || this.radioUseEffectiveDate.Checked)
      return true;
    int num3 = (int) MessageBox.Show("You must specify wehether to use the billing or effective date of coverage as the accounting post date.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private bool ValidateBankSettings(bool isPrimary)
  {
    if ((isPrimary ? (((Control) this.textPrimaryBankGLFullName).Text.Trim().Equals(string.Empty) ? 1 : 0) : (((Control) this.textOperatingBankGLFullName).Text.Trim().Equals(string.Empty) ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show("You must enter a GL Account full name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (((Control) this.textPrimaryBankGLShortName).Text.Trim().Equals(string.Empty) ? 1 : 0) : (((Control) this.textOperatingBankGLShortName).Text.Trim().Equals(string.Empty) ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show("You must enter a GL Account short name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (((Control) this.textPrimaryBankName).Text.Equals(string.Empty) ? 1 : 0) : (((Control) this.textOperatingBankName).Text.Equals(string.Empty) ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show($"You must enter {(isPrimary ? "a primary" : "an operating")} bank name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (((UltraDropDownBase) this.comboPrimaryAccountType).SelectedRow == null ? 1 : 0) : (((UltraDropDownBase) this.comboOperatingAccountType).SelectedRow == null ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show("You must select an account type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (((Control) this.textPrimaryAccountNumber).Text.Trim().Equals(string.Empty) ? 1 : 0) : (((Control) this.textOperatingAccountNumber).Text.Trim().Equals(string.Empty) ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show("You must enter an account number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (((Control) this.textPrimaryABARoutingNumber).Text.Trim().Equals(string.Empty) ? 1 : 0) : (((Control) this.textOperatingABARoutingNumber).Text.Trim().Equals(string.Empty) ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show("You must enter a routing number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!MGASystems.IMS.Accounting.Utilities.Tools.RoutingNumberIsValid(isPrimary ? ((Control) this.textPrimaryABARoutingNumber).Text.Trim() : ((Control) this.textOperatingABARoutingNumber).Text.Trim()))
    {
      int num = (int) MessageBox.Show("Routing number is invalid.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (this.addressPrimaryBankAddress.ISOCountryCode.Equals(string.Empty) ? 1 : 0) : (this.addressOperatingBankAddress.ISOCountryCode.Equals(string.Empty) ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show("You must select a country to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (!this.addressPrimaryBankAddress.Address1.Equals(string.Empty) ? 0 : (this.addressPrimaryBankAddress.Address2.EndsWith(string.Empty) ? 1 : 0)) : (!this.addressOperatingBankAddress.Address1.Equals(string.Empty) ? 0 : (this.addressOperatingBankAddress.Address2.EndsWith(string.Empty) ? 1 : 0))) != 0)
    {
      int num = (int) MessageBox.Show("You must specify a bank address to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (this.addressPrimaryBankAddress.ZipCode.Equals(string.Empty) ? 1 : 0) : (this.addressOperatingBankAddress.ZipCode.Equals(string.Empty) ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show("You must specify a valid zip code to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (this.addressPrimaryBankAddress.ZipCode.Equals(string.Empty) ? 1 : 0) : (this.addressOperatingBankAddress.ZipCode.Equals(string.Empty) ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show("You must specify a valid zip code to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (!this.addressPrimaryBankAddress.IsValidZipCode ? 1 : 0) : (!this.addressOperatingBankAddress.IsValidZipCode ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show("You must specify a valid zip code to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (((Control) this.textPrimaryBankContactName).Text.Trim().Equals(string.Empty) ? 1 : 0) : (((Control) this.textOperatingBankContactName).Text.Trim().Equals(string.Empty) ? 1 : 0)) != 0)
    {
      int num = (int) MessageBox.Show("You must specify a bank contact name to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((isPrimary ? (((Control) this.textPrimaryBankContactPhone).Text.Trim().Equals(string.Empty) ? 1 : 0) : (((Control) this.textOperatingBankContactPhone).Text.Trim().Equals(string.Empty) ? 1 : 0)) == 0)
      return true;
    int num1 = (int) MessageBox.Show("You must specify a bank contact phone number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void buttonBack_Click(object sender, EventArgs e)
  {
    if (this._currentPanel == this.panelGLCreationSettings)
    {
      ((Control) this.buttonBack).Enabled = false;
      this.panelOfficeLocation.BringToFront();
      this._currentPanel = this.panelOfficeLocation;
    }
    if (this._currentPanel == this.panelPrimaryBank)
    {
      this.panelGLCreationSettings.BringToFront();
      this._currentPanel = this.panelGLCreationSettings;
    }
    if (this._currentPanel == this.panelOperatingBank)
    {
      this.panelPrimaryBank.BringToFront();
      this._currentPanel = this.panelPrimaryBank;
    }
    if (this._currentPanel == this.panelCashOrAccrual)
    {
      this.panelOperatingBank.BringToFront();
      this._currentPanel = this.panelOperatingBank;
    }
    if (this._currentPanel == this.panelCommissionReconciliation)
    {
      this.panelCashOrAccrual.BringToFront();
      this._currentPanel = this.panelCashOrAccrual;
    }
    if (this._currentPanel == this.panelWriteOffThreshold)
    {
      this.panelCommissionReconciliation.BringToFront();
      this._currentPanel = this.panelCommissionReconciliation;
    }
    if (this._currentPanel == this.panelPostTiming)
    {
      this.panelWriteOffThreshold.BringToFront();
      this._currentPanel = this.panelWriteOffThreshold;
    }
    if (this._currentPanel != this.panelConfirmation)
      return;
    ((Control) this.buttonNext).Enabled = true;
    ((Control) this.buttonFinish).Enabled = false;
    this.panelPostTiming.BringToFront();
    this._currentPanel = this.panelPostTiming;
  }

  private void GenerateChartOfAccounts(SqlCommand cmd, int glCompanyId, bool createExpenses)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_BuildStaticAccounts";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@officelocationid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@buildexpenses", (object) createExpenses);
    cmd.ExecuteNonQuery();
  }

  private void CreateBankAccountObjects(bool isPrimary)
  {
    string bankName = isPrimary ? ((Control) this.textPrimaryBankName).Text : ((Control) this.textOperatingBankName).Text;
    string accountNumber = isPrimary ? ((Control) this.textPrimaryAccountNumber).Text : ((Control) this.textOperatingAccountNumber).Text;
    string abaRoutingNumber = isPrimary ? ((Control) this.textPrimaryABARoutingNumber).Text : ((Control) this.textOperatingABARoutingNumber).Text;
    bool canIssueChecks = isPrimary ? this.checkPrimaryNextCheckNumber.Checked : this.checkOperatingNextCheckNumber.Checked;
    int nextCheckNumber = isPrimary ? int.Parse(this.numericPrimaryNextCheckNumber.Value.ToString()) : int.Parse(this.numericOperatingNextCheckNumber.Value.ToString());
    string abaFractional = isPrimary ? ((Control) this.textPrimaryABAFractional).Text : ((Control) this.textOperatingABAFractional).Text;
    string depositSlipSuffix = isPrimary ? ((Control) this.textPrimaryDepositSlipSuffix).Text : ((Control) this.textOperatingDepositSlipSuffix).Text;
    string address1 = isPrimary ? this.addressPrimaryBankAddress.Address1 : this.addressOperatingBankAddress.Address1;
    string address2 = isPrimary ? this.addressPrimaryBankAddress.Address2 : this.addressOperatingBankAddress.Address2;
    string city = isPrimary ? this.addressPrimaryBankAddress.City : this.addressOperatingBankAddress.City;
    string state = isPrimary ? this.addressPrimaryBankAddress.State : this.addressOperatingBankAddress.State;
    string isoCountryCode = isPrimary ? this.addressPrimaryBankAddress.ISOCountryCode : this.addressOperatingBankAddress.ISOCountryCode;
    string zipCode = isPrimary ? this.addressPrimaryBankAddress.ZipCode : this.addressOperatingBankAddress.ZipCode;
    string zipPlus = isPrimary ? this.addressPrimaryBankAddress.ZipCodeExtension : this.addressOperatingBankAddress.ZipCodeExtension;
    string bankContactName = isPrimary ? ((Control) this.textPrimaryBankContactName).Text : ((Control) this.textOperatingBankContactName).Text;
    string bankContactPhone = isPrimary ? ((Control) this.textPrimaryBankContactPhone).Text : ((Control) this.textOperatingBankContactPhone).Text;
    string bankContactFax = isPrimary ? ((Control) this.textPrimaryBankContactFax).Text : ((Control) this.textOperatingtBankContactFax).Text;
    string bankContactEmail = isPrimary ? ((Control) this.textPrimaryBankContactEmail).Text : ((Control) this.textOperatingBankContactEmail).Text;
    string bankAccountTypeId = isPrimary ? ((UltraDropDownBase) this.comboPrimaryAccountType).SelectedRow.Cells["BankAcctTypeId"].Value.ToString() : ((UltraDropDownBase) this.comboOperatingAccountType).SelectedRow.Cells["BankAcctTypeId"].Value.ToString();
    if (isPrimary)
      this._primaryBank = new BankAccount(bankName, accountNumber, abaRoutingNumber, canIssueChecks, nextCheckNumber, abaFractional, depositSlipSuffix, address1, address2, city, state, isoCountryCode, zipCode, zipPlus, bankContactName, bankContactPhone, bankContactFax, bankContactEmail, bankAccountTypeId);
    else
      this._operatingBank = new BankAccount(bankName, accountNumber, abaRoutingNumber, canIssueChecks, nextCheckNumber, abaFractional, depositSlipSuffix, address1, address2, city, state, isoCountryCode, zipCode, zipPlus, bankContactName, bankContactPhone, bankContactFax, bankContactEmail, bankAccountTypeId);
  }

  private void SaveNewChartOfAccounts(int glCompanyId, bool createExpenses)
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand cmd = new SqlCommand("", connection))
      {
        cmd.Connection.Open();
        cmd.Transaction = cmd.Connection.BeginTransaction();
        try
        {
          this.progressProcessing.Value = 0;
          this.panelProcessing.Visible = true;
          this.panelConfirmation.Refresh();
          this.GenerateChartOfAccounts(cmd, glCompanyId, createExpenses);
          ++this.progressProcessing.Value;
          ((Control) this.progressProcessing).Refresh();
          this.SaveBankAccounts(cmd, glCompanyId);
          this.labelProgress.Text = "Saving accounting method...";
          this.labelProgress.Refresh();
          this.SaveCashAccrualSettings(cmd, glCompanyId);
          ++this.progressProcessing.Value;
          ((Control) this.progressProcessing).Refresh();
          this.labelProgress.Text = "Saving commission settings...";
          this.labelProgress.Refresh();
          this.SaveCommissionReconciliationSettings(cmd, glCompanyId);
          ++this.progressProcessing.Value;
          ((Control) this.progressProcessing).Refresh();
          this.SaveCommissionRecognitionSettings(cmd, glCompanyId);
          ++this.progressProcessing.Value;
          ((Control) this.progressProcessing).Refresh();
          this.labelProgress.Text = "Saving write-off settings...";
          this.labelProgress.Refresh();
          this.SaveReceivablesWriteOffSettings(cmd, glCompanyId);
          ++this.progressProcessing.Value;
          ((Control) this.progressProcessing).Refresh();
          this.SavePayablesWriteOffSettings(cmd, glCompanyId);
          ++this.progressProcessing.Value;
          ((Control) this.progressProcessing).Refresh();
          this.labelProgress.Text = "Saving post date configuration...";
          this.labelProgress.Refresh();
          this.SavePostDateConfigurationSettings(cmd, glCompanyId);
          ++this.progressProcessing.Value;
          ((Control) this.progressProcessing).Refresh();
          cmd.Transaction.Commit();
          CurrentUser.Instance.LogAction("Created chart of accounts.", "Accounting Logs");
        }
        catch (SqlException ex)
        {
          cmd.Transaction.Rollback();
          throw ex;
        }
        catch (Exception ex)
        {
          cmd.Transaction.Rollback();
          throw ex;
        }
      }
    }
  }

  private void SaveBankAccounts(SqlCommand cmd, int glCompanyId)
  {
    this.labelProgress.Text = "Retreiving financial types...";
    this.labelProgress.Refresh();
    cmd.CommandType = CommandType.Text;
    cmd.CommandText = $"Select dbo.GetGLAccountTypeID('{"Current Asset"}')";
    cmd.Parameters.Clear();
    int financialAcctType = int.Parse(cmd.ExecuteScalar().ToString());
    ++this.progressProcessing.Value;
    ((Control) this.progressProcessing).Refresh();
    this.labelProgress.Text = "Creating primary bank account...";
    this.labelProgress.Refresh();
    this.CreateBankAccountObjects(true);
    ++this.progressProcessing.Value;
    ((Control) this.progressProcessing).Refresh();
    this.labelProgress.Text = "Saving primary bank account...";
    this.labelProgress.Refresh();
    int num1 = this._primaryBank.Save(cmd, glCompanyId, ((Control) this.textPrimaryBankGLFullName).Text, ((Control) this.textPrimaryBankGLShortName).Text, financialAcctType);
    ++this.progressProcessing.Value;
    ((Control) this.progressProcessing).Refresh();
    this.labelProgress.Text = "Creating primary bank automation...";
    this.labelProgress.Refresh();
    cmd.Parameters.Clear();
    cmd.CommandText = "spFin_InsertAutomationSetting";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.AddWithValue("@AcctRoleId", (object) "PBA");
    cmd.Parameters.AddWithValue("@glAcctId", (object) num1);
    cmd.ExecuteNonQuery();
    this.labelProgress.Text = "Creating operating bank account...";
    this.labelProgress.Refresh();
    this.CreateBankAccountObjects(false);
    ++this.progressProcessing.Value;
    ((Control) this.progressProcessing).Refresh();
    this.labelProgress.Text = "Saving operating bank account...";
    this.labelProgress.Refresh();
    int num2 = this._operatingBank.Save(cmd, glCompanyId, ((Control) this.textOperatingBankGLFullName).Text, ((Control) this.textOperatingBankGLShortName).Text, financialAcctType);
    ++this.progressProcessing.Value;
    ((Control) this.progressProcessing).Refresh();
    this.labelProgress.Text = "Creating operating bank automation...";
    this.labelProgress.Refresh();
    cmd.CommandType = CommandType.Text;
    cmd.Parameters.Clear();
    cmd.CommandText = "spFin_InsertAutomationSetting";
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.Parameters.AddWithValue("@AcctRoleId", (object) "OBA");
    cmd.Parameters.AddWithValue("@glAcctId", (object) num2);
    cmd.ExecuteNonQuery();
    ++this.progressProcessing.Value;
    ((Control) this.progressProcessing).Refresh();
  }

  private void SaveCashAccrualSettings(SqlCommand cmd, int glCompanyId)
  {
    if (this.radioAccrualBasis.Checked)
      cmd.CommandText = $"Select dbo.GetGLCompanyCommissionsIncomeAccount({glCompanyId})";
    else
      cmd.CommandText = $"Select dbo.GetGLCompanyCommissionsPayableAccount({glCompanyId})";
    cmd.CommandType = CommandType.Text;
    cmd.Parameters.Clear();
    int num = int.Parse(cmd.ExecuteScalar().ToString());
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertAutomationSetting";
    cmd.Parameters.AddWithValue("@AcctRoleId", (object) "CCr");
    cmd.Parameters.AddWithValue("@glAcctId", (object) num);
    cmd.ExecuteNonQuery();
  }

  private void SaveCommissionReconciliationSettings(SqlCommand cmd, int glCompanyId)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExtendedSettings";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@setting", (object) "CommReconciliation");
    cmd.Parameters.AddWithValue("@settingnumvalue", (object) (this.radioReconReceivables.Checked ? 1.00M : 2.00M));
    cmd.ExecuteNonQuery();
  }

  private void SaveCommissionRecognitionSettings(SqlCommand cmd, int glCompanyId)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExtendedSettings";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@setting", (object) "CommRecognition");
    cmd.Parameters.AddWithValue("@settingstringvalue", this.radioFully.Checked ? (object) "F" : (object) "P");
    cmd.ExecuteNonQuery();
  }

  private void SaveReceivablesWriteOffSettings(SqlCommand cmd, int glCompanyId)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExtendedSettings";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@setting", (object) "AssetWriteOff");
    cmd.Parameters.AddWithValue("@settingnumvalue", (object) Decimal.Parse(((Control) this.textReceivableWriteOffThreshold).Text, NumberStyles.Currency));
    cmd.ExecuteNonQuery();
  }

  private void SavePayablesWriteOffSettings(SqlCommand cmd, int glCompanyId)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExtendedSettings";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@setting", (object) "LiabilityWriteOff");
    cmd.Parameters.AddWithValue("@settingnumvalue", (object) Decimal.Parse(((Control) this.textReceivableWriteOffThreshold).Text, NumberStyles.Currency));
    cmd.ExecuteNonQuery();
  }

  private void SavePostDateConfigurationSettings(SqlCommand cmd, int glCompanyId)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_InsertExtendedSettings";
    cmd.Parameters.Clear();
    cmd.Parameters.AddWithValue("@glcompanyid", (object) glCompanyId);
    cmd.Parameters.AddWithValue("@setting", (object) "PostDateConfiguration");
    cmd.Parameters.AddWithValue("@settingstringvalue", this.radioUseBillingdate.Checked ? (object) "B" : (object) "E");
    cmd.ExecuteNonQuery();
  }

  private void GetBankAccountTypes()
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("spfin_GetBankAccountTypes", connection))
      {
        selectCommand.CommandType = CommandType.StoredProcedure;
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
        {
          sqlDataAdapter.Fill((DataTable) this.dsBankAccountTypes1.BankAccountTypes);
          sqlDataAdapter.Fill((DataTable) this.dsBankAccountTypes2.BankAccountTypes);
        }
      }
    }
  }

  private void buttonFinish_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.SaveNewChartOfAccounts(int.Parse(((UltraDropDownBase) this.comboOfficeLocations).SelectedRow.Cells["id"].Value.ToString()), this.radioCreateExpenseAccounts.Checked);
      this.Cursor = Cursors.Default;
      int num = (int) MessageBox.Show("Chart of accounts created sucessfully.", "New Chart of Accounts Created!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
    catch (Exception ex)
    {
      throw ex;
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void BuildConfirmationScreen()
  {
    this.panelSettingsBreakout.Controls.Clear();
    Label label1 = new Label();
    label1.Text = $"Create chart of acocunts for: {((UltraDropDownBase) this.comboOfficeLocations).SelectedRow.Cells["Office Location"].Value.ToString()}";
    label1.Size = new Size(label1.Width, 32 /*0x20*/);
    this.panelSettingsBreakout.Controls.Add((Control) label1);
    label1.BringToFront();
    label1.Dock = DockStyle.Top;
    Label label2 = new Label();
    label2.Text = $"Build Expense Accounts: {(this.radioCreateExpenseAccounts.Checked ? (object) "YES" : (object) "NO")}";
    label2.Size = new Size(label2.Width, 16 /*0x10*/);
    this.panelSettingsBreakout.Controls.Add((Control) label2);
    label2.BringToFront();
    label2.Dock = DockStyle.Top;
    Label label3 = new Label();
    label3.Text = $"Primary Bank Account: {((Control) this.textPrimaryBankName).Text}-{((Control) this.textPrimaryAccountNumber).Text}";
    label3.Size = new Size(label3.Width, 16 /*0x10*/);
    this.panelSettingsBreakout.Controls.Add((Control) label3);
    label3.BringToFront();
    label3.Dock = DockStyle.Top;
    Label label4 = new Label();
    label4.Text = $"Operating Bank Account: {((Control) this.textOperatingBankName).Text}-{((Control) this.textOperatingAccountNumber).Text}";
    label4.Size = new Size(label4.Width, 16 /*0x10*/);
    this.panelSettingsBreakout.Controls.Add((Control) label4);
    label4.BringToFront();
    label4.Dock = DockStyle.Top;
    Label label5 = new Label();
    label5.Text = $"Commission Reconciliation: {(this.radioCashBasis.Checked ? (this.radioReconReceivables.Checked ? (object) "RECEIVABLES" : (object) "PAYABLES") : (object) "Not Applicable")}";
    label5.Size = new Size(label5.Width, 16 /*0x10*/);
    this.panelSettingsBreakout.Controls.Add((Control) label5);
    label5.BringToFront();
    label5.Dock = DockStyle.Top;
    Label label6 = new Label();
    label6.Text = $"Commission Recognition: {(this.radioCashBasis.Checked ? (this.radioFully.Checked ? (object) "ON FULL" : (object) "PROPORTIONAL") : (object) "Not Applicable")}";
    label6.Size = new Size(label6.Width, 16 /*0x10*/);
    this.panelSettingsBreakout.Controls.Add((Control) label6);
    label6.BringToFront();
    label6.Dock = DockStyle.Top;
    Label label7 = new Label();
    label7.Text = $"Receivable Write-Off Threshold: {((Control) this.textReceivableWriteOffThreshold).Text}";
    label7.Size = new Size(label7.Width, 16 /*0x10*/);
    this.panelSettingsBreakout.Controls.Add((Control) label7);
    label7.BringToFront();
    label7.Dock = DockStyle.Top;
    Label label8 = new Label();
    label8.Text = $"Payable Write-Off Threshold: {((Control) this.textPayableWriteOffThreshold).Text}";
    label8.Size = new Size(label8.Width, 16 /*0x10*/);
    this.panelSettingsBreakout.Controls.Add((Control) label8);
    label8.BringToFront();
    label8.Dock = DockStyle.Top;
    Label label9 = new Label();
    label9.Text = $"Post Date Configuration: {(this.radioUseBillingdate.Checked ? (object) "BILLING DATE" : (object) "EFFECTIVE DATE")}";
    label9.Size = new Size(label9.Width, 16 /*0x10*/);
    this.panelSettingsBreakout.Controls.Add((Control) label9);
    label9.BringToFront();
    label9.Dock = DockStyle.Top;
  }
}
