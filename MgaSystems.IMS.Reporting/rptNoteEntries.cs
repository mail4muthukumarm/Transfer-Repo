// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptNoteEntries
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
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

[SecureReportResource("{61A96FCE-1AE6-4a47-9719-ED953672B652}", "Note Entries report", "Displays Note Entries.", "General")]
public class rptNoteEntries : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{61A96FCE-1AE6-4a47-9719-ED953672B652}";
  private Label lblTitle;
  private Label Label2;
  private Label Label6;
  private Label Label7;
  private Label Label9;
  private Label Label17;
  private TextBox txtEffectiveDate;
  private TextBox txtControlNo;
  private TextBox txtLineName;
  private TextBox txtDescription;
  private DataTable _dt;
  private readonly DateTime _DateFrom;
  private readonly DateTime _DateTo;
  private readonly int _TypeID;

  [field: AccessedThroughProperty("txtPolicyNumber")]
  private virtual TextBox txtPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  private virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("GroupHeader1")]
  internal virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  internal virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox4")]
  private virtual TextBox TextBox4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtExpirationDate")]
  private virtual TextBox txtExpirationDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  public rptNoteEntries() => this.ReportStart += new EventHandler(this.rptNoteEntries_ReportStart);

  public rptNoteEntries(DateTime DateFrom, DateTime DateTo, int TypeID)
  {
    this.ReportStart += new EventHandler(this.rptNoteEntries_ReportStart);
    this.InitializeComponent();
    this._DateFrom = DateFrom;
    this._DateTo = DateTo;
    this._TypeID = TypeID;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptNoteEntries));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.txtEffectiveDate = new TextBox();
    this.txtControlNo = new TextBox();
    this.txtLineName = new TextBox();
    this.txtDescription = new TextBox();
    this.txtPolicyNumber = new TextBox();
    this.txtExpirationDate = new TextBox();
    this.lblTitle = new Label();
    this.Label2 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label9 = new Label();
    this.Label17 = new Label();
    this.Label19 = new Label();
    this.PageHeader1 = new PageHeader();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label8 = new Label();
    this.PageFooter1 = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.Label10 = new Label();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.txtEffectiveDate).BeginInit();
    ((ISupportInitialize) this.txtControlNo).BeginInit();
    ((ISupportInitialize) this.txtLineName).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    ((ISupportInitialize) this.txtExpirationDate).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "Subject";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 6.25f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 1f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "NoteBody";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 117f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 1.5f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "CreatedDate";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 8.875f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 9f / 16f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "CreatedBY";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 9.5f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "ddo-char-set: 0; text-align: left; font-size: 6.75pt; ";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.625f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox5).DataField = "LocationName";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 163f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "color: White; ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 35f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "UnderWriter";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 10.25f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "color: White; ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 0.875f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "LineName";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 165f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "color: White; ddo-char-set: 0; text-align: left; font-size: 6.75pt; ";
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 13f / 16f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "Description";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 5.25f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 15f / 16f;
    ((ARControl) this.txtEffectiveDate).Border.BottomColor = Color.Black;
    ((ARControl) this.txtEffectiveDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtEffectiveDate).Border.LeftColor = Color.Black;
    ((ARControl) this.txtEffectiveDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtEffectiveDate).Border.RightColor = Color.Black;
    ((ARControl) this.txtEffectiveDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtEffectiveDate).Border.TopColor = Color.Black;
    ((ARControl) this.txtEffectiveDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtEffectiveDate).DataField = "LineName";
    ((ARControl) this.txtEffectiveDate).Height = 0.125f;
    ((ARControl) this.txtEffectiveDate).Left = 39f / 16f;
    ((ARControl) this.txtEffectiveDate).Name = "txtEffectiveDate";
    this.txtEffectiveDate.OutputFormat = resourceManager.GetString("txtEffectiveDate.OutputFormat");
    this.txtEffectiveDate.Style = "ddo-char-set: 0; text-align: left; font-size: 6.75pt; ";
    this.txtEffectiveDate.Text = " ";
    ((ARControl) this.txtEffectiveDate).Top = 0.0f;
    ((ARControl) this.txtEffectiveDate).Width = 0.75f;
    ((ARControl) this.txtControlNo).Border.BottomColor = Color.Black;
    ((ARControl) this.txtControlNo).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtControlNo).Border.LeftColor = Color.Black;
    ((ARControl) this.txtControlNo).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtControlNo).Border.RightColor = Color.Black;
    ((ARControl) this.txtControlNo).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtControlNo).Border.TopColor = Color.Black;
    ((ARControl) this.txtControlNo).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtControlNo).DataField = "ControlNo";
    ((ARControl) this.txtControlNo).Height = 0.125f;
    ((ARControl) this.txtControlNo).Left = 0.0f;
    ((ARControl) this.txtControlNo).Name = "txtControlNo";
    this.txtControlNo.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtControlNo.Text = " ";
    ((ARControl) this.txtControlNo).Top = 0.0f;
    ((ARControl) this.txtControlNo).Width = 9f / 16f;
    ((ARControl) this.txtLineName).Border.BottomColor = Color.Black;
    ((ARControl) this.txtLineName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLineName).Border.LeftColor = Color.Black;
    ((ARControl) this.txtLineName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLineName).Border.RightColor = Color.Black;
    ((ARControl) this.txtLineName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLineName).Border.TopColor = Color.Black;
    ((ARControl) this.txtLineName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtLineName).DataField = "Premium";
    ((ARControl) this.txtLineName).Height = 0.125f;
    ((ARControl) this.txtLineName).Left = 59f / 16f;
    ((ARControl) this.txtLineName).Name = "txtLineName";
    this.txtLineName.OutputFormat = resourceManager.GetString("txtLineName.OutputFormat");
    this.txtLineName.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.txtLineName.Text = " ";
    ((ARControl) this.txtLineName).Top = 0.0f;
    ((ARControl) this.txtLineName).Width = 0.625f;
    ((ARControl) this.txtDescription).Border.BottomColor = Color.Black;
    ((ARControl) this.txtDescription).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDescription).Border.LeftColor = Color.Black;
    ((ARControl) this.txtDescription).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDescription).Border.RightColor = Color.Black;
    ((ARControl) this.txtDescription).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDescription).Border.TopColor = Color.Black;
    ((ARControl) this.txtDescription).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDescription).DataField = "UnderWriter";
    ((ARControl) this.txtDescription).Height = 0.125f;
    ((ARControl) this.txtDescription).Left = 4.375f;
    ((ARControl) this.txtDescription).Name = "txtDescription";
    this.txtDescription.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtDescription.Text = " ";
    ((ARControl) this.txtDescription).Top = 0.0f;
    ((ARControl) this.txtDescription).Width = 13f / 16f;
    ((ARControl) this.txtPolicyNumber).Border.BottomColor = Color.Black;
    ((ARControl) this.txtPolicyNumber).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.LeftColor = Color.Black;
    ((ARControl) this.txtPolicyNumber).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.RightColor = Color.Black;
    ((ARControl) this.txtPolicyNumber).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).Border.TopColor = Color.Black;
    ((ARControl) this.txtPolicyNumber).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNumber).DataField = "LocationName";
    ((ARControl) this.txtPolicyNumber).Height = 0.125f;
    ((ARControl) this.txtPolicyNumber).Left = 0.625f;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtPolicyNumber.Text = (string) null;
    ((ARControl) this.txtPolicyNumber).Top = 0.0f;
    ((ARControl) this.txtPolicyNumber).Width = 1.75f;
    ((ARControl) this.txtExpirationDate).Border.BottomColor = Color.Black;
    ((ARControl) this.txtExpirationDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExpirationDate).Border.LeftColor = Color.Black;
    ((ARControl) this.txtExpirationDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExpirationDate).Border.RightColor = Color.Black;
    ((ARControl) this.txtExpirationDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExpirationDate).Border.TopColor = Color.Black;
    ((ARControl) this.txtExpirationDate).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtExpirationDate).DataField = "Type";
    ((ARControl) this.txtExpirationDate).Height = 0.125f;
    ((ARControl) this.txtExpirationDate).Left = 3.25f;
    ((ARControl) this.txtExpirationDate).Name = "txtExpirationDate";
    this.txtExpirationDate.OutputFormat = resourceManager.GetString("txtExpirationDate.OutputFormat");
    this.txtExpirationDate.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.txtExpirationDate.Text = " ";
    ((ARControl) this.txtExpirationDate).Top = 0.0f;
    ((ARControl) this.txtExpirationDate).Width = 0.375f;
    ((ARControl) this.lblTitle).Border.BottomColor = Color.Black;
    ((ARControl) this.lblTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.LeftColor = Color.Black;
    ((ARControl) this.lblTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.RightColor = Color.Black;
    ((ARControl) this.lblTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Border.TopColor = Color.Black;
    ((ARControl) this.lblTitle).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblTitle).Height = 0.25f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "text-align: center; font-size: 14pt; ";
    this.lblTitle.Text = "Note Entries report";
    ((ARControl) this.lblTitle).Top = 49f / 16f;
    ((ARControl) this.lblTitle).Visible = false;
    ((ARControl) this.lblTitle).Width = 163f / 16f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 5f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.625f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label2.Text = "Location Name";
    ((ARControl) this.Label2).Top = 59f / 16f;
    ((ARControl) this.Label2).Visible = false;
    ((ARControl) this.Label2).Width = 1.75f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 5f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 59f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label6.Text = "Premium";
    ((ARControl) this.Label6).Top = 59f / 16f;
    ((ARControl) this.Label6).Visible = false;
    ((ARControl) this.Label6).Width = 0.625f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 5f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 39f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label7.Text = "Line Name";
    ((ARControl) this.Label7).Top = 59f / 16f;
    ((ARControl) this.Label7).Visible = false;
    ((ARControl) this.Label7).Width = 0.75f;
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 5f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.0f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label9.Text = "Control #";
    ((ARControl) this.Label9).Top = 59f / 16f;
    ((ARControl) this.Label9).Visible = false;
    ((ARControl) this.Label9).Width = 9f / 16f;
    ((ARControl) this.Label17).Border.BottomColor = Color.Black;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.LeftColor = Color.Black;
    ((ARControl) this.Label17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.RightColor = Color.Black;
    ((ARControl) this.Label17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Border.TopColor = Color.Black;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label17).Height = 5f / 16f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 4.375f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label17.Text = "Under Writer";
    ((ARControl) this.Label17).Top = 59f / 16f;
    ((ARControl) this.Label17).Visible = false;
    ((ARControl) this.Label17).Width = 13f / 16f;
    ((ARControl) this.Label19).Border.BottomColor = Color.Black;
    ((ARControl) this.Label19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label19).Border.LeftColor = Color.Black;
    ((ARControl) this.Label19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.RightColor = Color.Black;
    ((ARControl) this.Label19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.TopColor = Color.Black;
    ((ARControl) this.Label19).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Height = 5f / 16f;
    this.Label19.HyperLink = (string) null;
    ((ARControl) this.Label19).Left = 3.25f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label19.Text = "Policy Type";
    ((ARControl) this.Label19).Top = 59f / 16f;
    ((ARControl) this.Label19).Visible = false;
    ((ARControl) this.Label19).Width = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.Label9,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label2,
      (ARControl) this.Label17,
      (ARControl) this.Label19,
      (ARControl) this.lblTitle,
      (ARControl) this.Label1,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label8,
      (ARControl) this.Label10
    });
    this.PageHeader1.Height = 4.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 5f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 6.25f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label1.Text = "Subject";
    ((ARControl) this.Label1).Top = 59f / 16f;
    ((ARControl) this.Label1).Visible = false;
    ((ARControl) this.Label1).Width = 1f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 5f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 117f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label3.Text = "Note Message";
    ((ARControl) this.Label3).Top = 59f / 16f;
    ((ARControl) this.Label3).Visible = false;
    ((ARControl) this.Label3).Width = 1.5f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 5f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 8.875f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label4.Text = "Created     Date";
    ((ARControl) this.Label4).Top = 59f / 16f;
    ((ARControl) this.Label4).Visible = false;
    ((ARControl) this.Label4).Width = 9f / 16f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 5f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 9.5f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label5.Text = "Created     By";
    ((ARControl) this.Label5).Top = 59f / 16f;
    ((ARControl) this.Label5).Visible = false;
    ((ARControl) this.Label5).Width = 0.625f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Height = 5f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 5.25f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label8.Text = "Note Type";
    ((ARControl) this.Label8).Top = 59f / 16f;
    ((ARControl) this.Label8).Visible = false;
    ((ARControl) this.Label8).Width = 15f / 16f;
    this.PageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[6]
    {
      (ARControl) this.txtDescription,
      (ARControl) this.txtPolicyNumber,
      (ARControl) this.txtEffectiveDate,
      (ARControl) this.txtExpirationDate,
      (ARControl) this.txtLineName,
      (ARControl) this.txtControlNo
    });
    this.GroupHeader1.DataField = "ControlNo";
    this.GroupHeader1.GroupKeepTogether = (GroupKeepTogether) 1;
    this.GroupHeader1.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.UnderlayNext = true;
    this.GroupFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.Label10).Border.BottomColor = Color.Black;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftColor = Color.Black;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightColor = Color.Black;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopColor = Color.Black;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Height = 19f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 0.5f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "ddo-char-set: 0; text-align: center; font-size: 24pt; vertical-align: middle; ";
    this.Label10.Text = "EXPORT TO EXCEL";
    ((ARControl) this.Label10).Top = 5f / 16f;
    ((ARControl) this.Label10).Width = 8.75f;
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
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
    ((ISupportInitialize) this.txtEffectiveDate).EndInit();
    ((ISupportInitialize) this.txtControlNo).EndInit();
    ((ISupportInitialize) this.txtLineName).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
    ((ISupportInitialize) this.txtExpirationDate).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptNoteEntries_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.ShowPageNumbers();
    this.ShowPrintDateAndTime();
    object currentUserGuid = (object) DBNull.Value;
    if (SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid") && !this.CurrentUserGuid.Equals(Guid.Empty))
      currentUserGuid = (object) this.CurrentUserGuid;
    this._dt = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, nameof (rptNoteEntries), 0, (CommandArgumentType) 0, new object[8]
    {
      (object) "@DateFrom",
      (object) this._DateFrom,
      (object) "@DateTo",
      (object) this._DateTo,
      (object) "@NoteType",
      Interaction.IIf(this._TypeID != 0, (object) this._TypeID, (object) DBNull.Value),
      (object) "@CurrentUserGuid",
      currentUserGuid
    });
  }

  public override bool IsThreaded => true;

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DateRangePicker("Created Date:", false),
        (BaseReportControl) new GenericComboBox("Note Type", "SELECT 0 as sort, 0 As NoteTypeID, 'All Types' As Description UNION SELECT 1 as sort, NoteTypeID, Description FROM lstNoteTypes order by sort, Description", "NoteTypeID", "Description", typeof (int))
      };
    }
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  public override bool HasRecords => this._dt.Rows.Count > 0;

  private void PageHeader1_Format(object sender, EventArgs e)
  {
  }
}
