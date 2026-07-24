// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.FormDirectBillPayablesUtility
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using GrapeCity.ActiveReports;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Exceptions;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.PolicyServices;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.IMS.Reporting;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class FormDirectBillPayablesUtility : FormBase
{
  private int _apGLacctId;
  private bool _formClosing;
  private string _nextPayeeName = string.Empty;
  protected string sprocName = "spFin_DirectBillPayables_GetInvoiceList";
  protected string spocPayMethodsName = "spFin_GetDirectBillPaymentMethods";
  protected int _negativeCount;
  protected int _transactNum;
  private IContainer components;
  protected MGACheckBox checkLimitCompanyGroups;
  protected MGASimpleComboBox comboCompanyGroups;
  protected MGACheckBox checkLimitCompanies;
  protected MGASimpleComboBox comboCompanies;
  protected MGADateTimePicker dateTimeCheckDate;
  protected Label label13;
  protected MGASimpleComboBox comboBankAccounts;
  protected Label label12;
  protected CheckBox checkShowOthers;
  protected CheckBox checkShowCompanies;
  protected CheckBox checkShowProducers;
  protected MGADateTimePicker dateTimeCutOff;
  protected Label label11;
  protected MGASimpleComboBox comboOfficeLocation;
  protected Label labelOfficeLocation;
  protected MGAButton buttonContinue;
  protected MGAButton buttonPostSelectedResults;
  protected MGAButton buttonCancel;
  protected dsDirectBillPayables dsDirectBillPayables1;
  public UltraGrid gridDirectBillResults;
  protected Label label1;
  protected MGASimpleComboBox comboDateType;
  private Panel panel3;
  protected MGAButton buttonExportToExcel;
  protected StatusStrip statusStrip1;
  protected ToolStripStatusLabel toolLoadStatus;
  protected dsDirectBillPayables_Bulk dsDirectBillPayables_Bulk1;
  protected Panel panel1;
  protected ToolStripProgressBar toolStripProgressBar1;
  protected UltraDropDown comboPayOptionTypes;
  protected LinkLabel linkSelectAll;
  protected LinkLabel linkUnselectAll;
  protected LinkLabel linkCreateCheckNone;
  protected LinkLabel linkCreateCheckAll;
  protected LinkLabel linkCreateACHALL;
  protected LinkLabel linkCreateACHNone;
  protected LinkLabel linkCreateEFTALL;
  protected LinkLabel linkCreateEFTNONE;
  protected PictureBox pictCheckCalculate;
  protected MGATextBox textCheckTotal;
  protected Label label15;
  protected Label label2;
  protected MGATextBox textEFTTotal;
  protected Label label4;
  protected MGATextBox textACHTotal;
  protected Label label3;
  protected PictureBox pictEFTCalculate;
  protected PictureBox pictACHCalculate;
  protected Panel panel2;

  public int TransactNum
  {
    get => this._transactNum;
    set => this._transactNum = value;
  }

  public FormDirectBillPayablesUtility()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer, true);
  }

  private void FormDirectBillPayablesUtility_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadOfficeLocations();
    this.LoadCompanies();
    this.LoadCompanyGroups();
    this.LoadDateTypes();
    this.LoadPayOptionTypes();
    this.dateTimeCheckDate.Value = (object) DateTime.Now;
    this.dateTimeCheckDate.Value = (object) DateTime.Now;
    this.dsDirectBillPayables_Bulk1.Clear();
  }

  public void LoadOfficeLocations()
  {
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboOfficeLocation).Rows).Count != 1)
      return;
    this.comboOfficeLocation.Value = ((UltraGridBase) this.comboOfficeLocation).Rows[0].Cells["id"].Value;
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
      return;
    this.dsDirectBillPayables1.Clear();
    ((UltraGridBase) this.comboBankAccounts).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetBankAccounts", new object[2]
    {
      (object) "@GLCompanyId",
      (object) (int) this.comboOfficeLocation.Value
    });
    ((UltraDropDownBase) this.comboBankAccounts).DisplayMember = "bankname";
    ((UltraDropDownBase) this.comboBankAccounts).ValueMember = "glacctid";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboBankAccounts).Rows).Count != 1)
      return;
    this.comboBankAccounts.Value = ((UltraGridBase) this.comboBankAccounts).Rows[0].Cells["glacctid"].Value;
  }

  private void LoadCompanies()
  {
    BackgroundWorker backgroundWorker = new BackgroundWorker();
    DataTable dataCompanies = new DataTable();
    backgroundWorker.DoWork += (DoWorkEventHandler) ((_param1, _param2) => dataCompanies = DefaultDatabase.ExecuteDataTable("GetCompanyList"));
    backgroundWorker.RunWorkerAsync();
    backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((_param1, _param2) =>
    {
      ((UltraGridBase) this.comboCompanies).DataSource = (object) dataCompanies;
      ((UltraDropDownBase) this.comboCompanies).DisplayMember = "CompanyName";
      ((UltraDropDownBase) this.comboCompanies).ValueMember = "CompanyGuid";
    });
  }

  protected virtual void LoadPayOptionTypes()
  {
    ((UltraGridBase) this.comboPayOptionTypes).DataSource = (object) DefaultDatabase.ExecuteDataSet(this.spocPayMethodsName);
    ((UltraDropDownBase) this.comboPayOptionTypes).DisplayMember = "methodname";
    ((UltraDropDownBase) this.comboPayOptionTypes).ValueMember = "paymethodid";
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Bands[0].ColHeadersVisible = false;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Bands[0].Columns[0].Hidden = true;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Bands[0].Columns[1].Width = 300;
    if (!((IEnumerable<UltraGridRow>) ((UltraGridBase) this.comboPayOptionTypes).Rows).Any<UltraGridRow>())
      return;
    ((UltraDropDownBase) this.comboPayOptionTypes).SelectedRow = ((UltraGridBase) this.comboPayOptionTypes).Rows[0];
  }

  private void LoadCompanyGroups()
  {
    BackgroundWorker backgroundWorker = new BackgroundWorker();
    DataTable dataCompanyGroups = new DataTable();
    backgroundWorker.DoWork += (DoWorkEventHandler) ((_param1, _param2) => dataCompanyGroups = DefaultDatabase.ExecuteDataTable("spFin_GetCompanyGroups"));
    backgroundWorker.RunWorkerAsync();
    backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((_param1, _param2) =>
    {
      ((UltraGridBase) this.comboCompanyGroups).DataSource = (object) dataCompanyGroups;
      ((UltraDropDownBase) this.comboCompanyGroups).DisplayMember = "CompanyGroupName";
      ((UltraDropDownBase) this.comboCompanyGroups).ValueMember = "CompanyGroupGuid";
    });
  }

  public virtual void LoadDirectBillInvoices(
    int glCompanyId,
    bool showProducers,
    bool showCompanies,
    bool showOthers,
    Guid companyGuid,
    DateTime cutOffDate,
    Guid companyGroupGuid,
    string dateType)
  {
    this.dsDirectBillPayables_Bulk1.Clear();
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      this.statusStrip1.Visible = true;
      this.toolLoadStatus.Text = "Accessing database...";
      this.statusStrip1.Refresh();
      using (DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, this.sprocName, 0, (CommandArgumentType) 0, new object[16 /*0x10*/]
      {
        (object) "@glcompanyid",
        (object) glCompanyId,
        (object) "@showproducers",
        (object) showProducers,
        (object) "@showcompanies",
        (object) showCompanies,
        (object) "@showothers",
        (object) showOthers,
        (object) "@companyGuid",
        (object) companyGuid,
        (object) "@asofdate",
        (object) cutOffDate,
        (object) "@companyGroupGuid",
        (object) companyGroupGuid,
        (object) "@dateType",
        (object) dateType
      }))
      {
        if (dataTable == null || dataTable.Rows.Count == 0)
        {
          int num = (int) MessageBox.Show("The system has not found any direct bill invoices.", "No Data Found!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.toolLoadStatus.Text = string.Empty;
          this.statusStrip1.Visible = false;
          this.Cursor = MgaCursors.Default;
          return;
        }
        this.toolLoadStatus.Text = "Creating display view header...";
        this.statusStrip1.Refresh();
        foreach (DataRow row in (InternalDataCollectionBase) dataTable.DefaultView.ToTable(true, "PayeeGuid", "PayeeName").Rows)
        {
          if (this.dsDirectBillPayables_Bulk1.Payees.Select($"PayeeGuid = '{row["payeeGuid"].ToString()}'").Length == 0)
          {
            Decimal TotalGrossPayable = Decimal.Parse(dataTable.Compute("SUM(GrossPayable)", $"PayeeGuid = '{row["PayeeGuid"].ToString()}'").ToString());
            Decimal TotalPropAmt = Decimal.Parse(dataTable.Compute("SUM(ProportionalAmountDue)", $"PayeeGuid = '{row["PayeeGuid"].ToString()}'").ToString());
            this.dsDirectBillPayables_Bulk1.Payees.AddPayeesRow(false, new Guid(row["payeeGuid"].ToString()), row["payeeName"].ToString(), TotalGrossPayable, TotalPropAmt, false);
          }
        }
        this.toolLoadStatus.Text = "Creating display view invoice detail...";
        this.statusStrip1.Refresh();
        foreach (DataRow row1 in (InternalDataCollectionBase) dataTable.Rows)
        {
          dsDirectBillPayables_Bulk.InvoicesRow row2 = this.dsDirectBillPayables_Bulk1.Invoices.NewInvoicesRow();
          row2.selectinvoice = false;
          row2.PayeeGuid = new Guid(row1["payeeGuid"].ToString());
          row2.InvoiceNum = (int) row1["InvoiceNum"];
          row2.OfficeInvoiceNum = (int) row1["OfficeInvoiceNum"];
          row2.GrossPayable = (Decimal) row1["GrossPayable"];
          row2.ProportionalAmount = (Decimal) row1["ProportionalAmountDue"];
          row2.InsuredName = row1["InsuredName"].ToString();
          row2.CompanyLineGuid = new Guid(row1["CompanyLineGuid"].ToString());
          row2.ChargeCode = (int) row1["ChargeCode"];
          row2.EntityAPAccount = (int) row1["EntityAPAccount"];
          row2.PolicyNumber = row1["policyNumber"].ToString();
          row2.EffectiveDate = (DateTime) row1["effectiveDate"];
          row2.ExpirationDate = (DateTime) row1["expirationDate"];
          this.dsDirectBillPayables_Bulk1.Invoices.AddInvoicesRow(row2);
        }
      }
      this.ToggleSelectAll(false);
      ((Control) this.buttonExportToExcel).Visible = true;
      this.PrintCreditBalances();
    }
    finally
    {
      this.toolLoadStatus.Text = string.Empty;
      this.statusStrip1.Visible = false;
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void ExportData()
  {
    Workbook wb = new Workbook();
    wb.Worksheets.Clear();
    Worksheet ws = wb.Worksheets.Add("Direct Bill Payables Export");
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((_param1, _param2) =>
      {
        int num = 0;
        foreach (UltraGridRow row1 in ((UltraGridBase) this.gridDirectBillResults).Rows)
        {
          if (num == 0)
          {
            ws.Cells[num, 0].PutValue("Entity Name");
            ws.Cells[num, 1].PutValue("Insured");
            ws.Cells[num, 2].PutValue("Policy Number");
            ws.Cells[num, 3].PutValue("Effective Date");
            ws.Cells[num, 4].PutValue("Expiration Date");
            ws.Cells[num, 5].PutValue("Invoice Number");
            ws.Cells[num, 6].PutValue("Gross Payable");
            ws.Cells[num, 7].PutValue("Proportional Amount Due");
            ++num;
            foreach (UltraGridRow row2 in row1.ChildBands[0].Rows)
            {
              ws.Cells[num, 0].Value = (object) row1.Cells["PayeeName"].Value.ToString();
              ws.Cells[num, 1].Value = (object) row2.Cells["InsuredName"].Value.ToString();
              ws.Cells[num, 2].Value = (object) row2.Cells["PolicyNumber"].Value.ToString();
              ws.Cells[num, 3].Value = (object) DateTime.Parse(row2.Cells["EffectiveDate"].Value.ToString()).ToShortDateString();
              ws.Cells[num, 4].Value = (object) DateTime.Parse(row2.Cells["ExpirationDate"].Value.ToString()).ToShortDateString();
              ws.Cells[num, 5].Value = (object) row2.Cells["OfficeInvoiceNum"].Value.ToString();
              ws.Cells[num, 6].Value = (object) row2.Cells["GrossPayable"].Value.ToString();
              ws.Cells[num, 7].Value = (object) row2.Cells["ProportionalAmount"].Value.ToString();
              ++num;
            }
          }
          else
          {
            foreach (UltraGridRow row3 in row1.ChildBands[0].Rows)
            {
              ws.Cells[num, 0].Value = (object) row1.Cells["PayeeName"].Value.ToString();
              ws.Cells[num, 1].Value = (object) row3.Cells["InsuredName"].Value.ToString();
              ws.Cells[num, 2].Value = (object) row3.Cells["PolicyNumber"].Value.ToString();
              ws.Cells[num, 3].Value = (object) DateTime.Parse(row3.Cells["EffectiveDate"].Value.ToString()).ToShortDateString();
              ws.Cells[num, 4].Value = (object) DateTime.Parse(row3.Cells["ExpirationDate"].Value.ToString()).ToShortDateString();
              ws.Cells[num, 5].Value = (object) row3.Cells["OfficeInvoiceNum"].Value.ToString();
              ws.Cells[num, 6].Value = (object) row3.Cells["GrossPayable"].Value.ToString();
              ws.Cells[num, 7].Value = (object) row3.Cells["ProportionalAmount"].Value.ToString();
              ++num;
            }
          }
          ++num;
        }
      });
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((_param1, _param2) =>
      {
        string empty = string.Empty;
        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        {
          saveFileDialog.Title = "Save Direct Bill Data To...";
          saveFileDialog.Filter = "Excel Worksheets|*.xls";
          if (saveFileDialog.ShowDialog() != DialogResult.OK)
            return;
          string fileName = saveFileDialog.FileName;
          wb.Save(fileName);
          Process.Start(new ProcessStartInfo(fileName)
          {
            UseShellExecute = true
          });
        }
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  protected virtual void buttonContinue_Click(object sender, EventArgs e)
  {
    if (!this.ValidateInputs())
      return;
    ((Control) this.buttonPostSelectedResults).Enabled = false;
    ((Control) this.buttonExportToExcel).Visible = false;
    this.LoadDirectBillInvoices((int) this.comboOfficeLocation.Value, this.checkShowProducers.Checked, this.checkShowCompanies.Checked, this.checkShowOthers.Checked, ((UltraDropDownBase) this.comboCompanies).SelectedRow == null ? Guid.Empty : new Guid(this.comboCompanies.Value.ToString()), this.dateTimeCutOff.DateTime.Date, ((UltraDropDownBase) this.comboCompanyGroups).SelectedRow == null ? Guid.Empty : new Guid(this.comboCompanyGroups.Value.ToString()), this.comboDateType.Value.ToString());
    ((Control) this.buttonPostSelectedResults).Enabled = ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count > 0;
  }

  private bool ValidateInputs()
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboBankAccounts).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a bank account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.dateTimeCutOff.Value == null)
    {
      int num = (int) MessageBox.Show("You must select a cut-off date to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraToggleEditorBase) this.checkLimitCompanies).Checked && ((UltraDropDownBase) this.comboCompanies).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a company to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!((UltraToggleEditorBase) this.checkLimitCompanyGroups).Checked || ((UltraDropDownBase) this.comboCompanyGroups).SelectedRow != null)
      return true;
    int num1 = (int) MessageBox.Show("You must specify a company group to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void comboOfficeLocation_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count <= 0)
      return;
    if (MessageBox.Show("Changing the office location will clear the rows in the grid, continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
      e.Cancel = true;
    else
      e.Cancel = false;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void linkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ToggleSelectAll(true);
    this.CalculateAllTotal();
  }

  private void linkUnSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ToggleSelectAll(false);
    this.CalculateAllTotal();
  }

  protected virtual void ToggleSelectAll(bool value)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count == 0)
      return;
    ((UltraControlBase) this.gridDirectBillResults).BeginUpdate();
    ((EventManagerBase) this.gridDirectBillResults.EventManager).AllEventsEnabled = false;
    this.Cursor = MgaCursors.WaitCursor;
    foreach (UltraGridRow ultraGridRow1 in ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.gridDirectBillResults).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (item => item.Activation == 0)).Select<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, UltraGridRow>) (item => item)))
    {
      if (((KeyedSubObjectsCollectionBase) ultraGridRow1.Cells).Exists("selectpayee"))
      {
        ultraGridRow1.Cells["SelectPayee"].Value = (object) value;
        ultraGridRow1.Update();
        foreach (UltraGridRow ultraGridRow2 in ((IEnumerable<UltraGridRow>) ultraGridRow1.ChildBands[0].Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (item => item.Activation == 0)).Select<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, UltraGridRow>) (item => item)))
        {
          if (((KeyedSubObjectsCollectionBase) ultraGridRow2.Cells).Exists("selectinvoice"))
          {
            ultraGridRow2.Cells["SelectInvoice"].Value = (object) value;
            ultraGridRow2.Update();
          }
        }
      }
    }
    ((EventManagerBase) this.gridDirectBillResults.EventManager).AllEventsEnabled = true;
    ((UltraControlBase) this.gridDirectBillResults).EndUpdate();
    this.Cursor = MgaCursors.Default;
  }

  protected virtual void PostDirectBillPayables()
  {
    Stopwatch stopwatch = new Stopwatch();
    stopwatch.Start();
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.RowFilterMode = (RowFilterMode) 1;
    UltraGridBand band1 = ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Bands[0];
    UltraGridBand band2 = ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Bands[1];
    band1.ColumnFilters["selectpayee"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    band2.ColumnFilters["selectinvoice"].FilterConditions.Add((FilterComparisionOperator) 0, (object) true);
    ((UltraGridBase) this.gridDirectBillResults).UpdateData();
    if (((UltraGridBase) this.gridDirectBillResults).Rows.GetFilteredInNonGroupByRows().Length == 0)
    {
      int num1 = (int) MessageBox.Show("You have not selected any rows to post.", "Nothing Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      foreach (UltraGridRow filteredInNonGroupByRow in ((UltraGridBase) this.gridDirectBillResults).Rows.GetFilteredInNonGroupByRows())
      {
        if (string.IsNullOrWhiteSpace(filteredInNonGroupByRow.Cells["PayOptions"].Value?.ToString()))
        {
          int num2 = (int) MessageBox.Show("Must select a payment option for all selected payee rows.", "Must Select Payment Option", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
      this._negativeCount = 0;
      try
      {
        for (int index = 0; index < ((UltraGridBase) this.gridDirectBillResults).Rows.GetFilteredInNonGroupByRows().Length; ++index)
        {
          this.statusStrip1.Visible = true;
          StringBuilder stringBuilder = new StringBuilder();
          stringBuilder.Append("Processing ");
          stringBuilder.Append(((UltraGridBase) this.gridDirectBillResults).Rows.GetFilteredInNonGroupByRows()[index].Cells["payeename"].Value.ToString());
          this.toolLoadStatus.Text = stringBuilder.ToString();
          this.statusStrip1.Refresh();
          this.panel2.Refresh();
          this.PostRow(((UltraGridBase) this.gridDirectBillResults).Rows.GetFilteredInNonGroupByRows()[index], stringBuilder.ToString());
        }
      }
      finally
      {
        this.toolStripProgressBar1.Visible = false;
        this.statusStrip1.Visible = false;
        stopwatch.Stop();
        Console.WriteLine((stopwatch.ElapsedMilliseconds * 1000L).ToString());
      }
      this.PostDirectBillPayablesComplete();
      if (this._negativeCount > 0)
      {
        int num3 = (int) MessageBox.Show($"The system has found {this._negativeCount} negative check(s) during processing. Negative checks cannot be processed.", "Processing Complete!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        int num4 = (int) MessageBox.Show("Processing completed successfully.", "Processing Complete!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
  }

  protected virtual void PostDirectBillPayablesComplete()
  {
  }

  protected virtual void PostRow(UltraGridRow row, string processingStatus)
  {
    this.TransactNum = 0;
    Decimal num1 = 0M;
    if (row.ChildBands[0].Rows.GetFilteredInNonGroupByRows().Length == 0)
      return;
    foreach (UltraGridRow filteredInNonGroupByRow in row.ChildBands[0].Rows.GetFilteredInNonGroupByRows())
    {
      string s = filteredInNonGroupByRow.Cells["ProportionalAmount"].Value.ToString();
      if (s.Length > 0)
        num1 += Decimal.Parse(s);
    }
    if (num1 <= 0M)
    {
      ++this._negativeCount;
    }
    else
    {
      int num2 = (int) this.comboBankAccounts.Value;
      int rowCount = row.ChildBands[0].Rows.GetFilteredInNonGroupByRows().Length;
      DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
      {
        this.TransactNum = DefaultDatabase.ExecuteScalar<int>("spFin_PostPayables_Journal", new object[6]
        {
          (object) "@POSTDATE",
          (object) this.dateTimeCheckDate.DateTime,
          (object) "@COMMENTS",
          (object) "",
          (object) "@USERGUID",
          (object) CurrentUser.Instance.UserGUID
        });
        this.toolStripProgressBar1.Maximum = row.ChildBands[0].Rows.GetFilteredInNonGroupByRows().Length;
        this.toolStripProgressBar1.Value = 0;
        this.toolStripProgressBar1.Visible = true;
        try
        {
          this.Cursor = MgaCursors.WaitCursor;
          if (rowCount > 100)
          {
            DefaultDatabase.ExecuteNonQuery(CommandType.Text, "TRUNCATE TABLE tblFin_DirectBillPayables_Bulk");
            DataTable table = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM tblFin_DirectBillPayables_Bulk");
            DataRow[] source = this.dsDirectBillPayables_Bulk1.Invoices.Select($"PayeeGuid = '{row.Cells["PayeeGuid"].Value}' AND SelectInvoice = 1");
            if (source.Length != 0)
              table = ((IEnumerable<DataRow>) source).CopyToDataTable<DataRow>();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(processingStatus);
            stringBuilder.Append(" (Processing as bulk...");
            stringBuilder.Append(rowCount.ToString());
            stringBuilder.Append(" rows)");
            this.toolLoadStatus.Text = stringBuilder.ToString();
            this.statusStrip1.Refresh();
            this.toolStripProgressBar1.Visible = false;
            using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(e.Transaction.Connection as SqlConnection, SqlBulkCopyOptions.Default, (SqlTransaction) e.Transaction))
            {
              sqlBulkCopy.DestinationTableName = "tblFin_DirectBillPayables_Bulk";
              sqlBulkCopy.WriteToServer(table);
            }
            DefaultDatabase.ExecuteNonQuery(CommandType.StoredProcedure, "spfin_PostJournalDetail_DirectBill_Bulk", 0, (CommandArgumentType) 0, new object[10]
            {
              (object) "@transactnum",
              (object) this.TransactNum,
              (object) "@bankgl",
              this.comboBankAccounts.Value,
              (object) "@sourcedoctype",
              (object) "I",
              (object) "@payeeguid",
              row.Cells["PayeeGuid"].Value,
              (object) "@entityGuid",
              row.Cells["PayeeGuid"].Value
            });
            this.toolLoadStatus.Text = stringBuilder.ToString();
            this.statusStrip1.Refresh();
          }
          else
          {
            for (int index = 0; index < row.ChildBands[0].Rows.GetFilteredInNonGroupByRows().Length; ++index)
            {
              UltraGridRow filteredInNonGroupByRow = row.ChildBands[0].Rows.GetFilteredInNonGroupByRows()[index];
              if ((bool) filteredInNonGroupByRow.Cells["selectinvoice"].Value)
              {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(processingStatus);
                stringBuilder.Append(" - Invoice #:");
                stringBuilder.Append(filteredInNonGroupByRow.Cells["officeinvoicenum"].Value.ToString());
                stringBuilder.Append(" (");
                stringBuilder.Append((index + 1).ToString());
                stringBuilder.Append(" of ");
                stringBuilder.Append(rowCount.ToString());
                stringBuilder.Append(")");
                this.toolStripProgressBar1.Visible = true;
                this.toolLoadStatus.Text = stringBuilder.ToString();
                this.statusStrip1.Refresh();
                DefaultDatabase.ExecuteNonQuery("spfin_PostJournalDetail_DirectBill", new object[20]
                {
                  (object) "@transactnum",
                  (object) this.TransactNum,
                  (object) "@glacctid",
                  filteredInNonGroupByRow.Cells["EntityAPAccount"].Value,
                  (object) "@bankgl",
                  this.comboBankAccounts.Value,
                  (object) "@sourcedoctype",
                  (object) "I",
                  (object) "@invoicenum",
                  filteredInNonGroupByRow.Cells["invoicenum"].Value,
                  (object) "@chargecode",
                  filteredInNonGroupByRow.Cells["chargecode"].Value,
                  (object) "@companylineguid",
                  filteredInNonGroupByRow.Cells["companylineguid"].Value,
                  (object) "@amount",
                  filteredInNonGroupByRow.Cells["proportionalamount"].Value,
                  (object) "@payeeguid",
                  filteredInNonGroupByRow.Cells["PayeeGuid"].Value,
                  (object) "@entityGuid",
                  filteredInNonGroupByRow.Cells["PayeeGuid"].Value
                });
                ((AppearanceBase) filteredInNonGroupByRow.CellAppearance).BackColor = Color.LightGray;
                this.toolStripProgressBar1.Increment(1);
              }
            }
          }
          this.CreateCheckRegister(string.IsNullOrEmpty(row.Cells["PayOptions"].Value.ToString()) ? "" : row.Cells["PayOptions"].Value.ToString(), this.TransactNum, (int) this.comboBankAccounts.Value, (Guid) row.Cells["PayeeGuid"].Value, this.dateTimeCheckDate.DateTime);
          DefaultDatabase.ExecuteNonQuery("spFin_ExecutePropIncome", new object[6]
          {
            (object) "@transactnum",
            (object) this.TransactNum,
            (object) "@rollupto",
            (object) "A/P",
            (object) "@glcompanyid",
            this.comboOfficeLocation.Value
          });
          DefaultDatabase.ExecuteNonQuery("spFin_PostCommissionableFees", new object[8]
          {
            (object) "@transactnum",
            (object) this.TransactNum,
            (object) "@transtype",
            (object) "AP",
            (object) "@glcompanyid",
            this.comboOfficeLocation.Value,
            (object) "@postDate",
            (object) this.dateTimeCheckDate.DateTime
          });
          if (DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "Select dbo.CheckDistributionBalance(@trxnum)", new object[2]
          {
            (object) "@trxnum",
            (object) this.TransactNum
          }) != 1)
            throw new TransactionOutOfBalanceException("An error has occurred while trying to post this payables transaction. The posting distribution would not balance. To ensure data integrity this transaction has been rolled back.");
          if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("IsUpdateWorkingTriggerDisabled"))
            DefaultDatabase.ExecuteNonQuery("dbo.spFin_UpdateWorking_Transaction", new object[2]
            {
              (object) "@TransactNum",
              (object) this.TransactNum
            });
          e.Transaction.Commit();
          ((AppearanceBase) row.CellAppearance).BackColor = Color.LightGray;
        }
        catch (Exception ex)
        {
          this.LoadDirectBillInvoices((int) this.comboOfficeLocation.Value, this.checkShowProducers.Checked, this.checkShowCompanies.Checked, this.checkShowOthers.Checked, ((UltraDropDownBase) this.comboCompanies).SelectedRow == null ? Guid.Empty : new Guid(this.comboCompanies.Value.ToString()), this.dateTimeCutOff.DateTime.Date, ((UltraDropDownBase) this.comboCompanyGroups).SelectedRow == null ? Guid.Empty : new Guid(this.comboCompanyGroups.Value.ToString()), this.comboDateType.Value.ToString());
        }
        finally
        {
          this.Cursor = MgaCursors.Default;
        }
      }));
    }
  }

  protected virtual void CreateCheckRegister(
    string PayOption,
    int TransactNum,
    int BankAccountId,
    Guid PayeeGuid,
    DateTime CheckDate)
  {
    if (!string.IsNullOrEmpty(PayOption))
      DefaultDatabase.ExecuteNonQuery("dbo.spFin_InsertCheckRegister", new object[10]
      {
        (object) "@TransactNum",
        (object) TransactNum,
        (object) "@PaymentMethodId",
        (object) PayOption,
        (object) "@CheckingAccountId",
        (object) BankAccountId,
        (object) "@PayeeGuid",
        (object) PayeeGuid,
        (object) "@CheckDate",
        (object) CheckDate
      });
    else
      DefaultDatabase.ExecuteNonQuery("dbo.spFin_InsertCheckRegister", new object[10]
      {
        (object) "@TransactNum",
        (object) TransactNum,
        (object) "@PaymentMethodId",
        (object) "O",
        (object) "@CheckingAccountId",
        (object) BankAccountId,
        (object) "@PayeeGuid",
        (object) PayeeGuid,
        (object) "@CheckDate",
        (object) CheckDate
      });
  }

  private void buttonPostSelectedResults_Click(object sender, EventArgs e)
  {
    this.PostDirectBillPayables();
  }

  protected bool HasSelectedSiblings(UltraGridRow row, UltraGridRow currentRow)
  {
    foreach (UltraGridRow row1 in row.ChildBands[0].Rows)
    {
      if (row1 != currentRow && (bool) row1.Cells["SelectInvoice"].Value)
        return true;
    }
    return false;
  }

  protected virtual void gridDirectBillResults_Click(object sender, EventArgs e)
  {
    UltraGridCell cell = ((ControlUIElementBase) ((UltraGridBase) (sender as UltraGrid)).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridCell)) as UltraGridCell;
    if (cell == null)
      return;
    if (((KeyedSubObjectBase) cell.Column).Key == "selectpayee")
    {
      cell.Row.Update();
      try
      {
        this.Cursor = Cursors.WaitCursor;
        ((IEnumerable<DataRow>) this.dsDirectBillPayables_Bulk1.Invoices.Select($"PayeeGuid = '{cell.Row.Cells["PayeeGuid"].Value.ToString()}'")).ToList<DataRow>().ForEach((Action<DataRow>) (r => r["selectinvoice"] = (object) !bool.Parse(cell.Value.ToString())));
        this.SelectChildRows(cell);
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
    if (((KeyedSubObjectBase) cell.Column).Key == "selectinvoice")
    {
      cell.Row.Update();
      try
      {
        this.Cursor = Cursors.WaitCursor;
        this.SelectParentRow(cell);
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
    ((UltraGridBase) this.gridDirectBillResults).UpdateData();
    this.CalculateAllTotal();
  }

  protected virtual void SelectParentRow(UltraGridCell cell)
  {
    if (!(bool) cell.Value)
      cell.Row.ParentRow.Cells["selectpayee"].Value = (object) true;
    else
      cell.Row.ParentRow.Cells["selectpayee"].Value = (object) this.HasSelectedSiblings(cell.Row.ParentRow, cell.Row);
  }

  protected virtual void SelectChildRows(UltraGridCell cell)
  {
    foreach (UltraGridRow row in cell.Row.ChildBands[0].Rows)
    {
      row.Cells["selectinvoice"].Value = (object) !bool.Parse(cell.Value.ToString());
      row.Update();
    }
  }

  private void LoadDateTypes()
  {
    DataTable dataTable = new DataTable();
    dataTable.Columns.AddRange(new DataColumn[2]
    {
      new DataColumn("dateTypeId", typeof (string)),
      new DataColumn("dateType", typeof (string))
    });
    dataTable.Rows.Add((object) "NA", (object) "** No Date Limiter **");
    dataTable.Rows.Add((object) "CD", (object) "Company Due Date");
    dataTable.Rows.Add((object) "DD", (object) "Due Date");
    dataTable.Rows.Add((object) "EF", (object) "Effective Date");
    dataTable.Rows.Add((object) "IN", (object) "Invoice Date");
    dataTable.Rows.Add((object) "PD", (object) "Post Date");
    dataTable.Rows.Add((object) "CR", (object) "Cash Receipt Date");
    ((UltraGridBase) this.comboDateType).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboDateType).ValueMember = "dateTypeId";
    ((UltraDropDownBase) this.comboDateType).DisplayMember = "dateType";
    this.comboDateType.Value = (object) "NA";
  }

  private void GetAPGLAcctId()
  {
    try
    {
      this._apGLacctId = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT GLAcctId FROM tblFin_GLAccounts WHERE GLCompanyId = @GLCompanyId AND ShortName = @ap", new object[4]
      {
        (object) "@GLCompanyId",
        this.comboOfficeLocation.Value,
        (object) "@ap",
        (object) "AP"
      });
    }
    catch (Exception ex)
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("The system could not determine the accounts payable GL Account. ");
      stringBuilder.Append(ex.Message);
      int num = (int) MessageBox.Show(stringBuilder.ToString(), "Cannot Find Accounts Payable GL Account!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void linkCreateCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ToggleCreateCheck(true);
  }

  private void linkCreateCheckNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ToggleCreateCheck(false);
  }

  private void ToggleCreateCheck(bool value)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count == 0)
      return;
    for (int index = 0; index < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count; ++index)
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        if (value)
          ((UltraGridBase) this.gridDirectBillResults).Rows[index].Cells["PayOptions"].Value = (object) "C";
        else
          ((UltraGridBase) this.gridDirectBillResults).Rows[index].Cells["PayOptions"].Value = (object) "";
        ((UltraGridBase) this.gridDirectBillResults).Rows[index].Update();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void ToggleCreateACH(bool value)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count == 0)
      return;
    for (int index = 0; index < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count; ++index)
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        if (value)
          ((UltraGridBase) this.gridDirectBillResults).Rows[index].Cells["PayOptions"].Value = (object) "H";
        else
          ((UltraGridBase) this.gridDirectBillResults).Rows[index].Cells["PayOptions"].Value = (object) "";
        ((UltraGridBase) this.gridDirectBillResults).Rows[index].Update();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void ToggleCreateEFT(bool value)
  {
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count == 0)
      return;
    for (int index = 0; index < ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridDirectBillResults).Rows).Count; ++index)
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        if (value)
          ((UltraGridBase) this.gridDirectBillResults).Rows[index].Cells["PayOptions"].Value = (object) "E";
        else
          ((UltraGridBase) this.gridDirectBillResults).Rows[index].Cells["PayOptions"].Value = (object) "";
        ((UltraGridBase) this.gridDirectBillResults).Rows[index].Update();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  private void DrawProgress(ToolStripProgressBar pb)
  {
    StringBuilder stringBuilder = new StringBuilder();
    stringBuilder.Append(pb.Value.ToString());
    stringBuilder.Append(" of ");
    stringBuilder.Append(pb.Maximum.ToString());
    using (Graphics graphics = pb.ProgressBar.CreateGraphics())
    {
      float x = (float) (pb.Width / 2) - graphics.MeasureString(stringBuilder.ToString(), SystemFonts.DefaultFont).Width / 2f;
      float y = (float) (pb.Height / 2) - graphics.MeasureString(stringBuilder.ToString(), SystemFonts.DefaultFont).Height / 2f;
      graphics.SmoothingMode = SmoothingMode.AntiAlias;
      graphics.DrawString(stringBuilder.ToString(), SystemFonts.DefaultFont, (Brush) new SolidBrush(Color.Black), new PointF(x, y));
    }
  }

  private void buttonExportToExcel_Click(object sender, EventArgs e) => this.ExportData();

  private void gridDirectBillResults_ClickCellButton(object sender, CellEventArgs e)
  {
    using (formPolicyInquiry formPolicyInquiry = new formPolicyInquiry(Utility.GetInvoiceControlNumber((int) e.Cell.Row.Cells["invoiceNum"].Value), (int) this.comboOfficeLocation.Value))
    {
      int num = (int) formPolicyInquiry.ShowDialog();
    }
  }

  private void pictCalculate_Click(object sender, EventArgs e) => this.CalculateAllTotal();

  protected virtual void CalculateAllTotal()
  {
    ((Control) this.textCheckTotal).Text = "Calculating...";
    ((Control) this.textEFTTotal).Text = "Calculating...";
    ((Control) this.textACHTotal).Text = "Calculating...";
    Decimal checksTotal = 0M;
    Decimal EFTsTotal = 0M;
    Decimal ACHsTotal = 0M;
    ((UltraGridBase) this.gridDirectBillResults).UpdateData();
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((sender, e) =>
      {
        foreach (UltraGridRow row1 in ((UltraGridBase) this.gridDirectBillResults).Rows)
        {
          if (((KeyedSubObjectsCollectionBase) row1.Cells).Exists("PayOptions") && !Utility.IsNull(row1.Cells["PayOptions"].Value) && ((KeyedSubObjectBase) ((GridItemBase) row1).Band).Key.Equals("Payees") && (bool) row1.Cells["SelectPayee"].Value)
          {
            if (row1.Cells["PayOptions"].Value.ToString() == "C")
            {
              foreach (UltraGridRow row2 in row1.ChildBands[0].Rows)
              {
                if (bool.Parse(row2.Cells["SelectInvoice"].Text))
                  checksTotal += (Decimal) row2.Cells["ProportionalAmount"].Value;
              }
            }
            else if (row1.Cells["PayOptions"].Value.ToString() == "H")
            {
              foreach (UltraGridRow row3 in row1.ChildBands[0].Rows)
              {
                if (bool.Parse(row3.Cells["SelectInvoice"].Text))
                  ACHsTotal += (Decimal) row3.Cells["ProportionalAmount"].Value;
              }
            }
            else if (row1.Cells["PayOptions"].Value.ToString() == "E")
            {
              foreach (UltraGridRow row4 in row1.ChildBands[0].Rows)
              {
                if (bool.Parse(row4.Cells["SelectInvoice"].Text))
                  EFTsTotal += (Decimal) row4.Cells["ProportionalAmount"].Value;
              }
            }
          }
        }
      });
      backgroundWorker.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((sender, e) =>
      {
        ((Control) this.textCheckTotal).Text = checksTotal.ToString("c");
        ((Control) this.textACHTotal).Text = ACHsTotal.ToString("c");
        ((Control) this.textEFTTotal).Text = EFTsTotal.ToString("c");
      });
      backgroundWorker.RunWorkerAsync();
    }
  }

  private void gridDirectBillResults_AfterCellUpdate(object sender, CellEventArgs e)
  {
    this.CalculateAllTotal();
  }

  private void checkLimitCompanies_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.checkLimitCompanies).Checked)
      return;
    this.comboCompanies.Value = (object) Guid.Empty;
  }

  private void checkLimitCompanyGroups_CheckedChanged(object sender, EventArgs e)
  {
    if (((UltraToggleEditorBase) this.checkLimitCompanyGroups).Checked)
      return;
    this.comboCompanyGroups.Value = (object) Guid.Empty;
  }

  protected virtual void PrintCreditBalances() => this.PrintCreditBalances("TotalPropAmt");

  protected void PrintCreditBalances(string columnName)
  {
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridDirectBillResults).Rows.GetFilteredInNonGroupByRows();
    IEnumerable<UltraGridRow> matchedRows = ((IEnumerable<UltraGridRow>) inNonGroupByRows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (item => Convert.ToDecimal(item.Cells[columnName].Value) < 0M)).Select<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, UltraGridRow>) (item => item));
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
    if (!matchedRows.Any<UltraGridRow>() || MessageBox.Show("Would you like to print statements for the credit balances?", "Print Statements?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
      return;
    this.statusStrip1.Visible = true;
    this.statusStrip1.Refresh();
    this.toolStripProgressBar1.Value = 0;
    this.toolStripProgressBar1.Maximum = inNonGroupByRows.Length + 1;
    using (BackgroundWorker bgw = new BackgroundWorker())
    {
      bgw.WorkerReportsProgress = true;
      bgw.ProgressChanged += new ProgressChangedEventHandler(this.Bgw_ProgressChanged);
      bgw.WorkerSupportsCancellation = true;
      bgw.DoWork += (DoWorkEventHandler) ((_param1, _param2) =>
      {
        if (this._formClosing)
        {
          bgw.CancelAsync();
        }
        else
        {
          ((UltraControlBase) this.gridDirectBillResults).BeginUpdate();
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, "TRUNCATE TABLE dbo.tblfin_DirectBillPayablesCredits_Bulk");
          DataTable dataTable = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM dbo.tblfin_DirectBillPayablesCredits_Bulk");
          List<Guid> list = matchedRows.AsEnumerable<UltraGridRow>().Select<UltraGridRow, Guid>((System.Func<UltraGridRow, Guid>) (item => (Guid) item.Cells["PayeeGuid"].Value)).ToList<Guid>();
          if (list.Count > 0)
          {
            foreach (Guid guid in list)
              dataTable.Rows.Add((object) guid);
          }
          if (dataTable.Rows.Count > 0)
            DefaultDatabase.ExecuteBulkInsert(dataTable, (SqlRowsCopiedEventHandler) null, SqlBulkCopyOptions.Default, "dbo.tblfin_DirectBillPayablesCredits_Bulk");
          foreach (UltraGridRow ultraGridRow in matchedRows)
          {
            ((UltraControlBase) this.gridDirectBillResults).BeginUpdate();
            ultraGridRow.Activation = (Activation) 2;
            ((UltraControlBase) this.gridDirectBillResults).EndUpdate();
            if (this._formClosing)
            {
              bgw.CancelAsync();
              break;
            }
            foreach (UltraGridRow row in ultraGridRow.ChildBands[0].Rows)
            {
              ((UltraControlBase) this.gridDirectBillResults).BeginUpdate();
              row.Activation = (Activation) 2;
              ((UltraControlBase) this.gridDirectBillResults).EndUpdate();
            }
            if (this._formClosing)
            {
              bgw.CancelAsync();
              break;
            }
          }
        }
      });
      bgw.RunWorkerCompleted += (RunWorkerCompletedEventHandler) ((_param1, _param2) =>
      {
        if (this._formClosing)
          return;
        this.PrintCredits((int) this.comboOfficeLocation.Value, this.dateTimeCutOff.DateTime);
        bgw.ProgressChanged -= new ProgressChangedEventHandler(this.Bgw_ProgressChanged);
        this.statusStrip1.Visible = false;
      });
      bgw.RunWorkerAsync();
    }
  }

  protected virtual void PrintCredits(int glCompany, DateTime cutOff)
  {
    SectionReport report = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptReturnPremiumCommissionAutomation), new object[3]
    {
      (object) glCompany,
      null,
      (object) cutOff
    });
    report.Run();
    new frmPrint(report).Show();
  }

  private void Bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
  {
    if (this._formClosing)
      return;
    this.toolStripProgressBar1.Increment(1);
    this.toolLoadStatus.Text = $"Processing Credit Statements for {this._nextPayeeName} ";
    this.statusStrip1.Refresh();
  }

  private void linkCreateACHALL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ToggleCreateACH(true);
  }

  private void linkCreateACHNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ToggleCreateACH(false);
  }

  private void pictACHCalculate_Click(object sender, EventArgs e) => this.CalculateAllTotal();

  private void pictEFTCalculate_Click(object sender, EventArgs e) => this.CalculateAllTotal();

  private void pictCheckCalculate_Click(object sender, EventArgs e) => this.CalculateAllTotal();

  private void linkCreateEFTNONE_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ToggleCreateEFT(false);
  }

  private void linkCreateEFTALL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ToggleCreateEFT(true);
  }

  private void gridDirectBillResults_CellChange(object sender, CellEventArgs e)
  {
    if (!(((KeyedSubObjectBase) e.Cell.Column).Key == "SelectPayee") && !(((KeyedSubObjectBase) e.Cell.Column).Key == "SelectInvoice"))
      return;
    this.CalculateAllTotal();
  }

  private void gridDirectBillResults_MouseUp(object sender, MouseEventArgs e)
  {
    this.CalculateAllTotal();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Payees", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("selectpayee");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PayeeName", -1, (object) null, 0, (SortIndicator) 1, false);
    Appearance appearance27 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("TotalGrossPayable");
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("TotalPropAmt");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CreateCheck");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Payees_Invoices");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PayOptions", 0, (object) "comboPayOptionTypes");
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Payees_Invoices", 0);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("selectinvoice");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("PayeeGuid");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormDirectBillPayablesUtility));
    Appearance appearance36 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("GrossPayable");
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ProportionalAmount");
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("InsuredName", -1, (object) null, 0, (SortIndicator) 2, false);
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("EntityAPAccount");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("PolicyNumber");
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("EffectiveDate");
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ExpirationDate");
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "ProportionalAmount", 5, true, "Payees_Invoices", 1, (SummaryPosition) 3, "ProportionalAmount", 5, true);
    Appearance appearance49 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "GrossPayable", 4, true, "Payees_Invoices", 1, (SummaryPosition) 3, "GrossPayable", 4, true);
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("Layout1");
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    this.panel1 = new Panel();
    this.pictEFTCalculate = new PictureBox();
    this.pictACHCalculate = new PictureBox();
    this.textEFTTotal = new MGATextBox();
    this.label4 = new Label();
    this.textACHTotal = new MGATextBox();
    this.label3 = new Label();
    this.label2 = new Label();
    this.pictCheckCalculate = new PictureBox();
    this.textCheckTotal = new MGATextBox();
    this.label15 = new Label();
    this.buttonExportToExcel = new MGAButton();
    this.label1 = new Label();
    this.comboDateType = new MGASimpleComboBox();
    this.buttonContinue = new MGAButton();
    this.buttonPostSelectedResults = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.checkLimitCompanyGroups = new MGACheckBox();
    this.comboCompanyGroups = new MGASimpleComboBox();
    this.checkLimitCompanies = new MGACheckBox();
    this.comboCompanies = new MGASimpleComboBox();
    this.dateTimeCheckDate = new MGADateTimePicker();
    this.label13 = new Label();
    this.comboBankAccounts = new MGASimpleComboBox();
    this.label12 = new Label();
    this.checkShowOthers = new CheckBox();
    this.checkShowCompanies = new CheckBox();
    this.checkShowProducers = new CheckBox();
    this.dateTimeCutOff = new MGADateTimePicker();
    this.label11 = new Label();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.labelOfficeLocation = new Label();
    this.panel2 = new Panel();
    this.linkCreateEFTALL = new LinkLabel();
    this.linkCreateEFTNONE = new LinkLabel();
    this.linkCreateACHALL = new LinkLabel();
    this.linkCreateACHNone = new LinkLabel();
    this.linkCreateCheckNone = new LinkLabel();
    this.linkCreateCheckAll = new LinkLabel();
    this.linkUnselectAll = new LinkLabel();
    this.linkSelectAll = new LinkLabel();
    this.statusStrip1 = new StatusStrip();
    this.toolLoadStatus = new ToolStripStatusLabel();
    this.toolStripProgressBar1 = new ToolStripProgressBar();
    this.panel3 = new Panel();
    this.comboPayOptionTypes = new UltraDropDown();
    this.gridDirectBillResults = new UltraGrid();
    this.dsDirectBillPayables_Bulk1 = new dsDirectBillPayables_Bulk();
    this.dsDirectBillPayables1 = new dsDirectBillPayables();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.pictEFTCalculate).BeginInit();
    ((ISupportInitialize) this.pictACHCalculate).BeginInit();
    ((ISupportInitialize) this.textEFTTotal).BeginInit();
    ((ISupportInitialize) this.textACHTotal).BeginInit();
    ((ISupportInitialize) this.pictCheckCalculate).BeginInit();
    ((ISupportInitialize) this.textCheckTotal).BeginInit();
    ((ISupportInitialize) this.buttonExportToExcel).BeginInit();
    ((ISupportInitialize) this.comboDateType).BeginInit();
    ((ISupportInitialize) this.buttonContinue).BeginInit();
    ((ISupportInitialize) this.buttonPostSelectedResults).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.checkLimitCompanyGroups).BeginInit();
    ((ISupportInitialize) this.comboCompanyGroups).BeginInit();
    ((ISupportInitialize) this.checkLimitCompanies).BeginInit();
    ((ISupportInitialize) this.comboCompanies).BeginInit();
    ((ISupportInitialize) this.dateTimeCheckDate).BeginInit();
    ((ISupportInitialize) this.comboBankAccounts).BeginInit();
    ((ISupportInitialize) this.dateTimeCutOff).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.panel2.SuspendLayout();
    this.statusStrip1.SuspendLayout();
    this.panel3.SuspendLayout();
    ((ISupportInitialize) this.comboPayOptionTypes).BeginInit();
    ((ISupportInitialize) this.gridDirectBillResults).BeginInit();
    this.dsDirectBillPayables_Bulk1.BeginInit();
    this.dsDirectBillPayables1.BeginInit();
    this.SuspendLayout();
    this.panel1.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    this.panel1.Controls.Add((Control) this.pictEFTCalculate);
    this.panel1.Controls.Add((Control) this.pictACHCalculate);
    this.panel1.Controls.Add((Control) this.textEFTTotal);
    this.panel1.Controls.Add((Control) this.label4);
    this.panel1.Controls.Add((Control) this.textACHTotal);
    this.panel1.Controls.Add((Control) this.label3);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.pictCheckCalculate);
    this.panel1.Controls.Add((Control) this.textCheckTotal);
    this.panel1.Controls.Add((Control) this.label15);
    this.panel1.Controls.Add((Control) this.buttonExportToExcel);
    this.panel1.Controls.Add((Control) this.label1);
    this.panel1.Controls.Add((Control) this.comboDateType);
    this.panel1.Controls.Add((Control) this.buttonContinue);
    this.panel1.Controls.Add((Control) this.buttonPostSelectedResults);
    this.panel1.Controls.Add((Control) this.buttonCancel);
    this.panel1.Controls.Add((Control) this.checkLimitCompanyGroups);
    this.panel1.Controls.Add((Control) this.comboCompanyGroups);
    this.panel1.Controls.Add((Control) this.checkLimitCompanies);
    this.panel1.Controls.Add((Control) this.comboCompanies);
    this.panel1.Controls.Add((Control) this.dateTimeCheckDate);
    this.panel1.Controls.Add((Control) this.label13);
    this.panel1.Controls.Add((Control) this.comboBankAccounts);
    this.panel1.Controls.Add((Control) this.label12);
    this.panel1.Controls.Add((Control) this.checkShowOthers);
    this.panel1.Controls.Add((Control) this.checkShowCompanies);
    this.panel1.Controls.Add((Control) this.checkShowProducers);
    this.panel1.Controls.Add((Control) this.dateTimeCutOff);
    this.panel1.Controls.Add((Control) this.label11);
    this.panel1.Controls.Add((Control) this.comboOfficeLocation);
    this.panel1.Controls.Add((Control) this.labelOfficeLocation);
    this.panel1.Dock = DockStyle.Left;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(281, 675);
    this.panel1.TabIndex = 0;
    this.pictEFTCalculate.BackColor = Color.White;
    this.pictEFTCalculate.BorderStyle = BorderStyle.FixedSingle;
    this.pictEFTCalculate.Image = (Image) Resources.eye;
    this.pictEFTCalculate.Location = new Point(253, 495);
    this.pictEFTCalculate.Name = "pictEFTCalculate";
    this.pictEFTCalculate.Size = new Size(19, 19);
    this.pictEFTCalculate.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictEFTCalculate.TabIndex = 30;
    this.pictEFTCalculate.TabStop = false;
    this.pictEFTCalculate.WaitOnLoad = true;
    this.pictEFTCalculate.Click += new EventHandler(this.pictEFTCalculate_Click);
    this.pictACHCalculate.BackColor = Color.White;
    this.pictACHCalculate.BorderStyle = BorderStyle.FixedSingle;
    this.pictACHCalculate.Image = (Image) Resources.eye;
    this.pictACHCalculate.Location = new Point(253, 457);
    this.pictACHCalculate.Name = "pictACHCalculate";
    this.pictACHCalculate.Size = new Size(19, 19);
    this.pictACHCalculate.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictACHCalculate.TabIndex = 29;
    this.pictACHCalculate.TabStop = false;
    this.pictACHCalculate.WaitOnLoad = true;
    this.pictACHCalculate.Click += new EventHandler(this.pictACHCalculate_Click);
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEFTTotal).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textEFTTotal).BackColor = Color.White;
    ((Control) this.textEFTTotal).Location = new Point(11, 495);
    this.textEFTTotal.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEFTTotal).Name = "textEFTTotal";
    ((EditorButtonControlBase) this.textEFTTotal).ReadOnly = true;
    ((Control) this.textEFTTotal).Size = new Size(241, 20);
    ((Control) this.textEFTTotal).TabIndex = 28;
    ((UltraControlBase) this.textEFTTotal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEFTTotal).UseOsThemes = (DefaultableBoolean) 2;
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label4.Location = new Point(9, 480);
    this.label4.Name = "label4";
    this.label4.Size = new Size(58, 14);
    this.label4.TabIndex = 27;
    this.label4.Text = "EFT Total:";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textACHTotal).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textACHTotal).BackColor = Color.White;
    ((Control) this.textACHTotal).Location = new Point(11, 457);
    this.textACHTotal.MGAStyle = MGAStyles.Blue;
    ((Control) this.textACHTotal).Name = "textACHTotal";
    ((EditorButtonControlBase) this.textACHTotal).ReadOnly = true;
    ((Control) this.textACHTotal).Size = new Size(241, 20);
    ((Control) this.textACHTotal).TabIndex = 26;
    ((UltraControlBase) this.textACHTotal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textACHTotal).UseOsThemes = (DefaultableBoolean) 2;
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label3.Location = new Point(9, 442);
    this.label3.Name = "label3";
    this.label3.Size = new Size(62, 14);
    this.label3.TabIndex = 25;
    this.label3.Text = "ACH Total:";
    this.label2.BackColor = Color.SlateGray;
    this.label2.Location = new Point(15, 395);
    this.label2.Name = "label2";
    this.label2.Size = new Size(257, 1);
    this.label2.TabIndex = 24;
    this.pictCheckCalculate.BackColor = Color.White;
    this.pictCheckCalculate.BorderStyle = BorderStyle.FixedSingle;
    this.pictCheckCalculate.Image = (Image) Resources.eye;
    this.pictCheckCalculate.Location = new Point(253, 419);
    this.pictCheckCalculate.Name = "pictCheckCalculate";
    this.pictCheckCalculate.Size = new Size(19, 19);
    this.pictCheckCalculate.SizeMode = PictureBoxSizeMode.CenterImage;
    this.pictCheckCalculate.TabIndex = 23;
    this.pictCheckCalculate.TabStop = false;
    this.pictCheckCalculate.WaitOnLoad = true;
    this.pictCheckCalculate.Click += new EventHandler(this.pictCheckCalculate_Click);
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCheckTotal).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textCheckTotal).BackColor = Color.White;
    ((Control) this.textCheckTotal).Location = new Point(11, 419);
    this.textCheckTotal.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCheckTotal).Name = "textCheckTotal";
    ((EditorButtonControlBase) this.textCheckTotal).ReadOnly = true;
    ((Control) this.textCheckTotal).Size = new Size(241, 20);
    ((Control) this.textCheckTotal).TabIndex = 22;
    ((UltraControlBase) this.textCheckTotal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textCheckTotal).UseOsThemes = (DefaultableBoolean) 2;
    this.label15.AutoSize = true;
    this.label15.BackColor = Color.Transparent;
    this.label15.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label15.Location = new Point(9, 404);
    this.label15.Name = "label15";
    this.label15.Size = new Size(81, 14);
    this.label15.TabIndex = 21;
    this.label15.Text = "Checks Total:";
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).Image = (object) Resources.Excel;
    ((ControlBase) this.buttonExportToExcel).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonExportToExcel).Location = new Point(151, 359);
    ((Control) this.buttonExportToExcel).Name = "buttonExportToExcel";
    ((Control) this.buttonExportToExcel).Size = new Size(121, 24);
    ((Control) this.buttonExportToExcel).TabIndex = 20;
    ((Control) this.buttonExportToExcel).Text = "Export To Excel";
    ((UltraControlBase) this.buttonExportToExcel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonExportToExcel).Visible = false;
    ((Control) this.buttonExportToExcel).Click += new EventHandler(this.buttonExportToExcel_Click);
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label1.Location = new Point(106, 134);
    this.label1.Name = "label1";
    this.label1.Size = new Size(60, 14);
    this.label1.TabIndex = 8;
    this.label1.Text = "Date Type";
    this.comboDateType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDateType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDateType).Location = new Point(109, 151);
    this.comboDateType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDateType).Name = "comboDateType";
    ((Control) this.comboDateType).Size = new Size(165, 21);
    ((Control) this.comboDateType).TabIndex = 9;
    ((UltraControlBase) this.comboDateType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboDateType).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance5).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance5).Image = (object) Resources.SearchTransaction;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Center";
    ((ControlBase) this.buttonContinue).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonContinue).Location = new Point(11, 329);
    ((Control) this.buttonContinue).Name = "buttonContinue";
    ((Control) this.buttonContinue).Size = new Size(135, 24);
    ((Control) this.buttonContinue).TabIndex = 17;
    ((Control) this.buttonContinue).Text = "Load Payables";
    ((UltraControlBase) this.buttonContinue).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonContinue).Click += new EventHandler(this.buttonContinue_Click);
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance6).Image = (object) Resources.disk;
    ((ControlBase) this.buttonPostSelectedResults).Appearance = (AppearanceBase) appearance6;
    ((Control) this.buttonPostSelectedResults).Enabled = false;
    ((Control) this.buttonPostSelectedResults).Location = new Point(11, 359);
    ((Control) this.buttonPostSelectedResults).Name = "buttonPostSelectedResults";
    ((Control) this.buttonPostSelectedResults).Size = new Size(134, 24);
    ((Control) this.buttonPostSelectedResults).TabIndex = 18;
    ((Control) this.buttonPostSelectedResults).Text = "Post Selected Results";
    ((UltraControlBase) this.buttonPostSelectedResults).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonPostSelectedResults).Click += new EventHandler(this.buttonPostSelectedResults_Click);
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance7).Image = (object) Resources.delete;
    ((AppearanceBase) appearance7).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Center";
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance7;
    ((Control) this.buttonCancel).Location = new Point(151, 329);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(121, 24);
    ((Control) this.buttonCancel).TabIndex = 19;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance8).BorderColor = Color.Gray;
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkLimitCompanyGroups).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.checkLimitCompanyGroups).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkLimitCompanyGroups).Location = new Point(12, 284);
    ((Control) this.checkLimitCompanyGroups).Name = "checkLimitCompanyGroups";
    ((Control) this.checkLimitCompanyGroups).Size = new Size(295, 16 /*0x10*/);
    ((Control) this.checkLimitCompanyGroups).TabIndex = 15;
    ((Control) this.checkLimitCompanyGroups).Text = "Limit to Business with Company Groups";
    ((UltraToggleEditorBase) this.checkLimitCompanyGroups).CheckedChanged += new EventHandler(this.checkLimitCompanyGroups_CheckedChanged);
    this.comboCompanyGroups.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCompanyGroups.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCompanyGroups).Location = new Point(11, 302);
    this.comboCompanyGroups.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCompanyGroups).Name = "comboCompanyGroups";
    ((Control) this.comboCompanyGroups).Size = new Size(262, 21);
    ((Control) this.comboCompanyGroups).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.comboCompanyGroups).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCompanyGroups).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BorderColor = Color.Gray;
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkLimitCompanies).Appearance = (AppearanceBase) appearance9;
    ((UltraToggleEditorBase) this.checkLimitCompanies).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkLimitCompanies).Location = new Point(12, 241);
    ((Control) this.checkLimitCompanies).Name = "checkLimitCompanies";
    ((Control) this.checkLimitCompanies).Size = new Size(264, 20);
    ((Control) this.checkLimitCompanies).TabIndex = 13;
    ((Control) this.checkLimitCompanies).Text = "Limit to Business with Company";
    ((UltraToggleEditorBase) this.checkLimitCompanies).CheckedChanged += new EventHandler(this.checkLimitCompanies_CheckedChanged);
    this.comboCompanies.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCompanies.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCompanies).Location = new Point(12, 261);
    this.comboCompanies.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCompanies).Name = "comboCompanies";
    ((Control) this.comboCompanies).Size = new Size(262, 21);
    ((Control) this.comboCompanies).TabIndex = 14;
    ((UltraControlBase) this.comboCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCompanies).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.LightYellow;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeCheckDate.Appearance = (AppearanceBase) appearance10;
    ((Control) this.dateTimeCheckDate).BackColor = Color.LightYellow;
    ((AppearanceBase) appearance11).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance11).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance11).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance11).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance11).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance11).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance11).ForegroundAlpha = (Alpha) 2;
    this.dateTimeCheckDate.ButtonAppearance = (AppearanceBase) appearance11;
    ((Control) this.dateTimeCheckDate).Location = new Point(12, 108);
    this.dateTimeCheckDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeCheckDate).Name = "dateTimeCheckDate";
    ((Control) this.dateTimeCheckDate).Size = new Size(91, 20);
    ((Control) this.dateTimeCheckDate).TabIndex = 5;
    ((UltraControlBase) this.dateTimeCheckDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeCheckDate).UseOsThemes = (DefaultableBoolean) 2;
    this.label13.AutoSize = true;
    this.label13.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label13.Location = new Point(12, 91);
    this.label13.Name = "label13";
    this.label13.Size = new Size(72, 14);
    this.label13.TabIndex = 4;
    this.label13.Text = "Check Date:";
    this.comboBankAccounts.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraDropDownBase) this.comboBankAccounts).DisplayMember = "BANKNAME";
    this.comboBankAccounts.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboBankAccounts).Location = new Point(12, 67);
    this.comboBankAccounts.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccounts).Name = "comboBankAccounts";
    ((Control) this.comboBankAccounts).Size = new Size(261, 21);
    ((Control) this.comboBankAccounts).TabIndex = 3;
    ((UltraControlBase) this.comboBankAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboBankAccounts).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboBankAccounts).ValueMember = "GLACCTID";
    this.label12.AutoSize = true;
    this.label12.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label12.Location = new Point(12, 50);
    this.label12.Name = "label12";
    this.label12.Size = new Size(82, 14);
    this.label12.TabIndex = 2;
    this.label12.Text = "Bank Account";
    this.checkShowOthers.FlatStyle = FlatStyle.Flat;
    this.checkShowOthers.Location = new Point(12, 220);
    this.checkShowOthers.Name = "checkShowOthers";
    this.checkShowOthers.Size = new Size(88, 15);
    this.checkShowOthers.TabIndex = 12;
    this.checkShowOthers.Text = "Show Others ";
    this.checkShowCompanies.FlatStyle = FlatStyle.Flat;
    this.checkShowCompanies.Location = new Point(12, 197);
    this.checkShowCompanies.Name = "checkShowCompanies";
    this.checkShowCompanies.Size = new Size(112 /*0x70*/, 17);
    this.checkShowCompanies.TabIndex = 11;
    this.checkShowCompanies.Text = "Show Companies";
    this.checkShowProducers.Checked = true;
    this.checkShowProducers.CheckState = CheckState.Checked;
    this.checkShowProducers.FlatStyle = FlatStyle.Flat;
    this.checkShowProducers.Location = new Point(12, 177);
    this.checkShowProducers.Name = "checkShowProducers";
    this.checkShowProducers.Size = new Size(104, 17);
    this.checkShowProducers.TabIndex = 10;
    this.checkShowProducers.Text = "Show Producers";
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeCutOff.Appearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance13).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance13).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance13).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance13).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance13).ForegroundAlpha = (Alpha) 2;
    this.dateTimeCutOff.ButtonAppearance = (AppearanceBase) appearance13;
    ((Control) this.dateTimeCutOff).Location = new Point(12, 151);
    this.dateTimeCutOff.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeCutOff).Name = "dateTimeCutOff";
    ((Control) this.dateTimeCutOff).Size = new Size(91, 20);
    ((Control) this.dateTimeCutOff).TabIndex = 7;
    ((UltraControlBase) this.dateTimeCutOff).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeCutOff).UseOsThemes = (DefaultableBoolean) 2;
    this.label11.AutoSize = true;
    this.label11.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label11.Location = new Point(15, 134);
    this.label11.Name = "label11";
    this.label11.Size = new Size(73, 14);
    this.label11.TabIndex = 6;
    this.label11.Text = "Cut-Off Date";
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboOfficeLocation).DataMember = "spFin_GetOfficeLocations";
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(12, 26);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(261, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 1;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.comboOfficeLocation.BeforeDropDown += new CancelEventHandler(this.comboOfficeLocation_BeforeDropDown);
    this.comboOfficeLocation.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    this.labelOfficeLocation.AutoSize = true;
    this.labelOfficeLocation.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelOfficeLocation.Location = new Point(12, 10);
    this.labelOfficeLocation.Name = "labelOfficeLocation";
    this.labelOfficeLocation.Size = new Size(89, 14);
    this.labelOfficeLocation.TabIndex = 0;
    this.labelOfficeLocation.Text = "Office Location";
    this.panel2.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    this.panel2.Controls.Add((Control) this.linkCreateEFTALL);
    this.panel2.Controls.Add((Control) this.linkCreateEFTNONE);
    this.panel2.Controls.Add((Control) this.linkCreateACHALL);
    this.panel2.Controls.Add((Control) this.linkCreateACHNone);
    this.panel2.Controls.Add((Control) this.linkCreateCheckNone);
    this.panel2.Controls.Add((Control) this.linkCreateCheckAll);
    this.panel2.Controls.Add((Control) this.linkUnselectAll);
    this.panel2.Controls.Add((Control) this.linkSelectAll);
    this.panel2.Dock = DockStyle.Bottom;
    this.panel2.Location = new Point(0, 654);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(883, 21);
    this.panel2.TabIndex = 2;
    this.linkCreateEFTALL.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.linkCreateEFTALL.AutoSize = true;
    this.linkCreateEFTALL.Location = new Point(141, 4);
    this.linkCreateEFTALL.Name = "linkCreateEFTALL";
    this.linkCreateEFTALL.Size = new Size(108, 13);
    this.linkCreateEFTALL.TabIndex = 6;
    this.linkCreateEFTALL.TabStop = true;
    this.linkCreateEFTALL.Text = "Offset as EFT - (ALL)";
    this.linkCreateEFTALL.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkCreateEFTALL_LinkClicked);
    this.linkCreateEFTNONE.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.linkCreateEFTNONE.AutoSize = true;
    this.linkCreateEFTNONE.Location = new Point(254, 4);
    this.linkCreateEFTNONE.Name = "linkCreateEFTNONE";
    this.linkCreateEFTNONE.Size = new Size(119, 13);
    this.linkCreateEFTNONE.TabIndex = 7;
    this.linkCreateEFTNONE.TabStop = true;
    this.linkCreateEFTNONE.Text = "Offset as EFT - (NONE)";
    this.linkCreateEFTNONE.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkCreateEFTNONE_LinkClicked);
    this.linkCreateACHALL.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.linkCreateACHALL.AutoSize = true;
    this.linkCreateACHALL.Location = new Point(384, 3);
    this.linkCreateACHALL.Name = "linkCreateACHALL";
    this.linkCreateACHALL.Size = new Size(111, 13);
    this.linkCreateACHALL.TabIndex = 2;
    this.linkCreateACHALL.TabStop = true;
    this.linkCreateACHALL.Text = "Offset as ACH - (ALL)";
    this.linkCreateACHALL.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkCreateACHALL_LinkClicked);
    this.linkCreateACHNone.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.linkCreateACHNone.AutoSize = true;
    this.linkCreateACHNone.Location = new Point(503, 3);
    this.linkCreateACHNone.Name = "linkCreateACHNone";
    this.linkCreateACHNone.Size = new Size(122, 13);
    this.linkCreateACHNone.TabIndex = 3;
    this.linkCreateACHNone.TabStop = true;
    this.linkCreateACHNone.Text = "Offset as ACH - (NONE)";
    this.linkCreateACHNone.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkCreateACHNone_LinkClicked);
    this.linkCreateCheckNone.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.linkCreateCheckNone.AutoSize = true;
    this.linkCreateCheckNone.Location = new Point(753, 3);
    this.linkCreateCheckNone.Name = "linkCreateCheckNone";
    this.linkCreateCheckNone.Size = new Size(118, 13);
    this.linkCreateCheckNone.TabIndex = 5;
    this.linkCreateCheckNone.TabStop = true;
    this.linkCreateCheckNone.Text = "Create Check - (NONE)";
    this.linkCreateCheckNone.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkCreateCheckNone_LinkClicked);
    this.linkCreateCheckAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.linkCreateCheckAll.AutoSize = true;
    this.linkCreateCheckAll.Location = new Point(640, 3);
    this.linkCreateCheckAll.Name = "linkCreateCheckAll";
    this.linkCreateCheckAll.Size = new Size(107, 13);
    this.linkCreateCheckAll.TabIndex = 4;
    this.linkCreateCheckAll.TabStop = true;
    this.linkCreateCheckAll.Text = "Create Check - (ALL)";
    this.linkCreateCheckAll.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkCreateCheckAll_LinkClicked);
    this.linkUnselectAll.AutoSize = true;
    this.linkUnselectAll.LinkArea = new LinkArea(0, 14);
    this.linkUnselectAll.Location = new Point(61, 3);
    this.linkUnselectAll.Name = "linkUnselectAll";
    this.linkUnselectAll.Size = new Size(67, 18);
    this.linkUnselectAll.TabIndex = 1;
    this.linkUnselectAll.TabStop = true;
    this.linkUnselectAll.Text = "Un-Select All";
    this.linkUnselectAll.UseCompatibleTextRendering = true;
    this.linkUnselectAll.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkUnSelectAll_LinkClicked);
    this.linkSelectAll.AutoSize = true;
    this.linkSelectAll.Location = new Point(6, 3);
    this.linkSelectAll.Name = "linkSelectAll";
    this.linkSelectAll.Size = new Size(50, 13);
    this.linkSelectAll.TabIndex = 0;
    this.linkSelectAll.TabStop = true;
    this.linkSelectAll.Text = "Select All";
    this.linkSelectAll.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkSelectAll_LinkClicked);
    this.statusStrip1.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    this.statusStrip1.Items.AddRange(new ToolStripItem[2]
    {
      (ToolStripItem) this.toolLoadStatus,
      (ToolStripItem) this.toolStripProgressBar1
    });
    this.statusStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
    this.statusStrip1.Location = new Point(1, 654);
    this.statusStrip1.Name = "statusStrip1";
    this.statusStrip1.Size = new Size(1164, 22);
    this.statusStrip1.SizingGrip = false;
    this.statusStrip1.TabIndex = 21;
    this.statusStrip1.Visible = false;
    this.toolLoadStatus.BorderStyle = Border3DStyle.SunkenOuter;
    this.toolLoadStatus.Name = "toolLoadStatus";
    this.toolLoadStatus.Size = new Size(0, 17);
    this.toolStripProgressBar1.Alignment = ToolStripItemAlignment.Right;
    this.toolStripProgressBar1.Name = "toolStripProgressBar1";
    this.toolStripProgressBar1.Size = new Size(200, 16 /*0x10*/);
    this.toolStripProgressBar1.Step = 1;
    this.toolStripProgressBar1.Visible = false;
    this.panel3.Controls.Add((Control) this.comboPayOptionTypes);
    this.panel3.Controls.Add((Control) this.gridDirectBillResults);
    this.panel3.Controls.Add((Control) this.panel2);
    this.panel3.Dock = DockStyle.Fill;
    this.panel3.Location = new Point(281, 0);
    this.panel3.Name = "panel3";
    this.panel3.Size = new Size(883, 675);
    this.panel3.TabIndex = 22;
    ((AppearanceBase) appearance14).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance14).BorderAlpha = (Alpha) 3;
    ((AppearanceBase) appearance14).BorderColor = Color.White;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Appearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance15).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance15).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance15).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance16;
    ((SpecialBoxBase) ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance17).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance17).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance17).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance17).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance18).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance18).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance19).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance20).BackColor = SystemColors.Window;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    ((AppearanceBase) appearance21).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance22).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance22).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance22).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance22).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance22).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance24).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance24).BorderColor = Color.Silver;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance25).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.comboPayOptionTypes).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.comboPayOptionTypes).Location = new Point(224 /*0xE0*/, 220);
    ((Control) this.comboPayOptionTypes).Name = "comboPayOptionTypes";
    ((Control) this.comboPayOptionTypes).Size = new Size(424, 80 /*0x50*/);
    ((Control) this.comboPayOptionTypes).TabIndex = 3;
    ((Control) this.comboPayOptionTypes).Text = "ultraDropDown1";
    ((Control) this.comboPayOptionTypes).Visible = false;
    ((UltraGridBase) this.gridDirectBillResults).DataSource = (object) this.dsDirectBillPayables_Bulk1;
    ((AppearanceBase) appearance26).BackColor = Color.White;
    ((AppearanceBase) appearance26).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance26).ForeColor = Color.Black;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Appearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.DefaultCellValue = (object) "False";
    ((HeaderBase) ultraGridColumn1.Header).Caption = "";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.Style = (ColumnStyle) 3;
    ultraGridColumn1.Width = 26;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 0;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Style = (ColumnStyle) 3;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance27;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Payee";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 398;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance28;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance29).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance29;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Gross Payable";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 175;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance30;
    ultraGridColumn5.Format = "c";
    ((AppearanceBase) appearance31).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance31;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Proportional Amt.";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 159;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 82;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 7;
    ((AppearanceBase) appearance32).BorderAlpha = (Alpha) 3;
    ((AppearanceBase) appearance32).BorderColor = Color.White;
    ((AppearanceBase) appearance32).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance33;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Payment Options";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).TextOrientation = new TextOrientationInfo(0, (TextFlowDirection) 0);
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 6;
    ultraGridColumn8.Style = (ColumnStyle) 6;
    ultraGridColumn8.Width = 104;
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
    ultraGridBand1.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand1.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand1.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand1.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand1.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand1.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ultraGridBand1.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand1.Override.RowSelectors = (DefaultableBoolean) 2;
    ultraGridBand1.SummaryFooterCaption = "Checks Total:";
    ((HeaderBase) ultraGridColumn9.Header).Caption = "";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 0;
    ultraGridColumn9.Width = 28;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 1;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 75;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 2;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 49;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance34).Cursor = Cursors.Hand;
    ((AppearanceBase) appearance34).FontData.UnderlineAsString = "True";
    ((AppearanceBase) appearance34).ForeColor = Color.Blue;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Left";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).ForeColor = Color.Blue;
    ((AppearanceBase) appearance35).Image = componentResourceManager.GetObject("appearance35.Image");
    ultraGridColumn12.CellButtonAppearance = (AppearanceBase) appearance35;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance36;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 3;
    ultraGridColumn12.Style = (ColumnStyle) 2;
    ultraGridColumn12.Width = 73;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Right";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance37;
    ultraGridColumn13.Format = "c";
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance38;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Gross Payable";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 8;
    ultraGridColumn13.Width = 99;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance39).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance39).TextHAlignAsString = "Right";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance39;
    ultraGridColumn14.Format = "c";
    ((AppearanceBase) appearance40).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance40;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Pay Amt.";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 9;
    ultraGridColumn14.Width = 130;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance41).TextHAlignAsString = "Left";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance41;
    ((AppearanceBase) appearance42).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance42;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Insured";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 5;
    ultraGridColumn15.Width = 182;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 10;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 93;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 11;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 67;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 12;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 87;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance43).TextHAlignAsString = "Left";
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance43;
    ((AppearanceBase) appearance44).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance44;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 4;
    ultraGridColumn19.Width = 168;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance45).TextHAlignAsString = "Left";
    ultraGridColumn20.CellAppearance = (AppearanceBase) appearance45;
    ((AppearanceBase) appearance46).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn20.Header).Appearance = (AppearanceBase) appearance46;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 6;
    ultraGridColumn20.Width = 79;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance47).TextHAlignAsString = "Left";
    ultraGridColumn21.CellAppearance = (AppearanceBase) appearance47;
    ((AppearanceBase) appearance48).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn21.Header).Appearance = (AppearanceBase) appearance48;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "Expiration";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 7;
    ultraGridColumn21.Width = 84;
    ultraGridBand2.Columns.AddRange(new object[13]
    {
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
      (object) ultraGridColumn21
    });
    ultraGridBand2.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand2.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand2.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand2.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand2.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand2.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand2.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand2.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand2.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand2.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand2.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand2.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance49).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance49;
    summarySettings1.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance50).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance50;
    summarySettings2.DisplayFormat = "{0:c}";
    ultraGridBand2.Summaries.AddRange(new SummarySettings[2]
    {
      summarySettings1,
      summarySettings2
    });
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance51).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance51;
    ((AppearanceBase) appearance52).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance52;
    ((AppearanceBase) appearance53).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance53;
    ((AppearanceBase) appearance54).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance54;
    ((AppearanceBase) appearance55).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance55;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance56).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridDirectBillResults).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance56;
    ((Control) this.gridDirectBillResults).Dock = DockStyle.Fill;
    ((Control) this.gridDirectBillResults).Font = new Font("Tahoma", 8.25f);
    ((AppearanceBase) appearance57).BackColor = Color.White;
    ((AppearanceBase) appearance57).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance57).ForeColor = Color.Black;
    ultraGridLayout.Appearance = (AppearanceBase) appearance57;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout).Key = "Layout1";
    ultraGridLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance58).BorderColor = Color.Silver;
    ultraGridLayout.Override.CellAppearance = (AppearanceBase) appearance58;
    ((AppearanceBase) appearance59).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout.Override.HeaderAppearance = (AppearanceBase) appearance59;
    ((AppearanceBase) appearance60).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance60;
    ((AppearanceBase) appearance61).BorderColor = Color.Silver;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance61;
    ((AppearanceBase) appearance62).BackColor = Color.LightSteelBlue;
    ultraGridLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance62;
    ultraGridLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance63).BackColor = Color.LightSteelBlue;
    ultraGridLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance63;
    ((UltraGridBase) this.gridDirectBillResults).Layouts.Add(ultraGridLayout);
    ((Control) this.gridDirectBillResults).Location = new Point(0, 0);
    ((Control) this.gridDirectBillResults).Name = "gridDirectBillResults";
    ((Control) this.gridDirectBillResults).Size = new Size(883, 654);
    ((Control) this.gridDirectBillResults).TabIndex = 1;
    this.gridDirectBillResults.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridDirectBillResults).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridDirectBillResults).UseOsThemes = (DefaultableBoolean) 2;
    this.gridDirectBillResults.AfterCellUpdate += new CellEventHandler(this.gridDirectBillResults_AfterCellUpdate);
    this.gridDirectBillResults.CellChange += new CellEventHandler(this.gridDirectBillResults_CellChange);
    this.gridDirectBillResults.ClickCellButton += new CellEventHandler(this.gridDirectBillResults_ClickCellButton);
    ((Control) this.gridDirectBillResults).Click += new EventHandler(this.gridDirectBillResults_Click);
    ((Control) this.gridDirectBillResults).MouseUp += new MouseEventHandler(this.gridDirectBillResults_MouseUp);
    this.dsDirectBillPayables_Bulk1.DataSetName = "dsDirectBillPayables_Bulk";
    this.dsDirectBillPayables_Bulk1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.dsDirectBillPayables1.DataSetName = "dsDirectBillPayables";
    this.dsDirectBillPayables1.Locale = new CultureInfo("en-US");
    this.dsDirectBillPayables1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1164, 675);
    this.Controls.Add((Control) this.panel3);
    this.Controls.Add((Control) this.panel1);
    this.Controls.Add((Control) this.statusStrip1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormDirectBillPayablesUtility);
    this.Text = "Direct Bill Payables Utility";
    this.Load += new EventHandler(this.FormDirectBillPayablesUtility_Load);
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    ((ISupportInitialize) this.pictEFTCalculate).EndInit();
    ((ISupportInitialize) this.pictACHCalculate).EndInit();
    ((ISupportInitialize) this.textEFTTotal).EndInit();
    ((ISupportInitialize) this.textACHTotal).EndInit();
    ((ISupportInitialize) this.pictCheckCalculate).EndInit();
    ((ISupportInitialize) this.textCheckTotal).EndInit();
    ((ISupportInitialize) this.buttonExportToExcel).EndInit();
    ((ISupportInitialize) this.comboDateType).EndInit();
    ((ISupportInitialize) this.buttonContinue).EndInit();
    ((ISupportInitialize) this.buttonPostSelectedResults).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.checkLimitCompanyGroups).EndInit();
    ((ISupportInitialize) this.comboCompanyGroups).EndInit();
    ((ISupportInitialize) this.checkLimitCompanies).EndInit();
    ((ISupportInitialize) this.comboCompanies).EndInit();
    ((ISupportInitialize) this.dateTimeCheckDate).EndInit();
    ((ISupportInitialize) this.comboBankAccounts).EndInit();
    ((ISupportInitialize) this.dateTimeCutOff).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.statusStrip1.ResumeLayout(false);
    this.statusStrip1.PerformLayout();
    this.panel3.ResumeLayout(false);
    ((ISupportInitialize) this.comboPayOptionTypes).EndInit();
    ((ISupportInitialize) this.gridDirectBillResults).EndInit();
    this.dsDirectBillPayables_Bulk1.EndInit();
    this.dsDirectBillPayables1.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
