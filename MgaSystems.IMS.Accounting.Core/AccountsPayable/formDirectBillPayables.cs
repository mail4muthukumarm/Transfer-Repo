// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsPayable.formDirectBillPayables
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.CalcEngine;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinCalcManager;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.Exceptions;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsPayable;

public class formDirectBillPayables : AccountingNoteDocumentSupport
{
  private bool _formClosing;
  private string _nextPayeeName = string.Empty;
  protected Panel panelLeftSide;
  protected Panel panelMainDisplay;
  protected Panel panel1;
  protected Label label1;
  protected Label label2;
  protected Label label3;
  protected Label label4;
  protected Label label5;
  protected Panel panel7;
  protected Label label6;
  protected Panel panel8;
  protected Label label8;
  protected PictureBox pictureBox1;
  protected Panel panelStep6;
  protected Panel panelStep5;
  protected Panel panelStep4;
  protected Panel panelStep3;
  protected Panel panelStep2;
  protected Panel panelStep7;
  protected Label label7;
  protected Panel panelStep1;
  protected Label label9;
  protected Panel panelDateOfficeLocation;
  protected Label label10;
  protected Label labelOfficeLocation;
  protected Label label11;
  protected Panel panelCollectingDirectBillInvoices;
  protected Label labelPhaseTitle;
  protected Label labelPhaseInformation;
  protected PictureBox pictureBox2;
  protected MGASimpleComboBox comboOfficeLocation;
  protected MGAButton buttonPostSelectedResults;
  protected MGAButton buttonCancel;
  protected SqlDataAdapter daGetOfficeLocation;
  protected SqlCommand sqlSelectCommand1;
  protected SqlConnection FormDataConnection;
  protected Panel panelResults;
  protected CheckBox checkShowProducers;
  protected CheckBox checkShowCompanies;
  protected CheckBox checkShowOthers;
  protected dsDirectBillPayables dsDirectBillPayables1;
  protected MGASimpleComboBox comboBankAccounts;
  protected Label label12;
  protected dsBankAccounts dsBankAccounts1;
  protected SqlDataAdapter daGetBankAccounts;
  protected SqlCommand sqlSelectCommand2;
  protected MGADateTimePicker dateTimeCutOff;
  protected MGADateTimePicker dateTimeCheckDate;
  protected Label label13;
  protected RequiredFieldValidator requiredFieldValidator1;
  protected RequiredFieldValidator requiredFieldValidator2;
  protected RequiredFieldValidator requiredFieldValidator3;
  protected Panel panelCreatingChecks;
  protected Label label14;
  protected MGAStatusLook mgaStatusLook1;
  protected UltraGrid gridCheckBuilding;
  protected Panel panel2;
  protected MGACheckBox checkLimitCompanies;
  protected MGASimpleComboBox comboCompanies;
  protected MGAButton buttonExportData;
  private UltraCalcManager ultraCalcManager1;
  private MGATextBox textCheckTotal;
  private Label label15;
  private PictureBox pictCalculate;
  protected MGAButton buttonContinue;
  protected MGACheckBox checkLimitCompanyGroups;
  protected MGASimpleComboBox comboCompanyGroups;
  public UltraGrid gridDirectBillResults;
  private LinkLabel linkLabel2;
  private LinkLabel linkLabel1;
  private StatusStrip statusCreditStatements;
  private ToolStripStatusLabel labelProcessCreditStatements;
  private ToolStripProgressBar progressCreditStatements;
  private ToolStripStatusLabel toolStripStatusLabel2;
  private IContainer components;
  private int GlCompanyId;
  private bool DoInitializeRow = true;
  private Thread phaseThread;
  private DirectBillUtility directBillUtility;
  private Font CurrentTabFont = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
  private Font NonCurrentTabFont = new Font("Arial", 8.25f);
  private DataSet ds;
  private DataSet dsCheckCreation;

