// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formExcelImportWizard
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

[TestForm]
public class formExcelImportWizard : AccountingNoteDocumentSupport
{
  internal Panel panelStart;
  internal Panel Panel9;
  internal PictureBox PictureBox5;
  internal Label Label20;
  internal Label Label19;
  internal Panel Panel8;
  internal MGAButton btnStartNext;
  internal MGAButton btnStartCancel;
  internal Label Label24;
  internal Label Label23;
  internal Panel panelStep1;
  internal Panel panel18;
  internal PictureBox pictureBox17;
  internal Panel panel19;
  internal PictureBox pictureBox18;
  internal Label label7;
  internal Label label8;
  private Label label1;
  protected RadioButton radioAccountsReceivable;
  protected RadioButton radioAccountsPayable;
  private OpenFileDialog openFileDialog1;
  internal MGAButton buttonStep1Back;
  internal MGAButton buttonStep1Next;
  internal MGAButton buttonStep1Cancel;
  internal MGAButton buttonSearchFile;
  protected MGATextBox textFileName;
  internal Panel panelStep2;
  internal Panel panel2;
  internal PictureBox pictureBox1;
  internal Panel panel3;
  internal PictureBox pictureBox2;
  internal Label label3;
  internal Label label4;
  private Label label2;
  private MGASimpleComboBox comboWorksheet;
  private Label labelExcelStatus;
  internal MGAButton buttonStep2Back;
  internal MGAButton buttonStep2Next;
  internal MGAButton buttonStep2Cancel;
  private UltraGrid gridMappings;
  private UltraDropDown dropDownWorksheetFields;
  internal Panel panelStep3;
  internal Panel panel4;
  internal MGAButton buttonStep3Back;
  internal MGAButton buttonStep3Next;
  internal MGAButton buttonStep3Cancel;
  internal PictureBox pictureBox3;
  internal Panel panel5;
  internal PictureBox pictureBox4;
  internal Label label6;
  internal Label label9;
  private Label label5;
  protected MGATextBox textEntityName;
  protected RadioButton radioApplyAmounts;
  protected RadioButton radioDoNotApplyAmount;
  internal Panel panelConfirmation;
  private Label label10;
  internal Panel panel6;
  internal MGAButton buttonConfirmBack;
  internal MGAButton buttonConfirmFinish;
  internal MGAButton buttonConfirmCancel;
  internal PictureBox pictureBox6;
  internal Panel panel7;
  internal PictureBox pictureBox7;
  internal Label label11;
  internal Label label12;
  internal MGAButton buttonSearchEntity;
  private Label label15;
  private Panel panelMappings;
  private Label label16;
  private Label label18;
  private Label label22;
  private Label labelExcelFileName;
  private Label labelAutomationAccountingType;
  private Label labelEntityName;
  private Label labelExtendedAutomationSettings;
  private dsExcelImportMappings dsExcelImportMappings1;
  private dsExcelFieldNames dsExcelFieldNames1;
  private Label label13;
  protected MGASimpleComboBox comboOfficeLocation;
  protected Panel panelProcessing;
  internal Panel panel10;
  internal PictureBox pictureBox8;
  internal Panel panel11;
  internal PictureBox pictureBox9;
  internal Label label17;
  internal Label label21;
  private Label label14;
  protected UltraProgressBar progressProcessing;
  private MGACheckBox checkFirstRowColumnNames;
  private System.ComponentModel.Container components;
  protected DataSet excelData;
  protected Guid _entityName;
  protected Utility.PayablesSearchType _paySearchType;
  protected Utility.ReceivablesSearchType _recSearchType;
  protected formTransactionSearch.SearchTypes _searchType;
  protected StringBuilder _sb = new StringBuilder();

