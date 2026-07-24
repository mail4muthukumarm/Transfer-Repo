// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.BankAccountRegister
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.Misc.CommonControls;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Banking.Banking.Forms;
using MGASystems.IMS.Accounting.Banking.Enumerations;
using MGASystems.IMS.Accounting.Banking.Forms;
using MGASystems.IMS.Accounting.Banking.Services;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Accounting.SharedForms;
using MGASystems.IMS.Reporting;
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
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

[SecureResource("{724FE13B-6F3C-4c8b-B6B4-B41BBF157C55}", "Reconcile/Un-Reconcile Bank Transaction", "Determines whether or not a user can reconcile/un-reconcile bank transactions.", "Accounting")]
public class BankAccountRegister : UserControl
{
  private string filePathName;
  private int _glCompany;
  private IContainer components;
  internal int _bankaccountgl;
  private Decimal _bal;
  private DateTime _currentdate;
  private const string _BalanceWillBeNegative = "This transaction will bring the accounts balance below zero.";
  private const string _BalanceWillBePositive = "This transaction will bring the accounts balance above zero.";
  private Thread LoadThread;
  private MemoryStream gridLayout;
  private dsBankAccountRegister registerDataSet;
  private UltraGridRow currentContextRow;
  protected string sprocBankAcctRegisterName;

  public BankAccountRegister()
  {
    this.Load += new EventHandler(this.BankAccountRegister_Load);
    this.sprocBankAcctRegisterName = "dbo.spFin_GetBanKAccountRegister";
    this.InitializeComponent();
    this.LoadMonthsCombo();
    this.LoadYearCombo();
  }

