// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.ExpenseEntry
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.Interfaces;
using MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;
using MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;
using MGASystems.IMS.Accounting.OperatingExpenses.Forms;
using MGASystems.IMS.Accounting.Services.Forms;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.UserControls;

public class ExpenseEntry : UserControl
{
  private MGACheckBox checkboxPercentage;
  internal Label Label8;
  internal Label Label7;
  internal Label Label6;
  internal Label Label5;
  internal Label Label4;
  internal Label Label3;
  internal Label Label2;
  internal Label Label1;
  private UltraFlowLayoutManager ultraFlowLayoutManager1;
  private MGAButton buttonCancel;
  private MGAButton buttonSaveExpenseDetail;
  private MGAButton buttonEditAllocations;
  private MGAButton buttonSearchExpenseFor;
  private MGATextBox textboxExpenseFor;
  private MGATextBox textboxExpenseAmount;
  private MGATextBox textboxExpenseTotal;
  private MGATextBox textboxDiscountAmount;
  private MGASimpleComboBox comboCostCenters;
  private MGASimpleComboBox comboExpense;
  private ExtendedTreeViewDropDown dropTreeGlAccounts;
  private dsCostCenters dsCostCenters1;
  private dsExpenses dsExpenses1;
  private SqlDataAdapter daGetExpenses;
  private SqlConnection ControlDataConnection;
  private SqlDataAdapter daGetCostCenters;
  private SqlCommand sqlSelectCommand2;
  private SqlCommand sqlSelectCommand1;
  private MGADateTimePicker dateTimeExpenseDate;
  private MGAButton buttonSplitAllocations;
  private MGAButton buttonClearAllocations;
  private MGAButton buttonClearExpenseFor;
  private MGACheckBox checkExclude1099;
  private IContainer components;
  private int glCompanyId;
  private bool isInitialized;
  private bool isChangingCostCenter = true;
  internal PurchaseOrderExpenseDetail detailItem;
  public Mode ControlMode;
  private int EditRowIndex;

