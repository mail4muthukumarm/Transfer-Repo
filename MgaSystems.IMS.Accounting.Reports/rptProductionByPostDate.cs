// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reports.rptProductionByPostDate
// Assembly: MgaSystems.IMS.Accounting.Reports, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 04B285D2-9F1D-4009-8AE0-5683AB5AFB4E
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Reports.dll

using DDCssLib;
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
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;

#nullable disable
namespace MGASystems.IMS.Accounting.Reports;

[SecureReportResource("{DFCCF8C2-EED4-4B74-9F04-760EE3E632C3}", "Production Report By Post Date", "Production Report By Post Date.", "General")]
[SecureResource("{971AA9F8-874A-4571-A38F-551723841B93}", "Production Report By Post Date User Access", "Allows user to run report for any/all users.", "Reports")]
[SecureResource("{6E3BB37E-62AC-435F-81D4-9567A8ADC518}", "Production Report By Post Date Issuing Office Access", "Allows user to run report for any/all issuing offices.", "Reports")]
public sealed class rptProductionByPostDate : MGAReport, IReport
{
  internal const string SecurityIDReportGuid = "{DFCCF8C2-EED4-4B74-9F04-760EE3E632C3}";
  internal const string SecurityIDAllUsers = "{971AA9F8-874A-4571-A38F-551723841B93}";
  internal const string SecurityIDAllOffices = "{6E3BB37E-62AC-435F-81D4-9567A8ADC518}";
  private SqlConnection _connection;
  private SqlCommand _command;
  private SqlDataAdapter _da;
  private DataTable _dt;
  private DataTable _dtSorted;
  private DateTime _postDateFrom;
  private DateTime _postDateTo;
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

  [field: AccessedThroughProperty("TextBox33")]
  private virtual TextBox TextBox33 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label14")]
  private virtual Label Label14 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public rptProductionByPostDate()
  {
    this.ReportStart += new EventHandler(this.rptProductionByPostDate_ReportStart);
    this._UnderWriterItemCount = 0;
    this._MonthlyItemCount = 0;
    this._TotalItemCount = 0;
    this._costCenter = 0;
  }

