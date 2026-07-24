// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.FormUserGoals
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.Functions;
using MGASystems.Data;
using MGASystems.Tools;
using MGASystems.Tools.DBSaveUI;
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
namespace MGASystems.IMS.Forms;

[DesignerGenerated]
public class FormUserGoals : Form
{
  private IContainer components;
  private readonly Guid _userGuid;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("lstPolicyTypes", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("PolicyTypeID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("Description");
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstLines", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("LineGUID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("LineName");
    UltraGridBand ultraGridBand3 = new UltraGridBand("dtMonth", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Month");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("MonthName");
    UltraGridBand ultraGridBand4 = new UltraGridBand("dtYear", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Year");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("YearName");
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblUserGoals", -1);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("ID");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("PremiumGoal");
    Appearance appearance4 = new Appearance();
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("UserGuid");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("GoalMonth", -1, (object) "ddMonth");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("GoalYear", -1, (object) "ddYear");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("PolicyTypeID", -1, (object) "ddPolicyType");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("LineGUID", -1, (object) "ddLines");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Revenue");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.panelProdGoals = new Panel();
    this.numRevenue = new MGANumericEditor();
    this.ds = new dsUserGoals();
    this.Label6 = new Label();
    this.Label5 = new Label();
    this.numPremiumGoal = new MGANumericEditor();
    this.Label2 = new Label();
    this.Label4 = new Label();
    this.cboMonth = new MGASimpleComboBox();
    this.Label1 = new Label();
    this.cboPolicyType = new MGASimpleComboBox();
    this.Label3 = new Label();
    this.cboYear = new MGASimpleComboBox();
    this.cboLOB = new MGASimpleComboBox();
    this.dbSave = new MGASystems.Tools.DBSaveUI.DBSaveUI();
    this.err = new ErrorProvider(this.components);
    this.ddPolicyType = new UltraDropDown();
    this.ddLines = new UltraDropDown();
    this.ddMonth = new UltraDropDown();
    this.ddYear = new UltraDropDown();
    this.dg = new UltraGrid();
    this.panelProdGoals.SuspendLayout();
    ((ISupportInitialize) this.numRevenue).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.numPremiumGoal).BeginInit();
    ((ISupportInitialize) this.cboMonth).BeginInit();
    ((ISupportInitialize) this.cboPolicyType).BeginInit();
    ((ISupportInitialize) this.cboYear).BeginInit();
    ((ISupportInitialize) this.cboLOB).BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.ddPolicyType).BeginInit();
    ((ISupportInitialize) this.ddLines).BeginInit();
    ((ISupportInitialize) this.ddMonth).BeginInit();
    ((ISupportInitialize) this.ddYear).BeginInit();
    ((ISupportInitialize) this.dg).BeginInit();
    this.SuspendLayout();
    this.panelProdGoals.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.panelProdGoals.BackColor = Color.Transparent;
    this.panelProdGoals.BorderStyle = BorderStyle.Fixed3D;
    this.panelProdGoals.Controls.Add((Control) this.numRevenue);
    this.panelProdGoals.Controls.Add((Control) this.Label6);
    this.panelProdGoals.Controls.Add((Control) this.Label5);
    this.panelProdGoals.Controls.Add((Control) this.numPremiumGoal);
    this.panelProdGoals.Controls.Add((Control) this.Label2);
    this.panelProdGoals.Controls.Add((Control) this.Label4);
    this.panelProdGoals.Controls.Add((Control) this.cboMonth);
    this.panelProdGoals.Controls.Add((Control) this.Label1);
    this.panelProdGoals.Controls.Add((Control) this.cboPolicyType);
    this.panelProdGoals.Controls.Add((Control) this.Label3);
    this.panelProdGoals.Controls.Add((Control) this.cboYear);
    this.panelProdGoals.Controls.Add((Control) this.cboLOB);
    this.panelProdGoals.Location = new Point(14, 262);
    this.panelProdGoals.Name = "panelProdGoals";
    this.panelProdGoals.Size = new Size(592, 101);
    this.panelProdGoals.TabIndex = 212;
    appearance1.BackColorDisabled = Color.Gainsboro;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numRevenue).Appearance = (AppearanceBase) appearance1;
    ((Control) this.numRevenue).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUserGoals.Revenue", true));
    ((UltraNumericEditorBase) this.numRevenue).FormatString = "c";
    ((Control) this.numRevenue).Location = new Point(368, 13);
    this.numRevenue.MaskInput = "nnnnnnnnnnnnnnn.nn";
    this.numRevenue.MaxValue = (object) 1E+15;
    this.numRevenue.MGAStyle = MGAStyles.Blue;
    ((Control) this.numRevenue).Name = "numRevenue";
    this.numRevenue.Nullable = true;
    this.numRevenue.NumericType = (NumericType) 1;
    ((Control) this.numRevenue).Size = new Size(141, 19);
    ((Control) this.numRevenue).TabIndex = 3;
    ((UltraControlBase) this.numRevenue).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numRevenue).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsUserGoals";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label6.AutoSize = true;
    this.Label6.BackColor = Color.Transparent;
    this.Label6.Location = new Point(289, 16 /*0x10*/);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(54, 13);
    this.Label6.TabIndex = 29;
    this.Label6.Text = "Revenue:";
    this.Label5.AutoSize = true;
    this.Label5.BackColor = Color.Transparent;
    this.Label5.Location = new Point(289, 47);
    this.Label5.Name = "Label5";
    this.Label5.Size = new Size(31 /*0x1F*/, 13);
    this.Label5.TabIndex = 27;
    this.Label5.Text = "LOB:";
    appearance2.BackColorDisabled = Color.Gainsboro;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numPremiumGoal).Appearance = (AppearanceBase) appearance2;
    ((Control) this.numPremiumGoal).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUserGoals.PremiumGoal", true));
    ((UltraNumericEditorBase) this.numPremiumGoal).FormatString = "c";
    ((Control) this.numPremiumGoal).Location = new Point(85, 71);
    this.numPremiumGoal.MaskInput = "nnnnnnnnnnnnnnn.nn";
    this.numPremiumGoal.MaxValue = (object) 1E+15;
    this.numPremiumGoal.MGAStyle = MGAStyles.Blue;
    ((Control) this.numPremiumGoal).Name = "numPremiumGoal";
    this.numPremiumGoal.Nullable = true;
    this.numPremiumGoal.NumericType = (NumericType) 1;
    ((Control) this.numPremiumGoal).Size = new Size(141, 19);
    ((Control) this.numPremiumGoal).TabIndex = 2;
    ((UltraControlBase) this.numPremiumGoal).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numPremiumGoal).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(21, 74);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(50, 13);
    this.Label2.TabIndex = 15;
    this.Label2.Text = "Premium:";
    this.Label4.AutoSize = true;
    this.Label4.BackColor = Color.Transparent;
    this.Label4.Location = new Point(289, 77);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(65, 13);
    this.Label4.TabIndex = 25;
    this.Label4.Text = "Policy Type:";
    this.cboMonth.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboMonth).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUserGoals.GoalMonth", true));
    ((UltraGridBase) this.cboMonth).DataMember = "dtMonth";
    ((UltraGridBase) this.cboMonth).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboMonth).DisplayMember = "MonthName";
    this.cboMonth.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboMonth).Location = new Point(85, 9);
    this.cboMonth.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboMonth).Name = "cboMonth";
    ((Control) this.cboMonth).Size = new Size(141, 20);
    ((Control) this.cboMonth).TabIndex = 0;
    ((UltraControlBase) this.cboMonth).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboMonth).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboMonth).ValueMember = "Month";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(21, 13);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(40, 13);
    this.Label1.TabIndex = 14;
    this.Label1.Text = "Month:";
    this.cboPolicyType.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboPolicyType).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUserGoals.PolicyTypeID", true));
    ((UltraGridBase) this.cboPolicyType).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.cboPolicyType).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboPolicyType).DisplayMember = "Description";
    this.cboPolicyType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboPolicyType).Location = new Point(368, 73);
    this.cboPolicyType.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboPolicyType).Name = "cboPolicyType";
    ((Control) this.cboPolicyType).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.cboPolicyType).TabIndex = 5;
    ((UltraControlBase) this.cboPolicyType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboPolicyType).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboPolicyType).ValueMember = "PolicyTypeID";
    this.Label3.AutoSize = true;
    this.Label3.BackColor = Color.Transparent;
    this.Label3.Location = new Point(21, 44);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(32 /*0x20*/, 13);
    this.Label3.TabIndex = 21;
    this.Label3.Text = "Year:";
    this.cboYear.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboYear).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUserGoals.GoalYear", true));
    ((UltraGridBase) this.cboYear).DataMember = "dtYear";
    ((UltraGridBase) this.cboYear).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboYear).DisplayMember = "YearName";
    this.cboYear.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboYear).Location = new Point(85, 40);
    this.cboYear.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboYear).Name = "cboYear";
    ((Control) this.cboYear).Size = new Size(141, 20);
    ((Control) this.cboYear).TabIndex = 1;
    ((UltraControlBase) this.cboYear).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboYear).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboYear).ValueMember = "Year";
    this.cboLOB.BorderStyle = (UIElementBorderStyle) 4;
    ((Control) this.cboLOB).DataBindings.Add(new Binding("Value", (object) this.ds, "tblUserGoals.LineGUID", true));
    ((UltraGridBase) this.cboLOB).DataMember = "lstLines";
    ((UltraGridBase) this.cboLOB).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboLOB).DisplayMember = "LineName";
    this.cboLOB.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cboLOB).DropDownWidth = 450;
    ((Control) this.cboLOB).Location = new Point(368, 43);
    this.cboLOB.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboLOB).Name = "cboLOB";
    ((Control) this.cboLOB).Size = new Size(192 /*0xC0*/, 20);
    ((Control) this.cboLOB).TabIndex = 4;
    ((UltraControlBase) this.cboLOB).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboLOB).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboLOB).ValueMember = "LineGUID";
    this.dbSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.dbSave.AutoQueryRowCountOnLoad = false;
    this.dbSave.EditStyle = EditStyle.ShowEditButton;
    this.dbSave.FreezeEvents = false;
    this.dbSave.Location = new Point(660, 317);
    this.dbSave.Name = "dbSave";
    this.dbSave.Size = new Size(112 /*0x70*/, 40);
    this.dbSave.TabIndex = 0;
    this.err.ContainerControl = (ContainerControl) this;
    ((UltraGridBase) this.ddPolicyType).DataMember = "lstPolicyTypes";
    ((UltraGridBase) this.ddPolicyType).DataSource = (object) this.ds;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.ddPolicyType).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraDropDownBase) this.ddPolicyType).DisplayMember = "Description";
    ((Control) this.ddPolicyType).Location = new Point(170, 166);
    ((Control) this.ddPolicyType).Name = "ddPolicyType";
    ((Control) this.ddPolicyType).Size = new Size(140, 56);
    ((Control) this.ddPolicyType).TabIndex = 221;
    ((UltraDropDownBase) this.ddPolicyType).ValueMember = "PolicyTypeID";
    ((Control) this.ddPolicyType).Visible = false;
    ((UltraGridBase) this.ddLines).DataMember = "lstLines";
    ((UltraGridBase) this.ddLines).DataSource = (object) this.ds;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 200;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.ddLines).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraDropDownBase) this.ddLines).DisplayMember = "LineName";
    ((Control) this.ddLines).Location = new Point(375, 166);
    ((Control) this.ddLines).Name = "ddLines";
    ((Control) this.ddLines).Size = new Size(140, 56);
    ((Control) this.ddLines).TabIndex = 220;
    ((UltraDropDownBase) this.ddLines).ValueMember = "LineGUID";
    ((Control) this.ddLines).Visible = false;
    ((UltraGridBase) this.ddMonth).DataMember = "dtMonth";
    ((UltraGridBase) this.ddMonth).DataSource = (object) this.ds;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) this.ddMonth).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraDropDownBase) this.ddMonth).DisplayMember = "MonthName";
    ((Control) this.ddMonth).Location = new Point(375, 104);
    ((Control) this.ddMonth).Name = "ddMonth";
    ((Control) this.ddMonth).Size = new Size(140, 56);
    ((Control) this.ddMonth).TabIndex = 219;
    ((UltraDropDownBase) this.ddMonth).ValueMember = "Month";
    ((Control) this.ddMonth).Visible = false;
    ((UltraGridBase) this.ddYear).DataMember = "dtYear";
    ((UltraGridBase) this.ddYear).DataSource = (object) this.ds;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridBand4.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ddYear).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraDropDownBase) this.ddYear).DisplayMember = "YearName";
    ((Control) this.ddYear).Location = new Point(170, 104);
    ((Control) this.ddYear).Name = "ddYear";
    ((Control) this.ddYear).Size = new Size(140, 56);
    ((Control) this.ddYear).TabIndex = 218;
    ((UltraDropDownBase) this.ddYear).ValueMember = "Year";
    ((Control) this.ddYear).Visible = false;
    ((Control) this.dg).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dg).DataMember = "tblUserGoals";
    ((UltraGridBase) this.dg).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dg).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dg).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 52;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Right";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance4;
    ultraGridColumn10.Format = "c";
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Premium Goal";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 4;
    ultraGridColumn10.Width = 95;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn11.Width = 236;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Month";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 2;
    ultraGridColumn12.Style = (ColumnStyle) 6;
    ultraGridColumn12.Width = 118;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Year";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 3;
    ultraGridColumn13.Style = (ColumnStyle) 6;
    ultraGridColumn13.Width = 100;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Policy Type";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 6;
    ultraGridColumn14.Style = (ColumnStyle) 6;
    ultraGridColumn14.Width = 156;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 7;
    ultraGridColumn15.Style = (ColumnStyle) 6;
    ultraGridColumn15.Width = 181;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Right";
    ultraGridColumn16.CellAppearance = (AppearanceBase) appearance5;
    ultraGridColumn16.Format = "c";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 5;
    ultraGridColumn16.Width = 106;
    ultraGridBand5.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16
    });
    ((UltraGridBase) this.dg).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.dg).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = Color.LightSteelBlue;
    appearance6.FontData.SizeInPoints = 10f;
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.dg).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dg).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dg).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dg).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.dg).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.dg).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.dg).Location = new Point(14, 12);
    ((Control) this.dg).Name = "dg";
    ((Control) this.dg).Size = new Size(758, 244);
    ((Control) this.dg).TabIndex = 214;
    ((UltraControlBase) this.dg).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dg).UseOsThemes = (DefaultableBoolean) 2;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(784, 369);
    this.Controls.Add((Control) this.ddPolicyType);
    this.Controls.Add((Control) this.ddLines);
    this.Controls.Add((Control) this.ddMonth);
    this.Controls.Add((Control) this.ddYear);
    this.Controls.Add((Control) this.dg);
    this.Controls.Add((Control) this.dbSave);
    this.Controls.Add((Control) this.panelProdGoals);
    this.Name = nameof (FormUserGoals);
    this.Text = "User Goals";
    this.panelProdGoals.ResumeLayout(false);
    this.panelProdGoals.PerformLayout();
    ((ISupportInitialize) this.numRevenue).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.numPremiumGoal).EndInit();
    ((ISupportInitialize) this.cboMonth).EndInit();
    ((ISupportInitialize) this.cboPolicyType).EndInit();
    ((ISupportInitialize) this.cboYear).EndInit();
    ((ISupportInitialize) this.cboLOB).EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.ddPolicyType).EndInit();
    ((ISupportInitialize) this.ddLines).EndInit();
    ((ISupportInitialize) this.ddMonth).EndInit();
    ((ISupportInitialize) this.ddYear).EndInit();
    ((ISupportInitialize) this.dg).EndInit();
    this.ResumeLayout(false);
  }

  [field: AccessedThroughProperty("panelProdGoals")]
  private virtual Panel panelProdGoals { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numRevenue")]
  private virtual MGANumericEditor numRevenue { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label5")]
  internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboLOB")]
  protected virtual MGASimpleComboBox cboLOB { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboPolicyType")]
  protected virtual MGASimpleComboBox cboPolicyType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("numPremiumGoal")]
  private virtual MGANumericEditor numPremiumGoal { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboMonth")]
  protected virtual MGASimpleComboBox cboMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboYear")]
  protected virtual MGASimpleComboBox cboYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGASystems.Tools.DBSaveUI.DBSaveUI dbSave
  {
    get => this._dbSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler1 = new EventHandler(this.dbSave_ClickedCancel);
      CancelEventHandler cancelEventHandler1 = new CancelEventHandler(this.dbSave_ClickingDelete);
      CancelEventHandler cancelEventHandler2 = new CancelEventHandler(this.dbSave_ClickingEdit);
      CancelEventHandler cancelEventHandler3 = new CancelEventHandler(this.dbSave_ClickingNew);
      CancelEventHandler cancelEventHandler4 = new CancelEventHandler(this.dbSave_ClickingSave);
      EventHandler eventHandler2 = new EventHandler(this.dbSave_UIStateChanged);
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave1 = this._dbSave;
      if (dbSave1 != null)
      {
        dbSave1.ClickedCancel -= eventHandler1;
        dbSave1.ClickingDelete -= cancelEventHandler1;
        dbSave1.ClickingEdit -= cancelEventHandler2;
        dbSave1.ClickingNew -= cancelEventHandler3;
        dbSave1.ClickingSave -= cancelEventHandler4;
        dbSave1.UIStateChanged -= eventHandler2;
      }
      this._dbSave = value;
      MGASystems.Tools.DBSaveUI.DBSaveUI dbSave2 = this._dbSave;
      if (dbSave2 == null)
        return;
      dbSave2.ClickedCancel += eventHandler1;
      dbSave2.ClickingDelete += cancelEventHandler1;
      dbSave2.ClickingEdit += cancelEventHandler2;
      dbSave2.ClickingNew += cancelEventHandler3;
      dbSave2.ClickingSave += cancelEventHandler4;
      dbSave2.UIStateChanged += eventHandler2;
    }
  }

  private virtual UltraGrid dg
  {
    get => this._dg;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.dg_AfterRowActivate);
      UltraGrid dg1 = this._dg;
      if (dg1 != null)
        dg1.AfterRowActivate -= eventHandler;
      this._dg = value;
      UltraGrid dg2 = this._dg;
      if (dg2 == null)
        return;
      dg2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsUserGoals ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddYear")]
  private virtual UltraDropDown ddYear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddPolicyType")]
  private virtual UltraDropDown ddPolicyType { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddLines")]
  private virtual UltraDropDown ddLines { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ddMonth")]
  private virtual UltraDropDown ddMonth { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormUserGoals(Guid userGuid)
  {
    this.Load += new EventHandler(this.FormUserGoals_Load);
    this.InitializeComponent();
    this._userGuid = userGuid;
  }

  private BindingManagerBase bmb
  {
    get => this.BindingContext[(object) this.ds, this.ds.tblUserGoals.TableName];
  }

  private void FormUserGoals_Load(object sender, EventArgs e)
  {
    MGASystems.BusinessObjects.User user = new MGASystems.BusinessObjects.User(this._userGuid);
    ((Control) this.dg).Text = $"User Goals for [{user.LastName}, {user.FirstName}]";
    MGASystems.Tools.DBSaveUI.DBSaveUI dbSave = this.dbSave;
    dbSave.UIState = UIState.NoRecordsNotEditing;
    dbSave.EditStyle = EditStyle.ShowEditButton;
    this.FillDatasetTempTables();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblUserGoals"
    }, CommandType.Text, "SELECT ID, PremiumGoal, UserGuid, GoalMonth, GoalYear, PolicyTypeID, LineGUID, Revenue FROM dbo.tblUserGoals WHERE UserGuid = @UserGuid", new object[2]
    {
      (object) "@UserGuid",
      (object) this._userGuid
    });
    this.SetSaveState();
    this.panelProdGoals.Enabled = false;
    this.bmb.Position = this.ds.tblUserGoals.Count - 1;
    this.SetControlsEnabled(false);
  }

  private void SetSaveState()
  {
    if (this.ds.tblUserGoals.Count > 0)
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
  }

  private string GetMonth(Dictionary<byte, string> dict, byte monthID) => dict[monthID];

  private void FillDatasetTempTables()
  {
    Dictionary<byte, string> dict = new Dictionary<byte, string>();
    dict.Add((byte) 1, "January");
    dict.Add((byte) 2, "Febuary");
    dict.Add((byte) 3, "March");
    dict.Add((byte) 4, "April");
    dict.Add((byte) 5, "May");
    dict.Add((byte) 6, "June");
    dict.Add((byte) 7, "July");
    dict.Add((byte) 8, "August");
    dict.Add((byte) 9, "September");
    dict.Add((byte) 10, "October");
    dict.Add((byte) 11, "November");
    dict.Add((byte) 12, "December");
    dict.Add((byte) 13, "Annual");
    dict.Add((byte) 14, "Semi-Annual");
    dict.Add((byte) 15, "Quarterly");
    byte monthID = 1;
    do
    {
      dsUserGoals.dtMonthRow row = this.ds.dtMonth.NewdtMonthRow();
      row.Month = monthID;
      row.MonthName = this.GetMonth(dict, monthID);
      this.ds.dtMonth.AdddtMonthRow(row);
      ++monthID;
    }
    while (monthID <= (byte) 15);
    dsUserGoals.dtYearRow row1 = this.ds.dtYear.NewdtYearRow();
    row1.Year = 1901;
    row1.YearName = "Month";
    this.ds.dtYear.AdddtYearRow(row1);
    int num = 1980;
    do
    {
      dsUserGoals.dtYearRow row2 = this.ds.dtYear.NewdtYearRow();
      row2.Year = num;
      row2.YearName = num.ToString();
      this.ds.dtYear.AdddtYearRow(row2);
      ++num;
    }
    while (num <= 1984);
    num = 2007;
    do
    {
      dsUserGoals.dtYearRow row3 = this.ds.dtYear.NewdtYearRow();
      row3.Year = num;
      row3.YearName = num.ToString();
      this.ds.dtYear.AdddtYearRow(row3);
      ++num;
    }
    while (num <= 2025);
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstPolicyTypes"
    }, CommandType.Text, "SELECT PolicyTypeID,Description FROM lstPolicyTypes WITH (NOLOCK) ORDER BY Description");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstLines"
    }, CommandType.Text, "SELECT LineGUID,LineName FROM lstLines WITH (NOLOCK) ORDER BY LineName");
  }

  private bool ValidateForm()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboMonth, string.Empty);
    this.err.SetError((Control) this.cboYear, string.Empty);
    this.err.SetError((Control) this.numPremiumGoal, string.Empty);
    if (string.IsNullOrEmpty(this.cboMonth.Text))
    {
      this.err.SetError((Control) this.cboMonth, "Please select a value");
      flag = false;
    }
    if (string.IsNullOrEmpty(this.cboYear.Text))
    {
      this.err.SetError((Control) this.cboYear, "Please select a value");
      flag = false;
    }
    if (this.numPremiumGoal.Value == null || this.numPremiumGoal.Value == DBNull.Value)
    {
      this.err.SetError((Control) this.numPremiumGoal, "Please enter a value");
      flag = false;
    }
    return flag;
  }

  private void dg_AfterRowActivate(object sender, EventArgs e)
  {
    if (((UltraGridBase) this.dg).ActiveRow == null)
      return;
    Database.MoveTo((object) (int) ((UltraGridBase) this.dg).ActiveRow.Cells["ID"].Value, this.ds.tblUserGoals.IDColumn.ColumnName, (DataTable) this.ds.tblUserGoals, this.bmb);
  }

  private void dbSave_ClickedCancel(object sender, EventArgs e)
  {
    this.ds.tblUserGoals.RejectChanges();
    this.SetSaveState();
    this.SetControlsEnabled(false);
  }

  private void dbSave_ClickingDelete(object sender, CancelEventArgs e)
  {
    if (this.bmb.Position == -1)
    {
      int num = (int) MessageBox.Show("Please select a valid row in the grid", "Select valid Row", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      e.Cancel = true;
    }
    else if (MessageBox.Show("Are you sure you want to delete this user goal?", "Delete Production Goal?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
    {
      e.Cancel = true;
    }
    else
    {
      this.ds.tblUserGoals[this.bmb.Position].Delete();
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        this.UpdateUserGoals();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      this.SetControlsEnabled(false);
    }
  }

  private void dbSave_ClickingEdit(object sender, CancelEventArgs e)
  {
    this.SetControlsEnabled(true);
  }

  private void dbSave_ClickingNew(object sender, CancelEventArgs e)
  {
    dsUserGoals.tblUserGoalsRow row = this.ds.tblUserGoals.NewtblUserGoalsRow();
    row.UserGuid = this._userGuid;
    row.PremiumGoal = 0M;
    this.ds.tblUserGoals.AddtblUserGoalsRow(row);
    this.bmb.Position = this.ds.tblUserGoals.Count - 1;
    this.SetControlsEnabled(true);
  }

  private void dbSave_ClickingSave(object sender, CancelEventArgs e)
  {
    if (!this.ValidateForm())
    {
      e.Cancel = true;
    }
    else
    {
      this.bmb.EndCurrentEdit();
      this.Cursor = MgaCursors.WaitCursor;
      try
      {
        this.UpdateUserGoals();
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
      this.SetControlsEnabled(false);
    }
  }

  private void dbSave_UIStateChanged(object sender, EventArgs e)
  {
    bool enabled = this.dbSave.UIState == UIState.Editing;
    ((Control) this.dg).Enabled = !enabled;
    this.SetControlsEnabled(enabled);
    if (enabled)
      return;
    if (this.ds.tblUserGoals.Count == 0)
      this.dbSave.UIState = UIState.NoRecordsNotEditing;
    else
      this.dbSave.UIState = UIState.HasRecordsNotEditing;
  }

  private void EmptyControls()
  {
    try
    {
      foreach (Control control in this.panelProdGoals.Controls)
      {
        if (control is MGASimpleComboBox)
          ((UltraCombo) control).Value = (object) null;
        if (control is MGANumericEditor mgaNumericEditor)
          mgaNumericEditor.Value = (object) null;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void SetControlsEnabled(bool enabled) => this.panelProdGoals.Enabled = enabled;

  private void UpdateUserGoals()
  {
    using (DbDataAdapter dbDataAdapter = DefaultDatabase.BuildDataAdapter((DataTable) this.ds.tblUserGoals, "dbo.InsertUserGoals", "dbo.UpdateUserGoals", "dbo.DeleteUserGoals", true, 30, (DbTransaction) null))
      DefaultDatabase.DataAdapterUpdate(dbDataAdapter, (DataTable) this.ds.tblUserGoals);
  }
}
