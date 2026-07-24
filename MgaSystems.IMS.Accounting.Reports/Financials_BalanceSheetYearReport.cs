// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.Financials_BalanceSheetYearReport
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[DesignerGenerated]
[SecureReportResource("{138DC825-3446-4409-99F7-623C683A6120}", "Yearly Balance Sheet", "Yearly Balance Sheet", "Financials")]
public class Financials_BalanceSheetYearReport : MGAReport, IReport, ISupportReportDatabase
{
  private IContainer components;
  private int _priorTo;
  private int _gLCompanyID;
  private DataSet _ds;
  private DataView _dv;
  private Database _reportDatabase;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (Financials_BalanceSheetYearReport));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.txtClientOfficeName = new TextBox();
    this.txtYear = new TextBox();
    this.lblMonth12 = new Label();
    this.lblMonth11 = new Label();
    this.lblMonth10 = new Label();
    this.lblMonth6 = new Label();
    this.lblMonth5 = new Label();
    this.lblMonth4 = new Label();
    this.lblMonth9 = new Label();
    this.lblMonth8 = new Label();
    this.lblMonth7 = new Label();
    this.lblMonth3 = new Label();
    this.lblMonth2 = new Label();
    this.lblMonth1 = new Label();
    this.Detail1 = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.TextBox14 = new TextBox();
    this.PageFooter1 = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.txtAcctClassName = new TextBox();
    this.GroupFooter1 = new GroupFooter();
    this.TextBox27 = new TextBox();
    this.TextBox28 = new TextBox();
    this.TextBox29 = new TextBox();
    this.TextBox30 = new TextBox();
    this.TextBox31 = new TextBox();
    this.TextBox32 = new TextBox();
    this.TextBox33 = new TextBox();
    this.TextBox34 = new TextBox();
    this.TextBox35 = new TextBox();
    this.TextBox36 = new TextBox();
    this.TextBox37 = new TextBox();
    this.TextBox38 = new TextBox();
    this.txtSubTotalAcctClassName = new TextBox();
    this.GroupHeader2 = new GroupHeader();
    this.txtAcctTypeDescription = new TextBox();
    this.GroupFooter2 = new GroupFooter();
    this.TextBox15 = new TextBox();
    this.TextBox16 = new TextBox();
    this.TextBox17 = new TextBox();
    this.TextBox18 = new TextBox();
    this.TextBox19 = new TextBox();
    this.TextBox20 = new TextBox();
    this.TextBox21 = new TextBox();
    this.TextBox22 = new TextBox();
    this.TextBox23 = new TextBox();
    this.TextBox24 = new TextBox();
    this.TextBox25 = new TextBox();
    this.TextBox26 = new TextBox();
    this.txtSubTotalAcctTypeDescription = new TextBox();
    this.ReportHeader1 = new ReportHeader();
    this.ReportFooter1 = new ReportFooter();
    this.TextBox39 = new TextBox();
    this.TextBox40 = new TextBox();
    this.TextBox41 = new TextBox();
    this.TextBox42 = new TextBox();
    this.TextBox43 = new TextBox();
    this.TextBox44 = new TextBox();
    this.TextBox45 = new TextBox();
    this.TextBox46 = new TextBox();
    this.TextBox47 = new TextBox();
    this.TextBox48 = new TextBox();
    this.TextBox49 = new TextBox();
    this.TextBox50 = new TextBox();
    this.TextBox51 = new TextBox();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtClientOfficeName).BeginInit();
    ((ISupportInitialize) this.txtYear).BeginInit();
    ((ISupportInitialize) this.lblMonth12).BeginInit();
    ((ISupportInitialize) this.lblMonth11).BeginInit();
    ((ISupportInitialize) this.lblMonth10).BeginInit();
    ((ISupportInitialize) this.lblMonth6).BeginInit();
    ((ISupportInitialize) this.lblMonth5).BeginInit();
    ((ISupportInitialize) this.lblMonth4).BeginInit();
    ((ISupportInitialize) this.lblMonth9).BeginInit();
    ((ISupportInitialize) this.lblMonth8).BeginInit();
    ((ISupportInitialize) this.lblMonth7).BeginInit();
    ((ISupportInitialize) this.lblMonth3).BeginInit();
    ((ISupportInitialize) this.lblMonth2).BeginInit();
    ((ISupportInitialize) this.lblMonth1).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.txtAcctClassName).BeginInit();
    ((ISupportInitialize) this.TextBox27).BeginInit();
    ((ISupportInitialize) this.TextBox28).BeginInit();
    ((ISupportInitialize) this.TextBox29).BeginInit();
    ((ISupportInitialize) this.TextBox30).BeginInit();
    ((ISupportInitialize) this.TextBox31).BeginInit();
    ((ISupportInitialize) this.TextBox32).BeginInit();
    ((ISupportInitialize) this.TextBox33).BeginInit();
    ((ISupportInitialize) this.TextBox34).BeginInit();
    ((ISupportInitialize) this.TextBox35).BeginInit();
    ((ISupportInitialize) this.TextBox36).BeginInit();
    ((ISupportInitialize) this.TextBox37).BeginInit();
    ((ISupportInitialize) this.TextBox38).BeginInit();
    ((ISupportInitialize) this.txtSubTotalAcctClassName).BeginInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.TextBox23).BeginInit();
    ((ISupportInitialize) this.TextBox24).BeginInit();
    ((ISupportInitialize) this.TextBox25).BeginInit();
    ((ISupportInitialize) this.TextBox26).BeginInit();
    ((ISupportInitialize) this.txtSubTotalAcctTypeDescription).BeginInit();
    ((ISupportInitialize) this.TextBox39).BeginInit();
    ((ISupportInitialize) this.TextBox40).BeginInit();
    ((ISupportInitialize) this.TextBox41).BeginInit();
    ((ISupportInitialize) this.TextBox42).BeginInit();
    ((ISupportInitialize) this.TextBox43).BeginInit();
    ((ISupportInitialize) this.TextBox44).BeginInit();
    ((ISupportInitialize) this.TextBox45).BeginInit();
    ((ISupportInitialize) this.TextBox46).BeginInit();
    ((ISupportInitialize) this.TextBox47).BeginInit();
    ((ISupportInitialize) this.TextBox48).BeginInit();
    ((ISupportInitialize) this.TextBox49).BeginInit();
    ((ISupportInitialize) this.TextBox50).BeginInit();
    ((ISupportInitialize) this.TextBox51).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[15]
    {
      (ARControl) this.Label1,
      (ARControl) this.txtClientOfficeName,
      (ARControl) this.txtYear,
      (ARControl) this.lblMonth12,
      (ARControl) this.lblMonth11,
      (ARControl) this.lblMonth10,
      (ARControl) this.lblMonth6,
      (ARControl) this.lblMonth5,
      (ARControl) this.lblMonth4,
      (ARControl) this.lblMonth9,
      (ARControl) this.lblMonth8,
      (ARControl) this.lblMonth7,
      (ARControl) this.lblMonth3,
      (ARControl) this.lblMonth2,
      (ARControl) this.lblMonth1
    });
    this.PageHeader1.Height = 0.9479167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 0.25f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 14.25pt; ";
    this.Label1.Text = "Annual Balance Sheet";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 10.375f;
    ((ARControl) this.txtClientOfficeName).Border.BottomColor = Color.Black;
    ((ARControl) this.txtClientOfficeName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClientOfficeName).Border.LeftColor = Color.Black;
    ((ARControl) this.txtClientOfficeName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClientOfficeName).Border.RightColor = Color.Black;
    ((ARControl) this.txtClientOfficeName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClientOfficeName).Border.TopColor = Color.Black;
    ((ARControl) this.txtClientOfficeName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtClientOfficeName).Height = 3f / 16f;
    ((ARControl) this.txtClientOfficeName).Left = 0.0f;
    ((ARControl) this.txtClientOfficeName).Name = "txtClientOfficeName";
    this.txtClientOfficeName.Style = "ddo-char-set: 0; font-weight: bold; font-size: 12pt; ";
    this.txtClientOfficeName.Text = (string) null;
    ((ARControl) this.txtClientOfficeName).Top = 5f / 16f;
    ((ARControl) this.txtClientOfficeName).Width = 10.375f;
    ((ARControl) this.txtYear).Border.BottomColor = Color.Black;
    ((ARControl) this.txtYear).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtYear).Border.LeftColor = Color.Black;
    ((ARControl) this.txtYear).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtYear).Border.RightColor = Color.Black;
    ((ARControl) this.txtYear).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtYear).Border.TopColor = Color.Black;
    ((ARControl) this.txtYear).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtYear).Height = 3f / 16f;
    ((ARControl) this.txtYear).Left = 0.0f;
    ((ARControl) this.txtYear).Name = "txtYear";
    this.txtYear.Style = "ddo-char-set: 0; font-weight: bold; font-size: 12pt; ";
    this.txtYear.Text = (string) null;
    ((ARControl) this.txtYear).Top = 9f / 16f;
    ((ARControl) this.txtYear).Width = 10.375f;
    ((ARControl) this.lblMonth12).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth12).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth12).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth12).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth12).Height = 0.125f;
    this.lblMonth12.HyperLink = (string) null;
    ((ARControl) this.lblMonth12).Left = 155f / 16f;
    ((ARControl) this.lblMonth12).Name = "lblMonth12";
    this.lblMonth12.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth12.Text = "December";
    ((ARControl) this.lblMonth12).Top = 13f / 16f;
    ((ARControl) this.lblMonth12).Width = 11f / 16f;
    ((ARControl) this.lblMonth11).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth11).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth11).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth11).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth11).Height = 0.125f;
    this.lblMonth11.HyperLink = (string) null;
    ((ARControl) this.lblMonth11).Left = 9f;
    ((ARControl) this.lblMonth11).Name = "lblMonth11";
    this.lblMonth11.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth11.Text = "November";
    ((ARControl) this.lblMonth11).Top = 13f / 16f;
    ((ARControl) this.lblMonth11).Width = 11f / 16f;
    ((ARControl) this.lblMonth10).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth10).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth10).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth10).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth10).Height = 0.125f;
    this.lblMonth10.HyperLink = (string) null;
    ((ARControl) this.lblMonth10).Left = 133f / 16f;
    ((ARControl) this.lblMonth10).Name = "lblMonth10";
    this.lblMonth10.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth10.Text = "October";
    ((ARControl) this.lblMonth10).Top = 13f / 16f;
    ((ARControl) this.lblMonth10).Width = 11f / 16f;
    ((ARControl) this.lblMonth6).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth6).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth6).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth6).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth6).Height = 0.125f;
    this.lblMonth6.HyperLink = (string) null;
    ((ARControl) this.lblMonth6).Left = 89f / 16f;
    ((ARControl) this.lblMonth6).Name = "lblMonth6";
    this.lblMonth6.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth6.Text = "June";
    ((ARControl) this.lblMonth6).Top = 13f / 16f;
    ((ARControl) this.lblMonth6).Width = 11f / 16f;
    ((ARControl) this.lblMonth5).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth5).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth5).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth5).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth5).Height = 0.125f;
    this.lblMonth5.HyperLink = (string) null;
    ((ARControl) this.lblMonth5).Left = 4.875f;
    ((ARControl) this.lblMonth5).Name = "lblMonth5";
    this.lblMonth5.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth5.Text = "May";
    ((ARControl) this.lblMonth5).Top = 13f / 16f;
    ((ARControl) this.lblMonth5).Width = 11f / 16f;
    ((ARControl) this.lblMonth4).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth4).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth4).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth4).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth4).Height = 0.125f;
    this.lblMonth4.HyperLink = (string) null;
    ((ARControl) this.lblMonth4).Left = 67f / 16f;
    ((ARControl) this.lblMonth4).Name = "lblMonth4";
    this.lblMonth4.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth4.Text = "April";
    ((ARControl) this.lblMonth4).Top = 13f / 16f;
    ((ARControl) this.lblMonth4).Width = 11f / 16f;
    ((ARControl) this.lblMonth9).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth9).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth9).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth9).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth9).Height = 0.125f;
    this.lblMonth9.HyperLink = (string) null;
    ((ARControl) this.lblMonth9).Left = 7.625f;
    ((ARControl) this.lblMonth9).Name = "lblMonth9";
    this.lblMonth9.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth9.Text = "September";
    ((ARControl) this.lblMonth9).Top = 13f / 16f;
    ((ARControl) this.lblMonth9).Width = 11f / 16f;
    ((ARControl) this.lblMonth8).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth8).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth8).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth8).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth8).Height = 0.125f;
    this.lblMonth8.HyperLink = (string) null;
    ((ARControl) this.lblMonth8).Left = 111f / 16f;
    ((ARControl) this.lblMonth8).Name = "lblMonth8";
    this.lblMonth8.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth8.Text = "August";
    ((ARControl) this.lblMonth8).Top = 13f / 16f;
    ((ARControl) this.lblMonth8).Width = 11f / 16f;
    ((ARControl) this.lblMonth7).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth7).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth7).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth7).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth7).Height = 0.125f;
    this.lblMonth7.HyperLink = (string) null;
    ((ARControl) this.lblMonth7).Left = 6.25f;
    ((ARControl) this.lblMonth7).Name = "lblMonth7";
    this.lblMonth7.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth7.Text = "July";
    ((ARControl) this.lblMonth7).Top = 13f / 16f;
    ((ARControl) this.lblMonth7).Width = 11f / 16f;
    ((ARControl) this.lblMonth3).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth3).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth3).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth3).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth3).Height = 0.125f;
    this.lblMonth3.HyperLink = (string) null;
    ((ARControl) this.lblMonth3).Left = 3.5f;
    ((ARControl) this.lblMonth3).Name = "lblMonth3";
    this.lblMonth3.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth3.Text = "March";
    ((ARControl) this.lblMonth3).Top = 13f / 16f;
    ((ARControl) this.lblMonth3).Width = 11f / 16f;
    ((ARControl) this.lblMonth2).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth2).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth2).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth2).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth2).Height = 0.125f;
    this.lblMonth2.HyperLink = (string) null;
    ((ARControl) this.lblMonth2).Left = 45f / 16f;
    ((ARControl) this.lblMonth2).Name = "lblMonth2";
    this.lblMonth2.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth2.Text = "February";
    ((ARControl) this.lblMonth2).Top = 13f / 16f;
    ((ARControl) this.lblMonth2).Width = 11f / 16f;
    ((ARControl) this.lblMonth1).Border.BottomColor = Color.Black;
    ((ARControl) this.lblMonth1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.lblMonth1).Border.LeftColor = Color.Black;
    ((ARControl) this.lblMonth1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth1).Border.RightColor = Color.Black;
    ((ARControl) this.lblMonth1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth1).Border.TopColor = Color.Black;
    ((ARControl) this.lblMonth1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblMonth1).Height = 0.125f;
    this.lblMonth1.HyperLink = (string) null;
    ((ARControl) this.lblMonth1).Left = 2.125f;
    ((ARControl) this.lblMonth1).Name = "lblMonth1";
    this.lblMonth1.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.lblMonth1.Text = "January";
    ((ARControl) this.lblMonth1).Top = 13f / 16f;
    ((ARControl) this.lblMonth1).Width = 11f / 16f;
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[14]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox14
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "FullName";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 9f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 25f / 16f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "JanAmount";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 2.125f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 11f / 16f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "FebAmount";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 45f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 11f / 16f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "MarAmount";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 3.5f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 11f / 16f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "AprAmount";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 67f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 11f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "MayAmount";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 4.875f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 11f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "JunAmount";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 89f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 11f / 16f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "JulAmount";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 6.25f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 11f / 16f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "AugAmount";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 111f / 16f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 11f / 16f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "SepAmount";
    ((ARControl) this.TextBox10).Height = 0.125f;
    ((ARControl) this.TextBox10).Left = 7.625f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox10.Text = (string) null;
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 11f / 16f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "OctAmount";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 133f / 16f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 11f / 16f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "NovAmount";
    ((ARControl) this.TextBox12).Height = 0.125f;
    ((ARControl) this.TextBox12).Left = 9f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox12.Text = (string) null;
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 11f / 16f;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "DecAmount";
    ((ARControl) this.TextBox13).Height = 0.125f;
    ((ARControl) this.TextBox13).Left = 155f / 16f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox13.Text = (string) null;
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Width = 11f / 16f;
    ((ARControl) this.TextBox14).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).DataField = "GLAccountNumber";
    ((ARControl) this.TextBox14).Height = 0.125f;
    ((ARControl) this.TextBox14).Left = 0.0f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.Style = "ddo-char-set: 0; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox14.Text = (string) null;
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Width = 9f / 16f;
    this.PageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtAcctClassName
    });
    this.GroupHeader1.DataField = "AcctClassName";
    this.GroupHeader1.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.txtAcctClassName).Border.BottomColor = Color.Black;
    ((ARControl) this.txtAcctClassName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctClassName).Border.LeftColor = Color.Black;
    ((ARControl) this.txtAcctClassName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctClassName).Border.RightColor = Color.Black;
    ((ARControl) this.txtAcctClassName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctClassName).Border.TopColor = Color.Black;
    ((ARControl) this.txtAcctClassName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctClassName).DataField = "AcctClassName";
    ((ARControl) this.txtAcctClassName).Height = 0.125f;
    ((ARControl) this.txtAcctClassName).Left = 0.0f;
    ((ARControl) this.txtAcctClassName).Name = "txtAcctClassName";
    this.txtAcctClassName.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: middle; ";
    this.txtAcctClassName.Text = (string) null;
    ((ARControl) this.txtAcctClassName).Top = 0.0f;
    ((ARControl) this.txtAcctClassName).Width = 109f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.TextBox27,
      (ARControl) this.TextBox28,
      (ARControl) this.TextBox29,
      (ARControl) this.TextBox30,
      (ARControl) this.TextBox31,
      (ARControl) this.TextBox32,
      (ARControl) this.TextBox33,
      (ARControl) this.TextBox34,
      (ARControl) this.TextBox35,
      (ARControl) this.TextBox36,
      (ARControl) this.TextBox37,
      (ARControl) this.TextBox38,
      (ARControl) this.txtSubTotalAcctClassName
    });
    this.GroupFooter1.Height = 0.2916667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.TextBox27).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox27).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox27).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox27).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox27).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).DataField = "JanAmount";
    ((ARControl) this.TextBox27).Height = 0.125f;
    ((ARControl) this.TextBox27).Left = 2.125f;
    ((ARControl) this.TextBox27).Name = "TextBox27";
    this.TextBox27.OutputFormat = resourceManager.GetString("TextBox27.OutputFormat");
    this.TextBox27.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox27.SummaryGroup = "GroupHeader1";
    this.TextBox27.SummaryRunning = (SummaryRunning) 1;
    this.TextBox27.SummaryType = (SummaryType) 3;
    this.TextBox27.Text = (string) null;
    ((ARControl) this.TextBox27).Top = 0.0f;
    ((ARControl) this.TextBox27).Width = 11f / 16f;
    ((ARControl) this.TextBox28).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox28).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox28).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox28).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox28).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).DataField = "FebAmount";
    ((ARControl) this.TextBox28).Height = 0.125f;
    ((ARControl) this.TextBox28).Left = 45f / 16f;
    ((ARControl) this.TextBox28).Name = "TextBox28";
    this.TextBox28.OutputFormat = resourceManager.GetString("TextBox28.OutputFormat");
    this.TextBox28.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox28.SummaryGroup = "GroupHeader1";
    this.TextBox28.SummaryRunning = (SummaryRunning) 1;
    this.TextBox28.SummaryType = (SummaryType) 3;
    this.TextBox28.Text = (string) null;
    ((ARControl) this.TextBox28).Top = 0.0f;
    ((ARControl) this.TextBox28).Width = 11f / 16f;
    ((ARControl) this.TextBox29).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox29).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox29).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox29).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox29).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).DataField = "MarAmount";
    ((ARControl) this.TextBox29).Height = 0.125f;
    ((ARControl) this.TextBox29).Left = 3.5f;
    ((ARControl) this.TextBox29).Name = "TextBox29";
    this.TextBox29.OutputFormat = resourceManager.GetString("TextBox29.OutputFormat");
    this.TextBox29.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox29.SummaryGroup = "GroupHeader1";
    this.TextBox29.SummaryRunning = (SummaryRunning) 1;
    this.TextBox29.SummaryType = (SummaryType) 3;
    this.TextBox29.Text = (string) null;
    ((ARControl) this.TextBox29).Top = 0.0f;
    ((ARControl) this.TextBox29).Width = 11f / 16f;
    ((ARControl) this.TextBox30).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox30).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox30).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox30).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox30).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).DataField = "AprAmount";
    ((ARControl) this.TextBox30).Height = 0.125f;
    ((ARControl) this.TextBox30).Left = 67f / 16f;
    ((ARControl) this.TextBox30).Name = "TextBox30";
    this.TextBox30.OutputFormat = resourceManager.GetString("TextBox30.OutputFormat");
    this.TextBox30.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox30.SummaryGroup = "GroupHeader1";
    this.TextBox30.SummaryRunning = (SummaryRunning) 1;
    this.TextBox30.SummaryType = (SummaryType) 3;
    this.TextBox30.Text = (string) null;
    ((ARControl) this.TextBox30).Top = 0.0f;
    ((ARControl) this.TextBox30).Width = 11f / 16f;
    ((ARControl) this.TextBox31).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox31).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox31).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox31).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox31).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).DataField = "MayAmount";
    ((ARControl) this.TextBox31).Height = 0.125f;
    ((ARControl) this.TextBox31).Left = 4.875f;
    ((ARControl) this.TextBox31).Name = "TextBox31";
    this.TextBox31.OutputFormat = resourceManager.GetString("TextBox31.OutputFormat");
    this.TextBox31.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox31.SummaryGroup = "GroupHeader1";
    this.TextBox31.SummaryRunning = (SummaryRunning) 1;
    this.TextBox31.SummaryType = (SummaryType) 3;
    this.TextBox31.Text = (string) null;
    ((ARControl) this.TextBox31).Top = 0.0f;
    ((ARControl) this.TextBox31).Width = 11f / 16f;
    ((ARControl) this.TextBox32).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox32).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox32).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox32).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox32).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).DataField = "JunAmount";
    ((ARControl) this.TextBox32).Height = 0.125f;
    ((ARControl) this.TextBox32).Left = 89f / 16f;
    ((ARControl) this.TextBox32).Name = "TextBox32";
    this.TextBox32.OutputFormat = resourceManager.GetString("TextBox32.OutputFormat");
    this.TextBox32.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox32.SummaryGroup = "GroupHeader1";
    this.TextBox32.SummaryRunning = (SummaryRunning) 1;
    this.TextBox32.SummaryType = (SummaryType) 3;
    this.TextBox32.Text = (string) null;
    ((ARControl) this.TextBox32).Top = 0.0f;
    ((ARControl) this.TextBox32).Width = 11f / 16f;
    ((ARControl) this.TextBox33).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox33).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox33).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox33).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox33).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox33).DataField = "JulAmount";
    ((ARControl) this.TextBox33).Height = 0.125f;
    ((ARControl) this.TextBox33).Left = 6.25f;
    ((ARControl) this.TextBox33).Name = "TextBox33";
    this.TextBox33.OutputFormat = resourceManager.GetString("TextBox33.OutputFormat");
    this.TextBox33.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox33.SummaryGroup = "GroupHeader1";
    this.TextBox33.SummaryRunning = (SummaryRunning) 1;
    this.TextBox33.SummaryType = (SummaryType) 3;
    this.TextBox33.Text = (string) null;
    ((ARControl) this.TextBox33).Top = 0.0f;
    ((ARControl) this.TextBox33).Width = 11f / 16f;
    ((ARControl) this.TextBox34).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox34).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox34).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox34).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox34).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox34).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox34).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox34).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox34).DataField = "AugAmount";
    ((ARControl) this.TextBox34).Height = 0.125f;
    ((ARControl) this.TextBox34).Left = 111f / 16f;
    ((ARControl) this.TextBox34).Name = "TextBox34";
    this.TextBox34.OutputFormat = resourceManager.GetString("TextBox34.OutputFormat");
    this.TextBox34.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox34.SummaryGroup = "GroupHeader1";
    this.TextBox34.SummaryRunning = (SummaryRunning) 1;
    this.TextBox34.SummaryType = (SummaryType) 3;
    this.TextBox34.Text = (string) null;
    ((ARControl) this.TextBox34).Top = 0.0f;
    ((ARControl) this.TextBox34).Width = 11f / 16f;
    ((ARControl) this.TextBox35).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox35).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox35).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox35).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox35).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox35).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox35).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox35).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox35).DataField = "SepAmount";
    ((ARControl) this.TextBox35).Height = 0.125f;
    ((ARControl) this.TextBox35).Left = 7.625f;
    ((ARControl) this.TextBox35).Name = "TextBox35";
    this.TextBox35.OutputFormat = resourceManager.GetString("TextBox35.OutputFormat");
    this.TextBox35.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox35.SummaryGroup = "GroupHeader1";
    this.TextBox35.SummaryRunning = (SummaryRunning) 1;
    this.TextBox35.SummaryType = (SummaryType) 3;
    this.TextBox35.Text = (string) null;
    ((ARControl) this.TextBox35).Top = 0.0f;
    ((ARControl) this.TextBox35).Width = 11f / 16f;
    ((ARControl) this.TextBox36).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox36).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox36).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox36).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox36).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox36).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox36).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox36).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox36).DataField = "OctAmount";
    ((ARControl) this.TextBox36).Height = 0.125f;
    ((ARControl) this.TextBox36).Left = 133f / 16f;
    ((ARControl) this.TextBox36).Name = "TextBox36";
    this.TextBox36.OutputFormat = resourceManager.GetString("TextBox36.OutputFormat");
    this.TextBox36.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox36.SummaryGroup = "GroupHeader1";
    this.TextBox36.SummaryRunning = (SummaryRunning) 1;
    this.TextBox36.SummaryType = (SummaryType) 3;
    this.TextBox36.Text = (string) null;
    ((ARControl) this.TextBox36).Top = 0.0f;
    ((ARControl) this.TextBox36).Width = 11f / 16f;
    ((ARControl) this.TextBox37).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox37).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox37).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox37).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox37).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox37).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox37).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox37).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox37).DataField = "NovAmount";
    ((ARControl) this.TextBox37).Height = 0.125f;
    ((ARControl) this.TextBox37).Left = 9f;
    ((ARControl) this.TextBox37).Name = "TextBox37";
    this.TextBox37.OutputFormat = resourceManager.GetString("TextBox37.OutputFormat");
    this.TextBox37.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox37.SummaryGroup = "GroupHeader1";
    this.TextBox37.SummaryRunning = (SummaryRunning) 1;
    this.TextBox37.SummaryType = (SummaryType) 3;
    this.TextBox37.Text = (string) null;
    ((ARControl) this.TextBox37).Top = 0.0f;
    ((ARControl) this.TextBox37).Width = 11f / 16f;
    ((ARControl) this.TextBox38).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox38).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox38).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox38).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox38).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox38).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox38).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox38).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox38).DataField = "DecAmount";
    ((ARControl) this.TextBox38).Height = 0.125f;
    ((ARControl) this.TextBox38).Left = 155f / 16f;
    ((ARControl) this.TextBox38).Name = "TextBox38";
    this.TextBox38.OutputFormat = resourceManager.GetString("TextBox38.OutputFormat");
    this.TextBox38.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox38.SummaryGroup = "GroupHeader1";
    this.TextBox38.SummaryRunning = (SummaryRunning) 1;
    this.TextBox38.SummaryType = (SummaryType) 3;
    this.TextBox38.Text = (string) null;
    ((ARControl) this.TextBox38).Top = 0.0f;
    ((ARControl) this.TextBox38).Width = 11f / 16f;
    ((ARControl) this.txtSubTotalAcctClassName).Border.BottomColor = Color.Black;
    ((ARControl) this.txtSubTotalAcctClassName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotalAcctClassName).Border.LeftColor = Color.Black;
    ((ARControl) this.txtSubTotalAcctClassName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotalAcctClassName).Border.RightColor = Color.Black;
    ((ARControl) this.txtSubTotalAcctClassName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotalAcctClassName).Border.TopColor = Color.Black;
    ((ARControl) this.txtSubTotalAcctClassName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotalAcctClassName).DataField = "FullName";
    ((ARControl) this.txtSubTotalAcctClassName).Height = 0.125f;
    ((ARControl) this.txtSubTotalAcctClassName).Left = 0.0f;
    ((ARControl) this.txtSubTotalAcctClassName).Name = "txtSubTotalAcctClassName";
    this.txtSubTotalAcctClassName.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: middle; ";
    this.txtSubTotalAcctClassName.Text = (string) null;
    ((ARControl) this.txtSubTotalAcctClassName).Top = 0.0f;
    ((ARControl) this.txtSubTotalAcctClassName).Width = 2.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtAcctTypeDescription
    });
    this.GroupHeader2.DataField = "AcctTypeDescription";
    this.GroupHeader2.Height = 0.1458333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2).Name = "GroupHeader2";
    ((ARControl) this.txtAcctTypeDescription).Border.BottomColor = Color.Black;
    ((ARControl) this.txtAcctTypeDescription).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctTypeDescription).Border.LeftColor = Color.Black;
    ((ARControl) this.txtAcctTypeDescription).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctTypeDescription).Border.RightColor = Color.Black;
    ((ARControl) this.txtAcctTypeDescription).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctTypeDescription).Border.TopColor = Color.Black;
    ((ARControl) this.txtAcctTypeDescription).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtAcctTypeDescription).DataField = "AcctTypeDescription";
    ((ARControl) this.txtAcctTypeDescription).Height = 0.125f;
    ((ARControl) this.txtAcctTypeDescription).Left = 0.0f;
    ((ARControl) this.txtAcctTypeDescription).Name = "txtAcctTypeDescription";
    this.txtAcctTypeDescription.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.txtAcctTypeDescription.Text = (string) null;
    ((ARControl) this.txtAcctTypeDescription).Top = 0.0f;
    ((ARControl) this.txtAcctTypeDescription).Width = 109f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox18,
      (ARControl) this.TextBox19,
      (ARControl) this.TextBox20,
      (ARControl) this.TextBox21,
      (ARControl) this.TextBox22,
      (ARControl) this.TextBox23,
      (ARControl) this.TextBox24,
      (ARControl) this.TextBox25,
      (ARControl) this.TextBox26,
      (ARControl) this.txtSubTotalAcctTypeDescription
    });
    this.GroupFooter2.Height = 0.2604167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2).Name = "GroupFooter2";
    ((ARControl) this.TextBox15).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).DataField = "JanAmount";
    ((ARControl) this.TextBox15).Height = 0.125f;
    ((ARControl) this.TextBox15).Left = 2.125f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = resourceManager.GetString("TextBox15.OutputFormat");
    this.TextBox15.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox15.SummaryGroup = "GroupHeader2";
    this.TextBox15.SummaryRunning = (SummaryRunning) 1;
    this.TextBox15.SummaryType = (SummaryType) 3;
    this.TextBox15.Text = (string) null;
    ((ARControl) this.TextBox15).Top = 0.0f;
    ((ARControl) this.TextBox15).Width = 11f / 16f;
    ((ARControl) this.TextBox16).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).DataField = "FebAmount";
    ((ARControl) this.TextBox16).Height = 0.125f;
    ((ARControl) this.TextBox16).Left = 45f / 16f;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = resourceManager.GetString("TextBox16.OutputFormat");
    this.TextBox16.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox16.SummaryGroup = "GroupHeader2";
    this.TextBox16.SummaryRunning = (SummaryRunning) 1;
    this.TextBox16.SummaryType = (SummaryType) 3;
    this.TextBox16.Text = (string) null;
    ((ARControl) this.TextBox16).Top = 0.0f;
    ((ARControl) this.TextBox16).Width = 11f / 16f;
    ((ARControl) this.TextBox17).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).DataField = "MarAmount";
    ((ARControl) this.TextBox17).Height = 0.125f;
    ((ARControl) this.TextBox17).Left = 3.5f;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = resourceManager.GetString("TextBox17.OutputFormat");
    this.TextBox17.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox17.SummaryGroup = "GroupHeader2";
    this.TextBox17.SummaryRunning = (SummaryRunning) 1;
    this.TextBox17.SummaryType = (SummaryType) 3;
    this.TextBox17.Text = (string) null;
    ((ARControl) this.TextBox17).Top = 0.0f;
    ((ARControl) this.TextBox17).Width = 11f / 16f;
    ((ARControl) this.TextBox18).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).DataField = "AprAmount";
    ((ARControl) this.TextBox18).Height = 0.125f;
    ((ARControl) this.TextBox18).Left = 67f / 16f;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = resourceManager.GetString("TextBox18.OutputFormat");
    this.TextBox18.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox18.SummaryGroup = "GroupHeader2";
    this.TextBox18.SummaryRunning = (SummaryRunning) 1;
    this.TextBox18.SummaryType = (SummaryType) 3;
    this.TextBox18.Text = (string) null;
    ((ARControl) this.TextBox18).Top = 0.0f;
    ((ARControl) this.TextBox18).Width = 11f / 16f;
    ((ARControl) this.TextBox19).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).DataField = "MayAmount";
    ((ARControl) this.TextBox19).Height = 0.125f;
    ((ARControl) this.TextBox19).Left = 4.875f;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.OutputFormat = resourceManager.GetString("TextBox19.OutputFormat");
    this.TextBox19.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox19.SummaryGroup = "GroupHeader2";
    this.TextBox19.SummaryRunning = (SummaryRunning) 1;
    this.TextBox19.SummaryType = (SummaryType) 3;
    this.TextBox19.Text = (string) null;
    ((ARControl) this.TextBox19).Top = 0.0f;
    ((ARControl) this.TextBox19).Width = 11f / 16f;
    ((ARControl) this.TextBox20).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox20).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).DataField = "JunAmount";
    ((ARControl) this.TextBox20).Height = 0.125f;
    ((ARControl) this.TextBox20).Left = 89f / 16f;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = resourceManager.GetString("TextBox20.OutputFormat");
    this.TextBox20.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox20.SummaryGroup = "GroupHeader2";
    this.TextBox20.SummaryRunning = (SummaryRunning) 1;
    this.TextBox20.SummaryType = (SummaryType) 3;
    this.TextBox20.Text = (string) null;
    ((ARControl) this.TextBox20).Top = 0.0f;
    ((ARControl) this.TextBox20).Width = 11f / 16f;
    ((ARControl) this.TextBox21).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox21).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).DataField = "JulAmount";
    ((ARControl) this.TextBox21).Height = 0.125f;
    ((ARControl) this.TextBox21).Left = 6.25f;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.OutputFormat = resourceManager.GetString("TextBox21.OutputFormat");
    this.TextBox21.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox21.SummaryGroup = "GroupHeader2";
    this.TextBox21.SummaryRunning = (SummaryRunning) 1;
    this.TextBox21.SummaryType = (SummaryType) 3;
    this.TextBox21.Text = (string) null;
    ((ARControl) this.TextBox21).Top = 0.0f;
    ((ARControl) this.TextBox21).Width = 11f / 16f;
    ((ARControl) this.TextBox22).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).DataField = "AugAmount";
    ((ARControl) this.TextBox22).Height = 0.125f;
    ((ARControl) this.TextBox22).Left = 111f / 16f;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.OutputFormat = resourceManager.GetString("TextBox22.OutputFormat");
    this.TextBox22.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox22.SummaryGroup = "GroupHeader2";
    this.TextBox22.SummaryRunning = (SummaryRunning) 1;
    this.TextBox22.SummaryType = (SummaryType) 3;
    this.TextBox22.Text = (string) null;
    ((ARControl) this.TextBox22).Top = 0.0f;
    ((ARControl) this.TextBox22).Width = 11f / 16f;
    ((ARControl) this.TextBox23).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox23).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).DataField = "SepAmount";
    ((ARControl) this.TextBox23).Height = 0.125f;
    ((ARControl) this.TextBox23).Left = 7.625f;
    ((ARControl) this.TextBox23).Name = "TextBox23";
    this.TextBox23.OutputFormat = resourceManager.GetString("TextBox23.OutputFormat");
    this.TextBox23.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox23.SummaryGroup = "GroupHeader2";
    this.TextBox23.SummaryRunning = (SummaryRunning) 1;
    this.TextBox23.SummaryType = (SummaryType) 3;
    this.TextBox23.Text = (string) null;
    ((ARControl) this.TextBox23).Top = 0.0f;
    ((ARControl) this.TextBox23).Width = 11f / 16f;
    ((ARControl) this.TextBox24).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox24).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox24).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox24).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox24).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).DataField = "OctAmount";
    ((ARControl) this.TextBox24).Height = 0.125f;
    ((ARControl) this.TextBox24).Left = 133f / 16f;
    ((ARControl) this.TextBox24).Name = "TextBox24";
    this.TextBox24.OutputFormat = resourceManager.GetString("TextBox24.OutputFormat");
    this.TextBox24.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox24.SummaryGroup = "GroupHeader2";
    this.TextBox24.SummaryRunning = (SummaryRunning) 1;
    this.TextBox24.SummaryType = (SummaryType) 3;
    this.TextBox24.Text = (string) null;
    ((ARControl) this.TextBox24).Top = 0.0f;
    ((ARControl) this.TextBox24).Width = 11f / 16f;
    ((ARControl) this.TextBox25).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox25).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox25).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox25).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox25).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).DataField = "NovAmount";
    ((ARControl) this.TextBox25).Height = 0.125f;
    ((ARControl) this.TextBox25).Left = 9f;
    ((ARControl) this.TextBox25).Name = "TextBox25";
    this.TextBox25.OutputFormat = resourceManager.GetString("TextBox25.OutputFormat");
    this.TextBox25.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox25.SummaryGroup = "GroupHeader2";
    this.TextBox25.SummaryRunning = (SummaryRunning) 1;
    this.TextBox25.SummaryType = (SummaryType) 3;
    this.TextBox25.Text = (string) null;
    ((ARControl) this.TextBox25).Top = 0.0f;
    ((ARControl) this.TextBox25).Width = 11f / 16f;
    ((ARControl) this.TextBox26).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox26).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox26).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox26).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox26).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).DataField = "DecAmount";
    ((ARControl) this.TextBox26).Height = 0.125f;
    ((ARControl) this.TextBox26).Left = 155f / 16f;
    ((ARControl) this.TextBox26).Name = "TextBox26";
    this.TextBox26.OutputFormat = resourceManager.GetString("TextBox26.OutputFormat");
    this.TextBox26.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox26.SummaryGroup = "GroupHeader2";
    this.TextBox26.SummaryRunning = (SummaryRunning) 1;
    this.TextBox26.SummaryType = (SummaryType) 3;
    this.TextBox26.Text = (string) null;
    ((ARControl) this.TextBox26).Top = 0.0f;
    ((ARControl) this.TextBox26).Width = 11f / 16f;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Border.BottomColor = Color.Black;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Border.LeftColor = Color.Black;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Border.RightColor = Color.Black;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Border.TopColor = Color.Black;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTotalAcctTypeDescription).DataField = "FullName";
    ((ARControl) this.txtSubTotalAcctTypeDescription).Height = 0.125f;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Left = 0.0f;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Name = "txtSubTotalAcctTypeDescription";
    this.txtSubTotalAcctTypeDescription.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.txtSubTotalAcctTypeDescription.Text = (string) null;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Top = 0.0f;
    ((ARControl) this.txtSubTotalAcctTypeDescription).Width = 2.125f;
    this.ReportHeader1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1).Name = "ReportHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.TextBox39,
      (ARControl) this.TextBox40,
      (ARControl) this.TextBox41,
      (ARControl) this.TextBox42,
      (ARControl) this.TextBox43,
      (ARControl) this.TextBox44,
      (ARControl) this.TextBox45,
      (ARControl) this.TextBox46,
      (ARControl) this.TextBox47,
      (ARControl) this.TextBox48,
      (ARControl) this.TextBox49,
      (ARControl) this.TextBox50,
      (ARControl) this.TextBox51
    });
    this.ReportFooter1.Height = 0.1354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1).Name = "ReportFooter1";
    ((ARControl) this.TextBox39).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox39).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox39).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox39).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox39).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox39).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox39).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox39).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox39).DataField = "JanAmount";
    ((ARControl) this.TextBox39).Height = 0.125f;
    ((ARControl) this.TextBox39).Left = 2.125f;
    ((ARControl) this.TextBox39).Name = "TextBox39";
    this.TextBox39.OutputFormat = resourceManager.GetString("TextBox39.OutputFormat");
    this.TextBox39.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox39.Text = (string) null;
    ((ARControl) this.TextBox39).Top = 0.0f;
    ((ARControl) this.TextBox39).Width = 11f / 16f;
    ((ARControl) this.TextBox40).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox40).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox40).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox40).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox40).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox40).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox40).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox40).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox40).DataField = "FebAmount";
    ((ARControl) this.TextBox40).Height = 0.125f;
    ((ARControl) this.TextBox40).Left = 45f / 16f;
    ((ARControl) this.TextBox40).Name = "TextBox40";
    this.TextBox40.OutputFormat = resourceManager.GetString("TextBox40.OutputFormat");
    this.TextBox40.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox40.Text = (string) null;
    ((ARControl) this.TextBox40).Top = 0.0f;
    ((ARControl) this.TextBox40).Width = 11f / 16f;
    ((ARControl) this.TextBox41).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox41).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox41).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox41).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox41).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox41).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox41).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox41).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox41).DataField = "MarAmount";
    ((ARControl) this.TextBox41).Height = 0.125f;
    ((ARControl) this.TextBox41).Left = 3.5f;
    ((ARControl) this.TextBox41).Name = "TextBox41";
    this.TextBox41.OutputFormat = resourceManager.GetString("TextBox41.OutputFormat");
    this.TextBox41.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox41.Text = (string) null;
    ((ARControl) this.TextBox41).Top = 0.0f;
    ((ARControl) this.TextBox41).Width = 11f / 16f;
    ((ARControl) this.TextBox42).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox42).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox42).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox42).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox42).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox42).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox42).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox42).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox42).DataField = "AprAmount";
    ((ARControl) this.TextBox42).Height = 0.125f;
    ((ARControl) this.TextBox42).Left = 67f / 16f;
    ((ARControl) this.TextBox42).Name = "TextBox42";
    this.TextBox42.OutputFormat = resourceManager.GetString("TextBox42.OutputFormat");
    this.TextBox42.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox42.Text = (string) null;
    ((ARControl) this.TextBox42).Top = 0.0f;
    ((ARControl) this.TextBox42).Width = 11f / 16f;
    ((ARControl) this.TextBox43).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox43).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox43).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox43).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox43).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox43).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox43).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox43).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox43).DataField = "MayAmount";
    ((ARControl) this.TextBox43).Height = 0.125f;
    ((ARControl) this.TextBox43).Left = 4.875f;
    ((ARControl) this.TextBox43).Name = "TextBox43";
    this.TextBox43.OutputFormat = resourceManager.GetString("TextBox43.OutputFormat");
    this.TextBox43.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox43.Text = (string) null;
    ((ARControl) this.TextBox43).Top = 0.0f;
    ((ARControl) this.TextBox43).Width = 11f / 16f;
    ((ARControl) this.TextBox44).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox44).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox44).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox44).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox44).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox44).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox44).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox44).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox44).DataField = "JunAmount";
    ((ARControl) this.TextBox44).Height = 0.125f;
    ((ARControl) this.TextBox44).Left = 89f / 16f;
    ((ARControl) this.TextBox44).Name = "TextBox44";
    this.TextBox44.OutputFormat = resourceManager.GetString("TextBox44.OutputFormat");
    this.TextBox44.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox44.Text = (string) null;
    ((ARControl) this.TextBox44).Top = 0.0f;
    ((ARControl) this.TextBox44).Width = 11f / 16f;
    ((ARControl) this.TextBox45).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox45).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox45).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox45).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox45).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox45).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox45).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox45).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox45).DataField = "JulAmount";
    ((ARControl) this.TextBox45).Height = 0.125f;
    ((ARControl) this.TextBox45).Left = 6.25f;
    ((ARControl) this.TextBox45).Name = "TextBox45";
    this.TextBox45.OutputFormat = resourceManager.GetString("TextBox45.OutputFormat");
    this.TextBox45.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox45.Text = (string) null;
    ((ARControl) this.TextBox45).Top = 0.0f;
    ((ARControl) this.TextBox45).Width = 11f / 16f;
    ((ARControl) this.TextBox46).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox46).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox46).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox46).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox46).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox46).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox46).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox46).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox46).DataField = "AugAmount";
    ((ARControl) this.TextBox46).Height = 0.125f;
    ((ARControl) this.TextBox46).Left = 111f / 16f;
    ((ARControl) this.TextBox46).Name = "TextBox46";
    this.TextBox46.OutputFormat = resourceManager.GetString("TextBox46.OutputFormat");
    this.TextBox46.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox46.Text = (string) null;
    ((ARControl) this.TextBox46).Top = 0.0f;
    ((ARControl) this.TextBox46).Width = 11f / 16f;
    ((ARControl) this.TextBox47).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox47).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox47).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox47).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox47).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox47).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox47).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox47).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox47).DataField = "SepAmount";
    ((ARControl) this.TextBox47).Height = 0.125f;
    ((ARControl) this.TextBox47).Left = 7.625f;
    ((ARControl) this.TextBox47).Name = "TextBox47";
    this.TextBox47.OutputFormat = resourceManager.GetString("TextBox47.OutputFormat");
    this.TextBox47.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox47.Text = (string) null;
    ((ARControl) this.TextBox47).Top = 0.0f;
    ((ARControl) this.TextBox47).Width = 11f / 16f;
    ((ARControl) this.TextBox48).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox48).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox48).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox48).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox48).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox48).DataField = "OctAmount";
    ((ARControl) this.TextBox48).Height = 0.125f;
    ((ARControl) this.TextBox48).Left = 133f / 16f;
    ((ARControl) this.TextBox48).Name = "TextBox48";
    this.TextBox48.OutputFormat = resourceManager.GetString("TextBox48.OutputFormat");
    this.TextBox48.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox48.Text = (string) null;
    ((ARControl) this.TextBox48).Top = 0.0f;
    ((ARControl) this.TextBox48).Width = 11f / 16f;
    ((ARControl) this.TextBox49).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox49).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox49).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox49).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox49).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox49).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox49).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox49).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox49).DataField = "NovAmount";
    ((ARControl) this.TextBox49).Height = 0.125f;
    ((ARControl) this.TextBox49).Left = 9f;
    ((ARControl) this.TextBox49).Name = "TextBox49";
    this.TextBox49.OutputFormat = resourceManager.GetString("TextBox49.OutputFormat");
    this.TextBox49.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox49.Text = (string) null;
    ((ARControl) this.TextBox49).Top = 0.0f;
    ((ARControl) this.TextBox49).Width = 11f / 16f;
    ((ARControl) this.TextBox50).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox50).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox50).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox50).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox50).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox50).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox50).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox50).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox50).DataField = "DecAmount";
    ((ARControl) this.TextBox50).Height = 0.125f;
    ((ARControl) this.TextBox50).Left = 155f / 16f;
    ((ARControl) this.TextBox50).Name = "TextBox50";
    this.TextBox50.OutputFormat = resourceManager.GetString("TextBox50.OutputFormat");
    this.TextBox50.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox50.Text = (string) null;
    ((ARControl) this.TextBox50).Top = 0.0f;
    ((ARControl) this.TextBox50).Width = 11f / 16f;
    ((ARControl) this.TextBox51).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox51).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox51).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox51).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox51).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox51).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox51).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox51).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox51).Height = 0.125f;
    ((ARControl) this.TextBox51).Left = 0.0f;
    ((ARControl) this.TextBox51).Name = "TextBox51";
    this.TextBox51.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.TextBox51.Text = "Total Liabilities and Net Worth";
    ((ARControl) this.TextBox51).Top = 0.0f;
    ((ARControl) this.TextBox51).Width = 2.125f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtClientOfficeName).EndInit();
    ((ISupportInitialize) this.txtYear).EndInit();
    ((ISupportInitialize) this.lblMonth12).EndInit();
    ((ISupportInitialize) this.lblMonth11).EndInit();
    ((ISupportInitialize) this.lblMonth10).EndInit();
    ((ISupportInitialize) this.lblMonth6).EndInit();
    ((ISupportInitialize) this.lblMonth5).EndInit();
    ((ISupportInitialize) this.lblMonth4).EndInit();
    ((ISupportInitialize) this.lblMonth9).EndInit();
    ((ISupportInitialize) this.lblMonth8).EndInit();
    ((ISupportInitialize) this.lblMonth7).EndInit();
    ((ISupportInitialize) this.lblMonth3).EndInit();
    ((ISupportInitialize) this.lblMonth2).EndInit();
    ((ISupportInitialize) this.lblMonth1).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.txtAcctClassName).EndInit();
    ((ISupportInitialize) this.TextBox27).EndInit();
    ((ISupportInitialize) this.TextBox28).EndInit();
    ((ISupportInitialize) this.TextBox29).EndInit();
    ((ISupportInitialize) this.TextBox30).EndInit();
    ((ISupportInitialize) this.TextBox31).EndInit();
    ((ISupportInitialize) this.TextBox32).EndInit();
    ((ISupportInitialize) this.TextBox33).EndInit();
    ((ISupportInitialize) this.TextBox34).EndInit();
    ((ISupportInitialize) this.TextBox35).EndInit();
    ((ISupportInitialize) this.TextBox36).EndInit();
    ((ISupportInitialize) this.TextBox37).EndInit();
    ((ISupportInitialize) this.TextBox38).EndInit();
    ((ISupportInitialize) this.txtSubTotalAcctClassName).EndInit();
    ((ISupportInitialize) this.txtAcctTypeDescription).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.TextBox23).EndInit();
    ((ISupportInitialize) this.TextBox24).EndInit();
    ((ISupportInitialize) this.TextBox25).EndInit();
    ((ISupportInitialize) this.TextBox26).EndInit();
    ((ISupportInitialize) this.txtSubTotalAcctTypeDescription).EndInit();
    ((ISupportInitialize) this.TextBox39).EndInit();
    ((ISupportInitialize) this.TextBox40).EndInit();
    ((ISupportInitialize) this.TextBox41).EndInit();
    ((ISupportInitialize) this.TextBox42).EndInit();
    ((ISupportInitialize) this.TextBox43).EndInit();
    ((ISupportInitialize) this.TextBox44).EndInit();
    ((ISupportInitialize) this.TextBox45).EndInit();
    ((ISupportInitialize) this.TextBox46).EndInit();
    ((ISupportInitialize) this.TextBox47).EndInit();
    ((ISupportInitialize) this.TextBox48).EndInit();
    ((ISupportInitialize) this.TextBox49).EndInit();
    ((ISupportInitialize) this.TextBox50).EndInit();
    ((ISupportInitialize) this.TextBox51).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private virtual PageHeader PageHeader1
  {
    get => this._PageHeader1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PageHeader1_Format);
      PageHeader pageHeader1_1 = this._PageHeader1;
      if (pageHeader1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) pageHeader1_1).Format -= eventHandler;
      this._PageHeader1 = value;
      PageHeader pageHeader1_2 = this._PageHeader1;
      if (pageHeader1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) pageHeader1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtClientOfficeName")]
  internal virtual TextBox txtClientOfficeName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtYear")]
  internal virtual TextBox txtYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth12")]
  internal virtual Label lblMonth12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth11")]
  internal virtual Label lblMonth11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth10")]
  internal virtual Label lblMonth10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth6")]
  internal virtual Label lblMonth6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth5")]
  internal virtual Label lblMonth5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth4")]
  internal virtual Label lblMonth4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth9")]
  internal virtual Label lblMonth9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth8")]
  internal virtual Label lblMonth8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth7")]
  internal virtual Label lblMonth7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth3")]
  internal virtual Label lblMonth3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth2")]
  internal virtual Label lblMonth2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblMonth1")]
  internal virtual Label lblMonth1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  internal virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAcctClassName")]
  internal virtual TextBox txtAcctClassName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual GroupFooter GroupFooter1
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

  [field: AccessedThroughProperty("GroupHeader2")]
  internal virtual GroupHeader GroupHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAcctTypeDescription")]
  internal virtual TextBox txtAcctTypeDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual GroupFooter GroupFooter2
  {
    get => this._GroupFooter2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupFooter2_Format);
      GroupFooter groupFooter2_1 = this._GroupFooter2;
      if (groupFooter2_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) groupFooter2_1).Format -= eventHandler;
      this._GroupFooter2 = value;
      GroupFooter groupFooter2_2 = this._GroupFooter2;
      if (groupFooter2_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) groupFooter2_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  internal virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  internal virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  internal virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  internal virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  internal virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  internal virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  internal virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox13")]
  internal virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox14")]
  internal virtual TextBox TextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox15")]
  internal virtual TextBox TextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox16")]
  internal virtual TextBox TextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox17")]
  internal virtual TextBox TextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox18")]
  internal virtual TextBox TextBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox19")]
  internal virtual TextBox TextBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox20")]
  internal virtual TextBox TextBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox21")]
  internal virtual TextBox TextBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox22")]
  internal virtual TextBox TextBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox23")]
  internal virtual TextBox TextBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox24")]
  internal virtual TextBox TextBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox25")]
  internal virtual TextBox TextBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox26")]
  internal virtual TextBox TextBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSubTotalAcctTypeDescription")]
  internal virtual TextBox txtSubTotalAcctTypeDescription { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox27")]
  internal virtual TextBox TextBox27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox28")]
  internal virtual TextBox TextBox28 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox29")]
  internal virtual TextBox TextBox29 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox30")]
  internal virtual TextBox TextBox30 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox31")]
  internal virtual TextBox TextBox31 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox32")]
  internal virtual TextBox TextBox32 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox33")]
  internal virtual TextBox TextBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox34")]
  internal virtual TextBox TextBox34 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox35")]
  internal virtual TextBox TextBox35 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox36")]
  internal virtual TextBox TextBox36 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox37")]
  internal virtual TextBox TextBox37 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox38")]
  internal virtual TextBox TextBox38 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSubTotalAcctClassName")]
  internal virtual TextBox txtSubTotalAcctClassName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual ReportHeader ReportHeader1
  {
    get => this._ReportHeader1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportHeader1_Format);
      ReportHeader reportHeader1_1 = this._ReportHeader1;
      if (reportHeader1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportHeader1_1).Format -= eventHandler;
      this._ReportHeader1 = value;
      ReportHeader reportHeader1_2 = this._ReportHeader1;
      if (reportHeader1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportHeader1_2).Format += eventHandler;
    }
  }

  internal virtual ReportFooter ReportFooter1
  {
    get => this._ReportFooter1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportFooter1_Format);
      ReportFooter reportFooter1_1 = this._ReportFooter1;
      if (reportFooter1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter1_1).Format -= eventHandler;
      this._ReportFooter1 = value;
      ReportFooter reportFooter1_2 = this._ReportFooter1;
      if (reportFooter1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("TextBox39")]
  internal virtual TextBox TextBox39 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox40")]
  internal virtual TextBox TextBox40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox41")]
  internal virtual TextBox TextBox41 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox42")]
  internal virtual TextBox TextBox42 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox43")]
  internal virtual TextBox TextBox43 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox44")]
  internal virtual TextBox TextBox44 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox45")]
  internal virtual TextBox TextBox45 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox46")]
  internal virtual TextBox TextBox46 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox47")]
  internal virtual TextBox TextBox47 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox48")]
  internal virtual TextBox TextBox48 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox49")]
  internal virtual TextBox TextBox49 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox50")]
  internal virtual TextBox TextBox50 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox51")]
  internal virtual TextBox TextBox51 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public Financials_BalanceSheetYearReport()
  {
    this.ReportStart += new EventHandler(this.Financials_BalanceSheetYearReport_ReportStart);
    this.InitializeComponent();
  }

  public Financials_BalanceSheetYearReport(int priorTo, int glCompanyID)
  {
    this.ReportStart += new EventHandler(this.Financials_BalanceSheetYearReport_ReportStart);
    this.InitializeComponent();
    this._priorTo = priorTo;
    this._gLCompanyID = glCompanyID;
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      ArrayList arrayList = new ArrayList();
      arrayList.Add((object) DateTime.Now.Year);
      arrayList.Add((object) DateTime.Now.Year);
      DateTime now1 = DateTime.Now;
      int num1 = checked (now1.Year - 10);
      now1 = DateTime.Now;
      int num2 = checked (now1.Year - 1);
      int num3 = num1;
      while (num3 <= num2)
      {
        arrayList.Add((object) num3);
        arrayList.Add((object) num3);
        checked { ++num3; }
      }
      DateTime now2 = DateTime.Now;
      int num4 = checked (now2.Year + 1);
      now2 = DateTime.Now;
      int num5 = checked (now2.Year + 10);
      int num6 = num4;
      while (num6 <= num5)
      {
        arrayList.Add((object) num6);
        arrayList.Add((object) num6);
        checked { ++num6; }
      }
      return new BaseReportControl[2]
      {
        (BaseReportControl) new GenericComboBox("Fiscal Year", 100, 100, typeof (int), arrayList.ToArray()),
        (BaseReportControl) new AccountingOfficeLocations("Office Location", false, true)
      };
    }
  }

  private void Financials_BalanceSheetYearReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    ArrayList arrayList = new ArrayList();
    this._ds = new DataSet();
    arrayList.Add((object) "@PriorTo");
    arrayList.Add((object) ("01/01/" + this._priorTo.ToString()));
    arrayList.Add((object) "@glCompanyID");
    arrayList.Add((object) this._gLCompanyID);
    this._ds = this.ReportDatabase.ExecuteDataSet(CommandType.StoredProcedure, "spFin_rptFinancials_BalanceSheetYear", 9999, (CommandArgumentType) 0, arrayList.ToArray());
    this.DataSource = (object) this._ds.Tables[0];
  }

  private void ReportHeader1_Format(object sender, EventArgs e)
  {
    this.txtYear.Value = (object) $"Fiscal Year {this._priorTo}";
    if (this._ds.Tables[1].Rows.Count <= 0)
      return;
    this.txtClientOfficeName.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[1].Rows[0]["Location"]);
  }

  private void GroupFooter1_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.txtSubTotalAcctClassName.Value = (object) $"Total {RuntimeHelpers.GetObjectValue(this.txtAcctClassName.Value)}";
  }

  private void GroupFooter2_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.txtSubTotalAcctTypeDescription.Value = (object) $"Sub-Total {RuntimeHelpers.GetObjectValue(this.txtAcctTypeDescription.Value)}";
  }

  private void ReportFooter1_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.TextBox39.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(JanAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox40.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(FebAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox41.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(MarAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox42.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(AprAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox43.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(MayAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox44.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(JunAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox45.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(JulAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox46.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(AugAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox47.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(SepAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox48.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(OctAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox49.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(NovAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
    this.TextBox50.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Compute("SUM(DecAmount)", "AcctClassName IN ('Liabilities', 'Equity')"));
  }

  private void PageHeader1_Format(object sender, EventArgs e)
  {
    this.lblMonth1.Value = (object) this._ds.Tables[2].Rows[0]["MONTH1"].ToString();
    this.lblMonth2.Value = (object) this._ds.Tables[2].Rows[0]["MONTH2"].ToString();
    this.lblMonth3.Value = (object) this._ds.Tables[2].Rows[0]["MONTH3"].ToString();
    this.lblMonth4.Value = (object) this._ds.Tables[2].Rows[0]["MONTH4"].ToString();
    this.lblMonth5.Value = (object) this._ds.Tables[2].Rows[0]["MONTH5"].ToString();
    this.lblMonth6.Value = (object) this._ds.Tables[2].Rows[0]["MONTH6"].ToString();
    this.lblMonth7.Value = (object) this._ds.Tables[2].Rows[0]["MONTH7"].ToString();
    this.lblMonth8.Value = (object) this._ds.Tables[2].Rows[0]["MONTH8"].ToString();
    this.lblMonth9.Value = (object) this._ds.Tables[2].Rows[0]["MONTH9"].ToString();
    this.lblMonth10.Value = (object) this._ds.Tables[2].Rows[0]["MONTH10"].ToString();
    this.lblMonth11.Value = (object) this._ds.Tables[2].Rows[0]["MONTH11"].ToString();
    this.lblMonth12.Value = (object) this._ds.Tables[2].Rows[0]["MONTH12"].ToString();
  }

  public override bool IsThreaded => true;

  public Database ReportDatabase
  {
    get => this._reportDatabase;
    set => this._reportDatabase = value;
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    DataTable source = this._ds.Tables[0].Copy();
    source.Columns.Remove("OrderMaster");
    source.Columns.Remove("AcctTypeID");
    source.Columns.Remove("GLAcctId");
    source.Columns.Remove("RollUpTo");
    source.Columns.Remove("ControlAcct");
    source.Columns.Remove("Grouping");
    source.Columns.Remove("ApplyGrouping");
    ExcelExport.ToExcel(source, SaveFileTo);
    source.Dispose();
  }
}
