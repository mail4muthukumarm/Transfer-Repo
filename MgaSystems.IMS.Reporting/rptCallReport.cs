// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptCallReport
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
[SecureReportResource("{1442DEA2-E262-44ac-8482-A770BBCDAA26}", "Call Report", "a report showing – the agent – who called, what time, notes", "General")]
public class rptCallReport : MGAReport, IReport
{
  private IContainer components;
  private readonly int _LeadContact;
  private readonly DateTime _dateFrom;
  private readonly DateTime _dateTo;
  private readonly string _producerLocationsIDs;
  private DataSet _ds;

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
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
    ResourceManager resourceManager = new ResourceManager(typeof (rptCallReport));
    this.PageHeader1 = new PageHeader();
    this.Detail1 = new Detail();
    this.PageFooter1 = new PageFooter();
    this.label5 = new Label();
    this.label1 = new Label();
    this.label6 = new Label();
    this.label7 = new Label();
    this.label8 = new Label();
    this.label9 = new Label();
    this.label10 = new Label();
    this.label11 = new Label();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.textBox15 = new TextBox();
    this.textBox5 = new TextBox();
    this.textBox1 = new TextBox();
    this.textBox40 = new TextBox();
    this.textBox2 = new TextBox();
    this.textBox3 = new TextBox();
    this.textBox4 = new TextBox();
    this.textBox6 = new TextBox();
    ((ISupportInitialize) this.label5).BeginInit();
    ((ISupportInitialize) this.label1).BeginInit();
    ((ISupportInitialize) this.label6).BeginInit();
    ((ISupportInitialize) this.label7).BeginInit();
    ((ISupportInitialize) this.label8).BeginInit();
    ((ISupportInitialize) this.label9).BeginInit();
    ((ISupportInitialize) this.label10).BeginInit();
    ((ISupportInitialize) this.label11).BeginInit();
    ((ISupportInitialize) this.textBox15).BeginInit();
    ((ISupportInitialize) this.textBox5).BeginInit();
    ((ISupportInitialize) this.textBox1).BeginInit();
    ((ISupportInitialize) this.textBox40).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.textBox3).BeginInit();
    ((ISupportInitialize) this.textBox4).BeginInit();
    ((ISupportInitialize) this.textBox6).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.label5,
      (ARControl) this.label1,
      (ARControl) this.label6,
      (ARControl) this.label7,
      (ARControl) this.label8,
      (ARControl) this.label9,
      (ARControl) this.label10,
      (ARControl) this.label11
    });
    this.PageHeader1.Height = 0.833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.textBox5,
      (ARControl) this.textBox1,
      (ARControl) this.textBox40,
      (ARControl) this.textBox2,
      (ARControl) this.textBox3,
      (ARControl) this.textBox4,
      (ARControl) this.textBox6
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 0.2083333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    this.PageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((ARControl) this.label5).Border.BottomColor = Color.Black;
    ((ARControl) this.label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.LeftColor = Color.Black;
    ((ARControl) this.label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.RightColor = Color.Black;
    ((ARControl) this.label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Border.TopColor = Color.Black;
    ((ARControl) this.label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label5).Height = 0.375f;
    this.label5.HyperLink = (string) null;
    ((ARControl) this.label5).Left = 3f / 16f;
    ((ARControl) this.label5).Name = "label5";
    this.label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 14.25pt; font-family: Arial; vertical-align: middle; ";
    this.label5.Text = "Call Reports";
    ((ARControl) this.label5).Top = 0.125f;
    ((ARControl) this.label5).Width = 10.125f;
    ((ARControl) this.label1).Border.BottomColor = Color.Black;
    ((ARControl) this.label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label1).Border.LeftColor = Color.Black;
    ((ARControl) this.label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.RightColor = Color.Black;
    ((ARControl) this.label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Border.TopColor = Color.Black;
    ((ARControl) this.label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label1).Height = 3f / 16f;
    this.label1.HyperLink = (string) null;
    ((ARControl) this.label1).Left = 0.0f;
    ((ARControl) this.label1).Name = "label1";
    this.label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
    this.label1.Text = "Producer Location";
    ((ARControl) this.label1).Top = 0.625f;
    ((ARControl) this.label1).Width = 1.625f;
    ((ARControl) this.label6).Border.BottomColor = Color.Black;
    ((ARControl) this.label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label6).Border.LeftColor = Color.Black;
    ((ARControl) this.label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.RightColor = Color.Black;
    ((ARControl) this.label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Border.TopColor = Color.Black;
    ((ARControl) this.label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label6).Height = 3f / 16f;
    this.label6.HyperLink = (string) null;
    ((ARControl) this.label6).Left = 27f / 16f;
    ((ARControl) this.label6).Name = "label6";
    this.label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
    this.label6.Text = "Date of Visit";
    ((ARControl) this.label6).Top = 0.625f;
    ((ARControl) this.label6).Width = 0.875f;
    ((ARControl) this.label7).Border.BottomColor = Color.Black;
    ((ARControl) this.label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label7).Border.LeftColor = Color.Black;
    ((ARControl) this.label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.RightColor = Color.Black;
    ((ARControl) this.label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Border.TopColor = Color.Black;
    ((ARControl) this.label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label7).Height = 3f / 16f;
    this.label7.HyperLink = (string) null;
    ((ARControl) this.label7).Left = 2.625f;
    ((ARControl) this.label7).Name = "label7";
    this.label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
    this.label7.Text = "Visit Type";
    ((ARControl) this.label7).Top = 0.625f;
    ((ARControl) this.label7).Width = 0.875f;
    ((ARControl) this.label8).Border.BottomColor = Color.Black;
    ((ARControl) this.label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label8).Border.LeftColor = Color.Black;
    ((ARControl) this.label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.RightColor = Color.Black;
    ((ARControl) this.label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Border.TopColor = Color.Black;
    ((ARControl) this.label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label8).Height = 3f / 16f;
    this.label8.HyperLink = (string) null;
    ((ARControl) this.label8).Left = 57f / 16f;
    ((ARControl) this.label8).Name = "label8";
    this.label8.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
    this.label8.Text = "Lead Contact";
    ((ARControl) this.label8).Top = 0.625f;
    ((ARControl) this.label8).Width = 1.375f;
    ((ARControl) this.label9).Border.BottomColor = Color.Black;
    ((ARControl) this.label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label9).Border.LeftColor = Color.Black;
    ((ARControl) this.label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Border.RightColor = Color.Black;
    ((ARControl) this.label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Border.TopColor = Color.Black;
    ((ARControl) this.label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label9).Height = 3f / 16f;
    this.label9.HyperLink = (string) null;
    ((ARControl) this.label9).Left = 5f;
    ((ARControl) this.label9).Name = "label9";
    this.label9.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
    this.label9.Text = "Meeting Notes";
    ((ARControl) this.label9).Top = 0.625f;
    ((ARControl) this.label9).Width = 39f / 16f;
    ((ARControl) this.label10).Border.BottomColor = Color.Black;
    ((ARControl) this.label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label10).Border.LeftColor = Color.Black;
    ((ARControl) this.label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label10).Border.RightColor = Color.Black;
    ((ARControl) this.label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label10).Border.TopColor = Color.Black;
    ((ARControl) this.label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label10).Height = 3f / 16f;
    this.label10.HyperLink = (string) null;
    ((ARControl) this.label10).Left = 7.5f;
    ((ARControl) this.label10).Name = "label10";
    this.label10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
    this.label10.Text = "Producer Contact(s)";
    ((ARControl) this.label10).Top = 0.625f;
    ((ARControl) this.label10).Width = 1.375f;
    ((ARControl) this.label11).Border.BottomColor = Color.Black;
    ((ARControl) this.label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label11).Border.LeftColor = Color.Black;
    ((ARControl) this.label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.RightColor = Color.Black;
    ((ARControl) this.label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Border.TopColor = Color.Black;
    ((ARControl) this.label11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label11).Height = 3f / 16f;
    this.label11.HyperLink = (string) null;
    ((ARControl) this.label11).Left = 143f / 16f;
    ((ARControl) this.label11).Name = "label11";
    this.label11.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
    this.label11.Text = "User Contact(s)";
    ((ARControl) this.label11).Top = 0.625f;
    ((ARControl) this.label11).Width = 1.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.textBox15
    });
    this.GroupHeader1.DataField = "locName";
    this.GroupHeader1.GroupKeepTogether = (GroupKeepTogether) 1;
    this.GroupHeader1.Height = 0.198f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.UnderlayNext = true;
    this.GroupFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.textBox15).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.RightColor = Color.Black;
    ((ARControl) this.textBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).Border.TopColor = Color.Black;
    ((ARControl) this.textBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox15).DataField = "locName";
    ((ARControl) this.textBox15).Height = 3f / 16f;
    ((ARControl) this.textBox15).Left = 0.0f;
    ((ARControl) this.textBox15).Name = "textBox15";
    this.textBox15.Style = "ddo-char-set: 0; font-size: 9.75pt; font-family: Arial; vertical-align: top; ";
    this.textBox15.Text = (string) null;
    ((ARControl) this.textBox15).Top = 0.0f;
    ((ARControl) this.textBox15).Width = 1.625f;
    ((ARControl) this.textBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.RightColor = Color.Black;
    ((ARControl) this.textBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.TopColor = Color.Black;
    ((ARControl) this.textBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).DataField = "userContacts";
    ((ARControl) this.textBox5).Height = 3f / 16f;
    ((ARControl) this.textBox5).Left = 143f / 16f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.Style = "ddo-char-set: 0; font-size: 9.75pt; font-family: Arial; vertical-align: top; ";
    this.textBox5.Text = (string) null;
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 1.375f;
    ((ARControl) this.textBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.RightColor = Color.Black;
    ((ARControl) this.textBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox1).Border.TopColor = Color.Black;
    ((ARControl) this.textBox1).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox1.CanGrow = false;
    ((ARControl) this.textBox1).DataField = "DateOfVisit";
    ((ARControl) this.textBox1).Height = 3f / 16f;
    ((ARControl) this.textBox1).Left = 27f / 16f;
    ((ARControl) this.textBox1).Name = "textBox1";
    this.textBox1.OutputFormat = resourceManager.GetString("textBox1.OutputFormat");
    this.textBox1.Style = "ddo-char-set: 0; text-align: center; font-size: 9.75pt; font-family: Arial; vertical-align: top; ";
    this.textBox1.Text = (string) null;
    ((ARControl) this.textBox1).Top = 0.0f;
    ((ARControl) this.textBox1).Width = 0.875f;
    ((ARControl) this.textBox40).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox40).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox40).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox40).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox40).Border.RightColor = Color.Black;
    ((ARControl) this.textBox40).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox40).Border.TopColor = Color.Black;
    ((ARControl) this.textBox40).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox40.CanGrow = false;
    ((ARControl) this.textBox40).DataField = "Type";
    ((ARControl) this.textBox40).Height = 3f / 16f;
    ((ARControl) this.textBox40).Left = 2.625f;
    ((ARControl) this.textBox40).Name = "textBox40";
    this.textBox40.Style = "ddo-char-set: 0; text-align: center; font-size: 9.75pt; font-family: Arial; vertical-align: top; ";
    this.textBox40.Text = (string) null;
    ((ARControl) this.textBox40).Top = 0.0f;
    ((ARControl) this.textBox40).Width = 0.875f;
    ((ARControl) this.textBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.RightColor = Color.Black;
    ((ARControl) this.textBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox2).Border.TopColor = Color.Black;
    ((ARControl) this.textBox2).Border.TopStyle = (BorderLineStyle) 0;
    this.textBox2.CanGrow = false;
    ((ARControl) this.textBox2).DataField = "leadContact";
    ((ARControl) this.textBox2).Height = 3f / 16f;
    ((ARControl) this.textBox2).Left = 57f / 16f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "ddo-char-set: 0; font-size: 9.75pt; font-family: Arial; vertical-align: top; ";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 0.0f;
    ((ARControl) this.textBox2).Width = 1.375f;
    ((ARControl) this.textBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.RightColor = Color.Black;
    ((ARControl) this.textBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).Border.TopColor = Color.Black;
    ((ARControl) this.textBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox3).DataField = "MeetingNotes";
    ((ARControl) this.textBox3).Height = 3f / 16f;
    ((ARControl) this.textBox3).Left = 5f;
    ((ARControl) this.textBox3).Name = "textBox3";
    this.textBox3.Style = "ddo-char-set: 0; font-size: 9.75pt; font-family: Arial; vertical-align: top; ";
    this.textBox3.Text = (string) null;
    ((ARControl) this.textBox3).Top = 0.0f;
    ((ARControl) this.textBox3).Width = 39f / 16f;
    ((ARControl) this.textBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.RightColor = Color.Black;
    ((ARControl) this.textBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).Border.TopColor = Color.Black;
    ((ARControl) this.textBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox4).DataField = "producerContacts";
    ((ARControl) this.textBox4).Height = 3f / 16f;
    ((ARControl) this.textBox4).Left = 7.5f;
    ((ARControl) this.textBox4).Name = "textBox4";
    this.textBox4.Style = "ddo-char-set: 0; font-size: 9.75pt; font-family: Arial; vertical-align: top; ";
    this.textBox4.Text = (string) null;
    ((ARControl) this.textBox4).Top = 0.0f;
    ((ARControl) this.textBox4).Width = 1.375f;
    ((ARControl) this.textBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.RightColor = Color.Black;
    ((ARControl) this.textBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).Border.TopColor = Color.Black;
    ((ARControl) this.textBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox6).DataField = "locName";
    ((ARControl) this.textBox6).Height = 3f / 16f;
    ((ARControl) this.textBox6).Left = 10.375f;
    ((ARControl) this.textBox6).Name = "textBox6";
    this.textBox6.Style = "color: White; ddo-char-set: 0; font-size: 9.75pt; font-family: Arial; vertical-align: top; ";
    this.textBox6.Text = (string) null;
    ((ARControl) this.textBox6).Top = 0.0f;
    ((ARControl) this.textBox6).Width = 1.625f;
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.label5).EndInit();
    ((ISupportInitialize) this.label1).EndInit();
    ((ISupportInitialize) this.label6).EndInit();
    ((ISupportInitialize) this.label7).EndInit();
    ((ISupportInitialize) this.label8).EndInit();
    ((ISupportInitialize) this.label9).EndInit();
    ((ISupportInitialize) this.label10).EndInit();
    ((ISupportInitialize) this.label11).EndInit();
    ((ISupportInitialize) this.textBox15).EndInit();
    ((ISupportInitialize) this.textBox5).EndInit();
    ((ISupportInitialize) this.textBox1).EndInit();
    ((ISupportInitialize) this.textBox40).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.textBox3).EndInit();
    ((ISupportInitialize) this.textBox4).EndInit();
    ((ISupportInitialize) this.textBox6).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("label5")]
  private virtual Label label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label1")]
  private virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label6")]
  private virtual Label label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label7")]
  private virtual Label label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label8")]
  private virtual Label label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label9")]
  private virtual Label label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label10")]
  private virtual Label label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label11")]
  private virtual Label label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  internal virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox15")]
  private virtual TextBox textBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  internal virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox5")]
  private virtual TextBox textBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox1")]
  private virtual TextBox textBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox40")]
  private virtual TextBox textBox40 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox2")]
  private virtual TextBox textBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox3")]
  private virtual TextBox textBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox4")]
  private virtual TextBox textBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("textBox6")]
  private virtual TextBox textBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptCallReport()
  {
    this.ReportStart += new EventHandler(this.rptCallReport_ReportStart);
    this.InitializeComponent();
  }

  public rptCallReport(
    DateTime dateFrom,
    DateTime dateto,
    string producerLocationsIDs,
    int LeadContact)
  {
    this.ReportStart += new EventHandler(this.rptCallReport_ReportStart);
    this.InitializeComponent();
    this._LeadContact = LeadContact;
    this._dateFrom = dateFrom;
    this._dateTo = dateto;
    this._producerLocationsIDs = producerLocationsIDs;
  }

  private void rptCallReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.ShowPageNumbers();
    object dateFrom = (object) DBNull.Value;
    object dateTo = (object) DBNull.Value;
    object producerLocationsIds = (object) DBNull.Value;
    object leadContact = (object) DBNull.Value;
    if (!string.IsNullOrEmpty(this._producerLocationsIDs))
      producerLocationsIds = (object) this._producerLocationsIDs;
    if (!this._dateFrom.Equals(DateTime.MinValue))
      dateFrom = (object) this._dateFrom;
    if (!this._dateTo.Equals(DateTime.MinValue))
      dateTo = (object) this._dateTo;
    if (this._LeadContact != 0)
      leadContact = (object) this._LeadContact;
    this._ds = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, nameof (rptCallReport), 0, (CommandArgumentType) 0, new object[8]
    {
      (object) "@DateFrom",
      dateFrom,
      (object) "@DateTo",
      dateTo,
      (object) "@ProducerLocations",
      producerLocationsIds,
      (object) "@LeadContactID",
      leadContact
    });
    this.DataSource = (object) this._ds.Tables[0];
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[3]
      {
        (BaseReportControl) new DateRangePicker("Due Date", false),
        (BaseReportControl) new GenericListBox("Producer Locations(s)", "SELECT Name, ProducerLocationID FROM tblProducerLocations ORDER BY Name", "ProducerLocationID", "Name", true, typeof (int), true, false, 125),
        (BaseReportControl) new GenericComboBox("Lead Contact", "(SELECT -1 As Sort, 'All Lead Contact' As UserName, 0 As UserID) UNION (SELECT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserID FROM tblUsers) ORDER BY Sort, UserName", "UserID", "UserName", typeof (int))
      };
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._ds.Tables[0], SaveFileTo);
  }
}
