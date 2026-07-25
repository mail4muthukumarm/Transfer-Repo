// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormRaterConditionalsAdmin
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
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
public class FormRaterConditionalsAdmin : Form
{
  private IContainer components;

  public FormRaterConditionalsAdmin()
  {
    this.Load += new EventHandler(this.FormPolicyLimitRestriction_Load);
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
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblRaterConditionalElements", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ElementID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RaterID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Element");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("IsNumericValue");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("Conditions", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Condition");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("ID");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance14 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("lstRatingTypes", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("RatingTypeID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("RatingType");
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook3 = new ScrollBarLook();
    Appearance appearance18 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("State");
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    Appearance appearance21 = new Appearance();
    ScrollBarLook scrollBarLook4 = new ScrollBarLook();
    Appearance appearance22 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("LineName");
    Appearance appearance23 = new Appearance();
    Appearance appearance24 = new Appearance();
    Appearance appearance25 = new Appearance();
    ScrollBarLook scrollBarLook5 = new ScrollBarLook();
    Appearance appearance26 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("LocationName");
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    ScrollBarLook scrollBarLook6 = new ScrollBarLook();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormRaterConditionalsAdmin));
    UltraGridBand ultraGridBand7 = new UltraGridBand("tblRaterConditionalElements", -1);
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("ElementID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("RaterID");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("Element");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("IsNumericValue");
    UltraGridBand ultraGridBand8 = new UltraGridBand("Conditions", -1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Condition");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ID");
    UltraGridBand ultraGridBand9 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("State");
    UltraGridBand ultraGridBand10 = new UltraGridBand("lstRatingTypes", -1);
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("RatingTypeID");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("RatingType");
    UltraGridBand ultraGridBand11 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn25 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn26 = new UltraGridColumn("LineName");
    UltraGridBand ultraGridBand12 = new UltraGridBand("tblCompanyLocations", -1);
    UltraGridColumn ultraGridColumn27 = new UltraGridColumn("CompanyLocationGUID");
    UltraGridColumn ultraGridColumn28 = new UltraGridColumn("LocationName");
    Appearance appearance30 = new Appearance();
    UltraGridBand ultraGridBand13 = new UltraGridBand("tblCompanyLineRaterConditionals", -1);
    UltraGridColumn ultraGridColumn29 = new UltraGridColumn("ConditionalID", -1, (object) "ddElement");
    UltraGridColumn ultraGridColumn30 = new UltraGridColumn("CompanyLocationGuid", -1, (object) "ddCompanyLocation");
    UltraGridColumn ultraGridColumn31 = new UltraGridColumn("LineGuid", -1, (object) "ddLines");
    UltraGridColumn ultraGridColumn32 = new UltraGridColumn("StateID", -1, (object) "ddStates");
    UltraGridColumn ultraGridColumn33 = new UltraGridColumn("RaterID", -1, (object) "ddRaterTypes");
    UltraGridColumn ultraGridColumn34 = new UltraGridColumn("RaterElementID", -1, (object) "ddElement");
    UltraGridColumn ultraGridColumn35 = new UltraGridColumn("RaterConditionalID", -1, (object) "ddCondition");
    UltraGridColumn ultraGridColumn36 = new UltraGridColumn("ValueString");
    UltraGridColumn ultraGridColumn37 = new UltraGridColumn("ValueNumeric");
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    this.cnSQL = new SqlConnection();
    this.daLoadData = new SqlDataAdapter();
    this.SqlSelectCommand3 = new SqlCommand();
    this.panelControls = new MGAGroupBox();
    this.Label8 = new Label();
    this.cboElement = new MGAComboBox();
    this.ds = new dsRaterConditionals();
    this.txtValueNumeric = new MGANumericEditor();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.Label7 = new Label();
    this.Label6 = new Label();
    this.txtValueString = new MGATextBox();
    this.Label5 = new Label();
    this.cboConditions = new MGAComboBox();
    this.Label4 = new Label();
    this.cboRater = new MGAComboBox();
    this.Label3 = new Label();
    this.cboState = new MGAComboBox();
    this.Label2 = new Label();
    this.cboLines = new MGAComboBox();
    this.Label1 = new Label();
    this.cboCompanyLocation = new MGAComboBox();
    this.err = new ErrorProvider(this.components);
    this.da = new SqlDataAdapter();
    this.SqlDeleteCommand4 = new SqlCommand();
    this.SqlInsertCommand4 = new SqlCommand();
    this.SqlCommand1 = new SqlCommand();
    this.SqlUpdateCommand4 = new SqlCommand();
    this.ddElement = new UltraDropDown();
    this.ddCondition = new UltraDropDown();
    this.ddStates = new UltraDropDown();
    this.ddRaterTypes = new UltraDropDown();
    this.ddLines = new UltraDropDown();
    this.ddCompanyLocation = new UltraDropDown();
    this.dgPolicyLimitRestriction = new UltraGrid();
    ((ISupportInitialize) this.panelControls).BeginInit();
    ((Control) this.panelControls).SuspendLayout();
    ((ISupportInitialize) this.cboElement).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.txtValueNumeric).BeginInit();
    ((ISupportInitialize) this.txtValueString).BeginInit();
    ((ISupportInitialize) this.cboConditions).BeginInit();
    ((ISupportInitialize) this.cboRater).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    ((ISupportInitialize) this.cboLines).BeginInit();
    ((ISupportInitialize) this.cboCompanyLocation).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddElement).BeginInit();
    ((ISupportInitialize) this.ddCondition).BeginInit();
    ((ISupportInitialize) this.ddStates).BeginInit();
    ((ISupportInitialize) this.ddRaterTypes).BeginInit();
    ((ISupportInitialize) this.ddLines).BeginInit();
    ((ISupportInitialize) this.ddCompanyLocation).BeginInit();
    ((ISupportInitialize) this.dgPolicyLimitRestriction).BeginInit();
    this.SuspendLayout();
    this.cnSQL.ConnectionString = "Data Source=MGASYSTEMS;Initial Catalog=IMS;Integrated Security=True";
    this.cnSQL.FireInfoMessageEventOnUserErrors = false;
    this.daLoadData.SelectCommand = this.SqlSelectCommand3;
    this.daLoadData.TableMappings.AddRange(new DataTableMapping[2]
    {
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[3]
      {
        new DataColumnMapping("OfficeID", "OfficeID"),
        new DataColumnMapping("ChargeCode", "ChargeCode"),
        new DataColumnMapping("ChargeName", "ChargeName")
      }),
      new DataTableMapping("Table", "Table", new DataColumnMapping[0])
    });
    this.SqlSelectCommand3.CommandText = "[GetPolicyLimitRestrictionsData]";
    this.SqlSelectCommand3.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand3.Connection = this.cnSQL;
    ((Control) this.panelControls).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelControls.Appearance = (AppearanceBase) appearance1;
    this.panelControls.BackColorInternal = Color.FromArgb(239, 247, 253);
    appearance2.BackColor = Color.FromArgb(239, 247, 253);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelControls.ContentAreaAppearance = (AppearanceBase) appearance2;
    ((Control) this.panelControls).Controls.Add((Control) this.Label8);
    ((Control) this.panelControls).Controls.Add((Control) this.cboElement);
    ((Control) this.panelControls).Controls.Add((Control) this.txtValueNumeric);
    ((Control) this.panelControls).Controls.Add((Control) this.dbSave);
    ((Control) this.panelControls).Controls.Add((Control) this.Label7);
    ((Control) this.panelControls).Controls.Add((Control) this.Label6);
    ((Control) this.panelControls).Controls.Add((Control) this.txtValueString);
    ((Control) this.panelControls).Controls.Add((Control) this.Label5);
    ((Control) this.panelControls).Controls.Add((Control) this.cboConditions);
    ((Control) this.panelControls).Controls.Add((Control) this.Label4);
    ((Control) this.panelControls).Controls.Add((Control) this.cboRater);
    ((Control) this.panelControls).Controls.Add((Control) this.Label3);
    ((Control) this.panelControls).Controls.Add((Control) this.cboState);
    ((Control) this.panelControls).Controls.Add((Control) this.Label2);
    ((Control) this.panelControls).Controls.Add((Control) this.cboLines);
    ((Control) this.panelControls).Controls.Add((Control) this.Label1);
    ((Control) this.panelControls).Controls.Add((Control) this.cboCompanyLocation);
    appearance3.ForeColor = Color.FromArgb(21, 66, 139);
    this.panelControls.HeaderAppearance = (AppearanceBase) appearance3;
    ((Control) this.panelControls).Location = new Point(12, 206);
    ((Control) this.panelControls).Name = "panelControls";
    ((Control) this.panelControls).Size = new Size(798, 196);
    ((Control) this.panelControls).TabIndex = 31 /*0x1F*/;
    this.panelControls.Text = "Company Line Rater Conditionals";
    this.panelControls.ViewStyle = (GroupBoxViewStyle) 2;
    this.Label8.AutoSize = true;
    this.Label8.Location = new Point(436, 31 /*0x1F*/);
    this.Label8.Name = "Label8";
    this.Label8.Size = new Size(48 /*0x30*/, 13);
    this.Label8.TabIndex = 40;
    this.Label8.Text = "Element:";
    this.cboElement.BorderStyle = (UIElementBorderStyle) 4;
    this.cboElement.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboElement).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineRaterConditionals.RaterElementID", true));
    ((UltraGridBase) this.cboElement).DataSource = (object) this.ds.tblRaterConditionalElements;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboElement.DisplayLayout.Appearance = (AppearanceBase) appearance4;
    this.cboElement.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 75;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn2.Width = 171;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 104;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 102;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    this.cboElement.DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    this.cboElement.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboElement.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboElement.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboElement.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboElement.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboElement.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboElement.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboElement.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboElement.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboElement.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance5.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance5.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboElement.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance5;
    appearance6.BorderColor = Color.White;
    this.cboElement.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    this.cboElement.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance7.ForeColor = Color.Black;
    this.cboElement.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboElement.DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraDropDownBase) this.cboElement).DisplayMember = "Element";
    this.cboElement.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboElement.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboElement).DropDownWidth = 300;
    ((Control) this.cboElement).Location = new Point(490, 27);
    this.cboElement.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboElement).Name = "cboElement";
    ((Control) this.cboElement).Size = new Size(239, 20);
    ((Control) this.cboElement).TabIndex = 39;
    ((UltraControlBase) this.cboElement).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboElement).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboElement).ValueMember = "ElementID";
    this.ds.DataSetName = "dsRaterConditionals";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.txtValueNumeric).Appearance = (AppearanceBase) appearance8;
    ((Control) this.txtValueNumeric).CausesValidation = false;
    ((Control) this.txtValueNumeric).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineRaterConditionals.ValueNumeric", true));
    ((Control) this.txtValueNumeric).Location = new Point(490, 84);
    this.txtValueNumeric.MaskInput = "nnnnnnnnnn.nn";
    this.txtValueNumeric.MaxValue = (object) 5000000000L;
    this.txtValueNumeric.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtValueNumeric).Name = "txtValueNumeric";
    this.txtValueNumeric.Nullable = true;
    this.txtValueNumeric.NumericType = (NumericType) 1;
    ((Control) this.txtValueNumeric).Size = new Size(125, 19);
    ((Control) this.txtValueNumeric).TabIndex = 38;
    ((UltraControlBase) this.txtValueNumeric).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtValueNumeric).UseOsThemes = (DefaultableBoolean) 2;
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(681, 151);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 37;
    this.dbSave.UIState = UIState.Editing;
    this.Label7.AutoSize = true;
    this.Label7.Location = new Point(392, 87);
    this.Label7.Name = "Label7";
    this.Label7.Size = new Size(92, 13);
    this.Label7.TabIndex = 35;
    this.Label7.Text = "Value As Number:";
    this.Label6.AutoSize = true;
    this.Label6.Location = new Point(402, 58);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(82, 13);
    this.Label6.TabIndex = 34;
    this.Label6.Text = "Value As String:";
    appearance9.BackColor = Color.White;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance9.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtValueString).Appearance = (AppearanceBase) appearance9;
    ((TextEditorControlBase) this.txtValueString).BackColor = Color.White;
    ((Control) this.txtValueString).DataBindings.Add(new Binding("Text", (object) this.ds, "tblCompanyLineRaterConditionals.ValueString", true));
    ((Control) this.txtValueString).Location = new Point(490, 58);
    this.txtValueString.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtValueString).Name = "txtValueString";
    ((Control) this.txtValueString).Size = new Size(239, 19);
    ((Control) this.txtValueString).TabIndex = 33;
    ((UltraControlBase) this.txtValueString).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtValueString).UseOsThemes = (DefaultableBoolean) 2;
    this.Label5.AutoSize = true;
    this.Label5.Location = new Point(49, 155);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(54, 13);
    this.Label5.TabIndex = 32 /*0x20*/;
    this.Label5.Text = "Condition:";
    this.cboConditions.BorderStyle = (UIElementBorderStyle) 4;
    this.cboConditions.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboConditions).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineRaterConditionals.RaterConditionalID", true));
    ((UltraGridBase) this.cboConditions).DataSource = (object) this.ds.Conditions;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboConditions.DisplayLayout.Appearance = (AppearanceBase) appearance10;
    this.cboConditions.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Width = 281;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 138;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    this.cboConditions.DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    this.cboConditions.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboConditions.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboConditions.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboConditions.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboConditions.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboConditions.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboConditions.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboConditions.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboConditions.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboConditions.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance11.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance11.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboConditions.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.White;
    this.cboConditions.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    this.cboConditions.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance13.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance13.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance13.ForeColor = Color.Black;
    this.cboConditions.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance13;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboConditions.DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraDropDownBase) this.cboConditions).DisplayMember = "Condition";
    this.cboConditions.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboConditions.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboConditions).DropDownWidth = 300;
    ((Control) this.cboConditions).Location = new Point(109, 151);
    this.cboConditions.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboConditions).Name = "cboConditions";
    ((Control) this.cboConditions).Size = new Size(274, 20);
    ((Control) this.cboConditions).TabIndex = 31 /*0x1F*/;
    ((UltraControlBase) this.cboConditions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboConditions).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboConditions).ValueMember = "ID";
    this.Label4.AutoSize = true;
    this.Label4.Location = new Point(67, 124);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(36, 13);
    this.Label4.TabIndex = 30;
    this.Label4.Text = "Rater:";
    this.cboRater.BorderStyle = (UIElementBorderStyle) 4;
    this.cboRater.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboRater).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineRaterConditionals.RaterID", true));
    ((UltraGridBase) this.cboRater).DataSource = (object) this.ds.lstRatingTypes;
    appearance14.BackColor = Color.White;
    appearance14.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboRater.DisplayLayout.Appearance = (AppearanceBase) appearance14;
    this.cboRater.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand3.ColHeadersVisible = false;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 203;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 431;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    this.cboRater.DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    this.cboRater.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboRater.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboRater.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboRater.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboRater.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboRater.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboRater.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboRater.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboRater.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboRater.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance15.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance15.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboRater.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.White;
    this.cboRater.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    this.cboRater.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance17.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance17.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance17.ForeColor = Color.Black;
    this.cboRater.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    scrollBarLook3.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboRater.DisplayLayout.ScrollBarLook = scrollBarLook3;
    ((UltraDropDownBase) this.cboRater).DisplayMember = "RatingType";
    this.cboRater.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboRater.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboRater).DropDownWidth = 450;
    ((Control) this.cboRater).Location = new Point(109, 120);
    this.cboRater.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboRater).Name = "cboRater";
    ((Control) this.cboRater).Size = new Size(274, 20);
    ((Control) this.cboRater).TabIndex = 29;
    ((UltraControlBase) this.cboRater).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboRater).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboRater).ValueMember = "RatingTypeID";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(68, 93);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(35, 13);
    this.Label3.TabIndex = 28;
    this.Label3.Text = "State:";
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    this.cboState.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboState).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineRaterConditionals.StateID", true));
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds.lstStates;
    appearance18.BackColor = Color.White;
    appearance18.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboState.DisplayLayout.Appearance = (AppearanceBase) appearance18;
    this.cboState.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand4.ColHeadersVisible = false;
    ultraGridColumn9.Header.VisiblePosition = 1;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 156;
    ultraGridColumn10.Header.VisiblePosition = 0;
    ultraGridColumn10.Width = 431;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    this.cboState.DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    this.cboState.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboState.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboState.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance19.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance19.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboState.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance19;
    appearance20.BorderColor = Color.White;
    this.cboState.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance20;
    this.cboState.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance21.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance21.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance21.ForeColor = Color.Black;
    this.cboState.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance21;
    scrollBarLook4.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboState.DisplayLayout.ScrollBarLook = scrollBarLook4;
    ((UltraDropDownBase) this.cboState).DisplayMember = "StateID";
    this.cboState.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboState).DropDownWidth = 450;
    ((Control) this.cboState).Location = new Point(109, 89);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(274, 20);
    ((Control) this.cboState).TabIndex = 27;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(73, 62);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(30, 13);
    this.Label2.TabIndex = 26;
    this.Label2.Text = "Line:";
    this.cboLines.BorderStyle = (UIElementBorderStyle) 4;
    this.cboLines.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboLines).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineRaterConditionals.LineGuid", true));
    ((UltraGridBase) this.cboLines).DataSource = (object) this.ds.lstLines;
    appearance22.BackColor = Color.White;
    appearance22.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboLines.DisplayLayout.Appearance = (AppearanceBase) appearance22;
    this.cboLines.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand5.ColHeadersVisible = false;
    ultraGridColumn11.Header.VisiblePosition = 0;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 310;
    ultraGridColumn12.Header.VisiblePosition = 1;
    ultraGridColumn12.Width = 431;
    ultraGridBand5.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    this.cboLines.DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    this.cboLines.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboLines.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboLines.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance23.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance23.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboLines.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance23;
    appearance24.BorderColor = Color.White;
    this.cboLines.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance24;
    this.cboLines.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance25.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance25.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance25.ForeColor = Color.Black;
    this.cboLines.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance25;
    scrollBarLook5.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboLines.DisplayLayout.ScrollBarLook = scrollBarLook5;
    ((UltraDropDownBase) this.cboLines).DisplayMember = "LineName";
    this.cboLines.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboLines.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLines).DropDownWidth = 450;
    ((Control) this.cboLines).Location = new Point(109, 58);
    this.cboLines.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLines).Name = "cboLines";
    ((Control) this.cboLines).Size = new Size(274, 20);
    ((Control) this.cboLines).TabIndex = 25;
    ((UltraControlBase) this.cboLines).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLines).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLines).ValueMember = "LineGUID";
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(5, 31 /*0x1F*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(98, 13);
    this.Label1.TabIndex = 24;
    this.Label1.Text = "Company Location:";
    this.cboCompanyLocation.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCompanyLocation.CharacterCasing = CharacterCasing.Normal;
    ((Control) this.cboCompanyLocation).DataBindings.Add(new Binding("Value", (object) this.ds, "tblCompanyLineRaterConditionals.CompanyLocationGuid", true));
    ((UltraGridBase) this.cboCompanyLocation).DataSource = (object) this.ds.tblCompanyLocations;
    appearance26.BackColor = Color.White;
    appearance26.BorderColor = Color.FromArgb(78, 122, 171);
    this.cboCompanyLocation.DisplayLayout.Appearance = (AppearanceBase) appearance26;
    this.cboCompanyLocation.DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand6.ColHeadersVisible = false;
    ultraGridColumn13.Header.VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 310;
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn14.Width = 431;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn13,
      (object) ultraGridColumn14
    });
    this.cboCompanyLocation.DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    this.cboCompanyLocation.DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    this.cboCompanyLocation.DisplayLayout.BorderStyleCaption = (UIElementBorderStyle) 1;
    this.cboCompanyLocation.DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    this.cboCompanyLocation.DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    this.cboCompanyLocation.DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    this.cboCompanyLocation.DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    this.cboCompanyLocation.DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    this.cboCompanyLocation.DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    this.cboCompanyLocation.DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    this.cboCompanyLocation.DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    appearance27.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance27.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this.cboCompanyLocation.DisplayLayout.Override.HotTrackRowAppearance = (AppearanceBase) appearance27;
    appearance28.BorderColor = Color.White;
    this.cboCompanyLocation.DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance28;
    this.cboCompanyLocation.DisplayLayout.Override.RowSpacingAfter = 1;
    appearance29.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance29.BorderColor = Color.FromArgb((int) byte.MaxValue, 214, 88);
    appearance29.ForeColor = Color.Black;
    this.cboCompanyLocation.DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance29;
    scrollBarLook6.ViewStyle = (ScrollBarViewStyle) 3;
    this.cboCompanyLocation.DisplayLayout.ScrollBarLook = scrollBarLook6;
    ((UltraDropDownBase) this.cboCompanyLocation).DisplayMember = "LocationName";
    this.cboCompanyLocation.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.cboCompanyLocation.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboCompanyLocation).DropDownWidth = 450;
    ((Control) this.cboCompanyLocation).Location = new Point(109, 27);
    this.cboCompanyLocation.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboCompanyLocation).Name = "cboCompanyLocation";
    ((Control) this.cboCompanyLocation).Size = new Size(274, 20);
    ((Control) this.cboCompanyLocation).TabIndex = 23;
    ((UltraControlBase) this.cboCompanyLocation).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboCompanyLocation).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboCompanyLocation).ValueMember = "CompanyLocationGUID";
    this.err.ContainerControl = (ContainerControl) this;
    this.da.DeleteCommand = this.SqlDeleteCommand4;
    this.da.InsertCommand = this.SqlInsertCommand4;
    this.da.SelectCommand = this.SqlCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "tblCompanyLineRaterConditionals", new DataColumnMapping[9]
      {
        new DataColumnMapping("ConditionalID", "ConditionalID"),
        new DataColumnMapping("CompanyLocationGuid", "CompanyLocationGuid"),
        new DataColumnMapping("LineGuid", "LineGuid"),
        new DataColumnMapping("StateID", "StateID"),
        new DataColumnMapping("RaterID", "RaterID"),
        new DataColumnMapping("RaterElementID", "RaterElementID"),
        new DataColumnMapping("RaterConditionalID", "RaterConditionalID"),
        new DataColumnMapping("ValueString", "ValueString"),
        new DataColumnMapping("ValueNumeric", "ValueNumeric")
      })
    });
    this.da.UpdateCommand = this.SqlUpdateCommand4;
    this.SqlDeleteCommand4.CommandText = "DELETE FROM [tblCompanyLineRaterConditionals] WHERE (([ConditionalID] = @Original_ConditionalID))";
    this.SqlDeleteCommand4.Connection = this.cnSQL;
    this.SqlDeleteCommand4.Parameters.AddRange(new SqlParameter[1]
    {
      new SqlParameter("@Original_ConditionalID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ConditionalID", DataRowVersion.Original, (object) null)
    });
    this.SqlInsertCommand4.CommandText = componentResourceManager.GetString("SqlInsertCommand4.CommandText");
    this.SqlInsertCommand4.Connection = this.cnSQL;
    this.SqlInsertCommand4.Parameters.AddRange(new SqlParameter[8]
    {
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 0, "LineGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@RaterID", SqlDbType.Int, 0, "RaterID"),
      new SqlParameter("@RaterElementID", SqlDbType.TinyInt, 0, "RaterElementID"),
      new SqlParameter("@RaterConditionalID", SqlDbType.VarChar, 0, "RaterConditionalID"),
      new SqlParameter("@ValueString", SqlDbType.VarChar, 0, "ValueString"),
      new SqlParameter("@ValueNumeric", SqlDbType.Money, 0, "ValueNumeric")
    });
    this.SqlCommand1.CommandText = "SELECT     ConditionalID, CompanyLocationGuid, LineGuid, StateID, RaterID, RaterElementID, RaterConditionalID, ValueString, ValueNumeric\r\nFROM         tblCompanyLineRaterConditionals";
    this.SqlCommand1.Connection = this.cnSQL;
    this.SqlUpdateCommand4.CommandText = componentResourceManager.GetString("SqlUpdateCommand4.CommandText");
    this.SqlUpdateCommand4.Connection = this.cnSQL;
    this.SqlUpdateCommand4.Parameters.AddRange(new SqlParameter[10]
    {
      new SqlParameter("@CompanyLocationGuid", SqlDbType.UniqueIdentifier, 0, "CompanyLocationGuid"),
      new SqlParameter("@LineGuid", SqlDbType.UniqueIdentifier, 0, "LineGuid"),
      new SqlParameter("@StateID", SqlDbType.Char, 0, "StateID"),
      new SqlParameter("@RaterID", SqlDbType.Int, 0, "RaterID"),
      new SqlParameter("@RaterElementID", SqlDbType.TinyInt, 0, "RaterElementID"),
      new SqlParameter("@RaterConditionalID", SqlDbType.VarChar, 0, "RaterConditionalID"),
      new SqlParameter("@ValueString", SqlDbType.VarChar, 0, "ValueString"),
      new SqlParameter("@ValueNumeric", SqlDbType.Money, 0, "ValueNumeric"),
      new SqlParameter("@Original_ConditionalID", SqlDbType.Int, 0, ParameterDirection.Input, false, (byte) 0, (byte) 0, "ConditionalID", DataRowVersion.Original, (object) null),
      new SqlParameter("@ConditionalID", SqlDbType.Int, 4, "ConditionalID")
    });
    ((Control) this.ddElement).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddElement).DataSource = (object) this.ds.tblRaterConditionalElements;
    ((UltraGridBase) this.ddElement).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn15.Header.VisiblePosition = 0;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn16.Header.VisiblePosition = 1;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn17.Header.VisiblePosition = 2;
    ultraGridColumn18.Header.VisiblePosition = 3;
    ultraGridColumn18.Hidden = true;
    ultraGridBand7.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ((UltraGridBase) this.ddElement).DisplayLayout.BandsSerializer.Add((object) ultraGridBand7);
    ((UltraDropDownBase) this.ddElement).DisplayMember = "Element";
    ((UltraDropDownBase) this.ddElement).DropDownWidth = 400;
    ((Control) this.ddElement).Location = new Point(640, 61);
    ((Control) this.ddElement).Name = "ddElement";
    ((Control) this.ddElement).Size = new Size(101, 61);
    ((Control) this.ddElement).TabIndex = 223;
    ((Control) this.ddElement).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddElement).ValueMember = "ElementID";
    ((Control) this.ddElement).Visible = false;
    ((Control) this.ddCondition).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddCondition).DataMember = "Conditions";
    ((UltraGridBase) this.ddCondition).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddCondition).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn19.Header.VisiblePosition = 0;
    ultraGridColumn20.Header.VisiblePosition = 1;
    ultraGridColumn20.Hidden = true;
    ultraGridBand8.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ((UltraGridBase) this.ddCondition).DisplayLayout.BandsSerializer.Add((object) ultraGridBand8);
    ((UltraDropDownBase) this.ddCondition).DisplayMember = "Condition";
    ((UltraDropDownBase) this.ddCondition).DropDownWidth = 400;
    ((Control) this.ddCondition).Location = new Point(512 /*0x0200*/, 61);
    ((Control) this.ddCondition).Name = "ddCondition";
    ((Control) this.ddCondition).Size = new Size(101, 61);
    ((Control) this.ddCondition).TabIndex = 222;
    ((Control) this.ddCondition).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddCondition).ValueMember = "ID";
    ((Control) this.ddCondition).Visible = false;
    ((Control) this.ddStates).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddStates).DataMember = "lstStates";
    ((UltraGridBase) this.ddStates).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddStates).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn21.Header.VisiblePosition = 0;
    ultraGridColumn21.Hidden = true;
    ultraGridColumn22.Header.VisiblePosition = 1;
    ultraGridBand9.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn21,
      (object) ultraGridColumn22
    });
    ((UltraGridBase) this.ddStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand9);
    ((UltraDropDownBase) this.ddStates).DisplayMember = "State";
    ((UltraDropDownBase) this.ddStates).DropDownWidth = 400;
    ((Control) this.ddStates).Location = new Point(388, 61);
    ((Control) this.ddStates).Name = "ddStates";
    ((Control) this.ddStates).Size = new Size(101, 61);
    ((Control) this.ddStates).TabIndex = 221;
    ((Control) this.ddStates).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddStates).ValueMember = "StateID";
    ((Control) this.ddStates).Visible = false;
    ((Control) this.ddRaterTypes).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddRaterTypes).DataMember = "lstRatingTypes";
    ((UltraGridBase) this.ddRaterTypes).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddRaterTypes).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn23.Header.VisiblePosition = 0;
    ultraGridColumn23.Hidden = true;
    ultraGridColumn24.Header.VisiblePosition = 1;
    ultraGridBand10.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn23,
      (object) ultraGridColumn24
    });
    ((UltraGridBase) this.ddRaterTypes).DisplayLayout.BandsSerializer.Add((object) ultraGridBand10);
    ((UltraDropDownBase) this.ddRaterTypes).DisplayMember = "RatingType";
    ((UltraDropDownBase) this.ddRaterTypes).DropDownWidth = 400;
    ((Control) this.ddRaterTypes).Location = new Point(284, 61);
    ((Control) this.ddRaterTypes).Name = "ddRaterTypes";
    ((Control) this.ddRaterTypes).Size = new Size(74, 61);
    ((Control) this.ddRaterTypes).TabIndex = 220;
    ((Control) this.ddRaterTypes).Text = "UltraDropDown2";
    ((UltraDropDownBase) this.ddRaterTypes).ValueMember = "RatingTypeID";
    ((Control) this.ddRaterTypes).Visible = false;
    ((Control) this.ddLines).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddLines).DataMember = "lstLines";
    ((UltraGridBase) this.ddLines).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddLines).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn25.Header.VisiblePosition = 0;
    ultraGridColumn25.Hidden = true;
    ultraGridColumn26.Header.VisiblePosition = 1;
    ultraGridBand11.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn25,
      (object) ultraGridColumn26
    });
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand11);
    ((UltraDropDownBase) this.ddLines).DisplayMember = "LineName";
    ((UltraDropDownBase) this.ddLines).DropDownWidth = 400;
    ((Control) this.ddLines).Location = new Point(206, 61);
    ((Control) this.ddLines).Name = "ddLines";
    ((Control) this.ddLines).Size = new Size(59, 61);
    ((Control) this.ddLines).TabIndex = 219;
    ((Control) this.ddLines).Text = "UltraDropDown1";
    ((UltraDropDownBase) this.ddLines).ValueMember = "LineGUID";
    ((Control) this.ddLines).Visible = false;
    ((Control) this.ddCompanyLocation).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ddCompanyLocation).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.ddCompanyLocation).DataSource = (object) this.ds;
    ((UltraGridBase) this.ddCompanyLocation).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn27.Header.VisiblePosition = 0;
    ultraGridColumn27.Hidden = true;
    ultraGridColumn28.Header.VisiblePosition = 1;
    ultraGridBand12.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn27,
      (object) ultraGridColumn28
    });
    ((UltraGridBase) this.ddCompanyLocation).DisplayLayout.BandsSerializer.Add((object) ultraGridBand12);
    ((UltraDropDownBase) this.ddCompanyLocation).DisplayMember = "LocationName";
    ((UltraDropDownBase) this.ddCompanyLocation).DropDownWidth = 400;
    ((Control) this.ddCompanyLocation).Location = new Point(83, 52);
    ((Control) this.ddCompanyLocation).Name = "ddCompanyLocation";
    ((Control) this.ddCompanyLocation).Size = new Size(85, 61);
    ((Control) this.ddCompanyLocation).TabIndex = 218;
    ((Control) this.ddCompanyLocation).Text = "ddCompanyLocation";
    ((UltraDropDownBase) this.ddCompanyLocation).ValueMember = "CompanyLocationGUID";
    ((Control) this.ddCompanyLocation).Visible = false;
    ((Control) this.dgPolicyLimitRestriction).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DataMember = "tblCompanyLineRaterConditionals";
    ((UltraGridBase) this.dgPolicyLimitRestriction).DataSource = (object) this.ds;
    appearance30.BackColor = Color.White;
    appearance30.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Appearance = (AppearanceBase) appearance30;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand13.AddButtonCaption = "Add Program Code";
    ultraGridColumn29.Header.VisiblePosition = 0;
    ultraGridColumn29.Hidden = true;
    ultraGridColumn29.Style = (ColumnStyle) 6;
    ultraGridColumn29.Width = 75;
    ultraGridColumn30.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn30.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn30.Header).Caption = "Company";
    ultraGridColumn30.Header.VisiblePosition = 1;
    ultraGridColumn30.Style = (ColumnStyle) 6;
    ultraGridColumn30.Width = 155;
    ultraGridColumn31.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn31.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn31.Header).Caption = "Line";
    ultraGridColumn31.Header.VisiblePosition = 2;
    ultraGridColumn31.Style = (ColumnStyle) 6;
    ultraGridColumn31.Width = 122;
    ultraGridColumn32.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn32.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn32.Header).Caption = "State";
    ultraGridColumn32.Header.VisiblePosition = 3;
    ultraGridColumn32.Style = (ColumnStyle) 6;
    ultraGridColumn32.Width = 87;
    ultraGridColumn33.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn33.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn33.Header).Caption = "Rater";
    ultraGridColumn33.Header.VisiblePosition = 4;
    ultraGridColumn33.Style = (ColumnStyle) 6;
    ultraGridColumn33.Width = 119;
    ultraGridColumn34.AutoCompleteMode = (AutoCompleteMode) 1;
    ultraGridColumn34.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn34.Header).Caption = " Element";
    ultraGridColumn34.Header.VisiblePosition = 6;
    ultraGridColumn34.Style = (ColumnStyle) 6;
    ultraGridColumn34.Width = 89;
    ultraGridColumn35.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn35.Header).Caption = "Conditional";
    ultraGridColumn35.Header.VisiblePosition = 5;
    ultraGridColumn35.Style = (ColumnStyle) 6;
    ultraGridColumn35.Width = 73;
    ultraGridColumn36.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn36.Header).Caption = "Value";
    ultraGridColumn36.Header.VisiblePosition = 7;
    ultraGridColumn36.Width = 64 /*0x40*/;
    ultraGridColumn37.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn37.Header).Caption = "Value (#)";
    ultraGridColumn37.Header.VisiblePosition = 8;
    ultraGridColumn37.Width = 68;
    ultraGridBand13.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn29,
      (object) ultraGridColumn30,
      (object) ultraGridColumn31,
      (object) ultraGridColumn32,
      (object) ultraGridColumn33,
      (object) ultraGridColumn34,
      (object) ultraGridColumn35,
      (object) ultraGridColumn36,
      (object) ultraGridColumn37
    });
    ultraGridBand13.Override.AllowAddNew = (AllowAddNew) 1;
    ultraGridBand13.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand13.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.BandsSerializer.Add((object) ultraGridBand13);
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance31.BackColor = Color.LightSteelBlue;
    appearance31.FontData.SizeInPoints = 10f;
    appearance31.ForeColor = Color.Black;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance31;
    ((SpecialBoxBase) ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.GroupByBox).Hidden = true;
    appearance32.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance32.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance32.ForeColor = Color.Black;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance33.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance33;
    appearance34.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance35.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance35;
    appearance36.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.RowSelectorHeaderStyle = (RowSelectorHeaderStyle) 1;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance37.BackColor = Color.Transparent;
    appearance37.ForeColor = Color.Black;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.dgPolicyLimitRestriction).DisplayLayout.Override.SelectTypeRow = (SelectType) 1;
    ((Control) this.dgPolicyLimitRestriction).Font = new Font("Tahoma", 8.25f);
    ((Control) this.dgPolicyLimitRestriction).Location = new Point(12, 12);
    ((Control) this.dgPolicyLimitRestriction).Name = "dgPolicyLimitRestriction";
    ((Control) this.dgPolicyLimitRestriction).Size = new Size(798, 188);
    ((Control) this.dgPolicyLimitRestriction).TabIndex = 30;
    ((Control) this.dgPolicyLimitRestriction).Text = "Available Company/Line Rater Conditionals";
    ((UltraControlBase) this.dgPolicyLimitRestriction).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgPolicyLimitRestriction).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(822, 414);
    this.Controls.Add((Control) this.ddElement);
    this.Controls.Add((Control) this.ddCondition);
    this.Controls.Add((Control) this.ddStates);
    this.Controls.Add((Control) this.ddRaterTypes);
    this.Controls.Add((Control) this.ddLines);
    this.Controls.Add((Control) this.ddCompanyLocation);
    this.Controls.Add((Control) this.panelControls);
    this.Controls.Add((Control) this.dgPolicyLimitRestriction);
    this.Name = nameof (FormRaterConditionalsAdmin);
    this.Text = "Configure Rater Conditionals";
    ((ISupportInitialize) this.panelControls).EndInit();
    ((Control) this.panelControls).ResumeLayout(false);
    ((Control) this.panelControls).PerformLayout();
    ((ISupportInitialize) this.cboElement).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.txtValueNumeric).EndInit();
    ((ISupportInitialize) this.txtValueString).EndInit();
    ((ISupportInitialize) this.cboConditions).EndInit();
    ((ISupportInitialize) this.cboRater).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    ((ISupportInitialize) this.cboLines).EndInit();
    ((ISupportInitialize) this.cboCompanyLocation).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddElement).EndInit();
    ((ISupportInitialize) this.ddCondition).EndInit();
    ((ISupportInitialize) this.ddStates).EndInit();
    ((ISupportInitialize) this.ddRaterTypes).EndInit();
    ((ISupportInitialize) this.ddLines).EndInit();
    ((ISupportInitialize) this.ddCompanyLocation).EndInit();
    ((ISupportInitialize) this.dgPolicyLimitRestriction).EndInit();
    this.ResumeLayout(false);
  }

  private virtual UltraGrid dgPolicyLimitRestriction
  {
    get => this._dgPolicyLimitRestriction;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dgPolicyLimitRestriction_AfterRowActivate);
      UltraGrid limitRestriction1 = this._dgPolicyLimitRestriction;
      if (limitRestriction1 != null)
        limitRestriction1.AfterRowActivate -= eventHandler;
      this._dgPolicyLimitRestriction = value;
      UltraGrid limitRestriction2 = this._dgPolicyLimitRestriction;
      if (limitRestriction2 == null)
        return;
      limitRestriction2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("cnSQL")]
  private virtual SqlConnection cnSQL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("daLoadData")]
  private virtual SqlDataAdapter daLoadData { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlSelectCommand3")]
  private virtual SqlCommand SqlSelectCommand3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelControls")]
  private virtual MGAGroupBox panelControls { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboCompanyLocation")]
  private virtual MGAComboBox cboCompanyLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLines")]
  private virtual MGAComboBox cboLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboRater")]
  private virtual MGAComboBox cboRater { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  private virtual MGAComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboConditions")]
  private virtual MGAComboBox cboConditions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddCompanyLocation")]
  private virtual UltraDropDown ddCompanyLocation { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLines")]
  private virtual UltraDropDown ddLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddRaterTypes")]
  private virtual UltraDropDown ddRaterTypes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddStates")]
  private virtual UltraDropDown ddStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddCondition")]
  private virtual UltraDropDown ddCondition { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label7")]
  internal virtual Label Label7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtValueString")]
  private virtual MGATextBox txtValueString { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_ClickedDelete);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingCancel);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler5 = new CancelEventHandler(this.dbSave_ClickingSave);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickedDelete -= eventHandler2;
        dbSave1.ClickingCancel -= cancelEventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler2;
        dbSave1.ClickingEdit -= cancelEventHandler3;
        dbSave1.ClickingNew -= cancelEventHandler4;
        dbSave1.ClickingSave -= cancelEventHandler5;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickedDelete += eventHandler2;
      dbSave2.ClickingCancel += cancelEventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler2;
      dbSave2.ClickingEdit += cancelEventHandler3;
      dbSave2.ClickingNew += cancelEventHandler4;
      dbSave2.ClickingSave += cancelEventHandler5;
    }
  }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtValueNumeric")]
  private virtual MGANumericEditor txtValueNumeric { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("da")]
  private virtual SqlDataAdapter da { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlDeleteCommand4")]
  private virtual SqlCommand SqlDeleteCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlInsertCommand4")]
  private virtual SqlCommand SqlInsertCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlCommand1")]
  private virtual SqlCommand SqlCommand1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("SqlUpdateCommand4")]
  private virtual SqlCommand SqlUpdateCommand4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label8")]
  internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAComboBox cboElement
  {
    get => this._cboElement;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.cboElement_BeforeDropDown);
      MGAComboBox cboElement1 = this._cboElement;
      if (cboElement1 != null)
        cboElement1.BeforeDropDown -= cancelEventHandler;
      this._cboElement = value;
      MGAComboBox cboElement2 = this._cboElement;
      if (cboElement2 == null)
        return;
      cboElement2.BeforeDropDown += cancelEventHandler;
    }
  }

  [field: AccessedThroughProperty("ddElement")]
  private virtual UltraDropDown ddElement { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsRaterConditionals ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblCompanyLineRaterConditionals.TableName];
  }

  private void FormPolicyLimitRestriction_Load(object sender, EventArgs e)
  {
    this.cnSQL.ConnectionString = CurrentUser.Instance.ConnectionString;
    Dictionary<string, string> dictionary = new Dictionary<string, string>();
    dictionary.Add("LT", "Less Than");
    dictionary.Add("GT", "Greater Than");
    dictionary.Add("EQ", "Equal To");
    try
    {
      foreach (KeyValuePair<string, string> keyValuePair in dictionary)
        this.FillDataSetTempTable(keyValuePair.Key, keyValuePair.Value);
    }
    finally
    {
      Dictionary<string, string>.Enumerator enumerator;
      enumerator.Dispose();
    }
    dsRaterConditionals.lstStatesRow row1 = this.ds.lstStates.NewlstStatesRow();
    row1.State = string.Empty;
    row1.StateID = string.Empty;
    this.ds.lstStates.AddlstStatesRow(row1);
    dsRaterConditionals.lstLinesRow row2 = this.ds.lstLines.NewlstLinesRow();
    row2.LineName = string.Empty;
    this.ds.lstLines.AddlstLinesRow(row2);
    dsRaterConditionals.tblCompanyLocationsRow row3 = this.ds.tblCompanyLocations.NewtblCompanyLocationsRow();
    row3.LocationName = string.Empty;
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(row3);
    SqlDataAdapter daLoadData = this.daLoadData;
    daLoadData.TableMappings.Clear();
    daLoadData.TableMappings.Add("Table", this.ds.lstRatingTypes.TableName);
    daLoadData.TableMappings.Add("Table1", this.ds.lstStates.TableName);
    daLoadData.TableMappings.Add("Table2", this.ds.tblCompanyLocations.TableName);
    daLoadData.TableMappings.Add("Table3", this.ds.tblRaterConditionalElements.TableName);
    daLoadData.TableMappings.Add("Table4", this.ds.tblCompanyLineRaterConditionals.TableName);
    daLoadData.TableMappings.Add("Table5", this.ds.lstLines.TableName);
    MGASystems.Common.DataAccess.Database.SafeDataAdapterFill(this.daLoadData, (DataSet) this.ds);
    this.SetupDBSave();
    this.SetupGroupBox(false);
  }

  private void FillDataSetTempTable(string ID, string cond)
  {
    dsRaterConditionals.ConditionsRow row = this.ds.Conditions.NewConditionsRow();
    row.ID = ID;
    row.Condition = cond;
    this.ds.Conditions.AddConditionsRow(row);
  }

  private bool ValidForm()
  {
    bool flag = true;
    if (string.IsNullOrEmpty(this.cboRater.Text))
    {
      this.err.SetError((Control) this.cboRater, "Please select a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboRater, string.Empty);
    if (string.IsNullOrEmpty(this.cboConditions.Text))
    {
      this.err.SetError((Control) this.cboConditions, "Please select a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboConditions, string.Empty);
    if (string.IsNullOrEmpty(this.cboElement.Text))
    {
      this.err.SetError((Control) this.cboElement, "Please select a value");
      flag = false;
    }
    else
      this.err.SetError((Control) this.cboElement, string.Empty);
    if (flag && !string.IsNullOrEmpty(this.cboElement.Text))
    {
      dsRaterConditionals.tblRaterConditionalElementsRow byElementId = this.ds.tblRaterConditionalElements.FindByElementID(Conversions.ToInteger(this.cboElement.Value));
      if (byElementId != null)
      {
        if (byElementId.IsNumericValue)
        {
          if (this.txtValueNumeric.Value == DBNull.Value)
          {
            this.err.SetError((Control) this.txtValueNumeric, "Numeric Value Expected");
            flag = false;
          }
          else
            this.err.SetError((Control) this.txtValueNumeric, string.Empty);
          if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtValueString).Text))
          {
            this.err.SetError((Control) this.txtValueString, "Element is numeric");
            flag = false;
          }
          else
            this.err.SetError((Control) this.txtValueString, string.Empty);
        }
        else
        {
          if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtValueString).Text))
          {
            this.err.SetError((Control) this.txtValueString, "Please add data");
            flag = false;
          }
          else
            this.err.SetError((Control) this.txtValueString, string.Empty);
          if (this.txtValueNumeric.Value != DBNull.Value && this.txtValueNumeric.Value != DBNull.Value)
          {
            this.err.SetError((Control) this.txtValueNumeric, "Value is non-numeric");
            flag = false;
          }
          else
            this.err.SetError((Control) this.txtValueNumeric, string.Empty);
        }
      }
    }
    return flag;
  }

  private void SetupDBSave()
  {
    if (this.ds.tblCompanyLineRaterConditionals.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void EnableGrid(bool value) => ((Control) this.dgPolicyLimitRestriction).Enabled = value;

  private void SetupGroupBox(bool value)
  {
    try
    {
      foreach (Control control in ((Control) this.panelControls).Controls)
      {
        if (control != this.dbSave)
          control.Enabled = value;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e) => this.SetupDBSave();

  private void dbSave_ClickedDelete(object sender, EventArgs e) => this.SetupDBSave();

  private void dbSave_ClickingCancel(object sender, CancelEventArgs e)
  {
    this.bmb.EndCurrentEdit();
    this.ds.tblCompanyLineRaterConditionals.RejectChanges();
    this.SetupGroupBox(false);
    this.EnableGrid(true);
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
    {
      e.Cancel = true;
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to delete this conditional?", "Delete Conditional?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
      {
        this.Cursor = MgaCursors.WaitCursor;
        try
        {
          this.Refresh();
          this.ds.tblCompanyLineRaterConditionals[this.bmb.Position].Delete();
          MGASystems.Common.DataAccess.Database.SafeDataAdapterUpdate(this.da, (DataTable) this.ds.tblCompanyLineRaterConditionals);
        }
        finally
        {
          this.Cursor = MgaCursors.Default;
        }
      }
      this.SetupGroupBox(false);
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    this.SetupGroupBox(true);
    this.EnableGrid(false);
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    this.EnableGrid(false);
    this.SetupGroupBox(true);
    this.ds.tblCompanyLineRaterConditionals.AddtblCompanyLineRaterConditionalsRow(this.ds.tblCompanyLineRaterConditionals.NewtblCompanyLineRaterConditionalsRow());
    this.bmb.Position = this.ds.tblCompanyLineRaterConditionals.Rows.Count - 1;
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
      e.Cancel = true;
    else if (!this.ValidForm())
    {
      e.Cancel = true;
    }
    else
    {
      this.bmb.EndCurrentEdit();
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        MGASystems.Common.DataAccess.Database.SafeDataAdapterUpdate(this.da, (DataTable) this.ds.tblCompanyLineRaterConditionals);
        this.SetupGroupBox(false);
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      this.EnableGrid(true);
    }
  }

  private void dgPolicyLimitRestriction_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dgPolicyLimitRestriction).ActiveRow == null)
      return;
    MGASystems.Common.Functions.Database.MoveTo(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.dgPolicyLimitRestriction).ActiveRow.Cells["ConditionalID"].Value), "ConditionalID", (DataTable) this.ds.tblCompanyLineRaterConditionals, this.bmb);
    if (this.dbSave.UIState == UIState.Editing)
      return;
    this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void cboElement_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (string.IsNullOrEmpty(this.cboRater.Text))
      return;
    foreach (UltraGridRow row in ((UltraGridBase) this.cboElement).Rows)
      row.Hidden = Conversions.ToInteger(row.Cells["RaterID"].Value) != Conversions.ToInteger(this.cboRater.Value);
  }
}
