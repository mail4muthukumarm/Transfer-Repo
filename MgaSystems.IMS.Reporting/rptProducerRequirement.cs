// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptProducerRequirement
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
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{3C016C5E-B9BF-433c-812E-9C1B0EEB719B}", "Producer Requirement", "Displays Producer Requirement", "General")]
public class rptProducerRequirement : MGAReport, IReport
{
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
  internal const string SecurityIDReportGuid = "{3C016C5E-B9BF-433c-812E-9C1B0EEB719B}";
  private DataTable _dt;
  private Guid _ProducerLocationGuid;
  private int _RequirementType;
  private DateTime _ValidAfterDate;
  private bool _ShowNotSubmitted;
  private string _sqlProc;

  [field: AccessedThroughProperty("txtPolicyNumber")]
  private virtual TextBox txtPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  private virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader1")]
  internal virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  internal virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  private virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox2")]
  private virtual TextBox TextBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptProducerRequirement));
    this.Detail = new Detail();
    this.txtControlNo = new TextBox();
    this.txtDescription = new TextBox();
    this.txtEffectiveDate = new TextBox();
    this.txtExpirationDate = new TextBox();
    this.txtLineName = new TextBox();
    this.txtPolicyNumber = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
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
    this.PageFooter1 = new PageFooter();
    ((ISupportInitialize) this.txtControlNo).BeginInit();
    ((ISupportInitialize) this.txtDescription).BeginInit();
    ((ISupportInitialize) this.txtEffectiveDate).BeginInit();
    ((ISupportInitialize) this.txtExpirationDate).BeginInit();
    ((ISupportInitialize) this.txtLineName).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.txtControlNo,
      (ARControl) this.txtDescription,
      (ARControl) this.txtEffectiveDate,
      (ARControl) this.txtExpirationDate,
      (ARControl) this.txtLineName,
      (ARControl) this.txtPolicyNumber,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1458333f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtControlNo).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtControlNo).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtControlNo).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtControlNo).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtControlNo).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtControlNo).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtControlNo).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtControlNo).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtControlNo).DataField = "LocationCode";
    ((ARControl) this.txtControlNo).Height = 0.125f;
    ((ARControl) this.txtControlNo).Left = 1f / 16f;
    ((ARControl) this.txtControlNo).Name = "txtControlNo";
    this.txtControlNo.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtControlNo.Text = " ";
    ((ARControl) this.txtControlNo).Top = 0.0f;
    ((ARControl) this.txtControlNo).Width = 9f / 16f;
    ((ARControl) this.txtDescription).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDescription).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDescription).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDescription).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDescription).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDescription).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDescription).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDescription).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDescription).DataField = "PolicyNo";
    ((ARControl) this.txtDescription).Height = 0.125f;
    ((ARControl) this.txtDescription).Left = 6.875f;
    ((ARControl) this.txtDescription).Name = "txtDescription";
    this.txtDescription.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtDescription.Text = " ";
    ((ARControl) this.txtDescription).Top = 0.0f;
    ((ARControl) this.txtDescription).Width = 0.75f;
    ((ARControl) this.txtEffectiveDate).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).DataField = "address";
    ((ARControl) this.txtEffectiveDate).Height = 0.125f;
    ((ARControl) this.txtEffectiveDate).Left = 49f / 16f;
    ((ARControl) this.txtEffectiveDate).Name = "txtEffectiveDate";
    this.txtEffectiveDate.OutputFormat = resourceManager.GetString("txtEffectiveDate.OutputFormat");
    this.txtEffectiveDate.Style = "ddo-char-set: 0; text-align: left; font-size: 6.75pt; ";
    this.txtEffectiveDate.Text = " ";
    ((ARControl) this.txtEffectiveDate).Top = 0.0f;
    ((ARControl) this.txtEffectiveDate).Width = 23f / 16f;
    ((ARControl) this.txtExpirationDate).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpirationDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpirationDate).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpirationDate).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpirationDate).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpirationDate).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpirationDate).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpirationDate).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpirationDate).DataField = "Phone";
    ((ARControl) this.txtExpirationDate).Height = 0.125f;
    ((ARControl) this.txtExpirationDate).Left = 73f / 16f;
    ((ARControl) this.txtExpirationDate).Name = "txtExpirationDate";
    this.txtExpirationDate.OutputFormat = resourceManager.GetString("txtExpirationDate.OutputFormat");
    this.txtExpirationDate.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.txtExpirationDate.Text = " ";
    ((ARControl) this.txtExpirationDate).Top = 0.0f;
    ((ARControl) this.txtExpirationDate).Width = 13f / 16f;
    ((ARControl) this.txtLineName).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLineName).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLineName).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLineName).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLineName).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLineName).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLineName).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLineName).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLineName).DataField = "Carrier";
    ((ARControl) this.txtLineName).Height = 0.125f;
    ((ARControl) this.txtLineName).Left = 87f / 16f;
    ((ARControl) this.txtLineName).Name = "txtLineName";
    this.txtLineName.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtLineName.Text = " ";
    ((ARControl) this.txtLineName).Top = 0.0f;
    ((ARControl) this.txtLineName).Width = 1.375f;
    ((ARControl) this.txtPolicyNumber).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPolicyNumber).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPolicyNumber).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPolicyNumber).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPolicyNumber).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPolicyNumber).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPolicyNumber).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPolicyNumber).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPolicyNumber).DataField = "Name";
    ((ARControl) this.txtPolicyNumber).Height = 0.125f;
    ((ARControl) this.txtPolicyNumber).Left = 11f / 16f;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtPolicyNumber.Text = (string) null;
    ((ARControl) this.txtPolicyNumber).Top = 0.0f;
    ((ARControl) this.txtPolicyNumber).Width = 37f / 16f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "PolicyLimit";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 123f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; ";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 1.125f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "ValidThrough";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 8.875f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 11f / 16f;
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
    this.lblTitle.Text = "Producer Requirement report";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 10f;
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
    ((ARControl) this.Label2).Left = 11f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label2.Text = "Location Name";
    ((ARControl) this.Label2).Top = 0.625f;
    ((ARControl) this.Label2).Width = 37f / 16f;
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
    ((ARControl) this.Label6).Left = 87f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label6.Text = "Carrier";
    ((ARControl) this.Label6).Top = 0.625f;
    ((ARControl) this.Label6).Width = 1.375f;
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
    ((ARControl) this.Label7).Left = 49f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label7.Text = "Address";
    ((ARControl) this.Label7).Top = 0.625f;
    ((ARControl) this.Label7).Width = 23f / 16f;
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
    ((ARControl) this.Label9).Left = 1f / 16f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "text-align: left; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label9.Text = "Location Code";
    ((ARControl) this.Label9).Top = 0.625f;
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
    ((ARControl) this.Label17).Left = 6.875f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label17.Text = "Policy No";
    ((ARControl) this.Label17).Top = 0.625f;
    ((ARControl) this.Label17).Width = 0.75f;
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
    ((ARControl) this.Label19).Left = 73f / 16f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label19.Text = "Phone";
    ((ARControl) this.Label19).Top = 0.625f;
    ((ARControl) this.Label19).Width = 13f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.Label9,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label2,
      (ARControl) this.Label17,
      (ARControl) this.Label19,
      (ARControl) this.lblTitle,
      (ARControl) this.Label1,
      (ARControl) this.Label3
    });
    this.PageHeader1.Height = 15f / 16f;
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
    ((ARControl) this.Label1).Left = 123f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label1.Text = "Policy Limit";
    ((ARControl) this.Label1).Top = 0.625f;
    ((ARControl) this.Label1).Width = 1.125f;
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
    ((ARControl) this.Label3).Left = 8.875f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label3.Text = "Valid Through";
    ((ARControl) this.Label3).Top = 0.625f;
    ((ARControl) this.Label3).Width = 11f / 16f;
    this.PageFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtControlNo).EndInit();
    ((ISupportInitialize) this.txtDescription).EndInit();
    ((ISupportInitialize) this.txtEffectiveDate).EndInit();
    ((ISupportInitialize) this.txtExpirationDate).EndInit();
    ((ISupportInitialize) this.txtLineName).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public rptProducerRequirement()
  {
    this.ReportStart += new EventHandler(this.rptProducerRequirement_ReportStart);
    this._dt = new DataTable();
  }

  public rptProducerRequirement(
    Guid ProducerLocationGuid,
    int RequirementType,
    DateTime ValidAfterDate,
    bool ShowNotSubmitted)
  {
    this.ReportStart += new EventHandler(this.rptProducerRequirement_ReportStart);
    this._dt = new DataTable();
    this.InitializeComponent();
    this._ProducerLocationGuid = ProducerLocationGuid;
    this._RequirementType = RequirementType;
    this._ValidAfterDate = ValidAfterDate;
    this._ShowNotSubmitted = ShowNotSubmitted;
  }

  private void rptProducerRequirement_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.ShowPageNumbers();
    this._sqlProc = this._ShowNotSubmitted ? "rptProducerRequirementNotSubmitted" : nameof (rptProducerRequirement);
    using (DbConnection dbConnection = DefaultDatabase.CreateDbConnection())
    {
      using (DbCommand command = DefaultDatabase.CreateCommand(this._sqlProc, dbConnection))
      {
        command.CommandType = CommandType.StoredProcedure;
        command.CommandTimeout = 0;
        if (!this._ProducerLocationGuid.Equals(Guid.Empty))
          DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@ProducerLocationGuid", (object) this._ProducerLocationGuid);
        if (this._RequirementType > 0)
          DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@RequirementType", (object) this._RequirementType);
        DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@ValidAfterDate", (object) this._ValidAfterDate);
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

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[4]
      {
        (BaseReportControl) new GenericComboBox("Producer Location", $"SELECT 0 as sort, 'All Producer Locations' As Display, '{Guid.Empty}' As Value UNION SELECT 1 as sort, Name + ' ' + isnull(City,'') + isnull(', ' + State,'') + ' (' + convert(varchar,ProducerLocationID) + ')'AS Display, ProducerLocationGuid AS Value From tblProducerLocations where tblProducerLocations.StatusID = 1 Order BY sort, Display", "Value", "Display", typeof (Guid)),
        (BaseReportControl) new GenericComboBox("Requirement Type", $"SELECT '{0}' As value, 'All Requirements' As Display UNION SELECT ProducerRequirementListID as value, Description as Display FROM dbo.lstProducerRequirements order by Display", "value", "Display", typeof (int)),
        (BaseReportControl) new DatePicker("Valid After", DateTime.Now, false),
        (BaseReportControl) new GenericCheckBox("", "Show Not Submitted", false)
      };
    }
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }
}
