// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.FormSearchEntity
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.IMS.Accounting.AccountingDatasets;
using MGASystems.IMS.Accounting.Core.ClassObjects;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class FormSearchEntity : Form
{
  protected UltraGrid gridEntityList;
  internal SqlDataAdapter daSearchEntity;
  internal SqlCommand SqlSelectCommand1;
  internal SqlConnection FormDataConnection;
  internal ToolTip ToolTip1;
  internal Label Label2;
  internal Label Label1;
  protected MGAButton buttonSearch;
  protected MGATextBox textboxEntityName;
  protected MGASimpleComboBox comboEntityType;
  private UltraExplorerBar ultraExplorerBar1;
  protected UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  protected UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
  protected MGAButton buttonOpen;
  protected MGAButton buttonCancel;
  protected AccountingSearchEntity accountingSearchEntity1;
  protected MGACheckBox chkHideClosedInactive;
  private IContainer components;
  private bool showCompanyGroup;
  private bool showCompany;
  private bool showCompanyLocations;
  private bool showCompanyLines;
  private bool showInsured;
  private bool showIntermediary;
  private bool showProducer;
  private bool showProducerLocation;
  private bool showUsers;
  private bool showUserGroups;
  private bool showExpensePayees;
  private bool show3rdParty;
  private bool showFinanceCompanies;
  private bool showInspectionCompanies;
  protected FormSearchEntity.SearchType EntitySearchType;

  private FormSearchEntity()
  {
    this.InitializeComponent();
    this.showCompanyGroup = true;
    this.showCompany = true;
    this.showCompanyLocations = true;
    this.showCompanyLines = true;
    this.showInsured = true;
    this.showIntermediary = true;
    this.showProducer = true;
    this.showProducerLocation = true;
    this.showUsers = true;
    this.showUserGroups = true;
    this.showExpensePayees = true;
    this.show3rdParty = true;
    this.showFinanceCompanies = true;
    this.showInspectionCompanies = true;
  }

  public FormSearchEntity(Utility.SearchEntityTypes ShowEntities)
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.showCompanyGroup = (ShowEntities & Utility.SearchEntityTypes.ShowCompanyGroup) > Utility.SearchEntityTypes.None;
    this.showCompany = (ShowEntities & Utility.SearchEntityTypes.ShowCompany) > Utility.SearchEntityTypes.None;
    this.showCompanyLocations = (ShowEntities & Utility.SearchEntityTypes.ShowCompanyLocations) > Utility.SearchEntityTypes.None;
    this.showCompanyLines = (ShowEntities & Utility.SearchEntityTypes.ShowCompanyLines) > Utility.SearchEntityTypes.None;
    this.showInsured = (ShowEntities & Utility.SearchEntityTypes.ShowInsured) > Utility.SearchEntityTypes.None;
    this.showIntermediary = (ShowEntities & Utility.SearchEntityTypes.ShowIntermediary) > Utility.SearchEntityTypes.None;
    this.showProducer = (ShowEntities & Utility.SearchEntityTypes.ShowProducer) > Utility.SearchEntityTypes.None;
    this.showProducerLocation = (ShowEntities & Utility.SearchEntityTypes.ShowProducerLocation) > Utility.SearchEntityTypes.None;
    this.showUsers = (ShowEntities & Utility.SearchEntityTypes.ShowUsers) > Utility.SearchEntityTypes.None;
    this.showUserGroups = (ShowEntities & Utility.SearchEntityTypes.ShowUserGroups) > Utility.SearchEntityTypes.None;
    this.showExpensePayees = (ShowEntities & Utility.SearchEntityTypes.ShowExpensePayees) > Utility.SearchEntityTypes.None;
    this.show3rdParty = (ShowEntities & Utility.SearchEntityTypes.Show3rdParty) > Utility.SearchEntityTypes.None;
    this.showFinanceCompanies = (ShowEntities & Utility.SearchEntityTypes.ShowFinanceCompanies) > Utility.SearchEntityTypes.None;
    this.showInspectionCompanies = (ShowEntities & Utility.SearchEntityTypes.ShowInspectionCompanies) > Utility.SearchEntityTypes.None;
    this.BindEntityTypeCombo();
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (FormSearchEntity));
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_SearchEntity", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Entity Name");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EntityGUID");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("StatusID", 0);
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.chkHideClosedInactive = new MGACheckBox();
    this.buttonSearch = new MGAButton();
    this.textboxEntityName = new MGATextBox();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.comboEntityType = new MGASimpleComboBox();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.gridEntityList = new UltraGrid();
    this.accountingSearchEntity1 = new AccountingSearchEntity();
    this.ultraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.buttonCancel = new MGAButton();
    this.buttonOpen = new MGAButton();
    this.daSearchEntity = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.ToolTip1 = new ToolTip(this.components);
    this.ultraExplorerBar1 = new UltraExplorerBar();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.chkHideClosedInactive).BeginInit();
    ((ISupportInitialize) this.buttonSearch).BeginInit();
    ((ISupportInitialize) this.textboxEntityName).BeginInit();
    ((ISupportInitialize) this.comboEntityType).BeginInit();
    ((Control) this.ultraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.gridEntityList).BeginInit();
    this.accountingSearchEntity1.BeginInit();
    ((Control) this.ultraExplorerBarContainerControl3).SuspendLayout();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonOpen).BeginInit();
    ((ISupportInitialize) this.ultraExplorerBar1).BeginInit();
    ((Control) this.ultraExplorerBar1).SuspendLayout();
    this.SuspendLayout();
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.chkHideClosedInactive);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.buttonSearch);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.textboxEntityName);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.Label2);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.Label1);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboEntityType);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(10, 34);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(375, 68);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.chkHideClosedInactive).Appearance = (AppearanceBase) appearance1;
    ((Control) this.chkHideClosedInactive).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideClosedInactive).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.chkHideClosedInactive).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.chkHideClosedInactive).Location = new Point(72, 49);
    this.chkHideClosedInactive.MGAStyle = MGAStyles.Blue;
    ((Control) this.chkHideClosedInactive).Name = "chkHideClosedInactive";
    ((Control) this.chkHideClosedInactive).Size = new Size(218, 20);
    ((Control) this.chkHideClosedInactive).TabIndex = 27;
    ((Control) this.chkHideClosedInactive).Text = "Hide Closed\\Inactive";
    ((UltraControlBase) this.chkHideClosedInactive).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.chkHideClosedInactive).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.chkHideClosedInactive).Visible = false;
    ((UltraToggleEditorBase) this.chkHideClosedInactive).CheckedChanged += new EventHandler(this.chkHideClosedInactive_CheckedChanged);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).Image = componentResourceManager.GetObject("appearance2.Image");
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearch).Appearance = (AppearanceBase) appearance2;
    ((ControlBase) this.buttonSearch).ImageSize = new Size(24, 24);
    ((Control) this.buttonSearch).Location = new Point(320, 3);
    ((Control) this.buttonSearch).Name = "buttonSearch";
    ((Control) this.buttonSearch).Size = new Size(42, 42);
    ((Control) this.buttonSearch).TabIndex = 4;
    ((UltraControlBase) this.buttonSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSearch).Click += new EventHandler(this.btnSearch_Click);
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textboxEntityName).Appearance = (AppearanceBase) appearance3;
    ((Control) this.textboxEntityName).BackColor = Color.White;
    ((Control) this.textboxEntityName).ForeColor = Color.Black;
    ((Control) this.textboxEntityName).Location = new Point(72, 24);
    ((TextEditorControlBase) this.textboxEntityName).MaxLength = 25;
    this.textboxEntityName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textboxEntityName).Name = "textboxEntityName";
    ((Control) this.textboxEntityName).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.textboxEntityName).TabIndex = 3;
    ((UltraControlBase) this.textboxEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textboxEntityName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(0, 24);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(69, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Entity Name:";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(0, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(66, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Entity Type:";
    this.comboEntityType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboEntityType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboEntityType).Location = new Point(72, 0);
    this.comboEntityType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboEntityType).Name = "comboEntityType";
    ((Control) this.comboEntityType).Size = new Size(240 /*0xF0*/, 21);
    ((Control) this.comboEntityType).TabIndex = 1;
    ((UltraControlBase) this.comboEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboEntityType).UseOsThemes = (DefaultableBoolean) 2;
    this.comboEntityType.RowSelected += new RowSelectedEventHandler(this.comboEntityType_RowSelected);
    this.comboEntityType.ValueChanged += new EventHandler(this.comboEntityType_ValueChanged);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.gridEntityList);
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(10, 148);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(375, 328);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 1;
    ((UltraGridBase) this.gridEntityList).DataSource = (object) this.accountingSearchEntity1.spFin_SearchEntity;
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb(78, 122, 171);
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Appearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 373;
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridColumn3.DataType = typeof (short);
    ((HeaderBase) ultraGridColumn3.Header).Caption = "Status";
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 80 /*0x50*/;
    ultraGridBand.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ((UltraGridBase) this.gridEntityList).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance6).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((Control) this.gridEntityList).Dock = DockStyle.Fill;
    ((Control) this.gridEntityList).Location = new Point(0, 0);
    ((Control) this.gridEntityList).Name = "gridEntityList";
    ((Control) this.gridEntityList).Size = new Size(375, 328);
    ((Control) this.gridEntityList).TabIndex = 5;
    ((UltraControlBase) this.gridEntityList).UseFlatMode = (DefaultableBoolean) 1;
    this.gridEntityList.InitializeRow += new InitializeRowEventHandler(this.gridEntityList_InitializeRow);
    this.gridEntityList.DoubleClickRow += new DoubleClickRowEventHandler(this.gridEntityList_DoubleClickRow);
    this.accountingSearchEntity1.DataSetName = "AccountingSearchEntity";
    this.accountingSearchEntity1.Locale = new CultureInfo("en-US");
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonOpen);
    ((Control) this.ultraExplorerBarContainerControl3).Location = new Point(10, 497);
    ((Control) this.ultraExplorerBarContainerControl3).Name = "ultraExplorerBarContainerControl3";
    ((Control) this.ultraExplorerBarContainerControl3).Size = new Size(375, 25);
    ((Control) this.ultraExplorerBarContainerControl3).TabIndex = 2;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance7;
    ((Control) this.buttonCancel).Location = new Point(264, 0);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(104, 24);
    ((Control) this.buttonCancel).TabIndex = 8;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance8).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance8).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance8).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonOpen).Appearance = (AppearanceBase) appearance8;
    ((Control) this.buttonOpen).Location = new Point(152, 0);
    ((Control) this.buttonOpen).Name = "buttonOpen";
    ((Control) this.buttonOpen).Size = new Size(104, 24);
    ((Control) this.buttonOpen).TabIndex = 7;
    ((Control) this.buttonOpen).Text = "Display Selection";
    ((UltraControlBase) this.buttonOpen).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonOpen).Click += new EventHandler(this.btnOpen_Click);
    this.daSearchEntity.SelectCommand = this.SqlSelectCommand1;
    this.daSearchEntity.TableMappings.AddRange(new DataTableMapping[10]
    {
      new DataTableMapping("Table", "spFin_SearchEntity", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table1", "Table1", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table2", "Table2", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table3", "Table3", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table4", "Table4", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table5", "Table5", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table6", "Table6", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table7", "Table7", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table8", "Table8", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      }),
      new DataTableMapping("Table9", "Table9", new DataColumnMapping[2]
      {
        new DataColumnMapping("Entity Name", "Entity Name"),
        new DataColumnMapping("EntityGUID", "EntityGUID")
      })
    });
    this.SqlSelectCommand1.CommandText = "[spFin_SearchEntity]";
    this.SqlSelectCommand1.CommandType = CommandType.StoredProcedure;
    this.SqlSelectCommand1.Connection = this.FormDataConnection;
    this.SqlSelectCommand1.Parameters.AddRange(new SqlParameter[3]
    {
      new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null),
      new SqlParameter("@ENTITYTYPE", SqlDbType.VarChar, 2),
      new SqlParameter("@ENTITYNAME", SqlDbType.VarChar, 100)
    });
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    this.FormDataConnection.FireInfoMessageEventOnUserErrors = false;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BackColor2 = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance9;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl2);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl3);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 70;
    ((UltraExplorerBarSettingsBase) explorerBarGroup1.Settings).MaxLines = 100;
    explorerBarGroup1.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup1.Settings.Style = (GroupStyle) 6;
    explorerBarGroup1.Text = "Search Criteria";
    explorerBarGroup2.Container = this.ultraExplorerBarContainerControl2;
    explorerBarGroup2.Settings.ContainerHeight = 330;
    explorerBarGroup2.Settings.ShowExpansionIndicator = (DefaultableBoolean) 2;
    explorerBarGroup2.Settings.Style = (GroupStyle) 6;
    explorerBarGroup2.Text = "Results";
    explorerBarGroup3.Container = this.ultraExplorerBarContainerControl3;
    explorerBarGroup3.Settings.ContainerHeight = 27;
    explorerBarGroup3.Settings.HeaderVisible = (DefaultableBoolean) 2;
    explorerBarGroup3.Settings.Style = (GroupStyle) 6;
    explorerBarGroup3.Text = "New Group";
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance11).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance11).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance11).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance11).BorderColor = Color.White;
    ((AppearanceBase) appearance11).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance11).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance11).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance11).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance11).ImageBackground = (Image) componentResourceManager.GetObject("appearance11.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance12;
    this.ultraExplorerBar1.GroupSettings.BorderStyleItemArea = (UIElementBorderStyle) 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Bottom = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Left = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Right = 4;
    this.ultraExplorerBar1.GroupSettings.ItemAreaInnerMargins.Top = 4;
    this.ultraExplorerBar1.GroupSpacing = 10;
    ((Control) this.ultraExplorerBar1).Location = new Point(0, 0);
    this.ultraExplorerBar1.Margins.Bottom = 4;
    this.ultraExplorerBar1.Margins.Left = 4;
    this.ultraExplorerBar1.Margins.Right = 4;
    this.ultraExplorerBar1.Margins.Top = 4;
    ((Control) this.ultraExplorerBar1).Name = "ultraExplorerBar1";
    this.ultraExplorerBar1.NavigationAllowGroupReorder = false;
    this.ultraExplorerBar1.Scrollbars = (ScrollbarStyle) 2;
    ((Control) this.ultraExplorerBar1).Size = new Size(395, 535);
    ((Control) this.ultraExplorerBar1).TabIndex = 7;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.AcceptButton = (IButtonControl) this.buttonSearch;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(395, 535);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormSearchEntity);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Accounting - Search Entity";
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl1).PerformLayout();
    ((ISupportInitialize) this.chkHideClosedInactive).EndInit();
    ((ISupportInitialize) this.buttonSearch).EndInit();
    ((ISupportInitialize) this.textboxEntityName).EndInit();
    ((ISupportInitialize) this.comboEntityType).EndInit();
    ((Control) this.ultraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.gridEntityList).EndInit();
    this.accountingSearchEntity1.EndInit();
    ((Control) this.ultraExplorerBarContainerControl3).ResumeLayout(false);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonOpen).EndInit();
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public Guid EntityGuid
  {
    get
    {
      return ((SparseCollectionBase) this.gridEntityList.Selected.Rows).Count != 0 ? new Guid(this.gridEntityList.Selected.Rows[0].Cells[1].Value.ToString()) : Guid.Empty;
    }
  }

  public string EntityName
  {
    get
    {
      return ((SparseCollectionBase) this.gridEntityList.Selected.Rows).Count != 0 ? this.gridEntityList.Selected.Rows[0].Cells[0].Value.ToString() : string.Empty;
    }
  }

  private void BindEntityTypeCombo()
  {
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add(new DataColumn("EntityType", typeof (string)));
    dataTable.Columns.Add(new DataColumn("TypeCode", typeof (string)));
    if (this.showCompanyGroup)
      dataTable.Rows.Add((object) StringResourceManager.GetString("COMPANYGROUP"), (object) "CG");
    if (this.showCompany)
      dataTable.Rows.Add((object) StringResourceManager.GetString("COMPANY"), (object) "CO");
    if (this.showCompanyLocations)
      dataTable.Rows.Add((object) StringResourceManager.GetString("COMPANYLOCATION"), (object) "CL");
    if (this.showCompanyLines)
      dataTable.Rows.Add((object) StringResourceManager.GetString("COMPANYLINE"), (object) "C");
    if (this.showInsured)
      dataTable.Rows.Add((object) StringResourceManager.GetString("INSURED"), (object) "I");
    if (this.showIntermediary)
      dataTable.Rows.Add((object) StringResourceManager.GetString("INTERMEDIARY"), (object) "IN");
    if (this.showProducer)
      dataTable.Rows.Add((object) StringResourceManager.GetString("PRODUCER"), (object) "P");
    if (this.showProducerLocation)
      dataTable.Rows.Add((object) StringResourceManager.GetString("PRODUCERLOCATION"), (object) "PL");
    if (this.showUsers)
      dataTable.Rows.Add((object) StringResourceManager.GetString("USER"), (object) "U");
    if (this.showUserGroups)
      dataTable.Rows.Add((object) StringResourceManager.GetString("USERGROUP"), (object) "G");
    if (this.showExpensePayees)
      dataTable.Rows.Add((object) StringResourceManager.GetString("EXPENSEPAYEE"), (object) "X");
    if (this.show3rdParty)
      dataTable.Rows.Add((object) StringResourceManager.GetString("3RDPARTYPAYEE"), (object) "3");
    if (this.showFinanceCompanies)
      dataTable.Rows.Add((object) StringResourceManager.GetString("FINANCECOMPANY"), (object) "FI");
    if (this.showInspectionCompanies)
      dataTable.Rows.Add((object) StringResourceManager.GetString("INSPECTIONCOMPANY"), (object) "NS");
    ((UltraGridBase) this.comboEntityType).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboEntityType).DisplayMember = "EntityType";
    ((UltraDropDownBase) this.comboEntityType).ValueMember = "TypeCode";
  }

  protected virtual void comboEntityType_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboEntityType).SelectedRow == null)
      return;
    string str = ((UltraDropDownBase) this.comboEntityType).SelectedRow.Cells["typecode"].Value.ToString();
    if (str != null)
    {
      switch (str.Length)
      {
        case 1:
          switch (str[0])
          {
            case '3':
              this.EntitySearchType = FormSearchEntity.SearchType.ThirdPartyPayee;
              goto label_27;
            case 'C':
              this.EntitySearchType = FormSearchEntity.SearchType.CompanyLine;
              goto label_27;
            case 'G':
              this.EntitySearchType = FormSearchEntity.SearchType.UserGroup;
              goto label_27;
            case 'I':
              this.EntitySearchType = FormSearchEntity.SearchType.Insured;
              goto label_27;
            case 'P':
              this.EntitySearchType = FormSearchEntity.SearchType.Producer;
              goto label_27;
            case 'U':
              this.EntitySearchType = FormSearchEntity.SearchType.User;
              goto label_27;
            case 'X':
              this.EntitySearchType = FormSearchEntity.SearchType.ExpensePayee;
              goto label_27;
          }
          break;
        case 2:
          switch (str[1])
          {
            case 'G':
              if (str == "CG")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.CompanyGroup;
                goto label_27;
              }
              break;
            case 'I':
              if (str == "FI")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.FinanceCompany;
                goto label_27;
              }
              break;
            case 'L':
              switch (str)
              {
                case "CL":
                  this.EntitySearchType = FormSearchEntity.SearchType.CompanyLocation;
                  goto label_27;
                case "PL":
                  this.EntitySearchType = FormSearchEntity.SearchType.ProducerLocation;
                  goto label_27;
              }
              break;
            case 'N':
              if (str == "IN")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.Intermediary;
                goto label_27;
              }
              break;
            case 'O':
              if (str == "CO")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.Company;
                goto label_27;
              }
              break;
            case 'S':
              if (str == "NS")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.InspectionCompany;
                goto label_27;
              }
              break;
          }
          break;
      }
    }
    this.EntitySearchType = FormSearchEntity.SearchType.None;
