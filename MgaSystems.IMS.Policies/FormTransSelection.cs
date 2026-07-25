// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Policies.FormTransSelection
// Assembly: MgaSystems.IMS.Policies, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 2FF2C709-F7BF-41DA-82BD-FF6319CA235D
// Assembly location: C:\Users\muthu\Downloads\MgaSystems.IMS.Policies.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Common.Settings;
using MGASystems.Data;
using MGASystems.IMS.Policies.PolicyBusinessObjects;
using MGASystems.IMS.Policies.PolicyDetail;
using MGASystems.IMS.Policies.PolicyNumbering;
using MGASystems.IMS.Security;
using MGASystems.Tools;
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
namespace MGASystems.IMS.Policies;

[DesignerGenerated]
[SecureResource("{C58E35DF-DB9E-4669-AA9F-833702AE2DC6}", "Parent Policy Number Update", "Allows users to update the assigned parent policy number.", "Policies")]
[SecureResource("{3C549EF5-1B21-4CE3-A702-AA9E81A287E7}", "Parent Policy Number Index Update", "Allows users to update the assigned parent policy number index.", "Policies")]
[SecureResource("{A0302C7F-E364-454D-9F84-6FD8F98425B4}", "Parent Policy Number Rule Update", "Allows users to update the assigned parent policy number rule.", "Policies")]
public class FormTransSelection : Form
{
  private IContainer components;
  private readonly Guid _quoteGuid;
  private readonly int _controlNo;
  private bool _makeSelection;
  private bool _canUpdateIndex;
  private bool _canUpdatePolicyNumber;
  private bool _canUpdatePolicyNumberRule;
  public const string CanUpdateParentPolicyNumber = "{C58E35DF-DB9E-4669-AA9F-833702AE2DC6}";
  public const string CanUpdateParentPolicyNumberIndex = "{3C549EF5-1B21-4CE3-A702-AA9E81A287E7}";
  public const string CanUpdateParentPolicyNumberRule = "{A0302C7F-E364-454D-9F84-6FD8F98425B4}";

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblPolicyNumberRules", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("RuleID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("RuleName");
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormTransSelection));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("dtTrans", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("TransactionNum", -1, (object) null, 0, (SortIndicator) 2, false);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("QuoteID");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("QuoteGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("DisplayStatus");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("PolicyNumber");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("PolicyNumberIndex");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("PolicyNumberRuleID", -1, (object) "ddPolicyNums");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("Go");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Notes");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CurrentPolicyNumber");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CurrentIndex");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("CurrentRule");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Manual");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("TableBasedPolicyNumber");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    this.btnSave = new MGAButton();
    this.btnGenerate = new Button();
    this.lblCurrentPolicyNumber = new Label();
    this.lblCurrentIndex = new Label();
    this.lblCurrentRule = new Label();
    this.txtCurrentPolicyNumber = new TextBox();
    this.txtCurrentIndex = new TextBox();
    this.txtCurrentRule = new TextBox();
    this.lnkDeSelect = new LinkLabel();
    this.ddPolicyNums = new UltraDropDown();
    this.ds = new dsChildPol();
    this.lnkSelectAll = new LinkLabel();
    this.txtNotes = new TextBox();
    this.btnIndexUpdate = new MGAButton();
    this.btnPolicyNumberUpdate = new MGAButton();
    this.btnRuleUpdate = new MGAButton();
    this.toolTipDisplay = new ToolTip(this.components);
    this.ugTrans = new FixedUltraGrid();
    this.linkDeSelectAllGenerate = new LinkLabel();
    this.linkSelectAllGenerate = new LinkLabel();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.ddPolicyNums).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnIndexUpdate).BeginInit();
    ((ISupportInitialize) this.btnPolicyNumberUpdate).BeginInit();
    ((ISupportInitialize) this.btnRuleUpdate).BeginInit();
    ((ISupportInitialize) this.ugTrans).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((Control) this.btnSave).Location = new Point(1195, 460);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 3;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    this.btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.btnGenerate.Location = new Point(965, 479);
    this.btnGenerate.Name = "btnGenerate";
    this.btnGenerate.Size = new Size(169, 23);
    this.btnGenerate.TabIndex = 204;
    this.btnGenerate.Text = "Generate Selected Policy #s";
    this.btnGenerate.UseVisualStyleBackColor = true;
    this.lblCurrentPolicyNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblCurrentPolicyNumber.AutoSize = true;
    this.lblCurrentPolicyNumber.Location = new Point(12, 437);
    this.lblCurrentPolicyNumber.Name = "lblCurrentPolicyNumber";
    this.lblCurrentPolicyNumber.Size = new Size(85, 13);
    this.lblCurrentPolicyNumber.TabIndex = 205;
    this.lblCurrentPolicyNumber.Text = "Current Policy #:";
    this.lblCurrentIndex.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblCurrentIndex.AutoSize = true;
    this.lblCurrentIndex.Location = new Point(12, 391);
    this.lblCurrentIndex.Name = "lblCurrentIndex";
    this.lblCurrentIndex.Size = new Size(73, 13);
    this.lblCurrentIndex.TabIndex = 206;
    this.lblCurrentIndex.Text = "Current Index:";
    this.lblCurrentRule.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lblCurrentRule.AutoSize = true;
    this.lblCurrentRule.Location = new Point(12, 483);
    this.lblCurrentRule.Name = "lblCurrentRule";
    this.lblCurrentRule.Size = new Size(69, 13);
    this.lblCurrentRule.TabIndex = 207;
    this.lblCurrentRule.Text = "Current Rule:";
    this.txtCurrentPolicyNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.txtCurrentPolicyNumber.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtCurrentPolicyNumber.Location = new Point(115, 433);
    this.txtCurrentPolicyNumber.Name = "txtCurrentPolicyNumber";
    this.txtCurrentPolicyNumber.ReadOnly = true;
    this.txtCurrentPolicyNumber.Size = new Size(170, 20);
    this.txtCurrentPolicyNumber.TabIndex = 208 /*0xD0*/;
    this.txtCurrentIndex.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.txtCurrentIndex.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtCurrentIndex.Location = new Point(115, 387);
    this.txtCurrentIndex.Name = "txtCurrentIndex";
    this.txtCurrentIndex.ReadOnly = true;
    this.txtCurrentIndex.Size = new Size(90, 20);
    this.txtCurrentIndex.TabIndex = 209;
    this.txtCurrentRule.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.txtCurrentRule.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtCurrentRule.Location = new Point(115, 479);
    this.txtCurrentRule.Name = "txtCurrentRule";
    this.txtCurrentRule.ReadOnly = true;
    this.txtCurrentRule.Size = new Size(170, 20);
    this.txtCurrentRule.TabIndex = 210;
    this.lnkDeSelect.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelect.AutoSize = true;
    this.lnkDeSelect.Location = new Point(303, 416);
    this.lnkDeSelect.Name = "lnkDeSelect";
    this.lnkDeSelect.Size = new Size(114, 13);
    this.lnkDeSelect.TabIndex = 212;
    this.lnkDeSelect.TabStop = true;
    this.lnkDeSelect.Text = "De-Select All For Save";
    ((UltraGridBase) this.ddPolicyNums).DataMember = "tblPolicyNumberRules";
    ((UltraGridBase) this.ddPolicyNums).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ddPolicyNums).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ultraGridBand1.ColHeadersVisible = false;
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
    ((UltraGridBase) this.ddPolicyNums).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ddPolicyNums).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.ddPolicyNums).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddPolicyNums).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.ddPolicyNums).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraDropDownBase) this.ddPolicyNums).DisplayMember = "RuleName";
    ((UltraDropDownBase) this.ddPolicyNums).DropDownWidth = 400;
    ((Control) this.ddPolicyNums).Location = new Point(350, (int) sbyte.MaxValue);
    ((Control) this.ddPolicyNums).Name = "ddPolicyNums";
    ((Control) this.ddPolicyNums).Size = new Size(203, 57);
    ((Control) this.ddPolicyNums).TabIndex = 203;
    ((UltraDropDownBase) this.ddPolicyNums).ValueMember = "RuleID";
    ((Control) this.ddPolicyNums).Visible = false;
    this.ds.DataSetName = "dsChildPol";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(303, 379);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(97, 13);
    this.lnkSelectAll.TabIndex = 211;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All For Save";
    this.txtNotes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.txtNotes.Font = new Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.txtNotes.Location = new Point(452, 379);
    this.txtNotes.Multiline = true;
    this.txtNotes.Name = "txtNotes";
    this.txtNotes.ReadOnly = true;
    this.txtNotes.Size = new Size(339, 121);
    this.txtNotes.TabIndex = 213;
    this.txtNotes.Text = componentResourceManager.GetString("txtNotes.Text");
    ((Control) this.btnIndexUpdate).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance3.BackColor = Color.Gainsboro;
    appearance3.BackColor2 = Color.White;
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnIndexUpdate).Appearance = (AppearanceBase) appearance3;
    ((Control) this.btnIndexUpdate).Font = new Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnIndexUpdate).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnIndexUpdate).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnIndexUpdate).Location = new Point(812, 475);
    ((Control) this.btnIndexUpdate).Name = "btnIndexUpdate";
    ((ControlBase) this.btnIndexUpdate).Padding = new Size(5, 0);
    ((Control) this.btnIndexUpdate).Size = new Size(96 /*0x60*/, 29);
    ((Control) this.btnIndexUpdate).TabIndex = 214;
    ((ControlBase) this.btnIndexUpdate).Text = "Index Update";
    this.toolTipDisplay.SetToolTip((Control) this.btnIndexUpdate, "Update the current 'Policy # Index' in the grid.");
    this.btnIndexUpdate.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnIndexUpdate).Visible = false;
    ((Control) this.btnPolicyNumberUpdate).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance4.BackColor = Color.Gainsboro;
    appearance4.BackColor2 = Color.White;
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnPolicyNumberUpdate).Appearance = (AppearanceBase) appearance4;
    ((Control) this.btnPolicyNumberUpdate).Font = new Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnPolicyNumberUpdate).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnPolicyNumberUpdate).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnPolicyNumberUpdate).Location = new Point(812, 425);
    ((Control) this.btnPolicyNumberUpdate).Name = "btnPolicyNumberUpdate";
    ((ControlBase) this.btnPolicyNumberUpdate).Padding = new Size(5, 0);
    ((Control) this.btnPolicyNumberUpdate).Size = new Size(96 /*0x60*/, 29);
    ((Control) this.btnPolicyNumberUpdate).TabIndex = 215;
    ((ControlBase) this.btnPolicyNumberUpdate).Text = "Pol # Update";
    this.toolTipDisplay.SetToolTip((Control) this.btnPolicyNumberUpdate, "Update the current 'Policy #' in the grid.");
    this.btnPolicyNumberUpdate.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnPolicyNumberUpdate).Visible = false;
    ((Control) this.btnRuleUpdate).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance5.BackColor = Color.Gainsboro;
    appearance5.BackColor2 = Color.White;
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.ImageHAlign = (HAlign) 3;
    ((ControlBase) this.btnRuleUpdate).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnRuleUpdate).Font = new Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnRuleUpdate).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnRuleUpdate).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnRuleUpdate).Location = new Point(812, 375);
    ((Control) this.btnRuleUpdate).Name = "btnRuleUpdate";
    ((ControlBase) this.btnRuleUpdate).Padding = new Size(5, 0);
    ((Control) this.btnRuleUpdate).Size = new Size(96 /*0x60*/, 29);
    ((Control) this.btnRuleUpdate).TabIndex = 216;
    ((ControlBase) this.btnRuleUpdate).Text = "Rule Update";
    this.toolTipDisplay.SetToolTip((Control) this.btnRuleUpdate, "Update the current 'Policy # Rule' in the grid.");
    this.btnRuleUpdate.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnRuleUpdate).Visible = false;
    ((Control) this.ugTrans).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugTrans).DataMember = "dtTrans";
    ((UltraGridBase) this.ugTrans).DataSource = (object) this.ds;
    appearance6.BackColor = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugTrans).DisplayLayout.Appearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ugTrans).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Trans #";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 73;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Quote ID";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Width = 145;
    ultraGridColumn5.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 2;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 244;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 3;
    ultraGridColumn6.Width = 159;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Policy #";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 5;
    ultraGridColumn7.Width = 177;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Policy # Index";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 6;
    ultraGridColumn8.Width = 119;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Policy # Rule";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn9.Style = (ColumnStyle) 6;
    ultraGridColumn9.Width = 293;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Select";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 9;
    ultraGridColumn10.Width = 65;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 8;
    ultraGridColumn11.Width = 107;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 10;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 123;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 11;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 92;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 12;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 99;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 7;
    ultraGridColumn15.Width = 64 /*0x40*/;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 13;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 140;
    ultraGridBand2.Columns.AddRange(new object[14]
    {
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
      (object) ultraGridColumn16
    });
    ((UltraGridBase) this.ugTrans).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ugTrans).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance7.BackColor = Color.LightSteelBlue;
    appearance7.FontData.SizeInPoints = 10f;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.ugTrans).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    appearance9.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance11.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance11;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.RowSelectorStyle = (HeaderStyle) 1;
    appearance13.BackColor = Color.Transparent;
    appearance13.ForeColor = Color.Black;
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.SelectedCellAppearance = (AppearanceBase) appearance13;
    appearance14.BackColor = Color.Transparent;
    appearance14.ForeColor = Color.MistyRose;
    ((UltraGridBase) this.ugTrans).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance14;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugTrans).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ugTrans).Location = new Point(12, 12);
    ((Control) this.ugTrans).Name = "ugTrans";
    ((Control) this.ugTrans).Size = new Size(1223, 358);
    ((Control) this.ugTrans).TabIndex = 2;
    ((UltraControlBase) this.ugTrans).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugTrans).UseOsThemes = (DefaultableBoolean) 2;
    this.linkDeSelectAllGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkDeSelectAllGenerate.AutoSize = true;
    this.linkDeSelectAllGenerate.Location = new Point(303, 490);
    this.linkDeSelectAllGenerate.Name = "linkDeSelectAllGenerate";
    this.linkDeSelectAllGenerate.Size = new Size(131, 13);
    this.linkDeSelectAllGenerate.TabIndex = 218;
    this.linkDeSelectAllGenerate.TabStop = true;
    this.linkDeSelectAllGenerate.Text = "De-Select All To Generate";
    this.linkSelectAllGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.linkSelectAllGenerate.AutoSize = true;
    this.linkSelectAllGenerate.Location = new Point(303, 453);
    this.linkSelectAllGenerate.Name = "linkSelectAllGenerate";
    this.linkSelectAllGenerate.Size = new Size(114, 13);
    this.linkSelectAllGenerate.TabIndex = 217;
    this.linkSelectAllGenerate.TabStop = true;
    this.linkSelectAllGenerate.Text = "Select All To Generate";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1247, 512 /*0x0200*/);
    this.Controls.Add((Control) this.linkDeSelectAllGenerate);
    this.Controls.Add((Control) this.linkSelectAllGenerate);
    this.Controls.Add((Control) this.btnRuleUpdate);
    this.Controls.Add((Control) this.btnPolicyNumberUpdate);
    this.Controls.Add((Control) this.btnIndexUpdate);
    this.Controls.Add((Control) this.txtNotes);
    this.Controls.Add((Control) this.lnkDeSelect);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.txtCurrentRule);
    this.Controls.Add((Control) this.txtCurrentIndex);
    this.Controls.Add((Control) this.txtCurrentPolicyNumber);
    this.Controls.Add((Control) this.lblCurrentRule);
    this.Controls.Add((Control) this.lblCurrentIndex);
    this.Controls.Add((Control) this.lblCurrentPolicyNumber);
    this.Controls.Add((Control) this.btnGenerate);
    this.Controls.Add((Control) this.ddPolicyNums);
    this.Controls.Add((Control) this.btnSave);
    this.Controls.Add((Control) this.ugTrans);
    this.Name = nameof (FormTransSelection);
    this.Text = "Policy # Admin - Transaction Selection for Control #";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.ddPolicyNums).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnIndexUpdate).EndInit();
    ((ISupportInitialize) this.btnPolicyNumberUpdate).EndInit();
    ((ISupportInitialize) this.btnRuleUpdate).EndInit();
    ((ISupportInitialize) this.ugTrans).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  protected virtual MGAButton btnSave
  {
    get => this._btnSave;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnbtnSave_Click);
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

  [field: AccessedThroughProperty("ds")]
  private virtual dsChildPol ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual FixedUltraGrid ugTrans
  {
    get => this._ugTrans;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ugTrans_AfterRowActivate);
      FixedUltraGrid ugTrans1 = this._ugTrans;
      if (ugTrans1 != null)
        ugTrans1.AfterRowActivate -= eventHandler;
      this._ugTrans = value;
      FixedUltraGrid ugTrans2 = this._ugTrans;
      if (ugTrans2 == null)
        return;
      ugTrans2.AfterRowActivate += eventHandler;
    }
  }

  [field: AccessedThroughProperty("ddPolicyNums")]
  private virtual UltraDropDown ddPolicyNums { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual MGAButton btnIndexUpdate
  {
    get => this._btnIndexUpdate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnIndexUpdate_Click);
      MGAButton btnIndexUpdate1 = this._btnIndexUpdate;
      if (btnIndexUpdate1 != null)
        ((Control) btnIndexUpdate1).Click -= eventHandler;
      this._btnIndexUpdate = value;
      MGAButton btnIndexUpdate2 = this._btnIndexUpdate;
      if (btnIndexUpdate2 == null)
        return;
      ((Control) btnIndexUpdate2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnPolicyNumberUpdate
  {
    get => this._btnPolicyNumberUpdate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnPolicyNumberUpdate_Click);
      MGAButton policyNumberUpdate1 = this._btnPolicyNumberUpdate;
      if (policyNumberUpdate1 != null)
        ((Control) policyNumberUpdate1).Click -= eventHandler;
      this._btnPolicyNumberUpdate = value;
      MGAButton policyNumberUpdate2 = this._btnPolicyNumberUpdate;
      if (policyNumberUpdate2 == null)
        return;
      ((Control) policyNumberUpdate2).Click += eventHandler;
    }
  }

  protected virtual MGAButton btnRuleUpdate
  {
    get => this._btnRuleUpdate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRuleUpdate_Click);
      MGAButton btnRuleUpdate1 = this._btnRuleUpdate;
      if (btnRuleUpdate1 != null)
        ((Control) btnRuleUpdate1).Click -= eventHandler;
      this._btnRuleUpdate = value;
      MGAButton btnRuleUpdate2 = this._btnRuleUpdate;
      if (btnRuleUpdate2 == null)
        return;
      ((Control) btnRuleUpdate2).Click += eventHandler;
    }
  }

  [field: AccessedThroughProperty("toolTipDisplay")]
  internal virtual ToolTip toolTipDisplay { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual Button btnGenerate
  {
    get => this._btnGenerate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnGenerate_Click);
      Button btnGenerate1 = this._btnGenerate;
      if (btnGenerate1 != null)
        btnGenerate1.Click -= eventHandler;
      this._btnGenerate = value;
      Button btnGenerate2 = this._btnGenerate;
      if (btnGenerate2 == null)
        return;
      btnGenerate2.Click += eventHandler;
    }
  }

  protected virtual LinkLabel lnkDeSelect
  {
    get => this._lnkDeSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelect_LinkClicked);
      LinkLabel lnkDeSelect1 = this._lnkDeSelect;
      if (lnkDeSelect1 != null)
        lnkDeSelect1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelect = value;
      LinkLabel lnkDeSelect2 = this._lnkDeSelect;
      if (lnkDeSelect2 == null)
        return;
      lnkDeSelect2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel lnkSelectAll
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

  [field: AccessedThroughProperty("txtNotes")]
  protected virtual TextBox txtNotes { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  protected virtual LinkLabel linkDeSelectAllGenerate
  {
    get => this._linkDeSelectAllGenerate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkDeSelectAllGenerate_LinkClicked);
      LinkLabel selectAllGenerate1 = this._linkDeSelectAllGenerate;
      if (selectAllGenerate1 != null)
        selectAllGenerate1.LinkClicked -= clickedEventHandler;
      this._linkDeSelectAllGenerate = value;
      LinkLabel selectAllGenerate2 = this._linkDeSelectAllGenerate;
      if (selectAllGenerate2 == null)
        return;
      selectAllGenerate2.LinkClicked += clickedEventHandler;
    }
  }

  protected virtual LinkLabel linkSelectAllGenerate
  {
    get => this._linkSelectAllGenerate;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.linkSelectAllGenerate_LinkClicked);
      LinkLabel selectAllGenerate1 = this._linkSelectAllGenerate;
      if (selectAllGenerate1 != null)
        selectAllGenerate1.LinkClicked -= clickedEventHandler;
      this._linkSelectAllGenerate = value;
      LinkLabel selectAllGenerate2 = this._linkSelectAllGenerate;
      if (selectAllGenerate2 == null)
        return;
      selectAllGenerate2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblCurrentPolicyNumber")]
  protected virtual Label lblCurrentPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCurrentIndex")]
  protected virtual Label lblCurrentIndex { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCurrentRule")]
  protected virtual Label lblCurrentRule { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCurrentIndex")]
  protected virtual TextBox txtCurrentIndex { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCurrentPolicyNumber")]
  protected virtual TextBox txtCurrentPolicyNumber { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtCurrentRule")]
  protected virtual TextBox txtCurrentRule { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public Guid GetQuoteGuid
  {
    get => (Guid) ((UltraGridBase) this.ugTrans).ActiveRow.Cells["QuoteGuid"].Value;
  }

  public int GetQuoteId => (int) ((UltraGridBase) this.ugTrans).ActiveRow.Cells["QuoteID"].Value;

  public int GetPolicyNumberIndex
  {
    get => (int) ((UltraGridBase) this.ugTrans).ActiveRow.Cells["PolicyNumberIndex"].Value;
  }

  public int GetPolicyNumberRuleId
  {
    get => (int) ((UltraGridBase) this.ugTrans).ActiveRow.Cells["PolicyNumberRuleID"].Value;
  }

  public string GetPolicyNumber
  {
    get => ((UltraGridBase) this.ugTrans).ActiveRow.Cells["PolicyNumber"].Value.ToString();
  }

  public Guid SelectedQuoteGuid
  {
    get
    {
      return this._makeSelection ? (((UltraGridBase) this.ugTrans).ActiveRow != null ? (Guid) ((UltraGridBase) this.ugTrans).ActiveRow.Cells["QuoteGuid"].Value : Guid.Empty) : Guid.Empty;
    }
  }

  public FormTransSelection(Guid quoteGuid)
  {
    this.Load += new EventHandler(this.FormTransSelection_Load);
    this.FormClosing += new FormClosingEventHandler(this.FormTransSelection_FormClosing);
    this._makeSelection = false;
    this.InitializeComponent();
    this._quoteGuid = quoteGuid;
    this._controlNo = new Quote(this._quoteGuid).ControlNo;
  }

  private void FormTransSelection_Load(object sender, EventArgs e)
  {
    this._makeSelection = false;
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
    {
      "dtTrans",
      "tblPolicyNumberRules"
    }, CommandType.Text, "SELECT QuoteID, QuoteGuid, DisplayStatus, PolicyNumber, PolicyNumberIndex, PolicyNumberRuleID FROM tblQuotes WITH (NOLOCK) WHERE ControlNo = @CN ORDER BY QuoteID;SELECT RuleID, RuleName FROM tblPolicyNumberRules WITH (NOLOCK) ORDER BY RuleName", new object[2]
    {
      (object) "@CN",
      (object) this._controlNo
    });
    MGAButton btnSave = this.btnSave;
    ((ControlBase) btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) btnSave).Appearance.ImageHAlign = (HAlign) 2;
    ((ControlBase) btnSave).Appearance.ImageVAlign = (VAlign) 2;
    ((ControlBase) btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) btnSave).ImageTransparentColor = Color.Magenta;
    try
    {
      foreach (dsChildPol.dtTransRow row1 in this.ds.dtTrans.Rows)
      {
        DataRow row2 = DefaultDatabase.ExecuteDataRow(CommandType.Text, "SELECT PolicyNumber, PolicyNumberIndex, PolicyNumberRuleID FROM tblQuotes WITH (NOLOCK) WHERE QuoteGuid = @quoteGuid", new object[2]
        {
          (object) "@quoteGuid",
          (object) row1.QuoteGuid
        });
        row1.SetCurrentIndexNull();
        row1.SetCurrentRuleNull();
        row1.SetCurrentPolicyNumberNull();
        if (row2 != null)
        {
          if (!row2.IsNull("PolicyNumber"))
            row1.CurrentPolicyNumber = row2.Field<string>("PolicyNumber");
          if (!row2.IsNull("PolicyNumberIndex"))
            row1.CurrentIndex = row2.Field<int>("PolicyNumberIndex");
          if (!row2.IsNull("PolicyNumberRuleID"))
          {
            object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT RuleName FROM tblPolicyNumberRules WITH (NOLOCK) WHERE RuleID = @ID", new object[2]
            {
              (object) "@ID",
              (object) (int) row2.Field<short>("PolicyNumberRuleID")
            }));
            if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)))
              row1.CurrentRule = objectValue.ToString();
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
    this.ds.dtTrans.AcceptChanges();
    this._canUpdateIndex = SecurityManager.Instance.AssertPermission("{3C549EF5-1B21-4CE3-A702-AA9E81A287E7}");
    this._canUpdatePolicyNumber = SecurityManager.Instance.AssertPermission("{C58E35DF-DB9E-4669-AA9F-833702AE2DC6}");
    this._canUpdatePolicyNumberRule = SecurityManager.Instance.AssertPermission("{A0302C7F-E364-454D-9F84-6FD8F98425B4}");
    if (!SystemSettings.GetSetting<bool>("PolicyNumbering.Parent.AllowUpdate", false))
      return;
    ((Control) this.btnIndexUpdate).Visible = true;
    ((Control) this.btnRuleUpdate).Visible = true;
    ((Control) this.btnPolicyNumberUpdate).Visible = true;
  }

  private void btnbtnSave_Click(object sender, EventArgs e)
  {
    if (!this.IsValid() || DialogResult.Yes != MessageBox.Show($"You are about to update policy #(s).{Environment.NewLine}{Environment.NewLine}Continue?", "Update Policy (#)s)", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    this.ds.AcceptChanges();
    try
    {
      foreach (dsChildPol.dtTransRow row in this.ds.dtTrans.Rows)
      {
        if (row.Go)
        {
          if (row.Manual)
          {
            DefaultDatabase.ExecuteNonQuery("AssignPolicyNumber", new object[8]
            {
              (object) "@quoteGuid",
              (object) row.QuoteGuid,
              (object) "@polNumRuleID",
              null,
              (object) "@PolicyNumber",
              (object) row.PolicyNumber,
              (object) "@PolicyNumberIndex",
              null
            });
            this.LogPolicyNumberChange(row);
          }
          else
          {
            object obj1 = (object) null;
            object obj2 = (object) null;
            if (!row.IsPolicyNumberRuleIDNull())
              obj1 = (object) row.PolicyNumberRuleID;
            if (!row.IsPolicyNumberIndexNull())
              obj2 = (object) row.PolicyNumberIndex;
            DefaultDatabase.ExecuteNonQuery("AssignPolicyNumber", new object[8]
            {
              (object) "@quoteGuid",
              (object) row.QuoteGuid,
              (object) "@polNumRuleID",
              obj1,
              (object) "@PolicyNumber",
              (object) row.PolicyNumber,
              (object) "@PolicyNumberIndex",
              obj2
            });
            if (!row.IsTableBasedPolicyNumberNull())
              DefaultDatabase.ExecuteNonQuery("spPolicyNumberingSetTablePolicyNumberToUsed", new object[8]
              {
                (object) "@QuoteGuid",
                (object) row.QuoteGuid,
                (object) "@PolicyNumberRuleId",
                obj1,
                (object) "@ActualPolicyNumber",
                (object) row.PolicyNumber,
                (object) "@TableBasedPolicyNumber",
                (object) row.TableBasedPolicyNumber
              });
            this.LogPolicyNumberChange(row);
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

  private void LogPolicyNumberChange(dsChildPol.dtTransRow row)
  {
    string str1 = "Modified parent policy #. Changed policy # from";
    string str2 = "<empty>";
    if (!row.IsCurrentPolicyNumberNull())
      str2 = row.CurrentPolicyNumber;
    CurrentUser.Instance.LogAction(str1 + $" '{str2}' to '{row.PolicyNumber}' on QuoteID {row.QuoteID}.", row.QuoteGuid);
  }

  private void btnGenerate_Click(object sender, EventArgs e)
  {
    try
    {
      this.Cursor = MgaCursors.Working;
      try
      {
        foreach (dsChildPol.dtTransRow row in this.ds.dtTrans.Rows)
        {
          if (row.Go)
          {
            bool flag = true;
            Quote q = new Quote(row.QuoteGuid);
            try
            {
              if (q.IsManualPolicyNumberEntry())
              {
                flag = false;
                row.Manual = true;
                row.Notes = "Set for Manual Entry";
              }
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              Exception exception = ex;
              flag = false;
              string empty = string.Empty;
              string str = exception.Message.Length <= 100 ? exception.Message : exception.Message.Substring(0, 99);
              row.Notes = str;
              ProjectData.ClearProjectError();
            }
            PolicyInfo policyInfo = (PolicyInfo) null;
            if (flag)
            {
              try
              {
                policyInfo = Quote.GetNextPolicy(this._quoteGuid, Guid.Empty);
              }
              catch (Exception ex)
              {
                ProjectData.SetProjectError(ex);
                Exception exception = ex;
                flag = false;
                string empty = string.Empty;
                string str = exception.Message.Length <= 100 ? exception.Message : exception.Message.Substring(0, 99);
                row.Notes = str;
                ProjectData.ClearProjectError();
              }
            }
            if (policyInfo == null)
            {
              row.Notes = "No Policy # Generated";
              flag = false;
            }
            if (flag)
            {
              if (string.IsNullOrEmpty(policyInfo.PolicyNumber))
              {
                row.Notes = "Empty Policy # Generated";
                flag = false;
              }
              else
              {
                row.PolicyNumber = policyInfo.PolicyNumber;
                row.PolicyNumberRuleID = policyInfo.PolicyNumberRuleID;
                row.PolicyNumberIndex = policyInfo.PolicyIndex;
                if (!string.IsNullOrEmpty(policyInfo.TableBasedPolicyNumber))
                  row.TableBasedPolicyNumber = policyInfo.TableBasedPolicyNumber;
                else
                  row.SetTableBasedPolicyNumberNull();
              }
            }
            if (flag && q.IsOriginalQuoteRecord && q.CompanyLine.EnforceUniquePolicyNumbers && policyInfo != null && !string.IsNullOrEmpty(policyInfo.PolicyNumber) && !frmChangePolicyNumber.DuplicatePolicyNumberCheck(q, policyInfo.PolicyNumber))
            {
              row.Notes = $"Policy # {policyInfo.PolicyNumber} is already in use";
              flag = false;
            }
            if (row.IsPolicyNumberIndexNull() && row.IsPolicyNumberNull() && row.IsPolicyNumberRuleIDNull())
            {
              row.Notes = "Policy #, index and rule are all empty.";
              flag = false;
            }
            if (!flag)
            {
              row.Go = false;
            }
            else
            {
              row.Go = true;
              row.Manual = false;
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
      this.ds.AcceptChanges();
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void ugTrans_AfterRowActivate(object sender, EventArgs e)
  {
    this.txtCurrentPolicyNumber.Text = string.Empty;
    this.txtCurrentRule.Text = string.Empty;
    this.txtCurrentIndex.Text = string.Empty;
    if (((UltraGridBase) this.ugTrans).ActiveRow == null)
      return;
    UltraGridRow activeRow = ((UltraGridBase) this.ugTrans).ActiveRow;
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(activeRow.Cells["CurrentPolicyNumber"].Value)))
      this.txtCurrentPolicyNumber.Text = activeRow.Cells["CurrentPolicyNumber"].Value.ToString();
    if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(activeRow.Cells["CurrentIndex"].Value)))
      this.txtCurrentIndex.Text = activeRow.Cells["CurrentIndex"].Value.ToString();
    if (Utility.IsNull(RuntimeHelpers.GetObjectValue(activeRow.Cells["CurrentRule"].Value)))
      return;
    this.txtCurrentRule.Text = activeRow.Cells["CurrentRule"].Value.ToString();
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetAll(true);
  }

  private void lnkDeSelect_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetAll(false);
  }

  private void SetAll(bool boolValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugTrans).Rows)
      row.Cells["Go"].Value = (object) boolValue;
    ((UltraGridBase) this.ugTrans).UpdateData();
  }

  private bool IsValid()
  {
    bool flag;
    if (((IEnumerable<DataRow>) this.ds.dtTrans.Select("Go=1")).AsEnumerable<DataRow>().FirstOrDefault<DataRow>() == null)
    {
      int num = (int) MessageBox.Show("Cannot continue - Please select a row to save.", "Cannot Continue", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
    {
      try
      {
        foreach (dsChildPol.dtTransRow row in this.ds.dtTrans.Rows)
        {
          if (row.IsPolicyNumberNull())
          {
            int num = (int) MessageBox.Show($"Cannot continue.  QuoteID- {row.QuoteID}.{Environment.NewLine}{Environment.NewLine}Policy # is empty.", "Cannot Continue", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_14;
          }
          if (row.IsPolicyNumberIndexNull() && row.IsPolicyNumberNull() && row.IsPolicyNumberRuleIDNull())
          {
            int num = (int) MessageBox.Show($"Cannot continue.  QuoteID- {row.QuoteID}.{Environment.NewLine}{Environment.NewLine}Policy #, index and rule are all empty.", "Cannot Continue", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_14;
          }
          if (row.Go && !row.IsManualNull() && row.Manual && (!row.IsPolicyNumberIndexNull() || !row.IsPolicyNumberRuleIDNull()))
          {
            int num = (int) MessageBox.Show($"Cannot continue.  QuoteID - {row.QuoteID}.{Environment.NewLine}{Environment.NewLine}Manual entry is selected and index and/or rule filled in.", "Cannot Continue", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            flag = false;
            goto label_14;
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
    }
label_14:
    return flag;
  }

  private void FormTransSelection_FormClosing(object sender, FormClosingEventArgs e)
  {
    Form[] mdiChildren = MDIControls.Instance.MDIParent.MdiChildren;
    int index = 0;
    while (index < mdiChildren.Length)
    {
      if (mdiChildren[index] is frmPolicyDetail frmPolicyDetail && frmPolicyDetail.ControlNumber.Equals(this._controlNo))
      {
        frmPolicyDetail.RefreshPolicyData();
        break;
      }
      checked { ++index; }
    }
  }

  private void btnPolicyNumberUpdate_Click(object sender, EventArgs e)
  {
    if (!this.IsValidGridSelection() || !this.ValidPolicyNumber())
      return;
    this.SaveAndLogPolicyNumberUpdate(this.GetQuoteGuid);
  }

  private void btnRuleUpdate_Click(object sender, EventArgs e)
  {
    if (!this.IsValidGridSelection() || !this.ValidPolicyNumberRule())
      return;
    this.SaveAndLogPolicyNumberRuleUpdate(this.GetQuoteGuid);
  }

  private void btnIndexUpdate_Click(object sender, EventArgs e)
  {
    if (!this.IsValidGridSelection() || !this.ValidPolicyNumberIndex())
      return;
    this.SaveAndLogPolicyNumberIndexUpdate(this.GetQuoteGuid);
  }

  private bool IsValidGridSelection()
  {
    bool flag;
    if (((UltraGridBase) this.ugTrans).ActiveRow == null)
    {
      int num = (int) MessageBox.Show($"An active row is not selected.{Environment.NewLine}{Environment.NewLine}Please select a row in the grid to continue.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private string PolicyNumberEntityStringValue(
    FormTransSelection.PolicyNumberColumnName columnName)
  {
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugTrans).ActiveRow.Cells[columnName.ToString()].Value)) ? string.Empty : ((UltraGridBase) this.ugTrans).ActiveRow.Cells[columnName.ToString()].Value.ToString();
  }

  private bool IsPolicyNumberEntityNull(
    FormTransSelection.PolicyNumberColumnName columnName)
  {
    return Utility.IsNull(RuntimeHelpers.GetObjectValue(((UltraGridBase) this.ugTrans).ActiveRow.Cells[columnName.ToString()].Value));
  }

  protected virtual bool ValidPolicyNumberIndex()
  {
    bool flag;
    if (!this._canUpdateIndex)
    {
      int num = (int) MessageBox.Show("You do not have the required security to update policy number index.", "Insufficient Security - Parent Policy Number Index Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (this.IsPolicyNumberEntityNull(FormTransSelection.PolicyNumberColumnName.PolicyNumberIndex))
    {
      int num = (int) MessageBox.Show("Cannot assign null or nothing to policy number Index.", "Empty Policy Number Index", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (!int.TryParse(this.PolicyNumberEntityStringValue(FormTransSelection.PolicyNumberColumnName.PolicyNumberIndex), out int _))
    {
      int num = (int) MessageBox.Show("Policy number index is NOT an integer.", "Non-integer Policy Number Index", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  protected virtual bool ValidPolicyNumberRule()
  {
    bool flag;
    if (!this._canUpdatePolicyNumberRule)
    {
      int num = (int) MessageBox.Show("You do not have the required security to update policy number rule.", "Insufficient Security - Parent Policy Number Rule Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (this.IsPolicyNumberEntityNull(FormTransSelection.PolicyNumberColumnName.PolicyNumberRuleID))
    {
      int num = (int) MessageBox.Show("Cannot assign null or empty string to policy number rule.", "Empty Policy Number Rule", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (!int.TryParse(this.PolicyNumberEntityStringValue(FormTransSelection.PolicyNumberColumnName.PolicyNumberRuleID), out int _))
    {
      int num = (int) MessageBox.Show("Policy number rule is NOT an integer.", "Non-integer Policy Number Rule", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  protected virtual bool ValidPolicyNumber()
  {
    bool flag;
    if (!this._canUpdatePolicyNumber)
    {
      int num = (int) MessageBox.Show("You do not have the required security to update parent policy number.", "Insufficient Security - Parent Policy Number Update", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else if (this.IsPolicyNumberEntityNull(FormTransSelection.PolicyNumberColumnName.PolicyNumber))
    {
      int num = (int) MessageBox.Show("Cannot assign null or empty string to policy number.", "Empty Policy Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag = false;
    }
    else
      flag = true;
    return flag;
  }

  private void SaveAndLogPolicyNumberRuleUpdate(Guid quoteGuid)
  {
    if (DialogResult.Yes != MessageBox.Show("Do you wish to continue and update policy # rule?", "Continue And Update Index", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      dsChildPol.tblPolicyNumberRulesRow byRuleId = this.ds.tblPolicyNumberRules.FindByRuleID(this.GetPolicyNumberRuleId);
      DefaultDatabase.ExecuteNonQuery("dbo.UpdateParentPolicyNumberRule", new object[4]
      {
        (object) "@QuoteGuid",
        (object) quoteGuid,
        (object) "@PolicyNumberRuleID",
        (object) this.GetPolicyNumberRuleId
      });
      CurrentUser.Instance.LogAction($"Modified parent policy # rule. Assigned'{byRuleId.RuleName}' on QuoteID = {this.GetQuoteId}", quoteGuid);
      this.SavePolicyNumberRuleOnClient(quoteGuid, this.GetPolicyNumberRuleId);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void SaveAndLogPolicyNumberIndexUpdate(Guid quoteGuid)
  {
    if (DialogResult.Yes != MessageBox.Show("Do you wish to continue and update policy # index?", "Continue And Update Index", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteNonQuery("dbo.UpdateParentPolicyNumberIndex", new object[4]
      {
        (object) "@QuoteGuid",
        (object) quoteGuid,
        (object) "@PolicyNumberIndex",
        (object) this.GetPolicyNumberIndex
      });
      CurrentUser.Instance.LogAction($"Modified parent policy # index. Assigned {this.GetPolicyNumberIndex} on QuoteID = {this.GetQuoteId}", quoteGuid);
      this.SavePolicyNumberIndexRuleOnClient(quoteGuid, this.GetPolicyNumberIndex);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void SaveAndLogPolicyNumberUpdate(Guid quoteGuid)
  {
    if (DialogResult.Yes != MessageBox.Show("Do you wish to continue and update policy #?", "Continue And Update Policy Number", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DefaultDatabase.ExecuteNonQuery("dbo.UpdateParentPolicyNumber", new object[4]
      {
        (object) "@QuoteGuid",
        (object) quoteGuid,
        (object) "@PolicyNumber",
        (object) this.GetPolicyNumber
      });
      CurrentUser.Instance.LogAction($"Modified parent policy #. Assigned '{this.GetPolicyNumber}' on QuoteID = {this.GetQuoteId}", quoteGuid);
      this.SavePolicyNumberOnClient(quoteGuid, this.GetPolicyNumber);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  protected virtual void SavePolicyNumberRuleOnClient(Guid quoteGuid, int ruleId)
  {
  }

  protected virtual void SavePolicyNumberIndexRuleOnClient(Guid quoteGuid, int index)
  {
  }

  protected virtual void SavePolicyNumberOnClient(Guid quoteGuid, string policyNumber)
  {
  }

  private void SetGenerateSelection(bool boolValue)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugTrans).Rows)
      row.Cells["Go"].Value = (object) boolValue;
    ((UltraGridBase) this.ugTrans).UpdateData();
  }

  private void linkDeSelectAllGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGenerateSelection(false);
  }

  private void linkSelectAllGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGenerateSelection(true);
  }

  protected enum PolicyNumberColumnName
  {
    PolicyNumberRuleID,
    PolicyNumber,
    PolicyNumberIndex,
  }
}
