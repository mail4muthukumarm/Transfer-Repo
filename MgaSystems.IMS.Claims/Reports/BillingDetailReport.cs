// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Reports.BillingDetailReport
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

[SecureReportResource("{C41652A4-EDB4-446d-93BC-41410E78DABF}", "Billing Detail Report", "Billing Detail Report", "Claims")]
public class BillingDetailReport : MGAReport, IReport, ISupportReportDictionary
{
  private DateTime _datefrom;
  private DateTime _dateto;
  private string _claimNumber;
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
  private Label label5;
  private Label label6;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private Label label9;
  private Label label11;
  private Label label7;
  private Label label8;
  private Label label12;
  private Label label13;
  private Label label15;
  private Label label16;
  private TextBox textBox6;
  private TextBox textBox9;
  private TextBox textBox10;
  private TextBox textBox11;
  private TextBox textBox12;
  private TextBox textBox13;
  private TextBox textBox14;
  private TextBox textBox7;
  private TextBox textBox8;
  private TextBox textBox15;
  private TextBox textBox16;
  private Label label4;
  private TextBox textBox17;

  public BillingDetailReport() => this.InitializeComponent();

  public BillingDetailReport(DateTime datefrom, DateTime dateto, string claimNumber)
  {
    this.InitializeComponent();
    this._datefrom = datefrom;
    this._dateto = dateto;
    this._claimNumber = claimNumber;
  }

