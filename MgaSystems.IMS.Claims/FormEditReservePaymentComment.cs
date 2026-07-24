// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormEditReservePaymentComment
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Claims.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Claims;

[SecureResource("{48E13963-BF89-4831-9E3A-44A3585B88B4}", "Edit Reserve/Payment Comments Rights", "Users with this permission are granted the ability edit reserve/payments comments after the reserve/payment has been saved.", "Claims")]
public class FormEditReservePaymentComment : FormBase
{
  private int _resPayId;
  private string _oldComment;
  private IContainer components;
  private MGATextBox textResPayId;
  private Label label1;
  private Label label2;
  private MGATextBox textComment;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel FormEditReservePaymentComment_Fill_Panel;
  private UltraToolbarsDockArea _FormEditReservePaymentComment_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormEditReservePaymentComment_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormEditReservePaymentComment_Toolbars_Dock_Area_Top;

  public FormEditReservePaymentComment(int resPayId)
  {
    this.InitializeComponent();
    this._resPayId = resPayId;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "SAVE":
        this.SaveComment(((Control) this.textComment).Text);
        break;
      case "CANCEL":
        this.DialogResult = DialogResult.Cancel;
        break;
    }
  }

  private void FormEditReservePaymentComment_Load(object sender, EventArgs e)
  {
    ((Control) this.textResPayId).Text = this._resPayId.ToString();
    this.LoadComment();
  }

  private void LoadComment()
  {
    try
    {
      this._oldComment = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Comments FROM TBLCLAIMS_RESERVEPAYMENTS WHERE ResPayId = @ResPayId", new object[2]
      {
        (object) "@ResPayId",
        (object) this._resPayId
      });
      ((Control) this.textComment).Text = this._oldComment;
    }
    catch
    {
      throw;
    }
  }

  private void SaveComment(string comment)
  {
    try
    {
      if (MessageBox.Show("Any unsaved data on the claim/claimant screen will be lost, continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        return;
      DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "UPDATE TBLCLAIMS_RESERVEPAYMENTS SET Comments = @Comments WHERE ResPayId = @ResPayId", new object[4]
      {
        (object) "@Comments",
        (object) comment,
        (object) "@ResPayId",
        (object) this._resPayId
      });
      CurrentUser.Instance.LogAction($"Changed comment on reserve/payment ID: {this._resPayId}. Old comment: '{this._oldComment}'.", "Claims Action");
      this.DialogResult = DialogResult.OK;
      this.Close();
    }
    catch
    {
      throw;
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
    Appearance appearance2 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("SAVE");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    ButtonTool buttonTool3 = new ButtonTool("SAVE");
    Appearance appearance3 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("CANCEL");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    this.textResPayId = new MGATextBox();
    this.label1 = new Label();
    this.label2 = new Label();
    this.textComment = new MGATextBox();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this.FormEditReservePaymentComment_Fill_Panel = new UltraPanel();
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.textResPayId).BeginInit();
    ((ISupportInitialize) this.textComment).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).SuspendLayout();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textResPayId).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textResPayId).BackColor = Color.White;
    ((Control) this.textResPayId).Location = new Point(12, 21);
    this.textResPayId.MGAStyle = (MGAStyles) 2;
    ((Control) this.textResPayId).Name = "textResPayId";
    ((EditorButtonControlBase) this.textResPayId).ReadOnly = true;
    ((Control) this.textResPayId).Size = new Size(161, 20);
    ((Control) this.textResPayId).TabIndex = 2;
    ((Control) this.textResPayId).TabStop = false;
    ((UltraControlBase) this.textResPayId).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textResPayId).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(9, 5);
    this.label1.Name = "label1";
    this.label1.Size = new Size(111, 13);
    this.label1.TabIndex = 1;
    this.label1.Text = "Reserve/Payment ID:";
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(9, 54);
    this.label2.Name = "label2";
    this.label2.Size = new Size(145, 13);
    this.label2.TabIndex = 3;
    this.label2.Text = "Reserve/Payment Comment:";
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComment).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textComment).BackColor = Color.White;
    ((Control) this.textComment).Location = new Point(12, 70);
    this.textComment.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textComment).Multiline = true;
    ((Control) this.textComment).Name = "textComment";
    ((Control) this.textComment).Size = new Size(381, 126);
    ((Control) this.textComment).TabIndex = 0;
    ((UltraControlBase) this.textComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComment).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.MdiMergeable = false;
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(303, 151);
    ultraToolbar.FloatingSize = new Size(119, 72);
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
    ((AppearanceBase) appearance3).Image = (object) Resources.Save;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance3;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Save Changes";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance4).Image = (object) Resources.DeleteClaimSmall;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Cancel Changes";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((AppearanceBase) appearance5).BackColor = Color.Transparent;
    this.FormEditReservePaymentComment_Fill_Panel.Appearance = (AppearanceBase) appearance5;
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).Controls.Add((Control) this.textComment);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).Controls.Add((Control) this.textResPayId);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).Controls.Add((Control) this.label2);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).Controls.Add((Control) this.label1);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).Location = new Point(0, 26);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).Name = "FormEditReservePaymentComment_Fill_Panel";
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).Size = new Size(401, 205);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).TabIndex = 0;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left).Location = new Point(0, 26);
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left).Name = "_FormEditReservePaymentComment_Toolbars_Dock_Area_Left";
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left).Size = new Size(0, 205);
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right).Location = new Point(401, 26);
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right).Name = "_FormEditReservePaymentComment_Toolbars_Dock_Area_Right";
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right).Size = new Size(0, 205);
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top).Name = "_FormEditReservePaymentComment_Toolbars_Dock_Area_Top";
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top).Size = new Size(401, 26);
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom).Location = new Point(0, 231);
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom).Name = "_FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom).Size = new Size(401, 0);
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(401, 231);
    this.ControlBox = false;
    this.Controls.Add((Control) this.FormEditReservePaymentComment_Fill_Panel);
    this.Controls.Add((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (FormEditReservePaymentComment);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Edit Reserve/Payment Comment";
    this.Load += new EventHandler(this.FormEditReservePaymentComment_Load);
    ((ISupportInitialize) this.textResPayId).EndInit();
    ((ISupportInitialize) this.textComment).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).PerformLayout();
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
