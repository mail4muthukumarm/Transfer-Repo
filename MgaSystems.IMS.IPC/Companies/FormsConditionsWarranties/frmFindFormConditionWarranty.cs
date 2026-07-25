// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties.frmFindFormConditionWarranty
// Assembly: MgaSystems.IMS.IPC, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: F22CEF02-8C0F-420D-8344-A8A010CA7834
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.IPC.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinProgressBar;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.InfragisticsExtensions.Editors;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.InsuredsProducersCompanies.Companies.FormsConditionsWarranties;

public class frmFindFormConditionWarranty : Form
{
  private IContainer components;
  private MGAGroupBox MgaGroupBox1;
  private Label Label1;
  private SqlCommand SqlSelectCommand1;
  private SqlDataAdapter da;
  private SqlConnection cn;
  private dsFindFormConditionWarranty ds;
  private UltraProgressBar progress;
  private dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable _dt;
  private int _companyLineID;
  private MemoryStream _gridLayout;
  private bool _doneLoad;
  private Thread _fillThread;

  private virtual MGAButton btnSearch
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

  private virtual MGAButton btnSelect
  {
    get => this._btnSelect;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSelect_Click);
      MGAButton btnSelect1 = this._btnSelect;
      if (btnSelect1 != null)
        ((Control) btnSelect1).Click -= eventHandler;
      this._btnSelect = value;
      MGAButton btnSelect2 = this._btnSelect;
      if (btnSelect2 == null)
        return;
      ((Control) btnSelect2).Click += eventHandler;
    }
  }

  private virtual MGATextBox txtSearch
  {
    get => this._txtSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      KeyEventHandler keyEventHandler = new KeyEventHandler(this.txtSearch_KeyDown);
      MGATextBox txtSearch1 = this._txtSearch;
      if (txtSearch1 != null)
        ((Control) txtSearch1).KeyDown -= keyEventHandler;
      this._txtSearch = value;
      MGATextBox txtSearch2 = this._txtSearch;
      if (txtSearch2 == null)
        return;
      ((Control) txtSearch2).KeyDown += keyEventHandler;
    }
  }

  private virtual UltraGrid ug
  {
    get => this._ug;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.ug_DoubleClick);
      UltraGrid ug1 = this._ug;
      if (ug1 != null)
        ((Control) ug1).DoubleClick -= eventHandler;
      this._ug = value;
      UltraGrid ug2 = this._ug;
      if (ug2 == null)
        return;
      ((Control) ug2).DoubleClick += eventHandler;
    }
  }

  private virtual MGACheckBox chkForms
  {
    get => this._chkForms;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Filter_CheckedChanged);
      MGACheckBox chkForms1 = this._chkForms;
      if (chkForms1 != null)
        ((UltraToggleEditorBase) chkForms1).CheckedChanged -= eventHandler;
      this._chkForms = value;
      MGACheckBox chkForms2 = this._chkForms;
      if (chkForms2 == null)
        return;
      ((UltraToggleEditorBase) chkForms2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkConditions
  {
    get => this._chkConditions;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Filter_CheckedChanged);
      MGACheckBox chkConditions1 = this._chkConditions;
      if (chkConditions1 != null)
        ((UltraToggleEditorBase) chkConditions1).CheckedChanged -= eventHandler;
      this._chkConditions = value;
      MGACheckBox chkConditions2 = this._chkConditions;
      if (chkConditions2 == null)
        return;
      ((UltraToggleEditorBase) chkConditions2).CheckedChanged += eventHandler;
    }
  }

  private virtual MGACheckBox chkWarranties
  {
    get => this._chkWarranties;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.Filter_CheckedChanged);
      MGACheckBox chkWarranties1 = this._chkWarranties;
      if (chkWarranties1 != null)
        ((UltraToggleEditorBase) chkWarranties1).CheckedChanged -= eventHandler;
      this._chkWarranties = value;
      MGACheckBox chkWarranties2 = this._chkWarranties;
      if (chkWarranties2 == null)
        return;
      ((UltraToggleEditorBase) chkWarranties2).CheckedChanged += eventHandler;
    }
  }

  [field: AccessedThroughProperty("lstAdded")]
  internal virtual MGAListBox lstAdded { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  internal virtual LinkLabel lnkRemove
  {
    get => this._lnkRemove;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      LinkLabelLinkClickedEventHandler clickedEventHandler = new LinkLabelLinkClickedEventHandler(this.lnkRemove_LinkClicked);
      LinkLabel lnkRemove1 = this._lnkRemove;
      if (lnkRemove1 != null)
        lnkRemove1.LinkClicked -= clickedEventHandler;
      this._lnkRemove = value;
      LinkLabel lnkRemove2 = this._lnkRemove;
      if (lnkRemove2 == null)
        return;
      lnkRemove2.LinkClicked += clickedEventHandler;
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
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmFindFormConditionWarranty));
    Appearance appearance8 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("SearchFCW", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ItemID");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ItemType");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("FCW");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("FormNumber");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("AddLink");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("Description");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("TemplateName");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    this.chkForms = new MGACheckBox();
    this.chkConditions = new MGACheckBox();
    this.chkWarranties = new MGACheckBox();
    this.txtSearch = new MGATextBox();
    this.MgaGroupBox1 = new MGAGroupBox();
    this.btnSearch = new MGAButton();
    this.Label1 = new Label();
    this.ug = new UltraGrid();
    this.ds = new dsFindFormConditionWarranty();
    this.btnSelect = new MGAButton();
    this.da = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.cn = new SqlConnection();
    this.progress = new UltraProgressBar();
    this.lstAdded = new MGAListBox();
    this.lnkRemove = new LinkLabel();
    ((ISupportInitialize) this.chkForms).BeginInit();
    ((ISupportInitialize) this.chkConditions).BeginInit();
    ((ISupportInitialize) this.chkWarranties).BeginInit();
    ((ISupportInitialize) this.txtSearch).BeginInit();
    ((ISupportInitialize) this.MgaGroupBox1).BeginInit();
    ((Control) this.MgaGroupBox1).SuspendLayout();
    ((ISupportInitialize) this.btnSearch).BeginInit();
    ((ISupportInitialize) this.ug).BeginInit();
    this.ds.BeginInit();
    ((ISupportInitialize) this.btnSelect).BeginInit();
    ((ISupportInitialize) this.lstAdded).BeginInit();
    this.SuspendLayout();
    appearance1.BorderColor = Color.Gray;
    appearance1.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkForms).Appearance = (AppearanceBase) appearance1;
    ((UltraToggleEditorBase) this.chkForms).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkForms).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkForms).Checked = true;
    ((UltraToggleEditorBase) this.chkForms).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkForms).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkForms).Location = new Point(64 /*0x40*/, 32 /*0x20*/);
    ((Control) this.chkForms).Name = "chkForms";
    ((Control) this.chkForms).Size = new Size(56, 20);
    ((Control) this.chkForms).TabIndex = 0;
    ((UltraToggleEditorBase) this.chkForms).Text = "Forms";
    ((UltraControlBase) this.chkForms).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkForms).UseOsThemes = (DefaultableBoolean) 2;
    appearance2.BorderColor = Color.Gray;
    appearance2.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkConditions).Appearance = (AppearanceBase) appearance2;
    ((UltraToggleEditorBase) this.chkConditions).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkConditions).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkConditions).Checked = true;
    ((UltraToggleEditorBase) this.chkConditions).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkConditions).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkConditions).Location = new Point(136, 32 /*0x20*/);
    ((Control) this.chkConditions).Name = "chkConditions";
    ((Control) this.chkConditions).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.chkConditions).TabIndex = 1;
    ((UltraToggleEditorBase) this.chkConditions).Text = "Conditions";
    ((UltraControlBase) this.chkConditions).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkConditions).UseOsThemes = (DefaultableBoolean) 2;
    appearance3.BorderColor = Color.Gray;
    appearance3.ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkWarranties).Appearance = (AppearanceBase) appearance3;
    ((UltraToggleEditorBase) this.chkWarranties).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkWarranties).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkWarranties).Checked = true;
    ((UltraToggleEditorBase) this.chkWarranties).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.chkWarranties).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkWarranties).Location = new Point(224 /*0xE0*/, 32 /*0x20*/);
    ((Control) this.chkWarranties).Name = "chkWarranties";
    ((Control) this.chkWarranties).Size = new Size(80 /*0x50*/, 20);
    ((Control) this.chkWarranties).TabIndex = 2;
    ((UltraToggleEditorBase) this.chkWarranties).Text = "Warranties";
    ((UltraControlBase) this.chkWarranties).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkWarranties).UseOsThemes = (DefaultableBoolean) 2;
    appearance4.BackColor = Color.White;
    appearance4.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance4.ForeColor = Color.Black;
    ((TextEditorControlBase) this.txtSearch).Appearance = (AppearanceBase) appearance4;
    ((TextEditorControlBase) this.txtSearch).BackColor = Color.White;
    ((Control) this.txtSearch).Location = new Point(88, 70);
    this.txtSearch.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSearch).Name = "txtSearch";
    ((Control) this.txtSearch).Size = new Size(176 /*0xB0*/, 20);
    ((Control) this.txtSearch).TabIndex = 3;
    ((UltraControlBase) this.txtSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSearch).UseOsThemes = (DefaultableBoolean) 2;
    appearance5.BackColor = Color.FromArgb(239, 247, 253);
    appearance5.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.MgaGroupBox1.ContentAreaAppearance = (AppearanceBase) appearance5;
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.btnSearch);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.Label1);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.chkConditions);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.chkWarranties);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.chkForms);
    ((Control) this.MgaGroupBox1).Controls.Add((Control) this.txtSearch);
    appearance6.ForeColor = Color.FromArgb(21, 66, 139);
    this.MgaGroupBox1.HeaderAppearance = (AppearanceBase) appearance6;
    ((Control) this.MgaGroupBox1).Location = new Point(136, 8);
    ((Control) this.MgaGroupBox1).Name = "MgaGroupBox1";
    ((Control) this.MgaGroupBox1).Size = new Size(360, 112 /*0x70*/);
    ((Control) this.MgaGroupBox1).TabIndex = 4;
    this.MgaGroupBox1.Text = "Search Criteria";
    this.MgaGroupBox1.ViewStyle = (GroupBoxViewStyle) 2;
    appearance7.BackColor = Color.FromArgb(248, 248, 248);
    appearance7.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance7.BackGradientStyle = (GradientStyle) 2;
    appearance7.BorderColor = Color.DarkGray;
    appearance7.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance6.Image"));
    appearance7.ImageHAlign = (HAlign) 3;
    appearance7.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSearch).Appearance = (AppearanceBase) appearance7;
    ((ControlBase) this.btnSearch).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSearch).Location = new Point(272, 68);
    ((Control) this.btnSearch).Name = "btnSearch";
    ((ControlBase) this.btnSearch).Padding = new Size(5, 0);
    ((Control) this.btnSearch).Size = new Size(80 /*0x50*/, 24);
    ((Control) this.btnSearch).TabIndex = 5;
    ((ControlBase) this.btnSearch).Text = "Search";
    this.btnSearch.UseOSThemes = (DefaultableBoolean) 2;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(16 /*0x10*/, 69);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(64 /*0x40*/, 23);
    this.Label1.TabIndex = 4;
    this.Label1.Text = "Search For:";
    this.Label1.TextAlign = ContentAlignment.MiddleRight;
    ((Control) this.ug).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.SearchFCW;
    appearance8.BackColor = Color.White;
    appearance8.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.ug).DisplayLayout.Appearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.ug).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 52;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Item Type";
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Width = 126;
    ultraGridColumn3.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Name";
    ultraGridColumn3.Header.VisiblePosition = 2;
    ultraGridColumn3.Width = 257;
    ultraGridColumn4.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Form #";
    ultraGridColumn4.Header.VisiblePosition = 3;
    ultraGridColumn4.Width = 122;
    appearance9.FontData.UnderlineAsString = "True";
    appearance9.ForeColor = Color.Blue;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Center";
    ultraGridColumn5.CellAppearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn5.Header).Caption = "";
    ultraGridColumn5.Header.VisiblePosition = 4;
    ultraGridColumn5.Width = 85;
    ultraGridColumn6.Header.VisiblePosition = 5;
    ultraGridColumn6.Width = 95;
    ultraGridColumn7.Header.VisiblePosition = 6;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 70;
    ultraGridBand.Columns.AddRange(new object[7]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7
    });
    ((UltraGridBase) this.ug).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.ug).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    appearance10.BackColor = Color.LightSteelBlue;
    appearance10.FontData.SizeInPoints = 10f;
    appearance10.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.CaptionAppearance = (AppearanceBase) appearance10;
    appearance11.BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    appearance11.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance11.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.ug).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    appearance12.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance12;
    appearance13.BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance13;
    ((UltraGridBase) this.ug).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.ug).DisplayLayout.Override.MaxSelectedRows = 1;
    appearance14.BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance14;
    appearance15.BorderColor = Color.LightGray;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.ug).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    appearance16.BackColor = Color.Transparent;
    appearance16.ForeColor = Color.Black;
    ((UltraGridBase) this.ug).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance16;
    scrollBarLook.ViewStyle = (ScrollBarViewStyle) 3;
    ((UltraGridBase) this.ug).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.ug).Location = new Point(8, 128 /*0x80*/);
    ((Control) this.ug).Name = "ug";
    ((Control) this.ug).Size = new Size(687, 278);
    ((Control) this.ug).TabIndex = 5;
    ((Control) this.ug).Text = "Search Results";
    ((UltraControlBase) this.ug).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.ug).UseOsThemes = (DefaultableBoolean) 2;
    this.ds.DataSetName = "dsFindFormConditionWarranty";
    this.ds.Locale = new CultureInfo("en-US");
    this.ds.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this.btnSelect).Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    appearance17.BackColor = Color.FromArgb(248, 248, 248);
    appearance17.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance17.BackGradientStyle = (GradientStyle) 2;
    appearance17.BorderColor = Color.DarkGray;
    appearance17.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance17.Image"));
    appearance17.ImageHAlign = (HAlign) 3;
    appearance17.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnSelect).Appearance = (AppearanceBase) appearance17;
    ((ControlBase) this.btnSelect).ImageTransparentColor = Color.Magenta;
    ((Control) this.btnSelect).Location = new Point(583, 510);
    ((Control) this.btnSelect).Name = "btnSelect";
    ((ControlBase) this.btnSelect).Padding = new Size(5, 0);
    ((Control) this.btnSelect).Size = new Size(112 /*0x70*/, 32 /*0x20*/);
    ((Control) this.btnSelect).TabIndex = 6;
    ((ControlBase) this.btnSelect).Text = "Add Forms";
    this.btnSelect.UseOSThemes = (DefaultableBoolean) 2;
    this.da.SelectCommand = this.SqlSelectCommand1;
    this.da.TableMappings.AddRange(new DataTableMapping[1]
    {
      new DataTableMapping("Table", "SearchFCW", new DataColumnMapping[3]
      {
        new DataColumnMapping("ItemType", "ItemType"),
        new DataColumnMapping("FCW", "FCW"),
        new DataColumnMapping("FormNumber", "FormNumber")
      })
    });
    this.SqlSelectCommand1.CommandText = "[SearchFCW]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.cn;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[7]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@countOnly", SqlDbType.Bit, 1),
      new SqlParameter("@searchString", SqlDbType.VarChar, 100),
      new SqlParameter("@forms", SqlDbType.Bit, 1),
      new SqlParameter("@conditions", SqlDbType.Bit, 1),
      new SqlParameter("@warranties", SqlDbType.Bit, 1),
      new SqlParameter("@companyLineID", SqlDbType.Int, 4)
    });
    this.cn.ConnectionString = "workstation id=PSARNOWSKI;packet size=4096;integrated security=SSPI;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.cn.FireInfoMessageEventOnUserErrors = false;
    ((Control) this.progress).Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    appearance18.BackColor = Color.White;
    this.progress.Appearance = (AppearanceBase) appearance18;
    ((Control) this.progress).Location = new Point(8, 414);
    ((Control) this.progress).Name = "progress";
    ((Control) this.progress).Size = new Size(687, 16 /*0x10*/);
    this.progress.Style = (ProgressBarStyle) 2;
    ((Control) this.progress).TabIndex = 7;
    this.progress.Text = "[Formatted]";
    ((UltraControlBase) this.progress).UseFlatMode = (DefaultableBoolean) 1;
    this.lstAdded.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lstAdded.Location = new Point(8, 438);
    this.lstAdded.MGAStyle = MGAStyles.Blue;
    this.lstAdded.Name = "lstAdded";
    this.lstAdded.Size = new Size(568, 106);
    this.lstAdded.TabIndex = 8;
    this.lnkRemove.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
    this.lnkRemove.AutoSize = true;
    this.lnkRemove.Location = new Point(584, 440);
    this.lnkRemove.Name = "lnkRemove";
    this.lnkRemove.Size = new Size(94, 13);
    this.lnkRemove.TabIndex = 9;
    this.lnkRemove.TabStop = true;
    this.lnkRemove.Text = "(remove selected)";
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(703, 548);
    this.Controls.Add((Control) this.lnkRemove);
    this.Controls.Add((Control) this.lstAdded);
    this.Controls.Add((Control) this.progress);
    this.Controls.Add((Control) this.btnSelect);
    this.Controls.Add((Control) this.ug);
    this.Controls.Add((Control) this.MgaGroupBox1);
    this.Font = new Font("Tahoma", 8.25f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
    this.Name = nameof (frmFindFormConditionWarranty);
    this.Text = "Find Form / Condition / Warranty";
    ((ISupportInitialize) this.chkForms).EndInit();
    ((ISupportInitialize) this.chkConditions).EndInit();
    ((ISupportInitialize) this.chkWarranties).EndInit();
    ((ISupportInitialize) this.txtSearch).EndInit();
    ((ISupportInitialize) this.MgaGroupBox1).EndInit();
    ((Control) this.MgaGroupBox1).ResumeLayout(false);
    ((Control) this.MgaGroupBox1).PerformLayout();
    ((ISupportInitialize) this.btnSearch).EndInit();
    ((ISupportInitialize) this.ug).EndInit();
    this.ds.EndInit();
    ((ISupportInitialize) this.btnSelect).EndInit();
    ((ISupportInitialize) this.lstAdded).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }

  public frmFindFormConditionWarranty(
    int companyLineID,
    dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesDataTable dt)
  {
    this.FormClosing += new FormClosingEventHandler(this.frmFindFormConditionWarranty_FormClosing);
    this.Load += new EventHandler(this.frmFindFormConditionWarranty_Load);
    this._gridLayout = new MemoryStream();
    this._doneLoad = false;
    this.InitializeComponent();
    this._dt = dt;
    this._companyLineID = companyLineID;
  }

  private virtual HyperlinkEditor _hlkAdd
  {
    get => this.__hlkAdd;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this._hlkAdd_HyperLinkOpening);
      HyperlinkEditor hlkAdd1 = this.__hlkAdd;
      if (hlkAdd1 != null)
        hlkAdd1.HyperLinkOpening -= cancelEventHandler;
      this.__hlkAdd = value;
      HyperlinkEditor hlkAdd2 = this.__hlkAdd;
      if (hlkAdd2 == null)
        return;
      hlkAdd2.HyperLinkOpening += cancelEventHandler;
    }
  }

  private void frmFindFormConditionWarranty_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (this._fillThread == null || !this._fillThread.IsAlive)
      return;
    this._fillThread.Abort();
    this._fillThread = (Thread) null;
  }

  private void frmFindFormConditionWarranty_Load(object sender, EventArgs e)
  {
    this.cn.ConnectionString = CurrentUser.Instance.ConnectionString;
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    ((Control) this.btnSearch).Enabled = false;
    ((UltraGridBase) this.ug).DisplayLayout.Bands[0].Columns["FormNumber"].Hidden = !((UltraToggleEditorBase) this.chkForms).Checked;
    ((UltraGridBase) this.ug).DisplayLayout.Save((Stream) this._gridLayout);
    ((UltraGridBase) this.ug).DataSource = (object) null;
    this._fillThread = new Thread(new ThreadStart(this.ThreadedFill));
    Thread fillThread = this._fillThread;
    fillThread.Name = "Form Condition Warranty Search";
    fillThread.IsBackground = true;
    fillThread.Start();
  }

  private void ThreadedFill()
  {
    SqlCommand selectCommand = this.da.SelectCommand;
    selectCommand.Parameters["@countOnly"].Value = (object) 1;
    selectCommand.Parameters["@searchString"].Value = (object) ((TextEditorControlBase) this.txtSearch).Text;
    selectCommand.Parameters["@forms"].Value = (object) ((UltraToggleEditorBase) this.chkForms).Checked;
    selectCommand.Parameters["@conditions"].Value = (object) ((UltraToggleEditorBase) this.chkConditions).Checked;
    selectCommand.Parameters["@warranties"].Value = (object) ((UltraToggleEditorBase) this.chkWarranties).Checked;
    selectCommand.Parameters["@companyLineID"].Value = (object) this._companyLineID;
    int integer;
    try
    {
      this.cn.Open();
      integer = Conversions.ToInteger(this.da.SelectCommand.ExecuteScalar());
    }
    finally
    {
      this.cn.Close();
    }
    if (!this.Disposing && !this.IsDisposed)
      MDIControls.Instance.MDIParent.Invoke((Delegate) new frmFindFormConditionWarranty.SetProgressMaxHandler(this.SetProgressMax), (object) integer);
    this.ds.SearchFCW.Clear();
    this.da.SelectCommand.Parameters["@countOnly"].Value = (object) 0;
    SqlDataReader sqlDataReader = (SqlDataReader) null;
    try
    {
      this.cn.Open();
      sqlDataReader = this.da.SelectCommand.ExecuteReader(CommandBehavior.SingleResult);
      this.ds.EnforceConstraints = false;
      this.ds.SearchFCW.BeginLoadData();
      while (sqlDataReader.Read())
      {
        int num1 = (int) sqlDataReader["ItemID"];
        string str = (string) sqlDataReader["ItemType"];
        bool flag = false;
        try
        {
          foreach (FCWItem fcwItem in this.lstAdded.Items)
          {
            if (fcwItem.ItemID == num1 && Microsoft.VisualBasic.CompilerServices.Operators.CompareString(fcwItem.ItemTypeName, str.ToUpper(), false) == 0)
            {
              flag = true;
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
        if (!flag)
        {
          dsFindFormConditionWarranty.SearchFCWRow row = this.ds.SearchFCW.NewSearchFCWRow();
          int num2 = sqlDataReader.FieldCount - 1;
          for (int i = 0; i <= num2; ++i)
            row[sqlDataReader.GetName(i)] = RuntimeHelpers.GetObjectValue(sqlDataReader[i]);
          this.ds.SearchFCW.AddSearchFCWRow(row);
        }
        this.MoveProgress();
      }
      this.ds.SearchFCW.EndLoadData();
      this.ds.EnforceConstraints = true;
    }
    finally
    {
      if (sqlDataReader != null && !sqlDataReader.IsClosed)
        sqlDataReader.Close();
      this.cn.Close();
    }
    if (this.Disposing || this.IsDisposed)
      return;
    MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.LoadComplete));
  }

  private void LoadComplete()
  {
    ((Control) this.btnSearch).Enabled = true;
    this._gridLayout.Position = 0L;
    ((UltraGridBase) this.ug).DataSource = (object) this.ds.SearchFCW;
    ((UltraGridBase) this.ug).DisplayLayout.Load((Stream) this._gridLayout);
    this._hlkAdd = new HyperlinkEditor();
    ((UltraGridBase) this.ug).DisplayLayout.Bands[0].Columns["AddLink"].Editor = (EmbeddableEditorBase) this._hlkAdd;
    this.ResetProgress();
    this._doneLoad = true;
    ((UltraGridBase) this.ug).DisplayLayout.Bands[0].Columns["Description"].Hidden = !((UltraToggleEditorBase) this.chkForms).Checked;
    ((UltraGridBase) this.ug).DisplayLayout.Bands[0].Columns["TemplateName"].Hidden = !((UltraToggleEditorBase) this.chkForms).Checked;
  }

  private void SetProgressMax(int max) => this.progress.Maximum = max;

  private void ResetProgress() => this.progress.Value = 0;

  private void MoveProgress()
  {
    if (MDIControls.Instance.MDIParent.InvokeRequired)
    {
      MDIControls.Instance.MDIParent.Invoke((Delegate) new MethodInvoker(this.MoveProgress));
    }
    else
    {
      UltraProgressBar progress;
      int num = (progress = this.progress).Value + 1;
      progress.Value = num;
    }
  }

  private void btnSelect_Click(object sender, EventArgs e)
  {
    if (this.lstAdded.Items.Count == 0 && MessageBox.Show("You have not selected any items to add to the policy.\n\nWould you like to continue?", "No Items Added", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.No)
      return;
    try
    {
      foreach (FCWItem fcwItem in this.lstAdded.Items)
      {
        dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow row = this._dt.NewtblCompanyFormsConditionsWarrantiesRow();
        dsCompanyFormsConditionsWarranties.tblCompanyFormsConditionsWarrantiesRow conditionsWarrantiesRow = row;
        conditionsWarrantiesRow.CheckedByDefault = false;
        conditionsWarrantiesRow.CompanyLineID = this._companyLineID;
        conditionsWarrantiesRow.Effective = DateAndTime.Now.AddDays(-1.0);
        conditionsWarrantiesRow.NoteTypeID = this.GetDefaultNoteTypeID();
        switch (fcwItem.ItemType)
        {
          case FCWItem.ItemTypes.Form:
            conditionsWarrantiesRow.FormName = fcwItem.ItemName;
            conditionsWarrantiesRow.FormNumber = fcwItem.FormNumber;
            conditionsWarrantiesRow.PolicyFormID = fcwItem.ItemID;
            conditionsWarrantiesRow.ShowOnQuote = false;
            break;
          case FCWItem.ItemTypes.Condition:
            conditionsWarrantiesRow.Condition = fcwItem.ItemName;
            conditionsWarrantiesRow.ConditionID = fcwItem.ItemID;
            break;
          case FCWItem.ItemTypes.Warranty:
            conditionsWarrantiesRow.WarrantyID = fcwItem.ItemID;
            conditionsWarrantiesRow.WarrantyName = fcwItem.ItemName;
            break;
        }
        conditionsWarrantiesRow.AddedDate = DateTime.Now;
        conditionsWarrantiesRow.HasRaterConditional = false;
        conditionsWarrantiesRow.AppliedToQuotes = false;
        this._dt.AddtblCompanyFormsConditionsWarrantiesRow(row);
      }
    }
    finally
    {
      IEnumerator enumerator;
      if (enumerator is IDisposable)
        (enumerator as IDisposable).Dispose();
    }
    this.Close();
  }

  private int GetDefaultNoteTypeID()
  {
    int defaultNoteTypeId;
    if (this._dt.DataSet is dsCompanyFormsConditionsWarranties dataSet && dataSet.lstNoteTypes.Rows.Count > 0)
    {
      DataRow[] dataRowArray = dataSet.lstNoteTypes.Select("Description = 'Not Specified'");
      defaultNoteTypeId = dataRowArray == null || dataRowArray.Length <= 0 ? dataSet.lstNoteTypes[0].NoteTypeID : ((dsCompanyFormsConditionsWarranties.lstNoteTypesRow) dataRowArray[0]).NoteTypeID;
    }
    return defaultNoteTypeId;
  }

  private void SelectRow(UltraGridRow row)
  {
    FCWItem fcwItem = new FCWItem();
    string upper = ((UltraGridBase) this.ug).ActiveRow.Cells["ItemType"].Value.ToString().ToUpper();
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(upper, "FORM", false) != 0)
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(upper, "CONDITION", false) != 0)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(upper, "WARRANTY", false) == 0)
          fcwItem.ItemType = FCWItem.ItemTypes.Warranty;
      }
      else
        fcwItem.ItemType = FCWItem.ItemTypes.Condition;
    }
    else
      fcwItem.ItemType = FCWItem.ItemTypes.Form;
    fcwItem.ItemID = (int) ((UltraGridBase) this.ug).ActiveRow.Cells["ItemID"].Value;
    fcwItem.ItemName = (string) ((UltraGridBase) this.ug).ActiveRow.Cells["FCW"].Value;
    fcwItem.FormNumber = (string) ((UltraGridBase) this.ug).ActiveRow.Cells["FormNumber"].Value;
    this.lstAdded.Items.Add((object) fcwItem);
    this.ds.SearchFCW.Rows.Remove(this.ds.SearchFCW.Select("ItemID=" + fcwItem.ItemID.ToString())[0]);
  }

  private void ug_DoubleClick(object sender, EventArgs e)
  {
    UIElement uiElement = ((UIElement) ((UltraGridBase) this.ug).DisplayLayout.UIElement).ElementFromPoint(((Control) this.ug).PointToClient(Cursor.Position));
    RowUIElement rowUiElement = (RowUIElement) null;
    if (uiElement != null)
    {
      if (uiElement is RowUIElement)
      {
        rowUiElement = (RowUIElement) uiElement;
      }
      else
      {
        UIElement ancestor = uiElement.GetAncestor(typeof (RowUIElement));
        if (ancestor is RowUIElement)
          rowUiElement = (RowUIElement) ancestor;
      }
    }
    if (rowUiElement == null)
      return;
    UltraGridRow context = (UltraGridRow) ((UIElement) rowUiElement).GetContext(typeof (UltraGridRow));
    if (context == null)
      return;
    this.SelectRow(context);
  }

  private void Filter_CheckedChanged(object sender, EventArgs e)
  {
    this.ds.SearchFCW.DefaultView.RowFilter = "1=1";
    if (!((UltraToggleEditorBase) this.chkForms).Checked)
    {
      DataView defaultView;
      string str = (defaultView = this.ds.SearchFCW.DefaultView).RowFilter + " AND ItemType <> 'Form'";
      defaultView.RowFilter = str;
      if (this._doneLoad)
      {
        ((UltraGridBase) this.ug).DisplayLayout.Bands[0].Columns["Description"].Hidden = true;
        ((UltraGridBase) this.ug).DisplayLayout.Bands[0].Columns["TemplateName"].Hidden = true;
      }
    }
    else if (this._doneLoad)
    {
      ((UltraGridBase) this.ug).DisplayLayout.Bands[0].Columns["Description"].Hidden = false;
      ((UltraGridBase) this.ug).DisplayLayout.Bands[0].Columns["TemplateName"].Hidden = false;
    }
    if (!((UltraToggleEditorBase) this.chkConditions).Checked)
    {
      DataView defaultView;
      string str = (defaultView = this.ds.SearchFCW.DefaultView).RowFilter + " AND ItemType <> 'Condition'";
      defaultView.RowFilter = str;
    }
    if (((UltraToggleEditorBase) this.chkWarranties).Checked)
      return;
    DataView defaultView1;
    string str1 = (defaultView1 = this.ds.SearchFCW.DefaultView).RowFilter + " AND ItemType <> 'Warranty'";
    defaultView1.RowFilter = str1;
  }

  private void lnkRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    if (this.lstAdded.SelectedItem == null)
      return;
    FCWItem selectedItem = (FCWItem) this.lstAdded.SelectedItem;
    dsFindFormConditionWarranty.SearchFCWRow row = this.ds.SearchFCW.NewSearchFCWRow();
    row.ItemID = selectedItem.ItemID;
    row.FCW = selectedItem.ItemName;
    row.FormNumber = selectedItem.FormNumber;
    switch (selectedItem.ItemType)
    {
      case FCWItem.ItemTypes.Form:
        row.ItemType = "FORM";
        break;
      case FCWItem.ItemTypes.Condition:
        row.ItemType = "CONDITION";
        break;
      case FCWItem.ItemTypes.Warranty:
        row.ItemType = "WARRANTY";
        break;
    }
    this.ds.SearchFCW.AddSearchFCWRow(row);
    this.lstAdded.Items.Remove(RuntimeHelpers.GetObjectValue(this.lstAdded.SelectedItem));
  }

  private void _hlkAdd_HyperLinkOpening(object sender, CancelEventArgs e)
  {
    e.Cancel = true;
    if (((UltraGridBase) this.ug).ActiveRow == null)
      return;
    this.SelectRow(((UltraGridBase) this.ug).ActiveRow);
  }

  private void txtSearch_KeyDown(object sender, KeyEventArgs e)
  {
    if (e.KeyCode != Keys.Return)
      return;
    this.btnSearch_Click(RuntimeHelpers.GetObjectValue(sender), EventArgs.Empty);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing)
    {
      if (this.components != null)
        this.components.Dispose();
      if (this._hlkAdd != null)
        ((DisposableObject) this._hlkAdd).Dispose();
    }
    base.Dispose(disposing);
  }

  private delegate void SetProgressMaxHandler(int max);
}
