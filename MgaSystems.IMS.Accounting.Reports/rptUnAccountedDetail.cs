// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptUnAccountedDetail
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Common.ErrorHandling;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{1A357869-4F99-44a2-A9B1-7C29771BD24B}", "UnAccounted Detail Report", "Displays detailed unaccounted information by company and date.", "Accounting")]
public sealed class rptUnAccountedDetail : MGAReport, IReport
{
  private int _GlCompanyID;
  private DateTime _AsOfDate;
  private DataTable _dt;
  private Guid _entityGuid;
  private bool _ShowZeroBalances;
  private Label lblTitle;
  private TextBox txtSubTitle;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private TextBox TextBox1;
  private Label Label6;
  private Label Label;
  private Label Label9;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox;
  private TextBox TextBox8;
  private TextBox exchangeAmount1;
  private Label Label7;
  private TextBox exchangeAmount2;
  private Label Label8;

  public rptUnAccountedDetail()
  {
    this.ReportStart += new EventHandler(this.rptUnAccountedDetail_ReportStart);
  }

  public rptUnAccountedDetail(
    int GlCompanyID,
    DateTime AsOfDate,
    Guid EntityGuid,
    bool ShowZeroBalances)
  {
    this.ReportStart += new EventHandler(this.rptUnAccountedDetail_ReportStart);
    this.InitializeComponent();
    this._GlCompanyID = GlCompanyID;
    this._AsOfDate = AsOfDate;
    this._entityGuid = EntityGuid;
    this._ShowZeroBalances = ShowZeroBalances;
  }

