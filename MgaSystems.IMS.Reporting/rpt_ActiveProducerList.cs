// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rpt_ActiveProducerList
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
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[DesignerGenerated]
[SecureReportResource("{F11FA030-6225-43e3-AF00-2AE633CA7746}", "Active Producer List", "Active Producer List", "Contacts")]
public class rpt_ActiveProducerList : MGAReport, IReport
{
  private DataSet _ds;

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rpt_ActiveProducerList));
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.Detail1 = new Detail();
    this.TextBox14 = new TextBox();
    this.TextBox15 = new TextBox();
    this.TextBox16 = new TextBox();
    this.TextBox17 = new TextBox();
    this.TextBox18 = new TextBox();
    this.TextBox19 = new TextBox();
    this.TextBox20 = new TextBox();
    this.TextBox21 = new TextBox();
    this.TextBox22 = new TextBox();
    this.TextBox23 = new TextBox();
    this.TextBox24 = new TextBox();
    this.TextBox25 = new TextBox();
    this.TextBox26 = new TextBox();
    this.PageFooter1 = new PageFooter();
    this.ReportInfo1 = new ReportInfo();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.TextBox23).BeginInit();
    ((ISupportInitialize) this.TextBox24).BeginInit();
    ((ISupportInitialize) this.TextBox25).BeginInit();
    ((ISupportInitialize) this.TextBox26).BeginInit();
    ((ISupportInitialize) this.ReportInfo1).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.Label1
    });
    this.PageHeader1.Height = 0.4583333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 7f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.625f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; text-align: center; font-size: 26.25pt; ";
    this.Label1.Text = "EXPORT TO EXCEL";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 8.75f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox1.Text = "Description";
    ((ARControl) this.TextBox1).Top = 0.125f;
    ((ARControl) this.TextBox1).Visible = false;
    ((ARControl) this.TextBox1).Width = 1f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 1f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox2.Text = "ProducerName";
    ((ARControl) this.TextBox2).Top = 0.125f;
    ((ARControl) this.TextBox2).Visible = false;
    ((ARControl) this.TextBox2).Width = 31f / 16f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 47f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox3.Text = "Name";
    ((ARControl) this.TextBox3).Top = 0.125f;
    ((ARControl) this.TextBox3).Visible = false;
    ((ARControl) this.TextBox3).Width = 2f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 79f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox4.Text = "Address1";
    ((ARControl) this.TextBox4).Top = 0.125f;
    ((ARControl) this.TextBox4).Visible = false;
    ((ARControl) this.TextBox4).Width = 27f / 16f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 6.625f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox5.Text = "Address2";
    ((ARControl) this.TextBox5).Top = 0.125f;
    ((ARControl) this.TextBox5).Visible = false;
    ((ARControl) this.TextBox5).Width = 21f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = (float) sbyte.MaxValue / 16f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox6.Text = "City";
    ((ARControl) this.TextBox6).Top = 0.125f;
    ((ARControl) this.TextBox6).Visible = false;
    ((ARControl) this.TextBox6).Width = 0.75f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 139f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox7.Text = "State";
    ((ARControl) this.TextBox7).Top = 0.125f;
    ((ARControl) this.TextBox7).Visible = false;
    ((ARControl) this.TextBox7).Width = 7f / 16f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 9.125f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox8.Text = "Zip Code";
    ((ARControl) this.TextBox8).Top = 0.125f;
    ((ARControl) this.TextBox8).Visible = false;
    ((ARControl) this.TextBox8).Width = 0.625f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 9.75f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox9.Text = "Salutation";
    ((ARControl) this.TextBox9).Top = 0.125f;
    ((ARControl) this.TextBox9).Visible = false;
    ((ARControl) this.TextBox9).Width = 11f / 16f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Height = 5f / 16f;
    ((ARControl) this.TextBox10).Left = 167f / 16f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox10.Text = "First Name";
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Visible = false;
    ((ARControl) this.TextBox10).Width = 11f / 16f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Height = 5f / 16f;
    ((ARControl) this.TextBox11).Left = 11.125f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox11.Text = "Last Name";
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Visible = false;
    ((ARControl) this.TextBox11).Width = 11f / 16f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Height = 3f / 16f;
    ((ARControl) this.TextBox12).Left = 189f / 16f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox12.Text = "Title";
    ((ARControl) this.TextBox12).Top = 0.125f;
    ((ARControl) this.TextBox12).Visible = false;
    ((ARControl) this.TextBox12).Width = 11f / 16f;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Height = 3f / 16f;
    ((ARControl) this.TextBox13).Left = 12.5f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; ";
    this.TextBox13.Text = "Email Address";
    ((ARControl) this.TextBox13).Top = 0.125f;
    ((ARControl) this.TextBox13).Visible = false;
    ((ARControl) this.TextBox13).Width = 15f / 16f;
    this.Detail1.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox18,
      (ARControl) this.TextBox19,
      (ARControl) this.TextBox20,
      (ARControl) this.TextBox21,
      (ARControl) this.TextBox22,
      (ARControl) this.TextBox23,
      (ARControl) this.TextBox24,
      (ARControl) this.TextBox25,
      (ARControl) this.TextBox26
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Height = 7f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1).Name = "Detail1";
    ((ARControl) this.TextBox14).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox14).DataField = "Description";
    ((ARControl) this.TextBox14).Height = 3f / 16f;
    ((ARControl) this.TextBox14).Left = 0.0f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox14.Text = (string) null;
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Visible = false;
    ((ARControl) this.TextBox14).Width = 1f;
    ((ARControl) this.TextBox15).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).DataField = "ProducerName";
    ((ARControl) this.TextBox15).Height = 3f / 16f;
    ((ARControl) this.TextBox15).Left = 1f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox15.Text = (string) null;
    ((ARControl) this.TextBox15).Top = 0.0f;
    ((ARControl) this.TextBox15).Visible = false;
    ((ARControl) this.TextBox15).Width = 31f / 16f;
    ((ARControl) this.TextBox16).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).DataField = "Name";
    ((ARControl) this.TextBox16).Height = 3f / 16f;
    ((ARControl) this.TextBox16).Left = 47f / 16f;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox16.Text = (string) null;
    ((ARControl) this.TextBox16).Top = 0.0f;
    ((ARControl) this.TextBox16).Visible = false;
    ((ARControl) this.TextBox16).Width = 2f;
    ((ARControl) this.TextBox17).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).DataField = "Address1";
    ((ARControl) this.TextBox17).Height = 3f / 16f;
    ((ARControl) this.TextBox17).Left = 79f / 16f;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox17.Text = (string) null;
    ((ARControl) this.TextBox17).Top = 0.0f;
    ((ARControl) this.TextBox17).Visible = false;
    ((ARControl) this.TextBox17).Width = 27f / 16f;
    ((ARControl) this.TextBox18).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).DataField = "Address2";
    ((ARControl) this.TextBox18).Height = 3f / 16f;
    ((ARControl) this.TextBox18).Left = 6.625f;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox18.Text = (string) null;
    ((ARControl) this.TextBox18).Top = 0.0f;
    ((ARControl) this.TextBox18).Visible = false;
    ((ARControl) this.TextBox18).Width = 21f / 16f;
    ((ARControl) this.TextBox19).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox19).DataField = "City";
    ((ARControl) this.TextBox19).Height = 3f / 16f;
    ((ARControl) this.TextBox19).Left = (float) sbyte.MaxValue / 16f;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox19.Text = (string) null;
    ((ARControl) this.TextBox19).Top = 0.0f;
    ((ARControl) this.TextBox19).Visible = false;
    ((ARControl) this.TextBox19).Width = 0.75f;
    ((ARControl) this.TextBox20).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox20).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox20).DataField = "State";
    ((ARControl) this.TextBox20).Height = 3f / 16f;
    ((ARControl) this.TextBox20).Left = 139f / 16f;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox20.Text = (string) null;
    ((ARControl) this.TextBox20).Top = 0.0f;
    ((ARControl) this.TextBox20).Visible = false;
    ((ARControl) this.TextBox20).Width = 7f / 16f;
    ((ARControl) this.TextBox21).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox21).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox21).DataField = "ZipCode";
    ((ARControl) this.TextBox21).Height = 3f / 16f;
    ((ARControl) this.TextBox21).Left = 9.125f;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox21.Text = (string) null;
    ((ARControl) this.TextBox21).Top = 0.0f;
    ((ARControl) this.TextBox21).Visible = false;
    ((ARControl) this.TextBox21).Width = 0.625f;
    ((ARControl) this.TextBox22).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).DataField = "Salutation";
    ((ARControl) this.TextBox22).Height = 3f / 16f;
    ((ARControl) this.TextBox22).Left = 9.75f;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox22.Text = (string) null;
    ((ARControl) this.TextBox22).Top = 0.0f;
    ((ARControl) this.TextBox22).Visible = false;
    ((ARControl) this.TextBox22).Width = 11f / 16f;
    ((ARControl) this.TextBox23).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox23).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).DataField = "FName";
    ((ARControl) this.TextBox23).Height = 3f / 16f;
    ((ARControl) this.TextBox23).Left = 167f / 16f;
    ((ARControl) this.TextBox23).Name = "TextBox23";
    this.TextBox23.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; vertical-align: top; ";
    this.TextBox23.Text = (string) null;
    ((ARControl) this.TextBox23).Top = 0.0f;
    ((ARControl) this.TextBox23).Visible = false;
    ((ARControl) this.TextBox23).Width = 11f / 16f;
    ((ARControl) this.TextBox24).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox24).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox24).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox24).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox24).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).DataField = "LName";
    ((ARControl) this.TextBox24).Height = 3f / 16f;
    ((ARControl) this.TextBox24).Left = 11.125f;
    ((ARControl) this.TextBox24).Name = "TextBox24";
    this.TextBox24.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox24.Text = (string) null;
    ((ARControl) this.TextBox24).Top = 0.0f;
    ((ARControl) this.TextBox24).Visible = false;
    ((ARControl) this.TextBox24).Width = 11f / 16f;
    ((ARControl) this.TextBox25).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox25).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox25).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox25).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox25).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).DataField = "Title";
    ((ARControl) this.TextBox25).Height = 3f / 16f;
    ((ARControl) this.TextBox25).Left = 189f / 16f;
    ((ARControl) this.TextBox25).Name = "TextBox25";
    this.TextBox25.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox25.Text = (string) null;
    ((ARControl) this.TextBox25).Top = 0.0f;
    ((ARControl) this.TextBox25).Visible = false;
    ((ARControl) this.TextBox25).Width = 11f / 16f;
    ((ARControl) this.TextBox26).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox26).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox26).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox26).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox26).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).DataField = "Email";
    ((ARControl) this.TextBox26).Height = 3f / 16f;
    ((ARControl) this.TextBox26).Left = 12.5f;
    ((ARControl) this.TextBox26).Name = "TextBox26";
    this.TextBox26.Style = "ddo-char-set: 0; font-weight: normal; font-size: 9.75pt; ";
    this.TextBox26.Text = (string) null;
    ((ARControl) this.TextBox26).Top = 0.0f;
    ((ARControl) this.TextBox26).Visible = false;
    ((ARControl) this.TextBox26).Width = 15f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.ReportInfo1
    });
    this.PageFooter1.Height = 0.2604167f;
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
    ((ARControl) this.ReportInfo1).Height = 3f / 16f;
    ((ARControl) this.ReportInfo1).Left = 173f / 16f;
    ((ARControl) this.ReportInfo1).Name = "ReportInfo1";
    this.ReportInfo1.Style = "text-align: right; ";
    ((ARControl) this.ReportInfo1).Top = 1f / 16f;
    ((ARControl) this.ReportInfo1).Width = 2.625f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13
    });
    this.GroupHeader1.Height = 11f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
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
    this.PrintWidth = 13.54167f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.TextBox23).EndInit();
    ((ISupportInitialize) this.TextBox24).EndInit();
    ((ISupportInitialize) this.TextBox25).EndInit();
    ((ISupportInitialize) this.TextBox26).EndInit();
    ((ISupportInitialize) this.ReportInfo1).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail1")]
  private virtual Detail Detail1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  internal virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  internal virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  internal virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  internal virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  internal virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  internal virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  internal virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  internal virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  internal virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  internal virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  internal virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox13")]
  internal virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox14")]
  internal virtual TextBox TextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox15")]
  internal virtual TextBox TextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox16")]
  internal virtual TextBox TextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox17")]
  internal virtual TextBox TextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox18")]
  internal virtual TextBox TextBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox19")]
  internal virtual TextBox TextBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox20")]
  internal virtual TextBox TextBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox21")]
  internal virtual TextBox TextBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox22")]
  internal virtual TextBox TextBox22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox23")]
  internal virtual TextBox TextBox23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox24")]
  internal virtual TextBox TextBox24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox25")]
  internal virtual TextBox TextBox25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox26")]
  internal virtual TextBox TextBox26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  internal virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  internal virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo1")]
  internal virtual ReportInfo ReportInfo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rpt_ActiveProducerList()
  {
    this.ReportStart += new EventHandler(this.rpt_ActiveProducerList_ReportStart);
    this.InitializeComponent();
  }

  private void rpt_ActiveProducerList_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.ShowPageNumbers();
    this._ds = DefaultDatabase.ExecuteDataSet("rpt_ActiveProducer");
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._ds.Tables[0], SaveFileTo);
  }

  public override bool HasRecords => this._ds.Tables[0].Rows.Count > 1;
}
