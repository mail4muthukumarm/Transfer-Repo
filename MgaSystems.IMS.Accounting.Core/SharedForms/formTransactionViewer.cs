// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.SharedForms.formTransactionViewer
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.Misc.CommonControls;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinStatusBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.SharedForms;

public class formTransactionViewer : AccountingNoteDocumentSupport
{
  private Label label1;
  private Label label2;
  private Label label3;
  private Label label4;
  protected Label label5;
  private Label labelTransactionNumber;
  protected Label labelTransactionType;
  private Label labelTransactionDate;
  private Label labelEnteredBy;
  protected Label labelPostingComment;
  internal UltraTabControl UltraTabControl1;
  internal UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  internal UltraTabPageControl UltraTabPageControl1;
  internal UltraTabPageControl UltraTabPageControl2;
  internal UltraTabPageControl UltraTabPageControl5;
  private UltraTabPageControl ultraTabPageControl3;
  internal UltraGrid gridPostedInvoices;
  internal UltraGrid gridDistributions;
  internal UltraGrid gridLinkedTransaction;
  protected Panel panelTransactionTotals;
  internal TextBox txtUnAccounted;
  internal Label Label11;
  internal TextBox txtExchange;
  internal Label Label10;
  internal TextBox txtIncome;
  internal TextBox txtExpenses;
  internal TextBox txtPayables;
  internal TextBox txtReceivables;
  internal TextBox txtCash;
  internal Label Label9;
  internal Label Label8;
  internal Label Label7;
  internal Label Label6;
  internal Label label12;
  protected Panel panel1;
  internal SqlConnection FormDataConnection;
  internal SqlDataAdapter daViewTransaction_Summary;
  internal SqlCommand SqlSelectCommand7;
  internal SqlDataAdapter daViewTransaction_PO;
  internal SqlCommand SqlSelectCommand5;
  internal SqlDataAdapter daViewTransaction_Distributions;
  internal SqlCommand SqlSelectCommand2;
  protected SqlDataAdapter daViewTransaction_AffectedInvoices;
  protected SqlCommand SqlSelectCommand3;
  internal SqlDataAdapter daViewTransaction_Verbage;
  internal SqlCommand SqlSelectCommand4;
  internal SqlDataAdapter daViewTransaction_Header;
  internal SqlCommand SqlSelectCommand1;
  internal SqlDataAdapter daViewTransaction_Commissions;
  internal SqlCommand SqlSelectCommand6;
  private dsViewTransaction dsViewTransaction1;
  private Panel panelLoading;
  private Label label13;
  private Panel panel2;
  private Label labelLoadStatus;
  private AnimationControl animationControl1;
  protected MGAButton buttonVoidTransaction;
  private LinkLabel linkChangeDate;
  private Label lblPayeeRemitter;
  protected MGAButton buttonPrint;
  private LinkLabel linkVoidedTransactions;
  private Label lblVoidedTransactions;
  private Label labelReceivedDate;
  private Label label15;
  private Label labelCheckNumber;
  protected LinkLabel linkEditSaveComments;
  private MGATextBox textEditComments;
  private EllipsePanel panelEditComment;
  private MGAButton buttonSaveEditComment;
  private MGAButton buttonCancelEditComment;
  protected LinkLabel linkUnreconcile;
  protected UltraGrid gridClaims;
  private UltraStatusBar userTimestampUltraStatusBar;
  private System.ComponentModel.Container components;
  private int _transactionNumber;
  private int _glCompanyId;
  private dsViewTransaction _ds;
  private string BANKSECURITY_RECONCILEUNRECONCILE = "{724FE13B-6F3C-4c8b-B6B4-B41BBF157C55}";

  protected virtual string ClaimDataStoredProcedure => "spFin_ViewTransaction_Claim";

  protected virtual string ViewBuilderStoredProcedure => "dbo.spFin_ViewTransaction_Header";

  protected formTransactionViewer() => this.InitializeComponent();

