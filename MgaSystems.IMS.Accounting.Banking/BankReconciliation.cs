// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Banking.BankReconciliation
// Assembly: MgaSystems.IMS.Accounting.Banking, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: ED5B99DC-3DD2-44AB-BA36-49A11A94937D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Banking.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using Infragistics.Win.UltraWinSchedule;
using Infragistics.Win.UltraWinSchedule.CalendarCombo;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Banking.Interfaces;
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
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Banking;

public sealed class BankReconciliation : UserControl, IOperatingExpenseControl
{
  private IContainer components;
  private int mBankGLAccountID;
  private DateTime mFromDate;
  private DateTime mToDate;
  private DataSet ds;
  private Graphics gfx;
  private Font hdrFont1;
  private Font hdrFont2;
  private Font bodyFont1;
  private Font bodyFont2;
  private Pen linePen;
  private SizeF stringSize;
  private int yPosition;
  private Decimal decBalance;
  private bool cancelPaint;
  private bool firstPaint;
  private bool controlsAdded;
  private int _glCompanyID;
  private const int PanelWidth = 760;
  private const string HeaderString = "IMS Accounting Bank Reconciliation";
  private const int yBuffer = 10;
  private const int xBuffer = 10;

  public BankReconciliation()
  {
    this.Load += new EventHandler(this.frmReconcile_Load);
    this.hdrFont1 = new Font("Arial", 10f, FontStyle.Bold);
    this.hdrFont2 = new Font("Arial", 8f, FontStyle.Regular);
    this.bodyFont1 = new Font("Tahoma", 8f, FontStyle.Bold);
    this.bodyFont2 = new Font("Tahoma", 8f, FontStyle.Regular);
    this.linePen = new Pen(Color.SteelBlue, 2f);
    this.stringSize = new SizeF();
    this.yPosition = 2;
    this.cancelPaint = false;
    this.firstPaint = true;
    this.controlsAdded = false;
    this._glCompanyID = -1;
    this.InitializeComponent();
  }

