// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptPaymentStatement_InvoiceDetail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class rptPaymentStatement_InvoiceDetail : SectionReport
{
  private DataTable _dataTable;
  private DataView _dataView;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox7;
  private TextBox TextBox9;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private Line Line;
  private Line Line1;
  private Line Line2;
  private TextBox TextBox8;
  private Line Line3;
  private TextBox TextBox10;
  private Line Line4;

  public rptPaymentStatement_InvoiceDetail()
  {
    this.ReportStart += new EventHandler(this.rptPaymentStatement_InvoiceDetail_ReportStart);
    this.InitializeComponent();
  }

  public rptPaymentStatement_InvoiceDetail(DataTable data)
  {
    this.ReportStart += new EventHandler(this.rptPaymentStatement_InvoiceDetail_ReportStart);
    this.InitializeComponent();
    this._dataTable = data;
    this.DataSource = (object) this._dataTable;
  }

  public rptPaymentStatement_InvoiceDetail(DataView data)
  {
    this.ReportStart += new EventHandler(this.rptPaymentStatement_InvoiceDetail_ReportStart);
    this.InitializeComponent();
    this._dataView = data;
    this.DataSource = (object) this._dataView;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptPaymentStatement_InvoiceDetail));
    this.Detail = new Detail();
    this.TextBox = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox9 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.Line = new Line();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.TextBox8 = new TextBox();
    this.Line3 = new Line();
    this.TextBox10 = new TextBox();
    this.Line4 = new Line();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox9
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "linedescription";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox = this.TextBox;
    object obj1 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox).Location = pointF1;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(23f / 16f, 0.125f);
    this.TextBox.Text = "TextBox";
    this.TextBox1.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "gross";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj2 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox1).Location = pointF2;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox1).Size = new SizeF(0.75f, 0.125f);
    this.TextBox1.Text = "TextBox1";
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "commission";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj3 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox2).Location = pointF3;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox2).Size = new SizeF(0.75f, 0.125f);
    this.TextBox2.Text = "TextBox1";
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "paid";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj4 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) textBox3).Location = pointF4;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox3).Size = new SizeF(0.75f, 0.125f);
    this.TextBox3.Text = "TextBox1";
    this.TextBox7.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "netdue";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox7 = this.TextBox7;
    object obj5 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) textBox7).Location = pointF5;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox7).Size = new SizeF(0.75f, 0.125f);
    this.TextBox7.Text = "TextBox1";
    this.TextBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "ptd";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 7f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox9 = this.TextBox9;
    object obj6 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) textBox9).Location = pointF6;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox9).Size = new SizeF(0.75f, 0.125f);
    this.TextBox9.Text = "TextBox1";
    this.ReportHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).BackColor = Color.FromArgb(245, 245, 245);
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.Line,
      (ARControl) this.Line1,
      (ARControl) this.Line2,
      (ARControl) this.TextBox8,
      (ARControl) this.Line3,
      (ARControl) this.TextBox10,
      (ARControl) this.Line4
    });
    this.ReportFooter.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "gross";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj7 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox4).Location = pointF7;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(0.75f, 0.125f);
    this.TextBox4.SummaryRunning = (SummaryRunning) 2;
    this.TextBox4.SummaryType = (SummaryType) 1;
    this.TextBox4.Text = "TextBox1";
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "commission";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj8 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox5).Location = pointF8;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox5).Size = new SizeF(0.75f, 0.125f);
    this.TextBox5.SummaryRunning = (SummaryRunning) 2;
    this.TextBox5.SummaryType = (SummaryType) 1;
    this.TextBox5.Text = "TextBox1";
    this.TextBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "paid";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox6 = this.TextBox6;
    object obj9 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox6).Location = pointF9;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox6).Size = new SizeF(11f / 16f, 0.125f);
    this.TextBox6.SummaryRunning = (SummaryRunning) 2;
    this.TextBox6.SummaryType = (SummaryType) 1;
    this.TextBox6.Text = "TextBox1";
    this.Line.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line.Border.RightStyle = (BorderLineStyle) 0;
    this.Line.Border.TopStyle = (BorderLineStyle) 0;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    this.Line.X1 = 23f / 16f;
    this.Line.X2 = 35f / 16f;
    this.Line.Y1 = 0.0f;
    this.Line.Y2 = 0.0f;
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 2.239583f;
    this.Line1.X2 = 47f / 16f;
    this.Line1.Y1 = 0.0f;
    this.Line1.Y2 = 0.0f;
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    this.Line2.X1 = 4.5f;
    this.Line2.X2 = 83f / 16f;
    this.Line2.Y1 = 0.0f;
    this.Line2.Y2 = 0.0f;
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "netdue";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox8 = this.TextBox8;
    object obj10 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox8).Location = pointF10;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(0.75f, 0.125f);
    this.TextBox8.SummaryRunning = (SummaryRunning) 2;
    this.TextBox8.SummaryType = (SummaryType) 1;
    this.TextBox8.Text = "TextBox1";
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    this.Line3.X1 = 3f;
    this.Line3.X2 = 59f / 16f;
    this.Line3.Y1 = 0.0f;
    this.Line3.Y2 = 0.0f;
    this.TextBox10.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "ptd";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox10 = this.TextBox10;
    object obj11 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox10).Location = pointF11;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox10).Size = new SizeF(0.75f, 0.125f);
    this.TextBox10.SummaryRunning = (SummaryRunning) 2;
    this.TextBox10.SummaryType = (SummaryType) 1;
    this.TextBox10.Text = "TextBox1";
    this.Line4.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line4.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line4.Border.RightStyle = (BorderLineStyle) 0;
    this.Line4.Border.TopStyle = (BorderLineStyle) 0;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    this.Line4.X1 = 3.75f;
    this.Line4.X2 = 71f / 16f;
    this.Line4.Y1 = 0.0f;
    this.Line4.Y2 = 0.0f;
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 5.125f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
  }

  private void rptPaymentStatement_InvoiceDetail_ReportStart(object sender, EventArgs e)
  {
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
