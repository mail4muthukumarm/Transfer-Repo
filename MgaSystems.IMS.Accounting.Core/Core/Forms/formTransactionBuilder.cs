// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formTransactionBuilder
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using ChoETL;
using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.AppStyling.Runtime;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Infragistics.Win.UltraWinProgressBar;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.Extensions;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.AccountsPayable;
using MGASystems.IMS.Accounting.AccountsReceivable;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.DataAccess.BankAccountPaymentType;
using MGASystems.IMS.Accounting.Core.Exceptions;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Services.Forms.MVC.EditDataGridControl.View.GridDisplaySettings.Columns;
using MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.MvcComboBox.View;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.GridDisplaySettings.Columns.BaseClasses;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Accounting.SharedForms;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

[SecureResource("{0D8AB572-A12A-4386-8B58-EA1390F5EF81}", "Transaction write-off rights.", "Determines if the user can write-off a transaction.", "Accounting")]
[SecureResource("{5389EE28-AD3B-4233-B7A1-557D29CEB138}", "Transaction Builder Access Rights.", "Determines wherther or not the user can access the trasnaction builder screen.", "Accounting")]
[SecureResource("{756F0D0D-A87C-4d4a-887E-B6A265CEEF1F}", "Transaction write-off threshold override rights.", "Determines if the user can override a write-off threshold amount.", "Accounting")]
[SecureResource("{B0032CCA-AE39-4fcc-A6E8-51811B8F7EF7}", "Zero Receivables Override.", "Determines if the user can re-open an accounts receivable via a cash receipts posting.", "Accounting")]
[DocumentFolderFilter("Accounting-Transaction Builder")]
[SecureResource("{BA74605C-2DAA-462A-B167-D38E29BF9E61}", "Exceed Receivables Rights.", "Determines if the user can post more than the current accounts receivable amount.", "Accounting")]
[SecureResource("{7870E532-9754-4EF7-8271-AD3BD7EBB942}", "Additional Offset Bank Currency Rights", "Determines if the user can change the default bank currency setting in Additional Offsets.", "Accounting")]
public class formTransactionBuilder : Form, IRecreatableEntity, IExcelAutomation
{
  protected Panel pnlContainer;
  public Panel panel1;
  private const string RECEIVABLE_REQUIRES_FULL_PAYMENT_SETTING = "ReceivableReinstateRequiresFullPayment";
  private IMvcComboBoxModel<BankAccountPaymentTypeDto> _paymentMethodComboModel;
  private IMvcComboBoxController<BankAccountPaymentTypeDto> _paymentMethodComboController;
  private Appearance _redAppearance;
  private Appearance _darkOrangeAppearance;
  protected dsAppliedUnaccounted _appliedUnaccountedDS;
  protected string _bankCurrency;
  protected bool _hasClaims;
  protected int _numberOfClaimsReceived;
  protected bool _isPayableInDirectChipDownView;
  protected bool _isPayableInDirectBillView;
  protected bool _isReceivableInDirectChipDownView;
  protected bool _isReceivableInDirectBillView;
  protected bool _isExcelAutomation;
  protected bool _doNotShowReloadPrompt;
  protected dsOpenReceivables _dsChipDownReceivables;
  protected dsOpenPayables _dsChipDownPayables;
  private DirectBillReceivableCollection _receivableDirectBillReconciliationCollection;
  protected DirectBillPayablesCollection _payableDirectBillReconciliationCollection;
  protected Decimal _receivableAppliedTotal;
  protected Decimal _payableAppliedTotal;
  protected MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValueCollection _payableGridValues;
  private MGASystems.IMS.Accounting.AccountsReceivable.AppliedGridValueCollection _receivableGridValues;
  protected int _glCompanyId;
  protected Guid _entityGuid;
  protected bool _showZeroReceivableInvoices;
  protected SearchCriteriaCollection _additionalSearchOptions;
  protected SearchCriteria _mainSearchOption;
  protected SearchCriteria _currentSearchOption;
  protected formTransactionSearch.SearchTypes _searchType;
  protected bool _isLoadingAdditionalPayables;
  protected bool _isLoadingAdditionalReceivables;
  protected dsOpenReceivables _dsAdditionalOpenReceivables;
  protected dsOpenPayables _dsAdditionalOpenPayables;
  protected InterCompanyTransferCollection _interCompanyTransfers;
  protected FinancedReturnCollection _financedReceivables;
  protected NonPayableFeeCollection _nonPayableFees;
  protected bool _isMassiveUpdate;
  protected bool _isClearingScreen;
  protected bool _isRefreshing;
  protected bool _isAdditonalOffsetInEditMode;
  protected bool _isSummaryPrintingRequired;
  protected bool _isLoadingSavedWorkSheet;
  protected formTransactionBuilder.TabPages _currentPage;
  protected ArrayList _reappliedErrors;
  protected bool _isEnchancedPolicySearch;
  protected ArrayList _partialPay;
  protected ArrayList _afterCancelPay;
  protected bool _loadTypeIsExcel;
  protected readonly bool _allowDifferentThanBankCurrency;
  protected readonly bool _allowDifferentThanBankCurrencyPayables;
  private Dictionary<DateTime, InsuranceTransaction> _futureTransactions;
  protected MGASimpleComboBox comboBankAccount;
  private Label label1;
  private Label label2;
  protected Label label12;
  protected Label label11;
  protected Label label10;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage1;
  protected UltraTabPageControl tabPagePayable;
  private UltraTabPageControl tabPageReceivable;
  protected UltraGrid gridPayables;
  private RadioButton radioChipDownView;
  private Label label3;
  private RadioButton radioSummaryView;
  private RadioButton radioDetailView;
  private UltraProgressBar progressChipDownCreation;
  protected Panel panelGridOptions;
  private Label label4;
  protected Panel panel2;
  private Label label5;
  private UltraProgressBar ultraProgressBar2;
  private Label label6;
  private UltraToolbarsDockArea _formReceivables_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formReceivables_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formReceivables_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formReceivables_Toolbars_Dock_Area_Right;
  protected UltraToolbarsManager toolbar;
  protected UltraTabControl tabTransactions;
  private RadioButton radioPayableSummaryView;
  private RadioButton radioPayableDetailView;
  private RadioButton radioPayableChipDownView;
  private RadioButton radioReceivableChipDownView;
  private RadioButton radioReceivableSummaryView;
  private RadioButton radioReceivableDetailView;
  protected MGASimpleComboBox comboPaymentMethods;
  protected Label label7;
  protected Label labelPayAmt;
  private Label labelBalance;
  protected Label labelCheckDate;
  protected MGADateTimePicker dateTimeCheckDate;
  private Label labelReceivedDate;
  private Label labelDepositDate;
  protected MGADateTimePicker dateTimeReceivedDate;
  protected MGADateTimePicker dateTimeDepositDate;
  private Label labelCheckNumber;
  private Label labelCheckAmount;
  protected Label label8;
  private UltraToolbarsManager toolbarReceivables;
  protected SqlCommand cmdPayables;
  protected SqlDataAdapter daGetPayables;
  protected MGATextBox txtPayAmount;
  protected MGATextBox txtBalance;
  protected MGATextBox txtCheckNumber;
  protected MGATextBox txtCheckAmount;
  protected MGATextBox txtAppliedUnAccounted;
  protected SqlDataAdapter daGetReceivables;
  protected SqlCommand cmdReceivables;
  protected MGATextBox txtUnAccountedBalance;
  private SqlConnection cnReceivables;
  private SqlConnection cnPayables;
  private PayablesInformationViewer xViewPayable;
  private ReceivablesInformationViewer xViewReceivable;
  protected RadioButton radioCashReceipt;
  private SqlDataAdapter daGetBankAccounts;
  protected SqlCommand sqlcmdGetBankAccounts;
  private SqlConnection FormDataConnection;
  protected RadioButton radioCashDisbursement;
  private Panel pnlPayableChipDownView;
  private Panel pnlReceivableChipDownView;
  private UltraProgressBar progressBarPayablesChipDown;
  private UltraProgressBar progressBarReceivableChipDown;
  private dsBankAccounts dsBankAccounts;
  public UltraGrid gridReceivables;
  protected dsOpenReceivables dsOpenReceivables;
  protected dsOpenPayables dsOpenPayables;
  protected CheckBox chkReturnPremium;
  private UltraGrid gridNonPayableFees;
  private UltraLabel ultraLabel1;
  private Label lblDescription;
  public UltraToolbarsManager AdditionalOffsetToolManager;
  private UltraToolbarsDockArea _formAdditionalOffsets_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formAdditionalOffsets_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formAdditionalOffsets_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formAdditionalOffsets_Toolbars_Dock_Area_Right;
  public MGAButton btnCancelChanges;
  public RadioButton radioDebit;
  public RadioButton radioCredit;
  public MGAButton btnAdd;
  public Label label9;
  public Label label13;
  public MGATextBox txtAmount;
  public MGATextBox txtComments;
  public MGASimpleComboBox comboCostCenters;
  public Label lblCostCenter;
  private Label label14;
  public Label labelGLAccount;
  public ExtendedTreeViewDropDown dropTreeGLAccounts;
  private UltraTabPageControl tabNonPayableFees;
  protected UltraTabPageControl tabAdditonalOffsets;
  private UltraTabPageControl tabSummary;
  public UltraGrid gridAdditionalOffsets;
  protected Label labelCurtain;
  protected Label label15;
  protected MGATextBox txtPostingMemo;
  private MGATextBox txtNonPayableFees;
  private Label lblNonPayableFees;
  protected MGASimpleComboBox comboUnAccountedCostCenter;
  protected Label label16;
  protected MGATextBox txtCheckFrom;
  private Label label17;
  private MGAButton btnSearchCheckFrom;
  private LinkLabel linkRemoveCheckFrom;
  private ImageList imageList1;
  private Panel panelToggleCheckRequested;
  private MGACheckBox checkToggleCheckRequested;
  private MGADateTimePicker dateTimeToggleCheckRequested;
  private IContainer components;
  private Label lblbBankCurrency;
  protected MGACheckBox checkCreditCard;
  protected MGAButton buttonAppliedUnaccounted;
  protected MGAButton buttonCancelAppliedUnaccounted;
  private ToolTip toolTip1;
  private UltraTabPageControl ultraTabPageControl1;
  protected UltraGrid gridNonWorkingDeposit;
  private UltraGridExcelExporter ultraGridExcelExporter1;
  public MGACheckBox checkBankCurrency;
  private AppStylistRuntime appStylistRuntime1;
  private PrintDocument c_pdSetup;
  protected Label labelPayablesExist;
  protected Label labelReceiveablesExist;
  private MvcComboBoxView comboPayeePaymentMethods;
  protected MGATextBox txtEntityName;
  protected const string EXCELAP_PROCEDURESETTINGNAME = "EXCEL_AP_PROCEDURENAME";
  protected const string EXCELAR_PROCEDURESETTINGNAME = "EXCEL_AR_PROCEDURENAME";
  protected const string EXCELCLAIMSAR_PROCEDURESETTINGNAME = "EXCEL_CLAIMSAR_PROCEDURENAME";
  protected const string CLAIMSPOSTBULK_APSETTING = "POSTBULK_AP";
  protected const string POSTBULK_APSETTING = "POSTBULK_AP";
  private const int CommandTimeout = 300;
  public string dataImportXML;
  public UltraGrid GridClaimARImport;
  public UltraGrid GridClaimAPImport;
  public DataSet DSClaimAR;
  public DataSet DSClaimAP;
  private Dictionary<string, IEnumerable<UltraGridRow>> _mappedGrid;

  public formTransactionBuilder()
  {
    Appearance appearance1 = new Appearance();
    ((AppearanceBase) appearance1).ForeColor = Color.Red;
    this._redAppearance = appearance1;
    Appearance appearance2 = new Appearance();
    ((AppearanceBase) appearance2).ForeColor = Color.DarkOrange;
    this._darkOrangeAppearance = appearance2;
    this._bankCurrency = "USD";
    this.ReinstatementList = new SortedList();
    this._partialPay = new ArrayList();
    this._afterCancelPay = new ArrayList();
    this._allowDifferentThanBankCurrency = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("AllowDifferentThanBankCurrency", true);
    this._allowDifferentThanBankCurrencyPayables = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("AllowDifferentThanBankCurrencyPayables", true);
    this.LoadPayablesParamsCleared = (EventHandler) ((_param1, _param2) => { });
    this.c_pdSetup = new PrintDocument();
    this.dataImportXML = string.Empty;
    // ISSUE: explicit constructor call
    base.\u002Ector();
    this.InitializeComponent();
    this._currentPage = formTransactionBuilder.TabPages.Payable;
    this.cnPayables.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.cnReceivables.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.SetOptionalDataBindings();
    this._additionalSearchOptions = new SearchCriteriaCollection();
    this._dsAdditionalOpenPayables = new dsOpenPayables();
    this._dsAdditionalOpenReceivables = new dsOpenReceivables();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void SetOptionalDataBindings()
  {
    ((Control) this.txtCheckAmount).DataBindings.Add("Enabled", (object) this.radioCashReceipt, "Checked");
    ((Control) this.txtBalance).DataBindings.Add("Enabled", (object) this.radioCashReceipt, "Checked");
    ((Control) this.checkCreditCard).DataBindings.Add("Enabled", (object) this.radioCashReceipt, "Checked");
    ((Control) this.txtCheckNumber).DataBindings.Add("Enabled", (object) this.radioCashReceipt, "Checked");
    ((Control) this.dateTimeReceivedDate).DataBindings.Add("Enabled", (object) this.radioCashReceipt, "Checked");
    ((Control) this.dateTimeDepositDate).DataBindings.Add("Enabled", (object) this.radioCashReceipt, "Checked");
    ((Control) this.dateTimeCheckDate).DataBindings.Add("Enabled", (object) this.radioCashDisbursement, "Checked");
    ((Control) this.comboPaymentMethods).DataBindings.Add("Enabled", (object) this.radioCashDisbursement, "Checked");
    ((Control) this.txtPayAmount).DataBindings.Add("Enabled", (object) this.radioCashDisbursement, "Checked");
  }

  protected SortedList ReinstatementList { get; }

  protected bool LoadTypeIsExcel
  {
    get => this._loadTypeIsExcel;
    set => this._loadTypeIsExcel = value;
  }

  public bool IsEnhancedPolicySearch
  {
    get => this._isEnchancedPolicySearch;
    set => this._isEnchancedPolicySearch = value;
  }

  public bool IsExcelAutomation
  {
    get => this._isExcelAutomation;
    set => this._isExcelAutomation = value;
  }

  public int GLCompanyId
  {
    get => this._glCompanyId;
    set => this._glCompanyId = value;
  }

  protected Guid ProtectedEntityGuid
  {
    get => this._entityGuid;
    set => this._entityGuid = value;
  }

  protected bool IsSummaryPrintingRequired => this._isSummaryPrintingRequired;

  protected SearchCriteria SearchOptions
  {
    get => this._mainSearchOption;
    set => this._mainSearchOption = value;
  }

  protected SearchCriteria CurrentSearchOption
  {
    get => this._currentSearchOption;
    set => this._currentSearchOption = value;
  }

  protected formTransactionSearch.SearchTypes SearchType
  {
    get => this._searchType;
    set => this._searchType = value;
  }

  private DirectBillReceivableCollection ReceivableDirectBillReconcilliationColletion
  {
    get
    {
      if (this._receivableDirectBillReconciliationCollection == null)
        this._receivableDirectBillReconciliationCollection = new DirectBillReceivableCollection();
      return this._receivableDirectBillReconciliationCollection;
    }
  }

  private DirectBillPayablesCollection PayableDirectBillReconcilliationCollection
  {
    get
    {
      if (this._payableDirectBillReconciliationCollection == null)
        this._payableDirectBillReconciliationCollection = new DirectBillPayablesCollection();
      return this._payableDirectBillReconciliationCollection;
    }
  }

  private NonPayableFeeCollection NonPayableFees
  {
    get
    {
      if (this._nonPayableFees == null)
        this._nonPayableFees = new NonPayableFeeCollection();
      return this._nonPayableFees;
    }
  }

  private MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValueCollection PayableGridValues
  {
    get
    {
      if (this._payableGridValues == null)
        this._payableGridValues = new MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValueCollection();
      return this._payableGridValues;
    }
  }

  private MGASystems.IMS.Accounting.AccountsReceivable.AppliedGridValueCollection ReceivableGridValues
  {
    get
    {
      if (this._receivableGridValues == null)
        this._receivableGridValues = new MGASystems.IMS.Accounting.AccountsReceivable.AppliedGridValueCollection();
      return this._receivableGridValues;
    }
  }

  private SearchCriteriaCollection AdditionalSearchOptions
  {
    get
    {
      if (this._additionalSearchOptions == null)
        this._additionalSearchOptions = new SearchCriteriaCollection();
      return this._additionalSearchOptions;
    }
  }

  private InterCompanyTransferCollection InterCompanyTransfers
  {
    get
    {
      if (this._interCompanyTransfers == null)
        this._interCompanyTransfers = new InterCompanyTransferCollection();
      return this._interCompanyTransfers;
    }
  }

  private FinancedReturnCollection FinancedReceivables
  {
    get
    {
      if (this._financedReceivables == null)
        this._financedReceivables = new FinancedReturnCollection();
      return this._financedReceivables;
    }
  }

  protected bool HasClaims
  {
    get => this._hasClaims;
    set => this._hasClaims = value;
  }

  protected int NumberOfClaimsReceived
  {
    get => this._numberOfClaimsReceived;
    set => this._numberOfClaimsReceived = value;
  }

  protected string BankCurrency => this._bankCurrency;

  private void ReLoad()
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      this.ChildPreReload();
      if (!this._isLoadingSavedWorkSheet)
        this.Clear();
      if (this._isRefreshing)
      {
        this.LoadBankAccounts();
        this.LoadCostCenters(this.comboCostCenters);
        this.LoadCostCenters(this.comboUnAccountedCostCenter);
      }
      this._currentSearchOption = this._mainSearchOption;
      this._isLoadingAdditionalPayables = false;
      this._isLoadingAdditionalReceivables = false;
      this.LoadNew();
      SearchCriteriaCollection criteriaCollection = new SearchCriteriaCollection();
      foreach (SearchCriteria additionalSearchOption in (CollectionBase) this._additionalSearchOptions)
      {
        if (!criteriaCollection.Contains(additionalSearchOption))
        {
          criteriaCollection.Add(additionalSearchOption);
          this._isLoadingAdditionalPayables = true;
          this._isLoadingAdditionalReceivables = true;
          if (additionalSearchOption.PayableSearchType != MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.None)
          {
            this._currentSearchOption = additionalSearchOption;
            this.LoadPayables();
          }
          if (additionalSearchOption.ReceivableSearchType != MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.None)
          {
            this._currentSearchOption = additionalSearchOption;
            this.LoadReceivables();
          }
        }
      }
      if (!this._isRefreshing)
      {
        if (!this._isLoadingSavedWorkSheet)
          goto label_20;
      }
      this.labelCurtain.SendToBack();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
label_20:
    this.ChildReload();
  }

  protected virtual void ChildPreReload()
  {
  }

  protected virtual void ChildReload()
  {
  }

  private void SetUpSearchValues(formTransactionSearch f)
  {
    this._showZeroReceivableInvoices = f.ShowZeroInvoices;
    this._entityGuid = f.EntityGuid;
    f.Criteria.EntityGuid = f.EntityGuid;
    this._mainSearchOption = f.Criteria;
    this._glCompanyId = f.GlCompanyId;
    this._currentSearchOption = this._mainSearchOption;
    ((Control) this.txtEntityName).Text = f.EntityName;
    this._searchType = f.SearchType;
  }

  protected void LoadPayablesAndReceivables()
  {
    this._currentPage = formTransactionBuilder.TabPages.Payable;
    ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Visible = true;
    ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Visible = true;
    this.LoadReceivables();
    this.LoadPayables();
    this.GetEntityUnAccountedBalance();
  }

  protected virtual void LoadNew()
  {
    ((Control) this.tabTransactions).Show();
    this.chkReturnPremium.Enabled = false;
    if (!this._isLoadingSavedWorkSheet && !this._isRefreshing && !this._isExcelAutomation && !this._isEnchancedPolicySearch)
    {
      using (formTransactionSearch form = (formTransactionSearch) ObjectFactory.Instance.CreateForm(typeof (formTransactionSearch)))
      {
        if (form.ShowDialog() == DialogResult.Cancel)
          return;
        this.Clear();
        this.SetUpSearchValues(form);
        this.LoadBankAccounts();
        this.LoadCostCenters(this.comboUnAccountedCostCenter);
        this.LoadCostCenters(this.comboCostCenters);
      }
    }
    this.SetToolBarButtonState(true);
    this.SetToolBarButtonState(this._searchType);
    this.labelCurtain.BringToFront();
    switch (this._searchType)
    {
      case formTransactionSearch.SearchTypes.Payables:
        if (!this._isLoadingSavedWorkSheet)
        {
          this.radioCashDisbursement.Checked = true;
          this.chkReturnPremium.Checked = false;
        }
        this._currentPage = formTransactionBuilder.TabPages.Payable;
        this.LoadPayables();
        this.GetEntityUnAccountedBalance();
        if (this._currentSearchOption.PayableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Bordereau || this._currentSearchOption.PayableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.BordereauPayee)
          this.LoadNonPayableFees();
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Selected = true;
        break;
      case formTransactionSearch.SearchTypes.Receivables:
        if (!this._isLoadingSavedWorkSheet)
        {
          this.radioCashReceipt.Checked = true;
          this.chkReturnPremium.Checked = false;
        }
        this._currentPage = formTransactionBuilder.TabPages.Receivable;
        this.LoadReceivables();
        this.LoadNonWorkingDeposit();
        this.GetEntityUnAccountedBalance();
        ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Selected = true;
        break;
      case formTransactionSearch.SearchTypes.PayablesReceivables:
        if (!this._isLoadingSavedWorkSheet)
        {
          this.chkReturnPremium.Checked = false;
          this.chkReturnPremium.Enabled = true;
        }
        this.LoadPayablesAndReceivables();
        this.LoadNonWorkingDeposit();
        ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Selected = true;
        break;
    }
    this.OnDataLoadComplete();
  }

  protected virtual void OnDataLoadComplete()
  {
  }

  protected void SetToolBarButtonState(bool state)
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["TOGGLEPAID"].SharedProps.Visible = state;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["INTERCOMPANY"].SharedProps.Visible = state;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["POST"].SharedProps.Visible = state;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["LOADADDITIONAL"].SharedProps.Visible = state;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["PRINT"].SharedProps.Visible = state;
  }

  protected void SetToolBarButtonState(formTransactionSearch.SearchTypes type)
  {
    bool flag1 = type == formTransactionSearch.SearchTypes.Payables;
    bool flag2 = type == formTransactionSearch.SearchTypes.Receivables;
    bool flag3 = type == formTransactionSearch.SearchTypes.PayablesReceivables;
    ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["LOADADDITIONAL"]).Tools)["LOADADDITIONALPAYABLES"].SharedProps.Visible = flag1 | flag3;
    ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["LOADADDITIONAL"]).Tools)["LOADADDITIONALRECEIVABLES"].SharedProps.Visible = flag2 | flag3;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["TOGGLEPAID"].SharedProps.Enabled = flag1 | flag3;
    ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["OPTIONS"]).Tools)["SAVE"].SharedProps.Visible = true;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["PRINT"].SharedProps.Visible = true;
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["IMPORTERRORS"].SharedProps.Visible = this._isExcelAutomation;
    ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Visible = flag1 | flag3;
    ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Visible = flag2 | flag3;
    if (flag1)
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["POST"].SharedProps.Enabled = SecurityManager.Instance.AssertPermission("{FE58A2D8-3233-4E0B-A649-88BF41958575}");
    else if (flag2)
    {
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["POST"].SharedProps.Enabled = SecurityManager.Instance.AssertPermission("{1CA15155-6B68-4851-A62B-B2F071BE2293}");
    }
    else
    {
      if (!flag3)
        return;
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["POST"].SharedProps.Enabled = SecurityManager.Instance.AssertPermission("{FE58A2D8-3233-4E0B-A649-88BF41958575}") && SecurityManager.Instance.AssertPermission("{1CA15155-6B68-4851-A62B-B2F071BE2293}");
    }
  }

  private void PayableTabUiUpdate(bool bold, string text)
  {
    UltraTab tab = ((UltraTabControlBase) this.tabTransactions)?.Tabs["PAYABLE"];
    if (tab == null)
      return;
    tab.Appearance.FontData.Bold = bold ? (DefaultableBoolean) 1 : (DefaultableBoolean) 2;
    tab.Text = text;
  }

  protected void LoadPayables()
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["LOADADDITIONAL"].SharedProps.Enabled = false;
    if (!this._isRefreshing && !this._isLoadingSavedWorkSheet && !this._isExcelAutomation)
    {
      this.Cursor = Cursors.WaitCursor;
      new Thread(new ThreadStart(this.DoLoadPayables)).Start();
    }
    else
      this.DoLoadPayables();
  }

  public event EventHandler LoadPayablesParamsCleared;

  protected void OnLoadPayablesParamsCleared()
  {
    EventHandler payablesParamsCleared = this.LoadPayablesParamsCleared;
    if (payablesParamsCleared == null)
      return;
    payablesParamsCleared((object) this, new EventArgs());
  }

  protected virtual void DoLoadPayables()
  {
    foreach (DbParameter parameter in (DbParameterCollection) this.daGetPayables.SelectCommand.Parameters)
      parameter.Value = (object) DBNull.Value;
    this.OnLoadPayablesParamsCleared();
    this.daGetPayables.SelectCommand.Parameters["@payeeGuid"].Value = (object) this._currentSearchOption.SearchForGuid;
    this.daGetPayables.SelectCommand.Parameters["@glcompanyid"].Value = (object) this._glCompanyId;
    switch (this._currentSearchOption.PayableSearchType)
    {
      case MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.ControlNumber:
        this.daGetPayables.SelectCommand.Parameters["@controlnumber"].Value = (object) this._currentSearchOption.SearchForInteger;
        break;
      case MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.InvoiceNumber:
        this.daGetPayables.SelectCommand.Parameters["@invoicenumber"].Value = (object) this._currentSearchOption.SearchForInteger;
        break;
      case MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.PolicyNumber:
        this.daGetPayables.SelectCommand.Parameters["@policynumber"].Value = (object) this._currentSearchOption.SearchForString;
        break;
      case MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Bordereau:
        this.daGetPayables.SelectCommand.Parameters["@bordereau"].Value = (object) this._currentSearchOption.SearchForDate;
        break;
      case MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.BordereauPayee:
        this.daGetPayables.SelectCommand.Parameters["@bordereau"].Value = (object) this._currentSearchOption.SearchForDate;
        break;
      case MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.FeesFiling:
        this.daGetPayables.SelectCommand.Parameters["@filingFee"].Value = (object) this._currentSearchOption.SearchForDate;
        break;
    }
    this.daGetPayables.SelectCommand.CommandTimeout = 0;
    string text = ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Text;
    try
    {
      if (!this.IsDisposed)
      {
        if (this.InvokeRequired)
          this.BetterInvoke((Delegate) new formTransactionBuilder.PayableTabUiUpdateHandler(this.PayableTabUiUpdate), (object) true, (object) "Loading...");
        else
          this.PayableTabUiUpdate(true, "Loading...");
      }
      if (!this._isLoadingAdditionalPayables)
      {
        if (!this._isExcelAutomation && this.dsOpenPayables != null)
          this.dsOpenPayables.Clear();
        this.dsOpenPayables.AcceptChanges();
        this.daGetPayables.Fill((DataTable) this.dsOpenPayables.OpenPayables);
      }
      else
      {
        this._dsAdditionalOpenPayables.Clear();
        this._dsAdditionalOpenPayables.AcceptChanges();
        this.daGetPayables.Fill((DataTable) this._dsAdditionalOpenPayables.OpenPayables);
      }
    }
    catch (SqlException ex)
    {
      if (!this.InvokeRequired)
        throw ex;
      if (!this.IsDisposed)
      {
        if (!this.Disposing)
          this.Invoke((Delegate) new formTransactionBuilder.SqlThreadExceptionHandler(this.SqlThreadException), (object) ex);
      }
    }
    finally
    {
      if (!this.IsDisposed)
      {
        if (this.InvokeRequired)
          this.BetterInvoke((Delegate) new formTransactionBuilder.PayableTabUiUpdateHandler(this.PayableTabUiUpdate), (object) false, (object) text);
        else
          this.PayableTabUiUpdate(false, text);
      }
    }
    if (!this.IsDisposed && !this.Disposing)
    {
      if (!this._isLoadingAdditionalPayables)
      {
        try
        {
          this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadOpenAccountsPayablesCompleted));
        }
        catch (ObjectDisposedException ex)
        {
        }
      }
      else
      {
        try
        {
          this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadAdditionalPayablesCompleted));
        }
        catch (ObjectDisposedException ex)
        {
        }
      }
    }
    else if (!this._isLoadingAdditionalPayables)
      this.LoadOpenAccountsPayablesCompleted();
    else
      this.LoadAdditionalPayablesCompleted();
  }

  private void SqlThreadException(SqlException sqlX) => throw sqlX;

  protected virtual void LoadOpenAccountsPayablesCompleted()
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["LOADADDITIONAL"].SharedProps.Enabled = true;
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
    {
      ((UltraGridBase) this.gridPayables).SetDataBinding((object) this.dsOpenPayables, "OpenPayables");
      ((UltraControlBase) this.gridPayables).BeginUpdate();
      ((UltraGridBase) this.gridPayables).SuspendRowSynchronization();
    }
    else
    {
      ((UltraGridBase) this.gridPayables).DataSource = (object) this.dsOpenPayables;
      ((UltraGridBase) this.gridPayables).DataMember = this.dsOpenPayables.OpenPayables.ToString();
    }
    try
    {
      UltraGridLayout transactionBuilderLayout = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetTransactionBuilderLayout("AP_SUMMARYVIEW_v3.lyt");
      this.FormatPayablesGrid();
      this.LoadPayablesInitialLayout();
      if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns).Exists(formTransactionBuilder.ArApGridColumnKeys.CarrierCommission))
      {
        if (transactionBuilderLayout == null)
          ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.CarrierCommission].Hidden = true;
        ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.CarrierCommission].Format = "c";
        ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.CarrierCommission].CellAppearance.TextHAlign = (HAlign) 3;
        ((HeaderBase) ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.CarrierCommission].Header).Appearance.TextHAlign = (HAlign) 3;
        if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries).Exists("CarrierCommissionSum"))
        {
          SummarySettings summarySettings = ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries.Add("CarrierCommissionSum", (SummaryType) 1, ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns["CarrierCommission"]);
          summarySettings.SummaryPosition = (SummaryPosition) 3;
          summarySettings.SummaryPositionColumn = ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns["CarrierCommission"];
          summarySettings.DisplayFormat = "{0:c}";
          summarySettings.Appearance.TextHAlign = (HAlign) 3;
        }
      }
      if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns).Exists(formTransactionBuilder.ArApGridColumnKeys.GrossBilled))
      {
        if (transactionBuilderLayout == null)
          ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.GrossBilled].Hidden = true;
        ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.GrossBilled].Format = "c";
        ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.GrossBilled].CellAppearance.TextHAlign = (HAlign) 3;
        ((HeaderBase) ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.GrossBilled].Header).Appearance.TextHAlign = (HAlign) 3;
        if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries).Exists("GrossBilledSum"))
        {
          SummarySettings summarySettings = ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries.Add("GrossBilledSum", (SummaryType) 1, ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.GrossBilled]);
          summarySettings.SummaryPosition = (SummaryPosition) 3;
          summarySettings.SummaryPositionColumn = ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.GrossBilled];
          summarySettings.DisplayFormat = "{0:c}";
          summarySettings.Appearance.TextHAlign = (HAlign) 3;
        }
      }
      if (this.dsOpenPayables.OpenPayables.Rows.Count > 0 && !this._isExcelAutomation)
      {
        this.CreateDirectBillPayableView();
        this.radioPayableChipDownView.Visible = true;
        this.radioPayableSummaryView.Enabled = this.radioPayableDetailView.Enabled = true;
      }
      this.GeneratePayableGridSummaryRow();
      if (!this._isRefreshing && !this._isLoadingSavedWorkSheet)
      {
        this.labelCurtain.SendToBack();
        this.Cursor = Cursors.Default;
      }
      this.SetGridButtonImages(this.gridPayables);
    }
    finally
    {
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
      {
        ((UltraGridBase) this.gridPayables).ResumeRowSynchronization();
        ((UltraControlBase) this.gridPayables).EndUpdate();
      }
    }
  }

  private void LoadPayablesInitialLayout()
  {
    UltraGridLayout transactionBuilderLayout = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetTransactionBuilderLayout("AP_SUMMARYVIEW_v3.lyt");
    if (transactionBuilderLayout != null)
      ((UltraGridBase) this.gridPayables).DisplayLayout.Load(transactionBuilderLayout, (PropertyCategories) -1);
    else
      ((UltraGridBase) this.gridPayables).DisplayLayout.Load(((UltraGridBase) this.gridPayables).Layouts["SummaryView"], (PropertyCategories) -1);
  }

  private void ReceivableTabUiUpdate(bool bold, string text)
  {
    UltraTab tab = ((UltraTabControlBase) this.tabTransactions)?.Tabs["RECEIVABLE"];
    if (tab == null)
      return;
    tab.Appearance.FontData.Bold = bold ? (DefaultableBoolean) 1 : (DefaultableBoolean) 2;
    tab.Text = text;
  }

  protected void LoadReceivables()
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["LOADADDITIONAL"].SharedProps.Enabled = false;
    if (!this._isRefreshing && !this._isLoadingSavedWorkSheet && !this._isExcelAutomation)
      new Thread(new ThreadStart(this.DoLoadReceivables)).Start();
    else
      this.DoLoadReceivables();
  }

  protected virtual void DoLoadReceivables()
  {
    foreach (DbParameter parameter in (DbParameterCollection) this.daGetReceivables.SelectCommand.Parameters)
      parameter.Value = (object) DBNull.Value;
    this.daGetReceivables.SelectCommand.Parameters["@RemitterGuid"].Value = (object) this._currentSearchOption.SearchForGuid;
    this.daGetReceivables.SelectCommand.Parameters["@glcompanyid"].Value = (object) this._glCompanyId;
    this.daGetReceivables.SelectCommand.Parameters["@ShowZeros"].Value = (object) this._currentSearchOption.ShowZeros;
    this.daGetReceivables.SelectCommand.Parameters["@EntityGuid"].Value = (object) this._currentSearchOption.EntityGuid;
    switch (this._currentSearchOption.ReceivableSearchType)
    {
      case MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.ControlNumber:
        this.daGetReceivables.SelectCommand.Parameters["@ControlNumber"].Value = (object) this._currentSearchOption.SearchForInteger;
        break;
      case MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.InvoiceNumber:
        this.daGetReceivables.SelectCommand.Parameters["@InvoiceNumber"].Value = (object) this._currentSearchOption.SearchForInteger;
        break;
      case MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.PolicyNumber:
        this.daGetReceivables.SelectCommand.Parameters["@PolicyNumber"].Value = (object) this._currentSearchOption.SearchForString;
        break;
    }
    this.daGetReceivables.SelectCommand.CommandTimeout = 0;
    string text = ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Text;
    try
    {
      if (!this.IsDisposed)
      {
        if (this.InvokeRequired)
          this.BetterInvoke((Delegate) new formTransactionBuilder.ReceivableTabUiUpdateHandler(this.ReceivableTabUiUpdate), (object) true, (object) "Loading...");
        else
          this.ReceivableTabUiUpdate(true, "Loading...");
      }
      if (!this._isLoadingAdditionalReceivables)
      {
        if (this.dsOpenReceivables != null)
        {
          if (!this._isExcelAutomation)
            this.dsOpenReceivables.Clear();
          this.dsOpenReceivables.AcceptChanges();
        }
        this.daGetReceivables.Fill((DataTable) this.dsOpenReceivables.OpenReceivables);
      }
      else
      {
        this._dsAdditionalOpenReceivables.Clear();
        this._dsAdditionalOpenReceivables.AcceptChanges();
        this.daGetReceivables.Fill(this._dsAdditionalOpenReceivables.Tables[0]);
      }
    }
    catch (SqlException ex1)
    {
      if (!this.InvokeRequired)
        throw ex1;
      if (!this.IsDisposed)
      {
        if (!this.Disposing)
        {
          try
          {
            this.Invoke((Delegate) new formTransactionBuilder.SqlThreadExceptionHandler(this.SqlThreadException), (object) ex1);
          }
          catch (ObjectDisposedException ex2)
          {
          }
        }
      }
    }
    finally
    {
      if (!this.IsDisposed)
      {
        if (this.InvokeRequired)
          this.BetterInvoke((Delegate) new formTransactionBuilder.ReceivableTabUiUpdateHandler(this.ReceivableTabUiUpdate), (object) false, (object) text);
        else
          this.ReceivableTabUiUpdate(false, text);
      }
    }
    if (this.IsDisposed || this.Disposing)
      return;
    if (!this._isLoadingAdditionalReceivables)
    {
      try
      {
        this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadOpenAccountsReceivableCompleted));
      }
      catch (ObjectDisposedException ex)
      {
      }
    }
    else
    {
      try
      {
        this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadAdditonalReceivablesCompleted));
      }
      catch (ObjectDisposedException ex)
      {
      }
    }
  }

  protected virtual void LoadOpenAccountsReceivableCompleted()
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["LOADADDITIONAL"].SharedProps.Enabled = true;
    ((UltraGridBase) this.gridReceivables).DataSource = (object) this.dsOpenReceivables;
    ((UltraGridBase) this.gridReceivables).DataMember = this.dsOpenReceivables.OpenReceivables.ToString();
    UltraGridLayout transactionBuilderLayout = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetTransactionBuilderLayout("AR_SUMMARYVIEW_v3.lyt");
    if (transactionBuilderLayout != null)
      ((UltraGridBase) this.gridReceivables).DisplayLayout.Load(transactionBuilderLayout, (PropertyCategories) -1);
    else
      ((UltraGridBase) this.gridReceivables).DisplayLayout.Load(((UltraGridBase) this.gridReceivables).Layouts["SummaryView"], (PropertyCategories) -1);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.ExchApplied].ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied].ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 2;
    if (this.dsOpenReceivables.Tables[0].Rows.Count > 0)
    {
      this.radioReceivableChipDownView.Visible = true;
      this.radioReceivableDetailView.Enabled = this.radioReceivableSummaryView.Enabled = true;
      this.CreateDirectBillReceivableView();
    }
    this.radioReceivableDetailView.Enabled = this.dsOpenReceivables.Tables[0].Rows.Count > 0;
    this.radioReceivableSummaryView.Enabled = this.dsOpenReceivables.Tables[0].Rows.Count > 0;
    this.GenerateReceivableGridSummaryRow();
    if (!this._isRefreshing && !this._isLoadingSavedWorkSheet && this._searchType == formTransactionSearch.SearchTypes.Receivables)
      this.labelCurtain.SendToBack();
    this.SetGridButtonImages(this.gridReceivables);
  }

  private void SetGridButtonImages(UltraGrid grid)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) grid).DisplayLayout.Bands).Count == 0)
      return;
    UltraGridBand band = ((UltraGridBase) grid).DisplayLayout.Bands[0];
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists(formTransactionBuilder.ArApGridColumnKeys.ArApplied))
      band.Columns[formTransactionBuilder.ArApGridColumnKeys.ArApplied].CellButtonAppearance.Image = (object) Resources.wrench_orange;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists(formTransactionBuilder.ArApGridColumnKeys.ApApplied))
      band.Columns[formTransactionBuilder.ArApGridColumnKeys.ApApplied].CellButtonAppearance.Image = (object) Resources.wrench_orange;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists(formTransactionBuilder.ArApGridColumnKeys.PolicyNumber))
      band.Columns[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].CellButtonAppearance.Image = (object) Resources.wrench_orange;
    if (!((KeyedSubObjectsCollectionBase) band.Columns).Exists(formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNum))
      return;
    band.Columns[formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNum].CellButtonAppearance.Image = (object) Resources.wrench_orange;
  }

  protected void LoadNonPayableFees()
  {
    if (AccountingCache.Instance.GlCompany(this._glCompanyId).OfficeAccountingMethod != Utilities.AccountingMethod.Cash || AccountingCache.Instance.GlCompany(this._glCompanyId).CommissionReconciliation != Utilities.CommissionReconciliation.Payables || this._mainSearchOption.PayableSearchType != MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Bordereau && this._mainSearchOption.PayableSearchType != MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.BordereauPayee)
      return;
    new Thread(new ThreadStart(this.DoLoadNonPayableFees))
    {
      IsBackground = true,
      Name = nameof (LoadNonPayableFees)
    }.Start();
  }

  private void DoLoadNonPayableFees()
  {
    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetNonPayableFees", new SqlConnection(CurrentUser.Instance.ConnectionString))))
    {
      dsNonPayableFees dsNonPayableFees = new dsNonPayableFees();
      try
      {
        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@payeeGuid", (object) this._entityGuid);
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glCompanyId", (object) this._glCompanyId);
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@TransactionDate", (object) this._mainSearchOption.SearchForDate);
        sqlDataAdapter.SelectCommand.CommandTimeout = 0;
        sqlDataAdapter.Fill((DataTable) dsNonPayableFees.NonPayableFees);
      }
      catch (Exception ex)
      {
        if (!this.IsDisposed)
        {
          if (!this.Disposing)
            this.Invoke((Delegate) new formTransactionBuilder.NonUIExceptionThrownHandler(this.NonUiExceptionThrown), (object) ex);
        }
      }
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new formTransactionBuilder.LoadNonPayableFeesCompletedHandler(this.LoadNonPayableFeesCompleted), (object) dsNonPayableFees);
    }
  }

  private void LoadNonPayableFeesCompleted(dsNonPayableFees dataNonPayableFees)
  {
    if (dataNonPayableFees.NonPayableFees.Rows.Count == 0)
      return;
    this.lblNonPayableFees.Visible = ((Control) this.txtNonPayableFees).Visible = true;
    ((UltraTabControlBase) this.tabTransactions).Tabs["NONPAYABLEFEES"].Visible = true;
    this._nonPayableFees.Clear();
    this._nonPayableFees = new NonPayableFeeCollection(dataNonPayableFees);
    ((UltraGridBase) this.gridNonPayableFees).DataSource = (object) this._nonPayableFees;
    ((Control) this.gridNonPayableFees).Visible = true;
    ((Control) this.txtNonPayableFees).Text = this.NonPayableFees.SelectedNonPayableFeeTotal().ToString("c");
  }

  private void NonUiExceptionThrown(Exception exceptionObject) => throw exceptionObject;

  private void LoadAdditional(bool isPayable, bool showAdditionalSearchOptions)
  {
    formTransactionSearch.SearchTypes searchTypes = !isPayable ? formTransactionSearch.SearchTypes.Receivables : formTransactionSearch.SearchTypes.Payables;
    if (showAdditionalSearchOptions)
    {
      using (formTransactionSearch form = (formTransactionSearch) ObjectFactory.Instance.CreateForm(typeof (formTransactionSearch), new object[4]
      {
        (object) searchTypes,
        (object) this._glCompanyId,
        (object) ((Control) this.txtEntityName).Text,
        (object) this._entityGuid
      }))
      {
        if (form.ShowDialog() != DialogResult.OK)
          return;
        this._currentSearchOption = form.Criteria;
        this._currentSearchOption.EntityGuid = this._entityGuid;
        this.AdditionalSearchOptions.Add(this._currentSearchOption);
        if (isPayable)
        {
          ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Selected = true;
          this._isLoadingAdditionalPayables = true;
          this.LoadPayables();
        }
        else
        {
          ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Selected = true;
          this._isLoadingAdditionalReceivables = true;
          this.LoadReceivables();
        }
      }
    }
    else
    {
      this.AdditionalSearchOptions.Add(this._currentSearchOption);
      if (isPayable)
      {
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Selected = true;
        this._isLoadingAdditionalPayables = true;
        this.LoadPayables();
      }
      else
      {
        ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Selected = true;
        this._isLoadingAdditionalReceivables = true;
        this.LoadReceivables();
      }
    }
  }

  private void LoadAdditonalReceivablesCompleted()
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["LOADADDITIONAL"].SharedProps.Enabled = true;
    this._isLoadingAdditionalReceivables = false;
    if (this._dsAdditionalOpenReceivables == null || this._dsAdditionalOpenReceivables.OpenReceivables.Rows.Count == 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) this._dsAdditionalOpenReceivables.OpenReceivables.Rows)
    {
      if (this.dsOpenReceivables.OpenReceivables.Select($"InvoiceNum = {row[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber]} and ChargeCode = {row[formTransactionBuilder.ArApGridColumnKeys.ChargeCode]} and CompanyLineGuid = '{row[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].ToString()}' and QuoteControlNum = {row[formTransactionBuilder.ArApGridColumnKeys.ControlNum]}").Length != 0)
      {
        row.Delete();
        if (!this._isExcelAutomation)
          this.labelReceiveablesExist.Visible = true;
      }
    }
    this._dsAdditionalOpenReceivables.AcceptChanges();
    if (this._dsAdditionalOpenReceivables.OpenReceivables.Rows.Count > 0)
      this.dsOpenReceivables.Merge((DataSet) this._dsAdditionalOpenReceivables);
    if (!this._isExcelAutomation)
      this.CreateDirectBillReceivableView();
    if (!this._isRefreshing && !this._isLoadingSavedWorkSheet)
      this.labelCurtain.SendToBack();
    this.radioReceivableDetailView.Enabled = this.dsOpenReceivables.Tables[0].Rows.Count > 0;
    this.radioReceivableSummaryView.Enabled = this.dsOpenReceivables.Tables[0].Rows.Count > 0;
  }

  private void LoadAdditionalPayablesCompleted()
  {
    ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["LOADADDITIONAL"].SharedProps.Enabled = true;
    this._isLoadingAdditionalPayables = false;
    if (this._dsAdditionalOpenPayables == null || this._dsAdditionalOpenPayables.OpenPayables.Rows.Count == 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) this._dsAdditionalOpenPayables.OpenPayables.Rows)
    {
      if (this.dsOpenPayables.OpenPayables.Select($"InvoiceNum = {row[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber]} and ChargeCode = {row[formTransactionBuilder.ArApGridColumnKeys.ChargeCode]} and CompanyLineGuid = '{row[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].ToString()}' and QuoteControlNum = {row[formTransactionBuilder.ArApGridColumnKeys.ControlNum]} and PayeeGuid = '{row[formTransactionBuilder.ArApGridColumnKeys.PayeeGuid]}'").Length != 0)
      {
        row.Delete();
        if (!this._isExcelAutomation)
          this.labelPayablesExist.Visible = true;
      }
    }
    this._dsAdditionalOpenPayables.AcceptChanges();
    if (this._dsAdditionalOpenPayables.OpenPayables.Rows.Count > 0)
      this.dsOpenPayables.Merge((DataSet) this._dsAdditionalOpenPayables);
    if (!this._isExcelAutomation)
      this.CreateDirectBillPayableView();
    if (!this._isRefreshing && !this._isLoadingSavedWorkSheet)
      this.labelCurtain.SendToBack();
    this.Cursor = Cursors.Default;
  }

  private void ShowExtendedView(bool IsPayable)
  {
    if (this._isRefreshing)
      return;
    if (IsPayable)
    {
      if (((UltraGridBase) this.gridPayables).ActiveRow == null || this.radioPayableChipDownView.Checked)
      {
        this.xViewPayable.Visible = !this.radioPayableChipDownView.Checked;
      }
      else
      {
        this.xViewPayable.Visible = true;
        this.xViewPayable.BringToFront();
        this.xViewPayable.ShowInformation(((UltraGridBase) this.gridPayables).ActiveRow, this._glCompanyId);
      }
    }
    else if (((UltraGridBase) this.gridReceivables).ActiveRow == null || this.radioReceivableChipDownView.Checked)
    {
      this.xViewReceivable.Visible = !this.radioReceivableChipDownView.Checked;
    }
    else
    {
      this.xViewReceivable.Visible = true;
      this.xViewReceivable.BringToFront();
      this.xViewReceivable.ShowInformation(((UltraGridBase) this.gridReceivables).ActiveRow, this._glCompanyId);
    }
  }

  protected void GetEntityUnAccountedBalance()
  {
    TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();
    Task.Factory.StartNew((Action) (() =>
    {
      if (this._entityGuid == Guid.Empty)
        return;
      Decimal unacctAmount = 0M;
      unacctAmount = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetEntityUnAccountedBalance(this._entityGuid, this._glCompanyId);
      if (this.IsDisposed || this.Disposing)
        return;
      Task.Factory.StartNew((Action) (() => ((Control) this.txtUnAccountedBalance).Text = unacctAmount.ToString("c")), CancellationToken.None, TaskCreationOptions.None, scheduler);
    }));
  }

  protected virtual void Clear()
  {
    ((Control) this.txtCheckFrom).Text = string.Empty;
    ((Control) this.txtCheckFrom).Tag = (object) null;
    ((Control) this.txtPostingMemo).Text = string.Empty;
    this._isSummaryPrintingRequired = false;
    this.ResetInterCompanyControlValues();
    this.xViewPayable.Visible = false;
    this.xViewReceivable.Visible = false;
    this._reappliedErrors = (ArrayList) null;
    ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["OPTIONS"]).Tools)["SAVE"].SharedProps.Visible = false;
    ((UltraTabControlBase) this.tabTransactions).Tabs["ADDITIONALOFFSETS"].Visible = false;
    ((Control) this.tabSummary).Hide();
    if (!this._isRefreshing)
    {
      this._mainSearchOption = (SearchCriteria) null;
      this._additionalSearchOptions.Clear();
      this._currentSearchOption = (SearchCriteria) null;
      this._glCompanyId = -1;
      this._searchType = formTransactionSearch.SearchTypes.None;
      ((Control) this.txtEntityName).Text = string.Empty;
    }
    this.NonPayableFees.Clear();
    ((Control) this.gridNonPayableFees).Visible = false;
    this.lblNonPayableFees.Visible = ((Control) this.txtNonPayableFees).Visible = false;
    ((UltraTabControlBase) this.tabTransactions).Tabs["NONPAYABLEFEES"].Visible = false;
    this.PayableGridValues.Clear();
    this.InterCompanyTransfers.Clear();
    this.ReceivableGridValues.Clear();
    this.InterCompanyTransfers.Clear();
    if (this._interCompanyTransfers != null)
      this._interCompanyTransfers.Clear();
    ((UltraGridBase) this.gridAdditionalOffsets).DataSource = (object) null;
    this.chkReturnPremium.Checked = false;
    this.radioCashReceipt.Checked = true;
    this._isClearingScreen = true;
    ((UltraGridBase) this.gridPayables).DataSource = (object) null;
    this.dsOpenPayables.Clear();
    this.PayableDirectBillReconcilliationCollection.Clear();
    ((UltraGridBase) this.gridReceivables).DataSource = (object) null;
    this.dsOpenReceivables.Clear();
    this.ReceivableDirectBillReconcilliationColletion.Clear();
    this.comboBankAccount.SelectedIndex = -1;
    ((Control) this.txtAppliedUnAccounted).Text = string.Empty;
    ((Control) this.txtBalance).Text = string.Empty;
    ((Control) this.txtCheckAmount).Text = string.Empty;
    ((Control) this.txtCheckNumber).Text = string.Empty;
    ((Control) this.txtPayAmount).Text = string.Empty;
    ((Control) this.txtUnAccountedBalance).Text = string.Empty;
    this.ResetPaymentMethodSelection();
    this.radioPayableChipDownView.Visible = false;
    this.radioPayableSummaryView.Enabled = false;
    this.radioPayableDetailView.Enabled = false;
    this.radioPayableSummaryView.Checked = true;
    this.radioReceivableChipDownView.Visible = false;
    this.radioReceivableDetailView.Enabled = false;
    this.radioReceivableSummaryView.Enabled = false;
    this.radioReceivableSummaryView.Checked = true;
    this.dsBankAccounts.Clear();
    this.dsBankAccounts.AcceptChanges();
    this.SetToolBarButtonState(false);
    this.PayableDirectBillReconcilliationCollection.Clear();
    this._payableDirectBillReconciliationCollection = (DirectBillPayablesCollection) null;
    this.ReceivableDirectBillReconcilliationColletion.Clear();
    this._receivableDirectBillReconciliationCollection = (DirectBillReceivableCollection) null;
    this._payableAppliedTotal = this._receivableAppliedTotal = 0.0M;
    this.ReinstatementList.Clear();
    if (this._financedReceivables != null)
      this._financedReceivables.Clear();
    this._isClearingScreen = false;
    ((UltraToggleEditorBase) this.checkCreditCard).Checked = false;
    this._partialPay.Clear();
    this.ReleaseBatchLocks();
    this._hasClaims = false;
  }

  protected virtual void ToolBarClicked(object sender, ToolClickEventArgs e)
  {
    bool flag = true;
    string upper = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.ToUpper();
    if (upper == null)
      return;
    switch (upper.Length)
    {
      case 3:
        if (!(upper == "NEW"))
          break;
        this.LoadNew();
        break;
      case 4:
        switch (upper[0])
        {
          case 'H':
            if (!(upper == "HELP"))
              return;
            Help.ShowHelp((Control) this, "imsaccountinghelp.chm", HelpNavigator.Topic, (object) "TransactionBuilder.htm");
            return;
          case 'L':
            if (!(upper == "LOAD"))
              return;
            this.LoadWorkSheet();
            return;
          case 'P':
            if (!(upper == "POST") || !this.CheckFormViewState() || !this.ValidateForm())
              return;
            this.Post();
            return;
          case 'S':
            if (!(upper == "SAVE"))
              return;
            if (this.IsExcelAutomation)
            {
              this.SaveWorkSheet_Bulk();
              return;
            }
            this.SaveWorkSheet();
            return;
          default:
            return;
        }
      case 5:
        switch (upper[0])
        {
          case 'C':
            if (!(upper == "CLEAR") || MessageBox.Show("This will clear all the information on the screen, any unsaved changes will be lost. Continue?", "Clear Screen?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
              return;
            this.Clear();
            return;
          case 'P':
            if (!(upper == "PRINT"))
              return;
            if (((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Active)
              this.Print_Payable();
            if (!((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Active)
              return;
            this.Print_Receivable();
            return;
          default:
            return;
        }
      case 7:
        switch (upper[0])
        {
          case 'F':
            if (!(upper == "FINANCE"))
              return;
            this.UpdateFinanceCompany(this.gridPayables, false);
            this.xViewPayable.Visible = false;
            return;
          case 'P':
            if (!(upper == "PAYPROP"))
              return;
            this.PayProportionalAmtDue();
            return;
          default:
            return;
        }
      case 8:
        if (!(upper == "WRITEOFF"))
          break;
        this.WriteOffPayable(((UltraGridBase) this.gridPayables).ActiveRow);
        break;
      case 9:
        switch (upper[0])
        {
          case 'C':
            if (!(upper == "CLEAR_REC"))
              return;
            this.Clear();
            return;
          case 'P':
            if (!(upper == "PAYINFULL"))
              return;
            this.PayCurrentInFull(this.gridPayables, flag);
            return;
          default:
            return;
        }
      case 10:
        switch (upper[0])
        {
          case 'P':
            if (!(upper == "PAYALLPROP"))
              return;
            this.PayAllProportionalAmtDue();
            return;
          case 'T':
            if (!(upper == "TOGGLEPAID"))
              return;
            this.TogglePaidReceivable(((StateButtonTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["TOGGLEPAID"]).Checked);
            return;
          case 'V':
            if (!(upper == "VIEWDETAIL"))
              return;
            this.ShowPolicyDetail(this.gridPayables);
            return;
          default:
            return;
        }
      case 11:
        if (!(upper == "FINANCE_REC"))
          break;
        this.UpdateFinanceCompany(this.gridReceivables, true);
        this.xViewReceivable.Visible = false;
        break;
      case 12:
        switch (upper[9])
        {
          case 'A':
            if (!(upper == "INTERCOMPANY"))
              return;
            this.InterCompanyAdditionalOffsets();
            return;
          case 'B':
            return;
          case 'C':
            if (!(upper == "RECSELECTCOL"))
              return;
            ((UltraGridBase) this.gridReceivables).ShowColumnChooser(((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0], false, "Choose Receivables Grid Columns...", false, this.GetDialogRect());
            return;
          case 'D':
            if (!(upper == "SHOWEXTENDED"))
              return;
            this.ShowExtendedView(flag);
            return;
          case 'E':
            if (!(upper == "PAYCOLSELECT"))
              return;
            ((UltraGridBase) this.gridPayables).ShowColumnChooser(((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0], false, "Choose Payables Grid Columns...", false, this.GetDialogRect());
            return;
          case 'F':
            return;
          case 'G':
            return;
          case 'H':
            return;
          case 'I':
            if (!(upper == "CLEARAPPLIED"))
              return;
            this.ClearApplied(this.gridPayables, flag);
            return;
          case 'O':
            if (!(upper == "IMPORTERRORS"))
              return;
            if (this._reappliedErrors != null)
            {
              if (this._reappliedErrors.Count <= 0)
                return;
              this.DisplayReapplyErrors();
              return;
            }
            int num = (int) MessageBox.Show("There are no re-applied errors to display!", "No Re-Applied Errors!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          case 'R':
            if (!(upper == "WRITEOFF_REC"))
              return;
            this.WriteOffReceivable(((UltraGridBase) this.gridReceivables).ActiveRow, formTransactionBuilder.ArApGridColumnKeys.Argl, formTransactionBuilder.ArApGridColumnKeys.NetDue);
            return;
          case 'U':
            if (!(upper == "PAYALLINFULL"))
              return;
            this.PayAllInFull(this.gridPayables, flag);
            return;
          default:
            return;
        }
      case 13:
        if (!(upper == "PAYINFULL_REC"))
          break;
        this.PayCurrentInFull(this.gridReceivables, !flag);
        break;
      case 14:
        switch (upper[6])
        {
          case 'F':
            if (!(upper == "WRITEOFFUA_REC"))
              return;
            this.WriteOffReceivable(((UltraGridBase) this.gridReceivables).ActiveRow, formTransactionBuilder.ArApGridColumnKeys.Uagl, formTransactionBuilder.ArApGridColumnKeys.UnaccountedForBalance);
            return;
          case 'P':
            if (!(upper == "RESETAPLAYOUTS"))
              return;
            MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ResetTransactionBuilderLayouts("AP_DETAILVIEW_v3.lyt", "AP_SUMMARYVIEW_v3.lyt");
            this.LoadPayablesInitialLayout();
            return;
          case 'Q':
            return;
          case 'R':
            if (!(upper == "RESETARLAYOUTS"))
              return;
            MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ResetTransactionBuilderLayouts("AR_DETAILVIEW_v3.lyt", "AR_SUMMARYVIEW_v3.lyt");
            this.LoadReceivablesInitialLayout();
            return;
          case 'S':
            return;
          case 'T':
            if (!(upper == "VIEWDETAIL_REC"))
              return;
            this.ShowPolicyDetail(this.gridReceivables);
            return;
          default:
            return;
        }
      case 15:
        if (!(upper == "CLEARALLAPPLIED"))
          break;
        this.ClearAllApplied(this.gridPayables, flag);
        break;
      case 16 /*0x10*/:
        switch (upper[0])
        {
          case 'C':
            if (!(upper == "CLEARAPPLIED_REC"))
              return;
            this.ClearApplied(this.gridReceivables, !flag);
            return;
          case 'P':
            if (!(upper == "PAYALLINFULL_REC"))
              return;
            this.PayAllInFull(this.gridReceivables, !flag);
            return;
          case 'S':
            if (!(upper == "SHOWEXTENDED_REC"))
              return;
            this.ShowExtendedView(!flag);
            return;
          case 'W':
            if (!(upper == "WRITEOFFEXCH_REC"))
              return;
            this.WriteOffReceivable(((UltraGridBase) this.gridReceivables).ActiveRow, formTransactionBuilder.ArApGridColumnKeys.Exgl, formTransactionBuilder.ArApGridColumnKeys.ExchBalance);
            return;
          default:
            return;
        }
      case 18:
        if (!(upper == "TOGGLECHECKREQUEST"))
          break;
        this.TogglePaidReceivable(((StateButtonTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["TOGGLEPAID"]).Checked);
        break;
      case 19:
        if (!(upper == "CLEARALLAPPLIED_REC"))
          break;
        this.ClearAllApplied(this.gridReceivables, !flag);
        break;
      case 22:
        if (!(upper == "LOADADDITIONALPAYABLES"))
          break;
        this.LoadAdditional(flag, true);
        break;
      case 25:
        if (!(upper == "LOADADDITIONALRECEIVABLES"))
          break;
        this.LoadAdditional(!flag, true);
        break;
    }
  }

  private Rectangle GetDialogRect()
  {
    Rectangle workingArea = Screen.GetWorkingArea((Control) this);
    return new Rectangle(new Point((workingArea.Left + workingArea.Right) / 2, (workingArea.Top + workingArea.Bottom) / 2), new Size(250, 500));
  }

  private void ToggleCheckRequested(bool state)
  {
    if (state)
    {
      foreach (UltraGridBand band in ((UltraGridBase) this.gridPayables).DisplayLayout.Bands)
      {
        band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.CheckRequested].ClearFilterConditions();
        band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.CheckRequested].FilterConditions.Add((FilterComparisionOperator) 3, (object) this.dateTimeToggleCheckRequested.DateTime);
      }
    }
    else
    {
      foreach (UltraGridBand band in ((UltraGridBase) this.gridPayables).DisplayLayout.Bands)
        band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.CheckRequested].ClearFilterConditions();
    }
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridPayables).Rows).Count <= 0)
      return;
    ((UltraGridBase) this.gridPayables).ActiveRowScrollRegion.FirstRow = ((UltraGridBase) this.gridPayables).Rows[0];
  }

  private void TogglePaidReceivable(bool state)
  {
    if (state)
    {
      foreach (UltraGridBand band in ((UltraGridBase) this.gridPayables).DisplayLayout.Bands)
      {
        band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.Amount_Received].ClearFilterConditions();
        band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.Amount_Received].FilterConditions.Add((FilterComparisionOperator) 1, (object) 0);
      }
    }
    else
    {
      foreach (UltraGridBand band in ((UltraGridBase) this.gridPayables).DisplayLayout.Bands)
        band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.Amount_Received].ClearFilterConditions();
    }
  }

  protected virtual bool ValidateForm()
  {
    if (this.comboBankAccount.SelectedIndex == -1 || this.comboBankAccount.Value == null || int.Parse(this.comboBankAccount.Value.ToString()) == -1)
    {
      int num = (int) MessageBox.Show("You must select a bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!string.IsNullOrEmpty(((Control) this.txtAppliedUnAccounted).Text) && Decimal.Parse(((Control) this.txtAppliedUnAccounted).Text, NumberStyles.Any) != 0M && ((UltraDropDownBase) this.comboUnAccountedCostCenter).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an un-accounted cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    return this.radioCashReceipt.Checked ? this.ValidateCashReceipt() : this.ValidateReturnPremium();
  }

  protected virtual bool DoInputValidation()
  {
    if (!this._allowDifferentThanBankCurrency && ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridReceivables).Rows).Count<UltraGridRow>() > 0)
    {
      foreach (UltraGridRow ultraGridRow in ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridReceivables).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (x =>
      {
        if (x.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value != DBNull.Value && x.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value != null || x.Cells[formTransactionBuilder.ArApGridColumnKeys.ExchApplied].Value != DBNull.Value && x.Cells[formTransactionBuilder.ArApGridColumnKeys.ExchApplied].Value != null)
          return true;
        return x.Cells[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied].Value != DBNull.Value && x.Cells[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied].Value != null;
      })))
      {
        if (this.BankCurrency != ultraGridRow.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrencyCode].Value.ToString())
        {
          int num = (int) MessageBox.Show($"The invoice {ultraGridRow.Cells[formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNum].Value} has a different transactional currency than the Bank Currency!", "Invalid Posting!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        }
      }
    }
    if (!this._allowDifferentThanBankCurrencyPayables && ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridPayables).Rows).Count<UltraGridRow>() > 0)
    {
      foreach (UltraGridRow ultraGridRow in ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridPayables).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (x => x.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Value != DBNull.Value && x.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Value != null)))
      {
        if (this.BankCurrency != ultraGridRow.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrencyCode].Value.ToString())
        {
          int num = (int) MessageBox.Show($"The invoice {ultraGridRow.Cells[formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNum].Value} has a different transactional currency than the Bank Currency!", "Invalid Posting!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        }
      }
    }
    return true;
  }

  protected virtual Dictionary<formTransactionBuilder.ValidateCashReceiptRule, System.Func<object, bool>> GetCashReceiptValidationRules()
  {
    return new Dictionary<formTransactionBuilder.ValidateCashReceiptRule, System.Func<object, bool>>()
    {
      {
        formTransactionBuilder.ValidateCashReceiptRule.CheckAmount,
        (System.Func<object, bool>) (amount =>
        {
          if (ChoExtensions.IsNullOrWhiteSpace((string) amount))
          {
            int num = (int) MessageBox.Show("You must enter a check amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
          }
          if (!MGASystems.IMS.Accounting.Core.ClassObjects.Utility.IsDecimalValue(amount))
          {
            int num = (int) MessageBox.Show("Check amount must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
          }
          if (SecurityManager.Instance.AssertPermission("{EBDEB8A0-B1BC-4c82-AA7E-43DD435F0243}") || !(Decimal.Parse((string) amount, NumberStyles.Currency) < 0M))
            return true;
          int num1 = (int) MessageBox.Show("Check amount must be greater than zero.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        })
      },
      {
        formTransactionBuilder.ValidateCashReceiptRule.Balance,
        (System.Func<object, bool>) (balance =>
        {
          if (!(Decimal.Parse((string) balance, NumberStyles.Currency) != 0M))
            return true;
          int num = (int) MessageBox.Show("You must allocate the entire check to continue.", "Check Must Be Fully Allocated!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        })
      },
      {
        formTransactionBuilder.ValidateCashReceiptRule.CheckNumber,
        (System.Func<object, bool>) (checkNumber =>
        {
          if (!ChoExtensions.IsNullOrWhiteSpace((string) checkNumber))
            return true;
          int num = (int) MessageBox.Show("You must enter a check number to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        })
      },
      {
        formTransactionBuilder.ValidateCashReceiptRule.Entity,
        (System.Func<object, bool>) (entity =>
        {
          if (!((Guid) entity == Guid.Empty))
            return true;
          int num = (int) MessageBox.Show("You must select a remitter to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        })
      },
      {
        formTransactionBuilder.ValidateCashReceiptRule.DepositDate,
        (System.Func<object, bool>) (depositDate =>
        {
          if (depositDate != null)
            return true;
          int num = (int) MessageBox.Show("You must supply a date deposited.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        })
      },
      {
        formTransactionBuilder.ValidateCashReceiptRule.ReceivedDate,
        (System.Func<object, bool>) (receivedDate =>
        {
          if (receivedDate == null)
          {
            int num = (int) MessageBox.Show("You must supply a date received.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return false;
          }
          if (!(((DateTime) receivedDate).Date > this.dateTimeDepositDate.DateTime.Date))
            return true;
          int num2 = (int) MessageBox.Show("Date received can not be greater than date deposited.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return false;
        })
      }
    };
  }

  protected bool ValidateCashReceipt()
  {
    Dictionary<formTransactionBuilder.ValidateCashReceiptRule, System.Func<object, bool>> receiptValidationRules = this.GetCashReceiptValidationRules();
    return (!receiptValidationRules.ContainsKey(formTransactionBuilder.ValidateCashReceiptRule.CheckAmount) || receiptValidationRules[formTransactionBuilder.ValidateCashReceiptRule.CheckAmount]((object) ((Control) this.txtCheckAmount).Text)) && (!receiptValidationRules.ContainsKey(formTransactionBuilder.ValidateCashReceiptRule.Balance) || receiptValidationRules[formTransactionBuilder.ValidateCashReceiptRule.Balance]((object) ((Control) this.txtBalance).Text)) && (!receiptValidationRules.ContainsKey(formTransactionBuilder.ValidateCashReceiptRule.CheckNumber) || receiptValidationRules[formTransactionBuilder.ValidateCashReceiptRule.CheckNumber]((object) ((Control) this.txtCheckNumber).Text)) && (!receiptValidationRules.ContainsKey(formTransactionBuilder.ValidateCashReceiptRule.Entity) || receiptValidationRules[formTransactionBuilder.ValidateCashReceiptRule.Entity]((object) this._entityGuid)) && (!receiptValidationRules.ContainsKey(formTransactionBuilder.ValidateCashReceiptRule.DepositDate) || receiptValidationRules[formTransactionBuilder.ValidateCashReceiptRule.DepositDate](this.dateTimeDepositDate.Value)) && (!receiptValidationRules.ContainsKey(formTransactionBuilder.ValidateCashReceiptRule.ReceivedDate) || receiptValidationRules[formTransactionBuilder.ValidateCashReceiptRule.ReceivedDate](this.dateTimeReceivedDate.Value)) && this.DoInputValidation();
  }

  private bool ValidateReturnPremium()
  {
    this.CalculateAndDisplayTotal();
    if (this.PaymentMethodComboNeedsSelection())
    {
      int num = (int) MessageBox.Show("You must select a payment method to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.IsPaymentMethodAchType(this.GetCharTransactionPaymentMethod()) && !this.IsEntityValidForAch(this._entityGuid))
    {
      int num = (int) MessageBox.Show("The entity selected is not set up for ACH.", "Invalid Entity!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (Decimal.Parse(((Control) this.txtPayAmount).Text, NumberStyles.Currency) < 0M && this.GetCharTransactionPaymentMethod() != "O")
    {
      int num = (int) MessageBox.Show("The transaction you are trying to post will result in a negative check.", "Invalid Check Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!(Decimal.Parse(((Control) this.txtPayAmount).Text, NumberStyles.Currency) == 0M) || !(this.GetCharTransactionPaymentMethod() != "O"))
      return this.DoInputValidation();
    int num1 = (int) MessageBox.Show("The transaction you are trying to post will result in a zero check. The system can not post this transaction with the specified payment method. Please select 'Offset' as the payment method to complete this transaction.", "Invalid Payment Method!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected virtual bool IsEntityValidForAch(Guid entityGuid)
  {
    return !MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableMultiACHSettings") ? DefaultDatabase.ExecuteFunction<bool>("dbo.IsEntityValidForAch", new object[2]
    {
      (object) "@EntityGuid",
      (object) entityGuid
    }) : DefaultDatabase.ExecuteFunction<bool>("dbo.IsEntityValidForACH_Multi", new object[4]
    {
      (object) "@EntityGuid",
      (object) entityGuid,
      (object) "@PayMethodID",
      (object) this.GetCharTransactionPaymentMethod()
    });
  }

  private bool IsPaymentMethodAchType(string payMethodID)
  {
    return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "select dbo.IsPaymentMethodAchType(@PayMethodID)", new object[2]
    {
      (object) "@PayMethodID",
      (object) payMethodID
    });
  }

  protected bool IsDifferentCurrencyAllowed()
  {
    return DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "select dbo.IsDifferentCurrencyAllowed()");
  }

  private void ShowPolicyDetail(UltraGrid grid)
  {
    this.Cursor = Cursors.WaitCursor;
    MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ShowPolicyInquiry(int.Parse(((UltraGridBase) grid).ActiveRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ControlNum].Value.ToString()), this._glCompanyId);
    this.Cursor = Cursors.Default;
  }

  private void PayProportionalAmtDue()
  {
    this._isMassiveUpdate = false;
    string empty = string.Empty;
    UltraGridRow activeRow;
    if ((activeRow = ((UltraGridBase) this.gridPayables).ActiveRow) == null)
      return;
    if (activeRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Activation == 2)
    {
      int num = (int) MessageBox.Show("Cannot pay proportional amount due as the row is disabled!", "Cannot pay proportional amount due");
    }
    activeRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Value = Math.Sign(Decimal.Parse(activeRow.Cells[formTransactionBuilder.ArApGridColumnKeys.NetPayable].Value.ToString(), NumberStyles.Any)) == Math.Sign(Decimal.Parse(activeRow.Cells[formTransactionBuilder.ArApGridColumnKeys.PropAmount].Value.ToString(), NumberStyles.Any)) || !(Decimal.Parse(activeRow.Cells[formTransactionBuilder.ArApGridColumnKeys.PropAmount].Value.ToString(), NumberStyles.Any) != 0M) ? activeRow.Cells[formTransactionBuilder.ArApGridColumnKeys.PropAmount].Value : (object) "0.0";
    activeRow.Update();
  }

  private void PayAllProportionalAmtDue()
  {
    this._isMassiveUpdate = true;
    foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridPayables).Rows.GetFilteredInNonGroupByRows())
    {
      if (filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Activation != 2)
      {
        filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Value = Math.Sign(Decimal.Parse(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.NetPayable].Value.ToString(), NumberStyles.Any)) == Math.Sign(Decimal.Parse(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.PropAmount].Value.ToString(), NumberStyles.Any)) || !(Decimal.Parse(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.PropAmount].Value.ToString(), NumberStyles.Any) != 0M) ? filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.PropAmount].Value : (object) "0.0";
        filteredInNonGroupByRow.Update();
      }
    }
    this._isMassiveUpdate = false;
    this.CalculateAndDisplayTotal();
  }

  private void ClearApplied(UltraGrid grid, bool IsPayable)
  {
    this._isMassiveUpdate = false;
    string str = IsPayable ? formTransactionBuilder.ArApGridColumnKeys.ApApplied : formTransactionBuilder.ArApGridColumnKeys.ArApplied;
    UltraGridRow activeRow = ((UltraGridBase) grid).ActiveRow;
    if (((UltraGridBase) grid).ActiveRow == null)
      return;
    if (activeRow.Cells[str].Activation == 2)
    {
      int num = (int) MessageBox.Show("Cannot clear applied as the row is disabled!", "Cannot clear applied");
    }
    else
    {
      activeRow.Cells[str].Value = (object) DBNull.Value;
      activeRow.Update();
    }
  }

  private void ClearAllApplied(UltraGrid grid, bool IsPayable)
  {
    this._isMassiveUpdate = true;
    string str = IsPayable ? formTransactionBuilder.ArApGridColumnKeys.ApApplied : formTransactionBuilder.ArApGridColumnKeys.ArApplied;
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
    {
      try
      {
        this.BeginGridUpdate(grid);
        foreach (DataRow selectedDataRow in this.GetSelectedDataRows(grid, IsPayable, str))
          selectedDataRow[str] = (object) DBNull.Value;
        this.UpdateCells(grid, str, IsPayable);
      }
      finally
      {
        this.EndGridUpdate(grid);
      }
    }
    else
    {
      foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) grid).Rows.GetFilteredInNonGroupByRows())
      {
        if (filteredInNonGroupByRow.Cells[str].Activation != 2)
        {
          filteredInNonGroupByRow.Cells[str].Value = (object) DBNull.Value;
          filteredInNonGroupByRow.Update();
        }
      }
    }
    if (IsPayable && this._isPayableInDirectChipDownView)
    {
      foreach (DataRow row in (InternalDataCollectionBase) this.dsOpenPayables.OpenPayables.Rows)
        row[str] = (object) DBNull.Value;
      this.ClearPayableChipDownValues();
      this._payableAppliedTotal = 0.0M;
    }
    if (!IsPayable && this._isReceivableInDirectChipDownView)
    {
      foreach (DataRow row in (InternalDataCollectionBase) this.dsOpenReceivables.OpenReceivables.Rows)
        row[str] = (object) DBNull.Value;
      this.ClearReceivableChipDownValues();
      this._receivableAppliedTotal = 0.0M;
    }
    this._isMassiveUpdate = false;
    this.CalculateAndDisplayTotal();
  }

  private void PayCurrentInFull(UltraGrid grid, bool IsPayable)
  {
    this._isMassiveUpdate = false;
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string str1;
    string str2;
    if (IsPayable)
    {
      str1 = formTransactionBuilder.ArApGridColumnKeys.NetPayable;
      str2 = formTransactionBuilder.ArApGridColumnKeys.ApApplied;
      grid = this.gridPayables;
    }
    else
    {
      str2 = formTransactionBuilder.ArApGridColumnKeys.ArApplied;
      str1 = formTransactionBuilder.ArApGridColumnKeys.NetDue;
      grid = this.gridReceivables;
    }
    if (((UltraGridBase) grid).ActiveRow == null)
      return;
    UltraGridRow activeRow = ((UltraGridBase) grid).ActiveRow;
    if (activeRow.Cells[str2].Activation == 2)
    {
      int num = (int) MessageBox.Show("Cannot pay in full as the row is disabled!", "Cannot pay in full");
    }
    else
    {
      activeRow.Cells[str2].Value = activeRow.Cells[str1].Value;
      activeRow.Update();
    }
  }

  private void PayAllInFull(UltraGrid grid, bool IsPayable)
  {
    this._isMassiveUpdate = true;
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string str;
    string columnName;
    if (IsPayable)
    {
      str = formTransactionBuilder.ArApGridColumnKeys.ApApplied;
      columnName = formTransactionBuilder.ArApGridColumnKeys.NetPayable;
    }
    else
    {
      str = formTransactionBuilder.ArApGridColumnKeys.ArApplied;
      columnName = formTransactionBuilder.ArApGridColumnKeys.NetDue;
    }
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
    {
      try
      {
        this.BeginGridUpdate(grid);
        foreach (DataRow selectedDataRow in this.GetSelectedDataRows(grid, IsPayable, str))
          selectedDataRow[str] = selectedDataRow[columnName];
      }
      finally
      {
        this.EndGridUpdate(grid);
      }
      this.UpdateCells(grid, str, IsPayable);
    }
    else
    {
      foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) grid).Rows.GetFilteredInNonGroupByRows())
      {
        if (filteredInNonGroupByRow.Cells[str].Activation != 2)
        {
          filteredInNonGroupByRow.Cells[str].Value = filteredInNonGroupByRow.Cells[columnName].Value;
          filteredInNonGroupByRow.Update();
        }
      }
    }
    this._isMassiveUpdate = false;
    this.CalculateAndDisplayTotal();
  }

  private void BeginGridUpdate(UltraGrid grid)
  {
    ((UltraControlBase) grid).BeginUpdate();
    ((UltraGridBase) grid).SuspendRowSynchronization();
    this.Cursor = MgaCursors.WaitCursor;
  }

  private void EndGridUpdate(UltraGrid grid)
  {
    ((UltraGridBase) grid).ResumeRowSynchronization();
    ((UltraControlBase) grid).EndUpdate();
    this.Cursor = MgaCursors.Default;
  }

  private List<DataRow> GetSelectedDataRows(
    UltraGrid grid,
    bool isPayable,
    string checkActivationColumn)
  {
    HashSet<(object, object, object)> selected = ChoLinqEx.ToHashSet<(object, object, object)>((IEnumerable<(object, object, object)>) ((IEnumerable<UltraGridRow>) ((UltraGridBase) grid).Rows.GetFilteredInNonGroupByRows()).AsParallel<UltraGridRow>().Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (r => r.Cells[checkActivationColumn].Activation != 2)).Select<UltraGridRow, (object, object, object)>((System.Func<UltraGridRow, (object, object, object)>) (r => (r.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber), r.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.ChargeCode), r.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid)))));
    return (isPayable ? (DataTable) this.dsOpenPayables.OpenPayables : (DataTable) this.dsOpenReceivables.OpenReceivables).AsEnumerable().Where<DataRow>((System.Func<DataRow, bool>) (r => selected.Contains((r[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber], r[formTransactionBuilder.ArApGridColumnKeys.ChargeCode], r[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid])))).ToList<DataRow>();
  }

  private void UpdateCells(UltraGrid grid, string column, bool isPayable)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) grid).Rows.GetFilteredInNonGroupByRows())
      {
        CellEventArgs e = new CellEventArgs(filteredInNonGroupByRow.Cells[column]);
        if (isPayable)
          this.gridPayables_AfterCellUpdate((object) this, e);
        else
          this.gridReceivables_AfterCellUpdate((object) this, e);
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void gridReceivables_CellDataError(object sender, CellDataErrorEventArgs e)
  {
    ((UltraGrid) sender).ActiveCell.Value = (object) DBNull.Value;
    e.RaiseErrorEvent = false;
    e.StayInEditMode = false;
  }

  private void Grid_AferSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    if (!this.xViewPayable.Visible && !this.xViewReceivable.Visible)
      return;
    this.ShowExtendedView(this._currentPage == formTransactionBuilder.TabPages.Payable);
  }

  protected virtual void gridPayables_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (!((KeyedSubObjectBase) e.Cell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.ApApplied, StringComparison.InvariantCultureIgnoreCase))
      return;
    UltraGridRow row = e.Cell.Row;
    int chargeCode = row.Field<int>(formTransactionBuilder.ArApGridColumnKeys.ChargeCode);
    Guid result1;
    Guid.TryParse(row.Field<string>(formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid), out result1);
    int controlNumber = row.Field<int>(formTransactionBuilder.ArApGridColumnKeys.ControlNum);
    Guid result2;
    Guid.TryParse(row.Field<string>(formTransactionBuilder.ArApGridColumnKeys.PayeeGuid), out result2);
    Decimal num1 = row.Field<Decimal>(formTransactionBuilder.ArApGridColumnKeys.GrossPayable);
    int invoiceNumber = row.Field<int>(formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber);
    Decimal num2 = 0M;
    Decimal result3;
    if (e.Cell.Value == null || e.Cell.Value.Equals((object) DBNull.Value) || !Decimal.TryParse(e.Cell.Value.ToString(), NumberStyles.Currency, (IFormatProvider) CultureInfo.CurrentCulture, out result3))
      result3 = 0M;
    else if (row.Field<Decimal>(formTransactionBuilder.ArApGridColumnKeys.NetPayable) * 100M % 1M == 0M)
    {
      Decimal num3 = Decimal.Round(result3, 2);
      if (num3 != result3)
      {
        e.Cell.Value = (object) num3;
        return;
      }
    }
    if (this._isPayableInDirectBillView)
    {
      if ((Decimal) e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetPayable].Value == result3)
        this.PayableDirectBillReconcilliationCollection.UpdatePolicyApApplied(controlNumber, true);
      else if (result3 == 0.0M)
      {
        this.PayableDirectBillReconcilliationCollection.UpdatePolicyApApplied(controlNumber, false);
      }
      else
      {
        this.PayableDirectBillReconcilliationCollection.UpdatePolicyApApplied(controlNumber, false);
        this.PayableDirectBillReconcilliationCollection.UpdatePolicyApApplied(controlNumber, result3, 0.0M);
      }
    }
    MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValue match;
    if (this.PayableGridValues.TryGetItem(invoiceNumber, chargeCode, result1, controlNumber, result2, new Decimal?(num1), out match))
    {
      num2 = match.ApApplied;
      match.ApApplied = result3;
    }
    else
      this.PayableGridValues.Add(invoiceNumber, chargeCode, result1, result3, controlNumber, result2, new Decimal?(num1));
    this._payableAppliedTotal = result3 > 0M ? this._payableAppliedTotal + result3 : (result3 < 0M ? this._payableAppliedTotal - Math.Abs(result3) : this._payableAppliedTotal);
    this._payableAppliedTotal = num2 > 0M ? this._payableAppliedTotal - num2 : (num2 < 0M ? this._payableAppliedTotal + Math.Abs(num2) : this._payableAppliedTotal);
    if (this._isMassiveUpdate)
      return;
    this.CalculateAndDisplayTotal();
  }

  protected virtual void gridReceivables_AfterCellUpdate(object sender, CellEventArgs e)
  {
    UltraGridRow row = e.Cell.Row;
    if (!((KeyedSubObjectBase) e.Cell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.ArApplied, StringComparison.InvariantCultureIgnoreCase) && !((KeyedSubObjectBase) e.Cell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.ExchApplied, StringComparison.InvariantCultureIgnoreCase) && !((KeyedSubObjectBase) e.Cell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied, StringComparison.InvariantCultureIgnoreCase))
      return;
    Guid companyLineGuid = Guid.Empty;
    Guid empty = Guid.Empty;
    int invoiceNumber = int.Parse(e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value.ToString());
    int chargeCode = int.Parse(e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.ChargeCode].Value.ToString());
    companyLineGuid = new Guid(e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].Value.ToString());
    int controlNumber = int.Parse(e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.ControlNum].Value.ToString());
    Decimal num1 = 0M;
    Decimal result;
    if (e.Cell.Value == null || e.Cell.Value.Equals((object) DBNull.Value) || !Decimal.TryParse(e.Cell.Value.ToString(), NumberStyles.Currency, (IFormatProvider) CultureInfo.CurrentCulture, out result))
      result = 0M;
    else if (row.Field<Decimal>(formTransactionBuilder.ArApGridColumnKeys.NetDue) * 100M % 1M == 0M)
    {
      Decimal num2 = Decimal.Round(result, 2);
      if (num2 != result)
      {
        e.Cell.Value = (object) num2;
        return;
      }
    }
    if (this._isReceivableInDirectBillView)
    {
      switch (((KeyedSubObjectBase) e.Cell.Column).Key.ToLower())
      {
        case "arapplied":
          if (Decimal.Parse(e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetDue].Value.ToString(), NumberStyles.Any) == result)
          {
            this.ReceivableDirectBillReconcilliationColletion.UpdatePolicyArApplied(controlNumber, true);
            break;
          }
          if (result == 0.0M)
          {
            this.ReceivableDirectBillReconcilliationColletion.UpdatePolicyArApplied(controlNumber, false);
            break;
          }
          this.ReceivableDirectBillReconcilliationColletion.UpdatePolicyArApplied(controlNumber, result, 0M);
          break;
        case "exchapplied":
          this.ReceivableDirectBillReconcilliationColletion.UpdatePolicyExApplied(controlNumber, result, 0M);
          break;
        case "unacctapplied":
          this.ReceivableDirectBillReconcilliationColletion.UpdatePolicyUaApplied(controlNumber, result, 0M);
          break;
      }
    }
    MGASystems.IMS.Accounting.AccountsReceivable.AppliedGridValue appliedGridValue = this.ReceivableGridValues.GetItem(invoiceNumber, chargeCode, companyLineGuid, controlNumber);
    switch (((KeyedSubObjectBase) e.Cell.Column).Key.ToUpper())
    {
      case "ARAPPLIED":
        if (this.ReceivableGridValues.ItemExists(invoiceNumber, chargeCode, companyLineGuid, controlNumber))
        {
          num1 = appliedGridValue.ArApplied;
          appliedGridValue.ArApplied = result;
          break;
        }
        this.ReceivableGridValues.Add(e.Cell.Row);
        break;
      case "EXCHAPPLIED":
        if (this.ReceivableGridValues.ItemExists(invoiceNumber, chargeCode, companyLineGuid, controlNumber))
        {
          num1 = appliedGridValue.ExApplied;
          appliedGridValue.ExApplied = result;
          break;
        }
        this.ReceivableGridValues.Add(e.Cell.Row);
        break;
      case "UNACCTAPPLIED":
        if (this.ReceivableGridValues.ItemExists(invoiceNumber, chargeCode, companyLineGuid, controlNumber))
        {
          num1 = appliedGridValue.UaApplied;
          appliedGridValue.UaApplied = result;
          break;
        }
        this.ReceivableGridValues.Add(e.Cell.Row);
        break;
    }
    this._receivableAppliedTotal = result > 0M ? this._receivableAppliedTotal - result : (result < 0M ? this._receivableAppliedTotal + Math.Abs(result) : this._receivableAppliedTotal);
    this._receivableAppliedTotal = num1 > 0M ? this._receivableAppliedTotal + num1 : (num1 < 0M ? this._receivableAppliedTotal - Math.Abs(num1) : this._receivableAppliedTotal);
    if (this._isMassiveUpdate)
      return;
    this.CalculateAndDisplayTotal();
  }

  protected void gridReceivables_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    Decimal result1;
    Decimal result2;
    if (e.NewValue.Equals((object) DBNull.Value) || e.Cell.Text.Equals(string.Empty) || !(((KeyedSubObjectBase) e.Cell.Column).Key.ToLower() == "arapplied") || !Decimal.TryParse(e.NewValue.ToString(), NumberStyles.Any, (IFormatProvider) CultureInfo.CurrentCulture, out result1) || !Decimal.TryParse(e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetDue].Value.ToString(), NumberStyles.Any, (IFormatProvider) CultureInfo.CurrentCulture, out result2))
      return;
    if (result2 != 0M)
    {
      if (!SecurityManager.Instance.AssertPermission("{EBDEB8A0-B1BC-4c82-AA7E-43DD435F0243}") && Math.Sign(result2) != Math.Sign(result1) && result1 != 0M)
      {
        if (result2 < 0M)
        {
          int num1 = (int) MessageBox.Show("Only negative values can be applied to this item!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          int num2 = (int) MessageBox.Show("Amount positive values can be applied to this item!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        ((CancelEventArgs) e).Cancel = true;
      }
      else
      {
        if (SecurityManager.Instance.AssertPermission("{BA74605C-2DAA-462A-B167-D38E29BF9E61}") || !(Math.Abs(result1) > Math.Abs(result2)))
          return;
        int num = (int) MessageBox.Show("Amount applied can not exceed the net receivable!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((CancelEventArgs) e).Cancel = true;
        this.gridPayables.PerformAction((UltraGridAction) 21);
      }
    }
    else
    {
      if (SecurityManager.Instance.AssertPermission("{B0032CCA-AE39-4fcc-A6E8-51811B8F7EF7}"))
        return;
      int num = (int) MessageBox.Show("You do not have rights to override a zero receivable posting. The net amount due on this receivable is zero. No AR can be applied to this record!", "Invalid Posting!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
    }
  }

  private void gridPayables_BeforeCellUpdate(object sender, BeforeCellUpdateEventArgs e)
  {
    Decimal result1;
    Decimal result2;
    if (e.NewValue.Equals((object) DBNull.Value) || e.Cell.Text == string.Empty || !(((KeyedSubObjectBase) e.Cell.Column).Key.ToLower() == "apapplied") || !Decimal.TryParse(e.NewValue.ToString(), NumberStyles.Any, (IFormatProvider) CultureInfo.CurrentCulture, out result1) || !Decimal.TryParse(e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetPayable].Value.ToString(), NumberStyles.Any, (IFormatProvider) CultureInfo.CurrentCulture, out result2) || !(result2 != 0M))
      return;
    if (Math.Sign(result2) != Math.Sign(result1) && result1 != 0M)
    {
      if (result2 < 0M)
      {
        int num1 = (int) MessageBox.Show("Only negative values can be applied to this item!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        int num2 = (int) MessageBox.Show("Amount positive values can be applied to this item!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (this.ValidatePayableAmountApplied(Math.Abs(result1), Math.Abs(result2)))
        return;
      int num = (int) MessageBox.Show("Amount applied can not exceed the net payable!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ((CancelEventArgs) e).Cancel = true;
      this.gridPayables.PerformAction((UltraGridAction) 21);
    }
  }

  protected virtual bool ValidatePayableAmountApplied(Decimal amtApplied, Decimal netPayable)
  {
    return netPayable >= amtApplied;
  }

  protected void ImplementMultiCurrencyDisplay(InitializeRowEventArgs e)
  {
    if (!MultiCurrencyUtilities.IsMultiCurrencyActive() || e.ReInitialize && this.radioPayableChipDownView.Checked)
      return;
    CultureInfo cultureInfo = MultiCurrencyUtilities.GetCultureInfo(e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrencyCode].Value.ToString());
    EditorWithText editorWithText = new EditorWithText((EmbeddableEditorOwnerBase) new DefaultEditorOwner(new DefaultEditorOwnerSettings()
    {
      FormatProvider = (IFormatProvider) cultureInfo
    }));
    foreach (UltraGridCell cell in e.Row.Cells)
    {
      if (cell.Column.DataType == typeof (Decimal))
      {
        cell.Column.Format = "c";
        cell.Editor = (EmbeddableEditorBase) editorWithText;
      }
    }
  }

  protected virtual void gridPayables_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
    {
      if (Decimal.Parse(e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.NetPayable).ToString(), NumberStyles.Currency) < 0M)
        e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetPayable].Appearance = this._redAppearance;
      if (Decimal.Parse(e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.GrossPayable).ToString(), NumberStyles.Currency) < 0M)
        e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.GrossPayable].Appearance = this._redAppearance;
      if (!(Decimal.Parse(e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.PropAmount).ToString(), NumberStyles.Currency) < 0M))
        return;
      e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.PropAmount].Appearance = this._redAppearance;
    }
    else
    {
      if (Decimal.Parse(e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetPayable].Value.ToString(), NumberStyles.Currency) < 0M)
        ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetPayable].Appearance).ForeColor = Color.Red;
      if (Decimal.Parse(e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.GrossPayable].Value.ToString(), NumberStyles.Currency) < 0M)
        ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.GrossPayable].Appearance).ForeColor = Color.Red;
      if (!(Decimal.Parse(e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.PropAmount].Value.ToString(), NumberStyles.Currency) < 0M))
        return;
      ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.PropAmount].Appearance).ForeColor = Color.Red;
    }
  }

  private void gridPayable_KeyDown(object sender, KeyEventArgs e)
  {
    if (((UltraGridBase) this.gridPayables).ActiveRow == null || this.gridPayables.ActiveCell == null || ((KeyedSubObjectBase) this.gridPayables.ActiveCell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.ApApplied, StringComparison.InvariantCultureIgnoreCase))
      return;
    if (e.KeyValue == 46 && ((KeyedSubObjectBase) this.gridPayables.ActiveCell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.ApApplied, StringComparison.InvariantCultureIgnoreCase))
      this.gridPayables.ActiveCell.Value = (object) DBNull.Value;
    if (e.KeyValue == 38)
    {
      this.validateDollarSignForgridPayables();
      this.gridPayables.PerformAction((UltraGridAction) 44, false, false);
      this.gridPayables.PerformAction((UltraGridAction) 19, false, false);
      e.Handled = true;
      this.gridPayables.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 40)
    {
      this.validateDollarSignForgridPayables();
      this.gridPayables.PerformAction((UltraGridAction) 44, false, false);
      this.gridPayables.PerformAction((UltraGridAction) 20, false, false);
      e.Handled = true;
      this.gridPayables.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 39)
    {
      this.validateDollarSignForgridPayables();
      this.gridPayables.PerformAction((UltraGridAction) 44, false, false);
      this.gridPayables.PerformAction((UltraGridAction) 42, false, false);
      e.Handled = true;
      this.gridPayables.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 37)
    {
      this.validateDollarSignForgridPayables();
      this.gridPayables.PerformAction((UltraGridAction) 44, false, false);
      this.gridPayables.PerformAction((UltraGridAction) 43, false, false);
      e.Handled = true;
      this.gridPayables.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 13)
      this.validateDollarSignForgridPayables();
    if (e.KeyValue != 9)
      return;
    this.validateDollarSignForgridPayables();
  }

  private void validateDollarSignForgridPayables()
  {
    if (this.gridPayables.ActiveCell == null || !MGASystems.IMS.Accounting.Core.ClassObjects.Utility.IsDecimalValue((object) this.gridPayables.ActiveCell.Text))
      return;
    this.gridPayables.ActiveCell.Value = (object) Decimal.Parse(this.gridPayables.ActiveCell.Text, NumberStyles.Any);
    this.gridPayables.ActiveCell.Row.Update();
  }

  private void gridPayables_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.SelectedRowAppearance.ForeColor = Color.Black;
  }

  protected virtual void gridReceivables_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
    {
      if (e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.CurrentStatus).ToString() == "Cancelled")
        e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrentStatus].Appearance = this._redAppearance;
      if (e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.CurrentStatus).ToString() == "Notice of Cancellation")
        e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrentStatus].Appearance = this._darkOrangeAppearance;
      if (Decimal.Parse(e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.NetDue).ToString(), NumberStyles.Currency) < 0M)
        e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetDue].Appearance = this._redAppearance;
      if (Decimal.Parse(e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.AmountBilled).ToString(), NumberStyles.Currency) < 0M)
        e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.AmountBilled].Appearance = this._redAppearance;
      if (Decimal.Parse(e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.AmountPtc).ToString(), NumberStyles.Currency) < 0M)
        e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.AmountPtc].Appearance = this._redAppearance;
      if (Decimal.Parse(e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.UnaccountedForBalance).ToString(), NumberStyles.Currency) < 0M)
        e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForBalance].Appearance = this._redAppearance;
      if (Decimal.Parse(e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.ExchBalance).ToString(), NumberStyles.Currency) < 0M)
        e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.ExchBalance].Appearance = this._redAppearance;
      if (!(Decimal.Parse(e.Row.GetCellValue(formTransactionBuilder.ArApGridColumnKeys.AmountReturned).ToString(), NumberStyles.Currency) < 0M))
        return;
      e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.AmountReturned].Appearance = this._redAppearance;
    }
    else
    {
      if (e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrentStatus].Value.ToString() == "Cancelled")
        ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrentStatus].Appearance).ForeColor = Color.Red;
      if (e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrentStatus].Value.ToString() == "Notice of Cancellation")
        ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrentStatus].Appearance).ForeColor = Color.DarkOrange;
      if (Decimal.Parse(e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetDue].Value.ToString()) < 0M)
        ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetDue].Appearance).ForeColor = Color.Red;
      if (Decimal.Parse(e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.AmountBilled].Value.ToString()) < 0M)
        ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.AmountBilled].Appearance).ForeColor = Color.Red;
      if (Decimal.Parse(e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.AmountPtc].Value.ToString()) < 0M)
        ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.AmountPtc].Appearance).ForeColor = Color.Red;
      if (Decimal.Parse(e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForBalance].Value.ToString()) < 0M)
        ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForBalance].Appearance).ForeColor = Color.Red;
      if (Decimal.Parse(e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.ExchBalance].Value.ToString()) < 0M)
        ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.ExchBalance].Appearance).ForeColor = Color.Red;
      if (!(Decimal.Parse(e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.AmountReturned].Value.ToString()) < 0M))
        return;
      ((AppearanceBase) e.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.AmountReturned].Appearance).ForeColor = Color.Red;
    }
  }

  private void gridPayables_CellDataError(object sender, CellDataErrorEventArgs e)
  {
    ((UltraGrid) sender).ActiveCell.Value = (object) DBNull.Value;
    e.RaiseErrorEvent = false;
    e.StayInEditMode = false;
  }

  private void gridReceivables_KeyDown(object sender, KeyEventArgs e)
  {
    if (((UltraGridBase) this.gridReceivables).ActiveRow == null || this.gridReceivables.ActiveCell == null || !((KeyedSubObjectBase) this.gridReceivables.ActiveCell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.ArApplied, StringComparison.InvariantCultureIgnoreCase) && !((KeyedSubObjectBase) this.gridReceivables.ActiveCell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.ExchApplied, StringComparison.InvariantCultureIgnoreCase) && !((KeyedSubObjectBase) this.gridReceivables.ActiveCell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied, StringComparison.InvariantCultureIgnoreCase))
      return;
    if (e.KeyValue == 46 && (((KeyedSubObjectBase) this.gridReceivables.ActiveCell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.ArApplied, StringComparison.InvariantCultureIgnoreCase) || ((KeyedSubObjectBase) this.gridReceivables.ActiveCell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.ExchApplied, StringComparison.InvariantCultureIgnoreCase) || ((KeyedSubObjectBase) this.gridReceivables.ActiveCell.Column).Key.Equals(formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied, StringComparison.InvariantCultureIgnoreCase)))
      this.gridReceivables.ActiveCell.Value = (object) DBNull.Value;
    if (e.KeyValue == 38)
    {
      this.validateDollarSignForgridReceivables();
      this.gridReceivables.PerformAction((UltraGridAction) 44, false, false);
      this.gridReceivables.PerformAction((UltraGridAction) 19, false, false);
      e.Handled = true;
      this.gridReceivables.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 40)
    {
      this.validateDollarSignForgridReceivables();
      this.gridReceivables.PerformAction((UltraGridAction) 44, false, false);
      this.gridReceivables.PerformAction((UltraGridAction) 20, false, false);
      e.Handled = true;
      this.gridReceivables.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 39)
    {
      this.validateDollarSignForgridReceivables();
      this.gridReceivables.PerformAction((UltraGridAction) 44, false, false);
      this.gridReceivables.PerformAction((UltraGridAction) 42, false, false);
      e.Handled = true;
      this.gridReceivables.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 37)
    {
      this.validateDollarSignForgridReceivables();
      this.gridReceivables.PerformAction((UltraGridAction) 44, false, false);
      this.gridReceivables.PerformAction((UltraGridAction) 43, false, false);
      e.Handled = true;
      this.gridReceivables.PerformAction((UltraGridAction) 24, false, false);
    }
    else if (e.KeyValue == 13)
      this.validateDollarSignForgridReceivables();
    if (e.KeyValue != 9 || this.gridReceivables.ActiveCell == null)
      return;
    this.validateDollarSignForgridReceivables();
  }

  private void validateDollarSignForgridReceivables()
  {
    if (!MGASystems.IMS.Accounting.Core.ClassObjects.Utility.IsDecimalValue((object) this.gridReceivables.ActiveCell.Text))
      return;
    string text = this.gridReceivables.ActiveCell.Text;
    this.gridReceivables.ActiveCell.Value = (object) Decimal.Parse(this.gridReceivables.ActiveCell.Text, NumberStyles.Any);
    this.gridReceivables.ActiveCell.Row.Update();
  }

  private void GeneratePayableGridSummaryRow()
  {
    ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries.Clear();
    ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries.Add("GrossPayable", (SummaryType) 1, ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.GrossPayable], (SummaryPosition) 3);
    ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries.Add("NetPayable", (SummaryType) 1, ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.NetPayable], (SummaryPosition) 3);
    ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries.Add("APAppliedSum", (SummaryType) 1, ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.ApApplied], (SummaryPosition) 3);
    ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries.Add("PropoertionalSum", (SummaryType) 1, ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.PropAmount], (SummaryPosition) 3);
    if (!this.radioPayableSummaryView.Checked)
    {
      ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries.Add("AmtPTDSum", (SummaryType) 1, ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.AmountPtd], (SummaryPosition) 3);
      ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries.Add("AmtRCVDSum", (SummaryType) 1, ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.Amount_Received], (SummaryPosition) 3);
    }
    ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Override.SummaryFooterAppearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries)
    {
      summary.DisplayFormat = "{0:c}";
      summary.Appearance.TextHAlign = (HAlign) 3;
      summary.Appearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    }
  }

  private void GenerateReceivableGridSummaryRow()
  {
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries.Clear();
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries.Add("GrossBilled", (SummaryType) 1, ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.AmountBilled], (SummaryPosition) 3);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries.Add("NetReceivable", (SummaryType) 1, ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.NetDue], (SummaryPosition) 3);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries.Add("ARAppliedSum", (SummaryType) 1, ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.ArApplied], (SummaryPosition) 3);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries.Add("ExchAppliedSum", (SummaryType) 1, ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.ExchApplied], (SummaryPosition) 3);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries.Add("UnAcctAppliedSum", (SummaryType) 1, ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied], (SummaryPosition) 3);
    if (!this.radioReceivableSummaryView.Checked)
    {
      ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries.Add("AmtPTCSum", (SummaryType) 1, ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.AmountPtc], (SummaryPosition) 3);
      ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries.Add("AmtRTDSum", (SummaryType) 1, ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.AmountReturned], (SummaryPosition) 3);
      ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries.Add("ExchBalanceSum", (SummaryType) 1, ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.ExchBalance], (SummaryPosition) 3);
      ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries.Add("UnacctBalanceSum", (SummaryType) 1, ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForBalance], (SummaryPosition) 3);
    }
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Override.SummaryFooterAppearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Summaries)
    {
      summary.DisplayFormat = "{0:c}";
      summary.Appearance.TextHAlign = (HAlign) 3;
      summary.Appearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    }
  }

  private void tabTransactions_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    if (((UltraTabControlBase) this.tabTransactions).SelectedTab == null)
      return;
    if (((KeyedSubObjectBase) ((UltraTabControlBase) this.tabTransactions).SelectedTab).Key.ToUpper() == "PAYABLE")
    {
      this._currentPage = formTransactionBuilder.TabPages.Payable;
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["TOGGLEPAID"].SharedProps.Enabled = true;
    }
    else
    {
      if (!(((KeyedSubObjectBase) ((UltraTabControlBase) this.tabTransactions).SelectedTab).Key.ToUpper() == "RECEIVABLE"))
        return;
      this._currentPage = formTransactionBuilder.TabPages.Receivable;
      ((ToolsCollectionBase) ((UltraToolbarBase) this.toolbar.Toolbars[0]).Tools)["TOGGLEPAID"].SharedProps.Enabled = false;
    }
  }

  private bool AllowReallocation()
  {
    return MessageBox.Show("Switching the current view to the chip down view will result in the allocated amounts being re-allocated and disbursed by invoice number. Do you wish to continue?", "Re-Allocate Postings?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
  }

  private void LoadReceivablesInitialLayout()
  {
    string builderLayoutFilePath = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetTransactionBuilderLayoutFilePath("AR_SUMMARYVIEW_v3.lyt");
    if (!string.IsNullOrEmpty(builderLayoutFilePath))
      ((UltraGridBase) this.gridReceivables).DisplayLayout.Load(builderLayoutFilePath, (PropertyCategories) -1);
    else
      ((UltraGridBase) this.gridReceivables).DisplayLayout.Load(((UltraGridBase) this.gridReceivables).Layouts["SummaryView"], (PropertyCategories) -1);
  }

  private void PayableGridViewOptionsChangedHandler(object sender, EventArgs e)
  {
    bool flag = false;
    if (this._isClearingScreen || !((RadioButton) sender).Checked)
      return;
    string empty = string.Empty;
    try
    {
      this.Cursor = Cursors.WaitCursor;
      switch (((Control) sender).Name)
      {
        case "radioPayableSummaryView":
          string builderLayoutFilePath1 = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetTransactionBuilderLayoutFilePath("AP_SUMMARYVIEW_v3.lyt");
          if (!string.IsNullOrEmpty(builderLayoutFilePath1))
          {
            ((UltraGridBase) this.gridPayables).DisplayLayout.Load(builderLayoutFilePath1, (PropertyCategories) -1);
            break;
          }
          ((UltraGridBase) this.gridPayables).DisplayLayout.Load(((UltraGridBase) this.gridPayables).Layouts["SummaryView"], (PropertyCategories) -1);
          break;
        case "radioPayableDetailView":
          string builderLayoutFilePath2 = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetTransactionBuilderLayoutFilePath("AP_DETAILVIEW_v3.lyt");
          if (!string.IsNullOrEmpty(builderLayoutFilePath2))
          {
            ((UltraGridBase) this.gridPayables).DisplayLayout.Load(builderLayoutFilePath2, (PropertyCategories) -1);
            break;
          }
          ((UltraGridBase) this.gridPayables).DisplayLayout.Load(((UltraGridBase) this.gridPayables).Layouts["DetailView"], (PropertyCategories) -1);
          break;
        case "radioPayableChipDownView":
          if (!this.AllowReallocation())
          {
            if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Groups).Count == 0)
            {
              this.radioPayableSummaryView.Checked = true;
              return;
            }
            this.radioPayableDetailView.Checked = true;
            return;
          }
          flag = true;
          this._payableAppliedTotal = 0.0M;
          this.xViewPayable.Visible = false;
          ((UltraGridBase) this.gridPayables).DisplayLayout.Load(((UltraGridBase) this.gridPayables).Layouts["ChipDownView"], (PropertyCategories) -1);
          ((UltraGridBase) this.gridPayables).DataSource = (object) this.PayableDirectBillReconcilliationCollection.GeneratePayableDataSet();
          this.SetPayableChipDownApplied();
          this._isPayableInDirectBillView = true;
          this._isPayableInDirectChipDownView = this.radioPayableChipDownView.Checked;
          ((UltraGridBase) this.gridPayables).Rows.Refresh((RefreshRow) 1, true);
          break;
      }
      this.GeneratePayableGridSummaryRow();
      if (flag)
        return;
      ((UltraGridBase) this.gridPayables).DataSource = (object) this.dsOpenPayables;
      if (!this._isPayableInDirectBillView)
        return;
      this._isPayableInDirectBillView = false;
      this.ReApplyPayableChipDownValues();
      this.ResetPayableGridValuesCollection();
      this.CalculateAndDisplayTotal();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  protected virtual void ReceivableGridViewOptionsChangedHandler(object sender, EventArgs e)
  {
    if (this._isClearingScreen || !((RadioButton) sender).Checked)
      return;
    bool flag = false;
    string empty = string.Empty;
    try
    {
      this.Cursor = Cursors.WaitCursor;
      switch (((Control) sender).Name)
      {
        case "radioReceivableSummaryView":
          string builderLayoutFilePath1 = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetTransactionBuilderLayoutFilePath("AR_SUMMARYVIEW_v3.lyt");
          if (!string.IsNullOrEmpty(builderLayoutFilePath1))
          {
            ((UltraGridBase) this.gridReceivables).DisplayLayout.Load(builderLayoutFilePath1, (PropertyCategories) -1);
            break;
          }
          ((UltraGridBase) this.gridReceivables).DisplayLayout.Load(((UltraGridBase) this.gridReceivables).Layouts["SummaryView"], (PropertyCategories) -1);
          break;
        case "radioReceivableDetailView":
          string builderLayoutFilePath2 = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetTransactionBuilderLayoutFilePath("AR_DETAILVIEW_v3.lyt");
          if (!string.IsNullOrEmpty(builderLayoutFilePath2))
          {
            ((UltraGridBase) this.gridReceivables).DisplayLayout.Load(builderLayoutFilePath2, (PropertyCategories) -1);
            break;
          }
          ((UltraGridBase) this.gridReceivables).DisplayLayout.Load(((UltraGridBase) this.gridReceivables).Layouts["DetailView"], (PropertyCategories) -1);
          break;
        case "radioReceivableChipDownView":
          if (this.AllowReallocation() && this.ReceivableDirectBillReconcilliationColletion.Count > 0)
          {
            flag = true;
            this._receivableAppliedTotal = 0.0M;
            this.xViewReceivable.Visible = false;
            ((UltraGridBase) this.gridReceivables).DisplayLayout.Load(((UltraGridBase) this.gridReceivables).Layouts["ChipDownView"], (PropertyCategories) -1);
            ((UltraGridBase) this.gridReceivables).DataSource = (object) this.ReceivableDirectBillReconcilliationColletion.GenerateReceivableDataset();
            this.SetReceivableChipDownApplied();
            this._isReceivableInDirectChipDownView = this.radioReceivableChipDownView.Checked;
            this._isReceivableInDirectBillView = true;
            break;
          }
          if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0].Groups).Count == 0)
          {
            this.radioReceivableSummaryView.Checked = true;
            return;
          }
          this.radioReceivableDetailView.Checked = true;
          return;
      }
      this.GenerateReceivableGridSummaryRow();
      if (flag)
        return;
      if (this._isReceivableInDirectBillView)
      {
        this._isReceivableInDirectBillView = false;
        this.ReApplyReceivableChipDownValues();
        this.ResetReceivablesGridValuesCollection();
        this.CalculateAndDisplayTotal();
      }
      else
        ((UltraGridBase) this.gridReceivables).DataSource = (object) this.dsOpenReceivables;
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void ResetPayableGridValuesCollection()
  {
    this._payableAppliedTotal = 0.0M;
    this.PayableGridValues.Clear();
    foreach (UltraGridRow row in ((UltraGridBase) this.gridPayables).Rows)
    {
      if (((DisposableObjectCollectionBase) row.Cells).Count != 0 && row.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Value != null && row.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Value != DBNull.Value)
      {
        Decimal num = Decimal.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Value.ToString(), NumberStyles.Any);
        this.PayableGridValues.Add(row);
        this._payableAppliedTotal = num > 0M ? this._payableAppliedTotal + num : (num < 0M ? this._payableAppliedTotal - Math.Abs(num) : this._payableAppliedTotal);
      }
    }
  }

  protected virtual void ResetReceivablesGridValuesCollection()
  {
    this._receivableAppliedTotal = 0.0M;
    this.ReceivableGridValues.Clear();
    foreach (UltraGridRow row in ((UltraGridBase) this.gridReceivables).Rows)
    {
      if (((DisposableObjectCollectionBase) row.Cells).Count != 0 && row.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value != null && row.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value != DBNull.Value)
      {
        Decimal num = Decimal.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value.ToString(), NumberStyles.Any);
        this._receivableAppliedTotal = num > 0M ? this._receivableAppliedTotal - num : (num < 0M ? this._receivableAppliedTotal + Math.Abs(num) : this._receivableAppliedTotal);
        this.ReceivableGridValues.Add(row);
      }
    }
  }

  private void ClearPayableChipDownValues()
  {
    foreach (DirectBillPayable billReconcilliation in (CollectionBase) this.PayableDirectBillReconcilliationCollection)
    {
      foreach (DirectBillPayableDetail detail in (CollectionBase) billReconcilliation.Details)
        detail.ApApplied = 0M;
    }
  }

  private void ReApplyPayableChipDownValues()
  {
    foreach (DirectBillPayable billReconcilliation in (CollectionBase) this.PayableDirectBillReconcilliationCollection)
    {
      foreach (DirectBillPayableDetail detail in (CollectionBase) billReconcilliation.Details)
      {
        foreach (UltraGridRow row in ((UltraGridBase) this.gridPayables).Rows)
        {
          if (int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value.ToString()) == detail.InvoiceNumber && int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ChargeCode].Value.ToString()) == detail.ChargeCode && new Guid(row.Cells[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].Value.ToString()).Equals(detail.CompanyLineGuid))
          {
            row.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Value = !(detail.ApApplied != 0M) ? (object) DBNull.Value : (object) detail.ApApplied;
            break;
          }
        }
      }
    }
  }

  protected virtual void ReApplyReceivableChipDownValues()
  {
    ((UltraGridBase) this.gridReceivables).DataSource = (object) this.dsOpenReceivables;
    foreach (DirectBillReceivable directBillReceivable in (CollectionBase) this.ReceivableDirectBillReconcilliationColletion)
    {
      if (directBillReceivable.Details.Count != 0)
      {
        foreach (DirectBillReceivableDetail detail in (CollectionBase) directBillReceivable.Details)
        {
          foreach (UltraGridRow row in ((UltraGridBase) this.gridReceivables).Rows)
          {
            if (int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value.ToString()) == detail.InvoiceNumber && int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ChargeCode].Value.ToString()) == detail.ChargeCode && new Guid(row.Cells[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].Value.ToString()).Equals(detail.CompanyLineGuid))
            {
              row.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value = !(detail.ArApplied != 0M) ? (object) DBNull.Value : (object) detail.ArApplied;
              row.Cells[formTransactionBuilder.ArApGridColumnKeys.ExchApplied].Value = !(detail.ExchApplied != 0M) ? (object) DBNull.Value : (object) detail.ExchApplied;
              row.Cells[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied].Value = !(detail.UnAcctApplied != 0M) ? (object) DBNull.Value : (object) detail.UnAcctApplied;
              break;
            }
          }
        }
      }
    }
  }

  private void ClearReceivableChipDownValues()
  {
    foreach (DirectBillReceivable directBillReceivable in (CollectionBase) this.ReceivableDirectBillReconcilliationColletion)
    {
      foreach (DirectBillReceivableDetail detail in (CollectionBase) directBillReceivable.Details)
        detail.ArApplied = 0M;
    }
  }

  private void SetPayableChipDownApplied()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridPayables).Rows)
    {
      if (this.PayableGridValues.GetApAppliedSum(int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ControlNum].Value.ToString())) != 0M)
        row.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied].Value = (object) this.PayableGridValues.GetApAppliedSum(int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ControlNum].Value.ToString()));
    }
  }

  protected virtual void SetReceivableChipDownApplied()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridReceivables).Rows)
    {
      if (this.ReceivableGridValues.GetArAppliedSum(int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ControlNum].Value.ToString())) != 0M)
        row.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value = (object) this.ReceivableGridValues.GetArAppliedSum(int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ControlNum].Value.ToString()));
    }
  }

  private void CreateDirectBillReceivableView()
  {
    if (this._isLoadingSavedWorkSheet)
      return;
    this._dsChipDownReceivables = new dsOpenReceivables();
    this._dsChipDownReceivables = (dsOpenReceivables) this.dsOpenReceivables.Copy();
    this.progressBarReceivableChipDown.Value = 0;
    this.progressBarReceivableChipDown.Maximum = this._dsChipDownReceivables.OpenReceivables.Rows.Count;
    this.pnlReceivableChipDownView.Visible = true;
    this.pnlReceivableChipDownView.BringToFront();
    this.radioReceivableChipDownView.Enabled = false;
    TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();
    Task.Factory.StartNew((Action) (() => this.DoCreateReceivableDirectBillView(scheduler)));
  }

  internal void CreateDirectBillPayableView()
  {
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("BYPASS_INSTALLMENT_VIEW") || this._isLoadingSavedWorkSheet)
      return;
    this._dsChipDownPayables = new dsOpenPayables();
    this._dsChipDownPayables = (dsOpenPayables) this.dsOpenPayables.Copy();
    this.progressBarPayablesChipDown.Value = 0;
    this.progressBarPayablesChipDown.Maximum = this._dsChipDownPayables.OpenPayables.Rows.Count;
    this.pnlPayableChipDownView.Visible = true;
    this.pnlPayableChipDownView.BringToFront();
    this.radioPayableChipDownView.Enabled = false;
    TaskScheduler scheduler = TaskScheduler.FromCurrentSynchronizationContext();
    Task.Factory.StartNew((Action) (() => this.DoCreatePayableDirectBillView(scheduler)));
  }

  private void DoCreateReceivableDirectBillView(TaskScheduler scheduler)
  {
    lock (this.ReceivableDirectBillReconcilliationColletion)
    {
      foreach (dsOpenReceivables.OpenReceivablesRow row in (InternalDataCollectionBase) this._dsChipDownReceivables.OpenReceivables.Rows)
      {
        if (!this.ReceivableDirectBillReconcilliationColletion.ControlNumberExists(row.QuoteControlNum))
        {
          this.ReceivableDirectBillReconcilliationColletion.Add(new DirectBillReceivable(row.PolicyNumber, row.InsuredPolicyName, row.QuoteControlNum, row.CurrentStatus, row.EffectiveDate, row.ExpirationDate, row.Table.Select("QuoteControlNum = " + row.QuoteControlNum.ToString(), "InvoiceNum asc")));
          if (!this.IsDisposed && !this.Disposing)
            Task.Factory.StartNew(new Action(this.ShowChipDownProgress), CancellationToken.None, TaskCreationOptions.None, scheduler);
        }
      }
      if (this.IsDisposed || this.Disposing)
        return;
      Task.Factory.StartNew(new Action(this.CreateDirectBillReceivablesViewCompleted), CancellationToken.None, TaskCreationOptions.None, scheduler);
    }
  }

  private void ShowChipDownProgress()
  {
    if (this.IsDisposed || this.Disposing)
      return;
    UltraProgressBar ultraProgressBar = (UltraProgressBar) null;
    if (this._currentPage == formTransactionBuilder.TabPages.Payable)
      ultraProgressBar = this.progressBarPayablesChipDown;
    else if (this._currentPage == formTransactionBuilder.TabPages.Receivable)
      ultraProgressBar = this.progressBarReceivableChipDown;
    if (ultraProgressBar.Value + 1 > ultraProgressBar.Maximum)
      return;
    ++ultraProgressBar.Value;
    ((Control) ultraProgressBar).Refresh();
  }

  private void DoCreatePayableDirectBillView(TaskScheduler scheduler)
  {
    this.PayableDirectBillReconcilliationCollection.Clear();
    foreach (dsOpenPayables.OpenPayablesRow row in (InternalDataCollectionBase) this._dsChipDownPayables.OpenPayables.Rows)
    {
      if (!this.PayableDirectBillReconcilliationCollection.ControlNumberExists(row.QuoteControlNum))
      {
        this.PayableDirectBillReconcilliationCollection.Add(new DirectBillPayable(row.PolicyNumber, row.InsuredPolicyName, row.QuoteControlNum, row.EffectiveDate, row.ExpirationDate, row.Table.Select("QuoteControlNum = " + row.QuoteControlNum.ToString(), "InvoiceNum asc"), row.CurrencyCode));
        if (!this.IsDisposed && !this.Disposing)
          Task.Factory.StartNew(new Action(this.ShowChipDownProgress), CancellationToken.None, TaskCreationOptions.None, scheduler);
      }
    }
    if (this.IsDisposed || this.Disposing)
      return;
    Task.Factory.StartNew(new Action(this.CreateDirectBillPayableViewCompleted), CancellationToken.None, TaskCreationOptions.None, scheduler);
  }

  private void UpdateStatus(string message)
  {
  }

  private void CreateDirectBillPayableViewCompleted()
  {
    this.pnlPayableChipDownView.Visible = false;
    this.radioPayableChipDownView.Visible = true;
    this.radioPayableChipDownView.Enabled = true;
    this.pnlPayableChipDownView.SendToBack();
    this.radioPayableChipDownView.Enabled = true;
  }

  private void CreateDirectBillReceivablesViewCompleted()
  {
    this.pnlReceivableChipDownView.Visible = false;
    this.radioReceivableChipDownView.Visible = true;
    this.radioReceivableChipDownView.Enabled = true;
    this.pnlReceivableChipDownView.SendToBack();
    this.radioReceivableChipDownView.Enabled = true;
  }

  protected virtual void comboBankAccount_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboBankAccount).SelectedRow == null)
      return;
    this.SetupComboPaymentMethods();
    this.GetBankCurrency((int) ((UltraDropDownBase) this.comboBankAccount).SelectedRow.Cells[formTransactionBuilder.ArApGridColumnKeys.GeneralLedgerAccountId].Value);
  }

  protected virtual void SetupComboPaymentMethods()
  {
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableMultiACHSettings"))
    {
      this.SetupMultiACHPaymentMethods();
    }
    else
    {
      this.SetVisiblePaymentControl(true);
      ((UltraGridBase) this.comboPaymentMethods).DataSource = (object) MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetEntityPaymentMethods(this._entityGuid, this._glCompanyId, int.Parse(((UltraDropDownBase) this.comboBankAccount).SelectedRow.Cells[formTransactionBuilder.ArApGridColumnKeys.GeneralLedgerAccountId].Value.ToString()));
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboPaymentMethods).Rows).Count != 1)
        return;
      this.comboPaymentMethods.Value = ((UltraGridBase) this.comboPaymentMethods).Rows[0].Cells[formTransactionBuilder.ArApGridColumnKeys.PayMethodId].Value;
    }
  }

  private void SetupMultiACHPaymentMethods()
  {
    this.SetVisiblePaymentControl(false);
    this.comboPayeePaymentMethods.DataBindings.Clear();
    this.comboPayeePaymentMethods.SetDropDownWidth(300);
    if (this.comboPayeePaymentMethods.IsWiredUp())
      this.comboPayeePaymentMethods.UnWireUp();
    List<BankAccountPaymentTypeDto> list = ((IEnumerable<BankAccountPaymentTypeDto>) new BankAccountPaymentTypeRepository().GetForEntity(this._entityGuid)).ToList<BankAccountPaymentTypeDto>();
    if (list.Count == 0)
    {
      list.Add(formTransactionBuilder.GetOtherPaymentMethod('C', "Check"));
      list.Add(formTransactionBuilder.GetOtherPaymentMethod('E', "EFT"));
      list.Add(formTransactionBuilder.GetOtherPaymentMethod('O', "Offset"));
    }
    this._paymentMethodComboModel = (IMvcComboBoxModel<BankAccountPaymentTypeDto>) new MvcComboBoxModel<BankAccountPaymentTypeDto>((IEnumerable<BankAccountPaymentTypeDto>) list.OrderBy<BankAccountPaymentTypeDto, string>((System.Func<BankAccountPaymentTypeDto, string>) (m => m.BankName)).ThenBy<BankAccountPaymentTypeDto, string>((System.Func<BankAccountPaymentTypeDto, string>) (m => m.AccountName)).ThenBy<BankAccountPaymentTypeDto, string>((System.Func<BankAccountPaymentTypeDto, string>) (m => m.BankAccountNumber)).ThenBy<BankAccountPaymentTypeDto, string>((System.Func<BankAccountPaymentTypeDto, string>) (m => m.PaymentMethodName)).ToList<BankAccountPaymentTypeDto>(), true);
    this._paymentMethodComboController = (IMvcComboBoxController<BankAccountPaymentTypeDto>) new MvcComboBoxController<BankAccountPaymentTypeDto>(new IComboBoxColumn<BankAccountPaymentTypeDto>[5]
    {
      (IComboBoxColumn<BankAccountPaymentTypeDto>) new TextReadOnlyColumn<BankAccountPaymentTypeDto>("Bank", 200, (System.Func<BankAccountPaymentTypeDto, object>) (x => (object) x.BankName)),
      (IComboBoxColumn<BankAccountPaymentTypeDto>) new TextReadOnlyColumn<BankAccountPaymentTypeDto>("Account Number", 100, (System.Func<BankAccountPaymentTypeDto, object>) (x => (object) x.BankAccountNumber)),
      (IComboBoxColumn<BankAccountPaymentTypeDto>) new TextReadOnlyColumn<BankAccountPaymentTypeDto>("Account", 200, (System.Func<BankAccountPaymentTypeDto, object>) (x => (object) x.AccountName)),
      (IComboBoxColumn<BankAccountPaymentTypeDto>) new TextReadOnlyColumn<BankAccountPaymentTypeDto>("Method", 80 /*0x50*/, (System.Func<BankAccountPaymentTypeDto, object>) (x => (object) x.PaymentMethodName))
      {
        IsComboBoxSelectionDisplayColumn = true
      },
      (IComboBoxColumn<BankAccountPaymentTypeDto>) new TextReadOnlyColumn<BankAccountPaymentTypeDto>("Currency", 200, (System.Func<BankAccountPaymentTypeDto, object>) (x => (object) x.Currency))
    });
    this.comboPayeePaymentMethods.WireUp((IMvcComboBoxController) this._paymentMethodComboController, (IMvcComboBoxModel) this._paymentMethodComboModel);
    this.SetPayeeBankAccountComboEnabledState(this.radioCashDisbursement.Checked);
    this.SelectDefaultPaymentMethodComboValue();
  }

  private static BankAccountPaymentTypeDto GetOtherPaymentMethod(char id, string name)
  {
    return new BankAccountPaymentTypeDto()
    {
      AccountName = "-",
      BankAccountNumber = "-",
      BankName = "-",
      Currency = "-",
      IsDefault = false,
      PaymentMethodId = id,
      PaymentMethodName = name
    };
  }

  private void SetVisiblePaymentControl(bool useLegacy)
  {
    ((Control) this.comboPaymentMethods).Visible = useLegacy;
    ((Control) this.comboPaymentMethods).Enabled = useLegacy;
    this.comboPayeePaymentMethods.Enabled = !useLegacy;
    this.comboPayeePaymentMethods.Visible = !useLegacy;
  }

  private void SetPayeeBankAccountComboEnabledState(bool isCashDisbursement)
  {
    this.comboPayeePaymentMethods.Enabled = isCashDisbursement;
  }

  private void RadioCashDisbursement_CheckedChanged(object sender, EventArgs e)
  {
    this.SetPayeeBankAccountComboEnabledState(this.radioCashDisbursement.Checked);
  }

  private void SelectDefaultPaymentMethodComboValue()
  {
    if (this._paymentMethodComboModel == null)
      return;
    BankAccountPaymentTypeDto accountPaymentTypeDto = this._paymentMethodComboModel.Items.FirstOrDefault<BankAccountPaymentTypeDto>((System.Func<BankAccountPaymentTypeDto, bool>) (m => m.IsDefault));
    if (accountPaymentTypeDto != null)
      this._paymentMethodComboModel.SelectedItem = accountPaymentTypeDto;
    else if (this._paymentMethodComboModel.Items.Count<BankAccountPaymentTypeDto>() == 1)
      this._paymentMethodComboModel.SelectedItem = this._paymentMethodComboModel.Items.First<BankAccountPaymentTypeDto>();
    else
      this._paymentMethodComboModel.ClearSelection();
  }

  protected void LoadBankAccounts()
  {
    this.dsBankAccounts?.Clear();
    this.daGetBankAccounts.SelectCommand.Parameters["@glcompanyid"].Value = (object) this._glCompanyId;
    this.daGetBankAccounts.Fill((DataTable) this.dsBankAccounts.spFin_GetBankAccounts);
    this.SelectBankAccount();
  }

  protected virtual void SelectBankAccount()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboBankAccount).Rows).Count == 0)
      return;
    if (this._glCompanyId > 0)
    {
      int? glAccountId = AccountingCache.Instance.GlCompany(this._glCompanyId)?.PrimaryBankAccount?.GLAccountID;
      if (glAccountId.HasValue)
      {
        this.comboBankAccount.Value = (object) glAccountId;
      }
      else
      {
        int num = (int) MessageBox.Show("No Primary Bank Account has been found. Please setup a Primary Bank Account using the Automation Settings screen.");
      }
    }
    ((Control) this.comboBankAccount).Enabled = SecurityManager.Instance.AssertPermission("{6A42AE28-3617-4dfe-BC40-AC979EA71ADC}");
  }

  private void xViewReceivable_WriteOffReceivableClicked(
    object sender,
    WriteOffReceivableClickedEventArgs e)
  {
    this.WriteOffReceivable(e.Row, formTransactionBuilder.ArApGridColumnKeys.Argl, formTransactionBuilder.ArApGridColumnKeys.NetDue);
  }

  private void xViewReceivable_AssignFinanceCompanyClicked(
    object sender,
    AssignFinanceCompanyClickedEventArgs e)
  {
    this.UpdateFinanceCompany(this.gridReceivables, true);
    this.ShowExtendedView(true);
  }

  private void xViewReceivable_ViewPolicyDetailClicked(object sender, ViewPolicyClickedEventArgs e)
  {
    MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ShowPolicyInquiry(e.ControlNumber, e.GlCompanyId);
  }

  private void xViewPayable_ViewPolicyDetailClicked(object sender, ViewPolicyClickedEventArgs e)
  {
    MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ShowPolicyInquiry(e.ControlNumber, e.GlCompanyId);
  }

  private void xViewPayable_WriteOffPayableClicked(object sender, WriteOffPayableClickedEventArgs e)
  {
    this.WriteOffPayable(e.Row);
  }

  protected virtual void WriteOffReceivable(
    UltraGridRow ArRow,
    string glAccountColumn,
    string amountColumn)
  {
    if (!this.CheckFormViewState() || ArRow == null)
      return;
    UltraGridRow activeRow = ((UltraGridBase) this.gridReceivables).ActiveRow;
    if (!ReceivableServices.WriteOffTransaction(int.Parse(activeRow.Cells[glAccountColumn].Value.ToString()), Decimal.Parse(activeRow.Cells[amountColumn].Value.ToString()), int.Parse(activeRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ChargeCode].Value.ToString()), int.Parse(activeRow.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value.ToString()), new Guid(activeRow.Cells[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].Value.ToString()), this._glCompanyId, this._entityGuid))
      return;
    ArRow.Delete(false);
    this.dsOpenReceivables.AcceptChanges();
  }

  private void WriteOffPayable(UltraGridRow ApRow)
  {
    if (!this.CheckFormViewState() || ApRow == null || !PayableServices.WriteOffTransaction(int.Parse(ApRow.Cells[formTransactionBuilder.ArApGridColumnKeys.Apgl].Value.ToString()), Decimal.Parse(ApRow.Cells[formTransactionBuilder.ArApGridColumnKeys.NetPayable].Value.ToString()), int.Parse(ApRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ChargeCode].Value.ToString()), int.Parse(ApRow.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value.ToString()), new Guid(ApRow.Cells[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].Value.ToString()), this._glCompanyId, new Guid(ApRow.Cells[formTransactionBuilder.ArApGridColumnKeys.PayeeGuid].Value.ToString())))
      return;
    ApRow.Delete(false);
    this.dsOpenPayables.AcceptChanges();
  }

  private void WriteOffPayable(
    int apGlAccountId,
    Decimal netPayable,
    int chargeCode,
    int invoiceNumber,
    Guid companyLineGuid,
    int glCompanyId,
    Guid payeeGuid)
  {
    PayableServices.WriteOffTransaction(apGlAccountId, netPayable, chargeCode, invoiceNumber, companyLineGuid, glCompanyId, payeeGuid);
  }

  private void UpdateFinanceCompany(UltraGrid grid, bool isReceivable)
  {
    if (((UltraGridBase) grid).ActiveRow == null)
      return;
    int num1 = int.Parse(((UltraGridBase) grid).ActiveRow.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value.ToString());
    using (formFinanceCompany formFinanceCompany = new formFinanceCompany())
    {
      if (formFinanceCompany.ShowDialog() != DialogResult.OK)
        return;
      using (SqlCommand sqlCommand = new SqlCommand("spFin_UpdateFinanceCompany", new SqlConnection(CurrentUser.Instance.ConnectionString)))
      {
        sqlCommand.CommandType = CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("@invoicenum", (object) num1);
        sqlCommand.Parameters.AddWithValue("@financecompanyguid", (object) formFinanceCompany.FinanceCompanyGuid);
        if (!string.IsNullOrEmpty(formFinanceCompany.AccountNumber))
          sqlCommand.Parameters.AddWithValue("@accountnumber", (object) formFinanceCompany.AccountNumber);
        sqlCommand.Connection.Open();
        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
        if (sqlDataReader.Read())
          CurrentUser.Instance.LogAction($"Changed finance company from {sqlDataReader[0].ToString()} to {sqlDataReader[1].ToString()} for Invoice #: {num1.ToString()}.");
        if (!sqlDataReader.IsClosed)
          sqlDataReader.Close();
        if (isReceivable)
          ((UltraGridBase) grid).ActiveRow.Cells[formTransactionBuilder.ArApGridColumnKeys.FinanceCompanyGuid].Value = (object) formFinanceCompany.FinanceCompanyGuid.ToString();
        int num2 = (int) MessageBox.Show("Finance Company Assigned", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
  }

  private InsuranceWorksheet CreateSavableWorksheet()
  {
    InsuranceWorksheet savableWorksheet = new InsuranceWorksheet();
    savableWorksheet.GlCompanyId = this._glCompanyId;
    savableWorksheet.searchDate = this._mainSearchOption.SearchForDate;
    savableWorksheet.searchInteger = this._mainSearchOption.SearchForInteger;
    savableWorksheet.searchString = this._mainSearchOption.SearchForString;
    savableWorksheet.PostingMemo = "Empty for now ";
    savableWorksheet.UnAccountedBalance = ((Control) this.txtUnAccountedBalance).Text == string.Empty ? 0.0M : Decimal.Parse(((Control) this.txtUnAccountedBalance).Text, NumberStyles.Currency);
    savableWorksheet.AppliedUnAccounted = ((Control) this.txtAppliedUnAccounted).Text == string.Empty ? 0.0M : Decimal.Parse(((Control) this.txtAppliedUnAccounted).Text, NumberStyles.Currency);
    savableWorksheet.entityGuid = this._mainSearchOption.SearchForGuid;
    savableWorksheet.entityName = ((Control) this.txtEntityName).Text;
    savableWorksheet.payableSearchType = this._mainSearchOption.PayableSearchType;
    savableWorksheet.receivableSearchType = this._mainSearchOption.ReceivableSearchType;
    if (((UltraDropDownBase) this.comboBankAccount).SelectedRow != null)
      savableWorksheet.glAcctId = int.Parse(this.comboBankAccount.Value.ToString());
    if (this.radioCashDisbursement.Checked)
    {
      savableWorksheet.IsCashDisbursement = true;
      if (!this.PaymentMethodComboMissingSelectedIndex())
        savableWorksheet.PaymentMethod = this.GetCharTransactionPaymentMethod();
      savableWorksheet.CheckDate = this.dateTimeCheckDate.DateTime;
      if (((Control) this.txtPayAmount).Text != string.Empty)
        savableWorksheet.TotalAmount = Decimal.Parse(((Control) this.txtPayAmount).Text, NumberStyles.Any);
    }
    else
    {
      savableWorksheet.IsCashDisbursement = false;
      if (((Control) this.txtCheckAmount).Text != string.Empty)
        savableWorksheet.CheckAmount = Decimal.Parse(((Control) this.txtCheckAmount).Text, NumberStyles.Any);
      savableWorksheet.CheckNumber = ((Control) this.txtCheckNumber).Text;
      savableWorksheet.DepositDate = this.dateTimeDepositDate.DateTime;
      savableWorksheet.ReceivedDate = this.dateTimeReceivedDate.DateTime;
      if (((Control) this.txtBalance).Text != string.Empty)
        savableWorksheet.TotalAmount = Decimal.Parse(((Control) this.txtBalance).Text, NumberStyles.Any);
      if (((Control) this.txtCheckFrom).Text != string.Empty)
      {
        savableWorksheet.ReceivedFromGuid = new Guid(((Control) this.txtCheckFrom).Tag.ToString());
        savableWorksheet.ReceivedFromName = ((Control) this.txtCheckFrom).Text;
      }
    }
    savableWorksheet.IsReturnPremium = this.chkReturnPremium.Checked;
    if (this.PayableGridValues != null)
      this.PayableGridValues.CopyTo(savableWorksheet.payableGridValues);
    if (this.ReceivableGridValues != null)
      this.ReceivableGridValues.CopyTo(savableWorksheet.receivableGridValues);
    savableWorksheet.SearchCriteria = this.AdditionalSearchOptions;
    if (this.InterCompanyTransfers != null)
      this.InterCompanyTransfers.CopyTo(savableWorksheet.interCompanyTransfers);
    savableWorksheet.searchType = this._searchType;
    return savableWorksheet;
  }

  private void SaveWorkSheet()
  {
    using (formSaveWorksheet form = (formSaveWorksheet) ObjectFactory.Instance.CreateForm(typeof (formSaveWorksheet), new object[2]
    {
      (object) formSaveWorksheet.WorksheetType.PayableReceivable,
      (object) this.CreateSavableWorksheet()
    }))
    {
      this.Cursor = Cursors.WaitCursor;
      form.Owner = (Form) this;
      int num = (int) form.ShowDialog();
      this.Cursor = Cursors.Default;
    }
  }

  public event formTransactionBuilder.LoadWorksheetCompletedHandler LoadWorksheetCompleted;

  protected virtual void OnLoadWorksheetCompleted(int worksheetId)
  {
    formTransactionBuilder.LoadWorksheetCompletedHandler worksheetCompleted = this.LoadWorksheetCompleted;
    if (worksheetCompleted == null)
      return;
    worksheetCompleted(worksheetId);
  }

  private void ApplySavedWorkSheetValues(InsuranceWorksheet worksheet)
  {
    this.chkReturnPremium.Checked = worksheet.IsReturnPremium;
    ((Control) this.txtAppliedUnAccounted).Text = worksheet.appliedUnAccounted.ToString("C");
    ((Control) this.txtUnAccountedBalance).Text = worksheet.unAccountedBalance.ToString("C");
    ((Control) this.txtEntityName).Text = worksheet.EntityName;
    this._mainSearchOption = new SearchCriteria();
    this._mainSearchOption.PayableSearchType = worksheet.payableSearchType;
    this._mainSearchOption.PayeeName = worksheet.EntityName;
    this._mainSearchOption.ReceivableSearchType = worksheet.receivableSearchType;
    this._mainSearchOption.SearchForDate = worksheet.searchDate;
    this._mainSearchOption.SearchForGuid = worksheet.EntityGuid;
    this._mainSearchOption.SearchForInteger = worksheet.searchInteger;
    this._mainSearchOption.SearchForString = worksheet.searchString;
    this._glCompanyId = worksheet.GlCompanyId;
    this._payableGridValues = worksheet.payableGridValues;
    this._receivableGridValues = worksheet.receivableGridValues;
    this._additionalSearchOptions = worksheet.SearchCriteria;
    this._currentSearchOption = this._mainSearchOption;
    this._searchType = worksheet.searchType;
    this._interCompanyTransfers = worksheet.interCompanyTransfers;
    this._entityGuid = worksheet.EntityGuid;
    this.LoadBankAccounts();
    this.LoadCostCenters(this.comboUnAccountedCostCenter);
    this.LoadCostCenters(this.comboCostCenters);
    this.comboBankAccount.Value = (object) worksheet.glAcctId;
    if (worksheet.IsCashDisbursement)
    {
      this.radioCashDisbursement.Checked = true;
      this.dateTimeCheckDate.DateTime = worksheet.CheckDate;
      ((Control) this.txtPayAmount).Text = worksheet.TotalAmount.ToString("C");
      this.SetComboPaymentMethod(worksheet.PaymentMethod);
    }
    else
    {
      this.radioCashReceipt.Checked = true;
      ((Control) this.txtCheckAmount).Text = worksheet.CheckAmount.ToString("C");
      ((Control) this.txtCheckNumber).Text = worksheet.CheckNumber;
      this.dateTimeDepositDate.DateTime = worksheet.DepositDate;
      this.dateTimeReceivedDate.DateTime = worksheet.ReceivedDate;
      ((Control) this.txtPayAmount).Text = worksheet.TotalAmount.ToString("C");
      if (!(worksheet.ReceivedFromName != string.Empty))
        return;
      ((Control) this.txtCheckFrom).Text = worksheet.ReceivedFromName;
      ((Control) this.txtCheckFrom).Tag = (object) worksheet.ReceivedFromGuid;
    }
  }

  private void LoadWorkSheet()
  {
    this._isLoadingSavedWorkSheet = true;
    using (formLoadWorksheet formLoadWorksheet = new formLoadWorksheet(formLoadWorksheet.WorksheetType.Accounting))
    {
      if (formLoadWorksheet.ShowDialog() == DialogResult.OK)
      {
        if (formLoadWorksheet.IsBulk)
        {
          this.LoadWorksheet_Bulk(formLoadWorksheet.Worksheet, formLoadWorksheet.WorksheetId);
        }
        else
        {
          try
          {
            this.Cursor = MgaCursors.WaitCursor;
            this.Clear();
            this._isMassiveUpdate = true;
            this.ApplySavedWorkSheetValues((InsuranceWorksheet) formLoadWorksheet.Worksheet);
            this.ReLoad();
            this.ReapplyGridValues();
            this._isMassiveUpdate = false;
            if (this.InterCompanyTransfers.Count != 0)
            {
              ((UltraTabControlBase) this.tabTransactions).Tabs["ADDITIONALOFFSETS"].Visible = true;
              ((UltraGridBase) this.gridAdditionalOffsets).DataSource = (object) this.InterCompanyTransfers;
              if (this.InterCompanyTransfers.Count != 0)
              {
                ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Summaries.Clear();
                this.AddgridAdditionalOffsetsSummaries();
              }
            }
            this.LoadCostCenters(this.comboUnAccountedCostCenter);
            this.LoadCostCenters(this.comboCostCenters);
            this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyId);
            this.OnLoadWorksheetCompleted(formLoadWorksheet.WorksheetId);
            this.CalculateAndDisplayTotal();
            CurrentUser.Instance.LogAction("Loaded saved AR/AP worksheet.", "Accounting Logs");
          }
          finally
          {
            this.Cursor = Cursors.Default;
          }
        }
      }
    }
    this._isLoadingSavedWorkSheet = false;
    if (this._currentSearchOption == null)
      return;
    if (this._currentSearchOption.ReceivableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.None)
      this.CreateDirectBillPayableView();
    else
      this.CreateDirectBillReceivableView();
  }

  private void ReapplyGridValues()
  {
    if (this._searchType == formTransactionSearch.SearchTypes.PayablesReceivables)
    {
      this.ReapplyPayableGridValues();
      this.ReapplyReceivableGridValues();
    }
    else if (this._searchType == formTransactionSearch.SearchTypes.Receivables)
      this.ReapplyReceivableGridValues();
    else if (this._searchType == formTransactionSearch.SearchTypes.Payables)
      this.ReapplyPayableGridValues();
    this.CalculateAndDisplayTotal();
    this.DisplayReapplyErrors();
  }

  private void ReapplyPayableGridValues()
  {
    this._payableAppliedTotal = 0.0M;
    if (this.PayableGridValues.Count == 0)
      return;
    MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValueCollection gridValueCollection = new MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValueCollection();
    foreach (MGASystems.IMS.Accounting.AccountsPayable.AppliedGridValue payableGridValue in this.PayableGridValues)
    {
      StringBuilder stringBuilder = new StringBuilder(200);
      stringBuilder.Append($"InvoiceNum = {payableGridValue.InvoiceNumber} and ");
      stringBuilder.Append($"ChargeCode = {payableGridValue.ChargeCode} and ");
      stringBuilder.Append($"CompanyLineGuid = '{payableGridValue.CompanyLineGuid}' and ");
      stringBuilder.Append($"QuoteControlNum = {payableGridValue.ControlNumber} and ");
      stringBuilder.Append($"PayeeGuid = '{payableGridValue.EntityGuid}'");
      if (payableGridValue.GrossPayable.HasValue)
        stringBuilder.Append($" and [Gross Payable] = {payableGridValue.GrossPayable}");
      DataRow row = ((IEnumerable<DataRow>) this.dsOpenPayables.OpenPayables.Select(stringBuilder.ToString())).FirstOrDefault<DataRow>();
      if (row != null)
      {
        if (Math.Abs(row.Field<Decimal>(formTransactionBuilder.ArApGridColumnKeys.NetPayable)) < Math.Abs(payableGridValue.ApApplied))
        {
          payableGridValue.ApApplied = 0.0M;
          this.LogAppliedChanges(row[formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNum].ToString(), row[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].ToString(), string.Empty);
        }
        else
        {
          this._payableAppliedTotal += payableGridValue.ApApplied;
          row[formTransactionBuilder.ArApGridColumnKeys.ApApplied] = (object) payableGridValue.ApApplied;
          gridValueCollection.Add(payableGridValue);
        }
      }
    }
    this._payableGridValues = gridValueCollection;
  }

  private void ReapplyReceivableGridValues()
  {
    this._receivableAppliedTotal = 0.0M;
    if (this.ReceivableGridValues.Count == 0)
      return;
    foreach (MGASystems.IMS.Accounting.AccountsReceivable.AppliedGridValue receivableGridValue in (CollectionBase) this.ReceivableGridValues)
    {
      object[] objArray = new object[4]
      {
        (object) receivableGridValue.InvoiceNumber,
        (object) receivableGridValue.ChargeCode,
        (object) receivableGridValue.CompanyLineGuid.ToString(),
        (object) receivableGridValue.ControlNumber
      };
      foreach (DataRow dataRow in this.dsOpenReceivables.OpenReceivables.Select(string.Format("InvoiceNum = {0} and ChargeCode = {1} and CompanyLineGuid = '{2}' and QuoteControlNum = {3}", objArray)))
      {
        if (Math.Abs(Decimal.Parse(dataRow[formTransactionBuilder.ArApGridColumnKeys.NetDue].ToString())) < Math.Abs(receivableGridValue.ArApplied))
        {
          this.LogAppliedChanges(dataRow[formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNum].ToString(), dataRow[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].ToString());
          receivableGridValue.ExApplied = 0.0M;
          receivableGridValue.UaApplied = 0.0M;
          receivableGridValue.ArApplied = 0.0M;
        }
        else
        {
          this._receivableAppliedTotal -= receivableGridValue.ArApplied;
          dataRow[formTransactionBuilder.ArApGridColumnKeys.ArApplied] = (object) receivableGridValue.ArApplied;
          if (receivableGridValue.ExApplied != 0.0M)
          {
            this._receivableAppliedTotal -= receivableGridValue.ExApplied;
            dataRow[formTransactionBuilder.ArApGridColumnKeys.ExchApplied] = (object) receivableGridValue.ExApplied;
          }
          else
            dataRow[formTransactionBuilder.ArApGridColumnKeys.ExchApplied] = (object) DBNull.Value;
          if (receivableGridValue.UaApplied != 0.0M)
          {
            this._receivableAppliedTotal -= receivableGridValue.UaApplied;
            dataRow[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied] = (object) receivableGridValue.UaApplied;
          }
          else
            dataRow[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied] = (object) DBNull.Value;
        }
      }
    }
  }

  private void toolbar_BeforeToolDropdown(object sender, BeforeToolDropdownEventArgs e)
  {
    if (((KeyedSubObjectBase) ((CancelableToolEventArgs) e).Tool).Key != "ReceivableContextMenu" && ((KeyedSubObjectBase) ((CancelableToolEventArgs) e).Tool).Key != "PaybleContextMenu")
      return;
    UltraGrid ultraGrid = this._currentPage == formTransactionBuilder.TabPages.Payable ? this.gridPayables : this.gridReceivables;
    ((CancelEventArgs) e).Cancel = ((DisposableObjectCollectionBase) ((UltraGridBase) ultraGrid).Rows).Count == 0;
    if (!(((ControlUIElementBase) ((UltraGridBase) ultraGrid).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow), true) is UltraGridRow context))
      return;
    context.Activate();
    ((GridItemBase) context).Selected = true;
  }

  private void textAmount_Validating(object sender, CancelEventArgs e)
  {
    MGATextBox mgaTextBox = (MGATextBox) sender;
    if (!((Control) mgaTextBox).Text.Equals(string.Empty))
    {
      if (!MGASystems.IMS.Accounting.Core.ClassObjects.Utility.IsDecimalValue((object) ((Control) mgaTextBox).Text))
      {
        int num = (int) MessageBox.Show("Check amount must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
        return;
      }
      ((Control) mgaTextBox).Text = Decimal.Parse(((Control) mgaTextBox).Text, NumberStyles.Any).ToString("C");
    }
    this.CalculateAndDisplayTotal();
  }

  protected virtual void radioCashDisbursement_Click(object sender, EventArgs e)
  {
    if (this._searchType == formTransactionSearch.SearchTypes.Payables)
      this.chkReturnPremium.Checked = !this.radioCashDisbursement.Checked;
    else if (this._searchType == formTransactionSearch.SearchTypes.Receivables)
      this.chkReturnPremium.Checked = this.radioCashDisbursement.Checked;
    this.CalculateAndDisplayTotal();
  }

  protected virtual void radioCashReceipt_Click(object sender, EventArgs e)
  {
    if (this._searchType == formTransactionSearch.SearchTypes.Payables)
      this.chkReturnPremium.Checked = this.radioCashReceipt.Checked;
    else if (this._searchType == formTransactionSearch.SearchTypes.Receivables)
      this.chkReturnPremium.Checked = !this.radioCashReceipt.Checked;
    this.CalculateAndDisplayTotal();
  }

  protected virtual void CalculateAndDisplayTotal()
  {
    Decimal num1 = this.InterCompanyTransfers.InterCompanyTransferTotal();
    Decimal num2 = ((Control) this.txtCheckAmount).Text == string.Empty ? 0M : Decimal.Parse(((Control) this.txtCheckAmount).Text, NumberStyles.Any);
    Decimal num3 = ((Control) this.txtUnAccountedBalance).Text == string.Empty ? 0M : Decimal.Parse(((Control) this.txtUnAccountedBalance).Text, NumberStyles.Any);
    Decimal num4 = ((Control) this.txtAppliedUnAccounted).Text == string.Empty ? 0M : Decimal.Parse(((Control) this.txtAppliedUnAccounted).Text, NumberStyles.Any);
    if (this.radioCashReceipt.Checked)
    {
      Decimal num5 = this._payableAppliedTotal + this._receivableAppliedTotal + num2;
      Decimal num6 = !(num1 > 0M) ? num5 + Math.Abs(num1) : num5 - num1;
      Decimal num7 = (!(num4 > 0M) ? num6 + Math.Abs(num4) : num6 - Math.Abs(num4)) + this.WorkingDepositApplied();
      ((Control) this.txtUnAccountedBalance).Text = num3.ToString("c");
      ((Control) this.txtBalance).Text = num7.ToString("c");
      ((Control) this.txtPayAmount).Text = string.Empty;
    }
    else
    {
      Decimal num8 = this._payableAppliedTotal + this._receivableAppliedTotal;
      Decimal num9 = !(num1 > 0M) ? num8 + Math.Abs(num1) : num8 - Math.Abs(num1);
      Decimal num10 = (!(num4 > 0M) ? num9 - Math.Abs(num4) : num9 + Math.Abs(num4)) + this.WorkingDepositApplied();
      ((Control) this.txtUnAccountedBalance).Text = num3.ToString("c");
      ((Control) this.txtPayAmount).Text = num10.ToString("c");
      ((Control) this.txtBalance).Text = string.Empty;
    }
  }

  private void CreateFinancedReturnCollection()
  {
    if (this._mainSearchOption == null || this._mainSearchOption.ReceivableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.None)
      return;
    Guid empty = Guid.Empty;
    this.FinancedReceivables.Clear();
    foreach (UltraGridRow row in ((UltraGridBase) this.gridReceivables).Rows)
    {
      if (((DisposableObjectCollectionBase) row.Cells).Count != 0)
      {
        Guid guid = new Guid(row.Cells[formTransactionBuilder.ArApGridColumnKeys.FinanceCompanyGuid].Value.ToString());
        if (row.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value != null && row.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value.ToString() != string.Empty && Decimal.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value.ToString()) != 0.0M && !guid.Equals(Guid.Empty))
        {
          if (this.FinancedReceivables.KeyExists(guid))
            this.FinancedReceivables[guid].Details.Add(new FinancedReturnDetail(int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value.ToString()), int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNum].Value.ToString()), int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ChargeCode].Value.ToString()), new Guid(row.Cells[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].Value.ToString()), int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.Argl].Value.ToString()), Decimal.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value.ToString(), NumberStyles.Currency), row.Cells[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].Value.ToString(), int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ControlNum].Value.ToString()), new Guid(row.Cells[formTransactionBuilder.ArApGridColumnKeys.RemitterGuid].Value.ToString())));
          else
            this.FinancedReceivables.Add(new FinancedReturn(guid, this._glCompanyId, this.dateTimeCheckDate.DateTime)
            {
              Details = {
                new FinancedReturnDetail(int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value.ToString()), int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNum].Value.ToString()), int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ChargeCode].Value.ToString()), new Guid(row.Cells[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].Value.ToString()), int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.Argl].Value.ToString()), Decimal.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied].Value.ToString(), NumberStyles.Currency), row.Cells[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].Value.ToString(), int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ControlNum].Value.ToString()), new Guid(row.Cells[formTransactionBuilder.ArApGridColumnKeys.RemitterGuid].Value.ToString()))
              }
            });
        }
      }
    }
  }

  protected void ConfirmIsReturnPremium()
  {
    string text = "The current transaction may not support the book as return premium option. Are you sure you wish to book this transaction as a return premium?";
    bool flag = false;
    Decimal num1 = 0M;
    Decimal num2 = 0M;
    Decimal num3 = 0M;
    if (this._searchType != formTransactionSearch.SearchTypes.PayablesReceivables)
      return;
    foreach (UltraGridBand band in ((UltraGridBase) this.gridPayables).DisplayLayout.Bands)
    {
      band.ColumnFilters.ClearAllFilters();
      band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.ApApplied].FilterConditions.Add((FilterComparisionOperator) 1, (object) 0);
      band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.ApApplied].FilterConditions.Add((FilterComparisionOperator) 1, (object) DBNull.Value);
    }
    foreach (UltraGridBand band in ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands)
    {
      band.ColumnFilters.ClearAllFilters();
      band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.ArApplied].FilterConditions.Add((FilterComparisionOperator) 1, (object) 0);
      band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.ArApplied].FilterConditions.Add((FilterComparisionOperator) 1, (object) DBNull.Value);
    }
    int length1 = ((UltraGridBase) this.gridPayables).Rows.GetFilteredInNonGroupByRows().Length;
    int length2 = ((UltraGridBase) this.gridReceivables).Rows.GetFilteredInNonGroupByRows().Length;
    if (((Control) this.txtCheckAmount).Text != string.Empty)
      num1 = Decimal.Parse(((Control) this.txtCheckAmount).Text, NumberStyles.Any);
    if (((Control) this.txtBalance).Text != string.Empty)
      num2 = Decimal.Parse(((Control) this.txtBalance).Text, NumberStyles.Any);
    if (((Control) this.txtPayAmount).Text != string.Empty)
      num3 = Decimal.Parse(((Control) this.txtPayAmount).Text, NumberStyles.Any);
    if (length1 != 0 && length2 == 0)
    {
      if (this.radioCashReceipt.Checked && (num1 >= 0M || num2 <= 0M))
        flag = true;
    }
    else if (length1 == 0 && length2 != 0 && this.radioCashDisbursement.Checked && num3 > 0M)
      flag = true;
    foreach (UltraGridBand band in ((UltraGridBase) this.gridPayables).DisplayLayout.Bands)
      band.ColumnFilters.ClearAllFilters();
    foreach (UltraGridBand band in ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands)
      band.ColumnFilters.ClearAllFilters();
    if (!flag || MessageBox.Show(text, "Book As Return Premium?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.chkReturnPremium.Checked = true;
  }

  private bool AddUnaccountedTransactions(InsuranceTransaction trans)
  {
    if (((Control) this.txtAppliedUnAccounted).Text == string.Empty || Decimal.Parse(((Control) this.txtAppliedUnAccounted).Text, NumberStyles.Any) == 0M)
      return true;
    Decimal nonInvoiceAmount1 = Decimal.Parse(((Control) this.txtAppliedUnAccounted).Text, NumberStyles.Any);
    int unaccountedAccount = Utilities.GetEntityUnaccountedAccount(this._glCompanyId);
    int num1 = int.Parse(this.comboBankAccount.Value.ToString());
    int costCenterId = int.Parse(this.comboUnAccountedCostCenter.Value.ToString());
    if (this._appliedUnaccountedDS == null || this._appliedUnaccountedDS.AppliedUnaccounted.Rows.Count == 0)
    {
      if (((UltraDropDownBase) this.comboUnAccountedCostCenter).SelectedRow == null)
      {
        int num2 = (int) MessageBox.Show("You must specify an un-accounted cost center to continue.", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      int glAccountId1;
      int glAccountId2;
      if (nonInvoiceAmount1 < 0M)
      {
        glAccountId1 = this.radioCashReceipt.Checked ? num1 : unaccountedAccount;
        glAccountId2 = this.radioCashReceipt.Checked ? unaccountedAccount : num1;
      }
      else
      {
        glAccountId1 = this.radioCashReceipt.Checked ? unaccountedAccount : num1;
        glAccountId2 = this.radioCashReceipt.Checked ? num1 : unaccountedAccount;
      }
      Decimal transactionTotal = Math.Abs(nonInvoiceAmount1);
      CostCenterAllocationCollection withAllocation1 = CostCenterAllocationCollection.CreateWithAllocation(costCenterId, -transactionTotal);
      CostCenterAllocationCollection withAllocation2 = CostCenterAllocationCollection.CreateWithAllocation(costCenterId, transactionTotal);
      trans.Credits.Add(this.CreateNonInvoiceTransactionDetail(nonInvoiceAmount1, glAccountId1, withAllocation1));
      trans.Debits.Add(this.CreateNonInvoiceTransactionDetail(nonInvoiceAmount1, glAccountId2, withAllocation2));
    }
    else
    {
      foreach (dsAppliedUnaccounted.AppliedUnaccountedRow row in (InternalDataCollectionBase) this._appliedUnaccountedDS.AppliedUnaccounted.Rows)
      {
        if (!row.IsAppliedAmountNull() && row.AppliedAmount != 0M)
        {
          Decimal nonInvoiceAmount2 = ((Control) this.txtAppliedUnAccounted).Enabled ? row.AppliedAmount : row.AppliedAmount * -1M;
          int glAccountId3;
          int glAccountId4;
          if (nonInvoiceAmount2 < 0M)
          {
            if (((Control) this.txtAppliedUnAccounted).Enabled)
            {
              glAccountId3 = this.radioCashReceipt.Checked ? num1 : unaccountedAccount;
              glAccountId4 = this.radioCashReceipt.Checked ? unaccountedAccount : num1;
            }
            else
            {
              glAccountId3 = num1;
              glAccountId4 = unaccountedAccount;
            }
          }
          else if (((Control) this.txtAppliedUnAccounted).Enabled)
          {
            glAccountId3 = this.radioCashReceipt.Checked ? unaccountedAccount : num1;
            glAccountId4 = this.radioCashReceipt.Checked ? num1 : unaccountedAccount;
          }
          else
          {
            glAccountId3 = unaccountedAccount;
            glAccountId4 = num1;
          }
          Decimal transactionTotal = Math.Abs(nonInvoiceAmount2);
          CostCenterAllocationCollection withAllocation3 = CostCenterAllocationCollection.CreateWithAllocation(costCenterId, -transactionTotal);
          CostCenterAllocationCollection withAllocation4 = CostCenterAllocationCollection.CreateWithAllocation(costCenterId, transactionTotal);
          trans.Credits.Add(this.CreateNonInvoiceTransactionDetail(nonInvoiceAmount2, glAccountId3, withAllocation3, row.TransactNum));
          trans.Debits.Add(this.CreateNonInvoiceTransactionDetail(nonInvoiceAmount2, glAccountId4, withAllocation4, row.TransactNum));
        }
      }
    }
    return true;
  }

  protected Dictionary<DateTime, InsuranceTransaction> FutureTransactions
  {
    get => this._futureTransactions ?? new Dictionary<DateTime, InsuranceTransaction>();
    set => this._futureTransactions = value;
  }

  protected virtual void Post()
  {
    this.ConfirmIsReturnPremium();
    InsuranceTransaction transaction = this.CreateTransaction();
    if (transaction == null)
      return;
    transaction.NumberOfClaimsReceived = this.NumberOfClaimsReceived;
    if (this._searchType != formTransactionSearch.SearchTypes.None || this._searchType != formTransactionSearch.SearchTypes.Receivables)
    {
      this.AddNonPayableFeesToTransaction(transaction);
      transaction.BulkAPPostTableName = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled") ? string.Empty : this.PostAPExcel();
    }
    transaction.IsReturnPremium = this.chkReturnPremium.Checked;
    if (!this.AddUnaccountedTransactions(transaction))
      return;
    if ((transaction.Credits.Count == 0 || transaction.Debits.Count == 0) && transaction.FinancedReceivables.Count == 0)
    {
      int num = (int) MessageBox.Show("The current posting has no credits or debits and can not be posted to the ledger!", "Invalid Posting!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.PostFutureTransactions();
      if (transaction.IsBalanced())
      {
        transaction.HasClaims = this.HasClaims;
        if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
          transaction.SaveBulk();
        else
          transaction.Save();
        if (this.ReinstatementList.Count > 0)
          formTransactionBuilder.LoadReinstatements(transaction.TransactionNumber, this.ReinstatementList);
        this.AskPrintPaymentSummary(transaction);
      }
      this.AfterPostTransaction(transaction.TransactionNumber);
      if (!this.lblbBankCurrency.Text.ToString().Equals("Currency: USD", StringComparison.OrdinalIgnoreCase) && ((UltraToggleEditorBase) this.checkBankCurrency).Checked)
        DefaultDatabase.ExecuteNonQuery("spFin_ApplyBankCurrency", new object[4]
        {
          (object) "@transactionNumber",
          (object) transaction.TransactionNumber,
          (object) "@currencyCode",
          (object) this._bankCurrency
        });
      if (this._partialPay.Count > 0)
        this.OnPartialPayListReady(this._partialPay);
      if (this._afterCancelPay.Count > 0)
        this.OnAfterCancelledPayListReady(this._afterCancelPay);
      this.DoWishToReload();
    }
  }

  private void AskPrintPaymentSummary(InsuranceTransaction trans)
  {
    string text = "Do you wish to print a payment summary at this time?";
    if (!this._isSummaryPrintingRequired || MessageBox.Show(text, "Posting Successful!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || trans.TransactionsCreated.Count == 0)
      return;
    for (int index = 0; index < trans.TransactionsCreated.Count; ++index)
      PayableServices.PrintPaymentSummary((int) trans.TransactionsCreated[index]);
  }

  public void DoWishToReload()
  {
    if (this._doNotShowReloadPrompt)
      return;
    this._isRefreshing = true;
    if (MessageBox.Show("Do you wish to reload the AR/AP for the current entity?", "Reload?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      this.ReLoad();
    else
      this.Clear();
    this._isRefreshing = false;
  }

  protected void Post_ShareCommand()
  {
    InsuranceTransaction transactionPostShare;
    try
    {
      transactionPostShare = this.CreateTransactionPost_Share();
    }
    catch (formTransactionBuilder.TransactionCanceledException ex)
    {
      return;
    }
    if (this.AutoPost || !this.radioCashDisbursement.Checked)
      this.PostTransactionPublic(transactionPostShare, this.ReinstatementList, this.HasClaims, this._isSummaryPrintingRequired, this.lblbBankCurrency.Text, this._bankCurrency, ((UltraToggleEditorBase) this.checkBankCurrency).Checked, new Action(this.DoWishToReload));
    else
      this.CaptureTransactionForApproval(transactionPostShare);
  }

  protected virtual bool AutoPost => true;

  protected virtual void ChildCaptureTransactionForApproval(
    InsuranceTransaction trans,
    SortedList reinstatementList,
    bool hasClaims,
    bool summaryPrintingRequired,
    string currencyText,
    string bankCurrency,
    bool checkBankCurrencyChecked)
  {
    throw new NotImplementedException("If you are capturing transactions for approval you must implement custom logic to do so at this time.");
  }

  private void CaptureTransactionForApproval(InsuranceTransaction trans)
  {
    this.ChildCaptureTransactionForApproval(trans, this.ReinstatementList, this.HasClaims, this._isSummaryPrintingRequired, this.lblbBankCurrency.Text, this._bankCurrency, ((UltraToggleEditorBase) this.checkBankCurrency).Checked);
    this.DoWishToReload();
  }

  public void PostTransactionPublic(
    InsuranceTransaction trans,
    SortedList reinstatementList,
    bool hasClaims,
    bool summaryPrintingRequired,
    string currencyText,
    string bankCurrency,
    bool checkBankCurrencyChecked,
    Action reload = null)
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand sqlCommand = new SqlCommand("", connection))
      {
        try
        {
          sqlCommand.Connection.Open();
          sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
          if ((trans.Credits.Count == 0 || trans.Debits.Count == 0) && trans.FinancedReceivables.Count == 0 && !hasClaims)
          {
            this.AfterPostTransaction(-1, sqlCommand);
            this.AfterPostTransaction(trans, sqlCommand);
            if (sqlCommand.Transaction == null)
              throw new formTransactionBuilder.TransactionCanceledException();
            sqlCommand.Transaction.Commit();
          }
          else
          {
            this.PostFutureTransactions(sqlCommand);
            if (trans.IsBalanced())
            {
              trans.HasClaims = hasClaims;
              if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
                trans.Save((DbTransaction) sqlCommand.Transaction);
              else
                trans.Save(sqlCommand);
              this.AfterPostTransaction(trans.TransactionNumber, sqlCommand);
              this.AfterPostTransaction(trans, sqlCommand);
              if (sqlCommand.Transaction == null)
                throw new formTransactionBuilder.TransactionCanceledException();
              sqlCommand.Transaction.Commit();
              CurrentUser.Instance.LogAction($"Posted transaction #{trans.TransactionNumber}", "Accounting Logs");
              if (reinstatementList != null && reinstatementList.Count != 0)
                formTransactionBuilder.LoadReinstatements(trans.TransactionNumber, reinstatementList);
              string text = "Do you wish to print a payment summary at this time?";
              if (summaryPrintingRequired && MessageBox.Show(text, "Posting Successful!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes && trans.TransactionsCreated.Count != 0)
              {
                for (int index = 0; index < trans.TransactionsCreated.Count; ++index)
                  PayableServices.PrintPaymentSummary((int) trans.TransactionsCreated[index]);
              }
            }
            else
            {
              if (sqlCommand.Transaction != null)
                sqlCommand.Transaction.Rollback();
              int num = (int) MessageBox.Show("The transation you are trying to post does not balance and cannot be posted.", "Unbalanced Transaction Cannot Post!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          }
          if (!currencyText.ToString().Equals("Currency: USD", StringComparison.OrdinalIgnoreCase) & checkBankCurrencyChecked)
            DefaultDatabase.ExecuteNonQuery("spFin_ApplyBankCurrency", new object[4]
            {
              (object) "@transactionNumber",
              (object) trans.TransactionNumber,
              (object) "@currencyCode",
              (object) bankCurrency
            });
          if (reload == null)
            return;
          reload();
        }
        catch (NegativeCheckException ex)
        {
          if (sqlCommand.Transaction != null)
            sqlCommand.Transaction.Rollback();
          int num = (int) MessageBox.Show("The transaction you are trying to post will result in a negative check to the finance company, please modify the amount to ensure the check amount is greater than zero!", "Invalid Check Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        catch (formTransactionBuilder.TransactionCanceledException ex)
        {
        }
        catch (Exception ex)
        {
          if (sqlCommand.Transaction != null)
            sqlCommand.Transaction.Rollback();
          throw;
        }
        finally
        {
          if (sqlCommand.Connection.State != ConnectionState.Closed)
            sqlCommand.Connection.Close();
        }
      }
    }
  }

  private void PostFutureTransactions()
  {
    foreach (InsuranceTransaction insuranceTransaction in this.FutureTransactions.Values)
    {
      if (insuranceTransaction.IsBalanced())
      {
        if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
          insuranceTransaction.SaveBulk();
        else
          insuranceTransaction.Save();
      }
      this.AfterPostTransaction(insuranceTransaction.TransactionNumber);
    }
  }

  private void PostFutureTransactions(SqlCommand cmd)
  {
    foreach (InsuranceTransaction transaction in this.FutureTransactions.Values)
    {
      if (!transaction.IsBalanced())
        throw new InvalidOperationException("A future transaction created by this transaction would not balance and therefore cannot be created.");
      if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
        transaction.Save((DbTransaction) cmd.Transaction);
      else
        transaction.Save(cmd);
      this.AfterPostTransaction(transaction.TransactionNumber, cmd);
      this.AfterPostTransaction(transaction, cmd);
      if (cmd.Transaction == null)
        throw new formTransactionBuilder.TransactionCanceledException();
      CurrentUser.Instance.LogAction($"Posted transaction #{transaction.TransactionNumber}", "Accounting Logs");
    }
  }

  private InsuranceTransaction CreateTransactionPost_Share()
  {
    this.ConfirmIsReturnPremium();
    InsuranceTransaction transaction = this.CreateTransaction();
    if (transaction == null)
      throw new formTransactionBuilder.TransactionCanceledException();
    transaction.NumberOfClaimsReceived = this.NumberOfClaimsReceived;
    if (this._searchType != formTransactionSearch.SearchTypes.None || this._searchType != formTransactionSearch.SearchTypes.Receivables)
    {
      this.AddNonPayableFeesToTransaction(transaction);
      transaction.BulkAPPostTableName = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled") ? string.Empty : this.PostAPExcel();
    }
    transaction.IsReturnPremium = this.chkReturnPremium.Checked;
    return this.AddUnaccountedTransactions(transaction) ? transaction : throw new formTransactionBuilder.TransactionCanceledException();
  }

  protected virtual void AfterPostTransaction(int transactionNumber)
  {
  }

  protected virtual void AfterPostTransaction(int transactionNumber, SqlCommand cmd)
  {
  }

  protected virtual void AfterPostTransaction(InsuranceTransaction transaction, SqlCommand command)
  {
  }

  private static void LoadReinstatements(int transactionNumber, SortedList reinstatementList)
  {
    using (formReceivableReinstatements objectTypeAs = ObjectFactory.Instance.CreateObjectTypeAs<formReceivableReinstatements>(typeof (formReceivableReinstatements), (object) reinstatementList, (object) transactionNumber))
    {
      int num = (int) objectTypeAs.ShowDialog();
    }
  }

  protected MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType GetTransactionType()
  {
    MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType transactionType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType.None;
    if (this._searchType == formTransactionSearch.SearchTypes.PayablesReceivables)
    {
      if (this.radioCashReceipt.Checked)
        return this.chkReturnPremium.Checked ? MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType.PayableReturnPremium : MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType.Receivable;
      if (this.radioCashDisbursement.Checked)
        return this.chkReturnPremium.Checked ? MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType.ReceivableReturnPremium : MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType.Payable;
    }
    else if (this._searchType == formTransactionSearch.SearchTypes.Payables)
    {
      if (this.radioCashReceipt.Checked)
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType.PayableReturnPremium;
      if (this.radioCashDisbursement.Checked)
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType.Payable;
    }
    else if (this._searchType == formTransactionSearch.SearchTypes.Receivables)
    {
      if (this.radioCashReceipt.Checked)
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType.Receivable;
      if (this.radioCashDisbursement.Checked)
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.AccountingTransactionType.ReceivableReturnPremium;
    }
    return transactionType;
  }

  protected virtual void AddInterCompanyTransactionDetailsToTransaction(InsuranceTransaction trans)
  {
    int num = int.Parse(this.comboBankAccount.Value.ToString());
    if (this._interCompanyTransfers == null || this._interCompanyTransfers.Count == 0)
      return;
    foreach (InterCompanyTransfer interCompanyTransfer in (CollectionBase) this._interCompanyTransfers)
    {
      int glAccountId1;
      int glAccountId2;
      if (interCompanyTransfer.TransactionType.ToUpper() == "CREDIT")
      {
        glAccountId1 = num;
        glAccountId2 = interCompanyTransfer.GlAccountId;
      }
      else
      {
        glAccountId1 = interCompanyTransfer.GlAccountId;
        glAccountId2 = num;
      }
      Decimal transactionTotal = Math.Abs(interCompanyTransfer.Amount);
      CostCenterAllocationCollection withAllocation1 = CostCenterAllocationCollection.CreateWithAllocation(interCompanyTransfer.CostCenterId, -transactionTotal);
      CostCenterAllocationCollection withAllocation2 = CostCenterAllocationCollection.CreateWithAllocation(interCompanyTransfer.CostCenterId, transactionTotal);
      trans.Credits.Add(this.CreateNonInvoiceTransactionDetail(interCompanyTransfer.Amount, glAccountId1, withAllocation1, postingComments: interCompanyTransfer.Comments));
      trans.Debits.Add(this.CreateNonInvoiceTransactionDetail(interCompanyTransfer.Amount, glAccountId2, withAllocation2, postingComments: interCompanyTransfer.Comments));
    }
  }

  protected virtual InsuranceTransaction CreateTransaction()
  {
    int bankGlAccountId = int.Parse(this.comboBankAccount.Value.ToString());
    InsuranceTransaction objectAs = ObjectFactory.Instance.CreateObjectAs<InsuranceTransaction>((object) CurrentUser.Instance.UserGUID, (object) this.GetTransactionType(), (object) this._glCompanyId);
    objectAs.BankGLAccountId = bankGlAccountId;
    this.PopulateTransHeaderData(objectAs);
    if (this._searchType == formTransactionSearch.SearchTypes.Payables || this._searchType == formTransactionSearch.SearchTypes.PayablesReceivables)
      this.AddPayableTransactionDetails(objectAs);
    if (this._searchType == formTransactionSearch.SearchTypes.Receivables || this._searchType == formTransactionSearch.SearchTypes.PayablesReceivables)
    {
      this.CreateFinancedReturnCollection();
      if (this.radioCashDisbursement.Checked && !this.SetFinancedReceivables(objectAs))
        return (InsuranceTransaction) null;
      this.AddReceivableTransactionDetails(objectAs);
    }
    this.AddPostAppliedWorkingDepositDetailsToTransaction(objectAs);
    this.AddInterCompanyTransactionDetailsToTransaction(objectAs);
    if (this.radioCashDisbursement.Checked)
    {
      if (!this.CreateDisbursementReturnPremiumHeader(objectAs, bankGlAccountId))
        return (InsuranceTransaction) null;
    }
    else
      this.SetCashReceiptFields(objectAs);
    formTransactionBuilder.InsuranceTransactionCreatedDelegate transactionCreated = this.InsuranceTransactionCreated;
    if (transactionCreated != null)
      transactionCreated(objectAs);
    return objectAs;
  }

  private void SetCashReceiptFields(InsuranceTransaction insuranceTransaction)
  {
    insuranceTransaction.CheckNumber = ((Control) this.txtCheckNumber).Text;
    if (((Control) this.txtCheckFrom).Tag != null || ((Control) this.txtCheckFrom).Text != string.Empty)
      insuranceTransaction.ReceivedFromGuid = new Guid(((Control) this.txtCheckFrom).Tag.ToString());
    insuranceTransaction.RemitterGuid = this._entityGuid;
    insuranceTransaction.ReceivedDate = this.dateTimeReceivedDate.DateTime;
    insuranceTransaction.DepositDate = this.dateTimeDepositDate.DateTime;
    insuranceTransaction.CheckAmount = Decimal.Parse(((Control) this.txtCheckAmount).Text, NumberStyles.Any);
    insuranceTransaction.IsCreditCard = ((UltraToggleEditorBase) this.checkCreditCard).Checked;
  }

  private bool SetFinancedReceivables(InsuranceTransaction transaction)
  {
    if (this.FinancedReceivables.Count > 0)
    {
      formFinancedReceivables financedReceivables = new formFinancedReceivables(ref this._financedReceivables);
      if (financedReceivables.ShowDialog() == DialogResult.Cancel)
      {
        financedReceivables.Dispose();
        return false;
      }
      financedReceivables.Dispose();
    }
    if (this.FinancedReceivables.HasSelectedReturns())
      transaction.financedReceivables = this.FinancedReceivables;
    return true;
  }

  protected event formTransactionBuilder.InsuranceTransactionCreatedDelegate InsuranceTransactionCreated;

  protected virtual MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PaymentMethod GetTransactionPaymentMethod(
    int bankGlAccountId)
  {
    switch (this.GetCharTransactionPaymentMethod())
    {
      case "A":
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PaymentMethod.AutoEFT;
      case "C":
        if (!Methods.CanBankCreateChecks(bankGlAccountId))
          throw new InvalidOperationException("The bank account selected cannot create checks.");
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PaymentMethod.Check;
      case "D":
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PaymentMethod.ACH;
      case "H":
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PaymentMethod.ACH;
      case "M":
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PaymentMethod.ManualTransfer;
      case "O":
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PaymentMethod.Offset;
      default:
        return MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PaymentMethod.Check;
    }
  }

  protected virtual bool CreateDisbursementReturnPremiumHeader(
    InsuranceTransaction tran,
    int bankGlAccountId)
  {
    using (formPayeeAddressSelection f = new formPayeeAddressSelection(this._entityGuid))
    {
      try
      {
        if (f.ShowDialog() != DialogResult.OK)
          return false;
        string payeeCheckName = this.GetPayeeCheckName(f);
        string transactionPaymentMethod = this.GetCharTransactionPaymentMethod();
        tran.CheckData = new CheckInformation(transactionPaymentMethod[0], this._entityGuid, this.dateTimeCheckDate.DateTime, new GLAccount(bankGlAccountId), payeeCheckName, f.Address1, f.Address2, f.City, f.State, f.ZipCode, f.ZipPlus, string.Empty, f.CheckMemo);
        tran.CheckDate = this.dateTimeCheckDate.DateTime;
        tran.PaymentMethodChar = transactionPaymentMethod[0];
        if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableMultiACHSettings"))
        {
          CheckInformation checkData = tran.CheckData;
          BankAccountPaymentTypeDto selectedItem = this._paymentMethodComboModel.SelectedItem;
          int settingsAccountId = selectedItem != null ? selectedItem.AchSettingsAccountId : 0;
          checkData.AchSettingsAccountID = settingsAccountId;
        }
        this._isSummaryPrintingRequired = true;
      }
      catch
      {
        return false;
      }
    }
    tran.RemitterGuid = this._entityGuid;
    tran.CheckAmount = Decimal.Parse(((Control) this.txtPayAmount).Text, NumberStyles.Currency);
    tran.PayeeGuid = this._entityGuid;
    tran.CheckDate = this.dateTimeCheckDate.DateTime;
    return true;
  }

  protected virtual string GetPayeeCheckName(formPayeeAddressSelection f) => f.PayeeName;

  private void PopulateTransHeaderData(InsuranceTransaction trans)
  {
    if (trans == null)
      return;
    trans.IsReturnPremium = this.chkReturnPremium.Checked;
    if (this.radioCashDisbursement.Checked)
      trans.PostDate = this.dateTimeCheckDate.DateTime;
    else if (this.radioCashReceipt.Checked)
      trans.PostDate = this.dateTimeDepositDate.DateTime;
    trans.TransactionComments = ((Control) this.txtPostingMemo).Text;
  }

  private DateTime GetPostDate(UltraGridRow row)
  {
    DateTime result;
    if (!DateTime.TryParse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.PostDate].Value.ToString(), out result))
      result = DateTime.Today;
    return result.Date;
  }

  private InsuranceTransaction CreateFutureInsuranceTransaction(
    DateTime postDate,
    int bankGlAccountId)
  {
    InsuranceTransaction objectAs = ObjectFactory.Instance.CreateObjectAs<InsuranceTransaction>((object) CurrentUser.Instance.UserGUID, (object) this.GetTransactionType(), (object) this._glCompanyId);
    this.PopulateTransHeaderData(objectAs);
    this.SetCashReceiptFields(objectAs);
    objectAs.BankGLAccountId = bankGlAccountId;
    objectAs.PostDate = postDate;
    objectAs.HasClaims = this.HasClaims;
    return objectAs;
  }

  protected virtual void AddReceivableTransactionDetails(InsuranceTransaction trans)
  {
    bool setting1 = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ReceivableReinstateRequiresFullPayment");
    bool setting2 = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("PostFutureInvoicesToUnacct");
    foreach (UltraGridBand band in ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands)
    {
      band.ColumnFilters.ClearAllFilters();
      band.ColumnFilters[0].FilterConditions.Add((FilterCondition) new AccountsReceivableFilterCondition());
    }
    this.FutureTransactions = new Dictionary<DateTime, InsuranceTransaction>();
    foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridReceivables).Rows.GetFilteredInNonGroupByRows())
    {
      int bankGlAccountId = int.Parse(this.comboBankAccount.Value.ToString());
      int invoiceNumber = int.Parse(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value.ToString());
      int chargeCode = int.Parse(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ChargeCode].Value.ToString());
      Guid companyLineGuid = new Guid(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].Value.ToString());
      DateTime postDate = this.GetPostDate(filteredInNonGroupByRow);
      if (!this.FinancedReceivables.IsItemSelected(invoiceNumber, chargeCode, companyLineGuid))
      {
        Decimal num = formTransactionBuilder.ParseDecimalValue(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ArApplied]);
        Decimal decimalValue1 = formTransactionBuilder.ParseDecimalValue(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ExchApplied]);
        Decimal decimalValue2 = formTransactionBuilder.ParseDecimalValue(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.UnaccountedForApplied]);
        if (((!(postDate > trans.PostDate.Date) ? 0 : (this.radioCashReceipt.Checked ? 1 : 0)) & (setting2 ? 1 : 0)) != 0)
        {
          if (!this.FutureTransactions.ContainsKey(postDate))
            this.FutureTransactions.Add(postDate, this.CreateFutureInsuranceTransaction(postDate, bankGlAccountId));
          InsuranceTransaction futureTransaction = this.FutureTransactions[postDate];
          this.AddReceivableCreditDebitToTransaciton(futureTransaction, filteredInNonGroupByRow, bankGlAccountId, formTransactionBuilder.ArApGridColumnKeys.Argl, num);
          this.AddReceivableCreditDebitToTransaciton(futureTransaction, filteredInNonGroupByRow, bankGlAccountId, formTransactionBuilder.ArApGridColumnKeys.Uagl, -num);
          decimalValue2 += num;
          num = 0M;
        }
        if (num != 0M)
        {
          this.SetOnPostFlags(setting1, filteredInNonGroupByRow, invoiceNumber, num);
          this.AddReceivableCreditDebitToTransaciton(trans, filteredInNonGroupByRow, bankGlAccountId, formTransactionBuilder.ArApGridColumnKeys.Argl, num);
        }
        if (decimalValue1 != 0M)
          this.AddReceivableCreditDebitToTransaciton(trans, filteredInNonGroupByRow, bankGlAccountId, formTransactionBuilder.ArApGridColumnKeys.Exgl, decimalValue1);
        if (decimalValue2 != 0M)
          this.AddReceivableCreditDebitToTransaciton(trans, filteredInNonGroupByRow, bankGlAccountId, formTransactionBuilder.ArApGridColumnKeys.Uagl, decimalValue2);
      }
    }
  }

  private void AddPayableTransactionDetails(InsuranceTransaction trans)
  {
    int bankGlAccountId = int.Parse(this.comboBankAccount.Value.ToString());
    foreach (UltraGridBand band in ((UltraGridBase) this.gridPayables).DisplayLayout.Bands)
    {
      band.ColumnFilters.ClearAllFilters();
      band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.ApApplied].FilterConditions.Add((FilterComparisionOperator) 1, (object) 0);
      band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.ApApplied].FilterConditions.Add((FilterComparisionOperator) 1, FilterCondition.BlankCellValue);
      band.ColumnFilters.LogicalOperator = (FilterLogicalOperator) 0;
    }
    foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridPayables).Rows.GetFilteredInNonGroupByRows())
    {
      Decimal decimalValue = formTransactionBuilder.ParseDecimalValue(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.ApApplied]);
      if (decimalValue != 0M)
      {
        Guid guid = new Guid(filteredInNonGroupByRow.Cells[formTransactionBuilder.ArApGridColumnKeys.PayeeGuid].Value.ToString());
        this.AddPayableCreditDebitToTransaction(trans, filteredInNonGroupByRow, bankGlAccountId, formTransactionBuilder.ArApGridColumnKeys.Apgl, decimalValue, guid, guid);
      }
    }
  }

  private void AddPayableCreditDebitToTransaction(
    InsuranceTransaction insuranceTransaction,
    UltraGridRow row,
    int bankGlAccountId,
    string otherBankAccountRowId,
    Decimal amount,
    Guid payeeGuid,
    Guid entityGuid)
  {
    int negativeAmountCreditAcount = int.Parse(row.Cells[otherBankAccountRowId].Value.ToString());
    this.AddCreditDebitToTransaction(insuranceTransaction, row, bankGlAccountId, negativeAmountCreditAcount, amount, payeeGuid, entityGuid);
  }

  protected void AddReceivableCreditDebitToTransaciton(
    InsuranceTransaction insuranceTransaction,
    UltraGridRow row,
    int bankGlAccountId,
    string otherBankAccountRowId,
    Decimal amount)
  {
    int positiveAmountCreditAccount = int.Parse(row.Cells[otherBankAccountRowId].Value.ToString());
    this.AddCreditDebitToTransaction(insuranceTransaction, row, positiveAmountCreditAccount, bankGlAccountId, amount, Guid.Empty, this._entityGuid);
  }

  protected void AddCreditDebitToTransaction(
    InsuranceTransaction insuranceTransaction,
    UltraGridRow row,
    int positiveAmountCreditAccount,
    int negativeAmountCreditAcount,
    Decimal amount,
    Guid payeeGuid,
    Guid entityGuid)
  {
    bool flag = amount > 0M;
    int glAccountId1 = flag ? positiveAmountCreditAccount : negativeAmountCreditAcount;
    int glAccountId2 = flag ? negativeAmountCreditAcount : positiveAmountCreditAccount;
    int costCenterId = int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.CostCenterId].Value.ToString());
    Decimal transactionTotal = Math.Abs(amount);
    CostCenterAllocationCollection withAllocation1 = CostCenterAllocationCollection.CreateWithAllocation(costCenterId, -transactionTotal);
    CostCenterAllocationCollection withAllocation2 = CostCenterAllocationCollection.CreateWithAllocation(costCenterId, transactionTotal);
    insuranceTransaction.Credits.Add(this.ParseTransactionDetailFromRow(row, amount, withAllocation1, glAccountId1, payeeGuid, entityGuid));
    insuranceTransaction.Debits.Add(this.ParseTransactionDetailFromRow(row, amount, withAllocation2, glAccountId2, payeeGuid, entityGuid));
  }

  protected virtual TransactionDetail ParseTransactionDetailFromRow(
    UltraGridRow row,
    Decimal amount,
    CostCenterAllocationCollection costCenterAllocation,
    int glAccountId,
    Guid payeeGuid,
    Guid entityGuid)
  {
    return new TransactionDetail()
    {
      InvoiceNumber = int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value.ToString()),
      ChargeCode = int.Parse(row.Cells[formTransactionBuilder.ArApGridColumnKeys.ChargeCode].Value.ToString()),
      PurchaseOrderNumber = 0,
      ExpenseCode = 0,
      AppliedFrom = 0,
      ExchangeFrom = 0,
      CompanyLineGuid = new Guid(row.Cells[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].Value.ToString()),
      PayeeGuid = payeeGuid,
      Amount = Math.Abs(amount),
      CostCenterAllocations = costCenterAllocation,
      EntityGuid = entityGuid,
      GLAccountId = glAccountId
    };
  }

  private TransactionDetail CreateNonInvoiceTransactionDetail(
    Decimal nonInvoiceAmount,
    int glAccountId,
    CostCenterAllocationCollection costCenterAllocation,
    int appliedFrom = 0,
    string postingComments = null)
  {
    int appliedFrom1 = appliedFrom;
    int glAccountId1 = glAccountId;
    Guid empty = Guid.Empty;
    Guid entityGuid1 = this._entityGuid;
    Decimal transactionAmount = Math.Abs(nonInvoiceAmount);
    Guid entityGuid2 = this._entityGuid;
    CostCenterAllocationCollection allocationCollection = costCenterAllocation;
    string postingComments1 = postingComments;
    CostCenterAllocationCollection allocations = allocationCollection;
    return new TransactionDetail(0, 0, 0, 0, appliedFrom1, 0, glAccountId1, empty, entityGuid1, transactionAmount, entityGuid2, postingComments1, allocations);
  }

  private static TransactionDetail CreateNonPayableTransactionDetail(
    int account,
    CostCenterAllocationCollection costCenterAllocation,
    NonPayableFee nonFee)
  {
    return new TransactionDetail(nonFee.InvoiceNumber, nonFee.ChargeCode, 0, 0, 0, 0, account, nonFee.CompanyLineGuid, Guid.Empty, Math.Abs(nonFee.Amount), Guid.Empty, costCenterAllocation);
  }

  private void SetOnPostFlags(
    bool requireFullPaymentToReinstate,
    UltraGridRow row,
    int invoiceNumber,
    Decimal arApplied)
  {
    string key = row.Cells[formTransactionBuilder.ArApGridColumnKeys.QuoteId].Value.ToString();
    if (row.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrentStatus].Value.ToString() == "Cancelled" && !this._afterCancelPay.Contains((object) key))
      this._afterCancelPay.Add((object) key);
    Decimal decimalValue = formTransactionBuilder.ParseDecimalValue(row.Cells[formTransactionBuilder.ArApGridColumnKeys.NetDue]);
    if (!requireFullPaymentToReinstate || arApplied == decimalValue)
    {
      if (!row.Cells[formTransactionBuilder.ArApGridColumnKeys.CurrentStatus].Value.ToString().Contains("Notice of Cancellation") || !PolicyServices.IsUnderNotice(invoiceNumber) || !this.ShouldProcessReinstatement(row.Cells) || this.ReinstatementList.ContainsKey((object) key))
        return;
      this.ReinstatementList.Add((object) key, (object) invoiceNumber);
    }
    else
    {
      if (this._partialPay.Contains((object) key))
        return;
      this._partialPay.Add((object) key);
    }
  }

  protected static Decimal ParseDecimalValue(UltraGridCell cell)
  {
    return cell.Value != null && !cell.Value.ToString().Equals(string.Empty) ? Decimal.Parse(cell.Value.ToString(), NumberStyles.Currency) : 0M;
  }

  protected virtual bool ShouldProcessReinstatement(CellsCollection cells) => true;

  protected bool CheckFormViewState()
  {
    if (!this.radioReceivableChipDownView.Checked && !this.radioPayableChipDownView.Checked)
      return true;
    int num = (int) MessageBox.Show("You must be in either 'Summary View' or 'Detail View' to complete this operation.", "Posting Not Allowed When in 'Chip Down' View!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    if (this.radioPayableChipDownView.Checked)
      ((UltraTabControlBase) this.tabTransactions).SelectedTab = this.tabPagePayable.Tab;
    else
      ((UltraTabControlBase) this.tabTransactions).SelectedTab = this.tabPageReceivable.Tab;
    return false;
  }

  private bool ValidateData()
  {
    if (this.radioCashDisbursement.Checked)
    {
      if (((Control) this.txtCheckAmount).Text == string.Empty)
      {
        int num = (int) MessageBox.Show("You must enter a check number to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (!(((Control) this.txtCheckNumber).Text == string.Empty))
        return true;
      int num1 = (int) MessageBox.Show("You must enter a check number to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!this.radioCashReceipt.Checked)
      return true;
    if (((Control) this.txtPayAmount).Text == string.Empty)
    {
      int num = (int) MessageBox.Show("You must enter a payment amount number to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!this.PaymentMethodComboMissingSelectedIndex())
      return true;
    int num2 = (int) MessageBox.Show("You must select a payment method to continue.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected virtual bool PaymentMethodComboMissingSelectedIndex()
  {
    return MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableMultiACHSettings") ? this._paymentMethodComboModel.SelectedItem == null : this.comboPaymentMethods.SelectedIndex == -1;
  }

  protected virtual bool PaymentMethodComboNeedsSelection()
  {
    return MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableMultiACHSettings") ? this._paymentMethodComboModel.SelectedItem == null : ((UltraDropDownBase) this.comboPaymentMethods).SelectedRow == null;
  }

  protected virtual void ResetPaymentMethodSelection()
  {
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableMultiACHSettings"))
      this.SelectDefaultPaymentMethodComboValue();
    else
      this.comboPaymentMethods.SelectedIndex = -1;
  }

  protected virtual void SetComboPaymentMethod(string paymentMethod)
  {
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableMultiACHSettings"))
    {
      BankAccountPaymentTypeDto accountPaymentTypeDto = this._paymentMethodComboModel.Items.FirstOrDefault<BankAccountPaymentTypeDto>((System.Func<BankAccountPaymentTypeDto, bool>) (m => m.PaymentMethodId.ToString().Equals(paymentMethod, StringComparison.OrdinalIgnoreCase)));
      if (accountPaymentTypeDto == null)
        return;
      this._paymentMethodComboModel.SelectedItem = accountPaymentTypeDto;
    }
    else
      this.comboPaymentMethods.Value = (object) paymentMethod;
  }

  protected virtual string GetCharTransactionPaymentMethod()
  {
    return !MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("EnableMultiACHSettings") ? this.comboPaymentMethods.Value.ToString().ToUpper() : this._paymentMethodComboModel.SelectedItem?.PaymentMethodId.ToString().ToUpper() ?? string.Empty;
  }

  private void AddNonPayableFeesToTransaction(InsuranceTransaction trans)
  {
    GlCompany glCompany = AccountingCache.Instance.GlCompany(this._glCompanyId);
    if (glCompany.OfficeAccountingMethod != Utilities.AccountingMethod.Cash || glCompany.CommissionReconciliation != Utilities.CommissionReconciliation.Payables || this.NonPayableFees.Count == 0 || !(this.NonPayableFees.SelectedNonPayableFeeTotal() != 0M))
      return;
    foreach (NonPayableFee nonPayableFee in (CollectionBase) this.NonPayableFees)
    {
      if (nonPayableFee.IsSelected)
      {
        int glAccountId1 = glCompany.FeesIncomeAccount.GLAccountID;
        int glAccountId2 = glCompany.CommissionsPayableAccount.GLAccountID;
        int account1;
        int account2;
        if (nonPayableFee.Amount > 0M)
        {
          account1 = glAccountId1;
          account2 = glAccountId2;
        }
        else
        {
          account1 = glAccountId2;
          account2 = glAccountId1;
        }
        Decimal transactionTotal = Math.Abs(nonPayableFee.Amount);
        CostCenterAllocationCollection withAllocation1 = CostCenterAllocationCollection.CreateWithAllocation(nonPayableFee.CostCenterID, -transactionTotal);
        CostCenterAllocationCollection withAllocation2 = CostCenterAllocationCollection.CreateWithAllocation(nonPayableFee.CostCenterID, transactionTotal);
        trans.Credits.Add(formTransactionBuilder.CreateNonPayableTransactionDetail(account1, withAllocation1, nonPayableFee));
        trans.Debits.Add(formTransactionBuilder.CreateNonPayableTransactionDetail(account2, withAllocation2, nonPayableFee));
      }
    }
  }

  private void formTransactionBuilder_Load(object sender, EventArgs e)
  {
    ((UltraDropDownBase) this.comboPaymentMethods).DropDownWidth = 300;
    this.Clear();
  }

  private void gridNonPayableFees_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    ColumnsCollection columns = ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Bands[0].Columns;
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.IsSelected].Header).Appearance.TextHAlign = (HAlign) 2;
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.IsSelected].Header).VisiblePosition = 0;
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.IsSelected].Header).Caption = "Select";
    columns[formTransactionBuilder.ArApGridColumnKeys.IsSelected].CellActivation = (Activation) 0;
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].Header).VisiblePosition = 1;
    columns[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].CellActivation = (Activation) 3;
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].Header).Caption = "Policy #";
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNumber].Header).VisiblePosition = 2;
    columns[formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNumber].CellActivation = (Activation) 3;
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.OfficeInvoiceNumber].Header).Caption = "Invoice #";
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.InsuredName].Header).VisiblePosition = 3;
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.InsuredName].Header).Caption = "Insured";
    columns[formTransactionBuilder.ArApGridColumnKeys.InsuredName].CellActivation = (Activation) 3;
    columns[formTransactionBuilder.ArApGridColumnKeys.Amount].CellAppearance.TextHAlign = (HAlign) 3;
    columns[formTransactionBuilder.ArApGridColumnKeys.Amount].Format = "c";
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.Amount].Header).Appearance.TextHAlign = (HAlign) 3;
    columns[formTransactionBuilder.ArApGridColumnKeys.Amount].CellActivation = (Activation) 3;
    ((HeaderBase) columns[formTransactionBuilder.ArApGridColumnKeys.Amount].Header).VisiblePosition = 4;
    columns[formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid].Hidden = true;
    columns[formTransactionBuilder.ArApGridColumnKeys.ChargeCode].Hidden = true;
    columns["invoicenumber"].Hidden = true;
    columns[formTransactionBuilder.ArApGridColumnKeys.ControlNumber].Hidden = true;
    columns[formTransactionBuilder.ArApGridColumnKeys.CostCenterId].Hidden = true;
  }

  private void AdditionalOffsetToolManager_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridAdditionalOffsets).Rows).Count == 0;
    if (!(((ControlUIElementBase) ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow), true) is UltraGridRow context))
      return;
    context.Activate();
    ((GridItemBase) context).Selected = true;
  }

  private void InterCompanyAdditionalOffsets()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboCostCenters).Rows).Count == 0)
      this.LoadCostCenters(this.comboCostCenters);
    this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyId);
    ((UltraTabControlBase) this.tabTransactions).Tabs["ADDITIONALOFFSETS"].Visible = true;
    ((UltraTabControlBase) this.tabTransactions).SelectedTab = ((UltraTabControlBase) this.tabTransactions).Tabs["ADDITIONALOFFSETS"];
  }

  protected virtual void gridAdditionalOffsets_InitializeLayout(
    object sender,
    InitializeLayoutEventArgs e)
  {
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.HeaderAppearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.TransactionType].Header).VisiblePosition = 0;
    ((HeaderBase) ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.GlAccountShortName].Header).VisiblePosition = 1;
    ((HeaderBase) ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.CostCenterName].Header).VisiblePosition = 2;
    ((HeaderBase) ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.Amount].Header).VisiblePosition = 3;
    ((HeaderBase) ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.Amount].Header).Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.Amount].CellAppearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.Amount].Format = "c";
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.GlAccountId].Hidden = true;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.Comments].Hidden = true;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.CostCenterId].Hidden = true;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.SetTransactionType].Hidden = true;
    ((HeaderBase) ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.TransactionType].Header).Caption = " Transaction Type";
    ((HeaderBase) ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.GlAccountShortName].Header).Caption = "Gl Account";
    ((HeaderBase) ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.CostCenterName].Header).Caption = "Cost Center";
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].ScrollTipField = formTransactionBuilder.ArApGridColumnKeys.Comments;
  }

  protected virtual void AdditionalOffsetToolManager_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((UltraGridBase) this.gridAdditionalOffsets).ActiveRow == null)
      return;
    UltraGridRow activeRow = ((UltraGridBase) this.gridAdditionalOffsets).ActiveRow;
    int position = ((Control) this.gridAdditionalOffsets).BindingContext[(object) this.InterCompanyTransfers].Position;
    if (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.ToUpper() == "DELETE")
    {
      this.InterCompanyTransfers.RemoveAt(position);
      this.ResetInterCompanyControlValues();
      this.CalculateAndDisplayTotal();
    }
    else
    {
      if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.ToUpper() == "EDIT"))
        return;
      ((Control) this.txtComments).Text = this.InterCompanyTransfers[position].Comments;
      this.comboCostCenters.Value = (object) this.InterCompanyTransfers[position].CostCenterId;
      this.dropTreeGLAccounts.SetSelectedNodeByKey(this.InterCompanyTransfers[position].GlAccountId.ToString());
      if (this.InterCompanyTransfers[position].TransactionType == "Credit")
      {
        this.radioCredit.Checked = true;
        ((Control) this.txtAmount).Text = (-1M * this.InterCompanyTransfers[position].Amount).ToString("C");
      }
      else
      {
        this.radioDebit.Checked = true;
        ((Control) this.txtAmount).Text = this.InterCompanyTransfers[position].Amount.ToString("C");
      }
      ((Control) this.btnAdd).Text = "Save";
      ((Control) this.btnCancelChanges).Visible = true;
      this._isAdditonalOffsetInEditMode = true;
    }
  }

  protected virtual void btnAdd_Click(object sender, EventArgs e)
  {
    if (!this.ValidateValues())
      return;
    int glAccountId = this.dropTreeGLAccounts.GLAccountID;
    Decimal num = Decimal.Parse(((Control) this.txtAmount).Text, NumberStyles.Any);
    int costCenter = int.Parse(this.comboCostCenters.Value.ToString());
    string text1 = ((Control) this.txtComments).Text;
    string accountShortName = this.dropTreeGLAccounts.GLAccountShortName;
    Decimal amount = this.radioCredit.Checked ? Math.Abs(num) * -1M : Math.Abs(num);
    string text2 = ((Control) this.comboCostCenters).Text;
    if (!this._isAdditonalOffsetInEditMode)
    {
      this.InterCompanyTransfers.Add(new InterCompanyTransfer(glAccountId, accountShortName, text1, amount, costCenter, text2, this.radioCredit.Checked));
    }
    else
    {
      if (((SparseCollectionBase) this.gridAdditionalOffsets.Selected.Rows).Count == 0)
        this.gridAdditionalOffsets.Selected.Rows[0].Cells[formTransactionBuilder.ArApGridColumnKeys.CostCenterName].Value = (object) text2;
      this.gridAdditionalOffsets.Selected.Rows[0].Cells[formTransactionBuilder.ArApGridColumnKeys.Amount].Value = (object) amount;
      this.gridAdditionalOffsets.Selected.Rows[0].Cells[formTransactionBuilder.ArApGridColumnKeys.GlAccountId].Value = (object) glAccountId;
      this.gridAdditionalOffsets.Selected.Rows[0].Cells[formTransactionBuilder.ArApGridColumnKeys.GlAccountShortName].Value = (object) accountShortName;
      this.gridAdditionalOffsets.Selected.Rows[0].Cells[formTransactionBuilder.ArApGridColumnKeys.CostCenterId].Value = (object) costCenter;
      this.gridAdditionalOffsets.Selected.Rows[0].Cells[formTransactionBuilder.ArApGridColumnKeys.SetTransactionType].Value = (object) this.radioCredit.Checked;
      this.gridAdditionalOffsets.Selected.Rows[0].Cells[formTransactionBuilder.ArApGridColumnKeys.Comments].Value = (object) text1;
      ((Control) this.btnAdd).Text = "Add";
    }
    this.ResetInterCompanyControlValues();
    if (((UltraGridBase) this.gridAdditionalOffsets).DataSource == null)
    {
      ((UltraGridBase) this.gridAdditionalOffsets).DataSource = (object) this._interCompanyTransfers;
      this.AddgridAdditionalOffsetsSummaries();
    }
    this.CalculateAndDisplayTotal();
  }

  protected void AddgridAdditionalOffsetsSummaries()
  {
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Summaries.Add("Total", (SummaryType) 1, ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.Amount], (SummaryPosition) 3);
    ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Override.SummaryFooterAppearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Summaries)
    {
      summary.DisplayFormat = "{0:c}";
      summary.Appearance.TextHAlign = (HAlign) 3;
      summary.Appearance.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    }
  }

  private void btnCancelChanges_Click(object sender, EventArgs e)
  {
    ((Control) this.btnAdd).Text = "Add";
    this._isAdditonalOffsetInEditMode = false;
    this.ResetInterCompanyControlValues();
  }

  public virtual void ResetInterCompanyControlValues()
  {
    this.dropTreeGLAccounts.ResetText();
    this.comboCostCenters.SelectedIndex = -1;
    ((Control) this.txtComments).Text = string.Empty;
    ((Control) this.txtAmount).Text = string.Empty;
    this.radioDebit.Checked = true;
    this._isAdditonalOffsetInEditMode = false;
  }

  private void txtAdditionalOffsetAmount_Validating(object sender, CancelEventArgs e)
  {
    if (((Control) this.txtAmount).Text == string.Empty)
      return;
    if (!Information.IsNumeric((object) ((Control) this.txtAmount).Text))
    {
      int num = (int) MessageBox.Show("Amount must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
      ((Control) this.txtAmount).Text = string.Empty;
    }
    else
      ((Control) this.txtAmount).Text = Decimal.Parse(((Control) this.txtAmount).Text.Replace("$", string.Empty), NumberStyles.Any).ToString("C");
  }

  protected bool ValidateValues()
  {
    if (!this.dropTreeGLAccounts.GLAccountSelected)
    {
      int num = (int) MessageBox.Show("You select a GL account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.txtAmount).Text == string.Empty)
    {
      int num = (int) MessageBox.Show("You must enter an amount to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!Information.IsNumeric((object) ((Control) this.txtAmount).Text))
    {
      int num = (int) MessageBox.Show("Amount must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.comboCostCenters.SelectedIndex == -1)
    {
      int num = (int) MessageBox.Show("You must select a cost center to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.radioCredit.Checked || this.radioDebit.Checked)
      return true;
    int num1 = (int) MessageBox.Show("You must specify either credit or debit to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected void LoadCostCenters(MGASimpleComboBox combo)
  {
    DataSet dataSet = new DataSet();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(new SqlCommand("spFin_GetCostCentersList", new SqlConnection(CurrentUser.Instance.ConnectionString)));
    SqlCommand sqlCommand = (SqlCommand) null;
    try
    {
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) this._glCompanyId);
      sqlDataAdapter.Fill(dataSet);
      ((UltraGridBase) combo).DataSource = (object) dataSet;
      ((UltraGridBase) combo).DataMember = dataSet.Tables[0].TableName;
      ((UltraDropDownBase) combo).DisplayMember = "Name";
      ((UltraDropDownBase) combo).ValueMember = formTransactionBuilder.ArApGridColumnKeys.CostCenterId;
      if (dataSet == null || dataSet.Tables.Count < 1 || dataSet.Tables[0].Rows.Count <= 0)
        return;
      combo.Value = dataSet.Tables[0].Rows[0][0];
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

  [Obsolete("This method is deprecated, please use method with object definition instead.")]
  protected void LogAppliedChanges(string invoiceNumber, string policyNumber)
  {
    this.LogAppliedChanges(invoiceNumber, policyNumber, string.Empty);
  }

  protected void LogAppliedChanges(string invoiceNumber, string policyNumber, string message)
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("Invoice # ");
    stringBuilder.Append(invoiceNumber);
    stringBuilder.Append(" for policy ");
    stringBuilder.Append(policyNumber);
    if (string.IsNullOrEmpty(message))
      stringBuilder.Append(" has been changed or can not be found. The system can not apply the saved/imported worksheet values for this item.");
    else
      stringBuilder.Append(message);
    if (this._reappliedErrors == null)
      this._reappliedErrors = new ArrayList();
    this._reappliedErrors.Add((object) stringBuilder.ToString());
  }

  protected virtual void LogAppliedChanges(
    formTransactionBuilder.ExcelImportType importType,
    formTransactionBuilder.ColumnFilterNames columnFilter,
    string message,
    params object[] detailsObject)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    StringBuilder stringBuilder = new StringBuilder();
    switch (importType)
    {
      case formTransactionBuilder.ExcelImportType.Accounting:
        if (columnFilter == formTransactionBuilder.ColumnFilterNames.OfficeInvoiceNum)
        {
          if (detailsObject.Length >= 1)
          {
            string str1 = detailsObject[0]?.ToString() ?? string.Empty;
            stringBuilder.Append("Invoice #");
            stringBuilder.Append(str1);
            if (detailsObject.Length == 2)
            {
              string str2 = detailsObject[1]?.ToString() ?? string.Empty;
              stringBuilder.Append(" and Policy #");
              stringBuilder.Append(str2);
              break;
            }
            break;
          }
          break;
        }
        string str = detailsObject[0]?.ToString() ?? string.Empty;
        stringBuilder.Append("Policy #");
        stringBuilder.Append(str);
        break;
      case formTransactionBuilder.ExcelImportType.Claims:
        for (int index = 0; index < detailsObject.Length; ++index)
          empty3 = (string) detailsObject[index];
        stringBuilder.Append("Claim # ");
        stringBuilder.Append(empty3);
        break;
    }
    if (string.IsNullOrEmpty(message))
    {
      stringBuilder.Append(" has been changed or can not be found. The system can not apply the saved/imported worksheet values for this item.");
    }
    else
    {
      stringBuilder.Append(" ");
      stringBuilder.Append(message);
    }
    if (this._reappliedErrors == null)
      this._reappliedErrors = new ArrayList();
    this._reappliedErrors.Add((object) stringBuilder.ToString());
  }

  [Obsolete("This method is deprecated, please use method with object definition instead.")]
  protected virtual void LogAppliedChanges(
    formTransactionBuilder.ExcelImportType importType,
    string message,
    params object[] detailsObject)
  {
    string empty1 = string.Empty;
    string empty2 = string.Empty;
    string empty3 = string.Empty;
    StringBuilder stringBuilder = new StringBuilder();
    switch (importType)
    {
      case formTransactionBuilder.ExcelImportType.Accounting:
        for (int index = 0; index < detailsObject.Length; ++index)
        {
          empty1 = (string) detailsObject[index];
          if (index + 1 <= detailsObject.Length)
          {
            empty2 = (string) detailsObject[index + 1];
            ++index;
          }
        }
        stringBuilder.Append("Invoice # ");
        stringBuilder.Append(empty1);
        stringBuilder.Append(" for policy ");
        stringBuilder.Append(empty2);
        break;
      case formTransactionBuilder.ExcelImportType.Claims:
        for (int index = 0; index < detailsObject.Length; ++index)
          empty3 = (string) detailsObject[index];
        stringBuilder.Append("Claim # ");
        stringBuilder.Append(empty3);
        break;
    }
    if (string.IsNullOrEmpty(message))
      stringBuilder.Append(" has been changed or can not be found. The system can not apply the saved/imported worksheet values for this item.");
    else
      stringBuilder.Append(message);
    if (this._reappliedErrors == null)
      this._reappliedErrors = new ArrayList();
    this._reappliedErrors.Add((object) stringBuilder.ToString());
  }

  protected void DisplayReapplyErrors()
  {
    if (this._reappliedErrors == null || this._reappliedErrors.Count <= 0)
      return;
    using (formLoadWorksheetErrors loadWorksheetErrors = new formLoadWorksheetErrors(this._reappliedErrors))
    {
      int num = (int) loadWorksheetErrors.ShowDialog();
    }
  }

  private void formTransactionBuilder_Shown(object sender, EventArgs e)
  {
    if (this.DesignMode || this._isEnchancedPolicySearch || this.IsExcelAutomation)
      return;
    this.LoadNew();
  }

  private void gridNonPayableFees_MouseClick(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left)
      return;
    UltraGridCell context = ((ControlUIElementBase) ((UltraGridBase) (sender as UltraGrid)).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridCell)) as UltraGridCell;
    Decimal num1 = Decimal.Parse(((Control) this.txtNonPayableFees).Text, NumberStyles.Any);
    if (context == null || !(((KeyedSubObjectBase) context.Column).Key == "IsSelected"))
      return;
    Decimal num2 = Decimal.Parse(context.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.Amount].Value.ToString(), NumberStyles.Any);
    ((Control) this.txtNonPayableFees).Text = (!context.Text.Equals("True") ? num1 + num2 : num1 - num2).ToString("c");
  }

  private void btnSearchCheckFrom_Click(object sender, EventArgs e)
  {
    FormSearchEntity formSearchEntity = new FormSearchEntity(MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SearchEntityTypes.All);
    if (formSearchEntity.ShowDialog() != DialogResult.OK)
      return;
    ((Control) this.txtCheckFrom).Text = formSearchEntity.EntityName;
    ((Control) this.txtCheckFrom).Tag = (object) formSearchEntity.EntityGuid;
    this.linkRemoveCheckFrom.Visible = true;
  }

  private void linkRemoveCheckFrom_Click(object sender, EventArgs e)
  {
    ((Control) this.txtCheckFrom).Text = string.Empty;
    ((Control) this.txtCheckFrom).Tag = (object) null;
    this.linkRemoveCheckFrom.Visible = false;
  }

  private void checkToggleCheckRequested_CheckedChanged(object sender, EventArgs e)
  {
    this.ToggleCheckRequested(((UltraToggleEditorBase) this.checkToggleCheckRequested).Checked);
  }

  private void dateTimeToggleCheckRequested_ValueChanged(object sender, EventArgs e)
  {
    if (this.dateTimeToggleCheckRequested.Value == null)
      return;
    this.ToggleCheckRequested(((UltraToggleEditorBase) this.checkToggleCheckRequested).Checked);
  }

  public bool CanReCreateEntity => false;

  public Guid ControlGUID => Guid.Empty;

  public Guid EntityGuid => Guid.Empty;

  public string EntityName => string.Empty;

  public string FriendlyEntityName => string.Empty;

  public bool HasControlGUID => false;

  public bool RecreateEntityInitialize(Guid entityGuid) => false;

  public string RecreateTypeName => this.GetType().ToString();

  private void Print_Payable()
  {
    APreport report = new APreport(new DataView((DataTable) this.dsOpenPayables.OpenPayables, "", formTransactionBuilder.ArApGridColumnKeys.PolicyNumber, DataViewRowState.CurrentRows));
    report.Run();
    new frmPrint((SectionReport) report).Show();
  }

  private void Print_Receivable()
  {
    ARreport report = new ARreport(new DataView((DataTable) this.dsOpenReceivables.OpenReceivables, "", formTransactionBuilder.ArApGridColumnKeys.PolicyNumber, DataViewRowState.CurrentRows));
    report.Run();
    new frmPrint((SectionReport) report).Show();
  }

  protected void LoadAutomation_New()
  {
    ((Control) this.tabTransactions).Show();
    this.chkReturnPremium.Enabled = false;
    this.LoadBankAccounts();
    this.LoadCostCenters(this.comboUnAccountedCostCenter);
    this.LoadCostCenters(this.comboCostCenters);
    this.SetToolBarButtonState(true);
    this.SetToolBarButtonState(this._searchType);
    this.labelCurtain.BringToFront();
    switch (this._searchType)
    {
      case formTransactionSearch.SearchTypes.Payables:
        if (!this._isLoadingSavedWorkSheet)
        {
          this.radioCashDisbursement.Checked = true;
          this.chkReturnPremium.Checked = false;
        }
        this._currentPage = formTransactionBuilder.TabPages.Payable;
        this.LoadPayables();
        this.GetEntityUnAccountedBalance();
        if (this._currentSearchOption.PayableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Bordereau || this._currentSearchOption.PayableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.BordereauPayee)
          this.LoadNonPayableFees();
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Selected = true;
        break;
      case formTransactionSearch.SearchTypes.Receivables:
        if (!this._isLoadingSavedWorkSheet)
        {
          this.radioCashReceipt.Checked = true;
          this.chkReturnPremium.Checked = false;
        }
        this._currentPage = formTransactionBuilder.TabPages.Receivable;
        this.LoadReceivables();
        this.GetEntityUnAccountedBalance();
        ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Selected = true;
        break;
      case formTransactionSearch.SearchTypes.PayablesReceivables:
        if (!this._isLoadingSavedWorkSheet)
        {
          this.chkReturnPremium.Checked = false;
          this.chkReturnPremium.Enabled = true;
        }
        this.LoadPayablesAndReceivables();
        ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Selected = true;
        break;
    }
  }

  protected virtual void gridReceivables_BeforeColumnChooserDisplayed(
    object sender,
    BeforeColumnChooserDisplayedEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = this.radioReceivableChipDownView.Checked;
    List<string> stringList = new List<string>();
    stringList.AddRange((IEnumerable<string>) new string[13]
    {
      formTransactionBuilder.ArApGridColumnKeys.RemitterGuid,
      formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber,
      formTransactionBuilder.ArApGridColumnKeys.Exgl,
      formTransactionBuilder.ArApGridColumnKeys.Apgl,
      formTransactionBuilder.ArApGridColumnKeys.Uagl,
      formTransactionBuilder.ArApGridColumnKeys.ControlNum,
      formTransactionBuilder.ArApGridColumnKeys.CostCenterId,
      formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid,
      formTransactionBuilder.ArApGridColumnKeys.QuoteId,
      formTransactionBuilder.ArApGridColumnKeys.FinanceCompanyGuid,
      formTransactionBuilder.ArApGridColumnKeys.ChargeCode,
      formTransactionBuilder.ArApGridColumnKeys.AccountNumber,
      formTransactionBuilder.ArApGridColumnKeys.ArApplied
    });
    UltraGridBand band = ((UltraGridBase) this.gridReceivables).DisplayLayout.Bands[0];
    if (band != null)
    {
      foreach (UltraGridColumn column in band.Columns)
        column.ExcludeFromColumnChooser = !stringList.Contains(((KeyedSubObjectBase) column).Key) ? (ExcludeFromColumnChooser) 2 : (ExcludeFromColumnChooser) 1;
    }
    ((Form) e.Dialog).FormClosing += new FormClosingEventHandler(this.ReceivableFieldChooserDialog_FormClosing);
  }

  private void ReceivableFieldChooserDialog_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (MessageBox.Show("Do you wish to save your layout changes?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      this.SaveReceivableLayout();
    ((Form) sender).FormClosing -= new FormClosingEventHandler(this.ReceivableFieldChooserDialog_FormClosing);
  }

  private void gridReceivables_AfterColPosChanged(object sender, AfterColPosChangedEventArgs e)
  {
    this.SaveReceivableLayout();
  }

  private void SaveReceivableLayout()
  {
    if (this.radioReceivableChipDownView.Checked)
      return;
    MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SaveLayoutPreference(this.radioReceivableSummaryView.Checked ? "AR_SUMMARYVIEW_v3.lyt" : "AR_DETAILVIEW_v3.lyt", ((UltraGridBase) this.gridReceivables).DisplayLayout);
  }

  protected virtual void gridPayables_BeforeColumnChooserDisplayed(
    object sender,
    BeforeColumnChooserDisplayedEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = this.radioPayableChipDownView.Checked;
    List<string> stringList = new List<string>();
    stringList.AddRange((IEnumerable<string>) new string[13]
    {
      formTransactionBuilder.ArApGridColumnKeys.PayeeGuid,
      formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber,
      formTransactionBuilder.ArApGridColumnKeys.Exgl,
      formTransactionBuilder.ArApGridColumnKeys.Apgl,
      formTransactionBuilder.ArApGridColumnKeys.Uagl,
      formTransactionBuilder.ArApGridColumnKeys.ControlNum,
      formTransactionBuilder.ArApGridColumnKeys.CostCenterId,
      formTransactionBuilder.ArApGridColumnKeys.CompanyLineGuid,
      formTransactionBuilder.ArApGridColumnKeys.MgaPercentRate,
      formTransactionBuilder.ArApGridColumnKeys.PayeePercentRate,
      formTransactionBuilder.ArApGridColumnKeys.ChargeCode,
      formTransactionBuilder.ArApGridColumnKeys.AccountNumber,
      formTransactionBuilder.ArApGridColumnKeys.CheckRequested
    });
    UltraGridBand band = ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0];
    if (band != null)
    {
      foreach (UltraGridColumn column in band.Columns)
        column.ExcludeFromColumnChooser = !stringList.Contains(((KeyedSubObjectBase) column).Key) ? (ExcludeFromColumnChooser) 2 : (ExcludeFromColumnChooser) 1;
    }
    ((Form) e.Dialog).FormClosing += new FormClosingEventHandler(this.PayableFieldChooserDialog_FormClosing);
  }

  private void PayableFieldChooserDialog_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (MessageBox.Show("Do you wish to save your layout changes?", "Save Changes?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      this.SavePayablesLayout();
    ((Form) sender).FormClosing -= new FormClosingEventHandler(this.PayableFieldChooserDialog_FormClosing);
  }

  private void gridPayables_AfterColPosChanged(object sender, AfterColPosChangedEventArgs e)
  {
    this.SavePayablesLayout();
  }

  private void SavePayablesLayout()
  {
    if (this.radioPayableChipDownView.Checked)
      return;
    MGASystems.IMS.Accounting.Core.ClassObjects.Utility.SaveLayoutPreference(this.radioPayableSummaryView.Checked ? "AP_SUMMARYVIEW_v3.lyt" : "AP_DETAILVIEW_v3.lyt", ((UltraGridBase) this.gridPayables).DisplayLayout);
  }

  protected virtual void gridPayables_ClickCellButton(object sender, CellEventArgs e)
  {
    switch (((KeyedSubObjectBase) e.Cell.Column).Key.ToLower())
    {
      case "apapplied":
        this.PayCurrentInFull(this.gridPayables, true);
        break;
      case "officeinvoicenum":
        this.ApplyInvoicePolicyInFull(new int?((int) e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value), (string) null, true);
        break;
      case "policynumber":
        this.ApplyInvoicePolicyInFull(new int?(), e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].Value.ToString(), true);
        break;
    }
  }

  private void ApplyInvoicePolicyInFull(int? invoiceNumber, string policyNumber, bool isPayable)
  {
    UltraGrid grid = isPayable ? this.gridPayables : this.gridReceivables;
    ColumnFiltersCollection filtersCollection = (ColumnFiltersCollection) null;
    foreach (UltraGridBand band in ((UltraGridBase) grid).DisplayLayout.Bands)
    {
      filtersCollection = band.ColumnFilters;
      band.ColumnFilters.ClearAllFilters();
      if (invoiceNumber.HasValue)
        band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].FilterConditions.Add((FilterComparisionOperator) 0, (object) invoiceNumber.Value);
      else if (!string.IsNullOrEmpty(policyNumber))
        band.ColumnFilters[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].FilterConditions.Add((FilterComparisionOperator) 0, (object) policyNumber);
    }
    this.PayAllInFull(grid, isPayable);
    foreach (UltraGridBand band in ((UltraGridBase) grid).DisplayLayout.Bands)
    {
      band.ColumnFilters.ClearAllFilters();
      if (filtersCollection != null & ((DisposableObjectCollectionBase) filtersCollection).Count != 0)
        band.ColumnFilters.CopyFrom(filtersCollection);
    }
  }

  private void gridReceivables_ClickCellButton(object sender, CellEventArgs e)
  {
    switch (((KeyedSubObjectBase) e.Cell.Column).Key.ToLower())
    {
      case "arapplied":
      case "mc_arapplied":
        this.PayCurrentInFull(this.gridReceivables, false);
        break;
      case "officeinvoicenum":
        this.ApplyInvoicePolicyInFull(new int?((int) e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber].Value), (string) null, false);
        break;
      case "policynumber":
        this.ApplyInvoicePolicyInFull(new int?(), e.Cell.Row.Cells[formTransactionBuilder.ArApGridColumnKeys.PolicyNumber].Value.ToString(), false);
        break;
    }
    this.OnReceivableGridClickCellButton(sender, e);
  }

  public event formTransactionBuilder.ReceivableGridClickCellButtonDelegate ReceivableGridClickCellButton;

  protected void OnReceivableGridClickCellButton(object sender, CellEventArgs e)
  {
    formTransactionBuilder.ReceivableGridClickCellButtonDelegate gridClickCellButton = this.ReceivableGridClickCellButton;
    if (gridClickCellButton == null)
      return;
    gridClickCellButton(sender, e);
  }

  public void SetSearchType(
    SearchCriteria sCrit,
    int glCompanyId,
    string entityName,
    formTransactionSearch.SearchTypes searchType)
  {
    this._showZeroReceivableInvoices = sCrit.ShowZeros;
    this._entityGuid = sCrit.EntityGuid;
    this._mainSearchOption = sCrit;
    this._glCompanyId = glCompanyId;
    this._currentSearchOption = this._mainSearchOption;
    ((Control) this.txtEntityName).Text = entityName;
    this._searchType = searchType;
    this.LoadNew();
    this.LoadBankAccounts();
    this.LoadCostCenters(this.comboUnAccountedCostCenter);
    this.LoadCostCenters(this.comboCostCenters);
  }

  private void ReleaseBatchLocks()
  {
    foreach (DataRow row in (InternalDataCollectionBase) this.dsOpenPayables.OpenPayables.DefaultView.ToTable(true, formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber).Rows)
      DefaultDatabase.ExecuteNonQuery("spFin_ReleaseBatchLock", new object[6]
      {
        (object) "@invoiceNum",
        row[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber],
        (object) "@userGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@lockType",
        (object) "P"
      });
    foreach (DataRow row in (InternalDataCollectionBase) this.dsOpenReceivables.OpenReceivables.DefaultView.ToTable(true, formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber).Rows)
      DefaultDatabase.ExecuteNonQuery("spFin_ReleaseBatchLock", new object[6]
      {
        (object) "@invoiceNum",
        row[formTransactionBuilder.ArApGridColumnKeys.InvoiceNumber],
        (object) "@userGuid",
        (object) CurrentUser.Instance.UserGUID,
        (object) "@lockType",
        (object) "R"
      });
  }

  protected virtual void GetBankCurrency(int glAcctId)
  {
    this._bankCurrency = DefaultDatabase.ExecuteDataRow("spFin_GetBankCurrency", new object[2]
    {
      (object) "@glacctid",
      (object) glAcctId
    })[0].ToString();
    this.lblbBankCurrency.Text = $"Currency: {this._bankCurrency}";
  }

  private void checkCreditCard_CheckStateChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.checkCreditCard).CheckState == CheckState.Checked)
      this.labelCheckNumber.Text = "CC Auth #:";
    else
      this.labelCheckNumber.Text = "Check #:";
    this.CreditCardCheckbox_CheckStateChanged();
  }

  public event EventHandler ToggleCreditCardSelected;

  protected void CreditCardCheckbox_CheckStateChanged()
  {
    EventHandler creditCardSelected = this.ToggleCreditCardSelected;
    if (creditCardSelected == null)
      return;
    creditCardSelected((object) this, new EventArgs());
  }

  protected void buttonAppliedUnaccounted_Click(object sender, EventArgs e)
  {
    if (!string.IsNullOrEmpty(((Control) this.txtAppliedUnAccounted).Text) && MessageBox.Show("Explicitly allocating un-accounted will override any value you have entered to allocate. Continue?", "Override Allocated Amount?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      return;
    using (FormAppliedUnaccounted form = (FormAppliedUnaccounted) ObjectFactory.Instance.CreateForm(typeof (FormAppliedUnaccounted), new object[1]
    {
      (object) this._entityGuid
    }))
    {
      if (form.ShowDialog() != DialogResult.OK)
        return;
      ((Control) this.txtAppliedUnAccounted).Text = form.AppliedAmount.ToString("c");
      ((Control) this.txtAppliedUnAccounted).Enabled = false;
      this._appliedUnaccountedDS = form.AppliedUnaccountedData;
      this.CalculateAndDisplayTotal();
      this.OnAppliedUnaccountecConfirmed(form.CheckNumber);
    }
  }

  public event formTransactionBuilder.AppliedUnAccountedConfirmedDelegate AppliedUnaccountedConfirmed;

  protected virtual void OnAppliedUnaccountecConfirmed(string checkNumber)
  {
    formTransactionBuilder.AppliedUnAccountedConfirmedDelegate unaccountedConfirmed = this.AppliedUnaccountedConfirmed;
    if (unaccountedConfirmed == null)
      return;
    unaccountedConfirmed(checkNumber);
  }

  private void buttonCancelAppliedUnaccounted_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will clear the applied un-accounted. This action cannot be undone. Continue?", "Clear Applied Un-Accounted", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    ((Control) this.txtAppliedUnAccounted).Text = string.Empty;
    ((Control) this.txtAppliedUnAccounted).Enabled = true;
    this._appliedUnaccountedDS.Clear();
    this.CalculateAndDisplayTotal();
  }

  public event formTransactionBuilder.AfterPostPartialPayListReadyHandler PartialPayListReady;

  protected virtual void OnPartialPayListReady(ArrayList partialPayList)
  {
    formTransactionBuilder.AfterPostPartialPayListReadyHandler partialPayListReady = this.PartialPayListReady;
    if (partialPayListReady == null)
      return;
    partialPayListReady(partialPayList);
  }

  public event formTransactionBuilder.AfterCancelPayHandler AfterCancelledPayListReady;

  protected virtual void OnAfterCancelledPayListReady(ArrayList afterCancelPay)
  {
    formTransactionBuilder.AfterCancelPayHandler cancelledPayListReady = this.AfterCancelledPayListReady;
    if (cancelledPayListReady == null)
      return;
    cancelledPayListReady(this._afterCancelPay);
  }

  private void FormatPayablesGrid()
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridPayables).Rows).Count == 0 || !((Control) this.gridPayables).Visible || ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridPayables).DisplayLayout.Bands).Count == 0)
      return;
    UltraGridBand band = ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0];
    if (!((KeyedSubObjectsCollectionBase) band.Columns).Exists(formTransactionBuilder.ArApGridColumnKeys.AmountReceived))
      return;
    ((HeaderBase) band.Columns[formTransactionBuilder.ArApGridColumnKeys.AmountReceived].Header).Appearance.TextHAlign = (HAlign) 3;
    band.Columns[formTransactionBuilder.ArApGridColumnKeys.AmountReceived].CellAppearance.TextHAlign = (HAlign) 3;
    band.Columns[formTransactionBuilder.ArApGridColumnKeys.AmountReceived].Format = "c";
    if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries).Exists("amtrcvdsum"))
      return;
    SummarySettings summarySettings = ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Summaries.Add("amtrcvdsum", (SummaryType) 1, ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.AmountReceived]);
    summarySettings.SummaryPosition = (SummaryPosition) 3;
    summarySettings.SummaryPositionColumn = ((UltraGridBase) this.gridPayables).DisplayLayout.Bands[0].Columns[formTransactionBuilder.ArApGridColumnKeys.AmountReceived];
    summarySettings.DisplayFormat = "{0:c}";
    summarySettings.Appearance.TextHAlign = (HAlign) 3;
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("OpenPayables", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GLCompanyId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PolicyNumber", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance5 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formTransactionBuilder));
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Payee");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Gross Payable");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("AmtPtd");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Net Payable");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Amt Rcvd");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Exch Balance");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("UnAcct Balance");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("APGL");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("EXGL");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("UAGL");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("PropAmt");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("payeePercentRate");
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("mgaPercentrate");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("apapplied");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("CheckRequested");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("Fees Due Date");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("TransactionDate");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("Endorsement Effective");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("CurrencyCode");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("CurrencyCode_Functional");
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("CurrencyCode_Reporting");
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("ConvRate_Functional");
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("ConvRate_Reporting");
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("Producer");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("SummaryView");
    Appearance appearance25 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("OpenPayables", -1);
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("GLCompanyId");
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("PolicyNumber", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance26 = new Appearance();
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance27 = new Appearance();
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("Payee");
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("Gross Payable");
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("AmtPtd");
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("Net Payable");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("Amt Rcvd");
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("Exch Balance");
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("UnAcct Balance");
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("APGL");
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("EXGL");
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("UAGL");
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("PropAmt");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("payeePercentRate");
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("mgaPercentrate");
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("apapplied");
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("CheckRequested");
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("Fees Due Date");
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("TransactionDate");
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("Endorsement Effective");
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("CurrencyCode");
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("CurrencyCode_Functional");
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("CurrencyCode_Reporting");
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("ConvRate_Functional");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("ConvRate_Reporting");
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("Producer");
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("DetailView");
    Appearance appearance45 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("OpenPayables", -1);
    UltraGridColumn ultraGridColumn83 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn84 = new UltraGridColumn("GLCompanyId");
    UltraGridColumn ultraGridColumn85 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn86 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn87 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn88 = new UltraGridColumn("PolicyNumber", -1, (object) null, 472475876, 0, 0);
    UltraGridColumn ultraGridColumn89 = new UltraGridColumn("InsuredPolicyName", -1, (object) null, 472475876, 4, 0);
    UltraGridColumn ultraGridColumn90 = new UltraGridColumn("EffectiveDate", -1, (object) null, 472475876, 6, 0);
    UltraGridColumn ultraGridColumn91 = new UltraGridColumn("ExpirationDate", -1, (object) null, 472475876, 7, 0);
    UltraGridColumn ultraGridColumn92 = new UltraGridColumn("OfficeInvoiceNum", -1, (object) null, 472475876, 2, 0);
    UltraGridColumn ultraGridColumn93 = new UltraGridColumn("Payee", -1, (object) null, 472475876, 1, 0);
    UltraGridColumn ultraGridColumn94 = new UltraGridColumn("ChargeName", -1, (object) null, 472475876, 5, 0);
    UltraGridColumn ultraGridColumn95 = new UltraGridColumn("Gross Payable", -1, (object) null, 472475876, 8, 1);
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    UltraGridColumn ultraGridColumn96 = new UltraGridColumn("AmtPtd", -1, (object) null, 472475876, 10, 1);
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    UltraGridColumn ultraGridColumn97 = new UltraGridColumn("Net Payable", -1, (object) null, 472475876, 11, 1);
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraGridColumn ultraGridColumn98 = new UltraGridColumn("Amt Rcvd", -1, (object) null, 472475876, 9, 1);
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    UltraGridColumn ultraGridColumn99 = new UltraGridColumn("Exch Balance", -1, (object) null, 472475876, 12, 1);
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    UltraGridColumn ultraGridColumn100 = new UltraGridColumn("UnAcct Balance", -1, (object) null, 472475876, 14, 1);
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    UltraGridColumn ultraGridColumn101 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn102 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn103 = new UltraGridColumn("InvoiceDate", -1, (object) null, 472475876, 3, 0);
    UltraGridColumn ultraGridColumn104 = new UltraGridColumn("APGL");
    UltraGridColumn ultraGridColumn105 = new UltraGridColumn("EXGL");
    UltraGridColumn ultraGridColumn106 = new UltraGridColumn("UAGL");
    UltraGridColumn ultraGridColumn107 = new UltraGridColumn("PropAmt", -1, (object) null, 472475876, 16 /*0x10*/, 1);
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    UltraGridColumn ultraGridColumn108 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn109 = new UltraGridColumn("payeePercentRate");
    UltraGridColumn ultraGridColumn110 = new UltraGridColumn("mgaPercentrate");
    UltraGridColumn ultraGridColumn111 = new UltraGridColumn("apapplied", -1, (object) null, 472475876, 17, 1);
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    UltraGridColumn ultraGridColumn112 = new UltraGridColumn("CheckRequested");
    UltraGridColumn ultraGridColumn113 = new UltraGridColumn("CurrencyCode");
    UltraGridColumn ultraGridColumn114 = new UltraGridColumn("CurrencyCode_Functional");
    UltraGridColumn ultraGridColumn115 = new UltraGridColumn("CurrencyCode_Reporting");
    UltraGridColumn ultraGridColumn116 = new UltraGridColumn("ConvRate_Functional");
    UltraGridColumn ultraGridColumn117 = new UltraGridColumn("ConvRate_Reporting");
    UltraGridColumn ultraGridColumn118 = new UltraGridColumn("ExchApplied", 0, (object) null, 472475876, 13, 1);
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    UltraGridColumn ultraGridColumn119 = new UltraGridColumn("UnAcctApplied", 1, (object) null, 472475876, 15, 1);
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    UltraGridGroup ultraGridGroup1 = new UltraGridGroup("DetailView", 472475876);
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    UltraGridLayout ultraGridLayout3 = new UltraGridLayout("ChipDownView");
    Appearance appearance75 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("OpenPayables", -1);
    UltraGridColumn ultraGridColumn120 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn121 = new UltraGridColumn("GLCompanyId");
    UltraGridColumn ultraGridColumn122 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn123 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn124 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn125 = new UltraGridColumn("PolicyNumber", -1, (object) null, 472491063, 0, 0);
    UltraGridColumn ultraGridColumn126 = new UltraGridColumn("InsuredPolicyName", -1, (object) null, 472491063, 2, 0);
    UltraGridColumn ultraGridColumn127 = new UltraGridColumn("EffectiveDate", -1, (object) null, 472491063, 4, 0);
    UltraGridColumn ultraGridColumn128 = new UltraGridColumn("ExpirationDate", -1, (object) null, 472491063, 5, 0);
    UltraGridColumn ultraGridColumn129 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn130 = new UltraGridColumn("OfficeInvoiceNum", -1, (object) null, 472491063, 1, 0);
    UltraGridColumn ultraGridColumn131 = new UltraGridColumn("Payee", -1, (object) null, 472491063, 6, 1);
    UltraGridColumn ultraGridColumn132 = new UltraGridColumn("ChargeName", -1, (object) null, 472491063, 3, 0);
    UltraGridColumn ultraGridColumn133 = new UltraGridColumn("Gross Payable", -1, (object) null, 472491063, 7, 1);
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    UltraGridColumn ultraGridColumn134 = new UltraGridColumn("AmtPtd", -1, (object) null, 472491063, 9, 1);
    Appearance appearance78 = new Appearance();
    Appearance appearance79 = new Appearance();
    UltraGridColumn ultraGridColumn135 = new UltraGridColumn("Net Payable", -1, (object) null, 472491063, 10, 1);
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    UltraGridColumn ultraGridColumn136 = new UltraGridColumn("Amt Rcvd", -1, (object) null, 472491063, 8, 1);
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    UltraGridColumn ultraGridColumn137 = new UltraGridColumn("Exch Balance");
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    UltraGridColumn ultraGridColumn138 = new UltraGridColumn("UnAcct Balance");
    Appearance appearance86 = new Appearance();
    Appearance appearance87 = new Appearance();
    UltraGridColumn ultraGridColumn139 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn140 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn141 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn142 = new UltraGridColumn("APGL");
    UltraGridColumn ultraGridColumn143 = new UltraGridColumn("EXGL");
    UltraGridColumn ultraGridColumn144 = new UltraGridColumn("UAGL");
    UltraGridColumn ultraGridColumn145 = new UltraGridColumn("PropAmt", -1, (object) null, 472491063, 11, 1);
    Appearance appearance88 = new Appearance();
    Appearance appearance89 = new Appearance();
    UltraGridColumn ultraGridColumn146 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn147 = new UltraGridColumn("payeePercentRate");
    UltraGridColumn ultraGridColumn148 = new UltraGridColumn("mgaPercentrate");
    UltraGridColumn ultraGridColumn149 = new UltraGridColumn("apapplied", -1, (object) null, 472491063, 12, 1);
    Appearance appearance90 = new Appearance();
    Appearance appearance91 = new Appearance();
    UltraGridColumn ultraGridColumn150 = new UltraGridColumn("CheckRequested");
    UltraGridColumn ultraGridColumn151 = new UltraGridColumn("Fees Due Date");
    UltraGridColumn ultraGridColumn152 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn153 = new UltraGridColumn("TransactionDate");
    UltraGridColumn ultraGridColumn154 = new UltraGridColumn("Endorsement Effective");
    UltraGridColumn ultraGridColumn155 = new UltraGridColumn("CurrencyCode");
    UltraGridColumn ultraGridColumn156 = new UltraGridColumn("CurrencyCode_Functional");
    UltraGridColumn ultraGridColumn157 = new UltraGridColumn("CurrencyCode_Reporting");
    UltraGridColumn ultraGridColumn158 = new UltraGridColumn("ConvRate_Functional");
    UltraGridColumn ultraGridColumn159 = new UltraGridColumn("ConvRate_Reporting");
    UltraGridColumn ultraGridColumn160 = new UltraGridColumn("Producer");
    UltraGridGroup ultraGridGroup2 = new UltraGridGroup("DetailView", 472491063);
    Appearance appearance92 = new Appearance();
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    Appearance appearance95 = new Appearance();
    Appearance appearance96 = new Appearance();
    Appearance appearance97 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance98 = new Appearance();
    Appearance appearance99 = new Appearance();
    Appearance appearance100 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("OpenReceivables", -1);
    UltraGridColumn ultraGridColumn161 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn162 = new UltraGridColumn("OfficeInvoiceNum");
    UltraGridColumn ultraGridColumn163 = new UltraGridColumn("QuoteId");
    UltraGridColumn ultraGridColumn164 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn165 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn166 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn167 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn168 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn169 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn170 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn171 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn172 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn173 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn174 = new UltraGridColumn("AmtBilled");
    Appearance appearance101 = new Appearance();
    Appearance appearance102 = new Appearance();
    UltraGridColumn ultraGridColumn175 = new UltraGridColumn("AmtRTD");
    Appearance appearance103 = new Appearance();
    Appearance appearance104 = new Appearance();
    UltraGridColumn ultraGridColumn176 = new UltraGridColumn("NetDue");
    Appearance appearance105 = new Appearance();
    Appearance appearance106 = new Appearance();
    UltraGridColumn ultraGridColumn177 = new UltraGridColumn("AmtPTC");
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    UltraGridColumn ultraGridColumn178 = new UltraGridColumn("UnacctBalance");
    Appearance appearance109 = new Appearance();
    Appearance appearance110 = new Appearance();
    UltraGridColumn ultraGridColumn179 = new UltraGridColumn("ExchBalance");
    Appearance appearance111 = new Appearance();
    Appearance appearance112 = new Appearance();
    UltraGridColumn ultraGridColumn180 = new UltraGridColumn("ARGL");
    UltraGridColumn ultraGridColumn181 = new UltraGridColumn("EXGL");
    UltraGridColumn ultraGridColumn182 = new UltraGridColumn("UAGL");
    UltraGridColumn ultraGridColumn183 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn184 = new UltraGridColumn("CurrentStatus");
    UltraGridColumn ultraGridColumn185 = new UltraGridColumn("FinanceCompanyGuid");
    UltraGridColumn ultraGridColumn186 = new UltraGridColumn("RemitterGuid");
    UltraGridColumn ultraGridColumn187 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn188 = new UltraGridColumn("ARApplied");
    Appearance appearance113 = new Appearance();
    Appearance appearance114 = new Appearance();
    Appearance appearance115 = new Appearance();
    UltraGridColumn ultraGridColumn189 = new UltraGridColumn("ExchApplied");
    Appearance appearance116 = new Appearance();
    Appearance appearance117 = new Appearance();
    UltraGridColumn ultraGridColumn190 = new UltraGridColumn("UnAcctApplied");
    Appearance appearance118 = new Appearance();
    Appearance appearance119 = new Appearance();
    UltraGridColumn ultraGridColumn191 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn192 = new UltraGridColumn("Endorsement Effective");
    UltraGridColumn ultraGridColumn193 = new UltraGridColumn("CurrencyCode");
    UltraGridColumn ultraGridColumn194 = new UltraGridColumn("CurrencyCode_Functional");
    UltraGridColumn ultraGridColumn195 = new UltraGridColumn("CurrencyCode_Reporting");
    UltraGridColumn ultraGridColumn196 = new UltraGridColumn("ConvRate_Functional");
    UltraGridColumn ultraGridColumn197 = new UltraGridColumn("ConvRate_Reporting");
    UltraGridColumn ultraGridColumn198 = new UltraGridColumn("Producer");
    Appearance appearance120 = new Appearance();
    Appearance appearance121 = new Appearance();
    Appearance appearance122 = new Appearance();
    Appearance appearance123 = new Appearance();
    Appearance appearance124 = new Appearance();
    Appearance appearance125 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance126 = new Appearance();
    Appearance appearance127 = new Appearance();
    UltraGridLayout ultraGridLayout4 = new UltraGridLayout("DetailView");
    Appearance appearance128 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("OpenReceivables", -1);
    UltraGridColumn ultraGridColumn199 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn200 = new UltraGridColumn("OfficeInvoiceNum", -1, (object) null, 472543594, 2, 0);
    UltraGridColumn ultraGridColumn201 = new UltraGridColumn("QuoteId");
    UltraGridColumn ultraGridColumn202 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn203 = new UltraGridColumn("PolicyNumber", -1, (object) null, 472543594, 0, 0);
    UltraGridColumn ultraGridColumn204 = new UltraGridColumn("InsuredPolicyName", -1, (object) null, 472543594, 3, 0);
    UltraGridColumn ultraGridColumn205 = new UltraGridColumn("EffectiveDate", -1, (object) null, 472543594, 5, 0);
    UltraGridColumn ultraGridColumn206 = new UltraGridColumn("ExpirationDate", -1, (object) null, 472543594, 6, 0);
    UltraGridColumn ultraGridColumn207 = new UltraGridColumn("InvoiceDate", -1, (object) null, 472543594, 7, 1);
    UltraGridColumn ultraGridColumn208 = new UltraGridColumn("ChargeName", -1, (object) null, 472543594, 4, 0);
    UltraGridColumn ultraGridColumn209 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn210 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn211 = new UltraGridColumn("AmtBilled", -1, (object) null, 472543594, 8, 1);
    Appearance appearance129 = new Appearance();
    Appearance appearance130 = new Appearance();
    UltraGridColumn ultraGridColumn212 = new UltraGridColumn("AmtRTD", -1, (object) null, 472543594, 10, 1);
    Appearance appearance131 = new Appearance();
    Appearance appearance132 = new Appearance();
    UltraGridColumn ultraGridColumn213 = new UltraGridColumn("NetDue", -1, (object) null, 472543594, 11, 1);
    Appearance appearance133 = new Appearance();
    Appearance appearance134 = new Appearance();
    UltraGridColumn ultraGridColumn214 = new UltraGridColumn("AmtPTC", -1, (object) null, 472543594, 9, 1);
    Appearance appearance135 = new Appearance();
    Appearance appearance136 = new Appearance();
    UltraGridColumn ultraGridColumn215 = new UltraGridColumn("UnacctBalance", -1, (object) null, 472543594, 15, 1);
    Appearance appearance137 = new Appearance();
    Appearance appearance138 = new Appearance();
    UltraGridColumn ultraGridColumn216 = new UltraGridColumn("ExchBalance", -1, (object) null, 472543594, 13, 1);
    Appearance appearance139 = new Appearance();
    Appearance appearance140 = new Appearance();
    UltraGridColumn ultraGridColumn217 = new UltraGridColumn("ARGL");
    UltraGridColumn ultraGridColumn218 = new UltraGridColumn("EXGL");
    UltraGridColumn ultraGridColumn219 = new UltraGridColumn("UAGL");
    UltraGridColumn ultraGridColumn220 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn221 = new UltraGridColumn("CurrentStatus", -1, (object) null, 472543594, 1, 0);
    UltraGridColumn ultraGridColumn222 = new UltraGridColumn("FinanceCompanyGuid");
    UltraGridColumn ultraGridColumn223 = new UltraGridColumn("RemitterGuid");
    UltraGridColumn ultraGridColumn224 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn225 = new UltraGridColumn("ARApplied", -1, (object) null, 472543594, 12, 1);
    Appearance appearance141 = new Appearance();
    Appearance appearance142 = new Appearance();
    Appearance appearance143 = new Appearance();
    UltraGridColumn ultraGridColumn226 = new UltraGridColumn("ExchApplied", -1, (object) null, 472543594, 14, 1);
    Appearance appearance144 = new Appearance();
    Appearance appearance145 = new Appearance();
    UltraGridColumn ultraGridColumn227 = new UltraGridColumn("UnAcctApplied", -1, (object) null, 472543594, 16 /*0x10*/, 1);
    Appearance appearance146 = new Appearance();
    Appearance appearance147 = new Appearance();
    UltraGridColumn ultraGridColumn228 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn229 = new UltraGridColumn("Endorsement Effective");
    UltraGridColumn ultraGridColumn230 = new UltraGridColumn("CurrencyCode");
    UltraGridColumn ultraGridColumn231 = new UltraGridColumn("CurrencyCode_Functional");
    UltraGridColumn ultraGridColumn232 = new UltraGridColumn("CurrencyCode_Reporting");
    UltraGridColumn ultraGridColumn233 = new UltraGridColumn("ConvRate_Functional");
    UltraGridColumn ultraGridColumn234 = new UltraGridColumn("ConvRate_Reporting");
    UltraGridGroup ultraGridGroup3 = new UltraGridGroup("NewGroup0", 472543594);
    Appearance appearance148 = new Appearance();
    Appearance appearance149 = new Appearance();
    Appearance appearance150 = new Appearance();
    Appearance appearance151 = new Appearance();
    Appearance appearance152 = new Appearance();
    Appearance appearance153 = new Appearance();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    Appearance appearance154 = new Appearance();
    Appearance appearance155 = new Appearance();
    UltraGridLayout ultraGridLayout5 = new UltraGridLayout("SummaryView");
    Appearance appearance156 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("OpenReceivables", -1);
    UltraGridColumn ultraGridColumn235 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn236 = new UltraGridColumn("OfficeInvoiceNum");
    UltraGridColumn ultraGridColumn237 = new UltraGridColumn("QuoteId");
    UltraGridColumn ultraGridColumn238 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn239 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn240 = new UltraGridColumn("InsuredPolicyName");
    UltraGridColumn ultraGridColumn241 = new UltraGridColumn("EffectiveDate");
    UltraGridColumn ultraGridColumn242 = new UltraGridColumn("ExpirationDate");
    UltraGridColumn ultraGridColumn243 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn244 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn245 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn246 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn247 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn248 = new UltraGridColumn("AmtBilled");
    Appearance appearance157 = new Appearance();
    Appearance appearance158 = new Appearance();
    UltraGridColumn ultraGridColumn249 = new UltraGridColumn("AmtRTD");
    Appearance appearance159 = new Appearance();
    Appearance appearance160 = new Appearance();
    UltraGridColumn ultraGridColumn250 = new UltraGridColumn("NetDue");
    Appearance appearance161 = new Appearance();
    Appearance appearance162 = new Appearance();
    UltraGridColumn ultraGridColumn251 = new UltraGridColumn("AmtPTC");
    Appearance appearance163 = new Appearance();
    Appearance appearance164 = new Appearance();
    UltraGridColumn ultraGridColumn252 = new UltraGridColumn("UnacctBalance");
    Appearance appearance165 = new Appearance();
    Appearance appearance166 = new Appearance();
    UltraGridColumn ultraGridColumn253 = new UltraGridColumn("ExchBalance");
    Appearance appearance167 = new Appearance();
    Appearance appearance168 = new Appearance();
    UltraGridColumn ultraGridColumn254 = new UltraGridColumn("ARGL");
    UltraGridColumn ultraGridColumn255 = new UltraGridColumn("EXGL");
    UltraGridColumn ultraGridColumn256 = new UltraGridColumn("UAGL");
    UltraGridColumn ultraGridColumn257 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn258 = new UltraGridColumn("CurrentStatus");
    UltraGridColumn ultraGridColumn259 = new UltraGridColumn("FinanceCompanyGuid");
    UltraGridColumn ultraGridColumn260 = new UltraGridColumn("RemitterGuid");
    UltraGridColumn ultraGridColumn261 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn262 = new UltraGridColumn("ARApplied");
    Appearance appearance169 = new Appearance();
    Appearance appearance170 = new Appearance();
    Appearance appearance171 = new Appearance();
    UltraGridColumn ultraGridColumn263 = new UltraGridColumn("ExchApplied");
    Appearance appearance172 = new Appearance();
    Appearance appearance173 = new Appearance();
    UltraGridColumn ultraGridColumn264 = new UltraGridColumn("UnAcctApplied");
    Appearance appearance174 = new Appearance();
    Appearance appearance175 = new Appearance();
    UltraGridColumn ultraGridColumn265 = new UltraGridColumn("LOB");
    UltraGridColumn ultraGridColumn266 = new UltraGridColumn("Endorsement Effective");
    UltraGridColumn ultraGridColumn267 = new UltraGridColumn("CurrencyCode");
    UltraGridColumn ultraGridColumn268 = new UltraGridColumn("CurrencyCode_Functional");
    UltraGridColumn ultraGridColumn269 = new UltraGridColumn("CurrencyCode_Reporting");
    UltraGridColumn ultraGridColumn270 = new UltraGridColumn("ConvRate_Functional");
    UltraGridColumn ultraGridColumn271 = new UltraGridColumn("ConvRate_Reporting");
    UltraGridColumn ultraGridColumn272 = new UltraGridColumn("Producer");
    Appearance appearance176 = new Appearance();
    Appearance appearance177 = new Appearance();
    Appearance appearance178 = new Appearance();
    Appearance appearance179 = new Appearance();
    Appearance appearance180 = new Appearance();
    Appearance appearance181 = new Appearance();
    ScrollBarLook scrollBarLook7 = new ScrollBarLook();
    Appearance appearance182 = new Appearance();
    Appearance appearance183 = new Appearance();
    UltraGridLayout ultraGridLayout6 = new UltraGridLayout("ChipDownView");
    Appearance appearance184 = new Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("OpenReceivables", -1);
    UltraGridColumn ultraGridColumn273 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn274 = new UltraGridColumn("OfficeInvoiceNum");
    UltraGridColumn ultraGridColumn275 = new UltraGridColumn("QuoteId");
    UltraGridColumn ultraGridColumn276 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn277 = new UltraGridColumn("PolicyNumber", -1, (object) null, 472564016, 0, 0);
    UltraGridColumn ultraGridColumn278 = new UltraGridColumn("InsuredPolicyName", -1, (object) null, 472564016, 2, 0);
    UltraGridColumn ultraGridColumn279 = new UltraGridColumn("EffectiveDate", -1, (object) null, 472564016, 3, 0);
    UltraGridColumn ultraGridColumn280 = new UltraGridColumn("ExpirationDate", -1, (object) null, 472564016, 4, 0);
    UltraGridColumn ultraGridColumn281 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn282 = new UltraGridColumn("ChargeName");
    UltraGridColumn ultraGridColumn283 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn284 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn285 = new UltraGridColumn("AmtBilled", -1, (object) null, 472564016, 5, 1);
    Appearance appearance185 = new Appearance();
    Appearance appearance186 = new Appearance();
    UltraGridColumn ultraGridColumn286 = new UltraGridColumn("AmtRTD", -1, (object) null, 472564016, 7, 1);
    Appearance appearance187 = new Appearance();
    Appearance appearance188 = new Appearance();
    UltraGridColumn ultraGridColumn287 = new UltraGridColumn("NetDue", -1, (object) null, 472564016, 8, 1);
    Appearance appearance189 = new Appearance();
    Appearance appearance190 = new Appearance();
    UltraGridColumn ultraGridColumn288 = new UltraGridColumn("AmtPTC", -1, (object) null, 472564016, 6, 1);
    Appearance appearance191 = new Appearance();
    Appearance appearance192 = new Appearance();
    UltraGridColumn ultraGridColumn289 = new UltraGridColumn("UnacctBalance", -1, (object) null, 472564016, 12, 1);
    Appearance appearance193 = new Appearance();
    Appearance appearance194 = new Appearance();
    UltraGridColumn ultraGridColumn290 = new UltraGridColumn("ExchBalance", -1, (object) null, 472564016, 10, 1);
    Appearance appearance195 = new Appearance();
    Appearance appearance196 = new Appearance();
    UltraGridColumn ultraGridColumn291 = new UltraGridColumn("ARGL");
    UltraGridColumn ultraGridColumn292 = new UltraGridColumn("EXGL");
    UltraGridColumn ultraGridColumn293 = new UltraGridColumn("UAGL");
    UltraGridColumn ultraGridColumn294 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn295 = new UltraGridColumn("CurrentStatus", -1, (object) null, 472564016, 1, 0);
    UltraGridColumn ultraGridColumn296 = new UltraGridColumn("FinanceCompanyGuid");
    UltraGridColumn ultraGridColumn297 = new UltraGridColumn("RemitterGuid");
    UltraGridColumn ultraGridColumn298 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn299 = new UltraGridColumn("ARApplied", -1, (object) null, 472564016, 9, 1);
    Appearance appearance197 = new Appearance();
    Appearance appearance198 = new Appearance();
    UltraGridColumn ultraGridColumn300 = new UltraGridColumn("ExchApplied", -1, (object) null, 472564016, 11, 1);
    Appearance appearance199 = new Appearance();
    Appearance appearance200 = new Appearance();
    UltraGridColumn ultraGridColumn301 = new UltraGridColumn("UnAcctApplied", -1, (object) null, 472564016, 13, 1);
    Appearance appearance201 = new Appearance();
    Appearance appearance202 = new Appearance();
    UltraGridGroup ultraGridGroup4 = new UltraGridGroup("Recievable", 472564016);
    Appearance appearance203 = new Appearance();
    Appearance appearance204 = new Appearance();
    Appearance appearance205 = new Appearance();
    Appearance appearance206 = new Appearance();
    Appearance appearance207 = new Appearance();
    Appearance appearance208 = new Appearance();
    ScrollBarLook scrollBarLook8 = new ScrollBarLook();
    Appearance appearance209 = new Appearance();
    Appearance appearance210 = new Appearance();
    Appearance appearance211 = new Appearance();
    UltraGridBand ultraGridBand9 = new UltraGridBand("", -1);
    Appearance appearance212 = new Appearance();
    Appearance appearance213 = new Appearance();
    Appearance appearance214 = new Appearance();
    Appearance appearance215 = new Appearance();
    Appearance appearance216 = new Appearance();
    Appearance appearance217 = new Appearance();
    ScrollBarLook scrollBarLook9 = new ScrollBarLook();
    Appearance appearance218 = new Appearance();
    Appearance appearance219 = new Appearance();
    Appearance appearance220 = new Appearance();
    Appearance appearance221 = new Appearance();
    Appearance appearance222 = new Appearance();
    Appearance appearance223 = new Appearance();
    Appearance appearance224 = new Appearance();
    Appearance appearance225 = new Appearance();
    Appearance appearance226 = new Appearance();
    Appearance appearance227 = new Appearance();
    Appearance appearance228 = new Appearance();
    Appearance appearance229 = new Appearance();
    Appearance appearance230 = new Appearance();
    Appearance appearance231 = new Appearance();
    ScrollBarLook scrollBarLook10 = new ScrollBarLook();
    Appearance appearance232 = new Appearance();
    Appearance appearance233 = new Appearance();
    Appearance appearance234 = new Appearance();
    Appearance appearance235 = new Appearance();
    UltraGridBand ultraGridBand10 = new UltraGridBand("", -1);
    Appearance appearance236 = new Appearance();
    Appearance appearance237 = new Appearance();
    Appearance appearance238 = new Appearance();
    Appearance appearance239 = new Appearance();
    Appearance appearance240 = new Appearance();
    Appearance appearance241 = new Appearance();
    Appearance appearance242 = new Appearance();
    ScrollBarLook scrollBarLook11 = new ScrollBarLook();
    Appearance appearance243 = new Appearance();
    Appearance appearance244 = new Appearance();
    UltraToolbar ultraToolbar1 = new UltraToolbar("toolbarShared");
    ButtonTool buttonTool1 = new ButtonTool("NEW");
    ButtonTool buttonTool2 = new ButtonTool("CLEAR");
    ButtonTool buttonTool3 = new ButtonTool("POST");
    ButtonTool buttonTool4 = new ButtonTool("INTERCOMPANY");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("LOADADDITIONAL");
    StateButtonTool stateButtonTool1 = new StateButtonTool("TOGGLEPAID", "");
    PopupControlContainerTool controlContainerTool1 = new PopupControlContainerTool("TOGGLECHECKREQUEST");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("OPTIONS");
    ButtonTool buttonTool5 = new ButtonTool("PRINT");
    ButtonTool buttonTool6 = new ButtonTool("IMPORTERRORS");
    ButtonTool buttonTool7 = new ButtonTool("HELP");
    Appearance appearance245 = new Appearance();
    UltraToolbar ultraToolbar2 = new UltraToolbar("receivablesTools");
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("ReceivableContextMenu");
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("PaybleContextMenu");
    ButtonTool buttonTool8 = new ButtonTool("NEW");
    Appearance appearance246 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("LOAD");
    Appearance appearance247 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("SAVE");
    PopupMenuTool popupMenuTool5 = new PopupMenuTool("OPTIONS");
    Appearance appearance248 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("LOAD");
    ButtonTool buttonTool12 = new ButtonTool("SAVE");
    ButtonTool buttonTool13 = new ButtonTool("POST");
    Appearance appearance249 = new Appearance();
    ButtonTool buttonTool14 = new ButtonTool("CLEAR");
    Appearance appearance250 = new Appearance();
    ButtonTool buttonTool15 = new ButtonTool("INTERCOMPANY");
    Appearance appearance251 = new Appearance();
    PopupMenuTool popupMenuTool6 = new PopupMenuTool("PaybleContextMenu");
    Appearance appearance252 = new Appearance();
    ButtonTool buttonTool16 = new ButtonTool("PAYINFULL");
    ButtonTool buttonTool17 = new ButtonTool("PAYALLINFULL");
    ButtonTool buttonTool18 = new ButtonTool("PAYPROP");
    ButtonTool buttonTool19 = new ButtonTool("PAYALLPROP");
    ButtonTool buttonTool20 = new ButtonTool("APPLYUA_REC");
    ButtonTool buttonTool21 = new ButtonTool("APPLYEX");
    ButtonTool buttonTool22 = new ButtonTool("WRITEOFF");
    ButtonTool buttonTool23 = new ButtonTool("CLEARAPPLIED");
    ButtonTool buttonTool24 = new ButtonTool("CLEARALLAPPLIED");
    ButtonTool buttonTool25 = new ButtonTool("FINANCE");
    ButtonTool buttonTool26 = new ButtonTool("VIEWDETAIL");
    StateButtonTool stateButtonTool2 = new StateButtonTool("SHOWEXTENDED", "");
    ButtonTool buttonTool27 = new ButtonTool("PAYCOLSELECT");
    ButtonTool buttonTool28 = new ButtonTool("RESETAPLAYOUTS");
    PopupMenuTool popupMenuTool7 = new PopupMenuTool("PaymentOptions");
    ButtonTool buttonTool29 = new ButtonTool("PAYINFULL");
    Appearance appearance253 = new Appearance();
    ButtonTool buttonTool30 = new ButtonTool("PAYALLINFULL");
    Appearance appearance254 = new Appearance();
    ButtonTool buttonTool31 = new ButtonTool("WRITEOFF");
    ButtonTool buttonTool32 = new ButtonTool("CLEARAPPLIED");
    ButtonTool buttonTool33 = new ButtonTool("CLEARALLAPPLIED");
    ButtonTool buttonTool34 = new ButtonTool("FINANCE");
    Appearance appearance255 = new Appearance();
    ButtonTool buttonTool35 = new ButtonTool("VIEWDETAIL");
    ButtonTool buttonTool36 = new ButtonTool("APPLYUA_REC");
    ButtonTool buttonTool37 = new ButtonTool("APPLYEX");
    StateButtonTool stateButtonTool3 = new StateButtonTool("SHOWEXTENDED", "");
    Appearance appearance256 = new Appearance();
    ButtonTool buttonTool38 = new ButtonTool("LOADADDITIONALPAYABLES");
    Appearance appearance257 = new Appearance();
    ButtonTool buttonTool39 = new ButtonTool("PAYPROP");
    ButtonTool buttonTool40 = new ButtonTool("PAYALLPROP");
    StateButtonTool stateButtonTool4 = new StateButtonTool("TOGGLEPAID", "");
    Appearance appearance258 = new Appearance();
    Appearance appearance259 = new Appearance();
    ButtonTool buttonTool41 = new ButtonTool("WRITEOFFEXCH_REC");
    ButtonTool buttonTool42 = new ButtonTool("WRITEOFFUA_REC");
    PopupMenuTool popupMenuTool8 = new PopupMenuTool("ReceivableContextMenu");
    ButtonTool buttonTool43 = new ButtonTool("PAYINFULL_REC");
    ButtonTool buttonTool44 = new ButtonTool("PAYALLINFULL_REC");
    ButtonTool buttonTool45 = new ButtonTool("APPLYUA_REC");
    ButtonTool buttonTool46 = new ButtonTool("APPLYEX");
    ButtonTool buttonTool47 = new ButtonTool("WRITEOFF_REC");
    ButtonTool buttonTool48 = new ButtonTool("WRITEOFFEXCH_REC");
    ButtonTool buttonTool49 = new ButtonTool("WRITEOFFUA_REC");
    ButtonTool buttonTool50 = new ButtonTool("CLEARALLAPPLIED_REC");
    ButtonTool buttonTool51 = new ButtonTool("CLEARAPPLIED_REC");
    ButtonTool buttonTool52 = new ButtonTool("FINANCE_REC");
    ButtonTool buttonTool53 = new ButtonTool("VIEWDETAIL_REC");
    StateButtonTool stateButtonTool5 = new StateButtonTool("SHOWEXTENDED_REC", "");
    ButtonTool buttonTool54 = new ButtonTool("RECSELECTCOL");
    ButtonTool buttonTool55 = new ButtonTool("RESETARLAYOUTS");
    PopupMenuTool popupMenuTool9 = new PopupMenuTool("GridContextMenu");
    ButtonTool buttonTool56 = new ButtonTool("PAYINFULL");
    ButtonTool buttonTool57 = new ButtonTool("PAYALLINFULL");
    ButtonTool buttonTool58 = new ButtonTool("APPLYUA_REC");
    ButtonTool buttonTool59 = new ButtonTool("APPLYEX");
    ButtonTool buttonTool60 = new ButtonTool("WRITEOFF");
    ButtonTool buttonTool61 = new ButtonTool("WRITEOFFEXCH_REC");
    ButtonTool buttonTool62 = new ButtonTool("WRITEOFFUA_REC");
    ButtonTool buttonTool63 = new ButtonTool("CLEARAPPLIED");
    ButtonTool buttonTool64 = new ButtonTool("CLEARALLAPPLIED");
    ButtonTool buttonTool65 = new ButtonTool("FINANCE");
    ButtonTool buttonTool66 = new ButtonTool("VIEWDETAIL");
    StateButtonTool stateButtonTool6 = new StateButtonTool("SHOWEXTENDED", "");
    ButtonTool buttonTool67 = new ButtonTool("PAYINFULL_REC");
    Appearance appearance260 = new Appearance();
    ButtonTool buttonTool68 = new ButtonTool("PAYALLINFULL_REC");
    Appearance appearance261 = new Appearance();
    ButtonTool buttonTool69 = new ButtonTool("WRITEOFF_REC");
    ButtonTool buttonTool70 = new ButtonTool("CLEARALLAPPLIED_REC");
    ButtonTool buttonTool71 = new ButtonTool("CLEARAPPLIED_REC");
    ButtonTool buttonTool72 = new ButtonTool("FINANCE_REC");
    Appearance appearance262 = new Appearance();
    ButtonTool buttonTool73 = new ButtonTool("VIEWDETAIL_REC");
    StateButtonTool stateButtonTool7 = new StateButtonTool("SHOWEXTENDED_REC", "");
    Appearance appearance263 = new Appearance();
    ButtonTool buttonTool74 = new ButtonTool("LOADADDITIONALRECEIVABLES");
    Appearance appearance264 = new Appearance();
    PopupMenuTool popupMenuTool10 = new PopupMenuTool("LOADADDITIONAL");
    Appearance appearance265 = new Appearance();
    ButtonTool buttonTool75 = new ButtonTool("LOADADDITIONALPAYABLES");
    ButtonTool buttonTool76 = new ButtonTool("LOADADDITIONALRECEIVABLES");
    PopupControlContainerTool controlContainerTool2 = new PopupControlContainerTool("TOGGLECHECKREQUEST");
    ButtonTool buttonTool77 = new ButtonTool("PRINT");
    Appearance appearance266 = new Appearance();
    ButtonTool buttonTool78 = new ButtonTool("Button Test");
    ButtonTool buttonTool79 = new ButtonTool("IMPORTERRORS");
    Appearance appearance267 = new Appearance();
    ButtonTool buttonTool80 = new ButtonTool("PAYCOLSELECT");
    Appearance appearance268 = new Appearance();
    ButtonTool buttonTool81 = new ButtonTool("RECSELECTCOL");
    Appearance appearance269 = new Appearance();
    ButtonTool buttonTool82 = new ButtonTool("RESETAPLAYOUTS");
    ButtonTool buttonTool83 = new ButtonTool("RESETARLAYOUTS");
    ButtonTool buttonTool84 = new ButtonTool("HELP");
    Appearance appearance270 = new Appearance();
    Appearance appearance271 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    UltraTab ultraTab3 = new UltraTab();
    UltraTab ultraTab4 = new UltraTab();
    UltraTab ultraTab5 = new UltraTab();
    UltraTab ultraTab6 = new UltraTab();
    Appearance appearance272 = new Appearance();
    Appearance appearance273 = new Appearance();
    Appearance appearance274 = new Appearance();
    Appearance appearance275 = new Appearance();
    Appearance appearance276 = new Appearance();
    Appearance appearance277 = new Appearance();
    Appearance appearance278 = new Appearance();
    Appearance appearance279 = new Appearance();
    Appearance appearance280 = new Appearance();
    Appearance appearance281 = new Appearance();
    Appearance appearance282 = new Appearance();
    Appearance appearance283 = new Appearance();
    Appearance appearance284 = new Appearance();
    Appearance appearance285 = new Appearance();
    Appearance appearance286 = new Appearance();
    Appearance appearance287 = new Appearance();
    Appearance appearance288 = new Appearance();
    Appearance appearance289 = new Appearance();
    Appearance appearance290 = new Appearance();
    Appearance appearance291 = new Appearance();
    UltraToolbar ultraToolbar3 = new UltraToolbar("tbReceivables");
    ButtonTool buttonTool85 = new ButtonTool("NEW");
    ButtonTool buttonTool86 = new ButtonTool("CLEAR");
    ButtonTool buttonTool87 = new ButtonTool("POST");
    ButtonTool buttonTool88 = new ButtonTool("LOADADDITIONAL");
    ButtonTool buttonTool89 = new ButtonTool("INTERCOMPANY");
    PopupMenuTool popupMenuTool11 = new PopupMenuTool("OPTIONS");
    Appearance appearance292 = new Appearance();
    ButtonTool buttonTool90 = new ButtonTool("NEW");
    ButtonTool buttonTool91 = new ButtonTool("LOAD");
    ButtonTool buttonTool92 = new ButtonTool("SAVE");
    PopupMenuTool popupMenuTool12 = new PopupMenuTool("OPTIONS");
    ButtonTool buttonTool93 = new ButtonTool("LOAD");
    ButtonTool buttonTool94 = new ButtonTool("SAVE");
    ButtonTool buttonTool95 = new ButtonTool("POST");
    ButtonTool buttonTool96 = new ButtonTool("CLEAR");
    ButtonTool buttonTool97 = new ButtonTool("INTERCOMPANY");
    PopupMenuTool popupMenuTool13 = new PopupMenuTool("GridContextMenu");
    ButtonTool buttonTool98 = new ButtonTool("PAYINFULL");
    ButtonTool buttonTool99 = new ButtonTool("PAYALLINFULL");
    ButtonTool buttonTool100 = new ButtonTool("APPLYUA");
    ButtonTool buttonTool101 = new ButtonTool("APPLYEX");
    ButtonTool buttonTool102 = new ButtonTool("WRITEOFF");
    ButtonTool buttonTool103 = new ButtonTool("WRITEOFFEXCH");
    ButtonTool buttonTool104 = new ButtonTool("WRITEOFFUA");
    ButtonTool buttonTool105 = new ButtonTool("CLEARAPPLIED");
    ButtonTool buttonTool106 = new ButtonTool("CLEARALLAPPLIED");
    ButtonTool buttonTool107 = new ButtonTool("FINANCE");
    ButtonTool buttonTool108 = new ButtonTool("VIEWDETAIL");
    StateButtonTool stateButtonTool8 = new StateButtonTool("SHOWEXTENDED", "");
    PopupMenuTool popupMenuTool14 = new PopupMenuTool("PaymentOptions");
    ButtonTool buttonTool109 = new ButtonTool("PAYINFULL");
    ButtonTool buttonTool110 = new ButtonTool("PAYALLINFULL");
    ButtonTool buttonTool111 = new ButtonTool("WRITEOFF");
    ButtonTool buttonTool112 = new ButtonTool("CLEARAPPLIED");
    ButtonTool buttonTool113 = new ButtonTool("CLEARALLAPPLIED");
    ButtonTool buttonTool114 = new ButtonTool("FINANCE");
    ButtonTool buttonTool115 = new ButtonTool("VIEWDETAIL");
    ButtonTool buttonTool116 = new ButtonTool("APPLYUA");
    ButtonTool buttonTool117 = new ButtonTool("APPLYEX");
    StateButtonTool stateButtonTool9 = new StateButtonTool("SHOWEXTENDED", "");
    ButtonTool buttonTool118 = new ButtonTool("WRITEOFFEXCH");
    ButtonTool buttonTool119 = new ButtonTool("WRITEOFFUA");
    ButtonTool buttonTool120 = new ButtonTool("LOADADDITIONAL");
    PopupMenuTool popupMenuTool15 = new PopupMenuTool("ContextMenu");
    ButtonTool buttonTool121 = new ButtonTool("Edit");
    ButtonTool buttonTool122 = new ButtonTool("Delete");
    ButtonTool buttonTool123 = new ButtonTool("Edit");
    ButtonTool buttonTool124 = new ButtonTool("Delete");
    this.tabPagePayable = new UltraTabPageControl();
    this.panelToggleCheckRequested = new Panel();
    this.dateTimeToggleCheckRequested = new MGADateTimePicker();
    this.checkToggleCheckRequested = new MGACheckBox();
    this.gridPayables = new UltraGrid();
    this.dsOpenPayables = new dsOpenPayables();
    this.panel2 = new Panel();
    this.labelPayablesExist = new Label();
    this.radioPayableDetailView = new RadioButton();
    this.radioPayableSummaryView = new RadioButton();
    this.radioPayableChipDownView = new RadioButton();
    this.pnlPayableChipDownView = new Panel();
    this.label6 = new Label();
    this.progressBarPayablesChipDown = new UltraProgressBar();
    this.xViewPayable = new PayablesInformationViewer();
    this.tabPageReceivable = new UltraTabPageControl();
    this.gridReceivables = new UltraGrid();
    this.dsOpenReceivables = new dsOpenReceivables();
    this.panelGridOptions = new Panel();
    this.labelReceiveablesExist = new Label();
    this.radioReceivableChipDownView = new RadioButton();
    this.radioReceivableSummaryView = new RadioButton();
    this.radioReceivableDetailView = new RadioButton();
    this.pnlReceivableChipDownView = new Panel();
    this.label4 = new Label();
    this.progressBarReceivableChipDown = new UltraProgressBar();
    this.xViewReceivable = new ReceivablesInformationViewer();
    this.tabNonPayableFees = new UltraTabPageControl();
    this.gridNonPayableFees = new UltraGrid();
    this.tabAdditonalOffsets = new UltraTabPageControl();
    this.checkBankCurrency = new MGACheckBox();
    this.labelGLAccount = new Label();
    this.btnCancelChanges = new MGAButton();
    this.radioDebit = new RadioButton();
    this.radioCredit = new RadioButton();
    this.btnAdd = new MGAButton();
    this.label9 = new Label();
    this.label13 = new Label();
    this.txtAmount = new MGATextBox();
    this.txtComments = new MGATextBox();
    this.comboCostCenters = new MGASimpleComboBox();
    this.dropTreeGLAccounts = new ExtendedTreeViewDropDown();
    this.lblCostCenter = new Label();
    this.lblDescription = new Label();
    this.gridAdditionalOffsets = new UltraGrid();
    this.ultraLabel1 = new UltraLabel();
    this.tabSummary = new UltraTabPageControl();
    this.label14 = new Label();
    this.ultraTabPageControl1 = new UltraTabPageControl();
    this.gridNonWorkingDeposit = new UltraGrid();
    this.pnlContainer = new Panel();
    this._formReceivables_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.toolbar = new UltraToolbarsManager(this.components);
    this._formReceivables_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formReceivables_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.tabTransactions = new UltraTabControl();
    this.ultraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.panel1 = new Panel();
    this.comboPayeePaymentMethods = new MvcComboBoxView();
    this.buttonCancelAppliedUnaccounted = new MGAButton();
    this.buttonAppliedUnaccounted = new MGAButton();
    this.checkCreditCard = new MGACheckBox();
    this.btnSearchCheckFrom = new MGAButton();
    this.linkRemoveCheckFrom = new LinkLabel();
    this.txtCheckFrom = new MGATextBox();
    this.label17 = new Label();
    this.comboUnAccountedCostCenter = new MGASimpleComboBox();
    this.label16 = new Label();
    this.txtNonPayableFees = new MGATextBox();
    this.lblNonPayableFees = new Label();
    this.label15 = new Label();
    this.txtPostingMemo = new MGATextBox();
    this.chkReturnPremium = new CheckBox();
    this.label8 = new Label();
    this.comboPaymentMethods = new MGASimpleComboBox();
    this.label7 = new Label();
    this.labelPayAmt = new Label();
    this.txtPayAmount = new MGATextBox();
    this.labelBalance = new Label();
    this.txtBalance = new MGATextBox();
    this.labelCheckDate = new Label();
    this.dateTimeCheckDate = new MGADateTimePicker();
    this.labelReceivedDate = new Label();
    this.labelDepositDate = new Label();
    this.dateTimeReceivedDate = new MGADateTimePicker();
    this.dateTimeDepositDate = new MGADateTimePicker();
    this.labelCheckNumber = new Label();
    this.txtCheckNumber = new MGATextBox();
    this.labelCheckAmount = new Label();
    this.txtCheckAmount = new MGATextBox();
    this.label10 = new Label();
    this.txtAppliedUnAccounted = new MGATextBox();
    this.label12 = new Label();
    this.txtUnAccountedBalance = new MGATextBox();
    this.label11 = new Label();
    this.radioCashReceipt = new RadioButton();
    this.radioCashDisbursement = new RadioButton();
    this.label2 = new Label();
    this.comboBankAccount = new MGASimpleComboBox();
    this.dsBankAccounts = new dsBankAccounts();
    this.txtEntityName = new MGATextBox();
    this.label1 = new Label();
    this.lblbBankCurrency = new Label();
    this._formReceivables_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this.labelCurtain = new Label();
    this.imageList1 = new ImageList(this.components);
    this.radioChipDownView = new RadioButton();
    this.label3 = new Label();
    this.radioSummaryView = new RadioButton();
    this.radioDetailView = new RadioButton();
    this.progressChipDownCreation = new UltraProgressBar();
    this.label5 = new Label();
    this.ultraProgressBar2 = new UltraProgressBar();
    this.toolbarReceivables = new UltraToolbarsManager(this.components);
    this.daGetPayables = new SqlDataAdapter();
    this.cmdPayables = new SqlCommand();
    this.cnPayables = new SqlConnection();
    this.cnReceivables = new SqlConnection();
    this.daGetReceivables = new SqlDataAdapter();
    this.cmdReceivables = new SqlCommand();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.sqlcmdGetBankAccounts = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.AdditionalOffsetToolManager = new UltraToolbarsManager(this.components);
    this._formAdditionalOffsets_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._formAdditionalOffsets_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formAdditionalOffsets_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.toolTip1 = new ToolTip(this.components);
    this.ultraGridExcelExporter1 = new UltraGridExcelExporter(this.components);
    this.appStylistRuntime1 = new AppStylistRuntime(this.components);
    ((Control) this.tabPagePayable).SuspendLayout();
    this.panelToggleCheckRequested.SuspendLayout();
    ((ISupportInitialize) this.dateTimeToggleCheckRequested).BeginInit();
    ((ISupportInitialize) this.checkToggleCheckRequested).BeginInit();
    ((ISupportInitialize) this.gridPayables).BeginInit();
    this.dsOpenPayables.BeginInit();
    this.panel2.SuspendLayout();
    this.pnlPayableChipDownView.SuspendLayout();
    ((Control) this.tabPageReceivable).SuspendLayout();
    ((ISupportInitialize) this.gridReceivables).BeginInit();
    this.dsOpenReceivables.BeginInit();
    this.panelGridOptions.SuspendLayout();
    this.pnlReceivableChipDownView.SuspendLayout();
    ((Control) this.tabNonPayableFees).SuspendLayout();
    ((ISupportInitialize) this.gridNonPayableFees).BeginInit();
    ((Control) this.tabAdditonalOffsets).SuspendLayout();
    ((ISupportInitialize) this.checkBankCurrency).BeginInit();
    ((ISupportInitialize) this.btnCancelChanges).BeginInit();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    ((ISupportInitialize) this.comboCostCenters).BeginInit();
    ((ISupportInitialize) this.gridAdditionalOffsets).BeginInit();
    ((Control) this.tabSummary).SuspendLayout();
    ((Control) this.ultraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.gridNonWorkingDeposit).BeginInit();
    this.pnlContainer.SuspendLayout();
    ((ISupportInitialize) this.toolbar).BeginInit();
    ((ISupportInitialize) this.tabTransactions).BeginInit();
    ((Control) this.tabTransactions).SuspendLayout();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.buttonCancelAppliedUnaccounted).BeginInit();
    ((ISupportInitialize) this.buttonAppliedUnaccounted).BeginInit();
    ((ISupportInitialize) this.checkCreditCard).BeginInit();
    ((ISupportInitialize) this.btnSearchCheckFrom).BeginInit();
    ((ISupportInitialize) this.txtCheckFrom).BeginInit();
    ((ISupportInitialize) this.comboUnAccountedCostCenter).BeginInit();
    ((ISupportInitialize) this.txtNonPayableFees).BeginInit();
    ((ISupportInitialize) this.txtPostingMemo).BeginInit();
    ((ISupportInitialize) this.comboPaymentMethods).BeginInit();
    ((ISupportInitialize) this.txtPayAmount).BeginInit();
    ((ISupportInitialize) this.txtBalance).BeginInit();
    ((ISupportInitialize) this.dateTimeCheckDate).BeginInit();
    ((ISupportInitialize) this.dateTimeReceivedDate).BeginInit();
    ((ISupportInitialize) this.dateTimeDepositDate).BeginInit();
    ((ISupportInitialize) this.txtCheckNumber).BeginInit();
    ((ISupportInitialize) this.txtCheckAmount).BeginInit();
    ((ISupportInitialize) this.txtAppliedUnAccounted).BeginInit();
    ((ISupportInitialize) this.txtUnAccountedBalance).BeginInit();
    ((ISupportInitialize) this.comboBankAccount).BeginInit();
    this.dsBankAccounts.BeginInit();
    ((ISupportInitialize) this.txtEntityName).BeginInit();
    ((ISupportInitialize) this.toolbarReceivables).BeginInit();
    ((ISupportInitialize) this.AdditionalOffsetToolManager).BeginInit();
    this.SuspendLayout();
    ((Control) this.tabPagePayable).Controls.Add((Control) this.panelToggleCheckRequested);
    ((Control) this.tabPagePayable).Controls.Add((Control) this.gridPayables);
    ((Control) this.tabPagePayable).Controls.Add((Control) this.panel2);
    ((Control) this.tabPagePayable).Controls.Add((Control) this.xViewPayable);
    ((Control) this.tabPagePayable).Location = new Point(1, 20);
    ((Control) this.tabPagePayable).Name = "tabPagePayable";
    ((Control) this.tabPagePayable).Size = new Size(842, 704);
    this.panelToggleCheckRequested.Controls.Add((Control) this.dateTimeToggleCheckRequested);
    this.panelToggleCheckRequested.Controls.Add((Control) this.checkToggleCheckRequested);
    this.panelToggleCheckRequested.Location = new Point(229, 265);
    this.panelToggleCheckRequested.Name = "panelToggleCheckRequested";
    this.panelToggleCheckRequested.Size = new Size(117, 26);
    this.panelToggleCheckRequested.TabIndex = 11;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeToggleCheckRequested.Appearance = (AppearanceBase) appearance1;
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
    this.dateTimeToggleCheckRequested.ButtonAppearance = (AppearanceBase) appearance2;
    this.dateTimeToggleCheckRequested.DateTime = new DateTime(2009, 9, 24, 0, 0, 0, 0);
    ((Control) this.dateTimeToggleCheckRequested).Location = new Point(26, 4);
    this.dateTimeToggleCheckRequested.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeToggleCheckRequested).Name = "dateTimeToggleCheckRequested";
    ((Control) this.dateTimeToggleCheckRequested).Size = new Size(85, 20);
    ((Control) this.dateTimeToggleCheckRequested).TabIndex = 1;
    ((UltraControlBase) this.dateTimeToggleCheckRequested).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeToggleCheckRequested).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTimeToggleCheckRequested.Value = (object) new DateTime(2009, 9, 24, 0, 0, 0, 0);
    this.dateTimeToggleCheckRequested.ValueChanged += new EventHandler(this.dateTimeToggleCheckRequested_ValueChanged);
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkToggleCheckRequested).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.checkToggleCheckRequested).CheckAlign = ContentAlignment.MiddleRight;
    ((UltraToggleEditorBase) this.checkToggleCheckRequested).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkToggleCheckRequested).Location = new Point(-36, 3);
    this.checkToggleCheckRequested.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkToggleCheckRequested).Name = "checkToggleCheckRequested";
    ((Control) this.checkToggleCheckRequested).Size = new Size(56, 20);
    ((Control) this.checkToggleCheckRequested).TabIndex = 0;
    ((UltraControlBase) this.checkToggleCheckRequested).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkToggleCheckRequested).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkToggleCheckRequested).CheckedChanged += new EventHandler(this.checkToggleCheckRequested_CheckedChanged);
    this.toolbar.SetContextMenuUltra((Component) this.gridPayables, "PaybleContextMenu");
    ((UltraGridBase) this.gridPayables).DataMember = "OpenPayables";
    ((UltraGridBase) this.gridPayables).DataSource = (object) this.dsOpenPayables;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPayables).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridPayables).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 9;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 27;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 30;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 33;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 24;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance5).Image = componentResourceManager.GetObject("appearance197.Image");
    ultraGridColumn6.CellButtonAppearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Style = (ColumnStyle) 2;
    ultraGridColumn6.Width = 46;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 34;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 8;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 28;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 9;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 28;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 10;
    ultraGridColumn10.Width = 69;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance6).Image = componentResourceManager.GetObject("appearance198.Image");
    ultraGridColumn11.CellButtonAppearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 11;
    ultraGridColumn11.Style = (ColumnStyle) 2;
    ultraGridColumn11.Width = 102;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ultraGridColumn12.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 12;
    ultraGridColumn12.Width = 63 /*0x3F*/;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 13;
    ultraGridColumn13.Width = 83;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn14.Format = "c";
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 14;
    ultraGridColumn14.Width = 77;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance9;
    ultraGridColumn15.Format = "c";
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Amt. PTD";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 15;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 25;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance10;
    ultraGridColumn16.Format = "c";
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn16.Width = 75;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ultraGridColumn17.Format = "c";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 17;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 25;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ultraGridColumn18.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 18;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 25;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ultraGridColumn19.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 19;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 29;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 20;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.Width = 30;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 21;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 33;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 7;
    ultraGridColumn22.Width = 101;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ultraGridColumn23.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 22;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 18;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ultraGridColumn24.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.Width = 18;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ultraGridColumn25.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 24;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 18;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn26.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn26.Format = "c";
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn26.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Prop Amt. Due";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 25;
    ultraGridColumn26.Width = 75;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn27.CellActivation = (Activation) 3;
    ultraGridColumn27.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 26;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn27.Width = 25;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn28.CellActivation = (Activation) 3;
    ultraGridColumn28.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 27;
    ultraGridColumn28.Hidden = true;
    ultraGridColumn28.Width = 33;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn29.CellActivation = (Activation) 3;
    ultraGridColumn29.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 28;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Width = 29;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance14).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn30.CellAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance15).Image = componentResourceManager.GetObject("appearance207.Image");
    ultraGridColumn30.CellButtonAppearance = (AppearanceBase) appearance15;
    ultraGridColumn30.Format = "c";
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn30.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Ap Applied";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 29;
    ultraGridColumn30.Style = (ColumnStyle) 2;
    ultraGridColumn30.Width = 75;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 30;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 97;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 69;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 33;
    ultraGridColumn33.Hidden = true;
    ultraGridColumn33.Width = 61;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 36;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 74;
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 34;
    ultraGridColumn35.Hidden = true;
    ultraGridColumn35.Width = 125;
    ultraGridColumn36.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn36.Header).VisiblePosition = 32 /*0x20*/;
    ultraGridColumn36.Hidden = true;
    ultraGridColumn36.Width = 58;
    ultraGridColumn37.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn37.Header).VisiblePosition = 35;
    ultraGridColumn37.Hidden = true;
    ultraGridColumn37.Width = 88;
    ultraGridColumn38.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn38.Header).VisiblePosition = 37;
    ultraGridColumn38.Hidden = true;
    ultraGridColumn38.Width = 87;
    ultraGridColumn39.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn39.Header).VisiblePosition = 38;
    ultraGridColumn39.Hidden = true;
    ultraGridColumn39.Width = 77;
    ultraGridColumn40.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn40.Header).VisiblePosition = 39;
    ultraGridColumn40.Hidden = true;
    ultraGridColumn40.Width = 75;
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn41.Header).VisiblePosition = 40;
    ultraGridColumn41.Width = 74;
    ultraGridBand1.Columns.AddRange(new object[41]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
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
      (object) ultraGridColumn41
    });
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPayables).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridPayables).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance18).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance19).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance22).BackColor = Color.Transparent;
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPayables).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance23).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridPayables).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridPayables).Dock = DockStyle.Fill;
    ((Control) this.gridPayables).Font = new Font("Tahoma", 8f);
    ((AppearanceBase) appearance25).BackColor = Color.White;
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance25;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn42.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn42.Header).VisiblePosition = 0;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 9;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn43.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn43.Header).VisiblePosition = 1;
    ultraGridColumn43.Hidden = true;
    ultraGridColumn43.Width = 27;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn44.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn44.Header).VisiblePosition = 2;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 30;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn45.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn45.Header).VisiblePosition = 3;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 33;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn46.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn46.Header).VisiblePosition = 4;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 24;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn47.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance26).Image = (object) Resources.wrench_orange;
    ultraGridColumn47.CellButtonAppearance = (AppearanceBase) appearance26;
    ((HeaderBase) ultraGridColumn47.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn47.Header).VisiblePosition = 5;
    ultraGridColumn47.Style = (ColumnStyle) 2;
    ultraGridColumn47.Width = 46;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn48.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn48.Header).VisiblePosition = 6;
    ultraGridColumn48.Hidden = true;
    ultraGridColumn48.Width = 34;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn49.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn49.Header).VisiblePosition = 8;
    ultraGridColumn49.Hidden = true;
    ultraGridColumn49.Width = 28;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn50.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn50.Header).VisiblePosition = 9;
    ultraGridColumn50.Hidden = true;
    ultraGridColumn50.Width = 28;
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn51.Header).VisiblePosition = 10;
    ultraGridColumn51.Width = 69;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn52.CellActivation = (Activation) 1;
    ((AppearanceBase) appearance27).Image = (object) Resources.wrench_orange;
    ultraGridColumn52.CellButtonAppearance = (AppearanceBase) appearance27;
    ((HeaderBase) ultraGridColumn52.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn52.Header).VisiblePosition = 11;
    ultraGridColumn52.Style = (ColumnStyle) 2;
    ultraGridColumn52.Width = 102;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn53.CellActivation = (Activation) 3;
    ultraGridColumn53.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 2;
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn53.Header).VisiblePosition = 12;
    ultraGridColumn53.Width = 63 /*0x3F*/;
    ultraGridColumn54.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn54.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn54.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn54.Header).VisiblePosition = 13;
    ultraGridColumn54.Width = 83;
    ultraGridColumn55.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn55.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Right";
    ultraGridColumn55.CellAppearance = (AppearanceBase) appearance28;
    ultraGridColumn55.Format = "c";
    ((AppearanceBase) appearance29).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn55.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn55.Header).VisiblePosition = 14;
    ultraGridColumn55.Width = 77;
    ultraGridColumn56.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn56.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn56.Header).VisiblePosition = 15;
    ultraGridColumn56.Hidden = true;
    ultraGridColumn56.Width = 25;
    ultraGridColumn56.Format = "c";
    ultraGridColumn57.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn57.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ultraGridColumn57.CellAppearance = (AppearanceBase) appearance30;
    ultraGridColumn57.Format = "c";
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn57.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn57.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn57.Width = 75;
    ultraGridColumn58.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn58.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn58.Header).VisiblePosition = 17;
    ultraGridColumn58.Hidden = true;
    ultraGridColumn58.Width = 25;
    ultraGridColumn58.Format = "c";
    ultraGridColumn59.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn59.CellActivation = (Activation) 3;
    ultraGridColumn59.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn59.Header).VisiblePosition = 18;
    ultraGridColumn59.Hidden = true;
    ultraGridColumn59.Width = 25;
    ultraGridColumn60.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn60.CellActivation = (Activation) 3;
    ultraGridColumn60.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn60.Header).VisiblePosition = 19;
    ultraGridColumn60.Hidden = true;
    ultraGridColumn60.Width = 29;
    ultraGridColumn61.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn61.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn61.Header).VisiblePosition = 20;
    ultraGridColumn61.Hidden = true;
    ultraGridColumn61.Width = 30;
    ultraGridColumn62.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn62.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn62.Header).VisiblePosition = 21;
    ultraGridColumn62.Hidden = true;
    ultraGridColumn62.Width = 33;
    ultraGridColumn63.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn63.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn63.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn63.Header).VisiblePosition = 7;
    ultraGridColumn63.Width = 101;
    ultraGridColumn64.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn64.CellActivation = (Activation) 3;
    ultraGridColumn64.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn64.Header).VisiblePosition = 22;
    ultraGridColumn64.Hidden = true;
    ultraGridColumn64.Width = 18;
    ultraGridColumn65.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn65.CellActivation = (Activation) 3;
    ultraGridColumn65.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn65.Header).VisiblePosition = 23;
    ultraGridColumn65.Hidden = true;
    ultraGridColumn65.Width = 18;
    ultraGridColumn66.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn66.CellActivation = (Activation) 3;
    ultraGridColumn66.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn66.Header).VisiblePosition = 24;
    ultraGridColumn66.Hidden = true;
    ultraGridColumn66.Width = 18;
    ultraGridColumn67.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn67.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Right";
    ultraGridColumn67.CellAppearance = (AppearanceBase) appearance32;
    ultraGridColumn67.Format = "c";
    ((AppearanceBase) appearance33).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn67.Header).Appearance = (AppearanceBase) appearance33;
    ((HeaderBase) ultraGridColumn67.Header).Caption = "Prop Amt. Due";
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn67.Header).VisiblePosition = 25;
    ultraGridColumn67.Width = 75;
    ultraGridColumn68.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn68.CellActivation = (Activation) 3;
    ultraGridColumn68.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn68.Header).VisiblePosition = 26;
    ultraGridColumn68.Hidden = true;
    ultraGridColumn68.Width = 25;
    ultraGridColumn69.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn69.CellActivation = (Activation) 3;
    ultraGridColumn69.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn69.Header).VisiblePosition = 27;
    ultraGridColumn69.Hidden = true;
    ultraGridColumn69.Width = 33;
    ultraGridColumn70.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn70.CellActivation = (Activation) 3;
    ultraGridColumn70.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn70.Header).VisiblePosition = 28;
    ultraGridColumn70.Hidden = true;
    ultraGridColumn70.Width = 29;
    ultraGridColumn71.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance34).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Right";
    ultraGridColumn71.CellAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance35).Image = (object) Resources.wrench_orange;
    ultraGridColumn71.CellButtonAppearance = (AppearanceBase) appearance35;
    ultraGridColumn71.Format = "c";
    ((AppearanceBase) appearance36).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn71.Header).Appearance = (AppearanceBase) appearance36;
    ((HeaderBase) ultraGridColumn71.Header).Caption = "Ap Applied";
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn71.Header).VisiblePosition = 29;
    ultraGridColumn71.Style = (ColumnStyle) 2;
    ultraGridColumn71.Width = 75;
    ultraGridColumn72.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn72.Header).VisiblePosition = 30;
    ultraGridColumn72.Hidden = true;
    ultraGridColumn72.Width = 97;
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn73.Header).VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn73.Hidden = true;
    ultraGridColumn73.Width = 69;
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn74.Header).VisiblePosition = 33;
    ultraGridColumn74.Hidden = true;
    ultraGridColumn74.Width = 61;
    ((HeaderBase) ultraGridColumn75.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn75.Header).VisiblePosition = 36;
    ultraGridColumn75.Hidden = true;
    ultraGridColumn75.Width = 74;
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn76.Header).VisiblePosition = 34;
    ultraGridColumn76.Hidden = true;
    ultraGridColumn76.Width = 125;
    ultraGridColumn77.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn77.Header).VisiblePosition = 32 /*0x20*/;
    ultraGridColumn77.Hidden = true;
    ultraGridColumn77.Width = 58;
    ultraGridColumn78.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn78.Header).VisiblePosition = 35;
    ultraGridColumn78.Hidden = true;
    ultraGridColumn78.Width = 88;
    ultraGridColumn79.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn79.Header).VisiblePosition = 37;
    ultraGridColumn79.Hidden = true;
    ultraGridColumn79.Width = 87;
    ultraGridColumn80.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn80.Header).VisiblePosition = 38;
    ultraGridColumn80.Hidden = true;
    ultraGridColumn80.Width = 77;
    ultraGridColumn81.ExcludeFromColumnChooser = (ExcludeFromColumnChooser) 1;
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn81.Header).VisiblePosition = 39;
    ultraGridColumn81.Hidden = true;
    ultraGridColumn81.Width = 75;
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn82.Header).VisiblePosition = 40;
    ultraGridColumn82.Width = 74;
    ultraGridBand2.Columns.AddRange(new object[41]
    {
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
      (object) ultraGridColumn52,
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55,
      (object) ultraGridColumn56,
      (object) ultraGridColumn57,
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63,
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68,
      (object) ultraGridColumn69,
      (object) ultraGridColumn70,
      (object) ultraGridColumn71,
      (object) ultraGridColumn72,
      (object) ultraGridColumn73,
      (object) ultraGridColumn74,
      (object) ultraGridColumn75,
      (object) ultraGridColumn76,
      (object) ultraGridColumn77,
      (object) ultraGridColumn78,
      (object) ultraGridColumn79,
      (object) ultraGridColumn80,
      (object) ultraGridColumn81,
      (object) ultraGridColumn82
    });
    ultraGridBand2.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "SummaryView";
    ((AppearanceBase) appearance37).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance37).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance37).ForeColor = Color.Black;
    ultraGridLayout1.Override.ActiveRowAppearance = (AppearanceBase) appearance37;
    ultraGridLayout1.Override.AllowColMoving = (AllowColMoving) 3;
    ultraGridLayout1.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout1.Override.AllowColSwapping = (AllowColSwapping) 3;
    ultraGridLayout1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance38).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Left";
    ultraGridLayout1.Override.CellAppearance = (AppearanceBase) appearance38;
    ((AppearanceBase) appearance39).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance39).TextHAlignAsString = "Left";
    ultraGridLayout1.Override.HeaderAppearance = (AppearanceBase) appearance39;
    ultraGridLayout1.Override.HeaderClickAction = (HeaderClickAction) 3;
    ultraGridLayout1.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance40).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout1.Override.RowAlternateAppearance = (AppearanceBase) appearance40;
    ((AppearanceBase) appearance41).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance41;
    ultraGridLayout1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance42).BackColor = Color.Transparent;
    ((AppearanceBase) appearance42).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance42;
    ((AppearanceBase) appearance43).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance43).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance43;
    ((AppearanceBase) appearance44).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance44;
    ultraGridLayout1.ScrollBarLook = scrollBarLook2;
    ((AppearanceBase) appearance45).BackColor = Color.White;
    ((AppearanceBase) appearance45).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout2.Appearance = (AppearanceBase) appearance45;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn83.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn83.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn83.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn83.Header).VisiblePosition = 0;
    ultraGridColumn83.Hidden = true;
    ultraGridColumn83.Width = 23;
    ultraGridColumn84.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn84.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn84.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn84.Header).VisiblePosition = 1;
    ultraGridColumn84.Hidden = true;
    ultraGridColumn84.Width = 45;
    ultraGridColumn85.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn85.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn85.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn85.Header).VisiblePosition = 2;
    ultraGridColumn85.Hidden = true;
    ultraGridColumn85.Width = 52;
    ultraGridColumn86.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn86.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn86.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn86.Header).VisiblePosition = 3;
    ultraGridColumn86.Hidden = true;
    ultraGridColumn86.Width = 47;
    ultraGridColumn87.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn87.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn87.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn87.Header).VisiblePosition = 4;
    ultraGridColumn87.Hidden = true;
    ultraGridColumn87.Width = 37;
    ultraGridColumn88.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn88.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn88.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn88.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn88.Style = (ColumnStyle) 2;
    ultraGridColumn88.Width = 114;
    ultraGridColumn89.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn89.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn89.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn89.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn89.Width = 129;
    ultraGridColumn90.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn90.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn90.Header).Caption = "Effect. Date";
    ((HeaderBase) ultraGridColumn90.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn90.Width = 80 /*0x50*/;
    ultraGridColumn91.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn91.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn91.Header).Caption = "Expir. Date";
    ((HeaderBase) ultraGridColumn91.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn91.Width = 74;
    ultraGridColumn92.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn92.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn92.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn92.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn92.Style = (ColumnStyle) 2;
    ultraGridColumn92.Width = 77;
    ultraGridColumn93.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn93.CellActivation = (Activation) 3;
    ultraGridColumn93.Width = 95;
    ultraGridColumn94.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn94.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn94.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn94.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn94.Width = 191;
    ultraGridColumn95.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn95.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance46).TextHAlignAsString = "Right";
    ultraGridColumn95.CellAppearance = (AppearanceBase) appearance46;
    ultraGridColumn95.Format = "c";
    ((AppearanceBase) appearance47).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn95.Header).Appearance = (AppearanceBase) appearance47;
    ((HeaderBase) ultraGridColumn95.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn95.Width = 188;
    ultraGridColumn96.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn96.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance48).TextHAlignAsString = "Right";
    ultraGridColumn96.CellAppearance = (AppearanceBase) appearance48;
    ultraGridColumn96.Format = "c";
    ((AppearanceBase) appearance49).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn96.Header).Appearance = (AppearanceBase) appearance49;
    ((HeaderBase) ultraGridColumn96.Header).Caption = "Amt. PTD";
    ((HeaderBase) ultraGridColumn96.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn96.Width = 188;
    ultraGridColumn97.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn97.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance50).TextHAlignAsString = "Right";
    ultraGridColumn97.CellAppearance = (AppearanceBase) appearance50;
    ultraGridColumn97.Format = "c";
    ((AppearanceBase) appearance51).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn97.Header).Appearance = (AppearanceBase) appearance51;
    ((HeaderBase) ultraGridColumn97.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn97.Width = 129;
    ultraGridColumn98.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn98.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance52).TextHAlignAsString = "Right";
    ultraGridColumn98.CellAppearance = (AppearanceBase) appearance52;
    ultraGridColumn98.Format = "c";
    ((AppearanceBase) appearance53).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn98.Header).Appearance = (AppearanceBase) appearance53;
    ((HeaderBase) ultraGridColumn98.Header).Caption = "Amt. Rcvd";
    ((HeaderBase) ultraGridColumn98.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn98.Width = 188;
    ultraGridColumn99.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn99.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    ultraGridColumn99.CellAppearance = (AppearanceBase) appearance54;
    ((AppearanceBase) appearance55).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn99.Header).Appearance = (AppearanceBase) appearance55;
    ((HeaderBase) ultraGridColumn99.Header).Caption = "Exch Bal";
    ((HeaderBase) ultraGridColumn99.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn99.Hidden = true;
    ultraGridColumn99.Width = 92;
    ultraGridColumn100.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn100.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Right";
    ultraGridColumn100.CellAppearance = (AppearanceBase) appearance56;
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn100.Header).Appearance = (AppearanceBase) appearance57;
    ((HeaderBase) ultraGridColumn100.Header).Caption = "Un-Acct Bal";
    ((HeaderBase) ultraGridColumn100.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn100.Hidden = true;
    ultraGridColumn100.Width = 92;
    ultraGridColumn101.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn101.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn101.Header).VisiblePosition = 22;
    ultraGridColumn101.Hidden = true;
    ultraGridColumn102.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn102.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn102.Header).VisiblePosition = 23;
    ultraGridColumn102.Hidden = true;
    ultraGridColumn103.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn103.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn103.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn103.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn103.Width = 80 /*0x50*/;
    ultraGridColumn104.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn104.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn104.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn104.Header).VisiblePosition = 18;
    ultraGridColumn104.Hidden = true;
    ultraGridColumn104.Width = 29;
    ultraGridColumn105.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn105.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn105.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn105.Header).VisiblePosition = 20;
    ultraGridColumn105.Hidden = true;
    ultraGridColumn105.Width = 29;
    ultraGridColumn106.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn106.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn106.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn106.Header).VisiblePosition = 21;
    ultraGridColumn106.Hidden = true;
    ultraGridColumn106.Width = 29;
    ultraGridColumn107.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn107.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    ultraGridColumn107.CellAppearance = (AppearanceBase) appearance58;
    ultraGridColumn107.Format = "c";
    ((AppearanceBase) appearance59).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn107.Header).Appearance = (AppearanceBase) appearance59;
    ((HeaderBase) ultraGridColumn107.Header).Caption = "Prop Amt. Due";
    ((HeaderBase) ultraGridColumn107.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn107.Width = 95;
    ultraGridColumn108.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn108.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn108.Header).VisiblePosition = 27;
    ultraGridColumn108.Hidden = true;
    ultraGridColumn109.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn109.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn109.Header).VisiblePosition = 25;
    ultraGridColumn109.Width = 39;
    ultraGridColumn110.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn110.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn110.Header).VisiblePosition = 26;
    ultraGridColumn110.Width = 36;
    ultraGridColumn111.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance60).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance60).TextHAlignAsString = "Right";
    ultraGridColumn111.CellAppearance = (AppearanceBase) appearance60;
    ((AppearanceBase) appearance61).BackColor = Color.LightSteelBlue;
    ultraGridColumn111.CellButtonAppearance = (AppearanceBase) appearance61;
    ultraGridColumn111.Format = "c";
    ((AppearanceBase) appearance62).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn111.Header).Appearance = (AppearanceBase) appearance62;
    ((HeaderBase) ultraGridColumn111.Header).Caption = "AP Applied";
    ((HeaderBase) ultraGridColumn111.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn111.Style = (ColumnStyle) 2;
    ultraGridColumn111.Width = 29;
    ultraGridColumn112.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn112.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn112.Header).VisiblePosition = 29;
    ultraGridColumn112.Hidden = true;
    ((HeaderBase) ultraGridColumn113.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn113.Header).VisiblePosition = 30;
    ultraGridColumn113.Width = 33;
    ((HeaderBase) ultraGridColumn114.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn114.Header).VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn114.Width = 51;
    ((HeaderBase) ultraGridColumn115.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn115.Header).VisiblePosition = 32 /*0x20*/;
    ultraGridColumn115.Width = 50;
    ((HeaderBase) ultraGridColumn116.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn116.Header).VisiblePosition = 33;
    ultraGridColumn116.Width = 44;
    ((HeaderBase) ultraGridColumn117.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn117.Header).VisiblePosition = 34;
    ultraGridColumn117.Width = 43;
    ultraGridColumn118.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance63).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance63).TextHAlignAsString = "Right";
    ultraGridColumn118.CellAppearance = (AppearanceBase) appearance63;
    ultraGridColumn118.DataType = typeof (Decimal);
    ultraGridColumn118.Format = "c";
    ((AppearanceBase) appearance64).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn118.Header).Appearance = (AppearanceBase) appearance64;
    ((HeaderBase) ultraGridColumn118.Header).Caption = "Exch Applied";
    ((HeaderBase) ultraGridColumn118.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn118.Hidden = true;
    ultraGridColumn118.Width = 23;
    ultraGridColumn119.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance65).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance65).TextHAlignAsString = "Right";
    ultraGridColumn119.CellAppearance = (AppearanceBase) appearance65;
    ultraGridColumn119.DataType = typeof (Decimal);
    ultraGridColumn119.Format = "c";
    ((AppearanceBase) appearance66).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn119.Header).Appearance = (AppearanceBase) appearance66;
    ((HeaderBase) ultraGridColumn119.Header).Caption = "Un-Acct Applied";
    ((HeaderBase) ultraGridColumn119.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn119.Hidden = true;
    ultraGridColumn119.Width = 95;
    ultraGridBand3.Columns.AddRange(new object[37]
    {
      (object) ultraGridColumn83,
      (object) ultraGridColumn84,
      (object) ultraGridColumn85,
      (object) ultraGridColumn86,
      (object) ultraGridColumn87,
      (object) ultraGridColumn88,
      (object) ultraGridColumn89,
      (object) ultraGridColumn90,
      (object) ultraGridColumn91,
      (object) ultraGridColumn92,
      (object) ultraGridColumn93,
      (object) ultraGridColumn94,
      (object) ultraGridColumn95,
      (object) ultraGridColumn96,
      (object) ultraGridColumn97,
      (object) ultraGridColumn98,
      (object) ultraGridColumn99,
      (object) ultraGridColumn100,
      (object) ultraGridColumn101,
      (object) ultraGridColumn102,
      (object) ultraGridColumn103,
      (object) ultraGridColumn104,
      (object) ultraGridColumn105,
      (object) ultraGridColumn106,
      (object) ultraGridColumn107,
      (object) ultraGridColumn108,
      (object) ultraGridColumn109,
      (object) ultraGridColumn110,
      (object) ultraGridColumn111,
      (object) ultraGridColumn112,
      (object) ultraGridColumn113,
      (object) ultraGridColumn114,
      (object) ultraGridColumn115,
      (object) ultraGridColumn116,
      (object) ultraGridColumn117,
      (object) ultraGridColumn118,
      (object) ultraGridColumn119
    });
    ultraGridBand3.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup1).Key = "DetailView";
    ultraGridGroup1.RowLayoutGroupInfo.LabelSpan = 1;
    ultraGridBand3.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup1
    });
    ultraGridBand3.LevelCount = 2;
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand3);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "DetailView";
    ((AppearanceBase) appearance67).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance67).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance67).ForeColor = Color.Black;
    ultraGridLayout2.Override.ActiveRowAppearance = (AppearanceBase) appearance67;
    ultraGridLayout2.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridLayout2.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout2.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridLayout2.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridLayout2.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout2.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridLayout2.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridLayout2.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridLayout2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance68).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance68).TextHAlignAsString = "Left";
    ultraGridLayout2.Override.CellAppearance = (AppearanceBase) appearance68;
    ((AppearanceBase) appearance69).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance69).TextHAlignAsString = "Left";
    ultraGridLayout2.Override.HeaderAppearance = (AppearanceBase) appearance69;
    ultraGridLayout2.Override.HeaderClickAction = (HeaderClickAction) 3;
    ultraGridLayout2.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance70).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout2.Override.RowAlternateAppearance = (AppearanceBase) appearance70;
    ((AppearanceBase) appearance71).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance71;
    ultraGridLayout2.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.RowSpacingBefore = 1;
    ((AppearanceBase) appearance72).BackColor = Color.Transparent;
    ((AppearanceBase) appearance72).ForeColor = Color.Black;
    ultraGridLayout2.Override.SelectedRowAppearance = (AppearanceBase) appearance72;
    ((AppearanceBase) appearance73).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance73).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance73;
    ((AppearanceBase) appearance74).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance74;
    ultraGridLayout2.ScrollBarLook = scrollBarLook3;
    ((AppearanceBase) appearance75).BackColor = Color.White;
    ((AppearanceBase) appearance75).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout3.Appearance = (AppearanceBase) appearance75;
    ultraGridLayout3.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn120.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn120.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn120.Header).VisiblePosition = 0;
    ultraGridColumn120.Hidden = true;
    ultraGridColumn120.Width = 23;
    ultraGridColumn121.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn121.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn121.Header).VisiblePosition = 1;
    ultraGridColumn121.Hidden = true;
    ultraGridColumn121.Width = 45;
    ultraGridColumn122.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn122.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn122.Header).VisiblePosition = 2;
    ultraGridColumn122.Hidden = true;
    ultraGridColumn122.Width = 52;
    ultraGridColumn123.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn123.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn123.Header).VisiblePosition = 3;
    ultraGridColumn123.Hidden = true;
    ultraGridColumn123.Width = 47;
    ultraGridColumn124.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn124.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn124.Header).VisiblePosition = 4;
    ultraGridColumn124.Hidden = true;
    ultraGridColumn124.Width = 37;
    ultraGridColumn125.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn125.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn125.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn125.Width = 221;
    ultraGridColumn126.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn126.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn126.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn126.Width = 398;
    ultraGridColumn127.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn127.Header).Caption = "Effect. Date";
    ((HeaderBase) ultraGridColumn127.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn127.Width = 157;
    ultraGridColumn128.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn128.Header).Caption = "Expir. Date";
    ((HeaderBase) ultraGridColumn128.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn128.Width = 56;
    ((HeaderBase) ultraGridColumn129.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn129.Header).VisiblePosition = 9;
    ultraGridColumn130.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn130.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn130.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn130.Hidden = true;
    ultraGridColumn130.Width = 69;
    ultraGridColumn131.CellActivation = (Activation) 3;
    ultraGridColumn131.Hidden = true;
    ultraGridColumn131.Width = 163;
    ultraGridColumn132.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn132.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn132.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn132.Hidden = true;
    ultraGridColumn132.Width = 8;
    ultraGridColumn133.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance76).TextHAlignAsString = "Right";
    ultraGridColumn133.CellAppearance = (AppearanceBase) appearance76;
    ultraGridColumn133.Format = "c";
    ((AppearanceBase) appearance77).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn133.Header).Appearance = (AppearanceBase) appearance77;
    ((HeaderBase) ultraGridColumn133.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn133.Width = 140;
    ultraGridColumn134.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance78).TextHAlignAsString = "Right";
    ultraGridColumn134.CellAppearance = (AppearanceBase) appearance78;
    ultraGridColumn134.Format = "c";
    ((AppearanceBase) appearance79).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn134.Header).Appearance = (AppearanceBase) appearance79;
    ((HeaderBase) ultraGridColumn134.Header).Caption = "Amt. PTD";
    ((HeaderBase) ultraGridColumn134.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn134.Width = 140;
    ultraGridColumn135.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance80).TextHAlignAsString = "Right";
    ultraGridColumn135.CellAppearance = (AppearanceBase) appearance80;
    ultraGridColumn135.Format = "c";
    ((AppearanceBase) appearance81).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn135.Header).Appearance = (AppearanceBase) appearance81;
    ((HeaderBase) ultraGridColumn135.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn135.Width = 140;
    ultraGridColumn136.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance82).TextHAlignAsString = "Right";
    ultraGridColumn136.CellAppearance = (AppearanceBase) appearance82;
    ultraGridColumn136.Format = "c";
    ((AppearanceBase) appearance83).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn136.Header).Appearance = (AppearanceBase) appearance83;
    ((HeaderBase) ultraGridColumn136.Header).Caption = "Amt. Rcvd";
    ((HeaderBase) ultraGridColumn136.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn136.Width = 140;
    ultraGridColumn137.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance84).TextHAlignAsString = "Right";
    ultraGridColumn137.CellAppearance = (AppearanceBase) appearance84;
    ((AppearanceBase) appearance85).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn137.Header).Appearance = (AppearanceBase) appearance85;
    ((HeaderBase) ultraGridColumn137.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn137.Header).VisiblePosition = 17;
    ultraGridColumn137.Hidden = true;
    ultraGridColumn137.Width = 57;
    ultraGridColumn138.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance86).TextHAlignAsString = "Right";
    ultraGridColumn138.CellAppearance = (AppearanceBase) appearance86;
    ((AppearanceBase) appearance87).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn138.Header).Appearance = (AppearanceBase) appearance87;
    ((HeaderBase) ultraGridColumn138.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn138.Header).VisiblePosition = 18;
    ultraGridColumn138.Hidden = true;
    ultraGridColumn138.Width = 65;
    ((HeaderBase) ultraGridColumn139.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn139.Header).VisiblePosition = 23;
    ultraGridColumn139.Hidden = true;
    ((HeaderBase) ultraGridColumn140.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn140.Header).VisiblePosition = 24;
    ultraGridColumn140.Hidden = true;
    ((HeaderBase) ultraGridColumn141.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn141.Header).VisiblePosition = 21;
    ultraGridColumn142.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn142.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn142.Header).VisiblePosition = 19;
    ultraGridColumn142.Hidden = true;
    ultraGridColumn142.Width = 29;
    ultraGridColumn143.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn143.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn143.Header).VisiblePosition = 20;
    ultraGridColumn143.Hidden = true;
    ultraGridColumn143.Width = 29;
    ultraGridColumn144.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn144.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn144.Header).VisiblePosition = 22;
    ultraGridColumn144.Hidden = true;
    ultraGridColumn144.Width = 29;
    ultraGridColumn145.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance88).TextHAlignAsString = "Right";
    ultraGridColumn145.CellAppearance = (AppearanceBase) appearance88;
    ultraGridColumn145.Format = "c";
    ((AppearanceBase) appearance89).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn145.Header).Appearance = (AppearanceBase) appearance89;
    ((HeaderBase) ultraGridColumn145.Header).Caption = "Prop Amt. Due";
    ((HeaderBase) ultraGridColumn145.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn145.Width = 184;
    ((HeaderBase) ultraGridColumn146.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn146.Header).VisiblePosition = 26;
    ((HeaderBase) ultraGridColumn147.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn147.Header).VisiblePosition = 27;
    ((HeaderBase) ultraGridColumn148.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn148.Header).VisiblePosition = 28;
    ((AppearanceBase) appearance90).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance90).TextHAlignAsString = "Right";
    ultraGridColumn149.CellAppearance = (AppearanceBase) appearance90;
    ultraGridColumn149.Format = "c";
    ((AppearanceBase) appearance91).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn149.Header).Appearance = (AppearanceBase) appearance91;
    ((HeaderBase) ultraGridColumn149.Header).Caption = "AP Applied";
    ((HeaderBase) ultraGridColumn149.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn149.Width = 96 /*0x60*/;
    ((HeaderBase) ultraGridColumn150.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn150.Header).VisiblePosition = 30;
    ultraGridColumn150.Hidden = true;
    ((HeaderBase) ultraGridColumn151.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn151.Header).VisiblePosition = 31 /*0x1F*/;
    ((HeaderBase) ultraGridColumn152.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn152.Header).VisiblePosition = 32 /*0x20*/;
    ((HeaderBase) ultraGridColumn153.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn153.Header).VisiblePosition = 33;
    ((HeaderBase) ultraGridColumn154.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn154.Header).VisiblePosition = 34;
    ((HeaderBase) ultraGridColumn155.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn155.Header).VisiblePosition = 35;
    ((HeaderBase) ultraGridColumn156.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn156.Header).VisiblePosition = 36;
    ((HeaderBase) ultraGridColumn157.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn157.Header).VisiblePosition = 37;
    ((HeaderBase) ultraGridColumn158.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn158.Header).VisiblePosition = 38;
    ((HeaderBase) ultraGridColumn159.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn159.Header).VisiblePosition = 39;
    ((HeaderBase) ultraGridColumn160.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn160.Header).VisiblePosition = 40;
    ultraGridBand4.Columns.AddRange(new object[41]
    {
      (object) ultraGridColumn120,
      (object) ultraGridColumn121,
      (object) ultraGridColumn122,
      (object) ultraGridColumn123,
      (object) ultraGridColumn124,
      (object) ultraGridColumn125,
      (object) ultraGridColumn126,
      (object) ultraGridColumn127,
      (object) ultraGridColumn128,
      (object) ultraGridColumn129,
      (object) ultraGridColumn130,
      (object) ultraGridColumn131,
      (object) ultraGridColumn132,
      (object) ultraGridColumn133,
      (object) ultraGridColumn134,
      (object) ultraGridColumn135,
      (object) ultraGridColumn136,
      (object) ultraGridColumn137,
      (object) ultraGridColumn138,
      (object) ultraGridColumn139,
      (object) ultraGridColumn140,
      (object) ultraGridColumn141,
      (object) ultraGridColumn142,
      (object) ultraGridColumn143,
      (object) ultraGridColumn144,
      (object) ultraGridColumn145,
      (object) ultraGridColumn146,
      (object) ultraGridColumn147,
      (object) ultraGridColumn148,
      (object) ultraGridColumn149,
      (object) ultraGridColumn150,
      (object) ultraGridColumn151,
      (object) ultraGridColumn152,
      (object) ultraGridColumn153,
      (object) ultraGridColumn154,
      (object) ultraGridColumn155,
      (object) ultraGridColumn156,
      (object) ultraGridColumn157,
      (object) ultraGridColumn158,
      (object) ultraGridColumn159,
      (object) ultraGridColumn160
    });
    ultraGridBand4.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup2).Key = "DetailView";
    ultraGridGroup2.RowLayoutGroupInfo.LabelSpan = 1;
    ultraGridBand4.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup2
    });
    ultraGridBand4.LevelCount = 2;
    ultraGridLayout3.BandsSerializer.Add((object) ultraGridBand4);
    ultraGridLayout3.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout3).Key = "ChipDownView";
    ((AppearanceBase) appearance92).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance92).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance92).ForeColor = Color.Black;
    ultraGridLayout3.Override.ActiveRowAppearance = (AppearanceBase) appearance92;
    ultraGridLayout3.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridLayout3.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout3.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout3.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout3.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridLayout3.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridLayout3.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridLayout3.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout3.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridLayout3.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridLayout3.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridLayout3.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance93).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance93).TextHAlignAsString = "Left";
    ultraGridLayout3.Override.CellAppearance = (AppearanceBase) appearance93;
    ((AppearanceBase) appearance94).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance94).TextHAlignAsString = "Left";
    ultraGridLayout3.Override.HeaderAppearance = (AppearanceBase) appearance94;
    ultraGridLayout3.Override.HeaderClickAction = (HeaderClickAction) 3;
    ultraGridLayout3.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance95).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout3.Override.RowAlternateAppearance = (AppearanceBase) appearance95;
    ((AppearanceBase) appearance96).BorderColor = Color.LightGray;
    ultraGridLayout3.Override.RowAppearance = (AppearanceBase) appearance96;
    ultraGridLayout3.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridLayout3.Override.RowSpacingBefore = 1;
    ((AppearanceBase) appearance97).BackColor = Color.Transparent;
    ((AppearanceBase) appearance97).ForeColor = Color.Black;
    ultraGridLayout3.Override.SelectedRowAppearance = (AppearanceBase) appearance97;
    ((AppearanceBase) appearance98).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance98).BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance98;
    ((AppearanceBase) appearance99).BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance99;
    ultraGridLayout3.ScrollBarLook = scrollBarLook4;
    ((UltraGridBase) this.gridPayables).Layouts.Add(ultraGridLayout1);
    ((UltraGridBase) this.gridPayables).Layouts.Add(ultraGridLayout2);
    ((UltraGridBase) this.gridPayables).Layouts.Add(ultraGridLayout3);
    ((Control) this.gridPayables).Location = new Point(0, 24);
    ((Control) this.gridPayables).Name = "gridPayables";
    ((Control) this.gridPayables).Size = new Size(842, 680);
    ((Control) this.gridPayables).TabIndex = 4;
    this.gridPayables.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridPayables).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPayables).UseOsThemes = (DefaultableBoolean) 2;
    this.gridPayables.AfterCellUpdate += new CellEventHandler(this.gridPayables_AfterCellUpdate);
    this.gridPayables.InitializeLayout += new InitializeLayoutEventHandler(this.gridPayables_InitializeLayout);
    this.gridPayables.InitializeRow += new InitializeRowEventHandler(this.gridPayables_InitializeRow);
    this.gridPayables.ClickCellButton += new CellEventHandler(this.gridPayables_ClickCellButton);
    this.gridPayables.AfterSelectChange += new AfterSelectChangeEventHandler(this.Grid_AferSelectChange);
    this.gridPayables.BeforeCellUpdate += new BeforeCellUpdateEventHandler(this.gridPayables_BeforeCellUpdate);
    this.gridPayables.CellDataError += new CellDataErrorEventHandler(this.gridPayables_CellDataError);
    ((UltraGridBase) this.gridPayables).AfterColPosChanged += new AfterColPosChangedEventHandler(this.gridPayables_AfterColPosChanged);
    ((UltraGridBase) this.gridPayables).BeforeColumnChooserDisplayed += new BeforeColumnChooserDisplayedEventHandler(this.gridPayables_BeforeColumnChooserDisplayed);
    ((Control) this.gridPayables).KeyDown += new KeyEventHandler(this.gridPayable_KeyDown);
    this.dsOpenPayables.DataSetName = "dsOpenPayables";
    this.dsOpenPayables.Locale = new CultureInfo("en-US");
    this.dsOpenPayables.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panel2.BackColor = Color.FromArgb(239, 247, 253);
    this.panel2.Controls.Add((Control) this.labelPayablesExist);
    this.panel2.Controls.Add((Control) this.radioPayableDetailView);
    this.panel2.Controls.Add((Control) this.radioPayableSummaryView);
    this.panel2.Controls.Add((Control) this.radioPayableChipDownView);
    this.panel2.Controls.Add((Control) this.pnlPayableChipDownView);
    this.panel2.Dock = DockStyle.Top;
    this.panel2.Location = new Point(0, 0);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(842, 24);
    this.panel2.TabIndex = 10;
    this.labelPayablesExist.AutoSize = true;
    this.labelPayablesExist.BackColor = Color.Transparent;
    this.labelPayablesExist.ForeColor = Color.Red;
    this.labelPayablesExist.Image = (Image) Resources.exclamation;
    this.labelPayablesExist.ImageAlign = ContentAlignment.MiddleLeft;
    this.labelPayablesExist.Location = new Point(321, 5);
    this.labelPayablesExist.Name = "labelPayablesExist";
    this.labelPayablesExist.Size = new Size(299, 13);
    this.labelPayablesExist.TabIndex = 34;
    this.labelPayablesExist.Text = "      Payable(s) with the same invoice number already loaded!";
    this.labelPayablesExist.TextAlign = ContentAlignment.MiddleRight;
    this.labelPayablesExist.Visible = false;
    this.radioPayableDetailView.BackColor = Color.Transparent;
    this.radioPayableDetailView.Enabled = false;
    this.radioPayableDetailView.FlatStyle = FlatStyle.Flat;
    this.radioPayableDetailView.Location = new Point(106, 4);
    this.radioPayableDetailView.Name = "radioPayableDetailView";
    this.radioPayableDetailView.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.radioPayableDetailView.TabIndex = 13;
    this.radioPayableDetailView.Text = "Detail View";
    this.radioPayableDetailView.UseVisualStyleBackColor = false;
    this.radioPayableDetailView.CheckedChanged += new EventHandler(this.PayableGridViewOptionsChangedHandler);
    this.radioPayableSummaryView.BackColor = Color.Transparent;
    this.radioPayableSummaryView.Checked = true;
    this.radioPayableSummaryView.Enabled = false;
    this.radioPayableSummaryView.FlatStyle = FlatStyle.Flat;
    this.radioPayableSummaryView.Location = new Point(5, 4);
    this.radioPayableSummaryView.Name = "radioPayableSummaryView";
    this.radioPayableSummaryView.Size = new Size(94, 16 /*0x10*/);
    this.radioPayableSummaryView.TabIndex = 12;
    this.radioPayableSummaryView.TabStop = true;
    this.radioPayableSummaryView.Text = "Summary View";
    this.radioPayableSummaryView.UseVisualStyleBackColor = false;
    this.radioPayableSummaryView.CheckedChanged += new EventHandler(this.PayableGridViewOptionsChangedHandler);
    this.radioPayableChipDownView.BackColor = Color.Transparent;
    this.radioPayableChipDownView.Enabled = false;
    this.radioPayableChipDownView.FlatStyle = FlatStyle.Flat;
    this.radioPayableChipDownView.Location = new Point(203, 4);
    this.radioPayableChipDownView.Name = "radioPayableChipDownView";
    this.radioPayableChipDownView.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.radioPayableChipDownView.TabIndex = 14;
    this.radioPayableChipDownView.Text = "Installment View";
    this.radioPayableChipDownView.UseVisualStyleBackColor = false;
    this.radioPayableChipDownView.Visible = false;
    this.radioPayableChipDownView.CheckedChanged += new EventHandler(this.PayableGridViewOptionsChangedHandler);
    this.pnlPayableChipDownView.BackColor = Color.FromArgb(239, 247, 253);
    this.pnlPayableChipDownView.Controls.Add((Control) this.label6);
    this.pnlPayableChipDownView.Controls.Add((Control) this.progressBarPayablesChipDown);
    this.pnlPayableChipDownView.Dock = DockStyle.Right;
    this.pnlPayableChipDownView.Location = new Point(530, 0);
    this.pnlPayableChipDownView.Name = "pnlPayableChipDownView";
    this.pnlPayableChipDownView.Size = new Size(312, 24);
    this.pnlPayableChipDownView.TabIndex = 15;
    this.pnlPayableChipDownView.Visible = false;
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.Transparent;
    this.label6.Location = new Point(8, 4);
    this.label6.Name = "label6";
    this.label6.Size = new Size(133, 13);
    this.label6.TabIndex = 0;
    this.label6.Text = "Creating Installment View:";
    ((Control) this.progressBarPayablesChipDown).Location = new Point(160 /*0xA0*/, 6);
    ((Control) this.progressBarPayablesChipDown).Name = "progressBarPayablesChipDown";
    ((Control) this.progressBarPayablesChipDown).Size = new Size(144 /*0x90*/, 12);
    ((Control) this.progressBarPayablesChipDown).TabIndex = 1;
    ((Control) this.progressBarPayablesChipDown).Text = "[Formatted]";
    this.xViewPayable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.xViewPayable.BackColor = Color.White;
    this.xViewPayable.Font = new Font("Tahoma", 8f);
    this.xViewPayable.Location = new Point(351, 234);
    this.xViewPayable.Name = "xViewPayable";
    this.xViewPayable.Size = new Size(472, 264);
    this.xViewPayable.TabIndex = 9;
    this.xViewPayable.Visible = false;
    this.xViewPayable.ViewPolicyDetailClicked += new PayablesInformationViewer.ViewPolicyDetailClickedEventHandler(this.xViewPayable_ViewPolicyDetailClicked);
    this.xViewPayable.WriteOffPayableClicked += new PayablesInformationViewer.WriteOffPayableClickedEventHandler(this.xViewPayable_WriteOffPayableClicked);
    ((Control) this.tabPageReceivable).Controls.Add((Control) this.gridReceivables);
    ((Control) this.tabPageReceivable).Controls.Add((Control) this.panelGridOptions);
    ((Control) this.tabPageReceivable).Controls.Add((Control) this.xViewReceivable);
    ((Control) this.tabPageReceivable).Location = new Point(-10000, -10000);
    ((Control) this.tabPageReceivable).Name = "tabPageReceivable";
    ((Control) this.tabPageReceivable).Size = new Size(842, 704);
    this.toolbar.SetContextMenuUltra((Component) this.gridReceivables, "ReceivableContextMenu");
    ((UltraGridBase) this.gridReceivables).DataMember = "OpenReceivables";
    ((UltraGridBase) this.gridReceivables).DataSource = (object) this.dsOpenReceivables;
    ((AppearanceBase) appearance100).BackColor = Color.White;
    ((AppearanceBase) appearance100).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Appearance = (AppearanceBase) appearance100;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn161.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn161.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn161.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn161.Header).VisiblePosition = 3;
    ultraGridColumn161.Hidden = true;
    ultraGridColumn161.Width = 164;
    ultraGridColumn162.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn162.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn162.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn162.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn162.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn162.Style = (ColumnStyle) 2;
    ultraGridColumn162.Width = 107;
    ultraGridColumn163.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn163.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn163.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn163.Header).VisiblePosition = 1;
    ultraGridColumn163.Hidden = true;
    ultraGridColumn163.Width = 27;
    ultraGridColumn164.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn164.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn164.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn164.Header).VisiblePosition = 4;
    ultraGridColumn164.Hidden = true;
    ultraGridColumn164.Width = 27;
    ultraGridColumn165.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn165.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn165.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn165.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn165.Header).VisiblePosition = 13;
    ultraGridColumn165.Style = (ColumnStyle) 2;
    ultraGridColumn165.Width = 61;
    ultraGridColumn166.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn166.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn166.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn166.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn166.Header).VisiblePosition = 23;
    ultraGridColumn166.Hidden = true;
    ultraGridColumn166.Width = 162;
    ultraGridColumn167.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn167.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn167.Header).Caption = "Effect. Date";
    ((HeaderBase) ultraGridColumn167.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn167.Header).VisiblePosition = 25;
    ultraGridColumn167.Hidden = true;
    ultraGridColumn167.Width = 107;
    ultraGridColumn168.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn168.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn168.Header).Caption = "Expir. Date";
    ((HeaderBase) ultraGridColumn168.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn168.Header).VisiblePosition = 26;
    ultraGridColumn168.Hidden = true;
    ultraGridColumn168.Width = 63 /*0x3F*/;
    ultraGridColumn169.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn169.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn169.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn169.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn169.Header).VisiblePosition = 17;
    ultraGridColumn169.Width = 80 /*0x50*/;
    ((HeaderBase) ultraGridColumn170.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn170.Header).VisiblePosition = 9;
    ultraGridColumn170.Hidden = true;
    ultraGridColumn170.Width = 67;
    ultraGridColumn171.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn171.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn171.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn171.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn171.Header).VisiblePosition = 24;
    ultraGridColumn171.Hidden = true;
    ultraGridColumn171.Width = 176 /*0xB0*/;
    ultraGridColumn172.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn172.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn172.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn172.Header).VisiblePosition = 2;
    ultraGridColumn172.Hidden = true;
    ultraGridColumn172.Width = 25;
    ultraGridColumn173.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn173.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn173.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn173.Header).VisiblePosition = 0;
    ultraGridColumn173.Hidden = true;
    ultraGridColumn173.Width = 22;
    ultraGridColumn174.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn174.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance101).TextHAlignAsString = "Right";
    ultraGridColumn174.CellAppearance = (AppearanceBase) appearance101;
    ultraGridColumn174.Format = "c";
    ((AppearanceBase) appearance102).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn174.Header).Appearance = (AppearanceBase) appearance102;
    ((HeaderBase) ultraGridColumn174.Header).Caption = "Gross Billed";
    ((HeaderBase) ultraGridColumn174.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn174.Header).VisiblePosition = 18;
    ultraGridColumn174.Width = 90;
    ultraGridColumn175.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn175.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance103).TextHAlignAsString = "Right";
    ultraGridColumn175.CellAppearance = (AppearanceBase) appearance103;
    ultraGridColumn175.Format = "c";
    ((AppearanceBase) appearance104).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn175.Header).Appearance = (AppearanceBase) appearance104;
    ((HeaderBase) ultraGridColumn175.Header).Caption = "Amt PTD.";
    ((HeaderBase) ultraGridColumn175.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn175.Header).VisiblePosition = 28;
    ultraGridColumn175.Hidden = true;
    ultraGridColumn175.Width = 109;
    ultraGridColumn176.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn176.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance105).TextHAlignAsString = "Right";
    ultraGridColumn176.CellAppearance = (AppearanceBase) appearance105;
    ultraGridColumn176.Format = "c";
    ((AppearanceBase) appearance106).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn176.Header).Appearance = (AppearanceBase) appearance106;
    ((HeaderBase) ultraGridColumn176.Header).Caption = "Net. Due";
    ((HeaderBase) ultraGridColumn176.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn176.Header).VisiblePosition = 19;
    ultraGridColumn176.Width = 74;
    ultraGridColumn177.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn177.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance107).TextHAlignAsString = "Right";
    ultraGridColumn177.CellAppearance = (AppearanceBase) appearance107;
    ultraGridColumn177.Format = "c";
    ((AppearanceBase) appearance108).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn177.Header).Appearance = (AppearanceBase) appearance108;
    ((HeaderBase) ultraGridColumn177.Header).Caption = "Amt PTC.";
    ((HeaderBase) ultraGridColumn177.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn177.Header).VisiblePosition = 27;
    ultraGridColumn177.Hidden = true;
    ultraGridColumn177.Width = 97;
    ultraGridColumn178.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn178.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance109).TextHAlignAsString = "Right";
    ultraGridColumn178.CellAppearance = (AppearanceBase) appearance109;
    ultraGridColumn178.Format = "c";
    ((AppearanceBase) appearance110).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn178.Header).Appearance = (AppearanceBase) appearance110;
    ((HeaderBase) ultraGridColumn178.Header).Caption = "Un-Acct. Bal.";
    ((HeaderBase) ultraGridColumn178.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn178.Header).VisiblePosition = 30;
    ultraGridColumn178.Hidden = true;
    ultraGridColumn178.Width = 177;
    ultraGridColumn179.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn179.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance111).TextHAlignAsString = "Right";
    ultraGridColumn179.CellAppearance = (AppearanceBase) appearance111;
    ultraGridColumn179.Format = "c";
    ((AppearanceBase) appearance112).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn179.Header).Appearance = (AppearanceBase) appearance112;
    ((HeaderBase) ultraGridColumn179.Header).Caption = "Exch. Bal.";
    ((HeaderBase) ultraGridColumn179.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn179.Header).VisiblePosition = 29;
    ultraGridColumn179.Hidden = true;
    ultraGridColumn179.Width = 145;
    ultraGridColumn180.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn180.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn180.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn180.Header).VisiblePosition = 5;
    ultraGridColumn180.Hidden = true;
    ultraGridColumn180.Width = 10;
    ultraGridColumn181.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn181.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn181.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn181.Header).VisiblePosition = 6;
    ultraGridColumn181.Hidden = true;
    ultraGridColumn181.Width = 10;
    ultraGridColumn182.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn182.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn182.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn182.Header).VisiblePosition = 7;
    ultraGridColumn182.Hidden = true;
    ultraGridColumn182.Width = 10;
    ultraGridColumn183.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn183.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn183.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn183.Header).VisiblePosition = 8;
    ultraGridColumn183.Hidden = true;
    ultraGridColumn183.Width = 36;
    ultraGridColumn184.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn184.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn184.Header).Caption = "Current Status";
    ((HeaderBase) ultraGridColumn184.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn184.Header).VisiblePosition = 14;
    ultraGridColumn184.Width = 148;
    ultraGridColumn185.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn185.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn185.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn185.Header).VisiblePosition = 10;
    ultraGridColumn185.Hidden = true;
    ultraGridColumn185.Width = 114;
    ultraGridColumn186.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn186.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn186.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn186.Header).VisiblePosition = 11;
    ultraGridColumn186.Hidden = true;
    ultraGridColumn187.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn187.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn187.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn187.Header).VisiblePosition = 12;
    ultraGridColumn187.Hidden = true;
    ultraGridColumn188.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance113).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance113).TextHAlignAsString = "Right";
    ultraGridColumn188.CellAppearance = (AppearanceBase) appearance113;
    ((AppearanceBase) appearance114).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance114).Image = (object) Resources.TransactionBuilder;
    ultraGridColumn188.CellButtonAppearance = (AppearanceBase) appearance114;
    ultraGridColumn188.Format = "c";
    ((AppearanceBase) appearance115).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn188.Header).Appearance = (AppearanceBase) appearance115;
    ((HeaderBase) ultraGridColumn188.Header).Caption = "AR Applied";
    ((HeaderBase) ultraGridColumn188.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn188.Header).VisiblePosition = 20;
    ultraGridColumn188.Style = (ColumnStyle) 2;
    ultraGridColumn188.Width = 94;
    ultraGridColumn189.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance116).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance116).TextHAlignAsString = "Right";
    ultraGridColumn189.CellAppearance = (AppearanceBase) appearance116;
    ultraGridColumn189.Format = "c";
    ((AppearanceBase) appearance117).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn189.Header).Appearance = (AppearanceBase) appearance117;
    ((HeaderBase) ultraGridColumn189.Header).Caption = "Exch. Applied";
    ((HeaderBase) ultraGridColumn189.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn189.Header).VisiblePosition = 21;
    ultraGridColumn189.Width = 86;
    ultraGridColumn190.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance118).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance118).TextHAlignAsString = "Right";
    ultraGridColumn190.CellAppearance = (AppearanceBase) appearance118;
    ultraGridColumn190.Format = "c";
    ((AppearanceBase) appearance119).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn190.Header).Appearance = (AppearanceBase) appearance119;
    ((HeaderBase) ultraGridColumn190.Header).Caption = "Un-Acct. Applied";
    ((HeaderBase) ultraGridColumn190.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn190.Header).VisiblePosition = 22;
    ultraGridColumn190.Width = 100;
    ((HeaderBase) ultraGridColumn191.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn191.Header).VisiblePosition = 15;
    ultraGridColumn191.Hidden = true;
    ultraGridColumn191.Width = 85;
    ((HeaderBase) ultraGridColumn192.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn192.Header).VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn192.Hidden = true;
    ultraGridColumn192.Width = 119;
    ((HeaderBase) ultraGridColumn193.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn193.Header).VisiblePosition = 32 /*0x20*/;
    ultraGridColumn193.Hidden = true;
    ultraGridColumn193.Width = 50;
    ((HeaderBase) ultraGridColumn194.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn194.Header).VisiblePosition = 33;
    ultraGridColumn194.Hidden = true;
    ultraGridColumn194.Width = 78;
    ((HeaderBase) ultraGridColumn195.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn195.Header).VisiblePosition = 34;
    ultraGridColumn195.Hidden = true;
    ultraGridColumn195.Width = 77;
    ((HeaderBase) ultraGridColumn196.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn196.Header).VisiblePosition = 35;
    ultraGridColumn196.Hidden = true;
    ultraGridColumn196.Width = 68;
    ((HeaderBase) ultraGridColumn197.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn197.Header).VisiblePosition = 36;
    ultraGridColumn197.Hidden = true;
    ultraGridColumn197.Width = 66;
    ((HeaderBase) ultraGridColumn198.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn198.Header).VisiblePosition = 37;
    ultraGridColumn198.Hidden = true;
    ultraGridColumn198.Width = 88;
    ultraGridBand5.Columns.AddRange(new object[38]
    {
      (object) ultraGridColumn161,
      (object) ultraGridColumn162,
      (object) ultraGridColumn163,
      (object) ultraGridColumn164,
      (object) ultraGridColumn165,
      (object) ultraGridColumn166,
      (object) ultraGridColumn167,
      (object) ultraGridColumn168,
      (object) ultraGridColumn169,
      (object) ultraGridColumn170,
      (object) ultraGridColumn171,
      (object) ultraGridColumn172,
      (object) ultraGridColumn173,
      (object) ultraGridColumn174,
      (object) ultraGridColumn175,
      (object) ultraGridColumn176,
      (object) ultraGridColumn177,
      (object) ultraGridColumn178,
      (object) ultraGridColumn179,
      (object) ultraGridColumn180,
      (object) ultraGridColumn181,
      (object) ultraGridColumn182,
      (object) ultraGridColumn183,
      (object) ultraGridColumn184,
      (object) ultraGridColumn185,
      (object) ultraGridColumn186,
      (object) ultraGridColumn187,
      (object) ultraGridColumn188,
      (object) ultraGridColumn189,
      (object) ultraGridColumn190,
      (object) ultraGridColumn191,
      (object) ultraGridColumn192,
      (object) ultraGridColumn193,
      (object) ultraGridColumn194,
      (object) ultraGridColumn195,
      (object) ultraGridColumn196,
      (object) ultraGridColumn197,
      (object) ultraGridColumn198
    });
    ultraGridBand5.GroupHeadersVisible = false;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance120).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance120).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance120).ForeColor = Color.Black;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance120;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance121).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance121).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance121;
    ((AppearanceBase) appearance122).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance122).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance122;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance123).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance123;
    ((AppearanceBase) appearance124).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance124;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.RowSpacingBefore = 1;
    ((AppearanceBase) appearance125).BackColor = Color.Transparent;
    ((AppearanceBase) appearance125).ForeColor = Color.Black;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance125;
    ((AppearanceBase) appearance126).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance126).BorderColor = Color.Silver;
    scrollBarLook5.ButtonAppearance = (AppearanceBase) appearance126;
    ((AppearanceBase) appearance127).BackColor = Color.White;
    scrollBarLook5.TrackAppearance = (AppearanceBase) appearance127;
    ((UltraGridBase) this.gridReceivables).DisplayLayout.ScrollBarLook = scrollBarLook5;
    ((Control) this.gridReceivables).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance128).BackColor = Color.White;
    ((AppearanceBase) appearance128).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout4.Appearance = (AppearanceBase) appearance128;
    ultraGridLayout4.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn199.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn199.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn199.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn199.Header).VisiblePosition = 10;
    ultraGridColumn199.Hidden = true;
    ultraGridColumn199.Width = 164;
    ultraGridColumn200.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn200.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn200.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn200.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn200.Style = (ColumnStyle) 2;
    ultraGridColumn200.Width = 115;
    ultraGridColumn201.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn201.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn201.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn201.Header).VisiblePosition = 2;
    ultraGridColumn201.Hidden = true;
    ultraGridColumn201.Width = 27;
    ultraGridColumn202.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn202.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn202.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn202.Header).VisiblePosition = 11;
    ultraGridColumn202.Hidden = true;
    ultraGridColumn202.Width = 27;
    ultraGridColumn203.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn203.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn203.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn203.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn203.Style = (ColumnStyle) 2;
    ultraGridColumn203.Width = 139;
    ultraGridColumn204.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn204.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn204.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn204.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn204.Width = 162;
    ultraGridColumn205.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn205.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn205.Header).Caption = "Effect. Date";
    ((HeaderBase) ultraGridColumn205.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn205.Width = 90;
    ultraGridColumn206.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn206.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn206.Header).Caption = "Expir. Date";
    ((HeaderBase) ultraGridColumn206.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn206.Width = 65;
    ultraGridColumn207.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn207.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn207.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn207.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn207.Width = 92;
    ultraGridColumn208.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn208.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn208.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn208.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn208.Width = 162;
    ultraGridColumn209.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn209.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn209.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn209.Header).VisiblePosition = 9;
    ultraGridColumn209.Hidden = true;
    ultraGridColumn209.Width = 25;
    ultraGridColumn210.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn210.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn210.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn210.Header).VisiblePosition = 1;
    ultraGridColumn210.Hidden = true;
    ultraGridColumn210.Width = 22;
    ultraGridColumn211.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn211.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance129).TextHAlignAsString = "Right";
    ultraGridColumn211.CellAppearance = (AppearanceBase) appearance129;
    ultraGridColumn211.Format = "c";
    ((AppearanceBase) appearance130).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn211.Header).Appearance = (AppearanceBase) appearance130;
    ((HeaderBase) ultraGridColumn211.Header).Caption = "Gross Billed";
    ((HeaderBase) ultraGridColumn211.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn211.Width = 103;
    ultraGridColumn212.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn212.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance131).TextHAlignAsString = "Right";
    ultraGridColumn212.CellAppearance = (AppearanceBase) appearance131;
    ultraGridColumn212.Format = "c";
    ((AppearanceBase) appearance132).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn212.Header).Appearance = (AppearanceBase) appearance132;
    ((HeaderBase) ultraGridColumn212.Header).Caption = "Amt PTD.";
    ((HeaderBase) ultraGridColumn212.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn212.Width = 72;
    ultraGridColumn213.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn213.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance133).TextHAlignAsString = "Right";
    ultraGridColumn213.CellAppearance = (AppearanceBase) appearance133;
    ultraGridColumn213.Format = "c";
    ((AppearanceBase) appearance134).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn213.Header).Appearance = (AppearanceBase) appearance134;
    ((HeaderBase) ultraGridColumn213.Header).Caption = "Net. Due";
    ((HeaderBase) ultraGridColumn213.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn213.Width = 83;
    ultraGridColumn214.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn214.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance135).TextHAlignAsString = "Right";
    ultraGridColumn214.CellAppearance = (AppearanceBase) appearance135;
    ultraGridColumn214.Format = "c";
    ((AppearanceBase) appearance136).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn214.Header).Appearance = (AppearanceBase) appearance136;
    ((HeaderBase) ultraGridColumn214.Header).Caption = "Amt PTC.";
    ((HeaderBase) ultraGridColumn214.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn214.Width = 72;
    ultraGridColumn215.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn215.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance137).TextHAlignAsString = "Right";
    ultraGridColumn215.CellAppearance = (AppearanceBase) appearance137;
    ultraGridColumn215.Format = "c";
    ((AppearanceBase) appearance138).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn215.Header).Appearance = (AppearanceBase) appearance138;
    ((HeaderBase) ultraGridColumn215.Header).Caption = "Un-Acct. Bal.";
    ((HeaderBase) ultraGridColumn215.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn215.Width = 83;
    ultraGridColumn216.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn216.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance139).TextHAlignAsString = "Right";
    ultraGridColumn216.CellAppearance = (AppearanceBase) appearance139;
    ultraGridColumn216.Format = "c";
    ((AppearanceBase) appearance140).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn216.Header).Appearance = (AppearanceBase) appearance140;
    ((HeaderBase) ultraGridColumn216.Header).Caption = "Exch. Bal.";
    ((HeaderBase) ultraGridColumn216.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn216.Width = 83;
    ultraGridColumn217.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn217.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn217.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn217.Header).VisiblePosition = 18;
    ultraGridColumn217.Hidden = true;
    ultraGridColumn217.Width = 10;
    ultraGridColumn218.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn218.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn218.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn218.Header).VisiblePosition = 19;
    ultraGridColumn218.Hidden = true;
    ultraGridColumn218.Width = 10;
    ultraGridColumn219.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn219.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn219.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn219.Header).VisiblePosition = 20;
    ultraGridColumn219.Hidden = true;
    ultraGridColumn219.Width = 10;
    ultraGridColumn220.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn220.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn220.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn220.Header).VisiblePosition = 21;
    ultraGridColumn220.Hidden = true;
    ultraGridColumn220.Width = 36;
    ultraGridColumn221.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn221.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn221.Header).Caption = "Current Status";
    ((HeaderBase) ultraGridColumn221.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn221.Width = 107;
    ultraGridColumn222.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn222.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn222.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn222.Header).VisiblePosition = 23;
    ultraGridColumn222.Hidden = true;
    ultraGridColumn222.Width = 114;
    ultraGridColumn223.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn223.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn223.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn223.Header).VisiblePosition = 24;
    ultraGridColumn223.Hidden = true;
    ultraGridColumn224.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn224.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn224.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn224.Header).VisiblePosition = 25;
    ultraGridColumn224.Hidden = true;
    ultraGridColumn225.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance141).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance141).TextHAlignAsString = "Right";
    ultraGridColumn225.CellAppearance = (AppearanceBase) appearance141;
    ((AppearanceBase) appearance142).BackColor = Color.LightSteelBlue;
    ultraGridColumn225.CellButtonAppearance = (AppearanceBase) appearance142;
    ultraGridColumn225.Format = "c";
    ((AppearanceBase) appearance143).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn225.Header).Appearance = (AppearanceBase) appearance143;
    ((HeaderBase) ultraGridColumn225.Header).Caption = "AR Applied";
    ((HeaderBase) ultraGridColumn225.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn225.Style = (ColumnStyle) 2;
    ultraGridColumn225.Width = 83;
    ultraGridColumn226.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance144).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance144).TextHAlignAsString = "Right";
    ultraGridColumn226.CellAppearance = (AppearanceBase) appearance144;
    ultraGridColumn226.Format = "c";
    ((AppearanceBase) appearance145).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn226.Header).Appearance = (AppearanceBase) appearance145;
    ((HeaderBase) ultraGridColumn226.Header).Caption = "Exch. Applied";
    ((HeaderBase) ultraGridColumn226.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn226.Width = 83;
    ultraGridColumn227.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance146).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance146).TextHAlignAsString = "Right";
    ultraGridColumn227.CellAppearance = (AppearanceBase) appearance146;
    ultraGridColumn227.Format = "c";
    ((AppearanceBase) appearance147).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn227.Header).Appearance = (AppearanceBase) appearance147;
    ((HeaderBase) ultraGridColumn227.Header).Caption = "Un-Acct. Applied";
    ((HeaderBase) ultraGridColumn227.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn227.Width = 86;
    ((HeaderBase) ultraGridColumn228.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn228.Header).VisiblePosition = 29;
    ((HeaderBase) ultraGridColumn229.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn229.Header).VisiblePosition = 30;
    ((HeaderBase) ultraGridColumn230.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn230.Header).VisiblePosition = 31 /*0x1F*/;
    ((HeaderBase) ultraGridColumn231.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn231.Header).VisiblePosition = 32 /*0x20*/;
    ((HeaderBase) ultraGridColumn232.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn232.Header).VisiblePosition = 33;
    ((HeaderBase) ultraGridColumn233.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn233.Header).VisiblePosition = 34;
    ((HeaderBase) ultraGridColumn234.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn234.Header).VisiblePosition = 35;
    ultraGridBand6.Columns.AddRange(new object[36]
    {
      (object) ultraGridColumn199,
      (object) ultraGridColumn200,
      (object) ultraGridColumn201,
      (object) ultraGridColumn202,
      (object) ultraGridColumn203,
      (object) ultraGridColumn204,
      (object) ultraGridColumn205,
      (object) ultraGridColumn206,
      (object) ultraGridColumn207,
      (object) ultraGridColumn208,
      (object) ultraGridColumn209,
      (object) ultraGridColumn210,
      (object) ultraGridColumn211,
      (object) ultraGridColumn212,
      (object) ultraGridColumn213,
      (object) ultraGridColumn214,
      (object) ultraGridColumn215,
      (object) ultraGridColumn216,
      (object) ultraGridColumn217,
      (object) ultraGridColumn218,
      (object) ultraGridColumn219,
      (object) ultraGridColumn220,
      (object) ultraGridColumn221,
      (object) ultraGridColumn222,
      (object) ultraGridColumn223,
      (object) ultraGridColumn224,
      (object) ultraGridColumn225,
      (object) ultraGridColumn226,
      (object) ultraGridColumn227,
      (object) ultraGridColumn228,
      (object) ultraGridColumn229,
      (object) ultraGridColumn230,
      (object) ultraGridColumn231,
      (object) ultraGridColumn232,
      (object) ultraGridColumn233,
      (object) ultraGridColumn234
    });
    ultraGridBand6.GroupHeadersVisible = false;
    ((HeaderBase) ultraGridGroup3.Header).Caption = "Recievables";
    ((HeaderBase) ultraGridGroup3.Header).Editor = (EmbeddableEditorBase) null;
    ((KeyedSubObjectBase) ultraGridGroup3).Key = "NewGroup0";
    ultraGridGroup3.RowLayoutGroupInfo.LabelSpan = 1;
    ultraGridBand6.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup3
    });
    ultraGridBand6.LevelCount = 2;
    ultraGridLayout4.BandsSerializer.Add((object) ultraGridBand6);
    ultraGridLayout4.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout4).Key = "DetailView";
    ((AppearanceBase) appearance148).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance148).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance148).ForeColor = Color.Black;
    ultraGridLayout4.Override.ActiveRowAppearance = (AppearanceBase) appearance148;
    ultraGridLayout4.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridLayout4.Override.AllowColMoving = (AllowColMoving) 3;
    ultraGridLayout4.Override.AllowColSwapping = (AllowColSwapping) 3;
    ultraGridLayout4.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout4.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridLayout4.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridLayout4.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridLayout4.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout4.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridLayout4.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridLayout4.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridLayout4.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance149).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance149).TextHAlignAsString = "Left";
    ultraGridLayout4.Override.CellAppearance = (AppearanceBase) appearance149;
    ((AppearanceBase) appearance150).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance150).TextHAlignAsString = "Left";
    ultraGridLayout4.Override.HeaderAppearance = (AppearanceBase) appearance150;
    ultraGridLayout4.Override.HeaderClickAction = (HeaderClickAction) 3;
    ultraGridLayout4.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance151).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout4.Override.RowAlternateAppearance = (AppearanceBase) appearance151;
    ((AppearanceBase) appearance152).BorderColor = Color.LightGray;
    ultraGridLayout4.Override.RowAppearance = (AppearanceBase) appearance152;
    ultraGridLayout4.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridLayout4.Override.RowSpacingBefore = 1;
    ((AppearanceBase) appearance153).BackColor = Color.Transparent;
    ((AppearanceBase) appearance153).ForeColor = Color.Black;
    ultraGridLayout4.Override.SelectedRowAppearance = (AppearanceBase) appearance153;
    ((AppearanceBase) appearance154).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance154).BorderColor = Color.Silver;
    scrollBarLook6.ButtonAppearance = (AppearanceBase) appearance154;
    ((AppearanceBase) appearance155).BackColor = Color.White;
    scrollBarLook6.TrackAppearance = (AppearanceBase) appearance155;
    ultraGridLayout4.ScrollBarLook = scrollBarLook6;
    ((AppearanceBase) appearance156).BackColor = Color.White;
    ((AppearanceBase) appearance156).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout5.Appearance = (AppearanceBase) appearance156;
    ultraGridLayout5.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn235.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn235.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn235.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn235.Header).VisiblePosition = 3;
    ultraGridColumn235.Hidden = true;
    ultraGridColumn235.Width = 164;
    ultraGridColumn236.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn236.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn236.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn236.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn236.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn236.Style = (ColumnStyle) 2;
    ultraGridColumn236.Width = 107;
    ultraGridColumn237.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn237.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn237.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn237.Header).VisiblePosition = 1;
    ultraGridColumn237.Hidden = true;
    ultraGridColumn237.Width = 27;
    ultraGridColumn238.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn238.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn238.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn238.Header).VisiblePosition = 4;
    ultraGridColumn238.Hidden = true;
    ultraGridColumn238.Width = 27;
    ultraGridColumn239.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn239.CellActivation = (Activation) 1;
    ((HeaderBase) ultraGridColumn239.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn239.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn239.Header).VisiblePosition = 13;
    ultraGridColumn239.Style = (ColumnStyle) 2;
    ultraGridColumn239.Width = 61;
    ultraGridColumn240.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn240.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn240.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn240.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn240.Header).VisiblePosition = 23;
    ultraGridColumn240.Hidden = true;
    ultraGridColumn240.Width = 162;
    ultraGridColumn241.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn241.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn241.Header).Caption = "Effect. Date";
    ((HeaderBase) ultraGridColumn241.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn241.Header).VisiblePosition = 25;
    ultraGridColumn241.Hidden = true;
    ultraGridColumn241.Width = 107;
    ultraGridColumn242.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn242.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn242.Header).Caption = "Expir. Date";
    ((HeaderBase) ultraGridColumn242.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn242.Header).VisiblePosition = 26;
    ultraGridColumn242.Hidden = true;
    ultraGridColumn242.Width = 63 /*0x3F*/;
    ultraGridColumn243.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn243.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn243.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn243.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn243.Header).VisiblePosition = 17;
    ultraGridColumn243.Width = 80 /*0x50*/;
    ((HeaderBase) ultraGridColumn244.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn244.Header).VisiblePosition = 9;
    ultraGridColumn244.Hidden = true;
    ultraGridColumn244.Width = 67;
    ultraGridColumn245.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn245.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn245.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn245.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn245.Header).VisiblePosition = 24;
    ultraGridColumn245.Hidden = true;
    ultraGridColumn245.Width = 176 /*0xB0*/;
    ultraGridColumn246.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn246.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn246.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn246.Header).VisiblePosition = 2;
    ultraGridColumn246.Hidden = true;
    ultraGridColumn246.Width = 25;
    ultraGridColumn247.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn247.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn247.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn247.Header).VisiblePosition = 0;
    ultraGridColumn247.Hidden = true;
    ultraGridColumn247.Width = 22;
    ultraGridColumn248.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn248.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance157).TextHAlignAsString = "Right";
    ultraGridColumn248.CellAppearance = (AppearanceBase) appearance157;
    ultraGridColumn248.Format = "c";
    ((AppearanceBase) appearance158).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn248.Header).Appearance = (AppearanceBase) appearance158;
    ((HeaderBase) ultraGridColumn248.Header).Caption = "Gross Billed";
    ((HeaderBase) ultraGridColumn248.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn248.Header).VisiblePosition = 18;
    ultraGridColumn248.Width = 90;
    ultraGridColumn249.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn249.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance159).TextHAlignAsString = "Right";
    ultraGridColumn249.CellAppearance = (AppearanceBase) appearance159;
    ultraGridColumn249.Format = "c";
    ((AppearanceBase) appearance160).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn249.Header).Appearance = (AppearanceBase) appearance160;
    ((HeaderBase) ultraGridColumn249.Header).Caption = "Amt PTD.";
    ((HeaderBase) ultraGridColumn249.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn249.Header).VisiblePosition = 28;
    ultraGridColumn249.Hidden = true;
    ultraGridColumn249.Width = 109;
    ultraGridColumn250.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn250.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance161).TextHAlignAsString = "Right";
    ultraGridColumn250.CellAppearance = (AppearanceBase) appearance161;
    ultraGridColumn250.Format = "c";
    ((AppearanceBase) appearance162).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn250.Header).Appearance = (AppearanceBase) appearance162;
    ((HeaderBase) ultraGridColumn250.Header).Caption = "Net. Due";
    ((HeaderBase) ultraGridColumn250.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn250.Header).VisiblePosition = 19;
    ultraGridColumn250.Width = 74;
    ultraGridColumn251.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn251.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance163).TextHAlignAsString = "Right";
    ultraGridColumn251.CellAppearance = (AppearanceBase) appearance163;
    ultraGridColumn251.Format = "c";
    ((AppearanceBase) appearance164).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn251.Header).Appearance = (AppearanceBase) appearance164;
    ((HeaderBase) ultraGridColumn251.Header).Caption = "Amt PTC.";
    ((HeaderBase) ultraGridColumn251.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn251.Header).VisiblePosition = 27;
    ultraGridColumn251.Hidden = true;
    ultraGridColumn251.Width = 97;
    ultraGridColumn252.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn252.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance165).TextHAlignAsString = "Right";
    ultraGridColumn252.CellAppearance = (AppearanceBase) appearance165;
    ultraGridColumn252.Format = "c";
    ((AppearanceBase) appearance166).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn252.Header).Appearance = (AppearanceBase) appearance166;
    ((HeaderBase) ultraGridColumn252.Header).Caption = "Un-Acct. Bal.";
    ((HeaderBase) ultraGridColumn252.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn252.Header).VisiblePosition = 30;
    ultraGridColumn252.Hidden = true;
    ultraGridColumn252.Width = 177;
    ultraGridColumn253.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn253.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance167).TextHAlignAsString = "Right";
    ultraGridColumn253.CellAppearance = (AppearanceBase) appearance167;
    ultraGridColumn253.Format = "c";
    ((AppearanceBase) appearance168).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn253.Header).Appearance = (AppearanceBase) appearance168;
    ((HeaderBase) ultraGridColumn253.Header).Caption = "Exch. Bal.";
    ((HeaderBase) ultraGridColumn253.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn253.Header).VisiblePosition = 29;
    ultraGridColumn253.Hidden = true;
    ultraGridColumn253.Width = 145;
    ultraGridColumn254.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn254.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn254.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn254.Header).VisiblePosition = 5;
    ultraGridColumn254.Hidden = true;
    ultraGridColumn254.Width = 10;
    ultraGridColumn255.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn255.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn255.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn255.Header).VisiblePosition = 6;
    ultraGridColumn255.Hidden = true;
    ultraGridColumn255.Width = 10;
    ultraGridColumn256.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn256.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn256.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn256.Header).VisiblePosition = 7;
    ultraGridColumn256.Hidden = true;
    ultraGridColumn256.Width = 10;
    ultraGridColumn257.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn257.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn257.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn257.Header).VisiblePosition = 8;
    ultraGridColumn257.Hidden = true;
    ultraGridColumn257.Width = 36;
    ultraGridColumn258.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn258.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn258.Header).Caption = "Current Status";
    ((HeaderBase) ultraGridColumn258.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn258.Header).VisiblePosition = 14;
    ultraGridColumn258.Width = 148;
    ultraGridColumn259.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn259.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn259.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn259.Header).VisiblePosition = 10;
    ultraGridColumn259.Hidden = true;
    ultraGridColumn259.Width = 114;
    ultraGridColumn260.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn260.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn260.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn260.Header).VisiblePosition = 11;
    ultraGridColumn260.Hidden = true;
    ultraGridColumn261.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn261.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn261.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn261.Header).VisiblePosition = 12;
    ultraGridColumn261.Hidden = true;
    ultraGridColumn262.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance169).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance169).TextHAlignAsString = "Right";
    ultraGridColumn262.CellAppearance = (AppearanceBase) appearance169;
    ((AppearanceBase) appearance170).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance170).Image = (object) Resources.TransactionBuilder;
    ultraGridColumn262.CellButtonAppearance = (AppearanceBase) appearance170;
    ultraGridColumn262.Format = "c";
    ((AppearanceBase) appearance171).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn262.Header).Appearance = (AppearanceBase) appearance171;
    ((HeaderBase) ultraGridColumn262.Header).Caption = "AR Applied";
    ((HeaderBase) ultraGridColumn262.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn262.Header).VisiblePosition = 20;
    ultraGridColumn262.Style = (ColumnStyle) 2;
    ultraGridColumn262.Width = 94;
    ultraGridColumn263.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance172).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance172).TextHAlignAsString = "Right";
    ultraGridColumn263.CellAppearance = (AppearanceBase) appearance172;
    ultraGridColumn263.Format = "c";
    ((AppearanceBase) appearance173).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn263.Header).Appearance = (AppearanceBase) appearance173;
    ((HeaderBase) ultraGridColumn263.Header).Caption = "Exch. Applied";
    ((HeaderBase) ultraGridColumn263.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn263.Header).VisiblePosition = 21;
    ultraGridColumn263.Width = 86;
    ultraGridColumn264.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance174).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance174).TextHAlignAsString = "Right";
    ultraGridColumn264.CellAppearance = (AppearanceBase) appearance174;
    ultraGridColumn264.Format = "c";
    ((AppearanceBase) appearance175).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn264.Header).Appearance = (AppearanceBase) appearance175;
    ((HeaderBase) ultraGridColumn264.Header).Caption = "Un-Acct. Applied";
    ((HeaderBase) ultraGridColumn264.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn264.Header).VisiblePosition = 22;
    ultraGridColumn264.Width = 100;
    ((HeaderBase) ultraGridColumn265.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn265.Header).VisiblePosition = 15;
    ultraGridColumn265.Hidden = true;
    ultraGridColumn265.Width = 85;
    ((HeaderBase) ultraGridColumn266.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn266.Header).VisiblePosition = 31 /*0x1F*/;
    ultraGridColumn266.Hidden = true;
    ultraGridColumn266.Width = 119;
    ((HeaderBase) ultraGridColumn267.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn267.Header).VisiblePosition = 32 /*0x20*/;
    ultraGridColumn267.Hidden = true;
    ultraGridColumn267.Width = 50;
    ((HeaderBase) ultraGridColumn268.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn268.Header).VisiblePosition = 33;
    ultraGridColumn268.Hidden = true;
    ultraGridColumn268.Width = 78;
    ((HeaderBase) ultraGridColumn269.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn269.Header).VisiblePosition = 34;
    ultraGridColumn269.Hidden = true;
    ultraGridColumn269.Width = 77;
    ((HeaderBase) ultraGridColumn270.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn270.Header).VisiblePosition = 35;
    ultraGridColumn270.Hidden = true;
    ultraGridColumn270.Width = 68;
    ((HeaderBase) ultraGridColumn271.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn271.Header).VisiblePosition = 36;
    ultraGridColumn271.Hidden = true;
    ultraGridColumn271.Width = 66;
    ((HeaderBase) ultraGridColumn272.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn272.Header).VisiblePosition = 37;
    ultraGridColumn272.Hidden = true;
    ultraGridColumn272.Width = 88;
    ultraGridBand7.Columns.AddRange(new object[38]
    {
      (object) ultraGridColumn235,
      (object) ultraGridColumn236,
      (object) ultraGridColumn237,
      (object) ultraGridColumn238,
      (object) ultraGridColumn239,
      (object) ultraGridColumn240,
      (object) ultraGridColumn241,
      (object) ultraGridColumn242,
      (object) ultraGridColumn243,
      (object) ultraGridColumn244,
      (object) ultraGridColumn245,
      (object) ultraGridColumn246,
      (object) ultraGridColumn247,
      (object) ultraGridColumn248,
      (object) ultraGridColumn249,
      (object) ultraGridColumn250,
      (object) ultraGridColumn251,
      (object) ultraGridColumn252,
      (object) ultraGridColumn253,
      (object) ultraGridColumn254,
      (object) ultraGridColumn255,
      (object) ultraGridColumn256,
      (object) ultraGridColumn257,
      (object) ultraGridColumn258,
      (object) ultraGridColumn259,
      (object) ultraGridColumn260,
      (object) ultraGridColumn261,
      (object) ultraGridColumn262,
      (object) ultraGridColumn263,
      (object) ultraGridColumn264,
      (object) ultraGridColumn265,
      (object) ultraGridColumn266,
      (object) ultraGridColumn267,
      (object) ultraGridColumn268,
      (object) ultraGridColumn269,
      (object) ultraGridColumn270,
      (object) ultraGridColumn271,
      (object) ultraGridColumn272
    });
    ultraGridBand7.GroupHeadersVisible = false;
    ultraGridLayout5.BandsSerializer.Add((object) ultraGridBand7);
    ultraGridLayout5.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout5).Key = "SummaryView";
    ((AppearanceBase) appearance176).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance176).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance176).ForeColor = Color.Black;
    ultraGridLayout5.Override.ActiveRowAppearance = (AppearanceBase) appearance176;
    ultraGridLayout5.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridLayout5.Override.AllowColMoving = (AllowColMoving) 3;
    ultraGridLayout5.Override.AllowColSwapping = (AllowColSwapping) 3;
    ultraGridLayout5.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout5.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridLayout5.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridLayout5.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridLayout5.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout5.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridLayout5.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridLayout5.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridLayout5.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance177).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance177).TextHAlignAsString = "Left";
    ultraGridLayout5.Override.CellAppearance = (AppearanceBase) appearance177;
    ((AppearanceBase) appearance178).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance178).TextHAlignAsString = "Left";
    ultraGridLayout5.Override.HeaderAppearance = (AppearanceBase) appearance178;
    ultraGridLayout5.Override.HeaderClickAction = (HeaderClickAction) 3;
    ultraGridLayout5.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance179).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout5.Override.RowAlternateAppearance = (AppearanceBase) appearance179;
    ((AppearanceBase) appearance180).BorderColor = Color.LightGray;
    ultraGridLayout5.Override.RowAppearance = (AppearanceBase) appearance180;
    ultraGridLayout5.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridLayout5.Override.RowSpacingBefore = 1;
    ((AppearanceBase) appearance181).BackColor = Color.Transparent;
    ((AppearanceBase) appearance181).ForeColor = Color.Black;
    ultraGridLayout5.Override.SelectedRowAppearance = (AppearanceBase) appearance181;
    ((AppearanceBase) appearance182).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance182).BorderColor = Color.Silver;
    scrollBarLook7.ButtonAppearance = (AppearanceBase) appearance182;
    ((AppearanceBase) appearance183).BackColor = Color.White;
    scrollBarLook7.TrackAppearance = (AppearanceBase) appearance183;
    ultraGridLayout5.ScrollBarLook = scrollBarLook7;
    ((AppearanceBase) appearance184).BackColor = Color.White;
    ((AppearanceBase) appearance184).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout6.Appearance = (AppearanceBase) appearance184;
    ultraGridLayout6.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn273.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn273.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn273.Header).VisiblePosition = 3;
    ultraGridColumn273.Hidden = true;
    ultraGridColumn273.Width = 164;
    ultraGridColumn274.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn274.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn274.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn274.Header).VisiblePosition = 19;
    ultraGridColumn274.Width = 73;
    ultraGridColumn275.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn275.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn275.Header).VisiblePosition = 1;
    ultraGridColumn275.Hidden = true;
    ultraGridColumn275.Width = 27;
    ultraGridColumn276.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn276.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn276.Header).VisiblePosition = 8;
    ultraGridColumn276.Hidden = true;
    ultraGridColumn276.Width = 27;
    ultraGridColumn277.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn277.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn277.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn277.Width = 244;
    ultraGridColumn278.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn278.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn278.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn278.Width = 246;
    ultraGridColumn279.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn279.Header).Caption = "Effect. Date";
    ((HeaderBase) ultraGridColumn279.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn279.Width = 80 /*0x50*/;
    ultraGridColumn280.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn280.Header).Caption = "Expir. Date";
    ((HeaderBase) ultraGridColumn280.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn280.Width = 79;
    ultraGridColumn281.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn281.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn281.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn281.Header).VisiblePosition = 21;
    ultraGridColumn281.Width = 91;
    ultraGridColumn282.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn282.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn282.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn282.Header).VisiblePosition = 20;
    ultraGridColumn282.Hidden = true;
    ultraGridColumn282.Width = 129;
    ultraGridColumn283.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn283.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn283.Header).VisiblePosition = 2;
    ultraGridColumn283.Hidden = true;
    ultraGridColumn283.Width = 25;
    ultraGridColumn284.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn284.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn284.Header).VisiblePosition = 0;
    ultraGridColumn284.Hidden = true;
    ultraGridColumn284.Width = 22;
    ultraGridColumn285.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance185).TextHAlignAsString = "Right";
    ultraGridColumn285.CellAppearance = (AppearanceBase) appearance185;
    ultraGridColumn285.Format = "c";
    ((AppearanceBase) appearance186).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn285.Header).Appearance = (AppearanceBase) appearance186;
    ((HeaderBase) ultraGridColumn285.Header).Caption = "Gross Billed";
    ((HeaderBase) ultraGridColumn285.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn285.Width = 83;
    ultraGridColumn286.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance187).TextHAlignAsString = "Right";
    ultraGridColumn286.CellAppearance = (AppearanceBase) appearance187;
    ultraGridColumn286.Format = "c";
    ((AppearanceBase) appearance188).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn286.Header).Appearance = (AppearanceBase) appearance188;
    ((HeaderBase) ultraGridColumn286.Header).Caption = "Amt PTD.";
    ((HeaderBase) ultraGridColumn286.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn286.Width = 83;
    ultraGridColumn287.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance189).TextHAlignAsString = "Right";
    ultraGridColumn287.CellAppearance = (AppearanceBase) appearance189;
    ultraGridColumn287.Format = "c";
    ((AppearanceBase) appearance190).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn287.Header).Appearance = (AppearanceBase) appearance190;
    ((HeaderBase) ultraGridColumn287.Header).Caption = "Net. Due";
    ((HeaderBase) ultraGridColumn287.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn287.Width = 83;
    ultraGridColumn288.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance191).TextHAlignAsString = "Right";
    ultraGridColumn288.CellAppearance = (AppearanceBase) appearance191;
    ultraGridColumn288.Format = "c";
    ((AppearanceBase) appearance192).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn288.Header).Appearance = (AppearanceBase) appearance192;
    ((HeaderBase) ultraGridColumn288.Header).Caption = "Amt PTC.";
    ((HeaderBase) ultraGridColumn288.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn288.Width = 83;
    ultraGridColumn289.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance193).TextHAlignAsString = "Right";
    ultraGridColumn289.CellAppearance = (AppearanceBase) appearance193;
    ultraGridColumn289.Format = "c";
    ((AppearanceBase) appearance194).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn289.Header).Appearance = (AppearanceBase) appearance194;
    ((HeaderBase) ultraGridColumn289.Header).Caption = "Un-Acct. Bal.";
    ((HeaderBase) ultraGridColumn289.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn289.Width = 138;
    ultraGridColumn290.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance195).TextHAlignAsString = "Right";
    ultraGridColumn290.CellAppearance = (AppearanceBase) appearance195;
    ultraGridColumn290.Format = "c";
    ((AppearanceBase) appearance196).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn290.Header).Appearance = (AppearanceBase) appearance196;
    ((HeaderBase) ultraGridColumn290.Header).Caption = "Exch. Bal.";
    ((HeaderBase) ultraGridColumn290.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn290.Width = 100;
    ultraGridColumn291.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn291.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn291.Header).VisiblePosition = 9;
    ultraGridColumn291.Hidden = true;
    ultraGridColumn291.Width = 10;
    ultraGridColumn292.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn292.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn292.Header).VisiblePosition = 10;
    ultraGridColumn292.Hidden = true;
    ultraGridColumn292.Width = 10;
    ultraGridColumn293.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn293.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn293.Header).VisiblePosition = 17;
    ultraGridColumn293.Hidden = true;
    ultraGridColumn293.Width = 10;
    ultraGridColumn294.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn294.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn294.Header).VisiblePosition = 18;
    ultraGridColumn294.Hidden = true;
    ultraGridColumn294.Width = 36;
    ultraGridColumn295.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn295.Header).Caption = "Current Status";
    ((HeaderBase) ultraGridColumn295.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn295.Width = 191;
    ultraGridColumn296.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn296.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn296.Header).VisiblePosition = 23;
    ultraGridColumn296.Hidden = true;
    ultraGridColumn296.Width = 114;
    ultraGridColumn297.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn297.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn297.Header).VisiblePosition = 24;
    ultraGridColumn297.Hidden = true;
    ultraGridColumn298.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn298.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn298.Header).VisiblePosition = 25;
    ultraGridColumn298.Hidden = true;
    ((AppearanceBase) appearance197).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance197).TextHAlignAsString = "Right";
    ultraGridColumn299.CellAppearance = (AppearanceBase) appearance197;
    ultraGridColumn299.Format = "c";
    ((AppearanceBase) appearance198).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn299.Header).Appearance = (AppearanceBase) appearance198;
    ((HeaderBase) ultraGridColumn299.Header).Caption = "AR Applied";
    ((HeaderBase) ultraGridColumn299.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn299.Width = 83;
    ((AppearanceBase) appearance199).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance199).TextHAlignAsString = "Right";
    ultraGridColumn300.CellAppearance = (AppearanceBase) appearance199;
    ultraGridColumn300.Format = "c";
    ((AppearanceBase) appearance200).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn300.Header).Appearance = (AppearanceBase) appearance200;
    ((HeaderBase) ultraGridColumn300.Header).Caption = "Exch. Applied";
    ((HeaderBase) ultraGridColumn300.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn300.Width = 99;
    ((AppearanceBase) appearance201).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance201).TextHAlignAsString = "Right";
    ultraGridColumn301.CellAppearance = (AppearanceBase) appearance201;
    ultraGridColumn301.Format = "c";
    ((AppearanceBase) appearance202).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn301.Header).Appearance = (AppearanceBase) appearance202;
    ((HeaderBase) ultraGridColumn301.Header).Caption = "Un-Acct. Applied";
    ((HeaderBase) ultraGridColumn301.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn301.Width = 86;
    ultraGridBand8.Columns.AddRange(new object[29]
    {
      (object) ultraGridColumn273,
      (object) ultraGridColumn274,
      (object) ultraGridColumn275,
      (object) ultraGridColumn276,
      (object) ultraGridColumn277,
      (object) ultraGridColumn278,
      (object) ultraGridColumn279,
      (object) ultraGridColumn280,
      (object) ultraGridColumn281,
      (object) ultraGridColumn282,
      (object) ultraGridColumn283,
      (object) ultraGridColumn284,
      (object) ultraGridColumn285,
      (object) ultraGridColumn286,
      (object) ultraGridColumn287,
      (object) ultraGridColumn288,
      (object) ultraGridColumn289,
      (object) ultraGridColumn290,
      (object) ultraGridColumn291,
      (object) ultraGridColumn292,
      (object) ultraGridColumn293,
      (object) ultraGridColumn294,
      (object) ultraGridColumn295,
      (object) ultraGridColumn296,
      (object) ultraGridColumn297,
      (object) ultraGridColumn298,
      (object) ultraGridColumn299,
      (object) ultraGridColumn300,
      (object) ultraGridColumn301
    });
    ultraGridBand8.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup4).Key = "Recievable";
    ultraGridGroup4.RowLayoutGroupInfo.LabelSpan = 1;
    ultraGridBand8.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup4
    });
    ultraGridBand8.LevelCount = 2;
    ultraGridLayout6.BandsSerializer.Add((object) ultraGridBand8);
    ultraGridLayout6.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout6).Key = "ChipDownView";
    ((AppearanceBase) appearance203).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance203).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance203).ForeColor = Color.Black;
    ultraGridLayout6.Override.ActiveRowAppearance = (AppearanceBase) appearance203;
    ultraGridLayout6.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridLayout6.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout6.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout6.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout6.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridLayout6.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridLayout6.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridLayout6.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout6.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridLayout6.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridLayout6.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridLayout6.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance204).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance204).TextHAlignAsString = "Left";
    ultraGridLayout6.Override.CellAppearance = (AppearanceBase) appearance204;
    ((AppearanceBase) appearance205).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance205).TextHAlignAsString = "Left";
    ultraGridLayout6.Override.HeaderAppearance = (AppearanceBase) appearance205;
    ultraGridLayout6.Override.HeaderClickAction = (HeaderClickAction) 3;
    ultraGridLayout6.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance206).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout6.Override.RowAlternateAppearance = (AppearanceBase) appearance206;
    ((AppearanceBase) appearance207).BorderColor = Color.LightGray;
    ultraGridLayout6.Override.RowAppearance = (AppearanceBase) appearance207;
    ultraGridLayout6.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridLayout6.Override.RowSpacingBefore = 1;
    ((AppearanceBase) appearance208).BackColor = Color.Transparent;
    ((AppearanceBase) appearance208).ForeColor = Color.Black;
    ultraGridLayout6.Override.SelectedRowAppearance = (AppearanceBase) appearance208;
    ((AppearanceBase) appearance209).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance209).BorderColor = Color.Silver;
    scrollBarLook8.ButtonAppearance = (AppearanceBase) appearance209;
    ((AppearanceBase) appearance210).BackColor = Color.White;
    scrollBarLook8.TrackAppearance = (AppearanceBase) appearance210;
    ultraGridLayout6.ScrollBarLook = scrollBarLook8;
    ((UltraGridBase) this.gridReceivables).Layouts.Add(ultraGridLayout4);
    ((UltraGridBase) this.gridReceivables).Layouts.Add(ultraGridLayout5);
    ((UltraGridBase) this.gridReceivables).Layouts.Add(ultraGridLayout6);
    ((Control) this.gridReceivables).Location = new Point(0, 24);
    ((Control) this.gridReceivables).Name = "gridReceivables";
    ((Control) this.gridReceivables).Size = new Size(842, 680);
    ((Control) this.gridReceivables).TabIndex = 7;
    this.gridReceivables.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridReceivables).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridReceivables).UseOsThemes = (DefaultableBoolean) 2;
    this.gridReceivables.AfterCellUpdate += new CellEventHandler(this.gridReceivables_AfterCellUpdate);
    this.gridReceivables.InitializeRow += new InitializeRowEventHandler(this.gridReceivables_InitializeRow);
    this.gridReceivables.ClickCellButton += new CellEventHandler(this.gridReceivables_ClickCellButton);
    this.gridReceivables.AfterSelectChange += new AfterSelectChangeEventHandler(this.Grid_AferSelectChange);
    this.gridReceivables.BeforeCellUpdate += new BeforeCellUpdateEventHandler(this.gridReceivables_BeforeCellUpdate);
    this.gridReceivables.CellDataError += new CellDataErrorEventHandler(this.gridReceivables_CellDataError);
    ((UltraGridBase) this.gridReceivables).AfterColPosChanged += new AfterColPosChangedEventHandler(this.gridReceivables_AfterColPosChanged);
    ((UltraGridBase) this.gridReceivables).BeforeColumnChooserDisplayed += new BeforeColumnChooserDisplayedEventHandler(this.gridReceivables_BeforeColumnChooserDisplayed);
    ((Control) this.gridReceivables).KeyDown += new KeyEventHandler(this.gridReceivables_KeyDown);
    this.dsOpenReceivables.DataSetName = "dsOpenReceivables";
    this.dsOpenReceivables.Locale = new CultureInfo("en-US");
    this.dsOpenReceivables.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panelGridOptions.BackColor = Color.FromArgb(239, 247, 253);
    this.panelGridOptions.Controls.Add((Control) this.labelReceiveablesExist);
    this.panelGridOptions.Controls.Add((Control) this.radioReceivableChipDownView);
    this.panelGridOptions.Controls.Add((Control) this.radioReceivableSummaryView);
    this.panelGridOptions.Controls.Add((Control) this.radioReceivableDetailView);
    this.panelGridOptions.Controls.Add((Control) this.pnlReceivableChipDownView);
    this.panelGridOptions.Dock = DockStyle.Top;
    this.panelGridOptions.Location = new Point(0, 0);
    this.panelGridOptions.Name = "panelGridOptions";
    this.panelGridOptions.Size = new Size(842, 24);
    this.panelGridOptions.TabIndex = 6;
    this.labelReceiveablesExist.AutoSize = true;
    this.labelReceiveablesExist.BackColor = Color.Transparent;
    this.labelReceiveablesExist.ForeColor = Color.Red;
    this.labelReceiveablesExist.Image = (Image) Resources.exclamation;
    this.labelReceiveablesExist.ImageAlign = ContentAlignment.MiddleLeft;
    this.labelReceiveablesExist.Location = new Point(297, 6);
    this.labelReceiveablesExist.Name = "labelReceiveablesExist";
    this.labelReceiveablesExist.Size = new Size(319, 13);
    this.labelReceiveablesExist.TabIndex = 35;
    this.labelReceiveablesExist.Text = "      Receiveable(s) with the same invoice number already loaded!";
    this.labelReceiveablesExist.TextAlign = ContentAlignment.MiddleRight;
    this.labelReceiveablesExist.Visible = false;
    this.radioReceivableChipDownView.BackColor = Color.Transparent;
    this.radioReceivableChipDownView.Enabled = false;
    this.radioReceivableChipDownView.FlatStyle = FlatStyle.Flat;
    this.radioReceivableChipDownView.Location = new Point(179, 4);
    this.radioReceivableChipDownView.Name = "radioReceivableChipDownView";
    this.radioReceivableChipDownView.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.radioReceivableChipDownView.TabIndex = 10;
    this.radioReceivableChipDownView.Text = "Installment View";
    this.radioReceivableChipDownView.UseVisualStyleBackColor = false;
    this.radioReceivableChipDownView.Visible = false;
    this.radioReceivableChipDownView.CheckedChanged += new EventHandler(this.ReceivableGridViewOptionsChangedHandler);
    this.radioReceivableSummaryView.BackColor = Color.Transparent;
    this.radioReceivableSummaryView.Checked = true;
    this.radioReceivableSummaryView.Enabled = false;
    this.radioReceivableSummaryView.FlatStyle = FlatStyle.Flat;
    this.radioReceivableSummaryView.Location = new Point(7, 4);
    this.radioReceivableSummaryView.Name = "radioReceivableSummaryView";
    this.radioReceivableSummaryView.Size = new Size(93, 16 /*0x10*/);
    this.radioReceivableSummaryView.TabIndex = 8;
    this.radioReceivableSummaryView.TabStop = true;
    this.radioReceivableSummaryView.Text = "Summary View";
    this.radioReceivableSummaryView.UseVisualStyleBackColor = false;
    this.radioReceivableSummaryView.CheckedChanged += new EventHandler(this.ReceivableGridViewOptionsChangedHandler);
    this.radioReceivableDetailView.BackColor = Color.Transparent;
    this.radioReceivableDetailView.Enabled = false;
    this.radioReceivableDetailView.FlatStyle = FlatStyle.Flat;
    this.radioReceivableDetailView.Location = new Point(100, 4);
    this.radioReceivableDetailView.Name = "radioReceivableDetailView";
    this.radioReceivableDetailView.Size = new Size(76, 16 /*0x10*/);
    this.radioReceivableDetailView.TabIndex = 9;
    this.radioReceivableDetailView.Text = "Detail View";
    this.radioReceivableDetailView.UseVisualStyleBackColor = false;
    this.radioReceivableDetailView.CheckedChanged += new EventHandler(this.ReceivableGridViewOptionsChangedHandler);
    this.pnlReceivableChipDownView.BackColor = Color.Transparent;
    this.pnlReceivableChipDownView.Controls.Add((Control) this.label4);
    this.pnlReceivableChipDownView.Controls.Add((Control) this.progressBarReceivableChipDown);
    this.pnlReceivableChipDownView.Dock = DockStyle.Right;
    this.pnlReceivableChipDownView.Location = new Point(530, 0);
    this.pnlReceivableChipDownView.Name = "pnlReceivableChipDownView";
    this.pnlReceivableChipDownView.Size = new Size(312, 24);
    this.pnlReceivableChipDownView.TabIndex = 11;
    this.pnlReceivableChipDownView.Visible = false;
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(8, 4);
    this.label4.Name = "label4";
    this.label4.Size = new Size(133, 13);
    this.label4.TabIndex = 0;
    this.label4.Text = "Creating Installment View:";
    ((Control) this.progressBarReceivableChipDown).Location = new Point(160 /*0xA0*/, 6);
    ((Control) this.progressBarReceivableChipDown).Name = "progressBarReceivableChipDown";
    ((Control) this.progressBarReceivableChipDown).Size = new Size(144 /*0x90*/, 12);
    ((Control) this.progressBarReceivableChipDown).TabIndex = 1;
    ((Control) this.progressBarReceivableChipDown).Text = "[Formatted]";
    this.xViewReceivable.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.xViewReceivable.BackColor = Color.White;
    this.xViewReceivable.Font = new Font("Tahoma", 8f);
    this.xViewReceivable.ForeColor = Color.Black;
    this.xViewReceivable.Location = new Point(348, 351);
    this.xViewReceivable.Name = "xViewReceivable";
    this.xViewReceivable.Size = new Size(473, 264);
    this.xViewReceivable.TabIndex = 5;
    this.xViewReceivable.Visible = false;
    this.xViewReceivable.ViewPolicyDetailClicked += new ReceivablesInformationViewer.ViewPolicyDetailClickedEventHandler(this.xViewReceivable_ViewPolicyDetailClicked);
    this.xViewReceivable.WriteOffReceivableClicked += new ReceivablesInformationViewer.WriteOffReceivableClickedEventHandler(this.xViewReceivable_WriteOffReceivableClicked);
    this.xViewReceivable.AssignFinanceCompanyClicked += new ReceivablesInformationViewer.AssignFinanceCompanyClickedEventHandler(this.xViewReceivable_AssignFinanceCompanyClicked);
    ((Control) this.tabNonPayableFees).Controls.Add((Control) this.gridNonPayableFees);
    ((Control) this.tabNonPayableFees).Location = new Point(-10000, -10000);
    ((Control) this.tabNonPayableFees).Name = "tabNonPayableFees";
    ((Control) this.tabNonPayableFees).Size = new Size(842, 704);
    ((AppearanceBase) appearance211).BackColor = Color.White;
    ((AppearanceBase) appearance211).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Appearance = (AppearanceBase) appearance211;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand9.Override.CellClickAction = (CellClickAction) 1;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.BandsSerializer.Add((object) ultraGridBand9);
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance212).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance212).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance212).ForeColor = Color.Black;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance212;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance213).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance213;
    ((AppearanceBase) appearance214).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance214;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance215).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance215;
    ((AppearanceBase) appearance216).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance216;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance217).BackColor = Color.Transparent;
    ((AppearanceBase) appearance217).ForeColor = Color.Black;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance217;
    ((AppearanceBase) appearance218).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance218).BorderColor = Color.Silver;
    scrollBarLook9.ButtonAppearance = (AppearanceBase) appearance218;
    ((AppearanceBase) appearance219).BackColor = Color.White;
    scrollBarLook9.TrackAppearance = (AppearanceBase) appearance219;
    ((UltraGridBase) this.gridNonPayableFees).DisplayLayout.ScrollBarLook = scrollBarLook9;
    ((Control) this.gridNonPayableFees).Dock = DockStyle.Fill;
    ((Control) this.gridNonPayableFees).Location = new Point(0, 0);
    ((Control) this.gridNonPayableFees).Name = "gridNonPayableFees";
    ((Control) this.gridNonPayableFees).Size = new Size(842, 704);
    ((Control) this.gridNonPayableFees).TabIndex = 1;
    this.gridNonPayableFees.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridNonPayableFees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridNonPayableFees).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridNonPayableFees).Visible = false;
    this.gridNonPayableFees.InitializeLayout += new InitializeLayoutEventHandler(this.gridNonPayableFees_InitializeLayout);
    ((Control) this.gridNonPayableFees).MouseClick += new MouseEventHandler(this.gridNonPayableFees_MouseClick);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.checkBankCurrency);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.labelGLAccount);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.btnCancelChanges);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.radioDebit);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.radioCredit);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.btnAdd);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.label9);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.label13);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.txtAmount);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.txtComments);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.comboCostCenters);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.dropTreeGLAccounts);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.lblCostCenter);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.lblDescription);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.gridAdditionalOffsets);
    ((Control) this.tabAdditonalOffsets).Controls.Add((Control) this.ultraLabel1);
    ((Control) this.tabAdditonalOffsets).Location = new Point(-10000, -10000);
    ((Control) this.tabAdditonalOffsets).Name = "tabAdditonalOffsets";
    ((Control) this.tabAdditonalOffsets).Size = new Size(842, 704);
    ((AppearanceBase) appearance220).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance220).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkBankCurrency).Appearance = (AppearanceBase) appearance220;
    ((Control) this.checkBankCurrency).BackColor = Color.White;
    ((UltraToggleEditorBase) this.checkBankCurrency).BackColorInternal = Color.White;
    ((UltraToggleEditorBase) this.checkBankCurrency).Checked = true;
    ((UltraToggleEditorBase) this.checkBankCurrency).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.checkBankCurrency).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkBankCurrency).Location = new Point(80 /*0x50*/, 280);
    this.checkBankCurrency.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkBankCurrency).Name = "checkBankCurrency";
    ((Control) this.checkBankCurrency).Size = new Size(125, 13);
    ((Control) this.checkBankCurrency).TabIndex = 128 /*0x80*/;
    ((Control) this.checkBankCurrency).Text = "Use Bank Currency";
    this.labelGLAccount.AutoSize = true;
    this.labelGLAccount.BackColor = Color.White;
    this.labelGLAccount.Location = new Point(8, 64 /*0x40*/);
    this.labelGLAccount.Name = "labelGLAccount";
    this.labelGLAccount.Size = new Size(65, 13);
    this.labelGLAccount.TabIndex = 125;
    this.labelGLAccount.Text = "GL Account:";
    ((AppearanceBase) appearance221).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance221).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance221).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance221).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancelChanges).Appearance = (AppearanceBase) appearance221;
    ((Control) this.btnCancelChanges).Location = new Point(208 /*0xD0*/, 305);
    ((Control) this.btnCancelChanges).Name = "btnCancelChanges";
    ((Control) this.btnCancelChanges).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancelChanges).TabIndex = 124;
    ((Control) this.btnCancelChanges).Text = "&Cancel";
    ((UltraControlBase) this.btnCancelChanges).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancelChanges).Click += new EventHandler(this.btnCancelChanges_Click);
    this.radioDebit.BackColor = Color.White;
    this.radioDebit.Checked = true;
    this.radioDebit.FlatStyle = FlatStyle.Flat;
    this.radioDebit.Location = new Point(80 /*0x50*/, 248);
    this.radioDebit.Name = "radioDebit";
    this.radioDebit.Size = new Size(56, 16 /*0x10*/);
    this.radioDebit.TabIndex = 123;
    this.radioDebit.TabStop = true;
    this.radioDebit.Text = "Debit";
    this.radioDebit.UseVisualStyleBackColor = false;
    this.radioCredit.BackColor = Color.White;
    this.radioCredit.FlatStyle = FlatStyle.Flat;
    this.radioCredit.Location = new Point(136, 248);
    this.radioCredit.Name = "radioCredit";
    this.radioCredit.Size = new Size(72, 16 /*0x10*/);
    this.radioCredit.TabIndex = 122;
    this.radioCredit.Text = "Credit";
    this.radioCredit.UseVisualStyleBackColor = false;
    ((AppearanceBase) appearance222).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance222).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance222).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance222).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnAdd).Appearance = (AppearanceBase) appearance222;
    ((Control) this.btnAdd).Location = new Point(104, 306);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(96 /*0x60*/, 24);
    ((Control) this.btnAdd).TabIndex = 121;
    ((Control) this.btnAdd).Text = "&Add";
    ((UltraControlBase) this.btnAdd).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnAdd).Click += new EventHandler(this.btnAdd_Click);
    this.label9.AutoSize = true;
    this.label9.BackColor = Color.White;
    this.label9.Location = new Point(16 /*0x10*/, 224 /*0xE0*/);
    this.label9.Name = "label9";
    this.label9.Size = new Size(48 /*0x30*/, 13);
    this.label9.TabIndex = 119;
    this.label9.Text = "Amount:";
    this.label13.AutoSize = true;
    this.label13.BackColor = Color.White;
    this.label13.Location = new Point(8, 112 /*0x70*/);
    this.label13.Name = "label13";
    this.label13.Size = new Size(61, 13);
    this.label13.TabIndex = 117;
    this.label13.Text = "Comments:";
    ((AppearanceBase) appearance223).BackColor = Color.White;
    ((AppearanceBase) appearance223).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance223).ForeColor = Color.Black;
    ((AppearanceBase) appearance223).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.txtAmount).Appearance = (AppearanceBase) appearance223;
    ((Control) this.txtAmount).BackColor = Color.White;
    ((Control) this.txtAmount).Location = new Point(80 /*0x50*/, 224 /*0xE0*/);
    ((TextEditorControlBase) this.txtAmount).MaxLength = 50;
    this.txtAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAmount).Name = "txtAmount";
    ((Control) this.txtAmount).Size = new Size(200, 20);
    ((Control) this.txtAmount).TabIndex = 120;
    ((UltraControlBase) this.txtAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtAmount).Validating += new CancelEventHandler(this.txtAdditionalOffsetAmount_Validating);
    ((AppearanceBase) appearance224).BackColor = Color.White;
    ((AppearanceBase) appearance224).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance224).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComments).Appearance = (AppearanceBase) appearance224;
    ((Control) this.txtComments).BackColor = Color.White;
    ((Control) this.txtComments).Location = new Point(80 /*0x50*/, 112 /*0x70*/);
    ((TextEditorControlBase) this.txtComments).MaxLength = 2000;
    this.txtComments.MGAStyle = MGAStyles.Blue;
    this.txtComments.Multiline = true;
    ((Control) this.txtComments).Name = "txtComments";
    ((Control) this.txtComments).Size = new Size(200, 104);
    ((Control) this.txtComments).TabIndex = 118;
    ((UltraControlBase) this.txtComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComments).UseOsThemes = (DefaultableBoolean) 2;
    this.comboCostCenters.AutoSelectOnOneItem = true;
    this.comboCostCenters.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenters.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenters).Location = new Point(80 /*0x50*/, 88);
    this.comboCostCenters.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenters).Name = "comboCostCenters";
    ((Control) this.comboCostCenters).Size = new Size(200, 21);
    ((Control) this.comboCostCenters).TabIndex = 113;
    ((UltraControlBase) this.comboCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    this.dropTreeGLAccounts.DropDownHeight = 300;
    this.dropTreeGLAccounts.DropDownWidth = 300;
    this.dropTreeGLAccounts.Font = new Font("Tahoma", 8f);
    this.dropTreeGLAccounts.Location = new Point(80 /*0x50*/, 64 /*0x40*/);
    this.dropTreeGLAccounts.Name = "dropTreeGLAccounts";
    this.dropTreeGLAccounts.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeGLAccounts.ShowEquityAccounts = true;
    this.dropTreeGLAccounts.ShowExpenseAccounts = true;
    this.dropTreeGLAccounts.ShowIncomeAccounts = true;
    this.dropTreeGLAccounts.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeGLAccounts.ShowSystemDefinedAccounts = true;
    this.dropTreeGLAccounts.Size = new Size(200, 20);
    this.dropTreeGLAccounts.TabIndex = 126;
    this.dropTreeGLAccounts.UseCheckedStateSelectionOverride = false;
    this.lblCostCenter.AutoSize = true;
    this.lblCostCenter.BackColor = Color.White;
    this.lblCostCenter.Location = new Point(8, 88);
    this.lblCostCenter.Name = "lblCostCenter";
    this.lblCostCenter.Size = new Size(75, 13);
    this.lblCostCenter.TabIndex = 114;
    this.lblCostCenter.Text = "Cost Center : ";
    this.lblDescription.BackColor = Color.White;
    this.lblDescription.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblDescription.Location = new Point(8, 8);
    this.lblDescription.Name = "lblDescription";
    this.lblDescription.Size = new Size(288, 48 /*0x30*/);
    this.lblDescription.TabIndex = 100;
    this.lblDescription.Text = "This screen allows you enter additional offsets.  Additional offsets will be applied to credits and debits based on the bank account selected and the gl account.";
    ((Control) this.gridAdditionalOffsets).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.AdditionalOffsetToolManager.SetContextMenuUltra((Component) this.gridAdditionalOffsets, "ContextMenu");
    ((AppearanceBase) appearance225).BackColor = Color.White;
    ((AppearanceBase) appearance225).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Appearance = (AppearanceBase) appearance225;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance226).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance226).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance226).ForeColor = Color.Black;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance226;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance227).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance227;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance228).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance228;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance229).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance229;
    ((AppearanceBase) appearance230).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance230;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance231).BackColor = Color.Transparent;
    ((AppearanceBase) appearance231).ForeColor = Color.Black;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance231;
    ((AppearanceBase) appearance232).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance232).BorderColor = Color.Silver;
    scrollBarLook10.ButtonAppearance = (AppearanceBase) appearance232;
    ((AppearanceBase) appearance233).BackColor = Color.White;
    scrollBarLook10.TrackAppearance = (AppearanceBase) appearance233;
    ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.ScrollBarLook = scrollBarLook10;
    ((Control) this.gridAdditionalOffsets).Font = new Font("Tahoma", 8f);
    ((Control) this.gridAdditionalOffsets).Location = new Point(296, 0);
    ((Control) this.gridAdditionalOffsets).Name = "gridAdditionalOffsets";
    ((Control) this.gridAdditionalOffsets).Size = new Size(539, 635);
    ((Control) this.gridAdditionalOffsets).TabIndex = 79;
    ((UltraControlBase) this.gridAdditionalOffsets).UseOsThemes = (DefaultableBoolean) 2;
    this.gridAdditionalOffsets.InitializeLayout += new InitializeLayoutEventHandler(this.gridAdditionalOffsets_InitializeLayout);
    ((AppearanceBase) appearance234).BackColor = Color.White;
    ((AppearanceBase) appearance234).BackGradientAlignment = (GradientAlignment) 3;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance234;
    ((ControlBase) this.ultraLabel1).BackColorInternal = SystemColors.ActiveBorder;
    this.ultraLabel1.BorderStyleOuter = (UIElementBorderStyle) 1;
    ((Control) this.ultraLabel1).Dock = DockStyle.Fill;
    ((Control) this.ultraLabel1).Location = new Point(0, 0);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(842, 704);
    ((Control) this.ultraLabel1).TabIndex = 80 /*0x50*/;
    ((Control) this.tabSummary).Controls.Add((Control) this.label14);
    ((Control) this.tabSummary).Location = new Point(-10000, -10000);
    ((Control) this.tabSummary).Name = "tabSummary";
    ((Control) this.tabSummary).Size = new Size(842, 704);
    this.label14.Dock = DockStyle.Fill;
    this.label14.Location = new Point(0, 0);
    this.label14.Name = "label14";
    this.label14.Size = new Size(842, 704);
    this.label14.TabIndex = 0;
    this.label14.Text = "Under Construction.....";
    this.label14.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.gridNonWorkingDeposit);
    ((Control) this.ultraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl1).Name = "ultraTabPageControl1";
    ((Control) this.ultraTabPageControl1).Size = new Size(842, 704);
    ((AppearanceBase) appearance235).BackColor = Color.White;
    ((AppearanceBase) appearance235).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Appearance = (AppearanceBase) appearance235;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand10.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance236).BackColor = Color.LightSteelBlue;
    ultraGridBand10.Override.SummaryFooterAppearance = (AppearanceBase) appearance236;
    ultraGridBand10.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.BandsSerializer.Add((object) ultraGridBand10);
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance237).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance237).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance237).ForeColor = Color.Black;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance237;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance238).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance238;
    ((AppearanceBase) appearance239).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance239;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance240).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance240;
    ((AppearanceBase) appearance241).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance241;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance242).BackColor = Color.Transparent;
    ((AppearanceBase) appearance242).ForeColor = Color.Black;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance242;
    ((AppearanceBase) appearance243).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance243).BorderColor = Color.Silver;
    scrollBarLook11.ButtonAppearance = (AppearanceBase) appearance243;
    ((AppearanceBase) appearance244).BackColor = Color.White;
    scrollBarLook11.TrackAppearance = (AppearanceBase) appearance244;
    ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.ScrollBarLook = scrollBarLook11;
    ((Control) this.gridNonWorkingDeposit).Dock = DockStyle.Fill;
    ((Control) this.gridNonWorkingDeposit).Location = new Point(0, 0);
    ((Control) this.gridNonWorkingDeposit).Name = "gridNonWorkingDeposit";
    ((Control) this.gridNonWorkingDeposit).Size = new Size(842, 704);
    ((Control) this.gridNonWorkingDeposit).TabIndex = 2;
    this.gridNonWorkingDeposit.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridNonWorkingDeposit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridNonWorkingDeposit).UseOsThemes = (DefaultableBoolean) 2;
    this.gridNonWorkingDeposit.AfterCellUpdate += new CellEventHandler(this.gridNonWorkingDeposit_AfterCellUpdate);
    this.gridNonWorkingDeposit.ClickCellButton += new CellEventHandler(this.gridNonWorkingDeposit_ClickCellButton);
    this.pnlContainer.BackColor = Color.White;
    this.pnlContainer.Controls.Add((Control) this._formReceivables_Toolbars_Dock_Area_Bottom);
    this.pnlContainer.Controls.Add((Control) this._formReceivables_Toolbars_Dock_Area_Left);
    this.pnlContainer.Controls.Add((Control) this._formReceivables_Toolbars_Dock_Area_Right);
    this.pnlContainer.Controls.Add((Control) this.tabTransactions);
    this.pnlContainer.Controls.Add((Control) this.panel1);
    this.pnlContainer.Controls.Add((Control) this._formReceivables_Toolbars_Dock_Area_Top);
    this.pnlContainer.Controls.Add((Control) this.labelCurtain);
    this.pnlContainer.Dock = DockStyle.Fill;
    this.pnlContainer.Location = new Point(0, 0);
    this.pnlContainer.Name = "pnlContainer";
    this.pnlContainer.Size = new Size(1052, 770);
    this.pnlContainer.TabIndex = 3;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formReceivables_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Bottom).Location = new Point(208 /*0xD0*/, 770);
    ((Control) this._formReceivables_Toolbars_Dock_Area_Bottom).Name = "_formReceivables_Toolbars_Dock_Area_Bottom";
    ((Control) this._formReceivables_Toolbars_Dock_Area_Bottom).Size = new Size(844, 0);
    this._formReceivables_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.toolbar;
    this.toolbar.DesignerFlags = 1;
    this.toolbar.DockWithinContainer = (Control) this;
    this.toolbar.DockWithinContainerBaseType = typeof (Form);
    this.toolbar.MdiMergeable = false;
    this.toolbar.ShowFullMenusDelay = 500;
    this.toolbar.Style = (ToolbarStyle) 5;
    ultraToolbar1.DockedColumn = 0;
    ultraToolbar1.DockedRow = 0;
    ultraToolbar1.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool4).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) controlContainerTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool7).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar1).NonInheritedTools.AddRange(new ToolBase[11]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) popupMenuTool1,
      (ToolBase) stateButtonTool1,
      (ToolBase) controlContainerTool1,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7
    });
    ultraToolbar1.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar1.Settings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance245).AlphaLevel = (short) 95;
    ((AppearanceBase) appearance245).BackColor = Color.GhostWhite;
    ((AppearanceBase) appearance245).ForeColor = Color.Black;
    ((AppearanceBase) appearance245).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance245).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance245).ImageBackgroundAlpha = (Alpha) 1;
    ((AppearanceBase) appearance245).ImageBackgroundOrigin = (ImageBackgroundOrigin) 1;
    ((SettingsBase) ultraToolbar1.Settings).Appearance = (AppearanceBase) appearance245;
    ultraToolbar1.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar1.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar1.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) ultraToolbar1.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ultraToolbar1.Text = "toolbarShared";
    ultraToolbar2.DockedColumn = 0;
    ultraToolbar2.DockedRow = 1;
    ((UltraToolbarBase) ultraToolbar2).NonInheritedTools.AddRange(new ToolBase[2]
    {
      (ToolBase) popupMenuTool3,
      (ToolBase) popupMenuTool4
    });
    ultraToolbar2.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar2.Text = "quickTools";
    ultraToolbar2.Visible = false;
    this.toolbar.Toolbars.AddRange(new UltraToolbar[2]
    {
      ultraToolbar1,
      ultraToolbar2
    });
    ((AppearanceBase) appearance246).Image = (object) Resources.pencil;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance246;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "New ";
    ((ToolBase) buttonTool8).SharedPropsInternal.Category = "SharedTools";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance247).Image = (object) Resources.ExtendedSettings;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance247;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Load Worksheet";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Save Worksheet";
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool10).SharedPropsInternal.Visible = false;
    ((SettingsBase) popupMenuTool5.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance248).Image = (object) Resources.wrench_orange;
    ((ToolPropsBase) ((ToolBase) popupMenuTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance248;
    ((ToolPropsBase) ((ToolBase) popupMenuTool5).SharedPropsInternal).Caption = "Options";
    ((ToolPropsBase) ((ToolBase) popupMenuTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool12).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool5.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12
    });
    ((AppearanceBase) appearance249).Image = (object) Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance249;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "Post Transaction";
    ((ToolBase) buttonTool13).SharedPropsInternal.Category = "SharedTools";
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance250).Image = (object) Resources.arrow_undo;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance250;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Clear Screen";
    ((ToolBase) buttonTool14).SharedPropsInternal.Category = "SharedTools";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance251).Image = (object) Resources.cog_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance251;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Additional Offset";
    ((ToolBase) buttonTool15).SharedPropsInternal.Category = "SharedTools";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance252).TextHAlignAsString = "Left";
    ((ToolPropsBase) ((ToolBase) popupMenuTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance252;
    ((ToolPropsBase) ((ToolBase) popupMenuTool6).SharedPropsInternal).Caption = "Payable Options";
    ((ToolBase) popupMenuTool6).SharedPropsInternal.Category = "PayableTools";
    ((ToolBase) buttonTool18).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool20).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool22).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool23).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool25).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool26).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool27).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool6.Tools).AddRange(new ToolBase[14]
    {
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26,
      (ToolBase) stateButtonTool2,
      (ToolBase) buttonTool27,
      (ToolBase) buttonTool28
    });
    ((PopupToolBase) popupMenuTool7).DropDownArrowStyle = (DropDownArrowStyle) 4;
    ((ToolPropsBase) ((ToolBase) popupMenuTool7).SharedPropsInternal).Caption = "Payment Options";
    ((AppearanceBase) appearance253).Image = (object) Resources.money;
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance253;
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).Caption = "Pay In Full";
    ((ToolBase) buttonTool29).SharedPropsInternal.Category = "PayableTools";
    ((AppearanceBase) appearance254).Image = (object) Resources.money;
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance254;
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).Caption = "Pay All In Full";
    ((ToolBase) buttonTool30).SharedPropsInternal.Category = "PayableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedPropsInternal).Caption = "Write-Off Payables";
    ((ToolBase) buttonTool31).SharedPropsInternal.Category = "PayableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedPropsInternal).Caption = "Clear Applied Payable";
    ((ToolBase) buttonTool32).SharedPropsInternal.Category = "PayableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool33).SharedPropsInternal).Caption = "Clear All Applied Payables";
    ((ToolBase) buttonTool33).SharedPropsInternal.Category = "PayableTools";
    ((AppearanceBase) appearance255).Image = (object) Resources.building_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool34).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance255;
    ((ToolPropsBase) ((ToolBase) buttonTool34).SharedPropsInternal).Caption = "Finance Company";
    ((ToolBase) buttonTool34).SharedPropsInternal.Category = "PayableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool35).SharedPropsInternal).Caption = "View Policy Detail";
    ((ToolBase) buttonTool35).SharedPropsInternal.Category = "PayableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedPropsInternal).Caption = "Apply Un-Accounted Funds";
    ((ToolBase) buttonTool36).SharedPropsInternal.Category = "ReceivableTools";
    ((ToolBase) buttonTool36).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedPropsInternal).Caption = "Apply Exchange Funds";
    ((ToolBase) buttonTool37).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance256).Image = (object) Resources.eye;
    ((ToolPropsBase) ((ToolBase) stateButtonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance256;
    ((ToolPropsBase) ((ToolBase) stateButtonTool3).SharedPropsInternal).Caption = "Show Extended Information";
    ((ToolBase) stateButtonTool3).SharedPropsInternal.Category = "PayableTools";
    ((AppearanceBase) appearance257).Image = (object) Resources.money;
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance257;
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedPropsInternal).Caption = "Load Additional Payables";
    ((ToolBase) buttonTool38).SharedPropsInternal.Category = "PayableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool39).SharedPropsInternal).Caption = "Pay Proportional Amount Due";
    ((ToolBase) buttonTool39).SharedPropsInternal.Category = "PayableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool40).SharedPropsInternal).Caption = "Pay All Proportional Amount Due";
    ((ToolBase) buttonTool40).SharedPropsInternal.Category = "PayableTools";
    ((AppearanceBase) appearance258).Image = (object) Resources.picture_add;
    ((ToolPropsBase) ((ToolBase) stateButtonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance258;
    ((AppearanceBase) appearance259).BackColor = Color.White;
    ((AppearanceBase) appearance259).ForeColor = Color.Black;
    ((ToolPropsBase) ((ToolBase) stateButtonTool4).SharedPropsInternal).AppearancesSmall.PressedAppearance = (AppearanceBase) appearance259;
    ((ToolPropsBase) ((ToolBase) stateButtonTool4).SharedPropsInternal).Caption = "Toggle Paid Receivables";
    ((ToolBase) stateButtonTool4).SharedPropsInternal.Category = "PayableTools";
    ((ToolPropsBase) ((ToolBase) stateButtonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool41).SharedPropsInternal).Caption = "Write-Off Exchange";
    ((ToolBase) buttonTool41).SharedPropsInternal.Category = "ReceivableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool42).SharedPropsInternal).Caption = "Write-Off Un-Accounted";
    ((ToolBase) buttonTool42).SharedPropsInternal.Category = "ReceivableTools";
    ((ToolPropsBase) ((ToolBase) popupMenuTool8).SharedPropsInternal).Caption = "Receivable Options";
    ((ToolBase) popupMenuTool8).SharedPropsInternal.Category = "ReceivableTools";
    ((ToolBase) buttonTool45).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool47).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool50).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool52).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool53).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool54).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool8.Tools).AddRange(new ToolBase[14]
    {
      (ToolBase) buttonTool43,
      (ToolBase) buttonTool44,
      (ToolBase) buttonTool45,
      (ToolBase) buttonTool46,
      (ToolBase) buttonTool47,
      (ToolBase) buttonTool48,
      (ToolBase) buttonTool49,
      (ToolBase) buttonTool50,
      (ToolBase) buttonTool51,
      (ToolBase) buttonTool52,
      (ToolBase) buttonTool53,
      (ToolBase) stateButtonTool5,
      (ToolBase) buttonTool54,
      (ToolBase) buttonTool55
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool9).SharedPropsInternal).Caption = "GridContextMenu";
    ((ToolBase) buttonTool58).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool60).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool63).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool65).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool66).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool9.Tools).AddRange(new ToolBase[12]
    {
      (ToolBase) buttonTool56,
      (ToolBase) buttonTool57,
      (ToolBase) buttonTool58,
      (ToolBase) buttonTool59,
      (ToolBase) buttonTool60,
      (ToolBase) buttonTool61,
      (ToolBase) buttonTool62,
      (ToolBase) buttonTool63,
      (ToolBase) buttonTool64,
      (ToolBase) buttonTool65,
      (ToolBase) buttonTool66,
      (ToolBase) stateButtonTool6
    });
    ((AppearanceBase) appearance260).Image = (object) Resources.money;
    ((ToolPropsBase) ((ToolBase) buttonTool67).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance260;
    ((ToolPropsBase) ((ToolBase) buttonTool67).SharedPropsInternal).Caption = "Pay In Full";
    ((ToolBase) buttonTool67).SharedPropsInternal.Category = "ReceivableTools";
    ((AppearanceBase) appearance261).Image = (object) Resources.money;
    ((ToolPropsBase) ((ToolBase) buttonTool68).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance261;
    ((ToolPropsBase) ((ToolBase) buttonTool68).SharedPropsInternal).Caption = "Pay All In Full";
    ((ToolBase) buttonTool68).SharedPropsInternal.Category = "ReceivableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool69).SharedPropsInternal).Caption = "Write-Off Receivable";
    ((ToolBase) buttonTool69).SharedPropsInternal.Category = "ReceivableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool70).SharedPropsInternal).Caption = "Clear All Applied Receivables";
    ((ToolBase) buttonTool70).SharedPropsInternal.Category = "ReceivableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool71).SharedPropsInternal).Caption = "Clear Applied Receivable";
    ((ToolBase) buttonTool71).SharedPropsInternal.Category = "ReceivableTools";
    ((AppearanceBase) appearance262).Image = (object) Resources.building_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool72).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance262;
    ((ToolPropsBase) ((ToolBase) buttonTool72).SharedPropsInternal).Caption = "Finance Company";
    ((ToolBase) buttonTool72).SharedPropsInternal.Category = "ReceivableTools";
    ((ToolPropsBase) ((ToolBase) buttonTool73).SharedPropsInternal).Caption = "View Policy Detail";
    ((ToolBase) buttonTool73).SharedPropsInternal.Category = "ReceivableTools";
    ((AppearanceBase) appearance263).Image = (object) Resources.eye;
    ((ToolPropsBase) ((ToolBase) stateButtonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance263;
    ((ToolPropsBase) ((ToolBase) stateButtonTool7).SharedPropsInternal).Caption = "Show Extended Information";
    ((ToolBase) stateButtonTool7).SharedPropsInternal.Category = "ReceivableTools";
    ((AppearanceBase) appearance264).Image = (object) Resources.money;
    ((ToolPropsBase) ((ToolBase) buttonTool74).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance264;
    ((ToolPropsBase) ((ToolBase) buttonTool74).SharedPropsInternal).Caption = "Load Additional Receivables";
    ((ToolBase) buttonTool74).SharedPropsInternal.Category = "ReceivableTools";
    ((AppearanceBase) appearance265).Image = (object) Resources.bricks;
    ((ToolPropsBase) ((ToolBase) popupMenuTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance265;
    ((ToolPropsBase) ((ToolBase) popupMenuTool10).SharedPropsInternal).Caption = "Load Additional";
    ((ToolBase) popupMenuTool10).SharedPropsInternal.Category = "SharedTools";
    ((ToolsCollectionBase) popupMenuTool10.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool75,
      (ToolBase) buttonTool76
    });
    controlContainerTool2.ControlName = "panelToggleCheckRequested";
    ((PopupToolBase) controlContainerTool2).DropDownArrowStyle = (DropDownArrowStyle) 2;
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).SharedPropsInternal).Caption = "Toggle Check Requested";
    ((ToolBase) controlContainerTool2).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance266).Image = (object) Resources.printer;
    ((ToolPropsBase) ((ToolBase) buttonTool77).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance266;
    ((ToolPropsBase) ((ToolBase) buttonTool77).SharedPropsInternal).Caption = "Print Data";
    ((ToolPropsBase) ((ToolBase) buttonTool78).SharedPropsInternal).Caption = "Button Test";
    ((AppearanceBase) appearance267).Image = (object) Resources.error_go;
    ((ToolPropsBase) ((ToolBase) buttonTool79).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance267;
    ((ToolPropsBase) ((ToolBase) buttonTool79).SharedPropsInternal).Caption = "Import Errors";
    ((AppearanceBase) appearance268).Image = (object) Resources.list_components;
    ((ToolPropsBase) ((ToolBase) buttonTool80).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance268;
    ((ToolPropsBase) ((ToolBase) buttonTool80).SharedPropsInternal).Caption = "Column Chooser";
    ((AppearanceBase) appearance269).Image = (object) Resources.list_components;
    ((ToolPropsBase) ((ToolBase) buttonTool81).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance269;
    ((ToolPropsBase) ((ToolBase) buttonTool81).SharedPropsInternal).Caption = "Column Chooser";
    ((ToolPropsBase) ((ToolBase) buttonTool82).SharedPropsInternal).Caption = "Reset Payables Layouts";
    ((ToolPropsBase) ((ToolBase) buttonTool83).SharedPropsInternal).Caption = "Reset Receivables Layouts";
    ((AppearanceBase) appearance270).Image = (object) Resources.help;
    ((ToolPropsBase) ((ToolBase) buttonTool84).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance270;
    ((ToolPropsBase) ((ToolBase) buttonTool84).SharedPropsInternal).Caption = "Help";
    ((ToolsCollectionBase) this.toolbar.Tools).AddRange(new ToolBase[46]
    {
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) popupMenuTool5,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) popupMenuTool6,
      (ToolBase) popupMenuTool7,
      (ToolBase) buttonTool29,
      (ToolBase) buttonTool30,
      (ToolBase) buttonTool31,
      (ToolBase) buttonTool32,
      (ToolBase) buttonTool33,
      (ToolBase) buttonTool34,
      (ToolBase) buttonTool35,
      (ToolBase) buttonTool36,
      (ToolBase) buttonTool37,
      (ToolBase) stateButtonTool3,
      (ToolBase) buttonTool38,
      (ToolBase) buttonTool39,
      (ToolBase) buttonTool40,
      (ToolBase) stateButtonTool4,
      (ToolBase) buttonTool41,
      (ToolBase) buttonTool42,
      (ToolBase) popupMenuTool8,
      (ToolBase) popupMenuTool9,
      (ToolBase) buttonTool67,
      (ToolBase) buttonTool68,
      (ToolBase) buttonTool69,
      (ToolBase) buttonTool70,
      (ToolBase) buttonTool71,
      (ToolBase) buttonTool72,
      (ToolBase) buttonTool73,
      (ToolBase) stateButtonTool7,
      (ToolBase) buttonTool74,
      (ToolBase) popupMenuTool10,
      (ToolBase) controlContainerTool2,
      (ToolBase) buttonTool77,
      (ToolBase) buttonTool78,
      (ToolBase) buttonTool79,
      (ToolBase) buttonTool80,
      (ToolBase) buttonTool81,
      (ToolBase) buttonTool82,
      (ToolBase) buttonTool83,
      (ToolBase) buttonTool84
    });
    this.toolbar.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.toolbar_BeforeToolDropdown);
    this.toolbar.ToolClick += new ToolClickEventHandler(this.ToolBarClicked);
    ((Control) this._formReceivables_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formReceivables_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Left).Location = new Point(208 /*0xD0*/, 45);
    ((Control) this._formReceivables_Toolbars_Dock_Area_Left).Name = "_formReceivables_Toolbars_Dock_Area_Left";
    ((Control) this._formReceivables_Toolbars_Dock_Area_Left).Size = new Size(0, 725);
    this._formReceivables_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolbar;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formReceivables_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Right).Location = new Point(1052, 45);
    ((Control) this._formReceivables_Toolbars_Dock_Area_Right).Name = "_formReceivables_Toolbars_Dock_Area_Right";
    ((Control) this._formReceivables_Toolbars_Dock_Area_Right).Size = new Size(0, 725);
    this._formReceivables_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolbar;
    ((AppearanceBase) appearance271).BackColor = Color.LightSteelBlue;
    ((UltraTabControlBase) this.tabTransactions).Appearance = (AppearanceBase) appearance271;
    ((Control) this.tabTransactions).Controls.Add((Control) this.ultraTabSharedControlsPage1);
    ((Control) this.tabTransactions).Controls.Add((Control) this.tabPagePayable);
    ((Control) this.tabTransactions).Controls.Add((Control) this.tabPageReceivable);
    ((Control) this.tabTransactions).Controls.Add((Control) this.tabNonPayableFees);
    ((Control) this.tabTransactions).Controls.Add((Control) this.tabAdditonalOffsets);
    ((Control) this.tabTransactions).Controls.Add((Control) this.tabSummary);
    ((Control) this.tabTransactions).Controls.Add((Control) this.ultraTabPageControl1);
    ((Control) this.tabTransactions).Dock = DockStyle.Fill;
    ((Control) this.tabTransactions).Location = new Point(208 /*0xD0*/, 45);
    ((Control) this.tabTransactions).Name = "tabTransactions";
    ((UltraTabControlBase) this.tabTransactions).SharedControlsPage = this.ultraTabSharedControlsPage1;
    ((Control) this.tabTransactions).Size = new Size(844, 725);
    ((UltraTabControlBase) this.tabTransactions).Style = (UltraTabControlStyle) 12;
    ((Control) this.tabTransactions).TabIndex = 1;
    ((KeyedSubObjectBase) ultraTab1).Key = "PAYABLE";
    ultraTab1.TabPage = this.tabPagePayable;
    ultraTab1.Text = "Accounts Payable";
    ((KeyedSubObjectBase) ultraTab2).Key = "RECEIVABLE";
    ultraTab2.TabPage = this.tabPageReceivable;
    ultraTab2.Text = "Accounts Receivable";
    ((KeyedSubObjectBase) ultraTab3).Key = "NONPAYABLEFEES";
    ultraTab3.TabPage = this.tabNonPayableFees;
    ultraTab3.Text = "Non  Payable Fees";
    ultraTab3.Visible = false;
    ((KeyedSubObjectBase) ultraTab4).Key = "ADDITIONALOFFSETS";
    ultraTab4.TabPage = this.tabAdditonalOffsets;
    ultraTab4.Text = "Additional Offsets";
    ultraTab4.Visible = false;
    ((KeyedSubObjectBase) ultraTab5).Key = "SUMMARY";
    ultraTab5.TabPage = this.tabSummary;
    ultraTab5.Text = "Summary";
    ultraTab5.Visible = false;
    ((KeyedSubObjectBase) ultraTab6).Key = "NWD";
    ultraTab6.TabPage = this.ultraTabPageControl1;
    ultraTab6.Text = "Working Deposit";
    ultraTab6.Visible = false;
    ((UltraTabControlBase) this.tabTransactions).Tabs.AddRange(new UltraTab[6]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4,
      ultraTab5,
      ultraTab6
    });
    ((UltraTabControlBase) this.tabTransactions).SelectedTabChanged += new SelectedTabChangedEventHandler(this.tabTransactions_SelectedTabChanged);
    ((Control) this.ultraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage1).Name = "ultraTabSharedControlsPage1";
    ((Control) this.ultraTabSharedControlsPage1).Size = new Size(842, 704);
    this.panel1.BackColor = Color.FromArgb(239, 247, 253);
    this.panel1.Controls.Add((Control) this.comboPayeePaymentMethods);
    this.panel1.Controls.Add((Control) this.buttonCancelAppliedUnaccounted);
    this.panel1.Controls.Add((Control) this.buttonAppliedUnaccounted);
    this.panel1.Controls.Add((Control) this.checkCreditCard);
    this.panel1.Controls.Add((Control) this.btnSearchCheckFrom);
    this.panel1.Controls.Add((Control) this.linkRemoveCheckFrom);
    this.panel1.Controls.Add((Control) this.txtCheckFrom);
    this.panel1.Controls.Add((Control) this.label17);
    this.panel1.Controls.Add((Control) this.comboUnAccountedCostCenter);
    this.panel1.Controls.Add((Control) this.label16);
    this.panel1.Controls.Add((Control) this.txtNonPayableFees);
    this.panel1.Controls.Add((Control) this.lblNonPayableFees);
    this.panel1.Controls.Add((Control) this.label15);
    this.panel1.Controls.Add((Control) this.txtPostingMemo);
    this.panel1.Controls.Add((Control) this.chkReturnPremium);
    this.panel1.Controls.Add((Control) this.label8);
    this.panel1.Controls.Add((Control) this.comboPaymentMethods);
    this.panel1.Controls.Add((Control) this.label7);
    this.panel1.Controls.Add((Control) this.labelPayAmt);
    this.panel1.Controls.Add((Control) this.txtPayAmount);
    this.panel1.Controls.Add((Control) this.labelBalance);
    this.panel1.Controls.Add((Control) this.txtBalance);
    this.panel1.Controls.Add((Control) this.labelCheckDate);
    this.panel1.Controls.Add((Control) this.dateTimeCheckDate);
    this.panel1.Controls.Add((Control) this.labelReceivedDate);
    this.panel1.Controls.Add((Control) this.labelDepositDate);
    this.panel1.Controls.Add((Control) this.dateTimeReceivedDate);
    this.panel1.Controls.Add((Control) this.dateTimeDepositDate);
    this.panel1.Controls.Add((Control) this.labelCheckNumber);
    this.panel1.Controls.Add((Control) this.txtCheckNumber);
    this.panel1.Controls.Add((Control) this.labelCheckAmount);
    this.panel1.Controls.Add((Control) this.txtCheckAmount);
    this.panel1.Controls.Add((Control) this.label10);
    this.panel1.Controls.Add((Control) this.txtAppliedUnAccounted);
    this.panel1.Controls.Add((Control) this.label12);
    this.panel1.Controls.Add((Control) this.txtUnAccountedBalance);
    this.panel1.Controls.Add((Control) this.label11);
    this.panel1.Controls.Add((Control) this.radioCashReceipt);
    this.panel1.Controls.Add((Control) this.radioCashDisbursement);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.comboBankAccount);
    this.panel1.Controls.Add((Control) this.txtEntityName);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.lblbBankCurrency);
    this.panel1.Dock = DockStyle.Left;
    this.panel1.Location = new Point(0, 45);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(208 /*0xD0*/, 725);
    this.panel1.TabIndex = 0;
    this.comboPayeePaymentMethods.Enabled = false;
    this.comboPayeePaymentMethods.Location = new Point(88, 348);
    this.comboPayeePaymentMethods.Name = "comboPayeePaymentMethods";
    this.comboPayeePaymentMethods.Size = new Size(112 /*0x70*/, 21);
    this.comboPayeePaymentMethods.TabIndex = 50;
    this.comboPayeePaymentMethods.Visible = false;
    ((AppearanceBase) appearance272).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance272).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance272).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance272).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance272).Image = (object) Resources.delete;
    ((AppearanceBase) appearance272).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance272).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancelAppliedUnaccounted).Appearance = (AppearanceBase) appearance272;
    ((Control) this.buttonCancelAppliedUnaccounted).Location = new Point(154, 489);
    ((Control) this.buttonCancelAppliedUnaccounted).Name = "buttonCancelAppliedUnaccounted";
    ((Control) this.buttonCancelAppliedUnaccounted).Size = new Size(24, 24);
    ((Control) this.buttonCancelAppliedUnaccounted).TabIndex = (int) sbyte.MaxValue;
    this.toolTip1.SetToolTip((Control) this.buttonCancelAppliedUnaccounted, "Click here to clear all direct un-accounted applications.");
    ((UltraControlBase) this.buttonCancelAppliedUnaccounted).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancelAppliedUnaccounted).Click += new EventHandler(this.buttonCancelAppliedUnaccounted_Click);
    ((AppearanceBase) appearance273).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance273).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance273).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance273).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance273).Image = (object) Resources.bricks;
    ((AppearanceBase) appearance273).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance273).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonAppliedUnaccounted).Appearance = (AppearanceBase) appearance273;
    ((Control) this.buttonAppliedUnaccounted).Location = new Point(129, 489);
    ((Control) this.buttonAppliedUnaccounted).Name = "buttonAppliedUnaccounted";
    ((Control) this.buttonAppliedUnaccounted).Size = new Size(24, 24);
    ((Control) this.buttonAppliedUnaccounted).TabIndex = 126;
    this.toolTip1.SetToolTip((Control) this.buttonAppliedUnaccounted, "Click here to apply un-accounted against a specific un-accounted trasnsaction.");
    ((UltraControlBase) this.buttonAppliedUnaccounted).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonAppliedUnaccounted).Click += new EventHandler(this.buttonAppliedUnaccounted_Click);
    ((AppearanceBase) appearance274).BorderColor = Color.Gray;
    ((AppearanceBase) appearance274).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkCreditCard).Appearance = (AppearanceBase) appearance274;
    ((Control) this.checkCreditCard).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkCreditCard).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkCreditCard).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkCreditCard).Location = new Point(118, 141);
    ((Control) this.checkCreditCard).Name = "checkCreditCard";
    ((Control) this.checkCreditCard).Size = new Size(82, 13);
    ((Control) this.checkCreditCard).TabIndex = 124;
    ((Control) this.checkCreditCard).Text = "Credit Card";
    ((UltraToggleEditorBase) this.checkCreditCard).CheckStateChanged += new EventHandler(this.checkCreditCard_CheckStateChanged);
    ((AppearanceBase) appearance275).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance275).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance275).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance275).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance275).Image = (object) Resources.SearchTransaction;
    ((AppearanceBase) appearance275).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance275).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearchCheckFrom).Appearance = (AppearanceBase) appearance275;
    ((Control) this.btnSearchCheckFrom).Location = new Point(177, 110);
    ((Control) this.btnSearchCheckFrom).Name = "btnSearchCheckFrom";
    ((Control) this.btnSearchCheckFrom).Size = new Size(21, 21);
    ((Control) this.btnSearchCheckFrom).TabIndex = 125;
    ((UltraControlBase) this.btnSearchCheckFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSearchCheckFrom).Click += new EventHandler(this.btnSearchCheckFrom_Click);
    this.linkRemoveCheckFrom.AutoSize = true;
    this.linkRemoveCheckFrom.Location = new Point(132, 94);
    this.linkRemoveCheckFrom.Name = "linkRemoveCheckFrom";
    this.linkRemoveCheckFrom.Size = new Size(46, 13);
    this.linkRemoveCheckFrom.TabIndex = 63 /*0x3F*/;
    this.linkRemoveCheckFrom.TabStop = true;
    this.linkRemoveCheckFrom.Text = "Remove";
    this.linkRemoveCheckFrom.Visible = false;
    this.linkRemoveCheckFrom.Click += new EventHandler(this.linkRemoveCheckFrom_Click);
    ((AppearanceBase) appearance276).BackColor = Color.White;
    ((AppearanceBase) appearance276).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance276).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCheckFrom).Appearance = (AppearanceBase) appearance276;
    ((Control) this.txtCheckFrom).BackColor = Color.White;
    ((Control) this.txtCheckFrom).Location = new Point(8, 110);
    this.txtCheckFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCheckFrom).Name = "txtCheckFrom";
    ((EditorButtonControlBase) this.txtCheckFrom).ReadOnly = true;
    ((Control) this.txtCheckFrom).Size = new Size(168, 20);
    ((Control) this.txtCheckFrom).TabIndex = 62;
    ((UltraControlBase) this.txtCheckFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCheckFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.label17.BackColor = Color.Transparent;
    this.label17.Location = new Point(9, 94);
    this.label17.Name = "label17";
    this.label17.Size = new Size(77, 16 /*0x10*/);
    this.label17.TabIndex = 61;
    this.label17.Text = "Check From:";
    this.comboUnAccountedCostCenter.BorderStyle = (UIElementBorderStyle) 4;
    this.comboUnAccountedCostCenter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboUnAccountedCostCenter).DropDownWidth = 300;
    ((Control) this.comboUnAccountedCostCenter).Location = new Point(8, 530);
    this.comboUnAccountedCostCenter.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboUnAccountedCostCenter).Name = "comboUnAccountedCostCenter";
    ((Control) this.comboUnAccountedCostCenter).Size = new Size(192 /*0xC0*/, 21);
    ((Control) this.comboUnAccountedCostCenter).TabIndex = 60;
    ((UltraControlBase) this.comboUnAccountedCostCenter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboUnAccountedCostCenter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboUnAccountedCostCenter).ValueMember = "GLACCTID";
    this.label16.AutoSize = true;
    this.label16.BackColor = Color.Transparent;
    this.label16.Location = new Point(8, 514);
    this.label16.Name = "label16";
    this.label16.Size = new Size(143, 13);
    this.label16.TabIndex = 59;
    this.label16.Text = "Un-Accounted Cost Center: ";
    ((AppearanceBase) appearance277).BackColor = Color.White;
    ((AppearanceBase) appearance277).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance277).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtNonPayableFees).Appearance = (AppearanceBase) appearance277;
    ((Control) this.txtNonPayableFees).BackColor = Color.White;
    ((Control) this.txtNonPayableFees).Location = new Point(8, 721);
    this.txtNonPayableFees.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtNonPayableFees).Name = "txtNonPayableFees";
    ((Control) this.txtNonPayableFees).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.txtNonPayableFees).TabIndex = 58;
    ((UltraControlBase) this.txtNonPayableFees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtNonPayableFees).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtNonPayableFees).Visible = false;
    this.lblNonPayableFees.AutoSize = true;
    this.lblNonPayableFees.BackColor = Color.Transparent;
    this.lblNonPayableFees.Location = new Point(8, 705);
    this.lblNonPayableFees.Name = "lblNonPayableFees";
    this.lblNonPayableFees.Size = new Size(94, 13);
    this.lblNonPayableFees.TabIndex = 57;
    this.lblNonPayableFees.Text = "Non-Payable Fees";
    this.lblNonPayableFees.Visible = false;
    this.label15.AutoSize = true;
    this.label15.BackColor = Color.Transparent;
    this.label15.Location = new Point(8, 554);
    this.label15.Name = "label15";
    this.label15.Size = new Size(77, 13);
    this.label15.TabIndex = 55;
    this.label15.Text = "Posting Memo:";
    ((Control) this.txtPostingMemo).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance278).BackColor = Color.White;
    ((AppearanceBase) appearance278).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance278).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPostingMemo).Appearance = (AppearanceBase) appearance278;
    ((Control) this.txtPostingMemo).BackColor = Color.White;
    ((Control) this.txtPostingMemo).Location = new Point(8, 574);
    ((TextEditorControlBase) this.txtPostingMemo).MaxLength = 2000;
    this.txtPostingMemo.MGAStyle = MGAStyles.Blue;
    this.txtPostingMemo.Multiline = true;
    ((Control) this.txtPostingMemo).Name = "txtPostingMemo";
    ((Control) this.txtPostingMemo).Size = new Size(192 /*0xC0*/, 128 /*0x80*/);
    ((Control) this.txtPostingMemo).TabIndex = 56;
    ((UltraControlBase) this.txtPostingMemo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPostingMemo).UseOsThemes = (DefaultableBoolean) 2;
    this.chkReturnPremium.Enabled = false;
    this.chkReturnPremium.FlatStyle = FlatStyle.Flat;
    this.chkReturnPremium.Location = new Point(8, 408);
    this.chkReturnPremium.Name = "chkReturnPremium";
    this.chkReturnPremium.Size = new Size(176 /*0xB0*/, 24);
    this.chkReturnPremium.TabIndex = 54;
    this.chkReturnPremium.Text = "&Book as Return Premium";
    this.label8.BackColor = Color.LightSteelBlue;
    this.label8.Location = new Point(8, 400);
    this.label8.Name = "label8";
    this.label8.Size = new Size(190, 1);
    this.label8.TabIndex = 53;
    this.comboPaymentMethods.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboPaymentMethods).DataMember = "PaymentMethods";
    ((UltraDropDownBase) this.comboPaymentMethods).DisplayMember = "MethodName";
    this.comboPaymentMethods.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboPaymentMethods).Enabled = false;
    ((Control) this.comboPaymentMethods).Location = new Point(88, 348);
    this.comboPaymentMethods.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPaymentMethods).Name = "comboPaymentMethods";
    ((Control) this.comboPaymentMethods).Size = new Size(112 /*0x70*/, 21);
    ((Control) this.comboPaymentMethods).TabIndex = 50;
    ((UltraControlBase) this.comboPaymentMethods).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPaymentMethods).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboPaymentMethods).ValueMember = "PayMethodID";
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.Font = new Font("Tahoma", 8f);
    this.label7.Location = new Point(8, 348);
    this.label7.Name = "label7";
    this.label7.Size = new Size(68, 13);
    this.label7.TabIndex = 49;
    this.label7.Text = "Pay Method:";
    this.labelPayAmt.AutoSize = true;
    this.labelPayAmt.BackColor = Color.Transparent;
    this.labelPayAmt.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.labelPayAmt.Location = new Point(8, 372);
    this.labelPayAmt.Name = "labelPayAmt";
    this.labelPayAmt.Size = new Size(58, 13);
    this.labelPayAmt.TabIndex = 51;
    this.labelPayAmt.Text = "Pay Amt:";
    ((AppearanceBase) appearance279).BackColor = Color.White;
    ((AppearanceBase) appearance279).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance279).ForeColor = Color.Black;
    ((AppearanceBase) appearance279).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.txtPayAmount).Appearance = (AppearanceBase) appearance279;
    ((Control) this.txtPayAmount).BackColor = Color.White;
    ((Control) this.txtPayAmount).Location = new Point(88, 372);
    this.txtPayAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtPayAmount).Name = "txtPayAmount";
    ((EditorButtonControlBase) this.txtPayAmount).ReadOnly = true;
    ((Control) this.txtPayAmount).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.txtPayAmount).TabIndex = 52;
    ((Control) this.txtPayAmount).TabStop = false;
    ((UltraControlBase) this.txtPayAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPayAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtPayAmount).Validating += new CancelEventHandler(this.textAmount_Validating);
    this.labelBalance.AutoSize = true;
    this.labelBalance.BackColor = Color.Transparent;
    this.labelBalance.Font = new Font("Tahoma", 8f, FontStyle.Bold);
    this.labelBalance.Location = new Point(5, 184);
    this.labelBalance.Name = "labelBalance";
    this.labelBalance.Size = new Size(54, 13);
    this.labelBalance.TabIndex = 39;
    this.labelBalance.Text = "Balance:";
    this.txtBalance.AcceptsReturn = true;
    ((AppearanceBase) appearance280).BackColor = Color.White;
    ((AppearanceBase) appearance280).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance280).ForeColor = Color.Black;
    ((AppearanceBase) appearance280).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.txtBalance).Appearance = (AppearanceBase) appearance280;
    ((Control) this.txtBalance).BackColor = Color.White;
    ((Control) this.txtBalance).Location = new Point(88, 184);
    this.txtBalance.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtBalance).Name = "txtBalance";
    ((EditorButtonControlBase) this.txtBalance).ReadOnly = true;
    ((Control) this.txtBalance).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.txtBalance).TabIndex = 40;
    ((Control) this.txtBalance).TabStop = false;
    ((UltraControlBase) this.txtBalance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtBalance).UseOsThemes = (DefaultableBoolean) 2;
    this.labelCheckDate.AutoSize = true;
    this.labelCheckDate.BackColor = Color.Transparent;
    this.labelCheckDate.Location = new Point(8, 324);
    this.labelCheckDate.Name = "labelCheckDate";
    this.labelCheckDate.Size = new Size(66, 13);
    this.labelCheckDate.TabIndex = 47;
    this.labelCheckDate.Text = "Check Date:";
    ((AppearanceBase) appearance281).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeCheckDate.Appearance = (AppearanceBase) appearance281;
    ((AppearanceBase) appearance282).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance282).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance282).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance282).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance282).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance282).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance282).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance282).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance282).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance282).ForegroundAlpha = (Alpha) 2;
    this.dateTimeCheckDate.ButtonAppearance = (AppearanceBase) appearance282;
    ((Control) this.dateTimeCheckDate).Enabled = false;
    ((Control) this.dateTimeCheckDate).Location = new Point(88, 324);
    this.dateTimeCheckDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeCheckDate).Name = "dateTimeCheckDate";
    ((Control) this.dateTimeCheckDate).Size = new Size(88, 20);
    ((Control) this.dateTimeCheckDate).TabIndex = 48 /*0x30*/;
    ((UltraControlBase) this.dateTimeCheckDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeCheckDate).UseOsThemes = (DefaultableBoolean) 2;
    this.labelReceivedDate.AutoSize = true;
    this.labelReceivedDate.BackColor = Color.Transparent;
    this.labelReceivedDate.Location = new Point(5, 254);
    this.labelReceivedDate.Name = "labelReceivedDate";
    this.labelReceivedDate.Size = new Size(81, 13);
    this.labelReceivedDate.TabIndex = 45;
    this.labelReceivedDate.Text = "Received Date:";
    this.labelDepositDate.AutoSize = true;
    this.labelDepositDate.BackColor = Color.Transparent;
    this.labelDepositDate.Location = new Point(5, 232);
    this.labelDepositDate.Name = "labelDepositDate";
    this.labelDepositDate.Size = new Size(73, 13);
    this.labelDepositDate.TabIndex = 43;
    this.labelDepositDate.Text = "Deposit Date:";
    ((AppearanceBase) appearance283).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeReceivedDate.Appearance = (AppearanceBase) appearance283;
    ((AppearanceBase) appearance284).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance284).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance284).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance284).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance284).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance284).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance284).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance284).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance284).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance284).ForegroundAlpha = (Alpha) 2;
    this.dateTimeReceivedDate.ButtonAppearance = (AppearanceBase) appearance284;
    ((Control) this.dateTimeReceivedDate).Location = new Point(88, 254);
    this.dateTimeReceivedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeReceivedDate).Name = "dateTimeReceivedDate";
    ((Control) this.dateTimeReceivedDate).Size = new Size(88, 20);
    ((Control) this.dateTimeReceivedDate).TabIndex = 46;
    ((UltraControlBase) this.dateTimeReceivedDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeReceivedDate).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance285).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeDepositDate.Appearance = (AppearanceBase) appearance285;
    ((AppearanceBase) appearance286).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance286).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance286).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance286).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance286).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance286).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance286).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance286).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance286).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance286).ForegroundAlpha = (Alpha) 2;
    this.dateTimeDepositDate.ButtonAppearance = (AppearanceBase) appearance286;
    ((Control) this.dateTimeDepositDate).Location = new Point(88, 231);
    this.dateTimeDepositDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeDepositDate).Name = "dateTimeDepositDate";
    ((Control) this.dateTimeDepositDate).Size = new Size(88, 20);
    ((Control) this.dateTimeDepositDate).TabIndex = 44;
    ((UltraControlBase) this.dateTimeDepositDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeDepositDate).UseOsThemes = (DefaultableBoolean) 2;
    this.labelCheckNumber.AutoSize = true;
    this.labelCheckNumber.BackColor = Color.Transparent;
    this.labelCheckNumber.Location = new Point(5, 208 /*0xD0*/);
    this.labelCheckNumber.Name = "labelCheckNumber";
    this.labelCheckNumber.Size = new Size(51, 13);
    this.labelCheckNumber.TabIndex = 41;
    this.labelCheckNumber.Text = "Check #:";
    ((AppearanceBase) appearance287).BackColor = Color.White;
    ((AppearanceBase) appearance287).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance287).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCheckNumber).Appearance = (AppearanceBase) appearance287;
    ((Control) this.txtCheckNumber).BackColor = Color.White;
    ((Control) this.txtCheckNumber).Location = new Point(88, 208 /*0xD0*/);
    ((TextEditorControlBase) this.txtCheckNumber).MaxLength = 20;
    this.txtCheckNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCheckNumber).Name = "txtCheckNumber";
    ((Control) this.txtCheckNumber).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.txtCheckNumber).TabIndex = 42;
    ((UltraControlBase) this.txtCheckNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCheckNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.labelCheckAmount.AutoSize = true;
    this.labelCheckAmount.BackColor = Color.Transparent;
    this.labelCheckAmount.Location = new Point(5, 160 /*0xA0*/);
    this.labelCheckAmount.Name = "labelCheckAmount";
    this.labelCheckAmount.Size = new Size(80 /*0x50*/, 13);
    this.labelCheckAmount.TabIndex = 37;
    this.labelCheckAmount.Text = "Check Amount:";
    ((AppearanceBase) appearance288).BackColor = Color.White;
    ((AppearanceBase) appearance288).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance288).ForeColor = Color.Black;
    ((AppearanceBase) appearance288).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.txtCheckAmount).Appearance = (AppearanceBase) appearance288;
    ((Control) this.txtCheckAmount).BackColor = Color.White;
    ((Control) this.txtCheckAmount).Location = new Point(88, 160 /*0xA0*/);
    this.txtCheckAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtCheckAmount).Name = "txtCheckAmount";
    ((Control) this.txtCheckAmount).Size = new Size(112 /*0x70*/, 20);
    ((Control) this.txtCheckAmount).TabIndex = 38;
    ((UltraControlBase) this.txtCheckAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCheckAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtCheckAmount).Validating += new CancelEventHandler(this.textAmount_Validating);
    this.label10.BackColor = Color.LightSteelBlue;
    this.label10.Location = new Point(8, 288);
    this.label10.Name = "label10";
    this.label10.Size = new Size(190, 1);
    this.label10.TabIndex = 36;
    ((AppearanceBase) appearance289).BackColor = Color.White;
    ((AppearanceBase) appearance289).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance289).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAppliedUnAccounted).Appearance = (AppearanceBase) appearance289;
    ((Control) this.txtAppliedUnAccounted).BackColor = Color.White;
    ((Control) this.txtAppliedUnAccounted).Location = new Point(8, 491);
    this.txtAppliedUnAccounted.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAppliedUnAccounted).Name = "txtAppliedUnAccounted";
    ((Control) this.txtAppliedUnAccounted).Size = new Size(117, 20);
    ((Control) this.txtAppliedUnAccounted).TabIndex = 35;
    ((UltraControlBase) this.txtAppliedUnAccounted).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAppliedUnAccounted).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.txtAppliedUnAccounted).Validating += new CancelEventHandler(this.textAmount_Validating);
    this.label12.AutoSize = true;
    this.label12.BackColor = Color.Transparent;
    this.label12.Location = new Point(8, 475);
    this.label12.Name = "label12";
    this.label12.Size = new Size(117, 13);
    this.label12.TabIndex = 34;
    this.label12.Text = "Applied Un-Accounted:";
    ((AppearanceBase) appearance290).BackColor = Color.White;
    ((AppearanceBase) appearance290).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance290).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtUnAccountedBalance).Appearance = (AppearanceBase) appearance290;
    ((Control) this.txtUnAccountedBalance).BackColor = Color.White;
    ((Control) this.txtUnAccountedBalance).Location = new Point(8, 451);
    this.txtUnAccountedBalance.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtUnAccountedBalance).Name = "txtUnAccountedBalance";
    ((EditorButtonControlBase) this.txtUnAccountedBalance).ReadOnly = true;
    ((Control) this.txtUnAccountedBalance).Size = new Size(119, 20);
    ((Control) this.txtUnAccountedBalance).TabIndex = 33;
    ((Control) this.txtUnAccountedBalance).TabStop = false;
    ((UltraControlBase) this.txtUnAccountedBalance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtUnAccountedBalance).UseOsThemes = (DefaultableBoolean) 2;
    this.label11.AutoSize = true;
    this.label11.BackColor = Color.Transparent;
    this.label11.Location = new Point(8, 435);
    this.label11.Name = "label11";
    this.label11.Size = new Size(119, 13);
    this.label11.TabIndex = 32 /*0x20*/;
    this.label11.Text = "Un-Accounted Balance:";
    this.radioCashReceipt.BackColor = Color.Transparent;
    this.radioCashReceipt.Checked = true;
    this.radioCashReceipt.FlatStyle = FlatStyle.Flat;
    this.radioCashReceipt.Location = new Point(8, 136);
    this.radioCashReceipt.Name = "radioCashReceipt";
    this.radioCashReceipt.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.radioCashReceipt.TabIndex = 15;
    this.radioCashReceipt.TabStop = true;
    this.radioCashReceipt.Text = "Cash &Receipt";
    this.radioCashReceipt.UseVisualStyleBackColor = false;
    this.radioCashReceipt.Click += new EventHandler(this.radioCashReceipt_Click);
    this.radioCashDisbursement.BackColor = Color.Transparent;
    this.radioCashDisbursement.FlatStyle = FlatStyle.Flat;
    this.radioCashDisbursement.Location = new Point(8, 302);
    this.radioCashDisbursement.Name = "radioCashDisbursement";
    this.radioCashDisbursement.Size = new Size(136, 16 /*0x10*/);
    this.radioCashDisbursement.TabIndex = 14;
    this.radioCashDisbursement.Text = "Cash &Disbursement";
    this.radioCashDisbursement.UseVisualStyleBackColor = false;
    this.radioCashDisbursement.CheckedChanged += new EventHandler(this.RadioCashDisbursement_CheckedChanged);
    this.radioCashDisbursement.Click += new EventHandler(this.radioCashDisbursement_Click);
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(8, 48 /*0x30*/);
    this.label2.Name = "label2";
    this.label2.Size = new Size(77, 16 /*0x10*/);
    this.label2.TabIndex = 11;
    this.label2.Text = "Bank Account:";
    this.comboBankAccount.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboBankAccount).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.comboBankAccount).DataSource = (object) this.dsBankAccounts;
    ((UltraDropDownBase) this.comboBankAccount).DisplayMember = "BANKNAME";
    this.comboBankAccount.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboBankAccount).DropDownWidth = 300;
    ((Control) this.comboBankAccount).Location = new Point(8, 64 /*0x40*/);
    this.comboBankAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccount).Name = "comboBankAccount";
    ((Control) this.comboBankAccount).Size = new Size(192 /*0xC0*/, 21);
    ((Control) this.comboBankAccount).TabIndex = 10;
    ((UltraControlBase) this.comboBankAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboBankAccount).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboBankAccount).ValueMember = "GLACCTID";
    this.comboBankAccount.RowSelected += new RowSelectedEventHandler(this.comboBankAccount_RowSelected);
    this.dsBankAccounts.DataSetName = "dsBankAccounts";
    this.dsBankAccounts.Locale = new CultureInfo("en-US");
    ((AppearanceBase) appearance291).BackColor = Color.White;
    ((AppearanceBase) appearance291).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance291).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtEntityName).Appearance = (AppearanceBase) appearance291;
    ((Control) this.txtEntityName).BackColor = Color.White;
    ((Control) this.txtEntityName).Location = new Point(8, 24);
    this.txtEntityName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtEntityName).Name = "txtEntityName";
    ((EditorButtonControlBase) this.txtEntityName).ReadOnly = true;
    ((Control) this.txtEntityName).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.txtEntityName).TabIndex = 9;
    ((UltraControlBase) this.txtEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtEntityName).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(8, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(39, 13);
    this.label1.TabIndex = 8;
    this.label1.Text = "Entity:";
    this.lblbBankCurrency.AutoSize = true;
    this.lblbBankCurrency.BackColor = Color.Transparent;
    this.lblbBankCurrency.ForeColor = Color.DarkGreen;
    this.lblbBankCurrency.Location = new Point(120, 49);
    this.lblbBankCurrency.Name = "lblbBankCurrency";
    this.lblbBankCurrency.Size = new Size(78, 13);
    this.lblbBankCurrency.TabIndex = 123;
    this.lblbBankCurrency.Text = "Currency: USD";
    ((Control) this._formReceivables_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formReceivables_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formReceivables_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formReceivables_Toolbars_Dock_Area_Top).Name = "_formReceivables_Toolbars_Dock_Area_Top";
    ((Control) this._formReceivables_Toolbars_Dock_Area_Top).Size = new Size(1052, 45);
    this._formReceivables_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolbar;
    this.labelCurtain.BackColor = Color.FromArgb(239, 247, 253);
    this.labelCurtain.Dock = DockStyle.Fill;
    this.labelCurtain.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelCurtain.ForeColor = Color.LightSlateGray;
    this.labelCurtain.Location = new Point(0, 0);
    this.labelCurtain.Name = "labelCurtain";
    this.labelCurtain.Size = new Size(1052, 770);
    this.labelCurtain.TabIndex = 4;
    this.labelCurtain.Text = "Loading Data...";
    this.labelCurtain.TextAlign = ContentAlignment.MiddleCenter;
    this.imageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("imageList1.ImageStream");
    this.imageList1.TransparentColor = Color.Transparent;
    this.imageList1.Images.SetKeyName(0, "Find 1.ico");
    this.radioChipDownView.BackColor = Color.Transparent;
    this.radioChipDownView.Enabled = false;
    this.radioChipDownView.FlatStyle = FlatStyle.Flat;
    this.radioChipDownView.Location = new Point(330, 315);
    this.radioChipDownView.Name = "radioChipDownView";
    this.radioChipDownView.Size = new Size(176 /*0xB0*/, 16 /*0x10*/);
    this.radioChipDownView.TabIndex = 14;
    this.radioChipDownView.Text = "Direct Bill \"Chip-Down\" View";
    this.radioChipDownView.UseVisualStyleBackColor = false;
    this.radioChipDownView.Visible = false;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Location = new Point(0, 0);
    this.label3.Name = "label3";
    this.label3.Size = new Size(145, 16 /*0x10*/);
    this.label3.TabIndex = 0;
    this.label3.Text = "Creating \"Chip-Down\" View:";
    this.radioSummaryView.BackColor = Color.Transparent;
    this.radioSummaryView.Checked = true;
    this.radioSummaryView.Enabled = false;
    this.radioSummaryView.FlatStyle = FlatStyle.Flat;
    this.radioSummaryView.Location = new Point(90, 315);
    this.radioSummaryView.Name = "radioSummaryView";
    this.radioSummaryView.Size = new Size(96 /*0x60*/, 16 /*0x10*/);
    this.radioSummaryView.TabIndex = 12;
    this.radioSummaryView.TabStop = true;
    this.radioSummaryView.Text = "Summary View";
    this.radioSummaryView.UseVisualStyleBackColor = false;
    this.radioDetailView.BackColor = Color.Transparent;
    this.radioDetailView.Enabled = false;
    this.radioDetailView.FlatStyle = FlatStyle.Flat;
    this.radioDetailView.Location = new Point(194, 315);
    this.radioDetailView.Name = "radioDetailView";
    this.radioDetailView.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.radioDetailView.TabIndex = 13;
    this.radioDetailView.Text = "Detail View";
    this.radioDetailView.UseVisualStyleBackColor = false;
    ((Control) this.progressChipDownCreation).Location = new Point(160 /*0xA0*/, 2);
    ((Control) this.progressChipDownCreation).Name = "progressChipDownCreation";
    ((Control) this.progressChipDownCreation).Size = new Size(144 /*0x90*/, 12);
    ((Control) this.progressChipDownCreation).TabIndex = 1;
    ((Control) this.progressChipDownCreation).Text = "[Formatted]";
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(8, 4);
    this.label5.Name = "label5";
    this.label5.Size = new Size(145, 16 /*0x10*/);
    this.label5.TabIndex = 0;
    this.label5.Text = "Creating \"Chip-Down\" View:";
    ((Control) this.ultraProgressBar2).Location = new Point(160 /*0xA0*/, 8);
    ((Control) this.ultraProgressBar2).Name = "ultraProgressBar2";
    ((Control) this.ultraProgressBar2).Size = new Size(136, 12);
    ((Control) this.ultraProgressBar2).TabIndex = 1;
    ((Control) this.ultraProgressBar2).Text = "[Formatted]";
    this.toolbarReceivables.DesignerFlags = 1;
    this.toolbarReceivables.MdiMergeable = false;
    this.toolbarReceivables.ShowFullMenusDelay = 500;
    ultraToolbar3.DockedColumn = 0;
    ultraToolbar3.DockedRow = 0;
    ultraToolbar3.FloatingSize = new Size(531, 22);
    ultraToolbar3.IsMainMenuBar = true;
    ((ToolBase) buttonTool86).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool87).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool88).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool89).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool11).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar3).NonInheritedTools.AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool85,
      (ToolBase) buttonTool86,
      (ToolBase) buttonTool87,
      (ToolBase) buttonTool88,
      (ToolBase) buttonTool89,
      (ToolBase) popupMenuTool11
    });
    ultraToolbar3.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar3.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar3.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar3.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar3.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar3.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar3.Settings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance292).AlphaLevel = (short) 95;
    ((AppearanceBase) appearance292).BackColor = Color.GhostWhite;
    ((AppearanceBase) appearance292).ForeColor = Color.Black;
    ((AppearanceBase) appearance292).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance292).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance292).ImageBackgroundAlpha = (Alpha) 1;
    ((SettingsBase) ultraToolbar3.Settings).Appearance = (AppearanceBase) appearance292;
    ultraToolbar3.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar3.ShowInToolbarList = false;
    ultraToolbar3.Text = "tbReceivables";
    this.toolbarReceivables.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar3
    });
    ((ToolPropsBase) ((ToolBase) buttonTool90).SharedPropsInternal).Caption = "New Receivable";
    ((ToolPropsBase) ((ToolBase) buttonTool90).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool91).SharedPropsInternal).Caption = "Load Receivable";
    ((ToolPropsBase) ((ToolBase) buttonTool91).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool92).SharedPropsInternal).Caption = "Save Receivable";
    ((ToolPropsBase) ((ToolBase) buttonTool92).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool92).SharedPropsInternal.Visible = false;
    ((SettingsBase) popupMenuTool12.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) popupMenuTool12).SharedPropsInternal).Caption = "Receivable Options";
    ((ToolPropsBase) ((ToolBase) popupMenuTool12).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool94).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool12.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool93,
      (ToolBase) buttonTool94
    });
    ((ToolPropsBase) ((ToolBase) buttonTool95).SharedPropsInternal).Caption = "Post Receivable";
    ((ToolPropsBase) ((ToolBase) buttonTool95).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool95).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool96).SharedPropsInternal).Caption = "Clear Screen";
    ((ToolPropsBase) ((ToolBase) buttonTool96).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool97).SharedPropsInternal).Caption = "Additional Offset";
    ((ToolPropsBase) ((ToolBase) buttonTool97).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool97).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) popupMenuTool13).SharedPropsInternal).Caption = "GridContextMenu";
    ((ToolBase) buttonTool100).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool102).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool105).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool107).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool108).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool13.Tools).AddRange(new ToolBase[12]
    {
      (ToolBase) buttonTool98,
      (ToolBase) buttonTool99,
      (ToolBase) buttonTool100,
      (ToolBase) buttonTool101,
      (ToolBase) buttonTool102,
      (ToolBase) buttonTool103,
      (ToolBase) buttonTool104,
      (ToolBase) buttonTool105,
      (ToolBase) buttonTool106,
      (ToolBase) buttonTool107,
      (ToolBase) buttonTool108,
      (ToolBase) stateButtonTool8
    });
    ((PopupToolBase) popupMenuTool14).DropDownArrowStyle = (DropDownArrowStyle) 4;
    ((ToolPropsBase) ((ToolBase) popupMenuTool14).SharedPropsInternal).Caption = "Payment Options";
    ((ToolPropsBase) ((ToolBase) buttonTool109).SharedPropsInternal).Caption = "Pay In Full";
    ((ToolPropsBase) ((ToolBase) buttonTool110).SharedPropsInternal).Caption = "Pay All In Full";
    ((ToolPropsBase) ((ToolBase) buttonTool111).SharedPropsInternal).Caption = "Write-Off Receivables";
    ((ToolPropsBase) ((ToolBase) buttonTool112).SharedPropsInternal).Caption = "Clear Applied Receivable";
    ((ToolPropsBase) ((ToolBase) buttonTool113).SharedPropsInternal).Caption = "Clear All Applied Receivables";
    ((ToolPropsBase) ((ToolBase) buttonTool114).SharedPropsInternal).Caption = "Finance Company";
    ((ToolPropsBase) ((ToolBase) buttonTool115).SharedPropsInternal).Caption = "View Policy Detail";
    ((ToolPropsBase) ((ToolBase) buttonTool116).SharedPropsInternal).Caption = "Apply Un-Accounted Funds";
    ((ToolBase) buttonTool116).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool117).SharedPropsInternal).Caption = "Apply Exchange Funds";
    ((ToolBase) buttonTool117).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) stateButtonTool9).SharedPropsInternal).Caption = "Show Extended Information";
    ((ToolPropsBase) ((ToolBase) buttonTool118).SharedPropsInternal).Caption = "Write-Off Exchange";
    ((ToolPropsBase) ((ToolBase) buttonTool119).SharedPropsInternal).Caption = "Write-Off Un-Accounted";
    ((ToolPropsBase) ((ToolBase) buttonTool120).SharedPropsInternal).Caption = "Load Additional Receivables";
    ((ToolPropsBase) ((ToolBase) buttonTool120).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool120).SharedPropsInternal.Visible = false;
    ((ToolsCollectionBase) this.toolbarReceivables.Tools).AddRange(new ToolBase[22]
    {
      (ToolBase) buttonTool90,
      (ToolBase) buttonTool91,
      (ToolBase) buttonTool92,
      (ToolBase) popupMenuTool12,
      (ToolBase) buttonTool95,
      (ToolBase) buttonTool96,
      (ToolBase) buttonTool97,
      (ToolBase) popupMenuTool13,
      (ToolBase) popupMenuTool14,
      (ToolBase) buttonTool109,
      (ToolBase) buttonTool110,
      (ToolBase) buttonTool111,
      (ToolBase) buttonTool112,
      (ToolBase) buttonTool113,
      (ToolBase) buttonTool114,
      (ToolBase) buttonTool115,
      (ToolBase) buttonTool116,
      (ToolBase) buttonTool117,
      (ToolBase) stateButtonTool9,
      (ToolBase) buttonTool118,
      (ToolBase) buttonTool119,
      (ToolBase) buttonTool120
    });
    this.toolbarReceivables.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.toolbar_BeforeToolDropdown);
    this.toolbarReceivables.ToolClick += new ToolClickEventHandler(this.ToolBarClicked);
    this.daGetPayables.SelectCommand = this.cmdPayables;
    this.cmdPayables.CommandText = "spFin_GetAP";
    this.cmdPayables.CommandType = CommandType.StoredProcedure;
    this.cmdPayables.Connection = this.cnPayables;
    this.cmdPayables.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@payeeGuid", SqlDbType.UniqueIdentifier),
      new SqlParameter("@glcompanyid", SqlDbType.Int),
      new SqlParameter("@bordereau", SqlDbType.DateTime),
      new SqlParameter("@InvoiceNumber", SqlDbType.Int),
      new SqlParameter("@policyNumber", SqlDbType.NVarChar),
      new SqlParameter("@controlnumber", SqlDbType.Int),
      new SqlParameter("@filingFee", SqlDbType.DateTime)
    });
    this.cnPayables.FireInfoMessageEventOnUserErrors = false;
    this.cnReceivables.FireInfoMessageEventOnUserErrors = false;
    this.daGetReceivables.SelectCommand = this.cmdReceivables;
    this.cmdReceivables.CommandText = "spFin_GetAR";
    this.cmdReceivables.CommandType = CommandType.StoredProcedure;
    this.cmdReceivables.Connection = this.cnReceivables;
    this.cmdReceivables.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@RemitterGuid", SqlDbType.UniqueIdentifier),
      new SqlParameter("@GLCompanyId", SqlDbType.Int),
      new SqlParameter("@InvoiceNumber", SqlDbType.Int),
      new SqlParameter("@PolicyNumber", SqlDbType.NVarChar),
      new SqlParameter("@ControlNumber", SqlDbType.Int),
      new SqlParameter("@ShowZeros", SqlDbType.Bit),
      new SqlParameter("@entityGuid", SqlDbType.UniqueIdentifier)
    });
    this.daGetBankAccounts.SelectCommand = this.sqlcmdGetBankAccounts;
    this.daGetBankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccounts", new DataColumnMapping[3]
      {
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("BANKNAME", "BANKNAME"),
        new DataColumnMapping("CLOSED", "CLOSED")
      })
    });
    this.sqlcmdGetBankAccounts.CommandText = "[spFin_GetBankAccounts]";
    this.sqlcmdGetBankAccounts.CommandType = CommandType.StoredProcedure;
    this.sqlcmdGetBankAccounts.Connection = this.FormDataConnection;
    this.sqlcmdGetBankAccounts.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.AdditionalOffsetToolManager.DesignerFlags = 1;
    this.AdditionalOffsetToolManager.ShowFullMenusDelay = 500;
    ((ToolPropsBase) ((ToolBase) popupMenuTool15).SharedPropsInternal).Caption = "ContextMenu";
    ((ToolsCollectionBase) popupMenuTool15.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool121,
      (ToolBase) buttonTool122
    });
    ((ToolPropsBase) ((ToolBase) buttonTool123).SharedPropsInternal).Caption = "&Edit";
    ((ToolPropsBase) ((ToolBase) buttonTool124).SharedPropsInternal).Caption = "&Delete";
    ((ToolsCollectionBase) this.AdditionalOffsetToolManager.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool15,
      (ToolBase) buttonTool123,
      (ToolBase) buttonTool124
    });
    this.AdditionalOffsetToolManager.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.AdditionalOffsetToolManager_BeforeToolDropdown);
    this.AdditionalOffsetToolManager.ToolClick += new ToolClickEventHandler(this.AdditionalOffsetToolManager_ToolClick);
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formAdditionalOffsets_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).Name = "_formAdditionalOffsets_Toolbars_Dock_Area_Top";
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top).Size = new Size(1052, 0);
    this._formAdditionalOffsets_Toolbars_Dock_Area_Top.ToolbarsManager = this.AdditionalOffsetToolManager;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).Location = new Point(0, 770);
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).Name = "_formAdditionalOffsets_Toolbars_Dock_Area_Bottom";
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom).Size = new Size(1052, 0);
    this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.AdditionalOffsetToolManager;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formAdditionalOffsets_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).Name = "_formAdditionalOffsets_Toolbars_Dock_Area_Left";
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left).Size = new Size(0, 770);
    this._formAdditionalOffsets_Toolbars_Dock_Area_Left.ToolbarsManager = this.AdditionalOffsetToolManager;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formAdditionalOffsets_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).Location = new Point(1052, 0);
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).Name = "_formAdditionalOffsets_Toolbars_Dock_Area_Right";
    ((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right).Size = new Size(0, 770);
    this._formAdditionalOffsets_Toolbars_Dock_Area_Right.ToolbarsManager = this.AdditionalOffsetToolManager;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.LightGray;
    this.ClientSize = new Size(1052, 770);
    this.Controls.Add((Control) this.pnlContainer);
    this.Controls.Add((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formAdditionalOffsets_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formTransactionBuilder);
    this.Text = "Payable / Receivable";
    this.Load += new EventHandler(this.formTransactionBuilder_Load);
    this.Shown += new EventHandler(this.formTransactionBuilder_Shown);
    ((Control) this.tabPagePayable).ResumeLayout(false);
    this.panelToggleCheckRequested.ResumeLayout(false);
    this.panelToggleCheckRequested.PerformLayout();
    ((ISupportInitialize) this.dateTimeToggleCheckRequested).EndInit();
    ((ISupportInitialize) this.checkToggleCheckRequested).EndInit();
    ((ISupportInitialize) this.gridPayables).EndInit();
    this.dsOpenPayables.EndInit();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.pnlPayableChipDownView.ResumeLayout(false);
    this.pnlPayableChipDownView.PerformLayout();
    ((Control) this.tabPageReceivable).ResumeLayout(false);
    ((ISupportInitialize) this.gridReceivables).EndInit();
    this.dsOpenReceivables.EndInit();
    this.panelGridOptions.ResumeLayout(false);
    this.panelGridOptions.PerformLayout();
    this.pnlReceivableChipDownView.ResumeLayout(false);
    this.pnlReceivableChipDownView.PerformLayout();
    ((Control) this.tabNonPayableFees).ResumeLayout(false);
    ((ISupportInitialize) this.gridNonPayableFees).EndInit();
    ((Control) this.tabAdditonalOffsets).ResumeLayout(false);
    ((Control) this.tabAdditonalOffsets).PerformLayout();
    ((ISupportInitialize) this.checkBankCurrency).EndInit();
    ((ISupportInitialize) this.btnCancelChanges).EndInit();
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    ((ISupportInitialize) this.comboCostCenters).EndInit();
    ((ISupportInitialize) this.gridAdditionalOffsets).EndInit();
    ((Control) this.tabSummary).ResumeLayout(false);
    ((Control) this.ultraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.gridNonWorkingDeposit).EndInit();
    this.pnlContainer.ResumeLayout(false);
    ((ISupportInitialize) this.toolbar).EndInit();
    ((ISupportInitialize) this.tabTransactions).EndInit();
    ((Control) this.tabTransactions).ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    ((ISupportInitialize) this.buttonCancelAppliedUnaccounted).EndInit();
    ((ISupportInitialize) this.buttonAppliedUnaccounted).EndInit();
    ((ISupportInitialize) this.checkCreditCard).EndInit();
    ((ISupportInitialize) this.btnSearchCheckFrom).EndInit();
    ((ISupportInitialize) this.txtCheckFrom).EndInit();
    ((ISupportInitialize) this.comboUnAccountedCostCenter).EndInit();
    ((ISupportInitialize) this.txtNonPayableFees).EndInit();
    ((ISupportInitialize) this.txtPostingMemo).EndInit();
    ((ISupportInitialize) this.comboPaymentMethods).EndInit();
    ((ISupportInitialize) this.txtPayAmount).EndInit();
    ((ISupportInitialize) this.txtBalance).EndInit();
    ((ISupportInitialize) this.dateTimeCheckDate).EndInit();
    ((ISupportInitialize) this.dateTimeReceivedDate).EndInit();
    ((ISupportInitialize) this.dateTimeDepositDate).EndInit();
    ((ISupportInitialize) this.txtCheckNumber).EndInit();
    ((ISupportInitialize) this.txtCheckAmount).EndInit();
    ((ISupportInitialize) this.txtAppliedUnAccounted).EndInit();
    ((ISupportInitialize) this.txtUnAccountedBalance).EndInit();
    ((ISupportInitialize) this.comboBankAccount).EndInit();
    this.dsBankAccounts.EndInit();
    ((ISupportInitialize) this.txtEntityName).EndInit();
    ((ISupportInitialize) this.toolbarReceivables).EndInit();
    ((ISupportInitialize) this.AdditionalOffsetToolManager).EndInit();
    this.ResumeLayout(false);
  }

  void IExcelAutomation.AutomateInvoiceSearch(
    Guid entityGuid,
    int glCompanyId,
    int invoiceNumber,
    string policyNumber,
    string insuredName,
    DateTime effectiveDate,
    string userDefinedAccountNumber,
    Decimal appliedAmount,
    bool isPayable,
    string entityName,
    MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType payableSearchType,
    MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType receivableSearchType,
    formTransactionSearch.SearchTypes searchType)
  {
    this._glCompanyId = glCompanyId;
    if (Guid.Empty.Equals(this._entityGuid))
    {
      SearchCriteria searchCriteria = new SearchCriteria()
      {
        EntityGuid = entityGuid,
        SearchForGuid = entityGuid,
        PayableSearchType = payableSearchType,
        ReceivableSearchType = receivableSearchType,
        SearchForInteger = invoiceNumber,
        SearchForDate = effectiveDate,
        SearchForString = policyNumber,
        ShowZeros = false
      };
      this._showZeroReceivableInvoices = false;
      this._entityGuid = entityGuid;
      this._mainSearchOption = searchCriteria;
      this._currentSearchOption = searchCriteria;
      ((Control) this.txtEntityName).Text = entityName;
      this._searchType = searchType;
      this._isExcelAutomation = true;
      this.LoadAutomation_New();
    }
    else
    {
      SearchCriteria searchCriteria = new SearchCriteria()
      {
        EntityGuid = entityGuid,
        SearchForGuid = entityGuid,
        PayableSearchType = payableSearchType,
        ReceivableSearchType = receivableSearchType,
        SearchForInteger = invoiceNumber,
        SearchForDate = effectiveDate,
        SearchForString = policyNumber,
        ShowZeros = false
      };
      this._showZeroReceivableInvoices = false;
      this._entityGuid = entityGuid;
      this._currentSearchOption = searchCriteria;
      ((Control) this.txtEntityName).Text = entityName;
      this._searchType = searchType;
      this._isExcelAutomation = true;
      if (this.dsOpenPayables.Tables[0].Rows.Count == 0 & isPayable || this.dsOpenReceivables.Tables[0].Rows.Count == 0 && !isPayable)
      {
        if (isPayable)
          this.LoadPayables();
        else
          this.LoadReceivables();
      }
      else
        this.LoadAdditional(isPayable, false);
    }
    this.ApplyExcelValues(searchType, invoiceNumber, policyNumber, appliedAmount);
  }

  void IExcelAutomation.AutomateInvoiceSearch(
    Guid entityGuid,
    int glCompanyId,
    string entityName,
    MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType payableSearchType,
    MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType receivableSearchType,
    formTransactionSearch.SearchTypes searchType)
  {
    this._glCompanyId = glCompanyId;
    if (this._entityGuid.Equals(Guid.Empty))
    {
      SearchCriteria searchCriteria = new SearchCriteria()
      {
        EntityGuid = entityGuid,
        SearchForGuid = entityGuid,
        PayableSearchType = payableSearchType,
        ReceivableSearchType = receivableSearchType,
        ShowZeros = false
      };
      this._showZeroReceivableInvoices = false;
      this._entityGuid = entityGuid;
      this._mainSearchOption = searchCriteria;
      this._currentSearchOption = searchCriteria;
      ((Control) this.txtEntityName).Text = entityName;
      this._searchType = searchType;
      this._isExcelAutomation = true;
      this.LoadAutomation_New();
    }
    else
    {
      SearchCriteria searchCriteria = new SearchCriteria()
      {
        EntityGuid = entityGuid,
        SearchForGuid = entityGuid,
        PayableSearchType = payableSearchType,
        ReceivableSearchType = receivableSearchType,
        ShowZeros = false
      };
      this._showZeroReceivableInvoices = false;
      this._entityGuid = entityGuid;
      this._currentSearchOption = searchCriteria;
      ((Control) this.txtEntityName).Text = entityName;
      this._searchType = searchType;
      this._isExcelAutomation = true;
      this.LoadPayables();
    }
  }

  protected virtual void LoadPayables_Excel()
  {
    try
    {
      this.dsOpenPayables?.Clear();
      this.dsOpenPayables?.AcceptChanges();
      DefaultDatabase.LoadDataSet((DataSet) this.dsOpenPayables, new string[1]
      {
        "OpenPayables"
      }, CommandType.StoredProcedure, "spFin_GetAP_ExcelAutomation", 0, (CommandArgumentType) 0, new object[4]
      {
        (object) "@payeeGuid",
        (object) this._currentSearchOption.SearchForGuid,
        (object) "@glcompanyid",
        (object) this._glCompanyId
      });
      this.LoadOpenAccountsPayablesCompleted();
      this.OnImportCompleted(this._searchType);
    }
    catch (SqlException ex)
    {
      throw;
    }
  }

  void IExcelAutomation.ApplyFormSettings()
  {
    this.labelCurtain.SendToBack();
    this.LoadBankAccounts();
    this.LoadCostCenters(this.comboUnAccountedCostCenter);
    this.LoadCostCenters(this.comboCostCenters);
    if (this._searchType == formTransactionSearch.SearchTypes.Receivables)
      this.CreateDirectBillReceivableView();
    else
      this.CreateDirectBillPayableView();
  }

  public event EventHandler ImportCompleted;

  public void OnImportCompleted(formTransactionSearch.SearchTypes searchType)
  {
    EventHandler importCompleted = this.ImportCompleted;
    if (importCompleted == null)
      return;
    importCompleted((object) null, (EventArgs) new formTransactionBuilder.ImportCompletedEventArgs(searchType));
  }

  void IExcelAutomation.CheckAppliedErrors() => this.DisplayReapplyErrors();

  public virtual void LoadReceivables_ExcelBulk(
    Guid entityGuid,
    string entityName,
    int glCompanyId,
    bool appliedValues,
    DataTable excelValues,
    string policyNumberField,
    string invoiceNumberField,
    string appliedAmountField,
    bool showZeros = false)
  {
    string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("EXCEL_AR_PROCEDURENAME", "spFin_GetAR_ExcelAutomation");
    ((Control) this.txtEntityName).Text = entityName;
    this._entityGuid = entityGuid;
    this._glCompanyId = glCompanyId;
    this._searchType = formTransactionSearch.SearchTypes.Receivables;
    if (this._currentSearchOption == null)
      this._currentSearchOption = new SearchCriteria();
    this._currentSearchOption.SearchForGuid = entityGuid;
    this._currentSearchOption.PayableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.None;
    this._currentSearchOption.ReceivableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.Remitter;
    if (this._mainSearchOption == null)
      this._mainSearchOption = new SearchCriteria();
    this._mainSearchOption.EntityGuid = entityGuid;
    this._mainSearchOption.SearchForGuid = entityGuid;
    this._mainSearchOption.PayeeName = entityName;
    this._mainSearchOption.PayableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.None;
    this._mainSearchOption.ReceivableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.Remitter;
    this.dsOpenReceivables.Clear();
    this.dsOpenReceivables.AcceptChanges();
    List<object> objectList = new List<object>();
    foreach (KeyValuePair<string, DbParameter> discoverParameter in DefaultDatabase.DiscoverParameters(setting))
    {
      switch (discoverParameter.Key.ToUpper())
      {
        case "@REMITTERGUID":
        case "@ENTITYGUID":
          objectList.AddRange((IEnumerable<object>) new object[2]
          {
            (object) discoverParameter.Key,
            (object) entityGuid
          });
          continue;
        case "@GLCOMPANYID":
          objectList.AddRange((IEnumerable<object>) new object[2]
          {
            (object) discoverParameter.Key,
            (object) glCompanyId
          });
          continue;
        case "@SHOWZEROS":
          objectList.AddRange((IEnumerable<object>) new object[2]
          {
            (object) discoverParameter.Key,
            (object) showZeros
          });
          continue;
        default:
          continue;
      }
    }
    DefaultDatabase.LoadDataSet((DataSet) this.dsOpenReceivables, new string[1]
    {
      "OpenReceivables"
    }, setting, objectList.ToArray());
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadAutomation_New));
      this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadOpenAccountsReceivableCompleted));
    }
    else
    {
      this.LoadAutomation_NewBulk();
      this.LoadOpenAccountsReceivableCompleted();
    }
    string[] strArray = this.BuildMappingObject(policyNumberField, invoiceNumberField, appliedAmountField);
    if (appliedValues)
      this.ApplyDataExcelValues(excelValues, formTransactionSearch.SearchTypes.Receivables, (object[]) strArray);
    this._loadTypeIsExcel = true;
  }

  protected virtual string[] BuildMappingObject(
    string policyNumberField,
    string invoiceNumberField,
    string appliedAmountField)
  {
    List<string> stringList = new List<string>();
    if (!string.IsNullOrEmpty(policyNumberField))
    {
      stringList.Add("Policy Number");
      stringList.Add(policyNumberField);
    }
    if (!string.IsNullOrEmpty(invoiceNumberField))
    {
      stringList.Add("Invoice Number");
      stringList.Add(invoiceNumberField);
    }
    if (!string.IsNullOrEmpty(appliedAmountField))
    {
      stringList.Add("Applied Amount");
      stringList.Add(appliedAmountField);
    }
    return stringList.ToArray();
  }

  public virtual void LoadPayables_ExcelBulk(
    Guid entityGuid,
    string entityName,
    int glCompanyId,
    bool appliedValues,
    DataTable excelValues,
    string policyNumberField,
    string invoiceNumberField,
    string appliedAmountField,
    bool showZeros = false)
  {
    string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("EXCEL_AP_PROCEDURENAME", "spFin_GetAP_ExcelAutomation");
    ((Control) this.txtEntityName).Text = entityName;
    this._entityGuid = entityGuid;
    this._glCompanyId = glCompanyId;
    this._searchType = formTransactionSearch.SearchTypes.Payables;
    if (this._currentSearchOption == null)
      this._currentSearchOption = new SearchCriteria();
    this._currentSearchOption.SearchForGuid = entityGuid;
    this._currentSearchOption.PayableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Payee;
    this._currentSearchOption.ReceivableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.None;
    if (this._mainSearchOption == null)
      this._mainSearchOption = new SearchCriteria();
    this._mainSearchOption.EntityGuid = entityGuid;
    this._mainSearchOption.SearchForGuid = entityGuid;
    this._mainSearchOption.PayeeName = entityName;
    this._mainSearchOption.PayableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Payee;
    this._mainSearchOption.ReceivableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.None;
    this.dsOpenPayables.Clear();
    this.dsOpenPayables.AcceptChanges();
    List<object> objectList = new List<object>();
    foreach (KeyValuePair<string, DbParameter> discoverParameter in DefaultDatabase.DiscoverParameters(setting))
    {
      switch (discoverParameter.Key.ToUpper())
      {
        case "@PAYEEGUID":
        case "@ENTITYGUID":
          objectList.AddRange((IEnumerable<object>) new object[2]
          {
            (object) discoverParameter.Key,
            (object) entityGuid
          });
          continue;
        case "@GLCOMPANYID":
          objectList.AddRange((IEnumerable<object>) new object[2]
          {
            (object) discoverParameter.Key,
            (object) glCompanyId
          });
          continue;
        case "@SHOWZEROS":
          objectList.AddRange((IEnumerable<object>) new object[2]
          {
            (object) discoverParameter.Key,
            (object) showZeros
          });
          continue;
        default:
          continue;
      }
    }
    DefaultDatabase.LoadDataSet((DataSet) this.dsOpenPayables, new string[1]
    {
      "OpenPayables"
    }, setting, objectList.ToArray());
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadAutomation_NewBulk));
      this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadOpenAccountsPayablesCompleted));
    }
    else
    {
      this.LoadAutomation_NewBulk();
      this.LoadOpenAccountsPayablesCompleted();
    }
    string[] strArray = this.BuildMappingObject(policyNumberField, invoiceNumberField, appliedAmountField);
    if (appliedValues)
      this.ApplyDataExcelValues(excelValues, formTransactionSearch.SearchTypes.Payables, (object[]) strArray);
    this._loadTypeIsExcel = true;
  }

  protected void SetLoadAutomation()
  {
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadAutomation_NewBulk));
      this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadOpenAccountsPayablesCompleted));
    }
    else
    {
      this.LoadAutomation_NewBulk();
      this.LoadOpenAccountsPayablesCompleted();
    }
  }

  protected void SetPayablesSearchOptions(string entityName, Guid entityGuid, int glCompanyId)
  {
    ((Control) this.txtEntityName).Text = entityName;
    this._entityGuid = entityGuid;
    this._glCompanyId = glCompanyId;
    this._searchType = formTransactionSearch.SearchTypes.Payables;
    if (this._currentSearchOption == null)
      this._currentSearchOption = new SearchCriteria();
    this._currentSearchOption.SearchForGuid = entityGuid;
    this._currentSearchOption.PayableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Payee;
    this._currentSearchOption.ReceivableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.None;
    if (this._mainSearchOption == null)
      this._mainSearchOption = new SearchCriteria();
    this._mainSearchOption.EntityGuid = entityGuid;
    this._mainSearchOption.SearchForGuid = entityGuid;
    this._mainSearchOption.PayeeName = entityName;
    this._mainSearchOption.PayableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Payee;
    this._mainSearchOption.ReceivableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.None;
  }

  protected void LoadAutomation_NewBulk()
  {
    ((Control) this.tabTransactions).Show();
    this.chkReturnPremium.Enabled = false;
    this.LoadBankAccounts();
    this.LoadCostCenters(this.comboUnAccountedCostCenter);
    this.LoadCostCenters(this.comboCostCenters);
    this.SetToolBarButtonState(true);
    this.SetToolBarButtonState(this._searchType);
    this.labelCurtain.BringToFront();
    switch (this._searchType)
    {
      case formTransactionSearch.SearchTypes.Payables:
        if (!this._isLoadingSavedWorkSheet)
        {
          this.radioCashDisbursement.Checked = true;
          this.chkReturnPremium.Checked = false;
        }
        this._currentPage = formTransactionBuilder.TabPages.Payable;
        this.GetEntityUnAccountedBalance();
        if (this._currentSearchOption.PayableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Bordereau || this._currentSearchOption.PayableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.BordereauPayee)
          this.LoadNonPayableFees();
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Selected = true;
        break;
      case formTransactionSearch.SearchTypes.Receivables:
        if (!this._isLoadingSavedWorkSheet)
        {
          this.radioCashReceipt.Checked = true;
          this.chkReturnPremium.Checked = false;
        }
        this._currentPage = formTransactionBuilder.TabPages.Receivable;
        this.GetEntityUnAccountedBalance();
        ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Selected = true;
        break;
      case formTransactionSearch.SearchTypes.PayablesReceivables:
        if (!this._isLoadingSavedWorkSheet)
        {
          this.chkReturnPremium.Checked = false;
          this.chkReturnPremium.Enabled = true;
        }
        ((UltraTabControlBase) this.tabTransactions).Tabs["RECEIVABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Visible = true;
        ((UltraTabControlBase) this.tabTransactions).Tabs["PAYABLE"].Selected = true;
        break;
    }
  }

  protected virtual void LoadClaimsAutomation_NewBulk()
  {
    throw new NotImplementedException("Claims is not enabled, Please contact MGA Systems.");
  }

  protected virtual void LoadClaimsAutomation_New()
  {
    throw new NotImplementedException("Claims is not enabled, Please contact MGA Systems.");
  }

  protected virtual void SetGridSort(UltraGrid grid, string sortKey)
  {
    if (((UltraGridBase) grid).DisplayLayout.Bands[0].Columns[sortKey].SortIndicator != null && ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns[sortKey].SortIndicator != 3)
      return;
    ((UltraGridBase) grid).DisplayLayout.Bands[0].Columns[sortKey].SortIndicator = (SortIndicator) 1;
  }

  [Obsolete("This method is deprecated, please use method with object definition instead.")]
  protected virtual void ApplyExcelValues(
    formTransactionSearch.SearchTypes searchType,
    int invoiceNumber,
    string policyNumber,
    Decimal appliedAmount)
  {
    appliedAmount = Decimal.Round(appliedAmount, 2);
    UltraGrid grid = searchType == formTransactionSearch.SearchTypes.Payables ? this.gridPayables : this.gridReceivables;
    ((UltraGridBase) grid).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    if (invoiceNumber > 0)
    {
      ((UltraGridBase) grid).DisplayLayout.Bands[0].ColumnFilters[((UltraGridBase) grid).DisplayLayout.Bands[0].Columns["OfficeInvoiceNum"]].FilterConditions.Add((FilterComparisionOperator) 0, (object) invoiceNumber);
    }
    else
    {
      ((UltraGridBase) grid).DisplayLayout.Bands[0].ColumnFilters[((UltraGridBase) grid).DisplayLayout.Bands[0].Columns["PolicyNumber"]].FilterConditions.Add((FilterComparisionOperator) 0, (object) policyNumber);
      this.SetGridSort(grid, "DueDate");
    }
    string str1;
    string str2;
    if (searchType == formTransactionSearch.SearchTypes.Payables)
    {
      str1 = "net payable";
      str2 = "apapplied";
    }
    else
    {
      str1 = "netdue";
      str2 = "arapplied";
    }
    if (((UltraGridBase) grid).Rows.GetFilteredInNonGroupByRows().Length == 0)
    {
      this.LogAppliedChanges(invoiceNumber.ToString(), policyNumber.Trim());
    }
    else
    {
      foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) grid).Rows.GetFilteredInNonGroupByRows())
      {
        if (appliedAmount != 0M)
        {
          Decimal num1 = Decimal.Parse(filteredInNonGroupByRow.Cells[str1].Value.ToString(), NumberStyles.Currency);
          if (Math.Sign(num1) == Math.Sign(appliedAmount))
          {
            if (string.IsNullOrEmpty(filteredInNonGroupByRow.Cells[str2].Value.ToString()))
            {
              if (this.ValidatePayableAmountApplied(Math.Abs(appliedAmount), Math.Abs(num1)))
              {
                filteredInNonGroupByRow.Cells[str2].Value = (object) appliedAmount;
                appliedAmount = 0M;
              }
              else
              {
                filteredInNonGroupByRow.Cells[str2].Value = (object) num1;
                appliedAmount -= num1;
              }
            }
            else
            {
              Decimal num2 = (Decimal) filteredInNonGroupByRow.Cells[str2].Value;
              if (this.ValidatePayableAmountApplied(Math.Abs(appliedAmount) + Math.Abs(num2), Math.Abs(num1)))
              {
                filteredInNonGroupByRow.Cells[str2].Value = (object) appliedAmount;
                appliedAmount = 0M;
              }
              else if (!(num1 == num2))
              {
                if (Math.Abs(appliedAmount) > Math.Abs(num1) - Math.Abs(num2))
                {
                  filteredInNonGroupByRow.Cells[str2].Value = (object) (num1 - (Decimal) filteredInNonGroupByRow.Cells[str2].Value);
                  appliedAmount -= num1 - num2;
                }
                else
                {
                  filteredInNonGroupByRow.Cells[str2].Value = (object) (num2 + appliedAmount);
                  appliedAmount = 0M;
                }
              }
            }
          }
        }
        else
          break;
      }
      if (appliedAmount != 0M)
      {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append(" has an overage of ");
        stringBuilder.Append(appliedAmount.ToString("c"));
        stringBuilder.Append(" that could not be applied.");
        this.LogAppliedChanges(invoiceNumber.ToString(), policyNumber.Trim(), stringBuilder.ToString());
      }
    }
    ((UltraGridBase) grid).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
  }

  protected virtual void ApplyExcelValues(
    formTransactionSearch.SearchTypes searchType,
    formTransactionBuilder.ExcelImportType excelImportType,
    formTransactionBuilder.ColumnFilterNames gridFilterColumn,
    params object[] excelValuesObject)
  {
    string columnFilterName = string.Empty;
    int num1 = ((IEnumerable<object>) excelValuesObject).Count<object>();
    bool flag = num1 % 2 == 0;
    Dictionary<string, Decimal> dictionary = new Dictionary<string, Decimal>();
    for (int index = 0; index < num1; ++index)
    {
      string key = (string) excelValuesObject[index];
      Decimal num2 = flag || index + 1 <= num1 ? (Decimal) excelValuesObject[++index] : 0M;
      dictionary.Add(key, num2);
    }
    // ISSUE: explicit non-virtual call
    if (dictionary != null && __nonvirtual (dictionary.Count) == 0)
      return;
    UltraGrid grid;
    string balanceColumnName;
    string appliedColumnName;
    if (excelImportType != formTransactionBuilder.ExcelImportType.Accounting)
    {
      if (excelImportType != formTransactionBuilder.ExcelImportType.Claims)
        throw new Exception("Account Excel Import: The import you are trying is not for Accounting or Claims!");
      if (searchType == formTransactionSearch.SearchTypes.Payables)
      {
        grid = this.GridClaimAPImport;
        balanceColumnName = "Balance";
        appliedColumnName = "AP Applied";
      }
      else
      {
        grid = this.GridClaimARImport;
        balanceColumnName = "Balance";
        appliedColumnName = "ClaimARApplied";
      }
    }
    else if (searchType == formTransactionSearch.SearchTypes.Payables)
    {
      grid = this.gridPayables;
      balanceColumnName = "net payable";
      appliedColumnName = "apapplied";
    }
    else
    {
      grid = this.gridReceivables;
      balanceColumnName = "netdue";
      appliedColumnName = "arapplied";
    }
    switch (gridFilterColumn)
    {
      case formTransactionBuilder.ColumnFilterNames.PolicyNumber:
        columnFilterName = "PolicyNumber";
        break;
      case formTransactionBuilder.ColumnFilterNames.OfficeInvoiceNum:
        columnFilterName = "OfficeInvoiceNum";
        break;
      case formTransactionBuilder.ColumnFilterNames.ClaimNumber:
        columnFilterName = "ClaimNumber";
        break;
    }
    Dictionary<string, IEnumerable<UltraGridRow>> mappedGrid = this.GetMappedGrid(grid, columnFilterName);
    foreach (KeyValuePair<string, Decimal> keyValuePair in dictionary)
    {
      string key = keyValuePair.Key;
      Decimal appliedAmount = keyValuePair.Value;
      if (!string.IsNullOrEmpty(key))
      {
        IEnumerable<UltraGridRow> ultraGridRows;
        if (!mappedGrid.TryGetValue(key, out ultraGridRows))
        {
          string message = "The system was unable to find any matches between the Excel file and IMS data. Please check the Excel Sheet.";
          this.LogAppliedChanges(excelImportType, gridFilterColumn, message, (object) key);
          break;
        }
        foreach (UltraGridRow row in ultraGridRows)
        {
          if (appliedAmount != 0M)
            appliedAmount = this.UpdateMatchedRowsWithAppliedAmount(row, balanceColumnName, appliedColumnName, appliedAmount);
          else
            break;
        }
        if (appliedAmount != 0M)
        {
          StringBuilder stringBuilder = new StringBuilder();
          stringBuilder.Append(" has an overage of ");
          stringBuilder.Append(appliedAmount.ToString("c"));
          stringBuilder.Append(" that could not be applied.");
          this.LogAppliedChanges(excelImportType, gridFilterColumn, stringBuilder.ToString(), (object) key);
        }
        ((UltraGridBase) grid).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
      }
    }
  }

  protected virtual void ClearMappedGrid()
  {
    this._mappedGrid = (Dictionary<string, IEnumerable<UltraGridRow>>) null;
  }

  private bool HasMappedGrid() => this._mappedGrid != null;

  protected Dictionary<string, IEnumerable<UltraGridRow>> GetMappedGrid(
    UltraGrid grid,
    string columnFilterName)
  {
    if (this.HasMappedGrid())
      return this._mappedGrid;
    this._mappedGrid = formTransactionBuilder.CreateMappedGrid(grid, columnFilterName);
    return this._mappedGrid;
  }

  private static Dictionary<string, IEnumerable<UltraGridRow>> CreateMappedGrid(
    UltraGrid grid,
    string columnFilterName)
  {
    ((UltraGridBase) grid).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    return ((IEnumerable<UltraGridRow>) ((UltraGridBase) grid).Rows.GetFilteredInNonGroupByRows()).GroupBy<UltraGridRow, string>((System.Func<UltraGridRow, string>) (row => row.Cells[columnFilterName].Value.ToString())).ToDictionary<IGrouping<string, UltraGridRow>, string, IEnumerable<UltraGridRow>>((System.Func<IGrouping<string, UltraGridRow>, string>) (x => x.Key), (System.Func<IGrouping<string, UltraGridRow>, IEnumerable<UltraGridRow>>) (x => (IEnumerable<UltraGridRow>) x));
  }

  protected virtual void ApplyDataExcelValues(
    DataTable excelValues,
    formTransactionSearch.SearchTypes searchType,
    params object[] mappingObject)
  {
    Dictionary<string, string> mappingDictionary = this.GetExcelMappingDictionary(mappingObject);
    if (mappingDictionary == null || mappingDictionary.Count == 0)
      return;
    this.ClearMappedGrid();
    if (mappingDictionary.ContainsKey("Invoice Number") && !mappingDictionary.ContainsKey("Policy Number"))
    {
      formTransactionBuilder.ColumnFilterNames columnFilterNames = formTransactionBuilder.ColumnFilterNames.OfficeInvoiceNum;
      formTransactionBuilder.ExcelImportType excelImportType = formTransactionBuilder.ExcelImportType.Accounting;
      foreach (DataRow row in (InternalDataCollectionBase) excelValues.Rows)
      {
        object obj1 = row[mappingDictionary["Applied Amount"]];
        object obj2 = row[mappingDictionary["Invoice Number"]];
        if (obj2 != DBNull.Value || obj1 != DBNull.Value)
        {
          Decimal result;
          if (!Decimal.TryParse(obj1.ToString(), out result))
          {
            this.LogAppliedChanges(excelImportType, columnFilterNames, "The invoice is missing the applied amount in the excel sheet.", (object) obj2.ToString());
          }
          else
          {
            object[] excelValuesObj;
            if ((!(result == 0M) || obj2 != DBNull.Value) && this.CreateExcelValuesObject(obj2.ToString(), result, mappingDictionary, row, excelImportType, columnFilterNames, out excelValuesObj))
              this.ApplyExcelValues(searchType, excelImportType, columnFilterNames, excelValuesObj);
          }
        }
      }
    }
    else if (mappingDictionary.ContainsKey("Policy Number") && !mappingDictionary.ContainsKey("Invoice Number"))
    {
      formTransactionBuilder.ColumnFilterNames columnFilterNames = formTransactionBuilder.ColumnFilterNames.PolicyNumber;
      formTransactionBuilder.ExcelImportType excelImportType = formTransactionBuilder.ExcelImportType.Accounting;
      foreach (DataRow row in (InternalDataCollectionBase) excelValues.Rows)
      {
        object obj3 = row[mappingDictionary["Applied Amount"]];
        object obj4 = row[mappingDictionary["Policy Number"]];
        if (obj4 != DBNull.Value || obj3 != DBNull.Value)
        {
          Decimal result;
          if (!Decimal.TryParse(obj3.ToString(), out result))
          {
            this.LogAppliedChanges(excelImportType, columnFilterNames, "The policy is missing the applied amount in the excel sheet.", (object) obj4.ToString());
          }
          else
          {
            object[] excelValuesObj;
            if ((!(result == 0M) || obj4 != DBNull.Value) && this.CreateExcelValuesObject(obj4.ToString(), result, mappingDictionary, row, excelImportType, columnFilterNames, out excelValuesObj))
              this.ApplyExcelValues(searchType, excelImportType, columnFilterNames, excelValuesObj);
          }
        }
      }
    }
    else if (mappingDictionary.ContainsKey("Invoice Number") && mappingDictionary.ContainsKey("Policy Number"))
    {
      formTransactionBuilder.ColumnFilterNames columnFilter = formTransactionBuilder.ColumnFilterNames.OfficeInvoiceNum;
      formTransactionBuilder.ExcelImportType importType = formTransactionBuilder.ExcelImportType.Accounting;
      foreach (DataRow row in (InternalDataCollectionBase) excelValues.Rows)
      {
        object obj5 = row[mappingDictionary["Applied Amount"]];
        object obj6 = row[mappingDictionary["Policy Number"]];
        object obj7 = row[mappingDictionary["Invoice Number"]];
        if (obj6 != DBNull.Value || obj5 != DBNull.Value || obj7 != DBNull.Value)
        {
          int result1;
          if (!int.TryParse(obj7.ToString(), out result1))
          {
            this.LogAppliedChanges(importType, columnFilter, "The invoice number format is not valid. When importing by both invoice and policy number, the invoice number must be numeric.", (object) obj7.ToString(), (object) obj6.ToString());
          }
          else
          {
            Decimal result2;
            if (!Decimal.TryParse(obj5.ToString(), out result2))
              this.LogAppliedChanges(importType, columnFilter, "The invoice/policy is missing the applied amount in the excel sheet.", (object) obj7.ToString(), (object) obj6.ToString());
            else if (!(result2 == 0M) || obj6 != DBNull.Value)
              this.ApplyExcelValues(searchType, result1, obj6.ToString(), result2);
          }
        }
      }
    }
    else
    {
      if (!mappingDictionary.ContainsKey("Claims Number"))
        return;
      formTransactionBuilder.ColumnFilterNames columnFilterNames = formTransactionBuilder.ColumnFilterNames.ClaimNumber;
      formTransactionBuilder.ExcelImportType excelImportType = formTransactionBuilder.ExcelImportType.Claims;
      foreach (DataRow row in (InternalDataCollectionBase) excelValues.Rows)
      {
        object obj8 = row[mappingDictionary["Applied Amount"]];
        object obj9 = row[mappingDictionary["Claims Number"]];
        if (obj9 != DBNull.Value || obj8 != DBNull.Value)
        {
          Decimal result;
          if (!Decimal.TryParse(obj8.ToString(), out result))
          {
            this.LogAppliedChanges(excelImportType, columnFilterNames, "The claim is missing the applied amount in the excel sheet.", (object) obj9.ToString());
          }
          else
          {
            object[] excelValuesObj;
            if ((!(result == 0M) || obj9 != DBNull.Value) && this.CreateExcelValuesObject(obj9.ToString(), result, mappingDictionary, row, excelImportType, columnFilterNames, out excelValuesObj))
              this.ApplyExcelValues(searchType, excelImportType, columnFilterNames, excelValuesObj);
          }
        }
      }
    }
  }

  protected virtual bool CreateExcelValuesObject(
    string key,
    Decimal appliedAmount,
    Dictionary<string, string> excelMappingDict,
    DataRow dr,
    formTransactionBuilder.ExcelImportType importType,
    formTransactionBuilder.ColumnFilterNames gridFilterColumn,
    out object[] excelValuesObj)
  {
    excelValuesObj = new object[2]
    {
      (object) key,
      (object) appliedAmount
    };
    return true;
  }

  [Obsolete("This method is deprecated, please use method with object definition instead.")]
  protected virtual void ApplyDataExcelValues(
    DataTable excelValues,
    string policyNumberField,
    string invoiceNumberField,
    string appliedAmountField,
    formTransactionSearch.SearchTypes searchType)
  {
    foreach (DataRow row in (InternalDataCollectionBase) excelValues.Rows)
    {
      if (!string.IsNullOrEmpty(policyNumberField) && !string.IsNullOrEmpty(appliedAmountField) && string.IsNullOrEmpty(invoiceNumberField))
        this.ApplyExcelValues(searchType, 0, row[policyNumberField].ToString(), Decimal.Parse(row[appliedAmountField].ToString()));
      if (!string.IsNullOrEmpty(invoiceNumberField) && !string.IsNullOrEmpty(appliedAmountField) && string.IsNullOrEmpty(policyNumberField))
        this.ApplyExcelValues(searchType, int.Parse(row[invoiceNumberField].ToString()), string.Empty, Decimal.Parse(row[appliedAmountField].ToString()));
      if (!string.IsNullOrEmpty(invoiceNumberField) && !string.IsNullOrEmpty(appliedAmountField) && !string.IsNullOrEmpty(policyNumberField))
        this.ApplyExcelValues(searchType, int.Parse(row[invoiceNumberField].ToString()), row[policyNumberField].ToString(), Decimal.Parse(row[appliedAmountField].ToString()));
    }
  }

  protected virtual Decimal UpdateMatchedRowsWithAppliedAmount(
    UltraGridRow row,
    string balanceColumnName,
    string appliedColumnName,
    Decimal appliedAmount)
  {
    try
    {
      this.gridReceivables.BeforeCellUpdate -= new BeforeCellUpdateEventHandler(this.gridReceivables_BeforeCellUpdate);
      this.gridPayables.BeforeCellUpdate -= new BeforeCellUpdateEventHandler(this.gridPayables_BeforeCellUpdate);
      Decimal result;
      if (!Decimal.TryParse(row.Cells[balanceColumnName].Value.ToString(), NumberStyles.Currency, (IFormatProvider) CultureInfo.CurrentCulture, out result) || Math.Sign(result) != Math.Sign(appliedAmount))
        return appliedAmount;
      Decimal num1 = result * 100M % 1M == 0M ? Decimal.Round(appliedAmount, 2) : appliedAmount;
      Decimal num2 = 0M;
      if (row.Cells[appliedColumnName]?.Value != null && row.Cells[appliedColumnName].Value != DBNull.Value)
        num2 = (Decimal) row.Cells[appliedColumnName].Value;
      if (this.ValidatePayableAmountApplied(Math.Abs(num1) + Math.Abs(num2), Math.Abs(result)))
      {
        row.Cells[appliedColumnName].Value = (object) (num1 + num2);
        return 0M;
      }
      if (result == num2)
        return appliedAmount;
      if (Math.Abs(num1) > Math.Abs(result) - Math.Abs(num2))
      {
        row.Cells[appliedColumnName].Value = (object) result;
        return appliedAmount - result + num2;
      }
      row.Cells[appliedColumnName].Value = (object) (num2 + num1);
      return 0M;
    }
    finally
    {
      row.Update();
      this.gridReceivables.BeforeCellUpdate += new BeforeCellUpdateEventHandler(this.gridReceivables_BeforeCellUpdate);
      this.gridPayables.BeforeCellUpdate += new BeforeCellUpdateEventHandler(this.gridPayables_BeforeCellUpdate);
    }
  }

  private InsuranceWorksheet CreateSavableWorksheet_Bulk()
  {
    InsuranceWorksheet savableWorksheetBulk = new InsuranceWorksheet()
    {
      GlCompanyId = this._glCompanyId,
      PostingMemo = ((Control) this.txtPostingMemo).Text,
      UnAccountedBalance = ((Control) this.txtUnAccountedBalance).Text == string.Empty ? 0.0M : Decimal.Parse(((Control) this.txtUnAccountedBalance).Text, NumberStyles.Currency),
      AppliedUnAccounted = ((Control) this.txtAppliedUnAccounted).Text == string.Empty ? 0.0M : Decimal.Parse(((Control) this.txtAppliedUnAccounted).Text, NumberStyles.Currency),
      entityGuid = this._entityGuid,
      entityName = ((Control) this.txtEntityName).Text
    };
    switch (this._searchType)
    {
      case formTransactionSearch.SearchTypes.Payables:
        savableWorksheetBulk.payableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Excel;
        break;
      case formTransactionSearch.SearchTypes.Receivables:
        savableWorksheetBulk.receivableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.Excel;
        break;
    }
    if (((UltraDropDownBase) this.comboBankAccount).SelectedRow != null)
      savableWorksheetBulk.glAcctId = int.Parse(this.comboBankAccount.Value.ToString());
    if (this.radioCashDisbursement.Checked)
    {
      savableWorksheetBulk.IsCashDisbursement = true;
      savableWorksheetBulk.CheckDate = this.dateTimeCheckDate.DateTime;
      if (!this.PaymentMethodComboNeedsSelection())
        savableWorksheetBulk.PaymentMethod = this.GetCharTransactionPaymentMethod();
      if (((Control) this.txtPayAmount).Text != string.Empty)
        savableWorksheetBulk.TotalAmount = Decimal.Parse(((Control) this.txtPayAmount).Text, NumberStyles.Any);
    }
    else
    {
      savableWorksheetBulk.IsCashDisbursement = false;
      savableWorksheetBulk.CheckNumber = ((Control) this.txtCheckNumber).Text;
      savableWorksheetBulk.DepositDate = this.dateTimeDepositDate.DateTime;
      savableWorksheetBulk.ReceivedDate = this.dateTimeReceivedDate.DateTime;
      if (((Control) this.txtCheckAmount).Text != string.Empty)
        savableWorksheetBulk.CheckAmount = Decimal.Parse(((Control) this.txtCheckAmount).Text, NumberStyles.Any);
      if (((Control) this.txtBalance).Text != string.Empty)
        savableWorksheetBulk.TotalAmount = Decimal.Parse(((Control) this.txtBalance).Text, NumberStyles.Any);
      if (((Control) this.txtCheckFrom).Text != string.Empty)
      {
        savableWorksheetBulk.ReceivedFromGuid = new Guid(((Control) this.txtCheckFrom).Tag.ToString());
        savableWorksheetBulk.ReceivedFromName = ((Control) this.txtCheckFrom).Text;
      }
    }
    savableWorksheetBulk.IsReturnPremium = this.chkReturnPremium.Checked;
    this.PayableGridValues?.CopyTo(savableWorksheetBulk.payableGridValues);
    this.ReceivableGridValues?.CopyTo(savableWorksheetBulk.receivableGridValues);
    savableWorksheetBulk.SearchCriteria = this.AdditionalSearchOptions;
    this.InterCompanyTransfers?.CopyTo(savableWorksheetBulk.interCompanyTransfers);
    savableWorksheetBulk.searchType = this._searchType;
    return savableWorksheetBulk;
  }

  private void SaveWorkSheet_Bulk()
  {
    using (formSaveWorksheet form = (formSaveWorksheet) ObjectFactory.Instance.CreateForm(typeof (formSaveWorksheet), new object[2]
    {
      (object) formSaveWorksheet.WorksheetType.PayableReceivable,
      (object) this.CreateSavableWorksheet_Bulk()
    }))
    {
      this.Cursor = Cursors.WaitCursor;
      form.Owner = (Form) this;
      form.IsBulk = true;
      form.dataImportXML = this.dataImportXML;
      int num = (int) form.ShowDialog();
      this.Cursor = Cursors.Default;
    }
  }

  private void LoadWorksheet_Bulk(object worksheet, int worksheetId)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.Clear();
      this._isMassiveUpdate = true;
      this.ApplySavedWorkSheetValues_Bulk((InsuranceWorksheet) worksheet, worksheetId);
      this.ReLoad_Bulk();
      this.ReapplyGridValues();
      this._isMassiveUpdate = false;
      if (this.InterCompanyTransfers.Count != 0)
      {
        ((UltraTabControlBase) this.tabTransactions).Tabs["ADDITIONALOFFSETS"].Visible = true;
        ((UltraGridBase) this.gridAdditionalOffsets).DataSource = (object) this.InterCompanyTransfers;
        if (this.InterCompanyTransfers.Count != 0)
        {
          ((UltraGridBase) this.gridAdditionalOffsets).DisplayLayout.Bands[0].Summaries.Clear();
          this.AddgridAdditionalOffsetsSummaries();
        }
      }
      this.LoadCostCenters(this.comboUnAccountedCostCenter);
      this.LoadCostCenters(this.comboCostCenters);
      this.dropTreeGLAccounts.LoadGLAccounts(this._glCompanyId);
      this.OnLoadWorksheetCompleted(worksheetId);
      this.CalculateAndDisplayTotal();
      CurrentUser.Instance.LogAction("Loaded saved AR/AP worksheet.", "Accounting Logs");
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void ApplySavedWorkSheetValues_Bulk(InsuranceWorksheet worksheet, int workSheetId)
  {
    this.chkReturnPremium.Checked = worksheet.IsReturnPremium;
    ((Control) this.txtAppliedUnAccounted).Text = worksheet.appliedUnAccounted.ToString("C");
    ((Control) this.txtUnAccountedBalance).Text = worksheet.unAccountedBalance.ToString("C");
    ((Control) this.txtEntityName).Text = worksheet.EntityName;
    this.LoadWorksheetSetExcelDataSettings(workSheetId);
    this._mainSearchOption = new SearchCriteria();
    if (worksheet.payableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Excel)
      this._mainSearchOption.PayableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Excel;
    this._mainSearchOption.PayeeName = worksheet.EntityName;
    if (worksheet.receivableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.Excel)
      this._mainSearchOption.ReceivableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.Excel;
    this._mainSearchOption.SearchForDate = worksheet.searchDate;
    this._mainSearchOption.SearchForGuid = worksheet.EntityGuid;
    this._mainSearchOption.SearchForInteger = worksheet.searchInteger;
    this._mainSearchOption.SearchForString = worksheet.searchString;
    this._glCompanyId = worksheet.GlCompanyId;
    this._payableGridValues = worksheet.payableGridValues;
    this._receivableGridValues = worksheet.receivableGridValues;
    this._additionalSearchOptions = worksheet.SearchCriteria;
    this._currentSearchOption = this._mainSearchOption;
    this._searchType = worksheet.searchType;
    this._interCompanyTransfers = worksheet.interCompanyTransfers;
    this._entityGuid = worksheet.EntityGuid;
    this.LoadBankAccounts();
    this.LoadCostCenters(this.comboUnAccountedCostCenter);
    this.LoadCostCenters(this.comboCostCenters);
    this.comboBankAccount.Value = (object) worksheet.glAcctId;
    if (worksheet.IsCashDisbursement)
    {
      this.radioCashDisbursement.Checked = true;
      this.dateTimeCheckDate.DateTime = worksheet.CheckDate;
      ((Control) this.txtPayAmount).Text = worksheet.TotalAmount.ToString("C");
      this.SetComboPaymentMethod(worksheet.PaymentMethod);
    }
    else
    {
      this.radioCashReceipt.Checked = true;
      ((Control) this.txtCheckAmount).Text = worksheet.CheckAmount.ToString("C");
      ((Control) this.txtCheckNumber).Text = worksheet.CheckNumber;
      this.dateTimeDepositDate.DateTime = worksheet.DepositDate;
      this.dateTimeReceivedDate.DateTime = worksheet.ReceivedDate;
      ((Control) this.txtPayAmount).Text = worksheet.TotalAmount.ToString("C");
      if (!(worksheet.ReceivedFromName != string.Empty))
        return;
      ((Control) this.txtCheckFrom).Text = worksheet.ReceivedFromName;
      ((Control) this.txtCheckFrom).Tag = (object) worksheet.ReceivedFromGuid;
    }
  }

  private void LoadWorksheetSetExcelDataSettings(int worksheetId)
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM tblFin_AccountingWorksheet_BULK WHERE EntryId = @WorksheetId", new object[2]
    {
      (object) "@workSheetId",
      (object) worksheetId
    });
    this._isExcelAutomation = true;
    this.dataImportXML = dataTable.Rows[0]["ImportXML"].ToString();
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "TRUNCATE TABLE tblFin_ExcelImport");
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        connection.Open();
        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(connection))
        {
          sqlBulkCopy.DestinationTableName = "tblFin_ExcelImport";
          sqlBulkCopy.WriteToServer(MGASystems.IMS.Accounting.Core.ClassObjects.Utility.XMLToDataTable(this.dataImportXML));
        }
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void ReLoad_Bulk()
  {
    if (!this._isLoadingSavedWorkSheet)
      this.Clear();
    if (this._isRefreshing)
    {
      this.LoadBankAccounts();
      this.LoadCostCenters(this.comboCostCenters);
      this.LoadCostCenters(this.comboUnAccountedCostCenter);
    }
    this._currentSearchOption = this._mainSearchOption;
    this._currentSearchOption.EntityGuid = new Guid("6AC83463-B29F-4BC2-903A-1F77C36E0749");
    this._isLoadingAdditionalPayables = false;
    this._isLoadingAdditionalReceivables = false;
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      if (this._currentSearchOption.PayableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.Excel)
        this.LoadPayables_ExcelBulk(this._currentSearchOption.EntityGuid, this._currentSearchOption.PayeeName, this._glCompanyId, false, (DataTable) null, string.Empty, string.Empty, string.Empty);
      else if (this._currentSearchOption.ReceivableSearchType == MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.Excel)
        this.LoadReceivables_ExcelBulk(this._currentSearchOption.EntityGuid, this._currentSearchOption.PayeeName, this._glCompanyId, false, (DataTable) null, string.Empty, string.Empty, string.Empty);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
    SearchCriteriaCollection criteriaCollection = new SearchCriteriaCollection();
    if (!this._isRefreshing && !this._isLoadingSavedWorkSheet)
      return;
    this.labelCurtain.SendToBack();
  }

  protected string PostAPExcel()
  {
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("POSTBULK_AP") || !(((UltraGridBase) this.gridPayables).DataSource is DataSet dataSource))
      return string.Empty;
    string str = Guid.NewGuid().ToString().Replace("-", string.Empty);
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append("APBulkPost_");
    stringBuilder.Append(str);
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, MGASystems.Data.Utility.CreateBulkInsertTable(stringBuilder.ToString(), dataSource.Tables[0]));
    DefaultDatabase.ExecuteBulkInsert(new int?(300), dataSource.Tables[0], (SqlRowsCopiedEventHandler) null, SqlBulkCopyOptions.TableLock, stringBuilder.ToString());
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"DELETE FROM {stringBuilder} WHERE apApplied is null or apApplied = 0");
    return stringBuilder.ToString();
  }

  public virtual void LoadReceivablesClaims_ExcelBulk(
    Guid entityGuid,
    string entityName,
    int glCompanyId,
    bool appliedValues,
    DataTable excelValues,
    string claimsNumberField,
    string appliedAmountField)
  {
    string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("EXCEL_CLAIMSAR_PROCEDURENAME", "spClaims_GetClaimAR_ExcelAutomation");
    ((Control) this.txtEntityName).Text = entityName;
    this._entityGuid = entityGuid;
    this._glCompanyId = glCompanyId;
    this._searchType = formTransactionSearch.SearchTypes.Receivables;
    if (this._currentSearchOption == null)
      this._currentSearchOption = new SearchCriteria();
    this._currentSearchOption.SearchForGuid = entityGuid;
    this._currentSearchOption.PayableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.None;
    this._currentSearchOption.ReceivableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.Remitter;
    if (this._mainSearchOption == null)
      this._mainSearchOption = new SearchCriteria();
    this._mainSearchOption.EntityGuid = entityGuid;
    this._mainSearchOption.SearchForGuid = entityGuid;
    this._mainSearchOption.PayeeName = entityName;
    this._mainSearchOption.PayableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.PayablesSearchType.None;
    this._mainSearchOption.ReceivableSearchType = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.ReceivablesSearchType.Remitter;
    this.dsOpenReceivables.Clear();
    this.dsOpenReceivables.AcceptChanges();
    DefaultDatabase.LoadDataSet(this.DSClaimAR, new string[1]
    {
      "ClaimsAR"
    }, setting, new object[4]
    {
      (object) "@entityGuid",
      (object) entityGuid,
      (object) "@glcompanyid",
      (object) glCompanyId
    });
    if (this.InvokeRequired)
    {
      this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadAutomation_New));
      this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadOpenAccountsReceivableCompleted));
      this.Invoke((Delegate) new formTransactionBuilder.LoadDataCompletedHandler(this.LoadClaimsAutomation_New));
    }
    else
    {
      this.LoadAutomation_NewBulk();
      this.LoadOpenAccountsReceivableCompleted();
      this.LoadClaimsAutomation_NewBulk();
    }
    if (appliedValues)
      this.ApplyDataExcelValues(excelValues, formTransactionSearch.SearchTypes.Receivables, (object) "Claims Number", (object) claimsNumberField, (object) "Applied Amount", (object) appliedAmountField);
    this._loadTypeIsExcel = true;
  }

  protected Dictionary<string, string> GetExcelMappingDictionary(params object[] mappingObject)
  {
    Dictionary<string, string> mappingDictionary = new Dictionary<string, string>();
    int num = ((IEnumerable<object>) mappingObject).Count<object>();
    bool flag = num % 2 == 0;
    for (int index = 0; index < num; ++index)
    {
      string key = (string) mappingObject[index];
      string str = flag || index + 1 <= num ? (string) mappingObject[++index] : (string) null;
      mappingDictionary.Add(key, str);
    }
    return mappingDictionary;
  }

  protected void LoadNonWorkingDeposit()
  {
    DataTable dt = (DataTable) null;
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((_param1, _param2) => dt = DefaultDatabase.ExecuteDataTable("spFin_GetOpenDepositPremium", new object[4]
      {
        (object) "@glcompanyid",
        (object) this._glCompanyId,
        (object) "@remitterGuid",
        (object) this._entityGuid
      }));
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((_param1, _param2) =>
      {
        ((UltraTabControlBase) this.tabTransactions).Tabs["NWD"].Visible = dt.Rows.Count > 0;
        if (dt.Rows.Count <= 0)
          return;
        ((UltraGridBase) this.gridNonWorkingDeposit).DataSource = (object) dt;
        this.FormatNonWorkingDepositGrid();
      });
      this.DisplayWorkingDepositAppliedOnTab();
      ((UltraGridBase) this.gridNonWorkingDeposit).DataSource = (object) null;
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void FormatNonWorkingDepositGrid()
  {
    UltraGridBand band = ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Bands[0];
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("RemitterGuid"))
      band.Columns["RemitterGuid"].Hidden = true;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("invoiceNum"))
      band.Columns["invoiceNum"].Hidden = true;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("glacctid"))
      band.Columns["glacctid"].Hidden = true;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("chargecode"))
      band.Columns["chargecode"].Hidden = true;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("companylineguid"))
      band.Columns["companylineguid"].Hidden = true;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("costcenterid"))
      band.Columns["costcenterid"].Hidden = true;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("AvailableDepositBalance"))
    {
      band.Columns["AvailableDepositBalance"].Format = "c";
      band.Columns["AvailableDepositBalance"].CellAppearance.TextHAlign = (HAlign) 3;
      ((HeaderBase) band.Columns["AvailableDepositBalance"].Header).Appearance.TextHAlign = (HAlign) 3;
      band.Columns["AvailableDepositBalance"].CellActivation = (Activation) 3;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("DepositBilled"))
    {
      band.Columns["DepositBilled"].Format = "c";
      band.Columns["DepositBilled"].CellAppearance.TextHAlign = (HAlign) 3;
      ((HeaderBase) band.Columns["DepositBilled"].Header).Appearance.TextHAlign = (HAlign) 3;
      band.Columns["DepositBilled"].CellActivation = (Activation) 3;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("DepositRcvd"))
    {
      band.Columns["DepositRcvd"].Format = "c";
      band.Columns["DepositRcvd"].CellAppearance.TextHAlign = (HAlign) 3;
      ((HeaderBase) band.Columns["DepositRcvd"].Header).Appearance.TextHAlign = (HAlign) 3;
      band.Columns["DepositRcvd"].CellActivation = (Activation) 3;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("DepositUsed"))
    {
      band.Columns["DepositUsed"].Format = "c";
      band.Columns["DepositUsed"].CellAppearance.TextHAlign = (HAlign) 3;
      ((HeaderBase) band.Columns["DepositUsed"].Header).Appearance.TextHAlign = (HAlign) 3;
      band.Columns["DepositUsed"].CellActivation = (Activation) 3;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("Control Number"))
    {
      band.Columns["Control Number"].CellAppearance.TextHAlign = (HAlign) 1;
      ((HeaderBase) band.Columns["Control Number"].Header).Appearance.TextHAlign = (HAlign) 1;
      band.Columns["Control Number"].Width = 50;
      band.Columns["Control Number"].CellActivation = (Activation) 3;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("Invoice Number"))
    {
      band.Columns["Invoice Number"].CellAppearance.TextHAlign = (HAlign) 1;
      ((HeaderBase) band.Columns["Invoice Number"].Header).Appearance.TextHAlign = (HAlign) 1;
      band.Columns["Invoice Number"].Width = 50;
      band.Columns["Invoice Number"].CellActivation = (Activation) 3;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("Insured"))
    {
      band.Columns["Insured"].CellAppearance.TextHAlign = (HAlign) 1;
      ((HeaderBase) band.Columns["Insured"].Header).Appearance.TextHAlign = (HAlign) 1;
      band.Columns["Insured"].CellActivation = (Activation) 3;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("Policy Number"))
    {
      band.Columns["Policy Number"].CellAppearance.TextHAlign = (HAlign) 1;
      ((HeaderBase) band.Columns["Policy Number"].Header).Appearance.TextHAlign = (HAlign) 1;
      band.Columns["Policy Number"].CellActivation = (Activation) 3;
    }
    if (!((KeyedSubObjectsCollectionBase) band.Columns).Exists("AppliedNonWorkingDeposit"))
    {
      band.Columns.Add("AppliedNonWorkingDeposit", "Deposit Applied");
      band.Columns["AppliedNonWorkingDeposit"].DataType = typeof (Decimal);
      band.Columns["AppliedNonWorkingDeposit"].Format = "c";
      band.Columns["AppliedNonWorkingDeposit"].CellAppearance.TextHAlign = (HAlign) 3;
      ((HeaderBase) band.Columns["AppliedNonWorkingDeposit"].Header).Appearance.TextHAlign = (HAlign) 3;
      band.Columns["AppliedNonWorkingDeposit"].CellAppearance.BackColor = Color.LightSteelBlue;
      band.Columns["AppliedNonWorkingDeposit"].Style = (ColumnStyle) 2;
      band.Columns["AppliedNonWorkingDeposit"].ButtonDisplayStyle = (ButtonDisplayStyle) 0;
      band.Columns["AppliedNonWorkingDeposit"].CellButtonAppearance.Image = (object) Resources.arrow_switch;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("AvailableDepositBalance") && !((KeyedSubObjectsCollectionBase) band.Summaries).Exists("sumdepbal"))
    {
      band.Summaries.Add("sumdepbal", (SummaryType) 1, band.Columns["AvailableDepositBalance"], (SummaryPosition) 3);
      band.Summaries["sumdepbal"].DisplayFormat = "{0:c}";
      band.Summaries["sumdepbal"].Appearance.BackColor = Color.LightSteelBlue;
      band.Summaries["sumdepbal"].Appearance.TextHAlign = (HAlign) 3;
      band.Summaries["sumdepbal"].Appearance.FontData.Bold = (DefaultableBoolean) 1;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("DepositUsed") && !((KeyedSubObjectsCollectionBase) band.Summaries).Exists("sumdepused"))
    {
      band.Summaries.Add("sumdepused", (SummaryType) 1, band.Columns["DepositUsed"], (SummaryPosition) 3);
      band.Summaries["sumdepused"].DisplayFormat = "{0:c}";
      band.Summaries["sumdepused"].Appearance.BackColor = Color.LightSteelBlue;
      band.Summaries["sumdepused"].Appearance.TextHAlign = (HAlign) 3;
      band.Summaries["sumdepused"].Appearance.FontData.Bold = (DefaultableBoolean) 1;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("DepositRcvd") && !((KeyedSubObjectsCollectionBase) band.Summaries).Exists("sumdeprcvd"))
    {
      band.Summaries.Add("sumdeprcvd", (SummaryType) 1, band.Columns["DepositRcvd"], (SummaryPosition) 3);
      band.Summaries["sumdeprcvd"].DisplayFormat = "{0:c}";
      band.Summaries["sumdeprcvd"].Appearance.BackColor = Color.LightSteelBlue;
      band.Summaries["sumdeprcvd"].Appearance.TextHAlign = (HAlign) 3;
      band.Summaries["sumdeprcvd"].Appearance.FontData.Bold = (DefaultableBoolean) 1;
    }
    if (!((KeyedSubObjectsCollectionBase) band.Columns).Exists("AppliedNonWorkingDeposit") || ((KeyedSubObjectsCollectionBase) band.Summaries).Exists("sumapplieddepbal"))
      return;
    band.Summaries.Add("sumapplieddepbal", (SummaryType) 1, band.Columns["AppliedNonWorkingDeposit"], (SummaryPosition) 3);
    band.Summaries["sumapplieddepbal"].DisplayFormat = "{0:c}";
    band.Summaries["sumapplieddepbal"].Appearance.BackColor = Color.LightSteelBlue;
    band.Summaries["sumapplieddepbal"].Appearance.TextHAlign = (HAlign) 3;
    band.Summaries["sumapplieddepbal"].Appearance.FontData.Bold = (DefaultableBoolean) 1;
  }

  private void gridNonWorkingDeposit_ClickCellButton(object sender, CellEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "AppliedNonWorkingDeposit"))
      return;
    e.Cell.Value = e.Cell.Row.Cells["AvailableDepositBalance"].Value;
    this.CalculateAndDisplayTotal();
  }

  private Decimal WorkingDepositApplied()
  {
    Decimal num = 0M;
    if (((UltraTabControlBase) this.tabTransactions).Tabs["NWD"].Visible && ((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Bands[0].Summaries).Exists("sumapplieddepbal"))
      num = Decimal.Parse(((UltraGridBase) this.gridNonWorkingDeposit).Rows.SummaryValues["sumapplieddepbal"].Value.ToString());
    this.DisplayWorkingDepositAppliedOnTab();
    return num;
  }

  private void DisplayWorkingDepositAppliedOnTab()
  {
    Decimal num = 0M;
    if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Bands[0].Summaries).Exists("sumapplieddepbal"))
      num = Decimal.Parse(((UltraGridBase) this.gridNonWorkingDeposit).Rows.SummaryValues["sumapplieddepbal"].Value.ToString());
    if (num == 0M)
      ((UltraTabControlBase) this.tabTransactions).Tabs["NWD"].Text = "Working Deposit";
    else
      ((UltraTabControlBase) this.tabTransactions).Tabs["NWD"].Text = $"Working Deposit - {num.ToString("c")}";
  }

  private void AddPostAppliedWorkingDepositDetailsToTransaction(InsuranceTransaction trans)
  {
    if (this.WorkingDepositApplied() == 0M)
      return;
    int glAccountId1 = int.Parse(this.comboBankAccount.Value.ToString());
    UltraGridBand band = ((UltraGridBase) this.gridNonWorkingDeposit).DisplayLayout.Bands[0];
    band.ColumnFilters.ClearAllFilters();
    band.ColumnFilters["AppliedNonWorkingDeposit"].FilterConditions.Add((FilterComparisionOperator) 1, (object) 0);
    band.ColumnFilters["AppliedNonWorkingDeposit"].FilterConditions.Add((FilterComparisionOperator) 1, (object) DBNull.Value);
    foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridNonWorkingDeposit).Rows.GetFilteredInNonGroupByRows())
    {
      int invoiceNumber = (int) filteredInNonGroupByRow.Cells["invoicenum"].Value;
      int chargeCode = (int) filteredInNonGroupByRow.Cells["chargeCode"].Value;
      int glAccountId2 = (int) filteredInNonGroupByRow.Cells["glacctid"].Value;
      int costCenterId = (int) filteredInNonGroupByRow.Cells["costCenterId"].Value;
      Guid companyLineGuid = new Guid(filteredInNonGroupByRow.Cells["companyLineGuid"].Value.ToString());
      Guid remitterGuid = new Guid(filteredInNonGroupByRow.Cells["remitterGuid"].Value.ToString());
      Decimal num = (Decimal) filteredInNonGroupByRow.Cells["AppliedNonWorkingDeposit"].Value;
      CostCenterAllocationCollection withAllocation = CostCenterAllocationCollection.CreateWithAllocation(costCenterId, num);
      if (num < 0M)
      {
        trans.Credits.Add(formTransactionBuilder.CreatePostAppliedWorkingDepositTransactionDetail(withAllocation, invoiceNumber, chargeCode, companyLineGuid, remitterGuid, glAccountId2, num));
        trans.Debits.Add(formTransactionBuilder.CreatePostAppliedWorkingDepositTransactionDetail(withAllocation, invoiceNumber, chargeCode, companyLineGuid, remitterGuid, glAccountId1, num));
      }
      else
      {
        trans.Debits.Add(formTransactionBuilder.CreatePostAppliedWorkingDepositTransactionDetail(withAllocation, invoiceNumber, chargeCode, companyLineGuid, remitterGuid, glAccountId2, num));
        trans.Credits.Add(formTransactionBuilder.CreatePostAppliedWorkingDepositTransactionDetail(withAllocation, invoiceNumber, chargeCode, companyLineGuid, remitterGuid, glAccountId1, num));
      }
    }
  }

  private static TransactionDetail CreatePostAppliedWorkingDepositTransactionDetail(
    CostCenterAllocationCollection cca,
    int invoiceNumber,
    int chargeCode,
    Guid companyLineGuid,
    Guid remitterGuid,
    int glAccountId,
    Decimal appliedNonWorkingDeposit)
  {
    return new TransactionDetail(invoiceNumber, chargeCode, 0, 0, 0, 0, glAccountId, companyLineGuid, remitterGuid, Math.Abs(appliedNonWorkingDeposit), remitterGuid, cca);
  }

  private void gridNonWorkingDeposit_AfterCellUpdate(object sender, CellEventArgs e)
  {
    this.DisplayWorkingDepositAppliedOnTab();
    this.CalculateAndDisplayTotal();
  }

  protected enum ValidateCashReceiptRule
  {
    Balance,
    CheckAmount,
    CheckNumber,
    DepositDate,
    Entity,
    ReceivedDate,
  }

  protected enum TabPages : byte
  {
    Payable,
    Receivable,
    PayableAndReceivable,
  }

  protected delegate void ResetGridValuesCollectionCompletedHandler();

  protected delegate void CreateDirectBillViewCompletedHandler();

  protected delegate void ShowChipDownProgressHandler();

  protected delegate void UpdateStatusHandler(string message);

  protected delegate void LoadDataCompletedHandler();

  private delegate void PayableTabUiUpdateHandler(bool bold, string text);

  private delegate void SqlThreadExceptionHandler(SqlException sqlX);

  private delegate void ReceivableTabUiUpdateHandler(bool bold, string text);

  private delegate void LoadNonPayableFeesCompletedHandler(dsNonPayableFees dataNonPayableFees);

  private delegate void NonUIExceptionThrownHandler(Exception exceptionObject);

  public delegate void LoadWorksheetCompletedHandler(int worksheetId);

  private class TransactionCanceledException : Exception
  {
  }

  protected delegate void InsuranceTransactionCreatedDelegate(InsuranceTransaction insTransaction);

  public delegate void ReceivableGridClickCellButtonDelegate(object sender, CellEventArgs e);

  public delegate void AppliedUnAccountedConfirmedDelegate(string checkNumber);

  public delegate void AfterPostPartialPayListReadyHandler(ArrayList partialPayList);

  public delegate void AfterCancelPayHandler(ArrayList afterCancelPay);

  public static class ArApGridColumnKeys
  {
    public static string AmountReceived = "amtrcvd";
    public static string InvoiceNumber = "InvoiceNum";
    public static string ChargeCode = nameof (ChargeCode);
    public static string PayeeGuid = nameof (PayeeGuid);
    public static string CompanyLineGuid = nameof (CompanyLineGuid);
    public static string ControlNum = "QuoteControlNum";
    public static string ControlNumber = "QuoteControlNumber";
    public static string Exgl = "EXGL";
    public static string Apgl = "APGL";
    public static string Argl = "ARGL";
    public static string Uagl = "UAGL";
    public static string CostCenterId = nameof (CostCenterId);
    public static string MgaPercentRate = "MGAPercentRate";
    public static string PayeePercentRate = nameof (PayeePercentRate);
    public static string AccountNumber = nameof (AccountNumber);
    public static string CheckRequested = nameof (CheckRequested);
    public static string ArApplied = "ARApplied";
    public static string ApApplied = "APApplied";
    public static string FinanceCompanyGuid = nameof (FinanceCompanyGuid);
    public static string QuoteId = nameof (QuoteId);
    public static string RemitterGuid = nameof (RemitterGuid);
    public static string PolicyNumber = nameof (PolicyNumber);
    public static string OfficeInvoiceNumber = nameof (OfficeInvoiceNumber);
    public static string OfficeInvoiceNum = nameof (OfficeInvoiceNum);
    public static string Amount = nameof (Amount);
    public static string TransactionType = nameof (TransactionType);
    public static string GlAccountShortName = nameof (GlAccountShortName);
    public static string CostCenterName = nameof (CostCenterName);
    public static string GlAccountId = nameof (GlAccountId);
    public static string Comments = nameof (Comments);
    public static string SetTransactionType = nameof (SetTransactionType);
    public static string GrossBilled = "Gross Billed";
    public static string CarrierCommission = nameof (CarrierCommission);
    public static string GrossPayable = "gross payable";
    public static string NetPayable = "Net Payable";
    public static string PropAmount = "propamt";
    public static string AmountPtd = "AmtPtd";
    public static string Amount_Received = "Amt Rcvd";
    public static string AmountBilled = "Amtbilled";
    public static string NetDue = nameof (NetDue);
    public static string ExchApplied = nameof (ExchApplied);
    public static string UnaccountedForApplied = "UnacctApplied";
    public static string CurrentStatus = nameof (CurrentStatus);
    public static string AmountReturned = "amtrtd";
    public static string ExchBalance = "exchbalance";
    public static string UnaccountedForBalance = "unacctbalance";
    public static string AmountPtc = "amtptc";
    public static string CurrencyCode = nameof (CurrencyCode);
    public static string GeneralLedgerAccountId = "glacctid";
    public static string PayMethodId = "PayMethodID";
    public static string IsSelected = nameof (IsSelected);
    public static string InsuredName = nameof (InsuredName);
    public static string PostDate = "Post Date";
  }

  public enum ExcelImportType
  {
    Accounting,
    Claims,
  }

  public enum ColumnFilterNames
  {
    PolicyNumber,
    OfficeInvoiceNum,
    ClaimNumber,
    Both,
  }

  public class ImportCompletedEventArgs : EventArgs
  {
    public ImportCompletedEventArgs(formTransactionSearch.SearchTypes searchType)
    {
      this.SearchType = searchType;
    }

    public formTransactionSearch.SearchTypes SearchType { get; private set; }
  }
}
