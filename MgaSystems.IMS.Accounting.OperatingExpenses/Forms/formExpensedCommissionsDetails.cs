// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formExpensedCommissionsDetails
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.OperatingExpenses.UserControls;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Accounting.SharedForms;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formExpensedCommissionsDetails : AccountingNoteDocumentSupport
{
  private UltraLabel ultraLabel1;
  private Label label2;
  private PictureBox pictureBox1;
  private Panel panel2;
  private MGAButton buttonCancel;
  private Label label4;
  private UltraGrid gridCommissionDetails;
  private dsExpenseCommissionDetails dsExpenseCommissionDetails1;
  private Label labelHeader;
  private SqlDataAdapter daInvoiceList;
  private SqlCommand sqlSelectCommand1;
  private SqlDataAdapter daDetailList;
  private SqlCommand sqlSelectCommand2;
  private MGAButton buttonCreateCheck;
  private UltraDataSource dsSummaryData;
  private UltraGroupBox groupAddExpenseOffset;
  private UltraLabel ultraLabel5;
  private MGATextBox textAmount;
  private UltraLabel ultraLabel7;
  private MGAButton buttonAddExpense;
  private MGAButton buttonCancelAddExpense;
  private UltraGrid gridExpenseOffset;
  private UltraLabel ultraLabel9;
  private dsExpenses dsExpenses1;
  private UltraDataSource dsExpenseOffset;
  private ExtendedTreeViewDropDown dropTreeGLAccounts;
  private MGASimpleComboBox comboExpenses;
  private UltraLabel ultraLabel11;
  private Panel panelStep1;
  private LinkLabel linkProportionalDue;
  private LinkLabel linkTotalCommissions;
  private LinkLabel linkARFull;
  private UltraLabel labelProportional;
  private UltraLabel labelArFullyRcvd;
  private UltraLabel labelTotalCommissions;
  private UltraLabel ultraLabel4;
  private UltraLabel ultraLabel3;
  private UltraLabel ultraLabel2;
  private UltraLabel ultraLabel8;
  private UltraLabel ultraLabel6;
  private Panel panelExpenseOffset;
  private Panel panel3;
  private ExtendedTreeViewDropDown dropTreeAccountOffset;
  private UltraLabel ultraLabel12;
  private UltraGroupBox groupQuickPayment;
  private UltraLabel ultraLabel14;
  private UltraLabel ultraLabel15;
  private MGAButton btnBack;
  private MGAButton btnNext;
  private UltraLabel ultraLabel13;
  private dsBankAccounts dsBankAccounts1;
  private MGASimpleComboBox comboBankAccount;
  private SqlConnection sqlConnection1;
  private SqlDataAdapter daGetBankAccounts;
  private SqlCommand sqlSelectCommand3;
  private Panel pnlCash;
  private Label lblCash;
  private Panel pnlExpenseOffset;
  private Label lblExpenseOffset;
  private Label lblInvoices;
  private UltraLabel ultraLabel16;
  private UltraLabel ultraLabel17;
  private MGADateTimePicker dateTransactionDate;
  private Panel panelSummary;
  private UltraLabel ultraLabel18;
  private UltraLabel ultraLabel19;
  private Label label1;
  private UltraLabel ultraLabel20;
  private MGATextBox textComments;
  private MGASimpleComboBox comboPaymentMethods;
  private UltraLabel labelPayMethod;
  private dsPaymentMethods dsPaymentMethods1;
  private Label label3;
  private Label label5;
  private Label label6;
  private Panel panelTop;
  private SqlDataAdapter daGetCostCenters;
  private SqlCommand sqlCommand1;
  private MGASimpleComboBox comboCostCenter;
  private UltraLabel CostCenter;
  private UltraGrid gridPaidInvoiceList;
  private BindingSource invoiceSummaryBindingSource;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _formExpensedCommissionsDetails_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formExpensedCommissionsDetails_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formExpensedCommissionsDetails_Toolbars_Dock_Area_Top;
  private IContainer components;
  private Guid _payeeGuid;
  private string _payeeName;
  private int _glCompanyId;
  private Decimal _totalCommissions;
  private Decimal _commissionsDueFullAR;
  private Decimal _commissionsDueProportional;
  private bool _transactionUpdateRequired;
  private Decimal transactionTotal;
  private Decimal expenseTotal;
  private OperatingTransaction _tran;
  private OperatingTransaction temp_tran;
  private formExpensedCommissionsDetails.WizardStep _currentWizardStep;
  private bool _hasPopulatedCheckInfo;
  private ArrayList _invoiceList = new ArrayList();

  private formExpensedCommissionsDetails()
  {
    this.InitializeComponent();
    this.panelExpenseOffset.SendToBack();
    this.panelSummary.SendToBack();
  }

  public formExpensedCommissionsDetails(
    int glCompanyId,
    string payeeName,
    Guid payeeGuid,
    Decimal totalCommissions,
    Decimal commissionsDueFullAR,
    Decimal commissionsDueProportional)
  {
    this.InitializeComponent();
    this.panelExpenseOffset.SendToBack();
    this.panelSummary.SendToBack();
    this._glCompanyId = glCompanyId;
    this._payeeName = payeeName;
    this._payeeGuid = payeeGuid;
    this._totalCommissions = totalCommissions;
    this.linkTotalCommissions.Visible = totalCommissions != 0M;
    this._commissionsDueFullAR = commissionsDueFullAR;
    this.linkARFull.Visible = commissionsDueFullAR != 0M;
    this._commissionsDueProportional = commissionsDueProportional;
    this.linkProportionalDue.Visible = commissionsDueProportional != 0M;
    this.labelHeader.Text = this._payeeName + " - Expensed Commissions";
    ((Control) this.labelTotalCommissions).Text = this._totalCommissions.ToString("c");
    ((Control) this.labelArFullyRcvd).Text = this._commissionsDueFullAR.ToString("c");
    ((Control) this.labelProportional).Text = this._commissionsDueProportional.ToString("c");
    this.LoadInvoiceList();
    this.LoadExpenses();
    this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyId);
    this.dropTreeAccountOffset.LoadGLAccounts(this._glCompanyId);
    this.LoadBankAccounts(this._glCompanyId);
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
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Band 0", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GLAccountId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GLAccount");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Expense");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Amount");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("expenseCode");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CostCenterId");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CostCenterName");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraDataColumn ultraDataColumn1 = new UltraDataColumn("GLAccountId");
    UltraDataColumn ultraDataColumn2 = new UltraDataColumn("GLAccount");
    UltraDataColumn ultraDataColumn3 = new UltraDataColumn("Expense");
    UltraDataColumn ultraDataColumn4 = new UltraDataColumn("Amount");
    UltraDataColumn ultraDataColumn5 = new UltraDataColumn("expenseCode");
    UltraDataColumn ultraDataColumn6 = new UltraDataColumn("CostCenterId");
    UltraDataColumn ultraDataColumn7 = new UltraDataColumn("CostCenterName");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formExpensedCommissionsDetails));
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraDataColumn ultraDataColumn8 = new UltraDataColumn("Description");
    UltraDataColumn ultraDataColumn9 = new UltraDataColumn("Amount");
    UltraDataColumn ultraDataColumn10 = new UltraDataColumn("GLAcctID");
    Appearance appearance28 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("InvoiceList", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("InsuredName");
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PolicyNumber");
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("InvoiceDate");
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("EffectiveDate");
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("PercentRCVD");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("InvoiceListInvoiceDetailList");
    UltraGridBand ultraGridBand3 = new UltraGridBand("InvoiceListInvoiceDetailList", 0);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Description");
    Appearance appearance39 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("GrossBilled");
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("AgencyGross");
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("NetBilled");
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("AmtRcvd");
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("AgencyCommission");
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("PayeePercentRate");
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("PayeeAmt");
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Balance");
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("PercentageReceived");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("ChargeType");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("PropAmtDue");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("amtptd");
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("PayAmount", 0);
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
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    Appearance appearance78 = new Appearance();
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("InvoiceSummary", -1);
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("PolicyNum");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("Amount");
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    Appearance appearance86 = new Appearance();
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    Appearance appearance89 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance90 = new Appearance();
    Appearance appearance91 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("InvoicesLayout");
    Appearance appearance92 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("InvoiceSummary", -1);
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("Amount");
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("PolicyNum");
    Appearance appearance95 = new Appearance();
    Appearance appearance96 = new Appearance();
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("InvoiceNum");
    Appearance appearance97 = new Appearance();
    Appearance appearance98 = new Appearance();
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Description");
    Appearance appearance99 = new Appearance();
    Appearance appearance100 = new Appearance();
    Appearance appearance101 = new Appearance();
    Appearance appearance102 = new Appearance();
    Appearance appearance103 = new Appearance();
    Appearance appearance104 = new Appearance();
    Appearance appearance105 = new Appearance();
    Appearance appearance106 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    Appearance appearance109 = new Appearance();
    Appearance appearance110 = new Appearance();
    Appearance appearance111 = new Appearance();
    Appearance appearance112 = new Appearance();
    Appearance appearance113 = new Appearance();
    Appearance appearance114 = new Appearance();
    Appearance appearance115 = new Appearance();
    Appearance appearance116 = new Appearance();
    Appearance appearance117 = new Appearance();
    Appearance appearance118 = new Appearance();
    Appearance appearance119 = new Appearance();
    Appearance appearance120 = new Appearance();
    Appearance appearance121 = new Appearance();
    Appearance appearance122 = new Appearance();
    Appearance appearance123 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool = new PopupMenuTool("gridContext");
    ButtonTool buttonTool1 = new ButtonTool("PAYBALANCE");
    ButtonTool buttonTool2 = new ButtonTool("CLEARAMT");
    ButtonTool buttonTool3 = new ButtonTool("PAYBALANCE");
    Appearance appearance124 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("CLEARAMT");
    Appearance appearance125 = new Appearance();
    this.gridExpenseOffset = new UltraGrid();
    this.dsExpenseOffset = new UltraDataSource(this.components);
    this.groupAddExpenseOffset = new UltraGroupBox();
    this.comboCostCenter = new MGASimpleComboBox();
    this.CostCenter = new UltraLabel();
    this.ultraLabel11 = new UltraLabel();
    this.comboExpenses = new MGASimpleComboBox();
    this.ultraLabel9 = new UltraLabel();
    this.buttonAddExpense = new MGAButton();
    this.buttonCancelAddExpense = new MGAButton();
    this.ultraLabel7 = new UltraLabel();
    this.textAmount = new MGATextBox();
    this.ultraLabel5 = new UltraLabel();
    this.dropTreeGLAccounts = new ExtendedTreeViewDropDown();
    this.dsSummaryData = new UltraDataSource(this.components);
    this.panelStep1 = new Panel();
    this.gridCommissionDetails = new UltraGrid();
    this.dsExpenseCommissionDetails1 = new dsExpenseCommissionDetails();
    this.comboBankAccount = new MGASimpleComboBox();
    this.dsBankAccounts1 = new dsBankAccounts();
    this.ultraLabel13 = new UltraLabel();
    this.dropTreeAccountOffset = new ExtendedTreeViewDropDown();
    this.groupQuickPayment = new UltraGroupBox();
    this.linkARFull = new LinkLabel();
    this.labelProportional = new UltraLabel();
    this.labelArFullyRcvd = new UltraLabel();
    this.labelTotalCommissions = new UltraLabel();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.linkProportionalDue = new LinkLabel();
    this.linkTotalCommissions = new LinkLabel();
    this.ultraLabel12 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.ultraLabel1 = new UltraLabel();
    this.panelSummary = new Panel();
    this.gridPaidInvoiceList = new UltraGrid();
    this.invoiceSummaryBindingSource = new BindingSource(this.components);
    this.label5 = new Label();
    this.label3 = new Label();
    this.labelPayMethod = new UltraLabel();
    this.comboPaymentMethods = new MGASimpleComboBox();
    this.dsPaymentMethods1 = new dsPaymentMethods();
    this.textComments = new MGATextBox();
    this.ultraLabel20 = new UltraLabel();
    this.label1 = new Label();
    this.ultraLabel19 = new UltraLabel();
    this.ultraLabel17 = new UltraLabel();
    this.pnlCash = new Panel();
    this.lblCash = new Label();
    this.pnlExpenseOffset = new Panel();
    this.label6 = new Label();
    this.lblExpenseOffset = new Label();
    this.lblInvoices = new Label();
    this.dateTransactionDate = new MGADateTimePicker();
    this.ultraLabel16 = new UltraLabel();
    this.ultraLabel18 = new UltraLabel();
    this.panelExpenseOffset = new Panel();
    this.panel3 = new Panel();
    this.ultraLabel14 = new UltraLabel();
    this.ultraLabel15 = new UltraLabel();
    this.panelTop = new Panel();
    this.label2 = new Label();
    this.labelHeader = new Label();
    this.pictureBox1 = new PictureBox();
    this.panel2 = new Panel();
    this.btnBack = new MGAButton();
    this.btnNext = new MGAButton();
    this.buttonCreateCheck = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.label4 = new Label();
    this.daInvoiceList = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.daDetailList = new SqlDataAdapter();
    this.sqlSelectCommand2 = new SqlCommand();
    this.sqlConnection1 = new SqlConnection();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.sqlSelectCommand3 = new SqlCommand();
    this.daGetCostCenters = new SqlDataAdapter();
    this.sqlCommand1 = new SqlCommand();
    this.dsExpenses1 = new dsExpenses();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.gridExpenseOffset).BeginInit();
    ((ISupportInitialize) this.dsExpenseOffset).BeginInit();
    ((ISupportInitialize) this.groupAddExpenseOffset).BeginInit();
    ((Control) this.groupAddExpenseOffset).SuspendLayout();
    ((ISupportInitialize) this.comboCostCenter).BeginInit();
    ((ISupportInitialize) this.comboExpenses).BeginInit();
    ((ISupportInitialize) this.buttonAddExpense).BeginInit();
    ((ISupportInitialize) this.buttonCancelAddExpense).BeginInit();
    ((ISupportInitialize) this.textAmount).BeginInit();
    ((ISupportInitialize) this.dsSummaryData).BeginInit();
    this.panelStep1.SuspendLayout();
    ((ISupportInitialize) this.gridCommissionDetails).BeginInit();
    this.dsExpenseCommissionDetails1.BeginInit();
    ((ISupportInitialize) this.comboBankAccount).BeginInit();
    this.dsBankAccounts1.BeginInit();
    ((ISupportInitialize) this.groupQuickPayment).BeginInit();
    ((Control) this.groupQuickPayment).SuspendLayout();
    this.panelSummary.SuspendLayout();
    ((ISupportInitialize) this.gridPaidInvoiceList).BeginInit();
    ((ISupportInitialize) this.invoiceSummaryBindingSource).BeginInit();
    ((ISupportInitialize) this.comboPaymentMethods).BeginInit();
    this.dsPaymentMethods1.BeginInit();
    ((ISupportInitialize) this.textComments).BeginInit();
    this.pnlExpenseOffset.SuspendLayout();
    ((ISupportInitialize) this.dateTransactionDate).BeginInit();
    this.panelExpenseOffset.SuspendLayout();
    this.panel3.SuspendLayout();
    this.panelTop.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.btnBack).BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.buttonCreateCheck).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.dsExpenses1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.gridExpenseOffset).DataSource = (object) this.dsExpenseOffset;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Gl Account ID";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 153;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "GL Account";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 241;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.Width = 192 /*0xC0*/;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 4;
    ultraGridColumn4.Width = 130;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 5;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 85;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 85;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Cost Center";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 2;
    ultraGridColumn7.Width = 171;
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
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = Color.Transparent;
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance15).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridExpenseOffset).Dock = DockStyle.Fill;
    ((Control) this.gridExpenseOffset).Location = new Point(272, 0);
    ((Control) this.gridExpenseOffset).Name = "gridExpenseOffset";
    ((Control) this.gridExpenseOffset).Size = new Size(736, 609);
    ((Control) this.gridExpenseOffset).TabIndex = 1;
    ((UltraControlBase) this.gridExpenseOffset).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridExpenseOffset).UseOsThemes = (DefaultableBoolean) 2;
    this.gridExpenseOffset.BeforeRowsDeleted += new BeforeRowsDeletedEventHandler(this.gridExpenseOffset_BeforeRowsDeleted);
    this.dsExpenseOffset.Band.AllowDelete = (DefaultableBoolean) 1;
    ultraDataColumn1.DataType = typeof (int);
    ultraDataColumn1.ReadOnly = (DefaultableBoolean) 1;
    ultraDataColumn2.ReadOnly = (DefaultableBoolean) 1;
    ultraDataColumn3.ReadOnly = (DefaultableBoolean) 1;
    ultraDataColumn4.DataType = typeof (Decimal);
    ultraDataColumn4.ReadOnly = (DefaultableBoolean) 1;
    ultraDataColumn5.DataType = typeof (int);
    this.dsExpenseOffset.Band.Columns.AddRange(new object[7]
    {
      (object) ultraDataColumn1,
      (object) ultraDataColumn2,
      (object) ultraDataColumn3,
      (object) ultraDataColumn4,
      (object) ultraDataColumn5,
      (object) ultraDataColumn6,
      (object) ultraDataColumn7
    });
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance17).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance17).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupAddExpenseOffset.Appearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupAddExpenseOffset.ContentAreaAppearance = (AppearanceBase) appearance18;
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.comboCostCenter);
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.CostCenter);
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.ultraLabel11);
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.comboExpenses);
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.ultraLabel9);
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.buttonAddExpense);
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.buttonCancelAddExpense);
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.ultraLabel7);
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.textAmount);
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.ultraLabel5);
    ((Control) this.groupAddExpenseOffset).Controls.Add((Control) this.dropTreeGLAccounts);
    ((AppearanceBase) appearance19).ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupAddExpenseOffset.HeaderAppearance = (AppearanceBase) appearance19;
    ((Control) this.groupAddExpenseOffset).Location = new Point(16 /*0x10*/, 104);
    ((Control) this.groupAddExpenseOffset).Name = "groupAddExpenseOffset";
    ((Control) this.groupAddExpenseOffset).Size = new Size(248, 352);
    ((Control) this.groupAddExpenseOffset).TabIndex = 0;
    ((Control) this.groupAddExpenseOffset).Text = "Expense Offset";
    this.comboCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenter).Location = new Point(10, 82);
    this.comboCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenter).Name = "comboCostCenter";
    ((Control) this.comboCostCenter).Size = new Size(230, 21);
    ((Control) this.comboCostCenter).TabIndex = 52;
    ((UltraControlBase) this.comboCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance20).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance20).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance20).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance20).ForeColor = Color.Gray;
    ((ControlBase) this.CostCenter).Appearance = (AppearanceBase) appearance20;
    ((Control) this.CostCenter).AutoSize = true;
    ((Control) this.CostCenter).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.CostCenter).Location = new Point(8, 66);
    ((Control) this.CostCenter).Name = "CostCenter";
    ((Control) this.CostCenter).Size = new Size(68, 15);
    ((Control) this.CostCenter).TabIndex = 51;
    ((Control) this.CostCenter).Text = "Cost Center";
    ((AppearanceBase) appearance21).BackColor = Color.White;
    ((AppearanceBase) appearance21).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance21).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance21).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance21).ForeColor = Color.IndianRed;
    ((ControlBase) this.ultraLabel11).Appearance = (AppearanceBase) appearance21;
    ((Control) this.ultraLabel11).Font = new Font("Tahoma", 8f);
    ((Control) this.ultraLabel11).Location = new Point(8, 215);
    ((Control) this.ultraLabel11).Name = "ultraLabel11";
    ((Control) this.ultraLabel11).Size = new Size(216, 40);
    ((Control) this.ultraLabel11).TabIndex = 50;
    ((Control) this.ultraLabel11).Text = "NOTE: Positive amounts will result in a credit to the Expense GL Account and a debit to the Income/Offset Gl Account.";
    this.comboExpenses.BorderStyle = (UIElementBorderStyle) 4;
    this.comboExpenses.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboExpenses).Location = new Point(8, 128 /*0x80*/);
    this.comboExpenses.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboExpenses).Name = "comboExpenses";
    ((Control) this.comboExpenses).Size = new Size(232, 21);
    ((Control) this.comboExpenses).TabIndex = 46;
    ((UltraControlBase) this.comboExpenses).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboExpenses).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance22).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance22).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance22).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance22).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel9).Appearance = (AppearanceBase) appearance22;
    ((Control) this.ultraLabel9).AutoSize = true;
    ((Control) this.ultraLabel9).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel9).Location = new Point(8, 112 /*0x70*/);
    ((Control) this.ultraLabel9).Name = "ultraLabel9";
    ((Control) this.ultraLabel9).Size = new Size(50, 15);
    ((Control) this.ultraLabel9).TabIndex = 45;
    ((Control) this.ultraLabel9).Text = "Expense";
    ((Control) this.buttonAddExpense).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance23).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance23).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance23).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance23).Image = componentResourceManager.GetObject("appearance22.Image");
    ((AppearanceBase) appearance23).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonAddExpense).Appearance = (AppearanceBase) appearance23;
    ((Control) this.buttonAddExpense).Location = new Point(24, 313);
    ((Control) this.buttonAddExpense).Name = "buttonAddExpense";
    ((Control) this.buttonAddExpense).Size = new Size(104, 24);
    ((Control) this.buttonAddExpense).TabIndex = 42;
    ((Control) this.buttonAddExpense).Text = "Add Expense";
    ((UltraControlBase) this.buttonAddExpense).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonAddExpense).Click += new EventHandler(this.buttonAddExpense_Click);
    ((Control) this.buttonCancelAddExpense).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance24).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance24).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance24).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance24).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance24).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancelAddExpense).Appearance = (AppearanceBase) appearance24;
    ((Control) this.buttonCancelAddExpense).Location = new Point(136, 313);
    ((Control) this.buttonCancelAddExpense).Name = "buttonCancelAddExpense";
    ((Control) this.buttonCancelAddExpense).Size = new Size(104, 24);
    ((Control) this.buttonCancelAddExpense).TabIndex = 43;
    ((Control) this.buttonCancelAddExpense).Text = "Cancel";
    ((UltraControlBase) this.buttonCancelAddExpense).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancelAddExpense).Click += new EventHandler(this.buttonCancelAddExpense_Click);
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance25).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance25).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance25).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance25).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance25;
    ((Control) this.ultraLabel7).AutoSize = true;
    ((Control) this.ultraLabel7).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel7).Location = new Point(6, 155);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(47, 15);
    ((Control) this.ultraLabel7).TabIndex = 41;
    ((Control) this.ultraLabel7).Text = "Amount";
    ((AppearanceBase) appearance26).BackColor = Color.White;
    ((AppearanceBase) appearance26).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance26).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textAmount).Appearance = (AppearanceBase) appearance26;
    ((Control) this.textAmount).BackColor = Color.White;
    ((Control) this.textAmount).Location = new Point(8, 174);
    this.textAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.textAmount).Name = "textAmount";
    ((Control) this.textAmount).Size = new Size(232, 20);
    ((Control) this.textAmount).TabIndex = 40;
    ((UltraControlBase) this.textAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textAmount).Validating += new CancelEventHandler(this.textAmount_Validating);
    ((AppearanceBase) appearance27).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance27).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance27).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance27).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance27).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance27;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((Control) this.ultraLabel5).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel5).Location = new Point(8, 24);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(116, 15);
    ((Control) this.ultraLabel5).TabIndex = 39;
    ((Control) this.ultraLabel5).Text = "Expense GL Account";
    this.dropTreeGLAccounts.DropDownHeight = 300;
    this.dropTreeGLAccounts.DropDownWidth = 300;
    this.dropTreeGLAccounts.Font = new Font("Tahoma", 8f);
    this.dropTreeGLAccounts.Location = new Point(8, 40);
    this.dropTreeGLAccounts.Name = "dropTreeGLAccounts";
    this.dropTreeGLAccounts.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeGLAccounts.ShowEquityAccounts = true;
    this.dropTreeGLAccounts.ShowExpenseAccounts = true;
    this.dropTreeGLAccounts.ShowIncomeAccounts = true;
    this.dropTreeGLAccounts.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeGLAccounts.ShowSystemDefinedAccounts = true;
    this.dropTreeGLAccounts.Size = new Size(232, 20);
    this.dropTreeGLAccounts.TabIndex = 0;
    this.dropTreeGLAccounts.UseCheckedStateSelectionOverride = false;
    ultraDataColumn8.AllowDBNull = (DefaultableBoolean) 2;
    ultraDataColumn9.DataType = typeof (Decimal);
    ultraDataColumn9.ReadOnly = (DefaultableBoolean) 1;
    ultraDataColumn10.AllowDBNull = (DefaultableBoolean) 2;
    ultraDataColumn10.DataType = typeof (int);
    ultraDataColumn10.ReadOnly = (DefaultableBoolean) 1;
    this.dsSummaryData.Band.Columns.AddRange(new object[3]
    {
      (object) ultraDataColumn8,
      (object) ultraDataColumn9,
      (object) ultraDataColumn10
    });
    this.panelStep1.Controls.Add((Control) this.gridCommissionDetails);
    this.panelStep1.Controls.Add((Control) this.comboBankAccount);
    this.panelStep1.Controls.Add((Control) this.ultraLabel13);
    this.panelStep1.Controls.Add((Control) this.dropTreeAccountOffset);
    this.panelStep1.Controls.Add((Control) this.groupQuickPayment);
    this.panelStep1.Controls.Add((Control) this.ultraLabel12);
    this.panelStep1.Controls.Add((Control) this.ultraLabel8);
    this.panelStep1.Controls.Add((Control) this.ultraLabel6);
    this.panelStep1.Controls.Add((Control) this.ultraLabel1);
    this.panelStep1.Dock = DockStyle.Fill;
    this.panelStep1.Location = new Point(0, 80 /*0x50*/);
    this.panelStep1.Name = "panelStep1";
    this.panelStep1.Size = new Size(1008, 609);
    this.panelStep1.TabIndex = 1;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridCommissionDetails, "gridContext");
    ((UltraGridBase) this.gridCommissionDetails).DataSource = (object) this.dsExpenseCommissionDetails1;
    ((AppearanceBase) appearance28).BackColor = Color.White;
    ((AppearanceBase) appearance28).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Appearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 82;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Left";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance29;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance30;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 1;
    ultraGridColumn9.Width = 99;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance31).TextHAlignAsString = "Left";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance31;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance32;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Insured Name";
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 2;
    ultraGridColumn10.Width = 290;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Left";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance34;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 3;
    ultraGridColumn11.Width = 152;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance35).TextHAlignAsString = "Left";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance35;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance36;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 4;
    ultraGridColumn12.Width = 118;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Left";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance38;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Effective Date";
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 5;
    ultraGridColumn13.Width = 122;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 6;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 73;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 7;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 72;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 8;
    ultraGridBand2.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ultraGridBand2.SummaryFooterCaption = "";
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 0;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 89;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance39).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance39;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 1;
    ultraGridColumn18.Width = 100;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance40;
    ultraGridColumn19.Format = "c";
    ((AppearanceBase) appearance41).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance41;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Gross Billed";
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 2;
    ultraGridColumn19.Width = 72;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Right";
    ultraGridColumn20.CellAppearance = (AppearanceBase) appearance42;
    ultraGridColumn20.Format = "c";
    ((AppearanceBase) appearance43).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn20.Header).Appearance = (AppearanceBase) appearance43;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Gross Comm.";
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 3;
    ultraGridColumn20.Width = 64 /*0x40*/;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance44).TextHAlignAsString = "Right";
    ultraGridColumn21.CellAppearance = (AppearanceBase) appearance44;
    ultraGridColumn21.Format = "c";
    ((AppearanceBase) appearance45).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn21.Header).Appearance = (AppearanceBase) appearance45;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Net Billed";
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 5;
    ultraGridColumn21.Width = 71;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance46).TextHAlignAsString = "Right";
    ultraGridColumn22.CellAppearance = (AppearanceBase) appearance46;
    ultraGridColumn22.Format = "c";
    ((AppearanceBase) appearance47).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn22.Header).Appearance = (AppearanceBase) appearance47;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Amt Rcvd";
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 7;
    ultraGridColumn22.Width = 50;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance48).TextHAlignAsString = "Right";
    ultraGridColumn23.CellAppearance = (AppearanceBase) appearance48;
    ultraGridColumn23.Format = "c";
    ((AppearanceBase) appearance49).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn23.Header).Appearance = (AppearanceBase) appearance49;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "MGA Comm.";
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 4;
    ultraGridColumn23.Width = 62;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance50).TextHAlignAsString = "Right";
    ultraGridColumn24.CellAppearance = (AppearanceBase) appearance50;
    ultraGridColumn24.Format = "p";
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn24.Header).Appearance = (AppearanceBase) appearance51;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Payee %";
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 6;
    ultraGridColumn24.Width = 50;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance52).TextHAlignAsString = "Right";
    ultraGridColumn25.CellAppearance = (AppearanceBase) appearance52;
    ultraGridColumn25.Format = "c";
    ((AppearanceBase) appearance53).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn25.Header).Appearance = (AppearanceBase) appearance53;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Payee Amt.";
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 8;
    ultraGridColumn25.Width = 71;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    ultraGridColumn26.CellAppearance = (AppearanceBase) appearance54;
    ultraGridColumn26.Format = "c";
    ((AppearanceBase) appearance55).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn26.Header).Appearance = (AppearanceBase) appearance55;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 10;
    ultraGridColumn26.Width = 70;
    ultraGridColumn27.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 11;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 99;
    ultraGridColumn28.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 12;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 61;
    ultraGridColumn29.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 13;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 91;
    ultraGridColumn30.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 14;
    ultraGridColumn30.Hidden = true;
    ultraGridColumn30.Width = 89;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 15;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 71;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Right";
    ultraGridColumn32.CellAppearance = (AppearanceBase) appearance56;
    ultraGridColumn32.Format = "c";
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn32.Header).Appearance = (AppearanceBase) appearance57;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Amt PTD";
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 9;
    ultraGridColumn32.Width = 75;
    ((AppearanceBase) appearance58).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    ultraGridColumn33.CellAppearance = (AppearanceBase) appearance58;
    ultraGridColumn33.DataType = typeof (Decimal);
    ultraGridColumn33.Format = "c";
    ((AppearanceBase) appearance59).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance59).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn33.Header).Appearance = (AppearanceBase) appearance59;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Pay This";
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn33.Nullable = (Nullable) 1;
    ultraGridColumn33.Width = 77;
    ultraGridBand3.Columns.AddRange(new object[17]
    {
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
      (object) ultraGridColumn33
    });
    ultraGridBand3.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand3.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand3.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand3.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand3.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand3.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand3.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand3.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand3.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand3.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand3.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand3.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand3.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance60).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance60).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance60).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance61).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance61;
    ((AppearanceBase) appearance62).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance63).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance63;
    ((AppearanceBase) appearance64).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance64;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance65).BackColor = Color.Transparent;
    ((AppearanceBase) appearance65).ForeColor = Color.Black;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance65;
    ((AppearanceBase) appearance66).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance66;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance67).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance67;
    ((AppearanceBase) appearance68).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance68).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance68;
    ((AppearanceBase) appearance69).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance69;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridCommissionDetails).Dock = DockStyle.Fill;
    ((Control) this.gridCommissionDetails).Font = new Font("Tahoma", 8f);
    ((Control) this.gridCommissionDetails).Location = new Point(208 /*0xD0*/, 0);
    ((Control) this.gridCommissionDetails).Name = "gridCommissionDetails";
    ((Control) this.gridCommissionDetails).Size = new Size(800, 609);
    ((Control) this.gridCommissionDetails).TabIndex = 0;
    this.gridCommissionDetails.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridCommissionDetails).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCommissionDetails).UseOsThemes = (DefaultableBoolean) 2;
    this.gridCommissionDetails.AfterCellUpdate += new CellEventHandler(this.gridCommissionDetails_AfterCellUpdate);
    this.gridCommissionDetails.AfterRowExpanded += new RowEventHandler(this.gridCommissionDetails_AfterRowExpanded);
    ((Control) this.gridCommissionDetails).KeyDown += new KeyEventHandler(this.gridCommissionDetails_KeyDown);
    ((Control) this.gridCommissionDetails).KeyUp += new KeyEventHandler(this.gridCommissionDetails_KeyUp);
    this.dsExpenseCommissionDetails1.DataSetName = "dsExpenseCommissionDetails";
    this.dsExpenseCommissionDetails1.EnforceConstraints = false;
    this.dsExpenseCommissionDetails1.Locale = new CultureInfo("en-US");
    this.dsExpenseCommissionDetails1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.comboBankAccount.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboBankAccount).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.comboBankAccount).DataSource = (object) this.dsBankAccounts1;
    ((UltraDropDownBase) this.comboBankAccount).DisplayMember = "BANKNAME";
    this.comboBankAccount.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboBankAccount).DropDownWidth = 300;
    ((Control) this.comboBankAccount).Location = new Point(16 /*0x10*/, 200);
    this.comboBankAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccount).Name = "comboBankAccount";
    ((Control) this.comboBankAccount).Size = new Size(184, 21);
    ((Control) this.comboBankAccount).TabIndex = 66;
    ((UltraControlBase) this.comboBankAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboBankAccount).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboBankAccount).ValueMember = "GLACCTID";
    this.dsBankAccounts1.DataSetName = "dsBankAccounts";
    this.dsBankAccounts1.Locale = new CultureInfo("en-US");
    ((AppearanceBase) appearance70).BackColor = Color.White;
    ((AppearanceBase) appearance70).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance70).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance70).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance70).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel13).Appearance = (AppearanceBase) appearance70;
    ((Control) this.ultraLabel13).AutoSize = true;
    ((Control) this.ultraLabel13).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel13).Location = new Point(16 /*0x10*/, 184);
    ((Control) this.ultraLabel13).Name = "ultraLabel13";
    ((Control) this.ultraLabel13).Size = new Size(80 /*0x50*/, 15);
    ((Control) this.ultraLabel13).TabIndex = 65;
    ((Control) this.ultraLabel13).Text = "Bank Account";
    this.dropTreeAccountOffset.DropDownHeight = 300;
    this.dropTreeAccountOffset.DropDownWidth = 300;
    this.dropTreeAccountOffset.Font = new Font("Tahoma", 8f);
    this.dropTreeAccountOffset.Location = new Point(16 /*0x10*/, 152);
    this.dropTreeAccountOffset.Name = "dropTreeAccountOffset";
    this.dropTreeAccountOffset.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeAccountOffset.ShowEquityAccounts = true;
    this.dropTreeAccountOffset.ShowExpenseAccounts = true;
    this.dropTreeAccountOffset.ShowIncomeAccounts = true;
    this.dropTreeAccountOffset.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeAccountOffset.ShowSystemDefinedAccounts = true;
    this.dropTreeAccountOffset.Size = new Size(184, 20);
    this.dropTreeAccountOffset.TabIndex = 61;
    this.dropTreeAccountOffset.UseCheckedStateSelectionOverride = false;
    this.dropTreeAccountOffset.Load += new EventHandler(this.dropTreeAccountOffset_Load);
    ((AppearanceBase) appearance71).BackColor = Color.White;
    ((AppearanceBase) appearance71).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance71).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance71).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance71).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance71).FontData.Name = "Tahoma";
    this.groupQuickPayment.Appearance = (AppearanceBase) appearance71;
    ((Control) this.groupQuickPayment).Controls.Add((Control) this.linkARFull);
    ((Control) this.groupQuickPayment).Controls.Add((Control) this.labelProportional);
    ((Control) this.groupQuickPayment).Controls.Add((Control) this.labelArFullyRcvd);
    ((Control) this.groupQuickPayment).Controls.Add((Control) this.labelTotalCommissions);
    ((Control) this.groupQuickPayment).Controls.Add((Control) this.ultraLabel4);
    ((Control) this.groupQuickPayment).Controls.Add((Control) this.ultraLabel2);
    ((Control) this.groupQuickPayment).Controls.Add((Control) this.ultraLabel3);
    ((Control) this.groupQuickPayment).Controls.Add((Control) this.linkProportionalDue);
    ((Control) this.groupQuickPayment).Controls.Add((Control) this.linkTotalCommissions);
    ((AppearanceBase) appearance72).ForeColor = Color.DimGray;
    this.groupQuickPayment.HeaderAppearance = (AppearanceBase) appearance72;
    ((Control) this.groupQuickPayment).Location = new Point(8, 256 /*0x0100*/);
    ((Control) this.groupQuickPayment).Name = "groupQuickPayment";
    ((Control) this.groupQuickPayment).Size = new Size(184, 216);
    ((Control) this.groupQuickPayment).TabIndex = 63 /*0x3F*/;
    ((Control) this.groupQuickPayment).Text = "QUICK PAYMENT OPTIONS";
    this.linkARFull.AutoSize = true;
    this.linkARFull.BackColor = Color.FromArgb(247, 249, 253);
    this.linkARFull.LinkBehavior = LinkBehavior.HoverUnderline;
    this.linkARFull.Location = new Point(24, 120);
    this.linkARFull.Name = "linkARFull";
    this.linkARFull.Size = new Size(47, 13);
    this.linkARFull.TabIndex = 58;
    this.linkARFull.TabStop = true;
    this.linkARFull.Text = "Pay This";
    this.linkARFull.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkARFull_LinkClicked);
    ((AppearanceBase) appearance73).BackColor = Color.White;
    ((AppearanceBase) appearance73).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance73).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance73).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance73).ForeColor = Color.Gray;
    ((ControlBase) this.labelProportional).Appearance = (AppearanceBase) appearance73;
    ((Control) this.labelProportional).AutoSize = true;
    ((Control) this.labelProportional).Location = new Point(24, 168);
    ((Control) this.labelProportional).Name = "labelProportional";
    ((Control) this.labelProportional).Size = new Size(40, 15);
    ((Control) this.labelProportional).TabIndex = 57;
    ((Control) this.labelProportional).Text = "[$0.00]";
    ((AppearanceBase) appearance74).BackColor = Color.White;
    ((AppearanceBase) appearance74).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance74).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance74).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance74).ForeColor = Color.Gray;
    ((ControlBase) this.labelArFullyRcvd).Appearance = (AppearanceBase) appearance74;
    ((Control) this.labelArFullyRcvd).AutoSize = true;
    ((Control) this.labelArFullyRcvd).Location = new Point(24, 104);
    ((Control) this.labelArFullyRcvd).Name = "labelArFullyRcvd";
    ((Control) this.labelArFullyRcvd).Size = new Size(40, 15);
    ((Control) this.labelArFullyRcvd).TabIndex = 56;
    ((Control) this.labelArFullyRcvd).Text = "[$0.00]";
    ((AppearanceBase) appearance75).BackColor = Color.White;
    ((AppearanceBase) appearance75).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance75).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance75).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance75).ForeColor = Color.Gray;
    ((ControlBase) this.labelTotalCommissions).Appearance = (AppearanceBase) appearance75;
    ((Control) this.labelTotalCommissions).AutoSize = true;
    ((Control) this.labelTotalCommissions).Location = new Point(24, 40);
    ((Control) this.labelTotalCommissions).Name = "labelTotalCommissions";
    ((Control) this.labelTotalCommissions).Size = new Size(40, 15);
    ((Control) this.labelTotalCommissions).TabIndex = 55;
    ((Control) this.labelTotalCommissions).Text = "[$0.00]";
    ((AppearanceBase) appearance76).BackColor = Color.White;
    ((AppearanceBase) appearance76).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance76).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance76).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance76).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance76;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel4).Location = new Point(24, 152);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(121, 15);
    ((Control) this.ultraLabel4).TabIndex = 54;
    ((Control) this.ultraLabel4).Text = "DUE PROPORTIONAL";
    ((AppearanceBase) appearance77).BackColor = Color.White;
    ((AppearanceBase) appearance77).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance77).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance77).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance77).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance77;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((Control) this.ultraLabel2).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel2).Location = new Point(24, 24);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size((int) sbyte.MaxValue, 15);
    ((Control) this.ultraLabel2).TabIndex = 52;
    ((Control) this.ultraLabel2).Text = "TOTAL COMMISSIONS";
    ((AppearanceBase) appearance78).BackColor = Color.White;
    ((AppearanceBase) appearance78).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance78).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance78).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance78).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance78;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((Control) this.ultraLabel3).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel3).Location = new Point(24, 88);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(142, 15);
    ((Control) this.ultraLabel3).TabIndex = 53;
    ((Control) this.ultraLabel3).Text = "DUE A/R FULL RECEIVED";
    this.linkProportionalDue.AutoSize = true;
    this.linkProportionalDue.BackColor = Color.FromArgb(239, 247, 253);
    this.linkProportionalDue.LinkBehavior = LinkBehavior.HoverUnderline;
    this.linkProportionalDue.Location = new Point(24, 184);
    this.linkProportionalDue.Name = "linkProportionalDue";
    this.linkProportionalDue.Size = new Size(47, 13);
    this.linkProportionalDue.TabIndex = 60;
    this.linkProportionalDue.TabStop = true;
    this.linkProportionalDue.Text = "Pay This";
    this.linkProportionalDue.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkProportionalDue_LinkClicked);
    this.linkTotalCommissions.AutoSize = true;
    this.linkTotalCommissions.BackColor = Color.FromArgb(247, 251, 253);
    this.linkTotalCommissions.LinkBehavior = LinkBehavior.HoverUnderline;
    this.linkTotalCommissions.Location = new Point(24, 56);
    this.linkTotalCommissions.Name = "linkTotalCommissions";
    this.linkTotalCommissions.Size = new Size(47, 13);
    this.linkTotalCommissions.TabIndex = 59;
    this.linkTotalCommissions.TabStop = true;
    this.linkTotalCommissions.Text = "Pay This";
    this.linkTotalCommissions.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkTotalCommissions_LinkClicked);
    ((AppearanceBase) appearance79).BackColor = Color.White;
    ((AppearanceBase) appearance79).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance79).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance79).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance79).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel12).Appearance = (AppearanceBase) appearance79;
    ((Control) this.ultraLabel12).AutoSize = true;
    ((Control) this.ultraLabel12).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel12).Location = new Point(16 /*0x10*/, 136);
    ((Control) this.ultraLabel12).Name = "ultraLabel12";
    ((Control) this.ultraLabel12).Size = new Size(103, 15);
    ((Control) this.ultraLabel12).TabIndex = 62;
    ((Control) this.ultraLabel12).Text = "ACCOUNT OFFSET";
    ((AppearanceBase) appearance80).BackColor = Color.White;
    ((AppearanceBase) appearance80).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance80).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance80).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance80).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance80;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(16 /*0x10*/, 16 /*0x10*/);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(132, 15);
    ((Control) this.ultraLabel8).TabIndex = 50;
    ((Control) this.ultraLabel8).Text = "COMMISSION DETAILS";
    ((AppearanceBase) appearance81).BackColor = Color.White;
    ((AppearanceBase) appearance81).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance81).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance81).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance81).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel6).Appearance = (AppearanceBase) appearance81;
    ((Control) this.ultraLabel6).Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(176 /*0xB0*/, 88);
    ((Control) this.ultraLabel6).TabIndex = 51;
    ((Control) this.ultraLabel6).Text = "First, select the expense offset account from the drop-down menu below. Then select the commissions you wish to remit payment on using the quick payament options provided.";
    ((AppearanceBase) appearance82).BackColor = Color.White;
    ((AppearanceBase) appearance82).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance82).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance82).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance82;
    ((Control) this.ultraLabel1).Dock = DockStyle.Left;
    ((Control) this.ultraLabel1).Location = new Point(0, 0);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(208 /*0xD0*/, 609);
    ((Control) this.ultraLabel1).TabIndex = 36;
    ((UltraControlBase) this.ultraLabel1).UseOsThemes = (DefaultableBoolean) 2;
    this.panelSummary.BackColor = Color.White;
    this.panelSummary.Controls.Add((Control) this.gridPaidInvoiceList);
    this.panelSummary.Controls.Add((Control) this.label5);
    this.panelSummary.Controls.Add((Control) this.label3);
    this.panelSummary.Controls.Add((Control) this.labelPayMethod);
    this.panelSummary.Controls.Add((Control) this.comboPaymentMethods);
    this.panelSummary.Controls.Add((Control) this.textComments);
    this.panelSummary.Controls.Add((Control) this.ultraLabel20);
    this.panelSummary.Controls.Add((Control) this.label1);
    this.panelSummary.Controls.Add((Control) this.ultraLabel19);
    this.panelSummary.Controls.Add((Control) this.ultraLabel17);
    this.panelSummary.Controls.Add((Control) this.pnlCash);
    this.panelSummary.Controls.Add((Control) this.lblCash);
    this.panelSummary.Controls.Add((Control) this.pnlExpenseOffset);
    this.panelSummary.Controls.Add((Control) this.lblExpenseOffset);
    this.panelSummary.Controls.Add((Control) this.lblInvoices);
    this.panelSummary.Controls.Add((Control) this.dateTransactionDate);
    this.panelSummary.Controls.Add((Control) this.ultraLabel16);
    this.panelSummary.Controls.Add((Control) this.ultraLabel18);
    this.panelSummary.Dock = DockStyle.Fill;
    this.panelSummary.Font = new Font("Tahoma", 8f);
    this.panelSummary.ForeColor = Color.Black;
    this.panelSummary.ImeMode = ImeMode.NoControl;
    this.panelSummary.Location = new Point(0, 80 /*0x50*/);
    this.panelSummary.Name = "panelSummary";
    this.panelSummary.Size = new Size(1008, 609);
    this.panelSummary.TabIndex = 64 /*0x40*/;
    ((Control) this.gridPaidInvoiceList).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridPaidInvoiceList).DataSource = (object) this.invoiceSummaryBindingSource;
    ((AppearanceBase) appearance83).BackColor = Color.White;
    ((AppearanceBase) appearance83).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Appearance = (AppearanceBase) appearance83;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 0;
    ultraGridColumn34.Width = 160 /*0xA0*/;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 1;
    ultraGridColumn35.Width = 160 /*0xA0*/;
    ((HeaderBase) ultraGridColumn36.Header).VisiblePosition = 2;
    ultraGridColumn36.Width = 160 /*0xA0*/;
    ((HeaderBase) ultraGridColumn37.Header).VisiblePosition = 3;
    ultraGridColumn37.Width = 130;
    ultraGridBand4.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37
    });
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance84).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance84).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance84).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance84;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance85).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance85;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance86).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance86;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance87).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance87;
    ((AppearanceBase) appearance88).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance88;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance89).BackColor = Color.Transparent;
    ((AppearanceBase) appearance89).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance89;
    ((AppearanceBase) appearance90).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance90).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance90;
    ((AppearanceBase) appearance91).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance91;
    ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((AppearanceBase) appearance92).BackColor = Color.White;
    ((AppearanceBase) appearance92).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout.Appearance = (AppearanceBase) appearance92;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance93).TextHAlignAsString = "Right";
    ultraGridColumn38.CellAppearance = (AppearanceBase) appearance93;
    ultraGridColumn38.Format = "c";
    ((AppearanceBase) appearance94).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn38.Header).Appearance = (AppearanceBase) appearance94;
    ((HeaderBase) ultraGridColumn38.Header).VisiblePosition = 3;
    ultraGridColumn38.Width = 132;
    ((AppearanceBase) appearance95).TextHAlignAsString = "Left";
    ultraGridColumn39.CellAppearance = (AppearanceBase) appearance95;
    ((AppearanceBase) appearance96).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn39.Header).Appearance = (AppearanceBase) appearance96;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn39.Header).VisiblePosition = 0;
    ultraGridColumn39.Width = 160 /*0xA0*/;
    ((AppearanceBase) appearance97).TextHAlignAsString = "Left";
    ultraGridColumn40.CellAppearance = (AppearanceBase) appearance97;
    ((AppearanceBase) appearance98).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn40.Header).Appearance = (AppearanceBase) appearance98;
    ((HeaderBase) ultraGridColumn40.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn40.Header).VisiblePosition = 1;
    ultraGridColumn40.Width = 159;
    ((AppearanceBase) appearance99).TextHAlignAsString = "Left";
    ultraGridColumn41.CellAppearance = (AppearanceBase) appearance99;
    ((AppearanceBase) appearance100).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn41.Header).Appearance = (AppearanceBase) appearance100;
    ((HeaderBase) ultraGridColumn41.Header).VisiblePosition = 2;
    ultraGridColumn41.Width = 159;
    ultraGridBand5.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41
    });
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand5);
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout).Key = "InvoicesLayout";
    ((AppearanceBase) appearance101).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance101).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance101).ForeColor = Color.Black;
    ultraGridLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance101;
    ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance102).BorderColor = Color.LightGray;
    ultraGridLayout.Override.CellAppearance = (AppearanceBase) appearance102;
    ultraGridLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance103).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout.Override.HeaderAppearance = (AppearanceBase) appearance103;
    ultraGridLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance104).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance104;
    ((AppearanceBase) appearance105).BorderColor = Color.LightGray;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance105;
    ultraGridLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance106).BackColor = Color.Transparent;
    ((AppearanceBase) appearance106).ForeColor = Color.Black;
    ultraGridLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance106;
    ((AppearanceBase) appearance107).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance107).BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance107;
    ((AppearanceBase) appearance108).BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance108;
    ultraGridLayout.ScrollBarLook = scrollBarLook4;
    ((UltraGridBase) this.gridPaidInvoiceList).Layouts.Add(ultraGridLayout);
    ((Control) this.gridPaidInvoiceList).Location = new Point(299, 104);
    ((Control) this.gridPaidInvoiceList).Name = "gridPaidInvoiceList";
    ((Control) this.gridPaidInvoiceList).Size = new Size(612, 114);
    ((Control) this.gridPaidInvoiceList).TabIndex = 66;
    ((UltraControlBase) this.gridPaidInvoiceList).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPaidInvoiceList).UseOsThemes = (DefaultableBoolean) 2;
    this.invoiceSummaryBindingSource.DataSource = (object) typeof (InvoiceSummary);
    this.label5.Location = new Point(296, 40);
    this.label5.Name = "label5";
    this.label5.Size = new Size(576, 48 /*0x30*/);
    this.label5.TabIndex = 65;
    this.label5.Text = componentResourceManager.GetString("label5.Text");
    this.label3.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.label3.Location = new Point(296, 24);
    this.label3.Name = "label3";
    this.label3.Size = new Size(100, 23);
    this.label3.TabIndex = 64 /*0x40*/;
    this.label3.Text = "Congratulations!";
    ((AppearanceBase) appearance109).BackColor = Color.White;
    ((AppearanceBase) appearance109).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance109).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance109).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance109).ForeColor = Color.Gray;
    ((ControlBase) this.labelPayMethod).Appearance = (AppearanceBase) appearance109;
    ((Control) this.labelPayMethod).AutoSize = true;
    ((Control) this.labelPayMethod).Location = new Point(8, 440);
    ((Control) this.labelPayMethod).Name = "labelPayMethod";
    ((Control) this.labelPayMethod).Size = new Size(65, 15);
    ((Control) this.labelPayMethod).TabIndex = 63 /*0x3F*/;
    ((Control) this.labelPayMethod).Text = "Pay Method:";
    this.comboPaymentMethods.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboPaymentMethods).DataMember = "PaymentMethods";
    ((UltraGridBase) this.comboPaymentMethods).DataSource = (object) this.dsPaymentMethods1;
    ((UltraDropDownBase) this.comboPaymentMethods).DisplayMember = "MethodName";
    this.comboPaymentMethods.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboPaymentMethods).Location = new Point(8, 456);
    this.comboPaymentMethods.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPaymentMethods).Name = "comboPaymentMethods";
    ((Control) this.comboPaymentMethods).Size = new Size(168, 21);
    ((Control) this.comboPaymentMethods).TabIndex = 61;
    ((UltraControlBase) this.comboPaymentMethods).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPaymentMethods).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboPaymentMethods).ValueMember = "PayMethodID";
    this.dsPaymentMethods1.DataSetName = "dsPaymentMethods";
    this.dsPaymentMethods1.Locale = new CultureInfo("en-US");
    ((AppearanceBase) appearance110).BackColor = Color.White;
    ((AppearanceBase) appearance110).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance110).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComments).Appearance = (AppearanceBase) appearance110;
    ((Control) this.textComments).BackColor = Color.White;
    ((Control) this.textComments).Location = new Point(8, 216);
    ((TextEditorControlBase) this.textComments).MaxLength = 2000;
    this.textComments.MGAStyle = MGAStyles.Blue;
    this.textComments.Multiline = true;
    ((Control) this.textComments).Name = "textComments";
    ((Control) this.textComments).Size = new Size(192 /*0xC0*/, 160 /*0xA0*/);
    ((Control) this.textComments).TabIndex = 57;
    ((UltraControlBase) this.textComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComments).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance111).BackColor = Color.White;
    ((AppearanceBase) appearance111).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance111).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance111).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance111).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel20).Appearance = (AppearanceBase) appearance111;
    ((Control) this.ultraLabel20).AutoSize = true;
    ((Control) this.ultraLabel20).Location = new Point(8, 200);
    ((Control) this.ultraLabel20).Name = "ultraLabel20";
    ((Control) this.ultraLabel20).Size = new Size(115, 15);
    ((Control) this.ultraLabel20).TabIndex = 56;
    ((Control) this.ultraLabel20).Text = "Transaction Comments";
    this.label1.BackColor = Color.SteelBlue;
    this.label1.Dock = DockStyle.Left;
    this.label1.Location = new Point(208 /*0xD0*/, 0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(1, 609);
    this.label1.TabIndex = 55;
    ((AppearanceBase) appearance112).BackColor = Color.White;
    ((AppearanceBase) appearance112).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance112).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance112).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance112).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel19).Appearance = (AppearanceBase) appearance112;
    ((Control) this.ultraLabel19).AutoSize = true;
    ((Control) this.ultraLabel19).Location = new Point(8, 392);
    ((Control) this.ultraLabel19).Name = "ultraLabel19";
    ((Control) this.ultraLabel19).Size = new Size(86, 15);
    ((Control) this.ultraLabel19).TabIndex = 54;
    ((Control) this.ultraLabel19).Text = "Transaction Date";
    ((AppearanceBase) appearance113).BackColor = Color.White;
    ((AppearanceBase) appearance113).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance113).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance113).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance113).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel17).Appearance = (AppearanceBase) appearance113;
    ((Control) this.ultraLabel17).Location = new Point(8, 32 /*0x20*/);
    ((Control) this.ultraLabel17).Name = "ultraLabel17";
    ((Control) this.ultraLabel17).Size = new Size(176 /*0xB0*/, 96 /*0x60*/);
    ((Control) this.ultraLabel17).TabIndex = 53;
    ((Control) this.ultraLabel17).Text = componentResourceManager.GetString("ultraLabel17.Text");
    this.pnlCash.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.pnlCash.AutoScroll = true;
    this.pnlCash.BackColor = Color.White;
    this.pnlCash.Font = new Font("Tahoma", 8f);
    this.pnlCash.ForeColor = Color.Black;
    this.pnlCash.Location = new Point(296, 368);
    this.pnlCash.Name = "pnlCash";
    this.pnlCash.Size = new Size(593, 184);
    this.pnlCash.TabIndex = 7;
    this.lblCash.AutoSize = true;
    this.lblCash.BackColor = Color.White;
    this.lblCash.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.lblCash.ForeColor = Color.Black;
    this.lblCash.Location = new Point(296, 352);
    this.lblCash.Name = "lblCash";
    this.lblCash.Size = new Size(113, 13);
    this.lblCash.TabIndex = 6;
    this.lblCash.Text = "Cash (Total Check)";
    this.lblCash.Visible = false;
    this.pnlExpenseOffset.BackColor = Color.White;
    this.pnlExpenseOffset.Controls.Add((Control) this.label6);
    this.pnlExpenseOffset.Font = new Font("Tahoma", 8f);
    this.pnlExpenseOffset.ForeColor = Color.Black;
    this.pnlExpenseOffset.Location = new Point(296, 248);
    this.pnlExpenseOffset.Name = "pnlExpenseOffset";
    this.pnlExpenseOffset.Size = new Size(552, 96 /*0x60*/);
    this.pnlExpenseOffset.TabIndex = 5;
    this.label6.Dock = DockStyle.Fill;
    this.label6.Location = new Point(0, 0);
    this.label6.Name = "label6";
    this.label6.Size = new Size(552, 96 /*0x60*/);
    this.label6.TabIndex = 0;
    this.label6.Text = "No expene offset entries found!";
    this.label6.TextAlign = ContentAlignment.MiddleCenter;
    this.lblExpenseOffset.AutoSize = true;
    this.lblExpenseOffset.BackColor = Color.White;
    this.lblExpenseOffset.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.lblExpenseOffset.ForeColor = Color.Black;
    this.lblExpenseOffset.Location = new Point(296, 232);
    this.lblExpenseOffset.Name = "lblExpenseOffset";
    this.lblExpenseOffset.Size = new Size(91, 13);
    this.lblExpenseOffset.TabIndex = 4;
    this.lblExpenseOffset.Text = "Expense Offset";
    this.lblInvoices.AutoSize = true;
    this.lblInvoices.BackColor = Color.White;
    this.lblInvoices.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.lblInvoices.ForeColor = Color.Black;
    this.lblInvoices.Location = new Point(296, 88);
    this.lblInvoices.Name = "lblInvoices";
    this.lblInvoices.Size = new Size(55, 13);
    this.lblInvoices.TabIndex = 2;
    this.lblInvoices.Text = "Invoices";
    this.lblInvoices.Visible = false;
    ((AppearanceBase) appearance114).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTransactionDate.Appearance = (AppearanceBase) appearance114;
    ((AppearanceBase) appearance115).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance115).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance115).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance115).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance115).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance115).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance115).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance115).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance115).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance115).ForegroundAlpha = (Alpha) 2;
    this.dateTransactionDate.ButtonAppearance = (AppearanceBase) appearance115;
    this.dateTransactionDate.FormatString = "d";
    ((Control) this.dateTransactionDate).Location = new Point(8, 408);
    this.dateTransactionDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTransactionDate).Name = "dateTransactionDate";
    ((Control) this.dateTransactionDate).Size = new Size(168, 20);
    ((Control) this.dateTransactionDate).TabIndex = 3;
    ((UltraControlBase) this.dateTransactionDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTransactionDate).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance116).BackColor = Color.White;
    ((AppearanceBase) appearance116).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance116).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance116).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance116).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel16).Appearance = (AppearanceBase) appearance116;
    ((Control) this.ultraLabel16).AutoSize = true;
    ((Control) this.ultraLabel16).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel16).Location = new Point(8, 16 /*0x10*/);
    ((Control) this.ultraLabel16).Name = "ultraLabel16";
    ((Control) this.ultraLabel16).Size = new Size(146, 15);
    ((Control) this.ultraLabel16).TabIndex = 52;
    ((Control) this.ultraLabel16).Text = "TRANSACTION SUMMARY";
    ((AppearanceBase) appearance117).BackColor = Color.White;
    ((AppearanceBase) appearance117).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance117).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance117).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.ultraLabel18).Appearance = (AppearanceBase) appearance117;
    ((Control) this.ultraLabel18).Dock = DockStyle.Left;
    ((Control) this.ultraLabel18).Location = new Point(0, 0);
    ((Control) this.ultraLabel18).Name = "ultraLabel18";
    ((Control) this.ultraLabel18).Size = new Size(208 /*0xD0*/, 609);
    ((Control) this.ultraLabel18).TabIndex = 8;
    this.panelExpenseOffset.Controls.Add((Control) this.gridExpenseOffset);
    this.panelExpenseOffset.Controls.Add((Control) this.panel3);
    this.panelExpenseOffset.Dock = DockStyle.Fill;
    this.panelExpenseOffset.Location = new Point(0, 80 /*0x50*/);
    this.panelExpenseOffset.Name = "panelExpenseOffset";
    this.panelExpenseOffset.Size = new Size(1008, 609);
    this.panelExpenseOffset.TabIndex = 2;
    this.panel3.BackColor = Color.FromArgb(239, 247, 253);
    this.panel3.Controls.Add((Control) this.ultraLabel14);
    this.panel3.Controls.Add((Control) this.ultraLabel15);
    this.panel3.Controls.Add((Control) this.groupAddExpenseOffset);
    this.panel3.Dock = DockStyle.Left;
    this.panel3.Location = new Point(0, 0);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(272, 609);
    this.panel3.TabIndex = 2;
    ((AppearanceBase) appearance118).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance118).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance118).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance118).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance118).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel14).Appearance = (AppearanceBase) appearance118;
    ((Control) this.ultraLabel14).AutoSize = true;
    ((Control) this.ultraLabel14).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel14).Location = new Point(16 /*0x10*/, 24);
    ((Control) this.ultraLabel14).Name = "ultraLabel14";
    ((Control) this.ultraLabel14).Size = new Size(99, 15);
    ((Control) this.ultraLabel14).TabIndex = 52;
    ((Control) this.ultraLabel14).Text = "EXPENSE OFFSET";
    ((AppearanceBase) appearance119).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance119).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance119).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance119).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance119).ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel15).Appearance = (AppearanceBase) appearance119;
    ((Control) this.ultraLabel15).Location = new Point(16 /*0x10*/, 40);
    ((Control) this.ultraLabel15).Name = "ultraLabel15";
    ((Control) this.ultraLabel15).Size = new Size(240 /*0xF0*/, 56);
    ((Control) this.ultraLabel15).TabIndex = 53;
    ((Control) this.ultraLabel15).Text = "Use this step to assign expenses against this payees account to reduce the amount of commissions to be paid.";
    this.panelTop.BackColor = Color.White;
    this.panelTop.Controls.Add((Control) this.label2);
    this.panelTop.Controls.Add((Control) this.labelHeader);
    this.panelTop.Controls.Add((Control) this.pictureBox1);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(1008, 80 /*0x50*/);
    this.panelTop.TabIndex = 35;
    this.label2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Dock = DockStyle.Bottom;
    this.label2.ForeColor = Color.Gray;
    this.label2.Location = new Point(0, 79);
    this.label2.Name = "label2";
    this.label2.Size = new Size(1008, 1);
    this.label2.TabIndex = 1;
    this.labelHeader.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.labelHeader.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.labelHeader.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.labelHeader.Location = new Point(253, 48 /*0x30*/);
    this.labelHeader.Name = "labelHeader";
    this.labelHeader.Size = new Size(748, 25);
    this.labelHeader.TabIndex = 0;
    this.labelHeader.Text = "Expensed Commissions";
    this.labelHeader.TextAlign = ContentAlignment.TopRight;
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(0, -8);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(96 /*0x60*/, 96 /*0x60*/);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.panel2.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panel2.Controls.Add((Control) this.btnBack);
    this.panel2.Controls.Add((Control) this.btnNext);
    this.panel2.Controls.Add((Control) this.buttonCreateCheck);
    this.panel2.Controls.Add((Control) this.buttonCancel);
    this.panel2.Controls.Add((Control) this.label4);
    this.panel2.Dock = DockStyle.Bottom;
    this.panel2.Location = new Point(0, 689);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(1008, 40);
    this.panel2.TabIndex = 40;
    ((Control) this.btnBack).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance120).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance120).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance120).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance120).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance120).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance120).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnBack).Appearance = (AppearanceBase) appearance120;
    ((Control) this.btnBack).Enabled = false;
    ((Control) this.btnBack).Location = new Point(536, 8);
    ((Control) this.btnBack).Name = "btnBack";
    ((Control) this.btnBack).Size = new Size(104, 24);
    ((Control) this.btnBack).TabIndex = 4;
    ((Control) this.btnBack).Text = "<< &Back";
    ((UltraControlBase) this.btnBack).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnBack).Click += new EventHandler(this.btnBack_Click);
    ((Control) this.btnNext).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance121).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance121).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance121).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance121).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance121).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance121).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance121;
    ((Control) this.btnNext).Location = new Point(648, 8);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(104, 24);
    ((Control) this.btnNext).TabIndex = 5;
    ((Control) this.btnNext).Text = "&Next >>";
    ((UltraControlBase) this.btnNext).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNext).Click += new EventHandler(this.btnNext_Click);
    ((Control) this.buttonCreateCheck).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance122).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance122).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance122).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance122).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance122).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance122).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCreateCheck).Appearance = (AppearanceBase) appearance122;
    ((Control) this.buttonCreateCheck).Enabled = false;
    ((Control) this.buttonCreateCheck).Location = new Point(785, 8);
    ((Control) this.buttonCreateCheck).Name = "buttonCreateCheck";
    ((Control) this.buttonCreateCheck).Size = new Size(104, 24);
    ((Control) this.buttonCreateCheck).TabIndex = 2;
    ((Control) this.buttonCreateCheck).Text = "Create Check";
    ((UltraControlBase) this.buttonCreateCheck).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCreateCheck).Click += new EventHandler(this.buttonCreateCheck_Click);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance123).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance123).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance123).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance123).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance123).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance123).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance123;
    ((Control) this.buttonCancel).Location = new Point(897, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(104, 24);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.label4.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label4.BorderStyle = BorderStyle.Fixed3D;
    this.label4.Dock = DockStyle.Top;
    this.label4.ForeColor = Color.Gray;
    this.label4.Location = new Point(0, 0);
    this.label4.Name = "label4";
    this.label4.Size = new Size(1008, 1);
    this.label4.TabIndex = 3;
    this.daInvoiceList.SelectCommand = this.sqlSelectCommand1;
    this.daInvoiceList.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_ExpenseCommissionDetails_InvoiceList", new DataColumnMapping[6]
      {
        new DataColumnMapping("invoiceNum", "invoiceNum"),
        new DataColumnMapping("officeInvoiceNum", "officeInvoiceNum"),
        new DataColumnMapping("InsuredName", "InsuredName"),
        new DataColumnMapping("PolicyNumber", "PolicyNumber"),
        new DataColumnMapping("Invoicedate", "Invoicedate"),
        new DataColumnMapping("Effectivedate", "Effectivedate")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_ExpenseCommissionDetails_InvoiceList]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@glcompanyid", SqlDbType.Int, 4),
      new SqlParameter("@entityGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@cutOff", SqlDbType.DateTime, 8)
    });
    this.daDetailList.SelectCommand = this.sqlSelectCommand2;
    this.daDetailList.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_ExpenseCommissionDetails_DetailList", new DataColumnMapping[7]
      {
        new DataColumnMapping("invoicenum", "invoicenum"),
        new DataColumnMapping("description", "description"),
        new DataColumnMapping("AgencyGross", "AgencyGross"),
        new DataColumnMapping("AgencyCommission", "AgencyCommission"),
        new DataColumnMapping("PayeePercentRate", "PayeePercentRate"),
        new DataColumnMapping("PayeeAMT", "PayeeAMT"),
        new DataColumnMapping("Balance", "Balance")
      })
    });
    this.sqlSelectCommand2.CommandText = "[spFin_ExpenseCommissionDetails_DetailList]";
    this.sqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand2.Parameters.AddRange(new SqlParameter[4]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@glcompanyid", SqlDbType.Int, 4),
      new SqlParameter("@entityGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      new SqlParameter("@cutOff", SqlDbType.DateTime, 8)
    });
    this.sqlConnection1.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
    this.daGetBankAccounts.SelectCommand = this.sqlSelectCommand3;
    this.daGetBankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccounts", new DataColumnMapping[3]
      {
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("BANKNAME", "BANKNAME"),
        new DataColumnMapping("CLOSED", "CLOSED")
      })
    });
    this.sqlSelectCommand3.CommandText = "[spFin_GetBankAccounts]";
    this.sqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand3.Connection = this.sqlConnection1;
    this.sqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4)
    });
    this.daGetCostCenters.SelectCommand = this.sqlCommand1;
    this.daGetCostCenters.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "spFin_GetCostCenters", new DataColumnMapping[4]
      {
        new DataColumnMapping("CostCenterId", "CostCenterId"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("glCompanyId", "glCompanyId")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[5]
      {
        new DataColumnMapping("CostCenterId", "CostCenterId"),
        new DataColumnMapping("entityGuid", "entityGuid"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Entity Type", "Entity Type"),
        new DataColumnMapping("isdefault", "isdefault")
      })
    });
    this.sqlCommand1.CommandText = "[spFin_GetCostCenters]";
    this.sqlCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlCommand1.Connection = this.sqlConnection1;
    this.sqlCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4)
    });
    this.dsExpenses1.DataSetName = "dsExpenses";
    this.dsExpenses1.Locale = new CultureInfo("en-US");
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (AccountingNoteDocumentSupport);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "gridContext";
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((AppearanceBase) appearance124).Image = componentResourceManager.GetObject("appearance69.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance124;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Pay Balance";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance125).Image = componentResourceManager.GetObject("appearance70.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance125;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Clear Pay Amount";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Left).Name = "_formExpensedCommissionsDetails_Toolbars_Dock_Area_Left";
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Left).Size = new Size(0, 729);
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Right).Location = new Point(1008, 0);
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Right).Name = "_formExpensedCommissionsDetails_Toolbars_Dock_Area_Right";
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Right).Size = new Size(0, 729);
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Top).Name = "_formExpensedCommissionsDetails_Toolbars_Dock_Area_Top";
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Top).Size = new Size(1008, 0);
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom).Location = new Point(0, 729);
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom).Name = "_formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom";
    ((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom).Size = new Size(1008, 0);
    this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(1008, 729);
    this.Controls.Add((Control) this.panelStep1);
    this.Controls.Add((Control) this.panelExpenseOffset);
    this.Controls.Add((Control) this.panelSummary);
    this.Controls.Add((Control) this.panelTop);
    this.Controls.Add((Control) this.panel2);
    this.Controls.Add((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formExpensedCommissionsDetails_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MinimumSize = new Size(975, 560);
    this.Name = nameof (formExpensedCommissionsDetails);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Expensed Commissions Details";
    this.Load += new EventHandler(this.formExpensedCommissionsDetails_Load);
    ((ISupportInitialize) this.gridExpenseOffset).EndInit();
    ((ISupportInitialize) this.dsExpenseOffset).EndInit();
    ((ISupportInitialize) this.groupAddExpenseOffset).EndInit();
    ((Control) this.groupAddExpenseOffset).ResumeLayout(false);
    ((Control) this.groupAddExpenseOffset).PerformLayout();
    ((ISupportInitialize) this.comboCostCenter).EndInit();
    ((ISupportInitialize) this.comboExpenses).EndInit();
    ((ISupportInitialize) this.buttonAddExpense).EndInit();
    ((ISupportInitialize) this.buttonCancelAddExpense).EndInit();
    ((ISupportInitialize) this.textAmount).EndInit();
    ((ISupportInitialize) this.dsSummaryData).EndInit();
    this.panelStep1.ResumeLayout(false);
    this.panelStep1.PerformLayout();
    ((ISupportInitialize) this.gridCommissionDetails).EndInit();
    this.dsExpenseCommissionDetails1.EndInit();
    ((ISupportInitialize) this.comboBankAccount).EndInit();
    this.dsBankAccounts1.EndInit();
    ((ISupportInitialize) this.groupQuickPayment).EndInit();
    ((Control) this.groupQuickPayment).ResumeLayout(false);
    ((Control) this.groupQuickPayment).PerformLayout();
    this.panelSummary.ResumeLayout(false);
    this.panelSummary.PerformLayout();
    ((ISupportInitialize) this.gridPaidInvoiceList).EndInit();
    ((ISupportInitialize) this.invoiceSummaryBindingSource).EndInit();
    ((ISupportInitialize) this.comboPaymentMethods).EndInit();
    this.dsPaymentMethods1.EndInit();
    ((ISupportInitialize) this.textComments).EndInit();
    this.pnlExpenseOffset.ResumeLayout(false);
    ((ISupportInitialize) this.dateTransactionDate).EndInit();
    this.panelExpenseOffset.ResumeLayout(false);
    this.panel3.ResumeLayout(false);
    this.panel3.PerformLayout();
    this.panelTop.ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.panel2.ResumeLayout(false);
    ((ISupportInitialize) this.btnBack).EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.buttonCreateCheck).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.dsExpenses1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  private void LoadInvoiceList()
  {
    using (SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      this.daInvoiceList.SelectCommand.CommandTimeout = 0;
      this.daInvoiceList.SelectCommand.Connection = sqlConnection;
      this.daInvoiceList.SelectCommand.Parameters["@glCompanyid"].Value = (object) this._glCompanyId;
      this.daInvoiceList.SelectCommand.Parameters["@entityGuid"].Value = (object) this._payeeGuid;
      this.daInvoiceList.Fill((DataTable) this.dsExpenseCommissionDetails1.InvoiceList);
      this.daDetailList.SelectCommand.CommandTimeout = 0;
      this.daDetailList.SelectCommand.Connection = sqlConnection;
      this.daDetailList.SelectCommand.Parameters["@glCompanyid"].Value = (object) this._glCompanyId;
      this.daDetailList.SelectCommand.Parameters["@entityGuid"].Value = (object) this._payeeGuid;
      this.daDetailList.Fill((DataTable) this.dsExpenseCommissionDetails1.InvoiceDetailList);
    }
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void AddSummaryRow(
    int glAcctID,
    string glAcctName,
    string itemDescription,
    Decimal itemAmount,
    int expenseCode,
    int costCenterId,
    string costCenterName)
  {
    this.dsExpenseOffset.Rows.Add(false, new object[7]
    {
      (object) glAcctID,
      (object) glAcctName,
      (object) itemDescription,
      (object) itemAmount,
      (object) expenseCode,
      (object) costCenterId,
      (object) costCenterName
    }, true);
    this.BuildGridSummary();
  }

  private void BuildGridSummary()
  {
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Bands[0].Summaries.Clear();
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Bands[0].Summaries.Add("TotalSum", (SummaryType) 1, ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Bands[0].Columns["Amount"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Bands[0].Summaries["TotalSum"].DisplayFormat = "{0:c}";
    ((UltraGridBase) this.gridExpenseOffset).DisplayLayout.Bands[0].Summaries["TotalSum"].Appearance.TextHAlign = (HAlign) 3;
  }

  private void LoadExpenses()
  {
    DataSet dataSet = new DataSet();
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("spFin_GetExpenses", connection))
      {
        selectCommand.CommandType = CommandType.StoredProcedure;
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
        {
          sqlDataAdapter.Fill(dataSet);
          ((UltraGridBase) this.comboExpenses).DataSource = (object) dataSet;
          ((UltraDropDownBase) this.comboExpenses).DisplayMember = "ExpenseName";
          ((UltraDropDownBase) this.comboExpenses).ValueMember = "ExpenseCode";
        }
      }
    }
  }

  private void AddExpenseItem(
    int expenseGLAccountID,
    Decimal expenseAmount,
    string expenseName,
    int expenseCode,
    int costCenterId)
  {
    if (((UltraDropDownBase) this.comboBankAccount).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a Bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      GLAccount glAccount1 = new GLAccount(expenseGLAccountID);
      GLAccount glAccount2 = new GLAccount(int.Parse(this.comboBankAccount.Value.ToString()));
      CostCenterAllocationCollection allocations = new CostCenterAllocationCollection();
      this.expenseTotal += expenseAmount;
      this.transactionTotal -= expenseAmount;
      if (this.temp_tran == null)
        this.temp_tran = new OperatingTransaction(CurrentUser.Instance.UserGUID, true);
      GLAccount glAccount3;
      GLAccount glAccount4;
      if (expenseAmount > 0M)
      {
        glAccount3 = glAccount1;
        glAccount4 = glAccount2;
      }
      else
      {
        glAccount4 = glAccount1;
        glAccount3 = glAccount2;
      }
      allocations.Add(new CostCenterAllocation(costCenterId, expenseAmount), expenseAmount);
      this.temp_tran.Debits.Add(new TransactionDetail(0, 0, 0, expenseCode, 0, 0, glAccount4, Guid.Empty, this._payeeGuid, expenseAmount, this._payeeGuid, allocations));
      this.temp_tran.Credits.Add(new TransactionDetail(0, 0, 0, expenseCode, 0, 0, glAccount3, Guid.Empty, this._payeeGuid, expenseAmount, this._payeeGuid, allocations));
      this.AddExpenseOffsetSummaryLabel(glAccount1.AccountFullName, expenseName, expenseAmount);
    }
  }

  private void textAmount_Validating(object sender, CancelEventArgs e)
  {
    if (((Control) this.textAmount).Text == string.Empty)
      return;
    if (MGASystems.IMS.Accounting.OperatingExpenses.Utilities.IsDecimal(((Control) this.textAmount).Text))
      ((Control) this.textAmount).Text = Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Currency).ToString("c");
    else
      e.Cancel = true;
  }

  private void buttonAddExpense_Click(object sender, EventArgs e)
  {
    if (!this.ValidateExpenseOffset())
      return;
    this.AddSummaryRow(this.dropTreeGLAccounts.GLAccountID, this.dropTreeGLAccounts.GLAccountShortName, string.Empty, Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Currency), -1, int.Parse(this.comboCostCenter.Value.ToString()), ((Control) this.comboCostCenter).Text);
    this.ClearExpenseEntryControls();
  }

  private bool ValidateExpenseOffset()
  {
    if (this.dropTreeGLAccounts.GLAccountID <= 0)
    {
      int num = (int) MessageBox.Show("You must select an expense GL account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textAmount).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You must specify and expense offset amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!MGASystems.IMS.Accounting.OperatingExpenses.Utilities.IsDecimal(((Control) this.textAmount).Text))
    {
      int num = (int) MessageBox.Show("Offset amount must be numeric to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.comboCostCenter.SelectedIndex != -1 && ((UltraDropDownBase) this.comboCostCenter).SelectedRow != null)
      return true;
    int num1 = (int) MessageBox.Show("You must select a cost center to continue.", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    return false;
  }

  private void ClearExpenseEntryControls()
  {
    ((Control) this.comboExpenses).ResetText();
    this.dropTreeGLAccounts.ResetText();
    ((Control) this.textAmount).Text = string.Empty;
    this.comboCostCenter.SelectedIndex = -1;
  }

  private void buttonCancelAddExpense_Click(object sender, EventArgs e)
  {
    this.ClearExpenseEntryControls();
  }

  private void linkTotalCommissions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    this._transactionUpdateRequired = true;
    this.PopulateGrid(formExpensedCommissionsDetails.PaymentType.PayTotalCommission);
    this.Cursor = Cursors.Default;
  }

  private void linkProportionalDue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    this._transactionUpdateRequired = true;
    this.PopulateGrid(formExpensedCommissionsDetails.PaymentType.PayProportional);
    this.Cursor = Cursors.Default;
  }

  private void linkARFull_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    this._transactionUpdateRequired = true;
    this.PopulateGrid(formExpensedCommissionsDetails.PaymentType.PayFullyReceived);
    this.Cursor = Cursors.Default;
  }

  private bool OverwriteExistingTransactions()
  {
    if (this._tran == null || this._tran.Debits == null || this._tran.Debits.Count == 0)
      return true;
    if (MessageBox.Show("The system has determined that you have already selected invoices to be paid, do you wish to overwrite these previous selections?", "Overwrite Previous Selections?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
      return false;
    this.pnlCash.Controls.Clear();
    this.pnlExpenseOffset.Controls.Clear();
    this._invoiceList.Clear();
    this._tran.Debits.Clear();
    this._tran.Credits.Clear();
    this.lblCash.Visible = this.lblExpenseOffset.Visible = this.lblInvoices.Visible = false;
    return true;
  }

  private bool IsValidGLOffsetAndBankInfo()
  {
    string text = (string) null;
    if (this.dropTreeAccountOffset.GLAccountID == -1)
      text = "You must select a GL offset account to continue.";
    else if (this.comboBankAccount.SelectedIndex == -1 || this.comboBankAccount.SelectedIndex == 0)
      text = "You must select a bank account to continue.";
    if (text == null)
      return true;
    int num = (int) MessageBox.Show(text, "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void PopulateGrid(formExpensedCommissionsDetails.PaymentType payType)
  {
    Decimal result = 0M;
    switch (payType)
    {
      case formExpensedCommissionsDetails.PaymentType.PayFullyReceived:
        ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Bands[0].ColumnFilters["PercentRCVD"].FilterConditions.Add((FilterComparisionOperator) 0, (object) 1.0M);
        UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridCommissionDetails).Rows.GetFilteredInNonGroupByRows();
        for (int index1 = 0; index1 < inNonGroupByRows.Length; ++index1)
        {
          inNonGroupByRows[index1].ExpandAll();
          for (int index2 = 0; index2 < ((DisposableObjectCollectionBase) inNonGroupByRows[index1].ChildBands[0].Rows).Count; ++index2)
          {
            UltraGridRow row = inNonGroupByRows[index1].ChildBands[0].Rows[index2];
            if (Decimal.TryParse(row.Cells["Balance"].Value.ToString(), NumberStyles.Any, (IFormatProvider) null, out result) && result != 0M)
              row.Cells["PayAmount"].Value = (object) result;
          }
        }
        ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
        break;
      case formExpensedCommissionsDetails.PaymentType.PayProportional:
        RowEnumerator enumerator1 = ((UltraGridBase) this.gridCommissionDetails).Rows.GetEnumerator();
        try
        {
          while (enumerator1.MoveNext())
          {
            foreach (UltraGridRow row in enumerator1.Current.ChildBands[0].Rows)
            {
              if (Decimal.TryParse(row.Cells["PropAmtDue"].Value.ToString(), NumberStyles.Any, (IFormatProvider) null, out result) && result != 0M)
              {
                row.Cells["PayAmount"].Value = (object) result;
                row.ParentRow.ExpandAll();
              }
            }
          }
          break;
        }
        finally
        {
          if (enumerator1 is IDisposable disposable)
            disposable.Dispose();
        }
      case formExpensedCommissionsDetails.PaymentType.PayTotalCommission:
        RowEnumerator enumerator2 = ((UltraGridBase) this.gridCommissionDetails).Rows.GetEnumerator();
        try
        {
          while (enumerator2.MoveNext())
          {
            UltraGridRow current = enumerator2.Current;
            foreach (UltraGridRow row in current.ChildBands[0].Rows)
            {
              if (Decimal.TryParse(row.Cells["Balance"].Value.ToString(), NumberStyles.Any, (IFormatProvider) null, out result) && result != 0M)
              {
                row.Cells["PayAmount"].Value = (object) result;
                current.ExpandAll();
              }
            }
          }
          break;
        }
        finally
        {
          if (enumerator2 is IDisposable disposable)
            disposable.Dispose();
        }
    }
  }

  private void PopulateTransactionObjects()
  {
    ((UltraGridBase) this.gridPaidInvoiceList).DataSource = (object) this._invoiceList;
    this.transactionTotal = 0M;
    Decimal num1 = 0M;
    GLAccount glAccount1 = new GLAccount(this.dropTreeAccountOffset.GLAccountID);
    GLAccount glAccount2 = new GLAccount(int.Parse(this.comboBankAccount.Value.ToString()));
    if (this._tran == null)
    {
      this._tran = new OperatingTransaction(CurrentUser.Instance.UserGUID, true);
    }
    else
    {
      this._tran.Debits.Clear();
      this._tran.Credits.Clear();
      this._invoiceList.Clear();
    }
    for (int index1 = 0; index1 < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridCommissionDetails).Rows).Count; ++index1)
    {
      UltraGridRow row1 = ((UltraGridBase) this.gridCommissionDetails).Rows[index1];
      int CostCenterId = int.Parse(row1.Cells["CostCenterId"].Value.ToString());
      for (int index2 = 0; index2 < ((DisposableObjectCollectionBase) row1.ChildBands[0].Rows).Count; ++index2)
      {
        UltraGridRow row2 = row1.ChildBands[0].Rows[index2];
        if (row2.Cells["PayAmount"].Value != null && row2.Cells["PayAmount"].Value != DBNull.Value)
        {
          Decimal num2 = Decimal.Parse(row2.Cells["PayAmount"].Value.ToString(), NumberStyles.Currency);
          if (!(num2 == 0M))
          {
            CostCenterAllocationCollection allocations = new CostCenterAllocationCollection();
            allocations.Add(new CostCenterAllocation(CostCenterId, num2), num2);
            TransactionDetail transactionDetail1 = new TransactionDetail(int.Parse(row2.Cells["invoicenum"].Value.ToString()), int.Parse(row2.Cells["chargeCode"].Value.ToString()), 0, 0, 0, 0, glAccount1, new Guid(row2.Cells["companyLineGuid"].Value.ToString()), this._payeeGuid, num2, this._payeeGuid, allocations);
            TransactionDetail transactionDetail2 = new TransactionDetail(int.Parse(row2.Cells["invoicenum"].Value.ToString()), int.Parse(row2.Cells["chargeCode"].Value.ToString()), 0, 0, 0, 0, glAccount2, new Guid(row2.Cells["companyLineGuid"].Value.ToString()), this._payeeGuid, num2, this._payeeGuid, allocations);
            num1 += num2;
            if (num2 > 0M)
            {
              this._tran.Credits.Add(transactionDetail2);
              this._tran.Debits.Add(transactionDetail1);
            }
            else
            {
              this._tran.Debits.Add(transactionDetail2);
              this._tran.Credits.Add(transactionDetail1);
            }
            if (num2 != 0M)
              this.AddInvoiceSummaryLabel(row1.Cells["OfficeInvoiceNum"].Value.ToString(), row1.Cells["PolicyNumber"].Value.ToString(), row2.Cells["description"].Value.ToString(), num2);
          }
        }
      }
    }
    this.transactionTotal += num1;
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Bands[1].Summaries.Clear();
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Bands[1].Summaries.Add("tets", (SummaryType) 1, ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Bands[1].Columns["propamtdue"]);
    this.transactionTotal += this.expenseTotal * -1M;
  }

  private void AddInvoiceSummaryLabel(
    string invoiceNum,
    string policyNum,
    string description,
    Decimal amount)
  {
    this._invoiceList.Add((object) new InvoiceSummary(invoiceNum, policyNum, description, amount));
  }

  private void AddExpenseOffsetSummaryLabel(
    string AccountName,
    string itemDescription,
    Decimal itemAmount)
  {
    this.label6.Visible = false;
    this.pnlExpenseOffset.Controls.Add((Control) new ExpenseCommissionsInvoiceSummaryEntry(AccountName, itemDescription, itemAmount));
  }

  private void AddCashSummaryLabels()
  {
    if (this._tran == null && this.temp_tran == null)
      return;
    this.pnlCash.Controls.Clear();
    Label label = new Label();
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 8f);
    this.transactionTotal = this.CalculateTransactionTotal();
    label.Text = $"{((Control) this.comboBankAccount).Text}{Microsoft.VisualBasic.Strings.Space(15)}Account # {this.comboBankAccount.Value?.ToString()}{Microsoft.VisualBasic.Strings.Space(15)}{this.transactionTotal.ToString("c")}";
    this.pnlCash.Controls.Add((Control) label);
  }

  private Decimal CalculateTransactionTotal()
  {
    Decimal num1 = 0M;
    Decimal num2 = 0M;
    for (int index1 = 0; index1 < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridCommissionDetails).Rows).Count; ++index1)
    {
      UltraGridRow row1 = ((UltraGridBase) this.gridCommissionDetails).Rows[index1];
      for (int index2 = 0; index2 < ((DisposableObjectCollectionBase) row1.ChildBands[0].Rows).Count; ++index2)
      {
        UltraGridRow row2 = row1.ChildBands[0].Rows[index2];
        if (row2.Cells["PayAmount"].Value != null && !row2.Cells["PayAmount"].Value.Equals((object) DBNull.Value))
          num1 += Decimal.Parse(row2.Cells["PayAmount"].Value.ToString());
      }
    }
    for (int index = 0; index < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridExpenseOffset).Rows).Count; ++index)
    {
      UltraGridRow row = ((UltraGridBase) this.gridExpenseOffset).Rows[index];
      if (row.Cells["Amount"].Value != null && !row.Cells["Amount"].Value.Equals((object) DBNull.Value))
        num2 += Decimal.Parse(row.Cells["Amount"].Value.ToString());
    }
    return num1 + num2 * -1M;
  }

  private void PopulateCheckInfo()
  {
    ((UltraGridBase) this.comboPaymentMethods).DataSource = (object) Utility.GetEntityPaymentMethods(this._payeeGuid, this._glCompanyId, AccountingCache.Instance.GlCompany(this._glCompanyId).PrimaryBankAccount.GLAccountID);
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboPaymentMethods).Rows).Count != 1)
      return;
    this.comboPaymentMethods.Value = ((UltraGridBase) this.comboPaymentMethods).Rows[0].Cells["PayMethodID"].Value;
  }

  private void btnNext_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    if (this._currentWizardStep == formExpensedCommissionsDetails.WizardStep.Step1 && this.IsValidGLOffsetAndBankInfo())
    {
      if (this._transactionUpdateRequired)
      {
        this.PopulateTransactionObjects();
        ((UltraGridBase) this.gridPaidInvoiceList).DataSource = (object) this._invoiceList;
        ((UltraGridBase) this.gridPaidInvoiceList).DataBind();
        ((UltraGridBase) this.gridPaidInvoiceList).DisplayLayout.Load(((UltraGridBase) this.gridPaidInvoiceList).Layouts["InvoicesLayout"], (PropertyCategories) -1);
      }
      this.WizardNextStep();
      this._transactionUpdateRequired = false;
    }
    else if (this._currentWizardStep == formExpensedCommissionsDetails.WizardStep.ExpenseOffset)
      this.WizardNextStep();
    this.Cursor = Cursors.Default;
  }

  private void WizardNextStep()
  {
    if (this._currentWizardStep == formExpensedCommissionsDetails.WizardStep.ExpenseOffset)
    {
      ((Control) this.buttonCreateCheck).Enabled = true;
      ((Control) this.btnBack).Enabled = true;
      ((Control) this.btnNext).Enabled = false;
      this._currentWizardStep = formExpensedCommissionsDetails.WizardStep.Summary;
      ((Control) this.buttonCreateCheck).Enabled = true;
      this.RebuildExpenseOffsetTransaction();
      this.panelSummary.BringToFront();
      if (!this._hasPopulatedCheckInfo)
      {
        this.PopulateCheckInfo();
        this._hasPopulatedCheckInfo = true;
      }
      this.pnlCash.Controls.Clear();
      ((Control) this.buttonCreateCheck).Enabled = this._tran != null;
      this.AddCashSummaryLabels();
    }
    else
    {
      if (this._currentWizardStep != formExpensedCommissionsDetails.WizardStep.Step1)
        return;
      this.panelExpenseOffset.BringToFront();
      ((Control) this.btnBack).Enabled = true;
      ((Control) this.btnNext).Enabled = true;
      this._currentWizardStep = formExpensedCommissionsDetails.WizardStep.ExpenseOffset;
    }
  }

  private void WizardPreviousStep()
  {
    if (this._currentWizardStep == formExpensedCommissionsDetails.WizardStep.ExpenseOffset)
    {
      ((Control) this.btnNext).Enabled = true;
      ((Control) this.btnBack).Enabled = false;
      this.panelStep1.BringToFront();
      this._currentWizardStep = formExpensedCommissionsDetails.WizardStep.Step1;
    }
    else
    {
      if (this._currentWizardStep != formExpensedCommissionsDetails.WizardStep.Summary)
        return;
      ((Control) this.buttonCreateCheck).Enabled = false;
      ((Control) this.btnNext).Enabled = true;
      ((Control) this.btnBack).Enabled = true;
      this.panelExpenseOffset.BringToFront();
      this._currentWizardStep = formExpensedCommissionsDetails.WizardStep.ExpenseOffset;
    }
  }

  private void btnBack_Click(object sender, EventArgs e) => this.WizardPreviousStep();

  private void LoadBankAccounts(int glCompanyId)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.dsBankAccounts1.Clear();
      this.daGetBankAccounts.SelectCommand.Connection.ConnectionString = CurrentUser.Instance.ConnectionString;
      this.daGetBankAccounts.SelectCommand.Parameters["@glCompanyId"].Value = (object) glCompanyId;
      this.daGetBankAccounts.Fill((DataTable) this.dsBankAccounts1.spFin_GetBankAccounts);
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboBankAccount).Rows).Count != 1)
        return;
      this.comboBankAccount.Value = (object) ((UltraGridBase) this.comboBankAccount).Rows[0].Cells[((UltraDropDownBase) this.comboBankAccount).ValueMember];
    }
    catch (SqlException ex)
    {
      int num = (int) MessageBox.Show("An error has occured while trying to get the bank accounts for the specified office location." + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void buttonCreateCheck_Click(object sender, EventArgs e)
  {
    if (this._tran == null || this._tran.Credits == null)
      return;
    if (this.transactionTotal < 0M && this.comboPaymentMethods.Value.ToString().ToUpper() != "O")
    {
      int num1 = (int) MessageBox.Show("Total check amount can not be negative.", "Invalid Check Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (((UltraDropDownBase) this.comboPaymentMethods).SelectedRow == null)
    {
      int num2 = (int) MessageBox.Show("You must select a payment type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (this.transactionTotal == 0M && this.comboPaymentMethods.Value.ToString().ToUpper() != "O")
      {
        if (MessageBox.Show("The current check amount is zero. The system can not use the payment method selected. Would you like the system to set the payment method to 'Offset' ", "Invalid Pay Method", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
          return;
        this.comboPaymentMethods.SelectedIndex = 1;
      }
      if (this.comboPaymentMethods.Value.ToString().ToUpper() != "O")
      {
        CheckInformation checkInformation;
        if ((checkInformation = this.GetCheckInformation()) != null)
        {
          this._tran.CreateCheck = true;
          this._tran.CheckData = checkInformation;
        }
        else
        {
          int num3 = (int) MessageBox.Show("You must specify a payee address to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
      this._tran.PostDate = this.dateTransactionDate.DateTime;
      this._tran.TransactionComments = ((Control) this.textComments).Text;
      for (int index = 0; this.temp_tran != null && index < this.temp_tran.Credits.Count; ++index)
      {
        this._tran.Credits.Add(this.temp_tran.Credits[index]);
        this._tran.Debits.Add(this.temp_tran.Debits[index]);
      }
      this.temp_tran = (OperatingTransaction) null;
      if (!this._tran.IsBalanced())
      {
        int num4 = (int) MessageBox.Show("The current transaction is not in balance, please verify the transaction to continue.", "Transaction Does Not Balance!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else if (this._tran.Debits.Count == 0 || this._tran.Credits.Count == 0)
      {
        int num5 = (int) MessageBox.Show("The current transaction does not have any debits or credits defined.", "Transaction Is Empty!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        this._tran.Save();
        this.RefreshExpensedCommissionForm();
      }
    }
  }

  private CheckInformation GetCheckInformation()
  {
    using (formPayeeAddressSelection addressSelection = new formPayeeAddressSelection(this._payeeGuid))
    {
      if (addressSelection.ShowDialog() == DialogResult.OK)
      {
        Utility.PaymentMethod paymentMethod;
        switch (this.comboPaymentMethods.Value.ToString().ToUpper())
        {
          case "A":
            paymentMethod = Utility.PaymentMethod.AutoEFT;
            break;
          case "C":
            paymentMethod = Utility.PaymentMethod.Check;
            break;
          case "D":
            paymentMethod = Utility.PaymentMethod.Check;
            break;
          case "M":
            paymentMethod = Utility.PaymentMethod.ManualTransfer;
            break;
          default:
            paymentMethod = Utility.PaymentMethod.Check;
            break;
        }
        GLAccount bankGlAccount = new GLAccount(int.Parse(this.comboBankAccount.Value.ToString()));
        return new CheckInformation(paymentMethod, this._payeeGuid, this.dateTransactionDate.DateTime, bankGlAccount, addressSelection.PayeeName, addressSelection.Address1, addressSelection.Address2, addressSelection.City, addressSelection.State, addressSelection.ZipCode, addressSelection.ZipPlus, addressSelection.PayeeName, addressSelection.CheckMemo);
      }
    }
    return (CheckInformation) null;
  }

  private void RefreshExpensedCommissionForm()
  {
    foreach (Form mdiChild in this.MdiParent.MdiChildren)
    {
      if (mdiChild.Name == "formExpensedCommissions")
        ((formExpensedCommissions) mdiChild).RefreshForm();
    }
    this.Close();
  }

  private void gridExpenseOffset_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    e.DisplayPromptMsg = false;
  }

  private void RebuildExpenseOffsetTransaction()
  {
    if (this.temp_tran != null)
    {
      this.temp_tran.Debits.Clear();
      this.temp_tran.Credits.Clear();
    }
    for (int index = this.pnlExpenseOffset.Controls.Count - 1; index >= 0; --index)
    {
      if (this.pnlExpenseOffset.Controls[index] != this.label6)
        this.pnlExpenseOffset.Controls.RemoveAt(index);
    }
    this.label6.Visible = true;
    for (int index = 0; index < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridExpenseOffset).Rows).Count; ++index)
    {
      UltraGridRow row = ((UltraGridBase) this.gridExpenseOffset).Rows[index];
      this.AddExpenseItem(int.Parse(row.Cells["glaccountid"].Value.ToString()), Decimal.Parse(row.Cells["amount"].Value.ToString()), row.Cells["expense"].Value.ToString(), int.Parse(row.Cells["expenseCode"].Value.ToString()), int.Parse(row.Cells["CostCenterId"].Value.ToString()));
    }
  }

  private void gridCommissionDetails_KeyUp(object sender, KeyEventArgs e)
  {
    if (((UltraGridBase) this.gridCommissionDetails).ActiveRow == null || this.gridCommissionDetails.ActiveCell == null || ((KeyedSubObjectBase) this.gridCommissionDetails.ActiveCell.Column).Key.ToLower() != "payamount" || e.KeyCode != Keys.Return && e.KeyCode != Keys.Tab)
      return;
    ((UltraGridBase) this.gridCommissionDetails).ActiveRow.Update();
  }

  private void gridCommissionDetails_AfterCellUpdate(object sender, CellEventArgs e)
  {
    this._transactionUpdateRequired = true;
    if (((KeyedSubObjectBase) e.Cell.Column).Key != "PayAmount" || e.Cell.Value == null || e.Cell.Value.Equals((object) DBNull.Value))
      return;
    Decimal num1 = Decimal.Parse(e.Cell.Row.Cells["PayAmount"].Value.ToString());
    Decimal num2 = Decimal.Parse(e.Cell.Row.Cells["Balance"].Value.ToString());
    if (num1 == 0M)
      return;
    if (!Math.Sign(num1).Equals(Math.Sign(num2)))
    {
      int num3 = (int) MessageBox.Show("You can only apply credits to credit items and debits to debit items.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cell.Value = (object) DBNull.Value;
    }
    else
    {
      if (!(Math.Abs(num1) > Math.Abs(num2)))
        return;
      int num4 = (int) MessageBox.Show("Amount to pay can not be exceed the balance due.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cell.Value = (object) DBNull.Value;
    }
  }

  private void gridCommissionDetails_KeyDown(object sender, KeyEventArgs e)
  {
    if (((UltraGridBase) this.gridCommissionDetails).ActiveRow == null || this.gridCommissionDetails.ActiveCell == null || ((KeyedSubObjectBase) this.gridCommissionDetails.ActiveCell.Column).Key.ToLower() != "payamount")
      return;
    if (e.KeyValue == 46 && ((KeyedSubObjectBase) this.gridCommissionDetails.ActiveCell.Column).Key.ToLower() == "payamount")
      this.gridCommissionDetails.ActiveCell.Value = (object) DBNull.Value;
    if (e.KeyValue == 38)
    {
      this.validateGridForDollarSign();
      this.gridCommissionDetails.PerformAction((UltraGridAction) 44, false, false);
      this.gridCommissionDetails.PerformAction((UltraGridAction) 19, false, false);
      e.Handled = true;
      this.gridCommissionDetails.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 40)
    {
      this.validateGridForDollarSign();
      this.gridCommissionDetails.PerformAction((UltraGridAction) 44, false, false);
      this.gridCommissionDetails.PerformAction((UltraGridAction) 20, false, false);
      e.Handled = true;
      this.gridCommissionDetails.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 39)
    {
      this.validateGridForDollarSign();
      this.gridCommissionDetails.PerformAction((UltraGridAction) 44, false, false);
      this.gridCommissionDetails.PerformAction((UltraGridAction) 42, false, false);
      e.Handled = true;
      this.gridCommissionDetails.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 37)
    {
      this.validateGridForDollarSign();
      this.gridCommissionDetails.PerformAction((UltraGridAction) 44, false, false);
      this.gridCommissionDetails.PerformAction((UltraGridAction) 43, false, false);
      e.Handled = true;
      this.gridCommissionDetails.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 13)
    {
      this.validateGridForDollarSign();
      ((UltraGridBase) this.gridCommissionDetails).ActiveRow.Update();
    }
    if (e.KeyValue != 9)
      return;
    this.validateGridForDollarSign();
    ((UltraGridBase) this.gridCommissionDetails).ActiveRow.Update();
    this.gridCommissionDetails.ActiveCell = ((UltraGridBase) this.gridCommissionDetails).ActiveRow.Cells["PayAmount"];
    this.gridCommissionDetails.ActiveCell.Activate();
    e.Handled = true;
    this.gridCommissionDetails.PerformAction((UltraGridAction) 24);
  }

  private void validateGridForDollarSign()
  {
    if (this.gridCommissionDetails.ActiveCell == null || !Utility.IsDecimalValue((object) this.gridCommissionDetails.ActiveCell.Text))
      return;
    this.gridCommissionDetails.ActiveCell.Value = (object) Decimal.Parse(this.gridCommissionDetails.ActiveCell.Text, NumberStyles.Any);
    this.gridCommissionDetails.ActiveCell.Row.Update();
  }

  private void LoadCostCenters()
  {
    DataSet dataSet = new DataSet();
    ((UltraGridBase) this.comboCostCenter).DataSource = (object) null;
    ((UltraGridBase) this.comboCostCenter).DataMember = string.Empty;
    ((UltraDropDownBase) this.comboCostCenter).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboCostCenter).ValueMember = string.Empty;
    this.daGetCostCenters.SelectCommand.Parameters["@GlCompanyId"].Value = (object) this._glCompanyId;
    this.daGetCostCenters.Fill(dataSet);
    ((Control) this.CostCenter).Enabled = true;
    ((UltraGridBase) this.comboCostCenter).DataSource = (object) dataSet;
    ((UltraGridBase) this.comboCostCenter).DataMember = dataSet.Tables[0].TableName;
    ((UltraDropDownBase) this.comboCostCenter).DisplayMember = "Name";
    ((UltraDropDownBase) this.comboCostCenter).ValueMember = "CostCenterId";
  }

  private void formExpensedCommissionsDetails_Load(object sender, EventArgs e)
  {
    this.LoadCostCenters();
    this.AddCommissionDetailGridSummary();
  }

  private void gridCommissionDetails_AfterRowExpanded(object sender, RowEventArgs e)
  {
    ((SubObjectBase) e.Row).Tag = (object) true;
  }

  private void dropTreeAccountOffset_Load(object sender, EventArgs e)
  {
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((UltraGridBase) this.gridCommissionDetails).ActiveRow == null || ((GridItemBase) ((UltraGridBase) this.gridCommissionDetails).ActiveRow).Band.Index != 1)
    {
      int num = (int) MessageBox.Show("You must select a detail row to continue.", "Required Selection Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      UltraGridRow activeRow = ((UltraGridBase) this.gridCommissionDetails).ActiveRow;
      switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
      {
        case "PAYBALANCE":
          activeRow.Cells["PayAmount"].Value = activeRow.Cells["Balance"].Value;
          break;
        case "CLEARAMT":
          activeRow.Cells["PayAmount"].Value = (object) DBNull.Value;
          break;
      }
    }
  }

  private void AddCommissionDetailGridSummary()
  {
    ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Bands[0].Summaries.Add((SummaryType) 1, ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Bands[1].Columns["PayAmount"]);
    SummarySettings summary = ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Bands[0].Summaries[0];
    summary.Appearance.TextHAlign = (HAlign) 3;
    summary.DisplayFormat = "{0:c}";
    summary.Appearance.FontData.Bold = (DefaultableBoolean) 1;
    summary.SummaryPosition = (SummaryPosition) 3;
    summary.SummaryPositionColumn = ((UltraGridBase) this.gridCommissionDetails).DisplayLayout.Bands[0].Columns["EffectiveDate"];
  }

  private enum PaymentType : byte
  {
    PayFullyReceived,
    PayProportional,
    PayTotalCommission,
  }

  private enum WizardStep : byte
  {
    Step1,
    ExpenseOffset,
    Summary,
  }
}
