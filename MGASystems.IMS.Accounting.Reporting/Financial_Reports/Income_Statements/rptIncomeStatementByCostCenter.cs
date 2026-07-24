// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Financial_Reports.Income_Statements.rptIncomeStatementByCostCenter
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting.Financial_Reports.Income_Statements;

[SecureReportResource("{97E8586E-C6BB-4ef7-9C14-5DB92BF81EAC}", "Income Statement By Cost Center", "Income Statement By Cost Center", "Financials")]
public class rptIncomeStatementByCostCenter : MGAExcelReport, IReport
{
  private const int reportFontSize = 8;
  private const int headerFontSize = 12;
  private int _glCompanyid;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private dsIncomeStatementByCostCenter _data;
  private DataSet _ds;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private TextBox textPHOfficeName;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private GroupHeader ghAcctClass;
  private GroupFooter gfAcctClass;
  private GroupHeader ghAcctTypeDesc;
  private GroupFooter gfAcctTypeDesc;
  private TextBox textGhAcctClass;
  private TextBox textGhAcctTypeDesc;
  private TextBox textBox9;
  private TextBox textBox8;
  private TextBox textGfAcctClassTotal;
  private TextBox textGfAcctTypeDescTotal;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox textPHIncomeStmtYear;
  private TextBox textPHRunDate;

  public rptIncomeStatementByCostCenter() => this.InitializeComponent();

  public rptIncomeStatementByCostCenter(int glCompanyId, DateTime dateFrom, DateTime dateTo)
  {
    this.InitializeComponent();
    this._glCompanyid = glCompanyId;
    this._dateFrom = dateFrom;
    this._dateTo = dateTo;
  }

  Type IReport.getLaunchForm => (Type) null;

