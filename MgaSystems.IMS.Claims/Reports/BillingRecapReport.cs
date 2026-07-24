// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Reports.BillingRecapReport
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Reports;

[SecureReportResource("{76AB6681-F4ED-457c-AA24-D29FDD744682}", "Billing Recap Report", "Billing Recap Report", "Claims")]
public class BillingRecapReport : MGAReport, IReport, ISupportReportDictionary
{
  private Guid _companyGuid;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private int _recordCount;
  private DataSet _ds;
  private string _commandString;
  private Detail detail;
  private Container components;
  private TextBox textBox1;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox textBox8;
  private TextBox textBox9;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private Label label11;
  private TextBox txtRecordCount;
  private TextBox textBox11;
  private TextBox textBox12;
  private TextBox textBox13;
  private TextBox textBox14;
  private TextBox textBox15;
  private Label label12;
  private Label label13;
  private GroupHeader groupHeader1;
  private GroupFooter groupFooter1;
  private TextBox textBox10;
  private TextBox textBox16;
  private TextBox textBox17;
  private TextBox textBox18;
  private Label label15;
  private Label label16;
  private Label label17;
  private Label label18;
  private Label label19;
  private Label label20;
  private Label label21;
  private Label label22;
  private Label label23;
  private TextBox textBox20;

  public BillingRecapReport() => this.InitializeComponent();

  public BillingRecapReport(DataSet data)
  {
    this.InitializeComponent();
    this._dateFrom = DateTime.Parse(data.Tables[0].Rows[0]["DateFrom"].ToString());
    this._dateTo = DateTime.Parse(data.Tables[0].Rows[0]["DateTo"].ToString());
    this._ds = data;
    this.InitializeReport();
  }

  public BillingRecapReport(DateTime dateFrom, DateTime dateTo, Guid companyGuid)
  {
    this.InitializeComponent();
    this._dateFrom = dateFrom;
    this._dateTo = dateTo;
    this._companyGuid = companyGuid;
    this._commandString = "spClaims_rptBillingRecapReport";
    this.InitializeReport();
  }

  private void BillingRecapReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
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
            selectCommand.Parameters.AddWithValue("@DateFrom", (object) this._dateFrom);
            selectCommand.Parameters.AddWithValue("@DateTo", (object) this._dateTo);
            selectCommand.Parameters.AddWithValue("@companyGuid", (object) this._companyGuid);
            this.AddCommandToCancelList(selectCommand);
            try
            {
              DefaultDatabase.DataAdapterFill((DbDataAdapter) sqlDataAdapter, this._ds);
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

  private void GroupHeader_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.textBox18.Text = $"Billing Recap Report for {this._dateFrom.ToShortDateString()}  to {this._dateTo.ToShortDateString()}";
    this.textBox16.Text = this._ds.Tables[0].Rows[0]["CompanyName"].ToString();
    this.textBox10.Text = DateTime.Now.ToShortDateString();
  }

  private void pageFooter_Format(object sender, EventArgs e)
  {
    this.txtRecordCount.Value = (object) this._recordCount;
  }

  private void InitializeReport()
  {
    ((SectionReport) this).ReportStart += new EventHandler(this.BillingRecapReport_ReportStart);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Format += new EventHandler(this.GroupHeader_Format);
  }

  private void SetControlVars() => this._recordCount = this._ds.Tables[0].Rows.Count;

