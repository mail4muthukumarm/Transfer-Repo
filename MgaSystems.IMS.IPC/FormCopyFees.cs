// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormCopyFees
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.BusinessObjects;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
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
public class FormCopyFees : Form
{
  private IContainer components;
  private readonly int _currentCompanyLineID;
  private readonly List<int> _companyFeeIDsList;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("ViewCompanyLines", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("CopyOver");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ViewCompanyLines_ViewCompanyLinesChildren");
    UltraGridBand ultraGridBand2 = new UltraGridBand("ViewCompanyLines_ViewCompanyLinesChildren", 0);
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("CompanyLineGuid");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("LineName");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("Name");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("State");
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("CompanyLocationGuid");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ParentCompanyLineGuid");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("CompanyLineID");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("CopyOver");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook1 = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormCopyFees));
    Appearance appearance11 = new Appearance();
    UltraGridBand ultraGridBand3 = new UltraGridBand("dtFees", -1);
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("ChargeCode");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("CompanyFeeID");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("CopyFee");
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    ScrollBarLook scrollBarLook2 = new ScrollBarLook();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    this.txtCompanyLine = new Label();
    this.lblCompanyLine = new Label();
    this.lnkApplyFilter = new LinkLabel();
    this.Label26 = new Label();
    this.Label25 = new Label();
    this.Label24 = new Label();
    this.cbStateFilter = new MGASimpleComboBox();
    this.ds = new dsCopyFee();
    this.cbCompanyFilter = new MGASimpleComboBox();
    this.cbLineFilter = new MGASimpleComboBox();
    this.dgView = new UltraGrid();
    this.panelPleaseWait = new UltraGroupBox();
    this.Label27 = new Label();
    this.PictureBox1 = new PictureBox();
    this.dgFees = new UltraGrid();
    this.lnkSelectAll = new LinkLabel();
    this.lnkDeSelectAll = new LinkLabel();
    this.btnCopy = new MGAButton();
    this.lnkSelectAllChild = new LinkLabel();
    this.lnkDeSelectChild = new LinkLabel();
    this.lnkExpand = new LinkLabel();
    this.lnkCollapse = new LinkLabel();
    ((ISupportInitialize) this.cbStateFilter).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.cbCompanyFilter).BeginInit();
    ((ISupportInitialize) this.cbLineFilter).BeginInit();
    ((ISupportInitialize) this.dgView).BeginInit();
    ((ISupportInitialize) this.panelPleaseWait).BeginInit();
    ((Control) this.panelPleaseWait).SuspendLayout();
    ((ISupportInitialize) this.PictureBox1).BeginInit();
    ((ISupportInitialize) this.dgFees).BeginInit();
    ((ISupportInitialize) this.btnCopy).BeginInit();
    this.SuspendLayout();
    this.txtCompanyLine.AutoSize = true;
    this.txtCompanyLine.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.txtCompanyLine.Location = new Point(140, 9);
    this.txtCompanyLine.Name = "txtCompanyLine";
    this.txtCompanyLine.Size = new Size(145, 13);
    this.txtCompanyLine.TabIndex = 470;
    this.txtCompanyLine.Text = "Current Company / Line:";
    this.lblCompanyLine.AutoSize = true;
    this.lblCompanyLine.Location = new Point(12, 9);
    this.lblCompanyLine.Name = "lblCompanyLine";
    this.lblCompanyLine.Size = new Size(122, 13);
    this.lblCompanyLine.TabIndex = 469;
    this.lblCompanyLine.Text = "Current Company / Line:";
    this.lnkApplyFilter.AutoSize = true;
    this.lnkApplyFilter.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.lnkApplyFilter.Location = new Point(303, 99);
    this.lnkApplyFilter.Name = "lnkApplyFilter";
    this.lnkApplyFilter.Size = new Size(78, 15);
    this.lnkApplyFilter.TabIndex = 477;
    this.lnkApplyFilter.TabStop = true;
    this.lnkApplyFilter.Text = "Apply Filter";
    this.Label26.AutoSize = true;
    this.Label26.Location = new Point(550, 44);
    this.Label26.Name = "Label26";
    this.Label26.Size = new Size(60, 13);
    this.Label26.TabIndex = 476;
    this.Label26.Text = "State Filter:";
    this.Label25.AutoSize = true;
    this.Label25.Location = new Point(326, 44);
    this.Label25.Name = "Label25";
    this.Label25.Size = new Size(55, 13);
    this.Label25.TabIndex = 475;
    this.Label25.Text = "Line Filter:";
    this.Label24.AutoSize = true;
    this.Label24.Location = new Point(14, 44);
    this.Label24.Name = "Label24";
    this.Label24.Size = new Size(79, 13);
    this.Label24.TabIndex = 474;
    this.Label24.Text = "Company Filter:";
    this.cbStateFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbStateFilter).DataMember = "lstStates";
    ((UltraGridBase) this.cbStateFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbStateFilter).DisplayMember = "State";
    this.cbStateFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbStateFilter).DropDownWidth = 350;
    ((Control) this.cbStateFilter).Location = new Point(553, 65);
    this.cbStateFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbStateFilter).Name = "cbStateFilter";
    ((Control) this.cbStateFilter).Size = new Size(164, 20);
    ((Control) this.cbStateFilter).TabIndex = 473;
    ((UltraControlBase) this.cbStateFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbStateFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbStateFilter).ValueMember = "StateID";
    this.ds.DataSetName = "dsCopyFee";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.cbCompanyFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbCompanyFilter).DataMember = "tblCompanyLocations";
    ((UltraGridBase) this.cbCompanyFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbCompanyFilter).DisplayMember = "Name";
    this.cbCompanyFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbCompanyFilter).DropDownWidth = 600;
    ((Control) this.cbCompanyFilter).Location = new Point(17, 65);
    this.cbCompanyFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbCompanyFilter).Name = "cbCompanyFilter";
    ((Control) this.cbCompanyFilter).Size = new Size(298, 20);
    ((Control) this.cbCompanyFilter).TabIndex = 471;
    ((UltraControlBase) this.cbCompanyFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbCompanyFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbCompanyFilter).ValueMember = "CompanyLocationGuid";
    this.cbLineFilter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cbLineFilter).DataMember = "lstLines";
    ((UltraGridBase) this.cbLineFilter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cbLineFilter).DisplayMember = "LineName";
    this.cbLineFilter.DropDownStyle = (UltraComboStyle) 1;
    ((UltraDropDownBase) this.cbLineFilter).DropDownWidth = 400;
    ((Control) this.cbLineFilter).Location = new Point(329, 65);
    this.cbLineFilter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cbLineFilter).Name = "cbLineFilter";
    ((Control) this.cbLineFilter).Size = new Size(201, 20);
    ((Control) this.cbLineFilter).TabIndex = 472;
    ((UltraControlBase) this.cbLineFilter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cbLineFilter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cbLineFilter).ValueMember = "LineGuid";
    ((Control) this.dgView).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    ((UltraGridBase) this.dgView).DataMember = "ViewCompanyLines";
    ((UltraGridBase) this.dgView).DataSource = (object) this.ds;
    appearance1.BackColor = Color.White;
    appearance1.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.dgView).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 264;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn2.Header.VisiblePosition = 2;
    ultraGridColumn2.Width = 216;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn3.Header.VisiblePosition = 1;
    ultraGridColumn3.Width = 301;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 113;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 193;
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Hidden = true;
    ultraGridColumn6.Width = 85;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Width = 51;
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn8.Header.VisiblePosition = 7;
    ultraGridBand1.Columns.AddRange(new object[8]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn9.Header.VisiblePosition = 0;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 254;
    ultraGridColumn10.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Line";
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn10.Header.VisiblePosition = 2;
    ultraGridColumn10.Width = 203;
    ultraGridColumn11.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn11.Header).Caption = "Company";
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn11.Header.VisiblePosition = 1;
    ultraGridColumn11.Width = 289;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn12.Header.VisiblePosition = 3;
    ultraGridColumn12.Width = 117;
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn13.Header.VisiblePosition = 4;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 187;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn14.Header.VisiblePosition = 5;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 146;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn15.Header.VisiblePosition = 6;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 85;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn16.Header.VisiblePosition = 7;
    ultraGridColumn16.Width = 53;
    ultraGridBand2.Columns.AddRange(new object[8]
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
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.dgView).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.dgView).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance2.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
    appearance4.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance5.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    appearance6.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance7.BackColor = Color.Transparent;
    appearance7.ForeColor = Color.Black;
    ((UltraGridBase) this.dgView).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.WhiteSmoke;
    appearance8.BorderColor = Color.Silver;
    scrollBarLook1.ButtonAppearance = (AppearanceBase) appearance8;
    appearance9.BackColor = Color.White;
    scrollBarLook1.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.dgView).DisplayLayout.ScrollBarLook = scrollBarLook1;
    ((Control) this.dgView).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgView).Location = new Point(15, 126);
    ((Control) this.dgView).Name = "dgView";
    ((Control) this.dgView).Size = new Size(702, 440);
    ((Control) this.dgView).TabIndex = 478;
    ((UltraControlBase) this.dgView).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgView).UseOsThemes = (DefaultableBoolean) 2;
    appearance10.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.panelPleaseWait.ContentAreaAppearance = (AppearanceBase) appearance10;
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.Label27);
    ((Control) this.panelPleaseWait).Controls.Add((Control) this.PictureBox1);
    ((Control) this.panelPleaseWait).Location = new Point(288, 213);
    ((Control) this.panelPleaseWait).Name = "panelPleaseWait";
    ((Control) this.panelPleaseWait).Size = new Size(279, 84);
    ((Control) this.panelPleaseWait).TabIndex = 479;
    ((Control) this.panelPleaseWait).Visible = false;
    this.Label27.Font = new Font("Tahoma", 11f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.Label27.Location = new Point(55, 32 /*0x20*/);
    this.Label27.Name = "Label27";
    this.Label27.Size = new Size(209, 21);
    this.Label27.TabIndex = 1;
    this.Label27.Text = "Please wait.  Copying Fees ...";
    this.PictureBox1.Image = (Image) componentResourceManager.GetObject("PictureBox1.Image");
    this.PictureBox1.Location = new Point(17, 26);
    this.PictureBox1.Name = "PictureBox1";
    this.PictureBox1.Size = new Size(32 /*0x20*/, 32 /*0x20*/);
    this.PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
    this.PictureBox1.TabIndex = 0;
    this.PictureBox1.TabStop = false;
    ((Control) this.dgFees).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.dgFees).DataMember = "dtFees";
    ((UltraGridBase) this.dgFees).DataSource = (object) this.ds;
    appearance11.BackColor = Color.White;
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgFees).DisplayLayout.Appearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.dgFees).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn17.Header.VisiblePosition = 0;
    ultraGridColumn17.Hidden = true;
    ultraGridColumn17.Width = 101;
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn18.Header.VisiblePosition = 1;
    ultraGridColumn18.Hidden = true;
    ultraGridColumn18.Width = 75;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Fee";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn19.Header.VisiblePosition = 2;
    ultraGridColumn19.Width = 299;
    ((HeaderBase) ultraGridColumn20.Header).Caption = "Copy";
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridColumn20.Header.VisiblePosition = 3;
    ultraGridColumn20.Width = 57;
    ultraGridBand3.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20
    });
    ((UltraGridBase) this.dgFees).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.dgFees).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance12.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance12.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance13.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
    appearance14.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance14;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance15.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance15;
    appearance16.BorderColor = Color.LightGray;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance17.BackColor = Color.Transparent;
    appearance17.ForeColor = Color.Black;
    ((UltraGridBase) this.dgFees).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance17;
    appearance18.BackColor = Color.WhiteSmoke;
    appearance18.BorderColor = Color.Silver;
    scrollBarLook2.ButtonAppearance = (AppearanceBase) appearance18;
    appearance19.BackColor = Color.White;
    scrollBarLook2.TrackAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.dgFees).DisplayLayout.ScrollBarLook = scrollBarLook2;
    ((Control) this.dgFees).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.dgFees).Location = new Point(733, 65);
    ((Control) this.dgFees).Name = "dgFees";
    ((Control) this.dgFees).Size = new Size(377, 567);
    ((Control) this.dgFees).TabIndex = 480;
    ((Control) this.dgFees).Text = "Available Fees";
    ((UltraControlBase) this.dgFees).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.dgFees).UseOsThemes = (DefaultableBoolean) 2;
    this.lnkSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAll.AutoSize = true;
    this.lnkSelectAll.Location = new Point(12, 587);
    this.lnkSelectAll.Name = "lnkSelectAll";
    this.lnkSelectAll.Size = new Size(128 /*0x80*/, 13);
    this.lnkSelectAll.TabIndex = 481;
    this.lnkSelectAll.TabStop = true;
    this.lnkSelectAll.Text = "Select All Company/Lines";
    this.lnkDeSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAll.AutoSize = true;
    this.lnkDeSelectAll.Location = new Point(12, 619);
    this.lnkDeSelectAll.Name = "lnkDeSelectAll";
    this.lnkDeSelectAll.Size = new Size(145, 13);
    this.lnkDeSelectAll.TabIndex = 482;
    this.lnkDeSelectAll.TabStop = true;
    this.lnkDeSelectAll.Text = "De-Select All Company/Lines";
    ((Control) this.btnCopy).Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    appearance20.FontData.BoldAsString = "True";
    appearance20.ForeColor = Color.Blue;
    appearance20.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance22.Image"));
    ((ControlBase) this.btnCopy).Appearance = (AppearanceBase) appearance20;
    ((Control) this.btnCopy).Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    ((ControlBase) this.btnCopy).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnCopy).Location = new Point(641, 587);
    ((Control) this.btnCopy).Name = "btnCopy";
    ((ControlBase) this.btnCopy).Padding = new Size(5, 0);
    ((Control) this.btnCopy).Size = new Size(76, 40);
    ((Control) this.btnCopy).TabIndex = 483;
    ((Control) this.btnCopy).Tag = (object) "";
    ((ControlBase) this.btnCopy).Text = "Copy";
    this.btnCopy.UseOSThemes = (DefaultableBoolean) 2;
    this.lnkSelectAllChild.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkSelectAllChild.AutoSize = true;
    this.lnkSelectAllChild.Location = new Point(183, 587);
    this.lnkSelectAllChild.Name = "lnkSelectAllChild";
    this.lnkSelectAllChild.Size = new Size(154, 13);
    this.lnkSelectAllChild.TabIndex = 484;
    this.lnkSelectAllChild.TabStop = true;
    this.lnkSelectAllChild.Text = "Select All Child Company/Lines";
    this.lnkDeSelectChild.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectChild.AutoSize = true;
    this.lnkDeSelectChild.Location = new Point(183, 619);
    this.lnkDeSelectChild.Name = "lnkDeSelectChild";
    this.lnkDeSelectChild.Size = new Size(171, 13);
    this.lnkDeSelectChild.TabIndex = 485;
    this.lnkDeSelectChild.TabStop = true;
    this.lnkDeSelectChild.Text = "De-Select All Child Company/Lines";
    this.lnkExpand.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkExpand.AutoSize = true;
    this.lnkExpand.Location = new Point(376, 587);
    this.lnkExpand.Name = "lnkExpand";
    this.lnkExpand.Size = new Size(57, 13);
    this.lnkExpand.TabIndex = 486;
    this.lnkExpand.TabStop = true;
    this.lnkExpand.Text = "Expand All";
    this.lnkCollapse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkCollapse.AutoSize = true;
    this.lnkCollapse.Location = new Point(376, 619);
    this.lnkCollapse.Name = "lnkCollapse";
    this.lnkCollapse.Size = new Size(61, 13);
    this.lnkCollapse.TabIndex = 487;
    this.lnkCollapse.TabStop = true;
    this.lnkCollapse.Text = "Collapse All";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(1122, 641);
    this.Controls.Add((Control) this.lnkCollapse);
    this.Controls.Add((Control) this.lnkExpand);
    this.Controls.Add((Control) this.lnkDeSelectChild);
    this.Controls.Add((Control) this.lnkSelectAllChild);
    this.Controls.Add((Control) this.btnCopy);
    this.Controls.Add((Control) this.lnkDeSelectAll);
    this.Controls.Add((Control) this.lnkSelectAll);
    this.Controls.Add((Control) this.dgFees);
    this.Controls.Add((Control) this.panelPleaseWait);
    this.Controls.Add((Control) this.dgView);
    this.Controls.Add((Control) this.lnkApplyFilter);
    this.Controls.Add((Control) this.Label26);
    this.Controls.Add((Control) this.Label25);
    this.Controls.Add((Control) this.Label24);
    this.Controls.Add((Control) this.cbStateFilter);
    this.Controls.Add((Control) this.cbCompanyFilter);
    this.Controls.Add((Control) this.cbLineFilter);
    this.Controls.Add((Control) this.txtCompanyLine);
    this.Controls.Add((Control) this.lblCompanyLine);
    this.Name = nameof (FormCopyFees);
    this.Text = "Copy Fees Across Company / Lines";
    ((ISupportInitialize) this.cbStateFilter).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.cbCompanyFilter).EndInit();
    ((ISupportInitialize) this.cbLineFilter).EndInit();
    ((ISupportInitialize) this.dgView).EndInit();
    ((ISupportInitialize) this.panelPleaseWait).EndInit();
    ((Control) this.panelPleaseWait).ResumeLayout(false);
    ((Control) this.panelPleaseWait).PerformLayout();
    ((ISupportInitialize) this.PictureBox1).EndInit();
    ((ISupportInitialize) this.dgFees).EndInit();
    ((ISupportInitialize) this.btnCopy).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  [field: AccessedThroughProperty("txtCompanyLine")]
  internal virtual Label txtCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("lblCompanyLine")]
  internal virtual Label lblCompanyLine { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  [field: AccessedThroughProperty("dgView")]
  private virtual UltraGrid dgView { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsCopyFee ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("panelPleaseWait")]
  protected virtual UltraGroupBox panelPleaseWait { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label27")]
  protected virtual Label Label27 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("PictureBox1")]
  protected virtual PictureBox PictureBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("dgFees")]
  private virtual UltraGrid dgFees { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

  internal virtual LinkLabel lnkSelectAllChild
  {
    get => this._lnkSelectAllChild;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkSelectAllChild_LinkClicked);
      LinkLabel lnkSelectAllChild1 = this._lnkSelectAllChild;
      if (lnkSelectAllChild1 != null)
        lnkSelectAllChild1.LinkClicked -= clickedEventHandler;
      this._lnkSelectAllChild = value;
      LinkLabel lnkSelectAllChild2 = this._lnkSelectAllChild;
      if (lnkSelectAllChild2 == null)
        return;
      lnkSelectAllChild2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeSelectChild
  {
    get => this._lnkDeSelectChild;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectChild_LinkClicked);
      LinkLabel lnkDeSelectChild1 = this._lnkDeSelectChild;
      if (lnkDeSelectChild1 != null)
        lnkDeSelectChild1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectChild = value;
      LinkLabel lnkDeSelectChild2 = this._lnkDeSelectChild;
      if (lnkDeSelectChild2 == null)
        return;
      lnkDeSelectChild2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkExpand
  {
    get => this._lnkExpand;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkExpand_LinkClicked);
      LinkLabel lnkExpand1 = this._lnkExpand;
      if (lnkExpand1 != null)
        lnkExpand1.LinkClicked -= clickedEventHandler;
      this._lnkExpand = value;
      LinkLabel lnkExpand2 = this._lnkExpand;
      if (lnkExpand2 == null)
        return;
      lnkExpand2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkCollapse
  {
    get => this._lnkCollapse;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkCollapse_LinkClicked);
      LinkLabel lnkCollapse1 = this._lnkCollapse;
      if (lnkCollapse1 != null)
        lnkCollapse1.LinkClicked -= clickedEventHandler;
      this._lnkCollapse = value;
      LinkLabel lnkCollapse2 = this._lnkCollapse;
      if (lnkCollapse2 == null)
        return;
      lnkCollapse2.LinkClicked += clickedEventHandler;
    }
  }

  public FormCopyFees(Guid currentCompanyLineGuid, List<int> feeList)
  {
    this.Load += new EventHandler(this.FormCopyFees_Load);
    this._companyFeeIDsList = new List<int>();
    this.InitializeComponent();
    this._companyFeeIDsList = feeList;
    this._currentCompanyLineID = new CompanyLine(currentCompanyLineGuid).CompanyLineID;
  }

  private void SetComboBoxesEnabledProperty(bool enableValue)
  {
    ((Control) this.cbCompanyFilter).Enabled = enableValue;
    ((Control) this.cbStateFilter).Enabled = enableValue;
    ((Control) this.cbLineFilter).Enabled = enableValue;
  }

  private void lnkApplyFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
      DefaultDatabase.LoadDataSet((DataSet) this.ds, strArray, "spSearchCopyFeesCompanyLines", new object[8]
      {
        (object) "@companyLocationGuid",
        obj1,
        (object) "@lineGuid",
        obj2,
        (object) "@stateID",
        obj3,
        (object) "@CurrentCompanyLineID",
        (object) this._currentCompanyLineID
      });
    }
    finally
    {
      this.SetComboBoxesEnabledProperty(true);
    }
  }

  private bool IsvalidCopy()
  {
    bool flag1;
    if (((UltraGridBase) this.dgView).Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("No company/line row(s) available in the grid.", "No Row(s) Available", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
        foreach (UltraGridRow row in ((UltraGridBase) this.dgFees).Rows)
        {
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(row.Cells["CopyFee"].Value)) && Conversions.ToBoolean(row.Cells["CopyFee"].Value))
          {
            flag3 = true;
            break;
          }
        }
        if (!flag3)
        {
          int num = (int) MessageBox.Show("In order to continue, at least one fee must be selected to 'Copy' over.", "No Fee Selected", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
    if (DialogResult.Yes != MessageBox.Show("Continue and copy over the selected fee(s)?", "Copy Fees", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
      return;
    try
    {
      ((Control) this.panelPleaseWait).Visible = true;
      ((UltraControlBase) this.panelPleaseWait).Refresh();
      string str1 = string.Empty;
      string str2 = string.Empty;
      RowEnumerator enumerator1 = ((UltraGridBase) this.dgFees).Rows.GetEnumerator();
      while (enumerator1.MoveNext())
      {
        UltraGridRow current = enumerator1.Current;
        if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(current.Cells["CopyFee"].Value)) && Conversions.ToBoolean(current.Cells["CopyFee"].Value))
        {
          str1 = $"{str1}{current.Cells["ChargeCode"].Value.ToString()},";
          str2 = $"{str2}{current.Cells["CompanyFeeID"].Value.ToString()},";
        }
      }
      try
      {
        foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
        {
          ((UltraControlBase) this.panelPleaseWait).Refresh();
          if (!Utility.IsNull(RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["CopyOver"].Value)) && Conversions.ToBoolean(ultraGridRow.Cells["CopyOver"].Value))
            DefaultDatabase.ExecuteNonQuery("spCopyCompanyLineFees", new object[8]
            {
              (object) "@CurrentCompanyLineID",
              (object) this._currentCompanyLineID,
              (object) "@DestinationCompanyLineID",
              ultraGridRow.Cells["CompanyLineID"].Value,
              (object) "@ChargeCodeIDs",
              (object) str1,
              (object) "@CompanyFeeIDs",
              (object) str2
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
      ((Control) this.panelPleaseWait).Visible = false;
    }
    int num = (int) MessageBox.Show("Fee(s) copied over sucessfully.", "Copied Successfully", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.Close();
  }

  private void lnkDeSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(false);
  }

  private void lnkSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(true);
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

  private void FormCopyFees_Load(object sender, EventArgs e)
  {
    this.txtCompanyLine.Text = new CompanyLine(this._currentCompanyLineID).CompanyLineState;
    dsCopyFee.lstStatesRow row1 = this.ds.lstStates.NewlstStatesRow();
    row1.StateID = string.Empty;
    row1.State = "ANY";
    this.ds.lstStates.AddlstStatesRow(row1);
    dsCopyFee.lstLinesRow row2 = this.ds.lstLines.NewlstLinesRow();
    row2.LineGuid = Guid.Empty;
    row2.LineName = "ANY";
    this.ds.lstLines.AddlstLinesRow(row2);
    dsCopyFee.tblCompanyLocationsRow row3 = this.ds.tblCompanyLocations.NewtblCompanyLocationsRow();
    row3.CompanyLocationGuid = Guid.Empty;
    row3.Name = "ANY";
    this.ds.tblCompanyLocations.AddtblCompanyLocationsRow(row3);
    string str = string.Empty;
    try
    {
      foreach (int companyFeeIds in this._companyFeeIDsList)
        str = $"{str}{companyFeeIds.ToString()},";
    }
    finally
    {
      List<int>.Enumerator enumerator;
      enumerator.Dispose();
    }
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[4]
    {
      "lstLines",
      "lstStates",
      "tblCompanyLocations",
      "dtFees"
    }, "spGetCopyFeesData", new object[4]
    {
      (object) "@CurrentCompanyLineID",
      (object) this._currentCompanyLineID,
      (object) "@CompanyFeeIDs",
      (object) str
    });
  }

  private void lnkSelectAllChild_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(true, 1);
  }

  private void lnkDeSelectChild_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelection(false, 1);
  }

  private void SetGridSelection(bool selectionValue, int bandIndex)
  {
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.dgView).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (ultraGridRow.Band.Index == bandIndex)
          ultraGridRow.Cells["CopyOver"].Value = (object) selectionValue;
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

  private void lnkExpand_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((UltraGridBase) this.dgView).Rows.ExpandAll(true);
  }

  private void lnkCollapse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((UltraGridBase) this.dgView).Rows.CollapseAll(true);
  }
}
