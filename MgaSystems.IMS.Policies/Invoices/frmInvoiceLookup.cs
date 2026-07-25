// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Invoices.frmInvoiceLookup
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports.Export.Pdf.Section;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTree;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.InsuredsProducersCompanies;
using MGASystems.IMS.NoteDocuments.Email;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Invoices;

[SecureResource("{A9DE0B71-3010-4e2a-A96D-658C42CC12DD}", "Invoice Issued", "Give the user the ability to modify the issued date from the invoice lookup screen.", "Invoices")]
public class frmInvoiceLookup : Form
{
  private IContainer components;
  private ErrorProvider err;
  private ContextMenu cmRightClick;
  private Label lblInvoiceNumber;
  private Label lblInvoiceNumberRange;
  private Label lblInvoiceNumberRangeTo;
  private Label lblQuoteControlNumber;
  private Label lblQuoteControlNumberRange;
  private Label lblQuoteControlNumberRangeTo;
  private Label lblInvoiceBetweenAnd;
  private Label lblInsured;
  private Label lblProducerLocation;
  private Label lblUnderwriter;
  private MGASimpleComboBox cboUnderwriter;
  private DbCommand DbSelectCommand1;
  private MGATextBox txtInsured;
  private MGATextBox txtProducer;
  private ToolTip tt;
  private MGASimpleComboBox cboOffice;
  private Label lblOffice;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private MGATextBox txtPolicyNumber;
  private Label lblPolicyNumber;
  private MGADateTimePicker dtpPrintDateTo;
  private MGADateTimePicker dtpPrintDateFrom;
  private Label Label4;
  private Label Label5;
  public const string changeIssuedGuid = "{A9DE0B71-3010-4e2a-A96D-658C42CC12DD}";
  protected int _recordCount;
  private const int _numberOfRecordsToShow = 100;
  private int _currentStartingRecord;
  private Guid _insuredLocationGuid;
  private Guid _producerLocationGuid;
  private ArrayList _invoiceNumbersToPrint;
  private bool _clickedRow;
  private Guid _companyLocationGuid;
  private int selectCommandTimeout;
  private MemoryStream _gridLayout;

