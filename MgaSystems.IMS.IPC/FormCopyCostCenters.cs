// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCopyCostCenters
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies;

[DesignerGenerated]
public class FormCopyCostCenters : Form
{
  private IContainer components;
  private readonly Guid _currentCompanyLineGuid;
  private readonly CompanyLine _cl;
  private bool _hasCostCenters;

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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCopyCostCenters));
    Appearance appearance2 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblEntityGroups", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GroupId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("GroupDescription");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("SystemDefined");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("CopyOver");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("ViewCompanyLines", -1);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("CopyOver");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ViewCompanyLines_ViewCompanyLinesChildren");
    UltraGridBand ultraGridBand3 = new UltraGridBand("ViewCompanyLines_ViewCompanyLinesChildren", 0);
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ParentCompanyLineGuid");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("CopyOver");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    this.UltraGroupBox1 = new UltraGroupBox();
    this.lblCompanyAddress = new Label();
    this.lblState = new Label();
    this.lblCompany = new Label();
    this.lblLine = new Label();
    this.Label26 = new Label();
    this.Label25 = new Label();
    this.Label24 = new Label();
    this.lnkApplyFilter = new LinkLabel();
    this.btnCopy = new MGAButton();
    this.dgCostCenters = new UltraGrid();
    this.ds = new dsCopyCostCenters();
    this.dgView = new UltraGrid();
    this.cbStateFilter = new MGASimpleComboBox();
    this.cbCompanyFilter = new MGASimpleComboBox();
    this.cbLineFilter = new MGASimpleComboBox();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelectAll = new LinkLabel();
    this.lnkChildLinesSelection = new LinkLabel();
    ((ISupportInitialize) this.UltraGroupBox1).BeginInit();
    ((Control) this.UltraGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.btnCopy).BeginInit();
    ((ISupportInitialize) this.dgCostCenters).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.dgView).BeginInit();
    ((ISupportInitialize) this.cbStateFilter).BeginInit();
    ((ISupportInitialize) this.cbCompanyFilter).BeginInit();
    ((ISupportInitialize) this.cbLineFilter).BeginInit();
    this.SuspendLayout();
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.lblCompanyAddress);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.lblState);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.lblCompany);
    ((Control) this.UltraGroupBox1).Controls.Add((Control) this.lblLine);
    ((Control) this.UltraGroupBox1).Location = new Point(12, 12);
    ((Control) this.UltraGroupBox1).Name = "UltraGroupBox1";
    ((Control) this.UltraGroupBox1).Size = new Size(693, 123);
    ((Control) this.UltraGroupBox1).TabIndex = 447;
    this.UltraGroupBox1.Text = "Current Company / Line Info";
    this.UltraGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    this.lblCompanyAddress.AutoSize = true;
    this.lblCompanyAddress.Location = new Point(5, 49);
    this.lblCompanyAddress.Name = "lblCompanyAddress";
    this.lblCompanyAddress.Size = new Size(99, 13);
    this.lblCompanyAddress.TabIndex = 443;
    this.lblCompanyAddress.Text = "lblCompanyAddress";
    this.lblState.AutoSize = true;
    this.lblState.Location = new Point(5, 95);
    this.lblState.Name = "lblState";
    this.lblState.Size = new Size(42, 13);
    this.lblState.TabIndex = 445;
    this.lblState.Text = "lblState";
    this.lblCompany.AutoSize = true;
    this.lblCompany.Location = new Point(5, 27);
    this.lblCompany.Name = "lblCompany";
    this.lblCompany.Size = new Size(61, 13);
    this.lblCompany.TabIndex = 3;
    this.lblCompany.Text = "lblCompany";
    this.lblLine.AutoSize = true;
    this.lblLine.Location = new Point(5, 73);
    this.lblLine.Name = "lblLine";
    this.lblLine.Size = new Size(37, 13);
    this.lblLine.TabIndex = 444;
    this.lblLine.Text = "lblLine";
    this.Label26.AutoSize = true;
    this.Label26.Location = new Point(541, 148);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(60, 13);
    this.Label26.TabIndex = 453;
    this.Label26.Text = "State Filter:";
    this.Label25.AutoSize = true;
    this.Label25.Location = new Point(321, 148);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(55, 13);
    this.Label25.TabIndex = 452;
    this.Label25.Text = "Line Filter:";
    this.Label24.AutoSize = true;
    this.Label24.Location = new Point(9, 148);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(79, 13);
    this.Label24.TabIndex = 451;
    this.Label24.Text = "Company Filter:";
    this.lnkApplyFilter.AutoSize = true;
    this.lnkApplyFilter.Location = new Point(371, 203);
    this.lnkApplyFilter.Name = "lnkApplyFilter";
    this.lnkApplyFilter.Size = new Size(58, 13);
    this.lnkApplyFilter.TabIndex = 455;
    this.lnkApplyFilter.TabStop = true;
    this.lnkApplyFilter.Text = "Apply Filter";
    ((Control) this.btnCopy).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    ((ControlBase) this.btnCopy).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnCopy).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCopy).Location = new Point(1005, 628);
    ((Control) this.btnCopy).Name = "btnCopy";
    ((ControlBase) this.btnCopy).Padding = new Size(5, 0);
    ((Control) this.btnCopy).Size = new Size(74, 40);
    ((Control) this.btnCopy).TabIndex = 456;
    ((Control) this.btnCopy).Tag = (object) "";
    ((ControlBase) this.btnCopy).Text = "Copy";
    this.btnCopy.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.dgCostCenters).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgCostCenters).DataMember = "tblEntityGroups";
    ((UltraGridBase) this.dgCostCenters).DataSource = (object) this.ds;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 64 /*0x40*/;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Cost Center";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 239;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "System";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 56;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 49;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance3.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance3.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance4.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
    appearance5.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance6.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance6;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance8.BackColor = Color.Transparent;
    appearance8.ForeColor = Color.Black;
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.WhiteSmoke;
    appearance9.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance9;
    appearance10.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.dgCostCenters).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgCostCenters).Location = new Point(714, 12);
    ((Control) this.dgCostCenters).Name = "dgCostCenters";
    ((Control) this.dgCostCenters).Size = new Size(365, 603);
    ((Control) this.dgCostCenters).TabIndex = 457;
    ((Control) this.dgCostCenters).Text = "Available Cost Centers";
    ((UltraControlBase) this.dgCostCenters).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgCostCenters).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsCopyCostCenters";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((UltraGridBase) this.dgView).DataMember = "ViewCompanyLines";
    ((UltraGridBase) this.dgView).DataSource = (object) this.ds;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgView).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 264;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 2;
    ultraGridColumn6.Width = 213;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 1;
    ultraGridColumn7.Width = 276;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn8.Width = 124;
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 4;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 193;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 5;
    ultraGridColumn10.Width = 61;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 6;
    ultraGridBand2.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11
    });
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 0;
    ultraGridColumn12.Hidden = true;
    ultraGridColumn12.Width = 254;
    ultraGridColumn13.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn13.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 2;
    ultraGridColumn13.Width = 192 /*0xC0*/;
    ultraGridColumn14.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn14.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 1;
    ultraGridColumn14.Width = 278;
    ultraGridColumn15.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 3;
    ultraGridColumn15.Width = 121;
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 4;
    ultraGridColumn16.Hidden = true;
    ultraGridColumn16.Width = 187;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 5;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 146;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 6;
    ultraGridColumn18.Width = 64 /*0x40*/;
    ultraGridBand3.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn12,
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18
    });
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgView).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance12.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.Transparent;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.WhiteSmoke;
    appearance18.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dgView).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.dgView).Location = new Point(10, 222);
    ((Control) this.dgView).Name = "dgView";
    ((Control) this.dgView).Size = new Size(695, 393);
    ((Control) this.dgView).TabIndex = 454;
    ((UltraControlBase) this.dgView).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgView).UseOsThemes = (DefaultableBoolean) 2;
    this.cbStateFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbStateFilter).DataMember = "lstStates";
    ((UltraGridBase) this.cbStateFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbStateFilter).DisplayMember = "State";
    this.cbStateFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbStateFilter).DropDownWidth = 350;
    ((Control) this.cbStateFilter).Location = new Point(541, 169);
    this.cbStateFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStateFilter).Name = "cbStateFilter";
    ((Control) this.cbStateFilter).Size = new Size(164, 20);
    ((Control) this.cbStateFilter).TabIndex = 450;
    ((UltraControlBase) this.cbStateFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStateFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStateFilter).ValueMember = "StateID";
    this.cbCompanyFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbCompanyFilter).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cbCompanyFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbCompanyFilter).DisplayMember = "Name";
    this.cbCompanyFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbCompanyFilter).DropDownWidth = 600;
    ((Control) this.cbCompanyFilter).Location = new Point(12, 169);
    this.cbCompanyFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbCompanyFilter).Name = "cbCompanyFilter";
    ((Control) this.cbCompanyFilter).Size = new Size(298, 20);
    ((Control) this.cbCompanyFilter).TabIndex = 448;
    ((UltraControlBase) this.cbCompanyFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbCompanyFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbCompanyFilter).ValueMember = "CompanyLocationGuid";
    this.cbLineFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbLineFilter).DataMember = "lstLines";
    ((UltraGridBase) this.cbLineFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbLineFilter).DisplayMember = "LineName";
    this.cbLineFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbLineFilter).DropDownWidth = 400;
    ((Control) this.cbLineFilter).Location = new Point(324, 169);
    this.cbLineFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbLineFilter).Name = "cbLineFilter";
    ((Control) this.cbLineFilter).Size = new Size(198, 20);
    ((Control) this.cbLineFilter).TabIndex = 449;
    ((UltraControlBase) this.cbLineFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbLineFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbLineFilter).ValueMember = "LineGuid";
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(12, 630);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(128 /*0x80*/, 13);
    this.lnkSelectAll.TabIndex = 458;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All Company/Lines";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.Location = new Point(12, 658);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(145, 13);
    this.lnkDeSelectAll.TabIndex = 459;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All Company/Lines";
    this.lnkChildLinesSelection.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkChildLinesSelection.AutoSize = true;
    this.lnkChildLinesSelection.Location = new Point(483, 630);
    this.lnkChildLinesSelection.Name = "lnkChildLinesSelection";
    this.lnkChildLinesSelection.Size = new Size(206, 13);
    this.lnkChildLinesSelection.TabIndex = 473;
    this.lnkChildLinesSelection.TabStop = true;
    this.lnkChildLinesSelection.Text = "Select all \"selected\" Child Company/Lines";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1088, 680);
    this.Controls.Add((Control) this.lnkChildLinesSelection);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.dgCostCenters);
    this.Controls.Add((Control) this.btnCopy);
    this.Controls.Add((Control) this.lnkApplyFilter);
    this.Controls.Add((Control) this.dgView);
    this.Controls.Add((Control) this.Label26);
    this.Controls.Add((Control) this.Label25);
    this.Controls.Add((Control) this.Label24);
    this.Controls.Add((Control) this.cbStateFilter);
    this.Controls.Add((Control) this.cbCompanyFilter);
    this.Controls.Add((Control) this.cbLineFilter);
    this.Controls.Add((Control) this.UltraGroupBox1);
    this.Name = nameof (FormCopyCostCenters);
    this.Text = "Copy Cost Centers";
    ((ISupportInitialize) this.UltraGroupBox1).EndInit();
    ((Control) this.UltraGroupBox1).ResumeLayout(false);
    ((Control) this.UltraGroupBox1).PerformLayout();
    ((ISupportInitialize) this.btnCopy).EndInit();
    ((ISupportInitialize) this.dgCostCenters).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.dgView).EndInit();
    ((ISupportInitialize) this.cbStateFilter).EndInit();
    ((ISupportInitialize) this.cbCompanyFilter).EndInit();
    ((ISupportInitialize) this.cbLineFilter).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("UltraGroupBox1")]
  internal virtual UltraGroupBox UltraGroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompanyAddress")]
  internal virtual Label lblCompanyAddress { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblState")]
  internal virtual Label lblState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompany")]
  internal virtual Label lblCompany { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblLine")]
  internal virtual Label lblLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label26")]
  private virtual Label Label26 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label25")]
  private virtual Label Label25 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label24")]
  private virtual Label Label24 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbStateFilter")]
  private virtual MGASimpleComboBox cbStateFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbCompanyFilter")]
  private virtual MGASimpleComboBox cbCompanyFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cbLineFilter")]
  private virtual MGASimpleComboBox cbLineFilter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyCostCenters ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgCostCenters")]
  private virtual UltraGrid dgCostCenters { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgView")]
  private virtual UltraGrid dgView { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual LinkLabel lnkChildLinesSelection
  {
    get => this._lnkChildLinesSelection;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkChildLinesSelection_LinkClicked);
      LinkLabel childLinesSelection1 = this._lnkChildLinesSelection;
      if (childLinesSelection1 != null)
        childLinesSelection1.LinkClicked -= clickedEventHandler;
      this._lnkChildLinesSelection = value;
      LinkLabel childLinesSelection2 = this._lnkChildLinesSelection;
      if (childLinesSelection2 == null)
        return;
      childLinesSelection2.LinkClicked += clickedEventHandler;
    }
  }

  public FormCopyCostCenters(Guid companyLineGuid)
  {
    this.Load += new EventHandler(this.FormCopyCostCenters_Load);
    this._hasCostCenters = false;
    this.InitializeComponent();
    this._currentCompanyLineGuid = companyLineGuid;
    this._cl = new CompanyLine(companyLineGuid);
  }

  private void FormCopyCostCenters_Load(object sender, EventArgs e)
  {
    this.lblCompany.Text = "Current Company: " + this._cl.CompanyLocation.LocationName;
    this._hasCostCenters = DefaultDatabase.ExecuteScalar<int>(CommandType.Text, "SELECT COUNT(*) FROM tblCompanyLineCostCenters WITH (NOLOCK) WHERE CompanyLineGuid = @CL", new object[2]
    {
      (object) "@CL",
      (object) this._currentCompanyLineGuid
    }) > 0;
    object objectValue = RuntimeHelpers.GetObjectValue(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT ISNULL(Address1 + @c, @s) + City + @c + State AS Address FROM tblCompanyLocations WITH (NOLOCK) WHERE CompanyLocationGUID = @CLG", new object[6]
    {
      (object) "@CLG",
      (object) this._cl.CompanyLocationGuid,
      (object) "@c",
      (object) ", ",
      (object) "@s",
      (object) ""
    }));
    this.lblCompanyAddress.Text = Utility.IsNull(RuntimeHelpers.GetObjectValue(objectValue)) ? string.Empty : "Address: " + objectValue.ToString();
    this.lblLine.Text = "Line: " + this._cl.LineName;
    this.lblState.Text = "State: " + this._cl.StateID;
    try
    {
      this.SetComboBoxesEnabledProperty(false);
      dsCopyCostCenters.lstStatesRow row1 = this.ds.lstStates.NewlstStatesRow();
      row1.StateID = string.Empty;
      row1.State = "ANY";
      this.ds.lstStates.AddlstStatesRow(row1);
      dsCopyCostCenters.lstLinesRow row2 = this.ds.lstLines.NewlstLinesRow();
      row2.LineGuid = Guid.Empty;
      row2.LineName = "ANY";
      this.ds.lstLines.AddlstLinesRow(row2);
      dsCopyCostCenters.tblCompanyLocationsRow row3 = this.ds.tblCompanyLocations.NewtblCompanyLocationsRow();
      row3.CompanyLocationGuid = Guid.Empty;
      row3.Name = "ANY";
      this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(row3);
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[4]
      {
        "lstLines",
        "lstStates",
        "tblCompanyLocations",
        "tblEntityGroups"
      }, "spGetCompanyLineAndCostCenterData", new object[2]
      {
        (object) "@CurrentCompanyLineGuid",
        (object) this._currentCompanyLineGuid
      });
      if (this.ds.tblEntityGroups.Count != 1)
        return;
      this.ds.tblEntityGroups.Rows[0]["CopyOver"] = (object) true;
    }
    finally
    {
      this.SetComboBoxesEnabledProperty(true);
    }
  }

  private void SetComboBoxesEnabledProperty(bool enableValue)
  {
    ((Control) this.cbCompanyFilter).Enabled = enableValue;
    ((Control) this.cbStateFilter).Enabled = enableValue;
    ((Control) this.cbLineFilter).Enabled = enableValue;
  }

  private void lnkApplyFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    try
    {
      this.SetComboBoxesEnabledProperty(false);
      this.ds.ViewCompanyLines.Clear();
      this.ds.ViewCompanyLinesChildren.Clear();
      object obj1 = (object) null;
      object obj2 = (object) null;
      object obj3 = (object) null;
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbCompanyFilter.Text, "ANY", false) != 0)
        obj1 = RuntimeHelpers.GetObjectValue(this.cbCompanyFilter.Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbLineFilter.Text, "ANY", false) != 0)
        obj2 = RuntimeHelpers.GetObjectValue(this.cbLineFilter.Value);
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbStateFilter.Text, "ANY", false) != 0)
        obj3 = RuntimeHelpers.GetObjectValue(this.cbStateFilter.Value);
      string[] strArray = new string[2]
      {
        "ViewCompanyLines",
        "ViewCompanyLinesChildren"
      };
      try
      {
        DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, "spGetCopyCostCenterCompanyLines", new object[8]
        {
          (object) "@companyLocationGuid",
          obj1,
          (object) "@lineGuid",
          obj2,
          (object) "@stateID",
          obj3,
          (object) "@CurrentCompanyLineGuid",
          (object) this._currentCompanyLineGuid
        });
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
    finally
    {
      this.SetComboBoxesEnabledProperty(true);
    }
  }

  private bool IsvalidCopy()
  {
    bool flag1;
    if (!this._hasCostCenters)
    {
      int num = (int) MessageBox.Show("The current company/line does not have any assigned cost centers.", "No Cost Centers Assigned", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag1 = false;
    }
    else if (((UltraGridBase) this.dgView).Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("No row(s) available in the grid.", "No Row(s) Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      flag1 = false;
    }
    else
    {
      bool flag2 = false;
      try
      {
        foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
        {
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["CopyOver"].Value)) && Conversions.ToBoolean(ultraGridRow.Cells["CopyOver"].Value))
          {
            flag2 = true;
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
      if (!flag2)
      {
        int num = (int) MessageBox.Show("In order to continue, at least one company/line row must be selected to 'Copy' over.", "No Company/Line Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        flag1 = false;
      }
      else
      {
        bool flag3 = false;
        foreach (UltraGridRow row in ((UltraGridBase) this.dgCostCenters).Rows)
        {
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["CopyOver"].Value)) && Conversions.ToBoolean(row.Cells["CopyOver"].Value))
          {
            flag3 = true;
            break;
          }
        }
        if (!flag3)
        {
          int num = (int) MessageBox.Show("In order to continue, at least one cost center must be selected to 'Copy' over.", "No Cost Center Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
          flag1 = false;
        }
        else
          flag1 = true;
      }
    }
    return flag1;
  }

  private void btnCopy_Click(object sender, EventArgs e)
  {
    if (!this.IsvalidCopy())
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      string str = string.Empty;
      RowEnumerator enumerator1 = ((UltraGridBase) this.dgCostCenters).Rows.GetEnumerator();
      while (enumerator1.MoveNext())
      {
        UltraGridRow current = enumerator1.Current;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(current.Cells["CopyOver"].Value)) && Conversions.ToBoolean(current.Cells["CopyOver"].Value))
          str = $"{str}{current.Cells["GroupId"].Value.ToString()},";
      }
      try
      {
        foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
        {
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["CopyOver"].Value)) && Conversions.ToBoolean(ultraGridRow.Cells["CopyOver"].Value))
            DefaultDatabase.ExecuteNonQuery("spCopyCompanyLineCostCenters", new object[6]
            {
              (object) "@CurrentCompanyLineGuid",
              (object) this._currentCompanyLineGuid,
              (object) "@DestinationCompanyLineGuid",
              ultraGridRow.Cells["CompanyLineGuid"].Value,
              (object) "@CostCenterIDs",
              (object) str
            });
        }
      }
      finally
      {
        IEnumerator enumerator2;
        if (enumerator2 is IDisposable)
          (enumerator2 as IDisposable).Dispose();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    int num = (int) MessageBox.Show("Cost center(s) copied over sucessfully.", "Copied Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(true);
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(false);
  }

  private void SetGridSelection(bool selectionValue)
  {
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
        ultraGridRow.Cells["CopyOver"].Value = (object) selectionValue;
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    ((UltraGridBase) this.dgView).UpdateData();
  }

  private void lnkChildLinesSelection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    int num1 = 0;
    Guid empty = Guid.Empty;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["CopyOver"].Value)) && Conversions.ToBoolean(ultraGridRow.Cells["CopyOver"].Value))
        {
          if (ultraGridRow.Band.Index == 0)
          {
            int num2 = (int) MessageBox.Show("Cannot continue - Parent row is selected.", "Only Child Rows Expected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
          }
          empty = (Guid) ultraGridRow.Cells["CompanyLocationGuid"].Value;
          ++num1;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    if (num1 != 1)
    {
      int num3 = (int) MessageBox.Show("Cannot continue - Only 1 row can be selected.", "Only One Child Row Expected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else if (empty.Equals(Guid.Empty))
    {
      int num4 = (int) MessageBox.Show("Cannot continue - Must select a child row.", "No Child Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      try
      {
        foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
        {
          if (ultraGridRow.Band.Index == 1 && ((Guid) ultraGridRow.Cells["CompanyLocationGuid"].Value).Equals(empty))
            ultraGridRow.Cells["CopyOver"].Value = (object) 1;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      ((UltraGridBase) this.dgView).UpdateData();
    }
  }
}
