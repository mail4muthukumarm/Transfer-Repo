// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.FormBulkProducerUnderwriterAssign
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
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
public class FormBulkProducerUnderwriterAssign : Form
{
  private IContainer components;

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
    UltraGridBand ultraGridBand1 = new UltraGridBand("tblProducers", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ProducerGUID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ProducerName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("tblProducers_tblProducerLocations");
    UltraGridBand ultraGridBand2 = new UltraGridBand("tblProducers_tblProducerLocations", 0);
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ProducerLocationGUID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("LocationName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("Selected");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("ProducerGUID");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance12 = new Appearance();
    this.btnSave = new MGAButton();
    this.ug = new UltraGrid();
    this.ds = new dsBulkUnderwriterProducerAss();
    this.Label1 = new Label();
    this.err = new ErrorProvider(this.components);
    this.txtSearch = new TextBox();
    this.Label2 = new Label();
    this.btnSearch = new MGAButton();
    this.cboUnderwriter = new MGASimpleComboBox();
    this.Label3 = new Label();
    this.cboState = new MGASimpleComboBox();
    this.lnkProducersSelectAll = new LinkLabel();
    this.lnkLocationsSelectAll = new LinkLabel();
    this.lnkDeSelectAllProducers = new LinkLabel();
    this.lnkDeSelectAllLocations = new LinkLabel();
    this.lnkCollapse = new LinkLabel();
    this.lnkExpandAll = new LinkLabel();
    ((ISupportInitialize) this.btnSave).BeginInit();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.err).BeginInit();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.cboUnderwriter).BeginInit();
    ((ISupportInitialize) this.cboState).BeginInit();
    this.SuspendLayout();
    ((Control) this.btnSave).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSave).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.btnSave).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSave).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSave).Location = new Point(640, 666);
    ((Control) this.btnSave).Name = "btnSave";
    ((Control) this.btnSave).Size = new Size(40, 40);
    ((Control) this.btnSave).TabIndex = 24;
    this.btnSave.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ug).DataMember = "tblProducers";
    ((UltraGridBase) this.ug).DataSource = (object) this.ds;
    appearance2.BackColor = Color.WhiteSmoke;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Appearance = (AppearanceBase) appearance2;
    appearance3.BackColor = Color.WhiteSmoke;
    appearance3.BorderColor = Color.WhiteSmoke;
    appearance3.FontData.UnderlineAsString = "True";
    appearance3.ForeColor = Color.Blue;
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.ButtonAppearance = (AppearanceBase) appearance3;
    ((SpecialBoxBase) ((UltraGridBase) this.ug).DisplayLayout.AddNewBox).Prompt = " ";
    ((UltraGridBase) this.ug).DisplayLayout.AddNewBox.Style = (AddNewBoxStyle) 1;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand1.AddButtonCaption = "Add ... Producer / Underwriters";
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 328;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Producer Name";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 547;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Select";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 100;
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridBand1.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ultraGridColumn5.Header.VisiblePosition = 0;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 243;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Location";
    ultraGridColumn6.Header.VisiblePosition = 1;
    ultraGridColumn6.Width = 554;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "Select";
    ultraGridColumn7.Header.VisiblePosition = 2;
    ultraGridColumn7.Width = 74;
    ultraGridColumn8.Header.VisiblePosition = 3;
    ultraGridColumn8.Hidden = true;
    ultraGridColumn8.Width = 392;
    ultraGridBand2.Columns.AddRange(new object[4]
    {
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance5.BackColor = Color.LightSteelBlue;
    appearance5.FontData.SizeInPoints = 10f;
    appearance5.ForeColor = Color.Navy;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance5;
    appearance6.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance6.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    appearance7.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance7;
    appearance8.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 10;
    appearance9.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance9;
    appearance10.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance11.BackColor = Color.Transparent;
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance11;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.ug).Location = new Point(12, 93);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(668, 560);
    ((Control) this.ug).TabIndex = 25;
    ((Control) this.ug).Text = "Bulk Underwriter Producer / Location Assignment";
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsBulkUnderwriterProducerAss";
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    this.Label1.AutoSize = true;
    this.Label1.Location = new Point(9, 9);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(103, 13);
    this.Label1.TabIndex = 27;
    this.Label1.Text = "Choose Underwriter:";
    this.err.ContainerControl = (ContainerControl) this;
    this.txtSearch.Location = new Point(182, 67);
    this.txtSearch.MaxLength = 50;
    this.txtSearch.Name = "txtSearch";
    this.txtSearch.Size = new Size(253, 20);
    this.txtSearch.TabIndex = 52;
    this.Label2.AutoSize = true;
    this.Label2.Location = new Point(9, 71);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(160 /*0xA0*/, 13);
    this.Label2.TabIndex = 53;
    this.Label2.Text = "Producer/Location Search Text:";
    appearance12.ImageHAlign = (HAlign) 2;
    appearance12.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance12;
    ((ControlBase) this.btnSearch).ImageSize = new Size(24, 24);
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(495, 30);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((Control) this.btnSearch).Size = new Size(40, 40);
    ((Control) this.btnSearch).TabIndex = 54;
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.cboUnderwriter.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboUnderwriter).DataMember = "tblUsers";
    ((UltraGridBase) this.cboUnderwriter).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboUnderwriter).DisplayMember = "Name_LastFirst";
    this.cboUnderwriter.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboUnderwriter).Location = new Point(182, 5);
    this.cboUnderwriter.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboUnderwriter).Name = "cboUnderwriter";
    ((Control) this.cboUnderwriter).Size = new Size(253, 20);
    ((Control) this.cboUnderwriter).TabIndex = 26;
    ((UltraControlBase) this.cboUnderwriter).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboUnderwriter).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboUnderwriter).ValueMember = "UserGUID";
    this.Label3.AutoSize = true;
    this.Label3.Location = new Point(9, 40);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(79, 13);
    this.Label3.TabIndex = 55;
    this.Label3.Text = "Location State:";
    this.cboState.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.cboState).DataMember = "lstStates";
    ((UltraGridBase) this.cboState).DataSource = (object) this.ds;
    ((UltraDropDownBase) this.cboState).DisplayMember = "State";
    this.cboState.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.cboState).Location = new Point(182, 36);
    this.cboState.MGAStyle = MGAStyles.Blue;
    ((Control) this.cboState).Name = "cboState";
    ((Control) this.cboState).Size = new Size(253, 20);
    ((Control) this.cboState).TabIndex = 56;
    ((UltraControlBase) this.cboState).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.cboState).UseOsThemes = (DefaultableBoolean) 2;
    ((UltraDropDownBase) this.cboState).ValueMember = "StateID";
    this.lnkProducersSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkProducersSelectAll.AutoSize = true;
    this.lnkProducersSelectAll.Location = new Point(13, 666);
    this.lnkProducersSelectAll.Name = "lnkProducersSelectAll";
    this.lnkProducersSelectAll.Size = new Size(111, 13);
    this.lnkProducersSelectAll.TabIndex = 57;
    this.lnkProducersSelectAll.TabStop = true;
    this.lnkProducersSelectAll.Text = "Producers  - Select All";
    this.lnkLocationsSelectAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkLocationsSelectAll.AutoSize = true;
    this.lnkLocationsSelectAll.Location = new Point(13, 689);
    this.lnkLocationsSelectAll.Name = "lnkLocationsSelectAll";
    this.lnkLocationsSelectAll.Size = new Size(109, 13);
    this.lnkLocationsSelectAll.TabIndex = 58;
    this.lnkLocationsSelectAll.TabStop = true;
    this.lnkLocationsSelectAll.Text = "Locations  - Select All";
    this.lnkDeSelectAllProducers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAllProducers.AutoSize = true;
    this.lnkDeSelectAllProducers.Location = new Point(128 /*0x80*/, 666);
    this.lnkDeSelectAllProducers.Name = "lnkDeSelectAllProducers";
    this.lnkDeSelectAllProducers.Size = new Size(68, 13);
    this.lnkDeSelectAllProducers.TabIndex = 59;
    this.lnkDeSelectAllProducers.TabStop = true;
    this.lnkDeSelectAllProducers.Text = "De-Select All";
    this.lnkDeSelectAllLocations.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkDeSelectAllLocations.AutoSize = true;
    this.lnkDeSelectAllLocations.Location = new Point(128 /*0x80*/, 689);
    this.lnkDeSelectAllLocations.Name = "lnkDeSelectAllLocations";
    this.lnkDeSelectAllLocations.Size = new Size(68, 13);
    this.lnkDeSelectAllLocations.TabIndex = 60;
    this.lnkDeSelectAllLocations.TabStop = true;
    this.lnkDeSelectAllLocations.Text = "De-Select All";
    this.lnkCollapse.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lnkCollapse.AutoSize = true;
    this.lnkCollapse.Location = new Point(227, 666);
    this.lnkCollapse.Name = "lnkCollapse";
    this.lnkCollapse.Size = new Size(77, 13);
    this.lnkCollapse.TabIndex = 61;
    this.lnkCollapse.TabStop = true;
    this.lnkCollapse.Text = "Collapse Rows";
    this.lnkExpandAll.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.lnkExpandAll.AutoSize = true;
    this.lnkExpandAll.Location = new Point(227, 692);
    this.lnkExpandAll.Name = "lnkExpandAll";
    this.lnkExpandAll.Size = new Size(73, 13);
    this.lnkExpandAll.TabIndex = 62;
    this.lnkExpandAll.TabStop = true;
    this.lnkExpandAll.Text = "Expand Rows";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.White;
    this.ClientSize = new Size(692, 714);
    this.Controls.Add((Control) this.lnkExpandAll);
    this.Controls.Add((Control) this.lnkCollapse);
    this.Controls.Add((Control) this.lnkDeSelectAllLocations);
    this.Controls.Add((Control) this.lnkDeSelectAllProducers);
    this.Controls.Add((Control) this.lnkLocationsSelectAll);
    this.Controls.Add((Control) this.lnkProducersSelectAll);
    this.Controls.Add((Control) this.cboState);
    this.Controls.Add((Control) this.Label3);
    this.Controls.Add((Control) this.btnSearch);
    this.Controls.Add((Control) this.Label2);
    this.Controls.Add((Control) this.txtSearch);
    this.Controls.Add((Control) this.Label1);
    this.Controls.Add((Control) this.cboUnderwriter);
    this.Controls.Add((Control) this.ug);
    this.Controls.Add((Control) this.btnSave);
    this.Name = nameof (FormBulkProducerUnderwriterAssign);
    this.Text = "Bulk Underwriter/Producer Assignment";
    ((ISupportInitialize) this.btnSave).EndInit();
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.err).EndInit();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.cboUnderwriter).EndInit();
    ((ISupportInitialize) this.cboState).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  internal virtual MGAButton btnSave
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

  [field: AccessedThroughProperty("ug")]
  internal virtual UltraGrid ug { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("ds")]
  internal virtual dsBulkUnderwriterProducerAss ds { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboUnderwriter")]
  protected virtual MGASimpleComboBox cboUnderwriter { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label1")]
  internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("err")]
  internal virtual ErrorProvider err { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual MGAButton btnSearch
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

  [field: AccessedThroughProperty("Label2")]
  internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("txtSearch")]
  internal virtual TextBox txtSearch { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("cboState")]
  protected virtual MGASimpleComboBox cboState { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkDeSelectAllLocations
  {
    get => this._lnkDeSelectAllLocations;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAllLocations_LinkClicked);
      LinkLabel selectAllLocations1 = this._lnkDeSelectAllLocations;
      if (selectAllLocations1 != null)
        selectAllLocations1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAllLocations = value;
      LinkLabel selectAllLocations2 = this._lnkDeSelectAllLocations;
      if (selectAllLocations2 == null)
        return;
      selectAllLocations2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkDeSelectAllProducers
  {
    get => this._lnkDeSelectAllProducers;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkDeSelectAllProducers_LinkClicked);
      LinkLabel selectAllProducers1 = this._lnkDeSelectAllProducers;
      if (selectAllProducers1 != null)
        selectAllProducers1.LinkClicked -= clickedEventHandler;
      this._lnkDeSelectAllProducers = value;
      LinkLabel selectAllProducers2 = this._lnkDeSelectAllProducers;
      if (selectAllProducers2 == null)
        return;
      selectAllProducers2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkLocationsSelectAll
  {
    get => this._lnkLocationsSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkLocationsSelectAll_LinkClicked);
      LinkLabel locationsSelectAll1 = this._lnkLocationsSelectAll;
      if (locationsSelectAll1 != null)
        locationsSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkLocationsSelectAll = value;
      LinkLabel locationsSelectAll2 = this._lnkLocationsSelectAll;
      if (locationsSelectAll2 == null)
        return;
      locationsSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkProducersSelectAll
  {
    get => this._lnkProducersSelectAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkProducersSelectAll_LinkClicked);
      LinkLabel producersSelectAll1 = this._lnkProducersSelectAll;
      if (producersSelectAll1 != null)
        producersSelectAll1.LinkClicked -= clickedEventHandler;
      this._lnkProducersSelectAll = value;
      LinkLabel producersSelectAll2 = this._lnkProducersSelectAll;
      if (producersSelectAll2 == null)
        return;
      producersSelectAll2.LinkClicked += clickedEventHandler;
    }
  }

  internal virtual LinkLabel lnkExpandAll
  {
    get => this._lnkExpandAll;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkExpandAll_LinkClicked);
      LinkLabel lnkExpandAll1 = this._lnkExpandAll;
      if (lnkExpandAll1 != null)
        lnkExpandAll1.LinkClicked -= clickedEventHandler;
      this._lnkExpandAll = value;
      LinkLabel lnkExpandAll2 = this._lnkExpandAll;
      if (lnkExpandAll2 == null)
        return;
      lnkExpandAll2.LinkClicked += clickedEventHandler;
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

  public FormBulkProducerUnderwriterAssign()
  {
    this.Load += new EventHandler(this.FormBulkProducerUnderwriterAssign_Load);
    this.InitializeComponent();
  }

  private void FormBulkProducerUnderwriterAssign_Load(object sender, EventArgs e)
  {
    ((ControlBase) this.btnSave).Appearance.Image = (object) ImageCache.Instance.Save;
    ((ControlBase) this.btnSearch).Appearance.Image = (object) ImageCache.Instance.Search;
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "tblUsers"
    }, CommandType.Text, "SELECT UserGuid, Name_LastFirst FROM tblUsers WITH (NOLOCK) ORDER BY Name_LastFirst");
    DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[1]
    {
      "lstStates"
    }, CommandType.Text, "SELECT  StateID, State FROM lstStates ORDER BY State");
  }

  private bool IsAnyRowSelected()
  {
    bool flag;
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ug).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (Conversions.ToBoolean(ultraGridRow.Cells["Selected"].Value))
        {
          flag = true;
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    flag = false;
label_8:
    return flag;
  }

  private dsBulkUnderwriterProducerAss.tblProducersRow SingleEntitySelected()
  {
    dsBulkUnderwriterProducerAss.tblProducersRow tblProducersRow;
    try
    {
      foreach (dsBulkUnderwriterProducerAss.tblProducerLocationsRow row in this.ds.tblProducerLocations.Rows)
      {
        if (row.Selected && this.ds.tblProducers.FindByProducerGUID(row.ProducerGUID).Selected)
        {
          tblProducersRow = this.ds.tblProducers.FindByProducerGUID(row.ProducerGUID);
          goto label_8;
        }
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    tblProducersRow = (dsBulkUnderwriterProducerAss.tblProducersRow) null;
label_8:
    return tblProducersRow;
  }

  private bool ValidData()
  {
    bool flag = true;
    this.err.SetError((Control) this.cboUnderwriter, string.Empty);
    if (string.IsNullOrEmpty(this.cboUnderwriter.Text))
    {
      flag = false;
      this.err.SetError((Control) this.cboUnderwriter, "Please select an underwriter");
    }
    return flag;
  }

  private bool ValidSearch()
  {
    bool flag = true;
    this.err.SetError((Control) this.txtSearch, string.Empty);
    this.err.SetError((Control) this.cboUnderwriter, string.Empty);
    if (string.IsNullOrEmpty(this.cboUnderwriter.Text))
    {
      flag = false;
      this.err.SetError((Control) this.cboUnderwriter, "Please select an underwriter");
    }
    return flag;
  }

  private void btnSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidData())
      return;
    if (!this.IsAnyRowSelected())
    {
      int num1 = (int) MessageBox.Show("No row is selected.", "No Selected Rows", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      dsBulkUnderwriterProducerAss.tblProducersRow tblProducersRow = this.SingleEntitySelected();
      if (tblProducersRow != null)
      {
        int num2 = (int) MessageBox.Show("Both producer and location rows are selected.\n\nSee Producer  - " + tblProducersRow.ProducerName, "Cannot Select Both Producer and Location Rows", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
      }
      else
      {
        try
        {
          this.Cursor = MgaCursors.Working;
          try
          {
            foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ug).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
            {
              object obj1 = (object) null;
              object obj2 = (object) null;
              if (Conversions.ToBoolean(ultraGridRow.Cells["Selected"].Value))
              {
                if (ultraGridRow.Band.Index == 0)
                  obj1 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["ProducerGUID"].Value);
                else
                  obj2 = RuntimeHelpers.GetObjectValue(ultraGridRow.Cells["ProducerLocationGUID"].Value);
                DefaultDatabase.ExecuteNonQuery("dbo.spSaveBulkUnderwriterProducerAssignment", new object[6]
                {
                  (object) "@UnderwriterGUID",
                  this.cboUnderwriter.Value,
                  (object) "@ProducerLocationGUID",
                  obj2,
                  (object) "@ProducerGUID",
                  obj1
                });
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
        finally
        {
          this.Cursor = MgaCursors.Default;
        }
      }
    }
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (!this.ValidSearch())
      return;
    try
    {
      ((Control) this.btnSave).Enabled = false;
      ((Control) this.btnSearch).Enabled = false;
      this.ds.tblProducerLocations.Clear();
      this.ds.tblProducers.Clear();
      this.Cursor = MgaCursors.WaitCursor;
      object obj = (object) null;
      if (this.txtSearch.Text.Replace(" ", string.Empty).Length > 0)
        obj = (object) this.txtSearch.Text;
      DefaultDatabase.LoadDataSet((DataSet) this.ds, new string[2]
      {
        "tblProducers",
        "tblProducerLocations"
      }, "dbo.spSearchBulkUnderwriterProducerAssignment", new object[6]
      {
        (object) "@UnderwriterGUID",
        this.cboUnderwriter.Value,
        (object) "@SearchText",
        obj,
        (object) "@StateID",
        this.cboState.Value
      });
      this.ds.AcceptChanges();
    }
    finally
    {
      ((Control) this.btnSave).Enabled = true;
      ((Control) this.btnSearch).Enabled = true;
      this.Cursor = MgaCursors.Default;
    }
    ((UltraControlBase) this.ug).Update();
  }

  private void SetGridSelectedValue(
    bool selected,
    FormBulkProducerUnderwriterAssign.ProducerType type)
  {
    try
    {
      foreach (UltraGridRow ultraGridRow in ((UltraGridBase) this.ug).Rows.GetRowEnumerator((GridRowType) 1, (UltraGridBand) null, (UltraGridBand) null))
      {
        if (type == FormBulkProducerUnderwriterAssign.ProducerType.Producer)
        {
          if (ultraGridRow.Band.Index == 0)
            ultraGridRow.Cells["Selected"].Value = (object) selected;
        }
        else if (ultraGridRow.Band.Index == 1)
          ultraGridRow.Cells["Selected"].Value = (object) selected;
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
  }

  private void lnkProducersSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelectedValue(true, FormBulkProducerUnderwriterAssign.ProducerType.Producer);
  }

  private void lnkDeSelectAllProducers_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelectedValue(false, FormBulkProducerUnderwriterAssign.ProducerType.Producer);
  }

  private void lnkLocationsSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelectedValue(true, FormBulkProducerUnderwriterAssign.ProducerType.Location);
  }

  private void lnkDeSelectAllLocations_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    this.SetGridSelectedValue(false, FormBulkProducerUnderwriterAssign.ProducerType.Location);
  }

  private void lnkCollapse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((UltraGridBase) this.ug).Rows.CollapseAll(true);
  }

  private void lnkExpandAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ((UltraGridBase) this.ug).Rows.ExpandAll(true);
  }

  private enum ProducerType
  {
    Producer,
    Location,
  }
}