  public frmInvoiceLookup()
  {
    this.Load += new EventHandler(this.frmInvoiceLookup_Load);
    this._currentStartingRecord = 1;
    this._insuredLocationGuid = Guid.Empty;
    this._producerLocationGuid = Guid.Empty;
    this._invoiceNumbersToPrint = new ArrayList();
    this._companyLocationGuid = Guid.Empty;
    this.selectCommandTimeout = 30;
    this._gridLayout = new MemoryStream();
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private virtual MenuItem cmViewInvoice
  {
    get => this._cmViewInvoice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmViewInvoice_Click);
      MenuItem cmViewInvoice1 = this._cmViewInvoice;
      if (cmViewInvoice1 != null)
        cmViewInvoice1.Click -= eventHandler;
      this._cmViewInvoice = value;
      MenuItem cmViewInvoice2 = this._cmViewInvoice;
      if (cmViewInvoice2 == null)
        return;
      cmViewInvoice2.Click += eventHandler;
    }
  }

  private virtual MenuItem cmPrintInvoice
  {
    get => this._cmPrintInvoice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmPrintInvoice_Click);
      MenuItem cmPrintInvoice1 = this._cmPrintInvoice;
      if (cmPrintInvoice1 != null)
        cmPrintInvoice1.Click -= eventHandler;
      this._cmPrintInvoice = value;
      MenuItem cmPrintInvoice2 = this._cmPrintInvoice;
      if (cmPrintInvoice2 == null)
        return;
      cmPrintInvoice2.Click += eventHandler;
    }
  }

  private virtual MenuItem cmEmailInvoice
  {
    get => this._cmEmailInvoice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmEmailInvoice_Click);
      MenuItem cmEmailInvoice1 = this._cmEmailInvoice;
      if (cmEmailInvoice1 != null)
        cmEmailInvoice1.Click -= eventHandler;
      this._cmEmailInvoice = value;
      MenuItem cmEmailInvoice2 = this._cmEmailInvoice;
      if (cmEmailInvoice2 == null)
        return;
      cmEmailInvoice2.Click += eventHandler;
    }
  }

  protected virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
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

  [field: AccessedThroughProperty("gbSearchCriteria")]
  protected virtual MGAGroupBox gbSearchCriteria { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid ugInvoices
  {
    get => this._ugInvoices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.ugInvoices_AfterRowActivate);
      EventHandler eventHandler2 = new EventHandler(this.ugInvoices_DoubleClick);
      MouseEventHandler mouseEventHandler1 = new MouseEventHandler(this.ugInvoices_MouseDown);
      MouseEventHandler mouseEventHandler2 = new MouseEventHandler(this.ugInvoices_MouseUp);
      UltraGrid ugInvoices1 = this._ugInvoices;
      if (ugInvoices1 != null)
      {
        ugInvoices1.AfterRowActivate -= eventHandler1;
        ((Control) ugInvoices1).DoubleClick -= eventHandler2;
        ((Control) ugInvoices1).MouseDown -= mouseEventHandler1;
        ((Control) ugInvoices1).MouseUp -= mouseEventHandler2;
      }
      this._ugInvoices = value;
      UltraGrid ugInvoices2 = this._ugInvoices;
      if (ugInvoices2 == null)
        return;
      ugInvoices2.AfterRowActivate += eventHandler1;
      ((Control) ugInvoices2).DoubleClick += eventHandler2;
      ((Control) ugInvoices2).MouseDown += mouseEventHandler1;
      ((Control) ugInvoices2).MouseUp += mouseEventHandler2;
    }
  }

  [field: AccessedThroughProperty("lblStatus")]
  protected virtual Label lblStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnPrev
  {
    get => this._btnPrev;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrev_Click);
      MGAButton btnPrev1 = this._btnPrev;
      if (btnPrev1 != null)
        ((Control) btnPrev1).Click -= eventHandler;
      this._btnPrev = value;
      MGAButton btnPrev2 = this._btnPrev;
      if (btnPrev2 == null)
        return;
      ((Control) btnPrev2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnNext
  {
    get => this._btnNext;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnNext_Click);
      MGAButton btnNext1 = this._btnNext;
      if (btnNext1 != null)
        ((Control) btnNext1).Click -= eventHandler;
      this._btnNext = value;
      MGAButton btnNext2 = this._btnNext;
      if (btnNext2 == null)
        return;
      ((Control) btnNext2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnLast
  {
    get => this._btnLast;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnLast_Click);
      MGAButton btnLast1 = this._btnLast;
      if (btnLast1 != null)
        ((Control) btnLast1).Click -= eventHandler;
      this._btnLast = value;
      MGAButton btnLast2 = this._btnLast;
      if (btnLast2 == null)
        return;
      ((Control) btnLast2).Click += eventHandler;
    }
  }

  private virtual MGAButton btnFirst
  {
    get => this._btnFirst;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnFirst_Click);
      MGAButton btnFirst1 = this._btnFirst;
      if (btnFirst1 != null)
        ((Control) btnFirst1).Click -= eventHandler;
      this._btnFirst = value;
      MGAButton btnFirst2 = this._btnFirst;
      if (btnFirst2 == null)
        return;
      ((Control) btnFirst2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gbPrintOptions")]
  protected virtual MGAGroupBox gbPrintOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInvoiceNumber")]
  private virtual MGATextBox txtInvoiceNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtQuoteControlNumber")]
  private virtual MGATextBox txtQuoteControlNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInvoiceNumberFrom")]
  private virtual MGATextBox txtInvoiceNumberFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtInvoiceNumberTo")]
  private virtual MGATextBox txtInvoiceNumberTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtQuoteControlNumberFrom")]
  private virtual MGATextBox txtQuoteControlNumberFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtQuoteControlNumberTo")]
  private virtual MGATextBox txtQuoteControlNumberTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpInvoiceTo")]
  private virtual MGADateTimePicker dtpInvoiceTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkShowVoids")]
  private virtual MGACheckBox chkShowVoids { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpInvoiceFrom")]
  private virtual MGADateTimePicker dtpInvoiceFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkInsured
  {
    get => this._lnkInsured;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkInsured_LinkClicked);
      LinkLabel lnkInsured1 = this._lnkInsured;
      if (lnkInsured1 != null)
        lnkInsured1.LinkClicked -= clickedEventHandler;
      this._lnkInsured = value;
      LinkLabel lnkInsured2 = this._lnkInsured;
      if (lnkInsured2 == null)
        return;
      lnkInsured2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkProducer
  {
    get => this._lnkProducer;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkProducer_LinkClicked);
      LinkLabel lnkProducer1 = this._lnkProducer;
      if (lnkProducer1 != null)
        lnkProducer1.LinkClicked -= clickedEventHandler;
      this._lnkProducer = value;
      LinkLabel lnkProducer2 = this._lnkProducer;
      if (lnkProducer2 == null)
        return;
      lnkProducer2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual MGAButton btnReset
  {
    get => this._btnReset;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnReset_Click);
      MGAButton btnReset1 = this._btnReset;
      if (btnReset1 != null)
        ((Control) btnReset1).Click -= eventHandler;
      this._btnReset = value;
      MGAButton btnReset2 = this._btnReset;
      if (btnReset2 == null)
        return;
      ((Control) btnReset2).Click += eventHandler;
    }
  }

  private virtual MenuItem mnuViewPolicy
  {
    get => this._mnuViewPolicy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuViewPolicy_Click);
      MenuItem mnuViewPolicy1 = this._mnuViewPolicy;
      if (mnuViewPolicy1 != null)
        mnuViewPolicy1.Click -= eventHandler;
      this._mnuViewPolicy = value;
      MenuItem mnuViewPolicy2 = this._mnuViewPolicy;
      if (mnuViewPolicy2 == null)
        return;
      mnuViewPolicy2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkShowInstallments")]
  protected virtual MGACheckBox chkShowInstallments { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDueDateTo")]
  private virtual MGADateTimePicker dtpDueDateTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpDueDateFrom")]
  private virtual MGADateTimePicker dtpDueDateFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_dsInvoices")]
  private virtual dsInvoiceSearchResults _dsInvoices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbBoth")]
  protected virtual RadioButton rbBoth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblPrintOptionsLine")]
  protected virtual Label lblPrintOptionsLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbBrokerCopy")]
  protected virtual RadioButton rbBrokerCopy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbMGACopy")]
  protected virtual RadioButton rbMGACopy { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnPrintSelectedInvoices
  {
    get => this._btnPrintSelectedInvoices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintSelectedInvoices_Click);
      MGAButton selectedInvoices1 = this._btnPrintSelectedInvoices;
      if (selectedInvoices1 != null)
        ((Control) selectedInvoices1).Click -= eventHandler;
      this._btnPrintSelectedInvoices = value;
      MGAButton selectedInvoices2 = this._btnPrintSelectedInvoices;
      if (selectedInvoices2 == null)
        return;
      ((Control) selectedInvoices2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnPrintAllReturnedInvoices
  {
    get => this._btnPrintAllReturnedInvoices;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintAllReturnedInvoices_Click);
      MGAButton returnedInvoices1 = this._btnPrintAllReturnedInvoices;
      if (returnedInvoices1 != null)
        ((Control) returnedInvoices1).Click -= eventHandler;
      this._btnPrintAllReturnedInvoices = value;
      MGAButton returnedInvoices2 = this._btnPrintAllReturnedInvoices;
      if (returnedInvoices2 == null)
        return;
      ((Control) returnedInvoices2).Click += eventHandler;
    }
  }

  private virtual MenuItem cmChangeDateIssued
  {
    get => this._cmChangeDateIssued;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cmChangeDateIssued_Click);
      MenuItem changeDateIssued1 = this._cmChangeDateIssued;
      if (changeDateIssued1 != null)
        changeDateIssued1.Click -= eventHandler;
      this._cmChangeDateIssued = value;
      MenuItem changeDateIssued2 = this._cmChangeDateIssued;
      if (changeDateIssued2 == null)
        return;
      changeDateIssued2.Click += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraTreeNode ultraTreeNode1 = new UltraTreeNode();
    UltraTreeNode ultraTreeNode2 = new UltraTreeNode();
    UltraTreeNode ultraTreeNode3 = new UltraTreeNode();
    UltraTreeNode ultraTreeNode4 = new UltraTreeNode();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    DropDownEditorButton downEditorButton = new DropDownEditorButton();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmInvoiceLookup));
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("InvoiceLookup", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("RecordNumber");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("OfficeInvoiceNumber");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("SystemInvoiceNumber");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("InvoiceDate");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("DatePrinted");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("QuoteControlNum");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Insured");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Producer");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Company");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Failed");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("DueDate");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Print");
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.treeDcuFolders = new UltraTree();
    this.err = new ErrorProvider(this.components);
    this.cmRightClick = new ContextMenu();
    this.cmViewInvoice = new MenuItem();
    this.cmPrintInvoice = new MenuItem();
    this.cmEmailInvoice = new MenuItem();
    this.mnuViewPolicy = new MenuItem();
    this.cmChangeDateIssued = new MenuItem();
    this.btnSearch = new MGAButton();
    this.chkShowVoids = new MGACheckBox();
    this.chkShowInstallments = new MGACheckBox();
    this.gbPrintOptions = new MGAGroupBox();
    this.pnlDocFolders = new Panel();
    this.Label8 = new Label();
    this.textEdDocFolders = new UltraTextEditor();
    this.rbBoth = new RadioButton();
    this.rbBrokerCopy = new RadioButton();
    this.rbMGACopy = new RadioButton();
    this.lblPrintOptionsLine = new Label();
    this.gbSearchCriteria = new MGAGroupBox();
    this.cboLine = new MGASimpleComboBox();
    this.lblLine = new Label();
    this.chkHideFutureInvoices = new MGACheckBox();
    this.lnkCompany = new LinkLabel();
    this.txtCompany = new MGATextBox();
    this.Label7 = new Label();
    this.dtpPrintDateTo = new MGADateTimePicker();
    this.dtpPrintDateFrom = new MGADateTimePicker();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.txtPolicyNumber = new MGATextBox();
    this.lblPolicyNumber = new Label();
    this.dtpDueDateTo = new MGADateTimePicker();
    this.dtpDueDateFrom = new MGADateTimePicker();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.cboOffice = new MGASimpleComboBox();
    this.lnkProducer = new LinkLabel();
    this.lnkInsured = new LinkLabel();
    this.txtProducer = new MGATextBox();
    this.txtInsured = new MGATextBox();
    this.lblOffice = new Label();
    this.dtpInvoiceTo = new MGADateTimePicker();
    this.dtpInvoiceFrom = new MGADateTimePicker();
    this.txtQuoteControlNumberTo = new MGATextBox();
    this.txtQuoteControlNumberFrom = new MGATextBox();
    this.txtInvoiceNumberTo = new MGATextBox();
    this.txtInvoiceNumberFrom = new MGATextBox();
    this.cboUnderwriter = new MGASimpleComboBox();
    this.txtQuoteControlNumber = new MGATextBox();
    this.txtInvoiceNumber = new MGATextBox();
    this.lblUnderwriter = new Label();
    this.lblProducerLocation = new Label();
    this.lblInsured = new Label();
    this.lblInvoiceBetweenAnd = new Label();
    this.lblQuoteControlNumberRangeTo = new Label();
    this.lblQuoteControlNumberRange = new Label();
    this.lblQuoteControlNumber = new Label();
    this.lblInvoiceNumberRangeTo = new Label();
    this.lblInvoiceNumberRange = new Label();
    this.lblInvoiceNumber = new Label();
    this.Label1 = new Label();
    this.lblStatus = new Label();
    this.btnPrev = new MGAButton();
    this.btnNext = new MGAButton();
    this.btnLast = new MGAButton();
    this.btnFirst = new MGAButton();
    this._da = DefaultDatabase.CreateDataAdapter();
    this.DbSelectCommand1 = DefaultDatabase.CreateCommand();
    this.btnReset = new MGAButton();
    this.tt = new ToolTip(this.components);
    this.btnPrintSelectedInvoices = new MGAButton();
    this.btnPrintAllReturnedInvoices = new MGAButton();
    this.btnEmailAll = new MGAButton();
    this.btnPrintToPdf = new MGAButton();
    this.panelPleaseWait = new UltraGroupBox();
    this.Label6 = new Label();
    this.PictureBox1 = new PictureBox();
    this.FolderBrowserDialog1 = new FolderBrowserDialog();
    this.ugInvoices = new UltraGrid();
    this._dsInvoices = new dsInvoiceSearchResults();
    ((ISupportInitialize) this.treeDcuFolders).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.chkShowVoids).BeginInit();
    ((ISupportInitialize) this.chkShowInstallments).BeginInit();
    ((ISupportInitialize) this.gbPrintOptions).BeginInit();
    ((Control) this.gbPrintOptions).SuspendLayout();
    this.pnlDocFolders.SuspendLayout();
    ((ISupportInitialize) this.textEdDocFolders).BeginInit();
    ((ISupportInitialize) this.gbSearchCriteria).BeginInit();
    ((Control) this.gbSearchCriteria).SuspendLayout();
    ((ISupportInitialize) this.cboLine).BeginInit();
    ((ISupportInitialize) this.chkHideFutureInvoices).BeginInit();
    ((ISupportInitialize) this.txtCompany).BeginInit();
    ((ISupportInitialize) this.dtpPrintDateTo).BeginInit();
    ((ISupportInitialize) this.dtpPrintDateFrom).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    ((ISupportInitialize) this.dtpDueDateTo).BeginInit();
    ((ISupportInitialize) this.dtpDueDateFrom).BeginInit();
    ((ISupportInitialize) this.cboOffice).BeginInit();
    ((ISupportInitialize) this.txtProducer).BeginInit();
    ((ISupportInitialize) this.txtInsured).BeginInit();
    ((ISupportInitialize) this.dtpInvoiceTo).BeginInit();
    ((ISupportInitialize) this.dtpInvoiceFrom).BeginInit();
    ((ISupportInitialize) this.txtQuoteControlNumberTo).BeginInit();
    ((ISupportInitialize) this.txtQuoteControlNumberFrom).BeginInit();
    ((ISupportInitialize) this.txtInvoiceNumberTo).BeginInit();
    ((ISupportInitialize) this.txtInvoiceNumberFrom).BeginInit();
    ((ISupportInitialize) this.cboUnderwriter).BeginInit();
    ((ISupportInitialize) this.txtQuoteControlNumber).BeginInit();
    ((ISupportInitialize) this.txtInvoiceNumber).BeginInit();
    ((ISupportInitialize) this.btnPrev).BeginInit();
    ((ISupportInitialize) this.btnNext).BeginInit();
    ((ISupportInitialize) this.btnLast).BeginInit();
    ((ISupportInitialize) this.btnFirst).BeginInit();
    ((ISupportInitialize) this.btnReset).BeginInit();
    ((ISupportInitialize) this.btnPrintSelectedInvoices).BeginInit();
    ((ISupportInitialize) this.btnPrintAllReturnedInvoices).BeginInit();
    ((ISupportInitialize) this.btnEmailAll).BeginInit();
    ((ISupportInitialize) this.btnPrintToPdf).BeginInit();
    ((ISupportInitialize) this.panelPleaseWait).BeginInit();
    ((Control) this.panelPleaseWait).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.ugInvoices).BeginInit();
    this._dsInvoices.BeginInit();
    this.SuspendLayout();
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    this.treeDcuFolders.Appearance = (AppearanceBase) appearance1;
    this.treeDcuFolders.BorderStyle = (UIElementBorderStyle) 9;
    this.treeDcuFolders.DisplayStyle = (UltraTreeDisplayStyle) 1;
    this.treeDcuFolders.ImageTransparentColor = Color.Transparent;
    ((Control) this.treeDcuFolders).Location = new Point(3, 52);
    ((Control) this.treeDcuFolders).Name = "treeDcuFolders";
    this.treeDcuFolders.NodeConnectorColor = SystemColors.ControlDark;
    this.treeDcuFolders.NodeConnectorStyle = (NodeConnectorStyle) 2;
    ultraTreeNode1.Text = "Node0";
    ultraTreeNode3.Text = "Node2";
    ultraTreeNode4.Text = "Node3";
    ultraTreeNode2.Nodes.AddRange(new UltraTreeNode[2]
    {
      ultraTreeNode3,
      ultraTreeNode4
    });
    ultraTreeNode2.Text = "Node1";
    this.treeDcuFolders.Nodes.AddRange(new UltraTreeNode[2]
    {
      ultraTreeNode1,
      ultraTreeNode2
    });
    this.treeDcuFolders.Scrollable = (Scrollbar) 4;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 6;
    this.treeDcuFolders.ScrollBarLook = scrollBarLook1;
    ((Control) this.treeDcuFolders).Size = new Size(136, 130);
    ((Control) this.treeDcuFolders).TabIndex = 54;
    ((Control) this.treeDcuFolders).Visible = false;
    this.err.ContainerControl = (ContainerControl) this;
    this.cmRightClick.MenuItems.AddRange(new MenuItem[5]
    {
      this.cmViewInvoice,
      this.cmPrintInvoice,
      this.cmEmailInvoice,
      this.mnuViewPolicy,
      this.cmChangeDateIssued
    });
    this.cmViewInvoice.Index = 0;
    this.cmViewInvoice.Text = "View Invoice";
    this.cmPrintInvoice.Index = 1;
    this.cmPrintInvoice.Text = "Print Invoice";
    this.cmEmailInvoice.Index = 2;
    this.cmEmailInvoice.Text = "E-mail Invoice";
    this.mnuViewPolicy.Index = 3;
    this.mnuViewPolicy.Text = "View Policy";
    this.cmChangeDateIssued.Enabled = false;
    this.cmChangeDateIssued.Index = 4;
    this.cmChangeDateIssued.Text = "Change Date Issued";
    appearance2.BackColor = Color.Gainsboro;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(469, 250);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 4;
    this.tt.SetToolTip((Control) this.btnSearch, "Search");
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkShowVoids).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkShowVoids).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkShowVoids).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkShowVoids).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkShowVoids).Location = new Point(13, 400);
    ((Control) this.chkShowVoids).Name = "chkShowVoids";
    ((Control) this.chkShowVoids).Size = new Size(86, 14);
    ((Control) this.chkShowVoids).TabIndex = 14;
    ((UltraToggleEditorBase) this.chkShowVoids).Text = "Show Voids";
    ((UltraControlBase) this.chkShowVoids).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkShowVoids).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.Gray;
    appearance4.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkShowInstallments).Appearance = (AppearanceBase) appearance4;
    ((UltraToggleEditorBase) this.chkShowInstallments).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkShowInstallments).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkShowInstallments).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkShowInstallments).Location = new Point(14, 105);
    ((Control) this.chkShowInstallments).Name = "chkShowInstallments";
    ((Control) this.chkShowInstallments).Size = new Size(126, 14);
    ((Control) this.chkShowInstallments).TabIndex = 3;
    ((UltraToggleEditorBase) this.chkShowInstallments).Text = "Show Installments";
    ((UltraControlBase) this.chkShowInstallments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkShowInstallments).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.gbPrintOptions).Appearance = (AppearanceBase) appearance5;
    ((UltraGroupBox) this.gbPrintOptions).BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance6.BackColor = Color.FromArgb(239, 247, 253);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.gbPrintOptions).ContentAreaAppearance = (AppearanceBase) appearance6;
    ((Control) this.gbPrintOptions).Controls.Add((Control) this.pnlDocFolders);
    ((Control) this.gbPrintOptions).Controls.Add((Control) this.rbBoth);
    ((Control) this.gbPrintOptions).Controls.Add((Control) this.rbBrokerCopy);
    ((Control) this.gbPrintOptions).Controls.Add((Control) this.rbMGACopy);
    ((Control) this.gbPrintOptions).Controls.Add((Control) this.chkShowInstallments);
    ((Control) this.gbPrintOptions).Controls.Add((Control) this.lblPrintOptionsLine);
    appearance7.ForeColor = Color.FromArgb(21, 66, 139);
    ((UltraGroupBox) this.gbPrintOptions).HeaderAppearance = (AppearanceBase) appearance7;
    ((Control) this.gbPrintOptions).Location = new Point(420, 7);
    ((Control) this.gbPrintOptions).Name = "gbPrintOptions";
    ((Control) this.gbPrintOptions).Size = new Size(154, 211);
    ((Control) this.gbPrintOptions).TabIndex = 1;
    ((UltraGroupBox) this.gbPrintOptions).Text = "Print Options";
    ((UltraGroupBox) this.gbPrintOptions).ViewStyle = (GroupBoxViewStyle) 2;
    this.pnlDocFolders.Controls.Add((Control) this.treeDcuFolders);
    this.pnlDocFolders.Controls.Add((Control) this.Label8);
    this.pnlDocFolders.Controls.Add((Control) this.textEdDocFolders);
    this.pnlDocFolders.Location = new Point(3, 158);
    this.pnlDocFolders.Name = "pnlDocFolders";
    this.pnlDocFolders.Size = new Size(148, 48 /*0x30*/);
    this.pnlDocFolders.TabIndex = 58;
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(4, 5);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(120, 13);
    this.Label8.TabIndex = 53;
    this.Label8.Text = "Select Document Folder";
    downEditorButton.Control = (Control) this.treeDcuFolders;
    downEditorButton.DropDownResizeHandleStyle = (DropDownResizeHandleStyle) 3;
    downEditorButton.PreferredDropDownSize = new Size(300, 300);
    ((EditorButtonControlBase) this.textEdDocFolders).ButtonsRight.Add((EditorButtonBase) downEditorButton);
    ((TextEditorControlBase) this.textEdDocFolders).DisplayStyle = (EmbeddableElementDisplayStyle) 3;
    ((Control) this.textEdDocFolders).Location = new Point(3, 24);
    ((Control) this.textEdDocFolders).Name = "textEdDocFolders";
    ((Control) this.textEdDocFolders).Size = new Size(142, 22);
    ((Control) this.textEdDocFolders).TabIndex = 52;
    ((TextEditorControlBase) this.textEdDocFolders).Text = "none";
    this.rbBoth.BackColor = Color.Transparent;
    this.rbBoth.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.rbBoth.Location = new Point(14, 70);
    this.rbBoth.Name = "rbBoth";
    this.rbBoth.Size = new Size(91, 21);
    this.rbBoth.TabIndex = 2;
    this.rbBoth.Text = "Both";
    this.rbBoth.TextAlign = ContentAlignment.TopLeft;
    this.rbBoth.UseVisualStyleBackColor = false;
    this.rbBrokerCopy.BackColor = Color.Transparent;
    this.rbBrokerCopy.Location = new Point(14, 49);
    this.rbBrokerCopy.Name = "rbBrokerCopy";
    this.rbBrokerCopy.Size = new Size(91, 21);
    this.rbBrokerCopy.TabIndex = 1;
    this.rbBrokerCopy.Text = "Broker Copy";
    this.rbBrokerCopy.TextAlign = ContentAlignment.TopLeft;
    this.rbBrokerCopy.UseVisualStyleBackColor = false;
    this.rbMGACopy.BackColor = Color.Transparent;
    this.rbMGACopy.Checked = true;
    this.rbMGACopy.Location = new Point(14, 28);
    this.rbMGACopy.Name = "rbMGACopy";
    this.rbMGACopy.Size = new Size(91, 21);
    this.rbMGACopy.TabIndex = 0;
    this.rbMGACopy.TabStop = true;
    this.rbMGACopy.Text = "MGA Copy";
    this.rbMGACopy.TextAlign = ContentAlignment.TopLeft;
    this.rbMGACopy.UseVisualStyleBackColor = false;
    this.lblPrintOptionsLine.BorderStyle = BorderStyle.FixedSingle;
    this.lblPrintOptionsLine.Location = new Point(7, 91);
    this.lblPrintOptionsLine.Name = "lblPrintOptionsLine";
    this.lblPrintOptionsLine.Size = new Size(140, 1);
    this.lblPrintOptionsLine.TabIndex = 50;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.gbSearchCriteria).Appearance = (AppearanceBase) appearance8;
    ((UltraGroupBox) this.gbSearchCriteria).BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance9.BackColor = Color.FromArgb(239, 247, 253);
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGroupBox) this.gbSearchCriteria).ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.cboLine);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblLine);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.chkHideFutureInvoices);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lnkCompany);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.txtCompany);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.Label7);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.dtpPrintDateTo);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.dtpPrintDateFrom);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.Label4);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.Label5);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.txtPolicyNumber);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblPolicyNumber);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.dtpDueDateTo);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.dtpDueDateFrom);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.Label2);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.Label3);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.cboOffice);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lnkProducer);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lnkInsured);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.txtProducer);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.txtInsured);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblOffice);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.dtpInvoiceTo);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.dtpInvoiceFrom);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.txtQuoteControlNumberTo);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.txtQuoteControlNumberFrom);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.txtInvoiceNumberTo);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.txtInvoiceNumberFrom);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.cboUnderwriter);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.txtQuoteControlNumber);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.txtInvoiceNumber);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblUnderwriter);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblProducerLocation);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblInsured);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblInvoiceBetweenAnd);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblQuoteControlNumberRangeTo);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblQuoteControlNumberRange);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblQuoteControlNumber);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblInvoiceNumberRangeTo);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblInvoiceNumberRange);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.lblInvoiceNumber);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.chkShowVoids);
    ((Control) this.gbSearchCriteria).Controls.Add((Control) this.Label1);
    appearance10.ForeColor = Color.FromArgb(21, 66, 139);
    ((UltraGroupBox) this.gbSearchCriteria).HeaderAppearance = (AppearanceBase) appearance10;
    ((Control) this.gbSearchCriteria).Location = new Point(7, 7);
    ((Control) this.gbSearchCriteria).Name = "gbSearchCriteria";
    ((Control) this.gbSearchCriteria).Size = new Size(406, 419);
    ((Control) this.gbSearchCriteria).TabIndex = 0;
    ((UltraGroupBox) this.gbSearchCriteria).Text = "Search Criteria";
    ((UltraGroupBox) this.gbSearchCriteria).ViewStyle = (GroupBoxViewStyle) 2;
    ((UltraCombo) this.cboLine).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboLine).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboLine).Location = new Point(154, 130);
    this.cboLine.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboLine).Name = "cboLine";
    ((Control) this.cboLine).Size = new Size(238, 21);
    ((Control) this.cboLine).TabIndex = 71;
    ((UltraControlBase) this.cboLine).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLine).UseOsThemes = (DefaultableBoolean) 2;
    this.lblLine.BackColor = Color.Transparent;
    this.lblLine.Location = new Point(15, 133);
    this.lblLine.Name = "lblLine";
    this.lblLine.Size = new Size(133, 14);
    this.lblLine.TabIndex = 72;
    this.lblLine.Text = "Line:";
    appearance11.BorderColor = Color.Gray;
    appearance11.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideFutureInvoices).Appearance = (AppearanceBase) appearance11;
    ((UltraToggleEditorBase) this.chkHideFutureInvoices).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideFutureInvoices).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideFutureInvoices).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideFutureInvoices).Location = new Point(105, 400);
    ((Control) this.chkHideFutureInvoices).Name = "chkHideFutureInvoices";
    ((Control) this.chkHideFutureInvoices).Size = new Size(140, 14);
    ((Control) this.chkHideFutureInvoices).TabIndex = 70;
    ((UltraToggleEditorBase) this.chkHideFutureInvoices).Text = "Hide Future Invoices";
    ((UltraControlBase) this.chkHideFutureInvoices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideFutureInvoices).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkCompany.BackColor = Color.Transparent;
    this.lnkCompany.Location = new Point(350, 212);
    this.lnkCompany.Name = "lnkCompany";
    this.lnkCompany.Size = new Size(35, 14);
    this.lnkCompany.TabIndex = 68;
    this.lnkCompany.TabStop = true;
    this.lnkCompany.Text = "select";
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance12.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtCompany).Appearance = (AppearanceBase) appearance12;
    ((TextEditorControlBase) this.txtCompany).BackColor = Color.White;
    ((Control) this.txtCompany).Location = new Point(154, 209);
    this.txtCompany.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtCompany).Name = "txtCompany";
    ((EditorButtonControlBase) this.txtCompany).ReadOnly = true;
    ((Control) this.txtCompany).Size = new Size(189, 20);
    ((Control) this.txtCompany).TabIndex = 67;
    ((UltraControlBase) this.txtCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtCompany).UseOsThemes = (DefaultableBoolean) 2;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(14, 212);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(133, 14);
    this.Label7.TabIndex = 69;
    this.Label7.Text = "Company:";
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpPrintDateTo).Appearance = (AppearanceBase) appearance13;
    appearance14.AlphaLevel = (short) 14;
    appearance14.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance14.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance14.BackColorAlpha = (Alpha) 2;
    appearance14.BackGradientAlignment = (GradientAlignment) 4;
    appearance14.BackGradientStyle = (GradientStyle) 5;
    appearance14.BorderAlpha = (Alpha) 1;
    appearance14.BorderColor = Color.FromArgb(78, 122, 171);
    appearance14.ForeColor = Color.FromArgb(49, 85, 153);
    appearance14.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtpPrintDateTo).ButtonAppearance = (AppearanceBase) appearance14;
    ((Control) this.dtpPrintDateTo).Location = new Point(287, 366);
    this.dtpPrintDateTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpPrintDateTo).Name = "dtpPrintDateTo";
    ((Control) this.dtpPrintDateTo).Size = new Size(105, 20);
    ((Control) this.dtpPrintDateTo).TabIndex = 65;
    ((UltraControlBase) this.dtpPrintDateTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpPrintDateTo).UseOsThemes = (DefaultableBoolean) 2;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpPrintDateFrom).Appearance = (AppearanceBase) appearance15;
    appearance16.AlphaLevel = (short) 14;
    appearance16.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance16.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance16.BackColorAlpha = (Alpha) 2;
    appearance16.BackGradientAlignment = (GradientAlignment) 4;
    appearance16.BackGradientStyle = (GradientStyle) 5;
    appearance16.BorderAlpha = (Alpha) 1;
    appearance16.BorderColor = Color.FromArgb(78, 122, 171);
    appearance16.ForeColor = Color.FromArgb(49, 85, 153);
    appearance16.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtpPrintDateFrom).ButtonAppearance = (AppearanceBase) appearance16;
    ((Control) this.dtpPrintDateFrom).Location = new Point(154, 366);
    this.dtpPrintDateFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpPrintDateFrom).Name = "dtpPrintDateFrom";
    ((Control) this.dtpPrintDateFrom).Size = new Size(105, 20);
    ((Control) this.dtpPrintDateFrom).TabIndex = 64 /*0x40*/;
    ((UltraControlBase) this.dtpPrintDateFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpPrintDateFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(259, 369);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(28, 14);
    this.Label4.TabIndex = 63 /*0x3F*/;
    this.Label4.Text = "and";
    this.Label4.TextAlign = ContentAlignment.TopCenter;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(14, 369);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(133, 14);
    this.Label5.TabIndex = 66;
    this.Label5.Text = "Invoice Print Date Range:";
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtPolicyNumber).Appearance = (AppearanceBase) appearance17;
    ((TextEditorControlBase) this.txtPolicyNumber).BackColor = Color.White;
    ((Control) this.txtPolicyNumber).Location = new Point(154, 77);
    ((TextEditorControlBase) this.txtPolicyNumber).MaxLength = 100;
    this.txtPolicyNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtPolicyNumber).Name = "txtPolicyNumber";
    ((Control) this.txtPolicyNumber).Size = new Size(91, 20);
    ((Control) this.txtPolicyNumber).TabIndex = 61;
    ((UltraControlBase) this.txtPolicyNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtPolicyNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.lblPolicyNumber.BackColor = Color.Transparent;
    this.lblPolicyNumber.Location = new Point(14, 80 /*0x50*/);
    this.lblPolicyNumber.Name = "lblPolicyNumber";
    this.lblPolicyNumber.Size = new Size(133, 14);
    this.lblPolicyNumber.TabIndex = 62;
    this.lblPolicyNumber.Text = "Policy Number:";
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpDueDateTo).Appearance = (AppearanceBase) appearance18;
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
    ((UltraDateTimeEditor) this.dtpDueDateTo).ButtonAppearance = (AppearanceBase) appearance19;
    ((Control) this.dtpDueDateTo).Location = new Point(287, 340);
    this.dtpDueDateTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpDueDateTo).Name = "dtpDueDateTo";
    ((Control) this.dtpDueDateTo).Size = new Size(105, 20);
    ((Control) this.dtpDueDateTo).TabIndex = 59;
    ((UltraControlBase) this.dtpDueDateTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpDueDateTo).UseOsThemes = (DefaultableBoolean) 2;
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpDueDateFrom).Appearance = (AppearanceBase) appearance20;
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
    ((UltraDateTimeEditor) this.dtpDueDateFrom).ButtonAppearance = (AppearanceBase) appearance21;
    ((Control) this.dtpDueDateFrom).Location = new Point(154, 340);
    this.dtpDueDateFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpDueDateFrom).Name = "dtpDueDateFrom";
    ((Control) this.dtpDueDateFrom).Size = new Size(105, 20);
    ((Control) this.dtpDueDateFrom).TabIndex = 58;
    ((UltraControlBase) this.dtpDueDateFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpDueDateFrom).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(259, 343);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(28, 14);
    this.Label2.TabIndex = 57;
    this.Label2.Text = "and";
    this.Label2.TextAlign = ContentAlignment.TopCenter;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(14, 343);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(133, 14);
    this.Label3.TabIndex = 60;
    this.Label3.Text = "Invoice Due Date Range:";
    ((UltraCombo) this.cboOffice).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboOffice).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboOffice).Location = new Point(154, 103);
    this.cboOffice.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboOffice).Name = "cboOffice";
    ((Control) this.cboOffice).Size = new Size(238, 21);
    ((Control) this.cboOffice).TabIndex = 2;
    ((UltraControlBase) this.cboOffice).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboOffice).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkProducer.BackColor = Color.Transparent;
    this.lnkProducer.Location = new Point(350, 186);
    this.lnkProducer.Name = "lnkProducer";
    this.lnkProducer.Size = new Size(35, 14);
    this.lnkProducer.TabIndex = 5;
    this.lnkProducer.TabStop = true;
    this.lnkProducer.Text = "select";
    this.lnkInsured.BackColor = Color.Transparent;
    this.lnkInsured.Location = new Point(350, 160 /*0xA0*/);
    this.lnkInsured.Name = "lnkInsured";
    this.lnkInsured.Size = new Size(35, 14);
    this.lnkInsured.TabIndex = 3;
    this.lnkInsured.TabStop = true;
    this.lnkInsured.Text = "select";
    appearance22.BackColor = Color.White;
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance22.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtProducer).Appearance = (AppearanceBase) appearance22;
    ((TextEditorControlBase) this.txtProducer).BackColor = Color.White;
    ((Control) this.txtProducer).Location = new Point(154, 183);
    this.txtProducer.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtProducer).Name = "txtProducer";
    ((EditorButtonControlBase) this.txtProducer).ReadOnly = true;
    ((Control) this.txtProducer).Size = new Size(189, 20);
    ((Control) this.txtProducer).TabIndex = 4;
    ((UltraControlBase) this.txtProducer).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtProducer).UseOsThemes = (DefaultableBoolean) 2;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance23.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInsured).Appearance = (AppearanceBase) appearance23;
    ((TextEditorControlBase) this.txtInsured).BackColor = Color.White;
    ((Control) this.txtInsured).Location = new Point(154, 157);
    this.txtInsured.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInsured).Name = "txtInsured";
    ((EditorButtonControlBase) this.txtInsured).ReadOnly = true;
    ((Control) this.txtInsured).Size = new Size(189, 20);
    ((Control) this.txtInsured).TabIndex = 3;
    ((UltraControlBase) this.txtInsured).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInsured).UseOsThemes = (DefaultableBoolean) 2;
    this.lblOffice.BackColor = Color.Transparent;
    this.lblOffice.Location = new Point(14, 106);
    this.lblOffice.Name = "lblOffice";
    this.lblOffice.Size = new Size(133, 14);
    this.lblOffice.TabIndex = 25;
    this.lblOffice.Text = "Office:";
    appearance24.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpInvoiceTo).Appearance = (AppearanceBase) appearance24;
    appearance25.AlphaLevel = (short) 14;
    appearance25.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance25.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance25.BackColorAlpha = (Alpha) 2;
    appearance25.BackGradientAlignment = (GradientAlignment) 4;
    appearance25.BackGradientStyle = (GradientStyle) 5;
    appearance25.BorderAlpha = (Alpha) 1;
    appearance25.BorderColor = Color.FromArgb(78, 122, 171);
    appearance25.ForeColor = Color.FromArgb(49, 85, 153);
    appearance25.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtpInvoiceTo).ButtonAppearance = (AppearanceBase) appearance25;
    ((Control) this.dtpInvoiceTo).Location = new Point(287, 314);
    this.dtpInvoiceTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpInvoiceTo).Name = "dtpInvoiceTo";
    ((Control) this.dtpInvoiceTo).Size = new Size(105, 20);
    ((Control) this.dtpInvoiceTo).TabIndex = 13;
    ((UltraControlBase) this.dtpInvoiceTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpInvoiceTo).UseOsThemes = (DefaultableBoolean) 2;
    appearance26.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpInvoiceFrom).Appearance = (AppearanceBase) appearance26;
    appearance27.AlphaLevel = (short) 14;
    appearance27.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance27.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance27.BackColorAlpha = (Alpha) 2;
    appearance27.BackGradientAlignment = (GradientAlignment) 4;
    appearance27.BackGradientStyle = (GradientStyle) 5;
    appearance27.BorderAlpha = (Alpha) 1;
    appearance27.BorderColor = Color.FromArgb(78, 122, 171);
    appearance27.ForeColor = Color.FromArgb(49, 85, 153);
    appearance27.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtpInvoiceFrom).ButtonAppearance = (AppearanceBase) appearance27;
    ((Control) this.dtpInvoiceFrom).Location = new Point(154, 314);
    this.dtpInvoiceFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpInvoiceFrom).Name = "dtpInvoiceFrom";
    ((Control) this.dtpInvoiceFrom).Size = new Size(105, 20);
    ((Control) this.dtpInvoiceFrom).TabIndex = 12;
    ((UltraControlBase) this.dtpInvoiceFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpInvoiceFrom).UseOsThemes = (DefaultableBoolean) 2;
    appearance28.BackColor = Color.White;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance28.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtQuoteControlNumberTo).Appearance = (AppearanceBase) appearance28;
    ((TextEditorControlBase) this.txtQuoteControlNumberTo).BackColor = Color.White;
    ((Control) this.txtQuoteControlNumberTo).Location = new Point(287, 288);
    ((TextEditorControlBase) this.txtQuoteControlNumberTo).MaxLength = 10;
    this.txtQuoteControlNumberTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtQuoteControlNumberTo).Name = "txtQuoteControlNumberTo";
    ((Control) this.txtQuoteControlNumberTo).Size = new Size(105, 20);
    ((Control) this.txtQuoteControlNumberTo).TabIndex = 10;
    ((UltraControlBase) this.txtQuoteControlNumberTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtQuoteControlNumberTo).UseOsThemes = (DefaultableBoolean) 2;
    appearance29.BackColor = Color.White;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtQuoteControlNumberFrom).Appearance = (AppearanceBase) appearance29;
    ((TextEditorControlBase) this.txtQuoteControlNumberFrom).BackColor = Color.White;
    ((Control) this.txtQuoteControlNumberFrom).Location = new Point(154, 288);
    ((TextEditorControlBase) this.txtQuoteControlNumberFrom).MaxLength = 10;
    this.txtQuoteControlNumberFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtQuoteControlNumberFrom).Name = "txtQuoteControlNumberFrom";
    ((Control) this.txtQuoteControlNumberFrom).Size = new Size(105, 20);
    ((Control) this.txtQuoteControlNumberFrom).TabIndex = 9;
    ((UltraControlBase) this.txtQuoteControlNumberFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtQuoteControlNumberFrom).UseOsThemes = (DefaultableBoolean) 2;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance30.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInvoiceNumberTo).Appearance = (AppearanceBase) appearance30;
    ((TextEditorControlBase) this.txtInvoiceNumberTo).BackColor = Color.White;
    ((Control) this.txtInvoiceNumberTo).Location = new Point(287, 262);
    ((TextEditorControlBase) this.txtInvoiceNumberTo).MaxLength = 10;
    this.txtInvoiceNumberTo.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInvoiceNumberTo).Name = "txtInvoiceNumberTo";
    ((Control) this.txtInvoiceNumberTo).Size = new Size(105, 20);
    ((Control) this.txtInvoiceNumberTo).TabIndex = 8;
    ((UltraControlBase) this.txtInvoiceNumberTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInvoiceNumberTo).UseOsThemes = (DefaultableBoolean) 2;
    appearance31.BackColor = Color.White;
    appearance31.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance31.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInvoiceNumberFrom).Appearance = (AppearanceBase) appearance31;
    ((TextEditorControlBase) this.txtInvoiceNumberFrom).BackColor = Color.White;
    ((Control) this.txtInvoiceNumberFrom).Location = new Point(154, 262);
    ((TextEditorControlBase) this.txtInvoiceNumberFrom).MaxLength = 10;
    this.txtInvoiceNumberFrom.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInvoiceNumberFrom).Name = "txtInvoiceNumberFrom";
    ((Control) this.txtInvoiceNumberFrom).Size = new Size(105, 20);
    ((Control) this.txtInvoiceNumberFrom).TabIndex = 7;
    ((UltraControlBase) this.txtInvoiceNumberFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInvoiceNumberFrom).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraCombo) this.cboUnderwriter).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.cboUnderwriter).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUnderwriter).Location = new Point(154, 235);
    this.cboUnderwriter.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboUnderwriter).Name = "cboUnderwriter";
    ((Control) this.cboUnderwriter).Size = new Size(238, 21);
    ((Control) this.cboUnderwriter).TabIndex = 6;
    ((UltraControlBase) this.cboUnderwriter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriter).UseOsThemes = (DefaultableBoolean) 2;
    appearance32.BackColor = Color.White;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtQuoteControlNumber).Appearance = (AppearanceBase) appearance32;
    ((TextEditorControlBase) this.txtQuoteControlNumber).BackColor = Color.White;
    ((Control) this.txtQuoteControlNumber).Location = new Point(154, 51);
    ((TextEditorControlBase) this.txtQuoteControlNumber).MaxLength = 10;
    this.txtQuoteControlNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtQuoteControlNumber).Name = "txtQuoteControlNumber";
    ((Control) this.txtQuoteControlNumber).Size = new Size(91, 20);
    ((Control) this.txtQuoteControlNumber).TabIndex = 1;
    ((UltraControlBase) this.txtQuoteControlNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtQuoteControlNumber).UseOsThemes = (DefaultableBoolean) 2;
    appearance33.BackColor = Color.White;
    appearance33.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance33.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtInvoiceNumber).Appearance = (AppearanceBase) appearance33;
    ((TextEditorControlBase) this.txtInvoiceNumber).BackColor = Color.White;
    ((Control) this.txtInvoiceNumber).Location = new Point(154, 25);
    ((TextEditorControlBase) this.txtInvoiceNumber).MaxLength = 10;
    this.txtInvoiceNumber.MGAStyle = (MGAStyles) 2;
    ((Control) this.txtInvoiceNumber).Name = "txtInvoiceNumber";
    ((Control) this.txtInvoiceNumber).Size = new Size(91, 20);
    ((Control) this.txtInvoiceNumber).TabIndex = 0;
    ((UltraControlBase) this.txtInvoiceNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtInvoiceNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.lblUnderwriter.BackColor = Color.Transparent;
    this.lblUnderwriter.Location = new Point(14, 238);
    this.lblUnderwriter.Name = "lblUnderwriter";
    this.lblUnderwriter.Size = new Size(133, 14);
    this.lblUnderwriter.TabIndex = 13;
    this.lblUnderwriter.Text = "Underwriter:";
    this.lblProducerLocation.BackColor = Color.Transparent;
    this.lblProducerLocation.Location = new Point(14, 186);
    this.lblProducerLocation.Name = "lblProducerLocation";
    this.lblProducerLocation.Size = new Size(133, 14);
    this.lblProducerLocation.TabIndex = 12;
    this.lblProducerLocation.Text = "Producer:";
    this.lblInsured.BackColor = Color.Transparent;
    this.lblInsured.Location = new Point(14, 160 /*0xA0*/);
    this.lblInsured.Name = "lblInsured";
    this.lblInsured.Size = new Size(133, 14);
    this.lblInsured.TabIndex = 11;
    this.lblInsured.Text = "Insured:";
    this.lblInvoiceBetweenAnd.BackColor = Color.Transparent;
    this.lblInvoiceBetweenAnd.Location = new Point(259, 317);
    this.lblInvoiceBetweenAnd.Name = "lblInvoiceBetweenAnd";
    this.lblInvoiceBetweenAnd.Size = new Size(28, 14);
    this.lblInvoiceBetweenAnd.TabIndex = 10;
    this.lblInvoiceBetweenAnd.Text = "and";
    this.lblInvoiceBetweenAnd.TextAlign = ContentAlignment.TopCenter;
    this.lblQuoteControlNumberRangeTo.BackColor = Color.Transparent;
    this.lblQuoteControlNumberRangeTo.Location = new Point(259, 291);
    this.lblQuoteControlNumberRangeTo.Name = "lblQuoteControlNumberRangeTo";
    this.lblQuoteControlNumberRangeTo.Size = new Size(28, 14);
    this.lblQuoteControlNumberRangeTo.TabIndex = 8;
    this.lblQuoteControlNumberRangeTo.Text = "to";
    this.lblQuoteControlNumberRangeTo.TextAlign = ContentAlignment.TopCenter;
    this.lblQuoteControlNumberRange.BackColor = Color.Transparent;
    this.lblQuoteControlNumberRange.Location = new Point(14, 291);
    this.lblQuoteControlNumberRange.Name = "lblQuoteControlNumberRange";
    this.lblQuoteControlNumberRange.Size = new Size(133, 14);
    this.lblQuoteControlNumberRange.TabIndex = 7;
    this.lblQuoteControlNumberRange.Text = "Control Number Range:";
    this.lblQuoteControlNumber.BackColor = Color.Transparent;
    this.lblQuoteControlNumber.Location = new Point(14, 54);
    this.lblQuoteControlNumber.Name = "lblQuoteControlNumber";
    this.lblQuoteControlNumber.Size = new Size(133, 14);
    this.lblQuoteControlNumber.TabIndex = 6;
    this.lblQuoteControlNumber.Text = "Control Number:";
    this.lblInvoiceNumberRangeTo.BackColor = Color.Transparent;
    this.lblInvoiceNumberRangeTo.Location = new Point(259, 265);
    this.lblInvoiceNumberRangeTo.Name = "lblInvoiceNumberRangeTo";
    this.lblInvoiceNumberRangeTo.Size = new Size(28, 14);
    this.lblInvoiceNumberRangeTo.TabIndex = 5;
    this.lblInvoiceNumberRangeTo.Text = "to";
    this.lblInvoiceNumberRangeTo.TextAlign = ContentAlignment.TopCenter;
    this.lblInvoiceNumberRange.BackColor = Color.Transparent;
    this.lblInvoiceNumberRange.Location = new Point(14, 265);
    this.lblInvoiceNumberRange.Name = "lblInvoiceNumberRange";
    this.lblInvoiceNumberRange.Size = new Size(133, 14);
    this.lblInvoiceNumberRange.TabIndex = 4;
    this.lblInvoiceNumberRange.Text = "Invoice Number Range:";
    this.lblInvoiceNumber.BackColor = Color.Transparent;
    this.lblInvoiceNumber.Location = new Point(14, 28);
    this.lblInvoiceNumber.Name = "lblInvoiceNumber";
    this.lblInvoiceNumber.Size = new Size(133, 14);
    this.lblInvoiceNumber.TabIndex = 3;
    this.lblInvoiceNumber.Text = "Invoice Number:";
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(14, 317);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(133, 14);
    this.Label1.TabIndex = 56;
    this.Label1.Text = "Invoice Date Range:";
    this.lblStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lblStatus.BackColor = Color.Gainsboro;
    this.lblStatus.BorderStyle = BorderStyle.FixedSingle;
    this.lblStatus.Location = new Point(77, 670);
    this.lblStatus.Name = "lblStatus";
    this.lblStatus.Size = new Size(601, 14);
    this.lblStatus.TabIndex = 52;
    this.lblStatus.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this.btnPrev).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance34.BackColor = Color.Gainsboro;
    appearance34.BackColor2 = Color.White;
    appearance34.BackGradientStyle = (GradientStyle) 2;
    appearance34.BorderColor = Color.Gray;
    appearance34.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnPrev).Appearance = (AppearanceBase) appearance34;
    ((Control) this.btnPrev).Enabled = false;
    ((ControlBase) this.btnPrev).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnPrev).Location = new Point(42, 663);
    ((Control) this.btnPrev).Name = "btnPrev";
    ((Control) this.btnPrev).Size = new Size(28, 28);
    ((Control) this.btnPrev).TabIndex = 7;
    this.tt.SetToolTip((Control) this.btnPrev, "Previous");
    this.btnPrev.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnNext).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance35.BackColor = Color.Gainsboro;
    appearance35.BackColor2 = Color.White;
    appearance35.BackGradientStyle = (GradientStyle) 2;
    appearance35.BorderColor = Color.Gray;
    appearance35.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnNext).Appearance = (AppearanceBase) appearance35;
    ((Control) this.btnNext).Enabled = false;
    ((ControlBase) this.btnNext).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnNext).Location = new Point(685, 663);
    ((Control) this.btnNext).Name = "btnNext";
    ((Control) this.btnNext).Size = new Size(28, 28);
    ((Control) this.btnNext).TabIndex = 8;
    this.tt.SetToolTip((Control) this.btnNext, "Next");
    this.btnNext.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnLast).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance36.BackColor = Color.Gainsboro;
    appearance36.BackColor2 = Color.White;
    appearance36.BackGradientStyle = (GradientStyle) 2;
    appearance36.BorderColor = Color.Gray;
    appearance36.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnLast).Appearance = (AppearanceBase) appearance36;
    ((Control) this.btnLast).Enabled = false;
    ((ControlBase) this.btnLast).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnLast).Location = new Point(720, 663);
    ((Control) this.btnLast).Name = "btnLast";
    ((Control) this.btnLast).Size = new Size(28, 28);
    ((Control) this.btnLast).TabIndex = 9;
    this.tt.SetToolTip((Control) this.btnLast, "Last");
    this.btnLast.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnFirst).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance37.BackColor = Color.Gainsboro;
    appearance37.BackColor2 = Color.White;
    appearance37.BackGradientStyle = (GradientStyle) 2;
    appearance37.BorderColor = Color.Gray;
    appearance37.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnFirst).Appearance = (AppearanceBase) appearance37;
    ((Control) this.btnFirst).Enabled = false;
    ((ControlBase) this.btnFirst).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnFirst).Location = new Point(7, 663);
    ((Control) this.btnFirst).Name = "btnFirst";
    ((Control) this.btnFirst).Size = new Size(28, 28);
    ((Control) this.btnFirst).TabIndex = 6;
    this.tt.SetToolTip((Control) this.btnFirst, "First");
    this.btnFirst.UseOSThemes = (DefaultableBoolean) 2;
    this._da.SelectCommand = this.DbSelectCommand1;
    this._da.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "InvoiceLookup", new DataColumnMapping[1]
      {
        new DataColumnMapping("Column1", "Column1")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[9]
      {
        new DataColumnMapping("RecordNumber", "RecordNumber"),
        new DataColumnMapping("OfficeInvoiceNumber", "OfficeInvoiceNumber"),
        new DataColumnMapping("SystemInvoiceNumber", "SystemInvoiceNumber"),
        new DataColumnMapping("InvoiceDate", "InvoiceDate"),
        new DataColumnMapping("DatePrinted", "DatePrinted"),
        new DataColumnMapping("QuoteControlNum", "QuoteControlNum"),
        new DataColumnMapping("Insured", "Insured"),
        new DataColumnMapping("Producer", "Producer"),
        new DataColumnMapping("Company", "Company")
      })
    });
    this.DbSelectCommand1.CommandText = "[InvoiceLookup]";
    this.DbSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.DbSelectCommand1.Parameters.AddRange((Array) new DbParameter[17]
    {
      DefaultDatabase.CreateParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      DefaultDatabase.CreateParameter("@FromRecord", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@NumberOfRecords", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@GLCompanyID", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@OfficeInvoiceNumber", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@FromOfficeInvoiceNumber", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@ToOfficeInvoiceNumber", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@QuoteControlNum", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@FromQuoteControlNum", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@ToQuoteControlNum", SqlDbType.Int, 4),
      DefaultDatabase.CreateParameter("@FromInvoiceDate", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@ToInvoiceDate", SqlDbType.DateTime, 8),
      DefaultDatabase.CreateParameter("@InsuredLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@ProducerLocationGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@UnderwriterUserGuid", SqlDbType.UniqueIdentifier, 16 /*0x10*/),
      DefaultDatabase.CreateParameter("@GetCount", SqlDbType.Bit, 1),
      DefaultDatabase.CreateParameter("@ShowVoids", SqlDbType.Bit, 1)
    });
    appearance38.BackColor = Color.Gainsboro;
    appearance38.BackColor2 = Color.White;
    appearance38.BackGradientStyle = (GradientStyle) 2;
    appearance38.BorderColor = Color.Gray;
    appearance38.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnReset).Appearance = (AppearanceBase) appearance38;
    ((ControlBase) this.btnReset).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnReset).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnReset).Location = new Point(420, 250);
    ((Control) this.btnReset).Name = "btnReset";
    ((Control) this.btnReset).Size = new Size(40, 40);
    ((Control) this.btnReset).TabIndex = 3;
    this.tt.SetToolTip((Control) this.btnReset, "Reset Search Criteria");
    this.btnReset.UseOSThemes = (DefaultableBoolean) 2;
    appearance39.BackColor = Color.Gainsboro;
    appearance39.BackColor2 = Color.White;
    appearance39.BackGradientStyle = (GradientStyle) 2;
    appearance39.BorderColor = Color.Gray;
    appearance39.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnPrintSelectedInvoices).Appearance = (AppearanceBase) appearance39;
    ((ControlBase) this.btnPrintSelectedInvoices).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnPrintSelectedInvoices).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnPrintSelectedInvoices).Location = new Point(420, 375);
    ((Control) this.btnPrintSelectedInvoices).Name = "btnPrintSelectedInvoices";
    ((Control) this.btnPrintSelectedInvoices).Size = new Size(40, 40);
    ((Control) this.btnPrintSelectedInvoices).TabIndex = 54;
    this.tt.SetToolTip((Control) this.btnPrintSelectedInvoices, "Print Selected Invoices");
    this.btnPrintSelectedInvoices.UseOSThemes = (DefaultableBoolean) 2;
    appearance40.BackColor = Color.Gainsboro;
    appearance40.BackColor2 = Color.White;
    appearance40.BackGradientStyle = (GradientStyle) 2;
    appearance40.BorderColor = Color.Gray;
    appearance40.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnPrintAllReturnedInvoices).Appearance = (AppearanceBase) appearance40;
    ((ControlBase) this.btnPrintAllReturnedInvoices).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnPrintAllReturnedInvoices).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnPrintAllReturnedInvoices).Location = new Point(469, 375);
    ((Control) this.btnPrintAllReturnedInvoices).Name = "btnPrintAllReturnedInvoices";
    ((Control) this.btnPrintAllReturnedInvoices).Size = new Size(40, 40);
    ((Control) this.btnPrintAllReturnedInvoices).TabIndex = 55;
    this.tt.SetToolTip((Control) this.btnPrintAllReturnedInvoices, "Print All Returned Invoices");
    this.btnPrintAllReturnedInvoices.UseOSThemes = (DefaultableBoolean) 2;
    appearance41.BackColor = Color.Gainsboro;
    appearance41.BackColor2 = Color.White;
    appearance41.BackGradientStyle = (GradientStyle) 2;
    appearance41.BorderColor = Color.Gray;
    appearance41.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance4.Image"));
    appearance41.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnEmailAll).Appearance = (AppearanceBase) appearance41;
    ((ControlBase) this.btnEmailAll).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnEmailAll).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnEmailAll).Location = new Point(520, 375);
    ((Control) this.btnEmailAll).Name = "btnEmailAll";
    ((Control) this.btnEmailAll).Size = new Size(40, 40);
    ((Control) this.btnEmailAll).TabIndex = 57;
    this.tt.SetToolTip((Control) this.btnEmailAll, "Email All Returned Invoices");
    this.btnEmailAll.UseOSThemes = (DefaultableBoolean) 2;
    appearance42.BackColor = Color.Gainsboro;
    appearance42.BackColor2 = Color.White;
    appearance42.BackGradientStyle = (GradientStyle) 2;
    appearance42.BorderColor = Color.Gray;
    appearance42.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    appearance42.ImageHAlign = (HAlign) 2;
    ((ControlBase) this.btnPrintToPdf).Appearance = (AppearanceBase) appearance42;
    ((ControlBase) this.btnPrintToPdf).ImageSize = new Size(32 /*0x20*/, 32 /*0x20*/);
    ((ControlBase) this.btnPrintToPdf).ImageTransparentColor = Color.White;
    ((Control) this.btnPrintToPdf).Location = new Point(569, 375);
    ((Control) this.btnPrintToPdf).Name = "btnPrintToPdf";
    ((Control) this.btnPrintToPdf).Size = new Size(40, 40);
    ((Control) this.btnPrintToPdf).TabIndex = 58;
    this.tt.SetToolTip((Control) this.btnPrintToPdf, "Save Selected Invoices to PDF");
    this.btnPrintToPdf.UseOSThemes = (DefaultableBoolean) 2;
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelPleaseWait.ContentAreaAppearance = (AppearanceBase) appearance43;
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.Label6);
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.PictureBox1);
    ((Control) this.panelPleaseWait).Location = new Point(140, 498);
    ((Control) this.panelPleaseWait).Name = "panelPleaseWait";
    ((Control) this.panelPleaseWait).Size = new Size(369, 84);
    ((Control) this.panelPleaseWait).TabIndex = 56;
    ((Control) this.panelPleaseWait).Visible = false;
    this.Label6.Font = new Font("Tahoma", 11f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(55, 32 /*0x20*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(308, 21);
    this.Label6.TabIndex = 1;
    this.Label6.Text = "Please wait while the invoices are loaded ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(17, 26);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    this.FolderBrowserDialog1.Description = "Select folder to save PDF files";
    ((Control) this.ugInvoices).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ugInvoices).ContextMenu = this.cmRightClick;
    ((UltraControlBase) this.ugInvoices).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugInvoices).DataSource = (object) this._dsInvoices.InvoiceLookup;
    appearance44.BackColor = Color.White;
    appearance44.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Appearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 50;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 87;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 84;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Format = "d";
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Billed";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 67;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Format = "d";
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Printed";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Width = 78;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Width = 60;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 8;
    ultraGridColumn7.Width = 92;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 9;
    ultraGridColumn8.Width = 77;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 10;
    ultraGridColumn9.Width = 74;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 11;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 35;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 4;
    ultraGridColumn11.Width = 71;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 7;
    ultraGridColumn12.Width = 89;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Width = 44;
    ultraGridBand.Columns.AddRange(new object[13]
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
      (object) ultraGridColumn13
    });
    ((UltraGridBase) this.ugInvoices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugInvoices).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance45.BackColor = Color.LightSteelBlue;
    appearance45.FontData.SizeInPoints = 10f;
    appearance45.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance45;
    appearance46.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance46.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance46.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance47.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance47;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance48.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance49.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance49;
    appearance50.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance51.BackColor = Color.Transparent;
    appearance51.ForeColor = Color.Black;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance51;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugInvoices).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugInvoices).Location = new Point(7, 432);
    ((Control) this.ugInvoices).Name = "ugInvoices";
    ((Control) this.ugInvoices).Size = new Size(741, 219);
    ((Control) this.ugInvoices).TabIndex = 5;
    ((Control) this.ugInvoices).Text = "Invoices";
    ((UltraControlBase) this.ugInvoices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugInvoices).UseOsThemes = (DefaultableBoolean) 2;
    this._dsInvoices.DataSetName = "dsInvoiceSearchResults";
    this._dsInvoices.Locale = new CultureInfo("en-US");
    this._dsInvoices.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AcceptButton = (IButtonControl) this.btnSearch;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(756, 708);
    this.Controls.Add((Control) this.btnPrintToPdf);
    this.Controls.Add((Control) this.btnEmailAll);
    this.Controls.Add((Control) this.panelPleaseWait);
    this.Controls.Add((Control) this.btnPrintAllReturnedInvoices);
    this.Controls.Add((Control) this.btnPrintSelectedInvoices);
    this.Controls.Add((Control) this.btnReset);
    this.Controls.Add((Control) this.btnPrev);
    this.Controls.Add((Control) this.btnNext);
    this.Controls.Add((Control) this.btnLast);
    this.Controls.Add((Control) this.btnFirst);
    this.Controls.Add((Control) this.lblStatus);
    this.Controls.Add((Control) this.ugInvoices);
    this.Controls.Add((Control) this.gbSearchCriteria);
    this.Controls.Add((Control) this.gbPrintOptions);
    this.Controls.Add((Control) this.btnSearch);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.MinimumSize = new Size(637, 550);
    this.Name = nameof (frmInvoiceLookup);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Invoice Lookup";
    ((ISupportInitialize) this.treeDcuFolders).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.chkShowVoids).EndInit();
    ((ISupportInitialize) this.chkShowInstallments).EndInit();
    ((ISupportInitialize) this.gbPrintOptions).EndInit();
    ((Control) this.gbPrintOptions).ResumeLayout(false);
    this.pnlDocFolders.ResumeLayout(false);
    this.pnlDocFolders.PerformLayout();
    ((ISupportInitialize) this.textEdDocFolders).EndInit();
    ((ISupportInitialize) this.gbSearchCriteria).EndInit();
    ((Control) this.gbSearchCriteria).ResumeLayout(false);
    ((Control) this.gbSearchCriteria).PerformLayout();
    ((ISupportInitialize) this.cboLine).EndInit();
    ((ISupportInitialize) this.chkHideFutureInvoices).EndInit();
    ((ISupportInitialize) this.txtCompany).EndInit();
    ((ISupportInitialize) this.dtpPrintDateTo).EndInit();
    ((ISupportInitialize) this.dtpPrintDateFrom).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
    ((ISupportInitialize) this.dtpDueDateTo).EndInit();
    ((ISupportInitialize) this.dtpDueDateFrom).EndInit();
    ((ISupportInitialize) this.cboOffice).EndInit();
    ((ISupportInitialize) this.txtProducer).EndInit();
    ((ISupportInitialize) this.txtInsured).EndInit();
    ((ISupportInitialize) this.dtpInvoiceTo).EndInit();
    ((ISupportInitialize) this.dtpInvoiceFrom).EndInit();
    ((ISupportInitialize) this.txtQuoteControlNumberTo).EndInit();
    ((ISupportInitialize) this.txtQuoteControlNumberFrom).EndInit();
    ((ISupportInitialize) this.txtInvoiceNumberTo).EndInit();
    ((ISupportInitialize) this.txtInvoiceNumberFrom).EndInit();
    ((ISupportInitialize) this.cboUnderwriter).EndInit();
    ((ISupportInitialize) this.txtQuoteControlNumber).EndInit();
    ((ISupportInitialize) this.txtInvoiceNumber).EndInit();
    ((ISupportInitialize) this.btnPrev).EndInit();
    ((ISupportInitialize) this.btnNext).EndInit();
    ((ISupportInitialize) this.btnLast).EndInit();
    ((ISupportInitialize) this.btnFirst).EndInit();
    ((ISupportInitialize) this.btnReset).EndInit();
    ((ISupportInitialize) this.btnPrintSelectedInvoices).EndInit();
    ((ISupportInitialize) this.btnPrintAllReturnedInvoices).EndInit();
    ((ISupportInitialize) this.btnEmailAll).EndInit();
    ((ISupportInitialize) this.btnPrintToPdf).EndInit();
    ((ISupportInitialize) this.panelPleaseWait).EndInit();
    ((Control) this.panelPleaseWait).ResumeLayout(false);
    ((Control) this.panelPleaseWait).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.ugInvoices).EndInit();
    this._dsInvoices.EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("panelPleaseWait")]
  private virtual UltraGroupBox panelPleaseWait { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  private virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnEmailAll
  {
    get => this._btnEmailAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnEmailAll_Click);
      MGAButton btnEmailAll1 = this._btnEmailAll;
      if (btnEmailAll1 != null)
        ((Control) btnEmailAll1).Click -= eventHandler;
      this._btnEmailAll = value;
      MGAButton btnEmailAll2 = this._btnEmailAll;
      if (btnEmailAll2 == null)
        return;
      ((Control) btnEmailAll2).Click += eventHandler;
    }
  }

  private virtual LinkLabel lnkCompany
  {
    get => this._lnkCompany;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCompany_LinkClicked);
      LinkLabel lnkCompany1 = this._lnkCompany;
      if (lnkCompany1 != null)
        lnkCompany1.LinkClicked -= clickedEventHandler;
      this._lnkCompany = value;
      LinkLabel lnkCompany2 = this._lnkCompany;
      if (lnkCompany2 == null)
        return;
      lnkCompany2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtCompany")]
  private virtual MGATextBox txtCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkHideFutureInvoices")]
  protected virtual MGACheckBox chkHideFutureInvoices { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("pnlDocFolders")]
  protected virtual Panel pnlDocFolders { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraTree treeDcuFolders
  {
    get => this._treeDcuFolders;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      AfterNodeSelectEventHandler selectEventHandler = new AfterNodeSelectEventHandler(this.treeDcuFolders_AfterSelect);
      UltraTree treeDcuFolders1 = this._treeDcuFolders;
      if (treeDcuFolders1 != null)
        treeDcuFolders1.AfterSelect -= selectEventHandler;
      this._treeDcuFolders = value;
      UltraTree treeDcuFolders2 = this._treeDcuFolders;
      if (treeDcuFolders2 == null)
        return;
      treeDcuFolders2.AfterSelect += selectEventHandler;
    }
  }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraTextEditor textEdDocFolders
  {
    get => this._textEdDocFolders;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      BeforeEditorButtonDropDownEventHandler downEventHandler = new BeforeEditorButtonDropDownEventHandler(this.textEdDocFolders_BeforeEditorButtonDropDown);
      UltraTextEditor textEdDocFolders1 = this._textEdDocFolders;
      if (textEdDocFolders1 != null)
        ((EditorButtonControlBase) textEdDocFolders1).BeforeEditorButtonDropDown -= downEventHandler;
      this._textEdDocFolders = value;
      UltraTextEditor textEdDocFolders2 = this._textEdDocFolders;
      if (textEdDocFolders2 == null)
        return;
      ((EditorButtonControlBase) textEdDocFolders2).BeforeEditorButtonDropDown += downEventHandler;
    }
  }

  protected virtual MGAButton btnPrintToPdf
  {
    get => this._btnPrintToPdf;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrintToPdf_Click);
      MGAButton btnPrintToPdf1 = this._btnPrintToPdf;
      if (btnPrintToPdf1 != null)
        ((Control) btnPrintToPdf1).Click -= eventHandler;
      this._btnPrintToPdf = value;
      MGAButton btnPrintToPdf2 = this._btnPrintToPdf;
      if (btnPrintToPdf2 == null)
        return;
      ((Control) btnPrintToPdf2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("FolderBrowserDialog1")]
  internal virtual FolderBrowserDialog FolderBrowserDialog1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLine")]
  private virtual MGASimpleComboBox cboLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLine")]
  private virtual Label lblLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_da")]
  private virtual DbDataAdapter _da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected SqlDataAdapter da
  {
    get => this._da as SqlDataAdapter;
    set => this._da = (DbDataAdapter) value;
  }

  protected virtual void ResetForm()
  {
    ((TextEditorControlBase) this.txtInvoiceNumber).Text = string.Empty;
    ((TextEditorControlBase) this.txtQuoteControlNumber).Text = string.Empty;
    ((TextEditorControlBase) this.txtInsured).Text = string.Empty;
    this._insuredLocationGuid = Guid.Empty;
    ((TextEditorControlBase) this.txtProducer).Text = string.Empty;
    this._producerLocationGuid = Guid.Empty;
    this.cboUnderwriter.SelectedIndex = 0;
    this.cboOffice.SelectedIndex = 0;
    this.cboLine.SelectedIndex = 0;
    ((TextEditorControlBase) this.txtInvoiceNumberFrom).Text = string.Empty;
    ((TextEditorControlBase) this.txtInvoiceNumberTo).Text = string.Empty;
    ((TextEditorControlBase) this.txtQuoteControlNumberFrom).Text = string.Empty;
    ((TextEditorControlBase) this.txtQuoteControlNumberTo).Text = string.Empty;
    ((UltraDateTimeEditor) this.dtpInvoiceFrom).Value = (object) null;
    ((UltraDateTimeEditor) this.dtpInvoiceTo).Value = (object) null;
    ((UltraDateTimeEditor) this.dtpDueDateFrom).Value = (object) null;
    ((UltraDateTimeEditor) this.dtpDueDateTo).Value = (object) null;
    ((UltraDateTimeEditor) this.dtpPrintDateFrom).Value = (object) null;
    ((UltraDateTimeEditor) this.dtpPrintDateTo).Value = (object) null;
    ((UltraToggleEditorBase) this.chkShowVoids).Checked = false;
    this.rbMGACopy.Checked = true;
    ((UltraToggleEditorBase) this.chkShowVoids).Checked = false;
    this._companyLocationGuid = Guid.Empty;
    ((TextEditorControlBase) this.txtCompany).Text = string.Empty;
  }

  private void SetStatusText()
  {
    this.lblStatus.Text = $"Showing records {this._currentStartingRecord}-{(this._currentStartingRecord + 100 - 1 <= this._recordCount ? this._currentStartingRecord + 100 - 1 : this._recordCount)} of {this._recordCount}";
  }

  private void FormatResultSet()
  {
    int num = this.InvoiceOption_InvoicesSelectedForPrinting.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      int integer = Conversions.ToInteger(this.InvoiceOption_InvoicesSelectedForPrinting[index]);
      if (this.dsInvoices.InvoiceLookup.FindBySystemInvoiceNumber(integer) != null)
        this.dsInvoices.InvoiceLookup.FindBySystemInvoiceNumber(integer).Print = true;
    }
    if (!((UltraToggleEditorBase) this.chkShowVoids).Checked)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugInvoices).Rows)
    {
      Conversions.ToInteger(row.Cells["SystemInvoiceNumber"].Value);
      if (Conversions.ToBoolean(row.Cells["Failed"].Value))
      {
        row.CellAppearance.ForeColor = Color.Red;
        row.CellAppearance.FontData.Strikeout = (DefaultableBoolean) 1;
      }
    }
  }

  private int FirstRecordOfLastSet() => this._recordCount - this._recordCount % 100;

  private static bool IsCompletelyNumeric(string stringToValidate)
  {
    int num = stringToValidate.Length - 1;
    bool flag;
    for (int index = 0; index <= num; ++index)
    {
      if (!char.IsDigit(stringToValidate[index]))
      {
        flag = false;
        goto label_6;
      }
    }
    flag = true;
label_6:
    return flag;
  }

  private bool ValidateForm()
  {
    bool flag = true;
    if (((TextEditorControlBase) this.txtInvoiceNumber).Text.Length > 0 && !frmInvoiceLookup.IsCompletelyNumeric(((TextEditorControlBase) this.txtInvoiceNumber).Text))
    {
      flag = false;
      this.err.SetError((Control) this.txtInvoiceNumber, "Must be numeric");
    }
    else
      this.err.SetError((Control) this.txtInvoiceNumber, string.Empty);
    if (((TextEditorControlBase) this.txtInvoiceNumberFrom).Text.Length > 0 && !frmInvoiceLookup.IsCompletelyNumeric(((TextEditorControlBase) this.txtInvoiceNumberFrom).Text))
    {
      flag = false;
      this.err.SetError((Control) this.txtInvoiceNumberFrom, "Must be numeric");
    }
    else
      this.err.SetError((Control) this.txtInvoiceNumberFrom, string.Empty);
    if (((TextEditorControlBase) this.txtInvoiceNumberTo).Text.Length > 0 && !frmInvoiceLookup.IsCompletelyNumeric(((TextEditorControlBase) this.txtInvoiceNumberTo).Text))
    {
      flag = false;
      this.err.SetError((Control) this.txtInvoiceNumberTo, "Must be numeric");
    }
    else
      this.err.SetError((Control) this.txtInvoiceNumberTo, string.Empty);
    if (((TextEditorControlBase) this.txtQuoteControlNumber).Text.Length > 0 && !frmInvoiceLookup.IsCompletelyNumeric(((TextEditorControlBase) this.txtQuoteControlNumber).Text))
    {
      flag = false;
      this.err.SetError((Control) this.txtQuoteControlNumber, "Must be numeric");
    }
    else
      this.err.SetError((Control) this.txtQuoteControlNumber, string.Empty);
    if (((TextEditorControlBase) this.txtQuoteControlNumberFrom).Text.Length > 0 && !frmInvoiceLookup.IsCompletelyNumeric(((TextEditorControlBase) this.txtQuoteControlNumberFrom).Text))
    {
      flag = false;
      this.err.SetError((Control) this.txtQuoteControlNumberFrom, "Must be numeric");
    }
    else
      this.err.SetError((Control) this.txtQuoteControlNumberFrom, string.Empty);
    if (((TextEditorControlBase) this.txtQuoteControlNumberTo).Text.Length > 0 && !frmInvoiceLookup.IsCompletelyNumeric(((TextEditorControlBase) this.txtQuoteControlNumberTo).Text))
    {
      flag = false;
      this.err.SetError((Control) this.txtQuoteControlNumberTo, "Must be numeric");
    }
    else
      this.err.SetError((Control) this.txtQuoteControlNumberTo, string.Empty);
    return flag;
  }

  private void GetNextRecordSet()
  {
    if (this._currentStartingRecord + 100 > this._recordCount)
    {
      this._currentStartingRecord = this._recordCount - this._recordCount % 100;
    }
    else
    {
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = ^(local = ref this._currentStartingRecord) + 100;
      local = num;
    }
    this.GetRecords();
  }

  private void GetPreviousRecordSet()
  {
    if (this._currentStartingRecord - 100 < 0)
    {
      this._currentStartingRecord = 0;
    }
    else
    {
      // ISSUE: variable of a reference type
      int& local;
      // ISSUE: explicit reference operation
      int num = ^(local = ref this._currentStartingRecord) - 100;
      local = num;
    }
    this.GetRecords();
  }

  private void GetFirstRecordSet()
  {
    this._currentStartingRecord = 1;
    this.GetRecords();
  }

  private void GetLastRecordSet()
  {
    this._currentStartingRecord = this._recordCount - this._recordCount % 100;
    this.GetRecords();
  }

  private void GetRecords()
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((Control) this.panelPleaseWait).Visible = true;
    this.dsInvoices.Clear();
    if (!this._da.SelectCommand.Parameters.Contains("@FromRecord"))
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@FromRecord", (object) this._currentStartingRecord);
    else
      this._da.SelectCommand.Parameters["@FromRecord"].Value = (object) this._currentStartingRecord;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Save((Stream) this._gridLayout);
    ((UltraGridBase) this.ugInvoices).DataSource = (object) null;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetRecordsThread));
  }

  private void GetRecordsThread(object state)
  {
    DefaultDatabase.DataAdapterFill(this._da, (DataTable) this.dsInvoices.InvoiceLookup);
    if (this.IsDisposed || this.Disposing)
      return;
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.GetRecordsThreadComplete), new object[0]);
  }

  private void GetRecordsThreadComplete()
  {
    ((UltraGridBase) this.ugInvoices).DataSource = (object) this.dsInvoices.InvoiceLookup;
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.ugInvoices).DisplayLayout.Load((Stream) this._gridLayout);
    ((UltraGridBase) this.ugInvoices).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    if (this._currentStartingRecord == 1)
    {
      ((Control) this.btnPrev).Enabled = false;
      ((Control) this.btnFirst).Enabled = false;
    }
    else
    {
      ((Control) this.btnPrev).Enabled = true;
      ((Control) this.btnFirst).Enabled = true;
    }
    if (this._currentStartingRecord + 100 > this._recordCount)
    {
      ((Control) this.btnNext).Enabled = false;
      ((Control) this.btnLast).Enabled = false;
    }
    else
    {
      ((Control) this.btnNext).Enabled = true;
      ((Control) this.btnLast).Enabled = true;
    }
    this.SetStatusText();
    this.FormatResultSet();
    ((Control) this.btnSearch).Enabled = true;
    ((Control) this.panelPleaseWait).Visible = false;
    this.Cursor = MgaCursors.Default;
  }

  protected dsInvoiceSearchResults dsInvoices => this._dsInvoices;

  private void frmInvoiceLookup_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.cmChangeDateIssued.Enabled = SecurityManager.Instance.AssertPermission("{A9DE0B71-3010-4e2a-A96D-658C42CC12DD}");
    Utility.SetDataAdapterConnections(this._da, DefaultDatabase.CreateDbConnection(), (DbTransaction) null);
    ImageCache instance = ImageCache.Instance;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) instance.Search;
    ((ControlBase) this.btnFirst).Appearance.Image = (object) instance.MoveFirst;
    ((ControlBase) this.btnPrev).Appearance.Image = (object) instance.MovePrev;
    ((ControlBase) this.btnNext).Appearance.Image = (object) instance.MoveNext;
    ((ControlBase) this.btnLast).Appearance.Image = (object) instance.MoveLast;
    ((ControlBase) this.btnReset).Appearance.Image = (object) instance.Refresh;
    ((ControlBase) this.btnPrintSelectedInvoices).Appearance.Image = (object) instance.PrintSelectedDocuments;
    ((ControlBase) this.btnPrintAllReturnedInvoices).Appearance.Image = (object) instance.PrintAllDocuments;
    this.FillCompanies();
    this.FillUnderwriters();
    this.FillLines();
    this.PopulateDocFoldersTree();
    this.ResetForm();
  }

  private void FillUnderwriters()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT LastName + @C + FirstName AS [Name], UserGuid FROM tblUsers ORDER BY LastName", new object[2]
    {
      (object) "@C",
      (object) ", "
    });
    DataRow row = dataTable.NewRow();
    row[0] = (object) "All Underwriters";
    row[1] = (object) Guid.Empty;
    dataTable.Rows.InsertAt(row, 0);
    MGASimpleComboBox cboUnderwriter = this.cboUnderwriter;
    ((UltraDropDownBase) cboUnderwriter).DisplayMember = "Name";
    ((UltraDropDownBase) cboUnderwriter).ValueMember = "UserGUID";
    ((UltraGridBase) cboUnderwriter).DataSource = (object) dataTable;
  }

  private void FillCompanies()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Location, OfficeID FROM tblClientOffices WHERE    CASE WHEN exists(select OfficeGuid from  tblUserQuotingOffice where UserGuid = @CurrentUserGuid)    THEN         CASE WHEN exists(select OfficeGuid from  tblUserQuotingOffice where UserGuid = @CurrentUserGuid and tblClientOffices.OfficeGUID=tblUserQuotingOffice.OfficeGuid)         THEN 1 ELSE 0 END     ELSE 1 END = 1 ORDER BY Location", new object[2]
    {
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) from tblUserQuotingOffice where UserGuid = @CurrentUserGuid", new object[2]
    {
      (object) "@CurrentUserGuid",
      (object) CurrentUser.Instance.UserGUID
    }) == 0)
    {
      DataRow row = dataTable.NewRow();
      row[0] = (object) "All Companies";
      row[1] = (object) -1;
      dataTable.Rows.InsertAt(row, 0);
    }
    MGASimpleComboBox cboOffice = this.cboOffice;
    ((UltraGridBase) cboOffice).DataSource = (object) dataTable;
    ((UltraDropDownBase) cboOffice).DisplayMember = "Location";
    ((UltraDropDownBase) cboOffice).ValueMember = "OfficeID";
  }

  private void FillLines()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT LineGuid, LineName FROM lstLines ORDER BY LineName");
    DataRow row = dataTable.NewRow();
    row[0] = (object) Guid.Empty;
    row[1] = (object) "All Lines";
    dataTable.Rows.InsertAt(row, 0);
    MGASimpleComboBox cboLine = this.cboLine;
    ((UltraDropDownBase) cboLine).DisplayMember = "LineName";
    ((UltraDropDownBase) cboLine).ValueMember = "LineGuid";
    ((UltraGridBase) cboLine).DataSource = (object) dataTable;
  }

  private void lnkInsured_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (frmSelection frmSelection = new frmSelection((frmSelection.SelectionTypes) 4, true))
    {
      int num = (int) ((Form) frmSelection).ShowDialog();
      this._insuredLocationGuid = frmSelection.SelectedGuid;
      ((TextEditorControlBase) this.txtInsured).Text = frmSelection.SelectedText;
    }
  }

  private void lnkProducer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (frmSelection frmSelection = new frmSelection((frmSelection.SelectionTypes) 1, true))
    {
      int num = (int) ((Form) frmSelection).ShowDialog();
      this._producerLocationGuid = frmSelection.SelectedGuid;
      ((TextEditorControlBase) this.txtProducer).Text = frmSelection.SelectedText;
    }
  }

  private void lnkCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    using (frmSelection frmSelection = new frmSelection((frmSelection.SelectionTypes) 2, true))
    {
      int num = (int) ((Form) frmSelection).ShowDialog();
      this._companyLocationGuid = frmSelection.SelectedGuid;
      ((TextEditorControlBase) this.txtCompany).Text = frmSelection.SelectedText;
    }
  }

  private void ugInvoices_AfterRowActivate(object sender, EventArgs e)
  {
    ((UltraGridBase) this.ugInvoices).ActiveRow.Selected = true;
  }

  private void ugInvoices_DoubleClick(object sender, EventArgs e)
  {
    if (!this._clickedRow)
      return;
    if (((UltraGridBase) this.ugInvoices).ActiveRow == null)
    {
      int num = (int) MessageBox.Show("Please select an invoice", "Select Invoice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      this.showSelectedInvoiceReport(Conversions.ToInteger(((UltraGridBase) this.ugInvoices).ActiveRow.Cells["SystemInvoiceNumber"].Value));
  }

  private void ugInvoices_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right && e.Button != MouseButtons.Left)
      return;
    UIElement uiElement = ((UIElement) ((UltraGridBase) this.ugInvoices).DisplayLayout.UIElement).ElementFromPoint(new Point(e.X, e.Y));
    if (uiElement is RowUIElement)
      return;
    UIElement ancestor = uiElement.GetAncestor(typeof (RowUIElement));
    if (ancestor != null)
    {
      RowUIElement rowUiElement = (RowUIElement) ancestor;
      rowUiElement.Row.Selected = true;
      rowUiElement.Row.Activated = true;
      if (e.Button == MouseButtons.Right)
      {
        this.cmPrintInvoice.Enabled = true;
        this.cmViewInvoice.Enabled = true;
      }
      else
      {
        if (e.Button != MouseButtons.Left)
          return;
        this._clickedRow = true;
      }
    }
    else if (e.Button == MouseButtons.Right)
    {
      this.cmPrintInvoice.Enabled = false;
      this.cmViewInvoice.Enabled = false;
    }
    else
    {
      if (e.Button != MouseButtons.Left)
        return;
      this._clickedRow = false;
    }
  }

  private void ugInvoices_MouseUp(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Left || !(((UIElement) ((UltraGridBase) this.ugInvoices).DisplayLayout.UIElement).ElementFromPoint(new Point(e.X, e.Y)) is CheckIndicatorUIElement))
      return;
    if (!this.dsInvoices.InvoiceLookup.FindBySystemInvoiceNumber(this.InvoiceOption_CurrentlySelectedInvoice).Print)
      this.InvoiceOption_InvoicesSelectedForPrinting.Add((object) this.InvoiceOption_CurrentlySelectedInvoice);
    else if (this.dsInvoices.InvoiceLookup.FindBySystemInvoiceNumber(this.InvoiceOption_CurrentlySelectedInvoice).Print)
      this.InvoiceOption_InvoicesSelectedForPrinting.Remove((object) this.InvoiceOption_CurrentlySelectedInvoice);
    this.dsInvoices.InvoiceLookup.FindBySystemInvoiceNumber(this.InvoiceOption_CurrentlySelectedInvoice).Print = !this.dsInvoices.InvoiceLookup.FindBySystemInvoiceNumber(this.InvoiceOption_CurrentlySelectedInvoice).Print;
    if (this.InvoiceOption_InvoicesSelectedForPrinting.Count <= 0)
      return;
    this.InvoiceOption_InvoicesSelectedForPrinting.Sort();
  }

  protected virtual void SetSelectParameters()
  {
    DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@NumberOfRecords", (object) 100);
    if (((UltraDateTimeEditor) this.dtpInvoiceFrom).Value != null)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@InvoiceDateFrom", RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpInvoiceFrom).Value));
    if (((UltraDateTimeEditor) this.dtpInvoiceTo).Value != null)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@InvoiceDateTo", RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpInvoiceTo).Value));
    if (((UltraDateTimeEditor) this.dtpDueDateFrom).Value != null)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@InvoiceDueDateFrom", RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpDueDateFrom).Value));
    if (((UltraDateTimeEditor) this.dtpDueDateTo).Value != null)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@InvoiceDueDateTo", RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpDueDateTo).Value));
    if (((UltraDateTimeEditor) this.dtpPrintDateFrom).Value != null)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@InvoicePrintDateFrom", RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpPrintDateFrom).Value));
    if (((UltraDateTimeEditor) this.dtpPrintDateTo).Value != null)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@InvoicePrintDateTo", RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpPrintDateTo).Value));
    if (((TextEditorControlBase) this.txtInvoiceNumber).Text.Length > 0)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@OfficeInvoiceNumber", (object) ((TextEditorControlBase) this.txtInvoiceNumber).Text);
    if (((TextEditorControlBase) this.txtQuoteControlNumber).Text.Length > 0)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@QuoteControlNum", (object) ((TextEditorControlBase) this.txtQuoteControlNumber).Text);
    if (this.cboOffice.SelectedIndex > 0)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@GLCompanyID", (object) Conversions.ToInteger(((UltraCombo) this.cboOffice).Value));
    if (!this._insuredLocationGuid.Equals(Guid.Empty))
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@InsuredLocationGuid", (object) this._insuredLocationGuid);
    if (!this._producerLocationGuid.Equals(Guid.Empty))
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@ProducerLocationGuid", (object) this._producerLocationGuid);
    if (!((Guid) ((UltraCombo) this.cboUnderwriter).Value).Equals(Guid.Empty))
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@UnderwriterUserGuid", (object) (Guid) ((UltraCombo) this.cboUnderwriter).Value);
    if (((TextEditorControlBase) this.txtInvoiceNumberFrom).Text.Length > 0)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@FromOfficeInvoiceNumber", (object) ((TextEditorControlBase) this.txtInvoiceNumberFrom).Text);
    if (((TextEditorControlBase) this.txtInvoiceNumberTo).Text.Length > 0)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@ToOfficeInvoiceNumber", (object) ((TextEditorControlBase) this.txtInvoiceNumberTo).Text);
    if (((TextEditorControlBase) this.txtQuoteControlNumberFrom).Text.Length > 0)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@FromQuoteControlNum", (object) ((TextEditorControlBase) this.txtQuoteControlNumberFrom).Text);
    if (((TextEditorControlBase) this.txtQuoteControlNumberTo).Text.Length > 0)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@ToQuoteControlNum", (object) ((TextEditorControlBase) this.txtQuoteControlNumberTo).Text);
    if (((TextEditorControlBase) this.txtPolicyNumber).Text.Length > 0)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@PolicyNumber", (object) ((TextEditorControlBase) this.txtPolicyNumber).Text);
    if (((UltraToggleEditorBase) this.chkShowVoids).Checked)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@ShowVoids", (object) 1);
    if (((UltraToggleEditorBase) this.chkHideFutureInvoices).Checked)
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@HideFutureInvoices", (object) 1);
    if (!this._companyLocationGuid.Equals(Guid.Empty))
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@CompanyLocationGuid", (object) this._companyLocationGuid);
    if (((Guid) ((UltraCombo) this.cboLine).Value).Equals(Guid.Empty))
      return;
    DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@LineGuid", (object) (Guid) ((UltraCombo) this.cboLine).Value);
  }

  protected void AddControlToSearchCriteriaBox(ref Control control)
  {
    ((Control) this.gbSearchCriteria).Controls.Add(control);
  }

  private void btnSearch_Click(object sender, EventArgs e) => this.Search();

  protected virtual void Search()
  {
    if (this.ValidateForm())
    {
      ((Control) this.btnSearch).Enabled = false;
      ((Control) this.panelPleaseWait).Visible = true;
      this.dsInvoices.Clear();
      this._da.SelectCommand.Parameters.Clear();
      this._invoiceNumbersToPrint.Clear();
      this._currentStartingRecord = 1;
      this.SetSelectParameters();
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@SearchTime", (object) DefaultDatabase.ExecuteScalar<DateTime>(CommandType.Text, "SELECT GETDATE()"));
      DbParameterCollectionExtensions.AddWithValue(this._da.SelectCommand.Parameters, "@GetCount", (object) 1);
      ArrayList state = new ArrayList();
      try
      {
        foreach (DbParameter parameter in this._da.SelectCommand.Parameters)
        {
          state.Add((object) parameter.ParameterName);
          state.Add(RuntimeHelpers.GetObjectValue(parameter.Value));
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetRecordCount), (object) state);
    }
    else
      this.lblStatus.Text = string.Empty;
  }

  protected virtual void GetRecordCount(object @params)
  {
    this.selectCommandTimeout = SystemSettings.GetSetting<int>("InvoiceLookupScreen.DefaultCommandTimeout", 30);
    this._recordCount = DefaultDatabase.ExecuteScalar<int>(CommandType.StoredProcedure, "dbo.InvoiceLookup", this.selectCommandTimeout, (CommandArgumentType) 0, ((ArrayList) @params).ToArray());
    if (this.Disposing || this.Disposing)
      return;
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.RecordCountComplete), new object[0]);
  }

  protected void RecordCountComplete()
  {
    this._da.SelectCommand.Parameters.RemoveAt(this._da.SelectCommand.Parameters.Count - 1);
    if (this._recordCount > 0)
    {
      this.GetRecords();
    }
    else
    {
      ((Control) this.panelPleaseWait).Visible = false;
      ((Control) this.btnSearch).Enabled = true;
      this.lblStatus.Text = "No Records Found!";
    }
  }

  private void btnReset_Click(object sender, EventArgs e) => this.ResetForm();

  private void btnNext_Click(object sender, EventArgs e) => this.GetNextRecordSet();

  private void btnPrev_Click(object sender, EventArgs e) => this.GetPreviousRecordSet();

  private void btnFirst_Click(object sender, EventArgs e) => this.GetFirstRecordSet();

  private void btnLast_Click(object sender, EventArgs e) => this.GetLastRecordSet();

  private void btnPrintSelectedInvoices_Click(object sender, EventArgs e)
  {
    if (this.InvoiceOption_InvoicesSelectedForPrinting.Count == 0)
    {
      int num = (int) MessageBox.Show("Please check off invoices to print.", "No Invoices Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      this.printSelectedInvoicesReport(this.InvoiceOption_InvoicesSelectedForPrinting);
  }

  private void btnPrintAllReturnedInvoices_Click(object sender, EventArgs e)
  {
    if (this._recordCount == 0)
    {
      int num = (int) MessageBox.Show("No invoices to print.", "No invoices to print.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show($"This will print {this._recordCount.ToString()} invoices.  Are you sure you want to do this?", "Print ALL Invoices?", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
        return;
      this.printAllInvoicesReport();
    }
  }

  private void btnPrintToPdf_Click(object sender, EventArgs e)
  {
    if (this.InvoiceOption_InvoicesSelectedForPrinting.Count == 0)
    {
      int num = (int) MessageBox.Show("Please check off invoices to print.", "No Invoices Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (this.FolderBrowserDialog1.ShowDialog() != DialogResult.OK)
        return;
      this.saveSelectedInvoicesReportPDF(this.InvoiceOption_InvoicesSelectedForPrinting, this.FolderBrowserDialog1.SelectedPath);
    }
  }

  private void PrintInvoice(int invoiceNumber)
  {
    if (this.InvoiceOption_CurrentlySelectedInvoice == -1)
    {
      int num = (int) MessageBox.Show("No invoice selected.", "No Invoice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      this.printSelectedInvoiceReport(invoiceNumber);
  }

  private void ShowInvoice(int invoiceNumber)
  {
    if (this.InvoiceOption_CurrentlySelectedInvoice == -1)
    {
      int num = (int) MessageBox.Show("No invoice selected.", "No Invoice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
      this.showSelectedInvoiceReport(invoiceNumber);
  }

  protected virtual void printSelectedInvoiceReport(int invoiceNumber)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ArrayList arrayList = new ArrayList();
    int num = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) this.textEdDocFolders).Tag.ToString(), "none", false) == 0 ? -1 : Conversions.ToInteger(((Control) this.textEdDocFolders).Tag.ToString());
    if (this.InvoiceOption_Both)
    {
      InvoiceItem[] invoiceItemArray = new InvoiceItem[2];
      arrayList.AddRange((ICollection) new object[4]
      {
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments,
        (object) "MGACopy",
        (object) true
      });
      invoiceItemArray[0] = new InvoiceItem(invoiceNumber, arrayList);
      arrayList.Clear();
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments
      });
      invoiceItemArray[1] = new InvoiceItem(invoiceNumber, arrayList);
      if (num >= 0)
        ReportFactory.Instance.PrintInvoices(invoiceItemArray, false, num);
      else
        ReportFactory.Instance.PrintInvoices(invoiceItemArray, false);
    }
    else
    {
      InvoiceItem[] invoiceItemArray = new InvoiceItem[1];
      arrayList.AddRange((ICollection) new object[4]
      {
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments,
        (object) "MGACopy",
        (object) this.InvoiceOption_MGACopy
      });
      invoiceItemArray[0] = new InvoiceItem(invoiceNumber, arrayList);
      if (num >= 0)
        ReportFactory.Instance.PrintInvoices(invoiceItemArray, false, num);
      else
        ReportFactory.Instance.PrintInvoices(invoiceItemArray, false);
    }
    this.Cursor = MgaCursors.Default;
  }

  protected virtual void printAllInvoicesReport()
  {
    this.Cursor = MgaCursors.WaitCursor;
    try
    {
      ArrayList arrayList = new ArrayList();
      int num1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) this.textEdDocFolders).Tag.ToString(), "none", false) == 0 ? -1 : Conversions.ToInteger(((Control) this.textEdDocFolders).Tag.ToString());
      if (this.InvoiceOption_Both)
      {
        InvoiceItem[] invoiceItemArray = new InvoiceItem[this.dsInvoices.InvoiceLookup.Rows.Count * 2 - 1 + 1];
        int num2 = this.dsInvoices.InvoiceLookup.Rows.Count - 1;
        for (int index = 0; index <= num2; ++index)
        {
          arrayList.AddRange((ICollection) new object[4]
          {
            (object) "ShowMultipleInvoices",
            (object) this.InvoiceOption_ShowInstallments,
            (object) "MGACopy",
            (object) true
          });
          invoiceItemArray[index * 2] = new InvoiceItem(this.dsInvoices.InvoiceLookup[index].SystemInvoiceNumber, arrayList);
          arrayList.Clear();
          arrayList.AddRange((ICollection) new object[2]
          {
            (object) "ShowMultipleInvoices",
            (object) this.InvoiceOption_ShowInstallments
          });
          invoiceItemArray[index * 2 + 1] = new InvoiceItem(this.dsInvoices.InvoiceLookup[index].SystemInvoiceNumber, arrayList);
        }
        if (num1 >= 0)
          ReportFactory.Instance.PrintInvoices(invoiceItemArray, false, num1);
        else
          ReportFactory.Instance.PrintInvoices(invoiceItemArray, false);
      }
      else
      {
        InvoiceItem[] invoiceItemArray = new InvoiceItem[this.dsInvoices.InvoiceLookup.Rows.Count - 1 + 1];
        int num3 = this.dsInvoices.InvoiceLookup.Rows.Count - 1;
        for (int index = 0; index <= num3; ++index)
        {
          arrayList.AddRange((ICollection) new object[4]
          {
            (object) "ShowMultipleInvoices",
            (object) this.InvoiceOption_ShowInstallments,
            (object) "MGACopy",
            (object) this.InvoiceOption_MGACopy
          });
          invoiceItemArray[index] = new InvoiceItem(this.dsInvoices.InvoiceLookup[index].SystemInvoiceNumber, arrayList);
        }
        if (num1 >= 0)
          ReportFactory.Instance.PrintInvoices(invoiceItemArray, false, num1);
        else
          ReportFactory.Instance.PrintInvoices(invoiceItemArray, false);
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void printSelectedInvoicesReport(ArrayList invoices)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ArrayList arrayList = new ArrayList();
    int num1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) this.textEdDocFolders).Tag.ToString(), "none", false) == 0 ? -1 : Conversions.ToInteger(((Control) this.textEdDocFolders).Tag.ToString());
    if (this.InvoiceOption_Both)
    {
      InvoiceItem[] invoiceItemArray = new InvoiceItem[invoices.Count * 2 - 1 + 1];
      int num2 = invoices.Count - 1;
      for (int index = 0; index <= num2; ++index)
      {
        arrayList.AddRange((ICollection) new object[4]
        {
          (object) "ShowMultipleInvoices",
          (object) this.InvoiceOption_ShowInstallments,
          (object) "MGACopy",
          (object) true
        });
        invoiceItemArray[index * 2] = new InvoiceItem(Conversions.ToInteger(invoices[index]), arrayList);
        arrayList.Clear();
        arrayList.AddRange((ICollection) new object[2]
        {
          (object) "ShowMultipleInvoices",
          (object) this.InvoiceOption_ShowInstallments
        });
        invoiceItemArray[index * 2 + 1] = new InvoiceItem(Conversions.ToInteger(invoices[index]), arrayList);
      }
      if (num1 >= 0)
        ReportFactory.Instance.PrintInvoices(invoiceItemArray, true, num1);
      else
        ReportFactory.Instance.PrintInvoices(invoiceItemArray, true);
    }
    else
    {
      InvoiceItem[] invoiceItemArray = new InvoiceItem[invoices.Count - 1 + 1];
      int num3 = invoices.Count - 1;
      for (int index = 0; index <= num3; ++index)
      {
        arrayList.AddRange((ICollection) new object[4]
        {
          (object) "ShowMultipleInvoices",
          (object) this.InvoiceOption_ShowInstallments,
          (object) "MGACopy",
          (object) this.InvoiceOption_MGACopy
        });
        invoiceItemArray[index] = new InvoiceItem(Conversions.ToInteger(invoices[index]), arrayList);
      }
      if (num1 >= 0)
        ReportFactory.Instance.PrintInvoices(invoiceItemArray, true, num1);
      else
        ReportFactory.Instance.PrintInvoices(invoiceItemArray, true);
    }
    this.Cursor = MgaCursors.Default;
  }

  protected virtual void saveSelectedInvoicesReportPDF(ArrayList invoices, string FilePath)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ArrayList arrayList = new ArrayList();
    int num1 = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) this.textEdDocFolders).Tag.ToString(), "none", false) == 0 ? -1 : Conversions.ToInteger(((Control) this.textEdDocFolders).Tag.ToString());
    if (this.InvoiceOption_Both)
    {
      InvoiceItem[] invoiceItemArray = new InvoiceItem[invoices.Count * 2 - 1 + 1];
      int num2 = invoices.Count - 1;
      for (int index = 0; index <= num2; ++index)
      {
        arrayList.AddRange((ICollection) new object[4]
        {
          (object) "ShowMultipleInvoices",
          (object) this.InvoiceOption_ShowInstallments,
          (object) "MGACopy",
          (object) true
        });
        invoiceItemArray[index * 2] = new InvoiceItem(Conversions.ToInteger(invoices[index]), arrayList);
        arrayList.Clear();
        arrayList.AddRange((ICollection) new object[2]
        {
          (object) "ShowMultipleInvoices",
          (object) this.InvoiceOption_ShowInstallments
        });
        invoiceItemArray[index * 2 + 1] = new InvoiceItem(Conversions.ToInteger(invoices[index]), arrayList);
      }
      ReportFactory.Instance.SaveInvoicesPDF(invoiceItemArray, FilePath, num1);
    }
    else
    {
      InvoiceItem[] invoiceItemArray = new InvoiceItem[invoices.Count - 1 + 1];
      int num3 = invoices.Count - 1;
      for (int index = 0; index <= num3; ++index)
      {
        arrayList.AddRange((ICollection) new object[4]
        {
          (object) "ShowMultipleInvoices",
          (object) this.InvoiceOption_ShowInstallments,
          (object) "MGACopy",
          (object) this.InvoiceOption_MGACopy
        });
        invoiceItemArray[index] = new InvoiceItem(Conversions.ToInteger(invoices[index]), arrayList);
      }
      ReportFactory.Instance.SaveInvoicesPDF(invoiceItemArray, FilePath, num1);
    }
    this.Cursor = MgaCursors.Default;
  }

  protected virtual void showSelectedInvoiceReport(int invoiceNumber)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ArrayList arrayList = new ArrayList();
    if (this.InvoiceOption_Both)
    {
      InvoiceItem[] invoiceItemArray = new InvoiceItem[2];
      arrayList.AddRange((ICollection) new object[4]
      {
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments,
        (object) "MGACopy",
        (object) true
      });
      invoiceItemArray[0] = new InvoiceItem(invoiceNumber, arrayList);
      arrayList.Clear();
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments
      });
      invoiceItemArray[1] = new InvoiceItem(invoiceNumber, arrayList);
      ReportFactory.Instance.ShowInvoices(invoiceItemArray);
    }
    else
    {
      InvoiceItem[] invoiceItemArray = new InvoiceItem[1];
      arrayList.AddRange((ICollection) new object[4]
      {
        (object) "ShowMultipleInvoices",
        (object) this.InvoiceOption_ShowInstallments,
        (object) "MGACopy",
        (object) this.InvoiceOption_MGACopy
      });
      invoiceItemArray[0] = new InvoiceItem(invoiceNumber, arrayList);
      ReportFactory.Instance.ShowInvoices(invoiceItemArray);
    }
    this.Cursor = MgaCursors.Default;
  }

  protected bool InvoiceOption_MGACopy => this.rbMGACopy.Checked;

  protected bool InvoiceOption_Both => this.rbBoth.Checked;

  protected bool InvoiceOption_ShowInstallments
  {
    get => ((UltraToggleEditorBase) this.chkShowInstallments).Checked;
  }

  protected int InvoiceOption_CurrentlySelectedInvoice
  {
    get
    {
      return this.ugInvoices.Selected.Rows.Count == 0 ? -1 : (int) this.ugInvoices.Selected.Rows[0].Cells["SystemInvoiceNumber"].Value;
    }
  }

  protected ArrayList InvoiceOption_InvoicesSelectedForPrinting => this._invoiceNumbersToPrint;

  private void cmPrintInvoice_Click(object sender, EventArgs e)
  {
    this.PrintInvoice(this.InvoiceOption_CurrentlySelectedInvoice);
  }

  private void cmViewInvoice_Click(object sender, EventArgs e)
  {
    this.ShowInvoice(this.InvoiceOption_CurrentlySelectedInvoice);
  }

  private void mnuViewPolicy_Click(object sender, EventArgs e)
  {
    FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) (int) this.ugInvoices.Selected.Rows[0].Cells["QuoteControlNum"].Value
    });
  }

  private void cmChangeDateIssued_Click(object sender, EventArgs e)
  {
    using (frmChangeInvoiceIssuedDate invoiceIssuedDate = new frmChangeInvoiceIssuedDate((int) this.ugInvoices.Selected.Rows[0].Cells["SystemInvoiceNumber"].Value))
    {
      int num = (int) invoiceIssuedDate.ShowDialog();
    }
  }

  private void cmEmailInvoice_Click(object sender, EventArgs e)
  {
    if (this.InvoiceOption_CurrentlySelectedInvoice == -1)
    {
      int num = (int) MessageBox.Show("No invoice selected.", "No Invoice", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        this.EmailInvoices(false);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ErrorHandler.HandleError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }

  private void EmailInvoices(bool EmailAll)
  {
    List<string> stringList1 = new List<string>();
    foreach (UltraGridRow row in ((UltraGridBase) this.ugInvoices).Rows)
    {
      int num1;
      int num2;
      int num3;
      if (!EmailAll)
      {
        num1 = (int) this.ugInvoices.Selected.Rows[0].Cells["SystemInvoiceNumber"].Value;
        num2 = (int) this.ugInvoices.Selected.Rows[0].Cells["QuoteControlNum"].Value;
        num3 = num1;
        if (this.ugInvoices.Selected.Rows[0].Cells["OfficeInvoiceNumber"].Value != DBNull.Value)
          num3 = (int) this.ugInvoices.Selected.Rows[0].Cells["OfficeInvoiceNumber"].Value;
      }
      else
      {
        num1 = (int) row.Cells["SystemInvoiceNumber"].Value;
        num2 = (int) row.Cells["QuoteControlNum"].Value;
        num3 = num1;
        if (row.Cells["OfficeInvoiceNumber"].Value != DBNull.Value)
          num3 = (int) row.Cells["OfficeInvoiceNumber"].Value;
      }
      Quote quote = new Quote(DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT MAX(QuoteID) FROM dbo.tblQuotes WITH (NOLOCK) WHERE ControlNo = @ControlNo", new object[2]
      {
        (object) "@ControlNo",
        (object) num2
      }));
      string str1 = $"Policy #{quote.PolicyNumber} - {quote.InsuredPolicyName}";
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spGetInvoiceEmail", new object[2]
      {
        (object) "@quoteGUID",
        (object) quote.QuoteGuid
      });
      List<string> stringList2 = new List<string>();
      if (dataTable.Rows.Count > 0 && dataTable.Rows[0].ItemArray[0] != DBNull.Value)
        stringList2.Add((string) dataTable.Rows[0].ItemArray[0]);
      Invoice invoice = new Invoice(num1);
      ArrayList arrayList1 = new ArrayList();
      ArrayList arrayList2 = new ArrayList();
      string path;
      string str2;
      if (this.InvoiceOption_Both)
      {
        path = $"MGA Copy Invoice# - {Conversions.ToString(num3)}.pdf";
        str2 = $"Broker Copy Invoice# - {Conversions.ToString(num3)}.pdf";
        arrayList1.AddRange((ICollection) new object[4]
        {
          (object) "ShowMultipleInvoices",
          (object) this.InvoiceOption_ShowInstallments,
          (object) "MGACopy",
          (object) true
        });
        arrayList2.AddRange((ICollection) new object[2]
        {
          (object) "ShowMultipleInvoices",
          (object) this.InvoiceOption_ShowInstallments
        });
      }
      else
      {
        str2 = "";
        arrayList2.AddRange((ICollection) new object[0]);
        if (this.InvoiceOption_MGACopy)
        {
          path = $"MGA Copy Invoice# - {Conversions.ToString(num3)}.pdf";
          arrayList1.AddRange((ICollection) new object[4]
          {
            (object) "ShowMultipleInvoices",
            (object) this.InvoiceOption_ShowInstallments,
            (object) "MGACopy",
            (object) true
          });
        }
        else
        {
          path = $"Broker Copy Invoice# - {Conversions.ToString(num3)}.pdf";
          arrayList1.AddRange((ICollection) new object[2]
          {
            (object) "ShowMultipleInvoices",
            (object) this.InvoiceOption_ShowInstallments
          });
        }
      }
      using (PdfExport pdfExport = new PdfExport())
      {
        using (MemoryStream memoryStream = new MemoryStream())
        {
          pdfExport.Export(invoice.Report(arrayList1).Document, (Stream) memoryStream);
          path = MGATempFolder.MGATempPath + path;
          FileStream fileStream;
          try
          {
            fileStream = new FileStream(path, FileMode.Create);
          }
          catch (IOException ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            int num4 = (int) MessageBox.Show("The invoice PDF could not be attached to an email, because the document is in use.\n\nPlease ensure you do not have this document open in another application.", "Invoice In Use", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            ProjectData.ClearProjectError();
            break;
          }
          try
          {
            memoryStream.WriteTo((Stream) fileStream);
            fileStream.Write(memoryStream.ToArray(), 0, (int) memoryStream.Position);
          }
          finally
          {
            fileStream.Dispose();
          }
        }
        stringList1.Add(path);
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str2, "", false) != 0)
        {
          using (MemoryStream memoryStream = new MemoryStream())
          {
            pdfExport.Export(invoice.Report(arrayList2).Document, (Stream) memoryStream);
            str2 = MGATempFolder.MGATempPath + str2;
            FileStream fileStream;
            try
            {
              fileStream = new FileStream(str2, FileMode.Create);
            }
            catch (IOException ex)
            {
              ProjectData.SetProjectError((Exception) ex);
              int num5 = (int) MessageBox.Show("The invoice PDF could not be attached to an email, because the document is in use.\n\nPlease ensure you do not have this document open in another application.", "Invoice In Use", MessageBoxButtons.OK, MessageBoxIcon.Hand);
              ProjectData.ClearProjectError();
              break;
            }
            try
            {
              memoryStream.WriteTo((Stream) fileStream);
              fileStream.Write(memoryStream.ToArray(), 0, (int) memoryStream.Position);
            }
            finally
            {
              fileStream.Dispose();
            }
          }
          stringList1.Add(str2);
        }
      }
      if (!EmailAll)
      {
        UI.Send(stringList1.ToArray(), stringList2.ToArray(), str1);
        break;
      }
      if (row.ListIndex == ((UltraGridBase) this.ugInvoices).Rows.Count - 1)
        UI.Send(stringList1.ToArray(), stringList2.ToArray(), str1);
    }
  }

  private void btnEmailAll_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.EmailInvoices(true);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleError(ex);
      ProjectData.ClearProjectError();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void PopulateDocFoldersTree()
  {
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT FolderID, FolderName, ParentFolderID FROM dbo.tblDocumentFolders ORDER BY FolderName");
    this.treeDcuFolders.Nodes.Clear();
    UltraTreeNode ultraTreeNode1 = new UltraTreeNode("none", "none");
    ((SubObjectBase) ultraTreeNode1).Tag = (object) "";
    this.treeDcuFolders.Nodes.Add(ultraTreeNode1);
    ((Control) this.textEdDocFolders).Tag = (object) "none";
    int setting = SystemSettings.GetSetting<int>("InvoiceLookup.DefaultFolder", -1);
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        UltraTreeNode ultraTreeNode2 = new UltraTreeNode(Conversions.ToString(row[0]), Conversions.ToString(row[1]));
        if (!row.IsNull(2))
          ((SubObjectBase) ultraTreeNode2).Tag = (object) Conversions.ToString(row[2]);
        else
          ((SubObjectBase) ultraTreeNode2).Tag = (object) "";
        this.treeDcuFolders.Nodes.Add(ultraTreeNode2);
        if (row.Field<int>("FolderID") == setting)
        {
          ((TextEditorControlBase) this.textEdDocFolders).Text = ultraTreeNode2.Text;
          ((Control) this.textEdDocFolders).Tag = (object) setting.ToString();
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    for (int index = this.treeDcuFolders.Nodes.Count - 1; index >= 0; index += -1)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((SubObjectBase) this.treeDcuFolders.Nodes[index]).Tag.ToString(), "", false) != 0)
        this.treeDcuFolders.Nodes[index].Reposition(this.treeDcuFolders.GetNodeByKey(((SubObjectBase) this.treeDcuFolders.Nodes[index]).Tag.ToString()).Nodes);
    }
  }

  private void treeDcuFolders_AfterSelect(object sender, SelectEventArgs e)
  {
    if (((DisposableObjectCollectionBase) e.NewSelections).Count > 0)
    {
      ((TextEditorControlBase) this.textEdDocFolders).Text = e.NewSelections[0].Text;
      ((Control) this.textEdDocFolders).Tag = (object) e.NewSelections[0].Key;
    }
    else
    {
      ((TextEditorControlBase) this.textEdDocFolders).Text = "none";
      ((Control) this.textEdDocFolders).Tag = (object) "none";
    }
    ((EditorButtonControlBase) this.textEdDocFolders).CloseEditorButtonDropDowns();
  }

  private void textEdDocFolders_BeforeEditorButtonDropDown(
    object sender,
    BeforeEditorButtonDropDownEventArgs e)
  {
    this.treeDcuFolders.GetNodeByKey(((Control) this.textEdDocFolders).Tag.ToString()).Selected = true;
  }
}
