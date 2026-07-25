// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptUnprintedPolicies
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
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
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{4F7FFE7B-5363-4709-ABA8-9FCC131F997F}", "Unprinted Policies", "Shows a list of policies that have not yet been printed.", "General")]
public class rptUnprintedPolicies : MGAReport, IReport
{
  private Label Label;
  private TextBox TextBox;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
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

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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
        ((Section) detail1).BeforePrint -= eventHandler;
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((Section) detail2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptUnprintedPolicies));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.Label = new Label();
    this.TextBox = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.PageFooter = new PageFooter();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
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
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9
    });
    ((Section) this.Detail).Height = 0.1354167f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "ControlNo";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 9f / 16f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "InsuredName";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 9f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 23f / 16f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "PolicyNumber";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 65f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.875f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "EffectiveDate";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 79f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.75f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "ExpirationDate";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 91f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 13f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "LineName";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 2f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 17f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "Underwriter";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 49f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 1f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "dateBound";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 6.5f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 11f / 16f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "BasePremium";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 115f / 16f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 11f / 16f;
    ((Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label,
      (ARControl) this.TextBox
    });
    this.ReportHeader.Height = 9f / 16f;
    ((Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label).Border.BottomColor = Color.Black;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftColor = Color.Black;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightColor = Color.Black;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopColor = Color.Black;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Height = 0.25f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 14.25pt; ";
    this.Label.Text = "Unprinted Policy Report";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = (float) sbyte.MaxValue / 16f;
    ((ARControl) this.TextBox).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Height = 0.25f;
    ((ARControl) this.TextBox).Left = 0.0f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; ";
    this.TextBox.Text = "Date Range";
    ((ARControl) this.TextBox).Top = 5f / 16f;
    ((ARControl) this.TextBox).Width = (float) sbyte.MaxValue / 16f;
    this.ReportFooter.Height = 0.0f;
    ((Section) this.ReportFooter).Name = "ReportFooter";
    ((Section) this.PageHeader).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9
    });
    this.PageHeader.Height = 3f / 16f;
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
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label1.Text = "Control #";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 9f / 16f;
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
    ((ARControl) this.Label2).Left = 9f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label2.Text = "Insured";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 23f / 16f;
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
    ((ARControl) this.Label3).Left = 65f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label3.Text = "Policy #";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 0.875f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 79f / 16f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label4.Text = "Effective Date";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 0.75f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 91f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label5.Text = "Expiration Date";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 13f / 16f;
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
    ((ARControl) this.Label6).Left = 2f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label6.Text = "Line of Business";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 17f / 16f;
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
    ((ARControl) this.Label7).Left = 49f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "ddo-char-set: 0; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label7.Text = "Underwriter";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 1f;
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
    ((ARControl) this.Label8).Left = 6.5f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label8.Text = "Bound Date ";
    ((ARControl) this.Label8).Top = 0.0f;
    ((ARControl) this.Label8).Width = 11f / 16f;
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 115f / 16f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 6.75pt; vertical-align: bottom; ";
    this.Label9.Text = "Base Premium";
    ((ARControl) this.Label9).Top = 0.0f;
    ((ARControl) this.Label9).Width = 11f / 16f;
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
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public rptUnprintedPolicies()
  {
    this.ReportStart += new EventHandler(this.rptUnprintedPolicies_ReportStart);
    this.InitializeComponent();
  }

  public rptUnprintedPolicies(DateTime FromDate, DateTime ToDate)
  {
    this.ReportStart += new EventHandler(this.rptUnprintedPolicies_ReportStart);
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
        (BaseReportControl) new DateRangePicker("Date Range", false)
      };
    }
  }

  public override bool IsThreaded => true;

  private void rptUnprintedPolicies_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    if (!this.CurrentUserGuid.Equals((object) string.Empty) && SystemSettings.GetSetting<bool>("CheckQuotingOfficeGuid"))
      this._dt = DefaultDatabase.ExecuteDataTable("dbo.rptUnprintedPolicies", new object[6]
      {
        (object) "@FromDate",
        (object) this._FromDate,
        (object) "@ToDate",
        (object) this._ToDate,
        (object) "@CurrentUserGuid",
        (object) this.CurrentUserGuid
      });
    else
      this._dt = DefaultDatabase.ExecuteDataTable("dbo.rptUnprintedPolicies", new object[4]
      {
        (object) "@FromDate",
        (object) this._FromDate,
        (object) "@ToDate",
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
