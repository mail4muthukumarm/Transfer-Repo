// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptExchangeDetail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{D52965A4-CAA8-4e71-866D-83BFD80C5397}", "Exchange Detail Report", "Displays detailed exchange information by company and date.", "Accounting")]
public sealed class rptExchangeDetail : MGAReport, IReport
{
  private string _clientOfficeName;
  private string _priorToDate;
  private string _reportSubTitle;
  private int _glCompanyId;
  private DateTime _asOfDate;
  private string _costCenterIds;
  private Guid _entityGuid;
  private string _SortOrder;
  private DataView _dv;
  private DataTable _dt;
  private const int _reportFontSize = 10;
  private const int _reportHeaderFontSize = 13;
  private Workbook _wkb;
  private Worksheet _wks;
  private int _rowIndex;
  private Label lblTitle;
  private TextBox txtSubTitle;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private TextBox TextBox1;
  private Label Label6;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox exchangeAmount1;
  private Label Label7;
  private TextBox exchangeAmount2;
  private Label Label8;

  public rptExchangeDetail()
  {
    this.ReportStart += new EventHandler(this.rptExchangeReport_ReportStart);
    this._wkb = new Workbook();
    this._rowIndex = 0;
  }

  public rptExchangeDetail(
    int glCompanyID,
    string costCenterIds,
    DateTime asOfDate,
    Guid EntityGuid,
    string SortOrder)
  {
    this.ReportStart += new EventHandler(this.rptExchangeReport_ReportStart);
    this._wkb = new Workbook();
    this._rowIndex = 0;
    this.InitializeComponent();
    this._glCompanyId = glCompanyID;
    this._asOfDate = asOfDate;
    this._costCenterIds = costCenterIds;
    this._entityGuid = EntityGuid;
    this._SortOrder = SortOrder;
  }

