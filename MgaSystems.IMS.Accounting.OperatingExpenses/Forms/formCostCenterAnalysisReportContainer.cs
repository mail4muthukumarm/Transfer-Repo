// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.Forms.formCostCenterAnalysisReportContainer
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinDataSource;
using Infragistics.Win.UltraWinDock;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Forms;
using MGASystems.Tools;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.OperatingExpenses.Forms;

[TestForm]
public class formCostCenterAnalysisReportContainer : AccountingNoteDocumentSupport
{
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _formNewExpensePO_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formNewExpensePO_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formNewExpensePO_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formNewExpensePO_Toolbars_Dock_Area_Right;
  private SqlCommand sqlSelectCommand1;
  private SqlConnection FormDataConnection;
  private MGASimpleComboBox comboGroupBy;
  private SqlDataAdapter daGetData;
  private IContainer components;
  private DataSet _dataSource;
  private string[] HeaderInfo;
  private string ReportName;
  private string StoredProc;
  private ArrayList HiddenColumns;
  private UltraDockManager ultraDockManager1;
  private UnpinnedTabArea _formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft;
  private UnpinnedTabArea _formCostCenterAnalysisReportContainerUnpinnedTabAreaRight;
  private UnpinnedTabArea _formCostCenterAnalysisReportContainerUnpinnedTabAreaTop;
  private UnpinnedTabArea _formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom;
  private AutoHideControl _formCostCenterAnalysisReportContainerAutoHideControl;
  private Panel panelModifyReport;
  private WindowDockingArea windowDockingArea1;
  private DockableWindow dockableWindow1;
  private UltraDataSource ultraDataSource1;
  private UltraGrid gridColumnSelector;
  private Panel panelMain;
  private Panel panelHeaderInfo;
  private Label lblHeaderInfo;
  private Label lblCompanyName;
  private Label lblProgressMessage;
  private UltraProgressBar progressFetchData;
  private Panel panel1;
  private Panel panel2;
  private UltraGrid gridData;
  private object[] ProcArguments;

  public formCostCenterAnalysisReportContainer() => this.InitializeComponent();

  public formCostCenterAnalysisReportContainer(
    string[] headerInfo,
    string reportName,
    string storedProc,
    ArrayList hiddenColumns,
    params object[] procArguments)
  {
    this.SetParameters(headerInfo, reportName, storedProc, hiddenColumns, procArguments);
    this.Run();
  }

  public void SetHeaderInformation()
  {
    string str = string.Empty;
    if (this.HeaderInfo.Length > 1)
      this.lblCompanyName.Text = this.HeaderInfo[0];
    for (int index = 1; index < this.HeaderInfo.Length; ++index)
      str = $"{str}{this.HeaderInfo[index]}\r\n";
    this.lblHeaderInfo.Text = str;
  }