  public rptProductionByPostDate(
    DateTime postDateFrom,
    DateTime postDateTo,
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
    this.ReportStart += new EventHandler(this.rptProductionByPostDate_ReportStart);
    this._UnderWriterItemCount = 0;
    this._MonthlyItemCount = 0;
    this._TotalItemCount = 0;
    this._costCenter = 0;
    this.InitializeComponent();
    this._postDateFrom = postDateFrom;
    this._postDateTo = postDateTo;
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

  private void rptProductionByPostDate_ReportStart(object sender, EventArgs e)
  {
    this.BouncingProgress(true);
    this._connection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    this._command = new SqlCommand("spFin_rptProductionByPostDate", this._connection);
    this._command.CommandType = CommandType.StoredProcedure;
    this._command.CommandTimeout = 0;
    this.AddCommandToCancelList(this._command);
    if (DateTime.Compare(this._postDateFrom, DateTime.MinValue) != 0)
    {
      this._command.Parameters.Add("@postDateFrom", SqlDbType.DateTime);
      this._command.Parameters["@postDateFrom"].Value = (object) this._postDateFrom.Date;
      TextBox txtSubTitle;
      string str = $"{(txtSubTitle = this.txtSubTitle).Text} Post Date After {this._postDateFrom.Date.ToString("MM/dd/yyyy")}";
      txtSubTitle.Text = str;
    }
    if (DateTime.Compare(this._postDateTo, DateTime.MinValue) != 0)
    {
      this._command.Parameters.Add("@postDateTo", SqlDbType.DateTime);
      this._command.Parameters["@postDateTo"].Value = (object) this._postDateTo.Date;
      TextBox txtSubTitle;
      string str = $"{(txtSubTitle = this.txtSubTitle).Text} Post Date To {this._postDateTo.Date.ToString("MM/dd/yyyy")}";
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
        row["Month"] = (object) Conversions.ToDate(row["PostDate"]).ToString("MMMM");
        row["MonthNumeric"] = (object) Conversions.ToDate(row["PostDate"]).ToString("MM");
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._dv = new DataView(this._dt, "", this._SortBy, DataViewRowState.CurrentRows);
    this._dtSorted = this._dv.ToTable();
    this.DataSource = (object) this._dtSorted;
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptProductionByPostDate));
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
    this.Label14 = new Label();
    this.TextBox33 = new TextBox();
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
    ((ISupportInitialize) this.Label14).BeginInit();
    ((ISupportInitialize) this.TextBox33).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.Detail.ColumnSpacing = 0.0f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Controls.AddRange(new ARControl[20]
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
      (ARControl) this.TextBox14,
      (ARControl) this.TextBox33
    });
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.Detail).Height = 0.2083334f;
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
    ((ARControl) this.TextBox1).DataField = "PostDate";
    ((ARControl) this.TextBox1).Height = 3f / 16f;
    ((ARControl) this.TextBox1).Left = 0.0f;
    ((ARControl) this.TextBox1).Name = "TextBox1";
    this.TextBox1.OutputFormat = resourceManager.GetString("TextBox1.OutputFormat");
    this.TextBox1.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox1.Text = (string) null;
    ((ARControl) this.TextBox1).Top = 0.0f;
    ((ARControl) this.TextBox1).Width = 9f / 16f;
    ((ARControl) this.TextBox2).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox2).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox2).DataField = "EffectiveDate";
    ((ARControl) this.TextBox2).Height = 3f / 16f;
    ((ARControl) this.TextBox2).Left = 1.124f;
    ((ARControl) this.TextBox2).Name = "TextBox2";
    this.TextBox2.OutputFormat = resourceManager.GetString("TextBox2.OutputFormat");
    this.TextBox2.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox2.Text = " ";
    ((ARControl) this.TextBox2).Top = 0.0f;
    ((ARControl) this.TextBox2).Width = 9f / 16f;
    ((ARControl) this.TextBox3).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox3).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox3).DataField = "ExpirationDate";
    ((ARControl) this.TextBox3).Height = 3f / 16f;
    ((ARControl) this.TextBox3).Left = 1.686f;
    ((ARControl) this.TextBox3).Name = "TextBox3";
    this.TextBox3.OutputFormat = resourceManager.GetString("TextBox3.OutputFormat");
    this.TextBox3.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox3.Text = " ";
    ((ARControl) this.TextBox3).Top = 0.0f;
    ((ARControl) this.TextBox3).Width = 9f / 16f;
    ((ARControl) this.TextBox4).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox4).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox4).DataField = "Insured";
    ((ARControl) this.TextBox4).Height = 3f / 16f;
    ((ARControl) this.TextBox4).Left = 3.532f;
    ((ARControl) this.TextBox4).Name = "TextBox4";
    this.TextBox4.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox4.Text = " ";
    ((ARControl) this.TextBox4).Top = 0.0f;
    ((ARControl) this.TextBox4).Width = 0.8960004f;
    ((ARControl) this.TextBox5).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox5).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox5).DataField = "Producer";
    ((ARControl) this.TextBox5).Height = 3f / 16f;
    ((ARControl) this.TextBox5).Left = 4.428f;
    ((ARControl) this.TextBox5).Name = "TextBox5";
    this.TextBox5.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox5.Text = " ";
    ((ARControl) this.TextBox5).Top = 0.0f;
    ((ARControl) this.TextBox5).Width = 0.822f;
    ((ARControl) this.TextBox7).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox7).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox7).DataField = "Premium";
    ((ARControl) this.TextBox7).Height = 3f / 16f;
    ((ARControl) this.TextBox7).Left = 135f / 16f;
    ((ARControl) this.TextBox7).Name = "TextBox7";
    this.TextBox7.OutputFormat = resourceManager.GetString("TextBox7.OutputFormat");
    this.TextBox7.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox7.Text = " ";
    ((ARControl) this.TextBox7).Top = 0.0f;
    ((ARControl) this.TextBox7).Width = 0.75f;
    ((ARControl) this.TextBox8).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox8).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox8).DataField = "NetBilled";
    ((ARControl) this.TextBox8).Height = 3f / 16f;
    ((ARControl) this.TextBox8).Left = 147f / 16f;
    ((ARControl) this.TextBox8).Name = "TextBox8";
    this.TextBox8.OutputFormat = resourceManager.GetString("TextBox8.OutputFormat");
    this.TextBox8.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox8.Text = " ";
    ((ARControl) this.TextBox8).Top = 0.0f;
    ((ARControl) this.TextBox8).Width = 0.75f;
    ((ARControl) this.TextBox9).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox9).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox9).DataField = "MGAComm";
    ((ARControl) this.TextBox9).Height = 3f / 16f;
    ((ARControl) this.TextBox9).Left = 205f / 16f;
    ((ARControl) this.TextBox9).Name = "TextBox9";
    this.TextBox9.OutputFormat = resourceManager.GetString("TextBox9.OutputFormat");
    this.TextBox9.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox9.Text = (string) null;
    ((ARControl) this.TextBox9).Top = 0.0f;
    ((ARControl) this.TextBox9).Width = 0.75f;
    ((ARControl) this.TextBox19).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox19).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox19).DataField = "PolicyType";
    ((ARControl) this.TextBox19).Height = 3f / 16f;
    ((ARControl) this.TextBox19).Left = 125f / 16f;
    ((ARControl) this.TextBox19).Name = "TextBox19";
    this.TextBox19.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox19.Text = " ";
    ((ARControl) this.TextBox19).Top = 0.0f;
    ((ARControl) this.TextBox19).Width = 0.625f;
    ((ARControl) this.TextBox20).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox20).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox20).DataField = "AmountReceived";
    ((ARControl) this.TextBox20).Height = 3f / 16f;
    ((ARControl) this.TextBox20).Left = 183f / 16f;
    ((ARControl) this.TextBox20).Name = "TextBox20";
    this.TextBox20.OutputFormat = resourceManager.GetString("TextBox20.OutputFormat");
    this.TextBox20.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox20.Text = (string) null;
    ((ARControl) this.TextBox20).Top = 0.0f;
    ((ARControl) this.TextBox20).Width = 11f / 16f;
    ((ARControl) this.TextBox21).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox21).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox21).DataField = "AmountReceivedCommission";
    ((ARControl) this.TextBox21).Height = 3f / 16f;
    ((ARControl) this.TextBox21).Left = 12.125f;
    ((ARControl) this.TextBox21).Name = "TextBox21";
    this.TextBox21.OutputFormat = resourceManager.GetString("TextBox21.OutputFormat");
    this.TextBox21.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox21.Text = (string) null;
    ((ARControl) this.TextBox21).Top = 0.0f;
    ((ARControl) this.TextBox21).Width = 11f / 16f;
    ((ARControl) this.txtQuoteControlNum).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.txtQuoteControlNum).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.txtQuoteControlNum).DataField = "QuoteControlNum";
    ((ARControl) this.txtQuoteControlNum).Height = 3f / 16f;
    ((ARControl) this.txtQuoteControlNum).Left = 7.375f;
    ((ARControl) this.txtQuoteControlNum).Name = "txtQuoteControlNum";
    this.txtQuoteControlNum.Style = "color: Blue; font-size: 6.75pt; text-decoration: underline; ddo-char-set: 0";
    this.txtQuoteControlNum.Text = (string) null;
    ((ARControl) this.txtQuoteControlNum).Top = 0.0f;
    ((ARControl) this.txtQuoteControlNum).Width = 7f / 16f;
    ((ARControl) this.Producer1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Producer1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Producer1).DataField = "Carrier";
    ((ARControl) this.Producer1).Height = 3f / 16f;
    ((ARControl) this.Producer1).Left = 6.5f;
    ((ARControl) this.Producer1).Name = "Producer1";
    this.Producer1.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.Producer1.Text = " ";
    ((ARControl) this.Producer1).Top = 0.0f;
    ((ARControl) this.Producer1).Width = 0.875f;
    ((ARControl) this.Insured1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.Insured1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.Insured1).DataField = "PolicyNumber";
    ((ARControl) this.Insured1).Height = 3f / 16f;
    ((ARControl) this.Insured1).Left = 2.249f;
    ((ARControl) this.Insured1).Name = "Insured1";
    this.Insured1.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.Insured1.Text = " ";
    ((ARControl) this.Insured1).Top = 0.0f;
    ((ARControl) this.Insured1).Width = 0.7410002f;
    ((ARControl) this.NetBilled1).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.NetBilled1).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.NetBilled1).DataField = "RemitterCommission";
    ((ARControl) this.NetBilled1).Height = 3f / 16f;
    ((ARControl) this.NetBilled1).Left = 159f / 16f;
    ((ARControl) this.NetBilled1).Name = "NetBilled1";
    this.NetBilled1.OutputFormat = resourceManager.GetString("NetBilled1.OutputFormat");
    this.NetBilled1.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.NetBilled1.Text = " ";
    ((ARControl) this.NetBilled1).Top = 0.0f;
    ((ARControl) this.NetBilled1).Width = 0.75f;
    ((ARControl) this.TextBox).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox).DataField = "LineOfCoverage";
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 5.25f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox.Text = " ";
    ((ARControl) this.TextBox).Top = 0.0f;
    ((ARControl) this.TextBox).Width = 9f / 16f;
    ((ARControl) this.TextBox6).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox6).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox6).DataField = "RiskDescription";
    ((ARControl) this.TextBox6).Height = 3f / 16f;
    ((ARControl) this.TextBox6).Left = 93f / 16f;
    ((ARControl) this.TextBox6).Name = "TextBox6";
    this.TextBox6.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox6.Text = " ";
    ((ARControl) this.TextBox6).Top = 0.0f;
    ((ARControl) this.TextBox6).Width = 11f / 16f;
    ((ARControl) this.TextBox10).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox10).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox10).DataField = "QuoteStatus";
    ((ARControl) this.TextBox10).Height = 3f / 16f;
    ((ARControl) this.TextBox10).Left = 2.99f;
    ((ARControl) this.TextBox10).Name = "TextBox10";
    this.TextBox10.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox10.Text = " ";
    ((ARControl) this.TextBox10).Top = 0.0f;
    ((ARControl) this.TextBox10).Width = 0.5419998f;
    ((ARControl) this.TextBox14).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox14).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox14).DataField = "Fees";
    ((ARControl) this.TextBox14).Height = 3f / 16f;
    ((ARControl) this.TextBox14).Left = 171f / 16f;
    ((ARControl) this.TextBox14).Name = "TextBox14";
    this.TextBox14.OutputFormat = resourceManager.GetString("TextBox14.OutputFormat");
    this.TextBox14.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox14.Text = " ";
    ((ARControl) this.TextBox14).Top = 0.0f;
    ((ARControl) this.TextBox14).Width = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.Label1,
      (ARControl) this.txtSubTitle
    });
    this.ReportHeader.Height = 9f / 16f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ReportHeader).Name = "ReportHeader";
    ((ARControl) this.Label1).Height = 0.25f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 0.0f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 14.25pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.Label1.Text = "Production Report";
    ((ARControl) this.Label1).Top = 0.0f;
    ((ARControl) this.Label1).Width = 217f / 16f;
    ((ARControl) this.txtSubTitle).Height = 3f / 16f;
    ((ARControl) this.txtSubTitle).Left = 0.0f;
    ((ARControl) this.txtSubTitle).Name = "txtSubTitle";
    this.txtSubTitle.Style = "text-align: center; ddo-char-set: 0";
    this.txtSubTitle.Text = (string) null;
    ((ARControl) this.txtSubTitle).Top = 0.25f;
    ((ARControl) this.txtSubTitle).Width = 217f / 16f;
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
    ((ARControl) this.TextBox31).DataField = "AmountReceivedCommission";
    ((ARControl) this.TextBox31).Height = 3f / 16f;
    ((ARControl) this.TextBox31).Left = 12.125f;
    ((ARControl) this.TextBox31).Name = "TextBox31";
    this.TextBox31.OutputFormat = resourceManager.GetString("TextBox31.OutputFormat");
    this.TextBox31.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox31.SummaryGroup = "ghTotal";
    this.TextBox31.SummaryRunning = (SummaryRunning) 2;
    this.TextBox31.SummaryType = (SummaryType) 1;
    this.TextBox31.Text = " ";
    ((ARControl) this.TextBox31).Top = 0.0f;
    ((ARControl) this.TextBox31).Width = 11f / 16f;
    ((ARControl) this.TextBox30).DataField = "AmountReceived";
    ((ARControl) this.TextBox30).Height = 3f / 16f;
    ((ARControl) this.TextBox30).Left = 183f / 16f;
    ((ARControl) this.TextBox30).Name = "TextBox30";
    this.TextBox30.OutputFormat = resourceManager.GetString("TextBox30.OutputFormat");
    this.TextBox30.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox30.SummaryGroup = "ghTotal";
    this.TextBox30.SummaryRunning = (SummaryRunning) 2;
    this.TextBox30.SummaryType = (SummaryType) 1;
    this.TextBox30.Text = " ";
    ((ARControl) this.TextBox30).Top = 0.0f;
    ((ARControl) this.TextBox30).Width = 11f / 16f;
    ((ARControl) this.Label21).Height = 3f / 16f;
    this.Label21.HyperLink = (string) null;
    ((ARControl) this.Label21).Left = 7.125f;
    ((ARControl) this.Label21).Name = "Label21";
    this.Label21.Style = "font-size: 6.75pt; font-weight: bold; ddo-char-set: 0";
    this.Label21.Text = "Totals:";
    ((ARControl) this.Label21).Top = 0.0f;
    ((ARControl) this.Label21).Width = 21f / 16f;
    ((ARControl) this.TextBox28).DataField = "MGAComm";
    ((ARControl) this.TextBox28).Height = 3f / 16f;
    ((ARControl) this.TextBox28).Left = 205f / 16f;
    ((ARControl) this.TextBox28).Name = "TextBox28";
    this.TextBox28.OutputFormat = resourceManager.GetString("TextBox28.OutputFormat");
    this.TextBox28.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox28.SummaryGroup = "ghTotal";
    this.TextBox28.SummaryRunning = (SummaryRunning) 2;
    this.TextBox28.SummaryType = (SummaryType) 1;
    this.TextBox28.Text = " ";
    ((ARControl) this.TextBox28).Top = 0.0f;
    ((ARControl) this.TextBox28).Width = 0.75f;
    ((ARControl) this.TextBox27).DataField = "NetBilled";
    ((ARControl) this.TextBox27).Height = 3f / 16f;
    ((ARControl) this.TextBox27).Left = 147f / 16f;
    ((ARControl) this.TextBox27).Name = "TextBox27";
    this.TextBox27.OutputFormat = resourceManager.GetString("TextBox27.OutputFormat");
    this.TextBox27.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox27.SummaryGroup = "ghTotal";
    this.TextBox27.SummaryRunning = (SummaryRunning) 2;
    this.TextBox27.SummaryType = (SummaryType) 1;
    this.TextBox27.Text = " ";
    ((ARControl) this.TextBox27).Top = 0.0f;
    ((ARControl) this.TextBox27).Width = 0.75f;
    ((ARControl) this.TextBox26).DataField = "Premium";
    ((ARControl) this.TextBox26).Height = 3f / 16f;
    ((ARControl) this.TextBox26).Left = 135f / 16f;
    ((ARControl) this.TextBox26).Name = "TextBox26";
    this.TextBox26.OutputFormat = resourceManager.GetString("TextBox26.OutputFormat");
    this.TextBox26.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox26.SummaryGroup = "ghTotal";
    this.TextBox26.SummaryRunning = (SummaryRunning) 2;
    this.TextBox26.SummaryType = (SummaryType) 1;
    this.TextBox26.Text = " ";
    ((ARControl) this.TextBox26).Top = 0.0f;
    ((ARControl) this.TextBox26).Width = 0.75f;
    ((ARControl) this.txtTotalItems).Height = 3f / 16f;
    ((ARControl) this.txtTotalItems).Left = 0.0f;
    ((ARControl) this.txtTotalItems).Name = "txtTotalItems";
    this.txtTotalItems.Style = "font-size: 6.75pt; font-weight: bold; ddo-char-set: 0";
    this.txtTotalItems.Text = (string) null;
    ((ARControl) this.txtTotalItems).Top = 0.0f;
    ((ARControl) this.txtTotalItems).Width = 1f;
    ((ARControl) this.NetBilled4).DataField = "RemitterCommission";
    ((ARControl) this.NetBilled4).Height = 3f / 16f;
    ((ARControl) this.NetBilled4).Left = 159f / 16f;
    ((ARControl) this.NetBilled4).Name = "NetBilled4";
    this.NetBilled4.OutputFormat = resourceManager.GetString("NetBilled4.OutputFormat");
    this.NetBilled4.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.NetBilled4.SummaryGroup = "ghTotal";
    this.NetBilled4.SummaryRunning = (SummaryRunning) 2;
    this.NetBilled4.SummaryType = (SummaryType) 1;
    this.NetBilled4.Text = " ";
    ((ARControl) this.NetBilled4).Top = 0.0f;
    ((ARControl) this.NetBilled4).Width = 0.75f;
    ((ARControl) this.TextBox32).DataField = "Fees";
    ((ARControl) this.TextBox32).Height = 3f / 16f;
    ((ARControl) this.TextBox32).Left = 171f / 16f;
    ((ARControl) this.TextBox32).Name = "TextBox32";
    this.TextBox32.OutputFormat = resourceManager.GetString("TextBox32.OutputFormat");
    this.TextBox32.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox32.SummaryGroup = "ghTotal";
    this.TextBox32.SummaryRunning = (SummaryRunning) 2;
    this.TextBox32.SummaryType = (SummaryType) 1;
    this.TextBox32.Text = " ";
    ((ARControl) this.TextBox32).Top = 0.0f;
    ((ARControl) this.TextBox32).Width = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria1).Controls.AddRange(new ARControl[1]
    {
      (ARControl) this.lblCriteria1Title
    });
    this.ghCriteria1.Height = 7f / 16f;
    this.ghCriteria1.KeepTogether = true;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria1).Name = "ghCriteria1";
    ((ARControl) this.lblCriteria1Title).Height = 0.25f;
    this.lblCriteria1Title.HyperLink = (string) null;
    ((ARControl) this.lblCriteria1Title).Left = 0.0f;
    ((ARControl) this.lblCriteria1Title).Name = "lblCriteria1Title";
    this.lblCriteria1Title.Style = "font-size: 14.25pt; font-weight: bold; ddo-char-set: 0";
    this.lblCriteria1Title.Text = "";
    ((ARControl) this.lblCriteria1Title).Top = 1f / 16f;
    ((ARControl) this.lblCriteria1Title).Width = 217f / 16f;
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
    ((ARControl) this.TextBox11).DataField = "Premium";
    ((ARControl) this.TextBox11).Height = 3f / 16f;
    ((ARControl) this.TextBox11).Left = 135f / 16f;
    ((ARControl) this.TextBox11).Name = "TextBox11";
    this.TextBox11.OutputFormat = resourceManager.GetString("TextBox11.OutputFormat");
    this.TextBox11.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox11.SummaryGroup = "ghCriteria1";
    this.TextBox11.SummaryRunning = (SummaryRunning) 1;
    this.TextBox11.SummaryType = (SummaryType) 3;
    this.TextBox11.Text = " ";
    ((ARControl) this.TextBox11).Top = 0.0f;
    ((ARControl) this.TextBox11).Width = 0.75f;
    ((ARControl) this.TextBox12).DataField = "NetBilled";
    ((ARControl) this.TextBox12).Height = 3f / 16f;
    ((ARControl) this.TextBox12).Left = 147f / 16f;
    ((ARControl) this.TextBox12).Name = "TextBox12";
    this.TextBox12.OutputFormat = resourceManager.GetString("TextBox12.OutputFormat");
    this.TextBox12.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox12.SummaryGroup = "ghCriteria1";
    this.TextBox12.SummaryRunning = (SummaryRunning) 1;
    this.TextBox12.SummaryType = (SummaryType) 3;
    this.TextBox12.Text = " ";
    ((ARControl) this.TextBox12).Top = 0.0f;
    ((ARControl) this.TextBox12).Width = 0.75f;
    ((ARControl) this.TextBox13).DataField = "MGAComm";
    ((ARControl) this.TextBox13).Height = 3f / 16f;
    ((ARControl) this.TextBox13).Left = 205f / 16f;
    ((ARControl) this.TextBox13).Name = "TextBox13";
    this.TextBox13.OutputFormat = resourceManager.GetString("TextBox13.OutputFormat");
    this.TextBox13.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox13.SummaryGroup = "ghCriteria1";
    this.TextBox13.SummaryRunning = (SummaryRunning) 1;
    this.TextBox13.SummaryType = (SummaryType) 3;
    this.TextBox13.Text = " ";
    ((ARControl) this.TextBox13).Top = 0.0f;
    ((ARControl) this.TextBox13).Width = 0.75f;
    ((ARControl) this.Label12).Height = 3f / 16f;
    this.Label12.HyperLink = (string) null;
    ((ARControl) this.Label12).Left = 7.125f;
    ((ARControl) this.Label12).Name = "Label12";
    this.Label12.Style = "font-size: 6.75pt; font-weight: bold; ddo-char-set: 0";
    this.Label12.Text = "Totals:";
    ((ARControl) this.Label12).Top = 0.0f;
    ((ARControl) this.Label12).Width = 21f / 16f;
    ((ARControl) this.lblCriteria1FooterText).Height = 3f / 16f;
    this.lblCriteria1FooterText.HyperLink = (string) null;
    ((ARControl) this.lblCriteria1FooterText).Left = 1f;
    ((ARControl) this.lblCriteria1FooterText).Name = "lblCriteria1FooterText";
    this.lblCriteria1FooterText.Style = "font-size: 6.75pt; font-weight: bold; text-align: right; ddo-char-set: 0";
    this.lblCriteria1FooterText.Text = "";
    ((ARControl) this.lblCriteria1FooterText).Top = 0.0f;
    ((ARControl) this.lblCriteria1FooterText).Width = 6.125f;
    ((ARControl) this.TextBox24).DataField = "AmountReceived";
    ((ARControl) this.TextBox24).Height = 3f / 16f;
    ((ARControl) this.TextBox24).Left = 183f / 16f;
    ((ARControl) this.TextBox24).Name = "TextBox24";
    this.TextBox24.OutputFormat = resourceManager.GetString("TextBox24.OutputFormat");
    this.TextBox24.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox24.SummaryGroup = "ghCriteria1";
    this.TextBox24.SummaryRunning = (SummaryRunning) 1;
    this.TextBox24.SummaryType = (SummaryType) 3;
    this.TextBox24.Text = " ";
    ((ARControl) this.TextBox24).Top = 0.0f;
    ((ARControl) this.TextBox24).Width = 11f / 16f;
    ((ARControl) this.TextBox25).DataField = "AmountReceivedCommission";
    ((ARControl) this.TextBox25).Height = 3f / 16f;
    ((ARControl) this.TextBox25).Left = 12.125f;
    ((ARControl) this.TextBox25).Name = "TextBox25";
    this.TextBox25.OutputFormat = resourceManager.GetString("TextBox25.OutputFormat");
    this.TextBox25.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox25.SummaryGroup = "ghCriteria1";
    this.TextBox25.SummaryRunning = (SummaryRunning) 1;
    this.TextBox25.SummaryType = (SummaryType) 3;
    this.TextBox25.Text = " ";
    ((ARControl) this.TextBox25).Top = 0.0f;
    ((ARControl) this.TextBox25).Width = 11f / 16f;
    ((ARControl) this.txtMonthItemCount).Height = 3f / 16f;
    ((ARControl) this.txtMonthItemCount).Left = 0.0f;
    ((ARControl) this.txtMonthItemCount).Name = "txtMonthItemCount";
    this.txtMonthItemCount.Style = "font-size: 6.75pt; font-weight: bold; ddo-char-set: 0";
    this.txtMonthItemCount.Text = (string) null;
    ((ARControl) this.txtMonthItemCount).Top = 0.0f;
    ((ARControl) this.txtMonthItemCount).Width = 1f;
    ((ARControl) this.NetBilled3).DataField = "RemitterCommission";
    ((ARControl) this.NetBilled3).Height = 3f / 16f;
    ((ARControl) this.NetBilled3).Left = 159f / 16f;
    ((ARControl) this.NetBilled3).Name = "NetBilled3";
    this.NetBilled3.OutputFormat = resourceManager.GetString("NetBilled3.OutputFormat");
    this.NetBilled3.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.NetBilled3.SummaryGroup = "ghCriteria1";
    this.NetBilled3.SummaryRunning = (SummaryRunning) 1;
    this.NetBilled3.SummaryType = (SummaryType) 3;
    this.NetBilled3.Text = " ";
    ((ARControl) this.NetBilled3).Top = 0.0f;
    ((ARControl) this.NetBilled3).Width = 0.75f;
    ((ARControl) this.TextBox29).DataField = "Fees";
    ((ARControl) this.TextBox29).Height = 3f / 16f;
    ((ARControl) this.TextBox29).Left = 171f / 16f;
    ((ARControl) this.TextBox29).Name = "TextBox29";
    this.TextBox29.OutputFormat = resourceManager.GetString("TextBox29.OutputFormat");
    this.TextBox29.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox29.SummaryGroup = "ghCriteria1";
    this.TextBox29.SummaryRunning = (SummaryRunning) 1;
    this.TextBox29.SummaryType = (SummaryType) 3;
    this.TextBox29.Text = " ";
    ((ARControl) this.TextBox29).Top = 0.0f;
    ((ARControl) this.TextBox29).Width = 0.75f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria2).Controls.AddRange(new ARControl[21]
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
      (ARControl) this.Label13,
      (ARControl) this.Label14
    });
    this.ghCriteria2.Height = 0.5833334f;
    ((GrapeCity.ActiveReports.SectionReportModel.Section) this.ghCriteria2).Name = "ghCriteria2";
    ((ARControl) this.Label2).Height = 3f / 16f;
    this.Label2.HyperLink = (string) null;
    ((ARControl) this.Label2).Left = 0.0f;
    ((ARControl) this.Label2).Name = "Label2";
    this.Label2.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label2.Text = "Post Date";
    ((ARControl) this.Label2).Top = 0.375f;
    ((ARControl) this.Label2).Width = 9f / 16f;
    ((ARControl) this.Label3).Height = 3f / 16f;
    this.Label3.HyperLink = (string) null;
    ((ARControl) this.Label3).Left = 1.124f;
    ((ARControl) this.Label3).Name = "Label3";
    this.Label3.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label3.Text = "Effective";
    ((ARControl) this.Label3).Top = 0.375f;
    ((ARControl) this.Label3).Width = 9f / 16f;
    ((ARControl) this.Label4).Height = 3f / 16f;
    this.Label4.HyperLink = (string) null;
    ((ARControl) this.Label4).Left = 1.686f;
    ((ARControl) this.Label4).Name = "Label4";
    this.Label4.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label4.Text = "Expiration";
    ((ARControl) this.Label4).Top = 0.375f;
    ((ARControl) this.Label4).Width = 9f / 16f;
    ((ARControl) this.Label5).Height = 3f / 16f;
    this.Label5.HyperLink = (string) null;
    ((ARControl) this.Label5).Left = 3.532f;
    ((ARControl) this.Label5).Name = "Label5";
    this.Label5.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label5.Text = "Insured";
    ((ARControl) this.Label5).Top = 0.375f;
    ((ARControl) this.Label5).Width = 0.8960004f;
    ((ARControl) this.Label6).Height = 3f / 16f;
    this.Label6.HyperLink = (string) null;
    ((ARControl) this.Label6).Left = 4.428f;
    ((ARControl) this.Label6).Name = "Label6";
    this.Label6.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label6.Text = "Producer";
    ((ARControl) this.Label6).Top = 0.375f;
    ((ARControl) this.Label6).Width = 0.822f;
    ((ARControl) this.Label8).Height = 3f / 16f;
    this.Label8.HyperLink = (string) null;
    ((ARControl) this.Label8).Left = 135f / 16f;
    ((ARControl) this.Label8).Name = "Label8";
    this.Label8.Style = "font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.Label8.Text = "Premium";
    ((ARControl) this.Label8).Top = 0.375f;
    ((ARControl) this.Label8).Width = 0.75f;
    ((ARControl) this.Label9).Height = 3f / 16f;
    this.Label9.HyperLink = (string) null;
    ((ARControl) this.Label9).Left = 147f / 16f;
    ((ARControl) this.Label9).Name = "Label9";
    this.Label9.Style = "font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.Label9.Text = "Net Billed";
    ((ARControl) this.Label9).Top = 0.375f;
    ((ARControl) this.Label9).Width = 0.75f;
    ((ARControl) this.Label10).Height = 3f / 16f;
    this.Label10.HyperLink = (string) null;
    ((ARControl) this.Label10).Left = 205f / 16f;
    ((ARControl) this.Label10).Name = "Label10";
    this.Label10.Style = "font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.Label10.Text = "MGA Comm";
    ((ARControl) this.Label10).Top = 0.375f;
    ((ARControl) this.Label10).Width = 0.75f;
    ((ARControl) this.lblCriteria2Title).Height = 3f / 16f;
    this.lblCriteria2Title.HyperLink = (string) null;
    ((ARControl) this.lblCriteria2Title).Left = 0.0f;
    ((ARControl) this.lblCriteria2Title).Name = "lblCriteria2Title";
    this.lblCriteria2Title.Style = "font-size: 11.25pt; ddo-char-set: 0";
    this.lblCriteria2Title.Text = "";
    ((ARControl) this.lblCriteria2Title).Top = 1f / 16f;
    ((ARControl) this.lblCriteria2Title).Width = 217f / 16f;
    ((ARControl) this.Label18).Height = 3f / 16f;
    this.Label18.HyperLink = (string) null;
    ((ARControl) this.Label18).Left = 125f / 16f;
    ((ARControl) this.Label18).Name = "Label18";
    this.Label18.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label18.Text = "Policy Type";
    ((ARControl) this.Label18).Top = 0.375f;
    ((ARControl) this.Label18).Width = 0.625f;
    ((ARControl) this.Label19).Height = 3f / 16f;
    this.Label19.HyperLink = (string) null;
    ((ARControl) this.Label19).Left = 183f / 16f;
    ((ARControl) this.Label19).Name = "Label19";
    this.Label19.Style = "font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.Label19.Text = "Recvd";
    ((ARControl) this.Label19).Top = 0.375f;
    ((ARControl) this.Label19).Width = 11f / 16f;
    ((ARControl) this.Label20).Height = 3f / 16f;
    this.Label20.HyperLink = (string) null;
    ((ARControl) this.Label20).Left = 12.125f;
    ((ARControl) this.Label20).Name = "Label20";
    this.Label20.Style = "font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.Label20.Text = "Recvd Comm";
    ((ARControl) this.Label20).Top = 0.375f;
    ((ARControl) this.Label20).Width = 11f / 16f;
    ((ARControl) this.Label22).Height = 0.25f;
    this.Label22.HyperLink = (string) null;
    ((ARControl) this.Label22).Left = 7.375f;
    ((ARControl) this.Label22).Name = "Label22";
    this.Label22.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label22.Text = "Control No";
    ((ARControl) this.Label22).Top = 5f / 16f;
    ((ARControl) this.Label22).Width = 7f / 16f;
    ((ARControl) this.Label23).Height = 3f / 16f;
    this.Label23.HyperLink = (string) null;
    ((ARControl) this.Label23).Left = 6.5f;
    ((ARControl) this.Label23).Name = "Label23";
    this.Label23.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label23.Text = "Carrier";
    ((ARControl) this.Label23).Top = 0.375f;
    ((ARControl) this.Label23).Width = 0.875f;
    ((ARControl) this.Label24).Height = 3f / 16f;
    this.Label24.HyperLink = (string) null;
    ((ARControl) this.Label24).Left = 2.249f;
    ((ARControl) this.Label24).Name = "Label24";
    this.Label24.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label24.Text = "Policy";
    ((ARControl) this.Label24).Top = 0.375f;
    ((ARControl) this.Label24).Width = 0.7410002f;
    ((ARControl) this.Label25).Height = 3f / 16f;
    this.Label25.HyperLink = (string) null;
    ((ARControl) this.Label25).Left = 159f / 16f;
    ((ARControl) this.Label25).Name = "Label25";
    this.Label25.Style = "font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.Label25.Text = "Remitter Comm";
    ((ARControl) this.Label25).Top = 0.375f;
    ((ARControl) this.Label25).Width = 0.75f;
    ((ARControl) this.Label).Height = 0.25f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 5.25f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label.Text = "Line Of Coverage";
    ((ARControl) this.Label).Top = 5f / 16f;
    ((ARControl) this.Label).Width = 9f / 16f;
    ((ARControl) this.Label7).Height = 0.25f;
    this.Label7.HyperLink = (string) null;
    ((ARControl) this.Label7).Left = 93f / 16f;
    ((ARControl) this.Label7).Name = "Label7";
    this.Label7.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label7.Text = "Risk Description";
    ((ARControl) this.Label7).Top = 5f / 16f;
    ((ARControl) this.Label7).Width = 11f / 16f;
    ((ARControl) this.Label11).Height = 3f / 16f;
    this.Label11.HyperLink = (string) null;
    ((ARControl) this.Label11).Left = 2.99f;
    ((ARControl) this.Label11).Name = "Label11";
    this.Label11.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label11.Text = "Status";
    ((ARControl) this.Label11).Top = 0.375f;
    ((ARControl) this.Label11).Width = 0.5419998f;
    ((ARControl) this.Label13).Height = 3f / 16f;
    this.Label13.HyperLink = (string) null;
    ((ARControl) this.Label13).Left = 171f / 16f;
    ((ARControl) this.Label13).Name = "Label13";
    this.Label13.Style = "font-size: 6.75pt; font-weight: bold; text-align: right; vertical-align: bottom; ddo-char-set: 0";
    this.Label13.Text = "Fees";
    ((ARControl) this.Label13).Top = 0.375f;
    ((ARControl) this.Label13).Width = 0.75f;
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
    ((ARControl) this.TextBox15).DataField = "Premium";
    ((ARControl) this.TextBox15).Height = 3f / 16f;
    ((ARControl) this.TextBox15).Left = 135f / 16f;
    ((ARControl) this.TextBox15).Name = "TextBox15";
    this.TextBox15.OutputFormat = resourceManager.GetString("TextBox15.OutputFormat");
    this.TextBox15.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox15.SummaryGroup = "ghCriteria2";
    this.TextBox15.SummaryRunning = (SummaryRunning) 1;
    this.TextBox15.SummaryType = (SummaryType) 3;
    this.TextBox15.Text = " ";
    ((ARControl) this.TextBox15).Top = 0.0f;
    ((ARControl) this.TextBox15).Width = 0.75f;
    ((ARControl) this.TextBox16).DataField = "NetBilled";
    ((ARControl) this.TextBox16).Height = 3f / 16f;
    ((ARControl) this.TextBox16).Left = 147f / 16f;
    ((ARControl) this.TextBox16).Name = "TextBox16";
    this.TextBox16.OutputFormat = resourceManager.GetString("TextBox16.OutputFormat");
    this.TextBox16.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox16.SummaryGroup = "ghCriteria2";
    this.TextBox16.SummaryRunning = (SummaryRunning) 1;
    this.TextBox16.SummaryType = (SummaryType) 3;
    this.TextBox16.Text = " ";
    ((ARControl) this.TextBox16).Top = 0.0f;
    ((ARControl) this.TextBox16).Width = 0.75f;
    ((ARControl) this.TextBox17).DataField = "MGAComm";
    ((ARControl) this.TextBox17).Height = 3f / 16f;
    ((ARControl) this.TextBox17).Left = 205f / 16f;
    ((ARControl) this.TextBox17).Name = "TextBox17";
    this.TextBox17.OutputFormat = resourceManager.GetString("TextBox17.OutputFormat");
    this.TextBox17.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox17.SummaryGroup = "ghCriteria2";
    this.TextBox17.SummaryRunning = (SummaryRunning) 1;
    this.TextBox17.SummaryType = (SummaryType) 3;
    this.TextBox17.Text = " ";
    ((ARControl) this.TextBox17).Top = 0.0f;
    ((ARControl) this.TextBox17).Width = 0.75f;
    ((ARControl) this.Label16).Height = 3f / 16f;
    this.Label16.HyperLink = (string) null;
    ((ARControl) this.Label16).Left = 7.125f;
    ((ARControl) this.Label16).Name = "Label16";
    this.Label16.Style = "font-size: 6.75pt; font-weight: bold";
    this.Label16.Text = "Totals:";
    ((ARControl) this.Label16).Top = 0.0f;
    ((ARControl) this.Label16).Width = 21f / 16f;
    ((ARControl) this.lblCriteria2FooterText).Height = 3f / 16f;
    this.lblCriteria2FooterText.HyperLink = (string) null;
    ((ARControl) this.lblCriteria2FooterText).Left = 1f;
    ((ARControl) this.lblCriteria2FooterText).Name = "lblCriteria2FooterText";
    this.lblCriteria2FooterText.Style = "font-size: 6.75pt; font-weight: bold; text-align: right";
    this.lblCriteria2FooterText.Text = "";
    ((ARControl) this.lblCriteria2FooterText).Top = 0.0f;
    ((ARControl) this.lblCriteria2FooterText).Width = 6.125f;
    ((ARControl) this.TextBox22).DataField = "AmountReceived";
    ((ARControl) this.TextBox22).Height = 3f / 16f;
    ((ARControl) this.TextBox22).Left = 183f / 16f;
    ((ARControl) this.TextBox22).Name = "TextBox22";
    this.TextBox22.OutputFormat = resourceManager.GetString("TextBox22.OutputFormat");
    this.TextBox22.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox22.SummaryGroup = "ghCriteria2";
    this.TextBox22.SummaryRunning = (SummaryRunning) 1;
    this.TextBox22.SummaryType = (SummaryType) 3;
    this.TextBox22.Text = " ";
    ((ARControl) this.TextBox22).Top = 0.0f;
    ((ARControl) this.TextBox22).Width = 11f / 16f;
    ((ARControl) this.TextBox23).DataField = "AmountReceivedCommission";
    ((ARControl) this.TextBox23).Height = 3f / 16f;
    ((ARControl) this.TextBox23).Left = 12.125f;
    ((ARControl) this.TextBox23).Name = "TextBox23";
    this.TextBox23.OutputFormat = resourceManager.GetString("TextBox23.OutputFormat");
    this.TextBox23.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox23.SummaryGroup = "ghCriteria2";
    this.TextBox23.SummaryRunning = (SummaryRunning) 1;
    this.TextBox23.SummaryType = (SummaryType) 3;
    this.TextBox23.Text = " ";
    ((ARControl) this.TextBox23).Top = 0.0f;
    ((ARControl) this.TextBox23).Width = 11f / 16f;
    ((ARControl) this.txtUnderWriterItemCount).Height = 3f / 16f;
    ((ARControl) this.txtUnderWriterItemCount).Left = 0.0f;
    ((ARControl) this.txtUnderWriterItemCount).Name = "txtUnderWriterItemCount";
    this.txtUnderWriterItemCount.Style = "font-size: 6.75pt; font-weight: bold; ddo-char-set: 0";
    this.txtUnderWriterItemCount.Text = (string) null;
    ((ARControl) this.txtUnderWriterItemCount).Top = 0.0f;
    ((ARControl) this.txtUnderWriterItemCount).Width = 1f;
    ((ARControl) this.NetBilled2).DataField = "RemitterCommission";
    ((ARControl) this.NetBilled2).Height = 3f / 16f;
    ((ARControl) this.NetBilled2).Left = 159f / 16f;
    ((ARControl) this.NetBilled2).Name = "NetBilled2";
    this.NetBilled2.OutputFormat = resourceManager.GetString("NetBilled2.OutputFormat");
    this.NetBilled2.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.NetBilled2.SummaryGroup = "ghCriteria2";
    this.NetBilled2.SummaryRunning = (SummaryRunning) 1;
    this.NetBilled2.SummaryType = (SummaryType) 3;
    this.NetBilled2.Text = " ";
    ((ARControl) this.NetBilled2).Top = 0.0f;
    ((ARControl) this.NetBilled2).Width = 0.75f;
    ((ARControl) this.TextBox18).DataField = "Fees";
    ((ARControl) this.TextBox18).Height = 3f / 16f;
    ((ARControl) this.TextBox18).Left = 171f / 16f;
    ((ARControl) this.TextBox18).Name = "TextBox18";
    this.TextBox18.OutputFormat = resourceManager.GetString("TextBox18.OutputFormat");
    this.TextBox18.Style = "font-size: 6.75pt; text-align: right; ddo-char-set: 0";
    this.TextBox18.SummaryGroup = "ghCriteria2";
    this.TextBox18.SummaryRunning = (SummaryRunning) 1;
    this.TextBox18.SummaryType = (SummaryType) 3;
    this.TextBox18.Text = " ";
    ((ARControl) this.TextBox18).Top = 0.0f;
    ((ARControl) this.TextBox18).Width = 0.75f;
    ((ARControl) this.Label14).Height = 3f / 16f;
    this.Label14.HyperLink = (string) null;
    ((ARControl) this.Label14).Left = 0.562f;
    ((ARControl) this.Label14).Name = "Label14";
    this.Label14.Style = "font-size: 6.75pt; font-weight: bold; vertical-align: bottom; ddo-char-set: 0";
    this.Label14.Text = "Billed Date";
    ((ARControl) this.Label14).Top = 0.375f;
    ((ARControl) this.Label14).Width = 9f / 16f;
    ((ARControl) this.TextBox33).Border.BottomColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox33).Border.BottomStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox33).Border.LeftColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox33).Border.LeftStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox33).Border.RightColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox33).Border.RightStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox33).Border.TopColor = Color.FromArgb(224 /*0xE0*/, 224 /*0xE0*/, 224 /*0xE0*/);
    ((ARControl) this.TextBox33).Border.TopStyle = (BorderLineStyle) 1;
    ((ARControl) this.TextBox33).DataField = "BilledDate";
    ((ARControl) this.TextBox33).Height = 3f / 16f;
    ((ARControl) this.TextBox33).Left = 0.562f;
    ((ARControl) this.TextBox33).Name = "TextBox33";
    this.TextBox33.OutputFormat = resourceManager.GetString("TextBox33.OutputFormat");
    this.TextBox33.Style = "font-size: 6.75pt; ddo-char-set: 0";
    this.TextBox33.Text = (string) null;
    ((ARControl) this.TextBox33).Top = 0.0f;
    ((ARControl) this.TextBox33).Width = 9f / 16f;
    this.MasterReport = false;
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
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
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
    ((ISupportInitialize) this.Label14).EndInit();
    ((ISupportInitialize) this.TextBox33).EndInit();
    ((ISupportInitialize) this).EndInit();
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
      if (SecurityManager.Instance.AssertPermission("{971AA9F8-874A-4571-A38F-551723841B93}"))
      {
        genericComboBox1 = new GenericComboBox("Underwriters", $"(SELECT -1 As Sort, 'All Underwriters' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblQuotes INNER JOIN tblUsers ON tblQuotes.UnderwriterUserGuid = tblUsers.UserGUID) ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid));
        genericComboBox2 = new GenericComboBox("In-House Producer", $"(SELECT -1 As Sort, 'All In-House Producers' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblSubmissionGroup INNER JOIN tblUsers ON tblSubmissionGroup.InHouseProducerUserGuid = tblUsers.UserGUID) ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid));
      }
      else
      {
        genericComboBox2 = !flag1 || !flag2 ? (!flag1 ? (!flag2 ? new GenericComboBox("In-House Producer", $"SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblUsers WHERE UserGuid = '{this.CurrentUserGuid}' ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid)) : new GenericComboBox("In-House Producer", $"(SELECT -1 As Sort, 'All In-House Producers' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblUsers WHERE UserGuid = '{this.CurrentUserGuid}') ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid))) : new GenericComboBox("In-House Producer", $"(SELECT -1 As Sort, 'All In-House Producers' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblSubmissionGroup INNER JOIN tblUsers ON tblSubmissionGroup.InHouseProducerUserGuid = tblUsers.UserGUID) ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid))) : new GenericComboBox("In-House Producer", $"(SELECT -1 As Sort, 'All In-House Producers' As UserName, '{Guid.Empty}' As UserGuid) UNION (SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblUsers WHERE UserGuid = '{this.CurrentUserGuid}') ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid));
        genericComboBox1 = new GenericComboBox("Underwriters", $"SELECT DISTINCT 1 As Sort, tblUsers.FirstName + ' ' + tblUsers.LastName As UserName, UserGuid FROM tblUsers WHERE UserGuid = '{this.CurrentUserGuid}' ORDER BY Sort,UserName", "UserGuid", "UserName", typeof (Guid));
      }
      GenericListBox genericListBox = !SecurityManager.Instance.AssertPermission("{6E3BB37E-62AC-435F-81D4-9567A8ADC518}") ? new GenericListBox("Issuing Office Location", $"SELECT tblClientOffices.Location as Display, tblClientOffices.OfficeID as Value FROM dbo.tblClientOffices INNER JOIN tblUsers ON tblClientOffices.OfficeGUID = tblUsers.OfficeGUID WHERE tblUsers.UserGUID = '{CurrentUser.Instance.UserGUID}' ORDER BY tblClientOffices.OfficeID", "Value", "Display", true, typeof (int), true, false) : new GenericListBox("Issuing Office Location", "SELECT Location AS Display, OfficeID AS Value FROM dbo.tblClientOffices ORDER BY Location", "Value", "Display", true, typeof (int), true, false);
      return new BaseReportControl[18]
      {
        (BaseReportControl) new DateRangePicker("Post Date", true),
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
          "Post Date",
          "PostDate",
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
    columns.Add("Inhouse Producer", typeof (string));
    columns.Add("Post Date", typeof (DateTime));
    columns.Add("Billed Date", typeof (DateTime));
    columns.Add("Effective Date", typeof (DateTime));
    columns.Add("Expiration Date", typeof (DateTime));
    columns.Add("Policy #", typeof (string));
    columns.Add("Status", typeof (string));
    columns.Add("Insured", typeof (string));
    columns.Add("Producer", typeof (string));
    columns.Add("Line Of Coverage", typeof (string));
    columns.Add("Carrier", typeof (string));
    columns.Add("CompanyGroup", typeof (string));
    columns.Add("Intermediary", typeof (string));
    columns.Add("Control No", typeof (int));
    columns.Add("Invoice No", typeof (int));
    columns.Add("Policy Type", typeof (string));
    columns.Add("Transaction Type", typeof (string));
    columns.Add("State", typeof (string));
    columns.Add("Issuing Location", typeof (string));
    columns.Add("Premium", typeof (Decimal));
    columns.Add("NetBilled", typeof (Decimal));
    columns.Add("Remitter Comm", typeof (Decimal));
    columns.Add("Fees", typeof (Decimal));
    columns.Add("Recvd", typeof (Decimal));
    columns.Add("Recvd Comm", typeof (Decimal));
    columns.Add("MGA Comm", typeof (Decimal));
    columns.Add("Commission", typeof (Decimal));
    columns.Add("SubmissionGroupID", typeof (int));
    try
    {
      foreach (DataRow row1 in this._dtSorted.Rows)
      {
        DataRow row2 = source.NewRow();
        row2["Month"] = (object) Conversions.ToDate(row1["PostDate"]).ToString("MMMM");
        row2["Underwriter"] = RuntimeHelpers.GetObjectValue(row1["Underwriter"]);
        row2["Inhouse Producer"] = RuntimeHelpers.GetObjectValue(row1["InhouseProducer"]);
        row2["Post Date"] = RuntimeHelpers.GetObjectValue(row1["PostDate"]);
        row2["Billed Date"] = RuntimeHelpers.GetObjectValue(row1["BilledDate"]);
        row2["Effective Date"] = RuntimeHelpers.GetObjectValue(row1["EffectiveDate"]);
        row2["Expiration Date"] = RuntimeHelpers.GetObjectValue(row1["ExpirationDate"]);
        row2["Policy #"] = RuntimeHelpers.GetObjectValue(row1["PolicyNumber"]);
        row2["Status"] = RuntimeHelpers.GetObjectValue(row1["QuoteStatus"]);
        row2["Insured"] = RuntimeHelpers.GetObjectValue(row1["Insured"]);
        row2["Producer"] = RuntimeHelpers.GetObjectValue(row1["Producer"]);
        row2["Line Of Coverage"] = RuntimeHelpers.GetObjectValue(row1["LineOfCoverage"]);
        row2["Carrier"] = RuntimeHelpers.GetObjectValue(row1["Carrier"]);
        row2["CompanyGroup"] = RuntimeHelpers.GetObjectValue(row1["CompanyGroupName"]);
        row2["Intermediary"] = RuntimeHelpers.GetObjectValue(row1["Intermediary"]);
        row2["Control No"] = RuntimeHelpers.GetObjectValue(row1["QuoteControlNum"]);
        row2["Invoice No"] = RuntimeHelpers.GetObjectValue(row1["Sys_InvoiceNum"]);
        row2["Policy Type"] = RuntimeHelpers.GetObjectValue(row1["PolicyType"]);
        row2["Transaction Type"] = RuntimeHelpers.GetObjectValue(row1["TransactionType"]);
        row2["State"] = RuntimeHelpers.GetObjectValue(row1["StateID"]);
        row2["Issuing Location"] = RuntimeHelpers.GetObjectValue(row1["IssuingLocation"]);
        row2["Premium"] = RuntimeHelpers.GetObjectValue(row1["Premium"]);
        row2["NetBilled"] = RuntimeHelpers.GetObjectValue(row1["NetBilled"]);
        row2["Remitter Comm"] = RuntimeHelpers.GetObjectValue(row1["RemitterCommission"]);
        row2["Fees"] = RuntimeHelpers.GetObjectValue(row1["Fees"]);
        row2["Recvd"] = RuntimeHelpers.GetObjectValue(row1["AmountReceived"]);
        row2["Recvd Comm"] = RuntimeHelpers.GetObjectValue(row1["AmountReceivedCommission"]);
        row2["MGA Comm"] = RuntimeHelpers.GetObjectValue(row1["MGAComm"]);
        row2["Commission"] = RuntimeHelpers.GetObjectValue(row1["Commission"]);
        row2["SubmissionGroupID"] = RuntimeHelpers.GetObjectValue(row1["SubmissionGroupID"]);
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
    Process.Start(FileName);
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
