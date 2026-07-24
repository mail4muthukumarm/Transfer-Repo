// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptAccountTransactionLedger
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{C5B0F05A-522E-47b5-995E-F5F307AC9628}", "Account Transaction Ledger", "Provides a transactional view for GL accounts and journal transaction drill down capability.", "Accounting")]
public class rptAccountTransactionLedger : MGAReport, IReport
{
  private int _CostCenterID;
  private string _GLAccountIDs;
  private int _GLCompanyID;
  private DateTime _DateRangeFrom;
  private DateTime _DateRangeTo;
  private bool _SummaryView;
  private Guid _entityGuid;
  private bool _excelOnly;
  private DataTable _Data;
  private DataSet _Ds;
  private Label Label9;
  private TextBox txtDateRange;
  private TextBox txtFullname;
  private Label Label;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private TextBox txtTitle;
  private Label Label10;
  private Label Label11;
  private Label Label12;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox txtTransactionNum;
  private TextBox TextBox4;
  private TextBox currentDebit;
  private TextBox currentCredit;
  private TextBox currentBalance;
  private TextBox TextBox;
  private TextBox txtPolicyNum;
  private TextBox txtInvoiceNum;
  private Line Line;
  private Line Line1;
  private Line Line2;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox currentBalanceSubTotal;
  private TextBox TextBox11;
  private Label Label7;
  private Line Line3;
  private Line Line4;
  private Line Line5;
  private TextBox TextBox12;
  private TextBox TextBox13;
  private TextBox currentBalanceTotal;
  private Label Label8;

  [field: AccessedThroughProperty("TextBox5")]
  private virtual TextBox TextBox5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  private virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptAccountTransactionLedger()
  {
    this.ReportStart += new EventHandler(this.rptAccountTransactionLedger_ReportStart);
    this._CostCenterID = 0;
    this.InitializeComponent();
  }

  public rptAccountTransactionLedger(
    int GLCompanyID,
    int CostCenterId,
    string GLAccountIDs,
    DateTime DateRangeFrom,
    DateTime DateRangeTo,
    Guid EntityGuid,
    bool summaryView,
    bool ExcelOnly)
  {
    this.ReportStart += new EventHandler(this.rptAccountTransactionLedger_ReportStart);
    this._CostCenterID = 0;
    this.InitializeComponent();
    this._CostCenterID = CostCenterId;
    this._GLAccountIDs = GLAccountIDs;
    this._GLCompanyID = GLCompanyID;
    this._DateRangeTo = DateRangeTo;
    this._DateRangeFrom = DateRangeFrom;
    this._SummaryView = summaryView;
    this._entityGuid = EntityGuid;
    this._excelOnly = ExcelOnly;
  }

