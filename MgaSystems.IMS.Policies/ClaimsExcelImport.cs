// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.ClaimsExcelImport
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.AsposeFacade.Cells;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
[SecureResource("{A52DCD4B-35C1-4605-A2F5-8EE9A4EAE6B0}", "Can View / Access Claims Import Menu", "Controls whether or not a user can view / access Claims Import menu item.", "Claims")]
public class ClaimsExcelImport : FormBase
{
  private IContainer components;
  private BindingSource ImportMappingsBindingSource;
  protected Label Label1;
  private BindingSource IMSColumnsBindingSource;
  private BindingSource SpreadsheetColumnsBindingSource1;
  private ErrorProvider err;
  protected Workbook _workbook;
  protected Worksheet _SelectedWorksheet;
  private string _policyNumberName;
  private string _mappingsName;
  private string _controlNumberName;
  private string __controlNumberSelectedString;
  private string _currentFileName;
  private bool _dateReceivedRequired;
  private bool _dateReportedRequired;
  private bool _lossTypeRequired;
  private DataTable _ddDataSource;
  public const string CanViewClaimsImportForm = "{A52DCD4B-35C1-4605-A2F5-8EE9A4EAE6B0}";

  [DebuggerNonUserCode]
  protected virtual void Dispose(bool disposing)
  {
    try
    {
      if (!disposing || this.components == null)
        return;
      this.components.Dispose();
    }
    finally
    {
      // ISSUE: explicit non-virtual call
      __nonvirtual (((Form) this).Dispose(disposing));
    }
  }

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ImportMappings", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("IMSColumn");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("SpreadsheetColumn", -1, (object) "ddSpreadsheetCols", 0, (SortIndicator) 1, false);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("SpreadsheetColumns", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("SpreadsheetColumn", -1, (object) null, 0, (SortIndicator) 1, false);
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
    Appearance appearance25 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (ClaimsExcelImport));
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("SpreadsheetColumns", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("SpreadsheetColumn");
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("SpreadsheetDateColumns", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("SpreadsheetColumn");
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    Appearance appearance53 = new Appearance();
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("SpreadsheetColumns", -1);
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("SpreadsheetColumn");
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    Appearance appearance64 = new Appearance();
    Appearance appearance65 = new Appearance();
    Appearance appearance66 = new Appearance();
    Appearance appearance67 = new Appearance();
    Appearance appearance68 = new Appearance();
    Appearance appearance69 = new Appearance();
    Appearance appearance70 = new Appearance();
    Appearance appearance71 = new Appearance();
    Appearance appearance72 = new Appearance();
    Appearance appearance73 = new Appearance();
    Appearance appearance74 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    this.gridMappings = new UltraGrid();
    this.ImportMappingsBindingSource = new BindingSource(this.components);
    this.ds = new dsExcelImport();
    this.ddSpreadsheetCols = new UltraDropDown();
    this.SpreadsheetColumnsBindingSource1 = new BindingSource(this.components);
    this.DsBindingSource = new BindingSource(this.components);
    this.SpreadsheetColumnsBindingSource = new BindingSource(this.components);
    this.buttonImport = new MGAButton();
    this.buttonLoadSheet = new MGAButton();
    this.buttonLoadSavedMappings = new MGAButton();
    this.buttonSaveMappings = new MGAButton();
    this.Label1 = new Label();
    this.comboPolicyNumber = new MGAComboBox();
    this.IMSColumnsBindingSource = new BindingSource(this.components);
    this.err = new ErrorProvider(this.components);
    this.lblWhere = new Label();
    this.lblFallsAfter = new Label();
    this.dateCriteria = new MGADateTimePicker();
    this.comboDate = new MGAComboBox();
    this.dtpValuation = new MGADateTimePicker();
    this.lblValuationDate = new Label();
    this.comboControlNo = new MGAComboBox();
    this.lblControlNo = new Label();
    ((ISupportInitialize) this.gridMappings).BeginInit();
    ((ISupportInitialize) this.ImportMappingsBindingSource).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddSpreadsheetCols).BeginInit();
    ((ISupportInitialize) this.SpreadsheetColumnsBindingSource1).BeginInit();
    ((ISupportInitialize) this.DsBindingSource).BeginInit();
    ((ISupportInitialize) this.SpreadsheetColumnsBindingSource).BeginInit();
    ((ISupportInitialize) this.buttonImport).BeginInit();
    ((ISupportInitialize) this.buttonLoadSheet).BeginInit();
    ((ISupportInitialize) this.buttonLoadSavedMappings).BeginInit();
    ((ISupportInitialize) this.buttonSaveMappings).BeginInit();
    ((ISupportInitialize) this.comboPolicyNumber).BeginInit();
    ((ISupportInitialize) this.IMSColumnsBindingSource).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.dateCriteria).BeginInit();
    ((ISupportInitialize) this.comboDate).BeginInit();
    ((ISupportInitialize) this.dtpValuation).BeginInit();
    ((ISupportInitialize) this.comboControlNo).BeginInit();
    ((Control) this).SuspendLayout();
    ((Control) this.gridMappings).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.gridMappings).DataSource = (object) this.ImportMappingsBindingSource;
    appearance1.BackColor = SystemColors.Window;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 232;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
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
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.gridMappings).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.gridMappings).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.gridMappings).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.gridMappings).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridMappings).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.gridMappings).DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance7.BackColor = SystemColors.Window;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.gridMappings).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridMappings).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.gridMappings).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((Control) this.gridMappings).Location = new Point(12, 95);
    ((Control) this.gridMappings).Name = "gridMappings";
    ((Control) this.gridMappings).Size = new Size(625, 441);
    ((Control) this.gridMappings).TabIndex = 0;
    ((Control) this.gridMappings).Text = "UltraGrid1";
    this.ImportMappingsBindingSource.DataMember = "ImportMappings";
    this.ImportMappingsBindingSource.DataSource = (object) this.ds;
    this.ds.DataSetName = "dsExcelImport";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddSpreadsheetCols).DataSource = (object) this.SpreadsheetColumnsBindingSource1;
    appearance13.BackColor = SystemColors.Window;
    appearance13.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 181;
    ultraGridBand2.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance14.BackColor = SystemColors.ActiveBorder;
    appearance14.BackColor2 = SystemColors.ControlDark;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance14;
    appearance15.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance15;
    ((SpecialBoxBase) ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance16.BackColor = SystemColors.ControlLightLight;
    appearance16.BackColor2 = SystemColors.Control;
    appearance16.BackGradientStyle = (GradientStyle) 3;
    appearance16.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.MaxRowScrollRegions = 1;
    appearance17.BackColor = SystemColors.Window;
    appearance17.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = SystemColors.Highlight;
    appearance18.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance19.BackColor = SystemColors.Window;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance19;
    appearance20.BorderColor = Color.Silver;
    appearance20.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.CellPadding = 0;
    appearance21.BackColor = SystemColors.Control;
    appearance21.BackColor2 = SystemColors.ControlDark;
    appearance21.BackGradientAlignment = (GradientAlignment) 1;
    appearance21.BackGradientStyle = (GradientStyle) 3;
    appearance21.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance23.BackColor = SystemColors.Window;
    appearance23.BorderColor = Color.Silver;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance24.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.ddSpreadsheetCols).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.ddSpreadsheetCols).DropDownWidth = 200;
    ((Control) this.ddSpreadsheetCols).Location = new Point(63 /*0x3F*/, 130);
    ((Control) this.ddSpreadsheetCols).Name = "ddSpreadsheetCols";
    ((Control) this.ddSpreadsheetCols).Size = new Size(273, 72);
    ((Control) this.ddSpreadsheetCols).TabIndex = 1;
    ((Control) this.ddSpreadsheetCols).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.ddSpreadsheetCols).ValueMember = "SpreadsheetColumn";
    ((Control) this.ddSpreadsheetCols).Visible = false;
    this.SpreadsheetColumnsBindingSource1.DataMember = "SpreadsheetColumns";
    this.SpreadsheetColumnsBindingSource1.DataSource = (object) this.DsBindingSource;
    this.DsBindingSource.DataSource = (object) this.ds;
    this.DsBindingSource.Position = 0;
    this.SpreadsheetColumnsBindingSource.DataMember = "SpreadsheetColumns";
    this.SpreadsheetColumnsBindingSource.DataSource = (object) this.DsBindingSource;
    ((Control) this.buttonImport).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance25.BackColor = Color.FromArgb(248, 248, 248);
    appearance25.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance25.BackGradientStyle = (GradientStyle) 2;
    appearance25.BorderColor = Color.DarkGray;
    appearance25.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance25.Image"));
    appearance25.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonImport).Appearance = (AppearanceBase) appearance25;
    ((Control) this.buttonImport).Location = new Point(486, 550);
    ((Control) this.buttonImport).Name = "buttonImport";
    ((Control) this.buttonImport).Size = new Size(152, 34);
    ((Control) this.buttonImport).TabIndex = 2;
    ((ControlBase) this.buttonImport).Text = "Import Claims";
    this.buttonImport.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonLoadSheet).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance26.BackColor = Color.FromArgb(248, 248, 248);
    appearance26.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance26.BackGradientStyle = (GradientStyle) 2;
    appearance26.BorderColor = Color.DarkGray;
    appearance26.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance26.Image"));
    appearance26.ImageHAlign = (HAlign) 1;
    appearance26.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonLoadSheet).Appearance = (AppearanceBase) appearance26;
    ((Control) this.buttonLoadSheet).Location = new Point(12, 550);
    ((Control) this.buttonLoadSheet).Name = "buttonLoadSheet";
    ((Control) this.buttonLoadSheet).Size = new Size(152, 34);
    ((Control) this.buttonLoadSheet).TabIndex = 3;
    ((ControlBase) this.buttonLoadSheet).Text = "Load a Spreadsheet";
    this.buttonLoadSheet.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonLoadSavedMappings).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance27.BackColor = Color.FromArgb(248, 248, 248);
    appearance27.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance27.BackGradientStyle = (GradientStyle) 2;
    appearance27.BorderColor = Color.DarkGray;
    appearance27.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance27.Image"));
    appearance27.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonLoadSavedMappings).Appearance = (AppearanceBase) appearance27;
    ((Control) this.buttonLoadSavedMappings).Location = new Point(170, 550);
    ((Control) this.buttonLoadSavedMappings).Name = "buttonLoadSavedMappings";
    ((Control) this.buttonLoadSavedMappings).Size = new Size(152, 34);
    ((Control) this.buttonLoadSavedMappings).TabIndex = 4;
    ((ControlBase) this.buttonLoadSavedMappings).Text = "Load Saved Mappings";
    this.buttonLoadSavedMappings.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSaveMappings).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance28.BackColor = Color.FromArgb(248, 248, 248);
    appearance28.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance28.BackGradientStyle = (GradientStyle) 2;
    appearance28.BorderColor = Color.DarkGray;
    appearance28.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance28.Image"));
    appearance28.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSaveMappings).Appearance = (AppearanceBase) appearance28;
    ((Control) this.buttonSaveMappings).Location = new Point(328, 550);
    ((Control) this.buttonSaveMappings).Name = "buttonSaveMappings";
    ((Control) this.buttonSaveMappings).Size = new Size(152, 34);
    ((Control) this.buttonSaveMappings).TabIndex = 5;
    ((ControlBase) this.buttonSaveMappings).Text = "Save Mappings";
    this.buttonSaveMappings.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(5, 13);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(49, 13);
    this.Label1.TabIndex = 6;
    this.Label1.Text = "Policy #:";
    ((UltraCombo) this.comboPolicyNumber).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboPolicyNumber).DataSource = (object) this.SpreadsheetColumnsBindingSource1;
    appearance29.BackColor = Color.White;
    appearance29.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboPolicyNumber.DisplayLayout.Appearance = (AppearanceBase) appearance29;
    this.comboPolicyNumber.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Width = 187;
    ultraGridBand3.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn4
    });
    this.comboPolicyNumber.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.comboPolicyNumber.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboPolicyNumber.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance30.BackColor = SystemColors.ActiveBorder;
    appearance30.BackColor2 = SystemColors.ControlDark;
    appearance30.BackGradientStyle = (GradientStyle) 2;
    appearance30.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.comboPolicyNumber.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance30;
    appearance31.ForeColor = SystemColors.GrayText;
    this.comboPolicyNumber.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance31;
    ((SpecialBoxBase) this.comboPolicyNumber.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance32.BackColor = SystemColors.ControlLightLight;
    appearance32.BackColor2 = SystemColors.Control;
    appearance32.BackGradientStyle = (GradientStyle) 3;
    appearance32.ForeColor = SystemColors.GrayText;
    this.comboPolicyNumber.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance32;
    this.comboPolicyNumber.DisplayLayout.MaxColScrollRegions = 1;
    this.comboPolicyNumber.DisplayLayout.MaxRowScrollRegions = 1;
    appearance33.BackColor = SystemColors.Window;
    appearance33.ForeColor = SystemColors.ControlText;
    this.comboPolicyNumber.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance33;
    appearance34.BackColor = SystemColors.Highlight;
    appearance34.ForeColor = SystemColors.HighlightText;
    this.comboPolicyNumber.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance34;
    this.comboPolicyNumber.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboPolicyNumber.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance35.BackColor = SystemColors.Window;
    this.comboPolicyNumber.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance35;
    appearance36.BorderColor = Color.Silver;
    appearance36.TextTrimming = (TextTrimming) 3;
    this.comboPolicyNumber.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance36;
    this.comboPolicyNumber.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboPolicyNumber.DisplayLayout.Override.CellPadding = 0;
    appearance37.BackColor = SystemColors.Control;
    appearance37.BackColor2 = SystemColors.ControlDark;
    appearance37.BackGradientAlignment = (GradientAlignment) 1;
    appearance37.BackGradientStyle = (GradientStyle) 3;
    appearance37.BorderColor = SystemColors.Window;
    this.comboPolicyNumber.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance37;
    ((AppearanceBase) appearance38).TextHAlignAsString = "Left";
    this.comboPolicyNumber.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance38;
    this.comboPolicyNumber.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboPolicyNumber.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance39.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance39.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboPolicyNumber.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance39;
    appearance40.BackColor = SystemColors.Window;
    appearance40.BorderColor = Color.White;
    this.comboPolicyNumber.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance40;
    this.comboPolicyNumber.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboPolicyNumber.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance41.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance41.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance41.ForeColor = Color.Black;
    this.comboPolicyNumber.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance41;
    appearance42.BackColor = SystemColors.ControlLight;
    this.comboPolicyNumber.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance42;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboPolicyNumber.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.comboPolicyNumber.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboPolicyNumber.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboPolicyNumber.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.comboPolicyNumber).DisplayMember = "SpreadsheetColumn";
    ((UltraCombo) this.comboPolicyNumber).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboPolicyNumber).Location = new Point(68, 9);
    ((MGASimpleComboBox) this.comboPolicyNumber).MGAStyle = (MGAStyles) 2;
    ((Control) this.comboPolicyNumber).Name = "comboPolicyNumber";
    ((Control) this.comboPolicyNumber).Size = new Size(206, 21);
    ((Control) this.comboPolicyNumber).TabIndex = 7;
    ((UltraControlBase) this.comboPolicyNumber).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboPolicyNumber).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboPolicyNumber).ValueMember = "SpreadsheetColumn";
    this.IMSColumnsBindingSource.DataMember = "IMSColumns";
    this.IMSColumnsBindingSource.DataSource = (object) this.DsBindingSource;
    this.err.ContainerControl = (ContainerControl) this;
    this.lblWhere.AutoSize = true;
    this.lblWhere.BackColor = Color.Transparent;
    this.lblWhere.Location = new Point(5, 42);
    this.lblWhere.Name = "lblWhere";
    this.lblWhere.Size = new Size(39, 13);
    this.lblWhere.TabIndex = 8;
    this.lblWhere.Text = "Where";
    this.lblFallsAfter.AutoSize = true;
    this.lblFallsAfter.BackColor = Color.Transparent;
    this.lblFallsAfter.Location = new Point(283, 42);
    this.lblFallsAfter.Name = "lblFallsAfter";
    this.lblFallsAfter.Size = new Size(53, 13);
    this.lblFallsAfter.TabIndex = 10;
    this.lblFallsAfter.Text = "falls after";
    appearance43.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dateCriteria).Appearance = (AppearanceBase) appearance43;
    appearance44.AlphaLevel = (short) 14;
    appearance44.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance44.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance44.BackColorAlpha = (Alpha) 2;
    appearance44.BackGradientAlignment = (GradientAlignment) 4;
    appearance44.BackGradientStyle = (GradientStyle) 5;
    appearance44.BorderAlpha = (Alpha) 1;
    appearance44.BorderColor = Color.FromArgb(78, 122, 171);
    appearance44.ForeColor = Color.FromArgb(49, 85, 153);
    appearance44.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dateCriteria).ButtonAppearance = (AppearanceBase) appearance44;
    ((UltraDateTimeEditor) this.dateCriteria).DateTime = new DateTime(2011, 3, 16 /*0x10*/, 0, 0, 0, 0);
    ((Control) this.dateCriteria).Enabled = false;
    ((Control) this.dateCriteria).Location = new Point(341, 38);
    this.dateCriteria.MGAStyle = (MGAStyles) 2;
    ((Control) this.dateCriteria).Name = "dateCriteria";
    ((Control) this.dateCriteria).Size = new Size(94, 20);
    ((Control) this.dateCriteria).TabIndex = 11;
    ((UltraControlBase) this.dateCriteria).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dateCriteria).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dateCriteria).Value = (object) new DateTime(2011, 3, 16 /*0x10*/, 0, 0, 0, 0);
    ((UltraCombo) this.comboDate).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboDate).DataMember = "SpreadsheetDateColumns";
    ((UltraGridBase) this.comboDate).DataSource = (object) this.ds;
    appearance45.BackColor = Color.White;
    appearance45.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboDate.DisplayLayout.Appearance = (AppearanceBase) appearance45;
    this.comboDate.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Width = 187;
    ultraGridBand4.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn5
    });
    this.comboDate.DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    this.comboDate.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboDate.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance46.BackColor = SystemColors.ActiveBorder;
    appearance46.BackColor2 = SystemColors.ControlDark;
    appearance46.BackGradientStyle = (GradientStyle) 2;
    appearance46.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.comboDate.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance46;
    appearance47.ForeColor = SystemColors.GrayText;
    this.comboDate.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance47;
    ((SpecialBoxBase) this.comboDate.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance48.BackColor = SystemColors.ControlLightLight;
    appearance48.BackColor2 = SystemColors.Control;
    appearance48.BackGradientStyle = (GradientStyle) 3;
    appearance48.ForeColor = SystemColors.GrayText;
    this.comboDate.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance48;
    this.comboDate.DisplayLayout.MaxColScrollRegions = 1;
    this.comboDate.DisplayLayout.MaxRowScrollRegions = 1;
    appearance49.BackColor = SystemColors.Window;
    appearance49.ForeColor = SystemColors.ControlText;
    this.comboDate.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance49;
    appearance50.BackColor = SystemColors.Highlight;
    appearance50.ForeColor = SystemColors.HighlightText;
    this.comboDate.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance50;
    this.comboDate.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboDate.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance51.BackColor = SystemColors.Window;
    this.comboDate.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance51;
    appearance52.BorderColor = Color.Silver;
    appearance52.TextTrimming = (TextTrimming) 3;
    this.comboDate.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance52;
    this.comboDate.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboDate.DisplayLayout.Override.CellPadding = 0;
    appearance53.BackColor = SystemColors.Control;
    appearance53.BackColor2 = SystemColors.ControlDark;
    appearance53.BackGradientAlignment = (GradientAlignment) 1;
    appearance53.BackGradientStyle = (GradientStyle) 3;
    appearance53.BorderColor = SystemColors.Window;
    this.comboDate.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance53;
    ((AppearanceBase) appearance54).TextHAlignAsString = "Left";
    this.comboDate.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance54;
    this.comboDate.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboDate.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance55.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance55.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboDate.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance55;
    appearance56.BackColor = SystemColors.Window;
    appearance56.BorderColor = Color.White;
    this.comboDate.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance56;
    this.comboDate.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboDate.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance57.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance57.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance57.ForeColor = Color.Black;
    this.comboDate.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance57;
    appearance58.BackColor = SystemColors.ControlLight;
    this.comboDate.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance58;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboDate.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.comboDate.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboDate.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboDate.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.comboDate).DisplayMember = "SpreadsheetColumn";
    ((UltraCombo) this.comboDate).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboDate).Location = new Point(68, 38);
    ((MGASimpleComboBox) this.comboDate).MGAStyle = (MGAStyles) 2;
    ((Control) this.comboDate).Name = "comboDate";
    ((Control) this.comboDate).Size = new Size(206, 21);
    ((Control) this.comboDate).TabIndex = 9;
    ((UltraControlBase) this.comboDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboDate).ValueMember = "SpreadsheetColumn";
    appearance59.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtpValuation).Appearance = (AppearanceBase) appearance59;
    appearance60.AlphaLevel = (short) 14;
    appearance60.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance60.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance60.BackColorAlpha = (Alpha) 2;
    appearance60.BackGradientAlignment = (GradientAlignment) 4;
    appearance60.BackGradientStyle = (GradientStyle) 5;
    appearance60.BorderAlpha = (Alpha) 1;
    appearance60.BorderColor = Color.FromArgb(78, 122, 171);
    appearance60.ForeColor = Color.FromArgb(49, 85, 153);
    appearance60.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtpValuation).ButtonAppearance = (AppearanceBase) appearance60;
    ((UltraDateTimeEditor) this.dtpValuation).DateTime = new DateTime(1753, 1, 1, 0, 0, 0, 0);
    ((Control) this.dtpValuation).Location = new Point(341, 9);
    this.dtpValuation.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtpValuation).Name = "dtpValuation";
    ((Control) this.dtpValuation).Size = new Size(94, 20);
    ((Control) this.dtpValuation).TabIndex = 12;
    ((UltraControlBase) this.dtpValuation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtpValuation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtpValuation).Value = (object) null;
    this.lblValuationDate.AutoSize = true;
    this.lblValuationDate.BackColor = Color.Transparent;
    this.lblValuationDate.Location = new Point(280, 13);
    this.lblValuationDate.Name = "lblValuationDate";
    this.lblValuationDate.Size = new Size(55, 13);
    this.lblValuationDate.TabIndex = 13;
    this.lblValuationDate.Text = "Valuation:";
    ((UltraCombo) this.comboControlNo).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboControlNo).DataMember = "SpreadsheetColumns";
    ((UltraGridBase) this.comboControlNo).DataSource = (object) this.ds;
    appearance61.BackColor = Color.White;
    appearance61.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboControlNo.DisplayLayout.Appearance = (AppearanceBase) appearance61;
    this.comboControlNo.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.ColHeadersVisible = false;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 0;
    ultraGridColumn6.Width = 187;
    ultraGridBand5.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn6
    });
    this.comboControlNo.DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    this.comboControlNo.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboControlNo.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance62.BackColor = SystemColors.ActiveBorder;
    appearance62.BackColor2 = SystemColors.ControlDark;
    appearance62.BackGradientStyle = (GradientStyle) 2;
    appearance62.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.comboControlNo.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance62;
    appearance63.ForeColor = SystemColors.GrayText;
    this.comboControlNo.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance63;
    ((SpecialBoxBase) this.comboControlNo.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance64.BackColor = SystemColors.ControlLightLight;
    appearance64.BackColor2 = SystemColors.Control;
    appearance64.BackGradientStyle = (GradientStyle) 3;
    appearance64.ForeColor = SystemColors.GrayText;
    this.comboControlNo.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance64;
    this.comboControlNo.DisplayLayout.MaxColScrollRegions = 1;
    this.comboControlNo.DisplayLayout.MaxRowScrollRegions = 1;
    appearance65.BackColor = SystemColors.Window;
    appearance65.ForeColor = SystemColors.ControlText;
    this.comboControlNo.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance65;
    appearance66.BackColor = SystemColors.Highlight;
    appearance66.ForeColor = SystemColors.HighlightText;
    this.comboControlNo.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance66;
    this.comboControlNo.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboControlNo.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance67.BackColor = SystemColors.Window;
    this.comboControlNo.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance67;
    appearance68.BorderColor = Color.Silver;
    appearance68.TextTrimming = (TextTrimming) 3;
    this.comboControlNo.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance68;
    this.comboControlNo.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboControlNo.DisplayLayout.Override.CellPadding = 0;
    appearance69.BackColor = SystemColors.Control;
    appearance69.BackColor2 = SystemColors.ControlDark;
    appearance69.BackGradientAlignment = (GradientAlignment) 1;
    appearance69.BackGradientStyle = (GradientStyle) 3;
    appearance69.BorderColor = SystemColors.Window;
    this.comboControlNo.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance69;
    ((AppearanceBase) appearance70).TextHAlignAsString = "Left";
    this.comboControlNo.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance70;
    this.comboControlNo.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboControlNo.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance71.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance71.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboControlNo.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance71;
    appearance72.BackColor = SystemColors.Window;
    appearance72.BorderColor = Color.White;
    this.comboControlNo.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance72;
    this.comboControlNo.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboControlNo.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance73.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance73.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance73.ForeColor = Color.Black;
    this.comboControlNo.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance73;
    appearance74.BackColor = SystemColors.ControlLight;
    this.comboControlNo.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance74;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboControlNo.DisplayLayout.ScrollBarLook = scrollBarLook3;
    this.comboControlNo.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboControlNo.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboControlNo.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.comboControlNo).DisplayMember = "SpreadsheetColumn";
    ((UltraCombo) this.comboControlNo).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboControlNo).Location = new Point(68, 67);
    ((MGASimpleComboBox) this.comboControlNo).MGAStyle = (MGAStyles) 2;
    ((Control) this.comboControlNo).Name = "comboControlNo";
    ((Control) this.comboControlNo).Size = new Size(206, 21);
    ((Control) this.comboControlNo).TabIndex = 14;
    ((UltraControlBase) this.comboControlNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboControlNo).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboControlNo).ValueMember = "SpreadsheetColumn";
    this.lblControlNo.AutoSize = true;
    this.lblControlNo.BackColor = Color.Transparent;
    this.lblControlNo.Location = new Point(5, 71);
    this.lblControlNo.Name = "lblControlNo";
    this.lblControlNo.Size = new Size(57, 13);
    this.lblControlNo.TabIndex = 15;
    this.lblControlNo.Text = "Control #:";
    ((ContainerControl) this).AutoScaleDimensions = new SizeF(6f, 13f);
    ((ContainerControl) this).AutoScaleMode = AutoScaleMode.Font;
    ((Form) this).BackColor = Color.White;
    ((Form) this).ClientSize = new Size(649, 596);
    ((Control) this).Controls.Add((Control) this.lblControlNo);
    ((Control) this).Controls.Add((Control) this.comboControlNo);
    ((Control) this).Controls.Add((Control) this.lblValuationDate);
    ((Control) this).Controls.Add((Control) this.dtpValuation);
    ((Control) this).Controls.Add((Control) this.dateCriteria);
    ((Control) this).Controls.Add((Control) this.lblFallsAfter);
    ((Control) this).Controls.Add((Control) this.comboDate);
    ((Control) this).Controls.Add((Control) this.lblWhere);
    ((Control) this).Controls.Add((Control) this.comboPolicyNumber);
    ((Control) this).Controls.Add((Control) this.Label1);
    ((Control) this).Controls.Add((Control) this.buttonSaveMappings);
    ((Control) this).Controls.Add((Control) this.buttonLoadSavedMappings);
    ((Control) this).Controls.Add((Control) this.buttonLoadSheet);
    ((Control) this).Controls.Add((Control) this.buttonImport);
    ((Control) this).Controls.Add((Control) this.ddSpreadsheetCols);
    ((Control) this).Controls.Add((Control) this.gridMappings);
    ((Control) this).Font = new Font("Tahoma", 8.25f);
    ((Control) this).ForeColor = Color.Black;
    ((Control) this).Name = nameof (ClaimsExcelImport);
    ((Form) this).StartPosition = FormStartPosition.CenterScreen;
    ((Form) this).Text = "IMS Claims Import Utility";
    ((ISupportInitialize) this.gridMappings).EndInit();
    ((ISupportInitialize) this.ImportMappingsBindingSource).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddSpreadsheetCols).EndInit();
    ((ISupportInitialize) this.SpreadsheetColumnsBindingSource1).EndInit();
    ((ISupportInitialize) this.DsBindingSource).EndInit();
    ((ISupportInitialize) this.SpreadsheetColumnsBindingSource).EndInit();
    ((ISupportInitialize) this.buttonImport).EndInit();
    ((ISupportInitialize) this.buttonLoadSheet).EndInit();
    ((ISupportInitialize) this.buttonLoadSavedMappings).EndInit();
    ((ISupportInitialize) this.buttonSaveMappings).EndInit();
    ((ISupportInitialize) this.comboPolicyNumber).EndInit();
    ((ISupportInitialize) this.IMSColumnsBindingSource).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.dateCriteria).EndInit();
    ((ISupportInitialize) this.comboDate).EndInit();
    ((ISupportInitialize) this.dtpValuation).EndInit();
    ((ISupportInitialize) this.comboControlNo).EndInit();
    ((Control) this).ResumeLayout(false);
    ((Control) this).PerformLayout();
  }

  [field: AccessedThroughProperty("gridMappings")]
  protected virtual UltraGrid gridMappings { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton buttonLoadSheet
  {
    get => this._buttonLoadSheet;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonLoadSheet_Click);
      MGAButton buttonLoadSheet1 = this._buttonLoadSheet;
      if (buttonLoadSheet1 != null)
        ((Control) buttonLoadSheet1).Click -= eventHandler;
      this._buttonLoadSheet = value;
      MGAButton buttonLoadSheet2 = this._buttonLoadSheet;
      if (buttonLoadSheet2 == null)
        return;
      ((Control) buttonLoadSheet2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("comboPolicyNumber")]
  protected virtual MGAComboBox comboPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAComboBox comboDate
  {
    get => this._comboDate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.comboDate_KeyDown);
      EventHandler eventHandler = new EventHandler(this.comboDate_ValueChanged);
      MGAComboBox comboDate1 = this._comboDate;
      if (comboDate1 != null)
      {
        ((Control) comboDate1).KeyDown -= keyEventHandler;
        ((UltraCombo) comboDate1).ValueChanged -= eventHandler;
      }
      this._comboDate = value;
      MGAComboBox comboDate2 = this._comboDate;
      if (comboDate2 == null)
        return;
      ((Control) comboDate2).KeyDown += keyEventHandler;
      ((UltraCombo) comboDate2).ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("dateCriteria")]
  protected virtual MGADateTimePicker dateCriteria { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsExcelImport ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton buttonImport
  {
    get => this._buttonImport;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonImport_Click);
      MGAButton buttonImport1 = this._buttonImport;
      if (buttonImport1 != null)
        ((Control) buttonImport1).Click -= eventHandler;
      this._buttonImport = value;
      MGAButton buttonImport2 = this._buttonImport;
      if (buttonImport2 == null)
        return;
      ((Control) buttonImport2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblWhere")]
  protected virtual Label lblWhere { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblFallsAfter")]
  protected virtual Label lblFallsAfter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraDropDown ddSpreadsheetCols
  {
    get => this._ddSpreadsheetCols;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.ddSpreadsheetCols_InitializeLayout);
      UltraDropDown ddSpreadsheetCols1 = this._ddSpreadsheetCols;
      if (ddSpreadsheetCols1 != null)
        ddSpreadsheetCols1.InitializeLayout -= layoutEventHandler;
      this._ddSpreadsheetCols = value;
      UltraDropDown ddSpreadsheetCols2 = this._ddSpreadsheetCols;
      if (ddSpreadsheetCols2 == null)
        return;
      ddSpreadsheetCols2.InitializeLayout += layoutEventHandler;
    }
  }

  [field: AccessedThroughProperty("DsBindingSource")]
  protected virtual BindingSource DsBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SpreadsheetColumnsBindingSource")]
  protected virtual BindingSource SpreadsheetColumnsBindingSource { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton buttonLoadSavedMappings
  {
    get => this._buttonLoadSavedMappings;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonLoadSavedMappings_Click);
      MGAButton loadSavedMappings1 = this._buttonLoadSavedMappings;
      if (loadSavedMappings1 != null)
        ((Control) loadSavedMappings1).Click -= eventHandler;
      this._buttonLoadSavedMappings = value;
      MGAButton loadSavedMappings2 = this._buttonLoadSavedMappings;
      if (loadSavedMappings2 == null)
        return;
      ((Control) loadSavedMappings2).Click += eventHandler;
    }
  }

  protected virtual MGAButton buttonSaveMappings
  {
    get => this._buttonSaveMappings;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonSaveMappings_Click);
      MGAButton buttonSaveMappings1 = this._buttonSaveMappings;
      if (buttonSaveMappings1 != null)
        ((Control) buttonSaveMappings1).Click -= eventHandler;
      this._buttonSaveMappings = value;
      MGAButton buttonSaveMappings2 = this._buttonSaveMappings;
      if (buttonSaveMappings2 == null)
        return;
      ((Control) buttonSaveMappings2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lblValuationDate")]
  protected virtual Label lblValuationDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtpValuation")]
  protected virtual MGADateTimePicker dtpValuation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblControlNo")]
  protected virtual Label lblControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboControlNo")]
  protected virtual MGAComboBox comboControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected Workbook Workbook
  {
    get => this._workbook;
    set => this._workbook = value;
  }

  protected Worksheet SelectedWorksheet
  {
    get => this._SelectedWorksheet;
    set => this._SelectedWorksheet = value;
  }

  public string MappingsName
  {
    get => this._mappingsName;
    set => this._mappingsName = value;
  }

  public DataTable ddDataSource
  {
    get => this._ddDataSource;
    set => this._ddDataSource = value;
  }

  public bool ValuationOnSpreadsheet
  {
    get
    {
      bool valuationOnSpreadsheet;
      try
      {
        foreach (dsExcelImport.ImportMappingsRow row in this.ds.ImportMappings.Rows)
        {
          if (row.IMSColumn.Equals("ValueDate") && !row.IsSpreadsheetColumnNull())
          {
            valuationOnSpreadsheet = true;
            goto label_8;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      valuationOnSpreadsheet = false;
label_8:
      return valuationOnSpreadsheet;
    }
  }

  public string ControlNumberSelectedString
  {
    get => this.__controlNumberSelectedString;
    set => this.__controlNumberSelectedString = value;
  }

  public ClaimsExcelImport()
  {
    this._currentFileName = string.Empty;
    this._dateReceivedRequired = true;
    this._dateReportedRequired = true;
    this._lossTypeRequired = true;
    this.InitializeComponent();
    ((Control) this.gridMappings).Enabled = false;
    this._policyNumberName = new Guid("{1E05828A-08EF-4245-B5A7-E10B80F28AE1}").ToString();
    this._controlNumberName = new Guid("{2F58E107-6AFA-4728-850E-32C481B2DB93}").ToString();
    if (SystemSettings.GetSetting<bool>("ClaimsImport.IgnoreDateReceivedRequirement"))
      this._dateReceivedRequired = false;
    if (SystemSettings.GetSetting<bool>("ClaimsImport.IgnoreDateReportedRequirement"))
      this._dateReportedRequired = false;
    if (!SystemSettings.GetSetting<bool>("ClaimsImport.IgnoreLossTypeRequirement"))
      return;
    this._lossTypeRequired = false;
  }

  private void LoadDatabaseColumns()
  {
    this.ds.SpreadsheetColumns.AddSpreadsheetColumnsRow(string.Empty);
    this.ds.IMSColumns.Clear();
    this.OnLoadDatabaseColumns();
  }

  protected virtual void OnLoadDatabaseColumns()
  {
    List<string> excludeColumns = new List<string>();
    List<string> stringList = excludeColumns;
    stringList.Add("ClaimID");
    stringList.Add("ControlNo");
    stringList.Add("ImportedID");
    stringList.Add("ReadOnly");
    stringList.Add("CheckIssued");
    stringList.Add("PaymentID");
    this.AddIMSColumns("tblClaimInformation", excludeColumns);
    this.AddIMSColumns("tblClaimResPaymentActivity", excludeColumns);
  }

  protected void AddIMSColumns(string tableName, List<string> excludeColumns)
  {
    List<string> stringList1 = new List<string>();
    List<string> stringList2 = stringList1;
    stringList2.Add("ClaimNo");
    if (this._dateReceivedRequired)
      stringList2.Add("DateReceived");
    if (this._dateReportedRequired)
      stringList2.Add("DateReported");
    stringList2.Add("LossDate");
    if (this._lossTypeRequired)
      stringList2.Add("LossType");
    stringList2.Add("Status");
    DataTable dataTable = new DataTable();
    using (SqlConnection selectConnection = new SqlConnection(DefaultDatabase.ConnectionString))
    {
      using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM " + tableName, selectConnection))
        sqlDataAdapter.FillSchema(dataTable, SchemaType.Source);
    }
    try
    {
      foreach (DataColumn column in (InternalDataCollectionBase) dataTable.Columns)
      {
        if (!excludeColumns.Contains(column.ColumnName) && this.ds.ImportMappings.FindByIMSColumn(column.ColumnName) == null)
        {
          this.ds.ImportMappings.AddImportMappingsRow(column.ColumnName, string.Empty);
          this.ds.IMSColumns.AddIMSColumnsRow(column.ColumnName, tableName);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.AddClientTableColumns(this.ds, tableName);
    foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
    {
      if (stringList1.Contains(row.Cells["IMSColumn"].Value.ToString()))
        row.Appearance.BackColor = Color.LightGoldenrodYellow;
    }
  }

  protected virtual void AddClientTableColumns(dsExcelImport ds, string tableName)
  {
  }

  protected virtual string MappingStore => "tblClaimSavedSpreadsheetMappings";

  protected virtual void buttonLoadSavedMappings_Click(object sender, EventArgs e)
  {
    using (LoadSavedMapping loadSavedMapping = new LoadSavedMapping(this.MappingStore))
    {
      loadSavedMapping.ShowInTaskbar = false;
      int num1 = (int) loadSavedMapping.ShowDialog();
      if (!loadSavedMapping.Saved)
        return;
      try
      {
        foreach (dsExcelImport.ImportMappingsRow importMapping in (TypedTableBase<dsExcelImport.ImportMappingsRow>) this.ds.ImportMappings)
          importMapping.SetSpreadsheetColumnNull();
      }
      finally
      {
        IEnumerator<dsExcelImport.ImportMappingsRow> enumerator;
        enumerator?.Dispose();
      }
      try
      {
        foreach (DataRow row in loadSavedMapping.Data.Rows)
        {
          dsExcelImport.ImportMappingsRow byImsColumn = this.ds.ImportMappings.FindByIMSColumn(row["IMSColumn"].ToString());
          if (this.ds.SpreadsheetColumns.Select($"SpreadsheetColumn='{row["SpreadsheetColumn"].ToString().Replace("'", "''")}'").Length == 0)
          {
            if (row["SpreadsheetColumn"].ToString().Contains(this._policyNumberName))
              ((UltraCombo) this.comboPolicyNumber).Value = RuntimeHelpers.GetObjectValue(row["IMSColumn"]);
            else if (row["SpreadsheetColumn"].ToString().Contains(this._controlNumberName))
            {
              ((UltraCombo) this.comboControlNo).Value = RuntimeHelpers.GetObjectValue(row["IMSColumn"]);
            }
            else
            {
              int num2 = (int) MessageBox.Show("The following saved mapping could not be found in the spreadsheet:\n\n" + row["SpreadsheetColumn"].ToString(), "Invalid Mapping", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
          }
          else if (byImsColumn != null)
            byImsColumn.SpreadsheetColumn = row["SpreadsheetColumn"].ToString();
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
  }

  protected virtual void buttonSaveMappings_Click(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.gridMappings).Rows.Count == 0)
      return;
    this._mappingsName = Interaction.InputBox("Please enter a name for these mappings:", "Mappings Name", Path.GetFileNameWithoutExtension(this._currentFileName));
    if (string.IsNullOrEmpty(this._mappingsName))
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"DELETE FROM {this.MappingStore} WHERE MappingName=@MN", new object[2]
    {
      (object) "@MN",
      (object) this._mappingsName
    });
    string str = string.Empty;
    try
    {
      foreach (dsExcelImport.ImportMappingsRow importMapping in (TypedTableBase<dsExcelImport.ImportMappingsRow>) this.ds.ImportMappings)
      {
        if (!importMapping.IsSpreadsheetColumnNull() && !string.IsNullOrEmpty(importMapping.SpreadsheetColumn) && this.ds.IMSColumns.FindByIMSColumn(importMapping.IMSColumn) != null)
        {
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"INSERT INTO {this.MappingStore}(MappingName, IMSTable, IMSColumn, SpreadsheetColumn)VALUES(@MN, @IT, @IC, @SC)", new object[8]
          {
            (object) "@MN",
            (object) this._mappingsName,
            (object) "@IT",
            (object) this.ds.IMSColumns.FindByIMSColumn(importMapping.IMSColumn).IMSTable,
            (object) "@IC",
            (object) importMapping.IMSColumn,
            (object) "@SC",
            (object) importMapping.SpreadsheetColumn
          });
          str = this.ds.IMSColumns.FindByIMSColumn(importMapping.IMSColumn).IMSTable;
        }
      }
    }
    finally
    {
      IEnumerator<dsExcelImport.ImportMappingsRow> enumerator;
      enumerator?.Dispose();
    }
    if (((UltraCombo) this.comboPolicyNumber).Text.Length > 0)
      DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"INSERT INTO {this.MappingStore}(MappingName, IMSTable, IMSColumn, SpreadsheetColumn)VALUES(@MN, @IT, @IC, @SC)", new object[8]
      {
        (object) "@MN",
        (object) this._mappingsName,
        (object) "@IT",
        (object) str,
        (object) "@IC",
        (object) ((UltraCombo) this.comboPolicyNumber).Value.ToString(),
        (object) "@SC",
        (object) (((UltraCombo) this.comboPolicyNumber).Value.ToString() + this._policyNumberName)
      });
    if (((UltraCombo) this.comboControlNo).Text.Length <= 0)
      return;
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, $"INSERT INTO {this.MappingStore}(MappingName, IMSTable, IMSColumn, SpreadsheetColumn)VALUES(@MN, @IT, @IC, @SC)", new object[8]
    {
      (object) "@MN",
      (object) this._mappingsName,
      (object) "@IT",
      (object) str,
      (object) "@IC",
      (object) ((UltraCombo) this.comboControlNo).Value.ToString(),
      (object) "@SC",
      (object) (((UltraCombo) this.comboControlNo).Value.ToString() + this._controlNumberName)
    });
  }

  protected virtual void OnImport(string policyNumber)
  {
    ImportClaims importClaims = (ImportClaims) null;
    try
    {
      if (((Control) this.comboDate).Enabled && ((UltraCombo) this.comboDate).Value != null)
        importClaims = (ImportClaims) ObjectFactory.Instance.CreateFormEX(typeof (ImportClaims), new object[5]
        {
          (object) this.ds,
          (object) policyNumber,
          (object) this._SelectedWorksheet,
          (object) ((UltraCombo) this.comboDate).Value.ToString(),
          (object) (DateTime) ((UltraDateTimeEditor) this.dateCriteria).Value
        });
      else
        importClaims = (ImportClaims) ObjectFactory.Instance.CreateFormEX(typeof (ImportClaims), new object[3]
        {
          (object) this.ds,
          (object) policyNumber,
          (object) this._SelectedWorksheet
        });
      importClaims.ValuationDate = RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtpValuation).Value);
      importClaims.HasValuationOnSpreadsheet = this.ValuationOnSpreadsheet;
      importClaims.ControlNumberSelectedColumnName = this.ControlNumberSelectedString;
      importClaims.ShowInTaskbar = false;
      int num = (int) importClaims.ShowDialog();
    }
    finally
    {
      importClaims?.Dispose();
    }
  }

  private void buttonImport_Click(object sender, EventArgs e)
  {
    this.ControlNumberSelectedString = string.Empty;
    this.OnImportButtonClicked();
  }

  private bool RequiredColumn(string imsColumnName)
  {
    return (this._dateReceivedRequired || !imsColumnName.Equals("DateReceived")) && (this._dateReportedRequired || !imsColumnName.Equals("DateReported")) && (this._lossTypeRequired || !imsColumnName.Equals("LossType"));
  }

  protected virtual void OnImportButtonClicked()
  {
    this.err.SetError((Control) this.comboPolicyNumber, string.Empty);
    this.err.SetError((Control) this.dtpValuation, string.Empty);
    this.err.SetError((Control) this.comboControlNo, string.Empty);
    bool flag1 = false;
    bool flag2 = false;
    if (((UltraCombo) this.comboPolicyNumber).Value == null || string.IsNullOrEmpty(((UltraCombo) this.comboPolicyNumber).Value.ToString()))
      flag1 = true;
    if (((UltraCombo) this.comboControlNo).Value == null || string.IsNullOrEmpty(((UltraCombo) this.comboControlNo).Value.ToString()))
      flag2 = true;
    if (flag1 && flag2)
    {
      this.err.SetError((Control) this.comboPolicyNumber, "Select a mapping.  Both Polcy # and Control # cannot be empty.");
      this.err.SetError((Control) this.comboControlNo, "Select a mapping.  Both Polcy # and Control # cannot be empty.");
    }
    else if (!this.ValidValuationDate())
    {
      this.err.SetError((Control) this.dtpValuation, "Required Field. Please select a date");
    }
    else
    {
      foreach (UltraGridRow row in ((UltraGridBase) this.gridMappings).Rows)
      {
        if (row.Appearance.BackColor == Color.LightGoldenrodYellow && this.RequiredColumn(row.Cells["IMSColumn"].Value.ToString()) && (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["SpreadsheetColumn"].Value)) || row.Cells["SpreadsheetColumn"].Value.ToString().Replace(" ", string.Empty).Length == 0))
        {
          int num = (int) MessageBox.Show("Please fill in all the required fields before importing.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          return;
        }
      }
      string empty = string.Empty;
      if (!flag1)
        empty = (string) ((UltraCombo) this.comboPolicyNumber).Value;
      if (!flag2)
        this.ControlNumberSelectedString = (string) ((UltraCombo) this.comboControlNo).Value;
      this.OnImport(empty);
    }
  }

  private bool ValidValuationDate()
  {
    return !SystemSettings.KeyExists("ClaimsImportValuationDateRequired") || !SystemSettings.GetBoolSetting("ClaimsImportValuationDateRequired") || this.ValuationOnSpreadsheet || !(((UltraDateTimeEditor) this.dtpValuation).Value == DBNull.Value | ((UltraDateTimeEditor) this.dtpValuation).Value == null);
  }

  private void comboDate_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Delete)
      return;
    ((UltraCombo) this.comboDate).Value = (object) null;
  }

  private void comboDate_ValueChanged(object sender, EventArgs e)
  {
    ((Control) this.dateCriteria).Enabled = ((UltraCombo) this.comboDate).Value != null;
  }

  private void buttonLoadSheet_Click(object sender, EventArgs e)
  {
    ((Control) this).Cursor = Cursors.WaitCursor;
    try
    {
      using (OpenFileDialog openFileDialog = new OpenFileDialog())
      {
        openFileDialog.Filter = "Excel 1995-2003 Files (*.xls)|*.xls|Excel 2007-2010 Files(*.xlsx)|*.xlsx";
        if (openFileDialog.ShowDialog() != DialogResult.OK)
          return;
        this.ds.SpreadsheetColumns.Clear();
        this.ds.ImportMappings.Clear();
        if (((UltraGridBase) this.gridMappings).Rows.Count == 0)
          this.LoadDatabaseColumns();
        this._currentFileName = openFileDialog.FileName;
        try
        {
          this._workbook = new Workbook(this._currentFileName);
        }
        catch (IOException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          int num = (int) MessageBox.Show("The IMS was unable to open this file.\n\nPlease ensure that it is not currently open in Excel.", "Unable to Open File", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
          return;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          int num = (int) MessageBox.Show(ex.Message, "Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Hand);
          ProjectData.ClearProjectError();
          return;
        }
        Worksheet worksheet = (Worksheet) null;
        if (this._workbook.Worksheets.Count > 1)
        {
          using (SelectWorksheet selectWorksheet = new SelectWorksheet(this._workbook))
          {
            selectWorksheet.ShowInTaskbar = false;
            if (selectWorksheet.ShowDialog() == DialogResult.OK)
              worksheet = selectWorksheet.SelectedSheet;
          }
        }
        else
        {
          if (this._workbook.Worksheets.Count != 1)
            throw new InvalidOperationException("Workbook contains no worksheets!");
          worksheet = this._workbook.Worksheets[0];
        }
        this._SelectedWorksheet = worksheet;
        int maxColumn = worksheet.Cells.MaxColumn;
        for (int index = 0; index <= maxColumn; ++index)
        {
          if (worksheet.Cells[0, index].Value != null)
          {
            this.ds.SpreadsheetColumns.AddSpreadsheetColumnsRow(worksheet.Cells[0, index].Value.ToString());
            if (Information.IsDate(RuntimeHelpers.GetObjectValue(worksheet.Cells[1, index].Value)))
              this.ds.SpreadsheetDateColumns.AddSpreadsheetDateColumnsRow(worksheet.Cells[0, index].Value.ToString());
          }
        }
        this.LoadDropDownDisplayValues();
        ((Control) this.gridMappings).Enabled = true;
      }
    }
    finally
    {
      ((Control) this).Cursor = Cursors.Default;
    }
  }

  private void LoadDropDownDisplayValues()
  {
    DataTable dataTable = new DataTable("DropDownDataSource");
    dataTable.Columns.Add("SpreadsheetColumn", typeof (string));
    dataTable.Columns.Add("SpreadsheetColumns", typeof (string));
    BindingSource dataSource = (BindingSource) ((UltraGridBase) this.ddSpreadsheetCols).DataSource;
    string[,] strArray = new string[2, dataSource.Count - 1 + 1];
    int num = 0;
    ((UltraDropDownBase) this.ddSpreadsheetCols).DisplayMember = (string) null;
    ((UltraDropDownBase) this.ddSpreadsheetCols).ValueMember = (string) null;
    try
    {
      foreach (DataRowView dataRowView in (IEnumerable) dataSource.List)
      {
        string str = dataRowView["SpreadsheetColumn"].ToString();
        if (str.Contains("\r"))
          str = str.Replace("\r", string.Empty).Replace("\n", Strings.Space(1));
        dataTable.Rows.Add((object) dataRowView["SpreadsheetColumn"].ToString(), (object) str);
        ((UltraDropDownBase) this.ddSpreadsheetCols).ValueMember = dataRowView["SpreadsheetColumn"].ToString();
        ((UltraDropDownBase) this.ddSpreadsheetCols).DisplayMember = str;
        ++num;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this._ddDataSource = dataTable;
    ((UltraGridBase) this.ddSpreadsheetCols).DataSource = (object) this._ddDataSource;
    ((UltraDropDownBase) this.ddSpreadsheetCols).ValueMember = "SpreadsheetColumn";
    ((UltraDropDownBase) this.ddSpreadsheetCols).DisplayMember = "SpreadsheetColumns";
  }

  private void ddSpreadsheetCols_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    e.Layout.Bands[0].Columns[0].Hidden = true;
  }
}
