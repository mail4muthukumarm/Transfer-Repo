// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rpt1099Detail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[DesignerGenerated]
[SecureReportResource("{B8A2CA3E-5A4A-47e9-ACA8-404A24C9B882}", "1099 Detail", "1099 Detail", "Accounting")]
public class rpt1099Detail : MGAReport, IReport
{
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private Guid _EntityGUID;
  private DataView _dv;
  private SqlConnection _connection;
  private SqlCommand _command;
  private DataSet _ds;
  private SqlDataAdapter _da;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail1
  {
    get => this._Detail1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail1_BeforePrint);
      Detail detail1_1 = this._Detail1;
      if (detail1_1 != null)
        ((Section) detail1_1).BeforePrint -= eventHandler;
      this._Detail1 = value;
      Detail detail1_2 = this._Detail1;
      if (detail1_2 == null)
        return;
      ((Section) detail1_2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rpt1099Detail));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.lblHeader2 = new Label();
    this.lblHeader3 = new Label();
    this.Detail1 = new Detail();
    this.txtTransactionNum = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.PageFooter1 = new PageFooter();
    this.ReportInfo1 = new ReportInfo();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.TextBox5 = new TextBox();
    this.Label6 = new Label();
    this.Line1 = new Line();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.lblHeader2).BeginInit();
    ((ISupportInitialize) this.lblHeader3).BeginInit();
    ((ISupportInitialize) this.txtTransactionNum).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.ReportInfo1).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.PageHeader1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.lblHeader2,
      (ARControl) this.lblHeader3
    });
    this.PageHeader1.Height = 1.375f;
    ((Section) this.PageHeader1).Name = "PageHeader1";
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
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 24pt; ";
    this.Label1.Text = "1099 Detail";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 7.875f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 5f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.0f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9.75pt; ";
    this.Label2.Text = "Transaction Number";
    ((ARControl) this.Label2).Top = 1f;
    ((ARControl) this.Label2).Width = 1f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 5f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 2.375f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9.75pt; vertical-align: bottom; ";
    this.Label3.Text = "Check Date";
    ((ARControl) this.Label3).Top = 1f;
    ((ARControl) this.Label3).Width = 1f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 5f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 75f / 16f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9.75pt; vertical-align: bottom; ";
    this.Label4.Text = "Check Number";
    ((ARControl) this.Label4).Top = 1f;
    ((ARControl) this.Label4).Width = 1f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 5f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 6.875f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; vertical-align: bottom; ";
    this.Label5.Text = "Check Amount";
    ((ARControl) this.Label5).Top = 1f;
    ((ARControl) this.Label5).Width = 1f;
    ((ARControl) this.lblHeader2).Border.BottomColor = Color.Black;
    ((ARControl) this.lblHeader2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader2).Border.LeftColor = Color.Black;
    ((ARControl) this.lblHeader2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader2).Border.RightColor = Color.Black;
    ((ARControl) this.lblHeader2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader2).Border.TopColor = Color.Black;
    ((ARControl) this.lblHeader2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader2).Height = 3f / 16f;
    this.lblHeader2.HyperLink = (string) null;
    ((ARControl) this.lblHeader2).Left = 0.0f;
    ((ARControl) this.lblHeader2).Name = "lblHeader2";
    this.lblHeader2.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 11.25pt; ";
    this.lblHeader2.Text = "";
    ((ARControl) this.lblHeader2).Top = 0.375f;
    ((ARControl) this.lblHeader2).Width = 7.875f;
    ((ARControl) this.lblHeader3).Border.BottomColor = Color.Black;
    ((ARControl) this.lblHeader3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader3).Border.LeftColor = Color.Black;
    ((ARControl) this.lblHeader3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader3).Border.RightColor = Color.Black;
    ((ARControl) this.lblHeader3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader3).Border.TopColor = Color.Black;
    ((ARControl) this.lblHeader3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblHeader3).Height = 3f / 16f;
    this.lblHeader3.HyperLink = (string) null;
    ((ARControl) this.lblHeader3).Left = 0.0f;
    ((ARControl) this.lblHeader3).Name = "lblHeader3";
    this.lblHeader3.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 11.25pt; ";
    this.lblHeader3.Text = "";
    ((ARControl) this.lblHeader3).Top = 9f / 16f;
    ((ARControl) this.lblHeader3).Width = 7.875f;
    this.Detail1.ColumnSpacing = 0.0f;
    ((Section) this.Detail1).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.txtTransactionNum,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4
    });
    ((Section) this.Detail1).Height = 0.1979167f;
    ((Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.txtTransactionNum).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.RightColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.TopColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).DataField = "TransactNum";
    ((ARControl) this.txtTransactionNum).Height = 3f / 16f;
    ((ARControl) this.txtTransactionNum).Left = 0.0f;
    ((ARControl) this.txtTransactionNum).Name = "txtTransactionNum";
    this.txtTransactionNum.Style = "";
    this.txtTransactionNum.Text = (string) null;
    ((ARControl) this.txtTransactionNum).Top = 0.0f;
    ((ARControl) this.txtTransactionNum).Width = 1f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "CheckDate";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 2.375f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "";
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
    ((ARControl) this.TextBox3).DataField = "CheckNum";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 75f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 1f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "CheckAmount";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 6.875f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "text-align: right; ";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1f;
    ((Section) this.PageFooter1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.ReportInfo1
    });
    this.PageFooter1.Height = 0.25f;
    ((Section) this.PageFooter1).Name = "PageFooter1";
    ((ARControl) this.ReportInfo1).Border.BottomColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.ReportInfo1).Border.LeftColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.ReportInfo1).Border.RightColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.ReportInfo1).Border.TopColor = Color.Black;
    ((ARControl) this.ReportInfo1).Border.TopStyle = (BorderLineStyle) 0;
    this.ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
    ((ARControl) this.ReportInfo1).Height = 0.1979167f;
    ((ARControl) this.ReportInfo1).Left = 111f / 16f;
    ((ARControl) this.ReportInfo1).Name = "ReportInfo1";
    this.ReportInfo1.Style = "";
    ((ARControl) this.ReportInfo1).Top = 0.0f;
    ((ARControl) this.ReportInfo1).Width = 1f;
    this.GroupHeader1.Height = 0.0f;
    ((Section) this.GroupHeader1).Name = "GroupHeader1";
    ((Section) this.GroupFooter1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.TextBox5,
      (ARControl) this.Label6,
      (ARControl) this.Line1
    });
    this.GroupFooter1.Height = 15f / 32f;
    ((Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "CheckAmount";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 6.875f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox5.SummaryType = (SummaryType) 1;
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 1f / 16f;
    ((ARControl) this.TextBox5).Width = 1f;
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
    ((ARControl) this.Label6).Left = 5f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; vertical-align: bottom; ";
    this.Label6.Text = "Total";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 1f;
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
    ((ARControl) this.Line1).Top = 0.0f;
    ((ARControl) this.Line1).Width = 7.875f;
    this.Line1.X1 = 7.875f;
    this.Line1.X2 = 0.0f;
    this.Line1.Y1 = 0.0f;
    this.Line1.Y2 = 0.0f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.885417f;
    this.Sections.Add((Section) this.PageHeader1);
    this.Sections.Add((Section) this.GroupHeader1);
    this.Sections.Add((Section) this.Detail1);
    this.Sections.Add((Section) this.GroupFooter1);
    this.Sections.Add((Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.lblHeader2).EndInit();
    ((ISupportInitialize) this.lblHeader3).EndInit();
    ((ISupportInitialize) this.txtTransactionNum).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.ReportInfo1).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTransactionNum")]
  internal virtual TextBox txtTransactionNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo1")]
  internal virtual ReportInfo ReportInfo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblHeader2")]
  internal virtual Label lblHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblHeader3")]
  internal virtual Label lblHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  internal virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  internal virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line1")]
  internal virtual Line Line1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rpt1099Detail()
  {
    this.ReportStart += new EventHandler(this.rptFinancials_BalanceSheet_ReportStart);
    this.InitializeComponent();
  }

  public rpt1099Detail(Guid EntityGUID, DateTime DateFrom, DateTime DateTo)
  {
    this.ReportStart += new EventHandler(this.rptFinancials_BalanceSheet_ReportStart);
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._EntityGUID = EntityGUID;
  }

  private void rptFinancials_BalanceSheet_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._ds = DefaultDatabase.ExecuteDataSet("spFin_rpt1099Detail", new object[6]
    {
      (object) "@EntityGuid",
      (object) this._EntityGUID,
      (object) "@DateFrom",
      (object) this._DateFrom,
      (object) "@DateTo",
      (object) this._DateTo
    });
    this.DataSource = (object) this._ds.Tables[1];
    this.lblHeader2.Text = this._ds.Tables[0].Rows[0]["Header2"].ToString();
    this.lblHeader3.Text = this._ds.Tables[0].Rows[0]["Header3"].ToString();
  }

  private void Detail1_BeforePrint(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtTransactionNum.Text, string.Empty, false) == 0)
      return;
    this.txtTransactionNum.HyperLink = this.txtTransactionNum.Text.ToString();
  }

  public override bool IsThreaded => true;

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    rptJournalTransaction rpt = new rptJournalTransaction(Conversions.ToInteger(e.HyperLink));
    rpt.Run();
    rpt.Document.Name = $"Journal Transaction - {e.HyperLink}";
    ReportFactory.Instance.ShowReport((SectionReport) rpt);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new EntitySelection("Entity", true),
        (BaseReportControl) new DateRangePicker("Dates", false)
      };
    }
  }
}
