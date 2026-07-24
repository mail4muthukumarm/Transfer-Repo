// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.FormExcelImport
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class FormExcelImport : FormBase
{
  protected DataSet excelData;
  protected Guid _entityName;
  protected Utility.PayablesSearchType _paySearchType;
  protected Utility.ReceivablesSearchType _recSearchType;
  protected formTransactionSearch.SearchTypes _searchType;
  protected StringBuilder _sb = new StringBuilder();
  protected bool ClaimsEnabled;
  private IContainer components;
  private Label label1;
  protected MGATextBox textFileName;
  private UltraDropDown dropDownWorksheetFields;
  private Label labelSpacer;
  protected MGASimpleComboBox comboOfficeLocation;
  protected RadioButton radioDoNotApplyAmount;
  protected RadioButton radioApplyAmounts;
  protected MGATextBox textEntityName;
  private Button buttonSearchEntity;
  protected RadioButton radioAccountsPayable;
  protected RadioButton radioAccountsReceivable;
  protected OpenFileDialog openFileDialog1;
  protected dsExcelImportMappings dsExcelImportMappings1;
  protected dsExcelFieldNames dsExcelFieldNames1;
  protected UltraGrid gridMappings;
  protected ProgressBar progressProcessing;
  protected Label label2;
  protected MGACheckBox checkFirstRowColumnNames;
  protected MGASimpleComboBox comboWorksheet;
  protected Label label3;
  protected Button buttonImportFile;
  protected Button buttonCancel;
  protected Label labelProgress;
  protected Label label13;
  protected Label label5;
  protected Panel panel2;
  protected Panel panel1;
  protected Label label6;
  protected Label label4;
  protected Button buttonFindExcelFile;
  protected RadioButton radioClaimsReceivable;
  public GroupBox groupExcelFileAndMappings;
  public GroupBox groupBox1;
  protected MGACheckBox checkShowZero;

  public FormExcelImport() => this.InitializeComponent();

  private void FormExcelImport_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.GetOfficeLocations();
  }

  private void GetOfficeLocations()
  {
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = string.Empty;
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboOfficeLocation).Rows).Count != 1)
      return;
    this.comboOfficeLocation.Value = ((UltraGridBase) this.comboOfficeLocation).Rows[0].Cells["ID"].Value;
  }

  private void buttonSearchEntity_Click(object sender, EventArgs e)
  {
    using (FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.All))
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      ((Control) this.textEntityName).Tag = (object) formSearchEntity.EntityGuid;
      ((Control) this.textEntityName).Text = formSearchEntity.EntityName;
    }
  }

  private void buttonSearchFile_Click(object sender, EventArgs e)
  {
    if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
      return;
    ((Control) this.textFileName).Text = this.openFileDialog1.FileName;
    this.GetWorksheets();
  }

  protected virtual void GetIMSFields()
  {
    this.dsExcelImportMappings1.Clear();
    DefaultDatabase.LoadDataTable((DataTable) this.dsExcelImportMappings1.FieldMappings, this.radioClaimsReceivable.Checked ? "dbo.spfin_GetClaimsExcelFieldMappingsList" : "dbo.spfin_GetExcelFieldMappingsList");
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void GetWorksheets()
  {
    Workbook workbook = new Workbook(((Control) this.textFileName).Text);
    DataTable dataTable = new DataTable();
    dataTable.Columns.AddRange(new DataColumn[1]
    {
      new DataColumn("WorksheetName", typeof (string))
    });
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) workbook.Worksheets)
      dataTable.Rows.Add((object) worksheet.Name);
    ((Control) this.comboWorksheet).Enabled = true;
    ((UltraGridBase) this.comboWorksheet).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboWorksheet).DisplayMember = "WorksheetName";
    ((UltraDropDownBase) this.comboWorksheet).ValueMember = "WorksheetName";
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboWorksheet).Rows).Count != 0)
      return;
    this.comboWorksheet.Value = (object) ((UltraGridBase) this.comboWorksheet).Rows[0].Cells["WorksheetName"].Value.ToString();
  }

  private void BuildFieldMappingsDataset()
  {
    MGASystems.AsposeFacade.Cells.Cells cells = new Workbook(((Control) this.textFileName).Text).Worksheets[((Control) this.comboWorksheet).Text].Cells;
    this.dsExcelFieldNames1.Clear();
    if (cells.MaxDataColumn == 0 || cells.MaxDataRow == 0)
    {
      int num1 = (int) MessageBox.Show("The worksheet selected has no columns or rows.", "Invalid Worksheet Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.excelData = new DataSet();
      try
      {
        this.excelData.Tables.Add(cells.ExportDataTable(0, 0, cells.MaxDataRow + 1, cells.MaxDataColumn + 1, new ExportTableOptions()
        {
          CheckMixedValueType = true,
          ExportColumnName = ((UltraToggleEditorBase) this.checkFirstRowColumnNames).Checked
        }));
      }
      catch (DuplicateNameException ex)
      {
        int num2 = (int) MessageBox.Show("The worksheet selected has duplicate column names.", "Invalid Column Identifiers!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
      }
      for (int index = 0; index < this.excelData.Tables[0].Columns.Count; ++index)
        this.dsExcelFieldNames1.FieldNames.Rows.Add((object) this.excelData.Tables[0].Columns[index].ColumnName);
      ((UltraGridBase) this.gridMappings).DisplayLayout.Bands[0].Columns[1].ValueList = (IValueList) this.dropDownWorksheetFields;
    }
  }

  private void comboWorksheet_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboWorksheet).SelectedRow == null || ((Control) this.comboWorksheet).Text.Equals(string.Empty))
      return;
    this.GetIMSFields();
    this.BuildFieldMappingsDataset();
  }

  protected virtual void buttonImportFile_Click(object sender, EventArgs e)
  {
    if (!this.ValidateInputs() || !this.ValidateFieldMappings())
      return;
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.labelProgress.Visible = true;
      this.Automate();
    }
    finally
    {
      this.labelProgress.Visible = false;
      this.Cursor = Cursors.Default;
    }
  }

  protected void ValidateSettings()
  {
    if (this.radioAccountsPayable.Checked)
      this._searchType = formTransactionSearch.SearchTypes.Payables;
    else if (this.radioAccountsReceivable.Checked || this.radioClaimsReceivable.Checked)
      this._searchType = formTransactionSearch.SearchTypes.Receivables;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (row.Cells["ExcelField"].Value != null && !(row.Cells["ExcelField"].Value.ToString() == string.Empty))
      {
        switch (row.Cells["IMSField"].Value.ToString())
        {
          case "Policy Number":
            switch (this._searchType)
            {
              case formTransactionSearch.SearchTypes.Payables:
                this._paySearchType = Utility.PayablesSearchType.PolicyNumber;
                this._recSearchType = Utility.ReceivablesSearchType.None;
                continue;
              case formTransactionSearch.SearchTypes.Receivables:
                this._paySearchType = Utility.PayablesSearchType.None;
                this._recSearchType = Utility.ReceivablesSearchType.PolicyNumber;
                continue;
              default:
                continue;
            }
          case "Invoice Number":
            switch (this._searchType)
            {
              case formTransactionSearch.SearchTypes.Payables:
                this._paySearchType = Utility.PayablesSearchType.InvoiceNumber;
                this._recSearchType = Utility.ReceivablesSearchType.None;
                continue;
              case formTransactionSearch.SearchTypes.Receivables:
                this._paySearchType = Utility.PayablesSearchType.None;
                this._recSearchType = Utility.ReceivablesSearchType.InvoiceNumber;
                continue;
              default:
                continue;
            }
          case "Claim Number":
            switch (this._searchType)
            {
              case formTransactionSearch.SearchTypes.Payables:
                this._paySearchType = Utility.PayablesSearchType.Payee;
                this._recSearchType = Utility.ReceivablesSearchType.None;
                continue;
              case formTransactionSearch.SearchTypes.Receivables:
                this._paySearchType = Utility.PayablesSearchType.None;
                this._recSearchType = Utility.ReceivablesSearchType.Remitter;
                continue;
              default:
                continue;
            }
          default:
            continue;
        }
      }
    }
  }

  private bool ValidateFieldMappings()
  {
    UltraGridRow[] inNonGroupByRows = ((UltraGridBase) this.gridMappings).Rows.GetFilteredInNonGroupByRows();
    IEnumerable<UltraGridRow> ultraGridRows = ((IEnumerable<UltraGridRow>) inNonGroupByRows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (item => (item.Cells["IMSField"].Value.ToString() == "Policy Number" || item.Cells["IMSField"].Value.ToString() == "Effective Date" || item.Cells["IMSField"].Value.ToString() == "(User-Defined) Account Number" || item.Cells["IMSField"].Value.ToString() == "Applied Amount" || item.Cells["IMSField"].Value.ToString() == "Invoice Number") && !item.Cells["ExcelField"].Value.ToString().Equals(string.Empty))).Select<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, UltraGridRow>) (item => item));
    if (!this.ValidateUsedFields(ultraGridRows))
      return false;
    if (!this.radioClaimsReceivable.Checked)
    {
      if (ultraGridRows.Any<UltraGridRow>((System.Func<UltraGridRow, bool>) (row => row.Cells[0]?.Value?.ToString() != "Applied Amount")))
        return true;
      int num = (int) MessageBox.Show("You must specify either the policy number and effective date, invoice number or the user defined account number to continue.", "Required Field Mappings Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((IEnumerable<UltraGridRow>) inNonGroupByRows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (item => item.Cells["IMSField"].Value.ToString() == "Claim Number" && !item.Cells["ExcelField"].Value.ToString().Equals(string.Empty))).Select<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, UltraGridRow>) (item => item)).Any<UltraGridRow>())
      return true;
    int num1 = (int) MessageBox.Show("You must specify the claim number to continue.", "Required Field Mappings Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private bool ValidateUsedFields(IEnumerable<UltraGridRow> matchedRows)
  {
    bool flag1 = matchedRows.Any<UltraGridRow>((System.Func<UltraGridRow, bool>) (row => row.Cells[0]?.Value?.ToString() == "Policy Number"));
    bool flag2 = matchedRows.Any<UltraGridRow>((System.Func<UltraGridRow, bool>) (row => row.Cells[0]?.Value?.ToString() == "Effective Date"));
    bool flag3 = matchedRows.Any<UltraGridRow>((System.Func<UltraGridRow, bool>) (row => row.Cells[0]?.Value?.ToString() == "Invoice Number"));
    bool flag4 = matchedRows.Any<UltraGridRow>((System.Func<UltraGridRow, bool>) (row => row.Cells[0]?.Value?.ToString() == "Applied Amount"));
    if (flag1 & flag2 & flag3)
    {
      int num = (int) MessageBox.Show("You must specify either the Policy Number and Effective Date fields, or the Invoice Number field, not all three fields.", "Too Many Fields Specified!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (flag1 && !flag2 || !flag1 & flag2)
    {
      int num = (int) MessageBox.Show("You must specify the Policy Number and Effective Date fields together. Alternatively, you can provide the Invoice Number field.", "Not Enough Fields Specified!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!this.radioApplyAmounts.Checked || flag4)
      return true;
    int num1 = (int) MessageBox.Show("If Apply Dollar Amount radio button is checked, you must specify the Applied Amount field.", "Specify Applied Amount Field!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private bool ValidateInputs()
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an office location to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((Control) this.textEntityName).Text.Equals(string.Empty) || ((Control) this.textEntityName).Tag == null)
    {
      int num = (int) MessageBox.Show("You must select an entity to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!this.radioApplyAmounts.Checked && !this.radioDoNotApplyAmount.Checked)
    {
      int num = (int) MessageBox.Show("You must specify whether or not the wizard should apply amounts when importing the file.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (string.IsNullOrEmpty(((Control) this.textFileName).Text))
    {
      int num = (int) MessageBox.Show("You must specify an Excel file to import.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (!this.radioAccountsPayable.Checked && !this.radioAccountsReceivable.Checked && !this.radioClaimsReceivable.Checked)
    {
      int num = (int) MessageBox.Show("You must specify either accounts payable, accounts receivable or claims receivable when importing the file.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboWorksheet).SelectedRow != null)
      return true;
    int num1 = (int) MessageBox.Show("You must specify a worksheet when importing the file.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  protected virtual void Automate()
  {
    this.ValidateSettings();
    formTransactionBuilder transactionBuilderForm = this.CreateTransactionBuilderForm();
    this.BringToFront();
    string str = this.InsertExcelValues_Bulk();
    transactionBuilderForm.MdiParent = MDIControls.Instance.MDIParent;
    transactionBuilderForm.Show();
    if (this.radioAccountsPayable.Checked)
      this.LoadPayables(transactionBuilderForm);
    if (this.radioAccountsReceivable.Checked)
      this.LoadReceivables(transactionBuilderForm);
    if (this.radioClaimsReceivable.Checked)
      this.LoadReceivablesClaims(transactionBuilderForm);
    if (this.radioApplyAmounts.Checked)
      ((IExcelAutomation) transactionBuilderForm).CheckAppliedErrors();
    ((IExcelAutomation) transactionBuilderForm).ApplyFormSettings();
    transactionBuilderForm.dataImportXML = str;
    this.Close();
  }

  protected virtual void LoadPayables(formTransactionBuilder f)
  {
    f.LoadPayables_ExcelBulk(new Guid(((Control) this.textEntityName).Tag.ToString()), ((Control) this.textEntityName).Text, int.Parse(this.comboOfficeLocation.Value.ToString()), this.radioApplyAmounts.Checked, this.excelData.Tables[0], this.GetPolicyNumberField(), this.GetInvoiceNumberField(), this.GetAppliedAmountField(), ((UltraToggleEditorBase) this.checkShowZero).Checked);
    f.OnImportCompleted(formTransactionSearch.SearchTypes.Payables);
  }

  protected virtual void LoadReceivables(formTransactionBuilder f)
  {
    f.LoadReceivables_ExcelBulk(new Guid(((Control) this.textEntityName).Tag.ToString()), ((Control) this.textEntityName).Text, int.Parse(this.comboOfficeLocation.Value.ToString()), this.radioApplyAmounts.Checked, this.excelData.Tables[0], this.GetPolicyNumberField(), this.GetInvoiceNumberField(), this.GetAppliedAmountField(), ((UltraToggleEditorBase) this.checkShowZero).Checked);
  }

  protected virtual void LoadReceivablesClaims(formTransactionBuilder f)
  {
    f.LoadReceivablesClaims_ExcelBulk(new Guid(((Control) this.textEntityName).Tag.ToString()), ((Control) this.textEntityName).Text, int.Parse(this.comboOfficeLocation.Value.ToString()), this.radioApplyAmounts.Checked, this.excelData.Tables[0], this.GetClaimNumberField(), this.GetAppliedAmountField());
  }

  protected virtual formTransactionBuilder CreateTransactionBuilderForm()
  {
    formTransactionBuilder form = (formTransactionBuilder) ObjectFactory.Instance.CreateForm(typeof (formTransactionBuilder));
    form.IsExcelAutomation = true;
    return form;
  }

  protected virtual string InsertExcelValues_Bulk()
  {
    string empty = string.Empty;
    StringBuilder stringBuilder = new StringBuilder();
    int num1 = 0;
    int count = this.excelData.Tables[0].Rows.Count;
    stringBuilder.Clear();
    stringBuilder.Append("Processing record ");
    stringBuilder.Append(num1.ToString());
    stringBuilder.Append(" of ");
    stringBuilder.Append(count.ToString());
    ++this.progressProcessing.Value;
    this.progressProcessing.Refresh();
    this.Refresh();
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "TRUNCATE TABLE tblFin_ExcelImport");
    DataTable table = DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM tblFin_ExcelImport");
    for (int index = 0; index < this.excelData.Tables[0].Rows.Count; ++index)
    {
      DataRow row = this.excelData.Tables[0].Rows[index];
      string str1 = string.Empty;
      DateTime excelEffectiveDate = DateTime.Parse("1/1/1900");
      int num2 = 0;
      string str2 = string.Empty;
      Decimal excelApplyAmount;
      if (this.radioClaimsReceivable.Checked)
      {
        excelApplyAmount = this.GetExcel_ApplyAmount(row);
        str2 = this.GetExcel_ClaimNumber(row);
      }
      else
      {
        str1 = this.GetExcel_PolicyNumber(row);
        excelEffectiveDate = this.GetExcel_EffectiveDate(row);
        num2 = this.GetExcel_InvoiceNumber(row);
        excelApplyAmount = this.GetExcel_ApplyAmount(row);
      }
      table.Rows.Add((object) str1, (object) excelEffectiveDate, (object) num2, (object) excelApplyAmount, (object) str2);
      stringBuilder.Clear();
      stringBuilder.Append("Processing record ");
      stringBuilder.Append(index.ToString());
      stringBuilder.Append(" of ");
      stringBuilder.Append(count.ToString());
    }
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        connection.Open();
        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(connection))
        {
          sqlBulkCopy.DestinationTableName = "tblFin_ExcelImport";
          sqlBulkCopy.WriteToServer(table);
        }
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblFin_ExcelImport SET PolicyNumber = NULL WHERE PolicyNumber = @p", new object[2]
        {
          (object) "@p",
          (object) ""
        });
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblFin_ExcelImport SET InvoiceNumber = NULL WHERE InvoiceNumber = @i", new object[2]
        {
          (object) "@i",
          (object) 0
        });
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblFin_ExcelImport SET ClaimNumber = NULL WHERE ClaimNumber = @c", new object[2]
        {
          (object) "@c",
          (object) ""
        });
        DefaultDatabase.ExecuteNonQuery(CommandType.Text, "UPDATE tblFin_ExcelImport SET EffectiveDate = NULL WHERE EffectiveDate = @e", new object[2]
        {
          (object) "@e",
          (object) "1/1/1900"
        });
        return Utility.DataTableToXML(DefaultDatabase.ExecuteDataTable(CommandType.Text, "SELECT * FROM tblFin_ExcelImport"));
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }

  protected string GetField(string fieldName)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (row.Cells["IMSField"].Value.ToString() == fieldName)
        return row.Cells["ExcelField"].Value.ToString();
    }
    return string.Empty;
  }

  protected string GetInsuredNameField() => this.GetField("Insured Name");

  protected string GetPolicyNumberField() => this.GetField("Policy Number");

  protected string GetInvoiceNumberField() => this.GetField("Invoice Number");

  protected string GetAppliedAmountField() => this.GetField("Applied Amount");

  private string GetEffectiveDateField() => this.GetField("Effective Date");

  private string GetUserDefinedAccountNumberField()
  {
    return this.GetField("(User-Defined) Account Number");
  }

  protected string GetClaimNumberField() => this.GetField("Claim Number");

  protected int GetExcel_InvoiceNumber(DataRow r)
  {
    string invoiceNumberField = this.GetInvoiceNumberField();
    if (invoiceNumberField.Equals(string.Empty))
      return 0;
    try
    {
      return int.Parse(r[invoiceNumberField].ToString().Trim(), NumberStyles.Any);
    }
    catch (FormatException ex)
    {
      return 0;
    }
  }

  protected string GetExcel_PolicyNumber(DataRow r)
  {
    string policyNumberField = this.GetPolicyNumberField();
    return !policyNumberField.Equals(string.Empty) ? r[policyNumberField].ToString().Trim() : string.Empty;
  }

  protected string GetExcel_InsuredName(DataRow r)
  {
    string insuredNameField = this.GetInsuredNameField();
    return !insuredNameField.Equals(string.Empty) ? r[insuredNameField].ToString().Trim() : string.Empty;
  }

  protected string GetExcel_UserDefinedAccountNumber(DataRow r)
  {
    string accountNumberField = this.GetUserDefinedAccountNumberField();
    return !accountNumberField.Equals(string.Empty) ? r[accountNumberField].ToString().Trim() : string.Empty;
  }

  protected Decimal GetExcel_ApplyAmount(DataRow r)
  {
    string appliedAmountField = this.GetAppliedAmountField();
    if (appliedAmountField.Equals(string.Empty))
      return 0M;
    try
    {
      return Decimal.Round(Decimal.Parse(r[appliedAmountField].ToString().Trim(), NumberStyles.Any), 2);
    }
    catch (FormatException ex)
    {
      return 0M;
    }
  }

  protected DateTime GetExcel_EffectiveDate(DataRow r)
  {
    string effectiveDateField = this.GetEffectiveDateField();
    if (effectiveDateField.Equals(string.Empty))
      return DateTime.Parse("1/1/1900");
    try
    {
      return DateTime.Parse(r[effectiveDateField].ToString());
    }
    catch (FormatException ex)
    {
      return DateTime.Parse("1/1/1900");
    }
  }

  protected string GetExcel_ClaimNumber(DataRow r)
  {
    string claimNumberField = this.GetClaimNumberField();
    return !claimNumberField.Equals(string.Empty) ? r[claimNumberField].ToString().Trim() : string.Empty;
  }

  private void groupExcelFileAndMappings_Enter(object sender, EventArgs e)
  {
  }

  private void checkShowZero_CheckedChanged(object sender, EventArgs e)
  {
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("FieldMappings", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("IMSField", -1, (object) "dropDownWorksheetFields");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ExcelField");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("FieldNames", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FieldName");
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    this.label1 = new Label();
    this.label2 = new Label();
    this.buttonFindExcelFile = new Button();
    this.groupExcelFileAndMappings = new GroupBox();
    this.checkFirstRowColumnNames = new MGACheckBox();
    this.comboWorksheet = new MGASimpleComboBox();
    this.label3 = new Label();
    this.textFileName = new MGATextBox();
    this.groupBox1 = new GroupBox();
    this.checkShowZero = new MGACheckBox();
    this.label6 = new Label();
    this.label4 = new Label();
    this.panel2 = new Panel();
    this.radioClaimsReceivable = new RadioButton();
    this.radioAccountsPayable = new RadioButton();
    this.radioAccountsReceivable = new RadioButton();
    this.panel1 = new Panel();
    this.radioApplyAmounts = new RadioButton();
    this.radioDoNotApplyAmount = new RadioButton();
    this.buttonSearchEntity = new Button();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.label13 = new Label();
    this.textEntityName = new MGATextBox();
    this.label5 = new Label();
    this.labelSpacer = new Label();
    this.progressProcessing = new ProgressBar();
    this.buttonImportFile = new Button();
    this.buttonCancel = new Button();
    this.labelProgress = new Label();
    this.openFileDialog1 = new OpenFileDialog();
    this.gridMappings = new UltraGrid();
    this.dsExcelImportMappings1 = new dsExcelImportMappings();
    this.dropDownWorksheetFields = new UltraDropDown();
    this.dsExcelFieldNames1 = new dsExcelFieldNames();
    this.groupExcelFileAndMappings.SuspendLayout();
    ((ISupportInitialize) this.checkFirstRowColumnNames).BeginInit();
    ((ISupportInitialize) this.comboWorksheet).BeginInit();
    ((ISupportInitialize) this.textFileName).BeginInit();
    this.groupBox1.SuspendLayout();
    ((ISupportInitialize) this.checkShowZero).BeginInit();
    this.panel2.SuspendLayout();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    ((ISupportInitialize) this.textEntityName).BeginInit();
    ((ISupportInitialize) this.gridMappings).BeginInit();
    this.dsExcelImportMappings1.BeginInit();
    ((ISupportInitialize) this.dropDownWorksheetFields).BeginInit();
    this.dsExcelFieldNames1.BeginInit();
    this.SuspendLayout();
    this.label1.BackColor = Color.FromArgb(125, 165, 225);
    this.label1.Dock = DockStyle.Top;
    this.label1.Font = new Font("Tahoma", 16f, FontStyle.Bold);
    this.label1.ForeColor = Color.WhiteSmoke;
    this.label1.Location = new Point(0, 0);
    this.label1.Name = "label1";
    this.label1.Size = new Size(388, 28);
    this.label1.TabIndex = 0;
    this.label1.Text = "EXCEL IMPORT UTILITY";
    this.label1.TextAlign = ContentAlignment.MiddleLeft;
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Font = new Font("Tahoma", 8.25f);
    this.label2.Location = new Point(6, 18);
    this.label2.Name = "label2";
    this.label2.Size = new Size(139, 13);
    this.label2.TabIndex = 11;
    this.label2.Text = "Please Specify An Excel File";
    this.buttonFindExcelFile.Image = (Image) Resources.SearchTransaction;
    this.buttonFindExcelFile.Location = new Point(359, 32 /*0x20*/);
    this.buttonFindExcelFile.Name = "buttonFindExcelFile";
    this.buttonFindExcelFile.Size = new Size(23, 23);
    this.buttonFindExcelFile.TabIndex = 12;
    this.buttonFindExcelFile.UseVisualStyleBackColor = true;
    this.buttonFindExcelFile.Click += new EventHandler(this.buttonSearchFile_Click);
    this.groupExcelFileAndMappings.BackColor = Color.Transparent;
    this.groupExcelFileAndMappings.Controls.Add((Control) this.gridMappings);
    this.groupExcelFileAndMappings.Controls.Add((Control) this.checkFirstRowColumnNames);
    this.groupExcelFileAndMappings.Controls.Add((Control) this.comboWorksheet);
    this.groupExcelFileAndMappings.Controls.Add((Control) this.label3);
    this.groupExcelFileAndMappings.Controls.Add((Control) this.dropDownWorksheetFields);
    this.groupExcelFileAndMappings.Controls.Add((Control) this.textFileName);
    this.groupExcelFileAndMappings.Controls.Add((Control) this.buttonFindExcelFile);
    this.groupExcelFileAndMappings.Controls.Add((Control) this.label2);
    this.groupExcelFileAndMappings.Dock = DockStyle.Top;
    this.groupExcelFileAndMappings.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    this.groupExcelFileAndMappings.Location = new Point(0, 265);
    this.groupExcelFileAndMappings.Margin = new Padding(8);
    this.groupExcelFileAndMappings.Name = "groupExcelFileAndMappings";
    this.groupExcelFileAndMappings.Size = new Size(388, 324);
    this.groupExcelFileAndMappings.TabIndex = 13;
    this.groupExcelFileAndMappings.TabStop = false;
    this.groupExcelFileAndMappings.Text = "Excel File / File Mappings";
    this.groupExcelFileAndMappings.Enter += new EventHandler(this.groupExcelFileAndMappings_Enter);
    ((AppearanceBase) appearance1).BorderColor = Color.Gray;
    ((AppearanceBase) appearance1).FontData.BoldAsString = "False";
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkFirstRowColumnNames).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.checkFirstRowColumnNames).Checked = true;
    ((UltraToggleEditorBase) this.checkFirstRowColumnNames).CheckState = CheckState.Checked;
    ((Control) this.checkFirstRowColumnNames).Enabled = false;
    ((UltraToggleEditorBase) this.checkFirstRowColumnNames).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkFirstRowColumnNames).Location = new Point(6, 105);
    ((Control) this.checkFirstRowColumnNames).Name = "checkFirstRowColumnNames";
    ((Control) this.checkFirstRowColumnNames).Size = new Size(244, 16 /*0x10*/);
    ((Control) this.checkFirstRowColumnNames).TabIndex = 17;
    ((Control) this.checkFirstRowColumnNames).Text = "First row has column names.";
    ((UltraControlBase) this.checkFirstRowColumnNames).UseAppStyling = false;
    ((UltraControlBase) this.checkFirstRowColumnNames).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkFirstRowColumnNames).UseOsThemes = (DefaultableBoolean) 2;
    this.comboWorksheet.BorderStyle = (UIElementBorderStyle) 4;
    this.comboWorksheet.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboWorksheet).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboWorksheet).Location = new Point(6, 78);
    this.comboWorksheet.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboWorksheet).Name = "comboWorksheet";
    ((Control) this.comboWorksheet).Size = new Size(376, 21);
    ((Control) this.comboWorksheet).TabIndex = 14;
    ((UltraControlBase) this.comboWorksheet).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboWorksheet).UseOsThemes = (DefaultableBoolean) 2;
    this.comboWorksheet.RowSelected += new RowSelectedEventHandler(this.comboWorksheet_RowSelected);
    this.label3.AutoSize = true;
    this.label3.Font = new Font("Tahoma", 8.25f);
    this.label3.Location = new Point(6, 62);
    this.label3.Name = "label3";
    this.label3.Size = new Size(106, 13);
    this.label3.TabIndex = 13;
    this.label3.Text = "Specify a Worksheet";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textFileName).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textFileName).BackColor = Color.White;
    ((Control) this.textFileName).Font = new Font("Tahoma", 8.25f);
    ((Control) this.textFileName).Location = new Point(6, 34);
    this.textFileName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textFileName).Name = "textFileName";
    ((Control) this.textFileName).Size = new Size(351, 20);
    ((Control) this.textFileName).TabIndex = 10;
    ((UltraControlBase) this.textFileName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textFileName).UseOsThemes = (DefaultableBoolean) 2;
    this.groupBox1.BackColor = Color.Transparent;
    this.groupBox1.Controls.Add((Control) this.checkShowZero);
    this.groupBox1.Controls.Add((Control) this.label6);
    this.groupBox1.Controls.Add((Control) this.label4);
    this.groupBox1.Controls.Add((Control) this.panel2);
    this.groupBox1.Controls.Add((Control) this.panel1);
    this.groupBox1.Controls.Add((Control) this.buttonSearchEntity);
    this.groupBox1.Controls.Add((Control) this.comboOfficeLocation);
    this.groupBox1.Controls.Add((Control) this.label13);
    this.groupBox1.Controls.Add((Control) this.textEntityName);
    this.groupBox1.Controls.Add((Control) this.label5);
    this.groupBox1.Dock = DockStyle.Top;
    this.groupBox1.Font = new Font("Tahoma", 8.25f, FontStyle.Bold);
    this.groupBox1.Location = new Point(0, 38);
    this.groupBox1.Margin = new Padding(8);
    this.groupBox1.Name = "groupBox1";
    this.groupBox1.Size = new Size(388, 227);
    this.groupBox1.TabIndex = 14;
    this.groupBox1.TabStop = false;
    this.groupBox1.Text = "Office Location / Entity / Search Type";
    ((AppearanceBase) appearance3).BorderColor = Color.Gray;
    ((AppearanceBase) appearance3).FontData.BoldAsString = "False";
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkShowZero).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.checkShowZero).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.StandardCheckBoxGlyphInfo;
    ((Control) this.checkShowZero).Location = new Point(8, 201);
    ((Control) this.checkShowZero).Name = "checkShowZero";
    ((Control) this.checkShowZero).Size = new Size(244, 16 /*0x10*/);
    ((Control) this.checkShowZero).TabIndex = 19;
    ((Control) this.checkShowZero).Text = "Load net-zero invoices";
    ((UltraControlBase) this.checkShowZero).UseAppStyling = false;
    ((UltraControlBase) this.checkShowZero).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.checkShowZero).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraToggleEditorBase) this.checkShowZero).CheckedChanged += new EventHandler(this.checkShowZero_CheckedChanged);
    this.label6.AutoSize = true;
    this.label6.Font = new Font("Tahoma", 8.25f);
    this.label6.Location = new Point(6, 158);
    this.label6.Name = "label6";
    this.label6.Size = new Size(90, 13);
    this.label6.TabIndex = 22;
    this.label6.Text = "Import Behaviour";
    this.label4.AutoSize = true;
    this.label4.Font = new Font("Tahoma", 8.25f);
    this.label4.Location = new Point(6, 108);
    this.label4.Name = "label4";
    this.label4.Size = new Size(67, 13);
    this.label4.TabIndex = 21;
    this.label4.Text = "Search Type";
    this.panel2.Controls.Add((Control) this.radioClaimsReceivable);
    this.panel2.Controls.Add((Control) this.radioAccountsPayable);
    this.panel2.Controls.Add((Control) this.radioAccountsReceivable);
    this.panel2.Location = new Point(6, 124);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(370, 28);
    this.panel2.TabIndex = 20;
    this.radioClaimsReceivable.AutoSize = true;
    this.radioClaimsReceivable.FlatStyle = FlatStyle.Flat;
    this.radioClaimsReceivable.Font = new Font("Tahoma", 8.25f);
    this.radioClaimsReceivable.Location = new Point(247, 3);
    this.radioClaimsReceivable.Name = "radioClaimsReceivable";
    this.radioClaimsReceivable.Size = new Size(109, 17);
    this.radioClaimsReceivable.TabIndex = 11;
    this.radioClaimsReceivable.Text = "Claims Receivable";
    this.radioClaimsReceivable.Visible = false;
    this.radioAccountsPayable.AutoSize = true;
    this.radioAccountsPayable.FlatStyle = FlatStyle.Flat;
    this.radioAccountsPayable.Font = new Font("Tahoma", 8.25f);
    this.radioAccountsPayable.Location = new Point(135, 3);
    this.radioAccountsPayable.Name = "radioAccountsPayable";
    this.radioAccountsPayable.Size = new Size(109, 17);
    this.radioAccountsPayable.TabIndex = 10;
    this.radioAccountsPayable.Text = "Accounts Payable";
    this.radioAccountsReceivable.AutoSize = true;
    this.radioAccountsReceivable.Checked = true;
    this.radioAccountsReceivable.FlatStyle = FlatStyle.Flat;
    this.radioAccountsReceivable.Font = new Font("Tahoma", 8.25f);
    this.radioAccountsReceivable.Location = new Point(5, 3);
    this.radioAccountsReceivable.Name = "radioAccountsReceivable";
    this.radioAccountsReceivable.Size = new Size(123, 17);
    this.radioAccountsReceivable.TabIndex = 9;
    this.radioAccountsReceivable.TabStop = true;
    this.radioAccountsReceivable.Text = "Accounts Receivable";
    this.panel1.Controls.Add((Control) this.radioApplyAmounts);
    this.panel1.Controls.Add((Control) this.radioDoNotApplyAmount);
    this.panel1.Location = new Point(5, 174);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(265, 26);
    this.panel1.TabIndex = 19;
    this.radioApplyAmounts.AutoSize = true;
    this.radioApplyAmounts.CheckAlign = ContentAlignment.TopLeft;
    this.radioApplyAmounts.Checked = true;
    this.radioApplyAmounts.FlatStyle = FlatStyle.Flat;
    this.radioApplyAmounts.Font = new Font("Tahoma", 8.25f);
    this.radioApplyAmounts.Location = new Point(4, 3);
    this.radioApplyAmounts.Name = "radioApplyAmounts";
    this.radioApplyAmounts.Size = new Size(121, 17);
    this.radioApplyAmounts.TabIndex = 14;
    this.radioApplyAmounts.TabStop = true;
    this.radioApplyAmounts.Text = "Apply Dollar Amount";
    this.radioApplyAmounts.TextAlign = ContentAlignment.TopLeft;
    this.radioDoNotApplyAmount.AutoSize = true;
    this.radioDoNotApplyAmount.CheckAlign = ContentAlignment.TopLeft;
    this.radioDoNotApplyAmount.FlatStyle = FlatStyle.Flat;
    this.radioDoNotApplyAmount.Font = new Font("Tahoma", 8.25f);
    this.radioDoNotApplyAmount.Location = new Point(133, 3);
    this.radioDoNotApplyAmount.Name = "radioDoNotApplyAmount";
    this.radioDoNotApplyAmount.Size = new Size(110, 17);
    this.radioDoNotApplyAmount.TabIndex = 15;
    this.radioDoNotApplyAmount.Text = "Load Invoice Only";
    this.radioDoNotApplyAmount.TextAlign = ContentAlignment.TopLeft;
    this.buttonSearchEntity.Image = (Image) Resources.SearchTransaction;
    this.buttonSearchEntity.Location = new Point(359, 80 /*0x50*/);
    this.buttonSearchEntity.Name = "buttonSearchEntity";
    this.buttonSearchEntity.Size = new Size(23, 23);
    this.buttonSearchEntity.TabIndex = 18;
    this.buttonSearchEntity.UseVisualStyleBackColor = true;
    this.buttonSearchEntity.Click += new EventHandler(this.buttonSearchEntity_Click);
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Font = new Font("Tahoma", 8.25f);
    ((Control) this.comboOfficeLocation).Location = new Point(5, 39);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(377, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 17;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    this.label13.AutoSize = true;
    this.label13.Font = new Font("Tahoma", 8.25f);
    this.label13.Location = new Point(5, 23);
    this.label13.Name = "label13";
    this.label13.Size = new Size(79, 13);
    this.label13.TabIndex = 16 /*0x10*/;
    this.label13.Text = "Office Location";
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textEntityName).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textEntityName).BackColor = Color.White;
    ((Control) this.textEntityName).Font = new Font("Tahoma", 8.25f);
    ((Control) this.textEntityName).Location = new Point(5, 82);
    this.textEntityName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textEntityName).Name = "textEntityName";
    ((EditorButtonControlBase) this.textEntityName).ReadOnly = true;
    ((Control) this.textEntityName).Size = new Size(352, 20);
    ((Control) this.textEntityName).TabIndex = 13;
    ((UltraControlBase) this.textEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textEntityName).UseOsThemes = (DefaultableBoolean) 2;
    this.label5.AutoSize = true;
    this.label5.Font = new Font("Tahoma", 8.25f);
    this.label5.Location = new Point(5, 66);
    this.label5.Name = "label5";
    this.label5.Size = new Size(65, 13);
    this.label5.TabIndex = 12;
    this.label5.Text = "Entity Name";
    this.labelSpacer.BackColor = Color.Transparent;
    this.labelSpacer.Dock = DockStyle.Top;
    this.labelSpacer.Font = new Font("Tahoma", 16f, FontStyle.Bold);
    this.labelSpacer.ForeColor = Color.LightGray;
    this.labelSpacer.Location = new Point(0, 28);
    this.labelSpacer.Name = "labelSpacer";
    this.labelSpacer.Size = new Size(388, 10);
    this.labelSpacer.TabIndex = 15;
    this.progressProcessing.Location = new Point(8, 606);
    this.progressProcessing.Name = "progressProcessing";
    this.progressProcessing.Size = new Size(205, 10);
    this.progressProcessing.TabIndex = 16 /*0x10*/;
    this.progressProcessing.Visible = false;
    this.buttonImportFile.Image = (Image) Resources.Excel;
    this.buttonImportFile.ImageAlign = ContentAlignment.MiddleLeft;
    this.buttonImportFile.Location = new Point(222, 593);
    this.buttonImportFile.Name = "buttonImportFile";
    this.buttonImportFile.Size = new Size(86, 23);
    this.buttonImportFile.TabIndex = 17;
    this.buttonImportFile.Text = "&Import File";
    this.buttonImportFile.TextAlign = ContentAlignment.MiddleRight;
    this.buttonImportFile.UseVisualStyleBackColor = true;
    this.buttonImportFile.Click += new EventHandler(this.buttonImportFile_Click);
    this.buttonCancel.DialogResult = DialogResult.Cancel;
    this.buttonCancel.Image = (Image) Resources.delete;
    this.buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
    this.buttonCancel.Location = new Point(314, 593);
    this.buttonCancel.Name = "buttonCancel";
    this.buttonCancel.Size = new Size(68, 23);
    this.buttonCancel.TabIndex = 18;
    this.buttonCancel.Text = "&Cancel";
    this.buttonCancel.TextAlign = ContentAlignment.MiddleRight;
    this.buttonCancel.UseVisualStyleBackColor = true;
    this.buttonCancel.Click += new EventHandler(this.buttonCancel_Click);
    this.labelProgress.AutoSize = true;
    this.labelProgress.BackColor = Color.Transparent;
    this.labelProgress.Location = new Point(6, 589);
    this.labelProgress.Name = "labelProgress";
    this.labelProgress.Size = new Size(82, 13);
    this.labelProgress.TabIndex = 19;
    this.labelProgress.Text = "Importing file...";
    this.labelProgress.Visible = false;
    this.openFileDialog1.DefaultExt = "xls";
    this.openFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx|Excel Files 97-2003(*.xls)|*.xls";
    this.openFileDialog1.InitialDirectory = "C:\\";
    this.openFileDialog1.Title = "Specify the Excel File to Open";
    ((UltraGridBase) this.gridMappings).DataMember = "FieldMappings";
    ((UltraGridBase) this.gridMappings).DataSource = (object) this.dsExcelImportMappings1;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridMappings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridColumn1.CellButtonAppearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Accounting Worksheet Field";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 181;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ultraGridColumn2.CellButtonAppearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Excel Worksheet Field";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 5;
    ultraGridColumn2.Width = 190;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.gridMappings).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridMappings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance10).FontData.BoldAsString = "False";
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance12).FontData.BoldAsString = "False";
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance13).BackColor = Color.Transparent;
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance14).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridMappings).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridMappings).Location = new Point(9, (int) sbyte.MaxValue);
    ((Control) this.gridMappings).Name = "gridMappings";
    ((Control) this.gridMappings).Size = new Size(373, 184);
    ((Control) this.gridMappings).TabIndex = 18;
    this.gridMappings.UpdateMode = (UpdateMode) 2;
    ((UltraControlBase) this.gridMappings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridMappings).UseOsThemes = (DefaultableBoolean) 2;
    this.dsExcelImportMappings1.DataSetName = "dsExcelImportMappings";
    this.dsExcelImportMappings1.Locale = new CultureInfo("en-US");
    ((UltraGridBase) this.dropDownWorksheetFields).DataMember = "FieldNames";
    ((UltraGridBase) this.dropDownWorksheetFields).DataSource = (object) this.dsExcelFieldNames1;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Appearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 0;
    ultraGridColumn3.Width = 206;
    ultraGridBand2.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance17).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance18).BorderColor = Color.LightGray;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance20).BackColor = Color.White;
    ((AppearanceBase) appearance20).BorderColor = Color.White;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BorderColor = Color.White;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance22).BackColor = Color.Transparent;
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance23).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance23;
    ((AppearanceBase) appearance24).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.dropDownWorksheetFields).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.dropDownWorksheetFields).DisplayMember = "FieldName";
    ((Control) this.dropDownWorksheetFields).Font = new Font("Tahoma", 8.25f);
    ((Control) this.dropDownWorksheetFields).Location = new Point(150, 190);
    ((Control) this.dropDownWorksheetFields).Name = "dropDownWorksheetFields";
    ((Control) this.dropDownWorksheetFields).Size = new Size(208 /*0xD0*/, 80 /*0x50*/);
    ((Control) this.dropDownWorksheetFields).TabIndex = 16 /*0x10*/;
    ((Control) this.dropDownWorksheetFields).Text = "ultraDropDown1";
    ((UltraControlBase) this.dropDownWorksheetFields).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dropDownWorksheetFields).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.dropDownWorksheetFields).ValueMember = "FieldName";
    ((Control) this.dropDownWorksheetFields).Visible = false;
    this.dsExcelFieldNames1.DataSetName = "dsExcelFieldNames";
    this.dsExcelFieldNames1.Locale = new CultureInfo("en-US");
    this.AcceptButton = (IButtonControl) this.buttonImportFile;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.CancelButton = (IButtonControl) this.buttonCancel;
    this.ClientSize = new Size(388, 627);
    this.Controls.Add((Control) this.progressProcessing);
    this.Controls.Add((Control) this.labelProgress);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonImportFile);
    this.Controls.Add((Control) this.groupExcelFileAndMappings);
    this.Controls.Add((Control) this.groupBox1);
    this.Controls.Add((Control) this.labelSpacer);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormExcelImport);
    this.Text = "Excel AR/AP Import Utility";
    this.Load += new EventHandler(this.FormExcelImport_Load);
    this.groupExcelFileAndMappings.ResumeLayout(false);
    this.groupExcelFileAndMappings.PerformLayout();
    ((ISupportInitialize) this.checkFirstRowColumnNames).EndInit();
    ((ISupportInitialize) this.comboWorksheet).EndInit();
    ((ISupportInitialize) this.textFileName).EndInit();
    this.groupBox1.ResumeLayout(false);
    this.groupBox1.PerformLayout();
    ((ISupportInitialize) this.checkShowZero).EndInit();
    this.panel2.ResumeLayout(false);
    this.panel2.PerformLayout();
    this.panel1.ResumeLayout(false);
    this.panel1.PerformLayout();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    ((ISupportInitialize) this.textEntityName).EndInit();
    ((ISupportInitialize) this.gridMappings).EndInit();
    this.dsExcelImportMappings1.EndInit();
    ((ISupportInitialize) this.dropDownWorksheetFields).EndInit();
    this.dsExcelFieldNames1.EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
