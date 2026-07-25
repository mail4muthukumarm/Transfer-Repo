// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.PolicyDetail.PolicyDetail_Transactions
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.InfragisticsExtensions.Editors;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.PolicyDetail;

[PolicyDetail_Plugin("Transactions", "Transactions")]
public class PolicyDetail_Transactions : PolicyDetail_Plugin
{
  private IContainer components;
  private dsPolicyHistory ds;
  private readonly Quote _quote;
  private HyperlinkEditor _lnk;
  private HyperlinkEditor _lnkDetail;
  private object _getProcedureNameLock;

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._lnkDetail != null)
      {
        this._lnkDetail.HyperLinkOpening -= new CancelEventHandler(this.DetailLinkClicked);
        ((DisposableObject) this._lnkDetail).Dispose();
      }
      if (this._lnk != null)
      {
        this._lnk.HyperLinkOpening -= new CancelEventHandler(this.HyperLinkOpening);
        ((DisposableObject) this._lnk).Dispose();
      }
    }
    base.Dispose(disposing);
  }

  protected virtual UltraGrid ugPolicyHistory
  {
    get => this._ugPolicyHistory;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeRowEventHandler initializeRowEventHandler = new InitializeRowEventHandler(this.ugPolicyHistory_InitializeRow);
      UltraGrid ugPolicyHistory1 = this._ugPolicyHistory;
      if (ugPolicyHistory1 != null)
        ugPolicyHistory1.InitializeRow -= initializeRowEventHandler;
      this._ugPolicyHistory = value;
      UltraGrid ugPolicyHistory2 = this._ugPolicyHistory;
      if (ugPolicyHistory2 == null)
        return;
      ugPolicyHistory2.InitializeRow += initializeRowEventHandler;
    }
  }

  private virtual LinkLabel lnkExportExcel
  {
    get => this._lnkExportExcel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkExportExcel_LinkClicked);
      LinkLabel lnkExportExcel1 = this._lnkExportExcel;
      if (lnkExportExcel1 != null)
        lnkExportExcel1.LinkClicked -= clickedEventHandler;
      this._lnkExportExcel = value;
      LinkLabel lnkExportExcel2 = this._lnkExportExcel;
      if (lnkExportExcel2 == null)
        return;
      lnkExportExcel2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("UltraGridExcelExporter1")]
  internal virtual UltraGridExcelExporter UltraGridExcelExporter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("viewPolicyHistory", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("QuoteGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Bound");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("TransactionType");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Effective");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Expiration");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("PolicyType");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Created", -1, (object) null, 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("View");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Reason");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("EndorsementComment");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("EndorsementCalcType");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("QuoteStatusComment");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Detail");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("EndorsementNum");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Amount");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.ds = new dsPolicyHistory();
    this.ugPolicyHistory = new UltraGrid();
    this.lnkExportExcel = new LinkLabel();
    this.UltraGridExcelExporter1 = new UltraGridExcelExporter(this.components);
    this.ds.BeginInit();
    ((ISupportInitialize) this.ugPolicyHistory).BeginInit();
    this.SuspendLayout();
    this.ds.DataSetName = "dsPolicyHistory";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ugPolicyHistory).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugPolicyHistory).DataSource = (object) this.ds.viewPolicyHistory;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 13;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 39;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Type";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 34;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Format = "d";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 33;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Format = "d";
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 33;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Policy Type";
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 36;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Format = "d";
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridColumn8.Width = 33;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance2.FontData.UnderlineAsString = "True";
    appearance2.ForeColor = Color.Blue;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Center";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn9.Header.VisiblePosition = 12;
    ultraGridColumn9.Width = 36;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Header.VisiblePosition = 8;
    ultraGridColumn10.Width = 36;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Comment";
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Width = 77;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Calculation Type";
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 36;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    appearance3.FontData.UnderlineAsString = "True";
    appearance3.ForeColor = Color.Blue;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Center";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance3;
    ultraGridColumn14.Header.VisiblePosition = 14;
    ultraGridColumn14.Width = 36;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "End.  #";
    ultraGridColumn15.Header.VisiblePosition = 9;
    ultraGridColumn15.Width = 33;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Quote ID";
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Width = 57;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn17.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn17.Format = "c";
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Total Billed";
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn17.Width = 70;
    ultraGridBand.Columns.AddRange(new object[17]
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
      (object) ultraGridColumn17
    });
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugPolicyHistory).Location = new Point(0, 0);
    ((Control) this.ugPolicyHistory).Name = "ugPolicyHistory";
    ((Control) this.ugPolicyHistory).Size = new Size(568, 121);
    ((Control) this.ugPolicyHistory).TabIndex = 2;
    ((UltraControlBase) this.ugPolicyHistory).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugPolicyHistory).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkExportExcel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkExportExcel.Location = new Point(480, 124);
    this.lnkExportExcel.Name = "lnkExportExcel";
    this.lnkExportExcel.Size = new Size(88, 23);
    this.lnkExportExcel.TabIndex = 15;
    this.lnkExportExcel.TabStop = true;
    this.lnkExportExcel.Text = "Export to Excel";
    this.lnkExportExcel.TextAlign = ContentAlignment.MiddleLeft;
    this.Controls.Add((Control) this.lnkExportExcel);
    this.Controls.Add((Control) this.ugPolicyHistory);
    this.Name = nameof (PolicyDetail_Transactions);
    this.Size = new Size(568, 147);
    this.ds.EndInit();
    ((ISupportInitialize) this.ugPolicyHistory).EndInit();
    this.ResumeLayout(false);
  }

  public PolicyDetail_Transactions(Guid quoteGuid)
    : this()
  {
    this._quote = new Quote(quoteGuid);
  }

  public PolicyDetail_Transactions()
  {
    this.Load += new EventHandler(this.PolicyDetail_Transactions_Load);
    this._lnk = new HyperlinkEditor();
    this._lnkDetail = new HyperlinkEditor();
    this._getProcedureNameLock = RuntimeHelpers.GetObjectValue(new object());
    this.InitializeComponent();
  }

  private void PolicyDetail_Transactions_Load(object sender, EventArgs e)
  {
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Bands[0].Columns["View"].Editor = (EmbeddableEditorBase) this._lnk;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Bands[0].Columns["Detail"].Editor = (EmbeddableEditorBase) this._lnkDetail;
    this._lnk.HyperLinkOpening += new CancelEventHandler(this.HyperLinkOpening);
    this._lnkDetail.HyperLinkOpening += new CancelEventHandler(this.DetailLinkClicked);
  }

  public override void Fill() => ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));

  protected virtual string PolicyHistoryStoredProcedureOverride() => "spPolicyHistory";

  private string PolicyHistoryStoredProcedureBase()
  {
    object procedureNameLock = this._getProcedureNameLock;
    ObjectFlowControl.CheckForSyncLockOnValueType(procedureNameLock);
    bool lockTaken = false;
    try
    {
      Monitor.Enter(procedureNameLock, ref lockTaken);
      return this.PolicyHistoryStoredProcedureOverride();
    }
    finally
    {
      if (lockTaken)
        Monitor.Exit(procedureNameLock);
    }
  }

  private void ThreadedFill(object state)
  {
    Thread.Sleep(250);
    dsPolicyHistory.viewPolicyHistoryDataTable historyDataTable = new dsPolicyHistory.viewPolicyHistoryDataTable();
    string str = this.PolicyHistoryStoredProcedureBase();
    DefaultDatabase.LoadDataTable((DataTable) historyDataTable, str, new object[2]
    {
      (object) "@controlNum",
      (object) this._quote.ControlNo
    });
    try
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new PolicyDetail_Transactions.FillCompleteHandler(this.FillComplete), (object) historyDataTable);
    }
    catch (NullReferenceException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ProjectData.ClearProjectError();
    }
  }

  private void FillComplete(dsPolicyHistory.viewPolicyHistoryDataTable dt)
  {
    ((UltraGridBase) this.ugPolicyHistory).DataMember = string.Empty;
    ((UltraGridBase) this.ugPolicyHistory).DataSource = (object) dt;
    if (((UltraGridBase) this.ugPolicyHistory).Rows.Count > 1)
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.ugPolicyHistory).Rows)
      {
        if (row.Cells["QuoteGUID"].Value.Equals((object) this._quote.QuoteGuid))
        {
          row.Appearance.BackColor = Color.LightGoldenrodYellow;
          break;
        }
      }
    }
    if (!frmPolicyDetail.CurrentMultiCurrency || !frmPolicyDetail.ImplementCurrencyDisplay)
      return;
    ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Bands[0].Columns["Amount"].FormatInfo = (IFormatProvider) frmPolicyDetail.CurrentCultureInfo;
  }

  private void HyperLinkOpening(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugPolicyHistory).ActiveRow == null)
      return;
    e.Cancel = true;
    FormSettings.ShowForm(typeof (frmPolicyDetail), new object[1]
    {
      (object) (Guid) ((UltraGridBase) this.ugPolicyHistory).ActiveRow.Cells["QuoteGuid"].Value
    });
    this.ParentForm.Close();
  }

  protected virtual StringBuilder ModifyDetailLinkString(StringBuilder details) => details;

  private void DetailLinkClicked(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugPolicyHistory).ActiveRow == null)
      return;
    e.Cancel = true;
    Guid QuoteGUID = (Guid) ((UltraGridBase) this.ugPolicyHistory).ActiveRow.Cells["QuoteGuid"].Value;
    dsPolicyHistory.viewPolicyHistoryRow byQuoteGuid = ((dsPolicyHistory.viewPolicyHistoryDataTable) ((UltraGridBase) this.ugPolicyHistory).DataSource).FindByQuoteGUID(QuoteGUID);
    Quote quote = new Quote(QuoteGUID);
    StringBuilder details = new StringBuilder();
    foreach (UltraGridColumn column in ((UltraGridBase) this.ugPolicyHistory).DisplayLayout.Bands[0].Columns)
    {
      if (!column.Hidden && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.Key, "Detail", false) != 0 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(column.Key, "View", false) != 0)
      {
        object objectValue = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugPolicyHistory).ActiveRow.Cells[column].Value);
        string str = !(objectValue is DateTime dateTime) ? objectValue.ToString() : dateTime.ToShortDateString();
        if (str.Length > 0)
          details.Append($"{((HeaderBase) column.Header).Caption}: {str}\n");
      }
    }
    if (quote.IsEndorsement && !byQuoteGuid.IsEndorsementCalcTypeNull())
      details.Append($"Calculation Type: {byQuoteGuid.EndorsementCalcType}\n");
    if (!byQuoteGuid.IsReasonNull())
      details.Append($"Status Change Reason: {byQuoteGuid.Reason}\n");
    if (!byQuoteGuid.IsQuoteStatusCommentNull())
      details.Append($"Quote Status Comment: {byQuoteGuid.QuoteStatusComment}\n");
    FormSettings.ShowFormDialog(typeof (frmGenericInfo), new object[2]
    {
      (object) "Policy Transaction Detail:",
      (object) this.ModifyDetailLinkString(details)
    }).Dispose();
  }

  private void lnkExportExcel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    saveFileDialog.Filter = "Excel Files (*.xls)|*.xls|All Files (*.*)|*.*";
    saveFileDialog.DefaultExt = "xls";
    if (saveFileDialog.ShowDialog((IWin32Window) this) != DialogResult.OK)
      return;
    this.UltraGridExcelExporter1.Export(this.ugPolicyHistory, saveFileDialog.FileName);
  }

  private void ugPolicyHistory_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if ((double) e.Row.Cells["Amount"].Value >= 0.0)
      return;
    e.Row.Cells["Amount"].Appearance.ForeColor = Color.Red;
  }

  private delegate void FillCompleteHandler(dsPolicyHistory.viewPolicyHistoryDataTable dt);
}
