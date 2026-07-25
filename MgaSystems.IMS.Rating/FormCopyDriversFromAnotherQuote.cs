// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.Rating.FormCopyDriversFromAnotherQuote
// Assembly: MgaSystems.IMS.Rating, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 370B8F0A-FA1A-41D0-87BD-563CC23E9EA7
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Rating.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinMaskedEdit;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Policies.Rating;

[DesignerGenerated]
public class FormCopyDriversFromAnotherQuote : Form
{
  private IContainer components;
  private bool _selectCopy;
  private readonly int _controlNo;
  private string _DriverNumbers;

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
    Appearance appearance5 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("dtDriverInfo", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("DriverID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ControlNo");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("QuoteStatus");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("FirstName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("LastName");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("DOB");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("LicenseNumber");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("StateID", -1, (object) "uddState");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("StatusID", -1, (object) "uddDriverStatus");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("DateAdded");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("DriverDeleted");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("DriverAdded");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("NumberOfPoints");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("FullPartTime");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("LicenseExpDate");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Street1");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("City");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("ZipCode");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("Copy");
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("lstDriverStatus", -1);
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("DriverStatusID");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("Status");
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
    this.numControlNo = new MGANumericEditor();
    this.btnCopy = new Button();
    this.txtAddress = new MGATextBox();
    this.txtFirstName = new MGATextBox();
    this.txtLastName = new MGATextBox();
    this.ugDrivers = new UltraGrid();
    this.ds = new dsDriverInfo();
    this.lnkResetSearch = new LinkLabel();
    this.btnSearch = new MGAButton();
    this.uddDriverStatus = new UltraDropDown();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelectAll = new LinkLabel();
    Label label1 = new Label();
    Label label2 = new Label();
    Label label3 = new Label();
    Label label4 = new Label();
    ((ISupportInitialize) this.numControlNo).BeginInit();
    ((ISupportInitialize) this.txtAddress).BeginInit();
    ((ISupportInitialize) this.txtFirstName).BeginInit();
    ((ISupportInitialize) this.txtLastName).BeginInit();
    ((ISupportInitialize) this.ugDrivers).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.uddDriverStatus).BeginInit();
    this.SuspendLayout();
    label1.BackColor = Color.Transparent;
    label1.Location = new Point(39, 10);
    label1.Name = "label1";
    label1.Size = new Size(64 /*0x40*/, 23);
    label1.TabIndex = 7;
    label1.Text = "Control #:";
    label1.TextAlign = ContentAlignment.MiddleRight;
    label2.BackColor = Color.Transparent;
    label2.Location = new Point(12, 45);
    label2.Name = "Label2";
    label2.Size = new Size(91, 21);
    label2.TabIndex = 10;
    label2.Text = "Address:";
    label2.TextAlign = ContentAlignment.MiddleRight;
    label3.BackColor = Color.Transparent;
    label3.Location = new Point(301, 10);
    label3.Name = "Label3";
    label3.Size = new Size(64 /*0x40*/, 23);
    label3.TabIndex = 19;
    label3.Text = "First Name:";
    label3.TextAlign = ContentAlignment.MiddleRight;
    label4.BackColor = Color.Transparent;
    label4.Location = new Point(301, 45);
    label4.Name = "Label4";
    label4.Size = new Size(64 /*0x40*/, 23);
    label4.TabIndex = 21;
    label4.Text = "Last Name:";
    label4.TextAlign = ContentAlignment.MiddleRight;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraNumericEditorBase) this.numControlNo).Appearance = (AppearanceBase) appearance1;
    ((UltraNumericEditorBase) this.numControlNo).FormatString = "";
    ((Control) this.numControlNo).Location = new Point(109, 12);
    this.numControlNo.MGAStyle = MGAStyles.Blue;
    ((Control) this.numControlNo).Name = "numControlNo";
    this.numControlNo.Nullable = true;
    ((Control) this.numControlNo).Size = new Size(128 /*0x80*/, 19);
    ((Control) this.numControlNo).TabIndex = 0;
    ((UltraWinEditorMaskedControlBase) this.numControlNo).TabNavigation = (MaskedEditTabNavigation) 0;
    ((UltraControlBase) this.numControlNo).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.numControlNo).UseOsThemes = (DefaultableBoolean) 2;
    this.numControlNo.Value = (object) null;
    this.btnCopy.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.btnCopy.Location = new Point(428, 346);
    this.btnCopy.Name = "btnCopy";
    this.btnCopy.Size = new Size(74, 23);
    this.btnCopy.TabIndex = 7;
    this.btnCopy.Text = "Copy";
    this.btnCopy.UseVisualStyleBackColor = true;
    appearance2.BackColor = Color.White;
    appearance2.BackColor2 = Color.White;
    appearance2.BackGradientAlignment = (GradientAlignment) 1;
    appearance2.BackGradientStyle = (GradientStyle) 3;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtAddress).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.txtAddress).BackColor = Color.White;
    ((Control) this.txtAddress).Location = new Point(109, 47);
    ((TextEditorControlBase) this.txtAddress).MaxLength = 250;
    this.txtAddress.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtAddress).Name = "txtAddress";
    ((Control) this.txtAddress).Size = new Size(128 /*0x80*/, 19);
    ((Control) this.txtAddress).TabIndex = 1;
    ((UltraControlBase) this.txtAddress).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtAddress).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BackColor = Color.White;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientAlignment = (GradientAlignment) 1;
    appearance3.BackGradientStyle = (GradientStyle) 3;
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance3.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtFirstName).Appearance = (AppearanceBase) appearance3;
    ((TextEditorControlBase) this.txtFirstName).BackColor = Color.White;
    ((Control) this.txtFirstName).Location = new Point(371, 12);
    ((TextEditorControlBase) this.txtFirstName).MaxLength = 250;
    this.txtFirstName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtFirstName).Name = "txtFirstName";
    ((Control) this.txtFirstName).Size = new Size(146, 19);
    ((Control) this.txtFirstName).TabIndex = 2;
    ((UltraControlBase) this.txtFirstName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtFirstName).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientAlignment = (GradientAlignment) 1;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtLastName).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtLastName).BackColor = Color.White;
    ((Control) this.txtLastName).Location = new Point(371, 47);
    ((TextEditorControlBase) this.txtLastName).MaxLength = 250;
    this.txtLastName.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtLastName).Name = "txtLastName";
    ((Control) this.txtLastName).Size = new Size(146, 19);
    ((Control) this.txtLastName).TabIndex = 3;
    ((UltraControlBase) this.txtLastName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtLastName).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ugDrivers).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugDrivers).DataMember = "dtDriverInfo";
    ((UltraGridBase) this.ugDrivers).DataSource = (object) this.ds;
    appearance5.BackColor = Color.White;
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Appearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Control #";
    ultraGridColumn2.Header.VisiblePosition = 4;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Policy #";
    ultraGridColumn3.Header.VisiblePosition = 6;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 7;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "Quote Status";
    ultraGridColumn5.Header.VisiblePosition = 5;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Driver First";
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn6.Width = 129;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Driver Last ";
    ultraGridColumn7.Header.VisiblePosition = 3;
    ultraGridColumn7.Width = 118;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ultraGridColumn8.Header.VisiblePosition = 8;
    ultraGridColumn8.Width = 75;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "License #";
    ultraGridColumn9.Header.VisiblePosition = 9;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "State";
    ultraGridColumn10.Header.VisiblePosition = 19;
    ultraGridColumn10.Style = (ColumnStyle) 6;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Status";
    ultraGridColumn11.Header.VisiblePosition = 10;
    ultraGridColumn11.Style = (ColumnStyle) 6;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Added";
    ultraGridColumn12.Header.VisiblePosition = 11;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.Header.VisiblePosition = 12;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Header.VisiblePosition = 13;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Caption = "Points";
    ultraGridColumn15.Header.VisiblePosition = 14;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.Header.VisiblePosition = 15;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn17.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Lic. Exp.";
    ultraGridColumn17.Header.VisiblePosition = 16 /*0x10*/;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ultraGridColumn18.Header.VisiblePosition = 17;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ultraGridColumn19.Header.VisiblePosition = 18;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Zip";
    ultraGridColumn20.Header.VisiblePosition = 20;
    ultraGridColumn21.Header.VisiblePosition = 1;
    ultraGridColumn21.Width = 70;
    ultraGridBand1.Columns.AddRange(new object[21]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
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
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21
    });
    ((UltraGridBase) this.ugDrivers).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance6.BackColor = Color.LightSteelBlue;
    appearance6.FontData.SizeInPoints = 10f;
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance6;
    appearance7.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance7.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance8.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance10.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance10;
    appearance11.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = Color.Transparent;
    appearance12.ForeColor = Color.Black;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.WhiteSmoke;
    appearance13.BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((UltraGridBase) this.ugDrivers).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugDrivers).Location = new Point(12, 72);
    ((Control) this.ugDrivers).Name = "ugDrivers";
    ((Control) this.ugDrivers).Size = new Size(880, 249);
    ((Control) this.ugDrivers).TabIndex = 23;
    ((UltraControlBase) this.ugDrivers).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugDrivers).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsDriverInfo";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkResetSearch.Location = new Point(541, 50);
    this.lnkResetSearch.Name = "lnkResetSearch";
    this.lnkResetSearch.Size = new Size(80 /*0x50*/, 16 /*0x10*/);
    this.lnkResetSearch.TabIndex = 4;
    this.lnkResetSearch.TabStop = true;
    this.lnkResetSearch.Text = "Reset Search";
    ((Control) this.btnSearch).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance15.ImageHAlign = (HAlign) 2;
    appearance15.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance15;
    ((ControlBase) this.btnSearch).BackColorInternal = Color.FromArgb(250, 250, 250);
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((Control) this.btnSearch).Location = new Point(852, 329);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 8;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    ((UltraGridBase) this.uddDriverStatus).DataMember = "lstDriverStatus";
    ((UltraGridBase) this.uddDriverStatus).DataSource = (object) this.ds;
    appearance16.BackColor = SystemColors.Window;
    appearance16.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Appearance = (AppearanceBase) appearance16;
    ultraGridColumn22.Header.VisiblePosition = 0;
    ultraGridColumn23.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn22,
      (object) ultraGridColumn23
    });
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance17.BackColor = SystemColors.ActiveBorder;
    appearance17.BackColor2 = SystemColors.ControlDark;
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) this.uddDriverStatus).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance18.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance18.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance18;
    ((SpecialBoxBase) ((UltraGridBase) this.uddDriverStatus).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance19.BackColor = SystemColors.ControlLightLight;
    appearance19.BackColor2 = SystemColors.Control;
    appearance19.BackGradientStyle = (GradientStyle) 3;
    appearance19.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance19.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.MaxRowScrollRegions = 1;
    appearance20.BackColor = SystemColors.Window;
    appearance20.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance20.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance20;
    appearance21.BackColor = SystemColors.Highlight;
    appearance21.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    appearance21.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance21;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance22.BackColor = SystemColors.Window;
    appearance22.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance22;
    appearance23.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance23.BorderColor = Color.Silver;
    appearance23.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.CellPadding = 0;
    appearance24.BackColor = SystemColors.Control;
    appearance24.BackColor2 = SystemColors.ControlDark;
    appearance24.BackGradientAlignment = (GradientAlignment) 1;
    appearance24.BackGradientStyle = (GradientStyle) 3;
    appearance24.BorderColor = SystemColors.Window;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance24;
    appearance25.BackColor = Color.FromArgb(240 /*0xF0*/, 246, 254);
    appearance25.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((AppearanceBase) appearance25).TextHAlignAsString = "Left";
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance25;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance26.BackColor = SystemColors.Window;
    appearance26.BorderColor = Color.Silver;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance26;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance27.BackColor = SystemColors.ControlLight;
    appearance27.BorderColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance27;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) this.uddDriverStatus).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) this.uddDriverStatus).DisplayMember = "Status";
    ((Control) this.uddDriverStatus).Location = new Point(405, 174);
    ((Control) this.uddDriverStatus).Name = "uddDriverStatus";
    ((Control) this.uddDriverStatus).Size = new Size(96 /*0x60*/, 32 /*0x20*/);
    ((Control) this.uddDriverStatus).TabIndex = 27;
    ((UltraDropDownBase) this.uddDriverStatus).ValueMember = "DriverStatusID";
    ((Control) this.uddDriverStatus).Visible = false;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.Location = new Point(9, 329);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(73, 17);
    this.lnkSelectAll.TabIndex = 5;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.Location = new Point(9, 355);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(73, 17);
    this.lnkDeSelectAll.TabIndex = 6;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(906, 381);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.uddDriverStatus);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.lnkResetSearch);
    this.Controls.Add((Control) this.ugDrivers);
    this.Controls.Add((Control) this.txtLastName);
    this.Controls.Add((Control) label4);
    this.Controls.Add((Control) this.txtFirstName);
    this.Controls.Add((Control) label3);
    this.Controls.Add((Control) this.txtAddress);
    this.Controls.Add((Control) label2);
    this.Controls.Add((Control) this.btnCopy);
    this.Controls.Add((Control) label1);
    this.Controls.Add((Control) this.numControlNo);
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (FormCopyDriversFromAnotherQuote);
    this.Text = "Search & Copy Drivers";
    ((ISupportInitialize) this.numControlNo).EndInit();
    ((ISupportInitialize) this.txtAddress).EndInit();
    ((ISupportInitialize) this.txtFirstName).EndInit();
    ((ISupportInitialize) this.txtLastName).EndInit();
    ((ISupportInitialize) this.ugDrivers).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.uddDriverStatus).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("numControlNo")]
  private virtual MGANumericEditor numControlNo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual Button btnCopy
  {
    get => this._btnCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCopy_Click);
      Button btnCopy1 = this._btnCopy;
      if (btnCopy1 != null)
        btnCopy1.Click -= eventHandler;
      this._btnCopy = value;
      Button btnCopy2 = this._btnCopy;
      if (btnCopy2 == null)
        return;
      btnCopy2.Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("txtAddress")]
  protected virtual MGATextBox txtAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtFirstName")]
  protected virtual MGATextBox txtFirstName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtLastName")]
  protected virtual MGATextBox txtLastName { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ugDrivers")]
  protected virtual UltraGrid ugDrivers { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsDriverInfo ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkResetSearch
  {
    get => this._lnkResetSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkResetSearch_LinkClicked);
      LinkLabel lnkResetSearch1 = this._lnkResetSearch;
      if (lnkResetSearch1 != null)
        lnkResetSearch1.LinkClicked -= clickedEventHandler;
      this._lnkResetSearch = value;
      LinkLabel lnkResetSearch2 = this._lnkResetSearch;
      if (lnkResetSearch2 == null)
        return;
      lnkResetSearch2.LinkClicked += clickedEventHandler;
    }
  }

  protected internal virtual MGAButton btnSearch
  {
    get => this._btnSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
      MGAButton btnSearch1 = this._btnSearch;
      if (btnSearch1 != null)
        ((Control) btnSearch1).Click -= eventHandler;
      this._btnSearch = value;
      MGAButton btnSearch2 = this._btnSearch;
      if (btnSearch2 == null)
        return;
      ((Control) btnSearch2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("uddDriverStatus")]
  private virtual UltraDropDown uddDriverStatus { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected internal virtual LinkLabel lnkSelectAll
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

  protected internal virtual LinkLabel lnkDeSelectAll
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

  public FormCopyDriversFromAnotherQuote()
  {
    this.Load += new EventHandler(this.FormCopyDriversFromAnotherQuote_Load);
    this._selectCopy = false;
    this._DriverNumbers = string.Empty;
    this.InitializeComponent();
  }

  public FormCopyDriversFromAnotherQuote(int controlNo)
  {
    this.Load += new EventHandler(this.FormCopyDriversFromAnotherQuote_Load);
    this._selectCopy = false;
    this._DriverNumbers = string.Empty;
    this.InitializeComponent();
    this._controlNo = controlNo;
  }

  public bool SelectCopy => this._selectCopy;

  public string DriversNumbers => this._DriverNumbers;

  private void btnCopy_Click(object sender, EventArgs e)
  {
    this._selectCopy = true;
    this._DriverNumbers = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugDrivers).Rows)
    {
      if (Conversions.ToBoolean(row.Cells["Copy"].Value))
        this._DriverNumbers = $"{this._DriverNumbers}{row.Cells["DriverID"].Value.ToString()},";
    }
    this.Close();
  }

  private void FormCopyDriversFromAnotherQuote_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    this._selectCopy = false;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstDriverStatus"
    }, CommandType.Text, "SELECT DriverStatusID, Status FROM dbo.lstDriverStatus");
  }

  private bool ValidSearch()
  {
    bool flag1 = false;
    bool flag2 = false;
    bool flag3 = false;
    bool flag4 = false;
    if (this.numControlNo.Value == DBNull.Value | this.numControlNo.Value == null)
      flag1 = true;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtAddress).Text.Replace(" ", string.Empty)))
      flag2 = true;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtFirstName).Text.Replace(" ", string.Empty)))
      flag3 = true;
    if (string.IsNullOrEmpty(((TextEditorControlBase) this.txtLastName).Text.Replace(" ", string.Empty)))
      flag4 = true;
    bool flag5;
    if (flag1 && flag2 && flag3 && flag4)
    {
      int num = (int) MessageBox.Show("Please enter value for an item to begin search.", "Empty Search", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag5 = false;
    }
    else
      flag5 = true;
    return flag5;
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    this.ds.dtDriverInfo.Clear();
    if (!this.ValidSearch())
      return;
    object obj1 = (object) null;
    object obj2 = (object) null;
    object obj3 = (object) null;
    object obj4 = (object) null;
    if (this.numControlNo.Value != DBNull.Value && this.numControlNo.Value != null)
      obj1 = RuntimeHelpers.GetObjectValue(this.numControlNo.Value);
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtAddress).Text.Replace(" ", string.Empty)))
      obj2 = (object) ((TextEditorControlBase) this.txtAddress).Text;
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtFirstName).Text.Replace(" ", string.Empty)))
      obj3 = (object) ((TextEditorControlBase) this.txtFirstName).Text;
    if (!string.IsNullOrEmpty(((TextEditorControlBase) this.txtLastName).Text.Replace(" ", string.Empty)))
      obj4 = (object) ((TextEditorControlBase) this.txtLastName).Text;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "dtDriverInfo"
    }, "spSearchDrivers", new object[10]
    {
      (object) "@ControlNo",
      obj1,
      (object) "@Address",
      obj2,
      (object) "@FirstName",
      obj3,
      (object) "@LastName",
      obj4,
      (object) "@CurrentControlNo",
      (object) this._controlNo
    });
    foreach (UltraGridRow row in ((UltraGridBase) this.ugDrivers).Rows)
    {
      if (row.Cells["StatusID"].Value != DBNull.Value && Conversions.ToInteger(row.Cells["StatusID"].Value) != 1)
      {
        row.Appearance.FontData.Strikeout = (DefaultableBoolean) 1;
        row.Appearance.ForeColor = Color.Red;
      }
    }
  }

  private void lnkResetSearch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.numControlNo.Value = (object) DBNull.Value;
    ((TextEditorControlBase) this.txtFirstName).Text = string.Empty;
    ((TextEditorControlBase) this.txtLastName).Text = string.Empty;
    ((TextEditorControlBase) this.txtAddress).Text = string.Empty;
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridCopySelection(true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridCopySelection(false);
  }

  private void SetGridCopySelection(bool selectAll)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugDrivers).Rows)
      row.Cells["Copy"].Value = (object) selectAll;
  }
}
