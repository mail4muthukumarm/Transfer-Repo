// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formFlatCancelConfiguration
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

[SecureResource("{9F7DFA24-F2E6-419B-A7B3-FFA16F2A98B3}", "Flat Cancel Configuration Rights", "Determines if users can access the Policy Cancel Configuration screen.", "Accounting")]
public class formFlatCancelConfiguration : FormBase
{
  private const string LogContext = "Accounting";
  private IContainer components;
  private UltraToolbarsManager ToolbarsManager;
  private UltraPanel formFlatCancelConfiguation_Fill_Panel;
  private UltraToolbarsDockArea _formFlatCancelConfiguation_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formFlatCancelConfiguation_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formFlatCancelConfiguation_Toolbars_Dock_Area_Top;
  private UltraGrid Grid;

  public formFlatCancelConfiguration() => this.InitializeComponent();

  private void Grid_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    e.DisplayPromptMsg = false;
  }

  private void Grid_DoubleClickRow(object sender, DoubleClickRowEventArgs e) => this.EditSetting();

  private void Grid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    e.Layout.AutoFitStyle = (AutoFitStyle) 2;
    e.Layout.Override.RowSizing = (RowSizing) 5;
    e.Layout.Override.CellMultiLine = (DefaultableBoolean) 1;
  }

  private void Grid_MouseDown(object sender, MouseEventArgs e)
  {
    if (e.Button != MouseButtons.Right || !(((UIElement) ((UltraGridBase) this.Grid).DisplayLayout.UIElement).ElementFromPoint(e.Location).GetContext(typeof (UltraGridRow)) is UltraGridRow context) || !context.IsDataRow)
      return;
    this.SelectRow(context);
  }

  private void ToolbarsManager_BeforeToolbarListDropdown(
    object sender,
    BeforeToolbarListDropdownEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private void ToolbarsManager_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "BAR_DELETE":
      case "GRID_DELETE":
        this.DeleteSetting();
        break;
      case "BAR_EDIT":
      case "GRID_EDIT":
        this.EditSetting();
        break;
      case "BAR_NEW":
        this.NewSetting();
        break;
    }
  }

  private void formFlatCancelConfiguration_Load(object sender, EventArgs e) => this.LoadSettings();

  private void DeleteSetting()
  {
    if (((SparseCollectionBase) this.Grid.Selected.Rows).Count == 0)
      return;
    if (MessageBox.Show("Are you sure you want to delete the setting?", "Delete Setting", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      int activeRowSettingId = this.GetActiveRowSettingId();
      DefaultDatabase.ExecuteNonQuery("dbo.spFin_FlatCancelDeleteSetting", new object[2]
      {
        (object) "@SettingId",
        (object) activeRowSettingId
      });
      string str = (string) ((UltraGridBase) this.Grid).ActiveRow.Cells["Location"].Value;
      CurrentUser.Instance.LogAction($"Deleted policy cancel setting {activeRowSettingId} ({str})", "Accounting");
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    ((UltraGridBase) this.Grid).ActiveRow.Delete();
  }

  private void EditSetting()
  {
    if (((SparseCollectionBase) this.Grid.Selected.Rows).Count == 0)
      return;
    using (formFlatCancelEditSetting cancelEditSetting = new formFlatCancelEditSetting(this.GetActiveRowSettingId()))
    {
      if (cancelEditSetting.ShowDialog() != DialogResult.OK)
        return;
      this.LoadSettings();
    }
  }

  private int GetActiveRowSettingId()
  {
    return (int) ((UltraGridBase) this.Grid).ActiveRow.Cells["SettingId"].Value;
  }

  private void LoadSettings()
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      ((UltraGridBase) this.Grid).DataSource = (object) DefaultDatabase.ExecuteDataTable("dbo.spFin_FlatCancelGetSettings");
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.Grid).Rows).Count <= 0)
        return;
      this.SelectRow(((UltraGridBase) this.Grid).Rows[0]);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void NewSetting()
  {
    using (formFlatCancelEditSetting cancelEditSetting = new formFlatCancelEditSetting())
    {
      if (cancelEditSetting.ShowDialog() != DialogResult.OK)
        return;
      this.LoadSettings();
    }
  }

  private void SelectRow(UltraGridRow row)
  {
    this.Grid.Selected.Rows.Clear();
    this.Grid.Selected.Rows.Add(row);
    ((UltraGridBase) this.Grid).ActiveRow = row;
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
    UltraToolbar ultraToolbar1 = new UltraToolbar("GridContext");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("gridPopup");
    UltraToolbar ultraToolbar2 = new UltraToolbar("MainToolbar");
    ButtonTool buttonTool1 = new ButtonTool("BAR_NEW");
    ButtonTool buttonTool2 = new ButtonTool("BAR_EDIT");
    ButtonTool buttonTool3 = new ButtonTool("BAR_DELETE");
    ButtonTool buttonTool4 = new ButtonTool("GRID_DELETE");
    Appearance appearance1 = new Appearance();
    ButtonTool buttonTool5 = new ButtonTool("GRID_EDIT");
    Appearance appearance2 = new Appearance();
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("gridPopup");
    ButtonTool buttonTool6 = new ButtonTool("GRID_EDIT");
    ButtonTool buttonTool7 = new ButtonTool("GRID_DELETE");
    ButtonTool buttonTool8 = new ButtonTool("BAR_NEW");
    Appearance appearance3 = new Appearance();
    ButtonTool buttonTool9 = new ButtonTool("BAR_EDIT");
    Appearance appearance4 = new Appearance();
    ButtonTool buttonTool10 = new ButtonTool("BAR_DELETE");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("Band 0", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("SettingId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("UserName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("UseCancellingUser");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CheckNumber");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Comments");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    this.ToolbarsManager = new UltraToolbarsManager(this.components);
    this.Grid = new UltraGrid();
    this.formFlatCancelConfiguation_Fill_Panel = new UltraPanel();
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.ToolbarsManager).BeginInit();
    ((ISupportInitialize) this.Grid).BeginInit();
    ((Control) this.formFlatCancelConfiguation_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.formFlatCancelConfiguation_Fill_Panel).SuspendLayout();
    this.SuspendLayout();
    this.ToolbarsManager.DesignerFlags = 1;
    this.ToolbarsManager.DockWithinContainer = (Control) this;
    this.ToolbarsManager.DockWithinContainerBaseType = typeof (FormBase);
    this.ToolbarsManager.MdiMergeable = false;
    this.ToolbarsManager.ShowFullMenusDelay = 500;
    this.ToolbarsManager.Style = (ToolbarStyle) 5;
    ultraToolbar1.DockedColumn = 0;
    ultraToolbar1.DockedRow = 1;
    ((UltraToolbarBase) ultraToolbar1).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar1.Text = "GridContext";
    ultraToolbar1.Visible = false;
    ultraToolbar2.DockedColumn = 0;
    ultraToolbar2.DockedRow = 0;
    ultraToolbar2.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar2).NonInheritedTools.AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
    });
    ultraToolbar2.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar2.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar2.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar2.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar2.Text = "MainToolbar";
    this.ToolbarsManager.Toolbars.AddRange(new UltraToolbar[2]
    {
      ultraToolbar1,
      ultraToolbar2
    });
    ((AppearanceBase) appearance1).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Delete";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance2).Image = (object) Resources.pencil;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Edit";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "gridPopup";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7
    });
    ((AppearanceBase) appearance3).Image = (object) Resources.add;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "New";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance4).Image = (object) Resources.pencil;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).Caption = "Edit";
    ((ToolPropsBase) ((ToolBase) buttonTool9).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance5).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance5;
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).Caption = "Delete";
    ((ToolPropsBase) ((ToolBase) buttonTool10).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ToolbarsManager.Tools).AddRange(new ToolBase[6]
    {
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10
    });
    this.ToolbarsManager.BeforeToolbarListDropdown += new BeforeToolbarListDropdownEventHandler(this.ToolbarsManager_BeforeToolbarListDropdown);
    this.ToolbarsManager.ToolClick += new ToolClickEventHandler(this.ToolbarsManager_ToolClick);
    ((Control) this.Grid).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ToolbarsManager.SetContextMenuUltra((Component) this.Grid, "gridPopup");
    ((AppearanceBase) appearance6).BackColor = Color.White;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.Grid).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.Grid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 10;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Office Location";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 138;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "User";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 120;
    ultraGridColumn4.Format = "";
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Use Cancelling User";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Style = (ColumnStyle) 3;
    ultraGridColumn4.Width = 140;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Check Number";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Width = 140;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 5;
    ultraGridColumn6.Width = 294;
    ultraGridBand.Columns.AddRange(new object[6]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ultraGridBand.GroupHeadersVisible = false;
    ((HeaderBase) ultraGridBand.Header).AllowEditing = (AllowHeaderEditing) 1;
    ((HeaderBase) ultraGridBand.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 2;
    ultraGridBand.Override.NoRowsInDataSourceMessageEnabled = (DefaultableBoolean) 1;
    ultraGridBand.Override.NoVisibleRowsMessageEnabled = (DefaultableBoolean) 1;
    ((UltraGridBase) this.Grid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.Grid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance7).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((UltraGridBase) this.Grid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((UltraGridBase) this.Grid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.Grid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BorderColor = Color.LightGray;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance12).BackColor = Color.Transparent;
    ((AppearanceBase) appearance12).ForeColor = Color.Black;
    ((UltraGridBase) this.Grid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance13).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.Grid).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.Grid).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.Grid).Location = new Point(0, 0);
    ((Control) this.Grid).Name = "Grid";
    ((Control) this.Grid).Size = new Size(834, 416);
    ((Control) this.Grid).TabIndex = 0;
    ((UltraControlBase) this.Grid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.Grid).UseOsThemes = (DefaultableBoolean) 2;
    this.Grid.InitializeLayout += new InitializeLayoutEventHandler(this.Grid_InitializeLayout);
    this.Grid.BeforeRowsDeleted += new BeforeRowsDeletedEventHandler(this.Grid_BeforeRowsDeleted);
    this.Grid.DoubleClickRow += new DoubleClickRowEventHandler(this.Grid_DoubleClickRow);
    ((Control) this.Grid).MouseDown += new MouseEventHandler(this.Grid_MouseDown);
    ((Control) this.formFlatCancelConfiguation_Fill_Panel.ClientArea).Controls.Add((Control) this.Grid);
    ((Control) this.formFlatCancelConfiguation_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.formFlatCancelConfiguation_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.formFlatCancelConfiguation_Fill_Panel).Location = new Point(0, 45);
    ((Control) this.formFlatCancelConfiguation_Fill_Panel).Name = "formFlatCancelConfiguation_Fill_Panel";
    ((Control) this.formFlatCancelConfiguation_Fill_Panel).Size = new Size(834, 416);
    ((Control) this.formFlatCancelConfiguation_Fill_Panel).TabIndex = 0;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Left).Location = new Point(0, 45);
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Left).Name = "_formFlatCancelConfiguation_Toolbars_Dock_Area_Left";
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Left).Size = new Size(0, 416);
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Left.ToolbarsManager = this.ToolbarsManager;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Right).Location = new Point(834, 45);
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Right).Name = "_formFlatCancelConfiguation_Toolbars_Dock_Area_Right";
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Right).Size = new Size(0, 416);
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Right.ToolbarsManager = this.ToolbarsManager;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Top).Name = "_formFlatCancelConfiguation_Toolbars_Dock_Area_Top";
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Top).Size = new Size(834, 45);
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Top.ToolbarsManager = this.ToolbarsManager;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom).Location = new Point(0, 461);
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom).Name = "_formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom";
    ((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom).Size = new Size(834, 0);
    this._formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ToolbarsManager;
    this.ClientSize = new Size(834, 461);
    this.Controls.Add((Control) this.formFlatCancelConfiguation_Fill_Panel);
    this.Controls.Add((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formFlatCancelConfiguation_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formFlatCancelConfiguration);
    this.Text = "Policy Cancel Wash Transaction Configuration";
    this.Load += new EventHandler(this.formFlatCancelConfiguration_Load);
    ((ISupportInitialize) this.ToolbarsManager).EndInit();
    ((ISupportInitialize) this.Grid).EndInit();
    ((Control) this.formFlatCancelConfiguation_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.formFlatCancelConfiguation_Fill_Panel).ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
