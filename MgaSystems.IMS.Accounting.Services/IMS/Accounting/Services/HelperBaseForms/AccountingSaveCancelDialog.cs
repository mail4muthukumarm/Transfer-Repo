// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Services.HelperBaseForms.AccountingSaveCancelDialog
// Assembly: MgaSystems.IMS.Accounting.Services, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: EEF87E2E-9738-4C33-AE03-5712A958CE99
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Services.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Accounting.Services.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Services.HelperBaseForms;

public class AccountingSaveCancelDialog : FormBase
{
  private IContainer components;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _FormSettings_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormSettings_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormSettings_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormSettings_Toolbars_Dock_Area_Top;
  protected UltraPanel ChildFill_Panel;

  public AccountingSaveCancelDialog() => this.InitializeComponent();

  protected AccountingSaveCancelDialog(string dialogTitle)
    : this()
  {
    this.Text = dialogTitle ?? throw new ArgumentNullException(nameof (dialogTitle));
  }

  private void AccountingSaveCancelDialog_Load(object sender, EventArgs e)
  {
    if (this.DesignMode)
      return;
    this.ChildRead();
  }

  private void SaveChanges()
  {
    this.ChildSave();
    int num = (int) MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
    this.DialogResult = DialogResult.OK;
    this.Close();
  }

  private void Cancel()
  {
    this.DialogResult = DialogResult.Cancel;
    this.ChildCancel();
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "SAVE":
        this.SaveChanges();
        break;
      case "CANCEL":
        this.Cancel();
        break;
    }
  }

  protected virtual void ChildCancel()
  {
  }

  protected virtual void ChildSave()
  {
  }

  protected virtual void ChildRead()
  {
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
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("SAVE");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    ButtonTool buttonTool3 = new ButtonTool("SAVE");
    Appearance appearance1 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("CANCEL");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormSettings_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormSettings_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._FormSettings_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormSettings_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.ChildFill_Panel = new UltraPanel();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((Control) this.ChildFill_Panel).SuspendLayout();
    this.SuspendLayout();
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(1607, 308);
    ultraToolbar.FloatingSize = new Size(290, 24);
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 1;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance1).Image = (object) Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance1;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Save Changes";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance2).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormSettings_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormSettings_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormSettings_Toolbars_Dock_Area_Top).Name = "_FormSettings_Toolbars_Dock_Area_Top";
    ((Control) this._FormSettings_Toolbars_Dock_Area_Top).Size = new Size(874, 26);
    this._FormSettings_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormSettings_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Bottom).Location = new Point(0, 540);
    ((Control) this._FormSettings_Toolbars_Dock_Area_Bottom).Name = "_FormSettings_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormSettings_Toolbars_Dock_Area_Bottom).Size = new Size(874, 0);
    this._FormSettings_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormSettings_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Left).Location = new Point(0, 26);
    ((Control) this._FormSettings_Toolbars_Dock_Area_Left).Name = "_FormSettings_Toolbars_Dock_Area_Left";
    ((Control) this._FormSettings_Toolbars_Dock_Area_Left).Size = new Size(0, 514);
    this._FormSettings_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormSettings_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormSettings_Toolbars_Dock_Area_Right).Location = new Point(874, 26);
    ((Control) this._FormSettings_Toolbars_Dock_Area_Right).Name = "_FormSettings_Toolbars_Dock_Area_Right";
    ((Control) this._FormSettings_Toolbars_Dock_Area_Right).Size = new Size(0, 514);
    this._FormSettings_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((AppearanceBase) appearance3).BackColor = Color.Transparent;
    this.ChildFill_Panel.Appearance = (AppearanceBase) appearance3;
    ((Control) this.ChildFill_Panel).Cursor = Cursors.Default;
    ((Control) this.ChildFill_Panel).Dock = DockStyle.Fill;
    ((Control) this.ChildFill_Panel).Location = new Point(0, 26);
    ((Control) this.ChildFill_Panel).Name = "ChildFill_Panel";
    ((Control) this.ChildFill_Panel).Size = new Size(874, 514);
    ((Control) this.ChildFill_Panel).TabIndex = 8;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(874, 540);
    this.Controls.Add((Control) this.ChildFill_Panel);
    this.Controls.Add((Control) this._FormSettings_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormSettings_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormSettings_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormSettings_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (AccountingSaveCancelDialog);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "BaseAccountingSaveCancelDialog";
    this.Load += new EventHandler(this.AccountingSaveCancelDialog_Load);
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((Control) this.ChildFill_Panel).ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
