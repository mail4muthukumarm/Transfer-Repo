// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptDisbursementReport
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
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
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{69AB7507-D758-4b74-953F-BF222F40CF77}", "Cash Disbursement Summary", "Cash Disbursement Summary Report.", "Accounting")]
public sealed class rptDisbursementReport : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{69AB7507-D758-4b74-953F-BF222F40CF77}";
  private DataTable dtHeader;
  private DataTable dtDetail;
  private int _bankGLAcctId;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private DataSet _ds;
  private Guid _entityGuid;
  private Label lblHeader;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private SubReport SubReport1;

  public rptDisbursementReport()
  {
    this.ReportStart += new EventHandler(this.rptDisbursementReport_ReportStart);
    this.ReportHeader = (ReportHeader) null;
    this.PageHeader = (PageHeader) null;
    this.Detail = (Detail) null;
    this.PageFooter = (PageFooter) null;
    this.ReportFooter = (ReportFooter) null;
    this.lblHeader = (Label) null;
    this.TextBox1 = (TextBox) null;
    this.TextBox2 = (TextBox) null;
    this.TextBox3 = (TextBox) null;
    this.Label1 = (Label) null;
    this.Label2 = (Label) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.Label5 = (Label) null;
    this.Label6 = (Label) null;
    this.Label7 = (Label) null;
    this.Label8 = (Label) null;
    this.Label9 = (Label) null;
    this.Label10 = (Label) null;
    this.Label11 = (Label) null;
    this.Label12 = (Label) null;
    this.Label13 = (Label) null;
    this.SubReport1 = (SubReport) null;
  }

  public rptDisbursementReport(
    int BankGLAcctId,
    DateTime DateFrom,
    DateTime DateTo,
    Guid EntityGuid)
  {
    this.ReportStart += new EventHandler(this.rptDisbursementReport_ReportStart);
    this.ReportHeader = (ReportHeader) null;
    this.PageHeader = (PageHeader) null;
    this.Detail = (Detail) null;
    this.PageFooter = (PageFooter) null;
    this.ReportFooter = (ReportFooter) null;
    this.lblHeader = (Label) null;
    this.TextBox1 = (TextBox) null;
    this.TextBox2 = (TextBox) null;
    this.TextBox3 = (TextBox) null;
    this.Label1 = (Label) null;
    this.Label2 = (Label) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.Label5 = (Label) null;
    this.Label6 = (Label) null;
    this.Label7 = (Label) null;
    this.Label8 = (Label) null;
    this.Label9 = (Label) null;
    this.Label10 = (Label) null;
    this.Label11 = (Label) null;
    this.Label12 = (Label) null;
    this.Label13 = (Label) null;
    this.SubReport1 = (SubReport) null;
    this.InitializeComponent();
    this._bankGLAcctId = BankGLAcctId;
    this._dateFrom = DateFrom;
    this._dateTo = DateTo;
    this._entityGuid = EntityGuid;
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptDisbursementReport));
    this.Detail = new Detail();
    this.SubReport1 = new SubReport();
    this.ReportHeader = new ReportHeader();
    this.lblHeader = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.lblHeader).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.SubReport1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    this.SubReport1.CloseBorder = false;
    ((ARControl) this.SubReport1).Height = 5f / 16f;
    ((ARControl) this.SubReport1).Left = 0.0f;
    ((ARControl) this.SubReport1).Name = "SubReport1";
    this.SubReport1.Report = (SectionReport) null;
    this.SubReport1.ReportName = "DetailReport";
    ((ARControl) this.SubReport1).Top = 0.0f;
    ((ARControl) this.SubReport1).Width = 10.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.lblHeader,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3
    });
    this.ReportHeader.Height = 0.9479167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.lblHeader).Height = 0.25f;
    this.lblHeader.HyperLink = (string) null;
    ((ARControl) this.lblHeader).Left = 0.0f;
    ((ARControl) this.lblHeader).Name = "lblHeader";
    this.lblHeader.Style = "font-family: Tahoma; font-size: 11pt; font-weight: bold; ddo-char-set: 0";
    this.lblHeader.Text = "Cash Disbursement Report";
    ((ARControl) this.lblHeader).Top = 0.0f;
    ((ARControl) this.lblHeader).Width = 6.875f;
    ((ARControl) this.TextBox1).DataField = "bankName";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0";
    this.TextBox1.Text = "TextBox1";
    ((ARControl) this.TextBox1).Top = 5f / 16f;
    ((ARControl) this.TextBox1).Width = 6.875f;
    ((ARControl) this.TextBox2).DataField = "bankAddress";
    ((ARControl) this.TextBox2).Height = 0.2025f;
    ((ARControl) this.TextBox2).Left = 0.0f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0";
    this.TextBox2.Text = "TextBox2";
    ((ARControl) this.TextBox2).Top = 0.5f;
    ((ARControl) this.TextBox2).Width = 6.875f;
    ((ARControl) this.TextBox3).DataField = "Location";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 7f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-weight: bold; text-align: right; ddo-char-set: 0";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 3.375f;
    this.ReportFooter.Height = 0.01041667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13
    });
    this.PageHeader.Height = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label1).Height = 0.188f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 0";
    this.Label1.Text = "Check Date";
    ((ARControl) this.Label1).Top = 3f / 16f;
    ((ARControl) this.Label1).Width = 0.74f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.74f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 0";
    this.Label2.Text = "Payee";
    ((ARControl) this.Label2).Top = 3f / 16f;
    ((ARControl) this.Label2).Width = 35f / 16f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 2.9275f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.Label3.Text = "Void?";
    ((ARControl) this.Label3).Top = 3f / 16f;
    ((ARControl) this.Label3).Width = 0.375f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 3.3025f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 0";
    this.Label4.Text = "Check #";
    ((ARControl) this.Label4).Top = 3f / 16f;
    ((ARControl) this.Label4).Width = 0.625f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 3.8025f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label5.Text = "Check Amt.";
    ((ARControl) this.Label5).Top = 3f / 16f;
    ((ARControl) this.Label5).Width = 15f / 16f;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 4.740001f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label6.Text = "Income Amt.";
    ((ARControl) this.Label6).Top = 3f / 16f;
    ((ARControl) this.Label6).Width = 13f / 16f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 5.552501f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label7.Text = "A/P Amt.";
    ((ARControl) this.Label7).Top = 3f / 16f;
    ((ARControl) this.Label7).Width = 13f / 16f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 6.365f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label8.Text = "A/R Amt.";
    ((ARControl) this.Label8).Top = 3f / 16f;
    ((ARControl) this.Label8).Width = 0.75f;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 7.115f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "background-color: WhiteSmoke; font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label9.Text = "Un-Acct Amt.";
    ((ARControl) this.Label9).Top = 3f / 16f;
    ((ARControl) this.Label9).Width = 13f / 16f;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 7.9275f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "background-color: WhiteSmoke; font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label10.Text = "Exch. Amt.";
    ((ARControl) this.Label10).Top = 3f / 16f;
    ((ARControl) this.Label10).Width = 13f / 16f;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 8.74f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "background-color: WhiteSmoke; font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label11.Text = "Exp. Amt.";
    ((ARControl) this.Label11).Top = 3f / 16f;
    ((ARControl) this.Label11).Width = 0.75f;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 9.49f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "background-color: WhiteSmoke; font-size: 8pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label12.Text = "Other Amt.";
    ((ARControl) this.Label12).Top = 3f / 16f;
    ((ARControl) this.Label12).Width = 0.875f;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 7.115f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "background-color: WhiteSmoke; font-size: 8pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.Label13.Text = "OTHER";
    ((ARControl) this.Label13).Top = 0.0f;
    ((ARControl) this.Label13).Width = 3.25f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.lblHeader).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptDisbursementReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("spFin_rptDisbursementReport", new SqlConnection(CurrentUser.Instance.ConnectionString));
    this._ds = new DataSet();
    try
    {
      SqlCommand selectCommand = sqlDataAdapter.SelectCommand;
      selectCommand.CommandTimeout = 0;
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@bankAcctId", (object) this._bankGLAcctId);
      selectCommand.Parameters.AddWithValue("@dateFrom", (object) this._dateFrom);
      selectCommand.Parameters.AddWithValue("@dateTo", (object) this._dateTo);
      if (!(this._entityGuid == Guid.Empty))
        selectCommand.Parameters.AddWithValue("@entityGuid", (object) this._entityGuid);
      sqlDataAdapter.Fill(this._ds);
      if (this._ds.Tables[1].Rows.Count == 0)
        return;
    }
    finally
    {
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
    if (this._ds.Tables.Count == 0)
      return;
    if (this._ds.Tables[0] != null)
    {
      this.DataSource = (object) this._ds.Tables[0];
      this.lblHeader.Text = $"Cash Disbursements Summary Report ({Strings.Format((object) this._dateFrom, "Short Date").ToString()}-{Strings.Format((object) this._dateTo, "Short Date").ToString()})";
    }
    if (this._ds.Tables[1] == null)
      return;
    this.SubReport1.Report = (SectionReport) new rptDisbursementReport_Detail(this._ds.Tables[1]);
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[1] == null)
      return;
    this.SubReport1.Report = (SectionReport) new rptDisbursementReport_Detail(this._ds.Tables[1]);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[3]
      {
        (BaseReportControl) new BankList("Bank Account"),
        null,
        null
      };
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[1] = (BaseReportControl) new DateRangePicker("Check Date", date1, date2, false);
      getReportControls[2] = (BaseReportControl) new EntitySelection("Entity", false);
      return getReportControls;
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    Workbook workbook = new Workbook();
    workbook.Worksheets.Clear();
    Worksheet worksheet = workbook.Worksheets.Add("Cash Disbursement Summary");
    worksheet.Cells["A5"].PutValue("Check Date");
    worksheet.Cells["B5"].PutValue("Check #");
    worksheet.Cells["D5"].PutValue("Claim #");
    worksheet.Cells["C5"].PutValue("Policy #");
    worksheet.Cells["E5"].PutValue("Payee");
    worksheet.Cells["F5"].PutValue("Void");
    worksheet.Cells["G5"].PutValue("Check Amt.");
    worksheet.Cells["H5"].PutValue("Income Amt.");
    worksheet.Cells["I5"].PutValue("A/P Amt.");
    worksheet.Cells["J5"].PutValue("A/R Amt.");
    worksheet.Cells["K5"].PutValue("Un-Acct Amt.");
    worksheet.Cells["L5"].PutValue("Exch. Amt.");
    worksheet.Cells["M5"].PutValue("Exp. Amt.");
    worksheet.Cells["N5"].PutValue("Transfer Amt.");
    worksheet.Cells["O5"].PutValue("Loss Date");
    worksheet.Cells["P5"].PutValue("Insured");
    Style style = worksheet.Cells[0, 0].GetStyle();
    StyleFlag styleFlag = new StyleFlag();
    styleFlag.All = true;
    Font font = style.Font;
    font.Color = Color.Black;
    font.IsBold = true;
    font.IsItalic = false;
    style.Borders[(BorderType) 8].Color = Color.Black;
    style.Borders[(BorderType) 4].Color = Color.Black;
    style.Borders[(BorderType) 1].Color = Color.Black;
    style.Borders[(BorderType) 2].Color = Color.Black;
    style.Borders[(BorderType) 8].LineStyle = (CellBorderType) 1;
    style.Borders[(BorderType) 4].LineStyle = (CellBorderType) 1;
    style.Borders[(BorderType) 1].LineStyle = (CellBorderType) 1;
    style.Borders[(BorderType) 2].LineStyle = (CellBorderType) 1;
    worksheet.Cells.CreateRange("A5:P5").ApplyStyle(style, styleFlag);
    worksheet.Cells.ImportDataTable(this._ds.Tables[1], false, 5, 0);
    worksheet.AutoFitColumns();
    worksheet.Cells["A1"].PutValue("Bank Name:");
    worksheet.Cells["A2"].PutValue("Bank Address:");
    worksheet.Cells["A3"].PutValue("Location:");
    worksheet.Cells["B1"].PutValue(RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[0]["BankName"]));
    worksheet.Cells["B2"].PutValue(RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[0]["BankAddress"]));
    worksheet.Cells["B3"].PutValue(RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[0]["Location"]));
    workbook.Save(SaveFileTo, (SaveFormat) 6);
    Process.Start(SaveFileTo);
  }
}