  public ExpenseEntry()
  {
    this.InitializeComponent();
    this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    this.UpdateStyles();
    this.BackColor = Color.Transparent;
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
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
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ExpenseEntry));
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
    this.checkboxPercentage = new MGACheckBox();
    this.Label8 = new Label();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.Label4 = new Label();
    this.Label3 = new Label();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.ultraFlowLayoutManager1 = new UltraFlowLayoutManager(this.components);
    this.buttonCancel = new MGAButton();
    this.buttonSaveExpenseDetail = new MGAButton();
    this.buttonEditAllocations = new MGAButton();
    this.buttonSearchExpenseFor = new MGAButton();
    this.dateTimeExpenseDate = new MGADateTimePicker();
    this.comboExpense = new MGASimpleComboBox();
    this.dsExpenses1 = new dsExpenses();
    this.textboxExpenseFor = new MGATextBox();
    this.textboxExpenseAmount = new MGATextBox();
    this.textboxExpenseTotal = new MGATextBox();
    this.textboxDiscountAmount = new MGATextBox();
    this.comboCostCenters = new MGASimpleComboBox();
    this.dsCostCenters1 = new dsCostCenters();
    this.dropTreeGlAccounts = new ExtendedTreeViewDropDown();
    this.daGetExpenses = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.ControlDataConnection = new SqlConnection();
    this.daGetCostCenters = new SqlDataAdapter();
    this.sqlSelectCommand2 = new SqlCommand();
    this.buttonSplitAllocations = new MGAButton();
    this.buttonClearAllocations = new MGAButton();
    this.buttonClearExpenseFor = new MGAButton();
    this.checkExclude1099 = new MGACheckBox();
    ((ISupportInitialize) this.checkboxPercentage).BeginInit();
    ((ISupportInitialize) this.ultraFlowLayoutManager1).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSaveExpenseDetail).BeginInit();
    ((ISupportInitialize) this.buttonEditAllocations).BeginInit();
    ((ISupportInitialize) this.buttonSearchExpenseFor).BeginInit();
    ((ISupportInitialize) this.dateTimeExpenseDate).BeginInit();
    ((ISupportInitialize) this.comboExpense).BeginInit();
    this.dsExpenses1.BeginInit();
    ((ISupportInitialize) this.textboxExpenseFor).BeginInit();
    ((ISupportInitialize) this.textboxExpenseAmount).BeginInit();
    ((ISupportInitialize) this.textboxExpenseTotal).BeginInit();
    ((ISupportInitialize) this.textboxDiscountAmount).BeginInit();
    ((ISupportInitialize) this.comboCostCenters).BeginInit();
    this.dsCostCenters1.BeginInit();
    ((ISupportInitialize) this.buttonSplitAllocations).BeginInit();
    ((ISupportInitialize) this.buttonClearAllocations).BeginInit();
    ((ISupportInitialize) this.buttonClearExpenseFor).BeginInit();
    ((ISupportInitialize) this.checkExclude1099).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BorderColor = Color.Gray;
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkboxPercentage).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.checkboxPercentage).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkboxPercentage).Location = new Point(240 /*0xF0*/, 128 /*0x80*/);
    ((Control) this.checkboxPercentage).Name = "checkboxPercentage";
    ((Control) this.checkboxPercentage).Size = new Size(136, 20);
    ((Control) this.checkboxPercentage).TabIndex = 13;
    ((Control) this.checkboxPercentage).Text = "Apply as a Percentage";
    ((UltraToggleEditorBase) this.checkboxPercentage).CheckedChanged += new EventHandler(this.FormatDiscountAmt);
    // ISSUE: method pointer
    ((UltraToggleEditorBase) this.checkboxPercentage).BeforeCheckStateChanged += new ToggleEditorBase.BeforeCheckStateChangedHandler((object) this, __methodptr(checkboxPercentage_BeforeCheckStateChanged));
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(8, 152);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(79, 13);
    this.Label8.TabIndex = 14;
    this.Label8.Text = "Expense Total:";
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(8, 128 /*0x80*/);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(74, 13);
    this.Label7.TabIndex = 11;
    this.Label7.Text = "Discount Amt:";
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(8, 104);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(74, 13);
    this.Label6.TabIndex = 9;
    this.Label6.Text = "Expense Amt:";
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(8, 80 /*0x50*/);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(71, 13);
    this.Label5.TabIndex = 6;
    this.Label5.Text = "Expense For:";
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(8, 32 /*0x20*/);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(52, 13);
    this.Label4.TabIndex = 2;
    this.Label4.Text = "Expense:";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(8, 56);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(65, 13);
    this.Label3.TabIndex = 4;
    this.Label3.Text = "GL Account:";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(8, 176 /*0xB0*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(69, 13);
    this.Label2.TabIndex = 16 /*0x10*/;
    this.Label2.Text = "Cost Center:";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(8, 8);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(78, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Expense Date:";
    ((AppearanceBase) appearance2).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance2).BackColor2 = Color.White;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance2.Image");
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonCancel).Location = new Point(272, 232);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.buttonCancel).TabIndex = 20;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance3).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance3).BackColor2 = Color.White;
    ((AppearanceBase) appearance3).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance3).Image = componentResourceManager.GetObject("appearance3.Image");
    ((ControlBase) this.buttonSaveExpenseDetail).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonSaveExpenseDetail).Location = new Point(144 /*0x90*/, 232);
    ((Control) this.buttonSaveExpenseDetail).Name = "buttonSaveExpenseDetail";
    ((Control) this.buttonSaveExpenseDetail).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.buttonSaveExpenseDetail).TabIndex = 19;
    ((Control) this.buttonSaveExpenseDetail).Text = "Save Detail";
    ((UltraControlBase) this.buttonSaveExpenseDetail).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSaveExpenseDetail).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance4).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance4).BackColor2 = Color.White;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance4).Image = componentResourceManager.GetObject("appearance4.Image");
    ((ControlBase) this.buttonEditAllocations).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonEditAllocations).Location = new Point(144 /*0x90*/, 200);
    ((Control) this.buttonEditAllocations).Name = "buttonEditAllocations";
    ((Control) this.buttonEditAllocations).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.buttonEditAllocations).TabIndex = 18;
    ((Control) this.buttonEditAllocations).Text = "Edit Allocations";
    ((UltraControlBase) this.buttonEditAllocations).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonEditAllocations).Click += new EventHandler(this.buttonEditAllocations_Click);
    ((AppearanceBase) appearance5).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance5).BackColor2 = Color.White;
    ((AppearanceBase) appearance5).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance5).Image = componentResourceManager.GetObject("appearance5.Image");
    ((ControlBase) this.buttonSearchExpenseFor).Appearance = (AppearanceBase) appearance5;
    ((Control) this.buttonSearchExpenseFor).Location = new Point(352, 80 /*0x50*/);
    ((Control) this.buttonSearchExpenseFor).Name = "buttonSearchExpenseFor";
    ((Control) this.buttonSearchExpenseFor).Size = new Size(24, 24);
    ((Control) this.buttonSearchExpenseFor).TabIndex = 8;
    ((UltraControlBase) this.buttonSearchExpenseFor).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearchExpenseFor).Click += new EventHandler(this.buttonSearchExpenseFor_Click);
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dateTimeExpenseDate.Appearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance7).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance7).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance7).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance7).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance7).ForegroundAlpha = (Alpha) 2;
    this.dateTimeExpenseDate.ButtonAppearance = (AppearanceBase) appearance7;
    this.dateTimeExpenseDate.FormatString = "D";
    ((Control) this.dateTimeExpenseDate).Location = new Point(96 /*0x60*/, 8);
    this.dateTimeExpenseDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.dateTimeExpenseDate).Name = "dateTimeExpenseDate";
    ((Control) this.dateTimeExpenseDate).Size = new Size(304, 20);
    ((Control) this.dateTimeExpenseDate).TabIndex = 1;
    ((UltraControlBase) this.dateTimeExpenseDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateTimeExpenseDate).UseOsThemes = (DefaultableBoolean) 2;
    this.comboExpense.BorderStyle = (UIElementBorderStyle) 4;
    this.comboExpense.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboExpense).DataMember = "Expenses";
    ((UltraGridBase) this.comboExpense).DataSource = (object) this.dsExpenses1;
    ((UltraDropDownBase) this.comboExpense).DisplayMember = "ExpenseName";
    this.comboExpense.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboExpense).Location = new Point(96 /*0x60*/, 32 /*0x20*/);
    this.comboExpense.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboExpense).Name = "comboExpense";
    ((Control) this.comboExpense).Size = new Size(304, 21);
    ((Control) this.comboExpense).TabIndex = 3;
    ((UltraControlBase) this.comboExpense).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboExpense).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboExpense).ValueMember = "ExpenseCode";
    this.comboExpense.RowSelected += new RowSelectedEventHandler(this.cmbExpense_RowSelected);
    this.dsExpenses1.DataSetName = "dsExpenses";
    this.dsExpenses1.Locale = new CultureInfo("en-US");
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textboxExpenseFor).Appearance = (AppearanceBase) appearance8;
    ((Control) this.textboxExpenseFor).BackColor = Color.White;
    ((Control) this.textboxExpenseFor).Enabled = false;
    ((Control) this.textboxExpenseFor).Location = new Point(96 /*0x60*/, 80 /*0x50*/);
    this.textboxExpenseFor.MGAStyle = MGAStyles.Blue;
    ((Control) this.textboxExpenseFor).Name = "textboxExpenseFor";
    ((Control) this.textboxExpenseFor).Size = new Size(248, 20);
    ((Control) this.textboxExpenseFor).TabIndex = 7;
    ((Control) this.textboxExpenseFor).Tag = (object) "0";
    ((UltraControlBase) this.textboxExpenseFor).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textboxExpenseFor).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textboxExpenseAmount).Appearance = (AppearanceBase) appearance9;
    ((Control) this.textboxExpenseAmount).BackColor = Color.White;
    ((Control) this.textboxExpenseAmount).Location = new Point(96 /*0x60*/, 104);
    this.textboxExpenseAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.textboxExpenseAmount).Name = "textboxExpenseAmount";
    ((Control) this.textboxExpenseAmount).Size = new Size(136, 20);
    ((Control) this.textboxExpenseAmount).TabIndex = 10;
    ((UltraControlBase) this.textboxExpenseAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textboxExpenseAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textboxExpenseAmount).Validating += new CancelEventHandler(this.txtExpenseAmount_Validating);
    ((Control) this.textboxExpenseAmount).Enter += new EventHandler(this.textboxExpenseAmount_Enter);
    ((AppearanceBase) appearance10).BackColor = Color.White;
    ((AppearanceBase) appearance10).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textboxExpenseTotal).Appearance = (AppearanceBase) appearance10;
    ((Control) this.textboxExpenseTotal).BackColor = Color.White;
    ((Control) this.textboxExpenseTotal).Enabled = false;
    ((Control) this.textboxExpenseTotal).Location = new Point(96 /*0x60*/, 152);
    this.textboxExpenseTotal.MGAStyle = MGAStyles.Blue;
    ((Control) this.textboxExpenseTotal).Name = "textboxExpenseTotal";
    ((Control) this.textboxExpenseTotal).Size = new Size(136, 20);
    ((Control) this.textboxExpenseTotal).TabIndex = 15;
    ((Control) this.textboxExpenseTotal).Tag = (object) "0";
    ((UltraControlBase) this.textboxExpenseTotal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textboxExpenseTotal).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textboxDiscountAmount).Appearance = (AppearanceBase) appearance11;
    ((Control) this.textboxDiscountAmount).BackColor = Color.White;
    ((Control) this.textboxDiscountAmount).Location = new Point(96 /*0x60*/, 128 /*0x80*/);
    this.textboxDiscountAmount.MGAStyle = MGAStyles.Blue;
    ((Control) this.textboxDiscountAmount).Name = "textboxDiscountAmount";
    ((Control) this.textboxDiscountAmount).Size = new Size(136, 20);
    ((Control) this.textboxDiscountAmount).TabIndex = 12;
    ((UltraControlBase) this.textboxDiscountAmount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textboxDiscountAmount).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textboxDiscountAmount).Validating += new CancelEventHandler(this.txtExpenseAmount_Validating);
    ((Control) this.textboxDiscountAmount).Leave += new EventHandler(this.FormatDiscountAmt);
    ((Control) this.textboxDiscountAmount).Enter += new EventHandler(this.textboxExpenseAmount_Enter);
    this.comboCostCenters.BorderStyle = (UIElementBorderStyle) 4;
    this.comboCostCenters.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboCostCenters).DataMember = "spFin_GetCostCenters";
    ((UltraGridBase) this.comboCostCenters).DataSource = (object) this.dsCostCenters1;
    ((UltraDropDownBase) this.comboCostCenters).DisplayMember = "Name";
    this.comboCostCenters.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboCostCenters).Location = new Point(96 /*0x60*/, 176 /*0xB0*/);
    this.comboCostCenters.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboCostCenters).Name = "comboCostCenters";
    ((Control) this.comboCostCenters).Size = new Size(304, 21);
    ((Control) this.comboCostCenters).TabIndex = 17;
    ((UltraControlBase) this.comboCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboCostCenters).ValueMember = "CostCenterID";
    this.comboCostCenters.RowSelected += new RowSelectedEventHandler(this.cmbCostCenter_RowSelected);
    ((Control) this.comboCostCenters).Enter += new EventHandler(this.comboCostCenters_Enter);
    this.comboCostCenters.BeforeDropDown += new CancelEventHandler(this.comboCostCenters_BeforeDropDown);
    this.dsCostCenters1.DataSetName = "dsCostCenters";
    this.dsCostCenters1.Locale = new CultureInfo("en-US");
    this.dropTreeGlAccounts.DropDownHeight = 300;
    this.dropTreeGlAccounts.DropDownWidth = 300;
    this.dropTreeGlAccounts.Font = new Font("Tahoma", 8f);
    this.dropTreeGlAccounts.Location = new Point(96 /*0x60*/, 56);
    this.dropTreeGlAccounts.Name = "dropTreeGlAccounts";
    this.dropTreeGlAccounts.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeGlAccounts.ShowEquityAccounts = true;
    this.dropTreeGlAccounts.ShowExpenseAccounts = true;
    this.dropTreeGlAccounts.ShowIncomeAccounts = true;
    this.dropTreeGlAccounts.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeGlAccounts.ShowSystemDefinedAccounts = true;
    this.dropTreeGlAccounts.Size = new Size(304, 20);
    this.dropTreeGlAccounts.TabIndex = 5;
    this.dropTreeGlAccounts.UseCheckedStateSelectionOverride = false;
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
    this.sqlSelectCommand1.CommandText = "[spFin_GetExpenses]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.ControlDataConnection;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, string.Empty, DataRowVersion.Current, (object) null)
    });
    this.ControlDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.ControlDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.daGetCostCenters.SelectCommand = this.sqlSelectCommand2;
    this.daGetCostCenters.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "spFin_GetCostCenters", new DataColumnMapping[4]
      {
        new DataColumnMapping("CostCenterId", "CostCenterId"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("glCompanyId", "glCompanyId")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[5]
      {
        new DataColumnMapping("CostCenterId", "CostCenterId"),
        new DataColumnMapping("entityGuid", "entityGuid"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Entity Type", "Entity Type"),
        new DataColumnMapping("isdefault", "isdefault")
      })
    });
    this.sqlSelectCommand2.CommandText = "[spFin_GetCostCenters]";
    this.sqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand2.Connection = this.ControlDataConnection;
    this.sqlSelectCommand2.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, string.Empty, DataRowVersion.Current, (object) null),
      new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4)
    });
    ((AppearanceBase) appearance12).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance12).BackColor2 = Color.White;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance12).Image = componentResourceManager.GetObject("appearance12.Image");
    ((ControlBase) this.buttonSplitAllocations).Appearance = (AppearanceBase) appearance12;
    ((Control) this.buttonSplitAllocations).Location = new Point(16 /*0x10*/, 200);
    ((Control) this.buttonSplitAllocations).Name = "buttonSplitAllocations";
    ((Control) this.buttonSplitAllocations).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.buttonSplitAllocations).TabIndex = 21;
    ((Control) this.buttonSplitAllocations).Text = "Split Allocation";
    ((UltraControlBase) this.buttonSplitAllocations).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSplitAllocations).Click += new EventHandler(this.buttonSplitAllocations_Click);
    ((AppearanceBase) appearance13).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance13).BackColor2 = Color.White;
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance13).Image = componentResourceManager.GetObject("appearance13.Image");
    ((ControlBase) this.buttonClearAllocations).Appearance = (AppearanceBase) appearance13;
    ((Control) this.buttonClearAllocations).Location = new Point(272, 200);
    ((Control) this.buttonClearAllocations).Name = "buttonClearAllocations";
    ((Control) this.buttonClearAllocations).Size = new Size(128 /*0x80*/, 24);
    ((Control) this.buttonClearAllocations).TabIndex = 22;
    ((Control) this.buttonClearAllocations).Text = "Clear Allocations";
    ((UltraControlBase) this.buttonClearAllocations).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonClearAllocations).Click += new EventHandler(this.buttonClearAllocations_Click);
    ((AppearanceBase) appearance14).BackColor = Color.Gainsboro;
    ((AppearanceBase) appearance14).BackColor2 = Color.White;
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance14).Image = componentResourceManager.GetObject("appearance14.Image");
    ((ControlBase) this.buttonClearExpenseFor).Appearance = (AppearanceBase) appearance14;
    ((Control) this.buttonClearExpenseFor).Enabled = false;
    ((Control) this.buttonClearExpenseFor).Location = new Point(376, 80 /*0x50*/);
    ((Control) this.buttonClearExpenseFor).Name = "buttonClearExpenseFor";
    ((Control) this.buttonClearExpenseFor).Size = new Size(24, 24);
    ((Control) this.buttonClearExpenseFor).TabIndex = 23;
    ((UltraControlBase) this.buttonClearExpenseFor).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonClearExpenseFor).Click += new EventHandler(this.buttonClearExpenseFor_Click);
    ((AppearanceBase) appearance15).BorderColor = Color.Gray;
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkExclude1099).Appearance = (AppearanceBase) appearance15;
    ((UltraToggleEditorBase) this.checkExclude1099).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkExclude1099).Location = new Point(240 /*0xF0*/, 150);
    ((Control) this.checkExclude1099).Name = "checkExclude1099";
    ((Control) this.checkExclude1099).Size = new Size(136, 20);
    ((Control) this.checkExclude1099).TabIndex = 24;
    ((Control) this.checkExclude1099).Text = "Exclude From 1099";
    this.BackColor = Color.White;
    this.Controls.Add((Control) this.checkExclude1099);
    this.Controls.Add((Control) this.buttonClearExpenseFor);
    this.Controls.Add((Control) this.buttonClearAllocations);
    this.Controls.Add((Control) this.buttonSplitAllocations);
    this.Controls.Add((Control) this.dropTreeGlAccounts);
    this.Controls.Add((Control) this.comboCostCenters);
    this.Controls.Add((Control) this.textboxDiscountAmount);
    this.Controls.Add((Control) this.textboxExpenseTotal);
    this.Controls.Add((Control) this.textboxExpenseAmount);
    this.Controls.Add((Control) this.textboxExpenseFor);
    this.Controls.Add((Control) this.comboExpense);
    this.Controls.Add((Control) this.dateTimeExpenseDate);
    this.Controls.Add((Control) this.buttonSearchExpenseFor);
    this.Controls.Add((Control) this.buttonEditAllocations);
    this.Controls.Add((Control) this.buttonSaveExpenseDetail);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.checkboxPercentage);
    this.Controls.Add((Control) this.Label8);
    this.Controls.Add((Control) this.Label7);
    this.Controls.Add((Control) this.Label6);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.Label4);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.Label1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Name = nameof (ExpenseEntry);
    this.Size = new Size(408, 264);
    this.EnabledChanged += new EventHandler(this.ExpenseEntry_EnabledChanged);
    ((ISupportInitialize) this.checkboxPercentage).EndInit();
    ((ISupportInitialize) this.ultraFlowLayoutManager1).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSaveExpenseDetail).EndInit();
    ((ISupportInitialize) this.buttonEditAllocations).EndInit();
    ((ISupportInitialize) this.buttonSearchExpenseFor).EndInit();
    ((ISupportInitialize) this.dateTimeExpenseDate).EndInit();
    ((ISupportInitialize) this.comboExpense).EndInit();
    this.dsExpenses1.EndInit();
    ((ISupportInitialize) this.textboxExpenseFor).EndInit();
    ((ISupportInitialize) this.textboxExpenseAmount).EndInit();
    ((ISupportInitialize) this.textboxExpenseTotal).EndInit();
    ((ISupportInitialize) this.textboxDiscountAmount).EndInit();
    ((ISupportInitialize) this.comboCostCenters).EndInit();
    this.dsCostCenters1.EndInit();
    ((ISupportInitialize) this.buttonSplitAllocations).EndInit();
    ((ISupportInitialize) this.buttonClearAllocations).EndInit();
    ((ISupportInitialize) this.buttonClearExpenseFor).EndInit();
    ((ISupportInitialize) this.checkExclude1099).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal int GlCompanyId
  {
    get => this.glCompanyId;
    set
    {
      this.glCompanyId = value;
      this.LoadGLAccounts();
    }
  }

  public bool IsInitialized => this.isInitialized;

  public bool HasData
  {
    get
    {
      return this.dropTreeGlAccounts.Text != string.Empty || ((Control) this.comboCostCenters).Text != string.Empty;
    }
  }

  public void Initialize()
  {
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.LoadExpenses();
    this.isInitialized = true;
    this.Enabled = true;
  }

  private void LoadExpenses()
  {
    this.dsExpenses1.Expenses.Clear();
    this.daGetExpenses.Fill((DataTable) this.dsExpenses1.Expenses);
  }

  public void LoadGLAccounts()
  {
    this.dropTreeGlAccounts.ResetText();
    this.dropTreeGlAccounts.LoadGLAccounts(this.GlCompanyId);
    this.dropTreeGlAccounts.DropDownHeight = 300;
    this.dropTreeGlAccounts.DropDownWidth = 300;
    this.dsCostCenters1.spFin_GetCostCenters.Clear();
    this.daGetCostCenters.SelectCommand.Parameters["@GlCompanyId"].Value = (object) this.GlCompanyId;
    this.daGetCostCenters.Fill((DataTable) this.dsCostCenters1.spFin_GetCostCenters);
  }

  private void LoadCostCenters()
  {
    this.comboCostCenters.RowSelected -= new RowSelectedEventHandler(this.cmbCostCenter_RowSelected);
    ((DataSet) ((UltraGridBase) this.comboCostCenters).DataSource).Clear();
    ((UltraGridBase) this.comboCostCenters).DataSource = (object) null;
    ((UltraGridBase) this.comboCostCenters).DataMember = string.Empty;
    ((UltraDropDownBase) this.comboCostCenters).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboCostCenters).ValueMember = string.Empty;
    ((UltraGridBase) this.comboCostCenters).DataSource = (object) this.dsCostCenters1;
    ((UltraGridBase) this.comboCostCenters).DataMember = "spfin_GetCostCenters";
    ((UltraDropDownBase) this.comboCostCenters).DisplayMember = "Name";
    ((UltraDropDownBase) this.comboCostCenters).ValueMember = "CostCenterId";
    this.daGetCostCenters.SelectCommand.Parameters["@GlCompanyId"].Value = (object) this.GlCompanyId;
    this.daGetCostCenters.Fill((DataTable) this.dsCostCenters1.spFin_GetCostCenters);
    ((Control) this.comboCostCenters).Enabled = true;
    this.comboCostCenters.RowSelected += new RowSelectedEventHandler(this.cmbCostCenter_RowSelected);
  }

  private bool CreateDetailItem()
  {
    if (!this.ValidateForm())
      return false;
    if (this.detailItem == null)
    {
      if (!(this.ParentForm is formNewExpensePO))
        throw new InvalidFormOwnerException(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("InvalidFormOwnerException"));
      this.detailItem = ((formNewExpensePO) this.ParentForm).poObject.CreateNewDetailItem(int.Parse(((UltraDropDownBase) this.comboExpense).SelectedRow.Cells["expensecode"].Value.ToString()));
    }
    else
      this.detailItem.ExpenseCode = int.Parse(((UltraDropDownBase) this.comboExpense).SelectedRow.Cells["expensecode"].Value.ToString());
    this.detailItem.ExpenseDate = this.dateTimeExpenseDate.DateTime;
    this.detailItem.GlAccountId = this.dropTreeGlAccounts.GLAccountID;
    this.detailItem.ExpenseAmount = Decimal.Parse(((Control) this.textboxExpenseAmount).Text, NumberStyles.Currency);
    this.detailItem.IsDiscountPercentage = ((UltraToggleEditorBase) this.checkboxPercentage).Checked;
    this.detailItem.DiscountAmount = ((Control) this.textboxDiscountAmount).Text.Equals(string.Empty) || ((Control) this.textboxDiscountAmount).Text.Length == 0 ? 0M : (!((UltraToggleEditorBase) this.checkboxPercentage).Checked ? Decimal.Parse(((Control) this.textboxDiscountAmount).Text, NumberStyles.Currency) : Decimal.Parse(((Control) this.textboxDiscountAmount).Text.Substring(0, ((Control) this.textboxDiscountAmount).Text.Length - 1), NumberStyles.Any));
    this.detailItem.Is1099Item = !((UltraToggleEditorBase) this.checkExclude1099).Checked;
    return true;
  }

  private bool ValidateForm()
  {
    if (this.ControlMode == Mode.InterMediate)
      return true;
    if (((UltraDropDownBase) this.comboExpense).SelectedRow == null)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ExpenseRequiredToContinue"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.comboExpense.Focus();
      return false;
    }
    if (this.dropTreeGlAccounts.SelectedNodeCount == 0 || this.dropTreeGlAccounts.GLAccountID == -1)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("GL_ACCOUNT_REQUIRED"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.dropTreeGlAccounts.Focus();
      return false;
    }
    if (!((Control) this.textboxExpenseAmount).Text.Equals(string.Empty))
    {
      if (((Control) this.textboxExpenseAmount).Text.Length != 0)
      {
        try
        {
          Decimal.Parse(((Control) this.textboxExpenseAmount).Text, NumberStyles.Currency);
        }
        catch (FormatException ex)
        {
          int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidExpenseAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((TextEditorControlBase) this.textboxExpenseAmount).Focus();
          return false;
        }
        if (!((Control) this.textboxDiscountAmount).Text.Equals(string.Empty))
        {
          if (((Control) this.textboxDiscountAmount).Text.Length != 0)
          {
            try
            {
              Decimal num = 0M;
              num = !((UltraToggleEditorBase) this.checkboxPercentage).Checked ? Decimal.Parse(((Control) this.textboxDiscountAmount).Text, NumberStyles.Currency) : Decimal.Parse(((Control) this.textboxDiscountAmount).Text.Replace("%", ""));
            }
            catch (FormatException ex)
            {
              int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidDiscountAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return false;
            }
          }
        }
        return true;
      }
    }
    int num1 = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidExpenseAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    ((TextEditorControlBase) this.textboxExpenseAmount).Focus();
    return false;
  }

  private void CalculateExpenseTotal()
  {
    Decimal num1;
    try
    {
      num1 = ((Control) this.textboxExpenseAmount).Text.Length == 0 || ((Control) this.textboxExpenseAmount).Text.Equals(string.Empty) ? 0M : Decimal.Parse(((Control) this.textboxExpenseAmount).Text, NumberStyles.Currency);
    }
    catch (FormatException ex)
    {
      num1 = 0M;
    }
    Decimal num2;
    try
    {
      num2 = !((UltraToggleEditorBase) this.checkboxPercentage).Checked ? (((Control) this.textboxDiscountAmount).Text.Length == 0 || ((Control) this.textboxDiscountAmount).Text.Equals(string.Empty) ? 0M : Decimal.Parse(((Control) this.textboxDiscountAmount).Text, NumberStyles.Currency)) : (((Control) this.textboxDiscountAmount).Text.Length == 0 || ((Control) this.textboxDiscountAmount).Text.Equals(string.Empty) ? 0M : Decimal.Parse(((Control) this.textboxDiscountAmount).Text.Replace("%", "")));
    }
    catch (FormatException ex)
    {
      num2 = 0M;
    }
    if (num2 == 0M)
      ((Control) this.textboxExpenseTotal).Text = num1.ToString("c");
    else if (((UltraToggleEditorBase) this.checkboxPercentage).Checked)
      ((Control) this.textboxExpenseTotal).Text = (num1 - num1 * (num2 / 100M)).ToString("c");
    else
      ((Control) this.textboxExpenseTotal).Text = (num1 - num2).ToString("c");
  }

  private void FormatDiscountAmt(object sender, EventArgs e)
  {
    if (this.ControlMode == Mode.InterMediate)
      return;
    if (((Control) this.textboxDiscountAmount).Text.Equals(string.Empty) || ((Control) this.textboxDiscountAmount).Text.Length == 0)
    {
      ((Control) this.textboxDiscountAmount).Text = MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ZeroDollarAmount");
    }
    else
    {
      if (((UltraToggleEditorBase) this.checkboxPercentage).Checked)
      {
        if (!((Control) this.textboxDiscountAmount).Text.Equals(string.Empty))
        {
          if (((Control) this.textboxDiscountAmount).Text.Length != 0)
          {
            try
            {
              ((Control) this.textboxDiscountAmount).Text = (Decimal.Parse(((Control) this.textboxDiscountAmount).Text.Replace("%", ""), NumberStyles.Currency) / 100M).ToString("P");
              goto label_14;
            }
            catch (FormatException ex)
            {
              int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidDiscountAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
          }
        }
        ((Control) this.textboxDiscountAmount).Text = MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ZeroPercentage");
      }
      else
      {
        if (!((Control) this.textboxDiscountAmount).Text.Equals(string.Empty))
        {
          if (((Control) this.textboxDiscountAmount).Text.Length != 0)
          {
            try
            {
              ((Control) this.textboxDiscountAmount).Text = ((Control) this.textboxDiscountAmount).Text.Replace("%", "");
              ((Control) this.textboxDiscountAmount).Text = Decimal.Parse(((Control) this.textboxDiscountAmount).Text, NumberStyles.Currency).ToString("c");
              goto label_14;
            }
            catch (FormatException ex)
            {
              int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidDiscountAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              return;
            }
          }
        }
        ((Control) this.textboxDiscountAmount).Text = MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ZeroDollarAmount");
      }
label_14:
      this.CalculateExpenseTotal();
    }
  }

  private void SetSelectedCostCenter(int CostCenterId)
  {
    if (!this.CreateDetailItem())
      return;
    if (this.detailItem.CostCenterAllocations.Count == 0)
    {
      ((Control) this.comboCostCenters).Tag = (object) this.comboCostCenters.SelectedIndex;
      this.detailItem.CostCenterAllocations.Add(new CostCenterAllocation(CostCenterId, this.detailItem.ExpenseTotal), this.detailItem.ExpenseAmount);
    }
    else
    {
      if (this.ControlMode == Mode.InterMediate || MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OverwriteExistingCostCenterAllocations"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OverwriteAllocationHeader"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.detailItem.CostCenterAllocations.Clear();
        this.detailItem.CostCenterAllocations.Add(new CostCenterAllocation(CostCenterId, this.detailItem.ExpenseTotal), this.detailItem.ExpenseAmount);
        ((Control) this.comboCostCenters).Tag = (object) this.comboCostCenters.SelectedIndex;
      }
      else
      {
        this.isChangingCostCenter = false;
        this.comboCostCenters.SelectedIndex = int.Parse(((Control) this.comboCostCenters).Tag.ToString());
      }
      this.comboCostCenters.PerformAction((UltraComboAction) 2);
    }
  }

  private void DisplayCurrentDetailObject()
  {
    this.dateTimeExpenseDate.Value = (object) this.detailItem.ExpenseDate;
    this.comboExpense.Value = (object) this.detailItem.ExpenseCode;
    this.dropTreeGlAccounts.SetSelectedNodeByKey(this.detailItem.GlAccountId.ToString());
    ((Control) this.textboxExpenseAmount).Text = this.detailItem.ExpenseAmount.ToString("c");
    Decimal num;
    if (this.detailItem.DiscountAmount > 0M)
    {
      MGATextBox textboxDiscountAmount = this.textboxDiscountAmount;
      num = this.detailItem.DiscountAmount;
      string str = num.ToString("c");
      ((Control) textboxDiscountAmount).Text = str;
      ((UltraToggleEditorBase) this.checkboxPercentage).Checked = this.detailItem.IsDiscountPercentage;
    }
    MGATextBox textboxExpenseTotal = this.textboxExpenseTotal;
    num = this.detailItem.ExpenseTotal;
    string str1 = num.ToString("c");
    ((Control) textboxExpenseTotal).Text = str1;
    if (!this.detailItem.ExpenseFor.Equals(Guid.Empty))
      ((Control) this.textboxExpenseFor).Text = this.detailItem.ExpenseForName;
    if (this.detailItem.CostCenterAllocations.Count > 1)
    {
      this.comboCostCenters.Value = (object) 99999;
    }
    else
    {
      this.comboCostCenters.Value = (object) this.detailItem.CostCenterAllocations[0].CostCenterId;
      ((Control) this.comboCostCenters).Text = this.detailItem.CostCenterAllocations[0].CostCenterName;
    }
    ((Control) this.buttonEditAllocations).Visible = this.detailItem.CostCenterAllocations.Count >= 1;
    ((UltraToggleEditorBase) this.checkExclude1099).Checked = !this.detailItem.Is1099Item;
  }

  private void txtExpenseAmount_Validating(object sender, CancelEventArgs e)
  {
    if (!((Control) this.textboxExpenseAmount).Text.Equals(string.Empty) && ((Control) this.textboxExpenseAmount).Text.Length != 0)
    {
      if (!Information.IsNumeric((object) ((Control) this.textboxExpenseAmount).Text) || !Utility.IsDecimalValue((object) ((Control) this.textboxExpenseAmount).Text))
      {
        int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ValidExpenseAmountRequired"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("INVALIDENTRY"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        e.Cancel = true;
        return;
      }
      ((Control) this.textboxExpenseAmount).Text = Decimal.Parse(((Control) this.textboxExpenseAmount).Text, NumberStyles.Currency).ToString("c");
    }
    else
      ((Control) this.textboxExpenseAmount).Text = MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ZeroDollarAmount");
    MGATextBox mgaTextBox = (MGATextBox) sender;
    Decimal num1;
    try
    {
      num1 = Decimal.Parse(((Control) mgaTextBox).Text.Replace("%", ""), NumberStyles.Currency);
    }
    catch (FormatException ex)
    {
      ((TextEditorControlBase) mgaTextBox).Focus();
      return;
    }
    if (num1 == 0M)
      return;
    if (((Control) mgaTextBox).Tag.ToString() != ((Control) mgaTextBox).Text && this.comboCostCenters.SelectedIndex != -1)
    {
      if (MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OverwriteExistingCostCenterAllocations"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OverwriteAllocationHeader"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
      {
        this.LoadCostCenters();
        this.comboCostCenters.SelectedIndex = -1;
        if (this.detailItem != null && this.detailItem.CostCenterAllocations != null)
          this.detailItem.CostCenterAllocations.Clear();
      }
      else
      {
        ((Control) mgaTextBox).Text = ((Control) mgaTextBox).Tag.ToString();
        e.Cancel = true;
        return;
      }
    }
    this.CalculateExpenseTotal();
  }

  private void cmbCostCenter_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboCostCenters).SelectedRow == null)
      return;
    if (!this.isChangingCostCenter)
    {
      this.isChangingCostCenter = true;
    }
    else
    {
      if (this.detailItem == null || this.detailItem.CostCenterAllocations.Count > 1)
        return;
      this.SetSelectedCostCenter(int.Parse(((UltraDropDownBase) this.comboCostCenters).SelectedRow.Cells["costcenterid"].Value.ToString()));
    }
  }

  private void buttonSearchExpenseFor_Click(object sender, EventArgs e)
  {
    if (this.detailItem == null && ((UltraDropDownBase) this.comboExpense).SelectedRow == null)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ExpenseRequiredToContinue"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.comboExpense.Focus();
    }
    else
    {
      FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.ShowCompanyGroup | Utility.SearchEntityTypes.ShowCompany | Utility.SearchEntityTypes.ShowCompanyLocations | Utility.SearchEntityTypes.ShowCompanyLines | Utility.SearchEntityTypes.ShowInsured | Utility.SearchEntityTypes.ShowIntermediary | Utility.SearchEntityTypes.ShowProducer | Utility.SearchEntityTypes.ShowUsers | Utility.SearchEntityTypes.ShowExpensePayees | Utility.SearchEntityTypes.Show3rdParty | Utility.SearchEntityTypes.ShowFinanceCompanies | Utility.SearchEntityTypes.ShowInspectionCompanies);
      try
      {
        if (formSearchEntity.ShowDialog() != DialogResult.OK)
          return;
        ((Control) this.buttonClearExpenseFor).Enabled = true;
        ((Control) this.textboxExpenseFor).Text = formSearchEntity.EntityName;
        this.detailItem.ExpenseFor = formSearchEntity.EntityGuid;
      }
      finally
      {
        formSearchEntity.Dispose();
      }
    }
  }

  private void buttonClearExpenseFor_Click(object sender, EventArgs e)
  {
    if (MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("DeleteExistingExpenseFor"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("DeleteExpenseForHeader"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    ((Control) this.textboxExpenseFor).Text = "";
    this.detailItem.ExpenseFor = Guid.Empty;
    ((Control) this.buttonClearExpenseFor).Enabled = false;
  }

  private void cmbExpense_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboExpense).SelectedRow == null)
      return;
    if (this.detailItem == null)
    {
      if (!(this.ParentForm is formNewExpensePO))
        throw new InvalidFormOwnerException(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("InvalidFormOwnerException"));
      this.detailItem = ((formNewExpensePO) this.ParentForm).poObject.CreateNewDetailItem(int.Parse(((UltraDropDownBase) this.comboExpense).SelectedRow.Cells["expensecode"].Value.ToString()));
    }
    this.dropTreeGlAccounts.SetSelectedNodeByKey(Expense.GetExpenseDefaultGLAccount(int.Parse(((UltraDropDownBase) this.comboExpense).SelectedRow.Cells["expenseCode"].Value.ToString()), this.GlCompanyId).ToString());
  }

  private void EnableControl()
  {
    foreach (Control control in (ArrangedElementCollection) this.Controls)
      control.Enabled = (control.Tag == null || !(control.Tag.ToString() == "0")) && this.Enabled;
    this.Invalidate(true);
  }

  private void ExpenseEntry_EnabledChanged(object sender, EventArgs e) => this.EnableControl();

  private void comboCostCenters_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (((UltraDropDownBase) this.comboCostCenters).SelectedRow == null)
      e.Cancel = false;
    else
      e.Cancel = !this.ValidateForm();
  }

  internal void ClearScreen()
  {
    this.detailItem = (PurchaseOrderExpenseDetail) null;
    ((UltraToggleEditorBase) this.checkboxPercentage).Checked = false;
    foreach (Control control in (ArrangedElementCollection) this.Controls)
    {
      if (control is MGATextBox)
        control.Text = "";
      else if (control is MGADateTimePicker)
        ((UltraDateTimeEditor) control).DateTime = DateTime.Now;
      else if (control is MGASimpleComboBox)
      {
        control.Tag = (object) null;
        control.ResetText();
        control.Enabled = true;
      }
      if (control is ExtendedTreeViewDropDown)
        control.ResetText();
    }
    ((UltraToggleEditorBase) this.checkboxPercentage).Checked = false;
    ((UltraToggleEditorBase) this.checkExclude1099).Checked = false;
    this.LoadCostCenters();
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.CreateDetailItem())
      return;
    if (this.detailItem == null || this.detailItem.State == PurchaseOrderExpenseDetail.DetailObjectState.InComplete)
    {
      int num1 = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("CANNOT_SAVE_DETAILITEM"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this.detailItem.ExpenseAmount == 0M)
    {
      int num2 = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ZERO_EXPENSE_AMOUNT"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("ZERO_EXPENSE_AMOUNT_TITLE"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      formNewExpensePO parentForm = (formNewExpensePO) this.ParentForm;
      try
      {
        if (this.ControlMode == Mode.Edit)
        {
          this.CalculateExpenseTotal();
          parentForm.poObject.ExpenseDetails.RemoveAt(this.EditRowIndex);
          parentForm.poObject.ExpenseDetails.Add(this.detailItem);
          ((Control) this.buttonSaveExpenseDetail).Text = "Save Detail";
          this.ControlMode = Mode.New;
          this.detailItem = (PurchaseOrderExpenseDetail) null;
        }
        else
          parentForm.poObject.ExpenseDetails.Add(this.detailItem);
        this.ControlMode = Mode.Clearing;
        this.ClearScreen();
        this.ControlMode = Mode.New;
      }
      catch (ExpenseDetailItemAlreadyExists ex)
      {
        int num3 = (int) MessageBox.Show(ex.Message);
      }
      ((Control) this.buttonClearExpenseFor).Enabled = false;
      ((Control) parentForm.gridPODetails).Enabled = true;
    }
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    if (this.ControlMode == Mode.Edit)
    {
      ((Control) this.buttonSaveExpenseDetail).Text = "Save Detail";
      this.ControlMode = Mode.New;
      ((Control) ((formNewExpensePO) this.ParentForm).gridPODetails).Enabled = true;
    }
    ((Control) this.buttonClearExpenseFor).Enabled = false;
    this.ControlMode = Mode.Clearing;
    this.ClearScreen();
    this.ControlMode = Mode.New;
    ((Control) ((formNewExpensePO) this.ParentForm).gridPODetails).Enabled = true;
  }

  private void SetMultipleCostCenters()
  {
    DataSet dataSet = new DataSet();
    dataSet.Tables.Add(new DataTable()
    {
      Columns = {
        new DataColumn("Multi1", typeof (int)),
        new DataColumn("Multi2", typeof (string))
      },
      Rows = {
        new object[2]{ (object) 99999, (object) "Multiple..." }
      }
    });
    ((UltraGridBase) this.comboCostCenters).DataSource = (object) null;
    ((UltraGridBase) this.comboCostCenters).DataMember = string.Empty;
    ((UltraDropDownBase) this.comboCostCenters).DisplayMember = string.Empty;
    ((UltraDropDownBase) this.comboCostCenters).ValueMember = string.Empty;
    ((UltraGridBase) this.comboCostCenters).DataSource = (object) dataSet;
    ((UltraDropDownBase) this.comboCostCenters).DisplayMember = "Multi2";
    ((UltraDropDownBase) this.comboCostCenters).ValueMember = "Multi1";
    this.comboCostCenters.RowSelected -= new RowSelectedEventHandler(this.cmbCostCenter_RowSelected);
    ((UltraDropDownBase) this.comboCostCenters).SelectedRow = ((UltraGridBase) this.comboCostCenters).Rows[0];
    ((Control) this.comboCostCenters).Enabled = false;
  }

  private void LoadCostCenterAllocationsDialog()
  {
    if (!this.CreateDetailItem())
      return;
    formCostCenterAllocation centerAllocation = new formCostCenterAllocation((ISupportCostCenterAllocation) this.detailItem, this.glCompanyId);
    try
    {
      if (centerAllocation.ShowDialog() != DialogResult.OK)
        return;
      this.detailItem = (PurchaseOrderExpenseDetail) centerAllocation.TransactionDetail;
      if (this.detailItem.CostCenterAllocations.Count == 1)
      {
        this.ControlMode = Mode.InterMediate;
        this.LoadCostCenters();
        this.SetCostCenter(this.detailItem.CostCenterAllocations[0].CostCenterName);
        this.ControlMode = Mode.New;
      }
      else
        this.SetMultipleCostCenters();
    }
    finally
    {
      centerAllocation.Dispose();
    }
  }

  public void SetCostCenter(string costCenterName)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.comboCostCenters).Rows)
    {
      if (row.Cells[1].Value.ToString() == costCenterName)
      {
        ((UltraDropDownBase) this.comboCostCenters).SelectedRow = row;
        break;
      }
    }
  }

  private void buttonSplitAllocations_Click(object sender, EventArgs e)
  {
    this.LoadCostCenterAllocationsDialog();
  }

  private void buttonEditAllocations_Click(object sender, EventArgs e)
  {
    this.LoadCostCenterAllocationsDialog();
  }

  private void buttonClearAllocations_Click(object sender, EventArgs e)
  {
    if (this.detailItem == null)
      return;
    this.detailItem.CostCenterAllocations.Clear();
    this.LoadCostCenters();
  }

  internal void ClearGlAccountAndCostCenter() => this.LoadGLAccounts();

  private void comboCostCenters_Enter(object sender, EventArgs e)
  {
    this.isChangingCostCenter = true;
    ((Control) this.comboCostCenters).Tag = (object) this.comboCostCenters.SelectedIndex;
  }

  private void textboxExpenseAmount_Enter(object sender, EventArgs e)
  {
    MGATextBox mgaTextBox = (MGATextBox) sender;
    ((Control) mgaTextBox).Tag = ((TextEditorControlBase) mgaTextBox).Value != null ? ((TextEditorControlBase) mgaTextBox).Value : (object) "$0.00";
  }

  public void populateControlsForEdit(PurchaseOrderExpenseDetail detail, int rowIndex)
  {
    this.ControlMode = Mode.InterMediate;
    this.EditRowIndex = rowIndex;
    ((Control) this.buttonSaveExpenseDetail).Text = "Save Changes";
    this.detailItem = (PurchaseOrderExpenseDetail) detail.Clone();
    this.DisplayCurrentDetailObject();
    if (this.ControlMode == Mode.InterMediate && this.detailItem.IsDiscountPercentage)
      ((Control) this.textboxDiscountAmount).Text = this.detailItem.DiscountAmount.ToString() + "0 %";
    if (this.detailItem.CostCenterAllocations.Count > 1)
      this.SetMultipleCostCenters();
    ((Control) this.buttonClearExpenseFor).Enabled = !(((Control) this.textboxExpenseFor).Text == "");
    this.ControlMode = Mode.Edit;
  }

  private void checkboxPercentage_BeforeCheckStateChanged(object sender, CancelEventArgs e)
  {
    if (((Control) this.textboxDiscountAmount).Text == "")
      ((Control) this.textboxDiscountAmount).Text = "0.00 %";
    if (this.ControlMode == Mode.InterMediate || Decimal.Parse(((Control) this.textboxDiscountAmount).Text.Replace("%", " "), NumberStyles.Currency) == 0M)
      return;
    if (this.ControlMode != Mode.Clearing && this.comboCostCenters.SelectedIndex != -1 && MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OverwriteExistingCostCenterAllocations"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OverwriteAllocationHeader"), MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
    {
      e.Cancel = true;
    }
    else
    {
      if (this.detailItem == null)
        return;
      this.detailItem.CostCenterAllocations.Clear();
      this.LoadCostCenters();
      this.comboCostCenters.SelectedIndex = -1;
      ((Control) this.comboCostCenters).Enabled = true;
    }
  }
}
