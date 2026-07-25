// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Bulk_Renewal_Utility.FormBulkRenewal
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.FormattedLinkLabel;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinGrid.ExcelExport;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Bulk_Renewal_Utility;

public class FormBulkRenewal : FormBase
{
  private dsBulkRenewal.PolicyRenewalsDataTable _processedRenewals = new dsBulkRenewal.PolicyRenewalsDataTable();
  private FormBulkRenewalQueue _queueForm;
  private BackgroundWorker _bw;
  private IContainer components;
  private Panel panel1;
  private UltraGrid ultraGrid1;
  private Panel panelTop;
  public Panel panelContent;
  private PictureBox pictureBox1;
  public Label Label1;
  private BindingSource spGetBulkRenewalUtilityListBindingSource;
  private LinkLabel lnkSelectAll;
  private LinkLabel lnkSelectNone;
  protected UltraGrid grdRenewalSelections;
  protected dsBulkRenewal dsBulkRenewal;
  protected MGAButton btnCancel;
  protected MGAButton btnRenew;
  protected MGAButton btnBatch;
  protected MGAButton btnViewQueue;
  protected UltraFormattedTextEditor lnkControlNo;
  private UltraDropDownButton btnExport;
  private UltraToolbarsManager exportToolbar;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Top;
  private UltraGridExcelExporter bulkRenewalExporter;
  protected MGACheckBox chkRenewSilently;

  public dsBulkRenewal.spGetBulkRenewalUtilityListDataTable Renewals
  {
    get => this.dsBulkRenewal.spGetBulkRenewalUtilityList;
  }

  public FormBulkRenewal() => this.InitializeComponent();

  public FormBulkRenewal(
    dsBulkRenewal.spGetBulkRenewalUtilityListDataTable dt)
    : this()
  {
    this.Renewals.Merge((DataTable) dt);
  }

  public FormBulkRenewal(DataTable dt, int phase)
    : this()
  {
    this.Renewals.Merge(dt);
  }

