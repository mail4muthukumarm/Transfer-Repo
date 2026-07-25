// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptClearance
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{695D2939-CDD8-4d3e-A4DB-82B1E5B06E75}", "Clearance", "Displays submitted business by producer, underwriter, effective date and submitted date.", "General")]
[SecureResource("{9865D7C4-B8A1-41a6-88E0-21E29D53A1A3}", "Clearance report underwriter search", "User can run report for all underwriters.", "Reports")]
[SecureResource("{A7880375-830C-471c-A3F0-97308F7C77E9}", "Clearance report in-house producer search", "User can run report for all in-house producers.", "Reports")]
public class rptClearance : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{695D2939-CDD8-4d3e-A4DB-82B1E5B06E75}";
  internal const string UserCanViewAllResults = "{9865D7C4-B8A1-41a6-88E0-21E29D53A1A3}";
  internal const string UserCanViewAllInHouseProducerResults = "{A7880375-830C-471c-A3F0-97308F7C77E9}";
  private string _ProducerGuids;
  private string _ProducerLocations;
  private string _ProducerLocationRegions;
  private Guid _UnderwriterGuid;
  private Guid _InHouseProducerGuid;
  private DateTime _DateSubmittedFrom;
  private DateTime _DateSubmittedTo;
  private DateTime _DateEffectiveFrom;
  private DateTime _DateEffectiveTo;
  private DataTable _dt;
  private int _failSafePreviousRecordCount;
  private string _QuoteStatusID;
  private Guid _CompanyLocationGuid;
  private Guid _IntermediaryGuid;
  private Guid _QuotingOfficeLocation;
  private string _IssuingOfficeLocations;
  private Guid _CompanyGroupGuid;
  private int _PolicyTypeID;
  private int _CostCenterID;
  private bool _excelOnly;
  private string _StateID;
  private string _LineGuid;
  private Label lblTitle;
  private TextBox txtSubTitle;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label Label;
  private Label Label1;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private Label Label16;
  private Label Label17;
  private Label Label18;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox Insured;
  private TextBox PolicyNum;
  private TextBox BusinessType;
  private TextBox BusinessType1;
  private TextBox Issued;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox Type;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private TextBox TextBox11;

  [field: AccessedThroughProperty("Label23")]
  private virtual Label Label23 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox15")]
  private virtual TextBox TextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  private virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox21")]
  private virtual TextBox TextBox21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line1")]
  private virtual Line Line1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  private virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Line2")]
  private virtual Line Line2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptClearance()
  {
    this.ReportStart += new EventHandler(this.rptClearance_ReportStart);
    this._dt = new DataTable();
    this._failSafePreviousRecordCount = 0;
  }

  public rptClearance(
    string ProducerGuids,
    string ProducerLocations,
    string ProducerLocationRegions,
    Guid CompanyLocationGuid,
    Guid IntermediaryGuid,
    Guid UnderwriterGuid,
    Guid InHouseProducerGuid,
    Guid QuotingOfficeLocation,
    string IssuingOfficeLocations,
    Guid CompanyGroupGuid,
    string QuoteStatusID,
    string StateID,
    int PolicyTypeID,
    DateTime DateSubmittedFrom,
    DateTime DateSubmittedTo,
    DateTime DateEffectiveFrom,
    DateTime DateEffectiveTo,
    string lineguid,
    int CostCenterID,
    bool excelOnly)
  {
    this.ReportStart += new EventHandler(this.rptClearance_ReportStart);
    this._dt = new DataTable();
    this._failSafePreviousRecordCount = 0;
    this.InitializeComponent();
    this._ProducerGuids = ProducerGuids;
    this._ProducerLocations = ProducerLocations;
    this._ProducerLocationRegions = ProducerLocationRegions;
    this._UnderwriterGuid = UnderwriterGuid;
    this._InHouseProducerGuid = InHouseProducerGuid;
    this._QuoteStatusID = QuoteStatusID;
    this._DateSubmittedFrom = DateSubmittedFrom;
    this._DateSubmittedTo = DateSubmittedTo;
    this._DateEffectiveFrom = DateEffectiveFrom;
    this._DateEffectiveTo = DateEffectiveTo;
    this._CompanyLocationGuid = CompanyLocationGuid;
    this._IntermediaryGuid = IntermediaryGuid;
    this._QuotingOfficeLocation = QuotingOfficeLocation;
    this._IssuingOfficeLocations = IssuingOfficeLocations;
    this._CompanyGroupGuid = CompanyGroupGuid;
    this._PolicyTypeID = PolicyTypeID;
    this._CostCenterID = CostCenterID;
    this._StateID = StateID;
    this._LineGuid = lineguid;
    this._excelOnly = excelOnly;
  }

  public rptClearance(
    string ProducerGuids,
    string ProducerLocationRegions,
    Guid CompanyLocationGuid,
    Guid IntermediaryGuid,
    Guid UnderwriterGuid,
    Guid InHouseProducerGuid,
    Guid QuotingOfficeLocation,
    string IssuingOfficeLocations,
    Guid CompanyGroupGuid,
    string QuoteStatusID,
    string StateID,
    int PolicyTypeID,
    DateTime DateSubmittedFrom,
    DateTime DateSubmittedTo,
    DateTime DateEffectiveFrom,
    DateTime DateEffectiveTo,
    string LineGuid,
    int CostCenterID,
    bool excelOnly)
  {
    this.ReportStart += new EventHandler(this.rptClearance_ReportStart);
    this._dt = new DataTable();
    this._failSafePreviousRecordCount = 0;
    this.InitializeComponent();
    this._ProducerGuids = ProducerGuids;
    this._ProducerLocations = string.Empty;
    this._ProducerLocationRegions = ProducerLocationRegions;
    this._UnderwriterGuid = UnderwriterGuid;
    this._InHouseProducerGuid = InHouseProducerGuid;
    this._QuoteStatusID = QuoteStatusID;
    this._DateSubmittedFrom = DateSubmittedFrom;
    this._DateSubmittedTo = DateSubmittedTo;
    this._DateEffectiveFrom = DateEffectiveFrom;
    this._DateEffectiveTo = DateEffectiveTo;
    this._CompanyLocationGuid = CompanyLocationGuid;
    this._IntermediaryGuid = IntermediaryGuid;
    this._QuotingOfficeLocation = QuotingOfficeLocation;
    this._IssuingOfficeLocations = IssuingOfficeLocations;
    this._CompanyGroupGuid = CompanyGroupGuid;
    this._PolicyTypeID = PolicyTypeID;
    this._CostCenterID = CostCenterID;
    this._StateID = StateID;
    this._LineGuid = LineGuid;
    this._excelOnly = excelOnly;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptClearance));
    this.Detail = new Detail();
    this.TextBox20 = new TextBox();
    this.TextBox18 = new TextBox();
    this.TextBox19 = new TextBox();
    this.TextBox17 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.Insured = new TextBox();
    this.PolicyNum = new TextBox();
    this.BusinessType = new TextBox();
    this.BusinessType1 = new TextBox();
    this.Issued = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.Type = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox13 = new TextBox();
    this.TextBox14 = new TextBox();
    this.TextBox16 = new TextBox();
    this.Label23 = new Label();
    this.TextBox15 = new TextBox();
    this.Label24 = new Label();
    this.TextBox21 = new TextBox();
    this.Label25 = new Label();
    this.Line2 = new Line();
    this.ReportHeader = new ReportHeader();
    this.lblTitle = new Label();
    this.txtSubTitle = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.Label22 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox12 = new TextBox();
    this.gh = new GroupHeader();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label = new Label();
    this.Label1 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.Label19 = new Label();
    this.Label20 = new Label();
    this.Label21 = new Label();
    this.Line1 = new Line();
    this.gf = new GroupFooter();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.Insured).BeginInit();
    ((ISupportInitialize) this.PolicyNum).BeginInit();
    ((ISupportInitialize) this.BusinessType).BeginInit();
    ((ISupportInitialize) this.BusinessType1).BeginInit();
    ((ISupportInitialize) this.Issued).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.Type).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.Label23).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.Label24).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
    ((ISupportInitialize) this.Label25).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.txtSubTitle).BeginInit();
    ((ISupportInitialize) this.Label22).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.Label20).BeginInit();
    ((ISupportInitialize) this.Label21).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[29]
    {
      (ARControl) this.TextBox20,
      (ARControl) this.TextBox18,
      (ARControl) this.TextBox19,
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.Insured,
      (ARControl) this.PolicyNum,
      (ARControl) this.BusinessType,
      (ARControl) this.BusinessType1,
      (ARControl) this.Issued,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.Type,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox13,
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox16,
      (ARControl) this.Label23,
      (ARControl) this.TextBox15,
      (ARControl) this.Label24,
      (ARControl) this.TextBox21,
      (ARControl) this.Label25,
      (ARControl) this.Line2
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.4166666f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox20).DataField = "BasePremium";
    ((ARControl) this.TextBox20).Height = 0.125f;
    ((ARControl) this.TextBox20).Left = 195f / 16f;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = resourceManager.GetString("TextBox20.OutputFormat");
    this.TextBox20.Style = "font-size: 6pt; text-align: right; ddo-char-set: 0";
    this.TextBox20.Text = (string) null;
    ((ARControl) this.TextBox20).Top = 0.0f;
    ((ARControl) this.TextBox20).Width = 0.5624995f;
    ((ARControl) this.TextBox18).DataField = "PreviousPremium";
    ((ARControl) this.TextBox18).Height = 0.125f;
    ((ARControl) this.TextBox18).Left = 177f / 16f;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = resourceManager.GetString("TextBox18.OutputFormat");
    this.TextBox18.Style = "font-size: 6pt; text-align: right; ddo-char-set: 0";
    this.TextBox18.Text = (string) null;
    ((ARControl) this.TextBox18).Top = 0.0f;
    ((ARControl) this.TextBox18).Width = 0.5624999f;
    ((ARControl) this.TextBox19).DataField = "QuotedPremium";
    ((ARControl) this.TextBox19).Height = 0.125f;
    ((ARControl) this.TextBox19).Left = 11.625f;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.OutputFormat = resourceManager.GetString("TextBox19.OutputFormat");
    this.TextBox19.Style = "font-size: 6pt; text-align: right; ddo-char-set: 0";
    this.TextBox19.Text = (string) null;
    ((ARControl) this.TextBox19).Top = 0.0f;
    ((ARControl) this.TextBox19).Width = 0.5625002f;
    ((ARControl) this.TextBox17).DataField = "TargetPremium";
    ((ARControl) this.TextBox17).Height = 0.125f;
    ((ARControl) this.TextBox17).Left = 10.5f;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = resourceManager.GetString("TextBox17.OutputFormat");
    this.TextBox17.Style = "font-size: 6pt; text-align: right; ddo-char-set: 0";
    this.TextBox17.Text = (string) null;
    ((ARControl) this.TextBox17).Top = 0.0f;
    ((ARControl) this.TextBox17).Width = 0.5625004f;
    ((ARControl) this.TextBox2).DataField = "ProducerName";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 29f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 13f / 16f;
    ((ARControl) this.TextBox3).DataField = "Underwriter";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 115f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 11f / 16f;
    ((ARControl) this.TextBox4).DataField = "DateSubmitted";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 9.374999f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.625f;
    ((ARControl) this.TextBox5).DataField = "EffectiveDate";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 9.999999f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.5f;
    ((ARControl) this.Insured).DataField = "Insured";
    ((ARControl) this.Insured).Height = 0.125f;
    ((ARControl) this.Insured).Left = 3.875f;
    ((ARControl) this.Insured).Name = "Insured";
    this.Insured.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.Insured.Text = " ";
    ((ARControl) this.Insured).Top = 0.0f;
    ((ARControl) this.Insured).Width = 13f / 16f;
    ((ARControl) this.PolicyNum).DataField = "PolicyNumber";
    ((ARControl) this.PolicyNum).Height = 0.125f;
    ((ARControl) this.PolicyNum).Left = 9f / 16f;
    ((ARControl) this.PolicyNum).Name = "PolicyNum";
    this.PolicyNum.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.PolicyNum.Text = (string) null;
    ((ARControl) this.PolicyNum).Top = 0.0f;
    ((ARControl) this.PolicyNum).Width = 11f / 16f;
    ((ARControl) this.BusinessType).DataField = "InHouseProducer";
    ((ARControl) this.BusinessType).Height = 0.125f;
    ((ARControl) this.BusinessType).Left = 2.625f;
    ((ARControl) this.BusinessType).Name = "BusinessType";
    this.BusinessType.Style = "font-size: 6.75pt; text-align: center; ddo-char-set: 0";
    this.BusinessType.Text = " ";
    ((ARControl) this.BusinessType).Top = 0.0f;
    ((ARControl) this.BusinessType).Width = 9f / 16f;
    ((ARControl) this.BusinessType1).DataField = "Status";
    ((ARControl) this.BusinessType1).Height = 0.125f;
    ((ARControl) this.BusinessType1).Left = 0.0f;
    ((ARControl) this.BusinessType1).Name = "BusinessType1";
    this.BusinessType1.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.BusinessType1.Text = " ";
    ((ARControl) this.BusinessType1).Top = 0.0f;
    ((ARControl) this.BusinessType1).Width = 9f / 16f;
    ((ARControl) this.Issued).DataField = "DateIssued";
    ((ARControl) this.Issued).Height = 0.125f;
    ((ARControl) this.Issued).Left = 8.874999f;
    ((ARControl) this.Issued).Name = "Issued";
    this.Issued.OutputFormat = resourceManager.GetString("Issued.OutputFormat");
    this.Issued.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.Issued.Text = " ";
    ((ARControl) this.Issued).Top = 0.0f;
    ((ARControl) this.Issued).Width = 0.5f;
    ((ARControl) this.TextBox6).DataField = "CostCenter";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 12.75f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "font-size: 6pt; text-align: right; ddo-char-set: 0";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 0.6249998f;
    ((ARControl) this.TextBox7).DataField = "Carrier";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 75f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 13f / 16f;
    ((ARControl) this.Type).DataField = "Type";
    ((ARControl) this.Type).Height = 0.125f;
    ((ARControl) this.Type).Left = 135f / 16f;
    ((ARControl) this.Type).Name = "Type";
    this.Type.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.Type.Text = " ";
    ((ARControl) this.Type).Top = 0.0f;
    ((ARControl) this.Type).Width = 0.4375004f;
    ((ARControl) this.TextBox8).DataField = "LineOfBusiness";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 5.5f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 11f / 16f;
    ((ARControl) this.TextBox9).DataField = "RiskDescription";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 6.5f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 11f / 16f;
    ((ARControl) this.TextBox10).DataField = "Assistant";
    ((ARControl) this.TextBox10).Height = 0.125f;
    ((ARControl) this.TextBox10).Left = 7.875f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 0.5624998f;
    ((ARControl) this.TextBox11).DataField = "State";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 99f / 16f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox11.Text = " ";
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 5f / 16f;
    ((ARControl) this.TextBox13).DataField = "ControlNo";
    ((ARControl) this.TextBox13).Height = 0.125f;
    ((ARControl) this.TextBox13).Left = 1.25f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox13.Text = (string) null;
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Width = 9f / 16f;
    ((ARControl) this.TextBox14).DataField = "ProducerContact";
    ((ARControl) this.TextBox14).Height = 0.125f;
    ((ARControl) this.TextBox14).Left = 51f / 16f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox14.Text = " ";
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Width = 11f / 16f;
    ((ARControl) this.TextBox16).DataField = "QuoteStatusComment";
    ((ARControl) this.TextBox16).Height = 0.125f;
    ((ARControl) this.TextBox16).Left = 6.125f;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox16.Text = (string) null;
    ((ARControl) this.TextBox16).Top = 0.187f;
    ((ARControl) this.TextBox16).Width = 7.063f;
    ((ARControl) this.Label23).Height = 0.125f;
    this.Label23.HyperLink = (string) null;
    ((ARControl) this.Label23).Left = 0.0f;
    ((ARControl) this.Label23).Name = "Label23";
    this.Label23.Style = "font-size: 6.75pt; font-weight: normal; vertical-align: top";
    this.Label23.Text = "Billing Type:";
    ((ARControl) this.Label23).Top = 0.187f;
    ((ARControl) this.Label23).Width = 0.562f;
    ((ARControl) this.TextBox15).DataField = "BillingType";
    ((ARControl) this.TextBox15).Height = 0.125f;
    ((ARControl) this.TextBox15).Left = 0.562f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.Style = "font-size: 6.75pt; vertical-align: top; ddo-char-set: 0";
    this.TextBox15.Text = (string) null;
    ((ARControl) this.TextBox15).Top = 0.187f;
    ((ARControl) this.TextBox15).Width = 1.375f;
    ((ARControl) this.Label24).Height = 0.125f;
    this.Label24.HyperLink = (string) null;
    ((ARControl) this.Label24).Left = 2.187f;
    ((ARControl) this.Label24).Name = "Label24";
    this.Label24.Style = "font-size: 6.75pt; font-weight: normal; vertical-align: top";
    this.Label24.Text = "Finance Company:";
    ((ARControl) this.Label24).Top = 0.187f;
    ((ARControl) this.Label24).Width = 0.875f;
    ((ARControl) this.TextBox21).DataField = "FinanceCompany";
    ((ARControl) this.TextBox21).Height = 0.125f;
    ((ARControl) this.TextBox21).Left = 3.062f;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.Style = "font-size: 6.75pt; vertical-align: top; ddo-char-set: 0";
    this.TextBox21.Text = (string) null;
    ((ARControl) this.TextBox21).Top = 0.187f;
    ((ARControl) this.TextBox21).Width = 2.125f;
    ((ARControl) this.Label25).Height = 0.125f;
    this.Label25.HyperLink = (string) null;
    ((ARControl) this.Label25).Left = 5.375f;
    ((ARControl) this.Label25).Name = "Label25";
    this.Label25.Style = "font-size: 6.75pt; font-weight: normal; vertical-align: top";
    this.Label25.Text = "Quote Comment:";
    ((ARControl) this.Label25).Top = 0.187f;
    ((ARControl) this.Label25).Width = 0.75f;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 0.0f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 0.375f;
    ((ARControl) this.Line2).Width = 13.375f;
    this.Line2.X1 = 0.0f;
    this.Line2.X2 = 13.375f;
    this.Line2.Y1 = 0.375f;
    this.Line2.Y2 = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.txtSubTitle
    });
    this.ReportHeader.Height = 0.5104167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.lblTitle).Height = 0.25f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 14pt; text-align: center";
    this.lblTitle.Text = "Clearance Report";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 13.375f;
    ((ARControl) this.txtSubTitle).Height = 3f / 16f;
    ((ARControl) this.txtSubTitle).Left = 0.0f;
    ((ARControl) this.txtSubTitle).Name = "txtSubTitle";
    this.txtSubTitle.Style = "ddo-char-set: 0";
    this.txtSubTitle.Text = (string) null;
    ((ARControl) this.txtSubTitle).Top = 0.25f;
    ((ARControl) this.txtSubTitle).Width = 13.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label22,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox12
    });
    this.ReportFooter.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Label22).Height = 0.1458333f;
    this.Label22.HyperLink = (string) null;
    ((ARControl) this.Label22).Left = 0.0f;
    ((ARControl) this.Label22).Name = "Label22";
    this.Label22.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label22.Text = "Total";
    ((ARControl) this.Label22).Top = 0.0f;
    ((ARControl) this.Label22).Width = 9f / 16f;
    ((ARControl) this.TextBox1).DataField = "QuotedPremium";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 367f / 32f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "font-size: 6pt; text-align: right; ddo-char-set: 0";
    this.TextBox1.SummaryRunning = (SummaryRunning) 2;
    this.TextBox1.SummaryType = (SummaryType) 1;
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 0.7187495f;
    ((ARControl) this.TextBox12).DataField = "BasePremium";
    ((ARControl) this.TextBox12).Height = 0.125f;
    ((ARControl) this.TextBox12).Left = 195f / 16f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "font-size: 6pt; text-align: right; ddo-char-set: 0";
    this.TextBox12.SummaryRunning = (SummaryRunning) 2;
    this.TextBox12.SummaryType = (SummaryType) 1;
    this.TextBox12.Text = (string) null;
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 0.7187495f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gh).Controls.AddRange(new ARControl[23]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.Label17,
      (ARControl) this.Label18,
      (ARControl) this.Label19,
      (ARControl) this.Label20,
      (ARControl) this.Label21,
      (ARControl) this.Line1
    });
    this.gh.Height = 0.3958333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gh).Name = "gh";
    this.gh.RepeatStyle = (RepeatStyle) 1;
    ((ARControl) this.Label2).Height = 5f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 29f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label2.Text = "Producer";
    ((ARControl) this.Label2).Top = 0.0f;
    ((ARControl) this.Label2).Width = 13f / 16f;
    ((ARControl) this.Label3).Height = 5f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 115f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label3.Text = "Underwriter";
    ((ARControl) this.Label3).Top = 0.0f;
    ((ARControl) this.Label3).Width = 11f / 16f;
    ((ARControl) this.Label4).Height = 5f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 9.374999f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label4.Text = "Submitted";
    ((ARControl) this.Label4).Top = 0.0f;
    ((ARControl) this.Label4).Width = 0.625f;
    ((ARControl) this.Label5).Height = 5f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 9.999999f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label5.Text = "Effective";
    ((ARControl) this.Label5).Top = 0.0f;
    ((ARControl) this.Label5).Width = 0.5f;
    ((ARControl) this.Label6).Height = 5f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 3.875f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label6.Text = "Insured";
    ((ARControl) this.Label6).Top = 0.0f;
    ((ARControl) this.Label6).Width = 13f / 16f;
    ((ARControl) this.Label7).Height = 5f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 9f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label7.Text = "Policy #";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 11f / 16f;
    ((ARControl) this.Label8).Height = 5f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 2.625f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label8.Text = "In-House Producer";
    ((ARControl) this.Label8).Top = 0.0f;
    ((ARControl) this.Label8).Width = 9f / 16f;
    ((ARControl) this.Label9).Height = 5f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.0f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label9.Text = "Status";
    ((ARControl) this.Label9).Top = 0.0f;
    ((ARControl) this.Label9).Width = 9f / 16f;
    ((ARControl) this.Label10).Height = 5f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 8.874999f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label10.Text = "Issued";
    ((ARControl) this.Label10).Top = 0.0f;
    ((ARControl) this.Label10).Width = 0.5f;
    ((ARControl) this.Label).Height = 5f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 10.5f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label.Text = "Target Premium";
    ((ARControl) this.Label).Top = 0.0f;
    ((ARControl) this.Label).Width = 0.5625004f;
    ((ARControl) this.Label1).Height = 5f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 177f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label1.Text = "Previous Premium";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 0.5624999f;
    ((ARControl) this.Label11).Height = 5f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 195f / 16f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label11.Text = "Bound Premium";
    ((ARControl) this.Label11).Top = 0.0f;
    ((ARControl) this.Label11).Width = 0.5624997f;
    ((ARControl) this.Label12).Height = 5f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 75f / 16f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label12.Text = "Carrier";
    ((ARControl) this.Label12).Top = 0.0f;
    ((ARControl) this.Label12).Width = 13f / 16f;
    ((ARControl) this.Label13).Height = 5f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 135f / 16f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label13.Text = "Type";
    ((ARControl) this.Label13).Top = 0.0f;
    ((ARControl) this.Label13).Width = 0.4375004f;
    ((ARControl) this.Label14).Height = 5f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 5.5f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 8.25pt; font-weight: bold; vertical-align: middle; ddo-char-set: 0";
    this.Label14.Text = "Line of Business";
    ((ARControl) this.Label14).Top = 0.0f;
    ((ARControl) this.Label14).Width = 11f / 16f;
    ((ARControl) this.Label15).Height = 5f / 16f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 6.5f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "font-size: 8.25pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label15.Text = "Risk Description";
    ((ARControl) this.Label15).Top = 0.0f;
    ((ARControl) this.Label15).Width = 11f / 16f;
    ((ARControl) this.Label16).Height = 5f / 16f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 7.875f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label16.Text = "Assistant";
    ((ARControl) this.Label16).Top = 0.0f;
    ((ARControl) this.Label16).Width = 0.5624998f;
    ((ARControl) this.Label17).Height = 5f / 16f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 99f / 16f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "font-size: 8.25pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label17.Text = "State";
    ((ARControl) this.Label17).Top = 0.0f;
    ((ARControl) this.Label17).Width = 5f / 16f;
    ((ARControl) this.Label18).Height = 5f / 16f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 11.625f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "font-size: 8.25pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.Label18.Text = "Quoted Premium";
    ((ARControl) this.Label18).Top = 0.0f;
    ((ARControl) this.Label18).Width = 0.5625002f;
    ((ARControl) this.Label19).Height = 5f / 16f;
    this.Label19.HyperLink = (string) null;
    ((ARControl) this.Label19).Left = 1.25f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label19.Text = "Control #";
    ((ARControl) this.Label19).Top = 0.0f;
    ((ARControl) this.Label19).Width = 9f / 16f;
    ((ARControl) this.Label20).Height = 5f / 16f;
    this.Label20.HyperLink = (string) null;
    ((ARControl) this.Label20).Left = 51f / 16f;
    ((ARControl) this.Label20).Name = "Label20";
    this.Label20.Style = "font-size: 8pt; font-weight: bold; vertical-align: bottom";
    this.Label20.Text = "Producer Contact";
    ((ARControl) this.Label20).Top = 0.0f;
    ((ARControl) this.Label20).Width = 11f / 16f;
    ((ARControl) this.Label21).Height = 5f / 16f;
    this.Label21.HyperLink = (string) null;
    ((ARControl) this.Label21).Left = 12.75f;
    ((ARControl) this.Label21).Name = "Label21";
    this.Label21.Style = "font-size: 8.25pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label21.Text = "Cost Center";
    ((ARControl) this.Label21).Top = 0.0f;
    ((ARControl) this.Label21).Width = 0.6249998f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 0.0f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 0.375f;
    ((ARControl) this.Line1).Width = 13.375f;
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 13.375f;
    this.Line1.Y1 = 0.375f;
    this.Line1.Y2 = 0.375f;
    this.gf.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gf).Name = "gf";
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
    this.PrintWidth = 13.41667f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gh);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gf);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.Insured).EndInit();
    ((ISupportInitialize) this.PolicyNum).EndInit();
    ((ISupportInitialize) this.BusinessType).EndInit();
    ((ISupportInitialize) this.BusinessType1).EndInit();
    ((ISupportInitialize) this.Issued).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.Type).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.Label23).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.Label24).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
    ((ISupportInitialize) this.Label25).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.txtSubTitle).EndInit();
    ((ISupportInitialize) this.Label22).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.Label20).EndInit();
    ((ISupportInitialize) this.Label21).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void setSubTitle() => this.txtSubTitle.Text = "";

  private void rptClearance_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.setSubTitle();
    object producerGuids = (object) DBNull.Value;
    object producerLocations = (object) DBNull.Value;
    object producerLocationRegions = (object) DBNull.Value;
    if (this._ProducerGuids.Length > 0)
      producerGuids = (object) this._ProducerGuids;
    if (this._ProducerLocations.Length > 0)
      producerLocations = (object) this._ProducerLocations;
    if (!this._ProducerLocationRegions.Equals(string.Empty))
      producerLocationRegions = (object) this._ProducerLocationRegions;
    object lineGuid = (object) DBNull.Value;
    if (!this._LineGuid.Equals(string.Empty))
      lineGuid = (object) this._LineGuid;
    object currentUserGuid = (object) DBNull.Value;
    if (SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid") && !this.CurrentUserGuid.Equals(Guid.Empty))
      currentUserGuid = (object) this.CurrentUserGuid;
    try
    {
      this._dt = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, nameof (rptClearance), 0, (CommandArgumentType) 0, new object[42]
      {
        (object) "@SubmittedDateFrom",
        Interaction.IIf(DateTime.Compare(this._DateSubmittedFrom, DateTime.MinValue) != 0, (object) this._DateSubmittedFrom, (object) DBNull.Value),
        (object) "@SubmittedDateTo",
        Interaction.IIf(DateTime.Compare(this._DateSubmittedTo, DateTime.MinValue) != 0, (object) this._DateSubmittedTo, (object) DBNull.Value),
        (object) "@EffectiveDateFrom",
        Interaction.IIf(DateTime.Compare(this._DateEffectiveFrom, DateTime.MinValue) != 0, (object) this._DateEffectiveFrom, (object) DBNull.Value),
        (object) "@EffectiveDateTo",
        Interaction.IIf(DateTime.Compare(this._DateEffectiveTo, DateTime.MinValue) != 0, (object) this._DateEffectiveTo, (object) DBNull.Value),
        (object) "@ProducerGuids",
        producerGuids,
        (object) "@UnderwriterGuid",
        Interaction.IIf(!this._UnderwriterGuid.Equals(Guid.Empty), (object) this._UnderwriterGuid, (object) DBNull.Value),
        (object) "@InHouseProducerGuid",
        Interaction.IIf(!this._InHouseProducerGuid.Equals(Guid.Empty), (object) this._InHouseProducerGuid, (object) DBNull.Value),
        (object) "@QuotingOfficeLocation",
        Interaction.IIf(!this._QuotingOfficeLocation.Equals(Guid.Empty), (object) this._QuotingOfficeLocation, (object) DBNull.Value),
        (object) "@IssuingOfficeLocations",
        Interaction.IIf(!this._IssuingOfficeLocations.Equals(string.Empty), (object) this._IssuingOfficeLocations, (object) DBNull.Value),
        (object) "@CompanyGroupGuid",
        Interaction.IIf(!this._CompanyGroupGuid.Equals(Guid.Empty), (object) this._CompanyGroupGuid, (object) DBNull.Value),
        (object) "@GetCount",
        (object) false,
        (object) "@QuoteStatusID",
        Interaction.IIf(!this._QuoteStatusID.Equals(string.Empty), (object) this._QuoteStatusID, (object) DBNull.Value),
        (object) "@CompanyLocationGuid",
        Interaction.IIf(!this._CompanyLocationGuid.Equals(Guid.Empty), (object) this._CompanyLocationGuid, (object) DBNull.Value),
        (object) "@StateID",
        Interaction.IIf(!this._StateID.Equals(string.Empty), (object) this._StateID, (object) DBNull.Value),
        (object) "@IntermediaryGuid",
        Interaction.IIf(!this._IntermediaryGuid.Equals(Guid.Empty), (object) this._IntermediaryGuid, (object) DBNull.Value),
        (object) "@ProducerLocationRegions",
        producerLocationRegions,
        (object) "@ProducerLocations",
        producerLocations,
        (object) "@PolicyTypeID",
        Interaction.IIf(this._PolicyTypeID > 0, (object) this._PolicyTypeID, (object) DBNull.Value),
        (object) "@LineGuid",
        lineGuid,
        (object) "@CostCenterID",
        Interaction.IIf(this._CostCenterID > 0, (object) this._CostCenterID, (object) DBNull.Value),
        (object) "@CurrentUserGuid",
        currentUserGuid
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.HandleErrorOnThread((Control) MDIControls.Instance.MDIParent, ex);
      ProjectData.ClearProjectError();
    }
    this.DataSource = (object) this._dt;
  }

  public override bool IsThreaded => true;

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    Messaging.SendBroadcastMessage(BroadcastMessages.LaunchPolicyDetailScreen, (object) Conversions.ToInteger(e.HyperLink));
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
  }

  private void Detail_Format(object sender, EventArgs e)
  {
    if (this.TextBox13.Text == null)
      return;
    this.TextBox13.HyperLink = this.TextBox13.Text.ToString();
  }

  public override bool ExcelOnly => this._excelOnly;

  public System.Type getLaunchForm => (System.Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      Underwriters underwriters = !SecurityManager.Instance.AssertPermission("{9865D7C4-B8A1-41a6-88E0-21E29D53A1A3}") ? new Underwriters("Underwriter", this.CurrentUserGuid) : new Underwriters("Underwriter", true);
      GenericComboBox genericComboBox = !SecurityManager.Instance.AssertPermission("{A7880375-830C-471c-A3F0-97308F7C77E9}") ? new GenericComboBox("In-House Producer", string.Format("(SELECT -1 As Sort, 'All In-House Producers' As UserName, '{0}' As UserGuid) UNION (SELECT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblUsers WHERE UserGuid = '{0}')", (object) this.CurrentUserGuid), "UserGuid", "UserName", typeof (Guid)) : new GenericComboBox("In-House Producer", $"(SELECT -1 As Sort, 'All In-House Producers' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblSubmissionGroup INNER JOIN tblUsers ON tblSubmissionGroup.InHouseProducerUserGuid = tblUsers.UserGUID) ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid));
      return new BaseReportControl[17]
      {
        (BaseReportControl) new Producers_Multi("Producer(s)", true),
        (BaseReportControl) new GenericListBox("Producer Regions", "SELECT ProducerRegion, ID FROM lstProducerLocationRegions ORDER BY ProducerRegion", "ID", "ProducerRegion", true, typeof (int), true, false),
        (BaseReportControl) new CompanyLocations("Company", true),
        (BaseReportControl) new GenericComboBox("Intermediary", $"(SELECT -1 As SortBy, 'All Intermediaries' As Display, '{Guid.Empty}' As Value) UNION (SELECT 1 As SortBy, IntermediaryName As Display, IntermediaryGuid As Value FROM tblIntermediaries) ORDER BY SortBy, Display", "Value", "Display", typeof (Guid)),
        (BaseReportControl) underwriters,
        (BaseReportControl) genericComboBox,
        (BaseReportControl) new OfficeLocations("Quoting Office Location", true, false),
        (BaseReportControl) new GenericListBox("Issuing Office Location", "SELECT Location AS Display, OfficeGUID AS Value FROM dbo.tblClientOffices ORDER BY Location", "Value", "Display", true, typeof (Guid), true, false),
        (BaseReportControl) new GenericComboBox("Company Group", $"((SELECT -1 As Sort, 'All Groups' As CompanyGroupName, '{Guid.Empty}' As CompanyGroupGuid) UNION (SELECT 1 As Sort, CompanyGroupName, CompanyGroupGuid FROM tblCompanyGroups)) ORDER BY Sort, CompanyGroupName", "CompanyGroupGuid", "CompanyGroupName", typeof (Guid)),
        (BaseReportControl) new GenericListBox("Quote Status", "SELECT Description AS Display, CAST(QuoteStatusID as integer) AS Value FROM lstQuoteStatus  ORDER BY Description", "Value", "Display", true, typeof (int), true, false),
        (BaseReportControl) new GenericComboBox("State", $"SELECT '{string.Empty}' As StateID, 'All States' As State UNION SELECT StateID, State FROM lstStates", "StateID", "State", typeof (string)),
        (BaseReportControl) new GenericComboBox("Policy Type", "((SELECT -1 As Sort, 0 As Value, 'All Policy Types' As Display) UNION (SELECT 1 As Sort, PolicyTypeID As Value, Description As Display FROM lstPolicyTypes)) ORDER BY Sort, Display", "Value", "Display", typeof (int)),
        (BaseReportControl) new DateRangePicker("Submitted", true),
        (BaseReportControl) new DateRangePicker("Effective", true),
        (BaseReportControl) new GenericListBox("Line of Business", "Select LineName as Display, LineGuid as Value From lstlines Order BY LineName", "Value", "Display", true, typeof (Guid), true, false),
        (BaseReportControl) new GenericComboBox("Cost Center", "((SELECT -1 As Sort, 'All Cost Centers' As Display, 0 As Value) UNION (SELECT 1 As Sort, GroupName AS Display, GroupId AS Value FROM tblEntityGroups)) ORDER BY Sort, Display", "Value", "Display", typeof (int)),
        (BaseReportControl) new GenericCheckBox("", "Excel Only")
      };
    }
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
  }

  [field: AccessedThroughProperty("TextBox13")]
  private virtual TextBox TextBox13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label19")]
  private virtual Label Label19 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox14")]
  private virtual TextBox TextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label20")]
  private virtual Label Label20 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("Label21")]
  private virtual Label Label21 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label22")]
  private virtual Label Label22 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox1")]
  internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  internal virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gh")]
  private virtual GroupHeader gh { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual Detail Detail
  {
    get => this._Detail;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.Detail_BeforePrint);
      EventHandler eventHandler2 = new EventHandler(this.Detail_Format);
      Detail detail1 = this._Detail;
      if (detail1 != null)
      {
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).BeforePrint -= eventHandler1;
        ((GrapeCity.ActiveReports.SectionReportModel.Section) detail1).Format -= eventHandler2;
      }
      this._Detail = value;
      Detail detail2 = this._Detail;
      if (detail2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).BeforePrint += eventHandler1;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) detail2).Format += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("gf")]
  private virtual GroupFooter gf { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
