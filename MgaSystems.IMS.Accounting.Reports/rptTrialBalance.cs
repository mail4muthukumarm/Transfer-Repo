// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptTrialBalance
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptTrialBalance : MGAReport, IReport
{
  private int _OfficeID;
  private DateTime _PriorTo;
  private Label Label1;
  private TextBox txtCompany;
  private TextBox txtDateCriteria;
  private Line Line1;
  private Label Label2;
  private TextBox TextBox1;
  private TextBox txtFullName;
  private TextBox TextBox2;
  private TextBox txtBalanceTotal;
  private Label Label3;
  private TextBox ClassName1;
  private TextBox GrandTotalBalance;
  private Label Label4;

  public rptTrialBalance()
  {
    this.ReportStart += new EventHandler(this.rptTrialBalance_ReportStart);
  }

  public rptTrialBalance(int OfficeID, DateTime PriorTo)
  {
    this.ReportStart += new EventHandler(this.rptTrialBalance_ReportStart);
    this.InitializeComponent();
    this._OfficeID = OfficeID;
    this._PriorTo = PriorTo;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptTrialBalance));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.ghClassName = new GroupHeader();
    this.gfClassName = new GroupFooter();
    this.Label1 = new Label();
    this.txtCompany = new TextBox();
    this.txtDateCriteria = new TextBox();
    this.Line1 = new Line();
    this.Label2 = new Label();
    this.TextBox1 = new TextBox();
    this.txtFullName = new TextBox();
    this.TextBox2 = new TextBox();
    this.txtBalanceTotal = new TextBox();
    this.Label3 = new Label();
    this.ClassName1 = new TextBox();
    this.GrandTotalBalance = new TextBox();
    this.Label4 = new Label();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtCompany).BeginInit();
    ((ISupportInitialize) this.txtDateCriteria).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.txtFullName).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.txtBalanceTotal).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.ClassName1).BeginInit();
    ((ISupportInitialize) this.GrandTotalBalance).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtFullName,
      (ARControl) this.TextBox2
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label1,
      (ARControl) this.txtCompany,
      (ARControl) this.txtDateCriteria,
      (ARControl) this.Line1,
      (ARControl) this.Label2
    });
    this.ReportHeader.Height = 1.239583f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.GrandTotalBalance,
      (ARControl) this.Label4
    });
    this.ReportFooter.Height = 0.3625f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghClassName).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox1
    });
    this.ghClassName.DataField = "classname";
    this.ghClassName.Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghClassName).Name = "ghClassName";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfClassName).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.txtBalanceTotal,
      (ARControl) this.Label3,
      (ARControl) this.ClassName1
    });
    this.gfClassName.Height = 0.3958333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfClassName).Name = "gfClassName";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 18f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj1 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label1).Location = pointF1;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(7.875f, 5f / 16f);
    this.Label1.Text = "Trial Balance";
    ((ARControl) this.txtCompany).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtCompany).Border.TopStyle = (BorderLineStyle) 0;
    this.txtCompany.DistinctField = (string) null;
    this.txtCompany.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCompany.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCompany = this.txtCompany;
    object obj2 = componentResourceManager.GetObject("txtCompany.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtCompany).Location = pointF2;
    ((ARControl) this.txtCompany).Name = "txtCompany";
    this.txtCompany.OutputFormat = (string) null;
    ((ARControl) this.txtCompany).Size = new SizeF(7.875f, 3f / 16f);
    this.txtCompany.Text = "[Company]";
    ((ARControl) this.txtDateCriteria).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateCriteria).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateCriteria).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateCriteria).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDateCriteria.DistinctField = (string) null;
    this.txtDateCriteria.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDateCriteria.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDateCriteria = this.txtDateCriteria;
    object obj3 = componentResourceManager.GetObject("txtDateCriteria.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) txtDateCriteria).Location = pointF3;
    ((ARControl) this.txtDateCriteria).Name = "txtDateCriteria";
    this.txtDateCriteria.OutputFormat = (string) null;
    ((ARControl) this.txtDateCriteria).Size = new SizeF(7.875f, 3f / 16f);
    this.txtDateCriteria.Text = "[Date Criteria]";
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 3f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 7.875f;
    this.Line1.Y1 = 13f / 16f;
    this.Line1.Y2 = 13f / 16f;
    this.Label2.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj4 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label2).Location = pointF4;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.375f, 0.2f);
    this.Label2.Text = "Balance";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "ClassName";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj5 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) textBox1).Location = pointF5;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(7.875f, 3f / 16f);
    this.TextBox1.Text = "[Class Name]";
    ((ARControl) this.txtFullName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullName).DataField = "FullName";
    this.txtFullName.DistinctField = (string) null;
    this.txtFullName.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtFullName.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtFullName = this.txtFullName;
    object obj6 = componentResourceManager.GetObject("txtFullName.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) txtFullName).Location = pointF6;
    ((ARControl) this.txtFullName).Name = "txtFullName";
    this.txtFullName.OutputFormat = (string) null;
    ((ARControl) this.txtFullName).Size = new SizeF(101f / 16f, 3f / 16f);
    this.txtFullName.Text = "[Full Name]";
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "Balance";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj7 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox2).Location = pointF7;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox2).Size = new SizeF(1.375f, 0.2f);
    this.txtBalanceTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtBalanceTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBalanceTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBalanceTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtBalanceTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBalanceTotal).DataField = "Balance";
    this.txtBalanceTotal.DistinctField = (string) null;
    this.txtBalanceTotal.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtBalanceTotal.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtBalanceTotal = this.txtBalanceTotal;
    object obj8 = componentResourceManager.GetObject("txtBalanceTotal.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) txtBalanceTotal).Location = pointF8;
    ((ARControl) this.txtBalanceTotal).Name = "txtBalanceTotal";
    this.txtBalanceTotal.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.txtBalanceTotal).Size = new SizeF(1.375f, 3f / 16f);
    this.txtBalanceTotal.SummaryGroup = "ghClassName";
    this.txtBalanceTotal.SummaryRunning = (SummaryRunning) 1;
    this.txtBalanceTotal.SummaryType = (SummaryType) 3;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj9 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label3).Location = pointF9;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.375f, 0.2f);
    this.Label3.Text = "Total";
    ((ARControl) this.ClassName1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.ClassName1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.ClassName1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.ClassName1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.ClassName1).DataField = "ClassName";
    this.ClassName1.DistinctField = (string) null;
    this.ClassName1.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.ClassName1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox className1 = this.ClassName1;
    object obj10 = componentResourceManager.GetObject("ClassName1.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) className1).Location = pointF10;
    ((ARControl) this.ClassName1).Name = "ClassName1";
    this.ClassName1.OutputFormat = (string) null;
    ((ARControl) this.ClassName1).Size = new SizeF(395f / 64f, 3f / 16f);
    this.ClassName1.Text = "[Class Name]";
    this.GrandTotalBalance.Alignment = (TextAlignment) 2;
    ((ARControl) this.GrandTotalBalance).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.GrandTotalBalance).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.GrandTotalBalance).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.GrandTotalBalance).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.GrandTotalBalance).DataField = "Balance";
    this.GrandTotalBalance.DistinctField = (string) null;
    this.GrandTotalBalance.Font = new Font("Arial", 9.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.GrandTotalBalance.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox grandTotalBalance = this.GrandTotalBalance;
    object obj11 = componentResourceManager.GetObject("GrandTotalBalance.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) grandTotalBalance).Location = pointF11;
    ((ARControl) this.GrandTotalBalance).Name = "GrandTotalBalance";
    this.GrandTotalBalance.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.GrandTotalBalance).Size = new SizeF(1.375f, 0.25f);
    this.GrandTotalBalance.SummaryGroup = "ghClassName";
    this.GrandTotalBalance.SummaryRunning = (SummaryRunning) 2;
    this.GrandTotalBalance.SummaryType = (SummaryType) 1;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj12 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label4).Location = pointF12;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(6.5f, 0.25f);
    this.Label4.Text = "Journal Balance (Trial)";
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghClassName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfClassName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtCompany).EndInit();
    ((ISupportInitialize) this.txtDateCriteria).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.txtFullName).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.txtBalanceTotal).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.ClassName1).EndInit();
    ((ISupportInitialize) this.GrandTotalBalance).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
  }

  private void rptTrialBalance_ReportStart(object sender, EventArgs e)
  {
    this.txtDateCriteria.Text = "Prior To: " + this._PriorTo.Date.ToString("MM/dd/yyyy");
    this.SetStatusText("Retrieving Company Name...");
    this.txtCompany.Text = Database.Instance.QueryText.PerformScalarQueryString($"SELECT TOP 1 Location FROM tblClientOffices WHERE OfficeID = {this._OfficeID}");
    this.SetStatusText("Retrieving Report Data...");
    this.DataSource = (object) Database.Instance.QuerySP.PerformTableQuery("spFin_rptTrialBalance", (object) "@glcompanyid", (object) this._OfficeID, (object) "@PriorTo", (object) this._PriorTo);
    this.SetStatusText("Formatting...");
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new OfficeLocations("Office Location", false, true),
        (BaseReportControl) new DatePicker("Prior To", DateAndTime.Now.Date, false)
      };
    }
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghClassName")]
  private virtual GroupHeader ghClassName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfClassName")]
  private virtual GroupFooter gfClassName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
