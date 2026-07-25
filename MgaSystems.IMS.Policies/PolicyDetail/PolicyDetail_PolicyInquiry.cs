// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.PolicyDetail_PolicyInquiry
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using GrapeCity.ActiveReports;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Extensions;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyDetail;

[PolicyDetail_Plugin("Policy Inquiry", "Policy Inquiry")]
public class PolicyDetail_PolicyInquiry : PolicyDetail_Plugin
{
  private IContainer components;
  private dsPolicyInquiry ds;
  private UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  private UltraTabPageControl UltraTabPageControl1;
  private UltraTabPageControl UltraTabPageControl2;
  private UltraTabPageControl UltraTabPageControl3;
  private UltraTabPageControl tabAccountingNotes;
  private Guid _quoteGuid;
  private readonly CultureInfo _currCultureInfo;
  private readonly bool _currMultiCurrency;
  private readonly bool _implementCurrencyDisplay;
  private bool _ARDataFilled;
  private bool _APDataFilled;
  private MemoryStream _policyARBreakdown;
  private MemoryStream _policyAPBreakdown;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  protected virtual UltraGrid dgInquiry
  {
    get => this._dgInquiry;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.dgInquiry_InitializeRow);
      UltraGrid dgInquiry1 = this._dgInquiry;
      if (dgInquiry1 != null)
        dgInquiry1.InitializeRow -= initializeRowEventHandler;
      this._dgInquiry = value;
      UltraGrid dgInquiry2 = this._dgInquiry;
      if (dgInquiry2 == null)
        return;
      dgInquiry2.InitializeRow += initializeRowEventHandler;
    }
  }

  protected virtual UltraTabControl UltraTabControl1
  {
    get => this._UltraTabControl1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ActiveTabChangedEventHandler changedEventHandler = new ActiveTabChangedEventHandler(this.UltraTabControl1_ActiveTabChanged);
      UltraTabControl ultraTabControl1_1 = this._UltraTabControl1;
      if (ultraTabControl1_1 != null)
        ((UltraTabControlBase) ultraTabControl1_1).ActiveTabChanged -= changedEventHandler;
      this._UltraTabControl1 = value;
      UltraTabControl ultraTabControl1_2 = this._UltraTabControl1;
      if (ultraTabControl1_2 == null)
        return;
      ((UltraTabControlBase) ultraTabControl1_2).ActiveTabChanged += changedEventHandler;
    }
  }

  [field: AccessedThroughProperty("gridARBreakdown")]
  protected virtual UltraGrid gridARBreakdown { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGrid1")]
  protected virtual UltraGrid UltraGrid1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid gridPolicyAPBreakdown
  {
    get => this._gridPolicyAPBreakdown;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.GridPolicyAPBreakdown_InitializeRow);
      UltraGrid policyApBreakdown1 = this._gridPolicyAPBreakdown;
      if (policyApBreakdown1 != null)
        policyApBreakdown1.InitializeRow -= initializeRowEventHandler;
      this._gridPolicyAPBreakdown = value;
      UltraGrid policyApBreakdown2 = this._gridPolicyAPBreakdown;
      if (policyApBreakdown2 == null)
        return;
      policyApBreakdown2.InitializeRow += initializeRowEventHandler;
    }
  }

  [field: AccessedThroughProperty("txtAccountingNote")]
  protected virtual RichTextBox txtAccountingNote { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkPolicyInquiry
  {
    get => this._lnkPolicyInquiry;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPolicyInquiry_LinkClicked);
      LinkLabel lnkPolicyInquiry1 = this._lnkPolicyInquiry;
      if (lnkPolicyInquiry1 != null)
        lnkPolicyInquiry1.LinkClicked -= clickedEventHandler;
      this._lnkPolicyInquiry = value;
      LinkLabel lnkPolicyInquiry2 = this._lnkPolicyInquiry;
      if (lnkPolicyInquiry2 == null)
        return;
      lnkPolicyInquiry2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("spFin_QuoteInvoices", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("InvoiceDate");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DueDate");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("GrossPremium");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Fees");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("NetBilled");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("AmtPTD");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Surplus");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Transaction");
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("spFin_QuoteInvoicesspFin_InvoiceTransactions");
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "GrossPremium", 4, true, "spFin_QuoteInvoices", 0, (SummaryPosition) 3, "GrossPremium", 4, true);
    Appearance appearance19 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "Fees", 5, true, "spFin_QuoteInvoices", 0, (SummaryPosition) 3, "Fees", 5, true);
    Appearance appearance20 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 1, (string) null, "NetBilled", 6, true, "spFin_QuoteInvoices", 0, (SummaryPosition) 3, "NetBilled", 6, true);
    Appearance appearance21 = new Appearance();
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 1, (string) null, "AmtPTD", 7, true, "spFin_QuoteInvoices", 0, (SummaryPosition) 3, "AmtPTD", 7, true);
    Appearance appearance22 = new Appearance();
    SummarySettings summarySettings5 = new SummarySettings("", (SummaryType) 1, (string) null, "Surplus", 8, true, "spFin_QuoteInvoices", 0, (SummaryPosition) 3, "Surplus", 8, true);
    Appearance appearance23 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("spFin_QuoteInvoicesspFin_InvoiceTransactions", 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("TransactNum");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Transdescription");
    Appearance appearance26 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("postDate");
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("user");
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("voided");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("arapplied");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("apapplied");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("exchapplied");
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("unacctapplied");
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("incomeapplied");
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("cashapplied");
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("Check Number");
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    SummarySettings summarySettings6 = new SummarySettings("", (SummaryType) 1, (string) null, "arapplied", 6, true, "spFin_QuoteInvoicesspFin_InvoiceTransactions", 1, (SummaryPosition) 3, "arapplied", 6, true);
    Appearance appearance44 = new Appearance();
    SummarySettings summarySettings7 = new SummarySettings("", (SummaryType) 1, (string) null, "apapplied", 7, true, "spFin_QuoteInvoicesspFin_InvoiceTransactions", 1, (SummaryPosition) 3, "apapplied", 7, true);
    Appearance appearance45 = new Appearance();
    SummarySettings summarySettings8 = new SummarySettings("", (SummaryType) 1, (string) null, "exchapplied", 8, true, "spFin_QuoteInvoicesspFin_InvoiceTransactions", 1, (SummaryPosition) 3, "exchapplied", 8, true);
    Appearance appearance46 = new Appearance();
    SummarySettings summarySettings9 = new SummarySettings("", (SummaryType) 1, (string) null, "unacctapplied", 9, true, "spFin_QuoteInvoicesspFin_InvoiceTransactions", 1, (SummaryPosition) 3, "unacctapplied", 9, true);
    Appearance appearance47 = new Appearance();
    SummarySettings summarySettings10 = new SummarySettings("", (SummaryType) 1, (string) null, "incomeapplied", 10, true, "spFin_QuoteInvoicesspFin_InvoiceTransactions", 1, (SummaryPosition) 3, "incomeapplied", 10, true);
    Appearance appearance48 = new Appearance();
    SummarySettings summarySettings11 = new SummarySettings("", (SummaryType) 1, (string) null, "cashapplied", 11, true, "spFin_QuoteInvoicesspFin_InvoiceTransactions", 1, (SummaryPosition) 3, "cashapplied", 11, true);
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance53 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("Summaries", -1);
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Premium");
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("AIEndorsement");
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("SurchargeFees");
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("OtherFees");
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("CommissionNetOut");
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("DollarsReceived");
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("WriteOffs");
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("Balance");
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    SummarySettings summarySettings12 = new SummarySettings("", (SummaryType) 1, (string) null, "Premium", 1, true, "Summaries", 0, (SummaryPosition) 3, "Premium", 1, true);
    Appearance appearance71 = new Appearance();
    SummarySettings summarySettings13 = new SummarySettings("", (SummaryType) 1, (string) null, "AIEndorsement", 2, true, "Summaries", 0, (SummaryPosition) 3, "AIEndorsement", 2, true);
    Appearance appearance72 = new Appearance();
    SummarySettings summarySettings14 = new SummarySettings("", (SummaryType) 1, (string) null, "SurchargeFees", 3, true, "Summaries", 0, (SummaryPosition) 3, "SurchargeFees", 3, true);
    Appearance appearance73 = new Appearance();
    SummarySettings summarySettings15 = new SummarySettings("", (SummaryType) 1, (string) null, "OtherFees", 4, true, "Summaries", 0, (SummaryPosition) 3, "OtherFees", 4, true);
    Appearance appearance74 = new Appearance();
    SummarySettings summarySettings16 = new SummarySettings("", (SummaryType) 1, (string) null, "CommissionNetOut", 5, true, "Summaries", 0, (SummaryPosition) 3, "CommissionNetOut", 5, true);
    Appearance appearance75 = new Appearance();
    SummarySettings summarySettings17 = new SummarySettings("", (SummaryType) 1, (string) null, "DollarsReceived", 6, true, "Summaries", 0, (SummaryPosition) 3, "DollarsReceived", 6, true);
    Appearance appearance76 = new Appearance();
    SummarySettings summarySettings18 = new SummarySettings("", (SummaryType) 1, (string) null, "WriteOffs", 7, true, "Summaries", 0, (SummaryPosition) 3, "WriteOffs", 7, true);
    Appearance appearance77 = new Appearance();
    SummarySettings summarySettings19 = new SummarySettings("", (SummaryType) 1, (string) null, "Balance", 8, true, "Summaries", 0, (SummaryPosition) 3, "Balance", 8, true);
    Appearance appearance78 = new Appearance();
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    Appearance appearance82 = new Appearance();
    Appearance appearance83 = new Appearance();
    Appearance appearance84 = new Appearance();
    Appearance appearance85 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance86 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("spFin_PolicyARBreakdown", -1);
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("InvoiceNumber");
    Appearance appearance87 = new Appearance();
    Appearance appearance88 = new Appearance();
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("InvoiceNum");
    Appearance appearance89 = new Appearance();
    Appearance appearance90 = new Appearance();
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("Premium");
    Appearance appearance91 = new Appearance();
    Appearance appearance92 = new Appearance();
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("AIEndorsement");
    Appearance appearance93 = new Appearance();
    Appearance appearance94 = new Appearance();
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("SurchargeFees");
    Appearance appearance95 = new Appearance();
    Appearance appearance96 = new Appearance();
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("OtherFees");
    Appearance appearance97 = new Appearance();
    Appearance appearance98 = new Appearance();
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("CommissionNetOut");
    Appearance appearance99 = new Appearance();
    Appearance appearance100 = new Appearance();
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("DollarsReceived");
    Appearance appearance101 = new Appearance();
    Appearance appearance102 = new Appearance();
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("WriteOffs");
    Appearance appearance103 = new Appearance();
    Appearance appearance104 = new Appearance();
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("Balance");
    Appearance appearance105 = new Appearance();
    Appearance appearance106 = new Appearance();
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    Appearance appearance109 = new Appearance();
    Appearance appearance110 = new Appearance();
    Appearance appearance111 = new Appearance();
    Appearance appearance112 = new Appearance();
    Appearance appearance113 = new Appearance();
    Appearance appearance114 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance115 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("spFin_PolicyAPBreakdown", -1);
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("InvoiceNum");
    Appearance appearance116 = new Appearance();
    Appearance appearance117 = new Appearance();
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("Remitter");
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("Invoice Number");
    Appearance appearance118 = new Appearance();
    Appearance appearance119 = new Appearance();
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("ProducerLocationGuid");
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("CompanyPayable_Premium");
    Appearance appearance120 = new Appearance();
    Appearance appearance121 = new Appearance();
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("CompanyPayable_Fees");
    Appearance appearance122 = new Appearance();
    Appearance appearance123 = new Appearance();
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("ProducerPayable");
    Appearance appearance124 = new Appearance();
    Appearance appearance125 = new Appearance();
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("MGAPayable_Commission");
    Appearance appearance126 = new Appearance();
    Appearance appearance127 = new Appearance();
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("MGAPayable_Fees");
    Appearance appearance128 = new Appearance();
    Appearance appearance129 = new Appearance();
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("ExchangePayable");
    Appearance appearance130 = new Appearance();
    Appearance appearance131 = new Appearance();
    Appearance appearance132 = new Appearance();
    Appearance appearance133 = new Appearance();
    Appearance appearance134 = new Appearance();
    Appearance appearance135 = new Appearance();
    Appearance appearance136 = new Appearance();
    Appearance appearance137 = new Appearance();
    Appearance appearance138 = new Appearance();
    Appearance appearance139 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance140 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (PolicyDetail_PolicyInquiry));
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance141 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance142 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance143 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.lnkPolicyInquiry = new LinkLabel();
    this.dgInquiry = new UltraGrid();
    this.ds = new dsPolicyInquiry();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.UltraGrid1 = new UltraGrid();
    this.gridARBreakdown = new UltraGrid();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.gridPolicyAPBreakdown = new UltraGrid();
    this.tabAccountingNotes = new UltraTabPageControl();
    this.txtAccountingNote = new RichTextBox();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.dgInquiry).BeginInit();
    this.ds.BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    ((ISupportInitialize) this.gridARBreakdown).BeginInit();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.gridPolicyAPBreakdown).BeginInit();
    ((Control) this.tabAccountingNotes).SuspendLayout();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.lnkPolicyInquiry);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.dgInquiry);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(710, 296);
    this.lnkPolicyInquiry.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.lnkPolicyInquiry.BackColor = Color.Transparent;
    this.lnkPolicyInquiry.Location = new Point(587, 271);
    this.lnkPolicyInquiry.Name = "lnkPolicyInquiry";
    this.lnkPolicyInquiry.Size = new Size(120, 16 /*0x10*/);
    this.lnkPolicyInquiry.TabIndex = 2;
    this.lnkPolicyInquiry.TabStop = true;
    this.lnkPolicyInquiry.Text = "Policy Inquiry Report";
    this.lnkPolicyInquiry.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkPolicyInquiry.Visible = false;
    ((Control) this.dgInquiry).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgInquiry).DataSource = (object) this.ds.spFin_QuoteInvoices;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn3.Format = "d";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Invoice Date";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance6;
    ultraGridColumn4.Format = "d";
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Due";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance8;
    ultraGridColumn5.Format = "c";
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Gross Premium";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance10;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance12;
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Net Billed";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance14;
    ultraGridColumn8.Format = "c";
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance15;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Amt PTD";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance16;
    ultraGridColumn9.Format = "c";
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance17;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridBand1.Columns.AddRange(new object[11]
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
      (object) ultraGridColumn11
    });
    appearance19.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance19).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance19;
    summarySettings1.DisplayFormat = "{0:c}";
    appearance20.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance20;
    summarySettings2.DisplayFormat = "{0:c}";
    appearance21.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance21;
    summarySettings3.DisplayFormat = "{0:c}";
    appearance22.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance22;
    summarySettings4.DisplayFormat = "{0:c}";
    appearance23.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Right";
    summarySettings5.Appearance = (AppearanceBase) appearance23;
    summarySettings5.DisplayFormat = "{0:c}";
    ultraGridBand1.Summaries.AddRange(new SummarySettings[5]
    {
      summarySettings1,
      summarySettings2,
      summarySettings3,
      summarySettings4,
      summarySettings5
    });
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 0;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Right";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance25;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Transact #";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 1;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance26;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 2;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance27;
    ultraGridColumn15.Format = "d";
    ((AppearanceBase) appearance28).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance28;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Post Date";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 3;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 4;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Void";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 5;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ultraGridColumn18.CellAppearance = (AppearanceBase) appearance30;
    ultraGridColumn18.Format = "c";
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "AR";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 6;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Right";
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance32;
    ultraGridColumn19.Format = "c";
    ((AppearanceBase) appearance33).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance33;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "AP";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 7;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Right";
    ultraGridColumn20.CellAppearance = (AppearanceBase) appearance34;
    ultraGridColumn20.Format = "c";
    ((AppearanceBase) appearance35).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn20.Header).Appearance = (AppearanceBase) appearance35;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Exchange";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 8;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Right";
    ultraGridColumn21.CellAppearance = (AppearanceBase) appearance36;
    ultraGridColumn21.Format = "c";
    ((AppearanceBase) appearance37).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn21.Header).Appearance = (AppearanceBase) appearance37;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Unaccounted";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 9;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    ultraGridColumn22.CellAppearance = (AppearanceBase) appearance38;
    ultraGridColumn22.Format = "c";
    ((AppearanceBase) appearance39).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn22.Header).Appearance = (AppearanceBase) appearance39;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Income";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 10;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    ultraGridColumn23.CellAppearance = (AppearanceBase) appearance40;
    ultraGridColumn23.Format = "c";
    ((AppearanceBase) appearance41).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn23.Header).Appearance = (AppearanceBase) appearance41;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Cash";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 11;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Right";
    ultraGridColumn24.CellAppearance = (AppearanceBase) appearance42;
    ((AppearanceBase) appearance43).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn24.Header).Appearance = (AppearanceBase) appearance43;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Check #";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 12;
    ultraGridBand2.Columns.AddRange(new object[13]
    {
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
      (object) ultraGridColumn24
    });
    appearance44.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance44).TextHAlignAsString = "Right";
    summarySettings6.Appearance = (AppearanceBase) appearance44;
    summarySettings6.DisplayFormat = "{0:c}";
    appearance45.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance45).TextHAlignAsString = "Right";
    summarySettings7.Appearance = (AppearanceBase) appearance45;
    summarySettings7.DisplayFormat = "{0:c}";
    appearance46.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance46).TextHAlignAsString = "Right";
    summarySettings8.Appearance = (AppearanceBase) appearance46;
    summarySettings8.DisplayFormat = "{0:c}";
    appearance47.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance47).TextHAlignAsString = "Right";
    summarySettings9.Appearance = (AppearanceBase) appearance47;
    summarySettings9.DisplayFormat = "{0:c}";
    appearance48.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance48).TextHAlignAsString = "Right";
    summarySettings10.Appearance = (AppearanceBase) appearance48;
    summarySettings10.DisplayFormat = "{0:c}";
    appearance49.BackColor = Color.LightYellow;
    ((AppearanceBase) appearance49).TextHAlignAsString = "Right";
    summarySettings11.Appearance = (AppearanceBase) appearance49;
    summarySettings11.DisplayFormat = "{0:c} ";
    ultraGridBand2.Summaries.AddRange(new SummarySettings[6]
    {
      summarySettings6,
      summarySettings7,
      summarySettings8,
      summarySettings9,
      summarySettings10,
      summarySettings11
    });
    ultraGridBand2.SummaryFooterCaption = "Summaries for Invoice #: [SCROLLTIPFIELD]";
    ((UltraGridBase) this.dgInquiry).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgInquiry).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgInquiry).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance50.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance50.ForeColor = Color.Black;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance51.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance51;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance52.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance52;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgInquiry).Location = new Point(0, 0);
    ((Control) this.dgInquiry).Name = "dgInquiry";
    ((Control) this.dgInquiry).Size = new Size(710, 268);
    ((Control) this.dgInquiry).TabIndex = 1;
    ((UltraControlBase) this.dgInquiry).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgInquiry).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsPolicyInquiry";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.UltraGrid1);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.gridARBreakdown);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(710, 296);
    ((UltraGridBase) this.UltraGrid1).DataMember = "Summaries";
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.ds;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraGrid1).DisplayLayout.AddNewBox).Prompt = " ";
    appearance53.BackColor = Color.White;
    appearance53.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance53;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 0;
    ultraGridColumn25.Width = 87;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    ultraGridColumn26.CellAppearance = (AppearanceBase) appearance54;
    ultraGridColumn26.Format = "c";
    ((AppearanceBase) appearance55).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn26.Header).Appearance = (AppearanceBase) appearance55;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 1;
    ultraGridColumn26.Width = 110;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance56).TextHAlignAsString = "Right";
    ultraGridColumn27.CellAppearance = (AppearanceBase) appearance56;
    ultraGridColumn27.Format = "c";
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn27.Header).Appearance = (AppearanceBase) appearance57;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "AI End";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 2;
    ultraGridColumn27.Width = 73;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Right";
    ultraGridColumn28.CellAppearance = (AppearanceBase) appearance58;
    ultraGridColumn28.Format = "c";
    ((AppearanceBase) appearance59).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn28.Header).Appearance = (AppearanceBase) appearance59;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "Surcharge Fees";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 3;
    ultraGridColumn28.Width = 73;
    ultraGridColumn29.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance60).TextHAlignAsString = "Right";
    ultraGridColumn29.CellAppearance = (AppearanceBase) appearance60;
    ultraGridColumn29.Format = "c";
    ((AppearanceBase) appearance61).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn29.Header).Appearance = (AppearanceBase) appearance61;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "Other Fees";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn29.Header.VisiblePosition = 4;
    ultraGridColumn29.Width = 73;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance62).TextHAlignAsString = "Right";
    ultraGridColumn30.CellAppearance = (AppearanceBase) appearance62;
    ultraGridColumn30.Format = "c";
    ((AppearanceBase) appearance63).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn30.Header).Appearance = (AppearanceBase) appearance63;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Comm Net Out";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn30.Header.VisiblePosition = 5;
    ultraGridColumn30.Width = 73;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance64).TextHAlignAsString = "Right";
    ultraGridColumn31.CellAppearance = (AppearanceBase) appearance64;
    ultraGridColumn31.Format = "c";
    ((AppearanceBase) appearance65).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn31.Header).Appearance = (AppearanceBase) appearance65;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Received";
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn31.Header.VisiblePosition = 6;
    ultraGridColumn31.Width = 73;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance66).TextHAlignAsString = "Right";
    ultraGridColumn32.CellAppearance = (AppearanceBase) appearance66;
    ultraGridColumn32.Format = "c";
    ((AppearanceBase) appearance67).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn32.Header).Appearance = (AppearanceBase) appearance67;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "Write Offs";
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn32.Header.VisiblePosition = 7;
    ultraGridColumn32.Width = 73;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance68).TextHAlignAsString = "Right";
    ultraGridColumn33.CellAppearance = (AppearanceBase) appearance68;
    ultraGridColumn33.Format = "c";
    ((AppearanceBase) appearance69).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn33.Header).Appearance = (AppearanceBase) appearance69;
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn33.Header.VisiblePosition = 8;
    ultraGridColumn33.Width = 73;
    ultraGridBand3.Columns.AddRange(new object[9]
    {
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
    ultraGridBand3.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    appearance70.BackColor = Color.FloralWhite;
    ultraGridBand3.Override.SummaryValueAppearance = (AppearanceBase) appearance70;
    ((AppearanceBase) appearance71).TextHAlignAsString = "Right";
    summarySettings12.Appearance = (AppearanceBase) appearance71;
    summarySettings12.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance72).TextHAlignAsString = "Right";
    summarySettings13.Appearance = (AppearanceBase) appearance72;
    summarySettings13.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance73).TextHAlignAsString = "Right";
    summarySettings14.Appearance = (AppearanceBase) appearance73;
    summarySettings14.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance74).TextHAlignAsString = "Right";
    summarySettings15.Appearance = (AppearanceBase) appearance74;
    summarySettings15.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance75).TextHAlignAsString = "Right";
    summarySettings16.Appearance = (AppearanceBase) appearance75;
    summarySettings16.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance76).TextHAlignAsString = "Right";
    summarySettings17.Appearance = (AppearanceBase) appearance76;
    summarySettings17.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance77).TextHAlignAsString = "Right";
    summarySettings18.Appearance = (AppearanceBase) appearance77;
    summarySettings18.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance78).TextHAlignAsString = "Right";
    summarySettings19.Appearance = (AppearanceBase) appearance78;
    summarySettings19.DisplayFormat = "{0:c}";
    ultraGridBand3.Summaries.AddRange(new SummarySettings[8]
    {
      summarySettings12,
      summarySettings13,
      summarySettings14,
      summarySettings15,
      summarySettings16,
      summarySettings17,
      summarySettings18,
      summarySettings19
    });
    ultraGridBand3.SummaryFooterCaption = "";
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance79.BackColor = Color.LightSteelBlue;
    appearance79.FontData.SizeInPoints = 10f;
    appearance79.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance79;
    appearance80.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance80.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance80.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance80;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance81.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance81;
    appearance82.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance82;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance83.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance83;
    appearance84.BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance84;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance85.BackColor = Color.Transparent;
    appearance85.ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance85;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.UltraGrid1).Dock = DockStyle.Bottom;
    ((Control) this.UltraGrid1).Location = new Point(0, 181);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(710, 115);
    ((Control) this.UltraGrid1).TabIndex = 1;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridARBreakdown).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridARBreakdown).DataMember = "spFin_PolicyARBreakdown";
    ((UltraGridBase) this.gridARBreakdown).DataSource = (object) this.ds;
    ((SpecialBoxBase) ((UltraGridBase) this.gridARBreakdown).DisplayLayout.AddNewBox).Prompt = " ";
    appearance86.BackColor = Color.White;
    appearance86.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Appearance = (AppearanceBase) appearance86;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance87).TextHAlignAsString = "Right";
    ultraGridColumn34.CellAppearance = (AppearanceBase) appearance87;
    ((AppearanceBase) appearance88).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn34.Header).Appearance = (AppearanceBase) appearance88;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn34.Header.VisiblePosition = 0;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 131;
    ultraGridColumn35.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance89).TextHAlignAsString = "Right";
    ultraGridColumn35.CellAppearance = (AppearanceBase) appearance89;
    ultraGridColumn35.Format = "";
    ((AppearanceBase) appearance90).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn35.Header).Appearance = (AppearanceBase) appearance90;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn35.Header.VisiblePosition = 1;
    ultraGridColumn35.Width = 85;
    ultraGridColumn36.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance91).TextHAlignAsString = "Right";
    ultraGridColumn36.CellAppearance = (AppearanceBase) appearance91;
    ultraGridColumn36.Format = "c";
    ((AppearanceBase) appearance92).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn36.Header).Appearance = (AppearanceBase) appearance92;
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn36.Header.VisiblePosition = 2;
    ultraGridColumn36.Width = 117;
    ultraGridColumn37.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance93).TextHAlignAsString = "Right";
    ultraGridColumn37.CellAppearance = (AppearanceBase) appearance93;
    ultraGridColumn37.Format = "c";
    ((AppearanceBase) appearance94).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn37.Header).Appearance = (AppearanceBase) appearance94;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "AI End";
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn37.Header.VisiblePosition = 3;
    ultraGridColumn37.Width = 70;
    ultraGridColumn38.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance95).TextHAlignAsString = "Right";
    ultraGridColumn38.CellAppearance = (AppearanceBase) appearance95;
    ultraGridColumn38.Format = "c";
    ((AppearanceBase) appearance96).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn38.Header).Appearance = (AppearanceBase) appearance96;
    ((HeaderBase) ultraGridColumn38.Header).Caption = "Surcharge Fees";
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn38.Header.VisiblePosition = 4;
    ultraGridColumn38.Width = 71;
    ultraGridColumn39.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance97).TextHAlignAsString = "Right";
    ultraGridColumn39.CellAppearance = (AppearanceBase) appearance97;
    ultraGridColumn39.Format = "c";
    ((AppearanceBase) appearance98).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn39.Header).Appearance = (AppearanceBase) appearance98;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "Other Fees";
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn39.Header.VisiblePosition = 5;
    ultraGridColumn39.Width = 73;
    ultraGridColumn40.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance99).TextHAlignAsString = "Right";
    ultraGridColumn40.CellAppearance = (AppearanceBase) appearance99;
    ultraGridColumn40.Format = "c";
    ((AppearanceBase) appearance100).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn40.Header).Appearance = (AppearanceBase) appearance100;
    ((HeaderBase) ultraGridColumn40.Header).Caption = "Comm Net Out";
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn40.Header.VisiblePosition = 6;
    ultraGridColumn40.Width = 73;
    ultraGridColumn41.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance101).TextHAlignAsString = "Right";
    ultraGridColumn41.CellAppearance = (AppearanceBase) appearance101;
    ultraGridColumn41.Format = "c";
    ((AppearanceBase) appearance102).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn41.Header).Appearance = (AppearanceBase) appearance102;
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Received";
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn41.Header.VisiblePosition = 7;
    ultraGridColumn41.Width = 73;
    ultraGridColumn42.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance103).TextHAlignAsString = "Right";
    ultraGridColumn42.CellAppearance = (AppearanceBase) appearance103;
    ultraGridColumn42.Format = "c";
    ((AppearanceBase) appearance104).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn42.Header).Appearance = (AppearanceBase) appearance104;
    ((HeaderBase) ultraGridColumn42.Header).Caption = "Write Offs";
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn42.Header.VisiblePosition = 8;
    ultraGridColumn42.Width = 73;
    ultraGridColumn43.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance105).TextHAlignAsString = "Right";
    ultraGridColumn43.CellAppearance = (AppearanceBase) appearance105;
    ultraGridColumn43.Format = "c";
    ((AppearanceBase) appearance106).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn43.Header).Appearance = (AppearanceBase) appearance106;
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn43.Header.VisiblePosition = 9;
    ultraGridColumn43.Width = 73;
    ultraGridBand4.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42,
      (object) ultraGridColumn43
    });
    appearance107.BackColor = Color.FloralWhite;
    ultraGridBand4.Override.SummaryValueAppearance = (AppearanceBase) appearance107;
    ultraGridBand4.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance108.BackColor = Color.LightSteelBlue;
    appearance108.FontData.SizeInPoints = 10f;
    appearance108.ForeColor = Color.Black;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance108;
    appearance109.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance109.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance109.ForeColor = Color.Black;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance109;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance110.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance110;
    appearance111.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance111;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance112.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance112;
    appearance113.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance113;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance114.BackColor = Color.Transparent;
    appearance114.ForeColor = Color.Black;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance114;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.gridARBreakdown).Location = new Point(0, 0);
    ((Control) this.gridARBreakdown).Name = "gridARBreakdown";
    ((Control) this.gridARBreakdown).Size = new Size(710, 175);
    ((Control) this.gridARBreakdown).TabIndex = 0;
    ((UltraControlBase) this.gridARBreakdown).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridARBreakdown).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.gridPolicyAPBreakdown);
    ((Control) this.UltraTabPageControl3).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(710, 296);
    ((UltraGridBase) this.gridPolicyAPBreakdown).DataMember = "spFin_PolicyAPBreakdown";
    ((UltraGridBase) this.gridPolicyAPBreakdown).DataSource = (object) this.ds;
    ((SpecialBoxBase) ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.AddNewBox).Prompt = " ";
    appearance115.BackColor = Color.White;
    appearance115.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Appearance = (AppearanceBase) appearance115;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn44.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance116).TextHAlignAsString = "Right";
    ultraGridColumn44.CellAppearance = (AppearanceBase) appearance116;
    ultraGridColumn44.Format = "";
    ((AppearanceBase) appearance117).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn44.Header).Appearance = (AppearanceBase) appearance117;
    ((HeaderBase) ultraGridColumn44.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn44.Header.VisiblePosition = 0;
    ultraGridColumn44.Hidden = true;
    ultraGridColumn44.Width = 45;
    ultraGridColumn45.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn45.Header.VisiblePosition = 1;
    ultraGridColumn45.Hidden = true;
    ultraGridColumn45.Width = 114;
    ultraGridColumn46.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance118).TextHAlignAsString = "Right";
    ultraGridColumn46.CellAppearance = (AppearanceBase) appearance118;
    ((AppearanceBase) appearance119).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn46.Header).Appearance = (AppearanceBase) appearance119;
    ((HeaderBase) ultraGridColumn46.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn46.Header.VisiblePosition = 2;
    ultraGridColumn46.Width = 61;
    ultraGridColumn47.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn47.Header.VisiblePosition = 3;
    ultraGridColumn47.Hidden = true;
    ultraGridColumn47.Width = 139;
    ultraGridColumn48.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance120).TextHAlignAsString = "Right";
    ultraGridColumn48.CellAppearance = (AppearanceBase) appearance120;
    ultraGridColumn48.Format = "c";
    ((AppearanceBase) appearance121).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn48.Header).Appearance = (AppearanceBase) appearance121;
    ((HeaderBase) ultraGridColumn48.Header).Caption = "Com Pay - Prem";
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn48.Header.VisiblePosition = 4;
    ultraGridColumn48.Width = 109;
    ultraGridColumn49.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance122).TextHAlignAsString = "Right";
    ultraGridColumn49.CellAppearance = (AppearanceBase) appearance122;
    ultraGridColumn49.Format = "c";
    ((AppearanceBase) appearance123).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn49.Header).Appearance = (AppearanceBase) appearance123;
    ((HeaderBase) ultraGridColumn49.Header).Caption = "Com Pay - Fees";
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn49.Header.VisiblePosition = 5;
    ultraGridColumn49.Width = 113;
    ultraGridColumn50.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance124).TextHAlignAsString = "Right";
    ultraGridColumn50.CellAppearance = (AppearanceBase) appearance124;
    ultraGridColumn50.Format = "c";
    ((AppearanceBase) appearance125).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn50.Header).Appearance = (AppearanceBase) appearance125;
    ((HeaderBase) ultraGridColumn50.Header).Caption = "Prod Pay";
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn50.Header.VisiblePosition = 6;
    ultraGridColumn50.Width = 104;
    ultraGridColumn51.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance126).TextHAlignAsString = "Right";
    ultraGridColumn51.CellAppearance = (AppearanceBase) appearance126;
    ultraGridColumn51.Format = "c";
    ((AppearanceBase) appearance127).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn51.Header).Appearance = (AppearanceBase) appearance127;
    ((HeaderBase) ultraGridColumn51.Header).Caption = "MGA Comm";
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn51.Header.VisiblePosition = 7;
    ultraGridColumn51.Width = 107;
    ultraGridColumn52.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance128).TextHAlignAsString = "Right";
    ultraGridColumn52.CellAppearance = (AppearanceBase) appearance128;
    ultraGridColumn52.Format = "c";
    ((AppearanceBase) appearance129).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn52.Header).Appearance = (AppearanceBase) appearance129;
    ((HeaderBase) ultraGridColumn52.Header).Caption = "MGA Fees";
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn52.Header.VisiblePosition = 8;
    ultraGridColumn52.Width = 107;
    ultraGridColumn53.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance130).TextHAlignAsString = "Right";
    ultraGridColumn53.CellAppearance = (AppearanceBase) appearance130;
    ultraGridColumn53.Format = "c";
    ((AppearanceBase) appearance131).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn53.Header).Appearance = (AppearanceBase) appearance131;
    ((HeaderBase) ultraGridColumn53.Header).Caption = "Exc. Payable";
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn53.Header.VisiblePosition = 9;
    ultraGridColumn53.Width = 107;
    ultraGridBand5.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53
    });
    appearance132.BackColor = Color.FloralWhite;
    ultraGridBand5.Override.SummaryValueAppearance = (AppearanceBase) appearance132;
    ultraGridBand5.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance133.BackColor = Color.LightSteelBlue;
    appearance133.FontData.SizeInPoints = 10f;
    appearance133.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance133;
    appearance134.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance134.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance134.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance134;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance135.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance135;
    appearance136.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance136;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance137.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance137;
    appearance138.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance138;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance139.BackColor = Color.Transparent;
    appearance139.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance139;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((Control) this.gridPolicyAPBreakdown).Dock = DockStyle.Fill;
    ((Control) this.gridPolicyAPBreakdown).Location = new Point(0, 0);
    ((Control) this.gridPolicyAPBreakdown).Name = "gridPolicyAPBreakdown";
    ((Control) this.gridPolicyAPBreakdown).Size = new Size(710, 296);
    ((Control) this.gridPolicyAPBreakdown).TabIndex = 1;
    ((UltraControlBase) this.gridPolicyAPBreakdown).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPolicyAPBreakdown).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.tabAccountingNotes).Controls.Add((Control) this.txtAccountingNote);
    ((Control) this.tabAccountingNotes).Location = new Point(1, 31 /*0x1F*/);
    ((Control) this.tabAccountingNotes).Name = "tabAccountingNotes";
    ((Control) this.tabAccountingNotes).Size = new Size(710, 296);
    this.txtAccountingNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.txtAccountingNote.BackColor = Color.White;
    this.txtAccountingNote.BorderStyle = BorderStyle.None;
    this.txtAccountingNote.ForeColor = Color.Black;
    this.txtAccountingNote.Location = new Point(3, 3);
    this.txtAccountingNote.MaxLength = 8000;
    this.txtAccountingNote.Name = "txtAccountingNote";
    this.txtAccountingNote.ReadOnly = true;
    this.txtAccountingNote.Size = new Size(705, 290);
    this.txtAccountingNote.TabIndex = 1;
    this.txtAccountingNote.Text = "";
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.tabAccountingNotes);
    ((Control) this.UltraTabControl1).Dock = DockStyle.Fill;
    ((Control) this.UltraTabControl1).Location = new Point(0, 0);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(712, 328);
    ((Control) this.UltraTabControl1).TabIndex = 3;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 1;
    appearance140.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance140.Image"));
    ultraTab1.Appearance = (AppearanceBase) appearance140;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Policy Inquiry";
    appearance141.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance141.Image"));
    ultraTab2.Appearance = (AppearanceBase) appearance141;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "AR Breakdown";
    appearance142.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance142.Image"));
    ultraTab3.Appearance = (AppearanceBase) appearance142;
    ultraTab3.TabPage = this.UltraTabPageControl3;
    ultraTab3.Text = "AP Breakdown";
    appearance143.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance143.Image"));
    ultraTab4.Appearance = (AppearanceBase) appearance143;
    ultraTab4.FixedWidth = 125;
    ultraTab4.TabPage = this.tabAccountingNotes;
    ultraTab4.Text = "Accounting Notes";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabSize = new Size(110, 30);
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(710, 296);
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (PolicyDetail_PolicyInquiry);
    this.Size = new Size(712, 328);
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.dgInquiry).EndInit();
    this.ds.EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    ((ISupportInitialize) this.gridARBreakdown).EndInit();
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.gridPolicyAPBreakdown).EndInit();
    ((Control) this.tabAccountingNotes).ResumeLayout(false);
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public PolicyDetail_PolicyInquiry(Guid quoteGuid)
    : this()
  {
    this._quoteGuid = quoteGuid;
    this._currCultureInfo = frmPolicyDetail.CurrentCultureInfo;
    this._currMultiCurrency = frmPolicyDetail.CurrentMultiCurrency;
    this._implementCurrencyDisplay = frmPolicyDetail.ImplementCurrencyDisplay;
  }

  public PolicyDetail_PolicyInquiry()
  {
    this._policyARBreakdown = new MemoryStream();
    this._policyAPBreakdown = new MemoryStream();
    this.InitializeComponent();
  }

  public override void Fill()
  {
    this.Cursor = MgaCursors.Working;
    ((UltraGridBase) this.dgInquiry).DataSource = (object) null;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));
  }

  private void ThreadedFill(object state)
  {
    Thread.Sleep(250);
    Quote quote = new Quote(this._quoteGuid);
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "spFin_QuoteInvoices"
      }, "spFin_QuoteInvoices", new object[2]
      {
        (object) "@QuoteNum",
        (object) quote.ControlNo
      });
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "spFin_InvoiceTransactions"
      }, "spFin_InvoiceTransactions", new object[2]
      {
        (object) "@QuoteNum",
        (object) quote.ControlNo
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
      return;
    }
    try
    {
      if (!this.IsHandleCreated || this.IsDisposed || this.Disposing)
        return;
      InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new PolicyDetail_PolicyInquiry.FillCompleteHandler(this.FillComplete), new object[0]);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void ShowAccountingTab()
  {
    ((UltraTabControlBase) this.UltraTabControl1).Tabs[3].Visible = !SystemSettings.GetSetting<bool>("PolicyDetail.HideAccountingTab", false);
  }

  protected virtual void FillCustom()
  {
  }

  private void dgInquiry_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    foreach (UltraGridCell cell in e.Row.Cells)
    {
      if (cell.Value is Decimal && Decimal.Compare((Decimal) cell.Value, 0M) < 0)
        cell.Appearance.ForeColor = Color.Red;
    }
  }

  private void FillComplete()
  {
    UltraGrid dgInquiry = this.dgInquiry;
    ((UltraGridBase) dgInquiry).DataMember = string.Empty;
    ((UltraGridBase) dgInquiry).DataSource = (object) this.ds.spFin_QuoteInvoices;
    if (((UltraGridBase) this.dgInquiry).Rows.Count == 1)
      ((UltraGridBase) this.dgInquiry).Rows.ExpandAll(true);
    DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT Comment FROM tblFin_PolicyInquiryComments WITH (NOLOCK) WHERE ControlNumber = @CN", new object[2]
    {
      (object) "@CN",
      (object) new Quote(this._quoteGuid).ControlNo
    });
    StringBuilder stringBuilder = new StringBuilder();
    this.txtAccountingNote.Text = string.Empty;
    try
    {
      foreach (DataRow row in dataTable.Rows)
      {
        if (row[0] != DBNull.Value)
          stringBuilder.AppendLine(row[0].ToString());
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.txtAccountingNote.Text = stringBuilder.ToString();
    this.lnkPolicyInquiry.Visible = this.ds.spFin_InvoiceTransactions.Rows.Count > 0;
    this.SetupGrid();
    this.Cursor = MgaCursors.Default;
    this.ShowAccountingTab();
    this.FillCustom();
  }

  private void lnkPolicyInquiry_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      SectionReport sectionReport = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptPolicyInquiryReport), new object[1]
      {
        (object) this.ds
      });
      sectionReport.Run();
      ReportFactory.Instance.ShowReport(sectionReport);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void FillPolicyAPBreakdown(object state)
  {
    Quote quote = new Quote(this._quoteGuid);
    try
    {
      DefaultDatabase.LoadDataTable((DataTable) this.ds.spFin_PolicyAPBreakdown, "spFin_PolicyAPBreakdown", new object[2]
      {
        (object) "@ControlNo",
        (object) quote.ControlNo
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
      return;
    }
    if (this.IsDisposed || this.Disposing)
      return;
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.FillPolicyAPBreakdownComplete), new object[0]);
  }

  private void FillPolicyAPBreakdownComplete()
  {
    ((UltraGridBase) this.gridPolicyAPBreakdown).DataSource = (object) this.ds;
    this._policyAPBreakdown.Position = 0L;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Load((Stream) this._policyAPBreakdown);
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    if (this.ds.spFin_PolicyAPBreakdown.Count == 0)
      return;
    this.SetupGridAcccountsPayable();
    this._APDataFilled = true;
    this.Cursor = MgaCursors.Default;
  }

  private void FillPolicyARBreakdown(object state)
  {
    Quote quote = new Quote(this._quoteGuid);
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[4]
      {
        "spFin_PolicyARBreakdown",
        "spFin_PolicyARBreakdown_2",
        "spFin_PolicyARBreakdown_3",
        "spFin_PolicyARBreakdown_4"
      }, "spFin_PolicyARBreakdown", new object[2]
      {
        (object) "@ControlNumber",
        (object) quote.ControlNo
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
      return;
    }
    if (this.IsDisposed || this.Disposing)
      return;
    InvokeExtensions.BetterInvoke((ISynchronizeInvoke) MDIControls.Instance.MDIParent, (Delegate) new MethodInvoker(this.FillPolicyARBreakdownComplete), new object[0]);
  }

  private void FillPolicyARBreakdownComplete()
  {
    ((UltraGridBase) this.gridARBreakdown).DataSource = (object) this.ds;
    this._policyARBreakdown.Position = 0L;
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Load((Stream) this._policyARBreakdown);
    ((UltraGridBase) this.gridARBreakdown).DisplayLayout.ScrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    if (this.ds.spFin_PolicyARBreakdown.Count == 0)
      return;
    dsPolicyInquiry.spFin_PolicyARBreakdown_2Row policyArBreakdown2Row = this.ds.spFin_PolicyARBreakdown_2[0];
    this.ds.Summaries.AddSummariesRow("Received", policyArBreakdown2Row.DollarsReceived_Premium, policyArBreakdown2Row.DollarsReceived_AIEndorsement, policyArBreakdown2Row.DollarsReceived_SurchargeFees, policyArBreakdown2Row.DollarsReceived_OtherFees, 0M, 0M, 0M, 0M);
    dsPolicyInquiry.spFin_PolicyARBreakdown_3Row policyArBreakdown3Row = this.ds.spFin_PolicyARBreakdown_3[0];
    this.ds.Summaries.AddSummariesRow("Write Offs", policyArBreakdown3Row.WriteOffs_Premium, policyArBreakdown3Row.WriteOffs_AIEndorsement, policyArBreakdown3Row.WriteOffs_SurchargeFees, policyArBreakdown3Row.WriteOffs_OtherFees, 0M, 0M, 0M, 0M);
    dsPolicyInquiry.spFin_PolicyARBreakdown_4Row policyArBreakdown4Row = this.ds.spFin_PolicyARBreakdown_4[0];
    this.ds.Summaries.AddSummariesRow("Commission Net Out", policyArBreakdown4Row.CommissionNetOut_Premium, policyArBreakdown4Row.CommissionNetOut_AIEndorsement, policyArBreakdown4Row.CommissionNetOut_SurchargeFees, policyArBreakdown4Row.CommissionNetOut_OtherFees, 0M, 0M, 0M, 0M);
    this.SetupGridAcccountsReceivable();
    this._ARDataFilled = true;
    this.Cursor = MgaCursors.Default;
  }

  private void GridPolicyAPBreakdown_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    foreach (UltraGridCell cell in e.Row.Cells)
    {
      if (cell.Value is Decimal)
      {
        cell.Column.Format = "c";
        if (Decimal.Compare((Decimal) cell.Value, 0M) < 0)
          cell.Appearance.ForeColor = Color.Red;
      }
    }
  }

  private void UltraTabControl1_ActiveTabChanged(object sender, ActiveTabChangedEventArgs e)
  {
    if (((UltraTabControlBase) this.UltraTabControl1).ActiveTab.Index == 1 && !this._ARDataFilled)
    {
      this.Cursor = MgaCursors.Working;
      ((UltraGridBase) this.gridARBreakdown).DisplayLayout.Save((Stream) this._policyARBreakdown);
      ((UltraGridBase) this.gridARBreakdown).DataSource = (object) null;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.FillPolicyARBreakdown));
    }
    else
    {
      if (((UltraTabControlBase) this.UltraTabControl1).ActiveTab.Index != 2 || this._APDataFilled)
        return;
      this.Cursor = MgaCursors.Working;
      ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Save((Stream) this._policyAPBreakdown);
      ((UltraGridBase) this.gridPolicyAPBreakdown).DataSource = (object) null;
      ThreadPool.QueueUserWorkItem(new WaitCallback(this.FillPolicyAPBreakdown));
    }
  }

  private void SetupGrid()
  {
    if (!this._currMultiCurrency || !this._implementCurrencyDisplay)
      return;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[0].Columns["GrossPremium"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[0].Columns["Fees"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[0].Columns["NetBilled"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[0].Columns["AmtPTD"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[0].Columns["surplus"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[1].Columns["arapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[1].Columns["apapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[1].Columns["exchapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[1].Columns["unacctapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[1].Columns["incomeapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.dgInquiry).DisplayLayout.Bands[1].Columns["cashapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
  }

  private void SetupGridAcccountsReceivable()
  {
    if (!this._currMultiCurrency || !this._implementCurrencyDisplay)
      return;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["Premium"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["AIEndorsement"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["SurchargeFees"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["OtherFees"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["CommissionNetOut"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["DollarsReceived"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["WriteOffs"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Bands[0].Columns["Balance"].FormatInfo = (IFormatProvider) this._currCultureInfo;
  }

  private void SetupGridAcccountsPayable()
  {
    if (!this._currMultiCurrency || !this._implementCurrencyDisplay)
      return;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[0].Columns["GrossPremium"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[0].Columns["Fees"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[0].Columns["NetBilled"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[0].Columns["AmtPTD"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[0].Columns["Surplus"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[1].Columns["arapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[1].Columns["apapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[1].Columns["exchapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[1].Columns["unacctapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[1].Columns["incomeapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
    ((UltraGridBase) this.gridPolicyAPBreakdown).DisplayLayout.Bands[1].Columns["cashapplied"].FormatInfo = (IFormatProvider) this._currCultureInfo;
  }

  private delegate void FillCompleteHandler();
}
