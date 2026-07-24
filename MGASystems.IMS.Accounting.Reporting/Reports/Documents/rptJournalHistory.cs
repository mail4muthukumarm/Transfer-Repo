// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Reports.Documents.rptJournalHistory
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting.Reports.Documents;

[SecureReportResource("{61399DE7-E14D-40F5-8E84-80A44EDFD717}", "Journal History Report", "Journal History Report", "Accounting")]
public class rptJournalHistory : MGAReport, IReport
{
  private int _GLCompanyId;
  private DateTime _PostDateStartRange;
  private DateTime _PostDateEndRange;
  private string _TransactionType;
  private int _LastTransactionNum = -1;
  private DataSet _ds;
  private Detail detail;
  private GroupHeader ghTransaction;
  private GroupFooter gfTransaction;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private TextBox currentDebit;
  private TextBox currentCredit;
  private TextBox txtTransactionNum;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox;
  private TextBox TextBox4;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label1;
  private Label Label2;
  private Label Label;
  private Label Label7;
  private Line Line;
  private Line Line1;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private Label Label9;
  private TextBox txtDate;
  private Line Line3;
  private Line Line4;
  private TextBox TextBox12;
  private TextBox TextBox13;
  private Label Label8;
  private TextBox txtClientOfficeName;
  private Label label10;

  public rptJournalHistory() => this.InitializeComponent();

  public rptJournalHistory(
    int GLAccountId,
    DateTime PostDateStartRange,
    DateTime PostDateEndRange,
    string TransactionType)
  {
    this.InitializeComponent();
    this._GLCompanyId = GLAccountId;
    this._PostDateStartRange = PostDateStartRange;
    this._PostDateEndRange = PostDateEndRange;
    this._TransactionType = TransactionType;
  }

  Type IReport.getLaunchForm => (Type) null;

