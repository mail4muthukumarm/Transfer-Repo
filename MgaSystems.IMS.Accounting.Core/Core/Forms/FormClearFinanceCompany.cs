// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.FormClearFinanceCompany
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Properties;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class FormClearFinanceCompany : FormBase
{
  private int _controlNumber;
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel FormClearFinanceCompany_Fill_Panel;
  private UltraToolbarsDockArea _FormClearFinanceCompany_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormClearFinanceCompany_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormClearFinanceCompany_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormClearFinanceCompany_Toolbars_Dock_Area_Top;
  private UltraGrid gridFinanceCompanies;

  public FormClearFinanceCompany() => this.InitializeComponent();

  public FormClearFinanceCompany(int controlNumber)
  {
    this.InitializeComponent();
    this._controlNumber = controlNumber;
  }

  private void FormClearFinanceCompany_Load(object sender, EventArgs e)
  {
    this.LoadFinanceCompanies();
  }

  private void LoadFinanceCompanies()
  {
    ((UltraGridBase) this.gridFinanceCompanies).DataSource = (object) DefaultDatabase.ExecuteDataTable("spFin_GetClearFinanceCompanies", new object[2]
    {
      (object) "@controlNumber",
      (object) this._controlNumber
    });
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridFinanceCompanies).Rows).Count == 0)
      return;
    UltraGridBand band = ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Bands[0];
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("quoteId"))
      band.Columns["quoteId"].Hidden = true;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("financeCompanyGuid"))
      band.Columns["financeCompanyGuid"].Hidden = true;
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("policy number"))
    {
      band.Columns["policy number"].CellActivation = (Activation) 3;
      ((HeaderBase) band.Columns["policy number"].Header).Appearance.TextHAlign = (HAlign) 1;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("finance company"))
    {
      band.Columns["finance company"].CellActivation = (Activation) 3;
      ((HeaderBase) band.Columns["finance company"].Header).Appearance.TextHAlign = (HAlign) 1;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("endorsement effective"))
    {
      band.Columns["endorsement effective"].CellActivation = (Activation) 3;
      ((HeaderBase) band.Columns["endorsement effective"].Header).Appearance.TextHAlign = (HAlign) 1;
    }
    if (((KeyedSubObjectsCollectionBase) band.Columns).Exists("finance account number"))
    {
      band.Columns["finance account number"].CellActivation = (Activation) 3;
      ((HeaderBase) band.Columns["finance account number"].Header).Appearance.TextHAlign = (HAlign) 1;
    }
    UltraGridColumn ultraGridColumn = band.Columns.Add("select", string.Empty);
    ultraGridColumn.DataType = typeof (bool);
    ultraGridColumn.DefaultCellValue = (object) false;
    ultraGridColumn.Style = (ColumnStyle) 3;
    ultraGridColumn.CellActivation = (Activation) 0;
    ultraGridColumn.Width = 20;
    band.Override.CellClickAction = (CellClickAction) 1;
    band.Override.AllowUpdate = (DefaultableBoolean) 1;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "CLEARALL":
        this.ClearFiananceCompanies(true);
        break;
      case "CLEARSELECTED":
        this.ClearFiananceCompanies(false);
        break;
      case "CANCEL":
        this.DialogResult = DialogResult.Cancel;
        this.Close();
        break;
    }
  }

  private void ClearFiananceCompanies(bool all)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridFinanceCompanies).Rows)
    {
      if (all)
      {
        DataRow dataRow = DefaultDatabase.ExecuteDataRow("spFin_UpdateFinanceCompany", new object[6]
        {
          (object) "@quoteid",
          row.Cells["quoteid"].Value,
          (object) "@financecompanyguid",
          null,
          (object) "@accountnumber",
          null
        });
        CurrentUser.Instance.LogAction($"Removed finance company from quote Id# {row.Cells["quoteId"].Value.ToString()}.");
        dataRow = (DataRow) null;
      }
      else if ((bool) row.Cells["select"].Value)
      {
        DataRow dataRow = DefaultDatabase.ExecuteDataRow("spFin_UpdateFinanceCompany", new object[6]
        {
          (object) "@quoteid",
          row.Cells["quoteid"].Value,
          (object) "@financecompanyguid",
          null,
          (object) "@accountnumber",
          null
        });
        CurrentUser.Instance.LogAction($"Removed finance company from quote Id# {row.Cells["quoteId"].Value.ToString()}.");
        dataRow = (DataRow) null;
      }
    }
    this.DialogResult = DialogResult.OK;
    this.Close();
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
    ButtonTool buttonTool1 = new ButtonTool("CLEARALL");
    ButtonTool buttonTool2 = new ButtonTool("CLEARSELECTED");
    ButtonTool buttonTool3 = new ButtonTool("CANCEL");
    ButtonTool buttonTool4 = new ButtonTool("CLEARALL");
    Appearance appearance1 = new Appearance();
    ButtonTool buttonTool5 = new ButtonTool("CLEARSELECTED");
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormClearFinanceCompany));
    ButtonTool buttonTool6 = new ButtonTool("CANCEL");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("", -1);
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.FormClearFinanceCompany_Fill_Panel = new UltraPanel();
    this.gridFinanceCompanies = new UltraGrid();
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((Control) this.FormClearFinanceCompany_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormClearFinanceCompany_Fill_Panel).SuspendLayout();
    ((ISupportInitialize) this.gridFinanceCompanies).BeginInit();
    this.SuspendLayout();
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.LockToolbars = true;
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
    ultraToolbar.IsStockToolbar = false;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3
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
    ((AppearanceBase) appearance1).Image = (object) Resources.cog_edit;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Clear All";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance14.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Clear Selected";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance3).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((AppearanceBase) appearance4).BackColor = Color.Transparent;
    this.FormClearFinanceCompany_Fill_Panel.Appearance = (AppearanceBase) appearance4;
    ((Control) this.FormClearFinanceCompany_Fill_Panel.ClientArea).Controls.Add((Control) this.gridFinanceCompanies);
    ((Control) this.FormClearFinanceCompany_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormClearFinanceCompany_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormClearFinanceCompany_Fill_Panel).Location = new Point(0, 51);
    ((Control) this.FormClearFinanceCompany_Fill_Panel).Name = "FormClearFinanceCompany_Fill_Panel";
    ((Control) this.FormClearFinanceCompany_Fill_Panel).Size = new Size(825, 263);
    ((Control) this.FormClearFinanceCompany_Fill_Panel).TabIndex = 0;
    ((AppearanceBase) appearance5).BackColor = Color.White;
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridBand.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ultraGridBand.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ultraGridBand.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance8).ForeColor = Color.Black;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance13).BackColor = Color.Transparent;
    ((AppearanceBase) appearance13).ForeColor = Color.Black;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance14).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridFinanceCompanies).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridFinanceCompanies).Dock = DockStyle.Fill;
    ((Control) this.gridFinanceCompanies).Location = new Point(0, 0);
    ((Control) this.gridFinanceCompanies).Name = "gridFinanceCompanies";
    ((Control) this.gridFinanceCompanies).Size = new Size(825, 263);
    ((Control) this.gridFinanceCompanies).TabIndex = 0;
    ((UltraControlBase) this.gridFinanceCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridFinanceCompanies).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Left).Location = new Point(0, 51);
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Left).Name = "_FormClearFinanceCompany_Toolbars_Dock_Area_Left";
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Left).Size = new Size(0, 263);
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Right).Location = new Point(825, 51);
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Right).Name = "_FormClearFinanceCompany_Toolbars_Dock_Area_Right";
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Right).Size = new Size(0, 263);
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Top).Name = "_FormClearFinanceCompany_Toolbars_Dock_Area_Top";
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Top).Size = new Size(825, 51);
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Bottom).Location = new Point(0, 314);
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Bottom).Name = "_FormClearFinanceCompany_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Bottom).Size = new Size(825, 0);
    this._FormClearFinanceCompany_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(825, 314);
    this.Controls.Add((Control) this.FormClearFinanceCompany_Fill_Panel);
    this.Controls.Add((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormClearFinanceCompany_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (FormClearFinanceCompany);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Clear Policy Finance Company";
    this.Load += new EventHandler(this.FormClearFinanceCompany_Load);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((Control) this.FormClearFinanceCompany_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormClearFinanceCompany_Fill_Panel).ResumeLayout(false);
    ((ISupportInitialize) this.gridFinanceCompanies).EndInit();
    this.ResumeLayout(false);
  }
}