  public virtual bool IsThreaded => true;

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DateRangePicker("Effective Date Range", false),
        (BaseReportControl) new GenericComboBox("Company", "SELECT DISTINCT CompanyName AS Display,CompanyGuid as Value From tblCompanies  Order by CompanyName", "Value", "Display", typeof (Guid))
      };
    }
  }

  string[] ISupportReportDictionary.FieldDescriptions
  {
    get
    {
      return new string[18]
      {
        "Total",
        "Displays the total for the unallocated expense.",
        "Other",
        "Displays any other charges for the unallocated expense.",
        "Equipment",
        "Shows the equipment charges for the unallocated expense",
        "Hourly",
        "Displays any hourly charges for the unallocted expense.",
        "Time",
        "Displays the time spent for the unallocated expense.",
        "Claim Number",
        "Displays the claim number.",
        "Loss Date",
        "The date of loss.",
        "Insured",
        "Shows the insured name on the policy.",
        "Policy",
        "Displays the policy number."
      };
    }
  }

  string ISupportReportDictionary.GeneralDescription
  {
    get => "Displays the unallocated loss expenses for all claims for a specific company.";
  }

  string ISupportReportDictionary.ReportFriendlyName => "Billing Recap Report";

  string[] ISupportReportDictionary.SearchCriteriaDescription
  {
    get
    {
      return new string[4]
      {
        "Company",
        "Specifies the company for which you would like to run the report. This criteria is required.",
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
        "Date Entered",
        "Unallocated expenses are ordered by the date they were entered.",
        "Total",
        "Show the totals for time, hours, equipment and other charges."
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BillingRecapReport));
    this.detail = new Detail();
    this.textBox1 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.textBox9 = new TextBox();
    this.reportHeader1 = new ReportHeader();
    this.reportFooter1 = new ReportFooter();
    this.label11 = new Label();
    this.txtRecordCount = new TextBox();
    this.textBox11 = new TextBox();
    this.textBox12 = new TextBox();
    this.textBox13 = new TextBox();
    this.textBox14 = new TextBox();
    this.textBox15 = new TextBox();
    this.label12 = new Label();
    this.label13 = new Label();
    this.groupHeader1 = new GroupHeader();
    this.textBox10 = new TextBox();
    this.textBox16 = new TextBox();
    this.textBox17 = new TextBox();
    this.textBox18 = new TextBox();
    this.label15 = new Label();
    this.label16 = new Label();
    this.label17 = new Label();
    this.label18 = new Label();
    this.label19 = new Label();
    this.label20 = new Label();
    this.label21 = new Label();
    this.label22 = new Label();
    this.label23 = new Label();
    this.textBox20 = new TextBox();
    this.groupFooter1 = new GroupFooter();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.txtRecordCount).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.textBox13).BeginInit();
    ((ISupportInitialize) this.textBox14).BeginInit();
    ((ISupportInitialize) this.textBox15).BeginInit();
    ((ISupportInitialize) this.label12).BeginInit();
    ((ISupportInitialize) this.label13).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this.textBox16).BeginInit();
    ((ISupportInitialize) this.textBox17).BeginInit();
    ((ISupportInitialize) this.textBox18).BeginInit();
    ((ISupportInitialize) this.label15).BeginInit();
    ((ISupportInitialize) this.label16).BeginInit();
    ((ISupportInitialize) this.label17).BeginInit();
    ((ISupportInitialize) this.label18).BeginInit();
    ((ISupportInitialize) this.label19).BeginInit();
    ((ISupportInitialize) this.label20).BeginInit();
    ((ISupportInitialize) this.label21).BeginInit();
    ((ISupportInitialize) this.label22).BeginInit();
    ((ISupportInitialize) this.label23).BeginInit();
    ((ISupportInitialize) this.textBox20).BeginInit();
    this.detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.textBox1,
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8,
      (ARControl) this.textBox9
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.125f;
    this.detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((ARControl) this.textBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).DataField = "Policy";
    this.textBox1.DistinctField = (string) null;
    this.textBox1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox1).Location = (PointF) componentResourceManager.GetObject("textBox1.Location");
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.OutputFormat = (string) null;
    ((ARControl) this.textBox1).Size = new SizeF(19f / 16f, 0.125f);
    this.textBox1.Text = (string) null;
    this.textBox1.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).DataField = "Insured";
    this.textBox2.DistinctField = (string) null;
    this.textBox2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox2).Location = (PointF) componentResourceManager.GetObject("textBox2.Location");
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.OutputFormat = (string) null;
    ((ARControl) this.textBox2).Size = new SizeF(2f, 0.125f);
    this.textBox2.Text = (string) null;
    this.textBox2.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).DataField = "LossDate";
    this.textBox3.DistinctField = (string) null;
    this.textBox3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox3).Location = (PointF) componentResourceManager.GetObject("textBox3.Location");
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.textBox3).Size = new SizeF(15f / 16f, 0.125f);
    this.textBox3.Text = (string) null;
    this.textBox3.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).DataField = "ClaimNumber";
    this.textBox4.DistinctField = (string) null;
    this.textBox4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox4).Location = (PointF) componentResourceManager.GetObject("textBox4.Location");
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.OutputFormat = (string) null;
    ((ARControl) this.textBox4).Size = new SizeF(23f / 16f, 0.125f);
    this.textBox4.Text = (string) null;
    this.textBox4.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).DataField = "Time";
    this.textBox5.DistinctField = (string) null;
    this.textBox5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox5).Location = (PointF) componentResourceManager.GetObject("textBox5.Location");
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = (string) null;
    ((ARControl) this.textBox5).Size = new SizeF(0.75f, 0.125f);
    this.textBox5.Text = (string) null;
    this.textBox5.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).DataField = "Hourly";
    this.textBox6.DistinctField = (string) null;
    this.textBox6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox6).Location = (PointF) componentResourceManager.GetObject("textBox6.Location");
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox6).Size = new SizeF(15f / 16f, 0.125f);
    this.textBox6.Text = (string) null;
    this.textBox6.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox7.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).DataField = "Equipment";
    this.textBox7.DistinctField = (string) null;
    this.textBox7.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox7).Location = (PointF) componentResourceManager.GetObject("textBox7.Location");
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox7).Size = new SizeF(1f, 0.125f);
    this.textBox7.Text = (string) null;
    this.textBox7.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).DataField = "Other";
    this.textBox8.DistinctField = (string) null;
    this.textBox8.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox8).Location = (PointF) componentResourceManager.GetObject("textBox8.Location");
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox8).Size = new SizeF(0.875f, 0.125f);
    this.textBox8.Text = (string) null;
    this.textBox8.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).DataField = "Total";
    this.textBox9.DistinctField = (string) null;
    this.textBox9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox9).Location = (PointF) componentResourceManager.GetObject("textBox9.Location");
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox9).Size = new SizeF(17f / 16f, 0.125f);
    this.textBox9.Text = (string) null;
    this.textBox9.VerticalAlignment = (VerticalTextAlignment) 1;
    this.reportHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Name = "reportHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.label11,
      (ARControl) this.txtRecordCount,
      (ARControl) this.textBox11,
      (ARControl) this.textBox12,
      (ARControl) this.textBox13,
      (ARControl) this.textBox14,
      (ARControl) this.textBox15,
      (ARControl) this.label12,
      (ARControl) this.label13
    });
    this.reportFooter1.Height = 0.9791667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Name = "reportFooter1";
    this.label11.BackColor = Color.LightGray;
    ((ARControl) this.label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.TopStyle = (BorderLineStyle) 0;
    this.label11.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Location = (PointF) componentResourceManager.GetObject("label11.Location");
    ((ARControl) this.label11).Name = "label11";
    ((ARControl) this.label11).Size = new SizeF(11f / 16f, 3f / 16f);
    this.label11.Text = " TOTALS:";
    this.label11.VerticalAlignment = (VerticalTextAlignment) 1;
    this.txtRecordCount.BackColor = Color.LightGray;
    ((ARControl) this.txtRecordCount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRecordCount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRecordCount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtRecordCount).Border.TopStyle = (BorderLineStyle) 0;
    this.txtRecordCount.DistinctField = (string) null;
    this.txtRecordCount.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.txtRecordCount).Location = (PointF) componentResourceManager.GetObject("txtRecordCount.Location");
    ((ARControl) this.txtRecordCount).Name = "txtRecordCount";
    this.txtRecordCount.OutputFormat = (string) null;
    ((ARControl) this.txtRecordCount).Size = new SizeF(79f / 16f, 3f / 16f);
    this.txtRecordCount.Text = (string) null;
    this.txtRecordCount.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox11.Alignment = (TextAlignment) 2;
    this.textBox11.BackColor = Color.LightGray;
    ((ARControl) this.textBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).DataField = "Time";
    this.textBox11.DistinctField = (string) null;
    this.textBox11.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox11).Location = (PointF) componentResourceManager.GetObject("textBox11.Location");
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.OutputFormat = "#,##0.00";
    ((ARControl) this.textBox11).Size = new SizeF(0.75f, 3f / 16f);
    this.textBox11.SummaryRunning = (SummaryRunning) 2;
    this.textBox11.SummaryType = (SummaryType) 1;
    this.textBox11.Text = (string) null;
    this.textBox11.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox12.Alignment = (TextAlignment) 2;
    this.textBox12.BackColor = Color.LightGray;
    ((ARControl) this.textBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).DataField = "Hourly";
    this.textBox12.DistinctField = (string) null;
    this.textBox12.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox12).Location = (PointF) componentResourceManager.GetObject("textBox12.Location");
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox12).Size = new SizeF(15f / 16f, 3f / 16f);
    this.textBox12.SummaryRunning = (SummaryRunning) 2;
    this.textBox12.SummaryType = (SummaryType) 1;
    this.textBox12.Text = (string) null;
    this.textBox12.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox13.Alignment = (TextAlignment) 2;
    this.textBox13.BackColor = Color.LightGray;
    ((ARControl) this.textBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).DataField = "Equipment";
    this.textBox13.DistinctField = (string) null;
    this.textBox13.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox13).Location = (PointF) componentResourceManager.GetObject("textBox13.Location");
    ((ARControl) this.textBox13).Name = "textBox13";
    this.textBox13.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox13).Size = new SizeF(1f, 3f / 16f);
    this.textBox13.SummaryRunning = (SummaryRunning) 2;
    this.textBox13.SummaryType = (SummaryType) 1;
    this.textBox13.Text = (string) null;
    this.textBox13.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox14.Alignment = (TextAlignment) 2;
    this.textBox14.BackColor = Color.LightGray;
    ((ARControl) this.textBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).DataField = "Other";
    this.textBox14.DistinctField = (string) null;
    this.textBox14.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox14).Location = (PointF) componentResourceManager.GetObject("textBox14.Location");
    ((ARControl) this.textBox14).Name = "textBox14";
    this.textBox14.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox14).Size = new SizeF(0.875f, 3f / 16f);
    this.textBox14.SummaryRunning = (SummaryRunning) 2;
    this.textBox14.SummaryType = (SummaryType) 1;
    this.textBox14.Text = (string) null;
    this.textBox14.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox15.Alignment = (TextAlignment) 2;
    this.textBox15.BackColor = Color.LightGray;
    ((ARControl) this.textBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).DataField = "Total";
    this.textBox15.DistinctField = (string) null;
    this.textBox15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox15).Location = (PointF) componentResourceManager.GetObject("textBox15.Location");
    ((ARControl) this.textBox15).Name = "textBox15";
    this.textBox15.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox15).Size = new SizeF(17f / 16f, 3f / 16f);
    this.textBox15.SummaryRunning = (SummaryRunning) 2;
    this.textBox15.SummaryType = (SummaryType) 1;
    this.textBox15.Text = (string) null;
    this.textBox15.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label12).Border.TopStyle = (BorderLineStyle) 0;
    this.label12.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label12.HyperLink = (string) null;
    ((ARControl) this.label12).Location = (PointF) componentResourceManager.GetObject("label12.Location");
    ((ARControl) this.label12).Name = "label12";
    ((ARControl) this.label12).Size = new SizeF(23f / 16f, 3f / 16f);
    this.label12.Text = " Claims Manager:";
    this.label12.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label13).Border.TopStyle = (BorderLineStyle) 0;
    this.label13.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label13.HyperLink = (string) null;
    ((ARControl) this.label13).Location = (PointF) componentResourceManager.GetObject("label13.Location");
    ((ARControl) this.label13).Name = "label13";
    ((ARControl) this.label13).Size = new SizeF(41f / 16f, 3f / 16f);
    this.label13.Text = "";
    this.label13.VerticalAlignment = (VerticalTextAlignment) 1;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Controls.AddRange(new ARControl[14]
    {
      (ARControl) this.textBox10,
      (ARControl) this.textBox16,
      (ARControl) this.textBox17,
      (ARControl) this.textBox18,
      (ARControl) this.label15,
      (ARControl) this.label16,
      (ARControl) this.label17,
      (ARControl) this.label18,
      (ARControl) this.label19,
      (ARControl) this.label20,
      (ARControl) this.label21,
      (ARControl) this.label22,
      (ARControl) this.label23,
      (ARControl) this.textBox20
    });
    this.groupHeader1.DataField = "CompanyName";
    this.groupHeader1.Height = 19f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Name = "groupHeader1";
    this.groupHeader1.NewPage = (NewPage) 1;
    ((ARControl) this.textBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox10.DistinctField = (string) null;
    this.textBox10.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox10).Location = (PointF) componentResourceManager.GetObject("textBox10.Location");
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.OutputFormat = (string) null;
    ((ARControl) this.textBox10).Size = new SizeF(1f, 3f / 16f);
    this.textBox10.Text = (string) null;
    this.textBox10.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox16).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox16.DistinctField = (string) null;
    this.textBox16.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox16).Location = (PointF) componentResourceManager.GetObject("textBox16.Location");
    ((ARControl) this.textBox16).Name = "textBox16";
    this.textBox16.OutputFormat = (string) null;
    ((ARControl) this.textBox16).Size = new SizeF(7.875f, 3f / 16f);
    this.textBox16.Text = (string) null;
    this.textBox16.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox17).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox17.DistinctField = (string) null;
    this.textBox17.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox17).Location = (PointF) componentResourceManager.GetObject("textBox17.Location");
    ((ARControl) this.textBox17).Name = "textBox17";
    this.textBox17.OutputFormat = (string) null;
    ((ARControl) this.textBox17).Size = new SizeF(7.875f, 3f / 16f);
    this.textBox17.Text = (string) null;
    this.textBox17.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox18).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox18.DistinctField = (string) null;
    this.textBox18.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox18).Location = (PointF) componentResourceManager.GetObject("textBox18.Location");
    ((ARControl) this.textBox18).Name = "textBox18";
    this.textBox18.OutputFormat = (string) null;
    ((ARControl) this.textBox18).Size = new SizeF(7.875f, 3f / 16f);
    this.textBox18.Text = "Billing Recap for {0} to {1}";
    this.textBox18.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label15).Border.TopStyle = (BorderLineStyle) 0;
    this.label15.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label15.HyperLink = (string) null;
    ((ARControl) this.label15).Location = (PointF) componentResourceManager.GetObject("label15.Location");
    ((ARControl) this.label15).Name = "label15";
    ((ARControl) this.label15).Size = new SizeF(19f / 16f, 3f / 16f);
    this.label15.Text = "Policy";
    this.label15.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label16).Border.TopStyle = (BorderLineStyle) 0;
    this.label16.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label16.HyperLink = (string) null;
    ((ARControl) this.label16).Location = (PointF) componentResourceManager.GetObject("label16.Location");
    ((ARControl) this.label16).Name = "label16";
    ((ARControl) this.label16).Size = new SizeF(2f, 3f / 16f);
    this.label16.Text = "Insured  Name";
    this.label16.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label17).Border.TopStyle = (BorderLineStyle) 0;
    this.label17.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label17.HyperLink = (string) null;
    ((ARControl) this.label17).Location = (PointF) componentResourceManager.GetObject("label17.Location");
    ((ARControl) this.label17).Name = "label17";
    ((ARControl) this.label17).Size = new SizeF(15f / 16f, 3f / 16f);
    this.label17.Text = "Loss Date";
    this.label17.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label18).Border.TopStyle = (BorderLineStyle) 0;
    this.label18.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label18.HyperLink = (string) null;
    ((ARControl) this.label18).Location = (PointF) componentResourceManager.GetObject("label18.Location");
    ((ARControl) this.label18).Name = "label18";
    ((ARControl) this.label18).Size = new SizeF(23f / 16f, 3f / 16f);
    this.label18.Text = "Claim #";
    this.label18.VerticalAlignment = (VerticalTextAlignment) 1;
    this.label19.Alignment = (TextAlignment) 2;
    ((ARControl) this.label19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label19).Border.TopStyle = (BorderLineStyle) 0;
    this.label19.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label19.HyperLink = (string) null;
    ((ARControl) this.label19).Location = (PointF) componentResourceManager.GetObject("label19.Location");
    ((ARControl) this.label19).Name = "label19";
    ((ARControl) this.label19).Size = new SizeF(0.75f, 3f / 16f);
    this.label19.Text = "Time";
    this.label19.VerticalAlignment = (VerticalTextAlignment) 1;
    this.label20.Alignment = (TextAlignment) 2;
    ((ARControl) this.label20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label20).Border.TopStyle = (BorderLineStyle) 0;
    this.label20.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label20.HyperLink = (string) null;
    ((ARControl) this.label20).Location = (PointF) componentResourceManager.GetObject("label20.Location");
    ((ARControl) this.label20).Name = "label20";
    ((ARControl) this.label20).Size = new SizeF(15f / 16f, 3f / 16f);
    this.label20.Text = "Hourly";
    this.label20.VerticalAlignment = (VerticalTextAlignment) 1;
    this.label21.Alignment = (TextAlignment) 2;
    ((ARControl) this.label21).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label21).Border.TopStyle = (BorderLineStyle) 0;
    this.label21.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label21.HyperLink = (string) null;
    ((ARControl) this.label21).Location = (PointF) componentResourceManager.GetObject("label21.Location");
    ((ARControl) this.label21).Name = "label21";
    ((ARControl) this.label21).Size = new SizeF(1f, 3f / 16f);
    this.label21.Text = "Equipment";
    this.label21.VerticalAlignment = (VerticalTextAlignment) 1;
    this.label22.Alignment = (TextAlignment) 2;
    ((ARControl) this.label22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label22).Border.TopStyle = (BorderLineStyle) 0;
    this.label22.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label22.HyperLink = (string) null;
    ((ARControl) this.label22).Location = (PointF) componentResourceManager.GetObject("label22.Location");
    ((ARControl) this.label22).Name = "label22";
    ((ARControl) this.label22).Size = new SizeF(0.875f, 3f / 16f);
    this.label22.Text = "Other";
    this.label22.VerticalAlignment = (VerticalTextAlignment) 1;
    this.label23.Alignment = (TextAlignment) 2;
    ((ARControl) this.label23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label23).Border.TopStyle = (BorderLineStyle) 0;
    this.label23.Font = new Font("Arial", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label23.HyperLink = (string) null;
    ((ARControl) this.label23).Location = (PointF) componentResourceManager.GetObject("label23.Location");
    ((ARControl) this.label23).Name = "label23";
    ((ARControl) this.label23).Size = new SizeF(17f / 16f, 3f / 16f);
    this.label23.Text = "Total";
    this.label23.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox20).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox20.DistinctField = (string) null;
    this.textBox20.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox20).Location = (PointF) componentResourceManager.GetObject("textBox20.Location");
    ((ARControl) this.textBox20).Name = "textBox20";
    this.textBox20.OutputFormat = (string) null;
    ((ARControl) this.textBox20).Size = new SizeF(0.875f, 3f / 16f);
    this.textBox20.Text = "Report Date:";
    this.textBox20.VerticalAlignment = (VerticalTextAlignment) 1;
    this.groupFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Name = "groupFooter1";
    ((SectionReport) this).PageSettings.Margins.Bottom = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Left = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Right = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Top = 0.3f;
    ((SectionReport) this).PageSettings.Orientation = (PageOrientation) 2;
    ((SectionReport) this).PageSettings.PaperHeight = 11f;
    ((SectionReport) this).PageSettings.PaperWidth = 8.5f;
    ((SectionReport) this).PrintWidth = 10.275f;
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1);
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.txtRecordCount).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.textBox13).EndInit();
    ((ISupportInitialize) this.textBox14).EndInit();
    ((ISupportInitialize) this.textBox15).EndInit();
    ((ISupportInitialize) this.label12).EndInit();
    ((ISupportInitialize) this.label13).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this.textBox16).EndInit();
    ((ISupportInitialize) this.textBox17).EndInit();
    ((ISupportInitialize) this.textBox18).EndInit();
    ((ISupportInitialize) this.label15).EndInit();
    ((ISupportInitialize) this.label16).EndInit();
    ((ISupportInitialize) this.label17).EndInit();
    ((ISupportInitialize) this.label18).EndInit();
    ((ISupportInitialize) this.label19).EndInit();
    ((ISupportInitialize) this.label20).EndInit();
    ((ISupportInitialize) this.label21).EndInit();
    ((ISupportInitialize) this.label22).EndInit();
    ((ISupportInitialize) this.label23).EndInit();
    ((ISupportInitialize) this.textBox20).EndInit();
  }
}