  public formDirectBillPayables() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    this.CurrentTabFont.Dispose();
    this.NonCurrentTabFont.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formDirectBillPayables));
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("Payees", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PayeeName");
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("TotalGrossPayable");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("TotalPropAmt");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CreateCheck");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PayeesInvoices");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("SelectPayee", 0);
    UltraGridBand ultraGridBand2 = new UltraGridBand("PayeesInvoices", 0);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("OfficeInvoiceNum", -1, (object) null, 0, (SortIndicator) 2, false);
    Appearance appearance19 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("GrossPayable");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("ProportionalAmount");
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("InsuredName");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("EntityAPAccount");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("SelectInvoice", 0);
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    this.panelLeftSide = new Panel();
    this.panel2 = new Panel();
    this.pictCalculate = new PictureBox();
    this.textCheckTotal = new MGATextBox();
    this.label15 = new Label();
    this.buttonExportData = new MGAButton();
    this.panel7 = new Panel();
    this.panelStep7 = new Panel();
    this.label7 = new Label();
    this.label6 = new Label();
    this.panelStep6 = new Panel();
    this.label5 = new Label();
    this.panelStep5 = new Panel();
    this.label4 = new Label();
    this.panelStep4 = new Panel();
    this.label3 = new Label();
    this.panelStep3 = new Panel();
    this.label2 = new Label();
    this.panelStep2 = new Panel();
    this.label1 = new Label();
    this.panelStep1 = new Panel();
    this.label9 = new Label();
    this.panelMainDisplay = new Panel();
    this.panel8 = new Panel();
    this.linkLabel2 = new LinkLabel();
    this.linkLabel1 = new LinkLabel();
    this.buttonContinue = new MGAButton();
    this.buttonPostSelectedResults = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.ultraCalcManager1 = new UltraCalcManager(this.components);
    this.dsDirectBillPayables1 = new dsDirectBillPayables();
    this.panelDateOfficeLocation = new Panel();
    this.checkLimitCompanyGroups = new MGACheckBox();
    this.comboCompanyGroups = new MGASimpleComboBox();
    this.checkLimitCompanies = new MGACheckBox();
    this.comboCompanies = new MGASimpleComboBox();
    this.dateTimeCheckDate = new MGADateTimePicker();
    this.label13 = new Label();
    this.comboBankAccounts = new MGASimpleComboBox();
    this.dsBankAccounts1 = new dsBankAccounts();
    this.label12 = new Label();
    this.checkShowOthers = new CheckBox();
    this.checkShowCompanies = new CheckBox();
    this.checkShowProducers = new CheckBox();
    this.dateTimeCutOff = new MGADateTimePicker();
    this.label11 = new Label();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.labelOfficeLocation = new Label();
    this.label10 = new Label();
    this.panelCreatingChecks = new Panel();
    this.gridCheckBuilding = new UltraGrid();
    this.label14 = new Label();
    this.panelCollectingDirectBillInvoices = new Panel();
    this.pictureBox2 = new PictureBox();
    this.labelPhaseInformation = new Label();
    this.labelPhaseTitle = new Label();
    this.panelResults = new Panel();
    this.gridDirectBillResults = new UltraGrid();
    this.panel1 = new Panel();
    this.pictureBox1 = new PictureBox();
    this.label8 = new Label();
    this.daGetOfficeLocation = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.sqlSelectCommand2 = new SqlCommand();
    this.requiredFieldValidator1 = new RequiredFieldValidator(this.components);
    this.requiredFieldValidator2 = new RequiredFieldValidator(this.components);
    this.requiredFieldValidator3 = new RequiredFieldValidator(this.components);
    this.mgaStatusLook1 = new MGAStatusLook(this.components);
    this.statusCreditStatements = new StatusStrip();
    this.toolStripStatusLabel2 = new ToolStripStatusLabel();
    this.labelProcessCreditStatements = new ToolStripStatusLabel();
    this.progressCreditStatements = new ToolStripProgressBar();
    this.panelLeftSide.SuspendLayout();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.pictCalculate).BeginInit();
    ((ISupportInitialize) this.textCheckTotal).BeginInit();
    ((ISupportInitialize) this.buttonExportData).BeginInit();
    this.panel7.SuspendLayout();
    this.panelStep7.SuspendLayout();
    this.panelStep6.SuspendLayout();
    this.panelStep5.SuspendLayout();
    this.panelStep4.SuspendLayout();
    this.panelStep3.SuspendLayout();
    this.panelStep2.SuspendLayout();
    this.panelStep1.SuspendLayout();
    this.panel8.SuspendLayout();
    ((ISupportInitialize) this.buttonContinue).BeginInit();
    ((ISupportInitialize) this.buttonPostSelectedResults).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.ultraCalcManager1).BeginInit();
    this.dsDirectBillPayables1.BeginInit();
    this.panelDateOfficeLocation.SuspendLayout();
    ((ISupportInitialize) this.checkLimitCompanyGroups).BeginInit();
    ((ISupportInitialize) this.comboCompanyGroups).BeginInit();
    ((ISupportInitialize) this.checkLimitCompanies).BeginInit();
    ((ISupportInitialize) this.comboCompanies).BeginInit();
    ((ISupportInitialize) this.dateTimeCheckDate).BeginInit();
    ((ISupportInitialize) this.comboBankAccounts).BeginInit();
    this.dsBankAccounts1.BeginInit();
    ((ISupportInitialize) this.dateTimeCutOff).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.panelCreatingChecks.SuspendLayout();
    ((ISupportInitialize) this.gridCheckBuilding).BeginInit();
    this.panelCollectingDirectBillInvoices.SuspendLayout();
    ((ISupportInitialize) this.pictureBox2).BeginInit();
    this.panelResults.SuspendLayout();
    ((ISupportInitialize) this.gridDirectBillResults).BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    ((ISupportInitialize) this.requiredFieldValidator1).BeginInit();
    ((ISupportInitialize) this.requiredFieldValidator2).BeginInit();
    ((ISupportInitialize) this.requiredFieldValidator3).BeginInit();
    this.statusCreditStatements.SuspendLayout();
    this.SuspendLayout();
    this.panelLeftSide.BackgroundImage = (Image) componentResourceManager.GetObject("panelLeftSide.BackgroundImage");
    this.panelLeftSide.Controls.Add((Control) this.panel2);
    this.panelLeftSide.Controls.Add((Control) this.panel7);
    this.panelLeftSide.Controls.Add((Control) this.panelStep6);
    this.panelLeftSide.Controls.Add((Control) this.panelStep5);
    this.panelLeftSide.Controls.Add((Control) this.panelStep4);
    this.panelLeftSide.Controls.Add((Control) this.panelStep3);
    this.panelLeftSide.Controls.Add((Control) this.panelStep2);
    this.panelLeftSide.Controls.Add((Control) this.panelStep1);
    this.panelLeftSide.Dock = DockStyle.Left;
    this.panelLeftSide.Location = new Point(0, 64 /*0x40*/);
    this.panelLeftSide.Name = "panelLeftSide";
    this.panelLeftSide.Size = new Size(184, 611);
    this.panelLeftSide.TabIndex = 0;
    this.panel2.BackgroundImage = (Image) componentResourceManager.GetObject("panel2.BackgroundImage");
    this.panel2.Controls.Add((Control) this.pictCalculate);
    this.panel2.Controls.Add((Control) this.textCheckTotal);
    this.panel2.Controls.Add((Control) this.label15);
    this.panel2.Controls.Add((Control) this.buttonExportData);
    this.panel2.Dock = DockStyle.Fill;
    this.panel2.Location = new Point(0, 224 /*0xE0*/);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(184, 387);
    this.panel2.TabIndex = 7;
    this.pictCalculate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.pictCalculate.BackColor = Color.White;
    this.pictCalculate.BorderStyle = BorderStyle.FixedSingle;
    this.pictCalculate.Image = (Image) Resources.eye;
    this.pictCalculate.Location = new Point(149, 319);
    this.pictCalculate.Name = "pictCalculate";
    this.pictCalculate.Size = new Size(19, 19);
    this.pictCalculate.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictCalculate.TabIndex = 5;
    this.pictCalculate.TabStop = false;
    this.pictCalculate.Visible = false;
    this.pictCalculate.Click += new EventHandler(this.pictCalculate_Click);
    ((Control) this.textCheckTotal).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckTotal).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textCheckTotal).BackColor = Color.White;
    ((Control) this.textCheckTotal).Location = new Point(6, 319);
    this.textCheckTotal.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckTotal).Name = "textCheckTotal";
    ((EditorButtonControlBase) this.textCheckTotal).ReadOnly = true;
    ((Control) this.textCheckTotal).Size = new Size(144 /*0x90*/, 19);
    ((Control) this.textCheckTotal).TabIndex = 4;
    ((UltraControlBase) this.textCheckTotal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckTotal).UseOsThemes = (DefaultableBoolean) 2;
    this.label15.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.label15.AutoSize = true;
    this.label15.BackColor = Color.Transparent;
    this.label15.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label15.Location = new Point(4, 304);
    this.label15.Name = "label15";
    this.label15.Size = new Size(81, 14);
    this.label15.TabIndex = 3;
    this.label15.Text = "Checks Total:";
    ((Control) this.buttonExportData).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = (object) Resources.Excel;
    ((ControlBase) this.buttonExportData).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonExportData).Enabled = false;
    ((Control) this.buttonExportData).Location = new Point(7, 355);
    ((Control) this.buttonExportData).Name = "buttonExportData";
    ((Control) this.buttonExportData).Size = new Size(109, 24);
    ((Control) this.buttonExportData).TabIndex = 2;
    ((Control) this.buttonExportData).Text = "Export Data";
    ((UltraControlBase) this.buttonExportData).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonExportData).Click += new EventHandler(this.buttonExportData_Click);
    this.panel7.BackColor = Color.GhostWhite;
    this.panel7.Controls.Add((Control) this.panelStep7);
    this.panel7.Controls.Add((Control) this.label6);
    this.panel7.Dock = DockStyle.Top;
    this.panel7.Location = new Point(0, 192 /*0xC0*/);
    this.panel7.Name = "panel7";
    this.panel7.Size = new Size(184, 32 /*0x20*/);
    this.panel7.TabIndex = 5;
    this.panelStep7.BackColor = Color.GhostWhite;
    this.panelStep7.Controls.Add((Control) this.label7);
    this.panelStep7.Dock = DockStyle.Top;
    this.panelStep7.Location = new Point(0, 0);
    this.panelStep7.Name = "panelStep7";
    this.panelStep7.Size = new Size(184, 32 /*0x20*/);
    this.panelStep7.TabIndex = 6;
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.Location = new Point(8, 8);
    this.label7.Name = "label7";
    this.label7.Size = new Size(40, 14);
    this.label7.TabIndex = 0;
    this.label7.Text = "Ready!";
    this.label6.AutoSize = true;
    this.label6.Location = new Point(8, 8);
    this.label6.Name = "label6";
    this.label6.Size = new Size(40, 14);
    this.label6.TabIndex = 0;
    this.label6.Text = "Ready!";
    this.panelStep6.BackColor = Color.GhostWhite;
    this.panelStep6.Controls.Add((Control) this.label5);
    this.panelStep6.Dock = DockStyle.Top;
    this.panelStep6.Location = new Point(0, 160 /*0xA0*/);
    this.panelStep6.Name = "panelStep6";
    this.panelStep6.Size = new Size(184, 32 /*0x20*/);
    this.panelStep6.TabIndex = 4;
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(8, 8);
    this.label5.Name = "label5";
    this.label5.Size = new Size(96 /*0x60*/, 14);
    this.label5.TabIndex = 0;
    this.label5.Text = "Displaying Dataset";
    this.panelStep5.BackColor = Color.GhostWhite;
    this.panelStep5.Controls.Add((Control) this.label4);
    this.panelStep5.Dock = DockStyle.Top;
    this.panelStep5.Location = new Point(0, 128 /*0x80*/);
    this.panelStep5.Name = "panelStep5";
    this.panelStep5.Size = new Size(184, 32 /*0x20*/);
    this.panelStep5.TabIndex = 3;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(8, 8);
    this.label4.Name = "label4";
    this.label4.Size = new Size(114, 14);
    this.label4.TabIndex = 0;
    this.label4.Text = "Creating Detail Display";
    this.panelStep4.BackColor = Color.GhostWhite;
    this.panelStep4.Controls.Add((Control) this.label3);
    this.panelStep4.Dock = DockStyle.Top;
    this.panelStep4.Location = new Point(0, 96 /*0x60*/);
    this.panelStep4.Name = "panelStep4";
    this.panelStep4.Size = new Size(184, 32 /*0x20*/);
    this.panelStep4.TabIndex = 2;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(8, 8);
    this.label3.Name = "label3";
    this.label3.Size = new Size(142, 14);
    this.label3.TabIndex = 0;
    this.label3.Text = "Collecting Payee Information";
    this.panelStep3.BackColor = Color.GhostWhite;
    this.panelStep3.Controls.Add((Control) this.label2);
    this.panelStep3.Dock = DockStyle.Top;
    this.panelStep3.Location = new Point(0, 64 /*0x40*/);
    this.panelStep3.Name = "panelStep3";
    this.panelStep3.Size = new Size(184, 32 /*0x20*/);
    this.panelStep3.TabIndex = 1;
    this.label2.AutoSize = true;
    this.label2.Location = new Point(8, 8);
    this.label2.Name = "label2";
    this.label2.Size = new Size(120, 14);
    this.label2.TabIndex = 0;
    this.label2.Text = "Calculating Amount Due";
    this.panelStep2.BackColor = Color.GhostWhite;
    this.panelStep2.Controls.Add((Control) this.label1);
    this.panelStep2.Dock = DockStyle.Top;
    this.panelStep2.Location = new Point(0, 32 /*0x20*/);
    this.panelStep2.Name = "panelStep2";
    this.panelStep2.Size = new Size(184, 32 /*0x20*/);
    this.panelStep2.TabIndex = 0;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(8, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(142, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Collecting Direct Bill Invoices";
    this.panelStep1.BackColor = Color.LightSteelBlue;
    this.panelStep1.Controls.Add((Control) this.label9);
    this.panelStep1.Dock = DockStyle.Top;
    this.panelStep1.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.panelStep1.Location = new Point(0, 0);
    this.panelStep1.Name = "panelStep1";
    this.panelStep1.Size = new Size(184, 32 /*0x20*/);
    this.panelStep1.TabIndex = 6;
    this.label9.AutoSize = true;
    this.label9.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label9.Location = new Point(8, 8);
    this.label9.Name = "label9";
    this.label9.Size = new Size(139, 14);
    this.label9.TabIndex = 0;
    this.label9.Text = "Date and Office Location";
    this.panelMainDisplay.Dock = DockStyle.Fill;
    this.panelMainDisplay.Location = new Point(0, 0);
    this.panelMainDisplay.Name = "panelMainDisplay";
    this.panelMainDisplay.Size = new Size(994, 675);
    this.panelMainDisplay.TabIndex = 1;
    this.panel8.Controls.Add((Control) this.linkLabel2);
    this.panel8.Controls.Add((Control) this.linkLabel1);
    this.panel8.Controls.Add((Control) this.buttonContinue);
    this.panel8.Controls.Add((Control) this.buttonPostSelectedResults);
    this.panel8.Controls.Add((Control) this.buttonCancel);
    this.panel8.Dock = DockStyle.Bottom;
    this.panel8.Location = new Point(184, 635);
    this.panel8.Name = "panel8";
    this.panel8.Size = new Size(810, 40);
    this.panel8.TabIndex = 2;
    this.linkLabel2.AutoSize = true;
    this.linkLabel2.Location = new Point(85, 17);
    this.linkLabel2.Name = "linkLabel2";
    this.linkLabel2.Size = new Size(68, 14);
    this.linkLabel2.TabIndex = 12;
    this.linkLabel2.TabStop = true;
    this.linkLabel2.Text = "De-Select All";
    this.linkLabel2.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
    this.linkLabel1.AutoSize = true;
    this.linkLabel1.Location = new Point(16 /*0x10*/, 17);
    this.linkLabel1.Name = "linkLabel1";
    this.linkLabel1.Size = new Size(51, 14);
    this.linkLabel1.TabIndex = 11;
    this.linkLabel1.TabStop = true;
    this.linkLabel1.Text = "Select All";
    this.linkLabel1.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
    ((Control) this.buttonContinue).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonContinue).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonContinue).Location = new Point(371, 8);
    ((Control) this.buttonContinue).Name = "buttonContinue";
    ((Control) this.buttonContinue).Size = new Size(143, 24);
    ((Control) this.buttonContinue).TabIndex = 10;
    ((Control) this.buttonContinue).Text = "Continue";
    ((UltraControlBase) this.buttonContinue).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonContinue).Click += new EventHandler(this.buttonContinue_Click);
    ((Control) this.buttonPostSelectedResults).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonPostSelectedResults).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonPostSelectedResults).Enabled = false;
    ((Control) this.buttonPostSelectedResults).Location = new Point(520, 8);
    ((Control) this.buttonPostSelectedResults).Name = "buttonPostSelectedResults";
    ((Control) this.buttonPostSelectedResults).Size = new Size(136, 24);
    ((Control) this.buttonPostSelectedResults).TabIndex = 1;
    ((Control) this.buttonPostSelectedResults).Text = "Post Selected Results";
    ((UltraControlBase) this.buttonPostSelectedResults).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonPostSelectedResults).Click += new EventHandler(this.buttonPostSelectedResults_Click);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonCancel).Location = new Point(664, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(136, 24);
    ((Control) this.buttonCancel).TabIndex = 0;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.ultraCalcManager1.ContainingControl = (ContainerControl) this;
    this.dsDirectBillPayables1.DataSetName = "dsDirectBillPayables";
    this.dsDirectBillPayables1.Locale = new CultureInfo("en-US");
    this.dsDirectBillPayables1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panelDateOfficeLocation.Controls.Add((Control) this.checkLimitCompanyGroups);
    this.panelDateOfficeLocation.Controls.Add((Control) this.comboCompanyGroups);
    this.panelDateOfficeLocation.Controls.Add((Control) this.checkLimitCompanies);
    this.panelDateOfficeLocation.Controls.Add((Control) this.comboCompanies);
    this.panelDateOfficeLocation.Controls.Add((Control) this.dateTimeCheckDate);
    this.panelDateOfficeLocation.Controls.Add((Control) this.label13);
    this.panelDateOfficeLocation.Controls.Add((Control) this.comboBankAccounts);
    this.panelDateOfficeLocation.Controls.Add((Control) this.label12);
    this.panelDateOfficeLocation.Controls.Add((Control) this.checkShowOthers);
    this.panelDateOfficeLocation.Controls.Add((Control) this.checkShowCompanies);
    this.panelDateOfficeLocation.Controls.Add((Control) this.checkShowProducers);
    this.panelDateOfficeLocation.Controls.Add((Control) this.dateTimeCutOff);
    this.panelDateOfficeLocation.Controls.Add((Control) this.label11);
    this.panelDateOfficeLocation.Controls.Add((Control) this.comboOfficeLocation);
    this.panelDateOfficeLocation.Controls.Add((Control) this.labelOfficeLocation);
    this.panelDateOfficeLocation.Controls.Add((Control) this.label10);
    this.panelDateOfficeLocation.Dock = DockStyle.Fill;
    this.panelDateOfficeLocation.Location = new Point(184, 64 /*0x40*/);
    this.panelDateOfficeLocation.Name = "panelDateOfficeLocation";
    this.panelDateOfficeLocation.Size = new Size(810, 611);
    this.panelDateOfficeLocation.TabIndex = 0;
    ((AppearanceBase) appearance6).BorderColor = Color.Gray;
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkLimitCompanyGroups).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.checkLimitCompanyGroups).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkLimitCompanyGroups).Location = new Point(221, 454);
    ((Control) this.checkLimitCompanyGroups).Name = "checkLimitCompanyGroups";
    ((Control) this.checkLimitCompanyGroups).Size = new Size(434, 20);
    ((Control) this.checkLimitCompanyGroups).TabIndex = 16 /*0x10*/;
    ((Control) this.checkLimitCompanyGroups).Text = "Limit to Business with the Following Company Groups";
    this.comboCompanyGroups.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboCompanyGroups).CalcManager = (IUltraCalcManager) this.ultraCalcManager1;
    this.comboCompanyGroups.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCompanyGroups).Location = new Point(222, 479);
    this.comboCompanyGroups.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCompanyGroups).Name = "comboCompanyGroups";
    ((Control) this.comboCompanyGroups).Size = new Size(368, 20);
    ((Control) this.comboCompanyGroups).TabIndex = 15;
    ((UltraControlBase) this.comboCompanyGroups).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCompanyGroups).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.Gray;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkLimitCompanies).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.checkLimitCompanies).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkLimitCompanies).Location = new Point(222, 403);
    ((Control) this.checkLimitCompanies).Name = "checkLimitCompanies";
    ((Control) this.checkLimitCompanies).Size = new Size(264, 20);
    ((Control) this.checkLimitCompanies).TabIndex = 14;
    ((Control) this.checkLimitCompanies).Text = "Limit to Business with the Following Company";
    this.comboCompanies.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboCompanies).CalcManager = (IUltraCalcManager) this.ultraCalcManager1;
    this.comboCompanies.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCompanies).Location = new Point(222, 426);
    this.comboCompanies.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCompanies).Name = "comboCompanies";
    ((Control) this.comboCompanies).Size = new Size(368, 20);
    ((Control) this.comboCompanies).TabIndex = 13;
    ((UltraControlBase) this.comboCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCompanies).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BackColor = Color.LightYellow;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeCheckDate.Appearance = (AppearanceBase) appearance8;
    ((Control) this.dateTimeCheckDate).BackColor = Color.LightYellow;
    ((AppearanceBase) appearance9).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance9).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance9).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance9).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance9).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance9).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance9).ForegroundAlpha = (Alpha) 2;
    this.dateTimeCheckDate.ButtonAppearance = (AppearanceBase) appearance9;
    this.dateTimeCheckDate.FormatString = "D";
    ((Control) this.dateTimeCheckDate).Location = new Point(222, 263);
    this.dateTimeCheckDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeCheckDate).Name = "dateTimeCheckDate";
    ((Control) this.dateTimeCheckDate).Size = new Size(264, 19);
    ((Control) this.dateTimeCheckDate).TabIndex = 11;
    ((UltraControlBase) this.dateTimeCheckDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeCheckDate).UseOsThemes = (DefaultableBoolean) 2;
    this.label13.AutoSize = true;
    this.label13.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label13.Location = new Point(222, 247);
    this.label13.Name = "label13";
    this.label13.Size = new Size(72, 14);
    this.label13.TabIndex = 10;
    this.label13.Text = "Check Date:";
    this.comboBankAccounts.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboBankAccounts).CalcManager = (IUltraCalcManager) this.ultraCalcManager1;
    ((UltraGridBase) this.comboBankAccounts).DataSource = (object) this.dsBankAccounts1;
    ((UltraDropDownBase) this.comboBankAccounts).DisplayMember = "BANKNAME";
    this.comboBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboBankAccounts).Location = new Point(222, 207);
    this.comboBankAccounts.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccounts).Name = "comboBankAccounts";
    ((Control) this.comboBankAccounts).Size = new Size(368, 20);
    ((Control) this.comboBankAccounts).TabIndex = 3;
    ((UltraControlBase) this.comboBankAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboBankAccounts).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboBankAccounts).ValueMember = "GLACCTID";
    this.dsBankAccounts1.DataSetName = "dsBankAccounts";
    this.dsBankAccounts1.Locale = new CultureInfo("en-US");
    this.label12.AutoSize = true;
    this.label12.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label12.Location = new Point(222, 191);
    this.label12.Name = "label12";
    this.label12.Size = new Size(82, 14);
    this.label12.TabIndex = 2;
    this.label12.Text = "Bank Account";
    this.checkShowOthers.FlatStyle = FlatStyle.Flat;
    this.checkShowOthers.Location = new Point(518, 359);
    this.checkShowOthers.Name = "checkShowOthers";
    this.checkShowOthers.Size = new Size(88, 24);
    this.checkShowOthers.TabIndex = 8;
    this.checkShowOthers.Text = "Show Others ";
    this.checkShowCompanies.FlatStyle = FlatStyle.Flat;
    this.checkShowCompanies.Location = new Point(366, 359);
    this.checkShowCompanies.Name = "checkShowCompanies";
    this.checkShowCompanies.Size = new Size(112 /*0x70*/, 24);
    this.checkShowCompanies.TabIndex = 7;
    this.checkShowCompanies.Text = "Show Companies";
    this.checkShowProducers.Checked = true;
    this.checkShowProducers.CheckState = CheckState.Checked;
    this.checkShowProducers.FlatStyle = FlatStyle.Flat;
    this.checkShowProducers.Location = new Point(222, 359);
    this.checkShowProducers.Name = "checkShowProducers";
    this.checkShowProducers.Size = new Size(104, 24);
    this.checkShowProducers.TabIndex = 6;
    this.checkShowProducers.Text = "Show Producers";
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeCutOff.Appearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance11).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance11).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance11).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance11).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance11).ForegroundAlpha = (Alpha) 2;
    this.dateTimeCutOff.ButtonAppearance = (AppearanceBase) appearance11;
    this.dateTimeCutOff.FormatString = "D";
    ((Control) this.dateTimeCutOff).Location = new Point(222, 319);
    this.dateTimeCutOff.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeCutOff).Name = "dateTimeCutOff";
    ((Control) this.dateTimeCutOff).Size = new Size(264, 19);
    ((Control) this.dateTimeCutOff).TabIndex = 5;
    ((UltraControlBase) this.dateTimeCutOff).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeCutOff).UseOsThemes = (DefaultableBoolean) 2;
    this.label11.AutoSize = true;
    this.label11.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label11.Location = new Point(222, 303);
    this.label11.Name = "label11";
    this.label11.Size = new Size(73, 14);
    this.label11.TabIndex = 4;
    this.label11.Text = "Cut-Off Date";
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboOfficeLocation).CalcManager = (IUltraCalcManager) this.ultraCalcManager1;
    ((UltraGridBase) this.comboOfficeLocation).DataMember = "spFin_GetOfficeLocations";
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(224 /*0xE0*/, 152);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(368, 20);
    ((Control) this.comboOfficeLocation).TabIndex = 1;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.comboOfficeLocation.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    this.labelOfficeLocation.AutoSize = true;
    this.labelOfficeLocation.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelOfficeLocation.Location = new Point(224 /*0xE0*/, 136);
    this.labelOfficeLocation.Name = "labelOfficeLocation";
    this.labelOfficeLocation.Size = new Size(89, 14);
    this.labelOfficeLocation.TabIndex = 0;
    this.labelOfficeLocation.Text = "Office Location";
    this.label10.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label10.Location = new Point(16 /*0x10*/, 24);
    this.label10.Name = "label10";
    this.label10.Size = new Size(776, 48 /*0x30*/);
    this.label10.TabIndex = 0;
    this.label10.Text = "To begin the direct bill payables automation utility, you must specify an office location and a cut-off date.";
    this.label10.TextAlign = ContentAlignment.TopCenter;
    this.panelCreatingChecks.Controls.Add((Control) this.gridCheckBuilding);
    this.panelCreatingChecks.Controls.Add((Control) this.label14);
    this.panelCreatingChecks.Dock = DockStyle.Fill;
    this.panelCreatingChecks.Location = new Point(184, 64 /*0x40*/);
    this.panelCreatingChecks.Name = "panelCreatingChecks";
    this.panelCreatingChecks.Size = new Size(810, 611);
    this.panelCreatingChecks.TabIndex = 8;
    this.panelCreatingChecks.Visible = false;
    ((UltraGridBase) this.gridCheckBuilding).CalcManager = (IUltraCalcManager) this.ultraCalcManager1;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.CellMultiLine = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.RowSizing = (RowSizing) 5;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Scrollbars = (Scrollbars) 2;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((Control) this.gridCheckBuilding).Dock = DockStyle.Fill;
    ((Control) this.gridCheckBuilding).Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridCheckBuilding).Location = new Point(0, 32 /*0x20*/);
    ((Control) this.gridCheckBuilding).Name = "gridCheckBuilding";
    ((Control) this.gridCheckBuilding).Size = new Size(810, 579);
    ((Control) this.gridCheckBuilding).TabIndex = 1;
    ((UltraControlBase) this.gridCheckBuilding).UseOsThemes = (DefaultableBoolean) 2;
    this.gridCheckBuilding.InitializeLayout += new InitializeLayoutEventHandler(this.gridCheckBuilding_InitializeLayout);
    this.gridCheckBuilding.InitializeRow += new InitializeRowEventHandler(this.gridCheckBuilding_InitializeRow);
    this.label14.Dock = DockStyle.Top;
    this.label14.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label14.Location = new Point(0, 0);
    this.label14.Name = "label14";
    this.label14.Size = new Size(810, 32 /*0x20*/);
    this.label14.TabIndex = 0;
    this.label14.Text = "Creating checks. This may be a lengthy process, please be patient.";
    this.label14.TextAlign = ContentAlignment.MiddleCenter;
    this.panelCollectingDirectBillInvoices.Controls.Add((Control) this.pictureBox2);
    this.panelCollectingDirectBillInvoices.Controls.Add((Control) this.labelPhaseInformation);
    this.panelCollectingDirectBillInvoices.Controls.Add((Control) this.labelPhaseTitle);
    this.panelCollectingDirectBillInvoices.Dock = DockStyle.Fill;
    this.panelCollectingDirectBillInvoices.Location = new Point(184, 64 /*0x40*/);
    this.panelCollectingDirectBillInvoices.Name = "panelCollectingDirectBillInvoices";
    this.panelCollectingDirectBillInvoices.Size = new Size(810, 611);
    this.panelCollectingDirectBillInvoices.TabIndex = 6;
    this.panelCollectingDirectBillInvoices.Visible = false;
    this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
    this.pictureBox2.Location = new Point(336, 248);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(175, 175);
    this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox2.TabIndex = 2;
    this.pictureBox2.TabStop = false;
    this.labelPhaseInformation.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelPhaseInformation.Location = new Point(16 /*0x10*/, 64 /*0x40*/);
    this.labelPhaseInformation.Name = "labelPhaseInformation";
    this.labelPhaseInformation.Size = new Size(776, 56);
    this.labelPhaseInformation.TabIndex = 1;
    this.labelPhaseInformation.Text = "During this phase, the system is collecting all the direct bill invoices that have a balance in the system and match your specified date and office location selection criteria.";
    this.labelPhaseTitle.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelPhaseTitle.Location = new Point(16 /*0x10*/, 24);
    this.labelPhaseTitle.Name = "labelPhaseTitle";
    this.labelPhaseTitle.Size = new Size(520, 24);
    this.labelPhaseTitle.TabIndex = 0;
    this.labelPhaseTitle.Text = "Collecting Direct Bill Invoices";
    this.panelResults.Controls.Add((Control) this.gridDirectBillResults);
    this.panelResults.Dock = DockStyle.Fill;
    this.panelResults.Location = new Point(184, 64 /*0x40*/);
    this.panelResults.Name = "panelResults";
    this.panelResults.Size = new Size(810, 611);
    this.panelResults.TabIndex = 7;
    this.panelResults.Visible = false;
    ((UltraGridBase) this.gridDirectBillResults).CalcManager = (IUltraCalcManager) this.ultraCalcManager1;
    ((UltraGridBase) this.gridDirectBillResults).DataSource = (object) this.dsDirectBillPayables1;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Payee";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 2;
    ultraGridColumn2.Width = 393;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn3.Format = "c";
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Gross Payable";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.Width = 149;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance17;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Proportional Amt.";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 4;
    ultraGridColumn4.Width = 142;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Width = 76;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.DataType = typeof (bool);
    ultraGridColumn7.DefaultCellValue = (object) true;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 1;
    ultraGridColumn7.Style = (ColumnStyle) 4;
    ultraGridColumn7.Width = 29;
    ultraGridBand1.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ultraGridBand1.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand1.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand1.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand1.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand1.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridBand1.SummaryFooterCaption = "Checks Total:";
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 1;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 81;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 2;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 65;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance19;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Invoice Number";
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 3;
    ultraGridColumn10.Width = 104;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance20;
    ultraGridColumn11.Format = "c";
    ((AppearanceBase) appearance21).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance21;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 5;
    ultraGridColumn11.Width = 158;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance22;
    ultraGridColumn12.Format = "c";
    ((AppearanceBase) appearance23).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance23;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 6;
    ultraGridColumn12.Width = 160 /*0xA0*/;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Insured Name";
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 4;
    ultraGridColumn13.Width = 303;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 7;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 94;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 8;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 69;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 9;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 87;
    ultraGridColumn17.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn17.Header).Caption = "";
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 0;
    ultraGridColumn17.Style = (ColumnStyle) 3;
    ultraGridColumn17.Width = 45;
    ultraGridBand2.Columns.AddRange(new object[10]
    {
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
    ultraGridBand2.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance26).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance29;
    ((AppearanceBase) appearance30).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance31).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance31;
    ((Control) this.gridDirectBillResults).Dock = DockStyle.Fill;
    ((Control) this.gridDirectBillResults).Location = new Point(0, 0);
    ((Control) this.gridDirectBillResults).Name = "gridDirectBillResults";
    ((Control) this.gridDirectBillResults).Size = new Size(810, 611);
    ((Control) this.gridDirectBillResults).TabIndex = 1;
    this.gridDirectBillResults.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridDirectBillResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridDirectBillResults).UseOsThemes = (DefaultableBoolean) 2;
    this.gridDirectBillResults.AfterCellUpdate += new CellEventHandler(this.gridDirectBillResults_AfterCellUpdate);
    this.gridDirectBillResults.InitializeRow += new InitializeRowEventHandler(this.gridDirectBillResults_InitializeRow);
    this.gridDirectBillResults.CellChange += new CellEventHandler(this.gridDirectBillResults_CellChange);
    ((Control) this.gridDirectBillResults).Click += new EventHandler(this.gridDirectBillResults_Click);
    this.panel1.BackgroundImage = (Image) componentResourceManager.GetObject("panel1.BackgroundImage");
    this.panel1.Controls.Add((Control) this.pictureBox1);
    this.panel1.Controls.Add((Control) this.label8);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(994, 64 /*0x40*/);
    this.panel1.TabIndex = 0;
    this.pictureBox1.BackColor = Color.Transparent;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(936, 8);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox1.TabIndex = 2;
    this.pictureBox1.TabStop = false;
    this.label8.BackColor = Color.Transparent;
    this.label8.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label8.ForeColor = Color.White;
    this.label8.Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    this.label8.Name = "label8";
    this.label8.Size = new Size(888, 40);
    this.label8.TabIndex = 1;
    this.label8.Text = componentResourceManager.GetString("label8.Text");
    this.daGetOfficeLocation.SelectCommand = this.sqlSelectCommand1;
    this.daGetOfficeLocation.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_GetOfficeLocations]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.daGetBankAccounts.SelectCommand = this.sqlSelectCommand2;
    this.daGetBankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccounts", new DataColumnMapping[3]
      {
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("BANKNAME", "BANKNAME"),
        new DataColumnMapping("CLOSED", "CLOSED")
      })
    });
    this.sqlSelectCommand2.CommandText = "[spFin_GetBankAccounts]";
    this.sqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand2.Connection = this.FormDataConnection;
    this.sqlSelectCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4)
    });
    this.requiredFieldValidator1.ControlToValidate = (Control) this.comboOfficeLocation;
    this.requiredFieldValidator1.Enabled = true;
    this.requiredFieldValidator1.ErrorMessage = "You must select an office location to continue.";
    this.requiredFieldValidator1.FieldToValidate = "Value";
    this.requiredFieldValidator1.InvalidBackcolor = Color.White;
    this.requiredFieldValidator2.ControlToValidate = (Control) this.dateTimeCheckDate;
    this.requiredFieldValidator2.Enabled = true;
    this.requiredFieldValidator2.ErrorMessage = "You must enter a check date to continue.";
    this.requiredFieldValidator2.FieldToValidate = "DateTime";
    this.requiredFieldValidator3.ControlToValidate = (Control) this.comboBankAccounts;
    this.requiredFieldValidator3.Enabled = true;
    this.requiredFieldValidator3.ErrorMessage = "You must select a bank account to continue.";
    this.requiredFieldValidator3.FieldToValidate = "Value";
    this.statusCreditStatements.AllowMerge = false;
    this.statusCreditStatements.BackColor = Color.Transparent;
    this.statusCreditStatements.Items.AddRange(new ToolStripItem[3]
    {
      (ToolStripItem) this.toolStripStatusLabel2,
      (ToolStripItem) this.labelProcessCreditStatements,
      (ToolStripItem) this.progressCreditStatements
    });
    this.statusCreditStatements.Location = new Point(0, 653);
    this.statusCreditStatements.Name = "statusCreditStatements";
    this.statusCreditStatements.Size = new Size(994, 22);
    this.statusCreditStatements.SizingGrip = false;
    this.statusCreditStatements.TabIndex = 9;
    this.statusCreditStatements.Visible = false;
    this.toolStripStatusLabel2.DisplayStyle = ToolStripItemDisplayStyle.None;
    this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
    this.toolStripStatusLabel2.Size = new Size(610, 17);
    this.toolStripStatusLabel2.Spring = true;
    this.toolStripStatusLabel2.Text = " ";
    this.labelProcessCreditStatements.Name = "labelProcessCreditStatements";
    this.labelProcessCreditStatements.Size = new Size(167, 17);
    this.labelProcessCreditStatements.Text = "Processing Credit Statements: ";
    this.progressCreditStatements.BackColor = Color.White;
    this.progressCreditStatements.ForeColor = Color.SteelBlue;
    this.progressCreditStatements.Maximum = 200;
    this.progressCreditStatements.Name = "progressCreditStatements";
    this.progressCreditStatements.Size = new Size(200, 16 /*0x10*/);
    this.progressCreditStatements.Step = 1;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(994, 675);
    this.Controls.Add((Control) this.panel8);
    this.Controls.Add((Control) this.panelDateOfficeLocation);
    this.Controls.Add((Control) this.panelResults);
    this.Controls.Add((Control) this.panelCollectingDirectBillInvoices);
    this.Controls.Add((Control) this.panelCreatingChecks);
    this.Controls.Add((Control) this.panelLeftSide);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.panelMainDisplay);
    this.Controls.Add((Control) this.statusCreditStatements);
    this.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.Name = nameof (formDirectBillPayables);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Direct Bill Payables Utility";
    this.FormClosing += new FormClosingEventHandler(this.formDirectBillPayables_FormClosing);
    this.Load += new EventHandler(this.formDirectBillPayables_Load);
    this.panelLeftSide.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    ((ISupportInitialize) this.pictCalculate).EndInit();
    ((ISupportInitialize) this.textCheckTotal).EndInit();
    ((ISupportInitialize) this.buttonExportData).EndInit();
    this.panel7.ResumeLayout(false);
    this.panel7.PerformLayout();
    this.panelStep7.ResumeLayout(false);
    this.panelStep7.PerformLayout();
    this.panelStep6.ResumeLayout(false);
    this.panelStep6.PerformLayout();
    this.panelStep5.ResumeLayout(false);
    this.panelStep5.PerformLayout();
    this.panelStep4.ResumeLayout(false);
    this.panelStep4.PerformLayout();
    this.panelStep3.ResumeLayout(false);
    this.panelStep3.PerformLayout();
    this.panelStep2.ResumeLayout(false);
    this.panelStep2.PerformLayout();
    this.panelStep1.ResumeLayout(false);
    this.panelStep1.PerformLayout();
    this.panel8.ResumeLayout(false);
    this.panel8.PerformLayout();
    ((ISupportInitialize) this.buttonContinue).EndInit();
    ((ISupportInitialize) this.buttonPostSelectedResults).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.ultraCalcManager1).EndInit();
    this.dsDirectBillPayables1.EndInit();
    this.panelDateOfficeLocation.ResumeLayout(false);
    this.panelDateOfficeLocation.PerformLayout();
    ((ISupportInitialize) this.checkLimitCompanyGroups).EndInit();
    ((ISupportInitialize) this.comboCompanyGroups).EndInit();
    ((ISupportInitialize) this.checkLimitCompanies).EndInit();
    ((ISupportInitialize) this.comboCompanies).EndInit();
    ((ISupportInitialize) this.dateTimeCheckDate).EndInit();
    ((ISupportInitialize) this.comboBankAccounts).EndInit();
    this.dsBankAccounts1.EndInit();
    ((ISupportInitialize) this.dateTimeCutOff).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.panelCreatingChecks.ResumeLayout(false);
    ((ISupportInitialize) this.gridCheckBuilding).EndInit();
    this.panelCollectingDirectBillInvoices.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox2).EndInit();
    this.panelResults.ResumeLayout(false);
    ((ISupportInitialize) this.gridDirectBillResults).EndInit();
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    ((ISupportInitialize) this.requiredFieldValidator1).EndInit();
    ((ISupportInitialize) this.requiredFieldValidator2).EndInit();
    ((ISupportInitialize) this.requiredFieldValidator3).EndInit();
    this.statusCreditStatements.ResumeLayout(false);
    this.statusCreditStatements.PerformLayout();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected DirectBillUtility DBUtilityObject => this.directBillUtility;

  private void UIInvokeMethod(int Stage)
  {
    switch (Stage)
    {
      case 0:
        this.panelCollectingDirectBillInvoices.Visible = true;
        this.panelCollectingDirectBillInvoices.BringToFront();
        this.panelStep1.BackColor = Color.GhostWhite;
        this.panelStep1.Font = this.NonCurrentTabFont;
        this.panelStep2.BackColor = Color.LightSteelBlue;
        this.panelStep2.Font = this.CurrentTabFont;
        this.phaseThread = new Thread(new ThreadStart(this.LoadDirectBillInvoices));
        this.phaseThread.Start();
        break;
      case 1:
        this.panelCollectingDirectBillInvoices.Visible = true;
        this.panelCollectingDirectBillInvoices.BringToFront();
        this.panelStep2.BackColor = Color.GhostWhite;
        this.panelStep2.Font = this.NonCurrentTabFont;
        this.panelStep3.BackColor = Color.LightSteelBlue;
        this.panelStep3.Font = this.CurrentTabFont;
        this.labelPhaseTitle.Text = MGASystems.IMS.Accounting.Core.ClassObjects.StringResourceManager.GetString("CALCULATING_AMTDUE");
        this.labelPhaseInformation.Text = MGASystems.IMS.Accounting.Core.ClassObjects.StringResourceManager.GetString("CALCULATING_AMTDUE_VERBAGE");
        this.phaseThread = new Thread(new ThreadStart(this.CalculateProportionalAmount));
        this.phaseThread.Start();
        break;
      case 2:
        this.panelCollectingDirectBillInvoices.Visible = true;
        this.panelCollectingDirectBillInvoices.BringToFront();
        this.panelStep3.BackColor = Color.GhostWhite;
        this.panelStep3.Font = this.NonCurrentTabFont;
        this.panelStep4.BackColor = Color.LightSteelBlue;
        this.panelStep4.Font = this.CurrentTabFont;
        this.labelPhaseTitle.Text = MGASystems.IMS.Accounting.Core.ClassObjects.StringResourceManager.GetString("LOADING_DIRECTBILL_PAYEES");
        this.labelPhaseInformation.Text = MGASystems.IMS.Accounting.Core.ClassObjects.StringResourceManager.GetString("LOADING_DIRECTBILL_PAYEES_VERBAGE");
        this.phaseThread = new Thread(new ThreadStart(this.LoadDirectBillPayees));
        this.phaseThread.Start();
        break;
      case 3:
        this.panelCollectingDirectBillInvoices.Visible = true;
        this.panelCollectingDirectBillInvoices.BringToFront();
        this.panelStep4.BackColor = Color.GhostWhite;
        this.panelStep4.Font = this.NonCurrentTabFont;
        this.panelStep5.BackColor = Color.LightSteelBlue;
        this.panelStep5.Font = this.CurrentTabFont;
        this.labelPhaseTitle.Text = MGASystems.IMS.Accounting.Core.ClassObjects.StringResourceManager.GetString("CREATING_DIRECTBILL_DISPLAYSET");
        this.labelPhaseInformation.Text = MGASystems.IMS.Accounting.Core.ClassObjects.StringResourceManager.GetString("CREATING_DIRECTBILL_DISPLAYSET_VERBAGE");
        this.phaseThread = new Thread(new ThreadStart(this.CreateDisplay));
        this.phaseThread.Start();
        break;
      case 4:
        this.panelCollectingDirectBillInvoices.Visible = true;
        this.panelCollectingDirectBillInvoices.BringToFront();
        this.panelStep5.BackColor = Color.GhostWhite;
        this.panelStep5.Font = this.NonCurrentTabFont;
        this.panelStep6.BackColor = Color.LightSteelBlue;
        this.panelStep6.Font = this.CurrentTabFont;
        this.LoadDisplay();
        this.panelCollectingDirectBillInvoices.SendToBack();
        this.panelCollectingDirectBillInvoices.Visible = false;
        this.panelResults.BringToFront();
        this.panelResults.Visible = true;
        this.panelStep6.BackColor = Color.GhostWhite;
        this.panelStep6.Font = this.NonCurrentTabFont;
        this.panelStep7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
        this.panelStep7.Font = this.CurrentTabFont;
        ((Control) this.buttonPostSelectedResults).Enabled = true;
        ((Control) this.buttonContinue).Enabled = false;
        this.DoInitializeRow = false;
        this.SetGridSelected();
        this.PrintCreditBalances();
        this.OnLoadDataCompleted();
        break;
    }
  }

  private void ThreadExceptions(Exception ex)
  {
    if (!(ex is DirectBillInvoicesNotFoundException))
      return;
    int num = (int) MessageBox.Show(ex.Message, "No Direct Bill Invoices Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.ResetStepPanels();
    this.panelDateOfficeLocation.Visible = true;
    this.panelDateOfficeLocation.BringToFront();
  }

  public event EventHandler LoadDataCompleted;

  protected void OnLoadDataCompleted()
  {
    EventHandler loadDataCompleted = this.LoadDataCompleted;
    if (loadDataCompleted == null)
      return;
    loadDataCompleted((object) this, new EventArgs());
  }

  private void LoadDirectBillInvoices()
  {
    if (this.directBillUtility == null)
      return;
    try
    {
      this.directBillUtility.LoadDirectBillInvoices();
    }
    catch (DirectBillInvoicesNotFoundException ex)
    {
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new formDirectBillPayables.ThreadExceptionsHandler(this.ThreadExceptions), (object) ex);
      return;
    }
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new formDirectBillPayables.UIInvokeMethodHandler(this.UIInvokeMethod), (object) 1);
  }

  private void CalculateProportionalAmount()
  {
    if (this.directBillUtility == null)
      return;
    this.directBillUtility.CalculateAmountDue();
    if (this.IsDisposed)
      return;
    this.Invoke((Delegate) new formDirectBillPayables.UIInvokeMethodHandler(this.UIInvokeMethod), (object) 2);
  }

  private void LoadDirectBillPayees()
  {
    if (this.directBillUtility == null)
      return;
    this.directBillUtility.CreatePayeeCollection();
    if (this.IsDisposed)
      return;
    this.Invoke((Delegate) new formDirectBillPayables.UIInvokeMethodHandler(this.UIInvokeMethod), (object) 3);
  }

  private void CreateDisplay()
  {
    if (this.directBillUtility == null)
      return;
    this.ds = this.directBillUtility.CreateDisplaySet();
    if (this.IsDisposed)
      return;
    this.Invoke((Delegate) new formDirectBillPayables.UIInvokeMethodHandler(this.UIInvokeMethod), (object) 4);
  }

  private void LoadDisplay()
  {
    if (this.ds == null)
      return;
    ((UltraGridBase) this.gridDirectBillResults).DataSource = (object) this.ds;
  }

  protected virtual void PrintCreditBalances() => this.PrintCreditBalances("TotalGrossPayable");

  protected void PrintCreditBalances(string columnName)
  {
    string text = "Would you like to print statements for the credit balances?";
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Bands[0].ColumnFilters[columnName].FilterConditions.Add((FilterComparisionOperator) 2, (object) 0);
    UltraGridRow[] rows = ((UltraGridBase) this.gridDirectBillResults).Rows.GetFilteredInNonGroupByRows();
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    if (rows.Length == 0 || MessageBox.Show(text, "Print Statements?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
      return;
    SectionReport parent = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptReturnPremiumCommissionAutomation));
    this.progressCreditStatements.Value = 0;
    this.progressCreditStatements.Maximum = rows.Length + 1;
    this.statusCreditStatements.Visible = true;
    using (BackgroundWorker bgw = new BackgroundWorker())
    {
      bgw.WorkerReportsProgress = true;
      bgw.ProgressChanged += new ProgressChangedEventHandler(this.Bgw_ProgressChanged);
      bgw.WorkerSupportsCancellation = true;
      Guid payeeGuid;
      SectionReport child;
      bgw.DoWork += (DoWorkEventHandler) ((_param1, _param2) =>
      {
        if (this._formClosing)
        {
          bgw.CancelAsync();
        }
        else
        {
          parent.Run();
          foreach (UltraGridRow ultraGridRow in rows)
          {
            if (this._formClosing)
            {
              bgw.CancelAsync();
              return;
            }
            this._nextPayeeName = ultraGridRow.Cells["PayeeName"].Value.ToString();
            bgw.ReportProgress(1);
            ultraGridRow.Activation = (Activation) 2;
            if (this._formClosing)
            {
              bgw.CancelAsync();
              return;
            }
            foreach (UltraGridRow row in ultraGridRow.ChildBands[0].Rows)
              row.Activation = (Activation) 2;
            if (this._formClosing)
            {
              bgw.CancelAsync();
              return;
            }
            payeeGuid = new Guid(ultraGridRow.Cells["PayeeGuid"].Value.ToString());
            child = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptReturnPremiumCommissionAutomation), new object[3]
            {
              (object) this.directBillUtility.GlCompanyId,
              (object) payeeGuid,
              (object) this.directBillUtility.CutOffDate
            });
            child.Run();
            parent.Document.Pages.AddRange(child.Document.Pages);
          }
          parent.Document.Pages.RemoveAt(0);
        }
      });
      bgw.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((_param1, _param2) =>
      {
        if (this._formClosing)
          return;
        bgw.ProgressChanged -= new ProgressChangedEventHandler(this.Bgw_ProgressChanged);
        this.statusCreditStatements.Visible = false;
        new frmPrint(parent).Show();
      });
      bgw.RunWorkerAsync();
    }
  }

  private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
  {
    if (this._formClosing)
      return;
    this.progressCreditStatements.PerformStep();
    this.labelProcessCreditStatements.Text = $"Processing Credit Statements for {this._nextPayeeName} ";
  }

  private bool ValidateDataCollection() => this.requiredFieldValidator1.IsAllValidatorsValid;

  private bool ValidateSave() => true;

  private void buttonContinue_Click(object sender, EventArgs e)
  {
    if (!this.ValidateDataCollection())
      return;
    if (((UltraToggleEditorBase) this.checkLimitCompanies).Checked && ((UltraDropDownBase) this.comboCompanies).SelectedRow != null)
      this.directBillUtility = (DirectBillUtility) ObjectFactory.Instance.CreateObject(typeof (DirectBillUtility), new object[8]
      {
        (object) this.GlCompanyId,
        (object) this.dateTimeCutOff.DateTime,
        (object) this.checkShowProducers.Checked,
        (object) this.checkShowCompanies.Checked,
        (object) this.checkShowOthers.Checked,
        (object) int.Parse(((UltraDropDownBase) this.comboBankAccounts).SelectedRow.Cells["glacctid"].Value.ToString()),
        (object) this.dateTimeCheckDate.DateTime,
        (object) new Guid(this.comboCompanies.Value.ToString())
      });
    else
      this.directBillUtility = (DirectBillUtility) ObjectFactory.Instance.CreateObject(typeof (DirectBillUtility), new object[7]
      {
        (object) this.GlCompanyId,
        (object) this.dateTimeCutOff.DateTime,
        (object) this.checkShowProducers.Checked,
        (object) this.checkShowCompanies.Checked,
        (object) this.checkShowOthers.Checked,
        (object) int.Parse(((UltraDropDownBase) this.comboBankAccounts).SelectedRow.Cells["glacctid"].Value.ToString()),
        (object) this.dateTimeCheckDate.DateTime
      });
    this.Invoke((Delegate) new formDirectBillPayables.UIInvokeMethodHandler(this.UIInvokeMethod), (object) 0);
    this.DirectBillUtilityObjectCreated();
  }

  protected virtual void DirectBillUtilityObjectCreated()
  {
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
      return;
    this.GlCompanyId = int.Parse(((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells[0].Value.ToString());
    this.GetBankAccounts(this.GlCompanyId);
  }

  private void GetBankAccounts(int GlCompanyId)
  {
    if (this.dsBankAccounts1 != null && this.dsBankAccounts1.Tables.Count > 0)
    {
      this.dsBankAccounts1.Clear();
      this.dsBankAccounts1.AcceptChanges();
    }
    this.daGetBankAccounts.SelectCommand.Parameters["@glcompanyid"].Value = (object) GlCompanyId;
    this.daGetBankAccounts.Fill((DataSet) this.dsBankAccounts1);
    this.AfterBankAccountsLoaded();
  }

  protected virtual void AfterBankAccountsLoaded()
  {
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private void gridDirectBillResults_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridBand band = ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Bands[1];
    band.Summaries.Clear();
    band.Summaries.Add("GrossPayableSum", (SummaryType) 1, band.Columns["grosspayable"], (SummaryPosition) 3);
    band.Summaries.Add("ProportionalAmountSum", (SummaryType) 1, band.Columns["proportionalAmount"], (SummaryPosition) 3);
    foreach (SummarySettings summary in (IEnumerable) band.Summaries)
    {
      summary.DisplayFormat = "{0:c}";
      summary.Appearance.TextHAlign = (HAlign) 3;
    }
  }

  private void gridDirectBillResults_CellChange(object sender, CellEventArgs e)
  {
    if (((KeyedSubObjectBase) e.Cell.Column).Key == "SelectPayee")
    {
      try
      {
        this.Cursor = Cursors.WaitCursor;
        foreach (UltraGridRow row in e.Cell.Row.ChildBands[0].Rows)
          row.Cells["SelectInvoice"].Value = !(e.Cell.Text == string.Empty) ? (object) Convert.ToBoolean(e.Cell.Text) : (object) false;
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
    this.CalculateChecksTotal();
  }

  private void ResetStepPanels()
  {
    this.panelStep1.BackColor = Color.LightSteelBlue;
    this.panelStep2.BackColor = Color.GhostWhite;
    this.panelStep3.BackColor = Color.GhostWhite;
    this.panelStep4.BackColor = Color.GhostWhite;
    this.panelStep5.BackColor = Color.GhostWhite;
    this.panelStep6.BackColor = Color.GhostWhite;
    this.panelStep7.BackColor = Color.GhostWhite;
  }

  protected void gridDirectBillResults_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (this.DoInitializeRow)
    {
      if (((GridItemBase) e.Row).Band.Index == 0)
        e.Row.Cells["SelectPayee"].Value = (object) true;
      if (((GridItemBase) e.Row).Band.Index == 1)
        e.Row.Cells["SelectInvoice"].Value = (object) true;
    }
    this.DirectBillGridInitRowHandler(sender, e);
  }

  public event formDirectBillPayables.InitRowPassthroughHandler OnDirectBillGridInitRow;

  protected void DirectBillGridInitRowHandler(object sender, InitializeRowEventArgs e)
  {
    if (this.OnDirectBillGridInitRow == null)
      return;
    this.OnDirectBillGridInitRow(sender, e);
  }

  private void buttonPostSelectedResults_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will create checks for all records selected. This action can not be undone. If necessary, these checks can be voided manually only.", "Create Checks?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    try
    {
      this.directBillUtility.CheckCreated += new DirectBillUtility.CheckCreatedHandler(this.DirectBillCheckCreated);
      this.directBillUtility.CheckCreationComplete += new DirectBillUtility.CheckCreationCompletedHandler(this.DirectBillCheckCreationComplete);
      this.directBillUtility.CheckCreationInvalid += new DirectBillUtility.CheckCreationInvalidHandler(this.DirectBillCheckInvalid);
      if (this.dsCheckCreation == null)
        this.BuildCheckCreationDataset();
      this.dsCheckCreation.Tables[0].Rows.Add((object) "Initializing...");
      this.panelCreatingChecks.Visible = true;
      this.panelCreatingChecks.BringToFront();
      this.Refresh();
      this.Cursor = Cursors.WaitCursor;
      ((Control) this.buttonPostSelectedResults).Enabled = false;
      ((Control) this.buttonCancel).Enabled = false;
      this.ProcessDirectBill();
    }
    catch
    {
      throw;
    }
    finally
    {
      this.Cursor = Cursors.Default;
      ((Control) this.buttonCancel).Enabled = true;
      ((Control) this.buttonCancel).Text = "Close";
    }
  }

  protected virtual void ProcessDirectBill()
  {
    this.directBillUtility.CreateChecks(this.gridDirectBillResults);
  }

  private void DirectBillCheckCreated(object sender, DirectBillCheckCreatedEventArgs e)
  {
    this.Invoke((Delegate) new formDirectBillPayables.AddCheckCreationMessageHandler(this.AddCheckCreationMessage), (object) $"Check #{e.CheckNumber.ToString()} made payable to {e.PayeeName} for {e.CheckAmount.ToString("c")}");
  }

  private void DirectBillCheckCreationComplete(object sender, EventArgs e)
  {
    this.Invoke((Delegate) new formDirectBillPayables.AddCheckCreationMessageHandler(this.AddCheckCreationMessage), (object) "Process complete!");
  }

  private void DirectBillCheckInvalid(object sender, DirectBillCheckInvalidEventArgs e)
  {
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new formDirectBillPayables.AddCheckCreationMessageHandler(this.AddCheckCreationMessage), (object) e.Message);
  }

  private void DirectBillCheckCreationError(object sender, EventArgs e)
  {
    if (sender is Exception)
    {
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new formDirectBillPayables.AddCheckCreationMessageHandler(this.AddCheckCreationMessage), (object) ("Error creating checks! " + ((Exception) sender).Message));
    }
    else
    {
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new formDirectBillPayables.AddCheckCreationMessageHandler(this.AddCheckCreationMessage), (object) "Error creating checks!");
    }
  }

  private void AddCheckCreationMessage(string Message)
  {
    this.dsCheckCreation.Tables[0].Rows.Add((object) Message);
    ((Control) this.gridCheckBuilding).Refresh();
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.RowScrollRegions[0].ScrollRowIntoView(((UltraGridBase) this.gridCheckBuilding).Rows[((DisposableObjectCollectionBase) ((UltraGridBase) this.gridCheckBuilding).Rows).Count - 1]);
  }

  private void BuildCheckCreationDataset()
  {
    this.dsCheckCreation = new DataSet();
    this.dsCheckCreation.Tables.Add(new DataTable("CheckResults")
    {
      Columns = {
        new DataColumn("Column1", typeof (string))
      }
    });
    ((UltraGridBase) this.gridCheckBuilding).DataSource = (object) this.dsCheckCreation;
    ((UltraGridBase) this.gridCheckBuilding).DataMember = "CheckResults";
  }

  private void gridCheckBuilding_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Override.CellAppearance.TextHAlign = (HAlign) 2;
    ((UltraGridBase) this.gridCheckBuilding).DisplayLayout.Bands[0].ColHeadersVisible = false;
  }

  private void gridCheckBuilding_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!e.Row.Cells[0].Value.ToString().StartsWith("*"))
      return;
    ((AppearanceBase) e.Row.CellAppearance).ForeColor = Color.Red;
  }

  private void gridDirectBillResults_Click(object sender, EventArgs e)
  {
    if (!(((ControlUIElementBase) ((UltraGridBase) (sender as UltraGrid)).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridCell)) is UltraGridCell context) || !(((KeyedSubObjectBase) context.Column).Key == "SelectInvoice"))
      return;
    int num1 = 0;
    int num2 = !context.Text.Equals("False") ? num1 - 1 : num1 + 1;
    foreach (UltraGridRow row in context.Row.ParentRow.ChildBands[0].Rows)
    {
      if (row.Cells["SelectInvoice"].Text.Equals("True"))
        ++num2;
    }
    context.Row.ParentRow.Cells["SelectPayee"].Value = num2 != ((DisposableObjectCollectionBase) context.Row.ParentRow.ChildBands[0].Rows).Count ? (num2 != 0 ? (object) DBNull.Value : (object) false) : (object) true;
    ((UltraGridBase) this.gridCheckBuilding).UpdateData();
    ((UltraControlBase) this.gridCheckBuilding).Update();
  }

  private void SetGridSelected()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridDirectBillResults).Rows)
    {
      if (((KeyedSubObjectBase) ((GridItemBase) row).Band).Key.Equals("Payees"))
        row.Cells["SelectPayee"].Value = (object) false;
    }
  }

  private void gridDirectBillResults_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (((ControlUIElementBase) ((UltraGridBase) sender).DisplayLayout.UIElement).LastElementEntered == null || !(((ControlUIElementBase) ((UltraGridBase) (sender as UltraGrid)).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridCell)) is UltraGridCell context))
      return;
    if (((KeyedSubObjectBase) context.Column).Key == "SelectPayee")
    {
      if (((SubObjectBase) context).Tag != null && ((SubObjectBase) context).Tag.ToString() == "Done")
      {
        ((SubObjectBase) context).Tag = (object) null;
        return;
      }
      if (context.Value == null)
        return;
      if (context.Value == DBNull.Value)
      {
        ((SubObjectBase) context).Tag = (object) "Done";
        context.Value = (object) false;
        return;
      }
      if (context.Text == string.Empty)
        context.Value = (object) false;
    }
    this.CalculateChecksTotal();
  }

  private void LoadCompanies()
  {
    ((UltraGridBase) this.comboCompanies).DataSource = (object) DefaultDatabase.ExecuteDataTable("GetCompanyList");
    ((UltraDropDownBase) this.comboCompanies).DisplayMember = "CompanyName";
    ((UltraDropDownBase) this.comboCompanies).ValueMember = "CompanyGuid";
  }

  private void LoadCompanyGroups()
  {
    ((UltraGridBase) this.comboCompanyGroups).DataSource = (object) DefaultDatabase.ExecuteDataSet("spFin_GetCompanyGroups");
    ((UltraDropDownBase) this.comboCompanyGroups).DisplayMember = "CompanyGroupName";
    ((UltraDropDownBase) this.comboCompanyGroups).ValueMember = "CompanyGroupGuid";
  }

  private void formDirectBillPayables_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((Control) this.comboCompanies).DataBindings.Add("Enabled", (object) this.checkLimitCompanies, "Checked");
    ((Control) this.buttonExportData).DataBindings.Add("Enabled", (object) this.buttonPostSelectedResults, "Enabled");
    this.LoadCompanies();
    this.LoadCompanyGroups();
  }

  protected virtual void ExportData()
  {
    Workbook wb = new Workbook();
    wb.Worksheets.Clear();
    Worksheet ws = wb.Worksheets.Add("Direct Bill Payables Export");
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((_param1, _param2) =>
      {
        int num = 0;
        foreach (UltraGridRow row1 in ((UltraGridBase) this.gridDirectBillResults).Rows)
        {
          if (num == 0)
          {
            ws.Cells[num, 0].PutValue("Entity Name");
            ws.Cells[num, 1].PutValue("Insured");
            ws.Cells[num, 2].PutValue("Invoice Number");
            ws.Cells[num, 3].PutValue("Gross Payable");
            ws.Cells[num, 4].PutValue("Proportional Amount Due");
            ++num;
            foreach (UltraGridRow row2 in row1.ChildBands[0].Rows)
            {
              ws.Cells[num, 0].Value = (object) row1.Cells["PayeeName"].Value.ToString();
              ws.Cells[num, 1].Value = (object) row2.Cells["InsuredName"].Value.ToString();
              ws.Cells[num, 2].Value = (object) row2.Cells["OfficeInvoiceNum"].Value.ToString();
              ws.Cells[num, 3].Value = (object) row2.Cells["GrossPayable"].Value.ToString();
              ws.Cells[num, 4].Value = (object) row2.Cells["ProportionalAmount"].Value.ToString();
              ++num;
            }
          }
          else
          {
            foreach (UltraGridRow row3 in row1.ChildBands[0].Rows)
            {
              ws.Cells[num, 0].Value = (object) row1.Cells["PayeeName"].Value.ToString();
              ws.Cells[num, 1].Value = (object) row3.Cells["InsuredName"].Value.ToString();
              ws.Cells[num, 2].Value = (object) row3.Cells["OfficeInvoiceNum"].Value.ToString();
              ws.Cells[num, 3].Value = (object) row3.Cells["GrossPayable"].Value.ToString();
              ws.Cells[num, 4].Value = (object) row3.Cells["ProportionalAmount"].Value.ToString();
              ++num;
            }
          }
          ++num;
        }
      });
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((_param1, _param2) =>
      {
        string fileName = string.Empty;
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
          saveFileDialog.Title = "Save Direct Bill Data To...";
          saveFileDialog.Filter = "Excel Worksheets|*.xls";
          if (saveFileDialog.ShowDialog() == DialogResult.OK)
          {
            fileName = saveFileDialog.FileName;
            wb.Save(fileName);
          }
        }
        Process.Start(new ProcessStartInfo(fileName)
        {
          UseShellExecute = true
        });
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void buttonExportData_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.ExportData();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void CalculateChecksTotal()
  {
    ((Control) this.textCheckTotal).Text = "Calculating...";
    Decimal checksTotal = 0M;
    ((UltraGridBase) this.gridDirectBillResults).UpdateData();
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) =>
      {
        foreach (UltraGridRow row1 in ((UltraGridBase) this.gridDirectBillResults).Rows)
        {
          if (((KeyedSubObjectBase) ((GridItemBase) row1).Band).Key.Equals("Payees") && (row1.Cells["SelectPayee"].Value.Equals((object) DBNull.Value) || (bool) row1.Cells["SelectPayee"].Value))
          {
            foreach (UltraGridRow row2 in row1.ChildBands[0].Rows)
            {
              if (bool.Parse(row2.Cells["SelectInvoice"].Text))
                checksTotal += (Decimal) row2.Cells["ProportionalAmount"].Value;
            }
          }
        }
      });
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) => ((Control) this.textCheckTotal).Text = checksTotal.ToString("c"));
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void pictCalculate_Click(object sender, EventArgs e) => this.CalculateChecksTotal();

  private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count == 0)
      return;
    for (int index1 = 0; index1 < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count; ++index1)
    {
      this.Cursor = MgaCursors.WaitCursor;
      ((UltraGridBase) this.gridDirectBillResults).Rows[index1].Cells["SelectPayee"].Value = (object) true;
      for (int index2 = 0; index2 < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows[index1].ChildBands[0].Rows).Count; ++index2)
      {
        ((UltraGridBase) this.gridDirectBillResults).Rows[index1].ChildBands[0].Rows[index2].Cells["SelectInvoice"].Value = (object) true;
        ((UltraGridBase) this.gridDirectBillResults).Rows[index1].ChildBands[0].Rows[index2].Update();
      }
      ((UltraGridBase) this.gridDirectBillResults).Rows[index1].Update();
      this.Cursor = MgaCursors.Default;
    }
    this.CalculateChecksTotal();
  }

  private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count == 0)
      return;
    for (int index1 = 0; index1 < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count; ++index1)
    {
      this.Cursor = MgaCursors.WaitCursor;
      ((UltraGridBase) this.gridDirectBillResults).Rows[index1].Cells["SelectPayee"].Value = (object) false;
      for (int index2 = 0; index2 < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows[index1].ChildBands[0].Rows).Count; ++index2)
      {
        ((UltraGridBase) this.gridDirectBillResults).Rows[index1].ChildBands[0].Rows[index2].Cells["SelectInvoice"].Value = (object) false;
        ((UltraGridBase) this.gridDirectBillResults).Rows[index1].ChildBands[0].Rows[index2].Update();
      }
      ((UltraGridBase) this.gridDirectBillResults).Rows[index1].Update();
      this.Cursor = MgaCursors.Default;
    }
    this.CalculateChecksTotal();
  }

  private void formDirectBillPayables_FormClosing(object sender, FormClosingEventArgs e)
  {
    this._formClosing = true;
  }

  private delegate void UIInvokeMethodHandler(int Stage);

  private delegate void ThreadExceptionsHandler(Exception ex);

  public delegate void InitRowPassthroughHandler(object sender, InitializeRowEventArgs e);

  private delegate void AddCheckCreationMessageHandler(string Message);
}
