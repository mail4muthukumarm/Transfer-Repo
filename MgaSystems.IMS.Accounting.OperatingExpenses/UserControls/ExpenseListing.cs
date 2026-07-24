// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.ExpenseListing
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Controls;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.OperatingExpenses.Exceptions;
using MGASystems.IMS.Accounting.OperatingExpenses.Forms;
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

public class ExpenseListing : UserControl
{
  private dsOperatingExpenseJournal dsOperatingExpenseJournal1;
  private SqlDataAdapter daGetOperatingExpenseJournal;
  private SqlConnection ControlDataConnection;
  private IContainer components;
  private int glCompanyId;
  internal UltraGrid gridOperatingExpenseJournal;
  internal Label labelCurtain;
  private Panel panel1;
  private Label label2;
  private DateRangeOptionPicker dateRangeOptionPicker1;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _OpenExpenses_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _OpenExpenses_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _OpenExpenses_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _OpenExpenses_Toolbars_Dock_Area_Right;
  private SqlCommand sqlSelectCommand1;
  private dsOperatingExpenseJournal ds;

  public ExpenseListing(int GlCompanyId)
  {
    this.InitializeComponent();
    this.Dock = DockStyle.Fill;
    this.glCompanyId = GlCompanyId;
    this.ControlDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.PreLoad();
  }

