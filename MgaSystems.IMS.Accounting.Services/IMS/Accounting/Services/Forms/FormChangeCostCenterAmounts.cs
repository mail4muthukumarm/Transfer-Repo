// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.FormChangeCostCenterAmounts
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.EditCostCenterDetail;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms;

public class FormChangeCostCenterAmounts : FormBase
{
  private int _postingNum;
  private Decimal _journalAmount;
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private Panel FormChangeCostCenterAmounts_Fill_Panel;
  private UltraToolbarsDockArea _FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom;
  private UltraGrid gridAllocations;
  private dsCostCenterAllocations dsCostCenterAllocations1;

  public FormChangeCostCenterAmounts(int postingNum)
  {
    this.InitializeComponent();
    this._postingNum = postingNum;
    this.LoadPostingAllocations();
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "CANCEL":
        this.DialogResult = DialogResult.Cancel;
        break;
      case "SAVE":
        this.SaveChanges();
        break;
    }
  }

  private void LoadPostingAllocations()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsCostCenterAllocations1, new string[2]
    {
      "PostingAmount",
      "PostingAllocations"
    }, "spFin_GetPostingAllocations", new object[2]
    {
      (object) "@PostingNum",
      (object) this._postingNum
    });
    this._journalAmount = Decimal.Parse(this.dsCostCenterAllocations1.PostingAmount.Rows[0][0].ToString());
    this.Text = $"{this.Text} - {this._journalAmount.ToString("c")}";
  }

  private void SaveChanges()
  {
    if (!this.ValidateForm())
      return;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((sender, e) =>
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("spFin_DeletePostingAllocations", new object[2]
        {
          (object) "@PostingNum",
          (object) this._postingNum
        });
        foreach (UltraGridRow row in ((UltraGridBase) this.gridAllocations).Rows)
        {
          if (row.Cells["Amount"].Value != null && !string.IsNullOrEmpty(row.Cells["Amount"].Value.ToString()) && Decimal.Parse(row.Cells["Amount"].Value.ToString()) != 0M)
            DefaultDatabase.ExecuteNonQuery("spFin_InsertCostCenterAllocation", new object[6]
            {
              (object) "@PostingNum",
              (object) this._postingNum,
              (object) "@CostCenterId",
              row.Cells["CostCenterId"].Value,
              (object) "@Amount",
              row.Cells["Amount"].Value
            });
        }
        e.Transaction.Commit();
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      catch (Exception ex)
      {
        e.Transaction.Rollback();
        throw;
      }
    }));
  }

  private bool ValidateForm()
  {
    Decimal num1 = 0M;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridAllocations).Rows)
    {
      if (row.Cells["Amount"].Value != null && !string.IsNullOrEmpty(row.Cells["Amount"].Value.ToString()) && Decimal.Parse(row.Cells["Amount"].Value.ToString()) != 0M)
        num1 += Decimal.Parse(row.Cells["Amount"].Value.ToString());
    }
    if (!(num1 != this._journalAmount))
      return true;
    int num2 = (int) MessageBox.Show("You must allocate the entire posting amount to continue!", "Invalid Allocations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
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
    UltraGridBand ultraGridBand = new UltraGridBand("PostingAllocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GLAccount");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("CostCenterId");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("GroupName");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Amount");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    SummarySettings summarySettings = new SummarySettings(Strings.EmptyString, (SummaryType) 1, (string) null, "Amount", 3, true, "PostingAllocations", 0, (SummaryPosition) 3, "Amount", 3, true);
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("CANCEL");
    ButtonTool buttonTool2 = new ButtonTool("SAVE");
    ButtonTool buttonTool3 = new ButtonTool("CANCEL");
    Appearance appearance17 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormChangeCostCenterAmounts));
    ButtonTool buttonTool4 = new ButtonTool("SAVE");
    Appearance appearance18 = new Appearance();
    this.FormChangeCostCenterAmounts_Fill_Panel = new Panel();
    this.gridAllocations = new UltraGrid();
    this.dsCostCenterAllocations1 = new dsCostCenterAllocations();
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.FormChangeCostCenterAmounts_Fill_Panel.SuspendLayout();
    ((ISupportInitialize) this.gridAllocations).BeginInit();
    this.dsCostCenterAllocations1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.FormChangeCostCenterAmounts_Fill_Panel.BackColor = Color.Transparent;
    this.FormChangeCostCenterAmounts_Fill_Panel.Controls.Add((Control) this.gridAllocations);
    this.FormChangeCostCenterAmounts_Fill_Panel.Cursor = Cursors.Default;
    this.FormChangeCostCenterAmounts_Fill_Panel.Dock = DockStyle.Fill;
    this.FormChangeCostCenterAmounts_Fill_Panel.Location = new Point(0, 26);
    this.FormChangeCostCenterAmounts_Fill_Panel.Name = "FormChangeCostCenterAmounts_Fill_Panel";
    this.FormChangeCostCenterAmounts_Fill_Panel.Size = new Size(515, 315);
    this.FormChangeCostCenterAmounts_Fill_Panel.TabIndex = 0;
    ((UltraGridBase) this.gridAllocations).DataSource = (object) this.dsCostCenterAllocations1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn1.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn1.Header).Caption = "GL Account";
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 182;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 161;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Cost Center";
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Width = 183;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn4.Format = "c";
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 148;
    ultraGridBand.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridBand.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ultraGridBand.Override.CellClickAction = (CellClickAction) 1;
    ultraGridBand.Override.SummaryFooterCaptionVisible = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BackColor = Color.LightSteelBlue;
    ultraGridBand.Override.SummaryValueAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Right";
    summarySettings.Appearance = (AppearanceBase) appearance7;
    summarySettings.DisplayFormat = "{0:c}";
    summarySettings.GroupBySummaryValueAppearance = (AppearanceBase) appearance8;
    ultraGridBand.Summaries.AddRange(new SummarySettings[1]
    {
      summarySettings
    });
    ultraGridBand.SummaryFooterCaption = Strings.EmptyString;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridAllocations).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance12).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance14).BackColor = Color.Transparent;
    ((AppearanceBase) appearance14).ForeColor = Color.Black;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    ((AppearanceBase) appearance15).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance15).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridAllocations).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridAllocations).Dock = DockStyle.Fill;
    ((Control) this.gridAllocations).Location = new Point(0, 0);
    ((Control) this.gridAllocations).Name = "gridAllocations";
    ((Control) this.gridAllocations).Size = new Size(515, 315);
    ((Control) this.gridAllocations).TabIndex = 0;
    ((UltraControlBase) this.gridAllocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridAllocations).UseOsThemes = (DefaultableBoolean) 2;
    this.dsCostCenterAllocations1.DataSetName = "dsCostCenterAllocations";
    this.dsCostCenterAllocations1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left).Location = new Point(0, 26);
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left).Name = "_FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left";
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left).Size = new Size(0, 315);
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(521, 287);
    ultraToolbar.FloatingSize = new Size(290, 24);
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
    ((AppearanceBase) appearance17).Image = componentResourceManager.GetObject("appearance12.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance18).Image = componentResourceManager.GetObject("appearance11.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Save Changes";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right).Location = new Point(515, 26);
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right).Name = "_FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right";
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right).Size = new Size(0, 315);
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top).Name = "_FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top";
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top).Size = new Size(515, 26);
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom).Location = new Point(0, 341);
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom).Name = "_FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom).Size = new Size(515, 0);
    this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(515, 341);
    this.ControlBox = false;
    this.Controls.Add((Control) this.FormChangeCostCenterAmounts_Fill_Panel);
    this.Controls.Add((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._FormChangeCostCenterAmounts_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormChangeCostCenterAmounts);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Cost Center Allocation - Edit Detail";
    this.FormChangeCostCenterAmounts_Fill_Panel.ResumeLayout(false);
    ((ISupportInitialize) this.gridAllocations).EndInit();
    this.dsCostCenterAllocations1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
