// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptArApBalanceSheetBreakout
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{D1BBE530-DD26-4D92-8711-B0393EE139A6}", "Ar/Ap Balance Sheet Breakout", "Ar/Ap Balance Sheet Breakout.", "Financials")]
public sealed class rptArApBalanceSheetBreakout : MGAReport, IReport
{
  private DataTable exportDetail;
  public const string SecureReportGuid = "{D1BBE530-DD26-4D92-8711-B0393EE139A6}";
  private DateTime _AsOf;
  private string _rpt_Type;
  private DataSet _ds;
  private Label lblTitle;
  private Label lblSubTitle;
  private Label lblInvoiceNumber;
  private Label lblPolicyNumber;
  private Label lblGrossBilled;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private TextBox TextBox11;
  private TextBox bucket13;
  private TextBox TextBox;
  private TextBox TextBox4;

  [field: AccessedThroughProperty("txtEntityType")]
  private virtual TextBox txtEntityType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtEntityName")]
  private virtual TextBox txtEntityName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAmount")]
  private virtual TextBox txtAmount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  private virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("amount")]
  private virtual TextBox amount { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("amount2")]
  private virtual TextBox amount2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBillingType1")]
  private virtual TextBox txtBillingType1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBillingType2")]
  private virtual TextBox txtBillingType2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBillingTypeAmt1")]
  private virtual TextBox txtBillingTypeAmt1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBillingTypeAmt2")]
  private virtual TextBox txtBillingTypeAmt2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtTotal")]
  private virtual TextBox txtTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAgencyAndDirect")]
  private virtual TextBox txtAgencyAndDirect { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader1")]
  private virtual PageHeader PageHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  private virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  private virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter1")]
  private virtual PageFooter PageFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBillingType3")]
  private virtual TextBox txtBillingType3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBillingType4")]
  private virtual TextBox txtBillingType4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBillingTypeAmt3")]
  private virtual TextBox txtBillingTypeAmt3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBillingTypeAmt4")]
  private virtual TextBox txtBillingTypeAmt4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBillingType5")]
  private virtual TextBox txtBillingType5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtBillingTypeAmt5")]
  private virtual TextBox txtBillingTypeAmt5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("EntityType")]
  private virtual TextBox EntityType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptArApBalanceSheetBreakout()
  {
    this.ReportStart += new EventHandler(this.rptArApBalanceSheetBreakout_ReportStart);
    this.exportDetail = new DataTable();
    this._ds = new DataSet();
  }

  public rptArApBalanceSheetBreakout(DateTime AsOf, string rpt_Type)
  {
    this.ReportStart += new EventHandler(this.rptArApBalanceSheetBreakout_ReportStart);
    this.exportDetail = new DataTable();
    this._ds = new DataSet();
    this.InitializeComponent();
    this._AsOf = AsOf;
    this._rpt_Type = rpt_Type;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptArApBalanceSheetBreakout));
    this.Detail = new Detail();
    this.txtEntityType = new TextBox();
    this.txtEntityName = new TextBox();
    this.txtAmount = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.lblTitle = new Label();
    this.lblSubTitle = new Label();
    this.lblBillingType = new Label();
    this.ReportFooter = new ReportFooter();
    this.Line1 = new Line();
    this.Label2 = new Label();
    this.amount2 = new TextBox();
    this.txtBillingType1 = new TextBox();
    this.txtBillingType2 = new TextBox();
    this.txtBillingTypeAmt1 = new TextBox();
    this.txtBillingTypeAmt2 = new TextBox();
    this.txtTotal = new TextBox();
    this.txtAgencyAndDirect = new TextBox();
    this.ghEntity = new GroupHeader();
    this.lblInvoiceNumber = new Label();
    this.lblPolicyNumber = new Label();
    this.lblGrossBilled = new Label();
    this.gfEntity = new GroupFooter();
    this.Label1 = new Label();
    this.amount = new TextBox();
    this.PageHeader1 = new PageHeader();
    this.PageFooter1 = new PageFooter();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.txtBillingType3 = new TextBox();
    this.txtBillingType4 = new TextBox();
    this.txtBillingTypeAmt3 = new TextBox();
    this.txtBillingTypeAmt4 = new TextBox();
    this.txtBillingType5 = new TextBox();
    this.txtBillingTypeAmt5 = new TextBox();
    this.EntityType = new TextBox();
    ((ISupportInitialize) this.txtEntityType).BeginInit();
    ((ISupportInitialize) this.txtEntityName).BeginInit();
    ((ISupportInitialize) this.txtAmount).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.lblSubTitle).BeginInit();
    ((ISupportInitialize) this.lblBillingType).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.amount2).BeginInit();
    ((ISupportInitialize) this.txtBillingType1).BeginInit();
    ((ISupportInitialize) this.txtBillingType2).BeginInit();
    ((ISupportInitialize) this.txtBillingTypeAmt1).BeginInit();
    ((ISupportInitialize) this.txtBillingTypeAmt2).BeginInit();
    ((ISupportInitialize) this.txtTotal).BeginInit();
    ((ISupportInitialize) this.txtAgencyAndDirect).BeginInit();
    ((ISupportInitialize) this.lblInvoiceNumber).BeginInit();
    ((ISupportInitialize) this.lblPolicyNumber).BeginInit();
    ((ISupportInitialize) this.lblGrossBilled).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.amount).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.txtBillingType3).BeginInit();
    ((ISupportInitialize) this.txtBillingType4).BeginInit();
    ((ISupportInitialize) this.txtBillingTypeAmt3).BeginInit();
    ((ISupportInitialize) this.txtBillingTypeAmt4).BeginInit();
    ((ISupportInitialize) this.txtBillingType5).BeginInit();
    ((ISupportInitialize) this.txtBillingTypeAmt5).BeginInit();
    ((ISupportInitialize) this.EntityType).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.txtEntityType,
      (ARControl) this.txtEntityName,
      (ARControl) this.txtAmount
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1979167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.txtEntityType).DataField = "EntityType";
    ((ARControl) this.txtEntityType).Height = 3f / 16f;
    ((ARControl) this.txtEntityType).Left = 0.0f;
    ((ARControl) this.txtEntityType).Name = "txtEntityType";
    this.txtEntityType.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtEntityType.Text = (string) null;
    ((ARControl) this.txtEntityType).Top = 0.0f;
    ((ARControl) this.txtEntityType).Width = 1.323f;
    ((ARControl) this.txtEntityName).DataField = "EntityName";
    ((ARControl) this.txtEntityName).Height = 3f / 16f;
    ((ARControl) this.txtEntityName).Left = 1.375f;
    ((ARControl) this.txtEntityName).Name = "txtEntityName";
    this.txtEntityName.Style = "font-size: 9pt; ddo-char-set: 0";
    this.txtEntityName.Text = (string) null;
    ((ARControl) this.txtEntityName).Top = 0.0f;
    ((ARControl) this.txtEntityName).Width = 4.634001f;
    ((ARControl) this.txtAmount).DataField = "Amount";
    ((ARControl) this.txtAmount).Height = 3f / 16f;
    ((ARControl) this.txtAmount).Left = 6.42f;
    this.txtAmount.MultiLine = false;
    ((ARControl) this.txtAmount).Name = "txtAmount";
    this.txtAmount.OutputFormat = resourceManager.GetString("txtAmount.OutputFormat");
    this.txtAmount.Style = "font-size: 9pt; text-align: right; ddo-char-set: 0";
    this.txtAmount.Text = (string) null;
    ((ARControl) this.txtAmount).Top = 0.0f;
    ((ARControl) this.txtAmount).Width = 1.187001f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.lblSubTitle,
      (ARControl) this.lblBillingType
    });
    this.ReportHeader.Height = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.lblTitle).Height = 3f / 16f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 11.25pt; font-weight: bold; ddo-char-set: 0";
    this.lblTitle.Text = "";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 10.375f;
    ((ARControl) this.lblSubTitle).Height = 0.25f;
    this.lblSubTitle.HyperLink = (string) null;
    ((ARControl) this.lblSubTitle).Left = 0.0f;
    ((ARControl) this.lblSubTitle).Name = "lblSubTitle";
    this.lblSubTitle.Style = "font-size: 11.25pt; font-weight: bold; ddo-char-set: 0";
    this.lblSubTitle.Text = "AR / AP Balance Sheet Breakout as of {0}";
    ((ARControl) this.lblSubTitle).Top = 3f / 16f;
    ((ARControl) this.lblSubTitle).Width = 10.375f;
    ((ARControl) this.lblBillingType).Height = 3f / 16f;
    this.lblBillingType.HyperLink = (string) null;
    ((ARControl) this.lblBillingType).Left = 0.0f;
    ((ARControl) this.lblBillingType).Name = "lblBillingType";
    this.lblBillingType.Style = "font-size: 10pt; ddo-char-set: 0";
    this.lblBillingType.Text = "";
    ((ARControl) this.lblBillingType).Top = 7f / 16f;
    ((ARControl) this.lblBillingType).Width = 10.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[15]
    {
      (ARControl) this.Line1,
      (ARControl) this.Label2,
      (ARControl) this.amount2,
      (ARControl) this.txtBillingType1,
      (ARControl) this.txtBillingType2,
      (ARControl) this.txtBillingTypeAmt1,
      (ARControl) this.txtBillingTypeAmt2,
      (ARControl) this.txtTotal,
      (ARControl) this.txtAgencyAndDirect,
      (ARControl) this.txtBillingType3,
      (ARControl) this.txtBillingType4,
      (ARControl) this.txtBillingTypeAmt3,
      (ARControl) this.txtBillingTypeAmt4,
      (ARControl) this.txtBillingType5,
      (ARControl) this.txtBillingTypeAmt5
    });
    this.ReportFooter.Height = 2.052083f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.ReportFooter.NewPage = (NewPage) 1;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 0.0f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 0.375f;
    ((ARControl) this.Line1).Width = 10.4f;
    this.Line1.X1 = 0.0f;
    this.Line1.X2 = 10.4f;
    this.Line1.Y1 = 0.375f;
    this.Line1.Y2 = 0.375f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 5.191f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 9.75pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label2.Text = "Grand Total:";
    ((ARControl) this.Label2).Top = 0.094f;
    ((ARControl) this.Label2).Width = 1.125f;
    ((ARControl) this.amount2).DataField = "amount";
    ((ARControl) this.amount2).Height = 3f / 16f;
    ((ARControl) this.amount2).Left = 6.42f;
    ((ARControl) this.amount2).Name = "amount2";
    this.amount2.OutputFormat = resourceManager.GetString("amount2.OutputFormat");
    this.amount2.Style = "font-size: 10pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.amount2.SummaryRunning = (SummaryRunning) 2;
    this.amount2.SummaryType = (SummaryType) 1;
    this.amount2.Text = " ";
    ((ARControl) this.amount2).Top = 0.094f;
    ((ARControl) this.amount2).Width = 1.187001f;
    ((ARControl) this.txtBillingType1).DataField = "BillingType";
    ((ARControl) this.txtBillingType1).Height = 3f / 16f;
    ((ARControl) this.txtBillingType1).Left = 4.004f;
    ((ARControl) this.txtBillingType1).Name = "txtBillingType1";
    this.txtBillingType1.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtBillingType1.Text = (string) null;
    ((ARControl) this.txtBillingType1).Top = 0.437f;
    ((ARControl) this.txtBillingType1).Width = 2.312f;
    ((ARControl) this.txtBillingType2).DataField = "BillingType";
    ((ARControl) this.txtBillingType2).Height = 3f / 16f;
    ((ARControl) this.txtBillingType2).Left = 4.004f;
    ((ARControl) this.txtBillingType2).Name = "txtBillingType2";
    this.txtBillingType2.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtBillingType2.Text = (string) null;
    ((ARControl) this.txtBillingType2).Top = 0.698f;
    ((ARControl) this.txtBillingType2).Width = 2.312f;
    ((ARControl) this.txtBillingTypeAmt1).DataField = "BillingType";
    ((ARControl) this.txtBillingTypeAmt1).Height = 3f / 16f;
    ((ARControl) this.txtBillingTypeAmt1).Left = 6.42f;
    ((ARControl) this.txtBillingTypeAmt1).Name = "txtBillingTypeAmt1";
    this.txtBillingTypeAmt1.OutputFormat = resourceManager.GetString("txtBillingTypeAmt1.OutputFormat");
    this.txtBillingTypeAmt1.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtBillingTypeAmt1.Text = (string) null;
    ((ARControl) this.txtBillingTypeAmt1).Top = 0.437f;
    ((ARControl) this.txtBillingTypeAmt1).Width = 1.187001f;
    ((ARControl) this.txtBillingTypeAmt2).DataField = "BillingType";
    ((ARControl) this.txtBillingTypeAmt2).Height = 3f / 16f;
    ((ARControl) this.txtBillingTypeAmt2).Left = 6.42f;
    ((ARControl) this.txtBillingTypeAmt2).Name = "txtBillingTypeAmt2";
    this.txtBillingTypeAmt2.OutputFormat = resourceManager.GetString("txtBillingTypeAmt2.OutputFormat");
    this.txtBillingTypeAmt2.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtBillingTypeAmt2.Text = (string) null;
    ((ARControl) this.txtBillingTypeAmt2).Top = 0.698f;
    ((ARControl) this.txtBillingTypeAmt2).Width = 1.187001f;
    ((ARControl) this.txtTotal).Height = 3f / 16f;
    ((ARControl) this.txtTotal).Left = 5.077f;
    ((ARControl) this.txtTotal).Name = "txtTotal";
    this.txtTotal.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtTotal.Text = "Total:";
    ((ARControl) this.txtTotal).Top = 1.735f;
    ((ARControl) this.txtTotal).Width = 1.239f;
    ((ARControl) this.txtAgencyAndDirect).DataField = "BillingType";
    ((ARControl) this.txtAgencyAndDirect).Height = 3f / 16f;
    ((ARControl) this.txtAgencyAndDirect).Left = 6.420001f;
    ((ARControl) this.txtAgencyAndDirect).Name = "txtAgencyAndDirect";
    this.txtAgencyAndDirect.OutputFormat = resourceManager.GetString("txtAgencyAndDirect.OutputFormat");
    this.txtAgencyAndDirect.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtAgencyAndDirect.Text = (string) null;
    ((ARControl) this.txtAgencyAndDirect).Top = 1.735f;
    ((ARControl) this.txtAgencyAndDirect).Width = 1.187001f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghEntity).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.lblInvoiceNumber,
      (ARControl) this.lblPolicyNumber,
      (ARControl) this.lblGrossBilled
    });
    this.ghEntity.DataField = "entityType";
    this.ghEntity.Height = 0.1770833f;
    this.ghEntity.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghEntity).Name = "ghEntity";
    ((ARControl) this.lblInvoiceNumber).Height = 3f / 16f;
    this.lblInvoiceNumber.HyperLink = (string) null;
    ((ARControl) this.lblInvoiceNumber).Left = 0.0f;
    ((ARControl) this.lblInvoiceNumber).Name = "lblInvoiceNumber";
    this.lblInvoiceNumber.Style = "font-size: 9.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.lblInvoiceNumber.Text = "Type";
    ((ARControl) this.lblInvoiceNumber).Top = 3f / 16f;
    ((ARControl) this.lblInvoiceNumber).Visible = false;
    ((ARControl) this.lblInvoiceNumber).Width = 0.906f;
    ((ARControl) this.lblPolicyNumber).Height = 3f / 16f;
    this.lblPolicyNumber.HyperLink = (string) null;
    ((ARControl) this.lblPolicyNumber).Left = 1.375f;
    ((ARControl) this.lblPolicyNumber).Name = "lblPolicyNumber";
    this.lblPolicyNumber.Style = "font-size: 10pt; font-weight: bold; text-align: left; vertical-align: bottom";
    this.lblPolicyNumber.Text = "Entity";
    ((ARControl) this.lblPolicyNumber).Top = 0.187f;
    ((ARControl) this.lblPolicyNumber).Visible = false;
    ((ARControl) this.lblPolicyNumber).Width = 1.072f;
    ((ARControl) this.lblGrossBilled).Height = 3f / 16f;
    this.lblGrossBilled.HyperLink = (string) null;
    ((ARControl) this.lblGrossBilled).Left = 6.639001f;
    ((ARControl) this.lblGrossBilled).Name = "lblGrossBilled";
    this.lblGrossBilled.Style = "font-size: 10pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.lblGrossBilled.Text = "Amount";
    ((ARControl) this.lblGrossBilled).Top = 0.187f;
    ((ARControl) this.lblGrossBilled).Visible = false;
    ((ARControl) this.lblGrossBilled).Width = 0.7810001f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfEntity).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label1,
      (ARControl) this.amount,
      (ARControl) this.EntityType
    });
    this.gfEntity.Height = 0.2085f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfEntity).Name = "gfEntity";
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 2.702f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.Label1.Text = "Sub Total:";
    ((ARControl) this.Label1).Top = 0.021f;
    ((ARControl) this.Label1).Width = 2.311999f;
    ((ARControl) this.amount).DataField = "amount";
    ((ARControl) this.amount).Height = 3f / 16f;
    ((ARControl) this.amount).Left = 6.42f;
    ((ARControl) this.amount).Name = "amount";
    this.amount.OutputFormat = resourceManager.GetString("amount.OutputFormat");
    this.amount.Style = "font-size: 9pt; font-weight: bold; text-align: right; vertical-align: middle";
    this.amount.SummaryGroup = "ghEntity";
    this.amount.SummaryRunning = (SummaryRunning) 1;
    this.amount.SummaryType = (SummaryType) 3;
    ((ARControl) this.amount).Top = 0.021f;
    ((ARControl) this.amount).Width = 1.187001f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5
    });
    this.PageHeader1.Height = 0.2608334f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1).Name = "PageHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1).Name = "PageFooter1";
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 0.0f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 9.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label3.Text = "Type";
    ((ARControl) this.Label3).Top = 0.062f;
    ((ARControl) this.Label3).Width = 0.906f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 1.375f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 10pt; font-weight: bold; text-align: left; vertical-align: bottom";
    this.Label4.Text = "Entity";
    ((ARControl) this.Label4).Top = 0.062f;
    ((ARControl) this.Label4).Width = 1.072f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 6.639f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 10pt; font-weight: bold; text-align: right; vertical-align: bottom";
    this.Label5.Text = "Amount";
    ((ARControl) this.Label5).Top = 0.063f;
    ((ARControl) this.Label5).Width = 0.781f;
    ((ARControl) this.txtBillingType3).DataField = "BillingType";
    ((ARControl) this.txtBillingType3).Height = 3f / 16f;
    ((ARControl) this.txtBillingType3).Left = 4.004f;
    ((ARControl) this.txtBillingType3).Name = "txtBillingType3";
    this.txtBillingType3.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtBillingType3.Text = (string) null;
    ((ARControl) this.txtBillingType3).Top = 0.9630001f;
    ((ARControl) this.txtBillingType3).Visible = false;
    ((ARControl) this.txtBillingType3).Width = 2.312f;
    ((ARControl) this.txtBillingType4).DataField = "BillingType";
    ((ARControl) this.txtBillingType4).Height = 3f / 16f;
    ((ARControl) this.txtBillingType4).Left = 4.004f;
    ((ARControl) this.txtBillingType4).Name = "txtBillingType4";
    this.txtBillingType4.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtBillingType4.Text = (string) null;
    ((ARControl) this.txtBillingType4).Top = 1.213f;
    ((ARControl) this.txtBillingType4).Visible = false;
    ((ARControl) this.txtBillingType4).Width = 2.312f;
    ((ARControl) this.txtBillingTypeAmt3).DataField = "BillingType";
    ((ARControl) this.txtBillingTypeAmt3).Height = 3f / 16f;
    ((ARControl) this.txtBillingTypeAmt3).Left = 6.42f;
    ((ARControl) this.txtBillingTypeAmt3).Name = "txtBillingTypeAmt3";
    this.txtBillingTypeAmt3.OutputFormat = resourceManager.GetString("txtBillingTypeAmt3.OutputFormat");
    this.txtBillingTypeAmt3.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtBillingTypeAmt3.Text = (string) null;
    ((ARControl) this.txtBillingTypeAmt3).Top = 0.9630001f;
    ((ARControl) this.txtBillingTypeAmt3).Visible = false;
    ((ARControl) this.txtBillingTypeAmt3).Width = 1.187001f;
    ((ARControl) this.txtBillingTypeAmt4).DataField = "BillingType";
    ((ARControl) this.txtBillingTypeAmt4).Height = 3f / 16f;
    ((ARControl) this.txtBillingTypeAmt4).Left = 6.42f;
    ((ARControl) this.txtBillingTypeAmt4).Name = "txtBillingTypeAmt4";
    this.txtBillingTypeAmt4.OutputFormat = resourceManager.GetString("txtBillingTypeAmt4.OutputFormat");
    this.txtBillingTypeAmt4.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtBillingTypeAmt4.Text = (string) null;
    ((ARControl) this.txtBillingTypeAmt4).Top = 1.213f;
    ((ARControl) this.txtBillingTypeAmt4).Visible = false;
    ((ARControl) this.txtBillingTypeAmt4).Width = 1.187001f;
    ((ARControl) this.txtBillingType5).DataField = "BillingType";
    ((ARControl) this.txtBillingType5).Height = 3f / 16f;
    ((ARControl) this.txtBillingType5).Left = 4.004f;
    ((ARControl) this.txtBillingType5).Name = "txtBillingType5";
    this.txtBillingType5.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtBillingType5.Text = (string) null;
    ((ARControl) this.txtBillingType5).Top = 1.487f;
    ((ARControl) this.txtBillingType5).Visible = false;
    ((ARControl) this.txtBillingType5).Width = 2.312f;
    ((ARControl) this.txtBillingTypeAmt5).DataField = "BillingType";
    ((ARControl) this.txtBillingTypeAmt5).Height = 3f / 16f;
    ((ARControl) this.txtBillingTypeAmt5).Left = 6.42f;
    ((ARControl) this.txtBillingTypeAmt5).Name = "txtBillingTypeAmt5";
    this.txtBillingTypeAmt5.OutputFormat = resourceManager.GetString("txtBillingTypeAmt5.OutputFormat");
    this.txtBillingTypeAmt5.Style = "font-size: 10pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.txtBillingTypeAmt5.Text = (string) null;
    ((ARControl) this.txtBillingTypeAmt5).Top = 1.487f;
    ((ARControl) this.txtBillingTypeAmt5).Visible = false;
    ((ARControl) this.txtBillingTypeAmt5).Width = 1.187001f;
    ((ARControl) this.EntityType).DataField = "EntityType";
    ((ARControl) this.EntityType).Height = 3f / 16f;
    ((ARControl) this.EntityType).Left = 5.014f;
    ((ARControl) this.EntityType).Name = "EntityType";
    this.EntityType.OutputFormat = resourceManager.GetString("EntityType.OutputFormat");
    this.EntityType.Style = "font-size: 9pt; font-weight: bold; text-align: center; vertical-align: middle";
    this.EntityType.SummaryGroup = "ghEntity";
    this.EntityType.SummaryRunning = (SummaryRunning) 1;
    ((ARControl) this.EntityType).Top = 0.021f;
    ((ARControl) this.EntityType).Width = 1.406001f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.4f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 1;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.764576f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghEntity);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfEntity);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.txtEntityType).EndInit();
    ((ISupportInitialize) this.txtEntityName).EndInit();
    ((ISupportInitialize) this.txtAmount).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.lblSubTitle).EndInit();
    ((ISupportInitialize) this.lblBillingType).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.amount2).EndInit();
    ((ISupportInitialize) this.txtBillingType1).EndInit();
    ((ISupportInitialize) this.txtBillingType2).EndInit();
    ((ISupportInitialize) this.txtBillingTypeAmt1).EndInit();
    ((ISupportInitialize) this.txtBillingTypeAmt2).EndInit();
    ((ISupportInitialize) this.txtTotal).EndInit();
    ((ISupportInitialize) this.txtAgencyAndDirect).EndInit();
    ((ISupportInitialize) this.lblInvoiceNumber).EndInit();
    ((ISupportInitialize) this.lblPolicyNumber).EndInit();
    ((ISupportInitialize) this.lblGrossBilled).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.amount).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.txtBillingType3).EndInit();
    ((ISupportInitialize) this.txtBillingType4).EndInit();
    ((ISupportInitialize) this.txtBillingTypeAmt3).EndInit();
    ((ISupportInitialize) this.txtBillingTypeAmt4).EndInit();
    ((ISupportInitialize) this.txtBillingType5).EndInit();
    ((ISupportInitialize) this.txtBillingTypeAmt5).EndInit();
    ((ISupportInitialize) this.EntityType).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  private void rptArApBalanceSheetBreakout_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    SqlConnection connection = new SqlConnection(Database.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spFin_rptBalanceSheetARAPEntityBreakout", connection);
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    this._ds = new DataSet();
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Parameters.AddWithValue("@asof", (object) this._AsOf);
    selectCommand.Parameters.AddWithValue("@accounttype", (object) this._rpt_Type);
    selectCommand.CommandTimeout = 0;
    try
    {
      connection.Open();
      sqlDataAdapter.Fill(this._ds);
    }
    finally
    {
      connection.Close();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
      connection.Dispose();
    }
    if (this._ds.Tables.Count != 1 || this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.lblSubTitle.Text = string.Format(this.lblSubTitle.Text, (object) this._AsOf.ToShortDateString());
    this.lblTitle.Text = "Accounts " + Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._rpt_Type, "R", false) == 0, (object) "Receivable", (object) "Payable").ToString();
    this.exportDetail = this._ds.Tables[0];
    this.DataSource = (object) this._ds.Tables[0];
    this.ShowPageNumbers();
  }

  private void Detail_BeforePrint(object sender, EventArgs e) => this.SetDetailControlsHeight();

  private void ReportFooter_Format(object sender, EventArgs e)
  {
    SqlConnection connection = new SqlConnection(Database.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spFin_rptBalanceSheetARAPBillingTypeBreakout", connection);
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    this._ds = new DataSet();
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.Parameters.AddWithValue("@asof", (object) this._AsOf);
    selectCommand.Parameters.AddWithValue("@accounttype", (object) this._rpt_Type);
    selectCommand.CommandTimeout = 0;
    try
    {
      connection.Open();
      sqlDataAdapter.Fill(this._ds);
    }
    finally
    {
      connection.Close();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
      connection.Dispose();
    }
    if (this._ds.Tables.Count != 1 || this._ds.Tables[0].Rows.Count <= 0)
      return;
    this.DataSource = (object) this._ds.Tables[0];
    if (this._ds.Tables[0].Rows.Count >= 1)
    {
      this.txtBillingType1.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this._ds.Tables[0].Rows[0][0], (object) ":");
      this.txtBillingTypeAmt1.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[0][1]);
    }
    if (this._ds.Tables[0].Rows.Count >= 2)
    {
      this.txtBillingType2.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this._ds.Tables[0].Rows[1][0], (object) ":");
      this.txtBillingTypeAmt2.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[1][1]);
      this.txtAgencyAndDirect.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this._ds.Tables[0].Rows[0][1], this._ds.Tables[0].Rows[1][1]);
    }
    if (this._ds.Tables[0].Rows.Count >= 3)
    {
      ((ARControl) this.txtBillingType3).Visible = true;
      ((ARControl) this.txtBillingTypeAmt3).Visible = true;
      this.txtBillingType3.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this._ds.Tables[0].Rows[2][0], (object) ":");
      this.txtBillingTypeAmt3.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[2][1]);
      this.txtAgencyAndDirect.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this._ds.Tables[0].Rows[0][1], this._ds.Tables[0].Rows[1][1]), this._ds.Tables[0].Rows[2][1]);
    }
    if (this._ds.Tables[0].Rows.Count >= 4)
    {
      ((ARControl) this.txtBillingType4).Visible = true;
      ((ARControl) this.txtBillingTypeAmt4).Visible = true;
      this.txtBillingType4.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this._ds.Tables[0].Rows[3][0], (object) ":");
      this.txtBillingTypeAmt4.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[3][1]);
      this.txtAgencyAndDirect.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this._ds.Tables[0].Rows[0][1], this._ds.Tables[0].Rows[1][1]), this._ds.Tables[0].Rows[2][1]), this._ds.Tables[0].Rows[3][1]);
    }
    if (this._ds.Tables[0].Rows.Count >= 5)
    {
      ((ARControl) this.txtBillingType5).Visible = true;
      ((ARControl) this.txtBillingTypeAmt5).Visible = true;
      this.txtBillingType5.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this._ds.Tables[0].Rows[4][0], (object) ":");
      this.txtBillingTypeAmt5.Value = RuntimeHelpers.GetObjectValue(this._ds.Tables[0].Rows[4][1]);
      this.txtAgencyAndDirect.Value = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this._ds.Tables[0].Rows[0][1], this._ds.Tables[0].Rows[1][1]), this._ds.Tables[0].Rows[2][1]), this._ds.Tables[0].Rows[3][1]), this._ds.Tables[0].Rows[4][1]);
    }
    this.ShowPageNumbers();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      string[] strArray = new string[8]
      {
        "All",
        "*",
        "Agency Bill",
        "B",
        "Direct Bill (MGA)",
        "I",
        "Direct Bill (Company)",
        "C"
      };
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DatePicker("As Of", DateAndTime.Now.Date, false),
        (BaseReportControl) new GenericComboBox("Type", 125, 125, typeof (string), new object[4]
        {
          (object) "Receivable",
          (object) "R",
          (object) "Payable",
          (object) "P"
        })
      };
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    DataTable dataTable = new DataTable();
    this._ds.Tables[0].Copy();
    ExcelExport.ToExcel(this.exportDetail, SaveFileTo);
  }

  [field: AccessedThroughProperty("Line1")]
  internal virtual Line Line1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblBillingType")]
  private virtual Label lblBillingType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghEntity")]
  private virtual GroupHeader ghEntity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual GroupFooter gfEntity
  {
    get => this._gfEntity;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfEntity_Format);
      GroupFooter gfEntity1 = this._gfEntity;
      if (gfEntity1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfEntity1).Format -= eventHandler;
      this._gfEntity = value;
      GroupFooter gfEntity2 = this._gfEntity;
      if (gfEntity2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfEntity2).Format += eventHandler;
    }
  }

  private virtual ReportFooter ReportFooter
  {
    get => this._ReportFooter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportFooter_Format);
      ReportFooter reportFooter1 = this._ReportFooter;
      if (reportFooter1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter1).Format -= eventHandler;
      this._ReportFooter = value;
      ReportFooter reportFooter2 = this._ReportFooter;
      if (reportFooter2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportFooter2).Format += eventHandler;
    }
  }

  private void Detail_Format(object sender, EventArgs e)
  {
  }

  private void gfEntity_Format(object sender, EventArgs e)
  {
  }
}
