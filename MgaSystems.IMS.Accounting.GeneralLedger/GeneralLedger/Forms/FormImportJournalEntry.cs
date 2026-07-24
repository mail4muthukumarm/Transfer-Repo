// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.FormImportJournalEntry
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.IMS.Accounting.GeneralLedger.Properties;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

public class FormImportJournalEntry : FormBase
{
  protected Workbook _workbook;
  protected string _fileName;
  private int _glCompanyId;
  private string _worksheetName;
  protected DataTable dt;
  private IContainer components;
  private Label label1;
  protected Label lblFileName;
  private Label label2;
  private MGASimpleComboBox comboGLCompany;
  private Label label3;
  private Label label4;
  private Label label5;
  private Label label6;
  private MGASimpleComboBox comboGLAccount;
  private MGASimpleComboBox comboDebit;
  private MGASimpleComboBox comboCredit;
  protected MGAButton buttonImport;
  protected MGAButton buttonCancel;
  private MGASimpleComboBox comboWorksheet;
  private Label label7;
  protected MGACheckBox checkFirstrowColumnNames;
  private MGASimpleComboBox comboComment;
  private Label label8;
  private MGASimpleComboBox comboCostCenters;
  private Label label9;

  public int GLCompanyId
  {
    get => (int) ((UltraDropDownBase) this.comboGLCompany).SelectedRow.Cells["ID"].Value;
  }

  public string WorksheetName => this._worksheetName;

  public int GLAccountColumn
  {
    get => (int) ((UltraDropDownBase) this.comboGLAccount).SelectedRow.Cells["value"].Value;
  }

  public int CommentColumn
  {
    get
    {
      return ((UltraDropDownBase) this.comboComment).SelectedRow != null ? (int) ((UltraDropDownBase) this.comboComment).SelectedRow.Cells["value"].Value : -1;
    }
  }

  public int DebitAmountColumn
  {
    get => (int) ((UltraDropDownBase) this.comboDebit).SelectedRow.Cells["value"].Value;
  }

  public int CreditAmountColumn
  {
    get => (int) ((UltraDropDownBase) this.comboCredit).SelectedRow.Cells["value"].Value;
  }

  public bool FirstRowColumnNames
  {
    get => ((UltraToggleEditorBase) this.checkFirstrowColumnNames).Checked;
  }

  public int CostCenterColumn
  {
    get
    {
      return ((UltraDropDownBase) this.comboCostCenters).SelectedRow != null ? (int) ((UltraDropDownBase) this.comboCostCenters).SelectedRow.Cells["value"].Value : -1;
    }
  }

  public FormImportJournalEntry(string fileName, Workbook workbook)
  {
    this.InitializeComponent();
    this._fileName = fileName;
    this._workbook = workbook;
    this.lblFileName.Text = fileName;
  }

  public FormImportJournalEntry() => this.InitializeComponent();

