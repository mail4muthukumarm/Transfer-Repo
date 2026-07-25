// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptRenewalRetention
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{99A6C366-145B-4fb3-9C6E-3511564CE0CB}", "Renewal Retention Report", "Renewal Retention Report.", "General")]
public class rptRenewalRetention : MGAReport, IReport
{
  private Label Label;
  private TextBox TextBox;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label6;
  private Label Label7;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private DateTime _FromDate;
  private DateTime _ToDate;
  private DataTable _dt;

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  private virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  private virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  private virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  private virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox13")]
  private virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox14")]
  private virtual TextBox TextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label15")]
  private virtual Label Label15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox16")]
  private virtual TextBox TextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox15")]
  private virtual TextBox TextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptRenewalRetention));
    this.Detail = new Detail();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.TextBox14 = new TextBox();
    this.TextBox17 = new TextBox();
    this.TextBox18 = new TextBox();
    this.TextBox19 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.Label = new Label();
    this.TextBox = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.Label15 = new Label();
    this.TextBox16 = new TextBox();
    this.TextBox15 = new TextBox();
    this.TextBox20 = new TextBox();
    this.PageHeader = new PageHeader();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label5 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label1 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.PageFooter = new PageFooter();
    this.Label19 = new Label();
    this.TextBox21 = new TextBox();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[18]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox18,
      (ARControl) this.TextBox19,
      (ARControl) this.TextBox21
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox2).DataField = "InsuredPolicyName";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 2.510417f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 23f / 16f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox3).DataField = "ExpiringPolicyNumber";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 3.947917f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.875f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox4).DataField = "EffectiveDate";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 67f / 32f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.4166667f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox6).DataField = "LineName";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 0.25f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 17f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox7).DataField = "Renewal Underwriter";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 9.155001f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 1f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox8).DataField = "Type";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 0.0f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 0.25f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox9).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox9).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox9).DataField = "UserName";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 21f / 16f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 25f / 32f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox5).DataField = "Name";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 5.697917f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 1.770833f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox1).DataField = "RenewalPolicyNumber";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 4.822917f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.875f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox10).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox10).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox10).DataField = "Expiring Premium";
    ((ARControl) this.TextBox10).Height = 0.125f;
    ((ARControl) this.TextBox10).Left = 7.843f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox10.Text = (string) null;
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 9f / 16f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox11).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox11).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox11).DataField = "Renewal Premium";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 8.406f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 9f / 16f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox12).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox12).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox12).DataField = "DateIssued";
    ((ARControl) this.TextBox12).Height = 0.125f;
    ((ARControl) this.TextBox12).Left = 10.155f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox12.Text = (string) null;
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 0.4166667f;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox13).DataField = "Expiring Carrier";
    ((ARControl) this.TextBox13).Height = 0.125f;
    ((ARControl) this.TextBox13).Left = 10.572f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox13.Text = (string) null;
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Width = 1.01158f;
    ((ARControl) this.TextBox14).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).DataField = "Renewal Carrier";
    ((ARControl) this.TextBox14).Height = 0.125f;
    ((ARControl) this.TextBox14).Left = 11.584f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox14.Text = (string) null;
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Width = 0.9169997f;
    ((ARControl) this.TextBox17).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox17).DataField = "Expiring State of Issuance";
    ((ARControl) this.TextBox17).Height = 0.125f;
    ((ARControl) this.TextBox17).Left = 12.545f;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox17.Text = (string) null;
    ((ARControl) this.TextBox17).Top = 0.0f;
    ((ARControl) this.TextBox17).Width = 0.7410003f;
    ((ARControl) this.TextBox18).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).DataField = "Renewal State of Issuance";
    ((ARControl) this.TextBox18).Height = 0.125f;
    ((ARControl) this.TextBox18).Left = 13.256f;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox18.Text = (string) null;
    ((ARControl) this.TextBox18).Top = 0.0f;
    ((ARControl) this.TextBox18).Width = 0.8540003f;
    ((ARControl) this.TextBox19).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.LeftColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox19).Border.RightColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox19).Border.TopColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox19).DataField = "Annual Premium";
    ((ARControl) this.TextBox19).Height = 0.125f;
    ((ARControl) this.TextBox19).Left = 7.281f;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.OutputFormat = resourceManager.GetString("TextBox19.OutputFormat");
    this.TextBox19.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox19.Text = (string) null;
    ((ARControl) this.TextBox19).Top = 0.0f;
    ((ARControl) this.TextBox19).Width = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label,
      (ARControl) this.TextBox
    });
    this.ReportHeader.Height = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label).Height = 0.25f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 14.25pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.Label.Text = "Renewal Retention";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = 13.55208f;
    ((ARControl) this.TextBox).Height = 0.25f;
    ((ARControl) this.TextBox).Left = 0.0f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 12pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.TextBox.Text = "Date Range";
    ((ARControl) this.TextBox).Top = 5f / 16f;
    ((ARControl) this.TextBox).Width = 13.55208f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label15,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox20
    });
    this.ReportFooter.Height = 0.4583333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Height = 0.1770833f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 215f / 32f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label15.Text = "Total";
    ((ARControl) this.Label15).Top = 0.08333334f;
    ((ARControl) this.Label15).Width = 9f / 16f;
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox16).DataField = "Renewal Premium";
    ((ARControl) this.TextBox16).Height = 0.1770833f;
    ((ARControl) this.TextBox16).Left = 8.551001f;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = resourceManager.GetString("TextBox16.OutputFormat");
    this.TextBox16.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox16.SummaryRunning = (SummaryRunning) 2;
    this.TextBox16.SummaryType = (SummaryType) 1;
    this.TextBox16.Text = (string) null;
    ((ARControl) this.TextBox16).Top = 0.083f;
    ((ARControl) this.TextBox16).Width = 0.6354167f;
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox15).DataField = "Expiring Premium";
    ((ARControl) this.TextBox15).Height = 0.1770833f;
    ((ARControl) this.TextBox15).Left = 7.916f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = resourceManager.GetString("TextBox15.OutputFormat");
    this.TextBox15.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox15.SummaryRunning = (SummaryRunning) 2;
    this.TextBox15.SummaryType = (SummaryType) 1;
    this.TextBox15.Text = (string) null;
    ((ARControl) this.TextBox15).Top = 0.083f;
    ((ARControl) this.TextBox15).Width = 0.6354167f;
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).DataField = "Annual Premium";
    ((ARControl) this.TextBox20).Height = 0.1770833f;
    ((ARControl) this.TextBox20).Left = 7.281f;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = resourceManager.GetString("TextBox20.OutputFormat");
    this.TextBox20.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox20.SummaryRunning = (SummaryRunning) 2;
    this.TextBox20.SummaryType = (SummaryType) 1;
    this.TextBox20.Text = (string) null;
    ((ARControl) this.TextBox20).Top = 0.083f;
    ((ARControl) this.TextBox20).Width = 0.6354167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[18]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label5,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label1,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label16,
      (ARControl) this.Label17,
      (ARControl) this.Label18,
      (ARControl) this.Label19
    });
    this.PageHeader.Height = 0.2708333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 0.2604167f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 2.510417f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label2.Text = "Insured";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 23f / 16f;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 0.2604167f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 3.947917f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label3.Text = "Expiring Policy #";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 0.875f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 0.2604167f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 67f / 32f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label4.Text = "Eff Date";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 0.4166667f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 0.2604167f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.25f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label6.Text = "Line of Business";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 17f / 16f;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Height = 0.2604167f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 9.155001f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label7.Text = "Renewal Underwriter";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 1f;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Height = 0.2604167f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.0f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label8.Text = "Type";
    ((ARControl) this.Label8).Top = 0.0f;
    ((ARControl) this.Label8).Width = 0.25f;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Height = 0.2604167f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 21f / 16f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label9.Text = "User Name";
    ((ARControl) this.Label9).Top = 0.0f;
    ((ARControl) this.Label9).Width = 25f / 32f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 0.2604167f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 5.697917f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label5.Text = "Producer Location Name";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 1.770833f;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Height = 0.2604167f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 8.031f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label10.Text = "Expiring Premium";
    ((ARControl) this.Label10).Top = 0.0f;
    ((ARControl) this.Label10).Width = 9f / 16f;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Height = 0.2604167f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 8.593f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label11.Text = "Renewal Premium";
    ((ARControl) this.Label11).Top = 0.0f;
    ((ARControl) this.Label11).Width = 9f / 16f;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 0.2604167f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 4.822917f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label1.Text = "Renewal Policy #";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 0.875f;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Height = 0.2604167f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 10.155f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label12.Text = "Date Issued";
    ((ARControl) this.Label12).Top = 0.0f;
    ((ARControl) this.Label12).Width = 0.4166667f;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Height = 0.2604167f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 10.572f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label13.Text = "Expiring Carrier";
    ((ARControl) this.Label13).Top = 0.0f;
    ((ARControl) this.Label13).Width = 1.01158f;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Height = 0.2604167f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 11.584f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label14.Text = "Renewal Carrier";
    ((ARControl) this.Label14).Top = 0.0f;
    ((ARControl) this.Label14).Width = 0.9169997f;
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label16).Height = 0.2604167f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 12.545f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label16.Text = "Expiring State";
    ((ARControl) this.Label16).Top = 0.0f;
    ((ARControl) this.Label16).Width = 0.7410003f;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Height = 0.2604167f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 13.256f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label17.Text = "Renewal State";
    ((ARControl) this.Label17).Top = 0.0f;
    ((ARControl) this.Label17).Width = 0.8540003f;
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Height = 0.2604167f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 7.469f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label18.Text = "Annual Premium";
    ((ARControl) this.Label18).Top = 0.005f;
    ((ARControl) this.Label18).Width = 9f / 16f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((ARControl) this.Label19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Height = 0.2604167f;
    this.Label19.HyperLink = (string) null;
    ((ARControl) this.Label19).Left = 14.11f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label19.Text = "Location Code";
    ((ARControl) this.Label19).Top = 0.005f;
    ((ARControl) this.Label19).Width = 0.854f;
    ((ARControl) this.TextBox21).Border.BottomColor = Color.FromArgb(192 /*0xC0*/, 192 /*0xC0*/, 192 /*0xC0*/);
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).DataField = "LocationCode";
    ((ARControl) this.TextBox21).Height = 0.125f;
    ((ARControl) this.TextBox21).Left = 14.11f;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox21.Text = (string) null;
    ((ARControl) this.TextBox21).Top = 0.0f;
    ((ARControl) this.TextBox21).Width = 0.854f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.2086614f;
    this.PageSettings.Margins.Right = 0.2086614f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 14f;
    this.PageSettings.PaperKind = PaperKind.Legal;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 15.04492f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("TextBox17")]
  private virtual TextBox TextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox18")]
  private virtual TextBox TextBox18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label16")]
  private virtual Label Label16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  private virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  private virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox19")]
  private virtual TextBox TextBox19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox20")]
  private virtual TextBox TextBox20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox21")]
  private virtual TextBox TextBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  private virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptRenewalRetention()
  {
    this.ReportStart += new EventHandler(this.rptRenewalRentention_ReportStart);
    this.InitializeComponent();
  }

  public rptRenewalRetention(DateTime FromDate, DateTime ToDate)
  {
    this.ReportStart += new EventHandler(this.rptRenewalRentention_ReportStart);
    this.InitializeComponent();
    this._FromDate = FromDate;
    this._ToDate = ToDate;
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[1]
      {
        (BaseReportControl) new DateRangePicker("Expiration Date:", false)
      };
    }
  }

  public override bool IsThreaded => true;

  private void rptRenewalRentention_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    if (!this.CurrentUserGuid.Equals((object) string.Empty) && SystemSettings.GetSetting<bool>("CheckQuotingOfficeGuid"))
      this._dt = DefaultDatabase.ExecuteDataTable("dbo.rptRenewalRentention", new object[6]
      {
        (object) "@ExpirationDateFrom",
        (object) this._FromDate,
        (object) "@ExpirationDateTo",
        (object) this._ToDate,
        (object) "@CurrentUserGuid",
        (object) this.CurrentUserGuid
      });
    else
      this._dt = DefaultDatabase.ExecuteDataTable("dbo.rptRenewalRentention", new object[4]
      {
        (object) "@ExpirationDateFrom",
        (object) this._FromDate,
        (object) "@ExpirationDateTo",
        (object) this._ToDate
      });
    this.DataSource = (object) this._dt;
    this.TextBox.Text = $"{this._FromDate.ToShortDateString()} - {this._ToDate.ToShortDateString()}";
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }
}
