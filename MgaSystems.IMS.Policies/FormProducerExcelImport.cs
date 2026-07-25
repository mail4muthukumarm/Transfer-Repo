// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormProducerExcelImport
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormProducerExcelImport : ClaimsExcelImport
{
  private IContainer components;
  private dsProducerExcelImport _dsImporter;
  public const string CanViewProducerExcelImports = "{6DEC057B-B2D4-4c57-826E-46655E069973}";

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
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ImportMappings", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("IMSColumn");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("SpreadsheetColumn", -1, (object) "ddSpreadsheetCols");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("SpreadsheetColumns", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("SpreadsheetColumn");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("SpreadsheetDateColumns", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("SpreadsheetColumn");
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance32 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("SpreadsheetColumns", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("SpreadsheetColumn");
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("SpreadsheetColumns", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("SpreadsheetColumn");
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    ((ISupportInitialize) this.gridMappings).BeginInit();
    ((ISupportInitialize) this.buttonLoadSheet).BeginInit();
    ((ISupportInitialize) this.comboPolicyNumber).BeginInit();
    ((ISupportInitialize) this.comboDate).BeginInit();
    ((ISupportInitialize) this.dateCriteria).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.buttonImport).BeginInit();
    ((ISupportInitialize) this.ddSpreadsheetCols).BeginInit();
    ((ISupportInitialize) this.DsBindingSource).BeginInit();
    ((ISupportInitialize) this.SpreadsheetColumnsBindingSource).BeginInit();
    ((ISupportInitialize) this.buttonLoadSavedMappings).BeginInit();
    ((ISupportInitialize) this.buttonSaveMappings).BeginInit();
    ((ISupportInitialize) this.dtpValuation).BeginInit();
    ((ISupportInitialize) this.comboControlNo).BeginInit();
    ((Control) this).SuspendLayout();
    appearance1.BackColor = SystemColors.Window;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 232;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Style = (ColumnStyle) 6;
    ultraGridColumn2.Width = 391;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.gridMappings).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridMappings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridMappings).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((SpecialBoxBase) ((UltraGridBase) this.gridMappings).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.gridMappings).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.MaxRowScrollRegions = 1;
    appearance2.BackColor = SystemColors.Window;
    appearance2.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance2;
    appearance3.BackColor = SystemColors.Highlight;
    appearance3.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance4.BackColor = SystemColors.Window;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance4;
    appearance5.BorderColor = Color.Silver;
    appearance5.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellPadding = 0;
    appearance6.BackColor = SystemColors.Control;
    appearance6.BackColor2 = SystemColors.ControlDark;
    appearance6.BackGradientAlignment = (GradientAlignment) 1;
    appearance6.BackGradientStyle = (GradientStyle) 3;
    appearance6.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance8.BackColor = SystemColors.Window;
    appearance8.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance9.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridMappings).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.gridMappings).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboPolicyNumber.DisplayLayout.Appearance = (AppearanceBase) appearance10;
    this.comboPolicyNumber.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 187;
    ultraGridBand2.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn3
    });
    this.comboPolicyNumber.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.comboPolicyNumber.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboPolicyNumber.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((SpecialBoxBase) this.comboPolicyNumber.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    this.comboPolicyNumber.DisplayLayout.MaxColScrollRegions = 1;
    this.comboPolicyNumber.DisplayLayout.MaxRowScrollRegions = 1;
    appearance11.BackColor = SystemColors.Window;
    appearance11.ForeColor = SystemColors.ControlText;
    this.comboPolicyNumber.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = SystemColors.Highlight;
    appearance12.ForeColor = SystemColors.HighlightText;
    this.comboPolicyNumber.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    this.comboPolicyNumber.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboPolicyNumber.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance13.BackColor = SystemColors.Window;
    this.comboPolicyNumber.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance13;
    appearance14.BorderColor = Color.Silver;
    appearance14.TextTrimming = (TextTrimming) 3;
    this.comboPolicyNumber.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance14;
    this.comboPolicyNumber.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboPolicyNumber.DisplayLayout.Override.CellPadding = 0;
    appearance15.BackColor = SystemColors.Control;
    appearance15.BackColor2 = SystemColors.ControlDark;
    appearance15.BackGradientAlignment = (GradientAlignment) 1;
    appearance15.BackGradientStyle = (GradientStyle) 3;
    appearance15.BorderColor = SystemColors.Window;
    this.comboPolicyNumber.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance15;
    ((AppearanceBase) appearance16).TextHAlignAsString = "Left";
    this.comboPolicyNumber.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance16;
    this.comboPolicyNumber.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboPolicyNumber.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance17.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance17.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboPolicyNumber.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = SystemColors.Window;
    appearance18.BorderColor = Color.White;
    this.comboPolicyNumber.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance18;
    this.comboPolicyNumber.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboPolicyNumber.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance19.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance19.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance19.ForeColor = Color.Black;
    this.comboPolicyNumber.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = SystemColors.ControlLight;
    this.comboPolicyNumber.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance20;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboPolicyNumber.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.comboPolicyNumber.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboPolicyNumber.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboPolicyNumber.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    appearance21.BackColor = Color.White;
    appearance21.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboDate.DisplayLayout.Appearance = (AppearanceBase) appearance21;
    this.comboDate.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Width = 187;
    ultraGridBand3.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn4
    });
    this.comboDate.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.comboDate.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDate.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((SpecialBoxBase) this.comboDate.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    this.comboDate.DisplayLayout.MaxColScrollRegions = 1;
    this.comboDate.DisplayLayout.MaxRowScrollRegions = 1;
    appearance22.BackColor = SystemColors.Window;
    appearance22.ForeColor = SystemColors.ControlText;
    this.comboDate.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance22;
    appearance23.BackColor = SystemColors.Highlight;
    appearance23.ForeColor = SystemColors.HighlightText;
    this.comboDate.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance23;
    this.comboDate.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboDate.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance24.BackColor = SystemColors.Window;
    this.comboDate.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance24;
    appearance25.BorderColor = Color.Silver;
    appearance25.TextTrimming = (TextTrimming) 3;
    this.comboDate.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance25;
    this.comboDate.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboDate.DisplayLayout.Override.CellPadding = 0;
    appearance26.BackColor = SystemColors.Control;
    appearance26.BackColor2 = SystemColors.ControlDark;
    appearance26.BackGradientAlignment = (GradientAlignment) 1;
    appearance26.BackGradientStyle = (GradientStyle) 3;
    appearance26.BorderColor = SystemColors.Window;
    this.comboDate.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance26;
    ((AppearanceBase) appearance27).TextHAlignAsString = "Left";
    this.comboDate.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance27;
    this.comboDate.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboDate.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance28.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance28.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboDate.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance28;
    appearance29.BackColor = SystemColors.Window;
    appearance29.BorderColor = Color.White;
    this.comboDate.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance29;
    this.comboDate.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboDate.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance30.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance30.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance30.ForeColor = Color.Black;
    this.comboDate.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance30;
    appearance31.BackColor = SystemColors.ControlLight;
    this.comboDate.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance31;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboDate.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.comboDate.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboDate.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboDate.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    appearance32.BackColor = SystemColors.Window;
    appearance32.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Appearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 181;
    ultraGridBand4.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn5
    });
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((SpecialBoxBase) ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.MaxRowScrollRegions = 1;
    appearance33.BackColor = SystemColors.Window;
    appearance33.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance33;
    appearance34.BackColor = SystemColors.Highlight;
    appearance34.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance35.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance35;
    appearance36.BorderColor = Color.Silver;
    appearance36.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CellPadding = 0;
    appearance37.BackColor = SystemColors.Control;
    appearance37.BackColor2 = SystemColors.ControlDark;
    appearance37.BackGradientAlignment = (GradientAlignment) 1;
    appearance37.BackGradientStyle = (GradientStyle) 3;
    appearance37.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance39.BackColor = SystemColors.Window;
    appearance39.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance40.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((Control) this.ddSpreadsheetCols).Location = new Point(62, 183);
    appearance41.BackColor = Color.White;
    appearance41.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboControlNo.DisplayLayout.Appearance = (AppearanceBase) appearance41;
    this.comboControlNo.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.ColHeadersVisible = false;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.Width = 187;
    ultraGridBand5.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn6
    });
    this.comboControlNo.DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    this.comboControlNo.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboControlNo.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    ((SpecialBoxBase) this.comboControlNo.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    this.comboControlNo.DisplayLayout.MaxColScrollRegions = 1;
    this.comboControlNo.DisplayLayout.MaxRowScrollRegions = 1;
    appearance42.BackColor = SystemColors.Window;
    appearance42.ForeColor = SystemColors.ControlText;
    this.comboControlNo.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance42;
    appearance43.BackColor = SystemColors.Highlight;
    appearance43.ForeColor = SystemColors.HighlightText;
    this.comboControlNo.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance43;
    this.comboControlNo.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboControlNo.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance44.BackColor = SystemColors.Window;
    this.comboControlNo.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance44;
    appearance45.BorderColor = Color.Silver;
    appearance45.TextTrimming = (TextTrimming) 3;
    this.comboControlNo.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance45;
    this.comboControlNo.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboControlNo.DisplayLayout.Override.CellPadding = 0;
    appearance46.BackColor = SystemColors.Control;
    appearance46.BackColor2 = SystemColors.ControlDark;
    appearance46.BackGradientAlignment = (GradientAlignment) 1;
    appearance46.BackGradientStyle = (GradientStyle) 3;
    appearance46.BorderColor = SystemColors.Window;
    this.comboControlNo.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance46;
    ((AppearanceBase) appearance47).TextHAlignAsString = "Left";
    this.comboControlNo.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance47;
    this.comboControlNo.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboControlNo.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance48.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance48.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboControlNo.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance48;
    appearance49.BackColor = SystemColors.Window;
    appearance49.BorderColor = Color.White;
    this.comboControlNo.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance49;
    this.comboControlNo.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboControlNo.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance50.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance50.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance50.ForeColor = Color.Black;
    this.comboControlNo.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance50;
    appearance51.BackColor = SystemColors.ControlLight;
    this.comboControlNo.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance51;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboControlNo.DisplayLayout.ScrollBarLook = scrollBarLook3;
    this.comboControlNo.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboControlNo.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboControlNo.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
    ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    ((Form) this).ClientSize = new Size(649, 596);
    ((Control) this).Name = nameof (FormProducerExcelImport);
    ((Form) this).Text = nameof (FormProducerExcelImport);
    ((ISupportInitialize) this.gridMappings).EndInit();
    ((ISupportInitialize) this.buttonLoadSheet).EndInit();
    ((ISupportInitialize) this.comboPolicyNumber).EndInit();
    ((ISupportInitialize) this.comboDate).EndInit();
    ((ISupportInitialize) this.dateCriteria).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.buttonImport).EndInit();
    ((ISupportInitialize) this.ddSpreadsheetCols).EndInit();
    ((ISupportInitialize) this.DsBindingSource).EndInit();
    ((ISupportInitialize) this.SpreadsheetColumnsBindingSource).EndInit();
    ((ISupportInitialize) this.buttonLoadSavedMappings).EndInit();
    ((ISupportInitialize) this.buttonSaveMappings).EndInit();
    ((ISupportInitialize) this.dtpValuation).EndInit();
    ((ISupportInitialize) this.comboControlNo).EndInit();
    ((Control) this).ResumeLayout(false);
    ((Control) this).PerformLayout();
  }

  public FormProducerExcelImport()
  {
    this.InitializeComponent();
    ((Form) this).Text = "Producer and Producer Location Excel Import";
    ((ControlBase) this.buttonImport).Text = "Import Producers";
    ((Control) this.comboPolicyNumber).Visible = false;
    ((Control) this.comboDate).Visible = false;
    this.lblWhere.Visible = false;
    this.lblFallsAfter.Visible = false;
    ((Control) this.dateCriteria).Visible = false;
    this.Label1.Visible = false;
    this._dsImporter = new dsProducerExcelImport();
  }

  protected override void OnLoadDatabaseColumns()
  {
    List<string> excludeColumns = new List<string>();
    excludeColumns.Add("ProducerGuid");
    excludeColumns.Add("ProducerLocationID");
    excludeColumns.Add("ProducerLocationGUID");
    excludeColumns.Add("ProducerGUID");
    excludeColumns.Add("ProducerBusinessTypeID");
    excludeColumns.Add("DeliveryMethodID");
    excludeColumns.Add("Closed");
    excludeColumns.Add("StatusID");
    excludeColumns.Add("DateAdded");
    excludeColumns.Add("AllowAutomaticNOC");
    excludeColumns.Add("EmailReminders");
    excludeColumns.Add("ProducerLocationRegion");
    excludeColumns.Add("StripFax");
    excludeColumns.Add("NumEmployees");
    excludeColumns.Add("GrossWrittenPremium");
    excludeColumns.Add("OptOut");
    excludeColumns.Add("ProductionPotential");
    excludeColumns.Add("LocationSource");
    excludeColumns.Add("Owner");
    excludeColumns.Add("LocationTypeID");
    excludeColumns.Add("ISOCountryCode");
    excludeColumns.Add("NumWholesaleRelationship");
    excludeColumns.Add("WholesaleRelationships");
    excludeColumns.Add("Expertise");
    excludeColumns.Add("SetProcedureToEnage");
    excludeColumns.Add("ApproveWholesalersList");
    excludeColumns.Add("SpecFocusDept");
    excludeColumns.Add("AgreementEffectiveDate");
    excludeColumns.Add("ProducerRankingID");
    excludeColumns.Add("BillToProducerLocationGuid");
    excludeColumns.Add("MailToProducerLocationGuid");
    this.AddIMSColumns("tblProducers", excludeColumns);
    this.AddIMSColumns("tblProducerLocations", excludeColumns);
  }

  protected override void OnImportButtonClicked() => this.OnImport();

  protected override string MappingStore => "tblSavedProducerImportMappings";

  protected void OnImport()
  {
    if (this._workbook != null)
    {
      using (ProducerExcelImporter producerExcelImporter = new ProducerExcelImporter(this.ds, this._SelectedWorksheet))
      {
        producerExcelImporter.ShowInTaskbar = false;
        int num = (int) producerExcelImporter.ShowDialog();
      }
    }
    else
    {
      int num1 = (int) MessageBox.Show("Please select a spreadsheet to import", "No spreadsheet", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    }
  }
}
