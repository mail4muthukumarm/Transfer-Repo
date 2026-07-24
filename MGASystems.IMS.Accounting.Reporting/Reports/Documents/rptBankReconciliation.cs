// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Reports.Documents.rptBankReconciliation
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting.Reports.Documents;

[SecureReportResource("{FFA7C287-703C-4F27-9A66-096F68BE4F6B}", "Bank Reconciliation Report", "Bank Reconciliation Report", "Accounting")]
public class rptBankReconciliation : MGAReport, IReport
{
  private DateTime _Date;
  private int _GLAcctID;
  private DataSet _ds;
  private DataSet _dstReconciledTrans;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private Label Label;
  private TextBox TextBox;
  private Label Label8;
  private Label Label6;
  private Label Label7;
  private Label Label5;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private Label Label12;
  private Label Label13;
  private Label Label14;
  private Label Label15;
  private Label Label16;
  private Label Label17;
  private Label Label18;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox10;
  private TextBox TextBox11;
  private TextBox TextBox15;
  private Label Label22;
  private Label Label23;
  private Label Label24;
  private TextBox TextBox16;
  private TextBox TextBox17;
  private TextBox TextBox18;
  private Label Label25;
  private TextBox TextBox19;
  private TextBox TextBox20;
  private Label Label26;
  private Label Label27;

  public rptBankReconciliation() => this.InitializeComponent();

  public rptBankReconciliation(DateTime AsOfDate, int GLAcctID, int BankAcctID)
  {
    this.InitializeComponent();
    this._Date = AsOfDate;
    this._GLAcctID = BankAcctID;
  }

  public rptBankReconciliation(
    DateTime AsOfDate,
    int GLAcctID,
    int BankAcctID,
    DataSet dstReconciledTrans)
  {
    this.InitializeComponent();
    this._Date = AsOfDate;
    this._GLAcctID = BankAcctID;
    this._dstReconciledTrans = dstReconciledTrans;
  }

