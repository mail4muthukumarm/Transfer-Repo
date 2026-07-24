// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Reports.LossAmountReport
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
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
using System.Drawing;

#nullable disable
namespace MGASystems.IMS.Claims.Reports;

[SecureReportResource("{87D26CFA-E4C2-42b6-909A-DAD2A527B1BE}", "Loss Amount Report", "Loss Amount Report", "Claims")]
public class LossAmountReport : MGAReport, IReport, ISupportReportDictionary
{
  private DateTime _datefrom;
  private DateTime _dateto;
  private string _companyGuid;
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
  private Label label4;
  private Label label5;
  private Label label6;
  private Label label7;
  private Label label8;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox textBox6;
  private Label label10;
  private TextBox textBox7;
  private Label label11;
  private TextBox textBox9;

  public LossAmountReport() => this.InitializeComponent();

  public LossAmountReport(DateTime datefrom, DateTime dateto, string companyGuid)
  {
    this.InitializeComponent();
    this._datefrom = datefrom;
    this._dateto = dateto;
    this._companyGuid = companyGuid;
  }

  private void pageHeader_Format(object sender, EventArgs e)
  {
    this.textBox1.Text = DateTime.Now.ToShortDateString();
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.label11.Text = $"Loss Amounts Report for {this._datefrom.ToShortDateString()} to {this._dateto.ToShortDateString()}";
    this.label2.Text = this._ds.Tables[0].Rows[0]["MGAName"].ToString();
    this.label3.Text = this._ds.Tables[0].Rows[0]["CompanyName"].ToString();
  }

