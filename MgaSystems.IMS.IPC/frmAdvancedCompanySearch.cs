// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.frmAdvancedCompanySearch
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
internal class frmAdvancedCompanySearch : Form
{
  private IContainer components;

  public frmAdvancedCompanySearch() => this.InitializeComponent();

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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanies", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("companyGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("companyName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FEIN");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("Closed");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstProducerTypes", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProducerTypeID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Description");
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
    Appearance appearance25 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmAdvancedCompanySearch));
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    this.txtFEIN = new MGAMaskedEdit();
    this.Label13 = new Label();
    this.txtName = new MGATextBox();
    this.Label5 = new Label();
    this.lnkResetSearch = new LinkLabel();
    this.btnGo = new MGAButton();
    this.ugAdvancedCompanySearch = new UltraGrid();
    this.Label1 = new Label();
    this.cboProducerType = new MGAComboBox();
    this.UltraPictureBox1 = new UltraPictureBox();
    this.MgaButton1 = new MGAButton();
    this.btnSearch = new MGAButton();
    this.DsAdvancedCompanySearch1 = new dsAdvancedCompanySearch();
    this.MgaMaskedEdit1 = new MGAMaskedEdit();
    this.Label2 = new Label();
    ((ISupportInitialize) this.txtFEIN).BeginInit();
    ((ISupportInitialize) this.txtName).BeginInit();
    ((ISupportInitialize) this.btnGo).BeginInit();
    ((ISupportInitialize) this.ugAdvancedCompanySearch).BeginInit();
    ((ISupportInitialize) this.cboProducerType).BeginInit();
    ((ISupportInitialize) this.MgaButton1).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    this.DsAdvancedCompanySearch1.BeginInit();
    ((ISupportInitialize) this.MgaMaskedEdit1).BeginInit();
    this.SuspendLayout();
    appearance1.BackColorDisabled = Color.Gainsboro;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.txtFEIN.Appearance = (AppearanceBase) appearance1;
    this.txtFEIN.EditAs = (EditAsType) 1;
    this.txtFEIN.InputMask = "##-#######";
    ((Control) this.txtFEIN).Location = new Point(682, -25);
    this.txtFEIN.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFEIN).Name = "txtFEIN";
    this.txtFEIN.NonAutoSizeHeight = 20;
    ((Control) this.txtFEIN).Size = new Size(72, 20);
    ((Control) this.txtFEIN).TabIndex = 56;
    this.txtFEIN.Text = "-";
    ((UltraControlBase) this.txtFEIN).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFEIN).UseOsThemes = (DefaultableBoolean) 2;
    this.Label13.AutoSize = true;
    this.Label13.BackColor = Color.Transparent;
    this.Label13.Location = new Point(640, -21);
    this.Label13.Name = "Label13";
    this.Label13.Size = new Size(34, 13);
    this.Label13.TabIndex = 57;
    this.Label13.Text = "FEIN:";
    this.Label13.TextAlign = ContentAlignment.MiddleRight;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtName).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtName).BackColor = Color.White;
    ((Control) this.txtName).Location = new Point(40, -27);
    ((TextEditorControlBase) this.txtName).MaxLength = 250;
    this.txtName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtName).Name = "txtName";
    ((Control) this.txtName).Size = new Size(330, 19);
    ((Control) this.txtName).TabIndex = 42;
    ((UltraControlBase) this.txtName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.Location = new Point(-46, -25);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label5.TabIndex = 41;
    this.Label5.Text = "Name";
    this.Label5.TextAlign = ContentAlignment.MiddleLeft;
    this.lnkResetSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkResetSearch.Location = new Point(-46, 613);
    this.lnkResetSearch.Name = "lnkResetSearch";
    this.lnkResetSearch.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.lnkResetSearch.TabIndex = 38;
    this.lnkResetSearch.TabStop = true;
    this.lnkResetSearch.Text = "Reset Search";
    ((Control) this.btnGo).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.ImageHAlign = (HAlign) 2;
    appearance3.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnGo).Appearance = (AppearanceBase) appearance3;
    ((ControlBase) this.btnGo).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((Control) this.btnGo).Enabled = false;
    ((ControlBase) this.btnGo).ImageSize = new Size(24, 24);
    ((Control) this.btnGo).Location = new Point(1051, 589);
    ((Control) this.btnGo).Name = "btnGo";
    ((Control) this.btnGo).Size = new Size(40, 40);
    ((Control) this.btnGo).TabIndex = 36;
    this.btnGo.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ugAdvancedCompanySearch).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DataMember = "tblCompanies";
    ((UltraGridBase) this.ugAdvancedCompanySearch).DataSource = (object) this.DsAdvancedCompanySearch1;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 406;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 139;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 189;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 135;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugAdvancedCompanySearch).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.ugAdvancedCompanySearch).Location = new Point(12, 66);
    ((Control) this.ugAdvancedCompanySearch).Name = "ugAdvancedCompanySearch";
    ((Control) this.ugAdvancedCompanySearch).Size = new Size(871, 241);
    ((Control) this.ugAdvancedCompanySearch).TabIndex = 37;
    ((Control) this.ugAdvancedCompanySearch).Text = "Companies";
    ((UltraControlBase) this.ugAdvancedCompanySearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAdvancedCompanySearch).UseOsThemes = (DefaultableBoolean) 2;
    this.Label1.Location = new Point(376, -25);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.Label1.TabIndex = 32 /*0x20*/;
    this.Label1.Text = "Type";
    this.Label1.TextAlign = ContentAlignment.MiddleLeft;
    this.cboProducerType.BorderStyle = (UIElementBorderStyle) 4;
    appearance12.BackColor = Color.White;
    appearance12.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboProducerType.DisplayLayout.Appearance = (AppearanceBase) appearance12;
    this.cboProducerType.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 114;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    this.cboProducerType.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboProducerType.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboProducerType.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance13.BackColor = SystemColors.ActiveBorder;
    appearance13.BackColor2 = SystemColors.ControlDark;
    appearance13.BackGradientStyle = (GradientStyle) 2;
    appearance13.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.cboProducerType.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance13;
    appearance14.ForeColor = SystemColors.GrayText;
    this.cboProducerType.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance14;
    ((SpecialBoxBase) this.cboProducerType.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance15.BackColor = SystemColors.ControlLightLight;
    appearance15.BackColor2 = SystemColors.Control;
    appearance15.BackGradientStyle = (GradientStyle) 3;
    appearance15.ForeColor = SystemColors.GrayText;
    this.cboProducerType.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance15;
    this.cboProducerType.DisplayLayout.MaxColScrollRegions = 1;
    this.cboProducerType.DisplayLayout.MaxRowScrollRegions = 1;
    appearance16.BackColor = SystemColors.Window;
    appearance16.ForeColor = SystemColors.ControlText;
    this.cboProducerType.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance16;
    appearance17.BackColor = SystemColors.Highlight;
    appearance17.ForeColor = SystemColors.HighlightText;
    this.cboProducerType.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance17;
    this.cboProducerType.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboProducerType.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance18.BackColor = SystemColors.Window;
    this.cboProducerType.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance18;
    appearance19.BorderColor = Color.Silver;
    appearance19.TextTrimming = (TextTrimming) 3;
    this.cboProducerType.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance19;
    this.cboProducerType.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.cboProducerType.DisplayLayout.Override.CellPadding = 0;
    appearance20.BackColor = SystemColors.Control;
    appearance20.BackColor2 = SystemColors.ControlDark;
    appearance20.BackGradientAlignment = (GradientAlignment) 1;
    appearance20.BackGradientStyle = (GradientStyle) 3;
    appearance20.BorderColor = SystemColors.Window;
    this.cboProducerType.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).TextHAlignAsString = "Left";
    this.cboProducerType.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance21;
    this.cboProducerType.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.cboProducerType.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance22.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance22.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboProducerType.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance22;
    appearance23.BackColor = SystemColors.Window;
    appearance23.BorderColor = Color.White;
    this.cboProducerType.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    this.cboProducerType.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.cboProducerType.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance24.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance24.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance24.ForeColor = Color.Black;
    this.cboProducerType.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance24;
    appearance25.BackColor = SystemColors.ControlLight;
    this.cboProducerType.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance25;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboProducerType.DisplayLayout.ScrollBarLook = scrollBarLook2;
    this.cboProducerType.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.cboProducerType.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.cboProducerType.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.cboProducerType).DisplayMember = "Description";
    this.cboProducerType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboProducerType).Location = new Point(499, -27);
    this.cboProducerType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboProducerType).Name = "cboProducerType";
    ((Control) this.cboProducerType).Size = new Size(133, 20);
    ((Control) this.cboProducerType).TabIndex = 29;
    ((UltraControlBase) this.cboProducerType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboProducerType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboProducerType).ValueMember = "ProducerTypeID";
    this.UltraPictureBox1.AutoSize = true;
    this.UltraPictureBox1.BorderShadowColor = Color.Empty;
    this.UltraPictureBox1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("UltraPictureBox1.Image"));
    ((Control) this.UltraPictureBox1).Location = new Point(843, 12);
    ((Control) this.UltraPictureBox1).Name = "UltraPictureBox1";
    ((Control) this.UltraPictureBox1).Size = new Size(48 /*0x30*/, 48 /*0x30*/);
    ((Control) this.UltraPictureBox1).TabIndex = 45;
    ((Control) this.MgaButton1).Anchor = AnchorStyles.None;
    appearance26.ImageHAlign = (HAlign) 2;
    appearance26.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.MgaButton1).Appearance = (AppearanceBase) appearance26;
    ((ControlBase) this.MgaButton1).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((Control) this.MgaButton1).Enabled = false;
    ((ControlBase) this.MgaButton1).ImageSize = new Size(24, 24);
    ((Control) this.MgaButton1).Location = new Point(843, 334);
    ((Control) this.MgaButton1).Name = "MgaButton1";
    ((Control) this.MgaButton1).Size = new Size(40, 40);
    ((Control) this.MgaButton1).TabIndex = 59;
    this.MgaButton1.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnSearch).Anchor = AnchorStyles.None;
    appearance27.ImageHAlign = (HAlign) 2;
    appearance27.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance27;
    ((ControlBase) this.btnSearch).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(787, 334);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 58;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.DsAdvancedCompanySearch1.DataSetName = "dsAdvancedCompanySearch";
    this.DsAdvancedCompanySearch1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance28.BackColorDisabled = Color.Gainsboro;
    appearance28.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaMaskedEdit1.Appearance = (AppearanceBase) appearance28;
    this.MgaMaskedEdit1.EditAs = (EditAsType) 1;
    this.MgaMaskedEdit1.InputMask = "##-#######";
    ((Control) this.MgaMaskedEdit1).Location = new Point(69, 12);
    this.MgaMaskedEdit1.MGAStyle = MGAStyles.Blue;
    ((Control) this.MgaMaskedEdit1).Name = "MgaMaskedEdit1";
    this.MgaMaskedEdit1.NonAutoSizeHeight = 20;
    ((Control) this.MgaMaskedEdit1).Size = new Size(72, 20);
    ((Control) this.MgaMaskedEdit1).TabIndex = 61;
    this.MgaMaskedEdit1.Text = "-";
    ((UltraControlBase) this.MgaMaskedEdit1).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.MgaMaskedEdit1).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(27, 16 /*0x10*/);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(34, 13);
    this.Label2.TabIndex = 62;
    this.Label2.Text = "FEIN:";
    this.Label2.TextAlign = ContentAlignment.MiddleRight;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(1044, 599);
    this.Controls.Add((Control) this.MgaMaskedEdit1);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.MgaButton1);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.txtFEIN);
    this.Controls.Add((Control) this.Label13);
    this.Controls.Add((Control) this.UltraPictureBox1);
    this.Controls.Add((Control) this.txtName);
    this.Controls.Add((Control) this.Label5);
    this.Controls.Add((Control) this.lnkResetSearch);
    this.Controls.Add((Control) this.btnGo);
    this.Controls.Add((Control) this.ugAdvancedCompanySearch);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cboProducerType);
    this.Name = nameof (frmAdvancedCompanySearch);
    this.Text = "Advanced Company Search";
    ((ISupportInitialize) this.txtFEIN).EndInit();
    ((ISupportInitialize) this.txtName).EndInit();
    ((ISupportInitialize) this.btnGo).EndInit();
    ((ISupportInitialize) this.ugAdvancedCompanySearch).EndInit();
    ((ISupportInitialize) this.cboProducerType).EndInit();
    ((ISupportInitialize) this.MgaButton1).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    this.DsAdvancedCompanySearch1.EndInit();
    ((ISupportInitialize) this.MgaMaskedEdit1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("txtFEIN")]
  protected internal virtual MGAMaskedEdit txtFEIN { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label13")]
  private virtual Label Label13 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraPictureBox1")]
  internal virtual UltraPictureBox UltraPictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtName")]
  protected internal virtual MGATextBox txtName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lnkResetSearch")]
  protected internal virtual LinkLabel lnkResetSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnGo")]
  protected internal virtual MGAButton btnGo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugAdvancedCompanySearch")]
  protected internal virtual UltraGrid ugAdvancedCompanySearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboProducerType")]
  protected internal virtual MGAComboBox cboProducerType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaButton1")]
  protected internal virtual MGAButton MgaButton1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("btnSearch")]
  protected internal virtual MGAButton btnSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("DsAdvancedCompanySearch1")]
  internal virtual dsAdvancedCompanySearch DsAdvancedCompanySearch1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("MgaMaskedEdit1")]
  protected internal virtual MGAMaskedEdit MgaMaskedEdit1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  private virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }
}
