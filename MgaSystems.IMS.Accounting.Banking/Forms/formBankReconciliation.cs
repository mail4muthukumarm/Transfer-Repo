// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.Forms.formBankReconciliation
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Reporting.Reports.Documents;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Accounting.SharedForms;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.Reporting;
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking.Forms;

[DocumentFolderFilter("Accounting-Bank Reconciliation")]
public class formBankReconciliation : FormBase, IRecreatableEntity
{
  internal int _bankGlAccountId;
  private DateTime _statementDate;
  private bool _hasSavedWorkSheet;
  private string filePathName;
  private DateTime _currentdate;
  private IContainer components;

  public formBankReconciliation()
  {
    this.Load += new EventHandler(this.formBankReconciliation_Load);
    this.FormClosing += new FormClosingEventHandler(this.formBankReconciliation_FormClosing);
    this._hasSavedWorkSheet = false;
    this._currentdate = DateTime.Now.Date;
    this.InitializeComponent();
  }

  public formBankReconciliation(int bankGlAccountID, string bankName)
  {
    this.Load += new EventHandler(this.formBankReconciliation_Load);
    this.FormClosing += new FormClosingEventHandler(this.formBankReconciliation_FormClosing);
    this._hasSavedWorkSheet = false;
    this._currentdate = DateTime.Now.Date;
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._bankGlAccountId = bankGlAccountID;
    this.Text = "Reconcile Bank Account - " + bankName;
  }

  public formBankReconciliation(
    int bankGlAccountID,
    string bankName,
    DateTime statementDate,
    Decimal startingBalance,
    Decimal endingBalance)
  {
    this.Load += new EventHandler(this.formBankReconciliation_Load);
    this.FormClosing += new FormClosingEventHandler(this.formBankReconciliation_FormClosing);
    this._hasSavedWorkSheet = false;
    this._currentdate = DateTime.Now.Date;
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this._bankGlAccountId = bankGlAccountID;
    this.Text = "Reconcile Bank Account - " + bankName;
    ((TextEditorControlBase) this.textStatementDate).Text = Strings.Format((object) statementDate, "Short Date");
    this._statementDate = statementDate;
    ((TextEditorControlBase) this.textEndingBalance).Text = endingBalance.ToString("c");
    ((TextEditorControlBase) this.textStartingBalance).Text = startingBalance.ToString("c");
    ((TextEditorControlBase) this.textDifference).Text = Decimal.Subtract(endingBalance, startingBalance).ToString("c");
  }

