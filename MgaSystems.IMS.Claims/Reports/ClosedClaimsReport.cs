// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Reports.ClosedClaimsReport
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
using System.Diagnostics;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Claims.Reports;

[SecureReportResource("{A4CAE832-037E-448a-9535-CB6F909121FE}", "Closed Claims Report", "Closed Claims", "Claims")]
public class ClosedClaimsReport : MGAReport, IReport, ISupportReportDictionary
{
  private DateTime _datefrom;
  private DateTime _dateto;
  private string _companyGuid;
  private DataSet _ds;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Container components;
  private Label label1;
  private Label label2;
  private TextBox textBox1;
  private Label label3;
  private GroupHeader groupHeader1;
  private GroupFooter groupFooter1;
  private Label label4;
  private Label label5;
  private Label label7;
  private Label label8;
  private Label label9;
  private Label label10;
  private Label label12;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private Label label13;
  private TextBox textBox5;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox textBox8;
  private TextBox textBox11;
  private TextBox textBox16;
  private TextBox textBox14;
  private TextBox textBox13;
  private TextBox textBox12;
  private TextBox textBox15;
  private TextBox textBox9;
  private Label label6;

  public ClosedClaimsReport() => this.InitializeComponent();

  public ClosedClaimsReport(DateTime datefrom, DateTime dateto, string companyGuid)
  {
    this.InitializeComponent();
    this._datefrom = datefrom;
    this._dateto = dateto;
    this._companyGuid = companyGuid;
  }

