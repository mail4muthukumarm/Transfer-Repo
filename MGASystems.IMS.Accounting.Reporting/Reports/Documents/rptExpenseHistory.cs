// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Reports.Documents.rptExpenseHistory
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting.Reports.Documents;

[SecureReportResource("{80650EA2-F94D-4c1b-8B81-9CD90507C3A3}", "Expense History Report", "Expense History Report", "Accounting")]
public class rptExpenseHistory : MGAReport, IReport
{
  private int _glCompanyid;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private string _dateType;
  private Guid _entityGuid;
  private Guid _expenseFor;
  private DataSet _ds;
  private DataSet _dsPOHistory;
  private bool _calledFromViewReporting;
  private DataTable _expDt = new DataTable();
  private Decimal _totalAmount;
  private const int _totAmtColIdx = 8;
  private const int _reportFontSize = 10;
  private const int _reportHeaderFontSize = 13;
  private Workbook _wkb = new Workbook();
  private Worksheet _wks;
  private int _rowIndex;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Label label1;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private TextBox textBox1;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox textBox8;
  private TextBox textBox9;
  private TextBox textBox10;
  private Label labPH_ClientOfficeName;
  private Label labPH_DateRange;
  private GroupHeader ghPayeeName;
  private GroupFooter gfPayeeName;
  private GroupHeader ghPONum;
  private GroupFooter gfPONum;
  private TextBox textBox2;
  private TextBox textBox12;
  private TextBox textBox11;
  private Label label3;
  private Label labGF_PayeeNameSubtotal;
  private Label labGF_PONumSubtotal;
  private ReportInfo reportInfo1;
  private Label label2;
  private Label label4;
  private Label label5;
  private Label label6;
  private Label label7;
  private Label label8;
  private Label label9;
  private Label label10;
  private Label labGF_PayeeName;
  private Label labGF_PONum;
  private TextBox textBox13;
  private Label label11;

  public rptExpenseHistory() => this.InitializeComponent();

  public rptExpenseHistory(DataSet dsPOHistory)
  {
    this.InitializeComponent();
    this._dsPOHistory = dsPOHistory;
    this._calledFromViewReporting = false;
  }

  public rptExpenseHistory(
    int glCompanyId,
    DateTime dateFrom,
    DateTime dateTo,
    string dateType,
    Guid entityGuid,
    Guid expenseFor)
  {
    this.InitializeComponent();
    this._glCompanyid = glCompanyId;
    this._dateFrom = dateFrom;
    this._dateTo = dateTo;
    this._dateType = dateType;
    this._calledFromViewReporting = true;
    this._entityGuid = entityGuid;
    this._expenseFor = expenseFor;
  }

  Type IReport.getLaunchForm => (Type) null;

  BaseReportControl[] IReport.getReportControls
  {
    get
    {
      return new BaseReportControl[5]
      {
        (BaseReportControl) new OfficeLocations("Office", false, true),
        (BaseReportControl) new DateRangePicker("Date Range", false),
        (BaseReportControl) new GenericComboBox("Date Type", 100, 150, typeof (string), (object[]) new string[4]
        {
          "Post Date",
          "POST",
          "PO Date",
          "PO"
        }),
        (BaseReportControl) new EntitySelection("Payee", false),
        (BaseReportControl) new GenericComboBox("Expense For", $"(SELECT -1 as Sort, 'All' As ExpenseForName, '{Guid.Empty}' As ExpenseFor) UNION (SELECT DISTINCT 1 as Sort, viewEntityNames.EntityName AS ExpenseForName, tblFin_PODetails.ExpenseFor FROM tblFin_PODetails INNER JOIN viewEntityNames ON tblFin_PODetails.ExpenseFor = viewEntityNames.EntityGuid) ORDER BY Sort, ExpenseForName", "ExpenseFor", "ExpenseForName", typeof (Guid))
      };
    }
  }

