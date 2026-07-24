// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmPrintChecks
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.CheckPrinting;
using MGASystems.IMS.Accounting.Reports;
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
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{879830FE-04FA-4a48-9FE6-0626CF095A85}", "Check Printing Rights", "Ensures that only authorized users have the ability to print checks.", "Accounting")]
public class frmPrintChecks : Form
{
  private IContainer components;
  private const string USERSELECTPRINTER = "CHECKPRINTER_ISUSERSELECT";
  private ArrayList Transactions;
  private int _glcompanyid;
  protected string checkPrinterName;
  protected string checkPaperSource;
  protected string checkDetailPrinterName;
  protected string checkDetailPaperTray;
  private DataSet dsData;
  protected bool blnCustomSorted;
  protected string sprocName;
  private DataTable CheckDataTable;
  private PrinterSettings CheckPrinterSettings;
  private PrinterSettings CheckDetailPrinterSettings;
  private Thread threadCheckDetail;
  private int BankGLAcctID;

  public frmPrintChecks()
  {
    this.Load += new EventHandler(this.frmPrintChecks_Load);
    this.Closing += new CancelEventHandler(this.frmPrintChecks_Closing);
    this.Transactions = new ArrayList();
    this.checkPrinterName = "";
    this.checkPaperSource = "";
    this.checkDetailPrinterName = "";
    this.checkDetailPaperTray = "";
    this.dsData = new DataSet();
    this.blnCustomSorted = false;
    this.sprocName = "dbo.spFin_GetPrintableChecks";
    this.CheckDataTable = new DataTable();
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("daGetPrintableChecks")]
  protected virtual SqlDataAdapter daGetPrintableChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  protected virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsGetPrintableChecks1")]
  protected virtual dsGetPrintableChecks DsGetPrintableChecks1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public virtual UltraGrid gridPrintableChecks
  {
    get => this._gridPrintableChecks;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.gridPrintableChecks_CellChange);
      UltraGrid gridPrintableChecks1 = this._gridPrintableChecks;
      if (gridPrintableChecks1 != null)
        gridPrintableChecks1.CellChange -= cellEventHandler;
      this._gridPrintableChecks = value;
      UltraGrid gridPrintableChecks2 = this._gridPrintableChecks;
      if (gridPrintableChecks2 == null)
        return;
      gridPrintableChecks2.CellChange += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("gridCheckVerify")]
  protected virtual UltraGrid gridCheckVerify { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsCheckVerify")]
  protected virtual dsGetPrintableChecks dsCheckVerify { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraButton btnPrint
  {
    get => this._btnPrint;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPrint_Click);
      UltraButton btnPrint1 = this._btnPrint;
      if (btnPrint1 != null)
        ((Control) btnPrint1).Click -= eventHandler;
      this._btnPrint = value;
      UltraButton btnPrint2 = this._btnPrint;
      if (btnPrint2 == null)
        return;
      ((Control) btnPrint2).Click += eventHandler;
    }
  }

  internal virtual UltraButton btnVerify
  {
    get => this._btnVerify;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnVerify_Click);
      UltraButton btnVerify1 = this._btnVerify;
      if (btnVerify1 != null)
        ((Control) btnVerify1).Click -= eventHandler;
      this._btnVerify = value;
      UltraButton btnVerify2 = this._btnVerify;
      if (btnVerify2 == null)
        return;
      ((Control) btnVerify2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox2")]
  internal virtual MGAGroupBox MgaGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel linkPrintSelectAll
  {
    get => this._linkPrintSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkPrintSelectAll_LinkClicked);
      LinkLabel linkPrintSelectAll1 = this._linkPrintSelectAll;
      if (linkPrintSelectAll1 != null)
        linkPrintSelectAll1.LinkClicked -= clickedEventHandler;
      this._linkPrintSelectAll = value;
      LinkLabel linkPrintSelectAll2 = this._linkPrintSelectAll;
      if (linkPrintSelectAll2 == null)
        return;
      linkPrintSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel linkPrintUnSelectAll
  {
    get => this._linkPrintUnSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkPrintUnSelectAll_LinkClicked);
      LinkLabel printUnSelectAll1 = this._linkPrintUnSelectAll;
      if (printUnSelectAll1 != null)
        printUnSelectAll1.LinkClicked -= clickedEventHandler;
      this._linkPrintUnSelectAll = value;
      LinkLabel printUnSelectAll2 = this._linkPrintUnSelectAll;
      if (printUnSelectAll2 == null)
        return;
      printUnSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel linkVerifySelectAll
  {
    get => this._linkVerifySelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkPrintSelectAll_LinkClicked);
      LinkLabel linkVerifySelectAll1 = this._linkVerifySelectAll;
      if (linkVerifySelectAll1 != null)
        linkVerifySelectAll1.LinkClicked -= clickedEventHandler;
      this._linkVerifySelectAll = value;
      LinkLabel linkVerifySelectAll2 = this._linkVerifySelectAll;
      if (linkVerifySelectAll2 == null)
        return;
      linkVerifySelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
        toolbarsManager1_1.ToolClick -= clickEventHandler;
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.ToolClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("_frmPrintChecks_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _frmPrintChecks_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmPrintChecks_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _frmPrintChecks_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmPrintChecks_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _frmPrintChecks_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmPrintChecks_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _frmPrintChecks_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel linkVerifyUnSelectAll
  {
    get => this._linkVerifyUnSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkPrintUnSelectAll_LinkClicked);
      LinkLabel verifyUnSelectAll1 = this._linkVerifyUnSelectAll;
      if (verifyUnSelectAll1 != null)
        verifyUnSelectAll1.LinkClicked -= clickedEventHandler;
      this._linkVerifyUnSelectAll = value;
      LinkLabel verifyUnSelectAll2 = this._linkVerifyUnSelectAll;
      if (verifyUnSelectAll2 == null)
        return;
      verifyUnSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmPrintChecks));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("spFin_GetPrintableChecks", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("checknum", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("payeename");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("checkamt");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("transactnum");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("IsOperating");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("User");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("IsClaims");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Select..", 0);
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("spFin_GetPrintableChecks", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("checknum");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("payeename");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("checkamt");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("transactnum");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("IsOperating");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("User");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("IsClaims");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Select..", 0);
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("Change Check Printer");
    ButtonTool buttonTool2 = new ButtonTool("REPRINT");
    ButtonTool buttonTool3 = new ButtonTool("Change Check Printer");
    Appearance appearance24 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("REPRINT");
    Appearance appearance25 = new Appearance();
    this.btnPrint = new UltraButton();
    this.btnVerify = new UltraButton();
    this.daGetPrintableChecks = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.linkPrintUnSelectAll = new LinkLabel();
    this.linkPrintSelectAll = new LinkLabel();
    this.gridPrintableChecks = new UltraGrid();
    this.DsGetPrintableChecks1 = new dsGetPrintableChecks();
    this.MgaGroupBox2 = new MGAGroupBox();
    this.linkVerifyUnSelectAll = new LinkLabel();
    this.linkVerifySelectAll = new LinkLabel();
    this.gridCheckVerify = new UltraGrid();
    this.dsCheckVerify = new dsGetPrintableChecks();
    this._frmPrintChecks_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._frmPrintChecks_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmPrintChecks_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmPrintChecks_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.gridPrintableChecks).BeginInit();
    this.DsGetPrintableChecks1.BeginInit();
    ((ISupportInitialize) this.MgaGroupBox2).BeginInit();
    ((Control) this.MgaGroupBox2).SuspendLayout();
    ((ISupportInitialize) this.gridCheckVerify).BeginInit();
    this.dsCheckVerify.BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnPrint).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    ((ControlBase) this.btnPrint).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnPrint).Location = new Point(703, 303);
    ((Control) this.btnPrint).Name = "btnPrint";
    ((Control) this.btnPrint).Size = new Size(120, 32 /*0x20*/);
    ((Control) this.btnPrint).TabIndex = 3;
    ((ControlBase) this.btnPrint).Text = "Print Checks";
    ((Control) this.btnVerify).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance2.Image"));
    ((ControlBase) this.btnVerify).Appearance = (AppearanceBase) appearance2;
    ((Control) this.btnVerify).Location = new Point(703, 256 /*0x0100*/);
    ((Control) this.btnVerify).Name = "btnVerify";
    ((Control) this.btnVerify).Size = new Size(120, 32 /*0x20*/);
    ((Control) this.btnVerify).TabIndex = 4;
    ((ControlBase) this.btnVerify).Text = "Verify Checks";
    this.daGetPrintableChecks.SelectCommand = this.SqlSelectCommand1;
    this.daGetPrintableChecks.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetPrintableChecks", new DataColumnMapping[4]
      {
        new DataColumnMapping("checknum", "checknum"),
        new DataColumnMapping("payeename", "payeename"),
        new DataColumnMapping("checkamt", "checkamt"),
        new DataColumnMapping("transactnum", "transactnum")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetPrintableChecks]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@glcompanyid", SqlDbType.Int, 4),
      new SqlParameter("@glaccountid", SqlDbType.Int, 4)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(239, 247, 253);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance3;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.linkPrintUnSelectAll);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.linkPrintSelectAll);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnPrint);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.gridPrintableChecks);
    appearance4.AlphaLevel = (short) 230;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.White;
    appearance4.ForegroundAlpha = (Alpha) 2;
    appearance4.ImageAlpha = (Alpha) 2;
    appearance4.ImageBackground = (Image) componentResourceManager.GetObject("Appearance13.ImageBackground");
    appearance4.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance4;
    ((Control) this.MgaGroupBox1).Location = new Point(6, 29);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(831, 343);
    ((Control) this.MgaGroupBox1).TabIndex = 10;
    this.MgaGroupBox1.Text = "Printable Checks";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.linkPrintUnSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkPrintUnSelectAll.AutoSize = true;
    this.linkPrintUnSelectAll.BackColor = Color.FromArgb(239, 247, 253);
    this.linkPrintUnSelectAll.Location = new Point(80 /*0x50*/, 319);
    this.linkPrintUnSelectAll.Name = "linkPrintUnSelectAll";
    this.linkPrintUnSelectAll.Size = new Size(67, 13);
    this.linkPrintUnSelectAll.TabIndex = 5;
    this.linkPrintUnSelectAll.TabStop = true;
    this.linkPrintUnSelectAll.Text = "Un-Select All";
    this.linkPrintSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkPrintSelectAll.AutoSize = true;
    this.linkPrintSelectAll.BackColor = Color.FromArgb(239, 247, 253);
    this.linkPrintSelectAll.Location = new Point(16 /*0x10*/, 319);
    this.linkPrintSelectAll.Name = "linkPrintSelectAll";
    this.linkPrintSelectAll.Size = new Size(50, 13);
    this.linkPrintSelectAll.TabIndex = 4;
    this.linkPrintSelectAll.TabStop = true;
    this.linkPrintSelectAll.Text = "Select All";
    ((Control) this.gridPrintableChecks).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.gridPrintableChecks).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridPrintableChecks).DataSource = (object) this.DsGetPrintableChecks1;
    appearance5.BackColor = Color.Transparent;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Check #";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Width = 161;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    appearance6.FontData.BoldAsString = "False";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Payee";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 368;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn3.Format = "c";
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Check Amount";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 136;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 4;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 72;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 69;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 6;
    ultraGridColumn6.Width = 89;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 7;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 66;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.DataType = typeof (bool);
    ((AppearanceBase) appearance9).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Width = 59;
    ultraGridBand1.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    appearance10.BackColor = Color.White;
    appearance10.FontData.BoldAsString = "True";
    appearance10.FontData.Name = "Tahoma";
    ((HeaderBase) ultraGridBand1.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridBand1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance12.ForeColor = Color.Black;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance13.BackColor = Color.FromArgb(246, 250, 253);
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance13;
    ((Control) this.gridPrintableChecks).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridPrintableChecks).Location = new Point(8, 26);
    ((Control) this.gridPrintableChecks).Name = "gridPrintableChecks";
    ((Control) this.gridPrintableChecks).Size = new Size(815, 269);
    ((Control) this.gridPrintableChecks).TabIndex = 0;
    this.gridPrintableChecks.UpdateMode = (UpdateMode) 4;
    ((UltraControlBase) this.gridPrintableChecks).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPrintableChecks).UseOsThemes = (DefaultableBoolean) 2;
    this.DsGetPrintableChecks1.DataSetName = "dsGetPrintableChecks";
    this.DsGetPrintableChecks1.Locale = new CultureInfo("en-US");
    this.DsGetPrintableChecks1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.MgaGroupBox2).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance14.BackColor = Color.FromArgb(239, 247, 253);
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance14;
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.linkVerifyUnSelectAll);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.linkVerifySelectAll);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.gridCheckVerify);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.btnVerify);
    appearance15.AlphaLevel = (short) 230;
    appearance15.FontData.SizeInPoints = 10f;
    appearance15.ForeColor = Color.White;
    appearance15.ForegroundAlpha = (Alpha) 2;
    appearance15.ImageAlpha = (Alpha) 2;
    appearance15.ImageBackground = (Image) componentResourceManager.GetObject("Appearance23.ImageBackground");
    appearance15.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox2.HeaderAppearance = (AppearanceBase) appearance15;
    ((Control) this.MgaGroupBox2).Location = new Point(6, 378);
    ((Control) this.MgaGroupBox2).Name = "MgaGroupBox2";
    ((Control) this.MgaGroupBox2).Size = new Size(831, 296);
    ((Control) this.MgaGroupBox2).TabIndex = 11;
    this.MgaGroupBox2.Text = "Verify Checks";
    this.MgaGroupBox2.ViewStyle = (GroupBoxViewStyle) 2;
    this.linkVerifyUnSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkVerifyUnSelectAll.AutoSize = true;
    this.linkVerifyUnSelectAll.BackColor = Color.FromArgb(239, 247, 253);
    this.linkVerifyUnSelectAll.Location = new Point(88, 272);
    this.linkVerifyUnSelectAll.Name = "linkVerifyUnSelectAll";
    this.linkVerifyUnSelectAll.Size = new Size(67, 13);
    this.linkVerifyUnSelectAll.TabIndex = 6;
    this.linkVerifyUnSelectAll.TabStop = true;
    this.linkVerifyUnSelectAll.Text = "Un-Select All";
    this.linkVerifySelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkVerifySelectAll.AutoSize = true;
    this.linkVerifySelectAll.BackColor = Color.FromArgb(239, 247, 253);
    this.linkVerifySelectAll.Location = new Point(16 /*0x10*/, 272);
    this.linkVerifySelectAll.Name = "linkVerifySelectAll";
    this.linkVerifySelectAll.Size = new Size(50, 13);
    this.linkVerifySelectAll.TabIndex = 5;
    this.linkVerifySelectAll.TabStop = true;
    this.linkVerifySelectAll.Text = "Select All";
    ((Control) this.gridCheckVerify).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridCheckVerify).DataSource = (object) this.dsCheckVerify;
    appearance16.BackColor = Color.Transparent;
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Appearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Check #";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 136;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Payee";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridColumn10.Width = 321;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Right";
    ultraGridColumn11.CellAppearance = (AppearanceBase) appearance17;
    ultraGridColumn11.Format = "c";
    ((AppearanceBase) appearance18).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance18;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Check Amount";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 3;
    ultraGridColumn11.Width = 211;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 4;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 72;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 5;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 69;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 6;
    ultraGridColumn14.Width = 90;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 7;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 55;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.DataType = typeof (bool);
    ((AppearanceBase) appearance19).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance19;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Reprint..";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 0;
    ultraGridColumn16.Width = 55;
    ultraGridBand2.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ultraGridBand2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    appearance20.BackColor = Color.White;
    appearance20.FontData.BoldAsString = "True";
    appearance20.FontData.SizeInPoints = 12f;
    appearance20.ForeColor = Color.Gray;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance21.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    appearance22.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance22.ForeColor = Color.Black;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    appearance23.BackColor = Color.FromArgb(246, 250, 253);
    appearance23.ForeColor = Color.Black;
    ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance23;
    ((Control) this.gridCheckVerify).Location = new Point(8, 34);
    ((Control) this.gridCheckVerify).Name = "gridCheckVerify";
    ((Control) this.gridCheckVerify).Size = new Size(815, 214);
    ((Control) this.gridCheckVerify).TabIndex = 1;
    ((UltraControlBase) this.gridCheckVerify).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCheckVerify).UseOsThemes = (DefaultableBoolean) 2;
    this.dsCheckVerify.DataSetName = "dsGetPrintableChecks";
    this.dsCheckVerify.Locale = new CultureInfo("en-US");
    this.dsCheckVerify.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmPrintChecks_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).Location = new Point(0, 26);
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).Name = "_frmPrintChecks_Toolbars_Dock_Area_Left";
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).Size = new Size(0, 656);
    this._frmPrintChecks_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.MdiMergeable = false;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    appearance24.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance24.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance24;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Change Check Printer";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    appearance25.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance25.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance25;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Reprint Check(s)";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmPrintChecks_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Right).Location = new Point(841, 26);
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Right).Name = "_frmPrintChecks_Toolbars_Dock_Area_Right";
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Right).Size = new Size(0, 656);
    this._frmPrintChecks_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmPrintChecks_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Top).Name = "_frmPrintChecks_Toolbars_Dock_Area_Top";
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Top).Size = new Size(841, 26);
    this._frmPrintChecks_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmPrintChecks_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Bottom).Location = new Point(0, 682);
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Bottom).Name = "_frmPrintChecks_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Bottom).Size = new Size(841, 0);
    this._frmPrintChecks_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ClientSize = new Size(841, 682);
    this.Controls.Add((Control) this.MgaGroupBox2);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmPrintChecks_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmPrintChecks_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmPrintChecks_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmPrintChecks);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "IMS Accounting - Print Checks";
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.gridPrintableChecks).EndInit();
    this.DsGetPrintableChecks1.EndInit();
    ((ISupportInitialize) this.MgaGroupBox2).EndInit();
    ((Control) this.MgaGroupBox2).ResumeLayout(false);
    ((Control) this.MgaGroupBox2).PerformLayout();
    ((ISupportInitialize) this.gridCheckVerify).EndInit();
    this.dsCheckVerify.EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  public frmPrintChecks(int GLAcctID)
  {
    this.Load += new EventHandler(this.frmPrintChecks_Load);
    this.Closing += new CancelEventHandler(this.frmPrintChecks_Closing);
    this.Transactions = new ArrayList();
    this.checkPrinterName = "";
    this.checkPaperSource = "";
    this.checkDetailPrinterName = "";
    this.checkDetailPaperTray = "";
    this.dsData = new DataSet();
    this.blnCustomSorted = false;
    this.sprocName = "dbo.spFin_GetPrintableChecks";
    this.CheckDataTable = new DataTable();
    this.InitializeComponent();
    this.BankGLAcctID = GLAcctID;
  }

  public frmPrintChecks(DataTable DataTbl)
  {
    this.Load += new EventHandler(this.frmPrintChecks_Load);
    this.Closing += new CancelEventHandler(this.frmPrintChecks_Closing);
    this.Transactions = new ArrayList();
    this.checkPrinterName = "";
    this.checkPaperSource = "";
    this.checkDetailPrinterName = "";
    this.checkDetailPaperTray = "";
    this.dsData = new DataSet();
    this.blnCustomSorted = false;
    this.sprocName = "dbo.spFin_GetPrintableChecks";
    this.CheckDataTable = new DataTable();
    this.InitializeComponent();
    this.CheckDataTable = DataTbl;
  }

  public frmPrintChecks(DataTable DataTbl, int BankGLAccount)
  {
    this.Load += new EventHandler(this.frmPrintChecks_Load);
    this.Closing += new CancelEventHandler(this.frmPrintChecks_Closing);
    this.Transactions = new ArrayList();
    this.checkPrinterName = "";
    this.checkPaperSource = "";
    this.checkDetailPrinterName = "";
    this.checkDetailPaperTray = "";
    this.dsData = new DataSet();
    this.blnCustomSorted = false;
    this.sprocName = "dbo.spFin_GetPrintableChecks";
    this.CheckDataTable = new DataTable();
    this.InitializeComponent();
    this.CheckDataTable = DataTbl;
    this.BankGLAcctID = BankGLAccount;
  }

  public frmPrintChecks(
    int GLAcctID,
    string printerName,
    string printerSettings,
    string detailName,
    string detailSettings)
  {
    this.Load += new EventHandler(this.frmPrintChecks_Load);
    this.Closing += new CancelEventHandler(this.frmPrintChecks_Closing);
    this.Transactions = new ArrayList();
    this.checkPrinterName = "";
    this.checkPaperSource = "";
    this.checkDetailPrinterName = "";
    this.checkDetailPaperTray = "";
    this.dsData = new DataSet();
    this.blnCustomSorted = false;
    this.sprocName = "dbo.spFin_GetPrintableChecks";
    this.CheckDataTable = new DataTable();
    this.InitializeComponent();
    this.Text = $"{this.Text}-{printerName}";
    this.BankGLAcctID = GLAcctID;
    this.checkPrinterName = printerName;
    this.checkPaperSource = printerSettings;
    this.checkDetailPrinterName = detailName;
    this.checkDetailPaperTray = detailSettings;
  }

  private void frmPrintChecks_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadChecks(this._glcompanyid, this.BankGLAcctID);
    this.AddCheckSummaryRow();
  }

  protected virtual void LoadChecks(int glCompanyId, int bankGLAccountId)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.DsGetPrintableChecks1, new string[1]
    {
      "spFin_GetPrintableChecks"
    }, this.sprocName, new object[4]
    {
      (object) "@glcompanyid",
      (object) glCompanyId,
      (object) "@glaccountid",
      (object) bankGLAccountId
    });
  }

  protected virtual void AddCheckSummaryRow()
  {
    if (((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Bands.Count == 0 || ((UltraGridBase) this.gridPrintableChecks).Rows.Count == 0)
      return;
    UltraGridBand band = ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Bands[0];
    band.Summaries.Clear();
    band.Summaries.Add("CheckSum", (SummaryType) 1, band.Columns["checkamt"], (SummaryPosition) 3);
    band.SummaryFooterCaption = "Checks Total";
    band.Summaries[0].DisplayFormat = "{0:c}";
    UltraGridOverride ultraGridOverride = ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override;
    ultraGridOverride.SummaryFooterAppearance.BackColor = SystemColors.ControlLight;
    ultraGridOverride.SummaryValueAppearance.TextHAlign = (HAlign) 3;
  }

  protected virtual void PrintChecks(ref UltraGrid grid)
  {
    if (SystemSettings.GetBoolSetting("CHECKPRINTER_ISUSERSELECT"))
      this.UserPrinterSelect();
    foreach (UltraGridRow row in ((UltraGridBase) grid).Rows)
    {
      if (this.blnCustomSorted && !row.Hidden || Conversions.ToBoolean(row.Cells["select.."].Value) && !row.Hidden)
      {
        bool boolean = Conversions.ToBoolean(row.Cells["isOperating"].Value.ToString());
        SectionReport sectionReport = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (MGASystems.IMS.Accounting.Reports.Check_Standard), new object[2]
        {
          (object) int.Parse(row.Cells["transactnum"].Value.ToString()),
          (object) boolean
        });
        try
        {
          sectionReport.Run();
          if (this.checkPrinterName.Length != 0)
            sectionReport.Document.Printer.PrinterName = this.checkPrinterName;
          if (this.checkPaperSource.Length != 0)
          {
            try
            {
              foreach (PaperSource paperSource in ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.PaperSources)
              {
                if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(paperSource.SourceName, this.checkPaperSource, false) == 0)
                {
                  ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = paperSource;
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
          try
          {
            CurrentUser.Instance.LogAction($"{CurrentUser.Instance.UserName} Printed check for transaction # {int.Parse(row.Cells["transactnum"].Value.ToString())}", "Banking Logs");
            PrintExtension.Print(sectionReport.Document, false, false, false);
          }
          catch (Win32Exception ex)
          {
            ProjectData.SetProjectError((Exception) ex);
            if (ex.Message.Contains("The RPC server is unavailable"))
            {
              int num = (int) MessageBox.Show("The check could not be printed, because the printer could not be located.\n\nThe print server may be offline or network problems are preventing a connection to the print server.\n\nPlease contact your network administrator for further information.", "Unable to Find Printer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              ProjectData.ClearProjectError();
              break;
            }
            throw;
          }
        }
        finally
        {
          sectionReport.Dispose();
        }
        if (grid != this.gridCheckVerify)
        {
          this.MoveCheckToVerify(row);
          row.Hidden = true;
        }
        else
          row.Cells["select.."].Value = (object) false;
        this.PrintCheckDetail(int.Parse(row.Cells["transactnum"].Value.ToString()), boolean, row.Cells["payeename"].Value.ToString(), row.Cells["checknum"].Value.ToString());
      }
    }
  }

  private void btnPrint_Click(object sender, EventArgs e)
  {
    if (!this.HasChecksToPrint())
    {
      int num1 = (int) MessageBox.Show("Please select check(s) from the grid to print", "Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      UltraGrid grid = this.gridPrintableChecks;
      string text = "The selected checks will be printed by check number, would you like to rearrange the order in which the checks are printed?";
      UltraGrid gridPrintableChecks = this.gridPrintableChecks;
      DataSet selectedRows = this.GetSelectedRows(ref gridPrintableChecks);
      this.gridPrintableChecks = gridPrintableChecks;
      DataSet drRows = selectedRows;
      frmCheckOrder frmCheckOrder = (frmCheckOrder) null;
      if (drRows.Tables.Count > 0 && drRows.Tables[0].Rows.Count > 1 && MessageBox.Show(text, "Check Print Order", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
      {
        frmCheckOrder = new frmCheckOrder(drRows);
        int num2 = (int) frmCheckOrder.ShowDialog((IWin32Window) this.gridPrintableChecks);
        if (frmCheckOrder.DialogResult == DialogResult.Cancel)
          return;
        this.HidePrintingRows(grid);
        grid = frmCheckOrder.OrderdCheckGrid;
        this.blnCustomSorted = true;
      }
      try
      {
        this.PrintChecks(ref grid);
      }
      catch (InvalidPrinterException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        int num3 = (int) MessageBox.Show(ex.Message, "Invalid Printer Settings!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
      finally
      {
        frmCheckOrder?.Dispose();
        this.blnCustomSorted = false;
      }
    }
  }

  private void HidePrintingRows(UltraGrid grid)
  {
    int num = ((UltraGridBase) grid).Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (Conversions.ToBoolean(((UltraGridBase) grid).Rows[index].Cells["select.."].Value) && !((UltraGridBase) grid).Rows[index].Hidden)
        ((UltraGridBase) grid).Rows[index].Hidden = true;
    }
  }

  private bool HasChecksToPrint()
  {
    int num = ((UltraGridBase) this.gridPrintableChecks).Rows.Count - 1;
    bool print;
    for (int index = 0; index <= num; ++index)
    {
      if (Conversions.ToBoolean(((UltraGridBase) this.gridPrintableChecks).Rows[index].Cells["select.."].Value) && !((UltraGridBase) this.gridPrintableChecks).Rows[index].Hidden)
      {
        print = true;
        goto label_6;
      }
    }
    print = false;
label_6:
    return print;
  }

  private DataSet GetSelectedRows(ref UltraGrid grid)
  {
    DataSet selectedRows = this.DsGetPrintableChecks1.Copy();
    int num = ((UltraGridBase) this.gridPrintableChecks).Rows.Count - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (!Conversions.ToBoolean(((UltraGridBase) grid).Rows[index].Cells["select.."].Value) || ((UltraGridBase) grid).Rows[index].Hidden)
        selectedRows.Tables[0].Rows[((UltraGridBase) this.gridPrintableChecks).Rows[index].ListIndex].Delete();
    }
    selectedRows.AcceptChanges();
    return selectedRows;
  }

  protected virtual void MoveCheckToVerify(UltraGridRow rw)
  {
    UltraGridRow ultraGridRow = ((UltraGridBase) this.gridCheckVerify).DisplayLayout.Bands[0].AddNew();
    for (int index = 0; index < ultraGridRow.Cells.Count; ++index)
    {
      ultraGridRow.Cells[index].Value = RuntimeHelpers.GetObjectValue(rw.Cells[index].Value);
      ultraGridRow.Cells["select.."].Value = (object) false;
    }
  }

  protected virtual void PrintCheckDetail(
    int transactionNumber,
    bool isOperating,
    string payeeName,
    string checkNumber)
  {
    int index = 0;
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spFin_GetCheckDetails", connection);
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataSet dataSet = new DataSet();
    SectionReport sectionReport = (SectionReport) null;
    CheckPrintingSettings printingSettings = (CheckPrintingSettings) ObjectFactory.Instance.CreateObject(typeof (CheckPrintingSettings));
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Parameters.AddWithValue("@transactnum", (object) transactionNumber);
    selectCommand.CommandTimeout = 300;
    try
    {
      selectCommand.CommandText = !isOperating ? "spFin_GetCheckDetails" : "spFin_GetCheckDetails_Operating";
      sqlDataAdapter.Fill(dataSet);
      if (dataSet.Tables.Count <= 0 || dataSet.Tables[0].Rows.Count <= printingSettings.CheckDetailMax())
        return;
      if (isOperating)
        sectionReport = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (CheckOverFlow_Operating), new object[3]
        {
          (object) dataSet.Tables[0],
          (object) payeeName,
          (object) checkNumber
        });
      else
        sectionReport = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (MGASystems.IMS.Accounting.Reports.CheckOverFlow), new object[3]
        {
          (object) dataSet.Tables[0],
          (object) payeeName,
          (object) checkNumber
        });
      sectionReport.Run();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.checkDetailPrinterName, "", false) != 0)
        sectionReport.Document.Printer.PrinterName = this.checkDetailPrinterName;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.checkDetailPaperTray, "", false) != 0)
      {
        for (; index < ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.PaperSources.Count; ++index)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((PrintDocument) sectionReport.Document.Printer).PrinterSettings.PaperSources[index].SourceName, this.checkDetailPaperTray, false) == 0)
          {
            ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.DefaultPageSettings.PaperSource = ((PrintDocument) sectionReport.Document.Printer).PrinterSettings.PaperSources[index];
            break;
          }
        }
      }
      PrintExtension.Print(sectionReport.Document, false, false, false);
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      throw ex;
    }
    finally
    {
      sectionReport?.Dispose();
      if (connection != null)
      {
        if (connection.State != ConnectionState.Closed)
          connection.Close();
        connection.Dispose();
      }
      selectCommand?.Dispose();
      sqlDataAdapter?.Dispose();
      dataSet?.Dispose();
    }
  }

  private void btnVerify_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridCheckVerify).Rows.Count == 0)
    {
      this.Close();
    }
    else
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridCheckVerify).Rows)
      {
        if (Conversions.ToBoolean(row.Cells["select.."].Value))
        {
          UltraGrid gridCheckVerify = this.gridCheckVerify;
          this.PrintChecks(ref gridCheckVerify);
          this.gridCheckVerify = gridCheckVerify;
          return;
        }
      }
      if (!this.Verify(this.gridCheckVerify))
        return;
      this.Close();
    }
  }

  private bool Verify(UltraGrid grid)
  {
    // ISSUE: unable to decompile the method.
  }

  private void frmPrintChecks_Closing(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.gridCheckVerify).Rows.Count == 0)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridCheckVerify).Rows)
    {
      if (((SubObjectBase) row).Tag == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((SubObjectBase) row).Tag.ToString().Trim(), "", false) == 0)
      {
        if (MessageBox.Show("The system has determined that there are checks that have been printed. You should NOT print checks and leave them un-verified. This will result in users having the ability to reprint duplicate checks.\r\n\r\nDo you wish to verify the printed checks before closing this form?", "Verify Printed Checks?", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) == DialogResult.Yes)
        {
          e.Cancel = true;
          break;
        }
        e.Cancel = false;
        break;
      }
    }
  }

  private void UserPrinterSelect()
  {
    PrintDialog printDialog1 = new PrintDialog();
    if (printDialog1.ShowDialog() != DialogResult.OK)
      return;
    this.CheckPrinterSettings = printDialog1.PrinterSettings;
    this.checkPrinterName = printDialog1.PrinterSettings.PrinterName;
    this.CheckDetailPrinterSettings = printDialog1.PrinterSettings;
    this.checkDetailPrinterName = printDialog1.PrinterSettings.PrinterName;
    if (printDialog1.PrinterSettings.PaperSources.Count > 0 && printDialog1.PrinterSettings.PaperSources[0] != null)
    {
      this.checkPaperSource = printDialog1.PrinterSettings.PaperSources[0].SourceName;
      this.checkDetailPaperTray = printDialog1.PrinterSettings.PaperSources[0].SourceName;
    }
    if (MessageBox.Show("Do you want to print the check detail runoff to another printer?", "Use Different Check Detail Printer?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    PrintDialog printDialog2 = new PrintDialog();
    if (printDialog2.ShowDialog() != DialogResult.OK)
      return;
    this.CheckDetailPrinterSettings = printDialog2.PrinterSettings;
    this.checkDetailPrinterName = printDialog2.PrinterSettings.PrinterName;
    if (printDialog2.PrinterSettings.PaperSources.Count <= 0 || printDialog2.PrinterSettings.PaperSources[0] == null)
      return;
    this.checkDetailPaperTray = printDialog2.PrinterSettings.PaperSources[0].SourceName;
  }

  private string CreateE13BString(
    string CheckNumber,
    string RoutingNumber,
    string AccountNumber,
    string Amount)
  {
    string str = "C";
    for (int index = 0; index + Strings.Len(CheckNumber) < 6; ++index)
      str += "0";
    return $"{$"{str}{CheckNumber}C  A"}{RoutingNumber}A  {AccountNumber}C    B{Amount.Substring(0, Strings.InStr(Amount, ".") - 1)}B{Amount.Substring(Strings.InStr(Amount, ".") + 1, 2)}";
  }

  private string CreateE13BCheckNumber(string CheckNumber)
  {
    string str = "C";
    for (int index = 0; index + Strings.Len(CheckNumber) < 6; ++index)
      str += "0";
    return $"{str}{CheckNumber}C";
  }

  private string CreateE13BRoutingNumber(string RoutingNumber) => $"A{RoutingNumber}A";

  private string CreateE13BAccountNumber(string AccountNumber) => AccountNumber + "C";

  private string CreateE13BAmount(string Amount)
  {
    return $"B{Amount.Substring(0, Strings.InStr(Amount, ".") - 1)}B{Amount.Substring(Strings.InStr(Amount, "."), 2)}";
  }

  private void UltraExplorerBar1_GroupCollapsing(object sender, CancelableGroupEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private void linkPrintSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (sender == this.linkPrintSelectAll)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridPrintableChecks).Rows)
        row.Cells["select.."].Value = (object) true;
    }
    else
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridCheckVerify).Rows)
        row.Cells["select.."].Value = (object) true;
    }
  }

  private void linkPrintUnSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (sender == this.linkPrintUnSelectAll)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridPrintableChecks).Rows)
        row.Cells["select.."].Value = (object) false;
    }
    else
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridCheckVerify).Rows)
        row.Cells["select.."].Value = (object) false;
    }
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Change Check Printer", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "REPRINT", false) != 0)
        return;
      if (!SecurityManager.Instance.AssertPermission("{d64aeaf5-0b2a-4321-9b41-efe6c412d779}"))
      {
        Utility.DenyAccess();
      }
      else
      {
        frmReprintChecks form = ObjectFactory.Instance.CreateForm(typeof (frmReprintChecks), new object[5]
        {
          (object) this.BankGLAcctID,
          (object) this.checkPrinterName,
          (object) this.checkDetailPaperTray,
          (object) this.checkDetailPrinterName,
          (object) this.checkDetailPaperTray
        }) as frmReprintChecks;
        try
        {
          int num = (int) form.ShowDialog();
        }
        finally
        {
          form.Dispose();
        }
      }
    }
    else
    {
      dsCheckPrinterSettings checkPrinterDataset = new dsCheckPrinterSettings();
      DefaultDatabase.LoadDataSet((DataSet) checkPrinterDataset, new string[1]
      {
        "PrinterSettings"
      }, "spFin_GetCheckPrinterSettings");
      using (formSelectCheckPrinter selectCheckPrinter = new formSelectCheckPrinter(ref checkPrinterDataset))
      {
        if (selectCheckPrinter.ShowDialog() == DialogResult.OK)
        {
          this.checkPrinterName = selectCheckPrinter.CheckPrinterName;
          this.checkPaperSource = selectCheckPrinter.CheckPrinterSettings;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(selectCheckPrinter.CheckDetailPrinterName, string.Empty, false) == 0)
          {
            this.checkDetailPrinterName = selectCheckPrinter.CheckPrinterName;
            this.checkDetailPaperTray = selectCheckPrinter.CheckPrinterSettings;
          }
          else
          {
            this.checkDetailPrinterName = selectCheckPrinter.CheckDetailPrinterName;
            this.checkDetailPaperTray = selectCheckPrinter.CheckDetailPrinterSettings;
          }
        }
        else
        {
          int num = (int) MessageBox.Show("No settings have changed.", "User Cancelled Operation", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
      }
    }
  }

  private int GetSelectedChecksCount()
  {
    RowsCollection rows = ((UltraGridBase) this.gridPrintableChecks).Rows;
    System.Func<UltraGridRow, bool> predicate;
    // ISSUE: reference to a compiler-generated field
    if (frmPrintChecks._Closure\u0024__.\u0024I127\u002D0 != null)
    {
      // ISSUE: reference to a compiler-generated field
      predicate = frmPrintChecks._Closure\u0024__.\u0024I127\u002D0;
    }
    else
    {
      // ISSUE: reference to a compiler-generated field
      frmPrintChecks._Closure\u0024__.\u0024I127\u002D0 = predicate = (System.Func<UltraGridRow, bool>) ([SpecialName] (x) => Conversions.ToBoolean(x.Cells["select.."].Value));
    }
    return ((IEnumerable<UltraGridRow>) rows).Where<UltraGridRow>(predicate).Count<UltraGridRow>();
  }

  private void gridPrintableChecks_CellChange(object sender, CellEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Cell.Column.Key, "Select..", false) != 0)
      return;
    this.gridPrintableChecks.PerformAction((UltraGridAction) 44);
    e.Cell.Row.Update();
    ((UltraGridBase) this.gridPrintableChecks).UpdateData();
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Bands[0].SummaryFooterCaption = $"{this.GetSelectedChecksCount()} Checks Selected - Check Total:";
  }

  protected struct PrintedCheckData
  {
    public int TransactionNumber;
    public string Payee;
    public string CheckNumber;
  }
}