  private void LoadWorksheets()
  {
    DataTable dataTable = new DataTable("Worksheets");
    dataTable.Columns.AddRange(new DataColumn[2]
    {
      new DataColumn("value", typeof (string)),
      new DataColumn("display", typeof (string))
    });
    foreach (Worksheet worksheet in (IEnumerable<Worksheet>) this._workbook.Worksheets)
      dataTable.Rows.Add((object) worksheet.Name, (object) worksheet.Name);
    ((UltraGridBase) this.comboWorksheet).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboWorksheet).ValueMember = "value";
    ((UltraDropDownBase) this.comboWorksheet).DisplayMember = "display";
  }

  protected virtual void LoadWorksheetFields(string workSheetName)
  {
    this.dt = new DataTable("Fields");
    this.dt.Columns.AddRange(new DataColumn[2]
    {
      new DataColumn("value", typeof (int)),
      new DataColumn("display", typeof (string))
    });
    for (int index = 0; index <= this._workbook.Worksheets[workSheetName].Cells.MaxDataColumn; ++index)
    {
      if (!((UltraToggleEditorBase) this.checkFirstrowColumnNames).Checked)
        this.dt.Rows.Add((object) index, (object) this._workbook.Worksheets[workSheetName].Cells[0, index].Name);
      else
        this.dt.Rows.Add((object) index, (object) this._workbook.Worksheets[workSheetName].Cells[0, index].StringValue);
    }
    ((UltraGridBase) this.comboGLAccount).DataSource = (object) this.dt;
    ((UltraDropDownBase) this.comboGLAccount).ValueMember = "value";
    ((UltraDropDownBase) this.comboGLAccount).DisplayMember = "display";
    ((UltraGridBase) this.comboDebit).DataSource = (object) this.dt.Copy();
    ((UltraDropDownBase) this.comboDebit).ValueMember = "value";
    ((UltraDropDownBase) this.comboDebit).DisplayMember = "display";
    ((UltraGridBase) this.comboCredit).DataSource = (object) this.dt.Copy();
    ((UltraDropDownBase) this.comboCredit).ValueMember = "value";
    ((UltraDropDownBase) this.comboCredit).DisplayMember = "display";
    DataTable dataTable = this.dt.Copy();
    ((UltraGridBase) this.comboComment).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboComment).ValueMember = "value";
    ((UltraDropDownBase) this.comboComment).DisplayMember = "display";
    this.dt.Copy();
    ((UltraGridBase) this.comboCostCenters).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboCostCenters).ValueMember = "value";
    ((UltraDropDownBase) this.comboCostCenters).DisplayMember = "display";
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void LoadGLCompanies()
  {
    DataSet officeLocationDataset = (DataSet) Methods.GetOfficeLocationDataset();
    ((UltraGridBase) this.comboGLCompany).DataSource = (object) officeLocationDataset;
    ((UltraDropDownBase) this.comboGLCompany).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboGLCompany).ValueMember = "ID";
    this.comboGLCompany.Value = officeLocationDataset.Tables[0].Rows[0]["ID"];
    this._glCompanyId = (int) officeLocationDataset.Tables[0].Rows[0]["ID"];
  }

  private void FormImportJournalEntry_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadGLCompanies();
    this.LoadWorksheets();
  }

  private void comboWorksheet_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this._worksheetName = ((UltraDropDownBase) this.comboWorksheet).SelectedRow.Cells["value"].Value.ToString();
    this.LoadWorksheetFields(this._worksheetName);
  }

  private void checkFirstrowColumnNames_CheckedChanged(object sender, EventArgs e)
  {
    this.LoadWorksheetFields(this._worksheetName);
  }

  private bool ValidateForm()
  {
    if (((UltraDropDownBase) this.comboGLCompany).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a GL Company to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboWorksheet).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a worksheet to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboGLAccount).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a GL account column to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboDebit).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a debit column to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboCredit).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must specify a credit column to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.comboCredit.Value.ToString() == this.comboDebit.Value.ToString() || this.comboCredit.Value.ToString() == this.comboGLAccount.Value.ToString() || this.comboDebit.Value.ToString() == this.comboGLAccount.Value.ToString())
    {
      int num = (int) MessageBox.Show("The GL account, credit and debit columns must all be unique columns.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    for (int index = 0; index < this._workbook.Worksheets[this._worksheetName].Cells.MaxDataRow; ++index)
    {
      if (!int.TryParse(this._workbook.Worksheets[this._worksheetName].Cells[((UltraToggleEditorBase) this.checkFirstrowColumnNames).Checked ? index + 1 : index, (int) ((UltraDropDownBase) this.comboGLAccount).SelectedRow.Cells["value"].Value].Value.ToString(), out int _))
      {
        int num = (int) MessageBox.Show("The file contains GL accounts that cannot be converted to an integer. Please select a different column or modify the data.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    for (int index = 0; index < this._workbook.Worksheets[this._worksheetName].Cells.MaxDataRow; ++index)
    {
      if (this._workbook.Worksheets[this._worksheetName].Cells[((UltraToggleEditorBase) this.checkFirstrowColumnNames).Checked ? index + 1 : index, (int) ((UltraDropDownBase) this.comboDebit).SelectedRow.Cells["value"].Value].Value != null && !Decimal.TryParse(this._workbook.Worksheets[this._worksheetName].Cells[((UltraToggleEditorBase) this.checkFirstrowColumnNames).Checked ? index + 1 : index, (int) ((UltraDropDownBase) this.comboDebit).SelectedRow.Cells["value"].Value].Value.ToString(), out Decimal _))
      {
        int num = (int) MessageBox.Show("The file contains debit amounts that cannot be converted to a decimal. Please select a different column or modify the data.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    for (int index = 0; index < this._workbook.Worksheets[this._worksheetName].Cells.MaxDataRow; ++index)
    {
      if (this._workbook.Worksheets[this._worksheetName].Cells[((UltraToggleEditorBase) this.checkFirstrowColumnNames).Checked ? index + 1 : index, (int) ((UltraDropDownBase) this.comboCredit).SelectedRow.Cells["value"].Value].Value != null && !Decimal.TryParse(this._workbook.Worksheets[this._worksheetName].Cells[((UltraToggleEditorBase) this.checkFirstrowColumnNames).Checked ? index + 1 : index, (int) ((UltraDropDownBase) this.comboCredit).SelectedRow.Cells["value"].Value].Value.ToString(), out Decimal _))
      {
        int num = (int) MessageBox.Show("The file contains credit amounts that cannot be converted to a decimal. Please select a different column or modify the data.", "Invalid Entry!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return false;
      }
    }
    return true;
  }

  private void buttonImport_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    this.DialogResult = DialogResult.OK;
  }

  private void comboGLCompany_RowSelected(object sender, RowSelectedEventArgs e)
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
    this.label1 = new Label();
    this.lblFileName = new Label();
    this.label2 = new Label();
    this.comboGLCompany = new MGASimpleComboBox();
    this.label3 = new Label();
    this.label4 = new Label();
    this.label5 = new Label();
    this.label6 = new Label();
    this.comboGLAccount = new MGASimpleComboBox();
    this.comboDebit = new MGASimpleComboBox();
    this.comboCredit = new MGASimpleComboBox();
    this.buttonImport = new MGAButton();
    this.buttonCancel = new MGAButton();
    this.comboWorksheet = new MGASimpleComboBox();
    this.label7 = new Label();
    this.checkFirstrowColumnNames = new MGACheckBox();
    this.comboComment = new MGASimpleComboBox();
    this.label8 = new Label();
    this.comboCostCenters = new MGASimpleComboBox();
    this.label9 = new Label();
    ((ISupportInitialize) this.comboGLCompany).BeginInit();
    ((ISupportInitialize) this.comboGLAccount).BeginInit();
    ((ISupportInitialize) this.comboDebit).BeginInit();
    ((ISupportInitialize) this.comboCredit).BeginInit();
    ((ISupportInitialize) this.buttonImport).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.comboWorksheet).BeginInit();
    ((ISupportInitialize) this.checkFirstrowColumnNames).BeginInit();
    ((ISupportInitialize) this.comboComment).BeginInit();
    ((ISupportInitialize) this.comboCostCenters).BeginInit();
    this.SuspendLayout();
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(7, 10);
    this.label1.Name = "label1";
    this.label1.Size = new Size(27, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "File:";
    this.lblFileName.BackColor = Color.Transparent;
    this.lblFileName.Location = new Point(40, 10);
    this.lblFileName.Name = "lblFileName";
    this.lblFileName.Size = new Size(319, 41);
    this.lblFileName.TabIndex = 0;
    this.lblFileName.Text = "label2";
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(7, 57);
    this.label2.Name = "label2";
    this.label2.Size = new Size(71, 13);
    this.label2.TabIndex = 2;
    this.label2.Text = "GL Company:";
    this.comboGLCompany.BorderStyle = (UIElementBorderStyle) 4;
    this.comboGLCompany.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboGLCompany).Location = new Point(88, 57);
    this.comboGLCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLCompany).Name = "comboGLCompany";
    ((Control) this.comboGLCompany).Size = new Size(271, 21);
    ((Control) this.comboGLCompany).TabIndex = 3;
    ((UltraControlBase) this.comboGLCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLCompany).UseOsThemes = (DefaultableBoolean) 2;
    this.comboGLCompany.RowSelected += new RowSelectedEventHandler(this.comboGLCompany_RowSelected);
    this.label3.AutoSize = true;
    this.label3.BackColor = Color.Transparent;
    this.label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold | FontStyle.Underline);
    this.label3.Location = new Point(7, 115);
    this.label3.Name = "label3";
    this.label3.Size = new Size(61, 13);
    this.label3.TabIndex = 6;
    this.label3.Text = "Mappings";
    this.label4.AutoSize = true;
    this.label4.BackColor = Color.Transparent;
    this.label4.Location = new Point(7, 135);
    this.label4.Name = "label4";
    this.label4.Size = new Size(65, 13);
    this.label4.TabIndex = 8;
    this.label4.Text = "GL Account:";
    this.label5.AutoSize = true;
    this.label5.BackColor = Color.Transparent;
    this.label5.Location = new Point(7, 189);
    this.label5.Name = "label5";
    this.label5.Size = new Size(80 /*0x50*/, 13);
    this.label5.TabIndex = 12;
    this.label5.Text = "Credit Amount:";
    this.label6.AutoSize = true;
    this.label6.BackColor = Color.Transparent;
    this.label6.Location = new Point(7, 162);
    this.label6.Name = "label6";
    this.label6.Size = new Size(76, 13);
    this.label6.TabIndex = 10;
    this.label6.Text = "Debit Amount:";
    this.comboGLAccount.BorderStyle = (UIElementBorderStyle) 4;
    this.comboGLAccount.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboGLAccount).Location = new Point(88, 135);
    this.comboGLAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGLAccount).Name = "comboGLAccount";
    ((Control) this.comboGLAccount).Size = new Size(271, 21);
    ((Control) this.comboGLAccount).TabIndex = 9;
    ((UltraControlBase) this.comboGLAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGLAccount).UseOsThemes = (DefaultableBoolean) 2;
    this.comboDebit.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDebit.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDebit).Location = new Point(88, 162);
    this.comboDebit.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboDebit).Name = "comboDebit";
    ((Control) this.comboDebit).Size = new Size(271, 21);
    ((Control) this.comboDebit).TabIndex = 11;
    ((UltraControlBase) this.comboDebit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboDebit).UseOsThemes = (DefaultableBoolean) 2;
    this.comboCredit.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCredit.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCredit).Location = new Point(88, 189);
    this.comboCredit.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCredit).Name = "comboCredit";
    ((Control) this.comboCredit).Size = new Size(271, 21);
    ((Control) this.comboCredit).TabIndex = 13;
    ((UltraControlBase) this.comboCredit).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCredit).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).Image = (object) Resources.pencil_go;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonImport).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonImport).Location = new Point(147, 284);
    ((Control) this.buttonImport).Name = "buttonImport";
    ((Control) this.buttonImport).Size = new Size(103, 25);
    ((Control) this.buttonImport).TabIndex = 18;
    ((Control) this.buttonImport).Text = "Import Entry";
    ((UltraControlBase) this.buttonImport).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonImport).Click += new EventHandler(this.buttonImport_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = (object) Resources.delete;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonCancel).Location = new Point(256 /*0x0100*/, 284);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(103, 25);
    ((Control) this.buttonCancel).TabIndex = 19;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    this.comboWorksheet.BorderStyle = (UIElementBorderStyle) 4;
    this.comboWorksheet.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboWorksheet).Location = new Point(88, 84);
    this.comboWorksheet.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboWorksheet).Name = "comboWorksheet";
    ((Control) this.comboWorksheet).Size = new Size(271, 21);
    ((Control) this.comboWorksheet).TabIndex = 5;
    ((UltraControlBase) this.comboWorksheet).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboWorksheet).UseOsThemes = (DefaultableBoolean) 2;
    this.comboWorksheet.RowSelected += new RowSelectedEventHandler(this.comboWorksheet_RowSelected);
    this.label7.AutoSize = true;
    this.label7.BackColor = Color.Transparent;
    this.label7.Location = new Point(7, 84);
    this.label7.Name = "label7";
    this.label7.Size = new Size(63 /*0x3F*/, 13);
    this.label7.TabIndex = 4;
    this.label7.Text = "Worksheet:";
    ((AppearanceBase) appearance3).BorderColor = Color.Gray;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkFirstrowColumnNames).Appearance = (AppearanceBase) appearance3;
    ((Control) this.checkFirstrowColumnNames).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkFirstrowColumnNames).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkFirstrowColumnNames).Checked = true;
    ((UltraToggleEditorBase) this.checkFirstrowColumnNames).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.checkFirstrowColumnNames).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkFirstrowColumnNames).Location = new Point(88, 115);
    ((Control) this.checkFirstrowColumnNames).Name = "checkFirstrowColumnNames";
    ((Control) this.checkFirstrowColumnNames).Size = new Size(183, 20);
    ((Control) this.checkFirstrowColumnNames).TabIndex = 7;
    ((Control) this.checkFirstrowColumnNames).Text = "First row has columns names.";
    ((UltraToggleEditorBase) this.checkFirstrowColumnNames).CheckedChanged += new EventHandler(this.checkFirstrowColumnNames_CheckedChanged);
    this.comboComment.BorderStyle = (UIElementBorderStyle) 4;
    this.comboComment.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboComment).Location = new Point(88, 243);
    this.comboComment.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboComment).Name = "comboComment";
    ((Control) this.comboComment).Size = new Size(271, 21);
    ((Control) this.comboComment).TabIndex = 17;
    ((UltraControlBase) this.comboComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboComment).UseOsThemes = (DefaultableBoolean) 2;
    this.label8.AutoSize = true;
    this.label8.BackColor = Color.Transparent;
    this.label8.Location = new Point(7, 243);
    this.label8.Name = "label8";
    this.label8.Size = new Size(56, 13);
    this.label8.TabIndex = 16 /*0x10*/;
    this.label8.Text = "Comment:";
    this.comboCostCenters.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenters.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenters).Location = new Point(88, 216);
    this.comboCostCenters.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenters).Name = "comboCostCenters";
    ((Control) this.comboCostCenters).Size = new Size(271, 21);
    ((Control) this.comboCostCenters).TabIndex = 15;
    ((UltraControlBase) this.comboCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    this.label9.AutoSize = true;
    this.label9.BackColor = Color.Transparent;
    this.label9.Location = new Point(7, 216);
    this.label9.Name = "label9";
    this.label9.Size = new Size(69, 13);
    this.label9.TabIndex = 14;
    this.label9.Text = "Cost Center:";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(366, 320);
    this.ControlBox = false;
    this.Controls.Add((Control) this.comboCostCenters);
    this.Controls.Add((Control) this.label9);
    this.Controls.Add((Control) this.comboComment);
    this.Controls.Add((Control) this.label8);
    this.Controls.Add((Control) this.comboGLAccount);
    this.Controls.Add((Control) this.checkFirstrowColumnNames);
    this.Controls.Add((Control) this.comboWorksheet);
    this.Controls.Add((Control) this.label7);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.buttonImport);
    this.Controls.Add((Control) this.comboCredit);
    this.Controls.Add((Control) this.comboDebit);
    this.Controls.Add((Control) this.label6);
    this.Controls.Add((Control) this.label5);
    this.Controls.Add((Control) this.label4);
    this.Controls.Add((Control) this.label3);
    this.Controls.Add((Control) this.comboGLCompany);
    this.Controls.Add((Control) this.label2);
    this.Controls.Add((Control) this.lblFileName);
    this.Controls.Add((Control) this.label1);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormImportJournalEntry);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Import Journal Entry";
    this.Load += new EventHandler(this.FormImportJournalEntry_Load);
    ((ISupportInitialize) this.comboGLCompany).EndInit();
    ((ISupportInitialize) this.comboGLAccount).EndInit();
    ((ISupportInitialize) this.comboDebit).EndInit();
    ((ISupportInitialize) this.comboCredit).EndInit();
    ((ISupportInitialize) this.buttonImport).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.comboWorksheet).EndInit();
    ((ISupportInitialize) this.checkFirstrowColumnNames).EndInit();
    ((ISupportInitialize) this.comboComment).EndInit();
    ((ISupportInitialize) this.comboCostCenters).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
