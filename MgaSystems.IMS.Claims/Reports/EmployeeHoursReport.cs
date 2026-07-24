// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Reports.EmployeeHoursReport
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

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

[SecureReportResource("{E337BCE5-FC67-40f4-97AB-8C465C4938F2}", "Claims Employee Hours Report", "Claims Employee Hours Report", "Claims")]
public class EmployeeHoursReport : MGAReport, IReport, ISupportReportDictionary
{
  private DateTime _datefrom;
  private DateTime _dateto;
  private string _companyGuid;
  private string _inhouseAdjuster;
  private DataSet _ds;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Container components;
  private GroupHeader groupHeader1;
  private GroupFooter groupFooter1;
  private Label label1;
  private TextBox textBox1;
  private Label label2;
  private Label label3;
  private TextBox textBox2;
  private TextBox textBox3;
  private Label label5;
  private TextBox textBox4;
  private Label label6;
  private TextBox textBox5;
  private TextBox textBox9;
  private Label label17;
  private Label label7;
  private Label label8;
  private Label label9;
  private Label label16;
  private TextBox textBox13;
  private TextBox textBox12;
  private TextBox textBox14;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private Label label10;
  private Label label12;
  private Label label11;
  private Label label13;
  private Label label15;
  private TextBox textBox7;
  private TextBox textBox6;
  private TextBox textBox8;
  private Label label4;
  private TextBox textBox10;

  public EmployeeHoursReport() => this.InitializeComponent();

  public EmployeeHoursReport(
    DateTime datefrom,
    DateTime dateto,
    string companyGuid,
    string inhouseAdjuster)
  {
    this.InitializeComponent();
    this._datefrom = datefrom;
    this._dateto = dateto;
    this._companyGuid = companyGuid;
    this._inhouseAdjuster = inhouseAdjuster;
  }

