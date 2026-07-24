// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptTrialBal
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptTrialBal : SectionReport
{
  private DataTable _dtDetail;
  private int _glCompanyId;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private Label Label1;
  private Label Label7;
  private TextBox txtDate1;
  private TextBox txtDate2;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private SubReport AssetsSub;
  private SubReport LiabSub;
  private SubReport EquitySub;
  private SubReport IncomeSub;
  private SubReport ExpensesSub;

  public rptTrialBal()
  {
    this.ReportStart += new EventHandler(this.rptTrialBal_ReportStart);
    this.InitializeComponent();
  }

  public rptTrialBal(DataTable dtDetail, int glCompanyId, DateTime DateFrom, DateTime DateTo)
  {
    this.ReportStart += new EventHandler(this.rptTrialBal_ReportStart);
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this._dateFrom = DateFrom;
    this._dateTo = DateTo;
    this._dtDetail = dtDetail;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptTrialBal));
    this.Detail = new Detail();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.AssetsSub = new SubReport();
    this.LiabSub = new SubReport();
    this.EquitySub = new SubReport();
    this.IncomeSub = new SubReport();
    this.ExpensesSub = new SubReport();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.Label7 = new Label();
    this.txtDate1 = new TextBox();
    this.txtDate2 = new TextBox();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.txtDate1).BeginInit();
    ((ISupportInitialize) this.txtDate2).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.AssetsSub,
      (ARControl) this.LiabSub,
      (ARControl) this.EquitySub,
      (ARControl) this.IncomeSub,
      (ARControl) this.ExpensesSub
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 61f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj1 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label2).Location = pointF1;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.875f, 0.2f);
    this.Label2.Text = "Assets";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj2 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label3).Location = pointF2;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.875f, 0.2f);
    this.Label3.Text = "Liabilities";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj3 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label4).Location = pointF3;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(0.875f, 0.2f);
    this.Label4.Text = "Equity";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj4 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label5).Location = pointF4;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.875f, 0.2f);
    this.Label5.Text = "Income";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj5 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label6).Location = pointF5;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(0.875f, 0.2f);
    this.Label6.Text = "Expenses";
    ((ARControl) this.AssetsSub).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.AssetsSub).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.AssetsSub).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.AssetsSub).Border.TopStyle = (BorderLineStyle) 0;
    this.AssetsSub.CloseBorder = false;
    SubReport assetsSub = this.AssetsSub;
    object obj6 = componentResourceManager.GetObject("AssetsSub.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) assetsSub).Location = pointF6;
    ((ARControl) this.AssetsSub).Name = "AssetsSub";
    this.AssetsSub.Report = (SectionReport) null;
    ((ARControl) this.AssetsSub).Size = new SizeF(125f / 16f, 3f / 16f);
    ((ARControl) this.LiabSub).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.LiabSub).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.LiabSub).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.LiabSub).Border.TopStyle = (BorderLineStyle) 0;
    this.LiabSub.CloseBorder = false;
    SubReport liabSub = this.LiabSub;
    object obj7 = componentResourceManager.GetObject("LiabSub.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) liabSub).Location = pointF7;
    ((ARControl) this.LiabSub).Name = "LiabSub";
    this.LiabSub.Report = (SectionReport) null;
    ((ARControl) this.LiabSub).Size = new SizeF(125f / 16f, 3f / 16f);
    ((ARControl) this.EquitySub).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.EquitySub).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.EquitySub).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.EquitySub).Border.TopStyle = (BorderLineStyle) 0;
    this.EquitySub.CloseBorder = false;
    SubReport equitySub = this.EquitySub;
    object obj8 = componentResourceManager.GetObject("EquitySub.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) equitySub).Location = pointF8;
    ((ARControl) this.EquitySub).Name = "EquitySub";
    this.EquitySub.Report = (SectionReport) null;
    ((ARControl) this.EquitySub).Size = new SizeF(125f / 16f, 3f / 16f);
    ((ARControl) this.IncomeSub).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.IncomeSub).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.IncomeSub).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.IncomeSub).Border.TopStyle = (BorderLineStyle) 0;
    this.IncomeSub.CloseBorder = false;
    SubReport incomeSub = this.IncomeSub;
    object obj9 = componentResourceManager.GetObject("IncomeSub.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) incomeSub).Location = pointF9;
    ((ARControl) this.IncomeSub).Name = "IncomeSub";
    this.IncomeSub.Report = (SectionReport) null;
    ((ARControl) this.IncomeSub).Size = new SizeF(125f / 16f, 3f / 16f);
    ((ARControl) this.ExpensesSub).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.ExpensesSub).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.ExpensesSub).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.ExpensesSub).Border.TopStyle = (BorderLineStyle) 0;
    this.ExpensesSub.CloseBorder = false;
    SubReport expensesSub = this.ExpensesSub;
    object obj10 = componentResourceManager.GetObject("ExpensesSub.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) expensesSub).Location = pointF10;
    ((ARControl) this.ExpensesSub).Name = "ExpensesSub";
    this.ExpensesSub.Report = (SectionReport) null;
    ((ARControl) this.ExpensesSub).Size = new SizeF(125f / 16f, 3f / 16f);
    this.ReportHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.ReportFooter.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label7,
      (ARControl) this.txtDate1,
      (ARControl) this.txtDate2
    });
    this.PageHeader.Height = 0.8319445f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj11 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label1).Location = pointF11;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(125f / 16f, 7f / 16f);
    this.Label1.Text = "TRIAL BALANCE";
    this.Label7.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj12 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label7).Location = pointF12;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(125f / 16f, 0.2f);
    this.Label7.Text = "[YOUR COMPANY NAME HERE]";
    this.txtDate1.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtDate1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate1).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDate1.DistinctField = (string) null;
    this.txtDate1.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    TextBox txtDate1 = this.txtDate1;
    object obj13 = componentResourceManager.GetObject("txtDate1.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) txtDate1).Location = pointF13;
    ((ARControl) this.txtDate1).Name = "txtDate1";
    this.txtDate1.OutputFormat = (string) null;
    ((ARControl) this.txtDate1).Size = new SizeF(1f, 0.2f);
    this.txtDate1.Text = (string) null;
    this.txtDate2.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtDate2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate2).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDate2.DistinctField = (string) null;
    this.txtDate2.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    TextBox txtDate2 = this.txtDate2;
    object obj14 = componentResourceManager.GetObject("txtDate2.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) txtDate2).Location = pointF14;
    ((ARControl) this.txtDate2).Name = "txtDate2";
    this.txtDate2.OutputFormat = (string) null;
    ((ARControl) this.txtDate2).Size = new SizeF(1f, 0.2f);
    this.txtDate2.Text = (string) null;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = (float) byte.MaxValue / 32f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.txtDate1).EndInit();
    ((ISupportInitialize) this.txtDate2).EndInit();
  }

  private void rptTrialBal_ReportStart(object sender, EventArgs e)
  {
    this.txtDate1.Value = (object) this._dateFrom.Year.ToString();
    this.txtDate2.Value = (object) checked (this._dateFrom.Year - 1).ToString();
    this.Label1.Text = string.Format(this.Label1.Text + "\r\n({0} - {1})", (object) Strings.Format((object) this._dateFrom, "MM\\dd"), (object) Strings.Format((object) this._dateTo, "MM\\dd"));
    this.Label7.Text = Database.Instance.QueryText.PerformScalarQueryString($"Select dbo.GetOfficeLocation({this._glCompanyId})", (object) new SqlConnection(CurrentUser.Instance.ConnectionString)).ToUpper();
    rptTrialBalDetail rptTrialBalDetail1 = new rptTrialBalDetail("Assets Total:");
    rptTrialBalDetail1.DataSource = (object) new DataView(this._dtDetail, "classname = 'Assets'", "", DataViewRowState.CurrentRows);
    this.AssetsSub.Report = (SectionReport) rptTrialBalDetail1;
    rptTrialBalDetail rptTrialBalDetail2 = new rptTrialBalDetail("Liability Total:");
    rptTrialBalDetail2.DataSource = (object) new DataView(this._dtDetail, "classname = 'Liability'", "", DataViewRowState.CurrentRows);
    this.LiabSub.Report = (SectionReport) rptTrialBalDetail2;
    rptTrialBalDetail rptTrialBalDetail3 = new rptTrialBalDetail("Equity Total:");
    rptTrialBalDetail3.DataSource = (object) new DataView(this._dtDetail, "classname = 'Equity'", "", DataViewRowState.CurrentRows);
    this.EquitySub.Report = (SectionReport) rptTrialBalDetail3;
    rptTrialBalDetail rptTrialBalDetail4 = new rptTrialBalDetail("Expense Total:");
    rptTrialBalDetail4.DataSource = (object) new DataView(this._dtDetail, "classname = 'Expenses'", "", DataViewRowState.CurrentRows);
    this.ExpensesSub.Report = (SectionReport) rptTrialBalDetail4;
    rptTrialBalDetail rptTrialBalDetail5 = new rptTrialBalDetail("Income Total:");
    rptTrialBalDetail5.DataSource = (object) new DataView(this._dtDetail, "classname = 'Income'", "", DataViewRowState.CurrentRows);
    this.IncomeSub.Report = (SectionReport) rptTrialBalDetail5;
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
