// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormDriverProductStates
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.IMS.Security;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
[SecureResource("{5B033ACC-010B-4206-8DBA-B42799FAB9D4}", "Add Volta States", "Allows the user to add volta states.", "Driver")]
[SecureResource("{D7C2DACD-68F8-4A25-9029-ABD76D3BAEF8}", "Save Volta States", "Allows the user to save volta states.", "Driver")]
[SecureResource("{99A56537-E6AF-493C-BF79-4AEA854EC9D0}", "Delete Volta States", "Allows the user to delete volta states.", "Driver")]
public class FormDriverProductStates : Form
{
  private IContainer components;
  private Guid _userGuid;
  private bool _canAdd;
  private bool _canSave;
  private bool _canDelete;
  internal const string AddVoltaStates = "{5B033ACC-010B-4206-8DBA-B42799FAB9D4}";
  internal const string SaveVoltaStates = "{D7C2DACD-68F8-4A25-9029-ABD76D3BAEF8}";
  internal const string DeleteVoltaStates = "{99A56537-E6AF-493C-BF79-4AEA854EC9D0}";

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
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("State");
    Appearance appearance10 = new Appearance();
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
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("State");
    Appearance appearance23 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblDriverProductStates", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("StateID", -1, (object) "ddStates");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("SubType");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("FullOption");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CleanOption");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("ActivityOption");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("VdetailOption");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("AlternateSubType");
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.lblState = new Label();
    this.grpBox = new UltraGroupBox();
    this.lblAlternateSubTypeText = new Label();
    this.lblAlternateSubType = new Label();
    this.txtAlternateSubType = new MGATextBox();
    this.ds = new dsDriverRenewal();
    this.txtSubType = new MGATextBox();
    this.chkVdetail = new MGACheckBox();
    this.chkActivity = new MGACheckBox();
    this.chkClean = new MGACheckBox();
    this.chkFull = new MGACheckBox();
    this.lblSubType = new Label();
    this.comboState = new MGAComboBox();
    this.err = new ErrorProvider(this.components);
    this.ddStates = new UltraDropDown();
    this.ugAvail = new UltraGrid();
    ((ISupportInitialize) this.grpBox).BeginInit();
    ((Control) this.grpBox).SuspendLayout();
    ((ISupportInitialize) this.txtAlternateSubType).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtSubType).BeginInit();
    ((ISupportInitialize) this.chkVdetail).BeginInit();
    ((ISupportInitialize) this.chkActivity).BeginInit();
    ((ISupportInitialize) this.chkClean).BeginInit();
    ((ISupportInitialize) this.chkFull).BeginInit();
    ((ISupportInitialize) this.comboState).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddStates).BeginInit();
    ((ISupportInitialize) this.ugAvail).BeginInit();
    this.SuspendLayout();
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(639, 569);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(117, 34);
    this.dbSave.TabIndex = 14;
    this.lblState.AutoSize = true;
    this.lblState.BackColor = Color.Transparent;
    this.lblState.Location = new Point(17, 32 /*0x20*/);
    this.lblState.Name = "lblState";
    this.lblState.Size = new Size(35, 13);
    this.lblState.TabIndex = 80 /*0x50*/;
    this.lblState.Text = "State:";
    ((Control) this.grpBox).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance1.BackColor = Color.FromArgb(239, 247, 253);
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.grpBox.ContentAreaAppearance = (AppearanceBase) appearance1;
    ((Control) this.grpBox).Controls.Add((Control) this.lblAlternateSubTypeText);
    ((Control) this.grpBox).Controls.Add((Control) this.lblAlternateSubType);
    ((Control) this.grpBox).Controls.Add((Control) this.txtAlternateSubType);
    ((Control) this.grpBox).Controls.Add((Control) this.txtSubType);
    ((Control) this.grpBox).Controls.Add((Control) this.chkVdetail);
    ((Control) this.grpBox).Controls.Add((Control) this.chkActivity);
    ((Control) this.grpBox).Controls.Add((Control) this.chkClean);
    ((Control) this.grpBox).Controls.Add((Control) this.chkFull);
    ((Control) this.grpBox).Controls.Add((Control) this.lblSubType);
    ((Control) this.grpBox).Controls.Add((Control) this.comboState);
    ((Control) this.grpBox).Controls.Add((Control) this.lblState);
    ((Control) this.grpBox).Enabled = false;
    appearance2.ForeColor = Color.Navy;
    this.grpBox.HeaderAppearance = (AppearanceBase) appearance2;
    ((Control) this.grpBox).Location = new Point(10, 421);
    ((Control) this.grpBox).Name = "grpBox";
    ((Control) this.grpBox).Size = new Size(508, 181);
    ((Control) this.grpBox).TabIndex = 82;
    this.grpBox.Text = "MVR Options";
    this.lblAlternateSubTypeText.AutoSize = true;
    this.lblAlternateSubTypeText.BackColor = Color.Transparent;
    this.lblAlternateSubTypeText.Location = new Point(231, 109);
    this.lblAlternateSubTypeText.Name = "lblAlternateSubTypeText";
    this.lblAlternateSubTypeText.Size = new Size(172, 13);
    this.lblAlternateSubTypeText.TabIndex = 93;
    this.lblAlternateSubTypeText.Text = "If assigned, this takes precedence.";
    this.lblAlternateSubType.AutoSize = true;
    this.lblAlternateSubType.BackColor = Color.Transparent;
    this.lblAlternateSubType.Location = new Point(17, 109);
    this.lblAlternateSubType.Margin = new Padding(2, 0, 2, 0);
    this.lblAlternateSubType.Name = "lblAlternateSubType";
    this.lblAlternateSubType.Size = new Size(101, 13);
    this.lblAlternateSubType.TabIndex = 92;
    this.lblAlternateSubType.Text = "Alternate Sub Type:";
    this.lblAlternateSubType.TextAlign = ContentAlignment.MiddleLeft;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAlternateSubType).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtAlternateSubType).BackColor = Color.White;
    ((Control) this.txtAlternateSubType).DataBindings.Add(new Binding("Text", (object) this.ds, "tblDriverProductStates.AlternateSubType", true));
    ((Control) this.txtAlternateSubType).Location = new Point(126, 107);
    this.txtAlternateSubType.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAlternateSubType).Name = "txtAlternateSubType";
    ((Control) this.txtAlternateSubType).Size = new Size(99, 19);
    ((Control) this.txtAlternateSubType).TabIndex = 2;
    ((UltraControlBase) this.txtAlternateSubType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAlternateSubType).UseOsThemes = (DefaultableBoolean) 2;
    this.txtAlternateSubType.WordWrap = false;
    this.ds.DataSetName = "dsDriverRenewal";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSubType).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtSubType).BackColor = Color.White;
    ((Control) this.txtSubType).DataBindings.Add(new Binding("Text", (object) this.ds, "tblDriverProductStates.SubType", true));
    ((Control) this.txtSubType).Location = new Point(126, 66);
    this.txtSubType.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSubType).Name = "txtSubType";
    ((Control) this.txtSubType).Size = new Size(99, 19);
    ((Control) this.txtSubType).TabIndex = 1;
    ((UltraControlBase) this.txtSubType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSubType).UseOsThemes = (DefaultableBoolean) 2;
    this.txtSubType.WordWrap = false;
    appearance5.BorderColor = Color.Gray;
    appearance5.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkVdetail).Appearance = (AppearanceBase) appearance5;
    ((UltraToggleEditorBase) this.chkVdetail).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkVdetail).BackColorInternal = Color.Transparent;
    ((Control) this.chkVdetail).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblDriverProductStates.VdetailOption", true));
    ((UltraToggleEditorBase) this.chkVdetail).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.chkVdetail).Location = new Point(370, 148);
    ((Control) this.chkVdetail).Name = "chkVdetail";
    ((Control) this.chkVdetail).Size = new Size(72, 28);
    ((Control) this.chkVdetail).TabIndex = 6;
    ((UltraToggleEditorBase) this.chkVdetail).Text = "V detail";
    ((UltraControlBase) this.chkVdetail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkVdetail).UseOsThemes = (DefaultableBoolean) 2;
    appearance6.BorderColor = Color.Gray;
    appearance6.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkActivity).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.chkActivity).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkActivity).BackColorInternal = Color.Transparent;
    ((Control) this.chkActivity).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblDriverProductStates.ActivityOption", true));
    ((UltraToggleEditorBase) this.chkActivity).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.chkActivity).Location = new Point(254, 148);
    ((Control) this.chkActivity).Name = "chkActivity";
    ((Control) this.chkActivity).Size = new Size(72, 28);
    ((Control) this.chkActivity).TabIndex = 5;
    ((UltraToggleEditorBase) this.chkActivity).Text = "Activity";
    ((UltraControlBase) this.chkActivity).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkActivity).UseOsThemes = (DefaultableBoolean) 2;
    appearance7.BorderColor = Color.Gray;
    appearance7.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkClean).Appearance = (AppearanceBase) appearance7;
    ((UltraToggleEditorBase) this.chkClean).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkClean).BackColorInternal = Color.Transparent;
    ((Control) this.chkClean).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblDriverProductStates.CleanOption", true));
    ((UltraToggleEditorBase) this.chkClean).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.chkClean).Location = new Point(136, 148);
    ((Control) this.chkClean).Name = "chkClean";
    ((Control) this.chkClean).Size = new Size(74, 28);
    ((Control) this.chkClean).TabIndex = 4;
    ((UltraToggleEditorBase) this.chkClean).Text = "Clean";
    ((UltraControlBase) this.chkClean).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkClean).UseOsThemes = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.Gray;
    appearance8.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkFull).Appearance = (AppearanceBase) appearance8;
    ((UltraToggleEditorBase) this.chkFull).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkFull).BackColorInternal = Color.Transparent;
    ((Control) this.chkFull).DataBindings.Add(new Binding("Checked", (object) this.ds, "tblDriverProductStates.FullOption", true));
    ((UltraToggleEditorBase) this.chkFull).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007RadioButtonGlyphInfo;
    ((Control) this.chkFull).Location = new Point(20, 148);
    ((Control) this.chkFull).Name = "chkFull";
    ((Control) this.chkFull).Size = new Size(72, 28);
    ((Control) this.chkFull).TabIndex = 3;
    ((UltraToggleEditorBase) this.chkFull).Text = "Full";
    ((UltraControlBase) this.chkFull).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkFull).UseOsThemes = (DefaultableBoolean) 2;
    this.lblSubType.AutoSize = true;
    this.lblSubType.BackColor = Color.Transparent;
    this.lblSubType.Location = new Point(17, 69);
    this.lblSubType.Name = "lblSubType";
    this.lblSubType.Size = new Size(56, 13);
    this.lblSubType.TabIndex = 86;
    this.lblSubType.Text = "Sub Type:";
    this.comboState.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.comboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblDriverProductStates.StateID", true));
    ((UltraGridBase) this.comboState).DataMember = "lstStates";
    ((UltraGridBase) this.comboState).DataSource = (object) this.ds;
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb(78, 122, 171);
    this.comboState.DisplayLayout.Appearance = (AppearanceBase) appearance9;
    this.comboState.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 181;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    this.comboState.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.comboState.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.comboState.DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance10.BackColor = SystemColors.ActiveBorder;
    appearance10.BackColor2 = SystemColors.ControlDark;
    appearance10.BackGradientStyle = (GradientStyle) 2;
    appearance10.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) this.comboState.DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance10;
    appearance11.ForeColor = SystemColors.GrayText;
    this.comboState.DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance11;
    ((SpecialBoxBase) this.comboState.DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance12.BackColor = SystemColors.ControlLightLight;
    appearance12.BackColor2 = SystemColors.Control;
    appearance12.BackGradientStyle = (GradientStyle) 3;
    appearance12.ForeColor = SystemColors.GrayText;
    this.comboState.DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance12;
    this.comboState.DisplayLayout.MaxColScrollRegions = 1;
    this.comboState.DisplayLayout.MaxRowScrollRegions = 1;
    appearance13.BackColor = SystemColors.Window;
    appearance13.ForeColor = SystemColors.ControlText;
    this.comboState.DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = SystemColors.Highlight;
    appearance14.ForeColor = SystemColors.HighlightText;
    this.comboState.DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance14;
    this.comboState.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.comboState.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    appearance15.BackColor = SystemColors.Window;
    this.comboState.DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.Silver;
    appearance16.TextTrimming = (TextTrimming) 3;
    this.comboState.DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    this.comboState.DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    this.comboState.DisplayLayout.Override.CellPadding = 0;
    appearance17.BackColor = SystemColors.Control;
    appearance17.BackColor2 = SystemColors.ControlDark;
    appearance17.BackGradientAlignment = (GradientAlignment) 1;
    appearance17.BackGradientStyle = (GradientStyle) 3;
    appearance17.BorderColor = SystemColors.Window;
    this.comboState.DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance17;
    ((AppearanceBase) appearance18).TextHAlignAsString = "Left";
    this.comboState.DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance18;
    this.comboState.DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    this.comboState.DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance19.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance19.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.comboState.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance19;
    appearance20.BackColor = SystemColors.Window;
    appearance20.BorderColor = Color.White;
    this.comboState.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance20;
    this.comboState.DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    this.comboState.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance21.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance21.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance21.ForeColor = Color.Black;
    this.comboState.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance21;
    appearance22.BackColor = SystemColors.ControlLight;
    this.comboState.DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance22;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.comboState.DisplayLayout.ScrollBarLook = scrollBarLook1;
    this.comboState.DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    this.comboState.DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    this.comboState.DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.comboState).DisplayMember = "State";
    this.comboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboState).DropDownWidth = 200;
    ((Control) this.comboState).Location = new Point(126, 25);
    this.comboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboState).Name = "comboState";
    ((Control) this.comboState).Size = new Size(250, 20);
    ((Control) this.comboState).TabIndex = 0;
    ((UltraControlBase) this.comboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboState).ValueMember = "StateID";
    this.err.ContainerControl = (ContainerControl) this;
    ((UltraGridBase) this.ddStates).DataMember = "lstStates";
    ((UltraGridBase) this.ddStates).DataSource = (object) this.ds;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Hidden = true;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Width = 306;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddStates).DisplayMember = "State";
    ((Control) this.ddStates).Location = new Point(290, 259);
    ((Control) this.ddStates).Name = "ddStates";
    ((Control) this.ddStates).Size = new Size(325, 56);
    ((Control) this.ddStates).TabIndex = 211;
    ((UltraDropDownBase) this.ddStates).ValueMember = "StateID";
    ((Control) this.ddStates).Visible = false;
    ((Control) this.ugAvail).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraControlBase) this.ugAvail).Cursor = Cursors.Hand;
    ((UltraGridBase) this.ugAvail).DataMember = "tblDriverProductStates";
    ((UltraGridBase) this.ugAvail).DataSource = (object) this.ds;
    appearance23.BackColor = Color.White;
    appearance23.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Appearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.ugAvail).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 46;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Style = (ColumnStyle) 6;
    ultraGridColumn6.Width = 161;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Sub Type";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 93;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Full";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 5;
    ultraGridColumn8.Width = 76;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Clean";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn9.Width = 94;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Activity";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 6;
    ultraGridColumn10.Width = 102;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Vdetail";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 7;
    ultraGridColumn11.Width = 94;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Alternate SubType";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ultraGridColumn12.Width = 105;
    ultraGridBand3.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((UltraGridBase) this.ugAvail).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugAvail).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance24.BackColor = Color.LightSteelBlue;
    appearance24.FontData.SizeInPoints = 10f;
    appearance24.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance24;
    appearance25.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance25.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance25.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance26.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.CellDisplayStyle = (CellDisplayStyle) 3;
    appearance27.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance28.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance28;
    appearance29.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance29;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    appearance30.BackColor = Color.Transparent;
    appearance30.ForeColor = Color.Black;
    ((UltraGridBase) this.ugAvail).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance30;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugAvail).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.ugAvail).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ugAvail).Location = new Point(10, 20);
    ((Control) this.ugAvail).Margin = new Padding(1, 1, 1, 1);
    ((Control) this.ugAvail).Name = "ugAvail";
    ((Control) this.ugAvail).Size = new Size(746, 396);
    ((Control) this.ugAvail).TabIndex = 13;
    ((Control) this.ugAvail).Text = "States  - LX Product & MVR Options";
    ((UltraControlBase) this.ugAvail).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugAvail).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(768 /*0x0300*/, 615);
    this.Controls.Add((Control) this.ddStates);
    this.Controls.Add((Control) this.grpBox);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ugAvail);
    this.Margin = new Padding(1, 1, 1, 1);
    this.Name = nameof (FormDriverProductStates);
    this.Text = "Driver /  LX Product States";
    ((ISupportInitialize) this.grpBox).EndInit();
    ((Control) this.grpBox).ResumeLayout(false);
    ((Control) this.grpBox).PerformLayout();
    ((ISupportInitialize) this.txtAlternateSubType).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtSubType).EndInit();
    ((ISupportInitialize) this.chkVdetail).EndInit();
    ((ISupportInitialize) this.chkActivity).EndInit();
    ((ISupportInitialize) this.chkClean).EndInit();
    ((ISupportInitialize) this.chkFull).EndInit();
    ((ISupportInitialize) this.comboState).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddStates).EndInit();
    ((ISupportInitialize) this.ugAvail).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ugAvail")]
  private virtual UltraGrid ugAvail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDriverRenewal ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.DbSave_ClickingNew);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.DbSave_ClickingSave);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.DbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.DbSave_ClickingCancel);
      EventHandler eventHandler = new EventHandler(this.DbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingNew -= cancelEventHandler1;
        dbSave1.ClickingSave -= cancelEventHandler2;
        dbSave1.ClickingDelete -= cancelEventHandler3;
        dbSave1.ClickingCancel -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingNew += cancelEventHandler1;
      dbSave2.ClickingSave += cancelEventHandler2;
      dbSave2.ClickingDelete += cancelEventHandler3;
      dbSave2.ClickingCancel += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("comboState")]
  protected virtual MGAComboBox comboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddStates")]
  private virtual UltraDropDown ddStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblState")]
  protected virtual Label lblState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpBox")]
  protected virtual UltraGroupBox grpBox { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblSubType")]
  protected virtual Label lblSubType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkVdetail")]
  protected virtual MGACheckBox chkVdetail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkActivity")]
  protected virtual MGACheckBox chkActivity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkClean")]
  protected virtual MGACheckBox chkClean { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("chkFull")]
  protected virtual MGACheckBox chkFull { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSubType")]
  protected virtual MGATextBox txtSubType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtAlternateSubType")]
  protected virtual MGATextBox txtAlternateSubType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAlternateSubType")]
  internal virtual Label lblAlternateSubType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblAlternateSubTypeText")]
  protected virtual Label lblAlternateSubTypeText { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("_bindingManager")]
  private virtual BindingManagerBase _bindingManager { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormDriverProductStates()
  {
    this.Load += new EventHandler(this.FormDriverProductStates_Load);
    this.InitializeComponent();
  }

  private void FormDriverProductStates_Load(object sender, EventArgs e)
  {
    this._userGuid = CurrentUser.Instance.UserGUID;
    string[] strArray = new string[2]
    {
      "lstStates",
      "tblDriverProductStates"
    };
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, "GetDriverProductStates");
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    this._bindingManager = this.BindingContext[(object) this.ds, this.ds.tblDriverProductStates.TableName];
    this._bindingManager.Position = this.ds.tblDriverProductStates.Count - 1;
    this.SetSaveState();
    this._canAdd = SecurityManager.Instance.AssertPermission("{5B033ACC-010B-4206-8DBA-B42799FAB9D4}");
    this._canSave = SecurityManager.Instance.AssertPermission("{D7C2DACD-68F8-4A25-9029-ABD76D3BAEF8}");
    this._canDelete = SecurityManager.Instance.AssertPermission("{99A56537-E6AF-493C-BF79-4AEA854EC9D0}");
  }

  private bool ValidateSave()
  {
    bool flag = true;
    if (!this._canSave)
    {
      int num = (int) MessageBox.Show("You do not have permissions to save volta states.", "Insufficient Permissions - Save Volta State", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    this.err.SetError((Control) this.comboState, string.Empty);
    if (string.IsNullOrEmpty(this.comboState.Text))
    {
      this.err.SetError((Control) this.comboState, "Select a value");
      flag = false;
    }
    return flag;
  }

  private void DbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    if (!this._canAdd)
    {
      int num = (int) MessageBox.Show("You do not have permissions to add volta states.", "Insufficient Permissions - Add Volta State", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else
    {
      dsDriverRenewal.tblDriverProductStatesRow row = this.ds.tblDriverProductStates.NewtblDriverProductStatesRow();
      row.StateID = string.Empty;
      this.ds.tblDriverProductStates.AddtblDriverProductStatesRow(row);
      this._bindingManager.Position = this.ds.tblDriverProductStates.Count - 1;
    }
  }

  private void DbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidateSave())
    {
      e.Cancel = true;
    }
    else
    {
      this.SetEmptySubTypesNullable();
      this._bindingManager.EndCurrentEdit();
      this.UpdateSambaSafetyDriverStates();
    }
  }

  private void DbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (!this._canDelete)
    {
      int num = (int) MessageBox.Show("You do not have permissions to delete volta states.", "Insufficient Permissions - Delete Volta State", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (this._bindingManager.Position < 0)
    {
      e.Cancel = true;
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this setup?", "Delete State Product Setup?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
        return;
      this.ds.tblDriverProductStates[this._bindingManager.Position].Delete();
      try
      {
        this.UpdateSambaSafetyDriverStates();
        this.SetSaveState();
      }
      catch (SqlException ex)
      {
        ProjectData.SetProjectError((Exception) ex);
        ErrorHandler.HandleError((Exception) ex);
        e.Cancel = true;
        ProjectData.ClearProjectError();
      }
    }
  }

  private void DbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.ds.tblDriverProductStates.RejectChanges();
    this.SetSaveState();
  }

  private void DbSave_UIStateChanged(object sender, EventArgs e)
  {
    ((Control) this.ugAvail).Enabled = this.dbSave.UIState != UIState.Editing;
    ((Control) this.grpBox).Enabled = this.dbSave.UIState == UIState.Editing;
    if (this.dbSave.UIState == UIState.Editing)
      return;
    if (this.ds.tblDriverProductStates.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  protected virtual void UpdateSambaSafetyDriverStates()
  {
    try
    {
      this.Cursor = MgaCursors.Working;
      using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.tblDriverProductStates, "dbo.InsertSambaDriverProductStates", "dbo.UpdateSambaDriverProductStates", "dbo.DeleteSambaDriverProductStates", true, 30, (DbTransaction) null))
        DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.tblDriverProductStates);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void SetSaveState()
  {
    if (this.ds.tblDriverProductStates.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private void SetEmptySubTypesNullable()
  {
    if (!this.ds.tblDriverProductStates[this._bindingManager.Position].IsSubTypeNull() && string.IsNullOrWhiteSpace(this.ds.tblDriverProductStates[this._bindingManager.Position].SubType))
      this.ds.tblDriverProductStates[this._bindingManager.Position].SetSubTypeNull();
    if (this.ds.tblDriverProductStates[this._bindingManager.Position].IsAlternateSubTypeNull() || this.ds.tblDriverProductStates[this._bindingManager.Position].AlternateSubType.Replace(" ", string.Empty).Length != 0)
      return;
    this.ds.tblDriverProductStates[this._bindingManager.Position].SetAlternateSubTypeNull();
  }
}
