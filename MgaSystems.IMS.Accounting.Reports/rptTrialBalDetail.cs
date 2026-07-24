// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptTrialBalDetail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptTrialBalDetail : SectionReport
{
  private string _totalString;
  private TextBox TextBox1;
  private TextBox fullname1;
  private TextBox fullname2;
  private TextBox balance1;
  private TextBox prevamt1;
  private Line Line1;
  private Line Line2;
  private Line Line3;
  private Line Line4;
  private Label lblTotal;

  public rptTrialBalDetail()
  {
    this.ReportStart += new EventHandler(this.rptTrialBalanceDetail_ReportStart);
    this.InitializeComponent();
  }

  public rptTrialBalDetail(string totalString)
  {
    this.ReportStart += new EventHandler(this.rptTrialBalanceDetail_ReportStart);
    this.InitializeComponent();
    this._totalString = totalString;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptTrialBalDetail));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.TextBox1 = new TextBox();
    this.fullname1 = new TextBox();
    this.fullname2 = new TextBox();
    this.balance1 = new TextBox();
    this.prevamt1 = new TextBox();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.lblTotal = new Label();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.fullname1).BeginInit();
    ((ISupportInitialize) this.fullname2).BeginInit();
    ((ISupportInitialize) this.balance1).BeginInit();
    ((ISupportInitialize) this.prevamt1).BeginInit();
    ((ISupportInitialize) this.lblTotal).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.fullname1,
      (ARControl) this.fullname2
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 5f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    this.ReportHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.balance1,
      (ARControl) this.prevamt1,
      (ARControl) this.Line1,
      (ARControl) this.Line2,
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.lblTotal
    });
    this.ReportFooter.Height = 11f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "fullname";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj1 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox1).Location = pointF1;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(4f, 3f / 16f);
    this.fullname1.Alignment = (TextAlignment) 2;
    ((ARControl) this.fullname1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.fullname1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.fullname1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.fullname1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.fullname1).DataField = "balance";
    this.fullname1.DistinctField = (string) null;
    this.fullname1.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.fullname1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox fullname1 = this.fullname1;
    object obj2 = componentResourceManager.GetObject("fullname1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) fullname1).Location = pointF2;
    ((ARControl) this.fullname1).Name = "fullname1";
    this.fullname1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.fullname1).Size = new SizeF(1.625f, 3f / 16f);
    this.fullname2.Alignment = (TextAlignment) 2;
    ((ARControl) this.fullname2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.fullname2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.fullname2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.fullname2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.fullname2).DataField = "prevamt";
    this.fullname2.DistinctField = (string) null;
    this.fullname2.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.fullname2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox fullname2 = this.fullname2;
    object obj3 = componentResourceManager.GetObject("fullname2.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) fullname2).Location = pointF3;
    ((ARControl) this.fullname2).Name = "fullname2";
    this.fullname2.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.fullname2).Size = new SizeF(1.625f, 3f / 16f);
    this.balance1.Alignment = (TextAlignment) 2;
    ((ARControl) this.balance1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.balance1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.balance1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.balance1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.balance1).DataField = "balance";
    this.balance1.DistinctField = (string) null;
    this.balance1.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.balance1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox balance1 = this.balance1;
    object obj4 = componentResourceManager.GetObject("balance1.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) balance1).Location = pointF4;
    ((ARControl) this.balance1).Name = "balance1";
    this.balance1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.balance1).Size = new SizeF(1.625f, 0.2f);
    this.balance1.SummaryRunning = (SummaryRunning) 2;
    this.balance1.SummaryType = (SummaryType) 1;
    this.balance1.Text = "balance1";
    this.prevamt1.Alignment = (TextAlignment) 2;
    ((ARControl) this.prevamt1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.prevamt1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.prevamt1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.prevamt1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.prevamt1).DataField = "prevamt";
    this.prevamt1.DistinctField = (string) null;
    this.prevamt1.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.prevamt1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox prevamt1 = this.prevamt1;
    object obj5 = componentResourceManager.GetObject("prevamt1.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) prevamt1).Location = pointF5;
    ((ARControl) this.prevamt1).Name = "prevamt1";
    this.prevamt1.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.prevamt1).Size = new SizeF(1.625f, 0.2f);
    this.prevamt1.SummaryRunning = (SummaryRunning) 2;
    this.prevamt1.SummaryType = (SummaryType) 1;
    this.prevamt1.Text = "prevamt1";
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 93f / 16f;
    this.Line1.X2 = 67f / 16f;
    this.Line1.Y1 = 0.0f;
    this.Line1.Y2 = 0.0f;
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    this.Line2.LineColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    this.Line2.X1 = 119f / 16f;
    this.Line2.X2 = 5.875f;
    this.Line2.Y1 = 0.0f;
    this.Line2.Y2 = 0.0f;
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    this.Line3.X1 = 119f / 16f;
    this.Line3.X2 = 5.875f;
    this.Line3.Y1 = 5f / 16f;
    this.Line3.Y2 = 5f / 16f;
    this.Line4.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line4.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line4.Border.RightStyle = (BorderLineStyle) 0;
    this.Line4.Border.TopStyle = (BorderLineStyle) 0;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    this.Line4.X1 = 93f / 16f;
    this.Line4.X2 = 67f / 16f;
    this.Line4.Y1 = 5f / 16f;
    this.Line4.Y2 = 5f / 16f;
    this.lblTotal.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblTotal).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTotal).Border.TopStyle = (BorderLineStyle) 0;
    this.lblTotal.Font = new Font("Arial", 8f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblTotal.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblTotal.HyperLink = (string) null;
    Label lblTotal = this.lblTotal;
    object obj6 = componentResourceManager.GetObject("lblTotal.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) lblTotal).Location = pointF6;
    ((ARControl) this.lblTotal).Name = "lblTotal";
    ((ARControl) this.lblTotal).Size = new SizeF(2f, 0.2f);
    this.lblTotal.Text = "Label1";
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.2f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperName = "";
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 239f / 32f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.fullname1).EndInit();
    ((ISupportInitialize) this.fullname2).EndInit();
    ((ISupportInitialize) this.balance1).EndInit();
    ((ISupportInitialize) this.prevamt1).EndInit();
    ((ISupportInitialize) this.lblTotal).EndInit();
  }

  private void rptTrialBalanceDetail_ReportStart(object sender, EventArgs e)
  {
    this.lblTotal.Text = this._totalString;
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
