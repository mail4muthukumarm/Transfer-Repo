// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptForms
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{96EB7946-9384-45c2-863E-D40CBFB9EDBB}", "Forms report", "Displays Applied forms in specific Carrier/Line/State.", "General")]
public class rptForms : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{96EB7946-9384-45c2-863E-D40CBFB9EDBB}";
  private Label lblTitle;
  private Label Label6;
  private Label Label17;
  private DataTable _dt;
  private readonly Guid _CompanyLocationGuid;
  private readonly string _LineGuid;
  private readonly string _StateID;

  internal virtual PageHeader PageHeader1
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

  [field: AccessedThroughProperty("PageFooter1")]
  internal virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  internal virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  internal virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader2")]
  internal virtual GroupHeader GroupHeader2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter2")]
  internal virtual GroupFooter GroupFooter2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader3")]
  internal virtual GroupHeader GroupHeader3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter3")]
  internal virtual GroupFooter GroupFooter3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Detail_BeforePrint);
      Detail detail1 = this._Detail;
      if (detail1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).BeforePrint -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptForms()
  {
    this.ReportStart += new EventHandler(this.rptForms_ReportStart);
    this._dt = new DataTable();
  }

  public rptForms(Guid CompanyLocationGuid, string lineguid, string StateID)
  {
    this.ReportStart += new EventHandler(this.rptForms_ReportStart);
    this._dt = new DataTable();
    this.InitializeComponent();
    this._CompanyLocationGuid = CompanyLocationGuid;
    this._LineGuid = lineguid;
    this._StateID = StateID;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptForms));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox5 = new TextBox();
    this.lblTitle = new Label();
    this.Label6 = new Label();
    this.Label17 = new Label();
    this.PageHeader1 = new PageHeader();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.PageFooter1 = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.TextBox2 = new TextBox();
    this.GroupFooter1 = new GroupFooter();
    this.GroupHeader2 = new GroupHeader();
    this.TextBox3 = new TextBox();
    this.GroupFooter2 = new GroupFooter();
    this.GroupHeader3 = new GroupHeader();
    this.TextBox4 = new TextBox();
    this.GroupFooter3 = new GroupFooter();
    this.TextBox6 = new TextBox();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1666667f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "FormName";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 85f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 45f / 16f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    this.TextBox5.CanGrow = false;
    ((ARControl) this.TextBox5).DataField = "FormNumber";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 8.25f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 1.375f;
    ((ARControl) this.lblTitle).Height = 0.25f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 14pt; text-align: center";
    this.lblTitle.Text = "Forms report";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 163f / 16f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 5f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 47f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.Label6.Text = "Line Name";
    ((ARControl) this.Label6).Top = 0.625f;
    ((ARControl) this.Label6).Width = 25f / 16f;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Height = 5f / 16f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 73f / 16f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "font-size: 8.25pt; font-weight: bold; text-align: center; vertical-align: bottom; ddo-char-set: 0";
    this.Label17.Text = "State ID";
    ((ARControl) this.Label17).Top = 0.625f;
    ((ARControl) this.Label17).Width = 11f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Label6,
      (ARControl) this.Label2,
      (ARControl) this.Label17,
      (ARControl) this.lblTitle,
      (ARControl) this.Label1,
      (ARControl) this.Label3,
      (ARControl) this.Label4
    });
    this.PageHeader1.Height = 0.9791667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 5f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.0f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: bottom";
    this.Label2.Text = "Company Name";
    ((ARControl) this.Label2).Top = 0.625f;
    ((ARControl) this.Label2).Width = 2.875f;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 5f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 85f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 8.25pt; font-weight: bold; text-align: center; vertical-align: bottom; ddo-char-set: 0";
    this.Label1.Text = "Form Name";
    ((ARControl) this.Label1).Top = 0.625f;
    ((ARControl) this.Label1).Width = 45f / 16f;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 5f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 131f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 8.25pt; font-weight: bold; text-align: center; vertical-align: bottom; ddo-char-set: 0";
    this.Label3.Text = "Form Number";
    ((ARControl) this.Label3).Top = 0.625f;
    ((ARControl) this.Label3).Width = 1.375f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 0.313f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 9.625f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 8.25pt; font-weight: bold; text-align: center; vertical-align: bottom; ddo-char-set: 0";
    this.Label4.Text = "Edition Date";
    ((ARControl) this.Label4).Top = 0.625f;
    ((ARControl) this.Label4).Width = 1f;
    this.PageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox2
    });
    this.GroupHeader1.DataField = "Name";
    this.GroupHeader1.Height = 0.1979167f;
    this.GroupHeader1.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.RepeatStyle = (RepeatStyle) 1;
    this.GroupHeader1.UnderlayNext = true;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    this.TextBox2.CanGrow = false;
    ((ARControl) this.TextBox2).DataField = "Name";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 0.0f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 2.875f;
    this.GroupFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox3
    });
    this.GroupHeader2.DataField = "LineName";
    this.GroupHeader2.Height = 3f / 16f;
    this.GroupHeader2.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2).Name = "GroupHeader2";
    this.GroupHeader2.RepeatStyle = (RepeatStyle) 1;
    this.GroupHeader2.UnderlayNext = true;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    this.TextBox3.CanGrow = false;
    ((ARControl) this.TextBox3).DataField = "LineName";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 47f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 25f / 16f;
    this.GroupFooter2.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2).Name = "GroupFooter2";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader3).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox4
    });
    this.GroupHeader3.DataField = "StateID";
    this.GroupHeader3.Height = 3f / 16f;
    this.GroupHeader3.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader3).Name = "GroupHeader3";
    this.GroupHeader3.RepeatStyle = (RepeatStyle) 1;
    this.GroupHeader3.UnderlayNext = true;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    this.TextBox4.CanGrow = false;
    ((ARControl) this.TextBox4).DataField = "StateID";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 73f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 6.75pt; text-align: center; ddo-char-set: 0";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.625f;
    this.GroupFooter3.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter3).Name = "GroupFooter3";
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    this.TextBox6.CanGrow = false;
    ((ARControl) this.TextBox6).DataField = "EditionDate";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 9.625f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.021f;
    ((ARControl) this.TextBox6).Width = 1f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.81667f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader3);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter3);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptForms_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.ShowPageNumbers();
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, nameof (rptForms), 0, (CommandArgumentType) 0, new object[6]
    {
      (object) "@CompanyLocationGuid",
      Interaction.IIf(!this._CompanyLocationGuid.Equals(Guid.Empty), (object) this._CompanyLocationGuid, (object) DBNull.Value),
      (object) "@StateID",
      Interaction.IIf(!this._StateID.Equals(string.Empty), (object) this._StateID, (object) DBNull.Value),
      (object) "@LineGuid",
      Interaction.IIf(!this._LineGuid.Equals(string.Empty), (object) this._LineGuid, (object) DBNull.Value)
    });
    if (this._dt.Rows.Count <= 0)
      return;
    this.DataSource = (object) this._dt;
  }

  public override bool IsThreaded => true;

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new CompanyLocations("Company", true),
        (BaseReportControl) new GenericListBox("Line of Business", "Select LineName as Display, LineGuid as Value From lstlines Order BY LineName", "Value", "Display", true, typeof (Guid), true, false, 200),
        (BaseReportControl) new GenericComboBox("State", $"SELECT '{string.Empty}' As StateID, 'All States' As State UNION SELECT StateID, State FROM lstStates", "StateID", "State", typeof (string))
      };
    }
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  private void PageHeader1_Format(object sender, EventArgs e)
  {
  }
}
