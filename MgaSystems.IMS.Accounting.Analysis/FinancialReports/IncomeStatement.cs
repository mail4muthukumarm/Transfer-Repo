// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.FinancialReports.IncomeStatement
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.FinancialReports;

[SecureReportResource("{2A051D8F-88EF-4555-BFE1-C1D68AEB3920}", "Consolidated Income Statement", "Consolidated income statement.", "Financials")]
public class IncomeStatement : MGAReport, IReport
{
  private readonly string _companyIDs;
  private readonly string _comparisonType;
  private readonly DateTime _dateFrom;
  private readonly DateTime _priorTo;
  private TextBox _textCostCenter;
  private TextBox _orderMaster;
  private DataTable _dt;
  private DataSet _ds;
  private string _acctNums;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private ReportHeader ReportHeader;
  private PageHeader PageHeader;
  private GroupHeader ghAcctClassName;
  private GroupHeader ghAcctTypeDescription;
  private GroupHeader ghFullName;
  private Detail Detail;
  private GroupFooter gfFullName;
  private GroupFooter gfAcctTypeDescription;
  private GroupFooter gfAcctClassName;
  private PageFooter PageFooter;
  private ReportFooter ReportFooter;
  private Label Label9;
  private TextBox txtDate;
  private Label lblBucket1;
  private Label lblBucket2;
  private Label lblBucket3;
  private TextBox txtAcctClassName;
  private TextBox txtAcctTypeDescription;
  private TextBox AcctTypeID;
  private TextBox TextBox2;
  private TextBox txtBucket1_AcctTypeDescription_Total;
  private TextBox txtBucket2_AcctTypeDescription_Total;
  private TextBox txtBucket3_AcctTypeDescription_Total;
  private TextBox TextBox;
  private TextBox TextBox6;
  private TextBox txtBucket1_AcctClassName_Total;
  private TextBox txtBucket2_AcctClassName_Total;
  private TextBox txtBucket3_AcctClassName_Total;
  private Line Line;
  private Line Line1;
  private Line Line2;
  private TextBox TextBox1;
  private TextBox txtTotAmount;
  private TextBox txtTotCompareAmount;
  private TextBox txtTotChangeAmount;
  private Line Line3;
  private Line Line4;
  private Line Line5;
  private TextBox TextBox8;
  private TextBox txtCompany;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox txtFullName;
  private TextBox txtDtl_AcctNum;

  public IncomeStatement() => this.InitializeComponent();

  public IncomeStatement(
    string companyIDs,
    string comparisonType,
    DateTime dateFrom,
    DateTime priorTo)
  {
    this.InitializeComponent();
    this._companyIDs = companyIDs;
    this._comparisonType = comparisonType;
    this._dateFrom = dateFrom;
    this._priorTo = priorTo;
  }

