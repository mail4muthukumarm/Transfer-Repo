// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.View.RecordEditorView_Right
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.Model.DatabaseModels;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Controller;
using MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.Model;
using MGASystems.IMS.Accounting.Services.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.RecordEditor.View;

public class RecordEditorView_Right : 
  MvcViewBase<IRecordEditorModel, IRecordEditorController>,
  IRecordEditorView,
  IMvcView,
  IModelObserver
{
  private IMvcController _recordController;
  private IContainer components;
  private TableLayoutPanel tableLayoutControl;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _RecordEditorView_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _RecordEditorView_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _RecordEditorView_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _RecordEditorView_Toolbars_Dock_Area_Top;
  protected Panel editControlPanel;
  protected MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.DataGridView listControlView;

  public IMvcView EditControlView { get; private set; }

  public RecordEditorView_Right() => this.InitializeComponent();

  public void SetEditControl(IMvcView editControlView, IMvcController editControlController)
  {
    this.EditControlView = editControlView ?? throw new ArgumentNullException(nameof (editControlView));
    this._recordController = editControlController ?? throw new ArgumentNullException(nameof (editControlController));
    this.editControlPanel.Controls.Add((Control) this.EditControlView);
  }

  public void WireUpEditControl(IDatabaseSaveModel editControlModel)
  {
    this.EditControlView.WireUp(this._recordController, (IMvcModel) editControlModel);
  }

  public void UnWireUpEditControl() => this.EditControlView.UnWireUp();

  public void SetExcelExportVisibleStatus(bool isVisible)
  {
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).Remove(((ToolsCollectionBase) this.ultraToolbarsManager1.Tools)["Export"]);
  }

  public void UserEnterEditControl() => this.Controller.RequestCreateModelIfNeeded();

  public void UserSave()
  {
    this.Controller.RequestSave();
    this.listControlView.UpdateDataGrid();
  }

  public void UserDelete() => this.Controller.RequestDeleteSelectedRecord();

  public void UserReset() => this.Controller.RequestReset();

  public void UserExport() => this.Controller.RequestExportToExcel();

  protected override void ChildWireUp()
  {
    this.listControlView.WireUp(this.Controller.ListController, this.Model.ListModel);
  }

  private void editControlPanel_Enter(object sender, EventArgs e)
  {
    this.InvokeIfNotSuppressed(new Action(this.UserEnterEditControl));
  }

  private void ultraToolbarsManager1_ToolClick_1(object sender, ToolClickEventArgs e)
  {
    this.InvokeIfNotSuppressed((Action) (() =>
    {
      string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
      switch (key)
      {
        case "Save":
          this.UserSave();
          break;
        case "Delete":
          this.UserDelete();
          break;
        case "Clear":
          this.UserReset();
          break;
        case "Export":
          this.UserExport();
          break;
        default:
          throw new InvalidOperationException("Unknown tool click " + key);
      }
    }));
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
    UltraToolbar ultraToolbar = new UltraToolbar("buttonToolbar");
    ButtonTool buttonTool1 = new ButtonTool("Save");
    ButtonTool buttonTool2 = new ButtonTool("Delete");
    ButtonTool buttonTool3 = new ButtonTool("Clear");
    ButtonTool buttonTool4 = new ButtonTool("Export");
    ButtonTool buttonTool5 = new ButtonTool("Save");
    Appearance appearance1 = new Appearance();
    ButtonTool buttonTool6 = new ButtonTool("Delete");
    Appearance appearance2 = new Appearance();
    ButtonTool buttonTool7 = new ButtonTool("Clear");
    Appearance appearance3 = new Appearance();
    ButtonTool buttonTool8 = new ButtonTool("Export");
    Appearance appearance4 = new Appearance();
    this.tableLayoutControl = new TableLayoutPanel();
    this.listControlView = new MGASystems.IMS.Accounting.Services.Forms.MVC.DataGridControl.View.DataGridView();
    this.editControlPanel = new Panel();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._RecordEditorView_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._RecordEditorView_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._RecordEditorView_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._RecordEditorView_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.tableLayoutControl.SuspendLayout();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.tableLayoutControl.ColumnCount = 2;
    this.tableLayoutControl.ColumnStyles.Add(new ColumnStyle());
    this.tableLayoutControl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
    this.tableLayoutControl.Controls.Add((Control) this.listControlView, 1, 0);
    this.tableLayoutControl.Controls.Add((Control) this.editControlPanel, 0, 0);
    this.tableLayoutControl.Dock = DockStyle.Fill;
    this.tableLayoutControl.Location = new Point(0, 28);
    this.tableLayoutControl.Name = "tableLayoutControl";
    this.tableLayoutControl.RowCount = 1;
    this.tableLayoutControl.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
    this.tableLayoutControl.RowStyles.Add(new RowStyle(SizeType.Absolute, 764f));
    this.tableLayoutControl.Size = new Size(1231, 764);
    this.tableLayoutControl.TabIndex = 0;
    this.listControlView.BackColor = Color.Transparent;
    this.listControlView.Dock = DockStyle.Right;
    this.listControlView.Location = new Point(392, 4);
    this.listControlView.Margin = new Padding(4);
    this.listControlView.Name = "listControlView";
    this.listControlView.Size = new Size(835, 756);
    this.listControlView.TabIndex = 0;
    this.editControlPanel.BackColor = Color.Transparent;
    this.editControlPanel.Dock = DockStyle.Fill;
    this.editControlPanel.Location = new Point(3, 3);
    this.editControlPanel.Name = "editControlPanel";
    this.editControlPanel.Size = new Size(382, 758);
    this.editControlPanel.TabIndex = 1;
    this.editControlPanel.Enter += new EventHandler(this.editControlPanel_Enter);
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingSize = new Size(185, 26);
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool4).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "buttonToolbar";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance1).Image = (object) Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).Caption = "Save";
    ((ToolPropsBase) ((ToolBase) buttonTool5).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance2).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).Caption = "Delete";
    ((ToolPropsBase) ((ToolBase) buttonTool6).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance3).Image = (object) Resources.arrow_undo;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).Caption = "Clear";
    ((ToolPropsBase) ((ToolBase) buttonTool7).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance4).Image = (object) Resources.table_go;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).Caption = "Export";
    ((ToolPropsBase) ((ToolBase) buttonTool8).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[4]
    {
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8
    });
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseFlatMode = (DefaultableBoolean) 1;
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick_1);
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._RecordEditorView_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Left).Location = new Point(0, 28);
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Left).Name = "_RecordEditorView_Toolbars_Dock_Area_Left";
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Left).Size = new Size(0, 764);
    this._RecordEditorView_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._RecordEditorView_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Right).Location = new Point(1231, 28);
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Right).Name = "_RecordEditorView_Toolbars_Dock_Area_Right";
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Right).Size = new Size(0, 764);
    this._RecordEditorView_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._RecordEditorView_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Top).Name = "_RecordEditorView_Toolbars_Dock_Area_Top";
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Top).Size = new Size(1231, 28);
    this._RecordEditorView_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._RecordEditorView_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Bottom).Location = new Point(0, 792);
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Bottom).Name = "_RecordEditorView_Toolbars_Dock_Area_Bottom";
    ((Control) this._RecordEditorView_Toolbars_Dock_Area_Bottom).Size = new Size(1231, 0);
    this._RecordEditorView_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = Color.Transparent;
    this.Controls.Add((Control) this.tableLayoutControl);
    this.Controls.Add((Control) this._RecordEditorView_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._RecordEditorView_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._RecordEditorView_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._RecordEditorView_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.Name = nameof (RecordEditorView_Right);
    this.Size = new Size(1231, 792);
    this.tableLayoutControl.ResumeLayout(false);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
