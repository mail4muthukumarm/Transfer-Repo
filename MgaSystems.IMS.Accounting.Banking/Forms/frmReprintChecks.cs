// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.frmReprintChecks
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using GrapeCity.ActiveReports;
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
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[SecureResource("{d64aeaf5-0b2a-4321-9b41-efe6c412d779}", "Check Reprinting Rights", "Ensures that only authorized users have the ability to print checks.", "Accounting")]
public class frmReprintChecks : Form
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
  private DataTable CheckDataTable;
  private PrinterSettings CheckPrinterSettings;
  private PrinterSettings CheckDetailPrinterSettings;
  private Thread threadCheckDetail;
  private int BankGLAcctID;

  public frmReprintChecks()
  {
    this.Closing += new CancelEventHandler(this.frmPrintChecks_Closing);
    this.Transactions = new ArrayList();
    this.checkPrinterName = "";
    this.checkPaperSource = "";
    this.checkDetailPrinterName = "";
    this.checkDetailPaperTray = "";
    this.dsData = new DataSet();
    this.blnCustomSorted = false;
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
  public virtual SqlDataAdapter daGetPrintableChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  internal virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsGetPrintableChecks1")]
  internal virtual dsGetPrintableChecks DsGetPrintableChecks1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridPrintableChecks")]
  public virtual UltraGrid gridPrintableChecks { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dsCheckVerify")]
  internal virtual dsGetPrintableChecks dsCheckVerify { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual UltraToolbarsManager UltraToolbarsManager1
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

  [field: AccessedThroughProperty("dtSearchTo")]
  private virtual MGADateTimePicker dtSearchTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCheckNum")]
  internal virtual TextBox txtCheckNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtSearchFrom")]
  private virtual MGADateTimePicker dtSearchFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_frmPrintChecks_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _frmPrintChecks_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_GetPrintableChecks", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("checknum", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("payeename");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("checkamt");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("transactnum");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("IsOperating");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("User");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("IsClaims");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Select..", 0);
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    LabelTool labelTool1 = new LabelTool("From");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("container1");
    LabelTool labelTool2 = new LabelTool("To");
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("Container2");
    LabelTool labelTool3 = new LabelTool("Check #");
    ControlContainerTool controlContainerTool3 = new ControlContainerTool("container3");
    ButtonTool buttonTool1 = new ButtonTool("GetChecks");
    LabelTool labelTool4 = new LabelTool("From");
    ControlContainerTool controlContainerTool4 = new ControlContainerTool("container1");
    LabelTool labelTool5 = new LabelTool("To");
    ControlContainerTool controlContainerTool5 = new ControlContainerTool("Container2");
    LabelTool labelTool6 = new LabelTool("Check #");
    TextBoxTool textBoxTool = new TextBoxTool("txtCheckNum");
    ButtonTool buttonTool2 = new ButtonTool("GetChecks");
    Appearance appearance16 = new Appearance();
    ControlContainerTool controlContainerTool6 = new ControlContainerTool("container3");
    this.daGetPrintableChecks = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this._frmPrintChecks_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmPrintChecks_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._frmPrintChecks_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmPrintChecks_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.dsCheckVerify = new dsGetPrintableChecks();
    this.btnVerify = new UltraButton();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.linkPrintUnSelectAll = new LinkLabel();
    this.linkPrintSelectAll = new LinkLabel();
    this.btnPrint = new UltraButton();
    this.gridPrintableChecks = new UltraGrid();
    this.DsGetPrintableChecks1 = new dsGetPrintableChecks();
    this.dtSearchFrom = new MGADateTimePicker();
    this.dtSearchTo = new MGADateTimePicker();
    this.txtCheckNum = new TextBox();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.dsCheckVerify.BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.gridPrintableChecks).BeginInit();
    this.DsGetPrintableChecks1.BeginInit();
    ((ISupportInitialize) this.dtSearchFrom).BeginInit();
    ((ISupportInitialize) this.dtSearchTo).BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.SuspendLayout();
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
    this.SqlSelectCommand1.CommandText = "[spFin_GetReprintChecks]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@DateFrom", SqlDbType.DateTime),
      new SqlParameter("@DateTo", SqlDbType.DateTime),
      new SqlParameter("@CheckNum", SqlDbType.VarChar),
      new SqlParameter("@glaccountid", SqlDbType.Int)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._frmPrintChecks_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).Location = new Point(0, 26);
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).Name = "_frmPrintChecks_Toolbars_Dock_Area_Left";
    ((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left).Size = new Size(0, 656);
    this._frmPrintChecks_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
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
    this.dsCheckVerify.DataSetName = "dsGetPrintableChecks";
    this.dsCheckVerify.Locale = new CultureInfo("en-US");
    this.dsCheckVerify.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnVerify).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((Control) this.btnVerify).Location = new Point(703, 598);
    ((Control) this.btnVerify).Name = "btnVerify";
    ((Control) this.btnVerify).Size = new Size(120, 32 /*0x20*/);
    ((Control) this.btnVerify).TabIndex = 4;
    ((ControlBase) this.btnVerify).Text = "Close";
    ((Control) this.MgaGroupBox1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.dtSearchTo);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtCheckNum);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.dtSearchFrom);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.linkPrintUnSelectAll);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.linkPrintSelectAll);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnPrint);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.gridPrintableChecks);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnVerify);
    appearance2.AlphaLevel = (short) 230;
    appearance2.FontData.SizeInPoints = 10f;
    appearance2.ForeColor = Color.White;
    appearance2.ForegroundAlpha = (Alpha) 2;
    appearance2.ImageAlpha = (Alpha) 2;
    appearance2.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.MgaGroupBox1).Location = new Point(6, 29);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(831, 641);
    ((Control) this.MgaGroupBox1).TabIndex = 10;
    this.MgaGroupBox1.Text = "Printable Checks";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.linkPrintUnSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkPrintUnSelectAll.AutoSize = true;
    this.linkPrintUnSelectAll.BackColor = Color.FromArgb(239, 247, 253);
    this.linkPrintUnSelectAll.Location = new Point(80 /*0x50*/, 617);
    this.linkPrintUnSelectAll.Name = "linkPrintUnSelectAll";
    this.linkPrintUnSelectAll.Size = new Size(67, 13);
    this.linkPrintUnSelectAll.TabIndex = 5;
    this.linkPrintUnSelectAll.TabStop = true;
    this.linkPrintUnSelectAll.Text = "Un-Select All";
    this.linkPrintSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkPrintSelectAll.AutoSize = true;
    this.linkPrintSelectAll.BackColor = Color.FromArgb(239, 247, 253);
    this.linkPrintSelectAll.Location = new Point(16 /*0x10*/, 617);
    this.linkPrintSelectAll.Name = "linkPrintSelectAll";
    this.linkPrintSelectAll.Size = new Size(50, 13);
    this.linkPrintSelectAll.TabIndex = 4;
    this.linkPrintSelectAll.TabStop = true;
    this.linkPrintSelectAll.Text = "Select All";
    ((Control) this.btnPrint).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraButtonBase) this.btnPrint).ButtonStyle = (UIElementButtonStyle) 3;
    ((Control) this.btnPrint).Location = new Point(577, 599);
    ((Control) this.btnPrint).Name = "btnPrint";
    ((Control) this.btnPrint).Size = new Size(120, 32 /*0x20*/);
    ((Control) this.btnPrint).TabIndex = 3;
    ((ControlBase) this.btnPrint).Text = "Print Check(s)";
    ((Control) this.gridPrintableChecks).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.gridPrintableChecks).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridPrintableChecks).DataSource = (object) this.DsGetPrintableChecks1;
    appearance3.BackColor = Color.Transparent;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Check #";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Width = 152;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    appearance4.FontData.BoldAsString = "False";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Payee";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 352;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn3.Format = "c";
    ((AppearanceBase) appearance6).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Check Amount";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 3;
    ultraGridColumn3.Width = 131;
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
    ultraGridColumn6.Width = 86;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 7;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 66;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.DataType = typeof (bool);
    ((AppearanceBase) appearance7).TextHAlignAsString = "Center";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Width = 92;
    ultraGridBand.Columns.AddRange(new object[8]
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
    appearance8.BackColor = Color.White;
    appearance8.FontData.BoldAsString = "True";
    appearance8.FontData.Name = "Tahoma";
    ((HeaderBase) ultraGridBand.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridBand.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
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
    appearance9.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance10.ForeColor = Color.Black;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    appearance11.BackColor = Color.FromArgb(246, 250, 253);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.gridPrintableChecks).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    ((Control) this.gridPrintableChecks).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridPrintableChecks).Location = new Point(8, 26);
    ((Control) this.gridPrintableChecks).Name = "gridPrintableChecks";
    ((Control) this.gridPrintableChecks).Size = new Size(815, 567);
    ((Control) this.gridPrintableChecks).TabIndex = 0;
    ((UltraControlBase) this.gridPrintableChecks).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPrintableChecks).UseOsThemes = (DefaultableBoolean) 2;
    this.DsGetPrintableChecks1.DataSetName = "dsGetPrintableChecks";
    this.DsGetPrintableChecks1.Locale = new CultureInfo("en-US");
    this.DsGetPrintableChecks1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtSearchFrom.Appearance = (AppearanceBase) appearance12;
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
    this.dtSearchFrom.ButtonAppearance = (AppearanceBase) appearance13;
    ((Control) this.dtSearchFrom).Location = new Point(398, 598);
    this.dtSearchFrom.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtSearchFrom).Name = "dtSearchFrom";
    ((Control) this.dtSearchFrom).Size = new Size(0, 20);
    ((Control) this.dtSearchFrom).TabIndex = 7;
    ((UltraControlBase) this.dtSearchFrom).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtSearchFrom).UseOsThemes = (DefaultableBoolean) 2;
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtSearchTo.Appearance = (AppearanceBase) appearance14;
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
    this.dtSearchTo.ButtonAppearance = (AppearanceBase) appearance15;
    ((Control) this.dtSearchTo).Location = new Point(301, 604);
    this.dtSearchTo.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtSearchTo).Name = "dtSearchTo";
    ((Control) this.dtSearchTo).Size = new Size(0, 20);
    ((Control) this.dtSearchTo).TabIndex = 8;
    ((UltraControlBase) this.dtSearchTo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtSearchTo).UseOsThemes = (DefaultableBoolean) 2;
    this.txtCheckNum.Location = new Point(170, 609);
    this.txtCheckNum.Name = "txtCheckNum";
    this.txtCheckNum.Size = new Size(0, 21);
    this.txtCheckNum.TabIndex = 9;
    this.UltraToolbarsManager1.AlwaysShowMenusExpanded = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.MdiMergeable = false;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    controlContainerTool1.ControlName = "dtSearchFrom";
    ((ToolPropsBase) ((ToolBase) controlContainerTool1).InstanceProps).Width = 100;
    controlContainerTool2.ControlName = "dtSearchTo";
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).InstanceProps).Width = 100;
    controlContainerTool3.ControlName = "txtCheckNum";
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[7]
    {
      (ToolBase) labelTool1,
      (ToolBase) controlContainerTool1,
      (ToolBase) labelTool2,
      (ToolBase) controlContainerTool2,
      (ToolBase) labelTool3,
      (ToolBase) controlContainerTool3,
      (ToolBase) buttonTool1
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
    ((ToolPropsBase) ((ToolBase) labelTool4).SharedPropsInternal).Caption = "From:";
    ((ToolPropsBase) ((ToolBase) labelTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 2;
    controlContainerTool4.ControlName = "dtSearchFrom";
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).MaxWidth = 100;
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).MinWidth = 100;
    ((ToolPropsBase) ((ToolBase) controlContainerTool4).SharedPropsInternal).Width = 100;
    ((ToolPropsBase) ((ToolBase) labelTool5).SharedPropsInternal).Caption = "To:";
    ((ToolPropsBase) ((ToolBase) labelTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 2;
    ((ToolPropsBase) ((ToolBase) labelTool5).SharedPropsInternal).MaxWidth = 90;
    ((ToolPropsBase) ((ToolBase) labelTool5).SharedPropsInternal).MinWidth = 90;
    controlContainerTool5.ControlName = "dtSearchTo";
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).Caption = "Container2";
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).MaxWidth = 100;
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).MinWidth = 100;
    ((ToolPropsBase) ((ToolBase) controlContainerTool5).SharedPropsInternal).Width = 100;
    ((ToolPropsBase) ((ToolBase) labelTool6).SharedPropsInternal).Caption = "Check #";
    textBoxTool.MaxLength = 100;
    ((ToolPropsBase) ((ToolBase) textBoxTool).SharedPropsInternal).MaxWidth = 100;
    ((ToolPropsBase) ((ToolBase) textBoxTool).SharedPropsInternal).MinWidth = 100;
    appearance16.Image = (object) MGASystems.IMS.Accounting.Banking.My.Resources.Resources.createCheck;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "Get Checks";
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    controlContainerTool6.ControlName = "txtCheckNum";
    ((ToolPropsBase) ((ToolBase) controlContainerTool6).SharedPropsInternal).Caption = "container3";
    ((ToolPropsBase) ((ToolBase) controlContainerTool6).SharedPropsInternal).MaxWidth = 125;
    ((ToolPropsBase) ((ToolBase) controlContainerTool6).SharedPropsInternal).MinWidth = 125;
    ((ToolPropsBase) ((ToolBase) controlContainerTool6).SharedPropsInternal).Width = 125;
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[8]
    {
      (ToolBase) labelTool4,
      (ToolBase) controlContainerTool4,
      (ToolBase) labelTool5,
      (ToolBase) controlContainerTool5,
      (ToolBase) labelTool6,
      (ToolBase) textBoxTool,
      (ToolBase) buttonTool2,
      (ToolBase) controlContainerTool6
    });
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ClientSize = new Size(841, 682);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this._frmPrintChecks_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmPrintChecks_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmPrintChecks_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._frmPrintChecks_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmReprintChecks);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "IMS Accounting - Reprint Checks";
    this.dsCheckVerify.EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.gridPrintableChecks).EndInit();
    this.DsGetPrintableChecks1.EndInit();
    ((ISupportInitialize) this.dtSearchFrom).EndInit();
    ((ISupportInitialize) this.dtSearchTo).EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  public frmReprintChecks(int GLAcctID)
  {
    this.Closing += new CancelEventHandler(this.frmPrintChecks_Closing);
    this.Transactions = new ArrayList();
    this.checkPrinterName = "";
    this.checkPaperSource = "";
    this.checkDetailPrinterName = "";
    this.checkDetailPaperTray = "";
    this.dsData = new DataSet();
    this.blnCustomSorted = false;
    this.CheckDataTable = new DataTable();
    this.InitializeComponent();
    this.BankGLAcctID = GLAcctID;
  }

  public frmReprintChecks(DataTable DataTbl)
  {
    this.Closing += new CancelEventHandler(this.frmPrintChecks_Closing);
    this.Transactions = new ArrayList();
    this.checkPrinterName = "";
    this.checkPaperSource = "";
    this.checkDetailPrinterName = "";
    this.checkDetailPaperTray = "";
    this.dsData = new DataSet();
    this.blnCustomSorted = false;
    this.CheckDataTable = new DataTable();
    this.InitializeComponent();
    this.CheckDataTable = DataTbl;
  }

  public frmReprintChecks(DataTable DataTbl, int BankGLAccount)
  {
    this.Closing += new CancelEventHandler(this.frmPrintChecks_Closing);
    this.Transactions = new ArrayList();
    this.checkPrinterName = "";
    this.checkPaperSource = "";
    this.checkDetailPrinterName = "";
    this.checkDetailPaperTray = "";
    this.dsData = new DataSet();
    this.blnCustomSorted = false;
    this.CheckDataTable = new DataTable();
    this.InitializeComponent();
    this.CheckDataTable = DataTbl;
    this.BankGLAcctID = BankGLAccount;
  }

  public frmReprintChecks(
    int GLAcctID,
    string printerName,
    string printerSettings,
    string detailName,
    string detailSettings)
  {
    this.Closing += new CancelEventHandler(this.frmPrintChecks_Closing);
    this.Transactions = new ArrayList();
    this.checkPrinterName = "";
    this.checkPaperSource = "";
    this.checkDetailPrinterName = "";
    this.checkDetailPaperTray = "";
    this.dsData = new DataSet();
    this.blnCustomSorted = false;
    this.CheckDataTable = new DataTable();
    this.InitializeComponent();
    this.Text = $"{this.Text}-{printerName}";
    this.BankGLAcctID = GLAcctID;
    this.checkPrinterName = printerName;
    this.checkPaperSource = printerSettings;
    this.checkDetailPrinterName = detailName;
    this.checkDetailPaperTray = detailSettings;
  }

  public frmReprintChecks(
    int CheckNum,
    int GLAcctID,
    string printerName,
    string printerSettings,
    string detailName,
    string detailSettings)
    : this(GLAcctID, printerName, printerSettings, detailName, detailSettings)
  {
    this.DsGetPrintableChecks1.Clear();
    this.FormDataConnection.ConnectionString = DefaultDatabase.CreateConnection().ConnectionString;
    this.daGetPrintableChecks.SelectCommand.Parameters["@CheckNum"].Value = (object) CheckNum;
    this.daGetPrintableChecks.SelectCommand.Parameters["@glaccountid"].Value = (object) GLAcctID;
    DefaultDatabase.DataAdapterFill((DbDataAdapter) this.daGetPrintableChecks, (DataSet) this.DsGetPrintableChecks1);
    this.AddCheckSummaryRow();
  }

  private void AddCheckSummaryRow()
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
            PrintExtension.Print(sectionReport.Document, false, false, false);
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "INSERT INTO dbo.tblFin_CheckPrintingHistory\r\n                                        (\r\n                                            TransactNum,\r\n                                            WhenPrinted,\r\n                                            UserID\r\n                                        )\r\n                                        VALUES\r\n                                        (   @TransactNum,        \r\n                                            @WhenPrinted,\r\n                                            @UserID\r\n                                            )", new object[6]
            {
              (object) "@TransactNum",
              (object) row.Cells["transactnum"].Value.ToString(),
              (object) "@WhenPrinted",
              (object) DateTime.Now,
              (object) "@UserID",
              (object) CurrentUser.Instance.UserID
            });
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
        this.PrintCheckDetail(int.Parse(row.Cells["transactnum"].Value.ToString()), boolean, row.Cells["payeename"].Value.ToString(), row.Cells["checknum"].Value.ToString());
        CurrentUser.Instance.LogAction(string.Format("The following check has been reprinted: check # {0} on the following date: {1} .", (object) row.Cells["checknum"].Value.ToString(), (object) DateAndTime.Today.ToShortDateString(), (object) "Banking Logs"));
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

  private void btnVerify_Click(object sender, EventArgs e) => this.Close();

  private bool Verify(UltraGrid grid)
  {
    // ISSUE: unable to decompile the method.
  }

  private void frmPrintChecks_Closing(object sender, CancelEventArgs e)
  {
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
    int? count = printDialog1.PrinterSettings?.PaperSources?.Count;
    bool? nullable1 = count.HasValue ? new bool?(count.GetValueOrDefault() > 0) : new bool?();
    if (nullable1.GetValueOrDefault())
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
    count = printDialog2.PrinterSettings?.PaperSources?.Count;
    bool? nullable2;
    if (!count.HasValue)
    {
      nullable1 = new bool?();
      nullable2 = nullable1;
    }
    else
      nullable2 = new bool?(count.GetValueOrDefault() > 0);
    nullable1 = nullable2;
    if (!nullable1.GetValueOrDefault())
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
    if (sender != this.linkPrintSelectAll)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridPrintableChecks).Rows)
      row.Cells["select.."].Value = (object) true;
  }

  private void linkPrintUnSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (sender != this.linkPrintUnSelectAll)
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridPrintableChecks).Rows)
      row.Cells["select.."].Value = (object) false;
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((ToolEventArgs) e).Tool.Key, "GetChecks", false) != 0 || this.DesignMode)
      return;
    this.DsGetPrintableChecks1.Clear();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetPrintableChecks.SelectCommand.Parameters["@DateFrom"].Value = (object) this.dtSearchFrom.DateTime;
    this.daGetPrintableChecks.SelectCommand.Parameters["@DateTo"].Value = (object) this.dtSearchTo.DateTime;
    this.daGetPrintableChecks.SelectCommand.Parameters["@CheckNum"].Value = (object) this.txtCheckNum.Text;
    this.daGetPrintableChecks.SelectCommand.Parameters["@CheckNum"].Value = !string.IsNullOrEmpty(this.txtCheckNum.Text) ? (object) this.txtCheckNum.Text : (object) DBNull.Value;
    this.daGetPrintableChecks.SelectCommand.Parameters["@glaccountid"].Value = (object) this.BankGLAcctID;
    this.daGetPrintableChecks.Fill((DataSet) this.DsGetPrintableChecks1);
    this.AddCheckSummaryRow();
  }

  protected struct PrintedCheckData
  {
    public int TransactionNumber;
    public string Payee;
    public string CheckNumber;
  }
}