  BaseReportControl[] IReport.getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new AccountingOfficeLocations("Office", false, true),
        (BaseReportControl) new DateRangePicker("Date Range", false)
      };
    }
  }

  public override bool HasRecords => this._data.Tables[0].Rows.Count > 0;

  private dsIncomeStatementByCostCenter GetData()
  {
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_IncomeStatementByCostCenter", new object[6]
    {
      (object) "@GlCompanyId",
      (object) this._glCompanyid,
      (object) "@DateFrom",
      (object) this._dateFrom,
      (object) "@DateTo",
      (object) this._dateTo
    });
    return this.TransformData(this._ds);
  }

  private dsIncomeStatementByCostCenter TransformData(DataSet ds)
  {
    dsIncomeStatementByCostCenter statementByCostCenter = new dsIncomeStatementByCostCenter();
    foreach (DataRow row in (InternalDataCollectionBase) ds.Tables[1].Rows)
      statementByCostCenter.IncomeStatement.Columns.Add(row["CostCenter"].ToString(), typeof (Decimal));
    foreach (DataRow row1 in (InternalDataCollectionBase) ds.Tables[0].DefaultView.ToTable(true, "FullName", "GLAcctId", "AcctClassName", "AcctTypeDescription").Rows)
    {
      DataRow dataRow = statementByCostCenter.Tables[0].Rows.Add(row1["GLAcctId"], row1["FullName"], row1["AcctClassName"], row1["AcctTypeDescription"], ds.Tables[0].Compute("SUM(Amount)", $"GLAcctId = {row1["GLAcctId"]}"));
      foreach (DataRow row2 in (InternalDataCollectionBase) ds.Tables[1].Rows)
        dataRow[row2["CostCenter"].ToString()] = ds.Tables[0].Compute("SUM(Amount)", $"GLAcctId = {row1["GLAcctId"]} AND CostCenterId = {row2["CostCenterId"]}");
    }
    return statementByCostCenter;
  }

  private void Maritime_IncomeStatement_ReportStart(object sender, EventArgs e)
  {
    this.HidePrintDateAndTime();
    this._data = this.GetData();
  }

  protected override void DoExport(string excelFileName)
  {
    Workbook wkb = new Workbook((FileFormatType) 6);
    this.CreateWorkbookHeaders(wkb);
    wkb.Save(excelFileName);
  }

  private Style GetStyle(Style style, rptIncomeStatementByCostCenter.FontStyle fontStyle)
  {
    switch (fontStyle)
    {
      case rptIncomeStatementByCostCenter.FontStyle.ReportHeader:
        style.Font.IsBold = true;
        style.Font.Size = 12;
        style.Font.Name = "Arial";
        break;
      case rptIncomeStatementByCostCenter.FontStyle.ColumnHeader:
        style.Font.IsBold = false;
        style.Font.Underline = (FontUnderlineType) 4;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptIncomeStatementByCostCenter.FontStyle.SubTotal:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptIncomeStatementByCostCenter.FontStyle.GrandTotal:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptIncomeStatementByCostCenter.FontStyle.ReportContent:
        style.Font.IsBold = false;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptIncomeStatementByCostCenter.FontStyle.ClassHeader:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptIncomeStatementByCostCenter.FontStyle.SubTotalMoneyValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 44;
        style.Borders[(BorderType) 4].Color = Color.Black;
        style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
        break;
      case rptIncomeStatementByCostCenter.FontStyle.GrandTotalMoneyValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 44;
        style.Borders[(BorderType) 4].Color = Color.Black;
        style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
        style.Borders[(BorderType) 8].Color = Color.Black;
        style.Borders[(BorderType) 8].LineStyle = (CellBorderType) 6;
        break;
    }
    return style;
  }

  private void CreateWorkbookHeaders(Workbook wkb)
  {
    Worksheet worksheet = wkb.Worksheets[0];
    worksheet.Name = "Income Statement By Cost Center";
    Cell cell1 = worksheet.Cells["A1"];
    cell1.PutValue("Income Statement By Cost Center");
    cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.ReportHeader));
    Cell cell2 = worksheet.Cells["A2"];
    cell2.PutValue(this._ds.Tables[2].Rows[0]["OfficeName"]);
    cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.GrandTotal));
    Cell cell3 = worksheet.Cells["C2"];
    cell3.PutValue(this._ds.Tables[2].Rows[0]["IncomeStatementYear"]);
    cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.GrandTotal));
    Cell cell4 = worksheet.Cells["E2"];
    cell4.PutValue(this._ds.Tables[2].Rows[0]["RunDate"]);
    cell4.SetStyle(this.GetStyle(cell4.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.GrandTotal));
    int num = 5;
    foreach (DataColumn column in (InternalDataCollectionBase) this._data.Tables[0].Columns)
    {
      Cell cell5 = worksheet.Cells[2, num];
      if (column.DataType == typeof (Decimal))
      {
        cell5.PutValue(column.ColumnName);
        ++num;
      }
    }
    this.CreateIncomeStatement(worksheet);
  }

  private void CreateIncomeStatement(Worksheet wks)
  {
    DataTable table1 = this._data.Tables[0].DefaultView.ToTable(true, "AcctClass");
    DataTable table2 = this._data.Tables[0].DefaultView.ToTable(true, "AcctClass", "AcctTypeDescription");
    int num1 = 4;
    int num2 = 0;
    foreach (DataRow row in (InternalDataCollectionBase) table1.Rows)
    {
      int num3 = 0;
      Cell cell1 = wks.Cells[num1, num3];
      cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.ClassHeader));
      cell1.PutValue(row[0].ToString());
      ++num1;
      int num4 = num3 + 1;
      DataRow[] dataRowArray1 = table2.Select($"AcctClass = '{row[0].ToString()}'");
      for (int index1 = 0; index1 <= dataRowArray1.Length; ++index1)
      {
        if (index1 == dataRowArray1.Length)
        {
          Cell cell2 = wks.Cells[num1, num4];
          cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.GrandTotal));
          cell2.PutValue("Total " + row[0].ToString());
          int num5 = 5;
          for (int index2 = 4; index2 < this._data.Tables[0].Columns.Count; ++index2)
          {
            Cell cell3 = wks.Cells[num1, num5];
            cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.GrandTotalMoneyValue));
            object obj = this._data.Tables[0].Compute($"SUM([{this._data.Tables[0].Columns[index2].ColumnName}])", $"AcctClass = '{row[0].ToString()}'");
            if (obj == null || string.IsNullOrEmpty(obj.ToString()))
              obj = (object) 0M;
            cell3.PutValue(Decimal.Parse(obj.ToString()));
            ++num5;
          }
          ++num1;
          break;
        }
        int num6 = 1;
        Cell cell4 = wks.Cells[num1, num6];
        cell4.SetStyle(this.GetStyle(cell4.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.ClassHeader));
        cell4.PutValue(dataRowArray1[index1][1].ToString());
        ++num1;
        num4 = num6 + 1;
        DataRow[] dataRowArray2 = this._data.Tables[0].Select($"AcctClass = '{row[0].ToString()}' AND AcctTypeDescription = '{dataRowArray1[index1][1].ToString()}'", "FullName");
        for (int index3 = 0; index3 <= dataRowArray2.Length; ++index3)
        {
          if (index3 == dataRowArray2.Length)
          {
            ++num4;
            Cell cell5 = wks.Cells[num1, num4];
            cell5.SetStyle(this.GetStyle(cell5.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.SubTotal));
            cell5.PutValue("Total " + dataRowArray1[index1][1].ToString());
            int num7 = 5;
            for (int index4 = 4; index4 < this._data.Tables[0].Columns.Count; ++index4)
            {
              Cell cell6 = wks.Cells[num1, num7];
              cell6.SetStyle(this.GetStyle(cell6.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.SubTotalMoneyValue));
              object obj = this._data.Tables[0].Compute($"SUM([{this._data.Tables[0].Columns[index4].ColumnName}])", $"AcctClass = '{row[0].ToString()}' AND AcctTypeDescription = '{dataRowArray1[index1][1].ToString()}'");
              if (obj == null || string.IsNullOrEmpty(obj.ToString()))
                obj = (object) 0M;
              cell6.PutValue(Decimal.Parse(obj.ToString()));
              ++num7;
            }
            ++num1;
            break;
          }
          Cell cell7 = wks.Cells[num1, num4];
          cell7.SetStyle(this.GetStyle(cell7.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.ReportContent));
          cell7.PutValue(dataRowArray2[index3]["FullName"].ToString());
          int num8 = 5;
          for (int columnIndex = 4; columnIndex < this._data.Tables[0].Columns.Count; ++columnIndex)
          {
            Cell cell8 = wks.Cells[num1, num8];
            cell8.SetStyle(this.GetStyle(cell8.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.ReportContent));
            if (!string.IsNullOrEmpty(dataRowArray2[index3][columnIndex].ToString()))
              cell8.PutValue(Decimal.Parse(dataRowArray2[index3][columnIndex].ToString()));
            ++num8;
          }
          ++num1;
        }
      }
      ++num1;
      num2 = num4 + 1;
    }
    int num9 = 1;
    Cell cell9 = wks.Cells[num1, num9];
    cell9.SetStyle(this.GetStyle(cell9.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.GrandTotal));
    cell9.PutValue("NET INCOME/LOSS");
    int num10 = 5;
    for (int index = 4; index < this._data.Tables[0].Columns.Count; ++index)
    {
      Cell cell10 = wks.Cells[num1, num10];
      cell10.SetStyle(this.GetStyle(cell10.GetStyle(), rptIncomeStatementByCostCenter.FontStyle.SubTotalMoneyValue));
      object obj1 = this._data.Tables[0].Compute($"SUM([{this._data.Tables[0].Columns[index].ColumnName}])", "ACCTCLASS = 'INCOME'");
      object obj2 = this._data.Tables[0].Compute($"SUM([{this._data.Tables[0].Columns[index].ColumnName}])", "ACCTCLASS = 'EXPENSES'");
      if (obj1 == null || string.IsNullOrEmpty(obj1.ToString()))
        obj1 = (object) 0M;
      if (obj2 == null || string.IsNullOrEmpty(obj2.ToString()))
        obj2 = (object) 0M;
      cell10.PutValue(Decimal.Parse(obj1.ToString()) - Decimal.Parse(obj2.ToString()));
      ++num10;
    }
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptIncomeStatementByCostCenter));
    this.pageHeader = new PageHeader();
    this.textPHOfficeName = new TextBox();
    this.textBox3 = new TextBox();
    this.textPHIncomeStmtYear = new TextBox();
    this.textPHRunDate = new TextBox();
    this.detail = new Detail();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.pageFooter = new PageFooter();
    this.ghAcctClass = new GroupHeader();
    this.textGhAcctClass = new TextBox();
    this.gfAcctClass = new GroupFooter();
    this.textBox9 = new TextBox();
    this.textGfAcctClassTotal = new TextBox();
    this.ghAcctTypeDesc = new GroupHeader();
    this.textGhAcctTypeDesc = new TextBox();
    this.gfAcctTypeDesc = new GroupFooter();
    this.textBox8 = new TextBox();
    this.textGfAcctTypeDescTotal = new TextBox();
    this.reportHeader1 = new ReportHeader();
    this.reportFooter1 = new ReportFooter();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    ((ISupportInitialize) this.textPHOfficeName).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textPHIncomeStmtYear).BeginInit();
    ((ISupportInitialize) this.textPHRunDate).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textGhAcctClass).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.textGfAcctClassTotal).BeginInit();
    ((ISupportInitialize) this.textGhAcctTypeDesc).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textGfAcctTypeDescTotal).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.textPHOfficeName,
      (ARControl) this.textBox3,
      (ARControl) this.textPHIncomeStmtYear,
      (ARControl) this.textPHRunDate
    });
    this.pageHeader.Height = 0.875f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Name = "pageHeader";
    ((ARControl) this.textPHOfficeName).Border.BottomColor = Color.Black;
    ((ARControl) this.textPHOfficeName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHOfficeName).Border.LeftColor = Color.Black;
    ((ARControl) this.textPHOfficeName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHOfficeName).Border.RightColor = Color.Black;
    ((ARControl) this.textPHOfficeName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHOfficeName).Border.TopColor = Color.Black;
    ((ARControl) this.textPHOfficeName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHOfficeName).Height = 3f / 16f;
    ((ARControl) this.textPHOfficeName).Left = 0.0f;
    ((ARControl) this.textPHOfficeName).Name = "textPHOfficeName";
    this.textPHOfficeName.Style = "font-weight: bold; font-size: 12pt; ";
    this.textPHOfficeName.Text = (string) null;
    ((ARControl) this.textPHOfficeName).Top = 0.0f;
    ((ARControl) this.textPHOfficeName).Width = 2.875f;
    ((ARControl) this.textBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.RightColor = Color.Black;
    ((ARControl) this.textBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.TopColor = Color.Black;
    ((ARControl) this.textBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Height = 0.1979167f;
    ((ARControl) this.textBox3).Left = 3f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "text-decoration: underline; text-align: center; font-size: 8pt; ";
    this.textBox3.Text = "TOTAL";
    ((ARControl) this.textBox3).Top = 7f / 16f;
    ((ARControl) this.textBox3).Width = 1f;
    ((ARControl) this.textPHIncomeStmtYear).Border.BottomColor = Color.Black;
    ((ARControl) this.textPHIncomeStmtYear).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHIncomeStmtYear).Border.LeftColor = Color.Black;
    ((ARControl) this.textPHIncomeStmtYear).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHIncomeStmtYear).Border.RightColor = Color.Black;
    ((ARControl) this.textPHIncomeStmtYear).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHIncomeStmtYear).Border.TopColor = Color.Black;
    ((ARControl) this.textPHIncomeStmtYear).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHIncomeStmtYear).Height = 3f / 16f;
    ((ARControl) this.textPHIncomeStmtYear).Left = 0.0f;
    ((ARControl) this.textPHIncomeStmtYear).Name = "textPHIncomeStmtYear";
    this.textPHIncomeStmtYear.Style = "font-weight: bold; font-size: 8pt; ";
    this.textPHIncomeStmtYear.Text = (string) null;
    ((ARControl) this.textPHIncomeStmtYear).Top = 7f / 16f;
    ((ARControl) this.textPHIncomeStmtYear).Width = 2f;
    ((ARControl) this.textPHRunDate).Border.BottomColor = Color.Black;
    ((ARControl) this.textPHRunDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHRunDate).Border.LeftColor = Color.Black;
    ((ARControl) this.textPHRunDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHRunDate).Border.RightColor = Color.Black;
    ((ARControl) this.textPHRunDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHRunDate).Border.TopColor = Color.Black;
    ((ARControl) this.textPHRunDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textPHRunDate).Height = 3f / 16f;
    ((ARControl) this.textPHRunDate).Left = 3f;
    ((ARControl) this.textPHRunDate).Name = "textPHRunDate";
    this.textPHRunDate.OutputFormat = resourceManager.GetString("textPHRunDate.OutputFormat");
    this.textPHRunDate.Style = "font-weight: bold; font-size: 8pt; ";
    this.textPHRunDate.Text = (string) null;
    ((ARControl) this.textPHRunDate).Top = 0.0f;
    ((ARControl) this.textPHRunDate).Width = 1f;
    this.detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.textBox4,
      (ARControl) this.textBox5
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((ARControl) this.textBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.RightColor = Color.Black;
    ((ARControl) this.textBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.TopColor = Color.Black;
    ((ARControl) this.textBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).DataField = "FullName";
    ((ARControl) this.textBox4).Height = 3f / 16f;
    ((ARControl) this.textBox4).Left = 0.625f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Style = "font-size: 8pt; ";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 2.375f;
    ((ARControl) this.textBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.RightColor = Color.Black;
    ((ARControl) this.textBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.TopColor = Color.Black;
    ((ARControl) this.textBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).DataField = "Total";
    ((ARControl) this.textBox5).Height = 0.1979167f;
    ((ARControl) this.textBox5).Left = 3f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = resourceManager.GetString("textBox5.OutputFormat");
    this.textBox5.Style = "text-align: right; font-size: 8pt; ";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 1f;
    this.pageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Name = "pageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClass).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.textGhAcctClass
    });
    this.ghAcctClass.DataField = "AcctClass";
    this.ghAcctClass.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClass).Name = "ghAcctClass";
    ((ARControl) this.textGhAcctClass).Border.BottomColor = Color.Black;
    ((ARControl) this.textGhAcctClass).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctClass).Border.LeftColor = Color.Black;
    ((ARControl) this.textGhAcctClass).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctClass).Border.RightColor = Color.Black;
    ((ARControl) this.textGhAcctClass).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctClass).Border.TopColor = Color.Black;
    ((ARControl) this.textGhAcctClass).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctClass).DataField = "AcctClass";
    ((ARControl) this.textGhAcctClass).Height = 3f / 16f;
    ((ARControl) this.textGhAcctClass).Left = 0.0f;
    ((ARControl) this.textGhAcctClass).Name = "textGhAcctClass";
    this.textGhAcctClass.Style = "font-weight: bold; font-size: 8pt; ";
    this.textGhAcctClass.Text = (string) null;
    ((ARControl) this.textGhAcctClass).Top = 0.0f;
    ((ARControl) this.textGhAcctClass).Width = 4f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClass).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.textBox9,
      (ARControl) this.textGfAcctClassTotal
    });
    this.gfAcctClass.Height = 0.2916667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClass).Name = "gfAcctClass";
    ((ARControl) this.textBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox9).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.textBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.RightColor = Color.Black;
    ((ARControl) this.textBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.TopColor = Color.Black;
    ((ARControl) this.textBox9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox9).DataField = "Total";
    ((ARControl) this.textBox9).Height = 0.1979167f;
    ((ARControl) this.textBox9).Left = 3f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = resourceManager.GetString("textBox9.OutputFormat");
    this.textBox9.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.textBox9.SummaryGroup = "ghAcctClass";
    this.textBox9.SummaryRunning = (SummaryRunning) 1;
    this.textBox9.SummaryType = (SummaryType) 3;
    this.textBox9.Text = (string) null;
    ((ARControl) this.textBox9).Top = 0.0f;
    ((ARControl) this.textBox9).Width = 1f;
    ((ARControl) this.textGfAcctClassTotal).Border.BottomColor = Color.Black;
    ((ARControl) this.textGfAcctClassTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGfAcctClassTotal).Border.LeftColor = Color.Black;
    ((ARControl) this.textGfAcctClassTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGfAcctClassTotal).Border.RightColor = Color.Black;
    ((ARControl) this.textGfAcctClassTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGfAcctClassTotal).Border.TopColor = Color.Black;
    ((ARControl) this.textGfAcctClassTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGfAcctClassTotal).Height = 3f / 16f;
    ((ARControl) this.textGfAcctClassTotal).Left = 1f / 16f;
    ((ARControl) this.textGfAcctClassTotal).Name = "textGfAcctClassTotal";
    this.textGfAcctClassTotal.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.textGfAcctClassTotal.Text = (string) null;
    ((ARControl) this.textGfAcctClassTotal).Top = 0.0f;
    ((ARControl) this.textGfAcctClassTotal).Width = 2.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDesc).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.textGhAcctTypeDesc
    });
    this.ghAcctTypeDesc.DataField = "AcctTypeDescription";
    this.ghAcctTypeDesc.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDesc).Name = "ghAcctTypeDesc";
    ((ARControl) this.textGhAcctTypeDesc).Border.BottomColor = Color.Black;
    ((ARControl) this.textGhAcctTypeDesc).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctTypeDesc).Border.LeftColor = Color.Black;
    ((ARControl) this.textGhAcctTypeDesc).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctTypeDesc).Border.RightColor = Color.Black;
    ((ARControl) this.textGhAcctTypeDesc).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctTypeDesc).Border.TopColor = Color.Black;
    ((ARControl) this.textGhAcctTypeDesc).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctTypeDesc).DataField = "AcctTypeDescription";
    ((ARControl) this.textGhAcctTypeDesc).Height = 3f / 16f;
    ((ARControl) this.textGhAcctTypeDesc).Left = 0.375f;
    ((ARControl) this.textGhAcctTypeDesc).Name = "textGhAcctTypeDesc";
    this.textGhAcctTypeDesc.Style = "font-weight: bold; font-size: 8pt; ";
    this.textGhAcctTypeDesc.Text = (string) null;
    ((ARControl) this.textGhAcctTypeDesc).Top = 0.0f;
    ((ARControl) this.textGhAcctTypeDesc).Width = 3.625f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDesc).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.textBox8,
      (ARControl) this.textGfAcctTypeDescTotal
    });
    this.gfAcctTypeDesc.Height = 5f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDesc).Name = "gfAcctTypeDesc";
    ((ARControl) this.textBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.RightColor = Color.Black;
    ((ARControl) this.textBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.TopColor = Color.Black;
    ((ARControl) this.textBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox8).DataField = "Total";
    ((ARControl) this.textBox8).Height = 0.1979167f;
    ((ARControl) this.textBox8).Left = 3f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = resourceManager.GetString("textBox8.OutputFormat");
    this.textBox8.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.textBox8.SummaryGroup = "ghAcctTypeDesc";
    this.textBox8.SummaryRunning = (SummaryRunning) 1;
    this.textBox8.SummaryType = (SummaryType) 3;
    this.textBox8.Text = (string) null;
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 1f;
    ((ARControl) this.textGfAcctTypeDescTotal).Border.BottomColor = Color.Black;
    ((ARControl) this.textGfAcctTypeDescTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGfAcctTypeDescTotal).Border.LeftColor = Color.Black;
    ((ARControl) this.textGfAcctTypeDescTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGfAcctTypeDescTotal).Border.RightColor = Color.Black;
    ((ARControl) this.textGfAcctTypeDescTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGfAcctTypeDescTotal).Border.TopColor = Color.Black;
    ((ARControl) this.textGfAcctTypeDescTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGfAcctTypeDescTotal).Height = 3f / 16f;
    ((ARControl) this.textGfAcctTypeDescTotal).Left = 1f / 16f;
    ((ARControl) this.textGfAcctTypeDescTotal).Name = "textGfAcctTypeDescTotal";
    this.textGfAcctTypeDescTotal.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.textGfAcctTypeDescTotal.Text = (string) null;
    ((ARControl) this.textGfAcctTypeDescTotal).Top = 0.0f;
    ((ARControl) this.textGfAcctTypeDescTotal).Width = 2.75f;
    this.reportHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Name = "reportHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.textBox6,
      (ARControl) this.textBox7
    });
    this.reportFooter1.Height = 0.4479167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Name = "reportFooter1";
    ((ARControl) this.textBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.RightColor = Color.Black;
    ((ARControl) this.textBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.TopColor = Color.Black;
    ((ARControl) this.textBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Height = 3f / 16f;
    ((ARControl) this.textBox6).Left = 1f / 16f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.textBox6.Text = "NET INCOME (LOSS)";
    ((ARControl) this.textBox6).Top = 3f / 16f;
    ((ARControl) this.textBox6).Width = 2.75f;
    ((ARControl) this.textBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox7).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.textBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.RightColor = Color.Black;
    ((ARControl) this.textBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.TopColor = Color.Black;
    ((ARControl) this.textBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.textBox7).DataField = "Total";
    ((ARControl) this.textBox7).Height = 0.1979167f;
    ((ARControl) this.textBox7).Left = 3f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = resourceManager.GetString("textBox7.OutputFormat");
    this.textBox7.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.textBox7.SummaryRunning = (SummaryRunning) 2;
    this.textBox7.SummaryType = (SummaryType) 1;
    this.textBox7.Text = (string) null;
    ((ARControl) this.textBox7).Top = 3f / 16f;
    ((ARControl) this.textBox7).Width = 1f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 20f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClass);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDesc);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDesc);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClass);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.Maritime_IncomeStatement_ReportStart);
    ((ISupportInitialize) this.textPHOfficeName).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textPHIncomeStmtYear).EndInit();
    ((ISupportInitialize) this.textPHRunDate).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textGhAcctClass).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.textGfAcctClassTotal).EndInit();
    ((ISupportInitialize) this.textGhAcctTypeDesc).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textGfAcctTypeDescTotal).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private enum FontStyle
  {
    ReportHeader,
    ColumnHeader,
    SubTotal,
    GrandTotal,
    ReportContent,
    ClassHeader,
    SubTotalMoneyValue,
    GrandTotalMoneyValue,
  }
}
