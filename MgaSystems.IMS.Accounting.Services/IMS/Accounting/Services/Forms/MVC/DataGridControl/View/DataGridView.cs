// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.DataGridView
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.UltragridViewAdapters;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View;

public class DataGridView : 
  MvcViewBase<IDataGridModel, IDataGridController>,
  IDataGridView,
  IMvcView,
  IModelObserver
{
  private IDataGridDisplaySettings _displayEntitySettings;
  private BlockingRunner _updateDisplaySettingsRunner = new BlockingRunner();
  private IContainer components;
  private UltraGrid wrappedUltraGrid;

  public DataGridView() => this.InitializeComponent();

  protected override void ChildSetFocus() => ((Control) this.wrappedUltraGrid).Focus();

  protected override void ChildWireUp()
  {
    this._displayEntitySettings = this.Model.DisplaySettings;
    this.UpdateDisplayedSettings();
  }

  protected override void EnterUpdateMode()
  {
    ((UltraControlBase) this.wrappedUltraGrid).BeginUpdate();
    ((UltraGridBase) this.wrappedUltraGrid).SuspendRowSynchronization();
  }

  protected override void ExitUpdateMode()
  {
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Bands[0].SortedColumns.RefreshSort(true);
    ((UltraGridBase) this.wrappedUltraGrid).ResumeRowSynchronization();
    ((UltraControlBase) this.wrappedUltraGrid).EndUpdate();
  }

  public void UserDoubleClickGrid() => this.Controller.RequestHandleDoubleClick();

  public void UserChangeSelection(IDatabaseSaveModel newSelection)
  {
    this.Controller.RequestChangeSelection(newSelection);
  }

  public void UserClearSelection() => this.Controller.RequestClearSelectedRecord();

  public void UpdateDataGrid()
  {
    this._updateDisplaySettingsRunner.Run((Action) (() =>
    {
      ((UltraGridBase) this.wrappedUltraGrid).DataSource = (object) null;
      this.SetupGrid();
    }));
  }

  private void wrappedUltraGrid_DoubleClickRow(object sender, DoubleClickRowEventArgs e)
  {
    this.InvokeIfNotSuppressed(new Action(this.UserDoubleClickGrid));
  }

  private void wrappedUltraGrid_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() =>
    {
      Selected selected = (sender as UltraGrid).Selected;
      if (((SparseCollectionBase) selected.Rows).Count > 0)
        this.UserChangeSelection((IDatabaseSaveModel) selected.Rows[0].ListObject);
      else
        this.UserClearSelection();
    }));
  }

  private void UpdateDisplayedSettings()
  {
    this._updateDisplaySettingsRunner.Run((Action) (() => this.SetupGrid()));
    if (((DisposableObjectCollectionBase) ((UltraGridBase) this.wrappedUltraGrid).Rows).Count > 0)
    {
      UltraGridRow row = ((UltraGridBase) this.wrappedUltraGrid).Rows[0];
      IDatabaseSaveModel listObject = (IDatabaseSaveModel) row.ListObject;
      ((GridItemBase) row).Selected = true;
      this.UserChangeSelection(listObject);
    }
    else
      this.UserClearSelection();
  }

  private void SetupGrid()
  {
    ((UltraGridBase) this.wrappedUltraGrid).DataSource = (object) this.Model.Records;
    UltraGridBand firstBand = this.SetUpFirstBandLayout();
    DataGridView.HideAllColumns(firstBand);
    this.ApplyColumnSettingsAndPopulateCells(firstBand);
  }

  private static void HideAllColumns(UltraGridBand firstBand)
  {
    foreach (UltraGridColumn column in firstBand.Columns)
      column.Hidden = true;
  }

  private void ApplyColumnSettingsAndPopulateCells(UltraGridBand firstBand)
  {
    foreach (IDisplayColumnSettings column in this._displayEntitySettings.Columns)
    {
      UltraGridColumn associatedColumn = firstBand.Columns.Add(column.PropertyName, column.HeaderCaption);
      this.SetCellValues(column, associatedColumn);
      DataGridView.ApplyColumnSettings(column, associatedColumn);
    }
  }

  private UltraGridBand SetUpFirstBandLayout()
  {
    UltraGridLayout displayLayout = ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout;
    displayLayout.Override.HeaderAppearance.TextHAlign = this._displayEntitySettings.HeaderAlignment.ToInfragisticsHAlign();
    displayLayout.CaptionAppearance.TextHAlign = this._displayEntitySettings.TextAlignment.ToInfragisticsHAlign();
    displayLayout.Override.CellClickAction = (CellClickAction) 2;
    displayLayout.Override.MaxSelectedRows = 1;
    return displayLayout.Bands[0];
  }

  private void SetCellValues(
    IDisplayColumnSettings columnSettings,
    UltraGridColumn associatedColumn)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.wrappedUltraGrid).Rows)
      row.Cells[associatedColumn].Value = columnSettings.GetValueForDisplayObject((IMvcModel) row.ListObject);
  }

  private static void ApplyColumnSettings(
    IDisplayColumnSettings columnSettings,
    UltraGridColumn associatedColumn)
  {
    associatedColumn.Hidden = false;
    associatedColumn.Width = columnSettings.Width;
    associatedColumn.DataType = columnSettings.DataType;
    associatedColumn.AutoEditMode = (DefaultableBoolean) 2;
    associatedColumn.AllowRowFiltering = (DefaultableBoolean) 1;
  }

  private void wrappedUltraGrid_InitializeRow(object sender, InitializeRowEventArgs e)
  {
    if (this._updateDisplaySettingsRunner.IsRunning)
      return;
    foreach (IDisplayColumnSettings column in this._displayEntitySettings.Columns)
      e.Row.Cells[column.PropertyName].Value = column.GetValueForDisplayObject((IMvcModel) e.Row.ListObject);
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.components != null)
      this.components.Dispose();
    base.Dispose(disposing);
  }

  private void InitializeComponent()
  {
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand = new UltraGridBand("", -1);
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    this.wrappedUltraGrid = new UltraGrid();
    ((ISupportInitialize) this.wrappedUltraGrid).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.wrappedUltraGrid).Dock = DockStyle.Fill;
    ((Control) this.wrappedUltraGrid).Font = new Font("Tahoma", 8.25f);
    ((Control) this.wrappedUltraGrid).Location = new Point(0, 0);
    ((Control) this.wrappedUltraGrid).Name = "wrappedUltraGrid";
    ((Control) this.wrappedUltraGrid).Size = new Size(495, 208 /*0xD0*/);
    ((Control) this.wrappedUltraGrid).TabIndex = 0;
    ((UltraControlBase) this.wrappedUltraGrid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.wrappedUltraGrid).UseOsThemes = (DefaultableBoolean) 2;
    this.wrappedUltraGrid.InitializeRow += new InitializeRowEventHandler(this.wrappedUltraGrid_InitializeRow);
    this.wrappedUltraGrid.AfterSelectChange += new AfterSelectChangeEventHandler(this.wrappedUltraGrid_AfterSelectChange);
    this.wrappedUltraGrid.DoubleClickRow += new DoubleClickRowEventHandler(this.wrappedUltraGrid_DoubleClickRow);
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.wrappedUltraGrid);
    this.Name = nameof (DataGridView);
    this.Size = new Size(495, 208 /*0xD0*/);
    ((ISupportInitialize) this.wrappedUltraGrid).EndInit();
    this.ResumeLayout(false);
  }

  void IDataGridView.Update() => this.Update();
}
