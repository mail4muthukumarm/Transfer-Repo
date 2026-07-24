// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.FormMasterChartSync
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Analysis.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

public class FormMasterChartSync : FormBase
{
  private IContainer components;
  private dsMasterAccountSync dsMasterAccountSync1;
  private UltraGrid ultraGrid1;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel FormMasterChartSync_Fill_Panel;
  private UltraToolbarsDockArea _FormMasterChartSync_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormMasterChartSync_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormMasterChartSync_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormMasterChartSync_Toolbars_Dock_Area_Top;

  public FormMasterChartSync() => this.InitializeComponent();

  private void FormMasterChartSync_Load(object sender, EventArgs e) => this.LoadData();

  private void LoadData()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsMasterAccountSync1, new string[2]
    {
      "OfficeLocations",
      "MasterAccounts"
    }, "spFin_GetGLMasterSync");
  }

  private void RefreshMasterAccounts()
  {
    this.dsMasterAccountSync1.Clear();
    ((Control) this.ultraGrid1).Refresh();
  }

  private void SyncronizeCharts()
  {
    foreach (dsMasterAccountSync.MasterAccountsRow row in (InternalDataCollectionBase) this.dsMasterAccountSync1.MasterAccounts.Rows)
      DefaultDatabase.ExecuteNonQuery("spFin_GLMasterCreateGLAccount", new object[6]
      {
        (object) "@GLCompanyId",
        (object) row.GLCompanyId,
        (object) "@GLMasterAccountId",
        (object) row.GLMasterId,
        (object) "@UserGuid",
        (object) CurrentUser.Instance.UserGUID
      });
    this.RefreshMasterAccounts();
  }

  private void SyncronizeChartAccount()
  {
    if (((SparseCollectionBase) this.ultraGrid1.Selected.Rows).Count == 0)
      return;
    DefaultDatabase.ExecuteNonQuery("spFin_GLMasterCreateGLAccount", new object[6]
    {
      (object) "@GLCompanyId",
      (object) int.Parse(this.ultraGrid1.Selected.Rows[0].Cells["GLCompanyId"].Value.ToString()),
      (object) "@GLMasterAccountId",
      (object) int.Parse(this.ultraGrid1.Selected.Rows[0].Cells["GLMasterId"].Value.ToString()),
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    this.RefreshMasterAccounts();
  }

  private void AddGLChartAccounts()
  {
    if (((SparseCollectionBase) this.ultraGrid1.Selected.Rows).Count == 0)
      return;
    using (FormMasterChartSyncAccounts chartSyncAccounts = new FormMasterChartSyncAccounts(int.Parse(this.ultraGrid1.Selected.Rows[0].Cells["OfficeId"].Value.ToString())))
    {
      int num = (int) chartSyncAccounts.ShowDialog((IWin32Window) this);
    }
    this.RefreshMasterAccounts();
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "SYNC":
        this.SyncronizeCharts();
        this.LoadData();
        break;
      case "CANCEL":
        this.Close();
        break;
      case "SYNCACCOUNT":
        this.SyncronizeChartAccount();
        this.LoadData();
        break;
      case "ADDGLACCOUNT":
        this.AddGLChartAccounts();
        this.LoadData();
        break;
    }
  }

  private void ultraGrid1_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right || !(((UIElement) ((UltraGridBase) sender).DisplayLayout.UIElement).ElementFromPoint(e.Location).GetContext(typeof (UltraGridRow)) is UltraGridRow context) || context.HasChild())
      return;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["ADDGLACCOUNT"].SharedProps.Visible = false;
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
    UltraGridBand ultraGridBand1 = new UltraGridBand("OfficeLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("OfficeId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Location");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("OfficeLocations_MasterAccounts");
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("OfficeLocations_MasterAccounts", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("GLCompanyId");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("GLMasterId");
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("GLAccountName");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("GLAccountShortName");
    Appearance appearance7 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("GLAccountNumber");
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("GLFinancialAccountNumber");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("AccountType");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("SYNC");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    ButtonTool buttonTool3 = new ButtonTool("SYNC");
    Appearance appearance19 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("CANCEL");
    Appearance appearance20 = new Appearance();
    ButtonTool buttonTool5 = new ButtonTool("SYNCACCOUNT");
    Appearance appearance21 = new Appearance();
    PopupMenuTool popupMenuTool = new PopupMenuTool("SyncChartAccountContext");
    ButtonTool buttonTool6 = new ButtonTool("SYNCACCOUNT");
    ButtonTool buttonTool7 = new ButtonTool("ADDGLACCOUNT");
    ButtonTool buttonTool8 = new ButtonTool("ADDGLACCOUNT");
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    this.dsMasterAccountSync1 = new dsMasterAccountSync();
    this.ultraGrid1 = new UltraGrid();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.FormMasterChartSync_Fill_Panel = new UltraPanel();
    this._FormMasterChartSync_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormMasterChartSync_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormMasterChartSync_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormMasterChartSync_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.dsMasterAccountSync1.BeginInit();
    ((ISupportInitialize) this.ultraGrid1).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((Control) this.FormMasterChartSync_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormMasterChartSync_Fill_Panel).SuspendLayout();
    this.SuspendLayout();
    this.dsMasterAccountSync1.DataSetName = "dsMasterAccountSync";
    this.dsMasterAccountSync1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.ultraGrid1, "SyncChartAccountContext");
    ((UltraGridBase) this.ultraGrid1).DataSource = (object) this.dsMasterAccountSync1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 288;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 803;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand1.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridBand1.Header).Editor = (EmbeddableEditorBase) null;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 92;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 1;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 74;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 2;
    ultraGridColumn6.Width = 182;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance7;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Short Name";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 3;
    ultraGridColumn7.Width = 228;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 4;
    ultraGridColumn8.Width = 198;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 5;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 198;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance10;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 6;
    ultraGridColumn10.Width = 176 /*0xB0*/;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BorderColor = Color.LightGray;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BackColor = Color.Transparent;
    ((AppearanceBase) appearance16).ForeColor = Color.Black;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance17).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ultraGrid1).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ultraGrid1).Dock = DockStyle.Fill;
    ((Control) this.ultraGrid1).Location = new Point(0, 0);
    ((Control) this.ultraGrid1).Name = "ultraGrid1";
    ((Control) this.ultraGrid1).Size = new Size(824, 437);
    ((Control) this.ultraGrid1).TabIndex = 0;
    ((UltraControlBase) this.ultraGrid1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ultraGrid1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraGrid1).MouseDown += new MouseEventHandler(this.ultraGrid1_MouseDown);
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(744, 173);
    ultraToolbar.FloatingSize = new Size(176 /*0xB0*/, 48 /*0x30*/);
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance19).Image = (object) Resources.table_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Syncronize Charts";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance20).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance20;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance21).Image = (object) Resources.table_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance21;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Sync Chart Account";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "PopupMenuTool1";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7
    });
    ((AppearanceBase) appearance22).Image = (object) Resources.table_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesLarge.Appearance = (AppearanceBase) appearance22;
    ((AppearanceBase) appearance23).Image = (object) Resources.table_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance23;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Add GL Account";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[5]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool8
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((AppearanceBase) appearance24).BackColor = Color.Transparent;
    this.FormMasterChartSync_Fill_Panel.Appearance = (AppearanceBase) appearance24;
    ((Control) this.FormMasterChartSync_Fill_Panel.ClientArea).Controls.Add((Control) this.ultraGrid1);
    ((Control) this.FormMasterChartSync_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormMasterChartSync_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormMasterChartSync_Fill_Panel).Location = new Point(0, 26);
    ((Control) this.FormMasterChartSync_Fill_Panel).Name = "FormMasterChartSync_Fill_Panel";
    ((Control) this.FormMasterChartSync_Fill_Panel).Size = new Size(824, 437);
    ((Control) this.FormMasterChartSync_Fill_Panel).TabIndex = 0;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMasterChartSync_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).Location = new Point(0, 26);
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).Name = "_FormMasterChartSync_Toolbars_Dock_Area_Left";
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left).Size = new Size(0, 437);
    this._FormMasterChartSync_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMasterChartSync_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).Location = new Point(824, 26);
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).Name = "_FormMasterChartSync_Toolbars_Dock_Area_Right";
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right).Size = new Size(0, 437);
    this._FormMasterChartSync_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMasterChartSync_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).Name = "_FormMasterChartSync_Toolbars_Dock_Area_Top";
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top).Size = new Size(824, 26);
    this._FormMasterChartSync_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMasterChartSync_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).Location = new Point(0, 463);
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).Name = "_FormMasterChartSync_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom).Size = new Size(824, 0);
    this._FormMasterChartSync_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(824, 463);
    this.Controls.Add((Control) this.FormMasterChartSync_Fill_Panel);
    this.Controls.Add((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormMasterChartSync_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormMasterChartSync);
    this.Text = "Master Chart Syncronization Utility";
    this.Load += new EventHandler(this.FormMasterChartSync_Load);
    this.dsMasterAccountSync1.EndInit();
    ((ISupportInitialize) this.ultraGrid1).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((Control) this.FormMasterChartSync_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormMasterChartSync_Fill_Panel).ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
