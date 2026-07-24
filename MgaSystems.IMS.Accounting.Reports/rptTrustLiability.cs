// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptTrustLiability
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptTrustLiability : MGAReport, IReport
{
  public const string securityID = "{C155D9F7-A0F2-4ce2-8183-9CBB21052870}";
  private int _glCompanyId;
  private DateTime _asof;
  private DataTable dt;
  private int recMax;
  private int recs;
  private bool finished;
  private Label Label1;
  private TextBox txtPrintdate;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label11;
  private TextBox TextBox1;
  private Line Line13;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private Line Line2;
  private Line Line3;
  private Line Line4;
  private Line Line5;
  private Line Line6;
  private Line Line7;
  private Line Line8;
  private Line Line9;
  private Line Line10;
  private Line Line11;
  private Line Line12;
  private TextBox TextBox11;
  private TextBox grosspayable1;
  private TextBox grosspayable2;
  private TextBox grosspayable3;
  private TextBox grosspayable4;
  private Line Line1;
  private Line Line14;
  private Line Line15;
  private Line Line16;
  private Line Line17;
  private Line Line18;
  private Line Line19;
  private TextBox TextBox12;
  private Label Label12;
  private TextBox grosspayable5;
  private TextBox balancedue1;
  private TextBox propamtdue1;
  private TextBox paidtodate1;
  private TextBox trustliability1;
  private Label Label13;

  public override bool IsThreaded => true;

  public rptTrustLiability()
  {
    this.ReportStart += new EventHandler(this.rptTrustLiability_ReportStart);
    this.recMax = 50;
    this.finished = false;
    this.InitializeComponent();
  }

  public rptTrustLiability(int glCompanyId, DateTime AsOf)
  {
    this.ReportStart += new EventHandler(this.rptTrustLiability_ReportStart);
    this.recMax = 50;
    this.finished = false;
    this.InitializeComponent();
    this._glCompanyId = glCompanyId;
    this._asof = AsOf;
    this.SetProgressbarMaximum(this.recMax);
    this.LoadData();
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptTrustLiability));
    this.Detail = new Detail();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.Line2 = new Line();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.Line5 = new Line();
    this.Line6 = new Line();
    this.Line7 = new Line();
    this.Line8 = new Line();
    this.Line9 = new Line();
    this.Line10 = new Line();
    this.Line11 = new Line();
    this.Line12 = new Line();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.grosspayable5 = new TextBox();
    this.balancedue1 = new TextBox();
    this.propamtdue1 = new TextBox();
    this.paidtodate1 = new TextBox();
    this.trustliability1 = new TextBox();
    this.Label13 = new Label();
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.txtPrintdate = new TextBox();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label11 = new Label();
    this.TextBox1 = new TextBox();
    this.Line13 = new Line();
    this.GroupFooter1 = new GroupFooter();
    this.TextBox11 = new TextBox();
    this.grosspayable1 = new TextBox();
    this.grosspayable2 = new TextBox();
    this.grosspayable3 = new TextBox();
    this.grosspayable4 = new TextBox();
    this.Line1 = new Line();
    this.Line14 = new Line();
    this.Line15 = new Line();
    this.Line16 = new Line();
    this.Line17 = new Line();
    this.Line18 = new Line();
    this.Line19 = new Line();
    this.TextBox12 = new TextBox();
    this.Label12 = new Label();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.grosspayable5).BeginInit();
    ((ISupportInitialize) this.balancedue1).BeginInit();
    ((ISupportInitialize) this.propamtdue1).BeginInit();
    ((ISupportInitialize) this.paidtodate1).BeginInit();
    ((ISupportInitialize) this.trustliability1).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtPrintdate).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.grosspayable1).BeginInit();
    ((ISupportInitialize) this.grosspayable2).BeginInit();
    ((ISupportInitialize) this.grosspayable3).BeginInit();
    ((ISupportInitialize) this.grosspayable4).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[20]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.Line2,
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.Line5,
      (ARControl) this.Line6,
      (ARControl) this.Line7,
      (ARControl) this.Line8,
      (ARControl) this.Line9,
      (ARControl) this.Line10,
      (ARControl) this.Line11,
      (ARControl) this.Line12
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "officeinvoicenum";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 0.0f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0; font-size: 6pt; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 9f / 16f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "policynumber";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 11f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; font-size: 6pt; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.875f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "insuredname";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 1.625f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "ddo-char-set: 0; font-size: 6pt; ";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 2.125f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "payee";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 61f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "ddo-char-set: 0; font-size: 6pt; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 31f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "grosspayable";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 5.75f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-size: 6pt; ";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 15f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "balancedue";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 6.75f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-size: 6pt; ";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 13f / 16f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "propamtdue";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 7.625f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "ddo-char-set: 0; text-align: right; font-size: 6pt; ";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 15f / 16f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "paidtodate";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 8.625f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 6pt; ";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 13f / 16f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "trustliability";
    ((ARControl) this.TextBox10).Height = 0.125f;
    ((ARControl) this.TextBox10).Left = 9.5f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "ddo-char-set: 0; text-align: right; font-size: 6pt; ";
    this.TextBox10.Text = (string) null;
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 13f / 16f;
    this.Line2.Border.BottomColor = Color.Black;
    this.Line2.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line2.Border.LeftColor = Color.Black;
    this.Line2.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line2.Border.RightColor = Color.Black;
    this.Line2.Border.RightStyle = (BorderLineStyle) 0;
    this.Line2.Border.TopColor = Color.Black;
    this.Line2.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 0.0f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 0.125f;
    ((ARControl) this.Line2).Width = 165f / 16f;
    this.Line2.X1 = 0.0f;
    this.Line2.X2 = 165f / 16f;
    this.Line2.Y1 = 0.125f;
    this.Line2.Y2 = 0.125f;
    this.Line3.Border.BottomColor = Color.Black;
    this.Line3.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line3.Border.LeftColor = Color.Black;
    this.Line3.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line3.Border.RightColor = Color.Black;
    this.Line3.Border.RightStyle = (BorderLineStyle) 0;
    this.Line3.Border.TopColor = Color.Black;
    this.Line3.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Height = 0.125f;
    ((ARControl) this.Line3).Left = 151f / 16f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 0.0f;
    ((ARControl) this.Line3).Width = 0.0f;
    this.Line3.X1 = 151f / 16f;
    this.Line3.X2 = 151f / 16f;
    this.Line3.Y1 = 0.0f;
    this.Line3.Y2 = 0.125f;
    this.Line4.Border.BottomColor = Color.Black;
    this.Line4.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line4.Border.LeftColor = Color.Black;
    this.Line4.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line4.Border.RightColor = Color.Black;
    this.Line4.Border.RightStyle = (BorderLineStyle) 0;
    this.Line4.Border.TopColor = Color.Black;
    this.Line4.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line4).Height = 0.125f;
    ((ARControl) this.Line4).Left = 137f / 16f;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    ((ARControl) this.Line4).Top = 0.0f;
    ((ARControl) this.Line4).Width = 0.0f;
    this.Line4.X1 = 137f / 16f;
    this.Line4.X2 = 137f / 16f;
    this.Line4.Y1 = 0.0f;
    this.Line4.Y2 = 0.125f;
    this.Line5.Border.BottomColor = Color.Black;
    this.Line5.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line5.Border.LeftColor = Color.Black;
    this.Line5.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line5.Border.RightColor = Color.Black;
    this.Line5.Border.RightStyle = (BorderLineStyle) 0;
    this.Line5.Border.TopColor = Color.Black;
    this.Line5.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line5).Height = 0.125f;
    ((ARControl) this.Line5).Left = 121f / 16f;
    this.Line5.LineWeight = 1f;
    ((ARControl) this.Line5).Name = "Line5";
    ((ARControl) this.Line5).Top = 0.0f;
    ((ARControl) this.Line5).Width = 0.0f;
    this.Line5.X1 = 121f / 16f;
    this.Line5.X2 = 121f / 16f;
    this.Line5.Y1 = 0.0f;
    this.Line5.Y2 = 0.125f;
    this.Line6.Border.BottomColor = Color.Black;
    this.Line6.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line6.Border.LeftColor = Color.Black;
    this.Line6.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line6.Border.RightColor = Color.Black;
    this.Line6.Border.RightStyle = (BorderLineStyle) 0;
    this.Line6.Border.TopColor = Color.Black;
    this.Line6.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line6).Height = 0.125f;
    ((ARControl) this.Line6).Left = 107f / 16f;
    this.Line6.LineWeight = 1f;
    ((ARControl) this.Line6).Name = "Line6";
    ((ARControl) this.Line6).Top = 0.0f;
    ((ARControl) this.Line6).Width = 0.0f;
    this.Line6.X1 = 107f / 16f;
    this.Line6.X2 = 107f / 16f;
    this.Line6.Y1 = 0.0f;
    this.Line6.Y2 = 0.125f;
    this.Line7.Border.BottomColor = Color.Black;
    this.Line7.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line7.Border.LeftColor = Color.Black;
    this.Line7.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line7.Border.RightColor = Color.Black;
    this.Line7.Border.RightStyle = (BorderLineStyle) 0;
    this.Line7.Border.TopColor = Color.Black;
    this.Line7.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line7).Height = 0.125f;
    ((ARControl) this.Line7).Left = 5.75f;
    this.Line7.LineWeight = 1f;
    ((ARControl) this.Line7).Name = "Line7";
    ((ARControl) this.Line7).Top = 0.0f;
    ((ARControl) this.Line7).Width = 0.0f;
    this.Line7.X1 = 5.75f;
    this.Line7.X2 = 5.75f;
    this.Line7.Y1 = 0.0f;
    this.Line7.Y2 = 0.125f;
    this.Line8.Border.BottomColor = Color.Black;
    this.Line8.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line8.Border.LeftColor = Color.Black;
    this.Line8.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line8.Border.RightColor = Color.Black;
    this.Line8.Border.RightStyle = (BorderLineStyle) 0;
    this.Line8.Border.TopColor = Color.Black;
    this.Line8.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line8).Height = 0.125f;
    ((ARControl) this.Line8).Left = 61f / 16f;
    this.Line8.LineWeight = 1f;
    ((ARControl) this.Line8).Name = "Line8";
    ((ARControl) this.Line8).Top = 0.0f;
    ((ARControl) this.Line8).Width = 0.0f;
    this.Line8.X1 = 61f / 16f;
    this.Line8.X2 = 61f / 16f;
    this.Line8.Y1 = 0.0f;
    this.Line8.Y2 = 0.125f;
    this.Line9.Border.BottomColor = Color.Black;
    this.Line9.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line9.Border.LeftColor = Color.Black;
    this.Line9.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line9.Border.RightColor = Color.Black;
    this.Line9.Border.RightStyle = (BorderLineStyle) 0;
    this.Line9.Border.TopColor = Color.Black;
    this.Line9.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line9).Height = 0.125f;
    ((ARControl) this.Line9).Left = 165f / 16f;
    this.Line9.LineWeight = 1f;
    ((ARControl) this.Line9).Name = "Line9";
    ((ARControl) this.Line9).Top = 0.0f;
    ((ARControl) this.Line9).Width = 0.0f;
    this.Line9.X1 = 165f / 16f;
    this.Line9.X2 = 165f / 16f;
    this.Line9.Y1 = 0.0f;
    this.Line9.Y2 = 0.125f;
    this.Line10.Border.BottomColor = Color.Black;
    this.Line10.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line10.Border.LeftColor = Color.Black;
    this.Line10.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line10.Border.RightColor = Color.Black;
    this.Line10.Border.RightStyle = (BorderLineStyle) 0;
    this.Line10.Border.TopColor = Color.Black;
    this.Line10.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line10).Height = 0.125f;
    ((ARControl) this.Line10).Left = 25f / 16f;
    this.Line10.LineWeight = 1f;
    ((ARControl) this.Line10).Name = "Line10";
    ((ARControl) this.Line10).Top = 0.0f;
    ((ARControl) this.Line10).Width = 0.0f;
    this.Line10.X1 = 25f / 16f;
    this.Line10.X2 = 25f / 16f;
    this.Line10.Y1 = 0.0f;
    this.Line10.Y2 = 0.125f;
    this.Line11.Border.BottomColor = Color.Black;
    this.Line11.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line11.Border.LeftColor = Color.Black;
    this.Line11.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line11.Border.RightColor = Color.Black;
    this.Line11.Border.RightStyle = (BorderLineStyle) 0;
    this.Line11.Border.TopColor = Color.Black;
    this.Line11.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line11).Height = 0.125f;
    ((ARControl) this.Line11).Left = 0.625f;
    this.Line11.LineWeight = 1f;
    ((ARControl) this.Line11).Name = "Line11";
    ((ARControl) this.Line11).Top = 0.0f;
    ((ARControl) this.Line11).Width = 0.0f;
    this.Line11.X1 = 0.625f;
    this.Line11.X2 = 0.625f;
    this.Line11.Y1 = 0.0f;
    this.Line11.Y2 = 0.125f;
    this.Line12.Border.BottomColor = Color.Black;
    this.Line12.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line12.Border.LeftColor = Color.Black;
    this.Line12.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line12.Border.RightColor = Color.Black;
    this.Line12.Border.RightStyle = (BorderLineStyle) 0;
    this.Line12.Border.TopColor = Color.Black;
    this.Line12.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line12).Height = 0.125f;
    ((ARControl) this.Line12).Left = 0.0f;
    this.Line12.LineWeight = 1f;
    ((ARControl) this.Line12).Name = "Line12";
    ((ARControl) this.Line12).Top = 0.0f;
    ((ARControl) this.Line12).Width = 0.0f;
    this.Line12.X1 = 0.0f;
    this.Line12.X2 = 0.0f;
    this.Line12.Y1 = 0.0f;
    this.Line12.Y2 = 0.125f;
    this.ReportHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.grosspayable5,
      (ARControl) this.balancedue1,
      (ARControl) this.propamtdue1,
      (ARControl) this.paidtodate1,
      (ARControl) this.trustliability1,
      (ARControl) this.Label13
    });
    this.ReportFooter.Height = 0.2291667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.grosspayable5).Border.BottomColor = Color.Black;
    ((ARControl) this.grosspayable5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable5).Border.LeftColor = Color.Black;
    ((ARControl) this.grosspayable5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable5).Border.RightColor = Color.Black;
    ((ARControl) this.grosspayable5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable5).Border.TopColor = Color.Black;
    ((ARControl) this.grosspayable5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable5).DataField = "grosspayable";
    ((ARControl) this.grosspayable5).Height = 0.2f;
    ((ARControl) this.grosspayable5).Left = 5.75f;
    ((ARControl) this.grosspayable5).Name = "grosspayable5";
    this.grosspayable5.OutputFormat = resourceManager.GetString("grosspayable5.OutputFormat");
    this.grosspayable5.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; ";
    this.grosspayable5.SummaryGroup = "GroupHeader1";
    this.grosspayable5.SummaryRunning = (SummaryRunning) 2;
    this.grosspayable5.SummaryType = (SummaryType) 1;
    this.grosspayable5.Text = (string) null;
    ((ARControl) this.grosspayable5).Top = 0.0f;
    ((ARControl) this.grosspayable5).Width = 15f / 16f;
    ((ARControl) this.balancedue1).Border.BottomColor = Color.Black;
    ((ARControl) this.balancedue1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.balancedue1).Border.LeftColor = Color.Black;
    ((ARControl) this.balancedue1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.balancedue1).Border.RightColor = Color.Black;
    ((ARControl) this.balancedue1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.balancedue1).Border.TopColor = Color.Black;
    ((ARControl) this.balancedue1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.balancedue1).DataField = "balancedue";
    ((ARControl) this.balancedue1).Height = 0.2f;
    ((ARControl) this.balancedue1).Left = 6.75f;
    ((ARControl) this.balancedue1).Name = "balancedue1";
    this.balancedue1.OutputFormat = resourceManager.GetString("balancedue1.OutputFormat");
    this.balancedue1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; ";
    this.balancedue1.SummaryGroup = "GroupHeader1";
    this.balancedue1.SummaryRunning = (SummaryRunning) 2;
    this.balancedue1.SummaryType = (SummaryType) 1;
    this.balancedue1.Text = (string) null;
    ((ARControl) this.balancedue1).Top = 0.0f;
    ((ARControl) this.balancedue1).Width = 13f / 16f;
    ((ARControl) this.propamtdue1).Border.BottomColor = Color.Black;
    ((ARControl) this.propamtdue1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.propamtdue1).Border.LeftColor = Color.Black;
    ((ARControl) this.propamtdue1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.propamtdue1).Border.RightColor = Color.Black;
    ((ARControl) this.propamtdue1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.propamtdue1).Border.TopColor = Color.Black;
    ((ARControl) this.propamtdue1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.propamtdue1).DataField = "propamtdue";
    ((ARControl) this.propamtdue1).Height = 0.2f;
    ((ARControl) this.propamtdue1).Left = 7.625f;
    ((ARControl) this.propamtdue1).Name = "propamtdue1";
    this.propamtdue1.OutputFormat = resourceManager.GetString("propamtdue1.OutputFormat");
    this.propamtdue1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; ";
    this.propamtdue1.SummaryGroup = "GroupHeader1";
    this.propamtdue1.SummaryRunning = (SummaryRunning) 2;
    this.propamtdue1.SummaryType = (SummaryType) 1;
    this.propamtdue1.Text = (string) null;
    ((ARControl) this.propamtdue1).Top = 0.0f;
    ((ARControl) this.propamtdue1).Width = 15f / 16f;
    ((ARControl) this.paidtodate1).Border.BottomColor = Color.Black;
    ((ARControl) this.paidtodate1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidtodate1).Border.LeftColor = Color.Black;
    ((ARControl) this.paidtodate1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidtodate1).Border.RightColor = Color.Black;
    ((ARControl) this.paidtodate1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidtodate1).Border.TopColor = Color.Black;
    ((ARControl) this.paidtodate1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.paidtodate1).DataField = "paidtodate";
    ((ARControl) this.paidtodate1).Height = 0.2f;
    ((ARControl) this.paidtodate1).Left = 8.625f;
    ((ARControl) this.paidtodate1).Name = "paidtodate1";
    this.paidtodate1.OutputFormat = resourceManager.GetString("paidtodate1.OutputFormat");
    this.paidtodate1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; ";
    this.paidtodate1.SummaryGroup = "GroupHeader1";
    this.paidtodate1.SummaryRunning = (SummaryRunning) 2;
    this.paidtodate1.SummaryType = (SummaryType) 1;
    this.paidtodate1.Text = (string) null;
    ((ARControl) this.paidtodate1).Top = 0.0f;
    ((ARControl) this.paidtodate1).Width = 13f / 16f;
    ((ARControl) this.trustliability1).Border.BottomColor = Color.Black;
    ((ARControl) this.trustliability1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.trustliability1).Border.LeftColor = Color.Black;
    ((ARControl) this.trustliability1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.trustliability1).Border.RightColor = Color.Black;
    ((ARControl) this.trustliability1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.trustliability1).Border.TopColor = Color.Black;
    ((ARControl) this.trustliability1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.trustliability1).DataField = "trustliability";
    ((ARControl) this.trustliability1).Height = 0.2f;
    ((ARControl) this.trustliability1).Left = 9.5f;
    ((ARControl) this.trustliability1).Name = "trustliability1";
    this.trustliability1.OutputFormat = resourceManager.GetString("trustliability1.OutputFormat");
    this.trustliability1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8pt; ";
    this.trustliability1.SummaryGroup = "GroupHeader1";
    this.trustliability1.SummaryRunning = (SummaryRunning) 2;
    this.trustliability1.SummaryType = (SummaryType) 1;
    this.trustliability1.Text = (string) null;
    ((ARControl) this.trustliability1).Top = 0.0f;
    ((ARControl) this.trustliability1).Width = 13f / 16f;
    ((ARControl) this.Label13).Border.BottomColor = Color.Black;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftColor = Color.Black;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightColor = Color.Black;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopColor = Color.Black;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 79f / 16f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "ddo-char-set: 0; font-weight: bold; font-size: 7pt; ";
    this.Label13.Text = "Grand Total:";
    ((ARControl) this.Label13).Top = 0.0f;
    ((ARControl) this.Label13).Width = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label1,
      (ARControl) this.txtPrintdate
    });
    this.PageHeader.Height = 0.4493056f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 0.2f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 1f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; font-weight: bold; ";
    this.Label1.Text = "Premium Trust Liability Report";
    ((ARControl) this.Label1).Top = 1f / 16f;
    ((ARControl) this.Label1).Width = 39f / 16f;
    ((ARControl) this.txtPrintdate).Border.BottomColor = Color.Black;
    ((ARControl) this.txtPrintdate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPrintdate).Border.LeftColor = Color.Black;
    ((ARControl) this.txtPrintdate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPrintdate).Border.RightColor = Color.Black;
    ((ARControl) this.txtPrintdate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPrintdate).Border.TopColor = Color.Black;
    ((ARControl) this.txtPrintdate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPrintdate).Height = 0.2f;
    ((ARControl) this.txtPrintdate).Left = 1f / 16f;
    ((ARControl) this.txtPrintdate).Name = "txtPrintdate";
    this.txtPrintdate.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8pt; ";
    this.txtPrintdate.Text = "Printed On:";
    ((ARControl) this.txtPrintdate).Top = 0.25f;
    ((ARControl) this.txtPrintdate).Width = 39f / 16f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label11,
      (ARControl) this.TextBox1,
      (ARControl) this.Line13
    });
    this.GroupHeader1.DataField = "companyGuid";
    this.GroupHeader1.Height = 0.3847222f;
    this.GroupHeader1.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.RepeatStyle = (RepeatStyle) 3;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 0.125f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.0f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 7pt; ";
    this.Label2.Text = "Invoice #";
    ((ARControl) this.Label2).Top = 0.25f;
    ((ARControl) this.Label2).Width = 0.625f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 0.125f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 11f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 7pt; ";
    this.Label3.Text = "Policy #";
    ((ARControl) this.Label3).Top = 0.25f;
    ((ARControl) this.Label3).Width = 0.875f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 0.125f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 1.625f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; font-weight: bold; font-size: 7pt; ";
    this.Label4.Text = "Insured Name";
    ((ARControl) this.Label4).Top = 0.25f;
    ((ARControl) this.Label4).Width = 2.125f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 0.125f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 61f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; font-weight: bold; font-size: 7pt; ";
    this.Label5.Text = "Payee";
    ((ARControl) this.Label5).Top = 0.25f;
    ((ARControl) this.Label5).Width = 31f / 16f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 0.125f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 5.75f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 7pt; ";
    this.Label6.Text = "Gross Payable";
    ((ARControl) this.Label6).Top = 0.25f;
    ((ARControl) this.Label6).Width = 15f / 16f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 0.125f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 6.75f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 7pt; ";
    this.Label7.Text = "Balance Due";
    ((ARControl) this.Label7).Top = 0.25f;
    ((ARControl) this.Label7).Width = 13f / 16f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Height = 0.125f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 7.625f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 7pt; ";
    this.Label8.Text = "Proportional AR";
    ((ARControl) this.Label8).Top = 0.25f;
    ((ARControl) this.Label8).Width = 15f / 16f;
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 0.125f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 8.625f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 7pt; ";
    this.Label9.Text = "Amt. PTD.";
    ((ARControl) this.Label9).Top = 0.25f;
    ((ARControl) this.Label9).Width = 13f / 16f;
    ((ARControl) this.Label11).Border.BottomColor = Color.Black;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftColor = Color.Black;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightColor = Color.Black;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopColor = Color.Black;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Height = 0.125f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 9.5f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 7pt; ";
    this.Label11.Text = "Trust Liability";
    ((ARControl) this.Label11).Top = 0.25f;
    ((ARControl) this.Label11).Width = 13f / 16f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "companyName";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9pt; ";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 79f / 16f;
    this.Line13.Border.BottomColor = Color.Black;
    this.Line13.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line13.Border.LeftColor = Color.Black;
    this.Line13.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line13.Border.RightColor = Color.Black;
    this.Line13.Border.RightStyle = (BorderLineStyle) 0;
    this.Line13.Border.TopColor = Color.Black;
    this.Line13.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line13).Height = 0.0f;
    ((ARControl) this.Line13).Left = 0.0f;
    this.Line13.LineWeight = 1f;
    ((ARControl) this.Line13).Name = "Line13";
    ((ARControl) this.Line13).Top = 0.375f;
    ((ARControl) this.Line13).Width = 10.5f;
    this.Line13.X1 = 0.0f;
    this.Line13.X2 = 10.5f;
    this.Line13.Y1 = 0.375f;
    this.Line13.Y2 = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[14]
    {
      (ARControl) this.TextBox11,
      (ARControl) this.grosspayable1,
      (ARControl) this.grosspayable2,
      (ARControl) this.grosspayable3,
      (ARControl) this.grosspayable4,
      (ARControl) this.Line1,
      (ARControl) this.Line14,
      (ARControl) this.Line15,
      (ARControl) this.Line16,
      (ARControl) this.Line17,
      (ARControl) this.Line18,
      (ARControl) this.Line19,
      (ARControl) this.TextBox12,
      (ARControl) this.Label12
    });
    this.GroupFooter1.Height = 0.1354167f;
    this.GroupFooter1.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "grosspayable";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 93f / 16f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6pt; ";
    this.TextBox11.SummaryGroup = "GroupHeader1";
    this.TextBox11.SummaryRunning = (SummaryRunning) 1;
    this.TextBox11.SummaryType = (SummaryType) 3;
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.875f;
    ((ARControl) this.grosspayable1).Border.BottomColor = Color.Black;
    ((ARControl) this.grosspayable1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable1).Border.LeftColor = Color.Black;
    ((ARControl) this.grosspayable1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable1).Border.RightColor = Color.Black;
    ((ARControl) this.grosspayable1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable1).Border.TopColor = Color.Black;
    ((ARControl) this.grosspayable1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable1).DataField = "balancedue";
    ((ARControl) this.grosspayable1).Height = 0.125f;
    ((ARControl) this.grosspayable1).Left = 6.75f;
    ((ARControl) this.grosspayable1).Name = "grosspayable1";
    this.grosspayable1.OutputFormat = resourceManager.GetString("grosspayable1.OutputFormat");
    this.grosspayable1.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6pt; ";
    this.grosspayable1.SummaryGroup = "GroupHeader1";
    this.grosspayable1.SummaryRunning = (SummaryRunning) 1;
    this.grosspayable1.SummaryType = (SummaryType) 3;
    this.grosspayable1.Text = (string) null;
    ((ARControl) this.grosspayable1).Top = 0.0f;
    ((ARControl) this.grosspayable1).Width = 13f / 16f;
    ((ARControl) this.grosspayable2).Border.BottomColor = Color.Black;
    ((ARControl) this.grosspayable2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable2).Border.LeftColor = Color.Black;
    ((ARControl) this.grosspayable2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable2).Border.RightColor = Color.Black;
    ((ARControl) this.grosspayable2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable2).Border.TopColor = Color.Black;
    ((ARControl) this.grosspayable2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable2).DataField = "propamtdue";
    ((ARControl) this.grosspayable2).Height = 0.125f;
    ((ARControl) this.grosspayable2).Left = 7.625f;
    ((ARControl) this.grosspayable2).Name = "grosspayable2";
    this.grosspayable2.OutputFormat = resourceManager.GetString("grosspayable2.OutputFormat");
    this.grosspayable2.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6pt; ";
    this.grosspayable2.SummaryGroup = "GroupHeader1";
    this.grosspayable2.SummaryRunning = (SummaryRunning) 1;
    this.grosspayable2.SummaryType = (SummaryType) 3;
    this.grosspayable2.Text = (string) null;
    ((ARControl) this.grosspayable2).Top = 0.0f;
    ((ARControl) this.grosspayable2).Width = 15f / 16f;
    ((ARControl) this.grosspayable3).Border.BottomColor = Color.Black;
    ((ARControl) this.grosspayable3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable3).Border.LeftColor = Color.Black;
    ((ARControl) this.grosspayable3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable3).Border.RightColor = Color.Black;
    ((ARControl) this.grosspayable3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable3).Border.TopColor = Color.Black;
    ((ARControl) this.grosspayable3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable3).DataField = "paidtodate";
    ((ARControl) this.grosspayable3).Height = 0.125f;
    ((ARControl) this.grosspayable3).Left = 8.625f;
    ((ARControl) this.grosspayable3).Name = "grosspayable3";
    this.grosspayable3.OutputFormat = resourceManager.GetString("grosspayable3.OutputFormat");
    this.grosspayable3.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6pt; ";
    this.grosspayable3.SummaryGroup = "GroupHeader1";
    this.grosspayable3.SummaryRunning = (SummaryRunning) 1;
    this.grosspayable3.SummaryType = (SummaryType) 3;
    this.grosspayable3.Text = (string) null;
    ((ARControl) this.grosspayable3).Top = 0.0f;
    ((ARControl) this.grosspayable3).Width = 13f / 16f;
    ((ARControl) this.grosspayable4).Border.BottomColor = Color.Black;
    ((ARControl) this.grosspayable4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable4).Border.LeftColor = Color.Black;
    ((ARControl) this.grosspayable4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable4).Border.RightColor = Color.Black;
    ((ARControl) this.grosspayable4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable4).Border.TopColor = Color.Black;
    ((ARControl) this.grosspayable4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.grosspayable4).DataField = "trustliability";
    ((ARControl) this.grosspayable4).Height = 0.125f;
    ((ARControl) this.grosspayable4).Left = 9.5f;
    ((ARControl) this.grosspayable4).Name = "grosspayable4";
    this.grosspayable4.OutputFormat = resourceManager.GetString("grosspayable4.OutputFormat");
    this.grosspayable4.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6pt; ";
    this.grosspayable4.SummaryGroup = "GroupHeader1";
    this.grosspayable4.SummaryRunning = (SummaryRunning) 1;
    this.grosspayable4.SummaryType = (SummaryType) 3;
    this.grosspayable4.Text = (string) null;
    ((ARControl) this.grosspayable4).Top = 0.0f;
    ((ARControl) this.grosspayable4).Width = 13f / 16f;
    this.Line1.Border.BottomColor = Color.Black;
    this.Line1.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line1.Border.LeftColor = Color.Black;
    this.Line1.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line1.Border.RightColor = Color.Black;
    this.Line1.Border.RightStyle = (BorderLineStyle) 0;
    this.Line1.Border.TopColor = Color.Black;
    this.Line1.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 0.0f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 0.125f;
    ((ARControl) this.Line1).Width = 165f / 16f;
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 165f / 16f;
    this.Line1.Y1 = 0.125f;
    this.Line1.Y2 = 0.125f;
    this.Line14.Border.BottomColor = Color.Black;
    this.Line14.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line14.Border.LeftColor = Color.Black;
    this.Line14.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line14.Border.RightColor = Color.Black;
    this.Line14.Border.RightStyle = (BorderLineStyle) 0;
    this.Line14.Border.TopColor = Color.Black;
    this.Line14.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line14).Height = 0.125f;
    ((ARControl) this.Line14).Left = 165f / 16f;
    this.Line14.LineWeight = 1f;
    ((ARControl) this.Line14).Name = "Line14";
    ((ARControl) this.Line14).Top = 0.0f;
    ((ARControl) this.Line14).Width = 0.0f;
    this.Line14.X1 = 165f / 16f;
    this.Line14.X2 = 165f / 16f;
    this.Line14.Y1 = 0.0f;
    this.Line14.Y2 = 0.125f;
    this.Line15.Border.BottomColor = Color.Black;
    this.Line15.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line15.Border.LeftColor = Color.Black;
    this.Line15.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line15.Border.RightColor = Color.Black;
    this.Line15.Border.RightStyle = (BorderLineStyle) 0;
    this.Line15.Border.TopColor = Color.Black;
    this.Line15.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line15).Height = 0.125f;
    ((ARControl) this.Line15).Left = 107f / 16f;
    this.Line15.LineWeight = 1f;
    ((ARControl) this.Line15).Name = "Line15";
    ((ARControl) this.Line15).Top = 0.0f;
    ((ARControl) this.Line15).Width = 0.0f;
    this.Line15.X1 = 107f / 16f;
    this.Line15.X2 = 107f / 16f;
    this.Line15.Y1 = 0.0f;
    this.Line15.Y2 = 0.125f;
    this.Line16.Border.BottomColor = Color.Black;
    this.Line16.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line16.Border.LeftColor = Color.Black;
    this.Line16.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line16.Border.RightColor = Color.Black;
    this.Line16.Border.RightStyle = (BorderLineStyle) 0;
    this.Line16.Border.TopColor = Color.Black;
    this.Line16.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line16).Height = 0.125f;
    ((ARControl) this.Line16).Left = 121f / 16f;
    this.Line16.LineWeight = 1f;
    ((ARControl) this.Line16).Name = "Line16";
    ((ARControl) this.Line16).Top = 0.0f;
    ((ARControl) this.Line16).Width = 0.0f;
    this.Line16.X1 = 121f / 16f;
    this.Line16.X2 = 121f / 16f;
    this.Line16.Y1 = 0.0f;
    this.Line16.Y2 = 0.125f;
    this.Line17.Border.BottomColor = Color.Black;
    this.Line17.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line17.Border.LeftColor = Color.Black;
    this.Line17.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line17.Border.RightColor = Color.Black;
    this.Line17.Border.RightStyle = (BorderLineStyle) 0;
    this.Line17.Border.TopColor = Color.Black;
    this.Line17.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line17).Height = 0.125f;
    ((ARControl) this.Line17).Left = 5.75f;
    this.Line17.LineWeight = 1f;
    ((ARControl) this.Line17).Name = "Line17";
    ((ARControl) this.Line17).Top = 0.0f;
    ((ARControl) this.Line17).Width = 0.0f;
    this.Line17.X1 = 5.75f;
    this.Line17.X2 = 5.75f;
    this.Line17.Y1 = 0.0f;
    this.Line17.Y2 = 0.125f;
    this.Line18.Border.BottomColor = Color.Black;
    this.Line18.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line18.Border.LeftColor = Color.Black;
    this.Line18.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line18.Border.RightColor = Color.Black;
    this.Line18.Border.RightStyle = (BorderLineStyle) 0;
    this.Line18.Border.TopColor = Color.Black;
    this.Line18.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line18).Height = 0.125f;
    ((ARControl) this.Line18).Left = 137f / 16f;
    this.Line18.LineWeight = 1f;
    ((ARControl) this.Line18).Name = "Line18";
    ((ARControl) this.Line18).Top = 0.0f;
    ((ARControl) this.Line18).Width = 0.0f;
    this.Line18.X1 = 137f / 16f;
    this.Line18.X2 = 137f / 16f;
    this.Line18.Y1 = 0.0f;
    this.Line18.Y2 = 0.125f;
    this.Line19.Border.BottomColor = Color.Black;
    this.Line19.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line19.Border.LeftColor = Color.Black;
    this.Line19.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line19.Border.RightColor = Color.Black;
    this.Line19.Border.RightStyle = (BorderLineStyle) 0;
    this.Line19.Border.TopColor = Color.Black;
    this.Line19.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line19).Height = 0.125f;
    ((ARControl) this.Line19).Left = 151f / 16f;
    this.Line19.LineWeight = 1f;
    ((ARControl) this.Line19).Name = "Line19";
    ((ARControl) this.Line19).Top = 0.0f;
    ((ARControl) this.Line19).Width = 0.0f;
    this.Line19.X1 = 151f / 16f;
    this.Line19.X2 = 151f / 16f;
    this.Line19.Y1 = 0.0f;
    this.Line19.Y2 = 0.125f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "payee";
    ((ARControl) this.TextBox12).Height = 0.125f;
    ((ARControl) this.TextBox12).Left = 41f / 16f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.Style = "ddo-char-set: 0; text-align: right; font-size: 7pt; ";
    this.TextBox12.Text = (string) null;
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 2.375f;
    ((ARControl) this.Label12).Border.BottomColor = Color.Black;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftColor = Color.Black;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightColor = Color.Black;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopColor = Color.Black;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Height = 0.125f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 79f / 16f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "ddo-char-set: 0; font-weight: bold; font-size: 7pt; ";
    this.Label12.Text = "  Total:";
    ((ARControl) this.Label12).Top = 0.0f;
    ((ARControl) this.Label12).Width = 0.75f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.2f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.35417f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.grosspayable5).EndInit();
    ((ISupportInitialize) this.balancedue1).EndInit();
    ((ISupportInitialize) this.propamtdue1).EndInit();
    ((ISupportInitialize) this.paidtodate1).EndInit();
    ((ISupportInitialize) this.trustliability1).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtPrintdate).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.grosspayable1).EndInit();
    ((ISupportInitialize) this.grosspayable2).EndInit();
    ((ISupportInitialize) this.grosspayable3).EndInit();
    ((ISupportInitialize) this.grosspayable4).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void LoadData()
  {
    Database.Instance.QueryMultithreadedSP.PerformTableQueryBG(new TableQueryMultithreadEventHandler(this.TableFilled), new TableFillingEventHandler(this.TableFilling), (object) "trustLiability", "spFin_rptPremiumtLiabilityReport", (object) "@glcompanyid", (object) this._glCompanyId, (object) "@asof", (object) this._asof);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new AccountingOfficeLocations("Office Location", false, true),
        (BaseReportControl) new DatePicker("As of", DateAndTime.Now.Date, false)
      };
    }
  }

  private void TableFilling(object sender, TableFillingEventArgs e)
  {
    this.SetStatusText("Formatting..");
    this.IncreaseProgressbar(1);
    // ISSUE: variable of a reference type
    int& local1;
    // ISSUE: explicit reference operation
    int num1 = checked (^(local1 = ref this.recs) + 1);
    local1 = num1;
    if (checked (this.recs - 1) != this.recMax)
      return;
    // ISSUE: variable of a reference type
    int& local2;
    // ISSUE: explicit reference operation
    int num2 = checked (^(local2 = ref this.recMax) + 50);
    local2 = num2;
    this.SetProgressbarMaximum(this.recMax);
  }

  private void TableFilled(object sender, TableQueryMultithreadEventArgs e)
  {
    this.dt = e.Table;
    this.DataSource = (object) this.dt;
    this.finished = true;
  }

  private void rptTrustLiability_ReportStart(object sender, EventArgs e)
  {
    do
      ;
    while (!this.finished);
    this.ShowPageNumbers();
    this.txtPrintdate.Text = $"Printed On: {Strings.Format((object) DateTime.Now, "Short Date")}";
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
