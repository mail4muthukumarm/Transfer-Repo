// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.formInvoiceLedgerEntryWizard
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinTabControl;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

[SecureResource("{840AB406-22A8-41a2-B7E6-71AF171E2C75}", "Invoice Correction Utility Rights", "Determines whether a user has rights to modify invoice transactions using the correction wizard.")]
public class formInvoiceLedgerEntryWizard : Form
{
  private JournalEntry _journalEntry;
  private IContainer components;
  private dsOfficeLocations dsOfficeLocations1;
  internal MGASimpleComboBox comboType;
  private UltraLabel ultraLabel5;
  private UltraLabel ultraLabel3;
  private UltraLabel ultraLabel1;
  private UltraLabel ultraLabel6;
  internal MGASimpleComboBox comboOfficeLocation;
  private UltraLabel ultraLabel4;
  private MGAButton btnCancelChanges;
  private UltraLabel lblSideBar;
  private Panel pnlSummary;
  internal MGADateTimePicker dateTimePostDate;
  private Label label5;
  private Label label4;
  private Label label3;
  private MGATextBox textTransactionComments;
  private Label label6;
  private UltraLabel ultraLabel8;
  private UltraDataSource comboSource;
  private SqlDataAdapter daGetOfficeLocations;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection FormDataConnection;
  internal MGAButton buttonFinish;
  private UltraDataSource dataSource;
  private MGAButton buttonBack;
  private UltraGrid grid;
  private UltraToolbarsManager toolManager;
  private Panel pnlBottom;
  private MGAButton buttonNext;
  private MGAButton buttonCancel;
  private Panel pnlContainer;
  private Panel pnlContainerSide;
  private MGATextBox textInvoiceNumber;
  private UltraLabel ultraLabel9;
  private UltraLabel ultraLabel7;
  private ExtendedTreeViewDropDown dropTreeGLAccounts;
  private MGAButton btnAdd;
  private MGATextBox textAmount;
  private MGATextBox txtComments;
  private Panel panelTop;
  private Label lblLine;
  private Label label1;
  private PictureBox pictureBox1;
  private UltraToolbarsDockArea _formLedgerEntryWizard_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formLedgerEntryWizard_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formLedgerEntryWizard_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formLedgerEntryWizard_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom;
  internal MGASimpleComboBox comboCompanyLineGuid;
  internal MGASimpleComboBox comboChargeCode;
  private UltraLabel ultraLabel11;
  private UltraLabel ultraLabel10;
  private UltraLabel ultraLabel2;
  private UltraTabControl ultraTabControl1;
  private UltraTabSharedControlsPage ultraTabSharedControlsPage1;
  private UltraTabPageControl ultraTabPageControl1;
  private UltraTabPageControl ultraTabPageControl2;
  private MGAButton buttonSearchInvoice;
  private Label labelPolicyNumber;
  private Label labelInsuredName;
  private Label labelInvoiceNumber;
  private Label label8;
  private Label label7;
  private Label label2;
  private MGAGroupBox groupAccounts;
  private UltraGrid gridInvoiceAccounts;
  private dsInvoiceledgerEntry_InvoiceInformation dsLedger1;
  private MGAButton buttonClearInvoice;
  private UltraLabel labelDebitsTotal;
  private UltraLabel labelCreditsTotal;
  private Label label9;
  private MGASimpleComboBox comboTransactionType;
  private Label label10;

  public formInvoiceLedgerEntryWizard()
  {
    this.InitializeComponent();
    this.InitializeForm();
  }

  private void InitializeForm()
  {
    this.BindTypesCombo();
    this.BindTransactionTypesCombo();
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
  }

