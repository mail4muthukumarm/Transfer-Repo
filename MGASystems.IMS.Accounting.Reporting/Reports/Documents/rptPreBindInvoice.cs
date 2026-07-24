// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Reporting.Reports.Documents.rptPreBindInvoice
// Assembly: MGASystems.IMS.Accounting.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 725B9A25-3FF1-4B2E-9ECA-9E17C2CAE78A
// Assembly location: D:\augusta\fortegra\IMS Project\MGASystems.IMS.Accounting.Reporting.dll

using DDCssLib;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.SectionReportModel;
using MGASystems.Common;
using MGASystems.IMS.Reporting.AutomationReports;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Resources;

#nullable disable
namespace MGASystems.IMS.Accounting.Reporting.Reports.Documents;

[AutomationReport("{41FDBD63-6119-46A8-A494-92581F3E47DF}", Enums.AutomationDocGroups.PolicyDoc, "Pre-Bind Invoice", "Pre-Bind Invoice")]
public class rptPreBindInvoice : SectionReport, IQuoteDocument
{
  internal const string AutomationGuid = "{41FDBD63-6119-46A8-A494-92581F3E47DF}";
  private rptPreBindInvoice_Payees _srPayees;
  private rptPreBindInvoice_Summary _srSummary;
  private rptPreBindInvoice_Details _srDetails;
  private Guid _QuoteGuid;
  private Guid _QuoteOptionGuid;
  private bool _blnMGACopy;
  private Decimal _TotalGrossBilled;
  private Decimal _TotalRemitterAmt;
  private string _strRemitter;
  private DataSet _invoiceData = new DataSet();
  private Font _voidFont;
  private Font _pageNumberFont;
  private Container components;
  private PageHeader pageHeader;
  private Detail detail;
  private PageFooter pageFooter;
  private SubReport srSummary;
  private SubReport srPayees;
  private SubReport srDetails;
  private TextBox TextBox;
  private Label Label;
  private Label lblInvoiceCopy;
  private TextBox txtInvoiceNumber;
  private ReportHeader reportHeader1;
  private TextBox txtClientOfficeNameAddress;
  private TextBox txtCurrentDate;
  private TextBox txtRemitterInformation;
  private Label lblRE;
  private Label lblCompany;
  private TextBox txtRe;
  private Label lblUnderwriter;
  private TextBox txtUnderwriterName;
  private Label lblEffectiveDate;
  private TextBox txtEffectiveDate;
  private TextBox txtCompany;
  private Label Label1;
  private TextBox txtRemitterAddressName;
  private Label lblPolicyNum;
  private TextBox txtPolicyNumber;
  private Label lblInvoiceType;
  private TextBox txtInvoiceType;
  private ReportFooter reportFooter1;
  private TextBox textBox2;
  private Label label2;
  private Line Line1;
  private Line Line;
  private Line Line2;
  private Line Line3;
  private Line Line5;
  private Line Line6;
  private Line Line8;
  private Line Line7;

  public bool RequiresQuoteOptionGuids() => false;

  public void SetQuoteOptionGuids(Guid[] quoteOptionGuids)
  {
    this._QuoteOptionGuid = quoteOptionGuids[0];
  }

  public Decimal TotalGrossBilled
  {
    get => this._TotalGrossBilled;
    set => this._TotalGrossBilled = value;
  }

  public Decimal TotalRemitterAmount
  {
    get => this._TotalRemitterAmt;
    set => this._TotalRemitterAmt = value;
  }

  public rptPreBindInvoice() => this.InitializeComponent();

  public rptPreBindInvoice(Guid QuoteGuid)
  {
    this.InitializeComponent();
    this._QuoteGuid = QuoteGuid;
    this._blnMGACopy = false;
    this.ReportStart += new EventHandler(this.rptPreBindInvoice_ReportStart);
    ((Section) this.detail).Format += new EventHandler(this.detail_Format);
    this.ReportEnd += new EventHandler(this.rptPreBindInvoice_ReportEnd);
  }

  private void rptPreBindInvoice_ReportEnd(object sender, EventArgs e)
  {
  }

