// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptBindToIssuance
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{0A7169C7-282E-4125-B802-163E14648250}", "Bind To Issuance", "Displays submission and binding information.", "General")]
[SecureResource("{9755FD2B-29CF-49F4-BFFD-CBE8EC56FE52}", "Bind To Issuance report underwriter search", "User can run report for all underwriters.", "Reports")]
public class rptBindToIssuance : MGAReport, IReport
{
  internal const string UserCanViewAllUnderwriters = "{9755FD2B-29CF-49F4-BFFD-CBE8EC56FE52}";
  private Guid _IssuedByUserGuid;
  private Guid _BoundByUserGuid;
  private DateTime _IssueDateFrom;
  private DateTime _IssueDateTo;
  private DateTime _BoundDateFrom;
  private DateTime _BoundDateTo;
  private DateTime _EffectiveDateFrom;
  private DateTime _EffectiveDateTo;
  private Guid _CompanyLocationGuid;
  private int _CostCenterID;
  private string _QuotingOfficeGuids;
  private DataTable _dt;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox;

  private virtual PageHeader PageHeader1
  {
    get => this._PageHeader1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.PageHeader1_Format);
      PageHeader pageHeader1_1 = this._PageHeader1;
      if (pageHeader1_1 != null)
        ((Section) pageHeader1_1).Format -= eventHandler;
      this._PageHeader1 = value;
      PageHeader pageHeader1_2 = this._PageHeader1;
      if (pageHeader1_2 == null)
        return;
      ((Section) pageHeader1_2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblTitle")]
  private virtual Label lblTitle { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label")]
  private virtual Label Label { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  private virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  private virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  private virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox7")]
  private virtual TextBox TextBox7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportInfo1")]
  private virtual ReportInfo ReportInfo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptBindToIssuance()
  {
    this.ReportStart += new EventHandler(this.rptBindToIssuance_ReportStart);
    this.InitializeComponent();
  }

  public rptBindToIssuance(
    Guid IssuedByUserGuid,
    Guid BoundByUserGuid,
    Guid CompanyLocationGuid,
    int CostCenterID,
    string QuotingOfficeGuids,
    DateTime IssueDateFrom,
    DateTime IssueDateTo,
    DateTime BoundDateFrom,
    DateTime BoundDateTo,
    DateTime EffectiveDateFrom,
    DateTime EffectiveDateTo)
  {
    this.ReportStart += new EventHandler(this.rptBindToIssuance_ReportStart);
    this.InitializeComponent();
    this._IssuedByUserGuid = IssuedByUserGuid;
    this._BoundByUserGuid = BoundByUserGuid;
    this._IssueDateFrom = IssueDateFrom;
    this._IssueDateTo = IssueDateTo;
    this._BoundDateFrom = BoundDateFrom;
    this._BoundDateTo = BoundDateTo;
    this._EffectiveDateFrom = EffectiveDateFrom;
    this._EffectiveDateTo = EffectiveDateTo;
    this._CompanyLocationGuid = CompanyLocationGuid;
    this._CostCenterID = CostCenterID;
    this._QuotingOfficeGuids = QuotingOfficeGuids;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptBindToIssuance));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.PageHeader1 = new PageHeader();
    this.lblTitle = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.PageFooter1 = new PageFooter();
    this.ReportInfo1 = new ReportInfo();
    this.TextBox9 = new TextBox();
    this.Label9 = new Label();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.ReportInfo1).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((Section) this.Detail).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9
    });
    ((Section) this.Detail).Height = 0.125f;
    ((Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).DataField = "PolicyNumber";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 8pt";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 1f;
    ((ARControl) this.TextBox2).DataField = "DateBound";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 1.837f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 8pt; text-align: center";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 2.980232E-08f;
    ((ARControl) this.TextBox2).Width = 0.687f;
    ((ARControl) this.TextBox3).DataField = "BoundBy";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 2.587f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 8pt";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 2.980232E-08f;
    ((ARControl) this.TextBox3).Width = 0.813f;
    ((ARControl) this.TextBox4).DataField = "DateIssued";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 3.462f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 8pt; text-align: center";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 2.980232E-08f;
    ((ARControl) this.TextBox4).Width = 11f / 16f;
    ((ARControl) this.TextBox5).DataField = "IssuedBy";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 4.212f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 8pt";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 2.980232E-08f;
    ((ARControl) this.TextBox5).Width = 0.813f;
    ((ARControl) this.TextBox).DataField = "Status";
    ((ARControl) this.TextBox).Height = 0.125f;
    ((ARControl) this.TextBox).Left = 6.775f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 8pt; text-align: center";
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox).Top = 2.980232E-08f;
    ((ARControl) this.TextBox).Width = 17f / 16f;
    ((ARControl) this.TextBox6).DataField = "InsuredPolicyName";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 5.087f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 8pt";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 2.980232E-08f;
    ((ARControl) this.TextBox6).Width = 1.625f;
    ((ARControl) this.TextBox7).DataField = "CompanyName";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 7.9f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "font-size: 8pt";
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 2.980232E-08f;
    ((ARControl) this.TextBox7).Width = 1.625f;
    ((ARControl) this.TextBox8).DataField = "underwriter";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 9.587f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-size: 8pt";
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 2.980232E-08f;
    ((ARControl) this.TextBox8).Width = 0.813f;
    ((Section) this.PageHeader1).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9
    });
    this.PageHeader1.Height = 0.5626667f;
    ((Section) this.PageHeader1).Name = "PageHeader1";
    ((ARControl) this.lblTitle).Height = 0.25f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 12pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.lblTitle.Text = "Bind To Issuance Report";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 9.625f;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle";
    this.Label1.Text = "Policy #";
    ((ARControl) this.Label1).Top = 0.375f;
    ((ARControl) this.Label1).Width = 1f;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 1.837f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.Label2.Text = "Bound";
    ((ARControl) this.Label2).Top = 0.375f;
    ((ARControl) this.Label2).Width = 0.687f;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 3.462f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.Label3.Text = "Issued";
    ((ARControl) this.Label3).Top = 0.375f;
    ((ARControl) this.Label3).Width = 11f / 16f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 4.212f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle";
    this.Label4.Text = "Issued By";
    ((ARControl) this.Label4).Top = 0.375f;
    ((ARControl) this.Label4).Width = 0.813f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 2.5875f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle";
    this.Label5.Text = "Bound By";
    ((ARControl) this.Label5).Top = 0.3750001f;
    ((ARControl) this.Label5).Width = 0.813f;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 6.775f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.Label.Text = "Status";
    ((ARControl) this.Label).Top = 0.375f;
    ((ARControl) this.Label).Width = 17f / 16f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 5.086999f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle";
    this.Label6.Text = "Insured Name";
    ((ARControl) this.Label6).Top = 0.375f;
    ((ARControl) this.Label6).Width = 1.625f;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 7.9f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle";
    this.Label7.Text = "Company Group";
    ((ARControl) this.Label7).Top = 0.375f;
    ((ARControl) this.Label7).Width = 1.625f;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 9.587f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 8pt; font-weight: bold; vertical-align: middle";
    this.Label8.Text = "Underwriter ";
    ((ARControl) this.Label8).Top = 0.375f;
    ((ARControl) this.Label8).Width = 0.813f;
    ((Section) this.PageFooter1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.ReportInfo1
    });
    this.PageFooter1.Height = 0.2f;
    ((Section) this.PageFooter1).Name = "PageFooter1";
    this.ReportInfo1.FormatString = "Page {PageNumber} of {PageCount}";
    ((ARControl) this.ReportInfo1).Height = 0.2f;
    ((ARControl) this.ReportInfo1).Left = 8.9f;
    ((ARControl) this.ReportInfo1).Name = "ReportInfo1";
    this.ReportInfo1.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    ((ARControl) this.ReportInfo1).Top = 2.980232E-08f;
    ((ARControl) this.ReportInfo1).Width = 1.5f;
    ((ARControl) this.TextBox9).DataField = "EffectiveDate";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 1.063f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-size: 8pt; text-align: center";
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 11f / 16f;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 1.063f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 8pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.Label9.Text = "Effective";
    ((ARControl) this.Label9).Top = 0.375f;
    ((ARControl) this.Label9).Width = 11f / 16f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((Section) this.PageHeader1);
    this.Sections.Add((Section) this.Detail);
    this.Sections.Add((Section) this.PageFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.ReportInfo1).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private ArrayList GetParams()
  {
    ArrayList arrayList = new ArrayList();
    if (!this._IssuedByUserGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@IssuedByUser",
        (object) this._IssuedByUserGuid
      });
    if (!this._BoundByUserGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@BoundByUser",
        (object) this._BoundByUserGuid
      });
    if (DateTime.Compare(this._IssueDateFrom, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@IssuedFrom",
        (object) this._IssueDateFrom
      });
    if (DateTime.Compare(this._IssueDateTo, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@IssuedTo",
        (object) this._IssueDateTo
      });
    if (DateTime.Compare(this._BoundDateFrom, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@BoundFrom",
        (object) this._BoundDateFrom
      });
    if (DateTime.Compare(this._BoundDateTo, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@BoundTo",
        (object) this._BoundDateTo
      });
    if (DateTime.Compare(this._EffectiveDateFrom, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@EffectiveFrom",
        (object) this._EffectiveDateFrom
      });
    if (DateTime.Compare(this._EffectiveDateTo, DateTime.MinValue) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@EffectiveTo",
        (object) this._EffectiveDateTo
      });
    if (!this._CompanyLocationGuid.Equals(Guid.Empty))
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@CompanyLocationGuid",
        (object) this._CompanyLocationGuid
      });
    if (this._CostCenterID != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@CostCenterID",
        (object) this._CostCenterID
      });
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._QuotingOfficeGuids, "", false) != 0)
      arrayList.AddRange((ICollection) new object[2]
      {
        (object) "@QuotingOfficeGuids",
        (object) this._QuotingOfficeGuids
      });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@CurrentUserGuid",
      (object) this.CurrentUserGuid
    });
    return arrayList;
  }

  private void rptBindToIssuance_ReportStart(object sender, EventArgs e)
  {
    this.HidePrintDateAndTime();
    this.SetProgressbarMaximum(100);
    this.IncreaseProgressbar(20);
    this.SetStatusText("Retrieving Data...");
    this._dt = DefaultDatabase.ExecuteDataTable(nameof (rptBindToIssuance), this.GetParams().ToArray());
    this.IncreaseProgressbar(20);
    this.SetStatusText("Formatting...");
    this.IncreaseProgressbar(40);
    this.DataSource = (object) this._dt;
    this.IncreaseProgressbar(20);
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      Underwriters underwriters1;
      Underwriters underwriters2;
      if (SecurityManager.Instance.AssertPermission("{9755FD2B-29CF-49F4-BFFD-CBE8EC56FE52}"))
      {
        underwriters1 = new Underwriters("Issued By", true);
        underwriters2 = new Underwriters("Bound By", true);
      }
      else
      {
        underwriters1 = new Underwriters("Issued By", true, this.CurrentUserGuid, true);
        underwriters2 = new Underwriters("Bound By", true, this.CurrentUserGuid, true);
      }
      return new BaseReportControl[8]
      {
        (BaseReportControl) underwriters1,
        (BaseReportControl) underwriters2,
        (BaseReportControl) new CompanyLocations("Company", true),
        (BaseReportControl) new GenericComboBox("Cost Center", "((SELECT -1 As Sort, 'All Cost Centers' As Display, 0 As Value) UNION (SELECT 1 As Sort, GroupName AS Display, GroupId AS Value FROM tblEntityGroups)) ORDER BY Sort, Display", "Value", "Display", typeof (int)),
        (BaseReportControl) new GenericListBox("Quoting Office", "SELECT Location AS Display, OfficeGUID AS Value FROM dbo.tblClientOffices ORDER BY Location", "Value", "Display", true, typeof (Guid), true, false),
        (BaseReportControl) new DateRangePicker("Issued", true),
        (BaseReportControl) new DateRangePicker("Bound", true),
        (BaseReportControl) new DateRangePicker("Effective", true)
      };
    }
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  public override bool IsThreaded => true;

  [field: AccessedThroughProperty("TextBox6")]
  private virtual TextBox TextBox6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private void PageHeader1_Format(object sender, EventArgs e)
  {
  }
}