  private void rptUnAccountedDetail_ReportStart(object sender, EventArgs e)
  {
    this._dt = Database.Instance.QuerySP.PerformTableQuery("spFin_rptUnAccountedDetail", (object) "@GlCompanyID", (object) this._GlCompanyID, (object) "@AsOfDate", (object) this._AsOfDate, (object) "@EntityGuid", (object) this._entityGuid, (object) "@showZeroBlanaces", (object) this._ShowZeroBalances);
    if (this._dt.Rows.Count > 0)
      this.txtSubTitle.Text = $"{Database.Instance.QueryText.PerformScalarQueryString("SELECT TOP 1 Location FROM tblClientOffices WHERE OfficeID = " + Conversions.ToString(this._GlCompanyID))}\r\nPrior to {this._AsOfDate.Date.ToString("d")}";
    this.DataSource = (object) this._dt;
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    this.txtDtl_TransNum.HyperLink = this.txtDtl_TransNum.Value.ToString();
  }

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    try
    {
      Type typeFromString = ObjectFactory.Instance.CreateTypeFromString("MGASystems.IMS.Accounting.SharedForms.formTransactionViewer");
      (ObjectFactory.Instance.CreateObject(typeFromString, typeFromString, new object[2]
      {
        (object) Conversions.ToInteger(e.HyperLink),
        (object) 0
      }) as Form).Show();
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ErrorHandler.SilentHandleError(ex);
      ProjectData.ClearProjectError();
    }
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptUnAccountedDetail));
    this.Detail = new Detail();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.txtDtl_TransNum = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
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
    this.Label = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.GroupFooter1 = new GroupFooter();
    this.exchangeAmount1 = new TextBox();
    this.Label7 = new Label();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.txtDtl_TransNum).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
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
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.exchangeAmount1).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.txtDtl_TransNum,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1354167f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox2).DataField = "policyNumber";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 51f / 16f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 8pt";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 1f;
    ((ARControl) this.TextBox3).DataField = "effectiveDate";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 67f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "d";
    this.TextBox3.Style = "font-size: 8pt";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.625f;
    ((ARControl) this.TextBox4).DataField = "dueDate";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 77f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "d";
    this.TextBox4.Style = "font-size: 8pt";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 11f / 16f;
    ((ARControl) this.TextBox5).DataField = "officeInvoiceNum";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 5.5f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 8pt";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.625f;
    ((ARControl) this.TextBox6).DataField = "insuredName";
    ((ARControl) this.TextBox6).Height = 0.125f;
    ((ARControl) this.TextBox6).Left = 6.125f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 8pt";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 1.125f;
    ((ARControl) this.TextBox7).DataField = "unaccountedAmount";
    ((ARControl) this.TextBox7).Height = 0.125f;
    ((ARControl) this.TextBox7).Left = 9.5f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "font-size: 8pt; text-align: right";
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 0.875f;
    ((ARControl) this.TextBox).DataField = "trxDate";
    ((ARControl) this.TextBox).Height = 0.125f;
    ((ARControl) this.TextBox).Left = 0.0f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = "d";
    this.TextBox.Style = "font-size: 8pt; ddo-char-set: 0";
    this.TextBox.Text = (string) null;
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 11f / 16f;
    ((ARControl) this.TextBox8).DataField = "RemitterName";
    ((ARControl) this.TextBox8).Height = 0.125f;
    ((ARControl) this.TextBox8).Left = 7.25f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.Style = "font-size: 8pt";
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 1.125f;
    ((ARControl) this.TextBox9).DataField = "EntityName";
    ((ARControl) this.TextBox9).Height = 0.125f;
    ((ARControl) this.TextBox9).Left = 8.375f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.Style = "font-size: 8pt";
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 1.125f;
    ((ARControl) this.txtDtl_TransNum).DataField = "transactionNum";
    ((ARControl) this.txtDtl_TransNum).Height = 0.125f;
    ((ARControl) this.txtDtl_TransNum).Left = 11f / 16f;
    ((ARControl) this.txtDtl_TransNum).Name = "txtDtl_TransNum";
    this.txtDtl_TransNum.Style = "font-size: 8pt";
    this.txtDtl_TransNum.Text = " ";
    ((ARControl) this.txtDtl_TransNum).Top = 0.0f;
    ((ARControl) this.txtDtl_TransNum).Width = 0.625f;
    ((ARControl) this.TextBox11).DataField = "CheckNum";
    ((ARControl) this.TextBox11).Height = 0.125f;
    ((ARControl) this.TextBox11).Left = 21f / 16f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.Style = "font-size: 8pt";
    this.TextBox11.Text = " ";
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.625f;
    ((ARControl) this.TextBox12).DataField = "PostingComments";
    ((ARControl) this.TextBox12).Height = 0.125f;
    ((ARControl) this.TextBox12).Left = 31f / 16f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.Style = "font-size: 8pt";
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 1.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblTitle,
      (ARControl) this.txtSubTitle
    });
    this.ReportHeader.Height = 0.6666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.lblTitle).Height = 0.25f;
    this.lblTitle.HyperLink = (string) null;
    ((ARControl) this.lblTitle).Left = 0.0f;
    ((ARControl) this.lblTitle).Name = "lblTitle";
    this.lblTitle.Style = "font-size: 12pt; font-weight: bold; vertical-align: bottom";
    this.lblTitle.Text = "UnAccounted Detail Report";
    ((ARControl) this.lblTitle).Top = 0.0f;
    ((ARControl) this.lblTitle).Width = 7.875f;
    ((ARControl) this.txtSubTitle).Height = 5f / 16f;
    ((ARControl) this.txtSubTitle).Left = 0.0f;
    ((ARControl) this.txtSubTitle).Name = "txtSubTitle";
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
    ((ARControl) this.exchangeAmount2).DataField = "unaccountedAmount";
    ((ARControl) this.exchangeAmount2).Height = 3f / 16f;
    ((ARControl) this.exchangeAmount2).Left = 7.875f;
    ((ARControl) this.exchangeAmount2).Name = "exchangeAmount2";
    this.exchangeAmount2.OutputFormat = resourceManager.GetString("exchangeAmount2.OutputFormat");
    this.exchangeAmount2.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    this.exchangeAmount2.SummaryRunning = (SummaryRunning) 2;
    this.exchangeAmount2.SummaryType = (SummaryType) 1;
    this.exchangeAmount2.Text = " ";
    ((ARControl) this.exchangeAmount2).Top = 0.0f;
    ((ARControl) this.exchangeAmount2).Width = 2.5f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 111f / 16f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    this.Label8.Text = "Grand Total:";
    ((ARControl) this.Label8).Top = 0.0f;
    ((ARControl) this.Label8).Width = 15f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[13]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.TextBox1,
      (ARControl) this.Label6,
      (ARControl) this.Label,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13
    });
    this.GroupHeader1.DataField = "glaccountname";
    this.GroupHeader1.Height = 0.4479167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 5.5f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 8pt; font-weight: bold";
    this.Label1.Text = "Invoice #";
    ((ARControl) this.Label1).Top = 0.25f;
    ((ARControl) this.Label1).Width = 0.625f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 51f / 16f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 8pt; font-weight: bold";
    this.Label2.Text = "Policy #";
    ((ARControl) this.Label2).Top = 0.25f;
    ((ARControl) this.Label2).Width = 1f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 6.125f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 8pt; font-weight: bold";
    this.Label3.Text = "Insured";
    ((ARControl) this.Label3).Top = 0.25f;
    ((ARControl) this.Label3).Width = 1.125f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 67f / 16f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 8pt; font-weight: bold";
    this.Label4.Text = "Effective";
    ((ARControl) this.Label4).Top = 0.25f;
    ((ARControl) this.Label4).Width = 0.625f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 77f / 16f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 8pt; font-weight: bold";
    this.Label5.Text = "Due";
    ((ARControl) this.Label5).Top = 0.25f;
    ((ARControl) this.Label5).Width = 11f / 16f;
    ((ARControl) this.TextBox1).DataField = "glaccountname";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-weight: bold";
    this.TextBox1.Text = "[GLAccountName]";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 7.875f;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 9.5f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    this.Label6.Text = "UnAcct Amt";
    ((ARControl) this.Label6).Top = 0.25f;
    ((ARControl) this.Label6).Width = 0.875f;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 8pt; font-weight: bold; ddo-char-set: 0";
    this.Label.Text = "Date";
    ((ARControl) this.Label).Top = 0.25f;
    ((ARControl) this.Label).Width = 11f / 16f;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 7.25f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 8pt; font-weight: bold";
    this.Label9.Text = "Remitter";
    ((ARControl) this.Label9).Top = 0.25f;
    ((ARControl) this.Label9).Width = 1.125f;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 8.375f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 8pt; font-weight: bold";
    this.Label10.Text = "Entity";
    ((ARControl) this.Label10).Top = 0.25f;
    ((ARControl) this.Label10).Width = 1.125f;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 11f / 16f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 8pt; font-weight: bold";
    this.Label11.Text = "Trans #";
    ((ARControl) this.Label11).Top = 0.25f;
    ((ARControl) this.Label11).Width = 0.625f;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 21f / 16f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 8pt; font-weight: bold";
    this.Label12.Text = "Check #";
    ((ARControl) this.Label12).Top = 0.25f;
    ((ARControl) this.Label12).Width = 0.625f;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 31f / 16f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 8pt; font-weight: bold";
    this.Label13.Text = "Comments";
    ((ARControl) this.Label13).Top = 0.25f;
    ((ARControl) this.Label13).Width = 1.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.exchangeAmount1,
      (ARControl) this.Label7
    });
    this.GroupFooter1.Height = 0.2868056f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.exchangeAmount1).DataField = "unaccountedAmount";
    ((ARControl) this.exchangeAmount1).Height = 3f / 16f;
    ((ARControl) this.exchangeAmount1).Left = 7.875f;
    ((ARControl) this.exchangeAmount1).Name = "exchangeAmount1";
    this.exchangeAmount1.OutputFormat = resourceManager.GetString("exchangeAmount1.OutputFormat");
    this.exchangeAmount1.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    this.exchangeAmount1.SummaryGroup = "GroupHeader1";
    this.exchangeAmount1.SummaryRunning = (SummaryRunning) 1;
    this.exchangeAmount1.SummaryType = (SummaryType) 3;
    this.exchangeAmount1.Text = " ";
    ((ARControl) this.exchangeAmount1).Top = 0.0f;
    ((ARControl) this.exchangeAmount1).Width = 2.5f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 111f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 8pt; font-weight: bold; text-align: right";
    this.Label7.Text = "Sub Total:";
    ((ARControl) this.Label7).Top = 0.0f;
    ((ARControl) this.Label7).Width = 15f / 16f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.MirrorMargins = true;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.txtDtl_TransNum).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
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
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.exchangeAmount1).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[4]
      {
        (BaseReportControl) new AccountingOfficeLocations("Company", false, true),
        (BaseReportControl) new DatePicker("As Of", DateAndTime.Now.Date, false),
        (BaseReportControl) new EntitySelection("Entity", false),
        (BaseReportControl) new GenericCheckBox("", "Show Zero Balances")
      };
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._dt, SaveFileTo);
    Process.Start(SaveFileTo);
  }

  [field: AccessedThroughProperty("TextBox9")]
  private virtual TextBox TextBox9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label10")]
  private virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label11")]
  private virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label12")]
  private virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtDtl_TransNum")]
  private virtual TextBox txtDtl_TransNum { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox11")]
  private virtual TextBox TextBox11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextBox12")]
  private virtual TextBox TextBox12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
