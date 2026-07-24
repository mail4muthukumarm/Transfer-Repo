// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.OperatingExpenses.UserControls.CostCenterAssignment
// Assembly: MgaSystems.IMS.Accounting.OperatingExpenses, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 77B4DED4-9019-44D3-8D52-4669B0CA70E1
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.OperatingExpenses.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.IMS.Accounting.Core.Forms;
using System;
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

public class CostCenterAssignment : UserControl
{
  internal MenuItem mnuAssignEntity;
  internal MenuItem MenuItem2;
  internal MenuItem mnuDeleteCostCenter;
  internal MenuItem mnuRemoveEntity;
  internal UltraToolbarsManager CostCenterMenu;
  internal UltraToolbarsDockArea _frmInsurancePayables_Toolbars_Dock_Area_Top;
  internal UltraToolbarsDockArea _frmInsurancePayables_Toolbars_Dock_Area_Bottom;
  internal UltraToolbarsDockArea _frmInsurancePayables_Toolbars_Dock_Area_Left;
  internal UltraToolbarsDockArea _frmInsurancePayables_Toolbars_Dock_Area_Right;
  internal MenuItem menuSetDefault;
  internal MenuItem MenuItem3;
  internal MenuItem mnuAddCostCenter;
  internal UltraGrid gridCostCenters;
  internal ContextMenu gridMenu;
  internal ImageList ImageList1;
  internal SqlConnection FormDataConnection;
  internal SqlDataAdapter daCostCenters;
  internal SqlCommand SqlSelectCommand1;
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private dsCostCenters dsCostCenters1;
  private IContainer components;
  private int glCompanyId;