  private void FormBulkRenewal_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("SupportAutomaticRenewal"))
    {
      ((Control) this.btnBatch).Visible = true;
      ((Control) this.btnViewQueue).Visible = true;
    }
    this.OnFormLoad();
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void btnRenew_Click(object sender, EventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((Control) this.btnBatch).Enabled = ((Control) this.btnExport).Enabled = ((Control) this.btnRenew).Enabled = false;
    (bool, bool) valueTuple = (MGASystems.IMS.NoteDocuments.Common.BlackBoxMode, CompanyDocumentAutomation.BlackBoxMode);
    CompanyDocumentAutomation.BlackBoxMode = MGASystems.IMS.NoteDocuments.Common.BlackBoxMode = true;
    if (!((UltraToggleEditorBase) this.chkRenewSilently).Checked)
    {
      this.RenewPolicies(new Action<dsBulkRenewal.PolicyRenewalsRow>(this.ProcessRenewalNow));
      CompanyDocumentAutomation.BlackBoxMode = valueTuple.Item1;
      MGASystems.IMS.NoteDocuments.Common.BlackBoxMode = valueTuple.Item2;
      this.Cursor = MgaCursors.Default;
    }
    else
    {
      this._bw = new BackgroundWorker()
      {
        WorkerReportsProgress = true
      };
      this._bw.DoWork += new DoWorkEventHandler(this.BackgroundRenewPolicies);
      this._bw.ProgressChanged += new ProgressChangedEventHandler(this.BackgroundUpdateProgress);
      this._bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.BackgroundRunCompleted);
      this._bw.RunWorkerAsync((object) new object[2]
      {
        (object) new Action<dsBulkRenewal.PolicyRenewalsRow>(this.ProcessRenewalBackground),
        (object) valueTuple
      });
    }
  }

  private void btnBatch_Click(object sender, EventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((Control) this.btnBatch).Enabled = ((Control) this.btnExport).Enabled = ((Control) this.btnRenew).Enabled = false;
    this.RenewPolicies(new Action<dsBulkRenewal.PolicyRenewalsRow>(this.ProcessRenewalBatch));
    this.Cursor = MgaCursors.Default;
  }

  private void btnViewQueue_Click(object sender, EventArgs e)
  {
    if (this._queueForm == null || this._queueForm.IsDisposed)
      this._queueForm = (FormBulkRenewalQueue) MGASystems.Common.FormSettings.ShowForm(typeof (FormBulkRenewalQueue), (object[]) null);
    this._queueForm.Show();
  }

  private void lnkSelectNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectRows(false);
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectRows(true);
  }

  private void lnkControlNo_LinkClicked(object sender, LinkClickedEventArgs e)
  {
    int result;
    if (string.IsNullOrEmpty(e.LinkText) || !int.TryParse(e.LinkText, out result))
      return;
    if (Quote.ControlNumberExists(result))
    {
      MGASystems.Common.FormSettings.ShowForm(typeof (frmPolicyDetail), (object) result);
    }
    else
    {
      UltraGridCell context = (UltraGridCell) e.Context;
      if (((KeyedSubObjectBase) context.Column).Key.Equals("RenewalControlno"))
      {
        context.SetValue((object) DBNull.Value, false);
        context.Row.Activation = (Activation) 3;
      }
      else
        context.Row.Delete(false);
    }
  }

  private void exportToolbar_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "ExportReport":
        rptRenewalSelections report = new rptRenewalSelections(this.Renewals.Copy());
        report.Run();
        new frmPrint((SectionReport) report).Show();
        break;
      case "ExportSpreadsheet":
        string fileName = $"{MGATempFolder.MGATempPath}{DateTime.Now.ToString("\"BR\"yyyyMMddHHss")}.xls";
        this.bulkRenewalExporter.Export(this.grdRenewalSelections, fileName);
        Process.Start(fileName);
        break;
    }
  }

  private void grdRenewalSelections_CellChange(object sender, CellEventArgs e)
  {
    if (sender == null)
      return;
    this.grdRenewalSelections.PerformAction((UltraGridAction) 44);
    MGAButton btnBatch = this.btnBatch;
    UltraDropDownButton btnExport = this.btnExport;
    MGAButton btnRenew = this.btnRenew;
    dsBulkRenewal.spGetBulkRenewalUtilityListDataTable renewals = this.Renewals;
    int num1;
    bool flag1 = (num1 = renewals.Any<dsBulkRenewal.spGetBulkRenewalUtilityListRow>((System.Func<dsBulkRenewal.spGetBulkRenewalUtilityListRow, bool>) (tr => tr.Selected)) ? 1 : 0) != 0;
    ((Control) btnRenew).Enabled = num1 != 0;
    int num2;
    bool flag2 = (num2 = flag1 ? 1 : 0) != 0;
    ((Control) btnExport).Enabled = num2 != 0;
    int num3 = flag2 ? 1 : 0;
    ((Control) btnBatch).Enabled = num3 != 0;
  }

  private void grdRenewalSelections_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if ((int) e.Row.Cells["ClaimCount"].Value > 0)
      ((AppearanceBase) e.Row.Appearance).ForeColor = Color.Red;
    if (e.Row.Cells["QuoteStatusBound"].Value.Equals((object) false))
      this.DeactivateRow(e.Row, Color.Gray);
    if ((string) e.Row.Cells["Status"].Value == "Notice of Cancellation")
      ((AppearanceBase) e.Row.Appearance).ForeColor = Color.Red;
    this.ClientRowInitializer(e);
  }

  protected virtual void ClientRowInitializer(InitializeRowEventArgs e)
  {
  }

  private void bulkRenewalExporter_BeginExport(object sender, BeginExportEventArgs e)
  {
    e.Layout.Bands[0].Columns["Selected"].Hidden = true;
  }

  private void bulkRenewalExporter_RowExporting(object sender, RowExportingEventArgs e)
  {
    if ((bool) e.GridRow.GetCellValue("Selected"))
      return;
    ((CancelEventArgs) e).Cancel = true;
  }

  private void DeactivateRow(UltraGridRow row, Color appearanceColor)
  {
    ((AppearanceBase) row.Appearance).ForeColorDisabled = appearanceColor;
    row.Activation = (Activation) 2;
    row.Cells["ControlNo"].IgnoreRowColActivation = true;
    row.Cells["ControlNo"].Activation = (Activation) 3;
    row.Cells["RenewalControlno"].IgnoreRowColActivation = true;
    row.Cells["RenewalControlno"].Activation = (Activation) 3;
  }

  public void RenewPolicies(
    Action<dsBulkRenewal.PolicyRenewalsRow> processFunc)
  {
    this._processedRenewals = new dsBulkRenewal.PolicyRenewalsDataTable();
    foreach (dsBulkRenewal.spGetBulkRenewalUtilityListRow renewalUtilityListRow in this.Renewals.Where<dsBulkRenewal.spGetBulkRenewalUtilityListRow>((System.Func<dsBulkRenewal.spGetBulkRenewalUtilityListRow, bool>) (tr => tr.Selected)))
    {
      dsBulkRenewal.PolicyRenewalsRow row = (dsBulkRenewal.PolicyRenewalsRow) null;
      try
      {
        row = this._processedRenewals.NewPolicyRenewalsRow();
        row.ControlNo = renewalUtilityListRow.ControlNo;
        row.PolicyNumber = renewalUtilityListRow.PolicyNumber;
        row.Insured = renewalUtilityListRow.IsInsuredNull() ? string.Empty : renewalUtilityListRow.Insured;
        processFunc(row);
      }
      catch
      {
        row.Status = "Error processing renewal";
      }
      this._processedRenewals.AddPolicyRenewalsRow(row);
    }
    if (this._processedRenewals.Count > 0)
    {
      foreach (dsBulkRenewal.PolicyRenewalsRow policyRenewalsRow in this._processedRenewals.Where<dsBulkRenewal.PolicyRenewalsRow>((System.Func<dsBulkRenewal.PolicyRenewalsRow, bool>) (tr => tr.Status.IndexOf("Error", StringComparison.OrdinalIgnoreCase) == -1)))
      {
        dsBulkRenewal.spGetBulkRenewalUtilityListRow byControlNo = this.Renewals.FindByControlNo(policyRenewalsRow.ControlNo);
        if (byControlNo != null)
        {
          byControlNo.Selected = false;
          UltraGridRow rowWithListIndex = ((UltraGridBase) this.grdRenewalSelections).Rows.GetRowWithListIndex(this.Renewals.Rows.IndexOf((DataRow) byControlNo));
          if (!policyRenewalsRow.IsRenewalControlNoNull())
          {
            byControlNo.RenewalControlno = policyRenewalsRow.RenewalControlNo;
            this.DeactivateRow(rowWithListIndex, Color.Green);
          }
          else
            ((AppearanceBase) rowWithListIndex.Appearance).ForeColor = Color.Green;
        }
      }
      this.Renewals.AcceptChanges();
      if (this._queueForm == null || this._queueForm.DialogResult == DialogResult.Cancel)
      {
        this._queueForm = (FormBulkRenewalQueue) MGASystems.Common.FormSettings.ShowForm(typeof (FormBulkRenewalQueue), (object) this._processedRenewals);
      }
      else
      {
        this._queueForm.MergeRenewalQuotes(this._processedRenewals);
        this._queueForm.Show();
        this._queueForm.BringToFront();
      }
      if (this._processedRenewals.Any<dsBulkRenewal.PolicyRenewalsRow>((System.Func<dsBulkRenewal.PolicyRenewalsRow, bool>) (tr => !tr.IsRenewalGuidNull())))
        this.ClientWork((DataTable) this._processedRenewals);
    }
    MGAButton btnBatch = this.btnBatch;
    UltraDropDownButton btnExport = this.btnExport;
    MGAButton btnRenew = this.btnRenew;
    dsBulkRenewal.spGetBulkRenewalUtilityListDataTable renewals = this.Renewals;
    int num1;
    bool flag1 = (num1 = renewals.Any<dsBulkRenewal.spGetBulkRenewalUtilityListRow>((System.Func<dsBulkRenewal.spGetBulkRenewalUtilityListRow, bool>) (tr => tr.Selected)) ? 1 : 0) != 0;
    ((Control) btnRenew).Enabled = num1 != 0;
    int num2;
    bool flag2 = (num2 = flag1 ? 1 : 0) != 0;
    ((Control) btnExport).Enabled = num2 != 0;
    int num3 = flag2 ? 1 : 0;
    ((Control) btnBatch).Enabled = num3 != 0;
  }

  private void BackgroundRenewPolicies(object obj, DoWorkEventArgs dwea)
  {
    object[] objArray = dwea.Argument as object[];
    Action<dsBulkRenewal.PolicyRenewalsRow> action = objArray[0] as Action<dsBulkRenewal.PolicyRenewalsRow>;
    dsBulkRenewal.PolicyRenewalsDataTable renewalsDataTable = new dsBulkRenewal.PolicyRenewalsDataTable();
    foreach (dsBulkRenewal.spGetBulkRenewalUtilityListRow renewalUtilityListRow in this.Renewals.Where<dsBulkRenewal.spGetBulkRenewalUtilityListRow>((System.Func<dsBulkRenewal.spGetBulkRenewalUtilityListRow, bool>) (tr => tr.Selected)).ToList<dsBulkRenewal.spGetBulkRenewalUtilityListRow>())
    {
      dsBulkRenewal.PolicyRenewalsRow policyRenewalsRow = (dsBulkRenewal.PolicyRenewalsRow) null;
      try
      {
        policyRenewalsRow = renewalsDataTable.NewPolicyRenewalsRow();
        policyRenewalsRow.ControlNo = renewalUtilityListRow.ControlNo;
        policyRenewalsRow.PolicyNumber = renewalUtilityListRow.PolicyNumber;
        policyRenewalsRow.Insured = renewalUtilityListRow.IsInsuredNull() ? string.Empty : renewalUtilityListRow.Insured;
        policyRenewalsRow.Status = $"Renewing {policyRenewalsRow.ControlNo}...";
        this._bw?.ReportProgress(0, (object) policyRenewalsRow);
        action(policyRenewalsRow);
        if (!policyRenewalsRow.IsRenewalControlNoNull())
        {
          policyRenewalsRow.Status = $"Renewed successfully. Created control {policyRenewalsRow.RenewalControlNo}.";
          this._bw?.ReportProgress(1, (object) policyRenewalsRow);
        }
      }
      catch (Exception ex)
      {
        policyRenewalsRow.Status = "Error processing renewal";
        ex.Data.Add((object) "ControlNo", (object) policyRenewalsRow.ControlNo);
        ErrorHandler.SilentLogError(ex);
        this._bw?.ReportProgress(0, (object) policyRenewalsRow);
      }
      renewalsDataTable.AddPolicyRenewalsRow(policyRenewalsRow);
    }
    this._bw?.ReportProgress(100, objArray[1]);
    dwea.Result = (object) renewalsDataTable;
  }

  private void BackgroundUpdateProgress(object obj, ProgressChangedEventArgs pcea)
  {
    switch (pcea.ProgressPercentage)
    {
      case 0:
        dsBulkRenewal.PolicyRenewalsRow userState1 = pcea.UserState as dsBulkRenewal.PolicyRenewalsRow;
        dsBulkRenewal.spGetBulkRenewalUtilityListRow byControlNo1 = this.Renewals.FindByControlNo(userState1.ControlNo);
        if (byControlNo1 == null)
          break;
        byControlNo1.Status = userState1.Status;
        ((UltraGridBase) this.grdRenewalSelections).Rows.GetRowWithListIndex(this.Renewals.Rows.IndexOf((DataRow) byControlNo1)).Refresh();
        break;
      case 1:
        dsBulkRenewal.PolicyRenewalsRow userState2 = pcea.UserState as dsBulkRenewal.PolicyRenewalsRow;
        dsBulkRenewal.spGetBulkRenewalUtilityListRow byControlNo2 = this.Renewals.FindByControlNo(userState2.ControlNo);
        if (byControlNo2 == null)
          break;
        byControlNo2.Selected = false;
        UltraGridRow rowWithListIndex = ((UltraGridBase) this.grdRenewalSelections).Rows.GetRowWithListIndex(this.Renewals.Rows.IndexOf((DataRow) byControlNo2));
        if (!userState2.IsRenewalControlNoNull())
        {
          byControlNo2.RenewalControlno = userState2.RenewalControlNo;
          this.DeactivateRow(rowWithListIndex, Color.Green);
        }
        else
          ((AppearanceBase) rowWithListIndex.Appearance).ForeColor = Color.Green;
        rowWithListIndex.Refresh();
        break;
      case 100:
        (CompanyDocumentAutomation.BlackBoxMode, MGASystems.IMS.NoteDocuments.Common.BlackBoxMode) = ((bool, bool)) pcea.UserState;
        break;
    }
  }

  private void BackgroundRunCompleted(object obj, RunWorkerCompletedEventArgs rwcea)
  {
    if (rwcea.Result is dsBulkRenewal.PolicyRenewalsDataTable result && result.Count > 0)
    {
      this._processedRenewals = result;
      this.Renewals.AcceptChanges();
      if (this._queueForm == null || this._queueForm.DialogResult == DialogResult.Cancel)
      {
        this._queueForm = (FormBulkRenewalQueue) MGASystems.Common.FormSettings.ShowForm(typeof (FormBulkRenewalQueue), (object) this._processedRenewals);
      }
      else
      {
        this._queueForm.MergeRenewalQuotes(this._processedRenewals);
        this._queueForm.Show();
        this._queueForm.BringToFront();
      }
      if (this._processedRenewals.Any<dsBulkRenewal.PolicyRenewalsRow>((System.Func<dsBulkRenewal.PolicyRenewalsRow, bool>) (tr => !tr.IsRenewalGuidNull())))
        this.ClientWork((DataTable) this._processedRenewals);
    }
    MGAButton btnBatch = this.btnBatch;
    UltraDropDownButton btnExport = this.btnExport;
    MGAButton btnRenew = this.btnRenew;
    dsBulkRenewal.spGetBulkRenewalUtilityListDataTable renewals = this.Renewals;
    int num1;
    bool flag1 = (num1 = renewals.Any<dsBulkRenewal.spGetBulkRenewalUtilityListRow>((System.Func<dsBulkRenewal.spGetBulkRenewalUtilityListRow, bool>) (tr => tr.Selected)) ? 1 : 0) != 0;
    ((Control) btnRenew).Enabled = num1 != 0;
    int num2;
    bool flag2 = (num2 = flag1 ? 1 : 0) != 0;
    ((Control) btnExport).Enabled = num2 != 0;
    int num3 = flag2 ? 1 : 0;
    ((Control) btnBatch).Enabled = num3 != 0;
    this.Cursor = MgaCursors.Default;
  }

  private void ProcessRenewalNow(dsBulkRenewal.PolicyRenewalsRow policyRow)
  {
    Quote quote1 = Quote.FromControlNo(policyRow.ControlNo);
    policyRow.RenewalGuid = quote1.Renew();
    policyRow.Status = "Renewed Successfully";
    DefaultDatabase.ExecuteNonQuery("spRenewals_ClearRenewAutomatically", new object[2]
    {
      (object) "@QuoteId",
      (object) quote1.QuoteID
    });
    Quote quote2 = new Quote(policyRow.RenewalGuid);
    policyRow.RenewalControlNo = quote2.ControlNo;
  }

  private void ProcessRenewalBatch(dsBulkRenewal.PolicyRenewalsRow policyRow)
  {
    if ((int) DefaultDatabase.ExecuteScalar("spRenewals_MarkPolicyAutoRenewal", new object[2]
    {
      (object) "@ControlNo",
      (object) policyRow.ControlNo
    }) == 1)
      policyRow.Status = "Queued for Renewal";
    else
      policyRow.Status = "Error processing renewal";
  }

  private void ProcessRenewalBackground(dsBulkRenewal.PolicyRenewalsRow policyRow)
  {
    Quote quote1 = Quote.FromControlNo(policyRow.ControlNo);
    policyRow.RenewalGuid = quote1.Renew();
    policyRow.Status = "Renewed Successfully";
    DefaultDatabase.ExecuteNonQuery("spRenewals_ClearRenewAutomatically", new object[2]
    {
      (object) "@QuoteId",
      (object) quote1.QuoteID
    });
    Quote quote2 = new Quote(policyRow.RenewalGuid);
    policyRow.RenewalControlNo = quote2.ControlNo;
    CompanyDocumentAutomation objectAs = ObjectFactory.Instance.CreateObjectAs<CompanyDocumentAutomation>((object) quote2.CompanyLineGuid, (object) new Messaging.MessageEventArgs()
    {
      Context = (object) policyRow.RenewalGuid,
      EventGuid = BroadcastMessages.NewRenewal
    });
    try
    {
      objectAs.QuoteGuid = policyRow.RenewalGuid;
      objectAs.CreatePDFPackage();
    }
    catch
    {
    }
  }

  private void SelectRows(bool selected)
  {
    foreach (UltraGridRow ultraGridRow in ((IEnumerable) ((UltraGridBase) this.grdRenewalSelections).Rows).OfType<UltraGridRow>().Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (r => r.Activation != 2 && !r.IsFilteredOut)))
      ultraGridRow.Cells["Selected"].Value = (object) selected;
    MGAButton btnBatch = this.btnBatch;
    UltraDropDownButton btnExport = this.btnExport;
    MGAButton btnRenew = this.btnRenew;
    dsBulkRenewal.spGetBulkRenewalUtilityListDataTable renewals = this.Renewals;
    int num1;
    bool flag1 = (num1 = renewals.Any<dsBulkRenewal.spGetBulkRenewalUtilityListRow>((System.Func<dsBulkRenewal.spGetBulkRenewalUtilityListRow, bool>) (tr => tr.Selected)) ? 1 : 0) != 0;
    ((Control) btnRenew).Enabled = num1 != 0;
    int num2;
    bool flag2 = (num2 = flag1 ? 1 : 0) != 0;
    ((Control) btnExport).Enabled = num2 != 0;
    int num3 = flag2 ? 1 : 0;
    ((Control) btnBatch).Enabled = num3 != 0;
  }

  protected virtual void ClientWork(DataTable dataTable)
  {
  }

  protected virtual void OnFormLoad()
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ButtonTool buttonTool1 = new ButtonTool("ExportReport");
    ButtonTool buttonTool2 = new ButtonTool("ExportSpreadsheet");
    PopupMenuTool popupMenuTool = new PopupMenuTool("N/A");
    ButtonTool buttonTool3 = new ButtonTool("ExportReport");
    ButtonTool buttonTool4 = new ButtonTool("ExportSpreadsheet");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spGetBulkRenewalUtilityList", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyGroupGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Insured");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Broker");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProducerLocationName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ExpirationDate");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ControlNo");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Company");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Und");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("UndAssist");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Premium");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Lines");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("TACSR");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("ClaimCount");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("TotalIncurred");
    Appearance appearance13 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("LossRatio");
    Appearance appearance14 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("RenewalControlno");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("RenewalStatus");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Selected");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormBulkRenewal));
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("PayType");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("TotalPaid");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("QuoteStatusBound", 0);
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    this.lnkControlNo = new UltraFormattedTextEditor();
    this.panel1 = new Panel();
    this.chkRenewSilently = new MGACheckBox();
    this.btnExport = new UltraDropDownButton();
    this.exportToolbar = new UltraToolbarsManager(this.components);
    this.lnkSelectNone = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.btnViewQueue = new MGAButton();
    this.btnBatch = new MGAButton();
    this.btnCancel = new MGAButton();
    this.btnRenew = new MGAButton();
    this.ultraGrid1 = new UltraGrid();
    this.panelTop = new Panel();
    this.Label1 = new Label();
    this.pictureBox1 = new PictureBox();
    this.panelContent = new Panel();
    this.grdRenewalSelections = new UltraGrid();
    this.spGetBulkRenewalUtilityListBindingSource = new BindingSource(this.components);
    this.dsBulkRenewal = new dsBulkRenewal();
    this._FormBulkRenewal_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormBulkRenewal_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormBulkRenewal_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormBulkRenewal_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.bulkRenewalExporter = new UltraGridExcelExporter(this.components);
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.chkRenewSilently).BeginInit();
    ((ISupportInitialize) this.exportToolbar).BeginInit();
    ((ISupportInitialize) this.btnViewQueue).BeginInit();
    ((ISupportInitialize) this.btnBatch).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnRenew).BeginInit();
    ((ISupportInitialize) this.ultraGrid1).BeginInit();
    this.panelTop.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.panelContent.SuspendLayout();
    ((ISupportInitialize) this.grdRenewalSelections).BeginInit();
    ((ISupportInitialize) this.spGetBulkRenewalUtilityListBindingSource).BeginInit();
    this.dsBulkRenewal.BeginInit();
    this.SuspendLayout();
    ((Control) this.lnkControlNo).Location = new Point(45, 54);
    ((Control) this.lnkControlNo).Name = "lnkControlNo";
    ((Control) this.lnkControlNo).Size = new Size(72, 23);
    ((Control) this.lnkControlNo).TabIndex = 13;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).TreatValueAs = (TreatValueAs) 2;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).Value = (object) "controlno";
    ((Control) this.lnkControlNo).Visible = false;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).LinkClicked += new LinkClickedEventHandler(this.lnkControlNo_LinkClicked);
    this.panel1.BackColor = Color.Transparent;
    this.panel1.Controls.Add((Control) this.chkRenewSilently);
    this.panel1.Controls.Add((Control) this.btnExport);
    this.panel1.Controls.Add((Control) this.lnkSelectNone);
    this.panel1.Controls.Add((Control) this.lnkSelectAll);
    this.panel1.Controls.Add((Control) this.btnViewQueue);
    this.panel1.Controls.Add((Control) this.btnBatch);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnRenew);
    this.panel1.Dock = DockStyle.Bottom;
    this.panel1.Location = new Point(0, 410);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(885, 52);
    this.panel1.TabIndex = 4;
    ((Control) this.chkRenewSilently).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    ((AppearanceBase) appearance1).BorderColor = Color.Gray;
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRenewSilently).Appearance = (AppearanceBase) appearance1;
    ((Control) this.chkRenewSilently).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkRenewSilently).BackColorInternal = Color.Transparent;
    ((Control) this.chkRenewSilently).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.chkRenewSilently).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkRenewSilently).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkRenewSilently).Location = new Point(84, 8);
    ((Control) this.chkRenewSilently).Name = "chkRenewSilently";
    ((Control) this.chkRenewSilently).Size = new Size(102, 18);
    ((Control) this.chkRenewSilently).TabIndex = 14;
    ((Control) this.chkRenewSilently).Text = "Renew Silently";
    ((UltraControlBase) this.chkRenewSilently).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkRenewSilently).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnExport).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnExport).Appearance = (AppearanceBase) appearance2;
    ((UltraButtonBase) this.btnExport).ButtonStyle = (UIElementButtonStyle) 14;
    ((Control) this.btnExport).Enabled = false;
    ((Control) this.btnExport).Location = new Point(602, 7);
    ((Control) this.btnExport).Name = "btnExport";
    this.btnExport.PopupItemKey = "N/A";
    this.btnExport.PopupItemProvider = (IPopupItemProvider) this.exportToolbar;
    ((Control) this.btnExport).Size = new Size(75, 36);
    this.btnExport.Style = (SplitButtonDisplayStyle) 1;
    ((Control) this.btnExport).TabIndex = 13;
    ((Control) this.btnExport).Text = "Export";
    ((UltraControlBase) this.btnExport).UseOsThemes = (DefaultableBoolean) 2;
    this.exportToolbar.DesignerFlags = 1;
    this.exportToolbar.DockWithinContainer = (Control) this;
    this.exportToolbar.DockWithinContainerBaseType = typeof (FormBase);
    this.exportToolbar.ImageSizeLarge = new Size(0, 0);
    this.exportToolbar.ImageSizeSmall = new Size(0, 0);
    this.exportToolbar.ShowFullMenusDelay = 500;
    ((ToolPropsBase) ((ToolBase) buttonTool1).SharedPropsInternal).Caption = "Report";
    ((ToolBase) buttonTool1).SharedPropsInternal.CustomizerCaption = "Report";
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "Spreadsheet";
    ((ToolBase) buttonTool2).SharedPropsInternal.CustomizerCaption = "Spreadsheet";
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "N/A";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((ToolsCollectionBase) this.exportToolbar.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) popupMenuTool
    });
    this.exportToolbar.ToolClick += new ToolClickEventHandler(this.exportToolbar_ToolClick);
    this.lnkSelectNone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectNone.AutoSize = true;
    this.lnkSelectNone.BackColor = Color.Transparent;
    this.lnkSelectNone.Location = new Point(13, 30);
    this.lnkSelectNone.Margin = new Padding(4, 0, 4, 0);
    this.lnkSelectNone.Name = "lnkSelectNone";
    this.lnkSelectNone.Size = new Size(63 /*0x3F*/, 13);
    this.lnkSelectNone.TabIndex = 12;
    this.lnkSelectNone.TabStop = true;
    this.lnkSelectNone.Text = "Deselect All";
    this.lnkSelectNone.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkSelectNone_LinkClicked);
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.BackColor = Color.Transparent;
    this.lnkSelectAll.Location = new Point(13, 9);
    this.lnkSelectAll.Margin = new Padding(4, 0, 4, 0);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 11;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkSelectAll.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
    ((Control) this.btnViewQueue).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance3).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance3).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance3).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnViewQueue).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnViewQueue).Location = new Point(406, 9);
    ((Control) this.btnViewQueue).Name = "btnViewQueue";
    ((Control) this.btnViewQueue).Size = new Size(72, 34);
    ((Control) this.btnViewQueue).TabIndex = 4;
    ((Control) this.btnViewQueue).Text = "View Queue";
    ((UltraControlBase) this.btnViewQueue).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnViewQueue).Visible = false;
    ((Control) this.btnViewQueue).Click += new EventHandler(this.btnViewQueue_Click);
    ((Control) this.btnBatch).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnBatch).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnBatch).Enabled = false;
    ((Control) this.btnBatch).Location = new Point(504, 9);
    ((Control) this.btnBatch).Name = "btnBatch";
    ((Control) this.btnBatch).Size = new Size(75, 34);
    ((Control) this.btnBatch).TabIndex = 4;
    ((Control) this.btnBatch).Text = "Batch";
    ((UltraControlBase) this.btnBatch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnBatch).Visible = false;
    ((Control) this.btnBatch).Click += new EventHandler(this.btnBatch_Click);
    ((Control) this.btnCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance5).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance5).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnCancel).Location = new Point(798, 9);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(75, 34);
    ((Control) this.btnCancel).TabIndex = 1;
    ((Control) this.btnCancel).Text = "Cancel";
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    ((Control) this.btnRenew).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance6).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance6).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRenew).Appearance = (AppearanceBase) appearance6;
    ((Control) this.btnRenew).Enabled = false;
    ((Control) this.btnRenew).Location = new Point(700, 9);
    ((Control) this.btnRenew).Name = "btnRenew";
    ((Control) this.btnRenew).Size = new Size(75, 34);
    ((Control) this.btnRenew).TabIndex = 0;
    ((Control) this.btnRenew).Text = "Renew";
    ((UltraControlBase) this.btnRenew).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnRenew).Click += new EventHandler(this.btnRenew_Click);
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((SpecialBoxBase) ((UltraGridBase) this.ultraGrid1).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.MaxRowScrollRegions = 1;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.CellPadding = 0;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.ultraGrid1).Location = new Point(13, 13);
    ((Control) this.ultraGrid1).Name = "ultraGrid1";
    ((Control) this.ultraGrid1).Size = new Size(717, 390);
    ((Control) this.ultraGrid1).TabIndex = 0;
    ((Control) this.ultraGrid1).Text = "ultraGrid1";
    this.panelTop.BackColor = Color.Transparent;
    this.panelTop.Controls.Add((Control) this.Label1);
    this.panelTop.Controls.Add((Control) this.pictureBox1);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(885, 72);
    this.panelTop.TabIndex = 5;
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 18f);
    this.Label1.ForeColor = Color.SteelBlue;
    this.Label1.Location = new Point(636, 40);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(222, 29);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Bulk Renewal Utility";
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(21, 16 /*0x10*/);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(58, 50);
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.panelContent.BackColor = Color.Transparent;
    this.panelContent.Controls.Add((Control) this.lnkControlNo);
    this.panelContent.Controls.Add((Control) this.grdRenewalSelections);
    this.panelContent.Dock = DockStyle.Fill;
    this.panelContent.Location = new Point(0, 72);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(885, 338);
    this.panelContent.TabIndex = 6;
    ((UltraGridBase) this.grdRenewalSelections).DataSource = (object) this.spGetBulkRenewalUtilityListBindingSource;
    ((AppearanceBase) appearance7).BackColor = Color.White;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Appearance = (AppearanceBase) appearance7;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 15;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.MinWidth = 15;
    ultraGridColumn1.Width = 20;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 3;
    ultraGridColumn2.MinWidth = 15;
    ultraGridColumn2.RowLayoutColumnInfo.OriginX = 6;
    ultraGridColumn2.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn2.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn2.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn2.Width = 100;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 6;
    ultraGridColumn3.MinWidth = 15;
    ultraGridColumn3.RowLayoutColumnInfo.OriginX = 14;
    ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn3.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn3.Width = 100;
    ultraGridColumn4.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.MinWidth = 15;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Right";
    ultraGridColumn5.FilterCellAppearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Expiration Date";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 2;
    ultraGridColumn5.MinWidth = 15;
    ultraGridColumn5.RowLayoutColumnInfo.OriginX = 4;
    ultraGridColumn5.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn5.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn5.Width = 75;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ultraGridColumn6.EditorComponent = (Component) this.lnkControlNo;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Right";
    ultraGridColumn6.FilterCellAppearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 1;
    ultraGridColumn6.MinWidth = 15;
    ultraGridColumn6.RowLayoutColumnInfo.OriginX = 2;
    ultraGridColumn6.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn6.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn6.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn6.Width = 75;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 4;
    ultraGridColumn7.MinWidth = 15;
    ultraGridColumn7.RowLayoutColumnInfo.OriginX = 8;
    ultraGridColumn7.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn7.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn7.Width = 100;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Underwriter";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 5;
    ultraGridColumn8.MinWidth = 15;
    ultraGridColumn8.ProportionalResize = true;
    ultraGridColumn8.RowLayoutColumnInfo.OriginX = 12;
    ultraGridColumn8.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn8.RowLayoutColumnInfo.PreferredCellSize = new Size(100, 0);
    ultraGridColumn8.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn8.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn8.Width = 120;
    ultraGridColumn9.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 17;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.MinWidth = 15;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Right";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Right";
    ultraGridColumn10.FilterCellAppearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 8;
    ultraGridColumn10.MinWidth = 15;
    ultraGridColumn10.RowLayoutColumnInfo.OriginX = 18;
    ultraGridColumn10.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn10.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn10.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn10.Width = 100;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 9;
    ultraGridColumn11.MinWidth = 15;
    ultraGridColumn11.RowLayoutColumnInfo.OriginX = 20;
    ultraGridColumn11.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn11.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn11.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn11.Width = 100;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 7;
    ultraGridColumn12.MinWidth = 15;
    ultraGridColumn12.RowLayoutColumnInfo.OriginX = 16 /*0x10*/;
    ultraGridColumn12.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn12.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn12.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn12.Width = 100;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 11;
    ultraGridColumn13.MinWidth = 15;
    ultraGridColumn13.RowLayoutColumnInfo.OriginX = 24;
    ultraGridColumn13.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn13.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn13.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn13.Width = 100;
    ultraGridColumn14.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 18;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.MinWidth = 15;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 10;
    ultraGridColumn15.MinWidth = 15;
    ultraGridColumn15.RowLayoutColumnInfo.OriginX = 22;
    ultraGridColumn15.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn15.RowLayoutColumnInfo.PreferredCellSize = new Size(50, 0);
    ultraGridColumn15.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn15.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn15.Width = 25;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Claim Count";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 12;
    ultraGridColumn16.MinWidth = 15;
    ultraGridColumn16.RowLayoutColumnInfo.OriginX = 26;
    ultraGridColumn16.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn16.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn16.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn16.Width = 100;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Right";
    ultraGridColumn17.CellAppearance = (AppearanceBase) appearance13;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Total Incurred";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 13;
    ultraGridColumn17.MinWidth = 15;
    ultraGridColumn17.RowLayoutColumnInfo.OriginX = 30;
    ultraGridColumn17.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn17.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn17.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn17.Width = 100;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Right";
    ultraGridColumn18.CellAppearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Loss Ratio";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 14;
    ultraGridColumn18.MinWidth = 15;
    ultraGridColumn18.RowLayoutColumnInfo.OriginX = 32 /*0x20*/;
    ultraGridColumn18.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn18.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn18.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn18.Width = 100;
    ultraGridColumn19.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ultraGridColumn19.EditorComponent = (Component) this.lnkControlNo;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Renewal Control";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 19;
    ultraGridColumn19.MinWidth = 15;
    ultraGridColumn19.RowLayoutColumnInfo.OriginX = 34;
    ultraGridColumn19.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn19.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn19.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn20.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 20;
    ultraGridColumn20.Hidden = true;
    ultraGridColumn20.MinWidth = 15;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn21.CellClickAction = (CellClickAction) 1;
    ultraGridColumn21.DefaultCellValue = componentResourceManager.GetObject("ultraGridColumn69.DefaultCellValue");
    ((HeaderBase) ultraGridColumn21.Header).Caption = "";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 0;
    ultraGridColumn21.MinWidth = 15;
    ultraGridColumn21.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn21.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn21.RowLayoutColumnInfo.PreferredCellSize = new Size(45, 0);
    ultraGridColumn21.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn21.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn21.Width = 45;
    ultraGridColumn22.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Billing";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 21;
    ultraGridColumn22.MinWidth = 15;
    ultraGridColumn22.RowLayoutColumnInfo.OriginX = 10;
    ultraGridColumn22.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn22.RowLayoutColumnInfo.PreferredCellSize = new Size(50, 0);
    ultraGridColumn22.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn22.RowLayoutColumnInfo.SpanY = 2;
    ((AppearanceBase) appearance15).TextHAlignAsString = "Right";
    ultraGridColumn23.CellAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Right";
    ultraGridColumn23.FilterCellAppearance = (AppearanceBase) appearance16;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 22;
    ultraGridColumn23.RowLayoutColumnInfo.OriginX = 28;
    ultraGridColumn23.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn23.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn23.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn24.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 23;
    ultraGridColumn24.Hidden = true;
    ultraGridColumn24.MinWidth = 15;
    ultraGridBand.Columns.AddRange(new object[24]
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
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24
    });
    ((HeaderBase) ultraGridBand.Header).Caption = "";
    ((HeaderBase) ultraGridBand.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand.Override.ColumnAutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridBand.RowLayoutStyle = (RowLayoutStyle) 1;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance17).TextHAlignAsString = "Left";
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance18).ForeColor = Color.Black;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.ColumnSizingArea = (ColumnSizingArea) 3;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.MaxSelectedRows = 50;
    ((AppearanceBase) appearance21).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance23).BackColor = Color.Transparent;
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance24).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.grdRenewalSelections).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.grdRenewalSelections).Dock = DockStyle.Fill;
    ((Control) this.grdRenewalSelections).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.grdRenewalSelections).Location = new Point(0, 0);
    ((Control) this.grdRenewalSelections).Margin = new Padding(4);
    ((Control) this.grdRenewalSelections).Name = "grdRenewalSelections";
    ((Control) this.grdRenewalSelections).Size = new Size(885, 338);
    ((Control) this.grdRenewalSelections).TabIndex = 7;
    this.grdRenewalSelections.UpdateMode = (UpdateMode) 3;
    ((UltraControlBase) this.grdRenewalSelections).UseOsThemes = (DefaultableBoolean) 2;
    this.grdRenewalSelections.InitializeRow += new InitializeRowEventHandler(this.grdRenewalSelections_InitializeRow);
    this.grdRenewalSelections.CellChange += new CellEventHandler(this.grdRenewalSelections_CellChange);
    this.spGetBulkRenewalUtilityListBindingSource.DataMember = "spGetBulkRenewalUtilityList";
    this.spGetBulkRenewalUtilityListBindingSource.DataSource = (object) this.dsBulkRenewal;
    this.dsBulkRenewal.DataSetName = "dsBulkRenewal";
    this.dsBulkRenewal.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Left";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).Size = new Size(0, 462);
    this._FormBulkRenewal_Toolbars_Dock_Area_Left.ToolbarsManager = this.exportToolbar;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).Location = new Point(885, 0);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Right";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).Size = new Size(0, 462);
    this._FormBulkRenewal_Toolbars_Dock_Area_Right.ToolbarsManager = this.exportToolbar;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Top";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).Size = new Size(885, 0);
    this._FormBulkRenewal_Toolbars_Dock_Area_Top.ToolbarsManager = this.exportToolbar;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).Location = new Point(0, 462);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).Size = new Size(885, 0);
    this._FormBulkRenewal_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.exportToolbar;
    this.bulkRenewalExporter.BeginExport += new BeginExportEventHandler(this.bulkRenewalExporter_BeginExport);
    this.bulkRenewalExporter.RowExporting += new RowExportingEventHandler(this.bulkRenewalExporter_RowExporting);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(885, 462);
    this.Controls.Add((Control) this.panelContent);
    this.Controls.Add((Control) this.panelTop);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top);
    this.MinimumSize = new Size(657, 296);
    this.Name = nameof (FormBulkRenewal);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Bulk Renewal Selections";
    this.Load += new EventHandler(this.FormBulkRenewal_Load);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    ((ISupportInitialize) this.chkRenewSilently).EndInit();
    ((ISupportInitialize) this.exportToolbar).EndInit();
    ((ISupportInitialize) this.btnViewQueue).EndInit();
    ((ISupportInitialize) this.btnBatch).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnRenew).EndInit();
    ((ISupportInitialize) this.ultraGrid1).EndInit();
    this.panelTop.ResumeLayout(false);
    this.panelTop.PerformLayout();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.panelContent.ResumeLayout(false);
    ((ISupportInitialize) this.grdRenewalSelections).EndInit();
    ((ISupportInitialize) this.spGetBulkRenewalUtilityListBindingSource).EndInit();
    this.dsBulkRenewal.EndInit();
    this.ResumeLayout(false);
  }
}
