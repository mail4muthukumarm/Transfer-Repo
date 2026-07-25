// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptProducerGoals
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
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
[SecureReportResource("{AF80ACEA-6539-463e-AD91-F5B327EEF812}", "Producer Goals", "Producer Goals", "General")]
public class rptProducerGoals : MGAReport, IReport
{
  private DataTable _dt;
  private DateTime _DateTo;
  private DateTime _DateFrom;
  private string _ProducerLocations;
  private int _PolicyType;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptProducerGoals));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Detail1 = new Detail();
    this.ProducerLocationsName = new TextBox();
    this.Address = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.PageFooter1 = new PageFooter();
    this.ReportInfo1 = new ReportInfo();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.ProducerLocationsName).BeginInit();
    ((ISupportInitialize) this.Address).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.ReportInfo1).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7
    });
    this.PageHeader1.Height = 0.7708333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
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
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.Label1.Text = "Producer Location";
    ((ARControl) this.Label1).Top = 9f / 16f;
    ((ARControl) this.Label1).Width = 47f / 16f;
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
    ((ARControl) this.Label2).Left = 47f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.Label2.Text = "Producer Address";
    ((ARControl) this.Label2).Top = 9f / 16f;
    ((ARControl) this.Label2).Width = 47f / 16f;
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
    ((ARControl) this.Label3).Left = 5.875f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.Label3.Text = "Producer Code";
    ((ARControl) this.Label3).Top = 9f / 16f;
    ((ARControl) this.Label3).Width = 1.125f;
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
    ((ARControl) this.Label4).Left = 8.125f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; ";
    this.Label4.Text = "Target Premium";
    ((ARControl) this.Label4).Top = 9f / 16f;
    ((ARControl) this.Label4).Width = 1.125f;
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
    ((ARControl) this.Label5).Left = 7f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.Label5.Text = "Target Premium Entered Date";
    ((ARControl) this.Label5).Top = 7f / 16f;
    ((ARControl) this.Label5).Width = 1.125f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 5f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 9.25f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9.75pt; ";
    this.Label6.Text = "Actual Bound Premium";
    ((ARControl) this.Label6).Top = 7f / 16f;
    ((ARControl) this.Label6).Width = 1.125f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 0.375f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 1f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 21.75pt; ";
    this.Label7.Text = "Producer Goals";
    ((ARControl) this.Label7).Top = 1f / 16f;
    ((ARControl) this.Label7).Width = 165f / 16f;
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.ProducerLocationsName,
      (ARControl) this.Address,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 7f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.ProducerLocationsName).Border.BottomColor = Color.Black;
    ((ARControl) this.ProducerLocationsName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.ProducerLocationsName).Border.LeftColor = Color.Black;
    ((ARControl) this.ProducerLocationsName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.ProducerLocationsName).Border.RightColor = Color.Black;
    ((ARControl) this.ProducerLocationsName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.ProducerLocationsName).Border.TopColor = Color.Black;
    ((ARControl) this.ProducerLocationsName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.ProducerLocationsName).DataField = "ProducerLocationsName";
    ((ARControl) this.ProducerLocationsName).Height = 3f / 16f;
    ((ARControl) this.ProducerLocationsName).Left = 0.0f;
    ((ARControl) this.ProducerLocationsName).Name = "ProducerLocationsName";
    this.ProducerLocationsName.Style = "";
    this.ProducerLocationsName.Text = (string) null;
    ((ARControl) this.ProducerLocationsName).Top = 0.0f;
    ((ARControl) this.ProducerLocationsName).Width = 47f / 16f;
    ((ARControl) this.Address).Border.BottomColor = Color.Black;
    ((ARControl) this.Address).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Address).Border.LeftColor = Color.Black;
    ((ARControl) this.Address).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Address).Border.RightColor = Color.Black;
    ((ARControl) this.Address).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Address).Border.TopColor = Color.Black;
    ((ARControl) this.Address).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Address).DataField = "Address";
    ((ARControl) this.Address).Height = 3f / 16f;
    ((ARControl) this.Address).Left = 47f / 16f;
    ((ARControl) this.Address).Name = "Address";
    this.Address.Style = "";
    this.Address.Text = (string) null;
    ((ARControl) this.Address).Top = 0.0f;
    ((ARControl) this.Address).Width = 47f / 16f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "ProducerCode";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 5.875f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 1.125f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "Date";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 7f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1.125f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "GPremium";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 8.125f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "text-align: right; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 1.125f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "APremium";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 9.25f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "text-align: right; ";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 1.125f;
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
    ((ARControl) this.ReportInfo1).Height = 0.1979167f;
    ((ARControl) this.ReportInfo1).Left = 143f / 16f;
    ((ARControl) this.ReportInfo1).Name = "ReportInfo1";
    this.ReportInfo1.Style = "";
    ((ARControl) this.ReportInfo1).Top = 0.0f;
    ((ARControl) this.ReportInfo1).Width = 1f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 14f;
    this.PageSettings.PaperKind = PaperKind.Legal;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.52083f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.ProducerLocationsName).EndInit();
    ((ISupportInitialize) this.Address).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.ReportInfo1).EndInit();
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

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ProducerLocationsName")]
  internal virtual TextBox ProducerLocationsName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Address")]
  internal virtual TextBox Address { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  internal virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo1")]
  internal virtual ReportInfo ReportInfo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptProducerGoals()
  {
    this.ReportStart += new EventHandler(this.ProducerGoals_ReportStart);
    this._dt = new DataTable();
    this.InitializeComponent();
  }

  public rptProducerGoals(
    ref string ProducerLocations,
    ref int PolicyType,
    ref DateTime DateFrom,
    ref DateTime DateTo)
  {
    this.ReportStart += new EventHandler(this.ProducerGoals_ReportStart);
    this._dt = new DataTable();
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._ProducerLocations = ProducerLocations;
    this._PolicyType = PolicyType;
  }

  private void ProducerGoals_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.ShowPageNumbers();
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbCommand command = DefaultDatabase.CreateCommand(nameof (rptProducerGoals), dbConnection))
      {
        command.CommandType = CommandType.StoredProcedure;
        command.CommandTimeout = 0;
        if (!string.IsNullOrEmpty(this._ProducerLocations.ToString()))
          DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@ProducerLocationGuids", (object) this._ProducerLocations);
        DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@PolicyTypeID", (object) this._PolicyType);
        DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@EffectiveDateFrom", (object) this._DateFrom);
        DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@EffectiveDateTo", (object) this._DateTo);
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

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new GenericListBox("Producer Location", $"SELECT 'All Producer Locations' As Display, '{Guid.Empty}' As Value UNION SELECT  Name + ' ' + isnull(City,'') + isnull(', ' + State,'') + ' (' + convert(varchar,ProducerLocationID) + ')'AS Display, ProducerLocationGuid AS Value From tblProducerLocations where tblProducerLocations.StatusID = 1", "Value", "Display", true, typeof (Guid), true, false),
        (BaseReportControl) new GenericComboBox("Policy Type", "SELECT 0 as SortOrder, 0 AS ID,'All Types' AS Description UNION SELECT 1 as SortOrder, PolicyTypeID, Description FROM lstPolicyTypes Order By SortOrder,Description", "ID", "Description", typeof (int)),
        (BaseReportControl) new DateRangePicker("Dates", false)
      };
    }
  }
}
