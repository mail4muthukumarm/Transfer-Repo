// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.FinancialReports.TrialBalance
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
using System.Diagnostics;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.FinancialReports;

[SecureReportResource("{7CE90A5D-B849-4175-9FB5-B2FE96048F7D}", "Consolidated Trial Balance", "Consolidated Trial Balance.", "Financials")]
public class TrialBalance : MGAReport, IReport
{
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private string _GLCompanyIDs;
  private string _GLAccounts;
  private DataSet _ds;
  private string _acctNums;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private GroupHeader ghAccountClass;
  private GroupFooter gfAccountClass;
  private GroupHeader ghAcctTypeDescription;
  private GroupFooter gfAcctTypeDescription;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private Label Label5;
  private TextBox txtClientOffice;
  private TextBox txtTrialBalancePeriod;
  private TextBox txtAcctClassName;
  private TextBox Current_AcctTypeDescription;
  private TextBox Current_AcctClassName;
  private TextBox txtAcctTypeDescription;
  private Label Label3;
  private Label Label4;
  private SubReport srDetails;
  private TextBox AcctClassName3;
  private TextBox TextBox1;
  private TextBox txtAcctTypeTotal;
  private TextBox AcctClassName1;
  private TextBox AcctClassName2;
  private TextBox txtAccountClassTotal;
  private Label Label6;
  private TextBox TextBox2;
  private Label Label1;
  private Label Label2;
  private Label Label7;
  private TextBox txtAcctTypeTotal_BalForward;
  private TextBox txtAcctTypeTotal_Total;
  private TextBox txtAccountClassTotal_BalForward;
  private TextBox txtAccountClassTotal_Total;
  private TextBox TextBox4;
  private TextBox TextBox3;

  public TrialBalance() => this.InitializeComponent();

  public TrialBalance(DateTime DateFrom, DateTime DateTo, string GLCompanyIDs)
  {
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._GLCompanyIDs = GLCompanyIDs;
  }