  private void IncomeStatement_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    ArrayList arrayList = new ArrayList();
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@GlCompanyIDs",
      (object) this._companyIDs
    });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@ComparisonType",
      (object) this._comparisonType
    });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@DateFrom",
      (object) this._dateFrom
    });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@PriorTo",
      (object) this._priorTo
    });
    this._ds = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, "dbo.spFin_ConsolidatedIncomeStatement", 0, (CommandArgumentType) 0, arrayList.ToArray());
    this._dt = this._ds.Tables[0];
    DataRowCollection rows = this._dt.Rows;
    if ((rows != null ? (rows.Count > 0 ? 1 : 0) : 0) == 0)
      return;
    DateTime dateTime;
    if (this._comparisonType == "M")
    {
      this.lblBucket1.Text = this._priorTo.ToString("MM/dd/yyyy");
      Label lblBucket2 = this.lblBucket2;
      dateTime = (DateTime) this._dt.Rows[0]["CompareDate"];
      string str = dateTime.ToString("MM/dd/yyyy");
      lblBucket2.Text = str;
    }
    else
    {
      this.lblBucket1.Text = this._priorTo.ToString("MM/dd/yyyy");
      Label lblBucket2 = this.lblBucket2;
      dateTime = (DateTime) this._dt.Rows[0]["CompareDate"];
      string str = dateTime.ToString("MM/dd/yyyy");
      lblBucket2.Text = str;
    }
    this.txtCompany.Text = DefaultDatabase.ExecuteScalar(CommandType.Text, "Select dbo.GetOfficeLocationNames(@glcompanyids)", new object[2]
    {
      (object) "@glcompanyids",
      (object) this._companyIDs
    }).ToString();
    TextBox txtDate = this.txtDate;
    string text = this.txtDate.Text;
    dateTime = this._dateFrom;
    string str1 = dateTime.ToString("MM/dd/yyyy");
    dateTime = this._priorTo;
    string str2 = dateTime.ToString("MM/dd/yyyy");
    string str3 = string.Format(text, (object) str1, (object) str2);
    txtDate.Text = str3;
    this._textCostCenter.Text = "All Cost Centers";
    this.DataSource = (object) this._dt;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName).Format += new EventHandler(this.GfFullName_Format);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).BeforePrint += new EventHandler(this.GhAcctClassName_BeforePrint);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).BeforePrint += new EventHandler(this.GfAcctTypeDescription_BeforePrint);
  }

  private void GfFullName_Format(object sender, EventArgs e)
  {
  }

  private void GhAcctClassName_BeforePrint(object sender, EventArgs e)
  {
  }

  private void GfAcctTypeDescription_BeforePrint(object sender, EventArgs e)
  {
  }

  private void ReportFooter_BeforePrint(object sender, EventArgs e)
  {
    if (!string.IsNullOrEmpty(this._dt.Compute("SUM(Amount)", "OrderMaster = 1").ToString()) && !string.IsNullOrEmpty(this._dt.Compute("SUM(Amount)", "OrderMaster = 2").ToString()))
      this.txtTotAmount.Value = (object) (Convert.ToDecimal(this._dt.Compute("SUM(Amount)", "OrderMaster = 1")) - Convert.ToDecimal(this._dt.Compute("SUM(Amount)", "OrderMaster = 2")));
    if (!string.IsNullOrEmpty(this._dt.Compute("SUM(CompareAmount)", "OrderMaster = 1").ToString()) && !string.IsNullOrEmpty(this._dt.Compute("SUM(CompareAmount)", "OrderMaster = 2").ToString()))
      this.txtTotCompareAmount.Value = (object) (Convert.ToDecimal(this._dt.Compute("SUM(CompareAmount)", "OrderMaster = 1")) - Convert.ToDecimal(this._dt.Compute("SUM(CompareAmount)", "OrderMaster = 2")));
    if (string.IsNullOrEmpty(this._dt.Compute("SUM(ChangeAmount)", "OrderMaster = 1").ToString()) || string.IsNullOrEmpty(this._dt.Compute("SUM(ChangeAmount)", "OrderMaster = 2").ToString()))
      return;
    this.txtTotChangeAmount.Value = (object) (Convert.ToDecimal(this._dt.Compute("SUM(ChangeAmount)", "OrderMaster = 1")) - Convert.ToDecimal(this._dt.Compute("SUM(ChangeAmount)", "OrderMaster = 2")));
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(this.txtDtl_AcctNum.Text) || !(this.txtDtl_AcctNum.Text != "9999999"))
      return;
    this.txtFullName.HyperLink = this.txtDtl_AcctNum.Text;
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (!(this.txtDtl_AcctNum.Text == "9999999"))
      return;
    this.txtDtl_AcctNum.Text = "";
  }

  public override bool IsThreaded => true;

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    this._acctNums = Convert.ToString(e.HyperLink);
    rptAccountTransactionLedgerConsolidated rpt = new rptAccountTransactionLedgerConsolidated(this._companyIDs, this._acctNums, this._dateFrom, this._priorTo);
    rpt.Run();
    rpt.Document.Name = $"Account Transaction Ledger - {e.HyperLink}";
    ReportFactory.Instance.ShowReport((SectionReport) rpt);
  }

  public override void ExportToExcel(string saveFileTo)
  {
    ExcelExport.ToExcel(this._dt, saveFileTo);
  }

  Type IReport.getLaunchForm => (Type) null;

  BaseReportControl[] IReport.getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[4]
      {
        (BaseReportControl) new GenericListBox("Office Locations", $"spFin_GetOfficeLocations @userguid='{CurrentUser.Instance.UserGUID.ToString()}'", "ID", "Office Location", false, typeof (int), false, false, 300),
        (BaseReportControl) new RadioSelection("Comparison", "Monthly", (object) "M", "Yearly", (object) "Y", RadioSelection.ButtonLayout.Vertical),
        null,
        null
      };
      DateTime now1 = DateTime.Now;
      int year1 = now1.Year;
      now1 = DateTime.Now;
      int month1 = now1.Month;
      getReportControls[2] = (BaseReportControl) new DatePicker("Date From", new DateTime(year1, month1, 1), false);
      DateTime InitialDate;
      if (DateTime.Now.Month != 12)
      {
        DateTime dateTime = DateTime.Now;
        int year2 = dateTime.Year;
        dateTime = DateTime.Now;
        int month2 = dateTime.Month + 1;
        dateTime = new DateTime(year2, month2, 1);
        InitialDate = dateTime.AddDays(-1.0);
      }
      else
      {
        DateTime now2 = DateTime.Now;
        int year3 = now2.Year;
        now2 = DateTime.Now;
        int month3 = now2.Month;
        InitialDate = new DateTime(year3, month3, 31 /*0x1F*/);
      }
      getReportControls[3] = (BaseReportControl) new DatePicker("Date To", InitialDate, false);
      return getReportControls;
    }
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (IncomeStatement));
    this.Detail = new Detail();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.txtFullName = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.Label9 = new Label();
    this.txtDate = new TextBox();
    this._textCostCenter = new TextBox();
    this.txtCompany = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.txtTotAmount = new TextBox();
    this.txtTotCompareAmount = new TextBox();
    this.txtTotChangeAmount = new TextBox();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.Line5 = new Line();
    this.TextBox8 = new TextBox();
    this.PageHeader = new PageHeader();
    this.lblBucket1 = new Label();
    this.lblBucket2 = new Label();
    this.lblBucket3 = new Label();
    this.PageFooter = new PageFooter();
    this.ghAcctClassName = new GroupHeader();
    this.txtAcctClassName = new TextBox();
    this._orderMaster = new TextBox();
    this.gfAcctClassName = new GroupFooter();
    this.TextBox6 = new TextBox();
    this.txtBucket1_AcctClassName_Total = new TextBox();
    this.txtBucket2_AcctClassName_Total = new TextBox();
    this.txtBucket3_AcctClassName_Total = new TextBox();
    this.Line = new Line();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.TextBox1 = new TextBox();
    this.ghAcctTypeDescription = new GroupHeader();
    this.txtAcctTypeDescription = new TextBox();
    this.AcctTypeID = new TextBox();
    this.gfAcctTypeDescription = new GroupFooter();
    this.TextBox2 = new TextBox();
    this.txtBucket1_AcctTypeDescription_Total = new TextBox();
    this.txtBucket2_AcctTypeDescription_Total = new TextBox();
    this.txtBucket3_AcctTypeDescription_Total = new TextBox();
    this.TextBox = new TextBox();
    this.ghFullName = new GroupHeader();
    this.gfFullName = new GroupFooter();
    this.txtDtl_AcctNum = new TextBox();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.txtFullName).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtDate).BeginInit();
    ((ISupportInitialize) this._textCostCenter).BeginInit();
    ((ISupportInitialize) this.txtCompany).BeginInit();
    ((ISupportInitialize) this.txtTotAmount).BeginInit();
    ((ISupportInitialize) this.txtTotCompareAmount).BeginInit();
    ((ISupportInitialize) this.txtTotChangeAmount).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.lblBucket1).BeginInit();
    ((ISupportInitialize) this.lblBucket2).BeginInit();
    ((ISupportInitialize) this.lblBucket3).BeginInit();
    ((ISupportInitialize) this.txtAcctClassName).BeginInit();
    ((ISupportInitialize) this._orderMaster).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.txtBucket1_AcctClassName_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket2_AcctClassName_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket3_AcctClassName_Total).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).BeginInit();
    ((ISupportInitialize) this.AcctTypeID).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.txtBucket1_AcctTypeDescription_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket2_AcctTypeDescription_Total).BeginInit();
    ((ISupportInitialize) this.txtBucket3_AcctTypeDescription_Total).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.txtDtl_AcctNum).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.txtFullName,
      (ARControl) this.txtDtl_AcctNum
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1354166f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Format += new EventHandler(this.Detail_Format);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).BeforePrint += new EventHandler(this.Detail_BeforePrint);
    ((ARControl) this.textBox3).DataField = "Amount";
    ((ARControl) this.textBox3).Height = 0.125f;
    ((ARControl) this.textBox3).Left = 4.625f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.OutputFormat = resourceManager.GetString("textBox3.OutputFormat");
    this.textBox3.Style = "font-size: 8pt; text-align: right";
    this.textBox3.Text = " ";
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 1.875f;
    ((ARControl) this.textBox4).DataField = "CompareAmount";
    ((ARControl) this.textBox4).Height = 0.125f;
    ((ARControl) this.textBox4).Left = 105f / 16f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.OutputFormat = resourceManager.GetString("textBox4.OutputFormat");
    this.textBox4.Style = "font-size: 8pt; text-align: right";
    this.textBox4.Text = " ";
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 1.875f;
    ((ARControl) this.textBox5).DataField = "ChangeAmount";
    ((ARControl) this.textBox5).Height = 0.125f;
    ((ARControl) this.textBox5).Left = 8.5f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = resourceManager.GetString("textBox5.OutputFormat");
    this.textBox5.Style = "font-size: 8pt; text-align: right";
    this.textBox5.Text = " ";
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 1.875f;
    ((ARControl) this.txtFullName).DataField = "FullName";
    ((ARControl) this.txtFullName).Height = 0.125f;
    ((ARControl) this.txtFullName).Left = 0.5f;
    ((ARControl) this.txtFullName).Name = "txtFullName";
    this.txtFullName.Style = "font-size: 8pt; font-weight: bold";
    this.txtFullName.Text = (string) null;
    ((ARControl) this.txtFullName).Top = 0.0f;
    ((ARControl) this.txtFullName).Width = 4.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label9,
      (ARControl) this.txtDate,
      (ARControl) this._textCostCenter,
      (ARControl) this.txtCompany
    });
    this.ReportHeader.Height = 1.135417f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label9).Height = 0.25f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.0f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 14pt; font-weight: bold; text-align: center";
    this.Label9.Text = "Income Statement";
    ((ARControl) this.Label9).Top = 0.437f;
    ((ARControl) this.Label9).Width = 10.375f;
    ((ARControl) this.txtDate).Height = 3f / 16f;
    ((ARControl) this.txtDate).Left = 0.0f;
    ((ARControl) this.txtDate).Name = "txtDate";
    this.txtDate.Style = "text-align: center; ddo-char-set: 0";
    this.txtDate.Text = "{0} - {1}";
    ((ARControl) this.txtDate).Top = 0.687f;
    ((ARControl) this.txtDate).Width = 10.375f;
    ((ARControl) this._textCostCenter).Height = 3f / 16f;
    ((ARControl) this._textCostCenter).Left = 0.0f;
    ((ARControl) this._textCostCenter).Name = "textCostCenter";
    this._textCostCenter.Style = "text-align: center; ddo-char-set: 0";
    this._textCostCenter.Text = (string) null;
    ((ARControl) this._textCostCenter).Top = 0.8745f;
    ((ARControl) this._textCostCenter).Width = 10.375f;
    ((ARControl) this.txtCompany).Height = 0.25f;
    ((ARControl) this.txtCompany).Left = 0.0f;
    ((ARControl) this.txtCompany).Name = "txtCompany";
    this.txtCompany.Style = "font-size: 12pt; font-weight: bold; text-align: center";
    this.txtCompany.Text = (string) null;
    ((ARControl) this.txtCompany).Top = 0.0f;
    ((ARControl) this.txtCompany).Width = 10.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.txtTotAmount,
      (ARControl) this.txtTotCompareAmount,
      (ARControl) this.txtTotChangeAmount,
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.Line5,
      (ARControl) this.TextBox8
    });
    this.ReportFooter.Height = 0.5506945f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).BeforePrint += new EventHandler(this.ReportFooter_BeforePrint);
    ((ARControl) this.txtTotAmount).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotAmount).Height = 3f / 16f;
    ((ARControl) this.txtTotAmount).Left = 4.625f;
    ((ARControl) this.txtTotAmount).Name = "txtTotAmount";
    this.txtTotAmount.OutputFormat = resourceManager.GetString("txtTotAmount.OutputFormat");
    this.txtTotAmount.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.txtTotAmount.SummaryRunning = (SummaryRunning) 2;
    this.txtTotAmount.SummaryType = (SummaryType) 1;
    this.txtTotAmount.Text = " ";
    ((ARControl) this.txtTotAmount).Top = 5f / 16f;
    ((ARControl) this.txtTotAmount).Width = 1.875f;
    ((ARControl) this.txtTotCompareAmount).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotCompareAmount).Height = 3f / 16f;
    ((ARControl) this.txtTotCompareAmount).Left = 105f / 16f;
    ((ARControl) this.txtTotCompareAmount).Name = "txtTotCompareAmount";
    this.txtTotCompareAmount.OutputFormat = resourceManager.GetString("txtTotCompareAmount.OutputFormat");
    this.txtTotCompareAmount.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.txtTotCompareAmount.SummaryRunning = (SummaryRunning) 2;
    this.txtTotCompareAmount.SummaryType = (SummaryType) 1;
    this.txtTotCompareAmount.Text = " ";
    ((ARControl) this.txtTotCompareAmount).Top = 5f / 16f;
    ((ARControl) this.txtTotCompareAmount).Width = 1.875f;
    ((ARControl) this.txtTotChangeAmount).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtTotChangeAmount).Height = 3f / 16f;
    ((ARControl) this.txtTotChangeAmount).Left = 8.5f;
    ((ARControl) this.txtTotChangeAmount).Name = "txtTotChangeAmount";
    this.txtTotChangeAmount.OutputFormat = resourceManager.GetString("txtTotChangeAmount.OutputFormat");
    this.txtTotChangeAmount.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.txtTotChangeAmount.SummaryRunning = (SummaryRunning) 2;
    this.txtTotChangeAmount.SummaryType = (SummaryType) 1;
    this.txtTotChangeAmount.Text = " ";
    ((ARControl) this.txtTotChangeAmount).Top = 5f / 16f;
    ((ARControl) this.txtTotChangeAmount).Width = 1.875f;
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 4.625f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 17f / 32f;
    ((ARControl) this.Line3).Width = 1.875f;
    this.Line3.X1 = 4.625f;
    this.Line3.X2 = 6.5f;
    this.Line3.Y1 = 17f / 32f;
    this.Line3.Y2 = 17f / 32f;
    ((ARControl) this.Line4).Height = 0.0f;
    ((ARControl) this.Line4).Left = 105f / 16f;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    ((ARControl) this.Line4).Top = 17f / 32f;
    ((ARControl) this.Line4).Width = 1.875f;
    this.Line4.X1 = 105f / 16f;
    this.Line4.X2 = 135f / 16f;
    this.Line4.Y1 = 17f / 32f;
    this.Line4.Y2 = 17f / 32f;
    ((ARControl) this.Line5).Height = 0.0f;
    ((ARControl) this.Line5).Left = 8.5f;
    this.Line5.LineWeight = 1f;
    ((ARControl) this.Line5).Name = "Line5";
    ((ARControl) this.Line5).Top = 17f / 32f;
    ((ARControl) this.Line5).Width = 1.875f;
    this.Line5.X1 = 8.5f;
    this.Line5.X2 = 10.375f;
    this.Line5.Y1 = 17f / 32f;
    this.Line5.Y2 = 17f / 32f;
    ((ARControl) this.TextBox8).Height = 0.25f;
    ((ARControl) this.TextBox8).Left = 0.0f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-size: 11.25pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.TextBox8.Text = "Profit / (Loss)";
    ((ARControl) this.TextBox8).Top = 0.25f;
    ((ARControl) this.TextBox8).Width = 1.875f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblBucket1,
      (ARControl) this.lblBucket2,
      (ARControl) this.lblBucket3
    });
    this.PageHeader.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.lblBucket1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBucket1).Height = 3f / 16f;
    this.lblBucket1.HyperLink = (string) null;
    ((ARControl) this.lblBucket1).Left = 4.625f;
    ((ARControl) this.lblBucket1).Name = "lblBucket1";
    this.lblBucket1.Style = "font-size: 8pt; font-weight: bold; text-align: center";
    this.lblBucket1.Text = " ";
    ((ARControl) this.lblBucket1).Top = 0.0f;
    ((ARControl) this.lblBucket1).Width = 1.875f;
    ((ARControl) this.lblBucket2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBucket2).Height = 3f / 16f;
    this.lblBucket2.HyperLink = (string) null;
    ((ARControl) this.lblBucket2).Left = 105f / 16f;
    ((ARControl) this.lblBucket2).Name = "lblBucket2";
    this.lblBucket2.Style = "font-size: 8pt; font-weight: bold; text-align: center";
    this.lblBucket2.Text = " ";
    ((ARControl) this.lblBucket2).Top = 0.0f;
    ((ARControl) this.lblBucket2).Width = 1.875f;
    ((ARControl) this.lblBucket3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblBucket3).Height = 3f / 16f;
    this.lblBucket3.HyperLink = (string) null;
    ((ARControl) this.lblBucket3).Left = 8.5f;
    ((ARControl) this.lblBucket3).Name = "lblBucket3";
    this.lblBucket3.Style = "font-size: 8pt; font-weight: bold; text-align: center";
    this.lblBucket3.Text = " $ Change";
    ((ARControl) this.lblBucket3).Top = 0.0f;
    ((ARControl) this.lblBucket3).Width = 1.875f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtAcctClassName,
      (ARControl) this._orderMaster
    });
    this.ghAcctClassName.DataField = "OrderMaster";
    this.ghAcctClassName.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).Name = "ghAcctClassName";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName).BeforePrint += new EventHandler(this.GhAcctClassName_BeforePrint);
    ((ARControl) this.txtAcctClassName).DataField = "AcctClassName";
    ((ARControl) this.txtAcctClassName).Height = 0.125f;
    ((ARControl) this.txtAcctClassName).Left = 0.0f;
    ((ARControl) this.txtAcctClassName).Name = "txtAcctClassName";
    this.txtAcctClassName.Style = "font-size: 8pt; font-weight: bold";
    this.txtAcctClassName.Text = (string) null;
    ((ARControl) this.txtAcctClassName).Top = 0.0f;
    ((ARControl) this.txtAcctClassName).Width = 4.625f;
    ((ARControl) this._orderMaster).DataField = "OrderMaster";
    ((ARControl) this._orderMaster).Height = 1f / 16f;
    ((ARControl) this._orderMaster).Left = 0.0f;
    ((ARControl) this._orderMaster).Name = "OrderMaster";
    this._orderMaster.Style = "background-color: Yellow; font-size: 1pt";
    this._orderMaster.Text = (string) null;
    ((ARControl) this._orderMaster).Top = 0.0f;
    ((ARControl) this._orderMaster).Visible = false;
    ((ARControl) this._orderMaster).Width = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassName).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.TextBox6,
      (ARControl) this.txtBucket1_AcctClassName_Total,
      (ARControl) this.txtBucket2_AcctClassName_Total,
      (ARControl) this.txtBucket3_AcctClassName_Total,
      (ARControl) this.Line,
      (ARControl) this.Line1,
      (ARControl) this.Line2,
      (ARControl) this.TextBox1
    });
    this.gfAcctClassName.Height = 7f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassName).Name = "gfAcctClassName";
    ((ARControl) this.TextBox6).DataField = "AcctClassName";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 7f / 16f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 67f / 16f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtBucket1_AcctClassName_Total).DataField = "Amount";
    ((ARControl) this.txtBucket1_AcctClassName_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Left = 4.625f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Name = "txtBucket1_AcctClassName_Total";
    this.txtBucket1_AcctClassName_Total.OutputFormat = resourceManager.GetString("txtBucket1_AcctClassName_Total.OutputFormat");
    this.txtBucket1_AcctClassName_Total.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.txtBucket1_AcctClassName_Total.SummaryGroup = "ghAcctClassName";
    this.txtBucket1_AcctClassName_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket1_AcctClassName_Total.SummaryType = (SummaryType) 3;
    this.txtBucket1_AcctClassName_Total.Text = " ";
    ((ARControl) this.txtBucket1_AcctClassName_Total).Top = 0.0f;
    ((ARControl) this.txtBucket1_AcctClassName_Total).Width = 1.875f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtBucket2_AcctClassName_Total).DataField = "CompareAmount";
    ((ARControl) this.txtBucket2_AcctClassName_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Left = 105f / 16f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Name = "txtBucket2_AcctClassName_Total";
    this.txtBucket2_AcctClassName_Total.OutputFormat = resourceManager.GetString("txtBucket2_AcctClassName_Total.OutputFormat");
    this.txtBucket2_AcctClassName_Total.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.txtBucket2_AcctClassName_Total.SummaryGroup = "ghAcctClassName";
    this.txtBucket2_AcctClassName_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket2_AcctClassName_Total.SummaryType = (SummaryType) 3;
    this.txtBucket2_AcctClassName_Total.Text = " ";
    ((ARControl) this.txtBucket2_AcctClassName_Total).Top = 0.0f;
    ((ARControl) this.txtBucket2_AcctClassName_Total).Width = 1.875f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.txtBucket3_AcctClassName_Total).DataField = "ChangeAmount";
    ((ARControl) this.txtBucket3_AcctClassName_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Left = 8.5f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Name = "txtBucket3_AcctClassName_Total";
    this.txtBucket3_AcctClassName_Total.OutputFormat = resourceManager.GetString("txtBucket3_AcctClassName_Total.OutputFormat");
    this.txtBucket3_AcctClassName_Total.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.txtBucket3_AcctClassName_Total.SummaryGroup = "ghAcctClassName";
    this.txtBucket3_AcctClassName_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket3_AcctClassName_Total.SummaryType = (SummaryType) 3;
    this.txtBucket3_AcctClassName_Total.Text = " ";
    ((ARControl) this.txtBucket3_AcctClassName_Total).Top = 0.0f;
    ((ARControl) this.txtBucket3_AcctClassName_Total).Width = 1.875f;
    ((ARControl) this.Line).Height = 0.0f;
    ((ARControl) this.Line).Left = 4.625f;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    ((ARControl) this.Line).Top = 7f / 32f;
    ((ARControl) this.Line).Width = 1.875f;
    this.Line.X1 = 4.625f;
    this.Line.X2 = 6.5f;
    this.Line.Y1 = 7f / 32f;
    this.Line.Y2 = 7f / 32f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 105f / 16f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 7f / 32f;
    ((ARControl) this.Line1).Width = 1.875f;
    this.Line1.X1 = 105f / 16f;
    this.Line1.X2 = 135f / 16f;
    this.Line1.Y1 = 7f / 32f;
    this.Line1.Y2 = 7f / 32f;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 8.5f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 7f / 32f;
    ((ARControl) this.Line2).Width = 1.875f;
    this.Line2.X1 = 8.5f;
    this.Line2.X2 = 10.375f;
    this.Line2.Y1 = 7f / 32f;
    this.Line2.Y2 = 7f / 32f;
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.TextBox1.Text = "TOTAL";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 7f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtAcctTypeDescription,
      (ARControl) this.AcctTypeID
    });
    this.ghAcctTypeDescription.DataField = "AcctTypeDescription";
    this.ghAcctTypeDescription.Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).Name = "ghAcctTypeDescription";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).BeforePrint += new EventHandler(this.GfAcctTypeDescription_BeforePrint);
    ((ARControl) this.txtAcctTypeDescription).DataField = "AcctTypeDescription";
    ((ARControl) this.txtAcctTypeDescription).Height = 0.125f;
    ((ARControl) this.txtAcctTypeDescription).Left = 3f / 16f;
    ((ARControl) this.txtAcctTypeDescription).Name = "txtAcctTypeDescription";
    this.txtAcctTypeDescription.Style = "font-size: 8pt; font-weight: bold";
    this.txtAcctTypeDescription.Text = (string) null;
    ((ARControl) this.txtAcctTypeDescription).Top = 0.0f;
    ((ARControl) this.txtAcctTypeDescription).Width = 71f / 16f;
    ((ARControl) this.AcctTypeID).DataField = "AcctTypeID";
    ((ARControl) this.AcctTypeID).Height = 1f / 16f;
    ((ARControl) this.AcctTypeID).Left = 0.0f;
    ((ARControl) this.AcctTypeID).Name = "AcctTypeID";
    this.AcctTypeID.Style = "background-color: Yellow; font-size: 1pt";
    this.AcctTypeID.Text = (string) null;
    ((ARControl) this.AcctTypeID).Top = 0.0f;
    ((ARControl) this.AcctTypeID).Visible = false;
    ((ARControl) this.AcctTypeID).Width = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).CanShrink = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.txtBucket1_AcctTypeDescription_Total,
      (ARControl) this.txtBucket2_AcctTypeDescription_Total,
      (ARControl) this.txtBucket3_AcctTypeDescription_Total,
      (ARControl) this.TextBox
    });
    this.gfAcctTypeDescription.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).Name = "gfAcctTypeDescription";
    ((ARControl) this.TextBox2).DataField = "AcctTypeDescription";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 0.5f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 4.125f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).DataField = "Amount";
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Left = 4.625f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Name = "txtBucket1_AcctTypeDescription_Total";
    this.txtBucket1_AcctTypeDescription_Total.OutputFormat = resourceManager.GetString("txtBucket1_AcctTypeDescription_Total.OutputFormat");
    this.txtBucket1_AcctTypeDescription_Total.Style = "font-size: 8pt; text-align: right; vertical-align: bottom";
    this.txtBucket1_AcctTypeDescription_Total.SummaryGroup = "ghAcctTypeDescription";
    this.txtBucket1_AcctTypeDescription_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket1_AcctTypeDescription_Total.SummaryType = (SummaryType) 3;
    this.txtBucket1_AcctTypeDescription_Total.Text = " ";
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Top = 0.0f;
    ((ARControl) this.txtBucket1_AcctTypeDescription_Total).Width = 1.875f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).DataField = "CompareAmount";
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Left = 105f / 16f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Name = "txtBucket2_AcctTypeDescription_Total";
    this.txtBucket2_AcctTypeDescription_Total.OutputFormat = resourceManager.GetString("txtBucket2_AcctTypeDescription_Total.OutputFormat");
    this.txtBucket2_AcctTypeDescription_Total.Style = "font-size: 8pt; text-align: right; vertical-align: bottom";
    this.txtBucket2_AcctTypeDescription_Total.SummaryGroup = "ghAcctTypeDescription";
    this.txtBucket2_AcctTypeDescription_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket2_AcctTypeDescription_Total.SummaryType = (SummaryType) 3;
    this.txtBucket2_AcctTypeDescription_Total.Text = " ";
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Top = 0.0f;
    ((ARControl) this.txtBucket2_AcctTypeDescription_Total).Width = 1.875f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).DataField = "ChangeAmount";
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Height = 3f / 16f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Left = 8.5f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Name = "txtBucket3_AcctTypeDescription_Total";
    this.txtBucket3_AcctTypeDescription_Total.OutputFormat = resourceManager.GetString("txtBucket3_AcctTypeDescription_Total.OutputFormat");
    this.txtBucket3_AcctTypeDescription_Total.Style = "font-size: 8pt; text-align: right; vertical-align: bottom";
    this.txtBucket3_AcctTypeDescription_Total.SummaryGroup = "ghAcctTypeDescription";
    this.txtBucket3_AcctTypeDescription_Total.SummaryRunning = (SummaryRunning) 1;
    this.txtBucket3_AcctTypeDescription_Total.SummaryType = (SummaryType) 3;
    this.txtBucket3_AcctTypeDescription_Total.Text = " ";
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Top = 0.0f;
    ((ARControl) this.txtBucket3_AcctTypeDescription_Total).Width = 1.875f;
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 3f / 16f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.TextBox.Text = "Total";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 5f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName).CanShrink = true;
    this.ghFullName.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName).Name = "ghFullName";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName).Format += new EventHandler(this.GfFullName_Format);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName).CanShrink = true;
    this.gfFullName.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName).Name = "gfFullName";
    ((ARControl) this.txtDtl_AcctNum).DataField = "AcctNum";
    ((ARControl) this.txtDtl_AcctNum).Height = 0.09600007f;
    ((ARControl) this.txtDtl_AcctNum).Left = 1.25f;
    ((ARControl) this.txtDtl_AcctNum).Name = "txtDtl_AcctNum";
    this.txtDtl_AcctNum.Style = "background-color: Red";
    this.txtDtl_AcctNum.Text = (string) null;
    ((ARControl) this.txtDtl_AcctNum).Top = 0.02f;
    ((ARControl) this.txtDtl_AcctNum).Visible = false;
    ((ARControl) this.txtDtl_AcctNum).Width = 0.6249995f;
    this.MasterReport = false;
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctClassName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctClassName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.IncomeStatement_ReportStart);
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.txtFullName).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtDate).EndInit();
    ((ISupportInitialize) this._textCostCenter).EndInit();
    ((ISupportInitialize) this.txtCompany).EndInit();
    ((ISupportInitialize) this.txtTotAmount).EndInit();
    ((ISupportInitialize) this.txtTotCompareAmount).EndInit();
    ((ISupportInitialize) this.txtTotChangeAmount).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.lblBucket1).EndInit();
    ((ISupportInitialize) this.lblBucket2).EndInit();
    ((ISupportInitialize) this.lblBucket3).EndInit();
    ((ISupportInitialize) this.txtAcctClassName).EndInit();
    ((ISupportInitialize) this._orderMaster).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.txtBucket1_AcctClassName_Total).EndInit();
    ((ISupportInitialize) this.txtBucket2_AcctClassName_Total).EndInit();
    ((ISupportInitialize) this.txtBucket3_AcctClassName_Total).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).EndInit();
    ((ISupportInitialize) this.AcctTypeID).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.txtBucket1_AcctTypeDescription_Total).EndInit();
    ((ISupportInitialize) this.txtBucket2_AcctTypeDescription_Total).EndInit();
    ((ISupportInitialize) this.txtBucket3_AcctTypeDescription_Total).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.txtDtl_AcctNum).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
