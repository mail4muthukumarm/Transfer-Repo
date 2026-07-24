// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptAgingSummary
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
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptAgingSummary : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{04F9827E-DB1B-40a0-8E45-0FA7D14A20F5}";
  private int _glCompanyId;
  private DateTime _agingDate;
  private string _reportFor;
  private string p1f;
  private string p1t;
  private string p2f;
  private string p2t;
  private string p3f;
  private string p3t;
  private string p4f;
  private string p4t;
  private Label Label3;
  private Label lblP1;
  private Label lblPeriod1;
  private Label lblP2;
  private Label lblP4;
  private Label lblP3;
  private Label Label1;
  private Label lblReportFor;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;

  public rptAgingSummary()
  {
    this.ReportStart += new EventHandler(this.rptAgingSummary_ReportStart);
    this.InitializeComponent();
  }

  public rptAgingSummary(int GLCompanyID, DateTime AgingDate, string ReportFor)
  {
    this.ReportStart += new EventHandler(this.rptAgingSummary_ReportStart);
    this.InitializeComponent();
    this.DataSource = (object) Database.Instance.QuerySP.PerformTableQuery("spFin_AgingReport", (object) "@asof_date", (object) AgingDate, (object) "@rpt_type", (object) ReportFor, (object) "@glcompanyid", (object) GLCompanyID);
    string Left = ReportFor;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "P", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "R", false) == 0)
        this._reportFor = "Accounts Receivable";
    }
    else
      this._reportFor = "Accounts Payable";
    this._agingDate = AgingDate;
    this._glCompanyId = GLCompanyID;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptAgingSummary));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.Label3 = new Label();
    this.lblP1 = new Label();
    this.lblP2 = new Label();
    this.lblP4 = new Label();
    this.lblP3 = new Label();
    this.Label1 = new Label();
    this.lblReportFor = new Label();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.lblP1).BeginInit();
    ((ISupportInitialize) this.lblP2).BeginInit();
    ((ISupportInitialize) this.lblP4).BeginInit();
    ((ISupportInitialize) this.lblP3).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.lblReportFor).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "entityname";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj1 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox1).Location = pointF1;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(3f, 0.2f);
    this.TextBox1.Text = (string) null;
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "bucket1";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj2 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox2).Location = pointF2;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox2).Size = new SizeF(1.25f, 0.2f);
    this.TextBox2.Text = " ";
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "bucket2";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj3 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox3).Location = pointF3;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox3).Size = new SizeF(1.25f, 0.2f);
    this.TextBox3.Text = " ";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "bucket3";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj4 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) textBox4).Location = pointF4;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(1.25f, 0.2f);
    this.TextBox4.Text = " ";
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "bucket4";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj5 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) textBox5).Location = pointF5;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox5).Size = new SizeF(1.25f, 0.2f);
    this.TextBox5.Text = " ";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Label3,
      (ARControl) this.lblP1,
      (ARControl) this.lblP2,
      (ARControl) this.lblP4,
      (ARControl) this.lblP3,
      (ARControl) this.Label1,
      (ARControl) this.lblReportFor
    });
    this.ReportHeader.Height = 21f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj6 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label3).Location = pointF6;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(23f / 16f, 0.2f);
    this.Label3.Text = "Entity Name";
    this.lblP1.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblP1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP1).Border.TopStyle = (BorderLineStyle) 0;
    this.lblP1.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.lblP1.HyperLink = (string) null;
    Label lblP1 = this.lblP1;
    object obj7 = componentResourceManager.GetObject("lblP1.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) lblP1).Location = pointF7;
    ((ARControl) this.lblP1).Name = "lblP1";
    ((ARControl) this.lblP1).Size = new SizeF(1.25f, 0.325f);
    this.lblP1.Text = "Period 1";
    this.lblP2.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblP2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP2).Border.TopStyle = (BorderLineStyle) 0;
    this.lblP2.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.lblP2.HyperLink = (string) null;
    Label lblP2 = this.lblP2;
    object obj8 = componentResourceManager.GetObject("lblP2.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) lblP2).Location = pointF8;
    ((ARControl) this.lblP2).Name = "lblP2";
    ((ARControl) this.lblP2).Size = new SizeF(1.25f, 0.325f);
    this.lblP2.Text = "Period 2";
    this.lblP4.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblP4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP4).Border.TopStyle = (BorderLineStyle) 0;
    this.lblP4.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.lblP4.HyperLink = (string) null;
    Label lblP4 = this.lblP4;
    object obj9 = componentResourceManager.GetObject("lblP4.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) lblP4).Location = pointF9;
    ((ARControl) this.lblP4).Name = "lblP4";
    ((ARControl) this.lblP4).Size = new SizeF(1.25f, 0.325f);
    this.lblP4.Text = "Period 4";
    this.lblP3.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblP3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblP3).Border.TopStyle = (BorderLineStyle) 0;
    this.lblP3.Font = new Font("Arial", 8f, FontStyle.Bold);
    this.lblP3.HyperLink = (string) null;
    Label lblP3 = this.lblP3;
    object obj10 = componentResourceManager.GetObject("lblP3.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) lblP3).Location = pointF10;
    ((ARControl) this.lblP3).Name = "lblP3";
    ((ARControl) this.lblP3).Size = new SizeF(1.25f, 0.325f);
    this.lblP3.Text = "Period 3";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 11f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj11 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label1).Location = pointF11;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(83f / 16f, 0.25f);
    this.Label1.Text = "IMS Accounting - Aging Report";
    this.lblReportFor.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblReportFor).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReportFor).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReportFor).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblReportFor).Border.TopStyle = (BorderLineStyle) 0;
    this.lblReportFor.Font = new Font("Arial", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblReportFor.HyperLink = (string) null;
    Label lblReportFor = this.lblReportFor;
    object obj12 = componentResourceManager.GetObject("lblReportFor.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) lblReportFor).Location = pointF12;
    ((ARControl) this.lblReportFor).Name = "lblReportFor";
    ((ARControl) this.lblReportFor).Size = new SizeF(31f / 16f, 0.2f);
    this.lblReportFor.Text = "Label4";
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 8.072917f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.lblP1).EndInit();
    ((ISupportInitialize) this.lblP2).EndInit();
    ((ISupportInitialize) this.lblP4).EndInit();
    ((ISupportInitialize) this.lblP3).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.lblReportFor).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new OfficeLocations("Office", false, true),
        (BaseReportControl) new DatePicker("Aging Period", DateAndTime.Now.Date, false),
        (BaseReportControl) new GenericComboBox("Aging For", 125, 125, typeof (string), new object[4]
        {
          (object) "Accounts Receivable",
          (object) "R",
          (object) "Account Payable",
          (object) "P"
        })
      };
    }
  }

  private void rptAgingSummary_ReportStart(object sender, EventArgs e)
  {
    this.lblReportFor.Text = this._reportFor;
    DataRow dataRow = Database.Instance.QuerySP.PerformRowQuery(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._reportFor, "Accounts Payable", false) != 0 ? "spFin_GetReceivableAgingBuckets" : "spFin_GetPayableAgingBuckets");
    if (dataRow != null)
    {
      this.p1f = dataRow[0].ToString();
      this.p1t = dataRow[1].ToString();
      this.p2f = dataRow[2].ToString();
      this.p2t = dataRow[3].ToString();
      this.p3f = dataRow[4].ToString();
      this.p3t = dataRow[5].ToString();
      this.p4f = dataRow[6].ToString();
      this.p4t = dataRow[7].ToString();
    }
    else
    {
      this.p1f = "0";
      this.p1t = "30";
      this.p2f = "31";
      this.p2t = "60";
      this.p3f = "61";
      this.p3t = "90";
      this.p4f = "91";
      this.p4t = "OVER";
    }
    this.lblPeriod1.Text = $"({this.p1f}-{this.p1t})\r\n{string.Format($"{Strings.Format((object) this._agingDate, "Short Date").ToString()}-{Strings.Format((object) this._agingDate.Subtract(new TimeSpan(Conversions.ToInteger(this.p1t), 0, 0, 0, 0)), "Short Date").ToString()}")}";
    this.lblP2.Text = $"({this.p2f}-{this.p2t})\r\n{string.Format($"{Strings.Format((object) this._agingDate.Subtract(new TimeSpan(Conversions.ToInteger(this.p2f), 0, 0, 0, 0)), "Short Date").ToString()}-{Strings.Format((object) this._agingDate.Subtract(new TimeSpan(Conversions.ToInteger(this.p2f), 0, 0, 0, 0)), "Short Date").ToString()}")}";
    this.lblP3.Text = $"({this.p3f}-{this.p3t})\r\n{string.Format($"{Strings.Format((object) this._agingDate.Subtract(new TimeSpan(Conversions.ToInteger(this.p3f), 0, 0, 0, 0)), "Short Date").ToString()}-{Strings.Format((object) this._agingDate.Subtract(new TimeSpan(Conversions.ToInteger(this.p3t), 0, 0, 0, 0)), "Short Date").ToString()}")}";
    this.lblP4.Text = $"({this.p4f}-{this.p4t})\r\n{string.Format(Strings.Format((object) this._agingDate.Subtract(new TimeSpan(Conversions.ToInteger(this.p4f), 0, 0, 0, 0)), "Short Date").ToString() + "-OVER")}";
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
