// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.PolicyServices.formPolicyInquiry
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using CancellationNotices;
using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Export.Pdf.Section;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinTabs;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.BroadcastMessaging;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Reports.AccountsPayable;
using MGASystems.IMS.Accounting.SharedForms;
using MGASystems.IMS.NoteDocuments;
using MGASystems.IMS.NoteDocuments.DocumentSystem;
using MGASystems.IMS.NoteDocuments.NoteDiarySystem;
using MGASystems.IMS.Reporting;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.PolicyServices;

[DocumentFolderFilter("Accounting-Policy Inquiry")]
[SecureResource("{515B1DDA-7681-4739-9A5A-58253EB463F5}", "Policy Inquiry-View Invoice Activity/Accounting Notes Rights", "Determines whether or not the user can view the invoice activity and accounting notes in accounting policy inquiry.", "Accounting")]
[SecureResource("{16C4CBCA-7EDE-411D-A697-014313B0F4BA}", "Policy Inquiry-Reinstate Policy Rights", "Determines whether or not the user can reinstate a policy from within the policy inquiry screen.", "Accounting")]
[SecureResource("{26BCD36F-B9A5-43AC-8AA4-A0968C0C1984}", "Policy Inquiry-Manual NOC Rights", "Determines whether or not the user can issue a manual NOC for non-payment from within the policy inquiry screen.", "Accounting")]
[SecureResource("{16BEA76B-5F19-4B0C-A8C3-61CAD052E843}", "Policy Inquiry-View Invoice Rights", "Determines whether or not the user can view invoices from within the policy inquiry screen.", "Accounting")]
[SecureResource("{D31A5BA4-8991-4F6A-8DA1-0144565BB1AD}", "Policy Inquiry-Reprint NOC/Reinstatement Notices Rights", "Determines whether or not the user can reprint NOC/Reinstatement notices from within the policy inquiry screen.", "Accounting")]
[SecureResource("{C728610C-7B96-4779-99BC-934C791E05BF}", "Policy Inquiry-View Invoice Payee Rights", "Determines whether or not the user can view invoice payee information from within the policy inquiry screen.", "Accounting")]
[SecureResource("{EFC403E9-855D-43E0-8068-FD2AA7E813CF}", "Policy Inquiry-Force Commission Rights", "Determines whether or not the user can force the commission recognition of an invoice/transaction.", "Accounting")]
[SecureResource("{7F7A3D9F-DBC1-4910-BAC2-F70326E6D7B4}", "Policy Inquiry-Print Policy Inquiry Rights", "Determines whether or not the user can print NOC/Reinstatement notices from within the policy inquiry screen.", "Accounting")]
public class formPolicyInquiry : Form, ISupportDocumentSystem, IRecreatableEntity, ISupportNoteSystem
{
  protected int quoteControlNumber;
  protected int glCompanyId;
  protected Quote quoteObject;
  protected bool firstActivation = true;
  private Dictionary<int, int> _controlNumberLog = new Dictionary<int, int>();
  private KeyValuePair<int, int> _cLog;
  private int _logPosition;
  private readonly DateTime minDate = new DateTime(1900, 1, 1);
  public SqlDataAdapter daPolicyInquiryInvoicePremiumLines;
  public SqlCommand SqlSelectCommand6;
  public SqlConnection FormDataConnection;
  public SqlDataAdapter daPolicyInquiryHeader;
  public SqlCommand SqlSelectCommand1;
  public ImageList ImageList1;
  public SqlDataAdapter daPolicyInquiryPolicyStatus;
  public SqlCommand SqlSelectCommand2;
  protected UltraToolbarsManager UltraToolbarsManager1;
  public Panel panelPolicyInquiry2;
  public UltraTabControl UltraTabControl1;
  public UltraTabSharedControlsPage UltraTabSharedControlsPage1;
  public UltraTabPageControl UltraTabPageControl1;
  public EllipsePanel ElipsePanel1;
  public UltraGrid gridStatusChanges;
  public Label Label25;
  public UltraTabPageControl UltraTabPageControl2;
  public EllipsePanel panelInvoiceActivity;
  public EllipsePanel panelInvoiceActivityCurtain;
  public Label Label8;
  public Label Label7;
  public Label Label2;
  public CheckBox chkShowVoids;
  public UltraTabControl utcInvoiceActivity;
  public UltraTabSharedControlsPage UltraTabSharedControlsPage2;
  public UltraTabPageControl UltraTabPageControl3;
  public Label lblInvoiceDueDate;
  public Label Label37;
  public EllipsePanel ElipsePanel3;
  public Label Label33;
  public Label lblNetDueCalculation;
  public Label lblFeesCalculation;
  public Label Label35;
  public Label lblPremiumCalculation;
  public Label lblBrokerCommissionCalculation;
  public Label Label17;
  public Label Label24;
  public Label Label31;
  public Label Label29;
  public Label Label21;
  public UltraGrid gridInvoiceFeeLines;
  public UltraGrid gridInvoicePremiumLines;
  public Label lblDueCompany;
  public Label Label34;
  public Label lblInvoiceBrokerCommission;
  public Label Label32;
  public Label lblInvoiceGrossCommission;
  public Label Label30;
  public Label Label28;
  public Label lblEndorsementNumber;
  public Label Label26;
  public Label lblInvoiceDateBilled;
  public Label Label14;
  public Label lblInvoiceExpirationDate;
  public Label Label18;
  public Label lblInvoiceEffectiveDate;
  public Label Label20;
  public Label Label9;
  public Label Label27;
  public UltraTabPageControl UltraTabPageControl4;
  public UltraGrid gridInvoiceActivity;
  public EllipsePanel ElipsePanel2;
  public UltraTabPageControl UltraTabPageControl5;
  public EllipsePanel panelCurtain;
  public Label Label5;
  public Label Label4;
  public Label Label1;
  internal UltraToolbarsDockArea _panelPolicyInquiry2_Toolbars_Dock_Area_Left;
  internal UltraToolbarsDockArea _panelPolicyInquiry2_Toolbars_Dock_Area_Right;
  internal UltraToolbarsDockArea _panelPolicyInquiry2_Toolbars_Dock_Area_Top;
  internal UltraToolbarsDockArea _panelPolicyInquiry2_Toolbars_Dock_Area_Bottom;
  public SqlDataAdapter daPolicyInquiryInvoices;
  public SqlCommand SqlSelectCommand3;
  public SqlDataAdapter daPolicyInquiryInvoiceDetails;
  public SqlCommand SqlSelectCommand5;
  public SqlDataAdapter daPolicyInquiryInvoiceActivity;
  public SqlCommand SqlSelectCommand4;
  public SqlCommand SqlSelectCommand8;
  public SqlDataAdapter daPolicyInquiryCancellationInformation;
  public SqlCommand SqlSelectCommand7;
  public SqlDataAdapter daPolicyInquiryInvoiceFeeLines;
  public EllipsePanel ellipsePanel1;
  public Label label36;
  public UltraGrid UltraGrid1;
  public UltraGrid ultraGrid2;
  public UltraGrid gridPolicyInquiryComments;
  public SqlDataAdapter daGetPolicyInquiryComments;
  public SqlCommand sqlSelectCommand9;
  private TransactionCommentsViewer transactionCommentsViewer1;
  public SqlDataAdapter daPolicyInquiryReinstatementInformation;
  public SqlCommand sqlSelectCommand10;
  public LinkLabel linkChangeBillDate;
  public LinkLabel linkChangeDueDate;
  public Panel panelChangeDueDate;
  public MGAGroupBox mgaGroupBox1;
  public Label label38;
  public MGAButton buttonCloseChangeDueDate;
  public MGAButton buttonSaveDueDate;
  public Panel panelChangeBillDate;
  public MGAButton buttonCloseChangeBillDate;
  public MGAGroupBox mgaGroupBox2;
  public Label label39;
  public MGADateTimePicker dateNewDueDate;
  public MGADateTimePicker dateNewBillDate;
  public MGAButton buttonSaveChangeBillDate;
  public Panel panelChangeTransactionDate;
  public MGAButton buttonCloseChangeTransactionDate;
  public MGAGroupBox mgaGroupBox3;
  public MGAButton buttonSaveTransactionDate;
  public MGADateTimePicker dateTimeNewTransactionDate;
  public Label label40;
  public LinkLabel linkChangeTransactionDate;
  private TransactionCommentsViewer transactionCommentsViewer2;
  public UltraTabControl ultraTabControl4;
  public UltraTabSharedControlsPage ultraTabSharedControlsPage5;
  public UltraTabPageControl ultraTabPageControl8;
  public UltraGrid gridInvoiceListing;
  public UltraTabPageControl ultraTabPageControl9;
  public UltraGrid gridPolicyActivity;
  public UltraTabControl ultraTabControl2;
  public UltraTabSharedControlsPage ultraTabSharedControlsPage3;
  public UltraTabPageControl ultraTabPageControl6;
  public EllipsePanel ellipsePanel2;
  public UltraGrid ultraGrid3;
  public UltraGrid ultraGrid4;
  public Label label60;
  public EllipsePanel ellipsePanel3;
  public UltraGrid ultraGrid5;
  public Label label61;
  public CheckBox checkBox1;
  public Label label41;
  public Label label42;
  public Label label43;
  public Label label44;
  public Label label45;
  public Label label46;
  public Label label47;
  public Label label48;
  public Label label49;
  public Label label50;
  public Label label51;
  public Label label52;
  public Label label53;
  public Label label54;
  public Label label55;
  public Label label56;
  public Label label57;
  public Label label58;
  public Label label59;
  public UltraTabPageControl ultraTabPageControl7;
  public EllipsePanel ellipsePanel4;
  public UltraGrid ultraGrid6;
  public Label label62;
  public EllipsePanel ellipsePanel5;
  public EllipsePanel ellipsePanel6;
  public Label label63;
  public Label label64;
  public Label label65;
  public CheckBox checkBox2;
  public UltraTabControl ultraTabControl3;
  public UltraTabSharedControlsPage ultraTabSharedControlsPage4;
  public SqlDataAdapter daPolicyInquiryPolicyActivity;
  public SqlCommand sqlCommand1;
  public dsPolicyInformation dsPolicyInformation1;
  public InvoicePayeeBreakout invoicePayeeBreakout1;
  private ToolTip toolTip1;
  public Label lblCostCenter;
  public Label label66;
  public CheckBox checkDisableNOC;
  public Label labelOfficeLocation;
  public Label label69;
  public Label lblBillingType;
  public Label label67;
  public Label labelCurrency;
  public Label label68;
  public Label lblCurrentStatus;
  public Label Label19;
  public Label Label15;
  public Label lblExpirationDate;
  public Label Label11;
  public Label lblControlNumber;
  public Label Label23;
  public Label lblUnderwriter;
  public Label Label22;
  public Label lblCompany;
  public Label lblProducer;
  public Label lblEffectiveDate;
  public Label lblInsured;
  public Label lblPolicyNumber;
  public Label Label13;
  public Label Label12;
  public Label Label10;
  public Label Label6;
  public Label Label3;
  private IContainer components;

  public formPolicyInquiry() => this.InitializeComponent();

  public formPolicyInquiry(int controlNumber, int glCompanyId)
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.quoteControlNumber = controlNumber;
    this.glCompanyId = glCompanyId;
    this.firstActivation = false;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void SetFormPermissions()
  {
    if (this.DesignMode)
      return;
    this.linkChangeBillDate.Visible = SecurityManager.Instance.AssertPermission("{7554946B-BE1A-40dc-ADDE-39DFED664F8A}");
    this.linkChangeDueDate.Visible = SecurityManager.Instance.AssertPermission("{90D526A0-268E-4a6b-8BFC-ABF743361AA4}");
    this.linkChangeTransactionDate.Visible = SecurityManager.Instance.AssertPermission("{5AE7C614-A609-4ab5-A960-171E18062414}");
  }

  protected RowsCollection InvoiceListingRows => ((UltraGridBase) this.gridInvoiceListing).Rows;

