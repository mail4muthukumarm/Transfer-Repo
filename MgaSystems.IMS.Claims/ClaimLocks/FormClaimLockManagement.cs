// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.ClaimLocks.FormClaimLockManagement
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.ClaimLocks;

public class FormClaimLockManagement : FormBase
{
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel FormClaimLockManagement_Fill_Panel;
  private UltraGrid gridClaimLocks;
  private UltraToolbarsDockArea _FormClaimLockManagement_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormClaimLockManagement_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormClaimLockManagement_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormClaimLockManagement_Toolbars_Dock_Area_Top;

  public FormClaimLockManagement() => this.InitializeComponent();

  private void FormClaimLockManagement_Load(object sender, EventArgs e) => this.LoadClaimLocks();

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "Cancel":
        this.Close();
        break;
      case "DELETELOCK":
        if (((SparseCollectionBase) this.gridClaimLocks.Selected.Rows).Count == 0)
        {
          int num = (int) MessageBox.Show("You must select a lock to delete.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          break;
        }
        this.DeleteClaimLocks((int) this.gridClaimLocks.Selected.Rows[0].Cells["claimId"].Value);
        this.LoadClaimLocks();
        break;
    }
  }

  private void LoadClaimLocks()
  {
    ((UltraGridBase) this.gridClaimLocks).DataSource = (object) DefaultDatabase.ExecuteDataSet("spClaims_GetClaimLocks");
    this.FormatGrid();
  }

  private void DeleteClaimLocks(int claimId) => Utility.DeleteClaimLock(claimId);

  private void FormatGrid()
  {
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Bands[0].Columns["claimId"].Hidden = true;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Bands[0].Columns["userGuid"].Hidden = true;
    ((HeaderBase) ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Bands[0].Columns["claimNumber"].Header).Caption = "Claim Number";
    ((HeaderBase) ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Bands[0].Columns["claimNumber"].Header).Appearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Bands[0].Columns["user"].Header).Appearance.TextHAlign = (HAlign) 1;
    ((HeaderBase) ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Bands[0].Columns["lockDate"].Header).Caption = "Lock Date";
    ((HeaderBase) ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Bands[0].Columns["lockDate"].Header).Appearance.TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Bands[0].Columns["lockDate"].Format = "dddd, MMMM d yyyy HH:mm:ss tt";
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
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("Cancel");
    ButtonTool buttonTool2 = new ButtonTool("DELETELOCK");
    ButtonTool buttonTool3 = new ButtonTool("Cancel");
    Appearance appearance1 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("SAVE");
    ButtonTool buttonTool5 = new ButtonTool("DELETELOCK");
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormClaimLockManagement));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.FormClaimLockManagement_Fill_Panel = new UltraPanel();
    this.gridClaimLocks = new UltraGrid();
    this._FormClaimLockManagement_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormClaimLockManagement_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormClaimLockManagement_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormClaimLockManagement_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((Control) this.FormClaimLockManagement_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormClaimLockManagement_Fill_Panel).SuspendLayout();
    ((ISupportInitialize) this.gridClaimLocks).BeginInit();
    this.SuspendLayout();
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 8;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
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
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance1).Image = (object) Resources.CatastropheCodeSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Save";
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance11.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Delete Lock";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this.FormClaimLockManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.gridClaimLocks);
    ((Control) this.FormClaimLockManagement_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormClaimLockManagement_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormClaimLockManagement_Fill_Panel).Font = new Font("Tahoma", 8.25f);
    ((Control) this.FormClaimLockManagement_Fill_Panel).Location = new Point(0, 23);
    ((Control) this.FormClaimLockManagement_Fill_Panel).Name = "FormClaimLockManagement_Fill_Panel";
    ((Control) this.FormClaimLockManagement_Fill_Panel).Size = new Size(706, 344);
    ((Control) this.FormClaimLockManagement_Fill_Panel).TabIndex = 0;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BackColor = Color.Transparent;
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance10).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridClaimLocks).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridClaimLocks).Dock = DockStyle.Fill;
    ((Control) this.gridClaimLocks).Location = new Point(0, 0);
    ((Control) this.gridClaimLocks).Name = "gridClaimLocks";
    ((Control) this.gridClaimLocks).Size = new Size(706, 344);
    ((Control) this.gridClaimLocks).TabIndex = 0;
    ((UltraControlBase) this.gridClaimLocks).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimLocks).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormClaimLockManagement_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Left).Location = new Point(0, 23);
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Left).Name = "_FormClaimLockManagement_Toolbars_Dock_Area_Left";
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Left).Size = new Size(0, 344);
    this._FormClaimLockManagement_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormClaimLockManagement_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Right).Location = new Point(706, 23);
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Right).Name = "_FormClaimLockManagement_Toolbars_Dock_Area_Right";
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Right).Size = new Size(0, 344);
    this._FormClaimLockManagement_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormClaimLockManagement_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Top).Name = "_FormClaimLockManagement_Toolbars_Dock_Area_Top";
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Top).Size = new Size(706, 23);
    this._FormClaimLockManagement_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormClaimLockManagement_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Bottom).Location = new Point(0, 367);
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Bottom).Name = "_FormClaimLockManagement_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Bottom).Size = new Size(706, 0);
    this._FormClaimLockManagement_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(706, 367);
    this.ControlBox = false;
    this.Controls.Add((Control) this.FormClaimLockManagement_Fill_Panel);
    this.Controls.Add((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormClaimLockManagement_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormClaimLockManagement);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Claim Locks";
    this.Load += new EventHandler(this.FormClaimLockManagement_Load);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((Control) this.FormClaimLockManagement_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormClaimLockManagement_Fill_Panel).ResumeLayout(false);
    ((ISupportInitialize) this.gridClaimLocks).EndInit();
    this.ResumeLayout(false);
  }
}
