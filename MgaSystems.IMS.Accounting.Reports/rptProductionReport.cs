// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptProductionReport
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using GrapeCity.ActiveReports.Viewer.Win;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Policies.PolicyDetail;
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
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{CC322836-8CC2-40c5-98B7-8D316CAAC14B}", "Production Report", "Production Report.", "General")]
[SecureResource("{7A80CDAA-8E51-4a11-BE9A-F17D72F55AA0}", "Production Report User Access", "Allows user to run report for any/all users.", "Reports")]
[SecureResource("{CB84C8BA-08AC-4102-B171-1950CFC673FC}", "Production Report Issuing Office Access", "Allows user to run report for any/all issuing offices.", "Reports")]
public sealed class rptProductionReport : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{CC322836-8CC2-40c5-98B7-8D316CAAC14B}";
  internal const string SecurityIDAllUsers = "{7A80CDAA-8E51-4a11-BE9A-F17D72F55AA0}";
  internal const string SecurityIDAllOffices = "{CB84C8BA-08AC-4102-B171-1950CFC673FC}";
  private SqlConnection _connection;
  private SqlCommand _command;
  private SqlDataAdapter _da;
  private DataTable _dt;
  private DateTime _billingDateFrom;
  private DateTime _billingDateTo;
  private DateTime _effectiveDateFrom;
  private DateTime _effectiveDateTo;
  private Guid _underwriterGuid;
  private Guid _producerGuid;
  private int _policyTypeID;
  private int _UnderWriterItemCount;
  private int _MonthlyItemCount;
  private int _TotalItemCount;
  private Guid _inhouseProducerGuid;
  private Guid _companyGuid;
  private Guid _companyLocationGuid;
  private Guid _officeGuid;
  private Guid _lineGuid;
  private bool _showAllOffices;
  private string _issuingOfficeIDs;
  private Guid _ProducerLocationGuid;
  private string _SortBy;
  private DataView _dv;
  private int _QuoteStatusID;
  private Guid _CompanyGroupGuid;
  private int _costCenter;
  private bool _excelOnly;
  private Label Label1;
  private TextBox txtSubTitle;
  private Label lblCriteria1Title;
  private Label Label2;
  private Label Label3;
  private Label Label4;
  private Label Label5;
  private Label Label6;
  private Label Label8;
  private Label Label9;
  private Label Label10;
  private Label lblCriteria2Title;
  private Label Label18;
  private Label Label19;
  private Label Label20;
  private Label Label22;
  private Label Label23;
  private Label Label24;
  private Label Label25;
  private Label Label;
  private Label Label7;
  private Label Label11;
  private Label Label13;
  private TextBox TextBox1;
  private TextBox TextBox2;
  private TextBox TextBox3;
  private TextBox TextBox4;
  private TextBox TextBox5;
  private TextBox TextBox7;
  private TextBox TextBox8;
  private TextBox TextBox9;
  private TextBox TextBox19;
  private TextBox TextBox20;
  private TextBox TextBox21;
  private TextBox txtQuoteControlNum;
  private TextBox Producer1;
  private TextBox Insured1;
  private TextBox NetBilled1;
  private TextBox TextBox;
  private TextBox TextBox6;
  private TextBox TextBox10;
  private TextBox TextBox14;
  private TextBox TextBox15;
  private TextBox TextBox16;
  private TextBox TextBox17;
  private Label Label16;
  private Label lblCriteria2FooterText;
  private TextBox TextBox22;
  private TextBox TextBox23;
  private TextBox txtUnderWriterItemCount;
  private TextBox NetBilled2;
  private TextBox TextBox18;
  private TextBox TextBox11;
  private TextBox TextBox12;
  private TextBox TextBox13;
  private Label Label12;
  private Label lblCriteria1FooterText;
  private TextBox TextBox24;
  private TextBox TextBox25;
  private TextBox txtMonthItemCount;
  private TextBox NetBilled3;
  private TextBox TextBox29;
  private TextBox TextBox31;
  private TextBox TextBox30;
  private Label Label21;
  private TextBox TextBox28;
  private TextBox TextBox27;
  private TextBox TextBox26;
  private TextBox txtTotalItems;
  private TextBox NetBilled4;
  private TextBox TextBox32;

  public rptProductionReport()
  {
    this.ReportStart += new EventHandler(this.rptProductionReport_ReportStart);
    this._UnderWriterItemCount = 0;
    this._MonthlyItemCount = 0;
    this._TotalItemCount = 0;
    this._costCenter = 0;
  }

  public rptProductionReport(
    DateTime billingDateFrom,
    DateTime billingDateTo,
    DateTime effectiveDateFrom,
    DateTime effectiveDateTo,
    Guid underwriterGuid,
    Guid inhouseProducerGuid,
    Guid producerGuid,
    int PolicyTypeID,
    Guid CompanyGroupGuid,
    Guid companyGuid,
    Guid companyLocationGuid,
    Guid OfficeGuid,
    Guid LineGuid,
    int QuoteStatusID,
    string IssuingOfficeIDs,
    bool ShowAllOffices,
    Guid ProducerLocationGuid,
    string SortBy,
    int costCenter,
    bool excelOnly)
  {
    this.ReportStart += new EventHandler(this.rptProductionReport_ReportStart);
    this._UnderWriterItemCount = 0;
    this._MonthlyItemCount = 0;
    this._TotalItemCount = 0;
    this._costCenter = 0;
    this.InitializeComponent();
    this._billingDateFrom = billingDateFrom;
    this._billingDateTo = billingDateTo;
    this._effectiveDateFrom = effectiveDateFrom;
    this._effectiveDateTo = effectiveDateTo;
    this._underwriterGuid = underwriterGuid;
    this._producerGuid = producerGuid;
    this._policyTypeID = PolicyTypeID;
    this._inhouseProducerGuid = inhouseProducerGuid;
    this._companyGuid = companyGuid;
    this._companyLocationGuid = companyLocationGuid;
    this._officeGuid = OfficeGuid;
    this._lineGuid = LineGuid;
    this._showAllOffices = ShowAllOffices;
    this._issuingOfficeIDs = IssuingOfficeIDs;
    this._ProducerLocationGuid = ProducerLocationGuid;
    this._SortBy = SortBy;
    this._QuoteStatusID = QuoteStatusID;
    this._CompanyGroupGuid = CompanyGroupGuid;
    this._costCenter = costCenter;
    this._excelOnly = excelOnly;
    this._dt = new DataTable();
    string[] strArray = Strings.Split(SortBy, ",");
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray[0], "MonthNumeric", false) == 0)
    {
      this.ghCriteria1.DataField = "MonthNumeric";
      ((ARControl) this.lblCriteria1Title).DataField = "Month";
      ((ARControl) this.lblCriteria1FooterText).DataField = "Month";
    }
    else
    {
      this.ghCriteria1.DataField = strArray[0];
      ((ARControl) this.lblCriteria1Title).DataField = strArray[0];
      ((ARControl) this.lblCriteria1FooterText).DataField = strArray[0];
    }
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(strArray[1], "MonthNumeric", false) == 0)
    {
      this.ghCriteria2.DataField = "MonthNumeric";
      ((ARControl) this.lblCriteria2Title).DataField = "Month";
      ((ARControl) this.lblCriteria2FooterText).DataField = "Month";
    }
    else
    {
      this.ghCriteria2.DataField = strArray[1];
      ((ARControl) this.lblCriteria2Title).DataField = strArray[1];
      ((ARControl) this.lblCriteria2FooterText).DataField = strArray[1];
    }
  }

  private void Detail_BeforePrint(object sender, EventArgs e)
  {
    if (this._dv == null || this._dv.Table.Rows.Count <= 0)
      return;
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = checked (^(local = ref this._UnderWriterItemCount) + 1);
    local = num;
    this.txtQuoteControlNum.HyperLink = this.txtQuoteControlNum.Value.ToString();
    this.SetDetailControlsHeight();
  }

  private void gfCriteria2_BeforePrint(object sender, EventArgs e)
  {
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = checked (^(local = ref this._MonthlyItemCount) + this._UnderWriterItemCount);
    local = num;
    this.txtUnderWriterItemCount.Text = this._UnderWriterItemCount.ToString() + " ITEMS";
    this._UnderWriterItemCount = 0;
  }

  private void gfCriteria1_BeforePrint(object sender, EventArgs e)
  {
    // ISSUE: variable of a reference type
    int& local;
    // ISSUE: explicit reference operation
    int num = checked (^(local = ref this._TotalItemCount) + this._MonthlyItemCount);
    local = num;
    this.txtMonthItemCount.Text = this._MonthlyItemCount.ToString() + " ITEMS";
    this._MonthlyItemCount = 0;
  }

  private void gfTotal_BeforePrint(object sender, EventArgs e)
  {
    this.txtTotalItems.Value = (object) this._TotalItemCount;
    this.txtTotalItems.Text = this._TotalItemCount.ToString() + " ITEMS";
  }

  public override void Hyperlink(object sender, HyperLinkEventArgs e)
  {
    FormSettings.ShowForm(typeof (frmPolicyDetail), (object) Conversions.ToInteger(e.HyperLink));
  }

  private void rptProductionReport_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    this._command = new SqlCommand("spFin_rptProductionReport", this._connection);
    this._command.CommandType = CommandType.StoredProcedure;
    this._command.CommandTimeout = 0;
    this.AddCommandToCancelList(this._command);
    if (DateTime.Compare(this._billingDateFrom, DateTime.MinValue) != 0)
    {
      this._command.Parameters.Add("@billingDateFrom", SqlDbType.DateTime);
      this._command.Parameters["@billingDateFrom"].Value = (object) this._billingDateFrom.Date;
      TextBox txtSubTitle;
      string str = $"{(txtSubTitle = this.txtSubTitle).Text} Billing Date After {this._billingDateFrom.Date.ToString("MM/dd/yyyy")}";
      txtSubTitle.Text = str;
    }
    if (DateTime.Compare(this._billingDateTo, DateTime.MinValue) != 0)
    {
      this._command.Parameters.Add("@billingDateTo", SqlDbType.DateTime);
      this._command.Parameters["@billingDateTo"].Value = (object) this._billingDateTo.Date;
      TextBox txtSubTitle;
      string str = $"{(txtSubTitle = this.txtSubTitle).Text} Billing Date To {this._billingDateTo.Date.ToString("MM/dd/yyyy")}";
      txtSubTitle.Text = str;
    }
    if (DateTime.Compare(this._effectiveDateFrom, DateTime.MinValue) != 0)
    {
      this._command.Parameters.Add("@effectiveDateFrom", SqlDbType.DateTime);
      this._command.Parameters["@effectiveDateFrom"].Value = (object) this._effectiveDateFrom.Date;
      TextBox txtSubTitle;
      string str = $"{(txtSubTitle = this.txtSubTitle).Text} Effective Date From {this._effectiveDateFrom.Date.ToString("MM/dd/yyyy")}";
      txtSubTitle.Text = str;
    }
    if (DateTime.Compare(this._effectiveDateTo, DateTime.MinValue) != 0)
    {
      this._command.Parameters.Add("@effectiveDateTo", SqlDbType.DateTime);
      this._command.Parameters["@effectiveDateTo"].Value = (object) this._effectiveDateTo.Date;
      TextBox txtSubTitle;
      string str = $"{(txtSubTitle = this.txtSubTitle).Text} Effective Date To {this._effectiveDateTo.Date.ToString("MM/dd/yyyy")}";
      txtSubTitle.Text = str;
    }
    if (this._QuoteStatusID >= 0)
    {
      this._command.Parameters.Add("@QuoteStatusID", SqlDbType.Int);
      this._command.Parameters["@QuoteStatusID"].Value = (object) this._QuoteStatusID;
    }
    if (!this._underwriterGuid.Equals(Guid.Empty))
    {
      this._command.Parameters.Add("@underwriterGuid", SqlDbType.UniqueIdentifier);
      this._command.Parameters["@underwriterGuid"].Value = (object) this._underwriterGuid;
    }
    if (!this._inhouseProducerGuid.Equals(Guid.Empty))
    {
      this._command.Parameters.Add("@inHouseProducerGuid", SqlDbType.UniqueIdentifier);
      this._command.Parameters["@inHouseProducerGuid"].Value = (object) this._inhouseProducerGuid;
    }
    if (!this._producerGuid.Equals(Guid.Empty))
    {
      this._command.Parameters.Add("@producerGuid", SqlDbType.UniqueIdentifier);
      this._command.Parameters["@producerGuid"].Value = (object) this._producerGuid;
    }
    if (this._policyTypeID != -1)
    {
      this._command.Parameters.Add("@policyTypeID", SqlDbType.Int);
      this._command.Parameters["@policyTypeID"].Value = (object) this._policyTypeID;
    }
    if (!this._CompanyGroupGuid.Equals(Guid.Empty))
    {
      this._command.Parameters.Add("@companyGroupGuid", SqlDbType.UniqueIdentifier);
      this._command.Parameters["@companyGroupGuid"].Value = (object) this._CompanyGroupGuid;
    }
    if (!this._companyGuid.Equals(Guid.Empty))
    {
      this._command.Parameters.Add("@companyGuid", SqlDbType.UniqueIdentifier);
      this._command.Parameters["@companyGuid"].Value = (object) this._companyGuid;
    }
    if (!this._companyLocationGuid.Equals(Guid.Empty))
    {
      this._command.Parameters.Add("@companyLocationGuid", SqlDbType.UniqueIdentifier);
      this._command.Parameters["@companyLocationGuid"].Value = (object) this._companyLocationGuid;
    }
    if (!this._officeGuid.Equals(Guid.Empty))
    {
      this._command.Parameters.Add("@officeGuid", SqlDbType.UniqueIdentifier);
      this._command.Parameters["@officeGuid"].Value = (object) this._officeGuid;
    }
    if (!this._lineGuid.Equals(Guid.Empty))
    {
      this._command.Parameters.Add("@lineGuid", SqlDbType.UniqueIdentifier);
      this._command.Parameters["@lineGuid"].Value = (object) this._lineGuid;
    }
    this._command.Parameters.Add("@ShowAllOffices", SqlDbType.Bit);
    this._command.Parameters["@ShowAllOffices"].Value = (object) this._showAllOffices;
    if (!string.IsNullOrEmpty(this._issuingOfficeIDs))
    {
      this._command.Parameters.Add("@IssuingOfficeIDs", SqlDbType.VarChar);
      this._command.Parameters["@IssuingOfficeIDs"].Value = (object) this._issuingOfficeIDs;
    }
    if (!this._ProducerLocationGuid.Equals(Guid.Empty))
    {
      this._command.Parameters.Add("@ProducerLocationGuid", SqlDbType.UniqueIdentifier);
      this._command.Parameters["@ProducerLocationGuid"].Value = (object) this._ProducerLocationGuid;
    }
    this._command.Parameters.Add("@CostCenterID", SqlDbType.Int);
    this._command.Parameters["@CostCenterID"].Value = (object) this._costCenter;
    if (SystemSettings.KeyExists("CheckQuotingOfficeGuid") && SystemSettings.GetBoolSetting("CheckQuotingOfficeGuid") && !this.CurrentUserGuid.Equals((object) string.Empty))
      this._command.Parameters.AddWithValue("@CurrentUserGuid", (object) this.CurrentUserGuid);
    this._da = new SqlDataAdapter(this._command);
    try
    {
      Database.SafeDataAdapterFill(this._da, this._dt);
    }
    finally
    {
      this._da.Dispose();
      this._command.Dispose();
      this._connection.Dispose();
    }
    if (this._dt == null || this._dt.Rows.Count <= 0)
      return;
    this._dt.Columns.Add("Month", typeof (string));
    this._dt.Columns.Add("MonthNumeric", typeof (string));
    try
    {
      foreach (DataRow row in this._dt.Rows)
      {
        row["Month"] = (object) Conversions.ToDate(row["InvoiceDate"]).ToString("MMMM");
        row["MonthNumeric"] = (object) Conversions.ToDate(row["InvoiceDate"]).ToString("MM");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._dv = new DataView(this._dt, "", this._SortBy, DataViewRowState.CurrentRows);
    this.DataSource = (object) this._dv;
  }

  private void InitializeComponent()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (rptProductionReport));
    this.Detail = new Detail();
    this.TextBox1 = new TextBox();
    this.TextBox2 = new TextBox();
    this.TextBox3 = new TextBox();
    this.TextBox4 = new TextBox();
    this.TextBox5 = new TextBox();
    this.TextBox7 = new TextBox();
    this.TextBox8 = new TextBox();
    this.TextBox9 = new TextBox();
    this.TextBox19 = new TextBox();
    this.TextBox20 = new TextBox();
    this.TextBox21 = new TextBox();
    this.txtQuoteControlNum = new TextBox();
    this.Producer1 = new TextBox();
    this.Insured1 = new TextBox();
    this.NetBilled1 = new TextBox();
    this.TextBox = new TextBox();
    this.TextBox6 = new TextBox();
    this.TextBox10 = new TextBox();
    this.TextBox14 = new TextBox();
    this.ReportHeader = new ReportHeader();
    this.Label1 = new Label();
    this.txtSubTitle = new TextBox();
    this.ReportFooter = new ReportFooter();
    this.PageHeader = new PageHeader();
    this.PageFooter = new PageFooter();
    this.ghTotal = new GroupHeader();
    this.gfTotal = new GroupFooter();
    this.TextBox31 = new TextBox();
    this.TextBox30 = new TextBox();
    this.Label21 = new Label();
    this.TextBox28 = new TextBox();
    this.TextBox27 = new TextBox();
    this.TextBox26 = new TextBox();
    this.txtTotalItems = new TextBox();
    this.NetBilled4 = new TextBox();
    this.TextBox32 = new TextBox();
    this.ghCriteria1 = new GroupHeader();
    this.lblCriteria1Title = new Label();
    this.gfCriteria1 = new GroupFooter();
    this.TextBox11 = new TextBox();
    this.TextBox12 = new TextBox();
    this.TextBox13 = new TextBox();
    this.Label12 = new Label();
    this.lblCriteria1FooterText = new Label();
    this.TextBox24 = new TextBox();
    this.TextBox25 = new TextBox();
    this.txtMonthItemCount = new TextBox();
    this.NetBilled3 = new TextBox();
    this.TextBox29 = new TextBox();
    this.ghCriteria2 = new GroupHeader();
    this.Label2 = new Label();
    this.Label3 = new Label();
    this.Label4 = new Label();
    this.Label5 = new Label();
    this.Label6 = new Label();
    this.Label8 = new Label();
    this.Label9 = new Label();
    this.Label10 = new Label();
    this.lblCriteria2Title = new Label();
    this.Label18 = new Label();
    this.Label19 = new Label();
    this.Label20 = new Label();
    this.Label22 = new Label();
    this.Label23 = new Label();
    this.Label24 = new Label();
    this.Label25 = new Label();
    this.Label = new Label();
    this.Label7 = new Label();
    this.Label11 = new Label();
    this.Label13 = new Label();
    this.gfCriteria2 = new GroupFooter();
    this.TextBox15 = new TextBox();
    this.TextBox16 = new TextBox();
    this.TextBox17 = new TextBox();
    this.Label16 = new Label();
    this.lblCriteria2FooterText = new Label();
    this.TextBox22 = new TextBox();
    this.TextBox23 = new TextBox();
    this.txtUnderWriterItemCount = new TextBox();
    this.NetBilled2 = new TextBox();
    this.TextBox18 = new TextBox();
    ((ISupportInitialize) this.TextBox1).BeginInit();
    ((ISupportInitialize) this.TextBox2).BeginInit();
    ((ISupportInitialize) this.TextBox3).BeginInit();
    ((ISupportInitialize) this.TextBox4).BeginInit();
    ((ISupportInitialize) this.TextBox5).BeginInit();
    ((ISupportInitialize) this.TextBox7).BeginInit();
    ((ISupportInitialize) this.TextBox8).BeginInit();
    ((ISupportInitialize) this.TextBox9).BeginInit();
    ((ISupportInitialize) this.TextBox19).BeginInit();
    ((ISupportInitialize) this.TextBox20).BeginInit();
    ((ISupportInitialize) this.TextBox21).BeginInit();
    ((ISupportInitialize) this.txtQuoteControlNum).BeginInit();
    ((ISupportInitialize) this.Producer1).BeginInit();
    ((ISupportInitialize) this.Insured1).BeginInit();
    ((ISupportInitialize) this.NetBilled1).BeginInit();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.TextBox6).BeginInit();
    ((ISupportInitialize) this.TextBox10).BeginInit();
    ((ISupportInitialize) this.TextBox14).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtSubTitle).BeginInit();
    ((ISupportInitialize) this.TextBox31).BeginInit();
    ((ISupportInitialize) this.TextBox30).BeginInit();
    ((ISupportInitialize) this.Label21).BeginInit();
    ((ISupportInitialize) this.TextBox28).BeginInit();
    ((ISupportInitialize) this.TextBox27).BeginInit();
    ((ISupportInitialize) this.TextBox26).BeginInit();
    ((ISupportInitialize) this.txtTotalItems).BeginInit();
    ((ISupportInitialize) this.NetBilled4).BeginInit();
    ((ISupportInitialize) this.TextBox32).BeginInit();
    ((ISupportInitialize) this.lblCriteria1Title).BeginInit();
    ((ISupportInitialize) this.TextBox11).BeginInit();
    ((ISupportInitialize) this.TextBox12).BeginInit();
    ((ISupportInitialize) this.TextBox13).BeginInit();
    ((ISupportInitialize) this.Label12).BeginInit();
    ((ISupportInitialize) this.lblCriteria1FooterText).BeginInit();
    ((ISupportInitialize) this.TextBox24).BeginInit();
    ((ISupportInitialize) this.TextBox25).BeginInit();
    ((ISupportInitialize) this.txtMonthItemCount).BeginInit();
    ((ISupportInitialize) this.NetBilled3).BeginInit();
    ((ISupportInitialize) this.TextBox29).BeginInit();
    ((ISupportInitialize) this.Label2).BeginInit();
    ((ISupportInitialize) this.Label3).BeginInit();
    ((ISupportInitialize) this.Label4).BeginInit();
    ((ISupportInitialize) this.Label5).BeginInit();
    ((ISupportInitialize) this.Label6).BeginInit();
    ((ISupportInitialize) this.Label8).BeginInit();
    ((ISupportInitialize) this.Label9).BeginInit();
    ((ISupportInitialize) this.Label10).BeginInit();
    ((ISupportInitialize) this.lblCriteria2Title).BeginInit();
    ((ISupportInitialize) this.Label18).BeginInit();
    ((ISupportInitialize) this.Label19).BeginInit();
    ((ISupportInitialize) this.Label20).BeginInit();
    ((ISupportInitialize) this.Label22).BeginInit();
    ((ISupportInitialize) this.Label23).BeginInit();
    ((ISupportInitialize) this.Label24).BeginInit();
    ((ISupportInitialize) this.Label25).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.Label7).BeginInit();
    ((ISupportInitialize) this.Label11).BeginInit();
    ((ISupportInitialize) this.Label13).BeginInit();
    ((ISupportInitialize) this.TextBox15).BeginInit();
    ((ISupportInitialize) this.TextBox16).BeginInit();
    ((ISupportInitialize) this.TextBox17).BeginInit();
    ((ISupportInitialize) this.Label16).BeginInit();
    ((ISupportInitialize) this.lblCriteria2FooterText).BeginInit();
    ((ISupportInitialize) this.TextBox22).BeginInit();
    ((ISupportInitialize) this.TextBox23).BeginInit();
    ((ISupportInitialize) this.txtUnderWriterItemCount).BeginInit();
    ((ISupportInitialize) this.NetBilled2).BeginInit();
    ((ISupportInitialize) this.TextBox18).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[19]
    {
      (ARControl) this.TextBox1,
      (ARControl) this.TextBox2,
      (ARControl) this.TextBox3,
      (ARControl) this.TextBox4,
      (ARControl) this.TextBox5,
      (ARControl) this.TextBox7,
      (ARControl) this.TextBox8,
      (ARControl) this.TextBox9,
      (ARControl) this.TextBox19,
      (ARControl) this.TextBox20,
      (ARControl) this.TextBox21,
      (ARControl) this.txtQuoteControlNum,
      (ARControl) this.Producer1,
      (ARControl) this.Insured1,
      (ARControl) this.NetBilled1,
      (ARControl) this.TextBox,
      (ARControl) this.TextBox6,
      (ARControl) this.TextBox10,
      (ARControl) this.TextBox14
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 3f / 16f;
    this.Detail.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Name = "Detail";
    ((ARControl) this.TextBox1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox1).DataField = "InvoiceDate";
    this.TextBox1.DistinctField = (string) null;
    this.TextBox1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox1 = this.TextBox1;
    object obj1 = componentResourceManager.GetObject("TextBox1.Location");
    PointF pointF1 = obj1 != null ? (PointF) obj1 : new PointF();
    ((ARControl) textBox1).Location = pointF1;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox1).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "EffectiveDate";
    this.TextBox2.DistinctField = (string) null;
    this.TextBox2.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox2 = this.TextBox2;
    object obj2 = componentResourceManager.GetObject("TextBox2.Location");
    PointF pointF2 = obj2 != null ? (PointF) obj2 : new PointF();
    ((ARControl) textBox2).Location = pointF2;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox2).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "ExpirationDate";
    this.TextBox3.DistinctField = (string) null;
    this.TextBox3.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox3 = this.TextBox3;
    object obj3 = componentResourceManager.GetObject("TextBox3.Location");
    PointF pointF3 = obj3 != null ? (PointF) obj3 : new PointF();
    ((ARControl) textBox3).Location = pointF3;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = "MM/dd/yyyy";
    ((ARControl) this.TextBox3).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "Insured";
    this.TextBox4.DistinctField = (string) null;
    this.TextBox4.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox4 = this.TextBox4;
    object obj4 = componentResourceManager.GetObject("TextBox4.Location");
    PointF pointF4 = obj4 != null ? (PointF) obj4 : new PointF();
    ((ARControl) textBox4).Location = pointF4;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.OutputFormat = (string) null;
    ((ARControl) this.TextBox4).Size = new SizeF(1f, 3f / 16f);
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "Producer";
    this.TextBox5.DistinctField = (string) null;
    this.TextBox5.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox5 = this.TextBox5;
    object obj5 = componentResourceManager.GetObject("TextBox5.Location");
    PointF pointF5 = obj5 != null ? (PointF) obj5 : new PointF();
    ((ARControl) textBox5).Location = pointF5;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.OutputFormat = (string) null;
    ((ARControl) this.TextBox5).Size = new SizeF(15f / 16f, 3f / 16f);
    this.TextBox5.Text = " ";
    this.TextBox7.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "Premium";
    this.TextBox7.DistinctField = (string) null;
    this.TextBox7.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox7 = this.TextBox7;
    object obj6 = componentResourceManager.GetObject("TextBox7.Location");
    PointF pointF6 = obj6 != null ? (PointF) obj6 : new PointF();
    ((ARControl) textBox7).Location = pointF6;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox7).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox7.Text = " ";
    this.TextBox8.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "NetBilled";
    this.TextBox8.DistinctField = (string) null;
    this.TextBox8.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox8 = this.TextBox8;
    object obj7 = componentResourceManager.GetObject("TextBox8.Location");
    PointF pointF7 = obj7 != null ? (PointF) obj7 : new PointF();
    ((ARControl) textBox8).Location = pointF7;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox8).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox8.Text = " ";
    this.TextBox9.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).DataField = "MGAComm";
    this.TextBox9.DistinctField = (string) null;
    this.TextBox9.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox9 = this.TextBox9;
    object obj8 = componentResourceManager.GetObject("TextBox9.Location");
    PointF pointF8 = obj8 != null ? (PointF) obj8 : new PointF();
    ((ARControl) textBox9).Location = pointF8;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox9).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox19).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).DataField = "PolicyType";
    this.TextBox19.DistinctField = (string) null;
    this.TextBox19.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox19 = this.TextBox19;
    object obj9 = componentResourceManager.GetObject("TextBox19.Location");
    PointF pointF9 = obj9 != null ? (PointF) obj9 : new PointF();
    ((ARControl) textBox19).Location = pointF9;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.OutputFormat = (string) null;
    ((ARControl) this.TextBox19).Size = new SizeF(0.625f, 3f / 16f);
    this.TextBox19.Text = " ";
    this.TextBox20.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox20).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).DataField = "AmountReceived";
    this.TextBox20.DistinctField = (string) null;
    this.TextBox20.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox20 = this.TextBox20;
    object obj10 = componentResourceManager.GetObject("TextBox20.Location");
    PointF pointF10 = obj10 != null ? (PointF) obj10 : new PointF();
    ((ARControl) textBox20).Location = pointF10;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox20).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox20.Text = (string) null;
    this.TextBox21.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox21).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).DataField = "AmountReceivedCommission";
    this.TextBox21.DistinctField = (string) null;
    this.TextBox21.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox21 = this.TextBox21;
    object obj11 = componentResourceManager.GetObject("TextBox21.Location");
    PointF pointF11 = obj11 != null ? (PointF) obj11 : new PointF();
    ((ARControl) textBox21).Location = pointF11;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox21).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox21.Text = (string) null;
    ((ARControl) this.txtQuoteControlNum).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).DataField = "QuoteControlNum";
    this.txtQuoteControlNum.DistinctField = (string) null;
    this.txtQuoteControlNum.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Underline, GraphicsUnit.Point, (byte) 0);
    this.txtQuoteControlNum.ForeColor = Color.Blue;
    TextBox txtQuoteControlNum = this.txtQuoteControlNum;
    object obj12 = componentResourceManager.GetObject("txtQuoteControlNum.Location");
    PointF pointF12 = obj12 != null ? (PointF) obj12 : new PointF();
    ((ARControl) txtQuoteControlNum).Location = pointF12;
    ((ARControl) this.txtQuoteControlNum).Name = "txtQuoteControlNum";
    this.txtQuoteControlNum.OutputFormat = (string) null;
    ((ARControl) this.txtQuoteControlNum).Size = new SizeF(7f / 16f, 3f / 16f);
    this.txtQuoteControlNum.Text = (string) null;
    ((ARControl) this.Producer1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).DataField = "Carrier";
    this.Producer1.DistinctField = (string) null;
    this.Producer1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox producer1 = this.Producer1;
    object obj13 = componentResourceManager.GetObject("Producer1.Location");
    PointF pointF13 = obj13 != null ? (PointF) obj13 : new PointF();
    ((ARControl) producer1).Location = pointF13;
    ((ARControl) this.Producer1).Name = "Producer1";
    this.Producer1.OutputFormat = (string) null;
    ((ARControl) this.Producer1).Size = new SizeF(0.875f, 3f / 16f);
    this.Producer1.Text = " ";
    ((ARControl) this.Insured1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).DataField = "PolicyNumber";
    this.Insured1.DistinctField = (string) null;
    this.Insured1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox insured1 = this.Insured1;
    object obj14 = componentResourceManager.GetObject("Insured1.Location");
    PointF pointF14 = obj14 != null ? (PointF) obj14 : new PointF();
    ((ARControl) insured1).Location = pointF14;
    ((ARControl) this.Insured1).Name = "Insured1";
    this.Insured1.OutputFormat = (string) null;
    ((ARControl) this.Insured1).Size = new SizeF(1f, 3f / 16f);
    this.Insured1.Text = " ";
    this.NetBilled1.Alignment = (TextAlignment) 2;
    ((ARControl) this.NetBilled1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).DataField = "RemitterCommission";
    this.NetBilled1.DistinctField = (string) null;
    this.NetBilled1.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox netBilled1 = this.NetBilled1;
    object obj15 = componentResourceManager.GetObject("NetBilled1.Location");
    PointF pointF15 = obj15 != null ? (PointF) obj15 : new PointF();
    ((ARControl) netBilled1).Location = pointF15;
    ((ARControl) this.NetBilled1).Name = "NetBilled1";
    this.NetBilled1.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.NetBilled1).Size = new SizeF(0.75f, 3f / 16f);
    this.NetBilled1.Text = " ";
    ((ARControl) this.TextBox).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "LineOfCoverage";
    this.TextBox.DistinctField = (string) null;
    this.TextBox.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox = this.TextBox;
    object obj16 = componentResourceManager.GetObject("TextBox.Location");
    PointF pointF16 = obj16 != null ? (PointF) obj16 : new PointF();
    ((ARControl) textBox).Location = pointF16;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.OutputFormat = (string) null;
    ((ARControl) this.TextBox).Size = new SizeF(9f / 16f, 3f / 16f);
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "RiskDescription";
    this.TextBox6.DistinctField = (string) null;
    this.TextBox6.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox6 = this.TextBox6;
    object obj17 = componentResourceManager.GetObject("TextBox6.Location");
    PointF pointF17 = obj17 != null ? (PointF) obj17 : new PointF();
    ((ARControl) textBox6).Location = pointF17;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.OutputFormat = (string) null;
    ((ARControl) this.TextBox6).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox10).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).DataField = "QuoteStatus";
    this.TextBox10.DistinctField = (string) null;
    this.TextBox10.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox10 = this.TextBox10;
    object obj18 = componentResourceManager.GetObject("TextBox10.Location");
    PointF pointF18 = obj18 != null ? (PointF) obj18 : new PointF();
    ((ARControl) textBox10).Location = pointF18;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.OutputFormat = (string) null;
    ((ARControl) this.TextBox10).Size = new SizeF(0.625f, 3f / 16f);
    this.TextBox10.Text = " ";
    this.TextBox14.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox14).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).DataField = "Fees";
    this.TextBox14.DistinctField = (string) null;
    this.TextBox14.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox14 = this.TextBox14;
    object obj19 = componentResourceManager.GetObject("TextBox14.Location");
    PointF pointF19 = obj19 != null ? (PointF) obj19 : new PointF();
    ((ARControl) textBox14).Location = pointF19;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox14).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox14.Text = " ";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label1,
      (ARControl) this.txtSubTitle
    });
    this.ReportHeader.Height = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    this.Label1.Alignment = (TextAlignment) 1;
    ((ARControl) this.Label1).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label1).Border.TopStyle = (BorderLineStyle) 0;
    this.Label1.Font = new Font("Arial", 14.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label1.HyperLink = (string) null;
    Label label1 = this.Label1;
    object obj20 = componentResourceManager.GetObject("Label1.Location");
    PointF pointF20 = obj20 != null ? (PointF) obj20 : new PointF();
    ((ARControl) label1).Location = pointF20;
    ((ARControl) this.Label1).Name = "Label1";
    ((ARControl) this.Label1).Size = new SizeF(217f / 16f, 0.25f);
    this.Label1.Text = "Production Report";
    this.txtSubTitle.Alignment = (TextAlignment) 1;
    ((ARControl) this.txtSubTitle).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTitle).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTitle).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtSubTitle).Border.TopStyle = (BorderLineStyle) 0;
    this.txtSubTitle.DistinctField = (string) null;
    this.txtSubTitle.Font = new Font("Arial", 10f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox txtSubTitle = this.txtSubTitle;
    object obj21 = componentResourceManager.GetObject("txtSubTitle.Location");
    PointF pointF21 = obj21 != null ? (PointF) obj21 : new PointF();
    ((ARControl) txtSubTitle).Location = pointF21;
    ((ARControl) this.txtSubTitle).Name = "txtSubTitle";
    this.txtSubTitle.OutputFormat = (string) null;
    ((ARControl) this.txtSubTitle).Size = new SizeF(217f / 16f, 3f / 16f);
    this.txtSubTitle.Text = (string) null;
    this.ReportFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter).Name = "ReportFooter";
    this.ReportFooter.PrintAtBottom = true;
    this.PageHeader.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader).Name = "PageHeader";
    this.PageFooter.Height = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter).Name = "PageFooter";
    this.ghTotal.Height = 0.25f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTotal).Name = "ghTotal";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotal).Controls.AddRange(new ARControl[9]
    {
      (ARControl) this.TextBox31,
      (ARControl) this.TextBox30,
      (ARControl) this.Label21,
      (ARControl) this.TextBox28,
      (ARControl) this.TextBox27,
      (ARControl) this.TextBox26,
      (ARControl) this.txtTotalItems,
      (ARControl) this.NetBilled4,
      (ARControl) this.TextBox32
    });
    this.gfTotal.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotal).Name = "gfTotal";
    this.TextBox31.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox31).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox31).DataField = "AmountReceivedCommission";
    this.TextBox31.DistinctField = (string) null;
    this.TextBox31.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox31 = this.TextBox31;
    object obj22 = componentResourceManager.GetObject("TextBox31.Location");
    PointF pointF22 = obj22 != null ? (PointF) obj22 : new PointF();
    ((ARControl) textBox31).Location = pointF22;
    ((ARControl) this.TextBox31).Name = "TextBox31";
    this.TextBox31.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox31).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox31.SummaryGroup = "ghTotal";
    this.TextBox31.SummaryRunning = (SummaryRunning) 2;
    this.TextBox31.SummaryType = (SummaryType) 1;
    this.TextBox31.Text = " ";
    this.TextBox30.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox30).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox30).DataField = "AmountReceived";
    this.TextBox30.DistinctField = (string) null;
    this.TextBox30.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox30 = this.TextBox30;
    object obj23 = componentResourceManager.GetObject("TextBox30.Location");
    PointF pointF23 = obj23 != null ? (PointF) obj23 : new PointF();
    ((ARControl) textBox30).Location = pointF23;
    ((ARControl) this.TextBox30).Name = "TextBox30";
    this.TextBox30.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox30).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox30.SummaryGroup = "ghTotal";
    this.TextBox30.SummaryRunning = (SummaryRunning) 2;
    this.TextBox30.SummaryType = (SummaryType) 1;
    this.TextBox30.Text = " ";
    ((ARControl) this.Label21).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label21).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label21).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label21).Border.TopStyle = (BorderLineStyle) 0;
    this.Label21.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label21.HyperLink = (string) null;
    Label label21 = this.Label21;
    object obj24 = componentResourceManager.GetObject("Label21.Location");
    PointF pointF24 = obj24 != null ? (PointF) obj24 : new PointF();
    ((ARControl) label21).Location = pointF24;
    ((ARControl) this.Label21).Name = "Label21";
    ((ARControl) this.Label21).Size = new SizeF(21f / 16f, 3f / 16f);
    this.Label21.Text = "Totals:";
    this.TextBox28.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox28).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox28).DataField = "MGAComm";
    this.TextBox28.DistinctField = (string) null;
    this.TextBox28.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox28 = this.TextBox28;
    object obj25 = componentResourceManager.GetObject("TextBox28.Location");
    PointF pointF25 = obj25 != null ? (PointF) obj25 : new PointF();
    ((ARControl) textBox28).Location = pointF25;
    ((ARControl) this.TextBox28).Name = "TextBox28";
    this.TextBox28.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox28).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox28.SummaryGroup = "ghTotal";
    this.TextBox28.SummaryRunning = (SummaryRunning) 2;
    this.TextBox28.SummaryType = (SummaryType) 1;
    this.TextBox28.Text = " ";
    this.TextBox27.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox27).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox27).DataField = "NetBilled";
    this.TextBox27.DistinctField = (string) null;
    this.TextBox27.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox27 = this.TextBox27;
    object obj26 = componentResourceManager.GetObject("TextBox27.Location");
    PointF pointF26 = obj26 != null ? (PointF) obj26 : new PointF();
    ((ARControl) textBox27).Location = pointF26;
    ((ARControl) this.TextBox27).Name = "TextBox27";
    this.TextBox27.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox27).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox27.SummaryGroup = "ghTotal";
    this.TextBox27.SummaryRunning = (SummaryRunning) 2;
    this.TextBox27.SummaryType = (SummaryType) 1;
    this.TextBox27.Text = " ";
    this.TextBox26.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox26).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox26).DataField = "Premium";
    this.TextBox26.DistinctField = (string) null;
    this.TextBox26.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox26 = this.TextBox26;
    object obj27 = componentResourceManager.GetObject("TextBox26.Location");
    PointF pointF27 = obj27 != null ? (PointF) obj27 : new PointF();
    ((ARControl) textBox26).Location = pointF27;
    ((ARControl) this.TextBox26).Name = "TextBox26";
    this.TextBox26.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox26).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox26.SummaryGroup = "ghTotal";
    this.TextBox26.SummaryRunning = (SummaryRunning) 2;
    this.TextBox26.SummaryType = (SummaryType) 1;
    this.TextBox26.Text = " ";
    ((ARControl) this.txtTotalItems).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalItems).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalItems).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtTotalItems).Border.TopStyle = (BorderLineStyle) 0;
    this.txtTotalItems.DistinctField = (string) null;
    this.txtTotalItems.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtTotalItems = this.txtTotalItems;
    object obj28 = componentResourceManager.GetObject("txtTotalItems.Location");
    PointF pointF28 = obj28 != null ? (PointF) obj28 : new PointF();
    ((ARControl) txtTotalItems).Location = pointF28;
    ((ARControl) this.txtTotalItems).Name = "txtTotalItems";
    this.txtTotalItems.OutputFormat = (string) null;
    ((ARControl) this.txtTotalItems).Size = new SizeF(1f, 3f / 16f);
    this.txtTotalItems.Text = (string) null;
    this.NetBilled4.Alignment = (TextAlignment) 2;
    ((ARControl) this.NetBilled4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled4).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled4).DataField = "RemitterCommission";
    this.NetBilled4.DistinctField = (string) null;
    this.NetBilled4.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox netBilled4 = this.NetBilled4;
    object obj29 = componentResourceManager.GetObject("NetBilled4.Location");
    PointF pointF29 = obj29 != null ? (PointF) obj29 : new PointF();
    ((ARControl) netBilled4).Location = pointF29;
    ((ARControl) this.NetBilled4).Name = "NetBilled4";
    this.NetBilled4.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.NetBilled4).Size = new SizeF(0.75f, 3f / 16f);
    this.NetBilled4.SummaryGroup = "ghTotal";
    this.NetBilled4.SummaryRunning = (SummaryRunning) 2;
    this.NetBilled4.SummaryType = (SummaryType) 1;
    this.NetBilled4.Text = " ";
    this.TextBox32.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox32).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox32).DataField = "Fees";
    this.TextBox32.DistinctField = (string) null;
    this.TextBox32.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox32 = this.TextBox32;
    object obj30 = componentResourceManager.GetObject("TextBox32.Location");
    PointF pointF30 = obj30 != null ? (PointF) obj30 : new PointF();
    ((ARControl) textBox32).Location = pointF30;
    ((ARControl) this.TextBox32).Name = "TextBox32";
    this.TextBox32.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox32).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox32.SummaryGroup = "ghTotal";
    this.TextBox32.SummaryRunning = (SummaryRunning) 2;
    this.TextBox32.SummaryType = (SummaryType) 1;
    this.TextBox32.Text = " ";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.lblCriteria1Title
    });
    this.ghCriteria1.Height = 7f / 16f;
    this.ghCriteria1.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria1).Name = "ghCriteria1";
    ((ARControl) this.lblCriteria1Title).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1Title).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1Title).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1Title).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCriteria1Title.Font = new Font("Arial", 14.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCriteria1Title.HyperLink = (string) null;
    Label lblCriteria1Title = this.lblCriteria1Title;
    object obj31 = componentResourceManager.GetObject("lblCriteria1Title.Location");
    PointF pointF31 = obj31 != null ? (PointF) obj31 : new PointF();
    ((ARControl) lblCriteria1Title).Location = pointF31;
    ((ARControl) this.lblCriteria1Title).Name = "lblCriteria1Title";
    ((ARControl) this.lblCriteria1Title).Size = new SizeF(217f / 16f, 0.25f);
    this.lblCriteria1Title.Text = "";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria1).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.TextBox11,
      (ARControl) this.TextBox12,
      (ARControl) this.TextBox13,
      (ARControl) this.Label12,
      (ARControl) this.lblCriteria1FooterText,
      (ARControl) this.TextBox24,
      (ARControl) this.TextBox25,
      (ARControl) this.txtMonthItemCount,
      (ARControl) this.NetBilled3,
      (ARControl) this.TextBox29
    });
    this.gfCriteria1.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria1).Name = "gfCriteria1";
    this.gfCriteria1.NewPage = (NewPage) 2;
    this.TextBox11.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox11).DataField = "Premium";
    this.TextBox11.DistinctField = (string) null;
    this.TextBox11.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox11 = this.TextBox11;
    object obj32 = componentResourceManager.GetObject("TextBox11.Location");
    PointF pointF32 = obj32 != null ? (PointF) obj32 : new PointF();
    ((ARControl) textBox11).Location = pointF32;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox11).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox11.SummaryGroup = "ghCriteria1";
    this.TextBox11.SummaryRunning = (SummaryRunning) 1;
    this.TextBox11.SummaryType = (SummaryType) 3;
    this.TextBox11.Text = " ";
    this.TextBox12.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox12).DataField = "NetBilled";
    this.TextBox12.DistinctField = (string) null;
    this.TextBox12.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox12 = this.TextBox12;
    object obj33 = componentResourceManager.GetObject("TextBox12.Location");
    PointF pointF33 = obj33 != null ? (PointF) obj33 : new PointF();
    ((ARControl) textBox12).Location = pointF33;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox12).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox12.SummaryGroup = "ghCriteria1";
    this.TextBox12.SummaryRunning = (SummaryRunning) 1;
    this.TextBox12.SummaryType = (SummaryType) 3;
    this.TextBox12.Text = " ";
    this.TextBox13.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox13).DataField = "MGAComm";
    this.TextBox13.DistinctField = (string) null;
    this.TextBox13.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox13 = this.TextBox13;
    object obj34 = componentResourceManager.GetObject("TextBox13.Location");
    PointF pointF34 = obj34 != null ? (PointF) obj34 : new PointF();
    ((ARControl) textBox13).Location = pointF34;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox13).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox13.SummaryGroup = "ghCriteria1";
    this.TextBox13.SummaryRunning = (SummaryRunning) 1;
    this.TextBox13.SummaryType = (SummaryType) 3;
    this.TextBox13.Text = " ";
    ((ARControl) this.Label12).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label12).Border.TopStyle = (BorderLineStyle) 0;
    this.Label12.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label12.HyperLink = (string) null;
    Label label12 = this.Label12;
    object obj35 = componentResourceManager.GetObject("Label12.Location");
    PointF pointF35 = obj35 != null ? (PointF) obj35 : new PointF();
    ((ARControl) label12).Location = pointF35;
    ((ARControl) this.Label12).Name = "Label12";
    ((ARControl) this.Label12).Size = new SizeF(21f / 16f, 3f / 16f);
    this.Label12.Text = "Totals:";
    this.lblCriteria1FooterText.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblCriteria1FooterText).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1FooterText).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1FooterText).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria1FooterText).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCriteria1FooterText.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCriteria1FooterText.HyperLink = (string) null;
    Label criteria1FooterText = this.lblCriteria1FooterText;
    object obj36 = componentResourceManager.GetObject("lblCriteria1FooterText.Location");
    PointF pointF36 = obj36 != null ? (PointF) obj36 : new PointF();
    ((ARControl) criteria1FooterText).Location = pointF36;
    ((ARControl) this.lblCriteria1FooterText).Name = "lblCriteria1FooterText";
    ((ARControl) this.lblCriteria1FooterText).Size = new SizeF(6.125f, 3f / 16f);
    this.lblCriteria1FooterText.Text = "";
    this.TextBox24.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox24).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox24).DataField = "AmountReceived";
    this.TextBox24.DistinctField = (string) null;
    this.TextBox24.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox24 = this.TextBox24;
    object obj37 = componentResourceManager.GetObject("TextBox24.Location");
    PointF pointF37 = obj37 != null ? (PointF) obj37 : new PointF();
    ((ARControl) textBox24).Location = pointF37;
    ((ARControl) this.TextBox24).Name = "TextBox24";
    this.TextBox24.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox24).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox24.SummaryGroup = "ghCriteria1";
    this.TextBox24.SummaryRunning = (SummaryRunning) 1;
    this.TextBox24.SummaryType = (SummaryType) 3;
    this.TextBox24.Text = " ";
    this.TextBox25.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox25).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox25).DataField = "AmountReceivedCommission";
    this.TextBox25.DistinctField = (string) null;
    this.TextBox25.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox25 = this.TextBox25;
    object obj38 = componentResourceManager.GetObject("TextBox25.Location");
    PointF pointF38 = obj38 != null ? (PointF) obj38 : new PointF();
    ((ARControl) textBox25).Location = pointF38;
    ((ARControl) this.TextBox25).Name = "TextBox25";
    this.TextBox25.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox25).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox25.SummaryGroup = "ghCriteria1";
    this.TextBox25.SummaryRunning = (SummaryRunning) 1;
    this.TextBox25.SummaryType = (SummaryType) 3;
    this.TextBox25.Text = " ";
    ((ARControl) this.txtMonthItemCount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMonthItemCount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMonthItemCount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtMonthItemCount).Border.TopStyle = (BorderLineStyle) 0;
    this.txtMonthItemCount.DistinctField = (string) null;
    this.txtMonthItemCount.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox txtMonthItemCount = this.txtMonthItemCount;
    object obj39 = componentResourceManager.GetObject("txtMonthItemCount.Location");
    PointF pointF39 = obj39 != null ? (PointF) obj39 : new PointF();
    ((ARControl) txtMonthItemCount).Location = pointF39;
    ((ARControl) this.txtMonthItemCount).Name = "txtMonthItemCount";
    this.txtMonthItemCount.OutputFormat = (string) null;
    ((ARControl) this.txtMonthItemCount).Size = new SizeF(1f, 3f / 16f);
    this.txtMonthItemCount.Text = (string) null;
    this.NetBilled3.Alignment = (TextAlignment) 2;
    ((ARControl) this.NetBilled3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled3).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled3).DataField = "RemitterCommission";
    this.NetBilled3.DistinctField = (string) null;
    this.NetBilled3.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox netBilled3 = this.NetBilled3;
    object obj40 = componentResourceManager.GetObject("NetBilled3.Location");
    PointF pointF40 = obj40 != null ? (PointF) obj40 : new PointF();
    ((ARControl) netBilled3).Location = pointF40;
    ((ARControl) this.NetBilled3).Name = "NetBilled3";
    this.NetBilled3.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.NetBilled3).Size = new SizeF(0.75f, 3f / 16f);
    this.NetBilled3.SummaryGroup = "ghCriteria1";
    this.NetBilled3.SummaryRunning = (SummaryRunning) 1;
    this.NetBilled3.SummaryType = (SummaryType) 3;
    this.NetBilled3.Text = " ";
    this.TextBox29.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox29).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox29).DataField = "Fees";
    this.TextBox29.DistinctField = (string) null;
    this.TextBox29.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox29 = this.TextBox29;
    object obj41 = componentResourceManager.GetObject("TextBox29.Location");
    PointF pointF41 = obj41 != null ? (PointF) obj41 : new PointF();
    ((ARControl) textBox29).Location = pointF41;
    ((ARControl) this.TextBox29).Name = "TextBox29";
    this.TextBox29.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox29).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox29.SummaryGroup = "ghCriteria1";
    this.TextBox29.SummaryRunning = (SummaryRunning) 1;
    this.TextBox29.SummaryType = (SummaryType) 3;
    this.TextBox29.Text = " ";
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria2).Controls.AddRange(new ARControl[20]
    {
      (ARControl) this.Label2,
      (ARControl) this.Label3,
      (ARControl) this.Label4,
      (ARControl) this.Label5,
      (ARControl) this.Label6,
      (ARControl) this.Label8,
      (ARControl) this.Label9,
      (ARControl) this.Label10,
      (ARControl) this.lblCriteria2Title,
      (ARControl) this.Label18,
      (ARControl) this.Label19,
      (ARControl) this.Label20,
      (ARControl) this.Label22,
      (ARControl) this.Label23,
      (ARControl) this.Label24,
      (ARControl) this.Label25,
      (ARControl) this.Label,
      (ARControl) this.Label7,
      (ARControl) this.Label11,
      (ARControl) this.Label13
    });
    this.ghCriteria2.Height = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria2).Name = "ghCriteria2";
    ((ARControl) this.Label2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label2).Border.TopStyle = (BorderLineStyle) 0;
    this.Label2.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label2.HyperLink = (string) null;
    Label label2 = this.Label2;
    object obj42 = componentResourceManager.GetObject("Label2.Location");
    PointF pointF42 = obj42 != null ? (PointF) obj42 : new PointF();
    ((ARControl) label2).Location = pointF42;
    ((ARControl) this.Label2).Name = "Label2";
    ((ARControl) this.Label2).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label2.Text = "Date Billed";
    this.Label2.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label3).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label3).Border.TopStyle = (BorderLineStyle) 0;
    this.Label3.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.HyperLink = (string) null;
    Label label3 = this.Label3;
    object obj43 = componentResourceManager.GetObject("Label3.Location");
    PointF pointF43 = obj43 != null ? (PointF) obj43 : new PointF();
    ((ARControl) label3).Location = pointF43;
    ((ARControl) this.Label3).Name = "Label3";
    ((ARControl) this.Label3).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label3.Text = "Effective";
    this.Label3.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label4).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label4).Border.TopStyle = (BorderLineStyle) 0;
    this.Label4.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.HyperLink = (string) null;
    Label label4 = this.Label4;
    object obj44 = componentResourceManager.GetObject("Label4.Location");
    PointF pointF44 = obj44 != null ? (PointF) obj44 : new PointF();
    ((ARControl) label4).Location = pointF44;
    ((ARControl) this.Label4).Name = "Label4";
    ((ARControl) this.Label4).Size = new SizeF(9f / 16f, 3f / 16f);
    this.Label4.Text = "Expiration";
    this.Label4.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label5).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label5).Border.TopStyle = (BorderLineStyle) 0;
    this.Label5.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label5.HyperLink = (string) null;
    Label label5 = this.Label5;
    object obj45 = componentResourceManager.GetObject("Label5.Location");
    PointF pointF45 = obj45 != null ? (PointF) obj45 : new PointF();
    ((ARControl) label5).Location = pointF45;
    ((ARControl) this.Label5).Name = "Label5";
    ((ARControl) this.Label5).Size = new SizeF(1f, 3f / 16f);
    this.Label5.Text = "Insured";
    this.Label5.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label6).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label6).Border.TopStyle = (BorderLineStyle) 0;
    this.Label6.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.HyperLink = (string) null;
    Label label6 = this.Label6;
    object obj46 = componentResourceManager.GetObject("Label6.Location");
    PointF pointF46 = obj46 != null ? (PointF) obj46 : new PointF();
    ((ARControl) label6).Location = pointF46;
    ((ARControl) this.Label6).Name = "Label6";
    ((ARControl) this.Label6).Size = new SizeF(15f / 16f, 3f / 16f);
    this.Label6.Text = "Producer";
    this.Label6.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label8.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label8).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label8).Border.TopStyle = (BorderLineStyle) 0;
    this.Label8.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label8.HyperLink = (string) null;
    Label label8 = this.Label8;
    object obj47 = componentResourceManager.GetObject("Label8.Location");
    PointF pointF47 = obj47 != null ? (PointF) obj47 : new PointF();
    ((ARControl) label8).Location = pointF47;
    ((ARControl) this.Label8).Name = "Label8";
    ((ARControl) this.Label8).Size = new SizeF(0.75f, 3f / 16f);
    this.Label8.Text = "Premium";
    this.Label8.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label9.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label9).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label9).Border.TopStyle = (BorderLineStyle) 0;
    this.Label9.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.HyperLink = (string) null;
    Label label9 = this.Label9;
    object obj48 = componentResourceManager.GetObject("Label9.Location");
    PointF pointF48 = obj48 != null ? (PointF) obj48 : new PointF();
    ((ARControl) label9).Location = pointF48;
    ((ARControl) this.Label9).Name = "Label9";
    ((ARControl) this.Label9).Size = new SizeF(0.75f, 3f / 16f);
    this.Label9.Text = "Net Billed";
    this.Label9.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label10.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label10).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label10).Border.TopStyle = (BorderLineStyle) 0;
    this.Label10.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.HyperLink = (string) null;
    Label label10 = this.Label10;
    object obj49 = componentResourceManager.GetObject("Label10.Location");
    PointF pointF49 = obj49 != null ? (PointF) obj49 : new PointF();
    ((ARControl) label10).Location = pointF49;
    ((ARControl) this.Label10).Name = "Label10";
    ((ARControl) this.Label10).Size = new SizeF(0.75f, 3f / 16f);
    this.Label10.Text = "MGA Comm";
    this.Label10.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.lblCriteria2Title).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2Title).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2Title).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2Title).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCriteria2Title.Font = new Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCriteria2Title.HyperLink = (string) null;
    Label lblCriteria2Title = this.lblCriteria2Title;
    object obj50 = componentResourceManager.GetObject("lblCriteria2Title.Location");
    PointF pointF50 = obj50 != null ? (PointF) obj50 : new PointF();
    ((ARControl) lblCriteria2Title).Location = pointF50;
    ((ARControl) this.lblCriteria2Title).Name = "lblCriteria2Title";
    ((ARControl) this.lblCriteria2Title).Size = new SizeF(217f / 16f, 3f / 16f);
    this.lblCriteria2Title.Text = "";
    ((ARControl) this.Label18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label18).Border.TopStyle = (BorderLineStyle) 0;
    this.Label18.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label18.HyperLink = (string) null;
    Label label18 = this.Label18;
    object obj51 = componentResourceManager.GetObject("Label18.Location");
    PointF pointF51 = obj51 != null ? (PointF) obj51 : new PointF();
    ((ARControl) label18).Location = pointF51;
    ((ARControl) this.Label18).Name = "Label18";
    ((ARControl) this.Label18).Size = new SizeF(0.625f, 3f / 16f);
    this.Label18.Text = "Policy Type";
    this.Label18.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label19.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label19).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label19).Border.TopStyle = (BorderLineStyle) 0;
    this.Label19.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label19.HyperLink = (string) null;
    Label label19 = this.Label19;
    object obj52 = componentResourceManager.GetObject("Label19.Location");
    PointF pointF52 = obj52 != null ? (PointF) obj52 : new PointF();
    ((ARControl) label19).Location = pointF52;
    ((ARControl) this.Label19).Name = "Label19";
    ((ARControl) this.Label19).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label19.Text = "Recvd";
    this.Label19.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label20.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label20).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label20).Border.TopStyle = (BorderLineStyle) 0;
    this.Label20.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label20.HyperLink = (string) null;
    Label label20 = this.Label20;
    object obj53 = componentResourceManager.GetObject("Label20.Location");
    PointF pointF53 = obj53 != null ? (PointF) obj53 : new PointF();
    ((ARControl) label20).Location = pointF53;
    ((ARControl) this.Label20).Name = "Label20";
    ((ARControl) this.Label20).Size = new SizeF(11f / 16f, 3f / 16f);
    this.Label20.Text = "Recvd Comm";
    this.Label20.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label22).Border.TopStyle = (BorderLineStyle) 0;
    this.Label22.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label22.HyperLink = (string) null;
    Label label22 = this.Label22;
    object obj54 = componentResourceManager.GetObject("Label22.Location");
    PointF pointF54 = obj54 != null ? (PointF) obj54 : new PointF();
    ((ARControl) label22).Location = pointF54;
    ((ARControl) this.Label22).Name = "Label22";
    ((ARControl) this.Label22).Size = new SizeF(7f / 16f, 0.25f);
    this.Label22.Text = "Control No";
    this.Label22.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label23).Border.TopStyle = (BorderLineStyle) 0;
    this.Label23.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label23.HyperLink = (string) null;
    Label label23 = this.Label23;
    object obj55 = componentResourceManager.GetObject("Label23.Location");
    PointF pointF55 = obj55 != null ? (PointF) obj55 : new PointF();
    ((ARControl) label23).Location = pointF55;
    ((ARControl) this.Label23).Name = "Label23";
    ((ARControl) this.Label23).Size = new SizeF(0.875f, 3f / 16f);
    this.Label23.Text = "Carrier";
    this.Label23.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label24).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label24).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label24).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label24).Border.TopStyle = (BorderLineStyle) 0;
    this.Label24.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label24.HyperLink = (string) null;
    Label label24 = this.Label24;
    object obj56 = componentResourceManager.GetObject("Label24.Location");
    PointF pointF56 = obj56 != null ? (PointF) obj56 : new PointF();
    ((ARControl) label24).Location = pointF56;
    ((ARControl) this.Label24).Name = "Label24";
    ((ARControl) this.Label24).Size = new SizeF(1f, 3f / 16f);
    this.Label24.Text = "Policy";
    this.Label24.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label25.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label25).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label25).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label25).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label25).Border.TopStyle = (BorderLineStyle) 0;
    this.Label25.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label25.HyperLink = (string) null;
    Label label25 = this.Label25;
    object obj57 = componentResourceManager.GetObject("Label25.Location");
    PointF pointF57 = obj57 != null ? (PointF) obj57 : new PointF();
    ((ARControl) label25).Location = pointF57;
    ((ARControl) this.Label25).Name = "Label25";
    ((ARControl) this.Label25).Size = new SizeF(0.75f, 3f / 16f);
    this.Label25.Text = "Remitter Comm";
    this.Label25.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label).Border.TopStyle = (BorderLineStyle) 0;
    this.Label.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label.HyperLink = (string) null;
    Label label = this.Label;
    object obj58 = componentResourceManager.GetObject("Label.Location");
    PointF pointF58 = obj58 != null ? (PointF) obj58 : new PointF();
    ((ARControl) label).Location = pointF58;
    ((ARControl) this.Label).Name = "Label";
    ((ARControl) this.Label).Size = new SizeF(9f / 16f, 0.25f);
    this.Label.Text = "Line Of Coverage";
    this.Label.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label7).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label7).Border.TopStyle = (BorderLineStyle) 0;
    this.Label7.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label7.HyperLink = (string) null;
    Label label7 = this.Label7;
    object obj59 = componentResourceManager.GetObject("Label7.Location");
    PointF pointF59 = obj59 != null ? (PointF) obj59 : new PointF();
    ((ARControl) label7).Location = pointF59;
    ((ARControl) this.Label7).Name = "Label7";
    ((ARControl) this.Label7).Size = new SizeF(11f / 16f, 0.25f);
    this.Label7.Text = "Risk Description";
    this.Label7.VerticalAlignment = (VerticalTextAlignment) 2;
    ((ARControl) this.Label11).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label11).Border.TopStyle = (BorderLineStyle) 0;
    this.Label11.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label11.HyperLink = (string) null;
    Label label11 = this.Label11;
    object obj60 = componentResourceManager.GetObject("Label11.Location");
    PointF pointF60 = obj60 != null ? (PointF) obj60 : new PointF();
    ((ARControl) label11).Location = pointF60;
    ((ARControl) this.Label11).Name = "Label11";
    ((ARControl) this.Label11).Size = new SizeF(0.625f, 3f / 16f);
    this.Label11.Text = "Status";
    this.Label11.VerticalAlignment = (VerticalTextAlignment) 2;
    this.Label13.Alignment = (TextAlignment) 2;
    ((ARControl) this.Label13).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label13).Border.TopStyle = (BorderLineStyle) 0;
    this.Label13.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label13.HyperLink = (string) null;
    Label label13 = this.Label13;
    object obj61 = componentResourceManager.GetObject("Label13.Location");
    PointF pointF61 = obj61 != null ? (PointF) obj61 : new PointF();
    ((ARControl) label13).Location = pointF61;
    ((ARControl) this.Label13).Name = "Label13";
    ((ARControl) this.Label13).Size = new SizeF(0.75f, 3f / 16f);
    this.Label13.Text = "Fees";
    this.Label13.VerticalAlignment = (VerticalTextAlignment) 2;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria2).Controls.AddRange(new ARControl[10]
    {
      (ARControl) this.TextBox15,
      (ARControl) this.TextBox16,
      (ARControl) this.TextBox17,
      (ARControl) this.Label16,
      (ARControl) this.lblCriteria2FooterText,
      (ARControl) this.TextBox22,
      (ARControl) this.TextBox23,
      (ARControl) this.txtUnderWriterItemCount,
      (ARControl) this.NetBilled2,
      (ARControl) this.TextBox18
    });
    this.gfCriteria2.Height = 3f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria2).Name = "gfCriteria2";
    this.TextBox15.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox15).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox15).DataField = "Premium";
    this.TextBox15.DistinctField = (string) null;
    this.TextBox15.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox15 = this.TextBox15;
    object obj62 = componentResourceManager.GetObject("TextBox15.Location");
    PointF pointF62 = obj62 != null ? (PointF) obj62 : new PointF();
    ((ARControl) textBox15).Location = pointF62;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox15).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox15.SummaryGroup = "ghCriteria2";
    this.TextBox15.SummaryRunning = (SummaryRunning) 1;
    this.TextBox15.SummaryType = (SummaryType) 3;
    this.TextBox15.Text = " ";
    this.TextBox16.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox16).DataField = "NetBilled";
    this.TextBox16.DistinctField = (string) null;
    this.TextBox16.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox16 = this.TextBox16;
    object obj63 = componentResourceManager.GetObject("TextBox16.Location");
    PointF pointF63 = obj63 != null ? (PointF) obj63 : new PointF();
    ((ARControl) textBox16).Location = pointF63;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox16).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox16.SummaryGroup = "ghCriteria2";
    this.TextBox16.SummaryRunning = (SummaryRunning) 1;
    this.TextBox16.SummaryType = (SummaryType) 3;
    this.TextBox16.Text = " ";
    this.TextBox17.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox17).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox17).DataField = "MGAComm";
    this.TextBox17.DistinctField = (string) null;
    this.TextBox17.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox17 = this.TextBox17;
    object obj64 = componentResourceManager.GetObject("TextBox17.Location");
    PointF pointF64 = obj64 != null ? (PointF) obj64 : new PointF();
    ((ARControl) textBox17).Location = pointF64;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox17).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox17.SummaryGroup = "ghCriteria2";
    this.TextBox17.SummaryRunning = (SummaryRunning) 1;
    this.TextBox17.SummaryType = (SummaryType) 3;
    this.TextBox17.Text = " ";
    ((ARControl) this.Label16).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.Label16).Border.TopStyle = (BorderLineStyle) 0;
    this.Label16.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold);
    this.Label16.HyperLink = (string) null;
    Label label16 = this.Label16;
    object obj65 = componentResourceManager.GetObject("Label16.Location");
    PointF pointF65 = obj65 != null ? (PointF) obj65 : new PointF();
    ((ARControl) label16).Location = pointF65;
    ((ARControl) this.Label16).Name = "Label16";
    ((ARControl) this.Label16).Size = new SizeF(21f / 16f, 3f / 16f);
    this.Label16.Text = "Totals:";
    this.lblCriteria2FooterText.Alignment = (TextAlignment) 2;
    ((ARControl) this.lblCriteria2FooterText).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2FooterText).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2FooterText).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.lblCriteria2FooterText).Border.TopStyle = (BorderLineStyle) 0;
    this.lblCriteria2FooterText.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold);
    this.lblCriteria2FooterText.HyperLink = (string) null;
    Label criteria2FooterText = this.lblCriteria2FooterText;
    object obj66 = componentResourceManager.GetObject("lblCriteria2FooterText.Location");
    PointF pointF66 = obj66 != null ? (PointF) obj66 : new PointF();
    ((ARControl) criteria2FooterText).Location = pointF66;
    ((ARControl) this.lblCriteria2FooterText).Name = "lblCriteria2FooterText";
    ((ARControl) this.lblCriteria2FooterText).Size = new SizeF(6.125f, 3f / 16f);
    this.lblCriteria2FooterText.Text = "";
    this.TextBox22.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox22).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox22).DataField = "AmountReceived";
    this.TextBox22.DistinctField = (string) null;
    this.TextBox22.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox22 = this.TextBox22;
    object obj67 = componentResourceManager.GetObject("TextBox22.Location");
    PointF pointF67 = obj67 != null ? (PointF) obj67 : new PointF();
    ((ARControl) textBox22).Location = pointF67;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox22).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox22.SummaryGroup = "ghCriteria2";
    this.TextBox22.SummaryRunning = (SummaryRunning) 1;
    this.TextBox22.SummaryType = (SummaryType) 3;
    this.TextBox22.Text = " ";
    this.TextBox23.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox23).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox23).DataField = "AmountReceivedCommission";
    this.TextBox23.DistinctField = (string) null;
    this.TextBox23.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox23 = this.TextBox23;
    object obj68 = componentResourceManager.GetObject("TextBox23.Location");
    PointF pointF68 = obj68 != null ? (PointF) obj68 : new PointF();
    ((ARControl) textBox23).Location = pointF68;
    ((ARControl) this.TextBox23).Name = "TextBox23";
    this.TextBox23.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox23).Size = new SizeF(11f / 16f, 3f / 16f);
    this.TextBox23.SummaryGroup = "ghCriteria2";
    this.TextBox23.SummaryRunning = (SummaryRunning) 1;
    this.TextBox23.SummaryType = (SummaryType) 3;
    this.TextBox23.Text = " ";
    ((ARControl) this.txtUnderWriterItemCount).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderWriterItemCount).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderWriterItemCount).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.txtUnderWriterItemCount).Border.TopStyle = (BorderLineStyle) 0;
    this.txtUnderWriterItemCount.DistinctField = (string) null;
    this.txtUnderWriterItemCount.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    TextBox underWriterItemCount = this.txtUnderWriterItemCount;
    object obj69 = componentResourceManager.GetObject("txtUnderWriterItemCount.Location");
    PointF pointF69 = obj69 != null ? (PointF) obj69 : new PointF();
    ((ARControl) underWriterItemCount).Location = pointF69;
    ((ARControl) this.txtUnderWriterItemCount).Name = "txtUnderWriterItemCount";
    this.txtUnderWriterItemCount.OutputFormat = (string) null;
    ((ARControl) this.txtUnderWriterItemCount).Size = new SizeF(1f, 3f / 16f);
    this.txtUnderWriterItemCount.Text = (string) null;
    this.NetBilled2.Alignment = (TextAlignment) 2;
    ((ARControl) this.NetBilled2).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled2).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled2).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled2).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.NetBilled2).DataField = "RemitterCommission";
    this.NetBilled2.DistinctField = (string) null;
    this.NetBilled2.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox netBilled2 = this.NetBilled2;
    object obj70 = componentResourceManager.GetObject("NetBilled2.Location");
    PointF pointF70 = obj70 != null ? (PointF) obj70 : new PointF();
    ((ARControl) netBilled2).Location = pointF70;
    ((ARControl) this.NetBilled2).Name = "NetBilled2";
    this.NetBilled2.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.NetBilled2).Size = new SizeF(0.75f, 3f / 16f);
    this.NetBilled2.SummaryGroup = "ghCriteria2";
    this.NetBilled2.SummaryRunning = (SummaryRunning) 1;
    this.NetBilled2.SummaryType = (SummaryType) 3;
    this.NetBilled2.Text = " ";
    this.TextBox18.Alignment = (TextAlignment) 2;
    ((ARControl) this.TextBox18).Border.BottomStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.LeftStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.RightStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).Border.TopStyle = (BorderLineStyle) 0;
    ((ARControl) this.TextBox18).DataField = "Fees";
    this.TextBox18.DistinctField = (string) null;
    this.TextBox18.Font = new Font("Arial", 6.75f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    TextBox textBox18 = this.TextBox18;
    object obj71 = componentResourceManager.GetObject("TextBox18.Location");
    PointF pointF71 = obj71 != null ? (PointF) obj71 : new PointF();
    ((ARControl) textBox18).Location = pointF71;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = "#,##0.00;(#,##0.00)";
    ((ARControl) this.TextBox18).Size = new SizeF(0.75f, 3f / 16f);
    this.TextBox18.SummaryGroup = "ghCriteria2";
    this.TextBox18.SummaryRunning = (SummaryRunning) 1;
    this.TextBox18.SummaryType = (SummaryType) 3;
    this.TextBox18.Text = " ";
    this.PageSettings.DefaultPaperSize = false;
    this.PageSettings.Margins.Bottom = 0.2f;
    this.PageSettings.Margins.Left = 0.25f;
    this.PageSettings.Margins.Right = 0.1f;
    this.PageSettings.Margins.Top = 0.2f;
    this.PageSettings.Orientation = (PageOrientation) 2;
    this.PageSettings.PaperHeight = 14f;
    this.PageSettings.PaperKind = PaperKind.Legal;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 13.6f;
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageHeader);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghTotal);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria2);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfCriteria1);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.gfTotal);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.PageFooter);
    this.Sections.Add((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportFooter);
    ((ISupportInitialize) this.TextBox1).EndInit();
    ((ISupportInitialize) this.TextBox2).EndInit();
    ((ISupportInitialize) this.TextBox3).EndInit();
    ((ISupportInitialize) this.TextBox4).EndInit();
    ((ISupportInitialize) this.TextBox5).EndInit();
    ((ISupportInitialize) this.TextBox7).EndInit();
    ((ISupportInitialize) this.TextBox8).EndInit();
    ((ISupportInitialize) this.TextBox9).EndInit();
    ((ISupportInitialize) this.TextBox19).EndInit();
    ((ISupportInitialize) this.TextBox20).EndInit();
    ((ISupportInitialize) this.TextBox21).EndInit();
    ((ISupportInitialize) this.txtQuoteControlNum).EndInit();
    ((ISupportInitialize) this.Producer1).EndInit();
    ((ISupportInitialize) this.Insured1).EndInit();
    ((ISupportInitialize) this.NetBilled1).EndInit();
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.TextBox6).EndInit();
    ((ISupportInitialize) this.TextBox10).EndInit();
    ((ISupportInitialize) this.TextBox14).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtSubTitle).EndInit();
    ((ISupportInitialize) this.TextBox31).EndInit();
    ((ISupportInitialize) this.TextBox30).EndInit();
    ((ISupportInitialize) this.Label21).EndInit();
    ((ISupportInitialize) this.TextBox28).EndInit();
    ((ISupportInitialize) this.TextBox27).EndInit();
    ((ISupportInitialize) this.TextBox26).EndInit();
    ((ISupportInitialize) this.txtTotalItems).EndInit();
    ((ISupportInitialize) this.NetBilled4).EndInit();
    ((ISupportInitialize) this.TextBox32).EndInit();
    ((ISupportInitialize) this.lblCriteria1Title).EndInit();
    ((ISupportInitialize) this.TextBox11).EndInit();
    ((ISupportInitialize) this.TextBox12).EndInit();
    ((ISupportInitialize) this.TextBox13).EndInit();
    ((ISupportInitialize) this.Label12).EndInit();
    ((ISupportInitialize) this.lblCriteria1FooterText).EndInit();
    ((ISupportInitialize) this.TextBox24).EndInit();
    ((ISupportInitialize) this.TextBox25).EndInit();
    ((ISupportInitialize) this.txtMonthItemCount).EndInit();
    ((ISupportInitialize) this.NetBilled3).EndInit();
    ((ISupportInitialize) this.TextBox29).EndInit();
    ((ISupportInitialize) this.Label2).EndInit();
    ((ISupportInitialize) this.Label3).EndInit();
    ((ISupportInitialize) this.Label4).EndInit();
    ((ISupportInitialize) this.Label5).EndInit();
    ((ISupportInitialize) this.Label6).EndInit();
    ((ISupportInitialize) this.Label8).EndInit();
    ((ISupportInitialize) this.Label9).EndInit();
    ((ISupportInitialize) this.Label10).EndInit();
    ((ISupportInitialize) this.lblCriteria2Title).EndInit();
    ((ISupportInitialize) this.Label18).EndInit();
    ((ISupportInitialize) this.Label19).EndInit();
    ((ISupportInitialize) this.Label20).EndInit();
    ((ISupportInitialize) this.Label22).EndInit();
    ((ISupportInitialize) this.Label23).EndInit();
    ((ISupportInitialize) this.Label24).EndInit();
    ((ISupportInitialize) this.Label25).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.Label7).EndInit();
    ((ISupportInitialize) this.Label11).EndInit();
    ((ISupportInitialize) this.Label13).EndInit();
    ((ISupportInitialize) this.TextBox15).EndInit();
    ((ISupportInitialize) this.TextBox16).EndInit();
    ((ISupportInitialize) this.TextBox17).EndInit();
    ((ISupportInitialize) this.Label16).EndInit();
    ((ISupportInitialize) this.lblCriteria2FooterText).EndInit();
    ((ISupportInitialize) this.TextBox22).EndInit();
    ((ISupportInitialize) this.TextBox23).EndInit();
    ((ISupportInitialize) this.txtUnderWriterItemCount).EndInit();
    ((ISupportInitialize) this.NetBilled2).EndInit();
    ((ISupportInitialize) this.TextBox18).EndInit();
  }

  public Type getLaunchForm => (Type) null;

  public BaseReportControl[] getReportControls
  {
    get
    {
      bool flag1 = Database.Instance.QueryText.PerformScalarQueryInt($"SELECT COUNT(*) FROM tblQuotes WHERE UnderwriterUserGuid = '{this.CurrentUserGuid}'") > 0;
      bool flag2 = Database.Instance.QueryText.PerformScalarQueryInt($"SELECT COUNT(*) FROM tblSubmissionGroup WHERE InHouseProducerUserGuid = '{this.CurrentUserGuid}'") > 0;
      GenericComboBox genericComboBox1;
      GenericComboBox genericComboBox2;
      if (SecurityManager.Instance.AssertPermission("{7A80CDAA-8E51-4a11-BE9A-F17D72F55AA0}"))
      {
        genericComboBox1 = new GenericComboBox("Underwriters", $"(SELECT -1 As Sort, 'All Underwriters' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblQuotes INNER JOIN tblUsers ON tblQuotes.UnderwriterUserGuid = tblUsers.UserGUID) ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid));
        genericComboBox2 = new GenericComboBox("In-House Producer", $"(SELECT -1 As Sort, 'All In-House Producers' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblSubmissionGroup INNER JOIN tblUsers ON tblSubmissionGroup.InHouseProducerUserGuid = tblUsers.UserGUID) ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid));
      }
      else
      {
        genericComboBox2 = !flag1 || !flag2 ? (!flag1 ? (!flag2 ? new GenericComboBox("In-House Producer", $"SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblUsers WHERE UserGuid = '{this.CurrentUserGuid}' ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid)) : new GenericComboBox("In-House Producer", $"(SELECT -1 As Sort, 'All In-House Producers' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblUsers WHERE UserGuid = '{this.CurrentUserGuid}') ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid))) : new GenericComboBox("In-House Producer", $"SELECT -1 As Sort, 'All In-House Producers' As UserName, '{Guid.Empty}' As UserGuid", "UserGuid", "UserName", typeof (Guid))) : new GenericComboBox("In-House Producer", $"(SELECT -1 As Sort, 'All In-House Producers' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblUsers WHERE UserGuid = '{this.CurrentUserGuid}') ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid));
        genericComboBox1 = new GenericComboBox("Underwriters", $"SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblUsers WHERE UserGuid = '{this.CurrentUserGuid}' ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid));
      }
      GenericListBox genericListBox = !SecurityManager.Instance.AssertPermission("{CB84C8BA-08AC-4102-B171-1950CFC673FC}") ? new GenericListBox("Issuing Office Location", $"SELECT tblClientOffices.Location as Display, tblClientOffices.OfficeID as Value FROM dbo.tblClientOffices INNER JOIN tblUsers ON tblClientOffices.OfficeGUID = tblUsers.OfficeGUID WHERE tblUsers.UserGUID = '{CurrentUser.Instance.UserGUID}' ORDER BY tblClientOffices.OfficeID", "Value", "Display", true, typeof (int), true, false) : new GenericListBox("Issuing Office Location", "SELECT Location AS Display, OfficeID AS Value FROM dbo.tblClientOffices ORDER BY Location", "Value", "Display", true, typeof (int), true, false);
      return new BaseReportControl[18]
      {
        (BaseReportControl) new DateRangePicker("Billing Date", true),
        (BaseReportControl) new DateRangePicker("Effective Date", true),
        (BaseReportControl) genericComboBox1,
        (BaseReportControl) genericComboBox2,
        (BaseReportControl) new Producers("Producer", true),
        (BaseReportControl) new GenericComboBox("Policy Type", "(SELECT -1 AS PolicyTypeID, 'All Types' AS Description, -1 AS SORT) UNION (SELECT PolicyTypeID, Description, 0 AS SORT FROM lstPolicyTypes) ORDER BY SORT, Description", "PolicyTypeID", "Description", typeof (int)),
        (BaseReportControl) new GenericComboBox("Company Group", $"(SELECT '{Guid.Empty}' As CompanyGroupGuid, 'All Groups' As CompanyGroupName, -1 AS [Order]) UNION (SELECT CompanyGroupGuid, CompanyGroupName, 0 AS [Order] FROM tblCompanyGroups) ORDER BY [Order],CompanyGroupName", "CompanyGroupGuid", "CompanyGroupName", typeof (Guid)),
        (BaseReportControl) new Companies("Company", true, new Guid[0]),
        (BaseReportControl) new CompanyLocations("Company Location", true),
        (BaseReportControl) new GenericComboBox("Quoting Office", $"(SELECT '{Guid.Empty}' As OfficeGuid, 'All Locations' As Location,  -1 AS [Order]) UNION (SELECT DISTINCT OfficeGUID, Location, 0 AS [Order] FROM tblClientOffices INNER JOIN tblQuotes ON tblClientOffices.OfficeGUID = tblQuotes.QuotingLocationGuid) ORDER BY [Order], Location", "OfficeGUID", "Location", typeof (Guid)),
        (BaseReportControl) new CompanyLines("Line", true),
        (BaseReportControl) new GenericComboBox("Quote Status", "SELECT -1 As QuoteStatusID, 'Any Status' As Description UNION SELECT QuoteStatusID, Description FROM lstQuoteStatus WHERE lstQuoteStatus.Bound = 1", "QuoteStatusID", "Description", typeof (int)),
        (BaseReportControl) genericListBox,
        (BaseReportControl) new GenericCheckBox("", "Show All Office Locations for this Company"),
        (BaseReportControl) new ProducerLocations("Producer Location", true),
        (BaseReportControl) new OrderBy(new string[24]
        {
          "Month",
          "MonthNumeric",
          "In House Producer",
          "InHouseProducer",
          "Invoice Date",
          "InvoiceDate",
          "Insured",
          "Insured",
          "Control Number",
          "QuoteControlNum",
          "Producer",
          "Producer",
          "Underwriter",
          "Underwriter",
          "Line",
          "LineOfCoverage",
          "CompanyLocation",
          "CompanyLocationName",
          "Company",
          "CompanyName",
          "Company Group",
          "CompanyGroupName",
          "Intermediary",
          "Intermediary"
        }),
        (BaseReportControl) new GenericComboBox("Cost Center", "((SELECT -1 As Sort, 'All Cost Centers' As Display, 0 As Value) UNION (SELECT   1 as Sort, dbo.tblEntityGroups.GroupName + '-' + dbo.tblClientOffices.Location AS Display,  dbo.tblEntityGroups.GroupId as Value FROM dbo.tblEntityGroups INNER JOIN dbo.tblClientOffices ON dbo.tblEntityGroups.GLCompanyID = dbo.tblClientOffices.OfficeID AND dbo.tblEntityGroups.GLCompanyID = dbo.tblClientOffices.OfficeID))  ORDER BY Sort, Display", "Value", "Display", typeof (int)),
        (BaseReportControl) new GenericCheckBox("", "Excel Only")
      };
    }
  }

  public override bool ExcelOnly => this._excelOnly;

  public override bool IsThreaded => true;

  public override void ExportToExcel(string FileName)
  {
    if (this.DataSource == null)
      return;
    DataTable source = new DataTable();
    DataColumnCollection columns = source.Columns;
    columns.Add("Month", typeof (string));
    columns.Add("Underwriter", typeof (string));
    columns.Add("Date Billed", typeof (DateTime));
    columns.Add("Effective Date", typeof (DateTime));
    columns.Add("Expiration Date", typeof (DateTime));
    columns.Add("Policy #", typeof (string));
    columns.Add("Insured", typeof (string));
    columns.Add("Producer", typeof (string));
    columns.Add("Line Of Coverage", typeof (string));
    columns.Add("Carrier", typeof (string));
    columns.Add("CompanyGroup", typeof (string));
    columns.Add("Intermediary", typeof (string));
    columns.Add("Control No", typeof (int));
    columns.Add("Policy Type", typeof (string));
    columns.Add("State", typeof (string));
    columns.Add("Premium", typeof (Decimal));
    columns.Add("NetBilled", typeof (Decimal));
    columns.Add("Remitter Comm", typeof (Decimal));
    columns.Add("Fees", typeof (Decimal));
    columns.Add("Recvd", typeof (Decimal));
    columns.Add("Recvd Comm", typeof (Decimal));
    columns.Add("MGA Comm", typeof (Decimal));
    try
    {
      foreach (DataRow row1 in this._dv.Table.Rows)
      {
        DataRow row2 = source.NewRow();
        row2["Month"] = (object) Conversions.ToDate(row1["InvoiceDate"]).ToString("MMMM");
        row2["Underwriter"] = RuntimeHelpers.GetObjectValue(row1["Underwriter"]);
        row2["Date Billed"] = RuntimeHelpers.GetObjectValue(row1["InvoiceDate"]);
        row2["Effective Date"] = RuntimeHelpers.GetObjectValue(row1["EffectiveDate"]);
        row2["Expiration Date"] = RuntimeHelpers.GetObjectValue(row1["ExpirationDate"]);
        row2["Policy #"] = RuntimeHelpers.GetObjectValue(row1["PolicyNumber"]);
        row2["Insured"] = RuntimeHelpers.GetObjectValue(row1["Insured"]);
        row2["Producer"] = RuntimeHelpers.GetObjectValue(row1["Producer"]);
        row2["Line Of Coverage"] = RuntimeHelpers.GetObjectValue(row1["LineOfCoverage"]);
        row2["Carrier"] = RuntimeHelpers.GetObjectValue(row1["Carrier"]);
        row2["CompanyGroup"] = RuntimeHelpers.GetObjectValue(row1["CompanyGroupName"]);
        row2["Intermediary"] = RuntimeHelpers.GetObjectValue(row1["Intermediary"]);
        row2["Control No"] = RuntimeHelpers.GetObjectValue(row1["QuoteControlNum"]);
        row2["Policy Type"] = RuntimeHelpers.GetObjectValue(row1["PolicyType"]);
        row2["State"] = RuntimeHelpers.GetObjectValue(row1["StateID"]);
        row2["Premium"] = RuntimeHelpers.GetObjectValue(row1["Premium"]);
        row2["NetBilled"] = RuntimeHelpers.GetObjectValue(row1["NetBilled"]);
        row2["Remitter Comm"] = RuntimeHelpers.GetObjectValue(row1["RemitterCommission"]);
        row2["Fees"] = RuntimeHelpers.GetObjectValue(row1["Fees"]);
        row2["Recvd"] = RuntimeHelpers.GetObjectValue(row1["AmountReceived"]);
        row2["Recvd Comm"] = RuntimeHelpers.GetObjectValue(row1["AmountReceivedCommission"]);
        row2["MGA Comm"] = RuntimeHelpers.GetObjectValue(row1["MGAComm"]);
        source.Rows.Add(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ExcelExport.ToExcel(source, FileName);
    source.Dispose();
  }

  [field: AccessedThroughProperty("ReportHeader")]
  private virtual ReportHeader ReportHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PageHeader")]
  private virtual PageHeader PageHeader { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghTotal")]
  private virtual GroupHeader ghTotal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghCriteria1")]
  private virtual GroupHeader ghCriteria1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ghCriteria2")]
  private virtual GroupHeader ghCriteria2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  private virtual GroupFooter gfCriteria2
  {
    get => this._gfCriteria2;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfCriteria2_BeforePrint);
      GroupFooter gfCriteria2_1 = this._gfCriteria2;
      if (gfCriteria2_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfCriteria2_1).BeforePrint -= eventHandler;
      this._gfCriteria2 = value;
      GroupFooter gfCriteria2_2 = this._gfCriteria2;
      if (gfCriteria2_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfCriteria2_2).BeforePrint += eventHandler;
    }
  }

  private virtual GroupFooter gfCriteria1
  {
    get => this._gfCriteria1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfCriteria1_BeforePrint);
      GroupFooter gfCriteria1_1 = this._gfCriteria1;
      if (gfCriteria1_1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfCriteria1_1).BeforePrint -= eventHandler;
      this._gfCriteria1 = value;
      GroupFooter gfCriteria1_2 = this._gfCriteria1;
      if (gfCriteria1_2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfCriteria1_2).BeforePrint += eventHandler;
    }
  }

  private virtual GroupFooter gfTotal
  {
    get => this._gfTotal;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gfTotal_BeforePrint);
      GroupFooter gfTotal1 = this._gfTotal;
      if (gfTotal1 != null)
        ((GrapeCity.ActiveReports.SectionReportModel.Section) gfTotal1).BeforePrint -= eventHandler;
      this._gfTotal = value;
      GroupFooter gfTotal2 = this._gfTotal;
      if (gfTotal2 == null)
        return;
      ((GrapeCity.ActiveReports.SectionReportModel.Section) gfTotal2).BeforePrint += eventHandler;
    }
  }

  [field: AccessedThroughProperty("PageFooter")]
  private virtual PageFooter PageFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ReportFooter")]
  private virtual ReportFooter ReportFooter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
