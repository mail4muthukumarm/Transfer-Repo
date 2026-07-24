// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptVendorHistoryReport
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

public class rptVendorHistoryReport : MGAReport, IReport
{
  private Guid _EntityGuid;
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private DataSet _ds;
  private Label Label;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Line Line;
  private TextBox TextBox_poNum;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptVendorHistoryReport));
    this.Detail = new Detail();
    this.TextBox_poNum = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.srCheckNum = new SubReport();
    this.PageHeader = new PageHeader();
    this.Label = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Line = new Line();
    this.txtDateRange = new TextBox();
    this.txtVenodr = new TextBox();
    this.Label6 = new Label();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    ((ISupportInitialize) this.TextBox_poNum).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtDateRange).BeginInit();
    ((ISupportInitialize) this.txtVenodr).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.TextBox_poNum,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.srCheckNum
    });
    ((Section) this.Detail).Height = 0.3333333f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox_poNum).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox_poNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox_poNum).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox_poNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox_poNum).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox_poNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox_poNum).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox_poNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox_poNum).DataField = "PoNum";
    ((ARControl) this.TextBox_poNum).Height = 0.125f;
    ((ARControl) this.TextBox_poNum).Left = 0.0f;
    ((ARControl) this.TextBox_poNum).Name = "TextBox_poNum";
    this.TextBox_poNum.Style = "ddo-char-set: 0; ";
    this.TextBox_poNum.Text = (string) null;
    ((ARControl) this.TextBox_poNum).Top = 0.0f;
    ((ARControl) this.TextBox_poNum).Width = 19f / 16f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "PoDate";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 19f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "ddo-char-set: 0; ";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 15f / 16f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "payeeInvNum";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 2.125f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 1f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "Comments";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 3.125f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 2.5f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "Payments";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 5.625f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "ddo-char-set: 0; ";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 19f / 16f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "Amount";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 109f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 1f;
    ((ARControl) this.srCheckNum).Border.BottomColor = Color.Black;
    ((ARControl) this.srCheckNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.srCheckNum).Border.LeftColor = Color.Black;
    ((ARControl) this.srCheckNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.srCheckNum).Border.RightColor = Color.Black;
    ((ARControl) this.srCheckNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.srCheckNum).Border.TopColor = Color.Black;
    ((ARControl) this.srCheckNum).Border.TopStyle = (BorderLineStyle) 0;
    this.srCheckNum.CloseBorder = false;
    ((ARControl) this.srCheckNum).Height = 3f / 16f;
    ((ARControl) this.srCheckNum).Left = 4.375f;
    ((ARControl) this.srCheckNum).Name = "srCheckNum";
    this.srCheckNum.Report = (SectionReport) null;
    this.srCheckNum.ReportName = "SubReport1";
    ((ARControl) this.srCheckNum).Top = 0.125f;
    ((ARControl) this.srCheckNum).Width = 3f;
    ((Section) this.PageHeader).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Line,
      (ARControl) this.txtDateRange,
      (ARControl) this.txtVenodr,
      (ARControl) this.Label6
    });
    this.PageHeader.Height = 37f / 32f;
    ((Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label).Border.BottomColor = Color.Black;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftColor = Color.Black;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightColor = Color.Black;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopColor = Color.Black;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label.Text = "Purchase Order #";
    ((ARControl) this.Label).Top = 15f / 16f;
    ((ARControl) this.Label).Width = 19f / 16f;
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 19f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label1.Text = "PO Date";
    ((ARControl) this.Label1).Top = 15f / 16f;
    ((ARControl) this.Label1).Width = 0.9270833f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 2.125f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label2.Text = "Invoice #";
    ((ARControl) this.Label2).Top = 15f / 16f;
    ((ARControl) this.Label2).Width = 1f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 3.125f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label3.Text = "Comments";
    ((ARControl) this.Label3).Top = 15f / 16f;
    ((ARControl) this.Label3).Width = 2.5f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 109f / 16f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label4.Text = "Amount";
    ((ARControl) this.Label4).Top = 15f / 16f;
    ((ARControl) this.Label4).Width = 1f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 5.625f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label5.Text = "Payments";
    ((ARControl) this.Label5).Top = 15f / 16f;
    ((ARControl) this.Label5).Width = 19f / 16f;
    this.Line.Border.BottomColor = Color.Black;
    this.Line.Border.BottomStyle = (BorderLineStyle) 0;
    this.Line.Border.LeftColor = Color.Black;
    this.Line.Border.LeftStyle = (BorderLineStyle) 0;
    this.Line.Border.RightColor = Color.Black;
    this.Line.Border.RightStyle = (BorderLineStyle) 0;
    this.Line.Border.TopColor = Color.Black;
    this.Line.Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line).Height = 0.0f;
    ((ARControl) this.Line).Left = 0.0f;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    ((ARControl) this.Line).Top = 1.125f;
    ((ARControl) this.Line).Width = 7.875f;
    this.Line.X1 = 0.0f;
    this.Line.X2 = 7.875f;
    this.Line.Y1 = 1.125f;
    this.Line.Y2 = 1.125f;
    ((ARControl) this.txtDateRange).Border.BottomColor = Color.Black;
    ((ARControl) this.txtDateRange).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.LeftColor = Color.Black;
    ((ARControl) this.txtDateRange).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.RightColor = Color.Black;
    ((ARControl) this.txtDateRange).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.TopColor = Color.Black;
    ((ARControl) this.txtDateRange).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Height = 0.2f;
    ((ARControl) this.txtDateRange).Left = 41f / 16f;
    ((ARControl) this.txtDateRange).Name = "txtDateRange";
    this.txtDateRange.Style = "ddo-char-set: 0; text-align: center; font-size: 9.75pt; ";
    this.txtDateRange.Text = "From {0} To {1}";
    ((ARControl) this.txtDateRange).Top = 0.5f;
    ((ARControl) this.txtDateRange).Width = 35f / 16f;
    ((ARControl) this.txtVenodr).Border.BottomColor = Color.Black;
    ((ARControl) this.txtVenodr).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtVenodr).Border.LeftColor = Color.Black;
    ((ARControl) this.txtVenodr).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtVenodr).Border.RightColor = Color.Black;
    ((ARControl) this.txtVenodr).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtVenodr).Border.TopColor = Color.Black;
    ((ARControl) this.txtVenodr).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtVenodr).Height = 0.2f;
    ((ARControl) this.txtVenodr).Left = 1.75f;
    ((ARControl) this.txtVenodr).Name = "txtVenodr";
    this.txtVenodr.Style = "ddo-char-set: 0; text-align: center; font-size: 9.75pt; ";
    this.txtVenodr.Text = "{Vendor Name}";
    ((ARControl) this.txtVenodr).Top = 5f / 16f;
    ((ARControl) this.txtVenodr).Width = 3.75f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 0.25f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 2.625f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 14.25pt; ";
    this.Label6.Text = "Vendor History";
    ((ARControl) this.Label6).Top = 1f / 16f;
    ((ARControl) this.Label6).Width = 2f;
    this.PageFooter.Height = 0.0f;
    ((Section) this.PageFooter).Name = "PageFooter";
    this.GroupHeader1.Height = 0.0f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    ((Section) this.GroupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7
    });
    this.GroupFooter1.Height = 0.25f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "Amount";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 109f / 16f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox6.SummaryGroup = "GroupHeader1";
    this.TextBox6.SummaryRunning = (SummaryRunning) 2;
    this.TextBox6.SummaryType = (SummaryType) 1;
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 1f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 4.5f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-size: 9.75pt; vertical-align: middle; ";
    this.TextBox7.Text = "Total: ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 35f / 16f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 251f / 32f;
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.GroupFooter1);
    this.Sections.Add((Section) this.PageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox_poNum).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtDateRange).EndInit();
    ((ISupportInitialize) this.txtVenodr).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public rptVendorHistoryReport()
  {
    this.ReportStart += new EventHandler(this.rptUnAccountedDetail_ReportStart);
  }

  public rptVendorHistoryReport(Guid entityguid, DateTime dateFrom, DateTime dateTo)
  {
    this.ReportStart += new EventHandler(this.rptUnAccountedDetail_ReportStart);
    this.InitializeComponent();
    this._EntityGuid = entityguid;
    this._DateFrom = dateFrom;
    this._DateTo = dateTo;
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new EntitySelection("Company", true, false),
        (BaseReportControl) new DateRangePicker("Date Range", false)
      };
    }
  }

  private void rptUnAccountedDetail_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.ShowPageNumbers();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
    this._ds = new DataSet();
    try
    {
      sqlDataAdapter.SelectCommand = new SqlCommand("spFin_rptGetVendorHistory", new SqlConnection(CurrentUser.Instance.ConnectionString));
      sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@entityGuid", (object) this._EntityGuid);
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@dateTo", (object) this._DateTo);
      sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@dateFrom", (object) this._DateFrom);
      sqlDataAdapter.Fill(this._ds);
      if (this._ds.Tables.Count > 0)
        this.DataSource = (object) this._ds.Tables[0];
      if (this._ds.Tables.Count > 1 && this._ds.Tables[1].Rows.Count > 0)
        this.txtVenodr.Text = this._ds.Tables[1].Rows[0][0].ToString();
      this.txtDateRange.Text = $"{this._DateFrom.ToString("d")}  To  {this._DateTo.ToString("d")}";
    }
    finally
    {
      sqlDataAdapter.SelectCommand.Connection.Dispose();
      sqlDataAdapter.SelectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  public override bool IsThreaded => true;

  private void ReportHeader_Format(object sender, EventArgs e)
  {
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this._ds.Tables.Count > 1 && this._ds.Tables[0].Rows.Count > 0)
    {
      DataView dv = new DataView(this._ds.Tables[2], $"poNum={RuntimeHelpers.GetObjectValue(this.TextBox_poNum.Value)}", "CheckNum", DataViewRowState.CurrentRows);
      if (dv.Count <= 0)
        return;
      ((ARControl) this.srCheckNum).Visible = true;
      this.srCheckNum.Report = (SectionReport) new rptVendorHistoryReport_detail(dv);
    }
    else
    {
      ((ARControl) this.srCheckNum).Visible = false;
      ((ARControl) this.srCheckNum).Height = 0.0f;
    }
  }

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    rptJournalTransaction rpt = new rptJournalTransaction(Conversions.ToInteger(e.HyperLink));
    rpt.Run();
    rpt.Document.Name = $"Journal Transaction - {e.HyperLink}";
    ReportFactory.Instance.ShowReport((SectionReport) rpt);
  }

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
        ((Section) detail1).Format -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("srCheckNum")]
  internal virtual SubReport srCheckNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDateRange")]
  private virtual TextBox txtDateRange { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtVenodr")]
  private virtual TextBox txtVenodr { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  internal virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  internal virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
