// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptProducerHitRatio
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
[SecureReportResource("{426B2205-CD07-4217-901D-11DE2ED8F5AD}", "Producer Hit Ratio", "Shows premiums, submissions, quotes, binders and ratios on per quoting location.", "General")]
public class rptProducerHitRatio : MGAReport, IReport
{
  private Guid _producerLocationID;
  private string _businessType;
  private DateTime _dateFrom;
  private DateTime _dateTo;
  private DataTable _dt;
  private DataSet _ds;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptProducerHitRatio));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.txtDates = new TextBox();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
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
    this.ReportInfo1 = new ReportInfo();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtDates).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
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
    ((ISupportInitialize) this.ReportInfo1).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[16 /*0x10*/]
    {
      (ARControl) this.Label1,
      (ARControl) this.txtDates,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15
    });
    this.PageHeader1.Height = 23f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 0.375f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.125f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; text-align: center; font-size: 20.25pt; ";
    this.Label1.Text = "Producer Hit Ratio Report";
    ((ARControl) this.Label1).Top = 1f / 16f;
    ((ARControl) this.Label1).Width = 9.75f;
    ((ARControl) this.txtDates).Border.BottomColor = Color.Black;
    ((ARControl) this.txtDates).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDates).Border.LeftColor = Color.Black;
    ((ARControl) this.txtDates).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDates).Border.RightColor = Color.Black;
    ((ARControl) this.txtDates).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDates).Border.TopColor = Color.Black;
    ((ARControl) this.txtDates).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDates).Height = 0.25f;
    ((ARControl) this.txtDates).Left = 0.125f;
    ((ARControl) this.txtDates).Name = "txtDates";
    this.txtDates.Style = "text-align: center; ";
    this.txtDates.Text = (string) null;
    ((ARControl) this.txtDates).Top = 0.5f;
    ((ARControl) this.txtDates).Width = 9.75f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 5f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 1f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label2.Text = "Premium";
    ((ARControl) this.Label2).Top = 1.125f;
    ((ARControl) this.Label2).Width = 0.75f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 5f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 13f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label3.Text = "Quoted Premium";
    ((ARControl) this.Label3).Top = 1.125f;
    ((ARControl) this.Label3).Width = 0.75f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 5f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 25f / 16f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label4.Text = "    Producer Name";
    ((ARControl) this.Label4).Top = 1.125f;
    ((ARControl) this.Label4).Width = 2.375f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 5f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 63f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label5.Text = "Submitted";
    ((ARControl) this.Label5).Top = 1.125f;
    ((ARControl) this.Label5).Width = 11f / 16f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 5f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 4.625f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label6.Text = "Quoted";
    ((ARControl) this.Label6).Top = 1.125f;
    ((ARControl) this.Label6).Width = 0.5f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 5f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 5.125f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label7.Text = "Bound";
    ((ARControl) this.Label7).Top = 1.125f;
    ((ARControl) this.Label7).Width = 7f / 16f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Height = 5f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 89f / 16f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label8.Text = "Declined";
    ((ARControl) this.Label8).Top = 1.125f;
    ((ARControl) this.Label8).Width = 9f / 16f;
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 5f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 6.125f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label9.Text = "Lost";
    ((ARControl) this.Label9).Top = 1.125f;
    ((ARControl) this.Label9).Width = 5f / 16f;
    ((ARControl) this.Label10).Border.BottomColor = Color.Black;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.LeftColor = Color.Black;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightColor = Color.Black;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopColor = Color.Black;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Height = 5f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 103f / 16f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label10.Text = "Grand Total";
    ((ARControl) this.Label10).Top = 1.125f;
    ((ARControl) this.Label10).Width = 7f / 16f;
    ((ARControl) this.Label11).Border.BottomColor = Color.Black;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.LeftColor = Color.Black;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightColor = Color.Black;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopColor = Color.Black;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Height = 5f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 6.875f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label11.Text = "Total Quoted";
    ((ARControl) this.Label11).Top = 1.125f;
    ((ARControl) this.Label11).Width = 9f / 16f;
    ((ARControl) this.Label12).Border.BottomColor = Color.Black;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Border.LeftColor = Color.Black;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightColor = Color.Black;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopColor = Color.Black;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Height = 5f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 119f / 16f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label12.Text = "Quote Ratio";
    ((ARControl) this.Label12).Top = 1.125f;
    ((ARControl) this.Label12).Width = 9f / 16f;
    ((ARControl) this.Label13).Border.BottomColor = Color.Black;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.LeftColor = Color.Black;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightColor = Color.Black;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopColor = Color.Black;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Height = 5f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 8f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label13.Text = "Bound Ratio";
    ((ARControl) this.Label13).Top = 1.125f;
    ((ARControl) this.Label13).Width = 9f / 16f;
    ((ARControl) this.Label14).Border.BottomColor = Color.Black;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.LeftColor = Color.Black;
    ((ARControl) this.Label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.RightColor = Color.Black;
    ((ARControl) this.Label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Border.TopColor = Color.Black;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label14).Height = 5f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 137f / 16f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label14.Text = "Declination Ratio";
    ((ARControl) this.Label14).Top = 1.125f;
    ((ARControl) this.Label14).Width = 0.75f;
    ((ARControl) this.Label15).Border.BottomColor = Color.Black;
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Border.LeftColor = Color.Black;
    ((ARControl) this.Label15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.RightColor = Color.Black;
    ((ARControl) this.Label15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Border.TopColor = Color.Black;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label15).Height = 5f / 16f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 149f / 16f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label15.Text = "Business Type";
    ((ARControl) this.Label15).Top = 1.125f;
    ((ARControl) this.Label15).Width = 0.75f;
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
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Premium";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 1f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.75f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "QuotedPremium";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 13f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.75f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "ProducerName";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 27f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; font-family: Arial Narrow; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 2.25f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "Submitted";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 63f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; ";
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
    ((ARControl) this.TextBox5).DataField = "quoted";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 4.625f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.5f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "bound";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 5.125f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; ";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 7f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "declined";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 89f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; ";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 9f / 16f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "lost";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 6.125f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; ";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 5f / 16f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "Grandtotal";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 103f / 16f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; ";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 7f / 16f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "TotalQuoted";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 6.875f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; ";
    this.TextBox10.Text = (string) null;
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 9f / 16f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "QuoteRatio";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 119f / 16f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; ";
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 9f / 16f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "BoundRatio";
    ((ARControl) this.TextBox12).Height = 3f / 16f;
    ((ARControl) this.TextBox12).Left = 8f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; ";
    this.TextBox12.Text = (string) null;
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 9f / 16f;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "DeclinationRatio";
    ((ARControl) this.TextBox13).Height = 3f / 16f;
    ((ARControl) this.TextBox13).Left = 137f / 16f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; ";
    this.TextBox13.Text = (string) null;
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Width = 0.75f;
    ((ARControl) this.TextBox14).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).DataField = "BusinessType";
    ((ARControl) this.TextBox14).Height = 3f / 16f;
    ((ARControl) this.TextBox14).Left = 149f / 16f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.Style = "ddo-char-set: 0; text-align: left; font-size: 8.25pt; ";
    this.TextBox14.Text = (string) null;
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Width = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.ReportInfo1
    });
    this.PageFooter1.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((ARControl) this.ReportInfo1).Border.BottomColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.ReportInfo1).Border.LeftColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.ReportInfo1).Border.RightColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.ReportInfo1).Border.TopColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.TopStyle = (BorderLineStyle) 0;
    this.ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
    ((ARControl) this.ReportInfo1).Height = 3f / 16f;
    ((ARControl) this.ReportInfo1).Left = 125f / 16f;
    ((ARControl) this.ReportInfo1).Name = "ReportInfo1";
    this.ReportInfo1.Style = "";
    ((ARControl) this.ReportInfo1).Top = 1f / 16f;
    ((ARControl) this.ReportInfo1).Width = 2.375f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.25f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtDates).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
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
    ((ISupportInitialize) this.ReportInfo1).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDates")]
  internal virtual TextBox txtDates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  internal virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  internal virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  internal virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("ReportInfo1")]
  internal virtual ReportInfo ReportInfo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptProducerHitRatio()
  {
    this.ReportStart += new EventHandler(this.rptHitRatio_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
  }

  public rptProducerHitRatio(
    Guid ProducerLocationsID,
    string BusinessType,
    DateTime DateFrom,
    DateTime DateTo)
  {
    this.ReportStart += new EventHandler(this.rptHitRatio_ReportStart);
    this._ds = new DataSet();
    this.InitializeComponent();
    this._businessType = BusinessType;
    this._producerLocationID = ProducerLocationsID;
    this._dateFrom = DateFrom;
    this._dateTo = DateTo;
  }

  private void rptHitRatio_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    Conversions.ToBoolean(this._businessType);
    DbConnection dbConnection = DefaultDatabase.CreateDbConnection();
    DbCommand command = DefaultDatabase.CreateCommand("ProducerHitRatioReport", dbConnection);
    DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter(command);
    command.CommandTimeout = 0;
    command.CommandType = CommandType.StoredProcedure;
    command.Parameters.Clear();
    DbParameterCollectionExtensions.DerivedAdd(command.Parameters, "@DateFrom", SqlDbType.DateTime);
    DbParameterCollectionExtensions.DerivedAdd(command.Parameters, "@DateTo", SqlDbType.DateTime);
    DbParameterCollectionExtensions.DerivedAdd(command.Parameters, "@BusinessType", SqlDbType.Bit);
    DbParameterCollectionExtensions.DerivedAdd(command.Parameters, "@ProducerLocationID", SqlDbType.VarChar, 8000);
    command.Parameters["@DateFrom"].Value = (object) this._dateFrom;
    command.Parameters["@DateTo"].Value = (object) this._dateTo;
    command.Parameters["@BusinessType"].Value = (object) Conversions.ToBoolean(this._businessType);
    command.Parameters["@ProducerLocationID"].Value = (object) this._producerLocationID.ToString();
    if (SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid") && !this.CurrentUserGuid.Equals((object) string.Empty))
      DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@CurrentUserGuid", (object) this.CurrentUserGuid);
    using (dbConnection)
    {
      using (command)
      {
        using (dataAdapter)
        {
          try
          {
            dataAdapter.Fill(this._ds);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
            ProjectData.ClearProjectError();
          }
        }
      }
    }
    this.DataSource = (object) this._ds.Tables[0];
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new ProducerLocations("Producer Location", true),
        (BaseReportControl) new GenericComboBox("Business Type", 100, 150, typeof (string), (object[]) new string[4]
        {
          "New",
          "0",
          "Old",
          "1"
        }),
        (BaseReportControl) new DateRangePicker("Dates", false)
      };
    }
  }
}
