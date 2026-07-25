// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.rptLossRun
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Reporting;

[SecureReportResource("{D9F30AD7-152A-4312-967D-BBDC9FB40F4A}", "Loss Run", "IMS Default Loss Run.", "General")]
[ClearanceContextMenu("Loss Run Report", "Reports", ClearanceContextMenuLevelEnum.Quote)]
public class rptLossRun : MGAReport, IReport, ISaveDocumentHandler
{
  internal const string ReportGuid = "{D9F30AD7-152A-4312-967D-BBDC9FB40F4A}";
  private DataSet _ds;
  private readonly string _PolicyNumber;
  private readonly string _QuoteGuid;
  protected Quote Quote;
  protected string ProcedureName;
  private Label Label6;
  private Label Label7;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label Label11;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private TextBox txtHeader_Company;
  private Label Label;
  private Line Line;
  private TextBox txtHeader_PolicyNum;
  private TextBox txtHeader_Producer;
  private Label Label1;
  private TextBox txtHeader_AsOf;
  private Label Label2;
  private TextBox txtHeader_Term;
  private Label Label3;
  private TextBox txtHeader_PolicyType;
  private Label Label4;
  private TextBox txtHeader_LineOfBusiness;
  private Label Label5;
  private TextBox txtHeader_Insured;
  private TextBox TextBox;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private TextBox TextBox13;
  private Label Label16;

  [field: AccessedThroughProperty("Picture1")]
  private virtual Picture Picture1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox14")]
  private virtual TextBox TextBox14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox15")]
  private virtual TextBox TextBox15 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label17")]
  private virtual Label Label17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label18")]
  private virtual Label Label18 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox16")]
  private virtual TextBox TextBox16 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox17")]
  private virtual TextBox TextBox17 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptLossRun()
  {
    this.ReportStart += new EventHandler(this.rptLossRun_ReportStart);
    this.ProcedureName = "dbo.rptLossRun";
    this.InitializeComponent();
  }

  public rptLossRun(string PolicyNumber)
  {
    this.ReportStart += new EventHandler(this.rptLossRun_ReportStart);
    this.ProcedureName = "dbo.rptLossRun";
    this.InitializeComponent();
    this._PolicyNumber = PolicyNumber;
  }

  public rptLossRun(Guid QuoteGuid)
  {
    this.ReportStart += new EventHandler(this.rptLossRun_ReportStart);
    this.ProcedureName = "dbo.rptLossRun";
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid.ToString();
    this.Quote = Quote.CreateNew(QuoteGuid);
  }