  private void rptAccountTransactionLedger_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.txtDateRange.Text = string.Format(this.txtDateRange.Text, new object[2]
    {
      (object) this._DateRangeFrom.ToString("MM/dd/yyyy"),
      (object) this._DateRangeTo.ToString("MM/dd/yyyy")
    });
    TextBox txtDateRange;
    string str = (txtDateRange = this.txtDateRange).Text + string.Format("", (object) this._DateRangeTo.ToString("MM/dd/yyyy"));
    txtDateRange.Text = str;
    SqlConnection connection = new SqlConnection(Database.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand("spFin_rptAccountTransactionLedger", connection);
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    this._Ds = new DataSet();
    selectCommand.CommandType = CommandType.StoredProcedure;
    selectCommand.CommandTimeout = 0;
    selectCommand.Parameters.AddWithValue("@glaccountids", (object) this._GLAccountIDs);
    selectCommand.Parameters.AddWithValue("@glcompanyid", (object) this._GLCompanyID);
    selectCommand.Parameters.AddWithValue("@costcenterid", (object) this._CostCenterID);
    selectCommand.Parameters.AddWithValue("@DateRangeTo", (object) this._DateRangeTo);
    selectCommand.Parameters.AddWithValue("@DateRangeFrom", (object) this._DateRangeFrom);
    selectCommand.Parameters.AddWithValue("@SummaryView", (object) this._SummaryView);
    selectCommand.Parameters.AddWithValue("@EntityGuid", (object) this._entityGuid);
    try
    {
      connection.Open();
      sqlDataAdapter.Fill(this._Ds);
    }
    finally
    {
      connection.Close();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
      connection.Dispose();
    }
    this._Data = this._Ds.Tables[0];
    this._Data.Columns.Add("Balance", typeof (Decimal));
    try
    {
      foreach (DataRow row in this._Data.Rows)
        row["Balance"] = (object) Decimal.Add(Database.IsNull(RuntimeHelpers.GetObjectValue(row["Credit"]), 0M), Database.IsNull(RuntimeHelpers.GetObjectValue(row["Debit"]), 0M));
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this._excelOnly)
      return;
    this.DataSource = (object) this._Data;
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (this._excelOnly || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtTransactionNum.Text, string.Empty, false) == 0)
      return;
    this.txtTransactionNum.HyperLink = this.txtTransactionNum.Text.ToString();
  }

  private void ReportHeader_Format(object sender, EventArgs e)
  {
    if (this._excelOnly)
      return;
    this.TextHdCostCenter.Text = string.Format(this.TextHdCostCenter.Text, (object) this._Ds.Tables[2].Rows[0]["CostCenterName"].ToString());
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptAccountTransactionLedger));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.txtTransactionNum = new TextBox();
    this.TextBox4 = new TextBox();
    this.currentDebit = new TextBox();
    this.currentCredit = new TextBox();
    this.currentBalance = new TextBox();
    this.TextBox = new TextBox();
    this.txtPolicyNum = new TextBox();
    this.txtInvoiceNum = new TextBox();
    this.TextBox3 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.Label9 = new Label();
    this.txtDateRange = new TextBox();
    this.TextHdCostCenter = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.Line5 = new Line();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.currentBalanceTotal = new TextBox();
    this.Label8 = new Label();
    this.ghFullName = new GroupHeader();
    this.txtFullname = new TextBox();
    this.Label = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.txtTitle = new TextBox();
    this.Label10 = new Label();
    this.Label11 = new Label();
    this.Label12 = new Label();
    this.Label13 = new Label();
    this.gfFullName = new GroupFooter();
    this.Line = new Line();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.currentBalanceSubTotal = new TextBox();
    this.TextBox11 = new TextBox();
    this.Label7 = new Label();
    this.Label14 = new Label();
    this.TextBox5 = new TextBox();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.txtTransactionNum).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.currentDebit).BeginInit();
    ((ISupportInitialize) this.currentCredit).BeginInit();
    ((ISupportInitialize) this.currentBalance).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.txtPolicyNum).BeginInit();
    ((ISupportInitialize) this.txtInvoiceNum).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtDateRange).BeginInit();
    ((ISupportInitialize) this.TextHdCostCenter).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.currentBalanceTotal).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.txtFullname).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.txtTitle).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.currentBalanceSubTotal).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[12]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.txtTransactionNum,
      (ARControl) this.TextBox4,
      (ARControl) this.currentDebit,
      (ARControl) this.currentCredit,
      (ARControl) this.currentBalance,
      (ARControl) this.TextBox,
      (ARControl) this.txtPolicyNum,
      (ARControl) this.txtInvoiceNum,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox5
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.125f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).DataField = "TransDescription";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "font-size: 8.25pt; ddo-char-set: 0";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 1.177f;
    ((ARControl) this.TextBox2).DataField = "PostDate";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 1.177f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 8.25pt; ddo-char-set: 0";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.6245f;
    ((ARControl) this.txtTransactionNum).DataField = "transactnum";
    ((ARControl) this.txtTransactionNum).Height = 0.125f;
    ((ARControl) this.txtTransactionNum).Left = 1.802f;
    ((ARControl) this.txtTransactionNum).Name = "txtTransactionNum";
    this.txtTransactionNum.Style = "color: Blue; font-size: 8.25pt; ddo-char-set: 0";
    ((ARControl) this.txtTransactionNum).Top = 0.0f;
    ((ARControl) this.txtTransactionNum).Width = 0.5105f;
    ((ARControl) this.TextBox4).DataField = "comments";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 5.34f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 1.561f;
    ((ARControl) this.currentDebit).DataField = "Debit";
    ((ARControl) this.currentDebit).Height = 0.125f;
    ((ARControl) this.currentDebit).Left = 7.400001f;
    ((ARControl) this.currentDebit).Name = "currentDebit";
    this.currentDebit.OutputFormat = resourceManager.GetString("currentDebit.OutputFormat");
    this.currentDebit.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.currentDebit.Text = " ";
    ((ARControl) this.currentDebit).Top = 0.0f;
    ((ARControl) this.currentDebit).Width = 1f;
    ((ARControl) this.currentCredit).DataField = "Credit";
    ((ARControl) this.currentCredit).Height = 0.125f;
    ((ARControl) this.currentCredit).Left = 8.400001f;
    ((ARControl) this.currentCredit).Name = "currentCredit";
    this.currentCredit.OutputFormat = resourceManager.GetString("currentCredit.OutputFormat");
    this.currentCredit.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.currentCredit.Text = " ";
    ((ARControl) this.currentCredit).Top = 0.0f;
    ((ARControl) this.currentCredit).Width = 1f;
    ((ARControl) this.currentBalance).DataField = "Balance";
    ((ARControl) this.currentBalance).Height = 0.125f;
    ((ARControl) this.currentBalance).Left = 9.401f;
    ((ARControl) this.currentBalance).Name = "currentBalance";
    this.currentBalance.OutputFormat = resourceManager.GetString("currentBalance.OutputFormat");
    this.currentBalance.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.currentBalance.SummaryGroup = "ghFullName";
    this.currentBalance.SummaryRunning = (SummaryRunning) 1;
    this.currentBalance.SummaryType = (SummaryType) 3;
    this.currentBalance.Text = " ";
    ((ARControl) this.currentBalance).Top = 0.0f;
    ((ARControl) this.currentBalance).Width = 0.9990005f;
    ((ARControl) this.TextBox).DataField = "checkNum";
    ((ARControl) this.TextBox).Height = 0.125f;
    ((ARControl) this.TextBox).Left = 6.901f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "ddo-char-set: 0";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 0.4995003f;
    ((ARControl) this.txtPolicyNum).DataField = "policyNum";
    ((ARControl) this.txtPolicyNum).Height = 0.125f;
    ((ARControl) this.txtPolicyNum).Left = 37f / 16f;
    ((ARControl) this.txtPolicyNum).Name = "txtPolicyNum";
    this.txtPolicyNum.Style = "font-size: 8.25pt; ddo-char-set: 0";
    ((ARControl) this.txtPolicyNum).Top = 0.0f;
    ((ARControl) this.txtPolicyNum).Width = 0.9895f;
    ((ARControl) this.txtInvoiceNum).DataField = "invoiceNum";
    ((ARControl) this.txtInvoiceNum).Height = 0.125f;
    ((ARControl) this.txtInvoiceNum).Left = 3.302f;
    ((ARControl) this.txtInvoiceNum).Name = "txtInvoiceNum";
    this.txtInvoiceNum.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.txtInvoiceNum.Text = " ";
    ((ARControl) this.txtInvoiceNum).Top = 0.0f;
    ((ARControl) this.txtInvoiceNum).Width = 0.5730002f;
    ((ARControl) this.TextBox3).DataField = "BillingType";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 3.876f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "font-size: 8.25pt; ddo-char-set: 0";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 0.7504997f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[3]
    {
      (ARControl) this.Label9,
      (ARControl) this.txtDateRange,
      (ARControl) this.TextHdCostCenter
    });
    this.ReportHeader.Height = 0.7604167f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label9).Height = 0.25f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.0f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 14pt; font-weight: bold; text-align: center";
    this.Label9.Text = "Transactions by Account";
    ((ARControl) this.Label9).Top = 0.0f;
    ((ARControl) this.Label9).Width = 10.375f;
    ((ARControl) this.txtDateRange).Height = 3f / 16f;
    ((ARControl) this.txtDateRange).Left = 0.0f;
    ((ARControl) this.txtDateRange).Name = "txtDateRange";
    this.txtDateRange.Style = "text-align: center; ddo-char-set: 0";
    this.txtDateRange.Text = "Date Range {0} - {1}";
    ((ARControl) this.txtDateRange).Top = 7f / 16f;
    ((ARControl) this.txtDateRange).Width = 10.375f;
    ((ARControl) this.TextHdCostCenter).Height = 3f / 16f;
    ((ARControl) this.TextHdCostCenter).Left = 0.0f;
    ((ARControl) this.TextHdCostCenter).Name = "TextHdCostCenter";
    this.TextHdCostCenter.Style = "text-align: center; ddo-char-set: 0";
    this.TextHdCostCenter.Text = "Cost Center: {0}";
    ((ARControl) this.TextHdCostCenter).Top = 0.25f;
    ((ARControl) this.TextHdCostCenter).Width = 10.375f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Controls.AddRange(new ARControl[7]
    {
      (ARControl) this.Line3,
      (ARControl) this.Line4,
      (ARControl) this.Line5,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.currentBalanceTotal,
      (ARControl) this.Label8
    });
    this.ReportFooter.Height = 5f / 16f;
    this.ReportFooter.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 7.374001f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 0.281f;
    ((ARControl) this.Line3).Width = 1f;
    this.Line3.X1 = 7.374001f;
    this.Line3.X2 = 8.374001f;
    this.Line3.Y1 = 0.281f;
    this.Line3.Y2 = 0.281f;
    ((ARControl) this.Line4).Height = 0.0f;
    ((ARControl) this.Line4).Left = 8.374001f;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    ((ARControl) this.Line4).Top = 0.281f;
    ((ARControl) this.Line4).Width = 1f;
    this.Line4.X1 = 8.374001f;
    this.Line4.X2 = 9.374001f;
    this.Line4.Y1 = 0.281f;
    this.Line4.Y2 = 0.281f;
    ((ARControl) this.Line5).Height = 0.0f;
    ((ARControl) this.Line5).Left = 9.375f;
    this.Line5.LineWeight = 1f;
    ((ARControl) this.Line5).Name = "Line5";
    ((ARControl) this.Line5).Top = 9f / 32f;
    ((ARControl) this.Line5).Width = 1f;
    this.Line5.X1 = 9.375f;
    this.Line5.X2 = 10.375f;
    this.Line5.Y1 = 9f / 32f;
    this.Line5.Y2 = 9f / 32f;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox12).DataField = "Debit";
    ((ARControl) this.TextBox12).Height = 11f / 64f;
    ((ARControl) this.TextBox12).Left = 7.401f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.TextBox12.SummaryRunning = (SummaryRunning) 2;
    this.TextBox12.SummaryType = (SummaryType) 1;
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 0.062f;
    ((ARControl) this.TextBox12).Width = 1f;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox13).DataField = "Credit";
    ((ARControl) this.TextBox13).Height = 11f / 64f;
    ((ARControl) this.TextBox13).Left = 8.401f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.TextBox13.SummaryRunning = (SummaryRunning) 2;
    this.TextBox13.SummaryType = (SummaryType) 1;
    this.TextBox13.Text = " ";
    ((ARControl) this.TextBox13).Top = 0.062f;
    ((ARControl) this.TextBox13).Width = 1f;
    ((ARControl) this.currentBalanceTotal).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.currentBalanceTotal).DataField = "Balance";
    ((ARControl) this.currentBalanceTotal).Height = 11f / 64f;
    ((ARControl) this.currentBalanceTotal).Left = 9.400001f;
    ((ARControl) this.currentBalanceTotal).Name = "currentBalanceTotal";
    this.currentBalanceTotal.OutputFormat = resourceManager.GetString("currentBalanceTotal.OutputFormat");
    this.currentBalanceTotal.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.currentBalanceTotal.SummaryRunning = (SummaryRunning) 2;
    this.currentBalanceTotal.SummaryType = (SummaryType) 1;
    this.currentBalanceTotal.Text = " ";
    ((ARControl) this.currentBalanceTotal).Top = 0.062f;
    ((ARControl) this.currentBalanceTotal).Width = 1f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 0.0f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 9pt; font-weight: bold";
    this.Label8.Text = "TOTAL";
    ((ARControl) this.Label8).Top = 1f / 16f;
    ((ARControl) this.Label8).Width = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName).Controls.AddRange(new ARControl[14]
    {
      (ARControl) this.txtFullname,
      (ARControl) this.Label,
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.txtTitle,
      (ARControl) this.Label10,
      (ARControl) this.Label11,
      (ARControl) this.Label12,
      (ARControl) this.Label13,
      (ARControl) this.Label14
    });
    this.ghFullName.DataField = "fullname";
    this.ghFullName.Height = 0.6979167f;
    this.ghFullName.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName).Name = "ghFullName";
    ((ARControl) this.txtFullname).DataField = "glaccountname";
    ((ARControl) this.txtFullname).Height = 3f / 16f;
    ((ARControl) this.txtFullname).Left = 0.375f;
    ((ARControl) this.txtFullname).Name = "txtFullname";
    this.txtFullname.Style = "font-size: 9pt; font-weight: bold";
    this.txtFullname.Text = (string) null;
    ((ARControl) this.txtFullname).Top = 0.5f;
    ((ARControl) this.txtFullname).Width = 10.375f;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 9pt; text-align: center; vertical-align: bottom";
    this.Label.Text = "Transaction Type";
    ((ARControl) this.Label).Top = 0.25f;
    ((ARControl) this.Label).Width = 1.177f;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 1.177f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label1.Text = "Date";
    ((ARControl) this.Label1).Top = 0.25f;
    ((ARControl) this.Label1).Width = 0.625f;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 1.802f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label2.Text = "Trans #";
    ((ARControl) this.Label2).Top = 0.25f;
    ((ARControl) this.Label2).Width = 0.51f;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 5.339f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label3.Text = "Memo";
    ((ARControl) this.Label3).Top = 0.25f;
    ((ARControl) this.Label3).Width = 1.562001f;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 7.401f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 9pt; text-align: right; vertical-align: bottom";
    this.Label4.Text = "Debits";
    ((ARControl) this.Label4).Top = 0.25f;
    ((ARControl) this.Label4).Width = 0.9990005f;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 8.401f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 9pt; text-align: right; vertical-align: bottom";
    this.Label5.Text = "Credits";
    ((ARControl) this.Label5).Top = 0.25f;
    ((ARControl) this.Label5).Width = 1.0005f;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 9.400001f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 9pt; text-align: right; vertical-align: bottom";
    this.Label6.Text = "Balance";
    ((ARControl) this.Label6).Top = 0.25f;
    ((ARControl) this.Label6).Width = 0.9995003f;
    ((ARControl) this.txtTitle).DataField = "fullname";
    ((ARControl) this.txtTitle).Height = 0.25f;
    ((ARControl) this.txtTitle).Left = 0.0f;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.Style = "font-size: 11.25pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.txtTitle.Text = (string) null;
    ((ARControl) this.txtTitle).Top = 0.0f;
    ((ARControl) this.txtTitle).Width = 10.375f;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 6.901f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label10.Text = "Check #";
    ((ARControl) this.Label10).Top = 0.25f;
    ((ARControl) this.Label10).Width = 0.4995003f;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 3.302f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label11.Text = "Invoice #";
    ((ARControl) this.Label11).Top = 0.25f;
    ((ARControl) this.Label11).Width = 0.573f;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 2.312f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label12.Text = "Policy #";
    ((ARControl) this.Label12).Top = 0.25f;
    ((ARControl) this.Label12).Width = 0.9900002f;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 3.875001f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label13.Text = "Billing Type";
    ((ARControl) this.Label13).Top = 0.25f;
    ((ARControl) this.Label13).Width = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName).Controls.AddRange(new ARControl[8]
    {
      (ARControl) this.Line,
      (ARControl) this.Line1,
      (ARControl) this.Line2,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.currentBalanceSubTotal,
      (ARControl) this.TextBox11,
      (ARControl) this.Label7
    });
    this.gfFullName.Height = 9f / 32f;
    this.gfFullName.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName).Name = "gfFullName";
    ((ARControl) this.Line).Height = 0.0f;
    ((ARControl) this.Line).Left = 7.398001f;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    ((ARControl) this.Line).Top = 0.0f;
    ((ARControl) this.Line).Width = 1f;
    this.Line.X1 = 7.398001f;
    this.Line.X2 = 8.398001f;
    this.Line.Y1 = 0.0f;
    this.Line.Y2 = 0.0f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 8.398001f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 0.0f;
    ((ARControl) this.Line1).Width = 1f;
    this.Line1.X1 = 8.398001f;
    this.Line1.X2 = 9.398001f;
    this.Line1.Y1 = 0.0f;
    this.Line1.Y2 = 0.0f;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 9.399f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 0.0f;
    ((ARControl) this.Line2).Width = 1f;
    this.Line2.X1 = 9.399f;
    this.Line2.X2 = 10.399f;
    this.Line2.Y1 = 0.0f;
    this.Line2.Y2 = 0.0f;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "Debit";
    ((ARControl) this.TextBox8).Height = 11f / 64f;
    ((ARControl) this.TextBox8).Left = 7.398001f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.TextBox8.SummaryGroup = "ghFullName";
    this.TextBox8.SummaryRunning = (SummaryRunning) 1;
    this.TextBox8.SummaryType = (SummaryType) 3;
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.062f;
    ((ARControl) this.TextBox8).Width = 1f;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).DataField = "Credit";
    ((ARControl) this.TextBox9).Height = 11f / 64f;
    ((ARControl) this.TextBox9).Left = 8.401f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.TextBox9.SummaryGroup = "ghFullName";
    this.TextBox9.SummaryRunning = (SummaryRunning) 1;
    this.TextBox9.SummaryType = (SummaryType) 3;
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox9).Top = 0.062f;
    ((ARControl) this.TextBox9).Width = 1f;
    ((ARControl) this.currentBalanceSubTotal).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.currentBalanceSubTotal).DataField = "Balance";
    ((ARControl) this.currentBalanceSubTotal).Height = 11f / 64f;
    ((ARControl) this.currentBalanceSubTotal).Left = 9.399f;
    ((ARControl) this.currentBalanceSubTotal).Name = "currentBalanceSubTotal";
    this.currentBalanceSubTotal.OutputFormat = resourceManager.GetString("currentBalanceSubTotal.OutputFormat");
    this.currentBalanceSubTotal.Style = "font-size: 8.25pt; text-align: right; ddo-char-set: 0";
    this.currentBalanceSubTotal.SummaryGroup = "ghFullName";
    this.currentBalanceSubTotal.SummaryRunning = (SummaryRunning) 1;
    this.currentBalanceSubTotal.SummaryType = (SummaryType) 3;
    this.currentBalanceSubTotal.Text = " ";
    ((ARControl) this.currentBalanceSubTotal).Top = 0.062f;
    ((ARControl) this.currentBalanceSubTotal).Width = 1f;
    ((ARControl) this.TextBox11).DataField = "glaccountname";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 11f / 16f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.Style = "font-size: 9pt";
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 1f / 16f;
    ((ARControl) this.TextBox11).Width = 6.686501f;
    ((ARControl) this.Label7).Height = 3f / 16f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 0.375f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 9pt";
    this.Label7.Text = "Total";
    ((ARControl) this.Label7).Top = 1f / 16f;
    ((ARControl) this.Label7).Width = 5f / 16f;
    ((ARControl) this.Label14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 4.625f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 9pt; vertical-align: bottom";
    this.Label14.Text = "Cost Center";
    ((ARControl) this.Label14).Top = 0.25f;
    ((ARControl) this.Label14).Width = 0.7140002f;
    ((ARControl) this.TextBox5).DataField = "CostCenter";
    ((ARControl) this.TextBox5).Height = 0.125f;
    ((ARControl) this.TextBox5).Left = 4.625f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 8.25pt; ddo-char-set: 0";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.7144997f;
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.5f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 10.4f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.txtTransactionNum).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.currentDebit).EndInit();
    ((ISupportInitialize) this.currentCredit).EndInit();
    ((ISupportInitialize) this.currentBalance).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.txtPolicyNum).EndInit();
    ((ISupportInitialize) this.txtInvoiceNum).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtDateRange).EndInit();
    ((ISupportInitialize) this.TextHdCostCenter).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.currentBalanceTotal).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.txtFullname).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.txtTitle).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.currentBalanceSubTotal).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[5]
      {
        (BaseReportControl) new MultiGLAccountSelectorWithCostCenter(),
        (BaseReportControl) new DateRangePicker("Date Range", DateAndTime.Now, DateAndTime.Now),
        (BaseReportControl) new EntitySelection("Entity", false),
        (BaseReportControl) new GenericCheckBox("", "Summary View"),
        (BaseReportControl) new GenericCheckBox("", "Direct to Excel")
      };
    }
  }

  public override bool IsThreaded => true;

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    if (this._excelOnly)
      return;
    rptJournalTransaction rpt = new rptJournalTransaction(Conversions.ToInteger(e.HyperLink));
    rpt.Run();
    rpt.Document.Name = $"Journal Transaction - {e.HyperLink}";
    ReportFactory.Instance.ShowReport((SectionReport) rpt);
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    if (this._Ds.Tables.CanRemove(this._Ds.Tables[2]))
      this._Ds.Tables.Remove(this._Ds.Tables[2]);
    if (this._Ds.Tables.CanRemove(this._Ds.Tables[1]))
      this._Ds.Tables.Remove(this._Ds.Tables[1]);
    GC.Collect();
    GC.WaitForPendingFinalizers();
    ExcelExport.ToExcel(this._Ds, SaveFileTo);
  }

  public override bool HasRecords => this._Data.Rows.Count > 0;

  public override bool ExcelOnly => this._excelOnly;

  [field: AccessedThroughProperty("TextBox3")]
  private virtual TextBox TextBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("TextHdCostCenter")]
  private virtual TextBox TextHdCostCenter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual ReportHeader ReportHeader
  {
    get => this._ReportHeader;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ReportHeader_Format);
      ReportHeader reportHeader1 = this._ReportHeader;
      if (reportHeader1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) reportHeader1).Format -= eventHandler;
      this._ReportHeader = value;
      ReportHeader reportHeader2 = this._ReportHeader;
      if (reportHeader2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) reportHeader2).Format += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ghFullName")]
  private virtual GroupHeader ghFullName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("gfFullName")]
  private virtual GroupFooter gfFullName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