  BaseReportControl[] IReport.getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new AccountingOfficeLocations("GL Company:", false, true),
        (BaseReportControl) new DateRangePicker("Post Date:", false),
        (BaseReportControl) new GenericListBox("Transaction Type(s):", "Select TransDescription as Display, TransDescId as Value from tblFin_TransactionTypes order by TransDescription", "Value", "Display", true, typeof (string), true, false, 400)
      };
    }
  }

  private void rptJournalHistory_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_rptJournalHistory", new object[8]
    {
      (object) "@GLCompanyId",
      (object) this._GLCompanyId,
      (object) "@PostDateStartRange",
      (object) this._PostDateStartRange,
      (object) "@PostDateEndRange",
      (object) this._PostDateEndRange,
      (object) "@TransactionType",
      (object) this._TransactionType
    });
    this.DataSource = (object) this._ds.Tables[0];
    if (this._ds.Tables[0].Rows.Count > 0)
      this.txtDate.Text = Convert.ToDateTime(this._ds.Tables[0].Rows[0]["postDate"]).ToString("MM/dd/yyyy");
    if (this._ds.Tables[1].Rows.Count <= 0)
      return;
    this.txtClientOfficeName.Text = this._ds.Tables[1].Rows[0]["ClientOfficeName"].ToString();
  }

  private void detail_BeforePrint(object sender, EventArgs e)
  {
    if (this._LastTransactionNum == Convert.ToInt32(this.txtTransactionNum.Value))
      this.txtTransactionNum.Text = "";
    this._LastTransactionNum = Convert.ToInt32(this.txtTransactionNum.Value);
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    DataTable dataTable = new DataTable();
    ExcelExport.ToExcel(this._ds.Tables[0].Copy(), SaveFileTo);
    Process.Start(SaveFileTo);
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptJournalHistory));
    this.detail = new Detail();
    this.currentDebit = new TextBox();
    this.currentCredit = new TextBox();
    this.txtTransactionNum = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox = new TextBox();
    this.TextBox4 = new TextBox();
    this.ghTransaction = new GroupHeader();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label = new Label();
    this.Label7 = new Label();
    this.gfTransaction = new GroupFooter();
    this.Line = new Line();
    this.Line1 = new Line();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.reportHeader1 = new ReportHeader();
    this.Label9 = new Label();
    this.txtDate = new TextBox();
    this.txtClientOfficeName = new TextBox();
    this.reportFooter1 = new ReportFooter();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.Label8 = new Label();
    this.label10 = new Label();
    ((ISupportInitialize) this.currentDebit).BeginInit();
    ((ISupportInitialize) this.currentCredit).BeginInit();
    ((ISupportInitialize) this.txtTransactionNum).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtDate).BeginInit();
    ((ISupportInitialize) this.txtClientOfficeName).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.currentDebit,
      (ARControl) this.currentCredit,
      (ARControl) this.txtTransactionNum,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox4
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.1354166f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).BeforePrint += new EventHandler(this.detail_BeforePrint);
    ((ARControl) this.currentDebit).DataField = "Debit";
    ((ARControl) this.currentDebit).Height = 0.125f;
    ((ARControl) this.currentDebit).Left = 8.625f;
    ((ARControl) this.currentDebit).Name = "currentDebit";
    this.currentDebit.OutputFormat = resourceManager.GetString("currentDebit.OutputFormat");
    this.currentDebit.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.currentDebit.Text = " ";
    ((ARControl) this.currentDebit).Top = 0.0f;
    ((ARControl) this.currentDebit).Width = 15f / 16f;
    ((ARControl) this.currentCredit).DataField = "Credit";
    ((ARControl) this.currentCredit).Height = 0.125f;
    ((ARControl) this.currentCredit).Left = 9.625f;
    ((ARControl) this.currentCredit).Name = "currentCredit";
    this.currentCredit.OutputFormat = resourceManager.GetString("currentCredit.OutputFormat");
    this.currentCredit.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.currentCredit.Text = " ";
    ((ARControl) this.currentCredit).Top = 0.0f;
    ((ARControl) this.currentCredit).Width = 0.75f;
    ((ARControl) this.txtTransactionNum).DataField = "transactnum";
    ((ARControl) this.txtTransactionNum).Height = 0.125f;
    ((ARControl) this.txtTransactionNum).Left = 0.0f;
    ((ARControl) this.txtTransactionNum).Name = "txtTransactionNum";
    this.txtTransactionNum.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtTransactionNum.Text = " ";
    ((ARControl) this.txtTransactionNum).Top = 0.0f;
    ((ARControl) this.txtTransactionNum).Width = 0.5f;
    ((ARControl) this.TextBox1).DataField = "comments";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 2.187f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 35f / 16f;
    ((ARControl) this.TextBox2).DataField = "fullname";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 4.437f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 2.25f;
    ((ARControl) this.TextBox3).DataField = "classname";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 6.75f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 29f / 16f;
    ((ARControl) this.TextBox).DataField = "policynum";
    ((ARControl) this.TextBox).Height = 0.125f;
    ((ARControl) this.TextBox).Left = 0.562f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 15f / 16f;
    ((ARControl) this.TextBox4).DataField = "invoicenum";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 1.562f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.563f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransaction).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label,
      (ARControl) this.Label7
    });
    this.ghTransaction.DataField = "transactnum";
    this.ghTransaction.Height = 0.2604166f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransaction).Name = "ghTransaction";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 2.187f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label3.Text = "Memo";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 35f / 16f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 8.625f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 9pt; text-align: right; vertical-align: bottom";
    this.Label4.Text = "Debits";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 15f / 16f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 9.625f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 9pt; text-align: right; vertical-align: bottom";
    this.Label5.Text = "Credits";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 0.75f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 4.437f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label6.Text = "Account";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 2.25f;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 6.75f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label1.Text = "Class";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 29f / 16f;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.0f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label2.Text = "Trans #";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 0.5f;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.562f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label.Text = "Policy #";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = 15f / 16f;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 1.562f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label7.Text = "Invoice #";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 0.563f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTransaction).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Line,
      (ARControl) this.Line1,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.label10
    });
    this.gfTransaction.Height = 0.3229166f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTransaction).Name = "gfTransaction";
    ((ARControl) this.Line).Height = 0.0f;
    ((ARControl) this.Line).Left = 8.562f;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    ((ARControl) this.Line).Top = 0.0f;
    ((ARControl) this.Line).Width = 1f;
    this.Line.X1 = 8.562f;
    this.Line.X2 = 9.562f;
    this.Line.Y1 = 0.0f;
    this.Line.Y2 = 0.0f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 9.6245f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 0.0f;
    ((ARControl) this.Line1).Width = 0.75f;
    this.Line1.X1 = 9.6245f;
    this.Line1.X2 = 10.3745f;
    this.Line1.Y1 = 0.0f;
    this.Line1.Y2 = 0.0f;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "Debit";
    ((ARControl) this.TextBox8).Height = 11f / 64f;
    ((ARControl) this.TextBox8).Left = 8.562f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.TextBox8.SummaryGroup = "ghTransaction";
    this.TextBox8.SummaryRunning = (SummaryRunning) 1;
    this.TextBox8.SummaryType = (SummaryType) 3;
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 1f / 16f;
    ((ARControl) this.TextBox8).Width = 1f;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).DataField = "Credit";
    ((ARControl) this.TextBox9).Height = 11f / 64f;
    ((ARControl) this.TextBox9).Left = 9.6245f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.TextBox9.SummaryGroup = "ghTransaction";
    this.TextBox9.SummaryRunning = (SummaryRunning) 1;
    this.TextBox9.SummaryType = (SummaryType) 3;
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox9).Top = 1f / 16f;
    ((ARControl) this.TextBox9).Width = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label9,
      (ARControl) this.txtDate,
      (ARControl) this.txtClientOfficeName
    });
    this.reportHeader1.Height = 0.8229165f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Name = "reportHeader1";
    ((ARControl) this.Label9).Height = 0.25f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.0f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 14pt; font-weight: bold; text-align: center";
    this.Label9.Text = "General Journal History";
    ((ARControl) this.Label9).Top = 0.0f;
    ((ARControl) this.Label9).Width = 10.375f;
    ((ARControl) this.txtDate).Height = 3f / 16f;
    ((ARControl) this.txtDate).Left = 0.0f;
    ((ARControl) this.txtDate).Name = "txtDate";
    this.txtDate.Style = "text-align: center; ddo-char-set: 0";
    this.txtDate.Text = (string) null;
    ((ARControl) this.txtDate).Top = 0.5f;
    ((ARControl) this.txtDate).Width = 10.375f;
    ((ARControl) this.txtClientOfficeName).Height = 0.25f;
    ((ARControl) this.txtClientOfficeName).Left = 0.0f;
    ((ARControl) this.txtClientOfficeName).Name = "txtClientOfficeName";
    this.txtClientOfficeName.Style = "font-size: 12pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.txtClientOfficeName.Text = (string) null;
    ((ARControl) this.txtClientOfficeName).Top = 0.25f;
    ((ARControl) this.txtClientOfficeName).Width = 10.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.Label8
    });
    this.reportFooter1.Height = 9f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Name = "reportFooter1";
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 137f / 16f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 0.25f;
    ((ARControl) this.Line3).Width = 1f;
    this.Line3.X1 = 137f / 16f;
    this.Line3.X2 = 153f / 16f;
    this.Line3.Y1 = 0.25f;
    this.Line3.Y2 = 0.25f;
    ((ARControl) this.Line4).Height = 0.0f;
    ((ARControl) this.Line4).Left = 9.625f;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    ((ARControl) this.Line4).Top = 0.25f;
    ((ARControl) this.Line4).Width = 0.75f;
    this.Line4.X1 = 9.625f;
    this.Line4.X2 = 10.375f;
    this.Line4.Y1 = 0.25f;
    this.Line4.Y2 = 0.25f;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox12).DataField = "Debit";
    ((ARControl) this.TextBox12).Height = 11f / 64f;
    ((ARControl) this.TextBox12).Left = 137f / 16f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.TextBox12.SummaryRunning = (SummaryRunning) 2;
    this.TextBox12.SummaryType = (SummaryType) 1;
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 1f / 32f;
    ((ARControl) this.TextBox12).Width = 1f;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox13).DataField = "Credit";
    ((ARControl) this.TextBox13).Height = 11f / 64f;
    ((ARControl) this.TextBox13).Left = 9.625f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.TextBox13.SummaryRunning = (SummaryRunning) 2;
    this.TextBox13.SummaryType = (SummaryType) 1;
    this.TextBox13.Text = " ";
    ((ARControl) this.TextBox13).Top = 1f / 32f;
    ((ARControl) this.TextBox13).Width = 0.75f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.0f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 9pt; font-weight: bold";
    this.Label8.Text = "TOTAL";
    ((ARControl) this.Label8).Top = 1f / 32f;
    ((ARControl) this.Label8).Width = 9f / 16f;
    ((ARControl) this.label10).Height = 0.2f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 7.562f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "";
    this.label10.Text = "Subtotal";
    ((ARControl) this.label10).Top = 0.0f;
    ((ARControl) this.label10).Width = 1f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransaction);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTransaction);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.rptJournalHistory_ReportStart);
    ((ISupportInitialize) this.currentDebit).EndInit();
    ((ISupportInitialize) this.currentCredit).EndInit();
    ((ISupportInitialize) this.txtTransactionNum).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtDate).EndInit();
    ((ISupportInitialize) this.txtClientOfficeName).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
