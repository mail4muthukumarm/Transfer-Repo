// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormProducerLineBulkBlocking
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormProducerLineBulkBlocking : Form
{
  private IContainer components;
  private Thread _companyLineDataThread;
  private MemoryStream _gridLayout;
  private object _controlLock;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormProducerLineBulkBlocking));
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LocationName");
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
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("State");
    Appearance appearance17 = new Appearance();
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
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LineName");
    Appearance appearance29 = new Appearance();
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
    UltraGridBand ultraGridBand4 = new UltraGridBand("dtCompanyLines", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CompanyLocationGUID", -1, (object) "dropdownCompanies", 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LineGUID", -1, (object) "dropdownLineGuid");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("StateID", -1, (object) "dropdownStateID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Selected");
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    Appearance appearance45 = new Appearance();
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    this.dtEffective = new MGADateTimePicker();
    this.groupCombos = new UltraGroupBox();
    this.cboPolicyType = new MGASimpleComboBox();
    this.ds = new dsProducerBulkBlocking();
    this.comboProducers = new MGASimpleComboBox();
    this.comboProducerLocations = new MGASimpleComboBox();
    this.lnkPrefillLines = new LinkLabel();
    this.lnkPrefillStates = new LinkLabel();
    this.lnkPrefillCompanies = new LinkLabel();
    this.lnkApplyFilter = new LinkLabel();
    this.btnSave = new MGAButton();
    this.cboStates = new MGASimpleComboBox();
    this.cboLines = new MGASimpleComboBox();
    this.cboCompany = new MGASimpleComboBox();
    this.dropdownCompanies = new UltraDropDown();
    this.dropdownStateID = new UltraDropDown();
    this.dropdownLineGuid = new UltraDropDown();
    this.dgAddSetups = new UltraGrid();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelectAll = new LinkLabel();
    this.err = new ErrorProvider(this.components);
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    Label label5 = new Label();
    Label label6 = new Label();
    Label label7 = new Label();
    ((ISupportInitialize) this.dtEffective).BeginInit();
    ((ISupportInitialize) this.groupCombos).BeginInit();
    ((Control) this.groupCombos).SuspendLayout();
    ((ISupportInitialize) this.cboPolicyType).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.comboProducers).BeginInit();
    ((ISupportInitialize) this.comboProducerLocations).BeginInit();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.cboStates).BeginInit();
    ((ISupportInitialize) this.cboLines).BeginInit();
    ((ISupportInitialize) this.cboCompany).BeginInit();
    ((ISupportInitialize) this.dropdownCompanies).BeginInit();
    ((ISupportInitialize) this.dropdownStateID).BeginInit();
    ((ISupportInitialize) this.dropdownLineGuid).BeginInit();
    ((ISupportInitialize) this.dgAddSetups).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    label1.AutoSize = true;
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(10, 13);
    label1.Name = "Label1";
    label1.Size = new Size(53, 13);
    label1.TabIndex = 3;
    label1.Text = "Producer:";
    label2.AutoSize = true;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(11, 40);
    label2.Name = "Label5";
    label2.Size = new Size(97, 13);
    label2.TabIndex = 24;
    label2.Text = "Producer Location:";
    label3.AutoSize = true;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(435, 40);
    label3.Name = "Label6";
    label3.Size = new Size(52, 13);
    label3.TabIndex = 26;
    label3.Text = "Effective:";
    label4.AutoSize = true;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(-1, 78);
    label4.Name = "Label2";
    label4.Size = new Size(54, 13);
    label4.TabIndex = 27;
    label4.Text = "Company:";
    label5.AutoSize = true;
    label5.BackColor = Color.Transparent;
    label5.Location = new Point(323, 78);
    label5.Name = "Label3";
    label5.Size = new Size(30, 13);
    label5.TabIndex = 42;
    label5.Text = "Line:";
    label6.AutoSize = true;
    label6.BackColor = Color.Transparent;
    label6.Location = new Point(554, 78);
    label6.Name = "Label4";
    label6.Size = new Size(35, 13);
    label6.TabIndex = 43;
    label6.Text = "State:";
    label7.AutoSize = true;
    label7.BackColor = Color.Transparent;
    label7.Location = new Point(435, 13);
    label7.Name = "Label7";
    label7.Size = new Size(65, 13);
    label7.TabIndex = 28;
    label7.Text = "Policy Type:";
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.dtEffective.Appearance = (AppearanceBase) appearance1;
    appearance2.AlphaLevel = (short) 14;
    appearance2.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance2.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance2.BackColorAlpha = (Alpha) 2;
    appearance2.BackGradientAlignment = (GradientAlignment) 4;
    appearance2.BackGradientStyle = (GradientStyle) 5;
    appearance2.BorderAlpha = (Alpha) 1;
    appearance2.BorderColor = Color.FromArgb(78, 122, 171);
    appearance2.ForeColor = Color.FromArgb(49, 85, 153);
    appearance2.ForegroundAlpha = (Alpha) 2;
    this.dtEffective.ButtonAppearance = (AppearanceBase) appearance2;
    ((Control) this.dtEffective).Location = new Point(506, 37);
    this.dtEffective.MGAStyle = MGAStyles.Blue;
    ((Control) this.dtEffective).Name = "dtEffective";
    ((Control) this.dtEffective).Size = new Size(84, 19);
    ((Control) this.dtEffective).TabIndex = 25;
    ((UltraControlBase) this.dtEffective).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEffective).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.groupCombos).Controls.Add((Control) label7);
    ((Control) this.groupCombos).Controls.Add((Control) this.cboPolicyType);
    ((Control) this.groupCombos).Controls.Add((Control) this.comboProducers);
    ((Control) this.groupCombos).Controls.Add((Control) label1);
    ((Control) this.groupCombos).Controls.Add((Control) label3);
    ((Control) this.groupCombos).Controls.Add((Control) this.comboProducerLocations);
    ((Control) this.groupCombos).Controls.Add((Control) label2);
    ((Control) this.groupCombos).Controls.Add((Control) this.dtEffective);
    ((Control) this.groupCombos).Location = new Point(2, 3);
    ((Control) this.groupCombos).Name = "groupCombos";
    ((Control) this.groupCombos).Size = new Size(716, 66);
    ((Control) this.groupCombos).TabIndex = 34;
    this.groupCombos.ViewStyle = (GroupBoxViewStyle) 3;
    this.cboPolicyType.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboPolicyType).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.cboPolicyType).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboPolicyType).DisplayMember = "Description";
    this.cboPolicyType.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboPolicyType).DropDownWidth = 350;
    ((Control) this.cboPolicyType).Location = new Point(506, 9);
    this.cboPolicyType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPolicyType).Name = "cboPolicyType";
    ((Control) this.cboPolicyType).Size = new Size(201, 20);
    ((Control) this.cboPolicyType).TabIndex = 27;
    ((UltraControlBase) this.cboPolicyType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPolicyType).ValueMember = "PolicyTypeID";
    this.ds.DataSetName = "dsProducerBulkBlocking";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.comboProducers.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboProducers).DataMember = "tblProducers";
    ((UltraGridBase) this.comboProducers).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboProducers).DisplayMember = "ProducerName";
    this.comboProducers.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboProducers).DropDownWidth = 350;
    ((Control) this.comboProducers).Location = new Point(114, 9);
    this.comboProducers.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboProducers).Name = "comboProducers";
    ((Control) this.comboProducers).Size = new Size(303, 20);
    ((Control) this.comboProducers).TabIndex = 2;
    ((UltraControlBase) this.comboProducers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboProducers).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboProducers).ValueMember = "ProducerGUID";
    this.comboProducerLocations.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.comboProducerLocations).DataMember = "tblProducerLocations";
    ((UltraGridBase) this.comboProducerLocations).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboProducerLocations).DisplayMember = "Name";
    this.comboProducerLocations.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.comboProducerLocations).DropDownWidth = 500;
    ((Control) this.comboProducerLocations).Location = new Point(114, 36);
    this.comboProducerLocations.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboProducerLocations).Name = "comboProducerLocations";
    ((Control) this.comboProducerLocations).Size = new Size(303, 20);
    ((Control) this.comboProducerLocations).TabIndex = 23;
    ((UltraControlBase) this.comboProducerLocations).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboProducerLocations).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.comboProducerLocations).ValueMember = "ProducerLocationGUID";
    this.lnkPrefillLines.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkPrefillLines.AutoSize = true;
    this.lnkPrefillLines.Location = new Point(12, 542);
    this.lnkPrefillLines.Name = "lnkPrefillLines";
    this.lnkPrefillLines.Size = new Size(74, 13);
    this.lnkPrefillLines.TabIndex = 36;
    this.lnkPrefillLines.TabStop = true;
    this.lnkPrefillLines.Text = "Prefill All Lines";
    this.lnkPrefillStates.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkPrefillStates.AutoSize = true;
    this.lnkPrefillStates.Location = new Point(12, 568);
    this.lnkPrefillStates.Name = "lnkPrefillStates";
    this.lnkPrefillStates.Size = new Size(79, 13);
    this.lnkPrefillStates.TabIndex = 37;
    this.lnkPrefillStates.TabStop = true;
    this.lnkPrefillStates.Text = "Prefill All States";
    this.lnkPrefillCompanies.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkPrefillCompanies.AutoSize = true;
    this.lnkPrefillCompanies.Location = new Point(12, 594);
    this.lnkPrefillCompanies.Name = "lnkPrefillCompanies";
    this.lnkPrefillCompanies.Size = new Size(101, 13);
    this.lnkPrefillCompanies.TabIndex = 38;
    this.lnkPrefillCompanies.TabStop = true;
    this.lnkPrefillCompanies.Text = "Prefill All Companies";
    this.lnkApplyFilter.AutoSize = true;
    this.lnkApplyFilter.Location = new Point(323, 141);
    this.lnkApplyFilter.Name = "lnkApplyFilter";
    this.lnkApplyFilter.Size = new Size(58, 13);
    this.lnkApplyFilter.TabIndex = 44;
    this.lnkApplyFilter.TabStop = true;
    this.lnkApplyFilter.Text = "Apply Filter";
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance3.Image"));
    appearance3.ImageHAlign = (HAlign) 1;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnSave).Location = new Point(616, 569);
    ((Control) this.btnSave).Margin = new Padding(4);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(92, 33);
    ((Control) this.btnSave).TabIndex = 246;
    ((ControlBase) this.btnSave).Text = "Save Setups";
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.cboStates.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboStates).DataMember = "lstStates";
    ((UltraGridBase) this.cboStates).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboStates).DisplayMember = "State";
    this.cboStates.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboStates).DropDownWidth = 200;
    ((Control) this.cboStates).Location = new Point(557, 104);
    this.cboStates.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboStates).Name = "cboStates";
    ((Control) this.cboStates).Size = new Size(161, 20);
    ((Control) this.cboStates).TabIndex = 41;
    ((UltraControlBase) this.cboStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboStates).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboStates).ValueMember = "StateID";
    this.cboLines.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboLines).DataMember = "lstLines";
    ((UltraGridBase) this.cboLines).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboLines).DisplayMember = "LineName";
    this.cboLines.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLines).DropDownWidth = 300;
    ((Control) this.cboLines).Location = new Point(326, 104);
    this.cboLines.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLines).Name = "cboLines";
    ((Control) this.cboLines).Size = new Size(225, 20);
    ((Control) this.cboLines).TabIndex = 40;
    ((UltraControlBase) this.cboLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLines).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLines).ValueMember = "LineGUID";
    this.cboCompany.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraControlBase) this.cboCompany).Cursor = Cursors.Default;
    ((UltraGridBase) this.cboCompany).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cboCompany).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboCompany).DisplayMember = "LocationName";
    this.cboCompany.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompany).DropDownWidth = 500;
    ((Control) this.cboCompany).Location = new Point(2, 104);
    this.cboCompany.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompany).Name = "cboCompany";
    ((Control) this.cboCompany).Size = new Size(318, 20);
    ((Control) this.cboCompany).TabIndex = 27;
    ((UltraControlBase) this.cboCompany).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompany).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompany).ValueMember = "CompanyLocationGUID";
    ((UltraGridBase) this.dropdownCompanies).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.dropdownCompanies).DataSource = (object) this.ds;
    appearance4.BackColor = SystemColors.Window;
    appearance4.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Company Location";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 450;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance5.BackColor = SystemColors.ActiveBorder;
    appearance5.BackColor2 = SystemColors.ControlDark;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownCompanies).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance5;
    appearance6.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance6;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownCompanies).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance7.BackColor = SystemColors.ControlLightLight;
    appearance7.BackColor2 = SystemColors.Control;
    appearance7.BackGradientStyle = (GradientStyle) 3;
    appearance7.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.MaxRowScrollRegions = 1;
    appearance8.BackColor = SystemColors.Window;
    appearance8.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = SystemColors.Highlight;
    appearance9.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance10.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.Silver;
    appearance11.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.CellPadding = 0;
    appearance12.BackColor = SystemColors.Control;
    appearance12.BackColor2 = SystemColors.ControlDark;
    appearance12.BackGradientAlignment = (GradientAlignment) 1;
    appearance12.BackGradientStyle = (GradientStyle) 3;
    appearance12.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance12;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance14.BackColor = SystemColors.Window;
    appearance14.BorderColor = Color.Silver;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance15.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropdownCompanies).DisplayMember = "LocationName";
    ((UltraDropDownBase) this.dropdownCompanies).DropDownWidth = 450;
    ((Control) this.dropdownCompanies).Location = new Point(245, 269);
    ((Control) this.dropdownCompanies).Name = "dropdownCompanies";
    ((Control) this.dropdownCompanies).Size = new Size(174, 54);
    ((Control) this.dropdownCompanies).TabIndex = 33;
    ((UltraDropDownBase) this.dropdownCompanies).ValueMember = "CompanyLocationGUID";
    ((Control) this.dropdownCompanies).Visible = false;
    ((UltraGridBase) this.dropdownStateID).DataMember = "lstStates";
    ((UltraGridBase) this.dropdownStateID).DataSource = (object) this.ds;
    appearance16.BackColor = SystemColors.Window;
    appearance16.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Appearance = (AppearanceBase) appearance16;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 190;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance17.BackColor = SystemColors.ActiveBorder;
    appearance17.BackColor2 = SystemColors.ControlDark;
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownStateID).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance17;
    appearance18.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance18;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownStateID).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance19.BackColor = SystemColors.ControlLightLight;
    appearance19.BackColor2 = SystemColors.Control;
    appearance19.BackGradientStyle = (GradientStyle) 3;
    appearance19.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.MaxRowScrollRegions = 1;
    appearance20.BackColor = SystemColors.Window;
    appearance20.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = SystemColors.Highlight;
    appearance21.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance22.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance22;
    appearance23.BorderColor = Color.Silver;
    appearance23.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.CellPadding = 0;
    appearance24.BackColor = SystemColors.Control;
    appearance24.BackColor2 = SystemColors.ControlDark;
    appearance24.BackGradientAlignment = (GradientAlignment) 1;
    appearance24.BackGradientStyle = (GradientStyle) 3;
    appearance24.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance24;
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance26.BackColor = SystemColors.Window;
    appearance26.BorderColor = Color.Silver;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance27.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropdownStateID).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropdownStateID).DisplayMember = "State";
    ((Control) this.dropdownStateID).Location = new Point(41, 281);
    ((Control) this.dropdownStateID).Name = "dropdownStateID";
    ((Control) this.dropdownStateID).Size = new Size(174, 54);
    ((Control) this.dropdownStateID).TabIndex = 30;
    ((Control) this.dropdownStateID).Text = "UltraDropDown3";
    ((UltraDropDownBase) this.dropdownStateID).ValueMember = "StateID";
    ((Control) this.dropdownStateID).Visible = false;
    ((UltraGridBase) this.dropdownLineGuid).DataMember = "lstLines";
    ((UltraGridBase) this.dropdownLineGuid).DataSource = (object) this.ds;
    appearance28.BackColor = SystemColors.Window;
    appearance28.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Appearance = (AppearanceBase) appearance28;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 216;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance29.BackColor = SystemColors.ActiveBorder;
    appearance29.BackColor2 = SystemColors.ControlDark;
    appearance29.BackGradientStyle = (GradientStyle) 2;
    appearance29.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance29;
    appearance30.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance30;
    ((SpecialBoxBase) ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance31.BackColor = SystemColors.ControlLightLight;
    appearance31.BackColor2 = SystemColors.Control;
    appearance31.BackGradientStyle = (GradientStyle) 3;
    appearance31.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance31;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.MaxRowScrollRegions = 1;
    appearance32.BackColor = SystemColors.Window;
    appearance32.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance32;
    appearance33.BackColor = SystemColors.Highlight;
    appearance33.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance33;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance34.BackColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance34;
    appearance35.BorderColor = Color.Silver;
    appearance35.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.CellPadding = 0;
    appearance36.BackColor = SystemColors.Control;
    appearance36.BackColor2 = SystemColors.ControlDark;
    appearance36.BackGradientAlignment = (GradientAlignment) 1;
    appearance36.BackGradientStyle = (GradientStyle) 3;
    appearance36.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance36;
    ((AppearanceBase) appearance37).TextHAlignAsString = "Left";
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance38.BackColor = SystemColors.Window;
    appearance38.BorderColor = Color.Silver;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance38;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance39.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.dropdownLineGuid).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.dropdownLineGuid).DisplayMember = "LineName";
    ((Control) this.dropdownLineGuid).Location = new Point(440, 254);
    ((Control) this.dropdownLineGuid).Name = "dropdownLineGuid";
    ((Control) this.dropdownLineGuid).Size = new Size(174, 59);
    ((Control) this.dropdownLineGuid).TabIndex = 29;
    ((Control) this.dropdownLineGuid).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.dropdownLineGuid).ValueMember = "LineGUID";
    ((Control) this.dropdownLineGuid).Visible = false;
    ((Control) this.dgAddSetups).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgAddSetups).DataMember = "dtCompanyLines";
    ((UltraGridBase) this.dgAddSetups).DataSource = (object) this.ds;
    ((SpecialBoxBase) ((UltraGridBase) this.dgAddSetups).DisplayLayout.AddNewBox).Hidden = false;
    appearance40.BackColor = Color.White;
    appearance40.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Appearance = (AppearanceBase) appearance40;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.AddButtonCaption = "Producer Blocking Setups";
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Company Location";
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Style = (ColumnStyle) 6;
    ultraGridColumn7.Width = 301;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Line";
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Style = (ColumnStyle) 6;
    ultraGridColumn8.Width = 204;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "State";
    ultraGridColumn9.Header.VisiblePosition = 2;
    ultraGridColumn9.Style = (ColumnStyle) 6;
    ultraGridColumn9.Width = 134;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Select";
    ultraGridColumn10.Header.VisiblePosition = 3;
    ultraGridColumn10.Width = 56;
    ultraGridBand4.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance41.BackColor = Color.LightSteelBlue;
    appearance41.FontData.SizeInPoints = 10f;
    appearance41.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance41;
    appearance42.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance42.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance42.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance42;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance43.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance43;
    appearance44.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance44;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance45.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance45;
    appearance46.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance46;
    appearance47.BackColor = Color.Transparent;
    appearance47.ForeColor = Color.Black;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance47;
    appearance48.BackColor = Color.WhiteSmoke;
    appearance48.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance48;
    appearance49.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance49;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 2;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dgAddSetups).Location = new Point(2, 167);
    ((Control) this.dgAddSetups).Name = "dgAddSetups";
    ((Control) this.dgAddSetups).Size = new Size(716, 362);
    ((Control) this.dgAddSetups).TabIndex = 20;
    ((Control) this.dgAddSetups).Text = "Available Company/ Line / States";
    ((UltraControlBase) this.dgAddSetups).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgAddSetups).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(164, 542);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(51, 13);
    this.lnkSelectAll.TabIndex = 247;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.Location = new Point(164, 568);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(68, 13);
    this.lnkDeSelectAll.TabIndex = 248;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All";
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(721, 615);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.lnkApplyFilter);
    this.Controls.Add((Control) label6);
    this.Controls.Add((Control) label5);
    this.Controls.Add((Control) label4);
    this.Controls.Add((Control) this.cboStates);
    this.Controls.Add((Control) this.cboLines);
    this.Controls.Add((Control) this.cboCompany);
    this.Controls.Add((Control) this.lnkPrefillCompanies);
    this.Controls.Add((Control) this.lnkPrefillStates);
    this.Controls.Add((Control) this.lnkPrefillLines);
    this.Controls.Add((Control) this.dropdownCompanies);
    this.Controls.Add((Control) this.dropdownStateID);
    this.Controls.Add((Control) this.dropdownLineGuid);
    this.Controls.Add((Control) this.groupCombos);
    this.Controls.Add((Control) this.dgAddSetups);
    this.Name = nameof (FormProducerLineBulkBlocking);
    this.Text = "Producer Line Blocking by Bulk";
    ((ISupportInitialize) this.dtEffective).EndInit();
    ((ISupportInitialize) this.groupCombos).EndInit();
    ((Control) this.groupCombos).ResumeLayout(false);
    ((Control) this.groupCombos).PerformLayout();
    ((ISupportInitialize) this.cboPolicyType).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.comboProducers).EndInit();
    ((ISupportInitialize) this.comboProducerLocations).EndInit();
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.cboStates).EndInit();
    ((ISupportInitialize) this.cboLines).EndInit();
    ((ISupportInitialize) this.cboCompany).EndInit();
    ((ISupportInitialize) this.dropdownCompanies).EndInit();
    ((ISupportInitialize) this.dropdownStateID).EndInit();
    ((ISupportInitialize) this.dropdownLineGuid).EndInit();
    ((ISupportInitialize) this.dgAddSetups).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("comboProducers")]
  private virtual MGASimpleComboBox comboProducers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgAddSetups")]
  private virtual UltraGrid dgAddSetups { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("comboProducerLocations")]
  private virtual MGASimpleComboBox comboProducerLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEffective")]
  internal virtual MGADateTimePicker dtEffective { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dropdownCompanies")]
  private virtual UltraDropDown dropdownCompanies { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dropdownStateID")]
  private virtual UltraDropDown dropdownStateID { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dropdownLineGuid")]
  private virtual UltraDropDown dropdownLineGuid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("groupCombos")]
  private virtual UltraGroupBox groupCombos { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsProducerBulkBlocking ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkPrefillLines
  {
    get => this._lnkPrefillLines;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPrefillLines_LinkClicked);
      LinkLabel lnkPrefillLines1 = this._lnkPrefillLines;
      if (lnkPrefillLines1 != null)
        lnkPrefillLines1.LinkClicked -= clickedEventHandler;
      this._lnkPrefillLines = value;
      LinkLabel lnkPrefillLines2 = this._lnkPrefillLines;
      if (lnkPrefillLines2 == null)
        return;
      lnkPrefillLines2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkPrefillStates
  {
    get => this._lnkPrefillStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPrefillStates_LinkClicked);
      LinkLabel lnkPrefillStates1 = this._lnkPrefillStates;
      if (lnkPrefillStates1 != null)
        lnkPrefillStates1.LinkClicked -= clickedEventHandler;
      this._lnkPrefillStates = value;
      LinkLabel lnkPrefillStates2 = this._lnkPrefillStates;
      if (lnkPrefillStates2 == null)
        return;
      lnkPrefillStates2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkPrefillCompanies
  {
    get => this._lnkPrefillCompanies;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkPrefillCompanies_LinkClicked);
      LinkLabel prefillCompanies1 = this._lnkPrefillCompanies;
      if (prefillCompanies1 != null)
        prefillCompanies1.LinkClicked -= clickedEventHandler;
      this._lnkPrefillCompanies = value;
      LinkLabel prefillCompanies2 = this._lnkPrefillCompanies;
      if (prefillCompanies2 == null)
        return;
      prefillCompanies2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("cboCompany")]
  private virtual MGASimpleComboBox cboCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLines")]
  private virtual MGASimpleComboBox cboLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboStates")]
  private virtual MGASimpleComboBox cboStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkApplyFilter
  {
    get => this._lnkApplyFilter;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkApplyFilter_LinkClicked);
      LinkLabel lnkApplyFilter1 = this._lnkApplyFilter;
      if (lnkApplyFilter1 != null)
        lnkApplyFilter1.LinkClicked -= clickedEventHandler;
      this._lnkApplyFilter = value;
      LinkLabel lnkApplyFilter2 = this._lnkApplyFilter;
      if (lnkApplyFilter2 == null)
        return;
      lnkApplyFilter2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("cboPolicyType")]
  private virtual MGASimpleComboBox cboPolicyType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSave_Click);
      MGAButton btnSave1 = this._btnSave;
      if (btnSave1 != null)
        ((Control) btnSave1).Click -= eventHandler;
      this._btnSave = value;
      MGAButton btnSave2 = this._btnSave;
      if (btnSave2 == null)
        return;
      ((Control) btnSave2).Click += eventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAll
  {
    get => this._lnkSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAll_LinkClicked);
      LinkLabel lnkSelectAll1 = this._lnkSelectAll;
      if (lnkSelectAll1 != null)
        lnkSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAll = value;
      LinkLabel lnkSelectAll2 = this._lnkSelectAll;
      if (lnkSelectAll2 == null)
        return;
      lnkSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeSelectAll
  {
    get => this._lnkDeSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAll_LinkClicked);
      LinkLabel lnkDeSelectAll1 = this._lnkDeSelectAll;
      if (lnkDeSelectAll1 != null)
        lnkDeSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAll = value;
      LinkLabel lnkDeSelectAll2 = this._lnkDeSelectAll;
      if (lnkDeSelectAll2 == null)
        return;
      lnkDeSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormProducerLineBulkBlocking()
  {
    this.Load += new EventHandler(this.FormProducerLineBulkBlocking_Load);
    this._gridLayout = new MemoryStream();
    this._controlLock = RuntimeHelpers.GetObjectValue(new object());
    this.InitializeComponent();
  }

  private void FormProducerLineBulkBlocking_Load(object sender, EventArgs e)
  {
    this.Cursor = MgaCursors.WaitCursor;
    ThreadPool.QueueUserWorkItem(new WaitCallback(this.ThreadedFill));
  }

  private void ThreadedFill(object state)
  {
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[6]
      {
        this.ds.tblProducers.TableName,
        this.ds.tblProducerLocations.TableName,
        this.ds.lstLines.TableName,
        this.ds.lstStates.TableName,
        this.ds.lstPolicyTypes.TableName,
        this.ds.tblCompanyLocations.TableName
      }, "dbo.BulkProducerLineBlockingData");
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    MDIControls.Instance.MDIParent.Invoke((Delegate) new FormProducerLineBulkBlocking.ThreadedFillCompleteHandler(this.ThreadedFillComplete));
  }

  private void ThreadedFillComplete()
  {
    ((UltraGridBase) this.comboProducers).DataMember = "tblProducers";
    ((UltraGridBase) this.comboProducers).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboProducers).DisplayMember = "ProducerName";
    ((UltraDropDownBase) this.comboProducers).ValueMember = "ProducerGUID";
    ((UltraGridBase) this.comboProducerLocations).DataMember = "tblProducerLocations";
    ((UltraGridBase) this.comboProducerLocations).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.comboProducerLocations).DisplayMember = "Name";
    ((UltraDropDownBase) this.comboProducerLocations).ValueMember = "ProducerLocationGUID";
    ((UltraGridBase) this.cboPolicyType).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.cboPolicyType).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboPolicyType).DisplayMember = "Description";
    ((UltraDropDownBase) this.cboPolicyType).ValueMember = "PolicyTypeID";
    this.Cursor = MgaCursors.Default;
  }

  private void lnkPrefillLines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ds.dtCompanyLines.Clear();
    try
    {
      foreach (dsProducerBulkBlocking.lstLinesRow row1 in this.ds.lstLines.Rows)
      {
        dsProducerBulkBlocking.dtCompanyLinesRow row2 = this.ds.dtCompanyLines.NewdtCompanyLinesRow();
        row2.LineGUID = row1.LineGUID;
        this.ds.dtCompanyLines.AdddtCompanyLinesRow(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.SelectDeSelect(false);
  }

  private void lnkPrefillStates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ds.dtCompanyLines.Clear();
    try
    {
      foreach (dsProducerBulkBlocking.lstStatesRow row1 in this.ds.lstStates.Rows)
      {
        dsProducerBulkBlocking.dtCompanyLinesRow row2 = this.ds.dtCompanyLines.NewdtCompanyLinesRow();
        row2.StateID = row1.StateID;
        this.ds.dtCompanyLines.AdddtCompanyLinesRow(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.SelectDeSelect(false);
  }

  private void lnkPrefillCompanies_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ds.dtCompanyLines.Clear();
    try
    {
      foreach (dsProducerBulkBlocking.tblCompanyLocationsRow row1 in this.ds.tblCompanyLocations.Rows)
      {
        dsProducerBulkBlocking.dtCompanyLinesRow row2 = this.ds.dtCompanyLines.NewdtCompanyLinesRow();
        row2.CompanyLocationGUID = row1.CompanyLocationGUID;
        this.ds.dtCompanyLines.AdddtCompanyLinesRow(row2);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.SelectDeSelect(false);
  }

  private void lnkApplyFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((Control) this.cboCompany).Enabled = false;
    ((Control) this.cboStates).Enabled = false;
    ((Control) this.cboLines).Enabled = false;
    ((Control) this.btnSave).Enabled = false;
    ((UltraGridBase) this.dgAddSetups).DisplayLayout.Save((Stream) this._gridLayout);
    if (this._companyLineDataThread != null && this._companyLineDataThread.IsAlive)
      this._companyLineDataThread.Abort();
    Cursor.Current = MgaCursors.Working;
    this._companyLineDataThread = new Thread(new ThreadStart(this.FillCompanyLines));
    this._companyLineDataThread.Name = "FillCompanyLines";
    this._companyLineDataThread.IsBackground = true;
    this._companyLineDataThread.Start();
  }

  private void FillCompanyLines()
  {
    this.ds.dtCompanyLines.Clear();
    object obj1 = (object) null;
    object obj2 = (object) null;
    object obj3 = (object) null;
    object controlLock = this._controlLock;
    ObjectFlowControl.CheckForSyncLockOnValueType(controlLock);
    bool lockTaken = false;
    try
    {
      Monitor.Enter(controlLock, ref lockTaken);
      obj1 = RuntimeHelpers.GetObjectValue(this.cboCompany.Value);
      obj2 = RuntimeHelpers.GetObjectValue(this.cboLines.Value);
      obj3 = RuntimeHelpers.GetObjectValue(this.cboStates.Value);
    }
    finally
    {
      if (lockTaken)
        Monitor.Exit(controlLock);
    }
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
      {
        this.ds.dtCompanyLines.TableName
      }, "dbo.GetCompanyLineProducerBlockingData", new object[6]
      {
        (object) "@CompanyLocationGuid",
        obj1,
        (object) "@LineGuid",
        obj2,
        (object) "@StateID",
        obj3
      });
    }
    catch (Exception ex)
    {
      ProjectData.SetProjectError(ex);
      ProjectData.ClearProjectError();
    }
    MDIControls.Instance.MDIParent.Invoke((Delegate) new FormProducerLineBulkBlocking.CompanyLineDataThreadCompleteHandler(this.CompanyLineDataThreadComplete));
  }

  private void CompanyLineDataThreadComplete()
  {
    ((Control) this.cboCompany).Enabled = true;
    ((Control) this.cboStates).Enabled = true;
    ((Control) this.cboLines).Enabled = true;
    ((Control) this.btnSave).Enabled = true;
    this.SelectDeSelect(false);
    ((UltraGridBase) this.dropdownCompanies).DisplayLayout.Bands[0].Columns["LocationName"].SortIndicator = (SortIndicator) 1;
  }

  private void SelectDeSelect(bool valSelect)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.dgAddSetups).Rows)
      row.Cells["Selected"].Value = (object) valSelect;
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectDeSelect(true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectDeSelect(false);
  }

  private bool IsValidSetup()
  {
    bool flag = true;
    this.err.SetError((Control) this.comboProducerLocations, string.Empty);
    this.err.SetError((Control) this.comboProducers, string.Empty);
    this.err.SetError((Control) this.dtEffective, string.Empty);
    if (this.comboProducerLocations.Value != null && this.comboProducerLocations.Value != DBNull.Value && this.comboProducers.Value != null && this.comboProducers.Value != DBNull.Value)
    {
      this.err.SetError((Control) this.comboProducerLocations, "Both cannot be filled in.");
      this.err.SetError((Control) this.comboProducers, "Both cannot be filled in.");
      flag = false;
    }
    if ((this.comboProducerLocations.Value == null || this.comboProducerLocations.Value == DBNull.Value) && (this.comboProducers.Value == null || this.comboProducers.Value == DBNull.Value))
    {
      this.err.SetError((Control) this.comboProducerLocations, "Please select a producer or a location.");
      this.err.SetError((Control) this.comboProducers, "Please select a producer or a location..");
      flag = false;
    }
    if (this.dtEffective.Value == null | this.dtEffective.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.dtEffective, "Please enter a value.");
      flag = false;
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValidSetup())
      return;
    string str1 = string.Empty;
    int num1 = 0;
    int num2 = 0;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        foreach (dsProducerBulkBlocking.dtCompanyLinesRow row in this.ds.dtCompanyLines.Rows)
        {
          if (row.Selected)
          {
            ++num1;
            string str2 = "$$";
            string str3 = "00000000-0000-0000-0000-000000000000";
            string str4 = "00000000-0000-0000-0000-000000000000";
            if (!row.IsCompanyLocationGUIDNull())
              str4 = row.CompanyLocationGUID.ToString();
            if (!row.IsLineGUIDNull())
              str3 = row.LineGUID.ToString();
            if (!row.IsStateIDNull())
              str2 = row.StateID;
            str1 = $"{str1}{str4}/{str3}/{str2},";
          }
          if (str1.Length > 7000)
          {
            num2 += Conversions.ToInteger(DefaultDatabase.ExecuteScalar("dbo.SaveProducerBlockingSetup", new object[10]
            {
              (object) "@ProducerLocationGuid",
              this.comboProducerLocations.Value,
              (object) "@ProducerGuid",
              this.comboProducers.Value,
              (object) "@EffectiveDate",
              this.dtEffective.Value,
              (object) "@PolicyTypeID",
              this.cboPolicyType.Value,
              (object) "@CompanyLineStateBlob",
              (object) str1
            }));
            str1 = string.Empty;
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (num1 == 0)
      {
        int num3 = (int) MessageBox.Show("No row is selected", "No Selected Rows", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        if (str1.Length > 0)
          num2 += Conversions.ToInteger(DefaultDatabase.ExecuteScalar("dbo.SaveProducerBlockingSetup", new object[10]
          {
            (object) "@ProducerLocationGuid",
            this.comboProducerLocations.Value,
            (object) "@ProducerGuid",
            this.comboProducers.Value,
            (object) "@EffectiveDate",
            this.dtEffective.Value,
            (object) "@PolicyTypeID",
            this.cboPolicyType.Value,
            (object) "@CompanyLineStateBlob",
            (object) str1
          }));
        int num4 = (int) MessageBox.Show($"{Conversions.ToString(num2)} of {Conversions.ToString(num1)} rows were updated", "Bulk Producer Lines Blocking", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private delegate void ThreadedFillCompleteHandler();

  private delegate void FilterGridThreadCompleteHandler();

  private delegate void CompanyLineDataThreadCompleteHandler();
}
