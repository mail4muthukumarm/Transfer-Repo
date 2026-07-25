// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormFilingInformation
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
[SecureResource("{E7F7140D-24A2-40d9-868A-2E96EDA83E7E}", "View Filing Management Information", "Controls the ability for the user to view Filing Management Information.", "Filing Management")]
[SecureResource("{3C09B8C9-FD5D-4b22-A124-D395E38BF4D1}", "Edit Filing Management Information", "Controls the ability to edit Filing Management Information.", "Filing Management")]
public class FormFilingInformation : Form, ISupportNoteSystem
{
  private IContainer components;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private ErrorProvider err;
  private DbCommand SqlDeleteCommand;
  private DbCommand SqlInsertCommand;
  private DbCommand SqlUpdateCommand;
  private Label Label21;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private Label lblPayeeName;
  private Label Label3;
  private Label Label14;
  private Label Label4;
  private Label Label22;
  private Label Label1;
  private Label lblAffidavitNumber;
  private Label lblFilingProducer;
  private Label lblPremium;
  private Label lblLicenseNumber;
  private Label lblLOB;
  private Label Label30;
  private Label lblInvoiceNum;
  private Label Label29;
  private Label lblTransType;
  private Label Label31;
  private Label lblStatePremium;
  private Label Label32;
  private Label lblControlNo;
  private Label Label28;
  private Label lblStateTIV;
  private Label lblPolicyTIV;
  private Label Label34;
  private Label Label33;
  private Label Label38;
  private Label lblInsured;
  private Label Label39;
  private Label Label2;
  private Label lblState;
  private Label Label9;
  private GroupBox GroupBox1;
  private Label Label11;
  private Label Label15;
  private const int _INVALIDVALUE = -2147483648 /*0x80000000*/;
  private int _ID;
  protected string _guidsToString;
  private const string _gridLayoutName = "FilingManagementGrid";
  private const string _formHeight = "FilingManagementHeight";
  private const string _formWidth = "FilingManagementWidth";
  private bool _defaultAllIssuingLocations;
  private Quote _activeQuote;
  protected DataTable _dtHiddenCols;
  public const string CanViewFilingInformation = "{E7F7140D-24A2-40d9-868A-2E96EDA83E7E}";
  public const string CanEditFilingInformation = "{3C09B8C9-FD5D-4b22-A124-D395E38BF4D1}";
  private MemoryStream _gridlayout;
  private Dictionary<int, FormFilingInformation.QuoteStructure> _quoteDic;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormFilingInformation));
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblFin_PolicyCharges", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("StateID");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
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
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance38 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance39 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance40 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("PolicyFilingInformation", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("AffidavitNumber");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("FilingProducer");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Premium");
    Appearance appearance44 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DateAmountDue");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("DateFilingDue");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("OptionFeeID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("TaxDue");
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("FeesDue");
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("TransactionType");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("TransactionEffective");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Rate");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("PayeeName");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("IsCheckRequestDate");
    Appearance appearance49 = new Appearance();
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("TransactionDate");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("Paid");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("StatePremium");
    Appearance appearance50 = new Appearance();
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Carrier");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("PolicyTIV");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("StateTIV");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Filed");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("DecPageFiledDate");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("DSFFillDate");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("ControlsFiledDate");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("MonthlyReportDue");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("QuarterlyReportDue");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("SemiAnnualReportDue");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("AnnualReportDue");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("FilingDone");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("FireTaxDue");
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("MunicipalFilingDue");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("RevenueSurchargeDue");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("DatePaid");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("Underwriter");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("DateFiled");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("TaxableFee");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("OffSet", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("TaxableFeesAmount");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("TotalPremium");
    Appearance appearance51 = new Appearance();
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("PolicyStatus");
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "TaxDue", 11, true, "PolicyFilingInformation", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "FeesDue", 12, true, "PolicyFilingInformation", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 1, (string) null, "StatePremium", 21, true, "PolicyFilingInformation", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 1, (string) null, "TaxableFeesAmount", 44, true, "PolicyFilingInformation", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    this.tabSearch = new UltraTabPageControl();
    this.btnAggregateReport = new MGAButton();
    this.GroupBox3 = new GroupBox();
    this.chkHidePolicyStatus = new MGACheckBox();
    this.chkHideAffidavitNumber = new MGACheckBox();
    this.chkHideInsured = new MGACheckBox();
    this.chkHideUnderwriter = new MGACheckBox();
    this.chkHideTransactionType = new MGACheckBox();
    this.chkHideFeeColumn = new MGACheckBox();
    this.chkHideCarrierColumn = new MGACheckBox();
    this.chkHidePolicyNumberColumn = new MGACheckBox();
    this.btnExcelExport = new MGAButton();
    this.chkDateFiledNULL = new MGACheckBox();
    this.GroupBox2 = new GroupBox();
    this.dtpRevenueDateFrom = new MGADateTimePicker();
    this.dtpReveneDateTo = new MGADateTimePicker();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.chkHideOffsets = new MGACheckBox();
    this.chkTaxableFee = new MGACheckBox();
    this.GroupBox1 = new GroupBox();
    this.dtpPolicyEffFrom = new MGADateTimePicker();
    this.dtpPolEffectiveTo = new MGADateTimePicker();
    this.Label11 = new Label();
    this.Label15 = new Label();
    this.Label2 = new Label();
    this.lstIssuingOffices = new MGACheckedListBox();
    this.txtFilingProducer = new MGATextBox();
    this.Label38 = new Label();
    this.grpFee = new GroupBox();
    this.rbNotPaid = new RadioButton();
    this.rbBoth = new RadioButton();
    this.rbPaid = new RadioButton();
    this.lnkClearSearch = new LinkLabel();
    this.Label6 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.cboChargeName = new MGAComboBox();
    this.ds = new dsFilingPolicyInfo();
    this.txtInsuredName = new MGATextBox();
    this.Label21 = new Label();
    this.cboState = new MGASimpleComboBox();
    this.Label5 = new Label();
    this.txtPolicyNo = new MGATextBox();
    this.txtControlNo = new MGATextBox();
    this.btnSearch = new MGAButton();
    this.btnUndoOffset = new MGAButton();
    this.btnOffset = new MGAButton();
    this.btnSave = new MGAButton();
    this.tabFilingPolicyInfo = new UltraTabPageControl();
    this.Label43 = new Label();
    this.lblTaxDue_Pol = new Label();
    this.lblTaxableFeeAmount_Pol_Amount = new Label();
    this.lblStatePremium_Pol = new Label();
    this.lblTotalTaxableFeesAmount = new Label();
    this.lblTaxableFeeAmount_Pol = new Label();
    this.Label36 = new Label();
    this.lblStatePremiumAmount_Pol = new Label();
    this.lblTotalFeesDue = new Label();
    this.lblFeesDueAmount_Pol = new Label();
    this.Label26 = new Label();
    this.lblTaxDueAmount_Pol = new Label();
    this.lblTotalTaxDue = new Label();
    this.lblFeesDue_Pol = new Label();
    this.Label24 = new Label();
    this.lblTotalStatePremium = new Label();
    this.Label19 = new Label();
    this.lblState = new Label();
    this.Label9 = new Label();
    this.lblInsured = new Label();
    this.Label39 = new Label();
    this.lblStateTIV = new Label();
    this.lblPolicyTIV = new Label();
    this.Label34 = new Label();
    this.Label33 = new Label();
    this.lblStatePremium = new Label();
    this.Label32 = new Label();
    this.lblTransType = new Label();
    this.Label31 = new Label();
    this.lblLOB = new Label();
    this.Label30 = new Label();
    this.lblInvoiceNum = new Label();
    this.Label29 = new Label();
    this.lblControlNo = new Label();
    this.Label28 = new Label();
    this.linkRelatedQuote = new LinkLabel();
    this.lblPayeeName = new Label();
    this.Label3 = new Label();
    this.Label14 = new Label();
    this.Label4 = new Label();
    this.Label22 = new Label();
    this.Label1 = new Label();
    this.lblAffidavitNumber = new Label();
    this.lblFilingProducer = new Label();
    this.lblPremium = new Label();
    this.lblLicenseNumber = new Label();
    this.tabFilingStateInfo = new UltraTabPageControl();
    this.Label10 = new Label();
    this.dtCheckReqDate = new MGADateTimePicker();
    this.lnkClearCheckRequestDate = new LinkLabel();
    this.Label23 = new Label();
    this.lnkSetCheckRequestDate = new LinkLabel();
    this.tabNotesExemptions = new UltraTabPageControl();
    this.UltraGroupBox2 = new UltraGroupBox();
    this.txtNotes = new RichTextBox();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.txtExRe = new RichTextBox();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.err = new ErrorProvider(this.components);
    this.daGetOtherPolicyFilingInfo = DefaultDatabase.CreateDataAdapter();
    this.SqlDeleteCommand = DefaultDatabase.CreateCommand();
    this.SqlInsertCommand = DefaultDatabase.CreateCommand();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.SqlUpdateCommand = DefaultDatabase.CreateCommand();
    this.UltraFiling = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.panelPleaseWait = new UltraGroupBox();
    this.Label27 = new Label();
    this.PictureBox1 = new PictureBox();
    this.gridFilingInformation = new UltraGrid();
    this.ttToolTip = new ToolTip(this.components);
    ((Control) this.tabSearch).SuspendLayout();
    ((ISupportInitialize) this.btnAggregateReport).BeginInit();
    this.GroupBox3.SuspendLayout();
    ((ISupportInitialize) this.chkHidePolicyStatus).BeginInit();
    ((ISupportInitialize) this.chkHideAffidavitNumber).BeginInit();
    ((ISupportInitialize) this.chkHideInsured).BeginInit();
    ((ISupportInitialize) this.chkHideUnderwriter).BeginInit();
    ((ISupportInitialize) this.chkHideTransactionType).BeginInit();
    ((ISupportInitialize) this.chkHideFeeColumn).BeginInit();
    ((ISupportInitialize) this.chkHideCarrierColumn).BeginInit();
    ((ISupportInitialize) this.chkHidePolicyNumberColumn).BeginInit();
    ((ISupportInitialize) this.btnExcelExport).BeginInit();
    ((ISupportInitialize) this.chkDateFiledNULL).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.dtpRevenueDateFrom).BeginInit();
    ((ISupportInitialize) this.dtpReveneDateTo).BeginInit();
    ((ISupportInitialize) this.chkHideOffsets).BeginInit();
    ((ISupportInitialize) this.chkTaxableFee).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.dtpPolicyEffFrom).BeginInit();
    ((ISupportInitialize) this.dtpPolEffectiveTo).BeginInit();
    ((ISupportInitialize) this.lstIssuingOffices).BeginInit();
    ((ISupportInitialize) this.txtFilingProducer).BeginInit();
    this.grpFee.SuspendLayout();
    ((ISupportInitialize) this.cboChargeName).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtInsuredName).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.txtPolicyNo).BeginInit();
    ((ISupportInitialize) this.txtControlNo).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.btnUndoOffset).BeginInit();
    ((ISupportInitialize) this.btnOffset).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((Control) this.tabFilingPolicyInfo).SuspendLayout();
    ((Control) this.tabFilingStateInfo).SuspendLayout();
    ((ISupportInitialize) this.dtCheckReqDate).BeginInit();
    ((Control) this.tabNotesExemptions).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox2).BeginInit();
    ((Control) this.UltraGroupBox2).SuspendLayout();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.UltraFiling).BeginInit();
    ((Control) this.UltraFiling).SuspendLayout();
    ((ISupportInitialize) this.panelPleaseWait).BeginInit();
    ((Control) this.panelPleaseWait).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.gridFilingInformation).BeginInit();
    this.SuspendLayout();
    ((Control) this.tabSearch).Controls.Add((Control) this.btnAggregateReport);
    ((Control) this.tabSearch).Controls.Add((Control) this.GroupBox3);
    ((Control) this.tabSearch).Controls.Add((Control) this.btnExcelExport);
    ((Control) this.tabSearch).Controls.Add((Control) this.chkDateFiledNULL);
    ((Control) this.tabSearch).Controls.Add((Control) this.GroupBox2);
    ((Control) this.tabSearch).Controls.Add((Control) this.chkHideOffsets);
    ((Control) this.tabSearch).Controls.Add((Control) this.chkTaxableFee);
    ((Control) this.tabSearch).Controls.Add((Control) this.GroupBox1);
    ((Control) this.tabSearch).Controls.Add((Control) this.Label2);
    ((Control) this.tabSearch).Controls.Add((Control) this.lstIssuingOffices);
    ((Control) this.tabSearch).Controls.Add((Control) this.txtFilingProducer);
    ((Control) this.tabSearch).Controls.Add((Control) this.Label38);
    ((Control) this.tabSearch).Controls.Add((Control) this.grpFee);
    ((Control) this.tabSearch).Controls.Add((Control) this.lnkClearSearch);
    ((Control) this.tabSearch).Controls.Add((Control) this.Label6);
    ((Control) this.tabSearch).Controls.Add((Control) this.Label8);
    ((Control) this.tabSearch).Controls.Add((Control) this.Label7);
    ((Control) this.tabSearch).Controls.Add((Control) this.cboChargeName);
    ((Control) this.tabSearch).Controls.Add((Control) this.txtInsuredName);
    ((Control) this.tabSearch).Controls.Add((Control) this.Label21);
    ((Control) this.tabSearch).Controls.Add((Control) this.cboState);
    ((Control) this.tabSearch).Controls.Add((Control) this.Label5);
    ((Control) this.tabSearch).Controls.Add((Control) this.txtPolicyNo);
    ((Control) this.tabSearch).Controls.Add((Control) this.txtControlNo);
    ((Control) this.tabSearch).Controls.Add((Control) this.btnSearch);
    ((Control) this.tabSearch).Controls.Add((Control) this.btnUndoOffset);
    ((Control) this.tabSearch).Controls.Add((Control) this.btnOffset);
    ((Control) this.tabSearch).Controls.Add((Control) this.btnSave);
    ((Control) this.tabSearch).Location = new Point(1, 26);
    ((Control) this.tabSearch).Name = "tabSearch";
    ((Control) this.tabSearch).Size = new Size(1087, 232);
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnAggregateReport).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnAggregateReport).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnAggregateReport).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnAggregateReport).Location = new Point(855, 187);
    ((Control) this.btnAggregateReport).Name = "btnAggregateReport";
    ((Control) this.btnAggregateReport).Size = new Size(53, 40);
    ((Control) this.btnAggregateReport).TabIndex = 248;
    this.ttToolTip.SetToolTip((Control) this.btnAggregateReport, "Generate Aggregate Report group by Policy # - Sum Taxes and Fees");
    this.btnAggregateReport.UseOSThemes = (DefaultableBoolean) 2;
    this.GroupBox3.BackColor = Color.Transparent;
    this.GroupBox3.Controls.Add((Control) this.chkHidePolicyStatus);
    this.GroupBox3.Controls.Add((Control) this.chkHideAffidavitNumber);
    this.GroupBox3.Controls.Add((Control) this.chkHideInsured);
    this.GroupBox3.Controls.Add((Control) this.chkHideUnderwriter);
    this.GroupBox3.Controls.Add((Control) this.chkHideTransactionType);
    this.GroupBox3.Controls.Add((Control) this.chkHideFeeColumn);
    this.GroupBox3.Controls.Add((Control) this.chkHideCarrierColumn);
    this.GroupBox3.Controls.Add((Control) this.chkHidePolicyNumberColumn);
    this.GroupBox3.Location = new Point(914, 3);
    this.GroupBox3.Name = "GroupBox3";
    this.GroupBox3.Size = new Size(166, 221);
    this.GroupBox3.TabIndex = 247;
    this.GroupBox3.TabStop = false;
    this.GroupBox3.Text = "Hide/Show Columns";
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHidePolicyStatus).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.chkHidePolicyStatus).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHidePolicyStatus).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHidePolicyStatus).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHidePolicyStatus).Location = new Point(6, 201);
    ((Control) this.chkHidePolicyStatus).Name = "chkHidePolicyStatus";
    ((Control) this.chkHidePolicyStatus).Size = new Size(135, 14);
    ((Control) this.chkHidePolicyStatus).TabIndex = 251;
    ((UltraToggleEditorBase) this.chkHidePolicyStatus).Text = "Policy Status Column";
    ((UltraControlBase) this.chkHidePolicyStatus).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHidePolicyStatus).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideAffidavitNumber).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkHideAffidavitNumber).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideAffidavitNumber).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideAffidavitNumber).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideAffidavitNumber).Location = new Point(6, 177);
    ((Control) this.chkHideAffidavitNumber).Name = "chkHideAffidavitNumber";
    ((Control) this.chkHideAffidavitNumber).Size = new Size(135, 14);
    ((Control) this.chkHideAffidavitNumber).TabIndex = 250;
    ((UltraToggleEditorBase) this.chkHideAffidavitNumber).Text = "Affidavit # Column";
    ((UltraControlBase) this.chkHideAffidavitNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideAffidavitNumber).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideInsured).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkHideInsured).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideInsured).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideInsured).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideInsured).Location = new Point(6, 151);
    ((Control) this.chkHideInsured).Name = "chkHideInsured";
    ((Control) this.chkHideInsured).Size = new Size(114, 14);
    ((Control) this.chkHideInsured).TabIndex = 249;
    ((UltraToggleEditorBase) this.chkHideInsured).Text = "Insured Column";
    ((UltraControlBase) this.chkHideInsured).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideInsured).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideUnderwriter).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkHideUnderwriter).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideUnderwriter).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideUnderwriter).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideUnderwriter).Location = new Point(6, 125);
    ((Control) this.chkHideUnderwriter).Name = "chkHideUnderwriter";
    ((Control) this.chkHideUnderwriter).Size = new Size(135, 14);
    ((Control) this.chkHideUnderwriter).TabIndex = 248;
    ((UltraToggleEditorBase) this.chkHideUnderwriter).Text = "Underwriter Column";
    ((UltraControlBase) this.chkHideUnderwriter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideUnderwriter).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideTransactionType).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkHideTransactionType).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideTransactionType).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideTransactionType).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideTransactionType).Location = new Point(6, 99);
    ((Control) this.chkHideTransactionType).Name = "chkHideTransactionType";
    ((Control) this.chkHideTransactionType).Size = new Size(154, 14);
    ((Control) this.chkHideTransactionType).TabIndex = 247;
    ((UltraToggleEditorBase) this.chkHideTransactionType).Text = "Transaction Type Column";
    ((UltraControlBase) this.chkHideTransactionType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideTransactionType).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.Gray;
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideFeeColumn).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkHideFeeColumn).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideFeeColumn).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideFeeColumn).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideFeeColumn).Location = new Point(6, 21);
    ((Control) this.chkHideFeeColumn).Name = "chkHideFeeColumn";
    ((Control) this.chkHideFeeColumn).Size = new Size(114, 14);
    ((Control) this.chkHideFeeColumn).TabIndex = 241;
    ((UltraToggleEditorBase) this.chkHideFeeColumn).Text = "Fee Column";
    ((UltraControlBase) this.chkHideFeeColumn).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideFeeColumn).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.Gray;
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideCarrierColumn).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.chkHideCarrierColumn).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideCarrierColumn).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideCarrierColumn).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideCarrierColumn).Location = new Point(6, 73);
    ((Control) this.chkHideCarrierColumn).Name = "chkHideCarrierColumn";
    ((Control) this.chkHideCarrierColumn).Size = new Size(135, 14);
    ((Control) this.chkHideCarrierColumn).TabIndex = 245;
    ((UltraToggleEditorBase) this.chkHideCarrierColumn).Text = "Carrier Column";
    ((UltraControlBase) this.chkHideCarrierColumn).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideCarrierColumn).UseOsThemes = (DefaultableBoolean) 2;
    appearance9.BorderColor = Color.Gray;
    appearance9.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHidePolicyNumberColumn).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.chkHidePolicyNumberColumn).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHidePolicyNumberColumn).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHidePolicyNumberColumn).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHidePolicyNumberColumn).Location = new Point(6, 47);
    ((Control) this.chkHidePolicyNumberColumn).Name = "chkHidePolicyNumberColumn";
    ((Control) this.chkHidePolicyNumberColumn).Size = new Size(135, 14);
    ((Control) this.chkHidePolicyNumberColumn).TabIndex = 246;
    ((UltraToggleEditorBase) this.chkHidePolicyNumberColumn).Text = "Policy # Column";
    ((UltraControlBase) this.chkHidePolicyNumberColumn).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHidePolicyNumberColumn).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.ImageHAlign = (HAlign) 2;
    appearance10.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnExcelExport).Appearance = (AppearanceBase) appearance10;
    ((ControlBase) this.btnExcelExport).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnExcelExport).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnExcelExport).Location = new Point(658, 189);
    ((Control) this.btnExcelExport).Name = "btnExcelExport";
    ((Control) this.btnExcelExport).Size = new Size(53, 40);
    ((Control) this.btnExcelExport).TabIndex = 240 /*0xF0*/;
    this.ttToolTip.SetToolTip((Control) this.btnExcelExport, "Generate an Excel Report of the data on screen,");
    this.btnExcelExport.UseOSThemes = (DefaultableBoolean) 2;
    appearance11.BorderColor = Color.Gray;
    appearance11.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkDateFiledNULL).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.chkDateFiledNULL).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDateFiledNULL).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkDateFiledNULL).Checked = true;
    ((UltraToggleEditorBase) this.chkDateFiledNULL).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkDateFiledNULL).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkDateFiledNULL).Location = new Point(247, 159);
    ((Control) this.chkDateFiledNULL).Name = "chkDateFiledNULL";
    ((Control) this.chkDateFiledNULL).Size = new Size(112 /*0x70*/, 14);
    ((Control) this.chkDateFiledNULL).TabIndex = 239;
    ((UltraToggleEditorBase) this.chkDateFiledNULL).Text = "Date Filed Empty";
    ((UltraControlBase) this.chkDateFiledNULL).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkDateFiledNULL).UseOsThemes = (DefaultableBoolean) 2;
    this.GroupBox2.BackColor = Color.Transparent;
    this.GroupBox2.Controls.Add((Control) this.dtpRevenueDateFrom);
    this.GroupBox2.Controls.Add((Control) this.dtpReveneDateTo);
    this.GroupBox2.Controls.Add((Control) this.Label16);
    this.GroupBox2.Controls.Add((Control) this.Label17);
    this.GroupBox2.Location = new Point(247, 63 /*0x3F*/);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(251, 44);
    this.GroupBox2.TabIndex = 238;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Revenue Date";
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpRevenueDateFrom).Appearance = (AppearanceBase) appearance12;
    appearance13.AlphaLevel = (short) 14;
    appearance13.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance13.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance13.BackColorAlpha = (Alpha) 2;
    appearance13.BackGradientAlignment = (GradientAlignment) 4;
    appearance13.BackGradientStyle = (GradientStyle) 5;
    appearance13.BorderAlpha = (Alpha) 1;
    appearance13.BorderColor = Color.FromArgb(78, 122, 171);
    appearance13.ForeColor = Color.FromArgb(49, 85, 153);
    appearance13.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtpRevenueDateFrom).ButtonAppearance = (AppearanceBase) appearance13;
    ((UltraDateTimeEditor) this.dtpRevenueDateFrom).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpRevenueDateFrom).Location = new Point(42, 19);
    this.dtpRevenueDateFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpRevenueDateFrom).Name = "dtpRevenueDateFrom";
    ((Control) this.dtpRevenueDateFrom).Size = new Size(85, 20);
    ((Control) this.dtpRevenueDateFrom).TabIndex = 13;
    ((UltraControlBase) this.dtpRevenueDateFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpRevenueDateFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtpRevenueDateFrom).Value = (object) null;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpReveneDateTo).Appearance = (AppearanceBase) appearance14;
    appearance15.AlphaLevel = (short) 14;
    appearance15.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance15.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance15.BackColorAlpha = (Alpha) 2;
    appearance15.BackGradientAlignment = (GradientAlignment) 4;
    appearance15.BackGradientStyle = (GradientStyle) 5;
    appearance15.BorderAlpha = (Alpha) 1;
    appearance15.BorderColor = Color.FromArgb(78, 122, 171);
    appearance15.ForeColor = Color.FromArgb(49, 85, 153);
    appearance15.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtpReveneDateTo).ButtonAppearance = (AppearanceBase) appearance15;
    ((UltraDateTimeEditor) this.dtpReveneDateTo).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpReveneDateTo).Location = new Point(160 /*0xA0*/, 16 /*0x10*/);
    this.dtpReveneDateTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpReveneDateTo).Name = "dtpReveneDateTo";
    ((Control) this.dtpReveneDateTo).Size = new Size(85, 20);
    ((Control) this.dtpReveneDateTo).TabIndex = 14;
    ((UltraControlBase) this.dtpReveneDateTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpReveneDateTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtpReveneDateTo).Value = (object) null;
    this.Label16.AutoSize = true;
    this.Label16.BackColor = Color.Transparent;
    this.Label16.Location = new Point(133, 19);
    this.Label16.Name = "Label16";
    this.Label16.Size = new Size(19, 13);
    this.Label16.TabIndex = 225;
    this.Label16.Text = "To";
    this.Label17.AutoSize = true;
    this.Label17.BackColor = Color.Transparent;
    this.Label17.Location = new Point(6, 22);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(31 /*0x1F*/, 13);
    this.Label17.TabIndex = 223;
    this.Label17.Text = "From";
    appearance16.BorderColor = Color.Gray;
    appearance16.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideOffsets).Appearance = (AppearanceBase) appearance16;
    ((UltraToggleEditorBase) this.chkHideOffsets).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideOffsets).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideOffsets).Checked = true;
    ((UltraToggleEditorBase) this.chkHideOffsets).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkHideOffsets).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideOffsets).Location = new Point(247, 125);
    ((Control) this.chkHideOffsets).Name = "chkHideOffsets";
    ((Control) this.chkHideOffsets).Size = new Size(100, 14);
    ((Control) this.chkHideOffsets).TabIndex = 237;
    ((UltraToggleEditorBase) this.chkHideOffsets).Text = "Hide Offsets";
    ((UltraControlBase) this.chkHideOffsets).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideOffsets).UseOsThemes = (DefaultableBoolean) 2;
    appearance17.BorderColor = Color.Gray;
    appearance17.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkTaxableFee).Appearance = (AppearanceBase) appearance17;
    ((UltraToggleEditorBase) this.chkTaxableFee).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkTaxableFee).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkTaxableFee).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkTaxableFee).Location = new Point(247, 190);
    ((Control) this.chkTaxableFee).Name = "chkTaxableFee";
    ((Control) this.chkTaxableFee).Size = new Size(99, 14);
    ((Control) this.chkTaxableFee).TabIndex = 236;
    ((UltraToggleEditorBase) this.chkTaxableFee).Text = "Taxable Fee";
    ((UltraControlBase) this.chkTaxableFee).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkTaxableFee).UseOsThemes = (DefaultableBoolean) 2;
    this.GroupBox1.BackColor = Color.Transparent;
    this.GroupBox1.Controls.Add((Control) this.dtpPolicyEffFrom);
    this.GroupBox1.Controls.Add((Control) this.dtpPolEffectiveTo);
    this.GroupBox1.Controls.Add((Control) this.Label11);
    this.GroupBox1.Controls.Add((Control) this.Label15);
    this.GroupBox1.Location = new Point(247, 9);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(251, 44);
    this.GroupBox1.TabIndex = 235;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Policy Effective";
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpPolicyEffFrom).Appearance = (AppearanceBase) appearance18;
    appearance19.AlphaLevel = (short) 14;
    appearance19.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance19.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance19.BackColorAlpha = (Alpha) 2;
    appearance19.BackGradientAlignment = (GradientAlignment) 4;
    appearance19.BackGradientStyle = (GradientStyle) 5;
    appearance19.BorderAlpha = (Alpha) 1;
    appearance19.BorderColor = Color.FromArgb(78, 122, 171);
    appearance19.ForeColor = Color.FromArgb(49, 85, 153);
    appearance19.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtpPolicyEffFrom).ButtonAppearance = (AppearanceBase) appearance19;
    ((UltraDateTimeEditor) this.dtpPolicyEffFrom).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpPolicyEffFrom).Location = new Point(42, 19);
    this.dtpPolicyEffFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpPolicyEffFrom).Name = "dtpPolicyEffFrom";
    ((Control) this.dtpPolicyEffFrom).Size = new Size(85, 20);
    ((Control) this.dtpPolicyEffFrom).TabIndex = 13;
    ((UltraControlBase) this.dtpPolicyEffFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpPolicyEffFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtpPolicyEffFrom).Value = (object) null;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpPolEffectiveTo).Appearance = (AppearanceBase) appearance20;
    appearance21.AlphaLevel = (short) 14;
    appearance21.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance21.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance21.BackColorAlpha = (Alpha) 2;
    appearance21.BackGradientAlignment = (GradientAlignment) 4;
    appearance21.BackGradientStyle = (GradientStyle) 5;
    appearance21.BorderAlpha = (Alpha) 1;
    appearance21.BorderColor = Color.FromArgb(78, 122, 171);
    appearance21.ForeColor = Color.FromArgb(49, 85, 153);
    appearance21.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtpPolEffectiveTo).ButtonAppearance = (AppearanceBase) appearance21;
    ((UltraDateTimeEditor) this.dtpPolEffectiveTo).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpPolEffectiveTo).Location = new Point(160 /*0xA0*/, 16 /*0x10*/);
    this.dtpPolEffectiveTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpPolEffectiveTo).Name = "dtpPolEffectiveTo";
    ((Control) this.dtpPolEffectiveTo).Size = new Size(85, 20);
    ((Control) this.dtpPolEffectiveTo).TabIndex = 14;
    ((UltraControlBase) this.dtpPolEffectiveTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpPolEffectiveTo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtpPolEffectiveTo).Value = (object) null;
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Location = new Point(133, 19);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(19, 13);
    this.Label11.TabIndex = 225;
    this.Label11.Text = "To";
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Location = new Point(6, 22);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(31 /*0x1F*/, 13);
    this.Label15.TabIndex = 223;
    this.Label15.Text = "From";
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(523, 9);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(89, 13);
    this.Label2.TabIndex = 232;
    this.Label2.Text = "Issuing Locations";
    ((ListBox) this.lstIssuingOffices).BackColor = Color.White;
    ((CheckedListBox) this.lstIssuingOffices).CheckOnClick = true;
    ((ListBox) this.lstIssuingOffices).ForeColor = Color.Black;
    ((Control) this.lstIssuingOffices).Location = new Point(526, 30);
    this.lstIssuingOffices.MGAStyle = (MGAStyles) 2;
    ((Control) this.lstIssuingOffices).Name = "lstIssuingOffices";
    ((Control) this.lstIssuingOffices).Size = new Size(243, 116);
    ((Control) this.lstIssuingOffices).TabIndex = 231;
    appearance22.BackColor = Color.White;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFilingProducer).Appearance = (AppearanceBase) appearance22;
    ((TextEditorControlBase) this.txtFilingProducer).BackColor = Color.White;
    ((Control) this.txtFilingProducer).Location = new Point(113, 196);
    ((TextEditorControlBase) this.txtFilingProducer).MaxLength = 55;
    this.txtFilingProducer.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtFilingProducer).Name = "txtFilingProducer";
    ((Control) this.txtFilingProducer).Size = new Size(115, 20);
    ((Control) this.txtFilingProducer).TabIndex = 230;
    ((UltraControlBase) this.txtFilingProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFilingProducer).UseOsThemes = (DefaultableBoolean) 2;
    this.Label38.AutoSize = true;
    this.Label38.BackColor = Color.Transparent;
    this.Label38.Location = new Point(26, 200);
    this.Label38.Name = "Label38";
    this.Label38.Size = new Size(77, 13);
    this.Label38.TabIndex = 229;
    this.Label38.Text = "Filing Producer";
    this.grpFee.BackColor = Color.Transparent;
    this.grpFee.Controls.Add((Control) this.rbNotPaid);
    this.grpFee.Controls.Add((Control) this.rbBoth);
    this.grpFee.Controls.Add((Control) this.rbPaid);
    this.grpFee.Location = new Point(788, 27);
    this.grpFee.Name = "grpFee";
    this.grpFee.Size = new Size(73, 119);
    this.grpFee.TabIndex = 227;
    this.grpFee.TabStop = false;
    this.grpFee.Text = "Fee";
    this.rbNotPaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbNotPaid.BackColor = Color.Transparent;
    this.rbNotPaid.ForeColor = Color.Black;
    this.rbNotPaid.Location = new Point(6, 56);
    this.rbNotPaid.Name = "rbNotPaid";
    this.rbNotPaid.Size = new Size(67, 24);
    this.rbNotPaid.TabIndex = 14;
    this.rbNotPaid.Text = "Not Paid";
    this.rbNotPaid.UseVisualStyleBackColor = false;
    this.rbBoth.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbBoth.BackColor = Color.Transparent;
    this.rbBoth.Checked = true;
    this.rbBoth.ForeColor = Color.Black;
    this.rbBoth.Location = new Point(8, 86);
    this.rbBoth.Name = "rbBoth";
    this.rbBoth.Size = new Size(51, 24);
    this.rbBoth.TabIndex = 15;
    this.rbBoth.TabStop = true;
    this.rbBoth.Text = "Both";
    this.rbBoth.UseVisualStyleBackColor = false;
    this.rbPaid.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.rbPaid.BackColor = Color.Transparent;
    this.rbPaid.ForeColor = Color.Black;
    this.rbPaid.Location = new Point(6, 24);
    this.rbPaid.Name = "rbPaid";
    this.rbPaid.Size = new Size(53, 26);
    this.rbPaid.TabIndex = 13;
    this.rbPaid.Text = "Paid";
    this.rbPaid.UseVisualStyleBackColor = false;
    this.lnkClearSearch.AutoSize = true;
    this.lnkClearSearch.BackColor = Color.Transparent;
    this.lnkClearSearch.Location = new Point(384, 214);
    this.lnkClearSearch.Name = "lnkClearSearch";
    this.lnkClearSearch.Size = new Size(106, 13);
    this.lnkClearSearch.TabIndex = 225;
    this.lnkClearSearch.TabStop = true;
    this.lnkClearSearch.Tag = (object) "101";
    this.lnkClearSearch.Text = "Clear Search Criteria";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(70, 13);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(33, 13);
    this.Label6.TabIndex = 20;
    this.Label6.Text = "State";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(45, 126);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(58, 13);
    this.Label8.TabIndex = 16 /*0x10*/;
    this.Label8.Text = "Control No";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(29, 163);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(74, 13);
    this.Label7.TabIndex = 18;
    this.Label7.Text = "Insured Name";
    ((UltraCombo) this.cboChargeName).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboChargeName).DataMember = "tblFin_PolicyCharges";
    ((UltraGridBase) this.cboChargeName).DataSource = (object) this.ds;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboChargeName.DisplayLayout.Appearance = (AppearanceBase) appearance23;
    this.cboChargeName.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Charge Code";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 184;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Name";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 381;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 154;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "State";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 35;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboChargeName.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboChargeName.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboChargeName.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboChargeName.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboChargeName.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboChargeName.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboChargeName.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboChargeName.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboChargeName.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboChargeName.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboChargeName.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance24.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance24.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboChargeName.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance24;
    appearance25.BorderColor = Color.White;
    this.cboChargeName.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    this.cboChargeName.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance26.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance26.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance26.ForeColor = Color.Black;
    this.cboChargeName.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance26;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboChargeName.DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraDropDownBase) this.cboChargeName).DisplayMember = "ChargeName";
    ((UltraCombo) this.cboChargeName).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboChargeName).DropDownWidth = 400;
    ((Control) this.cboChargeName).Location = new Point(113, 47);
    ((MGASimpleComboBox) this.cboChargeName).MGAStyle = (MGAStyles) 2;
    ((Control) this.cboChargeName).Name = "cboChargeName";
    ((Control) this.cboChargeName).Size = new Size(115, 21);
    ((Control) this.cboChargeName).TabIndex = 3;
    ((UltraControlBase) this.cboChargeName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboChargeName).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboChargeName).ValueMember = "ChargeCode";
    this.ds.DataSetName = "dsFilingPolicyInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance27.BackColor = Color.White;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInsuredName).Appearance = (AppearanceBase) appearance27;
    ((TextEditorControlBase) this.txtInsuredName).BackColor = Color.White;
    ((Control) this.txtInsuredName).Location = new Point(113, 159);
    ((TextEditorControlBase) this.txtInsuredName).MaxLength = 50;
    this.txtInsuredName.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInsuredName).Name = "txtInsuredName";
    ((Control) this.txtInsuredName).Size = new Size(115, 20);
    ((Control) this.txtInsuredName).TabIndex = 5;
    ((UltraControlBase) this.txtInsuredName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInsuredName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label21.AutoSize = true;
    this.Label21.BackColor = Color.Transparent;
    this.Label21.Location = new Point(51, 51);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(52, 13);
    this.Label21.TabIndex = 221;
    this.Label21.Text = "Fee Type";
    ((UltraCombo) this.cboState).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboState).DataMember = "lstStates";
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    ((UltraCombo) this.cboState).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 150;
    ((Control) this.cboState).Location = new Point(113, 9);
    this.cboState.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(115, 21);
    ((Control) this.cboState).TabIndex = 2;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(53, 89);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(50, 13);
    this.Label5.TabIndex = 22;
    this.Label5.Text = "Policy No";
    appearance28.BackColor = Color.White;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPolicyNo).Appearance = (AppearanceBase) appearance28;
    ((TextEditorControlBase) this.txtPolicyNo).BackColor = Color.White;
    ((Control) this.txtPolicyNo).Location = new Point(113, 85);
    ((TextEditorControlBase) this.txtPolicyNo).MaxLength = 50;
    this.txtPolicyNo.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPolicyNo).Name = "txtPolicyNo";
    ((Control) this.txtPolicyNo).Size = new Size(115, 20);
    ((Control) this.txtPolicyNo).TabIndex = 6;
    ((UltraControlBase) this.txtPolicyNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPolicyNo).UseOsThemes = (DefaultableBoolean) 2;
    appearance29.BackColor = Color.White;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtControlNo).Appearance = (AppearanceBase) appearance29;
    ((TextEditorControlBase) this.txtControlNo).BackColor = Color.White;
    ((Control) this.txtControlNo).Location = new Point(113, 122);
    ((TextEditorControlBase) this.txtControlNo).MaxLength = 50;
    this.txtControlNo.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtControlNo).Name = "txtControlNo";
    ((Control) this.txtControlNo).Size = new Size(115, 20);
    ((Control) this.txtControlNo).TabIndex = 4;
    ((UltraControlBase) this.txtControlNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtControlNo).UseOsThemes = (DefaultableBoolean) 2;
    appearance30.ImageHAlign = (HAlign) 2;
    appearance30.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance30;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(526, 189);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(53, 40);
    ((Control) this.btnSearch).TabIndex = 204;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    appearance31.ImageHAlign = (HAlign) 2;
    appearance31.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnUndoOffset).Appearance = (AppearanceBase) appearance31;
    ((ControlBase) this.btnUndoOffset).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnUndoOffset).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnUndoOffset).Location = new Point(790, 189);
    ((Control) this.btnUndoOffset).Name = "btnUndoOffset";
    ((Control) this.btnUndoOffset).Size = new Size(53, 40);
    ((Control) this.btnUndoOffset).TabIndex = 235;
    ((ControlBase) this.btnUndoOffset).Text = "Undo Off-Set";
    this.btnUndoOffset.UseOSThemes = (DefaultableBoolean) 2;
    appearance32.ImageHAlign = (HAlign) 2;
    appearance32.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnOffset).Appearance = (AppearanceBase) appearance32;
    ((ControlBase) this.btnOffset).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnOffset).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnOffset).Location = new Point(724, 189);
    ((Control) this.btnOffset).Name = "btnOffset";
    ((Control) this.btnOffset).Size = new Size(53, 40);
    ((Control) this.btnOffset).TabIndex = 234;
    ((ControlBase) this.btnOffset).Text = "Off-Set";
    this.ttToolTip.SetToolTip((Control) this.btnOffset, "Offset the selected fees on the grid.");
    this.btnOffset.UseOSThemes = (DefaultableBoolean) 2;
    appearance33.ImageHAlign = (HAlign) 2;
    appearance33.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance33;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(592, 189);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(53, 40);
    ((Control) this.btnSave).TabIndex = 206;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label43);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblTaxDue_Pol);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblTaxableFeeAmount_Pol_Amount);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblStatePremium_Pol);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblTotalTaxableFeesAmount);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblTaxableFeeAmount_Pol);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label36);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblStatePremiumAmount_Pol);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblTotalFeesDue);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblFeesDueAmount_Pol);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label26);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblTaxDueAmount_Pol);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblTotalTaxDue);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblFeesDue_Pol);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label24);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblTotalStatePremium);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label19);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblState);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label9);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblInsured);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label39);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblStateTIV);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblPolicyTIV);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label34);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label33);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblStatePremium);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label32);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblTransType);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label31);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblLOB);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label30);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblInvoiceNum);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label29);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblControlNo);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label28);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.linkRelatedQuote);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblPayeeName);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label3);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label14);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label4);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label22);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.Label1);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblAffidavitNumber);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblFilingProducer);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblPremium);
    ((Control) this.tabFilingPolicyInfo).Controls.Add((Control) this.lblLicenseNumber);
    ((Control) this.tabFilingPolicyInfo).Location = new Point(-10000, -10000);
    ((Control) this.tabFilingPolicyInfo).Name = "tabFilingPolicyInfo";
    ((Control) this.tabFilingPolicyInfo).Size = new Size(1087, 232);
    ((Control) this.tabFilingPolicyInfo).Tag = (object) "1";
    this.Label43.AutoSize = true;
    this.Label43.BackColor = Color.Transparent;
    this.Label43.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
    this.Label43.Location = new Point(784, 117);
    this.Label43.Name = "Label43";
    this.Label43.Size = new Size(130, 13);
    this.Label43.TabIndex = 276;
    this.Label43.Tag = (object) "101";
    this.Label43.Text = "Selected Policy Totals";
    this.Label43.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTaxDue_Pol.AutoSize = true;
    this.lblTaxDue_Pol.BackColor = Color.Transparent;
    this.lblTaxDue_Pol.Location = new Point(759, 157);
    this.lblTaxDue_Pol.Name = "lblTaxDue_Pol";
    this.lblTaxDue_Pol.Size = new Size(51, 13);
    this.lblTaxDue_Pol.TabIndex = 270;
    this.lblTaxDue_Pol.Tag = (object) "101";
    this.lblTaxDue_Pol.Text = "Tax Due:";
    this.lblTaxDue_Pol.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTaxableFeeAmount_Pol_Amount.AutoSize = true;
    this.lblTaxableFeeAmount_Pol_Amount.BackColor = Color.Transparent;
    this.lblTaxableFeeAmount_Pol_Amount.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTaxableFeeAmount_Pol_Amount.Location = new Point(916, 205);
    this.lblTaxableFeeAmount_Pol_Amount.Name = "lblTaxableFeeAmount_Pol_Amount";
    this.lblTaxableFeeAmount_Pol_Amount.Size = new Size(19, 13);
    this.lblTaxableFeeAmount_Pol_Amount.TabIndex = 275;
    this.lblTaxableFeeAmount_Pol_Amount.Tag = (object) "1";
    this.lblTaxableFeeAmount_Pol_Amount.Text = "$0";
    this.lblTaxableFeeAmount_Pol_Amount.TextAlign = ContentAlignment.MiddleLeft;
    this.lblStatePremium_Pol.AutoSize = true;
    this.lblStatePremium_Pol.BackColor = Color.Transparent;
    this.lblStatePremium_Pol.Location = new Point(759, 133);
    this.lblStatePremium_Pol.Name = "lblStatePremium_Pol";
    this.lblStatePremium_Pol.Size = new Size(80 /*0x50*/, 13);
    this.lblStatePremium_Pol.TabIndex = 268;
    this.lblStatePremium_Pol.Tag = (object) "101";
    this.lblStatePremium_Pol.Text = "State Premium:";
    this.lblStatePremium_Pol.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTotalTaxableFeesAmount.AutoSize = true;
    this.lblTotalTaxableFeesAmount.BackColor = Color.Transparent;
    this.lblTotalTaxableFeesAmount.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTotalTaxableFeesAmount.Location = new Point(913, 91);
    this.lblTotalTaxableFeesAmount.Name = "lblTotalTaxableFeesAmount";
    this.lblTotalTaxableFeesAmount.Size = new Size(19, 13);
    this.lblTotalTaxableFeesAmount.TabIndex = 267;
    this.lblTotalTaxableFeesAmount.Tag = (object) "1";
    this.lblTotalTaxableFeesAmount.Text = "$0";
    this.lblTotalTaxableFeesAmount.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTaxableFeeAmount_Pol.AutoSize = true;
    this.lblTaxableFeeAmount_Pol.BackColor = Color.Transparent;
    this.lblTaxableFeeAmount_Pol.Location = new Point(759, 205);
    this.lblTaxableFeeAmount_Pol.Name = "lblTaxableFeeAmount_Pol";
    this.lblTaxableFeeAmount_Pol.Size = new Size(115, 13);
    this.lblTaxableFeeAmount_Pol.TabIndex = 274;
    this.lblTaxableFeeAmount_Pol.Tag = (object) "101";
    this.lblTaxableFeeAmount_Pol.Text = "Taxable Fees Amount:";
    this.lblTaxableFeeAmount_Pol.TextAlign = ContentAlignment.MiddleLeft;
    this.Label36.AutoSize = true;
    this.Label36.BackColor = Color.Transparent;
    this.Label36.Location = new Point(759, 85);
    this.Label36.Name = "Label36";
    this.Label36.Size = new Size(142, 13);
    this.Label36.TabIndex = 266;
    this.Label36.Tag = (object) "101";
    this.Label36.Text = "Total Taxable Fees Amount:";
    this.Label36.TextAlign = ContentAlignment.MiddleLeft;
    this.lblStatePremiumAmount_Pol.AutoSize = true;
    this.lblStatePremiumAmount_Pol.BackColor = Color.Transparent;
    this.lblStatePremiumAmount_Pol.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblStatePremiumAmount_Pol.Location = new Point(916, 133);
    this.lblStatePremiumAmount_Pol.Name = "lblStatePremiumAmount_Pol";
    this.lblStatePremiumAmount_Pol.Size = new Size(19, 13);
    this.lblStatePremiumAmount_Pol.TabIndex = 269;
    this.lblStatePremiumAmount_Pol.Tag = (object) "1";
    this.lblStatePremiumAmount_Pol.Text = "$0";
    this.lblStatePremiumAmount_Pol.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTotalFeesDue.AutoSize = true;
    this.lblTotalFeesDue.BackColor = Color.Transparent;
    this.lblTotalFeesDue.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTotalFeesDue.Location = new Point(913, 65);
    this.lblTotalFeesDue.Name = "lblTotalFeesDue";
    this.lblTotalFeesDue.Size = new Size(19, 13);
    this.lblTotalFeesDue.TabIndex = 265;
    this.lblTotalFeesDue.Tag = (object) "1";
    this.lblTotalFeesDue.Text = "$0";
    this.lblTotalFeesDue.TextAlign = ContentAlignment.MiddleLeft;
    this.lblFeesDueAmount_Pol.AutoSize = true;
    this.lblFeesDueAmount_Pol.BackColor = Color.Transparent;
    this.lblFeesDueAmount_Pol.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFeesDueAmount_Pol.Location = new Point(916, 181);
    this.lblFeesDueAmount_Pol.Name = "lblFeesDueAmount_Pol";
    this.lblFeesDueAmount_Pol.Size = new Size(19, 13);
    this.lblFeesDueAmount_Pol.TabIndex = 273;
    this.lblFeesDueAmount_Pol.Tag = (object) "1";
    this.lblFeesDueAmount_Pol.Text = "$0";
    this.lblFeesDueAmount_Pol.TextAlign = ContentAlignment.MiddleLeft;
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Location = new Point(759, 61);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(83, 13);
    this.Label26.TabIndex = 264;
    this.Label26.Tag = (object) "101";
    this.Label26.Text = "Total Fees Due:";
    this.Label26.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTaxDueAmount_Pol.AutoSize = true;
    this.lblTaxDueAmount_Pol.BackColor = Color.Transparent;
    this.lblTaxDueAmount_Pol.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTaxDueAmount_Pol.Location = new Point(916, 157);
    this.lblTaxDueAmount_Pol.Name = "lblTaxDueAmount_Pol";
    this.lblTaxDueAmount_Pol.Size = new Size(19, 13);
    this.lblTaxDueAmount_Pol.TabIndex = 271;
    this.lblTaxDueAmount_Pol.Tag = (object) "1";
    this.lblTaxDueAmount_Pol.Text = "$0";
    this.lblTaxDueAmount_Pol.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTotalTaxDue.AutoSize = true;
    this.lblTotalTaxDue.BackColor = Color.Transparent;
    this.lblTotalTaxDue.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTotalTaxDue.Location = new Point(913, 39);
    this.lblTotalTaxDue.Name = "lblTotalTaxDue";
    this.lblTotalTaxDue.Size = new Size(19, 13);
    this.lblTotalTaxDue.TabIndex = 263;
    this.lblTotalTaxDue.Tag = (object) "1";
    this.lblTotalTaxDue.Text = "$0";
    this.lblTotalTaxDue.TextAlign = ContentAlignment.MiddleLeft;
    this.lblFeesDue_Pol.AutoSize = true;
    this.lblFeesDue_Pol.BackColor = Color.Transparent;
    this.lblFeesDue_Pol.Location = new Point(759, 181);
    this.lblFeesDue_Pol.Name = "lblFeesDue_Pol";
    this.lblFeesDue_Pol.Size = new Size(56, 13);
    this.lblFeesDue_Pol.TabIndex = 272;
    this.lblFeesDue_Pol.Tag = (object) "101";
    this.lblFeesDue_Pol.Text = "Fees Due:";
    this.lblFeesDue_Pol.TextAlign = ContentAlignment.MiddleLeft;
    this.Label24.AutoSize = true;
    this.Label24.BackColor = Color.Transparent;
    this.Label24.Location = new Point(759, 37);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(78, 13);
    this.Label24.TabIndex = 262;
    this.Label24.Tag = (object) "101";
    this.Label24.Text = "Total Tax Due:";
    this.Label24.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTotalStatePremium.AutoSize = true;
    this.lblTotalStatePremium.BackColor = Color.Transparent;
    this.lblTotalStatePremium.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTotalStatePremium.Location = new Point(913, 13);
    this.lblTotalStatePremium.Name = "lblTotalStatePremium";
    this.lblTotalStatePremium.Size = new Size(19, 13);
    this.lblTotalStatePremium.TabIndex = 261;
    this.lblTotalStatePremium.Tag = (object) "1";
    this.lblTotalStatePremium.Text = "$0";
    this.lblTotalStatePremium.TextAlign = ContentAlignment.MiddleLeft;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Location = new Point(759, 13);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(107, 13);
    this.Label19.TabIndex = 260;
    this.Label19.Tag = (object) "101";
    this.Label19.Text = "Total State Premium:";
    this.Label19.TextAlign = ContentAlignment.MiddleLeft;
    this.lblState.AutoSize = true;
    this.lblState.BackColor = Color.Transparent;
    this.lblState.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblState.Location = new Point(562, 169);
    this.lblState.Name = "lblState";
    this.lblState.Size = new Size(42, 13);
    this.lblState.TabIndex = 259;
    this.lblState.Tag = (object) "1";
    this.lblState.Text = "lblState";
    this.lblState.TextAlign = ContentAlignment.MiddleLeft;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(459, 169);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(37, 13);
    this.Label9.TabIndex = 258;
    this.Label9.Tag = (object) "101";
    this.Label9.Text = "State:";
    this.Label9.TextAlign = ContentAlignment.MiddleLeft;
    this.lblInsured.AutoSize = true;
    this.lblInsured.BackColor = Color.Transparent;
    this.lblInsured.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblInsured.Location = new Point(132, 169);
    this.lblInsured.Name = "lblInsured";
    this.lblInsured.Size = new Size(52, 13);
    this.lblInsured.TabIndex = 257;
    this.lblInsured.Tag = (object) "1";
    this.lblInsured.Text = "lblInsured";
    this.lblInsured.TextAlign = ContentAlignment.MiddleLeft;
    this.Label39.AutoSize = true;
    this.Label39.BackColor = Color.Transparent;
    this.Label39.Location = new Point(43, 169);
    this.Label39.Name = "Label39";
    this.Label39.Size = new Size(48 /*0x30*/, 13);
    this.Label39.TabIndex = 256 /*0x0100*/;
    this.Label39.Tag = (object) "101";
    this.Label39.Text = "Insured:";
    this.Label39.TextAlign = ContentAlignment.MiddleLeft;
    this.lblStateTIV.AutoSize = true;
    this.lblStateTIV.BackColor = Color.Transparent;
    this.lblStateTIV.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblStateTIV.Location = new Point(562, 143);
    this.lblStateTIV.Name = "lblStateTIV";
    this.lblStateTIV.Size = new Size(59, 13);
    this.lblStateTIV.TabIndex = (int) byte.MaxValue;
    this.lblStateTIV.Tag = (object) "1";
    this.lblStateTIV.Text = "lblStateTIV";
    this.lblStateTIV.TextAlign = ContentAlignment.MiddleLeft;
    this.lblPolicyTIV.AutoSize = true;
    this.lblPolicyTIV.BackColor = Color.Transparent;
    this.lblPolicyTIV.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblPolicyTIV.Location = new Point(562, 117);
    this.lblPolicyTIV.Name = "lblPolicyTIV";
    this.lblPolicyTIV.Size = new Size(62, 13);
    this.lblPolicyTIV.TabIndex = 254;
    this.lblPolicyTIV.Tag = (object) "1";
    this.lblPolicyTIV.Text = "lblPolicyTIV";
    this.lblPolicyTIV.TextAlign = ContentAlignment.MiddleLeft;
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Location = new Point(459, 143);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(56, 13);
    this.Label34.TabIndex = 253;
    this.Label34.Tag = (object) "101";
    this.Label34.Text = "State TIV:";
    this.Label34.TextAlign = ContentAlignment.MiddleLeft;
    this.Label33.AutoSize = true;
    this.Label33.BackColor = Color.Transparent;
    this.Label33.Location = new Point(459, 117);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(57, 13);
    this.Label33.TabIndex = 252;
    this.Label33.Tag = (object) "101";
    this.Label33.Text = "Policy TIV:";
    this.Label33.TextAlign = ContentAlignment.MiddleLeft;
    this.lblStatePremium.AutoSize = true;
    this.lblStatePremium.BackColor = Color.Transparent;
    this.lblStatePremium.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblStatePremium.Location = new Point(132, 143);
    this.lblStatePremium.Name = "lblStatePremium";
    this.lblStatePremium.Size = new Size(82, 13);
    this.lblStatePremium.TabIndex = 251;
    this.lblStatePremium.Tag = (object) "1";
    this.lblStatePremium.Text = "lblStatePremium";
    this.lblStatePremium.TextAlign = ContentAlignment.MiddleLeft;
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Location = new Point(43, 143);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(80 /*0x50*/, 13);
    this.Label32.TabIndex = 250;
    this.Label32.Tag = (object) "101";
    this.Label32.Text = "State Premium:";
    this.Label32.TextAlign = ContentAlignment.MiddleLeft;
    this.lblTransType.AutoSize = true;
    this.lblTransType.BackColor = Color.Transparent;
    this.lblTransType.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblTransType.Location = new Point(562, 91);
    this.lblTransType.Name = "lblTransType";
    this.lblTransType.Size = new Size(68, 13);
    this.lblTransType.TabIndex = 249;
    this.lblTransType.Tag = (object) "1";
    this.lblTransType.Text = "lblTransType";
    this.lblTransType.TextAlign = ContentAlignment.MiddleLeft;
    this.Label31.AutoSize = true;
    this.Label31.BackColor = Color.Transparent;
    this.Label31.Location = new Point(459, 91);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(94, 13);
    this.Label31.TabIndex = 248;
    this.Label31.Tag = (object) "101";
    this.Label31.Text = "Transaction Type:";
    this.Label31.TextAlign = ContentAlignment.MiddleLeft;
    this.lblLOB.AutoSize = true;
    this.lblLOB.BackColor = Color.Transparent;
    this.lblLOB.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblLOB.Location = new Point(562, 65);
    this.lblLOB.Name = "lblLOB";
    this.lblLOB.Size = new Size(38, 13);
    this.lblLOB.TabIndex = 247;
    this.lblLOB.Tag = (object) "1";
    this.lblLOB.Text = "lblLOB";
    this.lblLOB.TextAlign = ContentAlignment.MiddleLeft;
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Location = new Point(459, 65);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(89, 13);
    this.Label30.TabIndex = 246;
    this.Label30.Tag = (object) "101";
    this.Label30.Text = "Line Of Business:";
    this.Label30.TextAlign = ContentAlignment.MiddleLeft;
    this.lblInvoiceNum.AutoSize = true;
    this.lblInvoiceNum.BackColor = Color.Transparent;
    this.lblInvoiceNum.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblInvoiceNum.Location = new Point(562, 39);
    this.lblInvoiceNum.Name = "lblInvoiceNum";
    this.lblInvoiceNum.Size = new Size(74, 13);
    this.lblInvoiceNum.TabIndex = 245;
    this.lblInvoiceNum.Tag = (object) "1";
    this.lblInvoiceNum.Text = "lblInvoiceNum";
    this.lblInvoiceNum.TextAlign = ContentAlignment.MiddleLeft;
    this.Label29.AutoSize = true;
    this.Label29.BackColor = Color.Transparent;
    this.Label29.Location = new Point(459, 39);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(57, 13);
    this.Label29.TabIndex = 244;
    this.Label29.Tag = (object) "101";
    this.Label29.Text = "Invoice #:";
    this.Label29.TextAlign = ContentAlignment.MiddleLeft;
    this.lblControlNo.AutoSize = true;
    this.lblControlNo.BackColor = Color.Transparent;
    this.lblControlNo.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblControlNo.Location = new Point(562, 13);
    this.lblControlNo.Name = "lblControlNo";
    this.lblControlNo.Size = new Size(64 /*0x40*/, 13);
    this.lblControlNo.TabIndex = 243;
    this.lblControlNo.Tag = (object) "1";
    this.lblControlNo.Text = "lblControlNo";
    this.lblControlNo.TextAlign = ContentAlignment.MiddleLeft;
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Location = new Point(459, 13);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(62, 13);
    this.Label28.TabIndex = 242;
    this.Label28.Tag = (object) "101";
    this.Label28.Text = "Control No:";
    this.Label28.TextAlign = ContentAlignment.MiddleLeft;
    this.linkRelatedQuote.AutoSize = true;
    this.linkRelatedQuote.BackColor = Color.Transparent;
    this.linkRelatedQuote.Location = new Point(17, 201);
    this.linkRelatedQuote.Name = "linkRelatedQuote";
    this.linkRelatedQuote.Size = new Size(89, 13);
    this.linkRelatedQuote.TabIndex = 241;
    this.linkRelatedQuote.TabStop = true;
    this.linkRelatedQuote.Tag = (object) "101";
    this.linkRelatedQuote.Text = "View Policy Detail";
    this.lblPayeeName.AutoSize = true;
    this.lblPayeeName.BackColor = Color.Transparent;
    this.lblPayeeName.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblPayeeName.Location = new Point(132, 117);
    this.lblPayeeName.Name = "lblPayeeName";
    this.lblPayeeName.Size = new Size(253, 13);
    this.lblPayeeName.TabIndex = 238;
    this.lblPayeeName.Tag = (object) "1";
    this.lblPayeeName.Text = "lblPayeeName Superientendent of finance and more";
    this.lblPayeeName.TextAlign = ContentAlignment.MiddleLeft;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(43, 13);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(63 /*0x3F*/, 13);
    this.Label3.TabIndex = 230;
    this.Label3.Tag = (object) "101";
    this.Label3.Text = "Affidavit #:";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    this.Label14.AutoSize = true;
    this.Label14.BackColor = Color.Transparent;
    this.Label14.Location = new Point(43, 91);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(81, 13);
    this.Label14.TabIndex = 235;
    this.Label14.Tag = (object) "101";
    this.Label14.Text = "Filing Producer:";
    this.Label14.TextAlign = ContentAlignment.MiddleLeft;
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(43, 39);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(81, 13);
    this.Label4.TabIndex = 229;
    this.Label4.Tag = (object) "101";
    this.Label4.Text = "Policy Premium:";
    this.Label4.TextAlign = ContentAlignment.MiddleLeft;
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Location = new Point(43, 117);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(41, 13);
    this.Label22.TabIndex = 237;
    this.Label22.Tag = (object) "101";
    this.Label22.Text = "Payee:";
    this.Label22.TextAlign = ContentAlignment.MiddleLeft;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(43, 65);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(57, 13);
    this.Label1.TabIndex = 231;
    this.Label1.Tag = (object) "101";
    this.Label1.Text = "License #:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.lblAffidavitNumber.AutoSize = true;
    this.lblAffidavitNumber.BackColor = Color.Transparent;
    this.lblAffidavitNumber.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblAffidavitNumber.Location = new Point(132, 13);
    this.lblAffidavitNumber.Name = "lblAffidavitNumber";
    this.lblAffidavitNumber.Size = new Size(92, 13);
    this.lblAffidavitNumber.TabIndex = 232;
    this.lblAffidavitNumber.Tag = (object) "1";
    this.lblAffidavitNumber.Text = "lblAffidavitNumber";
    this.lblAffidavitNumber.TextAlign = ContentAlignment.MiddleLeft;
    this.lblFilingProducer.AutoSize = true;
    this.lblFilingProducer.BackColor = Color.Transparent;
    this.lblFilingProducer.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblFilingProducer.Location = new Point(133, 91);
    this.lblFilingProducer.Name = "lblFilingProducer";
    this.lblFilingProducer.Size = new Size(84, 13);
    this.lblFilingProducer.TabIndex = 236;
    this.lblFilingProducer.Tag = (object) "1";
    this.lblFilingProducer.Text = "lblFilingProducer";
    this.lblFilingProducer.TextAlign = ContentAlignment.MiddleLeft;
    this.lblPremium.AutoSize = true;
    this.lblPremium.BackColor = Color.Transparent;
    this.lblPremium.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblPremium.Location = new Point(132, 39);
    this.lblPremium.Name = "lblPremium";
    this.lblPremium.Size = new Size(57, 13);
    this.lblPremium.TabIndex = 233;
    this.lblPremium.Tag = (object) "1";
    this.lblPremium.Text = "lblPremium";
    this.lblPremium.TextAlign = ContentAlignment.MiddleLeft;
    this.lblLicenseNumber.AutoSize = true;
    this.lblLicenseNumber.BackColor = Color.Transparent;
    this.lblLicenseNumber.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblLicenseNumber.Location = new Point(133, 65);
    this.lblLicenseNumber.Name = "lblLicenseNumber";
    this.lblLicenseNumber.Size = new Size(91, 13);
    this.lblLicenseNumber.TabIndex = 234;
    this.lblLicenseNumber.Tag = (object) "1";
    this.lblLicenseNumber.Text = "lblLicenseNumber";
    this.lblLicenseNumber.TextAlign = ContentAlignment.MiddleLeft;
    ((Control) this.tabFilingStateInfo).Controls.Add((Control) this.Label10);
    ((Control) this.tabFilingStateInfo).Controls.Add((Control) this.dtCheckReqDate);
    ((Control) this.tabFilingStateInfo).Controls.Add((Control) this.lnkClearCheckRequestDate);
    ((Control) this.tabFilingStateInfo).Controls.Add((Control) this.Label23);
    ((Control) this.tabFilingStateInfo).Controls.Add((Control) this.lnkSetCheckRequestDate);
    ((Control) this.tabFilingStateInfo).Location = new Point(-10000, -10000);
    ((Control) this.tabFilingStateInfo).Name = "tabFilingStateInfo";
    ((Control) this.tabFilingStateInfo).Size = new Size(1087, 232);
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(515, 16 /*0x10*/);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(11, 13);
    this.Label10.TabIndex = 226;
    this.Label10.Tag = (object) "101";
    this.Label10.Text = "/";
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtCheckReqDate).Appearance = (AppearanceBase) appearance34;
    appearance35.AlphaLevel = (short) 14;
    appearance35.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance35.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance35.BackColorAlpha = (Alpha) 2;
    appearance35.BackGradientAlignment = (GradientAlignment) 4;
    appearance35.BackGradientStyle = (GradientStyle) 5;
    appearance35.BorderAlpha = (Alpha) 1;
    appearance35.BorderColor = Color.FromArgb(78, 122, 171);
    appearance35.ForeColor = Color.FromArgb(49, 85, 153);
    appearance35.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtCheckReqDate).ButtonAppearance = (AppearanceBase) appearance35;
    ((UltraDateTimeEditor) this.dtCheckReqDate).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtCheckReqDate).Location = new Point(273, 13);
    this.dtCheckReqDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtCheckReqDate).Name = "dtCheckReqDate";
    ((Control) this.dtCheckReqDate).Size = new Size(95, 20);
    ((Control) this.dtCheckReqDate).TabIndex = 204;
    ((Control) this.dtCheckReqDate).Tag = (object) "101";
    ((UltraControlBase) this.dtCheckReqDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtCheckReqDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtCheckReqDate).Value = (object) null;
    this.lnkClearCheckRequestDate.AutoSize = true;
    this.lnkClearCheckRequestDate.BackColor = Color.Transparent;
    this.lnkClearCheckRequestDate.Location = new Point(532, 16 /*0x10*/);
    this.lnkClearCheckRequestDate.Name = "lnkClearCheckRequestDate";
    this.lnkClearCheckRequestDate.Size = new Size(133, 13);
    this.lnkClearCheckRequestDate.TabIndex = 225;
    this.lnkClearCheckRequestDate.TabStop = true;
    this.lnkClearCheckRequestDate.Tag = (object) "101";
    this.lnkClearCheckRequestDate.Text = "Clear Check Request Date";
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Location = new Point(125, 16 /*0x10*/);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(88, 13);
    this.Label23.TabIndex = 203;
    this.Label23.Tag = (object) "101";
    this.Label23.Text = "Check Req. Date";
    this.Label23.TextAlign = ContentAlignment.MiddleRight;
    this.lnkSetCheckRequestDate.AutoSize = true;
    this.lnkSetCheckRequestDate.BackColor = Color.Transparent;
    this.lnkSetCheckRequestDate.Location = new Point(385, 16 /*0x10*/);
    this.lnkSetCheckRequestDate.Name = "lnkSetCheckRequestDate";
    this.lnkSetCheckRequestDate.Size = new Size(124, 13);
    this.lnkSetCheckRequestDate.TabIndex = 224 /*0xE0*/;
    this.lnkSetCheckRequestDate.TabStop = true;
    this.lnkSetCheckRequestDate.Tag = (object) "101";
    this.lnkSetCheckRequestDate.Text = "Set Check Request Date";
    ((Control) this.tabNotesExemptions).Controls.Add((Control) this.UltraGroupBox2);
    ((Control) this.tabNotesExemptions).Controls.Add((Control) this.UltraGroupBox1);
    ((Control) this.tabNotesExemptions).Controls.Add((Control) this.Label12);
    ((Control) this.tabNotesExemptions).Controls.Add((Control) this.Label13);
    ((Control) this.tabNotesExemptions).Location = new Point(-10000, -10000);
    ((Control) this.tabNotesExemptions).Name = "tabNotesExemptions";
    ((Control) this.tabNotesExemptions).Size = new Size(1087, 232);
    ((Control) this.UltraGroupBox2).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraGroupBox2.BackColorInternal = Color.Transparent;
    appearance36.BackColor = Color.White;
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance36;
    ((Control) this.UltraGroupBox2).Controls.Add((Control) this.txtNotes);
    ((Control) this.UltraGroupBox2).Location = new Point(388, 35);
    ((Control) this.UltraGroupBox2).Name = "UltraGroupBox2";
    ((Control) this.UltraGroupBox2).Size = new Size(594, 149);
    ((Control) this.UltraGroupBox2).TabIndex = 207;
    this.txtNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtNotes.BackColor = Color.White;
    this.txtNotes.BorderStyle = BorderStyle.None;
    this.txtNotes.ForeColor = Color.Black;
    this.txtNotes.Location = new Point(6, 13);
    this.txtNotes.MaxLength = 3500;
    this.txtNotes.Name = "txtNotes";
    this.txtNotes.ReadOnly = true;
    this.txtNotes.Size = new Size(584, 128 /*0x80*/);
    this.txtNotes.TabIndex = 0;
    this.txtNotes.Text = "";
    ((Control) this.UltraGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    this.UltraGroupBox1.BackColorInternal = Color.Transparent;
    appearance37.BackColor = Color.White;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance37;
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.txtExRe);
    ((Control) this.UltraGroupBox1).Location = new Point(7, 35);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(375, 149);
    ((Control) this.UltraGroupBox1).TabIndex = 206;
    this.txtExRe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtExRe.BackColor = Color.White;
    this.txtExRe.BorderStyle = BorderStyle.None;
    this.txtExRe.ForeColor = Color.Black;
    this.txtExRe.Location = new Point(3, 13);
    this.txtExRe.MaxLength = 3500;
    this.txtExRe.Name = "txtExRe";
    this.txtExRe.ReadOnly = true;
    this.txtExRe.Size = new Size(366, 128 /*0x80*/);
    this.txtExRe.TabIndex = 0;
    this.txtExRe.Text = "";
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Location = new Point(11, 18);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(64 /*0x40*/, 13);
    this.Label12.TabIndex = 201;
    this.Label12.Tag = (object) "101";
    this.Label12.Text = "User Notes:";
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(385, 18);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(66, 13);
    this.Label13.TabIndex = 200;
    this.Label13.Tag = (object) "101";
    this.Label13.Text = "Filing Notes:";
    this.err.ContainerControl = (ContainerControl) this;
    this.daGetOtherPolicyFilingInfo.DeleteCommand = this.SqlDeleteCommand;
    this.daGetOtherPolicyFilingInfo.InsertCommand = this.SqlInsertCommand;
    this.daGetOtherPolicyFilingInfo.SelectCommand = this.DbSelectCommand1;
    this.daGetOtherPolicyFilingInfo.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblPolicyFilingManagementInfo", new DataColumnMapping[12]
      {
        new DataColumnMapping("OptionFeeID", "OptionFeeID"),
        new DataColumnMapping("DSFFillDate", "DSFFillDate"),
        new DataColumnMapping("ExemptionResearch", "ExemptionResearch"),
        new DataColumnMapping("Notes", "Notes"),
        new DataColumnMapping("DecPageFiledDate", "DecPageFiledDate"),
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("CheckRequestDate", "CheckRequestDate"),
        new DataColumnMapping("MonthlyReportDue", "MonthlyReportDue"),
        new DataColumnMapping("QuarterlyReportDue", "QuarterlyReportDue"),
        new DataColumnMapping("SemiAnnualReportDue", "SemiAnnualReportDue"),
        new DataColumnMapping("AnnualReportDue", "AnnualReportDue"),
        new DataColumnMapping("FilingDone", "FilingDone")
      })
    });
    this.daGetOtherPolicyFilingInfo.UpdateCommand = this.SqlUpdateCommand;
    this.SqlDeleteCommand.CommandText = "DELETE FROM [dbo].[tblPolicyFilingManagementInfo] WHERE (([ID] = @Original_ID))";
    this.SqlDeleteCommand.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand.CommandText = componentResourceManager.GetString("SqlInsertCommand.CommandText");
    this.SqlInsertCommand.Parameters.AddRange((Array) new DbParameter[15]
    {
      DefaultDatabase.CreateParameter("@OptionFeeID", SqlDbType.Int, 4, "OptionFeeID"),
      DefaultDatabase.CreateParameter("@DSFFillDate", SqlDbType.DateTime, 8, "DSFFillDate"),
      DefaultDatabase.CreateParameter("@ExemptionResearch", SqlDbType.VarChar, 3500, "ExemptionResearch"),
      DefaultDatabase.CreateParameter("@Notes", SqlDbType.VarChar, 3500, "Notes"),
      DefaultDatabase.CreateParameter("@DecPageFiledDate", SqlDbType.DateTime, 8, "DecPageFiledDate"),
      DefaultDatabase.CreateParameter("@CheckRequestDate", SqlDbType.DateTime, 8, "CheckRequestDate"),
      DefaultDatabase.CreateParameter("@MonthlyReportDue", SqlDbType.DateTime, 8, "MonthlyReportDue"),
      DefaultDatabase.CreateParameter("@QuarterlyReportDue", SqlDbType.DateTime, 8, "QuarterlyReportDue"),
      DefaultDatabase.CreateParameter("@SemiAnnualReportDue", SqlDbType.DateTime, 8, "SemiAnnualReportDue"),
      DefaultDatabase.CreateParameter("@AnnualReportDue", SqlDbType.DateTime, 8, "AnnualReportDue"),
      DefaultDatabase.CreateParameter("@FilingDone", SqlDbType.DateTime, 8, "FilingDone"),
      DefaultDatabase.CreateParameter("@FireTaxDue", SqlDbType.DateTime, 8, "FireTaxDue"),
      DefaultDatabase.CreateParameter("@RevenueSurchargeDue", SqlDbType.DateTime, 8, "RevenueSurchargeDue"),
      DefaultDatabase.CreateParameter("@ControlsFiledDate", SqlDbType.DateTime, 8, "ControlsFiledDate"),
      DefaultDatabase.CreateParameter("@MunicipalFilingDue", SqlDbType.DateTime, 8, "MunicipalFilingDue")
    });
    this.DbSelectCommand1.CommandText = componentResourceManager.GetString("DbSelectCommand1.CommandText");
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[1]
    {
      DefaultDatabase.CreateParameter("@OptionFeeID", SqlDbType.Int, 4, "OptionFeeID")
    });
    this.SqlUpdateCommand.CommandText = componentResourceManager.GetString("SqlUpdateCommand.CommandText");
    this.SqlUpdateCommand.Parameters.AddRange((Array) new DbParameter[17]
    {
      DefaultDatabase.CreateParameter("@OptionFeeID", SqlDbType.Int, 4, "OptionFeeID"),
      DefaultDatabase.CreateParameter("@DSFFillDate", SqlDbType.DateTime, 8, "DSFFillDate"),
      DefaultDatabase.CreateParameter("@ExemptionResearch", SqlDbType.VarChar, 3500, "ExemptionResearch"),
      DefaultDatabase.CreateParameter("@Notes", SqlDbType.VarChar, 3500, "Notes"),
      DefaultDatabase.CreateParameter("@DecPageFiledDate", SqlDbType.DateTime, 8, "DecPageFiledDate"),
      DefaultDatabase.CreateParameter("@CheckRequestDate", SqlDbType.DateTime, 8, "CheckRequestDate"),
      DefaultDatabase.CreateParameter("@MonthlyReportDue", SqlDbType.DateTime, 8, "MonthlyReportDue"),
      DefaultDatabase.CreateParameter("@QuarterlyReportDue", SqlDbType.DateTime, 8, "QuarterlyReportDue"),
      DefaultDatabase.CreateParameter("@SemiAnnualReportDue", SqlDbType.DateTime, 8, "SemiAnnualReportDue"),
      DefaultDatabase.CreateParameter("@AnnualReportDue", SqlDbType.DateTime, 8, "AnnualReportDue"),
      DefaultDatabase.CreateParameter("@FilingDone", SqlDbType.DateTime, 8, "FilingDone"),
      DefaultDatabase.CreateParameter("@FireTaxDue", SqlDbType.DateTime, 8, "FireTaxDue"),
      DefaultDatabase.CreateParameter("@RevenueSurchargeDue", SqlDbType.DateTime, 8, "RevenueSurchargeDue"),
      DefaultDatabase.CreateParameter("@ControlsFiledDate", SqlDbType.DateTime, 8, "ControlsFiledDate"),
      DefaultDatabase.CreateParameter("@MunicipalFilingDue", SqlDbType.DateTime, 8, "MunicipalFilingDue"),
      DefaultDatabase.CreateParameter("@Original_ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null),
      DefaultDatabase.CreateParameter("@ID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ID", DataRowVersion.Original, (object) null)
    });
    ((Control) this.UltraFiling).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraFiling).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraFiling).Controls.Add((Control) this.tabSearch);
    ((Control) this.UltraFiling).Controls.Add((Control) this.tabFilingStateInfo);
    ((Control) this.UltraFiling).Controls.Add((Control) this.tabNotesExemptions);
    ((Control) this.UltraFiling).Controls.Add((Control) this.tabFilingPolicyInfo);
    ((Control) this.UltraFiling).Location = new Point(4, 310);
    ((Control) this.UltraFiling).Name = "UltraFiling";
    ((UltraTabControlBase) this.UltraFiling).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraFiling).Size = new Size(1089, 259);
    ((Control) this.UltraFiling).TabIndex = 198;
    ((UltraTabControlBase) this.UltraFiling).TabLayoutStyle = (TabLayoutStyle) 1;
    appearance38.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance39.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance38;
    ultraTab1.TabPage = this.tabSearch;
    ultraTab1.Text = "Search";
    appearance39.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance40.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance39;
    ultraTab2.TabPage = this.tabFilingPolicyInfo;
    ultraTab2.Text = "Filing Information";
    appearance40.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance41.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance40;
    ultraTab3.TabPage = this.tabFilingStateInfo;
    ultraTab3.Text = "State Specific  Info";
    appearance41.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance42.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance41;
    ultraTab4.TabPage = this.tabNotesExemptions;
    ultraTab4.Text = "Notes";
    ((UltraTabControlBase) this.UltraFiling).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraTabControlBase) this.UltraFiling).TabSize = new Size(135, 25);
    ((UltraTabControlBase) this.UltraFiling).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.btnSave);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(1087, 232);
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelPleaseWait.ContentAreaAppearance = (AppearanceBase) appearance42;
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.Label27);
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.PictureBox1);
    ((Control) this.panelPleaseWait).Location = new Point(216, 101);
    ((Control) this.panelPleaseWait).Name = "panelPleaseWait";
    ((Control) this.panelPleaseWait).Size = new Size(345, 84);
    ((Control) this.panelPleaseWait).TabIndex = 199;
    ((Control) this.panelPleaseWait).Visible = false;
    this.Label27.Font = new Font("Tahoma", 11f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label27.Location = new Point(55, 32 /*0x20*/);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(280, 21);
    this.Label27.TabIndex = 1;
    this.Label27.Text = "Please wait while the fees are loaded ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(17, 26);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    ((Control) this.gridFilingInformation).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridFilingInformation).DataMember = "PolicyFilingInformation";
    ((UltraGridBase) this.gridFilingInformation).DataSource = (object) this.ds;
    appearance43.BackColor = Color.White;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance43.ForeColor = Color.SlateGray;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Appearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Insured";
    ultraGridColumn5.Header.VisiblePosition = 7;
    ultraGridColumn5.Width = 107;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Affidavit #";
    ultraGridColumn6.Header.VisiblePosition = 9;
    ultraGridColumn6.Width = 72;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Header.VisiblePosition = 17;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 88;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Filing Producer";
    ultraGridColumn8.Header.VisiblePosition = 18;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 113;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance44).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance44;
    ultraGridColumn9.Format = "c";
    ultraGridColumn9.Header.VisiblePosition = 19;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 86;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Tax Due";
    ultraGridColumn10.Header.VisiblePosition = 11;
    ultraGridColumn10.Width = 70;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = " Filing Due ";
    ultraGridColumn11.Header.VisiblePosition = 12;
    ultraGridColumn11.Width = 71;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "State";
    ultraGridColumn12.Header.VisiblePosition = 40;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 50;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Control #";
    ultraGridColumn13.Header.VisiblePosition = 22;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 8;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Policy #";
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn14.Width = 75;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.Header.VisiblePosition = 20;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 71;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance45).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance45;
    ultraGridColumn16.Format = "c";
    ((AppearanceBase) appearance46).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance46;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Tax Due $$";
    ultraGridColumn16.Header.VisiblePosition = 13;
    ultraGridColumn16.Width = 91;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance47).TextHAlignAsString = "Right";
    ultraGridColumn17.CellAppearance = (AppearanceBase) appearance47;
    ultraGridColumn17.Format = "c";
    ((AppearanceBase) appearance48).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn17.Header).Appearance = (AppearanceBase) appearance48;
    ((HeaderBase) ultraGridColumn17.Header).Caption = " Fees Due $$";
    ultraGridColumn17.Header.VisiblePosition = 14;
    ultraGridColumn17.Width = 85;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Trans Type";
    ultraGridColumn18.Header.VisiblePosition = 3;
    ultraGridColumn18.Width = 70;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Trans. Eff";
    ultraGridColumn19.Header.VisiblePosition = 4;
    ultraGridColumn19.Width = 80 /*0x50*/;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.Header.VisiblePosition = 25;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 87;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.Header.VisiblePosition = 21;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 76;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance49).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn22.Header).Appearance = (AppearanceBase) appearance49;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Check Requested";
    ultraGridColumn22.Header.VisiblePosition = 23;
    ultraGridColumn22.Hidden = true;
    ultraGridColumn22.Width = 44;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Trans Date";
    ultraGridColumn23.Header.VisiblePosition = 24;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 130;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn24.Header.VisiblePosition = 41;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 50;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Fee";
    ultraGridColumn25.Header.VisiblePosition = 0;
    ultraGridColumn25.Width = 89;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance50).TextHAlignAsString = "Right";
    ultraGridColumn26.CellAppearance = (AppearanceBase) appearance50;
    ultraGridColumn26.Format = "c";
    ((HeaderBase) ultraGridColumn26.Header).Caption = "State Prem$";
    ultraGridColumn26.Header.VisiblePosition = 10;
    ultraGridColumn26.Width = 76;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn27.Header.VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 80 /*0x50*/;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn28.Header.VisiblePosition = 2;
    ultraGridColumn28.Width = 106;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Invoice #";
    ultraGridColumn29.Header.VisiblePosition = 27;
    ultraGridColumn29.Width = 73;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn30.Header.VisiblePosition = 28;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 73;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn31.Header.VisiblePosition = 29;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 64 /*0x40*/;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn32.Header.VisiblePosition = 42;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 17;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn33.Header.VisiblePosition = 30;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 96 /*0x60*/;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn34.Header.VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 73;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn35.Header.VisiblePosition = 43;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 17;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn36.Header.VisiblePosition = 32 /*0x20*/;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 63 /*0x3F*/;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn37.Header.VisiblePosition = 33;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 67;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn38.Header.VisiblePosition = 34;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 73;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn39.Header.VisiblePosition = 35;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 61;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn40.Header.VisiblePosition = 36;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 47;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn41.Header.VisiblePosition = 37;
    ultraGridColumn41.Hidden = true;
    ultraGridColumn41.Width = 47;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn42.Header.VisiblePosition = 38;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 63 /*0x3F*/;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn43.Header.VisiblePosition = 39;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 123;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn44.Header).Caption = "Paid";
    ultraGridColumn44.Header.VisiblePosition = 6;
    ultraGridColumn44.Width = 67;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn45.Header.VisiblePosition = 8;
    ultraGridColumn45.Width = 76;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn46.Header).Caption = "Date Filed";
    ultraGridColumn46.Header.VisiblePosition = 5;
    ultraGridColumn46.Width = 66;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Caption = "Taxable Fee";
    ultraGridColumn47.Header.VisiblePosition = 15;
    ultraGridColumn47.Width = 82;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn48.Header.VisiblePosition = 45;
    ultraGridColumn48.Width = 65;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn49.Format = "c";
    ((HeaderBase) ultraGridColumn49.Header).Caption = "Taxable Fees Amt";
    ultraGridColumn49.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn49.Width = 113;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn50.Header.VisiblePosition = 44;
    ultraGridColumn50.Width = 85;
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    ultraGridColumn51.CellAppearance = (AppearanceBase) appearance51;
    ultraGridColumn51.Format = "c";
    ((HeaderBase) ultraGridColumn51.Header).Caption = "Total Prem$";
    ultraGridColumn51.Header.VisiblePosition = 46;
    ultraGridColumn52.Header.VisiblePosition = 47;
    ultraGridBand2.Columns.AddRange(new object[48 /*0x30*/]
    {
      (object) ultraGridColumn5,
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
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52
    });
    ultraGridBand2.GroupHeadersVisible = false;
    ultraGridBand2.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand2.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridBand2.Override.SelectTypeRow = (SelectType) 3;
    appearance52.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance52).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance52;
    summarySettings1.DisplayFormat = "{0:c}";
    summarySettings1.GroupBySummaryValueAppearance = (AppearanceBase) appearance53;
    appearance54.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance54;
    summarySettings2.DisplayFormat = "{0:c}";
    summarySettings2.GroupBySummaryValueAppearance = (AppearanceBase) appearance55;
    appearance56.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance56;
    summarySettings3.DisplayFormat = "{0:c}";
    summarySettings3.GroupBySummaryValueAppearance = (AppearanceBase) appearance57;
    appearance58.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance58;
    summarySettings4.DisplayFormat = "{0:c}";
    summarySettings4.GroupBySummaryValueAppearance = (AppearanceBase) appearance59;
    ultraGridBand2.Summaries.AddRange(new SummarySettings[4]
    {
      summarySettings1,
      summarySettings2,
      summarySettings3,
      summarySettings4
    });
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance60.BackColor = Color.LightSteelBlue;
    appearance60.FontData.SizeInPoints = 10f;
    appearance60.ForeColor = Color.Black;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance60;
    appearance61.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance61.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance61.ForeColor = Color.Black;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance61;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance62.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance63.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance63).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance64.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance64;
    appearance65.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance65;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.RowSpacingAfter = 1;
    appearance66.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance66.ForeColor = Color.Black;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance66;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.SummaryDisplayArea = (SummaryDisplayAreas) 16 /*0x10*/;
    ((AppearanceBase) appearance67).TextHAlignAsString = "Right";
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance67;
    ((AppearanceBase) appearance68).TextHAlignAsString = "Right";
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.SummaryFooterCaptionAppearance = (AppearanceBase) appearance68;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.gridFilingInformation).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridFilingInformation).Location = new Point(4, 1);
    ((Control) this.gridFilingInformation).Name = "gridFilingInformation";
    ((Control) this.gridFilingInformation).Size = new Size(1089, 303);
    ((Control) this.gridFilingInformation).TabIndex = 1;
    ((UltraControlBase) this.gridFilingInformation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridFilingInformation).UseOsThemes = (DefaultableBoolean) 2;
    this.ttToolTip.BackColor = Color.Transparent;
    this.AutoScaleMode = AutoScaleMode.None;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1097, 572);
    this.Controls.Add((Control) this.panelPleaseWait);
    this.Controls.Add((Control) this.UltraFiling);
    this.Controls.Add((Control) this.gridFilingInformation);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormFilingInformation);
    this.Text = "Filing Information";
    ((Control) this.tabSearch).ResumeLayout(false);
    ((Control) this.tabSearch).PerformLayout();
    ((ISupportInitialize) this.btnAggregateReport).EndInit();
    this.GroupBox3.ResumeLayout(false);
    ((ISupportInitialize) this.chkHidePolicyStatus).EndInit();
    ((ISupportInitialize) this.chkHideAffidavitNumber).EndInit();
    ((ISupportInitialize) this.chkHideInsured).EndInit();
    ((ISupportInitialize) this.chkHideUnderwriter).EndInit();
    ((ISupportInitialize) this.chkHideTransactionType).EndInit();
    ((ISupportInitialize) this.chkHideFeeColumn).EndInit();
    ((ISupportInitialize) this.chkHideCarrierColumn).EndInit();
    ((ISupportInitialize) this.chkHidePolicyNumberColumn).EndInit();
    ((ISupportInitialize) this.btnExcelExport).EndInit();
    ((ISupportInitialize) this.chkDateFiledNULL).EndInit();
    this.GroupBox2.ResumeLayout(false);
    this.GroupBox2.PerformLayout();
    ((ISupportInitialize) this.dtpRevenueDateFrom).EndInit();
    ((ISupportInitialize) this.dtpReveneDateTo).EndInit();
    ((ISupportInitialize) this.chkHideOffsets).EndInit();
    ((ISupportInitialize) this.chkTaxableFee).EndInit();
    this.GroupBox1.ResumeLayout(false);
    this.GroupBox1.PerformLayout();
    ((ISupportInitialize) this.dtpPolicyEffFrom).EndInit();
    ((ISupportInitialize) this.dtpPolEffectiveTo).EndInit();
    ((ISupportInitialize) this.lstIssuingOffices).EndInit();
    ((ISupportInitialize) this.txtFilingProducer).EndInit();
    this.grpFee.ResumeLayout(false);
    ((ISupportInitialize) this.cboChargeName).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtInsuredName).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.txtPolicyNo).EndInit();
    ((ISupportInitialize) this.txtControlNo).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.btnUndoOffset).EndInit();
    ((ISupportInitialize) this.btnOffset).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((Control) this.tabFilingPolicyInfo).ResumeLayout(false);
    ((Control) this.tabFilingPolicyInfo).PerformLayout();
    ((Control) this.tabFilingStateInfo).ResumeLayout(false);
    ((Control) this.tabFilingStateInfo).PerformLayout();
    ((ISupportInitialize) this.dtCheckReqDate).EndInit();
    ((Control) this.tabNotesExemptions).ResumeLayout(false);
    ((Control) this.tabNotesExemptions).PerformLayout();
    ((ISupportInitialize) this.UltraGroupBox2).EndInit();
    ((Control) this.UltraGroupBox2).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.UltraFiling).EndInit();
    ((Control) this.UltraFiling).ResumeLayout(false);
    ((ISupportInitialize) this.panelPleaseWait).EndInit();
    ((Control) this.panelPleaseWait).ResumeLayout(false);
    ((Control) this.panelPleaseWait).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.gridFilingInformation).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsFilingPolicyInfo ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtPolicyNo")]
  private virtual MGATextBox txtPolicyNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGASimpleComboBox cboState
  {
    get => this._cboState;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboState_ValueChanged);
      MGASimpleComboBox cboState1 = this._cboState;
      if (cboState1 != null)
        ((UltraCombo) cboState1).ValueChanged -= eventHandler;
      this._cboState = value;
      MGASimpleComboBox cboState2 = this._cboState;
      if (cboState2 == null)
        return;
      ((UltraCombo) cboState2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtInsuredName")]
  private virtual MGATextBox txtInsuredName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtControlNo")]
  private virtual MGATextBox txtControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetOtherPolicyFilingInfo")]
  private virtual DbDataAdapter daGetOtherPolicyFilingInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DbSelectCommand1")]
  private virtual DbCommand DbSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click_1);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  private virtual MGAComboBox cboChargeName
  {
    get => this._cboChargeName;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboChargeName_BeforeDropDown);
      MGAComboBox cboChargeName1 = this._cboChargeName;
      if (cboChargeName1 != null)
        ((UltraCombo) cboChargeName1).BeforeDropDown -= cancelEventHandler;
      this._cboChargeName = value;
      MGAComboBox cboChargeName2 = this._cboChargeName;
      if (cboChargeName2 == null)
        return;
      ((UltraCombo) cboChargeName2).BeforeDropDown += cancelEventHandler;
    }
  }

  private virtual LinkLabel lnkClearSearch
  {
    get => this._lnkClearSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkClearSearch_LinkClicked);
      LinkLabel lnkClearSearch1 = this._lnkClearSearch;
      if (lnkClearSearch1 != null)
        lnkClearSearch1.LinkClicked -= clickedEventHandler;
      this._lnkClearSearch = value;
      LinkLabel lnkClearSearch2 = this._lnkClearSearch;
      if (lnkClearSearch2 == null)
        return;
      lnkClearSearch2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel linkRelatedQuote
  {
    get => this._linkRelatedQuote;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkRelatedQuote_LinkClicked);
      LinkLabel linkRelatedQuote1 = this._linkRelatedQuote;
      if (linkRelatedQuote1 != null)
        linkRelatedQuote1.LinkClicked -= clickedEventHandler;
      this._linkRelatedQuote = value;
      LinkLabel linkRelatedQuote2 = this._linkRelatedQuote;
      if (linkRelatedQuote2 == null)
        return;
      linkRelatedQuote2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("rbBoth")]
  private virtual RadioButton rbBoth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbNotPaid")]
  private virtual RadioButton rbNotPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbPaid")]
  private virtual RadioButton rbPaid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFilingProducer")]
  private virtual MGATextBox txtFilingProducer { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lstIssuingOffices")]
  private virtual MGACheckedListBox lstIssuingOffices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnOffset
  {
    get => this._btnOffset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOffset_Click);
      MGAButton btnOffset1 = this._btnOffset;
      if (btnOffset1 != null)
        ((Control) btnOffset1).Click -= eventHandler;
      this._btnOffset = value;
      MGAButton btnOffset2 = this._btnOffset;
      if (btnOffset2 == null)
        return;
      ((Control) btnOffset2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnSave
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

  protected virtual UltraGrid gridFilingInformation
  {
    get => this._gridFilingInformation;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridFilingInformation_AfterRowActivate);
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.gridFilingInformation_InitializeRow);
      UltraGrid filingInformation1 = this._gridFilingInformation;
      if (filingInformation1 != null)
      {
        filingInformation1.AfterRowActivate -= eventHandler;
        filingInformation1.InitializeRow -= initializeRowEventHandler;
      }
      this._gridFilingInformation = value;
      UltraGrid filingInformation2 = this._gridFilingInformation;
      if (filingInformation2 == null)
        return;
      filingInformation2.AfterRowActivate += eventHandler;
      filingInformation2.InitializeRow += initializeRowEventHandler;
    }
  }

  [field: AccessedThroughProperty("dtpPolicyEffFrom")]
  private virtual MGADateTimePicker dtpPolicyEffFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpPolEffectiveTo")]
  private virtual MGADateTimePicker dtpPolEffectiveTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnUndoOffset
  {
    get => this._btnUndoOffset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnUndoOffset_Click);
      MGAButton btnUndoOffset1 = this._btnUndoOffset;
      if (btnUndoOffset1 != null)
        ((Control) btnUndoOffset1).Click -= eventHandler;
      this._btnUndoOffset = value;
      MGAButton btnUndoOffset2 = this._btnUndoOffset;
      if (btnUndoOffset2 == null)
        return;
      ((Control) btnUndoOffset2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkTaxableFee")]
  private virtual MGACheckBox chkTaxableFee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkHideOffsets")]
  private virtual MGACheckBox chkHideOffsets { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraFiling")]
  protected virtual UltraTabControl UltraFiling { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  private virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpRevenueDateFrom")]
  private virtual MGADateTimePicker dtpRevenueDateFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  private virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  private virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpReveneDateTo")]
  private virtual MGADateTimePicker dtpReveneDateTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkDateFiledNULL")]
  private virtual MGACheckBox chkDateFiledNULL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnExcelExport
  {
    get => this._btnExcelExport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnExcelExport_Click);
      MGAButton btnExcelExport1 = this._btnExcelExport;
      if (btnExcelExport1 != null)
        ((Control) btnExcelExport1).Click -= eventHandler;
      this._btnExcelExport = value;
      MGAButton btnExcelExport2 = this._btnExcelExport;
      if (btnExcelExport2 == null)
        return;
      ((Control) btnExcelExport2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblTotalTaxableFeesAmount")]
  private virtual Label lblTotalTaxableFeesAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label36")]
  private virtual Label Label36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalFeesDue")]
  private virtual Label lblTotalFeesDue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalTaxDue")]
  private virtual Label lblTotalTaxDue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  private virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTotalStatePremium")]
  private virtual Label lblTotalStatePremium { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  private virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGACheckBox chkHidePolicyNumberColumn
  {
    get => this._chkHidePolicyNumberColumn;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHidePolicyNumberColumn_CheckedChanged);
      MGACheckBox policyNumberColumn1 = this._chkHidePolicyNumberColumn;
      if (policyNumberColumn1 != null)
        ((UltraToggleEditorBase) policyNumberColumn1).CheckedChanged -= eventHandler;
      this._chkHidePolicyNumberColumn = value;
      MGACheckBox policyNumberColumn2 = this._chkHidePolicyNumberColumn;
      if (policyNumberColumn2 == null)
        return;
      ((UltraToggleEditorBase) policyNumberColumn2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkHideCarrierColumn
  {
    get => this._chkHideCarrierColumn;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideCarrierColumn_CheckedChanged);
      MGACheckBox hideCarrierColumn1 = this._chkHideCarrierColumn;
      if (hideCarrierColumn1 != null)
        ((UltraToggleEditorBase) hideCarrierColumn1).CheckedChanged -= eventHandler;
      this._chkHideCarrierColumn = value;
      MGACheckBox hideCarrierColumn2 = this._chkHideCarrierColumn;
      if (hideCarrierColumn2 == null)
        return;
      ((UltraToggleEditorBase) hideCarrierColumn2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkHideFeeColumn
  {
    get => this._chkHideFeeColumn;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideFeeColumn_CheckedChanged);
      MGACheckBox chkHideFeeColumn1 = this._chkHideFeeColumn;
      if (chkHideFeeColumn1 != null)
        ((UltraToggleEditorBase) chkHideFeeColumn1).CheckedChanged -= eventHandler;
      this._chkHideFeeColumn = value;
      MGACheckBox chkHideFeeColumn2 = this._chkHideFeeColumn;
      if (chkHideFeeColumn2 == null)
        return;
      ((UltraToggleEditorBase) chkHideFeeColumn2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkHideTransactionType
  {
    get => this._chkHideTransactionType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideTransactionType_CheckedChanged);
      MGACheckBox hideTransactionType1 = this._chkHideTransactionType;
      if (hideTransactionType1 != null)
        ((UltraToggleEditorBase) hideTransactionType1).CheckedChanged -= eventHandler;
      this._chkHideTransactionType = value;
      MGACheckBox hideTransactionType2 = this._chkHideTransactionType;
      if (hideTransactionType2 == null)
        return;
      ((UltraToggleEditorBase) hideTransactionType2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("GroupBox3")]
  protected virtual GroupBox GroupBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  protected virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  protected virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  protected virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtExRe")]
  protected virtual RichTextBox txtExRe { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGroupBox2")]
  protected virtual UltraGroupBox UltraGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtNotes")]
  protected virtual RichTextBox txtNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtCheckReqDate")]
  protected virtual MGADateTimePicker dtCheckReqDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label23")]
  protected virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel lnkClearCheckRequestDate
  {
    get => this._lnkClearCheckRequestDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkClearCheckRequestDate_LinkClicked);
      LinkLabel checkRequestDate1 = this._lnkClearCheckRequestDate;
      if (checkRequestDate1 != null)
        checkRequestDate1.LinkClicked -= clickedEventHandler;
      this._lnkClearCheckRequestDate = value;
      LinkLabel checkRequestDate2 = this._lnkClearCheckRequestDate;
      if (checkRequestDate2 == null)
        return;
      checkRequestDate2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkSetCheckRequestDate
  {
    get => this._lnkSetCheckRequestDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSetCheckRequestDate_LinkClicked);
      LinkLabel checkRequestDate1 = this._lnkSetCheckRequestDate;
      if (checkRequestDate1 != null)
        checkRequestDate1.LinkClicked -= clickedEventHandler;
      this._lnkSetCheckRequestDate = value;
      LinkLabel checkRequestDate2 = this._lnkSetCheckRequestDate;
      if (checkRequestDate2 == null)
        return;
      checkRequestDate2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label10")]
  protected virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpFee")]
  protected virtual GroupBox grpFee { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabSearch")]
  protected virtual UltraTabPageControl tabSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabNotesExemptions")]
  protected virtual UltraTabPageControl tabNotesExemptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGACheckBox chkHideUnderwriter
  {
    get => this._chkHideUnderwriter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideUnderwriter_CheckedChanged);
      MGACheckBox chkHideUnderwriter1 = this._chkHideUnderwriter;
      if (chkHideUnderwriter1 != null)
        ((UltraToggleEditorBase) chkHideUnderwriter1).CheckedChanged -= eventHandler;
      this._chkHideUnderwriter = value;
      MGACheckBox chkHideUnderwriter2 = this._chkHideUnderwriter;
      if (chkHideUnderwriter2 == null)
        return;
      ((UltraToggleEditorBase) chkHideUnderwriter2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("tabFilingStateInfo")]
  protected virtual UltraTabPageControl tabFilingStateInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelPleaseWait")]
  protected virtual UltraGroupBox panelPleaseWait { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  protected virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  protected virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("tabFilingPolicyInfo")]
  protected virtual UltraTabPageControl tabFilingPolicyInfo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGACheckBox chkHideInsured
  {
    get => this._chkHideInsured;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideInsured_CheckedChanged);
      MGACheckBox chkHideInsured1 = this._chkHideInsured;
      if (chkHideInsured1 != null)
        ((UltraToggleEditorBase) chkHideInsured1).CheckedChanged -= eventHandler;
      this._chkHideInsured = value;
      MGACheckBox chkHideInsured2 = this._chkHideInsured;
      if (chkHideInsured2 == null)
        return;
      ((UltraToggleEditorBase) chkHideInsured2).CheckedChanged += eventHandler;
    }
  }

  protected virtual MGACheckBox chkHideAffidavitNumber
  {
    get => this._chkHideAffidavitNumber;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHideAffidavitNumber_CheckedChanged);
      MGACheckBox hideAffidavitNumber1 = this._chkHideAffidavitNumber;
      if (hideAffidavitNumber1 != null)
        ((UltraToggleEditorBase) hideAffidavitNumber1).CheckedChanged -= eventHandler;
      this._chkHideAffidavitNumber = value;
      MGACheckBox hideAffidavitNumber2 = this._chkHideAffidavitNumber;
      if (hideAffidavitNumber2 == null)
        return;
      ((UltraToggleEditorBase) hideAffidavitNumber2).CheckedChanged += eventHandler;
    }
  }

  protected virtual MGACheckBox chkHidePolicyStatus
  {
    get => this._chkHidePolicyStatus;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.chkHidePolicyStatus_CheckedChanged);
      MGACheckBox hidePolicyStatus1 = this._chkHidePolicyStatus;
      if (hidePolicyStatus1 != null)
        ((UltraToggleEditorBase) hidePolicyStatus1).CheckedChanged -= eventHandler;
      this._chkHidePolicyStatus = value;
      MGACheckBox hidePolicyStatus2 = this._chkHidePolicyStatus;
      if (hidePolicyStatus2 == null)
        return;
      ((UltraToggleEditorBase) hidePolicyStatus2).CheckedChanged += eventHandler;
    }
  }

  protected virtual MGAButton btnAggregateReport
  {
    get => this._btnAggregateReport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAggregateReport_Click);
      MGAButton btnAggregateReport1 = this._btnAggregateReport;
      if (btnAggregateReport1 != null)
        ((Control) btnAggregateReport1).Click -= eventHandler;
      this._btnAggregateReport = value;
      MGAButton btnAggregateReport2 = this._btnAggregateReport;
      if (btnAggregateReport2 == null)
        return;
      ((Control) btnAggregateReport2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label43")]
  protected virtual Label Label43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTaxDue_Pol")]
  protected virtual Label lblTaxDue_Pol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTaxableFeeAmount_Pol_Amount")]
  protected virtual Label lblTaxableFeeAmount_Pol_Amount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblStatePremium_Pol")]
  protected virtual Label lblStatePremium_Pol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTaxableFeeAmount_Pol")]
  protected virtual Label lblTaxableFeeAmount_Pol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblStatePremiumAmount_Pol")]
  protected virtual Label lblStatePremiumAmount_Pol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblFeesDueAmount_Pol")]
  protected virtual Label lblFeesDueAmount_Pol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblTaxDueAmount_Pol")]
  protected virtual Label lblTaxDueAmount_Pol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblFeesDue_Pol")]
  protected virtual Label lblFeesDue_Pol { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ttToolTip")]
  protected virtual ToolTip ttToolTip { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormFilingInformation()
  {
    this.Load += new EventHandler(this.FormFilingInformation_Load);
    this._ID = int.MinValue;
    this._guidsToString = string.Empty;
    this._defaultAllIssuingLocations = false;
    this._gridlayout = new MemoryStream();
    this._quoteDic = new Dictionary<int, FormFilingInformation.QuoteStructure>();
    this.InitializeComponent();
    Utility.SetDataAdapterConnections(this.daGetOtherPolicyFilingInfo, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
  }

  public object StateID => ((UltraCombo) this.cboState).Value;

  public bool CanCreateNewNote => this._activeQuote != null && this._activeQuote.CanCreateNewNote;

  string IRecreatableEntity.EntityName
  {
    get => this._activeQuote != null ? this._activeQuote.EntityName : "EntityName Error";
  }

  Guid IRecreatableEntity.EntityGuid
  {
    get => this._activeQuote != null ? this._activeQuote.EntityGuid : Guid.Empty;
  }

  string IRecreatableEntity.FriendlyEntityName
  {
    get
    {
      return this._activeQuote != null ? this._activeQuote.FriendlyEntityName : "FriendlyEntityName Error";
    }
  }

  string IRecreatableEntity.RecreateTypeName
  {
    get
    {
      return this._activeQuote != null ? this._activeQuote.RecreateTypeName : "RecreateTypeName Error";
    }
  }

  bool IRecreatableEntity.CanReCreateEntity
  {
    get => this._activeQuote != null && this._activeQuote.CanReCreateEntity;
  }

  bool IRecreatableEntity.HasControlGUID
  {
    get => this._activeQuote != null && this._activeQuote.HasControlGUID;
  }

  Guid IRecreatableEntity.ControlGUID
  {
    get => this._activeQuote != null ? this._activeQuote.ControlGuid : Guid.Empty;
  }

  private void FormFilingInformation_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnExcelExport).Appearance.Image = (object) ImageCache.Instance.Excel;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    this._defaultAllIssuingLocations = SystemSettings.KeyExists("DefaultFilingIssuingLocations") && SystemSettings.GetBoolSetting("DefaultFilingIssuingLocations");
    dsFilingPolicyInfo.lstStatesRow row = this.ds.lstStates.NewlstStatesRow();
    row.StateID = string.Empty;
    row.State = string.Empty;
    this.ds.lstStates.AddlstStatesRow(row);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstStates"
    }, CommandType.Text, "SELECT StateID, State FROM lstStates ORDER BY State");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblStatesSLRequiredData_Info"
    }, "dbo.GetRequiredDataInformation");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblStateSLRules"
    }, CommandType.Text, "SELECT StateID, OtherInfo, Description FROM tblStateSLRules WITH (NOLOCK)");
    this.LoadClientOffices();
    this.ClearOtherFilingInfo();
    this.ClearFilingDetails();
    this.ClearQuoteFilingInformation();
    this._dtHiddenCols = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT ColumnName FROM lstSurplusLineHiddenColumns");
  }

  private void LoadClientOffices()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblClientOffices"
    }, CommandType.Text, "SELECT OfficeGUID, Location + @P + State AS Location FROM tblClientOffices WITH (NOLOCK) ORDER BY Location", new object[2]
    {
      (object) "@P",
      (object) " - "
    });
    try
    {
      foreach (dsFilingPolicyInfo.tblClientOfficesRow row in this.ds.tblClientOffices.Rows)
        ((CheckedListBox) this.lstIssuingOffices).Items.Add((object) new FormFilingInformation.ClientOffice(row.OfficeGUID, row.Location), this._defaultAllIssuingLocations);
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void ClearQuoteFilingInformation()
  {
    this.lblAffidavitNumber.Text = string.Empty;
    this.lblFilingProducer.Text = string.Empty;
    this.lblLicenseNumber.Text = string.Empty;
    this.lblPayeeName.Text = string.Empty;
    this.lblPremium.Text = string.Empty;
    this.lblLOB.Text = string.Empty;
    this.lblStatePremium.Text = string.Empty;
    this.lblControlNo.Text = string.Empty;
    this.lblInvoiceNum.Text = string.Empty;
    this.lblTransType.Text = string.Empty;
    this.lblPolicyTIV.Text = string.Empty;
    this.lblStateTIV.Text = string.Empty;
    this.lblInsured.Text = string.Empty;
    this.lblState.Text = string.Empty;
  }

  private void ClearFilingDetails()
  {
    try
    {
      foreach (Control control in ((Control) this.tabFilingStateInfo).Controls)
      {
        if (control is Label label && Conversions.ToInteger(label.Tag) != 101)
          label.Text = string.Empty;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private bool ValidateSearch()
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtControlNo).Text.Replace(" ", string.Empty).Length > 0 && !Versioned.IsNumeric((object) ((TextEditorControlBase) this.txtControlNo).Text))
    {
      this.err.SetError((Control) this.txtControlNo, "Please enter a number");
      flag = false;
    }
    else
      this.err.SetError((Control) this.txtControlNo, string.Empty);
    return flag;
  }

  protected void AssignParameterValues(
    ref object ctrlNo,
    ref object chargeCode,
    ref object insured,
    ref object state,
    ref object policyNo,
    ref object isDateFiledNULL,
    ref object isFeePaid,
    ref object filingProducer,
    ref object polEffectiveFrom,
    ref object polEffectiveTo,
    ref object taxableFee,
    ref object hideOffsets,
    ref object revenueDateFrom,
    ref object revenueDateTo)
  {
    isFeePaid = !this.rbPaid.Checked ? (!this.rbNotPaid.Checked ? (object) null : (object) true) : (object) false;
    isDateFiledNULL = !((UltraToggleEditorBase) this.chkDateFiledNULL).Checked ? (object) false : (object) true;
    if (((TextEditorControlBase) this.txtControlNo).Text.Replace(" ", string.Empty).Length > 0)
      ctrlNo = (object) ((TextEditorControlBase) this.txtControlNo).Text;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboChargeName).Text, string.Empty, false) != 0)
      chargeCode = RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboChargeName).Value);
    insured = ((TextEditorControlBase) this.txtInsuredName).Text.Replace(" ", string.Empty).Length <= 0 ? (object) null : (object) ((TextEditorControlBase) this.txtInsuredName).Text;
    policyNo = ((TextEditorControlBase) this.txtPolicyNo).Text.Replace(" ", string.Empty).Length <= 0 ? (object) null : (object) ((TextEditorControlBase) this.txtPolicyNo).Text;
    state = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboState).Text, string.Empty, false) == 0 ? (object) null : RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboState).Value);
    filingProducer = ((TextEditorControlBase) this.txtFilingProducer).Text.Replace(" ", string.Empty).Length <= 0 ? (object) null : (object) ((TextEditorControlBase) this.txtFilingProducer).Text;
    polEffectiveTo = ((UltraDateTimeEditor) this.dtpPolEffectiveTo).Value == null ? (object) null : RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpPolEffectiveTo).Value);
    polEffectiveFrom = ((UltraDateTimeEditor) this.dtpPolicyEffFrom).Value == null ? (object) null : RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpPolicyEffFrom).Value);
    taxableFee = (object) ((UltraToggleEditorBase) this.chkTaxableFee).Checked;
    hideOffsets = (object) ((UltraToggleEditorBase) this.chkHideOffsets).Checked;
    revenueDateFrom = ((UltraDateTimeEditor) this.dtpRevenueDateFrom).Value == null ? (object) null : RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpRevenueDateFrom).Value);
    if (((UltraDateTimeEditor) this.dtpReveneDateTo).Value != null)
      revenueDateTo = RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpReveneDateTo).Value);
    else
      revenueDateTo = (object) null;
  }

  private bool isEmptyGroupBoxControl(GroupBox grpBox)
  {
    bool flag = true;
    try
    {
      foreach (Control control in grpBox.Controls)
      {
        if (control is MGADateTimePicker mgaDateTimePicker && ((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
        {
          flag = false;
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return flag;
  }

  private bool IsEmptySearch()
  {
    bool flag = true;
    try
    {
      foreach (Control control in ((Control) this.tabSearch).Controls)
      {
        MGADateTimePicker mgaDateTimePicker = control as MGADateTimePicker;
        MGATextBox mgaTextBox = control as MGATextBox;
        MGASimpleComboBox mgaSimpleComboBox = control as MGASimpleComboBox;
        MGAComboBox mgaComboBox = control as MGAComboBox;
        MGACheckBox mgaCheckBox = control as MGACheckBox;
        if (control is GroupBox grpBox && !this.isEmptyGroupBoxControl(grpBox))
        {
          flag = false;
          break;
        }
        if (mgaDateTimePicker != null && ((UltraDateTimeEditor) mgaDateTimePicker).Value != null && ((UltraDateTimeEditor) mgaDateTimePicker).Value != DBNull.Value)
        {
          flag = false;
          break;
        }
        if (mgaTextBox != null && ((TextEditorControlBase) mgaTextBox).Text.Replace(" ", string.Empty).Length > 0)
        {
          flag = false;
          break;
        }
        if (mgaSimpleComboBox != null && ((UltraCombo) mgaSimpleComboBox).Text.Length > 0)
        {
          flag = false;
          break;
        }
        if (mgaComboBox != null && ((UltraCombo) mgaComboBox).Text.Length > 0)
        {
          flag = false;
          break;
        }
        if (mgaCheckBox != null && ((UltraToggleEditorBase) mgaCheckBox).Checked)
        {
          flag = false;
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (flag && ((CheckedListBox) this.lstIssuingOffices).CheckedItems.Count > 0)
      flag = false;
    return flag;
  }

  private string GetIssuingOfficeGuids()
  {
    string issuingOfficeGuids = string.Empty;
    int num = ((CheckedListBox) this.lstIssuingOffices).CheckedItems.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      FormFilingInformation.ClientOffice checkedItem = (FormFilingInformation.ClientOffice) ((CheckedListBox) this.lstIssuingOffices).CheckedItems[index];
      issuingOfficeGuids = $"{issuingOfficeGuids}{checkedItem.ClientOfficeGuid.ToString()},";
    }
    if (!string.IsNullOrEmpty(issuingOfficeGuids))
      issuingOfficeGuids = issuingOfficeGuids.Remove(issuingOfficeGuids.Length - 1, 1);
    return issuingOfficeGuids;
  }

  private void btnSearch_Click_1(object sender, EventArgs e)
  {
    ((Control) this.btnSearch).Enabled = false;
    if (this.IsEmptySearch())
    {
      int num = (int) MessageBox.Show("Please specify some search criteria.", "Invalid Search Criteria", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((Control) this.btnSearch).Enabled = true;
    }
    else if (!this.ValidateSearch())
    {
      ((Control) this.btnSearch).Enabled = true;
    }
    else
    {
      ((Control) this.panelPleaseWait).Visible = true;
      this.ds.tblStatesSLRequiredData_Info.Rows.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblStatesSLRequiredData_Info"
      }, "dbo.GetRequiredDataInformation");
      this.ds.PolicyFilingInformation.Clear();
      ((UltraGridBase) this.gridFilingInformation).Rows.Refresh((RefreshRow) 0, false, false);
      this._guidsToString = this.GetIssuingOfficeGuids();
      this.Cursor = MgaCursors.WaitCursor;
      ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Save((Stream) this._gridlayout);
      ((UltraGridBase) this.gridFilingInformation).DataSource = (object) null;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.FillDataThread));
    }
  }

  protected virtual void FillDataThread(object state)
  {
    object ctrlNo = (object) null;
    object chargeCode = (object) null;
    object insured = (object) null;
    object state1 = (object) null;
    object policyNo = (object) null;
    object isDateFiledNULL = (object) null;
    object isFeePaid = (object) null;
    object filingProducer = (object) null;
    object obj = (object) null;
    if (!string.IsNullOrEmpty(this._guidsToString))
      obj = (object) this._guidsToString;
    object polEffectiveTo = (object) null;
    object polEffectiveFrom = (object) null;
    object taxableFee = (object) null;
    object hideOffsets = (object) null;
    object revenueDateFrom = (object) null;
    object revenueDateTo = (object) null;
    this.AssignParameterValues(ref ctrlNo, ref chargeCode, ref insured, ref state1, ref policyNo, ref isDateFiledNULL, ref isFeePaid, ref filingProducer, ref polEffectiveFrom, ref polEffectiveTo, ref taxableFee, ref hideOffsets, ref revenueDateFrom, ref revenueDateTo);
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "PolicyFilingInformation"
      }, CommandType.StoredProcedure, this.FilingInformationStoredProcedure(), 0, (CommandArgumentType) 0, new object[30]
      {
        (object) "@ControlNo",
        ctrlNo,
        (object) "@Insured",
        insured,
        (object) "@PolicyNo",
        policyNo,
        (object) "@ChargeCode",
        chargeCode,
        (object) "@State",
        state1,
        (object) "@DateFileNULL",
        isDateFiledNULL,
        (object) "@FeePaid",
        isFeePaid,
        (object) "@FilingProducer",
        filingProducer,
        (object) "@IssuingOfficeGuids",
        obj,
        (object) "@polEffectiveFrom",
        polEffectiveFrom,
        (object) "@polEffectiveTo",
        polEffectiveTo,
        (object) "@taxableFee",
        taxableFee,
        (object) "@hideOffsets",
        hideOffsets,
        (object) "@revenueDateFrom",
        revenueDateFrom,
        (object) "@revenueDateTo",
        revenueDateTo
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new FormFilingInformation.HandleErrorOnUIThread(this.HandleError), new object[1]
      {
        (object) ex
      });
      ProjectData.ClearProjectError();
    }
    if (((!this.IsHandleCreated ? 0 : (!this.IsDisposed ? 1 : 0)) & (!this.Disposing ? 1 : 0)) == 0)
      return;
    try
    {
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.FillThreadComplete), new object[0]);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void HandleError(Exception ex)
  {
  }

  protected void FillThreadComplete()
  {
    try
    {
      this._gridlayout.Position = 0L;
      UltraGrid filingInformation = this.gridFilingInformation;
      ((UltraGridBase) filingInformation).DataSource = (object) this.ds;
      ((UltraGridBase) filingInformation).DataMember = "PolicyFilingInformation";
      ((UltraGridBase) filingInformation).DisplayLayout.Load((Stream) this._gridlayout);
      ((UltraGridBase) filingInformation).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
      this.SetSummaries();
      this.SetTotals();
      if (this.ds.PolicyFilingInformation.Rows.Count == 0)
      {
        this.ClearOtherFilingInfo();
        this.ClearPolicyQuoteFilingInfo();
        this.CheckFilingRequiredOnZeroPremium();
      }
      else
        this.SetOffSetRows();
      ((Control) this.panelPleaseWait).Visible = false;
      ((Control) this.btnSearch).Enabled = true;
      ((UltraTabControlBase) this.UltraFiling).SelectedTab = this.tabFilingPolicyInfo.Tab;
      this.HideColumns();
      this.SearchComplete();
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void SearchComplete()
  {
  }

  protected virtual string FilingInformationStoredProcedure() => "dbo.spGetPolicyFilingInformation";

  private void SetTotals()
  {
    this.lblTotalStatePremium.Text = 0M.ToString("c");
    object objectValue1 = RuntimeHelpers.GetObjectValue(this.ds.PolicyFilingInformation.Compute("SUM(StatePremium)", string.Empty));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
      this.lblTotalStatePremium.Text = Conversions.ToDecimal(objectValue1).ToString("c");
    this.lblTotalTaxDue.Text = 0M.ToString("c");
    object objectValue2 = RuntimeHelpers.GetObjectValue(this.ds.PolicyFilingInformation.Compute("SUM(TaxDue)", string.Empty));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
      this.lblTotalTaxDue.Text = Conversions.ToDecimal(objectValue2).ToString("c");
    this.lblTotalFeesDue.Text = 0M.ToString("c");
    object objectValue3 = RuntimeHelpers.GetObjectValue(this.ds.PolicyFilingInformation.Compute("SUM(FeesDue)", string.Empty));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue3)))
      this.lblTotalFeesDue.Text = Conversions.ToDecimal(objectValue3).ToString("c");
    this.lblTotalTaxableFeesAmount.Text = 0M.ToString("c");
    object objectValue4 = RuntimeHelpers.GetObjectValue(this.ds.PolicyFilingInformation.Compute("SUM(TaxableFeesAmount)", string.Empty));
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue4)))
      return;
    this.lblTotalTaxableFeesAmount.Text = Conversions.ToDecimal(objectValue4).ToString("c");
  }

  private void SetSummaries()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Summaries).Count != 0)
      return;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Summaries.Clear();
    SummarySettings summarySettings1 = ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Summaries.Add((SummaryType) 1, ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["StatePremium"]);
    summarySettings1.SummaryType = (SummaryType) 5;
    summarySettings1.DisplayFormat = "{0:c}";
    summarySettings1.Appearance.TextHAlign = (HAlign) 3;
    summarySettings1.CustomSummaryCalculator = (ICustomSummaryCalculator) new FilingSummary("StatePremium");
    SummarySettings summarySettings2 = ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Summaries.Add((SummaryType) 1, ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["TaxDue"]);
    summarySettings2.SummaryType = (SummaryType) 5;
    summarySettings2.DisplayFormat = "{0:c}";
    summarySettings2.Appearance.TextHAlign = (HAlign) 3;
    summarySettings2.CustomSummaryCalculator = (ICustomSummaryCalculator) new FilingSummary("TaxDue");
    SummarySettings summarySettings3 = ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Summaries.Add((SummaryType) 1, ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["FeesDue"]);
    summarySettings3.SummaryType = (SummaryType) 5;
    summarySettings3.DisplayFormat = "{0:c}";
    summarySettings3.Appearance.TextHAlign = (HAlign) 3;
    summarySettings3.CustomSummaryCalculator = (ICustomSummaryCalculator) new FilingSummary("FeesDue");
    SummarySettings summarySettings4 = ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Summaries.Add((SummaryType) 1, ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["TaxableFeesAmount"]);
    summarySettings4.SummaryType = (SummaryType) 5;
    summarySettings4.DisplayFormat = "{0:c}";
    summarySettings4.Appearance.TextHAlign = (HAlign) 3;
    summarySettings4.CustomSummaryCalculator = (ICustomSummaryCalculator) new FilingSummary("TaxableFeesAmount");
  }

  private void SetOffSetRows()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridFilingInformation).Rows)
    {
      UltraGridRow ultraGridRow;
      if (Conversions.ToBoolean((ultraGridRow = row).Cells["OffSet"].Value))
      {
        ultraGridRow.Appearance.ForeColor = Color.Red;
        ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
      }
      else
        ultraGridRow.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
    }
  }

  private bool IsAmountDueEmpty() => true;

  private void CheckFilingRequiredOnZeroPremium()
  {
  }

  private bool IsOtherFilingInfoDataValid()
  {
    bool flag = true;
    if (!this.OtherInfoHasData())
    {
      flag = false;
      if (this._ID != int.MinValue)
      {
        this.Cursor = MgaCursors.WaitCursor;
        try
        {
          dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow byId = this.ds.tblPolicyFilingManagementInfo.FindByID(this._ID);
          if (byId != null)
          {
            byId.Delete();
            DefaultDatabase.DataAdapterUpdate(this.daGetOtherPolicyFilingInfo, (DataTable) this.ds.tblPolicyFilingManagementInfo);
          }
        }
        finally
        {
          this.Cursor = MgaCursors.Default;
        }
      }
    }
    return flag;
  }

  private bool OtherInfoHasData() => true;

  private void ClearPolicyQuoteFilingInfo()
  {
    try
    {
      foreach (Control control in ((Control) this.tabFilingPolicyInfo).Controls)
      {
        if (control is Label label && Conversions.ToInteger(label.Tag) != 101)
          label.Text = string.Empty;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void ClearOtherFilingInfo()
  {
    try
    {
      foreach (Control control in ((Control) this.tabFilingStateInfo).Controls)
      {
        if (control is MGATextBox mgaTextBox)
          ((TextEditorControlBase) mgaTextBox).Text = string.Empty;
        if (control is MGADateTimePicker mgaDateTimePicker)
          ((UltraDateTimeEditor) mgaDateTimePicker).Value = (object) null;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void AssignRowInfoToFormControls(dsFilingPolicyInfo.PolicyFilingInformationRow dr)
  {
    this.lblAffidavitNumber.Text = dr.IsAffidavitNumberNull() ? string.Empty : dr.AffidavitNumber;
    if (!dr.IsPremiumNull())
    {
      if (dr.Premium >= 0.0)
        this.lblPremium.ForeColor = Color.Green;
      else
        this.lblPremium.ForeColor = Color.Red;
      this.lblPremium.Text = dr.Premium.ToString("c");
    }
    else
      this.lblPremium.Text = string.Empty;
    this.lblLicenseNumber.Text = dr.IsLicenseNumberNull() ? string.Empty : dr.LicenseNumber;
    this.lblFilingProducer.Text = dr.IsFilingProducerNull() ? string.Empty : dr.FilingProducer;
    this.lblPayeeName.Text = dr.IsPayeeNameNull() ? string.Empty : dr.PayeeName;
    this.lblControlNo.Text = dr.IsControlNoNull() ? string.Empty : dr.ControlNo.ToString();
    if (!dr.IsStatePremiumNull())
    {
      if (dr.StatePremium >= 0.0)
        this.lblStatePremium.ForeColor = Color.Green;
      else
        this.lblStatePremium.ForeColor = Color.Red;
      this.lblStatePremium.Text = dr.StatePremium.ToString("c");
    }
    else
      this.lblStatePremium.Text = string.Empty;
    this.lblInvoiceNum.Text = dr.IsInvoiceNumNull() ? string.Empty : dr.InvoiceNum.ToString();
    this.lblTransType.Text = dr.IsTransactionTypeNull() ? string.Empty : dr.TransactionType;
    this.lblPolicyTIV.Text = dr.IsPolicyTIVNull() ? string.Empty : dr.PolicyTIV.ToString("c");
    this.lblStateTIV.Text = dr.IsStateTIVNull() ? string.Empty : dr.StateTIV.ToString("c");
    this.lblInsured.Text = dr.IsInsuredPolicyNameNull() ? string.Empty : dr.InsuredPolicyName;
    if (!dr.IsStateIDNull())
      this.lblState.Text = dr.StateID;
    else
      this.lblState.Text = string.Empty;
  }

  private void gridFilingInformation_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridFilingInformation).ActiveRow == null)
      return;
    int num = (int) ((UltraGridBase) this.gridFilingInformation).ActiveRow.Cells["OptionFeeID"].Value;
    dsFilingPolicyInfo.PolicyFilingInformationRow dr = (dsFilingPolicyInfo.PolicyFilingInformationRow) this.ds.PolicyFilingInformation.Select("OptionFeeID=" + Conversions.ToString(num))[0];
    if (dr != null)
    {
      this.AssignRowInfoToFormControls(dr);
      this.ds.tblPolicyFilingManagementInfo.Clear();
      this.daGetOtherPolicyFilingInfo.SelectCommand.Parameters["@OptionFeeID"].Value = (object) num;
      DefaultDatabase.DataAdapterFill(this.daGetOtherPolicyFilingInfo, (DataTable) this.ds.tblPolicyFilingManagementInfo);
      if (this.ds.tblPolicyFilingManagementInfo.Rows.Count > 0)
      {
        dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow row = (dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) this.ds.tblPolicyFilingManagementInfo.Rows[0];
        if (row != null)
        {
          this.AssignOtherInfoData(row);
        }
        else
        {
          this._ID = int.MinValue;
          this.ClearOtherFilingInfo();
        }
      }
      else
      {
        this.ClearOtherFilingInfo();
        this._ID = int.MinValue;
      }
    }
    int controlNo = (int) ((UltraGridBase) this.gridFilingInformation).ActiveRow.Cells["ControlNo"].Value;
    this.PopulatePolicyFilingInformation(controlNo);
    this.PopulateFilingInfo(((UltraGridBase) this.gridFilingInformation).ActiveRow.Cells["StateID"].Value.ToString());
    this.SetPolicyTotals(controlNo);
    this._activeQuote = Quote.FromControlNo(controlNo);
    // ISSUE: reference to a compiler-generated field
    ISupportNoteSystem.EntityInfoChangedEventHandler infoChangedEvent = this.EntityInfoChangedEvent;
    if (infoChangedEvent == null)
      return;
    infoChangedEvent((object) this, EventArgs.Empty);
  }

  protected virtual void PopulateFilingInfo(string stateID)
  {
    dsFilingPolicyInfo.tblStateSLRulesRow byStateId = this.ds.tblStateSLRules.FindByStateID(stateID);
    if (byStateId == null)
      return;
    dsFilingPolicyInfo.tblStateSLRulesRow tblStateSlRulesRow = byStateId;
    if (!tblStateSlRulesRow.IsOtherInfoNull())
      this.txtNotes.Rtf = tblStateSlRulesRow.OtherInfo;
    else
      this.txtNotes.Text = string.Empty;
    if (!tblStateSlRulesRow.IsDescriptionNull())
      this.txtExRe.Rtf = tblStateSlRulesRow.Description;
    else
      this.txtExRe.Text = string.Empty;
  }

  public event ISupportNoteSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  private void PopulatePolicyFilingInformation(int controlNo)
  {
    FormFilingInformation.QuoteStructure quoteStructure;
    if (this._quoteDic.ContainsKey(controlNo))
    {
      quoteStructure = this._quoteDic[controlNo];
    }
    else
    {
      int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT MAX(QuoteID) FROM tblQuotes WITH (NOLOCK) WHERE ControlNo = @CNO", new object[2]
      {
        (object) "@CNO",
        (object) controlNo
      });
      Quote quote = new Quote(num);
      quoteStructure.QuoteID = num;
      quoteStructure.lineName = quote.LineName;
      this._quoteDic.Add(controlNo, quoteStructure);
    }
    this.lblLOB.Text = quoteStructure.lineName;
    this.lblControlNo.Text = controlNo.ToString();
  }

  private void ClearExemptionsAndNotes()
  {
    this.txtExRe.Text = string.Empty;
    this.txtNotes.Text = string.Empty;
  }

  private void AssignOtherInfoData(
    dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow drInfo)
  {
    dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow managementInfoRow = drInfo;
    this._ID = managementInfoRow.ID;
    if (!managementInfoRow.IsCheckRequestDateNull())
      ((UltraDateTimeEditor) this.dtCheckReqDate).Value = (object) managementInfoRow.CheckRequestDate;
    else
      ((UltraDateTimeEditor) this.dtCheckReqDate).Value = (object) null;
    if (!managementInfoRow.IsFilingDoneNull())
      this.SetDTP(1, managementInfoRow.FilingDone);
    else
      this.SetDTP(1, DateTime.MinValue);
    if (!managementInfoRow.IsDecPageFiledDateNull())
      this.SetDTP(2, managementInfoRow.DecPageFiledDate);
    else
      this.SetDTP(2, DateTime.MinValue);
    if (!managementInfoRow.IsDSFFillDateNull())
      this.SetDTP(3, managementInfoRow.DSFFillDate);
    else
      this.SetDTP(3, DateTime.MinValue);
    if (!managementInfoRow.IsMonthlyReportDueNull())
      this.SetDTP(4, managementInfoRow.MonthlyReportDue);
    else
      this.SetDTP(4, DateTime.MinValue);
    if (!managementInfoRow.IsQuarterlyReportDueNull())
      this.SetDTP(5, managementInfoRow.QuarterlyReportDue);
    else
      this.SetDTP(5, DateTime.MinValue);
    if (!managementInfoRow.IsAnnualReportDueNull())
      this.SetDTP(7, managementInfoRow.AnnualReportDue);
    else
      this.SetDTP(7, DateTime.MinValue);
    if (!managementInfoRow.IsSemiAnnualReportDueNull())
      this.SetDTP(6, managementInfoRow.SemiAnnualReportDue);
    else
      this.SetDTP(6, DateTime.MinValue);
    if (!managementInfoRow.IsFireTaxDueNull())
      this.SetDTP(10, managementInfoRow.FireTaxDue);
    else
      this.SetDTP(10, DateTime.MinValue);
    if (!managementInfoRow.IsRevenueSurchargeDueNull())
      this.SetDTP(9, managementInfoRow.RevenueSurchargeDue);
    else
      this.SetDTP(9, DateTime.MinValue);
    if (!managementInfoRow.IsMunicipalFilingDueNull())
      this.SetDTP(8, managementInfoRow.MunicipalFilingDue);
    else
      this.SetDTP(8, DateTime.MinValue);
    if (!managementInfoRow.IsControlsFiledDateNull())
      this.SetDTP(11, managementInfoRow.ControlsFiledDate);
    else
      this.SetDTP(11, DateTime.MinValue);
  }

  private void SetDTP(int tag, DateTime value)
  {
    try
    {
      foreach (Control control in ((Control) this.tabFilingStateInfo).Controls)
      {
        if (control is MGADateTimePicker mgaDateTimePicker && ((Control) mgaDateTimePicker).Tag.Equals((object) tag))
        {
          if (value.Equals(DateTime.MinValue) || value.Equals(DateTime.MaxValue))
          {
            ((UltraDateTimeEditor) mgaDateTimePicker).Value = (object) null;
            break;
          }
          ((UltraDateTimeEditor) mgaDateTimePicker).Value = (object) value;
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private MGADateTimePicker GetDTP(int tag)
  {
    dtp = (MGADateTimePicker) null;
    try
    {
      foreach (Control control in ((Control) this.tabFilingStateInfo).Controls)
      {
        if (control is MGADateTimePicker dtp)
        {
          if (((Control) dtp).Tag.Equals((object) tag))
            break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return dtp;
  }

  private void SetActiveRow()
  {
    if (this.gridFilingInformation.Selected.Rows.Count != 0 || ((UltraGridBase) this.gridFilingInformation).ActiveRow == null)
      return;
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Rows[((UltraGridBase) this.gridFilingInformation).ActiveRow.Index].Selected = true;
  }

  private void DefaultNotes()
  {
    foreach (UltraGridRow row in this.gridFilingInformation.Selected.Rows)
    {
      DataRow dataRow = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT OtherInfo, Description FROM tblStateSLRules WHERE StateID=@ST", new object[2]
      {
        (object) "@ST",
        (object) (string) row.Cells["StateID"].Value
      });
      if (dataRow != null)
      {
        if (dataRow[0] != DBNull.Value && string.IsNullOrEmpty(this.txtExRe.Text))
          this.txtExRe.Rtf = dataRow[0].ToString();
        if (dataRow[1] != DBNull.Value && string.IsNullOrEmpty(this.txtNotes.Text))
          this.txtNotes.Rtf = dataRow[1].ToString();
      }
    }
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.CanUpdateFilingInfo())
      return;
    this.SetActiveRow();
    this.DefaultNotes();
    if (this.gridFilingInformation.Selected.Rows.Count == 1 && !this.IsOtherFilingInfoDataValid())
      return;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      RowEnumerator enumerator = this.gridFilingInformation.Selected.Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        int num = (int) current.Cells["OptionFeeID"].Value;
        dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow managementInfoRow1 = (dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) null;
        this.ds.tblPolicyFilingManagementInfo.Clear();
        this.daGetOtherPolicyFilingInfo.SelectCommand.Parameters["@OptionFeeID"].Value = (object) num;
        DefaultDatabase.DataAdapterFill(this.daGetOtherPolicyFilingInfo, (DataTable) this.ds.tblPolicyFilingManagementInfo);
        if (this.ds.tblPolicyFilingManagementInfo.Count > 0)
          managementInfoRow1 = (dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow) this.ds.tblPolicyFilingManagementInfo.Select("OptionFeeID =" + Conversions.ToString(num))[0];
        bool flag;
        if (managementInfoRow1 == null)
        {
          dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow managementInfoRow2 = this.ds.tblPolicyFilingManagementInfo.NewtblPolicyFilingManagementInfoRow();
          this.UpdateRowInfo(managementInfoRow2, num);
          this.ds.tblPolicyFilingManagementInfo.AddtblPolicyFilingManagementInfoRow(managementInfoRow2);
          this.SetRelatedDataControls(current, managementInfoRow2);
          flag = true;
        }
        else
        {
          this.UpdateRowInfo(managementInfoRow1, num);
          this.SetRelatedDataControls(current, managementInfoRow1);
          flag = false;
        }
        if (flag)
          DefaultDatabase.DataAdapterUpdate(this.daGetOtherPolicyFilingInfo, (DataTable) this.ds.tblPolicyFilingManagementInfo);
        else
          this.UpdateFilingInfoRow(num, managementInfoRow1);
      }
      this.ds.tblStatesSLRequiredData_Info.Rows.Clear();
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "tblStatesSLRequiredData_Info"
      }, "dbo.GetRequiredDataInformation");
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    int num1 = -1;
    if (((UltraGridBase) this.gridFilingInformation).Rows.Count > 0 && ((UltraGridBase) this.gridFilingInformation).ActiveRow != null)
      num1 = ((UltraGridBase) this.gridFilingInformation).ActiveRow.Index;
    if (num1 == -1 || ((UltraGridBase) this.gridFilingInformation).Rows.Count <= 0)
      return;
    ((UltraGridBase) this.gridFilingInformation).ActiveRow = ((UltraGridBase) this.gridFilingInformation).Rows[num1];
  }

  private void SetRelatedDataControls(
    UltraGridRow row,
    dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow dr)
  {
    if (!dr.IsControlsFiledDateNull())
    {
      row.Cells["Filed"].Value = (object) true;
      row.Cells["ControlsFiledDate"].Value = (object) dr.ControlsFiledDate;
    }
    else
    {
      row.Cells["Filed"].Value = (object) false;
      row.Cells["ControlsFiledDate"].Value = (object) DBNull.Value;
    }
  }

  private void UpdateFilingInfoRow(
    int OptionFeeID,
    dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow dr)
  {
    object obj1 = (object) null;
    object obj2 = (object) null;
    object obj3 = (object) null;
    object obj4 = (object) null;
    object obj5 = (object) null;
    object obj6 = (object) null;
    object obj7 = (object) null;
    object obj8 = (object) null;
    object obj9 = (object) null;
    object obj10 = (object) null;
    object obj11 = (object) null;
    object obj12 = (object) null;
    object obj13 = (object) null;
    object obj14 = (object) null;
    if (!dr.IsFilingDoneNull())
      obj10 = (object) dr.FilingDone;
    if (!dr.IsAnnualReportDueNull())
      obj9 = (object) dr.AnnualReportDue;
    if (!dr.IsSemiAnnualReportDueNull())
      obj8 = (object) dr.SemiAnnualReportDue;
    if (!dr.IsQuarterlyReportDueNull())
      obj7 = (object) dr.QuarterlyReportDue;
    if (!dr.IsMonthlyReportDueNull())
      obj6 = (object) dr.MonthlyReportDue;
    if (!dr.IsCheckRequestDateNull())
      obj5 = (object) dr.CheckRequestDate;
    if (!dr.IsExemptionResearchNull())
      obj3 = (object) dr.ExemptionResearch;
    if (!dr.IsDSFFillDateNull())
      obj1 = (object) dr.DSFFillDate;
    if (!dr.IsDecPageFiledDateNull())
      obj2 = (object) dr.DecPageFiledDate;
    if (!dr.IsNotesNull())
      obj4 = (object) dr.Notes;
    if (!dr.IsFireTaxDueNull())
      obj11 = (object) dr.FireTaxDue;
    if (!dr.IsRevenueSurchargeDueNull())
      obj12 = (object) dr.RevenueSurchargeDue;
    if (!dr.IsControlsFiledDateNull())
      obj13 = (object) dr.ControlsFiledDate;
    if (!dr.IsMunicipalFilingDueNull())
      obj14 = (object) dr.MunicipalFilingDue;
    DefaultDatabase.ExecuteNonQuery("dbo.spUpdateFilingInfo", new object[30]
    {
      (object) "@OptionFeeID",
      (object) dr.OptionFeeID,
      (object) "@DSFFillDate",
      obj1,
      (object) "@DecPageFiledDate",
      obj2,
      (object) "@ExemptionResearch",
      obj3,
      (object) "@Notes",
      obj4,
      (object) "@CheckRequestDate",
      obj5,
      (object) "@MonthlyReportDue",
      obj6,
      (object) "@QuarterlyReportDue",
      obj7,
      (object) "@SemiAnnualReportDue",
      obj8,
      (object) "@AnnualReportDue",
      obj9,
      (object) "@FilingDone",
      obj10,
      (object) "@FireTaxDue",
      obj11,
      (object) "@RevenueSurchargeDue",
      obj12,
      (object) "@ControlsFiledDate",
      obj13,
      (object) "@MunicipalFilingDue",
      obj14
    });
    this.SaveClientInfo(dr.OptionFeeID);
  }

  protected virtual void SaveClientInfo(int optionFeeID)
  {
  }

  private void UpdateRowInfo(
    dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow drNew,
    int OptFeeID)
  {
    dsFilingPolicyInfo.tblPolicyFilingManagementInfoRow managementInfoRow = drNew;
    managementInfoRow.OptionFeeID = OptFeeID;
    if (this.txtExRe.Text.Replace(" ", string.Empty).Length > 0)
      managementInfoRow.ExemptionResearch = this.txtExRe.Text.Length <= this.txtExRe.MaxLength ? this.txtExRe.Text : this.txtExRe.Text.Substring(0, this.txtExRe.MaxLength - 1);
    else
      managementInfoRow.SetExemptionResearchNull();
    if (this.txtNotes.Text.Replace(" ", string.Empty).Length > 0)
      managementInfoRow.Notes = this.txtNotes.Text.Length <= this.txtNotes.MaxLength ? this.txtNotes.Text : this.txtNotes.Text.Substring(0, this.txtNotes.MaxLength - 1);
    else
      managementInfoRow.SetNotesNull();
    if (((UltraDateTimeEditor) this.dtCheckReqDate).Value != null)
      managementInfoRow.CheckRequestDate = (DateTime) ((UltraDateTimeEditor) this.dtCheckReqDate).Value;
    else
      managementInfoRow.SetCheckRequestDateNull();
    try
    {
      foreach (Control control in ((Control) this.tabFilingStateInfo).Controls)
      {
        if (control is MGADateTimePicker mgaDateTimePicker && !((Control) mgaDateTimePicker).Tag.Equals((object) "101"))
        {
          string str = ((Control) mgaDateTimePicker).Tag.ToString();
          // ISSUE: reference to a compiler-generated method
          switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
          {
            case 468396612:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "10", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.FireTaxDue = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetFireTaxDueNull();
                continue;
              }
              break;
            case 485174231:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "11", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.ControlsFiledDate = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetControlsFiledDateNull();
                continue;
              }
              break;
            case 806133968:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "5", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.QuarterlyReportDue = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetQuarterlyReportDueNull();
                continue;
              }
              break;
            case 822911587:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "4", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.MonthlyReportDue = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetMonthlyReportDueNull();
                continue;
              }
              break;
            case 839689206:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "7", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.AnnualReportDue = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetAnnualReportDueNull();
                continue;
              }
              break;
            case 856466825:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "6", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.SemiAnnualReportDue = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetSemiAnnualReportDueNull();
                continue;
              }
              break;
            case 873244444:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "1", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.FilingDone = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetFilingDoneNull();
                continue;
              }
              break;
            case 906799682:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "3", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.DSFFillDate = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetDSFFillDateNull();
                continue;
              }
              break;
            case 923577301:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "2", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.DecPageFiledDate = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetDecPageFiledDateNull();
                continue;
              }
              break;
            case 1007465396:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "9", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.RevenueSurchargeDue = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetRevenueSurchargeDueNull();
                continue;
              }
              break;
            case 1024243015:
              if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "8", false) == 0)
              {
                if (((UltraDateTimeEditor) mgaDateTimePicker).Value != null)
                {
                  managementInfoRow.MunicipalFilingDue = (DateTime) ((UltraDateTimeEditor) mgaDateTimePicker).Value;
                  continue;
                }
                managementInfoRow.SetMunicipalFilingDueNull();
                continue;
              }
              break;
          }
          throw new InvalidOperationException("Required Data not Found");
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void linkRelatedQuote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (((UltraGridBase) this.gridFilingInformation).ActiveRow == null)
      return;
    frmControlNumberJump.LaunchAppropriateQuoteForm(Conversions.ToInteger(((UltraGridBase) this.gridFilingInformation).ActiveRow.Cells["ControlNo"].Value));
  }

  private void UpdateGridColor(
    DateTime taxDueDate,
    DateTime filingDueDate,
    InitializeRowEventArgs e)
  {
    DateTime minValue1 = DateTime.MinValue;
    DateTime minValue2 = DateTime.MinValue;
    int num1 = 9000;
    int num2 = 9000;
    if (!filingDueDate.Equals(DateTime.MinValue))
      num1 = filingDueDate.Subtract(DateAndTime.Now).Days;
    if (!taxDueDate.Equals(DateTime.MinValue))
      num2 = taxDueDate.Subtract(DateAndTime.Now).Days;
    int num3 = num1 >= num2 ? num2 : num1;
    if (e.Row.Cells["DSFFillDate"].Value != DBNull.Value)
      minValue1 = (DateTime) e.Row.Cells["DSFFillDate"].Value;
    if (e.Row.Cells["DecPageFiledDate"].Value != DBNull.Value)
    {
      DateTime dateTime = (DateTime) e.Row.Cells["DecPageFiledDate"].Value;
    }
    if (!minValue1.Equals(DateTime.MinValue))
      e.Row.Appearance.ForeColor = Color.SlateGray;
    else if (num3 > 10)
      e.Row.Appearance.ForeColor = Color.Green;
    else if (num3 <= 10 && num3 > 0)
    {
      e.Row.Appearance.ForeColor = Color.DarkOrange;
    }
    else
    {
      if (num3 > 0)
        return;
      e.Row.Appearance.ForeColor = Color.Red;
    }
  }

  private void gridFilingInformation_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    this.InitializeGridColor(e);
    this.SetFiling(e);
  }

  protected virtual void InitializeGridColor(InitializeRowEventArgs e)
  {
    DateTime minValue1 = DateTime.MinValue;
    DateTime minValue2 = DateTime.MinValue;
    bool flag = true;
    try
    {
      if (e.Row.Cells["DateFilingDue"].Value != null && e.Row.Cells["DateFilingDue"].Value != DBNull.Value)
        minValue1 = (DateTime) e.Row.Cells["DateFilingDue"].Value;
      if (e.Row.Cells["DateAmountDue"].Value != null)
      {
        if (e.Row.Cells["DateAmountDue"].Value != DBNull.Value)
          minValue2 = (DateTime) e.Row.Cells["DateAmountDue"].Value;
      }
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      flag = false;
      ProjectData.ClearProjectError();
    }
    if (!flag)
      return;
    this.UpdateGridColor(minValue2, minValue1, e);
  }

  private void SetFiling(InitializeRowEventArgs e)
  {
    int num = -1;
    e.Row.Cells["StateID"].Value.ToString();
    DataRow[] dataRowArray = this.ds.tblStatesSLRequiredData_Info.Select($"StateID like'{e.Row.Cells["StateID"].Value.ToString()}'");
    int index = 0;
    while (index < dataRowArray.Length)
    {
      dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow requiredDataInfoRow = (dsFilingPolicyInfo.tblStatesSLRequiredData_InfoRow) dataRowArray[index];
      if (requiredDataInfoRow.UseForFiling)
      {
        num = requiredDataInfoRow.RequiredDataID;
        break;
      }
      checked { ++index; }
    }
    if (num == -1)
      return;
    if (num == 1 && e.Row.Cells["FilingDone"].Value != null && e.Row.Cells["FilingDone"].Value != DBNull.Value)
      e.Row.Cells["Filed"].Value = (object) true;
    else if (num == 2 && e.Row.Cells["DecPageFiledDate"].Value != null && e.Row.Cells["DecPageFiledDate"].Value != DBNull.Value)
      e.Row.Cells["Filed"].Value = (object) true;
    else if (num == 3 && e.Row.Cells["DSFFillDate"].Value != null && e.Row.Cells["DSFFillDate"].Value != DBNull.Value)
      e.Row.Cells["Filed"].Value = (object) true;
    else if (num == 4 && e.Row.Cells["MonthlyReportDue"].Value != null && e.Row.Cells["MonthlyReportDue"].Value != DBNull.Value)
      e.Row.Cells["Filed"].Value = (object) true;
    else if (num == 5 && e.Row.Cells["QuarterlyReportDue"].Value != null && e.Row.Cells["QuarterlyReportDue"].Value != DBNull.Value)
      e.Row.Cells["Filed"].Value = (object) true;
    else if (num == 6 && e.Row.Cells["SemiAnnualReportDue"].Value != null && e.Row.Cells["SemiAnnualReportDue"].Value != DBNull.Value)
      e.Row.Cells["Filed"].Value = (object) true;
    else if (num == 7 && e.Row.Cells["AnnualReportDue"].Value != null && e.Row.Cells["AnnualReportDue"].Value != DBNull.Value)
      e.Row.Cells["Filed"].Value = (object) true;
    else if (num == 8 && e.Row.Cells["MunicipalFilingDue"].Value != null && e.Row.Cells["MunicipalFilingDue"].Value != DBNull.Value)
      e.Row.Cells["Filed"].Value = (object) true;
    else if (num == 9 && e.Row.Cells["RevenueSurchargeDue"].Value != null && e.Row.Cells["RevenueSurchargeDue"].Value != DBNull.Value)
    {
      e.Row.Cells["Filed"].Value = (object) true;
    }
    else
    {
      if (num != 10 || e.Row.Cells["FireTaxDue"].Value == null || e.Row.Cells["FireTaxDue"].Value == DBNull.Value)
        return;
      e.Row.Cells["Filed"].Value = (object) true;
    }
  }

  private void cboChargeName_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((UltraCombo) this.cboState).Text, string.Empty, false) == 0)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.cboChargeName).Rows)
      row.Hidden = !row.Cells["StateID"].Value.Equals((object) ((UltraCombo) this.cboState).Value.ToString());
  }

  protected virtual void OnStateValueChange(object stateValue)
  {
  }

  private void cboState_ValueChanged(object sender, EventArgs e)
  {
    this.ds.tblFin_PolicyCharges.Rows.Clear();
    if (((UltraCombo) this.cboState).Value != DBNull.Value && ((UltraCombo) this.cboState).Value != null)
    {
      if (!string.IsNullOrEmpty(((UltraCombo) this.cboState).Value.ToString()))
      {
        try
        {
          this.Cursor = MgaCursors.WaitCursor;
          DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
          {
            "tblFin_PolicyCharges"
          }, "dbo.spGetChargeCodesByState", new object[2]
          {
            (object) "@StateID",
            ((UltraCombo) this.cboState).Value
          });
          this.LoadStateRequiredData(((UltraCombo) this.cboState).Value.ToString());
        }
        finally
        {
          this.Cursor = MgaCursors.Default;
        }
      }
    }
    ((UltraCombo) this.cboChargeName).Value = (object) null;
    ((UltraCombo) this.cboChargeName).Text = string.Empty;
    this.OnStateValueChange(RuntimeHelpers.GetObjectValue(((UltraCombo) this.cboState).Value));
  }

  private void CreateLabel(string labelText, Point pnt, int tag)
  {
    Label label = new Label();
    label.AutoSize = true;
    label.BackColor = Color.Transparent;
    label.Location = pnt;
    label.Name = ("lbl" + labelText).Replace(" ", string.Empty);
    label.Size = new Size(115, 13);
    label.Text = labelText;
    label.TextAlign = ContentAlignment.MiddleRight;
    label.Tag = (object) tag;
    ((Control) this.tabFilingStateInfo).Controls.Add((Control) label);
  }

  private void CreateDateTimePicker(string name, Point pnt, int tag)
  {
    MGADateTimePicker mgaDateTimePicker = new MGADateTimePicker();
    ((UltraDateTimeEditor) mgaDateTimePicker).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) mgaDateTimePicker).Location = pnt;
    mgaDateTimePicker.MGAStyle = (MGAStyles) 2;
    ((Control) mgaDateTimePicker).Name = ("dt" + name).Replace(" ", string.Empty);
    ((Control) mgaDateTimePicker).Tag = (object) tag;
    ((Control) mgaDateTimePicker).Size = new Size(95, 19);
    ((UltraControlBase) mgaDateTimePicker).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) mgaDateTimePicker).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) mgaDateTimePicker).Value = (object) null;
    ((Control) this.tabFilingStateInfo).Controls.Add((Control) mgaDateTimePicker);
  }

  private void RemoveRBControls()
  {
    for (int index = ((Control) this.tabFilingStateInfo).Controls.Count - 1; index >= 0; index += -1)
    {
      if (((Control) this.tabFilingStateInfo).Controls[index] is MGADateTimePicker control && ((Control) control).Tag != null && Conversions.ToInteger(((Control) control).Tag) != 101)
      {
        ((Control) this.tabFilingStateInfo).Controls.RemoveAt(index);
        ((Component) control).Dispose();
      }
    }
    for (int index = ((Control) this.tabFilingStateInfo).Controls.Count - 1; index >= 0; index += -1)
    {
      if (((Control) this.tabFilingStateInfo).Controls[index] is Label control && control.Tag != null && Conversions.ToInteger(control.Tag) != 101)
      {
        ((Control) this.tabFilingStateInfo).Controls.RemoveAt(index);
        control.Dispose();
      }
    }
  }

  private void LoadStateRequiredData(string StateID)
  {
    this.ds.tblStatesSLRequiredData.Rows.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblStatesSLRequiredData"
    }, "dbo.spGetRequiredSLDataByState", new object[2]
    {
      (object) "@StateID",
      (object) StateID
    });
    this.RemoveRBControls();
    if (this.ds.tblStatesSLRequiredData.Rows.Count <= 0)
      return;
    int x1 = 125;
    int y1 = 45;
    int x2 = 273;
    int y2 = 42;
    int num = 0;
    bool flag = false;
    try
    {
      foreach (dsFilingPolicyInfo.tblStatesSLRequiredDataRow row in this.ds.tblStatesSLRequiredData.Rows)
      {
        ++num;
        if (num > 6 && !flag)
        {
          x1 = 495;
          y1 = 48 /*0x30*/;
          x2 = 660;
          y2 = 45;
          flag = true;
        }
        Point pnt1 = new Point(x1, y1);
        this.CreateLabel(row.RequiredData, pnt1, row.RequiredDataID);
        Point pnt2 = new Point(x2, y2);
        this.CreateDateTimePicker(row.RequiredData, pnt2, row.RequiredDataID);
        y1 += 29;
        y2 += 29;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void SetCheckRequestDate(bool clearDate)
  {
    if (!this.CanUpdateFilingInfo())
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      object obj = (object) null;
      if (!clearDate)
        obj = ((UltraDateTimeEditor) this.dtCheckReqDate).Value == null || ((UltraDateTimeEditor) this.dtCheckReqDate).Value == DBNull.Value ? (object) DateAndTime.Now : (object) (DateTime) ((UltraDateTimeEditor) this.dtCheckReqDate).Value;
      RowEnumerator enumerator = ((UltraGridBase) this.gridFilingInformation).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        if (current.Selected)
        {
          int optionFeeID = (int) current.Cells["OptionFeeID"].Value;
          object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ID FROM tblPolicyFilingManagementInfo (NOLOCK) WHERE OptionFeeID = @OPF", new object[2]
          {
            (object) "@OPF",
            (object) optionFeeID
          }));
          if (clearDate || objectValue != DBNull.Value && objectValue != null)
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblPolicyFilingManagementInfo SET CheckRequestDate = @crd WHERE ID = @id", new object[4]
            {
              (object) "@crd",
              obj,
              (object) "@id",
              objectValue
            });
          else
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO tblPolicyFilingManagementInfo(CheckRequestDate, OptionFeeID) VALUES(@crd,@ofID)", new object[4]
            {
              (object) "@crd",
              obj,
              (object) "@ofID",
              (object) optionFeeID
            });
          current.Cells["IsCheckRequestDate"].Value = (object) !clearDate;
          this.UpdateInvoiceItemsPayees(optionFeeID, RuntimeHelpers.GetObjectValue(obj));
        }
      }
      ((UltraGridBase) this.gridFilingInformation).UpdateData();
      this.SetActiveRow();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void lnkSetCheckRequestDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCheckRequestDate(false);
  }

  private void lnkClearCheckRequestDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetCheckRequestDate(true);
    ((UltraDateTimeEditor) this.dtCheckReqDate).Value = (object) null;
  }

  private void UpdateInvoiceItemsPayees(int optionFeeID, object checkRequestDate)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteNonQuery("dbo.spUpdateInvoicedItemsPayeesCheckRequestedDate", new object[4]
      {
        (object) "@optionFeeID",
        (object) optionFeeID,
        (object) "@checkRequestDate",
        Interaction.IIf(checkRequestDate == null, (object) DBNull.Value, RuntimeHelpers.GetObjectValue(checkRequestDate))
      });
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    if (checkRequestDate == null)
    {
      int num1 = (int) MessageBox.Show("The check request date has been cleared.", "Request Date Cleared", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      int num2 = (int) MessageBox.Show($"The check request date was set to {Conversions.ToDate(checkRequestDate).ToShortDateString()}.", "Request Date Set", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
  }

  private bool CanUpdateFilingInfo()
  {
    bool flag;
    if (!SecurityManager.Instance.AssertPermission("{3C09B8C9-FD5D-4b22-A124-D395E38BF4D1}"))
    {
      int num = (int) MessageBox.Show("You do not have sufficient security permissions to update filing information.", "Insufficient Security Permissions", MessageBoxButtons.OK);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void ClearGroupBoxes(GroupBox grpBox)
  {
    try
    {
      foreach (Control control in grpBox.Controls)
      {
        MGADateTimePicker mgaDateTimePicker = control as MGADateTimePicker;
        RadioButton radioButton = control as RadioButton;
        if (mgaDateTimePicker != null)
          ((UltraDateTimeEditor) mgaDateTimePicker).Value = (object) null;
        if (radioButton != null)
          radioButton.Checked = false;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkClearSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (Control control in ((Control) this.tabSearch).Controls)
      {
        MGADateTimePicker mgaDateTimePicker = control as MGADateTimePicker;
        MGATextBox mgaTextBox = control as MGATextBox;
        MGASimpleComboBox mgaSimpleComboBox = control as MGASimpleComboBox;
        MGAComboBox mgaComboBox = control as MGAComboBox;
        MGACheckBox mgaCheckBox = control as MGACheckBox;
        if (control is GroupBox grpBox)
          this.ClearGroupBoxes(grpBox);
        if (mgaDateTimePicker != null)
          ((UltraDateTimeEditor) mgaDateTimePicker).Value = (object) null;
        if (mgaTextBox != null)
          ((TextEditorControlBase) mgaTextBox).Text = string.Empty;
        if (mgaSimpleComboBox != null)
          ((UltraCombo) mgaSimpleComboBox).Value = (object) null;
        if (mgaComboBox != null)
          ((UltraCombo) mgaComboBox).Value = (object) null;
        if (mgaCheckBox != null)
          ((UltraToggleEditorBase) mgaCheckBox).Checked = false;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    int num = ((CheckedListBox) this.lstIssuingOffices).Items.Count - 1;
    for (int index = 0; index <= num; ++index)
      ((CheckedListBox) this.lstIssuingOffices).SetItemChecked(index, this._defaultAllIssuingLocations);
  }

  private void btnOffset_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in this.gridFilingInformation.Selected.Rows)
    {
      row.Appearance.ForeColor = Color.Red;
      row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
      DefaultDatabase.ExecuteNonQuery("dbo.spOffSetFee", new object[4]
      {
        (object) "@OptionFeeID",
        (object) Conversions.ToInteger(row.Cells["OptionFeeID"].Value),
        (object) "@offSetType",
        (object) "S"
      });
    }
  }

  private void btnUndoOffset_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridFilingInformation).Rows)
    {
      UltraGridRow ultraGridRow1;
      UltraGridRow ultraGridRow2 = ultraGridRow1 = row;
      if (ultraGridRow2.Appearance.FontData.Strikeout == 1)
        ultraGridRow2.Appearance.FontData.Strikeout = (DefaultableBoolean) 2;
      DefaultDatabase.ExecuteNonQuery("dbo.spOffSetFee", new object[4]
      {
        (object) "@OptionFeeID",
        (object) Conversions.ToInteger(ultraGridRow1.Cells["OptionFeeID"].Value),
        (object) "@offSetType",
        (object) "U"
      });
    }
  }

  protected virtual void btnExcelExport_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridFilingInformation).Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("There are no records to display.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      dsFilingPolicyInfo.PolicyFilingInformationDataTable informationDataTable = (dsFilingPolicyInfo.PolicyFilingInformationDataTable) this.ds.PolicyFilingInformation.Clone();
      try
      {
        foreach (dsFilingPolicyInfo.PolicyFilingInformationRow row in this.ds.PolicyFilingInformation.Rows)
          informationDataTable.ImportRow((DataRow) row);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        foreach (DataRow row in this._dtHiddenCols.Rows)
          informationDataTable.Columns.Remove(row["ColumnName"].ToString());
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      using (SaveFileDialog saveFileDialog = new SaveFileDialog())
      {
        saveFileDialog.Filter = "Excel Files (*.xls)|*.xls|All Files (*.*)|*.*";
        saveFileDialog.DefaultExt = "xls";
        if (saveFileDialog.ShowDialog((IWin32Window) this) != DialogResult.OK)
          return;
        ExcelExport.ToExcel((DataTable) informationDataTable, saveFileDialog.FileName);
      }
    }
  }

  private void chkHideFeeColumn_CheckedChanged(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["ChargeName"].Hidden = ((UltraToggleEditorBase) this.chkHideFeeColumn).Checked;
  }

  private void chkHidePolicyNumberColumn_CheckedChanged(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["PolicyNumber"].Hidden = ((UltraToggleEditorBase) this.chkHidePolicyNumberColumn).Checked;
  }

  private void chkHideCarrierColumn_CheckedChanged(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["Carrier"].Hidden = ((UltraToggleEditorBase) this.chkHideCarrierColumn).Checked;
  }

  private void chkHideTransactionType_CheckedChanged(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["TransactionType"].Hidden = ((UltraToggleEditorBase) this.chkHideTransactionType).Checked;
  }

  private void chkHideUnderwriter_CheckedChanged(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["Underwriter"].Hidden = ((UltraToggleEditorBase) this.chkHideUnderwriter).Checked;
  }

  private void chkHideInsured_CheckedChanged(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["InsuredPolicyName"].Hidden = ((UltraToggleEditorBase) this.chkHideInsured).Checked;
  }

  private void chkHideAffidavitNumber_CheckedChanged(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["AffidavitNumber"].Hidden = ((UltraToggleEditorBase) this.chkHideAffidavitNumber).Checked;
  }

  private void chkHidePolicyStatus_CheckedChanged(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridFilingInformation).DisplayLayout.Bands[0].Columns["PolicyStatus"].Hidden = ((UltraToggleEditorBase) this.chkHidePolicyStatus).Checked;
  }

  private void HideColumns()
  {
    this.chkHideFeeColumn_CheckedChanged((object) null, EventArgs.Empty);
    this.chkHidePolicyNumberColumn_CheckedChanged((object) null, EventArgs.Empty);
    this.chkHideCarrierColumn_CheckedChanged((object) null, EventArgs.Empty);
    this.chkHideTransactionType_CheckedChanged((object) null, EventArgs.Empty);
    this.chkHideUnderwriter_CheckedChanged((object) null, EventArgs.Empty);
    this.chkHideUnderwriter_CheckedChanged((object) null, EventArgs.Empty);
    this.chkHideAffidavitNumber_CheckedChanged((object) null, EventArgs.Empty);
    this.chkHidePolicyStatus_CheckedChanged((object) null, EventArgs.Empty);
  }

  private void btnAggregateReport_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridFilingInformation).Rows.Count < 1)
      return;
    dsFilingPolicyInfo.PolicyFilingInformationDataTable informationDataTable = (dsFilingPolicyInfo.PolicyFilingInformationDataTable) this.ds.PolicyFilingInformation.Clone();
    informationDataTable.Rows.Clear();
    try
    {
      foreach (dsFilingPolicyInfo.PolicyFilingInformationRow row in this.ds.PolicyFilingInformation.Rows)
      {
        if (informationDataTable.Select($"[PolicyNumber]= '{row.PolicyNumber}'").Length == 0)
        {
          informationDataTable.ImportRow((DataRow) row);
        }
        else
        {
          dsFilingPolicyInfo.PolicyFilingInformationRow filingInformationRow = (dsFilingPolicyInfo.PolicyFilingInformationRow) informationDataTable.Select($"[PolicyNumber]='{row.PolicyNumber}'")[0];
          filingInformationRow.TaxDue = Decimal.Add(filingInformationRow.TaxDue, row.TaxDue);
          filingInformationRow.FeesDue = Decimal.Add(filingInformationRow.FeesDue, row.FeesDue);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      if (((UltraGridBase) this.gridFilingInformation).Rows.Count < 1)
        return;
      saveFileDialog.Filter = "Excel Files (*.xls)|*.xls|All Files (*.*)|*.*";
      saveFileDialog.DefaultExt = "xls";
      if (saveFileDialog.ShowDialog((IWin32Window) this) != DialogResult.OK)
        return;
      ExcelExport.ToExcel((DataTable) informationDataTable, saveFileDialog.FileName);
    }
  }

  private void SetPolicyTotals(int controlNo)
  {
    this.lblStatePremiumAmount_Pol.Text = 0M.ToString("c");
    object objectValue1 = RuntimeHelpers.GetObjectValue(this.ds.PolicyFilingInformation.Compute("SUM(StatePremium)", "ControlNo=" + controlNo.ToString()));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue1)))
      this.lblStatePremiumAmount_Pol.Text = Conversions.ToDecimal(objectValue1).ToString("c");
    this.lblTaxDueAmount_Pol.Text = 0M.ToString("c");
    object objectValue2 = RuntimeHelpers.GetObjectValue(this.ds.PolicyFilingInformation.Compute("SUM(TaxDue)", "ControlNo=" + controlNo.ToString()));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue2)))
      this.lblTaxDueAmount_Pol.Text = Conversions.ToDecimal(objectValue2).ToString("c");
    this.lblFeesDueAmount_Pol.Text = 0M.ToString("c");
    object objectValue3 = RuntimeHelpers.GetObjectValue(this.ds.PolicyFilingInformation.Compute("SUM(FeesDue)", "ControlNo=" + controlNo.ToString()));
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue3)))
      this.lblFeesDueAmount_Pol.Text = Conversions.ToDecimal(objectValue3).ToString("c");
    this.lblTaxableFeeAmount_Pol_Amount.Text = 0M.ToString("c");
    object objectValue4 = RuntimeHelpers.GetObjectValue(this.ds.PolicyFilingInformation.Compute("SUM(TaxableFeesAmount)", "ControlNo=" + controlNo.ToString()));
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue4)))
      return;
    this.lblTaxableFeeAmount_Pol_Amount.Text = Conversions.ToDecimal(objectValue4).ToString("c");
  }

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    return this._activeQuote.RecreateEntityInitialize(entityGuid);
  }

  private enum _dtpTag
  {
    FilingDone = 1,
    DecPageFiled = 2,
    DSFFillDate = 3,
    MonthlyReportDue = 4,
    QuarterlyReportDue = 5,
    SemiAnnualReportDue = 6,
    AnnualReportDue = 7,
    MunicipalFilingDue = 8,
    RevenueSurchargeDue = 9,
    FireTaxDue = 10, // 0x0000000A
    ControlsFiledDate = 11, // 0x0000000B
    NotToBeRemoved = 101, // 0x00000065
  }

  protected delegate void HandleErrorOnUIThread(Exception ex);

  private struct QuoteStructure
  {
    public int QuoteID;
    public string lineName;
  }

  private sealed class ClientOffice
  {
    private readonly Guid _clientOfficeGuid;
    private readonly string _locationName;

    public ClientOffice(Guid clientOfficeGuid, string locationName)
    {
      this._clientOfficeGuid = clientOfficeGuid;
      this._locationName = locationName;
    }

    public override string ToString() => this._locationName;

    public Guid ClientOfficeGuid => this._clientOfficeGuid;

    public string LocationName => this._locationName;
  }
}
