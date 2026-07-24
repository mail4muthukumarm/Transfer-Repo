// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formFlatCancelEditSetting
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Shared;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formFlatCancelEditSetting : Form
{
  private const string LogContext = "Accounting";
  private readonly int _settingId;
  private bool _saveClose;
  private IContainer components;
  private Label OfficeLocationLabel;
  private Label UserLabel;
  private Label CommentsLabel;
  private MGATextBox CommentsTextBox;
  private UltraPanel formFlatCancelEditSetting_Fill_Panel;
  private MGASimpleComboBox UserComboBox;
  private MGASimpleComboBox OfficeLocationComboBox;
  private UltraToolbarsManager ToolbarsManager;
  private UltraToolbarsDockArea _formFlatCancelEditSetting_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formFlatCancelEditSetting_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formFlatCancelEditSetting_Toolbars_Dock_Area_Top;
  private Label label1;
  private MGATextBox CheckNumTextBox;
  private MGACheckBox UseCancellingBox;

  public formFlatCancelEditSetting() => this.InitializeComponent();

  public formFlatCancelEditSetting(int settingId)
  {
    this._settingId = settingId;
    this.InitializeComponent();
  }

  private void ToolbarsManager_BeforeToolbarListDropdown(
    object sender,
    BeforeToolbarListDropdownEventArgs e)
  {
    ((CancelEventArgs) e).Cancel = true;
  }

  private void ToolbarsManager_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "SAVE":
        this.Save();
        break;
      case "CANCEL":
        this.Close();
        break;
    }
  }

  private void formFlatCancelEditSetting_FormClosing(object sender, FormClosingEventArgs e)
  {
    if (e.CloseReason != CloseReason.UserClosing || this._saveClose)
    {
      if (!this._saveClose)
        return;
      this.DialogResult = DialogResult.OK;
    }
    else
    {
      if (MessageBox.Show("Are you sure you want to exit the editor? All unsaved changes will be lost.", "Exit Editor", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.No)
        return;
      e.Cancel = true;
    }
  }

  private void formFlatCancelEditSetting_Load(object sender, EventArgs e)
  {
    this.LoadOfficeLocations();
    if (this._settingId == 0)
      return;
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spFin_FlatCancelGetSetting", new object[2]
    {
      (object) "@SettingID",
      (object) this._settingId
    });
    if (dataTable.Rows.Count == 0)
      throw new Exception($"Unable to find policy cancel setting {this._settingId}");
    DataRow row = dataTable.Rows[0];
    this.OfficeLocationComboBox.Value = (object) ExtensionsMethods.FieldAs<int>(row, "GlCompanyId", DataRowVersion.Current);
    this.UserComboBox.Value = (object) ExtensionsMethods.FieldAs<Guid?>(row, "UserGuid", DataRowVersion.Current);
    ((UltraToggleEditorBase) this.UseCancellingBox).Checked = row.Field<bool>("UseCancellingUser");
    ((TextEditorControlBase) this.CommentsTextBox).Value = (object) ExtensionsMethods.FieldAs<string>(row, "Comments", DataRowVersion.Current);
    ((TextEditorControlBase) this.CheckNumTextBox).Value = (object) ExtensionsMethods.FieldAs<string>(row, "CheckNumber", DataRowVersion.Current);
    ((Control) this.OfficeLocationComboBox).Enabled = false;
  }

  private void OfficeLocationComboBox_Leave(object sender, EventArgs e)
  {
    this.OfficeLocationComboBox.Appearance.BackColor = Color.White;
  }

  private void OfficeLocationComboBox_ValueChanged(object sender, EventArgs e)
  {
    this.LoadOfficeLocationUsers();
    ((Control) this.UserComboBox).Enabled = true;
    ((Control) this.CommentsTextBox).Enabled = true;
    ((Control) this.CheckNumTextBox).Enabled = true;
  }

  private void UserComboBox_Leave(object sender, EventArgs e)
  {
    this.UserComboBox.Appearance.BackColor = Color.White;
  }

  private void LoadOfficeLocations()
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      ((UltraGridBase) this.OfficeLocationComboBox).DataSource = (object) Methods.GetOfficeLocationDataset();
      ((UltraDropDownBase) this.OfficeLocationComboBox).ValueMember = "ID";
      ((UltraDropDownBase) this.OfficeLocationComboBox).DisplayMember = "Office Location";
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.OfficeLocationComboBox).Rows).Count != 1)
        return;
      this.OfficeLocationComboBox.Value = ((UltraGridBase) this.OfficeLocationComboBox).Rows[0].Cells["ID"].Value;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void LoadOfficeLocationUsers()
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DataTable dataTable = DefaultDatabase.ExecuteDataTable("dbo.spFin_GetGlOfficeUsers", new object[2]
      {
        (object) "@glcompanyid",
        this.OfficeLocationComboBox.Value
      });
      DataRow row = dataTable.NewRow();
      row["userGuid"] = (object) Guid.Empty;
      row["UserName"] = (object) string.Empty;
      dataTable.Rows.InsertAt(row, 0);
      ((UltraGridBase) this.UserComboBox).DataSource = (object) dataTable;
      ((UltraDropDownBase) this.UserComboBox).ValueMember = "userGuid";
      ((UltraDropDownBase) this.UserComboBox).DisplayMember = "UserName";
      if (dataTable.Rows.Count != 2)
        return;
      this.UserComboBox.Value = ((UltraGridBase) this.UserComboBox).Rows[1].Cells["userGuid"].Value;
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void Save()
  {
    if (!this.ValidateInputs())
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      Guid? nullable1 = this.UserComboBox.Value as Guid?;
      Guid? nullable2 = nullable1;
      Guid empty = Guid.Empty;
      if ((nullable2.HasValue ? (nullable2.HasValue ? (nullable2.GetValueOrDefault() == empty ? 1 : 0) : 1) : 0) != 0)
        nullable1 = new Guid?();
      if (DefaultDatabase.ExecuteNonQuery("dbo.spFin_FlatCancelSaveSetting", new object[12]
      {
        (object) "@GlCompanyId",
        this.OfficeLocationComboBox.Value,
        (object) "@UserGuid",
        (object) nullable1,
        (object) "@UseCancellingUser",
        (object) ((UltraToggleEditorBase) this.UseCancellingBox).Checked,
        (object) "@Comments",
        ((TextEditorControlBase) this.CommentsTextBox).Value,
        (object) "@CheckNumber",
        ((TextEditorControlBase) this.CheckNumTextBox).Value,
        (object) "@AllowUpdate",
        (object) (this._settingId != 0)
      }) == -1)
      {
        int num = (int) MessageBox.Show("A setting for this office location already exists.", "Duplicate Setting", MessageBoxButtons.OK, MessageBoxIcon.Hand);
      }
      else
      {
        CurrentUser.Instance.LogAction(this._settingId == 0 ? "Created new policy cancel setting for " + ((Control) this.OfficeLocationComboBox).Text : $"Changed policy cancel setting {this._settingId} ({((Control) this.OfficeLocationComboBox).Text})", "Accounting");
        this._saveClose = true;
        this.Close();
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private bool ValidateInputs()
  {
    if (this.OfficeLocationComboBox.Value == null)
    {
      int num = (int) MessageBox.Show("An office location must be selected.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if ((this.UserComboBox.Value == null || Guid.Empty.Equals((Guid) this.UserComboBox.Value)) && string.IsNullOrEmpty(((TextEditorControlBase) this.CommentsTextBox).Value.ToString()) && string.IsNullOrEmpty(((TextEditorControlBase) this.CheckNumTextBox).Value.ToString()))
    {
      int num = (int) MessageBox.Show("At least one of the user, comments, or check number inputs must be completed. All cannot be empty.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      return false;
    }
    if (this.UserComboBox.Value != null && !Guid.Empty.Equals((Guid) this.UserComboBox.Value) || ((UltraToggleEditorBase) this.UseCancellingBox).Checked)
      return true;
    int num1 = (int) MessageBox.Show("A user must be specified if the cancelling user is not to be used.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
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
    Appearance appearance3 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("MainToolbar");
    ButtonTool buttonTool1 = new ButtonTool("SAVE");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    ButtonTool buttonTool3 = new ButtonTool("SAVE");
    Appearance appearance4 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("CANCEL");
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    this.OfficeLocationLabel = new Label();
    this.UserLabel = new Label();
    this.CommentsLabel = new Label();
    this.CommentsTextBox = new MGATextBox();
    this.formFlatCancelEditSetting_Fill_Panel = new UltraPanel();
    this.CheckNumTextBox = new MGATextBox();
    this.label1 = new Label();
    this.UserComboBox = new MGASimpleComboBox();
    this.OfficeLocationComboBox = new MGASimpleComboBox();
    this.ToolbarsManager = new UltraToolbarsManager(this.components);
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.UseCancellingBox = new MGACheckBox();
    ((ISupportInitialize) this.CommentsTextBox).BeginInit();
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.formFlatCancelEditSetting_Fill_Panel).SuspendLayout();
    ((ISupportInitialize) this.CheckNumTextBox).BeginInit();
    ((ISupportInitialize) this.UserComboBox).BeginInit();
    ((ISupportInitialize) this.OfficeLocationComboBox).BeginInit();
    ((ISupportInitialize) this.ToolbarsManager).BeginInit();
    ((ISupportInitialize) this.UseCancellingBox).BeginInit();
    this.SuspendLayout();
    this.OfficeLocationLabel.AutoSize = true;
    this.OfficeLocationLabel.Location = new Point(13, 13);
    this.OfficeLocationLabel.Name = "OfficeLocationLabel";
    this.OfficeLocationLabel.Size = new Size(83, 13);
    this.OfficeLocationLabel.TabIndex = 0;
    this.OfficeLocationLabel.Text = "Office Location:";
    this.UserLabel.AutoSize = true;
    this.UserLabel.Location = new Point(13, 58);
    this.UserLabel.Name = "UserLabel";
    this.UserLabel.Size = new Size(33, 13);
    this.UserLabel.TabIndex = 3;
    this.UserLabel.Text = "User:";
    this.CommentsLabel.AutoSize = true;
    this.CommentsLabel.Location = new Point(13, 181);
    this.CommentsLabel.Name = "CommentsLabel";
    this.CommentsLabel.Size = new Size(61, 13);
    this.CommentsLabel.TabIndex = 5;
    this.CommentsLabel.Text = "Comments:";
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.Gray;
    ((AppearanceBase) appearance1).ForeColor = Color.Black;
    ((TextEditorControlBase) this.CommentsTextBox).Appearance = (AppearanceBase) appearance1;
    ((Control) this.CommentsTextBox).BackColor = Color.White;
    ((TextEditorControlBase) this.CommentsTextBox).DisplayStyle = (EmbeddableElementDisplayStyle) 6;
    ((Control) this.CommentsTextBox).Enabled = false;
    ((Control) this.CommentsTextBox).Location = new Point(13, 198);
    ((TextEditorControlBase) this.CommentsTextBox).MaxLength = 2000;
    this.CommentsTextBox.Multiline = true;
    ((Control) this.CommentsTextBox).Name = "CommentsTextBox";
    ((Control) this.CommentsTextBox).Size = new Size(345, 112 /*0x70*/);
    ((Control) this.CommentsTextBox).TabIndex = 6;
    ((UltraControlBase) this.CommentsTextBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CommentsTextBox).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(239, 247, 253);
    this.formFlatCancelEditSetting_Fill_Panel.Appearance = (AppearanceBase) appearance2;
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).Controls.Add((Control) this.UseCancellingBox);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).Controls.Add((Control) this.CheckNumTextBox);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).Controls.Add((Control) this.label1);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).Controls.Add((Control) this.CommentsTextBox);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).Controls.Add((Control) this.CommentsLabel);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).Controls.Add((Control) this.UserComboBox);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).Controls.Add((Control) this.UserLabel);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).Controls.Add((Control) this.OfficeLocationComboBox);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).Controls.Add((Control) this.OfficeLocationLabel);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.formFlatCancelEditSetting_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.formFlatCancelEditSetting_Fill_Panel).Location = new Point(0, 26);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel).Name = "formFlatCancelEditSetting_Fill_Panel";
    ((Control) this.formFlatCancelEditSetting_Fill_Panel).Size = new Size(369, 321);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel).TabIndex = 0;
    ((AppearanceBase) appearance3).BackColor = Color.White;
    ((AppearanceBase) appearance3).BorderColor = Color.Gray;
    ((AppearanceBase) appearance3).ForeColor = Color.Black;
    ((TextEditorControlBase) this.CheckNumTextBox).Appearance = (AppearanceBase) appearance3;
    ((Control) this.CheckNumTextBox).BackColor = Color.White;
    ((TextEditorControlBase) this.CheckNumTextBox).DisplayStyle = (EmbeddableElementDisplayStyle) 6;
    ((Control) this.CheckNumTextBox).Enabled = false;
    ((Control) this.CheckNumTextBox).Location = new Point(13, 149);
    ((TextEditorControlBase) this.CheckNumTextBox).MaxLength = 100;
    this.CheckNumTextBox.Multiline = true;
    ((Control) this.CheckNumTextBox).Name = "CheckNumTextBox";
    ((Control) this.CheckNumTextBox).Size = new Size(345, 21);
    ((Control) this.CheckNumTextBox).TabIndex = 8;
    ((UltraControlBase) this.CheckNumTextBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.CheckNumTextBox).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.Location = new Point(13, 133);
    this.label1.Name = "label1";
    this.label1.Size = new Size(80 /*0x50*/, 13);
    this.label1.TabIndex = 7;
    this.label1.Text = "Check Number:";
    this.UserComboBox.DisplayStyle = (EmbeddableElementDisplayStyle) 6;
    this.UserComboBox.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.UserComboBox).Enabled = false;
    ((Control) this.UserComboBox).Location = new Point(13, 74);
    ((Control) this.UserComboBox).Name = "UserComboBox";
    ((Control) this.UserComboBox).Size = new Size(345, 21);
    ((Control) this.UserComboBox).TabIndex = 4;
    ((UltraControlBase) this.UserComboBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.UserComboBox).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.UserComboBox).Leave += new EventHandler(this.UserComboBox_Leave);
    this.OfficeLocationComboBox.DisplayStyle = (EmbeddableElementDisplayStyle) 6;
    this.OfficeLocationComboBox.DropDownStyle = (UltraComboStyle) 1;
    ((Control) this.OfficeLocationComboBox).Location = new Point(13, 29);
    ((Control) this.OfficeLocationComboBox).Name = "OfficeLocationComboBox";
    ((Control) this.OfficeLocationComboBox).Size = new Size(345, 21);
    ((Control) this.OfficeLocationComboBox).TabIndex = 2;
    ((UltraControlBase) this.OfficeLocationComboBox).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.OfficeLocationComboBox).UseOsThemes = (DefaultableBoolean) 2;
    this.OfficeLocationComboBox.ValueChanged += new EventHandler(this.OfficeLocationComboBox_ValueChanged);
    ((Control) this.OfficeLocationComboBox).Leave += new EventHandler(this.OfficeLocationComboBox_Leave);
    this.ToolbarsManager.DesignerFlags = 1;
    this.ToolbarsManager.DockWithinContainer = (Control) this;
    this.ToolbarsManager.DockWithinContainerBaseType = typeof (Form);
    this.ToolbarsManager.MdiMergeable = false;
    this.ToolbarsManager.ShowFullMenusDelay = 500;
    this.ToolbarsManager.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
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
    ultraToolbar.Text = "MainToolbar";
    this.ToolbarsManager.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance4).Image = (object) Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance4;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Save";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance5).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance5;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Cancel";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ToolbarsManager.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ToolbarsManager.BeforeToolbarListDropdown += new BeforeToolbarListDropdownEventHandler(this.ToolbarsManager_BeforeToolbarListDropdown);
    this.ToolbarsManager.ToolClick += new ToolClickEventHandler(this.ToolbarsManager_ToolClick);
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Left).Location = new Point(0, 26);
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Left).Name = "_formFlatCancelEditSetting_Toolbars_Dock_Area_Left";
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Left).Size = new Size(0, 321);
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Left.ToolbarsManager = this.ToolbarsManager;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Right).Location = new Point(369, 26);
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Right).Name = "_formFlatCancelEditSetting_Toolbars_Dock_Area_Right";
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Right).Size = new Size(0, 321);
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Right.ToolbarsManager = this.ToolbarsManager;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Top).Name = "_formFlatCancelEditSetting_Toolbars_Dock_Area_Top";
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Top).Size = new Size(369, 26);
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Top.ToolbarsManager = this.ToolbarsManager;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom).Location = new Point(0, 347);
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom).Name = "_formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom";
    ((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom).Size = new Size(369, 0);
    this._formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ToolbarsManager;
    ((AppearanceBase) appearance6).BorderColor = Color.Gray;
    ((AppearanceBase) appearance6).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.UseCancellingBox).Appearance = (AppearanceBase) appearance6;
    ((UltraToggleEditorBase) this.UseCancellingBox).Checked = true;
    ((UltraToggleEditorBase) this.UseCancellingBox).CheckState = CheckState.Checked;
    ((UltraToggleEditorBase) this.UseCancellingBox).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.UseCancellingBox).Location = new Point(16 /*0x10*/, 103);
    ((Control) this.UseCancellingBox).Name = "UseCancellingBox";
    ((Control) this.UseCancellingBox).Size = new Size(311, 20);
    ((Control) this.UseCancellingBox).TabIndex = 11;
    ((Control) this.UseCancellingBox).Text = "Use Policy Cancelling User";
    this.ClientSize = new Size(369, 347);
    this.Controls.Add((Control) this.formFlatCancelEditSetting_Fill_Panel);
    this.Controls.Add((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formFlatCancelEditSetting_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formFlatCancelEditSetting);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "Policy Cancel Wash Transaction Configuration Setting";
    this.FormClosing += new FormClosingEventHandler(this.formFlatCancelEditSetting_FormClosing);
    this.Load += new EventHandler(this.formFlatCancelEditSetting_Load);
    ((ISupportInitialize) this.CommentsTextBox).EndInit();
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.formFlatCancelEditSetting_Fill_Panel.ClientArea).PerformLayout();
    ((Control) this.formFlatCancelEditSetting_Fill_Panel).ResumeLayout(false);
    ((ISupportInitialize) this.CheckNumTextBox).EndInit();
    ((ISupportInitialize) this.UserComboBox).EndInit();
    ((ISupportInitialize) this.OfficeLocationComboBox).EndInit();
    ((ISupportInitialize) this.ToolbarsManager).EndInit();
    ((ISupportInitialize) this.UseCancellingBox).EndInit();
    this.ResumeLayout(false);
  }
}