  public formExcelImportWizard() => this.InitializeComponent();

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formExcelImportWizard));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("FieldMappings", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("IMSField", -1, (object) "dropDownWorksheetFields");
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ExcelField");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("FieldNames", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FieldName");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
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
    this.panelStep1 = new Panel();
    this.textFileName = new MGATextBox();
    this.buttonSearchFile = new MGAButton();
    this.radioAccountsPayable = new RadioButton();
    this.radioAccountsReceivable = new RadioButton();
    this.label1 = new Label();
    this.panel18 = new Panel();
    this.buttonStep1Back = new MGAButton();
    this.buttonStep1Next = new MGAButton();
    this.buttonStep1Cancel = new MGAButton();
    this.pictureBox17 = new PictureBox();
    this.panel19 = new Panel();
    this.pictureBox18 = new PictureBox();
    this.label7 = new Label();
    this.label8 = new Label();
    this.openFileDialog1 = new OpenFileDialog();
    this.panelStep2 = new Panel();
    this.checkFirstRowColumnNames = new MGACheckBox();
    this.gridMappings = new UltraGrid();
    this.dsExcelImportMappings1 = new dsExcelImportMappings();
    this.comboWorksheet = new MGASimpleComboBox();
    this.label2 = new Label();
    this.panel2 = new Panel();
    this.buttonStep2Back = new MGAButton();
    this.buttonStep2Next = new MGAButton();
    this.buttonStep2Cancel = new MGAButton();
    this.pictureBox1 = new PictureBox();
    this.panel3 = new Panel();
    this.pictureBox2 = new PictureBox();
    this.label3 = new Label();
    this.label4 = new Label();
    this.dropDownWorksheetFields = new UltraDropDown();
    this.dsExcelFieldNames1 = new dsExcelFieldNames();
    this.labelExcelStatus = new Label();
    this.panelStep3 = new Panel();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.label13 = new Label();
    this.buttonSearchEntity = new MGAButton();
    this.radioDoNotApplyAmount = new RadioButton();
    this.radioApplyAmounts = new RadioButton();
    this.textEntityName = new MGATextBox();
    this.label5 = new Label();
    this.panel4 = new Panel();
    this.buttonStep3Back = new MGAButton();
    this.buttonStep3Next = new MGAButton();
    this.buttonStep3Cancel = new MGAButton();
    this.pictureBox3 = new PictureBox();
    this.panel5 = new Panel();
    this.pictureBox4 = new PictureBox();
    this.label6 = new Label();
    this.label9 = new Label();
    this.panelConfirmation = new Panel();
    this.labelExtendedAutomationSettings = new Label();
    this.label22 = new Label();
    this.labelEntityName = new Label();
    this.label18 = new Label();
    this.label16 = new Label();
    this.panelMappings = new Panel();
    this.labelAutomationAccountingType = new Label();
    this.label15 = new Label();
    this.labelExcelFileName = new Label();
    this.label10 = new Label();
    this.panel6 = new Panel();
    this.buttonConfirmBack = new MGAButton();
    this.buttonConfirmFinish = new MGAButton();
    this.buttonConfirmCancel = new MGAButton();
    this.pictureBox6 = new PictureBox();
    this.panel7 = new Panel();
    this.pictureBox7 = new PictureBox();
    this.label11 = new Label();
    this.label12 = new Label();
    this.panelProcessing = new Panel();
    this.progressProcessing = new UltraProgressBar();
    this.label14 = new Label();
    this.panel10 = new Panel();
    this.pictureBox8 = new PictureBox();
    this.panel11 = new Panel();
    this.pictureBox9 = new PictureBox();
    this.label17 = new Label();
    this.label21 = new Label();
    this.panelStart.SuspendLayout();
    this.Panel9.SuspendLayout();
    ((ISupportInitialize) this.PictureBox5).BeginInit();
    this.Panel8.SuspendLayout();
    ((ISupportInitialize) this.btnStartNext).BeginInit();
    ((ISupportInitialize) this.btnStartCancel).BeginInit();
    this.panelStep1.SuspendLayout();
    ((ISupportInitialize) this.textFileName).BeginInit();
    ((ISupportInitialize) this.buttonSearchFile).BeginInit();
    this.panel18.SuspendLayout();
    ((ISupportInitialize) this.buttonStep1Back).BeginInit();
    ((ISupportInitialize) this.buttonStep1Next).BeginInit();
    ((ISupportInitialize) this.buttonStep1Cancel).BeginInit();
    ((ISupportInitialize) this.pictureBox17).BeginInit();
    this.panel19.SuspendLayout();
    ((ISupportInitialize) this.pictureBox18).BeginInit();
    this.panelStep2.SuspendLayout();
    ((ISupportInitialize) this.checkFirstRowColumnNames).BeginInit();
    ((ISupportInitialize) this.gridMappings).BeginInit();
    this.dsExcelImportMappings1.BeginInit();
    ((ISupportInitialize) this.comboWorksheet).BeginInit();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.buttonStep2Back).BeginInit();
    ((ISupportInitialize) this.buttonStep2Next).BeginInit();
    ((ISupportInitialize) this.buttonStep2Cancel).BeginInit();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.panel3.SuspendLayout();
    ((ISupportInitialize) this.pictureBox2).BeginInit();
    ((ISupportInitialize) this.dropDownWorksheetFields).BeginInit();
    this.dsExcelFieldNames1.BeginInit();
    this.panelStep3.SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.buttonSearchEntity).BeginInit();
    ((ISupportInitialize) this.textEntityName).BeginInit();
    this.panel4.SuspendLayout();
    ((ISupportInitialize) this.buttonStep3Back).BeginInit();
    ((ISupportInitialize) this.buttonStep3Next).BeginInit();
    ((ISupportInitialize) this.buttonStep3Cancel).BeginInit();
    ((ISupportInitialize) this.pictureBox3).BeginInit();
    this.panel5.SuspendLayout();
    ((ISupportInitialize) this.pictureBox4).BeginInit();
    this.panelConfirmation.SuspendLayout();
    this.panel6.SuspendLayout();
    ((ISupportInitialize) this.buttonConfirmBack).BeginInit();
    ((ISupportInitialize) this.buttonConfirmFinish).BeginInit();
    ((ISupportInitialize) this.buttonConfirmCancel).BeginInit();
    ((ISupportInitialize) this.pictureBox6).BeginInit();
    this.panel7.SuspendLayout();
    ((ISupportInitialize) this.pictureBox7).BeginInit();
    this.panelProcessing.SuspendLayout();
    this.panel10.SuspendLayout();
    ((ISupportInitialize) this.pictureBox8).BeginInit();
    this.panel11.SuspendLayout();
    ((ISupportInitialize) this.pictureBox9).BeginInit();
    this.SuspendLayout();
    this.panelStart.BackColor = Color.White;
    this.panelStart.BorderStyle = BorderStyle.FixedSingle;
    this.panelStart.Controls.Add((Control) this.Panel9);
    this.panelStart.Controls.Add((Control) this.Label20);
    this.panelStart.Controls.Add((Control) this.Label19);
    this.panelStart.Controls.Add((Control) this.Panel8);
    this.panelStart.Controls.Add((Control) this.Label24);
    this.panelStart.Controls.Add((Control) this.Label23);
    this.panelStart.Dock = DockStyle.Fill;
    this.panelStart.Location = new Point(0, 0);
    this.panelStart.Name = "panelStart";
    this.panelStart.Size = new Size(768 /*0x0300*/, 430);
    this.panelStart.TabIndex = 7;
    this.Panel9.BackColor = Color.LightSlateGray;
    this.Panel9.Controls.Add((Control) this.PictureBox5);
    this.Panel9.Dock = DockStyle.Left;
    this.Panel9.Location = new Point(0, 0);
    this.Panel9.Name = "Panel9";
    this.Panel9.Size = new Size(136, 388);
    this.Panel9.TabIndex = 0;
    this.PictureBox5.Dock = DockStyle.Fill;
    this.PictureBox5.Image = (Image) componentResourceManager.GetObject("PictureBox5.Image");
    this.PictureBox5.Location = new Point(0, 0);
    this.PictureBox5.Name = "PictureBox5";
    this.PictureBox5.Size = new Size(136, 388);
    this.PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
    this.PictureBox5.TabIndex = 0;
    this.PictureBox5.TabStop = false;
    this.Label20.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label20.Location = new Point(152, 344);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(488, 16 /*0x10*/);
    this.Label20.TabIndex = 3;
    this.Label20.Text = "If at any time you wish to cancel this transaction, simply click the 'Cancel' button.";
    this.Label19.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label19.Location = new Point(152, 304);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(576, 32 /*0x20*/);
    this.Label19.TabIndex = 2;
    this.Label19.Text = "If at any time you make a mistake or you want to change a value, you can click the 'Back' button to go back to a previous step.";
    this.Panel8.BackgroundImage = (Image) componentResourceManager.GetObject("Panel8.BackgroundImage");
    this.Panel8.Controls.Add((Control) this.btnStartNext);
    this.Panel8.Controls.Add((Control) this.btnStartCancel);
    this.Panel8.Dock = DockStyle.Bottom;
    this.Panel8.Location = new Point(0, 388);
    this.Panel8.Name = "Panel8";
    this.Panel8.Size = new Size(766, 40);
    this.Panel8.TabIndex = 4;
    ((Control) this.btnStartNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance1).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance1).BackColor2 = Color.White;
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.Gray;
    ((ControlBase) this.btnStartNext).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnStartNext).Location = new Point(564, 8);
    ((Control) this.btnStartNext).Name = "btnStartNext";
    ((Control) this.btnStartNext).Size = new Size(100, 24);
    ((Control) this.btnStartNext).TabIndex = 0;
    ((Control) this.btnStartNext).Text = "&Next >";
    ((UltraControlBase) this.btnStartNext).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnStartNext).Click += new EventHandler(this.ClickHandler);
    ((Control) this.btnStartCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance2).BackColor2 = Color.White;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.Gray;
    ((ControlBase) this.btnStartCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnStartCancel).Location = new Point(676, 8);
    ((Control) this.btnStartCancel).Name = "btnStartCancel";
    ((Control) this.btnStartCancel).Size = new Size(75, 24);
    ((Control) this.btnStartCancel).TabIndex = 1;
    ((Control) this.btnStartCancel).Text = "&Cancel";
    ((UltraControlBase) this.btnStartCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnStartCancel).Click += new EventHandler(this.CancelHandler);
    this.Label24.AutoSize = true;
    this.Label24.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label24.Location = new Point(160 /*0xA0*/, 8);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(206, 23);
    this.Label24.TabIndex = 0;
    this.Label24.Text = "Excel Import Wizard";
    this.Label23.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label23.Location = new Point(160 /*0xA0*/, 48 /*0x30*/);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(592, 64 /*0x40*/);
    this.Label23.TabIndex = 1;
    this.Label23.Text = "Welcome to the Excel Import wizard. This wizard will walk you through the steps necessary to import and Excel worksheet";
    this.panelStep1.BackColor = Color.White;
    this.panelStep1.BorderStyle = BorderStyle.FixedSingle;
    this.panelStep1.Controls.Add((Control) this.textFileName);
    this.panelStep1.Controls.Add((Control) this.buttonSearchFile);
    this.panelStep1.Controls.Add((Control) this.radioAccountsPayable);
    this.panelStep1.Controls.Add((Control) this.radioAccountsReceivable);
    this.panelStep1.Controls.Add((Control) this.label1);
    this.panelStep1.Controls.Add((Control) this.panel18);
    this.panelStep1.Controls.Add((Control) this.panel19);
    this.panelStep1.Dock = DockStyle.Fill;
    this.panelStep1.Location = new Point(0, 0);
    this.panelStep1.Name = "panelStep1";
    this.panelStep1.Size = new Size(768 /*0x0300*/, 430);
    this.panelStep1.TabIndex = 15;
    this.panelStep1.Visible = false;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textFileName).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textFileName).BackColor = Color.White;
    ((Control) this.textFileName).Location = new Point(144 /*0x90*/, 176 /*0xB0*/);
    this.textFileName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textFileName).Name = "textFileName";
    ((Control) this.textFileName).Size = new Size(488, 20);
    ((Control) this.textFileName).TabIndex = 5;
    ((UltraControlBase) this.textFileName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textFileName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearchFile).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance4).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance4).BackColor2 = Color.White;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.Gray;
    ((AppearanceBase) appearance4).Image = (object) Resources.SearchTransaction;
    ((ControlBase) this.buttonSearchFile).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonSearchFile).Location = new Point(632, 175);
    ((Control) this.buttonSearchFile).Name = "buttonSearchFile";
    ((Control) this.buttonSearchFile).Size = new Size(22, 22);
    ((Control) this.buttonSearchFile).TabIndex = 9;
    ((UltraControlBase) this.buttonSearchFile).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearchFile).Click += new EventHandler(this.buttonSearchFile_Click);
    this.radioAccountsPayable.FlatStyle = FlatStyle.Flat;
    this.radioAccountsPayable.Location = new Point(336, 264);
    this.radioAccountsPayable.Name = "radioAccountsPayable";
    this.radioAccountsPayable.Size = new Size(136, 24);
    this.radioAccountsPayable.TabIndex = 8;
    this.radioAccountsPayable.Text = "Accounts Payable";
    this.radioAccountsReceivable.Checked = true;
    this.radioAccountsReceivable.FlatStyle = FlatStyle.Flat;
    this.radioAccountsReceivable.Location = new Point(336, 232);
    this.radioAccountsReceivable.Name = "radioAccountsReceivable";
    this.radioAccountsReceivable.Size = new Size(136, 24);
    this.radioAccountsReceivable.TabIndex = 7;
    this.radioAccountsReceivable.TabStop = true;
    this.radioAccountsReceivable.Text = "Accounts Receivable";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(144 /*0x90*/, 160 /*0xA0*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(139, 13);
    this.label1.TabIndex = 6;
    this.label1.Text = "Please Specify An Excel File";
    this.panel18.Controls.Add((Control) this.buttonStep1Back);
    this.panel18.Controls.Add((Control) this.buttonStep1Next);
    this.panel18.Controls.Add((Control) this.buttonStep1Cancel);
    this.panel18.Controls.Add((Control) this.pictureBox17);
    this.panel18.Dock = DockStyle.Bottom;
    this.panel18.Location = new Point(0, 388);
    this.panel18.Name = "panel18";
    this.panel18.Size = new Size(766, 40);
    this.panel18.TabIndex = 4;
    ((Control) this.buttonStep1Back).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance5).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance5).BackColor2 = Color.White;
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep1Back).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonStep1Back).Location = new Point(468, 8);
    ((Control) this.buttonStep1Back).Name = "buttonStep1Back";
    ((Control) this.buttonStep1Back).Size = new Size(100, 24);
    ((Control) this.buttonStep1Back).TabIndex = 0;
    ((Control) this.buttonStep1Back).Text = "< &Back";
    ((UltraControlBase) this.buttonStep1Back).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonStep1Back).Click += new EventHandler(this.ClickHandler);
    ((Control) this.buttonStep1Next).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance6).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance6).BackColor2 = Color.White;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep1Next).Appearance = (AppearanceBase) appearance6;
    ((Control) this.buttonStep1Next).Location = new Point(572, 8);
    ((Control) this.buttonStep1Next).Name = "buttonStep1Next";
    ((Control) this.buttonStep1Next).Size = new Size(100, 24);
    ((Control) this.buttonStep1Next).TabIndex = 1;
    ((Control) this.buttonStep1Next).Text = "&Next >";
    ((UltraControlBase) this.buttonStep1Next).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonStep1Next).Click += new EventHandler(this.ClickHandler);
    ((Control) this.buttonStep1Cancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance7).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance7).BackColor2 = Color.White;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep1Cancel).Appearance = (AppearanceBase) appearance7;
    ((Control) this.buttonStep1Cancel).Location = new Point(684, 8);
    ((Control) this.buttonStep1Cancel).Name = "buttonStep1Cancel";
    ((Control) this.buttonStep1Cancel).Size = new Size(75, 24);
    ((Control) this.buttonStep1Cancel).TabIndex = 2;
    ((Control) this.buttonStep1Cancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonStep1Cancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonStep1Cancel).Click += new EventHandler(this.CancelHandler);
    this.pictureBox17.Dock = DockStyle.Fill;
    this.pictureBox17.Image = (Image) componentResourceManager.GetObject("pictureBox17.Image");
    this.pictureBox17.Location = new Point(0, 0);
    this.pictureBox17.Name = "pictureBox17";
    this.pictureBox17.Size = new Size(766, 40);
    this.pictureBox17.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox17.TabIndex = 3;
    this.pictureBox17.TabStop = false;
    this.panel19.BackColor = Color.Transparent;
    this.panel19.BackgroundImage = (Image) componentResourceManager.GetObject("panel19.BackgroundImage");
    this.panel19.Controls.Add((Control) this.pictureBox18);
    this.panel19.Controls.Add((Control) this.label7);
    this.panel19.Controls.Add((Control) this.label8);
    this.panel19.Dock = DockStyle.Top;
    this.panel19.Location = new Point(0, 0);
    this.panel19.Name = "panel19";
    this.panel19.Size = new Size(766, 80 /*0x50*/);
    this.panel19.TabIndex = 0;
    this.pictureBox18.Image = (Image) componentResourceManager.GetObject("pictureBox18.Image");
    this.pictureBox18.Location = new Point(688, 8);
    this.pictureBox18.Name = "pictureBox18";
    this.pictureBox18.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.pictureBox18.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox18.TabIndex = 3;
    this.pictureBox18.TabStop = false;
    this.label7.BackColor = Color.Transparent;
    this.label7.ForeColor = Color.White;
    this.label7.Location = new Point(16 /*0x10*/, 40);
    this.label7.Name = "label7";
    this.label7.Size = new Size(640, 32 /*0x20*/);
    this.label7.TabIndex = 1;
    this.label7.Text = "Please specify the Excel file to import. You must also specify the import type whether this is for Accounts Receivable or Accounts Payable.";
    this.label8.AutoSize = true;
    this.label8.BackColor = Color.Transparent;
    this.label8.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label8.ForeColor = Color.White;
    this.label8.Location = new Point(8, 8);
    this.label8.Name = "label8";
    this.label8.Size = new Size(210, 23);
    this.label8.TabIndex = 0;
    this.label8.Text = "Import Type and File";
    this.openFileDialog1.DefaultExt = "xls";
    this.openFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files 97-2003(*.xls)|*.xls";
    this.openFileDialog1.InitialDirectory = "C:\\";
    this.openFileDialog1.Title = "Specify the Excel File to Open";
    this.panelStep2.BackColor = Color.White;
    this.panelStep2.BorderStyle = BorderStyle.FixedSingle;
    this.panelStep2.Controls.Add((Control) this.checkFirstRowColumnNames);
    this.panelStep2.Controls.Add((Control) this.gridMappings);
    this.panelStep2.Controls.Add((Control) this.comboWorksheet);
    this.panelStep2.Controls.Add((Control) this.label2);
    this.panelStep2.Controls.Add((Control) this.panel2);
    this.panelStep2.Controls.Add((Control) this.panel3);
    this.panelStep2.Controls.Add((Control) this.dropDownWorksheetFields);
    this.panelStep2.Controls.Add((Control) this.labelExcelStatus);
    this.panelStep2.Dock = DockStyle.Fill;
    this.panelStep2.Location = new Point(0, 0);
    this.panelStep2.Name = "panelStep2";
    this.panelStep2.Size = new Size(768 /*0x0300*/, 430);
    this.panelStep2.TabIndex = 16 /*0x10*/;
    this.panelStep2.Visible = false;
    ((AppearanceBase) appearance8).BorderColor = Color.Gray;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkFirstRowColumnNames).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.checkFirstRowColumnNames).Checked = true;
    ((UltraToggleEditorBase) this.checkFirstRowColumnNames).CheckState = CheckState.Checked;
    ((Control) this.checkFirstRowColumnNames).Enabled = false;
    ((UltraToggleEditorBase) this.checkFirstRowColumnNames).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkFirstRowColumnNames).Location = new Point(208 /*0xD0*/, 155);
    ((Control) this.checkFirstRowColumnNames).Name = "checkFirstRowColumnNames";
    ((Control) this.checkFirstRowColumnNames).Size = new Size(244, 16 /*0x10*/);
    ((Control) this.checkFirstRowColumnNames).TabIndex = 10;
    ((Control) this.checkFirstRowColumnNames).Text = "First row has column names.";
    ((UltraControlBase) this.checkFirstRowColumnNames).UseAppStyling = false;
    ((UltraControlBase) this.checkFirstRowColumnNames).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkFirstRowColumnNames).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkFirstRowColumnNames).CheckedChanged += new EventHandler(this.checkFirstRowColumnNames_CheckedChanged);
    ((UltraGridBase) this.gridMappings).DataMember = "FieldMappings";
    ((UltraGridBase) this.gridMappings).DataSource = (object) this.dsExcelImportMappings1;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Appearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridMappings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridColumn1.CellButtonAppearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Accounting Worksheet Field";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 175;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridColumn2.CellButtonAppearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Excel Worksheet Field";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 5;
    ultraGridColumn2.Width = 175;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.gridMappings).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridMappings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance13).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).BackColor = Color.Transparent;
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance18).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridMappings).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridMappings).Location = new Point(208 /*0xD0*/, 178);
    ((Control) this.gridMappings).Name = "gridMappings";
    ((Control) this.gridMappings).Size = new Size(352, 184);
    ((Control) this.gridMappings).TabIndex = 8;
    this.gridMappings.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridMappings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridMappings).UseOsThemes = (DefaultableBoolean) 2;
    this.dsExcelImportMappings1.DataSetName = "dsExcelImportMappings";
    this.dsExcelImportMappings1.Locale = new CultureInfo("en-US");
    this.comboWorksheet.BorderStyle = (UIElementBorderStyle) 4;
    this.comboWorksheet.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboWorksheet).Location = new Point(208 /*0xD0*/, 128 /*0x80*/);
    this.comboWorksheet.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboWorksheet).Name = "comboWorksheet";
    ((Control) this.comboWorksheet).Size = new Size(352, 21);
    ((Control) this.comboWorksheet).TabIndex = 6;
    ((UltraControlBase) this.comboWorksheet).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboWorksheet).UseOsThemes = (DefaultableBoolean) 2;
    this.comboWorksheet.RowSelected += new RowSelectedEventHandler(this.comboWorksheet_RowSelected);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(208 /*0xD0*/, 112 /*0x70*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(106, 13);
    this.label2.TabIndex = 5;
    this.label2.Text = "Specify a Worksheet";
    this.panel2.Controls.Add((Control) this.buttonStep2Back);
    this.panel2.Controls.Add((Control) this.buttonStep2Next);
    this.panel2.Controls.Add((Control) this.buttonStep2Cancel);
    this.panel2.Controls.Add((Control) this.pictureBox1);
    this.panel2.Dock = DockStyle.Bottom;
    this.panel2.Location = new Point(0, 388);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(766, 40);
    this.panel2.TabIndex = 4;
    ((Control) this.buttonStep2Back).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance20).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance20).BackColor2 = Color.White;
    ((AppearanceBase) appearance20).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance20).BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep2Back).Appearance = (AppearanceBase) appearance20;
    ((Control) this.buttonStep2Back).Location = new Point(468, 8);
    ((Control) this.buttonStep2Back).Name = "buttonStep2Back";
    ((Control) this.buttonStep2Back).Size = new Size(100, 24);
    ((Control) this.buttonStep2Back).TabIndex = 0;
    ((Control) this.buttonStep2Back).Text = "< &Back";
    ((UltraControlBase) this.buttonStep2Back).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonStep2Back).Click += new EventHandler(this.ClickHandler);
    ((Control) this.buttonStep2Next).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance21).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance21).BackColor2 = Color.White;
    ((AppearanceBase) appearance21).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance21).BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep2Next).Appearance = (AppearanceBase) appearance21;
    ((Control) this.buttonStep2Next).Location = new Point(572, 8);
    ((Control) this.buttonStep2Next).Name = "buttonStep2Next";
    ((Control) this.buttonStep2Next).Size = new Size(100, 24);
    ((Control) this.buttonStep2Next).TabIndex = 1;
    ((Control) this.buttonStep2Next).Text = "&Next >";
    ((UltraControlBase) this.buttonStep2Next).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonStep2Next).Click += new EventHandler(this.ClickHandler);
    ((Control) this.buttonStep2Cancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance22).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance22).BackColor2 = Color.White;
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance22).BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep2Cancel).Appearance = (AppearanceBase) appearance22;
    ((Control) this.buttonStep2Cancel).Location = new Point(684, 8);
    ((Control) this.buttonStep2Cancel).Name = "buttonStep2Cancel";
    ((Control) this.buttonStep2Cancel).Size = new Size(75, 24);
    ((Control) this.buttonStep2Cancel).TabIndex = 2;
    ((Control) this.buttonStep2Cancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonStep2Cancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonStep2Cancel).Click += new EventHandler(this.CancelHandler);
    this.pictureBox1.Dock = DockStyle.Fill;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(0, 0);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(766, 40);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox1.TabIndex = 3;
    this.pictureBox1.TabStop = false;
    this.panel3.BackColor = Color.Transparent;
    this.panel3.BackgroundImage = (Image) componentResourceManager.GetObject("panel3.BackgroundImage");
    this.panel3.Controls.Add((Control) this.pictureBox2);
    this.panel3.Controls.Add((Control) this.label3);
    this.panel3.Controls.Add((Control) this.label4);
    this.panel3.Dock = DockStyle.Top;
    this.panel3.Location = new Point(0, 0);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(766, 80 /*0x50*/);
    this.panel3.TabIndex = 0;
    this.pictureBox2.Image = (Image) componentResourceManager.GetObject("pictureBox2.Image");
    this.pictureBox2.Location = new Point(688, 8);
    this.pictureBox2.Name = "pictureBox2";
    this.pictureBox2.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox2.TabIndex = 3;
    this.pictureBox2.TabStop = false;
    this.label3.BackColor = Color.Transparent;
    this.label3.ForeColor = Color.White;
    this.label3.Location = new Point(16 /*0x10*/, 40);
    this.label3.Name = "label3";
    this.label3.Size = new Size(632, 32 /*0x20*/);
    this.label3.TabIndex = 1;
    this.label3.Text = "The wizard will analyze the specified Excel file. Please select the worksheet you wish to import and map the Excel worksheet fields to the IMS Accounting field provided.";
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label4.ForeColor = Color.White;
    this.label4.Location = new Point(8, 8);
    this.label4.Name = "label4";
    this.label4.Size = new Size(322, 23);
    this.label4.TabIndex = 0;
    this.label4.Text = "File Analysis And Field Mappings";
    ((UltraGridBase) this.dropDownWorksheetFields).DataMember = "FieldNames";
    ((UltraGridBase) this.dropDownWorksheetFields).DataSource = (object) this.dsExcelFieldNames1;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Appearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 0;
    ultraGridColumn3.Width = 206;
    ultraGridBand2.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance24).ForeColor = Color.Black;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance25).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance27).BackColor = Color.White;
    ((AppearanceBase) appearance27).BorderColor = Color.White;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).BorderColor = Color.White;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance29).BackColor = Color.Transparent;
    ((AppearanceBase) appearance29).ForeColor = Color.Black;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance29;
    ((AppearanceBase) appearance30).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance30).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.dropDownWorksheetFields).DisplayMember = "FieldName";
    ((Control) this.dropDownWorksheetFields).Location = new Point(352, 240 /*0xF0*/);
    ((Control) this.dropDownWorksheetFields).Name = "dropDownWorksheetFields";
    ((Control) this.dropDownWorksheetFields).Size = new Size(208 /*0xD0*/, 80 /*0x50*/);
    ((Control) this.dropDownWorksheetFields).TabIndex = 9;
    ((Control) this.dropDownWorksheetFields).Text = "ultraDropDown1";
    ((UltraControlBase) this.dropDownWorksheetFields).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dropDownWorksheetFields).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.dropDownWorksheetFields).ValueMember = "FieldName";
    ((Control) this.dropDownWorksheetFields).Visible = false;
    this.dsExcelFieldNames1.DataSetName = "dsExcelFieldNames";
    this.dsExcelFieldNames1.Locale = new CultureInfo("en-US");
    this.labelExcelStatus.AutoSize = true;
    this.labelExcelStatus.BackColor = Color.Transparent;
    this.labelExcelStatus.Location = new Point(8, 368);
    this.labelExcelStatus.Name = "labelExcelStatus";
    this.labelExcelStatus.Size = new Size(144 /*0x90*/, 13);
    this.labelExcelStatus.TabIndex = 7;
    this.labelExcelStatus.Text = "Starting Excel Application....";
    this.labelExcelStatus.Visible = false;
    this.panelStep3.BackColor = Color.White;
    this.panelStep3.BorderStyle = BorderStyle.FixedSingle;
    this.panelStep3.Controls.Add((Control) this.comboOfficeLocation);
    this.panelStep3.Controls.Add((Control) this.label13);
    this.panelStep3.Controls.Add((Control) this.buttonSearchEntity);
    this.panelStep3.Controls.Add((Control) this.radioDoNotApplyAmount);
    this.panelStep3.Controls.Add((Control) this.radioApplyAmounts);
    this.panelStep3.Controls.Add((Control) this.textEntityName);
    this.panelStep3.Controls.Add((Control) this.label5);
    this.panelStep3.Controls.Add((Control) this.panel4);
    this.panelStep3.Controls.Add((Control) this.panel5);
    this.panelStep3.Dock = DockStyle.Fill;
    this.panelStep3.Location = new Point(0, 0);
    this.panelStep3.Name = "panelStep3";
    this.panelStep3.Size = new Size(768 /*0x0300*/, 430);
    this.panelStep3.TabIndex = 17;
    this.panelStep3.Visible = false;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(224 /*0xE0*/, 128 /*0x80*/);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(368, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 11;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.label13.AutoSize = true;
    this.label13.Location = new Point(224 /*0xE0*/, 112 /*0x70*/);
    this.label13.Name = "label13";
    this.label13.Size = new Size(79, 13);
    this.label13.TabIndex = 10;
    this.label13.Text = "Office Location";
    ((Control) this.buttonSearchEntity).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance32).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance32).BackColor2 = Color.White;
    ((AppearanceBase) appearance32).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance32).BorderColor = Color.Gray;
    ((AppearanceBase) appearance32).Image = (object) Resources.SearchTransaction;
    ((AppearanceBase) appearance32).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance32).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearchEntity).Appearance = (AppearanceBase) appearance32;
    ((Control) this.buttonSearchEntity).Location = new Point(576, 184);
    ((Control) this.buttonSearchEntity).Name = "buttonSearchEntity";
    ((Control) this.buttonSearchEntity).Size = new Size(22, 22);
    ((Control) this.buttonSearchEntity).TabIndex = 9;
    ((UltraControlBase) this.buttonSearchEntity).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearchEntity).Click += new EventHandler(this.buttonSearchEntity_Click);
    this.radioDoNotApplyAmount.CheckAlign = ContentAlignment.TopLeft;
    this.radioDoNotApplyAmount.FlatStyle = FlatStyle.Flat;
    this.radioDoNotApplyAmount.Location = new Point(224 /*0xE0*/, 256 /*0x0100*/);
    this.radioDoNotApplyAmount.Name = "radioDoNotApplyAmount";
    this.radioDoNotApplyAmount.Size = new Size(400, 48 /*0x30*/);
    this.radioDoNotApplyAmount.TabIndex = 8;
    this.radioDoNotApplyAmount.Text = "I only want the wizard to load the invoices specified in the Excel file. I do not want the wizard to apply dollar amount where it can.";
    this.radioDoNotApplyAmount.TextAlign = ContentAlignment.TopLeft;
    this.radioApplyAmounts.CheckAlign = ContentAlignment.TopLeft;
    this.radioApplyAmounts.Checked = true;
    this.radioApplyAmounts.FlatStyle = FlatStyle.Flat;
    this.radioApplyAmounts.Location = new Point(224 /*0xE0*/, 232);
    this.radioApplyAmounts.Name = "radioApplyAmounts";
    this.radioApplyAmounts.Size = new Size(304, 24);
    this.radioApplyAmounts.TabIndex = 7;
    this.radioApplyAmounts.TabStop = true;
    this.radioApplyAmounts.Text = "I want the wizard to apply dollar amount where it can.";
    this.radioApplyAmounts.TextAlign = ContentAlignment.TopLeft;
    ((AppearanceBase) appearance33).BackColor = Color.White;
    ((AppearanceBase) appearance33).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance33).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEntityName).Appearance = (AppearanceBase) appearance33;
    ((Control) this.textEntityName).BackColor = Color.White;
    ((Control) this.textEntityName).Location = new Point(224 /*0xE0*/, 184);
    this.textEntityName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEntityName).Name = "textEntityName";
    ((EditorButtonControlBase) this.textEntityName).ReadOnly = true;
    ((Control) this.textEntityName).Size = new Size(352, 20);
    ((Control) this.textEntityName).TabIndex = 6;
    ((UltraControlBase) this.textEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEntityName).UseOsThemes = (DefaultableBoolean) 2;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(224 /*0xE0*/, 168);
    this.label5.Name = "label5";
    this.label5.Size = new Size(65, 13);
    this.label5.TabIndex = 5;
    this.label5.Text = "Entity Name";
    this.panel4.Controls.Add((Control) this.buttonStep3Back);
    this.panel4.Controls.Add((Control) this.buttonStep3Next);
    this.panel4.Controls.Add((Control) this.buttonStep3Cancel);
    this.panel4.Controls.Add((Control) this.pictureBox3);
    this.panel4.Dock = DockStyle.Bottom;
    this.panel4.Location = new Point(0, 388);
    this.panel4.Name = "panel4";
    this.panel4.Size = new Size(766, 40);
    this.panel4.TabIndex = 4;
    ((Control) this.buttonStep3Back).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance34).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance34).BackColor2 = Color.White;
    ((AppearanceBase) appearance34).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance34).BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep3Back).Appearance = (AppearanceBase) appearance34;
    ((Control) this.buttonStep3Back).Location = new Point(468, 8);
    ((Control) this.buttonStep3Back).Name = "buttonStep3Back";
    ((Control) this.buttonStep3Back).Size = new Size(100, 24);
    ((Control) this.buttonStep3Back).TabIndex = 0;
    ((Control) this.buttonStep3Back).Text = "< &Back";
    ((UltraControlBase) this.buttonStep3Back).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonStep3Back).Click += new EventHandler(this.ClickHandler);
    ((Control) this.buttonStep3Next).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance35).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance35).BackColor2 = Color.White;
    ((AppearanceBase) appearance35).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance35).BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep3Next).Appearance = (AppearanceBase) appearance35;
    ((Control) this.buttonStep3Next).Location = new Point(572, 8);
    ((Control) this.buttonStep3Next).Name = "buttonStep3Next";
    ((Control) this.buttonStep3Next).Size = new Size(100, 24);
    ((Control) this.buttonStep3Next).TabIndex = 1;
    ((Control) this.buttonStep3Next).Text = "&Next >";
    ((UltraControlBase) this.buttonStep3Next).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonStep3Next).Click += new EventHandler(this.ClickHandler);
    ((Control) this.buttonStep3Cancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance36).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance36).BackColor2 = Color.White;
    ((AppearanceBase) appearance36).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance36).BorderColor = Color.Gray;
    ((ControlBase) this.buttonStep3Cancel).Appearance = (AppearanceBase) appearance36;
    ((Control) this.buttonStep3Cancel).Location = new Point(684, 8);
    ((Control) this.buttonStep3Cancel).Name = "buttonStep3Cancel";
    ((Control) this.buttonStep3Cancel).Size = new Size(75, 24);
    ((Control) this.buttonStep3Cancel).TabIndex = 2;
    ((Control) this.buttonStep3Cancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonStep3Cancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonStep3Cancel).Click += new EventHandler(this.CancelHandler);
    this.pictureBox3.Dock = DockStyle.Fill;
    this.pictureBox3.Image = (Image) componentResourceManager.GetObject("pictureBox3.Image");
    this.pictureBox3.Location = new Point(0, 0);
    this.pictureBox3.Name = "pictureBox3";
    this.pictureBox3.Size = new Size(766, 40);
    this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox3.TabIndex = 3;
    this.pictureBox3.TabStop = false;
    this.panel5.BackColor = Color.Transparent;
    this.panel5.BackgroundImage = (Image) componentResourceManager.GetObject("panel5.BackgroundImage");
    this.panel5.Controls.Add((Control) this.pictureBox4);
    this.panel5.Controls.Add((Control) this.label6);
    this.panel5.Controls.Add((Control) this.label9);
    this.panel5.Dock = DockStyle.Top;
    this.panel5.Location = new Point(0, 0);
    this.panel5.Name = "panel5";
    this.panel5.Size = new Size(766, 80 /*0x50*/);
    this.panel5.TabIndex = 0;
    this.pictureBox4.Image = (Image) componentResourceManager.GetObject("pictureBox4.Image");
    this.pictureBox4.Location = new Point(688, 8);
    this.pictureBox4.Name = "pictureBox4";
    this.pictureBox4.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox4.TabIndex = 3;
    this.pictureBox4.TabStop = false;
    this.label6.BackColor = Color.Transparent;
    this.label6.ForeColor = Color.White;
    this.label6.Location = new Point(16 /*0x10*/, 40);
    this.label6.Name = "label6";
    this.label6.Size = new Size(640, 32 /*0x20*/);
    this.label6.TabIndex = 1;
    this.label6.Text = "Please specify the Excel file to import. You must also specify the import type whether this is for Accounts Receivable or Accounts Payable.";
    this.label9.AutoSize = true;
    this.label9.BackColor = Color.Transparent;
    this.label9.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label9.ForeColor = Color.White;
    this.label9.Location = new Point(8, 8);
    this.label9.Name = "label9";
    this.label9.Size = new Size(515, 23);
    this.label9.TabIndex = 0;
    this.label9.Text = "Office Location / Entity Selection / Automation Type";
    this.panelConfirmation.BackColor = Color.White;
    this.panelConfirmation.BorderStyle = BorderStyle.FixedSingle;
    this.panelConfirmation.Controls.Add((Control) this.labelExtendedAutomationSettings);
    this.panelConfirmation.Controls.Add((Control) this.label22);
    this.panelConfirmation.Controls.Add((Control) this.labelEntityName);
    this.panelConfirmation.Controls.Add((Control) this.label18);
    this.panelConfirmation.Controls.Add((Control) this.label16);
    this.panelConfirmation.Controls.Add((Control) this.panelMappings);
    this.panelConfirmation.Controls.Add((Control) this.labelAutomationAccountingType);
    this.panelConfirmation.Controls.Add((Control) this.label15);
    this.panelConfirmation.Controls.Add((Control) this.labelExcelFileName);
    this.panelConfirmation.Controls.Add((Control) this.label10);
    this.panelConfirmation.Controls.Add((Control) this.panel6);
    this.panelConfirmation.Controls.Add((Control) this.panel7);
    this.panelConfirmation.Dock = DockStyle.Fill;
    this.panelConfirmation.Location = new Point(0, 0);
    this.panelConfirmation.Name = "panelConfirmation";
    this.panelConfirmation.Size = new Size(768 /*0x0300*/, 430);
    this.panelConfirmation.TabIndex = 18;
    this.panelConfirmation.Visible = false;
    this.labelExtendedAutomationSettings.AutoSize = true;
    this.labelExtendedAutomationSettings.Location = new Point(224 /*0xE0*/, 360);
    this.labelExtendedAutomationSettings.Name = "labelExtendedAutomationSettings";
    this.labelExtendedAutomationSettings.Size = new Size(188, 13);
    this.labelExtendedAutomationSettings.TabIndex = 14;
    this.labelExtendedAutomationSettings.Text = "[EXTENDED AUTOMATION SETTINGS]";
    this.label22.AutoSize = true;
    this.label22.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label22.Location = new Point(224 /*0xE0*/, 344);
    this.label22.Name = "label22";
    this.label22.Size = new Size(187, 13);
    this.label22.TabIndex = 13;
    this.label22.Text = "Extended Automaqtion Settings";
    this.labelEntityName.AutoSize = true;
    this.labelEntityName.Location = new Point(224 /*0xE0*/, 320);
    this.labelEntityName.Name = "labelEntityName";
    this.labelEntityName.Size = new Size(81, 13);
    this.labelEntityName.TabIndex = 12;
    this.labelEntityName.Text = "[ENTITY NAME]";
    this.label18.AutoSize = true;
    this.label18.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label18.Location = new Point(224 /*0xE0*/, 304);
    this.label18.Name = "label18";
    this.label18.Size = new Size(75, 13);
    this.label18.TabIndex = 11;
    this.label18.Text = "Entity Name";
    this.label16.AutoSize = true;
    this.label16.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label16.Location = new Point(224 /*0xE0*/, 168);
    this.label16.Name = "label16";
    this.label16.Size = new Size(61, 13);
    this.label16.TabIndex = 10;
    this.label16.Text = "Mappings";
    this.panelMappings.Location = new Point(224 /*0xE0*/, 184);
    this.panelMappings.Name = "panelMappings";
    this.panelMappings.Size = new Size(328, 112 /*0x70*/);
    this.panelMappings.TabIndex = 9;
    this.labelAutomationAccountingType.AutoSize = true;
    this.labelAutomationAccountingType.Location = new Point(224 /*0xE0*/, 144 /*0x90*/);
    this.labelAutomationAccountingType.Name = "labelAutomationAccountingType";
    this.labelAutomationAccountingType.Size = new Size(180, 13);
    this.labelAutomationAccountingType.TabIndex = 8;
    this.labelAutomationAccountingType.Text = "[AUTOMATION ACCOUNTING TYPE]";
    this.label15.AutoSize = true;
    this.label15.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label15.Location = new Point(224 /*0xE0*/, 128 /*0x80*/);
    this.label15.Name = "label15";
    this.label15.Size = new Size(171, 13);
    this.label15.TabIndex = 7;
    this.label15.Text = "Automation Accounting Type";
    this.labelExcelFileName.AutoSize = true;
    this.labelExcelFileName.Location = new Point(224 /*0xE0*/, 104);
    this.labelExcelFileName.Name = "labelExcelFileName";
    this.labelExcelFileName.Size = new Size(69, 13);
    this.labelExcelFileName.TabIndex = 6;
    this.labelExcelFileName.Text = "[EXCEL FILE]";
    this.label10.AutoSize = true;
    this.label10.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label10.Location = new Point(224 /*0xE0*/, 88);
    this.label10.Name = "label10";
    this.label10.Size = new Size(58, 13);
    this.label10.TabIndex = 5;
    this.label10.Text = "Excel File";
    this.panel6.Controls.Add((Control) this.buttonConfirmBack);
    this.panel6.Controls.Add((Control) this.buttonConfirmFinish);
    this.panel6.Controls.Add((Control) this.buttonConfirmCancel);
    this.panel6.Controls.Add((Control) this.pictureBox6);
    this.panel6.Dock = DockStyle.Bottom;
    this.panel6.Location = new Point(0, 388);
    this.panel6.Name = "panel6";
    this.panel6.Size = new Size(766, 40);
    this.panel6.TabIndex = 4;
    ((Control) this.buttonConfirmBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance37).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance37).BackColor2 = Color.White;
    ((AppearanceBase) appearance37).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance37).BorderColor = Color.Gray;
    ((ControlBase) this.buttonConfirmBack).Appearance = (AppearanceBase) appearance37;
    ((Control) this.buttonConfirmBack).Location = new Point(468, 8);
    ((Control) this.buttonConfirmBack).Name = "buttonConfirmBack";
    ((Control) this.buttonConfirmBack).Size = new Size(100, 24);
    ((Control) this.buttonConfirmBack).TabIndex = 0;
    ((Control) this.buttonConfirmBack).Text = "< &Back";
    ((UltraControlBase) this.buttonConfirmBack).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonConfirmBack).Click += new EventHandler(this.ClickHandler);
    ((Control) this.buttonConfirmFinish).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance38).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance38).BackColor2 = Color.White;
    ((AppearanceBase) appearance38).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance38).BorderColor = Color.Gray;
    ((ControlBase) this.buttonConfirmFinish).Appearance = (AppearanceBase) appearance38;
    ((Control) this.buttonConfirmFinish).Location = new Point(572, 8);
    ((Control) this.buttonConfirmFinish).Name = "buttonConfirmFinish";
    ((Control) this.buttonConfirmFinish).Size = new Size(100, 24);
    ((Control) this.buttonConfirmFinish).TabIndex = 1;
    ((Control) this.buttonConfirmFinish).Text = "Finish";
    ((UltraControlBase) this.buttonConfirmFinish).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonConfirmFinish).Click += new EventHandler(this.buttonConfirmFinish_Click);
    ((Control) this.buttonConfirmCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance39).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance39).BackColor2 = Color.White;
    ((AppearanceBase) appearance39).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance39).BorderColor = Color.Gray;
    ((ControlBase) this.buttonConfirmCancel).Appearance = (AppearanceBase) appearance39;
    ((Control) this.buttonConfirmCancel).Location = new Point(684, 8);
    ((Control) this.buttonConfirmCancel).Name = "buttonConfirmCancel";
    ((Control) this.buttonConfirmCancel).Size = new Size(75, 24);
    ((Control) this.buttonConfirmCancel).TabIndex = 2;
    ((Control) this.buttonConfirmCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonConfirmCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonConfirmCancel).Click += new EventHandler(this.CancelHandler);
    this.pictureBox6.Dock = DockStyle.Fill;
    this.pictureBox6.Image = (Image) componentResourceManager.GetObject("pictureBox6.Image");
    this.pictureBox6.Location = new Point(0, 0);
    this.pictureBox6.Name = "pictureBox6";
    this.pictureBox6.Size = new Size(766, 40);
    this.pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox6.TabIndex = 3;
    this.pictureBox6.TabStop = false;
    this.panel7.BackColor = Color.Transparent;
    this.panel7.BackgroundImage = (Image) componentResourceManager.GetObject("panel7.BackgroundImage");
    this.panel7.Controls.Add((Control) this.pictureBox7);
    this.panel7.Controls.Add((Control) this.label11);
    this.panel7.Controls.Add((Control) this.label12);
    this.panel7.Dock = DockStyle.Top;
    this.panel7.Location = new Point(0, 0);
    this.panel7.Name = "panel7";
    this.panel7.Size = new Size(766, 80 /*0x50*/);
    this.panel7.TabIndex = 0;
    this.pictureBox7.Image = (Image) componentResourceManager.GetObject("pictureBox7.Image");
    this.pictureBox7.Location = new Point(688, 8);
    this.pictureBox7.Name = "pictureBox7";
    this.pictureBox7.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox7.TabIndex = 3;
    this.pictureBox7.TabStop = false;
    this.label11.BackColor = Color.Transparent;
    this.label11.ForeColor = Color.White;
    this.label11.Location = new Point(16 /*0x10*/, 40);
    this.label11.Name = "label11";
    this.label11.Size = new Size(640, 32 /*0x20*/);
    this.label11.TabIndex = 1;
    this.label11.Text = "Please specify the Excel file to import. You must also specify the import type whether this is for Accounts Receivable or Accounts Payable.";
    this.label12.AutoSize = true;
    this.label12.BackColor = Color.Transparent;
    this.label12.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label12.ForeColor = Color.White;
    this.label12.Location = new Point(8, 8);
    this.label12.Name = "label12";
    this.label12.Size = new Size(135, 23);
    this.label12.TabIndex = 0;
    this.label12.Text = "Confirmation";
    this.panelProcessing.BackColor = Color.White;
    this.panelProcessing.BorderStyle = BorderStyle.FixedSingle;
    this.panelProcessing.Controls.Add((Control) this.progressProcessing);
    this.panelProcessing.Controls.Add((Control) this.label14);
    this.panelProcessing.Controls.Add((Control) this.panel10);
    this.panelProcessing.Controls.Add((Control) this.panel11);
    this.panelProcessing.Dock = DockStyle.Fill;
    this.panelProcessing.Location = new Point(0, 0);
    this.panelProcessing.Name = "panelProcessing";
    this.panelProcessing.Size = new Size(768 /*0x0300*/, 430);
    this.panelProcessing.TabIndex = 19;
    this.panelProcessing.Visible = false;
    ((AppearanceBase) appearance40).BackColor = Color.White;
    ((AppearanceBase) appearance40).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.progressProcessing.Appearance = (AppearanceBase) appearance40;
    ((AppearanceBase) appearance41).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance41).BackColor2 = Color.LightSteelBlue;
    ((AppearanceBase) appearance41).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance41).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance41).ForeColor = Color.Black;
    this.progressProcessing.FillAppearance = (AppearanceBase) appearance41;
    ((Control) this.progressProcessing).Location = new Point(128 /*0x80*/, 224 /*0xE0*/);
    ((Control) this.progressProcessing).Name = "progressProcessing";
    ((Control) this.progressProcessing).Size = new Size(528, 16 /*0x10*/);
    ((Control) this.progressProcessing).TabIndex = 6;
    ((Control) this.progressProcessing).Text = "[Formatted]";
    ((UltraControlBase) this.progressProcessing).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.progressProcessing).UseOsThemes = (DefaultableBoolean) 2;
    this.label14.AutoSize = true;
    this.label14.Font = new Font("Tahoma", 9f);
    this.label14.Location = new Point(128 /*0x80*/, 192 /*0xC0*/);
    this.label14.Name = "label14";
    this.label14.Size = new Size(109, 14);
    this.label14.TabIndex = 5;
    this.label14.Text = "Processing File......";
    this.panel10.Controls.Add((Control) this.pictureBox8);
    this.panel10.Dock = DockStyle.Bottom;
    this.panel10.Location = new Point(0, 388);
    this.panel10.Name = "panel10";
    this.panel10.Size = new Size(766, 40);
    this.panel10.TabIndex = 4;
    this.pictureBox8.Dock = DockStyle.Fill;
    this.pictureBox8.Image = (Image) componentResourceManager.GetObject("pictureBox8.Image");
    this.pictureBox8.Location = new Point(0, 0);
    this.pictureBox8.Name = "pictureBox8";
    this.pictureBox8.Size = new Size(766, 40);
    this.pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox8.TabIndex = 3;
    this.pictureBox8.TabStop = false;
    this.panel11.BackColor = Color.Transparent;
    this.panel11.BackgroundImage = (Image) componentResourceManager.GetObject("panel11.BackgroundImage");
    this.panel11.Controls.Add((Control) this.pictureBox9);
    this.panel11.Controls.Add((Control) this.label17);
    this.panel11.Controls.Add((Control) this.label21);
    this.panel11.Dock = DockStyle.Top;
    this.panel11.Location = new Point(0, 0);
    this.panel11.Name = "panel11";
    this.panel11.Size = new Size(766, 80 /*0x50*/);
    this.panel11.TabIndex = 0;
    this.pictureBox9.Image = (Image) componentResourceManager.GetObject("pictureBox9.Image");
    this.pictureBox9.Location = new Point(688, 8);
    this.pictureBox9.Name = "pictureBox9";
    this.pictureBox9.Size = new Size(64 /*0x40*/, 64 /*0x40*/);
    this.pictureBox9.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox9.TabIndex = 3;
    this.pictureBox9.TabStop = false;
    this.label17.BackColor = Color.Transparent;
    this.label17.ForeColor = Color.White;
    this.label17.Location = new Point(16 /*0x10*/, 40);
    this.label17.Name = "label17";
    this.label17.Size = new Size(640, 32 /*0x20*/);
    this.label17.TabIndex = 1;
    this.label17.Text = "The Excel Import Wizard is processing the requested file with the specified field mappings. This process may take several minutes depending on the size of the file, please be patient.";
    this.label21.AutoSize = true;
    this.label21.BackColor = Color.Transparent;
    this.label21.Font = new Font("Tahoma", 14f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label21.ForeColor = Color.White;
    this.label21.Location = new Point(8, 8);
    this.label21.Name = "label21";
    this.label21.Size = new Size(153, 23);
    this.label21.TabIndex = 0;
    this.label21.Text = "Processing File";
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(768 /*0x0300*/, 430);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panelStep2);
    this.Controls.Add((Control) this.panelStep1);
    this.Controls.Add((Control) this.panelStart);
    this.Controls.Add((Control) this.panelConfirmation);
    this.Controls.Add((Control) this.panelStep3);
    this.Controls.Add((Control) this.panelProcessing);
    this.Font = new Font("Tahoma", 8f);
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (formExcelImportWizard);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "File Import Wizard";
    this.panelStart.ResumeLayout(false);
    this.panelStart.PerformLayout();
    this.Panel9.ResumeLayout(false);
    ((ISupportInitialize) this.PictureBox5).EndInit();
    this.Panel8.ResumeLayout(false);
    ((ISupportInitialize) this.btnStartNext).EndInit();
    ((ISupportInitialize) this.btnStartCancel).EndInit();
    this.panelStep1.ResumeLayout(false);
    this.panelStep1.PerformLayout();
    ((ISupportInitialize) this.textFileName).EndInit();
    ((ISupportInitialize) this.buttonSearchFile).EndInit();
    this.panel18.ResumeLayout(false);
    ((ISupportInitialize) this.buttonStep1Back).EndInit();
    ((ISupportInitialize) this.buttonStep1Next).EndInit();
    ((ISupportInitialize) this.buttonStep1Cancel).EndInit();
    ((ISupportInitialize) this.pictureBox17).EndInit();
    this.panel19.ResumeLayout(false);
    this.panel19.PerformLayout();
    ((ISupportInitialize) this.pictureBox18).EndInit();
    this.panelStep2.ResumeLayout(false);
    this.panelStep2.PerformLayout();
    ((ISupportInitialize) this.checkFirstRowColumnNames).EndInit();
    ((ISupportInitialize) this.gridMappings).EndInit();
    this.dsExcelImportMappings1.EndInit();
    ((ISupportInitialize) this.comboWorksheet).EndInit();
    this.panel2.ResumeLayout(false);
    ((ISupportInitialize) this.buttonStep2Back).EndInit();
    ((ISupportInitialize) this.buttonStep2Next).EndInit();
    ((ISupportInitialize) this.buttonStep2Cancel).EndInit();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.panel3.ResumeLayout(false);
    this.panel3.PerformLayout();
    ((ISupportInitialize) this.pictureBox2).EndInit();
    ((ISupportInitialize) this.dropDownWorksheetFields).EndInit();
    this.dsExcelFieldNames1.EndInit();
    this.panelStep3.ResumeLayout(false);
    this.panelStep3.PerformLayout();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.buttonSearchEntity).EndInit();
    ((ISupportInitialize) this.textEntityName).EndInit();
    this.panel4.ResumeLayout(false);
    ((ISupportInitialize) this.buttonStep3Back).EndInit();
    ((ISupportInitialize) this.buttonStep3Next).EndInit();
    ((ISupportInitialize) this.buttonStep3Cancel).EndInit();
    ((ISupportInitialize) this.pictureBox3).EndInit();
    this.panel5.ResumeLayout(false);
    this.panel5.PerformLayout();
    ((ISupportInitialize) this.pictureBox4).EndInit();
    this.panelConfirmation.ResumeLayout(false);
    this.panelConfirmation.PerformLayout();
    this.panel6.ResumeLayout(false);
    ((ISupportInitialize) this.buttonConfirmBack).EndInit();
    ((ISupportInitialize) this.buttonConfirmFinish).EndInit();
    ((ISupportInitialize) this.buttonConfirmCancel).EndInit();
    ((ISupportInitialize) this.pictureBox6).EndInit();
    this.panel7.ResumeLayout(false);
    this.panel7.PerformLayout();
    ((ISupportInitialize) this.pictureBox7).EndInit();
    this.panelProcessing.ResumeLayout(false);
    this.panelProcessing.PerformLayout();
    this.panel10.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox8).EndInit();
    this.panel11.ResumeLayout(false);
    this.panel11.PerformLayout();
    ((ISupportInitialize) this.pictureBox9).EndInit();
    this.ResumeLayout(false);
  }

  private void ClickHandler(object sender, EventArgs e)
  {
    if (sender == this.buttonStep1Next && ((Control) this.textFileName).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify an Excel file to continue.", "No File Specified!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (sender == this.buttonStep2Next && !this.ValidateFieldMappings() || sender == this.buttonStep3Next && !this.ValidateStep3())
        return;
      this.panelStart.Visible = sender == this.buttonStep1Back;
      this.panelStep1.Visible = sender == this.btnStartNext | sender == this.buttonStep2Back;
      this.panelStep2.Visible = sender == this.buttonStep1Next | sender == this.buttonStep3Back;
      this.panelStep3.Visible = sender == this.buttonStep2Next | sender == this.buttonConfirmBack;
      this.panelConfirmation.Visible = sender == this.buttonStep3Next;
      if (sender == this.buttonStep1Next)
      {
        this.labelExcelStatus.Visible = true;
        this.panelStep2.Refresh();
        ((UltraGridBase) this.comboWorksheet).DataSource = (object) this.GetWorksheets();
        ((UltraDropDownBase) this.comboWorksheet).DisplayMember = "WorksheetName";
        ((UltraDropDownBase) this.comboWorksheet).ValueMember = "WorksheetName";
        if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboWorksheet).Rows).Count == 0)
          this.comboWorksheet.Value = (object) ((UltraGridBase) this.comboWorksheet).Rows[0].Cells["WorksheetName"].Value.ToString();
      }
      if (sender == this.buttonStep2Next)
        this.GetOfficeLcoations();
      if (sender != this.buttonStep3Next)
        return;
      this.BuildConfirmationPanel();
    }
  }

  private void CancelHandler(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will close the Excel Import wizard, continue?", "Cancel Excel Import?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonSearchFile_Click(object sender, EventArgs e)
  {
    if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
      return;
    ((Control) this.textFileName).Text = this.openFileDialog1.FileName;
  }

  private DataTable GetWorksheets()
  {
    Workbook workbook = new Workbook(((Control) this.textFileName).Text);
    DataTable worksheets = new DataTable();
    worksheets.Columns.AddRange(new DataColumn[1]
    {
      new DataColumn("WorksheetName", typeof (string))
    });
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
      worksheets.Rows.Add((object) worksheet.Name);
    ((Control) this.comboWorksheet).Enabled = true;
    return worksheets;
  }

  private void BuildFieldMappingsDataset()
  {
    MGASystems.AsposeFacade.Cells.Cells cells = new Workbook(((Control) this.textFileName).Text).Worksheets[((Control) this.comboWorksheet).Text].Cells;
    this.dsExcelFieldNames1.Clear();
    if (this.excelData == null)
      this.excelData = new DataSet();
    this.excelData.Tables.Add(cells.ExportDataTable(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, ((UltraToggleEditorBase) this.checkFirstRowColumnNames).Checked));
    for (int index = 0; index < this.excelData.Tables[0].Columns.Count; ++index)
      this.dsExcelFieldNames1.FieldNames.Rows.Add((object) this.excelData.Tables[0].Columns[index].ColumnName);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].Columns[1].ValueList = (IValueList) this.dropDownWorksheetFields;
  }

  private void GetIMSFields()
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spfin_GetExcelFieldMappingsList", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    this.dsExcelImportMappings1.Clear();
    sqlDataAdapter.Fill((DataTable) this.dsExcelImportMappings1.FieldMappings);
  }

  private void comboWorksheet_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboWorksheet).SelectedRow == null || ((Control) this.comboWorksheet).Text.Equals(string.Empty))
      return;
    this.GetIMSFields();
    this.BuildFieldMappingsDataset();
  }

  private void buttonConfirmFinish_Click(object sender, EventArgs e) => this.Automate();

  private void GetOfficeLcoations()
  {
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = string.Empty;
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboOfficeLocation).Rows).Count != 1)
      return;
    this.comboOfficeLocation.Value = ((UltraGridBase) this.comboOfficeLocation).Rows[0].Cells["ID"].Value;
  }

  private void buttonSearchEntity_Click(object sender, EventArgs e)
  {
    using (FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.All))
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      ((Control) this.textEntityName).Tag = (object) formSearchEntity.EntityGuid;
      ((Control) this.textEntityName).Text = formSearchEntity.EntityName;
    }
  }

  private void BuildConfirmationPanel()
  {
    this.labelExcelFileName.Text = ((Control) this.textFileName).Text;
    if (this.radioAccountsReceivable.Checked)
      this.labelAutomationAccountingType.Text = "Accounts Receivable";
    else
      this.labelAutomationAccountingType.Text = "Accounts Payable";
    this._sb.Append("Excel Automation for ");
    this._sb.Append(this.labelAutomationAccountingType.Text);
    this._sb.Append(". Mapped as follows: ");
    this.panelMappings.Controls.Clear();
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (!row.Cells["ExcelField"].Value.Equals((object) DBNull.Value) && !row.Cells["ExcelField"].Value.ToString().Equals(string.Empty))
      {
        Label label = new Label();
        label.Text = $"{row.Cells["ImsField"].Value.ToString()} <- Maps To -> {row.Cells["ExcelField"].Value.ToString()}";
        this._sb.Append(label.Text);
        this._sb.Append(", ");
        label.Dock = DockStyle.Top;
        this.panelMappings.Controls.Add((Control) label);
      }
    }
    this._sb.Append(". For entity ");
    this.labelEntityName.Text = ((Control) this.textEntityName).Text;
    this._sb.Append(((Control) this.textEntityName).Text);
    if (this.radioApplyAmounts.Checked)
    {
      this.labelExtendedAutomationSettings.Text = "Apply Dollar Amounts";
      this._sb.Append(". System applies dollar amounts.");
    }
    else
    {
      this.labelExtendedAutomationSettings.Text = "Load Invoices Only";
      this._sb.Append(". System does not applies dollar amounts.");
    }
  }

  protected string GetInsuredNameField()
  {
    string empty = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (row.Cells["IMSField"].Value.ToString() == "Insured Name")
        return row.Cells["ExcelField"].Value.ToString();
    }
    return string.Empty;
  }

  protected string GetPolicyNumberField()
  {
    string empty = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (row.Cells["IMSField"].Value.ToString() == "Policy Number")
        return row.Cells["ExcelField"].Value.ToString();
    }
    return string.Empty;
  }

  protected string GetInvoiceNumberField()
  {
    string empty = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (row.Cells["IMSField"].Value.ToString() == "Invoice Number")
        return row.Cells["ExcelField"].Value.ToString();
    }
    return string.Empty;
  }

  protected string GetAppliedAmountField()
  {
    string empty = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (row.Cells["IMSField"].Value.ToString() == "Applied Amount")
        return row.Cells["ExcelField"].Value.ToString();
    }
    return string.Empty;
  }

  private string GetEffectiveDateField()
  {
    string empty = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (row.Cells["IMSField"].Value.ToString() == "Effective Date")
        return row.Cells["ExcelField"].Value.ToString();
    }
    return string.Empty;
  }

  private string GetUserDefinedAccountNumberField()
  {
    string empty = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (row.Cells["IMSField"].Value.ToString() == "(User-Defined) Account Number")
        return row.Cells["ExcelField"].Value.ToString();
    }
    return string.Empty;
  }

  protected int GetExcel_InvoiceNumber(DataRow r)
  {
    if (this.GetInvoiceNumberField().Equals(string.Empty))
      return 0;
    try
    {
      return int.Parse(r[this.GetInvoiceNumberField()].ToString().Trim(), NumberStyles.Any);
    }
    catch (FormatException ex)
    {
      return 0;
    }
  }

  protected string GetExcel_PolicyNumber(DataRow r)
  {
    return this.GetPolicyNumberField().Equals(string.Empty) ? string.Empty : r[this.GetPolicyNumberField()].ToString().Trim();
  }

  protected string GetExcel_InsuredName(DataRow r)
  {
    return this.GetInsuredNameField().Equals(string.Empty) ? string.Empty : r[this.GetInsuredNameField()].ToString().Trim();
  }

  protected string GetExcel_UserDefinedAccountNumber(DataRow r)
  {
    return this.GetUserDefinedAccountNumberField().Equals(string.Empty) ? string.Empty : r[this.GetUserDefinedAccountNumberField()].ToString().Trim();
  }

  protected Decimal GetExcel_ApplyAmount(DataRow r)
  {
    if (this.GetAppliedAmountField().Equals(string.Empty))
      return 0M;
    try
    {
      return Decimal.Round(Decimal.Parse(r[this.GetAppliedAmountField()].ToString().Trim(), NumberStyles.Any), 2);
    }
    catch (FormatException ex)
    {
      return 0M;
    }
  }

  protected DateTime GetExcel_EffectiveDate(DataRow r)
  {
    if (this.GetEffectiveDateField().Equals(string.Empty))
      return DateTime.Parse("1/1/1900");
    try
    {
      return DateTime.Parse(r[this.GetEffectiveDateField()].ToString());
    }
    catch (FormatException ex)
    {
      return DateTime.Parse("1/1/1900");
    }
  }

  protected virtual void Automate()
  {
    this.ValidateSettings();
    formTransactionBuilder transactionBuilder = new formTransactionBuilder();
    transactionBuilder.IsExcelAutomation = true;
    this.BringToFront();
    this.progressProcessing.Value = 0;
    this.progressProcessing.Maximum = this.excelData.Tables[0].Rows.Count;
    this.panelProcessing.Visible = true;
    this.panelProcessing.BringToFront();
    this.Refresh();
    transactionBuilder.MdiParent = MDIControls.Instance.MDIParent;
    transactionBuilder.Show();
    foreach (DataRow row in (InternalDataCollectionBase) this.excelData.Tables[0].Rows)
    {
      ++this.progressProcessing.Value;
      ((Control) this.progressProcessing).Refresh();
      if (this.radioApplyAmounts.Checked)
        ((IExcelAutomation) transactionBuilder).AutomateInvoiceSearch(new Guid(((Control) this.textEntityName).Tag.ToString()), int.Parse(this.comboOfficeLocation.Value.ToString()), this.GetExcel_InvoiceNumber(row), this.GetExcel_PolicyNumber(row), this.GetExcel_InsuredName(row), this.GetExcel_EffectiveDate(row), this.GetExcel_UserDefinedAccountNumber(row), this.GetExcel_ApplyAmount(row), this.radioAccountsPayable.Checked, ((Control) this.textEntityName).Text, this._paySearchType, this._recSearchType, this._searchType);
      else
        ((IExcelAutomation) transactionBuilder).AutomateInvoiceSearch(new Guid(((Control) this.textEntityName).Tag.ToString()), int.Parse(this.comboOfficeLocation.Value.ToString()), this.GetExcel_InvoiceNumber(row), this.GetExcel_PolicyNumber(row), this.GetExcel_InsuredName(row), this.GetExcel_EffectiveDate(row), this.GetExcel_UserDefinedAccountNumber(row), 0M, this.radioAccountsPayable.Checked, ((Control) this.textEntityName).Text, this._paySearchType, this._recSearchType, this._searchType);
    }
    ((IExcelAutomation) transactionBuilder).CheckAppliedErrors();
    ((IExcelAutomation) transactionBuilder).ApplyFormSettings();
    transactionBuilder.IsExcelAutomation = false;
    CurrentUser.Instance.LogAction(this._sb.ToString(), "Accounting Logs");
    this.Close();
  }

  private void InsertExcelValues()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblFin_ExcelImport");
    foreach (DataRow row in (InternalDataCollectionBase) this.excelData.Tables[0].Rows)
    {
      ++this.progressProcessing.Value;
      ((Control) this.progressProcessing).Refresh();
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblFin_ExcelImport(PolicyNumber, EffectiveDate, InvoiceNumber, ApplyAmount) VALUES(@PolicyNumber, @EffectiveDate, @InvoiceNumber, @ApplyAmount)", new object[8]
      {
        (object) "@PolicyNumber",
        (object) this.GetExcel_PolicyNumber(row),
        (object) "@EffectiveDate",
        (object) this.GetExcel_EffectiveDate(row),
        (object) "@InvoiceNumber",
        (object) this.GetExcel_InvoiceNumber(row),
        (object) "@ApplyAmount",
        (object) this.GetExcel_ApplyAmount(row)
      });
    }
  }

  protected void ValidateSettings()
  {
    if (this.radioAccountsPayable.Checked)
      this._searchType = formTransactionSearch.SearchTypes.Payables;
    else if (this.radioAccountsReceivable.Checked)
      this._searchType = formTransactionSearch.SearchTypes.Receivables;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (row.Cells["IMSField"].Value.ToString().Equals("Policy Number") && !string.IsNullOrEmpty(row.Cells["ExcelField"].Value.ToString()))
      {
        switch (this._searchType)
        {
          case formTransactionSearch.SearchTypes.Payables:
            this._paySearchType = Utility.PayablesSearchType.PolicyNumber;
            this._recSearchType = Utility.ReceivablesSearchType.None;
            break;
          case formTransactionSearch.SearchTypes.Receivables:
            this._paySearchType = Utility.PayablesSearchType.None;
            this._recSearchType = Utility.ReceivablesSearchType.PolicyNumber;
            break;
        }
      }
      if (row.Cells["IMSField"].Value.ToString().Equals("Invoice Number") && !string.IsNullOrEmpty(row.Cells["ExcelField"].Value.ToString()))
      {
        switch (this._searchType)
        {
          case formTransactionSearch.SearchTypes.Payables:
            this._paySearchType = Utility.PayablesSearchType.InvoiceNumber;
            this._recSearchType = Utility.ReceivablesSearchType.None;
            continue;
          case formTransactionSearch.SearchTypes.Receivables:
            this._paySearchType = Utility.PayablesSearchType.None;
            this._recSearchType = Utility.ReceivablesSearchType.InvoiceNumber;
            continue;
          default:
            continue;
        }
      }
    }
  }

  private bool ValidateFieldMappings()
  {
    bool flag1 = true;
    bool flag2 = true;
    bool flag3 = true;
    bool flag4 = true;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (row.Cells["IMSField"].Value.ToString().Equals("Policy Number") && row.Cells["ExcelField"].Value.ToString().Equals(string.Empty))
        flag1 = false;
      if (row.Cells["IMSField"].Value.ToString().Equals("Effective Date") && row.Cells["ExcelField"].Value.ToString().Equals(string.Empty))
        flag2 = false;
      if (row.Cells["IMSField"].Value.ToString().Equals("(User-Defined) Account Number") && row.Cells["ExcelField"].Value.ToString().Equals(string.Empty))
        flag3 = false;
      if (row.Cells["IMSField"].Value.ToString().Equals("Invoice Number") && row.Cells["ExcelField"].Value.ToString().Equals(string.Empty))
        flag4 = false;
    }
    if (flag1 & flag2 || flag3 || flag4)
      return true;
    int num = (int) MessageBox.Show("You must specify either the policy number and effective date, invoice number or the user defined account number to continue.", "Required Field Mappings Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private bool ValidateStep3()
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textEntityName).Text.Equals(string.Empty) || ((Control) this.textEntityName).Tag == null)
    {
      int num = (int) MessageBox.Show("You must select an entity to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.radioApplyAmounts.Checked || this.radioDoNotApplyAmount.Checked)
      return true;
    int num1 = (int) MessageBox.Show("You must specify whether or not the wizard should apply amounts when importing the file.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void checkFirstRowColumnNames_CheckedChanged(object sender, EventArgs e)
  {
    if (this.dsExcelFieldNames1.Tables[0].Rows.Count == 0)
      return;
    this.BuildFieldMappingsDataset();
  }
}
