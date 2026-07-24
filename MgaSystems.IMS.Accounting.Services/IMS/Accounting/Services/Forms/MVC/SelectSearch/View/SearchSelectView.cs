// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.View.SearchSelectView
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using MGASystems.Common;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.Model;
using MGASystems.IMS.Accounting.Services.Forms.MVC.WrappedUltraGridControl.View;
using MGASystems.IMS.Accounting.Services.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.SelectSearch.View;

[Override(typeof (ISearchSelectView))]
public class SearchSelectView : 
  MvcViewBase<ISearchSelectModel, ISearchSelectController>,
  ISearchSelectView<ISearchSelectModel, ISearchSelectController>,
  ISearchSelectView,
  IWrappedUltraGridView,
  IMvcView,
  IModelObserver,
  IWrappedUltraGridView<ISearchSelectModel, ISearchSelectController>,
  IMvcView<ISearchSelectModel, ISearchSelectController>,
  IModelObserver<ISearchSelectModel>
{
  private TableLayoutPanel tableLayoutPanel1;
  private MGATextBox txtSearch;
  private UltraGrid wrappedUltraGrid;
  private readonly BlockingRunner _updateDisplaySettingsRunner = new BlockingRunner();

  public SearchSelectView() => this.InitializeComponent();

  private void wrappedUltraGrid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    this.InitializeGridLayout(sender, e);
  }

  public void ReRead()
  {
    this._updateDisplaySettingsRunner.Run((Action) (() =>
    {
      this.SetDataSource();
      this.Controller.ReMapObjectsToRows();
    }));
  }

  public void RefreshDisplayValues() => ((UltraControlBase) this.wrappedUltraGrid).Update();

  public void UserSetFilter(string text) => this.Controller.RequestSetFilter(text);

  protected override void ChildSetFocus() => ((Control) this.wrappedUltraGrid).Focus();

  protected override void ChildWireUp()
  {
    this._updateDisplaySettingsRunner.Run((Action) (() =>
    {
      this.SetDataSource();
      this.Controller.WireUpGridAdapter(this.wrappedUltraGrid);
    }));
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
    this.RefreshDisplayValues();
  }

  protected virtual void SetDataSource()
  {
    ((UltraGridBase) this.wrappedUltraGrid).DataSource = (object) this.Controller.GetDisplayItems();
  }

  protected void InitializeGridLayout(object sender, InitializeLayoutEventArgs e)
  {
    UltraGridLayout layout = e.Layout;
    layout.SelectionOverlayBorderColor = Color.LightSteelBlue;
    layout.SelectionOverlayBorderThickness = 1;
    layout.SelectionOverlayColor = Color.LightSteelBlue;
  }

  protected override void ChildUpdateFromModel(ISearchSelectModel model)
  {
    base.ChildUpdateFromModel(model);
    ((Control) this.txtSearch).Text = model.SearchText;
  }

  private void txtSearch_ValueChanged(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() => this.UserSetFilter(((Control) this.txtSearch).Text)));
  }

  private void txtSearch_EditorButtonClick(object sender, EditorButtonEventArgs e)
  {
    this.InvokeIfNotSuppressed(new Action(this.Controller.RequestClearFilter));
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
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    EditorButton editorButton = new EditorButton();
    Appearance appearance10 = new Appearance();
    this.wrappedUltraGrid = new UltraGrid();
    this.tableLayoutPanel1 = new TableLayoutPanel();
    this.txtSearch = new MGATextBox();
    ((ISupportInitialize) this.wrappedUltraGrid).BeginInit();
    this.tableLayoutPanel1.SuspendLayout();
    ((ISupportInitialize) this.txtSearch).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 1;
    ((AppearanceBase) appearance2).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance2;
    ((AppearanceBase) appearance3).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).BorderColor = Color.LightGray;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance6;
    ((AppearanceBase) appearance7).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance7).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance8;
    ((UltraGridBase) this.wrappedUltraGrid).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.wrappedUltraGrid).Dock = DockStyle.Fill;
    ((Control) this.wrappedUltraGrid).Font = new Font("Tahoma", 8.25f);
    ((Control) this.wrappedUltraGrid).Location = new Point(0, 26);
    ((Control) this.wrappedUltraGrid).Margin = new Padding(0, 3, 0, 3);
    ((Control) this.wrappedUltraGrid).Name = "wrappedUltraGrid";
    ((Control) this.wrappedUltraGrid).Size = new Size(717, 461);
    ((Control) this.wrappedUltraGrid).TabIndex = 0;
    ((UltraControlBase) this.wrappedUltraGrid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.wrappedUltraGrid).UseOsThemes = (DefaultableBoolean) 2;
    this.wrappedUltraGrid.InitializeLayout += new InitializeLayoutEventHandler(this.wrappedUltraGrid_InitializeLayout);
    this.tableLayoutPanel1.ColumnCount = 1;
    this.tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
    this.tableLayoutPanel1.Controls.Add((Control) this.txtSearch, 0, 0);
    this.tableLayoutPanel1.Controls.Add((Control) this.wrappedUltraGrid, 0, 1);
    this.tableLayoutPanel1.Dock = DockStyle.Fill;
    this.tableLayoutPanel1.Location = new Point(0, 0);
    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
    this.tableLayoutPanel1.RowCount = 2;
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle());
    this.tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
    this.tableLayoutPanel1.Size = new Size(717, 490);
    this.tableLayoutPanel1.TabIndex = 1;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    ((AppearanceBase) appearance9).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance9).ForeColor = Color.Black;
    ((AppearanceBase) appearance9).Image = (object) Resources.magnifier;
    ((TextEditorControlBase) this.txtSearch).Appearance = (AppearanceBase) appearance9;
    ((Control) this.txtSearch).BackColor = Color.White;
    ((AppearanceBase) appearance10).Image = (object) Resources.cross;
    ((EditorButtonBase) editorButton).Appearance = (AppearanceBase) appearance10;
    ((EditorButtonControlBase) this.txtSearch).ButtonsRight.Add((EditorButtonBase) editorButton);
    ((Control) this.txtSearch).Dock = DockStyle.Top;
    ((Control) this.txtSearch).Location = new Point(0, 3);
    ((Control) this.txtSearch).Margin = new Padding(0, 3, 0, 0);
    this.txtSearch.MGAStyle = MGAStyles.Blue;
    ((Control) this.txtSearch).Name = "txtSearch";
    ((Control) this.txtSearch).Size = new Size(717, 20);
    ((Control) this.txtSearch).TabIndex = 7;
    ((UltraControlBase) this.txtSearch).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.txtSearch).UseOsThemes = (DefaultableBoolean) 2;
    ((TextEditorControlBase) this.txtSearch).ValueChanged += new EventHandler(this.txtSearch_ValueChanged);
    ((EditorButtonControlBase) this.txtSearch).EditorButtonClick += new EditorButtonEventHandler(this.txtSearch_EditorButtonClick);
    this.Controls.Add((Control) this.tableLayoutPanel1);
    this.Name = nameof (SearchSelectView);
    this.Size = new Size(717, 490);
    ((ISupportInitialize) this.wrappedUltraGrid).EndInit();
    this.tableLayoutPanel1.ResumeLayout(false);
    this.tableLayoutPanel1.PerformLayout();
    ((ISupportInitialize) this.txtSearch).EndInit();
    this.ResumeLayout(false);
  }
}
