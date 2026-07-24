// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Claims.FormEditTransactionULAEComment
// Assembly: MgaSystems.IMS.Claims, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: FCD9D0B7-28CF-40B9-8EB7-297871E1AF5F
// Assembly location: F:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
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

[SecureResource("{7924820D-3CB6-47AD-BD94-339AE336E10A}", "Edit Transaction/ULAE Comments Rights", "Users with this permission are granted the ability edit Transaction/ULAE comments after the Transaction/ULAE has been saved.", "Claims")]
public class FormEditTransactionULAEComment : FormBase
{
  private int _expenseId;
  private string _oldComment;
  private UltraGridRow _row;
  private IContainer components;
  private MGATextBox textComment;
  private MGATextBox textExpenseId;
  private Label label2;
  private Label label1;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraPanel FormEditReservePaymentComment_Fill_Panel;
  private UltraToolbarsDockArea _FormEditReservePaymentComment_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormEditReservePaymentComment_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormEditReservePaymentComment_Toolbars_Dock_Area_Top;

  public FormEditTransactionULAEComment(int expenseId)
  {
    this.InitializeComponent();
    this._expenseId = expenseId;
  }

  public FormEditTransactionULAEComment(ref UltraGridRow row)
  {
    this.InitializeComponent();
    this._row = row;
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

  private void FormEditTransactionULAEComment_Load(object sender, EventArgs e)
  {
    if (this._row == null)
    {
      ((Control) this.textExpenseId).Text = this._expenseId.ToString();
      this.LoadComment();
    }
    else
    {
      ((Control) this.textExpenseId).Text = "- unsaved -";
      ((Control) this.textComment).Text = this._row.Cells["comments"].Value.ToString();
    }
  }

  private void LoadComment()
  {
    try
    {
      this._oldComment = DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "SELECT Comments FROM tblClaims_ClaimExpenses WHERE UAExpenseId = @UAExpenseId", new object[2]
      {
        (object) "@UAExpenseId",
        (object) this._expenseId
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
      if (this._row == null)
      {
        if (MessageBox.Show("Any unsaved data on the claim/claimant screen will be lost, continue?", "Continue?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
          return;
        DefaultDatabase.ExecuteScalar<string>(CommandType.Text, "UPDATE tblClaims_ClaimExpenses SET Comments = @Comments WHERE UAExpenseId = @UAExpenseId", new object[4]
        {
          (object) "@Comments",
          (object) comment,
          (object) "@UAExpenseId",
          (object) this._expenseId
        });
        CurrentUser.Instance.LogAction($"Changed comment on UA Expense ID: {this._expenseId}. Old comment: '{this._oldComment}'.", "Claims Action");
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
      else
      {
        this._row.Cells["Comments"].Value = (object) comment;
        this.DialogResult = DialogResult.OK;
        this.Close();
      }
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
    this.textComment = new MGATextBox();
    this.textExpenseId = new MGATextBox();
    this.label2 = new Label();
    this.label1 = new Label();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormEditReservePaymentComment_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this.FormEditReservePaymentComment_Fill_Panel = new UltraPanel();
    ((ISupportInitialize) this.textComment).BeginInit();
    ((ISupportInitialize) this.textExpenseId).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).SuspendLayout();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textComment).Appearance = (AppearanceBase) appearance1;
    ((Control) this.textComment).BackColor = Color.White;
    ((Control) this.textComment).Location = new Point(12, 70);
    this.textComment.MGAStyle = (MGAStyles) 2;
    ((UltraTextEditor) this.textComment).Multiline = true;
    ((Control) this.textComment).Name = "textComment";
    ((Control) this.textComment).Size = new Size(381, 126);
    ((Control) this.textComment).TabIndex = 0;
    ((UltraControlBase) this.textComment).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textComment).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textExpenseId).Appearance = (AppearanceBase) appearance2;
    ((Control) this.textExpenseId).BackColor = Color.White;
    ((Control) this.textExpenseId).Location = new Point(12, 21);
    this.textExpenseId.MGAStyle = (MGAStyles) 2;
    ((Control) this.textExpenseId).Name = "textExpenseId";
    ((EditorButtonControlBase) this.textExpenseId).ReadOnly = true;
    ((Control) this.textExpenseId).Size = new Size(161, 20);
    ((Control) this.textExpenseId).TabIndex = 2;
    ((Control) this.textExpenseId).TabStop = false;
    ((UltraControlBase) this.textExpenseId).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textExpenseId).UseOsThemes = (DefaultableBoolean) 2;
    this.label2.AutoSize = true;
    this.label2.BackColor = Color.Transparent;
    this.label2.Location = new Point(9, 54);
    this.label2.Name = "label2";
    this.label2.Size = new Size(100, 13);
    this.label2.TabIndex = 3;
    this.label2.Text = "Expense Comment:";
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(9, 5);
    this.label1.Name = "label1";
    this.label1.Size = new Size(66, 13);
    this.label1.TabIndex = 1;
    this.label1.Text = "Expense ID:";
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
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
    ((AppearanceBase) appearance5).BackColor = Color.Transparent;
    this.FormEditReservePaymentComment_Fill_Panel.Appearance = (AppearanceBase) appearance5;
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).Controls.Add((Control) this.textComment);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).Controls.Add((Control) this.textExpenseId);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).Controls.Add((Control) this.label2);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).Controls.Add((Control) this.label1);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).Location = new Point(0, 26);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).Name = "FormEditReservePaymentComment_Fill_Panel";
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).Size = new Size(401, 205);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).TabIndex = 5;
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
    this.Name = nameof (FormEditTransactionULAEComment);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Edit Transaction/ULAE Comment";
    this.Load += new EventHandler(this.FormEditTransactionULAEComment_Load);
    ((ISupportInitialize) this.textComment).EndInit();
    ((ISupportInitialize) this.textExpenseId).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.FormEditReservePaymentComment_Fill_Panel.ClientArea).PerformLayout();
    ((Control) this.FormEditReservePaymentComment_Fill_Panel).ResumeLayout(false);
    this.ResumeLayout(false);
  }
}
