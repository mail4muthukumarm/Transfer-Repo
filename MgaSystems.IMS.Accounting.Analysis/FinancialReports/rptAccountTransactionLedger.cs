// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.FinancialReports.rptAccountTransactionLedger
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.Reports;
using MGASystems.IMS.Accounting.Reports.AccountingReportControls;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Reporting.ReportControls;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.FinancialReports;

[Override(typeof (MGASystems.IMS.Accounting.Reports.rptAccountTransactionLedger))]
public class rptAccountTransactionLedger : MGAReport, IReport
{
  private int _CostCenterID;
  private string _GLAccountIDs;
  private int _GLCompanyID;
  private DateTime _DateRangeFrom;
  private DateTime _DateRangeTo;
  private bool _SummaryView;
  private Guid _entityGuid;
  private DataTable _Data;
  private DataSet _ds;
  private bool _excelOnly;
  private Detail Detail;
  private GroupHeader ghFullName;
  private GroupFooter gfFullName;
  private ReportHeader ReportHeader;
  private ReportFooter ReportFooter;
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
  private Label Label13;
  private Label label14;
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
  private TextBox TextBox3;
  private TextBox textBox5;
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
  private TextBox textGhAcctNum;
  private TextBox textGhFullName;

  public rptAccountTransactionLedger() => this.InitializeComponent();

  public rptAccountTransactionLedger(
    int GLCompanyID,
    int CostCenterId,
    string GLAccountIDs,
    DateTime DateRangeFrom,
    DateTime DateRangeTo,
    Guid EntityGuid,
    bool summaryView,
    bool excelOnly)
  {
    this.InitializeComponent();
    this._CostCenterID = CostCenterId;
    this._GLAccountIDs = GLAccountIDs;
    this._GLCompanyID = GLCompanyID;
    this._DateRangeTo = DateRangeTo;
    this._DateRangeFrom = DateRangeFrom;
    this._SummaryView = summaryView;
    this._entityGuid = EntityGuid;
    this._excelOnly = excelOnly;
  }

