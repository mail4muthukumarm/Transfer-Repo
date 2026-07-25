// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Underwriting.Bulk_NonRenewal_Utility.fmBulkNonRenewalResults
// Assembly: MGASystems.IMS.Underwriting, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 1057C5B8-8299-4767-8242-AF9F1EF932DB
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Underwriting.dll

using Infragistics.Win;
using Infragistics.Win.FormattedLinkLabel;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.AsposeFacade.Cells;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.DocumentAutomation;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Underwriting.Bulk_NonRenewal_Utility;

public class fmBulkNonRenewalResults : FormBase
{
  private const int NONRENEWEDSTATUSID = 17;
  private Workbook _workbook;
  private string _fileName;
  private Worksheet _worksheet;
  private int _rowNum = -1;
  public const string ImageRightAutoUploadDocuments = "ImageRightOptions.AutoUploadDocuments";
  private IContainer components;
  public Panel panelContent;
  protected UltraFormattedTextEditor lnkControlNo;
  protected UltraGrid grdPolicySelections;
  private Panel panelTop;
  public Label Label1;
  private PictureBox pictureBox1;
  private Panel panel1;
  private LinkLabel lnkSelectNone;
  private LinkLabel lnkSelectAll;
  protected MGAButton btnCancel;
  protected MGAButton btnChangeStatus;
  private dsNonRenewalResults dsNonRenewalResults1;
  private UltraToolbarsManager exportToolbar;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormBulkRenewal_Toolbars_Dock_Area_Top;
  protected Label Label4;
  protected MGADateTimePicker dtpMailingDate;
  protected UltraComboEditor ddCancelReason;
  protected UltraLabel lblCancelReason;
  protected MGAButton btnUpload;
  protected MGAButton btnCopyfromClipBoard;
  protected MGAButton btnClearGrid;

  public dsNonRenewalResults.NonRenewalsResultsDataTable dtBulkNonRenewal
  {
    get => this.dsNonRenewalResults1.NonRenewalsResults;
  }

  public fmBulkNonRenewalResults() => this.InitializeComponent();

  public fmBulkNonRenewalResults(DataTable dt, int phase)
    : this()
  {
    this.dtBulkNonRenewal.Merge(dt);
  }

  public fmBulkNonRenewalResults(dsNonRenewalResults.NonRenewalsResultsDataTable dt)
    : this()
  {
    this.dtBulkNonRenewal.Merge((DataTable) dt);
  }

  private void fmBulkNonRenewalResults_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    DefaultDatabase.LoadDataSet((DataSet) this.dsNonRenewalResults1, new string[1]
    {
      this.dsNonRenewalResults1.lstQuoteStatusReasons.TableName
    }, "GetQuoteStatusReasonsByLine", new object[6]
    {
      (object) "@quoteStatusID",
      (object) 17,
      (object) "@lineGuid",
      null,
      (object) "@QuoteGuid",
      null
    });
    ((Control) this.btnUpload).Enabled = true;
    if (!MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ShowCopyFromExcelButtonOnBulkUtility", true))
      return;
    ((Control) this.btnCopyfromClipBoard).Visible = true;
  }

  private void btnRenew_Click(object sender, EventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    (bool, bool) valueTuple = (MGASystems.IMS.NoteDocuments.Common.BlackBoxMode, CompanyDocumentAutomation.BlackBoxMode);
    CompanyDocumentAutomation.BlackBoxMode = MGASystems.IMS.NoteDocuments.Common.BlackBoxMode = true;
    bool setting = MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("ImageRightOptions.AutoUploadDocuments", true);
    try
    {
      DefaultDatabase.ExecuteNonQuery("Appalachian_UpdateBatchNonRenewalSystemSetting", new object[2]
      {
        (object) "@turnOn",
        (object) false
      });
      this.BackgroundRenewPolicies();
      CompanyDocumentAutomation.BlackBoxMode = valueTuple.Item2;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
      MGASystems.IMS.NoteDocuments.Common.BlackBoxMode = valueTuple.Item1;
    }
    this.RefreshGridData();
    DefaultDatabase.ExecuteNonQuery("Appalachian_UpdateBatchNonRenewalSystemSetting", new object[2]
    {
      (object) "@turnOn",
      (object) setting
    });
  }

  private void RefreshGridData()
  {
    this.dtBulkNonRenewal.AcceptChanges();
    ((UltraGridBase) this.grdPolicySelections).UpdateData();
    ((Control) this.grdPolicySelections).Refresh();
  }

