// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.NewExpense
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class NewExpense : UserControl
{
  private dsExpenseCategoriesAll dsExpenseCategoriesAll1;
  private dsExpenses dsExpenses1;
  private SqlDataAdapter daGetExpenses;
  private SqlConnection ControlDataConnection;
  private SqlDataAdapter daGetExpenseCategories;
  private SqlCommand sqlSelectCommand2;
  internal UltraGrid gridExpenses;
  internal ContextMenu ContextMenu1;
  internal MenuItem menuAssignDefaultGLAccount;
  internal MenuItem menuDeleteExpense;
  private dsOfficeLocations dsOfficeLocations1;
  private SqlCommand sqlSelectCommand3;
  private SqlDataAdapter daGetOfficeLocations;
  private SqlCommand sqlSelectCommand1;
  private SqlCommand sqlInsertCommand1;
  private SqlCommand sqlUpdateCommand1;
  private SqlCommand sqlDeleteCommand1;
  private MGAGroupBox mgaGroupBox1;
  private Panel panel1;
  private Label labelExpenseCategory;
  private MGATextBox textExpenseName;
  private MGATextBox textExpenseDescription;
  private MGASimpleComboBox comboExpenseCategory;
  private MGASystems.Tools.DBSaveUI.DBSaveUI saveControl;
  private Label labelExpenseName;
  private Label labelExpenseDescription;
  private System.ComponentModel.Container components;
  private bool _isSaving;

  public NewExpense()
  {
    this.InitializeComponent();
    this.Dock = DockStyle.Fill;
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetExpenseCategories.Fill((DataTable) this.dsExpenseCategoriesAll1.ExpenseCategories);
    this.daGetExpenses.Fill((DataTable) this.dsExpenses1.Expenses);
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
    UltraGridBand ultraGridBand = new UltraGridBand("Expenses", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ExpenseCode");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ExpenseCategoryId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CategoryName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ExpenseName");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("SystemDefined");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (NewExpense));
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    this.gridExpenses = new UltraGrid();
    this.dsExpenses1 = new dsExpenses();
    this.dsExpenseCategoriesAll1 = new dsExpenseCategoriesAll();
    this.daGetExpenses = new SqlDataAdapter();
    this.sqlDeleteCommand1 = new SqlCommand();
    this.ControlDataConnection = new SqlConnection();
    this.sqlInsertCommand1 = new SqlCommand();
    this.sqlSelectCommand1 = new SqlCommand();
    this.sqlUpdateCommand1 = new SqlCommand();
    this.daGetExpenseCategories = new SqlDataAdapter();
    this.sqlSelectCommand2 = new SqlCommand();
    this.ContextMenu1 = new ContextMenu();
    this.menuAssignDefaultGLAccount = new MenuItem();
    this.menuDeleteExpense = new MenuItem();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.sqlSelectCommand3 = new SqlCommand();
    this.mgaGroupBox1 = new MGAGroupBox();
    this.panel1 = new Panel();
    this.saveControl = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.comboExpenseCategory = new MGASimpleComboBox();
    this.textExpenseDescription = new MGATextBox();
    this.textExpenseName = new MGATextBox();
    this.labelExpenseDescription = new Label();
    this.labelExpenseName = new Label();
    this.labelExpenseCategory = new Label();
    ((ISupportInitialize) this.gridExpenses).BeginInit();
    this.dsExpenses1.BeginInit();
    this.dsExpenseCategoriesAll1.BeginInit();
    this.dsOfficeLocations1.BeginInit();
    ((ISupportInitialize) this.mgaGroupBox1).BeginInit();
    ((Control) this.mgaGroupBox1).SuspendLayout();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.comboExpenseCategory).BeginInit();
    ((ISupportInitialize) this.textExpenseDescription).BeginInit();
    ((ISupportInitialize) this.textExpenseName).BeginInit();
    this.SuspendLayout();
    ((Control) this.gridExpenses).Cursor = Cursors.Hand;
    ((UltraGridBase) this.gridExpenses).DataSource = (object) this.dsExpenses1.Expenses;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 93;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 145;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Expense Category";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 150;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Expense Name";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 179;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 284;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 146;
    ultraGridBand.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.gridExpenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Scrollbars = (Scrollbars) 2;
    ((Control) this.gridExpenses).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridExpenses).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridExpenses).Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridExpenses).Location = new Point(4, 24);
    ((Control) this.gridExpenses).Name = "gridExpenses";
    ((Control) this.gridExpenses).Size = new Size(632, 628);
    ((UltraControlBase) this.gridExpenses).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridExpenses).TabIndex = 1;
    this.gridExpenses.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridExpenses_AfterSelectChange);
    this.gridExpenses.BeforeSelectChange += new BeforeSelectChangeEventHandler(this.gridExpenses_BeforeSelectChange);
    this.dsExpenses1.DataSetName = "dsExpenses";
    this.dsExpenses1.Locale = new CultureInfo("en-US");
    this.dsExpenseCategoriesAll1.DataSetName = "dsExpenseCategoriesAll";
    this.dsExpenseCategoriesAll1.Locale = new CultureInfo("en-US");
    this.daGetExpenses.DeleteCommand = this.sqlDeleteCommand1;
    this.daGetExpenses.InsertCommand = this.sqlInsertCommand1;
    this.daGetExpenses.SelectCommand = this.sqlSelectCommand1;
    this.daGetExpenses.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetExpenses", new DataColumnMapping[6]
      {
        new DataColumnMapping("ExpenseCode", "ExpenseCode"),
        new DataColumnMapping("ExpenseCategoryId", "ExpenseCategoryId"),
        new DataColumnMapping("CategoryName", "CategoryName"),
        new DataColumnMapping("ExpenseName", "ExpenseName"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("SystemDefined", "SystemDefined")
      })
    });
    this.daGetExpenses.UpdateCommand = this.sqlUpdateCommand1;
    this.sqlDeleteCommand1.CommandText = "[spFin_DeleteExpense]";
    this.sqlDeleteCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlDeleteCommand1.Connection = this.ControlDataConnection;
    this.sqlDeleteCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlDeleteCommand1.Parameters.Add(new SqlParameter("@EXPENSECODE", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExpenseCode", DataRowVersion.Original, (object) null));
    this.ControlDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.sqlInsertCommand1.CommandText = "[spFin_AddExpense]";
    this.sqlInsertCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlInsertCommand1.Connection = this.ControlDataConnection;
    this.sqlInsertCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlInsertCommand1.Parameters.Add(new SqlParameter("@EXPENSECATEGORYID", SqlDbType.Int, 4, "ExpenseCategoryId"));
    this.sqlInsertCommand1.Parameters.Add(new SqlParameter("@EXPENSENAME", SqlDbType.VarChar, 30, "ExpenseName"));
    this.sqlInsertCommand1.Parameters.Add(new SqlParameter("@DESCRIPTION", SqlDbType.VarChar, 60, "Description"));
    this.sqlSelectCommand1.CommandText = "[spFin_GetExpenses]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.ControlDataConnection;
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlUpdateCommand1.CommandText = "[spFin_UpdateExpense]";
    this.sqlUpdateCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlUpdateCommand1.Connection = this.ControlDataConnection;
    this.sqlUpdateCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlUpdateCommand1.Parameters.Add(new SqlParameter("@EXPENSECODE", SqlDbType.Int, 4, "ExpenseCode"));
    this.sqlUpdateCommand1.Parameters.Add(new SqlParameter("@EXPENSECATEGORYID", SqlDbType.Int, 4, "ExpenseCategoryId"));
    this.sqlUpdateCommand1.Parameters.Add(new SqlParameter("@EXPENSENAME", SqlDbType.VarChar, 30, "ExpenseName"));
    this.sqlUpdateCommand1.Parameters.Add(new SqlParameter("@DESCRIPTION", SqlDbType.VarChar, 60, "Description"));
    this.daGetExpenseCategories.SelectCommand = this.sqlSelectCommand2;
    this.daGetExpenseCategories.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetExpenseCategories", new DataColumnMapping[4]
      {
        new DataColumnMapping("ExpenseCategoryID", "ExpenseCategoryID"),
        new DataColumnMapping("CategoryName", "CategoryName"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("SystemDefined", "SystemDefined")
      })
    });
    this.sqlSelectCommand2.CommandText = "[spFin_GetExpenseCategories]";
    this.sqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand2.Connection = this.ControlDataConnection;
    this.sqlSelectCommand2.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.ContextMenu1.MenuItems.AddRange(new MenuItem[2]
    {
      this.menuAssignDefaultGLAccount,
      this.menuDeleteExpense
    });
    this.menuAssignDefaultGLAccount.Index = 0;
    this.menuAssignDefaultGLAccount.Text = "Assign Default GL Account";
    this.menuDeleteExpense.Index = 1;
    this.menuDeleteExpense.Text = "Delete Expense";
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.daGetOfficeLocations.SelectCommand = this.sqlSelectCommand3;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.sqlSelectCommand3.CommandText = "[spFin_GetOfficeLocations]";
    this.sqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand3.Connection = this.ControlDataConnection;
    this.sqlSelectCommand3.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance10;
    this.mgaGroupBox1.ContentPadding.Bottom = 2;
    this.mgaGroupBox1.ContentPadding.Left = 2;
    this.mgaGroupBox1.ContentPadding.Right = 2;
    this.mgaGroupBox1.ContentPadding.Top = 2;
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.panel1);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.gridExpenses);
    ((Control) this.mgaGroupBox1).Dock = DockStyle.Fill;
    ((Control) this.mgaGroupBox1).Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((AppearanceBase) appearance11).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance11).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance11).ForeColor = Color.White;
    ((AppearanceBase) appearance11).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance11).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance11).ImageBackground = (Image) resourceManager.GetObject("appearance11.ImageBackground");
    ((AppearanceBase) appearance11).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.mgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance11;
    ((Control) this.mgaGroupBox1).Location = new Point(0, 0);
    ((Control) this.mgaGroupBox1).Name = "mgaGroupBox1";
    ((Control) this.mgaGroupBox1).Size = new Size(640, 656);
    this.mgaGroupBox1.UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.mgaGroupBox1).TabIndex = 4;
    ((Control) this.mgaGroupBox1).Text = "Expenses";
    this.mgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.panel1.BackColor = Color.Transparent;
    this.panel1.Controls.Add((Control) this.saveControl);
    this.panel1.Controls.Add((Control) this.comboExpenseCategory);
    this.panel1.Controls.Add((Control) this.textExpenseDescription);
    this.panel1.Controls.Add((Control) this.textExpenseName);
    this.panel1.Controls.Add((Control) this.labelExpenseDescription);
    this.panel1.Controls.Add((Control) this.labelExpenseName);
    this.panel1.Controls.Add((Control) this.labelExpenseCategory);
    this.panel1.Dock = DockStyle.Bottom;
    this.panel1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.panel1.Location = new Point(4, 508);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(632, 144 /*0x90*/);
    this.panel1.TabIndex = 2;
    this.saveControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.saveControl.EditStyle = EditStyle.ShowEditButton;
    this.saveControl.FreezeEvents = false;
    this.saveControl.Location = new Point(512 /*0x0200*/, 96 /*0x60*/);
    this.saveControl.Name = "saveControl";
    this.saveControl.TabIndex = 6;
    this.saveControl.ToolTipDelete = "Click here to delete the selected expense.";
    this.saveControl.ToolTipEdit = "Click here to edit the selected expense.";
    this.saveControl.ToolTipNew = "Click here to add a new expense.";
    this.saveControl.ToolTipSave = "Click here to save the current expense.";
    this.saveControl.UIState = UIState.HasRecordsNotEditing;
    this.saveControl.ClickingEdit += new CancelEventHandler(this.saveControl_ClickingEdit);
    this.saveControl.ClickingNew += new CancelEventHandler(this.saveControl_ClickingNew);
    this.saveControl.ClickingCancel += new CancelEventHandler(this.saveControl_ClickingCancel);
    this.saveControl.ClickingDelete += new CancelEventHandler(this.saveControl_ClickingDelete);
    this.saveControl.ClickingSave += new CancelEventHandler(this.saveControl_ClickingSave);
    ((Control) this.comboExpenseCategory).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.comboExpenseCategory.BorderStyle = (UIElementBorderStyle) 4;
    this.comboExpenseCategory.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboExpenseCategory).DataMember = "ExpenseCategories";
    ((UltraGridBase) this.comboExpenseCategory).DataSource = (object) this.dsExpenseCategoriesAll1;
    ((UltraDropDownBase) this.comboExpenseCategory).DisplayMember = "CategoryName";
    this.comboExpenseCategory.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboExpenseCategory).Enabled = false;
    ((Control) this.comboExpenseCategory).Location = new Point(120, 8);
    this.comboExpenseCategory.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboExpenseCategory).Name = "comboExpenseCategory";
    ((Control) this.comboExpenseCategory).Size = new Size(384, 20);
    ((Control) this.comboExpenseCategory).TabIndex = 5;
    ((UltraDropDownBase) this.comboExpenseCategory).ValueMember = "ExpenseCategoryID";
    ((Control) this.textExpenseDescription).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textExpenseDescription).Appearance = (AppearanceBase) appearance12;
    ((Control) this.textExpenseDescription).Enabled = false;
    ((Control) this.textExpenseDescription).Location = new Point(120, 56);
    this.textExpenseDescription.MGAStyle = MGAStyles.Blue;
    this.textExpenseDescription.Multiline = true;
    ((Control) this.textExpenseDescription).Name = "textExpenseDescription";
    ((Control) this.textExpenseDescription).Size = new Size(384, 80 /*0x50*/);
    ((Control) this.textExpenseDescription).TabIndex = 4;
    ((Control) this.textExpenseName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textExpenseName).Appearance = (AppearanceBase) appearance13;
    ((Control) this.textExpenseName).Enabled = false;
    ((Control) this.textExpenseName).Location = new Point(120, 32 /*0x20*/);
    this.textExpenseName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textExpenseName).Name = "textExpenseName";
    ((Control) this.textExpenseName).Size = new Size(384, 20);
    ((Control) this.textExpenseName).TabIndex = 3;
    this.labelExpenseDescription.AutoSize = true;
    this.labelExpenseDescription.Enabled = false;
    this.labelExpenseDescription.Location = new Point(8, 56);
    this.labelExpenseDescription.Name = "labelExpenseDescription";
    this.labelExpenseDescription.Size = new Size(109, 17);
    this.labelExpenseDescription.TabIndex = 2;
    this.labelExpenseDescription.Text = "Expense Description:";
    this.labelExpenseName.AutoSize = true;
    this.labelExpenseName.Enabled = false;
    this.labelExpenseName.Location = new Point(8, 32 /*0x20*/);
    this.labelExpenseName.Name = "labelExpenseName";
    this.labelExpenseName.Size = new Size(82, 17);
    this.labelExpenseName.TabIndex = 1;
    this.labelExpenseName.Text = "Expense Name:";
    this.labelExpenseCategory.AutoSize = true;
    this.labelExpenseCategory.Enabled = false;
    this.labelExpenseCategory.Location = new Point(8, 8);
    this.labelExpenseCategory.Name = "labelExpenseCategory";
    this.labelExpenseCategory.Size = new Size(98, 17);
    this.labelExpenseCategory.TabIndex = 0;
    this.labelExpenseCategory.Text = "Expense Category:";
    this.Controls.Add((Control) this.mgaGroupBox1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (NewExpense);
    this.Size = new Size(640, 656);
    ((ISupportInitialize) this.gridExpenses).EndInit();
    this.dsExpenses1.EndInit();
    this.dsExpenseCategoriesAll1.EndInit();
    this.dsOfficeLocations1.EndInit();
    ((ISupportInitialize) this.mgaGroupBox1).EndInit();
    ((Control) this.mgaGroupBox1).ResumeLayout(false);
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.comboExpenseCategory).EndInit();
    ((ISupportInitialize) this.textExpenseDescription).EndInit();
    ((ISupportInitialize) this.textExpenseName).EndInit();
    this.ResumeLayout(false);
  }

  private void LoadData()
  {
    this.Cursor = Cursors.WaitCursor;
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.dsExpenses1.Clear();
    this.dsExpenseCategoriesAll1.Clear();
    this.daGetExpenses.Fill((DataTable) this.dsExpenses1.Expenses);
    this.daGetExpenseCategories.Fill((DataTable) this.dsExpenseCategoriesAll1.ExpenseCategories);
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridExpenses).Rows).Count != 0)
    {
      ((UltraGridBase) this.gridExpenses).Rows[0].Activate();
      ((GridItemBase) ((UltraGridBase) this.gridExpenses).Rows[0]).Selected = true;
    }
    this.Cursor = Cursors.Default;
  }

  private void gridExpenses_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    if (((UltraGridBase) this.gridExpenses).ActiveRow == null)
      return;
    this.comboExpenseCategory.Value = (object) int.Parse(((UltraGridBase) this.gridExpenses).ActiveRow.Cells["expensecategoryid"].Value.ToString());
    ((Control) this.textExpenseName).Tag = (object) int.Parse(((UltraGridBase) this.gridExpenses).ActiveRow.Cells["expensecode"].Value.ToString());
    ((Control) this.textExpenseName).Text = ((UltraGridBase) this.gridExpenses).ActiveRow.Cells["expensename"].Value.ToString();
    ((Control) this.textExpenseDescription).Text = ((UltraGridBase) this.gridExpenses).ActiveRow.Cells["description"].Value.ToString();
  }

  private void gridExpenses_BeforeSelectChange(object sender, BeforeSelectChangeEventArgs e)
  {
    if (this._isSaving)
    {
      this._isSaving = false;
    }
    else
    {
      if (this.saveControl.UIState != UIState.Editing)
        return;
      if (MessageBox.Show("This will cancel the current edit operation, continue?", "Cancel Edit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.saveControl.PerformAction(DBSaveUIAction.ClickCancelButton);
        this.ToggleEditControls(false);
      }
      else
        ((CancelEventArgs) e).Cancel = true;
    }
  }

  private void ToggleEditControls(bool controlsEnabled)
  {
    this.labelExpenseCategory.Enabled = controlsEnabled;
    ((Control) this.comboExpenseCategory).Enabled = controlsEnabled;
    this.labelExpenseName.Enabled = controlsEnabled;
    ((Control) this.textExpenseName).Enabled = controlsEnabled;
    this.labelExpenseDescription.Enabled = controlsEnabled;
    ((Control) this.textExpenseDescription).Enabled = controlsEnabled;
  }

  private void saveControl_ClickingEdit(object sender, CancelEventArgs e)
  {
    this.ToggleEditControls(true);
  }

  private void saveControl_ClickingNew(object sender, CancelEventArgs e)
  {
    this.ToggleEditControls(true);
    this.comboExpenseCategory.Value = ((UltraGridBase) this.comboExpenseCategory).Rows[0].Cells["expenseCategoryId"].Value;
    ((Control) this.textExpenseName).Tag = (object) null;
    ((Control) this.textExpenseName).Text = string.Empty;
    ((Control) this.textExpenseDescription).Text = string.Empty;
  }

  private void saveControl_ClickingSave(object sender, CancelEventArgs e)
  {
    try
    {
      this._isSaving = true;
      if (((Control) this.textExpenseName).Tag == null)
        new Expense(int.Parse(((UltraDropDownBase) this.comboExpenseCategory).SelectedRow.Cells["expenseCategoryId"].Value.ToString()), ((Control) this.textExpenseName).Text, ((Control) this.textExpenseDescription).Text).SaveExpense();
      else
        new Expense(int.Parse(((Control) this.textExpenseName).Tag.ToString()))
        {
          ExpenseName = ((Control) this.textExpenseName).Text,
          ExpenseDescription = ((Control) this.textExpenseDescription).Text
        }.SaveExpense();
      this.ToggleEditControls(false);
      this.LoadData();
    }
    catch (SqlException ex)
    {
      if (ex.Number != 50000 || ex.State != (byte) 1)
        throw ex;
      int num = (int) MessageBox.Show(ex.Message, "Invalid Operation!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this._isSaving = false;
      e.Cancel = true;
    }
  }

  private void saveControl_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (((Control) this.textExpenseName).Tag == null)
      return;
    if (MessageBox.Show($"This will permanently delete the {((Control) this.textExpenseName).Text} expense, continue?", "Delete Expense?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
      try
      {
        new Expense(int.Parse(((Control) this.textExpenseName).Tag.ToString())).Delete();
        this.ToggleEditControls(false);
        this.LoadData();
      }
      catch (SqlException ex)
      {
        if (ex.Number != 50000 || ex.State != (byte) 1)
          throw ex;
        int num = (int) MessageBox.Show(ex.Message, "Invalid Operation!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      }
    }
    else
      e.Cancel = true;
  }

  private void saveControl_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ToggleEditControls(false);
  }
}