label_27:
    this.AcceptButton = (IButtonControl) this.buttonSearch;
  }

  protected virtual void ExecuteSearch(string _EntityType, string _EntityName)
  {
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.daSearchEntity.SelectCommand.Parameters["@ENTITYTYPE"].Value = (object) _EntityType;
    if (!(_EntityName.Trim() == ""))
      this.daSearchEntity.SelectCommand.Parameters["@ENTITYNAME"].Value = (object) _EntityName;
    this.accountingSearchEntity1.Clear();
    this.daSearchEntity.SelectCommand.CommandText = "spFin_SearchEntity";
    this.daSearchEntity.Fill((DataSet) this.accountingSearchEntity1);
    if (this.accountingSearchEntity1.Tables[0].Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("The specified entity could not be found, please try again!", "Entity Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      ((Control) this.gridEntityList).Focus();
      ((UltraGridBase) this.gridEntityList).ActiveRow = ((UltraGridBase) this.gridEntityList).Rows[0];
      ((GridItemBase) ((UltraGridBase) this.gridEntityList).Rows[0]).Selected = true;
    }
  }

  protected virtual void btnSearch_Click(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.comboEntityType).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an entity type to continue.", "No Entity Type Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.Cursor = Cursors.WaitCursor;
      switch (this.EntitySearchType)
      {
        case FormSearchEntity.SearchType.CompanyGroup:
          this.ExecuteSearch("CG", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.Company:
          this.ExecuteSearch("CO", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.CompanyLocation:
          this.ExecuteSearch("CL", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.CompanyLine:
          this.ExecuteSearch("C", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.Insured:
          this.ExecuteSearch("I", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.Intermediary:
          this.ExecuteSearch("IN", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.Producer:
          this.ExecuteSearch("P", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.ProducerLocation:
          this.ExecuteSearch("PL", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.User:
          this.ExecuteSearch("U", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.UserGroup:
          this.ExecuteSearch("G", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.ExpensePayee:
          this.ExecuteSearch("X", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.ThirdPartyPayee:
          this.ExecuteSearch("3", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.FinanceCompany:
          this.ExecuteSearch("FI", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.InspectionCompany:
          this.ExecuteSearch("NS", ((Control) this.textboxEntityName).Text.Trim());
          break;
      }
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridEntityList).Rows).Count == 500 && CurrentUser.Instance.UsingXP)
        BalloonTip.ShowEditTip((Control) this.textboxEntityName, StringResourceManager.GetString("LIMITING_RESULTS"), StringResourceManager.GetString("TOOMANY_RESULTS_RETURNED"), BalloonTip.BalloonTipIcons.Info);
      this.AcceptButton = (IButtonControl) this.buttonOpen;
      this.Cursor = Cursors.Default;
    }
  }

  private void btnOpen_Click(object sender, EventArgs e)
  {
    if (((SparseCollectionBase) this.gridEntityList.Selected.Rows).Count == 0)
      return;
    this.DialogResult = DialogResult.OK;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void gridEntityList_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    if (this.gridEntityList.Selected.Rows[0] == null)
      return;
    UltraGridRow row = this.gridEntityList.Selected.Rows[0];
    if (row == null)
      return;
    ((GridItemBase) row).Selected = true;
    row.Activate();
    this.DialogResult = DialogResult.OK;
  }

  protected void comboEntityType_ValueChanged(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.comboEntityType).SelectedRow == null)
      return;
    ((Control) this.chkHideClosedInactive).Visible = ((Control) this.comboEntityType).Text == "Producer" || ((Control) this.comboEntityType).Text == "Producer Location";
  }

  protected void gridEntityList_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if ((FormSearchEntity.StatusType) Enum.Parse(typeof (FormSearchEntity.StatusType), e.Row.Cells["StatusID"].Value.ToString()) == FormSearchEntity.StatusType.Closed)
    {
      ((AppearanceBase) e.Row.Appearance).FontData.Strikeout = (DefaultableBoolean) 1;
      ((AppearanceBase) e.Row.Appearance).ForeColor = Color.Red;
    }
    else
    {
      if ((FormSearchEntity.StatusType) Enum.Parse(typeof (FormSearchEntity.StatusType), e.Row.Cells["StatusID"].Value.ToString()) == FormSearchEntity.StatusType.Active)
        return;
      ((AppearanceBase) e.Row.Appearance).ForeColor = Color.Red;
    }
  }

  protected void chkHideClosedInactive_CheckedChanged(object sender, EventArgs e)
  {
    UltraGrid gridEntityList = this.gridEntityList;
    if (((UltraToggleEditorBase) this.chkHideClosedInactive).Checked)
    {
      ((UltraGridBase) this.gridEntityList).DisplayLayout.Bands[0].ColumnFilters["StatusID"].FilterConditions.Add((FilterComparisionOperator) 15, (object) 2);
      ((UltraGridBase) this.gridEntityList).DisplayLayout.Bands[0].ColumnFilters["StatusID"].FilterConditions.Add((FilterComparisionOperator) 15, (object) 3);
    }
    else
      ((UltraGridBase) this.gridEntityList).DisplayLayout.Bands[0].ColumnFilters.ClearAllFilters();
  }

  protected enum SearchType
  {
    None,
    CompanyGroup,
    Company,
    CompanyLocation,
    CompanyLine,
    Insured,
    Intermediary,
    Producer,
    ProducerLocation,
    User,
    UserGroup,
    ExpensePayee,
    ThirdPartyPayee,
    FinanceCompany,
    InspectionCompany,
  }

  protected enum StatusType
  {
    Active = 1,
    Inactive = 2,
    Closed = 3,
    Suspended = 4,
  }
}