  private void BackgroundRenewPolicies()
  {
    dsNonRenewalResults.PolicyProcessedDataTable processedDataTable = new dsNonRenewalResults.PolicyProcessedDataTable();
    foreach (dsNonRenewalResults.NonRenewalsResultsRow renewalsResultsRow in this.dtBulkNonRenewal.Where<dsNonRenewalResults.NonRenewalsResultsRow>((System.Func<dsNonRenewalResults.NonRenewalsResultsRow, bool>) (tr => tr.Selected)).ToList<dsNonRenewalResults.NonRenewalsResultsRow>())
    {
      dsNonRenewalResults.PolicyProcessedRow row = (dsNonRenewalResults.PolicyProcessedRow) null;
      try
      {
        row = processedDataTable.NewPolicyProcessedRow();
        row.ControlNo = renewalsResultsRow.ControlNo;
        if (!renewalsResultsRow.IsquoteidNull())
        {
          row.quoteid = renewalsResultsRow.quoteid;
        }
        else
        {
          try
          {
            row.quoteid = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "select dbo.getmaxboundQuoteid(@controlNo)", new object[2]
            {
              (object) "@controlNo",
              (object) row.ControlNo
            });
          }
          catch (Exception ex)
          {
            renewalsResultsRow.Status = "Error processing non renewal.  Error:  The control number is not eligible for non renewal.  It has to be a bound status and exist in in IMS.  Error: " + ex.Message;
            int num = (int) MessageBox.Show($"Invalid control Number or control number does not exist in IMS and /or control number is not bound.  Control Num: {row.ControlNo}.  Processing Stopped.   Please uncheck the control and click nonrnew again to continue processing.", "Control number does not exist in IMS and / or is not bound status.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          }
        }
        row.quotestatusreasonid = !renewalsResultsRow.IsquotestatusreasonidNull() ? renewalsResultsRow.quotestatusreasonid : -1;
        renewalsResultsRow.Status = $"Processing {row.ControlNo}...";
        Quote quote = new Quote(row.quoteid);
        quote.ChangeStatus(17, row.quotestatusreasonid, "Quote status changed to non-renewed via Non- Renewed Bulk Utility");
        CurrentUser.Instance.LogAction($"Batch Non-Renewal Utility - The quote is updated to nonrenew via IMS Batch non-renewal. ControlNo - {quote.ControlNo}", quote.QuoteGuid);
        if (!renewalsResultsRow.IsmailingDateNull())
        {
          DefaultDatabase.ExecuteNonQuery("dbo.spSaveNonRenewedStatusInfo", new object[4]
          {
            (object) "@QuoteID",
            (object) row.quoteid,
            (object) "@NonRenewedMailingDate",
            (object) renewalsResultsRow.mailingDate
          });
          CurrentUser.Instance.LogAction($"Batch Non-Renewal Utility - The mailing date was updated via IMS Batch non-renewal. ControlNo - {quote.ControlNo}", quote.QuoteGuid);
        }
        CompanyDocumentAutomation.BlackBoxMode = true;
        MGASystems.IMS.NoteDocuments.Common.BlackBoxMode = true;
        Messaging.SendBroadcastMessage(BroadcastMessages.NonRenewed, (object) quote.QuoteGuid);
        renewalsResultsRow.Status = $"Converted to cancellation successfully. Status updated to Non_renewal for control {quote.ControlNo}.";
        this.DeactivateRow(((UltraGridBase) this.grdPolicySelections).Rows.GetRowWithListIndex(this.dtBulkNonRenewal.Rows.IndexOf((DataRow) this.dtBulkNonRenewal.FindByControlNo(quote.ControlNo))), Color.Green);
        CurrentUser.Instance.LogAction($"Batch Non-Renewal Utility - Policy was successfully updated to a non renewal status via IMS Batch non-renewal. ControlNo - {quote.ControlNo}", quote.QuoteGuid);
      }
      catch (Exception ex)
      {
        this.Cursor = MgaCursors.Default;
        renewalsResultsRow.Status = $"{$"Error processing non renewal for control {row.ControlNo}.  The control number is not eligible for non renewal.  It has to be a bound status and exist in in IMS."}Error{ex.Message}";
        CurrentUser.Instance.LogAction($"Batch Non-Renewal Utility - Policy failed to be updated to a non renewal status via IMS Batch non-renewal. ControlNo - {row.ControlNo}", row.ControlNo);
        this.DeactivateRow(((UltraGridBase) this.grdPolicySelections).Rows.GetRowWithListIndex(this.dtBulkNonRenewal.Rows.IndexOf((DataRow) this.dtBulkNonRenewal.FindByControlNo(row.ControlNo))), Color.Red);
      }
      this.Cursor = MgaCursors.Default;
      processedDataTable.AddPolicyProcessedRow(row);
    }
  }

  private void DeactivateRow(UltraGridRow row, Color appearanceColor)
  {
    ((AppearanceBase) row.Appearance).ForeColorDisabled = appearanceColor;
    row.Activation = (Activation) 2;
    row.Cells["ControlNo"].IgnoreRowColActivation = true;
    row.Cells["ControlNo"].Activation = (Activation) 3;
  }

  private void btnCancel_Click(object sender, EventArgs e) => this.Close();

  private void grdRenewalSelections_CellChange(object sender, CellEventArgs e)
  {
    if (sender == null)
      return;
    this.grdPolicySelections.PerformAction((UltraGridAction) 44);
    ((Control) this.btnChangeStatus).Enabled = this.dtBulkNonRenewal.Any<dsNonRenewalResults.NonRenewalsResultsRow>((System.Func<dsNonRenewalResults.NonRenewalsResultsRow, bool>) (tr => tr.Selected));
    ((Control) this.btnUpload).Enabled = !this.dtBulkNonRenewal.Any<dsNonRenewalResults.NonRenewalsResultsRow>((System.Func<dsNonRenewalResults.NonRenewalsResultsRow, bool>) (tr => tr.Selected));
    ((Control) this.btnCopyfromClipBoard).Enabled = !this.dtBulkNonRenewal.Any<dsNonRenewalResults.NonRenewalsResultsRow>((System.Func<dsNonRenewalResults.NonRenewalsResultsRow, bool>) (tr => tr.Selected));
  }

  private void lnkControlNo_LinkClicked(object sender, LinkClickedEventArgs e)
  {
    int result;
    if (string.IsNullOrEmpty(e.LinkText) || !int.TryParse(e.LinkText, out result) || !Quote.ControlNumberExists(result))
      return;
    MGASystems.Common.FormSettings.ShowForm(typeof (frmPolicyDetail), (object) result);
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectRows(true);
  }

  private void lnkSelectNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectRows(false);
  }

