// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptGeneralLedger
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Reporting;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptGeneralLedger : MGAReport
{
  private dsJournalView _ds;
  private string _reportTitle;
  private Color _BackColor;
  private TextBox txtTitle;
  private Label Label15;
  private Label Label16;
  private Label Label17;
  private Label Label18;
  private Label Label19;
  private Label Label20;
  private TextBox TextBox1;
  private Label Label10;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private TextBox txtDayStub;
  private TextBox txtAccount;
  private TextBox txtDebit;
  private TextBox txtCredit;
  private TextBox txtBlank;
  private Label lblDate;
  private TextBox TextBox16;
  private TextBox Void;
  private TextBox TextBox13;
  private Label Label23;
  private Label Label24;
  private Label Label25;
  private TextBox TextBox14;
  private TextBox TextBox15;

  public rptGeneralLedger(dsJournalView ds, DateTime dateFrom, DateTime dateTo)
  {
    this.ReportStart += new EventHandler(this.rptGeneralLedger_ReportStart);
    this._BackColor = Color.White;
    this.InitializeComponent();
    this._ds = ds;
    this._reportTitle = $"General Ledger Report ({dateFrom.ToString("MM/dd/yyyy")} - {dateTo.ToString("MM/dd/yyyy")})";
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptGeneralLedger));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.ghTransactionDate = new GroupHeader();
    this.gfTransactionDate = new GroupFooter();
    this.txtTitle = new TextBox();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.Label19 = new Label();
    this.Label20 = new Label();
    this.TextBox1 = new TextBox();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.txtDayStub = new TextBox();
    this.txtAccount = new TextBox();
    this.txtDebit = new TextBox();
    this.txtCredit = new TextBox();
    this.txtBlank = new TextBox();
    this.lblDate = new Label();
    this.TextBox16 = new TextBox();
    this.Void = new TextBox();
    this.TextBox13 = new TextBox();
    this.Label23 = new Label();
    this.Label24 = new Label();
    this.Label25 = new Label();
    this.TextBox14 = new TextBox();
    this.TextBox15 = new TextBox();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.Label20).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.txtDayStub).BeginInit();
    ((ISupportInitialize) this.txtAccount).BeginInit();
    ((ISupportInitialize) this.txtDebit).BeginInit();
    ((ISupportInitialize) this.txtCredit).BeginInit();
    ((ISupportInitialize) this.txtBlank).BeginInit();
    ((ISupportInitialize) this.lblDate).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.Void).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.Label23).BeginInit();
    ((ISupportInitialize) this.Label24).BeginInit();
    ((ISupportInitialize) this.Label25).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.txtDayStub,
      (ARControl) this.txtAccount,
      (ARControl) this.txtDebit,
      (ARControl) this.txtCredit,
      (ARControl) this.txtBlank,
      (ARControl) this.lblDate,
      (ARControl) this.TextBox16,
      (ARControl) this.Void
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1145833f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtTitle
    });
    this.ReportHeader.Height = 0.2708333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox13,
      (ARControl) this.Label23,
      (ARControl) this.Label24,
      (ARControl) this.Label25,
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox15
    });
    this.ReportFooter.Height = 0.2076389f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.Label17,
      (ARControl) this.Label18,
      (ARControl) this.Label19,
      (ARControl) this.Label20
    });
    this.PageHeader.Height = 0.2291667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransactionDate).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14
    });
    this.ghTransactionDate.DataField = "TransactionDate";
    this.ghTransactionDate.Height = 5f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransactionDate).Name = "ghTransactionDate";
    this.gfTransactionDate.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTransactionDate).Name = "gfTransactionDate";
    ((ARControl) this.txtTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTitle.DistinctField = (string) null;
    this.txtTitle.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtTitle.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTitle = this.txtTitle;
    object obj1 = componentResourceManager.GetObject("txtTitle.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) txtTitle).Location = pointF1;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.OutputFormat = (string) null;
    ((ARControl) this.txtTitle).Size = new SizeF(7f, 0.2f);
    this.Label15.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 6;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 6;
    this.Label15.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label15.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label15.HyperLink = (string) null;
    Label label15 = this.Label15;
    object obj2 = componentResourceManager.GetObject("Label15.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) label15).Location = pointF2;
    ((ARControl) this.Label15).Name = "Label15";
    ((ARControl) this.Label15).Size = new SizeF(1f, 3f / 16f);
    this.Label15.Text = " Credit";
    this.Label16.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 6;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 6;
    this.Label16.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label16.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj3 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label16).Location = pointF3;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(1f, 3f / 16f);
    this.Label16.Text = " Debit";
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 6;
    this.Label17.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label17.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label17.HyperLink = (string) null;
    Label label17 = this.Label17;
    object obj4 = componentResourceManager.GetObject("Label17.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label17).Location = pointF4;
    ((ARControl) this.Label17).Name = "Label17";
    ((ARControl) this.Label17).Size = new SizeF(2.75f, 3f / 16f);
    this.Label17.Text = " Account";
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 6;
    this.Label18.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label18.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label18.HyperLink = (string) null;
    Label label18 = this.Label18;
    object obj5 = componentResourceManager.GetObject("Label18.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label18).Location = pointF5;
    ((ARControl) this.Label18).Name = "Label18";
    ((ARControl) this.Label18).Size = new SizeF(0.375f, 3f / 16f);
    this.Label18.Text = " ";
    ((ARControl) this.Label19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Border.TopStyle = (BorderLineStyle) 6;
    this.Label19.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label19.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label19.HyperLink = (string) null;
    Label label19 = this.Label19;
    object obj6 = componentResourceManager.GetObject("Label19.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label19).Location = pointF6;
    ((ARControl) this.Label19).Name = "Label19";
    ((ARControl) this.Label19).Size = new SizeF(0.375f, 3f / 16f);
    this.Label19.Text = "";
    ((ARControl) this.Label20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.LeftStyle = (BorderLineStyle) 6;
    ((ARControl) this.Label20).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label20).Border.TopStyle = (BorderLineStyle) 6;
    this.Label20.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label20.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label20.HyperLink = (string) null;
    Label label20 = this.Label20;
    object obj7 = componentResourceManager.GetObject("Label20.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label20).Location = pointF7;
    ((ARControl) this.Label20).Name = "Label20";
    ((ARControl) this.Label20).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label20.Text = " Date";
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 6;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "Transaction Date";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj8 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox1).Location = pointF8;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "MMM-yyyy";
    ((ARControl) this.TextBox1).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox1.Text = " ";
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 6;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 1;
    this.Label10.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label10.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj9 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) label10).Location = pointF9;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(1f, 3f / 16f);
    this.Label10.Text = " ";
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 6;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 1;
    this.Label11.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label11.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj10 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) label11).Location = pointF10;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(1f, 3f / 16f);
    this.Label11.Text = " ";
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 1;
    this.Label12.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label12.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj11 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) label12).Location = pointF11;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(2.75f, 3f / 16f);
    this.Label12.Text = " ";
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 1;
    this.Label13.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label13.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj12 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) label13).Location = pointF12;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(0.375f, 3f / 16f);
    this.Label13.Text = " ";
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 1;
    this.Label14.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label14.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label14.HyperLink = (string) null;
    Label label14 = this.Label14;
    object obj13 = componentResourceManager.GetObject("Label14.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) label14).Location = pointF13;
    ((ARControl) this.Label14).Name = "Label14";
    ((ARControl) this.Label14).Size = new SizeF(0.375f, 3f / 16f);
    this.Label14.Text = " ";
    ((ARControl) this.txtDayStub).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDayStub).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDayStub).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDayStub).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDayStub).DataField = "Day Stub";
    this.txtDayStub.DistinctField = (string) null;
    this.txtDayStub.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtDayStub.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDayStub = this.txtDayStub;
    object obj14 = componentResourceManager.GetObject("txtDayStub.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) txtDayStub).Location = pointF14;
    ((ARControl) this.txtDayStub).Name = "txtDayStub";
    this.txtDayStub.OutputFormat = (string) null;
    ((ARControl) this.txtDayStub).Size = new SizeF(0.375f, 0.125f);
    this.txtDayStub.Text = " ";
    ((ARControl) this.txtAccount).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtAccount).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtAccount).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtAccount).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtAccount).DataField = "GL ACCT NAME";
    this.txtAccount.DistinctField = (string) null;
    this.txtAccount.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtAccount.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtAccount = this.txtAccount;
    object obj15 = componentResourceManager.GetObject("txtAccount.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) txtAccount).Location = pointF15;
    ((ARControl) this.txtAccount).Name = "txtAccount";
    this.txtAccount.OutputFormat = (string) null;
    ((ARControl) this.txtAccount).Size = new SizeF(2.75f, 0.125f);
    this.txtAccount.Text = " ";
    this.txtDebit.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtDebit).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDebit).Border.LeftStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtDebit).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDebit).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDebit).DataField = "Debit";
    this.txtDebit.DistinctField = (string) null;
    this.txtDebit.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtDebit.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtDebit = this.txtDebit;
    object obj16 = componentResourceManager.GetObject("txtDebit.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) txtDebit).Location = pointF16;
    ((ARControl) this.txtDebit).Name = "txtDebit";
    this.txtDebit.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtDebit).Size = new SizeF(1f, 0.125f);
    this.txtDebit.Text = " ";
    this.txtCredit.Alignment = (TextAlignment) 2;
    ((ARControl) this.txtCredit).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCredit).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCredit).Border.RightStyle = (BorderLineStyle) 6;
    ((ARControl) this.txtCredit).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCredit).DataField = "Credit";
    this.txtCredit.DistinctField = (string) null;
    this.txtCredit.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtCredit.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtCredit = this.txtCredit;
    object obj17 = componentResourceManager.GetObject("txtCredit.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) txtCredit).Location = pointF17;
    ((ARControl) this.txtCredit).Name = "txtCredit";
    this.txtCredit.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.txtCredit).Size = new SizeF(1f, 0.125f);
    this.txtCredit.Text = " ";
    ((ARControl) this.txtBlank).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBlank).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBlank).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtBlank).Border.TopStyle = (BorderLineStyle) 1;
    this.txtBlank.DistinctField = (string) null;
    this.txtBlank.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtBlank.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtBlank = this.txtBlank;
    object obj18 = componentResourceManager.GetObject("txtBlank.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) txtBlank).Location = pointF18;
    ((ARControl) this.txtBlank).Name = "txtBlank";
    this.txtBlank.OutputFormat = (string) null;
    ((ARControl) this.txtBlank).Size = new SizeF(0.375f, 0.125f);
    this.txtBlank.Text = " ";
    ((ARControl) this.lblDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblDate).Border.LeftStyle = (BorderLineStyle) 6;
    ((ARControl) this.lblDate).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblDate).Border.TopStyle = (BorderLineStyle) 1;
    this.lblDate.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblDate.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblDate.HyperLink = (string) null;
    Label lblDate = this.lblDate;
    object obj19 = componentResourceManager.GetObject("lblDate.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) lblDate).Location = pointF19;
    ((ARControl) this.lblDate).Name = "lblDate";
    ((ARControl) this.lblDate).Size = new SizeF(13f / 16f, 0.125f);
    this.lblDate.Text = " ";
    this.TextBox16.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).DataField = "Transaction #";
    this.TextBox16.DistinctField = (string) null;
    this.TextBox16.Font = new Font("Arial", 6f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox16.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox16 = this.TextBox16;
    object obj20 = componentResourceManager.GetObject("TextBox16.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) textBox16).Location = pointF20;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = (string) null;
    ((ARControl) this.TextBox16).Size = new SizeF(9f / 16f, 0.125f);
    this.Void.BackColor = Color.Yellow;
    ((ARControl) this.Void).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Void).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Void).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Void).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Void).DataField = "Void";
    this.Void.DistinctField = (string) null;
    this.Void.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Void.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox = this.Void;
    object obj21 = componentResourceManager.GetObject("Void.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) textBox).Location = pointF21;
    ((ARControl) this.Void).Name = "Void";
    this.Void.OutputFormat = (string) null;
    ((ARControl) this.Void).Size = new SizeF(11f / 16f, 1f / 16f);
    ((ARControl) this.Void).Visible = false;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 6;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 6;
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox13.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox13 = this.TextBox13;
    object obj22 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox13).Location = pointF22;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = (string) null;
    ((ARControl) this.TextBox13).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox13.Text = " ";
    ((ARControl) this.Label23).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.Label23).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label23).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label23).Border.TopStyle = (BorderLineStyle) 6;
    this.Label23.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label23.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label23.HyperLink = (string) null;
    Label label23 = this.Label23;
    object obj23 = componentResourceManager.GetObject("Label23.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) label23).Location = pointF23;
    ((ARControl) this.Label23).Name = "Label23";
    ((ARControl) this.Label23).Size = new SizeF(2.75f, 3f / 16f);
    this.Label23.Text = " ";
    ((ARControl) this.Label24).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.Label24).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label24).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label24).Border.TopStyle = (BorderLineStyle) 6;
    this.Label24.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label24.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label24.HyperLink = (string) null;
    Label label24 = this.Label24;
    object obj24 = componentResourceManager.GetObject("Label24.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label24).Location = pointF24;
    ((ARControl) this.Label24).Name = "Label24";
    ((ARControl) this.Label24).Size = new SizeF(0.375f, 3f / 16f);
    this.Label24.Text = " ";
    ((ARControl) this.Label25).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.Label25).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label25).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label25).Border.TopStyle = (BorderLineStyle) 6;
    this.Label25.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label25.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label25.HyperLink = (string) null;
    Label label25 = this.Label25;
    object obj25 = componentResourceManager.GetObject("Label25.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) label25).Location = pointF25;
    ((ARControl) this.Label25).Name = "Label25";
    ((ARControl) this.Label25).Size = new SizeF(0.375f, 3f / 16f);
    this.Label25.Text = " ";
    this.TextBox14.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 6;
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 6;
    ((ARControl) this.TextBox14).DataField = "Debit";
    this.TextBox14.DistinctField = (string) null;
    this.TextBox14.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox14.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox14 = this.TextBox14;
    object obj26 = componentResourceManager.GetObject("TextBox14.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) textBox14).Location = pointF26;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox14).Size = new SizeF(1f, 3f / 16f);
    this.TextBox14.SummaryGroup = "ghTransactionDate";
    this.TextBox14.SummaryRunning = (SummaryRunning) 2;
    this.TextBox14.SummaryType = (SummaryType) 1;
    this.TextBox14.Text = " ";
    this.TextBox15.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 6;
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 6;
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 6;
    ((ARControl) this.TextBox15).DataField = "Credit";
    this.TextBox15.DistinctField = (string) null;
    this.TextBox15.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox15.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox15 = this.TextBox15;
    object obj27 = componentResourceManager.GetObject("TextBox15.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox15).Location = pointF27;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox15).Size = new SizeF(1f, 3f / 16f);
    this.TextBox15.SummaryGroup = "ghTransactionDate";
    this.TextBox15.SummaryRunning = (SummaryRunning) 2;
    this.TextBox15.SummaryType = (SummaryType) 1;
    this.TextBox15.Text = " ";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTransactionDate);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTransactionDate);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.Label20).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.txtDayStub).EndInit();
    ((ISupportInitialize) this.txtAccount).EndInit();
    ((ISupportInitialize) this.txtDebit).EndInit();
    ((ISupportInitialize) this.txtCredit).EndInit();
    ((ISupportInitialize) this.txtBlank).EndInit();
    ((ISupportInitialize) this.lblDate).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.Void).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.Label23).EndInit();
    ((ISupportInitialize) this.Label24).EndInit();
    ((ISupportInitialize) this.Label25).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
  }

  private void setBackColor()
  {
    if (this._BackColor.Equals((object) Color.White))
      this._BackColor = Color.LightGray;
    else
      this._BackColor = Color.White;
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    this.SetDetailControlsHeight();
    Font font = Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.Void.Text, "True", false) != 0 ? new Font(this.txtAccount.Font.FontFamily, this.txtAccount.Font.Size, System.Drawing.FontStyle.Regular) : new Font(this.txtAccount.Font.FontFamily, this.txtAccount.Font.Size, System.Drawing.FontStyle.Strikeout);
    this.lblDate.Font = font;
    this.txtDayStub.Font = font;
    this.txtBlank.Font = font;
    this.txtAccount.Font = font;
    this.txtDebit.Font = font;
    this.txtCredit.Font = font;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtDayStub.Text, "", false) != 0)
      this.setBackColor();
    this.lblDate.BackColor = this._BackColor;
    this.txtDayStub.BackColor = this._BackColor;
    this.txtBlank.BackColor = this._BackColor;
    this.txtAccount.BackColor = this._BackColor;
    this.txtDebit.BackColor = this._BackColor;
    this.txtCredit.BackColor = this._BackColor;
  }

  private void rptGeneralLedger_ReportStart(object sender, EventArgs e)
  {
    this.txtTitle.Text = this._reportTitle;
    this.DataSource = (object) new DataView((DataTable) this._ds.spFin_JournalView, "", "", DataViewRowState.CurrentRows);
    this.SetStandardMargins();
    this.ShowPageNumbers();
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghTransactionDate")]
  private virtual GroupHeader ghTransactionDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("gfTransactionDate")]
  private virtual GroupFooter gfTransactionDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
