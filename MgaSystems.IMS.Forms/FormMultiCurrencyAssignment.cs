// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormMultiCurrencyAssignment
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Data;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormMultiCurrencyAssignment : Form
{
  private IContainer components;

  public FormMultiCurrencyAssignment()
  {
    this.Load += new EventHandler(this.FormMultiCurrencyAssignment_Load);
    this.InitializeComponent();
  }

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("OfficeLocationCurrencies", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GLCompanyId", -1, (object) "UltraDropDown1");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Location");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("CurrencyCode", -1, (object) "UltraDropDown1");
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
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Currencies", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CurrencyCode");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Currency");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("Save");
    ButtonTool buttonTool2 = new ButtonTool("Cancel");
    ButtonTool buttonTool3 = new ButtonTool("Save");
    Appearance appearance25 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("Cancel");
    Appearance appearance26 = new Appearance();
    ButtonTool buttonTool5 = new ButtonTool("Edit Selected");
    Appearance appearance27 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("Clear");
    Appearance appearance28 = new Appearance();
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.DsOfficeLocationCurrencies1 = new dsOfficeLocationCurrencies();
    this.gridOfficeLocationCurrencies = new UltraGrid();
    this.DsCurrencies1 = new dsCurrencies();
    this.UltraDropDown1 = new UltraDropDown();
    this.UltraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.DsOfficeLocationCurrencies1.BeginInit();
    ((ISupportInitialize) this.gridOfficeLocationCurrencies).BeginInit();
    this.DsCurrencies1.BeginInit();
    ((ISupportInitialize) this.UltraDropDown1).BeginInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).Name = "_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top";
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top).Size = new Size(544, 42);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).Location = new Point(0, 331);
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).Name = "_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom).Size = new Size(544, 0);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).Location = new Point(0, 42);
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).Name = "_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left";
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left).Size = new Size(0, 289);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left.ToolbarsManager = this.UltraToolbarsManager1;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).Location = new Point(544, 42);
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).Name = "_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right";
    ((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right).Size = new Size(0, 289);
    this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right.ToolbarsManager = this.UltraToolbarsManager1;
    this.DsOfficeLocationCurrencies1.DataSetName = "dsOfficeLocationCurrencies";
    this.DsOfficeLocationCurrencies1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DataSource = (object) this.DsOfficeLocationCurrencies1;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Style = (ColumnStyle) 6;
    ultraGridColumn1.Width = 166;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Office Location";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 407;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Currency Code";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Style = (ColumnStyle) 6;
    ultraGridColumn3.Width = 135;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridBand1.Override.CellClickAction = (CellClickAction) 1;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance5.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance6.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance7.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = Color.Transparent;
    appearance9.ForeColor = Color.Black;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.WhiteSmoke;
    appearance10.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridOfficeLocationCurrencies).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridOfficeLocationCurrencies).Dock = DockStyle.Fill;
    ((Control) this.gridOfficeLocationCurrencies).Location = new Point(0, 42);
    ((Control) this.gridOfficeLocationCurrencies).Name = "gridOfficeLocationCurrencies";
    ((Control) this.gridOfficeLocationCurrencies).Size = new Size(544, 289);
    ((Control) this.gridOfficeLocationCurrencies).TabIndex = 4;
    ((UltraControlBase) this.gridOfficeLocationCurrencies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridOfficeLocationCurrencies).UseOsThemes = (DefaultableBoolean) 2;
    this.DsCurrencies1.DataSetName = "dsCurrencies";
    this.DsCurrencies1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.UltraDropDown1).DataSource = (object) this.DsCurrencies1;
    appearance12.BackColor = SystemColors.Window;
    appearance12.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Appearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Width = 68;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn5.Width = 230;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance13.BackColor = SystemColors.ActiveBorder;
    appearance13.BackColor2 = SystemColors.ControlDark;
    appearance13.BackGradientStyle = (GradientStyle) 2;
    appearance13.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance13;
    appearance14.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance14;
    ((SpecialBoxBase) ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance15.BackColor = SystemColors.ControlLightLight;
    appearance15.BackColor2 = SystemColors.Control;
    appearance15.BackGradientStyle = (GradientStyle) 3;
    appearance15.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.MaxRowScrollRegions = 1;
    appearance16.BackColor = SystemColors.Window;
    appearance16.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = SystemColors.Highlight;
    appearance17.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance18.BackColor = SystemColors.Window;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance18;
    appearance19.BorderColor = Color.LightSteelBlue;
    appearance19.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.CellPadding = 0;
    appearance20.BackColor = SystemColors.Control;
    appearance20.BackColor2 = SystemColors.ControlDark;
    appearance20.BackGradientAlignment = (GradientAlignment) 1;
    appearance20.BackGradientStyle = (GradientStyle) 3;
    appearance20.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance21;
    appearance22.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance22;
    appearance23.BackColor = SystemColors.Window;
    appearance23.BorderColor = Color.Silver;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance24.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.UltraDropDown1).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.UltraDropDown1).DropDownWidth = 300;
    ((Control) this.UltraDropDown1).Location = new Point(22, 154);
    ((Control) this.UltraDropDown1).Name = "UltraDropDown1";
    ((Control) this.UltraDropDown1).Size = new Size(301, 124);
    ((Control) this.UltraDropDown1).TabIndex = 5;
    ((Control) this.UltraDropDown1).Text = "UltraDropDown1";
    ((UltraControlBase) this.UltraDropDown1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UltraDropDown1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UltraDropDown1).Visible = false;
    this.UltraToolbarsManager1.DesignerFlags = 1;
    this.UltraToolbarsManager1.DockWithinContainer = (Control) this;
    this.UltraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.UltraToolbarsManager1.MdiMergeable = false;
    this.UltraToolbarsManager1.Style = (ToolbarStyle) 8;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(370, 171);
    ultraToolbar.FloatingSize = new Size(105, 104);
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ultraToolbar.Text = "UltraToolbar1";
    this.UltraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.UltraToolbarsManager1.ToolbarSettings.AllowCustomize = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowDockBottom = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowDockLeft = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowDockRight = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowDockTop = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowFloating = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.AllowHiding = (DefaultableBoolean) 2;
    this.UltraToolbarsManager1.ToolbarSettings.CaptionPlacement = (TextPlacement) 2;
    this.UltraToolbarsManager1.ToolbarSettings.FillEntireRow = (DefaultableBoolean) 1;
    this.UltraToolbarsManager1.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    appearance25.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance25;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Save";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    appearance26.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance26;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    appearance27.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.pencil;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance27;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Edit Selected";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    appearance28.Image = (object) MGASystems.IMS.Forms.My.Resources.Resources.arrow_refresh;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance28;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Clear";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    this.UltraToolbarsManager1.Tools.AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6
    });
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(544, 331);
    this.ControlBox = false;
    this.Controls.Add((Control) this.UltraDropDown1);
    this.Controls.Add((Control) this.gridOfficeLocationCurrencies);
    this.Controls.Add((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormMultiCurrencyAssignment);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Office Location Currency Assignment";
    this.DsOfficeLocationCurrencies1.EndInit();
    ((ISupportInitialize) this.gridOfficeLocationCurrencies).EndInit();
    this.DsCurrencies1.EndInit();
    ((ISupportInitialize) this.UltraDropDown1).EndInit();
    ((ISupportInitialize) this.UltraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

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

  [field: AccessedThroughProperty("_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left")]
  internal virtual UltraToolbarsDockArea _FormMultiCurrencyAdmin_Toolbars_Dock_Area_Left { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right")]
  internal virtual UltraToolbarsDockArea _FormMultiCurrencyAdmin_Toolbars_Dock_Area_Right { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom")]
  internal virtual UltraToolbarsDockArea _FormMultiCurrencyAdmin_Toolbars_Dock_Area_Bottom { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top")]
  internal virtual UltraToolbarsDockArea _FormMultiCurrencyAdmin_Toolbars_Dock_Area_Top { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("gridOfficeLocationCurrencies")]
  protected virtual UltraGrid gridOfficeLocationCurrencies { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsOfficeLocationCurrencies1")]
  protected virtual dsOfficeLocationCurrencies DsOfficeLocationCurrencies1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraDropDown1")]
  internal virtual UltraDropDown UltraDropDown1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsCurrencies1")]
  internal virtual dsCurrencies DsCurrencies1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private void UltraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((ToolEventArgs) e).Tool.Key;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Save", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(key, "Cancel", false) != 0)
        return;
      this.DialogResult = DialogResult.Cancel;
    }
    else
      this.Save();
  }

  public virtual void Save()
  {
    if (!this.VerifyForm())
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.gridOfficeLocationCurrencies).Rows)
      DefaultDatabase.ExecuteNonQuery("dbo.spFin_UpdateOfficeLocationCurrencyCode", new object[4]
      {
        (object) "@OfficeId",
        row.Cells["GLCompanyId"].Value,
        (object) "@CurrencyCode",
        row.Cells["CurrencyCode"].Value
      });
  }

  protected virtual void LoadOfficeLocationCurrencies()
  {
    this.DsOfficeLocationCurrencies1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.DsOfficeLocationCurrencies1, new string[1]
    {
      "OfficeLocationCurrencies"
    }, "spFin_GetOfficeLocationCurrencies");
  }

  public bool VerifyForm() => true;

  private void FormMultiCurrencyAssignment_Load(object sender, EventArgs e)
  {
    this.LoadCurrencies();
    this.LoadOfficeLocationCurrencies();
  }

  private void LoadCurrencies()
  {
    this.DsCurrencies1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.DsCurrencies1, new string[1]
    {
      "Currencies"
    }, "spFin_GetCurrencies");
  }
}
