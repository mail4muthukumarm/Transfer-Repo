// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Reports.ClaimTransactionReport
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Claims.Reports;

[SecureReportResource("{88593CAC-9123-4cb0-B6A2-E0C27C236638}", "Transaction Report", "Transaction Report", "Claims")]
public class ClaimTransactionReport : MGAReport, IReport, ISupportReportDictionary
{
  private DateTime _datefrom;
  private DateTime _dateto;
  private string _companyGuid;
  private string _policyNumber;
  private string _inhouseAdjuster;
  private DataSet _ds;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Container components;
  private GroupHeader groupHeader1;
  private GroupFooter groupFooter1;
  private TextBox textBox2;
  private ReportHeader reportHeader1;
  private TextBox textBox1;
  private Label label2;
  private Label label3;
  private TextBox textBox17;
  private Label label4;
  private Label label7;
  private ReportFooter reportFooter1;
  private TextBox textBox5;
  private Label label8;
  private TextBox textBox3;
  private SubReport subReport1;
  private Label label5;
  private TextBox textBox4;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox textBox8;
  private TextBox textBox9;
  private TextBox textBox25;
  private TextBox textBox28;
  private TextBox textBox10;
  private TextBox textBox11;
  private Label label1;
  private Label label6;
  private TextBox textBox12;
  private TextBox txtClaimID;

  public ClaimTransactionReport() => this.InitializeComponent();

  public ClaimTransactionReport(
    DateTime datefrom,
    DateTime dateto,
    string companyGuid,
    string policyNumber,
    string inhouseAdjuster)
  {
    this.InitializeComponent();
    this._datefrom = datefrom;
    this._dateto = dateto;
    this._companyGuid = companyGuid;
    this._policyNumber = policyNumber;
    this._inhouseAdjuster = inhouseAdjuster;
  }

