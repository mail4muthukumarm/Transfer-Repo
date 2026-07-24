// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptJournalTransaction
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{2BB213FF-ACB8-4b86-B88F-97C0BE80BE0E}", "General Journal Transaction", "Detailed listing of transaction within the journal.", "Accounting")]
public class rptJournalTransaction : MGAReport, IReport
{
  private int _TransactionNum;
  private int _LastTransactionNum;
  private DataTable _dt;
  private Label Label9;
  private TextBox txtDate;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label1;
  private Label Label2;
  private Label Label;
  private Label Label7;
  private TextBox currentDebit;
  private TextBox currentCredit;
  private TextBox txtTransactionNum;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox;
  private TextBox TextBox4;
  private Line Line;
  private Line Line1;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private Line Line3;
  private Line Line4;
  private TextBox TextBox12;
  private TextBox TextBox13;
  private Label Label8;

  public rptJournalTransaction()
  {
    this.ReportStart += new EventHandler(this.rptJournalTransaction_ReportStart);
    this._LastTransactionNum = -1;
    this.InitializeComponent();
  }

  public rptJournalTransaction(int TransactionNum)
  {
    this.ReportStart += new EventHandler(this.rptJournalTransaction_ReportStart);
    this._LastTransactionNum = -1;
    this.InitializeComponent();
    this._TransactionNum = TransactionNum;
  }