  private void rptExchangeReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    DataTable table = DefaultDatabase.ExecuteDataTable(CommandType.StoredProcedure, "spFin_rptExchangeDetail", 99999, (CommandArgumentType) 0, new object[8]
    {
      (object) "@GlCompanyID",
      (object) this._glCompanyId,
      (object) "@AsOfDate",
      (object) this._asOfDate,
      (object) "@CostCenterIds",
      (object) this._costCenterIds,
      (object) "@EntityGuid",
      (object) this._entityGuid
    });
    if (table.Rows.Count > 0)
    {
      this._clientOfficeName = Database.Instance.QueryText.PerformScalarQueryString("SELECT TOP 1 Location FROM tblClientOffices WHERE OfficeID = " + Conversions.ToString(this._glCompanyId));
      this._priorToDate = this._asOfDate.Date.ToString("MM/dd/yyyy");
      this.txtSubTitle.Text = $"{this._clientOfficeName}\r\nPrior to {this._priorToDate}";
    }
    this._reportSubTitle = this.txtSubTitle.Text;
    this._dv = new DataView(table, "", this._SortOrder, DataViewRowState.CurrentRows);
    this.DataSource = (object) this._dv;
    this._dt = this._dv.ToTable(false, "trxdate", "transactionNum", "CheckNum", "PostingComments", "policyNumber", "effectiveDate", "dueDate", "officeInvoiceNum", "insuredName", "EntityName", "exchangeAmount");
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptExchangeDetail));
    this.Detail = new Detail();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.lblTitle = new Label();
    this.txtSubTitle = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.exchangeAmount2 = new TextBox();
    this.Label8 = new Label();
    this.GroupHeader1 = new GroupHeader();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.TextBox1 = new TextBox();
    this.Label6 = new Label();
    this.Label9 = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.exchangeAmount1 = new TextBox();
    this.Label7 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.lblTitle).BeginInit();
    ((ISupportInitialize) this.txtSubTitle).BeginInit();
    ((ISupportInitialize) this.exchangeAmount2).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.exchangeAmount1).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[11]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1354167f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "policyNumber";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 3f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 8pt; ";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 17f / 16f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "effectiveDate";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 65f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 8pt; ";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.625f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "dueDate";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 75f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = resourceManager.GetString("TextBox4.OutputFormat");
    this.TextBox4.Style = "font-size: 8pt; ";
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
    ((ARControl) this.TextBox5).DataField = "officeInvoiceNum";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 85f / 16f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 8pt; ";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 11f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "insuredName";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 6f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 8pt; ";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 1.875f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "exchangeAmount";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 9.25f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "text-align: right; font-size: 8pt; ";
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 1.125f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "EntityName";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 7.875f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-size: 8pt; ";
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 1.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.txtSubTitle
    });
    this.ReportHeader.Height = 0.6666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
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
    this.lblTitle.Style = "font-weight: bold; font-size: 12pt; vertical-align: bottom; ";
    this.lblTitle.Text = "Exchange Detail Report";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 7.875f;
    ((ARControl) this.txtSubTitle).Border.BottomColor = Color.Black;
    ((ARControl) this.txtSubTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTitle).Border.LeftColor = Color.Black;
    ((ARControl) this.txtSubTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTitle).Border.RightColor = Color.Black;
    ((ARControl) this.txtSubTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTitle).Border.TopColor = Color.Black;
    ((ARControl) this.txtSubTitle).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTitle).Height = 5f / 16f;
    ((ARControl) this.txtSubTitle).Left = 0.0f;
    ((ARControl) this.txtSubTitle).Name = "txtSubTitle";
    this.txtSubTitle.Style = "";
    this.txtSubTitle.Text = (string) null;
    ((ARControl) this.txtSubTitle).Top = 0.25f;
    ((ARControl) this.txtSubTitle).Width = 7.875f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.exchangeAmount2,
      (ARControl) this.Label8
    });
    this.ReportFooter.Height = 0.1763889f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.exchangeAmount2).Border.BottomColor = Color.Black;
    ((ARControl) this.exchangeAmount2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.exchangeAmount2).Border.LeftColor = Color.Black;
    ((ARControl) this.exchangeAmount2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.exchangeAmount2).Border.RightColor = Color.Black;
    ((ARControl) this.exchangeAmount2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.exchangeAmount2).Border.TopColor = Color.Black;
    ((ARControl) this.exchangeAmount2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.exchangeAmount2).DataField = "exchangeAmount";
    ((ARControl) this.exchangeAmount2).Height = 3f / 16f;
    ((ARControl) this.exchangeAmount2).Left = 7.875f;
    ((ARControl) this.exchangeAmount2).Name = "exchangeAmount2";
    this.exchangeAmount2.OutputFormat = resourceManager.GetString("exchangeAmount2.OutputFormat");
    this.exchangeAmount2.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.exchangeAmount2.SummaryRunning = (SummaryRunning) 2;
    this.exchangeAmount2.SummaryType = (SummaryType) 1;
    this.exchangeAmount2.Text = " ";
    ((ARControl) this.exchangeAmount2).Top = 0.0f;
    ((ARControl) this.exchangeAmount2).Width = 2.5f;
    ((ARControl) this.Label8).Border.BottomColor = Color.Black;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftColor = Color.Black;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightColor = Color.Black;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopColor = Color.Black;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 111f / 16f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.Label8.Text = "Grand Total:";
    ((ARControl) this.Label8).Top = 0.0f;
    ((ARControl) this.Label8).Width = 15f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.TextBox1,
      (ARControl) this.Label6,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13
    });
    this.GroupHeader1.DataField = "glaccountname";
    this.GroupHeader1.Height = 0.4583333f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 85f / 16f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-weight: bold; font-size: 8pt; ";
    this.Label1.Text = "Invoice #";
    ((ARControl) this.Label1).Top = 0.25f;
    ((ARControl) this.Label1).Width = 11f / 16f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 3f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-weight: bold; font-size: 8pt; ";
    this.Label2.Text = "Policy #";
    ((ARControl) this.Label2).Top = 0.25f;
    ((ARControl) this.Label2).Width = 17f / 16f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 6f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-weight: bold; font-size: 8pt; ";
    this.Label3.Text = "Insured";
    ((ARControl) this.Label3).Top = 0.25f;
    ((ARControl) this.Label3).Width = 1.875f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 65f / 16f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-weight: bold; font-size: 8pt; ";
    this.Label4.Text = "Effective";
    ((ARControl) this.Label4).Top = 0.25f;
    ((ARControl) this.Label4).Width = 0.625f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 75f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-weight: bold; font-size: 8pt; ";
    this.Label5.Text = "Due";
    ((ARControl) this.Label5).Top = 0.25f;
    ((ARControl) this.Label5).Width = 0.625f;
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "glaccountname";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-weight: bold; ";
    this.TextBox1.Text = "[GLAccountName]";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 7.875f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 9.25f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.Label6.Text = "Exchange Amt.";
    ((ARControl) this.Label6).Top = 0.25f;
    ((ARControl) this.Label6).Width = 1.125f;
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 7.875f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-weight: bold; font-size: 8pt; ";
    this.Label9.Text = "Entity";
    ((ARControl) this.Label9).Top = 0.25f;
    ((ARControl) this.Label9).Width = 1.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.exchangeAmount1,
      (ARControl) this.Label7
    });
    this.GroupFooter1.Height = 0.2868056f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.exchangeAmount1).Border.BottomColor = Color.Black;
    ((ARControl) this.exchangeAmount1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.exchangeAmount1).Border.LeftColor = Color.Black;
    ((ARControl) this.exchangeAmount1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.exchangeAmount1).Border.RightColor = Color.Black;
    ((ARControl) this.exchangeAmount1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.exchangeAmount1).Border.TopColor = Color.Black;
    ((ARControl) this.exchangeAmount1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.exchangeAmount1).DataField = "exchangeAmount";
    ((ARControl) this.exchangeAmount1).Height = 3f / 16f;
    ((ARControl) this.exchangeAmount1).Left = 7.875f;
    ((ARControl) this.exchangeAmount1).Name = "exchangeAmount1";
    this.exchangeAmount1.OutputFormat = resourceManager.GetString("exchangeAmount1.OutputFormat");
    this.exchangeAmount1.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.exchangeAmount1.SummaryGroup = "GroupHeader1";
    this.exchangeAmount1.SummaryRunning = (SummaryRunning) 1;
    this.exchangeAmount1.SummaryType = (SummaryType) 3;
    this.exchangeAmount1.Text = " ";
    ((ARControl) this.exchangeAmount1).Top = 0.0f;
    ((ARControl) this.exchangeAmount1).Width = 2.5f;
    ((ARControl) this.Label7).Border.BottomColor = Color.Black;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftColor = Color.Black;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightColor = Color.Black;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopColor = Color.Black;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 111f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "text-align: right; font-weight: bold; font-size: 8pt; ";
    this.Label7.Text = "Sub Total:";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 15f / 16f;
    ((ARControl) this.Label10).Border.BottomColor = Color.Black;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftColor = Color.Black;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightColor = Color.Black;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopColor = Color.Black;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 0.0f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-weight: bold; font-size: 8pt; ";
    this.Label10.Text = "Trans Date";
    ((ARControl) this.Label10).Top = 0.25f;
    ((ARControl) this.Label10).Width = 0.625f;
    ((ARControl) this.Label11).Border.BottomColor = Color.Black;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftColor = Color.Black;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightColor = Color.Black;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopColor = Color.Black;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 0.625f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-weight: bold; font-size: 8pt; ";
    this.Label11.Text = "Trans #";
    ((ARControl) this.Label11).Top = 0.25f;
    ((ARControl) this.Label11).Width = 0.625f;
    ((ARControl) this.Label12).Border.BottomColor = Color.Black;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftColor = Color.Black;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightColor = Color.Black;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopColor = Color.Black;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 1.25f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-weight: bold; font-size: 8pt; ";
    this.Label12.Text = "Check #";
    ((ARControl) this.Label12).Top = 0.25f;
    ((ARControl) this.Label12).Width = 0.625f;
    ((ARControl) this.Label13).Border.BottomColor = Color.Black;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftColor = Color.Black;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightColor = Color.Black;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopColor = Color.Black;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 1.875f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-weight: bold; font-size: 8pt; ";
    this.Label13.Text = "Posting Comments";
    ((ARControl) this.Label13).Top = 0.25f;
    ((ARControl) this.Label13).Width = 1.125f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "trxdate";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 0.0f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-size: 8pt; ";
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 0.625f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox10).DataField = "transactionNum";
    ((ARControl) this.TextBox10).Height = 0.125f;
    ((ARControl) this.TextBox10).Left = 0.625f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.Style = "font-size: 8pt; ";
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 0.625f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "CheckNum";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 1.25f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.Style = "font-size: 8pt; ";
    this.TextBox11.Text = " ";
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.625f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "PostingComments";
    ((ARControl) this.TextBox12).Height = 0.125f;
    ((ARControl) this.TextBox12).Left = 1.875f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.Style = "font-size: 8pt; ";
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 1.125f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.lblTitle).EndInit();
    ((ISupportInitialize) this.txtSubTitle).EndInit();
    ((ISupportInitialize) this.exchangeAmount2).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.exchangeAmount1).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[4]
      {
        (BaseReportControl) new OfficeThenMultiCostCenter("Office Location", false),
        (BaseReportControl) new DatePicker("As Of", DateAndTime.Now.Date, false),
        (BaseReportControl) new EntitySelection("Entity", false),
        (BaseReportControl) new OrderBy(new string[16 /*0x10*/]
        {
          "Account",
          "glaccountname",
          "Invoice #",
          "officeInvoiceNum",
          "Policy #",
          "policyNumber",
          "Insured",
          "insuredName",
          "Due Date",
          "dueDate",
          "Effective Date",
          "effectiveDate",
          "Exchange Amount",
          "exchangeAmount",
          "Entity Name",
          "EntityName"
        })
      };
    }
  }

  public override bool IsThreaded => true;

  public override bool HasRecords => this._dt.Rows.Count > 0;

  public override void ExportToExcel(string SaveFileTo)
  {
    this._wks = this._wkb.Worksheets[0];
    this._wks.Name = "Exchange";
    this._wks.Cells.StandardWidth = 14.0;
    this.PrintColumnHeaders();
    this.PrintDetailLines();
    this.PrintReportHeader();
    this.AdjustColumnWidth();
    if (!SaveFileTo.Contains(".xlsx"))
      SaveFileTo = SaveFileTo.Replace(".xls", ".xlsx");
    this._wkb.Save(SaveFileTo, (SaveFormat) 6);
    Process.Start(SaveFileTo);
  }

  private void PrintColumnHeaders()
  {
    int num1 = 0;
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) this._dt.Columns)
      {
        Cell cell = this._wks.Cells[this._rowIndex, num1];
        cell.SetStyle(this.GetStyle(cell.GetStyle(), rptExchangeDetail.FontStyle.ColumnHeader));
        switch (num1)
        {
          case 0:
            cell.PutValue("Trans Date");
            break;
          case 1:
            cell.PutValue("Trans #");
            break;
          case 2:
            cell.PutValue("Check #");
            break;
          case 3:
            cell.PutValue("Posting Comments");
            break;
          case 4:
            cell.PutValue("Policy #");
            break;
          case 5:
            cell.PutValue("Effective");
            break;
          case 6:
            cell.PutValue("Due");
            break;
          case 7:
            cell.PutValue("Invoice #");
            break;
          case 8:
            cell.PutValue("Insured");
            break;
          case 9:
            cell.PutValue("Entity");
            break;
          case 10:
            cell.PutValue("Exchange Amt.");
            break;
        }
        checked { ++num1; }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num2 = checked (^(local = ref this._rowIndex) + 1);
    local = num2;
  }

  private void PrintDetailLines()
  {
    try
    {
      foreach (DataRow row in this._dt.Rows)
      {
        int num1 = checked (this._dt.Columns.Count - 1);
        int columnIndex = 0;
        while (columnIndex <= num1)
        {
          Cell cell = this._wks.Cells[this._rowIndex, columnIndex];
          switch (columnIndex)
          {
            case 0:
            case 5:
            case 6:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptExchangeDetail.FontStyle.DetailDateValue));
              break;
            case 10:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptExchangeDetail.FontStyle.DetailMoneyValue));
              break;
            default:
              cell.SetStyle(this.GetStyle(cell.GetStyle(), rptExchangeDetail.FontStyle.DetailPlain));
              break;
          }
          cell.PutValue(RuntimeHelpers.GetObjectValue(row[columnIndex]));
          checked { ++columnIndex; }
        }
        // ISSUE: variable of a reference type
        int& local;
        // ISSUE: explicit reference operation
        int num2 = checked (^(local = ref this._rowIndex) + 1);
        local = num2;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void PrintReportHeader()
  {
    this._wks.Cells.InsertRow(0);
    this._wks.Cells.InsertRow(0);
    Cell cell1 = this._wks.Cells[0, 0];
    cell1.SetStyle(this.GetStyle(cell1.GetStyle(), rptExchangeDetail.FontStyle.ReportHeader));
    cell1.PutValue("Prior to " + this._priorToDate);
    this._wks.Cells.InsertRow(0);
    Cell cell2 = this._wks.Cells[0, 0];
    cell2.SetStyle(this.GetStyle(cell2.GetStyle(), rptExchangeDetail.FontStyle.ReportHeader));
    cell2.PutValue(this._clientOfficeName);
    this._wks.Cells.InsertRow(0);
    Cell cell3 = this._wks.Cells[0, 0];
    cell3.SetStyle(this.GetStyle(cell3.GetStyle(), rptExchangeDetail.FontStyle.ReportHeader));
    cell3.PutValue("Exchange Detail Report");
  }

  private void AdjustColumnWidth()
  {
    this._wks.Cells.Columns[3].Width = 50.0;
    this._wks.Cells.Columns[8].Width = 50.0;
    this._wks.Cells.Columns[9].Width = 50.0;
  }

  private Style GetStyle(Style style, rptExchangeDetail.FontStyle myFontStyle)
  {
    switch (myFontStyle)
    {
      case rptExchangeDetail.FontStyle.ColumnHeader:
        style.Font.IsBold = true;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        break;
      case rptExchangeDetail.FontStyle.DetailPlain:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.IsTextWrapped = true;
        break;
      case rptExchangeDetail.FontStyle.DetailMoneyValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 7;
        break;
      case rptExchangeDetail.FontStyle.DetailPctValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 9;
        break;
      case rptExchangeDetail.FontStyle.DetailDateValue:
        style.Font.IsBold = false;
        style.Font.Size = 10;
        style.Font.Name = "Arial";
        style.Number = 14;
        break;
      case rptExchangeDetail.FontStyle.ReportHeader:
        style.Font.IsBold = true;
        style.Font.Size = 13;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        break;
      case rptExchangeDetail.FontStyle.ReportHeaderWrapped:
        style.Font.IsBold = true;
        style.Font.Size = 13;
        style.Font.Name = "Arial";
        style.HorizontalAlignment = (TextAlignmentType) 7;
        style.IsTextWrapped = true;
        break;
    }
    return style;
  }

  [field: AccessedThroughProperty("TextBox8")]
  private virtual TextBox TextBox8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label9")]
  private virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox10")]
  private virtual TextBox TextBox10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  private virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  private virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private enum FontStyle
  {
    ColumnHeader,
    DetailPlain,
    DetailMoneyValue,
    DetailPctValue,
    DetailDateValue,
    ReportHeader,
    ReportHeaderWrapped,
  }
}