  public virtual MGAButton MgaButton1
  {
    get => this._MgaButton1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.MgaButton1_Click);
      MGAButton mgaButton1_1 = this._MgaButton1;
      if (mgaButton1_1 != null)
        ((Control) mgaButton1_1).Click -= eventHandler;
      this._MgaButton1 = value;
      MGAButton mgaButton1_2 = this._MgaButton1;
      if (mgaButton1_2 == null)
        return;
      ((Control) mgaButton1_2).Click += eventHandler;
    }
  }

  internal virtual UltraGridExcelExporter UltraGridExcelExporter1
  {
    get => this._UltraGridExcelExporter1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ExportStartedEventHandler startedEventHandler = new ExportStartedEventHandler(this.UltraGridExcelExporter1_ExportStarted);
      ExportEndedEventHandler endedEventHandler = new ExportEndedEventHandler(this.UltraGridExcelExporter1_ExportEnded);
      CellExportedEventHandler exportedEventHandler = new CellExportedEventHandler(this.UltraGridExcelExporter1_CellExported);
      InitializeColumnEventHandler columnEventHandler = new InitializeColumnEventHandler(this.UltraGridExcelExporter1_InitializeColumn);
      UltraGridExcelExporter gridExcelExporter1_1 = this._UltraGridExcelExporter1;
      if (gridExcelExporter1_1 != null)
      {
        gridExcelExporter1_1.ExportStarted -= startedEventHandler;
        gridExcelExporter1_1.ExportEnded -= endedEventHandler;
        gridExcelExporter1_1.CellExported -= exportedEventHandler;
        gridExcelExporter1_1.InitializeColumn -= columnEventHandler;
      }
      this._UltraGridExcelExporter1 = value;
      UltraGridExcelExporter gridExcelExporter1_2 = this._UltraGridExcelExporter1;
      if (gridExcelExporter1_2 == null)
        return;
      gridExcelExporter1_2.ExportStarted += startedEventHandler;
      gridExcelExporter1_2.ExportEnded += endedEventHandler;
      gridExcelExporter1_2.CellExported += exportedEventHandler;
      gridExcelExporter1_2.InitializeColumn += columnEventHandler;
    }
  }

  public BankAccountRegister(int BankAccountID, int glCompanyId)
  {
    this.Load += new EventHandler(this.BankAccountRegister_Load);
    this.sprocBankAcctRegisterName = "dbo.spFin_GetBanKAccountRegister";
    this.InitializeComponent();
    this._bankaccountgl = BankAccountID;
    this.LoadMonthsCombo();
    this.LoadYearCombo();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    if (this.LoadThread.ThreadState != System.Threading.ThreadState.Stopped)
    {
      try
      {
        this.LoadThread.Abort();
      }
      catch (ThreadAbortException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ProjectData.ClearProjectError();
      }
    }
    base.Dispose(disposing);
  }

  public virtual UltraGrid gridRegister
  {
    get => this._gridRegister;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.gridRegister_InitializeRow);
      UltraGrid gridRegister1 = this._gridRegister;
      if (gridRegister1 != null)
        gridRegister1.InitializeRow -= initializeRowEventHandler;
      this._gridRegister = value;
      UltraGrid gridRegister2 = this._gridRegister;
      if (gridRegister2 == null)
        return;
      gridRegister2.InitializeRow += initializeRowEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsBankAccountRegister1")]
  internal virtual dsBankAccountRegister DsBankAccountRegister1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankAccountRegister")]
  internal virtual SqlDataAdapter daGetBankAccountRegister { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ControlDataConnection")]
  internal virtual SqlConnection ControlDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ImageList1")]
  internal virtual ImageList ImageList1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ToolTip1")]
  internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
      BeforeToolDropdownEventHandler dropdownEventHandler = new BeforeToolDropdownEventHandler(this.UltraToolbarsManager1_BeforeToolDropdown);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
      {
        toolbarsManager1_1.ToolClick -= clickEventHandler;
        toolbarsManager1_1.BeforeToolDropdown -= dropdownEventHandler;
      }
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.ToolClick += clickEventHandler;
      toolbarsManager1_2.BeforeToolDropdown += dropdownEventHandler;
    }
  }

  [field: AccessedThroughProperty("_BankAccountRegister_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _BankAccountRegister_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_BankAccountRegister_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _BankAccountRegister_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_BankAccountRegister_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _BankAccountRegister_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_BankAccountRegister_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _BankAccountRegister_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel labelRemoveSearchFilter
  {
    get => this._labelRemoveSearchFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.labelRemoveSearchFilter_Click);
      LinkLabel removeSearchFilter1 = this._labelRemoveSearchFilter;
      if (removeSearchFilter1 != null)
        removeSearchFilter1.Click -= eventHandler;
      this._labelRemoveSearchFilter = value;
      LinkLabel removeSearchFilter2 = this._labelRemoveSearchFilter;
      if (removeSearchFilter2 == null)
        return;
      removeSearchFilter2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("panelCurtain")]
  internal virtual Panel panelCurtain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox1")]
  internal virtual MGAGroupBox MgaGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaGroupBox2")]
  internal virtual MGAGroupBox MgaGroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("EllipsePanel1")]
  internal virtual EllipsePanel EllipsePanel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBankName")]
  internal virtual Label lblBankName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("AnimationControl1")]
  internal virtual AnimationControl AnimationControl1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox comboMonth
  {
    get => this._comboMonth;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.ComboRowSelected);
      MGASimpleComboBox comboMonth1 = this._comboMonth;
      if (comboMonth1 != null)
        comboMonth1.RowSelected -= selectedEventHandler;
      this._comboMonth = value;
      MGASimpleComboBox comboMonth2 = this._comboMonth;
      if (comboMonth2 == null)
        return;
      comboMonth2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraLabel1")]
  internal virtual UltraLabel UltraLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGASimpleComboBox comboYear
  {
    get => this._comboYear;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.ComboRowSelected);
      MGASimpleComboBox comboYear1 = this._comboYear;
      if (comboYear1 != null)
        comboYear1.RowSelected -= selectedEventHandler;
      this._comboYear = value;
      MGASimpleComboBox comboYear2 = this._comboYear;
      if (comboYear2 == null)
        return;
      comboYear2.RowSelected += selectedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraLabel2")]
  internal virtual UltraLabel UltraLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual CheckBox checkShowVoids
  {
    get => this._checkShowVoids;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.checkShowVoids_CheckedChanged);
      CheckBox checkShowVoids1 = this._checkShowVoids;
      if (checkShowVoids1 != null)
        checkShowVoids1.CheckedChanged -= eventHandler;
      this._checkShowVoids = value;
      CheckBox checkShowVoids2 = this._checkShowVoids;
      if (checkShowVoids2 == null)
        return;
      checkShowVoids2.CheckedChanged += eventHandler;
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Register", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("transactNum");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("transactionDate", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CheckOrRef");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Method");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Status");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Description");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Debit");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Credit");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("IsVoided");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("TrxType");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("IsReconciled");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("HasBouncedChecks");
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("HasVoidedTransactions");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("balance", 0);
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("statusIcons", 1);
    Appearance appearance15 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("TransactNumDisplay", 2);
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BankAccountRegister));
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("GridContext");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("pmGridContext");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("pmGridContext");
    ButtonTool buttonTool1 = new ButtonTool("NewDeposit");
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("DepositOptions");
    ButtonTool buttonTool2 = new ButtonTool("CashReceipt");
    ButtonTool buttonTool3 = new ButtonTool("PrintChecks");
    ButtonTool buttonTool4 = new ButtonTool("PrintFacsimile");
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("Reconciliation");
    PopupMenuTool popupMenuTool5 = new PopupMenuTool("Bank Transactions / Adjustments");
    ButtonTool buttonTool5 = new ButtonTool("VoidTransaction");
    ButtonTool buttonTool6 = new ButtonTool("DeleteTransaction");
    ButtonTool buttonTool7 = new ButtonTool("ViewDetail");
    ButtonTool buttonTool8 = new ButtonTool("PrintTrx");
    ButtonTool buttonTool9 = new ButtonTool("NewDeposit");
    ButtonTool buttonTool10 = new ButtonTool("ViewDepositDetail");
    ButtonTool buttonTool11 = new ButtonTool("BankFees");
    ButtonTool buttonTool12 = new ButtonTool("BankInterest");
    PopupMenuTool popupMenuTool6 = new PopupMenuTool("Bank Transactions / Adjustments");
    ButtonTool buttonTool13 = new ButtonTool("BankFees");
    ButtonTool buttonTool14 = new ButtonTool("BankInterest");
    ButtonTool buttonTool15 = new ButtonTool("DeleteTransaction");
    ButtonTool buttonTool16 = new ButtonTool("BouncedCheck");
    ButtonTool buttonTool17 = new ButtonTool("UnReconcile");
    ButtonTool buttonTool18 = new ButtonTool("ReplaceVoid");
    ButtonTool buttonTool19 = new ButtonTool("VoidTransaction");
    ButtonTool buttonTool20 = new ButtonTool("PrintChecks");
    PopupMenuTool popupMenuTool7 = new PopupMenuTool("Reconciliation");
    ButtonTool buttonTool21 = new ButtonTool("UnReconcile");
    PopupMenuTool popupMenuTool8 = new PopupMenuTool("DepositOptions");
    ButtonTool buttonTool22 = new ButtonTool("ViewDepositDetail");
    ButtonTool buttonTool23 = new ButtonTool("BouncedCheck");
    ButtonTool buttonTool24 = new ButtonTool("ReplaceVoid");
    ButtonTool buttonTool25 = new ButtonTool("UnGroupDeposit");
    ButtonTool buttonTool26 = new ButtonTool("CashReceipt");
    ButtonTool buttonTool27 = new ButtonTool("PrintFacsimile");
    ButtonTool buttonTool28 = new ButtonTool("UnGroupDeposit");
    ButtonTool buttonTool29 = new ButtonTool("ViewDetail");
    ButtonTool buttonTool30 = new ButtonTool("PrintTrx");
    this.gridRegister = new UltraGrid();
    this.DsBankAccountRegister1 = new dsBankAccountRegister();
    this.panelCurtain = new Panel();
    this.AnimationControl1 = new AnimationControl();
    this.Label1 = new Label();
    this.labelRemoveSearchFilter = new LinkLabel();
    this.daGetBankAccountRegister = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ControlDataConnection = new SqlConnection();
    this.ImageList1 = new ImageList(this.components);
    this.ToolTip1 = new ToolTip(this.components);
    this.MgaGroupBox1 = new MGAGroupBox();
    this.MgaButton1 = new MGAButton();
    this.comboYear = new MGASimpleComboBox();
    this.UltraLabel2 = new UltraLabel();
    this.comboMonth = new MGASimpleComboBox();
    this.UltraLabel1 = new UltraLabel();
    this.lblBankName = new Label();
    this.checkShowVoids = new CheckBox();
    this.MgaGroupBox2 = new MGAGroupBox();
    this.EllipsePanel1 = new EllipsePanel();
    this.Panel1 = new Panel();
    this.Panel2 = new Panel();
    this.Panel3 = new Panel();
    this._BankAccountRegister_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._BankAccountRegister_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._BankAccountRegister_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._BankAccountRegister_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.UltraGridExcelExporter1 = new UltraGridExcelExporter(this.components);
    ((ISupportInitialize) this.gridRegister).BeginInit();
    this.DsBankAccountRegister1.BeginInit();
    this.panelCurtain.SuspendLayout();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.MgaButton1).BeginInit();
    ((ISupportInitialize) this.comboYear).BeginInit();
    ((ISupportInitialize) this.comboMonth).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox2).BeginInit();
    ((Control) this.MgaGroupBox2).SuspendLayout();
    this.EllipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.gridRegister, "pmGridContext");
    ((UltraGridBase) this.gridRegister).DataMember = "Register";
    ((UltraGridBase) this.gridRegister).DataSource = (object) this.DsBankAccountRegister1;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridRegister).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridRegister).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 20;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance2).TextVAlignAsString = "Middle";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 4;
    ultraGridColumn2.LockedWidth = true;
    ultraGridColumn2.Width = 85;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance3).TextVAlignAsString = "Middle";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 5;
    ultraGridColumn3.Width = 51;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance4).TextVAlignAsString = "Middle";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 7;
    ultraGridColumn4.Width = 24;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance5).TextVAlignAsString = "Middle";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 8;
    ultraGridColumn5.Width = 24;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((AppearanceBase) appearance6).TextVAlignAsString = "Middle";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 9;
    ultraGridColumn6.Width = 250;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance7).TextVAlignAsString = "Middle";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance7;
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 10;
    ultraGridColumn7.Width = 119;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance9).TextVAlignAsString = "Middle";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance9;
    ultraGridColumn8.Format = "c";
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 11;
    ultraGridColumn8.Width = 119;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 12;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 43;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 13;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 85;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 14;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 63 /*0x3F*/;
    appearance11.FontData.BoldAsString = "True";
    appearance11.FontData.SizeInPoints = 11f;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance11).TextVAlignAsString = "Middle";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn12.LockedWidth = true;
    ultraGridColumn12.Style = (ColumnStyle) 1;
    ultraGridColumn12.Width = 13;
    appearance12.FontData.BoldAsString = "True";
    appearance12.FontData.SizeInPoints = 11f;
    appearance12.ForeColor = Color.Red;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance12).TextVAlignAsString = "Middle";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridColumn13.LockedWidth = true;
    ultraGridColumn13.Width = 12;
    ultraGridColumn14.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ((AppearanceBase) appearance13).TextVAlignAsString = "Middle";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn14.DataType = typeof (Decimal);
    ultraGridColumn14.Format = "c";
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Balance";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 15;
    ultraGridColumn14.Width = 191;
    ultraGridColumn15.AllowRowFiltering = (DefaultableBoolean) 2;
    appearance15.FontData.BoldAsString = "True";
    appearance15.FontData.Name = "Arial Black";
    ((AppearanceBase) appearance15).TextHAlignAsString = "Center";
    ((AppearanceBase) appearance15).TextVAlignAsString = "Middle";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance15;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 1;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.LockedWidth = true;
    ultraGridColumn15.Width = 9;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Transact #";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 6;
    ultraGridColumn16.Width = 106;
    ultraGridBand.Columns.AddRange(new object[16 /*0x10*/]
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
      (object) ultraGridColumn16
    });
    ((AppearanceBase) appearance16).TextVAlignAsString = "Top";
    ultraGridBand.Override.HeaderAppearance = (AppearanceBase) appearance16;
    ultraGridBand.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.gridRegister).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridRegister).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance17.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance18.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    appearance18.ForeColor = Color.Black;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance19.AlphaLevel = (short) byte.MaxValue;
    appearance19.BackColor = Color.FromArgb(246, 250, 253);
    appearance19.BackColorAlpha = (Alpha) 1;
    appearance19.ForeColor = Color.Black;
    appearance19.ForegroundAlpha = (Alpha) 2;
    appearance19.ImageBackgroundAlpha = (Alpha) 2;
    appearance19.ImageBackgroundStyle = (ImageBackgroundStyle) 1;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance19;
    appearance20.AlphaLevel = (short) byte.MaxValue;
    appearance20.BackColor = Color.White;
    appearance20.BackColorAlpha = (Alpha) 1;
    appearance20.ForegroundAlpha = (Alpha) 2;
    appearance20.ImageBackgroundAlpha = (Alpha) 2;
    appearance20.ImageBackgroundStyle = (ImageBackgroundStyle) 1;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance21.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance21.BackColor2 = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance21.BackGradientStyle = (GradientStyle) 2;
    appearance21.ForeColor = Color.Black;
    ((UltraGridBase) this.gridRegister).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance21;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.gridRegister).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridRegister).Dock = DockStyle.Fill;
    ((Control) this.gridRegister).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridRegister).Location = new Point(6, 26);
    ((Control) this.gridRegister).Name = "gridRegister";
    ((Control) this.gridRegister).Size = new Size(996, 662);
    ((Control) this.gridRegister).TabIndex = 0;
    ((UltraControlBase) this.gridRegister).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridRegister).UseOsThemes = (DefaultableBoolean) 2;
    this.DsBankAccountRegister1.DataSetName = "dsBankAccountRegister";
    this.DsBankAccountRegister1.Locale = new CultureInfo("en-US");
    this.panelCurtain.BackColor = Color.White;
    this.panelCurtain.Controls.Add((Control) this.AnimationControl1);
    this.panelCurtain.Controls.Add((Control) this.Label1);
    this.panelCurtain.Cursor = Cursors.WaitCursor;
    this.panelCurtain.Dock = DockStyle.Fill;
    this.panelCurtain.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.panelCurtain.Location = new Point(6, 26);
    this.panelCurtain.Name = "panelCurtain";
    this.panelCurtain.Size = new Size(996, 662);
    this.panelCurtain.TabIndex = 19;
    this.AnimationControl1.AnimationSource = (AnimationType) 161;
    this.AnimationControl1.AutoCenter = true;
    this.AnimationControl1.AutoPlay = true;
    this.AnimationControl1.BorderStyle = BorderStyle.None;
    ((Control) this.AnimationControl1).Dock = DockStyle.Fill;
    ((Control) this.AnimationControl1).Location = new Point(0, 208 /*0xD0*/);
    ((Control) this.AnimationControl1).Name = "AnimationControl1";
    ((Control) this.AnimationControl1).Size = new Size(996, 454);
    ((Control) this.AnimationControl1).TabIndex = 0;
    this.Label1.Dock = DockStyle.Top;
    this.Label1.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(0, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(996, 208 /*0xD0*/);
    this.Label1.TabIndex = 1;
    this.Label1.Text = "Loading the Bank Information....";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    this.Label1.UseMnemonic = false;
    this.labelRemoveSearchFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.labelRemoveSearchFilter.AutoSize = true;
    this.labelRemoveSearchFilter.BackColor = Color.Transparent;
    this.labelRemoveSearchFilter.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelRemoveSearchFilter.LinkColor = Color.Blue;
    this.labelRemoveSearchFilter.Location = new Point(888, 8);
    this.labelRemoveSearchFilter.Name = "labelRemoveSearchFilter";
    this.labelRemoveSearchFilter.Size = new Size(109, 13);
    this.labelRemoveSearchFilter.TabIndex = 14;
    this.labelRemoveSearchFilter.TabStop = true;
    this.labelRemoveSearchFilter.Text = "Remove Search Filter";
    this.labelRemoveSearchFilter.Visible = false;
    this.labelRemoveSearchFilter.VisitedLinkColor = Color.Blue;
    this.daGetBankAccountRegister.SelectCommand = this.SqlSelectCommand1;
    this.daGetBankAccountRegister.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccountRegister", new DataColumnMapping[9]
      {
        new DataColumnMapping("TransactNum", "TransactNum"),
        new DataColumnMapping("TransactionDate", "TransactionDate"),
        new DataColumnMapping("CheckOrRef", "CheckOrRef"),
        new DataColumnMapping("Method", "Method"),
        new DataColumnMapping("Status", "Status"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("Debit", "Debit"),
        new DataColumnMapping("Credit", "Credit"),
        new DataColumnMapping("IsVoided", "IsVoided")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetBankAccountRegister]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.ControlDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@bankglacct", SqlDbType.Int, 4)
    });
    this.ControlDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.ControlDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "");
    this.ImageList1.Images.SetKeyName(1, "");
    this.ImageList1.Images.SetKeyName(2, "");
    this.ImageList1.Images.SetKeyName(3, "");
    this.ImageList1.Images.SetKeyName(4, "");
    this.ImageList1.Images.SetKeyName(5, "");
    this.ImageList1.Images.SetKeyName(6, "");
    appearance22.BackColor = Color.FromArgb(239, 247, 253);
    appearance22.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance22;
    this.MgaGroupBox1.ContentPadding.Bottom = 4;
    this.MgaGroupBox1.ContentPadding.Left = 4;
    this.MgaGroupBox1.ContentPadding.Right = 4;
    this.MgaGroupBox1.ContentPadding.Top = 4;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.MgaButton1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.comboYear);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.UltraLabel2);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.comboMonth);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.UltraLabel1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.lblBankName);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.checkShowVoids);
    this.MgaGroupBox1.Dock = DockStyle.Top;
    ((Control) this.MgaGroupBox1).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    appearance23.AlphaLevel = (short) 230;
    appearance23.FontData.SizeInPoints = 10f;
    appearance23.ForeColor = Color.White;
    appearance23.ForegroundAlpha = (Alpha) 2;
    appearance23.ImageAlpha = (Alpha) 2;
    appearance23.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance23;
    ((Control) this.MgaGroupBox1).Location = new Point(0, 2);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(1008, 96 /*0x60*/);
    ((Control) this.MgaGroupBox1).TabIndex = 29;
    this.MgaGroupBox1.Text = " Bank Information";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.MgaButton1).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance24.BackColor = Color.FromArgb(248, 248, 248);
    appearance24.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance24.BackGradientStyle = (GradientStyle) 2;
    appearance24.BorderColor = Color.DarkGray;
    appearance24.ImageHAlign = (HAlign) 1;
    appearance24.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.MgaButton1).Appearance = (AppearanceBase) appearance24;
    ((Control) this.MgaButton1).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.MgaButton1).Location = new Point(886, 30);
    ((Control) this.MgaButton1).Name = "MgaButton1";
    ((Control) this.MgaButton1).Size = new Size(117, 24);
    ((Control) this.MgaButton1).TabIndex = 19;
    ((ControlBase) this.MgaButton1).Text = "Export Register";
    this.MgaButton1.UseOSThemes = (DefaultableBoolean) 2;
    this.comboYear.BorderStyle = (UIElementBorderStyle) 4;
    this.comboYear.DisplayStyle = (EmbeddableElementDisplayStyle) 6;
    this.comboYear.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboYear).Location = new Point(9, 69);
    this.comboYear.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboYear).Name = "comboYear";
    ((Control) this.comboYear).Size = new Size(73, 21);
    ((Control) this.comboYear).TabIndex = 17;
    ((UltraControlBase) this.comboYear).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboYear).UseOsThemes = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.FromArgb(239, 247, 253);
    ((ControlBase) this.UltraLabel2).Appearance = (AppearanceBase) appearance25;
    ((AutoSizeControlBase) this.UltraLabel2).AutoSize = true;
    ((Control) this.UltraLabel2).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((Control) this.UltraLabel2).Location = new Point(9, 52);
    ((Control) this.UltraLabel2).Name = "UltraLabel2";
    ((Control) this.UltraLabel2).Size = new Size(35, 15);
    ((Control) this.UltraLabel2).TabIndex = 18;
    ((ControlBase) this.UltraLabel2).Text = "YEAR";
    this.comboMonth.BorderStyle = (UIElementBorderStyle) 4;
    this.comboMonth.DisplayStyle = (EmbeddableElementDisplayStyle) 6;
    this.comboMonth.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboMonth).Location = new Point(88, 69);
    this.comboMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboMonth).Name = "comboMonth";
    ((Control) this.comboMonth).Size = new Size(145, 21);
    ((Control) this.comboMonth).TabIndex = 15;
    ((UltraControlBase) this.comboMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboMonth).UseOsThemes = (DefaultableBoolean) 2;
    appearance26.BackColor = Color.FromArgb(239, 247, 253);
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance26;
    ((AutoSizeControlBase) this.UltraLabel1).AutoSize = true;
    ((Control) this.UltraLabel1).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((Control) this.UltraLabel1).Location = new Point(88, 52);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(47, 15);
    ((Control) this.UltraLabel1).TabIndex = 16 /*0x10*/;
    ((ControlBase) this.UltraLabel1).Text = "MONTH";
    this.lblBankName.BackColor = Color.Transparent;
    this.lblBankName.Dock = DockStyle.Top;
    this.lblBankName.Font = new Font("Tahoma", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblBankName.ForeColor = Color.LightSteelBlue;
    this.lblBankName.Location = new Point(6, 26);
    this.lblBankName.Name = "lblBankName";
    this.lblBankName.Size = new Size(996, 23);
    this.lblBankName.TabIndex = 10;
    this.lblBankName.Text = "Bank Name";
    this.checkShowVoids.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.checkShowVoids.BackColor = Color.Transparent;
    this.checkShowVoids.CheckAlign = ContentAlignment.MiddleRight;
    this.checkShowVoids.Checked = true;
    this.checkShowVoids.CheckState = CheckState.Checked;
    this.checkShowVoids.FlatStyle = FlatStyle.Flat;
    this.checkShowVoids.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.checkShowVoids.ForeColor = Color.DimGray;
    this.checkShowVoids.Location = new Point(920, 72);
    this.checkShowVoids.Name = "checkShowVoids";
    this.checkShowVoids.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.checkShowVoids.TabIndex = 14;
    this.checkShowVoids.Text = "Show Voids";
    this.checkShowVoids.UseVisualStyleBackColor = false;
    appearance27.BackColor = Color.FromArgb(239, 247, 253);
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance27;
    this.MgaGroupBox2.ContentPadding.Bottom = 4;
    this.MgaGroupBox2.ContentPadding.Left = 4;
    this.MgaGroupBox2.ContentPadding.Right = 4;
    this.MgaGroupBox2.ContentPadding.Top = 4;
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.gridRegister);
    ((Control) this.MgaGroupBox2).Controls.Add((Control) this.panelCurtain);
    this.MgaGroupBox2.Dock = DockStyle.Fill;
    ((Control) this.MgaGroupBox2).Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    appearance28.AlphaLevel = (short) 230;
    appearance28.FontData.SizeInPoints = 10f;
    appearance28.ForeColor = Color.White;
    appearance28.ForegroundAlpha = (Alpha) 2;
    appearance28.ImageAlpha = (Alpha) 2;
    appearance28.ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.MgaGroupBox2.HeaderAppearance = (AppearanceBase) appearance28;
    ((Control) this.MgaGroupBox2).Location = new Point(0, 98);
    ((Control) this.MgaGroupBox2).Name = "MgaGroupBox2";
    ((Control) this.MgaGroupBox2).Size = new Size(1008, 694);
    ((Control) this.MgaGroupBox2).TabIndex = 30;
    this.MgaGroupBox2.Text = " Bank Register";
    this.MgaGroupBox2.ViewStyle = (GroupBoxViewStyle) 2;
    this.EllipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.EllipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.EllipsePanel1.Controls.Add((Control) this.labelRemoveSearchFilter);
    this.EllipsePanel1.CornerOffset = 1;
    this.EllipsePanel1.Dock = DockStyle.Bottom;
    this.EllipsePanel1.Location = new Point(0, 800);
    this.EllipsePanel1.Name = "EllipsePanel1";
    this.EllipsePanel1.Size = new Size(1008, 40);
    this.EllipsePanel1.TabIndex = 31 /*0x1F*/;
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(1008, 2);
    this.Panel1.TabIndex = 32 /*0x20*/;
    this.Panel2.Dock = DockStyle.Bottom;
    this.Panel2.Location = new Point(0, 840);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(1008, 8);
    this.Panel2.TabIndex = 33;
    this.Panel3.Dock = DockStyle.Bottom;
    this.Panel3.Location = new Point(0, 792);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(1008, 8);
    this.Panel3.TabIndex = 34;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._BankAccountRegister_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Left).Name = "_BankAccountRegister_Toolbars_Dock_Area_Left";
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Left).Size = new Size(0, 848);
    this._BankAccountRegister_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedPosition = (DockedPosition) 4;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(351, 352);
    ultraToolbar.FloatingSize = new Size(107, 46);
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "GridContext";
    ultraToolbar.Visible = false;
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "pmGridContext";
    ((ToolBase) popupMenuTool2).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolBase) buttonTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool4).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) popupMenuTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool7).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool8).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[11]
    {
      (ToolBase) buttonTool1,
      (ToolBase) popupMenuTool3,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) popupMenuTool4,
      (ToolBase) popupMenuTool5,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8
    });
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "New Deposit";
    ((ToolBase) buttonTool9).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "View Deposit Detail";
    ((ToolBase) buttonTool10).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Bank Fees Entry";
    ((ToolBase) buttonTool11).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "Bank Interest Income Entry";
    ((ToolBase) buttonTool12).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) popupMenuTool6).SharedPropsInternal).Caption = "Bank Transactions / Adjustments";
    ((ToolBase) popupMenuTool6).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolsCollectionBase) popupMenuTool6.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14
    });
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Delete Transaction";
    ((ToolBase) buttonTool15).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).Caption = "Bounced Check";
    ((ToolBase) buttonTool16).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "Un-Reconcile Transaction";
    ((ToolBase) buttonTool17).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).Caption = "Replace Voided Transaction";
    ((ToolBase) buttonTool18).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).Caption = "Void Transaction";
    ((ToolBase) buttonTool19).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).Caption = "Print Checks";
    ((ToolBase) buttonTool20).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) popupMenuTool7).SharedPropsInternal).Caption = "Reconciliation";
    ((ToolBase) popupMenuTool7).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolsCollectionBase) popupMenuTool7.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool21
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool8).SharedPropsInternal).Caption = "Deposit Options";
    ((ToolBase) popupMenuTool8).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolBase) buttonTool23).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool24).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool8.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool22,
      (ToolBase) buttonTool23,
      (ToolBase) buttonTool24,
      (ToolBase) buttonTool25
    });
    ((ToolPropsBase) ((ToolBase) buttonTool26).SharedPropsInternal).Caption = "New Cash Receipt";
    ((ToolBase) buttonTool26).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool27).SharedPropsInternal).Caption = "Print Wire Transfer Facsimile";
    ((ToolBase) buttonTool27).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).Caption = "Un-Group Deposit";
    ((ToolBase) buttonTool28).SharedPropsInternal.Category = "GridContextMenu";
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).Caption = "View Transaction Detail";
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).Caption = "Print Transaction Detail";
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[19]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) popupMenuTool6,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) popupMenuTool7,
      (ToolBase) popupMenuTool8,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27,
      (ToolBase) buttonTool28,
      (ToolBase) buttonTool29,
      (ToolBase) buttonTool30
    });
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._BankAccountRegister_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Right).Location = new Point(1008, 0);
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Right).Name = "_BankAccountRegister_Toolbars_Dock_Area_Right";
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Right).Size = new Size(0, 848);
    this._BankAccountRegister_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._BankAccountRegister_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Top).Name = "_BankAccountRegister_Toolbars_Dock_Area_Top";
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Top).Size = new Size(1008, 0);
    this._BankAccountRegister_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._BankAccountRegister_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Bottom).Location = new Point(0, 848);
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Bottom).Name = "_BankAccountRegister_Toolbars_Dock_Area_Bottom";
    ((Control) this._BankAccountRegister_Toolbars_Dock_Area_Bottom).Size = new Size(1008, 0);
    this._BankAccountRegister_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.Controls.Add((Control) this.MgaGroupBox2);
    this.Controls.Add((Control) this.Panel3);
    this.Controls.Add((Control) this.EllipsePanel1);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this._BankAccountRegister_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._BankAccountRegister_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._BankAccountRegister_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._BankAccountRegister_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (BankAccountRegister);
    this.Size = new Size(1008, 848);
    ((ISupportInitialize) this.gridRegister).EndInit();
    this.DsBankAccountRegister1.EndInit();
    this.panelCurtain.ResumeLayout(false);
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.MgaButton1).EndInit();
    ((ISupportInitialize) this.comboYear).EndInit();
    ((ISupportInitialize) this.comboMonth).EndInit();
    ((ISupportInitialize) this.MgaGroupBox2).EndInit();
    ((Control) this.MgaGroupBox2).ResumeLayout(false);
    this.EllipsePanel1.ResumeLayout(false);
    this.EllipsePanel1.PerformLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  public int BankGLAccountId
  {
    get => this._bankaccountgl;
    set => this._bankaccountgl = value;
  }

  public string BankName => this.lblBankName.Text;

  public int SelectedTransactionNumber
  {
    get
    {
      return this.gridRegister.Selected.Rows.Count != 0 ? (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.gridRegister.Selected.Rows[0].Cells["trxtype"].Value.ToString(), "P", false) != 0 ? -1 : Conversions.ToInteger(this.gridRegister.Selected.Rows[0].Cells["transactnum"].Value)) : -1;
    }
  }

  public DateTime SelectedTransactionDate
  {
    get
    {
      return this.gridRegister.Selected.Rows.Count != 0 ? Conversions.ToDate(this.gridRegister.Selected.Rows[0].Cells["transactionDate"].Value) : DateTime.MinValue;
    }
  }

  public string SelectedTransactionPayeeName
  {
    get
    {
      return this.gridRegister.Selected.Rows.Count != 0 ? this.gridRegister.Selected.Rows[0].Cells["description"].Value.ToString() : string.Empty;
    }
  }

  public string SelectedTransactionCheckOrRefNumber
  {
    get
    {
      return this.gridRegister.Selected.Rows.Count != 0 ? this.gridRegister.Selected.Rows[0].Cells["checkorref"].Value.ToString() : string.Empty;
    }
  }

  public bool SelectedTransactionIsCheck
  {
    get
    {
      return this.gridRegister.Selected.Rows.Count != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.gridRegister.Selected.Rows[0].Cells["trxtype"].Value.ToString(), "P", false) == 0;
    }
  }

  public bool SelectedTransactionMethodIsCheck
  {
    get
    {
      return this.gridRegister.Selected.Rows.Count != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.gridRegister.Selected.Rows[0].Cells["method"].Value.ToString(), "C", false) == 0;
    }
  }

  private void BankAccountRegister_Load(object sender, EventArgs e) => this.Dock = DockStyle.Fill;

  public void Initialize()
  {
    this.LoadRegister();
    this.GetBankName();
  }

  internal UltraGridRow CurrentSelectedRow => this.gridRegister.Selected.Rows[0];

  private void LoadRegister()
  {
    this.panelCurtain.Visible = true;
    this.panelCurtain.BringToFront();
    this.registerDataSet = new dsBankAccountRegister();
    this.LoadThread = new Thread(new ThreadStart(this.DoLoadRegister));
    this.LoadThread.Start();
  }

  private void DoLoadRegister()
  {
    lock ((object) this)
    {
      dsBankAccountRegister bankAccountRegister = new dsBankAccountRegister();
      SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
      SqlCommand selectCommand = new SqlCommand(this.sprocBankAcctRegisterName, connection);
      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
      this._bal = BankingServices.GetBankStartingBalance(this._bankaccountgl);
      this.SetSelectedDateTime();
      try
      {
        selectCommand.CommandType = CommandType.StoredProcedure;
        selectCommand.CommandTimeout = 0;
        selectCommand.Parameters.AddWithValue("@bankglacct", (object) this._bankaccountgl);
        selectCommand.Parameters.AddWithValue("@date", (object) this._currentdate);
        sqlDataAdapter.Fill((DataTable) bankAccountRegister.Register);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        Exception exception = ex;
        if (!this.IsDisposed && !this.Disposing)
          this.Invoke((Delegate) new BankAccountRegister.ThreadExceptionHandler(this.ThreadException), (object) exception);
        ProjectData.ClearProjectError();
      }
      finally
      {
        if (connection != null)
        {
          if (connection.State != ConnectionState.Closed)
            connection.Close();
          connection.Dispose();
        }
        selectCommand?.Dispose();
        sqlDataAdapter?.Dispose();
      }
      if (this.IsDisposed || this.Disposing)
        return;
      this.Invoke((Delegate) new BankAccountRegister.LoadRegisterCompleteHandler(this.LoadRegisterComplete), (object) bankAccountRegister);
    }
  }

  protected virtual void LoadRegisterComplete(dsBankAccountRegister ds)
  {
    ((UltraGridBase) this.gridRegister).DataSource = (object) ds;
    UltraGridBand band = ((UltraGridBase) this.gridRegister).DisplayLayout.Bands[0];
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("ReconciliationDate"))
      band.Columns["ReconciliationDate"].Hidden = true;
    if (SystemSettings.GetBoolSetting("BankRegisterShowTransactNum"))
    {
      try
      {
        foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.gridRegister).Rows.GetRowEnumerator((GridRowType) 1, band, (UltraGridBand) null))
          ultraGridRow.Cells["TransactNumDisplay"].Value = !(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ultraGridRow.Cells["Method"].Value.ToString().ToUpper(), "D", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ultraGridRow.Cells["Method"].Value.ToString().ToUpper(), "Z", false) != 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(ultraGridRow.Cells["Method"].Value.ToString(), " ", false) != 0) ? (object) string.Empty : RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["transactNum"].Value);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    else
      band.Columns["TransactNumDisplay"].Hidden = true;
    this.panelCurtain.Visible = false;
  }

  private void ThreadException(Exception ex) => throw ex;

  private void LoadBankRegisterChecks(dsBankAccountRegister dsRegister)
  {
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spFin_GetBankAccountRegister_Checks", connection);
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataSet dataSet = new DataSet();
    this._bal = BankingServices.GetBankStartingBalance(this._bankaccountgl);
    try
    {
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@bankglacct", (object) this._bankaccountgl);
      selectCommand.CommandTimeout = 0;
      sqlDataAdapter.Fill(dataSet);
      dsRegister.Merge(dataSet.Tables[0]);
    }
    finally
    {
      if (connection != null)
      {
        if (connection.State != ConnectionState.Closed)
          connection.Close();
        connection.Dispose();
      }
      selectCommand?.Dispose();
      sqlDataAdapter?.Dispose();
    }
  }

  internal void ReloadRegister() => this.LoadRegister();

  private void GetBankName()
  {
    this.lblBankName.Text = Database.Instance.QueryText.PerformScalarQueryString($"select dbo.GetBankName({this._bankaccountgl})");
  }

  private void gridRegister_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    Decimal.Compare(this._bal, 0M);
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(e.Row.Cells["debit"].Value)))
    {
      // ISSUE: variable of a reference type
      Decimal& local;
      // ISSUE: explicit reference operation
      Decimal num = Decimal.Add(^(local = ref this._bal), Conversions.ToDecimal(e.Row.Cells["debit"].Value));
      local = num;
    }
    if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(e.Row.Cells["credit"].Value)))
    {
      // ISSUE: variable of a reference type
      Decimal& local;
      // ISSUE: explicit reference operation
      Decimal num = Decimal.Add(^(local = ref this._bal), Conversions.ToDecimal(e.Row.Cells["credit"].Value));
      local = num;
    }
    e.Row.Cells["balance"].Value = (object) this._bal;
    if (Decimal.Compare(Conversions.ToDecimal(e.Row.Cells["balance"].Value), 0M) < 0)
      e.Row.Cells["balance"].Appearance.ForeColor = Color.Red;
    if (e.Row.Cells["IsVoided"].Value.ToString().Equals("True"))
    {
      e.Row.Appearance.ImageBackground = Image.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("MGASystems.IMS.Accounting.Banking.Voided.png"));
      e.Row.Appearance.ImageBackgroundAlpha = (Alpha) 0;
      e.Row.Appearance.ImageBackgroundStyle = (ImageBackgroundStyle) 1;
      e.Row.Appearance.ImageBackgroundOrigin = (ImageBackgroundOrigin) 0;
      e.Row.Appearance.ForeColor = Color.Red;
      e.Row.Appearance.AlphaLevel = (short) 75;
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Row.Cells["status"].Value.ToString(), "R", false) == 0)
    {
      UltraGridCell cell = e.Row.Cells["status"];
      cell.Appearance.FontData.Bold = (DefaultableBoolean) 1;
      cell.Appearance.ForeColor = Color.Blue;
      cell.ToolTipText = !((KeyedSubObjectsCollectionBase) e.Row.Band.Columns).Exists("ReconciliationDate") ? "This transaction has been reconciled." : $"This transaction has been reconciled on {Conversions.ToDate(e.Row.Cells["reconciliationdate"].Value).ToShortDateString()}.";
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Row.Cells["HasBouncedChecks"].Value.ToString(), "*", false) == 0)
    {
      UltraGridCell cell = e.Row.Cells["HasBouncedChecks"];
      cell.Appearance.FontData.Bold = (DefaultableBoolean) 1;
      cell.Appearance.ForeColor = Color.Blue;
      cell.ToolTipText = "This cash receipt has checks that have been marked as bounced.";
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.Row.Cells["HasVoidedTransactions"].Value.ToString(), "*", false) != 0)
      return;
    e.Row.Cells["Debit"].Appearance.FontData.Bold = (DefaultableBoolean) 1;
    e.Row.Cells["HasVoidedTransactions"].ToolTipText = "This bank deposit has voided cash receipts grouped within it. A replacement transaction should be associated with this deposit.";
  }

  internal void NewDeposit()
  {
    frmBankDeposit frmBankDeposit = new frmBankDeposit();
    try
    {
      int num = (int) frmBankDeposit.ShowDialog();
    }
    finally
    {
      frmBankDeposit.Dispose();
    }
    this.LoadRegister();
  }

  internal void ViewDeposit()
  {
    if (!SecurityManager.Instance.AssertPermission("{F0B7BA7B-AB2D-4ac8-A7AE-DC57991D3E3B}"))
      Utility.DenyAccess();
    else if (this.gridRegister.Selected.Rows.Count == 0)
    {
      int num1 = (int) MessageBox.Show("You must select deposit transaction to view.", "No Transaction Specified!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      UltraGridRow row = this.gridRegister.Selected.Rows[0];
      if (row == null)
        return;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.Cells["trxtype"].Value.ToString(), "D", false) != 0)
      {
        int num2 = (int) MessageBox.Show("You must select a deposit transaction.", "Must Select A Deposit!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
        Utility.PrintDepositTicket(Conversions.ToInteger(row.Cells["transactnum"].Value));
    }
  }

  internal void BankFeesEntry()
  {
    frmBankAdjustments frmBankAdjustments = new frmBankAdjustments(BankingServices.GetBankGLCompanyID(this._bankaccountgl), BankingServices.GetBankName(this._bankaccountgl), BankingServices.GetBankAccountNumber(this._bankaccountgl), this._bankaccountgl, BankingTransactionType.BankFees);
    try
    {
      if (frmBankAdjustments.ShowDialog() != DialogResult.OK)
        return;
      this.LoadRegister();
    }
    finally
    {
      frmBankAdjustments.Dispose();
    }
  }

  internal void BankInterestEntry()
  {
    frmBankAdjustments frmBankAdjustments = new frmBankAdjustments(BankingServices.GetBankGLCompanyID(this._bankaccountgl), BankingServices.GetBankName(this._bankaccountgl), BankingServices.GetBankAccountNumber(this._bankaccountgl), this._bankaccountgl, BankingTransactionType.BankInterest);
    try
    {
      if (frmBankAdjustments.ShowDialog() != DialogResult.OK)
        return;
      this.LoadRegister();
    }
    finally
    {
      frmBankAdjustments.Dispose();
    }
  }

  internal void ReconcileSelectedTransaction()
  {
    if (this.gridRegister.Selected.Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("You must select a transaction to reconcile.", "No Transaction Specified!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      UltraGridRow row = this.gridRegister.Selected.Rows[0];
      if (row == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.Cells["status"].Value.ToString(), "R", false) == 0)
        return;
      if (MessageBox.Show("Reconciling the specified transaction will disallow any further modifications to the transaction. Users will no longer have the ability to void, edit or modify the transaction. Do you wish to continue?", "Reconcile Transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.ReconcileTransaction(row);
        this.LoadRegister();
      }
    }
  }

  internal void PrintChecks()
  {
    if (!SecurityManager.Instance.AssertPermission("{879830FE-04FA-4a48-9FE6-0626CF095A85}"))
    {
      Utility.DenyAccess();
    }
    else
    {
      try
      {
        this.Cursor = Cursors.WaitCursor;
        dsCheckPrinterSettings checkPrinterDataset = new dsCheckPrinterSettings();
        DefaultDatabase.LoadDataSet((DataSet) checkPrinterDataset, new string[1]
        {
          "PrinterSettings"
        }, "spFin_GetCheckPrinterSettings");
        if (checkPrinterDataset.PrinterSettings.Rows.Count == 1)
        {
          dsCheckPrinterSettings.PrinterSettingsRow printerSetting = checkPrinterDataset.PrinterSettings[0];
          frmPrintChecks form = ObjectFactory.Instance.CreateForm(typeof (frmPrintChecks), new object[5]
          {
            (object) this._bankaccountgl,
            (object) printerSetting.CheckPrinterName,
            (object) printerSetting.CheckPrinterSettings,
            (object) (string) Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printerSetting.CheckDetailName, string.Empty, false) == 0, (object) printerSetting.CheckPrinterName, (object) printerSetting.CheckDetailName),
            (object) (string) Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(printerSetting.CheckDetailName, string.Empty, false) == 0, (object) printerSetting.CheckPrinterSettings, (object) printerSetting.CheckDetailSettings)
          }) as frmPrintChecks;
          form.MdiParent = MDIControls.Instance.MDIParent;
          form.Show();
        }
        else
        {
          object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("GetPreference", new object[4]
          {
            (object) "@PreferenceName",
            (object) "Accounting.CheckPrinter",
            (object) "@UserGuid",
            (object) CurrentUser.Instance.UserGUID.ToString()
          }));
          if (objectValue == null)
          {
            using (formSelectCheckPrinter selectCheckPrinter = new formSelectCheckPrinter(ref checkPrinterDataset))
            {
              if (selectCheckPrinter.ShowDialog() != DialogResult.OK)
                return;
              frmPrintChecks form = ObjectFactory.Instance.CreateForm(typeof (frmPrintChecks), new object[5]
              {
                (object) this._bankaccountgl,
                (object) selectCheckPrinter.CheckPrinterName,
                (object) selectCheckPrinter.CheckPrinterSettings,
                (object) selectCheckPrinter.CheckDetailPrinterName,
                (object) selectCheckPrinter.CheckDetailPrinterSettings
              }) as frmPrintChecks;
              form.MdiParent = MDIControls.Instance.MDIParent;
              form.Show();
            }
          }
          else
          {
            bool flag = false;
            try
            {
              foreach (dsCheckPrinterSettings.PrinterSettingsRow printerSetting in (TypedTableBase<dsCheckPrinterSettings.PrinterSettingsRow>) checkPrinterDataset.PrinterSettings)
              {
                if (printerSetting.PrinterId == int.Parse(objectValue.ToString()))
                {
                  flag = true;
                  frmPrintChecks form = ObjectFactory.Instance.CreateForm(typeof (frmPrintChecks), new object[5]
                  {
                    (object) this._bankaccountgl,
                    (object) printerSetting.CheckPrinterName,
                    (object) printerSetting.CheckPrinterSettings,
                    (object) printerSetting.CheckDetailName,
                    (object) printerSetting.CheckDetailSettings
                  }) as frmPrintChecks;
                  form.MdiParent = MDIControls.Instance.MDIParent;
                  form.Show();
                  break;
                }
              }
            }
            finally
            {
              IEnumerator<dsCheckPrinterSettings.PrinterSettingsRow> enumerator;
              enumerator?.Dispose();
            }
            if (flag)
              return;
            using (formSelectCheckPrinter selectCheckPrinter = new formSelectCheckPrinter(ref checkPrinterDataset))
            {
              if (selectCheckPrinter.ShowDialog() != DialogResult.OK)
                return;
              frmPrintChecks form = ObjectFactory.Instance.CreateForm(typeof (frmPrintChecks), new object[5]
              {
                (object) this._bankaccountgl,
                (object) selectCheckPrinter.CheckPrinterName,
                (object) selectCheckPrinter.CheckPrinterSettings,
                (object) selectCheckPrinter.CheckDetailPrinterName,
                (object) selectCheckPrinter.CheckDetailPrinterSettings
              }) as frmPrintChecks;
              form.MdiParent = MDIControls.Instance.MDIParent;
              form.Show();
            }
          }
        }
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
  }

  private void PrintWireTransferFacsimile()
  {
    if (this.gridRegister.Selected.Rows[0] == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.gridRegister.Selected.Rows[0].Cells["method"].Value.ToString(), "M", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.gridRegister.Selected.Rows[0].Cells["trxtype"].Value.ToString(), "P", false) != 0)
      return;
    rptCustomerRemittance rpt = new rptCustomerRemittance(Conversions.ToInteger(this.gridRegister.Selected.Rows[0].Cells["TransactNum"].Value));
    rpt.Run();
    ReportFactory.Instance.ShowReport((SectionReport) rpt, true);
    rpt.Dispose();
  }

  internal void NewCashReceipt()
  {
    if (!SecurityManager.Instance.AssertPermission("{EE3AFC8D-71C9-4594-95CB-19889DF74C98}"))
    {
      Utility.DenyAccess();
    }
    else
    {
      frmCashReceipt frmCashReceipt = new frmCashReceipt(this._bankaccountgl, BankingServices.GetBankGLCompanyID(this._bankaccountgl));
      try
      {
        if (frmCashReceipt.ShowDialog() != DialogResult.OK)
          return;
        this.LoadRegister();
      }
      finally
      {
        frmCashReceipt.Dispose();
      }
    }
  }

  internal void IssueCheck()
  {
    Form form = ObjectFactory.Instance.CreateForm(typeof (frmCreateCheckWizard));
    try
    {
      int num = (int) form.ShowDialog();
    }
    finally
    {
      form.Dispose();
    }
    this.LoadRegister();
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(key))
    {
      case 108490041:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "NewDeposit", false) != 0)
          break;
        this.NewDeposit();
        break;
      case 314611965:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "ReplaceVoid", false) != 0 || this.gridRegister.Selected.Rows[0] == null)
          break;
        frmReplaceDepositVoid replaceDepositVoid = new frmReplaceDepositVoid(Conversions.ToInteger(this.gridRegister.Selected.Rows[0].Cells["transactnum"].Value), this._bankaccountgl, BankingServices.GetBankGLCompanyID(this._bankaccountgl));
        try
        {
          int num = (int) replaceDepositVoid.ShowDialog();
        }
        finally
        {
          replaceDepositVoid.Dispose();
        }
        this.LoadRegister();
        break;
      case 355989241:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "PrintChecks", false) != 0)
          break;
        this.PrintChecks();
        break;
      case 420276262:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "UnReconcile", false) != 0)
          break;
        if (!SecurityManager.Instance.AssertPermission("{724FE13B-6F3C-4c8b-B6B4-B41BBF157C55}"))
        {
          Utility.DenyAccess();
          break;
        }
        try
        {
          BankingServices.UnReconcileTransaction(int.Parse(this.gridRegister.Selected.Rows[0].Cells["transactnum"].Value.ToString()), this.gridRegister.Selected.Rows[0].Cells["trxType"].Value.ToString(), this._bankaccountgl);
          CurrentUser.Instance.LogAction($"User unreconciled transaction # {this.gridRegister.Selected.Rows[0].Cells["transactnum"].Value.ToString()}", "Banking Logs");
          this.ReloadRegister();
          break;
        }
        catch (SqlException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          throw ex;
        }
      case 1160211309:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "BouncedCheck", false) != 0)
          break;
        if (!SecurityManager.Instance.AssertPermission("{17ADC292-7269-4a90-AF7A-7B0200571153}"))
        {
          Utility.DenyAccess();
          break;
        }
        if (this.gridRegister.Selected.Rows[0] == null)
          break;
        UltraGridRow row = this.gridRegister.Selected.Rows[0];
        frmBouncedCheck form = (frmBouncedCheck) ObjectFactory.Instance.CreateForm(typeof (frmBouncedCheck), new object[5]
        {
          (object) Conversions.ToInteger(row.Cells["transactnum"].Value),
          (object) BankingServices.GetBankName(this._bankaccountgl),
          (object) Conversions.ToDate(row.Cells["transactionDate"].Value),
          (object) BankingServices.GetBankAccountNumber(this._bankaccountgl),
          (object) Conversions.ToString(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.Cells["status"].Value.ToString(), "R", false) == 0, (object) "Reconciled", (object) "Open (Not Reconciled)"))
        });
        try
        {
          int num = (int) form.ShowDialog();
        }
        finally
        {
          form.Dispose();
        }
        this.LoadRegister();
        break;
      case 1492913921:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "VoidTransaction", false) != 0)
          break;
        this.VoidDelete();
        break;
      case 1800720343:
        Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Reconcile", false);
        break;
      case 2020589967:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "PrintFacsimile", false) != 0)
          break;
        this.PrintWireTransferFacsimile();
        break;
      case 2419255602:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "BankFees", false) != 0)
          break;
        this.BankFeesEntry();
        break;
      case 2676189306:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "CashReceipt", false) != 0)
          break;
        this.NewCashReceipt();
        break;
      case 2806740781:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "UnGroupDeposit", false) != 0)
          break;
        this.UngroupDeposit();
        break;
      case 2906180569:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "ViewDetail", false) != 0 || ((UltraGridBase) this.gridRegister).Rows.Count == 0 || this.gridRegister.Selected.Rows.Count == 0 || this.gridRegister.Selected.Rows[0] == null)
          break;
        ObjectFactory.Instance.CreateForm(typeof (formTransactionViewer), new object[2]
        {
          (object) Conversions.ToInteger(this.gridRegister.Selected.Rows[0].Cells["transactnum"].Value),
          (object) this._glCompany
        }).Show();
        break;
      case 3314270937:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "BankInterest", false) != 0)
          break;
        this.BankInterestEntry();
        break;
      case 4008688239:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "ViewDepositDetail", false) != 0)
          break;
        this.ViewDeposit();
        break;
      case 4021053566:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "PrintTrx", false) != 0 || ((UltraGridBase) this.gridRegister).Rows.Count == 0 || this.gridRegister.Selected.Rows.Count == 0 || this.gridRegister.Selected.Rows[0] == null)
          break;
        ReportFactory.Instance.ShowReport(false, typeof (rptJournalTransaction), (object) Conversions.ToInteger(this.gridRegister.Selected.Rows[0].Cells["transactnum"].Value));
        break;
      case 4291354614:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "DeleteTransaction", false) != 0)
          break;
        this.VoidDelete();
        break;
    }
  }

  private void picAddStartingBalance_Click(object sender, EventArgs e)
  {
    frmBankStartingBalance bankStartingBalance = new frmBankStartingBalance(BankingServices.GetBankName(this._bankaccountgl), BankingServices.GetBankAccountNumber(this._bankaccountgl), this._bankaccountgl);
    try
    {
      int num = (int) bankStartingBalance.ShowDialog();
    }
    finally
    {
      bankStartingBalance.Dispose();
    }
    this.LoadRegister();
  }

  private void UltraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    if (((UltraGridBase) this.gridRegister).DisplayLayout.UIElement == null || ((ControlUIElementBase) ((UltraGridBase) this.gridRegister).DisplayLayout.UIElement).LastElementEntered == null)
      return;
    UltraGridRow context = (UltraGridRow) ((ControlUIElementBase) ((UltraGridBase) this.gridRegister).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow));
    this.currentContextRow = context;
    if (context == null)
    {
      ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DepositOptions"].SharedProps.Visible = false;
    }
    else
    {
      ((UltraGridBase) this.gridRegister).ActiveRow = context;
      this.gridRegister.Selected.Rows.Clear();
      ((UltraGridBase) this.gridRegister).ActiveRow.Selected = true;
      if (context.Cells["isVoided"].Value.ToString().Equals("True") || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "V", false) == 0)
      {
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["Reconciliation"].SharedProps.Visible = Conversions.ToBoolean(context.Cells["IsReconciled"].Value) || context.Cells["Status"].Value.ToString().Equals("R");
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DepositOptions"]).Tools)["ViewDepositDetail"].SharedProps.Visible = false;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DepositOptions"]).Tools)["BouncedCheck"].SharedProps.Visible = false;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DepositOptions"]).Tools)["ReplaceVoid"].SharedProps.Visible = false;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DepositOptions"].SharedProps.Visible = false;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DeleteTransaction"].SharedProps.Visible = false;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["VoidTransaction"].SharedProps.Visible = false;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["PrintFacsimile"].SharedProps.Visible = false;
      }
      else
      {
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DepositOptions"]).Tools)["ViewDepositDetail"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "D", false) == 0;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DepositOptions"]).Tools)["BouncedCheck"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "D", false) == 0;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DepositOptions"]).Tools)["ReplaceVoid"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "D", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["HasVoidedTransactions"].Value.ToString(), "*", false) == 0;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DepositOptions"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "D", false) == 0;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["ViewDetail"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "D", false) != 0;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["PrintTrx"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "D", false) != 0;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["Reconciliation"].SharedProps.Visible = Conversions.ToBoolean(context.Cells["IsReconciled"].Value) || context.Cells["Status"].Value.ToString().Equals("R");
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["DeleteTransaction"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "D", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "P", false) != 0;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["VoidTransaction"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "P", false) == 0;
        ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["pmGridContext"]).Tools)["PrintFacsimile"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "P", false) == 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["method"].Value.ToString(), "M", false) == 0;
      }
    }
  }

  internal void ReconcileTransaction(UltraGridRow r)
  {
    string Left = r.Cells["trxType"].Value.ToString();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "D", false) != 0)
        return;
      BankingServices.ReconcileDeposit(Conversions.ToInteger(r.Cells["transactnum"].Value));
    }
    else
      BankingServices.ReconciledCheck(Conversions.ToInteger(r.Cells["transactnum"].Value));
  }

  private void VoidDelete()
  {
    if (!SecurityManager.Instance.AssertPermission("{1A4F865E-ABC2-47c1-A976-77B4348F33F3}"))
    {
      int num = (int) MessageBox.Show("You do not have rights to void this transaction.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show("This will permanently reverse the specified transaction. Are you sure you wish to continue?", "Reverse Transaction?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes || this.currentContextRow == null)
        return;
      formVoidTransaction form = (formVoidTransaction) ObjectFactory.Instance.CreateForm(typeof (formVoidTransaction), new object[1]
      {
        (object) Conversions.ToInteger(this.currentContextRow.Cells["transactnum"].Value)
      });
      try
      {
        if (form.ShowDialog() != DialogResult.OK)
          return;
        this.LoadRegister();
      }
      finally
      {
        form.Dispose();
      }
    }
  }

  private void UngroupDeposit()
  {
    if (MessageBox.Show("This action can not be undone, continue?", "Un-Group Deposit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    if (this.gridRegister.Selected.Rows.Count == 0)
    {
      int num1 = (int) MessageBox.Show("You must select deposit transaction to ungroup.", "No Transaction Specified!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      UltraGridRow row = this.gridRegister.Selected.Rows[0];
      if (row == null)
        return;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(row.Cells["trxtype"].Value.ToString(), "D", false) != 0)
      {
        int num2 = (int) MessageBox.Show("You must select a deposit transaction.", "Must Select A Deposit!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        BankingServices.UnGroupDeposit(Conversions.ToInteger(row.Cells["transactnum"].Value));
        CurrentUser.Instance.LogAction($"User ungrouped deposit # {row.Cells["transactnum"].Value.ToString()}", "Banking Logs");
        this.LoadRegister();
      }
    }
  }

  public void DisplayRemoveSearchFilter() => this.labelRemoveSearchFilter.Visible = true;

  private void labelRemoveSearchFilter_Click(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridRegister).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    ((UltraGridBase) this.gridRegister).DisplayLayout.RowScrollRegions[0].ScrollRowIntoView(((UltraGridBase) this.gridRegister).Rows[0]);
    this.labelRemoveSearchFilter.Visible = false;
  }

  private void checkShowVoids_CheckedChanged(object sender, EventArgs e)
  {
    if (this.checkShowVoids.Checked)
    {
      ((UltraGridBase) this.gridRegister).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    }
    else
    {
      ((UltraGridBase) this.gridRegister).DisplayLayout.Bands[0].ColumnFilters["IsVoided"].FilterConditions.Add((FilterComparisionOperator) 1, (object) 1);
      ((UltraGridBase) this.gridRegister).DisplayLayout.Bands[0].ColumnFilters["TrxType"].FilterConditions.Add((FilterComparisionOperator) 1, (object) "V");
    }
  }

  private void LoadMonthsCombo()
  {
    DataSet dataSet = new DataSet();
    DataTable table = new DataTable();
    table.Columns.AddRange(new DataColumn[2]
    {
      new DataColumn("MonthInteger", typeof (int)),
      new DataColumn("Month", typeof (string))
    });
    table.Rows.Add((object) 1, (object) "January");
    table.Rows.Add((object) 2, (object) "February");
    table.Rows.Add((object) 3, (object) "March");
    table.Rows.Add((object) 4, (object) "April");
    table.Rows.Add((object) 5, (object) "May");
    table.Rows.Add((object) 6, (object) "June");
    table.Rows.Add((object) 7, (object) "July");
    table.Rows.Add((object) 8, (object) "August");
    table.Rows.Add((object) 9, (object) "September");
    table.Rows.Add((object) 10, (object) "October");
    table.Rows.Add((object) 11, (object) "November");
    table.Rows.Add((object) 12, (object) "December");
    dataSet.Tables.Add(table);
    ((UltraGridBase) this.comboMonth).DataSource = (object) dataSet.Tables[0];
    ((UltraDropDownBase) this.comboMonth).DisplayMember = "Month";
    ((UltraDropDownBase) this.comboMonth).ValueMember = "MonthInteger";
    this.comboMonth.RowSelected -= new RowSelectedEventHandler(this.ComboRowSelected);
    this.comboMonth.Value = (object) DateTime.Now.Month;
    this.comboMonth.RowSelected += new RowSelectedEventHandler(this.ComboRowSelected);
  }

  private void LoadYearCombo()
  {
    DataSet dataSet = new DataSet();
    DataTable table = new DataTable();
    table.Columns.AddRange(new DataColumn[2]
    {
      new DataColumn("YearInteger", typeof (int)),
      new DataColumn("Year", typeof (int))
    });
    int num1 = DateTime.Now.Year - 20;
    DateTime now;
    while (true)
    {
      int num2 = num1;
      now = DateTime.Now;
      int num3 = now.Year + 5;
      if (num2 < num3)
      {
        table.Rows.Add((object) num1, (object) num1);
        ++num1;
      }
      else
        break;
    }
    dataSet.Tables.Add(table);
    ((UltraGridBase) this.comboYear).DataSource = (object) dataSet.Tables[0];
    ((UltraDropDownBase) this.comboYear).DisplayMember = "Year";
    ((UltraDropDownBase) this.comboYear).ValueMember = "YearInteger";
    this.comboYear.RowSelected -= new RowSelectedEventHandler(this.ComboRowSelected);
    MGASimpleComboBox comboYear = this.comboYear;
    now = DateTime.Now;
    // ISSUE: variable of a boxed type
    __Boxed<int> year = (System.ValueType) now.Year;
    comboYear.Value = (object) year;
    this.comboYear.RowSelected += new RowSelectedEventHandler(this.ComboRowSelected);
  }

  private void ComboRowSelected(object sender, RowSelectedEventArgs e) => this.LoadRegister();

  private void SetSelectedDateTime()
  {
    this._currentdate = new DateTime(Conversions.ToInteger(this.comboYear.Value), Conversions.ToInteger(this.comboMonth.Value), 1);
  }

  protected virtual void MgaButton1_Click(object sender, EventArgs e)
  {
    using (SaveFileDialog saveFileDialog = new SaveFileDialog())
    {
      saveFileDialog.Filter = "Excel 97-2003 Workbook (*.xls)|*.xls|Excel Worksbook (*.xlsx)|*.xlsx";
      saveFileDialog.DefaultExt = "xls";
      if (saveFileDialog.ShowDialog() != DialogResult.OK)
        return;
      this.filePathName = saveFileDialog.FileName;
    }
    try
    {
      MGASystems.Tools.ExcelExport.ToExcel(this.GenerateExcelDataSet(), this.filePathName);
      Process.Start(this.filePathName);
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("The Excel file could not be saved. Please ensure the file is not open in Excel and locked.", "File Canot be Accessed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
  }

  private DataSet GenerateExcelDataSet()
  {
    DataSet excelDataSet = new DataSet();
    excelDataSet.Tables.Add(new DataTable()
    {
      Columns = {
        {
          "bankname",
          typeof (string)
        },
        {
          "registerdate",
          typeof (DateTime)
        }
      },
      Rows = {
        new object[2]
        {
          (object) this.lblBankName.Text,
          (object) this._currentdate
        }
      }
    });
    DataTable table = new DataTable();
    foreach (UltraGridColumn column in ((UltraGridBase) this.gridRegister).DisplayLayout.Bands[0].Columns)
    {
      if (!column.Hidden)
        table.Columns.Add(column.Key, column.DataType);
    }
    foreach (UltraGridRow row1 in ((UltraGridBase) this.gridRegister).Rows)
    {
      DataRow row2 = table.NewRow();
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) row2.Table.Columns)
          row2[column.ColumnName] = RuntimeHelpers.GetObjectValue(row1.Cells[column.ColumnName].Value);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      table.Rows.Add(row2);
    }
    excelDataSet.Tables.Add(table);
    return excelDataSet;
  }

  private void UltraGridExcelExporter1_ExportStarted(object sender, ExportStartedEventArgs e)
  {
    ((ExcelExportEventArgs) e).CurrentWorksheet.Rows[((ExcelExportEventArgs) e).CurrentRowIndex].Cells[((ExcelExportEventArgs) e).CurrentColumnIndex].Value = (object) this.lblBankName.Text;
    ExportStartedEventArgs startedEventArgs1;
    int num1 = ((ExcelExportEventArgs) (startedEventArgs1 = e)).CurrentRowIndex + 1;
    ((ExcelExportEventArgs) startedEventArgs1).CurrentRowIndex = num1;
    ((ExcelExportEventArgs) e).CurrentWorksheet.Rows[((ExcelExportEventArgs) e).CurrentRowIndex].Cells[((ExcelExportEventArgs) e).CurrentColumnIndex].Value = (object) this.comboMonth.Text;
    ((ExcelExportEventArgs) e).CurrentWorksheet.Rows[((ExcelExportEventArgs) e).CurrentRowIndex].Cells[((ExcelExportEventArgs) e).CurrentColumnIndex + 1].Value = (object) this.comboYear.Text;
    ExportStartedEventArgs startedEventArgs2;
    int num2 = ((ExcelExportEventArgs) (startedEventArgs2 = e)).CurrentRowIndex + 1;
    ((ExcelExportEventArgs) startedEventArgs2).CurrentRowIndex = num2;
  }

  private void UltraGridExcelExporter1_ExportEnded(object sender, ExportEndedEventArgs e)
  {
    Process.Start(new ProcessStartInfo(this.filePathName)
    {
      UseShellExecute = true
    });
  }

  private void UltraGridExcelExporter1_CellExported(object sender, CellExportedEventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(e.GridColumn.Key, "balance", false) != 0)
      return;
    ((ExcelExportEventArgs) e).CurrentWorksheet.Rows[((ExcelExportEventArgs) e).CurrentRowIndex].Cells[((ExcelExportEventArgs) e).CurrentColumnIndex].Value = RuntimeHelpers.GetObjectValue(e.GridRow.Cells["balance"].OriginalValue);
  }

  private void UltraGridExcelExporter1_InitializeColumn(object sender, InitializeColumnEventArgs e)
  {
    string lower = e.Column.Key.ToLower();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "balance", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "debit", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "credit", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(lower, "transactiondate", false) != 0)
        return;
      e.ExcelFormatStr = "mm/dd/yyy";
    }
    else
      e.ExcelFormatStr = "$#,##0.00;($#,##0.00);-";
  }

  private delegate void LoadRegisterCompleteHandler(dsBankAccountRegister ds);

  private delegate void ThreadExceptionHandler(Exception ex);
}