  private void detail_Format(object sender, EventArgs e)
  {
    this._srDetails = new rptPreBindInvoice_Details(this._strRemitter, this, this._invoiceData.Tables["InvoiceDetails"]);
    this.srDetails.Report = (SectionReport) this._srDetails;
    if (!this._blnMGACopy)
      return;
    this._srPayees = new rptPreBindInvoice_Payees(this._invoiceData.Tables["InvoicePayees"]);
    this.srPayees.Report = (SectionReport) this._srPayees;
    this._srSummary = new rptPreBindInvoice_Summary(this, this._invoiceData.Tables["InvoicePayees"]);
    this.srSummary.Report = (SectionReport) this._srSummary;
  }

  private void rptPreBindInvoice_ReportStart(object sender, EventArgs e)
  {
    SqlConnection sqlConnection = new SqlConnection(CurrentUser.Instance.ConnectionString);
    SqlCommand selectCommand = new SqlCommand();
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    DataSet dataSet = new DataSet();
    try
    {
      selectCommand.CommandText = "[spFin_PrintPreBindInvoice]";
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Connection = sqlConnection;
      selectCommand.Parameters.AddWithValue("@QuoteGuid", (object) this._QuoteGuid);
      sqlDataAdapter.Fill(dataSet);
      dataSet.Tables[0].TableName = "InvoiceHeader";
      dataSet.Tables[1].TableName = "InvoiceDetails";
      dataSet.Tables[2].TableName = "InvoicePayees";
      this._invoiceData = dataSet;
      this.txtEffectiveDate.Text = $"{((DateTime) dataSet.Tables["InvoiceHeader"].Rows[0]["EFFECTIVEDATE"]).ToShortDateString()} - {((DateTime) dataSet.Tables["InvoiceHeader"].Rows[0]["EXPIRATIONDATE"]).ToShortDateString()}";
      this.lblInvoiceCopy.Text = !this._blnMGACopy ? "Broker Copy" : "MGA Copy";
      this._strRemitter = "Broker";
      this.DataSource = (object) dataSet.Tables["InvoiceHeader"];
    }
    finally
    {
      sqlConnection.Close();
      sqlConnection.Dispose();
      selectCommand.Dispose();
      sqlDataAdapter.Dispose();
      dataSet.Dispose();
    }
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    ResourceManager resourceManager = new ResourceManager(typeof (rptPreBindInvoice));
    this.pageHeader = new PageHeader();
    this.detail = new Detail();
    this.srSummary = new SubReport();
    this.srPayees = new SubReport();
    this.srDetails = new SubReport();
    this.TextBox = new TextBox();
    this.Label = new Label();
    this.pageFooter = new PageFooter();
    this.lblInvoiceCopy = new Label();
    this.txtInvoiceNumber = new TextBox();
    this.reportHeader1 = new ReportHeader();
    this.txtClientOfficeNameAddress = new TextBox();
    this.txtCurrentDate = new TextBox();
    this.txtRemitterInformation = new TextBox();
    this.lblRE = new Label();
    this.lblCompany = new Label();
    this.txtRe = new TextBox();
    this.lblUnderwriter = new Label();
    this.txtUnderwriterName = new TextBox();
    this.lblEffectiveDate = new Label();
    this.txtEffectiveDate = new TextBox();
    this.txtCompany = new TextBox();
    this.Label1 = new Label();
    this.txtRemitterAddressName = new TextBox();
    this.lblPolicyNum = new Label();
    this.txtPolicyNumber = new TextBox();
    this.lblInvoiceType = new Label();
    this.txtInvoiceType = new TextBox();
    this.textBox2 = new TextBox();
    this.label2 = new Label();
    this.Line1 = new Line();
    this.Line = new Line();
    this.Line2 = new Line();
    this.Line3 = new Line();
    this.Line5 = new Line();
    this.Line6 = new Line();
    this.Line8 = new Line();
    this.Line7 = new Line();
    this.reportFooter1 = new ReportFooter();
    ((ISupportInitialize) this.TextBox).BeginInit();
    ((ISupportInitialize) this.Label).BeginInit();
    ((ISupportInitialize) this.lblInvoiceCopy).BeginInit();
    ((ISupportInitialize) this.txtInvoiceNumber).BeginInit();
    ((ISupportInitialize) this.txtClientOfficeNameAddress).BeginInit();
    ((ISupportInitialize) this.txtCurrentDate).BeginInit();
    ((ISupportInitialize) this.txtRemitterInformation).BeginInit();
    ((ISupportInitialize) this.lblRE).BeginInit();
    ((ISupportInitialize) this.lblCompany).BeginInit();
    ((ISupportInitialize) this.txtRe).BeginInit();
    ((ISupportInitialize) this.lblUnderwriter).BeginInit();
    ((ISupportInitialize) this.txtUnderwriterName).BeginInit();
    ((ISupportInitialize) this.lblEffectiveDate).BeginInit();
    ((ISupportInitialize) this.txtEffectiveDate).BeginInit();
    ((ISupportInitialize) this.txtCompany).BeginInit();
    ((ISupportInitialize) this.Label1).BeginInit();
    ((ISupportInitialize) this.txtRemitterAddressName).BeginInit();
    ((ISupportInitialize) this.lblPolicyNum).BeginInit();
    ((ISupportInitialize) this.txtPolicyNumber).BeginInit();
    ((ISupportInitialize) this.lblInvoiceType).BeginInit();
    ((ISupportInitialize) this.txtInvoiceType).BeginInit();
    ((ISupportInitialize) this.textBox2).BeginInit();
    ((ISupportInitialize) this.label2).BeginInit();
    ((ISupportInitialize) this).BeginInit();
    this.pageHeader.Height = 0.0f;
    ((Section) this.pageHeader).Name = "pageHeader";
    this.detail.ColumnSpacing = 0.0f;
    ((Section) this.detail).Controls.AddRange(new ARControl[5]
    {
      (ARControl) this.srSummary,
      (ARControl) this.srPayees,
      (ARControl) this.srDetails,
      (ARControl) this.TextBox,
      (ARControl) this.Label
    });
    ((Section) this.detail).Height = 3.635417f;
    ((Section) this.detail).Name = "detail";
    this.srSummary.CloseBorder = false;
    ((ARControl) this.srSummary).Height = 0.75f;
    ((ARControl) this.srSummary).Left = 0.0f;
    ((ARControl) this.srSummary).Name = "srSummary";
    this.srSummary.Report = (SectionReport) null;
    this.srSummary.ReportName = "";
    ((ARControl) this.srSummary).Top = 39f / 16f;
    ((ARControl) this.srSummary).Width = 7f;
    this.srPayees.CloseBorder = false;
    ((ARControl) this.srPayees).Height = 0.75f;
    ((ARControl) this.srPayees).Left = 0.0f;
    ((ARControl) this.srPayees).Name = "srPayees";
    this.srPayees.Report = (SectionReport) null;
    this.srPayees.ReportName = "";
    ((ARControl) this.srPayees).Top = 1.5f;
    ((ARControl) this.srPayees).Width = 7f;
    this.srDetails.CloseBorder = false;
    ((ARControl) this.srDetails).Height = 0.75f;
    ((ARControl) this.srDetails).Left = 0.0f;
    ((ARControl) this.srDetails).Name = "srDetails";
    this.srDetails.Report = (SectionReport) null;
    this.srDetails.ReportName = "";
    ((ARControl) this.srDetails).Top = 0.25f;
    ((ARControl) this.srDetails).Width = 7f;
    ((ARControl) this.TextBox).DataField = "Comments";
    ((ARControl) this.TextBox).Height = 3f / 16f;
    ((ARControl) this.TextBox).Left = 1.375f;
    ((ARControl) this.TextBox).Name = "TextBox";
    this.TextBox.Style = "ddo-char-set: 0";
    this.TextBox.Text = (string) null;
    ((ARControl) this.TextBox).Top = 55f / 16f;
    ((ARControl) this.TextBox).Width = 5.625f;
    ((ARControl) this.Label).Height = 3f / 16f;
    this.Label.HyperLink = (string) null;
    ((ARControl) this.Label).Left = 0.0f;
    ((ARControl) this.Label).Name = "Label";
    this.Label.Style = "font-weight: bold";
    this.Label.Text = "Comments:";
    ((ARControl) this.Label).Top = 55f / 16f;
    ((ARControl) this.Label).Width = 21f / 16f;
    ((Section) this.pageFooter).Controls.AddRange(new ARControl[2]
    {
      (ARControl) this.lblInvoiceCopy,
      (ARControl) this.txtInvoiceNumber
    });
    this.pageFooter.Height = 9f / 16f;
    ((Section) this.pageFooter).Name = "pageFooter";
    ((ARControl) this.lblInvoiceCopy).Height = 0.375f;
    this.lblInvoiceCopy.HyperLink = (string) null;
    ((ARControl) this.lblInvoiceCopy).Left = 0.0f;
    ((ARControl) this.lblInvoiceCopy).Name = "lblInvoiceCopy";
    this.lblInvoiceCopy.Style = "font-size: 20.25pt; text-align: center; ddo-char-set: 0";
    this.lblInvoiceCopy.Text = "Invoice Copy";
    ((ARControl) this.lblInvoiceCopy).Top = 0.0f;
    ((ARControl) this.lblInvoiceCopy).Width = 7f;
    ((ARControl) this.txtInvoiceNumber).DataField = "OrginalInvoiceNumber";
    ((ARControl) this.txtInvoiceNumber).Height = 3f / 16f;
    ((ARControl) this.txtInvoiceNumber).Left = 5f;
    ((ARControl) this.txtInvoiceNumber).Name = "txtInvoiceNumber";
    this.txtInvoiceNumber.Style = "text-align: right; ddo-char-set: 0";
    this.txtInvoiceNumber.Text = (string) null;
    ((ARControl) this.txtInvoiceNumber).Top = 0.375f;
    ((ARControl) this.txtInvoiceNumber).Width = 2f;
    ((Section) this.reportHeader1).Controls.AddRange(new ARControl[27]
    {
      (ARControl) this.txtClientOfficeNameAddress,
      (ARControl) this.txtCurrentDate,
      (ARControl) this.txtRemitterInformation,
      (ARControl) this.lblRE,
      (ARControl) this.lblCompany,
      (ARControl) this.txtRe,
      (ARControl) this.lblUnderwriter,
      (ARControl) this.txtUnderwriterName,
      (ARControl) this.lblEffectiveDate,
      (ARControl) this.txtEffectiveDate,
      (ARControl) this.txtCompany,
      (ARControl) this.Label1,
      (ARControl) this.txtRemitterAddressName,
      (ARControl) this.lblPolicyNum,
      (ARControl) this.txtPolicyNumber,
      (ARControl) this.lblInvoiceType,
      (ARControl) this.txtInvoiceType,
      (ARControl) this.textBox2,
      (ARControl) this.label2,
      (ARControl) this.Line1,
      (ARControl) this.Line,
      (ARControl) this.Line2,
      (ARControl) this.Line3,
      (ARControl) this.Line5,
      (ARControl) this.Line6,
      (ARControl) this.Line8,
      (ARControl) this.Line7
    });
    this.reportHeader1.Height = 3.708333f;
    ((Section) this.reportHeader1).Name = "reportHeader1";
    ((ARControl) this.txtClientOfficeNameAddress).DataField = "ClientOfficeNameAddress";
    ((ARControl) this.txtClientOfficeNameAddress).Height = 0.625f;
    ((ARControl) this.txtClientOfficeNameAddress).Left = 1f / 16f;
    ((ARControl) this.txtClientOfficeNameAddress).Name = "txtClientOfficeNameAddress";
    this.txtClientOfficeNameAddress.Style = "font-size: 11pt; font-weight: bold; text-align: center; ddo-char-set: 0";
    this.txtClientOfficeNameAddress.Text = (string) null;
    ((ARControl) this.txtClientOfficeNameAddress).Top = 0.375f;
    ((ARControl) this.txtClientOfficeNameAddress).Width = 125f / 16f;
    ((ARControl) this.txtCurrentDate).DataField = "invoicedate";
    ((ARControl) this.txtCurrentDate).Height = 3f / 16f;
    ((ARControl) this.txtCurrentDate).Left = 5.375f;
    ((ARControl) this.txtCurrentDate).Name = "txtCurrentDate";
    this.txtCurrentDate.OutputFormat = resourceManager.GetString("txtCurrentDate.OutputFormat");
    this.txtCurrentDate.Style = "font-size: 9.75pt; ddo-char-set: 0";
    this.txtCurrentDate.Text = "Current Date";
    ((ARControl) this.txtCurrentDate).Top = 2.25f;
    ((ARControl) this.txtCurrentDate).Width = 1.625f;
    ((ARControl) this.txtRemitterInformation).DataField = "RemitterAddress";
    ((ARControl) this.txtRemitterInformation).Height = 0.875f;
    ((ARControl) this.txtRemitterInformation).Left = 0.125f;
    ((ARControl) this.txtRemitterInformation).Name = "txtRemitterInformation";
    this.txtRemitterInformation.Style = "text-align: center; ddo-char-set: 0";
    this.txtRemitterInformation.Text = "Remitter Information";
    ((ARControl) this.txtRemitterInformation).Top = 2f;
    ((ARControl) this.txtRemitterInformation).Width = 2.875f;
    ((ARControl) this.lblRE).Height = 3f / 16f;
    this.lblRE.HyperLink = (string) null;
    ((ARControl) this.lblRE).Left = 1f / 16f;
    ((ARControl) this.lblRE).Name = "lblRE";
    this.lblRE.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblRE.Text = "RE:";
    ((ARControl) this.lblRE).Top = 53f / 16f;
    ((ARControl) this.lblRE).Width = 13f / 16f;
    ((ARControl) this.lblCompany).Height = 3f / 16f;
    this.lblCompany.HyperLink = (string) null;
    ((ARControl) this.lblCompany).Left = 1f / 16f;
    ((ARControl) this.lblCompany).Name = "lblCompany";
    this.lblCompany.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblCompany.Text = "Company:";
    ((ARControl) this.lblCompany).Top = 3.5f;
    ((ARControl) this.lblCompany).Width = 13f / 16f;
    ((ARControl) this.txtRe).DataField = "referencename";
    ((ARControl) this.txtRe).Height = 3f / 16f;
    ((ARControl) this.txtRe).Left = 0.875f;
    ((ARControl) this.txtRe).Name = "txtRe";
    this.txtRe.Style = "ddo-char-set: 0";
    this.txtRe.Text = "Re Company";
    ((ARControl) this.txtRe).Top = 53f / 16f;
    ((ARControl) this.txtRe).Width = 3f;
    ((ARControl) this.lblUnderwriter).Height = 3f / 16f;
    this.lblUnderwriter.HyperLink = (string) null;
    ((ARControl) this.lblUnderwriter).Left = 4.375f;
    ((ARControl) this.lblUnderwriter).Name = "lblUnderwriter";
    this.lblUnderwriter.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblUnderwriter.Text = "Underwriter";
    ((ARControl) this.lblUnderwriter).Top = 39f / 16f;
    ((ARControl) this.lblUnderwriter).Width = 1f;
    ((ARControl) this.txtUnderwriterName).DataField = "UnderwriterName";
    ((ARControl) this.txtUnderwriterName).Height = 3f / 16f;
    ((ARControl) this.txtUnderwriterName).Left = 5.375f;
    ((ARControl) this.txtUnderwriterName).Name = "txtUnderwriterName";
    this.txtUnderwriterName.Style = "ddo-char-set: 0";
    this.txtUnderwriterName.Text = "Underwriter Name";
    ((ARControl) this.txtUnderwriterName).Top = 39f / 16f;
    ((ARControl) this.txtUnderwriterName).Width = 37f / 16f;
    ((ARControl) this.lblEffectiveDate).Height = 3f / 16f;
    this.lblEffectiveDate.HyperLink = (string) null;
    ((ARControl) this.lblEffectiveDate).Left = 4.375f;
    ((ARControl) this.lblEffectiveDate).Name = "lblEffectiveDate";
    this.lblEffectiveDate.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblEffectiveDate.Text = "Effective Date:";
    ((ARControl) this.lblEffectiveDate).Top = 2.625f;
    ((ARControl) this.lblEffectiveDate).Width = 1f;
    ((ARControl) this.txtEffectiveDate).Height = 3f / 16f;
    ((ARControl) this.txtEffectiveDate).Left = 5.375f;
    ((ARControl) this.txtEffectiveDate).Name = "txtEffectiveDate";
    this.txtEffectiveDate.Style = "ddo-char-set: 0";
    this.txtEffectiveDate.Text = "EffectiveDate";
    ((ARControl) this.txtEffectiveDate).Top = 2.625f;
    ((ARControl) this.txtEffectiveDate).Width = 1.625f;
    ((ARControl) this.txtCompany).DataField = "companyname";
    ((ARControl) this.txtCompany).Height = 3f / 16f;
    ((ARControl) this.txtCompany).Left = 0.875f;
    ((ARControl) this.txtCompany).Name = "txtCompany";
    this.txtCompany.Style = "ddo-char-set: 0";
    this.txtCompany.Text = (string) null;
    ((ARControl) this.txtCompany).Top = 3.5f;
    ((ARControl) this.txtCompany).Width = 3f;
    ((ARControl) this.Label1).Height = 3f / 16f;
    this.Label1.HyperLink = (string) null;
    ((ARControl) this.Label1).Left = 4.375f;
    ((ARControl) this.Label1).Name = "Label1";
    this.Label1.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.Label1.Text = "Invoice Date:";
    ((ARControl) this.Label1).Top = 2.25f;
    ((ARControl) this.Label1).Width = 1f;
    ((ARControl) this.txtRemitterAddressName).DataField = "RemitterName";
    ((ARControl) this.txtRemitterAddressName).Height = 5f / 16f;
    ((ARControl) this.txtRemitterAddressName).Left = 0.125f;
    ((ARControl) this.txtRemitterAddressName).Name = "txtRemitterAddressName";
    this.txtRemitterAddressName.Style = "text-align: center; vertical-align: bottom; ddo-char-set: 0";
    this.txtRemitterAddressName.Text = "Remitter Name";
    ((ARControl) this.txtRemitterAddressName).Top = 27f / 16f;
    ((ARControl) this.txtRemitterAddressName).Width = 2.875f;
    ((ARControl) this.lblPolicyNum).Height = 3f / 16f;
    this.lblPolicyNum.HyperLink = (string) null;
    ((ARControl) this.lblPolicyNum).Left = 1f / 16f;
    ((ARControl) this.lblPolicyNum).Name = "lblPolicyNum";
    this.lblPolicyNum.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblPolicyNum.Text = "Policy #:";
    ((ARControl) this.lblPolicyNum).Top = 3.125f;
    ((ARControl) this.lblPolicyNum).Width = 13f / 16f;
    ((ARControl) this.txtPolicyNumber).DataField = "policyNumber";
    ((ARControl) this.txtPolicyNumber).Height = 3f / 16f;
    ((ARControl) this.txtPolicyNumber).Left = 0.875f;
    ((ARControl) this.txtPolicyNumber).Name = "txtPolicyNumber";
    this.txtPolicyNumber.Style = "ddo-char-set: 0";
    this.txtPolicyNumber.Text = (string) null;
    ((ARControl) this.txtPolicyNumber).Top = 3.125f;
    ((ARControl) this.txtPolicyNumber).Width = 3f;
    ((ARControl) this.lblInvoiceType).Height = 3f / 16f;
    this.lblInvoiceType.HyperLink = (string) null;
    ((ARControl) this.lblInvoiceType).Left = 4.375f;
    ((ARControl) this.lblInvoiceType).Name = "lblInvoiceType";
    this.lblInvoiceType.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.lblInvoiceType.Text = "Invoice Type:";
    ((ARControl) this.lblInvoiceType).Top = 1.875f;
    ((ARControl) this.lblInvoiceType).Width = 19f / 16f;
    ((ARControl) this.txtInvoiceType).DataField = "INVOICETYPE";
    ((ARControl) this.txtInvoiceType).Height = 3f / 16f;
    ((ARControl) this.txtInvoiceType).Left = 89f / 16f;
    ((ARControl) this.txtInvoiceType).Name = "txtInvoiceType";
    this.txtInvoiceType.Style = "ddo-char-set: 0";
    this.txtInvoiceType.Text = "ERROR";
    ((ARControl) this.txtInvoiceType).Top = 1.875f;
    ((ARControl) this.txtInvoiceType).Width = 23f / 16f;
    ((ARControl) this.textBox2).DataField = "PolicyType";
    ((ARControl) this.textBox2).Height = 3f / 16f;
    ((ARControl) this.textBox2).Left = 5.375f;
    ((ARControl) this.textBox2).Name = "textBox2";
    this.textBox2.Style = "ddo-char-set: 0";
    this.textBox2.Text = (string) null;
    ((ARControl) this.textBox2).Top = 45f / 16f;
    ((ARControl) this.textBox2).Width = 1.625f;
    ((ARControl) this.label2).Height = 3f / 16f;
    this.label2.HyperLink = (string) null;
    ((ARControl) this.label2).Left = 4.375f;
    ((ARControl) this.label2).Name = "label2";
    this.label2.Style = "font-size: 9.75pt; font-weight: bold; ddo-char-set: 0";
    this.label2.Text = "Policy Type:";
    ((ARControl) this.label2).Top = 45f / 16f;
    ((ARControl) this.label2).Width = 1f;
    ((ARControl) this.Line1).Height = 0.0f;
    ((ARControl) this.Line1).Left = 1f / 16f;
    this.Line1.LineWeight = 1f;
    ((ARControl) this.Line1).Name = "Line1";
    ((ARControl) this.Line1).Top = 1.625f;
    ((ARControl) this.Line1).Width = 3f / 16f;
    this.Line1.X1 = 1f / 16f;
    this.Line1.X2 = 0.25f;
    this.Line1.Y1 = 1.625f;
    this.Line1.Y2 = 1.625f;
    ((ARControl) this.Line).Height = 3f / 16f;
    ((ARControl) this.Line).Left = 1f / 16f;
    this.Line.LineWeight = 1f;
    ((ARControl) this.Line).Name = "Line";
    ((ARControl) this.Line).Top = 1.625f;
    ((ARControl) this.Line).Width = 0.0f;
    this.Line.X1 = 1f / 16f;
    this.Line.X2 = 1f / 16f;
    this.Line.Y1 = 29f / 16f;
    this.Line.Y2 = 1.625f;
    ((ARControl) this.Line2).Height = 3f / 16f;
    ((ARControl) this.Line2).Left = 1f / 16f;
    this.Line2.LineWeight = 1f;
    ((ARControl) this.Line2).Name = "Line2";
    ((ARControl) this.Line2).Top = 2.75f;
    ((ARControl) this.Line2).Width = 0.0f;
    this.Line2.X1 = 1f / 16f;
    this.Line2.X2 = 1f / 16f;
    this.Line2.Y1 = 47f / 16f;
    this.Line2.Y2 = 2.75f;
    ((ARControl) this.Line3).Height = 0.0f;
    ((ARControl) this.Line3).Left = 1f / 16f;
    this.Line3.LineWeight = 1f;
    ((ARControl) this.Line3).Name = "Line3";
    ((ARControl) this.Line3).Top = 47f / 16f;
    ((ARControl) this.Line3).Width = 3f / 16f;
    this.Line3.X1 = 1f / 16f;
    this.Line3.X2 = 0.25f;
    this.Line3.Y1 = 47f / 16f;
    this.Line3.Y2 = 47f / 16f;
    ((ARControl) this.Line5).Height = 0.0f;
    ((ARControl) this.Line5).Left = 2.875f;
    this.Line5.LineWeight = 1f;
    ((ARControl) this.Line5).Name = "Line5";
    ((ARControl) this.Line5).Top = 1.625f;
    ((ARControl) this.Line5).Width = 3f / 16f;
    this.Line5.X1 = 2.875f;
    this.Line5.X2 = 49f / 16f;
    this.Line5.Y1 = 1.625f;
    this.Line5.Y2 = 1.625f;
    ((ARControl) this.Line6).Height = 3f / 16f;
    ((ARControl) this.Line6).Left = 49f / 16f;
    this.Line6.LineWeight = 1f;
    ((ARControl) this.Line6).Name = "Line6";
    ((ARControl) this.Line6).Top = 1.625f;
    ((ARControl) this.Line6).Width = 0.0f;
    this.Line6.X1 = 49f / 16f;
    this.Line6.X2 = 49f / 16f;
    this.Line6.Y1 = 29f / 16f;
    this.Line6.Y2 = 1.625f;
    ((ARControl) this.Line8).Height = 3f / 16f;
    ((ARControl) this.Line8).Left = 49f / 16f;
    this.Line8.LineWeight = 1f;
    ((ARControl) this.Line8).Name = "Line8";
    ((ARControl) this.Line8).Top = 2.75f;
    ((ARControl) this.Line8).Width = 0.0f;
    this.Line8.X1 = 49f / 16f;
    this.Line8.X2 = 49f / 16f;
    this.Line8.Y1 = 47f / 16f;
    this.Line8.Y2 = 2.75f;
    ((ARControl) this.Line7).Height = 0.0f;
    ((ARControl) this.Line7).Left = 2.875f;
    this.Line7.LineWeight = 1f;
    ((ARControl) this.Line7).Name = "Line7";
    ((ARControl) this.Line7).Top = 47f / 16f;
    ((ARControl) this.Line7).Width = 3f / 16f;
    this.Line7.X1 = 2.875f;
    this.Line7.X2 = 49f / 16f;
    this.Line7.Y1 = 47f / 16f;
    this.Line7.Y2 = 47f / 16f;
    this.reportFooter1.Height = 0.0f;
    ((Section) this.reportFooter1).Name = "reportFooter1";
    this.MasterReport = false;
    this.PageSettings.Margins.Bottom = 0.3f;
    this.PageSettings.Margins.Left = 0.3f;
    this.PageSettings.Margins.Right = 0.3f;
    this.PageSettings.Margins.Top = 0.3f;
    this.PageSettings.PaperHeight = 11f;
    this.PageSettings.PaperWidth = 8.5f;
    this.PrintWidth = 7.9f;
    this.Sections.Add((Section) this.reportHeader1);
    this.Sections.Add((Section) this.pageHeader);
    this.Sections.Add((Section) this.detail);
    this.Sections.Add((Section) this.pageFooter);
    this.Sections.Add((Section) this.reportFooter1);
    this.StyleSheet.Add(new StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; color: Black", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: italic", "Heading2", "Normal"));
    this.StyleSheet.Add(new StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"));
    ((ISupportInitialize) this.TextBox).EndInit();
    ((ISupportInitialize) this.Label).EndInit();
    ((ISupportInitialize) this.lblInvoiceCopy).EndInit();
    ((ISupportInitialize) this.txtInvoiceNumber).EndInit();
    ((ISupportInitialize) this.txtClientOfficeNameAddress).EndInit();
    ((ISupportInitialize) this.txtCurrentDate).EndInit();
    ((ISupportInitialize) this.txtRemitterInformation).EndInit();
    ((ISupportInitialize) this.lblRE).EndInit();
    ((ISupportInitialize) this.lblCompany).EndInit();
    ((ISupportInitialize) this.txtRe).EndInit();
    ((ISupportInitialize) this.lblUnderwriter).EndInit();
    ((ISupportInitialize) this.txtUnderwriterName).EndInit();
    ((ISupportInitialize) this.lblEffectiveDate).EndInit();
    ((ISupportInitialize) this.txtEffectiveDate).EndInit();
    ((ISupportInitialize) this.txtCompany).EndInit();
    ((ISupportInitialize) this.Label1).EndInit();
    ((ISupportInitialize) this.txtRemitterAddressName).EndInit();
    ((ISupportInitialize) this.lblPolicyNum).EndInit();
    ((ISupportInitialize) this.txtPolicyNumber).EndInit();
    ((ISupportInitialize) this.lblInvoiceType).EndInit();
    ((ISupportInitialize) this.txtInvoiceType).EndInit();
    ((ISupportInitialize) this.textBox2).EndInit();
    ((ISupportInitialize) this.label2).EndInit();
    ((ISupportInitialize) this).EndInit();
  }
}
