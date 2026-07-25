// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptInvoicesViaAutomation
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{C6DEC157-69EB-4e72-A757-E319B45653F9}", "Invoice Automation Schedule", "Shows a list of invoices that are scheduled to be printed via automation.", "General")]
public class rptInvoicesViaAutomation : MGAReport, IReport
{
  private DateTime _dueDateFrom;
  private DateTime _dueDateTo;
  private DataTable _dt;
  private int _totalRecords;
  private int _failSafePreviousRecordCount;
  private TextBox txtTitle;
  private TextBox DueDate1;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;

  public rptInvoicesViaAutomation()
  {
    this.ReportStart += new EventHandler(this.rptUnprintedInvoices_ReportStart);
    this._dt = new DataTable();
    this._failSafePreviousRecordCount = 0;
  }

  public rptInvoicesViaAutomation(DateTime DueDateFrom, DateTime DueDateTo)
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

  private void rptUnprintedInvoices_ReportStart(object sender, EventArgs e)
  {
    this.txtTitle.Text = string.Format(this.txtTitle.Text, (object) this._dueDateFrom.ToShortDateString(), (object) this._dueDateTo.ToShortDateString());
    ArrayList arrayList = new ArrayList();
    arrayList.Add((object) "@DateFrom");
    arrayList.Add((object) this._dueDateFrom);
    arrayList.Add((object) "@DateTo");
    arrayList.Add((object) this._dueDateTo);
    arrayList.Add((object) "@GetCount");
    arrayList.Add((object) 1);
    this._totalRecords = Database.Instance.QuerySP.PerformScalarQueryInt(nameof (rptInvoicesViaAutomation), 0, arrayList.ToArray());
    this.SetProgressbarMaximum(this._totalRecords * 2);
    arrayList.RemoveRange(arrayList.Count - 2, 2);
    Database.Instance.QueryMultithreadedSP.PerformTableQueryBG(new TableQueryMultithreadEventHandler(this.queryComplete), new TableFillingEventHandler(this.queryProgress), (object) "Unprinted Report", nameof (rptInvoicesViaAutomation), arrayList.ToArray());
    this.SetStatusText("Retrieving Records...");
    while (this._dt.Rows.Count < this._totalRecords)
      Thread.Sleep(1000);
    this.SetStatusText("Formatting...");
    if (this._dt.Rows.Count <= 0)
      return;
    this.DataSource = (object) new DataView(this._dt, "", "DateToPrint", DataViewRowState.CurrentRows);
  }

  public override bool IsThreaded => true;

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptInvoicesViaAutomation));
    this.Detail = new Detail();
    this.ReportHeader = new ReportHeader();
    this.ReportFooter = new ReportFooter();
    this.ghDateToPrint = new GroupHeader();
    this.gfDateToPrint = new GroupFooter();
    this.txtTitle = new TextBox();
    this.DueDate1 = new TextBox();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.DueDate1).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 16f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.txtTitle
    });
    this.ReportHeader.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghDateToPrint).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.DueDate1,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5
    });
    this.ghDateToPrint.DataField = "DateToPrint";
    this.ghDateToPrint.Height = 0.5506945f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghDateToPrint).Name = "ghDateToPrint";
    this.gfDateToPrint.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfDateToPrint).Name = "gfDateToPrint";
    this.txtTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTitle.DistinctField = (string) null;
    this.txtTitle.Font = new Font("Arial", 14.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtTitle.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox txtTitle = this.txtTitle;
    object obj1 = componentResourceManager.GetObject("txtTitle.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) txtTitle).Location = pointF1;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.OutputFormat = (string) null;
    ((ARControl) this.txtTitle).Size = new SizeF(7.875f, 0.25f);
    this.txtTitle.Text = "Invoices to be Printed Via Automation {0} to {1}";
    ((ARControl) this.DueDate1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.DueDate1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.DueDate1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.DueDate1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.DueDate1).DataField = "DateToPrint";
    this.DueDate1.DistinctField = (string) null;
    this.DueDate1.Font = new Font("Arial", 12f, FontStyle.Bold);
    this.DueDate1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox dueDate1 = this.DueDate1;
    object obj2 = componentResourceManager.GetObject("DueDate1.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) dueDate1).Location = pointF2;
    ((ARControl) this.DueDate1).Name = "DueDate1";
    this.DueDate1.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.DueDate1).Size = new SizeF(3f, 0.25f);
    this.DueDate1.Text = " ";
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj3 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) label1).Location = pointF3;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1.25f, 3f / 16f);
    this.Label1.Text = "Invoice #";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj4 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) label2).Location = pointF4;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label2.Text = "Invoice Date";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj5 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label3).Location = pointF5;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(13f / 16f, 3f / 16f);
    this.Label3.Text = "Due Date";
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj6 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label4).Location = pointF6;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(61f / 16f, 3f / 16f);
    this.Label4.Text = "Remitter";
    this.Label5.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 9f, FontStyle.Bold);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj7 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label5).Location = pointF7;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(19f / 16f, 3f / 16f);
    this.Label5.Text = "Amount";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "OfficeInvoiceNum";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 9f);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj8 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox1).Location = pointF8;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = (string) null;
    ((ARControl) this.TextBox1).Size = new SizeF(1.25f, 3f / 16f);
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "InvoiceDate";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 9f);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj9 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox2).Location = pointF9;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox2).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "DueDate";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 9f);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj10 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox3).Location = pointF10;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox3).Size = new SizeF(13f / 16f, 3f / 16f);
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "Remitter";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 9f);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj11 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox4).Location = pointF11;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(61f / 16f, 3f / 16f);
    this.TextBox4.Text = " ";
    this.TextBox5.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "Amount";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 9f);
    this.TextBox5.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox5 = this.TextBox5;
    object obj12 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox5).Location = pointF12;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox5).Size = new SizeF(19f / 16f, 3f / 16f);
    this.TextBox5.Text = " ";
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.875f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghDateToPrint);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfDateToPrint);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.DueDate1).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
  }

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
      getReportControls[0] = (BaseReportControl) new DateRangePicker("Invoice Date", date1, date2, false);
      return getReportControls;
    }
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghDateToPrint")]
  private virtual GroupHeader ghDateToPrint { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gfDateToPrint")]
  private virtual GroupFooter gfDateToPrint { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
