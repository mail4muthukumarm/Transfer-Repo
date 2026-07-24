// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptBalanceSheet
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

public sealed class rptBalanceSheet : SectionReport
{
  private DataSet ds;
  private Line Line1;
  private Line Line2;
  private Line Line3;
  private Label lblGLCompanyName;
  private Label Label1;
  private TextBox txtDate;
  private SubReport subRptAssets;
  private SubReport subRptLiabilities;
  private SubReport subRptEquity;
  private Line Line4;
  private Line Line5;

  private rptBalanceSheet()
  {
    this.ReportStart += new EventHandler(this.rptBalanceSheet_ReportStart);
    this.InitializeComponent();
  }

  public rptBalanceSheet(DataSet balanceSheetData)
  {
    this.ReportStart += new EventHandler(this.rptBalanceSheet_ReportStart);
    this.InitializeComponent();
    this.ds = balanceSheetData;
    this.subRptAssets.Report = (SectionReport) new rptBalanceSheet_AssetsSub(new DataView(this.ds.Tables[1], "type = 'Assets'", "", DataViewRowState.CurrentRows));
    this.subRptLiabilities.Report = (SectionReport) new rptBalanceSheet_LiabSub(new DataView(this.ds.Tables[1], "type = 'Liabilities'", "", DataViewRowState.CurrentRows));
    this.subRptEquity.Report = (SectionReport) new rptBalanceSheet_EquitySub(new DataView(this.ds.Tables[1], "type = 'Equity'", "", DataViewRowState.CurrentRows));
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptBalanceSheet));
    this.Detail = new Detail();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.Line3 = new Line();
    this.lblGLCompanyName = new Label();
    this.Label1 = new Label();
    this.txtDate = new TextBox();
    this.subRptAssets = new SubReport();
    this.subRptLiabilities = new SubReport();
    this.subRptEquity = new SubReport();
    this.Line4 = new Line();
    this.Line5 = new Line();
    ((ISupportInitialize) this.lblGLCompanyName).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtDate).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.subRptAssets,
      (ARControl) this.subRptLiabilities,
      (ARControl) this.subRptEquity,
      (ARControl) this.Line4,
      (ARControl) this.Line5
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 107f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Line1,
      (ARControl) this.Line2,
      (ARControl) this.Line3,
      (ARControl) this.lblGLCompanyName,
      (ARControl) this.Label1,
      (ARControl) this.txtDate
    });
    this.PageHeader.Height = 0.8319445f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 103f / 16f;
    this.Line1.X2 = 1f / 16f;
    this.Line1.Y1 = 3f / 16f;
    this.Line1.Y2 = 3f / 16f;
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    this.Line2.X1 = 6.444445f;
    this.Line2.X2 = 0.06944445f;
    this.Line2.Y1 = 0.6944444f;
    this.Line2.Y2 = 0.6944444f;
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    this.Line3.X1 = 6.444445f;
    this.Line3.X2 = 0.06944445f;
    this.Line3.Y1 = 0.4444444f;
    this.Line3.Y2 = 0.4444444f;
    this.lblGLCompanyName.Alignment = (TextAlignment) 1;
    ((ARControl) this.lblGLCompanyName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGLCompanyName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGLCompanyName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGLCompanyName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblGLCompanyName).DataField = "location";
    this.lblGLCompanyName.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblGLCompanyName.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblGLCompanyName.HyperLink = (string) null;
    Label lblGlCompanyName = this.lblGLCompanyName;
    object obj1 = componentResourceManager.GetObject("lblGLCompanyName.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) lblGlCompanyName).Location = pointF1;
    ((ARControl) this.lblGLCompanyName).Name = "lblGLCompanyName";
    ((ARControl) this.lblGLCompanyName).Size = new SizeF(101f / 16f, 3f / 16f);
    this.lblGLCompanyName.Text = "";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj2 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label1).Location = pointF2;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(101f / 16f, 3f / 16f);
    this.Label1.Text = "Balance Sheet";
    this.txtDate.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).DataField = "todate";
    this.txtDate.DistinctField = (string) null;
    this.txtDate.Font = new Font("Tahoma", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtDate.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDate = this.txtDate;
    object obj3 = componentResourceManager.GetObject("txtDate.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) txtDate).Location = pointF3;
    ((ARControl) this.txtDate).Name = "txtDate";
    this.txtDate.OutputFormat = "MMMM-yyyy";
    ((ARControl) this.txtDate).Size = new SizeF(101f / 16f, 3f / 16f);
    ((ARControl) this.subRptAssets).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.subRptAssets).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.subRptAssets).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.subRptAssets).Border.TopStyle = (BorderLineStyle) 0;
    this.subRptAssets.CloseBorder = false;
    SubReport subRptAssets = this.subRptAssets;
    object obj4 = componentResourceManager.GetObject("subRptAssets.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) subRptAssets).Location = pointF4;
    ((ARControl) this.subRptAssets).Name = "subRptAssets";
    this.subRptAssets.Report = (SectionReport) null;
    ((ARControl) this.subRptAssets).Size = new SizeF(49f / 16f, 3.25f);
    ((ARControl) this.subRptLiabilities).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.subRptLiabilities).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.subRptLiabilities).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.subRptLiabilities).Border.TopStyle = (BorderLineStyle) 0;
    this.subRptLiabilities.CloseBorder = false;
    SubReport subRptLiabilities = this.subRptLiabilities;
    object obj5 = componentResourceManager.GetObject("subRptLiabilities.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) subRptLiabilities).Location = pointF5;
    ((ARControl) this.subRptLiabilities).Name = "subRptLiabilities";
    this.subRptLiabilities.Report = (SectionReport) null;
    ((ARControl) this.subRptLiabilities).Size = new SizeF(53f / 16f, 2f);
    ((ARControl) this.subRptEquity).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.subRptEquity).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.subRptEquity).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.subRptEquity).Border.TopStyle = (BorderLineStyle) 0;
    this.subRptEquity.CloseBorder = false;
    SubReport subRptEquity = this.subRptEquity;
    object obj6 = componentResourceManager.GetObject("subRptEquity.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) subRptEquity).Location = pointF6;
    ((ARControl) this.subRptEquity).Name = "subRptEquity";
    this.subRptEquity.Report = (SectionReport) null;
    ((ARControl) this.subRptEquity).Size = new SizeF(53f / 16f, 1.25f);
    this.Line4.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line4.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line4.Border.RightStyle = (BorderLineStyle) 0;
    this.Line4.Border.TopStyle = (BorderLineStyle) 0;
    this.Line4.LineWeight = 2f;
    ((ARControl) this.Line4).Name = "Line4";
    this.Line4.X1 = 103f / 16f;
    this.Line4.X2 = 1f / 16f;
    this.Line4.Y1 = 1f / 16f;
    this.Line4.Y2 = 1f / 16f;
    this.Line5.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line5.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line5.Border.RightStyle = (BorderLineStyle) 0;
    this.Line5.Border.TopStyle = (BorderLineStyle) 0;
    this.Line5.LineWeight = 1f;
    ((ARControl) this.Line5).Name = "Line5";
    this.Line5.X1 = 3.125f;
    this.Line5.X2 = 3.125f;
    this.Line5.Y1 = 1f / 16f;
    this.Line5.Y2 = 55f / 16f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 6.489583f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.lblGLCompanyName).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtDate).EndInit();
  }

  private void rptBalanceSheet_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this.ds.Tables[0];
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