  public CostCenterAssignment(int GlCompanyId)
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.LoadData();
    this.Dock = DockStyle.Fill;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  public int GlCompanyId
  {
    get => this.glCompanyId;
    set => this.glCompanyId = value;
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("spFin_GetCostCenters", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CostCenterID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Description", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("GLCOMPANYID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("spFin_GetCostCentersTable1");
    UltraGridBand ultraGridBand2 = new UltraGridBand("spFin_GetCostCentersTable1", 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("COSTCENTERID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ENTITYGUID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Entity Type");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("isdefault");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    ResourceManager resourceManager = new ResourceManager(typeof (CostCenterAssignment));
    Appearance appearance6 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("Insurance Payables");
    ButtonTool buttonTool1 = new ButtonTool("ACCT_OXNEWCOSTCENTER");
    ButtonTool buttonTool2 = new ButtonTool("ACCT_OXNEWASSIGNENTITY");
    ButtonTool buttonTool3 = new ButtonTool("ACCT_OXDELETECOSTCENTER");
    ButtonTool buttonTool4 = new ButtonTool("ACCT_OXNEWCOSTCENTER");
    ButtonTool buttonTool5 = new ButtonTool("ACCT_OXNEWASSIGNENTITY");
    Appearance appearance7 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("ACCT_OXDELETECOSTCENTER");
    Appearance appearance8 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup = new UltraExplorerBarGroup();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.gridCostCenters = new UltraGrid();
    this.gridMenu = new ContextMenu();
    this.mnuAddCostCenter = new MenuItem();
    this.mnuDeleteCostCenter = new MenuItem();
    this.MenuItem2 = new MenuItem();
    this.mnuAssignEntity = new MenuItem();
    this.mnuRemoveEntity = new MenuItem();
    this.MenuItem3 = new MenuItem();
    this.menuSetDefault = new MenuItem();
    this.ImageList1 = new ImageList(this.components);
    this.CostCenterMenu = new UltraToolbarsManager(this.components);
    this._frmInsurancePayables_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._frmInsurancePayables_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._frmInsurancePayables_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._frmInsurancePayables_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.FormDataConnection = new SqlConnection();
    this.daCostCenters = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    this.dsCostCenters1 = new dsCostCenters();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.gridCostCenters).BeginInit();
    ((ISupportInitialize) this.CostCenterMenu).BeginInit();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    this.dsCostCenters1.BeginInit();
    this.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.gridCostCenters);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(14, 38);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(532, 328);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    ((Control) this.gridCostCenters).ContextMenu = this.gridMenu;
    ((Control) this.gridCostCenters).Cursor = Cursors.Default;
    ((UltraGridBase) this.gridCostCenters).DataSource = (object) this.dsCostCenters1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 227;
    ultraGridColumn3.CellMultiLine = (DefaultableBoolean) 1;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 284;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridBand1.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 0;
    ultraGridColumn6.Hidden = true;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 1;
    ultraGridColumn7.Hidden = true;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 2;
    ultraGridColumn8.Width = 327;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 3;
    ultraGridColumn9.Width = 165;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 4;
    ultraGridColumn10.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.Silver;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 4;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance3).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).BorderAlpha = (Alpha) 3;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCostCenters).DisplayLayout.RowConnectorColor = Color.MediumBlue;
    ((Control) this.gridCostCenters).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridCostCenters).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((UltraGridBase) this.gridCostCenters).ImageList = this.ImageList1;
    ((Control) this.gridCostCenters).Location = new Point(0, 0);
    ((Control) this.gridCostCenters).Name = "gridCostCenters";
    ((Control) this.gridCostCenters).Size = new Size(532, 328);
    ((UltraControlBase) this.gridCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.gridCostCenters).TabIndex = 13;
    this.gridMenu.MenuItems.AddRange(new MenuItem[7]
    {
      this.mnuAddCostCenter,
      this.mnuDeleteCostCenter,
      this.MenuItem2,
      this.mnuAssignEntity,
      this.mnuRemoveEntity,
      this.MenuItem3,
      this.menuSetDefault
    });
    this.mnuAddCostCenter.Index = 0;
    this.mnuAddCostCenter.Text = "Add Cost Center..";
    this.mnuDeleteCostCenter.Index = 1;
    this.mnuDeleteCostCenter.Text = "Delete Cost Center";
    this.MenuItem2.Index = 2;
    this.MenuItem2.Text = "-";
    this.mnuAssignEntity.Index = 3;
    this.mnuAssignEntity.Text = "Assign Entity..";
    this.mnuRemoveEntity.Index = 4;
    this.mnuRemoveEntity.Text = "Remove Entity";
    this.MenuItem3.Index = 5;
    this.MenuItem3.Text = "-";
    this.menuSetDefault.Index = 6;
    this.menuSetDefault.Text = "Set As Entity Default..";
    this.ImageList1.ImageSize = new Size(16 /*0x10*/, 16 /*0x10*/);
    this.ImageList1.ImageStream = (ImageListStreamer) resourceManager.GetObject("ImageList1.ImageStream");
    this.ImageList1.TransparentColor = Color.Transparent;
    ((AppearanceBase) appearance6).BackColor = Color.WhiteSmoke;
    this.CostCenterMenu.Appearance = (AppearanceBase) appearance6;
    this.CostCenterMenu.DesignerFlags = 1;
    this.CostCenterMenu.DockWithinContainer = (Control) this;
    this.CostCenterMenu.MdiMergeable = false;
    this.CostCenterMenu.MenuAnimationStyle = (MenuAnimationStyle) 1;
    this.CostCenterMenu.RightAlignedMenus = (DefaultableBoolean) 2;
    this.CostCenterMenu.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ultraToolbar.Text = "Insurance Payables";
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) ((UltraToolbarBase) ultraToolbar).Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
    });
    this.CostCenterMenu.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.CostCenterMenu.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.CostCenterMenu.ToolbarSettings.AllowDockBottom = (DefaultableBoolean) 2;
    this.CostCenterMenu.ToolbarSettings.AllowDockLeft = (DefaultableBoolean) 2;
    this.CostCenterMenu.ToolbarSettings.AllowDockRight = (DefaultableBoolean) 2;
    this.CostCenterMenu.ToolbarSettings.AllowDockTop = (DefaultableBoolean) 2;
    this.CostCenterMenu.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.CostCenterMenu.ToolbarSettings.BorderStyleDocked = (UIElementBorderStyle) 1;
    this.CostCenterMenu.ToolbarSettings.CaptionPlacement = (TextPlacement) 4;
    this.CostCenterMenu.ToolbarSettings.FillEntireRow = (DefaultableBoolean) 1;
    this.CostCenterMenu.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) this.CostCenterMenu.ToolbarSettings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ((ToolbarSettingsBase) this.CostCenterMenu.ToolbarSettings).ToolSpacing = 12;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "&New Cost Center..";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolBase) buttonTool4).SharedProps.ToolTipText = "Click here to add a new purchase order.";
    ((AppearanceBase) appearance7).Image = resourceManager.GetObject("appearance7.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).AppearancesSmall.AppearanceOnToolbar = (AppearanceBase) appearance7;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).Caption = "Assign Entity";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).Caption = "Delete Cost Center";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.CostCenterMenu.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Top).BackColor = Color.WhiteSmoke;
    this._frmInsurancePayables_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Top).Name = "_frmInsurancePayables_Toolbars_Dock_Area_Top";
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Top).Size = new Size(560, 24);
    this._frmInsurancePayables_Toolbars_Dock_Area_Top.ToolbarsManager = this.CostCenterMenu;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Bottom).BackColor = Color.WhiteSmoke;
    this._frmInsurancePayables_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Bottom).Location = new Point(0, 408);
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Bottom).Name = "_frmInsurancePayables_Toolbars_Dock_Area_Bottom";
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Bottom).Size = new Size(560, 0);
    this._frmInsurancePayables_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.CostCenterMenu;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Left).BackColor = Color.WhiteSmoke;
    this._frmInsurancePayables_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Left).Location = new Point(0, 24);
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Left).Name = "_frmInsurancePayables_Toolbars_Dock_Area_Left";
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Left).Size = new Size(0, 384);
    this._frmInsurancePayables_Toolbars_Dock_Area_Left.ToolbarsManager = this.CostCenterMenu;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Right).BackColor = Color.WhiteSmoke;
    this._frmInsurancePayables_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Right).Location = new Point(560, 24);
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Right).Name = "_frmInsurancePayables_Toolbars_Dock_Area_Right";
    ((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Right).Size = new Size(0, 384);
    this._frmInsurancePayables_Toolbars_Dock_Area_Right.ToolbarsManager = this.CostCenterMenu;
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.daCostCenters.SelectCommand = this.SqlSelectCommand1;
    this.daCostCenters.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table", "spFin_GetCostCenters", new DataColumnMapping[4]
      {
        new DataColumnMapping("CostCenterID", "CostCenterID"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Description", "Description"),
        new DataColumnMapping("GLCOMPANYID", "GLCOMPANYID")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[4]
      {
        new DataColumnMapping("COSTCENTERID", "COSTCENTERID"),
        new DataColumnMapping("ENTITYGUID", "ENTITYGUID"),
        new DataColumnMapping("Name", "Name"),
        new DataColumnMapping("Entity Type", "Entity Type")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_GetCostCenters]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@GLCOMPANYID", SqlDbType.Int, 4));
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BackColor2 = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance8;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup.Settings.ContainerHeight = 330;
    ((UltraExplorerBarSettingsBase) explorerBarGroup.Settings).MaxLines = 100;
    explorerBarGroup.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup.Settings.Style = (GroupStyle) 6;
    explorerBarGroup.Text = "Cost Center Assignments";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[1]
    {
      explorerBarGroup
    });
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance9).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance10).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.White;
    ((AppearanceBase) appearance10).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance10).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance10).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance10).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance10).ImageBackground = (Image) resourceManager.GetObject("appearance10.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance11;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Bottom = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Left = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Right = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Top = 4;
    this.ultraExplorerBar1.GroupSpacing = 10;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 24);
    this.ultraExplorerBar1.Margins.Bottom = 8;
    this.ultraExplorerBar1.Margins.Left = 8;
    this.ultraExplorerBar1.Margins.Right = 8;
    this.ultraExplorerBar1.Margins.Top = 8;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(560, 384);
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBar1).TabIndex = 14;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.dsCostCenters1.DataSetName = "dsCostCenters";
    this.dsCostCenters1.Locale = new CultureInfo("en-US");
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Controls.Add((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._frmInsurancePayables_Toolbars_Dock_Area_Bottom);
    this.Name = nameof (CostCenterAssignment);
    this.Size = new Size(560, 408);
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((ISupportInitialize) this.gridCostCenters).EndInit();
    ((ISupportInitialize) this.CostCenterMenu).EndInit();
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    this.dsCostCenters1.EndInit();
    this.ResumeLayout(false);
  }

  private void LoadData()
  {
    try
    {
      this.Cursor = Cursors.WaitCursor;
      this.dsCostCenters1.Clear();
      this.daCostCenters.SelectCommand.Parameters["@GLCOMPANYID"].Value = (object) this.glCompanyId;
      this.daCostCenters.Fill((DataSet) this.dsCostCenters1);
    }
    catch (SqlException ex)
    {
      this.Cursor = Cursors.Default;
      int num = (int) MessageBox.Show("An error has occurred while trying to retreive the cost centers for the specified office location. " + ex.Errors[0].Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
    finally
    {
      this.Cursor = Cursors.Default;
    }
  }

  private void AssignEntity()
  {
    if (((UltraGridBase) this.gridCostCenters).ActiveRow == null)
    {
      int num1 = (int) MessageBox.Show("You must select a cost center to continue.", "Assign to Cost Center?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      int num2 = ((GridItemBase) ((UltraGridBase) this.gridCostCenters).ActiveRow).Band.Index != 0 ? (int) ((UltraGridBase) this.gridCostCenters).ActiveRow.ParentRow.Cells[0].Value : (int) ((UltraGridBase) this.gridCostCenters).ActiveRow.Cells[0].Value;
      FormSearchEntity formSearchEntity = new FormSearchEntity(Utility.SearchEntityTypes.ShowCompanyGroup | Utility.SearchEntityTypes.ShowCompany | Utility.SearchEntityTypes.ShowCompanyLocations | Utility.SearchEntityTypes.ShowCompanyLines | Utility.SearchEntityTypes.ShowInsured | Utility.SearchEntityTypes.ShowIntermediary | Utility.SearchEntityTypes.ShowProducer | Utility.SearchEntityTypes.ShowUsers | Utility.SearchEntityTypes.ShowExpensePayees | Utility.SearchEntityTypes.Show3rdParty | Utility.SearchEntityTypes.ShowFinanceCompanies | Utility.SearchEntityTypes.ShowInspectionCompanies);
      Guid entityGuid;
      try
      {
        int num3 = (int) formSearchEntity.ShowDialog();
        if (formSearchEntity.DialogResult != DialogResult.OK || formSearchEntity.EntityGuid.Equals(Guid.Empty))
          return;
        entityGuid = formSearchEntity.EntityGuid;
      }
      finally
      {
        formSearchEntity.Dispose();
      }
      if (MessageBox.Show("Do you wish to make this the default cost center for this entity?", "Mark as Default?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        Database.Instance.QuerySP.PerformNonQuery("spFin_AddCostCenterEntity", (object) "@costcenterid", (object) num2, (object) "@EntityGuid", (object) entityGuid, (object) "@IsDefault", (object) 1);
      else
        Database.Instance.QuerySP.PerformNonQuery("spFin_AddCostCenterEntity", (object) "@costcenterid", (object) num2, (object) "@EntityGuid", (object) entityGuid, (object) "@IsDefault", (object) 0);
      this.LoadData();
      foreach (UltraGridRow row in ((UltraGridBase) this.gridCostCenters).Rows)
      {
        if ((int) row.Cells[0].Value == num2)
        {
          row.Expanded = true;
          break;
        }
      }
    }
  }

  private void gridCostCenters_AfterRowExpanded(object sender, RowEventArgs e)
  {
    if (!e.Row.HasChild())
      return;
    ((AppearanceBase) e.Row.Appearance).BackColor = SystemColors.ControlDark;
    ((AppearanceBase) e.Row.Appearance).ForeColor = Color.White;
    ((AppearanceBase) e.Row.Appearance).FontData.Bold = (DefaultableBoolean) 1;
  }

  private void gridCostCenters_AfterRowCollapsed(object sender, RowEventArgs e)
  {
    ((AppearanceBase) e.Row.Appearance).BackColor = Color.Empty;
    ((AppearanceBase) e.Row.Appearance).ForeColor = Color.Black;
    ((AppearanceBase) e.Row.Appearance).FontData.Bold = (DefaultableBoolean) 2;
  }

  private void gridCostCenters_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (((GridItemBase) e.Row).Band.Index == 0 && (int) e.Row.Cells["GLCOMPANYID"].Value < 0)
      e.Row.Hidden = true;
    if (((GridItemBase) e.Row).Band.Index != 1)
      return;
    if ((bool) e.Row.Cells["isdefault"].Value)
      ((AppearanceBase) e.Row.Cells["Name"].Appearance).Image = (object) this.ImageList1.Images[0];
    else
      ((AppearanceBase) e.Row.Cells["Name"].Appearance).Image = (object) null;
  }

  private bool DeleteCostCenter()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridCostCenters).Rows)
    {
      if (((GridItemBase) row).Selected)
      {
        if (MessageBox.Show($"This will permanently delete cost center {row.Cells["NAME"].Value.ToString()}. Are you sure you wish to continue?", $"Delete Cost Center {row.Cells["NAME"].Value.ToString()}?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
          try
          {
            Database.Instance.QuerySP.PerformNonQuery("SpFin_DeleteCostCenter", (object) "@COSTCENTERID", (object) int.Parse(row.Cells["COSTCENTERID"].Value.ToString()));
            return true;
          }
          catch (Exception ex)
          {
            int num = (int) MessageBox.Show($"An error has occurred while trying to delete cost center {row.Cells["NAME"].Value.ToString()}. {ex.Message}", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            return false;
          }
        }
      }
    }
    return true;
  }

  private void mnuAddCostCenter_Click(object sender, EventArgs e) => this.AddCostCenter();

  private void mnuRemoveEntity_Click(object sender, EventArgs e) => this.RemoveEntity();

  private void mnuDeleteCostCenter_Click(object sender, EventArgs e)
  {
    if (!this.DeleteCostCenter())
      return;
    this.LoadData();
  }

  private void menuSetDefault_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridCostCenters).ActiveRow == null)
    {
      int num1 = (int) MessageBox.Show("You must select a cost center to continue.", "Assign to Cost Center?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (((GridItemBase) ((UltraGridBase) this.gridCostCenters).ActiveRow).Band.Index == 0)
        return;
      int num2 = (int) ((UltraGridBase) this.gridCostCenters).ActiveRow.ParentRow.Cells[0].Value;
      Guid guid = (Guid) ((UltraGridBase) this.gridCostCenters).ActiveRow.Cells[1].Value;
      Database.Instance.QuerySP.PerformNonQuery("spFin_UpdateDefaultcostCenter", (object) "@COSTCENTERID", (object) num2, (object) "@ENTITYGUID", (object) guid);
      this.LoadData();
      foreach (UltraGridRow row in ((UltraGridBase) this.gridCostCenters).Rows)
      {
        if ((int) row.Cells[0].Value == num2)
        {
          row.Expanded = true;
          break;
        }
      }
    }
  }

  private void RemoveEntity()
  {
    if (((UltraGridBase) this.gridCostCenters).ActiveRow == null)
    {
      int num1 = (int) MessageBox.Show("You must select a cost center to continue.", "Assign to Cost Center?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (((GridItemBase) ((UltraGridBase) this.gridCostCenters).ActiveRow).Band.Index == 0)
        return;
      int num2 = (int) ((UltraGridBase) this.gridCostCenters).ActiveRow.ParentRow.Cells[0].Value;
      Guid guid = (Guid) ((UltraGridBase) this.gridCostCenters).ActiveRow.Cells[1].Value;
      Database.Instance.QuerySP.PerformNonQuery("spFin_CostCenterRemoveEntity", (object) "@COSTCENTERID", (object) num2, (object) "@ENTITYGUID", (object) guid);
      this.LoadData();
      foreach (UltraGridRow row in ((UltraGridBase) this.gridCostCenters).Rows)
      {
        if ((int) row.Cells[0].Value == num2)
        {
          row.Expanded = true;
          break;
        }
      }
    }
  }

  private void CostCenterMenu_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "ACCT_OXNEWCOSTCENTER")
      this.AddCostCenter();
    else if (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "ACCT_OXNEWASSIGNENTITY")
    {
      this.AssignEntity();
    }
    else
    {
      if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "ACCT_OXDELETECOSTCENTER") || !this.DeleteCostCenter())
        return;
      this.LoadData();
    }
  }

  private void AddCostCenter()
  {
  }
}
