// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formNewExpensePO
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms;
using MGASystems.IMS.Accounting.GeneralLedger.ClassObjects;
using MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects;
using MGASystems.IMS.Accounting.OperatingExpenses.UserControls;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

public class formNewExpensePO : Form
{
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _formNewExpensePO_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formNewExpensePO_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formNewExpensePO_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formNewExpensePO_Toolbars_Dock_Area_Bottom;
  private SqlDataAdapter daGetBankAccounts;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection FormDataConnection;
  private SqlDataAdapter daGetOfficeLocations;
  private SqlCommand sqlSelectCommand2;
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
  private MGAGroupBox mgaGroupBox2;
  internal UltraGrid gridPODetails;
  private MGAGroupBox mgaGroupBox1;
  internal Label labelGlOffset;
  private ExtendedTreeViewDropDown dropTreeOffsetAccount;
  internal Label Label9;
  internal Label label12;
  internal Label Label7;
  private MGADateTimePicker datePickerDueDate;
  internal Label label11;
  private MGASimpleComboBox comboBankAccount;
  private MGATextBox textPayeeName;
  private Label label1;
  internal Label Label6;
  internal Label Label8;
  private MGATextBox textMemo;
  private MGATextBox textInvoiceNumber;
  private MGATextBox textPaymentTerms;
  private MGADateTimePicker datePickerPODate;
  private MGASimpleComboBox comboOfficeLocation;
  internal Label label2;
  internal Label Label3;
  internal Label label13;
  private MGASimpleComboBox comboPaymentType;
  private MGADateTimePicker datePickerReceivedDate;
  protected CheckBox checkCreateCheck;
  private dsBankAccounts dsBankAccounts1;
  private dsOfficeLocations dsOfficeLocations1;
  private ExpenseEntry expenseEntry1;
  private IContainer components;
  private Guid entityGuid;
  private string entityName;
  internal PurchaseOrderExpense poObject;