  private void TrialBalance_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.txtClientOffice.Text = DefaultDatabase.ExecuteScalar(CommandType.Text, "Select dbo.GetOfficeLocationNames(@glcompanyids)", new object[2]
    {
      (object) "@glcompanyids",
      (object) this._GLCompanyIDs
    }).ToString();
    this.txtTrialBalancePeriod.Text = $"{this._DateFrom.ToShortDateString()} - {this._DateTo.ToShortDateString()}";
    ArrayList arrayList = new ArrayList();
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@DateFrom",
      (object) this._DateFrom
    });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@DateTo",
      (object) this._DateTo
    });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@GlCompanyIDs",
      (object) this._GLCompanyIDs
    });
    this._ds = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, "spFin_ConsolidatedTrialBalance", 0, (CommandArgumentType) 0, arrayList.ToArray());
    this.DataSource = (object) this._ds.Tables[0];
  }

  private void detail_BeforePrint(object sender, EventArgs e)
  {
    this.srDetails.Report = (SectionReport) new TrialBalance_Record(new DataView(this._ds.Tables[0], $"AcctTypeDescription='{this.Current_AcctTypeDescription.Text}' AND AcctClassName='{this.Current_AcctClassName.Text}'", "", DataViewRowState.CurrentRows));
  }

  private void gfAcctTypeDescription_Format(object sender, EventArgs e)
  {
    this.txtAcctTypeTotal_BalForward.Value = this._ds.Tables[0].Compute("SUM(BalForward)", $"AcctTypeDescription='{this.Current_AcctTypeDescription.Text}' AND AcctClassName='{this.Current_AcctClassName.Text}'");
    this.txtAcctTypeTotal.Value = this._ds.Tables[0].Compute("SUM(Amount)", $"AcctTypeDescription='{this.Current_AcctTypeDescription.Text}' AND AcctClassName='{this.Current_AcctClassName.Text}'");
    this.txtAcctTypeTotal_Total.Value = this._ds.Tables[0].Compute("SUM(Total)", $"AcctTypeDescription='{this.Current_AcctTypeDescription.Text}' AND AcctClassName='{this.Current_AcctClassName.Text}'");
  }

  private void gfAccountClass_BeforePrint(object sender, EventArgs e)
  {
    this.txtAccountClassTotal_BalForward.Value = this._ds.Tables[0].Compute("SUM(BalForward)", $"AcctClassName='{this.Current_AcctClassName.Text}'");
    this.txtAccountClassTotal.Value = this._ds.Tables[0].Compute("SUM(Amount)", $"AcctClassName='{this.Current_AcctClassName.Text}'");
    this.txtAccountClassTotal_Total.Value = this._ds.Tables[0].Compute("SUM(Total)", $"AcctClassName='{this.Current_AcctClassName.Text}'");
  }

  Type IReport.getLaunchForm => (Type) null;

  BaseReportControl[] IReport.getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DateRangePicker("Trial Balance Date Range", false),
        (BaseReportControl) new GenericListBox("Office Locations", $"spFin_GetOfficeLocations @userguid='{CurrentUser.Instance.UserGUID.ToString()}'", "ID", "Office Location", false, typeof (int), false, false, 300)
      };
    }
  }

  public override bool IsThreaded => true;

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    this._acctNums = Convert.ToString(e.HyperLink);
    rptAccountTransactionLedgerConsolidated rpt = new rptAccountTransactionLedgerConsolidated(this._GLCompanyIDs, this._acctNums, this._DateFrom, this._DateTo);
    rpt.Run();
    rpt.Document.Name = $"Account Transaction Ledger - {e.HyperLink}";
    ReportFactory.Instance.ShowReport((SectionReport) rpt);
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    DataTable source = new DataTable();
    source.Columns.Add("GL Account", typeof (string));
    source.Columns.Add("Account Name", typeof (string));
    source.Columns.Add("Account Type", typeof (string));
    source.Columns.Add("BalForward", typeof (Decimal));
    source.Columns.Add("Amount", typeof (Decimal));
    source.Columns.Add("Total", typeof (Decimal));
    foreach (DataRow dataRow in this._ds.Tables[0].Select())
    {
      string str1 = dataRow["FullName"].ToString();
      int startIndex = str1.IndexOf(Convert.ToChar("-")) + 2;
      string str2 = str1.Substring(startIndex, str1.Length - startIndex);
      source.Rows.Add(dataRow["AcctNum"], (object) str2, dataRow["AcctTypeDescription"], (object) Convert.ToDecimal(dataRow["BalForward"]), (object) Convert.ToDecimal(dataRow["Amount"]), (object) Convert.ToDecimal(dataRow["Total"]));
    }
    ExcelExport.ToExcel(source, SaveFileTo);
    Process.Start(SaveFileTo);
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (TrialBalance));
    this.pageHeader = new PageHeader();
    this.Label5 = new Label();
    this.txtClientOffice = new TextBox();
    this.txtTrialBalancePeriod = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label7 = new Label();
    this.detail = new Detail();
    this.pageFooter = new PageFooter();
    this.ghAccountClass = new GroupHeader();
    this.txtAcctClassName = new TextBox();
    this.gfAccountClass = new GroupFooter();
    this.AcctClassName1 = new TextBox();
    this.AcctClassName2 = new TextBox();
    this.txtAccountClassTotal = new TextBox();
    this.txtAccountClassTotal_BalForward = new TextBox();
    this.txtAccountClassTotal_Total = new TextBox();
    this.ghAcctTypeDescription = new GroupHeader();
    this.Current_AcctTypeDescription = new TextBox();
    this.Current_AcctClassName = new TextBox();
    this.txtAcctTypeDescription = new TextBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.gfAcctTypeDescription = new GroupFooter();
    this.srDetails = new SubReport();
    this.AcctClassName3 = new TextBox();
    this.TextBox1 = new TextBox();
    this.txtAcctTypeTotal = new TextBox();
    this.txtAcctTypeTotal_BalForward = new TextBox();
    this.txtAcctTypeTotal_Total = new TextBox();
    this.reportHeader1 = new ReportHeader();
    this.reportFooter1 = new ReportFooter();
    this.Label6 = new Label();
    this.TextBox2 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox3 = new TextBox();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtClientOffice).BeginInit();
    ((ISupportInitialize) this.txtTrialBalancePeriod).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.txtAcctClassName).BeginInit();
    ((ISupportInitialize) this.AcctClassName1).BeginInit();
    ((ISupportInitialize) this.AcctClassName2).BeginInit();
    ((ISupportInitialize) this.txtAccountClassTotal).BeginInit();
    ((ISupportInitialize) this.txtAccountClassTotal_BalForward).BeginInit();
    ((ISupportInitialize) this.txtAccountClassTotal_Total).BeginInit();
    ((ISupportInitialize) this.Current_AcctTypeDescription).BeginInit();
    ((ISupportInitialize) this.Current_AcctClassName).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.AcctClassName3).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeTotal).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeTotal_BalForward).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeTotal_Total).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Label5,
      (ARControl) this.txtClientOffice,
      (ARControl) this.txtTrialBalancePeriod,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label7
    });
    this.pageHeader.Height = 21f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Name = "pageHeader";
    ((ARControl) this.Label5).Height = 0.25f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 0.0f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 16pt; text-align: center";
    this.Label5.Text = "Trial Balance";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 7.875f;
    ((ARControl) this.txtClientOffice).Height = 3f / 16f;
    ((ARControl) this.txtClientOffice).Left = 0.0f;
    ((ARControl) this.txtClientOffice).Name = "txtClientOffice";
    this.txtClientOffice.Style = "font-size: 11pt; text-align: center";
    this.txtClientOffice.Text = "[ClientOffice]";
    ((ARControl) this.txtClientOffice).Top = 0.375f;
    ((ARControl) this.txtClientOffice).Width = 7.875f;
    ((ARControl) this.txtTrialBalancePeriod).Height = 3f / 16f;
    ((ARControl) this.txtTrialBalancePeriod).Left = 0.0f;
    ((ARControl) this.txtTrialBalancePeriod).Name = "txtTrialBalancePeriod";
    this.txtTrialBalancePeriod.Style = "font-size: 11pt; text-align: center";
    this.txtTrialBalancePeriod.Text = (string) null;
    ((ARControl) this.txtTrialBalancePeriod).Top = 11f / 16f;
    ((ARControl) this.txtTrialBalancePeriod).Width = 7.875f;
    ((ARControl) this.Label1).Height = 0.188f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 6.562f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-weight: bold; text-align: right";
    this.Label1.Text = "Total";
    ((ARControl) this.Label1).Top = 1.009f;
    ((ARControl) this.Label1).Width = 1.313f;
    ((ARControl) this.Label2).Height = 0.188f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 5.25f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-weight: bold; text-align: right";
    this.Label2.Text = "Amount";
    ((ARControl) this.Label2).Top = 1.009f;
    ((ARControl) this.Label2).Width = 1.313f;
    ((ARControl) this.Label7).Height = 0.188f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 3.937f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-weight: bold; text-align: right";
    this.Label7.Text = "Balance Forward";
    ((ARControl) this.Label7).Top = 1.009f;
    ((ARControl) this.Label7).Width = 1.313f;
    this.detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.0f;
    this.detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).BeforePrint += new EventHandler(this.detail_BeforePrint);
    this.pageFooter.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Name = "pageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAccountClass).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtAcctClassName
    });
    this.ghAccountClass.DataField = "AcctClassName";
    this.ghAccountClass.Height = 0.188f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAccountClass).Name = "ghAccountClass";
    ((ARControl) this.txtAcctClassName).DataField = "AcctClassName";
    ((ARControl) this.txtAcctClassName).Height = 3f / 16f;
    ((ARControl) this.txtAcctClassName).Left = 0.0f;
    ((ARControl) this.txtAcctClassName).Name = "txtAcctClassName";
    this.txtAcctClassName.Style = "font-weight: bold; text-align: center";
    this.txtAcctClassName.Text = (string) null;
    ((ARControl) this.txtAcctClassName).Top = 0.0f;
    ((ARControl) this.txtAcctClassName).Width = 7.875f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAccountClass).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.AcctClassName1,
      (ARControl) this.AcctClassName2,
      (ARControl) this.txtAccountClassTotal,
      (ARControl) this.txtAccountClassTotal_BalForward,
      (ARControl) this.txtAccountClassTotal_Total
    });
    this.gfAccountClass.Height = 0.2208333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAccountClass).Name = "gfAccountClass";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAccountClass).BeforePrint += new EventHandler(this.gfAccountClass_BeforePrint);
    ((ARControl) this.AcctClassName1).DataField = "AcctClassName";
    ((ARControl) this.AcctClassName1).Height = 3f / 16f;
    ((ARControl) this.AcctClassName1).Left = 0.0f;
    ((ARControl) this.AcctClassName1).Name = "AcctClassName1";
    this.AcctClassName1.Style = "font-weight: bold; text-align: right";
    this.AcctClassName1.Text = (string) null;
    ((ARControl) this.AcctClassName1).Top = 0.0f;
    ((ARControl) this.AcctClassName1).Width = 2.99f;
    ((ARControl) this.AcctClassName2).Height = 3f / 16f;
    ((ARControl) this.AcctClassName2).Left = 2.99f;
    ((ARControl) this.AcctClassName2).Name = "AcctClassName2";
    this.AcctClassName2.Style = "font-weight: bold; text-align: right";
    this.AcctClassName2.Text = "Total:";
    ((ARControl) this.AcctClassName2).Top = 0.0f;
    ((ARControl) this.AcctClassName2).Width = 7f / 16f;
    ((ARControl) this.txtAccountClassTotal).Height = 0.2f;
    ((ARControl) this.txtAccountClassTotal).Left = 5.25f;
    ((ARControl) this.txtAccountClassTotal).Name = "txtAccountClassTotal";
    this.txtAccountClassTotal.OutputFormat = resourceManager.GetString("txtAccountClassTotal.OutputFormat");
    this.txtAccountClassTotal.Style = "text-align: right; ddo-char-set: 0";
    this.txtAccountClassTotal.Text = (string) null;
    ((ARControl) this.txtAccountClassTotal).Top = 0.0f;
    ((ARControl) this.txtAccountClassTotal).Width = 1.313f;
    ((ARControl) this.txtAccountClassTotal_BalForward).Height = 0.2f;
    ((ARControl) this.txtAccountClassTotal_BalForward).Left = 3.937f;
    ((ARControl) this.txtAccountClassTotal_BalForward).Name = "txtAccountClassTotal_BalForward";
    this.txtAccountClassTotal_BalForward.OutputFormat = resourceManager.GetString("txtAccountClassTotal_BalForward.OutputFormat");
    this.txtAccountClassTotal_BalForward.Style = "text-align: right; ddo-char-set: 0";
    this.txtAccountClassTotal_BalForward.Text = (string) null;
    ((ARControl) this.txtAccountClassTotal_BalForward).Top = 0.0f;
    ((ARControl) this.txtAccountClassTotal_BalForward).Width = 1.313f;
    ((ARControl) this.txtAccountClassTotal_Total).Height = 0.2f;
    ((ARControl) this.txtAccountClassTotal_Total).Left = 6.562f;
    ((ARControl) this.txtAccountClassTotal_Total).Name = "txtAccountClassTotal_Total";
    this.txtAccountClassTotal_Total.OutputFormat = resourceManager.GetString("txtAccountClassTotal_Total.OutputFormat");
    this.txtAccountClassTotal_Total.Style = "text-align: right; ddo-char-set: 0";
    this.txtAccountClassTotal_Total.Text = (string) null;
    ((ARControl) this.txtAccountClassTotal_Total).Top = 0.0f;
    ((ARControl) this.txtAccountClassTotal_Total).Width = 1.313f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Current_AcctTypeDescription,
      (ARControl) this.Current_AcctClassName,
      (ARControl) this.txtAcctTypeDescription,
      (ARControl) this.Label3,
      (ARControl) this.Label4
    });
    this.ghAcctTypeDescription.DataField = "AcctTypeDescription";
    this.ghAcctTypeDescription.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription).Name = "ghAcctTypeDescription";
    ((ARControl) this.Current_AcctTypeDescription).DataField = "AcctTypeDescription";
    ((ARControl) this.Current_AcctTypeDescription).Height = 1f / 16f;
    ((ARControl) this.Current_AcctTypeDescription).Left = 0.0f;
    ((ARControl) this.Current_AcctTypeDescription).Name = "Current_AcctTypeDescription";
    this.Current_AcctTypeDescription.Style = "background-color: Yellow";
    this.Current_AcctTypeDescription.Text = (string) null;
    ((ARControl) this.Current_AcctTypeDescription).Top = 0.0f;
    ((ARControl) this.Current_AcctTypeDescription).Visible = false;
    ((ARControl) this.Current_AcctTypeDescription).Width = 0.5f;
    ((ARControl) this.Current_AcctClassName).DataField = "AcctClassName";
    ((ARControl) this.Current_AcctClassName).Height = 1f / 16f;
    ((ARControl) this.Current_AcctClassName).Left = 0.5f;
    ((ARControl) this.Current_AcctClassName).Name = "Current_AcctClassName";
    this.Current_AcctClassName.Style = "background-color: Yellow";
    this.Current_AcctClassName.Text = (string) null;
    ((ARControl) this.Current_AcctClassName).Top = 0.0f;
    ((ARControl) this.Current_AcctClassName).Visible = false;
    ((ARControl) this.Current_AcctClassName).Width = 0.5f;
    ((ARControl) this.txtAcctTypeDescription).DataField = "AcctTypeDescription";
    ((ARControl) this.txtAcctTypeDescription).Height = 3f / 16f;
    ((ARControl) this.txtAcctTypeDescription).Left = 0.25f;
    ((ARControl) this.txtAcctTypeDescription).Name = "txtAcctTypeDescription";
    this.txtAcctTypeDescription.Text = (string) null;
    ((ARControl) this.txtAcctTypeDescription).Top = 0.0f;
    ((ARControl) this.txtAcctTypeDescription).Width = 5.625f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 5.875f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-weight: bold; text-align: right";
    this.Label3.Text = "";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 2f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 0.0f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-weight: bold; text-align: right";
    this.Label4.Text = "";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.srDetails,
      (ARControl) this.AcctClassName3,
      (ARControl) this.TextBox1,
      (ARControl) this.txtAcctTypeTotal,
      (ARControl) this.txtAcctTypeTotal_BalForward,
      (ARControl) this.txtAcctTypeTotal_Total
    });
    this.gfAcctTypeDescription.Height = 1.187834f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).Name = "gfAcctTypeDescription";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription).Format += new EventHandler(this.gfAcctTypeDescription_Format);
    this.srDetails.CloseBorder = false;
    ((ARControl) this.srDetails).Height = 0.698f;
    ((ARControl) this.srDetails).Left = 0.0f;
    ((ARControl) this.srDetails).Name = "srDetails";
    this.srDetails.Report = (SectionReport) null;
    ((ARControl) this.srDetails).Top = 0.0f;
    ((ARControl) this.srDetails).Width = 7.875f;
    ((ARControl) this.AcctClassName3).DataField = "AcctTypeDescription";
    ((ARControl) this.AcctClassName3).Height = 3f / 16f;
    ((ARControl) this.AcctClassName3).Left = 0.0f;
    ((ARControl) this.AcctClassName3).Name = "AcctClassName3";
    this.AcctClassName3.Style = "text-align: right";
    this.AcctClassName3.Text = (string) null;
    ((ARControl) this.AcctClassName3).Top = 0.761f;
    ((ARControl) this.AcctClassName3).Width = 2.99f;
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 2.99f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "text-align: right";
    this.TextBox1.Text = "Total:";
    ((ARControl) this.TextBox1).Top = 0.761f;
    ((ARControl) this.TextBox1).Width = 7f / 16f;
    ((ARControl) this.txtAcctTypeTotal).Height = 0.2f;
    ((ARControl) this.txtAcctTypeTotal).Left = 5.25f;
    ((ARControl) this.txtAcctTypeTotal).Name = "txtAcctTypeTotal";
    this.txtAcctTypeTotal.OutputFormat = resourceManager.GetString("txtAcctTypeTotal.OutputFormat");
    this.txtAcctTypeTotal.Style = "text-align: right; ddo-char-set: 0";
    this.txtAcctTypeTotal.Text = (string) null;
    ((ARControl) this.txtAcctTypeTotal).Top = 0.761f;
    ((ARControl) this.txtAcctTypeTotal).Width = 1.313f;
    ((ARControl) this.txtAcctTypeTotal_BalForward).Height = 0.2f;
    ((ARControl) this.txtAcctTypeTotal_BalForward).Left = 3.937f;
    ((ARControl) this.txtAcctTypeTotal_BalForward).Name = "txtAcctTypeTotal_BalForward";
    this.txtAcctTypeTotal_BalForward.OutputFormat = resourceManager.GetString("txtAcctTypeTotal_BalForward.OutputFormat");
    this.txtAcctTypeTotal_BalForward.Style = "text-align: right; ddo-char-set: 0";
    this.txtAcctTypeTotal_BalForward.Text = (string) null;
    ((ARControl) this.txtAcctTypeTotal_BalForward).Top = 0.761f;
    ((ARControl) this.txtAcctTypeTotal_BalForward).Width = 1.313f;
    ((ARControl) this.txtAcctTypeTotal_Total).Height = 0.2f;
    ((ARControl) this.txtAcctTypeTotal_Total).Left = 6.562f;
    ((ARControl) this.txtAcctTypeTotal_Total).Name = "txtAcctTypeTotal_Total";
    this.txtAcctTypeTotal_Total.OutputFormat = resourceManager.GetString("txtAcctTypeTotal_Total.OutputFormat");
    this.txtAcctTypeTotal_Total.Style = "text-align: right; ddo-char-set: 0";
    this.txtAcctTypeTotal_Total.Text = (string) null;
    ((ARControl) this.txtAcctTypeTotal_Total).Top = 0.761f;
    ((ARControl) this.txtAcctTypeTotal_Total).Width = 1.313f;
    this.reportHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Name = "reportHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label6,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox3
    });
    this.reportFooter1.Height = 0.325f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Name = "reportFooter1";
    ((ARControl) this.Label6).Height = 0.2f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.0f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 12pt; font-weight: bold";
    this.Label6.Text = "Trial Balance";
    ((ARControl) this.Label6).Top = 0.125f;
    ((ARControl) this.Label6).Width = 23f / 16f;
    ((ARControl) this.TextBox2).DataField = "Amount";
    ((ARControl) this.TextBox2).Height = 0.2f;
    ((ARControl) this.TextBox2).Left = 5.25f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 12pt; font-weight: bold; text-align: right";
    this.TextBox2.SummaryRunning = (SummaryRunning) 2;
    this.TextBox2.SummaryType = (SummaryType) 1;
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.125f;
    ((ARControl) this.TextBox2).Width = 1.313f;
    ((ARControl) this.TextBox4).DataField = "BalForward";
    ((ARControl) this.TextBox4).Height = 0.2f;
    ((ARControl) this.TextBox4).Left = 3.937f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 12pt; font-weight: bold; text-align: right";
    this.TextBox4.SummaryRunning = (SummaryRunning) 2;
    this.TextBox4.SummaryType = (SummaryType) 1;
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.125f;
    ((ARControl) this.TextBox4).Width = 1.313f;
    ((ARControl) this.TextBox3).DataField = "Total";
    ((ARControl) this.TextBox3).Height = 0.2f;
    ((ARControl) this.TextBox3).Left = 6.563f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 12pt; font-weight: bold; text-align: right";
    this.TextBox3.SummaryRunning = (SummaryRunning) 2;
    this.TextBox3.SummaryType = (SummaryType) 1;
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.125f;
    ((ARControl) this.TextBox3).Width = 1.313f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAccountClass);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghAcctTypeDescription);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAcctTypeDescription);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfAccountClass);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.TrialBalance_ReportStart);
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtClientOffice).EndInit();
    ((ISupportInitialize) this.txtTrialBalancePeriod).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.txtAcctClassName).EndInit();
    ((ISupportInitialize) this.AcctClassName1).EndInit();
    ((ISupportInitialize) this.AcctClassName2).EndInit();
    ((ISupportInitialize) this.txtAccountClassTotal).EndInit();
    ((ISupportInitialize) this.txtAccountClassTotal_BalForward).EndInit();
    ((ISupportInitialize) this.txtAccountClassTotal_Total).EndInit();
    ((ISupportInitialize) this.Current_AcctTypeDescription).EndInit();
    ((ISupportInitialize) this.Current_AcctClassName).EndInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.AcctClassName3).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.txtAcctTypeTotal).EndInit();
    ((ISupportInitialize) this.txtAcctTypeTotal_BalForward).EndInit();
    ((ISupportInitialize) this.txtAcctTypeTotal_Total).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