  public void HideColumnsAndSetGroupByColumns()
  {
    for (int index = 0; this.HiddenColumns != null && index < this.HiddenColumns.Count; ++index)
    {
      if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.gridData).DisplayLayout.Bands[0].Columns).Exists(this.HiddenColumns[index].ToString()))
        ((UltraGridBase) this.gridData).DisplayLayout.Bands[0].Columns[this.HiddenColumns[index].ToString()].Hidden = true;
    }
    DataTable dataTable1 = new DataTable();
    dataTable1.Columns.Add("ColumnName");
    DataTable dataTable2 = new DataTable();
    dataTable2.Columns.Add("ColumnName");
    foreach (UltraGridColumn column in ((UltraGridBase) this.gridData).DisplayLayout.Bands[0].Columns)
    {
      column.CellActivation = (Activation) 3;
      if (!column.Hidden)
        dataTable1.Rows.Add((object) ((KeyedSubObjectBase) column).Key.ToString());
      dataTable2.Rows.Add((object) ((KeyedSubObjectBase) column).Key.ToString());
    }
    ((UltraGridBase) this.comboGroupBy).DataSource = (object) dataTable1;
    ((UltraDropDownBase) this.comboGroupBy).DisplayMember = "ColumnName";
    ((UltraGridBase) this.gridColumnSelector).DataSource = (object) dataTable2;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Bands[0].HeaderVisible = false;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridColumnSelector).Rows)
      row.Cells["Select"].Value = this.HiddenColumns.IndexOf((object) row.Cells["ColumnName"].Value.ToString()) != -1 ? (object) false : (object) true;
  }

  private void LoadData() => new Thread(new ThreadStart(this.DoGetData)).Start();

  public void DoGetData()
  {
    this.sqlSelectCommand1.CommandText = this.StoredProc;
    this.sqlSelectCommand1.Parameters.Clear();
    int num;
    for (int index = 0; index < this.ProcArguments.Length - 1; index = num + 1)
      this.sqlSelectCommand1.Parameters.AddWithValue(this.ProcArguments[index].ToString(), (object) this.ProcArguments[num = index + 1].ToString());
    this._dataSource = new DataSet();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daGetData.Fill(this._dataSource);
    if (this.IsDisposed || this.Disposing)
      return;
    this.Invoke((Delegate) new formCostCenterAnalysisReportContainer.GetDataCompletedHandler(this.GetDataCompleted));
  }

  public void GetDataCompleted()
  {
    this.progressFetchData.Value = 85;
    this.lblProgressMessage.Text = "Creating Report...";
    ((UltraGridBase) this.gridData).DataSource = (object) this._dataSource;
    this.HideColumnsAndSetGroupByColumns();
    this.progressFetchData.Value = 100;
    this.lblCompanyName.Visible = this.lblHeaderInfo.Visible = true;
    this.lblProgressMessage.Visible = ((Control) this.progressFetchData).Visible = false;
  }

  public void Run()
  {
    this.progressFetchData.Value = 0;
    this.lblProgressMessage.Visible = ((Control) this.progressFetchData).Visible = true;
    this.lblCompanyName.Visible = this.lblHeaderInfo.Visible = false;
    if (this.ProcArguments.Length % 2 == 1)
      throw new ArgumentException("All parameters must have an associated value");
    this.SetHeaderInformation();
    this.progressFetchData.Value = 10;
    this.DoGetData();
  }

  public void SetParameters(
    string[] headerInfo,
    string reportName,
    string storedProc,
    ArrayList hiddenColumns,
    params object[] procArguments)
  {
    this.HeaderInfo = headerInfo;
    this.ReportName = reportName;
    this.StoredProc = storedProc;
    this.HiddenColumns = hiddenColumns;
    this.ProcArguments = procArguments;
  }

  public void CheckList()
  {
    ArrayList arrayList = new ArrayList();
    foreach (DataColumn column in (InternalDataCollectionBase) this._dataSource.Tables[0].Columns)
      arrayList.Add((object) column.ColumnName);
    ((UltraGridBase) this.gridColumnSelector).DataSource = (object) arrayList;
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
    UltraGridColumn ultraGridColumn = new UltraGridColumn("Select", 0);
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formCostCenterAnalysisReportContainer));
    UltraToolbar ultraToolbar = new UltraToolbar("PurchaseOrderToolbar");
    Appearance appearance17 = new Appearance();
    ButtonTool buttonTool1 = new ButtonTool("SaveReport");
    ButtonTool buttonTool2 = new ButtonTool("Print");
    ButtonTool buttonTool3 = new ButtonTool("Refresh");
    ButtonTool buttonTool4 = new ButtonTool("Excel");
    ButtonTool buttonTool5 = new ButtonTool("ShowChart");
    ButtonTool buttonTool6 = new ButtonTool("ModifyReport");
    ControlContainerTool controlContainerTool1 = new ControlContainerTool("GroupBy");
    ButtonTool buttonTool7 = new ButtonTool("SaveReport");
    Appearance appearance18 = new Appearance();
    ButtonTool buttonTool8 = new ButtonTool("Print");
    Appearance appearance19 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("ShowChart");
    Appearance appearance20 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("Refresh");
    Appearance appearance21 = new Appearance();
    ButtonTool buttonTool11 = new ButtonTool("Excel");
    Appearance appearance22 = new Appearance();
    ButtonTool buttonTool12 = new ButtonTool("ModifyReport");
    Appearance appearance23 = new Appearance();
    ControlContainerTool controlContainerTool2 = new ControlContainerTool("GroupBy");
    Appearance appearance24 = new Appearance();
    ButtonTool buttonTool13 = new ButtonTool("Search");
    Appearance appearance25 = new Appearance();
    DockAreaPane dockAreaPane = new DockAreaPane((DockedLocation) 2, new Guid("db0904bf-6702-4ab5-958a-7e4e1034aebe"));
    DockableControlPane dockableControlPane = new DockableControlPane(new Guid("5cb1a642-d83e-4883-a827-f24af72cc2de"), new Guid("00000000-0000-0000-0000-000000000000"), -1, new Guid("db0904bf-6702-4ab5-958a-7e4e1034aebe"), -1);
    Appearance appearance26 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("", -1);
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    UltraDataColumn ultraDataColumn = new UltraDataColumn("Column 0");
    this.comboGroupBy = new MGASimpleComboBox();
    this.panelModifyReport = new Panel();
    this.gridColumnSelector = new UltraGrid();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formNewExpensePO_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formNewExpensePO_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._formNewExpensePO_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formNewExpensePO_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.daGetData = new SqlDataAdapter();
    this.sqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.ultraDockManager1 = new UltraDockManager(this.components);
    this._formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft = new UnpinnedTabArea();
    this._formCostCenterAnalysisReportContainerUnpinnedTabAreaRight = new UnpinnedTabArea();
    this._formCostCenterAnalysisReportContainerUnpinnedTabAreaTop = new UnpinnedTabArea();
    this._formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom = new UnpinnedTabArea();
    this._formCostCenterAnalysisReportContainerAutoHideControl = new AutoHideControl();
    this.windowDockingArea1 = new WindowDockingArea();
    this.dockableWindow1 = new DockableWindow();
    this.panelMain = new Panel();
    this.gridData = new UltraGrid();
    this.panelHeaderInfo = new Panel();
    this.lblHeaderInfo = new Label();
    this.lblCompanyName = new Label();
    this.lblProgressMessage = new Label();
    this.progressFetchData = new UltraProgressBar();
    this.panel1 = new Panel();
    this.panel2 = new Panel();
    this.ultraDataSource1 = new UltraDataSource(this.components);
    ((ISupportInitialize) this.comboGroupBy).BeginInit();
    this.panelModifyReport.SuspendLayout();
    ((ISupportInitialize) this.gridColumnSelector).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.ultraDockManager1).BeginInit();
    ((Control) this.windowDockingArea1).SuspendLayout();
    ((Control) this.dockableWindow1).SuspendLayout();
    this.panelMain.SuspendLayout();
    ((ISupportInitialize) this.gridData).BeginInit();
    this.panelHeaderInfo.SuspendLayout();
    ((ISupportInitialize) this.ultraDataSource1).BeginInit();
    this.SuspendLayout();
    this.comboGroupBy.BorderStyle = (UIElementBorderStyle) 4;
    this.comboGroupBy.CharacterCasing = CharacterCasing.Normal;
    this.comboGroupBy.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboGroupBy.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboGroupBy).Font = new Font("Tahoma", 8f);
    ((Control) this.comboGroupBy).Location = new Point(297, 2);
    this.comboGroupBy.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboGroupBy).Name = "comboGroupBy";
    ((Control) this.comboGroupBy).Size = new Size(5, 21);
    ((Control) this.comboGroupBy).TabIndex = 21;
    ((UltraControlBase) this.comboGroupBy).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboGroupBy).UseOsThemes = (DefaultableBoolean) 2;
    this.panelModifyReport.Controls.Add((Control) this.gridColumnSelector);
    this.panelModifyReport.Location = new Point(0, 19);
    this.panelModifyReport.Name = "panelModifyReport";
    this.panelModifyReport.Size = new Size(253, 619);
    this.panelModifyReport.TabIndex = 42;
    ((AppearanceBase) appearance1).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance1).BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ultraGridColumn.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn.Header).VisiblePosition = 0;
    ultraGridColumn.RowLayoutColumnInfo.ActualCellSize = new Size(96 /*0x60*/, 17);
    ultraGridColumn.RowLayoutColumnInfo.ActualLabelSize = new Size(96 /*0x60*/, 25);
    ultraGridColumn.RowLayoutColumnInfo.PreferredCellSize = new Size(96 /*0x60*/, 0);
    ultraGridColumn.Width = 71;
    ultraGridBand1.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn
    });
    ultraGridBand1.UseRowLayout = true;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = SystemColors.ActiveBorder;
    ((AppearanceBase) appearance2).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.gridColumnSelector).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.gridColumnSelector).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = SystemColors.ControlLightLight;
    ((AppearanceBase) appearance4).BackColor2 = SystemColors.Control;
    ((AppearanceBase) appearance4).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance4).ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.MaxRowScrollRegions = 1;
    ((AppearanceBase) appearance5).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance5).ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance6).ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    ((AppearanceBase) appearance7).BackColor = SystemColors.Window;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.White;
    ((AppearanceBase) appearance8).TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.CellPadding = 0;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.FixedHeaderAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance10).BackColor2 = SystemColors.ControlDark;
    ((AppearanceBase) appearance10).BackGradientAlignment = (GradientAlignment) 1;
    ((AppearanceBase) appearance10).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance10).BorderColor = SystemColors.Window;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.HotTrackHeaderAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = SystemColors.Window;
    ((AppearanceBase) appearance13).BorderColor = Color.White;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.RowSelectorHeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.RowSizing = (RowSizing) 1;
    ((AppearanceBase) appearance15).BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.gridColumnSelector).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.gridColumnSelector).Dock = DockStyle.Fill;
    ((Control) this.gridColumnSelector).Font = new Font("Tahoma", 8f);
    ((Control) this.gridColumnSelector).Location = new Point(0, 0);
    ((Control) this.gridColumnSelector).Name = "gridColumnSelector";
    ((Control) this.gridColumnSelector).Size = new Size(253, 619);
    ((Control) this.gridColumnSelector).TabIndex = 0;
    ((Control) this.gridColumnSelector).Text = "ultraGrid2";
    ((Control) this.gridColumnSelector).Click += new EventHandler(this.gridColumnSelector_Click);
    ((AppearanceBase) appearance16).ImageBackground = (Image) componentResourceManager.GetObject("appearance16.ImageBackground");
    this.ultraToolbarsManager1.Appearance = (AppearanceBase) appearance16;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.LockToolbars = true;
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(17, 138);
    ultraToolbar.FloatingSize = new Size(397, 67);
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 1;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance17).AlphaLevel = (short) 62;
    ((AppearanceBase) appearance17).BackColor = Color.Lavender;
    ((AppearanceBase) appearance17).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance17).ForeColor = Color.Black;
    ((AppearanceBase) appearance17).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance17).ImageAlpha = (Alpha) 2;
    ((SettingsBase) ultraToolbar.Settings).Appearance = (AppearanceBase) appearance17;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) ultraToolbar.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ultraToolbar.Text = "ReoportOptionToolBar";
    ((ToolBase) buttonTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool6).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) controlContainerTool1).Control = (Control) this.comboGroupBy;
    ((ToolBase) controlContainerTool1).InstanceProps.IsFirstInGroup = true;
    ((ToolPropsBase) ((ToolBase) controlContainerTool1).InstanceProps).Width = 62;
    ((ToolsCollectionBase) ((UltraToolbarBase) ultraToolbar).Tools).AddRange(new ToolBase[7]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) controlContainerTool1
    });
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance18).Image = componentResourceManager.GetObject("appearance38.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).Image = componentResourceManager.GetObject("appearance39.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ((AppearanceBase) appearance20).Image = componentResourceManager.GetObject("appearance40.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).Image = componentResourceManager.GetObject("appearance41.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).Image = componentResourceManager.GetObject("appearance42.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool11).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).Image = componentResourceManager.GetObject("appearance43.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance23;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedProps).Caption = "Modify Report";
    ((ToolBase) controlContainerTool2).Control = (Control) this.comboGroupBy;
    ((AppearanceBase) appearance24).Image = componentResourceManager.GetObject("appearance44.Image");
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance24;
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).SharedProps).Caption = "Group By";
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) controlContainerTool2).SharedProps).Width = 62;
    ((AppearanceBase) appearance25).Image = componentResourceManager.GetObject("appearance45.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance25;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedProps).Caption = "Search";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[8]
    {
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11,
      (ToolBase) buttonTool12,
      (ToolBase) controlContainerTool2,
      (ToolBase) buttonTool13
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ToolBarClicked);
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._formNewExpensePO_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).Name = "_formNewExpensePO_Toolbars_Dock_Area_Top";
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top).Size = new Size(1152, 23);
    this._formNewExpensePO_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._formNewExpensePO_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).Location = new Point(0, 662);
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).Name = "_formNewExpensePO_Toolbars_Dock_Area_Bottom";
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom).Size = new Size(1152, 0);
    this._formNewExpensePO_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._formNewExpensePO_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).Location = new Point(0, 23);
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).Name = "_formNewExpensePO_Toolbars_Dock_Area_Left";
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left).Size = new Size(0, 639);
    this._formNewExpensePO_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._formNewExpensePO_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).Location = new Point(1152, 23);
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).Name = "_formNewExpensePO_Toolbars_Dock_Area_Right";
    ((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right).Size = new Size(0, 639);
    this._formNewExpensePO_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    this.daGetData.SelectCommand = this.sqlSelectCommand1;
    this.daGetData.TableMappings.AddRange(new DataTableMapping[4]
    {
      new DataTableMapping("Table", "spFin_GetAccountsReceivable", new DataColumnMapping[23]
      {
        new DataColumnMapping("invoicenum", "invoicenum"),
        new DataColumnMapping("officeinvoicenum", "officeinvoicenum"),
        new DataColumnMapping("quoteid", "quoteid"),
        new DataColumnMapping("quotecontrolnum", "quotecontrolnum"),
        new DataColumnMapping("policynumber", "policynumber"),
        new DataColumnMapping("insuredpolicyname", "insuredpolicyname"),
        new DataColumnMapping("effectivedate", "effectivedate"),
        new DataColumnMapping("expirationdate", "expirationdate"),
        new DataColumnMapping("invoicedate", "invoicedate"),
        new DataColumnMapping("chargename", "chargename"),
        new DataColumnMapping("chargecode", "chargecode"),
        new DataColumnMapping("companylineguid", "companylineguid"),
        new DataColumnMapping("amtbilled", "amtbilled"),
        new DataColumnMapping("AmtPTD", "AmtPTD"),
        new DataColumnMapping("NetDue", "NetDue"),
        new DataColumnMapping("AmtPTC", "AmtPTC"),
        new DataColumnMapping("UnacctBalance", "UnacctBalance"),
        new DataColumnMapping("ExchBalance", "ExchBalance"),
        new DataColumnMapping("ARGL", "ARGL"),
        new DataColumnMapping("EXGL", "EXGL"),
        new DataColumnMapping("UAGL", "UAGL"),
        new DataColumnMapping("accountnumber", "accountnumber"),
        new DataColumnMapping("CurrentStatus", "CurrentStatus")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[23]
      {
        new DataColumnMapping("invoicenum", "invoicenum"),
        new DataColumnMapping("officeinvoicenum", "officeinvoicenum"),
        new DataColumnMapping("quoteid", "quoteid"),
        new DataColumnMapping("quotecontrolnum", "quotecontrolnum"),
        new DataColumnMapping("policynumber", "policynumber"),
        new DataColumnMapping("insuredpolicyname", "insuredpolicyname"),
        new DataColumnMapping("effectivedate", "effectivedate"),
        new DataColumnMapping("expirationdate", "expirationdate"),
        new DataColumnMapping("invoicedate", "invoicedate"),
        new DataColumnMapping("chargename", "chargename"),
        new DataColumnMapping("chargecode", "chargecode"),
        new DataColumnMapping("companylineguid", "companylineguid"),
        new DataColumnMapping("amtbilled", "amtbilled"),
        new DataColumnMapping("AmtPTD", "AmtPTD"),
        new DataColumnMapping("NetDue", "NetDue"),
        new DataColumnMapping("AmtPTC", "AmtPTC"),
        new DataColumnMapping("UnacctBalance", "UnacctBalance"),
        new DataColumnMapping("ExchBalance", "ExchBalance"),
        new DataColumnMapping("ARGL", "ARGL"),
        new DataColumnMapping("EXGL", "EXGL"),
        new DataColumnMapping("UAGL", "UAGL"),
        new DataColumnMapping("accountnumber", "accountnumber"),
        new DataColumnMapping("CurrentStatus", "CurrentStatus")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[23]
      {
        new DataColumnMapping("invoicenum", "invoicenum"),
        new DataColumnMapping("officeinvoicenum", "officeinvoicenum"),
        new DataColumnMapping("quoteid", "quoteid"),
        new DataColumnMapping("quotecontrolnum", "quotecontrolnum"),
        new DataColumnMapping("policynumber", "policynumber"),
        new DataColumnMapping("insuredpolicyname", "insuredpolicyname"),
        new DataColumnMapping("effectivedate", "effectivedate"),
        new DataColumnMapping("expirationdate", "expirationdate"),
        new DataColumnMapping("invoicedate", "invoicedate"),
        new DataColumnMapping("chargename", "chargename"),
        new DataColumnMapping("chargecode", "chargecode"),
        new DataColumnMapping("companylineguid", "companylineguid"),
        new DataColumnMapping("amtbilled", "amtbilled"),
        new DataColumnMapping("AmtPTD", "AmtPTD"),
        new DataColumnMapping("NetDue", "NetDue"),
        new DataColumnMapping("AmtPTC", "AmtPTC"),
        new DataColumnMapping("UnacctBalance", "UnacctBalance"),
        new DataColumnMapping("ExchBalance", "ExchBalance"),
        new DataColumnMapping("ARGL", "ARGL"),
        new DataColumnMapping("EXGL", "EXGL"),
        new DataColumnMapping("UAGL", "UAGL"),
        new DataColumnMapping("accountnumber", "accountnumber"),
        new DataColumnMapping("CurrentStatus", "CurrentStatus")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[23]
      {
        new DataColumnMapping("invoicenum", "invoicenum"),
        new DataColumnMapping("officeinvoicenum", "officeinvoicenum"),
        new DataColumnMapping("quoteid", "quoteid"),
        new DataColumnMapping("quotecontrolnum", "quotecontrolnum"),
        new DataColumnMapping("policynumber", "policynumber"),
        new DataColumnMapping("insuredpolicyname", "insuredpolicyname"),
        new DataColumnMapping("effectivedate", "effectivedate"),
        new DataColumnMapping("expirationdate", "expirationdate"),
        new DataColumnMapping("invoicedate", "invoicedate"),
        new DataColumnMapping("chargename", "chargename"),
        new DataColumnMapping("chargecode", "chargecode"),
        new DataColumnMapping("companylineguid", "companylineguid"),
        new DataColumnMapping("amtbilled", "amtbilled"),
        new DataColumnMapping("AmtPTD", "AmtPTD"),
        new DataColumnMapping("NetDue", "NetDue"),
        new DataColumnMapping("AmtPTC", "AmtPTC"),
        new DataColumnMapping("UnacctBalance", "UnacctBalance"),
        new DataColumnMapping("ExchBalance", "ExchBalance"),
        new DataColumnMapping("ARGL", "ARGL"),
        new DataColumnMapping("EXGL", "EXGL"),
        new DataColumnMapping("UAGL", "UAGL"),
        new DataColumnMapping("accountnumber", "accountnumber"),
        new DataColumnMapping("CurrentStatus", "CurrentStatus")
      })
    });
    this.sqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.sqlSelectCommand1.Connection = this.FormDataConnection;
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    ((DockableGroupPane) dockAreaPane).ChildPaneStyle = (ChildPaneStyle) 2;
    ((DockablePaneBase) dockableControlPane).Closed = true;
    dockableControlPane.Control = (Control) this.panelModifyReport;
    dockableControlPane.FlyoutSize = new Size(249, -1);
    dockableControlPane.OriginalControlBounds = new Rectangle(392, 240 /*0xF0*/, 200, 100);
    ((DockablePaneBase) dockableControlPane).Size = new Size(100, 100);
    ((DockablePaneBase) dockableControlPane).Text = "Modify Report";
    ((DockableGroupPane) dockAreaPane).Panes.AddRange(new DockablePaneBase[1]
    {
      (DockablePaneBase) dockableControlPane
    });
    ((DockablePaneBase) dockAreaPane).Size = new Size(249, 638);
    this.ultraDockManager1.DockAreas.AddRange(new DockAreaPane[1]
    {
      dockAreaPane
    });
    this.ultraDockManager1.HostControl = (ContainerControl) this;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft).Dock = DockStyle.Left;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft).Font = new Font("Tahoma", 8f);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft).Location = new Point(0, 23);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft).Name = "_formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft";
    ((ManagedContainerControlBase) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft).Owner = (UltraComponentControlManagerBase) this.ultraDockManager1;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft).Size = new Size(0, 639);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft).TabIndex = 37;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaRight).Dock = DockStyle.Right;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaRight).Font = new Font("Tahoma", 8f);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaRight).Location = new Point(1152, 23);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaRight).Name = "_formCostCenterAnalysisReportContainerUnpinnedTabAreaRight";
    ((ManagedContainerControlBase) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaRight).Owner = (UltraComponentControlManagerBase) this.ultraDockManager1;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaRight).Size = new Size(0, 639);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaRight).TabIndex = 38;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaTop).Dock = DockStyle.Top;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaTop).Font = new Font("Tahoma", 8f);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaTop).Location = new Point(0, 23);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaTop).Name = "_formCostCenterAnalysisReportContainerUnpinnedTabAreaTop";
    ((ManagedContainerControlBase) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaTop).Owner = (UltraComponentControlManagerBase) this.ultraDockManager1;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaTop).Size = new Size(1152, 0);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaTop).TabIndex = 39;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom).Dock = DockStyle.Bottom;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom).Font = new Font("Tahoma", 8f);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom).Location = new Point(0, 662);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom).Name = "_formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom";
    ((ManagedContainerControlBase) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom).Owner = (UltraComponentControlManagerBase) this.ultraDockManager1;
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom).Size = new Size(1152, 0);
    ((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom).TabIndex = 40;
    ((Control) this._formCostCenterAnalysisReportContainerAutoHideControl).Font = new Font("Tahoma", 8f);
    ((Control) this._formCostCenterAnalysisReportContainerAutoHideControl).Location = new Point(733, 24);
    ((Control) this._formCostCenterAnalysisReportContainerAutoHideControl).Name = "_formCostCenterAnalysisReportContainerAutoHideControl";
    ((ManagedContainerControlBase) this._formCostCenterAnalysisReportContainerAutoHideControl).Owner = (UltraComponentControlManagerBase) this.ultraDockManager1;
    ((Control) this._formCostCenterAnalysisReportContainerAutoHideControl).Size = new Size(254, 638);
    ((Control) this._formCostCenterAnalysisReportContainerAutoHideControl).TabIndex = 41;
    ((Control) this.windowDockingArea1).Controls.Add((Control) this.dockableWindow1);
    ((Control) this.windowDockingArea1).Dock = DockStyle.Right;
    ((Control) this.windowDockingArea1).Font = new Font("Tahoma", 8f);
    ((Control) this.windowDockingArea1).Location = new Point(754, 24);
    ((Control) this.windowDockingArea1).Name = "windowDockingArea1";
    ((ManagedContainerControlBase) this.windowDockingArea1).Owner = (UltraComponentControlManagerBase) this.ultraDockManager1;
    ((Control) this.windowDockingArea1).Size = new Size(254, 638);
    ((Control) this.windowDockingArea1).TabIndex = 43;
    ((Control) this.dockableWindow1).Controls.Add((Control) this.panelModifyReport);
    ((Control) this.dockableWindow1).Location = new Point(-10000, 0);
    ((Control) this.dockableWindow1).Name = "dockableWindow1";
    ((ManagedContainerControlBase) this.dockableWindow1).Owner = (UltraComponentControlManagerBase) this.ultraDockManager1;
    ((Control) this.dockableWindow1).Size = new Size(253, 638);
    ((Control) this.dockableWindow1).TabIndex = 49;
    this.panelMain.Controls.Add((Control) this.gridData);
    this.panelMain.Controls.Add((Control) this.panelHeaderInfo);
    this.panelMain.Controls.Add((Control) this.panel1);
    this.panelMain.Controls.Add((Control) this.panel2);
    this.panelMain.Dock = DockStyle.Fill;
    this.panelMain.Location = new Point(0, 23);
    this.panelMain.Name = "panelMain";
    this.panelMain.Size = new Size(1152, 639);
    this.panelMain.TabIndex = 44;
    ((AppearanceBase) appearance26).BackColor = Color.White;
    ((AppearanceBase) appearance26).BorderColor = Color.Black;
    ((AppearanceBase) appearance26).ForeColor = Color.Black;
    ((AppearanceBase) appearance26).ThemedElementAlpha = (Alpha) 3;
    ((UltraGridBase) this.gridData).DisplayLayout.Appearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.gridData).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((AppearanceBase) appearance27).BackColor = Color.White;
    ((AppearanceBase) appearance27).BorderColor = Color.Black;
    ((AppearanceBase) appearance27).ForeColor = Color.Black;
    ((HeaderBase) ultraGridBand2.Header).Appearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).BackColor = Color.White;
    ((AppearanceBase) appearance28).BorderColor = Color.Black;
    ((AppearanceBase) appearance28).ForeColor = Color.Black;
    ultraGridBand2.Override.FixedHeaderAppearance = (AppearanceBase) appearance28;
    ((AppearanceBase) appearance29).BackColor = Color.White;
    ((AppearanceBase) appearance29).BorderColor = Color.Black;
    ((AppearanceBase) appearance29).ForeColor = Color.Black;
    ultraGridBand2.Override.HeaderAppearance = (AppearanceBase) appearance29;
    ((AppearanceBase) appearance30).BackColor = Color.White;
    ((AppearanceBase) appearance30).BorderColor = Color.Black;
    ((AppearanceBase) appearance30).ForeColor = Color.Black;
    ultraGridBand2.Override.HotTrackHeaderAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BackColor = Color.White;
    ((AppearanceBase) appearance31).BorderColor = Color.Black;
    ((AppearanceBase) appearance31).ForeColor = Color.Black;
    ultraGridBand2.Override.RowSelectorHeaderAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.gridData).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridData).DisplayLayout.BorderStyle = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance32).BackColor = Color.White;
    ((AppearanceBase) appearance32).BackColor2 = Color.White;
    ((AppearanceBase) appearance32).BackGradientStyle = (GradientStyle) 3;
    ((AppearanceBase) appearance32).BorderColor = Color.Black;
    ((SpecialBoxBase) ((UltraGridBase) this.gridData).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance32;
    ((SpecialBoxBase) ((UltraGridBase) this.gridData).DisplayLayout.GroupByBox).Prompt = " ";
    ((AppearanceBase) appearance33).BackColor = Color.Transparent;
    ((UltraGridBase) this.gridData).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.gridData).DisplayLayout.GroupByBox.Style = (GroupByBoxStyle) 1;
    ((AppearanceBase) appearance34).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance34).BorderColor = SystemColors.Highlight;
    ((AppearanceBase) appearance34).ForeColor = Color.White;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance34;
    ((AppearanceBase) appearance35).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance35).BorderColor = SystemColors.Highlight;
    ((AppearanceBase) appearance35).ForeColor = Color.White;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance36).BorderColor = Color.White;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance37).BackColor = Color.White;
    ((AppearanceBase) appearance37).BorderColor = Color.Black;
    ((AppearanceBase) appearance37).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance37).ForeColor = Color.Black;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.FixedHeaderAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).BackColor = Color.White;
    ((AppearanceBase) appearance38).BorderColor = Color.Black;
    ((AppearanceBase) appearance38).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance38).ForeColor = Color.Black;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance38;
    ((AppearanceBase) appearance39).BackColor = Color.White;
    ((AppearanceBase) appearance39).BorderColor = Color.Black;
    ((AppearanceBase) appearance39).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance39).ForeColor = Color.Black;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.HotTrackHeaderAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance40).BorderColor = Color.White;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance40;
    ((AppearanceBase) appearance41).BackColor = Color.White;
    ((AppearanceBase) appearance41).BorderColor = Color.Black;
    ((AppearanceBase) appearance41).FontData.BoldAsString = "True";
    ((AppearanceBase) appearance41).ForeColor = Color.Black;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.RowSelectorHeaderAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance42).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance42).BorderColor = SystemColors.Highlight;
    ((AppearanceBase) appearance42).ForeColor = Color.White;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.SelectedCellAppearance = (AppearanceBase) appearance42;
    ((AppearanceBase) appearance43).BackColor = SystemColors.Highlight;
    ((AppearanceBase) appearance43).BorderColor = SystemColors.Highlight;
    ((AppearanceBase) appearance43).ForeColor = Color.White;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.SelectTypeCell = (SelectType) 1;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.SelectTypeCol = (SelectType) 1;
    ((UltraGridBase) this.gridData).DisplayLayout.Override.SelectTypeRow = (SelectType) 2;
    ((AppearanceBase) appearance44).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance44).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance44;
    ((AppearanceBase) appearance45).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance45;
    ((UltraGridBase) this.gridData).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.gridData).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.gridData).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.gridData).Dock = DockStyle.Fill;
    ((Control) this.gridData).Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridData).Location = new Point(20, 80 /*0x50*/);
    ((Control) this.gridData).Name = "gridData";
    ((Control) this.gridData).Size = new Size(1112, 559);
    ((Control) this.gridData).TabIndex = 41;
    this.gridData.InitializeLayout += new InitializeLayoutEventHandler(this.gridData_InitializeLayout_1);
    this.panelHeaderInfo.Controls.Add((Control) this.lblHeaderInfo);
    this.panelHeaderInfo.Controls.Add((Control) this.lblCompanyName);
    this.panelHeaderInfo.Controls.Add((Control) this.lblProgressMessage);
    this.panelHeaderInfo.Controls.Add((Control) this.progressFetchData);
    this.panelHeaderInfo.Cursor = Cursors.Default;
    this.panelHeaderInfo.Dock = DockStyle.Top;
    this.panelHeaderInfo.Location = new Point(20, 0);
    this.panelHeaderInfo.Name = "panelHeaderInfo";
    this.panelHeaderInfo.Size = new Size(1112, 80 /*0x50*/);
    this.panelHeaderInfo.TabIndex = 40;
    this.lblHeaderInfo.Font = new Font("Tahoma", 10f);
    this.lblHeaderInfo.Location = new Point(8, 32 /*0x20*/);
    this.lblHeaderInfo.Name = "lblHeaderInfo";
    this.lblHeaderInfo.Size = new Size(416, 40);
    this.lblHeaderInfo.TabIndex = 14;
    this.lblHeaderInfo.Text = "Chart of Accounts";
    this.lblCompanyName.AutoSize = true;
    this.lblCompanyName.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCompanyName.ForeColor = Color.CornflowerBlue;
    this.lblCompanyName.Location = new Point(8, 8);
    this.lblCompanyName.Name = "lblCompanyName";
    this.lblCompanyName.Size = new Size(164, 19);
    this.lblCompanyName.TabIndex = 13;
    this.lblCompanyName.Text = "NorthWind Traders";
    this.lblProgressMessage.Location = new Point(464, 16 /*0x10*/);
    this.lblProgressMessage.Name = "lblProgressMessage";
    this.lblProgressMessage.Size = new Size(248, 16 /*0x10*/);
    this.lblProgressMessage.TabIndex = 16 /*0x10*/;
    this.lblProgressMessage.Text = "Retrieving Data...";
    this.lblProgressMessage.Visible = false;
    ((Control) this.progressFetchData).Location = new Point(464, 32 /*0x20*/);
    ((Control) this.progressFetchData).Name = "progressFetchData";
    ((Control) this.progressFetchData).Size = new Size(264, 16 /*0x10*/);
    ((Control) this.progressFetchData).TabIndex = 15;
    ((Control) this.progressFetchData).Text = "[Formatted]";
    ((Control) this.progressFetchData).Visible = false;
    this.panel1.Dock = DockStyle.Left;
    this.panel1.Location = new Point(0, 0);
    this.panel1.Name = "panel1";
    this.panel1.Size = new Size(20, 639);
    this.panel1.TabIndex = 38;
    this.panel2.Dock = DockStyle.Right;
    this.panel2.Location = new Point(1132, 0);
    this.panel2.Name = "panel2";
    this.panel2.Size = new Size(20, 639);
    this.panel2.TabIndex = 39;
    this.ultraDataSource1.Band.Columns.AddRange(new object[1]
    {
      (object) ultraDataColumn
    });
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(1152, 662);
    this.Controls.Add((Control) this._formCostCenterAnalysisReportContainerAutoHideControl);
    this.Controls.Add((Control) this.panelMain);
    this.Controls.Add((Control) this.comboGroupBy);
    this.Controls.Add((Control) this.windowDockingArea1);
    this.Controls.Add((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaTop);
    this.Controls.Add((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaBottom);
    this.Controls.Add((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaLeft);
    this.Controls.Add((Control) this._formCostCenterAnalysisReportContainerUnpinnedTabAreaRight);
    this.Controls.Add((Control) this._formNewExpensePO_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formNewExpensePO_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formNewExpensePO_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._formNewExpensePO_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.Name = nameof (formCostCenterAnalysisReportContainer);
    this.Text = "Cost Center Analysis";
    this.Load += new EventHandler(this.formCostCenterAnalysisReportContainer_Load);
    ((ISupportInitialize) this.comboGroupBy).EndInit();
    this.panelModifyReport.ResumeLayout(false);
    ((ISupportInitialize) this.gridColumnSelector).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.ultraDockManager1).EndInit();
    ((Control) this.windowDockingArea1).ResumeLayout(false);
    ((Control) this.dockableWindow1).ResumeLayout(false);
    this.panelMain.ResumeLayout(false);
    ((ISupportInitialize) this.gridData).EndInit();
    this.panelHeaderInfo.ResumeLayout(false);
    this.panelHeaderInfo.PerformLayout();
    ((ISupportInitialize) this.ultraDataSource1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private void formCostCenterAnalysisReportContainer_Load(object sender, EventArgs e)
  {
    this.SetParameters(new string[2]
    {
      "Northwind Traders",
      "Payment Receivable "
    }, "Pay", "[spFin_GetAccountsReceivable]", new ArrayList()
    {
      (object) "FinanceCompanyGuid",
      (object) "EXGL",
      (object) "ARGL",
      (object) "UAGL",
      (object) "companylineguid",
      (object) "ChargeCode"
    }, (object) "@remitterguid", (object) "88d2b280-1455-4960-bed7-e629c0eb205e", (object) "@glcompanyid", (object) 1);
    this.Run();
  }

  public void ModifyReport()
  {
  }

  private void ToolBarClicked(object sender, ToolClickEventArgs e)
  {
    string str = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key.ToString();
    if (str == null)
      return;
    switch (str.Length)
    {
      case 5:
        switch (str[0])
        {
          case 'E':
            int num1 = str == "Excel" ? 1 : 0;
            return;
          case 'P':
            int num2 = str == "Print" ? 1 : 0;
            return;
          default:
            return;
        }
      case 6:
        int num3 = str == "Search" ? 1 : 0;
        break;
      case 7:
        if (!(str == "Refresh"))
          break;
        ((UltraGridBase) this.gridData).DataSource = (object) null;
        this.Run();
        break;
      case 9:
        int num4 = str == "ShowChart" ? 1 : 0;
        break;
      case 10:
        int num5 = str == "SaveReport" ? 1 : 0;
        break;
      case 12:
        if (!(str == "ModifyReport"))
          break;
        ((DockablePaneBase) this.ultraDockManager1.PaneFromControl((Control) this.panelModifyReport)).Closed = false;
        this.ModifyReport();
        break;
    }
  }

  private void ExportToExcel()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridData).Rows)
    {
      foreach (UltraGridColumn column in ((UltraGridBase) this.gridData).DisplayLayout.Bands[0].Columns)
        ;
    }
  }

  private void gridColumnSelector_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridColumnSelector).ActiveRow == null || this.gridColumnSelector.ActiveCell == null || !(((KeyedSubObjectBase) this.gridColumnSelector.ActiveCell.Column).Key.ToString() == "Select"))
      return;
    ((UltraGridBase) this.gridData).DisplayLayout.Bands[0].Columns[((UltraGridBase) this.gridColumnSelector).ActiveRow.Cells["ColumnName"].Value.ToString()].Hidden = bool.Parse(this.gridColumnSelector.ActiveCell.Text);
  }

  private void panel2_Paint(object sender, PaintEventArgs e)
  {
  }

  private void gridData_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
  }

  private void gridData_InitializeLayout_1(object sender, InitializeLayoutEventArgs e)
  {
  }

  private delegate void GetDataCompletedHandler();
}