  private void rptAccountTransactionLedger_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this.txtDateRange.Text = string.Format(this.txtDateRange.Text, (object) this._DateRangeFrom.ToString("MM/dd/yyyy"), (object) this._DateRangeTo.ToString("MM/dd/yyyy"));
    this._ds = new DataSet();
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("spFin_rptAccountTransactionLedgerAnalysis", connection))
      {
        using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand))
        {
          selectCommand.CommandType = CommandType.StoredProcedure;
          selectCommand.CommandTimeout = 0;
          if (!string.IsNullOrEmpty(this._GLAccountIDs))
            selectCommand.Parameters.AddWithValue("@glaccountids", (object) this._GLAccountIDs);
          selectCommand.Parameters.AddWithValue("@glcompanyid", (object) this._GLCompanyID);
          if (this._CostCenterID == 0)
            selectCommand.Parameters.AddWithValue("@costcenterid", (object) DBNull.Value);
          else
            selectCommand.Parameters.AddWithValue("@costcenterid", (object) this._CostCenterID);
          selectCommand.Parameters.AddWithValue("@DateRangeTo", (object) this._DateRangeTo);
          selectCommand.Parameters.AddWithValue("@DateRangeFrom", (object) this._DateRangeFrom);
          selectCommand.Parameters.AddWithValue("@SummaryView", (object) this._SummaryView);
          if (!this._entityGuid.Equals(Guid.Empty))
            selectCommand.Parameters.AddWithValue("@EntityGuid", (object) this._entityGuid);
          sqlDataAdapter.Fill(this._ds);
        }
      }
    }
    this._Data = this._ds.Tables[0];
    this._Data.Columns.Add("Balance", typeof (Decimal));
    foreach (DataRow row in (InternalDataCollectionBase) this._Data.Rows)
      row["Balance"] = (object) (Database.IsNull(row["Credit"], 0M) + Database.IsNull(row["Debit"], 0M));
    if (this._excelOnly)
      return;
    this.DataSource = (object) this._Data;
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(this.txtTransactionNum.Text))
      return;
    this.txtTransactionNum.HyperLink = this.txtTransactionNum.Text;
  }

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[5]
      {
        (BaseReportControl) new MultiGLAccountSelectorWithCostCenter(),
        (BaseReportControl) new DateRangePicker("Date Range", DateTime.Now, DateTime.Now),
        (BaseReportControl) new EntitySelection("Entity", false),
        (BaseReportControl) new GenericCheckBox("", "Summary View"),
        (BaseReportControl) new GenericCheckBox("", "Export To Excel")
      };
    }
  }

  public Type getLaunchForm => (Type) null;

  public override bool HasRecords => this._Data.Rows.Count > 0;

  public override bool ExcelOnly => this._excelOnly;

  public override bool IsThreaded => true;

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    rptJournalTransaction rpt = new rptJournalTransaction(int.Parse(e.HyperLink));
    rpt.Run();
    rpt.Document.Name = $"Journal Transaction - {e.HyperLink}";
    ReportFactory.Instance.ShowReport((SectionReport) rpt);
  }

  public override void ExportToExcel(string SaveFileTo)
  {
    ExcelExport.ToExcel(this._Data, SaveFileTo);
  }

  private void ghFullName_Format(object sender, EventArgs e)
  {
    this.txtTitle.Text = $"{this.textGhAcctNum.Text} - {this.textGhFullName.Text}";
  }

  protected override void Dispose(bool disposing)
  {
    int num = disposing ? 1 : 0;
    base.Dispose(disposing);
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
    this.textBox5 = new TextBox();
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
    this.label14 = new Label();
    this.gfFullName = new GroupFooter();
    this.Line = new Line();
    this.Line1 = new Line();
    this.Line2 = new Line();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.currentBalanceSubTotal = new TextBox();
    this.TextBox11 = new TextBox();
    this.Label7 = new Label();
    this.ReportHeader = new ReportHeader();
    this.Label9 = new Label();
    this.txtDateRange = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.Line3 = new Line();
    this.Line4 = new Line();
    this.Line5 = new Line();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.currentBalanceTotal = new TextBox();
    this.Label8 = new Label();
    this.textGhAcctNum = new TextBox();
    this.textGhFullName = new TextBox();
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
    ((ISupportInitialize) this.textBox5).BeginInit();
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
    ((ISupportInitialize) this.label14).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.currentBalanceSubTotal).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.txtDateRange).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.currentBalanceTotal).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.textGhAcctNum).BeginInit();
    ((ISupportInitialize) this.textGhFullName).BeginInit();
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
      (ARControl) this.textBox5
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.135f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).BeforePrint += new EventHandler(this.Detail_BeforePrint);
    ((ARControl) this.TextBox1).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox1).DataField = "TransDescription";
    ((ARControl) this.TextBox1).Height = 0.125f;
    ((ARControl) this.TextBox1).Left = 0.375f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox1.Text = " ";
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 1.125f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox2).DataField = "PostDate";
    ((ARControl) this.TextBox2).Height = 0.125f;
    ((ARControl) this.TextBox2).Left = 1.5f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 0.625f;
    ((ARControl) this.txtTransactionNum).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.RightColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).Border.TopColor = Color.Black;
    ((ARControl) this.txtTransactionNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTransactionNum).DataField = "transactnum";
    ((ARControl) this.txtTransactionNum).Height = 0.125f;
    ((ARControl) this.txtTransactionNum).Left = 2.125f;
    ((ARControl) this.txtTransactionNum).Name = "txtTransactionNum";
    this.txtTransactionNum.Style = "color: Blue; ddo-char-set: 0; font-size: 8.25pt; ";
    this.txtTransactionNum.Text = (string) null;
    ((ARControl) this.txtTransactionNum).Top = 0.0f;
    ((ARControl) this.txtTransactionNum).Width = 9f / 16f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox4).DataField = "comments";
    ((ARControl) this.TextBox4).Height = 0.125f;
    ((ARControl) this.TextBox4).Left = 81f / 16f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 15f / 16f;
    ((ARControl) this.currentDebit).Border.BottomColor = Color.Black;
    ((ARControl) this.currentDebit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDebit).Border.LeftColor = Color.Black;
    ((ARControl) this.currentDebit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDebit).Border.RightColor = Color.Black;
    ((ARControl) this.currentDebit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDebit).Border.TopColor = Color.Black;
    ((ARControl) this.currentDebit).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentDebit).DataField = "Debit";
    ((ARControl) this.currentDebit).Height = 0.125f;
    ((ARControl) this.currentDebit).Left = 117f / 16f;
    ((ARControl) this.currentDebit).Name = "currentDebit";
    this.currentDebit.OutputFormat = resourceManager.GetString("currentDebit.OutputFormat");
    this.currentDebit.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.currentDebit.Text = " ";
    ((ARControl) this.currentDebit).Top = 0.0f;
    ((ARControl) this.currentDebit).Width = 1f;
    ((ARControl) this.currentCredit).Border.BottomColor = Color.Black;
    ((ARControl) this.currentCredit).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentCredit).Border.LeftColor = Color.Black;
    ((ARControl) this.currentCredit).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentCredit).Border.RightColor = Color.Black;
    ((ARControl) this.currentCredit).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentCredit).Border.TopColor = Color.Black;
    ((ARControl) this.currentCredit).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentCredit).DataField = "Credit";
    ((ARControl) this.currentCredit).Height = 0.125f;
    ((ARControl) this.currentCredit).Left = 133f / 16f;
    ((ARControl) this.currentCredit).Name = "currentCredit";
    this.currentCredit.OutputFormat = resourceManager.GetString("currentCredit.OutputFormat");
    this.currentCredit.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.currentCredit.Text = " ";
    ((ARControl) this.currentCredit).Top = 0.0f;
    ((ARControl) this.currentCredit).Width = 1f;
    ((ARControl) this.currentBalance).Border.BottomColor = Color.Black;
    ((ARControl) this.currentBalance).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentBalance).Border.LeftColor = Color.Black;
    ((ARControl) this.currentBalance).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentBalance).Border.RightColor = Color.Black;
    ((ARControl) this.currentBalance).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentBalance).Border.TopColor = Color.Black;
    ((ARControl) this.currentBalance).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentBalance).DataField = "Balance";
    ((ARControl) this.currentBalance).Height = 0.125f;
    ((ARControl) this.currentBalance).Left = 149f / 16f;
    ((ARControl) this.currentBalance).Name = "currentBalance";
    this.currentBalance.OutputFormat = resourceManager.GetString("currentBalance.OutputFormat");
    this.currentBalance.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.currentBalance.SummaryGroup = "ghFullName";
    this.currentBalance.SummaryRunning = (SummaryRunning) 1;
    this.currentBalance.SummaryType = (SummaryType) 3;
    this.currentBalance.Text = " ";
    ((ARControl) this.currentBalance).Top = 0.0f;
    ((ARControl) this.currentBalance).Width = 1f;
    ((ARControl) this.TextBox).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox).DataField = "checkNum";
    ((ARControl) this.TextBox).Height = 0.125f;
    ((ARControl) this.TextBox).Left = 6.625f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "ddo-char-set: 0; ";
    this.TextBox.Text = (string) null;
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 11f / 16f;
    ((ARControl) this.txtPolicyNum).Border.BottomColor = Color.Black;
    ((ARControl) this.txtPolicyNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNum).Border.LeftColor = Color.Black;
    ((ARControl) this.txtPolicyNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNum).Border.RightColor = Color.Black;
    ((ARControl) this.txtPolicyNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNum).Border.TopColor = Color.Black;
    ((ARControl) this.txtPolicyNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtPolicyNum).DataField = "policyNum";
    ((ARControl) this.txtPolicyNum).Height = 0.125f;
    ((ARControl) this.txtPolicyNum).Left = 43f / 16f;
    ((ARControl) this.txtPolicyNum).Name = "txtPolicyNum";
    this.txtPolicyNum.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.txtPolicyNum.Text = " ";
    ((ARControl) this.txtPolicyNum).Top = 0.0f;
    ((ARControl) this.txtPolicyNum).Width = 15f / 16f;
    ((ARControl) this.txtInvoiceNum).Border.BottomColor = Color.Black;
    ((ARControl) this.txtInvoiceNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.LeftColor = Color.Black;
    ((ARControl) this.txtInvoiceNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.RightColor = Color.Black;
    ((ARControl) this.txtInvoiceNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).Border.TopColor = Color.Black;
    ((ARControl) this.txtInvoiceNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtInvoiceNum).DataField = "invoiceNum";
    ((ARControl) this.txtInvoiceNum).Height = 0.125f;
    ((ARControl) this.txtInvoiceNum).Left = 3.625f;
    ((ARControl) this.txtInvoiceNum).Name = "txtInvoiceNum";
    this.txtInvoiceNum.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.txtInvoiceNum.Text = " ";
    ((ARControl) this.txtInvoiceNum).Top = 0.0f;
    ((ARControl) this.txtInvoiceNum).Width = 0.625f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox3).DataField = "BillingType";
    ((ARControl) this.TextBox3).Height = 0.125f;
    ((ARControl) this.TextBox3).Left = 4.25f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.TextBox3.Text = (string) null;
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 13f / 16f;
    ((ARControl) this.textBox5).Border.BottomColor = Color.Black;
    ((ARControl) this.textBox5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.LeftColor = Color.Black;
    ((ARControl) this.textBox5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.RightColor = Color.Black;
    ((ARControl) this.textBox5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).Border.TopColor = Color.Black;
    ((ARControl) this.textBox5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textBox5).DataField = "LineComments";
    ((ARControl) this.textBox5).Height = 0.125f;
    ((ARControl) this.textBox5).Left = 6f;
    ((ARControl) this.textBox5).Name = "textBox5";
    this.textBox5.Style = "ddo-char-set: 0; font-size: 8.25pt; ";
    this.textBox5.Text = " ";
    ((ARControl) this.textBox5).Top = 0.0f;
    ((ARControl) this.textBox5).Width = 0.625f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName).Controls.AddRange(new ARControl[16 /*0x10*/]
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
      (ARControl) this.label14,
      (ARControl) this.textGhAcctNum,
      (ARControl) this.textGhFullName
    });
    this.ghFullName.DataField = "AcctNum";
    this.ghFullName.Height = 0.698f;
    this.ghFullName.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName).Name = "ghFullName";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName).Format += new EventHandler(this.ghFullName_Format);
    ((ARControl) this.txtFullname).Border.BottomColor = Color.Black;
    ((ARControl) this.txtFullname).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullname).Border.LeftColor = Color.Black;
    ((ARControl) this.txtFullname).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullname).Border.RightColor = Color.Black;
    ((ARControl) this.txtFullname).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullname).Border.TopColor = Color.Black;
    ((ARControl) this.txtFullname).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtFullname).DataField = "glaccountname";
    ((ARControl) this.txtFullname).Height = 3f / 16f;
    ((ARControl) this.txtFullname).Left = 0.375f;
    ((ARControl) this.txtFullname).Name = "txtFullname";
    this.txtFullname.Style = "font-weight: bold; font-size: 9pt; ";
    this.txtFullname.Text = (string) null;
    ((ARControl) this.txtFullname).Top = 0.5f;
    ((ARControl) this.txtFullname).Width = 10.375f;
    ((ARControl) this.Label).Border.BottomColor = Color.Black;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label).Border.LeftColor = Color.Black;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightColor = Color.Black;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopColor = Color.Black;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 1f / 16f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "text-align: center; font-size: 9pt; vertical-align: bottom; ";
    this.Label.Text = "Transaction Type";
    ((ARControl) this.Label).Top = 0.25f;
    ((ARControl) this.Label).Width = 1.375f;
    ((ARControl) this.Label1).Border.BottomColor = Color.Black;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label1).Border.LeftColor = Color.Black;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightColor = Color.Black;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopColor = Color.Black;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 1.5f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9pt; vertical-align: bottom; ";
    this.Label1.Text = "Date";
    ((ARControl) this.Label1).Top = 0.25f;
    ((ARControl) this.Label1).Width = 9f / 16f;
    ((ARControl) this.Label2).Border.BottomColor = Color.Black;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label2).Border.LeftColor = Color.Black;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightColor = Color.Black;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopColor = Color.Black;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 2.125f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 9pt; vertical-align: bottom; ";
    this.Label2.Text = "Trans #";
    ((ARControl) this.Label2).Top = 0.25f;
    ((ARControl) this.Label2).Width = 9f / 16f;
    ((ARControl) this.Label3).Border.BottomColor = Color.Black;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label3).Border.LeftColor = Color.Black;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightColor = Color.Black;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopColor = Color.Black;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 81f / 16f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 9pt; vertical-align: bottom; ";
    this.Label3.Text = "Memo";
    ((ARControl) this.Label3).Top = 0.25f;
    ((ARControl) this.Label3).Width = 15f / 16f;
    ((ARControl) this.Label4).Border.BottomColor = Color.Black;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label4).Border.LeftColor = Color.Black;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightColor = Color.Black;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopColor = Color.Black;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 7.375f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "text-align: right; font-size: 9pt; vertical-align: bottom; ";
    this.Label4.Text = "Debits";
    ((ARControl) this.Label4).Top = 0.25f;
    ((ARControl) this.Label4).Width = 15f / 16f;
    ((ARControl) this.Label5).Border.BottomColor = Color.Black;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label5).Border.LeftColor = Color.Black;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightColor = Color.Black;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopColor = Color.Black;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 8.375f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "text-align: right; font-size: 9pt; vertical-align: bottom; ";
    this.Label5.Text = "Credits";
    ((ARControl) this.Label5).Top = 0.25f;
    ((ARControl) this.Label5).Width = 15f / 16f;
    ((ARControl) this.Label6).Border.BottomColor = Color.Black;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label6).Border.LeftColor = Color.Black;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightColor = Color.Black;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopColor = Color.Black;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 9.375f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "text-align: right; font-size: 9pt; vertical-align: bottom; ";
    this.Label6.Text = "Balance";
    ((ARControl) this.Label6).Top = 0.25f;
    ((ARControl) this.Label6).Width = 15f / 16f;
    ((ARControl) this.txtTitle).Border.BottomColor = Color.Black;
    ((ARControl) this.txtTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.LeftColor = Color.Black;
    ((ARControl) this.txtTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.RightColor = Color.Black;
    ((ARControl) this.txtTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Border.TopColor = Color.Black;
    ((ARControl) this.txtTitle).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTitle).Height = 0.25f;
    ((ARControl) this.txtTitle).Left = 0.0f;
    ((ARControl) this.txtTitle).Name = "txtTitle";
    this.txtTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 11.25pt; ";
    this.txtTitle.Text = (string) null;
    ((ARControl) this.txtTitle).Top = 0.0f;
    ((ARControl) this.txtTitle).Width = 10.375f;
    ((ARControl) this.Label10).Border.BottomColor = Color.Black;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label10).Border.LeftColor = Color.Black;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightColor = Color.Black;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopColor = Color.Black;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 107f / 16f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 9pt; vertical-align: bottom; ";
    this.Label10.Text = "Check #";
    ((ARControl) this.Label10).Top = 0.25f;
    ((ARControl) this.Label10).Width = 0.625f;
    ((ARControl) this.Label11).Border.BottomColor = Color.Black;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label11).Border.LeftColor = Color.Black;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightColor = Color.Black;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopColor = Color.Black;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 59f / 16f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 9pt; vertical-align: bottom; ";
    this.Label11.Text = "Invoice #";
    ((ARControl) this.Label11).Top = 0.25f;
    ((ARControl) this.Label11).Width = 9f / 16f;
    ((ARControl) this.Label12).Border.BottomColor = Color.Black;
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label12).Border.LeftColor = Color.Black;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightColor = Color.Black;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopColor = Color.Black;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 2.75f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 9pt; vertical-align: bottom; ";
    this.Label12.Text = "Policy #";
    ((ARControl) this.Label12).Top = 0.25f;
    ((ARControl) this.Label12).Width = 0.875f;
    ((ARControl) this.Label13).Border.BottomColor = Color.Black;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Label13).Border.LeftColor = Color.Black;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightColor = Color.Black;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopColor = Color.Black;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 69f / 16f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 9pt; vertical-align: bottom; ";
    this.Label13.Text = "Billing Type";
    ((ARControl) this.Label13).Top = 0.25f;
    ((ARControl) this.Label13).Width = 11f / 16f;
    ((ARControl) this.label14).Border.BottomColor = Color.Black;
    ((ARControl) this.label14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.label14).Border.LeftColor = Color.Black;
    ((ARControl) this.label14).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.label14).Border.RightColor = Color.Black;
    ((ARControl) this.label14).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.label14).Border.TopColor = Color.Black;
    ((ARControl) this.label14).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.label14).Height = 3f / 16f;
    this.label14.HyperLink = (string) null;
    ((ARControl) this.label14).Left = 6f;
    ((ARControl) this.label14).Name = "label14";
    this.label14.Style = "font-size: 9pt; vertical-align: bottom; ";
    this.label14.Text = "Comments";
    ((ARControl) this.label14).Top = 0.25f;
    ((ARControl) this.label14).Width = 11f / 16f;
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
    this.gfFullName.Height = 0.281f;
    this.gfFullName.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName).Name = "gfFullName";
    ((ARControl) this.Line).Border.BottomColor = Color.Black;
    ((ARControl) this.Line).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line).Border.LeftColor = Color.Black;
    ((ARControl) this.Line).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line).Border.RightColor = Color.Black;
    ((ARControl) this.Line).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line).Border.TopColor = Color.Black;
    ((ARControl) this.Line).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line).Height = 0.0f;
    ((ARControl) this.Line).Left = 7.25f;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    ((ARControl) this.Line).Top = 0.0f;
    ((ARControl) this.Line).Width = 1f;
    this.Line.X1 = 7.25f;
    this.Line.X2 = 8.25f;
    this.Line.Y1 = 0.0f;
    this.Line.Y2 = 0.0f;
    ((ARControl) this.Line1).Border.BottomColor = Color.Black;
    ((ARControl) this.Line1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line1).Border.LeftColor = Color.Black;
    ((ARControl) this.Line1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line1).Border.RightColor = Color.Black;
    ((ARControl) this.Line1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line1).Border.TopColor = Color.Black;
    ((ARControl) this.Line1).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 133f / 16f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 0.0f;
    ((ARControl) this.Line1).Width = 1f;
    this.Line1.X1 = 133f / 16f;
    this.Line1.X2 = 149f / 16f;
    this.Line1.Y1 = 0.0f;
    this.Line1.Y2 = 0.0f;
    ((ARControl) this.Line2).Border.BottomColor = Color.Black;
    ((ARControl) this.Line2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Border.LeftColor = Color.Black;
    ((ARControl) this.Line2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Border.RightColor = Color.Black;
    ((ARControl) this.Line2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Border.TopColor = Color.Black;
    ((ARControl) this.Line2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line2).Height = 0.0f;
    ((ARControl) this.Line2).Left = 9.375f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 0.0f;
    ((ARControl) this.Line2).Width = 1f;
    this.Line2.X1 = 9.375f;
    this.Line2.X2 = 10.375f;
    this.Line2.Y1 = 0.0f;
    this.Line2.Y2 = 0.0f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "Debit";
    ((ARControl) this.TextBox8).Height = 11f / 64f;
    ((ARControl) this.TextBox8).Left = 7.25f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.TextBox8.SummaryGroup = "ghFullName";
    this.TextBox8.SummaryRunning = (SummaryRunning) 1;
    this.TextBox8.SummaryType = (SummaryType) 3;
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 1f / 16f;
    ((ARControl) this.TextBox8).Width = 1f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox9).DataField = "Credit";
    ((ARControl) this.TextBox9).Height = 11f / 64f;
    ((ARControl) this.TextBox9).Left = 133f / 16f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.TextBox9.SummaryGroup = "ghFullName";
    this.TextBox9.SummaryRunning = (SummaryRunning) 1;
    this.TextBox9.SummaryType = (SummaryType) 3;
    this.TextBox9.Text = " ";
    ((ARControl) this.TextBox9).Top = 1f / 16f;
    ((ARControl) this.TextBox9).Width = 1f;
    ((ARControl) this.currentBalanceSubTotal).Border.BottomColor = Color.Black;
    ((ARControl) this.currentBalanceSubTotal).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.currentBalanceSubTotal).Border.LeftColor = Color.Black;
    ((ARControl) this.currentBalanceSubTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentBalanceSubTotal).Border.RightColor = Color.Black;
    ((ARControl) this.currentBalanceSubTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentBalanceSubTotal).Border.TopColor = Color.Black;
    ((ARControl) this.currentBalanceSubTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentBalanceSubTotal).DataField = "Balance";
    ((ARControl) this.currentBalanceSubTotal).Height = 11f / 64f;
    ((ARControl) this.currentBalanceSubTotal).Left = 9.375f;
    ((ARControl) this.currentBalanceSubTotal).Name = "currentBalanceSubTotal";
    this.currentBalanceSubTotal.OutputFormat = resourceManager.GetString("currentBalanceSubTotal.OutputFormat");
    this.currentBalanceSubTotal.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.currentBalanceSubTotal.SummaryGroup = "ghFullName";
    this.currentBalanceSubTotal.SummaryRunning = (SummaryRunning) 1;
    this.currentBalanceSubTotal.SummaryType = (SummaryType) 3;
    this.currentBalanceSubTotal.Text = " ";
    ((ARControl) this.currentBalanceSubTotal).Top = 1f / 16f;
    ((ARControl) this.currentBalanceSubTotal).Width = 1f;
    ((ARControl) this.TextBox11).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "glaccountname";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 11f / 16f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.Style = "font-size: 9pt; ";
    this.TextBox11.Text = (string) null;
    ((ARControl) this.TextBox11).Top = 1f / 16f;
    ((ARControl) this.TextBox11).Width = 6.5f;
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
    ((ARControl) this.Label7).Left = 0.375f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 9pt; ";
    this.Label7.Text = "Total";
    ((ARControl) this.Label7).Top = 1f / 16f;
    ((ARControl) this.Label7).Width = 5f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label9,
      (ARControl) this.txtDateRange
    });
    this.ReportHeader.Height = 0.51f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label9).Border.BottomColor = Color.Black;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftColor = Color.Black;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightColor = Color.Black;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopColor = Color.Black;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Height = 0.25f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 0.0f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "text-align: center; font-weight: bold; font-size: 14pt; ";
    this.Label9.Text = "Transactions by Account";
    ((ARControl) this.Label9).Top = 0.0f;
    ((ARControl) this.Label9).Width = 10.375f;
    ((ARControl) this.txtDateRange).Border.BottomColor = Color.Black;
    ((ARControl) this.txtDateRange).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.LeftColor = Color.Black;
    ((ARControl) this.txtDateRange).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.RightColor = Color.Black;
    ((ARControl) this.txtDateRange).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Border.TopColor = Color.Black;
    ((ARControl) this.txtDateRange).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtDateRange).Height = 3f / 16f;
    ((ARControl) this.txtDateRange).Left = 0.0f;
    ((ARControl) this.txtDateRange).Name = "txtDateRange";
    this.txtDateRange.Style = "ddo-char-set: 0; text-align: center; ";
    this.txtDateRange.Text = "Date Range {0} - {1}";
    ((ARControl) this.txtDateRange).Top = 0.25f;
    ((ARControl) this.txtDateRange).Width = 10.375f;
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
    this.ReportFooter.Height = 0.313f;
    this.ReportFooter.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    ((ARControl) this.Line3).Border.BottomColor = Color.Black;
    ((ARControl) this.Line3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Border.LeftColor = Color.Black;
    ((ARControl) this.Line3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Border.RightColor = Color.Black;
    ((ARControl) this.Line3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Border.TopColor = Color.Black;
    ((ARControl) this.Line3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 7.25f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 5f / 16f;
    ((ARControl) this.Line3).Width = 1f;
    this.Line3.X1 = 7.25f;
    this.Line3.X2 = 8.25f;
    this.Line3.Y1 = 5f / 16f;
    this.Line3.Y2 = 5f / 16f;
    ((ARControl) this.Line4).Border.BottomColor = Color.Black;
    ((ARControl) this.Line4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line4).Border.LeftColor = Color.Black;
    ((ARControl) this.Line4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line4).Border.RightColor = Color.Black;
    ((ARControl) this.Line4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line4).Border.TopColor = Color.Black;
    ((ARControl) this.Line4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line4).Height = 0.0f;
    ((ARControl) this.Line4).Left = 133f / 16f;
    this.Line4.LineWeight = 1f;
    ((ARControl) this.Line4).Name = "Line4";
    ((ARControl) this.Line4).Top = 5f / 16f;
    ((ARControl) this.Line4).Width = 1f;
    this.Line4.X1 = 133f / 16f;
    this.Line4.X2 = 149f / 16f;
    this.Line4.Y1 = 5f / 16f;
    this.Line4.Y2 = 5f / 16f;
    ((ARControl) this.Line5).Border.BottomColor = Color.Black;
    ((ARControl) this.Line5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line5).Border.LeftColor = Color.Black;
    ((ARControl) this.Line5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line5).Border.RightColor = Color.Black;
    ((ARControl) this.Line5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line5).Border.TopColor = Color.Black;
    ((ARControl) this.Line5).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.Line5).Height = 0.0f;
    ((ARControl) this.Line5).Left = 9.375f;
    this.Line5.LineWeight = 1f;
    ((ARControl) this.Line5).Name = "Line5";
    ((ARControl) this.Line5).Top = 5f / 16f;
    ((ARControl) this.Line5).Width = 1f;
    this.Line5.X1 = 9.375f;
    this.Line5.X2 = 10.375f;
    this.Line5.Y1 = 5f / 16f;
    this.Line5.Y2 = 5f / 16f;
    ((ARControl) this.TextBox12).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox12).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "Debit";
    ((ARControl) this.TextBox12).Height = 11f / 64f;
    ((ARControl) this.TextBox12).Left = 7.25f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.TextBox12.SummaryRunning = (SummaryRunning) 2;
    this.TextBox12.SummaryType = (SummaryType) 1;
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 1f / 16f;
    ((ARControl) this.TextBox12).Width = 1f;
    ((ARControl) this.TextBox13).Border.BottomColor = Color.Black;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.TextBox13).Border.LeftColor = Color.Black;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightColor = Color.Black;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopColor = Color.Black;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "Credit";
    ((ARControl) this.TextBox13).Height = 11f / 64f;
    ((ARControl) this.TextBox13).Left = 133f / 16f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.TextBox13.SummaryRunning = (SummaryRunning) 2;
    this.TextBox13.SummaryType = (SummaryType) 1;
    this.TextBox13.Text = " ";
    ((ARControl) this.TextBox13).Top = 1f / 16f;
    ((ARControl) this.TextBox13).Width = 1f;
    ((ARControl) this.currentBalanceTotal).Border.BottomColor = Color.Black;
    ((ARControl) this.currentBalanceTotal).Border.BottomStyle = (BorderLineStyle) 7;
    ((ARControl) this.currentBalanceTotal).Border.LeftColor = Color.Black;
    ((ARControl) this.currentBalanceTotal).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentBalanceTotal).Border.RightColor = Color.Black;
    ((ARControl) this.currentBalanceTotal).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentBalanceTotal).Border.TopColor = Color.Black;
    ((ARControl) this.currentBalanceTotal).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.currentBalanceTotal).DataField = "Balance";
    ((ARControl) this.currentBalanceTotal).Height = 11f / 64f;
    ((ARControl) this.currentBalanceTotal).Left = 9.375f;
    ((ARControl) this.currentBalanceTotal).Name = "currentBalanceTotal";
    this.currentBalanceTotal.OutputFormat = resourceManager.GetString("currentBalanceTotal.OutputFormat");
    this.currentBalanceTotal.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; ";
    this.currentBalanceTotal.SummaryRunning = (SummaryRunning) 2;
    this.currentBalanceTotal.SummaryType = (SummaryType) 1;
    this.currentBalanceTotal.Text = " ";
    ((ARControl) this.currentBalanceTotal).Top = 1f / 16f;
    ((ARControl) this.currentBalanceTotal).Width = 1f;
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
    ((ARControl) this.Label8).Left = 0.0f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-weight: bold; font-size: 9pt; ";
    this.Label8.Text = "TOTAL";
    ((ARControl) this.Label8).Top = 1f / 16f;
    ((ARControl) this.Label8).Width = 9f / 16f;
    ((ARControl) this.textGhAcctNum).Border.BottomColor = Color.Black;
    ((ARControl) this.textGhAcctNum).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctNum).Border.LeftColor = Color.Black;
    ((ARControl) this.textGhAcctNum).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctNum).Border.RightColor = Color.Black;
    ((ARControl) this.textGhAcctNum).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctNum).Border.TopColor = Color.Black;
    ((ARControl) this.textGhAcctNum).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhAcctNum).DataField = "AcctNum";
    ((ARControl) this.textGhAcctNum).Height = 0.1979167f;
    ((ARControl) this.textGhAcctNum).Left = 1f;
    ((ARControl) this.textGhAcctNum).Name = "textGhAcctNum";
    this.textGhAcctNum.Style = "background-color: Red; ";
    this.textGhAcctNum.Text = "AcctNum";
    ((ARControl) this.textGhAcctNum).Top = 0.0f;
    ((ARControl) this.textGhAcctNum).Visible = false;
    ((ARControl) this.textGhAcctNum).Width = 1f;
    ((ARControl) this.textGhFullName).Border.BottomColor = Color.Black;
    ((ARControl) this.textGhFullName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhFullName).Border.LeftColor = Color.Black;
    ((ARControl) this.textGhFullName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhFullName).Border.RightColor = Color.Black;
    ((ARControl) this.textGhFullName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhFullName).Border.TopColor = Color.Black;
    ((ARControl) this.textGhFullName).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.textGhFullName).DataField = "fullname";
    ((ARControl) this.textGhFullName).Height = 0.1979167f;
    ((ARControl) this.textGhFullName).Left = 3f;
    ((ARControl) this.textGhFullName).Name = "textGhFullName";
    this.textGhFullName.Style = "background-color: Red; ";
    this.textGhFullName.Text = "FullName";
    ((ARControl) this.textGhFullName).Top = 0.0f;
    ((ARControl) this.textGhFullName).Visible = false;
    ((ARControl) this.textGhFullName).Width = 1f;
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
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghFullName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfFullName);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black; ", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic; ", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
    this.ReportStart += new EventHandler(this.rptAccountTransactionLedger_ReportStart);
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
    ((ISupportInitialize) this.textBox5).EndInit();
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
    ((ISupportInitialize) this.label14).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.currentBalanceSubTotal).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.txtDateRange).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.currentBalanceTotal).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.textGhAcctNum).EndInit();
    ((ISupportInitialize) this.textGhFullName).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
