// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptDisbursementReport_Detail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public sealed class rptDisbursementReport_Detail : SectionReport
{
  private Decimal CheckTotal;
  private Font strikeFont;
  private Font noStrikeFont;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private CheckBox CheckBox1;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private TextBox txtCheckAmountTotal;
  private TextBox txtAPTotal;
  private TextBox txtIncomeTotal;
  private TextBox txtARTotal;
  private TextBox txtUnAcctTotal;
  private TextBox txtExchTotal;
  private TextBox txtExpenseTotal;
  private TextBox txtOtherTotal;

  public rptDisbursementReport_Detail()
  {
    this.strikeFont = new Font("Arial", 8f, System.Drawing.FontStyle.Strikeout);
    this.noStrikeFont = new Font("Arial", 8f);
    this.InitializeComponent();
  }

  public rptDisbursementReport_Detail(DataTable ds)
  {
    this.strikeFont = new Font("Arial", 8f, System.Drawing.FontStyle.Strikeout);
    this.noStrikeFont = new Font("Arial", 8f);
    this.InitializeComponent();
    this.DataSource = (object) ds;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptDisbursementReport_Detail));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.CheckBox1 = new CheckBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.txtCheckAmountTotal = new TextBox();
    this.txtAPTotal = new TextBox();
    this.txtIncomeTotal = new TextBox();
    this.txtARTotal = new TextBox();
    this.txtUnAcctTotal = new TextBox();
    this.txtExchTotal = new TextBox();
    this.txtExpenseTotal = new TextBox();
    this.txtOtherTotal = new TextBox();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.CheckBox1).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.txtCheckAmountTotal).BeginInit();
    ((ISupportInitialize) this.txtAPTotal).BeginInit();
    ((ISupportInitialize) this.txtIncomeTotal).BeginInit();
    ((ISupportInitialize) this.txtARTotal).BeginInit();
    ((ISupportInitialize) this.txtUnAcctTotal).BeginInit();
    ((ISupportInitialize) this.txtExchTotal).BeginInit();
    ((ISupportInitialize) this.txtExpenseTotal).BeginInit();
    ((ISupportInitialize) this.txtOtherTotal).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.CheckBox1,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "checkDate";
    ((ARControl) this.TextBox1).Height = 0.188f;
    ((ARControl) this.TextBox1).Left = 0.01f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.6779999f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "payeeName";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 11f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 2.25f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "checkNumber";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 53f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 8pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.5f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "checkAmt";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 61f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "font-size: 8pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox5.Text = "0.00";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 15f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "incomeAmt";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 4.75f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "font-size: 8pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox6.Text = "0.00";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 13f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "apAmt";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 89f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "font-size: 8pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox7.Text = "0.00";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 13f / 16f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "arAmt";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 6.375f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "font-size: 8pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox8.Text = "0.00";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 0.75f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).DataField = "unAcctAmt";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 7.125f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "background-color: WhiteSmoke; font-size: 8pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox9.Text = "0.00";
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 13f / 16f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).DataField = "exchAmt";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = (float) sbyte.MaxValue / 16f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "background-color: WhiteSmoke; font-size: 8pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox10.Text = "0.00";
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 13f / 16f;
    ((ARControl) this.CheckBox1).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.CheckBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox1).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.CheckBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox1).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.CheckBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.CheckBox1).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.CheckBox1).Border.TopStyle = (BorderLineStyle) 1;
    this.CheckBox1.CheckAlignment = ContentAlignment.MiddleCenter;
    ((ARControl) this.CheckBox1).DataField = "void";
    ((ARControl) this.CheckBox1).Height = 3f / 16f;
    ((ARControl) this.CheckBox1).Left = 47f / 16f;
    ((ARControl) this.CheckBox1).Name = "CheckBox1";
    this.CheckBox1.Style = "font-family: Tahoma; font-size: 8pt; ddo-char-set: 0";
    this.CheckBox1.Text = "";
    ((ARControl) this.CheckBox1).Top = 0.0f;
    ((ARControl) this.CheckBox1).Width = 0.375f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).DataField = "expAmt";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 8.75f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "background-color: WhiteSmoke; font-size: 8pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox11.Text = "0.00";
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.75f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).DataField = "otherAmt";
    ((ARControl) this.TextBox12).Height = 3f / 16f;
    ((ARControl) this.TextBox12).Left = 9.5f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "background-color: WhiteSmoke; font-size: 8pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox12.Text = "0.00";
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 0.875f;
    this.ReportHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.txtCheckAmountTotal,
      (ARControl) this.txtAPTotal,
      (ARControl) this.txtIncomeTotal,
      (ARControl) this.txtARTotal,
      (ARControl) this.txtUnAcctTotal,
      (ARControl) this.txtExchTotal,
      (ARControl) this.txtExpenseTotal,
      (ARControl) this.txtOtherTotal
    });
    this.ReportFooter.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.txtCheckAmountTotal).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.txtCheckAmountTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtCheckAmountTotal).DataField = " ";
    ((ARControl) this.txtCheckAmountTotal).Height = 3f / 16f;
    ((ARControl) this.txtCheckAmountTotal).Left = 61f / 16f;
    ((ARControl) this.txtCheckAmountTotal).Name = "txtCheckAmountTotal";
    this.txtCheckAmountTotal.OutputFormat = resourceManager.GetString("txtCheckAmountTotal.OutputFormat");
    this.txtCheckAmountTotal.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtCheckAmountTotal.Text = " ";
    ((ARControl) this.txtCheckAmountTotal).Top = 0.0f;
    ((ARControl) this.txtCheckAmountTotal).Width = 15f / 16f;
    ((ARControl) this.txtAPTotal).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.txtAPTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtAPTotal).DataField = " ";
    ((ARControl) this.txtAPTotal).Height = 3f / 16f;
    ((ARControl) this.txtAPTotal).Left = 89f / 16f;
    ((ARControl) this.txtAPTotal).Name = "txtAPTotal";
    this.txtAPTotal.OutputFormat = resourceManager.GetString("txtAPTotal.OutputFormat");
    this.txtAPTotal.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtAPTotal.Text = " ";
    ((ARControl) this.txtAPTotal).Top = 0.0f;
    ((ARControl) this.txtAPTotal).Width = 13f / 16f;
    ((ARControl) this.txtIncomeTotal).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.txtIncomeTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtIncomeTotal).DataField = " ";
    ((ARControl) this.txtIncomeTotal).Height = 3f / 16f;
    ((ARControl) this.txtIncomeTotal).Left = 4.75f;
    ((ARControl) this.txtIncomeTotal).Name = "txtIncomeTotal";
    this.txtIncomeTotal.OutputFormat = resourceManager.GetString("txtIncomeTotal.OutputFormat");
    this.txtIncomeTotal.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtIncomeTotal.Text = " ";
    ((ARControl) this.txtIncomeTotal).Top = 0.0f;
    ((ARControl) this.txtIncomeTotal).Width = 13f / 16f;
    ((ARControl) this.txtARTotal).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.txtARTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtARTotal).DataField = " ";
    ((ARControl) this.txtARTotal).Height = 3f / 16f;
    ((ARControl) this.txtARTotal).Left = 6.375f;
    ((ARControl) this.txtARTotal).Name = "txtARTotal";
    this.txtARTotal.OutputFormat = resourceManager.GetString("txtARTotal.OutputFormat");
    this.txtARTotal.Style = "font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtARTotal.Text = " ";
    ((ARControl) this.txtARTotal).Top = 0.0f;
    ((ARControl) this.txtARTotal).Width = 0.75f;
    ((ARControl) this.txtUnAcctTotal).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.txtUnAcctTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtUnAcctTotal).DataField = " ";
    ((ARControl) this.txtUnAcctTotal).Height = 3f / 16f;
    ((ARControl) this.txtUnAcctTotal).Left = 7.125f;
    ((ARControl) this.txtUnAcctTotal).Name = "txtUnAcctTotal";
    this.txtUnAcctTotal.OutputFormat = resourceManager.GetString("txtUnAcctTotal.OutputFormat");
    this.txtUnAcctTotal.Style = "background-color: WhiteSmoke; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtUnAcctTotal.Text = " ";
    ((ARControl) this.txtUnAcctTotal).Top = 0.0f;
    ((ARControl) this.txtUnAcctTotal).Width = 13f / 16f;
    ((ARControl) this.txtExchTotal).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.txtExchTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExchTotal).Height = 3f / 16f;
    ((ARControl) this.txtExchTotal).Left = (float) sbyte.MaxValue / 16f;
    ((ARControl) this.txtExchTotal).Name = "txtExchTotal";
    this.txtExchTotal.OutputFormat = resourceManager.GetString("txtExchTotal.OutputFormat");
    this.txtExchTotal.Style = "background-color: WhiteSmoke; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtExchTotal.Text = " ";
    ((ARControl) this.txtExchTotal).Top = 0.0f;
    ((ARControl) this.txtExchTotal).Width = 13f / 16f;
    ((ARControl) this.txtExpenseTotal).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.txtExpenseTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpenseTotal).Height = 3f / 16f;
    ((ARControl) this.txtExpenseTotal).Left = 8.75f;
    ((ARControl) this.txtExpenseTotal).Name = "txtExpenseTotal";
    this.txtExpenseTotal.OutputFormat = resourceManager.GetString("txtExpenseTotal.OutputFormat");
    this.txtExpenseTotal.Style = "background-color: WhiteSmoke; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtExpenseTotal.Text = " ";
    ((ARControl) this.txtExpenseTotal).Top = 0.0f;
    ((ARControl) this.txtExpenseTotal).Width = 13f / 16f;
    ((ARControl) this.txtOtherTotal).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.txtOtherTotal).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtOtherTotal).DataField = " ";
    ((ARControl) this.txtOtherTotal).Height = 3f / 16f;
    ((ARControl) this.txtOtherTotal).Left = 153f / 16f;
    ((ARControl) this.txtOtherTotal).Name = "txtOtherTotal";
    this.txtOtherTotal.OutputFormat = resourceManager.GetString("txtOtherTotal.OutputFormat");
    this.txtOtherTotal.Style = "background-color: WhiteSmoke; font-size: 8pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.txtOtherTotal.Text = " ";
    ((ARControl) this.txtOtherTotal).Top = 0.0f;
    ((ARControl) this.txtOtherTotal).Width = 13f / 16f;
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.0f;
    this.PageSettings.Margins.Left = 0.0f;
    this.PageSettings.Margins.Right = 0.0f;
    this.PageSettings.Margins.Top = 0.0f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.CheckBox1).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.txtCheckAmountTotal).EndInit();
    ((ISupportInitialize) this.txtAPTotal).EndInit();
    ((ISupportInitialize) this.txtIncomeTotal).EndInit();
    ((ISupportInitialize) this.txtARTotal).EndInit();
    ((ISupportInitialize) this.txtUnAcctTotal).EndInit();
    ((ISupportInitialize) this.txtExchTotal).EndInit();
    ((ISupportInitialize) this.txtExpenseTotal).EndInit();
    ((ISupportInitialize) this.txtOtherTotal).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this.CheckBox1.Checked)
    {
      this.TextBox5.Font = this.strikeFont;
      this.TextBox6.Font = this.strikeFont;
      this.TextBox7.Font = this.strikeFont;
      this.TextBox8.Font = this.strikeFont;
      this.TextBox9.Font = this.strikeFont;
      this.TextBox10.Font = this.strikeFont;
      this.TextBox11.Font = this.strikeFont;
      this.TextBox12.Font = this.strikeFont;
    }
    else
    {
      this.TextBox5.Font = this.noStrikeFont;
      this.TextBox6.Font = this.noStrikeFont;
      this.TextBox7.Font = this.noStrikeFont;
      this.TextBox8.Font = this.noStrikeFont;
      this.TextBox9.Font = this.noStrikeFont;
      this.TextBox10.Font = this.noStrikeFont;
      this.TextBox11.Font = this.noStrikeFont;
      this.TextBox12.Font = this.noStrikeFont;
    }
  }

  protected override void Dispose(bool disposing)
  {
    this.strikeFont.Dispose();
    this.noStrikeFont.Dispose();
  }

  private void ReportFooter_BeforePrint(object sender, EventArgs e)
  {
    this.txtCheckAmountTotal.Value = (object) Database.IsNull(RuntimeHelpers.GetObjectValue(((DataTable) this.DataSource).Compute("Sum(checkAmt)", "void=0")), 0M);
    this.txtIncomeTotal.Value = (object) Database.IsNull(RuntimeHelpers.GetObjectValue(((DataTable) this.DataSource).Compute("Sum(incomeAmt)", "void=0")), 0M);
    this.txtAPTotal.Value = (object) Database.IsNull(RuntimeHelpers.GetObjectValue(((DataTable) this.DataSource).Compute("Sum(apAmt)", "void=0")), 0M);
    this.txtARTotal.Value = (object) Database.IsNull(RuntimeHelpers.GetObjectValue(((DataTable) this.DataSource).Compute("Sum(arAmt)", "void=0")), 0M);
    this.txtUnAcctTotal.Value = (object) Database.IsNull(RuntimeHelpers.GetObjectValue(((DataTable) this.DataSource).Compute("Sum(unAcctAmt)", "void=0")), 0M);
    this.txtExchTotal.Value = (object) Database.IsNull(RuntimeHelpers.GetObjectValue(((DataTable) this.DataSource).Compute("Sum(exchAmt)", "void=0")), 0M);
    this.txtExpenseTotal.Value = (object) Database.IsNull(RuntimeHelpers.GetObjectValue(((DataTable) this.DataSource).Compute("Sum(expAmt)", "void=0")), 0M);
    this.txtOtherTotal.Value = (object) Database.IsNull(RuntimeHelpers.GetObjectValue(((DataTable) this.DataSource).Compute("Sum(otherAmt)", "void=0")), 0M);
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual ReportFooter ReportFooter
  {
    get => this._ReportFooter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportFooter_BeforePrint);
      ReportFooter reportFooter1 = this._ReportFooter;
      if (reportFooter1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter1).BeforePrint -= eventHandler;
      this._ReportFooter = value;
      ReportFooter reportFooter2 = this._ReportFooter;
      if (reportFooter2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter2).BeforePrint += eventHandler;
    }
  }
}