  public int GlCompanyId => this.glCompanyId;

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
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_GetOperatingExpenseJournal", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("DATE");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Purchase Order #");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Check #", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Payee");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Expense");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Amount");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Payee Invoice #");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Balance");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool = new PopupMenuTool("gridContextMenu");
    ButtonTool buttonTool1 = new ButtonTool("VOID");
    ButtonTool buttonTool2 = new ButtonTool("VOID");
    Appearance appearance13 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (ExpenseListing));
    this.gridOperatingExpenseJournal = new UltraGrid();
    this.dsOperatingExpenseJournal1 = new dsOperatingExpenseJournal();
    this.labelCurtain = new Label();
    this.daGetOperatingExpenseJournal = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.ControlDataConnection = new SqlConnection();
    this.panel1 = new Panel();
    this._OpenExpenses_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._OpenExpenses_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._OpenExpenses_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.label2 = new Label();
    this.dateRangeOptionPicker1 = new DateRangeOptionPicker();
    this._OpenExpenses_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.gridOperatingExpenseJournal).BeginInit();
    this.dsOperatingExpenseJournal1.BeginInit();
    this.panel1.SuspendLayout();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.gridOperatingExpenseJournal).DataSource = (object) this.dsOperatingExpenseJournal1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "Date";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 1;
    ultraGridColumn1.Width = 77;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 5;
    ultraGridColumn2.Width = 140;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 93;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 240 /*0xF0*/;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 6;
    ultraGridColumn5.Width = 190;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlign = (HAlign) 3;
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance2;
    ultraGridColumn6.Format = "c";
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 3;
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 4;
    ultraGridColumn6.Width = 98;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 7;
    ultraGridColumn7.Width = 120;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 32 /*0x20*/;
    ultraGridBand.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ultraGridBand.GroupHeadersVisible = false;
    ultraGridBand.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance6).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.RowSpacingBefore = 1;
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.LightSlateGray;
    ((AppearanceBase) appearance10).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance10).ForeColor = Color.White;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.RowConnectorColor = Color.Silver;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    scrollBarLook.Appearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.LightSteelBlue;
    ((AppearanceBase) appearance12).BackColor2 = Color.White;
    ((AppearanceBase) appearance12).BackGradientStyle = (GradientStyle) 6;
    ((AppearanceBase) appearance12).ForeColor = Color.DarkBlue;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridOperatingExpenseJournal).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridOperatingExpenseJournal).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridOperatingExpenseJournal).Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridOperatingExpenseJournal).Location = new Point(0, 32 /*0x20*/);
    ((Control) this.gridOperatingExpenseJournal).Name = "gridOperatingExpenseJournal";
    ((Control) this.gridOperatingExpenseJournal).Size = new Size(960, 640);
    ((UltraControlBase) this.gridOperatingExpenseJournal).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridOperatingExpenseJournal).TabIndex = 1;
    this.gridOperatingExpenseJournal.InitializeRow += new InitializeRowEventHandler(this.gridOperatingExpenseJournal_InitializeRow);
    ((Control) this.gridOperatingExpenseJournal).Click += new EventHandler(this.gridOperatingExpenseJournal_Click);
    this.dsOperatingExpenseJournal1.DataSetName = "dsOperatingExpenseJournal";
    this.dsOperatingExpenseJournal1.Locale = new CultureInfo("en-US");
    this.labelCurtain.BackColor = Color.FromArgb(239, 247, 253);
    this.labelCurtain.Dock = DockStyle.Fill;
    this.labelCurtain.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.labelCurtain.ForeColor = Color.LightSlateGray;
    this.labelCurtain.Location = new Point(0, 32 /*0x20*/);
    this.labelCurtain.Name = "labelCurtain";
    this.labelCurtain.Size = new Size(960, 640);
    this.labelCurtain.TabIndex = 3;
    this.labelCurtain.Text = "Loading Chart Data...";
    this.labelCurtain.TextAlign = ContentAlignment.MiddleCenter;
    this.daGetOperatingExpenseJournal.SelectCommand = this.sqlSelectCommand1;
    this.daGetOperatingExpenseJournal.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "spFin_GetOperatingExpenseJournal", new DataColumnMapping[8]
      {
        new DataColumnMapping("DATE", "DATE"),
        new DataColumnMapping("Purchase Order #", "Purchase Order #"),
        new DataColumnMapping("Check #", "Check #"),
        new DataColumnMapping("Payee", "Payee"),
        new DataColumnMapping("Expense", "Expense"),
        new DataColumnMapping("Amount", "Amount"),
        new DataColumnMapping("Payee Invoice #", "Payee Invoice #"),
        new DataColumnMapping("Balance", "Balance")
      })
    });
    this.sqlSelectCommand1.CommandText = "[spFin_GetOperatingExpenseJournal]";
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.ControlDataConnection;
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4));
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@DATERANGEFROM", SqlDbType.DateTime, 8));
    this.sqlSelectCommand1.Parameters.Add(new SqlParameter("@DATERANGETO", SqlDbType.DateTime, 8));
    this.ControlDataConnection.ConnectionString = "workstation id=GATEWAY;packet size=4096;user id=mgasystems;data source=NEWAGE_EXTERNAL;persist security info=False;initial catalog=IMS";
    this.panel1.BackColor = Color.White;
    this.panel1.Controls.Add((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom);
    this.panel1.Controls.Add((Control) this._OpenExpenses_Toolbars_Dock_Area_Left);
    this.panel1.Controls.Add((Control) this._OpenExpenses_Toolbars_Dock_Area_Right);
    this.panel1.Controls.Add((Control) this.label2);
    this.panel1.Controls.Add((Control) this.dateRangeOptionPicker1);
    this.panel1.Controls.Add((Control) this._OpenExpenses_Toolbars_Dock_Area_Top);
    this.panel1.Dock = DockStyle.Top;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(960, 32 /*0x20*/);
    this.panel1.TabIndex = 4;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._OpenExpenses_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).Location = new Point(0, 32 /*0x20*/);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).Name = "_OpenExpenses_Toolbars_Dock_Area_Bottom";
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Bottom).Size = new Size(960, 0);
    this._OpenExpenses_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.HideToolbars = true;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = "gridContextMenu";
    ((ToolBase) buttonTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool1
    });
    ((AppearanceBase) appearance13).Image = resourceManager.GetObject("appearance13.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedProps).Caption = "Void Expense";
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool2
    });
    this.ultraToolbarsManager1.BeforeToolDropdown += new BeforeToolDropdownEventHandler(this.ultraToolbarsManager1_BeforeToolDropdown);
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._OpenExpenses_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).Name = "_OpenExpenses_Toolbars_Dock_Area_Left";
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Left).Size = new Size(0, 32 /*0x20*/);
    this._OpenExpenses_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._OpenExpenses_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).Location = new Point(960, 0);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).Name = "_OpenExpenses_Toolbars_Dock_Area_Right";
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Right).Size = new Size(0, 32 /*0x20*/);
    this._OpenExpenses_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    this.label2.AutoSize = true;
    this.label2.Font = new Font("Tahoma", 11f, FontStyle.Bold);
    this.label2.ForeColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.label2.Location = new Point(2, 3);
    this.label2.Name = "label2";
    this.label2.Size = new Size(183, 21);
    this.label2.TabIndex = 2;
    this.label2.Text = "Expense History Listing";
    this.dateRangeOptionPicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.dateRangeOptionPicker1.Location = new Point(376, 3);
    this.dateRangeOptionPicker1.Name = "dateRangeOptionPicker1";
    this.dateRangeOptionPicker1.Size = new Size(576, 24);
    this.dateRangeOptionPicker1.TabIndex = 5;
    this.dateRangeOptionPicker1.DateChanged += new DateRangeOptionPicker.DateChangedEventHandler(this.dateRangeOptionPicker1_DateChanged);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._OpenExpenses_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).Name = "_OpenExpenses_Toolbars_Dock_Area_Top";
    ((Control) this._OpenExpenses_Toolbars_Dock_Area_Top).Size = new Size(960, 0);
    this._OpenExpenses_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    this.Controls.Add((Control) this.gridOperatingExpenseJournal);
    this.Controls.Add((Control) this.labelCurtain);
    this.Controls.Add((Control) this.panel1);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (ExpenseListing);
    this.Size = new Size(960, 672);
    ((ISupportInitialize) this.gridOperatingExpenseJournal).EndInit();
    this.dsOperatingExpenseJournal1.EndInit();
    this.panel1.ResumeLayout(false);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  private void PreLoad()
  {
    ((Control) this.dateRangeOptionPicker1.MgaSimpleComboBox1).Enabled = false;
    if (((UltraDropDownBase) this.dateRangeOptionPicker1.MgaSimpleComboBox1).IsDroppedDown)
      this.dateRangeOptionPicker1.MgaSimpleComboBox1.DropDown();
    this.labelCurtain.Visible = true;
    this.labelCurtain.BringToFront();
    new Thread(new ThreadStart(this.LoadData)).Start();
  }

  private void LoadData()
  {
    this.ds = new dsOperatingExpenseJournal();
    this.daGetOperatingExpenseJournal.SelectCommand.Parameters["@glcompanyid"].Value = (object) this.GlCompanyId;
    this.daGetOperatingExpenseJournal.SelectCommand.Parameters["@DATERANGEFROM"].Value = (object) this.dateRangeOptionPicker1.DateRangeFrom;
    this.daGetOperatingExpenseJournal.SelectCommand.Parameters["@DATERANGETO"].Value = (object) this.dateRangeOptionPicker1.DateRangeTo;
    this.daGetOperatingExpenseJournal.Fill((DataTable) this.ds.spFin_GetOperatingExpenseJournal);
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new ExpenseListing.LoadDataCompletedHandler(this.LoadDataCompleted));
  }

  private void LoadDataCompleted()
  {
    if (this.IsDisposed && this.Disposing)
      return;
    ((UltraGridBase) this.gridOperatingExpenseJournal).DataSource = (object) this.ds;
    this.labelCurtain.Visible = false;
    this.labelCurtain.SendToBack();
    ((Control) this.dateRangeOptionPicker1.MgaSimpleComboBox1).Enabled = true;
    this.dateRangeOptionPicker1.MgaSimpleComboBox1.Focus();
  }

  private void gridOperatingExpenseJournal_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (e.Row.Cells["expense"].Value.ToString() == "Split")
    {
      ((AppearanceBase) e.Row.Cells["expense"].Appearance).FontData.Underline = (DefaultableBoolean) 1;
      ((AppearanceBase) e.Row.Cells["expense"].Appearance).Cursor = Cursors.Hand;
      ((AppearanceBase) e.Row.Cells["expense"].Appearance).ForeColor = Color.Blue;
    }
    if (!(e.Row.Cells["Check #"].Value.ToString() == "Multiple"))
      return;
    ((AppearanceBase) e.Row.Cells["Check #"].Appearance).FontData.Underline = (DefaultableBoolean) 1;
    ((AppearanceBase) e.Row.Cells["Check #"].Appearance).Cursor = Cursors.Hand;
    ((AppearanceBase) e.Row.Cells["Check #"].Appearance).ForeColor = Color.Blue;
  }

  private void gridOperatingExpenseJournal_Click(object sender, EventArgs e)
  {
    UltraGridCell context = (UltraGridCell) ((ControlUIElementBase) ((UltraGridBase) this.gridOperatingExpenseJournal).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridCell), true);
    if (context == null)
      return;
    if (((KeyedSubObjectBase) context.Column).Key == "Expense" && context.Value.ToString() == "Split")
    {
      using (formExpenseSplit formExpenseSplit = new formExpenseSplit(int.Parse(context.Row.Cells["Purchase Order #"].Value.ToString())))
      {
        int num = (int) formExpenseSplit.ShowDialog((IWin32Window) this);
      }
    }
    if (!(((KeyedSubObjectBase) context.Column).Key == "Check #") || !(context.Value.ToString() == "Multiple"))
      return;
    using (formExpensePaymentHistory expensePaymentHistory = new formExpensePaymentHistory(int.Parse(context.Row.Cells["Purchase Order #"].Value.ToString())))
    {
      int num = (int) expensePaymentHistory.ShowDialog((IWin32Window) this);
    }
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((UltraGridBase) this.gridOperatingExpenseJournal).ActiveRow == null)
      return;
    this.VoidPurchaseOrder(int.Parse(((UltraGridBase) this.gridOperatingExpenseJournal).ActiveRow.Cells["Purchase Order #"].Value.ToString()));
  }

  private void ultraToolbarsManager1_BeforeToolDropdown(
    object sender,
    BeforeToolDropdownEventArgs e)
  {
    ((ToolsCollectionBase) ((PopupMenuTool) ((CancelableToolEventArgs) e).Tool).Tools)["VOID"].SharedProps.Visible = true;
    if (((UltraGridBase) this.gridOperatingExpenseJournal).ActiveRow != null && ((SparseCollectionBase) this.gridOperatingExpenseJournal.Selected.Rows).Count != 0 && ((DisposableObjectCollectionBase) ((UltraGridBase) this.gridOperatingExpenseJournal).Rows).Count != 0)
      return;
    ((ToolsCollectionBase) ((PopupMenuTool) ((CancelableToolEventArgs) e).Tool).Tools)["VOID"].SharedProps.Visible = false;
  }

  private void VoidPurchaseOrder(int poNum)
  {
    string cmdText = $"select count(distinct tblFin_JournalPostings.transactnum) from tblFin_JournalPostings inner join tblfin_journal on tblfin_journal.transactnum = tblfin_journalpostings.transactnum and (voiderfor is null and voidedby is null)where ponum = {poNum}";
    string str = $"select distinct tblFin_JournalPostings.transactnum from tblFin_JournalPostings inner join tblfin_journal on tblfin_journal.transactnum = tblfin_journalpostings.transactnum and (voiderfor is null and voidedby is null)where ponum = {poNum}";
    using (SqlCommand sqlCommand = new SqlCommand(cmdText, new SqlConnection(CurrentUser.Instance.ConnectionString)))
    {
      sqlCommand.CommandType = CommandType.Text;
      sqlCommand.Connection.Open();
      if (int.Parse(sqlCommand.ExecuteScalar().ToString()) > 1)
        throw new MultipleTransactionsFoundException("The system has found multiple transactions for the specified purchase order. This purchase order can not be voided by this method.");
      sqlCommand.CommandText = str;
      SqlDataReader sqlDataReader = sqlCommand.ExecuteReader(CommandBehavior.CloseConnection);
      if (!sqlDataReader.Read())
        return;
      Utility.VoidTransaction(int.Parse(sqlDataReader["transactnum"].ToString()));
    }
  }

  private void dateRangeOptionPicker1_DateChanged(object sender, MGASystems.IMS.Accounting.Controls.DateRangeEventArgs e)
  {
    this.PreLoad();
  }

  private delegate void LoadDataCompletedHandler();
}