  protected virtual void ShowPolicy(int quoteControlNumber)
  {
    this.quoteObject = new Quote(DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "Select top 1 quoteId from tblQuotes q\n                    INNER JOIN dbo.tblMaxQuoteIDs mx ON mx.ControlNo = q.ControlNo AND mx.MaxBoundQuoteID = q.QuoteID\n                    WHERE q.controlNo = @cn order by quoteid desc", new object[2]
    {
      (object) "@cn",
      (object) quoteControlNumber
    }));
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.Cursor = Cursors.WaitCursor;
    this.daPolicyInquiryHeader.SelectCommand.Parameters["@controlno"].Value = (object) quoteControlNumber;
    this.dsPolicyInformation1.PolicyHeader.Clear();
    this.daPolicyInquiryHeader.Fill((DataTable) this.dsPolicyInformation1.PolicyHeader);
    this.daPolicyInquiryPolicyStatus.SelectCommand.Parameters["@controlno"].Value = (object) quoteControlNumber;
    this.dsPolicyInformation1.PolicyStatusChanges.Clear();
    this.daPolicyInquiryPolicyStatus.Fill((DataTable) this.dsPolicyInformation1.PolicyStatusChanges);
    this.daPolicyInquiryInvoices.SelectCommand.Parameters["@controlno"].Value = (object) quoteControlNumber;
    this.dsPolicyInformation1.PolicyInvoices.Clear();
    this.daPolicyInquiryInvoices.Fill((DataTable) this.dsPolicyInformation1.PolicyInvoices);
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridInvoiceListing).Layouts).Count > 0)
      ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Load(((UltraGridBase) this.gridInvoiceListing).Layouts[0], (PropertyCategories) -1);
    if (this.dsPolicyInformation1.PolicyInvoices.Count != 0 && ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridInvoiceListing).Rows).Count != 0)
    {
      ((GridItemBase) ((UltraGridBase) this.gridInvoiceListing).Rows[0]).Selected = true;
      this.gridInvoiceListing.Selected.Rows[0].Activate();
      this.LoadInvoiceDetails(int.Parse(this.gridInvoiceListing.Selected.Rows[0].Cells["invoicenum"].Value.ToString()));
    }
    this.daPolicyInquiryPolicyActivity.SelectCommand.Parameters["@controlNumber"].Value = (object) quoteControlNumber;
    this.dsPolicyInformation1.PolicyActivity.Clear();
    this.daPolicyInquiryPolicyActivity.Fill((DataTable) this.dsPolicyInformation1.PolicyActivity);
    this.daPolicyInquiryCancellationInformation.SelectCommand.Parameters["@controlno"].Value = (object) quoteControlNumber;
    this.dsPolicyInformation1.CancellationInformation.Clear();
    this.daPolicyInquiryCancellationInformation.Fill((DataTable) this.dsPolicyInformation1.CancellationInformation);
    this.daPolicyInquiryReinstatementInformation.SelectCommand.Parameters["@quoteid"].Value = (object) this.quoteObject.QuoteID;
    this.dsPolicyInformation1.ReinstatementInformation.Clear();
    this.daPolicyInquiryReinstatementInformation.Fill((DataTable) this.dsPolicyInformation1.ReinstatementInformation);
    this.LoadPolicyInquiryComments();
    this.DisplayHeader();
    this.BuildInvoiceSummaryLine();
    if (this.EntityInfoChanged != null)
      this.EntityInfoChanged((object) this, EventArgs.Empty);
    if (this.NoteEntityInfoChanged != null)
      this.NoteEntityInfoChanged((object) this, EventArgs.Empty);
    this.panelCurtain.Visible = false;
    this.Cursor = Cursors.Default;
  }

  private void DisplayHeader()
  {
    if (this.dsPolicyInformation1.PolicyHeader.Rows.Count == 0)
      return;
    dsPolicyInformation.PolicyHeaderRow row = (dsPolicyInformation.PolicyHeaderRow) this.dsPolicyInformation1.PolicyHeader.Rows[0];
    this.lblPolicyNumber.Text = row.PolicyNumber;
    this.lblInsured.Text = row.Insured;
    this.lblEffectiveDate.Text = row.EffectiveDate.ToString("d");
    this.lblExpirationDate.Text = row.ExpirationDate.ToString("d");
    this.lblCompany.Text = row.Company;
    this.lblProducer.Text = row.Producer;
    this.lblUnderwriter.Text = row.Underwriter;
    this.lblControlNumber.Text = row.ControlNumber.ToString();
    this.lblCostCenter.Text = row.CostCenter;
    this.labelCurrency.Text = row.CurrencyCode;
    this.checkDisableNOC.CheckedChanged -= new EventHandler(this.checkDisableNOC_CheckedChanged);
    this.labelOfficeLocation.Text = row.IsOfficeLocationNull() ? string.Empty : row.OfficeLocation;
    if (!row.IsIsNocDisabledNull())
      this.checkDisableNOC.Checked = bool.Parse(row.IsNocDisabled.ToString());
    this.checkDisableNOC.CheckedChanged += new EventHandler(this.checkDisableNOC_CheckedChanged);
    this.lblBillingType.Text = row.IsBillingTypeNull() ? string.Empty : row.BillingType;
    string displayStatus = this.quoteObject?.DisplayStatus;
    this.lblCurrentStatus.Text = !string.IsNullOrEmpty(displayStatus) ? displayStatus : "Un-Determined";
    this.SetFinanceInfoToolbarLabel();
  }

  protected virtual void SetFinanceInfoToolbarLabel()
  {
    if (!(((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["FINANCEINFO"] is LabelTool tool))
      return;
    if (!string.IsNullOrEmpty(this.dsPolicyInformation1.PolicyHeader[0].FinanceCompanyName))
    {
      ((ToolPropsBase) ((ToolBase) tool).SharedProps).Caption = this.dsPolicyInformation1.PolicyHeader[0].FinanceCompanyName;
      if (string.IsNullOrEmpty(this.dsPolicyInformation1.PolicyHeader[0].FinanceCompanyAccountNumber))
        return;
      ((ToolPropsBase) ((ToolBase) tool).SharedProps).Caption = ((ToolPropsBase) ((ToolBase) tool).SharedProps).Caption + Environment.NewLine + this.dsPolicyInformation1.PolicyHeader[0].FinanceCompanyAccountNumber;
    }
    else
      ((ToolPropsBase) ((ToolBase) tool).SharedProps).Caption = string.Empty;
  }

  private void BuildInvoiceSummaryLine()
  {
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Summaries.Clear();
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Summaries.Add("GrossBilledSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Columns["grossbilled"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Summaries.Add("CommissionSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Columns["commission"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Summaries.Add("PremiumSumm", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Columns["premium"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Summaries.Add("FeesSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Columns["fees"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Summaries.Add("APBalanceSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Columns["apbalance"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Summaries.Add("ARBalanceSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Columns["arbalance"], (SummaryPosition) 3);
    foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Bands[0].Summaries)
    {
      summary.Appearance.TextHAlign = (HAlign) 3;
      summary.DisplayFormat = "{0:c}";
    }
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Load(((UltraGridBase) this.gridInvoiceListing).Layouts[0], (PropertyCategories) -1);
  }

  protected virtual void ClearScreen()
  {
    this.lblPolicyNumber.Text = string.Empty;
    this.lblInsured.Text = string.Empty;
    this.lblEffectiveDate.Text = string.Empty;
    this.lblExpirationDate.Text = string.Empty;
    this.lblCompany.Text = string.Empty;
    this.lblProducer.Text = string.Empty;
    this.lblUnderwriter.Text = string.Empty;
    this.lblControlNumber.Text = string.Empty;
    this.dsPolicyInformation1.Clear();
    this.panelInvoiceActivityCurtain.Visible = true;
    this.panelCurtain.Visible = true;
    this.panelCurtain.BringToFront();
    ((UltraTabControlBase) this.UltraTabControl1).SelectedTab = ((UltraTabControlBase) this.UltraTabControl1).Tabs[0];
    ((UltraTabControlBase) this.utcInvoiceActivity).SelectedTab = ((UltraTabControlBase) this.utcInvoiceActivity).Tabs[0];
    this.invoicePayeeBreakout1.Clear();
  }

  protected virtual void LoadInvoiceDetails(int invoiceNumber)
  {
    this.daPolicyInquiryInvoiceDetails.SelectCommand.Parameters["@invoiceNum"].Value = (object) invoiceNumber;
    this.dsPolicyInformation1.InvoiceDetail.Clear();
    this.daPolicyInquiryInvoiceDetails.Fill((DataTable) this.dsPolicyInformation1.InvoiceDetail);
    this.daPolicyInquiryInvoicePremiumLines.SelectCommand.Parameters["@invoiceNum"].Value = (object) invoiceNumber;
    this.dsPolicyInformation1.InvoicePremiumLines.Clear();
    this.daPolicyInquiryInvoicePremiumLines.Fill((DataTable) this.dsPolicyInformation1.InvoicePremiumLines);
    this.daPolicyInquiryInvoiceFeeLines.SelectCommand.Parameters["@invoiceNum"].Value = (object) invoiceNumber;
    this.dsPolicyInformation1.InvoiceFeeLines.Clear();
    this.daPolicyInquiryInvoiceFeeLines.Fill((DataTable) this.dsPolicyInformation1.InvoiceFeeLines);
    if (this.dsPolicyInformation1.InvoiceDetail.Rows.Count == 0)
      return;
    dsPolicyInformation.InvoiceDetailRow row = (dsPolicyInformation.InvoiceDetailRow) this.dsPolicyInformation1.InvoiceDetail.Rows[0];
    this.lblInvoiceDueDate.Text = row.DueDate.ToString("d");
    this.lblEndorsementNumber.Text = row.EndorsementNumber.ToString();
    Label invoiceEffectiveDate = this.lblInvoiceEffectiveDate;
    DateTime dateTime = row.EffectiveDate;
    string str1 = dateTime.ToString("d");
    invoiceEffectiveDate.Text = str1;
    Label invoiceExpirationDate = this.lblInvoiceExpirationDate;
    dateTime = row.ExpirationDate;
    string str2 = dateTime.ToString("d");
    invoiceExpirationDate.Text = str2;
    Label invoiceDateBilled = this.lblInvoiceDateBilled;
    dateTime = this.minDate;
    string str3;
    if (!dateTime.Equals(row.DateBilled))
    {
      dateTime = row.DateBilled;
      str3 = dateTime.ToString("d");
    }
    else
      str3 = "";
    invoiceDateBilled.Text = str3;
    Label lblDueCompany = this.lblDueCompany;
    dateTime = row.DueCompany;
    string str4 = dateTime.ToString("d");
    lblDueCompany.Text = str4;
    this.lblInvoiceBrokerCommission.Text = row.BrokerCommission.ToString() + "%";
    this.lblInvoiceGrossCommission.Text = row.GrossCommission.ToString() + "%";
    this.BuildInvoicePremiumFeeSummaries();
    this.CreateInvoiceCalculation();
  }

  private void BuildInvoicePremiumFeeSummaries()
  {
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Bands[0].Summaries.Clear();
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Bands[0].Summaries.Add("AmountSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Bands[0].Columns["amount"], (SummaryPosition) 3);
    foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Bands[0].Summaries)
    {
      summary.Appearance.TextHAlign = (HAlign) 3;
      summary.DisplayFormat = "{0:c}";
    }
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Load(((UltraGridBase) this.gridInvoicePremiumLines).Layouts[0], (PropertyCategories) -1);
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Bands[0].Summaries.Clear();
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Bands[0].Summaries.Add("AmountSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Bands[0].Columns["amount"], (SummaryPosition) 3);
    foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Bands[0].Summaries)
    {
      summary.Appearance.TextHAlign = (HAlign) 3;
      summary.DisplayFormat = "{0:c}";
    }
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Load(((UltraGridBase) this.gridInvoiceFeeLines).Layouts[0], (PropertyCategories) -1);
  }

  private void CreateInvoiceCalculation()
  {
    Decimal num1 = 0M;
    Decimal num2 = 0M;
    Decimal num3 = 0M;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridInvoicePremiumLines).Rows)
      num1 += Decimal.Parse(row.Cells["amount"].Value.ToString(), NumberStyles.Currency);
    foreach (UltraGridRow row in ((UltraGridBase) this.gridInvoiceFeeLines).Rows)
      num2 += Decimal.Parse(row.Cells["amount"].Value.ToString(), NumberStyles.Currency);
    this.lblPremiumCalculation.Text = num1.ToString("c");
    if (this.dsPolicyInformation1.InvoiceDetail.Columns.Contains("feeamt"))
      num3 = Decimal.Parse(this.dsPolicyInformation1.InvoiceDetail.Rows[0]["feeamt"].ToString());
    this.lblBrokerCommissionCalculation.Text = ((num1 + num3) * (Decimal.Parse(this.dsPolicyInformation1.InvoiceDetail.Rows[0]["BrokerCommission"].ToString(), NumberStyles.Currency) / 100M)).ToString("c");
    this.lblFeesCalculation.Text = num2.ToString("c");
    this.lblNetDueCalculation.Text = (num1 - Decimal.Parse(this.lblBrokerCommissionCalculation.Text, NumberStyles.Currency) + num2).ToString("c");
  }

  protected virtual void GetInvoiceActivity(int invoiceNumber)
  {
    this.daPolicyInquiryInvoiceActivity.SelectCommand.Parameters["@invoiceNum"].Value = (object) invoiceNumber;
    this.dsPolicyInformation1.InvoiceActivity.Clear();
    this.daPolicyInquiryInvoiceActivity.Fill((DataTable) this.dsPolicyInformation1.InvoiceActivity);
    this.BuildInvoicesActivitySummaryLine();
    this.panelInvoiceActivityCurtain.Visible = false;
    this.ToggleShowVoids();
  }

  private void ToggleShowVoids()
  {
    if (this.chkShowVoids.Checked)
    {
      ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].ColumnFilters["voided"].FilterConditions.Clear();
      ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].ColumnFilters["transdescription"].FilterConditions.Clear();
    }
    else
    {
      ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].ColumnFilters["voided"].Column.AllowRowFiltering = (DefaultableBoolean) 1;
      ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Override.RowFilterMode = (RowFilterMode) 1;
      ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].ColumnFilters["voided"].FilterConditions.Add((FilterComparisionOperator) 0, (object) false);
      ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].ColumnFilters["transdescription"].FilterConditions.Add((FilterComparisionOperator) 1, (object) "Void");
    }
  }

  private void BuildInvoicesActivitySummaryLine()
  {
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Summaries.Clear();
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Summaries.Add("ARSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Columns["arapplied"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Summaries.Add("APSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Columns["apapplied"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Summaries.Add("EXCHSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Columns["exchApplied"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Summaries.Add("UNACCTSum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Columns["unacctapplied"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Summaries.Add("INCOMESum", (SummaryType) 1, ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Columns["incomeapplied"], (SummaryPosition) 3);
    foreach (SummarySettings summary in (IEnumerable) ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Bands[0].Summaries)
    {
      summary.Appearance.TextHAlign = (HAlign) 3;
      summary.DisplayFormat = "{0:c}";
    }
  }

  protected virtual void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key == null)
      return;
    switch (key.Length)
    {
      case 5:
        switch (key[0])
        {
          case 'C':
            if (!(key == "CLEAR"))
              return;
            this.ClearScreen();
            return;
          case 'P':
            if (!(key == "PRINT"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{7F7A3D9F-DBC1-4910-BAC2-F70326E6D7B4}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            this.PrintPolicyInquiryReport();
            return;
          default:
            return;
        }
      case 6:
        if (!(key == "CANCEL"))
          break;
        if (!SecurityManager.Instance.AssertPermission("{26BCD36F-B9A5-43AC-8AA4-A0968C0C1984}"))
        {
          using (formAccessDenied formAccessDenied = new formAccessDenied())
          {
            int num = (int) formAccessDenied.ShowDialog();
            break;
          }
        }
        if (DateTime.Now.Date > this.quoteObject.ExpirationDate.Date)
        {
          int num = (int) MessageBox.Show("The policy has expired and can not be put under notice of cancellation.", "Policy Is Expired!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          break;
        }
        this.CancelPolicy();
        break;
      case 7:
        if (!(key == "REFRESH"))
          break;
        this.RefreshScreen();
        break;
      case 9:
        switch (key[0])
        {
          case 'F':
            if (!(key == "FORCECOMM") || !(this.ActiveControl is UltraGrid) || this.ActiveControl != this.gridInvoiceActivity && this.ActiveControl != this.gridPolicyActivity || ((UltraGridBase) (this.ActiveControl as UltraGrid)).ActiveRow == null || MessageBox.Show("This action will force the commission recognition for the transaction/invoice selected. This should ONLY be done if there is a discrepancy on the amounts of income recognized. This will have NO effect if the correct amount of commission has already been recognized or if you are on accrual basis. Continue?", "Force Commission Recognition?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
              return;
            this.ForceCommissionReconition(int.Parse(((UltraGridBase) (this.ActiveControl as UltraGrid)).ActiveRow.Cells["transactnum"].Value.ToString()));
            return;
          case 'R':
            if (!(key == "REINSTATE"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{16C4CBCA-7EDE-411D-A697-014313B0F4BA}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            this.ReinstatePolicy();
            return;
          default:
            return;
        }
      case 10:
        switch (key[0])
        {
          case 'A':
            if (!(key == "AddComment"))
              return;
            using (formPolicyInquiryComment policyInquiryComment = new formPolicyInquiryComment(this.quoteControlNumber))
            {
              if (policyInquiryComment.ShowDialog() != DialogResult.OK)
                return;
              this.LoadPolicyInquiryComments();
              return;
            }
          case 'F':
            if (!(key == "FINDPOLICY"))
              return;
            this.FindPolicy();
            return;
          case 'N':
            if (!(key == "NEXTPOLICY"))
              return;
            this.DisplayLoggedPolicy(false);
            return;
          case 'V':
            if (!(key == "VIEWPAYSUM") || ((SparseCollectionBase) this.gridInvoiceActivity.Selected.Rows).Count == 0)
              return;
            ReportFactory.Instance.ShowReport(false, typeof (rptPaymentSummary), (object) int.Parse(((UltraGridBase) this.gridInvoiceActivity).ActiveRow.Cells["transactNum"].Value.ToString()));
            return;
          default:
            return;
        }
      case 11:
        switch (key[0])
        {
          case 'E':
            if (!(key == "EditComment") || ((SparseCollectionBase) this.gridPolicyInquiryComments.Selected.Rows).Count == 0)
              return;
            using (formPolicyInquiryComment policyInquiryComment = new formPolicyInquiryComment(int.Parse(this.gridPolicyInquiryComments.Selected.Rows[0].Cells["commentid"].Value.ToString()), this.quoteControlNumber))
            {
              if (policyInquiryComment.ShowDialog() != DialogResult.OK)
                return;
              this.LoadPolicyInquiryComments();
              return;
            }
          case 'V':
            if (!(key == "VIEWINVOICE"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{16BEA76B-5F19-4B0C-A8C3-61CAD052E843}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            this.ViewInvoice();
            return;
          default:
            return;
        }
      case 13:
        switch (key[0])
        {
          case 'D':
            if (!(key == "DeleteComment") || ((SparseCollectionBase) this.gridPolicyInquiryComments.Selected.Rows).Count == 0)
              return;
            MGASystems.IMS.Accounting.Services.PolicyServices.DeletePolicyInquiryComment(int.Parse(this.gridPolicyInquiryComments.Selected.Rows[0].Cells["commentid"].Value.ToString()));
            this.LoadPolicyInquiryComments();
            return;
          case 'I':
            if (!(key == "INVOICEPAYEES"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{C728610C-7B96-4779-99BC-934C791E05BF}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            if (((SparseCollectionBase) this.gridInvoiceListing.Selected.Rows).Count <= 0)
              return;
            UltraGridRow row1 = this.gridInvoiceListing.Selected.Rows[0];
            this.invoicePayeeBreakout1.Clear();
            this.invoicePayeeBreakout1.ShowInvoicePayees(int.Parse(row1.Cells["invoicenum"].Value.ToString()));
            this.invoicePayeeBreakout1.Visible = true;
            return;
          case 'R':
            if (!(key == "ReprintNotice"))
              return;
            if (!SecurityManager.Instance.AssertPermission("{D31A5BA4-8991-4F6A-8DA1-0144565BB1AD}"))
            {
              using (formAccessDenied formAccessDenied = new formAccessDenied())
              {
                int num = (int) formAccessDenied.ShowDialog();
                return;
              }
            }
            this.ReprintNotice();
            return;
          default:
            return;
        }
      case 14:
        switch (key[0])
        {
          case 'F':
            if (!(key == "FINANCECOMPANY"))
              return;
            this.AddEditFinanceCompany();
            this.SetFinanceInfoToolbarLabel();
            return;
          case 'P':
            if (!(key == "PREVIOUSPOLICY"))
              return;
            this.DisplayLoggedPolicy(true);
            return;
          default:
            return;
        }
      case 17:
        if (!(key == "TRANSACTIONDETAIL") || !(this.ActiveControl is UltraGrid) || this.ActiveControl != this.gridInvoiceActivity && this.ActiveControl != this.gridPolicyActivity || ((DisposableObjectCollectionBase) ((UltraGridBase) (this.ActiveControl as UltraGrid)).Rows).Count == 0)
          break;
        if (((SparseCollectionBase) (this.ActiveControl as UltraGrid).Selected.Rows).Count == 0)
        {
          ((GridItemBase) ((UltraGridBase) (this.ActiveControl as UltraGrid)).Rows[0]).Selected = true;
          ((UltraGridBase) (this.ActiveControl as UltraGrid)).Rows[0].Activate();
        }
        if (((SparseCollectionBase) (this.ActiveControl as UltraGrid).Selected.Rows).Count == 0)
          break;
        UltraGridRow row2 = (this.ActiveControl as UltraGrid).Selected.Rows[0];
        if (row2 == null)
          break;
        formTransactionViewer form = (formTransactionViewer) ObjectFactory.Instance.CreateForm(typeof (formTransactionViewer), new object[2]
        {
          (object) int.Parse(row2.Cells["transactNum"].Value.ToString()),
          (object) this.glCompanyId
        });
        form.MdiParent = MDIControls.Instance.MDIParent;
        form.Show();
        break;
      case 19:
        if (!(key == "TransactionComments") || !(this.ActiveControl is UltraGrid) || this.ActiveControl != this.gridInvoiceActivity && this.ActiveControl != this.gridPolicyActivity || ((UltraGridBase) (this.ActiveControl as UltraGrid)).ActiveRow == null)
          break;
        this.ShowTransactionComments(int.Parse(((UltraGridBase) (this.ActiveControl as UltraGrid)).ActiveRow.Cells["transactnum"].Value.ToString()));
        break;
      case 22:
        int num1 = key == "InvoiceActivityContext" ? 1 : 0;
        break;
    }
  }

  private void AddEditFinanceCompany()
  {
    int num1 = int.Parse(((UltraGridBase) this.gridInvoiceListing).Rows[0].Cells["invoicenum"].Value.ToString());
    string financeCompanyName = string.Empty;
    string financeAccountNumber = string.Empty;
    Guid financeCompanyGuid = Guid.Empty;
    if (!this.dsPolicyInformation1.PolicyHeader[0].IsFinanceCompanyGuidNull())
      financeCompanyGuid = this.dsPolicyInformation1.PolicyHeader[0].FinanceCompanyGuid;
    if (!this.dsPolicyInformation1.PolicyHeader[0].IsFinanceCompanyNameNull())
      financeCompanyName = this.dsPolicyInformation1.PolicyHeader[0].FinanceCompanyName;
    if (!this.dsPolicyInformation1.PolicyHeader[0].IsFinanceCompanyAccountNumberNull())
      financeAccountNumber = this.dsPolicyInformation1.PolicyHeader[0].FinanceCompanyAccountNumber;
    using (formFinanceCompany formFinanceCompany = new formFinanceCompany(financeCompanyName, financeCompanyGuid, financeAccountNumber))
    {
      DialogResult dialogResult = formFinanceCompany.ShowDialog();
      if (dialogResult == DialogResult.OK && !formFinanceCompany.ClearFinanceCompany)
      {
        DataRow dataRow = DefaultDatabase.ExecuteDataRow("spFin_UpdateFinanceCompany", new object[6]
        {
          (object) "@invoicenum",
          (object) num1,
          (object) "@financecompanyguid",
          (object) formFinanceCompany.FinanceCompanyGuid,
          (object) "@accountnumber",
          (object) formFinanceCompany.AccountNumber
        });
        CurrentUser.Instance.LogAction($"Changed finance company from {dataRow[0].ToString()} to {dataRow[1].ToString()} for Invoice #: {num1.ToString()}.");
        int num2 = (int) MessageBox.Show("Finance Company Assigned", "Done", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        this.RefreshScreen();
      }
      else
      {
        if (dialogResult != DialogResult.OK || !formFinanceCompany.ClearFinanceCompany)
          return;
        using (FormClearFinanceCompany clearFinanceCompany = new FormClearFinanceCompany(this.quoteControlNumber))
        {
          if (clearFinanceCompany.ShowDialog() != DialogResult.OK)
            return;
          this.RefreshScreen();
        }
      }
    }
  }

  private void ForceCommissionReconition(int transactNum)
  {
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, e) =>
    {
      DefaultDatabase.ExecuteNonQuery("spFin_ForceCommissionRecognition", new object[6]
      {
        (object) "@glcompanyid",
        (object) this.glCompanyId,
        (object) "@rollupto",
        (object) "R",
        (object) "@transactNum",
        (object) transactNum
      });
      e.Transaction.Commit();
    }));
    this.RefreshScreen();
  }

  private void PrintPolicyInquiryReport()
  {
    if (this.quoteControlNumber == 0 || this.quoteControlNumber == -1)
      return;
    MGASystems.IMS.Accounting.Core.Forms.dsPolicyInquiry dsPolicyInquiry = new MGASystems.IMS.Accounting.Core.Forms.dsPolicyInquiry();
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.LoadDataSet((DataSet) dsPolicyInquiry, new string[1]
      {
        "spFin_QuoteInvoices"
      }, "spFin_QuoteInvoices", new object[2]
      {
        (object) "@QuoteNum",
        (object) this.quoteControlNumber
      });
      DefaultDatabase.LoadDataSet((DataSet) dsPolicyInquiry, new string[1]
      {
        "spFin_InvoiceTransactions"
      }, "spFin_InvoiceTransactions", new object[2]
      {
        (object) "@QuoteNum",
        (object) this.quoteControlNumber
      });
      SectionReport rpt = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (rptPolicyInquiryReport), new object[1]
      {
        (object) dsPolicyInquiry
      });
      rpt.Run();
      ReportFactory.Instance.ShowReport(rpt);
    }
    catch
    {
      throw;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void ViewInvoice()
  {
    ArrayList @params = new ArrayList();
    @params.AddRange((ICollection) new object[2]
    {
      (object) "MGACopy",
      (object) false
    });
    if (((SparseCollectionBase) this.gridInvoiceListing.Selected.Rows).Count <= 0)
      return;
    UltraGridRow row = this.gridInvoiceListing.Selected.Rows[0];
    if (row != null)
      ReportFactory.Instance.ShowInvoices(int.Parse(row.Cells["invoicenum"].Value.ToString()), @params);
  }

  private void DisplayLoggedPolicy(bool decrement)
  {
    if (this._controlNumberLog.Count == 0)
    {
      ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["PREVIOUSPOLICY"].SharedProps.Enabled = false;
      ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["NEXTPOLICY"].SharedProps.Enabled = false;
    }
    else
    {
      if (!decrement || this._logPosition != 0 && this._logPosition - 1 != 0)
        return;
      ((ToolsCollectionBase) ((UltraToolbarBase) this.UltraToolbarsManager1.Toolbars[0]).Tools)["PREVIOUSPOLICY"].SharedProps.Enabled = false;
    }
  }

  private void RefreshScreen() => this.ShowPolicy(this.quoteControlNumber);

  protected virtual void ReprintNotice()
  {
    SqlCommand selectCommand = new SqlCommand("spFin_ReprintNOC", new SqlConnection(CurrentUser.Instance.ConnectionString));
    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(selectCommand);
    dsCancellationList ds = new dsCancellationList();
    SectionReport sectionReport = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (PendingCancellation), new object[1]
    {
      (object) CurrentUser.Instance.ConnectionString
    });
    try
    {
      selectCommand.CommandType = CommandType.StoredProcedure;
      selectCommand.Parameters.AddWithValue("@quoteid", (object) this.quoteObject.QuoteID);
      sqlDataAdapter.Fill((DataTable) ds.CancellationList);
      if (ds.CancellationList.Rows.Count == 0)
        return;
      sectionReport.DataSource = (object) ds.CancellationList;
      sectionReport.Run();
      PrintExtension.Print(sectionReport.Document, true, false, false);
      if (MessageBox.Show("Do you wish to add this document to the document handler?", "Add Notice Of Cancellation To The Document Handler?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        try
        {
          this.Cursor = Cursors.WaitCursor;
          PdfExport pdfExport = new PdfExport();
          pdfExport.Export(sectionReport.Document, $"{Path.GetTempPath()}\\NoticeOfCancellation_{this.quoteObject.QuoteID.ToString()}.pdf");
          DocumentManager.BeginFileAddWithBind($"{Path.GetTempPath()}\\NoticeOfCancellation_{this.quoteObject.QuoteID.ToString()}.pdf", -1, "Notice Of Cancellation", (ISupportDocumentSystem) new Quote(this.quoteObject.QuoteID), true);
          ((Component) pdfExport).Dispose();
        }
        finally
        {
          this.Cursor = Cursors.Default;
        }
      }
      if (MessageBox.Show("Do you wish to print envelopes", "Print Envelopes", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      this.PrintEnvelopes(ds);
    }
    finally
    {
      sectionReport?.Dispose();
      if (selectCommand != null)
      {
        if (selectCommand.Connection != null)
        {
          if (selectCommand.Connection.State != ConnectionState.Closed)
            selectCommand.Connection.Close();
          selectCommand.Connection.Dispose();
          selectCommand.Connection = (SqlConnection) null;
        }
        selectCommand.Dispose();
      }
    }
  }

  protected void PrintEnvelopes(dsCancellationList ds)
  {
    string printerName = string.Empty;
    string paperTray = string.Empty;
    PrintDialog printDialog1 = (PrintDialog) null;
    SectionReport envelope = (SectionReport) ObjectFactory.Instance.CreateObject(typeof (StandardNo10Envelope));
    if (printDialog1 == null)
    {
      PrintDialog printDialog2 = new PrintDialog();
      printDialog2.Document = new PrintDocument()
      {
        DocumentName = "Notice Of Cancellation Envelopes"
      };
      printDialog2.AllowPrintToFile = false;
      printDialog2.AllowSelection = true;
      if (printDialog2.ShowDialog() == DialogResult.OK)
      {
        printerName = printDialog2.PrinterSettings.PrinterName;
        paperTray = printDialog2.Document.DefaultPageSettings.PaperSource.SourceName;
      }
    }
    CancellationNotices.NoticeOfCancellation.PrintEnvelopes(envelope, ds.Tables[0], printerName, paperTray);
  }

  protected virtual void CancelPolicy()
  {
    if (this.glCompanyId == 0 || this.quoteControlNumber == 0)
      return;
    formCancellationDateOverride cancellationDateOverride = (formCancellationDateOverride) null;
    try
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridInvoiceListing).Rows)
      {
        if (Convert.ToDateTime(row.Cells["duedate"].Value.ToString()) <= DateTime.Now && !MGASystems.IMS.Accounting.Services.PolicyServices.IsUnderNotice(int.Parse(row.Cells["invoicenum"].Value.ToString())))
        {
          if (MessageBox.Show("Do you wish to override the cancellation or mailing dates?", "Override Cancellation Dates?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
          {
            NoticeOfCancellation.PrintCancellationNotices(CurrentUser.Instance.ConnectionString, int.Parse(row.Cells["quoteId"].Value.ToString()), this.glCompanyId, "", "", "");
            if (this.quoteObject != null)
              CurrentUser.Instance.LogAction("Issued manual NOC on Control #" + this.quoteControlNumber.ToString(), this.quoteObject.QuoteGuid, "Accounting Logs");
            else
              CurrentUser.Instance.LogAction("Issued manual NOC on Control #" + this.quoteControlNumber.ToString(), "Accounting Logs");
            Messaging.SendBroadcastMessage(BroadcastMessages.NOCIssued, (object) this.quoteObject.QuoteGuid);
            this.ClearScreen();
            this.ShowPolicy(this.quoteControlNumber);
          }
          else
          {
            cancellationDateOverride = new formCancellationDateOverride(this.quoteObject.PolicyNumber, this.quoteControlNumber, this.quoteObject.QuoteID, this.glCompanyId);
            int num = (int) cancellationDateOverride.ShowDialog();
            return;
          }
        }
      }
      cancellationDateOverride = new formCancellationDateOverride(this.quoteObject.PolicyNumber, this.quoteControlNumber, this.quoteObject.QuoteID, this.glCompanyId);
      int num1 = (int) cancellationDateOverride.ShowDialog();
    }
    finally
    {
      this.ClearScreen();
      this.ShowPolicy(this.quoteControlNumber);
      cancellationDateOverride?.Dispose();
    }
  }

  protected virtual void ReinstatePolicy()
  {
    if (this.quoteObject == null)
      return;
    if (this.quoteObject.UnderNotice)
    {
      try
      {
        if (!MGASystems.IMS.Accounting.Core.ClassObjects.Utility.IsReasonNonPayment(this.quoteObject.QuoteStatusReasonID.Value))
        {
          int? quoteStatusReasonId = this.quoteObject.QuoteStatusReasonID;
          int num1 = 117;
          if (!(quoteStatusReasonId.GetValueOrDefault() == num1 & quoteStatusReasonId.HasValue))
          {
            if (SecurityManager.Instance.AssertPermission("{D7D3EE93-2CC6-45d7-B3D8-78394F438910}"))
            {
              if (MessageBox.Show("This policy is under notice for underwriting reasons, are you sure you wish to reinstate this policy?", "Reinstate Policy?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
              goto label_9;
            }
            int num2 = (int) MessageBox.Show("This policy is under notice for underwriting reasons. You do not have sufficient rights to reinstate this policy.", "Access Denied!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return;
          }
        }
        if (MessageBox.Show("Are you sure you wish to reinstate this policy?", "Reinstate Policy?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
          return;
label_9:
        this.Cursor = Cursors.WaitCursor;
        MGASystems.IMS.Accounting.Services.PolicyServices.ReinstatePolicy(this.quoteObject, false);
        if (!this.quoteObject.UnderNotice)
        {
          CurrentUser.Instance.LogAction("Issued Reinstatment", this.quoteObject.QuoteGuid);
          Messaging.SendBroadcastMessage(BroadcastMessages.RescindNotice, (object) this.quoteObject.QuoteGuid);
        }
        this.ClearScreen();
        this.ShowPolicy(this.quoteControlNumber);
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
    else if (this.quoteObject.IsCancelled)
    {
      if (MessageBox.Show("You can not reinstate a cancelled policy.Do you wish to reprint the reinstatement notice?", "Can Not Reinstate!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      try
      {
        this.Cursor = Cursors.WaitCursor;
        MGASystems.IMS.Accounting.Services.PolicyServices.ReinstatePolicy(this.quoteObject, true);
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
    else
    {
      if (MessageBox.Show("The policy is not under notice of cancellation. Do you wish to reprint the reinstatement notice?", "Reprint Notice?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) != DialogResult.Yes)
        return;
      try
      {
        this.Cursor = Cursors.WaitCursor;
        MGASystems.IMS.Accounting.Services.PolicyServices.ReinstatePolicy(this.quoteObject, true);
      }
      finally
      {
        this.Cursor = Cursors.Default;
      }
    }
  }

  private void FindPolicy()
  {
    formFindPolicy form = (formFindPolicy) ObjectFactory.Instance.CreateForm(typeof (formFindPolicy));
    if (form.ShowDialog() == DialogResult.OK)
    {
      this.ClearScreen();
      this.quoteControlNumber = form.QuoteControlNumber;
      if (!this._controlNumberLog.ContainsKey(form.QuoteControlNumber))
        this._controlNumberLog.Add(form.QuoteControlNumber, form.GLCompanyID);
      ++this._logPosition;
      this.glCompanyId = MGASystems.IMS.Accounting.Core.ClassObjects.Utility.GetGLCompanyIdFromControlNumber(form.QuoteControlNumber);
      this.dsPolicyInformation1.Clear();
      this.ShowPolicy(form.QuoteControlNumber);
      this.AfterLoadPolicy();
      if (this.quoteObject != null && this.quoteObject.QuoteGuid != Guid.Empty)
        Note_System.Instance.UIInteractive.ViewPopupNotes(Guid.Empty, this.quoteObject.QuoteGuid, (Form) this);
    }
    form.Dispose();
  }

  private void frmPolicyInquiry_Activated(object sender, EventArgs e)
  {
    if (!this.firstActivation)
      return;
    this.firstActivation = false;
    this.FindPolicy();
  }

  private void LoadPolicyInquiryComments()
  {
    this.dsPolicyInformation1.PolicyInquiryComments.Clear();
    this.daGetPolicyInquiryComments.SelectCommand.Parameters["@controlNumber"].Value = (object) this.quoteControlNumber;
    this.daGetPolicyInquiryComments.Fill((DataTable) this.dsPolicyInformation1.PolicyInquiryComments);
  }

  private void UltraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    if (((KeyedSubObjectBase) ((CancelableToolEventArgs) e).Tool).Key != "InvoiceActivityContext")
      return;
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridInvoiceActivity).Rows).Count == 0)
    {
      ((CancelEventArgs) e).Cancel = true;
    }
    else
    {
      if (((UltraGridBase) this.gridInvoiceActivity).ActiveRow == null)
        return;
      if (((UltraGridBase) this.gridInvoiceActivity).ActiveRow.Cells["transDescription"].Value.ToString() == "Disbursement")
        ((ToolsCollectionBase) ((PopupMenuTool) ((CancelableToolEventArgs) e).Tool).Tools)["VIEWPAYSUM"].SharedProps.Visible = true;
      else
        ((ToolsCollectionBase) ((PopupMenuTool) ((CancelableToolEventArgs) e).Tool).Tools)["VIEWPAYSUM"].SharedProps.Visible = false;
      ((ToolsCollectionBase) ((PopupMenuTool) ((CancelableToolEventArgs) e).Tool).Tools)["FORCECOMM"].SharedProps.Visible = SecurityManager.Instance.AssertPermission("{EFC403E9-855D-43E0-8068-FD2AA7E813CF}");
    }
  }

  private void gridInvoiceActivity_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (!Convert.ToBoolean(e.Row.Cells["voided"].Value))
      return;
    ((AppearanceBase) e.Row.Appearance).FontData.Strikeout = (DefaultableBoolean) 1;
  }

  private void gridInvoiceListing_Click(object sender, EventArgs e)
  {
    if (((SparseCollectionBase) this.gridInvoiceListing.Selected.Rows).Count == 0 || this.gridInvoiceListing.Selected.Rows[0] == null)
      return;
    UltraGridRow row = this.gridInvoiceListing.Selected.Rows[0];
    if (row == null)
      return;
    this.GetInvoiceActivity(int.Parse(row.Cells["invoiceNum"].Value.ToString()));
    this.LoadInvoiceDetails(int.Parse(row.Cells["invoiceNum"].Value.ToString()));
    this.panelChangeTransactionDate.Visible = false;
    this.panelChangeDueDate.Visible = false;
    this.panelChangeBillDate.Visible = false;
  }

  private void gridInvoiceActivity_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridInvoiceActivity).ActiveRow == null || !this.transactionCommentsViewer1.Visible)
      return;
    this.ShowTransactionComments(int.Parse(((UltraGridBase) this.gridInvoiceActivity).ActiveRow.Cells["transactnum"].Value.ToString()));
  }

  private void ShowTransactionComments(int transactionNumber)
  {
    if (this.ActiveControl == this.gridInvoiceActivity)
    {
      this.transactionCommentsViewer1.LoadComments(transactionNumber);
      this.transactionCommentsViewer1.Visible = true;
    }
    else
    {
      if (this.ActiveControl != this.gridPolicyActivity)
        return;
      this.transactionCommentsViewer2.LoadComments(transactionNumber);
      this.transactionCommentsViewer2.Visible = true;
    }
  }

  private void ToggleDisableNOC()
  {
    DefaultDatabase.ExecuteNonQuery("spFin_ToggleDisableNOC", new object[2]
    {
      (object) "@controlNumber",
      (object) this.quoteControlNumber
    });
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler EntityInfoChanged;

  bool ISupportNoteSystem.CanCreateNewNote => true;

  public event ISupportNoteSystem.EntityInfoChangedEventHandler NoteEntityInfoChanged;

  event ISupportNoteSystem.EntityInfoChangedEventHandler ISupportNoteSystem.EntityInfoChanged
  {
    add => this.NoteEntityInfoChanged += value;
    remove => this.NoteEntityInfoChanged += value;
  }

  bool IRecreatableEntity.CanReCreateEntity => true;

  Guid IRecreatableEntity.ControlGUID
  {
    get
    {
      Quote quoteObject = this.quoteObject;
      return quoteObject == null ? Guid.Empty : __nonvirtual (quoteObject.ControlGuid);
    }
  }

  Guid IRecreatableEntity.EntityGuid
  {
    get
    {
      Quote quoteObject = this.quoteObject;
      return quoteObject == null ? Guid.Empty : quoteObject.EntityGuid;
    }
  }

  string IRecreatableEntity.EntityName => this.quoteObject?.EntityName ?? string.Empty;

  string IRecreatableEntity.FriendlyEntityName
  {
    get => this.quoteObject?.FriendlyEntityName ?? string.Empty;
  }

  bool IRecreatableEntity.HasControlGUID
  {
    get => this.quoteObject != null && this.quoteObject.HasControlGUID;
  }

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid) => true;

  string IRecreatableEntity.RecreateTypeName => this.quoteObject?.RecreateTypeName ?? string.Empty;

  private void utcInvoiceActivity_SelectedTabChanged(object sender, SelectedTabChangedEventArgs e)
  {
    this.chkShowVoids.Visible = ((UltraTabControlBase) this.utcInvoiceActivity).SelectedTab.Index == 1;
  }

  private void chkShowVoids_CheckedChanged(object sender, EventArgs e) => this.ToggleShowVoids();

  private void buttonCloseChangeDueDate_Click(object sender, EventArgs e)
  {
    this.panelChangeDueDate.Visible = false;
  }

  private void buttonCloseChangeBillDate_Click(object sender, EventArgs e)
  {
    this.panelChangeBillDate.Visible = false;
  }

  private void buttonSaveDueDate_Click(object sender, EventArgs e)
  {
    DateTime dateTime1 = DateTime.Parse(this.lblInvoiceDateBilled.Text);
    DateTime.Parse(this.lblExpirationDate.Text);
    DateTime dateTime2 = DateTime.Parse(this.lblInvoiceDueDate.Text);
    int invoiceNumber;
    int num1;
    if (((SparseCollectionBase) this.gridInvoiceListing.Selected.Rows).Count == 0)
    {
      invoiceNumber = int.Parse(this.gridInvoiceListing.Selected.Rows[0].Cells["invoicenum"].Value.ToString());
      num1 = int.Parse(this.gridInvoiceListing.Selected.Rows[0].Cells["officeInvoiceNum"].Value.ToString());
    }
    else
    {
      invoiceNumber = int.Parse(((UltraGridBase) this.gridInvoiceListing).ActiveRow.Cells["invoicenum"].Value.ToString());
      num1 = int.Parse(((UltraGridBase) this.gridInvoiceListing).ActiveRow.Cells["officeInvoiceNum"].Value.ToString());
    }
    if (this.dateNewDueDate.DateTime < dateTime1)
    {
      int num2 = (int) MessageBox.Show("The due date cannot be before the date billed.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show($"This will change the due date for invoice {num1.ToString()} from {dateTime2.ToShortDateString()} to {this.dateNewDueDate.DateTime.ToShortDateString()}. Are you sure you wish to continue?", "Change Due Date?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      DefaultDatabase.ExecuteNonQuery("spFin_ChangeInvoiceDueDate", new object[4]
      {
        (object) "@invoicenum",
        (object) invoiceNumber,
        (object) "@newdate",
        (object) this.dateNewDueDate.DateTime
      });
      if (this.quoteObject != null)
        CurrentUser.Instance.LogAction($"Changed invoice due date on invoice #{num1}", this.quoteObject.QuoteGuid, "Accounting Logs");
      else
        CurrentUser.Instance.LogAction($"Changed invoice due date on invoice #{num1}", "Accounting Logs");
      this.panelChangeDueDate.Visible = false;
      this.GetInvoiceActivity(invoiceNumber);
      this.LoadInvoiceDetails(invoiceNumber);
    }
  }

  private void linkChangeDueDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.panelChangeDueDate.Visible = !this.panelChangeDueDate.Visible;
  }

  private void linkChangeBillDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.panelChangeBillDate.Visible = !this.panelChangeBillDate.Visible;
  }

  private void buttonSaveChangeBillDate_Click(object sender, EventArgs e)
  {
    DateTime dateTime = DateTime.Parse(this.lblInvoiceDueDate.Text);
    DateTime.Parse(this.lblExpirationDate.Text);
    DateTime date = DateTime.Parse(this.lblInvoiceDateBilled.Text);
    if (!AccountingCache.Instance.GlCompany(this.glCompanyId).ViolatesClosedDate(date))
    {
      int num1 = (int) MessageBox.Show("This entry you are trying to edit is in a closed accounting period.");
    }
    else
    {
      int invoiceNumber;
      int num2;
      if (((SparseCollectionBase) this.gridInvoiceListing.Selected.Rows).Count == 0)
      {
        invoiceNumber = int.Parse(this.gridInvoiceListing.Selected.Rows[0].Cells["invoicenum"].Value.ToString());
        num2 = int.Parse(this.gridInvoiceListing.Selected.Rows[0].Cells["officeInvoiceNum"].Value.ToString());
      }
      else
      {
        invoiceNumber = int.Parse(((UltraGridBase) this.gridInvoiceListing).ActiveRow.Cells["invoicenum"].Value.ToString());
        num2 = int.Parse(((UltraGridBase) this.gridInvoiceListing).ActiveRow.Cells["officeInvoiceNum"].Value.ToString());
      }
      if (this.dateNewBillDate.DateTime > dateTime)
      {
        int num3 = (int) MessageBox.Show("The due date cannot be before the date billed.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
      else
      {
        if (MessageBox.Show($"This will change the bill date for invoice {num2.ToString()} from {date.ToShortDateString()} to {this.dateNewBillDate.DateTime.ToShortDateString()}. Are you sure you wish to continue?", "Change Bill Date?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          return;
        if (!AccountingCache.Instance.GlCompany(this.glCompanyId).ViolatesClosedDate(this.dateNewBillDate.DateTime))
        {
          int num4 = (int) MessageBox.Show("This entry would violate the office locations closed accounting period.", "Can Not Post In Closed Accounting Period!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        else
        {
          using (SqlCommand sqlCommand = new SqlCommand("spFin_ChangeInvoiceBilledDate", new SqlConnection(CurrentUser.Instance.ConnectionString)))
          {
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.Parameters.AddWithValue("@invoicenum", (object) invoiceNumber);
            sqlCommand.Parameters.AddWithValue("@newdate", (object) this.dateNewBillDate.DateTime);
            sqlCommand.Connection.Open();
            sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
            try
            {
              sqlCommand.ExecuteNonQuery();
              sqlCommand.Transaction.Commit();
              if (this.quoteObject != null)
                CurrentUser.Instance.LogAction($"Changed bill date on invoice #{num2}", this.quoteObject.QuoteGuid, "Accounting Logs");
              else
                CurrentUser.Instance.LogAction($"Changed bill date on invoice #{num2}", "Accounting Logs");
            }
            catch (SqlException ex)
            {
              sqlCommand.Transaction.Rollback();
              throw ex;
            }
          }
          this.panelChangeBillDate.Visible = false;
          this.GetInvoiceActivity(invoiceNumber);
          this.LoadInvoiceDetails(invoiceNumber);
        }
      }
    }
  }

  private void buttonCloseChangeTransactionDate_Click(object sender, EventArgs e)
  {
    this.panelChangeTransactionDate.Visible = false;
  }

  private void linkChangeTransactionDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.panelChangeTransactionDate.Visible = !this.panelChangeTransactionDate.Visible;
  }

  private void buttonSaveTransactionDate_Click(object sender, EventArgs e)
  {
    DateTime dateTime1 = DateTime.Parse(this.lblInvoiceDateBilled.Text);
    DateTime dateTime2 = DateTime.Parse(this.lblDueCompany.Text);
    int invoiceNumber = ((SparseCollectionBase) this.gridInvoiceListing.Selected.Rows).Count != 0 ? int.Parse(((UltraGridBase) this.gridInvoiceListing).ActiveRow.Cells["invoicenum"].Value.ToString()) : int.Parse(this.gridInvoiceListing.Selected.Rows[0].Cells["invoicenum"].Value.ToString());
    if (this.dateTimeNewTransactionDate.DateTime < dateTime1)
    {
      int num = (int) MessageBox.Show("The invoice transaction date can not be less than the the date billed.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (MessageBox.Show($"This will change this specified invoices transaction date from {dateTime2.ToShortDateString()} to {this.dateTimeNewTransactionDate.DateTime.ToShortDateString()}, continue?", "Change Transaction Date?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        using (SqlCommand sqlCommand = new SqlCommand("spFin_ChangeInvoiceTransactionDate", new SqlConnection(CurrentUser.Instance.ConnectionString)))
        {
          sqlCommand.CommandType = CommandType.StoredProcedure;
          sqlCommand.Parameters.AddWithValue("@invoicenum", (object) invoiceNumber);
          sqlCommand.Parameters.AddWithValue("@newdate", (object) this.dateTimeNewTransactionDate.DateTime);
          sqlCommand.Connection.Open();
          sqlCommand.Transaction = sqlCommand.Connection.BeginTransaction();
          try
          {
            sqlCommand.ExecuteNonQuery();
            sqlCommand.Transaction.Commit();
            if (this.quoteObject != null)
              CurrentUser.Instance.LogAction("Changed transaction due date on invoice #" + ((UltraGridBase) this.gridInvoiceListing).ActiveRow.Cells["officeInvoiceNum"].Value.ToString(), this.quoteObject.QuoteGuid, "Accounting Logs");
            else
              CurrentUser.Instance.LogAction("Changed transaction due date on invoice #" + ((UltraGridBase) this.gridInvoiceListing).ActiveRow.Cells["officeInvoiceNum"].Value.ToString(), "Accounting Logs");
          }
          catch (SqlException ex)
          {
            sqlCommand.Transaction.Rollback();
            throw ex;
          }
        }
      }
      this.GetInvoiceActivity(invoiceNumber);
      this.LoadInvoiceDetails(invoiceNumber);
      this.panelChangeTransactionDate.Visible = false;
    }
  }

  private void checkDisableNOC_CheckedChanged(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.ToggleDisableNOC();
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  public string RecreateTypeName => this.quoteObject?.RecreateTypeName ?? string.Empty;

  public bool AllowAddNewDocument => true;

  public bool HasQuoteGuid => true;

  public Guid QuoteGuid
  {
    get
    {
      Quote quoteObject = this.quoteObject;
      return quoteObject == null ? Guid.Empty : quoteObject.QuoteGuid;
    }
  }

  protected bool HasInvoicesDue()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridInvoiceListing).Rows)
    {
      if (DateTime.Compare((DateTime) row.Cells["DueDate"].Value, DateTime.Now) <= 0)
        return true;
    }
    return false;
  }

  private void gridPolicyActivity_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridPolicyActivity).ActiveRow == null || !this.transactionCommentsViewer2.Visible)
      return;
    this.ShowTransactionComments(int.Parse(((UltraGridBase) this.gridPolicyActivity).ActiveRow.Cells["transactnum"].Value.ToString()));
  }

  protected virtual void AfterLoadPolicy()
  {
  }

  private void formPolicyInquiry_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    ((Control) this.UltraTabControl1).Enabled = SecurityManager.Instance.AssertPermission("{515B1DDA-7681-4739-9A5A-58253EB463F5}");
    this.SetFormPermissions();
    if (this.quoteControlNumber == -1 || this.quoteControlNumber == 0)
      return;
    this.ShowPolicy(this.quoteControlNumber);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("InvoiceFeeLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FeeName");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("amount");
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    SummarySettings summarySettings1 = new SummarySettings("", (SummaryType) 1, (string) null, "amount", 1, true, "InvoiceFeeLines", 0, (SummaryPosition) 3, "amount", 1, true);
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("lyt1");
    Appearance appearance35 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("InvoiceFeeLines", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FeeName");
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("amount");
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    SummarySettings summarySettings2 = new SummarySettings("", (SummaryType) 1, (string) null, "amount", 1, true, "InvoiceFeeLines", 0, (SummaryPosition) 3, "amount", 1, true);
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("InvoicePremiumLines", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("premiumName");
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("amount");
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    SummarySettings summarySettings3 = new SummarySettings("", (SummaryType) 1, (string) null, "amount", 1, true, "InvoicePremiumLines", 0, (SummaryPosition) 3, "amount", 1, true);
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("lyt1");
    Appearance appearance66 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("InvoicePremiumLines", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("premiumName");
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("amount");
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    SummarySettings summarySettings4 = new SummarySettings("", (SummaryType) 1, (string) null, "amount", 1, true, "InvoicePremiumLines", 0, (SummaryPosition) 3, "amount", 1, true);
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    Appearance appearance75 = new Appearance();
    Appearance appearance76 = new Appearance();
    Appearance appearance77 = new Appearance();
    Appearance appearance78 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance79 = new Appearance();
    Appearance appearance80 = new Appearance();
    Appearance appearance81 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("InvoiceActivity", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("transactNum");
    Appearance appearance82 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("transDescription");
    Appearance appearance83 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("postDate");
    Appearance appearance84 = new Appearance();
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Received");
    Appearance appearance85 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("User");
    Appearance appearance86 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("voided");
    Appearance appearance87 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ARApplied");
    Appearance appearance88 = new Appearance();
    Appearance appearance89 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("APApplied");
    Appearance appearance90 = new Appearance();
    Appearance appearance91 = new Appearance();
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ExchApplied");
    Appearance appearance92 = new Appearance();
    Appearance appearance93 = new Appearance();
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("UnacctApplied");
    Appearance appearance94 = new Appearance();
    Appearance appearance95 = new Appearance();
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("IncomeApplied");
    Appearance appearance96 = new Appearance();
    Appearance appearance97 = new Appearance();
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Check Number");
    Appearance appearance98 = new Appearance();
    Appearance appearance99 = new Appearance();
    SummarySettings summarySettings5 = new SummarySettings("", (SummaryType) 1, (string) null, "ARApplied", 6, true, "InvoiceActivity", 0, (SummaryPosition) 3, "ARApplied", 6, true);
    Appearance appearance100 = new Appearance();
    SummarySettings summarySettings6 = new SummarySettings("", (SummaryType) 1, (string) null, "APApplied", 7, true, "InvoiceActivity", 0, (SummaryPosition) 3, "APApplied", 7, true);
    Appearance appearance101 = new Appearance();
    SummarySettings summarySettings7 = new SummarySettings("", (SummaryType) 1, (string) null, "ExchApplied", 8, true, "InvoiceActivity", 0, (SummaryPosition) 3, "ExchApplied", 8, true);
    Appearance appearance102 = new Appearance();
    SummarySettings summarySettings8 = new SummarySettings("", (SummaryType) 1, (string) null, "UnacctApplied", 9, true, "InvoiceActivity", 0, (SummaryPosition) 3, "UnacctApplied", 9, true);
    Appearance appearance103 = new Appearance();
    SummarySettings summarySettings9 = new SummarySettings("", (SummaryType) 1, (string) null, "IncomeApplied", 10, true, "InvoiceActivity", 0, (SummaryPosition) 3, "IncomeApplied", 10, true);
    Appearance appearance104 = new Appearance();
    Appearance appearance105 = new Appearance();
    Appearance appearance106 = new Appearance();
    Appearance appearance107 = new Appearance();
    Appearance appearance108 = new Appearance();
    Appearance appearance109 = new Appearance();
    Appearance appearance110 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance111 = new Appearance();
    Appearance appearance112 = new Appearance();
    Appearance appearance113 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("PolicyInvoices", -1);
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("invoiceNum");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("officeInvoiceNum");
    Appearance appearance114 = new Appearance();
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("quoteId");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("GrossBilled");
    Appearance appearance115 = new Appearance();
    Appearance appearance116 = new Appearance();
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("Commission");
    Appearance appearance117 = new Appearance();
    Appearance appearance118 = new Appearance();
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("Premium");
    Appearance appearance119 = new Appearance();
    Appearance appearance120 = new Appearance();
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Fees");
    Appearance appearance121 = new Appearance();
    Appearance appearance122 = new Appearance();
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("APBalance");
    Appearance appearance123 = new Appearance();
    Appearance appearance124 = new Appearance();
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ARBalance");
    Appearance appearance125 = new Appearance();
    Appearance appearance126 = new Appearance();
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("DueDate");
    Appearance appearance127 = new Appearance();
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("underNotice");
    SummarySettings summarySettings10 = new SummarySettings("PremiumSum", (SummaryType) 1, (string) null, "Premium", 5, true, "PolicyInvoices", 0, (SummaryPosition) 3, "Premium", 5, true);
    Appearance appearance128 = new Appearance();
    SummarySettings summarySettings11 = new SummarySettings("", (SummaryType) 1, (string) null, "Fees", 6, true, "PolicyInvoices", 0, (SummaryPosition) 3, "Fees", 6, true);
    Appearance appearance129 = new Appearance();
    SummarySettings summarySettings12 = new SummarySettings("", (SummaryType) 1, (string) null, "APBalance", 7, true, "PolicyInvoices", 0, (SummaryPosition) 3, "APBalance", 7, true);
    Appearance appearance130 = new Appearance();
    SummarySettings summarySettings13 = new SummarySettings("", (SummaryType) 1, (string) null, "ARBalance", 8, true, "PolicyInvoices", 0, (SummaryPosition) 3, "ARBalance", 8, true);
    Appearance appearance131 = new Appearance();
    SummarySettings summarySettings14 = new SummarySettings("GrossBilledSum", (SummaryType) 1, (string) null, "GrossBilled", 3, true, "PolicyInvoices", 0, (SummaryPosition) 3, "GrossBilled", 3, true);
    Appearance appearance132 = new Appearance();
    SummarySettings summarySettings15 = new SummarySettings("commissionSum", (SummaryType) 1, (string) null, "Commission", 4, true, "PolicyInvoices", 0, (SummaryPosition) 3, "Commission", 4, true);
    Appearance appearance133 = new Appearance();
    Appearance appearance134 = new Appearance();
    Appearance appearance135 = new Appearance();
    Appearance appearance136 = new Appearance();
    Appearance appearance137 = new Appearance();
    Appearance appearance138 = new Appearance();
    Appearance appearance139 = new Appearance();
    Appearance appearance140 = new Appearance();
    Appearance appearance141 = new Appearance();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    Appearance appearance142 = new Appearance();
    Appearance appearance143 = new Appearance();
    UltraGridLayout ultraGridLayout3 = new UltraGridLayout("lyt1");
    Appearance appearance144 = new Appearance();
    UltraGridBand ultraGridBand7 = new UltraGridBand("PolicyInvoices", -1);
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("invoiceNum");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("officeInvoiceNum");
    Appearance appearance145 = new Appearance();
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("quoteId");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("GrossBilled");
    Appearance appearance146 = new Appearance();
    Appearance appearance147 = new Appearance();
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("Commission");
    Appearance appearance148 = new Appearance();
    Appearance appearance149 = new Appearance();
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("Premium");
    Appearance appearance150 = new Appearance();
    Appearance appearance151 = new Appearance();
    UltraGridColumn ultraGridColumn38 = new UltraGridColumn("Fees");
    Appearance appearance152 = new Appearance();
    Appearance appearance153 = new Appearance();
    UltraGridColumn ultraGridColumn39 = new UltraGridColumn("APBalance");
    Appearance appearance154 = new Appearance();
    Appearance appearance155 = new Appearance();
    UltraGridColumn ultraGridColumn40 = new UltraGridColumn("ARBalance");
    Appearance appearance156 = new Appearance();
    Appearance appearance157 = new Appearance();
    UltraGridColumn ultraGridColumn41 = new UltraGridColumn("DueDate");
    Appearance appearance158 = new Appearance();
    UltraGridColumn ultraGridColumn42 = new UltraGridColumn("underNotice");
    SummarySettings summarySettings16 = new SummarySettings("PremiumSum", (SummaryType) 1, (string) null, "Premium", 5, true, "PolicyInvoices", 0, (SummaryPosition) 3, "Premium", 5, true);
    Appearance appearance159 = new Appearance();
    SummarySettings summarySettings17 = new SummarySettings("", (SummaryType) 1, (string) null, "Fees", 6, true, "PolicyInvoices", 0, (SummaryPosition) 3, "Fees", 6, true);
    Appearance appearance160 = new Appearance();
    SummarySettings summarySettings18 = new SummarySettings("", (SummaryType) 1, (string) null, "APBalance", 7, true, "PolicyInvoices", 0, (SummaryPosition) 3, "APBalance", 7, true);
    Appearance appearance161 = new Appearance();
    SummarySettings summarySettings19 = new SummarySettings("", (SummaryType) 1, (string) null, "ARBalance", 8, true, "PolicyInvoices", 0, (SummaryPosition) 3, "ARBalance", 8, true);
    Appearance appearance162 = new Appearance();
    SummarySettings summarySettings20 = new SummarySettings("GrossBilledSum", (SummaryType) 1, (string) null, "GrossBilled", 3, true, "PolicyInvoices", 0, (SummaryPosition) 3, "GrossBilled", 3, true);
    Appearance appearance163 = new Appearance();
    SummarySettings summarySettings21 = new SummarySettings("commissionSum", (SummaryType) 1, (string) null, "Commission", 4, true, "PolicyInvoices", 0, (SummaryPosition) 3, "Commission", 4, true);
    Appearance appearance164 = new Appearance();
    Appearance appearance165 = new Appearance();
    Appearance appearance166 = new Appearance();
    Appearance appearance167 = new Appearance();
    Appearance appearance168 = new Appearance();
    Appearance appearance169 = new Appearance();
    Appearance appearance170 = new Appearance();
    Appearance appearance171 = new Appearance();
    Appearance appearance172 = new Appearance();
    ScrollBarLook scrollBarLook7 = new ScrollBarLook();
    Appearance appearance173 = new Appearance();
    Appearance appearance174 = new Appearance();
    Appearance appearance175 = new Appearance();
    UltraGridBand ultraGridBand8 = new UltraGridBand("PolicyActivity", -1);
    UltraGridColumn ultraGridColumn43 = new UltraGridColumn("transactNum");
    Appearance appearance176 = new Appearance();
    Appearance appearance177 = new Appearance();
    UltraGridColumn ultraGridColumn44 = new UltraGridColumn("transDescription");
    Appearance appearance178 = new Appearance();
    Appearance appearance179 = new Appearance();
    UltraGridColumn ultraGridColumn45 = new UltraGridColumn("postDate");
    Appearance appearance180 = new Appearance();
    Appearance appearance181 = new Appearance();
    UltraGridColumn ultraGridColumn46 = new UltraGridColumn("Received");
    Appearance appearance182 = new Appearance();
    Appearance appearance183 = new Appearance();
    UltraGridColumn ultraGridColumn47 = new UltraGridColumn("User");
    Appearance appearance184 = new Appearance();
    Appearance appearance185 = new Appearance();
    UltraGridColumn ultraGridColumn48 = new UltraGridColumn("voided");
    Appearance appearance186 = new Appearance();
    Appearance appearance187 = new Appearance();
    UltraGridColumn ultraGridColumn49 = new UltraGridColumn("ARApplied");
    Appearance appearance188 = new Appearance();
    Appearance appearance189 = new Appearance();
    UltraGridColumn ultraGridColumn50 = new UltraGridColumn("APApplied");
    Appearance appearance190 = new Appearance();
    Appearance appearance191 = new Appearance();
    UltraGridColumn ultraGridColumn51 = new UltraGridColumn("ExchApplied");
    Appearance appearance192 = new Appearance();
    Appearance appearance193 = new Appearance();
    UltraGridColumn ultraGridColumn52 = new UltraGridColumn("UnacctApplied");
    Appearance appearance194 = new Appearance();
    Appearance appearance195 = new Appearance();
    UltraGridColumn ultraGridColumn53 = new UltraGridColumn("IncomeApplied");
    Appearance appearance196 = new Appearance();
    Appearance appearance197 = new Appearance();
    UltraGridColumn ultraGridColumn54 = new UltraGridColumn("Check Number");
    UltraGridColumn ultraGridColumn55 = new UltraGridColumn("Invoice #");
    Appearance appearance198 = new Appearance();
    SummarySettings summarySettings22 = new SummarySettings("", (SummaryType) 1, (string) null, "ARApplied", 6, true, "PolicyActivity", 0, (SummaryPosition) 3, "ARApplied", 6, true);
    Appearance appearance199 = new Appearance();
    SummarySettings summarySettings23 = new SummarySettings("", (SummaryType) 1, (string) null, "APApplied", 7, true, "PolicyActivity", 0, (SummaryPosition) 3, "APApplied", 7, true);
    Appearance appearance200 = new Appearance();
    SummarySettings summarySettings24 = new SummarySettings("", (SummaryType) 1, (string) null, "ExchApplied", 8, true, "PolicyActivity", 0, (SummaryPosition) 3, "ExchApplied", 8, true);
    Appearance appearance201 = new Appearance();
    SummarySettings summarySettings25 = new SummarySettings("", (SummaryType) 1, (string) null, "UnacctApplied", 9, true, "PolicyActivity", 0, (SummaryPosition) 3, "UnacctApplied", 9, true);
    Appearance appearance202 = new Appearance();
    SummarySettings summarySettings26 = new SummarySettings("", (SummaryType) 1, (string) null, "IncomeApplied", 10, true, "PolicyActivity", 0, (SummaryPosition) 3, "IncomeApplied", 10, true);
    Appearance appearance203 = new Appearance();
    Appearance appearance204 = new Appearance();
    Appearance appearance205 = new Appearance();
    Appearance appearance206 = new Appearance();
    Appearance appearance207 = new Appearance();
    Appearance appearance208 = new Appearance();
    Appearance appearance209 = new Appearance();
    ScrollBarLook scrollBarLook8 = new ScrollBarLook();
    Appearance appearance210 = new Appearance();
    Appearance appearance211 = new Appearance();
    UltraGridLayout ultraGridLayout4 = new UltraGridLayout("lyt1");
    Appearance appearance212 = new Appearance();
    UltraGridBand ultraGridBand9 = new UltraGridBand("PolicyActivity", -1);
    UltraGridColumn ultraGridColumn56 = new UltraGridColumn("transactNum");
    Appearance appearance213 = new Appearance();
    Appearance appearance214 = new Appearance();
    UltraGridColumn ultraGridColumn57 = new UltraGridColumn("transDescription");
    Appearance appearance215 = new Appearance();
    Appearance appearance216 = new Appearance();
    UltraGridColumn ultraGridColumn58 = new UltraGridColumn("postDate");
    Appearance appearance217 = new Appearance();
    Appearance appearance218 = new Appearance();
    UltraGridColumn ultraGridColumn59 = new UltraGridColumn("Received");
    Appearance appearance219 = new Appearance();
    Appearance appearance220 = new Appearance();
    UltraGridColumn ultraGridColumn60 = new UltraGridColumn("User");
    Appearance appearance221 = new Appearance();
    Appearance appearance222 = new Appearance();
    UltraGridColumn ultraGridColumn61 = new UltraGridColumn("voided");
    Appearance appearance223 = new Appearance();
    Appearance appearance224 = new Appearance();
    UltraGridColumn ultraGridColumn62 = new UltraGridColumn("ARApplied");
    Appearance appearance225 = new Appearance();
    Appearance appearance226 = new Appearance();
    UltraGridColumn ultraGridColumn63 = new UltraGridColumn("APApplied");
    Appearance appearance227 = new Appearance();
    Appearance appearance228 = new Appearance();
    UltraGridColumn ultraGridColumn64 = new UltraGridColumn("ExchApplied");
    Appearance appearance229 = new Appearance();
    Appearance appearance230 = new Appearance();
    UltraGridColumn ultraGridColumn65 = new UltraGridColumn("UnacctApplied");
    Appearance appearance231 = new Appearance();
    Appearance appearance232 = new Appearance();
    UltraGridColumn ultraGridColumn66 = new UltraGridColumn("IncomeApplied");
    Appearance appearance233 = new Appearance();
    Appearance appearance234 = new Appearance();
    UltraGridColumn ultraGridColumn67 = new UltraGridColumn("Check Number");
    UltraGridColumn ultraGridColumn68 = new UltraGridColumn("Invoice #");
    Appearance appearance235 = new Appearance();
    SummarySettings summarySettings27 = new SummarySettings("", (SummaryType) 1, (string) null, "ARApplied", 6, true, "PolicyActivity", 0, (SummaryPosition) 3, "ARApplied", 6, true);
    Appearance appearance236 = new Appearance();
    SummarySettings summarySettings28 = new SummarySettings("", (SummaryType) 1, (string) null, "APApplied", 7, true, "PolicyActivity", 0, (SummaryPosition) 3, "APApplied", 7, true);
    Appearance appearance237 = new Appearance();
    SummarySettings summarySettings29 = new SummarySettings("", (SummaryType) 1, (string) null, "ExchApplied", 8, true, "PolicyActivity", 0, (SummaryPosition) 3, "ExchApplied", 8, true);
    Appearance appearance238 = new Appearance();
    SummarySettings summarySettings30 = new SummarySettings("", (SummaryType) 1, (string) null, "UnacctApplied", 9, true, "PolicyActivity", 0, (SummaryPosition) 3, "UnacctApplied", 9, true);
    Appearance appearance239 = new Appearance();
    SummarySettings summarySettings31 = new SummarySettings("", (SummaryType) 1, (string) null, "IncomeApplied", 10, true, "PolicyActivity", 0, (SummaryPosition) 3, "IncomeApplied", 10, true);
    Appearance appearance240 = new Appearance();
    Appearance appearance241 = new Appearance();
    Appearance appearance242 = new Appearance();
    Appearance appearance243 = new Appearance();
    Appearance appearance244 = new Appearance();
    Appearance appearance245 = new Appearance();
    Appearance appearance246 = new Appearance();
    ScrollBarLook scrollBarLook9 = new ScrollBarLook();
    Appearance appearance247 = new Appearance();
    Appearance appearance248 = new Appearance();
    Appearance appearance249 = new Appearance();
    UltraGridBand ultraGridBand10 = new UltraGridBand("ReinstatementInformation", -1);
    UltraGridColumn ultraGridColumn69 = new UltraGridColumn("IssuedMessage");
    Appearance appearance250 = new Appearance();
    UltraGridColumn ultraGridColumn70 = new UltraGridColumn("EffectiveMessage");
    Appearance appearance251 = new Appearance();
    Appearance appearance252 = new Appearance();
    Appearance appearance253 = new Appearance();
    Appearance appearance254 = new Appearance();
    Appearance appearance255 = new Appearance();
    Appearance appearance256 = new Appearance();
    Appearance appearance257 = new Appearance();
    ScrollBarLook scrollBarLook10 = new ScrollBarLook();
    Appearance appearance258 = new Appearance();
    Appearance appearance259 = new Appearance();
    Appearance appearance260 = new Appearance();
    UltraGridBand ultraGridBand11 = new UltraGridBand("CancellationInformation", -1);
    UltraGridColumn ultraGridColumn71 = new UltraGridColumn("IssuanceDate");
    Appearance appearance261 = new Appearance();
    UltraGridColumn ultraGridColumn72 = new UltraGridColumn("Message");
    Appearance appearance262 = new Appearance();
    UltraGridColumn ultraGridColumn73 = new UltraGridColumn("PastDueAmt");
    Appearance appearance263 = new Appearance();
    Appearance appearance264 = new Appearance();
    UltraGridColumn ultraGridColumn74 = new UltraGridColumn("CancellationDate");
    Appearance appearance265 = new Appearance();
    UltraGridColumn ultraGridColumn75 = new UltraGridColumn("CancellationMessage");
    Appearance appearance266 = new Appearance();
    Appearance appearance267 = new Appearance();
    Appearance appearance268 = new Appearance();
    Appearance appearance269 = new Appearance();
    Appearance appearance270 = new Appearance();
    Appearance appearance271 = new Appearance();
    Appearance appearance272 = new Appearance();
    ScrollBarLook scrollBarLook11 = new ScrollBarLook();
    Appearance appearance273 = new Appearance();
    Appearance appearance274 = new Appearance();
    Appearance appearance275 = new Appearance();
    UltraGridBand ultraGridBand12 = new UltraGridBand("PolicyStatusChanges", -1);
    UltraGridColumn ultraGridColumn76 = new UltraGridColumn("Status");
    Appearance appearance276 = new Appearance();
    UltraGridColumn ultraGridColumn77 = new UltraGridColumn("Reason");
    Appearance appearance277 = new Appearance();
    UltraGridColumn ultraGridColumn78 = new UltraGridColumn("DateChanged");
    Appearance appearance278 = new Appearance();
    Appearance appearance279 = new Appearance();
    Appearance appearance280 = new Appearance();
    Appearance appearance281 = new Appearance();
    Appearance appearance282 = new Appearance();
    Appearance appearance283 = new Appearance();
    Appearance appearance284 = new Appearance();
    ScrollBarLook scrollBarLook12 = new ScrollBarLook();
    Appearance appearance285 = new Appearance();
    Appearance appearance286 = new Appearance();
    Appearance appearance287 = new Appearance();
    Appearance appearance288 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance289 = new Appearance();
    Appearance appearance290 = new Appearance();
    UltraTab ultraTab3 = new UltraTab();
    UltraTab ultraTab4 = new UltraTab();
    Appearance appearance291 = new Appearance();
    UltraGridBand ultraGridBand13 = new UltraGridBand("PolicyInquiryComments", -1);
    UltraGridColumn ultraGridColumn79 = new UltraGridColumn("CommentId");
    UltraGridColumn ultraGridColumn80 = new UltraGridColumn("CommentDate");
    UltraGridColumn ultraGridColumn81 = new UltraGridColumn("UserName");
    UltraGridColumn ultraGridColumn82 = new UltraGridColumn("Comment");
    Appearance appearance292 = new Appearance();
    Appearance appearance293 = new Appearance();
    Appearance appearance294 = new Appearance();
    Appearance appearance295 = new Appearance();
    Appearance appearance296 = new Appearance();
    Appearance appearance297 = new Appearance();
    ScrollBarLook scrollBarLook13 = new ScrollBarLook();
    Appearance appearance298 = new Appearance();
    Appearance appearance299 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formPolicyInquiry));
    Appearance appearance300 = new Appearance();
    UltraTab ultraTab5 = new UltraTab();
    Appearance appearance301 = new Appearance();
    UltraTab ultraTab6 = new UltraTab();
    Appearance appearance302 = new Appearance();
    UltraTab ultraTab7 = new UltraTab();
    Appearance appearance303 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("PolicyInquiry");
    ButtonTool buttonTool1 = new ButtonTool("FINDPOLICY");
    ButtonTool buttonTool2 = new ButtonTool("CLEAR");
    ButtonTool buttonTool3 = new ButtonTool("CANCEL");
    ButtonTool buttonTool4 = new ButtonTool("ReprintNotice");
    ButtonTool buttonTool5 = new ButtonTool("REINSTATE");
    ButtonTool buttonTool6 = new ButtonTool("REFRESH");
    ButtonTool buttonTool7 = new ButtonTool("PREVIOUS");
    ButtonTool buttonTool8 = new ButtonTool("NEXTPOLICY");
    ButtonTool buttonTool9 = new ButtonTool("PRINT");
    ButtonTool buttonTool10 = new ButtonTool("FINANCECOMPANY");
    LabelTool labelTool1 = new LabelTool("FINANCEINFO");
    ButtonTool buttonTool11 = new ButtonTool("FINDPOLICY");
    Appearance appearance304 = new Appearance();
    ButtonTool buttonTool12 = new ButtonTool("CLEAR");
    Appearance appearance305 = new Appearance();
    ButtonTool buttonTool13 = new ButtonTool("CANCEL");
    Appearance appearance306 = new Appearance();
    ButtonTool buttonTool14 = new ButtonTool("REINSTATE");
    Appearance appearance307 = new Appearance();
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("InvoiceListingContext");
    ButtonTool buttonTool15 = new ButtonTool("VIEWINVOICE");
    ButtonTool buttonTool16 = new ButtonTool("INVOICEPAYEES");
    ButtonTool buttonTool17 = new ButtonTool("VIEWINVOICE");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("InvoiceActivityContext");
    Appearance appearance308 = new Appearance();
    ButtonTool buttonTool18 = new ButtonTool("TRANSACTIONDETAIL");
    ButtonTool buttonTool19 = new ButtonTool("TransactionComments");
    ButtonTool buttonTool20 = new ButtonTool("VIEWPAYSUM");
    ButtonTool buttonTool21 = new ButtonTool("FORCECOMM");
    ButtonTool buttonTool22 = new ButtonTool("TRANSACTIONDETAIL");
    Appearance appearance309 = new Appearance();
    PopupMenuTool popupMenuTool3 = new PopupMenuTool("StatusGridContextMenu");
    ButtonTool buttonTool23 = new ButtonTool("ReprintNotice");
    ButtonTool buttonTool24 = new ButtonTool("ReprintNotice");
    Appearance appearance310 = new Appearance();
    PopupMenuTool popupMenuTool4 = new PopupMenuTool("CommentsMenu");
    ButtonTool buttonTool25 = new ButtonTool("AddComment");
    ButtonTool buttonTool26 = new ButtonTool("EditComment");
    ButtonTool buttonTool27 = new ButtonTool("DeleteComment");
    ButtonTool buttonTool28 = new ButtonTool("AddComment");
    ButtonTool buttonTool29 = new ButtonTool("EditComment");
    ButtonTool buttonTool30 = new ButtonTool("DeleteComment");
    ButtonTool buttonTool31 = new ButtonTool("TransactionComments");
    Appearance appearance311 = new Appearance();
    ButtonTool buttonTool32 = new ButtonTool("VIEWPAYSUM");
    Appearance appearance312 = new Appearance();
    ButtonTool buttonTool33 = new ButtonTool("REFRESH");
    Appearance appearance313 = new Appearance();
    ButtonTool buttonTool34 = new ButtonTool("PREVIOUS");
    ButtonTool buttonTool35 = new ButtonTool("NEXTPOLICY");
    ButtonTool buttonTool36 = new ButtonTool("INVOICEPAYEES");
    Appearance appearance314 = new Appearance();
    ButtonTool buttonTool37 = new ButtonTool("PRINT");
    Appearance appearance315 = new Appearance();
    ButtonTool buttonTool38 = new ButtonTool("FORCECOMM");
    Appearance appearance316 = new Appearance();
    ButtonTool buttonTool39 = new ButtonTool("FINANCECOMPANY");
    Appearance appearance317 = new Appearance();
    LabelTool labelTool2 = new LabelTool("FINANCEINFO");
    Appearance appearance318 = new Appearance();
    Appearance appearance319 = new Appearance();
    Appearance appearance320 = new Appearance();
    Appearance appearance321 = new Appearance();
    Appearance appearance322 = new Appearance();
    Appearance appearance323 = new Appearance();
    Appearance appearance324 = new Appearance();
    ScrollBarLook scrollBarLook14 = new ScrollBarLook();
    Appearance appearance325 = new Appearance();
    Appearance appearance326 = new Appearance();
    Appearance appearance327 = new Appearance();
    Appearance appearance328 = new Appearance();
    Appearance appearance329 = new Appearance();
    Appearance appearance330 = new Appearance();
    Appearance appearance331 = new Appearance();
    Appearance appearance332 = new Appearance();
    Appearance appearance333 = new Appearance();
    ScrollBarLook scrollBarLook15 = new ScrollBarLook();
    Appearance appearance334 = new Appearance();
    Appearance appearance335 = new Appearance();
    Appearance appearance336 = new Appearance();
    Appearance appearance337 = new Appearance();
    Appearance appearance338 = new Appearance();
    Appearance appearance339 = new Appearance();
    Appearance appearance340 = new Appearance();
    Appearance appearance341 = new Appearance();
    Appearance appearance342 = new Appearance();
    ScrollBarLook scrollBarLook16 = new ScrollBarLook();
    Appearance appearance343 = new Appearance();
    Appearance appearance344 = new Appearance();
    Appearance appearance345 = new Appearance();
    Appearance appearance346 = new Appearance();
    Appearance appearance347 = new Appearance();
    Appearance appearance348 = new Appearance();
    Appearance appearance349 = new Appearance();
    Appearance appearance350 = new Appearance();
    Appearance appearance351 = new Appearance();
    ScrollBarLook scrollBarLook17 = new ScrollBarLook();
    Appearance appearance352 = new Appearance();
    Appearance appearance353 = new Appearance();
    Appearance appearance354 = new Appearance();
    this.UltraTabPageControl3 = new UltraTabPageControl();
    this.panelChangeDueDate = new Panel();
    this.buttonCloseChangeDueDate = new MGAButton();
    this.mgaGroupBox1 = new MGAGroupBox();
    this.buttonSaveDueDate = new MGAButton();
    this.dateNewDueDate = new MGADateTimePicker();
    this.label38 = new Label();
    this.linkChangeTransactionDate = new LinkLabel();
    this.panelChangeTransactionDate = new Panel();
    this.buttonCloseChangeTransactionDate = new MGAButton();
    this.mgaGroupBox3 = new MGAGroupBox();
    this.buttonSaveTransactionDate = new MGAButton();
    this.dateTimeNewTransactionDate = new MGADateTimePicker();
    this.label40 = new Label();
    this.panelChangeBillDate = new Panel();
    this.buttonCloseChangeBillDate = new MGAButton();
    this.mgaGroupBox2 = new MGAGroupBox();
    this.buttonSaveChangeBillDate = new MGAButton();
    this.dateNewBillDate = new MGADateTimePicker();
    this.label39 = new Label();
    this.linkChangeDueDate = new LinkLabel();
    this.linkChangeBillDate = new LinkLabel();
    this.lblInvoiceDueDate = new Label();
    this.Label37 = new Label();
    this.ElipsePanel3 = new EllipsePanel();
    this.Label33 = new Label();
    this.lblNetDueCalculation = new Label();
    this.lblFeesCalculation = new Label();
    this.Label35 = new Label();
    this.lblPremiumCalculation = new Label();
    this.lblBrokerCommissionCalculation = new Label();
    this.Label17 = new Label();
    this.Label24 = new Label();
    this.Label31 = new Label();
    this.Label29 = new Label();
    this.Label21 = new Label();
    this.gridInvoiceFeeLines = new UltraGrid();
    this.dsPolicyInformation1 = new dsPolicyInformation();
    this.gridInvoicePremiumLines = new UltraGrid();
    this.lblDueCompany = new Label();
    this.Label34 = new Label();
    this.lblInvoiceBrokerCommission = new Label();
    this.Label32 = new Label();
    this.lblInvoiceGrossCommission = new Label();
    this.Label30 = new Label();
    this.Label28 = new Label();
    this.lblEndorsementNumber = new Label();
    this.Label26 = new Label();
    this.lblInvoiceDateBilled = new Label();
    this.Label14 = new Label();
    this.lblInvoiceExpirationDate = new Label();
    this.Label18 = new Label();
    this.lblInvoiceEffectiveDate = new Label();
    this.Label20 = new Label();
    this.Label9 = new Label();
    this.Label27 = new Label();
    this.UltraTabPageControl4 = new UltraTabPageControl();
    this.transactionCommentsViewer1 = new TransactionCommentsViewer();
    this.gridInvoiceActivity = new UltraGrid();
    this.ultraTabPageControl8 = new UltraTabPageControl();
    this.gridInvoiceListing = new UltraGrid();
    this.ultraTabPageControl9 = new UltraTabPageControl();
    this.gridPolicyActivity = new UltraGrid();
    this.UltraTabPageControl1 = new UltraTabPageControl();
    this.ellipsePanel1 = new EllipsePanel();
    this.ultraGrid2 = new UltraGrid();
    this.UltraGrid1 = new UltraGrid();
    this.label36 = new Label();
    this.ElipsePanel1 = new EllipsePanel();
    this.gridStatusChanges = new UltraGrid();
    this.Label25 = new Label();
    this.UltraTabPageControl2 = new UltraTabPageControl();
    this.invoicePayeeBreakout1 = new InvoicePayeeBreakout();
    this.transactionCommentsViewer2 = new TransactionCommentsViewer();
    this.panelInvoiceActivity = new EllipsePanel();
    this.chkShowVoids = new CheckBox();
    this.utcInvoiceActivity = new UltraTabControl();
    this.UltraTabSharedControlsPage2 = new UltraTabSharedControlsPage();
    this.panelInvoiceActivityCurtain = new EllipsePanel();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.Label2 = new Label();
    this.ElipsePanel2 = new EllipsePanel();
    this.ultraTabControl4 = new UltraTabControl();
    this.ultraTabSharedControlsPage5 = new UltraTabSharedControlsPage();
    this.UltraTabPageControl5 = new UltraTabPageControl();
    this.gridPolicyInquiryComments = new UltraGrid();
    this.daPolicyInquiryInvoicePremiumLines = new SqlDataAdapter();
    this.SqlSelectCommand6 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.daPolicyInquiryHeader = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ImageList1 = new ImageList(this.components);
    this.daPolicyInquiryPolicyStatus = new SqlDataAdapter();
    this.SqlSelectCommand2 = new SqlCommand();
    this.panelPolicyInquiry2 = new Panel();
    this.UltraTabControl1 = new UltraTabControl();
    this.UltraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.lblCostCenter = new Label();
    this.label66 = new Label();
    this.checkDisableNOC = new CheckBox();
    this.labelOfficeLocation = new Label();
    this.label69 = new Label();
    this.lblBillingType = new Label();
    this.label67 = new Label();
    this.labelCurrency = new Label();
    this.label68 = new Label();
    this.lblCurrentStatus = new Label();
    this.Label19 = new Label();
    this.Label15 = new Label();
    this.lblExpirationDate = new Label();
    this.Label11 = new Label();
    this.lblControlNumber = new Label();
    this.Label23 = new Label();
    this.lblUnderwriter = new Label();
    this.Label22 = new Label();
    this.lblCompany = new Label();
    this.lblProducer = new Label();
    this.lblEffectiveDate = new Label();
    this.lblInsured = new Label();
    this.lblPolicyNumber = new Label();
    this.Label13 = new Label();
    this.Label12 = new Label();
    this.Label10 = new Label();
    this.Label6 = new Label();
    this.Label3 = new Label();
    this.panelCurtain = new EllipsePanel();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Label1 = new Label();
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.ultraGrid5 = new UltraGrid();
    this.ultraGrid6 = new UltraGrid();
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this.daPolicyInquiryInvoices = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.daPolicyInquiryInvoiceDetails = new SqlDataAdapter();
    this.SqlSelectCommand5 = new SqlCommand();
    this.daPolicyInquiryInvoiceActivity = new SqlDataAdapter();
    this.SqlSelectCommand4 = new SqlCommand();
    this.SqlSelectCommand8 = new SqlCommand();
    this.daPolicyInquiryCancellationInformation = new SqlDataAdapter();
    this.SqlSelectCommand7 = new SqlCommand();
    this.daPolicyInquiryInvoiceFeeLines = new SqlDataAdapter();
    this.daGetPolicyInquiryComments = new SqlDataAdapter();
    this.sqlSelectCommand9 = new SqlCommand();
    this.daPolicyInquiryReinstatementInformation = new SqlDataAdapter();
    this.sqlSelectCommand10 = new SqlCommand();
    this.ultraTabControl2 = new UltraTabControl();
    this.ultraTabSharedControlsPage3 = new UltraTabSharedControlsPage();
    this.ultraTabPageControl6 = new UltraTabPageControl();
    this.ellipsePanel2 = new EllipsePanel();
    this.ultraGrid3 = new UltraGrid();
    this.ultraGrid4 = new UltraGrid();
    this.label60 = new Label();
    this.ellipsePanel3 = new EllipsePanel();
    this.label61 = new Label();
    this.checkBox1 = new CheckBox();
    this.label41 = new Label();
    this.label42 = new Label();
    this.label43 = new Label();
    this.label44 = new Label();
    this.label45 = new Label();
    this.label46 = new Label();
    this.label47 = new Label();
    this.label48 = new Label();
    this.label49 = new Label();
    this.label50 = new Label();
    this.label51 = new Label();
    this.label52 = new Label();
    this.label53 = new Label();
    this.label54 = new Label();
    this.label55 = new Label();
    this.label56 = new Label();
    this.label57 = new Label();
    this.label58 = new Label();
    this.label59 = new Label();
    this.ultraTabPageControl7 = new UltraTabPageControl();
    this.ellipsePanel4 = new EllipsePanel();
    this.label62 = new Label();
    this.ultraTabControl3 = new UltraTabControl();
    this.ultraTabSharedControlsPage4 = new UltraTabSharedControlsPage();
    this.daPolicyInquiryPolicyActivity = new SqlDataAdapter();
    this.sqlCommand1 = new SqlCommand();
    this.toolTip1 = new ToolTip(this.components);
    this.ellipsePanel5 = new EllipsePanel();
    this.ellipsePanel6 = new EllipsePanel();
    this.label63 = new Label();
    this.label64 = new Label();
    this.label65 = new Label();
    this.checkBox2 = new CheckBox();
    ((Control) this.UltraTabPageControl3).SuspendLayout();
    this.panelChangeDueDate.SuspendLayout();
    ((ISupportInitialize) this.buttonCloseChangeDueDate).BeginInit();
    ((ISupportInitialize) this.mgaGroupBox1).BeginInit();
    ((Control) this.mgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.buttonSaveDueDate).BeginInit();
    ((ISupportInitialize) this.dateNewDueDate).BeginInit();
    this.panelChangeTransactionDate.SuspendLayout();
    ((ISupportInitialize) this.buttonCloseChangeTransactionDate).BeginInit();
    ((ISupportInitialize) this.mgaGroupBox3).BeginInit();
    ((Control) this.mgaGroupBox3).SuspendLayout();
    ((ISupportInitialize) this.buttonSaveTransactionDate).BeginInit();
    ((ISupportInitialize) this.dateTimeNewTransactionDate).BeginInit();
    this.panelChangeBillDate.SuspendLayout();
    ((ISupportInitialize) this.buttonCloseChangeBillDate).BeginInit();
    ((ISupportInitialize) this.mgaGroupBox2).BeginInit();
    ((Control) this.mgaGroupBox2).SuspendLayout();
    ((ISupportInitialize) this.buttonSaveChangeBillDate).BeginInit();
    ((ISupportInitialize) this.dateNewBillDate).BeginInit();
    this.ElipsePanel3.SuspendLayout();
    ((ISupportInitialize) this.gridInvoiceFeeLines).BeginInit();
    this.dsPolicyInformation1.BeginInit();
    ((ISupportInitialize) this.gridInvoicePremiumLines).BeginInit();
    ((Control) this.UltraTabPageControl4).SuspendLayout();
    ((ISupportInitialize) this.gridInvoiceActivity).BeginInit();
    ((Control) this.ultraTabPageControl8).SuspendLayout();
    ((ISupportInitialize) this.gridInvoiceListing).BeginInit();
    ((Control) this.ultraTabPageControl9).SuspendLayout();
    ((ISupportInitialize) this.gridPolicyActivity).BeginInit();
    ((Control) this.UltraTabPageControl1).SuspendLayout();
    this.ellipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.ultraGrid2).BeginInit();
    ((ISupportInitialize) this.UltraGrid1).BeginInit();
    this.ElipsePanel1.SuspendLayout();
    ((ISupportInitialize) this.gridStatusChanges).BeginInit();
    ((Control) this.UltraTabPageControl2).SuspendLayout();
    this.panelInvoiceActivity.SuspendLayout();
    ((ISupportInitialize) this.utcInvoiceActivity).BeginInit();
    ((Control) this.utcInvoiceActivity).SuspendLayout();
    this.panelInvoiceActivityCurtain.SuspendLayout();
    this.ElipsePanel2.SuspendLayout();
    ((ISupportInitialize) this.ultraTabControl4).BeginInit();
    ((Control) this.ultraTabControl4).SuspendLayout();
    ((Control) this.UltraTabPageControl5).SuspendLayout();
    ((ISupportInitialize) this.gridPolicyInquiryComments).BeginInit();
    this.panelPolicyInquiry2.SuspendLayout();
    ((ISupportInitialize) this.UltraTabControl1).BeginInit();
    ((Control) this.UltraTabControl1).SuspendLayout();
    ((Control) this.UltraTabSharedControlsPage1).SuspendLayout();
    this.panelCurtain.SuspendLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.ultraGrid5).BeginInit();
    ((ISupportInitialize) this.ultraGrid6).BeginInit();
    ((ISupportInitialize) this.ultraTabControl2).BeginInit();
    ((Control) this.ultraTabControl2).SuspendLayout();
    ((Control) this.ultraTabPageControl6).SuspendLayout();
    this.ellipsePanel2.SuspendLayout();
    ((ISupportInitialize) this.ultraGrid3).BeginInit();
    ((ISupportInitialize) this.ultraGrid4).BeginInit();
    this.ellipsePanel3.SuspendLayout();
    ((Control) this.ultraTabPageControl7).SuspendLayout();
    this.ellipsePanel4.SuspendLayout();
    ((ISupportInitialize) this.ultraTabControl3).BeginInit();
    this.ellipsePanel5.SuspendLayout();
    this.ellipsePanel6.SuspendLayout();
    this.SuspendLayout();
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.panelChangeDueDate);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.linkChangeTransactionDate);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.panelChangeTransactionDate);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.panelChangeBillDate);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.linkChangeDueDate);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.linkChangeBillDate);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblInvoiceDueDate);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label37);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.ElipsePanel3);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.gridInvoiceFeeLines);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.gridInvoicePremiumLines);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblDueCompany);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label34);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblInvoiceBrokerCommission);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label32);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblInvoiceGrossCommission);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label30);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label28);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblEndorsementNumber);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label26);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblInvoiceDateBilled);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label14);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblInvoiceExpirationDate);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label18);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.lblInvoiceEffectiveDate);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label20);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label9);
    ((Control) this.UltraTabPageControl3).Controls.Add((Control) this.Label27);
    ((Control) this.UltraTabPageControl3).Location = new Point(1, 20);
    ((Control) this.UltraTabPageControl3).Name = "UltraTabPageControl3";
    ((Control) this.UltraTabPageControl3).Size = new Size(836, 299);
    this.panelChangeDueDate.Controls.Add((Control) this.buttonCloseChangeDueDate);
    this.panelChangeDueDate.Controls.Add((Control) this.mgaGroupBox1);
    this.panelChangeDueDate.Location = new Point(216, 120);
    this.panelChangeDueDate.Name = "panelChangeDueDate";
    this.panelChangeDueDate.Size = new Size(168, 88);
    this.panelChangeDueDate.TabIndex = 54;
    this.panelChangeDueDate.Visible = false;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCloseChangeDueDate).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonCloseChangeDueDate).Location = new Point(148, 4);
    ((Control) this.buttonCloseChangeDueDate).Name = "buttonCloseChangeDueDate";
    ((Control) this.buttonCloseChangeDueDate).Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    ((Control) this.buttonCloseChangeDueDate).TabIndex = 1;
    ((Control) this.buttonCloseChangeDueDate).Text = "X";
    ((UltraControlBase) this.buttonCloseChangeDueDate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCloseChangeDueDate).Click += new EventHandler(this.buttonCloseChangeDueDate_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.buttonSaveDueDate);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.dateNewDueDate);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label38);
    ((AppearanceBase) appearance3).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance3).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance3).ForeColor = Color.White;
    ((AppearanceBase) appearance3).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance3).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.mgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.mgaGroupBox1).Location = new Point(0, 0);
    ((Control) this.mgaGroupBox1).Name = "mgaGroupBox1";
    ((Control) this.mgaGroupBox1).Size = new Size(168, 88);
    ((Control) this.mgaGroupBox1).TabIndex = 0;
    ((Control) this.mgaGroupBox1).Text = "Select a New Due Date";
    this.mgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance4).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance4).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance4).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSaveDueDate).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonSaveDueDate).Location = new Point(64 /*0x40*/, 56);
    ((Control) this.buttonSaveDueDate).Name = "buttonSaveDueDate";
    ((Control) this.buttonSaveDueDate).Size = new Size(88, 24);
    ((Control) this.buttonSaveDueDate).TabIndex = 2;
    ((Control) this.buttonSaveDueDate).Text = "Save Due Date";
    ((UltraControlBase) this.buttonSaveDueDate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSaveDueDate).Click += new EventHandler(this.buttonSaveDueDate_Click);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateNewDueDate.Appearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance6).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance6).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance6).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance6).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance6).ForegroundAlpha = (Alpha) 2;
    this.dateNewDueDate.ButtonAppearance = (AppearanceBase) appearance6;
    this.dateNewDueDate.DateTime = DateTime.Now;
    ((Control) this.dateNewDueDate).Location = new Point(64 /*0x40*/, 32 /*0x20*/);
    this.dateNewDueDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateNewDueDate).Name = "dateNewDueDate";
    ((Control) this.dateNewDueDate).Size = new Size(88, 20);
    ((Control) this.dateNewDueDate).TabIndex = 1;
    ((UltraControlBase) this.dateNewDueDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateNewDueDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dateNewDueDate.Value = (object) DateTime.Now;
    this.label38.AutoSize = true;
    this.label38.Location = new Point(8, 32 /*0x20*/);
    this.label38.Name = "label38";
    this.label38.Size = new Size(58, 13);
    this.label38.TabIndex = 0;
    this.label38.Text = "New Date:";
    this.linkChangeTransactionDate.AutoSize = true;
    this.linkChangeTransactionDate.Location = new Point(112 /*0x70*/, 152);
    this.linkChangeTransactionDate.Name = "linkChangeTransactionDate";
    this.linkChangeTransactionDate.Size = new Size(104, 13);
    this.linkChangeTransactionDate.TabIndex = 57;
    this.linkChangeTransactionDate.TabStop = true;
    this.linkChangeTransactionDate.Text = "Change Trans. Date";
    this.linkChangeTransactionDate.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkChangeTransactionDate_LinkClicked);
    this.panelChangeTransactionDate.Controls.Add((Control) this.buttonCloseChangeTransactionDate);
    this.panelChangeTransactionDate.Controls.Add((Control) this.mgaGroupBox3);
    this.panelChangeTransactionDate.Location = new Point(216, 160 /*0xA0*/);
    this.panelChangeTransactionDate.Name = "panelChangeTransactionDate";
    this.panelChangeTransactionDate.Size = new Size(168, 88);
    this.panelChangeTransactionDate.TabIndex = 56;
    this.panelChangeTransactionDate.Visible = false;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance7).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance7).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCloseChangeTransactionDate).Appearance = (AppearanceBase) appearance7;
    ((Control) this.buttonCloseChangeTransactionDate).Location = new Point(148, 4);
    ((Control) this.buttonCloseChangeTransactionDate).Name = "buttonCloseChangeTransactionDate";
    ((Control) this.buttonCloseChangeTransactionDate).Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    ((Control) this.buttonCloseChangeTransactionDate).TabIndex = 1;
    ((Control) this.buttonCloseChangeTransactionDate).Text = "X";
    ((UltraControlBase) this.buttonCloseChangeTransactionDate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCloseChangeTransactionDate).Click += new EventHandler(this.buttonCloseChangeTransactionDate_Click);
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mgaGroupBox3.ContentAreaAppearance = (AppearanceBase) appearance8;
    ((Control) this.mgaGroupBox3).Controls.Add((Control) this.buttonSaveTransactionDate);
    ((Control) this.mgaGroupBox3).Controls.Add((Control) this.dateTimeNewTransactionDate);
    ((Control) this.mgaGroupBox3).Controls.Add((Control) this.label40);
    ((AppearanceBase) appearance9).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance9).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance9).ForeColor = Color.White;
    ((AppearanceBase) appearance9).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance9).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.mgaGroupBox3.HeaderAppearance = (AppearanceBase) appearance9;
    ((Control) this.mgaGroupBox3).Location = new Point(0, 0);
    ((Control) this.mgaGroupBox3).Name = "mgaGroupBox3";
    ((Control) this.mgaGroupBox3).Size = new Size(168, 88);
    ((Control) this.mgaGroupBox3).TabIndex = 0;
    ((Control) this.mgaGroupBox3).Text = "Select a New Trx. Date";
    this.mgaGroupBox3.ViewStyle = (GroupBoxViewStyle) 2;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance10).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance10).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSaveTransactionDate).Appearance = (AppearanceBase) appearance10;
    ((Control) this.buttonSaveTransactionDate).Location = new Point(64 /*0x40*/, 56);
    ((Control) this.buttonSaveTransactionDate).Name = "buttonSaveTransactionDate";
    ((Control) this.buttonSaveTransactionDate).Size = new Size(88, 24);
    ((Control) this.buttonSaveTransactionDate).TabIndex = 2;
    ((Control) this.buttonSaveTransactionDate).Text = "Save Trx. Date";
    ((UltraControlBase) this.buttonSaveTransactionDate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSaveTransactionDate).Click += new EventHandler(this.buttonSaveTransactionDate_Click);
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeNewTransactionDate.Appearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance12).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance12).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance12).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance12).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance12).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance12).ForegroundAlpha = (Alpha) 2;
    this.dateTimeNewTransactionDate.ButtonAppearance = (AppearanceBase) appearance12;
    this.dateTimeNewTransactionDate.DateTime = DateTime.Now;
    ((Control) this.dateTimeNewTransactionDate).Location = new Point(64 /*0x40*/, 32 /*0x20*/);
    this.dateTimeNewTransactionDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeNewTransactionDate).Name = "dateTimeNewTransactionDate";
    ((Control) this.dateTimeNewTransactionDate).Size = new Size(88, 20);
    ((Control) this.dateTimeNewTransactionDate).TabIndex = 1;
    ((UltraControlBase) this.dateTimeNewTransactionDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeNewTransactionDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dateTimeNewTransactionDate.Value = (object) DateTime.Now;
    this.label40.AutoSize = true;
    this.label40.Location = new Point(8, 32 /*0x20*/);
    this.label40.Name = "label40";
    this.label40.Size = new Size(58, 13);
    this.label40.TabIndex = 0;
    this.label40.Text = "New Date:";
    this.panelChangeBillDate.Controls.Add((Control) this.buttonCloseChangeBillDate);
    this.panelChangeBillDate.Controls.Add((Control) this.mgaGroupBox2);
    this.panelChangeBillDate.Location = new Point(216, 72);
    this.panelChangeBillDate.Name = "panelChangeBillDate";
    this.panelChangeBillDate.Size = new Size(168, 88);
    this.panelChangeBillDate.TabIndex = 55;
    this.panelChangeBillDate.Visible = false;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance13).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance13).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance13).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCloseChangeBillDate).Appearance = (AppearanceBase) appearance13;
    ((Control) this.buttonCloseChangeBillDate).Location = new Point(148, 4);
    ((Control) this.buttonCloseChangeBillDate).Name = "buttonCloseChangeBillDate";
    ((Control) this.buttonCloseChangeBillDate).Size = new Size(16 /*0x10*/, 16 /*0x10*/);
    ((Control) this.buttonCloseChangeBillDate).TabIndex = 1;
    ((Control) this.buttonCloseChangeBillDate).Text = "X";
    ((UltraControlBase) this.buttonCloseChangeBillDate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCloseChangeBillDate).Click += new EventHandler(this.buttonCloseChangeBillDate_Click);
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mgaGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance14;
    ((Control) this.mgaGroupBox2).Controls.Add((Control) this.buttonSaveChangeBillDate);
    ((Control) this.mgaGroupBox2).Controls.Add((Control) this.dateNewBillDate);
    ((Control) this.mgaGroupBox2).Controls.Add((Control) this.label39);
    ((AppearanceBase) appearance15).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance15).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance15).ForeColor = Color.White;
    ((AppearanceBase) appearance15).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance15).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.mgaGroupBox2.HeaderAppearance = (AppearanceBase) appearance15;
    ((Control) this.mgaGroupBox2).Location = new Point(0, 0);
    ((Control) this.mgaGroupBox2).Name = "mgaGroupBox2";
    ((Control) this.mgaGroupBox2).Size = new Size(168, 88);
    ((Control) this.mgaGroupBox2).TabIndex = 0;
    ((Control) this.mgaGroupBox2).Text = "Select a New Bill Date";
    this.mgaGroupBox2.ViewStyle = (GroupBoxViewStyle) 2;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance16).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance16).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance16).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance16).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance16).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSaveChangeBillDate).Appearance = (AppearanceBase) appearance16;
    ((Control) this.buttonSaveChangeBillDate).Location = new Point(64 /*0x40*/, 56);
    ((Control) this.buttonSaveChangeBillDate).Name = "buttonSaveChangeBillDate";
    ((Control) this.buttonSaveChangeBillDate).Size = new Size(88, 24);
    ((Control) this.buttonSaveChangeBillDate).TabIndex = 2;
    ((Control) this.buttonSaveChangeBillDate).Text = "Save Bill Date";
    ((UltraControlBase) this.buttonSaveChangeBillDate).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSaveChangeBillDate).Click += new EventHandler(this.buttonSaveChangeBillDate_Click);
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateNewBillDate.Appearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance18).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance18).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance18).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance18).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance18).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance18).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance18).ForegroundAlpha = (Alpha) 2;
    this.dateNewBillDate.ButtonAppearance = (AppearanceBase) appearance18;
    this.dateNewBillDate.DateTime = DateTime.Now;
    ((Control) this.dateNewBillDate).Location = new Point(64 /*0x40*/, 32 /*0x20*/);
    this.dateNewBillDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateNewBillDate).Name = "dateNewBillDate";
    ((Control) this.dateNewBillDate).Size = new Size(88, 20);
    ((Control) this.dateNewBillDate).TabIndex = 1;
    ((UltraControlBase) this.dateNewBillDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateNewBillDate).UseOsThemes = (DefaultableBoolean) 2;
    this.dateNewBillDate.Value = (object) DateTime.Now;
    this.label39.AutoSize = true;
    this.label39.Location = new Point(8, 32 /*0x20*/);
    this.label39.Name = "label39";
    this.label39.Size = new Size(58, 13);
    this.label39.TabIndex = 0;
    this.label39.Text = "New Date:";
    this.linkChangeDueDate.AutoSize = true;
    this.linkChangeDueDate.Location = new Point(120, 120);
    this.linkChangeDueDate.Name = "linkChangeDueDate";
    this.linkChangeDueDate.Size = new Size(92, 13);
    this.linkChangeDueDate.TabIndex = 53;
    this.linkChangeDueDate.TabStop = true;
    this.linkChangeDueDate.Text = "Change Due Date";
    this.linkChangeDueDate.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkChangeDueDate_LinkClicked);
    this.linkChangeBillDate.AutoSize = true;
    this.linkChangeBillDate.Location = new Point(128 /*0x80*/, 72);
    this.linkChangeBillDate.Name = "linkChangeBillDate";
    this.linkChangeBillDate.Size = new Size(85, 13);
    this.linkChangeBillDate.TabIndex = 52;
    this.linkChangeBillDate.TabStop = true;
    this.linkChangeBillDate.Text = "Change Bill Date";
    this.linkChangeBillDate.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkChangeBillDate_LinkClicked);
    this.lblInvoiceDueDate.AutoSize = true;
    this.lblInvoiceDueDate.BackColor = Color.Transparent;
    this.lblInvoiceDueDate.Location = new Point(8, 120);
    this.lblInvoiceDueDate.Name = "lblInvoiceDueDate";
    this.lblInvoiceDueDate.Size = new Size(65, 13);
    this.lblInvoiceDueDate.TabIndex = 51;
    this.lblInvoiceDueDate.Text = "[Date Billed]";
    this.Label37.AutoSize = true;
    this.Label37.BackColor = Color.Transparent;
    this.Label37.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label37.Location = new Point(8, 104);
    this.Label37.Name = "Label37";
    this.Label37.Size = new Size(62, 13);
    this.Label37.TabIndex = 50;
    this.Label37.Text = "Date Due:";
    this.ElipsePanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.ElipsePanel3.BackColor = Color.Ivory;
    this.ElipsePanel3.Controls.Add((Control) this.Label33);
    this.ElipsePanel3.Controls.Add((Control) this.lblNetDueCalculation);
    this.ElipsePanel3.Controls.Add((Control) this.lblFeesCalculation);
    this.ElipsePanel3.Controls.Add((Control) this.Label35);
    this.ElipsePanel3.Controls.Add((Control) this.lblPremiumCalculation);
    this.ElipsePanel3.Controls.Add((Control) this.lblBrokerCommissionCalculation);
    this.ElipsePanel3.Controls.Add((Control) this.Label17);
    this.ElipsePanel3.Controls.Add((Control) this.Label24);
    this.ElipsePanel3.Controls.Add((Control) this.Label31);
    this.ElipsePanel3.Controls.Add((Control) this.Label29);
    this.ElipsePanel3.Controls.Add((Control) this.Label21);
    this.ElipsePanel3.Location = new Point(488, 8);
    this.ElipsePanel3.Name = "ElipsePanel3";
    this.ElipsePanel3.Size = new Size(336, 120);
    this.ElipsePanel3.TabIndex = 49;
    this.Label33.AutoSize = true;
    this.Label33.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label33.Location = new Point(8, 96 /*0x60*/);
    this.Label33.Name = "Label33";
    this.Label33.Size = new Size(54, 13);
    this.Label33.TabIndex = 10;
    this.Label33.Text = "Net Due:";
    this.lblNetDueCalculation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblNetDueCalculation.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblNetDueCalculation.Location = new Point(168, 96 /*0x60*/);
    this.lblNetDueCalculation.Name = "lblNetDueCalculation";
    this.lblNetDueCalculation.Size = new Size(160 /*0xA0*/, 16 /*0x10*/);
    this.lblNetDueCalculation.TabIndex = 9;
    this.lblNetDueCalculation.Text = "[Net Due Calculation]";
    this.lblNetDueCalculation.TextAlign = ContentAlignment.MiddleRight;
    this.lblFeesCalculation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblFeesCalculation.Location = new Point(224 /*0xE0*/, 72);
    this.lblFeesCalculation.Name = "lblFeesCalculation";
    this.lblFeesCalculation.Size = new Size(104, 16 /*0x10*/);
    this.lblFeesCalculation.TabIndex = 8;
    this.lblFeesCalculation.Text = "[Fees Calculation]";
    this.lblFeesCalculation.TextAlign = ContentAlignment.MiddleRight;
    this.Label35.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label35.AutoSize = true;
    this.Label35.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label35.Location = new Point(224 /*0xE0*/, 80 /*0x50*/);
    this.Label35.Name = "Label35";
    this.Label35.Size = new Size(105, 13);
    this.Label35.TabIndex = 7;
    this.Label35.Text = "______________";
    this.lblPremiumCalculation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblPremiumCalculation.Location = new Point(216, 8);
    this.lblPremiumCalculation.Name = "lblPremiumCalculation";
    this.lblPremiumCalculation.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.lblPremiumCalculation.TabIndex = 6;
    this.lblPremiumCalculation.Text = "[Premium Calculation]";
    this.lblPremiumCalculation.TextAlign = ContentAlignment.MiddleRight;
    this.lblBrokerCommissionCalculation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblBrokerCommissionCalculation.Location = new Point(216, 40);
    this.lblBrokerCommissionCalculation.Name = "lblBrokerCommissionCalculation";
    this.lblBrokerCommissionCalculation.Size = new Size(112 /*0x70*/, 16 /*0x10*/);
    this.lblBrokerCommissionCalculation.TabIndex = 5;
    this.lblBrokerCommissionCalculation.Text = "[Broker Commission Calculation]";
    this.lblBrokerCommissionCalculation.TextAlign = ContentAlignment.MiddleRight;
    this.Label17.AutoSize = true;
    this.Label17.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label17.Location = new Point(8, 8);
    this.Label17.Name = "Label17";
    this.Label17.Size = new Size(61, 13);
    this.Label17.TabIndex = 0;
    this.Label17.Text = "Premium:";
    this.Label24.AutoSize = true;
    this.Label24.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label24.Location = new Point(8, 40);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(119, 13);
    this.Label24.TabIndex = 2;
    this.Label24.Text = "Broker Commission:";
    this.Label31.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label31.AutoSize = true;
    this.Label31.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label31.Location = new Point(312, 56);
    this.Label31.Name = "Label31";
    this.Label31.Size = new Size(16 /*0x10*/, 13);
    this.Label31.TabIndex = 4;
    this.Label31.Text = "+";
    this.Label29.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label29.AutoSize = true;
    this.Label29.Font = new Font("Tahoma", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label29.Location = new Point(312, 24);
    this.Label29.Name = "Label29";
    this.Label29.Size = new Size(12, 14);
    this.Label29.TabIndex = 3;
    this.Label29.Text = "-";
    this.Label21.AutoSize = true;
    this.Label21.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label21.Location = new Point(8, 72);
    this.Label21.Name = "Label21";
    this.Label21.Size = new Size(36, 13);
    this.Label21.TabIndex = 1;
    this.Label21.Text = "Fees:";
    ((Control) this.gridInvoiceFeeLines).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.gridInvoiceFeeLines).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridInvoiceFeeLines).DataMember = "InvoiceFeeLines";
    ((UltraGridBase) this.gridInvoiceFeeLines).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance19).BackColor = Color.White;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Appearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance20).TextHAlignAsString = "Left";
    ultraGridColumn1.CellAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance21;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Fee";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 189;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Right";
    ultraGridColumn2.CellAppearance = (AppearanceBase) appearance22;
    ultraGridColumn2.Format = "c";
    ((AppearanceBase) appearance23).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance23;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 153;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((AppearanceBase) appearance24).BackColor = Color.LightSteelBlue;
    ultraGridBand1.Override.SummaryFooterAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).BackColor = Color.LightSteelBlue;
    ultraGridBand1.Override.SummaryFooterCaptionAppearance = (AppearanceBase) appearance25;
    ultraGridBand1.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance26).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance26).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance26).TextHAlignAsString = "Right";
    summarySettings1.Appearance = (AppearanceBase) appearance26;
    summarySettings1.DisplayFormat = "{0:c}";
    ultraGridBand1.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings1
    });
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance27).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance28).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance29).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance30).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance32).BackColor = Color.Transparent;
    ((AppearanceBase) appearance32).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance32;
    ((AppearanceBase) appearance33).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance33).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.gridInvoiceFeeLines).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((AppearanceBase) appearance35).BackColor = Color.White;
    ((AppearanceBase) appearance35).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance35;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance36).TextHAlignAsString = "Left";
    ultraGridColumn3.CellAppearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance37;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Fee";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 0;
    ultraGridColumn3.Width = 189;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance38;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance39).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance39;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 1;
    ultraGridColumn4.Width = 153;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((AppearanceBase) appearance40).BackColor = Color.LightSteelBlue;
    ultraGridBand2.Override.SummaryFooterAppearance = (AppearanceBase) appearance40;
    ((AppearanceBase) appearance41).BackColor = Color.LightSteelBlue;
    ultraGridBand2.Override.SummaryFooterCaptionAppearance = (AppearanceBase) appearance41;
    ultraGridBand2.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance42).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance42).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance42).TextHAlignAsString = "Right";
    summarySettings2.Appearance = (AppearanceBase) appearance42;
    summarySettings2.DisplayFormat = "{0:c}";
    ultraGridBand2.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings2
    });
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "lyt1";
    ((AppearanceBase) appearance43).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance43).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance43).ForeColor = Color.Black;
    ultraGridLayout1.Override.ActiveRowAppearance = (AppearanceBase) appearance43;
    ultraGridLayout1.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance44).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.CellAppearance = (AppearanceBase) appearance44;
    ultraGridLayout1.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance45).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout1.Override.HeaderAppearance = (AppearanceBase) appearance45;
    ultraGridLayout1.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance46).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout1.Override.RowAlternateAppearance = (AppearanceBase) appearance46;
    ((AppearanceBase) appearance47).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance47;
    ultraGridLayout1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance48).BackColor = Color.Transparent;
    ((AppearanceBase) appearance48).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance48;
    ((AppearanceBase) appearance49).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance49).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance49;
    ((AppearanceBase) appearance50).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance50;
    ultraGridLayout1.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridInvoiceFeeLines).Layouts.Add(ultraGridLayout1);
    ((Control) this.gridInvoiceFeeLines).Location = new Point(488, 160 /*0xA0*/);
    ((Control) this.gridInvoiceFeeLines).Name = "gridInvoiceFeeLines";
    ((Control) this.gridInvoiceFeeLines).Size = new Size(344, 133);
    ((Control) this.gridInvoiceFeeLines).TabIndex = 48 /*0x30*/;
    ((UltraControlBase) this.gridInvoiceFeeLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridInvoiceFeeLines).UseOsThemes = (DefaultableBoolean) 2;
    this.dsPolicyInformation1.DataSetName = "dsPolicyInformation";
    this.dsPolicyInformation1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.gridInvoicePremiumLines).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((Control) this.gridInvoicePremiumLines).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridInvoicePremiumLines).DataMember = "InvoicePremiumLines";
    ((UltraGridBase) this.gridInvoicePremiumLines).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance51).BackColor = Color.White;
    ((AppearanceBase) appearance51).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Appearance = (AppearanceBase) appearance51;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance52).TextHAlignAsString = "Left";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance52;
    ((AppearanceBase) appearance53).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance53;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Premium";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 0;
    ultraGridColumn5.Width = 136;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance54;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance55).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance55;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 1;
    ultraGridColumn6.Width = 110;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((AppearanceBase) appearance56).BackColor = Color.LightSteelBlue;
    ultraGridBand3.Override.SummaryFooterAppearance = (AppearanceBase) appearance56;
    ultraGridBand3.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance57).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance57).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance57).TextHAlignAsString = "Right";
    summarySettings3.Appearance = (AppearanceBase) appearance57;
    summarySettings3.DisplayFormat = "{0:c}";
    ultraGridBand3.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings3
    });
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance58).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance58).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance58).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance58;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance59).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance60).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance60;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance61).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance61;
    ((AppearanceBase) appearance62).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance63).BackColor = Color.Transparent;
    ((AppearanceBase) appearance63).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance63;
    ((AppearanceBase) appearance64).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance64).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance64;
    ((AppearanceBase) appearance65).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance65;
    ((UltraGridBase) this.gridInvoicePremiumLines).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((AppearanceBase) appearance66).BackColor = Color.White;
    ((AppearanceBase) appearance66).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout2.Appearance = (AppearanceBase) appearance66;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance67).TextHAlignAsString = "Left";
    ultraGridColumn7.CellAppearance = (AppearanceBase) appearance67;
    ((AppearanceBase) appearance68).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance68;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Premium";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 0;
    ultraGridColumn7.Width = 136;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance69).TextHAlignAsString = "Right";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance69;
    ultraGridColumn8.Format = "c";
    ((AppearanceBase) appearance70).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance70;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Amount";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 1;
    ultraGridColumn8.Width = 110;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((AppearanceBase) appearance71).BackColor = Color.LightSteelBlue;
    ultraGridBand4.Override.SummaryFooterAppearance = (AppearanceBase) appearance71;
    ultraGridBand4.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance72).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance72).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance72).TextHAlignAsString = "Right";
    summarySettings4.Appearance = (AppearanceBase) appearance72;
    summarySettings4.DisplayFormat = "{0:c}";
    ultraGridBand4.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings4
    });
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand4);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "lyt1";
    ((AppearanceBase) appearance73).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance73).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance73).ForeColor = Color.Black;
    ultraGridLayout2.Override.ActiveRowAppearance = (AppearanceBase) appearance73;
    ultraGridLayout2.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance74).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.CellAppearance = (AppearanceBase) appearance74;
    ultraGridLayout2.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance75).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout2.Override.HeaderAppearance = (AppearanceBase) appearance75;
    ultraGridLayout2.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance76).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout2.Override.RowAlternateAppearance = (AppearanceBase) appearance76;
    ((AppearanceBase) appearance77).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance77;
    ultraGridLayout2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance78).BackColor = Color.Transparent;
    ((AppearanceBase) appearance78).ForeColor = Color.Black;
    ultraGridLayout2.Override.SelectedRowAppearance = (AppearanceBase) appearance78;
    ((AppearanceBase) appearance79).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance79).BorderColor = Color.Silver;
    scrollBarLook4.ButtonAppearance = (AppearanceBase) appearance79;
    ((AppearanceBase) appearance80).BackColor = Color.White;
    scrollBarLook4.TrackAppearance = (AppearanceBase) appearance80;
    ultraGridLayout2.ScrollBarLook = scrollBarLook4;
    ((UltraGridBase) this.gridInvoicePremiumLines).Layouts.Add(ultraGridLayout2);
    ((Control) this.gridInvoicePremiumLines).Location = new Point(232, 160 /*0xA0*/);
    ((Control) this.gridInvoicePremiumLines).Name = "gridInvoicePremiumLines";
    ((Control) this.gridInvoicePremiumLines).Size = new Size(248, 128 /*0x80*/);
    ((Control) this.gridInvoicePremiumLines).TabIndex = 47;
    ((UltraControlBase) this.gridInvoicePremiumLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridInvoicePremiumLines).UseOsThemes = (DefaultableBoolean) 2;
    this.lblDueCompany.AutoSize = true;
    this.lblDueCompany.BackColor = Color.Transparent;
    this.lblDueCompany.Location = new Point(8, 168);
    this.lblDueCompany.Name = "lblDueCompany";
    this.lblDueCompany.Size = new Size(82, 13);
    this.lblDueCompany.TabIndex = 46;
    this.lblDueCompany.Text = "[Due Company]";
    this.Label34.AutoSize = true;
    this.Label34.BackColor = Color.Transparent;
    this.Label34.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label34.Location = new Point(8, 152);
    this.Label34.Name = "Label34";
    this.Label34.Size = new Size(88, 13);
    this.Label34.TabIndex = 45;
    this.Label34.Text = "Due Company:";
    this.lblInvoiceBrokerCommission.AutoSize = true;
    this.lblInvoiceBrokerCommission.BackColor = Color.Transparent;
    this.lblInvoiceBrokerCommission.Location = new Point(232, 80 /*0x50*/);
    this.lblInvoiceBrokerCommission.Name = "lblInvoiceBrokerCommission";
    this.lblInvoiceBrokerCommission.Size = new Size(118, 13);
    this.lblInvoiceBrokerCommission.TabIndex = 44;
    this.lblInvoiceBrokerCommission.Text = "[Broker Commission %]";
    this.Label32.AutoSize = true;
    this.Label32.BackColor = Color.Transparent;
    this.Label32.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label32.Location = new Point(232, 64 /*0x40*/);
    this.Label32.Name = "Label32";
    this.Label32.Size = new Size(132, 13);
    this.Label32.TabIndex = 43;
    this.Label32.Text = "Broker Commission %";
    this.lblInvoiceGrossCommission.AutoSize = true;
    this.lblInvoiceGrossCommission.BackColor = Color.Transparent;
    this.lblInvoiceGrossCommission.Location = new Point(232, 24);
    this.lblInvoiceGrossCommission.Name = "lblInvoiceGrossCommission";
    this.lblInvoiceGrossCommission.Size = new Size(114, 13);
    this.lblInvoiceGrossCommission.TabIndex = 42;
    this.lblInvoiceGrossCommission.Text = "[Gross Commission %]";
    this.Label30.AutoSize = true;
    this.Label30.BackColor = Color.Transparent;
    this.Label30.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label30.Location = new Point(232, 8);
    this.Label30.Name = "Label30";
    this.Label30.Size = new Size(126, 13);
    this.Label30.TabIndex = 41;
    this.Label30.Text = "Gross Commission %";
    this.Label28.AutoSize = true;
    this.Label28.BackColor = Color.Transparent;
    this.Label28.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label28.Location = new Point(488, 144 /*0x90*/);
    this.Label28.Name = "Label28";
    this.Label28.Size = new Size(59, 13);
    this.Label28.TabIndex = 40;
    this.Label28.Text = "Fee Lines";
    this.lblEndorsementNumber.AutoSize = true;
    this.lblEndorsementNumber.BackColor = Color.Transparent;
    this.lblEndorsementNumber.Location = new Point(8, 24);
    this.lblEndorsementNumber.Name = "lblEndorsementNumber";
    this.lblEndorsementNumber.Size = new Size(118, 13);
    this.lblEndorsementNumber.TabIndex = 36;
    this.lblEndorsementNumber.Text = "[Endorsement Number]";
    this.Label26.AutoSize = true;
    this.Label26.BackColor = Color.Transparent;
    this.Label26.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label26.Location = new Point(8, 8);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(97, 13);
    this.Label26.TabIndex = 35;
    this.Label26.Text = "Endorsement #:";
    this.lblInvoiceDateBilled.AutoSize = true;
    this.lblInvoiceDateBilled.BackColor = Color.Transparent;
    this.lblInvoiceDateBilled.Location = new Point(8, 72);
    this.lblInvoiceDateBilled.Name = "lblInvoiceDateBilled";
    this.lblInvoiceDateBilled.Size = new Size(65, 13);
    this.lblInvoiceDateBilled.TabIndex = 34;
    this.lblInvoiceDateBilled.Text = "[Date Billed]";
    this.Label14.AutoSize = true;
    this.Label14.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label14.Location = new Point(96 /*0x60*/, 216);
    this.Label14.Name = "Label14";
    this.Label14.Size = new Size(12, 13);
    this.Label14.TabIndex = 33;
    this.Label14.Text = "-";
    this.lblInvoiceExpirationDate.AutoSize = true;
    this.lblInvoiceExpirationDate.BackColor = Color.Transparent;
    this.lblInvoiceExpirationDate.Location = new Point(112 /*0x70*/, 216);
    this.lblInvoiceExpirationDate.Name = "lblInvoiceExpirationDate";
    this.lblInvoiceExpirationDate.Size = new Size(89, 13);
    this.lblInvoiceExpirationDate.TabIndex = 32 /*0x20*/;
    this.lblInvoiceExpirationDate.Text = "[Expiration Date]";
    this.Label18.AutoSize = true;
    this.Label18.BackColor = Color.Transparent;
    this.Label18.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label18.Location = new Point(112 /*0x70*/, 200);
    this.Label18.Name = "Label18";
    this.Label18.Size = new Size(97, 13);
    this.Label18.TabIndex = 31 /*0x1F*/;
    this.Label18.Text = "Expiration Date:";
    this.lblInvoiceEffectiveDate.AutoSize = true;
    this.lblInvoiceEffectiveDate.BackColor = Color.Transparent;
    this.lblInvoiceEffectiveDate.Location = new Point(8, 216);
    this.lblInvoiceEffectiveDate.Name = "lblInvoiceEffectiveDate";
    this.lblInvoiceEffectiveDate.Size = new Size(84, 13);
    this.lblInvoiceEffectiveDate.TabIndex = 30;
    this.lblInvoiceEffectiveDate.Text = "[Effective Date]";
    this.Label20.AutoSize = true;
    this.Label20.BackColor = Color.Transparent;
    this.Label20.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label20.Location = new Point(8, 200);
    this.Label20.Name = "Label20";
    this.Label20.Size = new Size(89, 13);
    this.Label20.TabIndex = 29;
    this.Label20.Text = "Effective Date:";
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label9.Location = new Point(8, 56);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(70, 13);
    this.Label9.TabIndex = 0;
    this.Label9.Text = "Date Billed:";
    this.Label27.AutoSize = true;
    this.Label27.BackColor = Color.Transparent;
    this.Label27.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label27.Location = new Point(232, 144 /*0x90*/);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(90, 13);
    this.Label27.TabIndex = 39;
    this.Label27.Text = "Premium Lines";
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.transactionCommentsViewer1);
    ((Control) this.UltraTabPageControl4).Controls.Add((Control) this.gridInvoiceActivity);
    ((Control) this.UltraTabPageControl4).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl4).Name = "UltraTabPageControl4";
    ((Control) this.UltraTabPageControl4).Size = new Size(836, 299);
    this.transactionCommentsViewer1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.transactionCommentsViewer1.BackColor = Color.White;
    this.transactionCommentsViewer1.Font = new Font("Tahoma", 8f);
    this.transactionCommentsViewer1.ForeColor = Color.Black;
    this.transactionCommentsViewer1.Location = new Point(553, 90);
    this.transactionCommentsViewer1.Name = "transactionCommentsViewer1";
    this.transactionCommentsViewer1.Size = new Size(280, 210);
    this.transactionCommentsViewer1.TabIndex = 21;
    this.transactionCommentsViewer1.Visible = false;
    ((Control) this.gridInvoiceActivity).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.gridInvoiceActivity, "InvoiceActivityContext");
    ((Control) this.gridInvoiceActivity).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridInvoiceActivity).DataMember = "InvoiceActivity";
    ((UltraGridBase) this.gridInvoiceActivity).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance81).BackColor = Color.White;
    ((AppearanceBase) appearance81).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Appearance = (AppearanceBase) appearance81;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance82).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance82;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Transaction #";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 0;
    ultraGridColumn9.Width = 82;
    ((AppearanceBase) appearance83).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance83;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 1;
    ultraGridColumn10.Width = 101;
    ((AppearanceBase) appearance84).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance84;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Post Date";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 2;
    ultraGridColumn11.Width = 78;
    ((AppearanceBase) appearance85).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance85;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 3;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 72;
    ((AppearanceBase) appearance86).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance86;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 4;
    ultraGridColumn13.Width = 85;
    ((AppearanceBase) appearance87).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance87;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 5;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 47;
    ((AppearanceBase) appearance88).TextHAlignAsString = "Right";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance88;
    ultraGridColumn15.Format = "c";
    ((AppearanceBase) appearance89).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance89;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 6;
    ultraGridColumn15.Width = 69;
    ((AppearanceBase) appearance90).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance90;
    ultraGridColumn16.Format = "c";
    ((AppearanceBase) appearance91).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance91;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 7;
    ultraGridColumn16.Width = 69;
    ((AppearanceBase) appearance92).TextHAlignAsString = "Right";
    ultraGridColumn17.CellAppearance = (AppearanceBase) appearance92;
    ultraGridColumn17.Format = "c";
    ((AppearanceBase) appearance93).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn17.Header).Appearance = (AppearanceBase) appearance93;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 8;
    ultraGridColumn17.Width = 77;
    ((AppearanceBase) appearance94).TextHAlignAsString = "Right";
    ultraGridColumn18.CellAppearance = (AppearanceBase) appearance94;
    ultraGridColumn18.Format = "c";
    ((AppearanceBase) appearance95).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn18.Header).Appearance = (AppearanceBase) appearance95;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 9;
    ultraGridColumn18.Width = 87;
    ((AppearanceBase) appearance96).TextHAlignAsString = "Right";
    ultraGridColumn19.CellAppearance = (AppearanceBase) appearance96;
    ultraGridColumn19.Format = "c";
    ((AppearanceBase) appearance97).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn19.Header).Appearance = (AppearanceBase) appearance97;
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 10;
    ultraGridColumn19.Width = 89;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 11;
    ultraGridColumn20.Width = 88;
    ultraGridBand5.Columns.AddRange(new object[12]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ultraGridBand5.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand5.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand5.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand5.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand5.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand5.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand5.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand5.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand5.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand5.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand5.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance98).BackColor = Color.LightSteelBlue;
    ultraGridBand5.Override.SummaryFooterAppearance = (AppearanceBase) appearance98;
    ultraGridBand5.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance99).BackColor = Color.LightSteelBlue;
    ultraGridBand5.Override.SummaryValueAppearance = (AppearanceBase) appearance99;
    ((AppearanceBase) appearance100).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance100).TextHAlignAsString = "Right";
    summarySettings5.Appearance = (AppearanceBase) appearance100;
    summarySettings5.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance101).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance101).TextHAlignAsString = "Right";
    summarySettings6.Appearance = (AppearanceBase) appearance101;
    summarySettings6.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance102).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance102).TextHAlignAsString = "Right";
    summarySettings7.Appearance = (AppearanceBase) appearance102;
    summarySettings7.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance103).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance103).TextHAlignAsString = "Right";
    summarySettings8.Appearance = (AppearanceBase) appearance103;
    summarySettings8.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance104).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance104).TextHAlignAsString = "Right";
    summarySettings9.Appearance = (AppearanceBase) appearance104;
    summarySettings9.DisplayFormat = "{0:c}";
    ultraGridBand5.Summaries.AddRange(new SummarySettings[5]
    {
      summarySettings5,
      summarySettings6,
      summarySettings7,
      summarySettings8,
      summarySettings9
    });
    ultraGridBand5.SummaryFooterCaption = "";
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance105).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance105).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance105).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance105;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance106).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance106;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance107).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance107;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance108).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance108;
    ((AppearanceBase) appearance109).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance109;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance110).BackColor = Color.Transparent;
    ((AppearanceBase) appearance110).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance110;
    ((AppearanceBase) appearance111).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance111).BorderColor = Color.Silver;
    scrollBarLook5.ButtonAppearance = (AppearanceBase) appearance111;
    ((AppearanceBase) appearance112).BackColor = Color.White;
    scrollBarLook5.TrackAppearance = (AppearanceBase) appearance112;
    ((UltraGridBase) this.gridInvoiceActivity).DisplayLayout.ScrollBarLook = scrollBarLook5;
    ((Control) this.gridInvoiceActivity).Location = new Point(3, 5);
    ((Control) this.gridInvoiceActivity).Name = "gridInvoiceActivity";
    ((Control) this.gridInvoiceActivity).Size = new Size(827, 293);
    ((Control) this.gridInvoiceActivity).TabIndex = 20;
    ((UltraControlBase) this.gridInvoiceActivity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridInvoiceActivity).UseOsThemes = (DefaultableBoolean) 2;
    this.gridInvoiceActivity.InitializeRow += new InitializeRowEventHandler(this.gridInvoiceActivity_InitializeRow);
    this.gridInvoiceActivity.AfterRowActivate += new EventHandler(this.gridInvoiceActivity_AfterRowActivate);
    ((Control) this.ultraTabPageControl8).Controls.Add((Control) this.gridInvoiceListing);
    ((Control) this.ultraTabPageControl8).Location = new Point(1, 20);
    ((Control) this.ultraTabPageControl8).Name = "ultraTabPageControl8";
    ((Control) this.ultraTabPageControl8).Size = new Size(836, 173);
    ((Control) this.gridInvoiceListing).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.gridInvoiceListing, "InvoiceListingContext");
    ((Control) this.gridInvoiceListing).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridInvoiceListing).DataMember = "PolicyInvoices";
    ((UltraGridBase) this.gridInvoiceListing).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance113).BackColor = Color.White;
    ((AppearanceBase) appearance113).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Appearance = (AppearanceBase) appearance113;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 0;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 73;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance114).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn22.Header).Appearance = (AppearanceBase) appearance114;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 1;
    ultraGridColumn22.Width = 77;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 3;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 66;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance115).TextHAlignAsString = "Right";
    ultraGridColumn24.CellAppearance = (AppearanceBase) appearance115;
    ultraGridColumn24.Format = "c";
    ((AppearanceBase) appearance116).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn24.Header).Appearance = (AppearanceBase) appearance116;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Gross Billed";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 6;
    ultraGridColumn24.Width = 118;
    ultraGridColumn25.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance117).TextHAlignAsString = "Right";
    ultraGridColumn25.CellAppearance = (AppearanceBase) appearance117;
    ultraGridColumn25.Format = "c";
    ((AppearanceBase) appearance118).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn25.Header).Appearance = (AppearanceBase) appearance118;
    ((HeaderBase) ultraGridColumn25.Header).Caption = "Net. Commission";
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 7;
    ultraGridColumn25.Width = 118;
    ultraGridColumn26.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance119).TextHAlignAsString = "Right";
    ultraGridColumn26.CellAppearance = (AppearanceBase) appearance119;
    ultraGridColumn26.Format = "c";
    ((AppearanceBase) appearance120).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn26.Header).Appearance = (AppearanceBase) appearance120;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 4;
    ultraGridColumn26.Width = 107;
    ultraGridColumn27.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance121).TextHAlignAsString = "Right";
    ultraGridColumn27.CellAppearance = (AppearanceBase) appearance121;
    ultraGridColumn27.Format = "c";
    ((AppearanceBase) appearance122).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn27.Header).Appearance = (AppearanceBase) appearance122;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 5;
    ultraGridColumn27.Width = 104;
    ultraGridColumn28.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance123).TextHAlignAsString = "Right";
    ultraGridColumn28.CellAppearance = (AppearanceBase) appearance123;
    ultraGridColumn28.Format = "c";
    ((AppearanceBase) appearance124).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn28.Header).Appearance = (AppearanceBase) appearance124;
    ((HeaderBase) ultraGridColumn28.Header).Caption = "AP Balance";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 8;
    ultraGridColumn28.Width = 105;
    ultraGridColumn29.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance125).TextHAlignAsString = "Right";
    ultraGridColumn29.CellAppearance = (AppearanceBase) appearance125;
    ultraGridColumn29.Format = "c";
    ((AppearanceBase) appearance126).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn29.Header).Appearance = (AppearanceBase) appearance126;
    ((HeaderBase) ultraGridColumn29.Header).Caption = "AR Balance";
    ((HeaderBase) ultraGridColumn29.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn29.Header).VisiblePosition = 9;
    ultraGridColumn29.Width = 106;
    ultraGridColumn30.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance127).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn30.Header).Appearance = (AppearanceBase) appearance127;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Due Date";
    ((HeaderBase) ultraGridColumn30.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn30.Header).VisiblePosition = 2;
    ultraGridColumn30.Width = 93;
    ultraGridColumn31.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn31.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn31.Header).VisiblePosition = 10;
    ultraGridColumn31.Hidden = true;
    ultraGridColumn31.Width = 92;
    ultraGridBand6.Columns.AddRange(new object[11]
    {
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28,
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31
    });
    ((AppearanceBase) appearance128).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance128).TextHAlignAsString = "Right";
    summarySettings10.Appearance = (AppearanceBase) appearance128;
    summarySettings10.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance129).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance129).TextHAlignAsString = "Right";
    summarySettings11.Appearance = (AppearanceBase) appearance129;
    summarySettings11.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance130).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance130).TextHAlignAsString = "Right";
    summarySettings12.Appearance = (AppearanceBase) appearance130;
    summarySettings12.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance131).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance131).TextHAlignAsString = "Right";
    summarySettings13.Appearance = (AppearanceBase) appearance131;
    summarySettings13.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance132).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance132).TextHAlignAsString = "Right";
    summarySettings14.Appearance = (AppearanceBase) appearance132;
    summarySettings14.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance133).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance133).TextHAlignAsString = "Right";
    summarySettings15.Appearance = (AppearanceBase) appearance133;
    summarySettings15.DisplayFormat = "{0:c}";
    ultraGridBand6.Summaries.AddRange(new SummarySettings[6]
    {
      summarySettings10,
      summarySettings11,
      summarySettings12,
      summarySettings13,
      summarySettings14,
      summarySettings15
    });
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance134).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance134).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance134).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance134;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance135).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance135;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance136).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance136).TextHAlignAsString = "Right";
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance136;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance137).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance137;
    ((AppearanceBase) appearance138).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance138;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance139).BackColor = Color.Transparent;
    ((AppearanceBase) appearance139).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance139;
    ((AppearanceBase) appearance140).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.SummaryFooterAppearance = (AppearanceBase) appearance140;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance141).BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.Override.SummaryValueAppearance = (AppearanceBase) appearance141;
    ((AppearanceBase) appearance142).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance142).BorderColor = Color.Silver;
    scrollBarLook6.ButtonAppearance = (AppearanceBase) appearance142;
    ((AppearanceBase) appearance143).BackColor = Color.White;
    scrollBarLook6.TrackAppearance = (AppearanceBase) appearance143;
    ((UltraGridBase) this.gridInvoiceListing).DisplayLayout.ScrollBarLook = scrollBarLook6;
    ((AppearanceBase) appearance144).BackColor = Color.White;
    ((AppearanceBase) appearance144).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout3.Appearance = (AppearanceBase) appearance144;
    ultraGridLayout3.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn32.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn32.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn32.Header).VisiblePosition = 0;
    ultraGridColumn32.Hidden = true;
    ultraGridColumn32.Width = 73;
    ultraGridColumn33.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance145).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn33.Header).Appearance = (AppearanceBase) appearance145;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn33.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn33.Header).VisiblePosition = 1;
    ultraGridColumn33.Width = 77;
    ultraGridColumn34.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn34.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn34.Header).VisiblePosition = 3;
    ultraGridColumn34.Hidden = true;
    ultraGridColumn34.Width = 66;
    ultraGridColumn35.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance146).TextHAlignAsString = "Right";
    ultraGridColumn35.CellAppearance = (AppearanceBase) appearance146;
    ultraGridColumn35.Format = "c";
    ((AppearanceBase) appearance147).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn35.Header).Appearance = (AppearanceBase) appearance147;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "Gross Billed";
    ((HeaderBase) ultraGridColumn35.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn35.Header).VisiblePosition = 6;
    ultraGridColumn35.Width = 118;
    ultraGridColumn36.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance148).TextHAlignAsString = "Right";
    ultraGridColumn36.CellAppearance = (AppearanceBase) appearance148;
    ultraGridColumn36.Format = "c";
    ((AppearanceBase) appearance149).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn36.Header).Appearance = (AppearanceBase) appearance149;
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Net. Commission";
    ((HeaderBase) ultraGridColumn36.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn36.Header).VisiblePosition = 7;
    ultraGridColumn36.Width = 118;
    ultraGridColumn37.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance150).TextHAlignAsString = "Right";
    ultraGridColumn37.CellAppearance = (AppearanceBase) appearance150;
    ultraGridColumn37.Format = "c";
    ((AppearanceBase) appearance151).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn37.Header).Appearance = (AppearanceBase) appearance151;
    ((HeaderBase) ultraGridColumn37.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn37.Header).VisiblePosition = 4;
    ultraGridColumn37.Width = 107;
    ultraGridColumn38.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance152).TextHAlignAsString = "Right";
    ultraGridColumn38.CellAppearance = (AppearanceBase) appearance152;
    ultraGridColumn38.Format = "c";
    ((AppearanceBase) appearance153).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn38.Header).Appearance = (AppearanceBase) appearance153;
    ((HeaderBase) ultraGridColumn38.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn38.Header).VisiblePosition = 5;
    ultraGridColumn38.Width = 104;
    ultraGridColumn39.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance154).TextHAlignAsString = "Right";
    ultraGridColumn39.CellAppearance = (AppearanceBase) appearance154;
    ultraGridColumn39.Format = "c";
    ((AppearanceBase) appearance155).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn39.Header).Appearance = (AppearanceBase) appearance155;
    ((HeaderBase) ultraGridColumn39.Header).Caption = "AP Balance";
    ((HeaderBase) ultraGridColumn39.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn39.Header).VisiblePosition = 8;
    ultraGridColumn39.Width = 105;
    ultraGridColumn40.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance156).TextHAlignAsString = "Right";
    ultraGridColumn40.CellAppearance = (AppearanceBase) appearance156;
    ultraGridColumn40.Format = "c";
    ((AppearanceBase) appearance157).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn40.Header).Appearance = (AppearanceBase) appearance157;
    ((HeaderBase) ultraGridColumn40.Header).Caption = "AR Balance";
    ((HeaderBase) ultraGridColumn40.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn40.Header).VisiblePosition = 9;
    ultraGridColumn40.Width = 106;
    ultraGridColumn41.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance158).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn41.Header).Appearance = (AppearanceBase) appearance158;
    ((HeaderBase) ultraGridColumn41.Header).Caption = "Due Date";
    ((HeaderBase) ultraGridColumn41.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn41.Header).VisiblePosition = 2;
    ultraGridColumn41.Width = 93;
    ultraGridColumn42.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn42.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn42.Header).VisiblePosition = 10;
    ultraGridColumn42.Hidden = true;
    ultraGridColumn42.Width = 92;
    ultraGridBand7.Columns.AddRange(new object[11]
    {
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37,
      (object) ultraGridColumn38,
      (object) ultraGridColumn39,
      (object) ultraGridColumn40,
      (object) ultraGridColumn41,
      (object) ultraGridColumn42
    });
    ((AppearanceBase) appearance159).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance159).TextHAlignAsString = "Right";
    summarySettings16.Appearance = (AppearanceBase) appearance159;
    summarySettings16.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance160).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance160).TextHAlignAsString = "Right";
    summarySettings17.Appearance = (AppearanceBase) appearance160;
    summarySettings17.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance161).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance161).TextHAlignAsString = "Right";
    summarySettings18.Appearance = (AppearanceBase) appearance161;
    summarySettings18.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance162).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance162).TextHAlignAsString = "Right";
    summarySettings19.Appearance = (AppearanceBase) appearance162;
    summarySettings19.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance163).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance163).TextHAlignAsString = "Right";
    summarySettings20.Appearance = (AppearanceBase) appearance163;
    summarySettings20.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance164).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance164).TextHAlignAsString = "Right";
    summarySettings21.Appearance = (AppearanceBase) appearance164;
    summarySettings21.DisplayFormat = "{0:c}";
    ultraGridBand7.Summaries.AddRange(new SummarySettings[6]
    {
      summarySettings16,
      summarySettings17,
      summarySettings18,
      summarySettings19,
      summarySettings20,
      summarySettings21
    });
    ultraGridLayout3.BandsSerializer.Add((object) ultraGridBand7);
    ultraGridLayout3.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout3).Key = "lyt1";
    ((AppearanceBase) appearance165).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance165).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance165).ForeColor = Color.Black;
    ultraGridLayout3.Override.ActiveRowAppearance = (AppearanceBase) appearance165;
    ultraGridLayout3.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout3.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout3.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout3.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance166).BorderColor = Color.LightGray;
    ultraGridLayout3.Override.CellAppearance = (AppearanceBase) appearance166;
    ultraGridLayout3.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance167).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance167).TextHAlignAsString = "Right";
    ultraGridLayout3.Override.HeaderAppearance = (AppearanceBase) appearance167;
    ultraGridLayout3.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout3.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance168).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout3.Override.RowAlternateAppearance = (AppearanceBase) appearance168;
    ((AppearanceBase) appearance169).BorderColor = Color.LightGray;
    ultraGridLayout3.Override.RowAppearance = (AppearanceBase) appearance169;
    ultraGridLayout3.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance170).BackColor = Color.Transparent;
    ((AppearanceBase) appearance170).ForeColor = Color.Black;
    ultraGridLayout3.Override.SelectedRowAppearance = (AppearanceBase) appearance170;
    ((AppearanceBase) appearance171).BackColor = Color.LightSteelBlue;
    ultraGridLayout3.Override.SummaryFooterAppearance = (AppearanceBase) appearance171;
    ultraGridLayout3.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance172).BackColor = Color.LightSteelBlue;
    ultraGridLayout3.Override.SummaryValueAppearance = (AppearanceBase) appearance172;
    ((AppearanceBase) appearance173).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance173).BorderColor = Color.Silver;
    scrollBarLook7.ButtonAppearance = (AppearanceBase) appearance173;
    ((AppearanceBase) appearance174).BackColor = Color.White;
    scrollBarLook7.TrackAppearance = (AppearanceBase) appearance174;
    ultraGridLayout3.ScrollBarLook = scrollBarLook7;
    ((UltraGridBase) this.gridInvoiceListing).Layouts.Add(ultraGridLayout3);
    ((Control) this.gridInvoiceListing).Location = new Point(3, 5);
    ((Control) this.gridInvoiceListing).Name = "gridInvoiceListing";
    ((Control) this.gridInvoiceListing).Size = new Size(830, 163);
    ((Control) this.gridInvoiceListing).TabIndex = 20;
    ((UltraControlBase) this.gridInvoiceListing).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridInvoiceListing).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridInvoiceListing).Click += new EventHandler(this.gridInvoiceListing_Click);
    ((Control) this.ultraTabPageControl9).Controls.Add((Control) this.gridPolicyActivity);
    ((Control) this.ultraTabPageControl9).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl9).Name = "ultraTabPageControl9";
    ((Control) this.ultraTabPageControl9).Size = new Size(836, 173);
    ((Control) this.gridPolicyActivity).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.gridPolicyActivity, "InvoiceActivityContext");
    ((Control) this.gridPolicyActivity).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridPolicyActivity).DataMember = "PolicyActivity";
    ((UltraGridBase) this.gridPolicyActivity).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance175).BackColor = Color.White;
    ((AppearanceBase) appearance175).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Appearance = (AppearanceBase) appearance175;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn43.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance176).TextHAlignAsString = "Left";
    ultraGridColumn43.CellAppearance = (AppearanceBase) appearance176;
    ((AppearanceBase) appearance177).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn43.Header).Appearance = (AppearanceBase) appearance177;
    ((HeaderBase) ultraGridColumn43.Header).Caption = "Transaction #";
    ((HeaderBase) ultraGridColumn43.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn43.Header).VisiblePosition = 0;
    ultraGridColumn43.Width = 78;
    ultraGridColumn44.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance178).TextHAlignAsString = "Left";
    ultraGridColumn44.CellAppearance = (AppearanceBase) appearance178;
    ((AppearanceBase) appearance179).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn44.Header).Appearance = (AppearanceBase) appearance179;
    ((HeaderBase) ultraGridColumn44.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn44.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn44.Header).VisiblePosition = 1;
    ultraGridColumn44.Width = 87;
    ultraGridColumn45.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance180).TextHAlignAsString = "Left";
    ultraGridColumn45.CellAppearance = (AppearanceBase) appearance180;
    ((AppearanceBase) appearance181).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn45.Header).Appearance = (AppearanceBase) appearance181;
    ((HeaderBase) ultraGridColumn45.Header).Caption = "Post Date";
    ((HeaderBase) ultraGridColumn45.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn45.Header).VisiblePosition = 2;
    ultraGridColumn45.Width = 72;
    ultraGridColumn46.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance182).TextHAlignAsString = "Left";
    ultraGridColumn46.CellAppearance = (AppearanceBase) appearance182;
    ((AppearanceBase) appearance183).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn46.Header).Appearance = (AppearanceBase) appearance183;
    ((HeaderBase) ultraGridColumn46.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn46.Header).VisiblePosition = 3;
    ultraGridColumn46.Hidden = true;
    ultraGridColumn46.Width = 63 /*0x3F*/;
    ultraGridColumn47.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance184).TextHAlignAsString = "Left";
    ultraGridColumn47.CellAppearance = (AppearanceBase) appearance184;
    ((AppearanceBase) appearance185).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn47.Header).Appearance = (AppearanceBase) appearance185;
    ((HeaderBase) ultraGridColumn47.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn47.Header).VisiblePosition = 4;
    ultraGridColumn47.Width = 78;
    ultraGridColumn48.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance186).TextHAlignAsString = "Left";
    ultraGridColumn48.CellAppearance = (AppearanceBase) appearance186;
    ((AppearanceBase) appearance187).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn48.Header).Appearance = (AppearanceBase) appearance187;
    ((HeaderBase) ultraGridColumn48.Header).Caption = "Voided";
    ((HeaderBase) ultraGridColumn48.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn48.Header).VisiblePosition = 5;
    ultraGridColumn48.Hidden = true;
    ultraGridColumn48.Width = 45;
    ultraGridColumn49.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance188).TextHAlignAsString = "Right";
    ultraGridColumn49.CellAppearance = (AppearanceBase) appearance188;
    ultraGridColumn49.Format = "c";
    ((AppearanceBase) appearance189).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn49.Header).Appearance = (AppearanceBase) appearance189;
    ((HeaderBase) ultraGridColumn49.Header).Caption = "AR";
    ((HeaderBase) ultraGridColumn49.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn49.Header).VisiblePosition = 6;
    ultraGridColumn49.Width = 63 /*0x3F*/;
    ultraGridColumn50.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance190).TextHAlignAsString = "Right";
    ultraGridColumn50.CellAppearance = (AppearanceBase) appearance190;
    ultraGridColumn50.Format = "c";
    ((AppearanceBase) appearance191).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn50.Header).Appearance = (AppearanceBase) appearance191;
    ((HeaderBase) ultraGridColumn50.Header).Caption = "AP";
    ((HeaderBase) ultraGridColumn50.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn50.Header).VisiblePosition = 7;
    ultraGridColumn50.Width = 63 /*0x3F*/;
    ultraGridColumn51.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance192).TextHAlignAsString = "Right";
    ultraGridColumn51.CellAppearance = (AppearanceBase) appearance192;
    ultraGridColumn51.Format = "c";
    ((AppearanceBase) appearance193).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn51.Header).Appearance = (AppearanceBase) appearance193;
    ((HeaderBase) ultraGridColumn51.Header).Caption = "Exchange";
    ((HeaderBase) ultraGridColumn51.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn51.Header).VisiblePosition = 8;
    ultraGridColumn51.Width = 71;
    ultraGridColumn52.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance194).TextHAlignAsString = "Right";
    ultraGridColumn52.CellAppearance = (AppearanceBase) appearance194;
    ultraGridColumn52.Format = "c";
    ((AppearanceBase) appearance195).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn52.Header).Appearance = (AppearanceBase) appearance195;
    ((HeaderBase) ultraGridColumn52.Header).Caption = "Un-Accounted";
    ((HeaderBase) ultraGridColumn52.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn52.Header).VisiblePosition = 9;
    ultraGridColumn52.Width = 79;
    ultraGridColumn53.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance196).TextHAlignAsString = "Right";
    ultraGridColumn53.CellAppearance = (AppearanceBase) appearance196;
    ultraGridColumn53.Format = "c";
    ((AppearanceBase) appearance197).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn53.Header).Appearance = (AppearanceBase) appearance197;
    ((HeaderBase) ultraGridColumn53.Header).Caption = "Income";
    ((HeaderBase) ultraGridColumn53.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn53.Header).VisiblePosition = 10;
    ultraGridColumn53.Width = 81;
    ultraGridColumn54.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn54.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn54.Header).VisiblePosition = 11;
    ultraGridColumn54.Width = 80 /*0x50*/;
    ultraGridColumn55.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn55.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn55.Header).VisiblePosition = 12;
    ultraGridColumn55.Width = 78;
    ultraGridBand8.Columns.AddRange(new object[13]
    {
      (object) ultraGridColumn43,
      (object) ultraGridColumn44,
      (object) ultraGridColumn45,
      (object) ultraGridColumn46,
      (object) ultraGridColumn47,
      (object) ultraGridColumn48,
      (object) ultraGridColumn49,
      (object) ultraGridColumn50,
      (object) ultraGridColumn51,
      (object) ultraGridColumn52,
      (object) ultraGridColumn53,
      (object) ultraGridColumn54,
      (object) ultraGridColumn55
    });
    ((AppearanceBase) appearance198).BackColor = Color.LightSteelBlue;
    ultraGridBand8.Override.SummaryFooterAppearance = (AppearanceBase) appearance198;
    ultraGridBand8.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance199).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance199).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance199).TextHAlignAsString = "Right";
    summarySettings22.Appearance = (AppearanceBase) appearance199;
    summarySettings22.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance200).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance200).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance200).TextHAlignAsString = "Right";
    summarySettings23.Appearance = (AppearanceBase) appearance200;
    summarySettings23.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance201).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance201).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance201).TextHAlignAsString = "Right";
    summarySettings24.Appearance = (AppearanceBase) appearance201;
    summarySettings24.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance202).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance202).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance202).TextHAlignAsString = "Right";
    summarySettings25.Appearance = (AppearanceBase) appearance202;
    summarySettings25.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance203).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance203).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance203).TextHAlignAsString = "Right";
    summarySettings26.Appearance = (AppearanceBase) appearance203;
    summarySettings26.DisplayFormat = "{0:c}";
    ultraGridBand8.Summaries.AddRange(new SummarySettings[5]
    {
      summarySettings22,
      summarySettings23,
      summarySettings24,
      summarySettings25,
      summarySettings26
    });
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance204).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance204).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance204).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance204;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance205).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance205;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance206).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance206;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance207).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance207;
    ((AppearanceBase) appearance208).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance208;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance209).BackColor = Color.Transparent;
    ((AppearanceBase) appearance209).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance209;
    ((AppearanceBase) appearance210).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance210).BorderColor = Color.Silver;
    scrollBarLook8.ButtonAppearance = (AppearanceBase) appearance210;
    ((AppearanceBase) appearance211).BackColor = Color.White;
    scrollBarLook8.TrackAppearance = (AppearanceBase) appearance211;
    ((UltraGridBase) this.gridPolicyActivity).DisplayLayout.ScrollBarLook = scrollBarLook8;
    ((AppearanceBase) appearance212).BackColor = Color.White;
    ((AppearanceBase) appearance212).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout4.Appearance = (AppearanceBase) appearance212;
    ultraGridLayout4.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn56.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance213).TextHAlignAsString = "Left";
    ultraGridColumn56.CellAppearance = (AppearanceBase) appearance213;
    ((AppearanceBase) appearance214).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn56.Header).Appearance = (AppearanceBase) appearance214;
    ((HeaderBase) ultraGridColumn56.Header).Caption = "Transaction #";
    ((HeaderBase) ultraGridColumn56.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn56.Header).VisiblePosition = 0;
    ultraGridColumn56.Width = 78;
    ultraGridColumn57.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance215).TextHAlignAsString = "Left";
    ultraGridColumn57.CellAppearance = (AppearanceBase) appearance215;
    ((AppearanceBase) appearance216).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn57.Header).Appearance = (AppearanceBase) appearance216;
    ((HeaderBase) ultraGridColumn57.Header).Caption = "Description";
    ((HeaderBase) ultraGridColumn57.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn57.Header).VisiblePosition = 1;
    ultraGridColumn57.Width = 87;
    ultraGridColumn58.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance217).TextHAlignAsString = "Left";
    ultraGridColumn58.CellAppearance = (AppearanceBase) appearance217;
    ((AppearanceBase) appearance218).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn58.Header).Appearance = (AppearanceBase) appearance218;
    ((HeaderBase) ultraGridColumn58.Header).Caption = "Post Date";
    ((HeaderBase) ultraGridColumn58.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn58.Header).VisiblePosition = 2;
    ultraGridColumn58.Width = 72;
    ultraGridColumn59.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance219).TextHAlignAsString = "Left";
    ultraGridColumn59.CellAppearance = (AppearanceBase) appearance219;
    ((AppearanceBase) appearance220).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn59.Header).Appearance = (AppearanceBase) appearance220;
    ((HeaderBase) ultraGridColumn59.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn59.Header).VisiblePosition = 3;
    ultraGridColumn59.Hidden = true;
    ultraGridColumn59.Width = 63 /*0x3F*/;
    ultraGridColumn60.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance221).TextHAlignAsString = "Left";
    ultraGridColumn60.CellAppearance = (AppearanceBase) appearance221;
    ((AppearanceBase) appearance222).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn60.Header).Appearance = (AppearanceBase) appearance222;
    ((HeaderBase) ultraGridColumn60.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn60.Header).VisiblePosition = 4;
    ultraGridColumn60.Width = 78;
    ultraGridColumn61.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance223).TextHAlignAsString = "Left";
    ultraGridColumn61.CellAppearance = (AppearanceBase) appearance223;
    ((AppearanceBase) appearance224).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn61.Header).Appearance = (AppearanceBase) appearance224;
    ((HeaderBase) ultraGridColumn61.Header).Caption = "Voided";
    ((HeaderBase) ultraGridColumn61.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn61.Header).VisiblePosition = 5;
    ultraGridColumn61.Hidden = true;
    ultraGridColumn61.Width = 45;
    ultraGridColumn62.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance225).TextHAlignAsString = "Right";
    ultraGridColumn62.CellAppearance = (AppearanceBase) appearance225;
    ultraGridColumn62.Format = "c";
    ((AppearanceBase) appearance226).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn62.Header).Appearance = (AppearanceBase) appearance226;
    ((HeaderBase) ultraGridColumn62.Header).Caption = "AR";
    ((HeaderBase) ultraGridColumn62.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn62.Header).VisiblePosition = 6;
    ultraGridColumn62.Width = 63 /*0x3F*/;
    ultraGridColumn63.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance227).TextHAlignAsString = "Right";
    ultraGridColumn63.CellAppearance = (AppearanceBase) appearance227;
    ultraGridColumn63.Format = "c";
    ((AppearanceBase) appearance228).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn63.Header).Appearance = (AppearanceBase) appearance228;
    ((HeaderBase) ultraGridColumn63.Header).Caption = "AP";
    ((HeaderBase) ultraGridColumn63.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn63.Header).VisiblePosition = 7;
    ultraGridColumn63.Width = 63 /*0x3F*/;
    ultraGridColumn64.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance229).TextHAlignAsString = "Right";
    ultraGridColumn64.CellAppearance = (AppearanceBase) appearance229;
    ultraGridColumn64.Format = "c";
    ((AppearanceBase) appearance230).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn64.Header).Appearance = (AppearanceBase) appearance230;
    ((HeaderBase) ultraGridColumn64.Header).Caption = "Exchange";
    ((HeaderBase) ultraGridColumn64.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn64.Header).VisiblePosition = 8;
    ultraGridColumn64.Width = 71;
    ultraGridColumn65.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance231).TextHAlignAsString = "Right";
    ultraGridColumn65.CellAppearance = (AppearanceBase) appearance231;
    ultraGridColumn65.Format = "c";
    ((AppearanceBase) appearance232).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn65.Header).Appearance = (AppearanceBase) appearance232;
    ((HeaderBase) ultraGridColumn65.Header).Caption = "Un-Accounted";
    ((HeaderBase) ultraGridColumn65.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn65.Header).VisiblePosition = 9;
    ultraGridColumn65.Width = 79;
    ultraGridColumn66.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance233).TextHAlignAsString = "Right";
    ultraGridColumn66.CellAppearance = (AppearanceBase) appearance233;
    ultraGridColumn66.Format = "c";
    ((AppearanceBase) appearance234).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn66.Header).Appearance = (AppearanceBase) appearance234;
    ((HeaderBase) ultraGridColumn66.Header).Caption = "Income";
    ((HeaderBase) ultraGridColumn66.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn66.Header).VisiblePosition = 10;
    ultraGridColumn66.Width = 81;
    ultraGridColumn67.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn67.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn67.Header).VisiblePosition = 11;
    ultraGridColumn67.Width = 80 /*0x50*/;
    ultraGridColumn68.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn68.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn68.Header).VisiblePosition = 12;
    ultraGridColumn68.Width = 78;
    ultraGridBand9.Columns.AddRange(new object[13]
    {
      (object) ultraGridColumn56,
      (object) ultraGridColumn57,
      (object) ultraGridColumn58,
      (object) ultraGridColumn59,
      (object) ultraGridColumn60,
      (object) ultraGridColumn61,
      (object) ultraGridColumn62,
      (object) ultraGridColumn63,
      (object) ultraGridColumn64,
      (object) ultraGridColumn65,
      (object) ultraGridColumn66,
      (object) ultraGridColumn67,
      (object) ultraGridColumn68
    });
    ((AppearanceBase) appearance235).BackColor = Color.LightSteelBlue;
    ultraGridBand9.Override.SummaryFooterAppearance = (AppearanceBase) appearance235;
    ultraGridBand9.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance236).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance236).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance236).TextHAlignAsString = "Right";
    summarySettings27.Appearance = (AppearanceBase) appearance236;
    summarySettings27.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance237).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance237).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance237).TextHAlignAsString = "Right";
    summarySettings28.Appearance = (AppearanceBase) appearance237;
    summarySettings28.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance238).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance238).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance238).TextHAlignAsString = "Right";
    summarySettings29.Appearance = (AppearanceBase) appearance238;
    summarySettings29.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance239).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance239).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance239).TextHAlignAsString = "Right";
    summarySettings30.Appearance = (AppearanceBase) appearance239;
    summarySettings30.DisplayFormat = "{0:c}";
    ((AppearanceBase) appearance240).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance240).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance240).TextHAlignAsString = "Right";
    summarySettings31.Appearance = (AppearanceBase) appearance240;
    summarySettings31.DisplayFormat = "{0:c}";
    ultraGridBand9.Summaries.AddRange(new SummarySettings[5]
    {
      summarySettings27,
      summarySettings28,
      summarySettings29,
      summarySettings30,
      summarySettings31
    });
    ultraGridLayout4.BandsSerializer.Add((object) ultraGridBand9);
    ultraGridLayout4.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout4).Key = "lyt1";
    ((AppearanceBase) appearance241).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance241).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance241).ForeColor = Color.Black;
    ultraGridLayout4.Override.ActiveRowAppearance = (AppearanceBase) appearance241;
    ultraGridLayout4.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout4.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout4.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridLayout4.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance242).BorderColor = Color.LightGray;
    ultraGridLayout4.Override.CellAppearance = (AppearanceBase) appearance242;
    ultraGridLayout4.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance243).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridLayout4.Override.HeaderAppearance = (AppearanceBase) appearance243;
    ultraGridLayout4.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridLayout4.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance244).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout4.Override.RowAlternateAppearance = (AppearanceBase) appearance244;
    ((AppearanceBase) appearance245).BorderColor = Color.LightGray;
    ultraGridLayout4.Override.RowAppearance = (AppearanceBase) appearance245;
    ultraGridLayout4.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance246).BackColor = Color.Transparent;
    ((AppearanceBase) appearance246).ForeColor = Color.Black;
    ultraGridLayout4.Override.SelectedRowAppearance = (AppearanceBase) appearance246;
    ((AppearanceBase) appearance247).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance247).BorderColor = Color.Silver;
    scrollBarLook9.ButtonAppearance = (AppearanceBase) appearance247;
    ((AppearanceBase) appearance248).BackColor = Color.White;
    scrollBarLook9.TrackAppearance = (AppearanceBase) appearance248;
    ultraGridLayout4.ScrollBarLook = scrollBarLook9;
    ((UltraGridBase) this.gridPolicyActivity).Layouts.Add(ultraGridLayout4);
    ((Control) this.gridPolicyActivity).Location = new Point(3, 6);
    ((Control) this.gridPolicyActivity).Name = "gridPolicyActivity";
    ((Control) this.gridPolicyActivity).Size = new Size(832, 160 /*0xA0*/);
    ((Control) this.gridPolicyActivity).TabIndex = 20;
    ((UltraControlBase) this.gridPolicyActivity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPolicyActivity).UseOsThemes = (DefaultableBoolean) 2;
    this.gridPolicyActivity.AfterRowActivate += new EventHandler(this.gridPolicyActivity_AfterRowActivate);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.ellipsePanel1);
    ((Control) this.UltraTabPageControl1).Controls.Add((Control) this.ElipsePanel1);
    ((Control) this.UltraTabPageControl1).Location = new Point(1, 22);
    ((Control) this.UltraTabPageControl1).Name = "UltraTabPageControl1";
    ((Control) this.UltraTabPageControl1).Size = new Size(1070, 570);
    this.ellipsePanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ellipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel1.Controls.Add((Control) this.ultraGrid2);
    this.ellipsePanel1.Controls.Add((Control) this.UltraGrid1);
    this.ellipsePanel1.Controls.Add((Control) this.label36);
    this.ellipsePanel1.CornerOffset = 20;
    this.ellipsePanel1.Location = new Point(208 /*0xD0*/, 208 /*0xD0*/);
    this.ellipsePanel1.Name = "ellipsePanel1";
    this.ellipsePanel1.Size = new Size(858, 328);
    this.ellipsePanel1.TabIndex = 31 /*0x1F*/;
    ((Control) this.ultraGrid2).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ultraGrid2).DataMember = "ReinstatementInformation";
    ((UltraGridBase) this.ultraGrid2).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance249).BackColor = Color.White;
    ((AppearanceBase) appearance249).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Appearance = (AppearanceBase) appearance249;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn69.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance250).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn69.Header).Appearance = (AppearanceBase) appearance250;
    ((HeaderBase) ultraGridColumn69.Header).Caption = "Issued Message";
    ((HeaderBase) ultraGridColumn69.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn69.Header).VisiblePosition = 0;
    ultraGridColumn69.Width = 412;
    ultraGridColumn70.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance251).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn70.Header).Appearance = (AppearanceBase) appearance251;
    ((HeaderBase) ultraGridColumn70.Header).Caption = "Effective Message";
    ((HeaderBase) ultraGridColumn70.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn70.Header).VisiblePosition = 1;
    ultraGridColumn70.Width = 426;
    ultraGridBand10.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn69,
      (object) ultraGridColumn70
    });
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.BandsSerializer.Add((object) ultraGridBand10);
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance252).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance252).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance252).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance252;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance253).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance253;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance254).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance254;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance255).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance255;
    ((AppearanceBase) appearance256).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance256;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance257).BackColor = Color.Transparent;
    ((AppearanceBase) appearance257).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance257;
    ((AppearanceBase) appearance258).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance258).BorderColor = Color.Silver;
    scrollBarLook10.ButtonAppearance = (AppearanceBase) appearance258;
    ((AppearanceBase) appearance259).BackColor = Color.White;
    scrollBarLook10.TrackAppearance = (AppearanceBase) appearance259;
    ((UltraGridBase) this.ultraGrid2).DisplayLayout.ScrollBarLook = scrollBarLook10;
    ((Control) this.ultraGrid2).Location = new Point(8, 160 /*0xA0*/);
    ((Control) this.ultraGrid2).Name = "ultraGrid2";
    ((Control) this.ultraGrid2).Size = new Size(840, 160 /*0xA0*/);
    ((Control) this.ultraGrid2).TabIndex = 33;
    ((UltraControlBase) this.ultraGrid2).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ultraGrid2).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraGrid1).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.UltraGrid1).DataMember = "CancellationInformation";
    ((UltraGridBase) this.UltraGrid1).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance260).BackColor = Color.White;
    ((AppearanceBase) appearance260).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance260;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn71.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance261).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn71.Header).Appearance = (AppearanceBase) appearance261;
    ((HeaderBase) ultraGridColumn71.Header).Caption = "Issuance Date";
    ((HeaderBase) ultraGridColumn71.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn71.Header).VisiblePosition = 0;
    ultraGridColumn71.Width = 155;
    ultraGridColumn72.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance262).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn72.Header).Appearance = (AppearanceBase) appearance262;
    ((HeaderBase) ultraGridColumn72.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn72.Header).VisiblePosition = 1;
    ultraGridColumn72.Width = 171;
    ultraGridColumn73.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance263).TextHAlignAsString = "Right";
    ultraGridColumn73.CellAppearance = (AppearanceBase) appearance263;
    ultraGridColumn73.Format = "c";
    ((AppearanceBase) appearance264).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn73.Header).Appearance = (AppearanceBase) appearance264;
    ((HeaderBase) ultraGridColumn73.Header).Caption = "Past Due Amt";
    ((HeaderBase) ultraGridColumn73.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn73.Header).VisiblePosition = 2;
    ultraGridColumn73.Width = 137;
    ultraGridColumn74.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance265).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn74.Header).Appearance = (AppearanceBase) appearance265;
    ((HeaderBase) ultraGridColumn74.Header).Caption = "Cancellation Date";
    ((HeaderBase) ultraGridColumn74.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn74.Header).VisiblePosition = 3;
    ultraGridColumn74.Width = 171;
    ultraGridColumn75.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance266).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn75.Header).Appearance = (AppearanceBase) appearance266;
    ((HeaderBase) ultraGridColumn75.Header).Caption = "Cancellation Message";
    ((HeaderBase) ultraGridColumn75.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn75.Header).VisiblePosition = 4;
    ultraGridColumn75.Width = 204;
    ultraGridBand11.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn71,
      (object) ultraGridColumn72,
      (object) ultraGridColumn73,
      (object) ultraGridColumn74,
      (object) ultraGridColumn75
    });
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand11);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance267).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance267).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance267).ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance267;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance268).BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance268;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance269).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance269;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance270).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance270;
    ((AppearanceBase) appearance271).BorderColor = Color.LightGray;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance271;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance272).BackColor = Color.Transparent;
    ((AppearanceBase) appearance272).ForeColor = Color.Black;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance272;
    ((AppearanceBase) appearance273).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance273).BorderColor = Color.Silver;
    scrollBarLook11.ButtonAppearance = (AppearanceBase) appearance273;
    ((AppearanceBase) appearance274).BackColor = Color.White;
    scrollBarLook11.TrackAppearance = (AppearanceBase) appearance274;
    ((UltraGridBase) this.UltraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook11;
    ((Control) this.UltraGrid1).Location = new Point(8, 24);
    ((Control) this.UltraGrid1).Name = "UltraGrid1";
    ((Control) this.UltraGrid1).Size = new Size(840, 128 /*0x80*/);
    ((Control) this.UltraGrid1).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.UltraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    this.label36.AutoSize = true;
    this.label36.BackColor = Color.Transparent;
    this.label36.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label36.ForeColor = Color.SteelBlue;
    this.label36.Location = new Point(8, 8);
    this.label36.Name = "label36";
    this.label36.Size = new Size(251, 13);
    this.label36.TabIndex = 17;
    this.label36.Text = "Cancellation / Re-Instatement Information";
    this.ElipsePanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ElipsePanel1.BackColor = Color.FromArgb(239, 247, 253);
    this.ElipsePanel1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ElipsePanel1.Controls.Add((Control) this.gridStatusChanges);
    this.ElipsePanel1.Controls.Add((Control) this.Label25);
    this.ElipsePanel1.CornerOffset = 20;
    this.ElipsePanel1.Location = new Point(208 /*0xD0*/, 88);
    this.ElipsePanel1.Name = "ElipsePanel1";
    this.ElipsePanel1.Size = new Size(850, 129);
    this.ElipsePanel1.TabIndex = 20;
    ((Control) this.gridStatusChanges).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridStatusChanges).DataMember = "PolicyStatusChanges";
    ((UltraGridBase) this.gridStatusChanges).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance275).BackColor = Color.White;
    ((AppearanceBase) appearance275).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Appearance = (AppearanceBase) appearance275;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn76.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance276).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn76.Header).Appearance = (AppearanceBase) appearance276;
    ((HeaderBase) ultraGridColumn76.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn76.Header).VisiblePosition = 0;
    ultraGridColumn76.Width = 286;
    ultraGridColumn77.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance277).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn77.Header).Appearance = (AppearanceBase) appearance277;
    ((HeaderBase) ultraGridColumn77.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn77.Header).VisiblePosition = 1;
    ultraGridColumn77.Width = 283;
    ultraGridColumn78.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance278).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn78.Header).Appearance = (AppearanceBase) appearance278;
    ((HeaderBase) ultraGridColumn78.Header).Caption = "Date Changed";
    ((HeaderBase) ultraGridColumn78.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn78.Header).VisiblePosition = 2;
    ultraGridColumn78.Width = 257;
    ultraGridBand12.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn76,
      (object) ultraGridColumn77,
      (object) ultraGridColumn78
    });
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.BandsSerializer.Add((object) ultraGridBand12);
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance279).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance279).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance279).ForeColor = Color.Black;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance279;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance280).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance280;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance281).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance281;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance282).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance282;
    ((AppearanceBase) appearance283).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance283;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance284).BackColor = Color.Transparent;
    ((AppearanceBase) appearance284).ForeColor = Color.Black;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance284;
    ((AppearanceBase) appearance285).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance285).BorderColor = Color.Silver;
    scrollBarLook12.ButtonAppearance = (AppearanceBase) appearance285;
    ((AppearanceBase) appearance286).BackColor = Color.White;
    scrollBarLook12.TrackAppearance = (AppearanceBase) appearance286;
    ((UltraGridBase) this.gridStatusChanges).DisplayLayout.ScrollBarLook = scrollBarLook12;
    ((Control) this.gridStatusChanges).Location = new Point(10, 7);
    ((Control) this.gridStatusChanges).Name = "gridStatusChanges";
    ((Control) this.gridStatusChanges).Size = new Size(828, 115);
    ((Control) this.gridStatusChanges).TabIndex = 0;
    ((UltraControlBase) this.gridStatusChanges).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridStatusChanges).UseOsThemes = (DefaultableBoolean) 2;
    this.Label25.AutoSize = true;
    this.Label25.BackColor = Color.Transparent;
    this.Label25.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label25.ForeColor = Color.SteelBlue;
    this.Label25.Location = new Point(8, 8);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(131, 13);
    this.Label25.TabIndex = 17;
    this.Label25.Text = "Policy Status Changes";
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.invoicePayeeBreakout1);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.transactionCommentsViewer2);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.panelInvoiceActivity);
    ((Control) this.UltraTabPageControl2).Controls.Add((Control) this.ElipsePanel2);
    ((Control) this.UltraTabPageControl2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl2).Name = "UltraTabPageControl2";
    ((Control) this.UltraTabPageControl2).Size = new Size(1070, 545);
    this.invoicePayeeBreakout1.Font = new Font("Tahoma", 8.25f);
    this.invoicePayeeBreakout1.Location = new Point(216, 76);
    this.invoicePayeeBreakout1.Name = "invoicePayeeBreakout1";
    this.invoicePayeeBreakout1.Size = new Size(418, 368);
    this.invoicePayeeBreakout1.TabIndex = 21;
    this.invoicePayeeBreakout1.Visible = false;
    this.transactionCommentsViewer2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.transactionCommentsViewer2.BackColor = Color.White;
    this.transactionCommentsViewer2.Font = new Font("Tahoma", 8f);
    this.transactionCommentsViewer2.ForeColor = Color.Black;
    this.transactionCommentsViewer2.Location = new Point(770, 88);
    this.transactionCommentsViewer2.Name = "transactionCommentsViewer2";
    this.transactionCommentsViewer2.Size = new Size(280, 211);
    this.transactionCommentsViewer2.TabIndex = 31 /*0x1F*/;
    this.transactionCommentsViewer2.Visible = false;
    this.panelInvoiceActivity.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelInvoiceActivity.BackColor = Color.FromArgb(239, 247, 253);
    this.panelInvoiceActivity.BorderColor = Color.DarkSlateGray;
    this.panelInvoiceActivity.Controls.Add((Control) this.chkShowVoids);
    this.panelInvoiceActivity.Controls.Add((Control) this.utcInvoiceActivity);
    this.panelInvoiceActivity.Controls.Add((Control) this.panelInvoiceActivityCurtain);
    this.panelInvoiceActivity.CornerOffset = 20;
    this.panelInvoiceActivity.Location = new Point(208 /*0xD0*/, 225);
    this.panelInvoiceActivity.Name = "panelInvoiceActivity";
    this.panelInvoiceActivity.Size = new Size(856, 341);
    this.panelInvoiceActivity.TabIndex = 22;
    this.chkShowVoids.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.chkShowVoids.BackColor = Color.FromArgb(239, 247, 253);
    this.chkShowVoids.FlatStyle = FlatStyle.Flat;
    this.chkShowVoids.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.chkShowVoids.ForeColor = Color.SteelBlue;
    this.chkShowVoids.Location = new Point(758, 4);
    this.chkShowVoids.Name = "chkShowVoids";
    this.chkShowVoids.Size = new Size(86, 16 /*0x10*/);
    this.chkShowVoids.TabIndex = 24;
    this.chkShowVoids.Text = "Show Voids";
    this.chkShowVoids.UseVisualStyleBackColor = false;
    this.chkShowVoids.Visible = false;
    this.chkShowVoids.CheckedChanged += new EventHandler(this.chkShowVoids_CheckedChanged);
    ((Control) this.utcInvoiceActivity).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance287).BackColor = Color.FromArgb(239, 247, 253);
    ((UltraTabControlBase) this.utcInvoiceActivity).Appearance = (AppearanceBase) appearance287;
    ((Control) this.utcInvoiceActivity).Controls.Add((Control) this.UltraTabPageControl3);
    ((Control) this.utcInvoiceActivity).Controls.Add((Control) this.UltraTabSharedControlsPage2);
    ((Control) this.utcInvoiceActivity).Controls.Add((Control) this.UltraTabPageControl4);
    ((Control) this.utcInvoiceActivity).Location = new Point(8, 8);
    ((Control) this.utcInvoiceActivity).Name = "utcInvoiceActivity";
    ((UltraTabControlBase) this.utcInvoiceActivity).SharedControlsPage = this.UltraTabSharedControlsPage2;
    ((Control) this.utcInvoiceActivity).Size = new Size(838, 320);
    ((UltraTabControlBase) this.utcInvoiceActivity).SpaceAfterTabs = new DefaultableInteger(10);
    ((UltraTabControlBase) this.utcInvoiceActivity).Style = (UltraTabControlStyle) 12;
    ((AppearanceBase) appearance288).BackColor = Color.FromArgb(239, 247, 253);
    ((UltraTabControlBase) this.utcInvoiceActivity).TabHeaderAreaAppearance = (AppearanceBase) appearance288;
    ((Control) this.utcInvoiceActivity).TabIndex = 25;
    ultraTab1.FixedWidth = 150;
    ultraTab1.TabPage = this.UltraTabPageControl3;
    ultraTab1.Text = "Invoice Details";
    ultraTab2.FixedWidth = 150;
    ultraTab2.TabPage = this.UltraTabPageControl4;
    ultraTab2.Text = "Invoice Activity";
    ((UltraTabControlBase) this.utcInvoiceActivity).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((UltraControlBase) this.utcInvoiceActivity).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.utcInvoiceActivity).SelectedTabChanged += new SelectedTabChangedEventHandler(this.utcInvoiceActivity_SelectedTabChanged);
    ((Control) this.UltraTabSharedControlsPage2).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage2).Name = "UltraTabSharedControlsPage2";
    ((Control) this.UltraTabSharedControlsPage2).Size = new Size(836, 299);
    this.panelInvoiceActivityCurtain.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.panelInvoiceActivityCurtain.BackColor = Color.FromArgb(239, 247, 253);
    this.panelInvoiceActivityCurtain.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelInvoiceActivityCurtain.Controls.Add((Control) this.Label8);
    this.panelInvoiceActivityCurtain.Controls.Add((Control) this.Label7);
    this.panelInvoiceActivityCurtain.Controls.Add((Control) this.Label2);
    this.panelInvoiceActivityCurtain.CornerOffset = 20;
    this.panelInvoiceActivityCurtain.Location = new Point(0, 0);
    this.panelInvoiceActivityCurtain.Name = "panelInvoiceActivityCurtain";
    this.panelInvoiceActivityCurtain.Size = new Size(856, 341);
    this.panelInvoiceActivityCurtain.TabIndex = 23;
    this.Label8.Anchor = AnchorStyles.Top;
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(316, 130);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(241, 13);
    this.Label8.TabIndex = 4;
    this.Label8.Text = "_______________________________________";
    this.Label7.Anchor = AnchorStyles.Top;
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(316, 198);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(241, 13);
    this.Label7.TabIndex = 3;
    this.Label7.Text = "_______________________________________";
    this.Label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Label2.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label2.ForeColor = Color.Black;
    this.Label2.Location = new Point(9, 102);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(838, 152);
    this.Label2.TabIndex = 1;
    this.Label2.Text = "Click on an invoice line above to display the invoice activity.";
    this.Label2.TextAlign = ContentAlignment.MiddleCenter;
    this.ElipsePanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ElipsePanel2.BackColor = Color.FromArgb(239, 247, 253);
    this.ElipsePanel2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ElipsePanel2.Controls.Add((Control) this.ultraTabControl4);
    this.ElipsePanel2.CornerOffset = 20;
    this.ElipsePanel2.Location = new Point(207, 10);
    this.ElipsePanel2.Name = "ElipsePanel2";
    this.ElipsePanel2.Size = new Size(856, 209);
    this.ElipsePanel2.TabIndex = 21;
    ((Control) this.ultraTabControl4).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance289).BackColor = Color.FromArgb(239, 247, 253);
    ((UltraTabControlBase) this.ultraTabControl4).Appearance = (AppearanceBase) appearance289;
    ((Control) this.ultraTabControl4).Controls.Add((Control) this.ultraTabSharedControlsPage5);
    ((Control) this.ultraTabControl4).Controls.Add((Control) this.ultraTabPageControl8);
    ((Control) this.ultraTabControl4).Controls.Add((Control) this.ultraTabPageControl9);
    ((Control) this.ultraTabControl4).Location = new Point(9, 6);
    ((Control) this.ultraTabControl4).Name = "ultraTabControl4";
    ((UltraTabControlBase) this.ultraTabControl4).SharedControlsPage = this.ultraTabSharedControlsPage5;
    ((Control) this.ultraTabControl4).Size = new Size(838, 194);
    ((UltraTabControlBase) this.ultraTabControl4).SpaceAfterTabs = new DefaultableInteger(10);
    ((UltraTabControlBase) this.ultraTabControl4).Style = (UltraTabControlStyle) 12;
    ((AppearanceBase) appearance290).BackColor = Color.FromArgb(239, 247, 253);
    ((UltraTabControlBase) this.ultraTabControl4).TabHeaderAreaAppearance = (AppearanceBase) appearance290;
    ((Control) this.ultraTabControl4).TabIndex = 26;
    ultraTab3.FixedWidth = 150;
    ultraTab3.TabPage = this.ultraTabPageControl8;
    ultraTab3.Text = "Invoice Listing";
    ultraTab4.FixedWidth = 150;
    ultraTab4.TabPage = this.ultraTabPageControl9;
    ultraTab4.Text = "Policy Activity";
    ((UltraTabControlBase) this.ultraTabControl4).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab3,
      ultraTab4
    });
    ((UltraControlBase) this.ultraTabControl4).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraTabSharedControlsPage5).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage5).Name = "ultraTabSharedControlsPage5";
    ((Control) this.ultraTabSharedControlsPage5).Size = new Size(836, 173);
    ((Control) this.UltraTabPageControl5).Controls.Add((Control) this.gridPolicyInquiryComments);
    ((Control) this.UltraTabPageControl5).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabPageControl5).Name = "UltraTabPageControl5";
    ((Control) this.UltraTabPageControl5).Size = new Size(1070, 545);
    ((Control) this.gridPolicyInquiryComments).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.gridPolicyInquiryComments, "CommentsMenu");
    ((UltraGridBase) this.gridPolicyInquiryComments).DataMember = "PolicyInquiryComments";
    ((UltraGridBase) this.gridPolicyInquiryComments).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance291).BackColor = Color.White;
    ((AppearanceBase) appearance291).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Appearance = (AppearanceBase) appearance291;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn79.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn79.Header).VisiblePosition = 0;
    ultraGridColumn79.Hidden = true;
    ultraGridColumn79.Width = 176 /*0xB0*/;
    ((HeaderBase) ultraGridColumn80.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn80.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn80.Header).VisiblePosition = 1;
    ultraGridColumn80.Width = 64 /*0x40*/;
    ((HeaderBase) ultraGridColumn81.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn81.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn81.Header).VisiblePosition = 2;
    ultraGridColumn81.Width = 159;
    ((HeaderBase) ultraGridColumn82.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn82.Header).VisiblePosition = 3;
    ultraGridColumn82.Width = 621;
    ultraGridBand13.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn79,
      (object) ultraGridColumn80,
      (object) ultraGridColumn81,
      (object) ultraGridColumn82
    });
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.BandsSerializer.Add((object) ultraGridBand13);
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance292).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance292).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance292).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance292;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance293).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance293;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance294).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance294).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance294;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance295).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance295;
    ((AppearanceBase) appearance296).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance296;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.RowSizing = (RowSizing) 5;
    ((AppearanceBase) appearance297).BackColor = Color.Transparent;
    ((AppearanceBase) appearance297).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance297;
    ((AppearanceBase) appearance298).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance298).BorderColor = Color.Silver;
    scrollBarLook13.ButtonAppearance = (AppearanceBase) appearance298;
    ((AppearanceBase) appearance299).BackColor = Color.White;
    scrollBarLook13.TrackAppearance = (AppearanceBase) appearance299;
    ((UltraGridBase) this.gridPolicyInquiryComments).DisplayLayout.ScrollBarLook = scrollBarLook13;
    ((Control) this.gridPolicyInquiryComments).Location = new Point(216, 88);
    ((Control) this.gridPolicyInquiryComments).Name = "gridPolicyInquiryComments";
    ((Control) this.gridPolicyInquiryComments).Size = new Size(846, 481);
    ((Control) this.gridPolicyInquiryComments).TabIndex = 33;
    ((UltraControlBase) this.gridPolicyInquiryComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridPolicyInquiryComments).UseOsThemes = (DefaultableBoolean) 2;
    this.daPolicyInquiryInvoicePremiumLines.SelectCommand = this.SqlSelectCommand6;
    this.daPolicyInquiryInvoicePremiumLines.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_PolicyInquiryInvoicePremiumLines", new DataColumnMapping[2]
      {
        new DataColumnMapping("premiumName", "premiumName"),
        new DataColumnMapping("Amount", "Amount")
      })
    });
    this.SqlSelectCommand6.CommandText = "[spFin_PolicyInquiryInvoicePremiumLines]";
    this.SqlSelectCommand6.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand6.Connection = this.FormDataConnection;
    this.SqlSelectCommand6.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@invoiceNum", SqlDbType.Int, 4)
    });
    this.FormDataConnection.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.daPolicyInquiryHeader.SelectCommand = this.SqlSelectCommand1;
    this.daPolicyInquiryHeader.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_PolicyInquiryPolicyHeader", new DataColumnMapping[8]
      {
        new DataColumnMapping("policyNumber", "policyNumber"),
        new DataColumnMapping("Insured", "Insured"),
        new DataColumnMapping("effectivedate", "effectivedate"),
        new DataColumnMapping("expirationdate", "expirationdate"),
        new DataColumnMapping("Producer", "Producer"),
        new DataColumnMapping("Company", "Company"),
        new DataColumnMapping("Underwriter", "Underwriter"),
        new DataColumnMapping("ControlNumber", "ControlNumber")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_PolicyInquiryPolicyHeader]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@controlno", SqlDbType.Int, 4)
    });
    this.ImageList1.ImageStream = (ImageListStreamer) componentResourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    this.ImageList1.Images.SetKeyName(0, "");
    this.ImageList1.Images.SetKeyName(1, "");
    this.ImageList1.Images.SetKeyName(2, "");
    this.ImageList1.Images.SetKeyName(3, "");
    this.daPolicyInquiryPolicyStatus.SelectCommand = this.SqlSelectCommand2;
    this.daPolicyInquiryPolicyStatus.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_PolicyInquiryStatusChanges", new DataColumnMapping[3]
      {
        new DataColumnMapping("Status", "Status"),
        new DataColumnMapping("Reason", "Reason"),
        new DataColumnMapping("DateChanged", "DateChanged")
      })
    });
    this.SqlSelectCommand2.CommandText = "[spFin_PolicyInquiryStatusChanges]";
    this.SqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand2.Connection = this.FormDataConnection;
    this.SqlSelectCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@controlno", SqlDbType.Int, 4)
    });
    this.panelPolicyInquiry2.Controls.Add((Control) this.UltraTabControl1);
    this.panelPolicyInquiry2.Controls.Add((Control) this.panelCurtain);
    this.panelPolicyInquiry2.Controls.Add((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Left);
    this.panelPolicyInquiry2.Controls.Add((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Right);
    this.panelPolicyInquiry2.Controls.Add((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom);
    this.panelPolicyInquiry2.Controls.Add((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Top);
    this.panelPolicyInquiry2.Dock = DockStyle.Fill;
    this.panelPolicyInquiry2.Location = new Point(0, 0);
    this.panelPolicyInquiry2.Name = "panelPolicyInquiry2";
    this.panelPolicyInquiry2.Size = new Size(1072, 638);
    this.panelPolicyInquiry2.TabIndex = 14;
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabSharedControlsPage1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl1);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl2);
    ((Control) this.UltraTabControl1).Controls.Add((Control) this.UltraTabPageControl5);
    ((Control) this.UltraTabControl1).Dock = DockStyle.Fill;
    ((Control) this.UltraTabControl1).Location = new Point(0, 45);
    ((Control) this.UltraTabControl1).Name = "UltraTabControl1";
    ((UltraTabControlBase) this.UltraTabControl1).SharedControls.AddRange(new Control[28]
    {
      (Control) this.lblCostCenter,
      (Control) this.label66,
      (Control) this.checkDisableNOC,
      (Control) this.labelOfficeLocation,
      (Control) this.label69,
      (Control) this.lblBillingType,
      (Control) this.label67,
      (Control) this.labelCurrency,
      (Control) this.label68,
      (Control) this.lblCurrentStatus,
      (Control) this.Label19,
      (Control) this.Label15,
      (Control) this.lblExpirationDate,
      (Control) this.Label11,
      (Control) this.lblControlNumber,
      (Control) this.Label23,
      (Control) this.lblUnderwriter,
      (Control) this.Label22,
      (Control) this.lblCompany,
      (Control) this.lblProducer,
      (Control) this.lblEffectiveDate,
      (Control) this.lblInsured,
      (Control) this.lblPolicyNumber,
      (Control) this.Label13,
      (Control) this.Label12,
      (Control) this.Label10,
      (Control) this.Label6,
      (Control) this.Label3
    });
    ((UltraTabControlBase) this.UltraTabControl1).SharedControlsPage = this.UltraTabSharedControlsPage1;
    ((Control) this.UltraTabControl1).Size = new Size(1072, 593);
    ((AppearanceBase) appearance300).BackColor = Color.LightSteelBlue;
    ((UltraTabControlBase) this.UltraTabControl1).TabHeaderAreaAppearance = (AppearanceBase) appearance300;
    ((Control) this.UltraTabControl1).TabIndex = 0;
    ((UltraTabControlBase) this.UltraTabControl1).TabLayoutStyle = (TabLayoutStyle) 5;
    ((AppearanceBase) appearance301).ImageHAlign = (HAlign) 3;
    ultraTab5.Appearance = (AppearanceBase) appearance301;
    ultraTab5.TabPage = this.UltraTabPageControl1;
    ultraTab5.Text = "Policy Information / Status Changes";
    ((AppearanceBase) appearance302).ImageHAlign = (HAlign) 3;
    ultraTab6.Appearance = (AppearanceBase) appearance302;
    ultraTab6.TabPage = this.UltraTabPageControl2;
    ultraTab6.Text = "Policy Financials / Invoice History";
    ((AppearanceBase) appearance303).ImageHAlign = (HAlign) 3;
    ultraTab7.Appearance = (AppearanceBase) appearance303;
    ultraTab7.TabPage = this.UltraTabPageControl5;
    ultraTab7.Text = "Policy Notes";
    ((UltraTabControlBase) this.UltraTabControl1).Tabs.AddRange(new UltraTab[3]
    {
      ultraTab5,
      ultraTab6,
      ultraTab7
    });
    ((UltraControlBase) this.UltraTabControl1).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraTabControlBase) this.UltraTabControl1).ViewStyle = (ViewStyle) 4;
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblCostCenter);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.label66);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.checkDisableNOC);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.labelOfficeLocation);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.label69);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblBillingType);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.label67);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.labelCurrency);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.label68);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblCurrentStatus);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label19);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label15);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblExpirationDate);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label11);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblControlNumber);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label23);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblUnderwriter);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label22);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblCompany);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblProducer);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblEffectiveDate);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblInsured);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.lblPolicyNumber);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label13);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label12);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label10);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label6);
    ((Control) this.UltraTabSharedControlsPage1).Controls.Add((Control) this.Label3);
    ((Control) this.UltraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.UltraTabSharedControlsPage1).Name = "UltraTabSharedControlsPage1";
    ((Control) this.UltraTabSharedControlsPage1).Size = new Size(1070, 570);
    this.lblCostCenter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.lblCostCenter.AutoSize = true;
    this.lblCostCenter.BackColor = Color.Transparent;
    this.lblCostCenter.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblCostCenter.Location = new Point(919, 25);
    this.lblCostCenter.Name = "lblCostCenter";
    this.lblCostCenter.Size = new Size(73, 13);
    this.lblCostCenter.TabIndex = 76;
    this.lblCostCenter.Text = "[Cost Center]";
    this.lblCostCenter.UseMnemonic = false;
    this.label66.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label66.AutoSize = true;
    this.label66.BackColor = Color.Transparent;
    this.label66.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label66.Location = new Point(919, 9);
    this.label66.Name = "label66";
    this.label66.Size = new Size(76, 13);
    this.label66.TabIndex = 75;
    this.label66.Text = "Cost Center:";
    this.checkDisableNOC.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.checkDisableNOC.BackColor = Color.Transparent;
    this.checkDisableNOC.CheckAlign = ContentAlignment.MiddleRight;
    this.checkDisableNOC.FlatStyle = FlatStyle.Flat;
    this.checkDisableNOC.Location = new Point(847, 61);
    this.checkDisableNOC.Name = "checkDisableNOC";
    this.checkDisableNOC.Size = new Size(199, 21);
    this.checkDisableNOC.TabIndex = 74;
    this.checkDisableNOC.Text = "Disable NOC Issuance";
    this.checkDisableNOC.TextAlign = ContentAlignment.MiddleRight;
    this.checkDisableNOC.UseVisualStyleBackColor = false;
    this.labelOfficeLocation.AutoSize = true;
    this.labelOfficeLocation.BackColor = Color.Transparent;
    this.labelOfficeLocation.Location = new Point(10, 145);
    this.labelOfficeLocation.Name = "labelOfficeLocation";
    this.labelOfficeLocation.Size = new Size(87, 13);
    this.labelOfficeLocation.TabIndex = 73;
    this.labelOfficeLocation.Text = "[Office Location]";
    this.labelOfficeLocation.UseMnemonic = false;
    this.label69.AutoSize = true;
    this.label69.BackColor = Color.Transparent;
    this.label69.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label69.Location = new Point(10, 129);
    this.label69.Name = "label69";
    this.label69.Size = new Size(93, 13);
    this.label69.TabIndex = 72;
    this.label69.Text = "Office Location:";
    this.lblBillingType.AutoSize = true;
    this.lblBillingType.BackColor = Color.Transparent;
    this.lblBillingType.Location = new Point(10, 104);
    this.lblBillingType.Name = "lblBillingType";
    this.lblBillingType.Size = new Size(68, 13);
    this.lblBillingType.TabIndex = 71;
    this.lblBillingType.Text = "[Billing Type]";
    this.lblBillingType.UseMnemonic = false;
    this.label67.AutoSize = true;
    this.label67.BackColor = Color.Transparent;
    this.label67.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label67.Location = new Point(10, 88);
    this.label67.Name = "label67";
    this.label67.Size = new Size(74, 13);
    this.label67.TabIndex = 70;
    this.label67.Text = "Billing Type:";
    this.labelCurrency.AutoSize = true;
    this.labelCurrency.BackColor = Color.Transparent;
    this.labelCurrency.Location = new Point(85, 538);
    this.labelCurrency.Name = "labelCurrency";
    this.labelCurrency.Size = new Size(27, 13);
    this.labelCurrency.TabIndex = 69;
    this.labelCurrency.Text = "USD";
    this.labelCurrency.UseMnemonic = false;
    this.label68.AutoSize = true;
    this.label68.BackColor = Color.Transparent;
    this.label68.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label68.Location = new Point(11, 537);
    this.label68.Name = "label68";
    this.label68.Size = new Size(61, 13);
    this.label68.TabIndex = 68;
    this.label68.Text = "Currency:";
    this.lblCurrentStatus.AutoSize = true;
    this.lblCurrentStatus.BackColor = Color.Transparent;
    this.lblCurrentStatus.Location = new Point(11, 65);
    this.lblCurrentStatus.Name = "lblCurrentStatus";
    this.lblCurrentStatus.Size = new Size(86, 13);
    this.lblCurrentStatus.TabIndex = 67;
    this.lblCurrentStatus.Text = "[Current Status]";
    this.lblCurrentStatus.UseMnemonic = false;
    this.Label19.AutoSize = true;
    this.Label19.BackColor = Color.Transparent;
    this.Label19.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label19.Location = new Point(11, 49);
    this.Label19.Name = "Label19";
    this.Label19.Size = new Size(93, 13);
    this.Label19.TabIndex = 66;
    this.Label19.Text = "Current Status:";
    this.Label15.AutoSize = true;
    this.Label15.BackColor = Color.Transparent;
    this.Label15.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label15.Location = new Point(95, 285);
    this.Label15.Name = "Label15";
    this.Label15.Size = new Size(12, 13);
    this.Label15.TabIndex = 65;
    this.Label15.Text = "-";
    this.lblExpirationDate.AutoSize = true;
    this.lblExpirationDate.BackColor = Color.Transparent;
    this.lblExpirationDate.Location = new Point(107, 285);
    this.lblExpirationDate.Name = "lblExpirationDate";
    this.lblExpirationDate.Size = new Size(89, 13);
    this.lblExpirationDate.TabIndex = 64 /*0x40*/;
    this.lblExpirationDate.Text = "[Expiration Date]";
    this.Label11.AutoSize = true;
    this.Label11.BackColor = Color.Transparent;
    this.Label11.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label11.Location = new Point(107, 269);
    this.Label11.Name = "Label11";
    this.Label11.Size = new Size(97, 13);
    this.Label11.TabIndex = 63 /*0x3F*/;
    this.Label11.Text = "Expiration Date:";
    this.lblControlNumber.AutoSize = true;
    this.lblControlNumber.BackColor = Color.Transparent;
    this.lblControlNumber.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.lblControlNumber.Location = new Point(219, 65);
    this.lblControlNumber.Name = "lblControlNumber";
    this.lblControlNumber.Size = new Size(90, 13);
    this.lblControlNumber.TabIndex = 62;
    this.lblControlNumber.Text = "[Control Number]";
    this.lblControlNumber.UseMnemonic = false;
    this.Label23.AutoSize = true;
    this.Label23.BackColor = Color.Transparent;
    this.Label23.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label23.Location = new Point(219, 49);
    this.Label23.Name = "Label23";
    this.Label23.Size = new Size(134, 13);
    this.Label23.TabIndex = 61;
    this.Label23.Text = "Policy Control Number:";
    this.lblUnderwriter.AutoSize = true;
    this.lblUnderwriter.BackColor = Color.Transparent;
    this.lblUnderwriter.Location = new Point(219, 25);
    this.lblUnderwriter.Name = "lblUnderwriter";
    this.lblUnderwriter.Size = new Size(72, 13);
    this.lblUnderwriter.TabIndex = 60;
    this.lblUnderwriter.Text = "[Underwriter]";
    this.lblUnderwriter.UseMnemonic = false;
    this.Label22.AutoSize = true;
    this.Label22.BackColor = Color.Transparent;
    this.Label22.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label22.Location = new Point(219, 9);
    this.Label22.Name = "Label22";
    this.Label22.Size = new Size(78, 13);
    this.Label22.TabIndex = 59;
    this.Label22.Text = "Underwriter:";
    this.lblCompany.BackColor = Color.Transparent;
    this.lblCompany.Location = new Point(11, 439);
    this.lblCompany.Name = "lblCompany";
    this.lblCompany.Size = new Size(192 /*0xC0*/, 96 /*0x60*/);
    this.lblCompany.TabIndex = 58;
    this.lblCompany.Text = "[Company Name and Address]";
    this.lblCompany.UseMnemonic = false;
    this.lblProducer.BackColor = Color.Transparent;
    this.lblProducer.Location = new Point(11, 329);
    this.lblProducer.Name = "lblProducer";
    this.lblProducer.Size = new Size(192 /*0xC0*/, 89);
    this.lblProducer.TabIndex = 57;
    this.lblProducer.Text = "[Producer Name and Address]";
    this.lblProducer.UseMnemonic = false;
    this.lblEffectiveDate.AutoSize = true;
    this.lblEffectiveDate.BackColor = Color.Transparent;
    this.lblEffectiveDate.Location = new Point(11, 285);
    this.lblEffectiveDate.Name = "lblEffectiveDate";
    this.lblEffectiveDate.Size = new Size(84, 13);
    this.lblEffectiveDate.TabIndex = 56;
    this.lblEffectiveDate.Text = "[Effective Date]";
    this.lblInsured.BackColor = Color.Transparent;
    this.lblInsured.Location = new Point(11, 181);
    this.lblInsured.Name = "lblInsured";
    this.lblInsured.Size = new Size(192 /*0xC0*/, 84);
    this.lblInsured.TabIndex = 55;
    this.lblInsured.Text = "[Insured Name and Address]";
    this.lblInsured.UseMnemonic = false;
    this.lblPolicyNumber.AutoSize = true;
    this.lblPolicyNumber.BackColor = Color.Transparent;
    this.lblPolicyNumber.Location = new Point(11, 25);
    this.lblPolicyNumber.Name = "lblPolicyNumber";
    this.lblPolicyNumber.Size = new Size(82, 13);
    this.lblPolicyNumber.TabIndex = 54;
    this.lblPolicyNumber.Text = "[Policy Number]";
    this.lblPolicyNumber.UseMnemonic = false;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label13.Location = new Point(11, 165);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(162, 13);
    this.Label13.TabIndex = 53;
    this.Label13.Text = "Insured Name and Address:";
    this.Label12.AutoSize = true;
    this.Label12.BackColor = Color.Transparent;
    this.Label12.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label12.Location = new Point(11, 269);
    this.Label12.Name = "Label12";
    this.Label12.Size = new Size(89, 13);
    this.Label12.TabIndex = 52;
    this.Label12.Text = "Effective Date:";
    this.Label10.AutoSize = true;
    this.Label10.BackColor = Color.Transparent;
    this.Label10.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label10.Location = new Point(11, 313);
    this.Label10.Name = "Label10";
    this.Label10.Size = new Size(169, 13);
    this.Label10.TabIndex = 51;
    this.Label10.Text = "Producer Name and Address:";
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.Location = new Point(11, 423);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(171, 13);
    this.Label6.TabIndex = 50;
    this.Label6.Text = "Company Name and Address:";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.Location = new Point(11, 9);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(90, 13);
    this.Label3.TabIndex = 49;
    this.Label3.Text = "Policy Number:";
    this.panelCurtain.BorderColor = Color.White;
    this.panelCurtain.Controls.Add((Control) this.Label5);
    this.panelCurtain.Controls.Add((Control) this.Label4);
    this.panelCurtain.Controls.Add((Control) this.Label1);
    this.panelCurtain.CornerOffset = 20;
    this.panelCurtain.Dock = DockStyle.Fill;
    this.panelCurtain.Location = new Point(0, 45);
    this.panelCurtain.Name = "panelCurtain";
    this.panelCurtain.Size = new Size(1072, 593);
    this.panelCurtain.TabIndex = 5;
    this.Label5.Anchor = AnchorStyles.Bottom;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(420, 299);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(241, 13);
    this.Label5.TabIndex = 2;
    this.Label5.Text = "_______________________________________";
    this.Label4.Anchor = AnchorStyles.Top;
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(420, 200);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(241, 13);
    this.Label4.TabIndex = 1;
    this.Label4.Text = "_______________________________________";
    this.Label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.Label1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label1.Location = new Point(8, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(1056, 459);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Search for a policy using the 'Find Policy' button on the toolbar above.";
    this.Label1.TextAlign = ContentAlignment.MiddleCenter;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Left).Location = new Point(0, 45);
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Left).Name = "_panelPolicyInquiry2_Toolbars_Dock_Area_Left";
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Left).Size = new Size(0, 593);
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((UltraControlBase) this._panelPolicyInquiry2_Toolbars_Dock_Area_Left).UseAppStyling = false;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this.panelPolicyInquiry2;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool7).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool9).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool10).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) labelTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolPropsBase) ((ToolBase) labelTool1).InstanceProps).Width = 25;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[11]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) labelTool1
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 1;
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) ultraToolbar.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ultraToolbar.ShowInToolbarList = false;
    ultraToolbar.Text = "Policy Inquiry";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance304).Image = (object) Resources.SearchTransaction;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance304;
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).Caption = "Find Policy";
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance305).Image = (object) Resources.arrow_undo;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance305;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "Clear Screen";
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance306).Image = (object) Resources.picture_delete;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance306;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "Manual Cancellation";
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance307).Image = (object) Resources.cog_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance307;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Reinstate Policy";
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) popupMenuTool1).SharedPropsInternal).Caption = "InvoiceListingContext";
    ((ToolBase) popupMenuTool1).SharedPropsInternal.Category = "InvoiceListingContext";
    ((ToolsCollectionBase) popupMenuTool1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16
    });
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "View Invoice";
    ((ToolBase) buttonTool17).SharedPropsInternal.Category = "InvoiceListingContext";
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance308).BackColor = Color.White;
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance308;
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "InvoiceActivityContext";
    ((ToolBase) popupMenuTool2).SharedPropsInternal.Category = "InvoiceActivityContext";
    ((ToolBase) buttonTool19).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool21).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21
    });
    ((AppearanceBase) appearance309).BackColor = Color.White;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance309;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).Caption = "View Transaction Detail";
    ((ToolBase) buttonTool22).SharedPropsInternal.Category = "InvoiceActivityContext";
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) popupMenuTool3).SharedPropsInternal).Caption = "StatusGridContextMenu";
    ((ToolsCollectionBase) popupMenuTool3.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool23
    });
    ((AppearanceBase) appearance310).Image = (object) Resources.printer_add;
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance310;
    ((ToolPropsBase) ((ToolBase) buttonTool24).SharedPropsInternal).Caption = "Reprint Notice Of Cancellation";
    ((ToolPropsBase) ((ToolBase) popupMenuTool4).SharedPropsInternal).Caption = "CommentsMenu";
    ((ToolBase) buttonTool27).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool4.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool25,
      (ToolBase) buttonTool26,
      (ToolBase) buttonTool27
    });
    ((ToolPropsBase) ((ToolBase) buttonTool28).SharedPropsInternal).Caption = "Add Comment";
    ((ToolPropsBase) ((ToolBase) buttonTool29).SharedPropsInternal).Caption = "Edit Comment";
    ((ToolPropsBase) ((ToolBase) buttonTool30).SharedPropsInternal).Caption = "Delete Comment";
    ((AppearanceBase) appearance311).BackColor = Color.White;
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance311;
    ((ToolPropsBase) ((ToolBase) buttonTool31).SharedPropsInternal).Caption = "View Transaction Comments";
    ((AppearanceBase) appearance312).BackColor = Color.White;
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance312;
    ((ToolPropsBase) ((ToolBase) buttonTool32).SharedPropsInternal).Caption = "View Payment Summary";
    ((AppearanceBase) appearance313).Image = (object) Resources.arrow_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool33).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance313;
    ((ToolPropsBase) ((ToolBase) buttonTool33).SharedPropsInternal).Caption = "Refresh Screen";
    ((ToolPropsBase) ((ToolBase) buttonTool34).SharedPropsInternal).Caption = "Previous Policy";
    ((ToolBase) buttonTool34).SharedPropsInternal.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool35).SharedPropsInternal).Caption = "Next Policy";
    ((ToolBase) buttonTool35).SharedPropsInternal.Visible = false;
    ((AppearanceBase) appearance314).Image = (object) Resources.user;
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance314;
    ((ToolPropsBase) ((ToolBase) buttonTool36).SharedPropsInternal).Caption = "Show Invoice Payees";
    ((ToolBase) buttonTool36).SharedPropsInternal.Category = "InvoiceListingContext";
    ((AppearanceBase) appearance315).Image = (object) Resources.printer;
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance315;
    ((ToolPropsBase) ((ToolBase) buttonTool37).SharedPropsInternal).Caption = "Print";
    ((AppearanceBase) appearance316).Image = (object) Resources.error_go;
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance316;
    ((ToolPropsBase) ((ToolBase) buttonTool38).SharedPropsInternal).Caption = "Force Commission Recognition";
    ((AppearanceBase) appearance317).Image = (object) Resources.writeoffsettings;
    ((ToolPropsBase) ((ToolBase) buttonTool39).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance317;
    ((ToolPropsBase) ((ToolBase) buttonTool39).SharedPropsInternal).Caption = "Assign Finance Company";
    ((ToolsCollectionBase) this.UltraToolbarsManager1.Tools).AddRange(new ToolBase[24]
    {
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) popupMenuTool1,
      (ToolBase) buttonTool17,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool22,
      (ToolBase) popupMenuTool3,
      (ToolBase) buttonTool24,
      (ToolBase) popupMenuTool4,
      (ToolBase) buttonTool28,
      (ToolBase) buttonTool29,
      (ToolBase) buttonTool30,
      (ToolBase) buttonTool31,
      (ToolBase) buttonTool32,
      (ToolBase) buttonTool33,
      (ToolBase) buttonTool34,
      (ToolBase) buttonTool35,
      (ToolBase) buttonTool36,
      (ToolBase) buttonTool37,
      (ToolBase) buttonTool38,
      (ToolBase) buttonTool39,
      (ToolBase) labelTool2
    });
    ((UltraStylableComponent) this.UltraToolbarsManager1).UseAppStyling = false;
    ((UltraComponentControlManagerBase) this.UltraToolbarsManager1).UseOsThemes = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.UltraToolbarsManager1_BeforeToolDropdown);
    this.UltraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
    ((Control) this.ultraGrid5).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.ultraGrid5, "StatusGridContextMenu");
    ((UltraGridBase) this.ultraGrid5).DataMember = "PolicyStatusChanges";
    ((UltraGridBase) this.ultraGrid5).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance318).BackColor = Color.White;
    ((AppearanceBase) appearance318).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Appearance = (AppearanceBase) appearance318;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance319).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance319).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance319).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance319;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance320).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance320;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance321).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance321).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance321;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance322).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance322;
    ((AppearanceBase) appearance323).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance323;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance324).BackColor = Color.Transparent;
    ((AppearanceBase) appearance324).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance324;
    ((AppearanceBase) appearance325).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance325).BorderColor = Color.Silver;
    scrollBarLook14.ButtonAppearance = (AppearanceBase) appearance325;
    ((AppearanceBase) appearance326).BackColor = Color.White;
    scrollBarLook14.TrackAppearance = (AppearanceBase) appearance326;
    ((UltraGridBase) this.ultraGrid5).DisplayLayout.ScrollBarLook = scrollBarLook14;
    ((Control) this.ultraGrid5).Location = new Point(8, 24);
    ((Control) this.ultraGrid5).Name = "ultraGrid5";
    ((Control) this.ultraGrid5).Size = new Size(618, 0);
    ((Control) this.ultraGrid5).TabIndex = 0;
    ((UltraControlBase) this.ultraGrid5).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ultraGrid5).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraGrid6).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.UltraToolbarsManager1.SetContextMenuUltra((Component) this.ultraGrid6, "InvoiceListingContext");
    ((Control) this.ultraGrid6).Cursor = Cursors.Default;
    ((UltraGridBase) this.ultraGrid6).DataMember = "PolicyInvoices";
    ((UltraGridBase) this.ultraGrid6).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance327).BackColor = Color.White;
    ((AppearanceBase) appearance327).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Appearance = (AppearanceBase) appearance327;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance328).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance328).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance328).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance328;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance329).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance329;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance330).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance330).TextHAlignAsString = "Right";
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance330;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance331).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance331;
    ((AppearanceBase) appearance332).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance332;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance333).BackColor = Color.Transparent;
    ((AppearanceBase) appearance333).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance333;
    ((AppearanceBase) appearance334).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance334).BorderColor = Color.Silver;
    scrollBarLook15.ButtonAppearance = (AppearanceBase) appearance334;
    ((AppearanceBase) appearance335).BackColor = Color.White;
    scrollBarLook15.TrackAppearance = (AppearanceBase) appearance335;
    ((UltraGridBase) this.ultraGrid6).DisplayLayout.ScrollBarLook = scrollBarLook15;
    ((Control) this.ultraGrid6).Location = new Point(8, 24);
    ((Control) this.ultraGrid6).Name = "ultraGrid6";
    ((Control) this.ultraGrid6).Size = new Size(834, 143);
    ((Control) this.ultraGrid6).TabIndex = 19;
    ((UltraControlBase) this.ultraGrid6).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ultraGrid6).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Right).Location = new Point(1072, 45);
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Right).Name = "_panelPolicyInquiry2_Toolbars_Dock_Area_Right";
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Right).Size = new Size(0, 593);
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((UltraControlBase) this._panelPolicyInquiry2_Toolbars_Dock_Area_Right).UseAppStyling = false;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom).Location = new Point(0, 638);
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom).Name = "_panelPolicyInquiry2_Toolbars_Dock_Area_Bottom";
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom).Size = new Size(1072, 0);
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    ((UltraControlBase) this._panelPolicyInquiry2_Toolbars_Dock_Area_Bottom).UseAppStyling = false;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Top).Name = "_panelPolicyInquiry2_Toolbars_Dock_Area_Top";
    ((Control) this._panelPolicyInquiry2_Toolbars_Dock_Area_Top).Size = new Size(1072, 45);
    this._panelPolicyInquiry2_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((UltraControlBase) this._panelPolicyInquiry2_Toolbars_Dock_Area_Top).UseAppStyling = false;
    this.daPolicyInquiryInvoices.SelectCommand = this.SqlSelectCommand3;
    this.daPolicyInquiryInvoices.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_PolicyInquiryInvoices", new DataColumnMapping[7]
      {
        new DataColumnMapping("invoiceNum", "invoiceNum"),
        new DataColumnMapping("officeInvoiceNum", "officeInvoiceNum"),
        new DataColumnMapping("quoteId", "quoteId"),
        new DataColumnMapping("GrossBilled", "GrossBilled"),
        new DataColumnMapping("Commission", "Commission"),
        new DataColumnMapping("Premium", "Premium"),
        new DataColumnMapping("Fees", "Fees")
      })
    });
    this.SqlSelectCommand3.CommandText = "[spFin_PolicyInquiryInvoices]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.FormDataConnection;
    this.SqlSelectCommand3.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@controlno", SqlDbType.Int, 4)
    });
    this.daPolicyInquiryInvoiceDetails.SelectCommand = this.SqlSelectCommand5;
    this.daPolicyInquiryInvoiceDetails.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_PolicyInquiryInvoiceDetails", new DataColumnMapping[6]
      {
        new DataColumnMapping("duedate", "duedate"),
        new DataColumnMapping("effectivedate", "effectivedate"),
        new DataColumnMapping("expirationdate", "expirationdate"),
        new DataColumnMapping("EndorsementNumber", "EndorsementNumber"),
        new DataColumnMapping("BrokerCommission", "BrokerCommission"),
        new DataColumnMapping("GrossCommission", "GrossCommission")
      })
    });
    this.SqlSelectCommand5.CommandText = "[spFin_PolicyInquiryInvoiceDetails]";
    this.SqlSelectCommand5.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand5.Connection = this.FormDataConnection;
    this.SqlSelectCommand5.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@invoiceNum", SqlDbType.Int, 4)
    });
    this.daPolicyInquiryInvoiceActivity.SelectCommand = this.SqlSelectCommand4;
    this.daPolicyInquiryInvoiceActivity.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_PolicyInquiryInvoiceActivity", new DataColumnMapping[4]
      {
        new DataColumnMapping("transactNum", "transactNum"),
        new DataColumnMapping("transDescription", "transDescription"),
        new DataColumnMapping("postDate", "postDate"),
        new DataColumnMapping("User", "User")
      })
    });
    this.SqlSelectCommand4.CommandText = "[spFin_PolicyInquiryInvoiceActivity]";
    this.SqlSelectCommand4.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand4.Connection = this.FormDataConnection;
    this.SqlSelectCommand4.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@invoicenum", SqlDbType.Int, 4)
    });
    this.SqlSelectCommand8.CommandText = "[spFin_PolicyInquiryCancellationInformation]";
    this.SqlSelectCommand8.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand8.Connection = this.FormDataConnection;
    this.SqlSelectCommand8.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@controlno", SqlDbType.Int, 4)
    });
    this.daPolicyInquiryCancellationInformation.SelectCommand = this.SqlSelectCommand8;
    this.daPolicyInquiryCancellationInformation.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_PolicyInquiryCancellationInformation", new DataColumnMapping[5]
      {
        new DataColumnMapping("issuancedate", "issuancedate"),
        new DataColumnMapping("message", "message"),
        new DataColumnMapping("pastdueamt", "pastdueamt"),
        new DataColumnMapping("cancellationdate", "cancellationdate"),
        new DataColumnMapping("CancellationMessage", "CancellationMessage")
      })
    });
    this.SqlSelectCommand7.CommandText = "[spFin_PolicyInquiryInvoiceFeeLines]";
    this.SqlSelectCommand7.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand7.Connection = this.FormDataConnection;
    this.SqlSelectCommand7.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@invoiceNum", SqlDbType.Int, 4)
    });
    this.daPolicyInquiryInvoiceFeeLines.SelectCommand = this.SqlSelectCommand7;
    this.daPolicyInquiryInvoiceFeeLines.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_PolicyInquiryInvoiceFeeLines", new DataColumnMapping[2]
      {
        new DataColumnMapping("feeName", "feeName"),
        new DataColumnMapping("Amount", "Amount")
      })
    });
    this.daGetPolicyInquiryComments.SelectCommand = this.sqlSelectCommand9;
    this.daGetPolicyInquiryComments.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetPolicyInquiryComments", new DataColumnMapping[4]
      {
        new DataColumnMapping("commentId", "commentId"),
        new DataColumnMapping("CommentDate", "CommentDate"),
        new DataColumnMapping("UserName", "UserName"),
        new DataColumnMapping("Comment", "Comment")
      })
    });
    this.sqlSelectCommand9.CommandText = "[spFin_GetPolicyInquiryComments]";
    this.sqlSelectCommand9.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand9.Connection = this.FormDataConnection;
    this.sqlSelectCommand9.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@controlNumber", SqlDbType.Int, 4)
    });
    this.daPolicyInquiryReinstatementInformation.SelectCommand = this.sqlSelectCommand10;
    this.daPolicyInquiryReinstatementInformation.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_PolicyInquiryReinstatementInformation", new DataColumnMapping[2]
      {
        new DataColumnMapping("IssuedMessage", "IssuedMessage"),
        new DataColumnMapping("EffectiveMessage", "EffectiveMessage")
      })
    });
    this.sqlSelectCommand10.CommandText = "[spFin_PolicyInquiryReinstatementInformation]";
    this.sqlSelectCommand10.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand10.Connection = this.FormDataConnection;
    this.sqlSelectCommand10.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@quoteid", SqlDbType.Int, 4)
    });
    ((Control) this.ultraTabControl2).Controls.Add((Control) this.ultraTabSharedControlsPage3);
    ((Control) this.ultraTabControl2).Controls.Add((Control) this.ultraTabPageControl6);
    ((Control) this.ultraTabControl2).Location = new Point(0, 0);
    ((Control) this.ultraTabControl2).Name = "ultraTabControl2";
    ((UltraTabControlBase) this.ultraTabControl2).SharedControlsPage = this.ultraTabSharedControlsPage3;
    ((Control) this.ultraTabControl2).Size = new Size(200, 100);
    ((Control) this.ultraTabControl2).TabIndex = 0;
    ((Control) this.ultraTabSharedControlsPage3).Location = new Point(1, 20);
    ((Control) this.ultraTabSharedControlsPage3).Name = "ultraTabSharedControlsPage3";
    ((Control) this.ultraTabSharedControlsPage3).Size = new Size(196, 77);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.ellipsePanel2);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.ellipsePanel3);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.checkBox1);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label41);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label42);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label43);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label44);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label45);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label46);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label47);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label48);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label49);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label50);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label51);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label52);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label53);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label54);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label55);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label56);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label57);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label58);
    ((Control) this.ultraTabPageControl6).Controls.Add((Control) this.label59);
    ((Control) this.ultraTabPageControl6).Location = new Point(1, 22);
    ((Control) this.ultraTabPageControl6).Name = "ultraTabPageControl6";
    ((Control) this.ultraTabPageControl6).Size = new Size(854, 175);
    this.ellipsePanel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ellipsePanel2.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel2.Controls.Add((Control) this.ultraGrid3);
    this.ellipsePanel2.Controls.Add((Control) this.ultraGrid4);
    this.ellipsePanel2.Controls.Add((Control) this.label60);
    this.ellipsePanel2.CornerOffset = 20;
    this.ellipsePanel2.Location = new Point(208 /*0xD0*/, -162);
    this.ellipsePanel2.Name = "ellipsePanel2";
    this.ellipsePanel2.Size = new Size(642, 328);
    this.ellipsePanel2.TabIndex = 31 /*0x1F*/;
    ((Control) this.ultraGrid3).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ultraGrid3).DataMember = "ReinstatementInformation";
    ((UltraGridBase) this.ultraGrid3).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance336).BackColor = Color.White;
    ((AppearanceBase) appearance336).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Appearance = (AppearanceBase) appearance336;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance337).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance337).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance337).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance337;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance338).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance338;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance339).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance339;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance340).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance340;
    ((AppearanceBase) appearance341).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance341;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance342).BackColor = Color.Transparent;
    ((AppearanceBase) appearance342).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance342;
    ((AppearanceBase) appearance343).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance343).BorderColor = Color.Silver;
    scrollBarLook16.ButtonAppearance = (AppearanceBase) appearance343;
    ((AppearanceBase) appearance344).BackColor = Color.White;
    scrollBarLook16.TrackAppearance = (AppearanceBase) appearance344;
    ((UltraGridBase) this.ultraGrid3).DisplayLayout.ScrollBarLook = scrollBarLook16;
    ((Control) this.ultraGrid3).Location = new Point(8, 160 /*0xA0*/);
    ((Control) this.ultraGrid3).Name = "ultraGrid3";
    ((Control) this.ultraGrid3).Size = new Size(624, 160 /*0xA0*/);
    ((Control) this.ultraGrid3).TabIndex = 33;
    ((UltraControlBase) this.ultraGrid3).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ultraGrid3).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraGrid4).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ultraGrid4).DataMember = "CancellationInformation";
    ((UltraGridBase) this.ultraGrid4).DataSource = (object) this.dsPolicyInformation1;
    ((AppearanceBase) appearance345).BackColor = Color.White;
    ((AppearanceBase) appearance345).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Appearance = (AppearanceBase) appearance345;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance346).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance346).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance346).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance346;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance347).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance347;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance348).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance348;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance349).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance349;
    ((AppearanceBase) appearance350).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance350;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance351).BackColor = Color.Transparent;
    ((AppearanceBase) appearance351).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance351;
    ((AppearanceBase) appearance352).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance352).BorderColor = Color.Silver;
    scrollBarLook17.ButtonAppearance = (AppearanceBase) appearance352;
    ((AppearanceBase) appearance353).BackColor = Color.White;
    scrollBarLook17.TrackAppearance = (AppearanceBase) appearance353;
    ((UltraGridBase) this.ultraGrid4).DisplayLayout.ScrollBarLook = scrollBarLook17;
    ((Control) this.ultraGrid4).Location = new Point(8, 24);
    ((Control) this.ultraGrid4).Name = "ultraGrid4";
    ((Control) this.ultraGrid4).Size = new Size(624, 128 /*0x80*/);
    ((Control) this.ultraGrid4).TabIndex = 32 /*0x20*/;
    ((UltraControlBase) this.ultraGrid4).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ultraGrid4).UseOsThemes = (DefaultableBoolean) 2;
    this.label60.AutoSize = true;
    this.label60.BackColor = Color.Transparent;
    this.label60.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label60.ForeColor = Color.SteelBlue;
    this.label60.Location = new Point(8, 8);
    this.label60.Name = "label60";
    this.label60.Size = new Size(251, 13);
    this.label60.TabIndex = 17;
    this.label60.Text = "Cancellation / Re-Instatement Information";
    this.ellipsePanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ellipsePanel3.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel3.Controls.Add((Control) this.ultraGrid5);
    this.ellipsePanel3.Controls.Add((Control) this.label61);
    this.ellipsePanel3.CornerOffset = 20;
    this.ellipsePanel3.Location = new Point(208 /*0xD0*/, 88);
    this.ellipsePanel3.Name = "ellipsePanel3";
    this.ellipsePanel3.Size = new Size(634, 0);
    this.ellipsePanel3.TabIndex = 20;
    this.label61.AutoSize = true;
    this.label61.BackColor = Color.Transparent;
    this.label61.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label61.ForeColor = Color.SteelBlue;
    this.label61.Location = new Point(8, 8);
    this.label61.Name = "label61";
    this.label61.Size = new Size(131, 13);
    this.label61.TabIndex = 17;
    this.label61.Text = "Policy Status Changes";
    this.checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.checkBox1.BackColor = Color.Transparent;
    this.checkBox1.CheckAlign = ContentAlignment.MiddleRight;
    this.checkBox1.FlatStyle = FlatStyle.Flat;
    this.checkBox1.Location = new Point(704, 64 /*0x40*/);
    this.checkBox1.Name = "checkBox1";
    this.checkBox1.Size = new Size(128 /*0x80*/, 16 /*0x10*/);
    this.checkBox1.TabIndex = 15;
    this.checkBox1.Text = "Disable NOC Issuance";
    this.checkBox1.UseVisualStyleBackColor = false;
    this.label41.AutoSize = true;
    this.label41.BackColor = Color.Transparent;
    this.label41.Location = new Point(8, 72);
    this.label41.Name = "label41";
    this.label41.Size = new Size(80 /*0x50*/, 13);
    this.label41.TabIndex = 30;
    this.label41.Text = "[Current Status]";
    this.label41.UseMnemonic = false;
    this.label42.AutoSize = true;
    this.label42.BackColor = Color.Transparent;
    this.label42.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label42.Location = new Point(8, 56);
    this.label42.Name = "label42";
    this.label42.Size = new Size(93, 13);
    this.label42.TabIndex = 29;
    this.label42.Text = "Current Status:";
    this.label43.AutoSize = true;
    this.label43.BackColor = Color.Transparent;
    this.label43.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label43.Location = new Point(92, 248);
    this.label43.Name = "label43";
    this.label43.Size = new Size(12, 13);
    this.label43.TabIndex = 28;
    this.label43.Text = "-";
    this.label44.AutoSize = true;
    this.label44.BackColor = Color.Transparent;
    this.label44.Location = new Point(104, 248);
    this.label44.Name = "label44";
    this.label44.Size = new Size(85, 13);
    this.label44.TabIndex = 27;
    this.label44.Text = "[Expiration Date]";
    this.label45.AutoSize = true;
    this.label45.BackColor = Color.Transparent;
    this.label45.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label45.Location = new Point(104, 232);
    this.label45.Name = "label45";
    this.label45.Size = new Size(97, 13);
    this.label45.TabIndex = 26;
    this.label45.Text = "Expiration Date:";
    this.label46.AutoSize = true;
    this.label46.BackColor = Color.Transparent;
    this.label46.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label46.Location = new Point(216, 64 /*0x40*/);
    this.label46.Name = "label46";
    this.label46.Size = new Size(90, 13);
    this.label46.TabIndex = 25;
    this.label46.Text = "[Control Number]";
    this.label46.UseMnemonic = false;
    this.label47.AutoSize = true;
    this.label47.BackColor = Color.Transparent;
    this.label47.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label47.Location = new Point(216, 48 /*0x30*/);
    this.label47.Name = "label47";
    this.label47.Size = new Size(134, 13);
    this.label47.TabIndex = 24;
    this.label47.Text = "Policy Control Number:";
    this.label48.AutoSize = true;
    this.label48.BackColor = Color.Transparent;
    this.label48.Location = new Point(216, 24);
    this.label48.Name = "label48";
    this.label48.Size = new Size(67, 13);
    this.label48.TabIndex = 23;
    this.label48.Text = "[Underwriter]";
    this.label48.UseMnemonic = false;
    this.label49.AutoSize = true;
    this.label49.BackColor = Color.Transparent;
    this.label49.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label49.Location = new Point(216, 8);
    this.label49.Name = "label49";
    this.label49.Size = new Size(78, 13);
    this.label49.TabIndex = 22;
    this.label49.Text = "Underwriter:";
    this.label50.BackColor = Color.Transparent;
    this.label50.Location = new Point(8, 424);
    this.label50.Name = "label50";
    this.label50.Size = new Size(192 /*0xC0*/, 112 /*0x70*/);
    this.label50.TabIndex = 21;
    this.label50.Text = "[Company Name and Address]";
    this.label50.UseMnemonic = false;
    this.label51.BackColor = Color.Transparent;
    this.label51.Location = new Point(8, 296);
    this.label51.Name = "label51";
    this.label51.Size = new Size(192 /*0xC0*/, 104);
    this.label51.TabIndex = 20;
    this.label51.Text = "[Producer Name and Address]";
    this.label51.UseMnemonic = false;
    this.label52.AutoSize = true;
    this.label52.BackColor = Color.Transparent;
    this.label52.Location = new Point(8, 248);
    this.label52.Name = "label52";
    this.label52.Size = new Size(81, 13);
    this.label52.TabIndex = 19;
    this.label52.Text = "[Effective Date]";
    this.label53.BackColor = Color.Transparent;
    this.label53.Location = new Point(8, 136);
    this.label53.Name = "label53";
    this.label53.Size = new Size(192 /*0xC0*/, 88);
    this.label53.TabIndex = 18;
    this.label53.Text = "[Insured Name and Address]";
    this.label53.UseMnemonic = false;
    this.label54.AutoSize = true;
    this.label54.BackColor = Color.Transparent;
    this.label54.Location = new Point(8, 24);
    this.label54.Name = "label54";
    this.label54.Size = new Size(81, 13);
    this.label54.TabIndex = 17;
    this.label54.Text = "[Policy Number]";
    this.label54.UseMnemonic = false;
    this.label55.AutoSize = true;
    this.label55.BackColor = Color.Transparent;
    this.label55.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label55.Location = new Point(8, 120);
    this.label55.Name = "label55";
    this.label55.Size = new Size(162, 13);
    this.label55.TabIndex = 16 /*0x10*/;
    this.label55.Text = "Insured Name and Address:";
    this.label56.AutoSize = true;
    this.label56.BackColor = Color.Transparent;
    this.label56.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label56.Location = new Point(8, 232);
    this.label56.Name = "label56";
    this.label56.Size = new Size(89, 13);
    this.label56.TabIndex = 15;
    this.label56.Text = "Effective Date:";
    this.label57.AutoSize = true;
    this.label57.BackColor = Color.Transparent;
    this.label57.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label57.Location = new Point(8, 280);
    this.label57.Name = "label57";
    this.label57.Size = new Size(169, 13);
    this.label57.TabIndex = 14;
    this.label57.Text = "Producer Name and Address:";
    this.label58.AutoSize = true;
    this.label58.BackColor = Color.Transparent;
    this.label58.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label58.Location = new Point(8, 408);
    this.label58.Name = "label58";
    this.label58.Size = new Size(171, 13);
    this.label58.TabIndex = 13;
    this.label58.Text = "Company Name and Address:";
    this.label59.AutoSize = true;
    this.label59.BackColor = Color.Transparent;
    this.label59.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label59.Location = new Point(8, 8);
    this.label59.Name = "label59";
    this.label59.Size = new Size(90, 13);
    this.label59.TabIndex = 12;
    this.label59.Text = "Policy Number:";
    ((Control) this.ultraTabPageControl7).Controls.Add((Control) this.ellipsePanel4);
    ((Control) this.ultraTabPageControl7).Location = new Point(0, 0);
    ((Control) this.ultraTabPageControl7).Name = "ultraTabPageControl7";
    ((Control) this.ultraTabPageControl7).Size = new Size(196, 77);
    this.ellipsePanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ellipsePanel4.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel4.Controls.Add((Control) this.ultraGrid6);
    this.ellipsePanel4.Controls.Add((Control) this.label62);
    this.ellipsePanel4.CornerOffset = 20;
    this.ellipsePanel4.Location = new Point(208 /*0xD0*/, 8);
    this.ellipsePanel4.Name = "ellipsePanel4";
    this.ellipsePanel4.Size = new Size(852, 175);
    this.ellipsePanel4.TabIndex = 21;
    this.label62.AutoSize = true;
    this.label62.BackColor = Color.Transparent;
    this.label62.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.label62.ForeColor = Color.Black;
    this.label62.Location = new Point(8, 8);
    this.label62.Name = "label62";
    this.label62.Size = new Size(89, 13);
    this.label62.TabIndex = 18;
    this.label62.Text = "Invoice Listing";
    ((Control) this.ultraTabControl3).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance354).BackColor = Color.FromArgb(239, 247, 253);
    ((UltraTabControlBase) this.ultraTabControl3).Appearance = (AppearanceBase) appearance354;
    ((Control) this.ultraTabControl3).Location = new Point(0, 0);
    ((Control) this.ultraTabControl3).Name = "ultraTabControl3";
    ((UltraTabControlBase) this.ultraTabControl3).SharedControlsPage = this.ultraTabSharedControlsPage4;
    ((Control) this.ultraTabControl3).Size = new Size(200, 100);
    ((Control) this.ultraTabControl3).TabIndex = 0;
    ((Control) this.ultraTabSharedControlsPage4).Location = new Point(1, 20);
    ((Control) this.ultraTabSharedControlsPage4).Name = "ultraTabSharedControlsPage4";
    ((Control) this.ultraTabSharedControlsPage4).Size = new Size(196, 77);
    this.daPolicyInquiryPolicyActivity.SelectCommand = this.sqlCommand1;
    this.daPolicyInquiryPolicyActivity.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_PolicyInquiryInvoiceActivity", new DataColumnMapping[4]
      {
        new DataColumnMapping("transactNum", "transactNum"),
        new DataColumnMapping("transDescription", "transDescription"),
        new DataColumnMapping("postDate", "postDate"),
        new DataColumnMapping("User", "User")
      })
    });
    this.sqlCommand1.CommandText = "[spFin_PolicyInquiryPolicyActivity]";
    this.sqlCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlCommand1.Connection = this.FormDataConnection;
    this.sqlCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@controlNumber", SqlDbType.Int, 4)
    });
    this.ellipsePanel5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ellipsePanel5.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel5.BorderColor = Color.DarkSlateGray;
    this.ellipsePanel5.Controls.Add((Control) this.ellipsePanel6);
    this.ellipsePanel5.Controls.Add((Control) this.checkBox2);
    this.ellipsePanel5.Location = new Point(0, 0);
    this.ellipsePanel5.Name = "ellipsePanel5";
    this.ellipsePanel5.Size = new Size(200, 100);
    this.ellipsePanel5.TabIndex = 0;
    this.ellipsePanel6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ellipsePanel6.BackColor = Color.FromArgb(239, 247, 253);
    this.ellipsePanel6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ellipsePanel6.Controls.Add((Control) this.label63);
    this.ellipsePanel6.Controls.Add((Control) this.label64);
    this.ellipsePanel6.Controls.Add((Control) this.label65);
    this.ellipsePanel6.CornerOffset = 20;
    this.ellipsePanel6.Location = new Point(0, 0);
    this.ellipsePanel6.Name = "ellipsePanel6";
    this.ellipsePanel6.Size = new Size(856, 341);
    this.ellipsePanel6.TabIndex = 23;
    this.label63.Anchor = AnchorStyles.Top;
    this.label63.AutoSize = true;
    this.label63.Location = new Point(323, 64 /*0x40*/);
    this.label63.Name = "label63";
    this.label63.Size = new Size(241, 13);
    this.label63.TabIndex = 4;
    this.label63.Text = "_______________________________________";
    this.label64.Anchor = AnchorStyles.Top;
    this.label64.AutoSize = true;
    this.label64.Location = new Point(323, 144 /*0x90*/);
    this.label64.Name = "label64";
    this.label64.Size = new Size(241, 13);
    this.label64.TabIndex = 3;
    this.label64.Text = "_______________________________________";
    this.label65.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.label65.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.label65.ForeColor = Color.Black;
    this.label65.Location = new Point(16 /*0x10*/, 48 /*0x30*/);
    this.label65.Name = "label65";
    this.label65.Size = new Size(838, 152);
    this.label65.TabIndex = 1;
    this.label65.Text = "Click on an invoice line above to display the invoice activity.";
    this.label65.TextAlign = ContentAlignment.MiddleCenter;
    this.checkBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.checkBox2.BackColor = Color.FromArgb(239, 247, 253);
    this.checkBox2.FlatStyle = FlatStyle.Flat;
    this.checkBox2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.checkBox2.ForeColor = Color.SteelBlue;
    this.checkBox2.Location = new Point(758, 4);
    this.checkBox2.Name = "checkBox2";
    this.checkBox2.Size = new Size(86, 16 /*0x10*/);
    this.checkBox2.TabIndex = 24;
    this.checkBox2.Text = "Show Voids";
    this.checkBox2.UseVisualStyleBackColor = false;
    this.checkBox2.Visible = false;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(1072, 638);
    this.Controls.Add((Control) this.panelPolicyInquiry2);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (formPolicyInquiry);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Accounting - Policy Inquiry";
    this.Activated += new EventHandler(this.frmPolicyInquiry_Activated);
    this.Load += new EventHandler(this.formPolicyInquiry_Load);
    ((Control) this.UltraTabPageControl3).ResumeLayout(false);
    ((Control) this.UltraTabPageControl3).PerformLayout();
    this.panelChangeDueDate.ResumeLayout(false);
    ((ISupportInitialize) this.buttonCloseChangeDueDate).EndInit();
    ((ISupportInitialize) this.mgaGroupBox1).EndInit();
    ((Control) this.mgaGroupBox1).ResumeLayout(false);
    ((Control) this.mgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.buttonSaveDueDate).EndInit();
    ((ISupportInitialize) this.dateNewDueDate).EndInit();
    this.panelChangeTransactionDate.ResumeLayout(false);
    ((ISupportInitialize) this.buttonCloseChangeTransactionDate).EndInit();
    ((ISupportInitialize) this.mgaGroupBox3).EndInit();
    ((Control) this.mgaGroupBox3).ResumeLayout(false);
    ((Control) this.mgaGroupBox3).PerformLayout();
    ((ISupportInitialize) this.buttonSaveTransactionDate).EndInit();
    ((ISupportInitialize) this.dateTimeNewTransactionDate).EndInit();
    this.panelChangeBillDate.ResumeLayout(false);
    ((ISupportInitialize) this.buttonCloseChangeBillDate).EndInit();
    ((ISupportInitialize) this.mgaGroupBox2).EndInit();
    ((Control) this.mgaGroupBox2).ResumeLayout(false);
    ((Control) this.mgaGroupBox2).PerformLayout();
    ((ISupportInitialize) this.buttonSaveChangeBillDate).EndInit();
    ((ISupportInitialize) this.dateNewBillDate).EndInit();
    this.ElipsePanel3.ResumeLayout(false);
    this.ElipsePanel3.PerformLayout();
    ((ISupportInitialize) this.gridInvoiceFeeLines).EndInit();
    this.dsPolicyInformation1.EndInit();
    ((ISupportInitialize) this.gridInvoicePremiumLines).EndInit();
    ((Control) this.UltraTabPageControl4).ResumeLayout(false);
    ((ISupportInitialize) this.gridInvoiceActivity).EndInit();
    ((Control) this.ultraTabPageControl8).ResumeLayout(false);
    ((ISupportInitialize) this.gridInvoiceListing).EndInit();
    ((Control) this.ultraTabPageControl9).ResumeLayout(false);
    ((ISupportInitialize) this.gridPolicyActivity).EndInit();
    ((Control) this.UltraTabPageControl1).ResumeLayout(false);
    this.ellipsePanel1.ResumeLayout(false);
    this.ellipsePanel1.PerformLayout();
    ((ISupportInitialize) this.ultraGrid2).EndInit();
    ((ISupportInitialize) this.UltraGrid1).EndInit();
    this.ElipsePanel1.ResumeLayout(false);
    this.ElipsePanel1.PerformLayout();
    ((ISupportInitialize) this.gridStatusChanges).EndInit();
    ((Control) this.UltraTabPageControl2).ResumeLayout(false);
    this.panelInvoiceActivity.ResumeLayout(false);
    ((ISupportInitialize) this.utcInvoiceActivity).EndInit();
    ((Control) this.utcInvoiceActivity).ResumeLayout(false);
    this.panelInvoiceActivityCurtain.ResumeLayout(false);
    this.panelInvoiceActivityCurtain.PerformLayout();
    this.ElipsePanel2.ResumeLayout(false);
    ((ISupportInitialize) this.ultraTabControl4).EndInit();
    ((Control) this.ultraTabControl4).ResumeLayout(false);
    ((Control) this.UltraTabPageControl5).ResumeLayout(false);
    ((ISupportInitialize) this.gridPolicyInquiryComments).EndInit();
    this.panelPolicyInquiry2.ResumeLayout(false);
    ((ISupportInitialize) this.UltraTabControl1).EndInit();
    ((Control) this.UltraTabControl1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).ResumeLayout(false);
    ((Control) this.UltraTabSharedControlsPage1).PerformLayout();
    this.panelCurtain.ResumeLayout(false);
    this.panelCurtain.PerformLayout();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.ultraGrid5).EndInit();
    ((ISupportInitialize) this.ultraGrid6).EndInit();
    ((ISupportInitialize) this.ultraTabControl2).EndInit();
    ((Control) this.ultraTabControl2).ResumeLayout(false);
    ((Control) this.ultraTabPageControl6).ResumeLayout(false);
    ((Control) this.ultraTabPageControl6).PerformLayout();
    this.ellipsePanel2.ResumeLayout(false);
    this.ellipsePanel2.PerformLayout();
    ((ISupportInitialize) this.ultraGrid3).EndInit();
    ((ISupportInitialize) this.ultraGrid4).EndInit();
    this.ellipsePanel3.ResumeLayout(false);
    this.ellipsePanel3.PerformLayout();
    ((Control) this.ultraTabPageControl7).ResumeLayout(false);
    this.ellipsePanel4.ResumeLayout(false);
    this.ellipsePanel4.PerformLayout();
    ((ISupportInitialize) this.ultraTabControl3).EndInit();
    this.ellipsePanel5.ResumeLayout(false);
    this.ellipsePanel6.ResumeLayout(false);
    this.ellipsePanel6.PerformLayout();
    this.ResumeLayout(false);
  }
}
