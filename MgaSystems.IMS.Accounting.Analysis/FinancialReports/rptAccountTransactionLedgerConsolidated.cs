// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.FinancialReports.rptAccountTransactionLedgerConsolidated
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using DDCssLib;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using System;
using System.ComponentModel;
using System.Data;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.FinancialReports;

public class rptAccountTransactionLedgerConsolidated : MGAReport
{
  private string _glCompanyIds;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private string _acctNums;
  private DataSet _ds = new DataSet();
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Label lblOfficeName;
  private Label label2;
  private Label lblDateRange;
  private ReportInfo reportInfo2;
  private ReportInfo reportInfo1;
  private GroupHeader groupHeader1;
  private Label labGH_GlName;
  private GroupFooter groupFooter1;
  private Label label5;
  private Label label6;
  private Label label7;
  private Label label8;
  private Label label9;
  private Label label10;
  private Label label11;
  private Label label12;
  private TextBox textBox1;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox txtDtl_Balance;
  private TextBox txtGF_Balance;
  private TextBox textBox10;
  private Line line1;
  private Line line2;
  private Label labGH_acctNum;
  private Label label1;
  private TextBox textBox11;
  private TextBox txtGH_BeginningBalance;

  public rptAccountTransactionLedgerConsolidated() => this.InitializeComponent();

  public rptAccountTransactionLedgerConsolidated(
    string GlCompanyIds,
    string AcctNums,
    DateTime dateFrom,
    DateTime dateTo)
  {
    this.InitializeComponent();
    this._glCompanyIds = GlCompanyIds;
    this._dateFrom = dateFrom;
    this._dateTo = dateTo;
    this._acctNums = AcctNums;
  }

  public override bool IsThreaded => true;

  private void pageHeader_Format(object sender, EventArgs e)
  {
    this.lblOfficeName.Text = this._ds.Tables[0].Rows[0]["Office"].ToString();
    Label lblDateRange = this.lblDateRange;
    DateTime dateTime = (DateTime) this._ds.Tables[0].Rows[0]["DateFrom"];
    string shortDateString1 = dateTime.ToShortDateString();
    dateTime = (DateTime) this._ds.Tables[0].Rows[0]["DateTo"];
    string shortDateString2 = dateTime.ToShortDateString();
    string str = $"{shortDateString1}-{shortDateString2}";
    lblDateRange.Text = str;
  }

