// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptAppliedForm
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
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{CFD381A7-490B-484f-989F-CF445F897238}", "Applied Form", "Displays specific Applied form in existing deal.", "General")]
public class rptAppliedForm : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{CFD381A7-490B-484f-989F-CF445F897238}";
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
  private readonly Guid _CompanyLocationGuid;
  private readonly string _LineGuid;
  private readonly string _StateID;
  private readonly string _FormID;

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

  public rptAppliedForm() => this.ReportStart += new EventHandler(this.rptAppliedForm_ReportStart);

  public rptAppliedForm(Guid CompanyLocationGuid, string lineguid, string StateID, string FormID)
  {
    this.ReportStart += new EventHandler(this.rptAppliedForm_ReportStart);
    this.InitializeComponent();
    this._CompanyLocationGuid = CompanyLocationGuid;
    this._LineGuid = lineguid;
    this._StateID = StateID;
    this._FormID = FormID;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptAppliedForm));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
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
    this.PageFooter1 = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    ((ISupportInitialize) this.TextBox1).BeginInit();
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
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.TextBox1
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
    ((ARControl) this.TextBox1).Left = 97f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 27f / 16f;
    ((ARControl) this.txtEffectiveDate).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtEffectiveDate).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtEffectiveDate).DataField = "EffectiveDate";
    ((ARControl) this.txtEffectiveDate).Height = 0.125f;
    ((ARControl) this.txtEffectiveDate).Left = 25f / 16f;
    ((ARControl) this.txtEffectiveDate).Name = "txtEffectiveDate";
    this.txtEffectiveDate.OutputFormat = resourceManager.GetString("txtEffectiveDate.OutputFormat");
    this.txtEffectiveDate.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.txtEffectiveDate.Text = " ";
    ((ARControl) this.txtEffectiveDate).Top = 0.0f;
    ((ARControl) this.txtEffectiveDate).Width = 13f / 16f;
    ((ARControl) this.txtControlNo).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtControlNo).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtControlNo).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtControlNo).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtControlNo).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtControlNo).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtControlNo).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtControlNo).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtControlNo).DataField = "ControlNo";
    ((ARControl) this.txtControlNo).Height = 0.125f;
    ((ARControl) this.txtControlNo).Left = 1f / 16f;
    ((ARControl) this.txtControlNo).Name = "txtControlNo";
    this.txtControlNo.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtControlNo.Text = " ";
    ((ARControl) this.txtControlNo).Top = 0.0f;
    ((ARControl) this.txtControlNo).Width = 9f / 16f;
    ((ARControl) this.txtLineName).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLineName).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLineName).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLineName).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLineName).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLineName).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLineName).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtLineName).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtLineName).DataField = "LineName";
    ((ARControl) this.txtLineName).Height = 0.125f;
    ((ARControl) this.txtLineName).Left = 55f / 16f;
    ((ARControl) this.txtLineName).Name = "txtLineName";
    this.txtLineName.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtLineName.Text = " ";
    ((ARControl) this.txtLineName).Top = 0.0f;
    ((ARControl) this.txtLineName).Width = 1.25f;
    ((ARControl) this.txtDescription).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDescription).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDescription).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDescription).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDescription).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDescription).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDescription).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtDescription).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtDescription).DataField = "QuoteStatus_Desc";
    ((ARControl) this.txtDescription).Height = 0.125f;
    ((ARControl) this.txtDescription).Left = 4.75f;
    ((ARControl) this.txtDescription).Name = "txtDescription";
    this.txtDescription.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtDescription.Text = " ";
    ((ARControl) this.txtDescription).Top = 0.0f;
    ((ARControl) this.txtDescription).Width = 1.25f;
    ((ARControl) this.txtPolicyNumber).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPolicyNumber).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPolicyNumber).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPolicyNumber).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPolicyNumber).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPolicyNumber).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPolicyNumber).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtPolicyNumber).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtPolicyNumber).DataField = "PolicyNumber";
    ((ARControl) this.txtPolicyNumber).Height = 0.125f;
    ((ARControl) this.txtPolicyNumber).Left = 11f / 16f;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.Style = "ddo-char-set: 0; font-size: 6.75pt; ";
    this.txtPolicyNumber.Text = (string) null;
    ((ARControl) this.txtPolicyNumber).Top = 0.0f;
    ((ARControl) this.txtPolicyNumber).Width = 13f / 16f;
    ((ARControl) this.txtExpirationDate).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpirationDate).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpirationDate).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpirationDate).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpirationDate).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpirationDate).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpirationDate).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtExpirationDate).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtExpirationDate).DataField = "ExpirationDate";
    ((ARControl) this.txtExpirationDate).Height = 0.125f;
    ((ARControl) this.txtExpirationDate).Left = 39f / 16f;
    ((ARControl) this.txtExpirationDate).Name = "txtExpirationDate";
    this.txtExpirationDate.OutputFormat = resourceManager.GetString("txtExpirationDate.OutputFormat");
    this.txtExpirationDate.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; ";
    this.txtExpirationDate.Text = " ";
    ((ARControl) this.txtExpirationDate).Top = 0.0f;
    ((ARControl) this.txtExpirationDate).Width = 15f / 16f;
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
    this.lblTitle.Text = "Applied Form report";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 7.75f;
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
    this.Label2.Text = "Policy Number";
    ((ARControl) this.Label2).Top = 0.625f;
    ((ARControl) this.Label2).Width = 13f / 16f;
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
    ((ARControl) this.Label6).Left = 55f / 16f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label6.Text = "Line Name";
    ((ARControl) this.Label6).Top = 0.625f;
    ((ARControl) this.Label6).Width = 1.25f;
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
    ((ARControl) this.Label7).Left = 25f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label7.Text = "Effective Date";
    ((ARControl) this.Label7).Top = 0.625f;
    ((ARControl) this.Label7).Width = 13f / 16f;
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
    this.Label9.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label9.Text = "Control #";
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
    ((ARControl) this.Label17).Left = 4.75f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label17.Text = "Bound Description";
    ((ARControl) this.Label17).Top = 0.625f;
    ((ARControl) this.Label17).Width = 1.25f;
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
    ((ARControl) this.Label19).Left = 39f / 16f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "text-align: center; font-weight: bold; font-size: 8pt; vertical-align: bottom; ";
    this.Label19.Text = "Expiration Date";
    ((ARControl) this.Label19).Top = 0.625f;
    ((ARControl) this.Label19).Width = 15f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.Label9,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label2,
      (ARControl) this.Label17,
      (ARControl) this.Label19,
      (ARControl) this.lblTitle,
      (ARControl) this.Label1
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
    ((ARControl) this.Label1).Left = 97f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; vertical-align: bottom; ";
    this.Label1.Text = "Form Name";
    ((ARControl) this.Label1).Top = 0.625f;
    ((ARControl) this.Label1).Width = 27f / 16f;
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
    this.GroupHeader1.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.UnderlayNext = true;
    this.GroupFooter1.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    this.MasterReport = false;
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
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
    ((ISupportInitialize) this).EndInit();
  }

  private void rptAppliedForm_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.ShowPageNumbers();
    object companyLocationGuid = (object) DBNull.Value;
    object stateId = (object) DBNull.Value;
    object lineGuid = (object) DBNull.Value;
    if (!this._CompanyLocationGuid.Equals(Guid.Empty))
      companyLocationGuid = (object) this._CompanyLocationGuid;
    if (!this._StateID.Equals(string.Empty))
      stateId = (object) this._StateID;
    if (!this._LineGuid.Equals(string.Empty))
      lineGuid = (object) this._LineGuid;
    try
    {
      this._dt = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, nameof (rptAppliedForm), 0, (CommandArgumentType) 0, new object[8]
      {
        (object) "@CompanyLocationGuid",
        companyLocationGuid,
        (object) "@LineGuid",
        lineGuid,
        (object) "@StateID",
        stateId,
        (object) "@FormID",
        (object) this._FormID
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
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
        (BaseReportControl) new CompanyLocations("Company", true),
        (BaseReportControl) new GenericListBox("Line of Business", "Select LineName as Display, LineGuid as Value From lstlines Order BY LineName", "Value", "Display", true, typeof (Guid), true, false),
        (BaseReportControl) new GenericComboBox("State", $"SELECT '{string.Empty}' As StateID, 'All States' As State UNION SELECT StateID, State FROM lstStates", "StateID", "State", typeof (string)),
        (BaseReportControl) new GenericListBox("Policy Form", "(SELECT FormID As Value, FormName + '(' + FormNumber + ' - ' + convert(varchar(50),FormID) + ')'  As Display FROM tblPolicyForms) ORDER BY Display", "Value", "Display", 400, 400, false)
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
