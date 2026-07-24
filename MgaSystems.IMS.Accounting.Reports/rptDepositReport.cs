// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptDepositReport
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{71C2744F-08C6-4954-BAA2-216D2BA69116}", "Cash Deposit Summary", "Cash Deposit Summary Report.", "Accounting")]
public sealed class rptDepositReport : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{71C2744F-08C6-4954-BAA2-216D2BA69116}";
  private DataTable dtHeader;
  private DataTable dtDetail;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private int _BankAccountID;
  private DataView _dv;
  private DataTable _dt;
  private const int _reportFontSize = 10;
  private const int _reportHeaderFontSize = 13;
  private Workbook _wkb;
  private Worksheet _wks;
  private int _rowIndex;
  private Label lblHeader;
  private SubReport SubReport1;
  private TextBox txtOfficeLocation;

  public rptDepositReport()
  {
    this.ReportStart += new EventHandler(this.rptDisbursementReport_ReportStart);
    this._wkb = new Workbook();
    this._rowIndex = 0;
    this.InitializeComponent();
  }

  public rptDepositReport(int BankAccountID, DateTime DateFrom, DateTime DateTo)
  {
    this.ReportStart += new EventHandler(this.rptDisbursementReport_ReportStart);
    this._wkb = new Workbook();
    this._rowIndex = 0;
    this.InitializeComponent();
    this._dateFrom = DateFrom;
    this._dateTo = DateTo;
    this._BankAccountID = BankAccountID;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptDepositReport));
    this.Detail = new Detail();
    this.SubReport1 = new SubReport();
    this.ReportHeader = new ReportHeader();
    this.lblHeader = new Label();
    this.txtOfficeLocation = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.lblHeader).BeginInit();
    ((ISupportInitialize) this.txtOfficeLocation).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.SubReport1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.2597222f;
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
    ((ARControl) this.SubReport1).Size = new SizeF(10.5f, 0.25f);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblHeader,
      (ARControl) this.txtOfficeLocation
    });
    this.ReportHeader.Height = 0.4583333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.lblHeader).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader).Border.TopStyle = (BorderLineStyle) 0;
    this.lblHeader.Font = new Font("Tahoma", 11f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblHeader.HyperLink = (string) null;
    Label lblHeader = this.lblHeader;
    object obj2 = componentResourceManager.GetObject("lblHeader.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) lblHeader).Location = pointF2;
    ((ARControl) this.lblHeader).Name = "lblHeader";
    ((ARControl) this.lblHeader).Size = new SizeF(6.875f, 0.25f);
    this.lblHeader.Text = "Cash Deposits Report";
    ((ARControl) this.txtOfficeLocation).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOfficeLocation).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOfficeLocation).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOfficeLocation).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtOfficeLocation).DataField = "Location";
    this.txtOfficeLocation.DistinctField = (string) null;
    this.txtOfficeLocation.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtOfficeLocation = this.txtOfficeLocation;
    object obj3 = componentResourceManager.GetObject("txtOfficeLocation.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) txtOfficeLocation).Location = pointF3;
    ((ARControl) this.txtOfficeLocation).Name = "txtOfficeLocation";
    this.txtOfficeLocation.OutputFormat = (string) null;
    ((ARControl) this.txtOfficeLocation).Size = new SizeF(6.875f, 0.2f);
    this.txtOfficeLocation.Text = (string) null;
    this.ReportFooter.Height = 0.01041667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.25f;
    this.PageSettings.Margins.Right = 0.15f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 169f / 16f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.lblHeader).EndInit();
    ((ISupportInitialize) this.txtOfficeLocation).EndInit();
  }

  private void rptDisbursementReport_ReportStart(object sender, EventArgs e)
  {
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spFin_rptDepositReport", new SqlConnection(CurrentUser.Instance.ConnectionString));
    DataSet dataSet = new DataSet();
    try
    {
      SqlCommand selectCommand = sqlDataAdapter.SelectCommand;
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@dateFrom", (object) this._dateFrom);
      selectCommand.Parameters.AddWithValue("@dateTo", (object) this._dateTo);
      selectCommand.Parameters.AddWithValue("@bankAcctId", (object) this._BankAccountID);
      selectCommand.CommandTimeout = 90;
      sqlDataAdapter.Fill(dataSet);
    }
    finally
    {
      sqlDataAdapter.Dispose();
    }
    if (dataSet.Tables.Count != 0)
    {
      if (dataSet.Tables[0] != null)
      {
        this.DataSource = (object) dataSet.Tables[0];
        this.lblHeader.Text = $"Cash Deposits Report ({Strings.Format((object) this._dateFrom, "Short Date").ToString()}-{Strings.Format((object) this._dateTo, "Short Date").ToString()})";
      }
      if (dataSet.Tables[1] != null)
      {
        rptDepositReport_Detail depositReportDetail = new rptDepositReport_Detail();
        depositReportDetail.DataSource = (object) dataSet.Tables[1];
        this.SubReport1.Report = (SectionReport) depositReportDetail;
      }
    }
    this.ShowPageNumbers();
    this.dtHeader = dataSet.Tables[0];
    this._dv = new DataView(dataSet.Tables[1], "", "", DataViewRowState.CurrentRows);
    this._dt = this._dv.ToTable(false, "checkDate", "PayeeName", "void", "CheckNumber", "CheckAmt", "IncomeAmt", "ApAmt", "ArAmt", "UnAcctAmt", "ExchAmt", "ExpAmt", "TransferAmt");
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[2]
      {
        (BaseReportControl) new BankList("Bank"),
        null
      };
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[1] = (BaseReportControl) new DateRangePicker("Deposit Date", date1, date2, false);
      return getReportControls;
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    this._wks = this._wkb.Worksheets[0];
    this._wks.Name = "Deposit";
    this._wks.Cells.StandardWidth = 14.0;
    this.PrintColumnHeaders();
    this.PrintDetailLines();
    this.PrintReportHeader();
    this.AdjustColumnWidth();
    if (!SaveFileTo.Contains(".xlsx"))
      SaveFileTo = SaveFileTo.Replace(".xls", ".xlsx");
    this._wkb.Save(SaveFileTo, (SaveFormat) 6);
    Process.Start(SaveFileTo);
  }

  private void PrintColumnHeaders()
  {
    int num1 = 0;
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) this._dt.Columns)
      {
        Cell cell = this._wks.Cells[this._rowIndex, num1];
        cell.SetStyle(this.GetStyle(cell.GetStyle(), rptDepositReport.FontStyle.ColumnHeader));
        switch (num1)
        {
          case 0:
            cell.PutValue("Check Date");
            break;
          case 1:
            cell.PutValue("Payee");
            break;
          case 2:
            cell.PutValue("Void?");
            break;
          case 3:
            cell.PutValue("Check #");
            break;
          case 4:
            cell.PutValue("Check Amt.");
            break;
          case 5:
            cell.PutValue("Income Amt.");
            break;
          case 6:
            cell.PutValue("A/P Amt.");
            break;
          case 7:
            cell.PutValue("A/R Amt.");
            break;
          case 8:
            cell.PutValue("Un-Acct Amt.");
            break;
          case 9:
            cell.PutValue("Exch. Amt.");
            break;
          case 10:
            cell.PutValue("Exp. Amt.");
            break;
          case 11:
            cell.PutValue("Transfer Amt.");
            break;
        }
        checked { ++num1; }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num2 = checked (^(local = ref this._rowIndex) + 1);
    local = num2;
  }

  private void PrintDetailLines()
  {
    try
    {
      foreach (DataRow row in this._dt.Rows)
      {
        int num1 = checked (this._dt.Columns.Count - 1);
        int columnIndex = 0;
        while (columnIndex <= num1)
        {
          Cell cell = this._wks.Cells[this._rowIndex, columnIndex];
          switch (columnIndex)
          {
            case 0:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptDepositReport.FontStyle.DetailDateValue));
              break;
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptDepositReport.FontStyle.DetailMoneyValue));
              break;
            default:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptDepositReport.FontStyle.DetailPlain));
              break;
          }
          cell.PutValue(RuntimeHelpers.GetObjectValue(row[columnIndex]));
          checked { ++columnIndex; }
        }
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num2 = checked (^(local = ref this._rowIndex) + 1);
        local = num2;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void PrintReportHeader()
  {
    this._wks.Cells.InsertRow(0);
    this._wks.Cells.InsertRow(0);
    Cell cell1 = this._wks.Cells[0, 0];
    cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptDepositReport.FontStyle.ReportHeader));
    cell1.PutValue(this.dtHeader.Rows[0]["BankName"].ToString());
    this._wks.Cells.InsertRow(0);
    Cell cell2 = this._wks.Cells[0, 0];
    cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptDepositReport.FontStyle.ReportHeader));
    cell2.PutValue(this.dtHeader.Rows[0]["ClientOfficeName"].ToString());
    this._wks.Cells.InsertRow(0);
    Cell cell3 = this._wks.Cells[0, 0];
    cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptDepositReport.FontStyle.ReportHeader));
    cell3.PutValue(this.lblHeader.Text);
  }

  private void AdjustColumnWidth() => this._wks.Cells.Columns[1].Width = 50.0;

  private Style GetStyle(Style style, rptDepositReport.FontStyle myFontStyle)
  {
    switch (myFontStyle)
    {
      case rptDepositReport.FontStyle.ColumnHeader:
        style.Font.IsBold = true;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        break;
      case rptDepositReport.FontStyle.DetailPlain:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.IsTextWrapped = true;
        break;
      case rptDepositReport.FontStyle.DetailMoneyValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 7;
        break;
      case rptDepositReport.FontStyle.DetailPctValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 9;
        break;
      case rptDepositReport.FontStyle.DetailDateValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 14;
        break;
      case rptDepositReport.FontStyle.ReportHeader:
        style.Font.IsBold = true;
        style.Font.Size = 13;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        break;
      case rptDepositReport.FontStyle.ReportHeaderWrapped:
        style.Font.IsBold = true;
        style.Font.Size = 13;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        style.IsTextWrapped = true;
        break;
    }
    return style;
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private enum FontStyle
  {
    ColumnHeader,
    DetailPlain,
    DetailMoneyValue,
    DetailPctValue,
    DetailDateValue,
    ReportHeader,
    ReportHeaderWrapped,
  }
}
