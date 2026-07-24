// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Reports.OpenClaimsReport
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Claims.Reports;

[SecureReportResource("{88DBA873-232C-4288-9BEE-1DC82C21067F}", "Open Claims Report", "Open Claims Report", "Claims")]
public class OpenClaimsReport : MGAReport, IReport, ISupportReportDictionary
{
  private DateTime _datefrom;
  private DateTime _dateto;
  private string _companyGuid;
  private string _coverageTypeId;
  private string _inhouseAdjuster;
  private DataSet _ds;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Container components;
  private Label label1;
  private TextBox textBox1;
  private Label label2;
  private Label label3;
  private TextBox textBox17;
  private GroupHeader groupHeader1;
  private Label label4;
  private Label label5;
  private Label label6;
  private Label label8;
  private Label label7;
  private Label label9;
  private Label label10;
  private Label label11;
  private Label label12;
  private Label label13;
  private Label label14;
  private Label label15;
  private Label label16;
  private GroupFooter groupFooter1;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox textBox8;
  private TextBox textBox9;
  private TextBox textBox10;
  private TextBox textBox12;
  private Label label17;
  private TextBox textBox16;
  private TextBox textBox13;
  private TextBox textBox14;
  private TextBox textBox15;
  private TextBox textBox11;
  private TextBox textBox18;
  private TextBox textBox19;
  private TextBox textBox20;
  private TextBox textBox22;
  private Label label20;
  private TextBox textBox23;
  private TextBox textBox21;
  private Label label18;
  private TextBox textBox24;

  public OpenClaimsReport() => this.InitializeComponent();

  public OpenClaimsReport(
    DateTime datefrom,
    DateTime dateto,
    string companyGuid,
    string coverageTypeId,
    string inhouseAdjuster)
  {
    this.InitializeComponent();
    this._datefrom = datefrom;
    this._dateto = dateto;
    this._companyGuid = companyGuid;
    this._coverageTypeId = coverageTypeId;
    this._inhouseAdjuster = inhouseAdjuster;
  }