  private void rptAccountTransactionLedgerConsolidated_ReportStart(object sender, EventArgs e)
  {
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_rptAccountTransactionLedgerConsolidated", new object[8]
    {
      (object) "@glCompanyIds",
      (object) this._glCompanyIds,
      (object) "@acctNums",
      (object) this._acctNums,
      (object) "@dFrom",
      (object) this._dateFrom,
      (object) "@dTo",
      (object) this._dateTo
    });
    this.DataSource = (object) this._ds.Tables[1];
  }

  private void groupHeader1_Format(object sender, EventArgs e)
  {
    this.labGH_GlName.Text = $"{this.labGH_acctNum.Text} {this.labGH_GlName.Text}";
  }

  private void detail_Format(object sender, EventArgs e)
  {
    this.txtDtl_Balance.Value = (object) (Convert.ToDecimal(this.txtDtl_Balance.Value) + Convert.ToDecimal(this.txtGH_BeginningBalance.Value));
  }

  private void groupFooter1_Format(object sender, EventArgs e)
  {
    this.txtGF_Balance.Value = (object) (Convert.ToDecimal(this.txtGF_Balance.Value) + Convert.ToDecimal(this.txtGH_BeginningBalance.Value));
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptAccountTransactionLedgerConsolidated));
    this.pageHeader = new PageHeader();
    this.lblOfficeName = new Label();
    this.label2 = new Label();
    this.lblDateRange = new Label();
    this.reportInfo2 = new ReportInfo();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.label11 = new Label();
    this.label12 = new Label();
    this.label1 = new Label();
    this.detail = new Detail();
    this.textBox1 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.txtDtl_Balance = new TextBox();
    this.textBox11 = new TextBox();
    this.pageFooter = new PageFooter();
    this.reportInfo1 = new ReportInfo();
    this.groupHeader1 = new GroupHeader();
    this.labGH_GlName = new Label();
    this.labGH_acctNum = new Label();
    this.txtGH_BeginningBalance = new TextBox();
    this.groupFooter1 = new GroupFooter();
    this.txtGF_Balance = new TextBox();
    this.textBox10 = new TextBox();
    this.line1 = new Line();
    this.line2 = new Line();
    ((ISupportInitialize) this.lblOfficeName).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.lblDateRange).BeginInit();
    ((ISupportInitialize) this.reportInfo2).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.label12).BeginInit();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.txtDtl_Balance).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.reportInfo1).BeginInit();
    ((ISupportInitialize) this.labGH_GlName).BeginInit();
    ((ISupportInitialize) this.labGH_acctNum).BeginInit();
    ((ISupportInitialize) this.txtGH_BeginningBalance).BeginInit();
    ((ISupportInitialize) this.txtGF_Balance).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.lblOfficeName,
      (ARControl) this.label2,
      (ARControl) this.lblDateRange,
      (ARControl) this.reportInfo2,
      (ARControl) this.label5,
      (ARControl) this.label6,
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label9,
      (ARControl) this.label10,
      (ARControl) this.label11,
      (ARControl) this.label12,
      (ARControl) this.label1
    });
    this.pageHeader.Height = 1.52875f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Name = "pageHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Format += new EventHandler(this.pageHeader_Format);
    ((ARControl) this.lblOfficeName).DataField = "Office";
    ((ARControl) this.lblOfficeName).Height = 0.467f;
    this.lblOfficeName.HyperLink = (string) null;
    ((ARControl) this.lblOfficeName).Left = 0.0f;
    ((ARControl) this.lblOfficeName).Name = "lblOfficeName";
    this.lblOfficeName.Style = "font-size: 12pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.lblOfficeName.Text = "";
    ((ARControl) this.lblOfficeName).Top = 0.083f;
    ((ARControl) this.lblOfficeName).Width = 10.4f;
    ((ARControl) this.label2).DataField = "Office";
    ((ARControl) this.label2).Height = 0.2f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 0.0f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-size: 12pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.label2.Text = "Transaction Detail by Account";
    ((ARControl) this.label2).Top = 0.55f;
    ((ARControl) this.label2).Width = 10.4f;
    ((ARControl) this.lblDateRange).DataField = "Office";
    ((ARControl) this.lblDateRange).Height = 0.2f;
    this.lblDateRange.HyperLink = (string) null;
    ((ARControl) this.lblDateRange).Left = 0.0f;
    ((ARControl) this.lblDateRange).Name = "lblDateRange";
    this.lblDateRange.Style = "font-size: 11pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.lblDateRange.Text = "1/1/2013-5/31/2013";
    ((ARControl) this.lblDateRange).Top = 0.75f;
    ((ARControl) this.lblDateRange).Width = 10.4f;
    this.reportInfo2.FormatString = "{RunDateTime:M/d/yyyy h:mm}";
    ((ARControl) this.reportInfo2).Height = 0.2f;
    ((ARControl) this.reportInfo2).Left = 0.0f;
    ((ARControl) this.reportInfo2).Name = "reportInfo2";
    this.reportInfo2.Style = "font-size: 8pt; font-weight: bold";
    ((ARControl) this.reportInfo2).Top = 0.95f;
    ((ARControl) this.reportInfo2).Width = 2.292f;
    ((ARControl) this.label5).Height = 0.2f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 0.167f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-size: 7pt; font-weight: bold; text-align: left; text-decoration: underline";
    this.label5.Text = "Type";
    ((ARControl) this.label5).Top = 1.327f;
    ((ARControl) this.label5).Width = 0.823f;
    ((ARControl) this.label6).Height = 0.2f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 0.9900001f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "font-size: 7pt; font-weight: bold; text-align: left; text-decoration: underline";
    this.label6.Text = "Date";
    ((ARControl) this.label6).Top = 1.327f;
    ((ARControl) this.label6).Width = 0.688f;
    ((ARControl) this.label7).Height = 0.2f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 1.678f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "font-size: 7pt; font-weight: bold; text-align: left; text-decoration: underline";
    this.label7.Text = "Trans. Num";
    ((ARControl) this.label7).Top = 1.327f;
    ((ARControl) this.label7).Width = 0.6139999f;
    ((ARControl) this.label8).Height = 0.2f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 2.906f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "font-size: 7pt; font-weight: bold; text-align: left; text-decoration: underline";
    this.label8.Text = "Name";
    ((ARControl) this.label8).Top = 1.327f;
    ((ARControl) this.label8).Width = 1.698f;
    ((ARControl) this.label9).Height = 0.2f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 4.604f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "font-size: 7pt; font-weight: bold; text-align: left; text-decoration: underline";
    this.label9.Text = "Memo";
    ((ARControl) this.label9).Top = 1.327f;
    ((ARControl) this.label9).Width = 2.015001f;
    ((ARControl) this.label10).Height = 0.2f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 6.619f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "font-size: 7pt; font-weight: bold; text-align: left; text-decoration: underline";
    this.label10.Text = "Class";
    ((ARControl) this.label10).Top = 1.327f;
    ((ARControl) this.label10).Width = 1.633999f;
    ((ARControl) this.label11).Height = 0.2f;
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Left = 8.253f;
    ((ARControl) this.label11).Name = "label11";
    this.label11.Style = "font-size: 7pt; font-weight: bold; text-align: right; text-decoration: underline";
    this.label11.Text = "Amount";
    ((ARControl) this.label11).Top = 1.327f;
    ((ARControl) this.label11).Width = 0.9689996f;
    ((ARControl) this.label12).Height = 0.2f;
    this.label12.HyperLink = (string) null;
    ((ARControl) this.label12).Left = 9.222f;
    ((ARControl) this.label12).Name = "label12";
    this.label12.Style = "font-size: 7pt; font-weight: bold; text-align: right; text-decoration: underline";
    this.label12.Text = "Balance";
    ((ARControl) this.label12).Top = 1.327f;
    ((ARControl) this.label12).Width = 1.178f;
    ((ARControl) this.label1).Height = 0.2f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 2.312f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-size: 7pt; font-weight: bold; text-align: left; text-decoration: underline";
    this.label1.Text = "Check Num";
    ((ARControl) this.label1).Top = 1.329f;
    ((ARControl) this.label1).Width = 0.614f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.textBox1,
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.txtDtl_Balance,
      (ARControl) this.textBox11
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.2187499f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Format += new EventHandler(this.detail_Format);
    ((ARControl) this.textBox1).DataField = "trantype";
    ((ARControl) this.textBox1).Height = 0.2f;
    ((ARControl) this.textBox1).Left = 0.167f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.Style = "font-size: 7pt";
    this.textBox1.Text = "textBox1";
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 0.823f;
    ((ARControl) this.textBox2).DataField = "transactnum";
    ((ARControl) this.textBox2).Height = 0.2f;
    ((ARControl) this.textBox2).Left = 1.678f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "font-size: 7pt";
    this.textBox2.Text = "textBox1";
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 0.6139999f;
    ((ARControl) this.textBox3).DataField = "name";
    ((ARControl) this.textBox3).Height = 0.2f;
    ((ARControl) this.textBox3).Left = 2.906f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "font-size: 7pt";
    this.textBox3.Text = "textBox1";
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 1.698f;
    ((ARControl) this.textBox4).DataField = "comment";
    ((ARControl) this.textBox4).Height = 0.2f;
    ((ARControl) this.textBox4).Left = 4.604f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Style = "font-size: 7pt";
    this.textBox4.Text = "textBox1";
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 2.015001f;
    ((ARControl) this.textBox5).DataField = "class";
    ((ARControl) this.textBox5).Height = 0.2f;
    ((ARControl) this.textBox5).Left = 6.619f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.Style = "font-size: 7pt";
    this.textBox5.Text = "textBox1";
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 1.633999f;
    ((ARControl) this.textBox6).DataField = "amount";
    ((ARControl) this.textBox6).Height = 0.2f;
    ((ARControl) this.textBox6).Left = 8.253f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = resourceManager.GetString("textBox6.OutputFormat");
    this.textBox6.Style = "font-size: 7pt; text-align: right";
    this.textBox6.Text = "textBox1";
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 0.9689999f;
    ((ARControl) this.textBox7).DataField = "date";
    ((ARControl) this.textBox7).Height = 0.2f;
    ((ARControl) this.textBox7).Left = 0.9900001f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = resourceManager.GetString("textBox7.OutputFormat");
    this.textBox7.Style = "font-size: 7pt";
    this.textBox7.Text = "textBox1";
    ((ARControl) this.textBox7).Top = 0.0f;
    ((ARControl) this.textBox7).Width = 0.688f;
    ((ARControl) this.txtDtl_Balance).DataField = "amount";
    ((ARControl) this.txtDtl_Balance).Height = 0.2f;
    ((ARControl) this.txtDtl_Balance).Left = 9.222f;
    ((ARControl) this.txtDtl_Balance).Name = "txtDtl_Balance";
    this.txtDtl_Balance.OutputFormat = resourceManager.GetString("txtDtl_Balance.OutputFormat");
    this.txtDtl_Balance.Style = "font-size: 7pt; text-align: right";
    this.txtDtl_Balance.SummaryGroup = "groupHeader1";
    this.txtDtl_Balance.SummaryRunning = (SummaryRunning) 2;
    this.txtDtl_Balance.SummaryType = (SummaryType) 3;
    this.txtDtl_Balance.Text = "textBox1";
    ((ARControl) this.txtDtl_Balance).Top = 0.0f;
    ((ARControl) this.txtDtl_Balance).Width = 1.178001f;
    ((ARControl) this.textBox11).DataField = "CheckNum";
    ((ARControl) this.textBox11).Height = 0.2f;
    ((ARControl) this.textBox11).Left = 2.292f;
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.Style = "font-size: 7pt";
    this.textBox11.Text = "textBox1";
    ((ARControl) this.textBox11).Top = 0.0f;
    ((ARControl) this.textBox11).Width = 0.614f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.reportInfo1
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Name = "pageFooter";
    this.reportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
    ((ARControl) this.reportInfo1).Height = 0.2f;
    ((ARControl) this.reportInfo1).Left = 8.182f;
    ((ARControl) this.reportInfo1).Name = "reportInfo1";
    this.reportInfo1.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    ((ARControl) this.reportInfo1).Top = 0.05f;
    ((ARControl) this.reportInfo1).Width = 2.218f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.labGH_GlName,
      (ARControl) this.labGH_acctNum,
      (ARControl) this.txtGH_BeginningBalance
    });
    this.groupHeader1.DataField = "acctNum";
    this.groupHeader1.Height = 0.2f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Name = "groupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Format += new EventHandler(this.groupHeader1_Format);
    ((ARControl) this.labGH_GlName).DataField = "glname";
    ((ARControl) this.labGH_GlName).Height = 0.169f;
    this.labGH_GlName.HyperLink = (string) null;
    ((ARControl) this.labGH_GlName).Left = 0.062f;
    ((ARControl) this.labGH_GlName).Name = "labGH_GlName";
    this.labGH_GlName.Style = "font-size: 8pt; font-weight: bold";
    this.labGH_GlName.Text = "label4";
    ((ARControl) this.labGH_GlName).Top = 0.0f;
    ((ARControl) this.labGH_GlName).Width = 7.938f;
    ((ARControl) this.labGH_acctNum).DataField = "acctNum";
    ((ARControl) this.labGH_acctNum).Height = 0.2f;
    this.labGH_acctNum.HyperLink = (string) null;
    ((ARControl) this.labGH_acctNum).Left = 8.275001f;
    ((ARControl) this.labGH_acctNum).Name = "labGH_acctNum";
    this.labGH_acctNum.Style = "background-color: Red";
    this.labGH_acctNum.Text = "";
    ((ARControl) this.labGH_acctNum).Top = 0.0f;
    ((ARControl) this.labGH_acctNum).Visible = false;
    ((ARControl) this.labGH_acctNum).Width = 0.3499994f;
    ((ARControl) this.txtGH_BeginningBalance).DataField = "BeginningBalance";
    ((ARControl) this.txtGH_BeginningBalance).Height = 0.2f;
    ((ARControl) this.txtGH_BeginningBalance).Left = 9.202001f;
    ((ARControl) this.txtGH_BeginningBalance).Name = "txtGH_BeginningBalance";
    this.txtGH_BeginningBalance.OutputFormat = resourceManager.GetString("txtGH_BeginningBalance.OutputFormat");
    this.txtGH_BeginningBalance.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGH_BeginningBalance.Text = "textBox1";
    ((ARControl) this.txtGH_BeginningBalance).Top = 0.0f;
    ((ARControl) this.txtGH_BeginningBalance).Width = 1.178001f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.txtGF_Balance,
      (ARControl) this.textBox10,
      (ARControl) this.line1,
      (ARControl) this.line2
    });
    this.groupFooter1.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Name = "groupFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Format += new EventHandler(this.groupFooter1_Format);
    ((ARControl) this.txtGF_Balance).DataField = "amount";
    ((ARControl) this.txtGF_Balance).Height = 0.2f;
    ((ARControl) this.txtGF_Balance).Left = 9.202001f;
    ((ARControl) this.txtGF_Balance).Name = "txtGF_Balance";
    this.txtGF_Balance.OutputFormat = resourceManager.GetString("txtGF_Balance.OutputFormat");
    this.txtGF_Balance.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.txtGF_Balance.SummaryGroup = "groupHeader1";
    this.txtGF_Balance.SummaryRunning = (SummaryRunning) 1;
    this.txtGF_Balance.SummaryType = (SummaryType) 3;
    this.txtGF_Balance.Text = "textBox1";
    ((ARControl) this.txtGF_Balance).Top = 0.0f;
    ((ARControl) this.txtGF_Balance).Width = 1.198001f;
    ((ARControl) this.textBox10).DataField = "amount";
    ((ARControl) this.textBox10).Height = 0.2f;
    ((ARControl) this.textBox10).Left = 8.004001f;
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.OutputFormat = resourceManager.GetString("textBox10.OutputFormat");
    this.textBox10.Style = "font-size: 7pt; font-weight: bold; text-align: right";
    this.textBox10.SummaryGroup = "groupHeader1";
    this.textBox10.SummaryRunning = (SummaryRunning) 1;
    this.textBox10.SummaryType = (SummaryType) 3;
    this.textBox10.Text = "textBox1";
    ((ARControl) this.textBox10).Top = 0.0f;
    ((ARControl) this.textBox10).Width = 1.198001f;
    ((ARControl) this.line1).Height = 0.0f;
    ((ARControl) this.line1).Left = 8.004001f;
    this.line1.LineWeight = 1f;
    ((ARControl) this.line1).Name = "line1";
    ((ARControl) this.line1).Top = 0.0f;
    ((ARControl) this.line1).Width = 1.198f;
    this.line1.X1 = 8.004001f;
    this.line1.X2 = 9.202001f;
    this.line1.Y1 = 0.0f;
    this.line1.Y2 = 0.0f;
    ((ARControl) this.line2).Height = 0.0f;
    ((ARControl) this.line2).Left = 9.275001f;
    this.line2.LineWeight = 1f;
    ((ARControl) this.line2).Name = "line2";
    ((ARControl) this.line2).Top = 0.0f;
    ((ARControl) this.line2).Width = 1.124999f;
    this.line2.X1 = 9.275001f;
    this.line2.X2 = 10.4f;
    this.line2.Y1 = 0.0f;
    this.line2.Y2 = 0.0f;
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.rptAccountTransactionLedgerConsolidated_ReportStart);
    ((ISupportInitialize) this.lblOfficeName).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.lblDateRange).EndInit();
    ((ISupportInitialize) this.reportInfo2).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.label12).EndInit();
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.txtDtl_Balance).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.reportInfo1).EndInit();
    ((ISupportInitialize) this.labGH_GlName).EndInit();
    ((ISupportInitialize) this.labGH_acctNum).EndInit();
    ((ISupportInitialize) this.txtGH_BeginningBalance).EndInit();
    ((ISupportInitialize) this.txtGF_Balance).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
