// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptInvoiceStatus
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{4ECEB645-8374-4b7f-A20C-7C344AFBC40D}", "Invoice Status", "Shows a list of invoices with submitted status, failed status and additional date information for a specified date range.", "General")]
public class rptInvoiceStatus : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{4ECEB645-8374-4b7f-A20C-7C344AFBC40D}";
  private DateTime _dueDateFrom;
  private DateTime _dueDateTo;
  private DataTable _dt;
  private int _totalRecords;
  private int _failSafePreviousRecordCount;
  private TextBox txtTitle;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private CheckBox chkFailed;
  private CheckBox chkPrinted;

  public rptInvoiceStatus()
  {
    this.ReportStart += new EventHandler(this.rptUnprintedInvoices_ReportStart);
    this._dt = new DataTable();
    this._failSafePreviousRecordCount = 0;
  }

  public rptInvoiceStatus(DateTime DueDateFrom, DateTime DueDateTo)
  {
    this.ReportStart += new EventHandler(this.rptUnprintedInvoices_ReportStart);
    this._dt = new DataTable();
    this._failSafePreviousRecordCount = 0;
    this.InitializeComponent();
    this._dueDateFrom = DueDateFrom;
    this._dueDateTo = DueDateTo;
  }

  private void queryComplete(object sender, TableQueryMultithreadEventArgs e)
  {
    this._totalRecords = this._failSafePreviousRecordCount;
  }

  private void queryProgress(object sender, TableFillingEventArgs e)
  {
    if (this._dt.Rows.Count == 0)
    {
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) e.Row.Table.Columns)
          this._dt.Columns.Add(column.Caption, column.DataType);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    this.SetStatusText("Retrieving Information on Invoice " + e.Row["OfficeInvoiceNum"].ToString());
    this.IncreaseProgressbar(1);
    this._dt.ImportRow(e.Row);
    if (this._failSafePreviousRecordCount == this._dt.Rows.Count)
      this._totalRecords = this._failSafePreviousRecordCount;
    this._failSafePreviousRecordCount = this._dt.Rows.Count;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptInvoiceStatus));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.chkFailed = new CheckBox();
    this.chkPrinted = new CheckBox();
    this.ReportHeader = new ReportHeader();
    this.txtTitle = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.chkFailed).BeginInit();
    ((ISupportInitialize) this.chkPrinted).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.chkFailed,
      (ARControl) this.chkPrinted
    });
    ((Section) this.Detail).Height = 0.1666667f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "OfficeInvoiceNum";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 8pt";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 1.375f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "EffectiveDate";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 1.375f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 8pt";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.875f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "ExpirationDate";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 2.25f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 8pt";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.875f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "DueDate";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 3.125f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 8pt";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.875f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "DateIssued";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 4f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "font-size: 8pt";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.875f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "DateBilled";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 4.875f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "font-size: 8pt";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 0.875f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "TransactionDate";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 5.75f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "font-size: 8pt";
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 0.875f;
    ((ARControl) this.chkFailed).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.chkFailed).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.chkFailed).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.chkFailed).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.chkFailed).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.chkFailed).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.chkFailed).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.chkFailed).Border.TopStyle = (BorderLineStyle) 1;
    this.chkFailed.CheckAlignment = ContentAlignment.MiddleCenter;
    ((ARControl) this.chkFailed).DataField = "Failed";
    ((ARControl) this.chkFailed).Height = 3f / 16f;
    ((ARControl) this.chkFailed).Left = 6.625f;
    ((ARControl) this.chkFailed).Name = "chkFailed";
    this.chkFailed.Style = "ddo-char-set: 0";
    this.chkFailed.Text = " ";
    ((ARControl) this.chkFailed).Top = 0.0f;
    ((ARControl) this.chkFailed).Width = 0.625f;
    ((ARControl) this.chkPrinted).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.chkPrinted).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.chkPrinted).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.chkPrinted).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.chkPrinted).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.chkPrinted).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.chkPrinted).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.chkPrinted).Border.TopStyle = (BorderLineStyle) 1;
    this.chkPrinted.CheckAlignment = ContentAlignment.MiddleCenter;
    ((ARControl) this.chkPrinted).DataField = "Printed";
    ((ARControl) this.chkPrinted).Height = 3f / 16f;
    ((ARControl) this.chkPrinted).Left = 7.25f;
    ((ARControl) this.chkPrinted).Name = "chkPrinted";
    this.chkPrinted.Style = "ddo-char-set: 0";
    this.chkPrinted.Text = " ";
    ((ARControl) this.chkPrinted).Top = 0.0f;
    ((ARControl) this.chkPrinted).Width = 0.625f;
    ((Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtTitle
    });
    this.ReportHeader.Height = 0.3222222f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.txtTitle).Height = 0.25f;
    ((ARControl) this.txtTitle).Left = 0.0f;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.Style = "font-size: 14.25pt; text-align: center; ddo-char-set: 0";
    this.txtTitle.Text = "All Invoices From {0} to {1}";
    ((ARControl) this.txtTitle).Top = 0.0f;
    ((ARControl) this.txtTitle).Width = 7.875f;
    this.ReportFooter.Height = 0.0f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    ((Section) this.PageHeader).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10
    });
    this.PageHeader.Height = 0.1763889f;
    ((Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 8pt; font-weight: bold";
    this.Label1.Text = "Invoice #";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 1.375f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 4.875f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 8pt; font-weight: bold";
    this.Label2.Text = "Billed";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 0.875f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 3.125f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 8pt; font-weight: bold";
    this.Label3.Text = "Due";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 0.875f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 7.25f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 8pt; font-weight: bold; text-align: center";
    this.Label5.Text = "Printed?";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 0.625f;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 4f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 8pt; font-weight: bold";
    this.Label6.Text = "Issued";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 0.875f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 1.375f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 8pt; font-weight: bold";
    this.Label7.Text = "Effective";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 0.875f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 2.25f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 8pt; font-weight: bold";
    this.Label8.Text = "Expiration";
    ((ARControl) this.Label8).Top = 0.0f;
    ((ARControl) this.Label8).Width = 0.875f;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 5.75f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 8pt; font-weight: bold";
    this.Label9.Text = "Transaction";
    ((ARControl) this.Label9).Top = 0.0f;
    ((ARControl) this.Label9).Width = 0.875f;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 6.625f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 8pt; font-weight: bold; text-align: center";
    this.Label10.Text = "Failed?";
    ((ARControl) this.Label10).Top = 0.0f;
    ((ARControl) this.Label10).Width = 0.625f;
    this.PageFooter.Height = 0.0f;
    ((Section) this.PageFooter).Name = "PageFooter";
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.ReportHeader);
    this.Sections.Add((Section) this.PageHeader);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.PageFooter);
    this.Sections.Add((Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.chkFailed).EndInit();
    ((ISupportInitialize) this.chkPrinted).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptUnprintedInvoices_ReportStart(object sender, EventArgs e)
  {
    this.txtTitle.Text = string.Format(this.txtTitle.Text, (object) this._dueDateFrom.ToShortDateString(), (object) this._dueDateTo.ToShortDateString());
    ArrayList arrayList = new ArrayList();
    arrayList.Add((object) "@InvoiceDueDateFrom");
    arrayList.Add((object) this._dueDateFrom);
    arrayList.Add((object) "@InvoiceDueDateTo");
    arrayList.Add((object) this._dueDateTo);
    arrayList.Add((object) "@GetCount");
    arrayList.Add((object) 1);
    this._totalRecords = Database.Instance.QuerySP.PerformScalarQueryInt(nameof (rptInvoiceStatus), 0, arrayList.ToArray());
    this.SetProgressbarMaximum(this._totalRecords);
    arrayList.RemoveRange(arrayList.Count - 2, 2);
    Database.Instance.QueryMultithreadedSP.PerformTableQueryBG(new TableQueryMultithreadEventHandler(this.queryComplete), new TableFillingEventHandler(this.queryProgress), (object) "Invoice Status Report", nameof (rptInvoiceStatus), arrayList.ToArray());
    this.SetStatusText("Retrieving Records...");
    while (this._dt.Rows.Count < this._totalRecords)
      Thread.Sleep(1000);
    this.SetStatusText("Formatting...");
    this.DataSource = (object) this._dt;
  }

  public override bool IsThreaded => true;

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[1];
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[0] = (BaseReportControl) new DateRangePicker("Due Date", date1, date2, false);
      return getReportControls;
    }
  }

  public override void ExportToExcel(string FileName)
  {
    if (this.DataSource == null)
      return;
    DataTable source = new DataTable();
    DataColumnCollection columns = source.Columns;
    columns.Add("Invoice #", typeof (string));
    columns.Add("Effective", typeof (DateTime));
    columns.Add("Expiration", typeof (DateTime));
    columns.Add("Due", typeof (DateTime));
    columns.Add("Issued", typeof (DateTime));
    columns.Add("Billed", typeof (DateTime));
    columns.Add("Transaction", typeof (DateTime));
    columns.Add("Failed?", typeof (string));
    columns.Add("Printed?", typeof (string));
    try
    {
      foreach (DataRow row1 in this._dt.Rows)
      {
        DataRow row2 = source.NewRow();
        row2["Invoice #"] = (object) row1["OfficeInvoiceNum"].ToString();
        row2["Effective"] = RuntimeHelpers.GetObjectValue(row1["EffectiveDate"]);
        row2["Expiration"] = RuntimeHelpers.GetObjectValue(row1["ExpirationDate"]);
        row2["Due"] = RuntimeHelpers.GetObjectValue(row1["DueDate"]);
        row2["Issued"] = RuntimeHelpers.GetObjectValue(row1["DateIssued"]);
        row2["Billed"] = RuntimeHelpers.GetObjectValue(row1["DateBilled"]);
        row2["Transaction"] = RuntimeHelpers.GetObjectValue(row1["TransactionDate"]);
        row2["Failed?"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Conversions.ToBoolean(row1["Failed"]), (object) "Yes", (object) "No"));
        row2["Printed?"] = RuntimeHelpers.GetObjectValue(Interaction.IIf(Conversions.ToBoolean(row1["Printed"]), (object) "Yes", (object) "No"));
        source.Rows.Add(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ExcelExport.ToExcel(source, FileName);
    source.Dispose();
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
