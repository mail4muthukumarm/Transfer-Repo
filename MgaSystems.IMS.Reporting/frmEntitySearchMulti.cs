// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Reporting.frmEntitySearchMulti
// Assembly: MgaSystems.IMS.Reporting, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: D0217E27-C87B-4FD0-8041-819EA70A118B
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Reporting.dll

using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using MGASystems.Common;
using MGASystems.Common.DataAccess;
using MGASystems.Data;
using MGASystems.Tools;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Reporting;

public class frmEntitySearchMulti : Form
{
  internal ToolTip ToolTip1;
  internal Label Label2;
  internal Label Label1;
  internal MGATextBox textboxEntityName;
  private IContainer components;
  private DataTable _dtSelected;
  private dsEntitySearch _data;
  private dsEntitySearch _selectedData;
  private string _PreSelectedEntity;
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
  private frmEntitySearchMulti.SearchType EntitySearchType;
  private bool IsCompanyLocationSearch;

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

  [field: AccessedThroughProperty("Panel1")]
  internal virtual Panel Panel1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel2")]
  internal virtual Panel Panel2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label3")]
  internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel3")]
  internal virtual Panel Panel3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Panel7")]
  internal virtual Panel Panel7 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnAddToSelected
  {
    get => this._btnAddToSelected;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnAddToSelected_Click);
      MGAButton btnAddToSelected1 = this._btnAddToSelected;
      if (btnAddToSelected1 != null)
        ((Control) btnAddToSelected1).Click -= eventHandler;
      this._btnAddToSelected = value;
      MGAButton btnAddToSelected2 = this._btnAddToSelected;
      if (btnAddToSelected2 == null)
        return;
      ((Control) btnAddToSelected2).Click += eventHandler;
    }
  }

  internal virtual UltraGrid gridSelectedEntities
  {
    get => this._gridSelectedEntities;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridEntityList_DoubleClick);
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.grid_SelectionDrag);
      DragEventHandler dragEventHandler1 = new DragEventHandler(this.grid_DragOver);
      DragEventHandler dragEventHandler2 = new DragEventHandler(this.grid_DragDrop);
      UltraGrid selectedEntities1 = this._gridSelectedEntities;
      if (selectedEntities1 != null)
      {
        ((Control) selectedEntities1).DoubleClick -= eventHandler;
        selectedEntities1.SelectionDrag -= cancelEventHandler;
        ((Control) selectedEntities1).DragOver -= dragEventHandler1;
        ((Control) selectedEntities1).DragDrop -= dragEventHandler2;
      }
      this._gridSelectedEntities = value;
      UltraGrid selectedEntities2 = this._gridSelectedEntities;
      if (selectedEntities2 == null)
        return;
      ((Control) selectedEntities2).DoubleClick += eventHandler;
      selectedEntities2.SelectionDrag += cancelEventHandler;
      ((Control) selectedEntities2).DragOver += dragEventHandler1;
      ((Control) selectedEntities2).DragDrop += dragEventHandler2;
    }
  }

  internal virtual UltraGrid gridEntityList
  {
    get => this._gridEntityList;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.gridEntityList_DoubleClick);
      CancelEventHandler cancelEventHandler = new CancelEventHandler(this.grid_SelectionDrag);
      DragEventHandler dragEventHandler1 = new DragEventHandler(this.grid_DragOver);
      DragEventHandler dragEventHandler2 = new DragEventHandler(this.grid_DragDrop);
      UltraGrid gridEntityList1 = this._gridEntityList;
      if (gridEntityList1 != null)
      {
        ((Control) gridEntityList1).DoubleClick -= eventHandler;
        gridEntityList1.SelectionDrag -= cancelEventHandler;
        ((Control) gridEntityList1).DragOver -= dragEventHandler1;
        ((Control) gridEntityList1).DragDrop -= dragEventHandler2;
      }
      this._gridEntityList = value;
      UltraGrid gridEntityList2 = this._gridEntityList;
      if (gridEntityList2 == null)
        return;
      ((Control) gridEntityList2).DoubleClick += eventHandler;
      gridEntityList2.SelectionDrag += cancelEventHandler;
      ((Control) gridEntityList2).DragOver += dragEventHandler1;
      ((Control) gridEntityList2).DragDrop += dragEventHandler2;
    }
  }

  [field: AccessedThroughProperty("Panel8")]
  internal virtual Panel Panel8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label4")]
  internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  [field: AccessedThroughProperty("Label6")]
  internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

  private virtual MGAButton btnRemoveFromSelected
  {
    get => this._btnRemoveFromSelected;
    [MethodImpl(MethodImplOptions.Synchronized)] set
    {
      EventHandler eventHandler = new EventHandler(this.btnRemoveFromSelected_Click);
      MGAButton removeFromSelected1 = this._btnRemoveFromSelected;
      if (removeFromSelected1 != null)
        ((Control) removeFromSelected1).Click -= eventHandler;
      this._btnRemoveFromSelected = value;
      MGAButton removeFromSelected2 = this._btnRemoveFromSelected;
      if (removeFromSelected2 == null)
        return;
      ((Control) removeFromSelected2).Click += eventHandler;
    }
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (frmEntitySearchMulti));
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("EntitySearch", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("EntityName");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EntityGUID");
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    UltraGridBand ultraGridBand2 = new UltraGridBand("EntitySearch", -1);
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("EntityName");
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("EntityGUID");
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    this.buttonSearch = new MGAButton();
    this.textboxEntityName = new MGATextBox();
    this.Label2 = new Label();
    this.Label1 = new Label();
    this.comboEntityType = new MGASimpleComboBox();
    this.buttonCancel = new MGAButton();
    this.buttonOpen = new MGAButton();
    this.ToolTip1 = new ToolTip(this.components);
    this.Panel1 = new Panel();
    this.Panel2 = new Panel();
    this.Label3 = new Label();
    this.Panel3 = new Panel();
    this.Panel7 = new Panel();
    this.btnRemoveFromSelected = new MGAButton();
    this.btnAddToSelected = new MGAButton();
    this.gridSelectedEntities = new UltraGrid();
    this.gridEntityList = new UltraGrid();
    this.Panel8 = new Panel();
    this.Label4 = new Label();
    this.Label6 = new Label();
    ((ISupportInitialize) this.buttonSearch).BeginInit();
    ((ISupportInitialize) this.textboxEntityName).BeginInit();
    ((ISupportInitialize) this.comboEntityType).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonOpen).BeginInit();
    this.Panel1.SuspendLayout();
    this.Panel2.SuspendLayout();
    this.Panel3.SuspendLayout();
    this.Panel7.SuspendLayout();
    ((ISupportInitialize) this.btnRemoveFromSelected).BeginInit();
    ((ISupportInitialize) this.btnAddToSelected).BeginInit();
    ((ISupportInitialize) this.gridSelectedEntities).BeginInit();
    ((ISupportInitialize) this.gridEntityList).BeginInit();
    this.Panel8.SuspendLayout();
    this.SuspendLayout();
    ((Control) this.buttonSearch).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance1.BackColor = Color.FromArgb(248, 248, 248);
    appearance1.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance1.BackGradientStyle = (GradientStyle) 2;
    appearance1.BorderColor = Color.DarkGray;
    appearance1.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance1.Image"));
    appearance1.ImageHAlign = (HAlign) 2;
    appearance1.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSearch).Appearance = (AppearanceBase) appearance1;
    ((ControlBase) this.buttonSearch).ImageSize = new Size(24, 24);
    ((Control) this.buttonSearch).Location = new Point(615, 32 /*0x20*/);
    ((Control) this.buttonSearch).Name = "buttonSearch";
    ((Control) this.buttonSearch).Size = new Size(42, 42);
    ((Control) this.buttonSearch).TabIndex = 4;
    this.buttonSearch.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.textboxEntityName).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    appearance2.BackColor = Color.White;
    appearance2.BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    appearance2.ForeColor = Color.Black;
    ((TextEditorControlBase) this.textboxEntityName).Appearance = (AppearanceBase) appearance2;
    ((TextEditorControlBase) this.textboxEntityName).BackColor = Color.White;
    ((TextEditorControlBase) this.textboxEntityName).ForeColor = Color.Black;
    ((Control) this.textboxEntityName).Location = new Point(82, 56);
    ((TextEditorControlBase) this.textboxEntityName).MaxLength = 25;
    this.textboxEntityName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textboxEntityName).Name = "textboxEntityName";
    ((Control) this.textboxEntityName).Size = new Size(527, 20);
    ((Control) this.textboxEntityName).TabIndex = 3;
    ((UltraControlBase) this.textboxEntityName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textboxEntityName).UseOsThemes = (DefaultableBoolean) 2;
    this.Label2.AutoSize = true;
    this.Label2.BackColor = Color.Transparent;
    this.Label2.Location = new Point(10, 56);
    this.Label2.Name = "Label2";
    this.Label2.Size = new Size(69, 13);
    this.Label2.TabIndex = 2;
    this.Label2.Text = "Entity Name:";
    this.Label1.AutoSize = true;
    this.Label1.BackColor = Color.Transparent;
    this.Label1.Location = new Point(10, 32 /*0x20*/);
    this.Label1.Name = "Label1";
    this.Label1.Size = new Size(66, 13);
    this.Label1.TabIndex = 0;
    this.Label1.Text = "Entity Type:";
    ((Control) this.comboEntityType).Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
    this.comboEntityType.BorderStyle = (UIElementBorderStyle) 4;
    this.comboEntityType.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.comboEntityType).Location = new Point(82, 32 /*0x20*/);
    this.comboEntityType.MGAStyle = MGAStyles.Blue;
    ((Control) this.comboEntityType).Name = "comboEntityType";
    ((Control) this.comboEntityType).Size = new Size(527, 21);
    ((Control) this.comboEntityType).TabIndex = 1;
    ((UltraControlBase) this.comboEntityType).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.comboEntityType).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance3.BackColor = Color.FromArgb(248, 248, 248);
    appearance3.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance3.BackGradientStyle = (GradientStyle) 2;
    appearance3.BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance3;
    ((Control) this.buttonCancel).Location = new Point(544, 9);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(104, 24);
    ((Control) this.buttonCancel).TabIndex = 8;
    ((ControlBase) this.buttonCancel).Text = "Cancel";
    this.buttonCancel.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonOpen).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance4.BackColor = Color.FromArgb(248, 248, 248);
    appearance4.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance4.BackGradientStyle = (GradientStyle) 2;
    appearance4.BorderColor = Color.DarkGray;
    ((ControlBase) this.buttonOpen).Appearance = (AppearanceBase) appearance4;
    ((Control) this.buttonOpen).Location = new Point(432, 9);
    ((Control) this.buttonOpen).Name = "buttonOpen";
    ((Control) this.buttonOpen).Size = new Size(104, 24);
    ((Control) this.buttonOpen).TabIndex = 7;
    ((ControlBase) this.buttonOpen).Text = "Display Selection";
    this.buttonOpen.UseOSThemes = (DefaultableBoolean) 2;
    this.Panel1.BackColor = Color.FromArgb(239, 247, 253);
    this.Panel1.Controls.Add((Control) this.buttonSearch);
    this.Panel1.Controls.Add((Control) this.Panel2);
    this.Panel1.Controls.Add((Control) this.textboxEntityName);
    this.Panel1.Controls.Add((Control) this.Label2);
    this.Panel1.Controls.Add((Control) this.comboEntityType);
    this.Panel1.Controls.Add((Control) this.Label1);
    this.Panel1.Dock = DockStyle.Top;
    this.Panel1.Location = new Point(0, 0);
    this.Panel1.Name = "Panel1";
    this.Panel1.Size = new Size(660, 80 /*0x50*/);
    this.Panel1.TabIndex = 8;
    this.Panel2.BackColor = Color.FromArgb(166, 202, 238);
    this.Panel2.Controls.Add((Control) this.Label3);
    this.Panel2.Dock = DockStyle.Top;
    this.Panel2.Location = new Point(0, 0);
    this.Panel2.Name = "Panel2";
    this.Panel2.Size = new Size(660, 28);
    this.Panel2.TabIndex = 0;
    this.Label3.AutoSize = true;
    this.Label3.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label3.ForeColor = Color.FromArgb(0, 0, 139);
    this.Label3.Location = new Point(15, 7);
    this.Label3.Name = "Label3";
    this.Label3.Size = new Size(91, 13);
    this.Label3.TabIndex = 0;
    this.Label3.Text = "Search Criteria";
    this.Panel3.BackColor = Color.FromArgb(239, 247, 253);
    this.Panel3.Controls.Add((Control) this.buttonCancel);
    this.Panel3.Controls.Add((Control) this.buttonOpen);
    this.Panel3.Dock = DockStyle.Bottom;
    this.Panel3.Location = new Point(0, 453);
    this.Panel3.Name = "Panel3";
    this.Panel3.Size = new Size(660, 44);
    this.Panel3.TabIndex = 9;
    this.Panel7.BackColor = Color.FromArgb(239, 247, 253);
    this.Panel7.Controls.Add((Control) this.btnRemoveFromSelected);
    this.Panel7.Controls.Add((Control) this.btnAddToSelected);
    this.Panel7.Controls.Add((Control) this.gridSelectedEntities);
    this.Panel7.Controls.Add((Control) this.gridEntityList);
    this.Panel7.Controls.Add((Control) this.Panel8);
    this.Panel7.Dock = DockStyle.Fill;
    this.Panel7.Location = new Point(0, 80 /*0x50*/);
    this.Panel7.Name = "Panel7";
    this.Panel7.Size = new Size(660, 373);
    this.Panel7.TabIndex = 11;
    ((Control) this.btnRemoveFromSelected).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance5.BackColor = Color.FromArgb(248, 248, 248);
    appearance5.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance5.BackGradientStyle = (GradientStyle) 2;
    appearance5.BorderColor = Color.DarkGray;
    appearance5.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance5.Image"));
    appearance5.ImageHAlign = (HAlign) 2;
    appearance5.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnRemoveFromSelected).Appearance = (AppearanceBase) appearance5;
    ((Control) this.btnRemoveFromSelected).Location = new Point(286, 151);
    ((Control) this.btnRemoveFromSelected).Name = "btnRemoveFromSelected";
    ((Control) this.btnRemoveFromSelected).Size = new Size(88, 24);
    ((Control) this.btnRemoveFromSelected).TabIndex = 9;
    this.ToolTip1.SetToolTip((Control) this.btnRemoveFromSelected, "Remove from selectes entities list");
    this.btnRemoveFromSelected.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.btnAddToSelected).Anchor = AnchorStyles.Top | AnchorStyles.Right;
    appearance6.BackColor = Color.FromArgb(248, 248, 248);
    appearance6.BackColor2 = Color.FromArgb(250, 250, 250);
    appearance6.BackGradientStyle = (GradientStyle) 2;
    appearance6.BorderColor = Color.DarkGray;
    appearance6.Image = RuntimeHelpers.GetObjectValue(componentResourceManager.GetObject("Appearance6.Image"));
    appearance6.ImageHAlign = (HAlign) 2;
    appearance6.ImageVAlign = (VAlign) 2;
    ((ControlBase) this.btnAddToSelected).Appearance = (AppearanceBase) appearance6;
    ((Control) this.btnAddToSelected).Location = new Point(286, 105);
    ((Control) this.btnAddToSelected).Name = "btnAddToSelected";
    ((Control) this.btnAddToSelected).Size = new Size(88, 24);
    ((Control) this.btnAddToSelected).TabIndex = 8;
    this.ToolTip1.SetToolTip((Control) this.btnAddToSelected, "Move to selectes entities list");
    this.btnAddToSelected.UseOSThemes = (DefaultableBoolean) 2;
    ((Control) this.gridSelectedEntities).AllowDrop = true;
    ((Control) this.gridSelectedEntities).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
    appearance7.BackColor = Color.White;
    appearance7.BorderColor = Color.FromArgb(78, 122, 171);
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Appearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand1.ColHeadersVisible = false;
    ultraGridColumn1.Header.VisiblePosition = 0;
    ultraGridColumn1.Width = 370;
    ultraGridColumn2.Header.VisiblePosition = 1;
    ultraGridColumn2.Hidden = true;
    ultraGridBand1.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowRowFiltering = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.BorderStyleCardArea = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.BorderStyleCell = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.BorderStyleHeader = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.BorderStyleRow = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.BorderStyleRowSelector = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.BorderStyleSummaryFooter = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.BorderStyleSummaryFooterCaption = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.BorderStyleSummaryValue = (UIElementBorderStyle) 1;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.BorderStyleTemplateAddRow = (UIElementBorderStyle) 1;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance9.BackColor = SystemColors.Control;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Override.SelectTypeRow = (SelectType) 4;
    ((Control) this.gridSelectedEntities).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridSelectedEntities).Location = new Point(380, 28);
    ((Control) this.gridSelectedEntities).Name = "gridSelectedEntities";
    ((Control) this.gridSelectedEntities).Size = new Size(280, 345);
    ((Control) this.gridSelectedEntities).TabIndex = 6;
    ((Control) this.gridSelectedEntities).Tag = (object) "sel entities";
    ((UltraControlBase) this.gridSelectedEntities).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this.gridEntityList).AllowDrop = true;
    ((Control) this.gridEntityList).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
    appearance10.BackColor = Color.White;
    appearance10.BorderColor = Color.FromArgb(78, 122, 171);
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Appearance = (AppearanceBase) appearance10;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.AutoFitStyle = (AutoFitStyle) 2;
    ultraGridBand2.ColHeadersVisible = false;
    ultraGridColumn3.Header.VisiblePosition = 0;
    ultraGridColumn3.Width = 370;
    ultraGridColumn4.Header.VisiblePosition = 1;
    ultraGridColumn4.Hidden = true;
    ultraGridBand2.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn3,
      (object) ultraGridColumn4
    });
    ((UltraGridBase) this.gridEntityList).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
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
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance11;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    appearance12.BackColor = SystemColors.Control;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridEntityList).DisplayLayout.Override.SelectTypeRow = (SelectType) 4;
    ((Control) this.gridEntityList).Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridEntityList).Location = new Point(0, 28);
    ((Control) this.gridEntityList).Name = "gridEntityList";
    ((Control) this.gridEntityList).Size = new Size(280, 345);
    ((Control) this.gridEntityList).TabIndex = 5;
    ((Control) this.gridEntityList).Tag = (object) "all entities";
    ((UltraControlBase) this.gridEntityList).UseFlatMode = (DefaultableBoolean) 1;
    this.Panel8.BackColor = Color.FromArgb(166, 202, 238);
    this.Panel8.Controls.Add((Control) this.Label4);
    this.Panel8.Controls.Add((Control) this.Label6);
    this.Panel8.Location = new Point(0, 0);
    this.Panel8.Name = "Panel8";
    this.Panel8.Size = new Size(660, 28);
    this.Panel8.TabIndex = 0;
    this.Label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
    this.Label4.AutoSize = true;
    this.Label4.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label4.ForeColor = Color.FromArgb(0, 0, 139);
    this.Label4.Location = new Point(391, 7);
    this.Label4.Name = "Label4";
    this.Label4.Size = new Size(59, 13);
    this.Label4.TabIndex = 1;
    this.Label4.Text = "Selection";
    this.Label6.AutoSize = true;
    this.Label6.Font = new Font("Tahoma", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.Label6.ForeColor = Color.FromArgb(0, 0, 139);
    this.Label6.Location = new Point(15, 7);
    this.Label6.Name = "Label6";
    this.Label6.Size = new Size(49, 13);
    this.Label6.TabIndex = 0;
    this.Label6.Text = "Results";
    this.AcceptButton = (IButtonControl) this.buttonSearch;
    this.AutoScaleBaseSize = new Size(5, 14);
    this.BackColor = Color.White;
    this.ClientSize = new Size(660, 497);
    this.ControlBox = false;
    this.Controls.Add((Control) this.Panel7);
    this.Controls.Add((Control) this.Panel3);
    this.Controls.Add((Control) this.Panel1);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (frmEntitySearchMulti);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Entity Search";
    ((ISupportInitialize) this.buttonSearch).EndInit();
    ((ISupportInitialize) this.textboxEntityName).EndInit();
    ((ISupportInitialize) this.comboEntityType).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonOpen).EndInit();
    this.Panel1.ResumeLayout(false);
    this.Panel1.PerformLayout();
    this.Panel2.ResumeLayout(false);
    this.Panel2.PerformLayout();
    this.Panel3.ResumeLayout(false);
    this.Panel7.ResumeLayout(false);
    ((ISupportInitialize) this.btnRemoveFromSelected).EndInit();
    ((ISupportInitialize) this.btnAddToSelected).EndInit();
    ((ISupportInitialize) this.gridSelectedEntities).EndInit();
    ((ISupportInitialize) this.gridEntityList).EndInit();
    this.Panel8.ResumeLayout(false);
    this.Panel8.PerformLayout();
    this.ResumeLayout(false);
  }

  public frmEntitySearchMulti()
  {
    this.Load += new EventHandler(this.frmEntitySearchMulti_Load);
    this._data = new dsEntitySearch();
    this._selectedData = new dsEntitySearch();
    this._PreSelectedEntity = "";
    this.IsCompanyLocationSearch = false;
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

  public frmEntitySearchMulti(
    frmEntitySearchMulti.SearchEntityTypes ShowEntities,
    string PreSelectedEntity = "")
  {
    this.Load += new EventHandler(this.frmEntitySearchMulti_Load);
    this._data = new dsEntitySearch();
    this._selectedData = new dsEntitySearch();
    this._PreSelectedEntity = "";
    this.IsCompanyLocationSearch = false;
    this.InitializeComponent();
    this.showCompanyGroup = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowCompanyGroup) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showCompany = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowCompany) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showCompanyLocations = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowCompanyLocations) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showCompanyLines = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowCompanyLines) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showInsured = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowInsured) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showIntermediary = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowIntermediary) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showProducer = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowProducer) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showProducerLocation = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowProducerLocation) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showUsers = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowUsers) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showUserGroups = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowUserGroups) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showExpensePayees = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowExpensePayees) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.show3rdParty = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.Show3rdParty) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showFinanceCompanies = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowFinanceCompanies) > frmEntitySearchMulti.SearchEntityTypes.None;
    this.showInspectionCompanies = (ShowEntities & frmEntitySearchMulti.SearchEntityTypes.ShowInspectionCompanies) > frmEntitySearchMulti.SearchEntityTypes.None;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PreSelectedEntity, "", false) == 0)
      return;
    this._PreSelectedEntity = PreSelectedEntity;
  }

  public frmEntitySearchMulti(
    bool ShowCompanyLocation,
    bool ShowCompany,
    bool ShowCompanyGroup,
    string PreSelectedEntity = "")
  {
    this.Load += new EventHandler(this.frmEntitySearchMulti_Load);
    this._data = new dsEntitySearch();
    this._selectedData = new dsEntitySearch();
    this._PreSelectedEntity = "";
    this.IsCompanyLocationSearch = false;
    this.InitializeComponent();
    this.showCompanyLocations = ShowCompanyLocation;
    this.showCompany = ShowCompany;
    this.showCompanyGroup = ShowCompanyGroup;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(PreSelectedEntity, "", false) == 0)
      return;
    this._PreSelectedEntity = PreSelectedEntity;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  internal List<frmEntitySearchMulti.clsSelectedEntity> SelectedEntities
  {
    get
    {
      List<frmEntitySearchMulti.clsSelectedEntity> selectedEntities = new List<frmEntitySearchMulti.clsSelectedEntity>();
      foreach (UltraGridRow row in ((UltraGridBase) this.gridSelectedEntities).Rows)
      {
        List<frmEntitySearchMulti.clsSelectedEntity> clsSelectedEntityList = selectedEntities;
        string Text = Conversions.ToString(row.Cells[0].Value);
        object obj = row.Cells[1].Value;
        Guid guid = obj != null ? (Guid) obj : new Guid();
        frmEntitySearchMulti.clsSelectedEntity clsSelectedEntity = new frmEntitySearchMulti.clsSelectedEntity(Text, guid);
        clsSelectedEntityList.Add(clsSelectedEntity);
      }
      return selectedEntities;
    }
  }

  private void BindEntityTypeCombo()
  {
    DataTable dataTable = new DataTable();
    dataTable.Columns.Add(new DataColumn("EntityType", typeof (string)));
    dataTable.Columns.Add(new DataColumn("TypeCode", typeof (string)));
    if (this.showCompanyGroup)
      dataTable.Rows.Add((object) SR.GetString("COMPANYGROUP"), (object) "CG");
    if (this.showCompany)
      dataTable.Rows.Add((object) SR.GetString("COMPANY"), (object) "CO");
    if (this.showCompanyLocations)
      dataTable.Rows.Add((object) SR.GetString("COMPANYLOCATION"), (object) "CL");
    if (this.showCompanyLines)
      dataTable.Rows.Add((object) SR.GetString("COMPANYLINE"), (object) "C");
    if (this.showInsured)
      dataTable.Rows.Add((object) SR.GetString("INSURED"), (object) "I");
    if (this.showIntermediary)
      dataTable.Rows.Add((object) SR.GetString("INTERMEDIARY"), (object) "IN");
    if (this.showProducer)
      dataTable.Rows.Add((object) SR.GetString("PRODUCER"), (object) "P");
    if (this.showProducerLocation)
      dataTable.Rows.Add((object) SR.GetString("PRODUCERLOCATION"), (object) "PL");
    if (this.showUsers)
      dataTable.Rows.Add((object) SR.GetString("USER"), (object) "U");
    if (this.showUserGroups)
      dataTable.Rows.Add((object) SR.GetString("USERGROUP"), (object) "G");
    if (this.showExpensePayees)
      dataTable.Rows.Add((object) SR.GetString("EXPENSEPAYEE"), (object) "X");
    if (this.show3rdParty)
      dataTable.Rows.Add((object) SR.GetString("3RDPARTYPAYEE"), (object) "3");
    if (this.showFinanceCompanies)
      dataTable.Rows.Add((object) SR.GetString("FINANCECOMPANY"), (object) "FI");
    if (this.showInspectionCompanies)
      dataTable.Rows.Add((object) SR.GetString("INSPECTIONCOMPANY"), (object) "NS");
    ((UltraGridBase) this.comboEntityType).DataSource = (object) dataTable;
    ((UltraDropDownBase) this.comboEntityType).DisplayMember = "EntityType";
    ((UltraDropDownBase) this.comboEntityType).ValueMember = "TypeCode";
  }

  private void ExecuteSearch(string entityType, string entityName)
  {
    using (SqlConnection connection = new SqlConnection(CurrentUser.Instance.ConnectionString))
    {
      using (SqlCommand selectCommand = new SqlCommand("EntitySearch", connection))
      {
        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand))
        {
          selectCommand.CommandType = CommandType.StoredProcedure;
          selectCommand.Parameters.AddWithValue("@ENTITYTYPE", (object) entityType);
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(entityName.Trim(), string.Empty, false) != 0)
            selectCommand.Parameters.AddWithValue("@ENTITYNAME", (object) entityName);
          this._data.EntitySearch.Clear();
          Database.SafeDataAdapterFill(dataAdapter, (DataTable) this._data.EntitySearch);
        }
      }
    }
    if (this._data.EntitySearch.Rows.Count == 0)
    {
      int num = (int) MessageBox.Show("The specified entity could not be found, please try again!", "Entity Not Found!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    }
    else
    {
      UltraGrid gridEntityList = this.gridEntityList;
      ((UltraGridBase) gridEntityList).DataSource = (object) this._data.EntitySearch;
      ((Control) gridEntityList).Focus();
      ((UltraGridBase) gridEntityList).ActiveRow = ((UltraGridBase) this.gridEntityList).Rows[0];
      ((UltraGridBase) gridEntityList).Rows[0].Selected = true;
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
          this.EntitySearchType = frmEntitySearchMulti.SearchType.ProducerLocation;
          break;
        }
        goto default;
      case 635854758:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "NS", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.InspectionCompany;
          break;
        }
        goto default;
      case 906799682:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "3", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.ThirdPartyPayee;
          break;
        }
        goto default;
      case 1625881374:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "IN", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.Intermediary;
          break;
        }
        goto default;
      case 2044336111:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CG", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.CompanyGroup;
          break;
        }
        goto default;
      case 2077450064:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "FI", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.FinanceCompany;
          break;
        }
        goto default;
      case 2178557063:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CO", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.Company;
          break;
        }
        goto default;
      case 2195334682:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "CL", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.CompanyLocation;
          break;
        }
        goto default;
      case 3255563174:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "G", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.UserGroup;
          break;
        }
        goto default;
      case 3322673650:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "C", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.CompanyLine;
          break;
        }
        goto default;
      case 3423339364:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "I", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.Insured;
          break;
        }
        goto default;
      case 3490449840:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "U", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.User;
          break;
        }
        goto default;
      case 3574337935:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "P", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.Producer;
          break;
        }
        goto default;
      case 3708558887:
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "X", false) == 0)
        {
          this.EntitySearchType = frmEntitySearchMulti.SearchType.ExpensePayee;
          break;
        }
        goto default;
      default:
        this.EntitySearchType = frmEntitySearchMulti.SearchType.None;
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
      switch (this.EntitySearchType)
      {
        case frmEntitySearchMulti.SearchType.CompanyGroup:
          this.ExecuteSearch("CG", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.Company:
          this.ExecuteSearch("CO", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.CompanyLocation:
          this.ExecuteSearch("CL", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = true;
          break;
        case frmEntitySearchMulti.SearchType.CompanyLine:
          this.ExecuteSearch("C", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.Insured:
          this.ExecuteSearch("I", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.Intermediary:
          this.ExecuteSearch("IN", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.Producer:
          this.ExecuteSearch("P", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.ProducerLocation:
          this.ExecuteSearch("PL", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.User:
          this.ExecuteSearch("U", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.UserGroup:
          this.ExecuteSearch("G", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.ExpensePayee:
          this.ExecuteSearch("X", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.ThirdPartyPayee:
          this.ExecuteSearch("3", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.FinanceCompany:
          this.ExecuteSearch("FI", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
        case frmEntitySearchMulti.SearchType.InspectionCompany:
          this.ExecuteSearch("NS", ((TextEditorControlBase) this.textboxEntityName).Text.Trim());
          this.IsCompanyLocationSearch = false;
          break;
      }
      if (((UltraGridBase) this.gridEntityList).Rows.Count == 500 && CurrentUser.Instance.UsingXP)
        BalloonTip.ShowEditTip((Control) this.textboxEntityName, SR.GetString("LIMITING_RESULTS"), SR.GetString("TOOMANY_RESULTS_RETURNED"), BalloonTip.BalloonTipIcons.Info);
      this.AcceptButton = (IButtonControl) this.buttonOpen;
      this.Cursor = Cursors.Default;
    }
  }

  private void btnOpen_Click(object sender, EventArgs e) => this.DialogResult = DialogResult.OK;

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
    this.Close();
  }

  private void gridEntityList_DoubleClick(object sender, EventArgs e)
  {
    UltraGrid Expression = sender as UltraGrid;
    if (Information.IsNothing((object) Expression))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) Expression).Name, "gridSelectedEntities", false) == 0)
    {
      this.btnRemoveFromSelected_Click((object) this.btnRemoveFromSelected, new EventArgs());
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) Expression).Name, "gridEntityList", false) != 0)
        return;
      this.btnAddToSelected_Click((object) this.btnAddToSelected, new EventArgs());
    }
  }

  private void frmEntitySearchMulti_Load(object sender, EventArgs e)
  {
    this.BindEntityTypeCombo();
    this._dtSelected = this._data.EntitySearch.Clone();
    ((UltraGridBase) this.gridSelectedEntities).DataSource = (object) this._dtSelected;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this._PreSelectedEntity, "", false) != 0)
    {
      string[] strArray = Strings.Split(this._PreSelectedEntity, ",");
      int index = 0;
      while (index < strArray.Length)
      {
        string g = strArray[index];
        string str = Conversions.ToString(DefaultDatabase.ExecuteScalar(CommandType.Text, "SELECT dbo.GetEntityName(@ENTITYGUID)", new object[2]
        {
          (object) "@ENTITYGUID",
          (object) g
        }));
        try
        {
          this._dtSelected.Rows.Add((object) str, (object) new Guid(g));
        }
        catch (ConstraintException ex)
        {
          ProjectData.SetProjectError((Exception) ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
      this._dtSelected.AcceptChanges();
      ((UltraGridBase) this.gridSelectedEntities).DisplayLayout.Bands[0].SortedColumns.Add("EntityName", false);
    }
    ((UltraGridBase) this.gridEntityList).DataSource = (object) this._data.EntitySearch;
  }

  private void grid_SelectionDrag(object sender, CancelEventArgs e)
  {
    UltraGrid ultraGrid = sender as UltraGrid;
    int num = (int) ((Control) ultraGrid).DoDragDrop((object) ultraGrid.Selected.Rows, DragDropEffects.Move);
  }

  private void grid_DragOver(object sender, DragEventArgs e)
  {
    e.Effect = DragDropEffects.Move;
    UltraGrid ultraGrid = sender as UltraGrid;
    Point client = ((Control) ultraGrid).PointToClient(new Point(e.X, e.Y));
    if (client.Y < 20)
    {
      ((UltraGridBase) ultraGrid).ActiveRowScrollRegion.Scroll((RowScrollAction) 0);
    }
    else
    {
      if (client.Y <= ((Control) ultraGrid).Height - 20)
        return;
      ((UltraGridBase) ultraGrid).ActiveRowScrollRegion.Scroll((RowScrollAction) 1);
    }
  }

  private void grid_DragDrop(object sender, DragEventArgs e)
  {
    UltraGrid Expression = sender as UltraGrid;
    if (Information.IsNothing((object) Expression))
      return;
    if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) Expression).Name, "gridSelectedEntities", false) == 0)
    {
      this.btnAddToSelected_Click((object) this.btnAddToSelected, new EventArgs());
    }
    else
    {
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(((Control) Expression).Name, "gridEntityList", false) != 0)
        return;
      this.btnRemoveFromSelected_Click((object) this.btnRemoveFromSelected, new EventArgs());
    }
  }

  private void btnAddToSelected_Click(object sender, EventArgs e)
  {
    // ISSUE: unable to decompile the method.
  }

  private void btnRemoveFromSelected_Click(object sender, EventArgs e)
  {
    // ISSUE: unable to decompile the method.
  }

  internal class clsSelectedEntity
  {
    private string _selText;
    private Guid _selGuid;

    public clsSelectedEntity()
    {
    }

    public clsSelectedEntity(string Text, Guid Value)
    {
      this._selText = Text;
      this._selGuid = Value;
    }

    public string Text
    {
      get => this._selText;
      set => this._selText = value;
    }

    public Guid Value
    {
      get => this._selGuid;
      set => this._selGuid = value;
    }

    public override string ToString() => this._selText;
  }

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
    All = 32766, // 0x00007FFE
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