  public formTransactionViewer(int transactionNumber, int _)
  {
    this.InitializeComponent();
    this._transactionNumber = transactionNumber;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
      this.components?.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("AffectedInvoices", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("policyNumber");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("officeInvoiceNum", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("company");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("producerName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("insuredName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("amount");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "amount", 5, true, "AffectedInvoices", 0, (SummaryPosition) 3, (string) null, -1, false);
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Distributions", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("glAccountId");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("fullName");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Entity");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("accountType");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("debitAmount");
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("creditAmount");
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "debitAmount", 4, true, "Distributions", 0, (SummaryPosition) 3, "debitAmount", 4, true);
    Appearance appearance19 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 1, (string) null, "creditAmount", 5, true, "Distributions", 0, (SummaryPosition) 3, "creditAmount", 5, true);
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("POExpense", -1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("PONum");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("GLAccount");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Amount");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("PODate", 0);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("EntityName", 1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Invoice Number", 2);
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    Appearance appearance43 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formTransactionViewer));
    Appearance appearance44 = new Appearance();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("", -1);
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.gridPostedInvoices = new UltraGrid();
    this.dsViewTransaction1 = new dsViewTransaction();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.gridDistributions = new UltraGrid();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.gridLinkedTransaction = new UltraGrid();
    this.ultraTabPageControl3 = new UltraTabPageControl();
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.labelTransactionNumber = new Label();
    this.labelTransactionType = new Label();
    this.labelTransactionDate = new Label();
    this.labelEnteredBy = new Label();
    this.labelPostingComment = new Label();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.panelTransactionTotals = new Panel();
    this.txtUnAccounted = new TextBox();
    this.Label11 = new Label();
    this.txtExchange = new TextBox();
    this.Label10 = new Label();
    this.txtIncome = new TextBox();
    this.txtExpenses = new TextBox();
    this.txtPayables = new TextBox();
    this.txtReceivables = new TextBox();
    this.txtCash = new TextBox();
    this.Label9 = new Label();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.label12 = new Label();
    this.panel1 = new Panel();
    this.linkUnreconcile = new LinkLabel();
    this.linkEditSaveComments = new LinkLabel();
    this.labelCheckNumber = new Label();
    this.buttonVoidTransaction = new MGAButton();
    this.buttonPrint = new MGAButton();
    this.labelReceivedDate = new Label();
    this.label15 = new Label();
    this.lblVoidedTransactions = new Label();
    this.linkVoidedTransactions = new LinkLabel();
    this.lblPayeeRemitter = new Label();
    this.linkChangeDate = new LinkLabel();
    this.FormDataConnection = new SqlConnection();
    this.daViewTransaction_Summary = new SqlDataAdapter();
    this.SqlSelectCommand7 = new SqlCommand();
    this.daViewTransaction_PO = new SqlDataAdapter();
    this.SqlSelectCommand5 = new SqlCommand();
    this.daViewTransaction_Distributions = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daViewTransaction_AffectedInvoices = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.daViewTransaction_Verbage = new SqlDataAdapter();
    this.SqlSelectCommand4 = new SqlCommand();
    this.daViewTransaction_Header = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.daViewTransaction_Commissions = new SqlDataAdapter();
    this.SqlSelectCommand6 = new SqlCommand();
    this.panelLoading = new Panel();
    this.panel2 = new Panel();
    this.animationControl1 = new AnimationControl();
    this.labelLoadStatus = new Label();
    this.label13 = new Label();
    this.textEditComments = new MGATextBox();
    this.panelEditComment = new EllipsePanel();
    this.buttonCancelEditComment = new MGAButton();
    this.buttonSaveEditComment = new MGAButton();
    this.gridClaims = new UltraGrid();
    this.userTimestampUltraStatusBar = new UltraStatusBar();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.gridPostedInvoices).BeginInit();
    this.dsViewTransaction1.BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.gridDistributions).BeginInit();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.gridLinkedTransaction).BeginInit();
    ((Control) this.ultraTabPageControl3).SuspendLayout();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    this.panelTransactionTotals.SuspendLayout();
    ((ISupportInitialize) this.userTimestampUltraStatusBar).BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.buttonVoidTransaction).BeginInit();
    ((ISupportInitialize) this.buttonPrint).BeginInit();
    this.panelLoading.SuspendLayout();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.textEditComments).BeginInit();
    this.panelEditComment.SuspendLayout();
    ((ISupportInitialize) this.buttonCancelEditComment).BeginInit();
    ((ISupportInitialize) this.buttonSaveEditComment).BeginInit();
    ((ISupportInitialize) this.gridClaims).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.gridPostedInvoices);
    ((Control) this.UltraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(913, 431);
    ((Control) this.gridPostedInvoices).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridPostedInvoices).DataMember = "AffectedInvoices";
    ((UltraGridBase) this.gridPostedInvoices).DataSource = (object) this.dsViewTransaction1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 104;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 181;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 144 /*0x90*/;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Producer";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 157;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 162;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 163;
    ultraGridBand1.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((AppearanceBase) appearance4).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance4;
    summarySettings1.DisplayFormat = "{0:c}";
    ultraGridBand1.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings1
    });
    ultraGridBand1.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridPostedInvoices).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridPostedInvoices).Dock = DockStyle.Fill;
    ((Control) this.gridPostedInvoices).Location = new Point(0, 0);
    ((Control) this.gridPostedInvoices).Name = "gridPostedInvoices";
    ((Control) this.gridPostedInvoices).Size = new Size(913, 431);
    ((Control) this.gridPostedInvoices).TabIndex = 2;
    ((UltraControlBase) this.gridPostedInvoices).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPostedInvoices).UseOsThemes = (DefaultableBoolean) 2;
    this.dsViewTransaction1.DataSetName = "dsViewTransaction";
    this.dsViewTransaction1.Locale = new CultureInfo("en-US");
    this.dsViewTransaction1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.gridDistributions);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(913, 431);
    ((Control) this.gridDistributions).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridDistributions).DataMember = "Distributions";
    ((UltraGridBase) this.gridDistributions).DataSource = (object) this.dsViewTransaction1;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 110;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "GL Account";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 1;
    ultraGridColumn8.Width = 235;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 2;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 142;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 3;
    ultraGridColumn10.Width = 232;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance14;
    ultraGridColumn11.Format = "c";
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance15;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Debit";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 4;
    ultraGridColumn11.Width = 219;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance16;
    ultraGridColumn12.Format = "c";
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance17;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Credit";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 5;
    ultraGridColumn12.Width = 225;
    ultraGridBand2.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((AppearanceBase) appearance18).BackColor = Color.LightSteelBlue;
    ultraGridBand2.Override.SummaryFooterAppearance = (AppearanceBase) appearance18;
    ultraGridBand2.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance19).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance19).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance19).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance19;
    summarySettings2.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance20).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance20).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance20).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance20;
    summarySettings3.DisplayFormat = "{0:c}";
    ultraGridBand2.Summaries.AddRange(new SummarySettings[2]
    {
      summarySettings2,
      summarySettings3
    });
    ultraGridBand2.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridDistributions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridDistributions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance21).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance21).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance22).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance23).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance26).BackColor = Color.Transparent;
    ((AppearanceBase) appearance26).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance27).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.gridDistributions).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridDistributions).Dock = DockStyle.Fill;
    ((Control) this.gridDistributions).Location = new Point(0, 0);
    ((Control) this.gridDistributions).Name = "gridDistributions";
    ((Control) this.gridDistributions).Size = new Size(913, 431);
    ((Control) this.gridDistributions).TabIndex = 1;
    ((UltraControlBase) this.gridDistributions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridDistributions).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.gridLinkedTransaction);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(913, 431);
    ((Control) this.gridLinkedTransaction).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridLinkedTransaction).DataMember = "POExpense";
    ((UltraGridBase) this.gridLinkedTransaction).DataSource = (object) this.dsViewTransaction1;
    ((AppearanceBase) appearance29).BackColor = Color.White;
    ((AppearanceBase) appearance29).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Appearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "PO Number";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 0;
    ultraGridColumn13.Width = 65;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Account";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 3;
    ultraGridColumn14.Width = 98;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 5;
    ultraGridColumn15.Width = 376;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance30;
    ultraGridColumn16.Format = "c";
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 6;
    ultraGridColumn16.Width = 95;
    ultraGridColumn17.DataType = typeof (DateTime);
    ((HeaderBase) ultraGridColumn17.Header).Caption = "PO Date";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 1;
    ultraGridColumn17.Width = 82;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Entity Name";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 2;
    ultraGridColumn18.Width = 92;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 4;
    ultraGridColumn19.Width = 103;
    ultraGridBand3.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19
    });
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance32).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance32).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance32).ForeColor = Color.Black;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance33).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance34).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance34).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance35).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance35;
    ((AppearanceBase) appearance36).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance37).BackColor = Color.Transparent;
    ((AppearanceBase) appearance37).ForeColor = Color.Black;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance38).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance38;
    ((AppearanceBase) appearance39).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.gridLinkedTransaction).Dock = DockStyle.Fill;
    ((Control) this.gridLinkedTransaction).Location = new Point(0, 0);
    ((Control) this.gridLinkedTransaction).Name = "gridLinkedTransaction";
    ((Control) this.gridLinkedTransaction).Size = new Size(913, 431);
    ((Control) this.gridLinkedTransaction).TabIndex = 2;
    ((UltraControlBase) this.gridLinkedTransaction).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridLinkedTransaction).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraTabPageControl3).Controls.Add((Control) this.gridClaims);
    ((Control) this.ultraTabPageControl3).Location = new Point(1, 20);
    ((Control) this.ultraTabPageControl3).Name = "ultraTabPageControl3";
    ((Control) this.ultraTabPageControl3).Size = new Size(913, 431);
    this.label1.AutoSize = true;
    this.label1.Location = new Point(8, 8);
    this.label1.Name = "label1";
    this.label1.Size = new Size(78, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Transaction #:";
    this.label2.AutoSize = true;
    this.label2.Location = new Point(8, 27);
    this.label2.Name = "label2";
    this.label2.Size = new Size(93, 13);
    this.label2.TabIndex = 1;
    this.label2.Text = "Transaction Date:";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(8, 65);
    this.label3.Name = "label3";
    this.label3.Size = new Size(94, 13);
    this.label3.TabIndex = 2;
    this.label3.Text = "Transaction Type:";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(8, 84);
    this.label4.Name = "label4";
    this.label4.Size = new Size(64 /*0x40*/, 13);
    this.label4.TabIndex = 3;
    this.label4.Text = "Entered By:";
    this.label5.AutoSize = true;
    this.label5.Location = new Point(264, 8);
    this.label5.Name = "label5";
    this.label5.Size = new Size(77, 13);
    this.label5.TabIndex = 4;
    this.label5.Text = "Posting Memo:";
    this.labelTransactionNumber.AutoSize = true;
    this.labelTransactionNumber.DataBindings.Add(new Binding("Text", (object) this.dsViewTransaction1, "TransactionHeader.transactNum", true));
    this.labelTransactionNumber.Location = new Point(104, 8);
    this.labelTransactionNumber.Name = "labelTransactionNumber";
    this.labelTransactionNumber.Size = new Size(82, 13);
    this.labelTransactionNumber.TabIndex = 5;
    this.labelTransactionNumber.Text = "[Transaction #]";
    this.labelTransactionType.AutoSize = true;
    this.labelTransactionType.DataBindings.Add(new Binding("Text", (object) this.dsViewTransaction1, "TransactionHeader.transDescription", true));
    this.labelTransactionType.Location = new Point(104, 65);
    this.labelTransactionType.Name = "labelTransactionType";
    this.labelTransactionType.Size = new Size(98, 13);
    this.labelTransactionType.TabIndex = 6;
    this.labelTransactionType.Text = "[Transaction Type]";
    this.labelTransactionDate.AutoSize = true;
    this.labelTransactionDate.DataBindings.Add(new Binding("Text", (object) this.dsViewTransaction1, "TransactionHeader.postDate", true));
    this.labelTransactionDate.Location = new Point(104, 27);
    this.labelTransactionDate.Name = "labelTransactionDate";
    this.labelTransactionDate.Size = new Size(97, 13);
    this.labelTransactionDate.TabIndex = 7;
    this.labelTransactionDate.Text = "[Transaction Date]";
    this.labelEnteredBy.AutoSize = true;
    this.labelEnteredBy.DataBindings.Add(new Binding("Text", (object) this.dsViewTransaction1, "TransactionHeader.User", true));
    this.labelEnteredBy.Location = new Point(104, 84);
    this.labelEnteredBy.Name = "labelEnteredBy";
    this.labelEnteredBy.Size = new Size(68, 13);
    this.labelEnteredBy.TabIndex = 8;
    this.labelEnteredBy.Text = "[Entered By]";
    this.labelPostingComment.Location = new Point(379, 8);
    this.labelPostingComment.Name = "labelPostingComment";
    this.labelPostingComment.Size = new Size(531, 64 /*0x40*/);
    this.labelPostingComment.TabIndex = 9;
    this.labelPostingComment.Text = "[Comments]";
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.ultraTabPageControl3);
    ((Control) this.UltraTabControl1).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance40).BackColor = Color.White;
    ((AppearanceBase) appearance40).BackColor2 = Color.SteelBlue;
    ((AppearanceBase) appearance40).BackGradientStyle = (GradientStyle) 2;
    ((UltraTabControlBase) this.UltraTabControl1).HotTrackAppearance = (AppearanceBase) appearance40;
    ((Control) this.UltraTabControl1).Location = new Point(0, 104);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((AppearanceBase) appearance41).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance41).ForeColor = Color.Black;
    ((UltraTabControlBase) this.UltraTabControl1).SelectedTabAppearance = (AppearanceBase) appearance41;
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(915, 452);
    ((UltraTabControlBase) this.UltraTabControl1).Style = (UltraTabControlStyle) 12;
    ((AppearanceBase) appearance42).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance42).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance42).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance42).TextHAlignAsString = "Left";
    ((UltraTabControlBase) this.UltraTabControl1).TabHeaderAreaAppearance = (AppearanceBase) appearance42;
    ((Control) this.UltraTabControl1).TabIndex = 10;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 5;
    ((AppearanceBase) appearance43).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance43).ForeColor = Color.Gray;
    ((AppearanceBase) appearance43).Image = componentResourceManager.GetObject("appearance52.Image");
    ((AppearanceBase) appearance43).ImageHAlign = (HAlign) 1;
    ultraTab1.Appearance = (AppearanceBase) appearance43;
    ((AppearanceBase) appearance44).BackColor = Color.White;
    ((AppearanceBase) appearance44).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance44).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance44).BackGradientStyle = (GradientStyle) 8;
    ultraTab1.ClientAreaAppearance = (AppearanceBase) appearance44;
    ultraTab1.TabPage = this.UltraTabPageControl1;
    ultraTab1.Text = "Posted Invoices";
    ((AppearanceBase) appearance45).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance45).ForeColor = Color.Gray;
    ((AppearanceBase) appearance45).Image = componentResourceManager.GetObject("appearance54.Image");
    ((AppearanceBase) appearance45).ImageHAlign = (HAlign) 1;
    ultraTab2.Appearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).BackColor = Color.White;
    ((AppearanceBase) appearance46).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance46).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance46).BackGradientStyle = (GradientStyle) 8;
    ultraTab2.ClientAreaAppearance = (AppearanceBase) appearance46;
    ultraTab2.TabPage = this.UltraTabPageControl2;
    ultraTab2.Text = "Distributions";
    ((AppearanceBase) appearance47).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance47).ForeColor = Color.Gray;
    ((AppearanceBase) appearance47).Image = componentResourceManager.GetObject("appearance56.Image");
    ((AppearanceBase) appearance47).ImageHAlign = (HAlign) 1;
    ultraTab3.Appearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).BackColor = Color.White;
    ((AppearanceBase) appearance48).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance48).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance48).BackGradientStyle = (GradientStyle) 8;
    ultraTab3.ClientAreaAppearance = (AppearanceBase) appearance48;
    ultraTab3.TabPage = this.UltraTabPageControl5;
    ultraTab3.Text = "Purchase Order/Expenses";
    ((AppearanceBase) appearance49).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance49).ForeColor = Color.Gray;
    ((AppearanceBase) appearance49).Image = componentResourceManager.GetObject("appearance58.Image");
    ((AppearanceBase) appearance49).ImageHAlign = (HAlign) 1;
    ultraTab4.Appearance = (AppearanceBase) appearance49;
    ((AppearanceBase) appearance50).BackColor = Color.White;
    ((AppearanceBase) appearance50).BackColor2 = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance50).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance50).BackGradientStyle = (GradientStyle) 8;
    ultraTab4.ClientAreaAppearance = (AppearanceBase) appearance50;
    ((KeyedSubObjectBase) ultraTab4).Key = "tabClaims";
    ultraTab4.TabPage = this.ultraTabPageControl3;
    ultraTab4.Text = "Claims";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[4]
    {
      ultraTab1,
      ultraTab2,
      ultraTab3,
      ultraTab4
    });
    ((UltraTabControlBase) this.UltraTabControl1).TabsPerRow = 4;
    ((UltraControlBase) this.UltraTabControl1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraTabControl1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(913, 431);
    this.panelTransactionTotals.BackColor = Color.FromArgb(239, 247, 253);
    this.panelTransactionTotals.BorderStyle = BorderStyle.FixedSingle;
    this.panelTransactionTotals.Controls.Add((Control) this.userTimestampUltraStatusBar);
    this.panelTransactionTotals.Controls.Add((Control) this.txtUnAccounted);
    this.panelTransactionTotals.Controls.Add((Control) this.Label11);
    this.panelTransactionTotals.Controls.Add((Control) this.txtExchange);
    this.panelTransactionTotals.Controls.Add((Control) this.Label10);
    this.panelTransactionTotals.Controls.Add((Control) this.txtIncome);
    this.panelTransactionTotals.Controls.Add((Control) this.txtExpenses);
    this.panelTransactionTotals.Controls.Add((Control) this.txtPayables);
    this.panelTransactionTotals.Controls.Add((Control) this.txtReceivables);
    this.panelTransactionTotals.Controls.Add((Control) this.txtCash);
    this.panelTransactionTotals.Controls.Add((Control) this.Label9);
    this.panelTransactionTotals.Controls.Add((Control) this.Label8);
    this.panelTransactionTotals.Controls.Add((Control) this.Label7);
    this.panelTransactionTotals.Controls.Add((Control) this.Label6);
    this.panelTransactionTotals.Controls.Add((Control) this.label12);
    this.panelTransactionTotals.Dock = DockStyle.Bottom;
    this.panelTransactionTotals.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.panelTransactionTotals.Location = new Point(0, 556);
    this.panelTransactionTotals.Name = "panelTransactionTotals";
    this.panelTransactionTotals.Size = new Size(915, 70);
    this.panelTransactionTotals.TabIndex = 11;
    ((Control) this.userTimestampUltraStatusBar).Location = new Point(0, 62);
    ((Control) this.userTimestampUltraStatusBar).Name = "userTimestampUltraStatusBar";
    ((Control) this.userTimestampUltraStatusBar).Size = new Size(915, 17);
    ((Control) this.userTimestampUltraStatusBar).TabIndex = 3;
    ((Control) this.userTimestampUltraStatusBar).Text = "ultraStatusBar1";
    this.txtUnAccounted.BackColor = Color.White;
    this.txtUnAccounted.BorderStyle = BorderStyle.FixedSingle;
    this.txtUnAccounted.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtUnAccounted.Location = new Point(538, 22);
    this.txtUnAccounted.Name = "txtUnAccounted";
    this.txtUnAccounted.ReadOnly = true;
    this.txtUnAccounted.Size = new Size(88, 21);
    this.txtUnAccounted.TabIndex = 13;
    this.txtUnAccounted.TabStop = false;
    this.txtUnAccounted.Text = "$0.00";
    this.txtUnAccounted.TextAlign = HorizontalAlignment.Right;
    this.Label11.AutoSize = true;
    this.Label11.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label11.ForeColor = Color.DimGray;
    this.Label11.Location = new Point(538, 6);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(90, 13);
    this.Label11.TabIndex = 12;
    this.Label11.Text = "Un-Accounted:";
    this.txtExchange.BackColor = Color.White;
    this.txtExchange.BorderStyle = BorderStyle.FixedSingle;
    this.txtExchange.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtExchange.Location = new Point(408, 23);
    this.txtExchange.Name = "txtExchange";
    this.txtExchange.ReadOnly = true;
    this.txtExchange.Size = new Size(96 /*0x60*/, 21);
    this.txtExchange.TabIndex = 11;
    this.txtExchange.TabStop = false;
    this.txtExchange.Text = "$0.00";
    this.txtExchange.TextAlign = HorizontalAlignment.Right;
    this.Label10.AutoSize = true;
    this.Label10.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.DimGray;
    this.Label10.Location = new Point(408, 7);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(64 /*0x40*/, 13);
    this.Label10.TabIndex = 10;
    this.Label10.Text = "Exchange:";
    this.txtIncome.BackColor = Color.White;
    this.txtIncome.BorderStyle = BorderStyle.FixedSingle;
    this.txtIncome.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtIncome.Location = new Point(678, 22);
    this.txtIncome.Name = "txtIncome";
    this.txtIncome.ReadOnly = true;
    this.txtIncome.Size = new Size(88, 21);
    this.txtIncome.TabIndex = 9;
    this.txtIncome.TabStop = false;
    this.txtIncome.Text = "$0.00";
    this.txtIncome.TextAlign = HorizontalAlignment.Right;
    this.txtExpenses.BackColor = Color.White;
    this.txtExpenses.BorderStyle = BorderStyle.FixedSingle;
    this.txtExpenses.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtExpenses.Location = new Point(818, 22);
    this.txtExpenses.Name = "txtExpenses";
    this.txtExpenses.ReadOnly = true;
    this.txtExpenses.Size = new Size(88, 21);
    this.txtExpenses.TabIndex = 8;
    this.txtExpenses.TabStop = false;
    this.txtExpenses.Text = "$0.00";
    this.txtExpenses.TextAlign = HorizontalAlignment.Right;
    this.txtPayables.BackColor = Color.White;
    this.txtPayables.BorderStyle = BorderStyle.FixedSingle;
    this.txtPayables.DataBindings.Add(new Binding("Text", (object) this.dsViewTransaction1, "Summary.payables", true));
    this.txtPayables.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtPayables.Location = new Point(278, 22);
    this.txtPayables.Name = "txtPayables";
    this.txtPayables.ReadOnly = true;
    this.txtPayables.Size = new Size(96 /*0x60*/, 21);
    this.txtPayables.TabIndex = 7;
    this.txtPayables.TabStop = false;
    this.txtPayables.Text = "$0.00";
    this.txtPayables.TextAlign = HorizontalAlignment.Right;
    this.txtReceivables.BackColor = Color.White;
    this.txtReceivables.BorderStyle = BorderStyle.FixedSingle;
    this.txtReceivables.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtReceivables.Location = new Point(148, 22);
    this.txtReceivables.Name = "txtReceivables";
    this.txtReceivables.ReadOnly = true;
    this.txtReceivables.Size = new Size(88, 21);
    this.txtReceivables.TabIndex = 6;
    this.txtReceivables.TabStop = false;
    this.txtReceivables.Text = "$0.00";
    this.txtReceivables.TextAlign = HorizontalAlignment.Right;
    this.txtCash.BackColor = Color.White;
    this.txtCash.BorderStyle = BorderStyle.FixedSingle;
    this.txtCash.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCash.Location = new Point(8, 22);
    this.txtCash.Name = "txtCash";
    this.txtCash.ReadOnly = true;
    this.txtCash.Size = new Size(88, 21);
    this.txtCash.TabIndex = 5;
    this.txtCash.TabStop = false;
    this.txtCash.Text = "$0.00";
    this.txtCash.TextAlign = HorizontalAlignment.Right;
    this.Label9.AutoSize = true;
    this.Label9.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.ForeColor = Color.DimGray;
    this.Label9.Location = new Point(818, 6);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(63 /*0x3F*/, 13);
    this.Label9.TabIndex = 4;
    this.Label9.Text = "Expenses:";
    this.Label8.AutoSize = true;
    this.Label8.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.ForeColor = Color.DimGray;
    this.Label8.Location = new Point(678, 6);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(53, 13);
    this.Label8.TabIndex = 3;
    this.Label8.Text = "Income:";
    this.Label7.AutoSize = true;
    this.Label7.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.ForeColor = Color.DimGray;
    this.Label7.Location = new Point(148, 6);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(78, 13);
    this.Label7.TabIndex = 2;
    this.Label7.Text = "Receivables:";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.DimGray;
    this.Label6.Location = new Point(278, 6);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(61, 13);
    this.Label6.TabIndex = 1;
    this.Label6.Text = "Payables:";
    this.label12.AutoSize = true;
    this.label12.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label12.ForeColor = Color.DimGray;
    this.label12.Location = new Point(8, 6);
    this.label12.Name = "label12";
    this.label12.Size = new Size(37, 13);
    this.label12.TabIndex = 0;
    this.label12.Text = "Cash:";
    this.panel1.BackColor = Color.FromArgb(239, 247, 253);
    this.panel1.Controls.Add((Control) this.linkUnreconcile);
    this.panel1.Controls.Add((Control) this.linkEditSaveComments);
    this.panel1.Controls.Add((Control) this.labelCheckNumber);
    this.panel1.Controls.Add((Control) this.buttonVoidTransaction);
    this.panel1.Controls.Add((Control) this.buttonPrint);
    this.panel1.Controls.Add((Control) this.labelReceivedDate);
    this.panel1.Controls.Add((Control) this.label15);
    this.panel1.Controls.Add((Control) this.lblVoidedTransactions);
    this.panel1.Controls.Add((Control) this.linkVoidedTransactions);
    this.panel1.Controls.Add((Control) this.lblPayeeRemitter);
    this.panel1.Controls.Add((Control) this.linkChangeDate);
    this.panel1.Controls.Add((Control) this.labelTransactionType);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.labelTransactionDate);
    this.panel1.Controls.Add((Control) this.labelTransactionNumber);
    this.panel1.Controls.Add((Control) this.labelEnteredBy);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.label5);
    this.panel1.Controls.Add((Control) this.labelPostingComment);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(915, 104);
    this.panel1.TabIndex = 12;
    this.linkUnreconcile.AutoSize = true;
    this.linkUnreconcile.DataBindings.Add(new Binding("Text", (object) this.dsViewTransaction1, "TransactionHeader.VoidTransaction", true));
    this.linkUnreconcile.Location = new Point(830, 8);
    this.linkUnreconcile.Name = "linkUnreconcile";
    this.linkUnreconcile.Size = new Size(77, 13);
    this.linkUnreconcile.TabIndex = 20;
    this.linkUnreconcile.TabStop = true;
    this.linkUnreconcile.Text = "[Un-Reconcile]";
    this.linkUnreconcile.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkUnreconcile_LinkClicked);
    this.linkEditSaveComments.AutoSize = true;
    this.linkEditSaveComments.Location = new Point(340, 8);
    this.linkEditSaveComments.Name = "linkEditSaveComments";
    this.linkEditSaveComments.Size = new Size(33, 13);
    this.linkEditSaveComments.TabIndex = 19;
    this.linkEditSaveComments.TabStop = true;
    this.linkEditSaveComments.Text = "(Edit)";
    this.linkEditSaveComments.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkEditSaveComments_LinkClicked);
    this.labelCheckNumber.DataBindings.Add(new Binding("Text", (object) this.dsViewTransaction1, "TransactionHeader.CheckNumber", true));
    this.labelCheckNumber.Location = new Point(264, 46);
    this.labelCheckNumber.Name = "labelCheckNumber";
    this.labelCheckNumber.Size = new Size(432, 16 /*0x10*/);
    this.labelCheckNumber.TabIndex = 18;
    this.labelCheckNumber.Text = "[CheckNumber]";
    ((Control) this.buttonVoidTransaction).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance51).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance51).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance51).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance51).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonVoidTransaction).Appearance = (AppearanceBase) appearance51;
    ((Control) this.buttonVoidTransaction).Location = new Point(809, 75);
    ((Control) this.buttonVoidTransaction).Name = "buttonVoidTransaction";
    ((Control) this.buttonVoidTransaction).Size = new Size(104, 24);
    ((Control) this.buttonVoidTransaction).TabIndex = 10;
    ((Control) this.buttonVoidTransaction).Text = "Void Transaction";
    ((UltraControlBase) this.buttonVoidTransaction).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonVoidTransaction).Click += new EventHandler(this.buttonVoidTransaction_Click);
    ((Control) this.buttonPrint).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance52).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance52).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance52).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance52).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonPrint).Appearance = (AppearanceBase) appearance52;
    ((Control) this.buttonPrint).Location = new Point(705, 75);
    ((Control) this.buttonPrint).Name = "buttonPrint";
    ((Control) this.buttonPrint).Size = new Size(104, 24);
    ((Control) this.buttonPrint).TabIndex = 13;
    ((Control) this.buttonPrint).Text = "Print Transaction";
    ((UltraControlBase) this.buttonPrint).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonPrint).Click += new EventHandler(this.buttonPrint_Click);
    this.labelReceivedDate.AutoSize = true;
    this.labelReceivedDate.DataBindings.Add(new Binding("Text", (object) this.dsViewTransaction1, "TransactionHeader.ReceivedDate", true));
    this.labelReceivedDate.Location = new Point(104, 46);
    this.labelReceivedDate.Name = "labelReceivedDate";
    this.labelReceivedDate.Size = new Size(85, 13);
    this.labelReceivedDate.TabIndex = 17;
    this.labelReceivedDate.Text = "[Received Date]";
    this.label15.AutoSize = true;
    this.label15.Location = new Point(8, 46);
    this.label15.Name = "label15";
    this.label15.Size = new Size(81, 13);
    this.label15.TabIndex = 16 /*0x10*/;
    this.label15.Text = "Received Date:";
    this.lblVoidedTransactions.AutoSize = true;
    this.lblVoidedTransactions.Location = new Point(264, 84);
    this.lblVoidedTransactions.Name = "lblVoidedTransactions";
    this.lblVoidedTransactions.Size = new Size(94, 13);
    this.lblVoidedTransactions.TabIndex = 15;
    this.lblVoidedTransactions.Text = "Transaction Voids ";
    this.linkVoidedTransactions.AutoSize = true;
    this.linkVoidedTransactions.DataBindings.Add(new Binding("Text", (object) this.dsViewTransaction1, "TransactionHeader.VoidTransaction", true));
    this.linkVoidedTransactions.Location = new Point(424, 84);
    this.linkVoidedTransactions.Name = "linkVoidedTransactions";
    this.linkVoidedTransactions.Size = new Size(59, 13);
    this.linkVoidedTransactions.TabIndex = 14;
    this.linkVoidedTransactions.TabStop = true;
    this.linkVoidedTransactions.Text = "[VoidedBy]";
    this.linkVoidedTransactions.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkVoidedTransactions_LinkClicked);
    this.lblPayeeRemitter.DataBindings.Add(new Binding("Text", (object) this.dsViewTransaction1, "TransactionHeader.PayeeRemitter", true));
    this.lblPayeeRemitter.Location = new Point(264, 65);
    this.lblPayeeRemitter.Name = "lblPayeeRemitter";
    this.lblPayeeRemitter.Size = new Size(432, 16 /*0x10*/);
    this.lblPayeeRemitter.TabIndex = 12;
    this.lblPayeeRemitter.Text = "[PayeeRemitter]";
    this.linkChangeDate.AutoSize = true;
    this.linkChangeDate.Location = new Point(264, 27);
    this.linkChangeDate.Name = "linkChangeDate";
    this.linkChangeDate.Size = new Size(94, 13);
    this.linkChangeDate.TabIndex = 11;
    this.linkChangeDate.TabStop = true;
    this.linkChangeDate.Text = "Change Post Date";
    this.linkChangeDate.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkChangeDate_LinkClicked);
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.daViewTransaction_Summary.SelectCommand = this.SqlSelectCommand7;
    this.daViewTransaction_Summary.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_ViewTransaction_Summary", new DataColumnMapping[7]
      {
        new DataColumnMapping("Cash", "Cash"),
        new DataColumnMapping("Receivables", "Receivables"),
        new DataColumnMapping("Payables", "Payables"),
        new DataColumnMapping("Exchange", "Exchange"),
        new DataColumnMapping("Income", "Income"),
        new DataColumnMapping("UnAccounted", "UnAccounted"),
        new DataColumnMapping("Expenses", "Expenses")
      })
    });
    this.SqlSelectCommand7.CommandText = "[spFin_ViewTransaction_Summary]";
    this.SqlSelectCommand7.CommandTimeout = 120;
    this.SqlSelectCommand7.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand7.Connection = this.FormDataConnection;
    this.SqlSelectCommand7.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@transactNum", SqlDbType.Int, 4)
    });
    this.daViewTransaction_PO.SelectCommand = this.SqlSelectCommand5;
    this.daViewTransaction_PO.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_ViewTransaction_Linked", new DataColumnMapping[3]
      {
        new DataColumnMapping("officeinvoicenum", "officeinvoicenum"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("Amount", "Amount")
      })
    });
    this.SqlSelectCommand5.CommandText = "spFin_ViewTransaction_PO";
    this.SqlSelectCommand5.CommandTimeout = 120;
    this.SqlSelectCommand5.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand5.Connection = this.FormDataConnection;
    this.SqlSelectCommand5.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@transactNum", SqlDbType.Int, 4)
    });
    this.daViewTransaction_Distributions.SelectCommand = this.SqlSelectCommand2;
    this.daViewTransaction_Distributions.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_ViewTransaction_Distributions", new DataColumnMapping[5]
      {
        new DataColumnMapping("glAccountId", "glAccountId"),
        new DataColumnMapping("fullName", "fullName"),
        new DataColumnMapping("accountType", "accountType"),
        new DataColumnMapping("debitAmount", "debitAmount"),
        new DataColumnMapping("creditAmount", "creditAmount")
      })
    });
    this.SqlSelectCommand2.CommandText = "[spFin_ViewTransaction_Distributions]";
    this.SqlSelectCommand2.CommandTimeout = 120;
    this.SqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand2.Connection = this.FormDataConnection;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@transactNum", SqlDbType.Int, 4)
    });
    this.daViewTransaction_AffectedInvoices.SelectCommand = this.SqlSelectCommand3;
    this.daViewTransaction_AffectedInvoices.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_ViewTransactions_AffectedInvoices", new DataColumnMapping[6]
      {
        new DataColumnMapping("policyNumber", "policyNumber"),
        new DataColumnMapping("officeInvoiceNum", "officeInvoiceNum"),
        new DataColumnMapping("Company", "Company"),
        new DataColumnMapping("producerName", "producerName"),
        new DataColumnMapping("InsuredName", "InsuredName"),
        new DataColumnMapping("amount", "amount")
      })
    });
    this.SqlSelectCommand3.CommandText = "[spFin_ViewTransactions_AffectedInvoices]";
    this.SqlSelectCommand3.CommandTimeout = 120;
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.FormDataConnection;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@transactNum", SqlDbType.Int, 4)
    });
    this.daViewTransaction_Verbage.SelectCommand = this.SqlSelectCommand4;
    this.daViewTransaction_Verbage.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_ViewTransaction_Verbage", new DataColumnMapping[5]
      {
        new DataColumnMapping("transactionType", "transactionType"),
        new DataColumnMapping("extendedTransactionType", "extendedTransactionType"),
        new DataColumnMapping("transactionDateString", "transactionDateString"),
        new DataColumnMapping("transactionDate", "transactionDate"),
        new DataColumnMapping("transactionAmount", "transactionAmount")
      })
    });
    this.SqlSelectCommand4.CommandText = "[spFin_ViewTransaction_Verbage]";
    this.SqlSelectCommand4.CommandTimeout = 120;
    this.SqlSelectCommand4.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand4.Connection = this.FormDataConnection;
    this.SqlSelectCommand4.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@transactNum", SqlDbType.Int, 4)
    });
    this.daViewTransaction_Header.SelectCommand = this.SqlSelectCommand1;
    this.daViewTransaction_Header.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_ViewTransaction_Header", new DataColumnMapping[4]
      {
        new DataColumnMapping("transactNum", "transactNum"),
        new DataColumnMapping("postDate", "postDate"),
        new DataColumnMapping("transDescription", "transDescription"),
        new DataColumnMapping("User", "User")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_ViewTransaction_Header]";
    this.SqlSelectCommand1.CommandTimeout = 120;
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@transactNum", SqlDbType.Int, 4)
    });
    this.daViewTransaction_Commissions.SelectCommand = this.SqlSelectCommand6;
    this.daViewTransaction_Commissions.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_ViewTransaction_Commissions", new DataColumnMapping[4]
      {
        new DataColumnMapping("officeinvoicenum", "officeinvoicenum"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("Account", "Account"),
        new DataColumnMapping("Amount", "Amount")
      })
    });
    this.SqlSelectCommand6.CommandText = "[spFin_ViewTransaction_Commissions]";
    this.SqlSelectCommand6.CommandTimeout = 120;
    this.SqlSelectCommand6.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand6.Connection = this.FormDataConnection;
    this.SqlSelectCommand6.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@transactNum", SqlDbType.Int, 4)
    });
    this.panelLoading.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelLoading.Controls.Add((Control) this.panel2);
    this.panelLoading.Location = new Point(0, 0);
    this.panelLoading.Name = "panelLoading";
    this.panelLoading.Size = new Size(913, 604);
    this.panelLoading.TabIndex = 13;
    this.panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panel2.BackColor = Color.FromArgb(239, 247, 253);
    this.panel2.Controls.Add((Control) this.animationControl1);
    this.panel2.Controls.Add((Control) this.labelLoadStatus);
    this.panel2.Controls.Add((Control) this.label13);
    this.panel2.Cursor = Cursors.WaitCursor;
    this.panel2.Location = new Point(8, 8);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(897, 588);
    this.panel2.TabIndex = 2;
    ((Control) this.animationControl1).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.animationControl1.AnimationSource = (AnimationType) 160 /*0xA0*/;
    this.animationControl1.AutoCenter = true;
    this.animationControl1.AutoPlay = true;
    this.animationControl1.BorderStyle = BorderStyle.None;
    ((Control) this.animationControl1).Location = new Point(8, 412);
    ((Control) this.animationControl1).Name = "animationControl1";
    ((Control) this.animationControl1).Size = new Size(881, 60);
    ((Control) this.animationControl1).TabIndex = 2;
    this.labelLoadStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.labelLoadStatus.BackColor = Color.Transparent;
    this.labelLoadStatus.Font = new Font("Tahoma", 8.5f);
    this.labelLoadStatus.Location = new Point(24, 48 /*0x30*/);
    this.labelLoadStatus.Name = "labelLoadStatus";
    this.labelLoadStatus.Size = new Size(849, 208 /*0xD0*/);
    this.labelLoadStatus.TabIndex = 1;
    this.labelLoadStatus.TextAlign = ContentAlignment.TopCenter;
    this.label13.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.label13.Font = new Font("Tahoma", 9f);
    this.label13.Location = new Point(24, 16 /*0x10*/);
    this.label13.Name = "label13";
    this.label13.Size = new Size(849, 24);
    this.label13.TabIndex = 0;
    this.label13.Text = "Loading Transaction...";
    this.label13.TextAlign = ContentAlignment.MiddleCenter;
    ((AppearanceBase) appearance53).BackColor = Color.White;
    ((AppearanceBase) appearance53).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance53).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEditComments).Appearance = (AppearanceBase) appearance53;
    ((Control) this.textEditComments).BackColor = Color.White;
    ((Control) this.textEditComments).Location = new Point(5, 4);
    this.textEditComments.MGAStyle = MGAStyles.Blue;
    this.textEditComments.Multiline = true;
    ((Control) this.textEditComments).Name = "textEditComments";
    ((Control) this.textEditComments).Size = new Size(505, 121);
    ((Control) this.textEditComments).TabIndex = 20;
    ((UltraControlBase) this.textEditComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEditComments).UseOsThemes = (DefaultableBoolean) 2;
    this.panelEditComment.BackColor = Color.FromArgb(246, 250, 253);
    this.panelEditComment.BorderColor = Color.SteelBlue;
    this.panelEditComment.Controls.Add((Control) this.buttonCancelEditComment);
    this.panelEditComment.Controls.Add((Control) this.buttonSaveEditComment);
    this.panelEditComment.Controls.Add((Control) this.textEditComments);
    this.panelEditComment.Location = new Point(377, 9);
    this.panelEditComment.Name = "panelEditComment";
    this.panelEditComment.Size = new Size(514, 156);
    this.panelEditComment.TabIndex = 14;
    this.panelEditComment.Visible = false;
    ((AppearanceBase) appearance54).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance54).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance54).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance54).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance54).Image = (object) Resources.delete;
    ((AppearanceBase) appearance54).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance54).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancelEditComment).Appearance = (AppearanceBase) appearance54;
    ((Control) this.buttonCancelEditComment).Location = new Point(479, 128 /*0x80*/);
    ((Control) this.buttonCancelEditComment).Name = "buttonCancelEditComment";
    ((Control) this.buttonCancelEditComment).Size = new Size(24, 24);
    ((Control) this.buttonCancelEditComment).TabIndex = 22;
    ((UltraControlBase) this.buttonCancelEditComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.buttonCancelEditComment).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancelEditComment).Click += new EventHandler(this.buttonCancelEditComment_Click);
    ((AppearanceBase) appearance55).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance55).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance55).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance55).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance55).Image = (object) Resources.disk;
    ((AppearanceBase) appearance55).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance55).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSaveEditComment).Appearance = (AppearanceBase) appearance55;
    ((Control) this.buttonSaveEditComment).Location = new Point(453, 128 /*0x80*/);
    ((Control) this.buttonSaveEditComment).Name = "buttonSaveEditComment";
    ((Control) this.buttonSaveEditComment).Size = new Size(24, 24);
    ((Control) this.buttonSaveEditComment).TabIndex = 21;
    ((UltraControlBase) this.buttonSaveEditComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.buttonSaveEditComment).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSaveEditComment).Click += new EventHandler(this.buttonSaveEditComment_Click);
    ((AppearanceBase) appearance56).BackColor = Color.White;
    ((AppearanceBase) appearance56).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaims).DisplayLayout.Appearance = (AppearanceBase) appearance56;
    ((UltraGridBase) this.gridClaims).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand4.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridClaims).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.gridClaims).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance57).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance57).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance57).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance57;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance58).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance58).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance58;
    ((AppearanceBase) appearance59).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance59).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance60).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance60;
    ((AppearanceBase) appearance61).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance61;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance62).BackColor = Color.Transparent;
    ((AppearanceBase) appearance62).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaims).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance62;
    ((AppearanceBase) appearance63).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance63).BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance63;
    ((AppearanceBase) appearance64).BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance64;
    ((UltraGridBase) this.gridClaims).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((Control) this.gridClaims).Dock = DockStyle.Fill;
    ((Control) this.gridClaims).Location = new Point(0, 0);
    ((Control) this.gridClaims).Name = "gridClaims";
    ((Control) this.gridClaims).Size = new Size(913, 431);
    ((Control) this.gridClaims).TabIndex = 0;
    ((UltraControlBase) this.gridClaims).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaims).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(915, 604);
    this.Controls.Add((Control) this.panelEditComment);
    this.Controls.Add((Control) this.UltraTabControl1);
    this.Controls.Add((Control) this.panelTransactionTotals);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.panelLoading);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MinimumSize = new Size(931, 643);
    this.Name = nameof (formTransactionViewer);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Posted Transaction Viewer";
    this.Load += new EventHandler(this.formTransactionViewer_Load);
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    ((ISupportInitialize) this.gridPostedInvoices).EndInit();
    this.dsViewTransaction1.EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.gridDistributions).EndInit();
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((ISupportInitialize) this.gridLinkedTransaction).EndInit();
    ((Control) this.ultraTabPageControl3).ResumeLayout(false);
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    this.panelTransactionTotals.ResumeLayout(false);
    this.panelTransactionTotals.PerformLayout();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    ((ISupportInitialize) this.buttonVoidTransaction).EndInit();
    ((ISupportInitialize) this.buttonPrint).EndInit();
    this.panelLoading.ResumeLayout(false);
    this.panel2.ResumeLayout(false);
    ((ISupportInitialize) this.textEditComments).EndInit();
    this.panelEditComment.ResumeLayout(false);
    this.panelEditComment.PerformLayout();
    ((ISupportInitialize) this.buttonCancelEditComment).EndInit();
    ((ISupportInitialize) this.buttonSaveEditComment).EndInit();
    ((ISupportInitialize) this.gridClaims).EndInit();
    this.ResumeLayout(false);
  }

  protected int TransactionNumber => this._transactionNumber;

  private void LoadTransaction()
  {
    using (BackgroundWorker worker = new BackgroundWorker())
    {
      worker.WorkerReportsProgress = true;
      worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.LoadTransactionCompleted);
      worker.DoWork += (DoWorkEventHandler) ((sender, e) =>
      {
        this._ds = new dsViewTransaction();
        worker.ReportProgress(0, (object) "Loading Transaction Header...");
        DefaultDatabase.LoadDataTable((DataTable) this._ds.TransactionHeader, this.ViewBuilderStoredProcedure, new object[2]
        {
          (object) "@transactNum",
          (object) this.TransactionNumber
        });
        worker.ReportProgress(0, (object) "Loading Invoices...");
        DefaultDatabase.LoadDataTable((DataTable) this._ds.AffectedInvoices, "dbo.spFin_ViewTransactions_AffectedInvoices", new object[2]
        {
          (object) "@transactNum",
          (object) this.TransactionNumber
        });
        worker.ReportProgress(0, (object) "Loading Transaction Distributions Log...");
        DefaultDatabase.LoadDataTable((DataTable) this._ds.Distributions, "dbo.spFin_ViewTransaction_Distributions", new object[2]
        {
          (object) "@transactNum",
          (object) this.TransactionNumber
        });
        worker.ReportProgress(0, (object) "Loading Linked Transactions...");
        DefaultDatabase.LoadDataTable((DataTable) this._ds.POExpense, "dbo.spFin_ViewTransaction_PO", new object[2]
        {
          (object) "@transactNum",
          (object) this.TransactionNumber
        });
        worker.ReportProgress(0, (object) "Loading Summerized Transaction Information...");
        DefaultDatabase.LoadDataTable((DataTable) this._ds.Summary, "dbo.spFin_ViewTransaction_Summary", new object[2]
        {
          (object) "@transactNum",
          (object) this.TransactionNumber
        });
        this.LoadTransactionClaimData(this.TransactionNumber);
        this.AddSummaryToExpensesGrid();
      });
      worker.ProgressChanged += (ProgressChangedEventHandler) ((sender, e) =>
      {
        if (this.IsDisposed || this.Disposing)
          return;
        this.UpdateStatus(e.UserState as string);
      });
      worker.RunWorkerAsync();
    }
  }

  private void AddSummaryToExpensesGrid()
  {
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Override.SummaryFooterAppearance.BackColor = Color.LightSteelBlue;
    UltraGridBand band = ((UltraGridBase) this.gridLinkedTransaction).DisplayLayout.Bands[0];
    band.Summaries.Clear();
    SummarySettings summarySettings = band.Summaries.Add("AmountSum", (SummaryType) 1, band.Columns["Amount"], (SummaryPosition) 3);
    summarySettings.Appearance.BackColor = Color.LightSteelBlue;
    summarySettings.Appearance.FontData.Bold = (DefaultableBoolean) 1;
    summarySettings.Appearance.TextHAlign = (HAlign) 3;
    summarySettings.DisplayFormat = "{0:c}";
  }

  protected virtual void LoadTransactionClaimData(int transactNum)
  {
    ((UltraGridBase) this.gridClaims).DataSource = (object) DefaultDatabase.ExecuteDataTable(this.ClaimDataStoredProcedure, new object[2]
    {
      (object) "@transactNum",
      (object) transactNum
    });
    foreach (UltraGridColumn column in ((UltraGridBase) this.gridClaims).DisplayLayout.Bands[0].Columns)
    {
      if (column.DataType == typeof (Decimal))
      {
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 3;
        column.CellAppearance.TextHAlign = (HAlign) 3;
        column.Format = "c";
      }
      else
      {
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 1;
        column.CellAppearance.TextHAlign = (HAlign) 1;
      }
    }
  }

  protected virtual void LoadTransactionCompleted(object sender, RunWorkerCompletedEventArgs e)
  {
    this.UpdateStatus("Binding Display...");
    ((UltraGridBase) this.gridPostedInvoices).DataSource = (object) this._ds;
    ((UltraGridBase) this.gridLinkedTransaction).DataSource = (object) this._ds;
    ((UltraGridBase) this.gridDistributions).DataSource = (object) this._ds;
    this.labelTransactionNumber.DataBindings.Clear();
    this.labelTransactionNumber.DataBindings.Add("Text", (object) this._ds.TransactionHeader, "TransactNum");
    this.labelTransactionType.DataBindings.Clear();
    this.labelTransactionType.DataBindings.Add("Text", (object) this._ds.TransactionHeader, "transDescription");
    ((Control) this.buttonVoidTransaction).Enabled = this.labelTransactionType.Text.Trim().ToLower() != "invoice" && this.labelTransactionType.Text.Trim().ToLower() != "void";
    this.labelEnteredBy.DataBindings.Clear();
    this.labelEnteredBy.DataBindings.Add("Text", (object) this._ds.TransactionHeader, "User");
    this.labelTransactionDate.DataBindings.Clear();
    this.labelTransactionDate.DataBindings.Add("Text", (object) this._ds.TransactionHeader, "PostDate");
    this.labelPostingComment.DataBindings.Clear();
    this.labelPostingComment.DataBindings.Add("Text", (object) this._ds.TransactionHeader, "Comments");
    this.lblPayeeRemitter.DataBindings.Clear();
    this.lblPayeeRemitter.DataBindings.Add("Text", (object) this._ds.TransactionHeader, "PayeeRemmitter");
    this.lblPayeeRemitter.UseMnemonic = false;
    this.labelCheckNumber.DataBindings.Clear();
    this.labelCheckNumber.DataBindings.Add("Text", (object) this._ds.TransactionHeader, "CheckNumber");
    this.labelReceivedDate.DataBindings.Clear();
    this.labelReceivedDate.DataBindings.Add("Text", (object) this._ds.TransactionHeader, "ReceivedDate");
    this.ResetTimeStamp();
    this.txtCash.Text = this._ds.Summary.Rows[0].Field<Decimal>("cash").ToString("c");
    this.txtReceivables.Text = this._ds.Summary.Rows[0].Field<Decimal>("Receivables").ToString("c");
    this.txtPayables.Text = this._ds.Summary.Rows[0].Field<Decimal>("Payables").ToString("c");
    this.txtIncome.Text = this._ds.Summary.Rows[0].Field<Decimal>("Income").ToString("c");
    this.txtExchange.Text = this._ds.Summary.Rows[0].Field<Decimal>("Exchange").ToString("c");
    this.txtUnAccounted.Text = this._ds.Summary.Rows[0].Field<Decimal>("UnAccounted").ToString("c");
    this.txtExpenses.Text = this._ds.Summary.Rows[0].Field<Decimal>("Expenses").ToString("c");
    this.UpdateStatus("Load Complete!");
    this.panelLoading.Visible = false;
    if (this._ds.TransactionHeader.Rows.Count > 0 && !Utility.IsNull(this._ds.TransactionHeader.Rows[0]["VoidTransaction"]))
    {
      this.linkVoidedTransactions.Visible = true;
      this.lblVoidedTransactions.Visible = true;
      if (this._ds.TransactionHeader.Rows[0].Field<string>("transDescription").ToUpper() == "VOID")
        this.lblVoidedTransactions.Text = " This Transaction Voids : ";
      else
        this.lblVoidedTransactions.Text = " This transaction is voided by : ";
      this.linkVoidedTransactions.Text = this._ds.TransactionHeader.Rows[0].Field<int>("VoidTransaction").ToString();
    }
    else
    {
      this.linkVoidedTransactions.Visible = false;
      this.lblVoidedTransactions.Visible = false;
    }
  }

  private void ResetTimeStamp()
  {
    if (this._ds.TransactionHeader.Columns.Contains("Created"))
    {
      ((Control) this.userTimestampUltraStatusBar).Enabled = true;
      ((Control) this.userTimestampUltraStatusBar).Visible = true;
      ((Control) this.userTimestampUltraStatusBar).DataBindings.Clear();
      ((Control) this.userTimestampUltraStatusBar).DataBindings.Add("Text", (object) this._ds.TransactionHeader, "Created");
      ((Control) this.userTimestampUltraStatusBar).Text = "Transaction Input Date: " + ((Control) this.userTimestampUltraStatusBar).Text;
    }
    else
    {
      ((Control) this.userTimestampUltraStatusBar).Enabled = false;
      ((Control) this.userTimestampUltraStatusBar).Visible = false;
    }
  }

  private void UpdateStatus(string statusMessage)
  {
    Label labelLoadStatus = this.labelLoadStatus;
    labelLoadStatus.Text = $"{labelLoadStatus.Text}\n{statusMessage}";
    this.labelLoadStatus.Refresh();
  }

  private void buttonVoidTransaction_Click(object sender, EventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission("{1A4F865E-ABC2-47c1-A976-77B4348F33F3}"))
    {
      new formAccessDenied().Show();
    }
    else
    {
      using (formVoidTransaction form = (formVoidTransaction) ObjectFactory.Instance.CreateForm(typeof (formVoidTransaction), new object[1]
      {
        (object) this._transactionNumber
      }))
      {
        if (form.ShowDialog() == DialogResult.OK)
          this.OnTransactionChanged();
        this.Close();
      }
    }
  }

  private void formTransactionViewer_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.panelLoading.BringToFront();
    this._glCompanyId = Utility.GetTransactionGLCompanyId(this._transactionNumber);
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    CurrentUser.Instance.LogAction($"Viewed transaction #{this._transactionNumber}", "Accounting Logs");
    this.LoadTransaction();
    this.linkChangeDate.Visible = SecurityManager.Instance.AssertPermission("{5AE7C614-A609-4ab5-A960-171E18062414}");
    this.ShowUnreconcileLink();
  }

  protected virtual void OnTransactionChanged()
  {
    if (this.TransactionChanged == null)
      return;
    this.TransactionChanged((object) this, new EventArgs());
  }

  private void linkChangeDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!AccountingCache.Instance.GlCompany(this._glCompanyId).ViolatesClosedDate(DateTime.Parse(this.labelTransactionDate.Text)))
    {
      int num = (int) MessageBox.Show("This entry you are trying to edit is in a closed accounting period.");
    }
    else
    {
      using (formChangeTransactionDate form = (formChangeTransactionDate) ObjectFactory.Instance.CreateForm(typeof (formChangeTransactionDate), new object[1]
      {
        (object) this._transactionNumber
      }))
      {
        if (form.ShowDialog() == DialogResult.OK)
          this.labelTransactionDate.Text = form.NewDate.ToShortDateString();
        this.OnTransactionChanged();
      }
    }
  }

  private void buttonPrint_Click(object sender, EventArgs e)
  {
    ReportFactory.Instance.ShowReport(false, typeof (rptJournalTransaction), (object) this._transactionNumber);
  }

  public event formTransactionViewer.OnTransactionChangedHandler TransactionChanged;

  private void linkVoidedTransactions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.labelLoadStatus.Text = string.Empty;
    this.panelLoading.Visible = true;
    this.panel2.Visible = true;
    this.Refresh();
    if (this._ds.TransactionHeader.Rows.Count <= 0 || Utility.IsNull(this._ds.TransactionHeader.Rows[0]["VoidTransaction"]))
      return;
    this._transactionNumber = int.Parse(this.linkVoidedTransactions.Text);
    this.LoadTransaction();
  }

  private void linkEditSaveComments_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.panelEditComment.Visible)
      return;
    ((Control) this.textEditComments).Text = this.labelPostingComment.Text;
    this.panelEditComment.Visible = true;
  }

  private void buttonSaveEditComment_Click(object sender, EventArgs e)
  {
    DefaultDatabase.ExecuteNonQuery("spFin_UpdateTransactionComment", new object[4]
    {
      (object) "@transactNum",
      (object) this._transactionNumber,
      (object) "@comments",
      (object) ((Control) this.textEditComments).Text
    });
    this.labelPostingComment.Text = ((Control) this.textEditComments).Text;
    ((Control) this.textEditComments).Text = string.Empty;
    this.panelEditComment.Visible = false;
  }

  private void buttonCancelEditComment_Click(object sender, EventArgs e)
  {
    this.panelEditComment.Visible = false;
    ((Control) this.textEditComments).Text = string.Empty;
  }

  private void linkUnreconcile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (!SecurityManager.Instance.AssertPermission(this.BANKSECURITY_RECONCILEUNRECONCILE))
    {
      int num1 = (int) MessageBox.Show("You do not have sufficient rights to complete this action.", "Insufficient Rights!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      int bankGLAcct = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "Select dbo.GetTransactionBankAccount(@transactNum)", new object[2]
      {
        (object) "@transactNum",
        (object) this._transactionNumber
      });
      if (bankGLAcct == -1)
      {
        int num2 = (int) MessageBox.Show("The cash account for the given transaction could not be determined.", "Cash Account Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        if (MessageBox.Show("This will unreconcile the current transaction. This action cannot be undone. Continue?", "Un-Reconcile Transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((execSender, execArgs) =>
        {
          DefaultDatabase.ExecuteNonQuery("spfin_UnreconcileTransaction", new object[6]
          {
            (object) "@TransactionId",
            (object) this._transactionNumber,
            (object) "@isDeposit",
            (object) 0,
            (object) "@bankGLAcct",
            (object) bankGLAcct
          });
          CurrentUser.Instance.LogAction($"User unreconciled transaction # {this._transactionNumber}", "Banking Logs");
          execArgs.Transaction.Commit();
        }));
        this.ShowUnreconcileLink();
      }
    }
  }

  private void ShowUnreconcileLink()
  {
    bool flag = false;
    if (!SecurityManager.Instance.AssertPermission(this.BANKSECURITY_RECONCILEUNRECONCILE))
      return;
    int num = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "Select dbo.GetTransactionBankAccount(@transactNum)", new object[2]
    {
      (object) "@transactNum",
      (object) this._transactionNumber
    });
    if (num != -1)
      flag = DefaultDatabase.ExecuteScalar<bool>(CommandType.Text, "Select dbo.IsTransactionReconciled(@transactNum, @bankGLAcct)", new object[4]
      {
        (object) "@transactNum",
        (object) this._transactionNumber,
        (object) "@bankGLAcct",
        (object) num
      });
    this.linkUnreconcile.Visible = flag;
  }

  [EditorBrowsable(EditorBrowsableState.Never)]
  public delegate void OnTransactionChangedHandler(object sender, EventArgs e);
}