  private void pageHeader_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.textBox16.Text = $"Closed Claims  for  {this._datefrom.ToShortDateString()} to {this._dateto.ToShortDateString()}";
    this.textBox1.Text = DateTime.Now.ToShortDateString();
    this.label2.Text = this._ds.Tables[0].Rows[0]["MGAName"].ToString();
    this.label3.Text = this._ds.Tables[0].Rows[0]["CompanyName"].ToString();
  }

  private void ClosedClaimsReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    string cmdText = !SystemSettings.KeyExists("Claims.ClosedClaimsReport2") ? "spClaims_rptClosedClaims" : SystemSettings.GetStringSetting("Claims.ClosedClaimsReport2");
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand(cmdText, connection);
    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
    this._ds = new DataSet();
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Parameters.AddWithValue("@datefrom", (object) this._datefrom);
    selectCommand.Parameters.AddWithValue("@dateto", (object) this._dateto);
    if (!string.IsNullOrEmpty(this._companyGuid.ToString()))
      selectCommand.Parameters.AddWithValue("@companyGuid", (object) this._companyGuid);
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
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DateRangePicker("Effective Date Range", false),
        (BaseReportControl) new GenericListBox("Company", "SELECT DISTINCT CompanyName AS Display,CompanyGuid as Value From tblCompanies  Order by CompanyName", "Value", "Display", true, typeof (Guid), true, false, 200)
      };
    }
  }

  public virtual bool IsThreaded => true;

  public virtual void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._ds, SaveFileTo);
    Process.Start(SaveFileTo);
  }

  private void groupFooter1_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count > 0)
      this.textBox11.Value = (object) this._ds.Tables[0].Rows.Count;
    else
      this.textBox11.Value = (object) 0;
  }

  string[] ISupportReportDictionary.FieldDescriptions
  {
    get
    {
      return new string[14]
      {
        "Unallocated",
        "Displays the sum of the unallocated expenses entered within the specified date range.",
        "Allocated",
        "Displays the sum of the allocated expense payments on the claim.",
        "Legal",
        "Displays the sum of the legal expense payments on the claim.",
        "Losses",
        "Displays the sum of the indemnity payments on the claim.",
        "Loss",
        "Shows the loss date of on the claim.",
        "Name",
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
      return "Displays closed claims that have a loss date that falls within the date range specified.";
    }
  }

  string ISupportReportDictionary.ReportFriendlyName => "Closed Claims Report";

  string[] ISupportReportDictionary.SearchCriteriaDescription
  {
    get
    {
      return new string[4]
      {
        "Company",
        "This search criteria is optional. This will further limit the result set to the company selected. Alternatively, you choose to run the report for all companies.",
        "Date Range",
        "Limits the data returned to losses within the specified date range. This field is required."
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
    ResourceManager resourceManager = new ResourceManager(typeof (ClosedClaimsReport));
    this.pageHeader = new PageHeader();
    this.label1 = new Label();
    this.label2 = new Label();
    this.textBox1 = new TextBox();
    this.label3 = new Label();
    this.textBox16 = new TextBox();
    this.detail = new Detail();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.pageFooter = new PageFooter();
    this.groupHeader1 = new GroupHeader();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.label12 = new Label();
    this.groupFooter1 = new GroupFooter();
    this.label13 = new Label();
    this.textBox11 = new TextBox();
    this.textBox14 = new TextBox();
    this.textBox13 = new TextBox();
    this.textBox12 = new TextBox();
    this.textBox15 = new TextBox();
    this.label6 = new Label();
    this.textBox9 = new TextBox();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.textBox16).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.label12).BeginInit();
    ((ISupportInitialize) this.label13).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.textBox14).BeginInit();
    ((ISupportInitialize) this.textBox13).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.textBox15).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.pageHeader).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.label1,
      (ARControl) this.label2,
      (ARControl) this.textBox1,
      (ARControl) this.label3,
      (ARControl) this.textBox16
    });
    this.pageHeader.Height = 0.9583333f;
    ((Section) this.pageHeader).Name = "pageHeader";
    ((Section) this.pageHeader).Format += new EventHandler(this.pageHeader_Format);
    ((ARControl) this.label1).Height = 3f / 16f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.0f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-family: Tahoma; font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.label1.Text = "Report Date:";
    ((ARControl) this.label1).Top = 9f / 16f;
    ((ARControl) this.label1).Width = 0.875f;
    ((ARControl) this.label2).Height = 0.188f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 0.0f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-family: Tahoma; font-size: 9.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label2.Text = "South Valley Claims";
    ((ARControl) this.label2).Top = 0.0f;
    ((ARControl) this.label2).Width = 7.8f;
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 0.875f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.OutputFormat = resourceManager.GetString("textBox1.OutputFormat");
    this.textBox1.Style = "font-family: Tahoma; font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox1.Text = (string) null;
    ((ARControl) this.textBox1).Top = 9f / 16f;
    ((ARControl) this.textBox1).Width = 111f / 16f;
    ((ARControl) this.label3).Height = 0.188f;
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Left = 0.0f;
    ((ARControl) this.label3).Name = "label3";
    this.label3.Style = "font-family: Tahoma; font-size: 9.75pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label3.Text = "";
    ((ARControl) this.label3).Top = 3f / 16f;
    ((ARControl) this.label3).Width = 7.8f;
    ((ARControl) this.textBox16).Height = 0.188f;
    ((ARControl) this.textBox16).Left = 0.0f;
    ((ARControl) this.textBox16).Name = "textBox16";
    this.textBox16.Style = "font-family: Tahoma; font-size: 9pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox16.Text = (string) null;
    ((ARControl) this.textBox16).Top = 0.375f;
    ((ARControl) this.textBox16).Width = 7.8f;
    this.detail.ColumnSpacing = 0.0f;
    ((Section) this.detail).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8,
      (ARControl) this.textBox9
    });
    ((Section) this.detail).Height = 0.1354166f;
    ((Section) this.detail).Name = "detail";
    ((ARControl) this.textBox2).DataField = "PolicyNumber";
    ((ARControl) this.textBox2).Height = 0.125f;
    ((ARControl) this.textBox2).Left = 0.0f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 15f / 16f;
    ((ARControl) this.textBox3).DataField = "InsuredName";
    ((ARControl) this.textBox3).Height = 0.125f;
    ((ARControl) this.textBox3).Left = 1.718f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 1.7815f;
    ((ARControl) this.textBox4).DataField = "LossDate";
    ((ARControl) this.textBox4).Height = 0.125f;
    ((ARControl) this.textBox4).Left = 3.5f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.OutputFormat = resourceManager.GetString("textBox4.OutputFormat");
    this.textBox4.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 0.625f;
    ((ARControl) this.textBox5).DataField = "Losses";
    ((ARControl) this.textBox5).Height = 0.125f;
    ((ARControl) this.textBox5).Left = 4.25f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = resourceManager.GetString("textBox5.OutputFormat");
    this.textBox5.Style = "font-family: Tahoma; font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 0.75f;
    ((ARControl) this.textBox6).DataField = "Legal";
    ((ARControl) this.textBox6).Height = 0.125f;
    ((ARControl) this.textBox6).Left = 85f / 16f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = resourceManager.GetString("textBox6.OutputFormat");
    this.textBox6.Style = "font-family: Tahoma; font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 0.625f;
    ((ARControl) this.textBox7).DataField = "Allocated";
    ((ARControl) this.textBox7).Height = 0.125f;
    ((ARControl) this.textBox7).Left = 97f / 16f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = resourceManager.GetString("textBox7.OutputFormat");
    this.textBox7.Style = "font-family: Tahoma; font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox7.Text = (string) null;
    ((ARControl) this.textBox7).Top = 0.0f;
    ((ARControl) this.textBox7).Width = 0.75f;
    ((ARControl) this.textBox8).DataField = "UnAllocated";
    ((ARControl) this.textBox8).Height = 0.125f;
    ((ARControl) this.textBox8).Left = 113f / 16f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = resourceManager.GetString("textBox8.OutputFormat");
    this.textBox8.Style = "font-family: Tahoma; font-size: 8.25pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox8.Text = (string) null;
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 13f / 16f;
    this.pageFooter.Height = 0.0f;
    ((Section) this.pageFooter).Name = "pageFooter";
    ((Section) this.groupHeader1).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.label4,
      (ARControl) this.label5,
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label9,
      (ARControl) this.label10,
      (ARControl) this.label12,
      (ARControl) this.label6
    });
    this.groupHeader1.Height = 0.2189167f;
    ((Section) this.groupHeader1).Name = "groupHeader1";
    ((ARControl) this.label4).Height = 3f / 16f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 0.0f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label4.Text = "Policy";
    ((ARControl) this.label4).Top = 0.0f;
    ((ARControl) this.label4).Width = 15f / 16f;
    ((ARControl) this.label5).Height = 3f / 16f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 1.718f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label5.Text = "Name";
    ((ARControl) this.label5).Top = 0.0f;
    ((ARControl) this.label5).Width = 1.782f;
    ((ARControl) this.label7).Height = 3f / 16f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 4.25f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.label7.Text = "Losses";
    ((ARControl) this.label7).Top = 0.0f;
    ((ARControl) this.label7).Width = 0.75f;
    ((ARControl) this.label8).Height = 3f / 16f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 85f / 16f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.label8.Text = "Legal";
    ((ARControl) this.label8).Top = 0.0f;
    ((ARControl) this.label8).Width = 0.625f;
    ((ARControl) this.label9).Height = 3f / 16f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 97f / 16f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.label9.Text = "Allocated";
    ((ARControl) this.label9).Top = 0.0f;
    ((ARControl) this.label9).Width = 0.75f;
    ((ARControl) this.label10).Height = 3f / 16f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 113f / 16f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.label10.Text = "Unallocated";
    ((ARControl) this.label10).Top = 0.0f;
    ((ARControl) this.label10).Width = 13f / 16f;
    ((ARControl) this.label12).Height = 3f / 16f;
    this.label12.HyperLink = (string) null;
    ((ARControl) this.label12).Left = 3.5f;
    ((ARControl) this.label12).Name = "label12";
    this.label12.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label12.Text = "Loss";
    ((ARControl) this.label12).Top = 0.0f;
    ((ARControl) this.label12).Width = 0.625f;
    ((Section) this.groupFooter1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.label13,
      (ARControl) this.textBox11,
      (ARControl) this.textBox14,
      (ARControl) this.textBox13,
      (ARControl) this.textBox12,
      (ARControl) this.textBox15
    });
    this.groupFooter1.Height = 0.3229167f;
    ((Section) this.groupFooter1).Name = "groupFooter1";
    ((Section) this.groupFooter1).Format += new EventHandler(this.groupFooter1_Format);
    ((ARControl) this.label13).Height = 3f / 16f;
    this.label13.HyperLink = (string) null;
    ((ARControl) this.label13).Left = 0.0f;
    ((ARControl) this.label13).Name = "label13";
    this.label13.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label13.Text = "Closed";
    ((ARControl) this.label13).Top = 0.125f;
    ((ARControl) this.label13).Width = 0.5f;
    ((ARControl) this.textBox11).Height = 3f / 16f;
    ((ARControl) this.textBox11).Left = 0.5f;
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.textBox11.Text = (string) null;
    ((ARControl) this.textBox11).Top = 0.125f;
    ((ARControl) this.textBox11).Width = 2.5f;
    ((ARControl) this.textBox14).DataField = "Allocated";
    ((ARControl) this.textBox14).Height = 3f / 16f;
    ((ARControl) this.textBox14).Left = 97f / 16f;
    ((ARControl) this.textBox14).Name = "textBox14";
    this.textBox14.OutputFormat = resourceManager.GetString("textBox14.OutputFormat");
    this.textBox14.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox14.SummaryGroup = "groupHeader1";
    this.textBox14.SummaryRunning = (SummaryRunning) 1;
    this.textBox14.SummaryType = (SummaryType) 3;
    this.textBox14.Text = (string) null;
    ((ARControl) this.textBox14).Top = 0.125f;
    ((ARControl) this.textBox14).Width = 0.75f;
    ((ARControl) this.textBox13).DataField = "Legal";
    ((ARControl) this.textBox13).Height = 3f / 16f;
    ((ARControl) this.textBox13).Left = 85f / 16f;
    ((ARControl) this.textBox13).Name = "textBox13";
    this.textBox13.OutputFormat = resourceManager.GetString("textBox13.OutputFormat");
    this.textBox13.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox13.SummaryGroup = "groupHeader1";
    this.textBox13.SummaryRunning = (SummaryRunning) 1;
    this.textBox13.SummaryType = (SummaryType) 3;
    this.textBox13.Text = (string) null;
    ((ARControl) this.textBox13).Top = 0.125f;
    ((ARControl) this.textBox13).Width = 0.625f;
    ((ARControl) this.textBox12).DataField = "Losses";
    ((ARControl) this.textBox12).Height = 3f / 16f;
    ((ARControl) this.textBox12).Left = 4.25f;
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.OutputFormat = resourceManager.GetString("textBox12.OutputFormat");
    this.textBox12.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox12.SummaryGroup = "groupHeader1";
    this.textBox12.SummaryRunning = (SummaryRunning) 1;
    this.textBox12.SummaryType = (SummaryType) 3;
    this.textBox12.Text = (string) null;
    ((ARControl) this.textBox12).Top = 0.125f;
    ((ARControl) this.textBox12).Width = 0.75f;
    ((ARControl) this.textBox15).DataField = "Unallocated";
    ((ARControl) this.textBox15).Height = 3f / 16f;
    ((ARControl) this.textBox15).Left = 113f / 16f;
    ((ARControl) this.textBox15).Name = "textBox15";
    this.textBox15.OutputFormat = resourceManager.GetString("textBox15.OutputFormat");
    this.textBox15.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.textBox15.SummaryGroup = "groupHeader1";
    this.textBox15.SummaryRunning = (SummaryRunning) 1;
    this.textBox15.SummaryType = (SummaryType) 3;
    this.textBox15.Text = (string) null;
    ((ARControl) this.textBox15).Top = 0.125f;
    ((ARControl) this.textBox15).Width = 13f / 16f;
    ((ARControl) this.label6).Height = 3f / 16f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 0.937f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "font-family: Tahoma; font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.label6.Text = "Claim #";
    ((ARControl) this.label6).Top = 0.0f;
    ((ARControl) this.label6).Width = 0.7809999f;
    ((ARControl) this.textBox9).DataField = "ClaimNumber";
    ((ARControl) this.textBox9).Height = 0.125f;
    ((ARControl) this.textBox9).Left = 0.937f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.Style = "font-family: Tahoma; font-size: 8.25pt; vertical-align: middle; ddo-char-set: 0";
    this.textBox9.Text = (string) null;
    ((ARControl) this.textBox9).Top = 0.0f;
    ((ARControl) this.textBox9).Width = 0.781f;
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
    ((SectionReport) this).ReportStart += new EventHandler(this.ClosedClaimsReport_ReportStart);
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.textBox16).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.label12).EndInit();
    ((ISupportInitialize) this.label13).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.textBox14).EndInit();
    ((ISupportInitialize) this.textBox13).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.textBox15).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