  protected virtual MGAButton btnRefresh
  {
    get => this._btnRefresh;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRefresh_Click);
      MGAButton btnRefresh1 = this._btnRefresh;
      if (btnRefresh1 != null)
        ((Control) btnRefresh1).Click -= eventHandler;
      this._btnRefresh = value;
      MGAButton btnRefresh2 = this._btnRefresh;
      if (btnRefresh2 == null)
        return;
      ((Control) btnRefresh2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("chkSave")]
  protected virtual UltraCheckEditor chkSave { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelCurtain")]
  protected virtual Label labelCurtain { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("depositTotal")]
  protected virtual MGATextBox depositTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("checkTotal")]
  protected virtual MGATextBox checkTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("voidTotal")]
  protected virtual MGATextBox voidTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("journalTotal")]
  protected virtual MGATextBox journalTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel7")]
  protected virtual UltraLabel UltraLabel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel9")]
  protected virtual UltraLabel UltraLabel9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel10")]
  protected virtual UltraLabel UltraLabel10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel11")]
  protected virtual UltraLabel UltraLabel11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("_formBankReconciliation_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _formBankReconciliation_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_formBankReconciliation_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _formBankReconciliation_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_formBankReconciliation_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _formBankReconciliation_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_formBankReconciliation_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _formBankReconciliation_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton MgaButton1
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

  protected int BankGL => this._bankGlAccountId;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("Panel1")]
  protected virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  protected virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  protected virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel1")]
  protected virtual UltraLabel UltraLabel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  protected virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid gridTransactions
  {
    get => this._gridTransactions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridTransactions_Click);
      CellEventHandler cellEventHandler = new CellEventHandler(this.gridTransactions_AfterCellUpdate);
      UltraGrid gridTransactions1 = this._gridTransactions;
      if (gridTransactions1 != null)
      {
        ((Control) gridTransactions1).Click -= eventHandler;
        gridTransactions1.AfterCellUpdate -= cellEventHandler;
      }
      this._gridTransactions = value;
      UltraGrid gridTransactions2 = this._gridTransactions;
      if (gridTransactions2 == null)
        return;
      ((Control) gridTransactions2).Click += eventHandler;
      gridTransactions2.AfterCellUpdate += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsBankReconciliation1")]
  protected virtual dsBankReconciliation DsBankReconciliation1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daBankReconciliation")]
  protected virtual SqlDataAdapter daBankReconciliation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("FormDataConnection")]
  protected virtual SqlConnection FormDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton buttonReconcile
  {
    get => this._buttonReconcile;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonReconcile_Click);
      MGAButton buttonReconcile1 = this._buttonReconcile;
      if (buttonReconcile1 != null)
        ((Control) buttonReconcile1).Click -= eventHandler;
      this._buttonReconcile = value;
      MGAButton buttonReconcile2 = this._buttonReconcile;
      if (buttonReconcile2 == null)
        return;
      ((Control) buttonReconcile2).Click += eventHandler;
    }
  }

  protected virtual MGAButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancel_Click);
      MGAButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      MGAButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  protected virtual MGAButton buttonUnSelectAll
  {
    get => this._buttonUnSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonUnSelectAll_Click);
      MGAButton buttonUnSelectAll1 = this._buttonUnSelectAll;
      if (buttonUnSelectAll1 != null)
        ((Control) buttonUnSelectAll1).Click -= eventHandler;
      this._buttonUnSelectAll = value;
      MGAButton buttonUnSelectAll2 = this._buttonUnSelectAll;
      if (buttonUnSelectAll2 == null)
        return;
      ((Control) buttonUnSelectAll2).Click += eventHandler;
    }
  }

  protected virtual MGAButton buttonSelectAll
  {
    get => this._buttonSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSelectAll_Click);
      MGAButton buttonSelectAll1 = this._buttonSelectAll;
      if (buttonSelectAll1 != null)
        ((Control) buttonSelectAll1).Click -= eventHandler;
      this._buttonSelectAll = value;
      MGAButton buttonSelectAll2 = this._buttonSelectAll;
      if (buttonSelectAll2 == null)
        return;
      ((Control) buttonSelectAll2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ultraLabel4")]
  protected virtual UltraLabel ultraLabel4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ultraLabel8")]
  protected virtual UltraLabel ultraLabel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel2")]
  protected virtual UltraLabel UltraLabel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel3")]
  protected virtual UltraLabel UltraLabel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel5")]
  protected virtual UltraLabel UltraLabel5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraLabel6")]
  protected virtual UltraLabel UltraLabel6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textStartingBalance")]
  protected virtual MGATextBox textStartingBalance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textEndingBalance")]
  protected virtual MGATextBox textEndingBalance { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textDifference")]
  protected virtual MGATextBox textDifference { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textStatementDate")]
  protected virtual MGATextBox textStatementDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton buttonEditEndingBalance
  {
    get => this._buttonEditEndingBalance;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonEditEndingBalance_Click);
      MGAButton editEndingBalance1 = this._buttonEditEndingBalance;
      if (editEndingBalance1 != null)
        ((Control) editEndingBalance1).Click -= eventHandler;
      this._buttonEditEndingBalance = value;
      MGAButton editEndingBalance2 = this._buttonEditEndingBalance;
      if (editEndingBalance2 == null)
        return;
      ((Control) editEndingBalance2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  protected virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand1")]
  protected virtual SqlCommand SqlUpdateCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("BankRegister", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Select");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("TransactNum");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("TransactionDate");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CheckOrRef");
    Appearance appearance10 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Method", -1, (object) null, 0, (SortIndicator) 2, false);
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Description");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Debit");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Credit");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("TrxType");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("BankAcctID");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
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
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("gridContext");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("gridContext");
    ButtonTool buttonTool1 = new ButtonTool("VIEW");
    ButtonTool buttonTool2 = new ButtonTool("PRINT");
    ButtonTool buttonTool3 = new ButtonTool("VIEW");
    Appearance appearance43 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formBankReconciliation));
    ButtonTool buttonTool4 = new ButtonTool("PRINT");
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    this.Panel1 = new Panel();
    this.chkSave = new UltraCheckEditor();
    this.btnRefresh = new MGAButton();
    this.buttonEditEndingBalance = new MGAButton();
    this.buttonSelectAll = new MGAButton();
    this.buttonUnSelectAll = new MGAButton();
    this.buttonReconcile = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.Panel2 = new Panel();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.UltraLabel1 = new UltraLabel();
    this.gridTransactions = new UltraGrid();
    this.DsBankReconciliation1 = new dsBankReconciliation();
    this.daBankReconciliation = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.SqlUpdateCommand1 = new SqlCommand();
    this.ultraLabel4 = new UltraLabel();
    this.ultraLabel8 = new UltraLabel();
    this.textStartingBalance = new MGATextBox();
    this.UltraLabel2 = new UltraLabel();
    this.textEndingBalance = new MGATextBox();
    this.UltraLabel3 = new UltraLabel();
    this.UltraLabel5 = new UltraLabel();
    this.textDifference = new MGATextBox();
    this.UltraLabel6 = new UltraLabel();
    this.textStatementDate = new MGATextBox();
    this.labelCurtain = new Label();
    this.depositTotal = new MGATextBox();
    this.checkTotal = new MGATextBox();
    this.voidTotal = new MGATextBox();
    this.journalTotal = new MGATextBox();
    this.UltraLabel7 = new UltraLabel();
    this.UltraLabel9 = new UltraLabel();
    this.UltraLabel10 = new UltraLabel();
    this.UltraLabel11 = new UltraLabel();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formBankReconciliation_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formBankReconciliation_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formBankReconciliation_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formBankReconciliation_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.MgaButton1 = new MGAButton();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.chkSave).BeginInit();
    ((ISupportInitialize) this.btnRefresh).BeginInit();
    ((ISupportInitialize) this.buttonEditEndingBalance).BeginInit();
    ((ISupportInitialize) this.buttonSelectAll).BeginInit();
    ((ISupportInitialize) this.buttonUnSelectAll).BeginInit();
    ((ISupportInitialize) this.buttonReconcile).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.Panel2.SuspendLayout();
    ((ISupportInitialize) this.gridTransactions).BeginInit();
    this.DsBankReconciliation1.BeginInit();
    ((ISupportInitialize) this.textStartingBalance).BeginInit();
    ((ISupportInitialize) this.textEndingBalance).BeginInit();
    ((ISupportInitialize) this.textDifference).BeginInit();
    ((ISupportInitialize) this.textStatementDate).BeginInit();
    ((ISupportInitialize) this.depositTotal).BeginInit();
    ((ISupportInitialize) this.checkTotal).BeginInit();
    ((ISupportInitialize) this.voidTotal).BeginInit();
    ((ISupportInitialize) this.journalTotal).BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.MgaButton1).BeginInit();
    this.SuspendLayout();
    this.Panel1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Panel1.Controls.Add((Control) this.MgaButton1);
    this.Panel1.Controls.Add((Control) this.chkSave);
    this.Panel1.Controls.Add((Control) this.btnRefresh);
    this.Panel1.Controls.Add((Control) this.buttonEditEndingBalance);
    this.Panel1.Controls.Add((Control) this.buttonSelectAll);
    this.Panel1.Controls.Add((Control) this.buttonUnSelectAll);
    this.Panel1.Controls.Add((Control) this.buttonReconcile);
    this.Panel1.Controls.Add((Control) this.buttonCancel);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 588);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(992, 62);
    this.Panel1.TabIndex = 0;
    ((UltraToggleEditorBase) this.chkSave).Checked = true;
    ((UltraToggleEditorBase) this.chkSave).CheckState = CheckState.Checked;
    ((Control) this.chkSave).Location = new Point(12, 2);
    ((Control) this.chkSave).Name = "chkSave";
    ((Control) this.chkSave).Size = new Size(142, 20);
    ((Control) this.chkSave).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkSave).Text = "Auto Save Reconciliation";
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRefresh).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnRefresh).Location = new Point(232, 28);
    ((Control) this.btnRefresh).Name = "btnRefresh";
    ((Control) this.btnRefresh).Size = new Size(104, 24);
    ((Control) this.btnRefresh).TabIndex = 5;
    ((ControlBase) this.btnRefresh).Text = "Refresh";
    this.btnRefresh.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonEditEndingBalance).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance2.BackColor = Color.FromArgb(248, 248, 248);
    appearance2.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = Color.DarkGray;
    appearance2.ImageHAlign = (HAlign) 2;
    appearance2.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonEditEndingBalance).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonEditEndingBalance).Enabled = false;
    ((Control) this.buttonEditEndingBalance).Location = new Point(580, 28);
    ((Control) this.buttonEditEndingBalance).Name = "buttonEditEndingBalance";
    ((Control) this.buttonEditEndingBalance).Size = new Size(108, 24);
    ((Control) this.buttonEditEndingBalance).TabIndex = 4;
    ((ControlBase) this.buttonEditEndingBalance).Text = "Edit Ending Balance";
    this.buttonEditEndingBalance.UseOSThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSelectAll).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonSelectAll).Location = new Point(12, 28);
    ((Control) this.buttonSelectAll).Name = "buttonSelectAll";
    ((Control) this.buttonSelectAll).Size = new Size(104, 24);
    ((Control) this.buttonSelectAll).TabIndex = 3;
    ((ControlBase) this.buttonSelectAll).Text = "Select All";
    this.buttonSelectAll.UseOSThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    appearance4.ImageHAlign = (HAlign) 2;
    appearance4.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonUnSelectAll).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonUnSelectAll).Location = new Point(122, 28);
    ((Control) this.buttonUnSelectAll).Name = "buttonUnSelectAll";
    ((Control) this.buttonUnSelectAll).Size = new Size(104, 24);
    ((Control) this.buttonUnSelectAll).TabIndex = 2;
    ((ControlBase) this.buttonUnSelectAll).Text = "Un-Select All";
    this.buttonUnSelectAll.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonReconcile).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonReconcile).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonReconcile).Location = new Point(694, 28);
    ((Control) this.buttonReconcile).Name = "buttonReconcile";
    ((Control) this.buttonReconcile).Size = new Size(143, 24);
    ((Control) this.buttonReconcile).TabIndex = 1;
    ((ControlBase) this.buttonReconcile).Text = "Reconcile Transactions";
    this.buttonReconcile.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance6.BackColor = Color.FromArgb(248, 248, 248);
    appearance6.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DarkGray;
    appearance6.ImageHAlign = (HAlign) 2;
    appearance6.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance6;
    ((Control) this.buttonCancel).Location = new Point(843, 28);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(141, 24);
    ((Control) this.buttonCancel).TabIndex = 0;
    ((ControlBase) this.buttonCancel).Text = "Cancel";
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    this.Panel2.BackColor = Color.Transparent;
    this.Panel2.Controls.Add((Control) this.Label1);
    this.Panel2.Controls.Add((Control) this.Label2);
    this.Panel2.Dock = DockStyle.Top;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(992, 37);
    this.Panel2.TabIndex = 1;
    this.Label1.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label1.Dock = DockStyle.Bottom;
    this.Label1.ForeColor = Color.FromArgb(239, 247, 253);
    this.Label1.Location = new Point(0, 36);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(992, 1);
    this.Label1.TabIndex = 0;
    this.Label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label2.AutoSize = true;
    this.Label2.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.Label2.Location = new Point(755, 9);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(229, 19);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Bank Account Reconciliation";
    appearance7.BackColor = Color.Transparent;
    appearance7.BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.UltraLabel1).Appearance = (AppearanceBase) appearance7;
    ((Control) this.UltraLabel1).Dock = DockStyle.Left;
    ((Control) this.UltraLabel1).Location = new Point(0, 37);
    ((Control) this.UltraLabel1).Name = "UltraLabel1";
    ((Control) this.UltraLabel1).Size = new Size(184, 551);
    ((Control) this.UltraLabel1).TabIndex = 2;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.gridTransactions, "gridContext");
    ((UltraGridBase) this.gridTransactions).DataMember = "BankRegister";
    ((UltraGridBase) this.gridTransactions).DataSource = (object) this.DsBankReconciliation1;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 1;
    ultraGridColumn1.Width = 34;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 109;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 69;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Check/Reference #";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 111;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Payment Method";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 103;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 284;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance13;
    ultraGridColumn7.Format = "c";
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 110;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance15;
    ultraGridColumn8.Format = "c";
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 95;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 8;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 110;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 67;
    ultraGridBand.Columns.AddRange(new object[10]
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
      (object) ultraGridColumn10
    });
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridTransactions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance17.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance17.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance18.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance19.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance20.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    appearance21.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance22.BackColor = Color.Transparent;
    appearance22.ForeColor = Color.Black;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    appearance23.BackColor = Color.WhiteSmoke;
    appearance23.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance23;
    appearance24.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridTransactions).Dock = DockStyle.Fill;
    ((Control) this.gridTransactions).Location = new Point(184, 37);
    ((Control) this.gridTransactions).Name = "gridTransactions";
    ((Control) this.gridTransactions).Size = new Size(808, 551);
    ((Control) this.gridTransactions).TabIndex = 3;
    ((UltraControlBase) this.gridTransactions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridTransactions).UseOsThemes = (DefaultableBoolean) 2;
    this.DsBankReconciliation1.DataSetName = "dsBankReconciliation";
    this.DsBankReconciliation1.Locale = new CultureInfo("en-US");
    this.DsBankReconciliation1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.daBankReconciliation.SelectCommand = this.SqlSelectCommand1;
    this.daBankReconciliation.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankReconciliation", new DataColumnMapping[10]
      {
        new DataColumnMapping("Select", "Select"),
        new DataColumnMapping("TransactNum", "TransactNum"),
        new DataColumnMapping("TransactionDate", "TransactionDate"),
        new DataColumnMapping("CheckOrRef", "CheckOrRef"),
        new DataColumnMapping("Method", "Method"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("Debit", "Debit"),
        new DataColumnMapping("Credit", "Credit"),
        new DataColumnMapping("TrxType", "TrxType"),
        new DataColumnMapping("BankAcctId", "BankAcctId")
      })
    });
    this.daBankReconciliation.UpdateCommand = this.SqlUpdateCommand1;
    this.SqlSelectCommand1.CommandText = "dbo.spFin_GetBankReconciliation";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@bankglacct", SqlDbType.Int, 4)
    });
    this.FormDataConnection.ConnectionString = "Data Source=mgasystems;Initial Catalog=IMS;Integrated Security=True";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.SqlUpdateCommand1.CommandText = "dbo.spFin_ReconcileBankTransaction";
    this.SqlUpdateCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlUpdateCommand1.Connection = this.FormDataConnection;
    this.SqlUpdateCommand1.Parameters.AddRange(new SqlParameter[5]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@transactNum", SqlDbType.Int, 4, "TransactNum"),
      new SqlParameter("@glAcctId", SqlDbType.Int, 4, "BankAcctId"),
      new SqlParameter("@transactionType", SqlDbType.Char, 1, "TrxType"),
      new SqlParameter("@reconcileDate", SqlDbType.DateTime, 8)
    });
    appearance25.BackColor = Color.White;
    appearance25.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance25.BackGradientAlignment = (GradientAlignment) 3;
    appearance25.BackGradientStyle = (GradientStyle) 2;
    appearance25.ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance25;
    ((AutoSizeControlBase) this.ultraLabel4).AutoSize = true;
    ((Control) this.ultraLabel4).Location = new Point(12, 64 /*0x40*/);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(160 /*0xA0*/, 15);
    ((Control) this.ultraLabel4).TabIndex = 9;
    ((ControlBase) this.ultraLabel4).Text = "Select Transactions to Reconcile";
    appearance26.BackColor = Color.White;
    appearance26.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance26.BackGradientAlignment = (GradientAlignment) 2;
    appearance26.BackGradientStyle = (GradientStyle) 2;
    appearance26.ForeColor = Color.Gray;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance26;
    ((AutoSizeControlBase) this.ultraLabel8).AutoSize = true;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, System.Drawing.FontStyle.Bold);
    ((Control) this.ultraLabel8).Location = new Point(12, 43);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(138, 15);
    ((Control) this.ultraLabel8).TabIndex = 8;
    ((ControlBase) this.ultraLabel8).Text = "BANK RECONCILIATION";
    appearance27.BackColor = Color.White;
    appearance27.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance27.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textStartingBalance).Appearance = (AppearanceBase) appearance27;
    ((TextEditorControlBase) this.textStartingBalance).BackColor = Color.White;
    ((Control) this.textStartingBalance).Location = new Point(12, 144 /*0x90*/);
    this.textStartingBalance.MGAStyle = MGAStyles.Blue;
    ((Control) this.textStartingBalance).Name = "textStartingBalance";
    ((EditorButtonControlBase) this.textStartingBalance).ReadOnly = true;
    ((Control) this.textStartingBalance).Size = new Size(152, 20);
    ((Control) this.textStartingBalance).TabIndex = 10;
    ((Control) this.textStartingBalance).TabStop = false;
    ((UltraControlBase) this.textStartingBalance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textStartingBalance).UseOsThemes = (DefaultableBoolean) 2;
    appearance28.BackColor = Color.White;
    appearance28.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance28.BackGradientAlignment = (GradientAlignment) 3;
    appearance28.BackGradientStyle = (GradientStyle) 2;
    appearance28.ForeColor = Color.Gray;
    ((ControlBase) this.UltraLabel2).Appearance = (AppearanceBase) appearance28;
    ((AutoSizeControlBase) this.UltraLabel2).AutoSize = true;
    ((Control) this.UltraLabel2).Location = new Point(12, 128 /*0x80*/);
    ((Control) this.UltraLabel2).Name = "UltraLabel2";
    ((Control) this.UltraLabel2).Size = new Size(87, 15);
    ((Control) this.UltraLabel2).TabIndex = 11;
    ((ControlBase) this.UltraLabel2).Text = "Starting Balance:";
    appearance29.BackColor = Color.White;
    appearance29.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance29.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEndingBalance).Appearance = (AppearanceBase) appearance29;
    ((TextEditorControlBase) this.textEndingBalance).BackColor = Color.White;
    ((Control) this.textEndingBalance).Location = new Point(12, 184);
    this.textEndingBalance.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEndingBalance).Name = "textEndingBalance";
    ((EditorButtonControlBase) this.textEndingBalance).ReadOnly = true;
    ((Control) this.textEndingBalance).Size = new Size(152, 20);
    ((Control) this.textEndingBalance).TabIndex = 12;
    ((Control) this.textEndingBalance).TabStop = false;
    ((UltraControlBase) this.textEndingBalance).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEndingBalance).UseOsThemes = (DefaultableBoolean) 2;
    appearance30.BackColor = Color.White;
    appearance30.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance30.BackGradientAlignment = (GradientAlignment) 3;
    appearance30.BackGradientStyle = (GradientStyle) 2;
    appearance30.ForeColor = Color.Gray;
    ((ControlBase) this.UltraLabel3).Appearance = (AppearanceBase) appearance30;
    ((AutoSizeControlBase) this.UltraLabel3).AutoSize = true;
    ((Control) this.UltraLabel3).Location = new Point(12, 168);
    ((Control) this.UltraLabel3).Name = "UltraLabel3";
    ((Control) this.UltraLabel3).Size = new Size(82, 15);
    ((Control) this.UltraLabel3).TabIndex = 13;
    ((ControlBase) this.UltraLabel3).Text = "Ending Balance:";
    appearance31.BackColor = Color.White;
    appearance31.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance31.BackGradientAlignment = (GradientAlignment) 3;
    appearance31.BackGradientStyle = (GradientStyle) 2;
    appearance31.ForeColor = Color.Gray;
    ((ControlBase) this.UltraLabel5).Appearance = (AppearanceBase) appearance31;
    ((AutoSizeControlBase) this.UltraLabel5).AutoSize = true;
    ((Control) this.UltraLabel5).Location = new Point(12, 208 /*0xD0*/);
    ((Control) this.UltraLabel5).Name = "UltraLabel5";
    ((Control) this.UltraLabel5).Size = new Size(57, 15);
    ((Control) this.UltraLabel5).TabIndex = 15;
    ((ControlBase) this.UltraLabel5).Text = "Difference:";
    appearance32.BackColor = Color.White;
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textDifference).Appearance = (AppearanceBase) appearance32;
    ((TextEditorControlBase) this.textDifference).BackColor = Color.White;
    ((Control) this.textDifference).Location = new Point(12, 224 /*0xE0*/);
    this.textDifference.MGAStyle = MGAStyles.Blue;
    ((Control) this.textDifference).Name = "textDifference";
    ((EditorButtonControlBase) this.textDifference).ReadOnly = true;
    ((Control) this.textDifference).Size = new Size(152, 20);
    ((Control) this.textDifference).TabIndex = 14;
    ((Control) this.textDifference).TabStop = false;
    ((UltraControlBase) this.textDifference).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textDifference).UseOsThemes = (DefaultableBoolean) 2;
    appearance33.BackColor = Color.White;
    appearance33.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance33.BackGradientAlignment = (GradientAlignment) 3;
    appearance33.BackGradientStyle = (GradientStyle) 2;
    appearance33.ForeColor = Color.Gray;
    ((ControlBase) this.UltraLabel6).Appearance = (AppearanceBase) appearance33;
    ((AutoSizeControlBase) this.UltraLabel6).AutoSize = true;
    ((Control) this.UltraLabel6).Location = new Point(12, 88);
    ((Control) this.UltraLabel6).Name = "UltraLabel6";
    ((Control) this.UltraLabel6).Size = new Size(84, 15);
    ((Control) this.UltraLabel6).TabIndex = 17;
    ((ControlBase) this.UltraLabel6).Text = "Statement Date:";
    appearance34.BackColor = Color.White;
    appearance34.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance34.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textStatementDate).Appearance = (AppearanceBase) appearance34;
    ((TextEditorControlBase) this.textStatementDate).BackColor = Color.White;
    ((Control) this.textStatementDate).Location = new Point(12, 104);
    this.textStatementDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.textStatementDate).Name = "textStatementDate";
    ((EditorButtonControlBase) this.textStatementDate).ReadOnly = true;
    ((Control) this.textStatementDate).Size = new Size(152, 20);
    ((Control) this.textStatementDate).TabIndex = 16 /*0x10*/;
    ((Control) this.textStatementDate).TabStop = false;
    ((UltraControlBase) this.textStatementDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textStatementDate).UseOsThemes = (DefaultableBoolean) 2;
    this.labelCurtain.BackColor = Color.FromArgb(239, 247, 253);
    this.labelCurtain.Dock = DockStyle.Fill;
    this.labelCurtain.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelCurtain.ForeColor = Color.LightSlateGray;
    this.labelCurtain.Location = new Point(0, 0);
    this.labelCurtain.Name = "labelCurtain";
    this.labelCurtain.Size = new Size(992, 650);
    this.labelCurtain.TabIndex = 18;
    this.labelCurtain.Text = "Loading Saved Reconciliation Data.....";
    this.labelCurtain.TextAlign = ContentAlignment.MiddleCenter;
    appearance35.BackColor = Color.White;
    appearance35.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance35.ForeColor = Color.Black;
    ((TextEditorControlBase) this.depositTotal).Appearance = (AppearanceBase) appearance35;
    ((TextEditorControlBase) this.depositTotal).BackColor = Color.White;
    ((Control) this.depositTotal).Location = new Point(12, 288);
    this.depositTotal.MGAStyle = MGAStyles.Blue;
    ((Control) this.depositTotal).Name = "depositTotal";
    ((EditorButtonControlBase) this.depositTotal).ReadOnly = true;
    ((Control) this.depositTotal).Size = new Size(152, 20);
    ((Control) this.depositTotal).TabIndex = 14;
    ((Control) this.depositTotal).TabStop = false;
    ((UltraControlBase) this.depositTotal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.depositTotal).UseOsThemes = (DefaultableBoolean) 2;
    appearance36.BackColor = Color.White;
    appearance36.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance36.ForeColor = Color.Black;
    ((TextEditorControlBase) this.checkTotal).Appearance = (AppearanceBase) appearance36;
    ((TextEditorControlBase) this.checkTotal).BackColor = Color.White;
    ((Control) this.checkTotal).Location = new Point(12, 326);
    this.checkTotal.MGAStyle = MGAStyles.Blue;
    ((Control) this.checkTotal).Name = "checkTotal";
    ((EditorButtonControlBase) this.checkTotal).ReadOnly = true;
    ((Control) this.checkTotal).Size = new Size(152, 20);
    ((Control) this.checkTotal).TabIndex = 14;
    ((Control) this.checkTotal).TabStop = false;
    ((UltraControlBase) this.checkTotal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkTotal).UseOsThemes = (DefaultableBoolean) 2;
    appearance37.BackColor = Color.White;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance37.ForeColor = Color.Black;
    ((TextEditorControlBase) this.voidTotal).Appearance = (AppearanceBase) appearance37;
    ((TextEditorControlBase) this.voidTotal).BackColor = Color.White;
    ((Control) this.voidTotal).Location = new Point(12, 365);
    this.voidTotal.MGAStyle = MGAStyles.Blue;
    ((Control) this.voidTotal).Name = "voidTotal";
    ((EditorButtonControlBase) this.voidTotal).ReadOnly = true;
    ((Control) this.voidTotal).Size = new Size(152, 20);
    ((Control) this.voidTotal).TabIndex = 14;
    ((Control) this.voidTotal).TabStop = false;
    ((UltraControlBase) this.voidTotal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.voidTotal).UseOsThemes = (DefaultableBoolean) 2;
    appearance38.BackColor = Color.White;
    appearance38.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance38.ForeColor = Color.Black;
    ((TextEditorControlBase) this.journalTotal).Appearance = (AppearanceBase) appearance38;
    ((TextEditorControlBase) this.journalTotal).BackColor = Color.White;
    ((Control) this.journalTotal).Location = new Point(12, 405);
    this.journalTotal.MGAStyle = MGAStyles.Blue;
    ((Control) this.journalTotal).Name = "journalTotal";
    ((EditorButtonControlBase) this.journalTotal).ReadOnly = true;
    ((Control) this.journalTotal).Size = new Size(152, 20);
    ((Control) this.journalTotal).TabIndex = 14;
    ((Control) this.journalTotal).TabStop = false;
    ((UltraControlBase) this.journalTotal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.journalTotal).UseOsThemes = (DefaultableBoolean) 2;
    appearance39.BackColor = Color.White;
    appearance39.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance39.BackGradientAlignment = (GradientAlignment) 3;
    appearance39.BackGradientStyle = (GradientStyle) 2;
    appearance39.ForeColor = Color.Gray;
    ((ControlBase) this.UltraLabel7).Appearance = (AppearanceBase) appearance39;
    ((AutoSizeControlBase) this.UltraLabel7).AutoSize = true;
    ((Control) this.UltraLabel7).Location = new Point(12, 273);
    ((Control) this.UltraLabel7).Name = "UltraLabel7";
    ((Control) this.UltraLabel7).Size = new Size(72, 15);
    ((Control) this.UltraLabel7).TabIndex = 15;
    ((ControlBase) this.UltraLabel7).Text = "Deposit Total:";
    appearance40.BackColor = Color.White;
    appearance40.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance40.BackGradientAlignment = (GradientAlignment) 3;
    appearance40.BackGradientStyle = (GradientStyle) 2;
    appearance40.ForeColor = Color.Gray;
    ((ControlBase) this.UltraLabel9).Appearance = (AppearanceBase) appearance40;
    ((AutoSizeControlBase) this.UltraLabel9).AutoSize = true;
    ((Control) this.UltraLabel9).Location = new Point(12, 309);
    ((Control) this.UltraLabel9).Name = "UltraLabel9";
    ((Control) this.UltraLabel9).Size = new Size(65, 15);
    ((Control) this.UltraLabel9).TabIndex = 15;
    ((ControlBase) this.UltraLabel9).Text = "Check Total:";
    appearance41.BackColor = Color.White;
    appearance41.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance41.BackGradientAlignment = (GradientAlignment) 3;
    appearance41.BackGradientStyle = (GradientStyle) 2;
    appearance41.ForeColor = Color.Gray;
    ((ControlBase) this.UltraLabel10).Appearance = (AppearanceBase) appearance41;
    ((AutoSizeControlBase) this.UltraLabel10).AutoSize = true;
    ((Control) this.UltraLabel10).Location = new Point(12, 350);
    ((Control) this.UltraLabel10).Name = "UltraLabel10";
    ((Control) this.UltraLabel10).Size = new Size(57, 15);
    ((Control) this.UltraLabel10).TabIndex = 15;
    ((ControlBase) this.UltraLabel10).Text = "Void Total:";
    appearance42.BackColor = Color.White;
    appearance42.BackColor2 = Color.FromArgb(239, 247, 253);
    appearance42.BackGradientAlignment = (GradientAlignment) 3;
    appearance42.BackGradientStyle = (GradientStyle) 2;
    appearance42.ForeColor = Color.Gray;
    ((ControlBase) this.UltraLabel11).Appearance = (AppearanceBase) appearance42;
    ((AutoSizeControlBase) this.UltraLabel11).AutoSize = true;
    ((Control) this.UltraLabel11).Location = new Point(12, 389);
    ((Control) this.UltraLabel11).Name = "UltraLabel11";
    ((Control) this.UltraLabel11).Size = new Size(105, 15);
    ((Control) this.UltraLabel11).TabIndex = 15;
    ((ControlBase) this.UltraLabel11).Text = "Other Miscellaneous:";
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 8;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "gridContext";
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    appearance43.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance27.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance43;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "View Transaction Detail";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    appearance44.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance28.Image"));
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance44;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Print Transaction Detail";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formBankReconciliation_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Left).Name = "_formBankReconciliation_Toolbars_Dock_Area_Left";
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Left).Size = new Size(0, 650);
    this._formBankReconciliation_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formBankReconciliation_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Right).Location = new Point(992, 0);
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Right).Name = "_formBankReconciliation_Toolbars_Dock_Area_Right";
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Right).Size = new Size(0, 650);
    this._formBankReconciliation_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formBankReconciliation_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Top).Name = "_formBankReconciliation_Toolbars_Dock_Area_Top";
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Top).Size = new Size(992, 0);
    this._formBankReconciliation_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formBankReconciliation_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Bottom).Location = new Point(0, 650);
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Bottom).Name = "_formBankReconciliation_Toolbars_Dock_Area_Bottom";
    ((Control) this._formBankReconciliation_Toolbars_Dock_Area_Bottom).Size = new Size(992, 0);
    this._formBankReconciliation_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    appearance45.BackColor = Color.FromArgb(248, 248, 248);
    appearance45.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance45.BackGradientStyle = (GradientStyle) 2;
    appearance45.BorderColor = Color.DarkGray;
    appearance45.ImageHAlign = (HAlign) 2;
    appearance45.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.MgaButton1).Appearance = (AppearanceBase) appearance45;
    ((Control) this.MgaButton1).Location = new Point(342, 28);
    ((Control) this.MgaButton1).Name = "MgaButton1";
    ((Control) this.MgaButton1).Size = new Size(104, 24);
    ((Control) this.MgaButton1).TabIndex = 23;
    ((ControlBase) this.MgaButton1).Text = "Export to Excel";
    this.MgaButton1.UseOSThemes = (DefaultableBoolean) 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(992, 650);
    this.Controls.Add((Control) this.UltraLabel6);
    this.Controls.Add((Control) this.textStatementDate);
    this.Controls.Add((Control) this.UltraLabel11);
    this.Controls.Add((Control) this.UltraLabel10);
    this.Controls.Add((Control) this.UltraLabel9);
    this.Controls.Add((Control) this.UltraLabel7);
    this.Controls.Add((Control) this.UltraLabel5);
    this.Controls.Add((Control) this.journalTotal);
    this.Controls.Add((Control) this.voidTotal);
    this.Controls.Add((Control) this.checkTotal);
    this.Controls.Add((Control) this.depositTotal);
    this.Controls.Add((Control) this.textDifference);
    this.Controls.Add((Control) this.UltraLabel3);
    this.Controls.Add((Control) this.textEndingBalance);
    this.Controls.Add((Control) this.UltraLabel2);
    this.Controls.Add((Control) this.textStartingBalance);
    this.Controls.Add((Control) this.ultraLabel4);
    this.Controls.Add((Control) this.ultraLabel8);
    this.Controls.Add((Control) this.gridTransactions);
    this.Controls.Add((Control) this.UltraLabel1);
    this.Controls.Add((Control) this.Panel2);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this.labelCurtain);
    this.Controls.Add((Control) this._formBankReconciliation_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formBankReconciliation_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formBankReconciliation_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formBankReconciliation_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formBankReconciliation);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Reconcile Bank Account";
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.chkSave).EndInit();
    ((ISupportInitialize) this.btnRefresh).EndInit();
    ((ISupportInitialize) this.buttonEditEndingBalance).EndInit();
    ((ISupportInitialize) this.buttonSelectAll).EndInit();
    ((ISupportInitialize) this.buttonUnSelectAll).EndInit();
    ((ISupportInitialize) this.buttonReconcile).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    ((ISupportInitialize) this.gridTransactions).EndInit();
    this.DsBankReconciliation1.EndInit();
    ((ISupportInitialize) this.textStartingBalance).EndInit();
    ((ISupportInitialize) this.textEndingBalance).EndInit();
    ((ISupportInitialize) this.textDifference).EndInit();
    ((ISupportInitialize) this.textStatementDate).EndInit();
    ((ISupportInitialize) this.depositTotal).EndInit();
    ((ISupportInitialize) this.checkTotal).EndInit();
    ((ISupportInitialize) this.voidTotal).EndInit();
    ((ISupportInitialize) this.journalTotal).EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.MgaButton1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void LoadAccountRegister()
  {
    this.DsBankReconciliation1.BankRegister.Clear();
    this.daBankReconciliation.SelectCommand.Parameters["@bankglacct"].Value = (object) this._bankGlAccountId;
    this.daBankReconciliation.SelectCommand.CommandTimeout = 300;
    this.daBankReconciliation.Fill((DataTable) this.DsBankReconciliation1.BankRegister);
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.ClosingHander();
    this.Close();
  }

  public virtual void gridTransactions_Click(object sender, EventArgs e)
  {
    UIElement lastElementEntered = ((ControlUIElementBase) ((UltraGridBase) this.gridTransactions).DisplayLayout.UIElement).LastElementEntered;
    if ((ColumnHeader) lastElementEntered.GetContext(typeof (ColumnHeader), true) != null || lastElementEntered == null)
      return;
    UltraGridRow context = (UltraGridRow) lastElementEntered.GetContext(typeof (UltraGridRow), true);
    if (context == null)
      return;
    context.Cells["select"].Value = (object) !bool.Parse(context.Cells["select"].Value.ToString());
  }

  public virtual void buttonUnSelectAll_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridTransactions).Rows)
      row.Cells["select"].Value = (object) false;
  }

  public virtual void buttonSelectAll_Click(object sender, EventArgs e)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridTransactions).Rows)
      row.Cells["select"].Value = (object) true;
  }

  private void buttonReconcile_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    this.Reconcile();
    if (this.MdiParent == null)
      return;
    Form[] all = Array.FindAll<Form>(this.MdiParent.MdiChildren, new Predicate<Form>(this.IsBankingForm));
    int num = all.Length - 1;
    for (int index = 0; index <= num; ++index)
    {
      if (all[index] != null)
      {
        frmBanking frmBanking = (frmBanking) all[index];
        if (frmBanking._BankAccountRegister.BankGLAccountId == this._bankGlAccountId)
        {
          frmBanking._BankAccountRegister.ReloadRegister();
          break;
        }
      }
    }
    if (this._hasSavedWorkSheet)
      ReconciliationWorkSheet.DeleteWorkSheet(this._bankGlAccountId);
    this.Close();
    this.Cursor = Cursors.Default;
  }

  private void Reconcile()
  {
    if (!this.ReconciliationInBalance())
    {
      int num = (int) MessageBox.Show("The reconciliation is does not match the statement balance. This reconciliation can not be saved until it matches the statement.", "Reconciliation Not Complete!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show("This will reconcile the selected transactions, continue?", "Reconcile Selected Transactions?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      ((UltraGridBase) this.gridTransactions).UpdateData();
      try
      {
        this.daBankReconciliation.UpdateCommand.Connection.Open();
        this.daBankReconciliation.UpdateCommand.Transaction = this.daBankReconciliation.UpdateCommand.Connection.BeginTransaction();
        this.daBankReconciliation.UpdateCommand.Parameters["@ReconcileDate"].Value = (object) DateTime.Parse(((TextEditorControlBase) this.textStatementDate).Text);
        this.daBankReconciliation.Update(this.DsBankReconciliation1.BankRegister.Select("Select = true"));
        this.daBankReconciliation.UpdateCommand.Transaction.Commit();
        this.PrintStatement();
        CurrentUser.Instance.LogAction($"Reconciled Bank GL Account# {this._bankGlAccountId}, using statement date {this._statementDate.ToString("d")}", "Banking Logs");
        this.DialogResult = DialogResult.OK;
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        SqlException sqlException = ex;
        if (this.daBankReconciliation.UpdateCommand.Transaction != null)
          this.daBankReconciliation.UpdateCommand.Transaction.Rollback();
        throw sqlException;
      }
      finally
      {
        this.daBankReconciliation.UpdateCommand.Connection.Close();
        this.Cursor = Cursors.Default;
      }
    }
  }

  private void formBankReconciliation_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.Cursor = Cursors.WaitCursor;
    try
    {
      if (this.LoadWorkSheet())
      {
        ((Control) this.buttonEditEndingBalance).Enabled = true;
        this.Cursor = Cursors.Default;
      }
      this.GetTotals();
      this.RecalculateDifference();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void GetStartingBalance(DateTime StatementDate)
  {
    ((TextEditorControlBase) this.textStartingBalance).Text = MGASystems.IMS.Accounting.Banking.Utility.GetAccountStartingBalance(this._bankGlAccountId, StatementDate).ToString("c");
  }

  private void CalculateDifference(Decimal Amount)
  {
    ((TextEditorControlBase) this.textDifference).Text = Decimal.Subtract(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.textDifference).Text, string.Empty, false) != 0 ? Conversions.ToDecimal(((TextEditorControlBase) this.textDifference).Text) : 0M, Amount).ToString("c");
  }

  private void gridTransactions_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (e.Cell == null)
      return;
    if (!e.Cell.Row.Cells["Debit"].Value.Equals((object) DBNull.Value) && Decimal.Compare(Conversions.ToDecimal(e.Cell.Row.Cells["Debit"].Value), 0M) != 0)
    {
      if (Conversions.ToBoolean(e.Cell.Row.Cells["Select"].Value))
        this.CalculateDifference(Conversions.ToDecimal(e.Cell.Row.Cells["Debit"].Value));
      else
        this.CalculateDifference(Decimal.Negate(Conversions.ToDecimal(e.Cell.Row.Cells["Debit"].Value)));
    }
    if (!e.Cell.Row.Cells["Credit"].Value.Equals((object) DBNull.Value) && Decimal.Compare(Conversions.ToDecimal(e.Cell.Row.Cells["Credit"].Value), 0M) != 0)
    {
      if (Conversions.ToBoolean(e.Cell.Row.Cells["Select"].Value))
        this.CalculateDifference(Conversions.ToDecimal(e.Cell.Row.Cells["Credit"].Value));
      else
        this.CalculateDifference(Decimal.Negate(Conversions.ToDecimal(e.Cell.Row.Cells["Credit"].Value)));
    }
    this.GetTotals();
  }

  private bool ReconciliationInBalance()
  {
    return Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((TextEditorControlBase) this.textDifference).Text, string.Empty, false) != 0 && Decimal.Compare(Conversions.ToDecimal(((TextEditorControlBase) this.textDifference).Text), 0M) == 0;
  }

  private void PrintStatement()
  {
    ReportFactory.Instance.ShowReport(false, ((object) new rptBankReconciliation()).GetType(), (object) this._statementDate, (object) this._bankGlAccountId, (object) this._bankGlAccountId, (object) this.DsBankReconciliation1);
  }

  private void buttonEditEndingBalance_Click(object sender, EventArgs e)
  {
    formBankRecInputs formBankRecInputs = new formBankRecInputs(this._bankGlAccountId, !string.IsNullOrEmpty(((TextEditorControlBase) this.textStatementDate).Text) ? Conversions.ToDate(((TextEditorControlBase) this.textStatementDate).Text) : DateTime.Now);
    try
    {
      if (formBankRecInputs.ShowDialog() != DialogResult.OK)
        return;
      this.Cursor = Cursors.WaitCursor;
      ((TextEditorControlBase) this.textStatementDate).Text = Strings.Format((object) formBankRecInputs.PeriodDate, "Short Date");
      this._statementDate = formBankRecInputs.PeriodDate;
      ((TextEditorControlBase) this.textEndingBalance).Text = formBankRecInputs.EndingBalance.ToString("c");
      this.GetStartingBalance(formBankRecInputs.PeriodDate);
      this.RecalculateDifference();
    }
    finally
    {
      formBankRecInputs.Dispose();
      this.Cursor = Cursors.Default;
    }
  }

  private void RecalculateDifference()
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      ((TextEditorControlBase) this.textDifference).Text = Decimal.Subtract(Conversions.ToDecimal(((TextEditorControlBase) this.textEndingBalance).Text), Conversions.ToDecimal(((TextEditorControlBase) this.textStartingBalance).Text)).ToString("c");
      RowEnumerator enumerator = ((UltraGridBase) this.gridTransactions).Rows.GetEnumerator();
      while (enumerator.MoveNext())
      {
        UltraGridRow current = enumerator.Current;
        if (Conversions.ToBoolean(current.Cells["Select"].Value))
        {
          if (!current.Cells["Debit"].Value.Equals((object) DBNull.Value) && Decimal.Compare(Conversions.ToDecimal(current.Cells["Debit"].Value), 0M) != 0)
            this.CalculateDifference(Conversions.ToDecimal(current.Cells["Debit"].Value));
          if (!current.Cells["Credit"].Value.Equals((object) DBNull.Value) && Decimal.Compare(Conversions.ToDecimal(current.Cells["Credit"].Value), 0M) != 0)
            this.CalculateDifference(Conversions.ToDecimal(current.Cells["Credit"].Value));
        }
      }
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void btnRefresh_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    List<int> selectedTransactions = this.GetSelectedTransactions();
    this.DsBankReconciliation1.Clear();
    this.DsBankReconciliation1.AcceptChanges();
    this.LoadAccountRegister();
    this.SetSelectTransactions(selectedTransactions);
    this.Cursor = Cursors.Default;
    selectedTransactions.Clear();
  }

  private bool IsBankingForm(Form f) => f is frmBanking;

  private List<int> GetSelectedTransactions()
  {
    List<int> selectedTransactions = new List<int>();
    foreach (UltraGridRow row in ((UltraGridBase) this.gridTransactions).Rows)
    {
      if (bool.Parse(row.Cells["select"].Value.ToString()))
        selectedTransactions.Add(int.Parse(row.Cells["TransactNum"].Value.ToString()));
    }
    return selectedTransactions;
  }

  private void SetSelectTransactions(List<int> _selectedTransactions)
  {
    int num1 = _selectedTransactions.Count - 1;
    for (int index1 = 0; index1 <= num1; ++index1)
    {
      dsBankReconciliation.BankRegisterDataTable bankRegister = this.DsBankReconciliation1.BankRegister;
      int num2 = _selectedTransactions[index1];
      string filterExpression = $"TransactNum ='{num2.ToString()}'";
      DataRow[] dataRowArray = bankRegister.Select(filterExpression);
      num2 = dataRowArray.Length - 1;
      for (int index2 = 0; index2 <= num2; ++index2)
        dataRowArray[index2]["select"] = (object) true;
    }
  }

  private bool LoadWorkSheet()
  {
    this.Cursor = Cursors.WaitCursor;
    this.DsBankReconciliation1.Clear();
    this.DsBankReconciliation1.AcceptChanges();
    this.LoadAccountRegister();
    ReconciliationWorkSheet worksheetObject = ReconciliationWorkSheet.GetWorksheetObject(CurrentUser.Instance.UserGUID, this._bankGlAccountId);
    bool flag;
    if (worksheetObject == null)
    {
      this._hasSavedWorkSheet = false;
      flag = false;
    }
    else if (MessageBox.Show("The system has found a saved worksheet for this bank account, would you like to load the saved reconciliation worksheet?", "Load Saved Reconciliation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
    {
      this._hasSavedWorkSheet = false;
      flag = false;
    }
    else
    {
      this.labelCurtain.BringToFront();
      this.SetSelectTransactions(worksheetObject.SelectedTransactions);
      this.GetStartingBalance(worksheetObject.StatementDate);
      ((TextEditorControlBase) this.textStatementDate).Text = worksheetObject.StatementDate.ToShortDateString();
      ((TextEditorControlBase) this.textEndingBalance).Text = worksheetObject.EndingBalance.ToString("c");
      this.CalculateDifference(worksheetObject.EndingBalance);
      this.Cursor = Cursors.Default;
      this.labelCurtain.SendToBack();
      this._hasSavedWorkSheet = true;
      flag = true;
    }
    return flag;
  }

  private void Save()
  {
    this.Cursor = Cursors.WaitCursor;
    List<int> selectedTransactions = this.GetSelectedTransactions();
    if (selectedTransactions.Count == 0)
      return;
    ReconciliationWorkSheet.SaveWorkSheet(new ReconciliationWorkSheet()
    {
      SelectedTransactions = selectedTransactions,
      EndingBalance = Decimal.Parse(((TextEditorControlBase) this.textEndingBalance).Text, NumberStyles.Any),
      StatementDate = DateTime.Parse(((TextEditorControlBase) this.textStatementDate).Text)
    }, this._bankGlAccountId);
    this.Cursor = Cursors.Default;
  }

  private void formBankReconciliation_FormClosing(object sender, FormClosingEventArgs e)
  {
    this.ClosingHander();
  }

  private void ClosingHander()
  {
    this.DialogResult = DialogResult.Cancel;
    string text = "Do you want to save current selected items?";
    if (!((UltraToggleEditorBase) this.chkSave).Checked && MessageBox.Show(text, "Save Reconciliation?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.Save();
  }

  public bool CanReCreateEntity => false;

  public Guid ControlGUID => Guid.Empty;

  public Guid EntityGuid => Guid.Empty;

  public string EntityName => string.Empty;

  public string FriendlyEntityName => string.Empty;

  public bool HasControlGUID => false;

  public bool RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    return flag;
  }

  public string RecreateTypeName => this.GetType().ToString();

  private void GetTotals()
  {
    this.GetDepositTotal();
    this.GetVoidTotals();
    this.GetCheckTotals();
    this.GetJournalTotals();
  }

  private void GetDepositTotal()
  {
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Description"].FilterConditions.Add((FilterComparisionOperator) 10, (object) "Deposit");
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Select"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridTransactions).Rows.GetFilteredInNonGroupByRows();
    Decimal d1 = 0M;
    UltraGridRow[] ultraGridRowArray = inNonGroupByRows;
    int index = 0;
    while (index < ultraGridRowArray.Length)
    {
      UltraGridRow ultraGridRow = ultraGridRowArray[index];
      d1 = ultraGridRow.Cells["Debit"].Value.Equals((object) DBNull.Value) || Decimal.Compare(Conversions.ToDecimal(ultraGridRow.Cells["Debit"].Value), 0M) == 0 ? Decimal.Add(d1, Decimal.Parse(ultraGridRow.Cells["Credit"].Value.ToString())) : Decimal.Add(d1, Decimal.Parse(ultraGridRow.Cells["Debit"].Value.ToString()));
      checked { ++index; }
    }
    ((TextEditorControlBase) this.depositTotal).Text = d1.ToString("c");
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
  }

  private void GetCheckTotals()
  {
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Method"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "C");
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Method"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "O");
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Method"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "M");
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Method"].LogicalOperator = (FilterLogicalOperator) 1;
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Select"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridTransactions).Rows.GetFilteredInNonGroupByRows();
    Decimal d1 = 0M;
    UltraGridRow[] ultraGridRowArray = inNonGroupByRows;
    int index = 0;
    while (index < ultraGridRowArray.Length)
    {
      UltraGridRow ultraGridRow = ultraGridRowArray[index];
      d1 = ultraGridRow.Cells["Debit"].Value.Equals((object) DBNull.Value) || Decimal.Compare(Conversions.ToDecimal(ultraGridRow.Cells["Debit"].Value), 0M) == 0 ? Decimal.Add(d1, Decimal.Parse(ultraGridRow.Cells["Credit"].Value.ToString())) : Decimal.Add(d1, Decimal.Parse(ultraGridRow.Cells["Debit"].Value.ToString()));
      checked { ++index; }
    }
    ((TextEditorControlBase) this.checkTotal).Text = d1.ToString("c");
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
  }

  private void GetJournalTotals()
  {
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Method"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "J");
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Select"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridTransactions).Rows.GetFilteredInNonGroupByRows();
    Decimal d1 = 0M;
    UltraGridRow[] ultraGridRowArray = inNonGroupByRows;
    int index = 0;
    while (index < ultraGridRowArray.Length)
    {
      UltraGridRow ultraGridRow = ultraGridRowArray[index];
      d1 = ultraGridRow.Cells["Debit"].Value.Equals((object) DBNull.Value) || Decimal.Compare(Conversions.ToDecimal(ultraGridRow.Cells["Debit"].Value), 0M) == 0 ? Decimal.Add(d1, Decimal.Parse(ultraGridRow.Cells["Credit"].Value.ToString())) : Decimal.Add(d1, Decimal.Parse(ultraGridRow.Cells["Debit"].Value.ToString()));
      checked { ++index; }
    }
    ((TextEditorControlBase) this.journalTotal).Text = d1.ToString("c");
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
  }

  private void GetVoidTotals()
  {
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Method"].FilterConditions.Add((FilterComparisionOperator) 0, (object) "V");
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters["Select"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridTransactions).Rows.GetFilteredInNonGroupByRows();
    Decimal d1 = 0M;
    UltraGridRow[] ultraGridRowArray = inNonGroupByRows;
    int index = 0;
    while (index < ultraGridRowArray.Length)
    {
      UltraGridRow ultraGridRow = ultraGridRowArray[index];
      d1 = ultraGridRow.Cells["Debit"].Value.Equals((object) DBNull.Value) || Decimal.Compare(Conversions.ToDecimal(ultraGridRow.Cells["Debit"].Value), 0M) == 0 ? Decimal.Add(d1, Decimal.Parse(ultraGridRow.Cells["Credit"].Value.ToString())) : Decimal.Add(d1, Decimal.Parse(ultraGridRow.Cells["Debit"].Value.ToString()));
      checked { ++index; }
    }
    ((TextEditorControlBase) this.voidTotal).Text = d1.ToString("c");
    ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
  }

  private bool VerifyForm() => true;

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    GLAccount glAccount = new GLAccount(this._bankGlAccountId);
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "VIEW", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "PRINT", false) != 0 || ((UltraGridBase) this.gridTransactions).Rows.Count == 0 || this.gridTransactions.Selected.Rows.Count == 0 || this.gridTransactions.Selected.Rows[0] == null)
        return;
      ReportFactory.Instance.ShowReport(false, typeof (rptJournalTransaction), (object) Conversions.ToInteger(this.gridTransactions.Selected.Rows[0].Cells["transactnum"].Value));
    }
    else
    {
      if (((UltraGridBase) this.gridTransactions).Rows.Count == 0 || this.gridTransactions.Selected.Rows.Count == 0 || this.gridTransactions.Selected.Rows[0] == null)
        return;
      new formTransactionViewer(Conversions.ToInteger(this.gridTransactions.Selected.Rows[0].Cells["transactnum"].Value), glAccount.GLCompanyId).Show();
    }
  }

  private void UltraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    if (((UltraGridBase) this.gridTransactions).DisplayLayout.UIElement == null || ((ControlUIElementBase) ((UltraGridBase) this.gridTransactions).DisplayLayout.UIElement).LastElementEntered == null)
      return;
    UltraGridRow context = (UltraGridRow) ((ControlUIElementBase) ((UltraGridBase) this.gridTransactions).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow));
    ((UltraGridBase) this.gridTransactions).ActiveRow = context;
    this.gridTransactions.Selected.Rows.Clear();
    ((UltraGridBase) this.gridTransactions).ActiveRow.Selected = true;
    ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["gridContext"]).Tools)["VIEW"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "D", false) != 0;
    ((ToolsCollectionBase) ((PopupMenuTool) ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["gridContext"]).Tools)["PRINT"].SharedProps.Visible = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(context.Cells["trxtype"].Value.ToString(), "D", false) != 0;
  }

  private void MgaButton1_Click(object sender, EventArgs e)
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
      ExcelExport.ToExcel(this.GenerateExcelDataSet(), this.filePathName);
      Process.Start(this.filePathName);
    }
    catch (IOException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      int num = (int) MessageBox.Show("The Excel file could not be saved. Please ensure the file is not open in Excel and locked.", "File Canot be Accessed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      ProjectData.ClearProjectError();
    }
  }

  public virtual DataSet GenerateExcelDataSet()
  {
    DataSet excelDataSet = new DataSet();
    DataTable table1 = new DataTable();
    DataTable table2 = new DataTable();
    string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select dbo.GetBankName(@glacctid)", new object[2]
    {
      (object) "@glacctid",
      (object) this._bankGlAccountId
    });
    table2.Columns.Add("Bank Name", typeof (string));
    table2.Columns.Add("Reconciliation Date", typeof (DateTime));
    table2.Rows.Add((object) str, (object) this._currentdate);
    table2.Rows.Add((object) "Please see Sheet 2 for raw data.");
    excelDataSet.Tables.Add(table2);
    foreach (UltraGridColumn column in ((UltraGridBase) this.gridTransactions).DisplayLayout.Bands[0].Columns)
    {
      if (!column.Hidden & (object) column.Key != (object) "Select")
        table1.Columns.Add(column.Key, column.DataType);
    }
    foreach (UltraGridRow row1 in ((UltraGridBase) this.gridTransactions).Rows)
    {
      DataRow row2 = table1.NewRow();
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
      table1.Rows.Add(row2);
    }
    excelDataSet.Tables.Add(table1);
    return excelDataSet;
  }
}