  private void pageHeader_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.textBox9.Text = $"Employee Hours for {this._datefrom.ToShortDateString()} to {this._dateto.ToShortDateString()}";
    this.textBox1.Text = DateTime.Now.ToShortDateString();
    this.label2.Text = this._ds.Tables[0].Rows[0]["MGAName"].ToString();
    this.label3.Text = this._ds.Tables[0].Rows[0]["CompanyName"].ToString();
    this.label4.Text = this._ds.Tables[0].Rows[0]["AdjusterLabel"].ToString();
    this.textBox10.Text = this._ds.Tables[0].Rows[0]["Adjusters"].ToString();
  }

  private void EmployeeHoursReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spClaims_rptEmployeeHours", connection);
    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
    this._ds = new DataSet();
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Parameters.AddWithValue("@datefrom", (object) this._datefrom);
    selectCommand.Parameters.AddWithValue("@dateto", (object) this._dateto);
    if (!string.IsNullOrEmpty(this._companyGuid.ToString()))
      selectCommand.Parameters.AddWithValue("@companyGuid", (object) this._companyGuid);
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

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new DateRangePicker("Effective Date Range", false),
        (BaseReportControl) new GenericListBox("Company", "SELECT DISTINCT CompanyName AS Display,CompanyGuid as Value From tblCompanies  Order by CompanyName", "Value", "Display", true, typeof (Guid), true, false),
        (BaseReportControl) new GenericListBox("Adjuster", "SELECT DISTINCT tblUsers.FirstName + ' ' + tblUsers.LastName AS Display, tblClaims_Claim.InhouseAdjuster as Value From tblClaims_Claim inner join tblUsers on tblUsers.userguid = tblClaims_Claim.userguid Order by tblUsers.FirstName + ' ' + tblUsers.LastName", "Value", "Display", true, typeof (Guid), true, false)
      };
    }
  }

  public virtual bool IsThreaded => true;

  public virtual void ExportToExcel(string SaveFileTo) => ExcelExport.ToExcel(this._ds, SaveFileTo);

  private void groupFooter1_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.label16.Text = "Total ";
  }

  string[] ISupportReportDictionary.FieldDescriptions
  {
    get
    {
      return new string[10]
      {
        "Hours",
        "The number of hours entered by this user within the specified date range.",
        "Count",
        "The number of claims expenses entered by this user within the specified date range.",
        "New",
        "The number of new claims entered by this user within the specified date range.",
        "Company",
        "This is the company on the policy for which the hours where entered.",
        "User",
        "The user name who entered the claims and expenses."
      };
    }
  }

  string ISupportReportDictionary.GeneralDescription
  {
    get
    {
      return "This report provides you with a listing of hours worked broken out by employee. These hours are calculated based on the times entered by the user when entering un-allocated expenses.";
    }
  }

  string ISupportReportDictionary.ReportFriendlyName => "Claims Employee Hours Report";

  string[] ISupportReportDictionary.SearchCriteriaDescription
  {
    get
    {
      return new string[4]
      {
        "Date Range",
        "Limits the data returned based on the date the hours were entered. This field is required",
        "Company",
        "This search criteria is optional. This will further limit the result set to the company selected."
      };
    }
  }

  string[] ISupportReportDictionary.SortingAndTotalsDescription
  {
    get
    {
      return new string[2]
      {
        "Company",
        "The report is sorted and sub-totalled by company. The report has a grand total at the bottom for all companies."
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
    ResourceManager resourceManager = new ResourceManager(typeof (EmployeeHoursReport));
    this.pageHeader = new PageHeader();
    this.label1 = new Label();
    this.textBox1 = new TextBox();
    this.label2 = new Label();
    this.textBox9 = new TextBox();
    this.label3 = new Label();
    this.detail = new Detail();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.label5 = new Label();
    this.textBox4 = new TextBox();
    this.label6 = new Label();
    this.textBox5 = new TextBox();
    this.label17 = new Label();
    this.pageFooter = new PageFooter();
    this.groupHeader1 = new GroupHeader();
    this.groupFooter1 = new GroupFooter();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label16 = new Label();
    this.textBox13 = new TextBox();
    this.textBox12 = new TextBox();
    this.textBox14 = new TextBox();
    this.reportHeader1 = new ReportHeader();
    this.reportFooter1 = new ReportFooter();
    this.label10 = new Label();
    this.label12 = new Label();
    this.label11 = new Label();
    this.label13 = new Label();
    this.label15 = new Label();
    this.textBox7 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox8 = new TextBox();
    this.label4 = new Label();
    this.textBox10 = new TextBox();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.label17).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label16).BeginInit();
    ((ISupportInitialize) this.textBox13).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.textBox14).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.label12).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.label13).BeginInit();
    ((ISupportInitialize) this.label15).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.pageHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.label1,
      (ARControl) this.textBox1,
      (ARControl) this.label2,
      (ARControl) this.textBox9,
      (ARControl) this.label4,
      (ARControl) this.textBox10
    });
    this.pageHeader.Height = 1f;
    ((Section) this.pageHeader).Name = "pageHeader";
    ((Section) this.pageHeader).Format += new EventHandler(this.pageHeader_Format);
    ((ARControl) this.label1).Height = 3f / 16f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.0f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-family: Tahoma; font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.label1.Text = "Report Date:";
    ((ARControl) this.label1).Top = 0.375f;
    ((ARControl) this.label1).Width = 15f / 16f;
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 15f / 16f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.OutputFormat = resourceManager.GetString("textBox1.OutputFormat");
    this.textBox1.Style = "font-family: Tahoma; font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox1.Text = (string) null;
    ((ARControl) this.textBox1).Top = 0.375f;
    ((ARControl) this.textBox1).Width = 81f / 16f;
    ((ARControl) this.label2).Height = 3f / 16f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 0.0f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-family: Tahoma; font-size: 9.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label2.Text = "South Valley Claims";
    ((ARControl) this.label2).Top = 0.0f;
    ((ARControl) this.label2).Width = 125f / 16f;
    ((ARControl) this.textBox9).Height = 3f / 16f;
    ((ARControl) this.textBox9).Left = 0.0f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.Style = "font-family: Tahoma; font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox9.Text = (string) null;
    ((ARControl) this.textBox9).Top = 3f / 16f;
    ((ARControl) this.textBox9).Width = 125f / 16f;
    ((ARControl) this.label3).DataField = "CompanyName";
    ((ARControl) this.label3).Height = 3f / 16f;
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Left = 0.0f;
    ((ARControl) this.label3).Name = "label3";
    this.label3.Style = "font-family: Tahoma; font-size: 9.75pt; font-weight: bold; text-align: justify; vertical-align: middle; ddo-char-set: 0";
    this.label3.Text = "";
    ((ARControl) this.label3).Top = 0.0f;
    ((ARControl) this.label3).Width = 125f / 16f;
    this.detail.ColumnSpacing = 0.0f;
    ((Section) this.detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.label5,
      (ARControl) this.textBox4,
      (ARControl) this.label6,
      (ARControl) this.textBox5,
      (ARControl) this.label17
    });
    ((Section) this.detail).Height = 0.1666667f;
    ((Section) this.detail).Name = "detail";
    ((ARControl) this.textBox2).DataField = "UserName";
    ((ARControl) this.textBox2).Height = 3f / 16f;
    ((ARControl) this.textBox2).Left = 0.0f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 4.25f;
    ((ARControl) this.textBox3).DataField = "NewCount";
    ((ARControl) this.textBox3).Height = 3f / 16f;
    ((ARControl) this.textBox3).Left = 4.625f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.OutputFormat = resourceManager.GetString("textBox3.OutputFormat");
    this.textBox3.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 13f / 16f;
    ((ARControl) this.label5).Height = 3f / 16f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 87f / 16f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.label5.Text = "Count:";
    ((ARControl) this.label5).Top = 0.0f;
    ((ARControl) this.label5).Width = 7f / 16f;
    ((ARControl) this.textBox4).DataField = "TransactionCount";
    ((ARControl) this.textBox4).Height = 3f / 16f;
    ((ARControl) this.textBox4).Left = 5.875f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.OutputFormat = resourceManager.GetString("textBox4.OutputFormat");
    this.textBox4.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 0.875f;
    ((ARControl) this.label6).Height = 3f / 16f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 6.75f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.label6.Text = "Hours:";
    ((ARControl) this.label6).Top = 0.0f;
    ((ARControl) this.label6).Width = 7f / 16f;
    ((ARControl) this.textBox5).DataField = "TotalHours";
    ((ARControl) this.textBox5).Height = 3f / 16f;
    ((ARControl) this.textBox5).Left = 115f / 16f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = resourceManager.GetString("textBox5.OutputFormat");
    this.textBox5.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 11f / 16f;
    ((ARControl) this.label17).Height = 3f / 16f;
    this.label17.HyperLink = (string) null;
    ((ARControl) this.label17).Left = 4.25f;
    ((ARControl) this.label17).Name = "label17";
    this.label17.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.label17.Text = "New:";
    ((ARControl) this.label17).Top = 0.0f;
    ((ARControl) this.label17).Width = 0.375f;
    this.pageFooter.Height = 0.0f;
    ((Section) this.pageFooter).Name = "pageFooter";
    ((Section) this.groupHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.label3
    });
    this.groupHeader1.DataField = "CompanyName";
    this.groupHeader1.Height = 3f / 16f;
    ((Section) this.groupHeader1).Name = "groupHeader1";
    ((Section) this.groupFooter1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label9,
      (ARControl) this.label16,
      (ARControl) this.textBox13,
      (ARControl) this.textBox12,
      (ARControl) this.textBox14
    });
    this.groupFooter1.Height = 19f / 32f;
    ((Section) this.groupFooter1).Name = "groupFooter1";
    ((Section) this.groupFooter1).Format += new EventHandler(this.groupFooter1_Format);
    ((ARControl) this.label7).Height = 3f / 16f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 4.25f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label7.Text = "New:";
    ((ARControl) this.label7).Top = 3f / 16f;
    ((ARControl) this.label7).Width = 0.375f;
    ((ARControl) this.label8).Height = 3f / 16f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 87f / 16f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label8.Text = "Count:";
    ((ARControl) this.label8).Top = 3f / 16f;
    ((ARControl) this.label8).Width = 7f / 16f;
    ((ARControl) this.label9).Height = 3f / 16f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 6.75f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label9.Text = "Hours:";
    ((ARControl) this.label9).Top = 3f / 16f;
    ((ARControl) this.label9).Width = 7f / 16f;
    ((ARControl) this.label16).Height = 3f / 16f;
    this.label16.HyperLink = (string) null;
    ((ARControl) this.label16).Left = 0.0f;
    ((ARControl) this.label16).Name = "label16";
    this.label16.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label16.Text = "";
    ((ARControl) this.label16).Top = 3f / 16f;
    ((ARControl) this.label16).Width = 4.25f;
    ((ARControl) this.textBox13).DataField = "TransactionCount";
    ((ARControl) this.textBox13).Height = 3f / 16f;
    ((ARControl) this.textBox13).Left = 5.875f;
    ((ARControl) this.textBox13).Name = "textBox13";
    this.textBox13.OutputFormat = resourceManager.GetString("textBox13.OutputFormat");
    this.textBox13.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox13.SummaryGroup = "groupHeader1";
    this.textBox13.SummaryRunning = (SummaryRunning) 1;
    this.textBox13.SummaryType = (SummaryType) 3;
    this.textBox13.Text = (string) null;
    ((ARControl) this.textBox13).Top = 3f / 16f;
    ((ARControl) this.textBox13).Width = 0.875f;
    ((ARControl) this.textBox12).DataField = "NewCount";
    ((ARControl) this.textBox12).Height = 3f / 16f;
    ((ARControl) this.textBox12).Left = 4.625f;
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.OutputFormat = resourceManager.GetString("textBox12.OutputFormat");
    this.textBox12.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox12.SummaryGroup = "groupHeader1";
    this.textBox12.SummaryRunning = (SummaryRunning) 1;
    this.textBox12.SummaryType = (SummaryType) 3;
    this.textBox12.Text = (string) null;
    ((ARControl) this.textBox12).Top = 3f / 16f;
    ((ARControl) this.textBox12).Width = 13f / 16f;
    ((ARControl) this.textBox14).DataField = "TotalHours";
    ((ARControl) this.textBox14).Height = 3f / 16f;
    ((ARControl) this.textBox14).Left = 115f / 16f;
    ((ARControl) this.textBox14).Name = "textBox14";
    this.textBox14.OutputFormat = resourceManager.GetString("textBox14.OutputFormat");
    this.textBox14.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox14.SummaryGroup = "groupHeader1";
    this.textBox14.SummaryRunning = (SummaryRunning) 1;
    this.textBox14.SummaryType = (SummaryType) 3;
    this.textBox14.Text = (string) null;
    ((ARControl) this.textBox14).Top = 3f / 16f;
    ((ARControl) this.textBox14).Width = 11f / 16f;
    this.reportHeader1.Height = 0.0f;
    ((Section) this.reportHeader1).Name = "reportHeader1";
    ((Section) this.reportFooter1).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.label10,
      (ARControl) this.label12,
      (ARControl) this.label11,
      (ARControl) this.label13,
      (ARControl) this.label15,
      (ARControl) this.textBox7,
      (ARControl) this.textBox6,
      (ARControl) this.textBox8
    });
    this.reportFooter1.Height = 0.7083333f;
    ((Section) this.reportFooter1).Name = "reportFooter1";
    ((ARControl) this.label10).Height = 0.25f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 0.0f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "font-family: Tahoma; font-size: 11.25pt; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.label10.Text = "Totals All Companies";
    ((ARControl) this.label10).Top = 0.25f;
    ((ARControl) this.label10).Width = 7.875f;
    ((ARControl) this.label12).Height = 3f / 16f;
    this.label12.HyperLink = (string) null;
    ((ARControl) this.label12).Left = 87f / 16f;
    ((ARControl) this.label12).Name = "label12";
    this.label12.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label12.Text = "Count:";
    ((ARControl) this.label12).Top = 9f / 16f;
    ((ARControl) this.label12).Width = 7f / 16f;
    ((ARControl) this.label11).Height = 3f / 16f;
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Left = 4.25f;
    ((ARControl) this.label11).Name = "label11";
    this.label11.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label11.Text = "New:";
    ((ARControl) this.label11).Top = 9f / 16f;
    ((ARControl) this.label11).Width = 0.375f;
    ((ARControl) this.label13).Height = 3f / 16f;
    this.label13.HyperLink = (string) null;
    ((ARControl) this.label13).Left = 6.75f;
    ((ARControl) this.label13).Name = "label13";
    this.label13.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label13.Text = "Hours:";
    ((ARControl) this.label13).Top = 9f / 16f;
    ((ARControl) this.label13).Width = 7f / 16f;
    ((ARControl) this.label15).Height = 3f / 16f;
    this.label15.HyperLink = (string) null;
    ((ARControl) this.label15).Left = 0.0f;
    ((ARControl) this.label15).Name = "label15";
    this.label15.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label15.Text = "TOTALS:";
    ((ARControl) this.label15).Top = 9f / 16f;
    ((ARControl) this.label15).Width = 4.25f;
    ((ARControl) this.textBox7).DataField = "TransactionCount";
    ((ARControl) this.textBox7).Height = 3f / 16f;
    ((ARControl) this.textBox7).Left = 5.875f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = resourceManager.GetString("textBox7.OutputFormat");
    this.textBox7.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox7.SummaryGroup = "groupHeader1";
    this.textBox7.SummaryRunning = (SummaryRunning) 2;
    this.textBox7.SummaryType = (SummaryType) 1;
    this.textBox7.Text = (string) null;
    ((ARControl) this.textBox7).Top = 9f / 16f;
    ((ARControl) this.textBox7).Width = 0.875f;
    ((ARControl) this.textBox6).DataField = "NewCount";
    ((ARControl) this.textBox6).Height = 3f / 16f;
    ((ARControl) this.textBox6).Left = 4.625f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = resourceManager.GetString("textBox6.OutputFormat");
    this.textBox6.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox6.SummaryGroup = "groupHeader1";
    this.textBox6.SummaryRunning = (SummaryRunning) 2;
    this.textBox6.SummaryType = (SummaryType) 1;
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 9f / 16f;
    ((ARControl) this.textBox6).Width = 13f / 16f;
    ((ARControl) this.textBox8).DataField = "TotalHours";
    ((ARControl) this.textBox8).Height = 3f / 16f;
    ((ARControl) this.textBox8).Left = 115f / 16f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = resourceManager.GetString("textBox8.OutputFormat");
    this.textBox8.Style = "background-color: LightGrey; font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox8.SummaryGroup = "groupHeader1";
    this.textBox8.SummaryRunning = (SummaryRunning) 2;
    this.textBox8.SummaryType = (SummaryType) 1;
    this.textBox8.Text = (string) null;
    ((ARControl) this.textBox8).Top = 9f / 16f;
    ((ARControl) this.textBox8).Width = 11f / 16f;
    ((ARControl) this.label4).Height = 3f / 16f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 0.0f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "font-family: Tahoma; font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.label4.Text = "";
    ((ARControl) this.label4).Top = 0.562f;
    ((ARControl) this.label4).Width = 15f / 16f;
    ((ARControl) this.textBox10).Height = 3f / 16f;
    ((ARControl) this.textBox10).Left = 0.937f;
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.OutputFormat = resourceManager.GetString("textBox10.OutputFormat");
    this.textBox10.Style = "font-family: Tahoma; font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox10.Text = (string) null;
    ((ARControl) this.textBox10).Top = 0.562f;
    ((ARControl) this.textBox10).Width = 81f / 16f;
    ((SectionReport) this).MasterReport = false;
    ((SectionReport) this).PageSettings.Margins.Bottom = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Left = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Right = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Top = 0.3f;
    ((SectionReport) this).PageSettings.PaperHeight = 11f;
    ((SectionReport) this).PageSettings.PaperWidth = 8.5f;
    ((SectionReport) this).PrintWidth = 7.9f;
    ((SectionReport) this).Sections.Add((Section) this.reportHeader1);
    ((SectionReport) this).Sections.Add((Section) this.pageHeader);
    ((SectionReport) this).Sections.Add((Section) this.groupHeader1);
    ((SectionReport) this).Sections.Add((Section) this.detail);
    ((SectionReport) this).Sections.Add((Section) this.groupFooter1);
    ((SectionReport) this).Sections.Add((Section) this.pageFooter);
    ((SectionReport) this).Sections.Add((Section) this.reportFooter1);
    ((SectionReport) this).ReportStart += new EventHandler(this.EmployeeHoursReport_ReportStart);
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.label17).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label16).EndInit();
    ((ISupportInitialize) this.textBox13).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.textBox14).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.label12).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.label13).EndInit();
    ((ISupportInitialize) this.label15).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
