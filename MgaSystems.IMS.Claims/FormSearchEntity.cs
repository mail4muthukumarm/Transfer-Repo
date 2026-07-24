// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormSearchEntity
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

public class FormSearchEntity : Form
{
  internal UltraGrid gridEntityList;
  internal SqlDataAdapter daSearchEntity;
  internal SqlCommand SqlSelectCommand1;
  internal SqlConnection FormDataConnection;
  internal ToolTip ToolTip1;
  internal Label Label2;
  internal Label Label1;
  private MGAButton buttonSearch;
  internal MGATextBox textboxEntityName;
  private MGASimpleComboBox comboEntityType;
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
  private MGAButton buttonOpen;
  private MGAButton buttonCancel;
  private dsSearchEntity accountingSearchEntity1;
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
  private bool showOutsideAdjusters;
  private bool showManagedCareFacilities;
  private bool showClaimEntities;
  private FormSearchEntity.SearchType EntitySearchType;

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
    this.showOutsideAdjusters = true;
    this.showManagedCareFacilities = true;
  }

  internal FormSearchEntity(Utility.SearchEntityTypes ShowEntities)
  {
    this.InitializeComponent();
    this.FormDataConnection.ConnectionString = CurrentUser.Instance.ConnectionString;
    this.showCompanyGroup = (ShowEntities & Utility.SearchEntityTypes.ShowCompanyGroup) > (Utility.SearchEntityTypes) 0;
    this.showCompany = (ShowEntities & Utility.SearchEntityTypes.ShowCompany) > (Utility.SearchEntityTypes) 0;
    this.showCompanyLocations = (ShowEntities & Utility.SearchEntityTypes.ShowCompanyLocations) > (Utility.SearchEntityTypes) 0;
    this.showCompanyLines = (ShowEntities & Utility.SearchEntityTypes.ShowCompanyLines) > (Utility.SearchEntityTypes) 0;
    this.showInsured = (ShowEntities & Utility.SearchEntityTypes.ShowInsured) > (Utility.SearchEntityTypes) 0;
    this.showIntermediary = (ShowEntities & Utility.SearchEntityTypes.ShowIntermediary) > (Utility.SearchEntityTypes) 0;
    this.showProducer = (ShowEntities & Utility.SearchEntityTypes.ShowProducer) > (Utility.SearchEntityTypes) 0;
    this.showProducerLocation = (ShowEntities & Utility.SearchEntityTypes.ShowProducerLocation) > (Utility.SearchEntityTypes) 0;
    this.showUsers = (ShowEntities & Utility.SearchEntityTypes.ShowUsers) > (Utility.SearchEntityTypes) 0;
    this.showUserGroups = (ShowEntities & Utility.SearchEntityTypes.ShowUserGroups) > (Utility.SearchEntityTypes) 0;
    this.showExpensePayees = (ShowEntities & Utility.SearchEntityTypes.ShowExpensePayees) > (Utility.SearchEntityTypes) 0;
    this.show3rdParty = (ShowEntities & Utility.SearchEntityTypes.Show3rdParty) > (Utility.SearchEntityTypes) 0;
    this.showFinanceCompanies = (ShowEntities & Utility.SearchEntityTypes.ShowFinanceCompanies) > (Utility.SearchEntityTypes) 0;
    this.showInspectionCompanies = (ShowEntities & Utility.SearchEntityTypes.ShowInspectionCompanies) > (Utility.SearchEntityTypes) 0;
    this.showOutsideAdjusters = (ShowEntities & Utility.SearchEntityTypes.ShowOutsideAdjusters) > (Utility.SearchEntityTypes) 0;
    this.showManagedCareFacilities = (ShowEntities & Utility.SearchEntityTypes.ShowManagedCareFacilities) > (Utility.SearchEntityTypes) 0;
    if (!SystemSettings.KeyExists("Claims.ShowClaimEntities") || !SystemSettings.GetBoolSetting("Claims.ShowClaimEntities"))
      this.showClaimEntities = (ShowEntities & Utility.SearchEntityTypes.ShowClaimEntities) > (Utility.SearchEntityTypes) 0;
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
    ResourceManager resourceManager = new ResourceManager(typeof (FormSearchEntity));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("spFin_SearchEntity", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Entity Name");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EntityGUID");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.buttonSearch = new MGAButton();
    this.textboxEntityName = new MGATextBox();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.comboEntityType = new MGASimpleComboBox();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.gridEntityList = new UltraGrid();
    this.accountingSearchEntity1 = new dsSearchEntity();
    this.ultraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.buttonCancel = new MGAButton();
    this.buttonOpen = new MGAButton();
    this.daSearchEntity = new SqlDataAdapter();
    this.SqlSelectCommand1 = new SqlCommand();
    this.FormDataConnection = new SqlConnection();
    this.ToolTip1 = new ToolTip(this.components);
    this.ultraExplorerBar1 = new UltraExplorerBar();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
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
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.buttonSearch);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.textboxEntityName);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.Label2);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.Label1);
    ((Control) this.ultraExplorerBarContainerControl1).Controls.Add((Control) this.comboEntityType);
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(10, 34);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(372, 51);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).Image = resourceManager.GetObject("appearance1.Image");
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearch).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.buttonSearch).ImageSize = new Size(24, 24);
    ((Control) this.buttonSearch).Location = new Point(320, 3);
    ((Control) this.buttonSearch).Name = "buttonSearch";
    ((Control) this.buttonSearch).Size = new Size(42, 42);
    ((Control) this.buttonSearch).TabIndex = 4;
    ((Control) this.buttonSearch).Click += new EventHandler(this.btnSearch_Click);
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textboxEntityName).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textboxEntityName).ForeColor = Color.Black;
    ((Control) this.textboxEntityName).Location = new Point(72, 24);
    ((TextEditorControlBase) this.textboxEntityName).MaxLength = 25;
    this.textboxEntityName.MGAStyle = (MGAStyles) 2;
    ((Control) this.textboxEntityName).Name = "textboxEntityName";
    ((Control) this.textboxEntityName).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.textboxEntityName).TabIndex = 3;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(0, 24);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(69, 17);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Entity Name:";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(0, 0);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(65, 17);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Entity Type:";
    ((UltraCombo) this.comboEntityType).BorderStyle = (UIElementBorderStyle) 4;
    ((UltraCombo) this.comboEntityType).CharacterCasing = CharacterCasing.Normal;
    ((UltraDropDownBase) this.comboEntityType).DisplayMember = "";
    ((UltraCombo) this.comboEntityType).DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboEntityType).Location = new Point(72, 0);
    this.comboEntityType.MGAStyle = (MGAStyles) 2;
    ((Control) this.comboEntityType).Name = "comboEntityType";
    ((Control) this.comboEntityType).Size = new Size(240 /*0xF0*/, 20);
    ((Control) this.comboEntityType).TabIndex = 1;
    ((UltraDropDownBase) this.comboEntityType).ValueMember = "";
    ((UltraCombo) this.comboEntityType).RowSelected += new RowSelectedEventHandler(this.comboEntityType_RowSelected);
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.gridEntityList);
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(10, 131);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(372, 328);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 1;
    ((UltraGridBase) this.gridEntityList).DataSource = (object) this.accountingSearchEntity1.EntityList;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.FromArgb(78, 122, 171);
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.ColHeadersVisible = false;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Width = 370;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
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
    ((AppearanceBase) appearance4).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance5).BackColor = SystemColors.Control;
    ((AppearanceBase) appearance5).TextHAlign = (HAlign) 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((Control) this.gridEntityList).Dock = DockStyle.Fill;
    ((UltraControlBase) this.gridEntityList).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridEntityList).Location = new Point(0, 0);
    ((Control) this.gridEntityList).Name = "gridEntityList";
    ((Control) this.gridEntityList).Size = new Size(372, 328);
    ((Control) this.gridEntityList).TabIndex = 5;
    this.gridEntityList.DoubleClickRow += new DoubleClickRowEventHandler(this.gridEntityList_DoubleClickRow);
    this.accountingSearchEntity1.DataSetName = "AccountingSearchEntity";
    this.accountingSearchEntity1.Locale = new CultureInfo("en-US");
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonOpen);
    ((Control) this.ultraExplorerBarContainerControl3).Location = new Point(10, 480);
    ((Control) this.ultraExplorerBarContainerControl3).Name = "ultraExplorerBarContainerControl3";
    ((Control) this.ultraExplorerBarContainerControl3).Size = new Size(372, 25);
    ((Control) this.ultraExplorerBarContainerControl3).TabIndex = 2;
    ((AppearanceBase) appearance6).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance6).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance6).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance6;
    ((Control) this.buttonCancel).Location = new Point(264, 0);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(104, 24);
    ((Control) this.buttonCancel).TabIndex = 8;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance7).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance7).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance7).BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonOpen).Appearance = (AppearanceBase) appearance7;
    ((Control) this.buttonOpen).Location = new Point(152, 0);
    ((Control) this.buttonOpen).Name = "buttonOpen";
    ((Control) this.buttonOpen).Size = new Size(104, 24);
    ((Control) this.buttonOpen).TabIndex = 7;
    ((Control) this.buttonOpen).Text = "Display Selection";
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
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@RETURN_VALUE", SqlDbType.Int, 4, ParameterDirection.ReturnValue, false, (byte) 0, (byte) 0, "", DataRowVersion.Current, (object) null));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@ENTITYTYPE", SqlDbType.VarChar, 2));
    this.SqlSelectCommand1.Parameters.Add(new SqlParameter("@ENTITYNAME", SqlDbType.VarChar, 100));
    this.FormDataConnection.ConnectionString = "workstation id=WREYES;packet size=4096;user id=mgasystems;data source=MGASYSTEMS;persist security info=False;initial catalog=IMS";
    ((AppearanceBase) appearance8).BackColor = Color.White;
    ((AppearanceBase) appearance8).BackColor2 = Color.White;
    ((AppearanceBase) appearance8).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance8;
    this.ultraExplorerBar1.BorderStyle = (UIElementBorderStyle) 1;
    this.ultraExplorerBar1.ColumnSpacing = 30;
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl1);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl2);
    ((Control) this.ultraExplorerBar1).Controls.Add((Control) this.ultraExplorerBarContainerControl3);
    ((Control) this.ultraExplorerBar1).Dock = DockStyle.Fill;
    explorerBarGroup1.Container = this.ultraExplorerBarContainerControl1;
    explorerBarGroup1.Settings.ContainerHeight = 53;
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
    this.ultraExplorerBar1.Groups.AddRange(new UltraExplorerBarGroup[3]
    {
      explorerBarGroup1,
      explorerBarGroup2,
      explorerBarGroup3
    });
    ((AppearanceBase) appearance9).BackColor = Color.FromArgb(239, 247, 253);
    ((AppearanceBase) appearance9).BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance9;
    ((AppearanceBase) appearance10).AlphaLevel = (short) 38;
    ((AppearanceBase) appearance10).BackColor = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance10).BackColor2 = Color.FromArgb(166, 202, 238);
    ((AppearanceBase) appearance10).BackColorAlpha = (Alpha) 2;
    ((AppearanceBase) appearance10).BorderColor = Color.White;
    ((AppearanceBase) appearance10).FontData.Name = "Tahoma";
    ((AppearanceBase) appearance10).FontData.SizeInPoints = 8f;
    ((AppearanceBase) appearance10).ForeColor = Color.DarkBlue;
    ((AppearanceBase) appearance10).ForegroundAlpha = (Alpha) 2;
    ((AppearanceBase) appearance10).ImageBackground = (Image) resourceManager.GetObject("appearance10.ImageBackground");
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance11;
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
    ((Control) this.ultraExplorerBar1).Size = new Size(392, 520);
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBar1).TabIndex = 7;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.AcceptButton = (IButtonControl) this.buttonSearch;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(392, 520);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) resourceManager.GetObject("$this.Icon");
    this.Name = nameof (FormSearchEntity);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Accounting - Search Entity";
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
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

  internal Guid EntityGuid
  {
    get
    {
      return ((SparseCollectionBase) this.gridEntityList.Selected.Rows).Count != 0 ? new Guid(this.gridEntityList.Selected.Rows[0].Cells[1].Value.ToString()) : Guid.Empty;
    }
  }

  internal string EntityName
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
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.COMPANYGROUP_SELECTION, (object) "CG");
    if (this.showCompany)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.COMPANY_SELECTION, (object) "CO");
    if (this.showCompanyLocations)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.COMPANYLOCATION_SELECTION, (object) "CL");
    if (this.showCompanyLines)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.COMPANYLINE_SELECTION, (object) "C");
    if (this.showInsured)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.INSURED_SELECTION, (object) "I");
    if (this.showIntermediary)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.INTERMEDIARY_SELECTION, (object) "IN");
    if (this.showProducer)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.PRODUCER_SELECTION, (object) "P");
    if (this.showProducerLocation)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.PRODUCERLOCATION_SELECTION, (object) "PL");
    if (this.showUsers)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.USER_SELECTION, (object) "U");
    if (this.showUserGroups)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.USERGROUP_SELECTION, (object) "G");
    if (this.showExpensePayees)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.EXPENSEPAYEE_SELECTION, (object) "X");
    if (this.show3rdParty)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.THIRDPARTYPAYEE_SELECTION, (object) "3");
    if (this.showFinanceCompanies)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.FINANCECOMPANY_SELECTION, (object) "FI");
    if (this.showInspectionCompanies)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.INSPECTIONCOMPANY_SELECTION, (object) "NS");
    if (this.showOutsideAdjusters)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.OUTSIDEADJUSTER_SELECTION, (object) "OA");
    if (this.showManagedCareFacilities)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.MANAGEDCARE_SELECTION, (object) "MC");
    if (this.showClaimEntities)
      dataTable.Rows.Add((object) MGASystems.IMS.Claims.Properties.Resources.CLAIMENTITY_SELECTION, (object) "CE");
    ((UltraGridBase) this.comboEntityType).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboEntityType).DisplayMember = "EntityType";
    ((UltraDropDownBase) this.comboEntityType).ValueMember = "TypeCode";
  }

  private void comboEntityType_RowSelected(object sender, RowSelectedEventArgs e)
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
              goto label_33;
            case 'C':
              this.EntitySearchType = FormSearchEntity.SearchType.CompanyLine;
              goto label_33;
            case 'G':
              this.EntitySearchType = FormSearchEntity.SearchType.UserGroup;
              goto label_33;
            case 'I':
              this.EntitySearchType = FormSearchEntity.SearchType.Insured;
              goto label_33;
            case 'P':
              this.EntitySearchType = FormSearchEntity.SearchType.Producer;
              goto label_33;
            case 'U':
              this.EntitySearchType = FormSearchEntity.SearchType.User;
              goto label_33;
            case 'X':
              this.EntitySearchType = FormSearchEntity.SearchType.ExpensePayee;
              goto label_33;
          }
          break;
        case 2:
          switch (str[1])
          {
            case 'A':
              if (str == "OA")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.OutsideAdjusters;
                goto label_33;
              }
              break;
            case 'C':
              if (str == "MC")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.ManagedCareFacilities;
                goto label_33;
              }
              break;
            case 'E':
              if (str == "CE")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.ClaimEntity;
                goto label_33;
              }
              break;
            case 'G':
              if (str == "CG")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.CompanyGroup;
                goto label_33;
              }
              break;
            case 'I':
              if (str == "FI")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.FinanceCompany;
                goto label_33;
              }
              break;
            case 'L':
              switch (str)
              {
                case "CL":
                  this.EntitySearchType = FormSearchEntity.SearchType.CompanyLocation;
                  goto label_33;
                case "PL":
                  this.EntitySearchType = FormSearchEntity.SearchType.ProducerLocation;
                  goto label_33;
              }
              break;
            case 'N':
              if (str == "IN")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.Intermediary;
                goto label_33;
              }
              break;
            case 'O':
              if (str == "CO")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.Company;
                goto label_33;
              }
              break;
            case 'S':
              if (str == "NS")
              {
                this.EntitySearchType = FormSearchEntity.SearchType.InspectionCompany;
                goto label_33;
              }
              break;
          }
          break;
      }
    }
    this.EntitySearchType = FormSearchEntity.SearchType.None;
