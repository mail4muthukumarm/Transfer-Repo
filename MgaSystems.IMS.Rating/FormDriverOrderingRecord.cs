// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormDriverOrderingRecord
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Security;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormDriverOrderingRecord : Form
{
  private IContainer components;
  private bool _continue;
  private readonly dsDriverInfo _dataset;
  private bool _usingLxSetting;
  private bool _defaultLxSetting;
  private const string _unAvailableString = "<Unavailable>";
  private const string _noneString = "<None>";
  private const string _fullString = "Full";
  private const string _cleanString = "Clean";
  private const string _activityString = "Activity";
  private const string _vDetailString = "Vdetail";
  private readonly bool _canViewLicense;
  private readonly bool _canViewDOB;
  private bool _isFinishedLoading;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("dtOptions", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("HintMvrInsuranceOption");
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("dtProducts", -1);
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProductID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ID");
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("dtOrdering", -1);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("DriverID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("FirstName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("MiddleName");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("LastName", -1, (object) null, 0, (SortIndicator) 1, false);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("DOB");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Suffix");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("Misc");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ProductID", -1, (object) "ddProduct");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("SubType");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Purpose");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("VaultAge");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("HintMvrInsuranceOption", -1, (object) "ddProduct");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("LicenseValidationLookup");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.btnContinue = new Button();
    this.err = new ErrorProvider(this.components);
    this.rbLX = new RadioButton();
    this.rbDL = new RadioButton();
    this.grpProduct = new GroupBox();
    this.grpOption = new GroupBox();
    this.rbVdetail = new RadioButton();
    this.rbActivity = new RadioButton();
    this.rbFull = new RadioButton();
    this.rbClean = new RadioButton();
    this.lnkAdminStateProduct = new LinkLabel();
    this.lnkSetOption = new LinkLabel();
    this.ddOptions = new UltraDropDown();
    this.ds = new dsDriverInfo();
    this.ddProduct = new UltraDropDown();
    this.ugDriversOrder = new UltraGrid();
    this.lnkAdminLicenseLookup = new LinkLabel();
    this.lnkSelectAllLookup = new LinkLabel();
    this.lnkDeSelectLookup = new LinkLabel();
    this.UltraTextEditor1 = new UltraTextEditor();
    this.lnkApplyAddDL = new LinkLabel();
    ((ISupportInitialize) this.err).BeginInit();
    this.grpProduct.SuspendLayout();
    this.grpOption.SuspendLayout();
    ((ISupportInitialize) this.ddOptions).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.ddProduct).BeginInit();
    ((ISupportInitialize) this.ugDriversOrder).BeginInit();
    ((ISupportInitialize) this.UltraTextEditor1).BeginInit();
    this.SuspendLayout();
    this.btnContinue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.btnContinue.Location = new Point(1164, 607);
    this.btnContinue.Name = "btnContinue";
    this.btnContinue.Size = new Size(75, 23);
    this.btnContinue.TabIndex = 12;
    this.btnContinue.Text = "Continue -->";
    this.btnContinue.UseVisualStyleBackColor = true;
    this.err.ContainerControl = (ContainerControl) this;
    this.rbLX.AutoSize = true;
    this.rbLX.Location = new Point(92, 19);
    this.rbLX.Name = "rbLX";
    this.rbLX.Size = new Size(38, 17);
    this.rbLX.TabIndex = 82;
    this.rbLX.Text = "LX";
    this.rbLX.UseVisualStyleBackColor = true;
    this.rbDL.AutoSize = true;
    this.rbDL.Checked = true;
    this.rbDL.Location = new Point(22, 19);
    this.rbDL.Name = "rbDL";
    this.rbDL.Size = new Size(39, 17);
    this.rbDL.TabIndex = 83;
    this.rbDL.TabStop = true;
    this.rbDL.Text = "DL";
    this.rbDL.UseVisualStyleBackColor = true;
    this.grpProduct.Controls.Add((Control) this.rbDL);
    this.grpProduct.Controls.Add((Control) this.rbLX);
    this.grpProduct.Location = new Point(12, 16 /*0x10*/);
    this.grpProduct.Name = "grpProduct";
    this.grpProduct.Size = new Size(164, 42);
    this.grpProduct.TabIndex = 84;
    this.grpProduct.TabStop = false;
    this.grpProduct.Text = "Product ID";
    this.grpOption.Controls.Add((Control) this.rbVdetail);
    this.grpOption.Controls.Add((Control) this.rbActivity);
    this.grpOption.Controls.Add((Control) this.rbFull);
    this.grpOption.Controls.Add((Control) this.rbClean);
    this.grpOption.Location = new Point(192 /*0xC0*/, 16 /*0x10*/);
    this.grpOption.Name = "grpOption";
    this.grpOption.Size = new Size(375, 42);
    this.grpOption.TabIndex = 85;
    this.grpOption.TabStop = false;
    this.grpOption.Text = "Hint Mvr Insurance Option";
    this.rbVdetail.AutoSize = true;
    this.rbVdetail.Location = new Point(287, 19);
    this.rbVdetail.Name = "rbVdetail";
    this.rbVdetail.Size = new Size(57, 17);
    this.rbVdetail.TabIndex = 85;
    this.rbVdetail.Text = "Vdetail";
    this.rbVdetail.UseVisualStyleBackColor = true;
    this.rbActivity.AutoSize = true;
    this.rbActivity.Location = new Point(203, 19);
    this.rbActivity.Name = "rbActivity";
    this.rbActivity.Size = new Size(59, 17);
    this.rbActivity.TabIndex = 84;
    this.rbActivity.Text = "Activity";
    this.rbActivity.UseVisualStyleBackColor = true;
    this.rbFull.AutoSize = true;
    this.rbFull.Location = new Point(22, 19);
    this.rbFull.Name = "rbFull";
    this.rbFull.Size = new Size(41, 17);
    this.rbFull.TabIndex = 83;
    this.rbFull.Text = "Full";
    this.rbFull.UseVisualStyleBackColor = true;
    this.rbClean.AutoSize = true;
    this.rbClean.Location = new Point(109, 19);
    this.rbClean.Name = "rbClean";
    this.rbClean.Size = new Size(52, 17);
    this.rbClean.TabIndex = 82;
    this.rbClean.Text = "Clean";
    this.rbClean.UseVisualStyleBackColor = true;
    this.lnkAdminStateProduct.AutoSize = true;
    this.lnkAdminStateProduct.Location = new Point(832, 54);
    this.lnkAdminStateProduct.Name = "lnkAdminStateProduct";
    this.lnkAdminStateProduct.Size = new Size(120, 13);
    this.lnkAdminStateProduct.TabIndex = 86;
    this.lnkAdminStateProduct.TabStop = true;
    this.lnkAdminStateProduct.Text = "Admin LX State Product";
    this.lnkSetOption.AutoSize = true;
    this.lnkSetOption.Location = new Point(583, 54);
    this.lnkSetOption.Name = "lnkSetOption";
    this.lnkSetOption.Size = new Size(226, 13);
    this.lnkSetOption.TabIndex = 205;
    this.lnkSetOption.TabStop = true;
    this.lnkSetOption.Text = "Apply Selected Option To All LX State Product";
    ((UltraGridBase) this.ddOptions).DataMember = "dtOptions";
    ((UltraGridBase) this.ddOptions).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddOptions).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ultraGridBand1.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridBand1.Columns.AddRange(new object[1]
    {
      (object) ultraGridColumn1
    });
    ((UltraGridBase) this.ddOptions).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddOptions).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddOptions).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddOptions).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddOptions).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddOptions).DisplayMember = "MvrInsuranceOption";
    ((UltraDropDownBase) this.ddOptions).DropDownWidth = 300;
    ((Control) this.ddOptions).Location = new Point(701, 273);
    ((Control) this.ddOptions).Name = "ddOptions";
    ((Control) this.ddOptions).Size = new Size(203, 73);
    ((Control) this.ddOptions).TabIndex = 204;
    ((UltraDropDownBase) this.ddOptions).ValueMember = "MvrInsuranceOption";
    ((Control) this.ddOptions).Visible = false;
    this.ds.DataSetName = "dsDriverInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.ddProduct).DataMember = "dtProducts";
    ((UltraGridBase) this.ddProduct).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddProduct).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ultraGridBand2.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 0;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.ddProduct).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ddProduct).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddProduct).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddProduct).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddProduct).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddProduct).DisplayMember = "ProductID";
    ((UltraDropDownBase) this.ddProduct).DropDownWidth = 300;
    ((Control) this.ddProduct).Location = new Point(416, 273);
    ((Control) this.ddProduct).Name = "ddProduct";
    ((Control) this.ddProduct).Size = new Size(203, 73);
    ((Control) this.ddProduct).TabIndex = 203;
    ((UltraDropDownBase) this.ddProduct).ValueMember = "ProductID";
    ((Control) this.ddProduct).Visible = false;
    ((Control) this.ugDriversOrder).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugDriversOrder).DataMember = "dtOrdering";
    ((UltraGridBase) this.ugDriversOrder).DataSource = (object) this.ds;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "License #";
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 1;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "First";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Middle";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Last";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 4;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 5;
    ultraGridColumn9.Width = 65;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "State";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 6;
    ultraGridColumn10.Width = 64 /*0x40*/;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 7;
    ultraGridColumn11.Hidden = true;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 14;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Product ID";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 9;
    ultraGridColumn13.Style = (ColumnStyle) 6;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Sub-Type";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 10;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 12;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Vault Age";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 13;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "MVR Ins Option";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 11;
    ultraGridColumn17.Style = (ColumnStyle) 6;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "License Lookup";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 8;
    ultraGridBand3.Columns.AddRange(new object[15]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = Color.LightSteelBlue;
    appearance4.FontData.SizeInPoints = 10f;
    appearance4.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance4;
    appearance5.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance5.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance8.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance10.BackColor = Color.Transparent;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.WhiteSmoke;
    appearance11.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    appearance12.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugDriversOrder).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugDriversOrder).Location = new Point(12, 80 /*0x50*/);
    ((Control) this.ugDriversOrder).Name = "ugDriversOrder";
    ((Control) this.ugDriversOrder).Size = new Size(1227, 511 /*0x01FF*/);
    ((Control) this.ugDriversOrder).TabIndex = 66;
    ((UltraControlBase) this.ugDriversOrder).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDriversOrder).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkAdminLicenseLookup.AutoSize = true;
    this.lnkAdminLicenseLookup.Location = new Point(962, 54);
    this.lnkAdminLicenseLookup.Name = "lnkAdminLicenseLookup";
    this.lnkAdminLicenseLookup.Size = new Size(192 /*0xC0*/, 13);
    this.lnkAdminLicenseLookup.TabIndex = 206;
    this.lnkAdminLicenseLookup.TabStop = true;
    this.lnkAdminLicenseLookup.Text = "Admin License Validation Lookup State";
    this.lnkAdminLicenseLookup.Visible = false;
    this.lnkSelectAllLookup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllLookup.AutoSize = true;
    this.lnkSelectAllLookup.Location = new Point(16 /*0x10*/, 594);
    this.lnkSelectAllLookup.Name = "lnkSelectAllLookup";
    this.lnkSelectAllLookup.Size = new Size(148, 13);
    this.lnkSelectAllLookup.TabIndex = 207;
    this.lnkSelectAllLookup.TabStop = true;
    this.lnkSelectAllLookup.Text = "Select All License For Lookup";
    this.lnkSelectAllLookup.Visible = false;
    this.lnkDeSelectLookup.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectLookup.AutoSize = true;
    this.lnkDeSelectLookup.Location = new Point(16 /*0x10*/, 617);
    this.lnkDeSelectLookup.Name = "lnkDeSelectLookup";
    this.lnkDeSelectLookup.Size = new Size(165, 13);
    this.lnkDeSelectLookup.TabIndex = 208 /*0xD0*/;
    this.lnkDeSelectLookup.TabStop = true;
    this.lnkDeSelectLookup.Text = "De-Select All License For Lookup";
    this.lnkDeSelectLookup.Visible = false;
    ((Control) this.UltraTextEditor1).Location = new Point(965, 607);
    ((Control) this.UltraTextEditor1).Name = "UltraTextEditor1";
    this.UltraTextEditor1.PasswordChar = '*';
    ((Control) this.UltraTextEditor1).Size = new Size(15, 21);
    ((Control) this.UltraTextEditor1).TabIndex = 301;
    ((Control) this.UltraTextEditor1).Visible = false;
    this.lnkApplyAddDL.AutoSize = true;
    this.lnkApplyAddDL.Location = new Point(583, 16 /*0x10*/);
    this.lnkApplyAddDL.Name = "lnkApplyAddDL";
    this.lnkApplyAddDL.Size = new Size(240 /*0xF0*/, 13);
    this.lnkApplyAddDL.TabIndex = 302;
    this.lnkApplyAddDL.TabStop = true;
    this.lnkApplyAddDL.Text = "Apply \"DL\" product ID To All Drivers On The Grid";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1251, 635);
    this.Controls.Add((Control) this.lnkApplyAddDL);
    this.Controls.Add((Control) this.UltraTextEditor1);
    this.Controls.Add((Control) this.lnkDeSelectLookup);
    this.Controls.Add((Control) this.lnkSelectAllLookup);
    this.Controls.Add((Control) this.lnkAdminLicenseLookup);
    this.Controls.Add((Control) this.lnkSetOption);
    this.Controls.Add((Control) this.ddOptions);
    this.Controls.Add((Control) this.ddProduct);
    this.Controls.Add((Control) this.lnkAdminStateProduct);
    this.Controls.Add((Control) this.grpOption);
    this.Controls.Add((Control) this.grpProduct);
    this.Controls.Add((Control) this.ugDriversOrder);
    this.Controls.Add((Control) this.btnContinue);
    this.MaximizeBox = false;
    this.Name = nameof (FormDriverOrderingRecord);
    this.Text = "ADR Ordering";
    ((ISupportInitialize) this.err).EndInit();
    this.grpProduct.ResumeLayout(false);
    this.grpProduct.PerformLayout();
    this.grpOption.ResumeLayout(false);
    this.grpOption.PerformLayout();
    ((ISupportInitialize) this.ddOptions).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.ddProduct).EndInit();
    ((ISupportInitialize) this.ugDriversOrder).EndInit();
    ((ISupportInitialize) this.UltraTextEditor1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual Button btnContinue
  {
    get => this._btnContinue;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnContinue_Click);
      Button btnContinue1 = this._btnContinue;
      if (btnContinue1 != null)
        btnContinue1.Click -= eventHandler;
      this._btnContinue = value;
      Button btnContinue2 = this._btnContinue;
      if (btnContinue2 == null)
        return;
      btnContinue2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual UltraGrid ugDriversOrder
  {
    get => this._ugDriversOrder;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      InitializeLayoutEventHandler layoutEventHandler = new InitializeLayoutEventHandler(this.ugDriversOrder_InitializeLayout);
      CellEventHandler cellEventHandler = new CellEventHandler(this.ugDriversOrder_AfterCellUpdate);
      UltraGrid ugDriversOrder1 = this._ugDriversOrder;
      if (ugDriversOrder1 != null)
      {
        ugDriversOrder1.InitializeLayout -= layoutEventHandler;
        ugDriversOrder1.AfterCellUpdate -= cellEventHandler;
      }
      this._ugDriversOrder = value;
      UltraGrid ugDriversOrder2 = this._ugDriversOrder;
      if (ugDriversOrder2 == null)
        return;
      ugDriversOrder2.InitializeLayout += layoutEventHandler;
      ugDriversOrder2.AfterCellUpdate += cellEventHandler;
    }
  }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDriverInfo ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual RadioButton rbDL
  {
    get => this._rbDL;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.rbDL_CheckedChanged);
      RadioButton rbDl1 = this._rbDL;
      if (rbDl1 != null)
        rbDl1.CheckedChanged -= eventHandler;
      this._rbDL = value;
      RadioButton rbDl2 = this._rbDL;
      if (rbDl2 == null)
        return;
      rbDl2.CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("rbLX")]
  internal virtual RadioButton rbLX { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("grpProduct")]
  internal virtual GroupBox grpProduct { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkAdminStateProduct
  {
    get => this._lnkAdminStateProduct;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkAdminStateProduct_LinkClicked);
      LinkLabel adminStateProduct1 = this._lnkAdminStateProduct;
      if (adminStateProduct1 != null)
        adminStateProduct1.LinkClicked -= clickedEventHandler;
      this._lnkAdminStateProduct = value;
      LinkLabel adminStateProduct2 = this._lnkAdminStateProduct;
      if (adminStateProduct2 == null)
        return;
      adminStateProduct2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual UltraDropDown ddProduct
  {
    get => this._ddProduct;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.DdProduct_BeforeDropDown);
      DropDownEventHandler downEventHandler = new DropDownEventHandler(this.DdProduct_AfterCloseUp);
      UltraDropDown ddProduct1 = this._ddProduct;
      if (ddProduct1 != null)
      {
        ddProduct1.BeforeDropDown -= cancelEventHandler;
        ddProduct1.AfterCloseUp -= downEventHandler;
      }
      this._ddProduct = value;
      UltraDropDown ddProduct2 = this._ddProduct;
      if (ddProduct2 == null)
        return;
      ddProduct2.BeforeDropDown += cancelEventHandler;
      ddProduct2.AfterCloseUp += downEventHandler;
    }
  }

  [field: AccessedThroughProperty("ddOptions")]
  protected virtual UltraDropDown ddOptions { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkSetOption
  {
    get => this._lnkSetOption;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.LnkSetOption_LinkClicked);
      LinkLabel lnkSetOption1 = this._lnkSetOption;
      if (lnkSetOption1 != null)
        lnkSetOption1.LinkClicked -= clickedEventHandler;
      this._lnkSetOption = value;
      LinkLabel lnkSetOption2 = this._lnkSetOption;
      if (lnkSetOption2 == null)
        return;
      lnkSetOption2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("grpOption")]
  protected virtual GroupBox grpOption { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkAdminLicenseLookup
  {
    get => this._lnkAdminLicenseLookup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkAdminLicenseLookup_LinkClicked);
      LinkLabel adminLicenseLookup1 = this._lnkAdminLicenseLookup;
      if (adminLicenseLookup1 != null)
        adminLicenseLookup1.LinkClicked -= clickedEventHandler;
      this._lnkAdminLicenseLookup = value;
      LinkLabel adminLicenseLookup2 = this._lnkAdminLicenseLookup;
      if (adminLicenseLookup2 == null)
        return;
      adminLicenseLookup2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkSelectAllLookup
  {
    get => this._lnkSelectAllLookup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllLookup_LinkClicked);
      LinkLabel lnkSelectAllLookup1 = this._lnkSelectAllLookup;
      if (lnkSelectAllLookup1 != null)
        lnkSelectAllLookup1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllLookup = value;
      LinkLabel lnkSelectAllLookup2 = this._lnkSelectAllLookup;
      if (lnkSelectAllLookup2 == null)
        return;
      lnkSelectAllLookup2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeSelectLookup
  {
    get => this._lnkDeSelectLookup;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectLookup_LinkClicked);
      LinkLabel lnkDeSelectLookup1 = this._lnkDeSelectLookup;
      if (lnkDeSelectLookup1 != null)
        lnkDeSelectLookup1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectLookup = value;
      LinkLabel lnkDeSelectLookup2 = this._lnkDeSelectLookup;
      if (lnkDeSelectLookup2 == null)
        return;
      lnkDeSelectLookup2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("rbActivity")]
  protected virtual RadioButton rbActivity { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbFull")]
  protected virtual RadioButton rbFull { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbClean")]
  protected virtual RadioButton rbClean { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("rbVdetail")]
  protected virtual RadioButton rbVdetail { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("UltraTextEditor1")]
  internal virtual UltraTextEditor UltraTextEditor1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkApplyAddDL
  {
    get => this._lnkApplyAddDL;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkApplyAddDL_LinkClicked);
      LinkLabel lnkApplyAddDl1 = this._lnkApplyAddDL;
      if (lnkApplyAddDl1 != null)
        lnkApplyAddDl1.LinkClicked -= clickedEventHandler;
      this._lnkApplyAddDL = value;
      LinkLabel lnkApplyAddDl2 = this._lnkApplyAddDL;
      if (lnkApplyAddDl2 == null)
        return;
      lnkApplyAddDl2.LinkClicked += clickedEventHandler;
    }
  }

  public FormDriverOrderingRecord(int controlNo, Guid quoteGuid, dsDriverInfo tmpDataset)
  {
    this.Load += new EventHandler(this.FormDriverOrderingRecord_Load);
    this._continue = false;
    this._usingLxSetting = false;
    this._defaultLxSetting = false;
    this._isFinishedLoading = false;
    this.InitializeComponent();
    this._dataset = tmpDataset;
    this._canViewDOB = SecurityManager.Instance.AssertPermission("{94A70A52-72AD-41FC-AB43-E80119EB97C7}");
    this._canViewLicense = SecurityManager.Instance.AssertPermission("{6737F846-CC52-4FBF-BFD3-11506D3551AE}");
  }

  public bool ContinueProcess => this._continue;

  public dsDriverInfo.dtOrderingDataTable ProcessOrderTable => this.ds.dtOrdering;

  public string FullString => "Full";

  public string CleanString => "Clean";

  public string ActivityString => "Activity";

  public string VdetailString => "Vdetail";

  private bool ValidData()
  {
    int num1 = 1;
    this.err.SetError((Control) this.grpOption, string.Empty);
    bool flag;
    try
    {
      foreach (dsDriverInfo.dtOrderingRow row in this.ds.dtOrdering.Rows)
      {
        if (row.IsFirstNameNull())
        {
          int num2 = (int) MessageBox.Show($"Row # {num1.ToString()} is missing First Name.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_43;
        }
        if (row.IsLastNameNull())
        {
          int num3 = (int) MessageBox.Show($"Row # {num1.ToString()} is missing Last Name.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_43;
        }
        string str = string.Format($"See driver '{{0}} {{1}} '{Environment.NewLine}{Environment.NewLine}", (object) row.FirstName, (object) row.LastName);
        if (row.IsLicenseNumberNull())
        {
          int num4 = (int) MessageBox.Show(str + "Driver is missing license #", "Missing License #", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_43;
        }
        if (row.IsProductIDNull())
        {
          int num5 = (int) MessageBox.Show(str + "Record is missing Product ID.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_43;
        }
        if (row.IsSubTypeNull())
        {
          int num6 = (int) MessageBox.Show(str + "Record is missing Sub-Type.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_43;
        }
        if (row.IsPurposeNull())
        {
          int num7 = (int) MessageBox.Show(str + "Record is missing Purpose.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_43;
        }
        if (row.IsDOBNull())
        {
          int num8 = (int) MessageBox.Show(str + "Driver is missing DOB.", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_43;
        }
        if (row.ProductID.Equals("DL") && !row.StateID.EqualsNoCase("MO") && !row.SubType.EqualsNoCase("3Y"))
        {
          int num9 = (int) MessageBox.Show($"{str} - 'DL' product expects a sub-type of '3Y'", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_43;
        }
        if (!row.IsLicenseValidationLookupNull() && row.LicenseValidationLookup && !row.IsStateIDNull() && this.ds.tblDriverLicenseValidationStates.FindByStateID(row.StateID) == null)
        {
          int num10 = (int) MessageBox.Show($"See driver {str}. License validation lookup is not offered in the state of {row.StateID}.", "Invalid License Validation Lookup State", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_43;
        }
        if (this._usingLxSetting && !row.IsHintMvrInsuranceOptionNull())
        {
          if (row.HintMvrInsuranceOption.Equals(FormDriverOrderingRecord.RequestOption.Full.ToString()) && !this.HasStateOption(row.StateID, 3))
          {
            int num11 = (int) MessageBox.Show($"{str}State of {row.StateID} does not offer 'Full' MVR option.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_43;
          }
          if (row.HintMvrInsuranceOption.Equals(FormDriverOrderingRecord.RequestOption.Clean.ToString()) && !this.HasStateOption(row.StateID, 4))
          {
            int num12 = (int) MessageBox.Show($"{str}State of {row.StateID} does not offer 'Clean' MVR option.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_43;
          }
          if (row.HintMvrInsuranceOption.Equals(FormDriverOrderingRecord.RequestOption.Activity.ToString()) && !this.HasStateOption(row.StateID, 5))
          {
            int num13 = (int) MessageBox.Show($"{str}State of {row.StateID} does not offer 'Activity' MVR option.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_43;
          }
          if (row.HintMvrInsuranceOption.Equals(FormDriverOrderingRecord.RequestOption.Vdetail.ToString()) && !this.HasStateOption(row.StateID, 6))
          {
            int num14 = (int) MessageBox.Show($"{str}State of {row.StateID} does not offer 'Vdetail' MVR option.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_43;
          }
          if (this.IsVoltaState(row.StateID) && row.HintMvrInsuranceOption.Equals($"<{FormDriverOrderingRecord.RequestOption.None.ToString()}>"))
          {
            int num15 = (int) MessageBox.Show($"{str}Please select an 'MVR Ins Option'\n\nState of {row.StateID} does not offer '<None>' MVR option.", "Invalid MVR Ins Option Selection '<None>'", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_43;
          }
          if (!this.IsVoltaState(row.StateID) && row.ProductID.Equals("LX"))
          {
            int num16 = (int) MessageBox.Show($"{str}The state of '{row.StateID}' is not a volta state and does not offer 'LX' product", "Invalid Product ID Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_43;
          }
          if (this.IsVoltaState(row.StateID) && row.ProductID.Equals("LX") && row.HintMvrInsuranceOption.Equals($"<{FormDriverOrderingRecord.RequestOption.Unavailable.ToString()}>"))
          {
            int num17 = (int) MessageBox.Show($"{str}The state of {row.StateID} is a volta state and <Unavailable>  does not match 'LX' Product ID selection.", "Invalid MVR Option Selection", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_43;
          }
        }
        ++num1;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (this._usingLxSetting && this.rbLX.Checked && !this.rbFull.Checked && !this.rbClean.Checked && !this.rbActivity.Checked && !this.rbVdetail.Checked)
    {
      int num18 = (int) MessageBox.Show("Policy watch LX specification is checked.\n\nPlease select 'Full', Clean', 'Activity' or 'Vdetail' ordering option.", "Invalid Order Option", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      this.err.SetError((Control) this.grpOption, "Choose an option");
      flag = false;
    }
    else
      flag = true;
label_43:
    return flag;
  }

  private void btnContinue_Click(object sender, EventArgs e)
  {
    if (!this.ValidData() || !this.ValidateSubType())
      return;
    this.MassageData();
    this._continue = true;
    this.Close();
  }

  private void MassageData()
  {
    try
    {
      foreach (dsDriverInfo.dtOrderingRow row in this.ds.dtOrdering.Rows)
      {
        if (row.StateID.Equals("NM") && row.LicenseNumber.Substring(0, 2).Equals("NM"))
          row.LicenseNumber = row.LicenseNumber.Replace("NM", string.Empty);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private string GetSubType(string stateID, bool validateDriverLicenseProduct)
  {
    string subType;
    if (validateDriverLicenseProduct || !this._defaultLxSetting)
    {
      subType = Interaction.IIf(stateID.Equals("MO"), (object) "DB", (object) "3Y").ToString();
    }
    else
    {
      if (this._defaultLxSetting)
      {
        dsDriverInfo.tblDriverProductStatesRow byStateId = this.ds.tblDriverProductStates.FindByStateID(stateID);
        if (byStateId != null)
        {
          if (!byStateId.IsAlternateSubTypeNull())
          {
            subType = byStateId.AlternateSubType;
            goto label_9;
          }
          if (!byStateId.IsSubTypeNull())
          {
            subType = byStateId.SubType;
            goto label_9;
          }
        }
      }
      subType = Interaction.IIf(stateID.Equals("MO"), (object) "DB", (object) "3Y").ToString();
    }
label_9:
    return subType;
  }

  private string GetProductType(string stateID)
  {
    string productType;
    if (!this._defaultLxSetting)
    {
      productType = "DL";
    }
    else
    {
      dsDriverInfo.tblDriverProductStatesRow byStateId = this.ds.tblDriverProductStates.FindByStateID(stateID);
      productType = byStateId == null || byStateId.IsSubTypeNull() && byStateId.IsAlternateSubTypeNull() ? "DL" : "LX";
    }
    return productType;
  }

  protected virtual bool IsVoltaState(string stateID)
  {
    bool flag;
    if (!this._defaultLxSetting)
    {
      flag = false;
    }
    else
    {
      dsDriverInfo.tblDriverProductStatesRow byStateId = this.ds.tblDriverProductStates.FindByStateID(stateID);
      flag = byStateId != null && !byStateId.IsSubTypeNull() | !byStateId.IsAlternateSubTypeNull();
    }
    return flag;
  }

  private void LoadDriverProductStates()
  {
    this.ds.tblDriverProductStates.Clear();
    string str = "SELECT StateID, SubType, FullOption, CleanOption, ActivityOption, VdetailOption, AlternateSubType FROM tblDriverProductStates WITH (NOLOCK) ";
    if (!this._defaultLxSetting)
      str += " WHERE 1=0";
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblDriverProductStates"
    }, CommandType.Text, str);
  }

  private void FormDriverOrderingRecord_Load(object sender, EventArgs e)
  {
    if (MGASystems.Common.Settings.SystemSettings.GetSetting<bool>("DefaultToLXForDriverMVRs"))
    {
      this._defaultLxSetting = true;
      this.lnkSetOption.Visible = true;
    }
    else
      this.lnkSetOption.Visible = false;
    if (!ADRConnectWrapper.ImplementsLicenseLookup)
    {
      this.lnkAdminLicenseLookup.Visible = false;
      this.lnkSelectAllLookup.Visible = false;
      this.lnkDeSelectLookup.Visible = false;
      ((UltraGridBase) this.ugDriversOrder).DisplayLayout.Bands[0].Columns["LicenseValidationLookup"].Hidden = true;
    }
    this.ds.dtProducts.AdddtProductsRow("DL", 0);
    this.ds.dtProducts.AdddtProductsRow("LX", 0);
    this.ds.dtProducts.AdddtProductsRow("<Unavailable>", 1);
    this.ds.dtProducts.AdddtProductsRow("<None>", 2);
    this.ds.dtProducts.AdddtProductsRow("Full", 3);
    this.ds.dtProducts.AdddtProductsRow("Clean", 4);
    this.ds.dtProducts.AdddtProductsRow("Activity", 5);
    this.ds.dtProducts.AdddtProductsRow("Vdetail", 6);
    this.LoadDriverProductStates();
    this.LoadLicenseLookupStates();
    bool flag1 = false;
    dsDriverInfo.tblDriverProductStatesRow productStatesRow = (dsDriverInfo.tblDriverProductStatesRow) null;
    if (this._defaultLxSetting)
    {
      try
      {
        foreach (dsDriverInfo.tblDriverInfoRow row in this._dataset.tblDriverInfo.Rows)
        {
          if (!row.IsADRNull() && row.ADR && this.IsVoltaState(row.StateID))
          {
            productStatesRow = this.ds.tblDriverProductStates.FindByStateID(row.StateID);
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
    }
    bool flag2 = false;
    bool flag3 = false;
    bool flag4 = false;
    bool flag5 = false;
    if (productStatesRow != null)
    {
      flag1 = !productStatesRow.IsSubTypeNull() || !productStatesRow.IsAlternateSubTypeNull();
      if (!productStatesRow.IsNull("FullOption"))
        flag2 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(productStatesRow["FullOption"]));
      if (!productStatesRow.IsNull("CleanOption"))
        flag3 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(productStatesRow["CleanOption"]));
      if (!productStatesRow.IsNull("ActivityOption"))
        flag4 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(productStatesRow["ActivityOption"]));
      if (!productStatesRow.IsNull("VdetailOption"))
        flag5 = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(productStatesRow["VdetailOption"]));
    }
    if (flag1 && this._defaultLxSetting)
    {
      this._usingLxSetting = true;
      this.rbDL.Checked = false;
      this.rbLX.Checked = true;
      this.rbFull.Checked = flag2;
      this.rbClean.Checked = flag3;
      this.rbActivity.Checked = flag4;
      this.rbVdetail.Checked = flag5;
    }
    else
    {
      this.rbDL.Checked = true;
      this.rbLX.Checked = false;
      this.rbLX.Enabled = false;
    }
    try
    {
      foreach (dsDriverInfo.tblDriverInfoRow row1 in this._dataset.tblDriverInfo.Rows)
      {
        if (!row1.IsADRNull() && row1.ADR)
        {
          dsDriverInfo.dtOrderingRow row2 = this.ds.dtOrdering.NewdtOrderingRow();
          row2.DriverID = (int) row1.DriverID;
          row2.LicenseNumber = row1.LicenseNumber;
          row2.FirstName = row1.FirstName;
          row2.LastName = row1.LastName;
          row2.DOB = row1.DOB;
          row2.StateID = row1.StateID;
          row2.ProductID = this.GetProductType(row2.StateID);
          row2.SubType = this.GetSubType(row2.StateID, !row2.IsProductIDNull() && row2.ProductID.EqualsNoCase("DL") && row2.StateID.Equals("MO"));
          string requestOption = this.GetRequestOption(row2.StateID);
          row2.HintMvrInsuranceOption = string.IsNullOrEmpty(requestOption) ? (this._usingLxSetting ? "<None>" : "<Unavailable>") : requestOption;
          row2.Purpose = "AA";
          row2.LicenseValidationLookup = this.IsLicenseLookupState(row2.StateID);
          this.ds.dtOrdering.AdddtOrderingRow(row2);
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.DefaultInsuranceOption();
    this.CleanStatesAssignment();
    ((UltraGridBase) this.ugDriversOrder).UpdateData();
    this.OnFormLoad();
    this._isFinishedLoading = true;
  }

  private void DefaultInsuranceOption()
  {
    int setting = MGASystems.Common.Settings.SystemSettings.GetSetting<int>("DefaultDriverLXInsuranceOption", -1);
    string str;
    switch (setting)
    {
      case -1:
        return;
      case 1:
        str = "<Unavailable>";
        break;
      case 2:
        str = "<None>";
        break;
      case 3:
        str = "Full";
        this.rbFull.Checked = true;
        break;
      case 4:
        str = "Clean";
        this.rbClean.Checked = true;
        break;
      case 5:
        str = "Activity";
        this.rbActivity.Checked = true;
        break;
      case 6:
        str = "Vdetail";
        this.rbVdetail.Checked = true;
        break;
      default:
        str = string.Empty;
        break;
    }
    if (string.IsNullOrEmpty(str))
      return;
    try
    {
      foreach (dsDriverInfo.dtOrderingRow row in this.ds.dtOrdering.Rows)
      {
        if (this.IsVoltaState(row.StateID) && this.HasStateOption(row.StateID, setting))
          row.HintMvrInsuranceOption = str;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private string GetRequestOption(string stateID)
  {
    string requestOption;
    if (!this._defaultLxSetting)
    {
      requestOption = "<Unavailable>";
    }
    else
    {
      bool flag1 = false;
      bool flag2 = false;
      bool flag3 = false;
      bool flag4 = false;
      dsDriverInfo.tblDriverProductStatesRow byStateId = this.ds.tblDriverProductStates.FindByStateID(stateID);
      if (byStateId != null)
      {
        flag1 = !byStateId.IsFullOptionNull() && byStateId.FullOption;
        flag2 = !byStateId.IsCleanOptionNull() && byStateId.CleanOption;
        flag3 = !byStateId.IsActivityOptionNull() && byStateId.ActivityOption;
        flag4 = !byStateId.IsVdetailOptionNull() && byStateId.VdetailOption;
        if (flag1 && !flag2 && !flag3 && !flag4)
        {
          requestOption = "Full";
          goto label_12;
        }
        if (flag2 && !flag1 && !flag3 && !flag4)
        {
          requestOption = "Clean";
          goto label_12;
        }
        if (flag3 && !flag1 && !flag2 && !flag4)
        {
          requestOption = "Activity";
          goto label_12;
        }
        if (flag4 && !flag1 && !flag2 && !flag3)
        {
          requestOption = "Vdetail";
          goto label_12;
        }
      }
      requestOption = flag1 || flag2 || flag3 || flag4 ? "<None>" : "<Unavailable>";
    }
label_12:
    return requestOption;
  }

  private void rbDL_CheckedChanged(object sender, EventArgs e)
  {
    if (this.rbDL.Checked)
    {
      this.grpOption.Enabled = false;
      this.rbFull.Checked = false;
      this.rbClean.Checked = false;
      this.rbActivity.Checked = false;
      this.rbVdetail.Checked = false;
    }
    else
      this.grpOption.Enabled = true;
  }

  private void LnkAdminStateProduct_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormDriverProductStates formEx = (FormDriverProductStates) ObjectFactory.Instance.CreateFormEX(typeof (FormDriverProductStates));
    try
    {
      int num = (int) formEx.ShowDialog();
    }
    finally
    {
      formEx.Dispose();
    }
    this.LoadDriverProductStates();
    this.UpdateSubTypes();
  }

  private void LnkSetOption_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    string str = string.Empty;
    FormDriverOrderingRecord.RequestOption ID = (FormDriverOrderingRecord.RequestOption) 0;
    if (this.rbFull.Checked)
    {
      str = "Full";
      ID = FormDriverOrderingRecord.RequestOption.Full;
    }
    if (this.rbClean.Checked)
    {
      str = "Clean";
      ID = FormDriverOrderingRecord.RequestOption.Clean;
    }
    if (this.rbActivity.Checked)
    {
      str = "Activity";
      ID = FormDriverOrderingRecord.RequestOption.Activity;
    }
    if (this.rbVdetail.Checked)
    {
      str = "Vdetail";
      ID = FormDriverOrderingRecord.RequestOption.Vdetail;
    }
    if (str.Equals(string.Empty))
    {
      int num = (int) MessageBox.Show("You have Not chosen a MVR Option.", "MVR Option Not Chosen", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      if (MessageBox.Show($"Apply '{str}' MVR Option to all LX (Volta) states?", "Update MVR Option(s)?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      try
      {
        foreach (dsDriverInfo.dtOrderingRow row in this.ds.dtOrdering.Rows)
        {
          if (this.IsVoltaState(row.StateID) && this.HasStateOption(row.StateID, (int) ID))
            row.HintMvrInsuranceOption = str;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      ((UltraGridBase) this.ugDriversOrder).UpdateData();
    }
  }

  protected virtual bool HasStateOption(string stateID, int ID)
  {
    bool flag;
    if (!this._defaultLxSetting)
    {
      flag = false;
    }
    else
    {
      dsDriverInfo.tblDriverProductStatesRow byStateId = this.ds.tblDriverProductStates.FindByStateID(stateID);
      if (byStateId != null)
      {
        if (ID == 3 && !byStateId.IsFullOptionNull() && byStateId.FullOption)
        {
          flag = true;
          goto label_12;
        }
        if (ID == 4 && !byStateId.IsCleanOptionNull() && byStateId.CleanOption)
        {
          flag = true;
          goto label_12;
        }
        if (ID == 5 && !byStateId.IsActivityOptionNull() && byStateId.ActivityOption)
        {
          flag = true;
          goto label_12;
        }
        if (ID == 6 && !byStateId.IsVdetailOptionNull() && byStateId.VdetailOption)
        {
          flag = true;
          goto label_12;
        }
      }
      flag = false;
    }
label_12:
    return flag;
  }

  private void DdProduct_BeforeDropDown(object sender, CancelEventArgs e)
  {
    if (((UltraGridBase) this.ugDriversOrder).ActiveRow == null || this.ugDriversOrder.ActiveCell == null)
      return;
    string stateID = ((UltraGridBase) this.ugDriversOrder).ActiveRow.Cells["StateID"].Value.ToString();
    string empty = string.Empty;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugDriversOrder).ActiveRow.Cells["ProductID"].Value)))
      empty = ((UltraGridBase) this.ugDriversOrder).ActiveRow.Cells["ProductID"].Value.ToString();
    foreach (UltraGridRow row in ((UltraGridBase) this.ddProduct).Rows)
    {
      row.Hidden = true;
      if (this.ugDriversOrder.ActiveCell.Column.Key.Equals("ProductID") && Conversions.ToInteger(row.Cells["ID"].Value) == 0)
        row.Hidden = false;
      else if (this.ugDriversOrder.ActiveCell.Column.Key.Equals("HintMvrInsuranceOption") && Conversions.ToInteger(row.Cells["ID"].Value) > 0)
      {
        row.Hidden = false;
        if (!this.IsVoltaState(stateID) && Conversions.ToInteger(row.Cells["ID"].Value) > 0)
          row.Hidden = true;
        else if (this.IsVoltaState(stateID) && !empty.Equals("DL") && Conversions.ToInteger(row.Cells["ID"].Value) == 1)
          row.Hidden = true;
        else if (Conversions.ToInteger(row.Cells["ID"].Value) > 2 && !this.HasStateOption(stateID, Conversions.ToInteger(row.Cells["ID"].Value)))
          row.Hidden = true;
        else if (empty.Equals("DL") && Conversions.ToInteger(row.Cells["ID"].Value) > 1)
          row.Hidden = true;
      }
    }
  }

  private void DdProduct_AfterCloseUp(object sender, DropDownEventArgs e)
  {
    if (((UltraGridBase) this.ugDriversOrder).ActiveRow == null || this.ugDriversOrder.ActiveCell == null)
      return;
    string str = string.Empty;
    if (!string.IsNullOrEmpty(((UltraGridBase) this.ugDriversOrder).ActiveRow.Cells["ProductID"].Text))
      str = ((UltraGridBase) this.ugDriversOrder).ActiveRow.Cells["ProductID"].Text;
    if (this.ugDriversOrder.ActiveCell.Column.Key.Equals("HintMvrInsuranceOption"))
    {
      if (str.Equals("DL"))
        ((UltraGridBase) this.ugDriversOrder).ActiveRow.Cells["HintMvrInsuranceOption"].Value = (object) "<Unavailable>";
    }
    else if (this.ugDriversOrder.ActiveCell.Column.Key.Equals("ProductID") && str.Equals("DL"))
      ((UltraGridBase) this.ugDriversOrder).ActiveRow.Cells["HintMvrInsuranceOption"].Value = (object) "<Unavailable>";
    ((UltraGridBase) this.ugDriversOrder).UpdateData();
  }

  private void lnkAdminLicenseLookup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    FormStateLicenseLookupAdmin formEx = (FormStateLicenseLookupAdmin) ObjectFactory.Instance.CreateFormEX(typeof (FormStateLicenseLookupAdmin));
    try
    {
      int num = (int) formEx.ShowDialog();
    }
    finally
    {
      formEx.Dispose();
    }
  }

  private void lnkSelectAllLookup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.AssignLookup(true);
  }

  private void LoadLicenseLookupStates()
  {
    this.ds.tblDriverLicenseValidationStates.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblDriverLicenseValidationStates"
    }, CommandType.Text, "SELECT StateID FROM tblDriverLicenseValidationStates WITH (NOLOCK) ");
  }

  private void lnkDeSelectLookup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.AssignLookup(false);
  }

  private void AssignLookup(bool val)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugDriversOrder).Rows)
      row.Cells["LicenseValidationLookup"].Value = (object) val;
    ((UltraGridBase) this.ugDriversOrder).UpdateData();
  }

  protected virtual void OnFormLoad()
  {
  }

  private void CleanStatesAssignment()
  {
    string setting = MGASystems.Common.Settings.SystemSettings.GetSetting<string>("ADR.CleanStates", string.Empty);
    if (string.IsNullOrEmpty(setting))
      return;
    string[] source = setting.Split(',');
    foreach (UltraGridRow row in ((UltraGridBase) this.ugDriversOrder).Rows)
    {
      if (((IEnumerable<string>) source).Contains<string>(row.Cells["StateID"].Value.ToString()))
        row.Cells["HintMvrInsuranceOption"].Value = (object) this.CleanString;
    }
  }

  private bool IsLicenseLookupState(string stateID)
  {
    return this._defaultLxSetting && ADRConnectWrapper.ImplementsLicenseLookup && this.ds.tblDriverLicenseValidationStates.FindByStateID(stateID) != null;
  }

  private void ugDriversOrder_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridBand band = e.Layout.Bands[0];
    this.UltraTextEditor1.PasswordChar = '*';
    if (!this._canViewLicense)
      band.Columns["LicenseNumber"].EditorComponent = (Component) this.UltraTextEditor1;
    if (this._canViewDOB)
      return;
    band.Columns["DOB"].EditorComponent = (Component) this.UltraTextEditor1;
  }

  private void lnkApplyAddDL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      foreach (dsDriverInfo.dtOrderingRow row in this.ds.dtOrdering.Rows)
      {
        row.ProductID = "DL";
        row.SubType = "3Y";
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.ds.dtOrdering.AcceptChanges();
  }

  private void ugDriversOrder_AfterCellUpdate(object sender, CellEventArgs e)
  {
    if (!this._isFinishedLoading || !e.Cell.Column.Key.Equals("ProductID") || Utility.IsNull(RuntimeHelpers.GetObjectValue(e.Cell.Value)))
      return;
    if (e.Cell.Value.ToString().EqualsNoCase("DL"))
    {
      e.Cell.Row.Cells["SubType"].Value = (object) this.GetSubType(e.Cell.Row.Cells["stateID"].Value.ToString(), true);
    }
    else
    {
      if (!e.Cell.Value.ToString().EqualsNoCase("LX") || Utility.IsNull(RuntimeHelpers.GetObjectValue(e.Cell.Row.Cells["stateID"].Value)))
        return;
      e.Cell.Row.Cells["SubType"].Value = (object) this.GetSubType(e.Cell.Row.Cells["stateID"].Value.ToString(), false);
    }
  }

  private bool ValidateSubType()
  {
    List<string> stringList = new List<string>()
    {
      "DB",
      "3Y"
    };
    bool flag;
    try
    {
      foreach (dsDriverInfo.dtOrderingRow row in this.ds.dtOrdering.Rows)
      {
        if (row.IsSubTypeNull())
        {
          int num = (int) MessageBox.Show($"Subtype is blank for the state of {row.StateID}.", "Missing SubType", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_11;
        }
        if ((!row.IsProductIDNull() && row.ProductID.EqualsNoCase("DL") && row.StateID.Equals("MO") || !this._defaultLxSetting) && !stringList.Contains(row.SubType))
        {
          int num = (int) MessageBox.Show($"Subtype of {row.SubType} is not a valid option for the state of {row.StateID}.", "Invalid SubType", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag = false;
          goto label_11;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = true;
label_11:
    return flag;
  }

  private void UpdateSubTypes()
  {
    if (!this._defaultLxSetting)
      return;
    try
    {
      foreach (dsDriverInfo.dtOrderingRow row in this.ds.dtOrdering.Rows)
      {
        if (!row.IsStateIDNull() && !row.IsProductIDNull() && !row.ProductID.EqualsNoCase("DL"))
        {
          dsDriverInfo.tblDriverProductStatesRow byStateId = this.ds.tblDriverProductStates.FindByStateID(row.StateID);
          if (byStateId != null && !byStateId.IsAlternateSubTypeNull() && byStateId.AlternateSubType.Replace(" ", string.Empty).Length > 0)
            row.SubType = byStateId.AlternateSubType;
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

  protected enum RequestOption
  {
    Unavailable = 1,
    None = 2,
    Full = 3,
    Clean = 4,
    Activity = 5,
    Vdetail = 6,
  }
}
