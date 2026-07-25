// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormProgramCode
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.NoteDocuments;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
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
[DocumentFolderFilter("Program Codes")]
[SecureResource("{7D1478EF-0434-4cae-B267-C2B171302048}", "Access Program Code Screen", "Controls access to the Program Code screen.", "Policies")]
public class FormProgramCode : Form, ISupportDocumentSystem
{
  private IContainer components;
  private Guid _emptyLocationGuid;
  private Guid _emptyLineGuid;
  private Guid _emptyIssuingOfficeGuid;
  private bool _AllowDuplicateProgramCodes;
  protected string _dicKey;
  protected bool valid;
  protected int rowNum;
  protected Dictionary<string, UltraGridRow> tmpDictionary;
  protected string tmpLoc;
  protected string tmpStateID;
  protected string tmpContractEff;
  protected string tmpLine;
  protected string tmpIssue;
  protected string tmpProgCode;
  private string _tmpGroupCode;
  protected readonly Lazy<bool> _canEditProgramCode;
  private Guid _programCodeGuid;
  private string _programCodeName;
  private readonly Dictionary<int, FormProgramCode.progStructure> _currentProgramCodes;
  private readonly HyperlinkEditor _baseAdddata;
  private readonly HyperlinkEditor _basePartData;
  protected readonly Lazy<bool> _showBaseProgCodeExt;
  public const string canViewProgramCodesForm = "{7D1478EF-0434-4cae-B267-C2B171302048}";

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstLineGroups", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GroupCode");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GroupName");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("State");
    UltraGridBand ultraGridBand3 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LocationName");
    UltraGridBand ultraGridBand4 = new UltraGridBand("tblClientOffices", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("OfficeGUID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("Location");
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("LineName");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblCompanyProgramCodes", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("CompanyLocationGUID", -1, (object) "ddCompanyLocations");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("StateID", -1, (object) "ddState");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ContractEffective");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ContractExpiration");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("LineGUID", -1, (object) "ddLine");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("IssuingOfficeGUID", -1, (object) "ddClientOffice");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ProgCode", -1, (object) null, 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("ProgramID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("GroupCode", -1, (object) "ddLineGroup");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("RowNum");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("ProgramCodeGuid");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("ParentLineGUID", -1, (object) "ddLine");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.btnSave = new MGAButton();
    this.lnkAddProgramCode = new LinkLabel();
    this.lnkCancelProgramCode = new LinkLabel();
    this.ddLineGroup = new UltraDropDown();
    this.ds = new dsProgramCodes();
    this.ddState = new UltraDropDown();
    this.ddCompanyLocations = new UltraDropDown();
    this.ddClientOffice = new UltraDropDown();
    this.ddLine = new UltraDropDown();
    this.dgProgramCodes = new UltraGrid();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.ddLineGroup).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddState).BeginInit();
    ((ISupportInitialize) this.ddCompanyLocations).BeginInit();
    ((ISupportInitialize) this.ddClientOffice).BeginInit();
    ((ISupportInitialize) this.ddLine).BeginInit();
    ((ISupportInitialize) this.dgProgramCodes).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSave).Location = new Point(1029, 396);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 1;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkAddProgramCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkAddProgramCode.AutoSize = true;
    this.lnkAddProgramCode.Location = new Point(12, 370);
    this.lnkAddProgramCode.Name = "lnkAddProgramCode";
    this.lnkAddProgramCode.Size = new Size(97, 13);
    this.lnkAddProgramCode.TabIndex = 218;
    this.lnkAddProgramCode.TabStop = true;
    this.lnkAddProgramCode.Text = "Add Program Code";
    this.lnkCancelProgramCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCancelProgramCode.AutoSize = true;
    this.lnkCancelProgramCode.Location = new Point(12, 411);
    this.lnkCancelProgramCode.Name = "lnkCancelProgramCode";
    this.lnkCancelProgramCode.Size = new Size(110, 13);
    this.lnkCancelProgramCode.TabIndex = 219;
    this.lnkCancelProgramCode.TabStop = true;
    this.lnkCancelProgramCode.Text = "Cancel Program Code";
    ((Control) this.ddLineGroup).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddLineGroup).DataMember = "lstLineGroups";
    ((UltraGridBase) this.ddLineGroup).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddLineGroup).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
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
    ((UltraGridBase) this.ddLineGroup).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddLineGroup).DisplayMember = "GroupName";
    ((UltraDropDownBase) this.ddLineGroup).DropDownWidth = 400;
    ((Control) this.ddLineGroup).Location = new Point(525, 178);
    ((Control) this.ddLineGroup).Name = "ddLineGroup";
    ((Control) this.ddLineGroup).Size = new Size(121, 93);
    ((Control) this.ddLineGroup).TabIndex = 220;
    ((Control) this.ddLineGroup).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddLineGroup).ValueMember = "GroupCode";
    ((Control) this.ddLineGroup).Visible = false;
    this.ds.DataSetName = "dsProgramCodes";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.ddState).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddState).DataMember = "lstStates";
    ((UltraGridBase) this.ddState).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddState).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 8;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 150;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ddState).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddState).DisplayMember = "State";
    ((UltraDropDownBase) this.ddState).DropDownWidth = 400;
    ((Control) this.ddState).Location = new Point(318, 104);
    ((Control) this.ddState).Name = "ddState";
    ((Control) this.ddState).Size = new Size(121, 103);
    ((Control) this.ddState).TabIndex = 217;
    ((Control) this.ddState).Text = "ddLines";
    ((UltraDropDownBase) this.ddState).ValueMember = "StateID";
    ((Control) this.ddState).Visible = false;
    ((Control) this.ddCompanyLocations).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddCompanyLocations).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.ddCompanyLocations).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddCompanyLocations).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 8;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Company Location Name";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 200;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ddCompanyLocations).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddCompanyLocations).DisplayMember = "LocationName";
    ((UltraDropDownBase) this.ddCompanyLocations).DropDownWidth = 400;
    ((Control) this.ddCompanyLocations).Location = new Point(829, 135);
    ((Control) this.ddCompanyLocations).Name = "ddCompanyLocations";
    ((Control) this.ddCompanyLocations).Size = new Size(121, 93);
    ((Control) this.ddCompanyLocations).TabIndex = 216;
    ((Control) this.ddCompanyLocations).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddCompanyLocations).ValueMember = "CompanyLocationGUID";
    ((Control) this.ddCompanyLocations).Visible = false;
    ((Control) this.ddClientOffice).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddClientOffice).DataMember = "tblClientOffices";
    ((UltraGridBase) this.ddClientOffice).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddClientOffice).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 200;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ddClientOffice).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddClientOffice).DisplayMember = "Location";
    ((UltraDropDownBase) this.ddClientOffice).DropDownWidth = 400;
    ((Control) this.ddClientOffice).Location = new Point(631, 125);
    ((Control) this.ddClientOffice).Name = "ddClientOffice";
    ((Control) this.ddClientOffice).Size = new Size(121, 93);
    ((Control) this.ddClientOffice).TabIndex = 215;
    ((Control) this.ddClientOffice).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddClientOffice).ValueMember = "OfficeGUID";
    ((Control) this.ddClientOffice).Visible = false;
    ((Control) this.ddLine).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddLine).DataMember = "lstLines";
    ((UltraGridBase) this.ddLine).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddLine).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 1;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.ddLine).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraDropDownBase) this.ddLine).DisplayMember = "LineName";
    ((UltraDropDownBase) this.ddLine).DropDownWidth = 400;
    ((Control) this.ddLine).Location = new Point(461, 125);
    ((Control) this.ddLine).Name = "ddLine";
    ((Control) this.ddLine).Size = new Size(121, 103);
    ((Control) this.ddLine).TabIndex = 214;
    ((Control) this.ddLine).Text = "ddLines";
    ((UltraDropDownBase) this.ddLine).ValueMember = "LineGUID";
    ((Control) this.ddLine).Visible = false;
    ((Control) this.dgProgramCodes).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgProgramCodes).DataMember = "tblCompanyProgramCodes";
    ((UltraGridBase) this.dgProgramCodes).DataSource = (object) this.ds;
    appearance2.FontData.BoldAsString = "False";
    appearance2.FontData.UnderlineAsString = "True";
    ((SpecialBoxBase) ((UltraGridBase) this.dgProgramCodes).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance2;
    ((SpecialBoxBase) ((UltraGridBase) this.dgProgramCodes).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand6.AddButtonCaption = "Add ... Program Code";
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Company Location";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 4;
    ultraGridColumn11.Style = (ColumnStyle) 6;
    ultraGridColumn11.Width = 153;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 9;
    ultraGridColumn12.Style = (ColumnStyle) 6;
    ultraGridColumn12.Width = 75;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Effective";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 2;
    ultraGridColumn13.Width = 86;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Expiration";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 3;
    ultraGridColumn14.Width = 87;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 7;
    ultraGridColumn15.Style = (ColumnStyle) 6;
    ultraGridColumn15.Width = 131;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Issuing Office";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 8;
    ultraGridColumn16.Style = (ColumnStyle) 6;
    ultraGridColumn16.Width = 111;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Program Code";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 1;
    ultraGridColumn17.Width = 130;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 10;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 76;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Line Group";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 5;
    ultraGridColumn19.Style = (ColumnStyle) 6;
    ultraGridColumn19.Width = 106;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Center";
    ultraGridColumn20.CellAppearance = (AppearanceBase) appearance4;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Row #";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 0;
    ultraGridColumn20.Width = 29;
    ultraGridColumn21.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn21.Header.VisiblePosition = 11;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn21.Width = 191;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Parent Line";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn22.Header.VisiblePosition = 6;
    ultraGridColumn22.Style = (ColumnStyle) 6;
    ultraGridColumn22.Width = 128 /*0x80*/;
    ultraGridBand6.Columns.AddRange(new object[12]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22
    });
    ultraGridBand6.Override.AllowAddNew = (AllowAddNew) 1;
    ultraGridBand6.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    ((Control) this.dgProgramCodes).Font = new Font("Tahoma", 8.25f);
    ((Control) this.dgProgramCodes).Location = new Point(12, 12);
    ((Control) this.dgProgramCodes).Name = "dgProgramCodes";
    ((Control) this.dgProgramCodes).Size = new Size(1057, 340);
    ((Control) this.dgProgramCodes).TabIndex = 29;
    ((Control) this.dgProgramCodes).Text = "Available Program Codes";
    ((UltraControlBase) this.dgProgramCodes).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgProgramCodes).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1081, 448);
    this.Controls.Add((Control) this.ddLineGroup);
    this.Controls.Add((Control) this.lnkCancelProgramCode);
    this.Controls.Add((Control) this.lnkAddProgramCode);
    this.Controls.Add((Control) this.ddState);
    this.Controls.Add((Control) this.ddCompanyLocations);
    this.Controls.Add((Control) this.ddClientOffice);
    this.Controls.Add((Control) this.ddLine);
    this.Controls.Add((Control) this.dgProgramCodes);
    this.Controls.Add((Control) this.btnSave);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.Name = nameof (FormProgramCode);
    this.Text = "Program Codes";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.ddLineGroup).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddState).EndInit();
    ((ISupportInitialize) this.ddCompanyLocations).EndInit();
    ((ISupportInitialize) this.ddClientOffice).EndInit();
    ((ISupportInitialize) this.ddLine).EndInit();
    ((ISupportInitialize) this.dgProgramCodes).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

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

  protected virtual UltraGrid dgProgramCodes
  {
    get => this._dgProgramCodes;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgProgramCodes_AfterRowsDeleted);
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.dgProgramCodes_InitializeLayout);
      BeforeRowsDeletedEventHandler deletedEventHandler = new BeforeRowsDeletedEventHandler(this.DgProgramCodes_BeforeRowsDeleted);
      UltraGrid dgProgramCodes1 = this._dgProgramCodes;
      if (dgProgramCodes1 != null)
      {
        dgProgramCodes1.AfterRowsDeleted -= eventHandler;
        dgProgramCodes1.InitializeLayout -= layoutEventHandler;
        dgProgramCodes1.BeforeRowsDeleted -= deletedEventHandler;
      }
      this._dgProgramCodes = value;
      UltraGrid dgProgramCodes2 = this._dgProgramCodes;
      if (dgProgramCodes2 == null)
        return;
      dgProgramCodes2.AfterRowsDeleted += eventHandler;
      dgProgramCodes2.InitializeLayout += layoutEventHandler;
      dgProgramCodes2.BeforeRowsDeleted += deletedEventHandler;
    }
  }

  protected virtual UltraDropDown ddLine
  {
    get => this._ddLine;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ddLine_BeforeDropDown);
      UltraDropDown ddLine1 = this._ddLine;
      if (ddLine1 != null)
        ddLine1.BeforeDropDown -= cancelEventHandler;
      this._ddLine = value;
      UltraDropDown ddLine2 = this._ddLine;
      if (ddLine2 == null)
        return;
      ddLine2.BeforeDropDown += cancelEventHandler;
    }
  }

  protected virtual UltraDropDown ddClientOffice
  {
    get => this._ddClientOffice;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ddClientOffice_BeforeDropDown);
      UltraDropDown ddClientOffice1 = this._ddClientOffice;
      if (ddClientOffice1 != null)
        ddClientOffice1.BeforeDropDown -= cancelEventHandler;
      this._ddClientOffice = value;
      UltraDropDown ddClientOffice2 = this._ddClientOffice;
      if (ddClientOffice2 == null)
        return;
      ddClientOffice2.BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  protected virtual dsProgramCodes ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraDropDown ddCompanyLocations
  {
    get => this._ddCompanyLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ddCompanyLocations_BeforeDropDown);
      UltraDropDown companyLocations1 = this._ddCompanyLocations;
      if (companyLocations1 != null)
        companyLocations1.BeforeDropDown -= cancelEventHandler;
      this._ddCompanyLocations = value;
      UltraDropDown companyLocations2 = this._ddCompanyLocations;
      if (companyLocations2 == null)
        return;
      companyLocations2.BeforeDropDown += cancelEventHandler;
    }
  }

  protected virtual UltraDropDown ddState
  {
    get => this._ddState;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.ddState_BeforeDropDown);
      UltraDropDown ddState1 = this._ddState;
      if (ddState1 != null)
        ddState1.BeforeDropDown -= cancelEventHandler;
      this._ddState = value;
      UltraDropDown ddState2 = this._ddState;
      if (ddState2 == null)
        return;
      ddState2.BeforeDropDown += cancelEventHandler;
    }
  }

  protected virtual LinkLabel lnkAddProgramCode
  {
    get => this._lnkAddProgramCode;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAddProgramCode_LinkClicked);
      LinkLabel lnkAddProgramCode1 = this._lnkAddProgramCode;
      if (lnkAddProgramCode1 != null)
        lnkAddProgramCode1.LinkClicked -= clickedEventHandler;
      this._lnkAddProgramCode = value;
      LinkLabel lnkAddProgramCode2 = this._lnkAddProgramCode;
      if (lnkAddProgramCode2 == null)
        return;
      lnkAddProgramCode2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkCancelProgramCode
  {
    get => this._lnkCancelProgramCode;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCancelProgramCode_LinkClicked);
      LinkLabel cancelProgramCode1 = this._lnkCancelProgramCode;
      if (cancelProgramCode1 != null)
        cancelProgramCode1.LinkClicked -= clickedEventHandler;
      this._lnkCancelProgramCode = value;
      LinkLabel cancelProgramCode2 = this._lnkCancelProgramCode;
      if (cancelProgramCode2 == null)
        return;
      cancelProgramCode2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("ddLineGroup")]
  protected virtual UltraDropDown ddLineGroup { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormProgramCode()
  {
    this.Load += new EventHandler(this.FormProgramCode_Load);
    this._emptyLocationGuid = new Guid("{2D2B247D-026B-48F0-BE68-807E4A521860}");
    this._emptyLineGuid = new Guid("{481617F8-887B-4EEA-A16D-02C45E20386C}");
    this._emptyIssuingOfficeGuid = new Guid("{A7242953-1625-4106-8DFD-5FEA1B95CBE4}");
    this._AllowDuplicateProgramCodes = false;
    this.valid = true;
    this.rowNum = 1;
    this.tmpDictionary = new Dictionary<string, UltraGridRow>();
    this.tmpLoc = string.Empty;
    this.tmpStateID = string.Empty;
    this.tmpContractEff = string.Empty;
    this.tmpLine = string.Empty;
    this.tmpIssue = string.Empty;
    this.tmpProgCode = string.Empty;
    this._tmpGroupCode = string.Empty;
    this._canEditProgramCode = SystemSettings.GetLazySetting<bool>("ProgramCodes.AllowEditWhenAppliedToBoundPolicies", false, true);
    this._programCodeGuid = Guid.Empty;
    this._currentProgramCodes = new Dictionary<int, FormProgramCode.progStructure>();
    this._baseAdddata = new HyperlinkEditor();
    this._basePartData = new HyperlinkEditor();
    this._showBaseProgCodeExt = SystemSettings.GetLazySetting<bool>("ProgramCodes.ShowBaseProgramCodeExtensions", false, true);
    this.InitializeComponent();
  }

  public void BaseAddData_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    if (!this._showBaseProgCodeExt.Value || !this.BaseContinueProcessingExt())
      return;
    FormBaseProgramCodeExt baseProgramCodeExt = new FormBaseProgramCodeExt(Conversions.ToInteger(((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ProgramID"].Value), ((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ProgCode"].Value.ToString());
    baseProgramCodeExt.ShowInTaskbar = true;
    baseProgramCodeExt.StartPosition = FormStartPosition.CenterScreen;
    baseProgramCodeExt.Show();
  }

  public void BasePartData_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    if (!this._showBaseProgCodeExt.Value || !this.BaseContinueProcessingExt())
      return;
    object obj1 = (object) null;
    object obj2 = (object) null;
    if (((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ContractEffective"].Value != DBNull.Value && ((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ContractEffective"].Value != null)
      obj1 = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ContractEffective"].Value);
    if (((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ContractExpiration"].Value != DBNull.Value && ((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ContractExpiration"].Value != null)
      obj2 = RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ContractExpiration"].Value);
    FormBaseProgramCodeParticipation codeParticipation = new FormBaseProgramCodeParticipation(Conversions.ToInteger(((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ProgramID"].Value), ((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ProgCode"].Value.ToString(), RuntimeHelpers.GetObjectValue(obj1), RuntimeHelpers.GetObjectValue(obj2));
    codeParticipation.ShowInTaskbar = true;
    codeParticipation.StartPosition = FormStartPosition.CenterScreen;
    codeParticipation.Show();
  }

  private bool BaseContinueProcessingExt()
  {
    bool flag;
    if (!this._showBaseProgCodeExt.Value)
      flag = false;
    else if (this.ds.tblCompanyProgramCodes.Select("ProgramID=" + Conversions.ToInteger(((UltraGridBase) this.dgProgramCodes).ActiveRow.Cells["ProgramID"].Value).ToString())[0].RowState == DataRowState.Added)
    {
      int num = (int) MessageBox.Show("Please save the current row prior to adding extension data.", "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void FormProgramCode_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    MGAButton btnSave = this.btnSave;
    ((ControlBase) btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) btnSave).Appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) btnSave).Appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) btnSave).ImageTransparentColor = Color.Magenta;
    this.ShowBaseProgramCodeExtension();
    dsProgramCodes.lstStatesRow row1 = this.ds.lstStates.NewlstStatesRow();
    row1.State = "ANY";
    row1.StateID = "&&";
    this.ds.lstStates.AddlstStatesRow(row1);
    dsProgramCodes.tblClientOfficesRow row2 = this.ds.tblClientOffices.NewtblClientOfficesRow();
    row2.OfficeGUID = new Guid("{00000000-0000-0000-0000-000000000000}");
    row2.Location = "ANY";
    this.ds.tblClientOffices.AddtblClientOfficesRow(row2);
    dsProgramCodes.tblClientOfficesRow row3 = this.ds.tblClientOffices.NewtblClientOfficesRow();
    row3.OfficeGUID = this._emptyIssuingOfficeGuid;
    row3.Location = string.Empty;
    this.ds.tblClientOffices.AddtblClientOfficesRow(row3);
    dsProgramCodes.tblCompanyLocationsRow row4 = this.ds.tblCompanyLocations.NewtblCompanyLocationsRow();
    row4.CompanyLocationGUID = new Guid("{00000000-0000-0000-0000-000000000000}");
    row4.LocationName = "ANY";
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(row4);
    dsProgramCodes.tblCompanyLocationsRow row5 = this.ds.tblCompanyLocations.NewtblCompanyLocationsRow();
    row5.CompanyLocationGUID = this._emptyLocationGuid;
    row5.LocationName = string.Empty;
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(row5);
    dsProgramCodes.lstLinesRow row6 = this.ds.lstLines.NewlstLinesRow();
    row6.LineGUID = new Guid("{00000000-0000-0000-0000-000000000000}");
    row6.LineName = "ANY";
    this.ds.lstLines.AddlstLinesRow(row6);
    dsProgramCodes.lstLinesRow row7 = this.ds.lstLines.NewlstLinesRow();
    row7.LineGUID = this._emptyLineGuid;
    row7.LineName = string.Empty;
    this.ds.lstLines.AddlstLinesRow(row7);
    dsProgramCodes.lstLineGroupsRow row8 = this.ds.lstLineGroups.NewlstLineGroupsRow();
    row8.GroupCode = "&&";
    row8.GroupName = "ANY";
    this.ds.lstLineGroups.AddlstLineGroupsRow(row8);
    string str = "dbo.GetProgramCodeData";
    if (SystemSettings.KeyExists("FormProgramCode.GetProgramCodeDataProcName"))
      str = SystemSettings.GetStringSetting("FormProgramCode.GetProgramCodeDataProcName");
    if (SystemSettings.KeyExists("FormProgramCode.DatesDisplay"))
    {
      string stringSetting = SystemSettings.GetStringSetting("FormProgramCode.DatesDisplay");
      ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].Columns["ContractEffective"].MaskInput = stringSetting;
      ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].Columns["ContractExpiration"].MaskInput = stringSetting;
    }
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[6]
      {
        "lstStates",
        "lstLines",
        "tblClientOffices",
        "tblCompanyLocations",
        "tblCompanyProgramCodes",
        "lstLineGroups"
      }, str);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    this.SetRowNumber();
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgProgramCodes).UpdateData();
    this.ds.AcceptChanges();
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].Columns["ParentLineGUID"].Hidden = !SystemSettings.GetBoolSetting("ProgramCodes.ShowParentLine");
    this.LoadOnClient();
    if (SystemSettings.KeyExists("AllowDuplicateProgramCodes"))
      this._AllowDuplicateProgramCodes = SystemSettings.GetBoolSetting("AllowDuplicateProgramCodes");
    this.GatherProgramCodes();
    this.dgProgramCodes.AfterRowActivate += new EventHandler(this.dgProgramCodes_AfterSelectChanged);
  }

  private void SetRowNumber()
  {
    int num = 1;
    foreach (UltraGridRow row in ((UltraGridBase) this.dgProgramCodes).Rows)
    {
      row.Cells["RowNum"].Value = (object) num;
      ++num;
    }
    ((UltraGridBase) this.dgProgramCodes).UpdateData();
    this.ds.tblCompanyProgramCodes.AcceptChanges();
    ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].Columns["RowNum"].Width = ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].Columns["RowNum"].Width + 40;
  }

  protected virtual bool ValidateForm()
  {
    this.tmpDictionary.Clear();
    this.valid = true;
    this._tmpGroupCode = string.Empty;
    this.tmpLoc = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.dgProgramCodes).Rows)
    {
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["GroupCode"].Value)) || row.Cells["GroupCode"].Text.Equals(string.Empty))
      {
        int num = (int) MessageBox.Show("Please enter a line group.  Select 'ANY' ", "Empty Line Group", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.valid = false;
        break;
      }
      this._tmpGroupCode = row.Cells["GroupCode"].Text;
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["CompanyLocationGUID"].Value)) || row.Cells["CompanyLocationGUID"].Text.Equals(string.Empty))
      {
        int num = (int) MessageBox.Show("Please enter a company location", "Empty Company Location at Row #" + row.Cells["RowNum"].Value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.valid = false;
        break;
      }
      this.tmpLoc = row.Cells["CompanyLocationGUID"].Text;
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["StateID"].Value)) || row.Cells["StateID"].Text.Equals(string.Empty))
      {
        int num = (int) MessageBox.Show("Please enter a state", "Empty State", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.valid = false;
        break;
      }
      this.tmpStateID = row.Cells["StateID"].Text;
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["ContractEffective"].Value)))
      {
        int num = (int) MessageBox.Show("Please enter an effective date", "Empty Effective Date at Row #" + row.Cells["RowNum"].Value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.valid = false;
        break;
      }
      this.tmpContractEff = ((DateTime) row.Cells["ContractEffective"].Value).ToShortDateString();
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["LineGUID"].Value)) || row.Cells["LineGUID"].Text.Equals(string.Empty))
      {
        int num = (int) MessageBox.Show("Please enter a line of business", "Empty Line Of Business at Row #" + row.Cells["RowNum"].Value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.valid = false;
        break;
      }
      this.tmpLine = row.Cells["LineGUID"].Text;
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["IssuingOfficeGUID"].Value)) || row.Cells["IssuingOfficeGUID"].Text.Equals(string.Empty))
      {
        int num = (int) MessageBox.Show("Please enter an Issuing Office", "Empty Issuing Office at Row #" + row.Cells["RowNum"].Value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.valid = false;
        break;
      }
      this.tmpIssue = row.Cells["IssuingOfficeGUID"].Text;
      if (Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["ProgCode"].Value)) || row.Cells["ProgCode"].Text.Replace(" ", string.Empty).Equals(string.Empty))
      {
        int num = (int) MessageBox.Show("Please enter a Program Code", "Empty Program Code at Row #" + row.Cells["RowNum"].Value.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        this.valid = false;
        break;
      }
      this.tmpProgCode = row.Cells["ProgCode"].Text;
      this._dicKey = $"Program Code - {this.tmpProgCode}\nEffective - {this.tmpContractEff}\nCompany Location - {this.tmpLoc}\nLine - {this.tmpLine}\nIssiung Office - {this.tmpIssue}\nState - {this.tmpStateID}\nLine Code - {this._tmpGroupCode}\nParent Line - {(!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["ParentLineGUID"].Value)) ? row.Cells["ParentLineGUID"].Text : string.Empty)}";
      if (!this._AllowDuplicateProgramCodes)
      {
        if (!this.tmpDictionary.ContainsKey(this._dicKey))
        {
          this.tmpDictionary.Add(this._dicKey, row);
        }
        else
        {
          int num = (int) MessageBox.Show($"The entry at row # {row.Cells["RowNum"].Value.ToString()} is a duplicate\n\n{this._dicKey}", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          this.valid = false;
          break;
        }
      }
      ++this.rowNum;
    }
    return this.valid;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm() || this.IsAppliedCode())
      return;
    if (!this.clientDuplicateLogic())
      return;
    try
    {
      ((Control) this.btnSave).Enabled = false;
      this.Cursor = MgaCursors.WaitCursor;
      this.LogChanges("tblCompanyProgramCodes", "Administration Menu: The program code(s) was modified. ", "CompanyLocationGUID", "ProgCode");
      this.UpdateProgramCodes();
      ((UltraGridBase) this.dgProgramCodes).UpdateData();
      this.SaveOnClient();
      int num = (int) MessageBox.Show("Data saved successfully.", "Data Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ConstraintException constraintException = ex;
      if (constraintException.Message.Contains("is constrained to be unique."))
      {
        int num = (int) MessageBox.Show("A record already exists with the same company location, state, line, effective date, office and Line Code.\n\nIt is best to close and reopen this form and try again", "Record Already Exists", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        ProjectData.ClearProjectError();
      }
      else
      {
        ErrorHandler.HandleError((Exception) constraintException);
        ProjectData.ClearProjectError();
      }
    }
    finally
    {
      ((Control) this.btnSave).Enabled = true;
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual bool clientDuplicateLogic() => true;

  protected virtual void LoadOnClient()
  {
  }

  protected virtual void SaveOnClient()
  {
  }

  protected void LogChanges(
    string dtTableName,
    string strAction,
    string strGUIDtoLog,
    string strcontext)
  {
    DataTable table = this.ds.Tables[dtTableName];
    DataRow[] dataRowArray1 = table.Select((string) null, (string) null, DataViewRowState.ModifiedCurrent);
    int index1 = 0;
    while (index1 < dataRowArray1.Length)
    {
      DataRow dataRow = dataRowArray1[index1];
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
        {
          string Left = dataRow[column, DataRowVersion.Original].ToString();
          string Right = dataRow[column, DataRowVersion.Current].ToString();
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, Right, false) != 0)
            strAction = $"{strAction} Original {column.Caption}: {Left} was changed to: {Right}";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} for {strcontext}: {dataRow[strcontext].ToString()}", Guid.Parse(dataRow[strGUIDtoLog].ToString()), $"{strcontext}: {dataRow[strcontext].ToString()}");
      checked { ++index1; }
    }
    DataRow[] dataRowArray2 = table.Select((string) null, (string) null, DataViewRowState.Added);
    int index2 = 0;
    while (index2 < dataRowArray2.Length)
    {
      DataRow dataRow = dataRowArray2[index2];
      string str = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str = $"{str}  {column.Caption}: {dataRow[column, DataRowVersion.Current].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} User inserted new record. {str}");
      checked { ++index2; }
    }
    DataRow[] dataRowArray3 = table.Select((string) null, (string) null, DataViewRowState.Deleted);
    int index3 = 0;
    while (index3 < dataRowArray3.Length)
    {
      DataRow dataRow = dataRowArray3[index3];
      string str = "";
      try
      {
        foreach (DataColumn column in (InternalDataCollectionBase) table.Columns)
          str = $"{str} {column.Caption}: {dataRow[column, DataRowVersion.Original].ToString()}";
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      CurrentUser.Instance.LogAction($"{strAction} User deleted the record. {str}");
      checked { ++index3; }
    }
  }

  private void dgProgramCodes_AfterRowsDeleted(object sender, EventArgs e)
  {
    int num = 1;
    foreach (UltraGridRow row in ((UltraGridBase) this.dgProgramCodes).Rows)
    {
      row.Cells["RowNum"].Value = (object) num;
      ++num;
    }
  }

  private void lnkAddProgramCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    UltraGridRow ultraGridRow = ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0].AddNew();
    ultraGridRow.Cells["RowNum"].Value = (object) (Utility.IsNull<int>(RuntimeHelpers.GetObjectValue(this.ds.tblCompanyProgramCodes.Compute("MAX(RowNum)", string.Empty)), 0) + 1);
    ultraGridRow.Cells["CompanyLocationGUID"].Value = (object) this._emptyLocationGuid;
    ultraGridRow.Cells["StateID"].Value = (object) string.Empty;
    ultraGridRow.Cells["ContractEffective"].Value = (object) DateTime.Now;
    ultraGridRow.Cells["ContractExpiration"].Value = (object) DateTime.Now.AddYears(1);
    ultraGridRow.Cells["LineGUID"].Value = (object) this._emptyLineGuid;
    ultraGridRow.Cells["IssuingOfficeGUID"].Value = (object) this._emptyIssuingOfficeGuid;
    ultraGridRow.Cells["ProgCode"].Value = (object) string.Empty;
    ultraGridRow.Cells["GroupCode"].Value = (object) "&&";
    ultraGridRow.Cells["ParentLineGUID"].Value = (object) Guid.Empty;
    Guid guid = Guid.NewGuid();
    ultraGridRow.Cells["ProgramCodeGuid"].Value = (object) guid;
    this._programCodeGuid = guid;
  }

  private void lnkCancelProgramCode_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.ds.RejectChanges();
    ((UltraGridBase) this.dgProgramCodes).UpdateData();
    this.ds.RejectChanges();
    ((UltraGridBase) this.dgProgramCodes).UpdateData();
  }

  private void ddState_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.SetDropDownRowsVisibility(this.ddState, "StateID", string.Empty);
  }

  private void ddLine_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.SetDropDownRowsVisibility(this.ddLine, "LineGuid", this._emptyLineGuid.ToString());
  }

  private void ddClientOffice_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.SetDropDownRowsVisibility(this.ddClientOffice, "OfficeGUID", this._emptyIssuingOfficeGuid.ToString());
  }

  private void ddCompanyLocations_BeforeDropDown(object sender, CancelEventArgs e)
  {
    this.SetDropDownRowsVisibility(this.ddCompanyLocations, "CompanyLocationGUID", this._emptyLocationGuid.ToString());
  }

  private void SetDropDownRowsVisibility(
    UltraDropDown dd,
    string gridColumn,
    string hiddenColumnValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) dd).Rows)
    {
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells[gridColumn].Value)) && row.Cells[gridColumn].Value.ToString().Equals(hiddenColumnValue))
        row.Hidden = true;
    }
  }

  private void dgProgramCodes_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    e.Layout.RowSelectorImages.DataChangedImage = (Image) null;
  }

  public event ISupportDocumentSystem.EntityInfoChangedEventHandler DocumentChanged;

  public bool AllowAddNewDocument => true;

  string IRecreatableEntity.EntityName => this._programCodeName;

  Guid IRecreatableEntity.EntityGuid => this._programCodeGuid;

  string IRecreatableEntity.FriendlyEntityName => "Program Codes";

  string IRecreatableEntity.RecreateTypeName => typeof (FormProgramCode).ToString();

  bool IRecreatableEntity.CanReCreateEntity => false;

  bool IRecreatableEntity.HasControlGUID => false;

  Guid IRecreatableEntity.ControlGUID => Guid.Empty;

  bool IRecreatableEntity.RecreateEntityInitialize(Guid entityGuid)
  {
    bool flag;
    return flag;
  }

  private void dgProgramCodes_AfterSelectChanged(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgProgramCodes).ActiveRow != null && !((UltraGridBase) this.dgProgramCodes).ActiveRow.IsAddRow)
    {
      dsProgramCodes.tblCompanyProgramCodesRow row = (dsProgramCodes.tblCompanyProgramCodesRow) ((DataRowView) ((UltraGridBase) this.dgProgramCodes).ActiveRow.ListObject).Row;
      this._programCodeGuid = row.ProgramCodeGuid;
      this._programCodeName = row.ProgCode;
    }
    else
    {
      this._programCodeGuid = Guid.Empty;
      this._programCodeName = "";
    }
    // ISSUE: reference to a compiler-generated field
    ISupportDocumentSystem.EntityInfoChangedEventHandler documentChangedEvent = this.DocumentChangedEvent;
    if (documentChangedEvent == null)
      return;
    documentChangedEvent((object) this, e);
  }

  private void DgProgramCodes_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
  {
    int num1 = e.Rows.Length - 1;
    for (int index = 0; index <= num1; ++index)
    {
      if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(e.Rows[0].Cells["ProgCode"].Value)))
      {
        string str = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "select top 1 RuleName from tblPolicyNumberRules with (nolock) where ProgCode=@PG", new object[2]
        {
          (object) "@PG",
          e.Rows[0].Cells["ProgCode"].Value
        });
        if (!Utility.IsNull((object) str))
        {
          e.DisplayPromptMsg = false;
          int num2 = (int) MessageBox.Show($"Cannot delete program code {RuntimeHelpers.GetObjectValue(e.Rows[0].Cells["ProgCode"].Value)} because it is " + $"assigned to policy # rule {str}", "Cannot Delete Program Code", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
          ((CancelEventArgs) e).Cancel = true;
        }
      }
    }
  }

  protected virtual bool IsAppliedCode()
  {
    DataRow[] dataRowArray = this.ds.tblCompanyProgramCodes.Select((string) null, (string) null, DataViewRowState.Deleted);
    int index = 0;
    bool flag;
    while (index < dataRowArray.Length)
    {
      DataRow dataRow = dataRowArray[index];
      if (DefaultDatabase.ExecuteScalar<bool>("spAppliedProgramCodeCheck", new object[2]
      {
        (object) "@ProgramID",
        dataRow["ProgramID", DataRowVersion.Original]
      }))
      {
        int num = (int) MessageBox.Show($"Prog code '{RuntimeHelpers.GetObjectValue(dataRow["ProgCode", DataRowVersion.Original])}' is already applied to a bound policy and cannot be deleted", "Program Code Applied - Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag = true;
        goto label_24;
      }
      checked { ++index; }
    }
    if (!this._canEditProgramCode.Value)
    {
      try
      {
        foreach (dsProgramCodes.tblCompanyProgramCodesRow row in this.ds.tblCompanyProgramCodes.Rows)
        {
          if (row.RowState == DataRowState.Modified && this._currentProgramCodes.ContainsKey(row.ProgramID))
          {
            int num1;
            if (this._currentProgramCodes[row.ProgramID].ProgCode.Equals(row.ProgCode) && this._currentProgramCodes[row.ProgramID].StateID.Equals(row.StateID))
            {
              string company = this._currentProgramCodes[row.ProgramID].Company;
              Guid guid = row.CompanyLocationGUID;
              string str1 = guid.ToString();
              if (company.Equals(str1))
              {
                string eff = this._currentProgramCodes[row.ProgramID].Eff;
                DateTime dateTime = row.ContractEffective;
                string str2 = dateTime.ToString();
                if (eff.Equals(str2))
                {
                  string exp = this._currentProgramCodes[row.ProgramID].Exp;
                  dateTime = row.ContractExpiration;
                  string str3 = dateTime.ToString();
                  if (exp.Equals(str3))
                  {
                    string line = this._currentProgramCodes[row.ProgramID].line;
                    guid = row.LineGUID;
                    string str4 = guid.ToString();
                    if (line.Equals(str4))
                    {
                      string issuingOffice = this._currentProgramCodes[row.ProgramID].IssuingOffice;
                      guid = row.IssuingOfficeGUID;
                      string str5 = guid.ToString();
                      if (issuingOffice.Equals(str5) && this._currentProgramCodes[row.ProgramID].GroupCode.Equals(row.GroupCode))
                      {
                        string parentLine = this._currentProgramCodes[row.ProgramID].ParentLine;
                        guid = row.ParentLineGUID;
                        string str6 = guid.ToString();
                        num1 = !parentLine.Equals(str6) ? 1 : 0;
                        goto label_16;
                      }
                    }
                  }
                }
              }
            }
            num1 = 1;
label_16:
            if (num1 != 0)
            {
              if (DefaultDatabase.ExecuteScalar<bool>("spAppliedProgramCodeCheck", new object[2]
              {
                (object) "@ProgramID",
                (object) row.ProgramID
              }))
              {
                int num2 = (int) MessageBox.Show($"Prog code '{row.ProgCode}' on row# {row.RowNum} is already applied to a bound policy and cannot be modified", "Program Code Applied - Cannot Modify", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                flag = true;
                goto label_24;
              }
            }
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }
    flag = false;
label_24:
    return flag;
  }

  private void GatherProgramCodes()
  {
    try
    {
      foreach (dsProgramCodes.tblCompanyProgramCodesRow row in this.ds.tblCompanyProgramCodes.Rows)
      {
        FormProgramCode.progStructure progStructure = new FormProgramCode.progStructure();
        progStructure.ProgCode = row.ProgCode;
        progStructure.StateID = row.StateID;
        progStructure.Company = row.CompanyLocationGUID.ToString();
        progStructure.Eff = row.ContractEffective.ToString();
        progStructure.Exp = row.ContractExpiration.ToString();
        progStructure.line = row.LineGUID.ToString();
        progStructure.IssuingOffice = row.IssuingOfficeGUID.ToString();
        progStructure.GroupCode = string.Empty;
        if (!row.IsGroupCodeNull())
          progStructure.GroupCode = row.GroupCode;
        progStructure.ParentLine = string.Empty;
        if (!row.IsParentLineGUIDNull())
          progStructure.ParentLine = row.ParentLineGUID.ToString();
        this._currentProgramCodes.Add(row.ProgramID, progStructure);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  protected virtual void UpdateProgramCodes()
  {
    using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.tblCompanyProgramCodes, "dbo.InsertProgamCodes", "dbo.UpdateProgamCodes", "dbo.DeleteProgamCodes", true, 30, (DbTransaction) null))
      DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.tblCompanyProgramCodes);
  }

  private bool ShowBaseProgramCodeExtension()
  {
    if (this._showBaseProgCodeExt.Value)
    {
      dsProgramCodes.tblCompanyProgramCodesDataTable companyProgramCodes = this.ds.tblCompanyProgramCodes;
      companyProgramCodes.Columns.Add("ExtensionsProgCode", typeof (string));
      companyProgramCodes.Columns["ExtensionsProgCode"].DefaultValue = (object) "Add Ext.";
      companyProgramCodes.Columns.Add("ExtensionsParticipation", typeof (string));
      companyProgramCodes.Columns["ExtensionsParticipation"].DefaultValue = (object) "Participation";
      ((UltraGridBase) this.dgProgramCodes).UpdateData();
      Appearance appearance1 = new Appearance();
      appearance1.FontData.Underline = (DefaultableBoolean) 1;
      appearance1.ForeColor = Color.Blue;
      appearance1.TextHAlign = (HAlign) 2;
      Appearance appearance2 = new Appearance();
      appearance2.FontData.Underline = (DefaultableBoolean) 1;
      appearance2.ForeColor = Color.Blue;
      appearance2.TextHAlign = (HAlign) 2;
      UltraGridBand band = ((UltraGridBase) this.dgProgramCodes).DisplayLayout.Bands[0];
      band.Columns["ExtensionsProgCode"].CellAppearance = (AppearanceBase) appearance1;
      band.Columns["ExtensionsProgCode"].Editor = (EmbeddableEditorBase) this._baseAdddata;
      band.Columns["ExtensionsParticipation"].CellAppearance = (AppearanceBase) appearance2;
      band.Columns["ExtensionsParticipation"].Editor = (EmbeddableEditorBase) this._basePartData;
      ((UltraGridBase) this.dgProgramCodes).UpdateData();
      this._baseAdddata.HyperLinkOpening += new CancelEventHandler(this.BaseAddData_HyperLinkOpening);
      this._basePartData.HyperLinkOpening += new CancelEventHandler(this.BasePartData_HyperLinkOpening);
    }
    bool flag;
    return flag;
  }

  private struct progStructure
  {
    public string ProgCode;
    public string StateID;
    public string Company;
    public string Eff;
    public string Exp;
    public string line;
    public string IssuingOffice;
    public string GroupCode;
    public string ParentLine;
  }
}
