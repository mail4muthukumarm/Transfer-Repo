// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Forms.frmEntitySearch
// Assembly: MgaSystems.IMS.Forms, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FB3F392E-40B6-486F-8F0B-A4A494A546D4
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Forms.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinExplorerBar;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.Data.DbExtensions;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Forms;

[TestForm]
public class frmEntitySearch : Form
{
  internal Label Label2;
  internal Label Label1;
  internal MGATextBox textboxEntityName;
  private UltraExplorerBar ultraExplorerBar1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl1;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl2;
  private UltraExplorerBarContainerControl ultraExplorerBarContainerControl3;
  private IContainer components;
  private dsEntitySearch _data;
  private bool _showCompanyGroup;
  private bool _showCompany;
  private bool _showCompanyLocations;
  private bool _showCompanyLines;
  private bool _showInsured;
  private bool _showIntermediary;
  private bool _showProducer;
  private bool _showProducerLocation;
  private bool _showUsers;
  private bool _showUserGroups;
  private bool _showExpensePayees;
  private bool _show3rdParty;
  private bool _showFinanceCompanies;
  private bool _showInspectionCompanies;
  private frmEntitySearch.SearchType _entitySearchType;
  private bool _isCompanyLocationSearch;

  internal virtual UltraGrid gridEntityList
  {
    get => this._gridEntityList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridEntityList_DoubleClick);
      UltraGrid gridEntityList1 = this._gridEntityList;
      if (gridEntityList1 != null)
        ((Control) gridEntityList1).DoubleClick -= eventHandler;
      this._gridEntityList = value;
      UltraGrid gridEntityList2 = this._gridEntityList;
      if (gridEntityList2 == null)
        return;
      ((Control) gridEntityList2).DoubleClick += eventHandler;
    }
  }

  private virtual MGAButton buttonSearch
  {
    get => this._buttonSearch;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnSearch_Click);
      MGAButton buttonSearch1 = this._buttonSearch;
      if (buttonSearch1 != null)
        ((Control) buttonSearch1).Click -= eventHandler;
      this._buttonSearch = value;
      MGAButton buttonSearch2 = this._buttonSearch;
      if (buttonSearch2 == null)
        return;
      ((Control) buttonSearch2).Click += eventHandler;
    }
  }

  private virtual MGASimpleComboBox comboEntityType
  {
    get => this._comboEntityType;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      RowSelectedEventHandler selectedEventHandler = new RowSelectedEventHandler(this.comboEntityType_RowSelected);
      MGASimpleComboBox comboEntityType1 = this._comboEntityType;
      if (comboEntityType1 != null)
        comboEntityType1.RowSelected -= selectedEventHandler;
      this._comboEntityType = value;
      MGASimpleComboBox comboEntityType2 = this._comboEntityType;
      if (comboEntityType2 == null)
        return;
      comboEntityType2.RowSelected += selectedEventHandler;
    }
  }

  private virtual MGAButton buttonOpen
  {
    get => this._buttonOpen;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnOpen_Click);
      MGAButton buttonOpen1 = this._buttonOpen;
      if (buttonOpen1 != null)
        ((Control) buttonOpen1).Click -= eventHandler;
      this._buttonOpen = value;
      MGAButton buttonOpen2 = this._buttonOpen;
      if (buttonOpen2 == null)
        return;
      ((Control) buttonOpen2).Click += eventHandler;
    }
  }

  private virtual MGAButton buttonCancel
  {
    get => this._buttonCancel;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.buttonCancel_Click);
      MGAButton buttonCancel1 = this._buttonCancel;
      if (buttonCancel1 != null)
        ((Control) buttonCancel1).Click -= eventHandler;
      this._buttonCancel = value;
      MGAButton buttonCancel2 = this._buttonCancel;
      if (buttonCancel2 == null)
        return;
      ((Control) buttonCancel2).Click += eventHandler;
    }
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEntitySearch));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("EntitySearch", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("Entity Name");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EntityGUID");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    UltraExplorerBarGroup explorerBarGroup1 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup2 = new UltraExplorerBarGroup();
    UltraExplorerBarGroup explorerBarGroup3 = new UltraExplorerBarGroup();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.ultraExplorerBarContainerControl1 = new UltraExplorerBarContainerControl();
    this.buttonSearch = new MGAButton();
    this.textboxEntityName = new MGATextBox();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.comboEntityType = new MGASimpleComboBox();
    this.ultraExplorerBarContainerControl2 = new UltraExplorerBarContainerControl();
    this.gridEntityList = new UltraGrid();
    this.ultraExplorerBarContainerControl3 = new UltraExplorerBarContainerControl();
    this.buttonCancel = new MGAButton();
    this.buttonOpen = new MGAButton();
    this.ultraExplorerBar1 = new UltraExplorerBar();
    ((Control) this.ultraExplorerBarContainerControl1).SuspendLayout();
    ((ISupportInitialize) this.buttonSearch).BeginInit();
    ((ISupportInitialize) this.textboxEntityName).BeginInit();
    ((ISupportInitialize) this.comboEntityType).BeginInit();
    ((Control) this.ultraExplorerBarContainerControl2).SuspendLayout();
    ((ISupportInitialize) this.gridEntityList).BeginInit();
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
    ((Control) this.ultraExplorerBarContainerControl1).Location = new Point(10, 32 /*0x20*/);
    ((Control) this.ultraExplorerBarContainerControl1).Name = "ultraExplorerBarContainerControl1";
    ((Control) this.ultraExplorerBarContainerControl1).Size = new Size(372, 51);
    ((Control) this.ultraExplorerBarContainerControl1).TabIndex = 0;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearch).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.buttonSearch).ImageSize = new Size(24, 24);
    ((Control) this.buttonSearch).Location = new Point(320, 3);
    ((Control) this.buttonSearch).Name = "buttonSearch";
    ((Control) this.buttonSearch).Size = new Size(42, 42);
    ((Control) this.buttonSearch).TabIndex = 4;
    this.buttonSearch.UseOSThemes = (DefaultableBoolean) 2;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textboxEntityName).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.textboxEntityName).BackColor = Color.White;
    ((TextEditorControlBase) this.textboxEntityName).ForeColor = Color.Black;
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
    this.Label2.Location = new Point(0, 28);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(69, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Entity Name:";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(0, 4);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(66, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Entity Type:";
    this.comboEntityType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboEntityType.CharacterCasing = CharacterCasing.Normal;
    this.comboEntityType.DisplayStyle = (EmbeddableElementDisplayStyle) 0;
    this.comboEntityType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboEntityType).Location = new Point(72, 0);
    this.comboEntityType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboEntityType).Name = "comboEntityType";
    ((Control) this.comboEntityType).Size = new Size(240 /*0xF0*/, 21);
    ((Control) this.comboEntityType).TabIndex = 1;
    ((UltraControlBase) this.comboEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboEntityType).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.ultraExplorerBarContainerControl2).Controls.Add((Control) this.gridEntityList);
    ((Control) this.ultraExplorerBarContainerControl2).Location = new Point(10, (int) sbyte.MaxValue);
    ((Control) this.ultraExplorerBarContainerControl2).Name = "ultraExplorerBarContainerControl2";
    ((Control) this.ultraExplorerBarContainerControl2).Size = new Size(372, 328);
    ((Control) this.ultraExplorerBarContainerControl2).TabIndex = 1;
    appearance3.BackColor = Color.White;
    appearance3.BorderColor = Color.FromArgb(78, 122, 171);
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Appearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 370;
    ultraGridColumn2.Header.VisiblePosition = 1;
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
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance5.BackColor = SystemColors.Control;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.MaxSelectedRows = 1;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((Control) this.gridEntityList).Dock = DockStyle.Fill;
    ((Control) this.gridEntityList).Location = new Point(0, 0);
    ((Control) this.gridEntityList).Name = "gridEntityList";
    ((Control) this.gridEntityList).Size = new Size(372, 328);
    ((Control) this.gridEntityList).TabIndex = 5;
    ((UltraControlBase) this.gridEntityList).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonCancel);
    ((Control) this.ultraExplorerBarContainerControl3).Controls.Add((Control) this.buttonOpen);
    ((Control) this.ultraExplorerBarContainerControl3).Location = new Point(10, 476);
    ((Control) this.ultraExplorerBarContainerControl3).Name = "ultraExplorerBarContainerControl3";
    ((Control) this.ultraExplorerBarContainerControl3).Size = new Size(372, 25);
    ((Control) this.ultraExplorerBarContainerControl3).TabIndex = 2;
    ((Control) this.buttonCancel).Location = new Point(264, 0);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(104, 24);
    ((Control) this.buttonCancel).TabIndex = 8;
    ((ControlBase) this.buttonCancel).Text = "Cancel";
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonOpen).Location = new Point(152, 0);
    ((Control) this.buttonOpen).Name = "buttonOpen";
    ((Control) this.buttonOpen).Size = new Size(104, 24);
    ((Control) this.buttonOpen).TabIndex = 7;
    ((ControlBase) this.buttonOpen).Text = "Display Selection";
    this.buttonOpen.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonOpen).Visible = false;
    appearance6.BackColor = Color.White;
    appearance6.BackColor2 = Color.White;
    appearance6.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.Appearance = (AppearanceBase) appearance6;
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
    appearance7.BackColor = Color.FromArgb(239, 247, 253);
    appearance7.BackColor2 = Color.FromArgb(239, 247, 253);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.Appearance = (AppearanceBase) appearance7;
    appearance8.AlphaLevel = (short) 38;
    appearance8.BackColor = Color.FromArgb(166, 202, 238);
    appearance8.BackColor2 = Color.FromArgb(166, 202, 238);
    appearance8.BackColorAlpha = (Alpha) 2;
    appearance8.BorderColor = Color.White;
    appearance8.FontData.Name = "Tahoma";
    appearance8.FontData.SizeInPoints = 8f;
    appearance8.ForeColor = Color.DarkBlue;
    appearance8.ForegroundAlpha = (Alpha) 2;
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.HeaderAppearance = (AppearanceBase) appearance8;
    appearance9.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    this.ultraExplorerBar1.GroupSettings.AppearancesSmall.ItemAreaAppearance = (AppearanceBase) appearance9;
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
    ((Control) this.ultraExplorerBar1).TabIndex = 7;
    this.ultraExplorerBar1.UseLargeGroupHeaderImages = (DefaultableBoolean) 2;
    ((UltraControlBase) this.ultraExplorerBar1).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraExplorerBar1.ViewStyle = (UltraExplorerBarViewStyle) 2;
    this.AcceptButton = (IButtonControl) this.buttonSearch;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(392, 520);
    this.ControlBox = false;
    this.Controls.Add((Control) this.ultraExplorerBar1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmEntitySearch);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Entity Search";
    ((Control) this.ultraExplorerBarContainerControl1).ResumeLayout(false);
    ((Control) this.ultraExplorerBarContainerControl1).PerformLayout();
    ((ISupportInitialize) this.buttonSearch).EndInit();
    ((ISupportInitialize) this.textboxEntityName).EndInit();
    ((ISupportInitialize) this.comboEntityType).EndInit();
    ((Control) this.ultraExplorerBarContainerControl2).ResumeLayout(false);
    ((ISupportInitialize) this.gridEntityList).EndInit();
    ((Control) this.ultraExplorerBarContainerControl3).ResumeLayout(false);
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonOpen).EndInit();
    ((ISupportInitialize) this.ultraExplorerBar1).EndInit();
    ((Control) this.ultraExplorerBar1).ResumeLayout(false);
    this.ResumeLayout(false);
  }

  public frmEntitySearch()
  {
    this.Load += new EventHandler(this.frmEntitySearch_Load);
    this._data = new dsEntitySearch();
    this.InitializeComponent();
    this._showCompanyGroup = true;
    this._showCompany = true;
    this._showCompanyLocations = true;
    this._showCompanyLines = true;
    this._showInsured = true;
    this._showIntermediary = true;
    this._showProducer = true;
    this._showProducerLocation = true;
    this._showUsers = true;
    this._showUserGroups = true;
    this._showExpensePayees = true;
    this._show3rdParty = true;
    this._showFinanceCompanies = true;
    this._showInspectionCompanies = true;
  }

  public frmEntitySearch(frmEntitySearch.SearchEntityTypes showEntities)
  {
    this.Load += new EventHandler(this.frmEntitySearch_Load);
    this._data = new dsEntitySearch();
    this.InitializeComponent();
    this._showCompanyGroup = (showEntities & frmEntitySearch.SearchEntityTypes.ShowCompanyGroup) > frmEntitySearch.SearchEntityTypes.None;
    this._showCompany = (showEntities & frmEntitySearch.SearchEntityTypes.ShowCompany) > frmEntitySearch.SearchEntityTypes.None;
    this._showCompanyLocations = (showEntities & frmEntitySearch.SearchEntityTypes.ShowCompanyLocations) > frmEntitySearch.SearchEntityTypes.None;
    this._showCompanyLines = (showEntities & frmEntitySearch.SearchEntityTypes.ShowCompanyLines) > frmEntitySearch.SearchEntityTypes.None;
    this._showInsured = (showEntities & frmEntitySearch.SearchEntityTypes.ShowInsured) > frmEntitySearch.SearchEntityTypes.None;
    this._showIntermediary = (showEntities & frmEntitySearch.SearchEntityTypes.ShowIntermediary) > frmEntitySearch.SearchEntityTypes.None;
    this._showProducer = (showEntities & frmEntitySearch.SearchEntityTypes.ShowProducer) > frmEntitySearch.SearchEntityTypes.None;
    this._showProducerLocation = (showEntities & frmEntitySearch.SearchEntityTypes.ShowProducerLocation) > frmEntitySearch.SearchEntityTypes.None;
    this._showUsers = (showEntities & frmEntitySearch.SearchEntityTypes.ShowUsers) > frmEntitySearch.SearchEntityTypes.None;
    this._showUserGroups = (showEntities & frmEntitySearch.SearchEntityTypes.ShowUserGroups) > frmEntitySearch.SearchEntityTypes.None;
    this._showExpensePayees = (showEntities & frmEntitySearch.SearchEntityTypes.ShowExpensePayees) > frmEntitySearch.SearchEntityTypes.None;
    this._show3rdParty = (showEntities & frmEntitySearch.SearchEntityTypes.Show3rdParty) > frmEntitySearch.SearchEntityTypes.None;
    this._showFinanceCompanies = (showEntities & frmEntitySearch.SearchEntityTypes.ShowFinanceCompanies) > frmEntitySearch.SearchEntityTypes.None;
    this._showInspectionCompanies = (showEntities & frmEntitySearch.SearchEntityTypes.ShowInspectionCompanies) > frmEntitySearch.SearchEntityTypes.None;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  public Guid EntityGuid
  {
    get
    {
      return this.gridEntityList.Selected.Rows.Count == 0 ? Guid.Empty : new Guid(this.gridEntityList.Selected.Rows[0].Cells[1].Value.ToString());
    }
  }

  public string EntityName
  {
    get
    {
      return this.gridEntityList.Selected.Rows.Count == 0 ? string.Empty : this.gridEntityList.Selected.Rows[0].Cells[0].Value.ToString();
    }
  }

  private void BindEntityTypeCombo()
  {
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add(new DataColumn("EntityType", typeof (string)));
    dataTable.Columns.Add(new DataColumn("TypeCode", typeof (string)));
    if (this._showCompanyGroup)
      dataTable.Rows.Add((object) SR.GetString("COMPANYGROUP"), (object) "CG");
    if (this._showCompany)
      dataTable.Rows.Add((object) SR.GetString("COMPANY"), (object) "CO");
    if (this._showCompanyLocations)
      dataTable.Rows.Add((object) SR.GetString("COMPANYLOCATION"), (object) "CL");
    if (this._showCompanyLines)
      dataTable.Rows.Add((object) SR.GetString("COMPANYLINE"), (object) "C");
    if (this._showInsured)
      dataTable.Rows.Add((object) SR.GetString("INSURED"), (object) "I");
    if (this._showIntermediary)
      dataTable.Rows.Add((object) SR.GetString("INTERMEDIARY"), (object) "IN");
    if (this._showProducer)
      dataTable.Rows.Add((object) SR.GetString("PRODUCER"), (object) "P");
    if (this._showProducerLocation)
      dataTable.Rows.Add((object) SR.GetString("PRODUCERLOCATION"), (object) "PL");
    if (this._showUsers)
      dataTable.Rows.Add((object) SR.GetString("USER"), (object) "U");
    if (this._showUserGroups)
      dataTable.Rows.Add((object) SR.GetString("USERGROUP"), (object) "G");
    if (this._showExpensePayees)
      dataTable.Rows.Add((object) SR.GetString("EXPENSEPAYEE"), (object) "X");
    if (this._show3rdParty)
      dataTable.Rows.Add((object) SR.GetString("3RDPARTYPAYEE"), (object) "3");
    if (this._showFinanceCompanies)
      dataTable.Rows.Add((object) SR.GetString("FINANCECOMPANY"), (object) "FI");
    if (this._showInspectionCompanies)
      dataTable.Rows.Add((object) SR.GetString("INSPECTIONCOMPANY"), (object) "NS");
    ((UltraGridBase) this.comboEntityType).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboEntityType).DisplayMember = "EntityType";
    ((UltraDropDownBase) this.comboEntityType).ValueMember = "TypeCode";
  }

  private void ExecuteSearch(string _EntityType, string _EntityName)
  {
    DbConnection dbConnection = DefaultDatabase.CreateDbConnection();
    DbCommand command = DefaultDatabase.CreateCommand("EntitySearch", dbConnection);
    DbDataAdapter dataAdapter = DefaultDatabase.CreateDataAdapter(command);
    command.CommandType = CommandType.StoredProcedure;
    DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@ENTITYTYPE", (object) _EntityType);
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(_EntityName.Trim(), "", false) != 0)
      DbParameterCollectionExtensions.AddWithValue(command.Parameters, "@ENTITYNAME", (object) _EntityName);
    this._data.EntitySearch.Clear();
    try
    {
      DefaultDatabase.DataAdapterFill(dataAdapter, (DataTable) this._data.EntitySearch);
    }
    finally
    {
      dbConnection.Dispose();
      command.Dispose();
      dataAdapter.Dispose();
    }
    if (this._data.EntitySearch.Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("The specified entity could not be found, please try again!", "Entity Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      ((UltraGridBase) this.gridEntityList).DataSource = (object) this._data.EntitySearch;
      ((Control) this.gridEntityList).Focus();
      ((UltraGridBase) this.gridEntityList).ActiveRow = ((UltraGridBase) this.gridEntityList).Rows[0];
      ((UltraGridBase) this.gridEntityList).Rows[0].Selected = true;
    }
  }

  private void comboEntityType_RowSelected(object sender, RowSelectedEventArgs e)
  {
    if (((UltraDropDownBase) this.comboEntityType).SelectedRow == null)
      return;
    string str = ((UltraDropDownBase) this.comboEntityType).SelectedRow.Cells["typecode"].Value.ToString();
    // ISSUE: reference to a compiler-generated method
    switch (\u003CPrivateImplementationDetails\u003E.ComputeStringHash(str))
    {
      case 620754425:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "PL", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.ProducerLocation;
          break;
        }
        goto default;
      case 635854758:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "NS", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.InspectionCompany;
          break;
        }
        goto default;
      case 906799682:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "3", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.ThirdPartyPayee;
          break;
        }
        goto default;
      case 1625881374:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "IN", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.Intermediary;
          break;
        }
        goto default;
      case 2044336111:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CG", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.CompanyGroup;
          break;
        }
        goto default;
      case 2077450064:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "FI", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.FinanceCompany;
          break;
        }
        goto default;
      case 2178557063:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CO", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.Company;
          break;
        }
        goto default;
      case 2195334682:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CL", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.CompanyLocation;
          break;
        }
        goto default;
      case 3255563174:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "G", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.UserGroup;
          break;
        }
        goto default;
      case 3322673650:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "C", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.CompanyLine;
          break;
        }
        goto default;
      case 3423339364:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "I", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.Insured;
          break;
        }
        goto default;
      case 3490449840:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "U", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.User;
          break;
        }
        goto default;
      case 3574337935:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.Producer;
          break;
        }
        goto default;
      case 3708558887:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "X", false) == 0)
        {
          this._entitySearchType = frmEntitySearch.SearchType.ExpensePayee;
          break;
        }
        goto default;
      default:
        this._entitySearchType = frmEntitySearch.SearchType.None;
        break;
    }
    this.AcceptButton = (IButtonControl) this.buttonSearch;
  }

  private void btnSearch_Click(object sender, EventArgs e)
  {
    if (((UltraDropDownBase) this.comboEntityType).SelectedRow == null)
    {
      int num = (int) MessageBox.Show("You must select an entity type to continue.", "No Entity Type Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      this.Cursor = Cursors.WaitCursor;
      switch (this._entitySearchType)
      {
        case frmEntitySearch.SearchType.CompanyGroup:
          this.ExecuteSearch("CG", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.Company:
          this.ExecuteSearch("CO", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.CompanyLocation:
          this.ExecuteSearch("CL", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = true;
          break;
        case frmEntitySearch.SearchType.CompanyLine:
          this.ExecuteSearch("C", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.Insured:
          this.ExecuteSearch("I", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.Intermediary:
          this.ExecuteSearch("IN", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.Producer:
          this.ExecuteSearch("P", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.ProducerLocation:
          this.ExecuteSearch("PL", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.User:
          this.ExecuteSearch("U", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.UserGroup:
          this.ExecuteSearch("G", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.ExpensePayee:
          this.ExecuteSearch("X", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.ThirdPartyPayee:
          this.ExecuteSearch("3", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.FinanceCompany:
          this.ExecuteSearch("FI", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
        case frmEntitySearch.SearchType.InspectionCompany:
          this.ExecuteSearch("NS", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this._isCompanyLocationSearch = false;
          break;
      }
      if (((UltraGridBase) this.gridEntityList).Rows.Count == 500 && CurrentUser.Instance.UsingXP)
        BalloonTip.ShowEditTip((Control) this.textboxEntityName, SR.GetString("LIMITING_RESULTS"), SR.GetString("TOOMANY_RESULTS_RETURNED"), BalloonTip.BalloonTipIcons.Info);
      this.AcceptButton = (IButtonControl) this.buttonOpen;
      this.Cursor = Cursors.Default;
    }
  }

  private void btnOpen_Click(object sender, EventArgs e)
  {
    if (this.gridEntityList.Selected.Rows.Count == 0)
      return;
    this.DialogResult = DialogResult.OK;
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void gridEntityList_DoubleClick(object sender, EventArgs e)
  {
    UltraGridRow context = (UltraGridRow) ((ControlUIElementBase) ((UltraGridBase) this.gridEntityList).DisplayLayout.UIElement).LastElementEntered.GetContext(typeof (UltraGridRow));
    if (context == null)
      return;
    context.Selected = true;
    context.Activate();
    this.DialogResult = DialogResult.OK;
  }

  private void frmEntitySearch_Load(object sender, EventArgs e) => this.BindEntityTypeCombo();

  [Flags]
  public enum SearchEntityTypes
  {
    None = 0,
    ShowCompanyGroup = 2,
    ShowCompany = 4,
    ShowCompanyLocations = 8,
    ShowCompanyLines = 16, // 0x00000010
    ShowInsured = 32, // 0x00000020
    ShowIntermediary = 64, // 0x00000040
    ShowProducer = 128, // 0x00000080
    ShowProducerLocation = 256, // 0x00000100
    ShowUsers = 512, // 0x00000200
    ShowUserGroups = 1024, // 0x00000400
    ShowExpensePayees = 2048, // 0x00000800
    Show3rdParty = 4096, // 0x00001000
    ShowFinanceCompanies = 8192, // 0x00002000
    ShowInspectionCompanies = 16384, // 0x00004000
    All = ShowInspectionCompanies | ShowFinanceCompanies | Show3rdParty | ShowExpensePayees | ShowUserGroups | ShowUsers | ShowProducerLocation | ShowProducer | ShowIntermediary | ShowInsured | ShowCompanyLines | ShowCompanyLocations | ShowCompany | ShowCompanyGroup, // 0x00007FFE
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
  }
}
