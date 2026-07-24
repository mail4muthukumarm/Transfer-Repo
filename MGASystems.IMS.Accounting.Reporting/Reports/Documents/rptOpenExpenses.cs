// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Reports.Documents.rptOpenExpenses
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.ComponentModel;
using System.Data;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting.Reports.Documents;

[SecureReportResource("{66EC5A25-DFDA-4036-B3BC-362D541BF551}", "Open Expenses Report", "Open Expenses Report", "Accounting")]
public class rptOpenExpenses : MGAReport, IReport
{
  private DataSet _ds;
  private DateTime _asOfDate;
  private Guid _officeGuid;
  private Detail detail;
  private ReportHeader reportHeader1;
  private ReportFooter reportFooter1;
  private TextBox txtRH_ClientOfficeName;
  private TextBox textBox1;
  private Label label1;
  private Label label2;
  private Label label3;
  private Label label4;
  private Label label5;
  private Label label6;
  private TextBox textBox2;
  private TextBox textBox3;
  private TextBox textBox4;
  private TextBox textBox5;
  private TextBox textBox6;
  private TextBox textBox7;
  private TextBox textBox8;
  private Label label7;
  private TextBox textBox9;
  private GroupHeader groupHeader1;
  private GroupFooter groupFooter1;
  private TextBox txtRH_AsOfDate;

  public rptOpenExpenses() => this.InitializeComponent();

  public rptOpenExpenses(DateTime AsOfDate, Guid OfficeGuid)
  {
    this.InitializeComponent();
    this._asOfDate = AsOfDate;
    this._officeGuid = OfficeGuid;
  }

  Type IReport.getLaunchForm => (Type) null;

