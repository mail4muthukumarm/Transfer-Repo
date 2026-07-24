// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.BankManagementHome
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.UltraChart.Resources.Appearance;
using Infragistics.UltraChart.Shared.Styles;
using Infragistics.Win;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Banking.Forms;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class BankManagementHome : UserControl
{
  private bool disableCustomDrawing;
  private IContainer components;
  private DataSet ds;
  private DataSet dsReceivables;
  private DataSet dsPayables;
  private Thread ChartDataThread;
  private Thread ReceivableLoadingThread;
  private Thread PayableLoadingThread;
  private int CurrentGLCompanyId;

  public BankManagementHome()
  {
    this.Load += new EventHandler(this.BankManagementHome_Load);
    this.disableCustomDrawing = SystemInformation.TerminalServerSession || this.DesignMode;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      try
      {
        if (this.ChartDataThread != null)
        {
          if (this.ChartDataThread.ThreadState != System.Threading.ThreadState.Stopped)
            this.ChartDataThread.Abort();
        }
      }
      catch (ThreadAbortException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (this.ReceivableLoadingThread != null)
        {
          if (this.ReceivableLoadingThread.ThreadState != System.Threading.ThreadState.Stopped)
            this.ReceivableLoadingThread.Abort();
        }
      }
      catch (ThreadAbortException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (this.PayableLoadingThread != null)
        {
          if (this.PayableLoadingThread.ThreadState != System.Threading.ThreadState.Stopped)
            this.PayableLoadingThread.Abort();
        }
      }
      catch (ThreadAbortException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
      if (this.components != null)
        this.components.Dispose();
    }
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("DsBankingHomeChartData1")]
  internal virtual dsBankingHomeChartData DsBankingHomeChartData1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankingHome_BankAccounts")]
  internal virtual SqlDataAdapter daGetBankingHome_BankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ControlDataConnection")]
  internal virtual SqlConnection ControlDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankingReceivablesDue1")]
  internal virtual dsBankingReceivablesDue DsBankingReceivablesDue1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankReceivablesDue")]
  internal virtual SqlDataAdapter daGetBankReceivablesDue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand2")]
  internal virtual SqlCommand SqlSelectCommand2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankingReceivablesDue2")]
  internal virtual dsBankingReceivablesDue DsBankingReceivablesDue2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  internal virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankingPayablesDue")]
  internal virtual SqlDataAdapter daGetBankingPayablesDue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraChart1")]
  internal virtual Infragistics.Win.UltraWinChart.UltraChart UltraChart1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsCashFlow1")]
  internal virtual dsCashFlow DsCashFlow1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetCashFlow")]
  internal virtual SqlDataAdapter daGetCashFlow { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand4")]
  internal virtual SqlCommand SqlSelectCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelLoadingCurtain")]
  internal virtual Panel panelLoadingCurtain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox4")]
  internal virtual PictureBox PictureBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelNoData")]
  internal virtual Panel panelNoData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraExplorerBar UltraExplorerBar1
  {
    get => this._UltraExplorerBar1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      GroupCollapsingEventHandler collapsingEventHandler = new GroupCollapsingEventHandler(this.UltraExplorerBar1_GroupCollapsing);
      UltraExplorerBar ultraExplorerBar1_1 = this._UltraExplorerBar1;
      if (ultraExplorerBar1_1 != null)
        ultraExplorerBar1_1.GroupCollapsing -= collapsingEventHandler;
      this._UltraExplorerBar1 = value;
      UltraExplorerBar ultraExplorerBar1_2 = this._UltraExplorerBar1;
      if (ultraExplorerBar1_2 == null)
        return;
      ultraExplorerBar1_2.GroupCollapsing += collapsingEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraExplorerBarContainerControl1")]
  internal virtual UltraExplorerBarContainerControl UltraExplorerBarContainerControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraExplorerBarContainerControl2")]
  internal virtual UltraExplorerBarContainerControl UltraExplorerBarContainerControl2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraExplorerBarContainerControl3")]
  internal virtual UltraExplorerBarContainerControl UltraExplorerBarContainerControl3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("llOrderChecks")]
  internal virtual LinkLabel llOrderChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("LinkLabel2")]
  internal virtual LinkLabel LinkLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("llCheckNumbers")]
  internal virtual LinkLabel llCheckNumbers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("llCheckPrinters")]
  internal virtual LinkLabel llCheckPrinters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelLoadingPayables")]
  internal virtual Label labelLoadingPayables { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelLoadingReceivables")]
  internal virtual Label labelLoadingReceivables { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("LinkLabel4")]
  internal virtual LinkLabel LinkLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("LinkLabel1")]
  internal virtual LinkLabel LinkLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraGrid2")]
  internal virtual UltraGrid UltraGrid2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridReceivablesDue")]
  internal virtual UltraGrid gridReceivablesDue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ReceivablesDue", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("invoicenum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("officeinvoicenum");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("entityname");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("amount");
    Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("ReceivablesDue", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("invoicenum");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("officeinvoicenum");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("entityname");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("amount");
    Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BankManagementHome));
    LineChartAppearance lineChartAppearance = new LineChartAppearance();
    Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
    Infragistics.Win.Appearance appearance18 = new Infragistics.Win.Appearance();
    this.UltraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.labelLoadingPayables = new Label();
    this.labelLoadingReceivables = new Label();
    this.LinkLabel4 = new LinkLabel();
    this.LinkLabel1 = new LinkLabel();
    this.UltraGrid2 = new UltraGrid();
    this.DsBankingReceivablesDue2 = new dsBankingReceivablesDue();
    this.gridReceivablesDue = new UltraGrid();
    this.DsBankingReceivablesDue1 = new dsBankingReceivablesDue();
    this.UltraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.Label10 = new Label();
    this.llOrderChecks = new LinkLabel();
    this.Label9 = new Label();
    this.LinkLabel2 = new LinkLabel();
    this.Label6 = new Label();
    this.llCheckNumbers = new LinkLabel();
    this.Label5 = new Label();
    this.llCheckPrinters = new LinkLabel();
    this.UltraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.Label3 = new Label();
    this.panelNoData = new Panel();
    this.Label4 = new Label();
    this.panelLoadingCurtain = new Panel();
    this.Label1 = new Label();
    this.PictureBox4 = new PictureBox();
    this.UltraChart1 = new Infragistics.Win.UltraWinChart.UltraChart();
    this.DsBankingHomeChartData1 = new dsBankingHomeChartData();
    this.daGetBankingHome_BankAccounts = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ControlDataConnection = new SqlConnection();
    this.DsCashFlow1 = new dsCashFlow();
    this.daGetBankReceivablesDue = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.daGetBankingPayablesDue = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.daGetCashFlow = new SqlDataAdapter();
    this.SqlSelectCommand4 = new SqlCommand();
    this.UltraExplorerBar1 = new UltraExplorerBar();
    ((Control) this.UltraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.UltraGrid2).BeginInit();
    this.DsBankingReceivablesDue2.BeginInit();
    ((ISupportInitialize) this.gridReceivablesDue).BeginInit();
    this.DsBankingReceivablesDue1.BeginInit();
    ((Control) this.UltraExplorerBarContainerControl2).SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl3).SuspendLayout();
    this.panelNoData.SuspendLayout();
    this.panelLoadingCurtain.SuspendLayout();
    ((ISupportInitialize) this.PictureBox4).BeginInit();
    ((ISupportInitialize) this.UltraChart1).BeginInit();
    this.DsBankingHomeChartData1.BeginInit();
    this.DsCashFlow1.BeginInit();
    ((ISupportInitialize) this.UltraExplorerBar1).BeginInit();
    ((Control) this.UltraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.labelLoadingPayables);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.labelLoadingReceivables);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.LinkLabel4);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.LinkLabel1);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.UltraGrid2);
    ((Control) this.UltraExplorerBarContainerControl1).Controls.Add((Control) this.gridReceivablesDue);
    ((Control) this.UltraExplorerBarContainerControl1).Location = new Point(14, 36);
    ((Control) this.UltraExplorerBarContainerControl1).Name = "UltraExplorerBarContainerControl1";
    ((Control) this.UltraExplorerBarContainerControl1).Size = new Size(335, 280);
    ((Control) this.UltraExplorerBarContainerControl1).TabIndex = 0;
    this.labelLoadingPayables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.labelLoadingPayables.BackColor = Color.Transparent;
    this.labelLoadingPayables.Location = new Point(8, 184);
    this.labelLoadingPayables.Name = "labelLoadingPayables";
    this.labelLoadingPayables.Size = new Size(320, 104);
    this.labelLoadingPayables.TabIndex = 18;
    this.labelLoadingPayables.Text = "Loading...";
    this.labelLoadingPayables.TextAlign = ContentAlignment.MiddleCenter;
    this.labelLoadingReceivables.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.labelLoadingReceivables.BackColor = Color.Transparent;
    this.labelLoadingReceivables.Location = new Point(8, 48 /*0x30*/);
    this.labelLoadingReceivables.Name = "labelLoadingReceivables";
    this.labelLoadingReceivables.Size = new Size(320, 88);
    this.labelLoadingReceivables.TabIndex = 17;
    this.labelLoadingReceivables.Text = "Loading...";
    this.labelLoadingReceivables.TextAlign = ContentAlignment.MiddleCenter;
    this.LinkLabel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.LinkLabel4.AutoSize = true;
    this.LinkLabel4.BackColor = Color.Transparent;
    this.LinkLabel4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.LinkLabel4.LinkBehavior = LinkBehavior.NeverUnderline;
    this.LinkLabel4.LinkColor = Color.Gray;
    this.LinkLabel4.Location = new Point(240 /*0xF0*/, 136);
    this.LinkLabel4.Name = "LinkLabel4";
    this.LinkLabel4.Size = new Size(83, 13);
    this.LinkLabel4.TabIndex = 16 /*0x10*/;
    this.LinkLabel4.TabStop = true;
    this.LinkLabel4.Text = "Payables Due";
    this.LinkLabel4.VisitedLinkColor = Color.Gray;
    this.LinkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.LinkLabel1.AutoSize = true;
    this.LinkLabel1.BackColor = Color.Transparent;
    this.LinkLabel1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.LinkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
    this.LinkLabel1.LinkColor = Color.Gray;
    this.LinkLabel1.Location = new Point(233, 0);
    this.LinkLabel1.Name = "LinkLabel1";
    this.LinkLabel1.Size = new Size(100, 13);
    this.LinkLabel1.TabIndex = 15;
    this.LinkLabel1.TabStop = true;
    this.LinkLabel1.Text = "Receivables Due";
    this.LinkLabel1.VisitedLinkColor = Color.Gray;
    ((Control) this.UltraGrid2).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.UltraGrid2).DataSource = (object) this.DsBankingReceivablesDue2;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 70;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Invoice #";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 119;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Payee";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 110;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Amount";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 91;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    appearance4.BackColor = Color.GhostWhite;
    appearance4.FontData.BoldAsString = "True";
    appearance4.ForeColor = Color.Gray;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance5.BackColor = Color.FromArgb(239, 247, 253);
    appearance5.FontData.BoldAsString = "True";
    appearance5.ForeColor = Color.DarkSlateGray;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb(239, 247, 253);
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.GhostWhite;
    appearance7.BackColor2 = Color.GhostWhite;
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.ForeColor = SystemColors.MenuText;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Scrollbars = (Scrollbars) 0;
    ((Control) this.UltraGrid2).Location = new Point(8, 160 /*0xA0*/);
    ((Control) this.UltraGrid2).Name = "UltraGrid2";
    ((Control) this.UltraGrid2).Size = new Size(320, 112 /*0x70*/);
    ((Control) this.UltraGrid2).TabIndex = 14;
    ((UltraControlBase) this.UltraGrid2).UseOsThemes = (DefaultableBoolean) 2;
    this.DsBankingReceivablesDue2.DataSetName = "dsBankingReceivablesDue";
    this.DsBankingReceivablesDue2.Locale = new CultureInfo("en-US");
    ((Control) this.gridReceivablesDue).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridReceivablesDue).DataSource = (object) this.DsBankingReceivablesDue1;
    appearance8.BackColor = Color.FromArgb(239, 247, 253);
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 70;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Invoice #";
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 123;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Remitter";
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 108;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance9;
    ultraGridColumn8.Format = "c";
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Amount";
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn8.Width = 89;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    appearance11.BackColor = Color.GhostWhite;
    appearance11.FontData.BoldAsString = "True";
    appearance11.ForeColor = Color.Gray;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance12.BackColor = Color.FromArgb(239, 247, 253);
    appearance12.FontData.BoldAsString = "True";
    appearance12.ForeColor = Color.DarkSlateGray;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(239, 247, 253);
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance14.BackColor = Color.GhostWhite;
    appearance14.BackColor2 = Color.GhostWhite;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.ForeColor = SystemColors.MenuText;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Scrollbars = (Scrollbars) 0;
    ((Control) this.gridReceivablesDue).Location = new Point(8, 24);
    ((Control) this.gridReceivablesDue).Name = "gridReceivablesDue";
    ((Control) this.gridReceivablesDue).Size = new Size(320, 96 /*0x60*/);
    ((Control) this.gridReceivablesDue).TabIndex = 13;
    ((UltraControlBase) this.gridReceivablesDue).UseOsThemes = (DefaultableBoolean) 2;
    this.DsBankingReceivablesDue1.DataSetName = "dsBankingReceivablesDue";
    this.DsBankingReceivablesDue1.Locale = new CultureInfo("en-US");
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label10);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.llOrderChecks);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label9);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.LinkLabel2);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label6);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.llCheckNumbers);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.Label5);
    ((Control) this.UltraExplorerBarContainerControl2).Controls.Add((Control) this.llCheckPrinters);
    ((Control) this.UltraExplorerBarContainerControl2).Location = new Point(371, 36);
    ((Control) this.UltraExplorerBarContainerControl2).Name = "UltraExplorerBarContainerControl2";
    ((Control) this.UltraExplorerBarContainerControl2).Size = new Size(335, 280);
    ((Control) this.UltraExplorerBarContainerControl2).TabIndex = 1;
    this.Label10.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Location = new Point(8, 208 /*0xD0*/);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(320, 24);
    this.Label10.TabIndex = 23;
    this.Label10.Text = "Connect to your check stock vendor online.";
    this.llOrderChecks.AutoSize = true;
    this.llOrderChecks.BackColor = Color.Transparent;
    this.llOrderChecks.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.llOrderChecks.LinkBehavior = LinkBehavior.NeverUnderline;
    this.llOrderChecks.Location = new Point(8, 192 /*0xC0*/);
    this.llOrderChecks.Name = "llOrderChecks";
    this.llOrderChecks.Size = new Size(82, 13);
    this.llOrderChecks.TabIndex = 22;
    this.llOrderChecks.TabStop = true;
    this.llOrderChecks.Text = "Order Checks";
    this.llOrderChecks.VisitedLinkColor = Color.Blue;
    this.Label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(8, 152);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(312, 24);
    this.Label9.TabIndex = 21;
    this.Label9.Text = "Analyze corporate cash flow, spending and expenses.";
    this.LinkLabel2.AutoSize = true;
    this.LinkLabel2.BackColor = Color.Transparent;
    this.LinkLabel2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.LinkLabel2.LinkBehavior = LinkBehavior.NeverUnderline;
    this.LinkLabel2.Location = new Point(8, 136);
    this.LinkLabel2.Name = "LinkLabel2";
    this.LinkLabel2.Size = new Size(112 /*0x70*/, 13);
    this.LinkLabel2.TabIndex = 20;
    this.LinkLabel2.TabStop = true;
    this.LinkLabel2.Text = "Cash Flow Analysis";
    this.LinkLabel2.VisitedLinkColor = Color.Blue;
    this.Label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(8, 80 /*0x50*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(320, 40);
    this.Label6.TabIndex = 18;
    this.Label6.Text = "Verify the current check numbers for the bank account associated with the currently specified office location.";
    this.llCheckNumbers.AutoSize = true;
    this.llCheckNumbers.BackColor = Color.Transparent;
    this.llCheckNumbers.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.llCheckNumbers.LinkBehavior = LinkBehavior.NeverUnderline;
    this.llCheckNumbers.Location = new Point(8, 64 /*0x40*/);
    this.llCheckNumbers.Name = "llCheckNumbers";
    this.llCheckNumbers.Size = new Size(174, 13);
    this.llCheckNumbers.TabIndex = 17;
    this.llCheckNumbers.TabStop = true;
    this.llCheckNumbers.Text = "Bank Account Check Numbers";
    this.llCheckNumbers.VisitedLinkColor = Color.Blue;
    this.Label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(8, 24);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(242, 13);
    this.Label5.TabIndex = 16 /*0x10*/;
    this.Label5.Text = "Verify or edit your current check printer settings.";
    this.llCheckPrinters.AutoSize = true;
    this.llCheckPrinters.BackColor = Color.Transparent;
    this.llCheckPrinters.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.llCheckPrinters.LinkBehavior = LinkBehavior.NeverUnderline;
    this.llCheckPrinters.Location = new Point(8, 8);
    this.llCheckPrinters.Name = "llCheckPrinters";
    this.llCheckPrinters.Size = new Size(89, 13);
    this.llCheckPrinters.TabIndex = 15;
    this.llCheckPrinters.TabStop = true;
    this.llCheckPrinters.Text = "Check Printers";
    this.llCheckPrinters.VisitedLinkColor = Color.Blue;
    ((Control) this.UltraExplorerBarContainerControl3).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.UltraExplorerBarContainerControl3).Controls.Add((Control) this.Label3);
    ((Control) this.UltraExplorerBarContainerControl3).Controls.Add((Control) this.panelNoData);
    ((Control) this.UltraExplorerBarContainerControl3).Controls.Add((Control) this.panelLoadingCurtain);
    ((Control) this.UltraExplorerBarContainerControl3).Controls.Add((Control) this.UltraChart1);
    ((Control) this.UltraExplorerBarContainerControl3).Location = new Point(14, 360);
    ((Control) this.UltraExplorerBarContainerControl3).Name = "UltraExplorerBarContainerControl3";
    ((Control) this.UltraExplorerBarContainerControl3).Size = new Size(692, 235);
    ((Control) this.UltraExplorerBarContainerControl3).TabIndex = 2;
    this.Label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.DimGray;
    this.Label3.Location = new Point(8, 208 /*0xD0*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(673, 24);
    this.Label3.TabIndex = 11;
    this.Label3.Text = "The chart above represents the cash flow activity of the premium account for the specified office location. Results are for the current year and up til the current day.";
    this.Label3.TextAlign = ContentAlignment.TopCenter;
    this.panelNoData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelNoData.BackColor = Color.Transparent;
    this.panelNoData.Controls.Add((Control) this.Label4);
    this.panelNoData.Location = new Point(0, 0);
    this.panelNoData.Name = "panelNoData";
    this.panelNoData.Size = new Size(689, 192 /*0xC0*/);
    this.panelNoData.TabIndex = 14;
    this.panelNoData.Visible = false;
    this.Label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Label4.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label4.Location = new Point(8, 94);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(673, 16 /*0x10*/);
    this.Label4.TabIndex = 1;
    this.Label4.Text = "No data found!";
    this.Label4.TextAlign = ContentAlignment.MiddleCenter;
    this.panelLoadingCurtain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelLoadingCurtain.BackColor = Color.White;
    this.panelLoadingCurtain.Controls.Add((Control) this.Label1);
    this.panelLoadingCurtain.Controls.Add((Control) this.PictureBox4);
    this.panelLoadingCurtain.Location = new Point(0, 0);
    this.panelLoadingCurtain.Name = "panelLoadingCurtain";
    this.panelLoadingCurtain.Size = new Size(689, 192 /*0xC0*/);
    this.panelLoadingCurtain.TabIndex = 13;
    this.Label1.Anchor = AnchorStyles.Top;
    this.Label1.Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(288, 176 /*0xB0*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(152, 23);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Loading chart...";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    this.PictureBox4.Anchor = AnchorStyles.Top;
    this.PictureBox4.Image = (Image) componentResourceManager.GetObject("PictureBox4.Image");
    this.PictureBox4.Location = new Point(301, 25);
    this.PictureBox4.Name = "PictureBox4";
    this.PictureBox4.Size = new Size(85, 81);
    this.PictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox4.TabIndex = 0;
    this.PictureBox4.TabStop = false;
    ((Control) this.UltraChart1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraChart1.Axis.BackColor = Color.FromArgb((int) byte.MaxValue, 248, 220);
    this.UltraChart1.Axis.X.Extent = 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).HorizontalAlign = StringAlignment.Near;
    this.UltraChart1.Axis.X.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).Orientation = (TextOrientation) 2;
    this.UltraChart1.Axis.X.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.X.LineColor = Color.DarkGray;
    this.UltraChart1.Axis.X.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.X.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.X.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.X.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.X.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.X.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.X.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.X.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.X.TickmarkPercentage = 5.0;
    this.UltraChart1.Axis.X.TickmarkStyle = (AxisTickStyle) 0;
    this.UltraChart1.Axis.X.Visible = true;
    this.UltraChart1.Axis.X2.Extent = 100;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).HorizontalAlign = StringAlignment.Far;
    this.UltraChart1.Axis.X2.Labels.ItemFormatString = "<ITEM_LABEL>";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).Orientation = (TextOrientation) 0;
    this.UltraChart1.Axis.X2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).Orientation = (TextOrientation) 0;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.X2.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.X2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.X2.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.X2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.X2.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.X2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.X2.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.X2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.X2.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.X2.Visible = false;
    this.UltraChart1.Axis.Y.Extent = 75;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).Font = new Font("Microsoft Sans Serif", 7f);
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).HorizontalAlign = StringAlignment.Far;
    this.UltraChart1.Axis.Y.Labels.ItemFormatString = "<DATA_VALUE:c>";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).Orientation = (TextOrientation) 2;
    this.UltraChart1.Axis.Y.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Far;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Y.LineColor = Color.Silver;
    this.UltraChart1.Axis.Y.LogBase = 20.0;
    this.UltraChart1.Axis.Y.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Y.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.Y.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Y.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.Y.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Y.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.Y.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Y.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.Y.TickmarkPercentage = 7.0;
    this.UltraChart1.Axis.Y.Visible = true;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).HorizontalAlign = StringAlignment.Near;
    this.UltraChart1.Axis.Y2.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).Orientation = (TextOrientation) 2;
    this.UltraChart1.Axis.Y2.Labels.SeriesLabels.FormatString = "";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Y2.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Y2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Y2.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.Y2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Y2.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.Y2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Y2.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.Y2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Y2.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.Y2.Visible = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).HorizontalAlign = StringAlignment.Near;
    this.UltraChart1.Axis.Z.Labels.ItemFormatString = "<DATA_VALUE:00.00>";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Z.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Z.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.Z.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Z.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.Z.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Z.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.Z.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Z.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.Z.Visible = false;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).HorizontalAlign = StringAlignment.Near;
    this.UltraChart1.Axis.Z2.Labels.ItemFormatString = "";
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).HorizontalAlign = StringAlignment.Near;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).Orientation = (TextOrientation) 2;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels.SeriesLabels).VerticalAlign = StringAlignment.Center;
    ((AxisLabelAppearanceBase) this.UltraChart1.Axis.Z2.Labels).VerticalAlign = StringAlignment.Center;
    this.UltraChart1.Axis.Z2.MajorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Z2.MajorGridLines.Color = Color.Gainsboro;
    this.UltraChart1.Axis.Z2.MajorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Z2.MajorGridLines.Visible = true;
    this.UltraChart1.Axis.Z2.MinorGridLines.AlphaLevel = byte.MaxValue;
    this.UltraChart1.Axis.Z2.MinorGridLines.Color = Color.LightGray;
    this.UltraChart1.Axis.Z2.MinorGridLines.DrawStyle = (LineDrawStyle) 4;
    this.UltraChart1.Axis.Z2.MinorGridLines.Visible = false;
    this.UltraChart1.Axis.Z2.Visible = false;
    this.UltraChart1.BackgroundImageStyle = (ImageFitStyle) 2;
    this.UltraChart1.Border.Color = Color.DarkGray;
    this.UltraChart1.Border.CornerRadius = 20;
    this.UltraChart1.ChartType = (ChartType) 3;
    this.UltraChart1.ColorModel.AlphaLevel = (byte) 150;
    this.UltraChart1.ColorModel.ColorBegin = Color.White;
    this.UltraChart1.ColorModel.ColorEnd = Color.RoyalBlue;
    this.UltraChart1.ColorModel.ModelStyle = (ColorModels) 6;
    this.UltraChart1.Data.EmptyStyle.LineStyle.DrawStyle = (LineDrawStyle) 1;
    this.UltraChart1.Data.RowLabelsColumn = 1;
    this.UltraChart1.Data.UseRowLabelsColumn = true;
    this.UltraChart1.Data.ZeroAligned = true;
    lineChartAppearance.HighLightLines = true;
    lineChartAppearance.MidPointAnchors = false;
    lineChartAppearance.Thickness = 1;
    this.UltraChart1.LineChart = lineChartAppearance;
    ((Control) this.UltraChart1).Location = new Point(0, 0);
    ((Control) this.UltraChart1).Name = "UltraChart1";
    ((Control) this.UltraChart1).Size = new Size(689, 192 /*0xC0*/);
    this.UltraChart1.TabIndex = 10;
    this.UltraChart1.TitleTop.Extent = 20;
    this.UltraChart1.TitleTop.Font = new Font("Tahoma", 7.8f, FontStyle.Bold);
    this.UltraChart1.TitleTop.FontColor = Color.DimGray;
    this.UltraChart1.TitleTop.HorizontalAlign = StringAlignment.Center;
    this.UltraChart1.TitleTop.Margins.Bottom = 0;
    this.UltraChart1.TitleTop.Margins.Left = 0;
    this.UltraChart1.TitleTop.Margins.Right = 0;
    this.UltraChart1.TitleTop.Margins.Top = 0;
    this.UltraChart1.TitleTop.Text = "premium bank cash flow analysis";
    this.UltraChart1.TitleTop.VerticalAlign = StringAlignment.Near;
    this.DsBankingHomeChartData1.DataSetName = "dsBankingHomeChartData";
    this.DsBankingHomeChartData1.Locale = new CultureInfo("en-US");
    this.daGetBankingHome_BankAccounts.SelectCommand = this.SqlSelectCommand1;
    this.daGetBankingHome_BankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankingHome_BankAccounts", new DataColumnMapping[6]
      {
        new DataColumnMapping("glAcctId", "glAcctId"),
        new DataColumnMapping("location", "location"),
        new DataColumnMapping("BankAddress", "BankAddress"),
        new DataColumnMapping("AccountNumber", "AccountNumber"),
        new DataColumnMapping("AccountType", "AccountType"),
        new DataColumnMapping("Balance", "Balance")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetBankingHome_BankAccounts]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.ControlDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null)
    });
    this.ControlDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.ControlDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.DsCashFlow1.DataSetName = "dsCashFlow";
    this.DsCashFlow1.Locale = new CultureInfo("en-US");
    this.daGetBankReceivablesDue.SelectCommand = this.SqlSelectCommand2;
    this.daGetBankReceivablesDue.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankingReceivablesDue", new DataColumnMapping[4]
      {
        new DataColumnMapping("invoicenum", "invoicenum"),
        new DataColumnMapping("officeinvoicenum", "officeinvoicenum"),
        new DataColumnMapping("EntityName", "EntityName"),
        new DataColumnMapping("Amount", "Amount")
      })
    });
    this.SqlSelectCommand2.CommandText = "[spFin_GetBankingReceivablesDue]";
    this.SqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand2.Connection = this.ControlDataConnection;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@glcompanyid", SqlDbType.Int, 4)
    });
    this.daGetBankingPayablesDue.SelectCommand = this.SqlSelectCommand3;
    this.daGetBankingPayablesDue.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankingPayablesDue", new DataColumnMapping[4]
      {
        new DataColumnMapping("invoicenum", "invoicenum"),
        new DataColumnMapping("officeinvoicenum", "officeinvoicenum"),
        new DataColumnMapping("EntityName", "EntityName"),
        new DataColumnMapping("Amount", "Amount")
      })
    });
    this.SqlSelectCommand3.CommandText = "[spFin_GetBankingPayablesDue]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.ControlDataConnection;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@glcompanyid", SqlDbType.Int, 4)
    });
    this.daGetCashFlow.SelectCommand = this.SqlSelectCommand4;
    this.daGetCashFlow.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "spFin_BankingHomeCashFlow", new DataColumnMapping[1]
      {
        new DataColumnMapping("Column1", "Column1")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("postDate", "postDate"),
        new DataColumnMapping("amount", "amount")
      })
    });
    this.SqlSelectCommand4.CommandText = "[spFin_BankingHomeCashFlow]";
    this.SqlSelectCommand4.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand4.Connection = this.ControlDataConnection;
    this.SqlSelectCommand4.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@glcompanyid", SqlDbType.Int, 4)
    });
    appearance15.BackColor = Color.White;
    appearance15.BackColor2 = Color.White;
    appearance15.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.Appearance = (AppearanceBase) appearance15;
    this.UltraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.UltraExplorerBar1.ColumnCount = 2;
    this.UltraExplorerBar1.ColumnSpacing = 10;
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl1);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl2);
    ((Control) this.UltraExplorerBar1).Controls.Add((Control) this.UltraExplorerBarContainerControl3);
    ((Control) this.UltraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.UltraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 282;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Banking Alerts";
    explorerBarGroup2.Container = this.UltraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 282;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Banking Tools";
    explorerBarGroup3.ColumnsSpanned = 2;
    explorerBarGroup3.Container = this.UltraExplorerBarContainerControl3;
    explorerBarGroup3.Settings.ContainerHeight = 237;
    explorerBarGroup3.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    explorerBarGroup3.Text = "Cash Flow Chart";
    this.UltraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    appearance16.BackColor = Color.FromArgb(239, 247, 253);
    appearance16.BackColor2 = Color.FromArgb(239, 247, 253);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    appearance17.AlphaLevel = (short) 38;
    appearance17.BackColor = Color.FromArgb(166, 202, 238);
    appearance17.BackColor2 = Color.FromArgb(166, 202, 238);
    appearance17.BackColorAlpha = (Alpha) 2;
    appearance17.BorderColor = Color.White;
    appearance17.FontData.Name = "Tahoma";
    appearance17.FontData.SizeInPoints = 8f;
    appearance17.ForeColor = Color.DarkBlue;
    appearance17.ForegroundAlpha = (Alpha) 2;
    appearance17.ImageBackground = (Image) componentResourceManager.GetObject("Appearance17.ImageBackground");
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance17;
    appearance18.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.UltraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance18;
    this.UltraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Bottom = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Left = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Right = 4;
    this.UltraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Top = 4;
    this.UltraExplorerBar1.GroupSpacing = 10;
    ((Control) this.UltraExplorerBar1).Location = new Point(0, 0);
    this.UltraExplorerBar1.Margins.Bottom = 8;
    this.UltraExplorerBar1.Margins.Left = 8;
    this.UltraExplorerBar1.Margins.Right = 8;
    this.UltraExplorerBar1.Margins.Top = 8;
    ((Control) this.UltraExplorerBar1).Name = "UltraExplorerBar1";
    this.UltraExplorerBar1.NavigationAllowGroupReorder = false;
    this.UltraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.UltraExplorerBar1).Size = new Size(720, 672);
    ((Control) this.UltraExplorerBar1).TabIndex = 5;
    this.UltraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    ((UltraControlBase) this.UltraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.UltraExplorerBar1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (BankManagementHome);
    this.Size = new Size(720, 672);
    ((Control) this.UltraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.UltraExplorerBarContainerControl1).PerformLayout();
    ((ISupportInitialize) this.UltraGrid2).EndInit();
    this.DsBankingReceivablesDue2.EndInit();
    ((ISupportInitialize) this.gridReceivablesDue).EndInit();
    this.DsBankingReceivablesDue1.EndInit();
    ((Control) this.UltraExplorerBarContainerControl2).ResumeLayout(false);
    ((Control) this.UltraExplorerBarContainerControl2).PerformLayout();
    ((Control) this.UltraExplorerBarContainerControl3).ResumeLayout(false);
    this.panelNoData.ResumeLayout(false);
    this.panelLoadingCurtain.ResumeLayout(false);
    this.panelLoadingCurtain.PerformLayout();
    ((ISupportInitialize) this.PictureBox4).EndInit();
    ((ISupportInitialize) this.UltraChart1).EndInit();
    this.DsBankingHomeChartData1.EndInit();
    this.DsCashFlow1.EndInit();
    ((ISupportInitialize) this.UltraExplorerBar1).EndInit();
    ((Control) this.UltraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void BankManagementHome_Load(object sender, EventArgs e) => this.Dock = DockStyle.Fill;

  private void llCheckPrinters_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    new frmPrinterSettings().Show();
  }

  public void LoadDue(int GLCompanyID)
  {
    this.CurrentGLCompanyId = GLCompanyID;
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.dsReceivables = new DataSet();
    this.ReceivableLoadingThread = new Thread(new ThreadStart(this.LoadReceivablesData));
    this.labelLoadingReceivables.Visible = true;
    this.ReceivableLoadingThread.Start();
  }

  private void LoadChartData()
  {
    lock ((object) this)
    {
      try
      {
        if (!this.IsDisposed)
        {
          if (!this.Disposing)
          {
            this.daGetCashFlow.SelectCommand.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
            this.daGetCashFlow.SelectCommand.Parameters["@glcompanyid"].Value = (object) this.CurrentGLCompanyId;
            this.daGetCashFlow.SelectCommand.CommandTimeout = 0;
            if (this.ds == null)
              this.ds = new DataSet();
            this.daGetCashFlow.Fill(this.ds);
          }
        }
      }
      finally
      {
        if (this.daGetCashFlow.SelectCommand.Connection.State != ConnectionState.Closed)
          this.daGetCashFlow.SelectCommand.Connection.Close();
        this.daGetCashFlow.SelectCommand.Connection.Dispose();
      }
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new BankManagementHome.BindChartHandler(this.BindChart));
    }
  }

  private void BindChart()
  {
    if (this.ds.Tables.Count != 0 && this.ds.Tables[0].Rows.Count != 0)
    {
      this.panelLoadingCurtain.Visible = false;
      this.UltraChart1.DataSource = (object) this.ds;
      this.UltraChart1.Axis.X.Labels.ItemFormat = (AxisItemLabelFormat) 0;
    }
    else
    {
      this.ds.Dispose();
      this.ds = (DataSet) null;
      this.panelLoadingCurtain.Visible = false;
      this.panelNoData.Visible = true;
    }
  }

  private void LoadReceivablesData()
  {
    lock ((object) this)
    {
      try
      {
        if (!this.IsDisposed)
        {
          if (!this.Disposing)
          {
            this.daGetBankReceivablesDue.SelectCommand = new SqlCommand("spFin_GetBankingReceivablesDue", new SqlConnection(CurrentUser.Instance.ConnectionString));
            this.daGetBankReceivablesDue.SelectCommand.CommandTimeout = 0;
            this.daGetBankReceivablesDue.SelectCommand.CommandType = CommandType.StoredProcedure;
            this.daGetBankReceivablesDue.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) this.CurrentGLCompanyId);
            this.daGetBankReceivablesDue.Fill(this.dsReceivables);
          }
        }
      }
      finally
      {
        if (!this.IsDisposed && !this.Disposing)
        {
          if (this.daGetBankReceivablesDue.SelectCommand.Connection.State != ConnectionState.Closed)
            this.daGetBankReceivablesDue.SelectCommand.Connection.Close();
          this.daGetBankReceivablesDue.SelectCommand.Connection.Dispose();
        }
      }
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new BankManagementHome.LoadReceivablesCompletedHandler(this.LoadReceivablesCompleted));
    }
  }

  private void LoadReceivablesCompleted()
  {
    if (this.dsReceivables.Tables.Count != 0)
    {
      ((UltraGridBase) this.gridReceivablesDue).DataSource = (object) this.dsReceivables.Tables[0];
      this.labelLoadingReceivables.Visible = false;
    }
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Bands[0].Columns["amount"].Format = "c";
    ((HeaderBase) ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Bands[0].Columns["amount"].Header).Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridReceivablesDue).DisplayLayout.Bands[0].Columns["amount"].CellAppearance.TextHAlign = (HAlign) 3;
    this.dsPayables = new DataSet();
    this.PayableLoadingThread = new Thread(new ThreadStart(this.LoadPayablesData));
    this.labelLoadingPayables.Visible = true;
    this.PayableLoadingThread.Start();
  }

  private void LoadPayablesData()
  {
    lock ((object) this)
    {
      try
      {
        if (!this.IsDisposed)
        {
          if (!this.Disposing)
          {
            this.daGetBankingPayablesDue.SelectCommand = new SqlCommand("spFin_GetBankingPayablesDue", new SqlConnection(CurrentUser.Instance.ConnectionString));
            this.daGetBankingPayablesDue.SelectCommand.CommandTimeout = 0;
            this.daGetBankingPayablesDue.SelectCommand.CommandType = CommandType.StoredProcedure;
            this.daGetBankingPayablesDue.SelectCommand.Parameters.AddWithValue("@glcompanyid", (object) this.CurrentGLCompanyId);
            this.daGetBankingPayablesDue.Fill(this.dsPayables);
          }
        }
      }
      finally
      {
        if (this.daGetBankingPayablesDue.SelectCommand.Connection.State != ConnectionState.Closed)
          this.daGetBankingPayablesDue.SelectCommand.Connection.Close();
        this.daGetBankingPayablesDue.SelectCommand.Connection.Dispose();
      }
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new BankManagementHome.LoadPayablesCompletedHandler(this.LoadPayablesCompleted));
    }
  }

  private void LoadPayablesCompleted()
  {
    if (this.dsPayables.Tables.Count != 0)
    {
      ((UltraGridBase) this.UltraGrid2).DataSource = (object) this.dsPayables.Tables[0];
      this.labelLoadingPayables.Visible = false;
    }
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Bands[0].Columns["amount"].Format = "c";
    ((HeaderBase) ((UltraGridBase) this.UltraGrid2).DisplayLayout.Bands[0].Columns["amount"].Header).Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Bands[0].Columns["amount"].CellAppearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.UltraGrid2).DisplayLayout.Bands[0].Columns["invoiceNum"].Hidden = true;
    ((HeaderBase) ((UltraGridBase) this.UltraGrid2).DisplayLayout.Bands[0].Columns["officeInvoiceNum"].Header).Caption = "Invoice # ";
    this.ds = new DataSet();
    this.ChartDataThread = new Thread(new ThreadStart(this.LoadChartData));
    this.panelLoadingCurtain.Visible = true;
    this.ChartDataThread.Start();
  }

  protected override void OnPaint(PaintEventArgs e)
  {
    if (this.disableCustomDrawing)
    {
      base.OnPaint(e);
    }
    else
    {
      using (LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, Color.White, Color.WhiteSmoke, LinearGradientMode.Vertical))
        e.Graphics.FillRectangle((Brush) linearGradientBrush, linearGradientBrush.Rectangle);
    }
  }

  private void UltraExplorerBar1_GroupCollapsing(object sender, CancelableGroupEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private delegate void BindChartHandler();

  private delegate void LoadReceivablesCompletedHandler();

  private delegate void LoadPayablesCompletedHandler();
}