  private void groupFooter1_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count > 0)
      this.textBox7.Value = (object) this._ds.Tables[0].Rows.Count;
    else
      this.textBox7.Value = (object) 0;
  }

  private void LossAmountReport_ReportStart(object sender, EventArgs e)
  {
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spClaims_rptLossAmounts", connection);
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
        (BaseReportControl) new GenericListBox("Company", "SELECT DISTINCT CompanyName AS Display,CompanyGuid as Value From tblCompanies  Order by CompanyName", "Value", "Display", true, typeof (Guid), true, false, 250)
      };
    }
  }

  public virtual bool IsThreaded => true;

  public virtual void ExportToExcel(string SaveFileTo) => ExcelExport.ToExcel(this._ds, SaveFileTo);

  string[] ISupportReportDictionary.FieldDescriptions
  {
    get
    {
      return new string[10]
      {
        "Loss Amount",
        "The sum of all reserves and payments within the specifed date range for the claim.",
        "Insured Name",
        "The name of the insured on the policy.",
        "Claim Number",
        "The claim number assigned to the claim.",
        "Loss Date",
        "This date of loss on the claim.",
        "Policy Number",
        "Displays the policy number."
      };
    }
  }

  string ISupportReportDictionary.GeneralDescription
  {
    get
    {
      return "This report provides you with a listing of the sum of all reserves and payments within the specified date range by claim.";
    }
  }

  string ISupportReportDictionary.ReportFriendlyName => "Loss Amount Report";

  string[] ISupportReportDictionary.SearchCriteriaDescription
  {
    get
    {
      return new string[4]
      {
        "Date Range",
        "Limits the data returned to reserves and payments within the specifed date range. This field is required",
        "Company",
        "This search criteria is optional. This will further limit the result set to the company selected."
      };
    }
  }

  string[] ISupportReportDictionary.SortingAndTotalsDescription
  {
    get
    {
      return new string[4]
      {
        "Total Matching Request",
        "Shows the number of records that matched your search criteria.",
        "Grand Total",
        "Shows the sum of all loss amounts listed."
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (LossAmountReport));
    this.pageHeader = new PageHeader();
    this.label1 = new Label();
    this.textBox1 = new TextBox();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label11 = new Label();
    this.detail = new Detail();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.pageFooter = new PageFooter();
    this.groupHeader1 = new GroupHeader();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.groupFooter1 = new GroupFooter();
    this.label10 = new Label();
    this.textBox7 = new TextBox();
    this.textBox9 = new TextBox();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.label1,
      (ARControl) this.textBox1,
      (ARControl) this.label2,
      (ARControl) this.label3,
      (ARControl) this.label11
    });
    this.pageHeader.Height = 31f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Name = "pageHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Format += new EventHandler(this.pageHeader_Format);
    ((ARControl) this.label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.TopStyle = (BorderLineStyle) 0;
    this.label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Location = (PointF) componentResourceManager.GetObject("label1.Location");
    ((ARControl) this.label1).Name = "label1";
    ((ARControl) this.label1).Size = new SizeF(0.875f, 3f / 16f);
    this.label1.Text = "Report Date:";
    this.label1.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox1.DistinctField = (string) null;
    this.textBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox1).Location = (PointF) componentResourceManager.GetObject("textBox1.Location");
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.OutputFormat = (string) null;
    ((ARControl) this.textBox1).Size = new SizeF(109f / 16f, 3f / 16f);
    this.textBox1.Text = (string) null;
    this.textBox1.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label2).Border.TopStyle = (BorderLineStyle) 0;
    this.label2.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Location = (PointF) componentResourceManager.GetObject("label2.Location");
    ((ARControl) this.label2).Name = "label2";
    ((ARControl) this.label2).Size = new SizeF(123f / 16f, 3f / 16f);
    this.label2.Text = "South Valley Claims";
    this.label2.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label3).Border.TopStyle = (BorderLineStyle) 0;
    this.label3.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Location = (PointF) componentResourceManager.GetObject("label3.Location");
    ((ARControl) this.label3).Name = "label3";
    ((ARControl) this.label3).Size = new SizeF(123f / 16f, 3f / 16f);
    this.label3.Text = "";
    this.label3.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.TopStyle = (BorderLineStyle) 0;
    this.label11.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Location = (PointF) componentResourceManager.GetObject("label11.Location");
    ((ARControl) this.label11).Name = "label11";
    ((ARControl) this.label11).Size = new SizeF(123f / 16f, 3f / 16f);
    this.label11.Text = "";
    this.label11.VerticalAlignment = (VerticalTextAlignment) 1;
    this.detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((ARControl) this.textBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).DataField = "PolicyNumber";
    this.textBox2.DistinctField = (string) null;
    this.textBox2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox2).Location = (PointF) componentResourceManager.GetObject("textBox2.Location");
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.OutputFormat = (string) null;
    ((ARControl) this.textBox2).Size = new SizeF(25f / 16f, 0.125f);
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
    ((ARControl) this.textBox3).Size = new SizeF(11f / 16f, 0.125f);
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
    ((ARControl) this.textBox4).Size = new SizeF(1.625f, 0.125f);
    this.textBox4.Text = (string) null;
    this.textBox4.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).DataField = "InsuredName";
    this.textBox5.DistinctField = (string) null;
    this.textBox5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox5).Location = (PointF) componentResourceManager.GetObject("textBox5.Location");
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = (string) null;
    ((ARControl) this.textBox5).Size = new SizeF(45f / 16f, 0.125f);
    this.textBox5.Text = (string) null;
    this.textBox5.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).DataField = "Losses";
    this.textBox6.DistinctField = (string) null;
    this.textBox6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox6).Location = (PointF) componentResourceManager.GetObject("textBox6.Location");
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox6).Size = new SizeF(19f / 16f, 0.125f);
    this.textBox6.Text = (string) null;
    this.textBox6.VerticalAlignment = (VerticalTextAlignment) 1;
    this.pageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Name = "pageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.label4,
      (ARControl) this.label5,
      (ARControl) this.label6,
      (ARControl) this.label7,
      (ARControl) this.label8
    });
    this.groupHeader1.Height = 0.1770833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Name = "groupHeader1";
    ((ARControl) this.label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.TopStyle = (BorderLineStyle) 0;
    this.label4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Location = (PointF) componentResourceManager.GetObject("label4.Location");
    ((ARControl) this.label4).Name = "label4";
    ((ARControl) this.label4).Size = new SizeF(25f / 16f, 3f / 16f);
    this.label4.Text = "Policy Number";
    this.label4.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.TopStyle = (BorderLineStyle) 0;
    this.label5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Location = (PointF) componentResourceManager.GetObject("label5.Location");
    ((ARControl) this.label5).Name = "label5";
    ((ARControl) this.label5).Size = new SizeF(11f / 16f, 3f / 16f);
    this.label5.Text = "Loss Date";
    this.label5.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.TopStyle = (BorderLineStyle) 0;
    this.label6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Location = (PointF) componentResourceManager.GetObject("label6.Location");
    ((ARControl) this.label6).Name = "label6";
    ((ARControl) this.label6).Size = new SizeF(1.625f, 3f / 16f);
    this.label6.Text = "Claim Number";
    this.label6.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.TopStyle = (BorderLineStyle) 0;
    this.label7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Location = (PointF) componentResourceManager.GetObject("label7.Location");
    ((ARControl) this.label7).Name = "label7";
    ((ARControl) this.label7).Size = new SizeF(45f / 16f, 3f / 16f);
    this.label7.Text = "Insured Name";
    this.label7.VerticalAlignment = (VerticalTextAlignment) 1;
    this.label8.Alignment = (TextAlignment) 2;
    ((ARControl) this.label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.TopStyle = (BorderLineStyle) 0;
    this.label8.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Location = (PointF) componentResourceManager.GetObject("label8.Location");
    ((ARControl) this.label8).Name = "label8";
    ((ARControl) this.label8).Size = new SizeF(19f / 16f, 3f / 16f);
    this.label8.Text = "Loss Amount";
    this.label8.VerticalAlignment = (VerticalTextAlignment) 1;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.label10,
      (ARControl) this.textBox7,
      (ARControl) this.textBox9
    });
    this.groupFooter1.Height = 0.2291667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Name = "groupFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Format += new EventHandler(this.groupFooter1_Format);
    this.label10.BackColor = Color.LightGray;
    ((ARControl) this.label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label10).Border.TopStyle = (BorderLineStyle) 0;
    this.label10.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Location = (PointF) componentResourceManager.GetObject("label10.Location");
    ((ARControl) this.label10).Name = "label10";
    ((ARControl) this.label10).Size = new SizeF(1.5f, 3f / 16f);
    this.label10.Text = "Total  Matching Request:";
    this.label10.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox7.BackColor = Color.LightGray;
    ((ARControl) this.textBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox7.DistinctField = (string) null;
    this.textBox7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox7).Location = (PointF) componentResourceManager.GetObject("textBox7.Location");
    ((ARControl) this.textBox7).Name = "textBox7";
    ((ARControl) this.textBox7).Size = new SizeF(4.5f, 3f / 16f);
    this.textBox7.Text = (string) null;
    this.textBox7.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox9.Alignment = (TextAlignment) 2;
    this.textBox9.BackColor = Color.LightGray;
    ((ARControl) this.textBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).DataField = "Losses";
    this.textBox9.DistinctField = (string) null;
    this.textBox9.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox9).Location = (PointF) componentResourceManager.GetObject("textBox9.Location");
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox9).Size = new SizeF(1.875f, 3f / 16f);
    this.textBox9.SummaryGroup = "groupHeader1";
    this.textBox9.SummaryRunning = (SummaryRunning) 1;
    this.textBox9.SummaryType = (SummaryType) 3;
    this.textBox9.Text = (string) null;
    this.textBox9.VerticalAlignment = (VerticalTextAlignment) 1;
    ((SectionReport) this).PageSettings.Margins.Bottom = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Left = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Right = 0.3f;
    ((SectionReport) this).PageSettings.Margins.Top = 0.3f;
    ((SectionReport) this).PageSettings.PaperHeight = 11f;
    ((SectionReport) this).PageSettings.PaperWidth = 8.5f;
    ((SectionReport) this).PrintWidth = 7.9f;
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1);
    ((SectionReport) this).Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter);
    ((SectionReport) this).ReportStart += new EventHandler(this.LossAmountReport_ReportStart);
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
  }
}
