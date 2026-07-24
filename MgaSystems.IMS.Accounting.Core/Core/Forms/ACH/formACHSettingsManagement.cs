// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.formACHSettingsManagement
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
using MGASystems.IMS.Accounting.Core.ClassObjects;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class formACHSettingsManagement : FormBase
{
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel ACHSettingsManagement_Fill_Panel;
  private UltraToolbarsDockArea _DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top;
  private ACHEntry achEntry1;
  private dsACHSettings dsACHSettings1;
  private UltraGrid gridACHSettings;

  public formACHSettingsManagement() => this.InitializeComponent();

  private void LoadACHSettings()
  {
    this.Cursor = MgaCursors.WaitCursor;
    ((UltraControlBase) this.gridACHSettings).BeginUpdate();
    this.dsACHSettings1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsACHSettings1, new string[1]
    {
      "ACHSettings"
    }, "spFin_GetAllACHInformation");
    ((UltraControlBase) this.gridACHSettings).EndUpdate();
    this.Cursor = MgaCursors.Default;
  }

  private void formACHSettingsManagement_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.LoadACHSettings();
  }

  private void achEntry1_ACHSaveComplete(object sender, ACHSaveCompleteArgs e)
  {
    this.LoadACHSettings();
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "EDIT":
        this.EditACHSettings();
        break;
      case "DELETE":
        if (((SparseCollectionBase) this.gridACHSettings.Selected.Rows).Count == 0 || MessageBox.Show("This will permanently delete this ACH setting. This action cannot be undone. Continue?", "Delete ACH Setting?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
          break;
        DefaultDatabase.ExecuteNonQuery("spFin_DeleteACHInformation", new object[2]
        {
          (object) "@entityGuid",
          this.gridACHSettings.Selected.Rows[0].Cells["EntityGuid"].Value
        });
        this.LoadACHSettings();
        break;
    }
  }

  private void EditACHSettings()
  {
    if (((SparseCollectionBase) this.gridACHSettings.Selected.Rows).Count == 0)
      return;
    this.achEntry1.LoadACHInformation(new Guid(this.gridACHSettings.Selected.Rows[0].Cells["EntityGuid"].Value.ToString()));
  }

  private void gridACHSettings_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    this.EditACHSettings();
  }

  private void gridACHSettings_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (((GridItemBase) e.Row).Band.Index != 0)
      return;
    e.Row.Cells["AccountNumber"].Value = (object) this.DecryptValue(e.Row.Cells["AccountNumber"].Value.ToString());
    e.Row.Cells["RoutingNumber"].Value = (object) this.DecryptValue(e.Row.Cells["RoutingNumber"].Value.ToString());
    e.Row.Cells["IBAN"].Value = (object) this.DecryptValue(e.Row.Cells["IBAN"].Value.ToString());
    e.Row.Cells["SWIFTCode"].Value = (object) this.DecryptValue(e.Row.Cells["SWIFTCode"].Value.ToString());
    e.Row.Cells["CHIPNumber"].Value = (object) this.DecryptValue(e.Row.Cells["CHIPNumber"].Value.ToString());
  }

  private string DecryptValue(string valueString)
  {
    Encryption encryption = new Encryption();
    if (!string.IsNullOrEmpty(valueString.ToString()) && Utility.IsBase64(valueString.ToString()))
      return encryption.DecryptTripleDes(valueString.ToString());
    return string.IsNullOrEmpty(valueString.ToString()) ? string.Empty : valueString;
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
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("gridContext");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("gridContext");
    ButtonTool buttonTool1 = new ButtonTool("EDIT");
    ButtonTool buttonTool2 = new ButtonTool("DELETE");
    ButtonTool buttonTool3 = new ButtonTool("EDIT");
    ButtonTool buttonTool4 = new ButtonTool("DELETE");
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formACHSettingsManagement));
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("ACHSettings", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("EntityGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("AccountName", -1, (object) null, 1297521844, 0, 0);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("AccountNumber", -1, (object) null, 1297521844, 1, 0, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("RoutingNumber");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("AccountType", -1, (object) null, 1297521844, 3, 0);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("BankName", -1, (object) null, 1297521844, 2, 0);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("EnteredBy");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("IBAN", -1, (object) null, 1297521844, 4, 1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("SWIFTCode", -1, (object) null, 1297521844, 5, 1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("BankISOCountryCode");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("BankAddress1");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("BankAddress2");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("BankCity");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("BankState");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("BankZipCode");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("CHIPNumber", -1, (object) null, 1297521844, 6, 1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("DateEntered", -1, (object) null, 1297521844, 7, 1);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("EnteredByUserName", -1, (object) null, 1297521844, 8, 1);
    UltraGridGroup ultraGridGroup = new UltraGridGroup("NewGroup0", 1297521844);
    Appearance appearance3 = new Appearance();
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
    Appearance appearance13 = new Appearance();
    this.dsACHSettings1 = new dsACHSettings();
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.gridACHSettings = new UltraGrid();
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.ACHSettingsManagement_Fill_Panel = new UltraPanel();
    this.achEntry1 = new ACHEntry();
    this.dsACHSettings1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((ISupportInitialize) this.gridACHSettings).BeginInit();
    ((Control) this.ACHSettingsManagement_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.ACHSettingsManagement_Fill_Panel).SuspendLayout();
    this.SuspendLayout();
    this.dsACHSettings1.DataSetName = "dsACHSettings";
    this.dsACHSettings1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top).Name = "_DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top";
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top).Size = new Size(1109, 0);
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "gridContext";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Edit ACH Setting";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance1).Image = componentResourceManager.GetObject("appearance13.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Delete ACH Setting";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridACHSettings, "gridContext");
    ((UltraGridBase) this.gridACHSettings).DataSource = (object) this.dsACHSettings1;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 125;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Width = 100;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Width = 150;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 10;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 95;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Width = 100;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Bank Name";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Width = 100;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 11;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 130;
    ultraGridColumn8.Width = 150;
    ultraGridColumn9.Width = 150;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 12;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 63 /*0x3F*/;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Address";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 14;
    ultraGridColumn11.Width = 38;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 13;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 44;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "City";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 15;
    ultraGridColumn13.Width = 21;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 16 /*0x10*/;
    ultraGridColumn14.Width = 16 /*0x10*/;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Zip Code";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 17;
    ultraGridColumn15.Width = 30;
    ultraGridColumn16.Width = 150;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Date Entered";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Width = 100;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Width = 33;
    ultraGridBand.Columns.AddRange(new object[18]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ultraGridBand.GroupHeadersVisible = false;
    ((KeyedSubObjectBase) ultraGridGroup).Key = "NewGroup0";
    ultraGridBand.Groups.AddRange(new UltraGridGroup[1]
    {
      ultraGridGroup
    });
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridBand.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand.LevelCount = 2;
    ultraGridBand.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand.Override.AllowColMoving = (AllowColMoving) 1;
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
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ultraGridBand.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ultraGridBand.Override.HeaderClickAction = (HeaderClickAction) 2;
    ultraGridBand.Override.RowSizing = (RowSizing) 5;
    ultraGridBand.Override.RowSpacingAfter = 1;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridACHSettings).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridACHSettings).Dock = DockStyle.Fill;
    ((Control) this.gridACHSettings).Location = new Point(376, 0);
    ((Control) this.gridACHSettings).Name = "gridACHSettings";
    ((Control) this.gridACHSettings).Size = new Size(733, 471);
    ((Control) this.gridACHSettings).TabIndex = 8;
    ((UltraControlBase) this.gridACHSettings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridACHSettings).UseOsThemes = (DefaultableBoolean) 2;
    this.gridACHSettings.InitializeRow += new InitializeRowEventHandler(this.gridACHSettings_InitializeRow);
    this.gridACHSettings.DoubleClickRow += new DoubleClickRowEventHandler(this.gridACHSettings_DoubleClickRow);
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom).Location = new Point(0, 471);
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom).Name = "_DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom";
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom).Size = new Size(1109, 0);
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left).Name = "_DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left";
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left).Size = new Size(0, 471);
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right).Location = new Point(1109, 0);
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right).Name = "_DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right";
    ((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right).Size = new Size(0, 471);
    this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((AppearanceBase) appearance13).BackColor = Color.Transparent;
    this.ACHSettingsManagement_Fill_Panel.Appearance = (AppearanceBase) appearance13;
    ((Control) this.ACHSettingsManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.gridACHSettings);
    ((Control) this.ACHSettingsManagement_Fill_Panel.ClientArea).Controls.Add((Control) this.achEntry1);
    ((Control) this.ACHSettingsManagement_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.ACHSettingsManagement_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.ACHSettingsManagement_Fill_Panel).Location = new Point(0, 0);
    ((Control) this.ACHSettingsManagement_Fill_Panel).Name = "ACHSettingsManagement_Fill_Panel";
    ((Control) this.ACHSettingsManagement_Fill_Panel).Size = new Size(1109, 471);
    ((Control) this.ACHSettingsManagement_Fill_Panel).TabIndex = 9;
    this.achEntry1.AccountName = "";
    this.achEntry1.AccountNumber = "";
    this.achEntry1.AccountType = "C";
    this.achEntry1.BackColor = Color.Transparent;
    this.achEntry1.BankAddress1 = "";
    this.achEntry1.BankAddress2 = "";
    this.achEntry1.BankCity = "";
    this.achEntry1.BankCountryCode = "";
    this.achEntry1.BankName = "";
    this.achEntry1.BankState = "";
    this.achEntry1.BankZipCode = "";
    this.achEntry1.CHIPNumber = "";
    this.achEntry1.Dock = DockStyle.Left;
    this.achEntry1.EntityGuid = new Guid("00000000-0000-0000-0000-000000000000");
    this.achEntry1.EntityName = "";
    this.achEntry1.Font = new Font("Tahoma", 8.25f);
    this.achEntry1.IBAN = "";
    this.achEntry1.Location = new Point(0, 0);
    this.achEntry1.Name = "achEntry1";
    this.achEntry1.PaymentFormat = -1;
    this.achEntry1.RoutingNumber = "";
    this.achEntry1.Size = new Size(376, 471);
    this.achEntry1.SWIFTCode = "";
    this.achEntry1.TabIndex = 7;
    this.achEntry1.ACHSaveComplete += new ACHEntry.ACHSaveCompleteHandler(this.achEntry1_ACHSaveComplete);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1109, 471);
    this.Controls.Add((Control) this.ACHSettingsManagement_Fill_Panel);
    this.Controls.Add((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._DUAL_ACHSettingsManagement_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (formACHSettingsManagement);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "ACH Settings Management";
    this.Load += new EventHandler(this.formACHSettingsManagement_Load);
    this.dsACHSettings1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((ISupportInitialize) this.gridACHSettings).EndInit();
    ((Control) this.ACHSettingsManagement_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.ACHSettingsManagement_Fill_Panel).ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
