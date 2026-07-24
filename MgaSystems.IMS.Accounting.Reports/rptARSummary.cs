// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptARSummary
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
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
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{09C4DF50-CB49-49a4-A78A-28C3F6E9D0E1}", "AR Summary", "Accounts receivable summary report shown by bank and deposit date.", "Accounting")]
public sealed class rptARSummary : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{09C4DF50-CB49-49a4-A78A-28C3F6E9D0E1}";
  private DateTime _datFromDate;
  private DateTime _datToDate;
  private int _GLAcctID;
  private Label lblDate;
  private Label lblARReportTitle;
  private Label lblAgencyName;
  private Label lblBank;
  private Label Label1;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox6;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private Label Label5;

  public rptARSummary() => this.ReportStart += new EventHandler(this.rptARSummary_ReportStart);

  public rptARSummary(int GLAcctID, DateTime fromDate, DateTime toDate)
  {
    this.ReportStart += new EventHandler(this.rptARSummary_ReportStart);
    this.InitializeComponent();
    this._datFromDate = fromDate;
    this._datToDate = toDate;
    this._GLAcctID = GLAcctID;
  }

  private void rptARSummary_ReportStart(object sender, EventArgs e)
  {
    this.lblDate.Value = (object) DateAndTime.Now.ToShortDateString();
    this.lblAgencyName.Text = Database.Instance.QueryText.PerformScalarQuery("SELECT TOP 1 Location FROM tblClientOffices WHERE OfficeID = dbo.GetGlCompanyId(@bankAcctId)", (object) "@bankAcctId", (object) this._GLAcctID).ToString();
    this.lblARReportTitle.Text = $"Daily AR Report Summary ({this._datFromDate.ToShortDateString()} - {this._datToDate.ToShortDateString()})";
    this.lblBank.Text = Database.Instance.QueryText.PerformScalarQuery("SELECT BankName FROM tblFin_BankAccounts WHERE GLAcctID = " + this._GLAcctID.ToString()).ToString();
    this.SetStatusText("Getting AR Information..");
    SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataSet dataSet = new DataSet();
    try
    {
      selectCommand.CommandText = "[spFin_rptARSummary]";
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Connection = sqlConnection;
      selectCommand.Parameters.AddWithValue("@FROMDATE", (object) this._datFromDate);
      selectCommand.Parameters.AddWithValue("@TODATE", (object) this._datToDate);
      selectCommand.Parameters.AddWithValue("@GLAcctID", (object) this._GLAcctID);
      sqlDataAdapter.Fill(dataSet);
      dataSet.Tables[0].Columns.Add("Deposit", typeof (Decimal));
      dataSet.Tables[0].Columns.Add("Other", typeof (Decimal));
      this.SetStatusText("Calculating deposits and manual entries..");
      this.SetProgressbarMaximum(Math.Abs(checked (dataSet.Tables[0].Rows.Count * 2 + this._datToDate.Subtract(this._datFromDate).Days + 1)));
      try
      {
        foreach (DataRow row in dataSet.Tables[0].Rows)
        {
          row["Deposit"] = (object) Decimal.Add(Decimal.Add(Decimal.Add(Conversions.ToDecimal(row["AR AMOUNT"]), Conversions.ToDecimal(row["SURPLUS AMOUNT"])), Conversions.ToDecimal(row["EXCHANGE AMOUNT"])), Conversions.ToDecimal(row["MCI AMOUNT"]));
          row["Other"] = (object) Decimal.Add(Decimal.Add(Conversions.ToDecimal(row["SURPLUS AMOUNT"]), Conversions.ToDecimal(row["EXCHANGE AMOUNT"])), Conversions.ToDecimal(row["MCI AMOUNT"]));
          this.IncreaseProgressbar(1);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      double num = 0.0;
      string empty = string.Empty;
      DataTable table = new DataTable();
      table.Columns.Add("Date", typeof (DateTime));
      table.Columns.Add("Deposit", typeof (Decimal));
      table.Columns.Add("Posted", typeof (Decimal));
      table.Columns.Add("Other", typeof (Decimal));
      this.IncreaseProgressbar(1);
      while (DateTime.Compare(this._datFromDate.AddDays(num), this._datToDate) <= 0)
      {
        string filter = $"DEPOSITDATE = '{this._datFromDate.AddDays(num).ToString("MM/dd/yyyy")}'";
        Decimal d2 = Decimal.Subtract(Database.IsNull(RuntimeHelpers.GetObjectValue(dataSet.Tables[1].Compute("SUM(creditAmount)", filter)), 0M), Database.IsNull(RuntimeHelpers.GetObjectValue(dataSet.Tables[1].Compute("SUM(debitAmount)", filter)), 0M));
        DataRow row = table.NewRow();
        row["Date"] = (object) this._datFromDate.AddDays(num);
        row["Deposit"] = (object) Database.IsNull(RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Compute("SUM(DEPOSIT)", filter)), 0M);
        row["Posted"] = (object) Decimal.Subtract(Database.IsNull(RuntimeHelpers.GetObjectValue(dataSet.Tables[0].Compute("SUM(DEPOSIT)", filter)), 0M), d2);
        row["Other"] = (object) d2;
        table.Rows.Add(row);
        ++num;
        this.IncreaseProgressbar(1);
      }
      this.DataSource = (object) new DataView(table, "", "Date", DataViewRowState.CurrentRows);
      this.SetStandardMargins();
      this.ShowPageNumbers();
    }
    finally
    {
      sqlConnection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
    }
  }

  public override bool IsThreaded => true;

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptARSummary));
    this.Detail = new Detail();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.GroupHeader1 = new GroupHeader();
    this.GroupFooter1 = new GroupFooter();
    this.lblDate = new Label();
    this.lblARReportTitle = new Label();
    this.lblAgencyName = new Label();
    this.lblBank = new Label();
    this.Label1 = new Label();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.Label5 = new Label();
    ((ISupportInitialize) this.lblDate).BeginInit();
    ((ISupportInitialize) this.lblARReportTitle).BeginInit();
    ((ISupportInitialize) this.lblAgencyName).BeginInit();
    ((ISupportInitialize) this.lblBank).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.lblDate,
      (ARControl) this.lblARReportTitle,
      (ARControl) this.lblAgencyName,
      (ARControl) this.lblBank
    });
    this.PageHeader.Height = 1.125f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.Label1,
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4
    });
    this.GroupHeader1.Height = 0.3645833f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1).Name = "GroupHeader1";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Controls.AddRange(new ARControl[4]
    {
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.Label5
    });
    this.GroupFooter1.Height = 0.1666667f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1).Name = "GroupFooter1";
    ((ARControl) this.lblDate).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblDate).Border.TopStyle = (BorderLineStyle) 0;
    this.lblDate.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
    this.lblDate.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblDate.HyperLink = (string) null;
    Label lblDate = this.lblDate;
    object obj1 = componentResourceManager.GetObject("lblDate.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) lblDate).Location = pointF1;
    ((ARControl) this.lblDate).Name = "lblDate";
    ((ARControl) this.lblDate).Size = new SizeF(109f / 16f, 3f / 16f);
    this.lblDate.Text = "Report Date";
    ((ARControl) this.lblARReportTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblARReportTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblARReportTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblARReportTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.lblARReportTitle.Font = new Font("Arial", 12f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblARReportTitle.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblARReportTitle.HyperLink = (string) null;
    Label lblArReportTitle = this.lblARReportTitle;
    object obj2 = componentResourceManager.GetObject("lblARReportTitle.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) lblArReportTitle).Location = pointF2;
    ((ARControl) this.lblARReportTitle).Name = "lblARReportTitle";
    ((ARControl) this.lblARReportTitle).Size = new SizeF(109f / 16f, 0.25f);
    this.lblARReportTitle.Text = "Title";
    ((ARControl) this.lblAgencyName).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAgencyName).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAgencyName).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblAgencyName).Border.TopStyle = (BorderLineStyle) 0;
    this.lblAgencyName.Font = new Font("Arial", 18f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblAgencyName.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblAgencyName.HyperLink = (string) null;
    Label lblAgencyName = this.lblAgencyName;
    object obj3 = componentResourceManager.GetObject("lblAgencyName.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) lblAgencyName).Location = pointF3;
    ((ARControl) this.lblAgencyName).Name = "lblAgencyName";
    ((ARControl) this.lblAgencyName).Size = new SizeF(109f / 16f, 5f / 16f);
    this.lblAgencyName.Text = "Agency Name";
    ((ARControl) this.lblBank).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBank).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBank).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblBank).Border.TopStyle = (BorderLineStyle) 0;
    this.lblBank.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Bold);
    this.lblBank.ForeColor = Color.FromArgb(0, 0, 0);
    this.lblBank.HyperLink = (string) null;
    Label lblBank = this.lblBank;
    object obj4 = componentResourceManager.GetObject("lblBank.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) lblBank).Location = pointF4;
    ((ARControl) this.lblBank).Name = "lblBank";
    ((ARControl) this.lblBank).Size = new SizeF(109f / 16f, 3f / 16f);
    this.lblBank.Text = "Bank";
    this.Label1.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
    this.Label1.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj5 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) label1).Location = pointF5;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(1.25f, 3f / 16f);
    this.Label1.Text = "Deposited";
    this.Label2.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
    this.Label2.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj6 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) label2).Location = pointF6;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(1.25f, 3f / 16f);
    this.Label2.Text = "Posted";
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj7 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) label3).Location = pointF7;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(1.25f, 3f / 16f);
    this.Label3.Text = "Date";
    this.Label4.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Bold);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj8 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) label4).Location = pointF8;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(1.25f, 3f / 16f);
    this.Label4.Text = "Other";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "Date";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox1.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox1 = this.TextBox1;
    object obj9 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox1).Location = pointF9;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox1).Size = new SizeF(1.25f, 3f / 16f);
    this.TextBox2.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "Deposit";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox2.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox2 = this.TextBox2;
    object obj10 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox2).Location = pointF10;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox2).Size = new SizeF(1.25f, 3f / 16f);
    this.TextBox3.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "Posted";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox3.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox3 = this.TextBox3;
    object obj11 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox3).Location = pointF11;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox3).Size = new SizeF(1.25f, 3f / 16f);
    this.TextBox4.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "Other";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox4.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox4 = this.TextBox4;
    object obj12 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) textBox4).Location = pointF12;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox4).Size = new SizeF(1.25f, 3f / 16f);
    this.TextBox6.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox6).DataField = "Deposit";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox6.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox6 = this.TextBox6;
    object obj13 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) textBox6).Location = pointF13;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox6).Size = new SizeF(1.25f, 3f / 16f);
    this.TextBox6.SummaryGroup = "GroupHeader1";
    this.TextBox6.SummaryRunning = (SummaryRunning) 1;
    this.TextBox6.SummaryType = (SummaryType) 3;
    this.TextBox7.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox7).DataField = "Posted";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox7.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox7 = this.TextBox7;
    object obj14 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) textBox7).Location = pointF14;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox7).Size = new SizeF(1.25f, 3f / 16f);
    this.TextBox7.SummaryGroup = "GroupHeader1";
    this.TextBox7.SummaryRunning = (SummaryRunning) 1;
    this.TextBox7.SummaryType = (SummaryType) 3;
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox8).DataField = "Other";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.TextBox8.ForeColor = Color.FromArgb(0, 0, 0);
    TextBox textBox8 = this.TextBox8;
    object obj15 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) textBox8).Location = pointF15;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "$#,##0.00;($#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(1.25f, 3f / 16f);
    this.TextBox8.SummaryGroup = "GroupHeader1";
    this.TextBox8.SummaryRunning = (SummaryRunning) 1;
    this.TextBox8.SummaryType = (SummaryType) 3;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 9f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.ForeColor = Color.FromArgb(0, 0, 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj16 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) label5).Location = pointF16;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(1.25f, 3f / 16f);
    this.Label5.Text = "Totals:";
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupHeader1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.GroupFooter1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    ((ISupportInitialize) this.lblDate).EndInit();
    ((ISupportInitialize) this.lblARReportTitle).EndInit();
    ((ISupportInitialize) this.lblAgencyName).EndInit();
    ((ISupportInitialize) this.lblBank).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      return new BaseReportControl[2]
      {
        (BaseReportControl) new BankList("Bank"),
        (BaseReportControl) new DateRangePicker("Deposit Date", false)
      };
    }
  }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupHeader1")]
  private virtual GroupHeader GroupHeader1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Detail")]
  private virtual Detail Detail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupFooter1")]
  private virtual GroupFooter GroupFooter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