  private void buttonSearchInvoice_Click(object sender, EventArgs e)
  {
    if (!int.TryParse(((Control) this.textInvoiceNumber).Text, out int _))
    {
      int num = (int) MessageBox.Show("You must specify a valid invoice number to continue!", "Invalid Invoice Number!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (!this.GetInvoiceInformation(int.Parse(((Control) this.textInvoiceNumber).Text)))
        return;
      this.DisplayInvoiceInformation();
    }
  }

  private bool GetInvoiceInformation(int invoiceNumber)
  {
    this.dsLedger1.Clear();
    Database.Instance.QuerySP.PerformTableQuery("dbo.spFin_InvoiceLedgerEntry_InvoiceHeader", (DataTable) this.dsLedger1.InvoiceHeader, (object) "@officeinvoicenum", (object) invoiceNumber, (object) "@glcompanyid", (object) int.Parse(this.comboOfficeLocation.Value.ToString()));
    if (this.dsLedger1.InvoiceHeader.Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("The specified invoice could not be found, please verify the invoice number and try again.", "Invoice Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      return false;
    }
    Database.Instance.QuerySP.PerformTableQuery("dbo.spFin_InvoiceLedgerEntry_InvoiceAccounts", (DataTable) this.dsLedger1.InvoiceAccounts, (object) "@officeinvoicenum", (object) invoiceNumber, (object) "@glcompanyid", (object) int.Parse(this.comboOfficeLocation.Value.ToString()));
    Database.Instance.QuerySP.PerformTableQuery("dbo.spFin_InvoiceLedgerEntry_ChargeCodes", (DataTable) this.dsLedger1.ChargeCodes, (object) "@officeinvoicenum", (object) invoiceNumber, (object) "@glcompanyid", (object) int.Parse(this.comboOfficeLocation.Value.ToString()));
    return true;
  }

  private void DisplayInvoiceInformation()
  {
    ((UltraGridBase) this.comboChargeCode).DataSource = (object) this.dsLedger1.ChargeCodes;
    ((UltraDropDownBase) this.comboChargeCode).ValueMember = "ChargeCode";
    ((UltraDropDownBase) this.comboChargeCode).DisplayMember = "Description";
    this.labelInvoiceNumber.Text = this.dsLedger1.InvoiceHeader[0].OfficeInvoiceNum.ToString();
    this.labelInsuredName.Text = this.dsLedger1.InvoiceHeader[0].InsuredName;
    this.labelPolicyNumber.Text = this.dsLedger1.InvoiceHeader[0].PolicyNumber;
  }

  private void comboChargeCode_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (e.Row == null)
      return;
    this.dsLedger1.CompanyLines.Clear();
    Database.Instance.QuerySP.PerformTableQuery("dbo.spFin_InvoiceLedgerEntry_CompanyLines", (DataTable) this.dsLedger1.CompanyLines, (object) "@officeinvoicenum", (object) this.dsLedger1.InvoiceHeader[0].OfficeInvoiceNum, (object) "@glcompanyid", (object) int.Parse(this.comboOfficeLocation.Value.ToString()), (object) "@chargecode", (object) int.Parse(e.Row.Cells["chargecode"].Value.ToString()));
    ((UltraGridBase) this.comboCompanyLineGuid).DataSource = (object) this.dsLedger1.CompanyLines;
    ((UltraDropDownBase) this.comboCompanyLineGuid).ValueMember = "CompanyLineGuid";
    ((UltraDropDownBase) this.comboCompanyLineGuid).DisplayMember = "LineName";
  }

  private void btnAdd_Click(object sender, EventArgs e)
  {
    if (!this.VerifyEntry())
      return;
    this.AddRow();
    this.ClearEntry(true);
  }

  private bool VerifyEntry()
  {
    if (this.dsLedger1.InvoiceHeader.Count == 0)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("INVOICELEDGER_INVOICEREQUIRED"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("RequiredFieldMissingMessageBoxCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.comboChargeCode.Value == null)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("INVOICELEDGER_CHARGECODEREQUIRED"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("RequiredFieldMissingMessageBoxCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.comboCompanyLineGuid.Value == null)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("INVOICELEDGER_COMPANYLINEREQUIRED"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("RequiredFieldMissingMessageBoxCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textAmount).Text.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("INVOICELEDGER_AMOUNTREQUIRED"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("RequiredFieldMissingMessageBoxCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!Decimal.TryParse(((Control) this.textAmount).Text, NumberStyles.Any, (IFormatProvider) null, out Decimal _))
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("INVOICELEDGER_AMOUNTINVALID"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("InvalidEntryMessageBoxCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.comboType.Value != null)
      return true;
    int num1 = (int) MessageBox.Show(MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("INVOICELEDGER_ENTRYTYPEREQURIED"), MGASystems.IMS.Accounting.GeneralLedger.StringResourceManager.GetString("RequiredFieldMissingMessageBoxCaption"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.dropTreeGLAccounts.LoadGLAccounts(int.Parse(this.comboOfficeLocation.Value.ToString()));
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("All changes will be lost, are you sure you wish to cancel?", "Cancel Invoice Ledger Entry Wizard?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void AddRow()
  {
    UltraGridRow ultraGridRow = ((UltraGridBase) this.grid).DisplayLayout.Bands[0].AddNew();
    ultraGridRow.Cells["Type"].Value = (object) this.comboType.Value.ToString();
    ultraGridRow.Cells["GLAccountName"].Value = (object) this.dropTreeGLAccounts.GLAccountShortName;
    ultraGridRow.Cells["GLAccountID"].Value = (object) this.dropTreeGLAccounts.GLAccountID;
    ultraGridRow.Cells["Amount"].Value = (object) Decimal.Parse(((Control) this.textAmount).Text, NumberStyles.Any);
    ultraGridRow.Cells["InvoiceNum"].Value = (object) this.dsLedger1.InvoiceHeader[0].InvoiceNum;
    ultraGridRow.Cells["OfficeInvoiceNum"].Value = (object) this.dsLedger1.InvoiceHeader[0].OfficeInvoiceNum;
    ultraGridRow.Cells["ChargeCode"].Value = (object) int.Parse(this.comboChargeCode.Value.ToString());
    ultraGridRow.Cells["CompanyLineGuid"].Value = this.comboCompanyLineGuid.Value;
    ultraGridRow.Cells["CompanyLine"].Value = (object) ((UltraDropDownBase) this.comboCompanyLineGuid).SelectedRow.Cells["LineName"].Value.ToString();
    ultraGridRow.Cells["ChargeDescription"].Value = (object) ((UltraDropDownBase) this.comboChargeCode).SelectedRow.Cells["Description"].Value.ToString();
    ultraGridRow.Update();
  }

  private void BindTypesCombo()
  {
    DataSet dataSet = new DataSet();
    DataTable table = new DataTable("TypesList");
    table.Columns.AddRange(new DataColumn[2]
    {
      new DataColumn("TypeId", typeof (string)),
      new DataColumn("TypeName", typeof (string))
    });
    DataRow row1 = table.NewRow();
    row1[0] = (object) "Debit";
    row1[1] = (object) "Debit";
    table.Rows.Add(row1);
    DataRow row2 = table.NewRow();
    row2[0] = (object) "Credit";
    row2[1] = (object) "Credit";
    table.Rows.Add(row2);
    dataSet.Tables.Add(table);
    ((UltraGridBase) this.comboType).DataSource = (object) dataSet;
    ((UltraDropDownBase) this.comboType).DisplayMember = "TypeName";
    ((UltraDropDownBase) this.comboType).ValueMember = "TypeId";
  }

  private void buttonClearInvoice_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show("This will clear all entries added, this action can not be undone. Are you sure you wish to continue?", "Clear Invoice Transactions?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.ClearInvoice();
  }

  private void ClearInvoice()
  {
    this.dsLedger1.Clear();
    this.dataSource.Rows.Clear();
    ((Control) this.textInvoiceNumber).Enabled = true;
    ((Control) this.buttonSearchInvoice).Enabled = true;
    ((UltraTabControlBase) this.ultraTabControl1).Tabs[1].Visible = false;
    ((Control) this.textInvoiceNumber).Text = string.Empty;
    this.ClearEntry(false);
  }

  private void ClearEntry(bool allowNewEntry)
  {
    ((Control) this.textAmount).Text = string.Empty;
    ((Control) this.comboChargeCode).ResetText();
    ((UltraGridBase) this.comboCompanyLineGuid).DataSource = (object) null;
    ((Control) this.textTransactionComments).Text = string.Empty;
    this.dropTreeGLAccounts.ResetText();
    ((Control) this.comboType).ResetText();
    ((Control) this.textInvoiceNumber).Enabled = !allowNewEntry;
    ((Control) this.buttonSearchInvoice).Enabled = !allowNewEntry;
  }

  private void buttonNext_Click(object sender, EventArgs e)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      if (!this.ValidateForm(1))
        return;
      this.CreateLedgerTransaction();
      this.GenerateSummary();
      this.pnlSummary.BringToFront();
      ((Control) this.buttonNext).Enabled = false;
      ((Control) this.buttonBack).Enabled = true;
      ((Control) this.buttonFinish).Enabled = this._journalEntry.CreditsCol.Total() == this._journalEntry.DebitsCol.Total();
      this.ToggleEntryControlsEnabled(false);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void buttonBack_Click(object sender, EventArgs e)
  {
    this.pnlContainer.BringToFront();
    ((Control) this.buttonBack).Enabled = false;
    ((Control) this.buttonNext).Enabled = true;
    ((Control) this.buttonFinish).Enabled = false;
    this.ToggleEntryControlsEnabled(true);
  }

  private void buttonFinish_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm(2))
      return;
    this._journalEntry.TransactionDescriptionId = this.comboTransactionType.Value.ToString();
    this._journalEntry.PostDate = this.dateTimePostDate.DateTime;
    this.Save();
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void CreateLedgerTransaction()
  {
    this.CreateTransactionHeader();
    this.CreateTransactionDetails();
  }

  private void CreateTransactionHeader()
  {
    this._journalEntry = new JournalEntry();
    this._journalEntry.PostDate = this.dateTimePostDate.DateTime;
    this._journalEntry.IsYearEnd = false;
    this._journalEntry.GlCompanyId = int.Parse(this.comboOfficeLocation.Value.ToString());
    this._journalEntry.Comments = ((Control) this.textTransactionComments).Text;
    this._journalEntry.JournalEntryType = SharedMembers.JournalEntryType.InvoiceLedgerEntry;
  }

  private void CreateTransactionDetails()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.grid).Rows)
    {
      int ledgerAccount = int.Parse(row.Cells["GLAccountID"].Value.ToString());
      int invoiceNumber = int.Parse(row.Cells["invoicenum"].Value.ToString());
      Decimal amount = Decimal.Parse(row.Cells["Amount"].Value.ToString());
      Guid companyLineGuid = new Guid(row.Cells["companylineguid"].Value.ToString());
      int chargeCode = int.Parse(row.Cells["chargecode"].Value.ToString());
      LedgerEntry ledgerEntry = new LedgerEntry(ledgerAccount, amount, invoiceNumber, chargeCode, companyLineGuid);
      if (row.Cells["type"].Value.ToString().ToUpper() == "DEBIT")
        this._journalEntry.DebitsCol.Add(ledgerEntry);
      else
        this._journalEntry.CreditsCol.Add(ledgerEntry);
    }
  }

  private void GenerateSummary()
  {
    ((Control) this.labelDebitsTotal).Text = this._journalEntry.DebitsCol.Total().ToString("c");
    ((Control) this.labelCreditsTotal).Text = this._journalEntry.CreditsCol.Total().ToString("c");
  }

  private void textAmount_Leave(object sender, EventArgs e)
  {
    Decimal result;
    if (((Control) this.textAmount).Text.Equals(string.Empty) || !Decimal.TryParse(((Control) this.textAmount).Text, NumberStyles.Any, (IFormatProvider) null, out result))
      return;
    ((Control) this.textAmount).Text = result.ToString("c");
  }

  private void Save() => this._journalEntry.Save();

  private void BindTransactionTypesCombo()
  {
    ((UltraGridBase) this.comboTransactionType).DataSource = (object) Methods.AccountingTransactionTypes();
    ((UltraDropDownBase) this.comboTransactionType).DisplayMember = "TransactionType";
    ((UltraDropDownBase) this.comboTransactionType).ValueMember = "TransactionTypeId";
  }

  private bool ValidateForm(int step)
  {
    if (step == 1)
    {
      if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
      {
        int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (this.dsLedger1.InvoiceHeader.Rows.Count == 0 || this.dsLedger1.InvoiceAccounts.Rows.Count == 0)
      {
        int num = (int) MessageBox.Show("You must specify an invoice to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.grid).Rows).Count == 0)
      {
        int num = (int) MessageBox.Show("You have not entered any debits or credits.", "Required Entry Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    else if (((UltraDropDownBase) this.comboTransactionType).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a transaction type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    return true;
  }

  private void ToggleEntryControlsEnabled(bool state)
  {
    ((Control) this.comboOfficeLocation).Enabled = state;
    ((Control) this.comboCompanyLineGuid).Enabled = state;
    ((Control) this.comboChargeCode).Enabled = state;
    this.dropTreeGLAccounts.Enabled = state;
    ((Control) this.txtComments).Enabled = state;
    ((Control) this.textAmount).Enabled = state;
    ((Control) this.btnAdd).Enabled = state;
    ((Control) this.btnCancelChanges).Enabled = state;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("Band 0", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Type");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GlAccountName");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("GlAccountId");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Amount");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("InvoiceNum");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("OfficeInvoiceNum");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ChargeCode");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CompanyLine");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ChargeDescription");
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    UltraDataColumn ultraDataColumn1 = new UltraDataColumn("Type");
    UltraDataColumn ultraDataColumn2 = new UltraDataColumn("GlAccountName");
    UltraDataColumn ultraDataColumn3 = new UltraDataColumn("GlAccountId");
    UltraDataColumn ultraDataColumn4 = new UltraDataColumn("Amount");
    UltraDataColumn ultraDataColumn5 = new UltraDataColumn("Comments");
    UltraDataColumn ultraDataColumn6 = new UltraDataColumn("InvoiceNum");
    UltraDataColumn ultraDataColumn7 = new UltraDataColumn("OfficeInvoiceNum");
    UltraDataColumn ultraDataColumn8 = new UltraDataColumn("ChargeCode");
    UltraDataColumn ultraDataColumn9 = new UltraDataColumn("CompanyLineGuid");
    UltraDataColumn ultraDataColumn10 = new UltraDataColumn("CompanyLine");
    UltraDataColumn ultraDataColumn11 = new UltraDataColumn("ChargeDescription");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("InvoiceAccounts", -1);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("GlAcctId");
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ShortName");
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("FullName");
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("AccountTypeDescription");
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Amount");
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    UltraDataColumn ultraDataColumn12 = new UltraDataColumn("Key");
    UltraDataColumn ultraDataColumn13 = new UltraDataColumn("Value");
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    PopupMenuTool popupMenuTool = new PopupMenuTool("ContextMenu");
    ButtonTool buttonTool1 = new ButtonTool("Edit");
    ButtonTool buttonTool2 = new ButtonTool("Delete");
    ButtonTool buttonTool3 = new ButtonTool("Edit");
    Appearance appearance57 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("Delete");
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    UltraTab ultraTab1 = new UltraTab();
    UltraTab ultraTab2 = new UltraTab();
    Appearance appearance64 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formInvoiceLedgerEntryWizard));
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    this.ultraTabPageControl2 = new UltraTabPageControl();
    this.grid = new UltraGrid();
    this.dataSource = new UltraDataSource(this.components);
    this.ultraTabPageControl1 = new UltraTabPageControl();
    this.groupAccounts = new MGAGroupBox();
    this.gridInvoiceAccounts = new UltraGrid();
    this.dsLedger1 = new dsInvoiceledgerEntry_InvoiceInformation();
    this.labelPolicyNumber = new Label();
    this.labelInsuredName = new Label();
    this.labelInvoiceNumber = new Label();
    this.label8 = new Label();
    this.label7 = new Label();
    this.label2 = new Label();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    this.comboType = new MGASimpleComboBox();
    this.ultraLabel5 = new UltraLabel();
    this.ultraLabel3 = new UltraLabel();
    this.ultraLabel1 = new UltraLabel();
    this.ultraLabel6 = new UltraLabel();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.ultraLabel4 = new UltraLabel();
    this.btnCancelChanges = new MGAButton();
    this.lblSideBar = new UltraLabel();
    this.pnlSummary = new Panel();
    this.label10 = new Label();
    this.labelDebitsTotal = new UltraLabel();
    this.labelCreditsTotal = new UltraLabel();
    this.label9 = new Label();
    this.comboTransactionType = new MGASimpleComboBox();
    this.dateTimePostDate = new MGADateTimePicker();
    this.label5 = new Label();
    this.label4 = new Label();
    this.label3 = new Label();
    this.textTransactionComments = new MGATextBox();
    this.label6 = new Label();
    this.ultraLabel8 = new UltraLabel();
    this.comboSource = new UltraDataSource(this.components);
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.buttonFinish = new MGAButton();
    this.buttonBack = new MGAButton();
    this.buttonNext = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.pnlBottom = new Panel();
    this.buttonClearInvoice = new MGAButton();
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this.toolManager = new UltraToolbarsManager(this.components);
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.ultraLabel9 = new UltraLabel();
    this.ultraLabel7 = new UltraLabel();
    this.dropTreeGLAccounts = new ExtendedTreeViewDropDown();
    this.btnAdd = new MGAButton();
    this.textAmount = new MGATextBox();
    this.txtComments = new MGATextBox();
    this.pnlContainer = new Panel();
    this.ultraTabControl1 = new UltraTabControl();
    this.ultraTabSharedControlsPage1 = new UltraTabSharedControlsPage();
    this.pictureBox1 = new PictureBox();
    this.pnlContainerSide = new Panel();
    this.buttonSearchInvoice = new MGAButton();
    this.comboCompanyLineGuid = new MGASimpleComboBox();
    this.comboChargeCode = new MGASimpleComboBox();
    this.ultraLabel11 = new UltraLabel();
    this.ultraLabel10 = new UltraLabel();
    this.ultraLabel2 = new UltraLabel();
    this.textInvoiceNumber = new MGATextBox();
    this.lblLine = new Label();
    this.panelTop = new Panel();
    this.label1 = new Label();
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((Control) this.ultraTabPageControl2).SuspendLayout();
    ((ISupportInitialize) this.grid).BeginInit();
    ((ISupportInitialize) this.dataSource).BeginInit();
    ((Control) this.ultraTabPageControl1).SuspendLayout();
    ((ISupportInitialize) this.groupAccounts).BeginInit();
    ((Control) this.groupAccounts).SuspendLayout();
    ((ISupportInitialize) this.gridInvoiceAccounts).BeginInit();
    this.dsLedger1.BeginInit();
    this.dsOfficeLocations1.BeginInit();
    ((ISupportInitialize) this.comboType).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.btnCancelChanges).BeginInit();
    this.pnlSummary.SuspendLayout();
    ((ISupportInitialize) this.comboTransactionType).BeginInit();
    ((ISupportInitialize) this.dateTimePostDate).BeginInit();
    ((ISupportInitialize) this.textTransactionComments).BeginInit();
    ((ISupportInitialize) this.comboSource).BeginInit();
    ((ISupportInitialize) this.buttonFinish).BeginInit();
    ((ISupportInitialize) this.buttonBack).BeginInit();
    ((ISupportInitialize) this.buttonNext).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    this.pnlBottom.SuspendLayout();
    ((ISupportInitialize) this.buttonClearInvoice).BeginInit();
    ((ISupportInitialize) this.toolManager).BeginInit();
    ((ISupportInitialize) this.btnAdd).BeginInit();
    ((ISupportInitialize) this.textAmount).BeginInit();
    ((ISupportInitialize) this.txtComments).BeginInit();
    this.pnlContainer.SuspendLayout();
    ((ISupportInitialize) this.ultraTabControl1).BeginInit();
    ((Control) this.ultraTabControl1).SuspendLayout();
    ((ISupportInitialize) this.pictureBox1).BeginInit();
    this.pnlContainerSide.SuspendLayout();
    ((ISupportInitialize) this.buttonSearchInvoice).BeginInit();
    ((ISupportInitialize) this.comboCompanyLineGuid).BeginInit();
    ((ISupportInitialize) this.comboChargeCode).BeginInit();
    ((ISupportInitialize) this.textInvoiceNumber).BeginInit();
    this.panelTop.SuspendLayout();
    this.SuspendLayout();
    ((Control) this.ultraTabPageControl2).Controls.Add((Control) this.grid);
    ((Control) this.ultraTabPageControl2).Location = new Point(1, 23);
    ((Control) this.ultraTabPageControl2).Name = "ultraTabPageControl2";
    ((Control) this.ultraTabPageControl2).Size = new Size(702, 353);
    this.toolManager.SetContextMenuUltra((Component) this.grid, "ContextMenu");
    ((UltraGridBase) this.grid).DataMember = "Band 0";
    ((UltraGridBase) this.grid).DataSource = (object) this.dataSource;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.grid).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.grid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 90;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "GL Account";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 106;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 3;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 95;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn4.Format = "C";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 10;
    ultraGridColumn4.Width = 94;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 2;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 70;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 4;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 45;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Invoice #";
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 5;
    ultraGridColumn7.Width = 72;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 6;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 64 /*0x40*/;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 7;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 64 /*0x40*/;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Company/Line";
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 8;
    ultraGridColumn10.Width = 196;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn11.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Charge Type";
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 9;
    ultraGridColumn11.Width = 142;
    ultraGridBand1.Columns.AddRange(new object[11]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ((UltraGridBase) this.grid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.grid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.grid).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.grid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.grid).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.grid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.grid).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BorderColor = Color.LightGray;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.grid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BackColor = Color.Transparent;
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.grid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance16).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.grid).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.grid).Dock = DockStyle.Fill;
    ((Control) this.grid).Font = new Font("Tahoma", 8f);
    ((Control) this.grid).Location = new Point(0, 0);
    ((Control) this.grid).Name = "grid";
    ((Control) this.grid).Size = new Size(702, 353);
    ((Control) this.grid).TabIndex = 0;
    ((UltraControlBase) this.grid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.grid).UseOsThemes = (DefaultableBoolean) 2;
    ultraDataColumn4.DataType = typeof (Decimal);
    ultraDataColumn6.DataType = typeof (int);
    ultraDataColumn7.DataType = typeof (int);
    ultraDataColumn8.DataType = typeof (int);
    ultraDataColumn9.DataType = typeof (Guid);
    this.dataSource.Band.Columns.AddRange(new object[11]
    {
      (object) ultraDataColumn1,
      (object) ultraDataColumn2,
      (object) ultraDataColumn3,
      (object) ultraDataColumn4,
      (object) ultraDataColumn5,
      (object) ultraDataColumn6,
      (object) ultraDataColumn7,
      (object) ultraDataColumn8,
      (object) ultraDataColumn9,
      (object) ultraDataColumn10,
      (object) ultraDataColumn11
    });
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.groupAccounts);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.labelPolicyNumber);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.labelInsuredName);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.labelInvoiceNumber);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.label8);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.label7);
    ((Control) this.ultraTabPageControl1).Controls.Add((Control) this.label2);
    ((Control) this.ultraTabPageControl1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabPageControl1).Name = "ultraTabPageControl1";
    ((Control) this.ultraTabPageControl1).Size = new Size(702, 353);
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupAccounts.ContentAreaAppearance = (AppearanceBase) appearance18;
    ((Control) this.groupAccounts).Controls.Add((Control) this.gridInvoiceAccounts);
    ((Control) this.groupAccounts).Dock = DockStyle.Bottom;
    ((AppearanceBase) appearance19).ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.groupAccounts.HeaderAppearance = (AppearanceBase) appearance19;
    ((Control) this.groupAccounts).Location = new Point(0, 96 /*0x60*/);
    ((Control) this.groupAccounts).Name = "groupAccounts";
    ((Control) this.groupAccounts).Size = new Size(702, 257);
    ((Control) this.groupAccounts).TabIndex = 6;
    ((Control) this.groupAccounts).Text = "Accounts / Transactions";
    this.groupAccounts.ViewStyle = (GroupBoxViewStyle) 2;
    ((UltraGridBase) this.gridInvoiceAccounts).DataMember = "InvoiceAccounts";
    ((UltraGridBase) this.gridInvoiceAccounts).DataSource = (object) this.dsLedger1;
    ((AppearanceBase) appearance20).BackColor = Color.White;
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Appearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ultraGridColumn12.CellAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn12.Header).Appearance = (AppearanceBase) appearance22;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 0;
    ultraGridColumn12.Width = 134;
    ((AppearanceBase) appearance23).TextHAlignAsString = "Left";
    ultraGridColumn13.CellAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn13.Header).Appearance = (AppearanceBase) appearance24;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Account Short Name";
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 1;
    ultraGridColumn13.Width = 130;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ultraGridColumn14.CellAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn14.Header).Appearance = (AppearanceBase) appearance26;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "GL Account";
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 2;
    ultraGridColumn14.Width = 128 /*0x80*/;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Left";
    ultraGridColumn15.CellAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn15.Header).Appearance = (AppearanceBase) appearance28;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 3;
    ultraGridColumn15.Width = 176 /*0xB0*/;
    ((AppearanceBase) appearance29).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance29;
    ultraGridColumn16.Format = "c";
    ((AppearanceBase) appearance30).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn16.Header).Appearance = (AppearanceBase) appearance30;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Account Balance";
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 4;
    ultraGridColumn16.Width = 128 /*0x80*/;
    ultraGridBand2.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance31).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance31).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance31).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance32).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance33).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance34).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance36).BackColor = Color.Transparent;
    ((AppearanceBase) appearance36).ForeColor = Color.Black;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance37).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.gridInvoiceAccounts).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.gridInvoiceAccounts).Dock = DockStyle.Fill;
    ((Control) this.gridInvoiceAccounts).Location = new Point(2, 19);
    ((Control) this.gridInvoiceAccounts).Name = "gridInvoiceAccounts";
    ((Control) this.gridInvoiceAccounts).Size = new Size(698, 236);
    ((Control) this.gridInvoiceAccounts).TabIndex = 0;
    ((UltraControlBase) this.gridInvoiceAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridInvoiceAccounts).UseOsThemes = (DefaultableBoolean) 2;
    this.dsLedger1.DataSetName = "dsInvoiceledgerEntry_InvoiceInformation";
    this.dsLedger1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.labelPolicyNumber.AutoSize = true;
    this.labelPolicyNumber.Location = new Point(115, 76);
    this.labelPolicyNumber.Name = "labelPolicyNumber";
    this.labelPolicyNumber.Size = new Size(95, 13);
    this.labelPolicyNumber.TabIndex = 5;
    this.labelPolicyNumber.Text = "[POLICY NUMBER]";
    this.labelInsuredName.AutoSize = true;
    this.labelInsuredName.Location = new Point(115, 51);
    this.labelInsuredName.Name = "labelInsuredName";
    this.labelInsuredName.Size = new Size(90, 13);
    this.labelInsuredName.TabIndex = 4;
    this.labelInsuredName.Text = "[INSURED NAME]";
    this.labelInvoiceNumber.AutoSize = true;
    this.labelInvoiceNumber.Location = new Point(115, 26);
    this.labelInvoiceNumber.Name = "labelInvoiceNumber";
    this.labelInvoiceNumber.Size = new Size(101, 13);
    this.labelInvoiceNumber.TabIndex = 3;
    this.labelInvoiceNumber.Text = "[INVOICE NUMBER]";
    this.label8.AutoSize = true;
    this.label8.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    this.label8.Location = new Point(10, 76);
    this.label8.Name = "label8";
    this.label8.Size = new Size(90, 13);
    this.label8.TabIndex = 2;
    this.label8.Text = "Policy Number:";
    this.label7.AutoSize = true;
    this.label7.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    this.label7.Location = new Point(10, 51);
    this.label7.Name = "label7";
    this.label7.Size = new Size(89, 13);
    this.label7.TabIndex = 1;
    this.label7.Text = "Insured Name:";
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    this.label2.Location = new Point(10, 26);
    this.label2.Name = "label2";
    this.label2.Size = new Size(99, 13);
    this.label2.TabIndex = 0;
    this.label2.Text = "Invoice Number:";
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.comboType.AutoSelectOnOneItem = true;
    this.comboType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboType.CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboType).DisplayMember = "Key";
    this.comboType.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboType).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.comboType).Location = new Point(100, 320);
    this.comboType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboType).Name = "comboType";
    ((Control) this.comboType).Size = new Size(212, 21);
    ((Control) this.comboType).TabIndex = 20;
    ((UltraControlBase) this.comboType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboType).ValueMember = "Value";
    ((AppearanceBase) appearance39).BackColor = Color.White;
    ((AppearanceBase) appearance39).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance39).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance39).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance39).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel5).Appearance = (AppearanceBase) appearance39;
    ((Control) this.ultraLabel5).AutoSize = true;
    ((ControlBase) this.ultraLabel5).BackColorInternal = Color.White;
    ((Control) this.ultraLabel5).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel5).ForeColor = Color.Black;
    ((Control) this.ultraLabel5).Location = new Point(4, 317);
    ((Control) this.ultraLabel5).Name = "ultraLabel5";
    ((Control) this.ultraLabel5).Size = new Size(35, 14);
    ((Control) this.ultraLabel5).TabIndex = 19;
    ((Control) this.ultraLabel5).Text = "Type :";
    ((AppearanceBase) appearance40).BackColor = Color.White;
    ((AppearanceBase) appearance40).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance40).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance40).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance40).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel3).Appearance = (AppearanceBase) appearance40;
    ((Control) this.ultraLabel3).AutoSize = true;
    ((ControlBase) this.ultraLabel3).BackColorInternal = Color.White;
    ((Control) this.ultraLabel3).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel3).ForeColor = Color.Black;
    ((Control) this.ultraLabel3).Location = new Point(4, 234);
    ((Control) this.ultraLabel3).Name = "ultraLabel3";
    ((Control) this.ultraLabel3).Size = new Size(63 /*0x3F*/, 14);
    ((Control) this.ultraLabel3).TabIndex = 15;
    ((Control) this.ultraLabel3).Text = "Comments : ";
    ((AppearanceBase) appearance41).BackColor = Color.White;
    ((AppearanceBase) appearance41).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance41).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance41).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance41).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance41;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((ControlBase) this.ultraLabel1).BackColorInternal = Color.White;
    ((Control) this.ultraLabel1).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel1).ForeColor = Color.Black;
    ((Control) this.ultraLabel1).Location = new Point(4, 97);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(83, 14);
    ((Control) this.ultraLabel1).TabIndex = 2;
    ((Control) this.ultraLabel1).Text = "Office Location : ";
    ((AppearanceBase) appearance42).BackColor = Color.White;
    ((AppearanceBase) appearance42).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance42).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance42).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance42).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel6).Appearance = (AppearanceBase) appearance42;
    ((Control) this.ultraLabel6).AutoSize = true;
    ((ControlBase) this.ultraLabel6).BackColorInternal = Color.White;
    ((Control) this.ultraLabel6).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel6).ForeColor = Color.Black;
    ((Control) this.ultraLabel6).Location = new Point(4, 297);
    ((Control) this.ultraLabel6).Name = "ultraLabel6";
    ((Control) this.ultraLabel6).Size = new Size(48 /*0x30*/, 14);
    ((Control) this.ultraLabel6).TabIndex = 17;
    ((Control) this.ultraLabel6).Text = "Amount :";
    this.comboOfficeLocation.AutoSelectOnOneItem = true;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboOfficeLocation).DataMember = "spFin_GetOfficeLocations";
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) this.dsOfficeLocations1;
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    this.comboOfficeLocation.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.comboOfficeLocation).Location = new Point(100, 99);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(212, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 3;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.comboOfficeLocation.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    ((AppearanceBase) appearance43).BackColor = Color.White;
    ((AppearanceBase) appearance43).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance43).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance43).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance43).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel4).Appearance = (AppearanceBase) appearance43;
    ((Control) this.ultraLabel4).AutoSize = true;
    ((ControlBase) this.ultraLabel4).BackColorInternal = Color.White;
    ((Control) this.ultraLabel4).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel4).ForeColor = Color.Black;
    ((Control) this.ultraLabel4).Location = new Point(4, 206);
    ((Control) this.ultraLabel4).Name = "ultraLabel4";
    ((Control) this.ultraLabel4).Size = new Size(64 /*0x40*/, 14);
    ((Control) this.ultraLabel4).TabIndex = 11;
    ((Control) this.ultraLabel4).Text = "Gl Account : ";
    ((AppearanceBase) appearance44).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance44).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance44).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance44).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnCancelChanges).Appearance = (AppearanceBase) appearance44;
    ((ControlBase) this.btnCancelChanges).BackColorInternal = Color.White;
    ((Control) this.btnCancelChanges).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnCancelChanges).ForeColor = Color.Black;
    ((Control) this.btnCancelChanges).Location = new Point(237, 347);
    ((Control) this.btnCancelChanges).Name = "btnCancelChanges";
    ((Control) this.btnCancelChanges).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnCancelChanges).TabIndex = 22;
    ((Control) this.btnCancelChanges).Text = "&Cancel";
    ((UltraControlBase) this.btnCancelChanges).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance45).BackColor = Color.White;
    ((AppearanceBase) appearance45).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance45).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance45).BackGradientStyle = (GradientStyle) 2;
    ((ControlBase) this.lblSideBar).Appearance = (AppearanceBase) appearance45;
    ((ControlBase) this.lblSideBar).BackColorInternal = Color.White;
    this.lblSideBar.BorderStyleOuter = (UIElementBorderStyle) 1;
    ((Control) this.lblSideBar).Dock = DockStyle.Fill;
    ((Control) this.lblSideBar).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.lblSideBar).ForeColor = Color.Black;
    ((Control) this.lblSideBar).Location = new Point(0, 0);
    ((Control) this.lblSideBar).Name = "lblSideBar";
    ((Control) this.lblSideBar).Size = new Size(320, 419);
    ((Control) this.lblSideBar).TabIndex = 1;
    this.pnlSummary.BackColor = Color.White;
    this.pnlSummary.Controls.Add((Control) this.label10);
    this.pnlSummary.Controls.Add((Control) this.labelDebitsTotal);
    this.pnlSummary.Controls.Add((Control) this.labelCreditsTotal);
    this.pnlSummary.Controls.Add((Control) this.label9);
    this.pnlSummary.Controls.Add((Control) this.comboTransactionType);
    this.pnlSummary.Controls.Add((Control) this.dateTimePostDate);
    this.pnlSummary.Controls.Add((Control) this.label5);
    this.pnlSummary.Controls.Add((Control) this.label4);
    this.pnlSummary.Controls.Add((Control) this.label3);
    this.pnlSummary.Controls.Add((Control) this.textTransactionComments);
    this.pnlSummary.Controls.Add((Control) this.label6);
    this.pnlSummary.Controls.Add((Control) this.ultraLabel8);
    this.pnlSummary.Dock = DockStyle.Fill;
    this.pnlSummary.Location = new Point(0, 0);
    this.pnlSummary.Name = "pnlSummary";
    this.pnlSummary.Size = new Size(1026, 499);
    this.pnlSummary.TabIndex = 1;
    this.label10.ForeColor = Color.Red;
    this.label10.Location = new Point(257, 199);
    this.label10.Name = "label10";
    this.label10.Size = new Size(328, 47);
    this.label10.TabIndex = 22;
    this.label10.Text = "Selecting the incorrect transaction type may have adverse effects on reports, please make sure you select the correct transaction type when using this utility. *";
    ((AppearanceBase) appearance46).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.labelDebitsTotal).Appearance = (AppearanceBase) appearance46;
    this.labelDebitsTotal.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.labelDebitsTotal).Location = new Point(257, 89);
    ((Control) this.labelDebitsTotal).Name = "labelDebitsTotal";
    ((Control) this.labelDebitsTotal).Size = new Size(158, 23);
    ((Control) this.labelDebitsTotal).TabIndex = 21;
    ((AppearanceBase) appearance47).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((ControlBase) this.labelCreditsTotal).Appearance = (AppearanceBase) appearance47;
    this.labelCreditsTotal.BorderStyleOuter = (UIElementBorderStyle) 4;
    ((Control) this.labelCreditsTotal).Location = new Point(257, 118);
    ((Control) this.labelCreditsTotal).Name = "labelCreditsTotal";
    ((Control) this.labelCreditsTotal).Size = new Size(158, 23);
    ((Control) this.labelCreditsTotal).TabIndex = 20;
    this.label9.AutoSize = true;
    this.label9.Location = new Point(161, 176 /*0xB0*/);
    this.label9.Name = "label9";
    this.label9.Size = new Size(94, 13);
    this.label9.TabIndex = 19;
    this.label9.Text = "Transaction Type:";
    this.comboTransactionType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboTransactionType.CharacterCasing = CharacterCasing.Normal;
    this.comboTransactionType.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboTransactionType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboTransactionType).Location = new Point(257, 175);
    this.comboTransactionType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboTransactionType).Name = "comboTransactionType";
    ((Control) this.comboTransactionType).Size = new Size(276, 21);
    ((Control) this.comboTransactionType).TabIndex = 18;
    ((UltraControlBase) this.comboTransactionType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboTransactionType).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance48).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimePostDate.Appearance = (AppearanceBase) appearance48;
    ((AppearanceBase) appearance49).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance49).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance49).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance49).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance49).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance49).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance49).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance49).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance49).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance49).ForegroundAlpha = (Alpha) 2;
    this.dateTimePostDate.ButtonAppearance = (AppearanceBase) appearance49;
    ((Control) this.dateTimePostDate).Location = new Point(257, 146);
    this.dateTimePostDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimePostDate).Name = "dateTimePostDate";
    ((Control) this.dateTimePostDate).Size = new Size(88, 20);
    ((Control) this.dateTimePostDate).TabIndex = 6;
    ((UltraControlBase) this.dateTimePostDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimePostDate).UseOsThemes = (DefaultableBoolean) 2;
    this.label5.AutoSize = true;
    this.label5.Location = new Point(161, 146);
    this.label5.Name = "label5";
    this.label5.Size = new Size(78, 13);
    this.label5.TabIndex = 5;
    this.label5.Text = "Posting Date : ";
    this.label4.AutoSize = true;
    this.label4.Location = new Point(161, 89);
    this.label4.Name = "label4";
    this.label4.Size = new Size(69, 13);
    this.label4.TabIndex = 0;
    this.label4.Text = "Debit Total : ";
    this.label3.AutoSize = true;
    this.label3.Location = new Point(161, 116);
    this.label3.Name = "label3";
    this.label3.Size = new Size(78, 13);
    this.label3.TabIndex = 3;
    this.label3.Text = "Credits Total : ";
    ((AppearanceBase) appearance50).BackColor = Color.White;
    ((AppearanceBase) appearance50).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance50).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textTransactionComments).Appearance = (AppearanceBase) appearance50;
    ((Control) this.textTransactionComments).BackColor = Color.White;
    ((Control) this.textTransactionComments).Location = new Point(257, 249);
    ((TextEditorControlBase) this.textTransactionComments).MaxLength = 2000;
    this.textTransactionComments.MGAStyle = MGAStyles.Blue;
    this.textTransactionComments.Multiline = true;
    ((Control) this.textTransactionComments).Name = "textTransactionComments";
    ((Control) this.textTransactionComments).Size = new Size(328, 109);
    ((Control) this.textTransactionComments).TabIndex = 17;
    ((UltraControlBase) this.textTransactionComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textTransactionComments).UseOsThemes = (DefaultableBoolean) 2;
    this.label6.AutoSize = true;
    this.label6.Location = new Point(161, 248);
    this.label6.Name = "label6";
    this.label6.Size = new Size(57, 13);
    this.label6.TabIndex = 1;
    this.label6.Text = "Comments";
    ((AppearanceBase) appearance51).BackColor = Color.White;
    ((AppearanceBase) appearance51).BackGradientAlignment = (GradientAlignment) 3;
    ((AppearanceBase) appearance51).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance51).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel8).Appearance = (AppearanceBase) appearance51;
    ((Control) this.ultraLabel8).AutoSize = true;
    ((ControlBase) this.ultraLabel8).BackColorInternal = Color.White;
    ((Control) this.ultraLabel8).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel8).ForeColor = Color.Black;
    ((Control) this.ultraLabel8).Location = new Point(161, 41);
    ((Control) this.ultraLabel8).Name = "ultraLabel8";
    ((Control) this.ultraLabel8).Size = new Size(125, 15);
    ((Control) this.ultraLabel8).TabIndex = 0;
    ((Control) this.ultraLabel8).Text = "Transaction Summary";
    this.comboSource.Band.Columns.AddRange(new object[2]
    {
      (object) ultraDataColumn12,
      (object) ultraDataColumn13
    });
    this.daGetOfficeLocations.SelectCommand = this.sqlSelectCommand1;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_GetOfficeLocations]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, MGASystems.IMS.Accounting.GeneralLedger.Strings.EmptyString, DataRowVersion.Current, (object) null)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    ((Control) this.buttonFinish).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance52).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance52).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance52).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance52).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance52).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance52).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonFinish).Appearance = (AppearanceBase) appearance52;
    ((Control) this.buttonFinish).Enabled = false;
    ((Control) this.buttonFinish).Location = new Point(512 /*0x0200*/, 8);
    ((Control) this.buttonFinish).Name = "buttonFinish";
    ((Control) this.buttonFinish).Size = new Size(88, 24);
    ((Control) this.buttonFinish).TabIndex = 2;
    ((Control) this.buttonFinish).Text = "Finish";
    ((UltraControlBase) this.buttonFinish).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonFinish).Click += new EventHandler(this.buttonFinish_Click);
    ((Control) this.buttonBack).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance53).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance53).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance53).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance53).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance53).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance53).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonBack).Appearance = (AppearanceBase) appearance53;
    ((ControlBase) this.buttonBack).BackColorInternal = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((Control) this.buttonBack).Enabled = false;
    ((Control) this.buttonBack).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.buttonBack).ForeColor = Color.Black;
    ((Control) this.buttonBack).Location = new Point(288, 8);
    ((Control) this.buttonBack).Name = "buttonBack";
    ((Control) this.buttonBack).Size = new Size(88, 24);
    ((Control) this.buttonBack).TabIndex = 0;
    ((Control) this.buttonBack).Text = "<< &Back";
    ((UltraControlBase) this.buttonBack).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonBack).Click += new EventHandler(this.buttonBack_Click);
    ((Control) this.buttonNext).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance54).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance54).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance54).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance54).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance54).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance54).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonNext).Appearance = (AppearanceBase) appearance54;
    ((ControlBase) this.buttonNext).BackColorInternal = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((Control) this.buttonNext).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.buttonNext).ForeColor = Color.Black;
    ((Control) this.buttonNext).Location = new Point(384, 8);
    ((Control) this.buttonNext).Name = "buttonNext";
    ((Control) this.buttonNext).Size = new Size(88, 24);
    ((Control) this.buttonNext).TabIndex = 1;
    ((Control) this.buttonNext).Text = "&Next >>";
    ((UltraControlBase) this.buttonNext).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonNext).Click += new EventHandler(this.buttonNext_Click);
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((AppearanceBase) appearance55).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance55).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance55).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance55).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance55).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance55).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance55;
    ((Control) this.buttonCancel).Location = new Point(608, 8);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 24);
    ((Control) this.buttonCancel).TabIndex = 3;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.pnlBottom.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.pnlBottom.Controls.Add((Control) this.buttonClearInvoice);
    this.pnlBottom.Controls.Add((Control) this.buttonFinish);
    this.pnlBottom.Controls.Add((Control) this.buttonBack);
    this.pnlBottom.Controls.Add((Control) this.buttonNext);
    this.pnlBottom.Controls.Add((Control) this.buttonCancel);
    this.pnlBottom.Dock = DockStyle.Bottom;
    this.pnlBottom.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.pnlBottom.ForeColor = Color.Black;
    this.pnlBottom.Location = new Point(320, 459);
    this.pnlBottom.Name = "pnlBottom";
    this.pnlBottom.Size = new Size(706, 40);
    this.pnlBottom.TabIndex = 2;
    ((AppearanceBase) appearance56).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance56).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance56).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance56).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonClearInvoice).Appearance = (AppearanceBase) appearance56;
    ((ControlBase) this.buttonClearInvoice).BackColorInternal = Color.White;
    ((Control) this.buttonClearInvoice).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.buttonClearInvoice).ForeColor = Color.Black;
    ((Control) this.buttonClearInvoice).Location = new Point(6, 8);
    ((Control) this.buttonClearInvoice).Name = "buttonClearInvoice";
    ((Control) this.buttonClearInvoice).Size = new Size((int) sbyte.MaxValue, 24);
    ((Control) this.buttonClearInvoice).TabIndex = 23;
    ((Control) this.buttonClearInvoice).Text = "Clear Invoice ";
    ((UltraControlBase) this.buttonClearInvoice).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonClearInvoice).Click += new EventHandler(this.buttonClearInvoice_Click);
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).Name = "_formLedgerEntryWizard_Toolbars_Dock_Area_Top";
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top).Size = new Size(1026, 0);
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolManager;
    this.toolManager.DesignerFlags = 0;
    this.toolManager.DockWithinContainer = (Control) this;
    this.toolManager.DockWithinContainerBaseType = typeof (Form);
    this.toolManager.ShowFullMenusDelay = 500;
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = "ContextMenu";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((AppearanceBase) appearance57).Image = componentResourceManager.GetObject("appearance50.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance57;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "&Edit";
    ((AppearanceBase) appearance58).Image = componentResourceManager.GetObject("appearance51.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance58;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "&Delete";
    ((ToolsCollectionBase) this.toolManager.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).Location = new Point(0, 499);
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).Name = "_formLedgerEntryWizard_Toolbars_Dock_Area_Bottom";
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom).Size = new Size(1026, 0);
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.toolManager;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).Name = "_formLedgerEntryWizard_Toolbars_Dock_Area_Left";
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left).Size = new Size(0, 499);
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolManager;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).Location = new Point(1026, 0);
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).Name = "_formLedgerEntryWizard_Toolbars_Dock_Area_Right";
    ((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right).Size = new Size(0, 499);
    this._formLedgerEntryWizard_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolManager;
    ((AppearanceBase) appearance59).BackColor = Color.White;
    ((AppearanceBase) appearance59).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance59).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance59).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance59).ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel9).Appearance = (AppearanceBase) appearance59;
    ((Control) this.ultraLabel9).AutoSize = true;
    ((ControlBase) this.ultraLabel9).BackColorInternal = Color.White;
    ((Control) this.ultraLabel9).Font = new Font("Tahoma", 8f, FontStyle.Bold);
    ((Control) this.ultraLabel9).ForeColor = Color.Black;
    ((Control) this.ultraLabel9).Location = new Point(8, 8);
    ((Control) this.ultraLabel9).Name = "ultraLabel9";
    ((Control) this.ultraLabel9).Size = new Size(161, 15);
    ((Control) this.ultraLabel9).TabIndex = 1;
    ((Control) this.ultraLabel9).Text = "Invoice Ledger Entry Wizard";
    ((AppearanceBase) appearance60).BackColor = Color.White;
    ((AppearanceBase) appearance60).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance60).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance60).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance60).ForeColor = Color.DimGray;
    ((ControlBase) this.ultraLabel7).Appearance = (AppearanceBase) appearance60;
    ((ControlBase) this.ultraLabel7).BackColorInternal = Color.White;
    ((Control) this.ultraLabel7).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel7).ForeColor = Color.Black;
    ((Control) this.ultraLabel7).Location = new Point(8, 24);
    ((Control) this.ultraLabel7).Name = "ultraLabel7";
    ((Control) this.ultraLabel7).Size = new Size(304, 50);
    ((Control) this.ultraLabel7).TabIndex = 2;
    ((Control) this.ultraLabel7).Text = componentResourceManager.GetString("ultraLabel7.Text");
    this.dropTreeGLAccounts.BackColor = Color.White;
    this.dropTreeGLAccounts.DropDownHeight = 300;
    this.dropTreeGLAccounts.DropDownWidth = 300;
    this.dropTreeGLAccounts.Font = new Font("Tahoma", 8f);
    this.dropTreeGLAccounts.ForeColor = Color.Black;
    this.dropTreeGLAccounts.Location = new Point(100, 206);
    this.dropTreeGLAccounts.Name = "dropTreeGLAccounts";
    this.dropTreeGLAccounts.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeGLAccounts.ShowEquityAccounts = true;
    this.dropTreeGLAccounts.ShowExpenseAccounts = true;
    this.dropTreeGLAccounts.ShowIncomeAccounts = true;
    this.dropTreeGLAccounts.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeGLAccounts.ShowSystemDefinedAccounts = true;
    this.dropTreeGLAccounts.Size = new Size(212, 20);
    this.dropTreeGLAccounts.TabIndex = 12;
    this.dropTreeGLAccounts.UseCheckedStateSelectionOverride = false;
    ((AppearanceBase) appearance61).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance61).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance61).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance61).BorderColor = Color.DarkGray;
    ((ControlBase) this.btnAdd).Appearance = (AppearanceBase) appearance61;
    ((ControlBase) this.btnAdd).BackColorInternal = Color.White;
    ((Control) this.btnAdd).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnAdd).ForeColor = Color.Black;
    ((Control) this.btnAdd).Location = new Point(141, 347);
    ((Control) this.btnAdd).Name = "btnAdd";
    ((Control) this.btnAdd).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnAdd).TabIndex = 21;
    ((Control) this.btnAdd).Text = "&Add";
    ((UltraControlBase) this.btnAdd).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.btnAdd).Click += new EventHandler(this.btnAdd_Click);
    ((AppearanceBase) appearance62).BackColor = Color.White;
    ((AppearanceBase) appearance62).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance62).ForeColor = Color.Black;
    ((AppearanceBase) appearance62).TextHAlignAsString = "Right";
    ((TextEditorControlBase) this.textAmount).Appearance = (AppearanceBase) appearance62;
    ((Control) this.textAmount).BackColor = Color.White;
    ((Control) this.textAmount).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.textAmount).ForeColor = Color.Black;
    ((Control) this.textAmount).Location = new Point(100, 297);
    ((TextEditorControlBase) this.textAmount).MaxLength = 50;
    this.textAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.textAmount).Name = "textAmount";
    ((Control) this.textAmount).Size = new Size(212, 20);
    ((Control) this.textAmount).TabIndex = 18;
    ((UltraControlBase) this.textAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textAmount).Leave += new EventHandler(this.textAmount_Leave);
    ((AppearanceBase) appearance63).BackColor = Color.White;
    ((AppearanceBase) appearance63).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance63).ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtComments).Appearance = (AppearanceBase) appearance63;
    ((Control) this.txtComments).BackColor = Color.White;
    ((Control) this.txtComments).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.txtComments).ForeColor = Color.Black;
    ((Control) this.txtComments).Location = new Point(100, 232);
    ((TextEditorControlBase) this.txtComments).MaxLength = 2000;
    this.txtComments.MGAStyle = MGAStyles.Blue;
    this.txtComments.Multiline = true;
    ((Control) this.txtComments).Name = "txtComments";
    ((Control) this.txtComments).Size = new Size(212, 61);
    ((Control) this.txtComments).TabIndex = 16 /*0x10*/;
    ((UltraControlBase) this.txtComments).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtComments).UseOsThemes = (DefaultableBoolean) 2;
    this.pnlContainer.BackColor = Color.White;
    this.pnlContainer.Controls.Add((Control) this.ultraTabControl1);
    this.pnlContainer.Dock = DockStyle.Fill;
    this.pnlContainer.Location = new Point(320, 80 /*0x50*/);
    this.pnlContainer.Name = "pnlContainer";
    this.pnlContainer.Size = new Size(706, 379);
    this.pnlContainer.TabIndex = 213;
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabSharedControlsPage1);
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabPageControl1);
    ((Control) this.ultraTabControl1).Controls.Add((Control) this.ultraTabPageControl2);
    ((Control) this.ultraTabControl1).Dock = DockStyle.Fill;
    ((Control) this.ultraTabControl1).Location = new Point(0, 0);
    ((Control) this.ultraTabControl1).Name = "ultraTabControl1";
    ((UltraTabControlBase) this.ultraTabControl1).SharedControlsPage = this.ultraTabSharedControlsPage1;
    ((Control) this.ultraTabControl1).Size = new Size(706, 379);
    ((Control) this.ultraTabControl1).TabIndex = 0;
    ultraTab1.TabPage = this.ultraTabPageControl2;
    ultraTab1.Text = "Transaction Information";
    ultraTab2.TabPage = this.ultraTabPageControl1;
    ultraTab2.Text = "Invoice Information";
    ((UltraTabControlBase) this.ultraTabControl1).Tabs.AddRange(new UltraTab[2]
    {
      ultraTab1,
      ultraTab2
    });
    ((Control) this.ultraTabSharedControlsPage1).Location = new Point(-10000, -10000);
    ((Control) this.ultraTabSharedControlsPage1).Name = "ultraTabSharedControlsPage1";
    ((Control) this.ultraTabSharedControlsPage1).Size = new Size(702, 353);
    this.pictureBox1.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.pictureBox1.Location = new Point(19, 12);
    this.pictureBox1.Name = "pictureBox1";
    this.pictureBox1.Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    this.pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.pictureBox1.TabIndex = 2;
    this.pictureBox1.TabStop = false;
    this.pnlContainerSide.Controls.Add((Control) this.buttonSearchInvoice);
    this.pnlContainerSide.Controls.Add((Control) this.comboCompanyLineGuid);
    this.pnlContainerSide.Controls.Add((Control) this.comboChargeCode);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel11);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel10);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel2);
    this.pnlContainerSide.Controls.Add((Control) this.textInvoiceNumber);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel9);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel7);
    this.pnlContainerSide.Controls.Add((Control) this.dropTreeGLAccounts);
    this.pnlContainerSide.Controls.Add((Control) this.btnAdd);
    this.pnlContainerSide.Controls.Add((Control) this.textAmount);
    this.pnlContainerSide.Controls.Add((Control) this.txtComments);
    this.pnlContainerSide.Controls.Add((Control) this.comboType);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel5);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel3);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel1);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel6);
    this.pnlContainerSide.Controls.Add((Control) this.comboOfficeLocation);
    this.pnlContainerSide.Controls.Add((Control) this.ultraLabel4);
    this.pnlContainerSide.Controls.Add((Control) this.btnCancelChanges);
    this.pnlContainerSide.Controls.Add((Control) this.lblSideBar);
    this.pnlContainerSide.Dock = DockStyle.Left;
    this.pnlContainerSide.Location = new Point(0, 80 /*0x50*/);
    this.pnlContainerSide.Name = "pnlContainerSide";
    this.pnlContainerSide.Size = new Size(320, 419);
    this.pnlContainerSide.TabIndex = 216;
    ((AppearanceBase) appearance64).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance64).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance64).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance64).BorderColor = Color.DimGray;
    ((AppearanceBase) appearance64).Image = componentResourceManager.GetObject("appearance27.Image");
    ((AppearanceBase) appearance64).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance64).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearchInvoice).Appearance = (AppearanceBase) appearance64;
    ((Control) this.buttonSearchInvoice).Location = new Point(293, 126);
    ((Control) this.buttonSearchInvoice).Name = "buttonSearchInvoice";
    ((Control) this.buttonSearchInvoice).Size = new Size(21, 21);
    ((Control) this.buttonSearchInvoice).TabIndex = 6;
    ((UltraControlBase) this.buttonSearchInvoice).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearchInvoice).Click += new EventHandler(this.buttonSearchInvoice_Click);
    this.comboCompanyLineGuid.AutoSelectOnOneItem = true;
    this.comboCompanyLineGuid.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCompanyLineGuid.CharacterCasing = CharacterCasing.Normal;
    this.comboCompanyLineGuid.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboCompanyLineGuid.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCompanyLineGuid).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.comboCompanyLineGuid).Location = new Point(100, 179);
    this.comboCompanyLineGuid.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCompanyLineGuid).Name = "comboCompanyLineGuid";
    ((Control) this.comboCompanyLineGuid).Size = new Size(212, 21);
    ((Control) this.comboCompanyLineGuid).TabIndex = 10;
    ((UltraControlBase) this.comboCompanyLineGuid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCompanyLineGuid).UseOsThemes = (DefaultableBoolean) 2;
    this.comboChargeCode.AutoSelectOnOneItem = true;
    this.comboChargeCode.BorderStyle = (UIElementBorderStyle) 4;
    this.comboChargeCode.CharacterCasing = CharacterCasing.Normal;
    this.comboChargeCode.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboChargeCode.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboChargeCode).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.comboChargeCode).Location = new Point(100, 152);
    this.comboChargeCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboChargeCode).Name = "comboChargeCode";
    ((Control) this.comboChargeCode).Size = new Size(212, 21);
    ((Control) this.comboChargeCode).TabIndex = 8;
    ((UltraControlBase) this.comboChargeCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboChargeCode).UseOsThemes = (DefaultableBoolean) 2;
    this.comboChargeCode.RowSelected += new RowSelectedEventHandler(this.comboChargeCode_RowSelected);
    ((AppearanceBase) appearance65).BackColor = Color.White;
    ((AppearanceBase) appearance65).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance65).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance65).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance65).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel11).Appearance = (AppearanceBase) appearance65;
    ((Control) this.ultraLabel11).AutoSize = true;
    ((ControlBase) this.ultraLabel11).BackColorInternal = Color.White;
    ((Control) this.ultraLabel11).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel11).ForeColor = Color.Black;
    ((Control) this.ultraLabel11).Location = new Point(4, 179);
    ((Control) this.ultraLabel11).Name = "ultraLabel11";
    ((Control) this.ultraLabel11).Size = new Size(78, 14);
    ((Control) this.ultraLabel11).TabIndex = 9;
    ((Control) this.ultraLabel11).Text = "Company/Line:";
    ((AppearanceBase) appearance66).BackColor = Color.White;
    ((AppearanceBase) appearance66).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance66).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance66).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance66).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel10).Appearance = (AppearanceBase) appearance66;
    ((Control) this.ultraLabel10).AutoSize = true;
    ((ControlBase) this.ultraLabel10).BackColorInternal = Color.White;
    ((Control) this.ultraLabel10).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel10).ForeColor = Color.Black;
    ((Control) this.ultraLabel10).Location = new Point(4, 152);
    ((Control) this.ultraLabel10).Name = "ultraLabel10";
    ((Control) this.ultraLabel10).Size = new Size(72, 14);
    ((Control) this.ultraLabel10).TabIndex = 7;
    ((Control) this.ultraLabel10).Text = "Charge Code:";
    ((AppearanceBase) appearance67).BackColor = Color.White;
    ((AppearanceBase) appearance67).BackColor2 = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance67).BackGradientAlignment = (GradientAlignment) 2;
    ((AppearanceBase) appearance67).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance67).ForeColor = Color.Black;
    ((ControlBase) this.ultraLabel2).Appearance = (AppearanceBase) appearance67;
    ((Control) this.ultraLabel2).AutoSize = true;
    ((ControlBase) this.ultraLabel2).BackColorInternal = Color.White;
    ((Control) this.ultraLabel2).Font = new Font("Arial", 8f);
    ((Control) this.ultraLabel2).ForeColor = Color.Black;
    ((Control) this.ultraLabel2).Location = new Point(4, 129);
    ((Control) this.ultraLabel2).Name = "ultraLabel2";
    ((Control) this.ultraLabel2).Size = new Size(84, 14);
    ((Control) this.ultraLabel2).TabIndex = 4;
    ((Control) this.ultraLabel2).Text = "Invoice Number:";
    ((AppearanceBase) appearance68).BackColor = Color.White;
    ((AppearanceBase) appearance68).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance68).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textInvoiceNumber).Appearance = (AppearanceBase) appearance68;
    ((Control) this.textInvoiceNumber).BackColor = Color.White;
    ((Control) this.textInvoiceNumber).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.textInvoiceNumber).ForeColor = Color.Black;
    ((Control) this.textInvoiceNumber).Location = new Point(100, 126);
    ((TextEditorControlBase) this.textInvoiceNumber).MaxLength = 50;
    this.textInvoiceNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textInvoiceNumber).Name = "textInvoiceNumber";
    ((Control) this.textInvoiceNumber).Size = new Size(190, 20);
    ((Control) this.textInvoiceNumber).TabIndex = 5;
    ((UltraControlBase) this.textInvoiceNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textInvoiceNumber).UseOsThemes = (DefaultableBoolean) 2;
    this.lblLine.BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.lblLine.Dock = DockStyle.Bottom;
    this.lblLine.Location = new Point(0, 79);
    this.lblLine.Name = "lblLine";
    this.lblLine.Size = new Size(1026, 1);
    this.lblLine.TabIndex = 1;
    this.panelTop.BackColor = Color.White;
    this.panelTop.Controls.Add((Control) this.lblLine);
    this.panelTop.Controls.Add((Control) this.label1);
    this.panelTop.Controls.Add((Control) this.pictureBox1);
    this.panelTop.Dock = DockStyle.Top;
    this.panelTop.Location = new Point(0, 0);
    this.panelTop.Name = "panelTop";
    this.panelTop.Size = new Size(1026, 80 /*0x50*/);
    this.panelTop.TabIndex = 0;
    this.label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label1.AutoSize = true;
    this.label1.Font = new Font("Arial", 14f, FontStyle.Bold);
    this.label1.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label1.Location = new Point(752, 55);
    this.label1.Name = "label1";
    this.label1.Size = new Size(271, 22);
    this.label1.TabIndex = 0;
    this.label1.Text = "Invoice Ledger Entry Wizard";
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left).Name = "_formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left";
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left).Size = new Size(0, 499);
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left.ToolbarsManager = this.toolManager;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right).Location = new Point(1026, 0);
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right).Name = "_formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right";
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right).Size = new Size(0, 499);
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right.ToolbarsManager = this.toolManager;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top).Name = "_formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top";
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top).Size = new Size(1026, 0);
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top.ToolbarsManager = this.toolManager;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom).Location = new Point(0, 499);
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom).Name = "_formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom";
    ((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom).Size = new Size(1026, 0);
    this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.toolManager;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1026, 499);
    this.Controls.Add((Control) this.pnlContainer);
    this.Controls.Add((Control) this.pnlBottom);
    this.Controls.Add((Control) this.pnlContainerSide);
    this.Controls.Add((Control) this.panelTop);
    this.Controls.Add((Control) this.pnlSummary);
    this.Controls.Add((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._formLedgerEntryWizard_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._formInvoiceLedgerEntryWizard_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (formInvoiceLedgerEntryWizard);
    this.Text = "Invoice Ledger Entry Wizard";
    ((Control) this.ultraTabPageControl2).ResumeLayout(false);
    ((ISupportInitialize) this.grid).EndInit();
    ((ISupportInitialize) this.dataSource).EndInit();
    ((Control) this.ultraTabPageControl1).ResumeLayout(false);
    ((Control) this.ultraTabPageControl1).PerformLayout();
    ((ISupportInitialize) this.groupAccounts).EndInit();
    ((Control) this.groupAccounts).ResumeLayout(false);
    ((ISupportInitialize) this.gridInvoiceAccounts).EndInit();
    this.dsLedger1.EndInit();
    this.dsOfficeLocations1.EndInit();
    ((ISupportInitialize) this.comboType).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.btnCancelChanges).EndInit();
    this.pnlSummary.ResumeLayout(false);
    this.pnlSummary.PerformLayout();
    ((ISupportInitialize) this.comboTransactionType).EndInit();
    ((ISupportInitialize) this.dateTimePostDate).EndInit();
    ((ISupportInitialize) this.textTransactionComments).EndInit();
    ((ISupportInitialize) this.comboSource).EndInit();
    ((ISupportInitialize) this.buttonFinish).EndInit();
    ((ISupportInitialize) this.buttonBack).EndInit();
    ((ISupportInitialize) this.buttonNext).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    this.pnlBottom.ResumeLayout(false);
    ((ISupportInitialize) this.buttonClearInvoice).EndInit();
    ((ISupportInitialize) this.toolManager).EndInit();
    ((ISupportInitialize) this.btnAdd).EndInit();
    ((ISupportInitialize) this.textAmount).EndInit();
    ((ISupportInitialize) this.txtComments).EndInit();
    this.pnlContainer.ResumeLayout(false);
    ((ISupportInitialize) this.ultraTabControl1).EndInit();
    ((Control) this.ultraTabControl1).ResumeLayout(false);
    ((ISupportInitialize) this.pictureBox1).EndInit();
    this.pnlContainerSide.ResumeLayout(false);
    this.pnlContainerSide.PerformLayout();
    ((ISupportInitialize) this.buttonSearchInvoice).EndInit();
    ((ISupportInitialize) this.comboCompanyLineGuid).EndInit();
    ((ISupportInitialize) this.comboChargeCode).EndInit();
    ((ISupportInitialize) this.textInvoiceNumber).EndInit();
    this.panelTop.ResumeLayout(false);
    this.panelTop.PerformLayout();
    this.ResumeLayout(false);
  }
}