  private void rptBankReconciliation_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    ArrayList arrayList = new ArrayList();
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@glacctid",
      (object) this._GLAcctID
    });
    arrayList.AddRange((ICollection) new object[2]
    {
      (object) "@date",
      (object) this._Date
    });
    this._ds = DefaultDatabase.ExecuteDataSet(CommandType.StoredProcedure, "Spfin_RptBankReconciliation", 0, (CommandArgumentType) 0, arrayList.ToArray());
    this.DataSource = (object) this._ds.Tables[0];
    this.TextBox.Text = string.Format(this.TextBox.Text, (object) this._Date.ToShortDateString());
  }

  private void rptBankReconciliation_ReportEnd(object sender, EventArgs e)
  {
    if (this._ds.Tables[1].Rows.Count > 0)
    {
      rptBankReconciliation_Checks reconciliationChecks = new rptBankReconciliation_Checks(this._ds.Tables[1]);
      reconciliationChecks.Run();
      this.Document.Pages.AddRange(reconciliationChecks.Document.Pages);
      reconciliationChecks.Dispose();
    }
    if (this._ds.Tables[2].Rows.Count > 0)
    {
      rptBankReconciliation_Misc reconciliationMisc = new rptBankReconciliation_Misc(this._ds.Tables[2]);
      reconciliationMisc.Run();
      this.Document.Pages.AddRange(reconciliationMisc.Document.Pages);
      reconciliationMisc.Dispose();
    }
    if (this._ds.Tables[3].Rows.Count > 0)
    {
      SectionReport sectionReport = (SectionReport) new rptBankReconciliation_Deposits(this._ds.Tables[3]);
      sectionReport.Run();
      this.Document.Pages.AddRange(sectionReport.Document.Pages);
      sectionReport.Dispose();
    }
    if ((this._dstReconciledTrans == null || this._dstReconciledTrans.Tables.Count <= 0 || this._dstReconciledTrans.Tables[0].Rows.Count <= 0) && this._ds.Tables.Count != 5)
      return;
    if (this._dstReconciledTrans != null)
    {
      SectionReport sectionReport = (SectionReport) new rptCurrentReconciliationReport(this._dstReconciledTrans.Tables[0].Select("Select = True"));
      sectionReport.Run();
      this.Document.Pages.AddRange(sectionReport.Document.Pages);
      sectionReport.Dispose();
    }
    else
    {
      if (this._ds.Tables.Count != 5 || this._ds.Tables[4].Rows.Count <= 0)
        return;
      SectionReport sectionReport = (SectionReport) new rptCurrentReconciliationReport(this._ds.Tables[4].Select("Select = True"));
      sectionReport.Run();
      this.Document.Pages.AddRange(sectionReport.Document.Pages);
      sectionReport.Dispose();
    }
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new DatePicker("As Of Date", DateTime.Now, false),
        (BaseReportControl) new OfficeLocationThenBank(false, true)
      };
    }
  }

  public override bool IsThreaded => true;

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._ds, SaveFileTo);
    Process.Start(SaveFileTo);
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptBankReconciliation));
    this.pageHeader = new PageHeader();
    this.Label = new Label();
    this.TextBox = new TextBox();
    this.Label8 = new Label();
    this.detail = new Detail();
    this.Label6 = new Label();
    this.Label7 = new Label();
    this.Label5 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.Label14 = new Label();
    this.Label15 = new Label();
    this.Label16 = new Label();
    this.Label17 = new Label();
    this.Label18 = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox11 = new TextBox();
    this.TextBox15 = new TextBox();
    this.Label22 = new Label();
    this.Label23 = new Label();
    this.Label24 = new Label();
    this.TextBox16 = new TextBox();
    this.TextBox17 = new TextBox();
    this.TextBox18 = new TextBox();
    this.Label25 = new Label();
    this.TextBox19 = new TextBox();
    this.TextBox20 = new TextBox();
    this.Label26 = new Label();
    this.Label27 = new Label();
    this.pageFooter = new PageFooter();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.Label15).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.Label17).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.Label22).BeginInit();
    ((ISupportInitialize) this.Label23).BeginInit();
    ((ISupportInitialize) this.Label24).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    ((ISupportInitialize) this.Label25).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.Label26).BeginInit();
    ((ISupportInitialize) this.Label27).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    ((Section) this.pageHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label,
      (ARControl) this.TextBox,
      (ARControl) this.Label8
    });
    this.pageHeader.Height = 0.9479167f;
    ((Section) this.pageHeader).Name = "pageHeader";
    ((ARControl) this.Label).Height = 0.25f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.026f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 12pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label.Text = "Bank Reconciliation";
    ((ARControl) this.Label).Top = 0.3959583f;
    ((ARControl) this.Label).Width = 7.875f;
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 0.026f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 10pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.TextBox.Text = "As of {0}";
    ((ARControl) this.TextBox).Top = 0.6454585f;
    ((ARControl) this.TextBox).Width = 7.875f;
    ((ARControl) this.Label8).DataField = "CompanyName";
    ((ARControl) this.Label8).Height = 0.25f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.0f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 14.25pt; font-weight: bold; text-align: center; vertical-align: middle; ddo-char-set: 0";
    this.Label8.Text = "";
    ((ARControl) this.Label8).Top = 0.1149583f;
    ((ARControl) this.Label8).Width = 7.875f;
    ((Section) this.detail).Controls.AddRange(new ARControl[37]
    {
      (ARControl) this.Label6,
      (ARControl) this.Label7,
      (ARControl) this.Label5,
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14,
      (ARControl) this.Label15,
      (ARControl) this.Label16,
      (ARControl) this.Label17,
      (ARControl) this.Label18,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox15,
      (ARControl) this.Label22,
      (ARControl) this.Label23,
      (ARControl) this.Label24,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox17,
      (ARControl) this.TextBox18,
      (ARControl) this.Label25,
      (ARControl) this.TextBox19,
      (ARControl) this.TextBox20,
      (ARControl) this.Label26,
      (ARControl) this.Label27
    });
    ((Section) this.detail).Height = 5.98975f;
    ((Section) this.detail).Name = "detail";
    ((ARControl) this.Label6).Height = 0.2f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 1.313f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 14pt";
    this.Label6.Text = ".........................................................................................................................................................";
    ((ARControl) this.Label6).Top = 4.272f;
    ((ARControl) this.Label6).Width = 5.605001f;
    ((ARControl) this.Label7).Height = 0.2f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 1.313f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 14pt";
    this.Label7.Text = ".........................................................................................................................................................";
    ((ARControl) this.Label7).Top = 5.696f;
    ((ARControl) this.Label7).Width = 5.605001f;
    ((ARControl) this.Label5).Height = 0.2f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 1.313f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 14pt";
    this.Label5.Text = ".........................................................................................................................................................";
    ((ARControl) this.Label5).Top = 2.883f;
    ((ARControl) this.Label5).Width = 5.605f;
    ((ARControl) this.TextBox1).DataField = "Address";
    ((ARControl) this.TextBox1).Height = 11f / 16f;
    ((ARControl) this.TextBox1).Left = 1.812f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 10pt; vertical-align: top; ddo-char-set: 0";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.187f;
    ((ARControl) this.TextBox1).Width = 4.208001f;
    ((ARControl) this.TextBox2).DataField = "BankAcctNum";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 1.812f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox2.Text = (string) null;
    ((ARControl) this.TextBox2).Top = 0.875f;
    ((ARControl) this.TextBox2).Width = 55f / 16f;
    ((ARControl) this.TextBox3).DataField = "NextCheckNum";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 29f / 16f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 1.062f;
    ((ARControl) this.TextBox3).Width = 55f / 16f;
    ((ARControl) this.TextBox4).DataField = "LastCheckNum";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 29f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox4.Text = (string) null;
    ((ARControl) this.TextBox4).Top = 1.249f;
    ((ARControl) this.TextBox4).Width = 55f / 16f;
    ((ARControl) this.TextBox5).DataField = "StartingBalance";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 5.554f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = resourceManager.GetString("TextBox5.OutputFormat");
    this.TextBox5.Style = "font-size: 10pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox5.Text = (string) null;
    ((ARControl) this.TextBox5).Top = 2.896f;
    ((ARControl) this.TextBox5).Width = 2.3225f;
    ((ARControl) this.TextBox6).DataField = "ReportAsOf";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 29f / 16f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = resourceManager.GetString("TextBox6.OutputFormat");
    this.TextBox6.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox6.Text = (string) null;
    ((ARControl) this.TextBox6).Top = 1.436f;
    ((ARControl) this.TextBox6).Width = 55f / 16f;
    ((ARControl) this.TextBox7).DataField = "BankName";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 29f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.TextBox7.Text = (string) null;
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 6.063499f;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 0.0f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label12.Text = "Bank Name:";
    ((ARControl) this.Label12).Top = 0.0f;
    ((ARControl) this.Label12).Width = 1.125f;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 0.0f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label13.Text = "Bank Address:";
    ((ARControl) this.Label13).Top = 0.187f;
    ((ARControl) this.Label13).Width = 1.125f;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 0.0f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label14.Text = "Bank Account #:";
    ((ARControl) this.Label14).Top = 0.875f;
    ((ARControl) this.Label14).Width = 19f / 16f;
    ((ARControl) this.Label15).Height = 3f / 16f;
    this.Label15.HyperLink = (string) null;
    ((ARControl) this.Label15).Left = 0.0f;
    ((ARControl) this.Label15).Name = "Label15";
    this.Label15.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label15.Text = "Next Check:";
    ((ARControl) this.Label15).Top = 1.062f;
    ((ARControl) this.Label15).Width = 19f / 16f;
    ((ARControl) this.Label16).Height = 3f / 16f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 0.0f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label16.Text = "Last Check #:";
    ((ARControl) this.Label16).Top = 1.249f;
    ((ARControl) this.Label16).Width = 19f / 16f;
    ((ARControl) this.Label17).Height = 3f / 16f;
    this.Label17.HyperLink = (string) null;
    ((ARControl) this.Label17).Left = 1f / 1000f;
    ((ARControl) this.Label17).Name = "Label17";
    this.Label17.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label17.Text = "Report Ran as of:";
    ((ARControl) this.Label17).Top = 1.437f;
    ((ARControl) this.Label17).Width = 21f / 16f;
    ((ARControl) this.Label18).Height = 3f / 16f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 0.0009999278f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label18.Text = "Starting Balance:";
    ((ARControl) this.Label18).Top = 2.896f;
    ((ARControl) this.Label18).Width = 21f / 16f;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 1.813f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label1.Text = "Cleared Transactions:";
    ((ARControl) this.Label1).Top = 3.167f;
    ((ARControl) this.Label1).Width = 1.521f;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 2.418f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label2.Text = "Checks/Disbursements:";
    ((ARControl) this.Label2).Top = 3.355f;
    ((ARControl) this.Label2).Width = 1.521f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 2.418f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label3.Text = "Deposits:";
    ((ARControl) this.Label3).Top = 3.542f;
    ((ARControl) this.Label3).Width = 1.521f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 2.418f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label4.Text = "Miscellaneous:";
    ((ARControl) this.Label4).Top = 3.73f;
    ((ARControl) this.Label4).Width = 1.521f;
    ((ARControl) this.TextBox8).DataField = "ClearedChecks";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 3.939f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "font-size: 10pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox8.Text = (string) null;
    ((ARControl) this.TextBox8).Top = 3.355f;
    ((ARControl) this.TextBox8).Width = 1.615f;
    ((ARControl) this.TextBox9).DataField = "ClearedDeposits";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 3.939f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-size: 10pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 3.542f;
    ((ARControl) this.TextBox9).Width = 1.615f;
    ((ARControl) this.TextBox10).DataField = "ClearedMisc";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 3.939f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = resourceManager.GetString("TextBox10.OutputFormat");
    this.TextBox10.Style = "font-size: 10pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox10.Text = (string) null;
    ((ARControl) this.TextBox10).Top = 3.73f;
    ((ARControl) this.TextBox10).Width = 1.615f;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox11).DataField = "TotalCleared";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 3.939f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "font-size: 10pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 3.917f;
    ((ARControl) this.TextBox11).Width = 1.615f;
    ((ARControl) this.TextBox15).DataField = "OutstandingDeposits";
    ((ARControl) this.TextBox15).Height = 3f / 16f;
    ((ARControl) this.TextBox15).Left = 3.939f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = resourceManager.GetString("TextBox15.OutputFormat");
    this.TextBox15.Style = "font-size: 10pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox15.Text = (string) null;
    ((ARControl) this.TextBox15).Top = 4.991f;
    ((ARControl) this.TextBox15).Width = 1.615f;
    ((ARControl) this.Label22).Height = 3f / 16f;
    this.Label22.HyperLink = (string) null;
    ((ARControl) this.Label22).Left = 2.418f;
    ((ARControl) this.Label22).Name = "Label22";
    this.Label22.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label22.Text = "Deposits:";
    ((ARControl) this.Label22).Top = 4.991f;
    ((ARControl) this.Label22).Width = 1.521f;
    ((ARControl) this.Label23).Height = 3f / 16f;
    this.Label23.HyperLink = (string) null;
    ((ARControl) this.Label23).Left = 1.813f;
    ((ARControl) this.Label23).Name = "Label23";
    this.Label23.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label23.Text = "Outstanding Transactions:";
    ((ARControl) this.Label23).Top = 4.616f;
    ((ARControl) this.Label23).Width = 1.979f;
    ((ARControl) this.Label24).Height = 3f / 16f;
    this.Label24.HyperLink = (string) null;
    ((ARControl) this.Label24).Left = 2.418f;
    ((ARControl) this.Label24).Name = "Label24";
    this.Label24.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label24.Text = "Checks/Disbursements:";
    ((ARControl) this.Label24).Top = 4.804f;
    ((ARControl) this.Label24).Width = 1.521f;
    ((ARControl) this.TextBox16).DataField = "OutstandingChecks";
    ((ARControl) this.TextBox16).Height = 3f / 16f;
    ((ARControl) this.TextBox16).Left = 3.939f;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = resourceManager.GetString("TextBox16.OutputFormat");
    this.TextBox16.Style = "font-size: 10pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox16.Text = (string) null;
    ((ARControl) this.TextBox16).Top = 4.803f;
    ((ARControl) this.TextBox16).Width = 1.615f;
    ((ARControl) this.TextBox17).DataField = "OutstandingMisc";
    ((ARControl) this.TextBox17).Height = 3f / 16f;
    ((ARControl) this.TextBox17).Left = 3.939f;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = resourceManager.GetString("TextBox17.OutputFormat");
    this.TextBox17.Style = "font-size: 10pt; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox17.Text = (string) null;
    ((ARControl) this.TextBox17).Top = 5.178f;
    ((ARControl) this.TextBox17).Width = 1.615f;
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox18).DataField = "TotalOutstanding";
    ((ARControl) this.TextBox18).Height = 3f / 16f;
    ((ARControl) this.TextBox18).Left = 3.939f;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = resourceManager.GetString("TextBox18.OutputFormat");
    this.TextBox18.Style = "font-size: 10pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox18.Text = (string) null;
    ((ARControl) this.TextBox18).Top = 5.365001f;
    ((ARControl) this.TextBox18).Width = 1.615f;
    ((ARControl) this.Label25).Height = 3f / 16f;
    this.Label25.HyperLink = (string) null;
    ((ARControl) this.Label25).Left = 2.418f;
    ((ARControl) this.Label25).Name = "Label25";
    this.Label25.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label25.Text = "Miscellaneous:";
    ((ARControl) this.Label25).Top = 5.178f;
    ((ARControl) this.Label25).Width = 1.521f;
    ((ARControl) this.TextBox19).DataField = "EndingBalance";
    ((ARControl) this.TextBox19).Height = 3f / 16f;
    ((ARControl) this.TextBox19).Left = 4.438f;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.OutputFormat = resourceManager.GetString("TextBox19.OutputFormat");
    this.TextBox19.Style = "font-size: 10pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox19.Text = (string) null;
    ((ARControl) this.TextBox19).Top = 4.272f;
    ((ARControl) this.TextBox19).Width = 55f / 16f;
    ((ARControl) this.TextBox20).DataField = "RegisterBalance";
    ((ARControl) this.TextBox20).Height = 3f / 16f;
    ((ARControl) this.TextBox20).Left = 4.463f;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = resourceManager.GetString("TextBox20.OutputFormat");
    this.TextBox20.Style = "font-size: 10pt; font-weight: bold; text-align: right; vertical-align: middle; ddo-char-set: 0";
    this.TextBox20.Text = (string) null;
    ((ARControl) this.TextBox20).Top = 5.708001f;
    ((ARControl) this.TextBox20).Width = 55f / 16f;
    ((ARControl) this.Label26).Height = 3f / 16f;
    this.Label26.HyperLink = (string) null;
    ((ARControl) this.Label26).Left = 0.0009999278f;
    ((ARControl) this.Label26).Name = "Label26";
    this.Label26.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label26.Text = "Ending Balance:";
    ((ARControl) this.Label26).Top = 4.272f;
    ((ARControl) this.Label26).Width = 21f / 16f;
    ((ARControl) this.Label27).Height = 3f / 16f;
    this.Label27.HyperLink = (string) null;
    ((ARControl) this.Label27).Left = 0.0009999278f;
    ((ARControl) this.Label27).Name = "Label27";
    this.Label27.Style = "font-size: 10pt; vertical-align: middle; ddo-char-set: 0";
    this.Label27.Text = "Register Balance:";
    ((ARControl) this.Label27).Top = 5.708001f;
    ((ARControl) this.Label27).Width = 21f / 16f;
    this.pageFooter.Height = 0.0f;
    ((Section) this.pageFooter).Name = "pageFooter";
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.895834f;
    this.Sections.Add((Section) this.pageHeader);
    this.Sections.Add((Section) this.detail);
    this.Sections.Add((Section) this.pageFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.rptBankReconciliation_ReportStart);
    this.ReportEnd += new EventHandler(this.rptBankReconciliation_ReportEnd);
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.Label15).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.Label17).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.Label22).EndInit();
    ((ISupportInitialize) this.Label23).EndInit();
    ((ISupportInitialize) this.Label24).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
    ((ISupportInitialize) this.Label25).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.Label26).EndInit();
    ((ISupportInitialize) this.Label27).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
