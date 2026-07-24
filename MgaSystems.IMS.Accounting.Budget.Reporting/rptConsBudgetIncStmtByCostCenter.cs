// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Budget.Reporting.rptConsBudgetIncStmtByCostCenter
// Assembly: MGASystems.IMS.Accounting.Budget.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2F70404E-A856-4350-950F-177768D5941D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Budget.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Budget.Reporting;

[SecureReportResource("{C181C866-1775-45B6-A7F6-9C4287A451BF}", "Consolidated Budget Income Statement by Cost Center", "Consolidated Budget Income Statement by Cost Center", "Budget")]
public class rptConsBudgetIncStmtByCostCenter : MGAExcelReport, IReport
{
  private const int reportFontSize = 8;
  private const int headerFontSize = 12;
  private string _glCompanyids;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private dsBudgetIncomeStatementByCostCenter _data;
  private DataSet _ds;
  private Detail detail;

  public rptConsBudgetIncStmtByCostCenter() => this.InitializeComponent();

  public rptConsBudgetIncStmtByCostCenter(string glCompanyIds, DateTime dateFrom, DateTime dateTo)
  {
    this.InitializeComponent();
    this._glCompanyids = glCompanyIds;
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
        (BaseReportControl) new GenericListBox("Office", "Select Location as Display, OfficeID as Value From tblClientOffices Order BY Location", "Value", "Display", true, typeof (int), true, false, 250),
        (BaseReportControl) new DateRangePicker("Date Range", false)
      };
    }
  }

  public override bool HasRecords => this._data.Tables[0].Rows.Count > 0;

  private dsBudgetIncomeStatementByCostCenter GetData()
  {
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_rptConsBudgetIncStmtByCostCenter", new object[6]
    {
      (object) "@GLCompanyIds",
      (object) this._glCompanyids,
      (object) "@DateFrom",
      (object) this._dateFrom,
      (object) "@DateTo",
      (object) this._dateTo
    });
    return this.TransformData(this._ds);
  }

  private dsBudgetIncomeStatementByCostCenter TransformData(DataSet ds)
  {
    dsBudgetIncomeStatementByCostCenter statementByCostCenter = new dsBudgetIncomeStatementByCostCenter();
    foreach (DataRow row in (InternalDataCollectionBase) ds.Tables[1].Rows)
    {
      if (!statementByCostCenter.IncomeStatement.Columns.Contains(row["CostCenter"].ToString()))
        statementByCostCenter.IncomeStatement.Columns.Add(row["CostCenter"].ToString(), typeof (Decimal));
    }
    foreach (DataRow row1 in (InternalDataCollectionBase) ds.Tables[0].DefaultView.ToTable(true, "FullName", "GLAcctId", "AcctClassName", "AcctTypeDescription").Rows)
    {
      DataRow dataRow = statementByCostCenter.Tables[0].Rows.Add(row1["GLAcctId"], row1["FullName"], row1["AcctClassName"], row1["AcctTypeDescription"], ds.Tables[0].Compute("SUM(Amount)", $"GLAcctId = {row1["GLAcctId"]}"));
      foreach (DataRow row2 in (InternalDataCollectionBase) ds.Tables[1].Rows)
        dataRow[row2["CostCenter"].ToString()] = ds.Tables[0].Compute("SUM(Amount)", $"GLAcctId = {row1["GLAcctId"]} AND CostCenter = '{row2["CostCenter"]}'");
    }
    return statementByCostCenter;
  }

  private void rptConsBudgetIncStmtByCostCenter_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.HidePrintDateAndTime();
    this._data = this.GetData();
  }

  protected override void DoExport(string excelFileName)
  {
    Workbook wkb = new Workbook((FileFormatType) 6);
    this.CreateWorkbookHeaders(wkb);
    wkb.Save(excelFileName);
  }

  private Style GetStyle(
    Style style,
    rptConsBudgetIncStmtByCostCenter.FontStyle fontStyle)
  {
    switch (fontStyle)
    {
      case rptConsBudgetIncStmtByCostCenter.FontStyle.ReportHeader:
        style.Font.IsBold = true;
        style.Font.Size = 12;
        style.Font.Name = "Arial";
        break;
      case rptConsBudgetIncStmtByCostCenter.FontStyle.ColumnHeader:
        style.Font.IsBold = false;
        style.Font.Underline = (FontUnderlineType) 4;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptConsBudgetIncStmtByCostCenter.FontStyle.SubTotal:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptConsBudgetIncStmtByCostCenter.FontStyle.GrandTotal:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptConsBudgetIncStmtByCostCenter.FontStyle.ReportContent:
        style.Font.IsBold = false;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptConsBudgetIncStmtByCostCenter.FontStyle.ClassHeader:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        break;
      case rptConsBudgetIncStmtByCostCenter.FontStyle.SubTotalMoneyValue:
        style.Font.IsBold = true;
        style.Font.Size = 8;
        style.Font.Name = "Arial";
        style.Number = 44;
        style.Borders[(BorderType) 4].Color = Color.Black;
        style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
        break;
      case rptConsBudgetIncStmtByCostCenter.FontStyle.GrandTotalMoneyValue:
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
    worksheet.Name = "Cons Bdgt Inc Stmt By CC";
    Cell cell1 = worksheet.Cells["A1"];
    cell1.PutValue("Consolidated Budget Income Statement By Cost Center");
    cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.ReportHeader));
    Cell cell2 = worksheet.Cells["A2"];
    cell2.PutValue(this._ds.Tables[2].Rows[0]["ClientOfficeNames"]);
    cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.GrandTotal));
    Cell cell3 = worksheet.Cells["C2"];
    cell3.PutValue(this._ds.Tables[2].Rows[0]["IncomeStatementYear"]);
    cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.GrandTotal));
    Cell cell4 = worksheet.Cells["E2"];
    cell4.PutValue(this._ds.Tables[2].Rows[0]["RunDate"]);
    cell4.SetStyle(this.GetStyle(cell4.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.GrandTotal));
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
      cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.ClassHeader));
      cell1.PutValue(row[0].ToString());
      ++num1;
      int num4 = num3 + 1;
      DataRow[] dataRowArray1 = table2.Select($"AcctClass = '{row[0].ToString()}'");
      for (int index1 = 0; index1 <= dataRowArray1.Length; ++index1)
      {
        if (index1 == dataRowArray1.Length)
        {
          Cell cell2 = wks.Cells[num1, num4];
          cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.GrandTotal));
          cell2.PutValue("Total " + row[0].ToString());
          int num5 = 5;
          for (int index2 = 4; index2 < this._data.Tables[0].Columns.Count; ++index2)
          {
            Cell cell3 = wks.Cells[num1, num5];
            cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.GrandTotalMoneyValue));
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
        cell4.SetStyle(this.GetStyle(cell4.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.ClassHeader));
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
            cell5.SetStyle(this.GetStyle(cell5.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.SubTotal));
            cell5.PutValue("Total " + dataRowArray1[index1][1].ToString());
            int num7 = 5;
            for (int index4 = 4; index4 < this._data.Tables[0].Columns.Count; ++index4)
            {
              Cell cell6 = wks.Cells[num1, num7];
              cell6.SetStyle(this.GetStyle(cell6.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.SubTotalMoneyValue));
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
          cell7.SetStyle(this.GetStyle(cell7.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.ReportContent));
          cell7.PutValue(dataRowArray2[index3]["FullName"].ToString());
          int num8 = 5;
          for (int columnIndex = 4; columnIndex < this._data.Tables[0].Columns.Count; ++columnIndex)
          {
            Cell cell8 = wks.Cells[num1, num8];
            cell8.SetStyle(this.GetStyle(cell8.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.ReportContent));
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
    cell9.SetStyle(this.GetStyle(cell9.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.GrandTotal));
    cell9.PutValue("NET INCOME/LOSS");
    int num10 = 5;
    for (int index = 4; index < this._data.Tables[0].Columns.Count; ++index)
    {
      Cell cell10 = wks.Cells[num1, num10];
      cell10.SetStyle(this.GetStyle(cell10.GetStyle(), rptConsBudgetIncStmtByCostCenter.FontStyle.SubTotalMoneyValue));
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
    ResourceManager resourceManager = new ResourceManager(typeof (rptConsBudgetIncStmtByCostCenter));
    this.detail = new Detail();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.detail).Height = 0.0f;
    ((Section) this.detail).Name = "detail";
    ((Section) this.detail).Visible = false;
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.Sections.Add((Section) this.detail);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.rptConsBudgetIncStmtByCostCenter_ReportStart);
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