  private void pageHeader_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.textBox17.Text = $"Open Claims Report for {this._datefrom.ToShortDateString()}  to {this._dateto.ToShortDateString()}";
    this.label2.Text = this._ds.Tables[0].Rows[0]["MGAName"].ToString();
    this.label3.Text = this._ds.Tables[0].Rows[0]["CompanyName"].ToString();
    this.label18.Text = this._ds.Tables[0].Rows[0]["AdjusterLabel"].ToString();
    this.textBox24.Text = this._ds.Tables[0].Rows[0]["Adjusters"].ToString();
    this.textBox1.Text = DateTime.Now.ToShortDateString();
  }

  private void groupFooter1_Format(object sender, EventArgs e)
  {
    this.textBox23.Value = (object) (Convert.ToDecimal(this.textBox11.Value) + Convert.ToDecimal(this.textBox18.Value) + Convert.ToDecimal(this.textBox19.Value));
    if (this._ds.Tables[0].Rows.Count > 0)
      this.textBox22.Value = (object) this._ds.Tables[0].Rows.Count;
    else
      this.textBox22.Value = (object) 0;
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[4]
      {
        (BaseReportControl) new DateRangePicker("Effective Date Range", false),
        (BaseReportControl) new GenericListBox("Company", "SELECT DISTINCT CompanyName AS Display,CompanyGuid as Value From tblCompanies  Order by CompanyName", "Value", "Display", true, typeof (Guid), true, false, 200),
        (BaseReportControl) new GenericListBox("Coverage Type ", "SELECT DISTINCT CoverageType AS Display, CoverageTypeId AS Value FROM lstClaims_CoverageTypes ORDER BY CoverageType", "Value", "Display", true, typeof (int), true, false),
        (BaseReportControl) new GenericListBox("Adjuster", "SELECT DISTINCT tblUsers.FirstName + ' ' + tblUsers.LastName AS Display, tblClaims_Claim.InhouseAdjuster as Value From tblClaims_Claim inner join tblUsers on tblUsers.userguid = tblClaims_Claim.InhouseAdjuster Order by tblUsers.FirstName + ' ' + tblUsers.LastName", "Value", "Display", true, typeof (Guid), true, false)
      };
    }
  }

  public virtual bool IsThreaded => true;

  public virtual void ExportToExcel(string SaveFileTo) => ExcelExport.ToExcel(this._ds, SaveFileTo);

  private void OpenClaimsReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    string cmdText = !SystemSettings.KeyExists("Claims.OpenClaimsReport2") ? "spClaims_rptOpenClaims" : SystemSettings.GetStringSetting("Claims.OpenClaimsReport2");
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand(cmdText, connection);
    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
    this._ds = new DataSet();
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Parameters.AddWithValue("@datefrom", (object) this._datefrom);
    selectCommand.Parameters.AddWithValue("@dateto", (object) this._dateto);
    if (!string.IsNullOrEmpty(this._companyGuid.ToString()))
      selectCommand.Parameters.AddWithValue("@companyGuid", (object) this._companyGuid);
    if (!string.IsNullOrEmpty(this._coverageTypeId.ToString()))
      selectCommand.Parameters.AddWithValue("@coverageTypeId", (object) this._companyGuid);
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
    ((SectionReport) this).DataSource = (object) this._ds.Tables[0];
  }

  string[] ISupportReportDictionary.FieldDescriptions
  {
    get
    {
      return new string[20]
      {
        "Unallocated Paid",
        "Displays the amount of un-allocated expense that where paid within the specified date range.",
        "Allocated Remaining Reserve",
        "Shows the amount of the remaining allocated expense reserves within the specified date range.",
        "Allocated Paid",
        "Displays the sum of the payments made against allocated expense reserves within the specified date range.",
        "Allocated Reserved",
        "Shows the sum of the amount reserved for allocated expenses within the specified date range.",
        "Claims Remaining Reserve",
        "Shows the amount of the remaining indemnity reserves within the specified date range. ",
        "Claims Paid",
        "Displays the sum of the payments made against indemnity reserves within the specified date range.",
        "Claims Reserved",
        "Shows the sum of the amount reserved for indemnity within the specified date range.",
        "Loss Date",
        "The date of loss.",
        "Insured",
        "Shows the insured name on the policy.",
        "Policy Number",
        "Displays the policy number."
      };
    }
  }

  string ISupportReportDictionary.GeneralDescription
  {
    get
    {
      return "This report provides you with a listing all remaining reserves within the specified data range for all open claims.";
    }
  }

  string ISupportReportDictionary.ReportFriendlyName => "Open Claims Report";

  string[] ISupportReportDictionary.SearchCriteriaDescription
  {
    get
    {
      return new string[6]
      {
        "Date Range",
        "Limits the data returned to losses within the specified date range. This field is required.",
        "Company",
        "This search criteria is optional. This will further limit the result set to the company selected. Alternatively, you choose to run the report for all companies.",
        "Coverage Type",
        "This search criteria is optional. This will further limit the result set to the coverage type selected. Alternatively, you choose to run the report for all coverage types."
      };
    }
  }

  string[] ISupportReportDictionary.SortingAndTotalsDescription
  {
    get
    {
      return new string[4]
      {
        "Grand Total",
        "Shows the sum of all loss amounts listed.",
        "Claim Reserved + Allocated Reserve + Unallocated Paid",
        "Shows the grand total for all listed items."
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
    ResourceManager resourceManager = new ResourceManager(typeof (OpenClaimsReport));
    this.pageHeader = new PageHeader();
    this.label1 = new Label();
    this.textBox1 = new TextBox();
    this.label2 = new Label();
    this.label3 = new Label();
    this.textBox17 = new TextBox();
    this.detail = new Detail();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.textBox9 = new TextBox();
    this.textBox10 = new TextBox();
    this.textBox12 = new TextBox();
    this.pageFooter = new PageFooter();
    this.groupHeader1 = new GroupHeader();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label8 = new Label();
    this.label7 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.label11 = new Label();
    this.label12 = new Label();
    this.label13 = new Label();
    this.label14 = new Label();
    this.label15 = new Label();
    this.label16 = new Label();
    this.groupFooter1 = new GroupFooter();
    this.label17 = new Label();
    this.textBox16 = new TextBox();
    this.textBox13 = new TextBox();
    this.textBox14 = new TextBox();
    this.textBox15 = new TextBox();
    this.textBox11 = new TextBox();
    this.textBox18 = new TextBox();
    this.textBox19 = new TextBox();
    this.textBox20 = new TextBox();
    this.textBox22 = new TextBox();
    this.label20 = new Label();
    this.textBox23 = new TextBox();
    this.textBox21 = new TextBox();
    this.label18 = new Label();
    this.textBox24 = new TextBox();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.textBox17).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.label12).BeginInit();
    ((ISupportInitialize) this.label13).BeginInit();
    ((ISupportInitialize) this.label14).BeginInit();
    ((ISupportInitialize) this.label15).BeginInit();
    ((ISupportInitialize) this.label16).BeginInit();
    ((ISupportInitialize) this.label17).BeginInit();
    ((ISupportInitialize) this.textBox16).BeginInit();
    ((ISupportInitialize) this.textBox13).BeginInit();
    ((ISupportInitialize) this.textBox14).BeginInit();
    ((ISupportInitialize) this.textBox15).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.textBox18).BeginInit();
    ((ISupportInitialize) this.textBox19).BeginInit();
    ((ISupportInitialize) this.textBox20).BeginInit();
    ((ISupportInitialize) this.textBox22).BeginInit();
    ((ISupportInitialize) this.label20).BeginInit();
    ((ISupportInitialize) this.textBox23).BeginInit();
    ((ISupportInitialize) this.textBox21).BeginInit();
    ((ISupportInitialize) this.label18).BeginInit();
    ((ISupportInitialize) this.textBox24).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.pageHeader).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.label1,
      (ARControl) this.textBox1,
      (ARControl) this.label2,
      (ARControl) this.label3,
      (ARControl) this.textBox17,
      (ARControl) this.label18,
      (ARControl) this.textBox24
    });
    this.pageHeader.Height = 1.104167f;
    ((Section) this.pageHeader).Name = "pageHeader";
    ((Section) this.pageHeader).Format += new EventHandler(this.pageHeader_Format);
    ((ARControl) this.label1).Height = 3f / 16f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.0f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-family: Tahoma; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    this.label1.Text = "Report Date:";
    ((ARControl) this.label1).Top = 9f / 16f;
    ((ARControl) this.label1).Width = 15f / 16f;
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 15f / 16f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.OutputFormat = resourceManager.GetString("textBox1.OutputFormat");
    this.textBox1.Style = "font-family: Tahoma; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox1.Text = (string) null;
    ((ARControl) this.textBox1).Top = 9f / 16f;
    ((ARControl) this.textBox1).Width = 59f / 16f;
    ((ARControl) this.label2).Height = 0.188f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 0.0f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-family: Tahoma; font-size: 9.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label2.Text = "South Valley Claims";
    ((ARControl) this.label2).Top = 0.0f;
    ((ARControl) this.label2).Width = 7.9f;
    ((ARControl) this.label3).Height = 0.188f;
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Left = 0.0f;
    ((ARControl) this.label3).Name = "label3";
    this.label3.Style = "font-family: Tahoma; font-size: 9.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label3.Text = "Company Name";
    ((ARControl) this.label3).Top = 3f / 16f;
    ((ARControl) this.label3).Width = 7.9f;
    ((ARControl) this.textBox17).Height = 0.188f;
    ((ARControl) this.textBox17).Left = 0.0f;
    ((ARControl) this.textBox17).Name = "textBox17";
    this.textBox17.Style = "font-family: Tahoma; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox17.Text = (string) null;
    ((ARControl) this.textBox17).Top = 0.375f;
    ((ARControl) this.textBox17).Width = 7.9f;
    this.detail.ColumnSpacing = 0.0f;
    ((Section) this.detail).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8,
      (ARControl) this.textBox9,
      (ARControl) this.textBox10,
      (ARControl) this.textBox12
    });
    ((Section) this.detail).Height = 0.1458333f;
    ((Section) this.detail).Name = "detail";
    ((ARControl) this.textBox2).DataField = "PolicyNumber";
    ((ARControl) this.textBox2).Height = 0.125f;
    ((ARControl) this.textBox2).Left = 0.0f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "font-family: Tahoma; font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 1.125f;
    ((ARControl) this.textBox3).DataField = "InsuredName";
    ((ARControl) this.textBox3).Height = 0.125f;
    ((ARControl) this.textBox3).Left = 1.125f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "font-family: Tahoma; font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 1.625f;
    ((ARControl) this.textBox4).DataField = "LossDate";
    ((ARControl) this.textBox4).Height = 0.125f;
    ((ARControl) this.textBox4).Left = 2.75f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.OutputFormat = resourceManager.GetString("textBox4.OutputFormat");
    this.textBox4.Style = "font-family: Tahoma; font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 0.625f;
    ((ARControl) this.textBox5).DataField = "ClaimsReserved";
    ((ARControl) this.textBox5).Height = 0.125f;
    ((ARControl) this.textBox5).Left = 3.375f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = resourceManager.GetString("textBox5.OutputFormat");
    this.textBox5.Style = "font-family: Tahoma; font-size: 6.75pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 0.625f;
    ((ARControl) this.textBox6).DataField = "ClaimsPaid";
    ((ARControl) this.textBox6).Height = 0.125f;
    ((ARControl) this.textBox6).Left = 4f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = resourceManager.GetString("textBox6.OutputFormat");
    this.textBox6.Style = "font-family: Tahoma; font-size: 6.75pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 0.625f;
    ((ARControl) this.textBox7).DataField = "ClaimsReserveRemaining";
    ((ARControl) this.textBox7).Height = 0.125f;
    ((ARControl) this.textBox7).Left = 4.625f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = resourceManager.GetString("textBox7.OutputFormat");
    this.textBox7.Style = "font-family: Tahoma; font-size: 6.75pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox7.Text = (string) null;
    ((ARControl) this.textBox7).Top = 0.0f;
    ((ARControl) this.textBox7).Width = 0.625f;
    ((ARControl) this.textBox8).DataField = "AllocatedReserved";
    ((ARControl) this.textBox8).Height = 0.125f;
    ((ARControl) this.textBox8).Left = 5.25f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = resourceManager.GetString("textBox8.OutputFormat");
    this.textBox8.Style = "font-family: Tahoma; font-size: 6.75pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox8.Text = (string) null;
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 0.625f;
    ((ARControl) this.textBox9).DataField = "AllocatedPaid";
    ((ARControl) this.textBox9).Height = 0.125f;
    ((ARControl) this.textBox9).Left = 5.875f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = resourceManager.GetString("textBox9.OutputFormat");
    this.textBox9.Style = "font-family: Tahoma; font-size: 6.75pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox9.Text = (string) null;
    ((ARControl) this.textBox9).Top = 0.0f;
    ((ARControl) this.textBox9).Width = 0.625f;
    ((ARControl) this.textBox10).DataField = "AllocatedReserveRemaining";
    ((ARControl) this.textBox10).Height = 0.125f;
    ((ARControl) this.textBox10).Left = 6.5f;
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.OutputFormat = resourceManager.GetString("textBox10.OutputFormat");
    this.textBox10.Style = "font-family: Tahoma; font-size: 6.75pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox10.Text = (string) null;
    ((ARControl) this.textBox10).Top = 0.0f;
    ((ARControl) this.textBox10).Width = 0.625f;
    ((ARControl) this.textBox12).DataField = "UnAllocated";
    ((ARControl) this.textBox12).Height = 0.125f;
    ((ARControl) this.textBox12).Left = 7.125f;
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.OutputFormat = resourceManager.GetString("textBox12.OutputFormat");
    this.textBox12.Style = "font-family: Tahoma; font-size: 6.75pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox12.Text = (string) null;
    ((ARControl) this.textBox12).Top = 0.0f;
    ((ARControl) this.textBox12).Width = 0.75f;
    this.pageFooter.Height = 0.0f;
    ((Section) this.pageFooter).Name = "pageFooter";
    ((Section) this.groupHeader1).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.label4,
      (ARControl) this.label5,
      (ARControl) this.label6,
      (ARControl) this.label8,
      (ARControl) this.label7,
      (ARControl) this.label9,
      (ARControl) this.label10,
      (ARControl) this.label11,
      (ARControl) this.label12,
      (ARControl) this.label13,
      (ARControl) this.label14,
      (ARControl) this.label15,
      (ARControl) this.label16
    });
    this.groupHeader1.Height = 7f / 16f;
    ((Section) this.groupHeader1).Name = "groupHeader1";
    ((ARControl) this.label4).Height = 0.25f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 0.0f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.label4.Text = "Policy Number";
    ((ARControl) this.label4).Top = 3f / 16f;
    ((ARControl) this.label4).Width = 1.125f;
    ((ARControl) this.label5).Height = 0.25f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 1.125f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.label5.Text = "Insured Name";
    ((ARControl) this.label5).Top = 3f / 16f;
    ((ARControl) this.label5).Width = 1.625f;
    ((ARControl) this.label6).Height = 0.25f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 2.75f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.label6.Text = "Loss Date";
    ((ARControl) this.label6).Top = 3f / 16f;
    ((ARControl) this.label6).Width = 0.625f;
    ((ARControl) this.label8).Height = 3f / 16f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 3.375f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.label8.Text = "Claims";
    ((ARControl) this.label8).Top = 0.0f;
    ((ARControl) this.label8).Width = 1.875f;
    ((ARControl) this.label7).Height = 0.25f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 3.375f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.label7.Text = "Reserved";
    ((ARControl) this.label7).Top = 3f / 16f;
    ((ARControl) this.label7).Width = 0.625f;
    ((ARControl) this.label9).Height = 0.25f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 4f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.label9.Text = "Paid";
    ((ARControl) this.label9).Top = 3f / 16f;
    ((ARControl) this.label9).Width = 0.625f;
    ((ARControl) this.label10).Height = 0.25f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 4.625f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.label10.Text = "Remaining Reserve";
    ((ARControl) this.label10).Top = 3f / 16f;
    ((ARControl) this.label10).Width = 0.625f;
    ((ARControl) this.label11).Height = 3f / 16f;
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Left = 5.25f;
    ((ARControl) this.label11).Name = "label11";
    this.label11.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.label11.Text = "Allocated";
    ((ARControl) this.label11).Top = 0.0f;
    ((ARControl) this.label11).Width = 1.875f;
    ((ARControl) this.label12).Height = 0.25f;
    this.label12.HyperLink = (string) null;
    ((ARControl) this.label12).Left = 5.25f;
    ((ARControl) this.label12).Name = "label12";
    this.label12.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.label12.Text = "Reserved";
    ((ARControl) this.label12).Top = 3f / 16f;
    ((ARControl) this.label12).Width = 0.625f;
    ((ARControl) this.label13).Height = 0.25f;
    this.label13.HyperLink = (string) null;
    ((ARControl) this.label13).Left = 5.875f;
    ((ARControl) this.label13).Name = "label13";
    this.label13.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.label13.Text = "Paid";
    ((ARControl) this.label13).Top = 3f / 16f;
    ((ARControl) this.label13).Width = 0.625f;
    ((ARControl) this.label14).Height = 0.25f;
    this.label14.HyperLink = (string) null;
    ((ARControl) this.label14).Left = 6.5f;
    ((ARControl) this.label14).Name = "label14";
    this.label14.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.label14.Text = "Remaining Reserve";
    ((ARControl) this.label14).Top = 3f / 16f;
    ((ARControl) this.label14).Width = 0.625f;
    ((ARControl) this.label15).Height = 3f / 16f;
    this.label15.HyperLink = (string) null;
    ((ARControl) this.label15).Left = 7.125f;
    ((ARControl) this.label15).Name = "label15";
    this.label15.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.label15.Text = "Unallocated";
    ((ARControl) this.label15).Top = 0.0f;
    ((ARControl) this.label15).Width = 0.75f;
    ((ARControl) this.label16).Height = 0.25f;
    this.label16.HyperLink = (string) null;
    ((ARControl) this.label16).Left = 7.125f;
    ((ARControl) this.label16).Name = "label16";
    this.label16.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.label16.Text = "Paid";
    ((ARControl) this.label16).Top = 3f / 16f;
    ((ARControl) this.label16).Width = 0.75f;
    ((Section) this.groupFooter1).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.label17,
      (ARControl) this.textBox16,
      (ARControl) this.textBox13,
      (ARControl) this.textBox14,
      (ARControl) this.textBox15,
      (ARControl) this.textBox11,
      (ARControl) this.textBox18,
      (ARControl) this.textBox19,
      (ARControl) this.textBox20,
      (ARControl) this.textBox22,
      (ARControl) this.label20,
      (ARControl) this.textBox23,
      (ARControl) this.textBox21
    });
    this.groupFooter1.Height = 7f / 16f;
    ((Section) this.groupFooter1).Name = "groupFooter1";
    ((Section) this.groupFooter1).Format += new EventHandler(this.groupFooter1_Format);
    ((ARControl) this.label17).Height = 0.125f;
    this.label17.HyperLink = (string) null;
    ((ARControl) this.label17).Left = 0.0f;
    ((ARControl) this.label17).Name = "label17";
    this.label17.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label17.Text = "Total Open Claims";
    ((ARControl) this.label17).Top = 5f / 16f;
    ((ARControl) this.label17).Width = 1f;
    ((ARControl) this.textBox16).DataField = "AllocatedPaid";
    ((ARControl) this.textBox16).Height = 3f / 16f;
    ((ARControl) this.textBox16).Left = 5.875f;
    ((ARControl) this.textBox16).Name = "textBox16";
    this.textBox16.OutputFormat = resourceManager.GetString("textBox16.OutputFormat");
    this.textBox16.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox16.SummaryGroup = "groupHeader1";
    this.textBox16.SummaryRunning = (SummaryRunning) 1;
    this.textBox16.SummaryType = (SummaryType) 3;
    this.textBox16.Text = (string) null;
    ((ARControl) this.textBox16).Top = 0.0f;
    ((ARControl) this.textBox16).Width = 0.625f;
    ((ARControl) this.textBox13).DataField = "ClaimsPaid";
    ((ARControl) this.textBox13).Height = 3f / 16f;
    ((ARControl) this.textBox13).Left = 4f;
    ((ARControl) this.textBox13).Name = "textBox13";
    this.textBox13.OutputFormat = resourceManager.GetString("textBox13.OutputFormat");
    this.textBox13.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox13.SummaryGroup = "groupHeader1";
    this.textBox13.SummaryRunning = (SummaryRunning) 1;
    this.textBox13.SummaryType = (SummaryType) 3;
    this.textBox13.Text = (string) null;
    ((ARControl) this.textBox13).Top = 0.0f;
    ((ARControl) this.textBox13).Width = 0.625f;
    ((ARControl) this.textBox14).DataField = "ClaimsReserveRemaining";
    ((ARControl) this.textBox14).Height = 3f / 16f;
    ((ARControl) this.textBox14).Left = 4.625f;
    ((ARControl) this.textBox14).Name = "textBox14";
    this.textBox14.OutputFormat = resourceManager.GetString("textBox14.OutputFormat");
    this.textBox14.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox14.SummaryGroup = "groupHeader1";
    this.textBox14.SummaryRunning = (SummaryRunning) 1;
    this.textBox14.SummaryType = (SummaryType) 3;
    this.textBox14.Text = (string) null;
    ((ARControl) this.textBox14).Top = 0.0f;
    ((ARControl) this.textBox14).Width = 0.625f;
    ((ARControl) this.textBox15).DataField = "AllocatedReserved";
    ((ARControl) this.textBox15).Height = 3f / 16f;
    ((ARControl) this.textBox15).Left = 5.25f;
    ((ARControl) this.textBox15).Name = "textBox15";
    this.textBox15.OutputFormat = resourceManager.GetString("textBox15.OutputFormat");
    this.textBox15.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox15.SummaryGroup = "groupHeader1";
    this.textBox15.SummaryRunning = (SummaryRunning) 1;
    this.textBox15.SummaryType = (SummaryType) 3;
    this.textBox15.Text = (string) null;
    ((ARControl) this.textBox15).Top = 0.0f;
    ((ARControl) this.textBox15).Width = 0.625f;
    ((ARControl) this.textBox11).DataField = "ClaimsReserved";
    ((ARControl) this.textBox11).Height = 3f / 16f;
    ((ARControl) this.textBox11).Left = 3.375f;
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.OutputFormat = resourceManager.GetString("textBox11.OutputFormat");
    this.textBox11.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox11.SummaryGroup = "groupHeader1";
    this.textBox11.SummaryRunning = (SummaryRunning) 1;
    this.textBox11.SummaryType = (SummaryType) 3;
    this.textBox11.Text = (string) null;
    ((ARControl) this.textBox11).Top = 0.0f;
    ((ARControl) this.textBox11).Width = 0.625f;
    ((ARControl) this.textBox18).DataField = "AllocatedReserveRemaining";
    ((ARControl) this.textBox18).Height = 3f / 16f;
    ((ARControl) this.textBox18).Left = 6.5f;
    ((ARControl) this.textBox18).Name = "textBox18";
    this.textBox18.OutputFormat = resourceManager.GetString("textBox18.OutputFormat");
    this.textBox18.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox18.SummaryGroup = "groupHeader1";
    this.textBox18.SummaryRunning = (SummaryRunning) 1;
    this.textBox18.SummaryType = (SummaryType) 3;
    this.textBox18.Text = (string) null;
    ((ARControl) this.textBox18).Top = 0.0f;
    ((ARControl) this.textBox18).Width = 0.625f;
    ((ARControl) this.textBox19).DataField = "UnAllocated";
    ((ARControl) this.textBox19).Height = 3f / 16f;
    ((ARControl) this.textBox19).Left = 7.125f;
    ((ARControl) this.textBox19).Name = "textBox19";
    this.textBox19.OutputFormat = resourceManager.GetString("textBox19.OutputFormat");
    this.textBox19.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox19.SummaryGroup = "groupHeader1";
    this.textBox19.SummaryRunning = (SummaryRunning) 1;
    this.textBox19.SummaryType = (SummaryType) 3;
    this.textBox19.Text = (string) null;
    ((ARControl) this.textBox19).Top = 0.0f;
    ((ARControl) this.textBox19).Width = 0.75f;
    ((ARControl) this.textBox20).Height = 3f / 16f;
    ((ARControl) this.textBox20).Left = 1.625f;
    ((ARControl) this.textBox20).Name = "textBox20";
    this.textBox20.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 6.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox20.Text = (string) null;
    ((ARControl) this.textBox20).Top = 0.0f;
    ((ARControl) this.textBox20).Width = 1.75f;
    ((ARControl) this.textBox22).Height = 0.125f;
    ((ARControl) this.textBox22).Left = 1f;
    ((ARControl) this.textBox22).Name = "textBox22";
    this.textBox22.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox22.Text = (string) null;
    ((ARControl) this.textBox22).Top = 5f / 16f;
    ((ARControl) this.textBox22).Width = 0.875f;
    ((ARControl) this.label20).Height = 0.125f;
    this.label20.HyperLink = (string) null;
    ((ARControl) this.label20).Left = 1.875f;
    ((ARControl) this.label20).Name = "label20";
    this.label20.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label20.Text = "Claim Reserved + Allocated Reserve + Unallocated Paid ";
    ((ARControl) this.label20).Top = 5f / 16f;
    ((ARControl) this.label20).Width = 47f / 16f;
    ((ARControl) this.textBox23).DataField = "AllocatedReserved";
    ((ARControl) this.textBox23).Height = 0.125f;
    ((ARControl) this.textBox23).Left = 77f / 16f;
    ((ARControl) this.textBox23).Name = "textBox23";
    this.textBox23.OutputFormat = resourceManager.GetString("textBox23.OutputFormat");
    this.textBox23.Style = "font-family: Tahoma; font-size: 6.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox23.SummaryGroup = "groupHeader1";
    this.textBox23.SummaryRunning = (SummaryRunning) 1;
    this.textBox23.SummaryType = (SummaryType) 3;
    this.textBox23.Text = (string) null;
    ((ARControl) this.textBox23).Top = 5f / 16f;
    ((ARControl) this.textBox23).Width = 1.875f;
    ((ARControl) this.textBox21).Height = 3f / 16f;
    ((ARControl) this.textBox21).Left = 0.0f;
    ((ARControl) this.textBox21).Name = "textBox21";
    this.textBox21.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 6.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox21.Text = (string) null;
    ((ARControl) this.textBox21).Top = 0.0f;
    ((ARControl) this.textBox21).Width = 1.75f;
    ((ARControl) this.label18).Height = 3f / 16f;
    this.label18.HyperLink = (string) null;
    ((ARControl) this.label18).Left = 0.0f;
    ((ARControl) this.label18).Name = "label18";
    this.label18.Style = "font-family: Tahoma; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    this.label18.Text = "";
    ((ARControl) this.label18).Top = 0.7500001f;
    ((ARControl) this.label18).Width = 15f / 16f;
    ((ARControl) this.textBox24).Height = 3f / 16f;
    ((ARControl) this.textBox24).Left = 0.937f;
    ((ARControl) this.textBox24).Name = "textBox24";
    this.textBox24.OutputFormat = resourceManager.GetString("textBox24.OutputFormat");
    this.textBox24.Style = "font-family: Tahoma; font-size: 9.75pt; vertical-align: middle; ddo-char-set: 0";
    ((ARControl) this.textBox24).Top = 0.7500001f;
    ((ARControl) this.textBox24).Width = 59f / 16f;
    ((SectionReport) this).MasterReport = false;
    ((SectionReport) this).PageSettings.Margins.Bottom = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Left = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Right = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Top = 0.3f;
    ((SectionReport) this).PageSettings.PaperHeight = 11f;
    ((SectionReport) this).PageSettings.PaperWidth = 8.5f;
    ((SectionReport) this).PrintWidth = 7.9f;
    ((SectionReport) this).Sections.Add((Section) this.pageHeader);
    ((SectionReport) this).Sections.Add((Section) this.groupHeader1);
    ((SectionReport) this).Sections.Add((Section) this.detail);
    ((SectionReport) this).Sections.Add((Section) this.groupFooter1);
    ((SectionReport) this).Sections.Add((Section) this.pageFooter);
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((SectionReport) this).ReportStart += new EventHandler(this.OpenClaimsReport_ReportStart);
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.textBox17).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.label12).EndInit();
    ((ISupportInitialize) this.label13).EndInit();
    ((ISupportInitialize) this.label14).EndInit();
    ((ISupportInitialize) this.label15).EndInit();
    ((ISupportInitialize) this.label16).EndInit();
    ((ISupportInitialize) this.label17).EndInit();
    ((ISupportInitialize) this.textBox16).EndInit();
    ((ISupportInitialize) this.textBox13).EndInit();
    ((ISupportInitialize) this.textBox14).EndInit();
    ((ISupportInitialize) this.textBox15).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.textBox18).EndInit();
    ((ISupportInitialize) this.textBox19).EndInit();
    ((ISupportInitialize) this.textBox20).EndInit();
    ((ISupportInitialize) this.textBox22).EndInit();
    ((ISupportInitialize) this.label20).EndInit();
    ((ISupportInitialize) this.textBox23).EndInit();
    ((ISupportInitialize) this.textBox21).EndInit();
    ((ISupportInitialize) this.label18).EndInit();
    ((ISupportInitialize) this.textBox24).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
