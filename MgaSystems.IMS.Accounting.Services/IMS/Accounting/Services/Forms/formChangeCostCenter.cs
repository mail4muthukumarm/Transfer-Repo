// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.formChangeCostCenter
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinToolTip;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

[SecureResource("{A64D7C6E-0F7F-4e23-B610-B8F6CF8EF7DA}", "Change Cost Center Rights", "Determines whether or not a user will have the ability to change transaction cost centers.")]
public class formChangeCostCenter : Form
{
  private Panel panel4;
  private MGASimpleComboBox comboOfficeLocation;
  private Panel panel1;
  private Panel panel2;
  private ContextMenu contextCostCenter;
  private Panel panel3;
  private Label label1;
  private MGAButton btnCancel;
  private MGAButton btnUpdate;
  private UltraGroupBox ultraGroupBox1;
  private MGAButton btnClear;
  internal PictureBox pictureBox2;
  private MGAButton btnSearch;
  private Label label2;
  private Label label3;
  private dsChangeCostCenter dsChangeCostCenter1;
  private Label label7;
  internal Label labelCurtain;
  private UltraGrid gridCostCenter;
  internal UltraToolTipManager tip;
  private CheckBox chkNoCostCenter;
  private GroupBox grpHasCostCenter;
  private Label label6;
  private Label label4;
  private MGADateTimePicker dateInvoiceDateTo;
  private MGATextBox txtPoNum;
  private CheckBox radioCostCenter;
  private MGATextBox txtTransactionNumber;
  private MGATextBox txtInvoiceNum;
  private CheckBox radioInvoiceNum;
  private CheckBox radioUnderWriter;
  private MGASimpleComboBox comboUnderWriters;
  private CheckBox radioInvoiceDate;
  private MGASimpleComboBox comboCostCenter;
  private MGADateTimePicker dateInvoiceDateFrom;
  private CheckBox radioTransactionNum;
  private CheckBox radioPoNum;
  private MGASimpleComboBox comboTransType;
  private CheckBox radioTransactionDateRange;
  private Label label5;
  private Label label24;
  private MGADateTimePicker dateTransactionDateFrom;
  private MGADateTimePicker dateTransactionDateTo;
  private CheckBox radioTrasnsType;
  private MGAButton buttonHelp;
  private IContainer components;
  internal const string SECURITY_KEY = "{A64D7C6E-0F7F-4e23-B610-B8F6CF8EF7DA}";
  private int[] costCenterDataLoadedNodes;
  private int costCenterDataLoadCurrentIndex;
  private int[] nodesExpanedBeforeSave;
  private bool _isLoadingAfterUpdate;
  private formChangeSecondCostCenter formSecondCostCenter;
  private dsChangeCostCenter dsCostCenterData;
  private UltraToolTipInfo ToolTipInfo = new UltraToolTipInfo();
  private DataTable dtContextMenu;
  private SqlDataAdapter da;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formChangeCostCenter));
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("SearchInvoiceData", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("transactnum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("postdate");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("username");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("transdescription");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("SearchInvoiceDataCostCenterData");
    UltraGridBand ultraGridBand2 = new UltraGridBand("SearchInvoiceDataCostCenterData", 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("transactnum");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("costCenter");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("costCenterName");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("postingNum");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("glAccount");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Amount");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("invoicedate");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("insured");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("policyNumber");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("expenseCode");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Expense");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("NewcostcenterID");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.panel4 = new Panel();
    this.label1 = new Label();
    this.ultraGroupBox1 = new UltraGroupBox();
    this.radioTrasnsType = new CheckBox();
    this.radioTransactionDateRange = new CheckBox();
    this.label5 = new Label();
    this.label24 = new Label();
    this.dateTransactionDateFrom = new MGADateTimePicker();
    this.dateTransactionDateTo = new MGADateTimePicker();
    this.comboTransType = new MGASimpleComboBox();
    this.chkNoCostCenter = new CheckBox();
    this.label7 = new Label();
    this.btnSearch = new MGAButton();
    this.btnClear = new MGAButton();
    this.grpHasCostCenter = new GroupBox();
    this.radioPoNum = new CheckBox();
    this.label6 = new Label();
    this.label4 = new Label();
    this.dateInvoiceDateTo = new MGADateTimePicker();
    this.txtPoNum = new MGATextBox();
    this.radioCostCenter = new CheckBox();
    this.txtTransactionNumber = new MGATextBox();
    this.txtInvoiceNum = new MGATextBox();
    this.radioInvoiceNum = new CheckBox();
    this.radioUnderWriter = new CheckBox();
    this.comboUnderWriters = new MGASimpleComboBox();
    this.radioInvoiceDate = new CheckBox();
    this.comboCostCenter = new MGASimpleComboBox();
    this.dateInvoiceDateFrom = new MGADateTimePicker();
    this.radioTransactionNum = new CheckBox();
    this.panel1 = new Panel();
    this.gridCostCenter = new UltraGrid();
    this.dsChangeCostCenter1 = new dsChangeCostCenter();
    this.panel2 = new Panel();
    this.label3 = new Label();
    this.pictureBox2 = new PictureBox();
    this.label2 = new Label();
    this.panel3 = new Panel();
    this.btnUpdate = new MGAButton();
    this.btnCancel = new MGAButton();
    this.labelCurtain = new Label();
    this.contextCostCenter = new ContextMenu();
    this.tip = new UltraToolTipManager(this.components);
    this.buttonHelp = new MGAButton();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.panel4.SuspendLayout();
    ((ISupportInitialize) this.ultraGroupBox1).BeginInit();
    ((Control) this.ultraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.dateTransactionDateFrom).BeginInit();
    ((ISupportInitialize) this.dateTransactionDateTo).BeginInit();
    ((ISupportInitialize) this.comboTransType).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnClear).BeginInit();
    this.grpHasCostCenter.SuspendLayout();
    ((ISupportInitialize) this.dateInvoiceDateTo).BeginInit();
    ((ISupportInitialize) this.txtPoNum).BeginInit();
    ((ISupportInitialize) this.txtTransactionNumber).BeginInit();
    ((ISupportInitialize) this.txtInvoiceNum).BeginInit();
    ((ISupportInitialize) this.comboUnderWriters).BeginInit();
    ((ISupportInitialize) this.comboCostCenter).BeginInit();
    ((ISupportInitialize) this.dateInvoiceDateFrom).BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.gridCostCenter).BeginInit();
    this.dsChangeCostCenter1.BeginInit();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.pictureBox2).BeginInit();
    this.panel3.SuspendLayout();
    ((ISupportInitialize) this.btnUpdate).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.buttonHelp).BeginInit();
    this.SuspendLayout();
    this.comboOfficeLocation.AutoSelectOnOneItem = true;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(8, 32 /*0x20*/);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(200, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 54;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.comboOfficeLocation.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    this.panel4.BackColor = Color.FromArgb(239, 247, 253);
    this.panel4.Controls.Add((Control) this.label1);
    this.panel4.Controls.Add((Control) this.ultraGroupBox1);
    this.panel4.Dock = DockStyle.Left;
    this.panel4.Location = new Point(0, 64 /*0x40*/);
    this.panel4.Name = "panel4";
    this.panel4.Size = new Size(264, 662);
    this.panel4.TabIndex = 74;
    this.label1.BackColor = Color.FromArgb(239, 247, 253);
    this.label1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(8, 0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(248, 104);
    this.label1.TabIndex = 77;
    this.label1.Text = componentResourceManager.GetString("label1.Text");
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.radioTrasnsType);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.radioTransactionDateRange);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label5);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label24);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.dateTransactionDateFrom);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.dateTransactionDateTo);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.comboTransType);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.chkNoCostCenter);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.label7);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.btnSearch);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.comboOfficeLocation);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.btnClear);
    ((Control) this.ultraGroupBox1).Controls.Add((Control) this.grpHasCostCenter);
    ((Control) this.ultraGroupBox1).Location = new Point(0, 112 /*0x70*/);
    ((Control) this.ultraGroupBox1).Name = "ultraGroupBox1";
    ((Control) this.ultraGroupBox1).Size = new Size(264, 544);
    ((Control) this.ultraGroupBox1).TabIndex = 77;
    ((Control) this.ultraGroupBox1).Text = "Search Options";
    this.radioTrasnsType.BackColor = Color.FromArgb(239, 247, 253);
    this.radioTrasnsType.FlatStyle = FlatStyle.Flat;
    this.radioTrasnsType.ForeColor = Color.Black;
    this.radioTrasnsType.Location = new Point(8, 64 /*0x40*/);
    this.radioTrasnsType.Name = "radioTrasnsType";
    this.radioTrasnsType.Size = new Size(120, 16 /*0x10*/);
    this.radioTrasnsType.TabIndex = 112 /*0x70*/;
    this.radioTrasnsType.Text = "Transaction Type";
    this.radioTrasnsType.UseVisualStyleBackColor = false;
    this.radioTrasnsType.CheckedChanged += new EventHandler(this.radioTrasnsType_CheckedChanged);
    this.radioTransactionDateRange.BackColor = Color.FromArgb(239, 247, 253);
    this.radioTransactionDateRange.FlatStyle = FlatStyle.Flat;
    this.radioTransactionDateRange.Location = new Point(8, 112 /*0x70*/);
    this.radioTransactionDateRange.Name = "radioTransactionDateRange";
    this.radioTransactionDateRange.Size = new Size(120, 16 /*0x10*/);
    this.radioTransactionDateRange.TabIndex = 111;
    this.radioTransactionDateRange.Text = "Transaction Date";
    this.radioTransactionDateRange.UseVisualStyleBackColor = false;
    this.radioTransactionDateRange.CheckedChanged += new EventHandler(this.radioTransactionDateRange_CheckedChanged);
    this.label5.BackColor = Color.FromArgb(239, 247, 253);
    this.label5.Location = new Point(12, 128 /*0x80*/);
    this.label5.Name = "label5";
    this.label5.Size = new Size(40, 16 /*0x10*/);
    this.label5.TabIndex = 110;
    this.label5.Text = "From :";
    this.label24.BackColor = Color.FromArgb(239, 247, 253);
    this.label24.Location = new Point(140, 128 /*0x80*/);
    this.label24.Name = "label24";
    this.label24.Size = new Size(24, 16 /*0x10*/);
    this.label24.TabIndex = 108;
    this.label24.Text = "To : ";
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTransactionDateFrom.Appearance = (AppearanceBase) appearance1;
    ((AppearanceBase) appearance2).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance2).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance2).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance2).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    this.dateTransactionDateFrom.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dateTransactionDateFrom).Enabled = false;
    ((Control) this.dateTransactionDateFrom).Location = new Point(52, 128 /*0x80*/);
    this.dateTransactionDateFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTransactionDateFrom).Name = "dateTransactionDateFrom";
    ((Control) this.dateTransactionDateFrom).Size = new Size(88, 20);
    ((Control) this.dateTransactionDateFrom).TabIndex = 107;
    ((UltraControlBase) this.dateTransactionDateFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTransactionDateFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTransactionDateTo.Appearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance4).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance4).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance4).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance4).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance4).ForegroundAlpha = (Alpha) 2;
    this.dateTransactionDateTo.ButtonAppearance = (AppearanceBase) appearance4;
    ((Control) this.dateTransactionDateTo).Enabled = false;
    ((Control) this.dateTransactionDateTo).Location = new Point(164, 128 /*0x80*/);
    this.dateTransactionDateTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTransactionDateTo).Name = "dateTransactionDateTo";
    ((Control) this.dateTransactionDateTo).Size = new Size(88, 20);
    ((Control) this.dateTransactionDateTo).TabIndex = 109;
    ((UltraControlBase) this.dateTransactionDateTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTransactionDateTo).UseOsThemes = (DefaultableBoolean) 2;
    this.comboTransType.AutoSelectOnOneItem = true;
    this.comboTransType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboTransType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboTransType).Enabled = false;
    ((Control) this.comboTransType).Location = new Point(8, 80 /*0x50*/);
    this.comboTransType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboTransType).Name = "comboTransType";
    ((Control) this.comboTransType).Size = new Size(200, 21);
    ((Control) this.comboTransType).TabIndex = 89;
    ((UltraControlBase) this.comboTransType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboTransType).UseOsThemes = (DefaultableBoolean) 2;
    this.chkNoCostCenter.BackColor = Color.FromArgb(239, 247, 253);
    this.chkNoCostCenter.FlatStyle = FlatStyle.Flat;
    this.chkNoCostCenter.Location = new Point(8, 472);
    this.chkNoCostCenter.Name = "chkNoCostCenter";
    this.chkNoCostCenter.Size = new Size(144 /*0x90*/, 16 /*0x10*/);
    this.chkNoCostCenter.TabIndex = 87;
    this.chkNoCostCenter.Text = "No Cost Center Assigned";
    this.chkNoCostCenter.UseVisualStyleBackColor = false;
    this.chkNoCostCenter.CheckedChanged += new EventHandler(this.chkNoCostCenter_CheckedChanged);
    this.label7.BackColor = Color.FromArgb(239, 247, 253);
    this.label7.Location = new Point(8, 16 /*0x10*/);
    this.label7.Name = "label7";
    this.label7.Size = new Size(120, 16 /*0x10*/);
    this.label7.TabIndex = 86;
    this.label7.Text = "Office Location : ";
    ((Control) this.btnSearch).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance5).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance5).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnSearch).Location = new Point(152, 515);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(104, 24);
    ((Control) this.btnSearch).TabIndex = 74;
    ((Control) this.btnSearch).Text = "Search";
    ((UltraControlBase) this.btnSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSearch).Click += new EventHandler(this.btnSearch_Click);
    ((Control) this.btnClear).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance6).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance6).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnClear).Appearance = (AppearanceBase) appearance6;
    ((Control) this.btnClear).Location = new Point(40, 515);
    ((Control) this.btnClear).Name = "btnClear";
    ((Control) this.btnClear).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnClear).TabIndex = 78;
    ((Control) this.btnClear).Text = "Clear ";
    ((UltraControlBase) this.btnClear).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnClear).Click += new EventHandler(this.btnClear_Click);
    this.grpHasCostCenter.Controls.Add((Control) this.radioPoNum);
    this.grpHasCostCenter.Controls.Add((Control) this.label6);
    this.grpHasCostCenter.Controls.Add((Control) this.label4);
    this.grpHasCostCenter.Controls.Add((Control) this.dateInvoiceDateTo);
    this.grpHasCostCenter.Controls.Add((Control) this.txtPoNum);
    this.grpHasCostCenter.Controls.Add((Control) this.radioCostCenter);
    this.grpHasCostCenter.Controls.Add((Control) this.txtTransactionNumber);
    this.grpHasCostCenter.Controls.Add((Control) this.txtInvoiceNum);
    this.grpHasCostCenter.Controls.Add((Control) this.radioInvoiceNum);
    this.grpHasCostCenter.Controls.Add((Control) this.radioUnderWriter);
    this.grpHasCostCenter.Controls.Add((Control) this.comboUnderWriters);
    this.grpHasCostCenter.Controls.Add((Control) this.radioInvoiceDate);
    this.grpHasCostCenter.Controls.Add((Control) this.comboCostCenter);
    this.grpHasCostCenter.Controls.Add((Control) this.dateInvoiceDateFrom);
    this.grpHasCostCenter.Controls.Add((Control) this.radioTransactionNum);
    this.grpHasCostCenter.Location = new Point(5, 160 /*0xA0*/);
    this.grpHasCostCenter.Name = "grpHasCostCenter";
    this.grpHasCostCenter.Size = new Size(256 /*0x0100*/, 304);
    this.grpHasCostCenter.TabIndex = 88;
    this.grpHasCostCenter.TabStop = false;
    this.radioPoNum.BackColor = Color.FromArgb(239, 247, 253);
    this.radioPoNum.FlatStyle = FlatStyle.Flat;
    this.radioPoNum.Location = new Point(8, 248);
    this.radioPoNum.Name = "radioPoNum";
    this.radioPoNum.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.radioPoNum.TabIndex = 107;
    this.radioPoNum.Text = "Purchase Order  #";
    this.radioPoNum.UseVisualStyleBackColor = false;
    this.radioPoNum.CheckedChanged += new EventHandler(this.radioPoNum_CheckedChanged);
    this.label6.BackColor = Color.FromArgb(239, 247, 253);
    this.label6.Location = new Point(8, 170);
    this.label6.Name = "label6";
    this.label6.Size = new Size(40, 16 /*0x10*/);
    this.label6.TabIndex = 105;
    this.label6.Text = "From :";
    this.label4.BackColor = Color.FromArgb(239, 247, 253);
    this.label4.Location = new Point(136, 170);
    this.label4.Name = "label4";
    this.label4.Size = new Size(24, 16 /*0x10*/);
    this.label4.TabIndex = 103;
    this.label4.Text = "To : ";
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateInvoiceDateTo.Appearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance8).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance8).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance8).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance8).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance8).ForegroundAlpha = (Alpha) 2;
    this.dateInvoiceDateTo.ButtonAppearance = (AppearanceBase) appearance8;
    this.dateInvoiceDateTo.DateTime = new DateTime(2007, 1, 17, 0, 0, 0, 0);
    ((Control) this.dateInvoiceDateTo).Enabled = false;
    ((Control) this.dateInvoiceDateTo).Location = new Point(160 /*0xA0*/, 170);
    this.dateInvoiceDateTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateInvoiceDateTo).Name = "dateInvoiceDateTo";
    ((Control) this.dateInvoiceDateTo).Size = new Size(88, 20);
    ((Control) this.dateInvoiceDateTo).TabIndex = 102;
    ((UltraControlBase) this.dateInvoiceDateTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateInvoiceDateTo).UseOsThemes = (DefaultableBoolean) 2;
    this.dateInvoiceDateTo.Value = (object) new DateTime(2007, 1, 17, 0, 0, 0, 0);
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPoNum).Appearance = (AppearanceBase) appearance9;
    ((Control) this.txtPoNum).BackColor = Color.White;
    ((Control) this.txtPoNum).Enabled = false;
    ((Control) this.txtPoNum).Location = new Point(8, 272);
    this.txtPoNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPoNum).Name = "txtPoNum";
    ((Control) this.txtPoNum).Size = new Size(168, 20);
    ((Control) this.txtPoNum).TabIndex = 100;
    ((UltraControlBase) this.txtPoNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPoNum).UseOsThemes = (DefaultableBoolean) 2;
    this.radioCostCenter.BackColor = Color.FromArgb(239, 247, 253);
    this.radioCostCenter.FlatStyle = FlatStyle.Flat;
    this.radioCostCenter.Location = new Point(8, 10);
    this.radioCostCenter.Name = "radioCostCenter";
    this.radioCostCenter.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.radioCostCenter.TabIndex = 99;
    this.radioCostCenter.Text = "Cost Center";
    this.radioCostCenter.UseVisualStyleBackColor = false;
    this.radioCostCenter.CheckedChanged += new EventHandler(this.radioCostCenter_CheckedChanged);
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtTransactionNumber).Appearance = (AppearanceBase) appearance10;
    ((Control) this.txtTransactionNumber).BackColor = Color.White;
    ((Control) this.txtTransactionNumber).Enabled = false;
    ((Control) this.txtTransactionNumber).Location = new Point(8, 218);
    this.txtTransactionNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtTransactionNumber).Name = "txtTransactionNumber";
    ((Control) this.txtTransactionNumber).Size = new Size(168, 20);
    ((Control) this.txtTransactionNumber).TabIndex = 90;
    ((UltraControlBase) this.txtTransactionNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtTransactionNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInvoiceNum).Appearance = (AppearanceBase) appearance11;
    ((Control) this.txtInvoiceNum).BackColor = Color.White;
    ((Control) this.txtInvoiceNum).Enabled = false;
    ((Control) this.txtInvoiceNum).Location = new Point(8, 122);
    this.txtInvoiceNum.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtInvoiceNum).Name = "txtInvoiceNum";
    ((Control) this.txtInvoiceNum).Size = new Size(200, 20);
    ((Control) this.txtInvoiceNum).TabIndex = 89;
    ((UltraControlBase) this.txtInvoiceNum).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInvoiceNum).UseOsThemes = (DefaultableBoolean) 2;
    this.radioInvoiceNum.BackColor = Color.FromArgb(239, 247, 253);
    this.radioInvoiceNum.FlatStyle = FlatStyle.Flat;
    this.radioInvoiceNum.Location = new Point(8, 106);
    this.radioInvoiceNum.Name = "radioInvoiceNum";
    this.radioInvoiceNum.Size = new Size(72, 16 /*0x10*/);
    this.radioInvoiceNum.TabIndex = 95;
    this.radioInvoiceNum.Text = "Invoice # ";
    this.radioInvoiceNum.UseVisualStyleBackColor = false;
    this.radioInvoiceNum.CheckedChanged += new EventHandler(this.radioInvoiceNum_CheckedChanged);
    this.radioUnderWriter.BackColor = Color.FromArgb(239, 247, 253);
    this.radioUnderWriter.FlatStyle = FlatStyle.Flat;
    this.radioUnderWriter.Location = new Point(8, 58);
    this.radioUnderWriter.Name = "radioUnderWriter";
    this.radioUnderWriter.Size = new Size(88, 16 /*0x10*/);
    this.radioUnderWriter.TabIndex = 94;
    this.radioUnderWriter.Text = "Under Writer";
    this.radioUnderWriter.UseVisualStyleBackColor = false;
    this.radioUnderWriter.CheckedChanged += new EventHandler(this.radioUnderWriter_CheckedChanged);
    this.comboUnderWriters.BorderStyle = (UIElementBorderStyle) 4;
    this.comboUnderWriters.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboUnderWriters).Enabled = false;
    ((Control) this.comboUnderWriters).Location = new Point(8, 74);
    this.comboUnderWriters.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboUnderWriters).Name = "comboUnderWriters";
    ((Control) this.comboUnderWriters).Size = new Size(200, 21);
    ((Control) this.comboUnderWriters).TabIndex = 88;
    ((UltraControlBase) this.comboUnderWriters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboUnderWriters).UseOsThemes = (DefaultableBoolean) 2;
    this.radioInvoiceDate.BackColor = Color.FromArgb(239, 247, 253);
    this.radioInvoiceDate.FlatStyle = FlatStyle.Flat;
    this.radioInvoiceDate.Location = new Point(8, 154);
    this.radioInvoiceDate.Name = "radioInvoiceDate";
    this.radioInvoiceDate.Size = new Size(88, 16 /*0x10*/);
    this.radioInvoiceDate.TabIndex = 96 /*0x60*/;
    this.radioInvoiceDate.Text = "Invoice Date";
    this.radioInvoiceDate.UseVisualStyleBackColor = false;
    this.radioInvoiceDate.CheckedChanged += new EventHandler(this.radioInvoiceDate_CheckedChanged);
    this.comboCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenter).Enabled = false;
    ((Control) this.comboCostCenter).Location = new Point(8, 26);
    this.comboCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenter).Name = "comboCostCenter";
    ((Control) this.comboCostCenter).Size = new Size(200, 21);
    ((Control) this.comboCostCenter).TabIndex = 86;
    ((UltraControlBase) this.comboCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateInvoiceDateFrom.Appearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance13).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance13).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance13).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance13).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance13).ForegroundAlpha = (Alpha) 2;
    this.dateInvoiceDateFrom.ButtonAppearance = (AppearanceBase) appearance13;
    this.dateInvoiceDateFrom.DateTime = new DateTime(2007, 1, 17, 0, 0, 0, 0);
    ((Control) this.dateInvoiceDateFrom).Enabled = false;
    ((Control) this.dateInvoiceDateFrom).Location = new Point(48 /*0x30*/, 170);
    this.dateInvoiceDateFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateInvoiceDateFrom).Name = "dateInvoiceDateFrom";
    ((Control) this.dateInvoiceDateFrom).Size = new Size(88, 20);
    ((Control) this.dateInvoiceDateFrom).TabIndex = 87;
    ((UltraControlBase) this.dateInvoiceDateFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateInvoiceDateFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.dateInvoiceDateFrom.Value = (object) new DateTime(2007, 1, 17, 0, 0, 0, 0);
    this.radioTransactionNum.BackColor = Color.FromArgb(239, 247, 253);
    this.radioTransactionNum.FlatStyle = FlatStyle.Flat;
    this.radioTransactionNum.Location = new Point(8, 202);
    this.radioTransactionNum.Name = "radioTransactionNum";
    this.radioTransactionNum.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.radioTransactionNum.TabIndex = 97;
    this.radioTransactionNum.Text = "Transaction # ";
    this.radioTransactionNum.UseVisualStyleBackColor = false;
    this.radioTransactionNum.CheckedChanged += new EventHandler(this.radioTransactionNum_CheckedChanged);
    this.panel1.Controls.Add((Control) this.gridCostCenter);
    this.panel1.Controls.Add((Control) this.panel4);
    this.panel1.Controls.Add((Control) this.panel2);
    this.panel1.Controls.Add((Control) this.panel3);
    this.panel1.Controls.Add((Control) this.labelCurtain);
    this.panel1.Cursor = Cursors.Default;
    this.panel1.Dock = DockStyle.Fill;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(1152, 766);
    this.panel1.TabIndex = 75;
    ((Control) this.gridCostCenter).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridCostCenter).DataMember = "SearchInvoiceData";
    ((UltraGridBase) this.gridCostCenter).DataSource = (object) this.dsChangeCostCenter1;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 1;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Appearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Trx. #";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 165;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Post Date";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 150;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 272;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Trx. Type";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 280;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ultraGridBand1.Override.AllowColSizing = (AllowColSizing) 2;
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 0;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 76;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 2;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 89;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Cost Center";
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 10;
    ultraGridColumn8.Width = 141;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 1;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 63 /*0x3F*/;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "GL Account";
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 6;
    ultraGridColumn10.Width = 113;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn11.Format = "c";
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 9;
    ultraGridColumn11.Width = 116;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.Format = "d";
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 5;
    ultraGridColumn12.Width = 117;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 4;
    ultraGridColumn13.Width = 103;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 3;
    ultraGridColumn14.Width = 121;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 8;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 92;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 7;
    ultraGridColumn16.Width = 137;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 11;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 92;
    ultraGridBand2.Columns.AddRange(new object[12]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17
    });
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance17).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance18).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance21).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance21).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance21;
    ((Control) this.gridCostCenter).Dock = DockStyle.Fill;
    ((Control) this.gridCostCenter).Font = new Font("Tahoma", 8f);
    ((Control) this.gridCostCenter).Location = new Point(264, 64 /*0x40*/);
    ((Control) this.gridCostCenter).Name = "gridCostCenter";
    ((Control) this.gridCostCenter).Size = new Size(888, 662);
    ((Control) this.gridCostCenter).TabIndex = 79;
    this.gridCostCenter.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    this.gridCostCenter.BeforeRowExpanded += new CancelableRowEventHandler(this.gridCostCenter_BeforeRowExpanded);
    this.gridCostCenter.DoubleClickRow += new DoubleClickRowEventHandler(this.gridCostCenter_DoubleClickRow);
    ((UltraGridBase) this.gridCostCenter).AfterSortChange += new BandEventHandler(this.gridCostCenter_AfterSortChange);
    ((Control) this.gridCostCenter).MouseUp += new MouseEventHandler(this.gridCostCenter_MouseUp);
    this.dsChangeCostCenter1.DataSetName = "dsChangeCostCenter";
    this.dsChangeCostCenter1.Locale = new CultureInfo("en-US");
    this.dsChangeCostCenter1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panel2.BackColor = Color.White;
    this.panel2.Controls.Add((Control) this.label3);
    this.panel2.Controls.Add((Control) this.pictureBox2);
    this.panel2.Controls.Add((Control) this.label2);
    this.panel2.Dock = DockStyle.Top;
    this.panel2.Location = new Point(0, 0);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(1152, 64 /*0x40*/);
    this.panel2.TabIndex = 75;
    this.label3.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label3.Dock = DockStyle.Bottom;
    this.label3.ForeColor = Color.Gray;
    this.label3.Location = new Point(0, 63 /*0x3F*/);
    this.label3.Name = "label3";
    this.label3.Size = new Size(1152, 1);
    this.label3.TabIndex = 80 /*0x50*/;
    this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
    this.pictureBox2.Location = new Point(24, 8);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox2.TabIndex = 2;
    this.pictureBox2.TabStop = false;
    this.label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.White;
    this.label2.Font = new Font("Arial", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Location = new Point(872, 32 /*0x20*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(265, 22);
    this.label2.TabIndex = 79;
    this.label2.Text = "Cost Center Re-Assignment";
    this.panel3.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panel3.Controls.Add((Control) this.buttonHelp);
    this.panel3.Controls.Add((Control) this.btnUpdate);
    this.panel3.Controls.Add((Control) this.btnCancel);
    this.panel3.Dock = DockStyle.Bottom;
    this.panel3.Location = new Point(0, 726);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(1152, 40);
    this.panel3.TabIndex = 76;
    ((Control) this.btnUpdate).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance22).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance22).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance22).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance22).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnUpdate).Appearance = (AppearanceBase) appearance22;
    ((Control) this.btnUpdate).Location = new Point(896, 8);
    ((Control) this.btnUpdate).Name = "btnUpdate";
    ((Control) this.btnUpdate).Size = new Size(120, 24);
    ((Control) this.btnUpdate).TabIndex = 1;
    ((Control) this.btnUpdate).Text = "Update";
    ((UltraControlBase) this.btnUpdate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnUpdate).Click += new EventHandler(this.btnUpdate_Click);
    ((Control) this.btnCancel).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance23).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance23).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance23).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance23).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance23).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance23;
    ((Control) this.btnCancel).Location = new Point(1024 /*0x0400*/, 8);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(120, 24);
    ((Control) this.btnCancel).TabIndex = 0;
    ((Control) this.btnCancel).Text = "Cancel";
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    this.labelCurtain.BackColor = Color.White;
    this.labelCurtain.Dock = DockStyle.Fill;
    this.labelCurtain.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelCurtain.ForeColor = Color.LightSlateGray;
    this.labelCurtain.Location = new Point(0, 0);
    this.labelCurtain.Name = "labelCurtain";
    this.labelCurtain.Size = new Size(1152, 766);
    this.labelCurtain.TabIndex = 78;
    this.labelCurtain.Text = "Loading Data...";
    this.labelCurtain.TextAlign = ContentAlignment.MiddleCenter;
    this.tip.ContainingControl = (Control) this;
    ((Control) this.buttonHelp).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance24).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance24).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance24).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance24).Image = componentResourceManager.GetObject("appearance22.Image");
    ((AppearanceBase) appearance24).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance24).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonHelp).Appearance = (AppearanceBase) appearance24;
    ((Control) this.buttonHelp).Location = new Point(8, 8);
    ((Control) this.buttonHelp).Name = "buttonHelp";
    ((Control) this.buttonHelp).Size = new Size(21, 24);
    ((Control) this.buttonHelp).TabIndex = 2;
    ((UltraControlBase) this.buttonHelp).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonHelp).Click += new EventHandler(this.buttonHelp_Click);
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(1152, 766);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formChangeCostCenter);
    this.SizeGripStyle = SizeGripStyle.Hide;
    this.Text = "Cost Center Reassignment";
    this.Closing += new CancelEventHandler(this.formChangeCostCenter_Closing);
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.panel4.ResumeLayout(false);
    ((ISupportInitialize) this.ultraGroupBox1).EndInit();
    ((Control) this.ultraGroupBox1).ResumeLayout(false);
    ((Control) this.ultraGroupBox1).PerformLayout();
    ((ISupportInitialize) this.dateTransactionDateFrom).EndInit();
    ((ISupportInitialize) this.dateTransactionDateTo).EndInit();
    ((ISupportInitialize) this.comboTransType).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnClear).EndInit();
    this.grpHasCostCenter.ResumeLayout(false);
    this.grpHasCostCenter.PerformLayout();
    ((ISupportInitialize) this.dateInvoiceDateTo).EndInit();
    ((ISupportInitialize) this.txtPoNum).EndInit();
    ((ISupportInitialize) this.txtTransactionNumber).EndInit();
    ((ISupportInitialize) this.txtInvoiceNum).EndInit();
    ((ISupportInitialize) this.comboUnderWriters).EndInit();
    ((ISupportInitialize) this.comboCostCenter).EndInit();
    ((ISupportInitialize) this.dateInvoiceDateFrom).EndInit();
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.gridCostCenter).EndInit();
    this.dsChangeCostCenter1.EndInit();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    ((ISupportInitialize) this.pictureBox2).EndInit();
    this.panel3.ResumeLayout(false);
    ((ISupportInitialize) this.btnUpdate).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.buttonHelp).EndInit();
    this.ResumeLayout(false);
  }

  public formChangeCostCenter()
  {
    this.InitializeComponent();
    this.LoadOfficeLocations();
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.LoadUnderWriters();
    this.LoadTransactionTypes();
  }

  private void LoadTransactionTypes()
  {
    DataSet dataSet = new DataSet();
    SqlDataAdapter sqlDataAdapter = (SqlDataAdapter) null;
    try
    {
      sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_getTransactionTypes", new SqlConnection(CurrentUser.Instance.ConnectionString)));
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.Fill(dataSet);
    }
    finally
    {
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
    ((UltraGridBase) this.comboTransType).DataSource = (object) dataSet;
    ((UltraDropDownBase) this.comboTransType).DisplayMember = "TransactionType";
    ((UltraDropDownBase) this.comboTransType).ValueMember = "TransactionTypeId";
  }

  private void LoadCostCenters()
  {
    DataSet dataSet = new DataSet();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetCostCentersList", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    SqlCommand sqlCommand = (SqlCommand) null;
    try
    {
      if (this.comboOfficeLocation.Value == null)
        return;
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) int.Parse(this.comboOfficeLocation.Value.ToString()));
      sqlDataAdapter.Fill(dataSet);
      ((UltraGridBase) this.comboCostCenter).DataSource = (object) dataSet.Tables[0];
      ((UltraDropDownBase) this.comboCostCenter).DisplayMember = "Name";
      ((UltraDropDownBase) this.comboCostCenter).ValueMember = "CostCenterId";
    }
    finally
    {
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
      if (sqlCommand != null)
      {
        if (sqlCommand.Connection.State != ConnectionState.Closed)
          sqlCommand.Connection.Close();
        sqlCommand.Connection.Dispose();
        sqlCommand.Dispose();
      }
    }
  }

  private void PopulateContextMenu()
  {
    DataTable dataSource = (DataTable) ((UltraGridBase) this.comboCostCenter).DataSource;
    if (dataSource == null || dataSource.Rows.Count <= 0)
      return;
    this.contextCostCenter.MenuItems.Clear();
    MenuItem[] items = new MenuItem[dataSource.Rows.Count];
    int num = 0;
    foreach (DataRow row in (InternalDataCollectionBase) dataSource.Rows)
      items[num++] = new MenuItem(row["Name"].ToString(), new EventHandler(this.ContextCostCenter_Click));
    this.contextCostCenter.MenuItems.AddRange(items);
  }

  private void LoadUnderWriters()
  {
    DataSet dataSet = new DataSet();
    SqlDataAdapter sqlDataAdapter = (SqlDataAdapter) null;
    try
    {
      sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetUnderWriters", new SqlConnection(CurrentUser.Instance.ConnectionString)));
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.Fill(dataSet);
    }
    finally
    {
      if (sqlDataAdapter.SelectCommand.Connection.State != ConnectionState.Closed)
        sqlDataAdapter.SelectCommand.Connection.Close();
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
    ((UltraGridBase) this.comboUnderWriters).DataSource = (object) dataSet;
    ((UltraDropDownBase) this.comboUnderWriters).DisplayMember = "FullName";
    ((UltraDropDownBase) this.comboUnderWriters).ValueMember = "USerGuid";
  }

  private void ContextCostCenter_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    DataRow[] dataRowArray = this.dtContextMenu.Select($"Name='{((MenuItem) sender).Text}'");
    bool flag = false;
    if (this.gridCostCenter.Selected.Rows == null || ((SparseCollectionBase) this.gridCostCenter.Selected.Rows).Count == 0)
      return;
    if (this.gridCostCenter.Selected.Rows[0].ChildBands != null && ((DisposableObjectCollectionBase) this.gridCostCenter.Selected.Rows[0].ChildBands).Count > 0 && this.gridCostCenter.Selected.Rows[0].ChildBands[0].Rows != null)
      flag = true;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Bands[0].Override.AllowUpdate = (DefaultableBoolean) 1;
    if (flag)
    {
      foreach (UltraGridRow row1 in this.gridCostCenter.Selected.Rows)
      {
        this.LoadChildNodes(row1);
        foreach (UltraGridRow row2 in row1.ChildBands[0].Rows)
        {
          if (dataRowArray.Length != 0)
          {
            row2.Cells["CostCenterName"].Value = dataRowArray[0]["Name"];
            row2.Cells["NewcostcenterID"].Value = (object) int.Parse(dataRowArray[0]["CostCenterID"].ToString());
            ((AppearanceBase) row2.Appearance).FontData.Bold = (DefaultableBoolean) 1;
          }
        }
      }
    }
    else
    {
      foreach (UltraGridRow row in this.gridCostCenter.Selected.Rows)
      {
        if (dataRowArray.Length != 0)
        {
          row.Cells["CostCenterName"].Value = dataRowArray[0]["Name"];
          row.Cells["NewcostcenterID"].Value = (object) int.Parse(dataRowArray[0]["CostCenterID"].ToString());
          ((AppearanceBase) row.Appearance).FontData.Bold = (DefaultableBoolean) 1;
        }
      }
    }
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Bands[0].Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCostCenter).UpdateData();
    this.ReassginCostCenterAndReAllocateAmount();
    this.dsCostCenterData.AcceptChanges();
    this.Cursor = Cursors.Default;
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    if (this.comboOfficeLocation.Value == null)
      return;
    this.LoadCostCenters();
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.LoadCostCenters();
  }

  private void ReassginCostCenterAndReAllocateAmount()
  {
    int num1 = -1;
    int num2 = -1;
    Decimal num3 = 0.0M;
    foreach (DataRow row in (InternalDataCollectionBase) this.dsCostCenterData.CostCenterData.Rows)
    {
      if (row.RowState != DataRowState.Deleted && row["NewCostCenterId"] != DBNull.Value)
      {
        DataRow[] dataRowArray = this.dsCostCenterData.CostCenterData.Select($"PostingNum ='{row["PostingNum"].ToString()}' and transactnum ='{row["transactnum"].ToString()}'");
        for (int index1 = 0; index1 < dataRowArray.Length; ++index1)
        {
          if (dataRowArray[index1].RowState != DataRowState.Deleted)
          {
            num3 = 0.0M;
            if (dataRowArray[index1]["NewCostCenterId"] != DBNull.Value)
              num2 = int.Parse(dataRowArray[index1]["NewCostCenterId"].ToString());
            else if (dataRowArray[index1]["CostCenter"] != DBNull.Value)
              num2 = int.Parse(dataRowArray[index1]["CostCenter"].ToString());
            Decimal num4 = Decimal.Parse(dataRowArray[index1]["Amount"].ToString(), NumberStyles.Any);
            for (int index2 = index1 + 1; index2 < dataRowArray.Length; ++index2)
            {
              if (dataRowArray[index2].RowState != DataRowState.Deleted)
              {
                if (dataRowArray[index2]["NewCostCenterId"] != DBNull.Value)
                  num1 = int.Parse(dataRowArray[index2]["NewCostCenterId"].ToString());
                else if (dataRowArray[index2]["CostCenter"] != DBNull.Value)
                  num1 = int.Parse(dataRowArray[index2]["CostCenter"].ToString());
                if (num2 == num1)
                {
                  num4 += Decimal.Parse(dataRowArray[index2]["Amount"].ToString(), NumberStyles.Any);
                  dataRowArray[index2].Delete();
                }
              }
            }
            dataRowArray[index1]["Amount"] = (object) num4;
          }
        }
      }
    }
    this.dsCostCenterData.AcceptChanges();
  }

  private void UpdateCostCenters()
  {
    int num1 = 0;
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand sqlCommand = new SqlCommand("SpFin_UpdateCostCenter", connection);
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.Parameters.AddWithValue("@costCenterId", (object) SqlDbType.Int);
    sqlCommand.Parameters.AddWithValue("@amount", (object) SqlDbType.Money);
    sqlCommand.Parameters.AddWithValue("@PostingNum", (object) SqlDbType.Int);
    sqlCommand.Parameters.AddWithValue("@isDelete", (object) SqlDbType.Bit);
    connection.Open();
    foreach (DataRow row in (InternalDataCollectionBase) this.dsCostCenterData.SearchInvoiceData.Rows)
    {
      int transNum = int.Parse(row["TransactNum"].ToString());
      if (this.TransactionExists(transNum))
      {
        DataRow[] dataRowArray = this.dsCostCenterData.CostCenterData.Select($"transactnum ='{transNum.ToString()}'");
        for (int index1 = 0; index1 < dataRowArray.Length; ++index1)
        {
          if (dataRowArray[index1].RowState != DataRowState.Deleted && (dataRowArray[index1]["CostCenter"] != DBNull.Value || dataRowArray[index1]["NewCostCenterId"] != DBNull.Value))
          {
            if (dataRowArray[index1]["NewCostCenterId"] != DBNull.Value)
              num1 = int.Parse(dataRowArray[index1]["NewCostCenterId"].ToString());
            else if (dataRowArray[index1]["CostCenter"] != DBNull.Value)
              num1 = int.Parse(dataRowArray[index1]["CostCenter"].ToString());
            int num2 = int.Parse(dataRowArray[index1]["PostingNum"].ToString());
            Decimal num3 = Decimal.Parse(dataRowArray[index1]["amount"].ToString(), NumberStyles.Any);
            sqlCommand.Parameters["@costCenterId"].Value = (object) num1;
            sqlCommand.Parameters["@amount"].Value = (object) num3;
            sqlCommand.Parameters["@PostingNum"].Value = (object) num2;
            sqlCommand.Parameters["@isDelete"].Value = (object) true;
            sqlCommand.ExecuteNonQuery();
            for (int index2 = index1 + 1; index2 < dataRowArray.Length; ++index2)
            {
              if (dataRowArray[index2].RowState != DataRowState.Deleted)
              {
                int num4 = int.Parse(dataRowArray[index2]["postingNum"].ToString());
                if (num4 == num2)
                {
                  if (dataRowArray[index2]["NewCostCenterId"] != DBNull.Value)
                    num1 = int.Parse(dataRowArray[index2]["NewCostCenterId"].ToString());
                  else if (dataRowArray[index2]["CostCenter"] != DBNull.Value)
                    num1 = int.Parse(dataRowArray[index2]["CostCenter"].ToString());
                  Decimal num5 = Decimal.Parse(dataRowArray[index2]["amount"].ToString(), NumberStyles.Any);
                  sqlCommand.Parameters["@costCenterId"].Value = (object) num1;
                  sqlCommand.Parameters["@amount"].Value = (object) num5;
                  sqlCommand.Parameters["@PostingNum"].Value = (object) num4;
                  sqlCommand.Parameters["@isDelete"].Value = (object) false;
                  sqlCommand.ExecuteNonQuery();
                  dataRowArray[index2].Delete();
                }
              }
            }
            dataRowArray[index1].Delete();
          }
        }
      }
    }
    if (!this.InvokeRequired)
      return;
    this.Invoke((Delegate) new formChangeCostCenter.PreThreadLoadHanndler(this.PreLoad), (object) true);
  }

  private void LoadSearchData()
  {
    this.dsCostCenterData = new dsChangeCostCenter();
    try
    {
      this.da.SelectCommand.CommandTimeout = 120;
      this.da.Fill((DataTable) this.dsCostCenterData.SearchInvoiceData);
    }
    catch (SqlException ex)
    {
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new formChangeCostCenter.ThreadErrorHandler(this.HandleException), (object) ex);
    }
    finally
    {
      if (this.da.SelectCommand.Connection.State != ConnectionState.Closed)
        this.da.SelectCommand.Connection.Close();
      this.da.SelectCommand.Connection.Dispose();
      this.da.SelectCommand.Dispose();
      this.da.Dispose();
      if (!this.IsDisposed && !this.Disposing)
        this.Invoke((Delegate) new formChangeCostCenter.ThreadExecutionCompletedHandler(this.LoadDataCompleted));
    }
  }

  private void gridCostCenter_AfterSortChange(object sender, BandEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Band).Key == "SearchInvoiceData") || ((DisposableObjectCollectionBase) e.Band.SortedColumns).Count <= 0)
      return;
    ((UltraGridBase) this.gridCostCenter).DisplayLayout.Bands[0].ScrollTipField = ((KeyedSubObjectBase) e.Band.SortedColumns[0]).Key;
  }

  private void gridCostCenter_MouseUp(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right || this.gridCostCenter.Selected.Rows == null || ((SparseCollectionBase) this.gridCostCenter.Selected.Rows).Count == 0)
      return;
    this.contextCostCenter.Show((Control) this.gridCostCenter, ((Control) this.gridCostCenter).PointToClient(Control.MousePosition));
  }

  private void btnCancel_Click(object sender, EventArgs e)
  {
    this.Dispose();
    this.Close();
  }

  private bool VerifyForm()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridCostCenter).Rows).Count != 0)
      return true;
    int num = (int) MessageBox.Show("You must search for items and make edits before you can update the data.", "No Data To Update!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void btnUpdate_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    int num = 0;
    this.nodesExpanedBeforeSave = new int[this.dsCostCenterData.SearchInvoiceData.Count];
    foreach (UltraGridRow row in ((UltraGridBase) this.gridCostCenter).Rows)
    {
      if (row.Expanded)
        this.nodesExpanedBeforeSave[num++] = int.Parse(row.Cells["transactNum"].Value.ToString());
    }
    this.Cursor = Cursors.WaitCursor;
    if (this.dsCostCenterData == null || this.dsCostCenterData.Tables.Count == 0 || this.dsCostCenterData.Tables[0].Rows.Count == 0)
      return;
    this.PreLoad(false);
  }

  private void btnClear_Click(object sender, EventArgs e) => this.ClearSearchOptions();

  private void btnSearch_Click(object sender, EventArgs e) => this.DoSearch();

  private void DoSearch()
  {
    if (this.comboOfficeLocation.SelectedIndex == -1 || ((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an office location to contiue.", "Require Item Missing !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.PopulateContextMenu();
      this.dtContextMenu = ((DataTable) ((UltraGridBase) this.comboCostCenter).DataSource).Copy();
      this.nodesExpanedBeforeSave = (int[]) null;
      this.costCenterDataLoadedNodes = (int[]) null;
      if (this.comboOfficeLocation.SelectedIndex == -1)
        return;
      this.PreLoad(true);
    }
  }

  private void radioPoNum_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.txtPoNum).Enabled = this.radioPoNum.Checked;
  }

  private void radioInvoiceNum_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.txtInvoiceNum).Enabled = this.radioInvoiceNum.Checked;
  }

  private void radioUnderWriter_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.comboUnderWriters).Enabled = this.radioUnderWriter.Checked;
  }

  private void radioTransactionDateRange_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.dateTransactionDateFrom).Enabled = ((Control) this.dateTransactionDateTo).Enabled = this.radioTransactionDateRange.Checked;
  }

  private void radioTransactionNum_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.txtTransactionNumber).Enabled = this.radioTransactionNum.Checked;
  }

  private void radioInvoiceDate_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.dateInvoiceDateFrom).Enabled = ((Control) this.dateInvoiceDateTo).Enabled = this.radioInvoiceDate.Checked;
  }

  private void radioCostCenter_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.comboCostCenter).Enabled = this.radioCostCenter.Checked;
  }

  private void ClearSearchOptions()
  {
    if (this.dsCostCenterData != null)
    {
      this.dsCostCenterData.Clear();
      this.dsCostCenterData.AcceptChanges();
    }
    this.comboCostCenter.SelectedIndex = -1;
    this.comboOfficeLocation.SelectedIndex = -1;
    this.comboUnderWriters.SelectedIndex = -1;
    this.comboCostCenter.SelectedIndex = -1;
    this.comboOfficeLocation.SelectedIndex = -1;
    ((Control) this.comboUnderWriters).Enabled = false;
    this.comboTransType.SelectedIndex = -1;
    this.radioCostCenter.Checked = false;
    this.radioUnderWriter.Checked = false;
    this.radioInvoiceNum.Checked = false;
    this.radioInvoiceDate.Checked = false;
    this.radioTransactionNum.Checked = false;
    this.radioTransactionDateRange.Checked = false;
    this.radioPoNum.Checked = false;
    this.chkNoCostCenter.Checked = false;
    this.radioTrasnsType.Checked = false;
    ((Control) this.txtInvoiceNum).Text = string.Empty;
    ((Control) this.txtTransactionNumber).Text = string.Empty;
    ((Control) this.txtPoNum).Text = string.Empty;
  }

  private void formChangeCostCenter_Closing(object sender, CancelEventArgs e)
  {
    if (this.formSecondCostCenter != null)
      this.formSecondCostCenter.Dispose();
    this.formSecondCostCenter = (formChangeSecondCostCenter) null;
  }

  private void SetUpSearchOptionParameters()
  {
    this.da = (SqlDataAdapter) null;
    this.da = new SqlDataAdapter(new SqlCommand("spFin_CostCenterReassignment", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    this.da.SelectCommand.CommandType = CommandType.StoredProcedure;
    this.da.SelectCommand.Parameters.AddWithValue("@glcompanyid", this.comboOfficeLocation.Value);
    if (this.radioTransactionDateRange.Checked && this.dateTransactionDateFrom.Value.ToString() != string.Empty && this.dateTransactionDateTo.Value.ToString() != string.Empty)
    {
      this.da.SelectCommand.Parameters.AddWithValue("@dateFrom", this.dateTransactionDateFrom.Value);
      this.da.SelectCommand.Parameters.AddWithValue("@dateTo", this.dateTransactionDateTo.Value);
    }
    if (this.radioTrasnsType.Checked && this.comboTransType.SelectedIndex != -1)
      this.da.SelectCommand.Parameters.AddWithValue("@transType", this.comboTransType.Value);
    if (this.chkNoCostCenter.Checked)
    {
      this.da.SelectCommand.Parameters.AddWithValue("@noCostCenter", (object) true);
    }
    else
    {
      if (this.radioCostCenter.Checked && ((UltraDropDownBase) this.comboCostCenter).SelectedRow != null)
        this.da.SelectCommand.Parameters.AddWithValue("@costcenter", this.comboCostCenter.Value);
      if (this.radioUnderWriter.Checked && ((UltraDropDownBase) this.comboUnderWriters).SelectedRow != null)
        this.da.SelectCommand.Parameters.AddWithValue("@underwriter", this.comboUnderWriters.Value);
      if (this.radioTransactionNum.Checked && ((Control) this.txtTransactionNumber).Text != string.Empty)
        this.da.SelectCommand.Parameters.AddWithValue("@transactNum", ((TextEditorControlBase) this.txtTransactionNumber).Value);
      if (this.radioInvoiceNum.Checked && ((Control) this.txtInvoiceNum).Text != string.Empty)
        this.da.SelectCommand.Parameters.AddWithValue("@invoicenum", ((TextEditorControlBase) this.txtInvoiceNum).Value);
      if (this.radioInvoiceDate.Checked && this.dateInvoiceDateFrom.Value.ToString() != string.Empty && this.dateInvoiceDateTo.Value.ToString() != string.Empty)
      {
        this.da.SelectCommand.Parameters.AddWithValue("@invoicedateto", this.dateInvoiceDateTo.Value);
        this.da.SelectCommand.Parameters.AddWithValue("@invoicedatefrom", this.dateInvoiceDateFrom.Value);
      }
      if (!this.radioPoNum.Checked || !(((Control) this.txtPoNum).Text != string.Empty))
        return;
      this.da.SelectCommand.Parameters.AddWithValue("@poNum", ((TextEditorControlBase) this.txtPoNum).Value);
    }
  }

  private void PreLoad(bool IsLoadingSerachData)
  {
    this.Cursor = Cursors.WaitCursor;
    ((Control) this.btnSearch).Enabled = false;
    ((Control) this.btnUpdate).Enabled = false;
    if (IsLoadingSerachData)
    {
      this.SetUpSearchOptionParameters();
      this.labelCurtain.BringToFront();
      new Thread(new ThreadStart(this.LoadSearchData)).Start();
    }
    else
    {
      this.labelCurtain.BringToFront();
      this._isLoadingAfterUpdate = true;
      new Thread(new ThreadStart(this.UpdateCostCenters)).Start();
    }
  }

  private void LoadDataCompleted()
  {
    if (this.IsDisposed && this.Disposing)
      return;
    ((UltraGridBase) this.gridCostCenter).DataSource = (object) this.dsCostCenterData;
    this.costCenterDataLoadedNodes = new int[this.dsCostCenterData.SearchInvoiceData.Count];
    this.costCenterDataLoadCurrentIndex = 0;
    if (this._isLoadingAfterUpdate && this.nodesExpanedBeforeSave != null)
    {
      for (int index = 0; index < this.nodesExpanedBeforeSave.Length && index < 100; ++index)
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.gridCostCenter).Rows)
        {
          if (int.Parse(row.Cells["transactnum"].Value.ToString()) == this.nodesExpanedBeforeSave[index])
          {
            row.ExpandAll();
            break;
          }
        }
      }
    }
    ((Control) this.btnSearch).Enabled = true;
    ((Control) this.btnUpdate).Enabled = true;
    this.Cursor = Cursors.Default;
    this.labelCurtain.SendToBack();
  }

  private void HandleException(Exception e)
  {
    if (!this.IsDisposed || !this.Disposing)
    {
      ((Control) this.btnSearch).Enabled = true;
      ((Control) this.btnUpdate).Enabled = true;
      this.Cursor = Cursors.Default;
      this.labelCurtain.SendToBack();
      throw e;
    }
  }

  private void UpdateCompleted() => this.PreLoad(true);

  private void chkNoCostCenter_CheckedChanged(object sender, EventArgs e)
  {
    this.grpHasCostCenter.Enabled = !this.chkNoCostCenter.Checked;
  }

  private void radioTrasnsType_CheckedChanged(object sender, EventArgs e)
  {
    ((Control) this.comboTransType).Enabled = this.radioTrasnsType.Checked;
  }

  private void gridCostCenter_BeforeRowExpanded(object sender, CancelableRowEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    this.LoadChildNodes(e.Row);
    this.Cursor = Cursors.Default;
  }

  private void LoadChildNodes(UltraGridRow r)
  {
    int num = int.Parse(r.Cells["Transactnum"].Value.ToString());
    if (this.TransactionExists(num))
      return;
    this.GetCostCenterData(num);
    this.costCenterDataLoadedNodes[this.costCenterDataLoadCurrentIndex++] = num;
  }

  private bool TransactionExists(int transNum)
  {
    for (int index = 0; index < this.costCenterDataLoadCurrentIndex; ++index)
    {
      if (this.costCenterDataLoadedNodes[index] == transNum)
        return true;
    }
    return false;
  }

  private void GetCostCenterData(int transactionNumber)
  {
    SqlDataAdapter sqlDataAdapter = (SqlDataAdapter) null;
    try
    {
      sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_CostCenterReassignmentCostCenterData", new SqlConnection(CurrentUser.Instance.ConnectionString)));
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@transactionNumber", (object) transactionNumber);
      if (this.radioCostCenter.Checked && this.comboCostCenter.SelectedIndex != -1 && ((UltraDropDownBase) this.comboCostCenter).SelectedRow != null)
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@costcenterid", (object) int.Parse(this.comboCostCenter.Value.ToString()));
      sqlDataAdapter.Fill((DataTable) this.dsCostCenterData.CostCenterData);
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

  private void gridCostCenter_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    if (((GridItemBase) e.Row).Band.Index != 1)
      return;
    using (FormChangeCostCenterAmounts costCenterAmounts = new FormChangeCostCenterAmounts(int.Parse(e.Row.Cells["PostingNum"].Value.ToString())))
    {
      if (costCenterAmounts.ShowDialog() != DialogResult.OK)
        return;
      this.DoSearch();
    }
  }

  private void buttonHelp_Click(object sender, EventArgs e)
  {
    Help.ShowHelp((Control) this, "imsaccountinghelp.chm", HelpNavigator.Topic, (object) "EditingCostCenters.htm");
  }

  private delegate void ThreadExecutionCompletedHandler();

  private delegate void ThreadErrorHandler(Exception e);

  private delegate void PreThreadLoadHanndler(bool IsLoadingData);
}