  private void rptExpenseHistory_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.HidePrintDateAndTime();
    if (this._calledFromViewReporting)
    {
      this._ds = DefaultDatabase.ExecuteDataSet("spFin_rptExpenseHistory", new object[12]
      {
        (object) "@GLCompanyId",
        (object) this._glCompanyid,
        (object) "@From",
        (object) this._dateFrom,
        (object) "@To",
        (object) this._dateTo,
        (object) "@DateType",
        (object) this._dateType,
        (object) "@EntityGuid",
        (object) this._entityGuid,
        (object) "@ExpenseFor",
        (object) this._expenseFor
      });
      this.DataSource = (object) this._ds.Tables[1];
    }
    else
      this.DataSource = (object) this._dsPOHistory.Tables[1];
  }

  private void pageHeader_Format(object sender, EventArgs e)
  {
    this.labPH_ClientOfficeName.Text = this._ds.Tables[0].Rows[0]["ClientOfficeName"].ToString();
    this.labPH_DateRange.Text = this._ds.Tables[0].Rows[0]["DateRange"].ToString();
  }

  private void gfPONum_Format(object sender, EventArgs e)
  {
    this.labGF_PONumSubtotal.Text = $"PO # {this.labGF_PONum.Text} Subtotal:";
  }

  private void gfPayeeName_Format(object sender, EventArgs e)
  {
    this.labGF_PayeeNameSubtotal.Text = this.labGF_PayeeName.Text + " Total:";
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string saveFileTo)
  {
    this._expDt = this._ds.Tables[1];
    this._wks = this._wkb.Worksheets[0];
    this._wks.Name = "Expense History";
    this._wks.Cells.StandardWidth = 14.0;
    this.PrintColumnHeaders();
    this.PrintDetailLines();
    this.PrintTotalLine();
    this.PrintReportHeader();
    this._wkb.Save(saveFileTo);
    Process.Start(saveFileTo);
  }

  private void PrintColumnHeaders()
  {
    int num = 0;
    foreach (DataColumn column in (InternalDataCollectionBase) this._expDt.Columns)
    {
      Cell cell = this._wks.Cells[this._rowIndex, num];
      cell.SetStyle(this.GetStyle(cell.GetStyle(), rptExpenseHistory.FontStyle.ColumnHeader));
      cell.PutValue(column.ColumnName);
      ++num;
    }
    ++this._rowIndex;
  }

  private void PrintDetailLines()
  {
    foreach (DataRow row in (InternalDataCollectionBase) this._expDt.Rows)
    {
      for (int columnIndex = 0; columnIndex <= this._expDt.Columns.Count - 1; ++columnIndex)
      {
        Cell cell = this._wks.Cells[this._rowIndex, columnIndex];
        if (columnIndex == 8)
          cell.SetStyle(this.GetStyle(cell.GetStyle(), rptExpenseHistory.FontStyle.DetailMoneyValue));
        else
          cell.SetStyle(this.GetStyle(cell.GetStyle(), rptExpenseHistory.FontStyle.DetailPlain));
        cell.PutValue(row[columnIndex]);
      }
      ++this._rowIndex;
    }
  }

  private void PrintTotalLine()
  {
    this._totalAmount = (Decimal) this._ds.Tables[1].Compute("SUM(Amount)", "");
    this._rowIndex += 2;
    Cell cell = this._wks.Cells[this._rowIndex, 8];
    cell.SetStyle(this.GetStyle(cell.GetStyle(), rptExpenseHistory.FontStyle.GrandTotal));
    cell.PutValue(this._totalAmount);
  }

  private void PrintReportHeader()
  {
    this._wks.Cells.InsertRow(0);
    this._wks.Cells.InsertRow(0);
    Cell cell1 = this._wks.Cells[0, 0];
    cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptExpenseHistory.FontStyle.ReportHeader));
    cell1.PutValue(this._ds.Tables[0].Rows[0]["DateRange"].ToString());
    this._wks.Cells.InsertRow(0);
    Cell cell2 = this._wks.Cells[0, 0];
    cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptExpenseHistory.FontStyle.ReportHeader));
    cell2.PutValue(this._ds.Tables[0].Rows[0]["ClientOfficeName"].ToString());
    this._wks.Cells.InsertRow(0);
    Cell cell3 = this._wks.Cells[0, 0];
    cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptExpenseHistory.FontStyle.ReportHeader));
    cell3.PutValue("Expense History Report");
  }

  private Style GetStyle(Style style, rptExpenseHistory.FontStyle myFontStyle)
  {
    switch (myFontStyle)
    {
      case rptExpenseHistory.FontStyle.ColumnHeader:
        style.Font.IsBold = true;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        break;
      case rptExpenseHistory.FontStyle.DetailPlain:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        break;
      case rptExpenseHistory.FontStyle.DetailMoneyValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 7;
        break;
      case rptExpenseHistory.FontStyle.DetailPctValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 9;
        break;
      case rptExpenseHistory.FontStyle.DetailDateValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 14;
        break;
      case rptExpenseHistory.FontStyle.ReportHeader:
        style.Font.IsBold = true;
        style.Font.Size = 13;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        break;
      case rptExpenseHistory.FontStyle.GrandTotal:
        style.Font.IsBold = true;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 7;
        break;
    }
    return style;
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptExpenseHistory));
    this.pageHeader = new PageHeader();
    this.label1 = new Label();
    this.labPH_ClientOfficeName = new Label();
    this.labPH_DateRange = new Label();
    this.detail = new Detail();
    this.textBox1 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.textBox9 = new TextBox();
    this.pageFooter = new PageFooter();
    this.reportInfo1 = new ReportInfo();
    this.reportHeader1 = new ReportHeader();
    this.reportFooter1 = new ReportFooter();
    this.textBox10 = new TextBox();
    this.label3 = new Label();
    this.ghPayeeName = new GroupHeader();
    this.textBox2 = new TextBox();
    this.label2 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.gfPayeeName = new GroupFooter();
    this.textBox12 = new TextBox();
    this.labGF_PayeeNameSubtotal = new Label();
    this.labGF_PayeeName = new Label();
    this.ghPONum = new GroupHeader();
    this.gfPONum = new GroupFooter();
    this.textBox11 = new TextBox();
    this.labGF_PONumSubtotal = new Label();
    this.labGF_PONum = new Label();
    this.label11 = new Label();
    this.textBox13 = new TextBox();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.labPH_ClientOfficeName).BeginInit();
    ((ISupportInitialize) this.labPH_DateRange).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.reportInfo1).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.labGF_PayeeNameSubtotal).BeginInit();
    ((ISupportInitialize) this.labGF_PayeeName).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.labGF_PONumSubtotal).BeginInit();
    ((ISupportInitialize) this.labGF_PONum).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.textBox13).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.label1,
      (ARControl) this.labPH_ClientOfficeName,
      (ARControl) this.labPH_DateRange
    });
    this.pageHeader.Height = 0.8124996f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Name = "pageHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Format += new EventHandler(this.pageHeader_Format);
    ((ARControl) this.label1).Height = 0.25f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.0f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-size: 13pt; font-weight: bold; text-align: center";
    this.label1.Text = "Expense History Report";
    ((ARControl) this.label1).Top = 0.0f;
    ((ARControl) this.label1).Width = 10.375f;
    ((ARControl) this.labPH_ClientOfficeName).Height = 0.25f;
    this.labPH_ClientOfficeName.HyperLink = (string) null;
    ((ARControl) this.labPH_ClientOfficeName).Left = 0.0f;
    ((ARControl) this.labPH_ClientOfficeName).Name = "labPH_ClientOfficeName";
    this.labPH_ClientOfficeName.Style = "font-size: 13pt; font-weight: bold; text-align: center";
    this.labPH_ClientOfficeName.Text = "";
    ((ARControl) this.labPH_ClientOfficeName).Top = 0.25f;
    ((ARControl) this.labPH_ClientOfficeName).Width = 10.375f;
    ((ARControl) this.labPH_DateRange).Height = 0.25f;
    this.labPH_DateRange.HyperLink = (string) null;
    ((ARControl) this.labPH_DateRange).Left = 0.0f;
    ((ARControl) this.labPH_DateRange).Name = "labPH_DateRange";
    this.labPH_DateRange.Style = "font-size: 10pt; font-weight: bold; text-align: center";
    this.labPH_DateRange.Text = "";
    ((ARControl) this.labPH_DateRange).Top = 0.5f;
    ((ARControl) this.labPH_DateRange).Width = 10.375f;
    this.detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.textBox1,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8,
      (ARControl) this.textBox9,
      (ARControl) this.textBox13
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.1979166f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((ARControl) this.textBox1).DataField = "PONum";
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 0.312f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.Style = "font-size: 8pt";
    this.textBox1.Text = (string) null;
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 13f / 16f;
    ((ARControl) this.textBox3).DataField = "PostDate";
    ((ARControl) this.textBox3).Height = 3f / 16f;
    ((ARControl) this.textBox3).Left = 3.749f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.OutputFormat = resourceManager.GetString("textBox3.OutputFormat");
    this.textBox3.Style = "font-size: 8pt";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 0.75f;
    ((ARControl) this.textBox4).DataField = "GLName";
    ((ARControl) this.textBox4).Height = 3f / 16f;
    ((ARControl) this.textBox4).Left = 1.125f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Style = "font-size: 8pt";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 1.718f;
    ((ARControl) this.textBox5).DataField = "CheckNum";
    ((ARControl) this.textBox5).Height = 3f / 16f;
    ((ARControl) this.textBox5).Left = 5.999f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.Style = "font-size: 8pt";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 17f / 16f;
    ((ARControl) this.textBox6).DataField = "Comments";
    ((ARControl) this.textBox6).Height = 3f / 16f;
    ((ARControl) this.textBox6).Left = 7.062f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.Style = "font-size: 8pt";
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 2.437f;
    ((ARControl) this.textBox7).DataField = "DatePaid";
    ((ARControl) this.textBox7).Height = 3f / 16f;
    ((ARControl) this.textBox7).Left = 5.249f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = resourceManager.GetString("textBox7.OutputFormat");
    this.textBox7.Style = "font-size: 8pt";
    this.textBox7.Text = (string) null;
    ((ARControl) this.textBox7).Top = 0.0f;
    ((ARControl) this.textBox7).Width = 0.75f;
    ((ARControl) this.textBox8).DataField = "DueDate";
    ((ARControl) this.textBox8).Height = 3f / 16f;
    ((ARControl) this.textBox8).Left = 4.499f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = resourceManager.GetString("textBox8.OutputFormat");
    this.textBox8.Style = "font-size: 8pt";
    this.textBox8.Text = (string) null;
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 0.75f;
    ((ARControl) this.textBox9).DataField = "Amount";
    ((ARControl) this.textBox9).Height = 3f / 16f;
    ((ARControl) this.textBox9).Left = 9.5f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = resourceManager.GetString("textBox9.OutputFormat");
    this.textBox9.Style = "font-size: 8pt; text-align: right";
    this.textBox9.Text = (string) null;
    ((ARControl) this.textBox9).Top = 0.0f;
    ((ARControl) this.textBox9).Width = 0.8745003f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.reportInfo1
    });
    this.pageFooter.Height = 7f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Name = "pageFooter";
    this.reportInfo1.FormatString = "Page {PageNumber} of {PageCount}.";
    ((ARControl) this.reportInfo1).Height = 0.2f;
    ((ARControl) this.reportInfo1).Left = 8f;
    ((ARControl) this.reportInfo1).Name = "reportInfo1";
    this.reportInfo1.Style = "font-size: 8pt; text-align: right";
    ((ARControl) this.reportInfo1).Top = 0.0f;
    ((ARControl) this.reportInfo1).Width = 2.400001f;
    this.reportHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Name = "reportHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.textBox10,
      (ARControl) this.label3
    });
    this.reportFooter1.Height = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Name = "reportFooter1";
    ((ARControl) this.textBox10).DataField = "Amount";
    ((ARControl) this.textBox10).Height = 3f / 16f;
    ((ARControl) this.textBox10).Left = 147f / 16f;
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.OutputFormat = resourceManager.GetString("textBox10.OutputFormat");
    this.textBox10.Style = "font-weight: bold; text-align: right";
    this.textBox10.SummaryRunning = (SummaryRunning) 2;
    this.textBox10.SummaryType = (SummaryType) 1;
    this.textBox10.Text = (string) null;
    ((ARControl) this.textBox10).Top = 0.125f;
    ((ARControl) this.textBox10).Width = 19f / 16f;
    ((ARControl) this.label3).Height = 3f / 16f;
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Left = 7.5f;
    ((ARControl) this.label3).Name = "label3";
    this.label3.Style = "font-weight: bold; text-align: right";
    this.label3.Text = "Grand Total:";
    ((ARControl) this.label3).Top = 0.125f;
    ((ARControl) this.label3).Width = 1.479499f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghPayeeName).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.textBox2,
      (ARControl) this.label2,
      (ARControl) this.label4,
      (ARControl) this.label5,
      (ARControl) this.label6,
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label9,
      (ARControl) this.label10,
      (ARControl) this.label11
    });
    this.ghPayeeName.DataField = "PayeeName";
    this.ghPayeeName.GroupKeepTogether = (GroupKeepTogether) 2;
    this.ghPayeeName.Height = 0.4583333f;
    this.ghPayeeName.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghPayeeName).Name = "ghPayeeName";
    this.ghPayeeName.RepeatStyle = (RepeatStyle) 1;
    ((ARControl) this.textBox2).DataField = "PayeeName";
    ((ARControl) this.textBox2).Height = 3f / 16f;
    ((ARControl) this.textBox2).Left = 0.0f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "font-weight: bold";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 10f;
    ((ARControl) this.label2).Height = 3f / 16f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 0.312f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-size: 8pt; font-weight: bold";
    this.label2.Text = "PO #";
    ((ARControl) this.label2).Top = 0.25f;
    ((ARControl) this.label2).Width = 13f / 16f;
    ((ARControl) this.label4).Height = 3f / 16f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 3.75f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "font-size: 8pt; font-weight: bold";
    this.label4.Text = "Post Date";
    ((ARControl) this.label4).Top = 0.25f;
    ((ARControl) this.label4).Width = 0.75f;
    ((ARControl) this.label5).Height = 3f / 16f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 1.124f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-size: 8pt; font-weight: bold";
    this.label5.Text = "GL Name";
    ((ARControl) this.label5).Top = 0.25f;
    ((ARControl) this.label5).Width = 1.719f;
    ((ARControl) this.label6).Height = 3f / 16f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 6.000002f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "font-size: 8pt; font-weight: bold";
    this.label6.Text = "Check #";
    ((ARControl) this.label6).Top = 0.25f;
    ((ARControl) this.label6).Width = 17f / 16f;
    ((ARControl) this.label7).Height = 3f / 16f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 7.063001f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "font-size: 8pt; font-weight: bold";
    this.label7.Text = "Comments";
    ((ARControl) this.label7).Top = 0.25f;
    ((ARControl) this.label7).Width = 2.437f;
    ((ARControl) this.label8).Height = 3f / 16f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 5.250002f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "font-size: 8pt; font-weight: bold";
    this.label8.Text = "Date Paid";
    ((ARControl) this.label8).Top = 0.25f;
    ((ARControl) this.label8).Width = 0.75f;
    ((ARControl) this.label9).Height = 3f / 16f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 4.500003f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "font-size: 8pt; font-weight: bold";
    this.label9.Text = "Due Date";
    ((ARControl) this.label9).Top = 0.25f;
    ((ARControl) this.label9).Width = 0.75f;
    ((ARControl) this.label10).Height = 3f / 16f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 9.5f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    this.label10.Text = "Amount";
    ((ARControl) this.label10).Top = 0.25f;
    ((ARControl) this.label10).Width = 0.8745003f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPayeeName).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.textBox12,
      (ARControl) this.labGF_PayeeNameSubtotal,
      (ARControl) this.labGF_PayeeName
    });
    this.gfPayeeName.Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPayeeName).Name = "gfPayeeName";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPayeeName).Format += new EventHandler(this.gfPayeeName_Format);
    ((ARControl) this.textBox12).DataField = "Amount";
    ((ARControl) this.textBox12).Height = 3f / 16f;
    ((ARControl) this.textBox12).Left = 9.499001f;
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.OutputFormat = resourceManager.GetString("textBox12.OutputFormat");
    this.textBox12.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    this.textBox12.SummaryGroup = "ghPayeeName";
    this.textBox12.SummaryRunning = (SummaryRunning) 1;
    this.textBox12.SummaryType = (SummaryType) 3;
    this.textBox12.Text = (string) null;
    ((ARControl) this.textBox12).Top = 0.012f;
    ((ARControl) this.textBox12).Width = 0.8754997f;
    ((ARControl) this.labGF_PayeeNameSubtotal).Height = 3f / 16f;
    this.labGF_PayeeNameSubtotal.HyperLink = (string) null;
    ((ARControl) this.labGF_PayeeNameSubtotal).Left = 0.437f;
    ((ARControl) this.labGF_PayeeNameSubtotal).Name = "labGF_PayeeNameSubtotal";
    this.labGF_PayeeNameSubtotal.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    this.labGF_PayeeNameSubtotal.Text = "";
    ((ARControl) this.labGF_PayeeNameSubtotal).Top = 0.012f;
    ((ARControl) this.labGF_PayeeNameSubtotal).Width = 8.9175f;
    ((ARControl) this.labGF_PayeeName).DataField = "PayeeName";
    ((ARControl) this.labGF_PayeeName).Height = 0.2f;
    this.labGF_PayeeName.HyperLink = (string) null;
    ((ARControl) this.labGF_PayeeName).Left = 0.0f;
    ((ARControl) this.labGF_PayeeName).Name = "labGF_PayeeName";
    this.labGF_PayeeName.Style = "background-color: Red";
    this.labGF_PayeeName.Text = "";
    ((ARControl) this.labGF_PayeeName).Top = 3.72529E-09f;
    ((ARControl) this.labGF_PayeeName).Visible = false;
    ((ARControl) this.labGF_PayeeName).Width = 0.2290003f;
    this.ghPONum.DataField = "PONum";
    this.ghPONum.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghPONum).Name = "ghPONum";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPONum).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.textBox11,
      (ARControl) this.labGF_PONumSubtotal,
      (ARControl) this.labGF_PONum
    });
    this.gfPONum.Height = 0.2604167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPONum).Name = "gfPONum";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPONum).Format += new EventHandler(this.gfPONum_Format);
    ((ARControl) this.textBox11).DataField = "Amount";
    ((ARControl) this.textBox11).Height = 3f / 16f;
    ((ARControl) this.textBox11).Left = 9.499001f;
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.OutputFormat = resourceManager.GetString("textBox11.OutputFormat");
    this.textBox11.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    this.textBox11.SummaryGroup = "ghPONum";
    this.textBox11.SummaryRunning = (SummaryRunning) 1;
    this.textBox11.SummaryType = (SummaryType) 3;
    this.textBox11.Text = (string) null;
    ((ARControl) this.textBox11).Top = 0.062f;
    ((ARControl) this.textBox11).Width = 0.8754997f;
    ((ARControl) this.labGF_PONumSubtotal).Height = 3f / 16f;
    this.labGF_PONumSubtotal.HyperLink = (string) null;
    ((ARControl) this.labGF_PONumSubtotal).Left = 0.437f;
    ((ARControl) this.labGF_PONumSubtotal).Name = "labGF_PONumSubtotal";
    this.labGF_PONumSubtotal.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    this.labGF_PONumSubtotal.Text = "";
    ((ARControl) this.labGF_PONumSubtotal).Top = 0.062f;
    ((ARControl) this.labGF_PONumSubtotal).Width = 8.9175f;
    ((ARControl) this.labGF_PONum).DataField = "PONum";
    ((ARControl) this.labGF_PONum).Height = 0.2f;
    this.labGF_PONum.HyperLink = (string) null;
    ((ARControl) this.labGF_PONum).Left = 0.0f;
    ((ARControl) this.labGF_PONum).Name = "labGF_PONum";
    this.labGF_PONum.Style = "background-color: Red";
    this.labGF_PONum.Text = "";
    ((ARControl) this.labGF_PONum).Top = 0.062f;
    ((ARControl) this.labGF_PONum).Visible = false;
    ((ARControl) this.labGF_PONum).Width = 0.2290003f;
    ((ARControl) this.label11).Height = 3f / 16f;
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Left = 2.843f;
    ((ARControl) this.label11).Name = "label11";
    this.label11.Style = "font-size: 8pt; font-weight: bold";
    this.label11.Text = "Expense For";
    ((ARControl) this.label11).Top = 0.25f;
    ((ARControl) this.label11).Width = 0.906f;
    ((ARControl) this.textBox13).DataField = "ExpenseForName";
    ((ARControl) this.textBox13).Height = 3f / 16f;
    ((ARControl) this.textBox13).Left = 2.843f;
    ((ARControl) this.textBox13).Name = "textBox13";
    this.textBox13.Style = "font-size: 8pt";
    this.textBox13.Text = (string) null;
    ((ARControl) this.textBox13).Top = 0.0f;
    ((ARControl) this.textBox13).Width = 0.9060001f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghPayeeName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghPONum);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPONum);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfPayeeName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.rptExpenseHistory_ReportStart);
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.labPH_ClientOfficeName).EndInit();
    ((ISupportInitialize) this.labPH_DateRange).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.reportInfo1).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.labGF_PayeeNameSubtotal).EndInit();
    ((ISupportInitialize) this.labGF_PayeeName).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.labGF_PONumSubtotal).EndInit();
    ((ISupportInitialize) this.labGF_PONum).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.textBox13).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private enum FontStyle
  {
    ColumnHeader,
    DetailPlain,
    DetailMoneyValue,
    DetailPctValue,
    DetailDateValue,
    ReportHeader,
    GrandTotal,
  }
}
