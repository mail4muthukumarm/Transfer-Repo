// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormBaseProgramCodeParticipation
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
public class FormBaseProgramCodeParticipation : Form
{
  private IContainer components;
  private readonly int _ProgramID;
  private BindingManagerBase _bmb;
  private readonly object _effectiveDate;
  private readonly object _expirationDate;

  [DebuggerStepThrough]
  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLocationID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LocationName");
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyProgramParticpation_Base", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ProgramID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLocationID", -1, (object) "ddCompanyLocations");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Share");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("StartDate");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("EndDate");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Commission");
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
    Appearance appearance17 = new Appearance();
    this.ddCompanyLocations = new UltraDropDown();
    this.ds = new dsProgCodeExt();
    this.dgParticipation = new UltraGrid();
    this.grpDetails = new GroupBox();
    this.Label5 = new Label();
    this.numCommission = new MGANumericEditor();
    this.label4 = new Label();
    this.cboCompanyLocation = new MGASimpleComboBox();
    this.numShare = new MGANumericEditor();
    this.label3 = new Label();
    this.label1 = new Label();
    this.dtEndDate = new MGADateTimePicker();
    this.label2 = new Label();
    this.dtStartDate = new MGADateTimePicker();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.err = new ErrorProvider(this.components);
    ((ISupportInitialize) this.ddCompanyLocations).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dgParticipation).BeginInit();
    this.grpDetails.SuspendLayout();
    ((ISupportInitialize) this.numCommission).BeginInit();
    ((ISupportInitialize) this.cboCompanyLocation).BeginInit();
    ((ISupportInitialize) this.numShare).BeginInit();
    ((ISupportInitialize) this.dtEndDate).BeginInit();
    ((ISupportInitialize) this.dtStartDate).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    this.SuspendLayout();
    ((Control) this.ddCompanyLocations).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddCompanyLocations).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.ddCompanyLocations).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddCompanyLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddCompanyLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddCompanyLocations).DisplayMember = "LocationName";
    ((UltraDropDownBase) this.ddCompanyLocations).DropDownWidth = 400;
    ((Control) this.ddCompanyLocations).Location = new Point(236, 129);
    ((Control) this.ddCompanyLocations).Name = "ddCompanyLocations";
    ((Control) this.ddCompanyLocations).Size = new Size(121, 93);
    ((Control) this.ddCompanyLocations).TabIndex = 221;
    ((Control) this.ddCompanyLocations).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddCompanyLocations).ValueMember = "CompanyLocationID";
    ((Control) this.ddCompanyLocations).Visible = false;
    this.ds.DataSetName = "dsProgCodeExt";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.dgParticipation).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgParticipation).DataMember = "tblCompanyProgramParticpation_Base";
    ((UltraGridBase) this.dgParticipation).DataSource = (object) this.ds;
    appearance1.FontData.BoldAsString = "False";
    appearance1.FontData.UnderlineAsString = "True";
    ((SpecialBoxBase) ((UltraGridBase) this.dgParticipation).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance1;
    ((SpecialBoxBase) ((UltraGridBase) this.dgParticipation).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.dgParticipation).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 69;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 66;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Company Location";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Width = 261;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Right";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 69;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Start";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridColumn7.Width = 59;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "End";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ultraGridColumn8.Width = 63 /*0x3F*/;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn9.CellAppearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 6;
    ultraGridColumn9.Width = 68;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ((UltraGridBase) this.dgParticipation).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgParticipation).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((Control) this.dgParticipation).Font = new Font("Tahoma", 8.25f);
    ((Control) this.dgParticipation).Location = new Point(9, 12);
    ((Control) this.dgParticipation).Name = "dgParticipation";
    ((Control) this.dgParticipation).Size = new Size(522, 332);
    ((Control) this.dgParticipation).TabIndex = 220;
    ((Control) this.dgParticipation).Text = "Program Codes Participation";
    ((UltraControlBase) this.dgParticipation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgParticipation).UseOsThemes = (DefaultableBoolean) 2;
    this.grpDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.grpDetails.Controls.Add((Control) this.Label5);
    this.grpDetails.Controls.Add((Control) this.numCommission);
    this.grpDetails.Controls.Add((Control) this.label4);
    this.grpDetails.Controls.Add((Control) this.cboCompanyLocation);
    this.grpDetails.Controls.Add((Control) this.numShare);
    this.grpDetails.Controls.Add((Control) this.label3);
    this.grpDetails.Controls.Add((Control) this.label1);
    this.grpDetails.Controls.Add((Control) this.dtEndDate);
    this.grpDetails.Controls.Add((Control) this.label2);
    this.grpDetails.Controls.Add((Control) this.dtStartDate);
    this.grpDetails.Location = new Point(12, 350);
    this.grpDetails.Name = "grpDetails";
    this.grpDetails.Size = new Size(519, 134);
    this.grpDetails.TabIndex = 223;
    this.grpDetails.TabStop = false;
    this.grpDetails.Text = "Participation Details";
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(334, 101);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(65, 13);
    this.Label5.TabIndex = 40;
    this.Label5.Text = "Commission:";
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numCommission).Appearance = (AppearanceBase) appearance12;
    ((Control) this.numCommission).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyProgramParticpation_Base.Commission", true));
    ((UltraNumericEditorBase) this.numCommission).FormatString = "";
    ((Control) this.numCommission).Location = new Point(421, 98);
    ((UltraNumericEditor) this.numCommission).MaskInput = "nnn.nnnnnnn";
    this.numCommission.MGAStyle = (MGAStyles) 2;
    ((Control) this.numCommission).Name = "numCommission";
    ((UltraNumericEditor) this.numCommission).Nullable = true;
    ((UltraNumericEditor) this.numCommission).NumericType = (NumericType) 2;
    ((Control) this.numCommission).Size = new Size(80 /*0x50*/, 19);
    ((Control) this.numCommission).TabIndex = 4;
    ((UltraWinEditorMaskedControlBase) this.numCommission).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numCommission).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numCommission).UseOsThemes = (DefaultableBoolean) 2;
    this.label4.AutoSize = true;
    this.label4.Location = new Point(334, 60);
    this.label4.Name = "label4";
    this.label4.Size = new Size(38, 13);
    this.label4.TabIndex = 38;
    this.label4.Text = "Share:";
    ((UltraCombo) this.cboCompanyLocation).BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboCompanyLocation).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyProgramParticpation_Base.CompanyLocationID", true));
    ((UltraGridBase) this.cboCompanyLocation).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cboCompanyLocation).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboCompanyLocation).DisplayMember = "LocationName";
    ((UltraCombo) this.cboCompanyLocation).DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanyLocation).DropDownWidth = 500;
    ((Control) this.cboCompanyLocation).Location = new Point(113, 15);
    this.cboCompanyLocation.MGAStyle = (MGAStyles) 2;
    ((Control) this.cboCompanyLocation).Name = "cboCompanyLocation";
    ((Control) this.cboCompanyLocation).Size = new Size(388, 20);
    ((Control) this.cboCompanyLocation).TabIndex = 0;
    ((UltraControlBase) this.cboCompanyLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanyLocation).ValueMember = "CompanyLocationID";
    appearance13.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numShare).Appearance = (AppearanceBase) appearance13;
    ((Control) this.numShare).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyProgramParticpation_Base.Share", true));
    ((UltraNumericEditorBase) this.numShare).FormatString = "";
    ((Control) this.numShare).Location = new Point(421, 57);
    ((UltraNumericEditor) this.numShare).MaskInput = "nnn.nnnnnnn";
    this.numShare.MGAStyle = (MGAStyles) 2;
    ((Control) this.numShare).Name = "numShare";
    ((UltraNumericEditor) this.numShare).Nullable = true;
    ((UltraNumericEditor) this.numShare).NumericType = (NumericType) 2;
    ((Control) this.numShare).Size = new Size(80 /*0x50*/, 19);
    ((Control) this.numShare).TabIndex = 3;
    ((UltraWinEditorMaskedControlBase) this.numShare).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numShare).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numShare).UseOsThemes = (DefaultableBoolean) 2;
    this.label3.AutoSize = true;
    this.label3.Location = new Point(43, 101);
    this.label3.Name = "label3";
    this.label3.Size = new Size(55, 13);
    this.label3.TabIndex = 37;
    this.label3.Text = "End Date:";
    this.label1.AutoSize = true;
    this.label1.Location = new Point(3, 19);
    this.label1.Name = "label1";
    this.label1.Size = new Size(98, 13);
    this.label1.TabIndex = 34;
    this.label1.Text = "Company Location:";
    appearance14.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtEndDate).Appearance = (AppearanceBase) appearance14;
    appearance15.AlphaLevel = (short) 14;
    appearance15.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance15.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance15.BackColorAlpha = (Alpha) 2;
    appearance15.BackGradientAlignment = (GradientAlignment) 4;
    appearance15.BackGradientStyle = (GradientStyle) 5;
    appearance15.BorderAlpha = (Alpha) 1;
    appearance15.BorderColor = Color.FromArgb(78, 122, 171);
    appearance15.ForeColor = Color.FromArgb(49, 85, 153);
    appearance15.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtEndDate).ButtonAppearance = (AppearanceBase) appearance15;
    ((Control) this.dtEndDate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyProgramParticpation_Base.EndDate", true));
    ((UltraDateTimeEditor) this.dtEndDate).DateTime = new DateTime(2013, 7, 15, 0, 0, 0, 0);
    ((Control) this.dtEndDate).Location = new Point(113, 98);
    this.dtEndDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtEndDate).Name = "dtEndDate";
    ((UltraDateTimeEditor) this.dtEndDate).Nullable = false;
    ((Control) this.dtEndDate).Size = new Size(99, 19);
    ((Control) this.dtEndDate).TabIndex = 2;
    ((UltraControlBase) this.dtEndDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtEndDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtEndDate).Value = (object) new DateTime(2013, 7, 15, 0, 0, 0, 0);
    this.label2.AutoSize = true;
    this.label2.Location = new Point(43, 60);
    this.label2.Name = "label2";
    this.label2.Size = new Size(58, 13);
    this.label2.TabIndex = 36;
    this.label2.Text = "Start Date:";
    appearance16.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraDateTimeEditor) this.dtStartDate).Appearance = (AppearanceBase) appearance16;
    appearance17.AlphaLevel = (short) 14;
    appearance17.BackColor = Color.FromArgb(0, 0, 246, 253);
    appearance17.BackColor2 = Color.FromArgb(133, 162, 221);
    appearance17.BackColorAlpha = (Alpha) 2;
    appearance17.BackGradientAlignment = (GradientAlignment) 4;
    appearance17.BackGradientStyle = (GradientStyle) 5;
    appearance17.BorderAlpha = (Alpha) 1;
    appearance17.BorderColor = Color.FromArgb(78, 122, 171);
    appearance17.ForeColor = Color.FromArgb(49, 85, 153);
    appearance17.ForegroundAlpha = (Alpha) 2;
    ((UltraDateTimeEditor) this.dtStartDate).ButtonAppearance = (AppearanceBase) appearance17;
    ((Control) this.dtStartDate).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyProgramParticpation_Base.StartDate", true));
    ((UltraDateTimeEditor) this.dtStartDate).DateTime = new DateTime(2013, 7, 15, 0, 0, 0, 0);
    ((Control) this.dtStartDate).Location = new Point(113, 57);
    this.dtStartDate.MGAStyle = (MGAStyles) 2;
    ((Control) this.dtStartDate).Name = "dtStartDate";
    ((UltraDateTimeEditor) this.dtStartDate).Nullable = false;
    ((Control) this.dtStartDate).Size = new Size(99, 19);
    ((Control) this.dtStartDate).TabIndex = 1;
    ((UltraControlBase) this.dtStartDate).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dtStartDate).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDateTimeEditor) this.dtStartDate).Value = (object) new DateTime(2013, 7, 15, 0, 0, 0, 0);
    ((Control) this.dbSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = (EditStyle) 1;
    this.dbSave.FreezeEvents = false;
    ((Control) this.dbSave).Location = new Point(419, 490);
    ((Control) this.dbSave).Name = "dbSave";
    ((Control) this.dbSave).Size = new Size(112 /*0x70*/, 40);
    ((Control) this.dbSave).TabIndex = 222;
    this.err.ContainerControl = (ContainerControl) this;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(543, 542);
    this.Controls.Add((Control) this.grpDetails);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.ddCompanyLocations);
    this.Controls.Add((Control) this.dgParticipation);
    this.Name = nameof (FormBaseProgramCodeParticipation);
    this.Text = "Program Code Participation";
    ((ISupportInitialize) this.ddCompanyLocations).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.dgParticipation).EndInit();
    this.grpDetails.ResumeLayout(false);
    this.grpDetails.PerformLayout();
    ((ISupportInitialize) this.numCommission).EndInit();
    ((ISupportInitialize) this.cboCompanyLocation).EndInit();
    ((ISupportInitialize) this.numShare).EndInit();
    ((ISupportInitialize) this.dtEndDate).EndInit();
    ((ISupportInitialize) this.dtStartDate).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("ddCompanyLocations")]
  private virtual UltraDropDown ddCompanyLocations { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgParticipation")]
  protected virtual UltraGrid dgParticipation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpDetails")]
  private virtual GroupBox grpDetails { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label4")]
  private virtual Label label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCompanyLocation")]
  protected virtual MGASimpleComboBox cboCompanyLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numShare")]
  protected virtual MGANumericEditor numShare { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label3")]
  private virtual Label label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label1")]
  private virtual Label label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtEndDate")]
  protected virtual MGADateTimePicker dtEndDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("label2")]
  private virtual Label label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dtStartDate")]
  protected virtual MGADateTimePicker dtStartDate { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingNew -= cancelEventHandler2;
        dbSave1.ClickingEdit -= cancelEventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler4;
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickedSave -= eventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingNew += cancelEventHandler2;
      dbSave2.ClickingEdit += cancelEventHandler3;
      dbSave2.ClickingSave += cancelEventHandler4;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickedSave += eventHandler2;
    }
  }

  [field: AccessedThroughProperty("err")]
  private virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  private virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numCommission")]
  protected virtual MGANumericEditor numCommission { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsProgCodeExt ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormBaseProgramCodeParticipation(
    int ProgramID,
    string progCode,
    object effective,
    object expiration)
  {
    this.Load += new EventHandler(this.FormProgramCodeParticipation_Load);
    this.InitializeComponent();
    this._ProgramID = ProgramID;
    this._effectiveDate = RuntimeHelpers.GetObjectValue(effective);
    this._expirationDate = RuntimeHelpers.GetObjectValue(expiration);
    ((Control) this.dgParticipation).Text = $"{((Control) this.dgParticipation).Text}[{progCode}]";
  }

  private void FormProgramCodeParticipation_Load(object sender, EventArgs e)
  {
    this.GenerateSummaries("Share", "{0:N7}");
    this.GenerateSummaries("Commission", "{0:N7}");
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(int.MinValue, string.Empty);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      "tblCompanyProgramParticpation_Base",
      "tblCompanyLocations"
    }, "GetProgramCodeParticipationData_Base", new object[2]
    {
      (object) "@ProgramID",
      (object) this._ProgramID
    });
    this._bmb = this.BindingContext[(object) this.ds, this.ds.tblCompanyProgramParticpation_Base.TableName];
    this._bmb.Position = this.ds.tblCompanyProgramParticpation_Base.Count - 1;
    this.SetEnabledState(false);
    this.SetSaveState();
  }

  private void GenerateSummaries(string columnName, string summaryDisplayFormat)
  {
    ((UltraGridBase) this.dgParticipation).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 0;
    UltraGridBand band = ((UltraGridBase) this.dgParticipation).DisplayLayout.Bands[0];
    SummarySettings summarySettings = band.Summaries.Add((SummaryType) 1, band.Columns[columnName]);
    summarySettings.DisplayFormat = summaryDisplayFormat;
    summarySettings.Appearance.TextHAlign = (HAlign) 3;
  }

  private void SetSaveState()
  {
    if (this.ds.tblCompanyProgramParticpation_Base.Count > 0)
      this.dbSave.UIState = (UIState) 1;
    else
      this.dbSave.UIState = (UIState) 0;
  }

  private void SetEnabledState(bool isEditing) => this.grpDetails.Enabled = isEditing;

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this._bmb.Position < 0)
      e.Cancel = true;
    else if (DialogResult.Yes != MessageBox.Show("Continue Delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
    {
      e.Cancel = true;
    }
    else
    {
      this.ds.tblCompanyProgramParticpation_Base[this._bmb.Position].Delete();
      this.UpdateParticipationData();
      this.SetEnabledState(false);
      this.SetSaveState();
    }
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this.SetEnabledState(true);
    dsProgCodeExt.tblCompanyProgramParticpation_BaseRow row = this.ds.tblCompanyProgramParticpation_Base.NewtblCompanyProgramParticpation_BaseRow();
    row.StartDate = Utility.IsNull(RuntimeHelpers.GetObjectValue(this._effectiveDate)) ? DateAndTime.Now : Conversions.ToDate(this._effectiveDate);
    row.EndDate = Utility.IsNull(RuntimeHelpers.GetObjectValue(this._expirationDate)) ? DateAndTime.Now.AddYears(1) : Conversions.ToDate(this._expirationDate);
    row.CompanyLocationID = int.MinValue;
    row.ProgramID = this._ProgramID;
    this.ds.tblCompanyProgramParticpation_Base.AddtblCompanyProgramParticpation_BaseRow(row);
    this._bmb.Position = this.ds.tblCompanyProgramParticpation_Base.Count - 1;
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e) => this.SetEnabledState(true);

  private bool IsValidData()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboCompanyLocation, string.Empty);
    this.err.SetError((Control) this.dtStartDate, string.Empty);
    if (string.IsNullOrEmpty(((UltraCombo) this.cboCompanyLocation).Text))
    {
      this.err.SetError((Control) this.cboCompanyLocation, "Please select a value");
      flag = false;
    }
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraDateTimeEditor) this.dtStartDate).Value)))
    {
      this.err.SetError((Control) this.dtStartDate, "Please enter a value");
      flag = false;
    }
    return flag;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.IsValidData())
    {
      e.Cancel = true;
    }
    else
    {
      this._bmb.EndCurrentEdit();
      this.UpdateParticipationData();
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblCompanyProgramParticpation_Base.RejectChanges();
    if (this.ds.tblCompanyProgramParticpation_Base.Count > 0)
      this.dbSave.UIState = (UIState) 1;
    else
      this.dbSave.UIState = (UIState) 0;
  }

  private void dbSave_ClickedSave(object sender, EventArgs e) => this.SetEnabledState(false);

  private void UpdateParticipationData()
  {
    using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.tblCompanyProgramParticpation_Base, "dbo.InsertCompanyProgamParticipation", "dbo.UpdateCompanyProgamParticipation", "dbo.DeleteCompanyProgamParticipation", true, 30, (DbTransaction) null))
      DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.tblCompanyProgramParticpation_Base);
  }
}
