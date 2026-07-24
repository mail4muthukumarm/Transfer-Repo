// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptExpenseBreakout
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Accounting.Reports.Controls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class rptExpenseBreakout : MGAReport, IReport
{
  private DataTable _dt;
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private string _ExpenseCode;
  private int _OfficeLocationID;
  private bool _ShowVoid;
  private TextBox txtHeader;
  private Label Label;
  private Label Label1;
  private TextBox txtFrom;
  private TextBox txtTo;
  private Label Label2;
  private Label Label4;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox txtType;
  private TextBox txtPONUM;
  private TextBox txtAmount;
  private CheckBox cbShowVoid;
  private TextBox TextBox2;
  private TextBox TextBox4;
  private Label Label3;
  private Line Line;
  private TextBox TextBox3;
  private TextBox TextBox5;
  private Label Label5;
  private TextBox TextBox6;
  private Label Label9;

  public rptExpenseBreakout()
  {
    this.ReportStart += new EventHandler(this.rptExpenseBreakout_ReportStart);
    this.InitializeComponent();
  }

  public rptExpenseBreakout(
    DateTime DateFrom,
    DateTime DateTo,
    string ExpenseCode,
    int OfficeLocationID,
    bool ShowVoid)
  {
    this.ReportStart += new EventHandler(this.rptExpenseBreakout_ReportStart);
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._ExpenseCode = ExpenseCode;
    this._OfficeLocationID = OfficeLocationID;
    this._ShowVoid = ShowVoid;
    if (this._OfficeLocationID.Equals(-1))
      this._dt = Database.Instance.QuerySP.PerformTableQuery("spFin_rptExpenseBreakout", (object) "@DateFrom", (object) this._DateFrom, (object) "@DateTo", (object) this._DateTo, (object) "@ExpenseCode", (object) this._ExpenseCode, (object) "@ShowVoids", (object) this._ShowVoid);
    else
      this._dt = Database.Instance.QuerySP.PerformTableQuery("spFin_rptExpenseBreakout", (object) "@DateFrom", (object) this._DateFrom, (object) "@DateTo", (object) this._DateTo, (object) "@ExpenseCode", (object) this._ExpenseCode, (object) "@ShowVoids", (object) this._ShowVoid, (object) "@OfficeLocationID", (object) this._OfficeLocationID);
    this.DataSource = (object) this._dt;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptExpenseBreakout));
    this.Detail = new Detail();
    this.txtType = new TextBox();
    this.txtPONUM = new TextBox();
    this.txtAmount = new TextBox();
    this.cbShowVoid = new CheckBox();
    this.ReportHeader = new ReportHeader();
    this.txtHeader = new TextBox();
    this.Label = new Label();
    this.Label1 = new Label();
    this.txtFrom = new TextBox();
    this.txtTo = new TextBox();
    this.Label2 = new Label();
    this.ReportFooter = new ReportFooter();
    this.Label9 = new Label();
    this.TextBox6 = new TextBox();
    this.PageHeader = new PageHeader();
    this.Label4 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.TextBox = new TextBox();
    this.GroupFooter1 = new GroupFooter();
    this.TextBox3 = new TextBox();
    this.TextBox5 = new TextBox();
    this.Label5 = new Label();
    this.GroupHeader2 = new GroupHeader();
    this.TextBox1 = new TextBox();
    this.GroupFooter2 = new GroupFooter();
    this.TextBox2 = new TextBox();
    this.TextBox4 = new TextBox();
    this.Label3 = new Label();
    this.Line = new Line();
    ((ISupportInitialize) this.txtType).BeginInit();
    ((ISupportInitialize) this.txtPONUM).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.cbShowVoid).BeginInit();
    ((ISupportInitialize) this.txtHeader).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtFrom).BeginInit();
    ((ISupportInitialize) this.txtTo).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.txtType,
      (ARControl) this.txtPONUM,
      (ARControl) this.txtAmount,
      (ARControl) this.cbShowVoid
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.2597222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtType).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtType).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtType).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtType).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtType).DataField = "ExpenseName";
    this.txtType.DistinctField = (string) null;
    this.txtType.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtType = this.txtType;
    object obj1 = componentResourceManager.GetObject("txtType.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) txtType).Location = pointF1;
    ((ARControl) this.txtType).Name = "txtType";
    this.txtType.OutputFormat = (string) null;
    ((ARControl) this.txtType).Size = new SizeF(2f, 0.25f);
    this.txtType.Text = "txtType";
    ((ARControl) this.txtPONUM).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPONUM).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPONUM).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPONUM).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPONUM).DataField = "PONum";
    this.txtPONUM.DistinctField = (string) null;
    this.txtPONUM.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtPonum = this.txtPONUM;
    object obj2 = componentResourceManager.GetObject("txtPONUM.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtPonum).Location = pointF2;
    ((ARControl) this.txtPONUM).Name = "txtPONUM";
    this.txtPONUM.OutputFormat = (string) null;
    ((ARControl) this.txtPONUM).Size = new SizeF(0.875f, 0.25f);
    this.txtPONUM.Text = "txtPONUM";
    this.txtAmount.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtAmount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAmount).DataField = "Amount";
    this.txtAmount.DistinctField = (string) null;
    this.txtAmount.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtAmount = this.txtAmount;
    object obj3 = componentResourceManager.GetObject("txtAmount.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) txtAmount).Location = pointF3;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = "$#,##0.00";
    ((ARControl) this.txtAmount).Size = new SizeF(2f, 0.25f);
    this.txtAmount.Text = "0.00";
    ((ARControl) this.cbShowVoid).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.cbShowVoid).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.cbShowVoid).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.cbShowVoid).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.cbShowVoid).DataField = "IsVoided";
    this.cbShowVoid.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    CheckBox cbShowVoid = this.cbShowVoid;
    object obj4 = componentResourceManager.GetObject("cbShowVoid.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) cbShowVoid).Location = pointF4;
    ((ARControl) this.cbShowVoid).Name = "cbShowVoid";
    ((ARControl) this.cbShowVoid).Size = new SizeF(3f / 16f, 0.125f);
    this.cbShowVoid.Text = "";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.txtHeader,
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.txtFrom,
      (ARControl) this.txtTo,
      (ARControl) this.Label2
    });
    this.ReportHeader.Height = 1.134722f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.txtHeader.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtHeader).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtHeader).DataField = "OfficeLocation";
    this.txtHeader.DistinctField = (string) null;
    this.txtHeader.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtHeader = this.txtHeader;
    object obj5 = componentResourceManager.GetObject("txtHeader.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) txtHeader).Location = pointF5;
    ((ARControl) this.txtHeader).Name = "txtHeader";
    this.txtHeader.OutputFormat = (string) null;
    ((ARControl) this.txtHeader).Size = new SizeF(125f / 16f, 3f / 16f);
    this.txtHeader.Text = "TextBox6";
    this.Label.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj6 = componentResourceManager.GetObject("Label.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label).Location = pointF6;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(7.75f, 3f / 16f);
    this.Label.Text = "Expense Breakout";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj7 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label1).Location = pointF7;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(7.75f, 3f / 16f);
    this.Label1.Text = "For";
    this.txtFrom.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtFrom).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFrom).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFrom).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFrom).Border.TopStyle = (BorderLineStyle) 0;
    this.txtFrom.DistinctField = (string) null;
    this.txtFrom.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtFrom = this.txtFrom;
    object obj8 = componentResourceManager.GetObject("txtFrom.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) txtFrom).Location = pointF8;
    ((ARControl) this.txtFrom).Name = "txtFrom";
    this.txtFrom.OutputFormat = (string) null;
    ((ARControl) this.txtFrom).Size = new SizeF(53f / 16f, 3f / 16f);
    this.txtFrom.Text = "TextBox6";
    ((ARControl) this.txtTo).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTo).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTo).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTo).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTo.DistinctField = (string) null;
    this.txtTo.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtTo = this.txtTo;
    object obj9 = componentResourceManager.GetObject("txtTo.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) txtTo).Location = pointF9;
    ((ARControl) this.txtTo).Name = "txtTo";
    this.txtTo.OutputFormat = (string) null;
    ((ARControl) this.txtTo).Size = new SizeF(51f / 16f, 3f / 16f);
    this.txtTo.Text = "TextBox6";
    this.Label2.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj10 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label2).Location = pointF10;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.75f, 0.25f);
    this.Label2.Text = "through";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label9,
      (ARControl) this.TextBox6
    });
    this.ReportFooter.Height = 0.2291667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj11 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label9).Location = pointF11;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(1f, 3f / 16f);
    this.Label9.Text = "GrandTotal:";
    this.TextBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "Amount";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox6 = this.TextBox6;
    object obj12 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox6).Location = pointF12;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "$#,##0.00";
    ((ARControl) this.TextBox6).Size = new SizeF(33f / 16f, 3f / 16f);
    this.TextBox6.SummaryRunning = (SummaryRunning) 2;
    this.TextBox6.SummaryType = (SummaryType) 1;
    this.TextBox6.Text = "TextBox6";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label4,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8
    });
    this.PageHeader.Height = 5f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj13 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label4).Location = pointF13;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(31f / 16f, 3f / 16f);
    this.Label4.Text = "Expenses";
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj14 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) label6).Location = pointF14;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(1.75f, 3f / 16f);
    this.Label6.Text = "Purchase Order #";
    this.Label7.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj15 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) label7).Location = pointF15;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(2f, 3f / 16f);
    this.Label7.Text = "Amount";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj16 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label8).Location = pointF16;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.375f, 3f / 16f);
    this.Label8.Text = "Voided";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox
    });
    this.GroupHeader1.DataField = "dateMonth";
    this.GroupHeader1.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "dateMonth";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox = this.TextBox;
    object obj17 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox).Location = pointF17;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox.Text = "txtMonth";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox5,
      (ARControl) this.Label5
    });
    this.GroupFooter1.Height = 0.3222222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "Amount";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj18 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox3).Location = pointF18;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "$#,##0.00";
    ((ARControl) this.TextBox3).Size = new SizeF(33f / 16f, 3f / 16f);
    this.TextBox3.SummaryGroup = "GroupHeader1";
    this.TextBox3.SummaryRunning = (SummaryRunning) 2;
    this.TextBox3.SummaryType = (SummaryType) 1;
    this.TextBox3.Text = "TextBox3";
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "dateMonth";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj19 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox5).Location = pointF19;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(0.875f, 3f / 16f);
    this.TextBox5.Text = "txtMonth";
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 11f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj20 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) label5).Location = pointF20;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.5f, 3f / 16f);
    this.Label5.Text = "Total:";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox1
    });
    this.GroupHeader2.DataField = "dateDay";
    this.GroupHeader2.Height = 0.2708333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2).Name = "GroupHeader2";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "PostDate";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj21 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox1).Location = pointF21;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox1).Size = new SizeF(13f / 16f, 0.25f);
    this.TextBox1.Text = "txtDay";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox4,
      (ARControl) this.Label3,
      (ARControl) this.Line
    });
    this.GroupFooter2.Height = 0.3847222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2).Name = "GroupFooter2";
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "Amount";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj22 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox2).Location = pointF22;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "$#,##0.00";
    ((ARControl) this.TextBox2).Size = new SizeF(33f / 16f, 3f / 16f);
    this.TextBox2.SummaryGroup = "GroupHeader2";
    this.TextBox2.SummaryRunning = (SummaryRunning) 2;
    this.TextBox2.SummaryType = (SummaryType) 3;
    this.TextBox2.Text = "TextBox2";
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "PostDate";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj23 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox4).Location = pointF23;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "MM/dd/yy";
    ((ARControl) this.TextBox4).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox4.Text = "txtDay";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj24 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label3).Location = pointF24;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(0.5f, 3f / 16f);
    this.Label3.Text = "Total:";
    this.Line.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line.Border.RightStyle = (BorderLineStyle) 0;
    this.Line.Border.TopStyle = (BorderLineStyle) 0;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    this.Line.X1 = 6f;
    this.Line.X2 = 7f;
    this.Line.Y1 = 1f / 16f;
    this.Line.Y2 = 1f / 16f;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.txtType).EndInit();
    ((ISupportInitialize) this.txtPONUM).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.cbShowVoid).EndInit();
    ((ISupportInitialize) this.txtHeader).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtFrom).EndInit();
    ((ISupportInitialize) this.txtTo).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[4]
      {
        (BaseReportControl) new DateRangePicker("Date Range", false),
        (BaseReportControl) new Expenses_Multi("Expense Type", true),
        (BaseReportControl) new AccountingOfficeLocations("Office Location", false, true),
        (BaseReportControl) new GenericCheckBox("Show Voided Transactions", "")
      };
    }
  }

  private void rptExpenseBreakout_ReportStart(object sender, EventArgs e)
  {
    this.txtFrom.Text = Conversions.ToString(this._DateFrom);
    this.txtTo.Text = Conversions.ToString(this._DateTo);
  }

  private void GroupFooter1_Format(object sender, EventArgs e)
  {
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader2")]
  private virtual GroupHeader GroupHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter2")]
  private virtual GroupFooter GroupFooter2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual GroupFooter GroupFooter1
  {
    get => this._GroupFooter1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupFooter1_Format);
      GroupFooter groupFooter1_1 = this._GroupFooter1;
      if (groupFooter1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) groupFooter1_1).Format -= eventHandler;
      this._GroupFooter1 = value;
      GroupFooter groupFooter1_2 = this._GroupFooter1;
      if (groupFooter1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) groupFooter1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