label_33:
    this.AcceptButton = (IButtonControl) this.buttonSearch;
  }

  private void ExecuteSearch(string entityType, string entityName)
  {
    this.accountingSearchEntity1.Clear();
    if (!string.IsNullOrEmpty(entityName))
      DefaultDatabase.LoadDataTable((DataTable) this.accountingSearchEntity1.EntityList, "spClaims_SearchEntity", new object[4]
      {
        (object) "@ENTITYTYPE",
        (object) entityType,
        (object) "@EntityName",
        (object) entityName
      });
    else
      DefaultDatabase.LoadDataTable((DataTable) this.accountingSearchEntity1.EntityList, "spClaims_SearchEntity", new object[2]
      {
        (object) "@ENTITYTYPE",
        (object) entityType
      });
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

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.comboEntityType).SelectedRow == null)
    {
      int num1 = (int) MessageBox.Show("You must select an entity type to continue.", "No Entity Type Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
        case FormSearchEntity.SearchType.OutsideAdjusters:
          this.ExecuteSearch("OA", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.ManagedCareFacilities:
          this.ExecuteSearch("MC", ((Control) this.textboxEntityName).Text.Trim());
          break;
        case FormSearchEntity.SearchType.ClaimEntity:
          this.ExecuteSearch("CE", ((Control) this.textboxEntityName).Text.Trim());
          break;
      }
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.gridEntityList).Rows).Count == 500)
      {
        int num2 = CurrentUser.Instance.UsingXP ? 1 : 0;
      }
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

  private enum SearchType
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
    OutsideAdjusters,
    ManagedCareFacilities,
    ClaimEntity,
  }
}