  private void SelectRows(bool selected)
  {
    foreach (UltraGridRow ultraGridRow in ((IEnumerable) ((UltraGridBase) this.grdPolicySelections).Rows).OfType<UltraGridRow>().Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (r => r.Activation != 2 && !r.IsFilteredOut)))
      ultraGridRow.Cells["Selected"].Value = (object) selected;
    MGAButton btnChangeStatus = this.btnChangeStatus;
    MGADateTimePicker dtpMailingDate = this.dtpMailingDate;
    dsNonRenewalResults.NonRenewalsResultsDataTable dtBulkNonRenewal = this.dtBulkNonRenewal;
    int num1;
    bool flag = (num1 = dtBulkNonRenewal.Any<dsNonRenewalResults.NonRenewalsResultsRow>((System.Func<dsNonRenewalResults.NonRenewalsResultsRow, bool>) (tr => tr.Selected)) ? 1 : 0) != 0;
    ((Control) dtpMailingDate).Enabled = num1 != 0;
    int num2 = flag ? 1 : 0;
    ((Control) btnChangeStatus).Enabled = num2 != 0;
    ((Control) this.btnUpload).Enabled = !selected;
    ((Control) this.btnCopyfromClipBoard).Enabled = !selected;
  }

  private void lnkPaste_Click(object sender, EventArgs e) => this.copyDataontoGrid();

  private void copyDataontoGrid()
  {
    string str1 = string.Empty;
    IDataObject dataObject = Clipboard.GetDataObject();
    if (dataObject.GetDataPresent(DataFormats.Text))
      str1 = (string) dataObject.GetData(DataFormats.Text);
    string[] strArray1 = str1.Split(new string[2]
    {
      "\r\n",
      "\n"
    }, StringSplitOptions.None);
    if (strArray1.Length == 0)
    {
      int num1 = (int) MessageBox.Show("No data is present on the clipboard", "No Data Present", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (!strArray1[0].Contains("CONTROL NUMBER"))
    {
      int num2 = (int) MessageBox.Show("CONTROL NUMBER is not present on the clipboard.  No data is pasted onto the grid.", "No Data Present", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      this.dsNonRenewalResults1.NonRenewalsResults.Clear();
      Dictionary<int, string> dict = new Dictionary<int, string>();
      string[] strArray2 = strArray1[0].Split(Convert.ToChar("\t"));
      int key = 0;
      foreach (string str2 in strArray2)
      {
        dict.Add(key, str2.ToUpper());
        ++key;
      }
      int num3 = 0;
      StringBuilder stringBuilder = new StringBuilder();
      for (int index = 1; index < strArray1.Length; ++index)
      {
        try
        {
          string[] strArray3 = strArray1[index].Split('\t');
          if (strArray3.Length > 1)
          {
            dsNonRenewalResults.NonRenewalsResultsRow row = this.dsNonRenewalResults1.NonRenewalsResults.NewNonRenewalsResultsRow();
            row.Selected = true;
            try
            {
              int columnPosition = this.GetColumnPosition("MAILING DATE", dict);
              if (columnPosition != -1 && strArray3[columnPosition].Replace(" ", string.Empty).Length > 0)
                row.mailingDate = Convert.ToDateTime(strArray3[columnPosition].ToString());
              else
                row.SetmailingDateNull();
            }
            catch (Exception ex)
            {
              ++num3;
              throw new InvalidOperationException(ex.Message + "MAILING DATE is not properly formatted.");
            }
            try
            {
              int columnPosition = this.GetColumnPosition("CONTROL NUMBER", dict);
              if (columnPosition != -1)
              {
                if (strArray3[columnPosition].Replace(" ", string.Empty).Length > 0)
                  row.ControlNo = Convert.ToInt32(strArray3[columnPosition].ToString());
              }
            }
            catch (Exception ex)
            {
              ++num3;
              throw new InvalidOperationException(ex.Message + "CONTROL NUMBER is not properly formatted.");
            }
            try
            {
              int columnPosition = this.GetColumnPosition("REASON ID", dict);
              if (columnPosition != -1 && strArray3[columnPosition].Replace(" ", string.Empty).Length > 0)
                row.quotestatusreasonid = Convert.ToInt32(strArray3[columnPosition].ToString());
              else
                row.SetquotestatusreasonidNull();
            }
            catch (Exception ex)
            {
              ++num3;
              throw new InvalidOperationException(ex.Message + " REASON ID is not properly formatted.  It needs to be a number that exists as part of cancellation reasosn list.");
            }
            this.dsNonRenewalResults1.NonRenewalsResults.AddNonRenewalsResultsRow(row);
          }
        }
        catch (Exception ex)
        {
          ++num3;
          if (num3 < 6)
            stringBuilder.AppendLine($"Line # {index} - {ex.Message}");
        }
      }
      if (num3 > 0)
      {
        int num4 = strArray1.Length - 1;
        ((Control) this.btnChangeStatus).Enabled = false;
        int num5 = (int) MessageBox.Show(stringBuilder.ToString(), $"{num3.ToString()} of {num4.ToString()} records failed.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
        ((Control) this.btnChangeStatus).Enabled = true;
    }
  }

  private int GetColumnPosition(string columnName, Dictionary<int, string> dict)
  {
    foreach (KeyValuePair<int, string> keyValuePair in dict)
    {
      if (keyValuePair.Value.Equals(columnName))
        return keyValuePair.Key;
    }
    return -1;
  }

  private void dtpMailingDate_ValueChanged(object sender, EventArgs e)
  {
    foreach (dsNonRenewalResults.NonRenewalsResultsRow renewalsResultsRow in this.dtBulkNonRenewal.Where<dsNonRenewalResults.NonRenewalsResultsRow>((System.Func<dsNonRenewalResults.NonRenewalsResultsRow, bool>) (tr => tr.Selected)))
    {
      if (this.dtpMailingDate.Value != null)
        renewalsResultsRow.mailingDate = Convert.ToDateTime(this.dtpMailingDate.Value);
      else
        renewalsResultsRow.SetmailingDateNull();
    }
  }

  private void ddCancelReason_ValueChanged(object sender, EventArgs e)
  {
    foreach (dsNonRenewalResults.NonRenewalsResultsRow renewalsResultsRow in this.dtBulkNonRenewal.Where<dsNonRenewalResults.NonRenewalsResultsRow>((System.Func<dsNonRenewalResults.NonRenewalsResultsRow, bool>) (tr => tr.Selected)))
    {
      if (((TextEditorControlBase) this.ddCancelReason).Value != null)
        renewalsResultsRow.quotestatusreasonid = Convert.ToInt32(((TextEditorControlBase) this.ddCancelReason).Value);
      else
        renewalsResultsRow.SetquotestatusreasonidNull();
    }
  }

  private void mgaButton1_Click(object sender, EventArgs e)
  {
    OpenFileDialog openFileDialog = new OpenFileDialog();
    openFileDialog.DefaultExt = "xls";
    openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files 97-2003(*.xls)|*.xls";
    openFileDialog.FilterIndex = 1;
    openFileDialog.Title = "Please select the Excel file to upload";
    openFileDialog.InitialDirectory = "C:\\";
    openFileDialog.RestoreDirectory = true;
    if (openFileDialog.ShowDialog() == DialogResult.OK)
    {
      this._fileName = openFileDialog.FileName;
      this._workbook = new Workbook(this._fileName);
      this._worksheet = this._workbook.Worksheets[0];
      this.Cursor = MgaCursors.WaitCursor;
    }
    this.dsNonRenewalResults1.NonRenewalsResults.Clear();
    try
    {
      foreach (Row row1 in (IEnumerable<Row>) this._worksheet.Cells.Rows)
      {
        ++this._rowNum;
        if (row1.Index != 0)
        {
          dsNonRenewalResults.NonRenewalsResultsRow row2 = this.dsNonRenewalResults1.NonRenewalsResults.NewNonRenewalsResultsRow();
          row2.Selected = true;
          try
          {
            if (Utility.IsNull(this._worksheet.Cells[row1.Index, 0].Value))
              throw new InvalidOperationException();
            row2.ControlNo = Convert.ToInt32(this._worksheet.Cells[row1.Index, 0].Value);
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show($"CONTROLNO is not properly formatted or is missing.  Line Number: {this._rowNum}. Import Stopped. {ex.Message}", "Control number is missing or is not formatted properly.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          }
          try
          {
            if (!Utility.IsNull(this._worksheet.Cells[row1.Index, 1].Value))
              row2.quotestatusreasonid = Convert.ToInt32(this._worksheet.Cells[row1.Index, 1].Value);
            else
              row2.SetquoteidNull();
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show($"REASON ID is not properly formatted. It needs to be a number or it can be blank.  Line Number: {this._rowNum}. Import Stopped. {ex.Message}", "Control number is missing or is not formatted properly.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          }
          try
          {
            if (!Utility.IsNull(this._worksheet.Cells[row1.Index, 2].Value))
              row2.mailingDate = Convert.ToDateTime(this._worksheet.Cells[row1.Index, 2].Value);
            else
              row2.SetmailingDateNull();
          }
          catch (Exception ex)
          {
            this.Cursor = MgaCursors.Default;
            ((Control) this.btnChangeStatus).Enabled = false;
            int num = (int) MessageBox.Show($"MAILING DATE is not properly formatted. It needs to be a date or it can be blank.  Line Number: {this._rowNum}. Import Stopped. {ex.Message}", "Control number is missing or is not formatted properly.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            break;
          }
          this.dsNonRenewalResults1.NonRenewalsResults.AddNonRenewalsResultsRow(row2);
        }
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
      ((Control) this.btnChangeStatus).Enabled = true;
    }
  }

  private void btnCopyfromClipBoard_Click(object sender, EventArgs e) => this.copyDataontoGrid();

  private void btnClearGrid_Click(object sender, EventArgs e)
  {
    this.dsNonRenewalResults1.NonRenewalsResults.Clear();
    ((Control) this.btnCopyfromClipBoard).Enabled = true;
    ((Control) this.btnUpload).Enabled = true;
    ((Control) this.btnChangeStatus).Enabled = false;
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
    UltraGridBand ultraGridBand = new UltraGridBand("NonRenewalsResults", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Insured");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerLocationName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ExpirationDate");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ControlNo");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Company");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Lines");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Status");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Selected");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (fmBulkNonRenewalResults));
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("quoteid");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("quotestatusreasonid");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("mailingDate");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("QuoteStatusBound", 0);
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    ButtonTool buttonTool1 = new ButtonTool("ExportReport");
    ButtonTool buttonTool2 = new ButtonTool("ExportSpreadsheet");
    PopupMenuTool popupMenuTool = new PopupMenuTool("N/A");
    ButtonTool buttonTool3 = new ButtonTool("ExportReport");
    ButtonTool buttonTool4 = new ButtonTool("ExportSpreadsheet");
    Appearance appearance20 = new Appearance();
    this.lnkControlNo = new UltraFormattedTextEditor();
    this.panelContent = new Panel();
    this.grdPolicySelections = new UltraGrid();
    this.dsNonRenewalResults1 = new dsNonRenewalResults();
    this.panelTop = new Panel();
    this.Label1 = new Label();
    this.pictureBox1 = new PictureBox();
    this.panel1 = new Panel();
    this.btnCopyfromClipBoard = new MGAButton();
    this.btnUpload = new MGAButton();
    this.ddCancelReason = new UltraComboEditor();
    this.lblCancelReason = new UltraLabel();
    this.Label4 = new Label();
    this.dtpMailingDate = new MGADateTimePicker();
    this.lnkSelectNone = new LinkLabel();
    this.lnkSelectAll = new LinkLabel();
    this.btnCancel = new MGAButton();
    this.btnChangeStatus = new MGAButton();
    this.exportToolbar = new UltraToolbarsManager(this.components);
    this._FormBulkRenewal_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormBulkRenewal_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._FormBulkRenewal_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormBulkRenewal_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.btnClearGrid = new MGAButton();
    this.panelContent.SuspendLayout();
    ((ISupportInitialize) this.grdPolicySelections).BeginInit();
    this.dsNonRenewalResults1.BeginInit();
    this.panelTop.SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.btnCopyfromClipBoard).BeginInit();
    ((ISupportInitialize) this.btnUpload).BeginInit();
    ((ISupportInitialize) this.ddCancelReason).BeginInit();
    ((ISupportInitialize) this.dtpMailingDate).BeginInit();
    ((ISupportInitialize) this.btnCancel).BeginInit();
    ((ISupportInitialize) this.btnChangeStatus).BeginInit();
    ((ISupportInitialize) this.exportToolbar).BeginInit();
    ((ISupportInitialize) this.btnClearGrid).BeginInit();
    this.SuspendLayout();
    ((Control) this.lnkControlNo).Location = new Point(45, 54);
    ((Control) this.lnkControlNo).Name = "lnkControlNo";
    ((Control) this.lnkControlNo).Size = new Size(72, 23);
    ((Control) this.lnkControlNo).TabIndex = 13;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).TreatValueAs = (TreatValueAs) 2;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).Value = (object) "controlno";
    ((Control) this.lnkControlNo).Visible = false;
    ((UltraFormattedTextEditorBase) this.lnkControlNo).LinkClicked += new LinkClickedEventHandler(this.lnkControlNo_LinkClicked);
    this.panelContent.BackColor = Color.Transparent;
    this.panelContent.Controls.Add((Control) this.lnkControlNo);
    this.panelContent.Controls.Add((Control) this.grdPolicySelections);
    this.panelContent.Dock = DockStyle.Fill;
    this.panelContent.Location = new Point(0, 72);
    this.panelContent.Name = "panelContent";
    this.panelContent.Size = new Size(800, 302);
    this.panelContent.TabIndex = 9;
    ((UltraGridBase) this.grdPolicySelections).DataMember = "NonRenewalsResults";
    ((UltraGridBase) this.grdPolicySelections).DataSource = (object) this.dsNonRenewalResults1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ultraGridColumn1.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 3;
    ultraGridColumn1.MinWidth = 15;
    ultraGridColumn1.RowLayoutColumnInfo.OriginX = 10;
    ultraGridColumn1.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn1.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn1.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn1.Width = 100;
    ultraGridColumn2.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 9;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.MinWidth = 15;
    ultraGridColumn3.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Right";
    ultraGridColumn3.FilterCellAppearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Expiration Date";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.MinWidth = 15;
    ultraGridColumn3.RowLayoutColumnInfo.OriginX = 14;
    ultraGridColumn3.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn3.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn3.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn3.Width = 75;
    ultraGridColumn4.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ultraGridColumn4.EditorComponent = (Component) this.lnkControlNo;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn4.FilterCellAppearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 1;
    ultraGridColumn4.MinWidth = 15;
    ultraGridColumn4.RowLayoutColumnInfo.OriginX = 2;
    ultraGridColumn4.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn4.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn4.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn4.Width = 75;
    ultraGridColumn5.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.MinWidth = 15;
    ultraGridColumn5.RowLayoutColumnInfo.OriginX = 12;
    ultraGridColumn5.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn5.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn5.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn5.Width = 100;
    ultraGridColumn6.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn6.MinWidth = 15;
    ultraGridColumn6.RowLayoutColumnInfo.OriginX = 18;
    ultraGridColumn6.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn6.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn6.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn6.Width = 100;
    ultraGridColumn7.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Policy Number";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 5;
    ultraGridColumn7.MinWidth = 15;
    ultraGridColumn7.RowLayoutColumnInfo.OriginX = 16 /*0x10*/;
    ultraGridColumn7.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn7.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn7.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn7.Width = 100;
    ultraGridColumn8.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 7;
    ultraGridColumn8.MinWidth = 15;
    ultraGridColumn8.RowLayoutColumnInfo.OriginX = 8;
    ultraGridColumn8.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn8.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn8.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn8.Width = 100;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 8;
    ultraGridColumn9.RowLayoutColumnInfo.OriginX = 20;
    ultraGridColumn9.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn9.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn9.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn10.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn10.CellClickAction = (CellClickAction) 1;
    ultraGridColumn10.DefaultCellValue = componentResourceManager.GetObject("ultraGridColumn35.DefaultCellValue");
    ((HeaderBase) ultraGridColumn10.Header).Caption = "";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 0;
    ultraGridColumn10.MinWidth = 15;
    ultraGridColumn10.RowLayoutColumnInfo.OriginX = 0;
    ultraGridColumn10.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn10.RowLayoutColumnInfo.PreferredCellSize = new Size(45, 0);
    ultraGridColumn10.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn10.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn10.Width = 45;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 10;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.RowLayoutColumnInfo.OriginX = 22;
    ultraGridColumn11.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn11.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn11.RowLayoutColumnInfo.SpanY = 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Cancellation Reason ID";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 11;
    ultraGridColumn12.RowLayoutColumnInfo.OriginX = 4;
    ultraGridColumn12.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn12.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn12.RowLayoutColumnInfo.SpanY = 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Mailing Date";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 12;
    ultraGridColumn13.RowLayoutColumnInfo.OriginX = 6;
    ultraGridColumn13.RowLayoutColumnInfo.OriginY = 0;
    ultraGridColumn13.RowLayoutColumnInfo.SpanX = 2;
    ultraGridColumn13.RowLayoutColumnInfo.SpanY = 2;
    ultraGridColumn14.AutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.MinWidth = 15;
    ultraGridBand.Columns.AddRange(new object[14]
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
      (object) ultraGridColumn14
    });
    ((HeaderBase) ultraGridBand.Header).Caption = "";
    ((HeaderBase) ultraGridBand.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand.Override.ColumnAutoSizeMode = (ColumnAutoSizeMode) 4;
    ultraGridBand.RowLayoutStyle = (RowLayoutStyle) 1;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.ColumnSizingArea = (ColumnSizingArea) 3;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.MaxSelectedRows = 50;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.grdPolicySelections).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.grdPolicySelections).Dock = DockStyle.Fill;
    ((Control) this.grdPolicySelections).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.grdPolicySelections).Location = new Point(0, 0);
    ((Control) this.grdPolicySelections).Margin = new Padding(4);
    ((Control) this.grdPolicySelections).Name = "grdPolicySelections";
    ((Control) this.grdPolicySelections).Size = new Size(800, 302);
    ((Control) this.grdPolicySelections).TabIndex = 7;
    this.grdPolicySelections.UpdateMode = (UpdateMode) 3;
    ((UltraControlBase) this.grdPolicySelections).UseOsThemes = (DefaultableBoolean) 2;
    this.grdPolicySelections.CellChange += new CellEventHandler(this.grdRenewalSelections_CellChange);
    this.dsNonRenewalResults1.DataSetName = "dsNonRenewalResults";
    this.dsNonRenewalResults1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.panelTop.BackColor = Color.Transparent;
    this.panelTop.Controls.Add((Control) this.Label1);
    this.panelTop.Controls.Add((Control) this.pictureBox1);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(800, 72);
    this.panelTop.TabIndex = 8;
    this.Label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.Label1.AutoSize = true;
    this.Label1.Font = new Font("Tahoma", 18f);
    this.Label1.ForeColor = Color.SteelBlue;
    this.Label1.Location = new Point(512 /*0x0200*/, 37);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(272, 29);
    this.Label1.TabIndex = 2;
    this.Label1.Text = "Bulk Non Renewal Utility";
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(21, 16 /*0x10*/);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(58, 50);
    this.pictureBox1.TabIndex = 0;
    this.pictureBox1.TabStop = false;
    this.panel1.BackColor = Color.Transparent;
    this.panel1.Controls.Add((Control) this.btnClearGrid);
    this.panel1.Controls.Add((Control) this.btnCopyfromClipBoard);
    this.panel1.Controls.Add((Control) this.btnUpload);
    this.panel1.Controls.Add((Control) this.ddCancelReason);
    this.panel1.Controls.Add((Control) this.lblCancelReason);
    this.panel1.Controls.Add((Control) this.Label4);
    this.panel1.Controls.Add((Control) this.dtpMailingDate);
    this.panel1.Controls.Add((Control) this.lnkSelectNone);
    this.panel1.Controls.Add((Control) this.lnkSelectAll);
    this.panel1.Controls.Add((Control) this.btnCancel);
    this.panel1.Controls.Add((Control) this.btnChangeStatus);
    this.panel1.Dock = DockStyle.Bottom;
    this.panel1.Location = new Point(0, 374);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(800, 171);
    this.panel1.TabIndex = 7;
    ((Control) this.btnCopyfromClipBoard).Anchor = AnchorStyles.None;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance13).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance13).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance13).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCopyfromClipBoard).Appearance = (AppearanceBase) appearance13;
    ((Control) this.btnCopyfromClipBoard).Location = new Point(395, 112 /*0x70*/);
    ((Control) this.btnCopyfromClipBoard).Name = "btnCopyfromClipBoard";
    ((Control) this.btnCopyfromClipBoard).Size = new Size(75, 34);
    ((Control) this.btnCopyfromClipBoard).TabIndex = 89;
    ((Control) this.btnCopyfromClipBoard).Text = "Paste from Excel";
    ((UltraControlBase) this.btnCopyfromClipBoard).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCopyfromClipBoard).Click += new EventHandler(this.btnCopyfromClipBoard_Click);
    ((Control) this.btnUpload).Anchor = AnchorStyles.None;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance14).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance14).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance14).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnUpload).Appearance = (AppearanceBase) appearance14;
    ((Control) this.btnUpload).Location = new Point(476, 112 /*0x70*/);
    ((Control) this.btnUpload).Name = "btnUpload";
    ((Control) this.btnUpload).Size = new Size(75, 34);
    ((Control) this.btnUpload).TabIndex = 88;
    ((Control) this.btnUpload).Text = "Upload Excel File";
    ((UltraControlBase) this.btnUpload).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnUpload).Click += new EventHandler(this.mgaButton1_Click);
    ((Control) this.ddCancelReason).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ddCancelReason.DataMember = "lstQuoteStatusReasons";
    this.ddCancelReason.DataSource = (object) this.dsNonRenewalResults1;
    this.ddCancelReason.DisplayMember = "Reason";
    this.ddCancelReason.DropDownStyle = (DropDownStyle) 1;
    ((Control) this.ddCancelReason).Location = new Point(126, 49);
    ((Control) this.ddCancelReason).Name = "ddCancelReason";
    ((Control) this.ddCancelReason).Size = new Size(527, 21);
    ((Control) this.ddCancelReason).TabIndex = 86;
    this.ddCancelReason.ValueMember = "ID";
    ((TextEditorControlBase) this.ddCancelReason).ValueChanged += new EventHandler(this.ddCancelReason_ValueChanged);
    ((AppearanceBase) appearance15).BackColorAlpha = (Alpha) 3;
    ((ControlBase) this.lblCancelReason).Appearance = (AppearanceBase) appearance15;
    ((Control) this.lblCancelReason).Location = new Point(12, 53);
    ((Control) this.lblCancelReason).Name = "lblCancelReason";
    ((Control) this.lblCancelReason).Size = new Size(109, 18);
    ((Control) this.lblCancelReason).TabIndex = 85;
    ((Control) this.lblCancelReason).Text = "Cancellation Reason";
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(9, 28);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(69, 13);
    this.Label4.TabIndex = 15;
    this.Label4.Text = "Mailing Date:";
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtpMailingDate.Appearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance17).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance17).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance17).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance17).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance17).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance17).ForegroundAlpha = (Alpha) 2;
    this.dtpMailingDate.ButtonAppearance = (AppearanceBase) appearance17;
    this.dtpMailingDate.DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpMailingDate).Location = new Point(126, 25);
    this.dtpMailingDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtpMailingDate).Name = "dtpMailingDate";
    ((Control) this.dtpMailingDate).Size = new Size(89, 19);
    ((Control) this.dtpMailingDate).TabIndex = 14;
    ((UltraControlBase) this.dtpMailingDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpMailingDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dtpMailingDate.Value = (object) null;
    this.dtpMailingDate.ValueChanged += new EventHandler(this.dtpMailingDate_ValueChanged);
    this.lnkSelectNone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectNone.AutoSize = true;
    this.lnkSelectNone.BackColor = Color.Transparent;
    this.lnkSelectNone.Location = new Point(13, 149);
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
    this.lnkSelectAll.Location = new Point(13, 128 /*0x80*/);
    this.lnkSelectAll.Margin = new Padding(4, 0, 4, 0);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 11;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkSelectAll.LinkClicked += new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
    ((Control) this.btnCancel).Anchor = AnchorStyles.None;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance18).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance18).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance18).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance18).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnCancel).Appearance = (AppearanceBase) appearance18;
    ((Control) this.btnCancel).Location = new Point(718, 112 /*0x70*/);
    ((Control) this.btnCancel).Name = "btnCancel";
    ((Control) this.btnCancel).Size = new Size(75, 34);
    ((Control) this.btnCancel).TabIndex = 1;
    ((Control) this.btnCancel).Text = "Close";
    ((UltraControlBase) this.btnCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnCancel).Click += new EventHandler(this.btnCancel_Click);
    ((Control) this.btnChangeStatus).Anchor = AnchorStyles.None;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance19).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance19).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance19).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance19).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance19).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnChangeStatus).Appearance = (AppearanceBase) appearance19;
    ((Control) this.btnChangeStatus).Enabled = false;
    ((Control) this.btnChangeStatus).Location = new Point(557, 112 /*0x70*/);
    ((Control) this.btnChangeStatus).Name = "btnChangeStatus";
    ((Control) this.btnChangeStatus).Size = new Size(75, 34);
    ((Control) this.btnChangeStatus).TabIndex = 0;
    ((Control) this.btnChangeStatus).Text = "NonRenew";
    ((UltraControlBase) this.btnChangeStatus).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnChangeStatus).Click += new EventHandler(this.btnRenew_Click);
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
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Top";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top).Size = new Size(800, 0);
    this._FormBulkRenewal_Toolbars_Dock_Area_Top.ToolbarsManager = this.exportToolbar;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).Location = new Point(0, 545);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom).Size = new Size(800, 0);
    this._FormBulkRenewal_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.exportToolbar;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Left";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left).Size = new Size(0, 545);
    this._FormBulkRenewal_Toolbars_Dock_Area_Left.ToolbarsManager = this.exportToolbar;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._FormBulkRenewal_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).Location = new Point(800, 0);
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).Name = "_FormBulkRenewal_Toolbars_Dock_Area_Right";
    ((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right).Size = new Size(0, 545);
    this._FormBulkRenewal_Toolbars_Dock_Area_Right.ToolbarsManager = this.exportToolbar;
    ((Control) this.btnClearGrid).Anchor = AnchorStyles.None;
    ((AppearanceBase) appearance20).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance20).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance20).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance20).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance20).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance20).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnClearGrid).Appearance = (AppearanceBase) appearance20;
    ((Control) this.btnClearGrid).Location = new Point(637, 112 /*0x70*/);
    ((Control) this.btnClearGrid).Name = "btnClearGrid";
    ((Control) this.btnClearGrid).Size = new Size(75, 34);
    ((Control) this.btnClearGrid).TabIndex = 90;
    ((Control) this.btnClearGrid).Text = "Clear Grid";
    ((UltraControlBase) this.btnClearGrid).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnClearGrid).Click += new EventHandler(this.btnClearGrid_Click);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(800, 545);
    this.Controls.Add((Control) this.panelContent);
    this.Controls.Add((Control) this.panelTop);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormBulkRenewal_Toolbars_Dock_Area_Top);
    this.Name = nameof (fmBulkNonRenewalResults);
    this.Text = "Bulk NON-Renewal Selections";
    this.Load += new EventHandler(this.fmBulkNonRenewalResults_Load);
    this.panelContent.ResumeLayout(false);
    ((ISupportInitialize) this.grdPolicySelections).EndInit();
    this.dsNonRenewalResults1.EndInit();
    this.panelTop.ResumeLayout(false);
    this.panelTop.PerformLayout();
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    ((ISupportInitialize) this.btnCopyfromClipBoard).EndInit();
    ((ISupportInitialize) this.btnUpload).EndInit();
    ((ISupportInitialize) this.ddCancelReason).EndInit();
    ((ISupportInitialize) this.dtpMailingDate).EndInit();
    ((ISupportInitialize) this.btnCancel).EndInit();
    ((ISupportInitialize) this.btnChangeStatus).EndInit();
    ((ISupportInitialize) this.exportToolbar).EndInit();
    ((ISupportInitialize) this.btnClearGrid).EndInit();
    this.ResumeLayout(false);
  }
}