  private void rptLossRun_ReportStart(object sender, EventArgs e)
  {
    if (this.Quote == null)
    {
      Guid result;
      if (!string.IsNullOrEmpty(this._QuoteGuid) && !Guid.TryParse(this._QuoteGuid, out result))
        return;
      if (!string.IsNullOrEmpty(this._PolicyNumber))
        result = DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT TOP 1 QuoteGUID FROM dbo.tblQuotes WITH(NOLOCK) WHERE PolicyNumber = @PolicyNumber ORDER BY QuoteID DESC", new object[2]
        {
          (object) "@PolicyNumber",
          (object) this._PolicyNumber
        }) ?? Guid.Empty;
      if (result.Equals(Guid.Empty))
        return;
      this.Quote = Quote.CreateNew(result);
    }
    this.ReportQuoteGuid = this.Quote.QuoteGuid;
    List<object> objectList = new List<object>()
    {
      (object) "@QuoteGuid",
      (object) this.Quote.QuoteGuid
    };
    if (MGASystems.IMS.NoteDocuments.SystemSettings.GetSetting<bool>("CheckQuotingOfficeGuid", false))
      objectList.AddRange((IEnumerable<object>) new object[2]
      {
        (object) "@CurrentUserGuid",
        (object) this.CurrentUserGuid
      });
    this._ds = DefaultDatabase.ExecuteDataSet(this.StoredProcedure, objectList.ToArray());
    this.DataSource = (object) this._ds.Tables[0];
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptLossRun));
    this.Detail = new Detail();
    this.TextBox = new TextBox();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.GroupHeader1 = new GroupHeader();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.txtHeader_Company = new TextBox();
    this.Label = new Label();
    this.Line = new Line();
    this.txtHeader_PolicyNum = new TextBox();
    this.txtHeader_Producer = new TextBox();
    this.Label1 = new Label();
    this.txtHeader_AsOf = new TextBox();
    this.Label2 = new Label();
    this.txtHeader_Term = new TextBox();
    this.Label3 = new Label();
    this.txtHeader_PolicyType = new TextBox();
    this.Label4 = new Label();
    this.txtHeader_LineOfBusiness = new TextBox();
    this.Label5 = new Label();
    this.txtHeader_Insured = new TextBox();
    this.Picture1 = new Picture();
    this.GroupFooter1 = new GroupFooter();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.Label16 = new Label();
    this.txtFooterNote = new TextBox();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.TextBox14 = new TextBox();
    this.TextBox15 = new TextBox();
    this.TextBox16 = new TextBox();
    this.TextBox17 = new TextBox();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.txtHeader_Company).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.txtHeader_PolicyNum).BeginInit();
    ((ISupportInitialize) this.txtHeader_Producer).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtHeader_AsOf).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.txtHeader_Term).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.txtHeader_PolicyType).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.txtHeader_LineOfBusiness).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtHeader_Insured).BeginInit();
    ((ISupportInitialize) this.Picture1).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.txtFooterNote).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.TextBox,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox15
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox).DataField = "ControlNo";
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 0.0f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 9pt; vertical-align: middle";
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 11f / 16f;
    ((ARControl) this.TextBox1).DataField = "ClaimNo";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 11f / 16f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 9pt; vertical-align: middle";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 1f;
    ((ARControl) this.TextBox2).DataField = "DateOfLoss";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 27f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 9pt; vertical-align: middle";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 11f / 16f;
    ((ARControl) this.TextBox3).DataField = "DateReported";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 2.375f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 9pt; vertical-align: middle";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 11f / 16f;
    ((ARControl) this.TextBox4).DataField = "Closed";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 49f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 9pt; text-align: center; vertical-align: middle";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 11f / 16f;
    ((ARControl) this.TextBox5).DataField = "DescriptionofClaim";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 3.75f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 9pt; vertical-align: middle";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 1.937f;
    ((ARControl) this.TextBox6).DataField = "Paid";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 7.25f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 0.7489991f;
    ((ARControl) this.TextBox7).DataField = "Expense";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 8f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 0.7489991f;
    ((ARControl) this.TextBox8).DataField = "Reserve";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 8.75f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 0.7489991f;
    ((ARControl) this.TextBox9).DataField = "Incurred";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 9.5f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 0.8120008f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[28]
    {
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.txtHeader_Company,
      (ARControl) this.Label,
      (ARControl) this.Line,
      (ARControl) this.txtHeader_PolicyNum,
      (ARControl) this.txtHeader_Producer,
      (ARControl) this.Label1,
      (ARControl) this.txtHeader_AsOf,
      (ARControl) this.Label2,
      (ARControl) this.txtHeader_Term,
      (ARControl) this.Label3,
      (ARControl) this.txtHeader_PolicyType,
      (ARControl) this.Label4,
      (ARControl) this.txtHeader_LineOfBusiness,
      (ARControl) this.Label5,
      (ARControl) this.txtHeader_Insured,
      (ARControl) this.Picture1,
      (ARControl) this.Label17,
      (ARControl) this.Label18
    });
    this.GroupHeader1.DataField = "LineAndEffective";
    this.GroupHeader1.Height = 2.135417f;
    this.GroupHeader1.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    this.GroupHeader1.NewPage = (NewPage) 1;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 0.375f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 0.0f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle";
    this.Label6.Text = "Control No";
    ((ARControl) this.Label6).Top = 1.75f;
    ((ARControl) this.Label6).Width = 11f / 16f;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label7).Height = 0.375f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 11f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle";
    this.Label7.Text = "Claim No";
    ((ARControl) this.Label7).Top = 1.75f;
    ((ARControl) this.Label7).Width = 1f;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label8).Height = 0.375f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 27f / 16f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle";
    this.Label8.Text = "Date of Loss";
    ((ARControl) this.Label8).Top = 1.75f;
    ((ARControl) this.Label8).Width = 11f / 16f;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label9).Height = 0.375f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 2.375f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle";
    this.Label9.Text = "Date Reported";
    ((ARControl) this.Label9).Top = 1.75f;
    ((ARControl) this.Label9).Width = 11f / 16f;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Height = 0.375f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 49f / 16f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 9pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.Label10.Text = "Status";
    ((ARControl) this.Label10).Top = 1.75f;
    ((ARControl) this.Label10).Width = 11f / 16f;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Height = 0.375f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 3.75f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 9pt; font-weight: bold; vertical-align: middle";
    this.Label11.Text = "Description of Claim";
    ((ARControl) this.Label11).Top = 1.75f;
    ((ARControl) this.Label11).Width = 1.937f;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Height = 0.375f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 7.25f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 9pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.Label12.Text = "Paid";
    ((ARControl) this.Label12).Top = 1.75f;
    ((ARControl) this.Label12).Width = 0.7489991f;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Height = 0.375f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 8f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 9pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.Label13.Text = "Expense";
    ((ARControl) this.Label13).Top = 1.75f;
    ((ARControl) this.Label13).Width = 0.7489991f;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Height = 0.375f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 8.75f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 9pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.Label14.Text = "Reserve";
    ((ARControl) this.Label14).Top = 1.75f;
    ((ARControl) this.Label14).Width = 0.7489991f;
    ((ARControl) this.Label15).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label15).Height = 0.375f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 9.5f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "font-size: 9pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.Label15.Text = "Incurred";
    ((ARControl) this.Label15).Top = 1.75f;
    ((ARControl) this.Label15).Width = 0.8120008f;
    ((ARControl) this.txtHeader_Company).DataField = "Companyname";
    ((ARControl) this.txtHeader_Company).Height = 3f / 16f;
    ((ARControl) this.txtHeader_Company).Left = 2.844f;
    ((ARControl) this.txtHeader_Company).Name = "txtHeader_Company";
    this.txtHeader_Company.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.txtHeader_Company.Text = (string) null;
    ((ARControl) this.txtHeader_Company).Top = 0.632f;
    ((ARControl) this.txtHeader_Company).Width = 3.281f;
    ((ARControl) this.Label).Height = 5f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 4.575f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 18pt";
    this.Label.Text = "Loss Run";
    ((ARControl) this.Label).Top = 0.156f;
    ((ARControl) this.Label).Width = 1.25f;
    ((ARControl) this.Line).Height = 0.0f;
    ((ARControl) this.Line).Left = 0.0f;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    ((ARControl) this.Line).Top = 0.0f;
    ((ARControl) this.Line).Width = 10.375f;
    this.Line.X1 = 0.0f;
    this.Line.X2 = 10.375f;
    this.Line.Y1 = 0.0f;
    this.Line.Y2 = 0.0f;
    ((ARControl) this.txtHeader_PolicyNum).DataField = "PolicyNumber";
    ((ARControl) this.txtHeader_PolicyNum).Height = 3f / 16f;
    ((ARControl) this.txtHeader_PolicyNum).Left = 99f / 16f;
    ((ARControl) this.txtHeader_PolicyNum).Name = "txtHeader_PolicyNum";
    this.txtHeader_PolicyNum.Style = "font-size: 9pt; font-weight: bold; ddo-char-set: 0";
    this.txtHeader_PolicyNum.Text = (string) null;
    ((ARControl) this.txtHeader_PolicyNum).Top = 0.632f;
    ((ARControl) this.txtHeader_PolicyNum).Width = 1.75f;
    ((ARControl) this.txtHeader_Producer).DataField = "Producer";
    ((ARControl) this.txtHeader_Producer).Height = 13f / 16f;
    ((ARControl) this.txtHeader_Producer).Left = 8f;
    ((ARControl) this.txtHeader_Producer).Name = "txtHeader_Producer";
    this.txtHeader_Producer.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtHeader_Producer.Text = (string) null;
    ((ARControl) this.txtHeader_Producer).Top = 0.632f;
    ((ARControl) this.txtHeader_Producer).Width = 37f / 16f;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 5.687f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-weight: bold";
    this.Label1.Text = "As of:";
    ((ARControl) this.Label1).Top = 1.5005f;
    ((ARControl) this.Label1).Width = 7f / 16f;
    ((ARControl) this.txtHeader_AsOf).DataField = "AsOf";
    ((ARControl) this.txtHeader_AsOf).Height = 3f / 16f;
    ((ARControl) this.txtHeader_AsOf).Left = 6.187f;
    ((ARControl) this.txtHeader_AsOf).Name = "txtHeader_AsOf";
    this.txtHeader_AsOf.Style = "ddo-char-set: 0";
    this.txtHeader_AsOf.Text = (string) null;
    ((ARControl) this.txtHeader_AsOf).Top = 1.5005f;
    ((ARControl) this.txtHeader_AsOf).Width = 0.75f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 2.844f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-weight: bold";
    this.Label2.Text = "Term:";
    ((ARControl) this.Label2).Top = 0.8824999f;
    ((ARControl) this.Label2).Width = 7f / 16f;
    ((ARControl) this.txtHeader_Term).DataField = "Term";
    ((ARControl) this.txtHeader_Term).Height = 3f / 16f;
    ((ARControl) this.txtHeader_Term).Left = 3.344f;
    ((ARControl) this.txtHeader_Term).Name = "txtHeader_Term";
    this.txtHeader_Term.Style = "ddo-char-set: 0";
    this.txtHeader_Term.Text = (string) null;
    ((ARControl) this.txtHeader_Term).Top = 0.8824999f;
    ((ARControl) this.txtHeader_Term).Width = 29f / 16f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 5.25f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-weight: bold; text-align: right";
    this.Label3.Text = "Policy Type:";
    ((ARControl) this.Label3).Top = 0.882f;
    ((ARControl) this.Label3).Width = 0.875f;
    ((ARControl) this.txtHeader_PolicyType).DataField = "PolicyType";
    ((ARControl) this.txtHeader_PolicyType).Height = 3f / 16f;
    ((ARControl) this.txtHeader_PolicyType).Left = 99f / 16f;
    ((ARControl) this.txtHeader_PolicyType).Name = "txtHeader_PolicyType";
    this.txtHeader_PolicyType.Style = "ddo-char-set: 0";
    this.txtHeader_PolicyType.Text = (string) null;
    ((ARControl) this.txtHeader_PolicyType).Top = 0.882f;
    ((ARControl) this.txtHeader_PolicyType).Width = 1.75f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 79f / 16f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-weight: bold; text-align: right";
    this.Label4.Text = "Line of Business:";
    ((ARControl) this.Label4).Top = 1.132f;
    ((ARControl) this.Label4).Width = 19f / 16f;
    ((ARControl) this.txtHeader_LineOfBusiness).DataField = "LineName";
    ((ARControl) this.txtHeader_LineOfBusiness).Height = 0.3050001f;
    ((ARControl) this.txtHeader_LineOfBusiness).Left = 99f / 16f;
    ((ARControl) this.txtHeader_LineOfBusiness).Name = "txtHeader_LineOfBusiness";
    this.txtHeader_LineOfBusiness.Style = "ddo-char-set: 0";
    this.txtHeader_LineOfBusiness.Text = (string) null;
    ((ARControl) this.txtHeader_LineOfBusiness).Top = 1.132f;
    ((ARControl) this.txtHeader_LineOfBusiness).Width = 1.75f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 0.0f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-weight: bold";
    this.Label5.Text = "for";
    ((ARControl) this.Label5).Top = 1.132f;
    ((ARControl) this.Label5).Width = 5f / 16f;
    ((ARControl) this.txtHeader_Insured).DataField = "InsuredPolicyName";
    ((ARControl) this.txtHeader_Insured).Height = 0.5550001f;
    ((ARControl) this.txtHeader_Insured).Left = 0.375f;
    ((ARControl) this.txtHeader_Insured).Name = "txtHeader_Insured";
    this.txtHeader_Insured.Style = "font-size: 14pt";
    this.txtHeader_Insured.Text = (string) null;
    ((ARControl) this.txtHeader_Insured).Top = 1.132f;
    ((ARControl) this.txtHeader_Insured).Width = 4.5f;
    ((ARControl) this.Picture1).DataField = "Logo";
    ((ARControl) this.Picture1).Height = 1.07f;
    this.Picture1.ImageData = (Stream) null;
    ((ARControl) this.Picture1).Left = 0.0f;
    ((ARControl) this.Picture1).Name = "Picture1";
    this.Picture1.SizeMode = (SizeModes) 2;
    ((ARControl) this.Picture1).Top = 0.0f;
    ((ARControl) this.Picture1).Width = 2.6f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.Label16,
      (ARControl) this.txtFooterNote,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox17
    });
    this.GroupFooter1.Height = 0.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.TextBox10).DataField = "Paid";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 7.25f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox10.SummaryGroup = "GroupHeader1";
    this.TextBox10.SummaryRunning = (SummaryRunning) 1;
    this.TextBox10.SummaryType = (SummaryType) 3;
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 0.7489991f;
    ((ARControl) this.TextBox11).DataField = "Expense";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 8f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox11.SummaryGroup = "GroupHeader1";
    this.TextBox11.SummaryRunning = (SummaryRunning) 1;
    this.TextBox11.SummaryType = (SummaryType) 3;
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.7489991f;
    ((ARControl) this.TextBox12).DataField = "Reserve";
    ((ARControl) this.TextBox12).Height = 3f / 16f;
    ((ARControl) this.TextBox12).Left = 8.75f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox12.SummaryGroup = "GroupHeader1";
    this.TextBox12.SummaryRunning = (SummaryRunning) 1;
    this.TextBox12.SummaryType = (SummaryType) 3;
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 0.7489991f;
    ((ARControl) this.TextBox13).DataField = "Incurred";
    ((ARControl) this.TextBox13).Height = 3f / 16f;
    ((ARControl) this.TextBox13).Left = 9.5f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox13.SummaryGroup = "GroupHeader1";
    this.TextBox13.SummaryRunning = (SummaryRunning) 1;
    this.TextBox13.SummaryType = (SummaryType) 3;
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Width = 0.8120008f;
    ((ARControl) this.Label16).Height = 3f / 16f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 4.4995f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-size: 9pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.Label16.Text = "Totals:";
    ((ARControl) this.Label16).Top = 0.0f;
    ((ARControl) this.Label16).Width = 19f / 16f;
    ((ARControl) this.txtFooterNote).DataField = "footerNote";
    ((ARControl) this.txtFooterNote).Height = 3f / 16f;
    ((ARControl) this.txtFooterNote).Left = 11f / 16f;
    ((ARControl) this.txtFooterNote).Name = "txtFooterNote";
    this.txtFooterNote.Style = "font-size: 12pt; font-weight: bold; ddo-char-set: 0";
    this.txtFooterNote.Text = (string) null;
    ((ARControl) this.txtFooterNote).Top = 3f / 16f;
    ((ARControl) this.txtFooterNote).Width = 123f / 16f;
    ((ARControl) this.Label17).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label17).Height = 0.375f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 6.5f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "font-size: 9pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.Label17.Text = "Salvage";
    ((ARControl) this.Label17).Top = 1.75f;
    ((ARControl) this.Label17).Width = 0.7489991f;
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label18).Height = 0.375f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 5.687f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "font-size: 9pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.Label18.Text = "Subrogation";
    ((ARControl) this.Label18).Top = 1.75f;
    ((ARControl) this.Label18).Width = 0.8119993f;
    ((ARControl) this.TextBox14).DataField = "Subrogation";
    ((ARControl) this.TextBox14).Height = 3f / 16f;
    ((ARControl) this.TextBox14).Left = 5.687f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = resourceManager.GetString("TextBox14.OutputFormat");
    this.TextBox14.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox14.Text = " ";
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Width = 0.8119993f;
    ((ARControl) this.TextBox15).DataField = "Salvage";
    ((ARControl) this.TextBox15).Height = 3f / 16f;
    ((ARControl) this.TextBox15).Left = 6.562f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = resourceManager.GetString("TextBox15.OutputFormat");
    this.TextBox15.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox15.Text = " ";
    ((ARControl) this.TextBox15).Top = 0.0f;
    ((ARControl) this.TextBox15).Width = 0.7489991f;
    ((ARControl) this.TextBox16).DataField = "Subrogation";
    ((ARControl) this.TextBox16).Height = 3f / 16f;
    ((ARControl) this.TextBox16).Left = 5.687f;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = resourceManager.GetString("TextBox16.OutputFormat");
    this.TextBox16.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox16.SummaryGroup = "GroupHeader1";
    this.TextBox16.SummaryRunning = (SummaryRunning) 1;
    this.TextBox16.SummaryType = (SummaryType) 3;
    ((ARControl) this.TextBox16).Top = 0.0f;
    ((ARControl) this.TextBox16).Width = 0.8119993f;
    ((ARControl) this.TextBox17).DataField = "Salvage";
    ((ARControl) this.TextBox17).Height = 3f / 16f;
    ((ARControl) this.TextBox17).Left = 6.562f;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = resourceManager.GetString("TextBox17.OutputFormat");
    this.TextBox17.Style = "font-size: 9pt; text-align: right; vertical-align: middle";
    this.TextBox17.SummaryGroup = "GroupHeader1";
    this.TextBox17.SummaryRunning = (SummaryRunning) 1;
    this.TextBox17.SummaryType = (SummaryType) 3;
    ((ARControl) this.TextBox17).Top = 0.0f;
    ((ARControl) this.TextBox17).Width = 0.7489991f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.4f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.txtHeader_Company).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.txtHeader_PolicyNum).EndInit();
    ((ISupportInitialize) this.txtHeader_Producer).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtHeader_AsOf).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.txtHeader_Term).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.txtHeader_PolicyType).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.txtHeader_LineOfBusiness).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtHeader_Insured).EndInit();
    ((ISupportInitialize) this.Picture1).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.txtFooterNote).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      BaseReportControl[] getReportControls;
      if (!string.IsNullOrEmpty(this._QuoteGuid))
        getReportControls = (BaseReportControl[]) null;
      else
        getReportControls = new BaseReportControl[1]
        {
          (BaseReportControl) new TextInput("Policy Number", true, false)
        };
      return getReportControls;
    }
  }

  public string StoredProcedure
  {
    get => this.ProcedureName;
    set => this.ProcedureName = value;
  }

  public override bool HasRecords
  {
    get
    {
      bool hasRecords;
      if (this.Quote != null)
        hasRecords = this.Quote.RecordExists();
      else
        hasRecords = !((System.ValueType) DefaultDatabase.ExecuteScalar<Guid?>(CommandType.Text, "SELECT TOP 1 QuoteGUID FROM dbo.tblQuotes WITH(NOLOCK) WHERE PolicyNumber = @PolicyNumber ORDER BY QuoteID DESC", new object[2]
        {
          (object) "@PolicyNumber",
          (object) this._PolicyNumber
        }) == null & string.IsNullOrEmpty(this._QuoteGuid));
      return hasRecords;
    }
  }

  public ISaveDocumentHandler.ReportDocHandlerProperties DocHandlerProperties
  {
    get
    {
      return new ISaveDocumentHandler.ReportDocHandlerProperties()
      {
        AskForDocHandlerFolderID = true,
        DocHandlerDescription = "Loss Run",
        DocHandlerFolderID = -1,
        SaveToDocHandler = true,
        ShowMessageBox = false,
        QuoteGUID = this.ReportQuoteGuid
      };
    }
  }

  [field: AccessedThroughProperty("txtFooterNote")]
  private virtual TextBox txtFooterNote { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
