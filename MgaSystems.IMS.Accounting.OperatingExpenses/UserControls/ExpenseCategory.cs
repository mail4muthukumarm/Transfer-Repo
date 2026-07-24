// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.ExpenseCategory
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
using MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class ExpenseCategory : UserControl
{
  private dsExpenseCategoriesAll dsExpenseCategoriesAll1;
  private SqlConnection ControlDataConnection;
  private SqlCommand sqlSelectCommand3;
  private SqlDataAdapter daGetOfficeLocations;
  internal SqlDataAdapter daGetExpenseCategories;
  internal UltraGrid gridExpenses;
  internal UltraDropDown uddExpenseCategories;
  private dsOfficeLocations dsOfficeLocations1;
  private SqlCommand sqlSelectCommand1;
  private SqlCommand sqlInsertCommand1;
  private SqlCommand sqlUpdateCommand1;
  private SqlCommand sqlDeleteCommand1;
  private Panel panel1;
  private MGASystems.Tools.DBSaveUI.DBSaveUI saveControl;
  private MGATextBox textCategoryName;
  private MGATextBox textCategoryDescription;
  private Panel panel2;
  private MGAGroupBox mgaGroupBox1;
  private Label labelCategoryName;
  private Label labelCategoryDescription;
  private System.ComponentModel.Container components;
  private LinkLabel linkExpenses;
  private bool _isSaving;
  private int _selectedCategoryId;

  public ExpenseCategory()
  {
    this.InitializeComponent();
    this.Dock = DockStyle.Fill;
    this.LoadExpenseCategories();
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("ExpenseCategories", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ExpenseCategoryID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CategoryName");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Description");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("SystemDefined");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("ExpenseCategories", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ExpenseCategoryID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CategoryName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("SystemDefined");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (ExpenseCategory));
    this.gridExpenses = new UltraGrid();
    this.dsExpenseCategoriesAll1 = new dsExpenseCategoriesAll();
    this.uddExpenseCategories = new UltraDropDown();
    this.ControlDataConnection = new SqlConnection();
    this.sqlSelectCommand3 = new SqlCommand();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.daGetExpenseCategories = new SqlDataAdapter();
    this.sqlDeleteCommand1 = new SqlCommand();
    this.sqlInsertCommand1 = new SqlCommand();
    this.sqlSelectCommand1 = new SqlCommand();
    this.sqlUpdateCommand1 = new SqlCommand();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    this.panel1 = new Panel();
    this.saveControl = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.textCategoryDescription = new MGATextBox();
    this.textCategoryName = new MGATextBox();
    this.labelCategoryDescription = new Label();
    this.labelCategoryName = new Label();
    this.panel2 = new Panel();
    this.mgaGroupBox1 = new MGAGroupBox();
    this.linkExpenses = new LinkLabel();
    ((ISupportInitialize) this.gridExpenses).BeginInit();
    this.dsExpenseCategoriesAll1.BeginInit();
    ((ISupportInitialize) this.uddExpenseCategories).BeginInit();
    this.dsOfficeLocations1.BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.textCategoryDescription).BeginInit();
    ((ISupportInitialize) this.textCategoryName).BeginInit();
    this.panel2.SuspendLayout();
    ((ISupportInitialize) this.mgaGroupBox1).BeginInit();
    ((Control) this.mgaGroupBox1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.gridExpenses).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridExpenses).DataMember = "ExpenseCategories";
    ((UltraGridBase) this.gridExpenses).DataSource = (object) this.dsExpenseCategoriesAll1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 204;
    ((AppearanceBase) appearance2).TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Category Name";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 353;
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 1;
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 353;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 224 /*0xE0*/;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.Transparent;
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance10).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridExpenses).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridExpenses).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridExpenses).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridExpenses).Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridExpenses).Location = new Point(0, 0);
    ((Control) this.gridExpenses).Name = "gridExpenses";
    ((Control) this.gridExpenses).Size = new Size(708, 552);
    ((UltraControlBase) this.gridExpenses).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridExpenses).TabIndex = 0;
    this.gridExpenses.AfterSelectChange += new AfterSelectChangeEventHandler(this.gridExpenses_AfterSelectChange);
    this.gridExpenses.BeforeSelectChange += new BeforeSelectChangeEventHandler(this.gridExpenses_BeforeSelectChange);
    this.dsExpenseCategoriesAll1.DataSetName = "dsExpenseCategoriesAll";
    this.dsExpenseCategoriesAll1.Locale = new CultureInfo("en-US");
    ((UltraGridBase) this.uddExpenseCategories).DataSource = (object) this.dsExpenseCategoriesAll1.ExpenseCategories;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 1;
    ultraGridColumn6.Width = 182;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 2;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 144 /*0x90*/;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 3;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 202;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.uddExpenseCategories).DisplayLayout.Override.CellMultiLine = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.uddExpenseCategories).DisplayMember = "CategoryName";
    ((Control) this.uddExpenseCategories).Location = new Point(624, 8);
    ((Control) this.uddExpenseCategories).Name = "uddExpenseCategories";
    ((Control) this.uddExpenseCategories).Size = new Size(184, 80 /*0x50*/);
    ((Control) this.uddExpenseCategories).TabIndex = 2;
    ((UltraDropDownBase) this.uddExpenseCategories).ValueMember = "ExpenseCategoryID";
    ((Control) this.uddExpenseCategories).Visible = false;
    this.ControlDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.sqlSelectCommand3.CommandText = "[spFin_GetOfficeLocations]";
    this.sqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand3.Connection = this.ControlDataConnection;
    this.sqlSelectCommand3.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.daGetOfficeLocations.SelectCommand = this.sqlSelectCommand3;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.daGetExpenseCategories.DeleteCommand = this.sqlDeleteCommand1;
    this.daGetExpenseCategories.InsertCommand = this.sqlInsertCommand1;
    this.daGetExpenseCategories.SelectCommand = this.sqlSelectCommand1;
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
    this.daGetExpenseCategories.UpdateCommand = this.sqlUpdateCommand1;
    this.sqlDeleteCommand1.CommandText = "[spFin_DeleteExpenseCategory]";
    this.sqlDeleteCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlDeleteCommand1.Connection = this.ControlDataConnection;
    this.sqlDeleteCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlDeleteCommand1.Parameters.Add(new SqlParameter("@EXPENSECATEGORYID", SqlDbType.Int, 4, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ExpenseCategoryID", DataRowVersion.Original, (object) null));
    this.sqlInsertCommand1.CommandText = "[spFin_AddExpenseCategory]";
    this.sqlInsertCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlInsertCommand1.Connection = this.ControlDataConnection;
    this.sqlInsertCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlInsertCommand1.Parameters.Add(new SqlParameter("@CATEGORYNAME", SqlDbType.VarChar, 40, "CategoryName"));
    this.sqlInsertCommand1.Parameters.Add(new SqlParameter("@DESCRIPTION", SqlDbType.VarChar, 100, "Description"));
    this.sqlSelectCommand1.CommandText = "[spFin_GetExpenseCategories]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.ControlDataConnection;
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlUpdateCommand1.CommandText = "[spFin_UpdateExpenseCategory]";
    this.sqlUpdateCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlUpdateCommand1.Connection = this.ControlDataConnection;
    this.sqlUpdateCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlUpdateCommand1.Parameters.Add(new SqlParameter("@EXPENSECATEGORYID", SqlDbType.Int, 4, "ExpenseCategoryID"));
    this.sqlUpdateCommand1.Parameters.Add(new SqlParameter("@CATEGORYNAME", SqlDbType.VarChar, 40, "CategoryName"));
    this.sqlUpdateCommand1.Parameters.Add(new SqlParameter("@DESCRIPTION", SqlDbType.VarChar, 750, "Description"));
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.panel1.BackColor = Color.Transparent;
    this.panel1.Controls.Add((Control) this.linkExpenses);
    this.panel1.Controls.Add((Control) this.saveControl);
    this.panel1.Controls.Add((Control) this.textCategoryDescription);
    this.panel1.Controls.Add((Control) this.textCategoryName);
    this.panel1.Controls.Add((Control) this.labelCategoryDescription);
    this.panel1.Controls.Add((Control) this.labelCategoryName);
    this.panel1.Dock = DockStyle.Bottom;
    this.panel1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.panel1.Location = new Point(6, 578);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(708, 128 /*0x80*/);
    this.panel1.TabIndex = 0;
    this.saveControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.saveControl.EditStyle = EditStyle.ShowEditButton;
    this.saveControl.FreezeEvents = false;
    this.saveControl.Location = new Point(584, 80 /*0x50*/);
    this.saveControl.Name = "saveControl";
    this.saveControl.TabIndex = 4;
    this.saveControl.ToolTipDelete = "Click here to delete the selected expense category.";
    this.saveControl.ToolTipEdit = "Click here to edit the selected expense category.";
    this.saveControl.ToolTipNew = "Clck here to add a new expense category.";
    this.saveControl.ToolTipSave = "Click here to save your changes.";
    this.saveControl.UIState = UIState.HasRecordsNotEditing;
    this.saveControl.ClickingEdit += new CancelEventHandler(this.saveControl_ClickingEdit);
    this.saveControl.ClickedCancel += new EventHandler(this.saveControl_ClickedCancel);
    this.saveControl.ClickingNew += new CancelEventHandler(this.saveControl_ClickingNew);
    this.saveControl.ClickingDelete += new CancelEventHandler(this.saveControl_ClickingDelete);
    this.saveControl.ClickingSave += new CancelEventHandler(this.saveControl_ClickingSave);
    ((Control) this.textCategoryDescription).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCategoryDescription).Appearance = (AppearanceBase) appearance13;
    ((Control) this.textCategoryDescription).Enabled = false;
    ((Control) this.textCategoryDescription).Location = new Point(96 /*0x60*/, 32 /*0x20*/);
    ((TextEditorControlBase) this.textCategoryDescription).MaxLength = 750;
    this.textCategoryDescription.MGAStyle = MGAStyles.Blue;
    this.textCategoryDescription.Multiline = true;
    ((Control) this.textCategoryDescription).Name = "textCategoryDescription";
    ((Control) this.textCategoryDescription).Size = new Size(456, 88);
    ((Control) this.textCategoryDescription).TabIndex = 3;
    ((Control) this.textCategoryName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textCategoryName).Appearance = (AppearanceBase) appearance14;
    ((Control) this.textCategoryName).Enabled = false;
    ((Control) this.textCategoryName).Location = new Point(96 /*0x60*/, 8);
    ((TextEditorControlBase) this.textCategoryName).MaxLength = 40;
    this.textCategoryName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textCategoryName).Name = "textCategoryName";
    ((Control) this.textCategoryName).Size = new Size(456, 20);
    ((Control) this.textCategoryName).TabIndex = 1;
    this.labelCategoryDescription.AutoSize = true;
    this.labelCategoryDescription.Enabled = false;
    this.labelCategoryDescription.Location = new Point(8, 32 /*0x20*/);
    this.labelCategoryDescription.Name = "labelCategoryDescription";
    this.labelCategoryDescription.Size = new Size(64 /*0x40*/, 17);
    this.labelCategoryDescription.TabIndex = 2;
    this.labelCategoryDescription.Text = "Description:";
    this.labelCategoryName.AutoSize = true;
    this.labelCategoryName.Enabled = false;
    this.labelCategoryName.Location = new Point(8, 8);
    this.labelCategoryName.Name = "labelCategoryName";
    this.labelCategoryName.Size = new Size(85, 17);
    this.labelCategoryName.TabIndex = 0;
    this.labelCategoryName.Text = "Category Name:";
    this.panel2.BackColor = Color.Transparent;
    this.panel2.Controls.Add((Control) this.gridExpenses);
    this.panel2.Dock = DockStyle.Fill;
    this.panel2.Location = new Point(6, 26);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(708, 552);
    this.panel2.TabIndex = 4;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance15;
    this.mgaGroupBox1.ContentPadding.Bottom = 4;
    this.mgaGroupBox1.ContentPadding.Left = 4;
    this.mgaGroupBox1.ContentPadding.Right = 4;
    this.mgaGroupBox1.ContentPadding.Top = 4;
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.panel2);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.panel1);
    ((Control) this.mgaGroupBox1).Dock = DockStyle.Fill;
    ((Control) this.mgaGroupBox1).Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((AppearanceBase) appearance16).AlphaLevel = (short) 230;
    ((AppearanceBase) appearance16).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance16).ForeColor = Color.White;
    ((AppearanceBase) appearance16).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance16).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance16).ImageBackground = (Image) resourceManager.GetObject("appearance16.ImageBackground");
    ((AppearanceBase) appearance16).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.mgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance16;
    ((Control) this.mgaGroupBox1).Location = new Point(0, 0);
    ((Control) this.mgaGroupBox1).Name = "mgaGroupBox1";
    ((Control) this.mgaGroupBox1).Size = new Size(720, 712);
    this.mgaGroupBox1.UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.mgaGroupBox1).TabIndex = 1;
    ((Control) this.mgaGroupBox1).Text = "Expense Categories";
    this.mgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.linkExpenses.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.linkExpenses.Location = new Point(552, 8);
    this.linkExpenses.Name = "linkExpenses";
    this.linkExpenses.Size = new Size(144 /*0x90*/, 16 /*0x10*/);
    this.linkExpenses.TabIndex = 5;
    this.linkExpenses.TabStop = true;
    this.linkExpenses.Text = "Finding Linked Expenses...";
    this.linkExpenses.TextAlign = ContentAlignment.TopRight;
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.mgaGroupBox1);
    this.Controls.Add((Control) this.uddExpenseCategories);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.ForeColor = Color.Black;
    this.Name = nameof (ExpenseCategory);
    this.Size = new Size(720, 712);
    ((ISupportInitialize) this.gridExpenses).EndInit();
    this.dsExpenseCategoriesAll1.EndInit();
    ((ISupportInitialize) this.uddExpenseCategories).EndInit();
    this.dsOfficeLocations1.EndInit();
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.textCategoryDescription).EndInit();
    ((ISupportInitialize) this.textCategoryName).EndInit();
    this.panel2.ResumeLayout(false);
    ((ISupportInitialize) this.mgaGroupBox1).EndInit();
    ((Control) this.mgaGroupBox1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  private void LoadExpenseCategories()
  {
    try
    {
      this.Cursor = Cursors.WaitCursor;
      this.daGetExpenseCategories.SelectCommand.Connection.ConnectionString = CurrentUser.Instance.ConnectionString;
      this.dsExpenseCategoriesAll1.ExpenseCategories.Clear();
      this.daGetExpenseCategories.Fill((DataTable) this.dsExpenseCategoriesAll1.ExpenseCategories);
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridExpenses).Rows).Count == 0)
        return;
      ((UltraGridBase) this.gridExpenses).ActiveRow = ((UltraGridBase) this.gridExpenses).Rows[0];
      ((GridItemBase) ((UltraGridBase) this.gridExpenses).Rows[0]).Selected = true;
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void gridExpenses_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    if (((UltraGridBase) this.gridExpenses).ActiveRow == null)
      return;
    this._selectedCategoryId = int.Parse(((UltraGridBase) this.gridExpenses).ActiveRow.Cells["EXPENSECATEGORYID"].Value.ToString());
    ((Control) this.textCategoryName).Tag = (object) this._selectedCategoryId;
    ((Control) this.textCategoryName).Text = ((UltraGridBase) this.gridExpenses).ActiveRow.Cells["CATEGORYNAME"].Value.ToString();
    ((Control) this.textCategoryDescription).Text = ((UltraGridBase) this.gridExpenses).ActiveRow.Cells["DESCRIPTION"].Value.ToString();
    this.GetLinkedExpensesCount();
  }

  private void ToggleEditControlsEnabled(bool enabledStatus)
  {
    this.labelCategoryName.Enabled = enabledStatus;
    ((Control) this.textCategoryName).Enabled = enabledStatus;
    this.labelCategoryDescription.Enabled = enabledStatus;
    ((Control) this.textCategoryDescription).Enabled = enabledStatus;
  }

  private void saveControl_ClickingEdit(object sender, CancelEventArgs e)
  {
    this.ToggleEditControlsEnabled(true);
  }

  private void saveControl_ClickingNew(object sender, CancelEventArgs e)
  {
    this.saveControl.UIState = UIState.NoRecordsNotEditing;
    this.ToggleEditControlsEnabled(true);
    ((Control) this.textCategoryName).Tag = (object) null;
    ((Control) this.textCategoryName).Text = string.Empty;
    ((Control) this.textCategoryDescription).Text = string.Empty;
    this.linkExpenses.Visible = false;
  }

  private void saveControl_ClickingSave(object sender, CancelEventArgs e)
  {
    if (((Control) this.textCategoryName).Text.Length == 0 || ((Control) this.textCategoryName).Text == string.Empty)
    {
      int num = (int) MessageBox.Show("You must enter a category name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else if ((((Control) this.textCategoryName).Tag == null || !((Control) this.textCategoryName).Text.ToUpper().Equals(((UltraGridBase) this.gridExpenses).ActiveRow.Cells["categoryname"].Value.ToString().ToUpper())) && Utilities.ExpenseCategoryExists(((Control) this.textCategoryName).Text))
    {
      int num = (int) MessageBox.Show("The expense category you are trying to add already exists.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      e.Cancel = true;
    }
    else
    {
      MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.ExpenseCategory expenseCategory;
      if (((Control) this.textCategoryName).Tag == null)
      {
        expenseCategory = new MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.ExpenseCategory(((Control) this.textCategoryName).Text, ((Control) this.textCategoryDescription).Text);
      }
      else
      {
        expenseCategory = new MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.ExpenseCategory(int.Parse(((Control) this.textCategoryName).Tag.ToString()));
        expenseCategory.CategoryName = ((Control) this.textCategoryName).Text;
        expenseCategory.CategoryDescription = ((Control) this.textCategoryDescription).Text;
      }
      try
      {
        this._isSaving = true;
        expenseCategory.Save();
        this.ToggleEditControlsEnabled(false);
        this.LoadExpenseCategories();
        this.linkExpenses.Visible = true;
      }
      catch (ExpenseCategoryAlreadyExistsException ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "Category Exists!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
        this._isSaving = false;
      }
      catch (ObjectCannotBeModifiedException ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "System Defined!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
        this._isSaving = false;
      }
    }
  }

  private void saveControl_ClickedCancel(object sender, EventArgs e)
  {
    this.ToggleEditControlsEnabled(false);
    this.linkExpenses.Visible = true;
  }

  private void saveControl_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (MessageBox.Show($"This will permanently delete the {((Control) this.textCategoryName).Text} expense category, do you wish to continue?", "Delete Expense Category?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
    {
      MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.ExpenseCategory expenseCategory = new MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.ExpenseCategory(int.Parse(((Control) this.textCategoryName).Tag.ToString()));
      try
      {
        expenseCategory.Delete();
        this.ToggleEditControlsEnabled(false);
        this.LoadExpenseCategories();
      }
      catch (CannotDeleteException ex)
      {
        int num = (int) MessageBox.Show(ex.Message, "Can Not Delete Expense Category!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
      }
    }
    else
      e.Cancel = true;
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
      if (MessageBox.Show("This will cancel the editing of the current record, continue?", "Cancel Edit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        ((CancelEventArgs) e).Cancel = true;
      else
        this.saveControl.PerformAction(DBSaveUIAction.ClickCancelButton);
    }
  }

  private void GetLinkedExpensesCount()
  {
    if (((Control) this.textCategoryName).Tag == null)
      return;
    this.linkExpenses.Text = "Finding Linked Expenses...";
    this._selectedCategoryId = int.Parse(((Control) this.textCategoryName).Tag.ToString());
    new Thread(new ThreadStart(this.DoGetLinkedExpensesCount))
    {
      IsBackground = true,
      Name = nameof (GetLinkedExpensesCount)
    }.Start();
  }

  private void DoGetLinkedExpensesCount()
  {
    int expenseCount = 0;
    using (SqlCommand sqlCommand = new SqlCommand($"Select dbo.GetLinkedExpenseCount({this._selectedCategoryId})", new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      try
      {
        sqlCommand.CommandType = CommandType.Text;
        sqlCommand.Connection.Open();
        expenseCount = (int) sqlCommand.ExecuteScalar();
      }
      catch (Exception ex)
      {
        if (!this.IsDisposed)
        {
          if (!this.Disposing)
            this.Invoke((Delegate) new ExpenseCategory.ThreadExceptionHandler(this.ThreadException), (object) ex);
        }
      }
    }
    if (this.IsDisposed || this.Disposing)
      return;
    if (this.InvokeRequired)
      this.Invoke((Delegate) new ExpenseCategory.GetLinkedExpensesCountCompletedHandler(this.GetLinkedExpensesCountCompleted), (object) expenseCount);
    else
      this.GetLinkedExpensesCountCompleted(expenseCount);
  }

  private void GetLinkedExpensesCountCompleted(int expenseCount)
  {
    this.linkExpenses.Text = $"({expenseCount}) Linked Expense(s)";
  }

  private void ThreadException(Exception ex) => throw ex;

  private delegate void GetLinkedExpensesCountCompletedHandler(int expenseCount);

  private delegate void ThreadExceptionHandler(Exception ex);
}
