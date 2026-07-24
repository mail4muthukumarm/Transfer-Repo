// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.Claims.FormEditReserveComment
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims.Claims;

public class FormEditReserveComment : FormBase
{
  private int _resPayId;
  private IContainer components;
  private MGATextBox textComment;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel FormEditReserveComment_Fill_Panel;
  private UltraToolbarsDockArea _FormEditReserveComment_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormEditReserveComment_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormEditReserveComment_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormEditReserveComment_Toolbars_Dock_Area_Top;

  public FormEditReserveComment() => this.InitializeComponent();

  public FormEditReserveComment(int resPayId) => this.InitializeComponent();

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "CANCEL":
        this.DialogResult = DialogResult.Cancel;
        this.Close();
        break;
    }
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
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("SAVE");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    ButtonTool buttonTool3 = new ButtonTool("SAVE");
    Appearance appearance2 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("CANCEL");
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    this.textComment = new MGATextBox();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.FormEditReserveComment_Fill_Panel = new UltraPanel();
    this._FormEditReserveComment_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormEditReserveComment_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormEditReserveComment_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormEditReserveComment_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.textComment).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((Control) this.FormEditReserveComment_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormEditReserveComment_Fill_Panel).SuspendLayout();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComment).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textComment).BackColor = Color.White;
    ((Control) this.textComment).Location = new Point(12, 111);
    this.textComment.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textComment).Multiline = true;
    ((Control) this.textComment).Name = "textComment";
    ((Control) this.textComment).Size = new Size(577, 254);
    ((Control) this.textComment).TabIndex = 0;
    ((UltraControlBase) this.textComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComment).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(474, 284);
    ultraToolbar.FloatingSize = new Size(240 /*0xF0*/, 24);
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
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance2).Image = (object) Resources.Save;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance2;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "&Save";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance3).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "&Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((AppearanceBase) appearance4).BackColor = Color.Transparent;
    this.FormEditReserveComment_Fill_Panel.Appearance = (AppearanceBase) appearance4;
    ((Control) this.FormEditReserveComment_Fill_Panel.ClientArea).Controls.Add((Control) this.textComment);
    ((Control) this.FormEditReserveComment_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormEditReserveComment_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormEditReserveComment_Fill_Panel).Location = new Point(0, 51);
    ((Control) this.FormEditReserveComment_Fill_Panel).Name = "FormEditReserveComment_Fill_Panel";
    ((Control) this.FormEditReserveComment_Fill_Panel).Size = new Size(601, 351);
    ((Control) this.FormEditReserveComment_Fill_Panel).TabIndex = 0;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEditReserveComment_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Left).Location = new Point(0, 51);
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Left).Name = "_FormEditReserveComment_Toolbars_Dock_Area_Left";
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Left).Size = new Size(0, 351);
    this._FormEditReserveComment_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEditReserveComment_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Right).Location = new Point(601, 51);
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Right).Name = "_FormEditReserveComment_Toolbars_Dock_Area_Right";
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Right).Size = new Size(0, 351);
    this._FormEditReserveComment_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEditReserveComment_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Top).Name = "_FormEditReserveComment_Toolbars_Dock_Area_Top";
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Top).Size = new Size(601, 51);
    this._FormEditReserveComment_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEditReserveComment_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Bottom).Location = new Point(0, 402);
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Bottom).Name = "_FormEditReserveComment_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Bottom).Size = new Size(601, 0);
    this._FormEditReserveComment_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(601, 402);
    this.ControlBox = false;
    this.Controls.Add((Control) this.FormEditReserveComment_Fill_Panel);
    this.Controls.Add((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormEditReserveComment_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormEditReserveComment);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Edit Reserve/Payment Comment";
    ((ISupportInitialize) this.textComment).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((Control) this.FormEditReserveComment_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormEditReserveComment_Fill_Panel.ClientArea).PerformLayout();
    ((Control) this.FormEditReserveComment_Fill_Panel).ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