  public BankReconciliation(int GLCompanyID)
  {
    this.Load += new EventHandler(this.frmReconcile_Load);
    this.hdrFont1 = new Font("Arial", 10f, FontStyle.Bold);
    this.hdrFont2 = new Font("Arial", 8f, FontStyle.Regular);
    this.bodyFont1 = new Font("Tahoma", 8f, FontStyle.Bold);
    this.bodyFont2 = new Font("Tahoma", 8f, FontStyle.Regular);
    this.linePen = new Pen(Color.SteelBlue, 2f);
    this.stringSize = new SizeF();
    this.yPosition = 2;
    this.cancelPaint = false;
    this.firstPaint = true;
    this.controlsAdded = false;
    this._glCompanyID = -1;
    this.InitializeComponent();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("ContextMenu1")]
  internal virtual ContextMenu ContextMenu1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MenuItem mnuAllDeposits
  {
    get => this._mnuAllDeposits;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuAllDeposits_Click);
      MenuItem mnuAllDeposits1 = this._mnuAllDeposits;
      if (mnuAllDeposits1 != null)
        mnuAllDeposits1.Click -= eventHandler;
      this._mnuAllDeposits = value;
      MenuItem mnuAllDeposits2 = this._mnuAllDeposits;
      if (mnuAllDeposits2 == null)
        return;
      mnuAllDeposits2.Click += eventHandler;
    }
  }

  internal virtual MenuItem mnuAllDisbursements
  {
    get => this._mnuAllDisbursements;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.mnuAllDisbursements_Click);
      MenuItem allDisbursements1 = this._mnuAllDisbursements;
      if (allDisbursements1 != null)
        allDisbursements1.Click -= eventHandler;
      this._mnuAllDisbursements = value;
      MenuItem allDisbursements2 = this._mnuAllDisbursements;
      if (allDisbursements2 == null)
        return;
      allDisbursements2.Click += eventHandler;
    }
  }

  internal virtual Panel panelReconcile
  {
    get => this._panelReconcile;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      PaintEventHandler paintEventHandler = new PaintEventHandler(this.panelReconcile_Paint);
      InvalidateEventHandler invalidateEventHandler = new InvalidateEventHandler(this.panelReconcile_Invalidated);
      Panel panelReconcile1 = this._panelReconcile;
      if (panelReconcile1 != null)
      {
        panelReconcile1.Paint -= paintEventHandler;
        panelReconcile1.Invalidated -= invalidateEventHandler;
      }
      this._panelReconcile = value;
      Panel panelReconcile2 = this._panelReconcile;
      if (panelReconcile2 == null)
        return;
      panelReconcile2.Paint += paintEventHandler;
      panelReconcile2.Invalidated += invalidateEventHandler;
    }
  }

  [field: AccessedThroughProperty("panelLoading")]
  internal virtual Panel panelLoading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("upbLoading")]
  internal virtual UltraProgressBar upbLoading { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDateFrom")]
  internal virtual UltraCalendarCombo dtDateFrom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtDateTo")]
  internal virtual UltraCalendarCombo dtDateTo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnGetBankRec
  {
    get => this._btnGetBankRec;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGetBankRec_Click);
      Button btnGetBankRec1 = this._btnGetBankRec;
      if (btnGetBankRec1 != null)
        btnGetBankRec1.Click -= eventHandler;
      this._btnGetBankRec = value;
      Button btnGetBankRec2 = this._btnGetBankRec;
      if (btnGetBankRec2 == null)
        return;
      btnGetBankRec2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cmbBankAccounts")]
  internal virtual UltraCombo cmbBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsBankAccounts1")]
  internal virtual dsBankAccounts DsBankAccounts1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daGetBankAccounts")]
  internal virtual SqlDataAdapter daGetBankAccounts { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand1")]
  internal virtual SqlCommand SqlSelectCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ControlDataConnection")]
  internal virtual SqlConnection ControlDataConnection { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    Appearance appearance = new Appearance();
    DateButton dateButton1 = new DateButton();
    DateButton dateButton2 = new DateButton();
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_GetBankAccounts", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GLACCTID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("BANKNAME");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CLOSED");
    this.ContextMenu1 = new ContextMenu();
    this.mnuAllDeposits = new MenuItem();
    this.mnuAllDisbursements = new MenuItem();
    this.panelReconcile = new Panel();
    this.panelLoading = new Panel();
    this.upbLoading = new UltraProgressBar();
    this.Label1 = new Label();
    this.Panel1 = new Panel();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.btnGetBankRec = new Button();
    this.dtDateTo = new UltraCalendarCombo();
    this.dtDateFrom = new UltraCalendarCombo();
    this.cmbBankAccounts = new UltraCombo();
    this.DsBankAccounts1 = new dsBankAccounts();
    this.Label2 = new Label();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ControlDataConnection = new SqlConnection();
    this.panelLoading.SuspendLayout();
    this.Panel1.SuspendLayout();
    ((ISupportInitialize) this.dtDateTo).BeginInit();
    ((ISupportInitialize) this.dtDateFrom).BeginInit();
    ((ISupportInitialize) this.cmbBankAccounts).BeginInit();
    this.DsBankAccounts1.BeginInit();
    this.SuspendLayout();
    this.ContextMenu1.MenuItems.AddRange(new MenuItem[2]
    {
      this.mnuAllDeposits,
      this.mnuAllDisbursements
    });
    this.mnuAllDeposits.Index = 0;
    this.mnuAllDeposits.Text = "Reconcile All Deposits";
    this.mnuAllDisbursements.Index = 1;
    this.mnuAllDisbursements.Text = "Reconcilie All Disbursements";
    this.panelReconcile.AutoScroll = true;
    this.panelReconcile.BackColor = Color.White;
    this.panelReconcile.BorderStyle = BorderStyle.FixedSingle;
    this.panelReconcile.ContextMenu = this.ContextMenu1;
    this.panelReconcile.Dock = DockStyle.Fill;
    this.panelReconcile.Location = new Point(0, 0);
    this.panelReconcile.Name = "panelReconcile";
    this.panelReconcile.Size = new Size(984, 584);
    this.panelReconcile.TabIndex = 2;
    this.panelLoading.AutoScroll = true;
    this.panelLoading.BackColor = Color.White;
    this.panelLoading.BorderStyle = BorderStyle.FixedSingle;
    this.panelLoading.Controls.Add((Control) this.upbLoading);
    this.panelLoading.Controls.Add((Control) this.Label1);
    this.panelLoading.Dock = DockStyle.Fill;
    this.panelLoading.Location = new Point(0, 0);
    this.panelLoading.Name = "panelLoading";
    this.panelLoading.Size = new Size(984, 584);
    this.panelLoading.TabIndex = 3;
    appearance.BackColor2 = SystemColors.ControlDark;
    this.upbLoading.FillAppearance = (AppearanceBase) appearance;
    ((Control) this.upbLoading).Location = new Point(264, 272);
    ((Control) this.upbLoading).Name = "upbLoading";
    ((Control) this.upbLoading).Size = new Size(448, 23);
    ((Control) this.upbLoading).TabIndex = 1;
    this.upbLoading.Text = "[Formatted]";
    this.Label1.Font = new Font("Tahoma", 10f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = SystemColors.ControlDark;
    this.Label1.Location = new Point(264, 248);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(440, 48 /*0x30*/);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Loading Bank Reconciliation..";
    this.Panel1.BackColor = Color.WhiteSmoke;
    this.Panel1.Controls.Add((Control) this.Label4);
    this.Panel1.Controls.Add((Control) this.Label3);
    this.Panel1.Controls.Add((Control) this.btnGetBankRec);
    this.Panel1.Controls.Add((Control) this.dtDateTo);
    this.Panel1.Controls.Add((Control) this.dtDateFrom);
    this.Panel1.Controls.Add((Control) this.cmbBankAccounts);
    this.Panel1.Controls.Add((Control) this.Label2);
    this.Panel1.Dock = DockStyle.Bottom;
    this.Panel1.Location = new Point(0, 584);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(984, 64 /*0x40*/);
    this.Panel1.TabIndex = 4;
    this.Label4.BackColor = Color.Black;
    this.Label4.Location = new Point(232, 40);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(42, 2);
    this.Label4.TabIndex = 6;
    this.Label4.Text = "-";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(8, 32 /*0x20*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(108, 16 /*0x10*/);
    this.Label3.TabIndex = 5;
    this.Label3.Text = "Specify Date Range:";
    this.btnGetBankRec.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.btnGetBankRec.FlatStyle = FlatStyle.Flat;
    this.btnGetBankRec.Location = new Point(840, 32 /*0x20*/);
    this.btnGetBankRec.Name = "btnGetBankRec";
    this.btnGetBankRec.Size = new Size(136, 22);
    this.btnGetBankRec.TabIndex = 4;
    this.btnGetBankRec.Text = "Get Bank Information";
    dateButton1.Caption = "Today";
    this.dtDateTo.DateButtons.Add(dateButton1);
    ((Control) this.dtDateTo).Location = new Point(280, 32 /*0x20*/);
    ((Control) this.dtDateTo).Name = "dtDateTo";
    this.dtDateTo.NonAutoSizeHeight = 23;
    ((Control) this.dtDateTo).Size = new Size(88, 21);
    ((Control) this.dtDateTo).TabIndex = 3;
    dateButton2.Caption = "Today";
    this.dtDateFrom.DateButtons.Add(dateButton2);
    ((Control) this.dtDateFrom).Location = new Point(128 /*0x80*/, 32 /*0x20*/);
    ((Control) this.dtDateFrom).Name = "dtDateFrom";
    this.dtDateFrom.NonAutoSizeHeight = 23;
    ((Control) this.dtDateFrom).Size = new Size(96 /*0x60*/, 21);
    ((Control) this.dtDateFrom).TabIndex = 2;
    this.cmbBankAccounts.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.cmbBankAccounts).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.cmbBankAccounts).DataSource = (object) this.DsBankAccounts1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 63 /*0x3F*/;
    ultraGridColumn2.Width = 205;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 57;
    ultraGridBand.Columns.Add((object) ultraGridColumn1);
    ultraGridBand.Columns.Add((object) ultraGridColumn2);
    ultraGridBand.Columns.Add((object) ultraGridColumn3);
    ultraGridBand.GroupHeadersVisible = false;
    ultraGridBand.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ultraGridBand.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.cmbBankAccounts).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.cmbBankAccounts).DisplayMember = "BANKNAME";
    this.cmbBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cmbBankAccounts).Location = new Point(128 /*0x80*/, 8);
    ((Control) this.cmbBankAccounts).Name = "cmbBankAccounts";
    ((Control) this.cmbBankAccounts).Size = new Size(240 /*0xF0*/, 21);
    ((Control) this.cmbBankAccounts).TabIndex = 1;
    ((UltraDropDownBase) this.cmbBankAccounts).ValueMember = "GLACCTID";
    this.DsBankAccounts1.DataSetName = "dsBankAccounts";
    this.DsBankAccounts1.Locale = new CultureInfo("en-US");
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 8);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(77, 16 /*0x10*/);
    this.Label2.TabIndex = 0;
    this.Label2.Text = "Bank Account:";
    this.daGetBankAccounts.SelectCommand = this.SqlSelectCommand1;
    this.daGetBankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccounts", new DataColumnMapping[3]
      {
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("BANKNAME", "BANKNAME"),
        new DataColumnMapping("CLOSED", "CLOSED")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetBankAccounts]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.ControlDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4));
    this.ControlDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.Controls.Add((Control) this.panelLoading);
    this.Controls.Add((Control) this.panelReconcile);
    this.Controls.Add((Control) this.Panel1);
    this.Name = nameof (BankReconciliation);
    this.Size = new Size(984, 648);
    this.panelLoading.ResumeLayout(false);
    this.Panel1.ResumeLayout(false);
    ((ISupportInitialize) this.dtDateTo).EndInit();
    ((ISupportInitialize) this.dtDateFrom).EndInit();
    ((ISupportInitialize) this.cmbBankAccounts).EndInit();
    this.DsBankAccounts1.EndInit();
    this.ResumeLayout(false);
  }

  public int BankGLAccountID
  {
    get => this.mBankGLAccountID;
    set => this.mBankGLAccountID = value;
  }

  public DateTime FromDate
  {
    get => this.mFromDate;
    set => this.mFromDate = value;
  }

  public DateTime ToDate
  {
    get => this.mToDate;
    set => this.mToDate = value;
  }

  public int GLCompanyID
  {
    get => this._glCompanyID;
    set => this._glCompanyID = value;
  }

  private void LoadData()
  {
    SqlCommand selectCommand = new SqlCommand("spFin_ReconcileBankAccount", new SqlConnection(CurrentUser.Instance.ConnectionString));
    selectCommand.CommandType = CommandType.StoredProcedure;
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    selectCommand.Parameters.AddWithValue("@fromdate", (object) this.FromDate);
    selectCommand.Parameters.AddWithValue("@todate", (object) this.ToDate);
    selectCommand.Parameters.AddWithValue("@glacctid", (object) this.BankGLAccountID);
    try
    {
      this.ds = new DataSet();
      sqlDataAdapter.Fill(this.ds);
    }
    finally
    {
      selectCommand.Connection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  private void DrawReconciliationReport()
  {
    if (this.ds == null)
      return;
    this.DrawBankInformation();
    this.DrawBankRecHeader();
    this.DrawStartingBalance();
  }

  private void DrawBankInformation()
  {
    if (this.ds.Tables[0].Rows.Count == 0)
      return;
    DataRow row1 = this.ds.Tables[0].Rows[0];
    Graphics gfx = this.gfx;
    gfx.DrawString(row1[1].ToString(), this.hdrFont1, SystemBrushes.ControlText, 10f, (float) this.GetY());
    gfx.DrawString(string.Format("Acct #: " + row1["bankacctnum"].ToString()), this.hdrFont1, SystemBrushes.ControlText, (float) (720 - (int) Math.Round((double) gfx.MeasureString(string.Format("Acct #: " + row1["bankacctnum"].ToString()), this.hdrFont1).Width)), (float) this.GetY());
    // ISSUE: variable of a reference type
    int& local1;
    // ISSUE: explicit reference operation
    int num1 = ^(local1 = ref this.yPosition) + (int) Math.Round((double) gfx.MeasureString(row1[1].ToString(), this.hdrFont1).Height);
    local1 = num1;
    DataRow row2 = this.ds.Tables[1].Rows[0];
    gfx.DrawString($"Statement Date: '{Strings.Format((object) row2[1].ToString(), "Short Date")}' - '{Strings.Format((object) row2[2].ToString(), "Short Date")}'", this.hdrFont2, SystemBrushes.ControlText, 10f, (float) this.GetY());
    // ISSUE: variable of a reference type
    int& local2;
    // ISSUE: explicit reference operation
    int num2 = ^(local2 = ref this.yPosition) + (int) Math.Round((double) gfx.MeasureString($"Statement Date: '{Strings.Format((object) row2[1].ToString(), "Short Date")}' - '{Strings.Format((object) row2[2].ToString(), "Short Date")}'", this.hdrFont2).Height);
    local2 = num2;
  }

  private void DrawBankRecHeader()
  {
    SizeF sizeF1 = new SizeF();
    Graphics gfx = this.gfx;
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = ^(local = ref this.yPosition) + 2;
    local = num;
    gfx.DrawLine(this.linePen, 10, this.GetY(), 735, this.GetY());
    SizeF sizeF2 = gfx.MeasureString("IMS Accounting Bank Reconciliation", this.hdrFont1);
    gfx.DrawString("IMS Accounting Bank Reconciliation", this.hdrFont1, SystemBrushes.ControlDarkDark, 720f - sizeF2.Width, (float) this.GetY() - (sizeF2.Height + 2f));
  }

  private void DrawStartingBalance()
  {
    // ISSUE: variable of a reference type
    int& local1;
    // ISSUE: explicit reference operation
    int num1 = ^(local1 = ref this.yPosition) + 10;
    local1 = num1;
    DataRow row = this.ds.Tables[1].Rows[0];
    Graphics gfx = this.gfx;
    SizeF sizeF1 = gfx.MeasureString("Deposits", this.bodyFont1);
    gfx.DrawString("Deposits", this.bodyFont1, SystemBrushes.ControlText, 380f - sizeF1.Width, (float) this.GetY());
    SizeF sizeF2 = gfx.MeasureString("Disbursements", this.bodyFont1);
    gfx.DrawString("Disbursements", this.bodyFont1, SystemBrushes.ControlText, 570f - sizeF2.Width, (float) this.GetY());
    SizeF sizeF3 = gfx.MeasureString("Balance", this.bodyFont1);
    gfx.DrawString("Balance", this.bodyFont1, SystemBrushes.ControlText, 720f - sizeF3.Width, (float) this.GetY());
    // ISSUE: variable of a reference type
    int& local2;
    // ISSUE: explicit reference operation
    int num2 = ^(local2 = ref this.yPosition) + (int) Math.Round((double) gfx.MeasureString("Disbursements", this.bodyFont1).Height);
    local2 = num2;
    gfx.DrawString($"Balance as of {Strings.Format((object) DateAndTime.DateAdd(DateInterval.Day, -1.0, Conversions.ToDate(row[1])), "Short Date")}", this.bodyFont1, SystemBrushes.HotTrack, 10f, (float) this.GetY());
    SizeF sizeF4 = gfx.MeasureString(Strings.Format((object) Conversions.ToDecimal(row[0]), "Currency"), this.bodyFont2);
    gfx.DrawString(Strings.Format((object) Conversions.ToDecimal(row[0]), "Currency"), this.bodyFont2, SystemBrushes.HotTrack, 720f - sizeF4.Width, (float) this.GetY());
    // ISSUE: variable of a reference type
    int& local3;
    // ISSUE: explicit reference operation
    int num3 = ^(local3 = ref this.yPosition) + (int) Math.Round((double) gfx.MeasureString($"Balance as of {Strings.Format((object) DateAndTime.DateAdd(DateInterval.Day, 1.0, Conversions.ToDate(row[1])), "Short Date")}", this.bodyFont1).Height);
    local3 = num3;
    this.decBalance = Conversions.ToDecimal(row[0]);
  }

  private void DrawEntries()
  {
    this.upbLoading.Value = 0;
    this.panelReconcile.Controls.Clear();
    int num1 = this.ds.Tables[2].Rows.Count + this.ds.Tables[3].Rows.Count;
    this.upbLoading.Maximum = num1;
    int num2;
    for (; num2 < num1; ++num2)
    {
      UltraProgressBar upbLoading;
      int num3 = (upbLoading = this.upbLoading).Value + 1;
      upbLoading.Value = num3;
      ((UltraControlBase) this.upbLoading).Refresh();
      int index1;
      int index2;
      if (index1 + 1 <= this.ds.Tables[2].Rows.Count && index2 + 1 <= this.ds.Tables[3].Rows.Count)
      {
        switch (DateTime.Compare(Conversions.ToDate(this.ds.Tables[2].Rows[index1]["trxdate"]), Conversions.ToDate(this.ds.Tables[3].Rows[index2]["trxdate"])))
        {
          case 0:
            this.DrawEntry(this.ds.Tables[2].Rows[index1], BankReconciliation.EntryType.Deposit);
            ++index1;
            continue;
          case 1:
            this.DrawEntry(this.ds.Tables[3].Rows[index2], BankReconciliation.EntryType.Disbursement);
            ++index2;
            continue;
          default:
            this.DrawEntry(this.ds.Tables[2].Rows[index1], BankReconciliation.EntryType.Deposit);
            ++index1;
            continue;
        }
      }
      else if (index1 + 1 <= this.ds.Tables[2].Rows.Count)
      {
        this.DrawEntry(this.ds.Tables[2].Rows[index1], BankReconciliation.EntryType.Deposit);
        ++index1;
      }
      else
      {
        this.DrawEntry(this.ds.Tables[3].Rows[index2], BankReconciliation.EntryType.Disbursement);
        ++index2;
      }
    }
    this.DrawTransactionSummary();
    this.firstPaint = true;
    this.controlsAdded = true;
    this.cancelPaint = false;
    this.panelReconcile.Refresh();
  }

  private void DrawEntry(DataRow dr, BankReconciliation.EntryType eType)
  {
    CheckBox checkBox1 = new CheckBox();
    Label label1 = new Label();
    switch (eType)
    {
      case BankReconciliation.EntryType.Deposit:
        CheckBox checkBox2 = checkBox1;
        checkBox2.Name = "D" + dr["transactnum"].ToString();
        checkBox2.Text = Strings.Format(RuntimeHelpers.GetObjectValue(dr["amount"]), "Currency");
        checkBox2.CheckAlign = ContentAlignment.MiddleRight;
        checkBox2.FlatStyle = FlatStyle.Flat;
        checkBox2.Tag = RuntimeHelpers.GetObjectValue(dr["transactnum"]);
        checkBox2.Size = new Size(100, 16 /*0x10*/);
        checkBox2.BackColor = this.panelReconcile.BackColor;
        checkBox2.ForeColor = SystemColors.ControlText;
        checkBox2.Location = new Point(380 - checkBox1.Width, this.GetY());
        checkBox2.Font = this.bodyFont2;
        checkBox2.Checked = Conversions.ToBoolean(dr["reconciled"]);
        checkBox2.Enabled = !Conversions.ToBoolean(dr["reconciled"]);
        Label label2 = label1;
        label2.Text = Strings.Format((object) Conversions.ToDate(dr["trxdate"]), "MM/dd/yyyy");
        label2.Font = this.bodyFont2;
        label2.ForeColor = SystemColors.ControlText;
        label2.AutoSize = true;
        label2.Location = new Point(10, this.GetY());
        this.DrawBalanceAmount(Conversions.ToDecimal(dr["amount"]));
        this.panelReconcile.Controls.Add((Control) label1);
        this.panelReconcile.Controls.Add((Control) checkBox1);
        // ISSUE: variable of a reference type
        int& local1;
        // ISSUE: explicit reference operation
        int num1 = ^(local1 = ref this.yPosition) + checkBox1.Size.Height;
        local1 = num1;
        break;
      case BankReconciliation.EntryType.Disbursement:
        CheckBox checkBox3 = checkBox1;
        checkBox3.Name = "P" + dr["transactnum"].ToString();
        checkBox3.Text = Strings.Format((object) Decimal.Multiply(Conversions.ToDecimal(dr["amount"]), -1M), "Currency");
        checkBox3.CheckAlign = ContentAlignment.MiddleRight;
        checkBox3.FlatStyle = FlatStyle.Flat;
        checkBox3.Tag = RuntimeHelpers.GetObjectValue(dr["transactnum"]);
        checkBox3.Size = new Size(100, 16 /*0x10*/);
        checkBox3.BackColor = this.panelReconcile.BackColor;
        checkBox3.ForeColor = SystemColors.ControlText;
        checkBox3.Location = new Point(570 - checkBox1.Width, this.GetY());
        checkBox3.Font = this.bodyFont2;
        checkBox3.Checked = Conversions.ToBoolean(dr["reconciled"]);
        checkBox3.Enabled = !Conversions.ToBoolean(dr["reconciled"]);
        Label label3 = label1;
        label3.Text = $"{Strings.Format((object) Conversions.ToDate(dr["trxdate"]), "MM/dd/yyyy")}-{Conversions.ToString(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr["paymethodid"].ToString(), "C", false) == 0, (object) ("Check # " + dr["checknum"].ToString()), (object) dr["paidto"].ToString()))} ({Conversions.ToString(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dr["paymethodid"].ToString(), "C", false) == 0, (object) dr["paidto"].ToString(), (object) ""))})";
        label3.Font = this.bodyFont2;
        label3.ForeColor = SystemColors.ControlText;
        label3.AutoSize = true;
        label3.Location = new Point(10, this.GetY());
        this.DrawBalanceAmount(Decimal.Multiply(Conversions.ToDecimal(dr["amount"]), -1M));
        this.panelReconcile.Controls.Add((Control) label1);
        this.panelReconcile.Controls.Add((Control) checkBox1);
        // ISSUE: variable of a reference type
        int& local2;
        // ISSUE: explicit reference operation
        int num2 = ^(local2 = ref this.yPosition) + checkBox1.Size.Height;
        local2 = num2;
        break;
    }
  }

  private void DrawTransactionSummary()
  {
    // ISSUE: variable of a reference type
    int& local1;
    // ISSUE: explicit reference operation
    int num1 = ^(local1 = ref this.yPosition) + 10;
    local1 = num1;
    Label label1 = new Label();
    Label label2 = label1;
    label2.Text = "Transaction Summary";
    label2.Font = this.bodyFont1;
    label2.ForeColor = SystemColors.ControlDark;
    label2.Location = new Point(10, this.GetY());
    label2.AutoSize = true;
    this.panelReconcile.Controls.Add((Control) label1);
    Label label3 = new Label();
    Label label4 = label3;
    label4.AutoSize = true;
    label4.Text = "Fees and Interest";
    label4.Font = this.bodyFont1;
    label4.ForeColor = SystemColors.ControlDark;
    label4.Location = new Point(720 - label3.Width, this.GetY());
    this.panelReconcile.Controls.Add((Control) label3);
    // ISSUE: variable of a reference type
    int& local2;
    // ISSUE: explicit reference operation
    int num2 = ^(local2 = ref this.yPosition) + label3.Height;
    local2 = num2;
    Label label5 = new Label();
    Label label6 = label5;
    label6.AutoSize = true;
    label6.Text = "Deposits Summary........" + Strings.Format((object) this.GetDepositsSum(), "Currency");
    label6.Font = this.bodyFont2;
    label6.ForeColor = SystemColors.ControlText;
    label6.Location = new Point(10, this.GetY());
    this.panelReconcile.Controls.Add((Control) label5);
    Label label7 = new Label();
    Label label8 = label7;
    label8.AutoSize = true;
    label8.Text = "Fees:";
    label8.Font = this.bodyFont2;
    label8.ForeColor = SystemColors.ControlText;
    label8.Location = new Point(720 - (label7.Width + 106), this.GetY());
    this.panelReconcile.Controls.Add((Control) label7);
    TextBox textBox1 = new TextBox();
    TextBox textBox2 = textBox1;
    textBox2.Size = new Size(100, 20);
    textBox2.Name = "txtFees";
    textBox2.BorderStyle = BorderStyle.FixedSingle;
    textBox2.TextAlign = HorizontalAlignment.Right;
    textBox2.Text = "$0.00";
    textBox2.ForeColor = SystemColors.ControlText;
    textBox2.Location = new Point(720 - textBox1.Width, this.GetY());
    textBox1.Leave += new EventHandler(this.VerifyAndFormatText);
    this.panelReconcile.Controls.Add((Control) textBox1);
    // ISSUE: variable of a reference type
    int& local3;
    // ISSUE: explicit reference operation
    int num3 = ^(local3 = ref this.yPosition) + (textBox1.Height + 2);
    local3 = num3;
    Label label9 = new Label();
    Label label10 = label9;
    label10.AutoSize = true;
    label10.Text = "Disbursements Summary..." + Strings.Format((object) Decimal.Multiply(this.GetDisbursementsSum(), -1M), "Currency");
    label10.Font = this.bodyFont2;
    label10.ForeColor = SystemColors.ControlText;
    label10.Location = new Point(10, this.GetY());
    this.panelReconcile.Controls.Add((Control) label9);
    Label label11 = new Label();
    Label label12 = label11;
    label12.AutoSize = true;
    label12.Text = "Interest:";
    label12.Font = this.bodyFont2;
    label12.ForeColor = SystemColors.ControlText;
    label12.Location = new Point(720 - (label11.Width + 106), this.GetY());
    this.panelReconcile.Controls.Add((Control) label11);
    TextBox textBox3 = new TextBox();
    TextBox textBox4 = textBox3;
    textBox4.Size = new Size(100, 20);
    textBox4.Name = "txtInterest";
    textBox4.BorderStyle = BorderStyle.FixedSingle;
    textBox4.TextAlign = HorizontalAlignment.Right;
    textBox4.Text = "$0.00";
    textBox4.ForeColor = SystemColors.ControlText;
    textBox4.Location = new Point(720 - textBox3.Width, this.GetY());
    textBox3.Leave += new EventHandler(this.VerifyAndFormatText);
    this.panelReconcile.Controls.Add((Control) textBox3);
    // ISSUE: variable of a reference type
    int& local4;
    // ISSUE: explicit reference operation
    int num4 = ^(local4 = ref this.yPosition) + (textBox3.Height + 2);
    local4 = num4;
    Label label13 = new Label();
    Label label14 = label13;
    label14.Size = new Size(210, 1);
    label14.BorderStyle = BorderStyle.FixedSingle;
    label14.BackColor = SystemColors.ControlText;
    label14.Location = new Point(520, this.GetY());
    this.panelReconcile.Controls.Add((Control) label13);
    // ISSUE: variable of a reference type
    int& local5;
    // ISSUE: explicit reference operation
    int num5 = ^(local5 = ref this.yPosition) + 4;
    local5 = num5;
    Label label15 = new Label();
    Label label16 = label15;
    label16.AutoSize = true;
    label16.Text = "Balance:";
    label16.Font = this.bodyFont2;
    label16.ForeColor = SystemColors.ControlText;
    label16.Location = new Point(720 - (label15.Width + 106), this.GetY());
    this.panelReconcile.Controls.Add((Control) label15);
    TextBox textBox5 = new TextBox();
    TextBox textBox6 = textBox5;
    textBox6.Size = new Size(100, 20);
    textBox6.Name = "txtFeesInterestBalance";
    textBox6.BorderStyle = BorderStyle.FixedSingle;
    textBox6.TextAlign = HorizontalAlignment.Right;
    textBox6.Text = "$0.00";
    textBox6.ReadOnly = true;
    textBox6.TabStop = false;
    textBox6.ForeColor = SystemColors.ControlText;
    textBox6.Location = new Point(720 - textBox5.Width, this.GetY());
    this.panelReconcile.Controls.Add((Control) textBox5);
    // ISSUE: variable of a reference type
    int& local6;
    // ISSUE: explicit reference operation
    int num6 = ^(local6 = ref this.yPosition) + (textBox5.Height + 6);
    local6 = num6;
    Button button1 = new Button();
    Button button2 = button1;
    button2.Size = new Size(120, 20);
    button2.Text = "Post Reconciliation..";
    button2.Name = "btnPost";
    button2.FlatStyle = FlatStyle.Flat;
    button2.ForeColor = SystemColors.ControlText;
    button2.Location = new Point(720 - button1.Width, this.GetY());
    this.panelReconcile.Controls.Add((Control) button1);
    button1.Click += new EventHandler(this.PostReconcile);
    // ISSUE: variable of a reference type
    int& local7;
    // ISSUE: explicit reference operation
    int num7 = ^(local7 = ref this.yPosition) + (button1.Height + 4);
    local7 = num7;
    Label label17 = new Label();
    Label label18 = label17;
    label18.Size = new Size(1, 16 /*0x10*/);
    label18.Text = "";
    label18.Font = this.bodyFont2;
    label18.ForeColor = this.panelReconcile.BackColor;
    label18.Location = new Point(10, this.GetY());
    this.panelReconcile.Controls.Add((Control) label17);
  }

  private void DrawBalanceAmount(Decimal decAmount)
  {
    // ISSUE: variable of a reference type
    Decimal& local;
    // ISSUE: explicit reference operation
    Decimal num = Decimal.Add(^(local = ref this.decBalance), decAmount);
    local = num;
    Label label1 = new Label();
    Label label2 = label1;
    label2.Text = Strings.Format((object) this.decBalance, "Currency").ToString();
    label2.Font = this.bodyFont2;
    if (Decimal.Compare(this.decBalance, 0M) > 0)
      label2.ForeColor = SystemColors.ControlText;
    else
      label2.ForeColor = Color.Red;
    label2.Size = new Size(120, 16 /*0x10*/);
    label2.TextAlign = ContentAlignment.MiddleRight;
    label2.Location = new Point(720 - label2.Width, this.GetY());
    this.panelReconcile.Controls.Add((Control) label1);
  }

  private int GetY() => this.yPosition + 10;

  private void ResetYPosition() => this.yPosition = this.panelReconcile.AutoScrollPosition.Y + 2;

  private Decimal GetDepositsSum()
  {
    return this.ds.Tables[2].Rows.Count != 0 ? Conversions.ToDecimal(this.ds.Tables[2].Compute("Sum(amount)", "")) : 0M;
  }

  private Decimal GetDisbursementsSum()
  {
    return this.ds.Tables[3].Rows.Count != 0 ? Conversions.ToDecimal(this.ds.Tables[3].Compute("Sum(amount)", "")) : 0M;
  }

  private void VerifyAndFormatText(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) sender).Name, "txtFees", false) == 0)
    {
      if (!Versioned.IsNumeric((object) ((TextBox) sender).Text))
      {
        this.Cursor = Cursors.Default;
        int num = (int) MessageBox.Show("Fees amount must be numeric!", "Invlid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((Control) sender).Focus();
        return;
      }
      ((TextBox) sender).Text = Strings.Format((object) ((TextBox) sender).Text, "Currency");
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) sender).Name, "txtInterest", false) == 0)
    {
      if (!Versioned.IsNumeric((object) ((TextBox) sender).Text))
      {
        this.Cursor = Cursors.Default;
        int num = (int) MessageBox.Show("Interest amount must be numeric!", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ((Control) sender).Focus();
        return;
      }
      ((TextBox) sender).Text = Strings.Format((object) ((TextBox) sender).Text, "Currency");
    }
    try
    {
      foreach (Control control in this.panelReconcile.Controls)
      {
        if (control is TextBox)
        {
          Decimal num;
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "txtFees", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "txtInterest", false) == 0)
            num = Decimal.Add(num, Conversions.ToDecimal(control.Text));
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "txtFeesInterestBalance", false) == 0)
            control.Text = Strings.Format((object) num, "Currency");
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Cursor = Cursors.Default;
  }

  private void InitGraphics()
  {
    this.gfx.Clip = new Region(this.panelReconcile.RectangleToScreen(new Rectangle()));
  }

  private void frmReconcile_Load(object sender, EventArgs e)
  {
    this.SetStyle(ControlStyles.ResizeRedraw, true);
    this.SetStyle(ControlStyles.DoubleBuffer, true);
    this.Dock = DockStyle.Fill;
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetBankAccounts.SelectCommand.Parameters["@GLCOMPANYID"].Value = (object) this.GLCompanyID;
    this.daGetBankAccounts.Fill((DataTable) this.DsBankAccounts1.spFin_GetBankAccounts);
  }

  private void panelReconcile_Paint(object sender, PaintEventArgs e)
  {
    if (this.ds == null)
    {
      this.panelLoading.SendToBack();
    }
    else
    {
      this.ResetYPosition();
      this.gfx = e.Graphics;
      this.DrawReconciliationReport();
      if (this.controlsAdded)
        return;
      this.panelReconcile.SuspendLayout();
      this.panelLoading.BringToFront();
      this.DrawEntries();
      this.panelLoading.SendToBack();
      this.panelReconcile.ResumeLayout();
    }
  }

  private new void Dispose()
  {
    this.linePen.Dispose();
    this.linePen = (Pen) null;
    this.hdrFont1.Dispose();
    this.hdrFont1 = (Font) null;
    this.hdrFont2.Dispose();
    this.hdrFont2 = (Font) null;
    this.bodyFont1.Dispose();
    this.bodyFont1 = (Font) null;
    this.bodyFont2.Dispose();
    this.bodyFont2 = (Font) null;
    try
    {
      foreach (Control control in this.panelReconcile.Controls)
      {
        if (control is Button & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "btnPost", false) == 0)
          control.Click -= new EventHandler(this.PostReconcile);
        if (control is TextBox & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "txtInterest", false) == 0)
          control.Leave -= new EventHandler(this.VerifyAndFormatText);
        if (control is TextBox & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "txtFees", false) == 0)
          control.Leave -= new EventHandler(this.VerifyAndFormatText);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void mnuAllDeposits_Click(object sender, EventArgs e)
  {
    this.mnuAllDeposits.Checked = !this.mnuAllDeposits.Checked;
    try
    {
      foreach (Control control in this.panelReconcile.Controls)
      {
        if (control is CheckBox && control.Name.StartsWith("D"))
          ((CheckBox) control).Checked = this.mnuAllDeposits.Checked;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void mnuAllDisbursements_Click(object sender, EventArgs e)
  {
    this.mnuAllDisbursements.Checked = !this.mnuAllDisbursements.Checked;
    try
    {
      foreach (Control control in this.panelReconcile.Controls)
      {
        if (control is CheckBox && control.Name.StartsWith("P"))
          ((CheckBox) control).Checked = this.mnuAllDisbursements.Checked;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void panelReconcile_Invalidated(object sender, InvalidateEventArgs e)
  {
  }

  private void PostReconcile(object sender, EventArgs e)
  {
    if (!this.VerifyForm())
      return;
    this.Cursor = Cursors.WaitCursor;
    SqlCommand cmd = new SqlCommand();
    cmd.Connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    try
    {
      cmd.Connection.Open();
      cmd.Transaction = cmd.Connection.BeginTransaction();
      this.ReconcileDisbursements(cmd);
      this.ReconcileDeposits(cmd);
      this.ReconcileFees(cmd);
      this.ReconcileInterest(cmd);
      cmd.Transaction.Commit();
    }
    catch (SqlException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      if (cmd.Transaction != null)
        cmd.Transaction.Rollback();
      throw;
    }
    finally
    {
      cmd.Connection.Close();
      cmd.Connection.Dispose();
      if (cmd.Transaction != null)
        cmd.Transaction.Dispose();
      cmd.Dispose();
      this.Cursor = Cursors.Default;
    }
  }

  private void ReconcileDisbursements(SqlCommand cmd)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_ReconcileCheck";
    try
    {
      foreach (Control control in this.panelReconcile.Controls)
      {
        if (control.Enabled && control is CheckBox && control.Name.StartsWith("P") && ((CheckBox) control).Checked && control.Enabled)
        {
          cmd.Parameters.Clear();
          cmd.Parameters.AddWithValue("@transactnum", (object) Conversions.ToInteger(control.Tag));
          cmd.ExecuteNonQuery();
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

  private void ReconcileDeposits(SqlCommand cmd)
  {
    cmd.CommandType = CommandType.StoredProcedure;
    cmd.CommandText = "spFin_ReconcileDeposit";
    try
    {
      foreach (Control control in this.panelReconcile.Controls)
      {
        if (control.Enabled && control is CheckBox && control.Name.StartsWith("D") && ((CheckBox) control).Checked && control.Enabled)
        {
          cmd.Parameters.Clear();
          cmd.Parameters.AddWithValue("@transactnum", (object) Conversions.ToInteger(control.Tag));
          cmd.ExecuteNonQuery();
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

  private void ReconcileFees(SqlCommand cmd)
  {
    Decimal num;
    try
    {
      foreach (Control control in this.panelReconcile.Controls)
      {
        if (control is TextBox && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "txtFees", false) == 0)
        {
          if (Decimal.Compare(Conversions.ToDecimal(control.Text), 0M) == 0)
            return;
          num = Conversions.ToDecimal(control.Text);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    SqlCommand sqlCommand = cmd;
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.CommandText = "spFin_PostBankFees";
    sqlCommand.Parameters.Clear();
    sqlCommand.Parameters.AddWithValue("@bankaccttypeid", RuntimeHelpers.GetObjectValue(this.ds.Tables[0].Rows[0]["bankaccttypeid"]));
    sqlCommand.Parameters.AddWithValue("@bankacctnum", RuntimeHelpers.GetObjectValue(this.ds.Tables[0].Rows[0]["bankacctnum"]));
    sqlCommand.Parameters.AddWithValue("@amount", (object) num);
    sqlCommand.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
    sqlCommand.ExecuteNonQuery();
  }

  private void ReconcileInterest(SqlCommand cmd)
  {
    Decimal num;
    try
    {
      foreach (Control control in this.panelReconcile.Controls)
      {
        if (control is TextBox && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "txtInterest", false) == 0)
        {
          if (Decimal.Compare(Conversions.ToDecimal(control.Text), 0M) == 0)
            return;
          num = Conversions.ToDecimal(control.Text);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    SqlCommand sqlCommand = cmd;
    sqlCommand.CommandType = CommandType.StoredProcedure;
    sqlCommand.CommandText = "spFin_PostAccruedInterest";
    sqlCommand.Parameters.Clear();
    sqlCommand.Parameters.AddWithValue("@bankaccttypeid", RuntimeHelpers.GetObjectValue(this.ds.Tables[0].Rows[0]["bankaccttypeid"]));
    sqlCommand.Parameters.AddWithValue("@bankacctnum", RuntimeHelpers.GetObjectValue(this.ds.Tables[0].Rows[0]["bankacctnum"]));
    sqlCommand.Parameters.AddWithValue("@amount", (object) num);
    sqlCommand.Parameters.AddWithValue("@userguid", (object) CurrentUser.Instance.UserGUID);
    sqlCommand.ExecuteNonQuery();
  }

  private bool VerifyForm()
  {
    bool flag = true;
    try
    {
      foreach (Control control in this.panelReconcile.Controls)
      {
        if (control is TextBox)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "txtFees", false) == 0 && !Versioned.IsNumeric((object) control.Text))
          {
            int num = (int) MessageBox.Show("Fees amount must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            control.Focus();
            SendKeys.Send("{HOME}+{END}");
            flag = false;
            break;
          }
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(control.Name, "txtFees", false) == 0 && !Versioned.IsNumeric((object) control.Text))
          {
            int num = (int) MessageBox.Show("Interest amount must be numeric.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            control.Focus();
            SendKeys.Send("{HOME}+{END}");
            flag = false;
            break;
          }
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    return flag;
  }

  private void btnGetBankRec_Click(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.cmbBankAccounts).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        this.Cursor = Cursors.WaitCursor;
        if (this.ds != null)
        {
          this.panelReconcile.Controls.Clear();
          this.ds.Clear();
          this.ds.Dispose();
          this.ds = (DataSet) null;
          this.Refresh();
        }
        this.BankGLAccountID = Conversions.ToInteger(((UltraDropDownBase) this.cmbBankAccounts).SelectedRow.Cells["GLACCTID"].Value);
        this.FromDate = Conversions.ToDate(this.dtDateFrom.Value);
        this.ToDate = Conversions.ToDate(this.dtDateTo.Value);
        this.LoadData();
        this.controlsAdded = false;
        this.panelReconcile.Refresh();
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
  }

  public void OfficeLocationChanged(int glCompanyID)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.panelReconcile.Controls.Clear();
      this._glCompanyID = glCompanyID;
      this.daGetBankAccounts.SelectCommand.Parameters["@GLCOMPANYID"].Value = (object) this.GLCompanyID;
      this.DsBankAccounts1.Clear();
      this.daGetBankAccounts.Fill((DataTable) this.DsBankAccounts1.spFin_GetBankAccounts);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private enum EntryType
  {
    Deposit,
    Disbursement,
  }
}