  private void rptJournalTransaction_ReportStart(object sender, EventArgs e)
  {
    this.ShowPageNumbers();
    this._dt = Database.Instance.QuerySP.PerformTableQuery("spFin_rptJournalTransaction", (object) "@transactnum", (object) this._TransactionNum);
    if (this._dt.Rows.Count <= 0)
      return;
    this.txtDate.Text = Conversions.ToDate(this._dt.Rows[0]["postDate"]).ToString("MM/dd/yyyy");
    this.DataSource = (object) this._dt;
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (this._LastTransactionNum == Conversions.ToInteger(this.txtTransactionNum.Value))
      this.txtTransactionNum.Text = "";
    this._LastTransactionNum = Conversions.ToInteger(this.txtTransactionNum.Value);
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptJournalTransaction));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.ghTransaction = new GroupHeader();
    this.gfTransaction = new GroupFooter();
    this.Label9 = new Label();
    this.txtDate = new TextBox();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label = new Label();
    this.Label7 = new Label();
    this.currentDebit = new TextBox();
    this.currentCredit = new TextBox();
    this.txtTransactionNum = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox = new TextBox();
    this.TextBox4 = new TextBox();
    this.Line = new Line();
    this.Line1 = new Line();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.Label8 = new Label();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtDate).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.currentDebit).BeginInit();
    ((ISupportInitialize) this.currentCredit).BeginInit();
    ((ISupportInitialize) this.txtTransactionNum).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.currentDebit,
      (ARControl) this.currentCredit,
      (ARControl) this.txtTransactionNum,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox4
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label9,
      (ARControl) this.txtDate
    });
    this.ReportHeader.Height = 17f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.Label8
    });
    this.ReportFooter.Height = 0.3222222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransaction).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label,
      (ARControl) this.Label7
    });
    this.ghTransaction.Height = 0.2597222f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransaction).Name = "ghTransaction";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTransaction).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Line,
      (ARControl) this.Line1,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9
    });
    this.gfTransaction.Height = 0.2388889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTransaction).Name = "gfTransaction";
    this.Label9.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 14f, System.Drawing.FontStyle.Bold);
    this.Label9.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj1 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) label9).Location = pointF1;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(10.375f, 0.25f);
    this.Label9.Text = "General Journal Transaction";
    this.txtDate.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDate).Border.TopStyle = (BorderLineStyle) 0;
    this.txtDate.DistinctField = (string) null;
    this.txtDate.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDate.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDate = this.txtDate;
    object obj2 = componentResourceManager.GetObject("txtDate.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) txtDate).Location = pointF2;
    ((ARControl) this.txtDate).Name = "txtDate";
    this.txtDate.OutputFormat = (string) null;
    ((ARControl) this.txtDate).Size = new SizeF(10.375f, 3f / 16f);
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 9f);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj3 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label3).Location = pointF3;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(35f / 16f, 3f / 16f);
    this.Label3.Text = "Memo";
    this.Label3.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label4.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 9f);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj4 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label4).Location = pointF4;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label4.Text = "Debits";
    this.Label4.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label5.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 9f);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj5 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label5).Location = pointF5;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(0.75f, 3f / 16f);
    this.Label5.Text = "Credits";
    this.Label5.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 9f);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj6 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label6).Location = pointF6;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(2.25f, 3f / 16f);
    this.Label6.Text = "Account";
    this.Label6.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 9f);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj7 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label1).Location = pointF7;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label1.Text = "Class";
    this.Label1.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 9f);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj8 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label2).Location = pointF8;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(0.875f, 3f / 16f);
    this.Label2.Text = "Transaction #";
    this.Label2.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 9f);
    this.Label.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj9 = componentResourceManager.GetObject("Label.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label).Location = pointF9;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label.Text = "Policy #";
    this.Label.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 9f);
    this.Label7.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj10 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label7).Location = pointF10;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(17f / 16f, 3f / 16f);
    this.Label7.Text = "Invoice #";
    this.Label7.VerticalAlignment = (VerticalTextAlignment) 2;
    this.currentDebit.Alignment = (TextAlignment) 2;
    ((ARControl) this.currentDebit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDebit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDebit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDebit).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDebit).DataField = "Debit";
    this.currentDebit.DistinctField = (string) null;
    this.currentDebit.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.currentDebit.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox currentDebit = this.currentDebit;
    object obj11 = componentResourceManager.GetObject("currentDebit.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) currentDebit).Location = pointF11;
    ((ARControl) this.currentDebit).Name = "currentDebit";
    this.currentDebit.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.currentDebit).Size = new SizeF(15f / 16f, 0.125f);
    this.currentDebit.Text = " ";
    this.currentCredit.Alignment = (TextAlignment) 2;
    ((ARControl) this.currentCredit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentCredit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentCredit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentCredit).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentCredit).DataField = "Credit";
    this.currentCredit.DistinctField = (string) null;
    this.currentCredit.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.currentCredit.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox currentCredit = this.currentCredit;
    object obj12 = componentResourceManager.GetObject("currentCredit.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) currentCredit).Location = pointF12;
    ((ARControl) this.currentCredit).Name = "currentCredit";
    this.currentCredit.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.currentCredit).Size = new SizeF(0.75f, 0.125f);
    this.currentCredit.Text = " ";
    ((ARControl) this.txtTransactionNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).DataField = "transactnum";
    this.txtTransactionNum.DistinctField = (string) null;
    this.txtTransactionNum.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtTransactionNum.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTransactionNum = this.txtTransactionNum;
    object obj13 = componentResourceManager.GetObject("txtTransactionNum.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) txtTransactionNum).Location = pointF13;
    ((ARControl) this.txtTransactionNum).Name = "txtTransactionNum";
    this.txtTransactionNum.OutputFormat = (string) null;
    ((ARControl) this.txtTransactionNum).Size = new SizeF(0.875f, 0.125f);
    this.txtTransactionNum.Text = " ";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "comments";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj14 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox1).Location = pointF14;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(35f / 16f, 0.125f);
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "fullname";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj15 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox2).Location = pointF15;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = (string) null;
    ((ARControl) this.TextBox2).Size = new SizeF(2.25f, 0.125f);
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "classname";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj16 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox3).Location = pointF16;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = (string) null;
    ((ARControl) this.TextBox3).Size = new SizeF(15f / 16f, 0.125f);
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "policynum";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.TextBox;
    object obj17 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox).Location = pointF17;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(15f / 16f, 0.125f);
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "invoicenum";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj18 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox4).Location = pointF18;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(17f / 16f, 0.125f);
    this.TextBox4.Text = " ";
    this.Line.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line.Border.RightStyle = (BorderLineStyle) 0;
    this.Line.Border.TopStyle = (BorderLineStyle) 0;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    this.Line.X1 = 137f / 16f;
    this.Line.X2 = 153f / 16f;
    this.Line.Y1 = 0.0f;
    this.Line.Y2 = 0.0f;
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    this.Line1.X1 = 9.625f;
    this.Line1.X2 = 10.375f;
    this.Line1.Y1 = 0.0f;
    this.Line1.Y2 = 0.0f;
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "Debit";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj19 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox8).Location = pointF19;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(1f, 11f / 64f);
    this.TextBox8.SummaryGroup = "ghTransaction";
    this.TextBox8.SummaryRunning = (SummaryRunning) 1;
    this.TextBox8.SummaryType = (SummaryType) 3;
    this.TextBox8.Text = " ";
    this.TextBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "Credit";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox9.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox9 = this.TextBox9;
    object obj20 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox9).Location = pointF20;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox9).Size = new SizeF(0.75f, 11f / 64f);
    this.TextBox9.SummaryGroup = "ghTransaction";
    this.TextBox9.SummaryRunning = (SummaryRunning) 1;
    this.TextBox9.SummaryType = (SummaryType) 3;
    this.TextBox9.Text = " ";
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    this.Line3.X1 = 137f / 16f;
    this.Line3.X2 = 153f / 16f;
    this.Line3.Y1 = 9f / 32f;
    this.Line3.Y2 = 9f / 32f;
    this.Line4.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line4.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line4.Border.RightStyle = (BorderLineStyle) 0;
    this.Line4.Border.TopStyle = (BorderLineStyle) 0;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    this.Line4.X1 = 9.625f;
    this.Line4.X2 = 10.375f;
    this.Line4.Y1 = 9f / 32f;
    this.Line4.Y2 = 9f / 32f;
    this.TextBox12.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "Debit";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox12.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox12 = this.TextBox12;
    object obj21 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox12).Location = pointF21;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox12).Size = new SizeF(1f, 11f / 64f);
    this.TextBox12.SummaryRunning = (SummaryRunning) 2;
    this.TextBox12.SummaryType = (SummaryType) 1;
    this.TextBox12.Text = " ";
    this.TextBox13.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "Credit";
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox13.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox13 = this.TextBox13;
    object obj22 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox13).Location = pointF22;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox13).Size = new SizeF(0.75f, 11f / 64f);
    this.TextBox13.SummaryRunning = (SummaryRunning) 2;
    this.TextBox13.SummaryType = (SummaryType) 1;
    this.TextBox13.Text = " ";
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold);
    this.Label8.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj23 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) label8).Location = pointF23;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label8.Text = "TOTAL";
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransaction);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTransaction);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtDate).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.currentDebit).EndInit();
    ((ISupportInitialize) this.currentCredit).EndInit();
    ((ISupportInitialize) this.txtTransactionNum).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[1]
      {
        (BaseReportControl) new TextInput("Transaction #", true, true)
      };
    }
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghTransaction")]
  private virtual GroupHeader ghTransaction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_BeforePrint);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).BeforePrint -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("gfTransaction")]
  private virtual GroupFooter gfTransaction { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
