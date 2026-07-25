// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCopyCompanyLineRaterConditionals
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.BusinessObjects.Rating;
using MGASystems.Common;
using MGASystems.Common.ErrorHandling;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormCopyCompanyLineRaterConditionals : Form
{
  private IContainer components;
  private int _companyLineID;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblPolicyForms", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("FormID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("FormName");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
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
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblCompanyRaters", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("RatingTypeID");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("RatingType");
    Appearance appearance14 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCopyCompanyLineRaterConditionals));
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
    UltraGridBand ultraGridBand3 = new UltraGridBand("Operators", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("Operator");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Description");
    Appearance appearance26 = new Appearance();
    Appearance appearance27 = new Appearance();
    Appearance appearance28 = new Appearance();
    Appearance appearance29 = new Appearance();
    Appearance appearance30 = new Appearance();
    Appearance appearance31 = new Appearance();
    Appearance appearance32 = new Appearance();
    Appearance appearance33 = new Appearance();
    Appearance appearance34 = new Appearance();
    Appearance appearance35 = new Appearance();
    Appearance appearance36 = new Appearance();
    Appearance appearance37 = new Appearance();
    UltraGridBand ultraGridBand4 = new UltraGridBand("lstStates", -1);
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("StateID");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("Select");
    Appearance appearance38 = new Appearance();
    Appearance appearance39 = new Appearance();
    Appearance appearance40 = new Appearance();
    Appearance appearance41 = new Appearance();
    Appearance appearance42 = new Appearance();
    Appearance appearance43 = new Appearance();
    Appearance appearance44 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance45 = new Appearance();
    UltraGridBand ultraGridBand5 = new UltraGridBand("tblRaterFormSetups", -1);
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("SetupID");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("PolicyFormID", -1, (object) "ddPolicyForm");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("RaterID", -1, (object) "ddRaters");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("Condition");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ConditionalID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("Amount");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("Operator", -1, (object) "ddOperators");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("CompanyLineConditionID", -1, (object) "ddCondition");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("Select");
    Appearance appearance46 = new Appearance();
    Appearance appearance47 = new Appearance();
    Appearance appearance48 = new Appearance();
    Appearance appearance49 = new Appearance();
    Appearance appearance50 = new Appearance();
    Appearance appearance51 = new Appearance();
    Appearance appearance52 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance53 = new Appearance();
    UltraGridBand ultraGridBand6 = new UltraGridBand("tblConditions", -1);
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("ConditionID");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("Condition");
    Appearance appearance54 = new Appearance();
    Appearance appearance55 = new Appearance();
    Appearance appearance56 = new Appearance();
    Appearance appearance57 = new Appearance();
    Appearance appearance58 = new Appearance();
    Appearance appearance59 = new Appearance();
    Appearance appearance60 = new Appearance();
    Appearance appearance61 = new Appearance();
    Appearance appearance62 = new Appearance();
    Appearance appearance63 = new Appearance();
    this.ds = new dsCopyRaterCond();
    this.btnCopy = new MGAButton();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelectAll = new LinkLabel();
    this.lnkSelectAllStates = new LinkLabel();
    this.lnkDeSelectAllStates = new LinkLabel();
    this.ugStates = new UltraGrid();
    this.ugRaterconditionals = new UltraGrid();
    this.lblCL = new Label();
    UltraDropDown ultraDropDown1 = new UltraDropDown();
    UltraDropDown ultraDropDown2 = new UltraDropDown();
    UltraDropDown ultraDropDown3 = new UltraDropDown();
    UltraDropDown ultraDropDown4 = new UltraDropDown();
    ((ISupportInitialize) ultraDropDown1).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) ultraDropDown2).BeginInit();
    ((ISupportInitialize) ultraDropDown3).BeginInit();
    ((ISupportInitialize) this.btnCopy).BeginInit();
    ((ISupportInitialize) this.ugStates).BeginInit();
    ((ISupportInitialize) this.ugRaterconditionals).BeginInit();
    ((ISupportInitialize) ultraDropDown4).BeginInit();
    this.SuspendLayout();
    ((UltraGridBase) ultraDropDown1).DataMember = "tblPolicyForms";
    ((UltraGridBase) ultraDropDown1).DataSource = (object) this.ds;
    appearance1.BackColor = SystemColors.Window;
    appearance1.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) ultraDropDown1).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) ultraDropDown1).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance2.BackColor = SystemColors.ActiveBorder;
    appearance2.BackColor2 = SystemColors.ControlDark;
    appearance2.BackGradientStyle = (GradientStyle) 2;
    appearance2.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) ultraDropDown1).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance2;
    appearance3.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) ultraDropDown1).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance4.BackColor = SystemColors.ControlLightLight;
    appearance4.BackColor2 = SystemColors.Control;
    appearance4.BackGradientStyle = (GradientStyle) 3;
    appearance4.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.MaxRowScrollRegions = 1;
    appearance5.BackColor = SystemColors.Window;
    appearance5.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = SystemColors.Highlight;
    appearance6.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance7.BackColor = SystemColors.Window;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance7;
    appearance8.BorderColor = Color.Silver;
    appearance8.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.CellPadding = 0;
    appearance9.BackColor = SystemColors.Control;
    appearance9.BackColor2 = SystemColors.ControlDark;
    appearance9.BackGradientAlignment = (GradientAlignment) 1;
    appearance9.BackGradientStyle = (GradientStyle) 3;
    appearance9.BorderColor = SystemColors.Window;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance11.BackColor = SystemColors.Window;
    appearance11.BorderColor = Color.Silver;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance12.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) ultraDropDown1).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) ultraDropDown1).DisplayMember = "FormName";
    ((Control) ultraDropDown1).Location = new Point(175, 192 /*0xC0*/);
    ((UltraDropDownBase) ultraDropDown1).MaxDropDownItems = 1;
    ((Control) ultraDropDown1).Name = "ddPolicyForm";
    ((Control) ultraDropDown1).Size = new Size(103, 76);
    ((Control) ultraDropDown1).TabIndex = 50;
    ((Control) ultraDropDown1).Text = "UltraDropDown1";
    ((UltraDropDownBase) ultraDropDown1).ValueMember = "FormID";
    ((Control) ultraDropDown1).Visible = false;
    this.ds.DataSetName = "dsCopyRaterCond";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) ultraDropDown2).DataMember = "tblCompanyRaters";
    ((UltraGridBase) ultraDropDown2).DataSource = (object) this.ds;
    appearance13.BackColor = SystemColors.Window;
    appearance13.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Appearance = (AppearanceBase) appearance13;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) ultraDropDown2).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) ultraDropDown2).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance14.BackColor = SystemColors.ActiveBorder;
    appearance14.BackColor2 = SystemColors.ControlDark;
    appearance14.BackGradientStyle = (GradientStyle) 2;
    appearance14.BorderColor = SystemColors.Window;
    appearance14.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance33.Image"));
    appearance14.ImageHAlign = (HAlign) 1;
    appearance14.ImageVAlign = (VAlign) 2;
    ((SpecialBoxBase) ((UltraGridBase) ultraDropDown2).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance14;
    appearance15.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance15;
    ((SpecialBoxBase) ((UltraGridBase) ultraDropDown2).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance16.BackColor = SystemColors.ControlLightLight;
    appearance16.BackColor2 = SystemColors.Control;
    appearance16.BackGradientStyle = (GradientStyle) 3;
    appearance16.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.MaxRowScrollRegions = 1;
    appearance17.BackColor = SystemColors.Window;
    appearance17.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = SystemColors.Highlight;
    appearance18.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance18;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance19.BackColor = SystemColors.Window;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance19;
    appearance20.BorderColor = Color.Silver;
    appearance20.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance20;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.CellPadding = 0;
    appearance21.BackColor = SystemColors.Control;
    appearance21.BackColor2 = SystemColors.ControlDark;
    appearance21.BackGradientAlignment = (GradientAlignment) 1;
    appearance21.BackGradientStyle = (GradientStyle) 3;
    appearance21.BorderColor = SystemColors.Window;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).TextHAlignAsString = "Left";
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance23.BackColor = SystemColors.Window;
    appearance23.BorderColor = Color.Silver;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance23;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance24.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance24;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) ultraDropDown2).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) ultraDropDown2).DisplayMember = "RatingType";
    ((Control) ultraDropDown2).Location = new Point(284, 274);
    ((UltraDropDownBase) ultraDropDown2).MaxDropDownItems = 1;
    ((Control) ultraDropDown2).Name = "ddRaters";
    ((Control) ultraDropDown2).Size = new Size(103, 76);
    ((Control) ultraDropDown2).TabIndex = 49;
    ((Control) ultraDropDown2).Text = "UltraDropDown1";
    ((UltraDropDownBase) ultraDropDown2).ValueMember = "RatingTypeID";
    ((Control) ultraDropDown2).Visible = false;
    ((UltraGridBase) ultraDropDown3).DataMember = "Operators";
    ((UltraGridBase) ultraDropDown3).DataSource = (object) this.ds;
    appearance25.BackColor = SystemColors.Window;
    appearance25.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Appearance = (AppearanceBase) appearance25;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridBand3.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6
    });
    ((UltraGridBase) ultraDropDown3).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) ultraDropDown3).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance26.BackColor = SystemColors.ActiveBorder;
    appearance26.BackColor2 = SystemColors.ControlDark;
    appearance26.BackGradientStyle = (GradientStyle) 2;
    appearance26.BorderColor = SystemColors.Window;
    ((SpecialBoxBase) ((UltraGridBase) ultraDropDown3).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance26;
    appearance27.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance27;
    ((SpecialBoxBase) ((UltraGridBase) ultraDropDown3).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance28.BackColor = SystemColors.ControlLightLight;
    appearance28.BackColor2 = SystemColors.Control;
    appearance28.BackGradientStyle = (GradientStyle) 3;
    appearance28.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance28;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.MaxRowScrollRegions = 1;
    appearance29.BackColor = SystemColors.Window;
    appearance29.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance29;
    appearance30.BackColor = SystemColors.Highlight;
    appearance30.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance30;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance31.BackColor = SystemColors.Window;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance31;
    appearance32.BorderColor = Color.Silver;
    appearance32.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance32;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.CellPadding = 0;
    appearance33.BackColor = SystemColors.Control;
    appearance33.BackColor2 = SystemColors.ControlDark;
    appearance33.BackGradientAlignment = (GradientAlignment) 1;
    appearance33.BackGradientStyle = (GradientStyle) 3;
    appearance33.BorderColor = SystemColors.Window;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance33;
    ((AppearanceBase) appearance34).TextHAlignAsString = "Left";
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance34;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance35.BackColor = SystemColors.Window;
    appearance35.BorderColor = Color.Silver;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance35;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance36.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance36;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) ultraDropDown3).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) ultraDropDown3).DisplayMember = "Description";
    ((Control) ultraDropDown3).Location = new Point(153, 283);
    ((UltraDropDownBase) ultraDropDown3).MaxDropDownItems = 1;
    ((Control) ultraDropDown3).Name = "ddOperators";
    ((Control) ultraDropDown3).Size = new Size(103, 76);
    ((Control) ultraDropDown3).TabIndex = 219;
    ((Control) ultraDropDown3).Text = "UltraDropDown1";
    ((UltraDropDownBase) ultraDropDown3).ValueMember = "Operator";
    ((Control) ultraDropDown3).Visible = false;
    ((Control) this.btnCopy).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    ((ControlBase) this.btnCopy).Appearance = (AppearanceBase) appearance14;
    ((Control) this.btnCopy).Font = new Font("Tahoma", 10f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.btnCopy).Location = new Point(852, 576);
    ((Control) this.btnCopy).Name = "btnCopy";
    ((ControlBase) this.btnCopy).Padding = new Size(5, 0);
    ((Control) this.btnCopy).Size = new Size(97, 40);
    ((Control) this.btnCopy).TabIndex = 213;
    ((ControlBase) this.btnCopy).Text = "Copy";
    this.btnCopy.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.BackColor = Color.Transparent;
    this.lnkSelectAll.Location = new Point(12, 576);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(210, 13);
    this.lnkSelectAll.TabIndex = 214;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All Rater / Policy Forms Conditionals";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.BackColor = Color.Transparent;
    this.lnkDeSelectAll.Location = new Point(12, 603);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(227, 13);
    this.lnkDeSelectAll.TabIndex = 215;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All Rater / Policy Forms Conditionals";
    this.lnkSelectAllStates.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllStates.AutoSize = true;
    this.lnkSelectAllStates.BackColor = Color.Transparent;
    this.lnkSelectAllStates.Location = new Point(366, 576);
    this.lnkSelectAllStates.Name = "lnkSelectAllStates";
    this.lnkSelectAllStates.Size = new Size(84, 13);
    this.lnkSelectAllStates.TabIndex = 217;
    this.lnkSelectAllStates.TabStop = true;
    this.lnkSelectAllStates.Text = "Select All States";
    this.lnkDeSelectAllStates.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAllStates.AutoSize = true;
    this.lnkDeSelectAllStates.BackColor = Color.Transparent;
    this.lnkDeSelectAllStates.Location = new Point(366, 606);
    this.lnkDeSelectAllStates.Name = "lnkDeSelectAllStates";
    this.lnkDeSelectAllStates.Size = new Size(101, 13);
    this.lnkDeSelectAllStates.TabIndex = 218;
    this.lnkDeSelectAllStates.TabStop = true;
    this.lnkDeSelectAllStates.Text = "De-Select All States";
    ((Control) this.ugStates).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    ((UltraGridBase) this.ugStates).DataMember = "lstStates";
    ((UltraGridBase) this.ugStates).DataSource = (object) this.ds;
    appearance37.BackColor = Color.White;
    appearance37.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugStates).DisplayLayout.Appearance = (AppearanceBase) appearance37;
    ((UltraGridBase) this.ugStates).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn7.Header.VisiblePosition = 0;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 89;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn8.Header.VisiblePosition = 1;
    ultraGridColumn8.Width = 133;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn9.Header.VisiblePosition = 2;
    ultraGridColumn9.Width = 48 /*0x30*/;
    ultraGridBand4.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9
    });
    ultraGridBand4.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugStates).DisplayLayout.BandsSerializer.Add((object) ultraGridBand4);
    ((UltraGridBase) this.ugStates).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance38.BackColor = Color.LightSteelBlue;
    appearance38.FontData.SizeInPoints = 10f;
    appearance38.ForeColor = Color.Black;
    ((UltraGridBase) this.ugStates).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance38;
    appearance39.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance39.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance39.ForeColor = Color.Black;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance39;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance40.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance40;
    appearance41.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance41;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance42.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance42;
    appearance43.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance43;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance44.BackColor = Color.Transparent;
    appearance44.ForeColor = Color.Black;
    ((UltraGridBase) this.ugStates).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance44;
    scrollBarLook1.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugStates).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((UltraGridBase) this.ugStates).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugStates).Location = new Point(773, 45);
    ((Control) this.ugStates).Name = "ugStates";
    ((Control) this.ugStates).Size = new Size(183, 525);
    ((Control) this.ugStates).TabIndex = 216;
    ((Control) this.ugStates).Text = "Available States";
    ((UltraControlBase) this.ugStates).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugStates).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ugRaterconditionals).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ugRaterconditionals).DataMember = "tblRaterFormSetups";
    ((UltraGridBase) this.ugRaterconditionals).DataSource = (object) this.ds;
    appearance45.BackColor = Color.White;
    appearance45.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Appearance = (AppearanceBase) appearance45;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn10.Header.VisiblePosition = 0;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 57;
    ultraGridColumn11.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Policy Form";
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn11.Style = (ColumnStyle) 6;
    ultraGridColumn11.Width = 169;
    ultraGridColumn12.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Rater";
    ultraGridColumn12.Header.VisiblePosition = 3;
    ultraGridColumn12.Style = (ColumnStyle) 6;
    ultraGridColumn12.Width = 112 /*0x70*/;
    ultraGridColumn13.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ultraGridColumn13.Header.VisiblePosition = 4;
    ultraGridColumn13.Width = 97;
    ultraGridColumn14.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn14.Header.VisiblePosition = 5;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 85;
    ultraGridColumn15.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ultraGridColumn15.Header.VisiblePosition = 7;
    ultraGridColumn15.Width = 69;
    ultraGridColumn16.AutoCompleteMode = (AutoCompleteMode) 2;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ultraGridColumn16.Header.VisiblePosition = 6;
    ultraGridColumn16.Style = (ColumnStyle) 6;
    ultraGridColumn16.Width = 89;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Company / Line Conditions";
    ultraGridColumn17.Header.VisiblePosition = 2;
    ultraGridColumn17.Style = (ColumnStyle) 6;
    ultraGridColumn17.Width = 158;
    ultraGridColumn18.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "";
    ultraGridColumn18.Header.VisiblePosition = 8;
    ultraGridColumn18.Width = 36;
    ultraGridBand5.Columns.AddRange(new object[9]
    {
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
    ultraGridBand5.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.BandsSerializer.Add((object) ultraGridBand5);
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance46.BackColor = Color.LightSteelBlue;
    appearance46.FontData.SizeInPoints = 10f;
    appearance46.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance46;
    appearance47.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance47.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance47.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance47;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    appearance48.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance48;
    appearance49.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance49;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance50.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance50;
    appearance51.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance51;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance52.BackColor = Color.Transparent;
    appearance52.ForeColor = Color.Black;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance52;
    scrollBarLook2.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((UltraGridBase) this.ugRaterconditionals).DisplayLayout.ViewStyle = (ViewStyle) 0;
    ((Control) this.ugRaterconditionals).Location = new Point(35, 45);
    ((Control) this.ugRaterconditionals).Name = "ugRaterconditionals";
    ((Control) this.ugRaterconditionals).Size = new Size(732, 525);
    ((Control) this.ugRaterconditionals).TabIndex = 14;
    ((Control) this.ugRaterconditionals).Text = "Available Rater / Policy Forms / Conditionals";
    ((UltraControlBase) this.ugRaterconditionals).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ugRaterconditionals).UseOsThemes = (DefaultableBoolean) 2;
    this.lblCL.AutoSize = true;
    this.lblCL.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lblCL.Location = new Point(12, 18);
    this.lblCL.Name = "lblCL";
    this.lblCL.Size = new Size(217, 13);
    this.lblCL.TabIndex = 220;
    this.lblCL.Text = "Currently working with Company/Line";
    ((UltraGridBase) ultraDropDown4).DataMember = "tblConditions";
    ((UltraGridBase) ultraDropDown4).DataSource = (object) this.ds;
    appearance53.BackColor = SystemColors.Window;
    appearance53.BorderColor = SystemColors.InactiveCaption;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Appearance = (AppearanceBase) appearance53;
    ultraGridColumn19.Header.VisiblePosition = 0;
    ultraGridColumn20.Header.VisiblePosition = 1;
    ultraGridBand6.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ((UltraGridBase) ultraDropDown4).DisplayLayout.BandsSerializer.Add((object) ultraGridBand6);
    ((UltraGridBase) ultraDropDown4).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.CaptionVisible = (DefaultableBoolean) 2;
    appearance13.BackColor = SystemColors.ActiveBorder;
    appearance13.BackColor2 = SystemColors.ControlDark;
    appearance13.BackGradientStyle = (GradientStyle) 2;
    appearance13.BorderColor = SystemColors.Window;
    appearance13.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("appearance22.Image"));
    appearance13.ImageHAlign = (HAlign) 1;
    appearance13.ImageVAlign = (VAlign) 2;
    ((SpecialBoxBase) ((UltraGridBase) ultraDropDown4).DisplayLayout.GroupByBox).Appearance = (AppearanceBase) appearance13;
    appearance54.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.GroupByBox.BandLabelAppearance = (AppearanceBase) appearance54;
    ((SpecialBoxBase) ((UltraGridBase) ultraDropDown4).DisplayLayout.GroupByBox).BorderStyle = (UIElementBorderStyle) 4;
    appearance55.BackColor = SystemColors.ControlLightLight;
    appearance55.BackColor2 = SystemColors.Control;
    appearance55.BackGradientStyle = (GradientStyle) 3;
    appearance55.ForeColor = SystemColors.GrayText;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.GroupByBox.PromptAppearance = (AppearanceBase) appearance55;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.MaxColScrollRegions = 1;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.MaxRowScrollRegions = 1;
    appearance56.BackColor = SystemColors.Window;
    appearance56.ForeColor = SystemColors.ControlText;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.ActiveCellAppearance = (AppearanceBase) appearance56;
    appearance57.BackColor = SystemColors.Highlight;
    appearance57.ForeColor = SystemColors.HighlightText;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance57;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 2;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 2;
    appearance58.BackColor = SystemColors.Window;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.CardAreaAppearance = (AppearanceBase) appearance58;
    appearance59.BorderColor = Color.Silver;
    appearance59.TextTrimming = (TextTrimming) 3;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance59;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.CellClickAction = (CellClickAction) 4;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.CellPadding = 0;
    appearance60.BackColor = SystemColors.Control;
    appearance60.BackColor2 = SystemColors.ControlDark;
    appearance60.BackGradientAlignment = (GradientAlignment) 1;
    appearance60.BackGradientStyle = (GradientStyle) 3;
    appearance60.BorderColor = SystemColors.Window;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.GroupByRowAppearance = (AppearanceBase) appearance60;
    ((AppearanceBase) appearance61).TextHAlignAsString = "Left";
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance61;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.HeaderStyle = (HeaderStyle) 2;
    appearance62.BackColor = SystemColors.Window;
    appearance62.BorderColor = Color.Silver;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance62;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance63.BackColor = SystemColors.ControlLight;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.Override.TemplateAddRowAppearance = (AppearanceBase) appearance63;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.ScrollBounds = (ScrollBounds) 0;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.ScrollStyle = (ScrollStyle) 1;
    ((UltraGridBase) ultraDropDown4).DisplayLayout.ViewStyleBand = (ViewStyleBand) 2;
    ((UltraDropDownBase) ultraDropDown4).DisplayMember = "Condition";
    ((Control) ultraDropDown4).Location = new Point(284, 192 /*0xC0*/);
    ((UltraDropDownBase) ultraDropDown4).MaxDropDownItems = 1;
    ((Control) ultraDropDown4).Name = "ddCondition";
    ((Control) ultraDropDown4).Size = new Size(103, 76);
    ((Control) ultraDropDown4).TabIndex = 221;
    ((Control) ultraDropDown4).Text = "UltraDropDown1";
    ((UltraDropDownBase) ultraDropDown4).ValueMember = "ConditionID";
    ((Control) ultraDropDown4).Visible = false;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(961, 628);
    this.Controls.Add((Control) ultraDropDown4);
    this.Controls.Add((Control) this.lblCL);
    this.Controls.Add((Control) ultraDropDown3);
    this.Controls.Add((Control) this.lnkDeSelectAllStates);
    this.Controls.Add((Control) this.lnkSelectAllStates);
    this.Controls.Add((Control) this.ugStates);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.btnCopy);
    this.Controls.Add((Control) ultraDropDown1);
    this.Controls.Add((Control) ultraDropDown2);
    this.Controls.Add((Control) this.ugRaterconditionals);
    this.Name = nameof (FormCopyCompanyLineRaterConditionals);
    this.Text = "Copy Company/Line Rater Conditionals";
    ((ISupportInitialize) ultraDropDown1).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) ultraDropDown2).EndInit();
    ((ISupportInitialize) ultraDropDown3).EndInit();
    ((ISupportInitialize) this.btnCopy).EndInit();
    ((ISupportInitialize) this.ugStates).EndInit();
    ((ISupportInitialize) this.ugRaterconditionals).EndInit();
    ((ISupportInitialize) ultraDropDown4).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("ugRaterconditionals")]
  private virtual UltraGrid ugRaterconditionals { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyRaterCond ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnCopy
  {
    get => this._btnCopy;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnCopy_Click);
      MGAButton btnCopy1 = this._btnCopy;
      if (btnCopy1 != null)
        ((Control) btnCopy1).Click -= eventHandler;
      this._btnCopy = value;
      MGAButton btnCopy2 = this._btnCopy;
      if (btnCopy2 == null)
        return;
      ((Control) btnCopy2).Click += eventHandler;
    }
  }

  private virtual LinkLabel lnkSelectAll
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

  private virtual LinkLabel lnkDeSelectAll
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

  [field: AccessedThroughProperty("ugStates")]
  private virtual UltraGrid ugStates { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual LinkLabel lnkSelectAllStates
  {
    get => this._lnkSelectAllStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllStates_LinkClicked);
      LinkLabel lnkSelectAllStates1 = this._lnkSelectAllStates;
      if (lnkSelectAllStates1 != null)
        lnkSelectAllStates1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllStates = value;
      LinkLabel lnkSelectAllStates2 = this._lnkSelectAllStates;
      if (lnkSelectAllStates2 == null)
        return;
      lnkSelectAllStates2.LinkClicked += clickedEventHandler;
    }
  }

  private virtual LinkLabel lnkDeSelectAllStates
  {
    get => this._lnkDeSelectAllStates;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAllStates_LinkClicked);
      LinkLabel deSelectAllStates1 = this._lnkDeSelectAllStates;
      if (deSelectAllStates1 != null)
        deSelectAllStates1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAllStates = value;
      LinkLabel deSelectAllStates2 = this._lnkDeSelectAllStates;
      if (deSelectAllStates2 == null)
        return;
      deSelectAllStates2.LinkClicked += clickedEventHandler;
    }
  }

  [field: AccessedThroughProperty("lblCL")]
  internal virtual Label lblCL { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  public FormCopyCompanyLineRaterConditionals(int companyLineID)
  {
    this.Load += new EventHandler(this.FormCopyCompanyLineRaterConditionals_Load);
    this.InitializeComponent();
    this._companyLineID = companyLineID;
  }

  private void FormCopyCompanyLineRaterConditionals_Load(object sender, EventArgs e)
  {
    string[] strArray = new string[6]
    {
      "tblRaterFormSetups",
      "tblPolicyForms",
      "tblCompanyRaters",
      "tblRaterConditionals",
      "lstStates",
      "tblConditions"
    };
    try
    {
      DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, "GetExistingCompanyLineRaterConditionals", new object[2]
      {
        (object) "@companylineid",
        (object) this._companyLineID
      });
    }
    catch (ConstraintException ex)
    {
      ProjectData.SetProjectError((Exception) ex);
      ErrorHandler.ShowDataSetErrors((DataSet) this.ds, ex);
      ProjectData.ClearProjectError();
    }
    dsCopyRaterCond.OperatorsDataTable operators = this.ds.Operators;
    operators.AddOperatorsRow("LT", "Less Than");
    operators.AddOperatorsRow("GT", "Greater Than");
    operators.AddOperatorsRow("EQ", "Equal To");
    operators.AddOperatorsRow("NE", "Not Equal To");
    operators.AddOperatorsRow("TR", "True");
    operators.AddOperatorsRow("FA", "False");
    this.FillConditions();
    this.SelectOrDeselectRows(false);
    this.SelectOrDeselectStates(false);
    this.lblCL.Text = $"{this.lblCL.Text} '{new CompanyLine(this._companyLineID).CompanyLineState}'";
  }

  private void FillConditions()
  {
    Dictionary<int, IRater> dictionary = new Dictionary<int, IRater>();
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRaterconditionals).Rows)
    {
      if (row.Cells["Condition"].Value == DBNull.Value | row.Cells["Condition"].Value == null)
      {
        int num1 = (int) row.Cells["RaterID"].Value;
        int num2 = (int) row.Cells["ConditionalID"].Value;
        IRater rater;
        if (dictionary.ContainsKey(num1))
        {
          rater = dictionary[num1];
        }
        else
        {
          rater = RaterFactory.GetRater(num1);
          if (rater != null)
            dictionary.Add(num1, rater);
        }
        List<RaterConditionalElement> conditionalElementList = rater.RaterConditionalElements(num1.ToString());
        try
        {
          foreach (RaterConditionalElement conditionalElement in conditionalElementList)
          {
            if (conditionalElement.ConditionalID == num2)
              row.Cells["Condition"].Value = (object) conditionalElement.Condition;
          }
        }
        finally
        {
          List<RaterConditionalElement>.Enumerator enumerator;
          enumerator.Dispose();
        }
      }
    }
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectOrDeselectRows(true);
  }

  private void SelectOrDeselectRows(bool objVal)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRaterconditionals).Rows)
      row.Cells["Select"].Value = (object) objVal;
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectOrDeselectRows(false);
  }

  private void SelectOrDeselectStates(bool objVal)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.ugStates).Rows)
      row.Cells["Select"].Value = (object) objVal;
  }

  private void lnkSelectAllStates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectOrDeselectStates(true);
  }

  private void lnkDeSelectAllStates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SelectOrDeselectStates(false);
  }

  private void btnCopy_Click(object sender, EventArgs e)
  {
    string str1 = string.Empty;
    string str2 = string.Empty;
    string str3 = string.Empty;
    string str4 = string.Empty;
    string str5 = string.Empty;
    foreach (UltraGridRow row in ((UltraGridBase) this.ugStates).Rows)
    {
      if ((bool) row.Cells["Select"].Value)
        str1 = $"{str1},{row.Cells["StateID"].Value.ToString()}";
    }
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRaterconditionals).Rows)
    {
      if ((bool) row.Cells["Select"].Value)
        str2 = $"{str2},{row.Cells["SetupID"].Value.ToString()}";
    }
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRaterconditionals).Rows)
    {
      if ((bool) row.Cells["Select"].Value)
        str3 = $"{str3},{row.Cells["ConditionalID"].Value.ToString()}";
    }
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRaterconditionals).Rows)
    {
      if ((bool) row.Cells["Select"].Value && row.Cells["PolicyFormID"].Value != DBNull.Value)
        str4 = $"{str4},{row.Cells["PolicyFormID"].Value.ToString()}";
    }
    foreach (UltraGridRow row in ((UltraGridBase) this.ugRaterconditionals).Rows)
    {
      if ((bool) row.Cells["Select"].Value && row.Cells["CompanyLineConditionID"].Value != DBNull.Value)
        str5 = $"{str5},{row.Cells["CompanyLineConditionID"].Value.ToString()}";
    }
    if (str2.Equals(string.Empty))
    {
      int num1 = (int) MessageBox.Show("No Setup has been selected.", "No Setup Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (str1.Equals(string.Empty))
    {
      int num2 = (int) MessageBox.Show("No State has been selected to copy over the setup to.", "No State Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        this.Cursor = MgaCursors.WaitCursor;
        object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar("CopyCompanyLineRaterConditionals", new object[12]
        {
          (object) "@companylineid",
          (object) this._companyLineID,
          (object) "@stateString",
          (object) str1,
          (object) "@setupIDString",
          (object) str2,
          (object) "@conditionalIDString",
          (object) str3,
          (object) "@policyFormIDString",
          (object) str4,
          (object) "@compLineConditionIDString",
          (object) str5
        }));
        if (objectValue == null || objectValue == DBNull.Value)
          return;
        int num3 = (int) MessageBox.Show(objectValue.ToString() + " rater policy form / company line conditionals were copied over.", "Rater/Conditionals Copied Over", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      finally
      {
        this.Cursor = MgaCursors.Default;
      }
    }
  }
}
