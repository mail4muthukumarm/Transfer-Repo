// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Analysis.GLMasterAccounts.FormOfficeAccountClassifications
// Assembly: MgaSystems.IMS.Accounting.Analysis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 8E3A477E-E77B-44DA-B1A6-ED3671BCE2BE
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Analysis.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Analysis.Properties;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Analysis.GLMasterAccounts;

public class FormOfficeAccountClassifications : Form
{
  private IContainer components;
  private UltraGrid gridOfficeAccounts;
  private dsOfficeAccountClassifications dsOfficeAccountClassifications1;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _FormOfficeAccountClassifications_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormOfficeAccountClassifications_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormOfficeAccountClassifications_Toolbars_Dock_Area_Top;

  public FormOfficeAccountClassifications()
  {
    this.InitializeComponent();
    this.LoadAccountClassfications();
  }

  private void LoadAccountClassfications()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.dsOfficeAccountClassifications1, new string[2]
    {
      "OfficeLocations",
      "OfficeAccountClassifications"
    }, "[dbo].[spFin_GetOfficeAccountClassifications]");
  }

  protected virtual void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "SyncClassifications") || MessageBox.Show(Resources.QUESTION_SYNCCLASSIFICATIONS, Resources.QUESTION_SYNCCLASSIFICATIONS_HEADER, MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    this.SyncAccountClassifications();
    this.RefreshMasterAccounts();
  }

  private void SyncAccountClassifications()
  {
    DefaultDatabase.ExecuteNonQuery("dbo.spFin_SyncGLMasterAccountClassifications");
  }

  private void RefreshMasterAccounts()
  {
    this.dsOfficeAccountClassifications1.Clear();
    ((Control) this.gridOfficeAccounts).Refresh();
    this.LoadAccountClassfications();
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
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Id");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Office Location");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("OfficeLocations_OfficeAccountClassifications");
    UltraGridBand ultraGridBand2 = new UltraGridBand("OfficeLocations_OfficeAccountClassifications", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("OfficeId");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("OfficeLocation");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("AccountClass");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ClassLLimit");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ClassULimit");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridLayout ultraGridLayout1 = new UltraGridLayout("Layout1");
    Appearance appearance14 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("MasterAccounts", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("GLMasterId");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("GLAccountName");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("GLAccountShortName");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("GLAccountNumber");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("GLFinancialAccountNumber");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("AcctTypeDescription");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("AutomationSetting", -1, (object) "dropDownAutomationSettings");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("IsBankAccount");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Select", 0);
    ColScrollRegion colScrollRegion1 = new ColScrollRegion(497);
    ColScrollRegion colScrollRegion2 = new ColScrollRegion(676);
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    UltraGridLayout ultraGridLayout2 = new UltraGridLayout("Layout2");
    Appearance appearance23 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("MasterAccounts", -1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("GLMasterId");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("GLAccountName");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("GLAccountShortName");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("GLAccountNumber");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("GLFinancialAccountNumber");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("AcctTypeDescription");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("AutomationSettingId");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("AutomationSetting", -1, (object) "dropDownAutomationSettings");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("IsBankAccount");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("Select", 0);
    ColScrollRegion colScrollRegion3 = new ColScrollRegion(497);
    ColScrollRegion colScrollRegion4 = new ColScrollRegion(676);
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("SyncClassifications");
    ButtonTool buttonTool2 = new ButtonTool("SyncClassifications");
    Appearance appearance32 = new Appearance();
    this.gridOfficeAccounts = new UltraGrid();
    this.dsOfficeAccountClassifications1 = new dsOfficeAccountClassifications();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.gridOfficeAccounts).BeginInit();
    this.dsOfficeAccountClassifications1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) this.gridOfficeAccounts).DataMember = "OfficeLocations";
    ((UltraGridBase) this.gridOfficeAccounts).DataSource = (object) this.dsOfficeAccountClassifications1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 177;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 606;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 69;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 1;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 132;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Account Class";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 2;
    ultraGridColumn6.Width = 229;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Class Lower Limit";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 3;
    ultraGridColumn7.Width = 178;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Class Upper Limit";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 4;
    ultraGridColumn8.Width = 180;
    ultraGridBand2.Columns.AddRange(new object[5]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 192 /*0xC0*/;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance7).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance11).BackColor = Color.Transparent;
    ((AppearanceBase) appearance11).ForeColor = Color.Black;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance12).BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.gridOfficeAccounts).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridOfficeAccounts).Dock = DockStyle.Fill;
    ((AppearanceBase) appearance14).BackColor = Color.White;
    ((AppearanceBase) appearance14).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout1.Appearance = (AppearanceBase) appearance14;
    ultraGridLayout1.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Master ID";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 1;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 152;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 2;
    ultraGridColumn10.Width = 128 /*0x80*/;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 3;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 128 /*0x80*/;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 4;
    ultraGridColumn12.Width = 48 /*0x30*/;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 5;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 189;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 6;
    ultraGridColumn14.Style = (ColumnStyle) 6;
    ultraGridColumn14.Width = 132;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 7;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 96 /*0x60*/;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Automation Setting";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 8;
    ultraGridColumn16.Style = (ColumnStyle) 6;
    ultraGridColumn16.Width = 144 /*0x90*/;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Bank Account";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 9;
    ultraGridColumn17.Width = 45;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn18.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn18.Header).Caption = "";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 0;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Style = (ColumnStyle) 3;
    ultraGridColumn18.Width = 32 /*0x20*/;
    ultraGridBand3.Columns.AddRange(new object[10]
    {
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
    ultraGridLayout1.BandsSerializer.Add((object) ultraGridBand3);
    ultraGridLayout1.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout1.ColScrollRegions.Add((object) colScrollRegion1);
    ultraGridLayout1.ColScrollRegions.Add((object) colScrollRegion2);
    ((KeyedSubObjectBase) ultraGridLayout1).Key = "Layout1";
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ultraGridLayout1.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ultraGridLayout1.Override.AllowAddNew = (AllowAddNew) 4;
    ultraGridLayout1.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout1.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout1.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout1.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout1.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.CellAppearance = (AppearanceBase) appearance16;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance17).TextHAlignAsString = "Left";
    ultraGridLayout1.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ultraGridLayout1.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout1.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ultraGridLayout1.Override.RowAppearance = (AppearanceBase) appearance19;
    ultraGridLayout1.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = Color.Transparent;
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ultraGridLayout1.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance22;
    ultraGridLayout1.ScrollBarLook = scrollBarLook2;
    ((AppearanceBase) appearance23).BackColor = Color.White;
    ((AppearanceBase) appearance23).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout2.Appearance = (AppearanceBase) appearance23;
    ultraGridLayout2.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn19.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Master ID";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 1;
    ultraGridColumn19.Hidden = true;
    ultraGridColumn19.Width = 152;
    ultraGridColumn20.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 2;
    ultraGridColumn20.Width = 124;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 3;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 128 /*0x80*/;
    ultraGridColumn22.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 4;
    ultraGridColumn22.Width = 49;
    ultraGridColumn23.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 5;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn23.Width = 189;
    ultraGridColumn24.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Account Type";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 6;
    ultraGridColumn24.Style = (ColumnStyle) 6;
    ultraGridColumn24.Width = 124;
    ultraGridColumn25.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn25.Header).VisiblePosition = 7;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn25.Width = 96 /*0x60*/;
    ultraGridColumn26.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn26.Header).Caption = "Automation Setting";
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn26.Header).VisiblePosition = 8;
    ultraGridColumn26.Style = (ColumnStyle) 6;
    ultraGridColumn26.Width = 136;
    ultraGridColumn27.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn27.Header).Caption = "Bank Account";
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn27.Header).VisiblePosition = 9;
    ultraGridColumn27.Width = 43;
    ultraGridColumn28.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn28.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn28.Header).Caption = "";
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn28.Header).VisiblePosition = 0;
    ultraGridColumn28.Style = (ColumnStyle) 3;
    ultraGridColumn28.Width = 21;
    ultraGridBand4.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24,
      (object) ultraGridColumn25,
      (object) ultraGridColumn26,
      (object) ultraGridColumn27,
      (object) ultraGridColumn28
    });
    ultraGridLayout2.BandsSerializer.Add((object) ultraGridBand4);
    ultraGridLayout2.BorderStyle = (UIElementBorderStyle) 4;
    ultraGridLayout2.ColScrollRegions.Add((object) colScrollRegion3);
    ultraGridLayout2.ColScrollRegions.Add((object) colScrollRegion4);
    ((KeyedSubObjectBase) ultraGridLayout2).Key = "Layout2";
    ((AppearanceBase) appearance24).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance24).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance24).ForeColor = Color.Black;
    ultraGridLayout2.Override.ActiveRowAppearance = (AppearanceBase) appearance24;
    ultraGridLayout2.Override.AllowAddNew = (AllowAddNew) 4;
    ultraGridLayout2.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridLayout2.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridLayout2.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridLayout2.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout2.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance25).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.CellAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    ultraGridLayout2.Override.HeaderAppearance = (AppearanceBase) appearance26;
    ultraGridLayout2.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance27).BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout2.Override.RowAlternateAppearance = (AppearanceBase) appearance27;
    ((AppearanceBase) appearance28).BorderColor = Color.LightGray;
    ultraGridLayout2.Override.RowAppearance = (AppearanceBase) appearance28;
    ultraGridLayout2.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance29).BackColor = Color.Transparent;
    ((AppearanceBase) appearance29).ForeColor = Color.Black;
    ultraGridLayout2.Override.SelectedRowAppearance = (AppearanceBase) appearance29;
    ((AppearanceBase) appearance30).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance30).BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance30;
    ((AppearanceBase) appearance31).BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance31;
    ultraGridLayout2.ScrollBarLook = scrollBarLook3;
    ((UltraGridBase) this.gridOfficeAccounts).Layouts.Add(ultraGridLayout1);
    ((UltraGridBase) this.gridOfficeAccounts).Layouts.Add(ultraGridLayout2);
    ((Control) this.gridOfficeAccounts).Location = new Point(0, 53);
    ((Control) this.gridOfficeAccounts).Name = "gridOfficeAccounts";
    ((Control) this.gridOfficeAccounts).Size = new Size(627, 337);
    ((Control) this.gridOfficeAccounts).TabIndex = 1;
    this.gridOfficeAccounts.UpdateMode = (UpdateMode) 1;
    ((UltraControlBase) this.gridOfficeAccounts).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOfficeAccounts).UseOsThemes = (DefaultableBoolean) 2;
    this.dsOfficeAccountClassifications1.DataSetName = "dsOfficeAccountClassifications";
    this.dsOfficeAccountClassifications1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.MiniToolbar.ToolRowCount = 1;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool1
    });
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance32).Image = (object) Resources.table_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance32;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "Sync Classifications";
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool2
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Left).Location = new Point(0, 53);
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Left).Name = "_FormOfficeAccountClassifications_Toolbars_Dock_Area_Left";
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Left).Size = new Size(0, 337);
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Right).Location = new Point(627, 53);
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Right).Name = "_FormOfficeAccountClassifications_Toolbars_Dock_Area_Right";
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Right).Size = new Size(0, 337);
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Top).Name = "_FormOfficeAccountClassifications_Toolbars_Dock_Area_Top";
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Top).Size = new Size(627, 53);
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom).Location = new Point(0, 390);
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom).Name = "_FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom).Size = new Size(627, 0);
    this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(627, 390);
    this.Controls.Add((Control) this.gridOfficeAccounts);
    this.Controls.Add((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormOfficeAccountClassifications_Toolbars_Dock_Area_Top);
    this.Name = nameof (FormOfficeAccountClassifications);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Account Classification Sync Utility";
    ((ISupportInitialize) this.gridOfficeAccounts).EndInit();
    this.dsOfficeAccountClassifications1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