  public formNewExpensePO() => this.InitializeComponent();

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formNewExpensePO));
    UltraToolbar ultraToolbar = new UltraToolbar("PurchaseOrderToolbar");
    ButtonTool buttonTool1 = new ButtonTool("FindPayee");
    ButtonTool buttonTool2 = new ButtonTool("ScheduleExpense");
    ButtonTool buttonTool3 = new ButtonTool("PostExpense");
    ButtonTool buttonTool4 = new ButtonTool("PayeeCommissions");
    Appearance appearance2 = new Appearance();
    ButtonTool buttonTool5 = new ButtonTool("PostExpense");
    Appearance appearance3 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("PayeeCommissions");
    ButtonTool buttonTool7 = new ButtonTool("ScheduleExpense");
    ButtonTool buttonTool8 = new ButtonTool("FindPayee");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
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
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.ultraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this._formNewExpensePO_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formNewExpensePO_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formNewExpensePO_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formNewExpensePO_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.daGetBankAccounts = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.daGetOfficeLocations = new SqlDataAdapter();
    this.sqlSelectCommand2 = new SqlCommand();
    this.mgaGroupBox2 = new MGAGroupBox();
    this.gridPODetails = new UltraGrid();
    this.mgaGroupBox1 = new MGAGroupBox();
    this.checkCreateCheck = new CheckBox();
    this.labelGlOffset = new Label();
    this.dropTreeOffsetAccount = new ExtendedTreeViewDropDown();
    this.Label9 = new Label();
    this.label12 = new Label();
    this.Label7 = new Label();
    this.datePickerDueDate = new MGADateTimePicker();
    this.label11 = new Label();
    this.comboBankAccount = new MGASimpleComboBox();
    this.dsBankAccounts1 = new dsBankAccounts();
    this.textPayeeName = new MGATextBox();
    this.label1 = new Label();
    this.Label6 = new Label();
    this.Label8 = new Label();
    this.textMemo = new MGATextBox();
    this.textInvoiceNumber = new MGATextBox();
    this.textPaymentTerms = new MGATextBox();
    this.datePickerPODate = new MGADateTimePicker();
    this.comboOfficeLocation = new MGASimpleComboBox();
    this.dsOfficeLocations1 = new dsOfficeLocations();
    this.label2 = new Label();
    this.Label3 = new Label();
    this.label13 = new Label();
    this.comboPaymentType = new MGASimpleComboBox();
    this.datePickerReceivedDate = new MGADateTimePicker();
    this.expenseEntry1 = new ExpenseEntry();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    ((ISupportInitialize) this.mgaGroupBox2).BeginInit();
    ((Control) this.mgaGroupBox2).SuspendLayout();
    ((ISupportInitialize) this.gridPODetails).BeginInit();
    ((ISupportInitialize) this.mgaGroupBox1).BeginInit();
    ((Control) this.mgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.datePickerDueDate).BeginInit();
    ((ISupportInitialize) this.comboBankAccount).BeginInit();
    this.dsBankAccounts1.BeginInit();
    ((ISupportInitialize) this.textPayeeName).BeginInit();
    ((ISupportInitialize) this.textMemo).BeginInit();
    ((ISupportInitialize) this.textInvoiceNumber).BeginInit();
    ((ISupportInitialize) this.textPaymentTerms).BeginInit();
    ((ISupportInitialize) this.datePickerPODate).BeginInit();
    ((ISupportInitialize) this.comboOfficeLocation).BeginInit();
    this.dsOfficeLocations1.BeginInit();
    ((ISupportInitialize) this.comboPaymentType).BeginInit();
    ((ISupportInitialize) this.datePickerReceivedDate).BeginInit();
    this.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(0, 0);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(200, 100);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(494, 43);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(421, 288);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 0;
    ((Control) this.ultraExplorerBarContainerControl3).Location = new Point(22, 387);
    ((Control) this.ultraExplorerBarContainerControl3).Name = "ultraExplorerBarContainerControl3";
    ((Control) this.ultraExplorerBarContainerControl3).Size = new Size(893, 259);
    ((Control) this.ultraExplorerBarContainerControl3).TabIndex = 2;
    ((AppearanceBase) appearance1).ImageBackground = (Image) componentResourceManager.GetObject("appearance1.ImageBackground");
    this.ultraToolbarsManager1.Appearance = (AppearanceBase) appearance1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (AccountingNoteDocumentSupport);
    this.ultraToolbarsManager1.LockToolbars = true;
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(17, 138);
    ultraToolbar.FloatingSize = new Size(567, 24);
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool4).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 1;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).AlphaLevel = (short) 62;
    ((AppearanceBase) appearance2).BackColor = Color.Lavender;
    ((AppearanceBase) appearance2).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((AppearanceBase) appearance2).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance2).ImageAlpha = (Alpha) 2;
    ((SettingsBase) ultraToolbar.Settings).Appearance = (AppearanceBase) appearance2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) ultraToolbar.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ultraToolbar.Text = "PurchaseOrderToolbar";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance3).Image = componentResourceManager.GetObject("appearance3.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).Caption = "Post Expense";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).Caption = "Payee Commissions";
    ((ToolBase) buttonTool6).SharedProps.Visible = false;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedProps).Caption = "Schedule Expense";
    ((ToolBase) buttonTool7).SharedProps.Visible = false;
    ((AppearanceBase) appearance4).Image = componentResourceManager.GetObject("appearance4.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedProps).Caption = "Find Payee";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BackColor2 = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance5;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnCount = 2;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl2);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl3);
    ((Control) this.ultraExplorerBar1).Font = new Font("Tahoma", 8f);
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 290;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Payee Information";
    explorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 290;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Expense Schedule";
    explorerBarGroup3.ColumnsSpanned = 2;
    explorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
    explorerBarGroup3.Settings.ContainerHeight = 261;
    explorerBarGroup3.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    explorerBarGroup3.Text = "Expense Details";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance7).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance7).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance7).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance7).ForegroundAlpha = (Alpha) 2;
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance8;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSpacing = 10;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 0);
    this.ultraExplorerBar1.Margins.Bottom = 8;
    this.ultraExplorerBar1.Margins.Left = 8;
    this.ultraExplorerBar1.Margins.Right = 8;
    this.ultraExplorerBar1.Margins.Top = 8;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(930, 656);
    ((Control) this.ultraExplorerBar1).TabIndex = 0;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.ultraExplorerBar1.GroupCollapsing += new GroupCollapsingEventHandler(this.ultraExplorerBar1_GroupCollapsing);
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formNewExpensePO_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).Location = new Point(0, 25);
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).Name = "_formNewExpensePO_Toolbars_Dock_Area_Left";
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).Size = new Size(0, 499);
    this._formNewExpensePO_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formNewExpensePO_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).Location = new Point(818, 25);
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).Name = "_formNewExpensePO_Toolbars_Dock_Area_Right";
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).Size = new Size(0, 499);
    this._formNewExpensePO_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formNewExpensePO_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).Name = "_formNewExpensePO_Toolbars_Dock_Area_Top";
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).Size = new Size(818, 25);
    this._formNewExpensePO_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formNewExpensePO_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).Location = new Point(0, 524);
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).Name = "_formNewExpensePO_Toolbars_Dock_Area_Bottom";
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).Size = new Size(818, 0);
    this._formNewExpensePO_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.daGetBankAccounts.SelectCommand = this.sqlSelectCommand1;
    this.daGetBankAccounts.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetBankAccounts", new DataColumnMapping[3]
      {
        new DataColumnMapping("GLACCTID", "GLACCTID"),
        new DataColumnMapping("BANKNAME", "BANKNAME"),
        new DataColumnMapping("CLOSED", "CLOSED")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_GetBankAccounts]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.sqlSelectCommand1.Parameters.AddRange(new SqlParameter[2]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, MGASystems.IMS.Accounting.OperatingExpenses.Strings.EmptyString, DataRowVersion.Current, (object) null),
      new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    this.daGetOfficeLocations.SelectCommand = this.sqlSelectCommand2;
    this.daGetOfficeLocations.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOfficeLocations", new DataColumnMapping[2]
      {
        new DataColumnMapping("ID", "ID"),
        new DataColumnMapping("Office Location", "Office Location")
      })
    });
    this.sqlSelectCommand2.CommandText = "[spFin_GetOfficeLocations]";
    this.sqlSelectCommand2.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand2.Connection = this.FormDataConnection;
    this.sqlSelectCommand2.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, MGASystems.IMS.Accounting.OperatingExpenses.Strings.EmptyString, DataRowVersion.Current, (object) null)
    });
    this.mgaGroupBox2.BackColorInternal = Color.White;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mgaGroupBox2.ContentAreaAppearance = (AppearanceBase) appearance9;
    ((Control) this.mgaGroupBox2).Controls.Add((Control) this.expenseEntry1);
    ((Control) this.mgaGroupBox2).Controls.Add((Control) this.gridPODetails);
    ((Control) this.mgaGroupBox2).Dock = DockStyle.Fill;
    ((Control) this.mgaGroupBox2).Font = new Font("Tahoma", 8f);
    ((AppearanceBase) appearance10).AlphaLevel = (short) 210;
    ((AppearanceBase) appearance10).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance10).ForeColor = Color.White;
    ((AppearanceBase) appearance10).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance10).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance10).ImageBackground = (Image) componentResourceManager.GetObject("appearance10.ImageBackground");
    ((AppearanceBase) appearance10).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.mgaGroupBox2.HeaderAppearance = (AppearanceBase) appearance10;
    ((Control) this.mgaGroupBox2).Location = new Point(0, 225);
    ((Control) this.mgaGroupBox2).Name = "mgaGroupBox2";
    ((Control) this.mgaGroupBox2).Size = new Size(818, 299);
    ((Control) this.mgaGroupBox2).TabIndex = 1;
    ((Control) this.mgaGroupBox2).Text = "Expense Detail Information";
    this.mgaGroupBox2.ViewStyle = (GroupBoxViewStyle) 2;
    ((Control) this.gridPODetails).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.gridPODetails).Cursor = Cursors.Default;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance11).FontData.Name = "Tahoma";
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance12).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    ((AppearanceBase) appearance13).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance13).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance13).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance13).ForeColor = Color.DimGray;
    ((AppearanceBase) appearance13).ThemedElementAlpha = (Alpha) 3;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(168, 167, 191);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(112 /*0x70*/, 111, 145);
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.RowSelectorAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance15).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance15).BackColor2 = Color.White;
    ((AppearanceBase) appearance15).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.gridPODetails).Location = new Point(424, 32 /*0x20*/);
    ((Control) this.gridPODetails).Name = "gridPODetails";
    ((Control) this.gridPODetails).Size = new Size(384, (int) byte.MaxValue);
    ((Control) this.gridPODetails).TabIndex = 1;
    ((Control) this.gridPODetails).Visible = false;
    this.gridPODetails.InitializeLayout += new InitializeLayoutEventHandler(this.gridPODetails_InitializeLayout);
    this.gridPODetails.DoubleClickRow += new DoubleClickRowEventHandler(this.gridPODetails_DoubleClickRow);
    this.mgaGroupBox1.BackColorInternal = Color.White;
    ((AppearanceBase) appearance16).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance16).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.mgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance16;
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.checkCreateCheck);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.labelGlOffset);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.dropTreeOffsetAccount);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.Label9);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label12);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.Label7);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.datePickerDueDate);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label11);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.comboBankAccount);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.textPayeeName);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label1);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.Label6);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.Label8);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.textMemo);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.textInvoiceNumber);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.textPaymentTerms);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.datePickerPODate);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.comboOfficeLocation);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label2);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.Label3);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.label13);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.comboPaymentType);
    ((Control) this.mgaGroupBox1).Controls.Add((Control) this.datePickerReceivedDate);
    ((Control) this.mgaGroupBox1).Dock = DockStyle.Top;
    ((Control) this.mgaGroupBox1).Font = new Font("Tahoma", 8f);
    ((AppearanceBase) appearance17).AlphaLevel = (short) 210;
    ((AppearanceBase) appearance17).FontData.SizeInPoints = 10f;
    ((AppearanceBase) appearance17).ForeColor = Color.White;
    ((AppearanceBase) appearance17).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance17).ImageAlpha = (Alpha) 2;
    ((AppearanceBase) appearance17).ImageBackground = (Image) componentResourceManager.GetObject("appearance17.ImageBackground");
    ((AppearanceBase) appearance17).ImageBackgroundAlpha = (Alpha) 1;
    ((AppearanceBase) appearance17).ImageBackgroundStyle = (ImageBackgroundStyle) 3;
    this.mgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance17;
    ((Control) this.mgaGroupBox1).Location = new Point(0, 25);
    ((Control) this.mgaGroupBox1).Name = "mgaGroupBox1";
    ((Control) this.mgaGroupBox1).Size = new Size(818, 200);
    ((Control) this.mgaGroupBox1).TabIndex = 0;
    ((Control) this.mgaGroupBox1).Text = "Payee Information";
    this.mgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.checkCreateCheck.BackColor = Color.FromArgb(239, 247, 253);
    this.checkCreateCheck.Checked = true;
    this.checkCreateCheck.CheckState = CheckState.Checked;
    this.checkCreateCheck.FlatStyle = FlatStyle.Flat;
    this.checkCreateCheck.Location = new Point(112 /*0x70*/, 176 /*0xB0*/);
    this.checkCreateCheck.Name = "checkCreateCheck";
    this.checkCreateCheck.Size = new Size(104, 16 /*0x10*/);
    this.checkCreateCheck.TabIndex = 24;
    this.checkCreateCheck.Text = "Create Check";
    this.checkCreateCheck.UseVisualStyleBackColor = false;
    this.labelGlOffset.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.labelGlOffset.AutoSize = true;
    this.labelGlOffset.BackColor = Color.Transparent;
    this.labelGlOffset.Enabled = false;
    this.labelGlOffset.Location = new Point(448, 56);
    this.labelGlOffset.Name = "labelGlOffset";
    this.labelGlOffset.Size = new Size(84, 13);
    this.labelGlOffset.TabIndex = 16 /*0x10*/;
    this.labelGlOffset.Text = "Offset Account:";
    this.dropTreeOffsetAccount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.dropTreeOffsetAccount.DropDownHeight = 300;
    this.dropTreeOffsetAccount.DropDownWidth = 300;
    this.dropTreeOffsetAccount.Enabled = false;
    this.dropTreeOffsetAccount.Font = new Font("Tahoma", 8f);
    this.dropTreeOffsetAccount.Location = new Point(544, 56);
    this.dropTreeOffsetAccount.Name = "dropTreeOffsetAccount";
    this.dropTreeOffsetAccount.ShowAssetAccounts = ExtendedTreeViewDropDown.Assets.All;
    this.dropTreeOffsetAccount.ShowEquityAccounts = true;
    this.dropTreeOffsetAccount.ShowExpenseAccounts = true;
    this.dropTreeOffsetAccount.ShowIncomeAccounts = true;
    this.dropTreeOffsetAccount.ShowLiabilityAccounts = ExtendedTreeViewDropDown.Liabilities.All;
    this.dropTreeOffsetAccount.ShowSystemDefinedAccounts = true;
    this.dropTreeOffsetAccount.Size = new Size(264, 20);
    this.dropTreeOffsetAccount.TabIndex = 17;
    this.dropTreeOffsetAccount.UseCheckedStateSelectionOverride = false;
    this.Label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label9.AutoSize = true;
    this.Label9.BackColor = Color.Transparent;
    this.Label9.Location = new Point(448, 128 /*0x80*/);
    this.Label9.Name = "Label9";
    this.Label9.Size = new Size(39, 13);
    this.Label9.TabIndex = 22;
    this.Label9.Text = "Memo:";
    this.label12.AutoSize = true;
    this.label12.BackColor = Color.Transparent;
    this.label12.Location = new Point(16 /*0x10*/, 128 /*0x80*/);
    this.label12.Name = "label12";
    this.label12.Size = new Size(81, 13);
    this.label12.TabIndex = 10;
    this.label12.Text = "Received Date:";
    this.Label7.AutoSize = true;
    this.Label7.BackColor = Color.Transparent;
    this.Label7.Location = new Point(16 /*0x10*/, 56);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(83, 13);
    this.Label7.TabIndex = 4;
    this.Label7.Text = "Office Location:";
    ((AppearanceBase) appearance18).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.datePickerDueDate.Appearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance19).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance19).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance19).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance19).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance19).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance19).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance19).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance19).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance19).ForegroundAlpha = (Alpha) 2;
    this.datePickerDueDate.ButtonAppearance = (AppearanceBase) appearance19;
    this.datePickerDueDate.FormatString = "D";
    ((Control) this.datePickerDueDate).Location = new Point(112 /*0x70*/, 152);
    this.datePickerDueDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.datePickerDueDate).Name = "datePickerDueDate";
    ((Control) this.datePickerDueDate).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.datePickerDueDate).TabIndex = 13;
    ((UltraControlBase) this.datePickerDueDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.datePickerDueDate).UseOsThemes = (DefaultableBoolean) 2;
    this.label11.AutoSize = true;
    this.label11.BackColor = Color.Transparent;
    this.label11.Location = new Point(16 /*0x10*/, 152);
    this.label11.Name = "label11";
    this.label11.Size = new Size(56, 13);
    this.label11.TabIndex = 12;
    this.label11.Text = "Due Date:";
    this.comboBankAccount.BorderStyle = (UIElementBorderStyle) 4;
    this.comboBankAccount.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboBankAccount).DataMember = "spFin_GetBankAccounts";
    ((UltraGridBase) this.comboBankAccount).DataSource = (object) this.dsBankAccounts1;
    ((UltraDropDownBase) this.comboBankAccount).DisplayMember = "BANKNAME";
    this.comboBankAccount.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboBankAccount).Location = new Point(112 /*0x70*/, 80 /*0x50*/);
    this.comboBankAccount.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboBankAccount).Name = "comboBankAccount";
    ((Control) this.comboBankAccount).Size = new Size(264, 21);
    ((Control) this.comboBankAccount).TabIndex = 7;
    ((UltraControlBase) this.comboBankAccount).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboBankAccount).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboBankAccount).ValueMember = "GLACCTID";
    this.dsBankAccounts1.DataSetName = "dsBankAccounts";
    this.dsBankAccounts1.Locale = new CultureInfo("en-US");
    ((AppearanceBase) appearance20).BackColor = Color.White;
    ((AppearanceBase) appearance20).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPayeeName).Appearance = (AppearanceBase) appearance20;
    ((Control) this.textPayeeName).BackColor = Color.White;
    ((Control) this.textPayeeName).Enabled = false;
    ((Control) this.textPayeeName).Location = new Point(112 /*0x70*/, 32 /*0x20*/);
    this.textPayeeName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPayeeName).Name = "textPayeeName";
    ((Control) this.textPayeeName).Size = new Size(320, 20);
    ((Control) this.textPayeeName).TabIndex = 3;
    ((UltraControlBase) this.textPayeeName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPayeeName).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(16 /*0x10*/, 32 /*0x20*/);
    this.label1.Name = "label1";
    this.label1.Size = new Size(41, 13);
    this.label1.TabIndex = 2;
    this.label1.Text = "Payee:";
    this.Label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(448, 104);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(57, 13);
    this.Label6.TabIndex = 20;
    this.Label6.Text = "Invoice #:";
    this.Label8.AutoSize = true;
    this.Label8.BackColor = Color.Transparent;
    this.Label8.Location = new Point(16 /*0x10*/, 80 /*0x50*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(76, 13);
    this.Label8.TabIndex = 6;
    this.Label8.Text = "Bank Account:";
    ((Control) this.textMemo).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance21).BackColor = Color.White;
    ((AppearanceBase) appearance21).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance21).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textMemo).Appearance = (AppearanceBase) appearance21;
    ((Control) this.textMemo).BackColor = Color.White;
    ((Control) this.textMemo).Location = new Point(544, 128 /*0x80*/);
    this.textMemo.MGAStyle = MGAStyles.Blue;
    this.textMemo.Multiline = true;
    ((Control) this.textMemo).Name = "textMemo";
    ((Control) this.textMemo).Size = new Size(264, 64 /*0x40*/);
    ((Control) this.textMemo).TabIndex = 23;
    ((UltraControlBase) this.textMemo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textMemo).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textInvoiceNumber).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    ((AppearanceBase) appearance22).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance22).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textInvoiceNumber).Appearance = (AppearanceBase) appearance22;
    ((Control) this.textInvoiceNumber).BackColor = Color.White;
    ((Control) this.textInvoiceNumber).Location = new Point(544, 104);
    this.textInvoiceNumber.MGAStyle = MGAStyles.Blue;
    ((Control) this.textInvoiceNumber).Name = "textInvoiceNumber";
    ((Control) this.textInvoiceNumber).Size = new Size(100, 20);
    ((Control) this.textInvoiceNumber).TabIndex = 21;
    ((UltraControlBase) this.textInvoiceNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textInvoiceNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.textInvoiceNumber).Leave += new EventHandler(this.textInvoiceNumber_Leave);
    ((Control) this.textPaymentTerms).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance23).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textPaymentTerms).Appearance = (AppearanceBase) appearance23;
    ((Control) this.textPaymentTerms).BackColor = Color.White;
    ((Control) this.textPaymentTerms).Location = new Point(544, 80 /*0x50*/);
    this.textPaymentTerms.MGAStyle = MGAStyles.Blue;
    ((Control) this.textPaymentTerms).Name = "textPaymentTerms";
    ((Control) this.textPaymentTerms).Size = new Size(100, 20);
    ((Control) this.textPaymentTerms).TabIndex = 19;
    ((UltraControlBase) this.textPaymentTerms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textPaymentTerms).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.datePickerPODate.Appearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance25).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance25).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance25).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance25).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance25).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance25).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance25).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance25).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance25).ForegroundAlpha = (Alpha) 2;
    this.datePickerPODate.ButtonAppearance = (AppearanceBase) appearance25;
    this.datePickerPODate.FormatString = "D";
    ((Control) this.datePickerPODate).Location = new Point(112 /*0x70*/, 104);
    this.datePickerPODate.MGAStyle = MGAStyles.Blue;
    ((Control) this.datePickerPODate).Name = "datePickerPODate";
    ((Control) this.datePickerPODate).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.datePickerPODate).TabIndex = 9;
    ((UltraControlBase) this.datePickerPODate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.datePickerPODate).UseOsThemes = (DefaultableBoolean) 2;
    this.comboOfficeLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.comboOfficeLocation.CharacterCasing = CharacterCasing.Normal;
    ((UltraGridBase) this.comboOfficeLocation).DataMember = "spFin_GetOfficeLocations";
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) this.dsOfficeLocations1;
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    this.comboOfficeLocation.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboOfficeLocation).Location = new Point(112 /*0x70*/, 56);
    this.comboOfficeLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboOfficeLocation).Name = "comboOfficeLocation";
    ((Control) this.comboOfficeLocation).Size = new Size(264, 21);
    ((Control) this.comboOfficeLocation).TabIndex = 5;
    ((UltraControlBase) this.comboOfficeLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboOfficeLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.comboOfficeLocation.RowSelected += new RowSelectedEventHandler(this.comboOfficeLocation_RowSelected);
    this.comboOfficeLocation.BeforeDropDown += new CancelEventHandler(this.comboOfficeLocation_BeforeDropDown);
    this.dsOfficeLocations1.DataSetName = "dsOfficeLocations";
    this.dsOfficeLocations1.Locale = new CultureInfo("en-US");
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(16 /*0x10*/, 104);
    this.label2.Name = "label2";
    this.label2.Size = new Size(51, 13);
    this.label2.TabIndex = 8;
    this.label2.Text = "PO Date:";
    this.Label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(448, 80 /*0x50*/);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(85, 13);
    this.Label3.TabIndex = 18;
    this.Label3.Text = "Payment Terms:";
    this.label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.label13.AutoSize = true;
    this.label13.BackColor = Color.Transparent;
    this.label13.Location = new Point(448, 32 /*0x20*/);
    this.label13.Name = "label13";
    this.label13.Size = new Size(80 /*0x50*/, 13);
    this.label13.TabIndex = 14;
    this.label13.Text = "Payment Type:";
    ((Control) this.comboPaymentType).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.comboPaymentType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboPaymentType.CharacterCasing = CharacterCasing.Normal;
    this.comboPaymentType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboPaymentType).Location = new Point(544, 32 /*0x20*/);
    this.comboPaymentType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboPaymentType).Name = "comboPaymentType";
    ((Control) this.comboPaymentType).Size = new Size(264, 21);
    ((Control) this.comboPaymentType).TabIndex = 15;
    ((UltraControlBase) this.comboPaymentType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPaymentType).UseOsThemes = (DefaultableBoolean) 2;
    this.comboPaymentType.RowSelected += new RowSelectedEventHandler(this.comboPaymentType_RowSelected);
    ((AppearanceBase) appearance26).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.datePickerReceivedDate.Appearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).AlphaLevel = (short) 14;
    ((AppearanceBase) appearance27).BackColor = Color.FromArgb(0, 0, 246, 253);
    ((AppearanceBase) appearance27).BackColor2 = Color.FromArgb(133, 162, 221);
    ((AppearanceBase) appearance27).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance27).BackGradientAlignment = (GradientAlignment) 4;
    ((AppearanceBase) appearance27).BackGradientStyle = (GradientStyle) 5;
    ((AppearanceBase) appearance27).BorderAlpha = (Alpha) 1;
    ((AppearanceBase) appearance27).BorderColor = Color.FromArgb(78, 122, 171);
    ((AppearanceBase) appearance27).ForeColor = Color.FromArgb(49, 85, 153);
    ((AppearanceBase) appearance27).ForegroundAlpha = (Alpha) 2;
    this.datePickerReceivedDate.ButtonAppearance = (AppearanceBase) appearance27;
    this.datePickerReceivedDate.FormatString = "D";
    ((Control) this.datePickerReceivedDate).Location = new Point(112 /*0x70*/, 128 /*0x80*/);
    this.datePickerReceivedDate.MGAStyle = MGAStyles.Blue;
    ((Control) this.datePickerReceivedDate).Name = "datePickerReceivedDate";
    ((Control) this.datePickerReceivedDate).Size = new Size(208 /*0xD0*/, 20);
    ((Control) this.datePickerReceivedDate).TabIndex = 11;
    ((UltraControlBase) this.datePickerReceivedDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.datePickerReceivedDate).UseOsThemes = (DefaultableBoolean) 2;
    this.expenseEntry1.BackColor = Color.Transparent;
    this.expenseEntry1.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.expenseEntry1.Location = new Point(8, 24);
    this.expenseEntry1.Name = "expenseEntry1";
    this.expenseEntry1.Size = new Size(408, 264);
    this.expenseEntry1.TabIndex = 2;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.ClientSize = new Size(818, 524);
    this.Controls.Add((Control) this.mgaGroupBox2);
    this.Controls.Add((Control) this.mgaGroupBox1);
    this.Controls.Add((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MinimumSize = new Size(824, 552);
    this.Name = nameof (formNewExpensePO);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "New Expense / Purchase Order";
    this.Load += new EventHandler(this.formNewExpensePO_Load);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    ((ISupportInitialize) this.mgaGroupBox2).EndInit();
    ((Control) this.mgaGroupBox2).ResumeLayout(false);
    ((ISupportInitialize) this.gridPODetails).EndInit();
    ((ISupportInitialize) this.mgaGroupBox1).EndInit();
    ((Control) this.mgaGroupBox1).ResumeLayout(false);
    ((Control) this.mgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.datePickerDueDate).EndInit();
    ((ISupportInitialize) this.comboBankAccount).EndInit();
    this.dsBankAccounts1.EndInit();
    ((ISupportInitialize) this.textPayeeName).EndInit();
    ((ISupportInitialize) this.textMemo).EndInit();
    ((ISupportInitialize) this.textInvoiceNumber).EndInit();
    ((ISupportInitialize) this.textPaymentTerms).EndInit();
    ((ISupportInitialize) this.datePickerPODate).EndInit();
    ((ISupportInitialize) this.comboOfficeLocation).EndInit();
    this.dsOfficeLocations1.EndInit();
    ((ISupportInitialize) this.comboPaymentType).EndInit();
    ((ISupportInitialize) this.datePickerReceivedDate).EndInit();
    this.ResumeLayout(false);
  }

  public Guid EntityGuid => this.entityGuid;

  public string EntityName => this.entityName;

  private void buttonFindPayee_Click(object sender, EventArgs e) => this.FindPayee();

  private void FindPayee()
  {
    FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.ShowCompanyGroup | Utility.SearchEntityTypes.ShowCompany | Utility.SearchEntityTypes.ShowCompanyLocations | Utility.SearchEntityTypes.ShowCompanyLines | Utility.SearchEntityTypes.ShowInsured | Utility.SearchEntityTypes.ShowIntermediary | Utility.SearchEntityTypes.ShowProducer | Utility.SearchEntityTypes.ShowUsers | Utility.SearchEntityTypes.ShowExpensePayees | Utility.SearchEntityTypes.Show3rdParty | Utility.SearchEntityTypes.ShowFinanceCompanies | Utility.SearchEntityTypes.ShowInspectionCompanies);
    try
    {
      if (formSearchEntity.ShowDialog() != DialogResult.OK)
        return;
      this.entityGuid = formSearchEntity.EntityGuid;
      this.entityName = formSearchEntity.EntityName;
      ((Control) this.textPayeeName).Text = formSearchEntity.EntityName;
      this.InitializePoObject();
      this.poObject.PayeeGuid = formSearchEntity.EntityGuid;
    }
    finally
    {
      formSearchEntity.Dispose();
    }
  }

  private void InitializePoObject()
  {
    if (this.poObject == null)
    {
      this.poObject = new PurchaseOrderExpense();
      this.poObject.ExpenseDetailsChanged -= new PurchaseOrderExpense.ExpenseDetailsChangedHandler(this.PurchaseOrderExpensesChanged);
      this.poObject.ExpenseDetailsChanged += new PurchaseOrderExpense.ExpenseDetailsChangedHandler(this.PurchaseOrderExpensesChanged);
    }
    this.ShowWaitCursor();
    try
    {
      if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
      {
        this.comboOfficeLocation.Value = (object) CurrentUser.Instance.OfficeID;
        this.poObject.GlCompanyId = CurrentUser.Instance.OfficeID;
      }
      else
        this.poObject.GlCompanyId = int.Parse(((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells["ID"].Value.ToString());
      if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
        return;
      this.LoadBankAccounts(int.Parse(((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells["ID"].Value.ToString()));
      this.expenseEntry1.Initialize();
      this.expenseEntry1.GlCompanyId = this.poObject.GlCompanyId;
      this.expenseEntry1.LoadGLAccounts();
    }
    finally
    {
      this.ShowDefaultCursor();
    }
  }

  private void comboOfficeLocation_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboOfficeLocation).IsDroppedDown)
      this.comboOfficeLocation.ToggleDropdown();
    if (((Control) this.comboOfficeLocation).Tag != null && int.Parse(((Control) this.comboOfficeLocation).Tag.ToString()) == this.comboOfficeLocation.SelectedIndex)
      return;
    if (this.poObject != null && this.poObject.ExpenseDetails.Count > 0 && MessageBox.Show("A new office location has been selected and all expense detail information data will be cleared. Do you want to continue? ", "Clear Expense Information Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
    {
      if (((Control) this.comboOfficeLocation).Tag == null)
        return;
      this.comboOfficeLocation.SelectedIndex = int.Parse(((Control) this.comboOfficeLocation).Tag.ToString());
    }
    else
    {
      if (this.poObject != null && this.poObject.ExpenseDetails.Count > 0)
      {
        this.poObject.ExpenseDetails.Clear();
        ((UltraGridBase) this.gridPODetails).DataSource = (object) null;
      }
      if (!this.expenseEntry1.IsInitialized)
        this.expenseEntry1.Initialize();
      if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow != null)
      {
        int num = int.Parse(((UltraDropDownBase) this.comboOfficeLocation).SelectedRow.Cells["ID"].Value.ToString());
        bool enabled = this.dropTreeOffsetAccount.Enabled;
        this.LoadBankAccounts(num);
        this.dropTreeOffsetAccount.LoadGLAccounts(num);
        this.dropTreeOffsetAccount.ResetText();
        this.dropTreeOffsetAccount.Enabled = enabled;
        this.expenseEntry1.GlCompanyId = num;
      }
      else
        this.dsBankAccounts1.Clear();
      this.expenseEntry1.ClearGlAccountAndCostCenter();
    }
  }

  private void LoadBankAccounts(int glCompanyId)
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      this.dsBankAccounts1.Clear();
      this.daGetBankAccounts.SelectCommand.Parameters["@glCompanyId"].Value = (object) glCompanyId;
      this.daGetBankAccounts.Fill((DataTable) this.dsBankAccounts1.spFin_GetBankAccounts);
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.comboBankAccount).Rows).Count != 1)
        return;
      this.comboBankAccount.Value = (object) ((UltraGridBase) this.comboBankAccount).Rows[0].Cells[((UltraDropDownBase) this.comboBankAccount).ValueMember];
    }
    catch (SqlException ex)
    {
      int num = (int) MessageBox.Show("An error has occured while trying to get the bank accounts for the specified office location." + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "AddExpense":
        if (!this.ValidatePoObjectMinimumProperties())
          break;
        formExpensePoDetail formExpensePoDetail = new formExpensePoDetail(this.poObject.GlCompanyId);
        try
        {
          if (formExpensePoDetail.ShowDialog((IWin32Window) this) != DialogResult.OK)
            break;
          this.poObject.ExpenseDetails.Add(formExpensePoDetail.detailItem);
          break;
        }
        finally
        {
          formExpensePoDetail.Dispose();
        }
      case "ScheduleExpense":
        if (!this.ValidatePoObjectMinimumProperties())
          break;
        formScheduleExpense formScheduleExpense = new formScheduleExpense(this.poObject);
        try
        {
          if (formScheduleExpense.ShowDialog((IWin32Window) this) != DialogResult.OK)
            break;
          this.poObject.Schedule = formScheduleExpense.Schedule;
          this.GetPaymentTypes(true);
          break;
        }
        finally
        {
          formScheduleExpense.Dispose();
        }
      case "FindPayee":
        this.FindPayee();
        this.PaymentTypeHandler();
        break;
      case "PostExpense":
        this.SavePurchaseOrder();
        break;
    }
  }

  private bool ValidatePoObjectMinimumProperties()
  {
    if (this.poObject == null || this.poObject.PayeeGuid.Equals(Guid.Empty))
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OFFICELOCATION_REQUIRED"), "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.poObject != null && this.poObject.GlCompanyId != 0)
      return true;
    int num1 = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OFFICELOCATION_REQUIRED"), "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private bool ValidateForm()
  {
    if (this.entityGuid.Equals(Guid.Empty))
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("PayeeRequiredToContinue"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("OFFICELOCATION_REQUIRED"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboBankAccount).SelectedRow == null || int.Parse(this.comboBankAccount.Value.ToString()) == -1)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("BankAccountRequiredToContinue"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (((UltraDropDownBase) this.comboPaymentType).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select a payment type to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (int.Parse(this.comboPaymentType.Value.ToString()) == 4 && (this.dropTreeOffsetAccount.GLAccountID == -1 || this.dropTreeOffsetAccount.GLAccountID == 0))
    {
      int num = (int) MessageBox.Show("You must select an offset account to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.poObject.ExpenseDetails.Count == 0)
    {
      int num = (int) MessageBox.Show(MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("NO_EXPENSE_DETAILS"), MGASystems.IMS.Accounting.OperatingExpenses.StringResourceManager.GetString("RequiredFieldMissing"), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    Decimal num1 = 0M;
    foreach (PurchaseOrderExpenseDetail expenseDetail in (CollectionBase) this.poObject.ExpenseDetails)
      num1 += expenseDetail.ExpenseTotal;
    if (int.Parse(this.comboPaymentType.Value.ToString()) == 4 || !(num1 <= 0M))
      return true;
    int num2 = (int) MessageBox.Show("The system has determined that the expense you are creating has a credit or zero balance. You can not create a check for this expense. Please select 'Pay Later' and an offset account to continue this posting.", "Invalid Check Amount!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void PurchaseOrderExpensesChanged(object sender, EventArgs e)
  {
    ((UltraGridBase) this.gridPODetails).DataSource = (object) this.poObject.ExpenseDetails;
    ((Control) this.gridPODetails).Visible = this.poObject.ExpenseDetails.Count > 0;
  }

  private void gridPODetails_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    this.FormatExpenseDetailGrid(this.gridPODetails);
    this.SetExpenseDetailGridSummaries();
  }

  private void FormatExpenseDetailGrid(UltraGrid Grid)
  {
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["glaccountid"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expensecode"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expensecategoryid"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["issystemdefined"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expensefor"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expenseforname"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["parent"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["isdiscountpercentage"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["state"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["discountamount"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expenseamount"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expensedescription"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["GlAccountName"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["PostingNumber"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["TransactionTotal"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["TransactionDate"].Hidden = true;
    ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["Is1099Item"].Hidden = true;
    foreach (UltraGridColumn column in ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns)
    {
      if (((KeyedSubObjectBase) column).Key.ToUpper() == "EXPENSETOTAL")
      {
        column.Format = "c";
        column.CellAppearance.TextHAlign = (HAlign) 3;
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 3;
      }
      else
      {
        column.CellAppearance.TextHAlign = (HAlign) 1;
        ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 1;
      }
    }
    ((HeaderBase) ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expensetotal"].Header).Caption = "Total";
    ((HeaderBase) ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expensedate"].Header).Caption = "Date";
    ((HeaderBase) ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expensename"].Header).Caption = "Expense";
    ((HeaderBase) ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expensedate"].Header).VisiblePosition = 0;
    ((HeaderBase) ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expensename"].Header).VisiblePosition = 1;
    ((HeaderBase) ((UltraGridBase) Grid).DisplayLayout.Bands[0].Columns["expensetotal"].Header).VisiblePosition = 2;
  }

  private void SetExpenseDetailGridSummaries()
  {
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Bands[0].Summaries.Clear();
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Bands[0].Summaries.Add("sum", (SummaryType) 1, ((UltraGridBase) this.gridPODetails).DisplayLayout.Bands[0].Columns["expensetotal"], (SummaryPosition) 3);
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Bands[0].Summaries[0].DisplayFormat = "{0:c}";
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Bands[0].Summaries[0].Appearance.TextHAlign = (HAlign) 3;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Bands[0].Summaries[0].Appearance.BackColor = Color.LightSteelBlue;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridPODetails).DisplayLayout.Override.SummaryFooterAppearance.BackColor = Color.LightSteelBlue;
  }

  private void gridPODetails_DoubleClick(object sender, EventArgs e)
  {
  }

  private void buttonSave_Click(object sender, EventArgs e) => this.SavePurchaseOrder();

  private void SavePurchaseOrder()
  {
    if (this.poObject == null)
    {
      this.poObject = new PurchaseOrderExpense();
      this.poObject.ExpenseDetailsChanged += new PurchaseOrderExpense.ExpenseDetailsChangedHandler(this.PurchaseOrderExpensesChanged);
    }
    if (!this.ValidateForm())
      return;
    this.SetObjectHeaderProperties();
    this.poObject.Save();
    this.ClearScreen();
  }

  private void gridScheduleDetails_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
  }

  private void SetObjectHeaderProperties()
  {
    this.poObject.PayeeGuid = this.entityGuid;
    this.poObject.GlCompanyId = int.Parse(this.comboOfficeLocation.Value.ToString());
    this.poObject.BankGlAccountId = int.Parse(this.comboBankAccount.Value.ToString());
    this.poObject.PurchaseOrderDate = this.datePickerPODate.DateTime;
    this.poObject.ReceivedDate = this.datePickerReceivedDate.DateTime;
    this.poObject.PaymentDueDate = this.datePickerDueDate.DateTime;
    this.poObject.PaymentTerms = ((Control) this.textPaymentTerms).Text;
    this.poObject.PayeeInvoiceNumber = ((Control) this.textInvoiceNumber).Text;
    this.poObject.PurchaseOrderComments = ((Control) this.textMemo).Text;
    this.poObject.PaymentType = (MGASystems.IMS.Accounting.OperatingExpenses.Utilities.PurchaseOrderPaymentType) this.comboPaymentType.Value;
    if (this.checkCreateCheck.Checked)
      this.poObject.CheckData = new CheckInformation(Utility.PaymentMethod.Check, this.poObject.PayeeGuid, this.poObject.PurchaseOrderDate, new GLAccount(int.Parse(this.comboBankAccount.Value.ToString())));
    this.poObject.Prepaid = this.poObject.PaymentType == MGASystems.IMS.Accounting.OperatingExpenses.Utilities.PurchaseOrderPaymentType.PayNowPrePaid;
    if (int.Parse(this.comboPaymentType.Value.ToString()) != 4)
      return;
    this.poObject.GlOffset = this.dropTreeOffsetAccount.GLAccountID;
  }

  private void GetPaymentTypes(bool SetManualSchedule)
  {
    DataSet dataSet = new DataSet();
    DataTable table = new DataTable("paymentTypes");
    table.Columns.Add(new DataColumn("paymentTypeID", Type.GetType("System.Int32")));
    table.Columns.Add(new DataColumn("paymentType", Type.GetType("System.String")));
    table.Rows.Add((object) 2, (object) "Pay Now");
    table.Rows.Add((object) 3, (object) "Pay Now (Pre-Paid Expense)");
    table.Rows.Add((object) 4, (object) "Pay Later");
    if (SetManualSchedule)
      table.Rows.Add((object) 1, (object) "Pay Later (Manual Schedule)");
    dataSet.Tables.Add(table);
    ((UltraGridBase) this.comboPaymentType).DataSource = (object) null;
    ((UltraGridBase) this.comboPaymentType).DataSource = (object) dataSet;
    ((UltraDropDownBase) this.comboPaymentType).DisplayMember = "paymentType";
    ((UltraDropDownBase) this.comboPaymentType).ValueMember = "paymentTypeId";
    if (!SetManualSchedule)
    {
      this.comboPaymentType.Value = (object) 2;
      ((Control) this.comboPaymentType).Enabled = true;
    }
    else
    {
      this.comboPaymentType.Value = (object) 1;
      ((Control) this.comboPaymentType).Enabled = false;
    }
  }

  private void ClearScreen()
  {
    this.poObject.Dispose();
    this.poObject = (PurchaseOrderExpense) null;
    ((Control) this.textPayeeName).Tag = (object) null;
    ((Control) this.textPayeeName).Text = string.Empty;
    ((Control) this.textPaymentTerms).Text = string.Empty;
    ((Control) this.textMemo).Text = string.Empty;
    ((Control) this.textInvoiceNumber).Text = string.Empty;
    ((Control) this.comboOfficeLocation).ResetText();
    this.comboOfficeLocation.Value = (object) null;
    ((Control) this.comboPaymentType).ResetText();
    this.comboPaymentType.Value = (object) null;
    ((Control) this.comboBankAccount).ResetText();
    this.comboBankAccount.Value = (object) null;
    ((UltraGridBase) this.gridPODetails).DataSource = (object) null;
    this.datePickerDueDate.DateTime = DateTime.Now;
    this.datePickerPODate.DateTime = DateTime.Now;
    this.datePickerReceivedDate.DateTime = DateTime.Now;
    this.comboPaymentType.SelectedIndex = 0;
    this.checkCreateCheck.Enabled = true;
    this.checkCreateCheck.Checked = true;
    this.expenseEntry1.Enabled = false;
  }

  private void ShowWaitCursor() => this.Cursor = Cursors.WaitCursor;

  private void ShowDefaultCursor() => this.Cursor = Cursors.Default;

  private void linkEditSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    formScheduleExpense formScheduleExpense = new formScheduleExpense(this.poObject.Schedule);
    try
    {
      if (formScheduleExpense.ShowDialog() != DialogResult.OK)
        return;
      this.GetPaymentTypes(true);
    }
    finally
    {
      formScheduleExpense.Dispose();
    }
  }

  private void linkCancelSchedule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (MessageBox.Show("All scheduling information will be reset, are you sure you wish to continue?", "Reset Scheduling Options?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.poObject.Schedule = (MGASystems.IMS.Accounting.OperatingExpenses.ClassObjects.ExpenseSchedule) null;
    this.GetPaymentTypes(false);
  }

  private void ultraExplorerBar1_GroupCollapsing(object sender, CancelableGroupEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private void comboPaymentType_RowSelected(object sender, RowSelectedEventArgs e)
  {
    this.PaymentTypeHandler();
  }

  private void PaymentTypeHandler()
  {
    if (((UltraDropDownBase) this.comboPaymentType).SelectedRow == null)
      return;
    switch ((MGASystems.IMS.Accounting.OperatingExpenses.Utilities.PurchaseOrderPaymentType) int.Parse(this.comboPaymentType.Value.ToString()))
    {
      case MGASystems.IMS.Accounting.OperatingExpenses.Utilities.PurchaseOrderPaymentType.PayNowPrePaid:
        this.labelGlOffset.Enabled = false;
        this.dropTreeOffsetAccount.Enabled = false;
        this.checkCreateCheck.Checked = true;
        this.checkCreateCheck.Enabled = false;
        break;
      case MGASystems.IMS.Accounting.OperatingExpenses.Utilities.PurchaseOrderPaymentType.PayLater:
        this.labelGlOffset.Enabled = true;
        this.dropTreeOffsetAccount.Enabled = false;
        this.checkCreateCheck.Enabled = false;
        this.checkCreateCheck.Checked = false;
        this.LoadGlAccounts();
        break;
      default:
        this.labelGlOffset.Enabled = false;
        this.dropTreeOffsetAccount.Enabled = false;
        this.checkCreateCheck.Enabled = true;
        break;
    }
  }

  private void LoadGlAccounts()
  {
    this.Cursor = Cursors.WaitCursor;
    try
    {
      if (((UltraDropDownBase) this.comboOfficeLocation).SelectedRow == null)
        return;
      this.dropTreeOffsetAccount.LoadGLAccounts(int.Parse(this.comboOfficeLocation.Value.ToString()));
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void gridPODetails_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    e.DisplayPromptMsg = false;
    for (int index = this.poObject.ExpenseDetails.Count - 1; index >= 0; --index)
    {
      if (this.poObject.ExpenseDetails[index].ExpenseCode == int.Parse(e.Rows[0].Cells["expenseCode"].Value.ToString()))
      {
        this.poObject.ExpenseDetails.RemoveAt(index);
        ((CancelEventArgs) e).Cancel = true;
        break;
      }
    }
  }

  private void formNewExpensePO_Load(object sender, EventArgs e)
  {
    this.Size = this.MinimumSize;
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    ((UltraGridBase) this.comboOfficeLocation).DataSource = (object) Methods.GetOfficeLocationDataset();
    ((UltraDropDownBase) this.comboOfficeLocation).DisplayMember = "Office Location";
    ((UltraDropDownBase) this.comboOfficeLocation).ValueMember = "ID";
    this.datePickerPODate.DateTime = DateTime.Now;
    this.datePickerDueDate.DateTime = DateTime.Now;
    this.datePickerReceivedDate.DateTime = DateTime.Now;
    this.GetPaymentTypes(false);
    this.poObject = new PurchaseOrderExpense();
    this.poObject.ExpenseDetailsChanged += new PurchaseOrderExpense.ExpenseDetailsChangedHandler(this.PurchaseOrderExpensesChanged);
  }

  private void comboOfficeLocation_BeforeDropDown(object sender, CancelEventArgs e)
  {
    ((Control) this.comboOfficeLocation).Tag = (object) this.comboOfficeLocation.SelectedIndex;
  }

  private void gridPODetails_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    ((Control) this.gridPODetails).Enabled = false;
    int position = ((Control) this.gridPODetails).BindingContext[(object) this.poObject.ExpenseDetails].Position;
    this.expenseEntry1.populateControlsForEdit(this.poObject.ExpenseDetails[position], position);
  }

  private void textInvoiceNumber_Leave(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(((Control) this.textInvoiceNumber).Text))
      return;
    using (BackgroundWorker backgroundWorker = new BackgroundWorker())
    {
      backgroundWorker.DoWork += (DoWorkEventHandler) ((s, ev) =>
      {
        if (!MGASystems.IMS.Accounting.OperatingExpenses.Utilities.InvoicePaymentExists(this.EntityGuid, ((Control) this.textInvoiceNumber).Text))
          return;
        int num = (int) MessageBox.Show("The system has determined that a payment for this invoice may already exist.", "Invoice Already Paid?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      });
      backgroundWorker.RunWorkerAsync();
    }
  }
}
