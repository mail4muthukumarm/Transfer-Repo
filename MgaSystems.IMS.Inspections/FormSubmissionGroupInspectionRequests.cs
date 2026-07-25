// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Inspections.FormSubmissionGroupInspectionRequests
// Assembly: MgaSystems.IMS.Inspections, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 07B8D1F3-634C-445B-ABFB-027DE209A43D
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Inspections.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Inspections;

[DesignerGenerated]
public class FormSubmissionGroupInspectionRequests : Form
{
  private IContainer components;
  private Guid _submissionGroupGuid;
  private Guid _currentUserGuid;
  private bool _isFormLoading;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSubmissionGroupInspectionRequests));
    ValueListItem valueListItem1 = new ValueListItem();
    ValueListItem valueListItem2 = new ValueListItem();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("dtProgramCodes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProgramCode");
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
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("dtInspectionTypes", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("InspectType");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Code");
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance31 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("InspectionCompanies", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("PayeeID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("PayeeName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("ClientCode");
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
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance45 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("dt", -1);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("InsuredPolicyName", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("QuoteStatus");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Rater");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("InspectionType");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("dt_Loc");
    UltraGridBand ultraGridBand5 = new UltraGridBand("dt_Loc", 0);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("LocationID");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Location");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("InspectionContact");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("InspectionContactPhone");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Comments");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("Rush");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Address");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("Inspect");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("ClassCode");
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    ValueListItem valueListItem3 = new ValueListItem();
    ValueListItem valueListItem4 = new ValueListItem();
    this.btnRequestInspections = new MGAButton();
    this.panelSearch = new UltraGroupBox();
    this.spinner = new PictureBox();
    this.labelSearchText = new Label();
    this.lnkAll = new LinkLabel();
    this.lnkNone = new LinkLabel();
    this.Label2 = new Label();
    this.err = new ErrorProvider(this.components);
    this.GroupBox1 = new GroupBox();
    this.optionInspMethod = new UltraOptionSet();
    this.Label1 = new Label();
    this.Label3 = new Label();
    this.cboProgramCode = new MGAComboBox();
    this.ds = new dsSubReq();
    this.cboDivision = new MGAComboBox();
    this.cboInspectionCompanies = new MGAComboBox();
    this.ug = new UltraGrid();
    this.GroupBox2 = new GroupBox();
    this.optionInspectionCompany = new UltraOptionSet();
    this.lnkClear = new LinkLabel();
    Label label = new Label();
    ((ISupportInitialize) this.btnRequestInspections).BeginInit();
    ((ISupportInitialize) this.panelSearch).BeginInit();
    ((Control) this.panelSearch).SuspendLayout();
    ((ISupportInitialize) this.spinner).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.GroupBox1.SuspendLayout();
    ((ISupportInitialize) this.optionInspMethod).BeginInit();
    ((ISupportInitialize) this.cboProgramCode).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cboDivision).BeginInit();
    ((ISupportInitialize) this.cboInspectionCompanies).BeginInit();
    ((ISupportInitialize) this.ug).BeginInit();
    this.GroupBox2.SuspendLayout();
    ((ISupportInitialize) this.optionInspectionCompany).BeginInit();
    this.SuspendLayout();
    label.AutoSize = true;
    label.Font = new Font("Tahoma", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    label.Location = new Point(128 /*0x80*/, 16 /*0x10*/);
    label.Name = "Label27";
    label.Size = new Size(253, 19);
    label.TabIndex = 1;
    label.Text = "Inspection Request ... Please Wait.";
    ((Control) this.btnRequestInspections).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRequestInspections).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnRequestInspections).Location = new Point(890, 642);
    ((Control) this.btnRequestInspections).Name = "btnRequestInspections";
    ((Control) this.btnRequestInspections).Size = new Size(144 /*0x90*/, 30);
    ((Control) this.btnRequestInspections).TabIndex = 6;
    ((ControlBase) this.btnRequestInspections).Text = "Request Inspections";
    this.btnRequestInspections.UseOSThemes = (DefaultableBoolean) 2;
    this.panelSearch.BackColorInternal = Color.White;
    appearance2.BorderColor = Color.Gray;
    this.panelSearch.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.panelSearch).Controls.Add((Control) this.spinner);
    ((Control) this.panelSearch).Controls.Add((Control) this.labelSearchText);
    ((Control) this.panelSearch).Controls.Add((Control) label);
    ((Control) this.panelSearch).ForeColor = Color.Black;
    ((Control) this.panelSearch).Location = new Point(201, 182);
    ((Control) this.panelSearch).Name = "panelSearch";
    ((Control) this.panelSearch).Size = new Size(501, 148);
    ((Control) this.panelSearch).TabIndex = 117;
    ((Control) this.panelSearch).Visible = false;
    this.spinner.Image = (Image) componentResourceManager.GetObject("spinner.Image");
    this.spinner.Location = new Point(222, 87);
    this.spinner.Name = "spinner";
    this.spinner.Size = new Size(60, 44);
    this.spinner.SizeMode = PictureBoxSizeMode.Zoom;
    this.spinner.TabIndex = 116;
    this.spinner.TabStop = false;
    this.labelSearchText.Font = new Font("Tahoma", 8f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.labelSearchText.Location = new Point(6, 44);
    this.labelSearchText.Name = "labelSearchText";
    this.labelSearchText.Size = new Size(489, 40);
    this.labelSearchText.TabIndex = 3;
    this.labelSearchText.Text = "Gathering policies for request ...";
    this.labelSearchText.TextAlign = ContentAlignment.MiddleCenter;
    this.lnkAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAll.AutoSize = true;
    this.lnkAll.Location = new Point(12, 638);
    this.lnkAll.Name = "lnkAll";
    this.lnkAll.Size = new Size(104, 13);
    this.lnkAll.TabIndex = 118;
    this.lnkAll.TabStop = true;
    this.lnkAll.Text = "Select All for Inspect";
    this.lnkNone.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkNone.AutoSize = true;
    this.lnkNone.Location = new Point(151, 638);
    this.lnkNone.Name = "lnkNone";
    this.lnkNone.Size = new Size(121, 13);
    this.lnkNone.TabIndex = 119;
    this.lnkNone.TabStop = true;
    this.lnkNone.Text = "De-Select All for Inspect";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(15, 29);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(106, 13);
    this.Label2.TabIndex = 120;
    this.Label2.Text = "Inspection Company:";
    this.Label2.TextAlign = ContentAlignment.MiddleLeft;
    this.err.ContainerControl = (ContainerControl) this;
    this.GroupBox1.Controls.Add((Control) this.optionInspMethod);
    this.GroupBox1.Location = new Point(404, 12);
    this.GroupBox1.Name = "GroupBox1";
    this.GroupBox1.Size = new Size(140, 50);
    this.GroupBox1.TabIndex = 122;
    this.GroupBox1.TabStop = false;
    this.GroupBox1.Text = "Method of Inspection";
    this.optionInspMethod.BackColor = Color.Transparent;
    this.optionInspMethod.BackColorInternal = Color.Transparent;
    this.optionInspMethod.BorderStyle = (UIElementBorderStyle) 1;
    this.optionInspMethod.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem1.DataValue = (object) (byte) 1;
    valueListItem1.DisplayText = "Phone Survey";
    valueListItem2.DataValue = (object) (byte) 2;
    valueListItem2.DisplayText = "Physical Inspection";
    this.optionInspMethod.Items.AddRange(new ValueListItem[2]
    {
      valueListItem1,
      valueListItem2
    });
    ((Control) this.optionInspMethod).Location = new Point(3, 14);
    ((Control) this.optionInspMethod).Name = "optionInspMethod";
    ((Control) this.optionInspMethod).Size = new Size(131, 33);
    ((Control) this.optionInspMethod).TabIndex = 6;
    ((UltraControlBase) this.optionInspMethod).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionInspMethod).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(749, 19);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(47, 13);
    this.Label1.TabIndex = 126;
    this.Label1.Text = "Division:";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(719, 46);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(77, 13);
    this.Label3.TabIndex = (int) sbyte.MaxValue;
    this.Label3.Text = "Program Code:";
    this.Label3.TextAlign = ContentAlignment.MiddleLeft;
    this.cboProgramCode.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboProgramCode).DataMember = "dtProgramCodes";
    ((UltraGridBase) this.cboProgramCode).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboProgramCode.DisplayLayout.Appearance = (AppearanceBase) appearance3;
    this.cboProgramCode.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 172;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 159;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.cboProgramCode.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboProgramCode.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProgramCode.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance4.BackColor = SystemColors.ActiveBorder;
    appearance4.BackColor2 = SystemColors.ControlDark;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboProgramCode.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance4;
    appearance5.ForeColor = SystemColors.GrayText;
    this.cboProgramCode.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance5;
    ((SpecialBoxBase) this.cboProgramCode.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = SystemColors.ControlLightLight;
    appearance6.BackColor2 = SystemColors.Control;
    appearance6.BackGradientStyle = (GradientStyle) 3;
    appearance6.ForeColor = SystemColors.GrayText;
    this.cboProgramCode.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance6;
    this.cboProgramCode.DisplayLayout.MaxColScrollRegions = 1;
    this.cboProgramCode.DisplayLayout.MaxRowScrollRegions = 1;
    appearance7.BackColor = SystemColors.Window;
    appearance7.ForeColor = SystemColors.ControlText;
    this.cboProgramCode.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = SystemColors.Highlight;
    appearance8.ForeColor = SystemColors.HighlightText;
    this.cboProgramCode.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProgramCode.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance9.BackColor = SystemColors.Window;
    this.cboProgramCode.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.Silver;
    appearance10.TextTrimming = (TextTrimming) 3;
    this.cboProgramCode.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance10;
    this.cboProgramCode.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboProgramCode.DisplayLayout.Override.CellPadding = 0;
    appearance11.BackColor = SystemColors.Control;
    appearance11.BackColor2 = SystemColors.ControlDark;
    appearance11.BackGradientAlignment = (GradientAlignment) 1;
    appearance11.BackGradientStyle = (GradientStyle) 3;
    appearance11.BorderColor = SystemColors.Window;
    this.cboProgramCode.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    this.cboProgramCode.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    this.cboProgramCode.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboProgramCode.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance13.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance13.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProgramCode.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = SystemColors.Window;
    appearance14.BorderColor = Color.White;
    this.cboProgramCode.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    this.cboProgramCode.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboProgramCode.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance15.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance15.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance15.ForeColor = Color.Black;
    this.cboProgramCode.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance15;
    appearance16.BackColor = SystemColors.ControlLight;
    this.cboProgramCode.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance16;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProgramCode.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.cboProgramCode.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboProgramCode.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboProgramCode.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboProgramCode).DisplayMember = "ProgramCode";
    this.cboProgramCode.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboProgramCode).DropDownWidth = 350;
    ((Control) this.cboProgramCode).Location = new Point(802, 42);
    this.cboProgramCode.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProgramCode).Name = "cboProgramCode";
    ((Control) this.cboProgramCode).Size = new Size(232, 20);
    ((Control) this.cboProgramCode).TabIndex = 125;
    ((UltraControlBase) this.cboProgramCode).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProgramCode).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProgramCode).ValueMember = "ID";
    this.ds.DataSetName = "dsSubReq";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cboDivision.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboDivision).DataMember = "dtInspectionTypes";
    ((UltraGridBase) this.cboDivision).DataSource = (object) this.ds;
    appearance17.BackColor = Color.White;
    appearance17.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboDivision.DisplayLayout.Appearance = (AppearanceBase) appearance17;
    this.cboDivision.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 259;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 72;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboDivision.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboDivision.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboDivision.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboDivision.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance18.BackColor = SystemColors.ActiveBorder;
    appearance18.BackColor2 = SystemColors.ControlDark;
    appearance18.BackGradientStyle = (GradientStyle) 2;
    appearance18.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboDivision.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance18;
    appearance19.ForeColor = SystemColors.GrayText;
    this.cboDivision.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance19;
    ((SpecialBoxBase) this.cboDivision.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance20.BackColor = SystemColors.ControlLightLight;
    appearance20.BackColor2 = SystemColors.Control;
    appearance20.BackGradientStyle = (GradientStyle) 3;
    appearance20.ForeColor = SystemColors.GrayText;
    this.cboDivision.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance20;
    this.cboDivision.DisplayLayout.MaxColScrollRegions = 1;
    this.cboDivision.DisplayLayout.MaxRowScrollRegions = 1;
    appearance21.BackColor = SystemColors.Window;
    appearance21.ForeColor = SystemColors.ControlText;
    this.cboDivision.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance21;
    appearance22.BackColor = SystemColors.Highlight;
    appearance22.ForeColor = SystemColors.HighlightText;
    this.cboDivision.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance22;
    this.cboDivision.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboDivision.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboDivision.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboDivision.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboDivision.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboDivision.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboDivision.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboDivision.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance23.BackColor = SystemColors.Window;
    this.cboDivision.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance23;
    appearance24.BorderColor = Color.Silver;
    appearance24.TextTrimming = (TextTrimming) 3;
    this.cboDivision.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance24;
    this.cboDivision.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboDivision.DisplayLayout.Override.CellPadding = 0;
    appearance25.BackColor = SystemColors.Control;
    appearance25.BackColor2 = SystemColors.ControlDark;
    appearance25.BackGradientAlignment = (GradientAlignment) 1;
    appearance25.BackGradientStyle = (GradientStyle) 3;
    appearance25.BorderColor = SystemColors.Window;
    this.cboDivision.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance25;
    ((AppearanceBase) appearance26).TextHAlignAsString = "Left";
    this.cboDivision.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance26;
    this.cboDivision.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboDivision.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance27.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance27.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboDivision.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance27;
    appearance28.BackColor = SystemColors.Window;
    appearance28.BorderColor = Color.White;
    this.cboDivision.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance28;
    this.cboDivision.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboDivision.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance29.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance29.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance29.ForeColor = Color.Black;
    this.cboDivision.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance29;
    appearance30.BackColor = SystemColors.ControlLight;
    this.cboDivision.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance30;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboDivision.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.cboDivision.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboDivision.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboDivision.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboDivision).DisplayMember = "InspectType";
    this.cboDivision.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboDivision).DropDownWidth = 350;
    ((Control) this.cboDivision).Location = new Point(802, 12);
    this.cboDivision.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboDivision).Name = "cboDivision";
    ((Control) this.cboDivision).Size = new Size(232, 20);
    ((Control) this.cboDivision).TabIndex = 124;
    ((UltraControlBase) this.cboDivision).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboDivision).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboDivision).ValueMember = "Code";
    this.cboInspectionCompanies.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboInspectionCompanies).DataMember = "InspectionCompanies";
    ((UltraGridBase) this.cboInspectionCompanies).DataSource = (object) this.ds;
    appearance31.BackColor = Color.White;
    appearance31.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboInspectionCompanies.DisplayLayout.Appearance = (AppearanceBase) appearance31;
    this.cboInspectionCompanies.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 97;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 231;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 106;
    ultraGridBand3.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    this.cboInspectionCompanies.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboInspectionCompanies.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboInspectionCompanies.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance32.BackColor = SystemColors.ActiveBorder;
    appearance32.BackColor2 = SystemColors.ControlDark;
    appearance32.BackGradientStyle = (GradientStyle) 2;
    appearance32.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboInspectionCompanies.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance32;
    appearance33.ForeColor = SystemColors.GrayText;
    this.cboInspectionCompanies.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance33;
    ((SpecialBoxBase) this.cboInspectionCompanies.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance34.BackColor = SystemColors.ControlLightLight;
    appearance34.BackColor2 = SystemColors.Control;
    appearance34.BackGradientStyle = (GradientStyle) 3;
    appearance34.ForeColor = SystemColors.GrayText;
    this.cboInspectionCompanies.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance34;
    this.cboInspectionCompanies.DisplayLayout.MaxColScrollRegions = 1;
    this.cboInspectionCompanies.DisplayLayout.MaxRowScrollRegions = 1;
    appearance35.BackColor = SystemColors.Window;
    appearance35.ForeColor = SystemColors.ControlText;
    this.cboInspectionCompanies.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance35;
    appearance36.BackColor = SystemColors.Highlight;
    appearance36.ForeColor = SystemColors.HighlightText;
    this.cboInspectionCompanies.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance36;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance37.BackColor = SystemColors.Window;
    this.cboInspectionCompanies.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance37;
    appearance38.BorderColor = Color.Silver;
    appearance38.TextTrimming = (TextTrimming) 3;
    this.cboInspectionCompanies.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance38;
    this.cboInspectionCompanies.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboInspectionCompanies.DisplayLayout.Override.CellPadding = 0;
    appearance39.BackColor = SystemColors.Control;
    appearance39.BackColor2 = SystemColors.ControlDark;
    appearance39.BackGradientAlignment = (GradientAlignment) 1;
    appearance39.BackGradientStyle = (GradientStyle) 3;
    appearance39.BorderColor = SystemColors.Window;
    this.cboInspectionCompanies.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance39;
    ((AppearanceBase) appearance40).TextHAlignAsString = "Left";
    this.cboInspectionCompanies.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance40;
    this.cboInspectionCompanies.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboInspectionCompanies.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance41.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance41.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboInspectionCompanies.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance41;
    appearance42.BackColor = SystemColors.Window;
    appearance42.BorderColor = Color.White;
    this.cboInspectionCompanies.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance42;
    this.cboInspectionCompanies.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboInspectionCompanies.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance43.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance43.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance43.ForeColor = Color.Black;
    this.cboInspectionCompanies.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance43;
    appearance44.BackColor = SystemColors.ControlLight;
    this.cboInspectionCompanies.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance44;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboInspectionCompanies.DisplayLayout.ScrollBarLook = scrollBarLook3;
    this.cboInspectionCompanies.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboInspectionCompanies.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboInspectionCompanies.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboInspectionCompanies).DisplayMember = "PayeeName";
    this.cboInspectionCompanies.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboInspectionCompanies).Location = new Point(135, 25);
    this.cboInspectionCompanies.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboInspectionCompanies).Name = "cboInspectionCompanies";
    ((Control) this.cboInspectionCompanies).Size = new Size(250, 20);
    ((Control) this.cboInspectionCompanies).TabIndex = 121;
    ((UltraControlBase) this.cboInspectionCompanies).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboInspectionCompanies).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboInspectionCompanies).ValueMember = "PayeeID";
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ug).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ug).DataMember = "dt";
    ((UltraGridBase) this.ug).DataSource = (object) this.ds;
    appearance45.BackColor = Color.White;
    appearance45.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance45;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Control #";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 0;
    ultraGridColumn8.Width = 158;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Width = 193;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Insured Policy Name";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridColumn10.Width = 322;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 3;
    ultraGridColumn11.Width = 162;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 4;
    ultraGridColumn12.Width = 166;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 5;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 197;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 6;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 116;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 7;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 96 /*0x60*/;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 8;
    ultraGridBand4.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 0;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 151;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 2;
    ultraGridColumn18.Width = 72;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Inspection Contact";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 3;
    ultraGridColumn19.Width = 136;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Contact Phone";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 4;
    ultraGridColumn20.Width = 102;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 5;
    ultraGridColumn21.Width = 151;
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 6;
    ultraGridColumn22.Width = 50;
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn23.Header.VisiblePosition = 7;
    ultraGridColumn23.Width = 109;
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn24.Header.VisiblePosition = 8;
    ultraGridColumn24.Width = 83;
    ((HeaderBase) ultraGridColumn25.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn25.Header.VisiblePosition = 9;
    ultraGridColumn25.Width = 70;
    ((HeaderBase) ultraGridColumn26.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn26.Header.VisiblePosition = 10;
    ultraGridColumn26.Width = 66;
    ((HeaderBase) ultraGridColumn27.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn27.Header.VisiblePosition = 1;
    ultraGridColumn27.Width = 52;
    ((HeaderBase) ultraGridColumn28.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn28.Header.VisiblePosition = 11;
    ultraGridColumn28.Width = 91;
    ultraGridBand5.Columns.AddRange(new object[12]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
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
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance46.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance46.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance46.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance46;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance47.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance47;
    appearance48.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance48;
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance49.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance49;
    appearance50.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance50;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance51.BackColor = Color.Transparent;
    appearance51.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance51;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((Control) this.ug).Location = new Point(12, 68);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(1022, 551);
    ((Control) this.ug).TabIndex = 5;
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.GroupBox2.Controls.Add((Control) this.optionInspectionCompany);
    this.GroupBox2.Location = new Point(556, 12);
    this.GroupBox2.Name = "GroupBox2";
    this.GroupBox2.Size = new Size(126, 50);
    this.GroupBox2.TabIndex = 128 /*0x80*/;
    this.GroupBox2.TabStop = false;
    this.GroupBox2.Text = "Inspection Company";
    this.optionInspectionCompany.BackColor = Color.Transparent;
    this.optionInspectionCompany.BackColorInternal = Color.Transparent;
    this.optionInspectionCompany.BorderStyle = (UIElementBorderStyle) 1;
    this.optionInspectionCompany.GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    valueListItem3.DataValue = (object) (byte) 1;
    valueListItem3.DisplayText = "RCT";
    valueListItem4.DataValue = (object) (byte) 2;
    valueListItem4.DisplayText = "Preferred Reports";
    this.optionInspectionCompany.Items.AddRange(new ValueListItem[2]
    {
      valueListItem3,
      valueListItem4
    });
    ((Control) this.optionInspectionCompany).Location = new Point(3, 14);
    ((Control) this.optionInspectionCompany).Name = "optionInspectionCompany";
    ((Control) this.optionInspectionCompany).Size = new Size(117, 33);
    ((Control) this.optionInspectionCompany).TabIndex = 6;
    ((UltraControlBase) this.optionInspectionCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.optionInspectionCompany).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkClear.AutoSize = true;
    this.lnkClear.Location = new Point(684, 12);
    this.lnkClear.Name = "lnkClear";
    this.lnkClear.Size = new Size(31 /*0x1F*/, 13);
    this.lnkClear.TabIndex = 129;
    this.lnkClear.TabStop = true;
    this.lnkClear.Text = "Clear";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1046, 684);
    this.Controls.Add((Control) this.lnkClear);
    this.Controls.Add((Control) this.GroupBox2);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cboProgramCode);
    this.Controls.Add((Control) this.cboDivision);
    this.Controls.Add((Control) this.GroupBox1);
    this.Controls.Add((Control) this.cboInspectionCompanies);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.lnkNone);
    this.Controls.Add((Control) this.lnkAll);
    this.Controls.Add((Control) this.panelSearch);
    this.Controls.Add((Control) this.btnRequestInspections);
    this.Controls.Add((Control) this.ug);
    this.Name = nameof (FormSubmissionGroupInspectionRequests);
    this.Text = "Submission Group Inspection Requests";
    ((ISupportInitialize) this.btnRequestInspections).EndInit();
    ((ISupportInitialize) this.panelSearch).EndInit();
    ((Control) this.panelSearch).ResumeLayout(false);
    ((Control) this.panelSearch).PerformLayout();
    ((ISupportInitialize) this.spinner).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.GroupBox1.ResumeLayout(false);
    ((ISupportInitialize) this.optionInspMethod).EndInit();
    ((ISupportInitialize) this.cboProgramCode).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cboDivision).EndInit();
    ((ISupportInitialize) this.cboInspectionCompanies).EndInit();
    ((ISupportInitialize) this.ug).EndInit();
    this.GroupBox2.ResumeLayout(false);
    ((ISupportInitialize) this.optionInspectionCompany).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CellEventHandler cellEventHandler = new CellEventHandler(this.ug_AfterCellUpdate);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
        ug1.AfterCellUpdate -= cellEventHandler;
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ug2.AfterCellUpdate += cellEventHandler;
    }
  }

  protected virtual MGAButton btnRequestInspections
  {
    get => this._btnRequestInspections;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRequestInspections_Click);
      MGAButton requestInspections1 = this._btnRequestInspections;
      if (requestInspections1 != null)
        ((Control) requestInspections1).Click -= eventHandler;
      this._btnRequestInspections = value;
      MGAButton requestInspections2 = this._btnRequestInspections;
      if (requestInspections2 == null)
        return;
      ((Control) requestInspections2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("panelSearch")]
  private virtual UltraGroupBox panelSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("spinner")]
  public virtual PictureBox spinner { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("labelSearchText")]
  private virtual Label labelSearchText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsSubReq ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkAll
  {
    get => this._lnkAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAll_LinkClicked);
      LinkLabel lnkAll1 = this._lnkAll;
      if (lnkAll1 != null)
        lnkAll1.LinkClicked -= clickedEventHandler;
      this._lnkAll = value;
      LinkLabel lnkAll2 = this._lnkAll;
      if (lnkAll2 == null)
        return;
      lnkAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkNone
  {
    get => this._lnkNone;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkNone_LinkClicked);
      LinkLabel lnkNone1 = this._lnkNone;
      if (lnkNone1 != null)
        lnkNone1.LinkClicked -= clickedEventHandler;
      this._lnkNone = value;
      LinkLabel lnkNone2 = this._lnkNone;
      if (lnkNone2 == null)
        return;
      lnkNone2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual MGAComboBox cboInspectionCompanies
  {
    get => this._cboInspectionCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.cboInspectionCompanies_ValueChanged);
      MGAComboBox inspectionCompanies1 = this._cboInspectionCompanies;
      if (inspectionCompanies1 != null)
        inspectionCompanies1.ValueChanged -= eventHandler;
      this._cboInspectionCompanies = value;
      MGAComboBox inspectionCompanies2 = this._cboInspectionCompanies;
      if (inspectionCompanies2 == null)
        return;
      inspectionCompanies2.ValueChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  protected virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox1")]
  internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("optionInspMethod")]
  private virtual UltraOptionSet optionInspMethod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProgramCode")]
  protected virtual MGAComboBox cboProgramCode { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboDivision")]
  protected virtual MGAComboBox cboDivision { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("GroupBox2")]
  internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("optionInspectionCompany")]
  private virtual UltraOptionSet optionInspectionCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkClear
  {
    get => this._lnkClear;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkClear_LinkClicked);
      LinkLabel lnkClear1 = this._lnkClear;
      if (lnkClear1 != null)
        lnkClear1.LinkClicked -= clickedEventHandler;
      this._lnkClear = value;
      LinkLabel lnkClear2 = this._lnkClear;
      if (lnkClear2 == null)
        return;
      lnkClear2.LinkClicked += clickedEventHandler;
    }
  }

  public FormSubmissionGroupInspectionRequests(Guid submissionGroupGuid)
  {
    this.Load += new EventHandler(this.FormSubmissionGroupInspectionRequests_Load);
    this._isFormLoading = true;
    this.InitializeComponent();
    this._submissionGroupGuid = submissionGroupGuid;
    this._currentUserGuid = CurrentUser.Instance.UserGUID;
  }

  private void FormSubmissionGroupInspectionRequests_Load(object sender, EventArgs e)
  {
    try
    {
      ((Control) this.panelSearch).Visible = true;
      this.RefreshInspectionLocationData();
      this.FillListTables();
      this.RefreshPanel("Gathering submission policies for request ...");
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[3]
      {
        "dt",
        "Loc",
        "InspectionCompanies"
      }, "GetSubmissionInspectionPolicies", new object[2]
      {
        (object) "@submissionGroupGuid",
        (object) this._submissionGroupGuid
      });
      if (this.ds.InspectionCompanies.Count == 1)
        this.cboInspectionCompanies.Value = (object) this.ds.InspectionCompanies[0].PayeeID;
      ((UltraGridBase) this.ug).Rows.ExpandAll(true);
      this._isFormLoading = false;
    }
    finally
    {
      ((Control) this.panelSearch).Visible = false;
    }
  }

  protected virtual void OnFormSave()
  {
  }

  private void FillListTables()
  {
    if (SystemSettings.KeyExists("RctInspectionDivisionTableName"))
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        "dtInspectionTypes"
      }, CommandType.Text, $"SELECT InspectType, Code FROM {SystemSettings.GetStringSetting("RctInspectionDivisionTableName")} ORDER BY InspectType");
    if (!SystemSettings.KeyExists("RctInspectionProgramCodeTableName"))
      return;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtProgramCodes"
    }, CommandType.Text, $"SELECT ID, ProgramCode FROM {SystemSettings.GetStringSetting("RctInspectionProgramCodeTableName")} ORDER BY ProgramCode");
  }

  private void RefreshInspectionLocationData()
  {
    DefaultDatabase.ExecuteNonQuery(CommandType.Text, "DELETE FROM tblSubmissionInspRequests WHERE UserGuid=@UG AND SubmissionGroupGuid=@SG", new object[4]
    {
      (object) "@UG",
      (object) this._currentUserGuid,
      (object) "@SG",
      (object) this._submissionGroupGuid
    });
  }

  private void lnkAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.InspectionColumnSelection(true);
  }

  private void lnkNone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.InspectionColumnSelection(false);
  }

  private void InspectionColumnSelection(bool booleanSelection)
  {
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ug).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (ultraGridRow.Band.Index == 1)
          ultraGridRow.Cells["Inspect"].Value = (object) booleanSelection;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.ug).UpdateData();
  }

  private bool IsValidData()
  {
    bool flag1 = true;
    this.err.SetError((Control) this.cboInspectionCompanies, string.Empty);
    this.err.SetError((Control) this.cboDivision, string.Empty);
    this.err.SetError((Control) this.cboProgramCode, string.Empty);
    if (string.IsNullOrEmpty(this.cboInspectionCompanies.Text))
    {
      this.err.SetError((Control) this.cboInspectionCompanies, "Please select an inspection company.");
      flag1 = false;
    }
    if (string.IsNullOrEmpty(this.cboDivision.Text))
    {
      this.err.SetError((Control) this.cboDivision, "Please select a Division.");
      flag1 = false;
    }
    if (string.IsNullOrEmpty(this.cboProgramCode.Text))
    {
      this.err.SetError((Control) this.cboProgramCode, "Please select a Program Code.");
      flag1 = false;
    }
    bool flag2 = false;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ug).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (ultraGridRow.Band.Index == 1 && ultraGridRow.Cells["Inspect"].Value != null && ultraGridRow.Cells["Inspect"].Value != DBNull.Value && Conversions.ToBoolean(ultraGridRow.Cells["Inspect"].Value))
        {
          flag2 = true;
          break;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this.optionInspMethod.CheckedItem == null)
    {
      int num = (int) MessageBox.Show("Please select an inspection method.", "No Inspection Method Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag1 = false;
    }
    if (!flag2)
    {
      int num = (int) MessageBox.Show("No policy selected on grid.", "No Policy Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag1 = false;
    }
    bool flag3;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ug).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (ultraGridRow.Band.Index == 1 && ultraGridRow.Cells["Inspect"].Value != null && ultraGridRow.Cells["Inspect"].Value != DBNull.Value && Conversions.ToBoolean(ultraGridRow.Cells["Inspect"].Value) && ultraGridRow.Cells["InspectionContact"].Value == DBNull.Value)
        {
          int num = (int) MessageBox.Show("Inspection Contact is missing on selected location.", "Missing Inspection Contact", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag3 = false;
          goto label_34;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ug).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (ultraGridRow.Band.Index == 1 && ultraGridRow.Cells["Inspect"].Value != null && ultraGridRow.Cells["Inspect"].Value != DBNull.Value && Conversions.ToBoolean(ultraGridRow.Cells["Inspect"].Value) && ultraGridRow.Cells["InspectionContactPhone"].Value == DBNull.Value)
        {
          int num = (int) MessageBox.Show("Contact phone is missing on selected location.", "Missing Inspection Contact Phone", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag3 = false;
          goto label_34;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag3 = flag1;
label_34:
    return flag3;
  }

  private void btnRequestInspections_Click(object sender, EventArgs e)
  {
    if (!this.IsValidData())
      return;
    this.RefreshInspectionLocationData();
    List<int> intList = new List<int>();
    List<Guid> guidList = new List<Guid>();
    string str1 = "INSERT INTO tblSubmissionInspRequests ( SubmissionGroupGuid, UserGuid, LocationID, InspectionType,QuoteGuid, InspectionContact,InspectionContactPhone, Comments, Rush, Location, ClassCode, Address, City, State, ZipCode ) VALUES(@SG, @UG, @LD, @IT, @QG, @IC, @ICP, @Comments, @Rush, @Location, @ClassCode, @Address, @City, @State, @ZipCode)";
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ug).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        object obj1 = (object) null;
        object obj2 = (object) null;
        object obj3 = (object) null;
        object obj4 = (object) null;
        object obj5 = (object) null;
        object obj6 = (object) null;
        object obj7 = (object) null;
        object obj8 = (object) null;
        object obj9 = (object) null;
        object obj10 = (object) null;
        object obj11 = (object) null;
        if (ultraGridRow.Band.Index == 1 && ultraGridRow.Cells["Inspect"].Value != null && ultraGridRow.Cells["Inspect"].Value != DBNull.Value && Conversions.ToBoolean(ultraGridRow.Cells["Inspect"].Value))
        {
          intList.Add(Convert.ToInt32(RuntimeHelpers.GetObjectValue(ultraGridRow.ParentRow.Cells["ControlNo"].Value)));
          guidList.Add((Guid) ultraGridRow.ParentRow.Cells["QuoteGuid"].Value);
          object objectValue1 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["LocationID"].Value);
          if (ultraGridRow.ParentRow.Cells["InspectionType"].Value != DBNull.Value)
            obj1 = RuntimeHelpers.GetObjectValue(ultraGridRow.ParentRow.Cells["InspectionType"].Value);
          object objectValue2 = RuntimeHelpers.GetObjectValue(ultraGridRow.ParentRow.Cells["QuoteGuid"].Value);
          if (ultraGridRow.Cells["InspectionContact"].Value != DBNull.Value)
            obj2 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["InspectionContact"].Value);
          if (ultraGridRow.Cells["InspectionContactPhone"].Value != DBNull.Value)
            obj3 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["InspectionContactPhone"].Value);
          if (ultraGridRow.Cells["Comments"].Value != DBNull.Value)
            obj4 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["Comments"].Value);
          if (ultraGridRow.Cells["Rush"].Value != DBNull.Value)
            obj5 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["Rush"].Value);
          if (ultraGridRow.Cells["Location"].Value != DBNull.Value)
            obj6 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["Location"].Value);
          if (ultraGridRow.Cells["ClassCode"].Value != DBNull.Value)
            obj7 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["ClassCode"].Value);
          if (ultraGridRow.Cells["Address"].Value != DBNull.Value)
            obj8 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["Address"].Value);
          if (ultraGridRow.Cells["City"].Value != DBNull.Value)
            obj9 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["City"].Value);
          if (ultraGridRow.Cells["State"].Value != DBNull.Value)
            obj10 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["State"].Value);
          if (ultraGridRow.Cells["ZipCode"].Value != DBNull.Value)
            obj11 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["ZipCode"].Value);
          DefaultDatabase.ExecuteNonQuery(CommandType.Text, str1, new object[30]
          {
            (object) "@SG",
            (object) this._submissionGroupGuid,
            (object) "@UG",
            (object) this._currentUserGuid,
            (object) "@LD",
            objectValue1,
            (object) "@IT",
            obj1,
            (object) "@QG",
            objectValue2,
            (object) "@IC",
            obj2,
            (object) "@ICP",
            obj3,
            (object) "@Comments",
            obj4,
            (object) "@Rush",
            obj5,
            (object) "@Location",
            obj6,
            (object) "@ClassCode",
            obj7,
            (object) "@Address",
            obj8,
            (object) "@City",
            obj9,
            (object) "@State",
            obj10,
            (object) "@ZipCode",
            obj11
          });
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    try
    {
      ((Control) this.panelSearch).Visible = true;
      this.RefreshPanel("Requesting submission requests ...");
      this.OnFormSave();
      bool flag1 = false;
      bool flag2 = false;
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.optionInspectionCompany.Value)))
      {
        flag1 = (byte) this.optionInspectionCompany.Value == (byte) 1;
        flag2 = (byte) this.optionInspectionCompany.Value == (byte) 2;
      }
      Quote quote = Quote.FromControlNo(intList[0]);
      if (flag1)
      {
        RctInspections objectEx = (RctInspections) ObjectFactory.Instance.CreateObjectEX(typeof (RctInspections), (object) new RRIRequest(), (object) quote);
        objectEx.SubmissionRequest = true;
        objectEx.QuoteList = intList;
        objectEx.SubmissionRequestInspectionCompanyID = Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboInspectionCompanies.Value));
        if (this.optionInspMethod.Value != null)
          objectEx.BaseInspectionMethod = (object) (byte) this.optionInspMethod.Value;
        if (this.cboDivision.Text.Length > 0)
          objectEx.SubmissionRequestDivision = this.cboDivision.Value.ToString();
        if (this.cboProgramCode.Text.Length > 0)
          objectEx.SubmissionRequestProgramCode = this.cboProgramCode.Value.ToString();
        objectEx.SendRctRequests();
      }
      else if (flag2)
      {
        PreferredReportsRequests objectEx = (PreferredReportsRequests) ObjectFactory.Instance.CreateObjectEX(typeof (PreferredReportsRequests), (object) quote.QuoteGuid);
        objectEx.QuoteList = intList;
        objectEx.SubmissionRequest = true;
        objectEx.SubmissionRequestInspectionCompanyID = Convert.ToInt32(RuntimeHelpers.GetObjectValue(this.cboInspectionCompanies.Value));
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(this.optionInspMethod.Value)))
          objectEx.BaseInspectionMethod = (object) (byte) this.optionInspMethod.Value;
        if (this.cboDivision.Text.Length > 0)
          objectEx.SubmissionRequestDivision = this.cboDivision.Value.ToString();
        if (this.cboProgramCode.Text.Length > 0)
          objectEx.SubmissionRequestProgramCode = this.cboProgramCode.Value.ToString();
        objectEx.SendPreferredReportsRequests();
      }
      else
      {
        try
        {
          ((Control) this.panelSearch).Visible = true;
          string str2 = "select ControlNo from tblQuotes with (nolock) where QuoteGuid = @QG";
          try
          {
            foreach (Guid guid in guidList)
            {
              this.RefreshPanel($"Requesting inspection for Control # {DefaultDatabase.ExecuteScalar<int>(CommandType.Text, str2, new object[2]
              {
                (object) "@QG",
                (object) guid
              })} ...");
              Thread.Sleep(2000);
              ((Control) this.panelSearch).Visible = false;
              ((BlackBoxInspectionRequest) ObjectFactory.Instance.CreateObjectEX(typeof (BlackBoxInspectionRequest), (object) guid)).BeginBlackBoxInspectionRequest();
            }
          }
          finally
          {
            List<Guid>.Enumerator enumerator;
            enumerator.Dispose();
          }
        }
        finally
        {
          ((Control) this.panelSearch).Visible = false;
        }
      }
    }
    finally
    {
      ((Control) this.panelSearch).Visible = false;
    }
  }

  public void RefreshPanel(string searchText)
  {
    this.labelSearchText.Text = searchText;
    ((UltraControlBase) this.panelSearch).Refresh();
  }

  private void ug_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (this._isFormLoading || e.Cell.Band.Index != 1 || !e.Cell.Column.Key.Equals("InspectionContact") && !e.Cell.Column.Key.Equals("InspectionContactPhone"))
      return;
    try
    {
      this.ug.AfterCellUpdate -= new CellEventHandler(this.ug_AfterCellUpdate);
      this.ug.AfterCellUpdate -= new CellEventHandler(this.ug_AfterCellUpdate);
      this.ug.AfterCellUpdate -= new CellEventHandler(this.ug_AfterCellUpdate);
      string str = "Contact";
      if (e.Cell.Column.Key.Equals("InspectionContactPhone"))
        str = "Phone";
      if (MessageBox.Show(str + " has changed.\n\nUpdate the other rows with this new value?", "Update Other Locations", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      if (str.Equals("Contact"))
      {
        try
        {
          foreach (dsSubReq.LocRow row in this.ds.Loc.Rows)
            row.InspectionContact = e.Cell.Text;
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      else
      {
        try
        {
          foreach (dsSubReq.LocRow row in this.ds.Loc.Rows)
            row.InspectionContactPhone = e.Cell.Text;
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
      }
      this.ds.AcceptChanges();
    }
    finally
    {
      this.ug.AfterCellUpdate += new CellEventHandler(this.ug_AfterCellUpdate);
    }
  }

  private void lnkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.optionInspectionCompany.Value = (object) null;
  }

  private void cboInspectionCompanies_ValueChanged(object sender, EventArgs e)
  {
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(this.cboInspectionCompanies.Value)))
      return;
    if (this.cboInspectionCompanies.Text.ToUpper().Equals("PREFERRED REPORTS"))
      this.optionInspectionCompany.Value = (object) 2;
    else if (this.cboInspectionCompanies.Text.ToUpper().Equals("RISK CONTROL TECHNOLOGIES"))
      this.optionInspectionCompany.Value = (object) 1;
    else
      this.optionInspectionCompany.Value = (object) null;
  }
}
