// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.IMSNotesReport
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
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
[SecureReportResource("{8D827C06-7415-442f-82B2-6504804860F8}", "Report on error type notes", "Display error type notes by Type, DateFrom and DateTo.", "General")]
public class IMSNotesReport : MGAReport, IReport
{
  internal int _Type;
  internal DateTime _DateFrom;
  internal DateTime _DateTo;
  internal DataTable _dt;
  internal DataTable _dtCopy;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (IMSNotesReport));
    this.PageHeader1 = new PageHeader();
    this.txtTitle1 = new TextBox();
    this.txtTitle = new TextBox();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.Label3 = new Label();
    this.Label8 = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Detail1 = new Detail();
    this.TextBox6 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox_username = new TextBox();
    this.PageFooter1 = new PageFooter();
    ((ISupportInitialize) this.txtTitle1).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox_username).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.txtTitle1,
      (ARControl) this.txtTitle,
      (ARControl) this.Label7,
      (ARControl) this.Label6,
      (ARControl) this.Label3,
      (ARControl) this.Label8,
      (ARControl) this.Label1,
      (ARControl) this.Label2
    });
    this.PageHeader1.Height = 15f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.txtTitle1).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTitle1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle1).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTitle1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle1).Border.RightColor = Color.Black;
    ((ARControl) this.txtTitle1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle1).Border.TopColor = Color.Black;
    ((ARControl) this.txtTitle1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle1).Height = 5f / 16f;
    ((ARControl) this.txtTitle1).Left = 0.0f;
    ((ARControl) this.txtTitle1).Name = "txtTitle1";
    this.txtTitle1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11.25pt; ";
    this.txtTitle1.Text = "IMS Report on error type notes";
    ((ARControl) this.txtTitle1).Top = 0.0f;
    ((ARControl) this.txtTitle1).Width = 165f / 16f;
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
    this.txtTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; ";
    this.txtTitle.Text = "Created Date From {0} To {1}   Type: {2} ";
    ((ARControl) this.txtTitle).Top = 5f / 16f;
    ((ARControl) this.txtTitle).Width = 165f / 16f;
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
    ((ARControl) this.Label7).Left = 0.0f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label7.Text = "Type";
    ((ARControl) this.Label7).Top = 11f / 16f;
    ((ARControl) this.Label7).Width = 17f / 16f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 19f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label6.Text = "Policy Number";
    ((ARControl) this.Label6).Top = 11f / 16f;
    ((ARControl) this.Label6).Width = 13f / 16f;
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
    ((ARControl) this.Label3).Left = 2.125f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label3.Text = "Insured";
    ((ARControl) this.Label3).Top = 11f / 16f;
    ((ARControl) this.Label3).Width = 31f / 16f;
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
    ((ARControl) this.Label8).Left = 67f / 16f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label8.Text = "Subject";
    ((ARControl) this.Label8).Top = 11f / 16f;
    ((ARControl) this.Label8).Width = 17f / 16f;
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
    ((ARControl) this.Label1).Left = 5.375f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label1.Text = "User Name";
    ((ARControl) this.Label1).Top = 11f / 16f;
    ((ARControl) this.Label1).Width = 1.625f;
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
    ((ARControl) this.Label2).Left = 7.125f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label2.Text = "Body";
    ((ARControl) this.Label2).Top = 11f / 16f;
    ((ARControl) this.Label2).Width = 43f / 16f;
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox_username
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 5f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "Type";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 0.0f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "ddo-char-set: 0; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 17f / 16f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "PolicyNumber";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 19f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "ddo-char-set: 0; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 13f / 16f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "Insured";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 2.125f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 31f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "Subject";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 67f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "ddo-char-set: 0; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 17f / 16f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "Body";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 7.125f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 43f / 16f;
    ((ARControl) this.TextBox_username).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox_username).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox_username).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox_username).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox_username).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox_username).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox_username).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox_username).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox_username).DataField = "UserName";
    ((ARControl) this.TextBox_username).Height = 0.125f;
    ((ARControl) this.TextBox_username).Left = 5.375f;
    ((ARControl) this.TextBox_username).Name = "TextBox_username";
    this.TextBox_username.Style = "ddo-char-set: 0; font-size: 6.75pt; vertical-align: middle; ";
    this.TextBox_username.Text = (string) null;
    ((ARControl) this.TextBox_username).Top = 0.0f;
    ((ARControl) this.TextBox_username).Width = 1.625f;
    this.PageFooter1.Height = 0.1190476f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtTitle1).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox_username).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTitle1")]
  private virtual TextBox txtTitle1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTitle")]
  private virtual TextBox txtTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox_username")]
  private virtual TextBox TextBox_username { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public IMSNotesReport()
  {
    this.ReportStart += new EventHandler(this.rptTasks_ReportStart);
    this._dt = new DataTable();
    this._dtCopy = new DataTable();
  }

  public IMSNotesReport(int Type, DateTime DateFrom, DateTime DateTo)
  {
    this.ReportStart += new EventHandler(this.rptTasks_ReportStart);
    this._dt = new DataTable();
    this._dtCopy = new DataTable();
    this.InitializeComponent();
    this._Type = Type;
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
  }

  private void rptTasks_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    string str;
    if (this._Type == 0)
      str = "All Types";
    else
      str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT  dbo.lstNoteTypes.Description FROM dbo.lstNoteTypes WHERE dbo.lstNoteTypes.NoteTypeID = @NT", new object[2]
      {
        (object) "@NT",
        (object) this._Type
      });
    this.txtTitle.Text = string.Format(this.txtTitle.Text, (object) this._DateFrom.ToString("MM/dd/yyyy"), (object) this._DateTo.ToString("MM/dd/yyyy"), (object) str);
    this._dt = DefaultDatabase.ExecuteDataTable("rptIMSNotes", new object[6]
    {
      (object) "@Type",
      Interaction.IIf(this._Type == 0, (object) DBNull.Value, (object) this._Type),
      (object) "@DateFrom",
      Interaction.IIf(DateTime.Compare(this._DateFrom.Date, DateTime.MinValue) == 0, (object) DBNull.Value, (object) this._DateFrom.Date),
      (object) "@DateTo",
      Interaction.IIf(DateTime.Compare(this._DateTo.Date, DateTime.MinValue) == 0, (object) DBNull.Value, (object) this._DateTo.Date)
    });
    this.DataSource = (object) this._dt;
    this._dtCopy = this._dt;
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls = new BaseReportControl[2]
      {
        (BaseReportControl) new GenericComboBox("Type", "(SELECT -1 As Sort, 0 As Value, 'All Types' As Display) UNION (SELECT 1 As Sort, CONVERT(int, NoteTypeID) As Value, Description As Display FROM lstNoteTypes)ORDER BY Sort, Display", "Value", "Display", typeof (int)),
        null
      };
      DateTime now = DateAndTime.Now;
      DateTime date1 = now.Date;
      now = DateAndTime.Now;
      DateTime date2 = now.Date;
      getReportControls[1] = (BaseReportControl) new DateRangePicker("Created Date", date1, date2, true);
      return getReportControls;
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dtCopy, SaveFileTo);
  }
}