  BaseReportControl[] IReport.getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DatePicker("As of", DateTime.Now, false),
        (BaseReportControl) new OfficeLocations("Office", true)
      };
    }
  }

  private void rptOpenExpenses_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_rptOpenExpenses", new object[4]
    {
      (object) "@AsOfDate",
      (object) this._asOfDate,
      (object) "@OfficeGuid",
      (object) this._officeGuid
    });
    this.DataSource = (object) this._ds.Tables[1];
  }

  private void reportHeader1_Format(object sender, EventArgs e)
  {
    this.txtRH_ClientOfficeName.Text = this._ds.Tables[0].Rows[0]["ClientOfficeName"].ToString();
    this.txtRH_AsOfDate.Value = this._ds.Tables[0].Rows[0]["AsOfDate"];
  }

  public override bool IsThreaded => true;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptOpenExpenses));
    this.detail = new Detail();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox6 = new TextBox();
    this.textBox7 = new TextBox();
    this.textBox8 = new TextBox();
    this.reportHeader1 = new ReportHeader();
    this.txtRH_ClientOfficeName = new TextBox();
    this.textBox1 = new TextBox();
    this.label1 = new Label();
    this.label2 = new Label();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.reportFooter1 = new ReportFooter();
    this.textBox9 = new TextBox();
    this.groupHeader1 = new GroupHeader();
    this.groupFooter1 = new GroupFooter();
    this.txtRH_AsOfDate = new TextBox();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this.textBox7).BeginInit();
    ((ISupportInitialize) this.textBox8).BeginInit();
    ((ISupportInitialize) this.txtRH_ClientOfficeName).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this.label3).BeginInit();
    ((ISupportInitialize) this.label4).BeginInit();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.textBox9).BeginInit();
    ((ISupportInitialize) this.txtRH_AsOfDate).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox5,
      (ARControl) this.textBox6,
      (ARControl) this.textBox7,
      (ARControl) this.textBox8
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Height = 0.2083334f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail).Name = "detail";
    ((ARControl) this.textBox2).DataField = "Payee";
    ((ARControl) this.textBox2).Height = 0.2f;
    ((ARControl) this.textBox2).Left = 0.0f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 2.5f;
    ((ARControl) this.textBox3).DataField = "PONum";
    ((ARControl) this.textBox3).Height = 0.2f;
    ((ARControl) this.textBox3).Left = 2.5f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 1f;
    ((ARControl) this.textBox4).DataField = "PODate";
    ((ARControl) this.textBox4).Height = 0.2f;
    ((ARControl) this.textBox4).Left = 3.5f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 1f;
    ((ARControl) this.textBox5).DataField = "DueDate";
    ((ARControl) this.textBox5).Height = 0.2f;
    ((ARControl) this.textBox5).Left = 4.5f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 1f;
    ((ARControl) this.textBox6).DataField = "InvoiceNumber";
    ((ARControl) this.textBox6).Height = 0.2f;
    ((ARControl) this.textBox6).Left = 5.5f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 1f;
    ((ARControl) this.textBox7).DataField = "Comments";
    ((ARControl) this.textBox7).Height = 0.2f;
    ((ARControl) this.textBox7).Left = 6.5f;
    ((ARControl) this.textBox7).Name = "textBox7";
    this.textBox7.Text = (string) null;
    ((ARControl) this.textBox7).Top = 0.0f;
    ((ARControl) this.textBox7).Width = 2.875f;
    ((ARControl) this.textBox8).DataField = "Amount";
    ((ARControl) this.textBox8).Height = 0.2f;
    ((ARControl) this.textBox8).Left = 9.375f;
    ((ARControl) this.textBox8).Name = "textBox8";
    this.textBox8.OutputFormat = resourceManager.GetString("textBox8.OutputFormat");
    this.textBox8.Style = "text-align: right";
    this.textBox8.Text = (string) null;
    ((ARControl) this.textBox8).Top = 0.0f;
    ((ARControl) this.textBox8).Width = 1f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.txtRH_ClientOfficeName,
      (ARControl) this.textBox1,
      (ARControl) this.txtRH_AsOfDate
    });
    this.reportHeader1.Height = 0.8036668f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Name = "reportHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1).Format += new EventHandler(this.reportHeader1_Format);
    ((ARControl) this.txtRH_ClientOfficeName).Height = 0.25f;
    ((ARControl) this.txtRH_ClientOfficeName).Left = 0.0f;
    ((ARControl) this.txtRH_ClientOfficeName).Name = "txtRH_ClientOfficeName";
    this.txtRH_ClientOfficeName.Style = "font-size: 12pt; font-weight: bold; text-align: center";
    this.txtRH_ClientOfficeName.Text = (string) null;
    ((ARControl) this.txtRH_ClientOfficeName).Top = 0.25f;
    ((ARControl) this.txtRH_ClientOfficeName).Width = 10.4f;
    ((ARControl) this.textBox1).Height = 0.25f;
    ((ARControl) this.textBox1).Left = 0.0f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.Style = "font-size: 12pt; font-weight: bold; text-align: center";
    this.textBox1.Text = "Open Expenses Report";
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 10.4f;
    ((ARControl) this.label1).Height = 0.2f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.0250001f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "font-weight: bold";
    this.label1.Text = "Payee";
    ((ARControl) this.label1).Top = 0.05000001f;
    ((ARControl) this.label1).Width = 2.5f;
    ((ARControl) this.label2).Height = 0.2f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 2.525f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-weight: bold";
    this.label2.Text = "PO Num";
    ((ARControl) this.label2).Top = 0.05000001f;
    ((ARControl) this.label2).Width = 1f;
    ((ARControl) this.label3).Height = 0.2f;
    this.label3.HyperLink = (string) null;
    ((ARControl) this.label3).Left = 3.525f;
    ((ARControl) this.label3).Name = "label3";
    this.label3.Style = "font-weight: bold";
    this.label3.Text = "PO Date";
    ((ARControl) this.label3).Top = 0.05000001f;
    ((ARControl) this.label3).Width = 1f;
    ((ARControl) this.label4).Height = 0.2f;
    this.label4.HyperLink = (string) null;
    ((ARControl) this.label4).Left = 4.525001f;
    ((ARControl) this.label4).Name = "label4";
    this.label4.Style = "font-weight: bold";
    this.label4.Text = "Due Date";
    ((ARControl) this.label4).Top = 0.05000001f;
    ((ARControl) this.label4).Width = 1f;
    ((ARControl) this.label5).Height = 0.2f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 6.525f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "font-weight: bold";
    this.label5.Text = "Comments";
    ((ARControl) this.label5).Top = 0.05000001f;
    ((ARControl) this.label5).Width = 2.875f;
    ((ARControl) this.label6).Height = 0.2f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 9.4f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "font-weight: bold";
    this.label6.Text = "Amount";
    ((ARControl) this.label6).Top = 0.05000001f;
    ((ARControl) this.label6).Width = 1f;
    ((ARControl) this.label7).Height = 0.2f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 5.525f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "font-weight: bold";
    this.label7.Text = "Invoice #";
    ((ARControl) this.label7).Top = 0.05199987f;
    ((ARControl) this.label7).Width = 1f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.textBox9
    });
    this.reportFooter1.Height = 11f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1).Name = "reportFooter1";
    ((ARControl) this.textBox9).DataField = "Amount";
    ((ARControl) this.textBox9).Height = 0.2f;
    ((ARControl) this.textBox9).Left = 9f;
    ((ARControl) this.textBox9).Name = "textBox9";
    this.textBox9.OutputFormat = resourceManager.GetString("textBox9.OutputFormat");
    this.textBox9.Style = "font-weight: bold; text-align: right";
    this.textBox9.SummaryRunning = (SummaryRunning) 2;
    this.textBox9.SummaryType = (SummaryType) 1;
    this.textBox9.Text = (string) null;
    ((ARControl) this.textBox9).Top = 0.125f;
    ((ARControl) this.textBox9).Width = 1.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.label5,
      (ARControl) this.label2,
      (ARControl) this.label3,
      (ARControl) this.label4,
      (ARControl) this.label1,
      (ARControl) this.label7,
      (ARControl) this.label6
    });
    this.groupHeader1.Height = 0.2519999f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1).Name = "groupHeader1";
    this.groupHeader1.RepeatStyle = (RepeatStyle) 1;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1).Name = "groupFooter1";
    ((ARControl) this.txtRH_AsOfDate).Height = 0.25f;
    ((ARControl) this.txtRH_AsOfDate).Left = 0.0f;
    ((ARControl) this.txtRH_AsOfDate).Name = "txtRH_AsOfDate";
    this.txtRH_AsOfDate.Style = "font-size: 12pt; font-weight: bold; text-align: center";
    this.txtRH_AsOfDate.Text = (string) null;
    ((ARControl) this.txtRH_AsOfDate).Top = 0.5f;
    ((ARControl) this.txtRH_AsOfDate).Width = 10.4f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.groupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.reportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.rptOpenExpenses_ReportStart);
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this.textBox7).EndInit();
    ((ISupportInitialize) this.textBox8).EndInit();
    ((ISupportInitialize) this.txtRH_ClientOfficeName).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this.label3).EndInit();
    ((ISupportInitialize) this.label4).EndInit();
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.textBox9).EndInit();
    ((ISupportInitialize) this.txtRH_AsOfDate).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
