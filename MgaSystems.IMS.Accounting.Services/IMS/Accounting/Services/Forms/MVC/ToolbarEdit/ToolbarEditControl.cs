// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit.ToolbarEditControl
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Win;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common.MVC.BaseClasses.Controller;
using MGASystems.Common.MVC.BaseClasses.Model;
using MGASystems.Common.MVC.BaseClasses.View;
using MGASystems.IMS.Accounting.Services.InfragisticsWrappers.UltraToolBarSettings.BaseClasses;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.Forms.MVC.ToolbarEdit;

public class ToolbarEditControl : UserControl
{
  private IMvcController _editControlController;
  private IMvcView _editControlView;
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _ToolbarEditView_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _ToolbarEditView_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _ToolbarEditView_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _ToolbarEditView_Toolbars_Dock_Area_Top;
  private Panel editControlPanel;

  public ToolbarEditControl() => this.InitializeComponent();

  public void WireUpEditControl(IMvcModel editControlModel)
  {
    this._editControlView.WireUp(this._editControlController, editControlModel);
  }

  public void SetEditControl(
    IMvcView editControlView,
    IMvcController editControlController,
    IToolbarSettings toolbarSettings)
  {
    this._editControlView = editControlView ?? throw new ArgumentNullException(nameof (editControlView));
    this._editControlController = editControlController ?? throw new ArgumentNullException(nameof (editControlController));
    Control editControlView1 = (Control) this._editControlView;
    editControlView1.Dock = DockStyle.Fill;
    this.editControlPanel.Controls.Add(editControlView1);
    toolbarSettings.ApplyToToolbar(this.ultraToolbarsManager1.Toolbars[0]);
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
    UltraToolbar ultraToolbar = new UltraToolbar("controlsToolbar");
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._ToolbarEditView_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._ToolbarEditView_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._ToolbarEditView_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._ToolbarEditView_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.editControlPanel = new Panel();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "controlsToolbar";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    this.ultraToolbarsManager1.ToolbarSettings.FillEntireRow = (DefaultableBoolean) 1;
    this.ultraToolbarsManager1.ToolbarSettings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((UltraComponentControlManagerBase) this.ultraToolbarsManager1).UseFlatMode = (DefaultableBoolean) 1;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._ToolbarEditView_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Left).Location = new Point(0, 20);
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Left).Name = "_ToolbarEditView_Toolbars_Dock_Area_Left";
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Left).Size = new Size(0, 631);
    this._ToolbarEditView_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._ToolbarEditView_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Right).Location = new Point(884, 20);
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Right).Name = "_ToolbarEditView_Toolbars_Dock_Area_Right";
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Right).Size = new Size(0, 631);
    this._ToolbarEditView_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._ToolbarEditView_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Top).Name = "_ToolbarEditView_Toolbars_Dock_Area_Top";
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Top).Size = new Size(884, 20);
    this._ToolbarEditView_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._ToolbarEditView_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Bottom).Location = new Point(0, 651);
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Bottom).Name = "_ToolbarEditView_Toolbars_Dock_Area_Bottom";
    ((Control) this._ToolbarEditView_Toolbars_Dock_Area_Bottom).Size = new Size(884, 0);
    this._ToolbarEditView_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.editControlPanel.Dock = DockStyle.Fill;
    this.editControlPanel.Location = new Point(0, 20);
    this.editControlPanel.Name = "editControlPanel";
    this.editControlPanel.Padding = new Padding(3, 0, 3, 3);
    this.editControlPanel.Size = new Size(884, 631);
    this.editControlPanel.TabIndex = 1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.BackColor = SystemColors.Control;
    this.Controls.Add((Control) this.editControlPanel);
    this.Controls.Add((Control) this._ToolbarEditView_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._ToolbarEditView_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._ToolbarEditView_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._ToolbarEditView_Toolbars_Dock_Area_Top);
    this.Name = nameof (ToolbarEditControl);
    this.Size = new Size(884, 651);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
