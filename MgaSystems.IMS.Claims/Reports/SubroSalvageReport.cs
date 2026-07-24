// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Reports.SubroSalvageReport
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Reports;

[SecureReportResource("{98C7C218-7700-43e5-B1C3-F1E9475AD600}", "Subrogation/Salvage Report", "Subrogation/Salvage Report", "Claims")]
public class SubroSalvageReport : MGAReport, IReport, ISupportReportDictionary
{
  private int _glCompanyId;
  private Guid _companyGuid;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private int _recordCount;
  private DataSet _ds;
  private string _commandString;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Label label1;
  private Label label2;
  private Label label3;
  private Label label4;
  private Label label5;
  private Label label6;
  private Label label7;
  private Label label9;
  private TextBox textBox1;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox textGLCompany;
  private TextBox textCompanyName;
  private TextBox textDateRange;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private TextBox textBox8;
  private TextBox textBox9;
  private TextBox textBox10;
  private TextBox textBox11;
  private Label label8;
  private Line line3;
  private Line line4;
  private TextBox textBox14;
  private TextBox textBox15;
  private TextBox textTotalClaims;

  public SubroSalvageReport() => this.InitializeComponent();

  public SubroSalvageReport(int glCompanyId, DateTime dateFrom, DateTime dateTo, Guid companyGuid)
  {
    this._glCompanyId = glCompanyId;
    this._dateFrom = dateFrom;
    this._dateTo = dateTo;
    this._companyGuid = companyGuid;
    this._commandString = "spClaims_rptSubrogationSalvage";
    this.InitializeComponent();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new OfficeLocations("Office Location", false, true),
        (BaseReportControl) new DateRangePicker("Effective Date Range", false),
        (BaseReportControl) new GenericComboBox("Company", "SELECT DISTINCT CompanyName AS Display,CompanyGuid as Value From tblCompanies  Order by CompanyName", "Value", "Display", typeof (Guid))
      };
    }
  }

  private void SubroSalvageReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.ShowPageNumbers();
    if (this._ds == null)
    {
      using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
      {
        using (SqlCommand selectCommand = new SqlCommand(this._commandString, connection))
        {
          using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
          {
            this._ds = new DataSet();
            selectCommand.CommandType = CommandType.StoredProcedure;
            selectCommand.CommandTimeout = 0;
            selectCommand.Parameters.AddWithValue("@GLCompanyId", (object) this._glCompanyId);
            selectCommand.Parameters.AddWithValue("@DateFrom", (object) this._dateFrom);
            selectCommand.Parameters.AddWithValue("@DateTo", (object) this._dateTo);
            selectCommand.Parameters.AddWithValue("@companyGuid", (object) this._companyGuid);
            this.AddCommandToCancelList(selectCommand);
            try
            {
              sqlDataAdapter.Fill(this._ds);
            }
            catch (SqlException ex)
            {
              ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, (Exception) ex);
            }
          }
        }
      }
    }
    ((SectionReport) this).DataSource = (object) this._ds.Tables[1];
    this.SetControlVars();
  }

  private void SetControlVars() => this._recordCount = this._ds.Tables[0].Rows.Count;

  private void pageHeader_Format(object sender, EventArgs e)
  {
    this.textGLCompany.Text = this._ds.Tables[0].Rows[0]["Location"].ToString();
    this.textCompanyName.Text = this._ds.Tables[0].Rows[0]["CompanyName"].ToString();
    this.textDateRange.Text = this._ds.Tables[0].Rows[0]["DateRange"].ToString();
  }

  private void reportFooter1_Format(object sender, EventArgs e)
  {
    this.textTotalClaims.Text = "Total Claims: " + this._ds.Tables[1].Rows.Count.ToString();
  }

  string[] ISupportReportDictionary.FieldDescriptions
  {
    get
    {
      return new string[14]
      {
        "Salvage Potential",
        "Shows the potential salvage for all reserves within the specified date range. The indemnity and expense reserves will need to be marked as salvage to be considered.",
        "Salvage Received",
        "Shows the payments received for salvage within the specified date range. The indemnity and expense reserves will need to be marked as salvage to be considered.",
        "Subrogation Potential",
        "Shows the potential subrogation for all reserves within the specified date range. The indemnity and expense reserves will need to be marked as subrogation to be considered.",
        "Subrogation Received",
        "Shows the payments received for subrogation within the specified date range. The indemnity and expense reserves will need to be marked as subrogation to be considered.",
        "Loss Date",
        "This date of loss on the claim.",
        "Insured Name",
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
      return "Provides you with a picture of the potential and actual subrogation and salvage within the specified date range for all claims.";
    }
  }

  string ISupportReportDictionary.ReportFriendlyName => "Subrogation/Salvage Report";

  string[] ISupportReportDictionary.SearchCriteriaDescription
  {
    get
    {
      return new string[6]
      {
        "Office Location",
        "Limits the report to claims against policies issued from the specified office lcoation. This field is required.",
        "Date Range",
        "Limits the data returned to reserves and payments within the specifed date range. This field is required",
        "Company",
        "Limits the data returned to policies written for the specified company. This field is required."
      };
    }
  }

  string[] ISupportReportDictionary.SortingAndTotalsDescription
  {
    get
    {
      return new string[10]
      {
        "Total Claims",
        "Shows the number of records that matched your search criteria.",
        "Total Subrogation Potential",
        "Shows the sum of the subrogation potential column.",
        "Total Subrogation Received",
        "Shows the sum of the subrogation received column.",
        "Total Salvage Potential",
        "Shows the sum of the salvage potential column.",
        "Total Salvage Received",
        "Shows the sum of the salvage received column."
      };
    }
  }

  protected virtual void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (SubroSalvageReport));
    this.pageHeader = new PageHeader();
    this.label3 = new Label();
    this.label2 = new Label();
    this.label1 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label9 = new Label();
    this.textGLCompany = new TextBox();
    this.textCompanyName = new TextBox();
    this.textDateRange = new TextBox();
    this.detail = new Detail();
    this.textBox1 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.pageFooter = new PageFooter();
    this.reportHeader1 = new ReportHeader();
    this.reportFooter1 = new ReportFooter();
    this.textBox8 = new TextBox();
    this.textBox9 = new TextBox();
    this.textBox10 = new TextBox();
    this.textBox11 = new TextBox();
    this.line3 = new Line();
    this.line4 = new Line();
    this.label8 = new Label();
    this.textBox14 = new TextBox();
    this.textBox15 = new TextBox();
    this.textTotalClaims = new TextBox();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.textGLCompany).BeginInit();
    ((ISupportInitialize) this.textCompanyName).BeginInit();
    ((ISupportInitialize) this.textDateRange).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.textBox14).BeginInit();
    ((ISupportInitialize) this.textBox15).BeginInit();
    ((ISupportInitialize) this.textTotalClaims).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.pageHeader).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.label3,
      (ARControl) this.label2,
      (ARControl) this.label1,
      (ARControl) this.label4,
      (ARControl) this.label5,
      (ARControl) this.label6,
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label9,
      (ARControl) this.textGLCompany,
      (ARControl) this.textCompanyName,
      (ARControl) this.textDateRange,
      (ARControl) this.line3
    });
    this.pageHeader.Height = 1.729167f;
    ((Section) this.pageHeader).Name = "pageHeader";
    ((Section) this.pageHeader).Format += new EventHandler(this.pageHeader_Format);
    ((ARControl) this.label3).Border.BottomColor = Color.Black;
    ((ARControl) this.label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Border.LeftColor = Color.Black;
    ((ARControl) this.label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Border.RightColor = Color.Black;
    ((ARControl) this.label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Border.TopColor = Color.Black;
    ((ARControl) this.label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Height = 3f / 16f;
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Left = 2.875f;
    ((ARControl) this.label3).Name = "label3";
    this.label3.Style = "font-weight: bold; font-size: 8pt; ";
    this.label3.Text = "Loss Date";
    ((ARControl) this.label3).Top = 1.5f;
    ((ARControl) this.label3).Width = 0.875f;
    ((ARControl) this.label2).Border.BottomColor = Color.Black;
    ((ARControl) this.label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.LeftColor = Color.Black;
    ((ARControl) this.label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.RightColor = Color.Black;
    ((ARControl) this.label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.TopColor = Color.Black;
    ((ARControl) this.label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Height = 3f / 16f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 21f / 16f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-weight: bold; font-size: 8pt; ";
    this.label2.Text = "Insured Name";
    ((ARControl) this.label2).Top = 1.5f;
    ((ARControl) this.label2).Width = 1.375f;
    ((ARControl) this.label1).Border.BottomColor = Color.Black;
    ((ARControl) this.label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.LeftColor = Color.Black;
    ((ARControl) this.label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.RightColor = Color.Black;
    ((ARControl) this.label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.TopColor = Color.Black;
    ((ARControl) this.label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Height = 3f / 16f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.0f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-weight: bold; font-size: 8pt; ";
    this.label1.Text = "Policy Number";
    ((ARControl) this.label1).Top = 1.5f;
    ((ARControl) this.label1).Width = 21f / 16f;
    ((ARControl) this.label4).Border.BottomColor = Color.Black;
    ((ARControl) this.label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.LeftColor = Color.Black;
    ((ARControl) this.label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.RightColor = Color.Black;
    ((ARControl) this.label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.TopColor = Color.Black;
    ((ARControl) this.label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Height = 3f / 16f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 3.75f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.label4.Text = "SUBROGATION";
    ((ARControl) this.label4).Top = 1.25f;
    ((ARControl) this.label4).Width = 2f;
    ((ARControl) this.label5).Border.BottomColor = Color.Black;
    ((ARControl) this.label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.LeftColor = Color.Black;
    ((ARControl) this.label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.RightColor = Color.Black;
    ((ARControl) this.label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.TopColor = Color.Black;
    ((ARControl) this.label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Height = 3f / 16f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 5.75f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: middle; ";
    this.label5.Text = "SALVAGE";
    ((ARControl) this.label5).Top = 1.25f;
    ((ARControl) this.label5).Width = 31f / 16f;
    ((ARControl) this.label6).Border.BottomColor = Color.Black;
    ((ARControl) this.label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.LeftColor = Color.Black;
    ((ARControl) this.label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.RightColor = Color.Black;
    ((ARControl) this.label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.TopColor = Color.Black;
    ((ARControl) this.label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Height = 0.1979167f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 4.75f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.label6.Text = "Received";
    ((ARControl) this.label6).Top = 1.5f;
    ((ARControl) this.label6).Width = 1f;
    ((ARControl) this.label7).Border.BottomColor = Color.Black;
    ((ARControl) this.label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.LeftColor = Color.Black;
    ((ARControl) this.label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.RightColor = Color.Black;
    ((ARControl) this.label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.TopColor = Color.Black;
    ((ARControl) this.label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Height = 0.1979167f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 3.75f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.label7.Text = "Potential";
    ((ARControl) this.label7).Top = 1.5f;
    ((ARControl) this.label7).Width = 1f;
    ((ARControl) this.label9).Border.BottomColor = Color.Black;
    ((ARControl) this.label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Border.LeftColor = Color.Black;
    ((ARControl) this.label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Border.RightColor = Color.Black;
    ((ARControl) this.label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Border.TopColor = Color.Black;
    ((ARControl) this.label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Height = 3f / 16f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 6.75f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.label9.Text = "Received";
    ((ARControl) this.label9).Top = 1.5f;
    ((ARControl) this.label9).Width = 1f;
    ((ARControl) this.textGLCompany).Border.BottomColor = Color.Black;
    ((ARControl) this.textGLCompany).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGLCompany).Border.LeftColor = Color.Black;
    ((ARControl) this.textGLCompany).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGLCompany).Border.RightColor = Color.Black;
    ((ARControl) this.textGLCompany).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGLCompany).Border.TopColor = Color.Black;
    ((ARControl) this.textGLCompany).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGLCompany).Height = 3f / 16f;
    ((ARControl) this.textGLCompany).Left = 0.0f;
    ((ARControl) this.textGLCompany).Name = "textGLCompany";
    this.textGLCompany.Style = "text-align: center; ";
    this.textGLCompany.Text = "textBox8";
    ((ARControl) this.textGLCompany).Top = 0.25f;
    ((ARControl) this.textGLCompany).Width = 7.875f;
    ((ARControl) this.textCompanyName).Border.BottomColor = Color.Black;
    ((ARControl) this.textCompanyName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textCompanyName).Border.LeftColor = Color.Black;
    ((ARControl) this.textCompanyName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textCompanyName).Border.RightColor = Color.Black;
    ((ARControl) this.textCompanyName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textCompanyName).Border.TopColor = Color.Black;
    ((ARControl) this.textCompanyName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textCompanyName).Height = 3f / 16f;
    ((ARControl) this.textCompanyName).Left = 0.0f;
    ((ARControl) this.textCompanyName).Name = "textCompanyName";
    this.textCompanyName.Style = "text-align: center; ";
    this.textCompanyName.Text = "textBox8";
    ((ARControl) this.textCompanyName).Top = 7f / 16f;
    ((ARControl) this.textCompanyName).Width = 7.875f;
    ((ARControl) this.textDateRange).Border.BottomColor = Color.Black;
    ((ARControl) this.textDateRange).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textDateRange).Border.LeftColor = Color.Black;
    ((ARControl) this.textDateRange).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textDateRange).Border.RightColor = Color.Black;
    ((ARControl) this.textDateRange).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textDateRange).Border.TopColor = Color.Black;
    ((ARControl) this.textDateRange).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textDateRange).Height = 3f / 16f;
    ((ARControl) this.textDateRange).Left = 0.0f;
    ((ARControl) this.textDateRange).Name = "textDateRange";
    this.textDateRange.Style = "text-align: center; ";
    this.textDateRange.Text = "textBox8";
    ((ARControl) this.textDateRange).Top = 0.625f;
    ((ARControl) this.textDateRange).Width = 7.875f;
    this.detail.ColumnSpacing = 0.0f;
    ((Section) this.detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.textBox1,
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox14,
      (ARControl) this.textBox15
    });
    ((Section) this.detail).Height = 0.1979167f;
    ((Section) this.detail).Name = "detail";
    ((ARControl) this.textBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.RightColor = Color.Black;
    ((ARControl) this.textBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.TopColor = Color.Black;
    ((ARControl) this.textBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).DataField = "PolicyNumber";
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 0.0f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.Style = "font-size: 8pt; ";
    this.textBox1.Text = "textBox1";
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 21f / 16f;
    ((ARControl) this.textBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.RightColor = Color.Black;
    ((ARControl) this.textBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.TopColor = Color.Black;
    ((ARControl) this.textBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).DataField = "InsuredName";
    ((ARControl) this.textBox2).Height = 3f / 16f;
    ((ARControl) this.textBox2).Left = 21f / 16f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "font-size: 8pt; ";
    this.textBox2.Text = "textBox1";
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 25f / 16f;
    ((ARControl) this.textBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.RightColor = Color.Black;
    ((ARControl) this.textBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.TopColor = Color.Black;
    ((ARControl) this.textBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).DataField = "LossDate";
    ((ARControl) this.textBox3).Height = 3f / 16f;
    ((ARControl) this.textBox3).Left = 2.875f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.OutputFormat = resourceManager.GetString("textBox3.OutputFormat");
    this.textBox3.Style = "font-size: 8pt; ";
    this.textBox3.Text = "textBox1";
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 0.875f;
    ((ARControl) this.textBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.RightColor = Color.Black;
    ((ARControl) this.textBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.TopColor = Color.Black;
    ((ARControl) this.textBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).DataField = "SubroPotential";
    ((ARControl) this.textBox4).Height = 3f / 16f;
    ((ARControl) this.textBox4).Left = 3.75f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.OutputFormat = resourceManager.GetString("textBox4.OutputFormat");
    this.textBox4.Style = "text-align: right; font-size: 8pt; ";
    this.textBox4.Text = "textBox1";
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 1f;
    ((ARControl) this.textBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.RightColor = Color.Black;
    ((ARControl) this.textBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.TopColor = Color.Black;
    ((ARControl) this.textBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).DataField = "SubroReceived";
    ((ARControl) this.textBox5).Height = 3f / 16f;
    ((ARControl) this.textBox5).Left = 4.75f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = resourceManager.GetString("textBox5.OutputFormat");
    this.textBox5.Style = "text-align: right; font-size: 8pt; ";
    this.textBox5.Text = "textBox1";
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 1f;
    this.pageFooter.Height = 1.875f;
    ((Section) this.pageFooter).Name = "pageFooter";
    this.reportHeader1.Height = 0.0f;
    ((Section) this.reportHeader1).Name = "reportHeader1";
    ((Section) this.reportFooter1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.textTotalClaims,
      (ARControl) this.textBox8,
      (ARControl) this.textBox9,
      (ARControl) this.textBox10,
      (ARControl) this.textBox11,
      (ARControl) this.line4
    });
    this.reportFooter1.Height = 0.4479167f;
    ((Section) this.reportFooter1).Name = "reportFooter1";
    ((Section) this.reportFooter1).Format += new EventHandler(this.reportFooter1_Format);
    ((ARControl) this.textBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.RightColor = Color.Black;
    ((ARControl) this.textBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.TopColor = Color.Black;
    ((ARControl) this.textBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).DataField = "SalvageReceived";
    ((ARControl) this.textBox8).Height = 3f / 16f;
    ((ARControl) this.textBox8).Left = 6.75f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = resourceManager.GetString("textBox8.OutputFormat");
    this.textBox8.Style = "text-align: right; font-size: 8pt; ";
    this.textBox8.SummaryRunning = (SummaryRunning) 2;
    this.textBox8.SummaryType = (SummaryType) 1;
    this.textBox8.Text = "textBox1";
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 1f;
    ((ARControl) this.textBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.RightColor = Color.Black;
    ((ARControl) this.textBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.TopColor = Color.Black;
    ((ARControl) this.textBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).DataField = "SubroReceived";
    ((ARControl) this.textBox9).Height = 3f / 16f;
    ((ARControl) this.textBox9).Left = 4.75f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = resourceManager.GetString("textBox9.OutputFormat");
    this.textBox9.Style = "text-align: right; font-size: 8pt; ";
    this.textBox9.SummaryRunning = (SummaryRunning) 2;
    this.textBox9.SummaryType = (SummaryType) 1;
    this.textBox9.Text = "textBox1";
    ((ARControl) this.textBox9).Top = 0.0f;
    ((ARControl) this.textBox9).Width = 1f;
    ((ARControl) this.textBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.RightColor = Color.Black;
    ((ARControl) this.textBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.TopColor = Color.Black;
    ((ARControl) this.textBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).DataField = "SalvagePotential";
    ((ARControl) this.textBox10).Height = 3f / 16f;
    ((ARControl) this.textBox10).Left = 5.75f;
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.OutputFormat = resourceManager.GetString("textBox10.OutputFormat");
    this.textBox10.Style = "text-align: right; font-size: 8pt; ";
    this.textBox10.SummaryRunning = (SummaryRunning) 2;
    this.textBox10.SummaryType = (SummaryType) 1;
    this.textBox10.Text = "textBox1";
    ((ARControl) this.textBox10).Top = 0.0f;
    ((ARControl) this.textBox10).Width = 1f;
    ((ARControl) this.textBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.RightColor = Color.Black;
    ((ARControl) this.textBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.TopColor = Color.Black;
    ((ARControl) this.textBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).DataField = "SubroPotential";
    ((ARControl) this.textBox11).Height = 3f / 16f;
    ((ARControl) this.textBox11).Left = 3.75f;
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.OutputFormat = resourceManager.GetString("textBox11.OutputFormat");
    this.textBox11.Style = "text-align: right; font-size: 8pt; ";
    this.textBox11.SummaryRunning = (SummaryRunning) 2;
    this.textBox11.SummaryType = (SummaryType) 1;
    this.textBox11.Text = "textBox1";
    ((ARControl) this.textBox11).Top = 0.0f;
    ((ARControl) this.textBox11).Width = 1f;
    ((ARControl) this.line3).Border.BottomColor = Color.Black;
    ((ARControl) this.line3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.line3).Border.LeftColor = Color.Black;
    ((ARControl) this.line3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.line3).Border.RightColor = Color.Black;
    ((ARControl) this.line3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.line3).Border.TopColor = Color.Black;
    ((ARControl) this.line3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.line3).Height = 0.0f;
    ((ARControl) this.line3).Left = 0.0f;
    this.line3.LineWeight = 1f;
    ((ARControl) this.line3).Name = "line3";
    ((ARControl) this.line3).Top = 27f / 16f;
    ((ARControl) this.line3).Width = 125f / 16f;
    this.line3.X1 = 0.0f;
    this.line3.X2 = 125f / 16f;
    this.line3.Y1 = 27f / 16f;
    this.line3.Y2 = 27f / 16f;
    ((ARControl) this.line4).Border.BottomColor = Color.Black;
    ((ARControl) this.line4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.line4).Border.LeftColor = Color.Black;
    ((ARControl) this.line4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.line4).Border.RightColor = Color.Black;
    ((ARControl) this.line4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.line4).Border.TopColor = Color.Black;
    ((ARControl) this.line4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.line4).Height = 0.0f;
    ((ARControl) this.line4).Left = 0.0f;
    this.line4.LineWeight = 1f;
    ((ARControl) this.line4).Name = "line4";
    ((ARControl) this.line4).Top = 0.0f;
    ((ARControl) this.line4).Width = 125f / 16f;
    this.line4.X1 = 0.0f;
    this.line4.X2 = 125f / 16f;
    this.line4.Y1 = 0.0f;
    this.line4.Y2 = 0.0f;
    ((ARControl) this.label8).Border.BottomColor = Color.Black;
    ((ARControl) this.label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.LeftColor = Color.Black;
    ((ARControl) this.label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.RightColor = Color.Black;
    ((ARControl) this.label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.TopColor = Color.Black;
    ((ARControl) this.label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Height = 0.1979167f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 5.75f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.label8.Text = "Potential";
    ((ARControl) this.label8).Top = 1.5f;
    ((ARControl) this.label8).Width = 1f;
    ((ARControl) this.textBox14).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.RightColor = Color.Black;
    ((ARControl) this.textBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.TopColor = Color.Black;
    ((ARControl) this.textBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).DataField = "SalvagePotential";
    ((ARControl) this.textBox14).Height = 3f / 16f;
    ((ARControl) this.textBox14).Left = 5.75f;
    ((ARControl) this.textBox14).Name = "textBox14";
    this.textBox14.OutputFormat = resourceManager.GetString("textBox14.OutputFormat");
    this.textBox14.Style = "text-align: right; font-size: 8pt; ";
    this.textBox14.Text = "textBox1";
    ((ARControl) this.textBox14).Top = 0.0f;
    ((ARControl) this.textBox14).Width = 1f;
    ((ARControl) this.textBox15).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.RightColor = Color.Black;
    ((ARControl) this.textBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.TopColor = Color.Black;
    ((ARControl) this.textBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).DataField = "SalvageReceived";
    ((ARControl) this.textBox15).Height = 3f / 16f;
    ((ARControl) this.textBox15).Left = 6.75f;
    ((ARControl) this.textBox15).Name = "textBox15";
    this.textBox15.OutputFormat = resourceManager.GetString("textBox15.OutputFormat");
    this.textBox15.Style = "text-align: right; font-size: 8pt; ";
    this.textBox15.Text = "textBox1";
    ((ARControl) this.textBox15).Top = 0.0f;
    ((ARControl) this.textBox15).Width = 1f;
    ((ARControl) this.textTotalClaims).Border.BottomColor = Color.Black;
    ((ARControl) this.textTotalClaims).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textTotalClaims).Border.LeftColor = Color.Black;
    ((ARControl) this.textTotalClaims).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textTotalClaims).Border.RightColor = Color.Black;
    ((ARControl) this.textTotalClaims).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textTotalClaims).Border.TopColor = Color.Black;
    ((ARControl) this.textTotalClaims).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textTotalClaims).Height = 3f / 16f;
    ((ARControl) this.textTotalClaims).Left = 1f / 16f;
    ((ARControl) this.textTotalClaims).Name = "textTotalClaims";
    this.textTotalClaims.Style = "font-size: 8pt; ";
    this.textTotalClaims.Text = "textBox6";
    ((ARControl) this.textTotalClaims).Top = 0.0f;
    ((ARControl) this.textTotalClaims).Width = 1.625f;
    ((SectionReport) this).MasterReport = false;
    ((SectionReport) this).PageSettings.Margins.Bottom = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Left = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Right = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Top = 0.3f;
    ((SectionReport) this).PageSettings.PaperHeight = 11f;
    ((SectionReport) this).PageSettings.PaperWidth = 8.5f;
    ((SectionReport) this).PrintWidth = 251f / 32f;
    ((SectionReport) this).Sections.Add((Section) this.reportHeader1);
    ((SectionReport) this).Sections.Add((Section) this.pageHeader);
    ((SectionReport) this).Sections.Add((Section) this.detail);
    ((SectionReport) this).Sections.Add((Section) this.pageFooter);
    ((SectionReport) this).Sections.Add((Section) this.reportFooter1);
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    ((SectionReport) this).StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((SectionReport) this).ReportStart += new EventHandler(this.SubroSalvageReport_ReportStart);
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.textGLCompany).EndInit();
    ((ISupportInitialize) this.textCompanyName).EndInit();
    ((ISupportInitialize) this.textDateRange).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.textBox14).EndInit();
    ((ISupportInitialize) this.textBox15).EndInit();
    ((ISupportInitialize) this.textTotalClaims).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