  private void pageHeader_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.textBox17.Text = $"Billing Detail Report for {this._datefrom.ToShortDateString()}  to {this._dateto.ToShortDateString()}";
    this.label2.Text = this._ds.Tables[0].Rows[0]["MGAName"].ToString();
    this.label3.Text = this._ds.Tables[0].Rows[0]["CompanyName"].ToString();
    this.textBox1.Text = DateTime.Now.ToShortDateString();
  }

  private void BillingDetailReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spClaims_rptBillingDetailReport", connection);
    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
    this._ds = new DataSet();
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Parameters.AddWithValue("@Datefrom", (object) this._datefrom);
    selectCommand.Parameters.AddWithValue("@Dateto", (object) this._dateto);
    selectCommand.Parameters.AddWithValue("@claimNumber", (object) this._claimNumber);
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
    ((SectionReport) this).DataSource = (object) this._ds.Tables[2];
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DateRangePicker("Effective Date Range", false),
        (BaseReportControl) new TextInput("Claim #", true, false)
      };
    }
  }

  private void groupHeader1_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[1].Rows.Count <= 0)
      return;
    this.textBox3.Text = this._ds.Tables[1].Rows[0]["LossDate"].ToString();
    this.textBox4.Text = this._ds.Tables[1].Rows[0]["ClaimNumber"].ToString();
    this.textBox5.Text = this._ds.Tables[1].Rows[0]["InsuredName"].ToString();
    this.textBox2.Text = this._ds.Tables[1].Rows[0]["PolicyNumber"].ToString();
  }

  public virtual bool IsThreaded => true;

  public virtual void ExportToExcel(string SaveFileTo) => ExcelExport.ToExcel(this._ds, SaveFileTo);

  string[] ISupportReportDictionary.FieldDescriptions
  {
    get
    {
      return new string[20]
      {
        "Other",
        "Displays any other charges for the unallocated expense.",
        "Equipment",
        "Shows the equipment charges for the unallocated expense",
        "Hourly",
        "Displays any hourly charges for the unallocted expense.",
        "Time",
        "Displays the time spent for the unallocated expense.",
        "Activity Description",
        "Shows the name/type of unallocated expense entered.",
        "Date",
        "Displays the date the unallocated expense was entered.",
        "Loss Date",
        "The date of loss.",
        "Insured",
        "Shows the insured name on the policy.",
        "Policy",
        "Displays the policy number.",
        "Claim Number",
        "Displays the claim number."
      };
    }
  }

  string ISupportReportDictionary.GeneralDescription
  {
    get
    {
      return "Displays the unallocated loss expense for a specific claim between the specified date range.";
    }
  }

  string ISupportReportDictionary.ReportFriendlyName => "Billing Detail Report";

  string[] ISupportReportDictionary.SearchCriteriaDescription
  {
    get
    {
      return new string[4]
      {
        "Claim Number",
        "Specifies the claim for which you would like to run the report. This criteria is required.",
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (BillingDetailReport));
    this.pageHeader = new PageHeader();
    this.label1 = new Label();
    this.textBox1 = new TextBox();
    this.label2 = new Label();
    this.label3 = new Label();
    this.textBox17 = new TextBox();
    this.detail = new Detail();
    this.textBox6 = new TextBox();
    this.textBox9 = new TextBox();
    this.textBox10 = new TextBox();
    this.textBox11 = new TextBox();
    this.textBox12 = new TextBox();
    this.textBox13 = new TextBox();
    this.textBox14 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.pageFooter = new PageFooter();
    this.groupHeader1 = new GroupHeader();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label11 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label12 = new Label();
    this.label13 = new Label();
    this.label15 = new Label();
    this.label16 = new Label();
    this.label4 = new Label();
    this.groupFooter1 = new GroupFooter();
    this.label9 = new Label();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.textBox15 = new TextBox();
    this.textBox16 = new TextBox();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.textBox17).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.textBox10).BeginInit();
    ((ISupportInitialize) this.textBox11).BeginInit();
    ((ISupportInitialize) this.textBox12).BeginInit();
    ((ISupportInitialize) this.textBox13).BeginInit();
    ((ISupportInitialize) this.textBox14).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label12).BeginInit();
    ((ISupportInitialize) this.label13).BeginInit();
    ((ISupportInitialize) this.label15).BeginInit();
    ((ISupportInitialize) this.label16).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.textBox15).BeginInit();
    ((ISupportInitialize) this.textBox16).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageHeader).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.label1,
      (ARControl) this.textBox1,
      (ARControl) this.label2,
      (ARControl) this.label3,
      (ARControl) this.textBox17
    });
    this.pageHeader.Height = 0.9895833f;
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
    ((ARControl) this.label1).Size = new SizeF(15f / 16f, 3f / 16f);
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
    this.textBox1.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.textBox1).Size = new SizeF(15f / 16f, 3f / 16f);
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
    ((ARControl) this.label2).Size = new SizeF(7.9f, 0.188f);
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
    ((ARControl) this.label3).Size = new SizeF(7.9f, 0.188f);
    this.label3.Text = "";
    this.label3.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox17).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox17.DistinctField = (string) null;
    this.textBox17.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox17).Location = (PointF) componentResourceManager.GetObject("textBox17.Location");
    ((ARControl) this.textBox17).Name = "textBox17";
    this.textBox17.OutputFormat = (string) null;
    ((ARControl) this.textBox17).Size = new SizeF(7.9f, 0.188f);
    this.textBox17.Text = (string) null;
    this.textBox17.VerticalAlignment = (VerticalTextAlignment) 1;
    this.detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.textBox6,
      (ARControl) this.textBox9,
      (ARControl) this.textBox10,
      (ARControl) this.textBox11,
      (ARControl) this.textBox12,
      (ARControl) this.textBox13,
      (ARControl) this.textBox14
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.3958333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((ARControl) this.textBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).DataField = "DateEntered";
    this.textBox6.DistinctField = (string) null;
    this.textBox6.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox6).Location = (PointF) componentResourceManager.GetObject("textBox6.Location");
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.textBox6).Size = new SizeF(11f / 16f, 3f / 16f);
    this.textBox6.Text = (string) null;
    this.textBox6.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox9).DataField = "Expense";
    this.textBox9.DistinctField = (string) null;
    this.textBox9.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox9).Location = (PointF) componentResourceManager.GetObject("textBox9.Location");
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = (string) null;
    ((ARControl) this.textBox9).Size = new SizeF(73f / 16f, 3f / 16f);
    this.textBox9.Text = (string) null;
    this.textBox9.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox10).DataField = "Comments";
    this.textBox10.DistinctField = (string) null;
    this.textBox10.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox10).Location = (PointF) componentResourceManager.GetObject("textBox10.Location");
    ((ARControl) this.textBox10).Name = "textBox10";
    this.textBox10.OutputFormat = (string) null;
    ((ARControl) this.textBox10).Size = new SizeF(115f / 16f, 3f / 16f);
    this.textBox10.Text = (string) null;
    this.textBox10.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox11.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox11).DataField = "Hours";
    this.textBox11.DistinctField = (string) null;
    this.textBox11.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox11).Location = (PointF) componentResourceManager.GetObject("textBox11.Location");
    ((ARControl) this.textBox11).Name = "textBox11";
    this.textBox11.OutputFormat = "#,##0;(#,##0)";
    ((ARControl) this.textBox11).Size = new SizeF(9f / 16f, 3f / 16f);
    this.textBox11.Text = (string) null;
    this.textBox11.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox12.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox12).DataField = "HourlyTotal";
    this.textBox12.DistinctField = (string) null;
    this.textBox12.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox12).Location = (PointF) componentResourceManager.GetObject("textBox12.Location");
    ((ARControl) this.textBox12).Name = "textBox12";
    this.textBox12.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox12).Size = new SizeF(9f / 16f, 3f / 16f);
    this.textBox12.Text = (string) null;
    this.textBox12.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox13.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox13).DataField = "EquipmentTotal";
    this.textBox13.DistinctField = (string) null;
    this.textBox13.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox13).Location = (PointF) componentResourceManager.GetObject("textBox13.Location");
    ((ARControl) this.textBox13).Name = "textBox13";
    this.textBox13.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox13).Size = new SizeF(13f / 16f, 3f / 16f);
    this.textBox13.Text = (string) null;
    this.textBox13.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox14.Alignment = (TextAlignment) 2;
    ((ARControl) this.textBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox14).DataField = "OtherTotal";
    this.textBox14.DistinctField = (string) null;
    this.textBox14.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox14).Location = (PointF) componentResourceManager.GetObject("textBox14.Location");
    ((ARControl) this.textBox14).Name = "textBox14";
    this.textBox14.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox14).Size = new SizeF(11f / 16f, 3f / 16f);
    this.textBox14.Text = (string) null;
    this.textBox14.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox2.DistinctField = (string) null;
    this.textBox2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox2).Location = (PointF) componentResourceManager.GetObject("textBox2.Location");
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.OutputFormat = (string) null;
    ((ARControl) this.textBox2).Size = new SizeF(7.125f, 3f / 16f);
    this.textBox2.Text = (string) null;
    this.textBox2.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox3.DistinctField = (string) null;
    this.textBox3.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox3).Location = (PointF) componentResourceManager.GetObject("textBox3.Location");
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.textBox3).Size = new SizeF(7.125f, 3f / 16f);
    this.textBox3.Text = (string) null;
    this.textBox3.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox4.DistinctField = (string) null;
    this.textBox4.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox4).Location = (PointF) componentResourceManager.GetObject("textBox4.Location");
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.OutputFormat = (string) null;
    ((ARControl) this.textBox4).Size = new SizeF(7.125f, 3f / 16f);
    this.textBox4.Text = (string) null;
    this.textBox4.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.textBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox5.DistinctField = (string) null;
    this.textBox5.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox5).Location = (PointF) componentResourceManager.GetObject("textBox5.Location");
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.OutputFormat = (string) null;
    ((ARControl) this.textBox5).Size = new SizeF(7.125f, 3f / 16f);
    this.textBox5.Text = (string) null;
    this.textBox5.VerticalAlignment = (VerticalTextAlignment) 1;
    this.pageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.pageFooter).Name = "pageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Controls.AddRange(new ARControl[14]
    {
      (ARControl) this.textBox5,
      (ARControl) this.textBox2,
      (ARControl) this.label5,
      (ARControl) this.textBox3,
      (ARControl) this.label6,
      (ARControl) this.textBox4,
      (ARControl) this.label11,
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label12,
      (ARControl) this.label13,
      (ARControl) this.label15,
      (ARControl) this.label16,
      (ARControl) this.label4
    });
    this.groupHeader1.Height = 1.166667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Name = "groupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Format += new EventHandler(this.groupHeader1_Format);
    ((ARControl) this.label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.TopStyle = (BorderLineStyle) 0;
    this.label5.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Location = (PointF) componentResourceManager.GetObject("label5.Location");
    ((ARControl) this.label5).Name = "label5";
    ((ARControl) this.label5).Size = new SizeF(11f / 16f, 3f / 16f);
    this.label5.Text = "Loss Date:";
    this.label5.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.TopStyle = (BorderLineStyle) 0;
    this.label6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Location = (PointF) componentResourceManager.GetObject("label6.Location");
    ((ARControl) this.label6).Name = "label6";
    ((ARControl) this.label6).Size = new SizeF(11f / 16f, 3f / 16f);
    this.label6.Text = "Claim #:";
    this.label6.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.TopStyle = (BorderLineStyle) 0;
    this.label11.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Location = (PointF) componentResourceManager.GetObject("label11.Location");
    ((ARControl) this.label11).Name = "label11";
    ((ARControl) this.label11).Size = new SizeF(11f / 16f, 3f / 16f);
    this.label11.Text = "Insured:";
    this.label11.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.TopStyle = (BorderLineStyle) 0;
    this.label7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Location = (PointF) componentResourceManager.GetObject("label7.Location");
    ((ARControl) this.label7).Name = "label7";
    ((ARControl) this.label7).Size = new SizeF(11f / 16f, 3f / 16f);
    this.label7.Text = "Date";
    this.label7.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.TopStyle = (BorderLineStyle) 0;
    this.label8.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Location = (PointF) componentResourceManager.GetObject("label8.Location");
    ((ARControl) this.label8).Name = "label8";
    ((ARControl) this.label8).Size = new SizeF(73f / 16f, 3f / 16f);
    this.label8.Text = "Activity Description";
    this.label8.VerticalAlignment = (VerticalTextAlignment) 1;
    this.label12.Alignment = (TextAlignment) 2;
    ((ARControl) this.label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label12).Border.TopStyle = (BorderLineStyle) 0;
    this.label12.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label12.HyperLink = (string) null;
    ((ARControl) this.label12).Location = (PointF) componentResourceManager.GetObject("label12.Location");
    ((ARControl) this.label12).Name = "label12";
    ((ARControl) this.label12).Size = new SizeF(9f / 16f, 3f / 16f);
    this.label12.Text = "Time";
    this.label12.VerticalAlignment = (VerticalTextAlignment) 1;
    this.label13.Alignment = (TextAlignment) 2;
    ((ARControl) this.label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label13).Border.TopStyle = (BorderLineStyle) 0;
    this.label13.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label13.HyperLink = (string) null;
    ((ARControl) this.label13).Location = (PointF) componentResourceManager.GetObject("label13.Location");
    ((ARControl) this.label13).Name = "label13";
    ((ARControl) this.label13).Size = new SizeF(9f / 16f, 3f / 16f);
    this.label13.Text = "Hourly";
    this.label13.VerticalAlignment = (VerticalTextAlignment) 1;
    this.label15.Alignment = (TextAlignment) 2;
    ((ARControl) this.label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label15).Border.TopStyle = (BorderLineStyle) 0;
    this.label15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label15.HyperLink = (string) null;
    ((ARControl) this.label15).Location = (PointF) componentResourceManager.GetObject("label15.Location");
    ((ARControl) this.label15).Name = "label15";
    ((ARControl) this.label15).Size = new SizeF(13f / 16f, 3f / 16f);
    this.label15.Text = "Equipment";
    this.label15.VerticalAlignment = (VerticalTextAlignment) 1;
    this.label16.Alignment = (TextAlignment) 2;
    ((ARControl) this.label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label16).Border.TopStyle = (BorderLineStyle) 0;
    this.label16.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label16.HyperLink = (string) null;
    ((ARControl) this.label16).Location = (PointF) componentResourceManager.GetObject("label16.Location");
    ((ARControl) this.label16).Name = "label16";
    ((ARControl) this.label16).Size = new SizeF(11f / 16f, 3f / 16f);
    this.label16.Text = "Other";
    this.label16.VerticalAlignment = (VerticalTextAlignment) 1;
    ((ARControl) this.label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label4).Border.TopStyle = (BorderLineStyle) 0;
    this.label4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Location = (PointF) componentResourceManager.GetObject("label4.Location");
    ((ARControl) this.label4).Name = "label4";
    ((ARControl) this.label4).Size = new SizeF(11f / 16f, 3f / 16f);
    this.label4.Text = "Policy:";
    this.label4.VerticalAlignment = (VerticalTextAlignment) 1;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.label9,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8,
      (ARControl) this.textBox15,
      (ARControl) this.textBox16
    });
    this.groupFooter1.Height = 0.4270833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Name = "groupFooter1";
    this.label9.BackColor = Color.LightGray;
    ((ARControl) this.label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Border.TopStyle = (BorderLineStyle) 0;
    this.label9.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Location = (PointF) componentResourceManager.GetObject("label9.Location");
    ((ARControl) this.label9).Name = "label9";
    ((ARControl) this.label9).Size = new SizeF(5.25f, 3f / 16f);
    this.label9.Text = "Totals";
    this.label9.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox7.Alignment = (TextAlignment) 2;
    this.textBox7.BackColor = Color.LightGray;
    ((ARControl) this.textBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox7).DataField = "Hours";
    this.textBox7.DistinctField = (string) null;
    this.textBox7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox7).Location = (PointF) componentResourceManager.GetObject("textBox7.Location");
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.OutputFormat = "#,##0;(#,##0)";
    ((ARControl) this.textBox7).Size = new SizeF(9f / 16f, 3f / 16f);
    this.textBox7.SummaryGroup = "groupHeader1";
    this.textBox7.SummaryRunning = (SummaryRunning) 1;
    this.textBox7.SummaryType = (SummaryType) 3;
    this.textBox7.Text = (string) null;
    this.textBox7.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox8.Alignment = (TextAlignment) 2;
    this.textBox8.BackColor = Color.LightGray;
    ((ARControl) this.textBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox8).DataField = "HourlyTotal";
    this.textBox8.DistinctField = (string) null;
    this.textBox8.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox8).Location = (PointF) componentResourceManager.GetObject("textBox8.Location");
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox8).Size = new SizeF(9f / 16f, 3f / 16f);
    this.textBox8.SummaryGroup = "groupHeader1";
    this.textBox8.SummaryRunning = (SummaryRunning) 1;
    this.textBox8.SummaryType = (SummaryType) 3;
    this.textBox8.Text = (string) null;
    this.textBox8.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox15.Alignment = (TextAlignment) 2;
    this.textBox15.BackColor = Color.LightGray;
    ((ARControl) this.textBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).DataField = "EquipmentTotal";
    this.textBox15.DistinctField = (string) null;
    this.textBox15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox15).Location = (PointF) componentResourceManager.GetObject("textBox15.Location");
    ((ARControl) this.textBox15).Name = "textBox15";
    this.textBox15.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox15).Size = new SizeF(13f / 16f, 3f / 16f);
    this.textBox15.SummaryGroup = "groupHeader1";
    this.textBox15.SummaryRunning = (SummaryRunning) 1;
    this.textBox15.SummaryType = (SummaryType) 3;
    this.textBox15.Text = (string) null;
    this.textBox15.VerticalAlignment = (VerticalTextAlignment) 1;
    this.textBox16.Alignment = (TextAlignment) 2;
    this.textBox16.BackColor = Color.LightGray;
    ((ARControl) this.textBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox16).DataField = "OtherTotal";
    this.textBox16.DistinctField = (string) null;
    this.textBox16.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ARControl) this.textBox16).Location = (PointF) componentResourceManager.GetObject("textBox16.Location");
    ((ARControl) this.textBox16).Name = "textBox16";
    this.textBox16.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.textBox16).Size = new SizeF(11f / 16f, 3f / 16f);
    this.textBox16.SummaryGroup = "groupHeader1";
    this.textBox16.SummaryRunning = (SummaryRunning) 1;
    this.textBox16.SummaryType = (SummaryType) 3;
    this.textBox16.Text = (string) null;
    this.textBox16.VerticalAlignment = (VerticalTextAlignment) 1;
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
    ((SectionReport) this).ReportStart += new EventHandler(this.BillingDetailReport_ReportStart);
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.textBox17).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.textBox10).EndInit();
    ((ISupportInitialize) this.textBox11).EndInit();
    ((ISupportInitialize) this.textBox12).EndInit();
    ((ISupportInitialize) this.textBox13).EndInit();
    ((ISupportInitialize) this.textBox14).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label12).EndInit();
    ((ISupportInitialize) this.label13).EndInit();
    ((ISupportInitialize) this.label15).EndInit();
    ((ISupportInitialize) this.label16).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.textBox15).EndInit();
    ((ISupportInitialize) this.textBox16).EndInit();
  }
}