  private void ClaimTransactionReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spClaims_rptTransactionDetail", connection);
    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
    this._ds = new DataSet();
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Parameters.AddWithValue("@datefrom", (object) this._datefrom);
    selectCommand.Parameters.AddWithValue("@dateto", (object) this._dateto);
    if (!string.IsNullOrEmpty(this._companyGuid.ToString()))
      selectCommand.Parameters.AddWithValue("@companyGuid", (object) this._companyGuid);
    if (!string.IsNullOrEmpty(this._policyNumber))
      selectCommand.Parameters.AddWithValue("@policyNumber", (object) this._policyNumber);
    if (!string.IsNullOrEmpty(this._inhouseAdjuster.ToString()))
      selectCommand.Parameters.AddWithValue("@inhouseAdjuster", (object) this._inhouseAdjuster);
    try
    {
      Database.SafeDataAdapterFill(dataAdapter, this._ds);
    }
    finally
    {
      connection.Close();
      dataAdapter.Dispose();
      selectCommand.Dispose();
      connection.Dispose();
    }
    ((SectionReport) this).DataSource = (object) this._ds.Tables[1];
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[4]
      {
        (BaseReportControl) new DateRangePicker("Effective Date Range", false),
        (BaseReportControl) new GenericListBox("Company", "SELECT DISTINCT CompanyName AS Display,CompanyGuid as Value From tblCompanies  Order by CompanyName", "Value", "Display", true, typeof (Guid), true, false),
        (BaseReportControl) new TextInput("Policy Number", false, false),
        (BaseReportControl) new GenericListBox("Adjuster", "SELECT DISTINCT tblUsers.FirstName + ' ' + tblUsers.LastName AS Display, tblClaims_Claim.InhouseAdjuster as Value From tblClaims_Claim inner join tblUsers on tblUsers.userguid = tblClaims_Claim.InhouseAdjuster Order by tblUsers.FirstName + ' ' + tblUsers.LastName", "Value", "Display", true, typeof (Guid), true, false)
      };
    }
  }

  private void detail_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count <= 0 || this._ds.Tables[1].Rows.Count <= 0)
      return;
    this.subReport1.Report = (SectionReport) new ClaimsTransactionSubReport(new DataView(this._ds.Tables[2], $"ClaimID='{this.txtClaimID.Text}'", "ClaimID", DataViewRowState.CurrentRows));
  }

  private void reportHeader1_Format(object sender, EventArgs e)
  {
    this.textBox1.Text = DateTime.Now.ToShortDateString();
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.textBox17.Text = $"Transaction Report for {this._datefrom.ToShortDateString()} to {this._dateto.ToShortDateString()}";
    this.label2.Text = this._ds.Tables[0].Rows[0]["MGAName"].ToString();
    this.label3.Text = this._ds.Tables[0].Rows[0]["CompanyName"].ToString();
    this.label6.Text = this._ds.Tables[0].Rows[0]["AdjusterLabel"].ToString();
    this.textBox12.Text = this._ds.Tables[0].Rows[0]["Adjusters"].ToString();
  }

  public virtual bool IsThreaded => true;

  private void reportFooter1_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[3].Rows.Count <= 0)
      return;
    this.textBox7.Value = (object) Convert.ToDecimal(this._ds.Tables[3].Rows[0]["hours"]);
    this.textBox28.Value = (object) Convert.ToDecimal(this._ds.Tables[3].Rows[0]["HourlyCharges"]);
    this.textBox8.Value = (object) Convert.ToDecimal(this._ds.Tables[3].Rows[0]["EquipmentCharges"]);
    this.textBox9.Value = (object) Convert.ToDecimal(this._ds.Tables[3].Rows[0]["OtherCharges"]);
    this.textBox25.Value = (object) Convert.ToDecimal(this._ds.Tables[3].Rows[0]["total"]);
  }

  string[] ISupportReportDictionary.FieldDescriptions
  {
    get
    {
      return new string[24]
      {
        "Amount",
        "Displays the sum of all charges for the transaction.",
        "Other Charges",
        "Shows the sum of any other charges for the transaction.",
        "Equipment",
        "Shows the sum of the equipment charges for the transaction.",
        "Hourly Charges",
        "Shows the total of the hourly charges.",
        "Hours",
        "Displays the number of hours for the transcation.",
        "User",
        "Shows the user who entered the transaction.",
        "Expense",
        "Displays the expense description.",
        "Date Entered",
        "Shows the date the ULAE transaction was entered.",
        "Insured",
        "Shows the insured name on the policy.",
        "Claim Number",
        "Shows the claim number.",
        "Loss Date",
        "The date of loss.",
        "Policy Number",
        "Displays the policy number."
      };
    }
  }

  string ISupportReportDictionary.GeneralDescription
  {
    get => "Displays a list of unallocated loss expenses within the specified date range.";
  }

  string ISupportReportDictionary.ReportFriendlyName => "Transaction Report";

  string[] ISupportReportDictionary.SearchCriteriaDescription
  {
    get
    {
      return new string[4]
      {
        "Company",
        "This search criteria is optional. This will further limit the result set to the company selected. Alternatively, you choose to run the report for all companies.",
        "Date Range",
        "Limits the data returned to unallocated loss expenses created within the specified date range. This field is required."
      };
    }
  }

  string[] ISupportReportDictionary.SortingAndTotalsDescription
  {
    get
    {
      return new string[4]
      {
        "Claim Number",
        "The is grouped and sub-totalled by claim number.",
        "Grand Total",
        "The report has a grand total of all transactions for all claims."
      };
    }
  }

  protected virtual void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (ClaimTransactionReport));
    this.pageHeader = new PageHeader();
    this.detail = new Detail();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox5 = new TextBox();
    this.subReport1 = new SubReport();
    this.textBox11 = new TextBox();
    this.pageFooter = new PageFooter();
    this.groupHeader1 = new GroupHeader();
    this.groupFooter1 = new GroupFooter();
    this.reportHeader1 = new ReportHeader();
    this.textBox1 = new TextBox();
    this.label2 = new Label();
    this.label3 = new Label();
    this.textBox17 = new TextBox();
    this.label4 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label5 = new Label();
    this.label1 = new Label();
    this.label6 = new Label();
    this.textBox12 = new TextBox();
    this.reportFooter1 = new ReportFooter();
    this.textBox4 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.textBox9 = new TextBox();
    this.textBox25 = new TextBox();
    this.textBox28 = new TextBox();
    this.textBox10 = new TextBox();
    this.txtClaimID = new TextBox();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.textBox17).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.textBox25).BeginInit();
    ((ISupportInitialize) this.textBox28).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this.txtClaimID).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.pageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Name = "pageHeader";
    this.detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox5,
      (ARControl) this.subReport1,
      (ARControl) this.textBox11,
      (ARControl) this.txtClaimID
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 13f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Format += new EventHandler(this.detail_Format);
    ((ARControl) this.textBox2).DataField = "PolicyNumber";
    ((ARControl) this.textBox2).Height = 0.125f;
    ((ARControl) this.textBox2).Left = 0.0f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 1.75f;
    ((ARControl) this.textBox3).DataField = "LossDate";
    ((ARControl) this.textBox3).Height = 0.125f;
    ((ARControl) this.textBox3).Left = 1.75f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.OutputFormat = resourceManager.GetString("textBox3.OutputFormat");
    this.textBox3.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 1.192093E-07f;
    ((ARControl) this.textBox3).Width = 1f;
    ((ARControl) this.textBox5).DataField = "InsuredName";
    ((ARControl) this.textBox5).Height = 0.125f;
    ((ARControl) this.textBox5).Left = 93f / 16f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 1.192093E-07f;
    ((ARControl) this.textBox5).Width = 4f;
    this.subReport1.CloseBorder = false;
    ((ARControl) this.subReport1).Height = 0.219f;
    ((ARControl) this.subReport1).Left = 1f;
    ((ARControl) this.subReport1).Name = "subReport1";
    this.subReport1.Report = (SectionReport) null;
    this.subReport1.ReportName = "subReport1";
    ((ARControl) this.subReport1).Top = 0.125f;
    ((ARControl) this.subReport1).Width = 9.375f;
    ((ARControl) this.textBox11).DataField = "claimnumber";
    ((ARControl) this.textBox11).Height = 0.125f;
    ((ARControl) this.textBox11).Left = 2.75f;
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox11.Text = (string) null;
    ((ARControl) this.textBox11).Top = 1.192093E-07f;
    ((ARControl) this.textBox11).Width = 49f / 16f;
    this.pageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Name = "pageFooter";
    this.groupHeader1.DataField = "policynumber";
    this.groupHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Name = "groupHeader1";
    this.groupFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Name = "groupFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.textBox1,
      (ARControl) this.label2,
      (ARControl) this.label3,
      (ARControl) this.textBox17,
      (ARControl) this.label4,
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label5,
      (ARControl) this.label1,
      (ARControl) this.label6,
      (ARControl) this.textBox12
    });
    this.reportHeader1.Height = 1.333334f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Name = "reportHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Format += new EventHandler(this.reportHeader1_Format);
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 15f / 16f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.OutputFormat = resourceManager.GetString("textBox1.OutputFormat");
    this.textBox1.Style = "font-family: Tahoma; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox1.Text = (string) null;
    ((ARControl) this.textBox1).Top = 9f / 16f;
    ((ARControl) this.textBox1).Width = 65f / 16f;
    ((ARControl) this.label2).Height = 0.188f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 0.0f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-family: Tahoma; font-size: 9.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label2.Text = "South Valley Claims";
    ((ARControl) this.label2).Top = 0.0f;
    ((ARControl) this.label2).Width = 10.2f;
    ((ARControl) this.label3).Height = 0.188f;
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Left = 0.0f;
    ((ARControl) this.label3).Name = "label3";
    this.label3.Style = "font-family: Tahoma; font-size: 9.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label3.Text = "";
    ((ARControl) this.label3).Top = 3f / 16f;
    ((ARControl) this.label3).Width = 10.2f;
    ((ARControl) this.textBox17).Height = 0.188f;
    ((ARControl) this.textBox17).Left = 0.0f;
    ((ARControl) this.textBox17).Name = "textBox17";
    this.textBox17.Style = "font-family: Tahoma; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox17.Text = (string) null;
    ((ARControl) this.textBox17).Top = 0.375f;
    ((ARControl) this.textBox17).Width = 10.2f;
    ((ARControl) this.label4).Height = 0.125f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 0.0f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label4.Text = "Policy Number";
    ((ARControl) this.label4).Top = 1.208f;
    ((ARControl) this.label4).Width = 1.75f;
    ((ARControl) this.label7).Height = 0.125f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 93f / 16f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label7.Text = "Insured Name";
    ((ARControl) this.label7).Top = 1.208f;
    ((ARControl) this.label7).Width = 4f;
    ((ARControl) this.label8).Height = 0.125f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 1.75f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label8.Text = "Loss Date";
    ((ARControl) this.label8).Top = 1.208f;
    ((ARControl) this.label8).Width = 1f;
    ((ARControl) this.label5).Height = 3f / 16f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 0.0f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-family: Tahoma; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    this.label5.Text = "Report Date:";
    ((ARControl) this.label5).Top = 9f / 16f;
    ((ARControl) this.label5).Width = 15f / 16f;
    ((ARControl) this.label1).Height = 0.125f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 2.75f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label1.Text = "Claim Number";
    ((ARControl) this.label1).Top = 1.208f;
    ((ARControl) this.label1).Width = 49f / 16f;
    ((ARControl) this.label6).Height = 3f / 16f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 0.0f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "font-family: Tahoma; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    this.label6.Text = "";
    ((ARControl) this.label6).Top = 0.7500001f;
    ((ARControl) this.label6).Width = 15f / 16f;
    ((ARControl) this.textBox12).Height = 3f / 16f;
    ((ARControl) this.textBox12).Left = 15f / 16f;
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.OutputFormat = resourceManager.GetString("textBox12.OutputFormat");
    this.textBox12.Style = "font-family: Tahoma; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox12.Text = (string) null;
    ((ARControl) this.textBox12).Top = 0.7500001f;
    ((ARControl) this.textBox12).Width = 65f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.textBox4,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8,
      (ARControl) this.textBox9,
      (ARControl) this.textBox25,
      (ARControl) this.textBox28,
      (ARControl) this.textBox10
    });
    this.reportFooter1.Height = 0.1770833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Name = "reportFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Format += new EventHandler(this.reportFooter1_Format);
    ((ARControl) this.textBox4).Height = 3f / 16f;
    ((ARControl) this.textBox4).Left = 1f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox4.Text = "Grand Total";
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 0.75f;
    ((ARControl) this.textBox6).Height = 3f / 16f;
    ((ARControl) this.textBox6).Left = 1.75f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 25f / 16f;
    ((ARControl) this.textBox7).DataField = "Hours";
    ((ARControl) this.textBox7).Height = 3f / 16f;
    ((ARControl) this.textBox7).Left = 5.75f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = resourceManager.GetString("textBox7.OutputFormat");
    this.textBox7.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox7.Text = (string) null;
    ((ARControl) this.textBox7).Top = 0.0f;
    ((ARControl) this.textBox7).Width = 13f / 16f;
    ((ARControl) this.textBox8).DataField = "EquipmentCharges";
    ((ARControl) this.textBox8).Height = 3f / 16f;
    ((ARControl) this.textBox8).Left = 7.375f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = resourceManager.GetString("textBox8.OutputFormat");
    this.textBox8.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox8.Text = (string) null;
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 15f / 16f;
    ((ARControl) this.textBox9).DataField = "OtherCharges";
    ((ARControl) this.textBox9).Height = 3f / 16f;
    ((ARControl) this.textBox9).Left = 133f / 16f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = resourceManager.GetString("textBox9.OutputFormat");
    this.textBox9.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox9.Text = (string) null;
    ((ARControl) this.textBox9).Top = 0.0f;
    ((ARControl) this.textBox9).Width = 1.125f;
    ((ARControl) this.textBox25).DataField = "Total";
    ((ARControl) this.textBox25).Height = 3f / 16f;
    ((ARControl) this.textBox25).Left = 151f / 16f;
    ((ARControl) this.textBox25).Name = "textBox25";
    this.textBox25.OutputFormat = resourceManager.GetString("textBox25.OutputFormat");
    this.textBox25.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox25.Text = (string) null;
    ((ARControl) this.textBox25).Top = 0.0f;
    ((ARControl) this.textBox25).Width = 15f / 16f;
    ((ARControl) this.textBox28).DataField = "HourlyCharges";
    ((ARControl) this.textBox28).Height = 3f / 16f;
    ((ARControl) this.textBox28).Left = 105f / 16f;
    ((ARControl) this.textBox28).Name = "textBox28";
    this.textBox28.OutputFormat = resourceManager.GetString("textBox28.OutputFormat");
    this.textBox28.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox28.Text = (string) null;
    ((ARControl) this.textBox28).Top = 0.0f;
    ((ARControl) this.textBox28).Width = 13f / 16f;
    ((ARControl) this.textBox10).Height = 3f / 16f;
    ((ARControl) this.textBox10).Left = 53f / 16f;
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox10.Text = (string) null;
    ((ARControl) this.textBox10).Top = 0.0f;
    ((ARControl) this.textBox10).Width = 39f / 16f;
    ((ARControl) this.txtClaimID).DataField = "ClaimID";
    ((ARControl) this.txtClaimID).Height = 1f / 16f;
    ((ARControl) this.txtClaimID).Left = 0.0f;
    ((ARControl) this.txtClaimID).Name = "txtClaimID";
    this.txtClaimID.Style = "background-color: Gold; vertical-align: middle";
    ((ARControl) this.txtClaimID).Top = 0.0f;
    ((ARControl) this.txtClaimID).Visible = false;
    ((ARControl) this.txtClaimID).Width = 1f;
    ((SectionReport) this).MasterReport = false;
    ((SectionReport) this).PageSettings.Margins.Bottom = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Left = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Right = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Top = 0.3f;
    ((SectionReport) this).PageSettings.Orientation = (PageOrientation) 2;
    ((SectionReport) this).PageSettings.PaperHeight = 11f;
    ((SectionReport) this).PageSettings.PaperWidth = 8.5f;
    ((SectionReport) this).PrintWidth = 10.4f;
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1);
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((SectionReport) this).ReportStart += new EventHandler(this.ClaimTransactionReport_ReportStart);
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.textBox17).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.textBox25).EndInit();
    ((ISupportInitialize) this.textBox28).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this.txtClaimID).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
