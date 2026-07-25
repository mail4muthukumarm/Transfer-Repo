// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptPrintDriverInfo
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class rptPrintDriverInfo : MGAReport, IReport
{
  private Label Label3;
  private Label Label4;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private Guid _QuoteGuid;
  private int _ControlNo;
  private DataSet _ds;

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label")]
  private virtual Label Label { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  private virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  private virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual GroupHeader GroupHeader1
  {
    get => this._GroupHeader1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.GroupHeader1_Format);
      GroupHeader groupHeader1_1 = this._GroupHeader1;
      if (groupHeader1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) groupHeader1_1).Format -= eventHandler;
      this._GroupHeader1 = value;
      GroupHeader groupHeader1_2 = this._GroupHeader1;
      if (groupHeader1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) groupHeader1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("GroupFooter1")]
  internal virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  private virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptPrintDriverInfo));
    this.Detail = new Detail();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox12 = new TextBox();
    this.PageHeader = new PageHeader();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label = new Label();
    this.TextBox1 = new TextBox();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label10 = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label11 = new Label();
    this.Label9 = new Label();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.TextBox13 = new TextBox();
    this.Label12 = new Label();
    this.GroupFooter1 = new GroupFooter();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox12
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 5f / 32f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "LicenseNumber";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 2.708333f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1.135417f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "DOB";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 1.979167f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.7283465f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "FirstName";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 0.0f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 0.9895833f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "StateID";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 123f / 32f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.5f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "Status";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 139f / 32f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 13f / 16f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "LicenseExpDate";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 267f / 32f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 17f / 16f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "DateAdded";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 165f / 32f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox10.Text = (string) null;
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 0.7291667f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "ModifiedDate";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 233f / 32f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 17f / 16f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "LastName";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 0.9895833f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.002083302f;
    ((ARControl) this.TextBox7).Width = 0.988189f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "NumberOfPoints";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 5.885417f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 0.002083302f;
    ((ARControl) this.TextBox8).Width = 9f / 32f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "CpOnRenewal";
    ((ARControl) this.TextBox12).Height = 3f / 16f;
    ((ARControl) this.TextBox12).Left = 6.166667f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox12.Text = (string) null;
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 1.114583f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label,
      (ARControl) this.TextBox1,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label10,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label11,
      (ARControl) this.Label9
    });
    this.PageHeader.Height = 1.020833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 0.25f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 2.708333f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label3.Text = "License #";
    ((ARControl) this.Label3).Top = 0.75f;
    ((ARControl) this.Label3).Width = 1.135417f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 0.2519685f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 1.979167f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label4.Text = "DOB";
    ((ARControl) this.Label4).Top = 0.75f;
    ((ARControl) this.Label4).Width = 0.7283465f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 0.25f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 0.0f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label5.Text = "First Name";
    ((ARControl) this.Label5).Top = 0.75f;
    ((ARControl) this.Label5).Width = 0.9895833f;
    ((ARControl) this.Label).Border.BottomColor = Color.Black;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftColor = Color.Black;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightColor = Color.Black;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopColor = Color.Black;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; vertical-align: middle; ";
    this.Label.Text = "Driver Information";
    ((ARControl) this.Label).Top = 1f / 16f;
    ((ARControl) this.Label).Width = 9.39583f;
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
    this.TextBox1.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 9.75pt; vertical-align: middle; ";
    this.TextBox1.Text = "Policy# {0}";
    ((ARControl) this.TextBox1).Top = 5f / 16f;
    ((ARControl) this.TextBox1).Width = 9.395837f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 0.25f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 123f / 32f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label6.Text = "State ID";
    ((ARControl) this.Label6).Top = 0.75f;
    ((ARControl) this.Label6).Width = 0.5f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 0.25f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 139f / 32f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label7.Text = "Status";
    ((ARControl) this.Label7).Top = 0.75f;
    ((ARControl) this.Label7).Width = 13f / 16f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Height = 0.25f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 233f / 32f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label8.Text = "Date Modified";
    ((ARControl) this.Label8).Top = 0.75f;
    ((ARControl) this.Label8).Width = 17f / 16f;
    ((ARControl) this.Label10).Border.BottomColor = Color.Black;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.LeftColor = Color.Black;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightColor = Color.Black;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopColor = Color.Black;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Height = 0.25f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 165f / 32f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label10.Text = "Date Added";
    ((ARControl) this.Label10).Top = 0.75f;
    ((ARControl) this.Label10).Width = 0.7291667f;
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 0.2519685f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.9895833f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label1.Text = "Last Name";
    ((ARControl) this.Label1).Top = 0.75f;
    ((ARControl) this.Label1).Width = 0.988189f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 0.25f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 5.885417f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label2.Text = "Pts";
    ((ARControl) this.Label2).Top = 0.75f;
    ((ARControl) this.Label2).Width = 9f / 32f;
    ((ARControl) this.Label11).Border.BottomColor = Color.Black;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.LeftColor = Color.Black;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightColor = Color.Black;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopColor = Color.Black;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Height = 0.25f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 6.166667f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label11.Text = "Copy On Renewal";
    ((ARControl) this.Label11).Top = 0.75f;
    ((ARControl) this.Label11).Width = 1.114583f;
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 0.25f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 267f / 32f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
    this.Label9.Text = "Lic. Exp. Date";
    ((ARControl) this.Label9).Top = 0.75f;
    ((ARControl) this.Label9).Width = 17f / 16f;
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.TextBox13,
      (ARControl) this.Label12
    });
    this.GroupHeader1.DataField = "DriverDeleted";
    this.GroupHeader1.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.TextBox13).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "DriverDeleted";
    ((ARControl) this.TextBox13).Height = 3f / 16f;
    ((ARControl) this.TextBox13).Left = 0.0f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "ddo-char-set: 0; text-align: center; background-color: Yellow; font-size: 8.25pt; vertical-align: middle; ";
    this.TextBox13.Text = (string) null;
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Visible = false;
    ((ARControl) this.TextBox13).Width = 9f / 32f;
    ((ARControl) this.Label12).Border.BottomColor = Color.Black;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Border.LeftColor = Color.Black;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightColor = Color.Black;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopColor = Color.Black;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 0.0f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "text-align: center; font-weight: bold; ";
    this.Label12.Text = "";
    ((ARControl) this.Label12).Top = 0.0f;
    ((ARControl) this.Label12).Width = 9.395833f;
    this.GroupFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.GroupFooter1.NewPage = (NewPage) 2;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.1968504f;
    this.PageSettings.Margins.Right = 0.1968504f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 151f / 16f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  [field: AccessedThroughProperty("TextBox13")]
  private virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptPrintDriverInfo()
  {
    this.ReportStart += new EventHandler(this.rptPrintDriverInfo_ReportStart);
    this.PageHeader = (PageHeader) null;
    this.Detail = (Detail) null;
    this.PageFooter = (PageFooter) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.TextBox4 = (TextBox) null;
    this.TextBox5 = (TextBox) null;
    this.InitializeComponent();
  }

  public rptPrintDriverInfo(Guid quoteGuid, int controlNo)
  {
    this.ReportStart += new EventHandler(this.rptPrintDriverInfo_ReportStart);
    this.PageHeader = (PageHeader) null;
    this.Detail = (Detail) null;
    this.PageFooter = (PageFooter) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.TextBox4 = (TextBox) null;
    this.TextBox5 = (TextBox) null;
    this.InitializeComponent();
    this._ControlNo = controlNo;
    this._QuoteGuid = quoteGuid;
  }

  public rptPrintDriverInfo(int controlNo)
  {
    this.ReportStart += new EventHandler(this.rptPrintDriverInfo_ReportStart);
    this.PageHeader = (PageHeader) null;
    this.Detail = (Detail) null;
    this.PageFooter = (PageFooter) null;
    this.Label3 = (Label) null;
    this.Label4 = (Label) null;
    this.TextBox4 = (TextBox) null;
    this.TextBox5 = (TextBox) null;
    this.InitializeComponent();
    this._ControlNo = controlNo;
  }

  private void rptPrintDriverInfo_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._ds = new DataSet();
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbCommand command = DefaultDatabase.CreateCommand(nameof (rptPrintDriverInfo), dbConnection))
      {
        using (DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter(command))
        {
          command.CommandType = CommandType.StoredProcedure;
          DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@QuoteGuid", (object) this._QuoteGuid);
          if (this._ControlNo != 0)
            DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@ControlNo", (object) this._ControlNo);
          DefaultDatabase.DataAdapterFill(dataAdapter, this._ds);
        }
      }
    }
    if (this._ds.Tables[0].Rows.Count > 0)
      this.TextBox1.Text = string.Format(this.TextBox1.Text, RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[0][0]));
    else
      ((ARControl) this.TextBox1).Visible = false;
    this.DataSource = (object) this._ds.Tables[1];
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls => (BaseReportControl[]) null;

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._ds.Tables[1], SaveFileTo);
  }

  private void GroupHeader1_Format(object sender, EventArgs e)
  {
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.TextBox13.Text, "1", false) == 0)
      this.Label12.Text = "Deleted Drivers";
    else
      this.Label12.Text = "Active Drivers";
  }
}
