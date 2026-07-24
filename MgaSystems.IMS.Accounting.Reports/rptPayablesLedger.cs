// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptPayablesLedger
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{B23FBB87-7B33-4b1b-8622-6495C04C4030}", "Accounts Payable Ledger Report", "Accounts Payable Ledger Report.", "Accounting")]
public sealed class rptPayablesLedger : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{B23FBB87-7B33-4b1b-8622-6495C04C4030}";
  private DataTable dtHeader;
  private DataTable dtDetail;
  private int _glCompanyId;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private bool _showZeros;
  private DataTable dt;
  private int recMax;
  private int recs;
  private bool finished;
  private Label Label1;
  private TextBox TextBox1;
  private Label lblDates;
  private SubReport SubReport1;

  public rptPayablesLedger()
  {
    this.ReportStart += new EventHandler(this.rptReceivablesLedger_ReportStart);
    this.recMax = 50;
    this.finished = false;
    this.InitializeComponent();
  }

  public rptPayablesLedger(int glCompanyId, DateTime DateFrom, DateTime DateTo, bool ShowZeros)
  {
    this.ReportStart += new EventHandler(this.rptReceivablesLedger_ReportStart);
    this.recMax = 50;
    this.finished = false;
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this._dateFrom = DateFrom;
    this._dateTo = DateTo;
    this._showZeros = ShowZeros;
    this.SetProgressbarMaximum(this.recMax);
    this.LoadData();
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptPayablesLedger));
    this.Detail = new Detail();
    this.SubReport1 = new SubReport();
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.TextBox1 = new TextBox();
    this.lblDates = new Label();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.lblDates).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.SubReport1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 7f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.SubReport1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.SubReport1).Border.TopStyle = (BorderLineStyle) 0;
    this.SubReport1.CloseBorder = false;
    SubReport subReport1 = this.SubReport1;
    object obj1 = componentResourceManager.GetObject("SubReport1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) subReport1).Location = pointF1;
    ((ARControl) this.SubReport1).Name = "SubReport1";
    this.SubReport1.Report = (SectionReport) null;
    ((ARControl) this.SubReport1).Size = new SizeF(10.4f, 0.188f);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label1,
      (ARControl) this.TextBox1,
      (ARControl) this.lblDates
    });
    this.PageHeader.Height = 0.6354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj2 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label1).Location = pointF2;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(7.875f, 0.2f);
    this.Label1.Text = "A/P Ledger";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "location";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj3 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox1).Location = pointF3;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(71f / 16f, 0.2f);
    this.TextBox1.Text = (string) null;
    ((ARControl) this.lblDates).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDates).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDates).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDates).Border.TopStyle = (BorderLineStyle) 0;
    this.lblDates.Font = new Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblDates.HyperLink = (string) null;
    Label lblDates = this.lblDates;
    object obj4 = componentResourceManager.GetObject("lblDates.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) lblDates).Location = pointF4;
    ((ARControl) this.lblDates).Name = "lblDates";
    ((ARControl) this.lblDates).Size = new SizeF(4.375f, 0.2f);
    this.lblDates.Text = "Label2";
    this.PageFooter.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.lblDates).EndInit();
  }

  private void LoadData()
  {
    this.dtHeader = Database.Instance.QuerySP.PerformTableQuery("spFin_rptPayablesLedgerHeader", (object) "@glcompanyid", (object) this._glCompanyId, (object) "@dateFrom", (object) this._dateFrom, (object) "@dateTo", (object) this._dateTo);
    Database.Instance.QueryMultithreadedSP.PerformTableQueryBG(new TableQueryMultithreadEventHandler(this.TableFilled), new TableFillingEventHandler(this.TableFilling), (object) "payablesLedger", "spFin_rptPayablesLedger", (object) "@glcompanyid", (object) this._glCompanyId, (object) "@dateFrom", (object) this._dateFrom, (object) "@dateTo", (object) this._dateTo, (object) "@showzeros", (object) this._showZeros);
  }

  private void TableFilling(object sender, TableFillingEventArgs e)
  {
    this.SetStatusText("Formatting..");
    this.IncreaseProgressbar(1);
    // ISSUE: variable of a reference type
    int& local1;
    // ISSUE: explicit reference operation
    int num1 = checked (^(local1 = ref this.recs) + 1);
    local1 = num1;
    if (checked (this.recs - 1) != this.recMax)
      return;
    // ISSUE: variable of a reference type
    int& local2;
    // ISSUE: explicit reference operation
    int num2 = checked (^(local2 = ref this.recMax) + 50);
    local2 = num2;
    this.SetProgressbarMaximum(this.recMax);
  }

  private void TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    this.dtDetail = e.Table;
    this.finished = true;
  }

  private void rptReceivablesLedger_ReportStart(object sender, EventArgs e)
  {
    do
      ;
    while (!this.finished);
    this.DataSource = (object) this.dtHeader;
    this.lblDates.Text = $"Payables Ledger ({Strings.Format((object) this._dateFrom, "Short Date").ToString()}-{Strings.Format((object) this._dateTo, "Short Date").ToString()})";
    if (this.dtDetail != null)
    {
      rptPayablesLedger_Detail payablesLedgerDetail = new rptPayablesLedger_Detail();
      payablesLedgerDetail.DataSource = (object) this.dtDetail;
      this.SubReport1.Report = (SectionReport) payablesLedgerDetail;
    }
    this.ShowPageNumbers();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[3]
      {
        (BaseReportControl) new AccountingOfficeLocations("Office", false, true),
        null,
        null
      };
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[1] = (BaseReportControl) new DateRangePicker("Invoice Date", date1, date2, false);
      getReportControls[2] = (BaseReportControl) new GenericComboBox("Show Zero Invoices", 100, 100, typeof (bool), new object[4]
      {
        (object) "Yes",
        (object) true,
        (object) "No",
        (object) false
      });
      return getReportControls;
    }
  }

  public override bool IsThreaded => true;

  public override bool HasRecords => this.dtDetail.Rows.Count > 0;

  public override void ExportToExcel(string SaveFileTo)
  {
    DataSet exDataSet = new DataSet();
    DataTable table = new DataTable();
    table.Columns.Add("Policy Number");
    table.Columns.Add("Invoice Number");
    table.Columns.Add("Insured");
    table.Columns.Add("Invoice Date");
    table.Columns.Add("Opening Balance");
    table.Columns.Add("Billings");
    table.Columns.Add("A/P Paid");
    table.Columns.Add("Closing Balance");
    table.Columns.Add("Invoice Month");
    table.Columns.Add("Due Date");
    table.Columns.Add("Printed");
    table.Columns.Add("Policy Effective Date");
    table.Columns.Add("Is Installment Invoice");
    table.Columns["Invoice Number"].DataType = Type.GetType("System.Decimal");
    table.Columns["Opening Balance"].DataType = Type.GetType("System.Decimal");
    table.Columns["Billings"].DataType = Type.GetType("System.Decimal");
    table.Columns["A/P Paid"].DataType = Type.GetType("System.Decimal");
    table.Columns["Closing Balance"].DataType = Type.GetType("System.Decimal");
    table.Columns["Invoice Month"].DataType = Type.GetType("System.Decimal");
    try
    {
      foreach (DataRow row1 in this.dtDetail.Rows)
      {
        DataRow row2 = table.NewRow();
        row2[0] = RuntimeHelpers.GetObjectValue(row1[0]);
        row2[1] = RuntimeHelpers.GetObjectValue(row1[1]);
        row2[2] = RuntimeHelpers.GetObjectValue(row1[2]);
        row2[3] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(row1[3], (Type) null, "ToShortDateString", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
        row2[4] = RuntimeHelpers.GetObjectValue(row1[4]);
        row2[5] = RuntimeHelpers.GetObjectValue(row1[5]);
        row2[6] = RuntimeHelpers.GetObjectValue(row1[6]);
        row2[7] = RuntimeHelpers.GetObjectValue(row1[7]);
        row2[8] = RuntimeHelpers.GetObjectValue(row1[8]);
        row2[9] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(row1[9], (Type) null, "ToShortDateString", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
        row2[10] = RuntimeHelpers.GetObjectValue(row1[10]);
        row2[11] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(row1[11], (Type) null, "ToShortDateString", new object[0], (string[]) null, (Type[]) null, (bool[]) null));
        row2[12] = RuntimeHelpers.GetObjectValue(row1[12]);
        table.Rows.Add(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    exDataSet.Tables.Add(table);
    exDataSet.Tables[0].TableName = "AP Ledger";
    this.DoExport(exDataSet, 1, true).Save(SaveFileTo);
  }

  public Workbook DoExport(DataSet exDataSet, int tableCount, bool showFieldName)
  {
    Workbook workbook = new Workbook();
    this.AddWorksheets(exDataSet, workbook, tableCount, showFieldName);
    return workbook;
  }

  private void AddWorksheets(DataSet data, Workbook workbook, int tableCount, bool showFieldName)
  {
    workbook.Worksheets.Clear();
    int num = checked (tableCount - 1);
    int index = 0;
    while (index <= num)
    {
      Worksheet worksheet = workbook.Worksheets.Add(data.Tables[index].TableName);
      this.AddData(data.Tables[index], worksheet, showFieldName);
      checked { ++index; }
    }
  }

  private void AddData(DataTable dt, Worksheet worksheet, bool showFieldName)
  {
    if (dt.Rows.Count == 0)
      return;
    worksheet.Cells.ImportDataTable(dt, showFieldName, "A1");
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
