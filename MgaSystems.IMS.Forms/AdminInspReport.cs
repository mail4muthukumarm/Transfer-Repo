// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.AdminInspReport
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using DDCssLib;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class AdminInspReport : MGAReport, IReport
{
  private IContainer components;
  private Label Label1;
  private Label Label9;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private TextBox txtInspectionContact;
  private TextBox TextBox15;
  private TextBox TextBox16;
  private TextBox txtInspectionCompany;
  private TextBox TextBox22;
  private DataView _dvSource;
  private dsAdminInspReq _ds;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (AdminInspReport));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.Label9 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label7 = new Label();
    this.Label11 = new Label();
    this.Label8 = new Label();
    this.Label10 = new Label();
    this.Detail1 = new Detail();
    this.txtInspectionContact = new TextBox();
    this.TextBox15 = new TextBox();
    this.TextBox16 = new TextBox();
    this.TextBox22 = new TextBox();
    this.txtInspectionCompany = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.PageFooter1 = new PageFooter();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.txtInspectionContact).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.txtInspectionCompany).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.PageHeader1).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label9,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label7,
      (ARControl) this.Label11,
      (ARControl) this.Label8,
      (ARControl) this.Label10
    });
    this.PageHeader1.Height = 0.4685833f;
    ((Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label1).Height = 0.208f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.072f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 12.75pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label1.Text = "Follow-up Inspection Request Report";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 7.875f;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.7920001f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "";
    this.Label9.Text = "Insured";
    ((ARControl) this.Label9).Top = 0.281f;
    ((ARControl) this.Label9).Width = 1.583f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.0f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "";
    this.Label2.Text = "Control #";
    ((ARControl) this.Label2).Top = 0.281f;
    ((ARControl) this.Label2).Width = 0.9170001f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 2.323f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "";
    this.Label3.Text = "Insp. Company";
    ((ARControl) this.Label3).Top = 0.281f;
    ((ARControl) this.Label3).Width = 1.646f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 3.969f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "";
    this.Label4.Text = "Contact";
    ((ARControl) this.Label4).Top = 0.281f;
    ((ARControl) this.Label4).Width = 0.915f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 4.884f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "";
    this.Label5.Text = "Phone";
    ((ARControl) this.Label5).Top = 0.281f;
    ((ARControl) this.Label5).Width = 0.6469998f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 5.551f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "";
    this.Label7.Text = "Address";
    ((ARControl) this.Label7).Top = 0.281f;
    ((ARControl) this.Label7).Width = 0.8870001f;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 6.438f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "";
    this.Label11.Text = "City";
    ((ARControl) this.Label11).Top = 0.281f;
    ((ARControl) this.Label11).Width = 0.6750002f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 7.113f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "";
    this.Label8.Text = "State";
    ((ARControl) this.Label8).Top = 0.281f;
    ((ARControl) this.Label8).Width = 0.3860002f;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 7.499001f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "";
    this.Label10.Text = "Zip";
    ((ARControl) this.Label10).Top = 0.281f;
    ((ARControl) this.Label10).Width = 0.5009999f;
    this.Detail1.ColumnSpacing = 0.0f;
    ((Section) this.Detail1).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.txtInspectionContact,
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox22,
      (ARControl) this.txtInspectionCompany,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4
    });
    ((Section) this.Detail1).Height = 0.08366677f;
    ((Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.txtInspectionContact).DataField = "InspectionContact";
    ((ARControl) this.txtInspectionContact).Height = 0.125f;
    ((ARControl) this.txtInspectionContact).Left = 3.969f;
    ((ARControl) this.txtInspectionContact).Name = "txtInspectionContact";
    this.txtInspectionContact.Style = "font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.txtInspectionContact.Text = (string) null;
    ((ARControl) this.txtInspectionContact).Top = 0.0f;
    ((ARControl) this.txtInspectionContact).Width = 0.915f;
    ((ARControl) this.TextBox15).DataField = "ControlNo";
    ((ARControl) this.TextBox15).Height = 0.125f;
    ((ARControl) this.TextBox15).Left = 0.0f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.Style = "font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox15.Text = (string) null;
    ((ARControl) this.TextBox15).Top = 0.0f;
    ((ARControl) this.TextBox15).Width = 0.7920001f;
    ((ARControl) this.TextBox16).DataField = "Insured";
    ((ARControl) this.TextBox16).Height = 0.125f;
    ((ARControl) this.TextBox16).Left = 0.7920001f;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.Style = "font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox16.Text = (string) null;
    ((ARControl) this.TextBox16).Top = 0.0f;
    ((ARControl) this.TextBox16).Width = 1.531f;
    ((ARControl) this.TextBox22).DataField = "InspectionContactPhone";
    ((ARControl) this.TextBox22).Height = 0.125f;
    ((ARControl) this.TextBox22).Left = 4.884f;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.Style = "font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox22.Text = (string) null;
    ((ARControl) this.TextBox22).Top = 0.0f;
    ((ARControl) this.TextBox22).Width = 0.6469998f;
    ((ARControl) this.txtInspectionCompany).DataField = "InspectionCompanyName";
    ((ARControl) this.txtInspectionCompany).Height = 0.125f;
    ((ARControl) this.txtInspectionCompany).Left = 2.323f;
    ((ARControl) this.txtInspectionCompany).Name = "txtInspectionCompany";
    this.txtInspectionCompany.Style = "font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.txtInspectionCompany.Text = (string) null;
    ((ARControl) this.txtInspectionCompany).Top = 0.0f;
    ((ARControl) this.txtInspectionCompany).Width = 1.646f;
    ((ARControl) this.TextBox1).DataField = "City";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 6.438f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.6750001f;
    ((ARControl) this.TextBox2).DataField = "Address1";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 5.551f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.8870001f;
    ((ARControl) this.TextBox3).DataField = "State";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 7.113f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.3860002f;
    ((ARControl) this.TextBox4).DataField = "Zip";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 7.499001f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 6.75pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.5009999f;
    this.PageFooter1.Height = 1f / 16f;
    ((Section) this.PageFooter1).Name = "PageFooter1";
    this.MasterReport = false;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 8.000334f;
    this.Sections.Add((Section) this.PageHeader1);
    this.Sections.Add((Section) this.Detail1);
    this.Sections.Add((Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.txtInspectionContact).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.txtInspectionCompany).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public AdminInspReport()
  {
    this.ReportStart += new EventHandler(this.ITVReport_ReportStart);
    this._dvSource = new DataView();
    this._ds = new dsAdminInspReq();
    this.InitializeComponent();
  }

  public AdminInspReport(string idString)
  {
    this.ReportStart += new EventHandler(this.ITVReport_ReportStart);
    this._dvSource = new DataView();
    this._ds = new dsAdminInspReq();
    this.InitializeComponent();
    DefaultDatabase.LoadDataSet((DataSet) this._ds, new string[1]
    {
      "dtReport"
    }, "InspectionReportData", new object[4]
    {
      (object) "@IDString",
      (object) idString,
      (object) "@IsGenericReport",
      (object) false
    });
    this._dvSource.Table = (DataTable) this._ds.dtReport;
  }

  private void ITVReport_ReportStart(object sender, EventArgs e)
  {
    this.DataSource = (object) this._dvSource;
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel((DataTable) this._ds.dtReport, SaveFileTo);
  }

  public override bool ExcelOnly => true;

  public override bool HasRecords => this._ds.dtReport.Count > 0;

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;
}
