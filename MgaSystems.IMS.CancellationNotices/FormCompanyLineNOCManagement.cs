// Decompiled with JetBrains decompiler
// Type: CancellationNotices.FormCompanyLineNOCManagement
// Assembly: MgaSystems.IMS.CancellationNotices, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 212B4515-7BA8-45EF-B7D5-4974627BD234
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.CancellationNotices.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace CancellationNotices;

[DesignerGenerated]
public class FormCompanyLineNOCManagement : FormBase
{
  private IContainer components;

  [DebuggerNonUserCode]
  protected override void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      base.Dispose(disposing);
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridLayout ultraGridLayout = new UltraGridLayout("Layout1");
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("VariableNOCTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("TypeName");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("NOCName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("NOCDescription");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("VariableNOCTypes_AssignedCompanyLines");
    UltraGridBand ultraGridBand2 = new UltraGridBand("VariableNOCTypes_AssignedCompanyLines", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("TypeName");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyLine");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("Company", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CompanyName");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Company_CompanyLocations");
    UltraGridBand ultraGridBand4 = new UltraGridBand("Company_CompanyLocations", 0);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CompanyGuid");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CompanyLocations_CompanyLines");
    UltraGridBand ultraGridBand5 = new UltraGridBand("CompanyLocations_CompanyLines", 1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("CompanyLine");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("CompanyLocationGuid");
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("ASSIGN");
    ButtonTool buttonTool2 = new ButtonTool("REMOVE");
    Appearance appearance28 = new Appearance();
    ButtonTool buttonTool3 = new ButtonTool("ASSIGN");
    Appearance appearance29 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("REMOVE");
    Appearance appearance30 = new Appearance();
    this.gridReports = new UltraGrid();
    this.gridCompanyLines = new UltraGrid();
    this.DsNOCCompanies1 = new dsNOCCompanies();
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.Panel1 = new Panel();
    this.Splitter1 = new Splitter();
    this.Panel3 = new Panel();
    this.Panel2 = new Panel();
    ((ISupportInitialize) this.gridReports).BeginInit();
    ((ISupportInitialize) this.gridCompanyLines).BeginInit();
    this.DsNOCCompanies1.BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.Panel1.SuspendLayout();
    this.Panel3.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.SuspendLayout();
    appearance1.BackColor = Color.Transparent;
    appearance1.BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridReports).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridReports).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridReports).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance4.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance5.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.Transparent;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.gridReports).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.WhiteSmoke;
    appearance8.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridReports).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.gridReports).Dock = DockStyle.Fill;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ultraGridLayout.Appearance = (AppearanceBase) appearance10;
    ultraGridLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 170;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "NOC Name";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 178;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "NOC Description";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 180;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 171;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 159;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 174;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Company Line";
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 529;
    ultraGridBand2.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand1);
    ultraGridLayout.BandsSerializer.Add((object) ultraGridBand2);
    ultraGridLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((KeyedSubObjectBase) ultraGridLayout).Key = "Layout1";
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ultraGridLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ultraGridLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ultraGridLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.LightGray;
    ultraGridLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    ultraGridLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ultraGridLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ultraGridLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ultraGridLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ultraGridLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ultraGridLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ultraGridLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = Color.WhiteSmoke;
    appearance17.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance18;
    ultraGridLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.gridReports).Layouts.Add(ultraGridLayout);
    ((Control) this.gridReports).Location = new Point(0, 0);
    ((Control) this.gridReports).Name = "gridReports";
    ((Control) this.gridReports).Size = new Size(529, 467);
    ((Control) this.gridReports).TabIndex = 1;
    ((UltraControlBase) this.gridReports).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridReports).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCompanyLines).DataSource = (object) this.DsNOCCompanies1;
    appearance19.BackColor = Color.Transparent;
    appearance19.BorderColor = Color.Transparent;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Appearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 263;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Company";
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 517;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 143;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridColumn12.Width = 498;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Header.VisiblePosition = 2;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 144 /*0x90*/;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Header.VisiblePosition = 3;
    ultraGridBand4.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    ultraGridBand5.ColHeadersVisible = false;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.Header.VisiblePosition = 0;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 137;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Company Line";
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn16.Width = 479;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.Header.VisiblePosition = 2;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 138;
    ultraGridBand5.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17
    });
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance20.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance20.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance20.ForeColor = Color.Black;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance21.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance22.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance23.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance23;
    appearance24.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance25.BackColor = Color.Transparent;
    appearance25.ForeColor = Color.Black;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance25;
    appearance26.BackColor = Color.WhiteSmoke;
    appearance26.BorderColor = Color.Silver;
    scrollBarLook3.ButtonAppearance = (AppearanceBase) appearance26;
    appearance27.BackColor = Color.White;
    scrollBarLook3.TrackAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.gridCompanyLines).DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((Control) this.gridCompanyLines).Dock = DockStyle.Fill;
    ((Control) this.gridCompanyLines).Location = new Point(0, 0);
    ((Control) this.gridCompanyLines).Name = "gridCompanyLines";
    ((Control) this.gridCompanyLines).Size = new Size(538, 467);
    ((Control) this.gridCompanyLines).TabIndex = 0;
    ((UltraControlBase) this.gridCompanyLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridCompanyLines).UseOsThemes = (DefaultableBoolean) 2;
    this.DsNOCCompanies1.DataSetName = "dsNOCCompanies";
    this.DsNOCCompanies1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left).BackColor = Color.White;
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left).Location = new Point(0, 43);
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left).Name = "_FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left";
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left).Size = new Size(0, 467);
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.MdiMergeable = false;
    this.UltraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.IsMainMenuBar = true;
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
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    appearance28.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance28.BackColor2 = Color.White;
    appearance28.BackGradientAlignment = (GradientAlignment) 1;
    appearance28.BackGradientStyle = (GradientStyle) 14;
    ((SettingsBase) this.UltraToolbarsManager1.ToolbarSettings).Appearance = (AppearanceBase) appearance28;
    appearance29.Image = (object) CancellationNotices.My.Resources.Resources.accept;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance29;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "Assign Company Lines";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    appearance30.Image = (object) CancellationNotices.My.Resources.Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance30;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Remove Company Lines";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).DisplayStyle = (ToolDisplayStyle) 4;
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right).BackColor = Color.White;
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right).Location = new Point(1067, 43);
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right).Name = "_FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right";
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right).Size = new Size(0, 467);
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top).BackColor = Color.White;
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top).Name = "_FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top";
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top).Size = new Size(1067, 43);
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom).BackColor = Color.White;
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom).Location = new Point(0, 510);
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom).Name = "_FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom).Size = new Size(1067, 0);
    this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    this.Panel1.BackColor = Color.Transparent;
    this.Panel1.Controls.Add((Control) this.Splitter1);
    this.Panel1.Controls.Add((Control) this.Panel3);
    this.Panel1.Controls.Add((Control) this.Panel2);
    this.Panel1.Dock = DockStyle.Fill;
    this.Panel1.Location = new Point(0, 43);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(1067, 467);
    this.Panel1.TabIndex = 8;
    this.Splitter1.BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.Splitter1.Location = new Point(538, 0);
    this.Splitter1.Name = "Splitter1";
    this.Splitter1.Size = new Size(2, 467);
    this.Splitter1.TabIndex = 2;
    this.Splitter1.TabStop = false;
    this.Panel3.BackColor = Color.Transparent;
    this.Panel3.Controls.Add((Control) this.gridReports);
    this.Panel3.Dock = DockStyle.Fill;
    this.Panel3.Location = new Point(538, 0);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(529, 467);
    this.Panel3.TabIndex = 1;
    this.Panel2.BackColor = Color.Transparent;
    this.Panel2.Controls.Add((Control) this.gridCompanyLines);
    this.Panel2.Dock = DockStyle.Left;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(538, 467);
    this.Panel2.TabIndex = 0;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1067, 510);
    this.Controls.Add((Control) this.Panel1);
    this.Controls.Add((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom);
    this.Name = nameof (FormCompanyLineNOCManagement);
    this.Text = "Company Line NOC Management";
    ((ISupportInitialize) this.gridReports).EndInit();
    ((ISupportInitialize) this.gridCompanyLines).EndInit();
    this.DsNOCCompanies1.EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel3.ResumeLayout(false);
    this.Panel2.ResumeLayout(false);
    this.ResumeLayout(false);
  }

  internal virtual UltraGrid gridCompanyLines
  {
    get => this._gridCompanyLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelableRowEventHandler cancelableRowEventHandler = new CancelableRowEventHandler(this.gridCompanyLines_BeforeRowExpanded);
      UltraGrid gridCompanyLines1 = this._gridCompanyLines;
      if (gridCompanyLines1 != null)
        gridCompanyLines1.BeforeRowExpanded -= cancelableRowEventHandler;
      this._gridCompanyLines = value;
      UltraGrid gridCompanyLines2 = this._gridCompanyLines;
      if (gridCompanyLines2 == null)
        return;
      gridCompanyLines2.BeforeRowExpanded += cancelableRowEventHandler;
    }
  }

  [field: AccessedThroughProperty("gridReports")]
  internal virtual UltraGrid gridReports { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsNOCCompanies1")]
  internal virtual dsNOCCompanies DsNOCCompanies1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual UltraToolbarsManager UltraToolbarsManager1
  {
    get => this._UltraToolbarsManager1;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      ToolClickEventHandler clickEventHandler = new ToolClickEventHandler(this.UltraToolbarsManager1_ToolClick);
      UltraToolbarsManager toolbarsManager1_1 = this._UltraToolbarsManager1;
      if (toolbarsManager1_1 != null)
        toolbarsManager1_1.ToolClick -= clickEventHandler;
      this._UltraToolbarsManager1 = value;
      UltraToolbarsManager toolbarsManager1_2 = this._UltraToolbarsManager1;
      if (toolbarsManager1_2 == null)
        return;
      toolbarsManager1_2.ToolClick += clickEventHandler;
    }
  }

  [field: AccessedThroughProperty("_FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _FormCompanyLineNOCManagement_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _FormCompanyLineNOCManagement_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _FormCompanyLineNOCManagement_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _FormCompanyLineNOCManagement_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Splitter1")]
  internal virtual Splitter Splitter1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCompanyLineNOCManagement()
  {
    this.InitializeComponent();
    this.LoadReports();
    this.LoadCompanies();
  }

  private void LoadReports()
  {
    List<Type> typeList = new List<Type>();
    typeList.AddRange((IEnumerable<Type>) ObjectFactory.Instance.QueryTypesWithAttribute((Attribute) new VariableNoticeOfCancellation(string.Empty, string.Empty)));
    if (typeList.Count == 0)
      return;
    dsVariableNOCTypes variableNocTypes = new dsVariableNOCTypes();
    try
    {
      foreach (Type type in typeList)
      {
        object[] customAttributes = type.GetCustomAttributes(false);
        int index = 0;
        if (index < customAttributes.Length)
        {
          VariableNoticeOfCancellation noticeOfCancellation = (VariableNoticeOfCancellation) customAttributes[index];
          variableNocTypes.VariableNOCTypes.Rows.Add((object) type.FullName, (object) noticeOfCancellation.NocName, (object) noticeOfCancellation.NocDescription);
        }
      }
    }
    finally
    {
      List<Type>.Enumerator enumerator;
      enumerator.Dispose();
    }
    DefaultDatabase.LoadDataSet((DataSet) variableNocTypes, new string[1]
    {
      "AssignedCompanyLines"
    }, "spFin_GetNOCOverride_Settings");
    ((UltraGridBase) this.gridReports).DataSource = (object) variableNocTypes;
    ((UltraGridBase) this.gridReports).DisplayLayout.Load(((UltraGridBase) this.gridReports).Layouts[0], (PropertyCategories) -1);
    ((UltraGridBase) this.gridReports).DisplayLayout.Appearance.BackColor = Color.Transparent;
    ((UltraGridBase) this.gridReports).DisplayLayout.Appearance.BorderColor = Color.Transparent;
  }

  private void LoadCompanies()
  {
    DefaultDatabase.LoadDataSet((DataSet) this.DsNOCCompanies1, new string[1]
    {
      "Company"
    }, "GetCompanyList");
  }

  private void LoadCompanyLocations(string companyGuid)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.DsNOCCompanies1, new string[1]
    {
      "CompanyLocations"
    }, "GetCompanyLocationList", new object[2]
    {
      (object) "@CompanyGuid",
      (object) companyGuid
    });
  }

  private void LoadCompanyLines(string companyLocationGuid)
  {
    DefaultDatabase.LoadDataSet((DataSet) this.DsNOCCompanies1, new string[1]
    {
      "CompanyLines"
    }, "GetCompanyLocation_LineList", new object[2]
    {
      (object) "@CompanyLocationGuid",
      (object) companyLocationGuid
    });
  }

  private void gridCompanyLines_BeforeRowExpanded(object sender, CancelableRowEventArgs e)
  {
    if (e.Row.HasChild())
      return;
    if (e.Row.Band.Index == 2)
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      if (e.Row.Band.Index == 0)
        this.LoadCompanyLocations(e.Row.Cells["CompanyGuid"].Value.ToString());
      else
        this.LoadCompanyLines(e.Row.Cells["CompanyLocationGuid"].Value.ToString());
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void EditAssignment(bool isDelete)
  {
    if (!isDelete && this.gridCompanyLines.Selected.Rows.Count == 0)
    {
      int num1 = (int) MessageBox.Show("You must select a company, company location or company line to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this.gridReports.Selected.Rows.Count == 0)
    {
      int num2 = (int) MessageBox.Show("You must select an NOC form to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      string str = string.Empty;
      string empty = string.Empty;
      if (!isDelete)
      {
        switch (this.gridCompanyLines.Selected.Rows[0].Band.Index)
        {
          case 0:
            str = "C";
            empty = this.gridCompanyLines.Selected.Rows[0].Cells["CompanyGuid"].Value.ToString();
            break;
          case 1:
            str = "CO";
            empty = this.gridCompanyLines.Selected.Rows[0].Cells["CompanyLocationGuid"].Value.ToString();
            break;
          case 2:
            str = "CL";
            empty = this.gridCompanyLines.Selected.Rows[0].Cells["CompanyLineGuid"].Value.ToString();
            break;
        }
      }
      else if (this.gridReports.Selected.Rows[0].Band.Index != 0)
      {
        str = "CL";
        empty = this.gridReports.Selected.Rows[0].Cells["CompanyLineGuid"].Value.ToString();
      }
      if (string.IsNullOrEmpty(empty) || string.IsNullOrEmpty(str))
        return;
      if (!isDelete)
        DefaultDatabase.ExecuteNonQuery("spFin_InsertNOCOverride", new object[6]
        {
          (object) "@EntityGuid",
          (object) empty,
          (object) "@EntityType",
          (object) str,
          (object) "@FormType",
          (object) this.gridReports.Selected.Rows[0].Cells["TypeName"].Value.ToString()
        });
      else
        DefaultDatabase.ExecuteNonQuery("spFin_DeleteNOCOverride", new object[4]
        {
          (object) "@EntityGuid",
          (object) empty,
          (object) "@EntityType",
          (object) str
        });
      this.LoadReports();
    }
  }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "ASSIGN", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "REMOVE", false) != 0)
        return;
      this.EditAssignment(true);
    }
    else
      this.EditAssignment(false);
  }
}
