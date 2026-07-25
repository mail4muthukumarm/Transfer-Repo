// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptWaivedFees
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{5A2108CE-CB92-4c8b-AD3E-3DFCFEFBBA0D}", "Waived Fees", "Waived Fees report.", "General")]
public class rptWaivedFees : MGAReport, IReport
{
  private TextBox txtTitle1;
  private Label Label1;
  private Label Label3;
  private Label Label7;
  private Label Label8;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  internal const string SecurityIDReportGuid = "{5A2108CE-CB92-4c8b-AD3E-3DFCFEFBBA0D}";
  private DateTime _DateFrom;
  private DateTime _DateTo;
  private DataTable _dt;

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTitle")]
  private virtual TextBox txtTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptWaivedFees));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.txtTitle1 = new TextBox();
    this.txtTitle = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.PageFooter = new PageFooter();
    this.Label2 = new Label();
    this.TextBox5 = new TextBox();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.txtTitle1).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5
    });
    ((Section) this.Detail).Height = 3f / 16f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "EffectiveDate";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 1.5f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 8pt; ";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.875f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "Amount";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 4.5f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "text-align: right; font-size: 8pt; ";
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
    ((ARControl) this.TextBox3).DataField = "Name_LastFirst";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 89f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 8pt; ";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 33f / 16f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "ChargeName";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 41f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 8pt; ";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1.75f;
    ((Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.txtTitle1,
      (ARControl) this.txtTitle
    });
    this.ReportHeader.Height = 0.6666667f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.txtTitle1).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTitle1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle1).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTitle1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle1).Border.RightColor = Color.Black;
    ((ARControl) this.txtTitle1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle1).Border.TopColor = Color.Black;
    ((ARControl) this.txtTitle1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle1).Height = 0.25f;
    ((ARControl) this.txtTitle1).Left = 0.0f;
    ((ARControl) this.txtTitle1).Name = "txtTitle1";
    this.txtTitle1.Style = "ddo-char-set: 0; text-align: center; font-size: 14.25pt; ";
    this.txtTitle1.Text = "Waived Fees report";
    ((ARControl) this.txtTitle1).Top = 0.0f;
    ((ARControl) this.txtTitle1).Width = 7.875f;
    ((ARControl) this.txtTitle).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.RightColor = Color.Black;
    ((ARControl) this.txtTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.TopColor = Color.Black;
    ((ARControl) this.txtTitle).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Height = 0.25f;
    ((ARControl) this.txtTitle).Left = 0.0f;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.Style = "ddo-char-set: 0; text-align: center; font-size: 12pt; ";
    this.txtTitle.Text = "From {0} to {1}";
    ((ARControl) this.txtTitle).Top = 5f / 16f;
    ((ARControl) this.txtTitle).Width = 7.875f;
    this.ReportFooter.Height = 0.0f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    ((Section) this.PageHeader).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label3,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label2
    });
    this.PageHeader.Height = 0.1979167f;
    ((Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 21f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label1.Text = "Effective Date";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 17f / 16f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 89f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label3.Text = "Users Name";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 33f / 16f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 41f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label7.Text = "Charge Name";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 1.75f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 4.5f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label8.Text = "Amount";
    ((ARControl) this.Label8).Top = 0.0f;
    ((ARControl) this.Label8).Width = 0.875f;
    this.PageFooter.Height = 0.0f;
    ((Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 1f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "text-align: center; font-weight: bold; font-size: 8pt; ";
    this.Label2.Text = "Control No";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 17f / 16f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "Controlno";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 0.25f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 8pt; ";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.875f;
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
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.txtTitle1).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public rptWaivedFees()
  {
    this.ReportStart += new EventHandler(this.rptUnprintedInvoices_ReportStart);
    this._dt = new DataTable();
  }

  public rptWaivedFees(DateTime DateFrom, DateTime DateTo)
  {
    this.ReportStart += new EventHandler(this.rptUnprintedInvoices_ReportStart);
    this._dt = new DataTable();
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
  }

  private void rptUnprintedInvoices_ReportStart(object sender, EventArgs e)
  {
    this.txtTitle.Text = string.Format(this.txtTitle.Text, (object) this._DateFrom.ToShortDateString(), (object) this._DateTo.ToShortDateString());
    this.BouncingProgress(true);
    this.ShowPageNumbers();
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbCommand command = DefaultDatabase.CreateCommand(nameof (rptWaivedFees), dbConnection))
      {
        command.CommandType = CommandType.StoredProcedure;
        command.CommandTimeout = 0;
        if (DateTime.Compare(this._DateFrom, DateTime.MinValue) != 0)
          DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@DateFrom", (object) this._DateFrom);
        if (DateTime.Compare(this._DateTo, DateTime.MinValue) != 0)
          DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@DateTo", (object) this._DateTo);
        using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter(command))
        {
          try
          {
            dataAdapter.Fill(this._dt);
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
    if (this._dt.Rows.Count <= 0)
      return;
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
      getReportControls[0] = (BaseReportControl) new DateRangePicker("Effective Date", date1, date2, false);
      return getReportControls;
    }
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }
}
