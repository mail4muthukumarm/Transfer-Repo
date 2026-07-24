// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formTransactionSearch
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Exceptions;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formTransactionSearch : Form
{
  private Panel panelTop;
  private Panel panelLeft;
  private Panel panelBottom;
  private Label label1;
  private PictureBox picture1;
  private MGAButton buttonFinish;
  private MGAButton buttonCancel;
  private MGAButton buttonBack;
  private MGAButton buttonNext;
  private Label labelLine;
  private UltraLabel ultraLabel1;
  private UltraLabel labelSideBarHeader;
  private UltraLabel ultraLabel2;
  private Label label2;
  private Label label3;
  private Label label4;
  protected MGAButton buttonSearch;
  protected UltraOptionSet optionPayables;
  private MGATextBox textPayablesCriteria;
  protected UltraOptionSet optionReceivables;
  private MGATextBox textReceivablesCriteria;
  private MGADateTimePicker dateBordereau;
  private Panel panelStep1;
  private Panel panelStep2;
  private Label label8;
  protected MGASimpleComboBox comboOfficeLocations;
  private dsOfficeLocations dsOfficeLocations1;
  private Panel panelStep0;
  private Label label9;
  private Label label10;
  private UltraLabel ultraLabel4;
  private UltraLabel ultraLabel6;
  private ImageList imageList1;
  private UltraLabel ultraLabel8;
  private Label label11;
  private Label label12;
  protected RadioButton optionPayablesOnly;
  protected RadioButton optionPayablesReceivables;
  protected RadioButton optionReceivablesOnly;
  private UltraLabel labelStep1;
  private UltraLabel labelStep2;
  private UltraLabel labelStep3;
  private Panel panelContent;
  private Panel panelReceivableOptions;
  private Panel panelPayableOptions;
  private Label label13;
  private Label label14;
  private Panel panelPayablesReceivablesOptions;
  private Label label15;
  private Label labelResultsType;
  private Label labelNoResults;
  private CheckBox checkShowZeroInvoices;
  private dsGetOpenReceivables dsGetOpenReceivables1;
  private UltraGrid gridResults;
  private dsGetOpenPayables dsGetOpenPayables1;
  protected MGATextBox textEntityName;
  private IContainer components;
  private Label labelDirectBillOnly;
  private StatusStrip StatusStrip;
  private ToolStripStatusLabel ToolStripStatusLabel;
  private int? _glCompanyId;
  private int _currentWizardStep;
  private Guid _entityGuid = Guid.Empty;
  private int _controlNumber;
  private int _invoiceNumber;
  private int _maxRows;
  private string _policyNumber = string.Empty;
  private DateTime _bordereaux = DateTime.MinValue;
  private string _producerLocationCode = string.Empty;
  private int _insuredCode;
  private bool _isAdditionalSearch;
  private formTransactionSearch.SearchTypes _searchType;
  private Utility.PayablesSearchType _payablesSearch;
  private Utility.ReceivablesSearchType _receivablesSearch;

  public formTransactionSearch()
  {
    this.InitializeComponent();
    this.panelStep0.BringToFront();
  }

  public formTransactionSearch(
    formTransactionSearch.SearchTypes searchType,
    int glCompanyId,
    string entityName,
    Guid entityGuid)
  {
    this.InitializeComponent();
    this.panelStep0.BringToFront();
    this._glCompanyId = new int?(glCompanyId);
    this._isAdditionalSearch = true;
    this._searchType = searchType;
    this.ToggleSearchMode();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formTransactionSearch));
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
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    ValueListItem valueListItem3 = new ValueListItem();
    ValueListItem valueListItem4 = new ValueListItem();
    ValueListItem valueListItem5 = new ValueListItem();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ValueListItem valueListItem6 = new ValueListItem();
    ValueListItem valueListItem7 = new ValueListItem();
    ValueListItem valueListItem8 = new ValueListItem();
    ValueListItem valueListItem9 = new ValueListItem();
    ValueListItem valueListItem10 = new ValueListItem();
    ValueListItem valueListItem11 = new ValueListItem();
    ValueListItem valueListItem12 = new ValueListItem();
    Appearance appearance18 = new Appearance();
    ValueListItem valueListItem13 = new ValueListItem();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("OpenReceivables", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("RemitterGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Remitter");
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PolicyNumber");
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Balance");
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("PayablesLayout");
    Appearance appearance39 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("OpenPayables", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PolicyNumber");
    Appearance appearance40 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("EntityName");
    Appearance appearance41 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("GrossPayable");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Balance");
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("ReceivablesLayout");
    Appearance appearance52 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("OpenReceivables", -1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("RemitterGuid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Remitter");
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("PolicyNumber");
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Balance");
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    this.panelTop = new Panel();
    this.labelLine = new Label();
    this.picture1 = new PictureBox();
    this.label1 = new Label();
    this.panelLeft = new Panel();
    this.label14 = new Label();
    this.ultraLabel8 = new UltraLabel();
    this.labelStep3 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.labelStep2 = new UltraLabel();
    this.ultraLabel4 = new UltraLabel();
    this.labelStep1 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.labelSideBarHeader = new UltraLabel();
    this.ultraLabel1 = new UltraLabel();
    this.panelBottom = new Panel();
    this.StatusStrip = new StatusStrip();
    this.ToolStripStatusLabel = new ToolStripStatusLabel();
    this.label13 = new Label();
    this.buttonBack = new MGAButton();
    this.buttonNext = new MGAButton();
    this.buttonFinish = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.buttonSearch = new MGAButton();
    this.optionPayables = new UltraOptionSet();
    this.textPayablesCriteria = new MGATextBox();
    this.optionReceivables = new UltraOptionSet();
    this.textReceivablesCriteria = new MGATextBox();
    this.dateBordereau = new MGADateTimePicker();
    this.panelStep1 = new Panel();
    this.comboOfficeLocations = new MGASimpleComboBox();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    this.label8 = new Label();
    this.textEntityName = new MGATextBox();
    this.panelReceivableOptions = new Panel();
    this.labelDirectBillOnly = new Label();
    this.checkShowZeroInvoices = new CheckBox();
    this.panelPayableOptions = new Panel();
    this.panelPayablesReceivablesOptions = new Panel();
    this.label15 = new Label();
    this.panelStep2 = new Panel();
    this.labelResultsType = new Label();
    this.gridResults = new UltraGrid();
    this.dsGetOpenReceivables1 = new dsGetOpenReceivables();
    this.labelNoResults = new Label();
    this.panelStep0 = new Panel();
    this.optionReceivablesOnly = new RadioButton();
    this.optionPayablesReceivables = new RadioButton();
    this.optionPayablesOnly = new RadioButton();
    this.label12 = new Label();
    this.label11 = new Label();
    this.label10 = new Label();
    this.label9 = new Label();
    this.imageList1 = new ImageList(this.components);
    this.panelContent = new Panel();
    this.dsGetOpenPayables1 = new dsGetOpenPayables();
    this.panelTop.SuspendLayout();
    ((ISupportInitialize) this.picture1).BeginInit();
    this.panelLeft.SuspendLayout();
    this.panelBottom.SuspendLayout();
    this.StatusStrip.SuspendLayout();
    ((ISupportInitialize) this.buttonBack).BeginInit();
    ((ISupportInitialize) this.buttonNext).BeginInit();
    ((ISupportInitialize) this.buttonFinish).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSearch).BeginInit();
    ((ISupportInitialize) this.optionPayables).BeginInit();
    ((ISupportInitialize) this.textPayablesCriteria).BeginInit();
    ((ISupportInitialize) this.optionReceivables).BeginInit();
    ((ISupportInitialize) this.textReceivablesCriteria).BeginInit();
    ((ISupportInitialize) this.dateBordereau).BeginInit();
    this.panelStep1.SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocations).BeginInit();
    this.dsOfficeLocations1.BeginInit();
    ((ISupportInitialize) this.textEntityName).BeginInit();
    this.panelReceivableOptions.SuspendLayout();
    this.panelPayableOptions.SuspendLayout();
    this.panelPayablesReceivablesOptions.SuspendLayout();
    this.panelStep2.SuspendLayout();
    ((ISupportInitialize) this.gridResults).BeginInit();
    this.dsGetOpenReceivables1.BeginInit();
    this.panelStep0.SuspendLayout();
    this.panelContent.SuspendLayout();
    this.dsGetOpenPayables1.BeginInit();
    this.SuspendLayout();
    this.panelTop.Controls.Add((Control) this.labelLine);
    this.panelTop.Controls.Add((Control) this.picture1);
    this.panelTop.Controls.Add((Control) this.label1);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(753, 88);
    this.panelTop.TabIndex = 0;
    this.labelLine.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.labelLine.Dock = DockStyle.Bottom;
    this.labelLine.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.labelLine.Location = new Point(0, 87);
    this.labelLine.Name = "labelLine";
    this.labelLine.Size = new Size(753, 1);
    this.labelLine.TabIndex = 2;
    this.labelLine.Text = "label2";
    this.picture1.Image = (Image) componentResourceManager.GetObject("picture1.Image");
    this.picture1.Location = new Point(8, 0);
    this.picture1.Name = "picture1";
    this.picture1.Size = new Size(100, 80 /*0x50*/);
    this.picture1.SizeMode = PictureBoxSizeMode.CenterImage;
    this.picture1.TabIndex = 1;
    this.picture1.TabStop = false;
    this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(513, 56);
    this.label1.Name = "label1";
    this.label1.Size = new Size(233, 22);
    this.label1.TabIndex = 0;
    this.label1.Text = "Find Open Transactions";
    this.panelLeft.Controls.Add((Control) this.label14);
    this.panelLeft.Controls.Add((Control) this.ultraLabel8);
    this.panelLeft.Controls.Add((Control) this.labelStep3);
    this.panelLeft.Controls.Add((Control) this.ultraLabel6);
    this.panelLeft.Controls.Add((Control) this.labelStep2);
    this.panelLeft.Controls.Add((Control) this.ultraLabel4);
    this.panelLeft.Controls.Add((Control) this.labelStep1);
    this.panelLeft.Controls.Add((Control) this.ultraLabel2);
    this.panelLeft.Controls.Add((Control) this.labelSideBarHeader);
    this.panelLeft.Controls.Add((Control) this.ultraLabel1);
    this.panelLeft.Dock = DockStyle.Left;
    this.panelLeft.Location = new Point(0, 88);
    this.panelLeft.Name = "panelLeft";
    this.panelLeft.Size = new Size(184, 331);
    this.panelLeft.TabIndex = 0;
    this.label14.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label14.Dock = DockStyle.Right;
    this.label14.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label14.Location = new Point(183, 0);
    this.label14.Name = "label14";
    this.label14.Size = new Size(1, 331);
    this.label14.TabIndex = 9;
    this.label14.Text = "label2";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance1;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel8).Location = new Point(8, 216);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(168, 14);
    ((Control) this.ultraLabel8).TabIndex = 8;
    ((Control) this.ultraLabel8).Text = "Verify and Complete Your Search";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((ControlBase) this.labelStep3).Appearance = (AppearanceBase) appearance2;
    ((Control) this.labelStep3).AutoSize = true;
    ((Control) this.labelStep3).Font = new Font("Arial", 8f, FontStyle.Bold);
    ((Control) this.labelStep3).Location = new Point(8, 200);
    ((Control) this.labelStep3).Name = "labelStep3";
    ((Control) this.labelStep3).Size = new Size(37, 14);
    ((Control) this.labelStep3).TabIndex = 7;
    ((Control) this.labelStep3).Text = "Step 3";
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel6).Appearance = (AppearanceBase) appearance3;
    ((Control) this.ultraLabel6).AutoSize = true;
    ((Control) this.ultraLabel6).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel6).Location = new Point(8, 176 /*0xB0*/);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(141, 14);
    ((Control) this.ultraLabel6).TabIndex = 6;
    ((Control) this.ultraLabel6).Text = "Define Your Search Criteria.";
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((ControlBase) this.labelStep2).Appearance = (AppearanceBase) appearance4;
    ((Control) this.labelStep2).AutoSize = true;
    ((Control) this.labelStep2).Font = new Font("Arial", 8f, FontStyle.Bold);
    ((Control) this.labelStep2).Location = new Point(8, 160 /*0xA0*/);
    ((Control) this.labelStep2).Name = "labelStep2";
    ((Control) this.labelStep2).Size = new Size(37, 14);
    ((Control) this.labelStep2).TabIndex = 5;
    ((Control) this.labelStep2).Text = "Step 2";
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance5;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel4).Location = new Point(8, 136);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(151, 14);
    ((Control) this.ultraLabel4).TabIndex = 4;
    ((Control) this.ultraLabel4).Text = "What Are You Searching For?";
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((ControlBase) this.labelStep1).Appearance = (AppearanceBase) appearance6;
    ((Control) this.labelStep1).AutoSize = true;
    ((Control) this.labelStep1).Font = new Font("Arial", 8f, FontStyle.Bold);
    ((Control) this.labelStep1).Location = new Point(7, 120);
    ((Control) this.labelStep1).Name = "labelStep1";
    ((Control) this.labelStep1).Size = new Size(37, 14);
    ((Control) this.labelStep1).TabIndex = 3;
    ((Control) this.labelStep1).Text = "Step 1";
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance7;
    ((Control) this.ultraLabel2).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel2).Location = new Point(8, 40);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(168, 88);
    ((Control) this.ultraLabel2).TabIndex = 2;
    ((Control) this.ultraLabel2).Text = "This wizard will help you search for open transactions invoice transactions within the IMS. You can search for both payable and receivable transactions.";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).ForeColor = Color.DimGray;
    ((ControlBase) this.labelSideBarHeader).Appearance = (AppearanceBase) appearance8;
    ((Control) this.labelSideBarHeader).AutoSize = true;
    ((Control) this.labelSideBarHeader).Font = new Font("Arial", 8f, FontStyle.Bold);
    ((Control) this.labelSideBarHeader).Location = new Point(8, 16 /*0x10*/);
    ((Control) this.labelSideBarHeader).Name = "labelSideBarHeader";
    ((Control) this.labelSideBarHeader).Size = new Size(154, 14);
    ((Control) this.labelSideBarHeader).TabIndex = 1;
    ((Control) this.labelSideBarHeader).Text = "FIND OPEN TRANSACTIONS";
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BackColor2 = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance9).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance9;
    this.ultraLabel1.BorderStyleOuter = (UIElementBorderStyle) 1;
    ((Control) this.ultraLabel1).Dock = DockStyle.Fill;
    ((Control) this.ultraLabel1).Location = new Point(0, 0);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(184, 331);
    ((Control) this.ultraLabel1).TabIndex = 0;
    this.panelBottom.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelBottom.Controls.Add((Control) this.StatusStrip);
    this.panelBottom.Controls.Add((Control) this.label13);
    this.panelBottom.Controls.Add((Control) this.buttonBack);
    this.panelBottom.Controls.Add((Control) this.buttonNext);
    this.panelBottom.Controls.Add((Control) this.buttonFinish);
    this.panelBottom.Controls.Add((Control) this.buttonCancel);
    this.panelBottom.Dock = DockStyle.Bottom;
    this.panelBottom.Location = new Point(0, 419);
    this.panelBottom.Name = "panelBottom";
    this.panelBottom.Size = new Size(753, 63 /*0x3F*/);
    this.panelBottom.TabIndex = 0;
    this.StatusStrip.Items.AddRange(new ToolStripItem[1]
    {
      (ToolStripItem) this.ToolStripStatusLabel
    });
    this.StatusStrip.Location = new Point(0, 41);
    this.StatusStrip.Name = "StatusStrip";
    this.StatusStrip.Size = new Size(753, 22);
    this.StatusStrip.SizingGrip = false;
    this.StatusStrip.TabIndex = 9;
    this.StatusStrip.Text = "statusStrip1";
    this.StatusStrip.Visible = false;
    this.ToolStripStatusLabel.BackColor = Color.Transparent;
    this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
    this.ToolStripStatusLabel.Size = new Size(738, 17);
    this.ToolStripStatusLabel.Spring = true;
    this.ToolStripStatusLabel.Text = "toolStripStatusLabel1";
    this.label13.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label13.Dock = DockStyle.Top;
    this.label13.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label13.Location = new Point(0, 0);
    this.label13.Name = "label13";
    this.label13.Size = new Size(753, 1);
    this.label13.TabIndex = 8;
    this.label13.Text = "label2";
    ((Control) this.buttonBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance10).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance10).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonBack).Appearance = (AppearanceBase) appearance10;
    ((Control) this.buttonBack).Enabled = false;
    ((Control) this.buttonBack).Location = new Point(369, 8);
    ((Control) this.buttonBack).Name = "buttonBack";
    ((Control) this.buttonBack).Size = new Size(88, 24);
    ((Control) this.buttonBack).TabIndex = 6;
    ((Control) this.buttonBack).Text = "<< &Back";
    ((UltraControlBase) this.buttonBack).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonBack).Click += new EventHandler(this.buttonBack_Click);
    ((Control) this.buttonNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance11).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance11).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonNext).Appearance = (AppearanceBase) appearance11;
    ((Control) this.buttonNext).Location = new Point(457, 8);
    ((Control) this.buttonNext).Name = "buttonNext";
    ((Control) this.buttonNext).Size = new Size(88, 24);
    ((Control) this.buttonNext).TabIndex = 7;
    ((Control) this.buttonNext).Text = "&Next >>";
    ((UltraControlBase) this.buttonNext).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonNext).Click += new EventHandler(this.buttonNext_Click);
    ((Control) this.buttonFinish).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance12).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance12).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance12).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonFinish).Appearance = (AppearanceBase) appearance12;
    ((Control) this.buttonFinish).Enabled = false;
    ((Control) this.buttonFinish).Location = new Point(561, 8);
    ((Control) this.buttonFinish).Name = "buttonFinish";
    ((Control) this.buttonFinish).Size = new Size(88, 24);
    ((Control) this.buttonFinish).TabIndex = 4;
    ((Control) this.buttonFinish).Text = "&Finish";
    ((UltraControlBase) this.buttonFinish).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonFinish).Click += new EventHandler(this.buttonFinish_Click);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance13).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance13).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance13).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance13;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(657, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 24);
    ((Control) this.buttonCancel).TabIndex = 5;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 10f, FontStyle.Bold);
    this.label2.ForeColor = Color.Black;
    this.label2.Location = new Point(8, 56);
    this.label2.Name = "label2";
    this.label2.Size = new Size(186, 17);
    this.label2.TabIndex = 1;
    this.label2.Text = "Payable/Receivable Entity";
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 10f, FontStyle.Bold | FontStyle.Underline);
    this.label3.ForeColor = Color.Black;
    this.label3.Location = new Point(8, 8);
    this.label3.Name = "label3";
    this.label3.Size = new Size(166, 17);
    this.label3.TabIndex = 3;
    this.label3.Text = "Payable Search Criteria";
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Tahoma", 10f, FontStyle.Bold | FontStyle.Underline);
    this.label4.ForeColor = Color.Black;
    this.label4.Location = new Point(8, 8);
    this.label4.Name = "label4";
    this.label4.Size = new Size(185, 17);
    this.label4.TabIndex = 4;
    this.label4.Text = "Receivable Search Criteria";
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance14).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance14).Image = (object) Resources.SearchTransaction;
    ((AppearanceBase) appearance14).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance14).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearch).Appearance = (AppearanceBase) appearance14;
    ((Control) this.buttonSearch).Location = new Point(368, 78);
    ((Control) this.buttonSearch).Name = "buttonSearch";
    ((Control) this.buttonSearch).Size = new Size(22, 22);
    ((Control) this.buttonSearch).TabIndex = 5;
    ((UltraControlBase) this.buttonSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearch).Click += new EventHandler(this.buttonSearch_Click);
    ((AppearanceBase) appearance15).BorderColor = Color.White;
    this.optionPayables.Appearance = (AppearanceBase) appearance15;
    this.optionPayables.CheckedIndex = 0;
    valueListItem1.DataValue = (object) "CO";
    valueListItem1.DisplayText = "Control Number";
    valueListItem2.DataValue = (object) "PO";
    valueListItem2.DisplayText = "Policy Number";
    valueListItem3.DataValue = (object) "IN";
    valueListItem3.DisplayText = "Invoice Number";
    valueListItem4.DataValue = (object) "BP";
    valueListItem4.DisplayText = "Bordereau";
    valueListItem5.DataValue = (object) "PA";
    valueListItem5.DisplayText = "Payee Only";
    this.optionPayables.Items.AddRange(new ValueListItem[5]
    {
      valueListItem1,
      valueListItem2,
      valueListItem3,
      valueListItem4,
      valueListItem5
    });
    this.optionPayables.ItemSpacingVertical = 10;
    ((Control) this.optionPayables).Location = new Point(8, 56);
    ((Control) this.optionPayables).Name = "optionPayables";
    ((Control) this.optionPayables).Size = new Size(448, 38);
    ((Control) this.optionPayables).TabIndex = 6;
    ((Control) this.optionPayables).Tag = (object) "PAY";
    ((Control) this.optionPayables).Text = "Control Number";
    this.optionPayables.TextIndentation = 2;
    ((UltraControlBase) this.optionPayables).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionPayables).UseOsThemes = (DefaultableBoolean) 2;
    this.optionPayables.ValueChanged += new EventHandler(this.optionPayables_ValueChanged);
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPayablesCriteria).Appearance = (AppearanceBase) appearance16;
    ((Control) this.textPayablesCriteria).BackColor = Color.White;
    ((Control) this.textPayablesCriteria).Location = new Point(16 /*0x10*/, 120);
    this.textPayablesCriteria.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPayablesCriteria).Name = "textPayablesCriteria";
    ((Control) this.textPayablesCriteria).Size = new Size(344, 20);
    ((Control) this.textPayablesCriteria).TabIndex = 8;
    ((Control) this.textPayablesCriteria).Tag = (object) "PAY";
    ((UltraControlBase) this.textPayablesCriteria).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPayablesCriteria).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).BorderColor = Color.White;
    this.optionReceivables.Appearance = (AppearanceBase) appearance17;
    this.optionReceivables.CheckedIndex = 0;
    valueListItem6.CheckState = CheckState.Checked;
    valueListItem6.DataValue = (object) "CO";
    valueListItem6.DisplayText = "Control Number";
    valueListItem7.DataValue = (object) "PO";
    valueListItem7.DisplayText = "Policy Number";
    valueListItem8.DataValue = (object) "PL";
    valueListItem8.DisplayText = "Producer Location Code";
    valueListItem9.DataValue = (object) "IC";
    valueListItem9.DisplayText = "Insured Code";
    valueListItem10.DataValue = (object) "IN";
    valueListItem10.DisplayText = "Invoice Number";
    valueListItem11.DataValue = (object) "RM";
    valueListItem11.DisplayText = "Remitter Only";
    ((AppearanceBase) appearance18).FontData.SizeInPoints = 8.5f;
    ((AppearanceBase) appearance18).ForeColor = Color.DarkSlateGray;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Left";
    valueListItem12.Appearance = (AppearanceBase) appearance18;
    valueListItem12.DataValue = (object) "CNRO";
    valueListItem12.DisplayText = "Control Number - Remitter Only";
    ((AppearanceBase) appearance19).FontData.SizeInPoints = 8.5f;
    ((AppearanceBase) appearance19).ForeColor = Color.DarkSlateGray;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Left";
    valueListItem13.Appearance = (AppearanceBase) appearance19;
    valueListItem13.DataValue = (object) "PNRO";
    valueListItem13.DisplayText = "Policy Number - Remitter Only";
    this.optionReceivables.Items.AddRange(new ValueListItem[8]
    {
      valueListItem6,
      valueListItem7,
      valueListItem8,
      valueListItem9,
      valueListItem10,
      valueListItem11,
      valueListItem12,
      valueListItem13
    });
    this.optionReceivables.ItemSpacingHorizontal = 2;
    this.optionReceivables.ItemSpacingVertical = 5;
    ((Control) this.optionReceivables).Location = new Point(8, 40);
    ((Control) this.optionReceivables).Name = "optionReceivables";
    ((Control) this.optionReceivables).Size = new Size(540, 50);
    ((Control) this.optionReceivables).TabIndex = 9;
    ((Control) this.optionReceivables).Tag = (object) "REC";
    ((Control) this.optionReceivables).Text = "Control Number";
    this.optionReceivables.TextIndentation = 2;
    ((UltraControlBase) this.optionReceivables).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionReceivables).UseOsThemes = (DefaultableBoolean) 1;
    this.optionReceivables.ValueChanged += new EventHandler(this.optionReceivables_ValueChanged);
    ((AppearanceBase) appearance20).BackColor = Color.White;
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textReceivablesCriteria).Appearance = (AppearanceBase) appearance20;
    ((Control) this.textReceivablesCriteria).BackColor = Color.White;
    ((Control) this.textReceivablesCriteria).Location = new Point(8, 128 /*0x80*/);
    this.textReceivablesCriteria.MGAStyle = MGAStyles.Blue;
    ((Control) this.textReceivablesCriteria).Name = "textReceivablesCriteria";
    ((Control) this.textReceivablesCriteria).Size = new Size(530, 20);
    ((Control) this.textReceivablesCriteria).TabIndex = 11;
    ((Control) this.textReceivablesCriteria).Tag = (object) "REC";
    ((UltraControlBase) this.textReceivablesCriteria).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textReceivablesCriteria).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateBordereau.Appearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance22).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance22).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance22).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance22).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance22).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance22).ForegroundAlpha = (Alpha) 2;
    this.dateBordereau.ButtonAppearance = (AppearanceBase) appearance22;
    ((Control) this.dateBordereau).Location = new Point(16 /*0x10*/, 120);
    this.dateBordereau.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateBordereau).Name = "dateBordereau";
    ((Control) this.dateBordereau).Size = new Size(88, 20);
    ((Control) this.dateBordereau).TabIndex = 14;
    ((Control) this.dateBordereau).Tag = (object) "PAY";
    ((UltraControlBase) this.dateBordereau).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateBordereau).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.dateBordereau).Visible = false;
    this.panelStep1.Controls.Add((Control) this.comboOfficeLocations);
    this.panelStep1.Controls.Add((Control) this.label8);
    this.panelStep1.Controls.Add((Control) this.textEntityName);
    this.panelStep1.Controls.Add((Control) this.buttonSearch);
    this.panelStep1.Controls.Add((Control) this.label2);
    this.panelStep1.Controls.Add((Control) this.panelReceivableOptions);
    this.panelStep1.Controls.Add((Control) this.panelPayableOptions);
    this.panelStep1.Controls.Add((Control) this.panelPayablesReceivablesOptions);
    this.panelStep1.Dock = DockStyle.Fill;
    this.panelStep1.Location = new Point(0, 0);
    this.panelStep1.Name = "panelStep1";
    this.panelStep1.Size = new Size(569, 328);
    this.panelStep1.TabIndex = 15;
    this.comboOfficeLocations.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboOfficeLocations).DataMember = "spFin_GetOfficeLocations";
    ((UltraGridBase) this.comboOfficeLocations).DataSource = (object) this.dsOfficeLocations1;
    ((UltraDropDownBase) this.comboOfficeLocations).DisplayMember = "Office Location";
    this.comboOfficeLocations.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocations).Location = new Point(8, 24);
    this.comboOfficeLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocations).Name = "comboOfficeLocations";
    ((Control) this.comboOfficeLocations).Size = new Size(312, 21);
    ((Control) this.comboOfficeLocations).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.comboOfficeLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboOfficeLocations).ValueMember = "ID";
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.label8.AutoSize = true;
    this.label8.Font = new Font("Tahoma", 10f, FontStyle.Bold);
    this.label8.ForeColor = Color.Black;
    this.label8.Location = new Point(8, 8);
    this.label8.Name = "label8";
    this.label8.Size = new Size(110, 17);
    this.label8.TabIndex = 15;
    this.label8.Text = "Office Location";
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEntityName).Appearance = (AppearanceBase) appearance23;
    ((Control) this.textEntityName).BackColor = Color.White;
    ((Control) this.textEntityName).Location = new Point(8, 80 /*0x50*/);
    this.textEntityName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEntityName).Name = "textEntityName";
    ((EditorButtonControlBase) this.textEntityName).ReadOnly = true;
    ((Control) this.textEntityName).Size = new Size(360, 20);
    ((Control) this.textEntityName).TabIndex = 2;
    ((UltraControlBase) this.textEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEntityName).UseOsThemes = (DefaultableBoolean) 2;
    this.panelReceivableOptions.Controls.Add((Control) this.labelDirectBillOnly);
    this.panelReceivableOptions.Controls.Add((Control) this.checkShowZeroInvoices);
    this.panelReceivableOptions.Controls.Add((Control) this.optionReceivables);
    this.panelReceivableOptions.Controls.Add((Control) this.label4);
    this.panelReceivableOptions.Controls.Add((Control) this.textReceivablesCriteria);
    this.panelReceivableOptions.Location = new Point(8, 120);
    this.panelReceivableOptions.Name = "panelReceivableOptions";
    this.panelReceivableOptions.Size = new Size(550, 184);
    this.panelReceivableOptions.TabIndex = 17;
    this.panelReceivableOptions.VisibleChanged += new EventHandler(this.panelReceivableOptions_VisibleChanged);
    this.labelDirectBillOnly.AutoSize = true;
    this.labelDirectBillOnly.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.labelDirectBillOnly.ForeColor = Color.SteelBlue;
    this.labelDirectBillOnly.Location = new Point(310, 24);
    this.labelDirectBillOnly.Name = "labelDirectBillOnly";
    this.labelDirectBillOnly.Size = new Size(228, 13);
    this.labelDirectBillOnly.TabIndex = 13;
    this.labelDirectBillOnly.Text = "OPTION FOR DIRECT BILL INSURED ONLY";
    this.labelDirectBillOnly.Visible = false;
    this.checkShowZeroInvoices.FlatStyle = FlatStyle.Flat;
    this.checkShowZeroInvoices.Location = new Point(8, 160 /*0xA0*/);
    this.checkShowZeroInvoices.Name = "checkShowZeroInvoices";
    this.checkShowZeroInvoices.Size = new Size(144 /*0x90*/, 16 /*0x10*/);
    this.checkShowZeroInvoices.TabIndex = 12;
    this.checkShowZeroInvoices.Text = "Show Zero Invoices";
    this.panelPayableOptions.Controls.Add((Control) this.label3);
    this.panelPayableOptions.Controls.Add((Control) this.optionPayables);
    this.panelPayableOptions.Controls.Add((Control) this.dateBordereau);
    this.panelPayableOptions.Controls.Add((Control) this.textPayablesCriteria);
    this.panelPayableOptions.Location = new Point(8, 120);
    this.panelPayableOptions.Name = "panelPayableOptions";
    this.panelPayableOptions.Size = new Size(549, 184);
    this.panelPayableOptions.TabIndex = 18;
    this.panelPayableOptions.VisibleChanged += new EventHandler(this.panelPayableOptions_VisibleChanged);
    this.panelPayablesReceivablesOptions.Controls.Add((Control) this.label15);
    this.panelPayablesReceivablesOptions.Location = new Point(8, 120);
    this.panelPayablesReceivablesOptions.Name = "panelPayablesReceivablesOptions";
    this.panelPayablesReceivablesOptions.Size = new Size(550, 176 /*0xB0*/);
    this.panelPayablesReceivablesOptions.TabIndex = 19;
    this.panelPayablesReceivablesOptions.VisibleChanged += new EventHandler(this.panelPayablesReceivablesOptions_VisibleChanged);
    this.label15.Font = new Font("Tahoma", 10f);
    this.label15.Location = new Point(8, 16 /*0x10*/);
    this.label15.Name = "label15";
    this.label15.Size = new Size(539, 160 /*0xA0*/);
    this.label15.TabIndex = 0;
    this.label15.Text = "You have selected to search for both Accounts Payable and Accounts Receivable. Simply specify an entity and the system will find all open AP and AR for the specified entity.";
    this.label15.TextAlign = ContentAlignment.MiddleCenter;
    this.panelStep2.Controls.Add((Control) this.labelResultsType);
    this.panelStep2.Controls.Add((Control) this.gridResults);
    this.panelStep2.Controls.Add((Control) this.labelNoResults);
    this.panelStep2.Dock = DockStyle.Fill;
    this.panelStep2.Location = new Point(0, 0);
    this.panelStep2.Name = "panelStep2";
    this.panelStep2.Size = new Size(569, 328);
    this.panelStep2.TabIndex = 16 /*0x10*/;
    this.labelResultsType.AutoSize = true;
    this.labelResultsType.Font = new Font("Tahoma", 10f, FontStyle.Bold | FontStyle.Underline);
    this.labelResultsType.ForeColor = Color.Black;
    this.labelResultsType.Location = new Point(8, 8);
    this.labelResultsType.Name = "labelResultsType";
    this.labelResultsType.Size = new Size(115, 17);
    this.labelResultsType.TabIndex = 11;
    this.labelResultsType.Text = "Payable Results";
    ((Control) this.gridResults).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridResults).DataSource = (object) this.dsGetOpenReceivables1;
    ((AppearanceBase) appearance24).BackColor = Color.White;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridResults).DisplayLayout.Appearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridResults).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 121;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance26;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 195;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Left";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance28;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 195;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance29;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance30;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 158;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance31).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance31).ForeColor = Color.Black;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance32).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance33).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance34).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance36).BackColor = Color.Transparent;
    ((AppearanceBase) appearance36).ForeColor = Color.Black;
    ((UltraGridBase) this.gridResults).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance37).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.gridResults).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((AppearanceBase) appearance39).BackColor = Color.White;
    ((AppearanceBase) appearance39).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance39;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 72;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance40;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 1;
    ultraGridColumn6.Width = 197;
    ((AppearanceBase) appearance41).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance41;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Payee";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 2;
    ultraGridColumn7.Width = 194;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 3;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 80 /*0x50*/;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance42;
    ultraGridColumn9.Format = "c";
    ((AppearanceBase) appearance43).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance43;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Balance Due";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 4;
    ultraGridColumn9.Width = 157;
    ultraGridBand2.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "PayablesLayout";
    ((AppearanceBase) appearance44).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance44).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance44).ForeColor = Color.Black;
    ultraGridLayout1.Override.ActiveRowAppearance = (AppearanceBase) appearance44;
    ultraGridLayout1.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance45).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.CellAppearance = (AppearanceBase) appearance45;
    ultraGridLayout1.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance46).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout1.Override.HeaderAppearance = (AppearanceBase) appearance46;
    ultraGridLayout1.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance47).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout1.Override.RowAlternateAppearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance48;
    ultraGridLayout1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance49).BackColor = Color.Transparent;
    ((AppearanceBase) appearance49).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance49;
    ((AppearanceBase) appearance50).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance50).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance50;
    ((AppearanceBase) appearance51).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance51;
    ultraGridLayout1.ScrollBarLook = scrollBarLook2;
    ((AppearanceBase) appearance52).BackColor = Color.White;
    ((AppearanceBase) appearance52).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout2.Appearance = (AppearanceBase) appearance52;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 0;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 121;
    ((AppearanceBase) appearance53).TextHAlignAsString = "Left";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance53;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance54;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 1;
    ultraGridColumn11.Width = 195;
    ((AppearanceBase) appearance55).TextHAlignAsString = "Left";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance55;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance56;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 2;
    ultraGridColumn12.Width = 195;
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance57;
    ultraGridColumn13.Format = "c";
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance58;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 3;
    ultraGridColumn13.Width = 158;
    ultraGridBand3.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13
    });
    ultraGridBand3.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand3.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand3);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "ReceivablesLayout";
    ((AppearanceBase) appearance59).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance59).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance59).ForeColor = Color.Black;
    ultraGridLayout2.Override.ActiveRowAppearance = (AppearanceBase) appearance59;
    ultraGridLayout2.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance60).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.CellAppearance = (AppearanceBase) appearance60;
    ultraGridLayout2.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance61).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout2.Override.HeaderAppearance = (AppearanceBase) appearance61;
    ultraGridLayout2.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance62).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout2.Override.RowAlternateAppearance = (AppearanceBase) appearance62;
    ((AppearanceBase) appearance63).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance63;
    ultraGridLayout2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance64).BackColor = Color.Transparent;
    ((AppearanceBase) appearance64).ForeColor = Color.Black;
    ultraGridLayout2.Override.SelectedRowAppearance = (AppearanceBase) appearance64;
    ((AppearanceBase) appearance65).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance65).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance65;
    ((AppearanceBase) appearance66).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance66;
    ultraGridLayout2.ScrollBarLook = scrollBarLook3;
    ((UltraGridBase) this.gridResults).Layouts.Add(ultraGridLayout1);
    ((UltraGridBase) this.gridResults).Layouts.Add(ultraGridLayout2);
    ((Control) this.gridResults).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.gridResults).Name = "gridResults";
    ((Control) this.gridResults).Size = new Size(550, 296);
    ((Control) this.gridResults).TabIndex = 0;
    ((UltraControlBase) this.gridResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridResults).UseOsThemes = (DefaultableBoolean) 2;
    this.gridResults.DoubleClickRow += new DoubleClickRowEventHandler(this.gridResults_DoubleClickRow);
    this.dsGetOpenReceivables1.DataSetName = "dsGetOpenReceivables";
    this.dsGetOpenReceivables1.Locale = new CultureInfo("en-US");
    this.dsGetOpenReceivables1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.labelNoResults.Font = new Font("Tahoma", 9f);
    this.labelNoResults.Location = new Point(8, 32 /*0x20*/);
    this.labelNoResults.Name = "labelNoResults";
    this.labelNoResults.Size = new Size(553, 296);
    this.labelNoResults.TabIndex = 14;
    this.labelNoResults.Text = "No results found that match your search criteria.";
    this.labelNoResults.TextAlign = ContentAlignment.MiddleCenter;
    this.panelStep0.Controls.Add((Control) this.optionReceivablesOnly);
    this.panelStep0.Controls.Add((Control) this.optionPayablesReceivables);
    this.panelStep0.Controls.Add((Control) this.optionPayablesOnly);
    this.panelStep0.Controls.Add((Control) this.label12);
    this.panelStep0.Controls.Add((Control) this.label11);
    this.panelStep0.Controls.Add((Control) this.label10);
    this.panelStep0.Controls.Add((Control) this.label9);
    this.panelStep0.Dock = DockStyle.Fill;
    this.panelStep0.Location = new Point(0, 0);
    this.panelStep0.Name = "panelStep0";
    this.panelStep0.Size = new Size(569, 328);
    this.panelStep0.TabIndex = 17;
    this.optionReceivablesOnly.FlatStyle = FlatStyle.Flat;
    this.optionReceivablesOnly.Location = new Point(8, 224 /*0xE0*/);
    this.optionReceivablesOnly.Name = "optionReceivablesOnly";
    this.optionReceivablesOnly.Size = new Size(128 /*0x80*/, 24);
    this.optionReceivablesOnly.TabIndex = 6;
    this.optionReceivablesOnly.Text = "Accounts &Receivable";
    this.optionReceivablesOnly.CheckedChanged += new EventHandler(this.SearchTypeOptionChanged);
    this.optionPayablesReceivables.FlatStyle = FlatStyle.Flat;
    this.optionPayablesReceivables.Location = new Point(8, 256 /*0x0100*/);
    this.optionPayablesReceivables.Name = "optionPayablesReceivables";
    this.optionPayablesReceivables.Size = new Size(248, 24);
    this.optionPayablesReceivables.TabIndex = 5;
    this.optionPayablesReceivables.Text = "&Accounts Payable and Accounts Receivable";
    this.optionPayablesReceivables.CheckedChanged += new EventHandler(this.SearchTypeOptionChanged);
    this.optionPayablesOnly.Checked = true;
    this.optionPayablesOnly.FlatStyle = FlatStyle.Flat;
    this.optionPayablesOnly.Location = new Point(8, 192 /*0xC0*/);
    this.optionPayablesOnly.Name = "optionPayablesOnly";
    this.optionPayablesOnly.Size = new Size(128 /*0x80*/, 24);
    this.optionPayablesOnly.TabIndex = 4;
    this.optionPayablesOnly.TabStop = true;
    this.optionPayablesOnly.Text = "Accounts &Payable";
    this.optionPayablesOnly.CheckedChanged += new EventHandler(this.SearchTypeOptionChanged);
    this.label12.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label12.Location = new Point(8, 136);
    this.label12.Name = "label12";
    this.label12.Size = new Size(456, 48 /*0x30*/);
    this.label12.TabIndex = 3;
    this.label12.Text = "NOTE: When searching for accounts receivable and account payable you will only be presented with the option to specify an entity, no other search options will be available.";
    this.label11.Location = new Point(8, 96 /*0x60*/);
    this.label11.Name = "label11";
    this.label11.Size = new Size(464, 32 /*0x20*/);
    this.label11.TabIndex = 2;
    this.label11.Text = "The first step is to define what your are looking for. Select your search type from one of the 3 options below.";
    this.label10.AutoSize = true;
    this.label10.Font = new Font("Arial", 12f, FontStyle.Bold);
    this.label10.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label10.Location = new Point(8, 16 /*0x10*/);
    this.label10.Name = "label10";
    this.label10.Size = new Size(370, 19);
    this.label10.TabIndex = 1;
    this.label10.Text = "Welcome to the Open Transaction Search Utility";
    this.label9.Location = new Point(8, 48 /*0x30*/);
    this.label9.Name = "label9";
    this.label9.Size = new Size(464, 48 /*0x30*/);
    this.label9.TabIndex = 0;
    this.label9.Text = componentResourceManager.GetString("label9.Text");
    this.imageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList1.ImageStream");
    this.imageList1.TransparentColor = Color.Transparent;
    this.imageList1.Images.SetKeyName(0, "");
    this.panelContent.Controls.Add((Control) this.panelStep1);
    this.panelContent.Controls.Add((Control) this.panelStep0);
    this.panelContent.Controls.Add((Control) this.panelStep2);
    this.panelContent.Location = new Point(184, 88);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(569, 328);
    this.panelContent.TabIndex = 18;
    this.dsGetOpenPayables1.DataSetName = "dsGetOpenPayables";
    this.dsGetOpenPayables1.Locale = new CultureInfo("en-US");
    this.dsGetOpenPayables1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AcceptButton = (IButtonControl) this.buttonNext;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(753, 482);
    this.ControlBox = false;
    this.Controls.Add((Control) this.panelContent);
    this.Controls.Add((Control) this.panelLeft);
    this.Controls.Add((Control) this.panelTop);
    this.Controls.Add((Control) this.panelBottom);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (formTransactionSearch);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Find Open Transactions";
    this.Load += new EventHandler(this.formTransactionSearch_Load);
    this.Resize += new EventHandler(this.formTransactionSearch_Resize);
    this.panelTop.ResumeLayout(false);
    this.panelTop.PerformLayout();
    ((ISupportInitialize) this.picture1).EndInit();
    this.panelLeft.ResumeLayout(false);
    this.panelLeft.PerformLayout();
    this.panelBottom.ResumeLayout(false);
    this.panelBottom.PerformLayout();
    this.StatusStrip.ResumeLayout(false);
    this.StatusStrip.PerformLayout();
    ((ISupportInitialize) this.buttonBack).EndInit();
    ((ISupportInitialize) this.buttonNext).EndInit();
    ((ISupportInitialize) this.buttonFinish).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSearch).EndInit();
    ((ISupportInitialize) this.optionPayables).EndInit();
    ((ISupportInitialize) this.textPayablesCriteria).EndInit();
    ((ISupportInitialize) this.optionReceivables).EndInit();
    ((ISupportInitialize) this.textReceivablesCriteria).EndInit();
    ((ISupportInitialize) this.dateBordereau).EndInit();
    this.panelStep1.ResumeLayout(false);
    this.panelStep1.PerformLayout();
    ((ISupportInitialize) this.comboOfficeLocations).EndInit();
    this.dsOfficeLocations1.EndInit();
    ((ISupportInitialize) this.textEntityName).EndInit();
    this.panelReceivableOptions.ResumeLayout(false);
    this.panelReceivableOptions.PerformLayout();
    this.panelPayableOptions.ResumeLayout(false);
    this.panelPayableOptions.PerformLayout();
    this.panelPayablesReceivablesOptions.ResumeLayout(false);
    this.panelStep2.ResumeLayout(false);
    this.panelStep2.PerformLayout();
    ((ISupportInitialize) this.gridResults).EndInit();
    this.dsGetOpenReceivables1.EndInit();
    this.panelStep0.ResumeLayout(false);
    this.panelStep0.PerformLayout();
    this.panelContent.ResumeLayout(false);
    this.dsGetOpenPayables1.EndInit();
    this.ResumeLayout(false);
  }

  public Guid EntityGuid => this._entityGuid;

  public int GlCompanyId => int.Parse(this.comboOfficeLocations.Value.ToString());

  public string EntityName => ((Control) this.textEntityName).Text;

  public formTransactionSearch.SearchTypes SearchType => this._searchType;

  public int InvoiceNumber => this._invoiceNumber;

  public int ControlNumber => this._controlNumber;

  public string PolicyNumber => this._policyNumber;

  public DateTime Bordereaux => this._bordereaux;

  public Utility.PayablesSearchType PayablesSearch => this._payablesSearch;

  public Utility.ReceivablesSearchType ReceivablesSearch => this._receivablesSearch;

  public string ProducerLocationCode => this._producerLocationCode;

  public int InsuredCode => this._insuredCode;

  public bool ShowZeroInvoices
  {
    get
    {
      return this.checkShowZeroInvoices.Checked & this._searchType == formTransactionSearch.SearchTypes.Receivables;
    }
  }

  public bool IsAdditionalSearch => this._isAdditionalSearch;

  public SearchCriteria Criteria => this.BuildCriteria();

  protected formTransactionSearch.SearchTypes SearchType_Protected
  {
    get => this._searchType;
    set => this._searchType = value;
  }

  protected virtual void ToggleSearchMode()
  {
    ((Control) this.comboOfficeLocations).Enabled = false;
    this.optionPayablesReceivables.Enabled = false;
    this.optionPayablesOnly.Enabled = this._searchType == formTransactionSearch.SearchTypes.Payables;
    this.optionReceivablesOnly.Enabled = this._searchType == formTransactionSearch.SearchTypes.Receivables;
    for (int index = ((DisposableObjectCollectionBase) this.optionReceivables.Items).Count - 1; index >= 0; --index)
    {
      if (!(this.optionReceivables.Items[index].DataValue.ToString() == "CO") && !(this.optionReceivables.Items[index].DataValue.ToString() == "IN") && !(this.optionReceivables.Items[index].DataValue.ToString() == "PO"))
        this.optionReceivables.Items.RemoveAt(index);
    }
    for (int index = ((DisposableObjectCollectionBase) this.optionPayables.Items).Count - 1; index >= 0; --index)
    {
      if (!(this.optionPayables.Items[index].DataValue.ToString() == "CO") && !(this.optionPayables.Items[index].DataValue.ToString() == "IN") && !(this.optionPayables.Items[index].DataValue.ToString() == "PO"))
        this.optionPayables.Items.RemoveAt(index);
    }
  }

  private SearchCriteria BuildCriteria()
  {
    SearchCriteria searchCriteria = new SearchCriteria();
    searchCriteria.SearchForGuid = this.EntityGuid;
    searchCriteria.ShowZeros = this.ShowZeroInvoices;
    if (this.SearchType == formTransactionSearch.SearchTypes.PayablesReceivables && !this.EntityGuid.Equals(Guid.Empty))
    {
      searchCriteria.PayableSearchType = Utility.PayablesSearchType.Payee;
      searchCriteria.ReceivableSearchType = Utility.ReceivablesSearchType.Remitter;
      return searchCriteria;
    }
    switch (this.SearchType)
    {
      case formTransactionSearch.SearchTypes.Payables:
        searchCriteria.ReceivableSearchType = Utility.ReceivablesSearchType.None;
        searchCriteria.PayableSearchType = this.PayablesSearch;
        switch (this.PayablesSearch)
        {
          case Utility.PayablesSearchType.ControlNumber:
            searchCriteria.SearchForInteger = this.ControlNumber;
            break;
          case Utility.PayablesSearchType.InvoiceNumber:
            searchCriteria.SearchForInteger = this.InvoiceNumber;
            break;
          case Utility.PayablesSearchType.PolicyNumber:
            searchCriteria.SearchForString = this.PolicyNumber;
            break;
          case Utility.PayablesSearchType.Bordereau:
          case Utility.PayablesSearchType.BordereauPayee:
            searchCriteria.SearchForDate = this.Bordereaux;
            break;
          case Utility.PayablesSearchType.Payee:
            searchCriteria.PayeeName = this.EntityName;
            break;
          default:
            throw new SearchTypeNotDefinedException("Can not create a SearchCriteria object. No search type has been defined.");
        }
        break;
      case formTransactionSearch.SearchTypes.Receivables:
        searchCriteria.PayableSearchType = Utility.PayablesSearchType.None;
        searchCriteria.ReceivableSearchType = this.ReceivablesSearch;
        switch (this.ReceivablesSearch)
        {
          case Utility.ReceivablesSearchType.ControlNumber:
            searchCriteria.SearchForInteger = this.ControlNumber;
            break;
          case Utility.ReceivablesSearchType.InsuredCode:
            searchCriteria.SearchForInteger = this.InsuredCode;
            break;
          case Utility.ReceivablesSearchType.InvoiceNumber:
            searchCriteria.SearchForInteger = this.InvoiceNumber;
            break;
          case Utility.ReceivablesSearchType.PolicyNumber:
            searchCriteria.SearchForString = this.PolicyNumber;
            break;
          case Utility.ReceivablesSearchType.ProducerLocationCode:
            searchCriteria.SearchForString = this.ProducerLocationCode;
            break;
          case Utility.ReceivablesSearchType.Remitter:
            break;
          default:
            throw new SearchTypeNotDefinedException("Can not create a SearchCriteria object. No search type has been defined.");
        }
        break;
      default:
        throw new SearchTypeNotDefinedException("Can not create a SearchCriteria object. No search type has been defined.");
    }
    return searchCriteria;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void buttonFinish_Click(object sender, EventArgs e)
  {
    ((ControlBase) this.labelStep3).Appearance.Image = (object) this.imageList1.Images[0];
    if (!this.VerifyFinish())
      return;
    this.Finish();
  }

  private void buttonNext_Click(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    ++this._currentWizardStep;
    this.ChangeStep();
  }

  private void SearchTypeOptionChanged(object sender, EventArgs e)
  {
    if (this.optionPayablesOnly.Checked)
      this._searchType = formTransactionSearch.SearchTypes.Payables;
    else if (this.optionReceivablesOnly.Checked)
      this._searchType = formTransactionSearch.SearchTypes.Receivables;
    else if (this.optionPayablesReceivables.Checked)
      this._searchType = formTransactionSearch.SearchTypes.PayablesReceivables;
    ((Control) this.buttonNext).Focus();
  }

  private void buttonBack_Click(object sender, EventArgs e)
  {
    --this._currentWizardStep;
    this.ChangeStep();
  }

  private void ChangeStep()
  {
    ((Control) this.buttonNext).Enabled = this._currentWizardStep != 2;
    ((Control) this.buttonBack).Enabled = this._currentWizardStep != 0;
    ((Control) this.buttonFinish).Enabled = this._currentWizardStep == 2;
    this.AcceptButton = this._currentWizardStep == 2 ? (IButtonControl) this.buttonFinish : (IButtonControl) this.buttonNext;
    this.StatusStrip.Visible = false;
    switch (this._currentWizardStep)
    {
      case 0:
        ((ControlBase) this.labelStep1).Appearance.Image = (object) null;
        ((ControlBase) this.labelStep2).Appearance.Image = (object) null;
        ((ControlBase) this.labelStep3).Appearance.Image = (object) null;
        this.panelStep0.BringToFront();
        break;
      case 1:
        ((TextEditorControlBase) this.textPayablesCriteria).Focus();
        ((ControlBase) this.labelStep1).Appearance.Image = (object) this.imageList1.Images[0];
        ((ControlBase) this.labelStep2).Appearance.Image = (object) null;
        ((ControlBase) this.labelStep3).Appearance.Image = (object) null;
        this.panelPayableOptions.Visible = this.optionPayablesOnly.Checked;
        this.panelReceivableOptions.Visible = this.optionReceivablesOnly.Checked;
        this.panelPayablesReceivablesOptions.Visible = this.optionPayablesReceivables.Checked;
        if (this.panelPayableOptions.Visible)
          ((TextEditorControlBase) this.textPayablesCriteria).Focus();
        if (this.panelReceivableOptions.Visible)
          ((TextEditorControlBase) this.textReceivablesCriteria).Focus();
        if (this.panelPayablesReceivablesOptions.Visible)
          ((Control) this.buttonSearch).Focus();
        this.panelStep1.BringToFront();
        break;
      case 2:
        if (this._searchType == formTransactionSearch.SearchTypes.Payables)
        {
          this.FindOpenPayables();
          ((Control) this.buttonFinish).Enabled = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridResults).Rows).Count != 0;
        }
        if (this._searchType == formTransactionSearch.SearchTypes.Receivables)
        {
          this.FindOpenReceivables();
          ((Control) this.buttonFinish).Enabled = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridResults).Rows).Count != 0;
          if (this.optionReceivables.Value.ToString() == "IC" && ((Control) this.buttonFinish).Enabled)
          {
            this.Finish();
            break;
          }
        }
        ((ControlBase) this.labelStep1).Appearance.Image = (object) this.imageList1.Images[0];
        ((ControlBase) this.labelStep2).Appearance.Image = (object) this.imageList1.Images[0];
        this.panelStep2.BringToFront();
        this.Refresh();
        break;
    }
  }

  private void buttonSearch_Click(object sender, EventArgs e)
  {
    using (FormSearchEntity objectAs = ObjectFactory.Instance.CreateObjectAs<FormSearchEntity>((object) Utility.SearchEntityTypes.All))
    {
      if (objectAs.ShowDialog() != DialogResult.OK)
        return;
      this._entityGuid = objectAs.EntityGuid;
      ((Control) this.textEntityName).Text = objectAs.EntityName;
    }
  }

  private void optionPayables_ValueChanged(object sender, EventArgs e)
  {
    ((Control) this.textPayablesCriteria).Visible = this.optionPayables.Value.ToString() != "BP";
    ((Control) this.dateBordereau).Visible = !((Control) this.textPayablesCriteria).Visible;
    if (((Control) this.textPayablesCriteria).Visible)
      ((TextEditorControlBase) this.textPayablesCriteria).Focus();
    else
      ((Control) this.dateBordereau).Focus();
  }

  private bool VerifyForm()
  {
    switch (this._currentWizardStep)
    {
      case 0:
        return true;
      case 1:
        if (((UltraDropDownBase) this.comboOfficeLocations).SelectedRow != null)
          return this.VerifyOptions();
        int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      case 2:
        return this.VerifyFinish();
      default:
        return false;
    }
  }

  private bool VerifyOptions()
  {
    if (this._searchType == formTransactionSearch.SearchTypes.PayablesReceivables && !this._entityGuid.Equals(Guid.Empty))
    {
      this.Finish();
      return false;
    }
    if (this._searchType == formTransactionSearch.SearchTypes.PayablesReceivables && this._entityGuid.Equals(Guid.Empty))
    {
      int num = (int) MessageBox.Show("You must specify an entity to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this._searchType == formTransactionSearch.SearchTypes.Payables)
      return this.VerifyPayableOptions();
    return this._searchType == formTransactionSearch.SearchTypes.Receivables && this.VerifyReceivableOptions();
  }

  private bool VerifyReceivableOptions()
  {
    this.labelResultsType.Text = "Receivables Results";
    string str = this.optionReceivables.Value.ToString();
    if (str != null)
    {
      switch (str.Length)
      {
        case 2:
          switch (str[1])
          {
            case 'C':
              if (str == "IC")
              {
                if (!((Control) this.textReceivablesCriteria).Text.Equals(string.Empty) && Utility.IsNumericValue((object) ((Control) this.textReceivablesCriteria).Text))
                  return true;
                int num = (int) MessageBox.Show("You must specify a valid insured code to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
              }
              break;
            case 'L':
              if (str == "PL")
              {
                if (!((Control) this.textReceivablesCriteria).Text.Equals(string.Empty))
                  return true;
                int num = (int) MessageBox.Show("You must enter a producer location code to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
              }
              break;
            case 'M':
              if (str == "RM")
              {
                if (this.EntityGuid.Equals(Guid.Empty))
                {
                  int num = (int) MessageBox.Show("You must select an entity to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return false;
                }
                this._receivablesSearch = Utility.ReceivablesSearchType.Remitter;
                this.DialogResult = DialogResult.OK;
                this.Close();
                return false;
              }
              break;
            case 'N':
              if (str == "IN")
              {
                if (!((Control) this.textReceivablesCriteria).Text.Equals(string.Empty) && Utility.IsNumericValue((object) ((Control) this.textReceivablesCriteria).Text))
                  return true;
                int num = (int) MessageBox.Show("The invoice number entered is invalid, please enter a valid invoice number to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
              }
              break;
            case 'O':
              switch (str)
              {
                case "CO":
                  if (!((Control) this.textReceivablesCriteria).Text.Equals(string.Empty) && Utility.IsNumericValue((object) ((Control) this.textReceivablesCriteria).Text))
                    return true;
                  int num1 = (int) MessageBox.Show("The control number entered is invalid, please enter a valid control number to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return false;
                case "PO":
                  if (!((Control) this.textReceivablesCriteria).Text.Equals(string.Empty))
                    return true;
                  int num2 = (int) MessageBox.Show("You must enter a valid policy number to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return false;
              }
              break;
          }
          break;
        case 4:
          switch (str[0])
          {
            case 'C':
              if (str == "CNRO")
              {
                if (((Control) this.textReceivablesCriteria).Text.Equals(string.Empty))
                {
                  int num3 = (int) MessageBox.Show("You must enter a control number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return false;
                }
                this._entityGuid = Utility.GetDirectBillInsuredRemitterGUID(int.Parse(((Control) this.textReceivablesCriteria).Text), string.Empty);
                if (this._entityGuid.Equals(Guid.Empty))
                {
                  int num4 = (int) MessageBox.Show("An insured remitter identifier for this control number could not be determined. This search option is only available for direct bill insured policies.", "Entity Could Not Be Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return false;
                }
                ((Control) this.textEntityName).Text = Utility.GetEntityName(this._entityGuid);
                this._receivablesSearch = Utility.ReceivablesSearchType.Remitter;
                this.DialogResult = DialogResult.OK;
                this.Close();
                return false;
              }
              break;
            case 'P':
              if (str == "PNRO")
              {
                if (((Control) this.textReceivablesCriteria).Text.Equals(string.Empty))
                {
                  int num5 = (int) MessageBox.Show("You must enter a policy number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return false;
                }
                this._entityGuid = Utility.GetDirectBillInsuredRemitterGUID(policyNumber: ((Control) this.textReceivablesCriteria).Text);
                if (this._entityGuid.Equals(Guid.Empty))
                {
                  int num6 = (int) MessageBox.Show("An insured remitter identifier for this control number could not be determined. This search option is only available for direct bill insured policies.", "Entity Could Not Be Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  return false;
                }
                ((Control) this.textEntityName).Text = Utility.GetEntityName(this._entityGuid);
                this._receivablesSearch = Utility.ReceivablesSearchType.Remitter;
                this.DialogResult = DialogResult.OK;
                this.Close();
                return false;
              }
              break;
          }
          break;
      }
    }
    return false;
  }

  private bool VerifyPayableOptions()
  {
    this.labelResultsType.Text = "Payables Results";
    switch (this.optionPayables.Value.ToString())
    {
      case "BP":
        if (this.dateBordereau.Value != null)
        {
          if (this.EntityGuid.Equals(Guid.Empty))
            return true;
          this._payablesSearch = Utility.PayablesSearchType.BordereauPayee;
          this._bordereaux = this.dateBordereau.DateTime;
          this.DialogResult = DialogResult.OK;
          this.Close();
          return false;
        }
        int num1 = (int) MessageBox.Show("You must select a bordereau date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      case "IN":
        if (!((Control) this.textPayablesCriteria).Text.Equals(string.Empty) && Utility.IsNumericValue((object) ((Control) this.textPayablesCriteria).Text))
          return true;
        int num2 = (int) MessageBox.Show("The invoice number entered is invalid, please enter a valid invoice number to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      case "CO":
        if (!((Control) this.textPayablesCriteria).Text.Equals(string.Empty) && Utility.IsNumericValue((object) ((Control) this.textPayablesCriteria).Text))
          return true;
        int num3 = (int) MessageBox.Show("The control number entered is invalid, please enter a valid control number to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      case "PO":
        if (!((Control) this.textPayablesCriteria).Text.Equals(string.Empty))
          return true;
        int num4 = (int) MessageBox.Show("You must enter a valid policy number to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      case "PA":
        if (this.EntityGuid.Equals(Guid.Empty))
        {
          int num5 = (int) MessageBox.Show("You must select an entity to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        }
        this._payablesSearch = Utility.PayablesSearchType.Payee;
        this.DialogResult = DialogResult.OK;
        this.Close();
        return false;
      default:
        return false;
    }
  }

  private bool VerifyFinish()
  {
    if (this._searchType != formTransactionSearch.SearchTypes.Payables && this._searchType != formTransactionSearch.SearchTypes.Receivables || this._receivablesSearch == Utility.ReceivablesSearchType.Remitter || this._payablesSearch == Utility.PayablesSearchType.Payee || this._payablesSearch == Utility.PayablesSearchType.Bordereau || this._payablesSearch == Utility.PayablesSearchType.BordereauPayee || ((SparseCollectionBase) this.gridResults.Selected.Rows).Count != 0)
      return true;
    int num = (int) MessageBox.Show("You must select a result to continue.", "Result Selection Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocations).DataSource = (object) Methods.GetOfficeLocationDataset();
    this.comboOfficeLocations.SelectedIndex = 0;
  }

  private void FindOpenPayables()
  {
    List<object> objectList = new List<object>()
    {
      (object) "@GLCompanyId",
      (object) (int) this.comboOfficeLocations.Value
    };
    if (this.EntityGuid != Guid.Empty)
    {
      objectList.Add((object) "@EntityGuid");
      objectList.Add((object) this.EntityGuid);
    }
    if (this.optionPayables.Value is string str)
    {
      switch (str)
      {
        case "BP":
          objectList.Add((object) "@Bordereaux");
          objectList.Add((object) this.dateBordereau.DateTime);
          break;
        case "IN":
          objectList.Add((object) "@InvoiceNumber");
          objectList.Add((object) int.Parse(((Control) this.textPayablesCriteria).Text));
          break;
        case "CO":
          objectList.Add((object) "@ControlNumber");
          objectList.Add((object) int.Parse(((Control) this.textPayablesCriteria).Text));
          break;
        case "PO":
          objectList.Add((object) "@PolicyNumber");
          objectList.Add((object) ((Control) this.textPayablesCriteria).Text.Trim());
          break;
      }
    }
    this.dsGetOpenPayables1.Clear();
    try
    {
      this.Cursor = Cursors.WaitCursor;
      DefaultDatabase.LoadDataTable((DataTable) this.dsGetOpenPayables1.OpenPayables, "spFin_GetOpenPayables", objectList.ToArray());
      ((UltraGridBase) this.gridResults).DataSource = (object) this.dsGetOpenPayables1.OpenPayables;
      ((UltraGridBase) this.gridResults).DisplayLayout.Load(((UltraGridBase) this.gridResults).Layouts["PayablesLayout"], (PropertyCategories) -1);
      this.labelNoResults.Visible = this.dsGetOpenPayables1.OpenPayables.Count == 0;
      if (this.dsGetOpenPayables1.OpenPayables.Count > 0)
      {
        ((GridItemBase) ((UltraGridBase) this.gridResults).Rows[0]).Selected = true;
        ((UltraGridBase) this.gridResults).Rows[0].Activate();
      }
      if (this.dsGetOpenPayables1.OpenPayables.Count != this._maxRows)
        return;
      this.StatusStrip.Visible = true;
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void FindOpenReceivables()
  {
    List<object> objectList = new List<object>()
    {
      (object) "@GLCompanyId",
      (object) (int) this.comboOfficeLocations.Value
    };
    if (this.EntityGuid != Guid.Empty)
    {
      objectList.Add((object) "@RemitterGuid");
      objectList.Add((object) this.EntityGuid);
    }
    if (this.optionReceivables.Value is string str)
    {
      switch (str)
      {
        case "PL":
          objectList.Add((object) "@ProducerLocationCode");
          objectList.Add((object) ((Control) this.textReceivablesCriteria).Text);
          break;
        case "IC":
          objectList.Add((object) "@InsuredCode");
          objectList.Add((object) ((Control) this.textReceivablesCriteria).Text);
          break;
        case "IN":
          objectList.Add((object) "@InvoiceNumber");
          objectList.Add((object) int.Parse(((Control) this.textReceivablesCriteria).Text));
          break;
        case "CO":
          objectList.Add((object) "@ControlNumber");
          objectList.Add((object) int.Parse(((Control) this.textReceivablesCriteria).Text));
          break;
        case "PO":
          objectList.Add((object) "@PolicyNumber");
          objectList.Add((object) ((Control) this.textReceivablesCriteria).Text.Trim());
          break;
      }
    }
    if (this.checkShowZeroInvoices.Checked)
    {
      objectList.Add((object) "@ShowZeros");
      objectList.Add((object) 1);
    }
    this.dsGetOpenReceivables1.Clear();
    try
    {
      this.Cursor = Cursors.WaitCursor;
      DefaultDatabase.LoadDataTable((DataTable) this.dsGetOpenReceivables1.OpenReceivables, "spFin_GetOpenReceivables", objectList.ToArray());
      ((UltraGridBase) this.gridResults).DataSource = (object) this.dsGetOpenReceivables1.OpenReceivables;
      ((UltraGridBase) this.gridResults).DisplayLayout.Load(((UltraGridBase) this.gridResults).Layouts["ReceivablesLayout"], (PropertyCategories) -1);
      this.labelNoResults.Visible = this.dsGetOpenReceivables1.OpenReceivables.Count == 0;
      if (this.dsGetOpenReceivables1.OpenReceivables.Count > 0)
      {
        ((GridItemBase) ((UltraGridBase) this.gridResults).Rows[0]).Selected = true;
        ((UltraGridBase) this.gridResults).Rows[0].Activate();
      }
      if (this.dsGetOpenReceivables1.OpenReceivables.Count != this._maxRows)
        return;
      this.StatusStrip.Visible = true;
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void Finish()
  {
    switch (this._searchType)
    {
      case formTransactionSearch.SearchTypes.Payables:
        switch (this.optionPayables.Value.ToString())
        {
          case "BP":
            this._payablesSearch = Utility.PayablesSearchType.BordereauPayee;
            this._bordereaux = this.dateBordereau.DateTime;
            break;
          case "IN":
            this._payablesSearch = Utility.PayablesSearchType.InvoiceNumber;
            this._invoiceNumber = int.Parse(((Control) this.textPayablesCriteria).Text);
            break;
          case "CO":
            this._payablesSearch = Utility.PayablesSearchType.ControlNumber;
            this._controlNumber = int.Parse(((Control) this.textPayablesCriteria).Text);
            break;
          case "PO":
            this._payablesSearch = Utility.PayablesSearchType.PolicyNumber;
            this._policyNumber = this.gridResults.Selected.Rows[0].Cells["PolicyNumber"].Value.ToString();
            break;
        }
        this._entityGuid = new Guid(this.gridResults.Selected.Rows[0].Cells["PayeeGuid"].Value.ToString());
        ((Control) this.textEntityName).Text = this.gridResults.Selected.Rows[0].Cells["EntityName"].Value.ToString();
        this._receivablesSearch = Utility.ReceivablesSearchType.None;
        break;
      case formTransactionSearch.SearchTypes.Receivables:
        string str = this.optionReceivables.Value.ToString();
        if (str != null)
        {
          switch (str.Length)
          {
            case 2:
              switch (str[1])
              {
                case 'C':
                  if (str == "IC")
                  {
                    this._receivablesSearch = Utility.ReceivablesSearchType.InsuredCode;
                    this._entityGuid = Utility.GetInsuredFromCode(int.Parse(((Control) this.textReceivablesCriteria).Text));
                    this._insuredCode = int.Parse(((Control) this.textReceivablesCriteria).Text);
                    break;
                  }
                  break;
                case 'L':
                  if (str == "PL")
                  {
                    this._receivablesSearch = Utility.ReceivablesSearchType.ProducerLocationCode;
                    this._producerLocationCode = ((Control) this.textReceivablesCriteria).Text;
                    break;
                  }
                  break;
                case 'N':
                  if (str == "IN")
                  {
                    this._receivablesSearch = Utility.ReceivablesSearchType.InvoiceNumber;
                    this._invoiceNumber = int.Parse(((Control) this.textReceivablesCriteria).Text);
                    break;
                  }
                  break;
                case 'O':
                  switch (str)
                  {
                    case "CO":
                      this._receivablesSearch = Utility.ReceivablesSearchType.ControlNumber;
                      this._controlNumber = int.Parse(((Control) this.textReceivablesCriteria).Text);
                      break;
                    case "PO":
                      this._receivablesSearch = Utility.ReceivablesSearchType.PolicyNumber;
                      this._policyNumber = this.gridResults.Selected.Rows[0].Cells["PolicyNumber"].Value.ToString();
                      break;
                  }
                  break;
              }
              break;
            case 4:
              switch (str[0])
              {
                case 'C':
                  if (str == "CNRO")
                  {
                    this._receivablesSearch = Utility.ReceivablesSearchType.Remitter;
                    this._entityGuid = Utility.GetDirectBillInsuredRemitterGUID(int.Parse(((Control) this.textReceivablesCriteria).Text), string.Empty);
                    break;
                  }
                  break;
                case 'P':
                  if (str == "PNRO")
                  {
                    this._receivablesSearch = Utility.ReceivablesSearchType.Remitter;
                    this._entityGuid = Utility.GetDirectBillInsuredRemitterGUID(policyNumber: ((Control) this.textReceivablesCriteria).Text);
                    break;
                  }
                  break;
              }
              break;
          }
        }
        this._entityGuid = new Guid(this.gridResults.Selected.Rows[0].Cells["RemitterGuid"].Value.ToString());
        ((Control) this.textEntityName).Text = this.gridResults.Selected.Rows[0].Cells["Remitter"].Value.ToString();
        this._payablesSearch = Utility.PayablesSearchType.None;
        break;
      case formTransactionSearch.SearchTypes.PayablesReceivables:
        this._payablesSearch = Utility.PayablesSearchType.Payee;
        this._receivablesSearch = Utility.ReceivablesSearchType.Remitter;
        break;
      default:
        return;
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void optionReceivables_ValueChanged(object sender, EventArgs e)
  {
    string str = this.optionReceivables.Value.ToString();
    if (str == "RM" || str == "PL" || str == "IC")
    {
      this.checkShowZeroInvoices.Checked = false;
      this.checkShowZeroInvoices.Enabled = false;
    }
    else
      this.checkShowZeroInvoices.Enabled = true;
    this.labelDirectBillOnly.Visible = this.optionReceivables.Value.ToString() == "PNRO" || this.optionReceivables.Value.ToString() == "CNRO";
    ((TextEditorControlBase) this.textReceivablesCriteria).Focus();
  }

  private void formTransactionSearch_Resize(object sender, EventArgs e) => this.Refresh();

  private void gridResults_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    if (!this.VerifyFinish())
      return;
    this.Finish();
  }

  private void panelPayableOptions_VisibleChanged(object sender, EventArgs e)
  {
    if (!this.panelPayableOptions.Visible)
      return;
    ((TextEditorControlBase) this.textPayablesCriteria).Focus();
  }

  private void panelReceivableOptions_VisibleChanged(object sender, EventArgs e)
  {
    if (!this.panelReceivableOptions.Visible)
      return;
    ((TextEditorControlBase) this.textReceivablesCriteria).Focus();
  }

  private void panelPayablesReceivablesOptions_VisibleChanged(object sender, EventArgs e)
  {
    if (!this.panelPayablesReceivablesOptions.Visible)
      return;
    ((Control) this.buttonSearch).Focus();
  }

  private void formTransactionSearch_Load(object sender, EventArgs e)
  {
    this._maxRows = MGASystems.Common.Settings.SystemSettings.GetSetting<int>("TransactionBuilderSearchMaxRowsReturned", 1000);
    this.ToolStripStatusLabel.Text = $"The results have been limited to {this._maxRows} rows. Please narrow your search if you can not see what you were searching for.";
    if (this.DesignMode)
      return;
    this.LoadOfficeLocations();
    if (!this._glCompanyId.HasValue)
      return;
    this.comboOfficeLocations.Value = (object) this._glCompanyId.Value;
  }

  public enum SearchTypes
  {
    Payables,
    Receivables,
    PayablesReceivables,
    None,
  }
}
