// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.GeneralLedger.Forms.FormJournalEntryTemplates
// Assembly: MgaSystems.IMS.Accounting.GeneralLedger, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: DC511D5D-5AA9-4B52-8578-E2A0BCB046C3
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Claims\lib\MgaSystems.IMS.Accounting.GeneralLedger.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinListView;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.GeneralLedger.Properties;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.GeneralLedger.Forms;

public class FormJournalEntryTemplates : FormBase
{
  private bool _isLoading;
  private IContainer components;
  private UltraListView listViewTemplates;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private UltraLabel ultraLabel1;
  private MGATextBox textTemplateName;
  private MGACheckBox checkPrivate;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _FormJournalEntryTemplates_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormJournalEntryTemplates_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormJournalEntryTemplates_Toolbars_Dock_Area_Top;

  public string TemplateName => ((Control) this.textTemplateName).Text;

  public bool IsPrivate => ((UltraToggleEditorBase) this.checkPrivate).Checked;

  public int SelectedTemplateId
  {
    get
    {
      return ((DisposableObjectCollectionBase) this.listViewTemplates.SelectedItems).Count == 0 ? -1 : int.Parse(((KeyedSubObjectBase) ((UltraListViewStateSpecificItemsCollectionBase) this.listViewTemplates.SelectedItems)[0]).Key);
    }
  }

  public FormJournalEntryTemplates(bool isLoading)
  {
    this.InitializeComponent();
    this._isLoading = isLoading;
  }

  private void LoadTemplates()
  {
    this.listViewTemplates.Items.Clear();
    DataTable dataTable = DefaultDatabase.ExecuteDataTable("spFin_GetJournalEntryTemplates", new object[2]
    {
      (object) "@UserGuid",
      (object) CurrentUser.Instance.UserGUID
    });
    if (dataTable.Rows.Count == 0)
      return;
    foreach (DataRow row in (InternalDataCollectionBase) dataTable.Rows)
    {
      UltraListViewItem ultraListViewItem = new UltraListViewItem(row["TemplateName"], new object[2]
      {
        row["UserName"],
        row["Created"]
      });
      ((KeyedSubObjectBase) ultraListViewItem).Key = row["TemplateId"].ToString();
      this.listViewTemplates.Items.Add(ultraListViewItem);
    }
  }

  private void buttonCancel_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void FormJournalEntryTemplates_Load(object sender, EventArgs e) => this.LoadTemplates();

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (string.IsNullOrEmpty(((Control) this.textTemplateName).Text))
    {
      int num = (int) MessageBox.Show("You must specify a template name to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else if (this._isLoading)
    {
      this.DialogResult = DialogResult.OK;
    }
    else
    {
      foreach (UltraListViewItemBase listViewItemBase in this.listViewTemplates.Items)
      {
        if (listViewItemBase.Text == ((Control) this.textTemplateName).Text)
        {
          if (MessageBox.Show($"A template named {((Control) this.textTemplateName).Text} already exists, would you like to overwrite this template?", "Overwrite Existing Template?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            return;
          break;
        }
      }
      this.DialogResult = DialogResult.OK;
    }
  }

  private void listViewTemplates_ItemSelectionChanged(
    object sender,
    ItemSelectionChangedEventArgs e)
  {
    if (((DisposableObjectCollectionBase) e.SelectedItems).Count == 0)
      return;
    ((Control) this.textTemplateName).Text = ((UltraListViewItemBase) ((UltraListViewStateSpecificItemsCollectionBase) e.SelectedItems)[0]).Text;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    if (((DisposableObjectCollectionBase) this.listViewTemplates.SelectedItems).Count == 0)
    {
      int num = (int) MessageBox.Show("You must select a template to continue.", "No Template Selected!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
    else
    {
      if (!(((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key == "DELETE") || MessageBox.Show("This action cannot be undone. Continue?", "Permanently Delete Journal Entry Template?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
        return;
      DefaultDatabase.ExecuteNonQuery("spFin_DeleteJournalEntryTemplate", new object[2]
      {
        (object) "@TemplateId",
        (object) ((KeyedSubObjectBase) ((UltraListViewStateSpecificItemsCollectionBase) this.listViewTemplates.SelectedItems)[0]).Key
      });
      this.listViewTemplates.Items.Clear();
      this.LoadTemplates();
      ((Control) this.textTemplateName).Text = string.Empty;
      this.listViewTemplates.SelectedItems.Clear();
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
    UltraListViewItem ultraListViewItem = new UltraListViewItem((object) "test", new UltraListViewSubItem[2]
    {
      new UltraListViewSubItem((object) "Joe", (object) null),
      new UltraListViewSubItem((object) "12/13/2012", (object) null)
    }, (object) null);
    UltraListViewSubItemColumn viewSubItemColumn1 = new UltraListViewSubItemColumn("User Name");
    UltraListViewSubItemColumn viewSubItemColumn2 = new UltraListViewSubItemColumn("Created");
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool1 = new PopupMenuTool("listViewContext");
    PopupMenuTool popupMenuTool2 = new PopupMenuTool("listViewContext");
    ButtonTool buttonTool1 = new ButtonTool("DELETE");
    ButtonTool buttonTool2 = new ButtonTool("DELETE");
    Appearance appearance6 = new Appearance();
    this.listViewTemplates = new UltraListView();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.ultraLabel1 = new UltraLabel();
    this.textTemplateName = new MGATextBox();
    this.checkPrivate = new MGACheckBox();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.listViewTemplates).BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.textTemplateName).BeginInit();
    ((ISupportInitialize) this.checkPrivate).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.listViewTemplates, "listViewContext");
    ((KeyedSubObjectBase) ultraListViewItem).Key = "1";
    this.listViewTemplates.Items.AddRange(new UltraListViewItem[1]
    {
      ultraListViewItem
    });
    this.listViewTemplates.ItemSettings.DefaultImage = (Image) Resources.pencil_go;
    ((Control) this.listViewTemplates).Location = new Point(0, 0);
    ((KeyedSubObjectBase) this.listViewTemplates.MainColumn).Key = "Template Name";
    ((Control) this.listViewTemplates).Name = "listViewTemplates";
    ((Control) this.listViewTemplates).Size = new Size(702, 383);
    ((KeyedSubObjectBase) viewSubItemColumn1).Key = "User Name";
    viewSubItemColumn1.VisibleInDetailsView = (DefaultableBoolean) 1;
    ((KeyedSubObjectBase) viewSubItemColumn2).Key = "Created";
    viewSubItemColumn2.VisibleInDetailsView = (DefaultableBoolean) 1;
    this.listViewTemplates.SubItemColumns.AddRange(new UltraListViewSubItemColumn[2]
    {
      viewSubItemColumn1,
      viewSubItemColumn2
    });
    ((Control) this.listViewTemplates).TabIndex = 0;
    this.listViewTemplates.View = (UltraListViewStyle) 0;
    this.listViewTemplates.ViewSettingsDetails.AutoFitColumns = (AutoFitColumns) 2;
    this.listViewTemplates.ViewSettingsDetails.ColumnHeaderStyle = (HeaderStyle) 3;
    this.listViewTemplates.ViewSettingsDetails.FullRowSelect = true;
    this.listViewTemplates.ItemSelectionChanged += new ItemSelectionChangedEventHandler(this.listViewTemplates_ItemSelectionChanged);
    ((AppearanceBase) appearance1).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance1).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance1).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance1).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance1).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance1).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance1;
    ((Control) this.buttonCancel).Location = new Point(596, 395);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(103, 25);
    ((Control) this.buttonCancel).TabIndex = 4;
    ((Control) this.buttonCancel).Text = "Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance2).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance2).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance2).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance2).ImageHAlign = (HAlign) 2;
    ((AppearanceBase) appearance2).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance2;
    ((Control) this.buttonSave).Location = new Point(472, 395);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(120, 25);
    ((Control) this.buttonSave).TabIndex = 3;
    ((Control) this.buttonSave).Text = "Save/Load Template";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance3).BackColor = Color.Transparent;
    ((ControlBase) this.ultraLabel1).Appearance = (AppearanceBase) appearance3;
    ((Control) this.ultraLabel1).AutoSize = true;
    ((Control) this.ultraLabel1).Location = new Point(1, 395);
    ((Control) this.ultraLabel1).Name = "ultraLabel1";
    ((Control) this.ultraLabel1).Size = new Size(87, 15);
    ((Control) this.ultraLabel1).TabIndex = 1;
    ((Control) this.ultraLabel1).Text = "Template Name:";
    ((AppearanceBase) appearance4).BackColor = Color.White;
    ((AppearanceBase) appearance4).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance4).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textTemplateName).Appearance = (AppearanceBase) appearance4;
    ((Control) this.textTemplateName).BackColor = Color.White;
    ((Control) this.textTemplateName).Location = new Point(95, 395);
    ((TextEditorControlBase) this.textTemplateName).MaxLength = 45;
    this.textTemplateName.MGAStyle = MGAStyles.Blue;
    ((Control) this.textTemplateName).Name = "textTemplateName";
    ((Control) this.textTemplateName).Size = new Size(314, 20);
    ((Control) this.textTemplateName).TabIndex = 2;
    ((UltraControlBase) this.textTemplateName).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textTemplateName).UseOsThemes = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance5).BorderColor = Color.Gray;
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraToggleEditorBase) this.checkPrivate).Appearance = (AppearanceBase) appearance5;
    ((Control) this.checkPrivate).BackColor = Color.Transparent;
    ((UltraToggleEditorBase) this.checkPrivate).BackColorInternal = Color.Transparent;
    ((UltraToggleEditorBase) this.checkPrivate).GlyphInfo = (GlyphInfoBase) UIElementDrawParams.Office2007CheckBoxGlyphInfo;
    ((Control) this.checkPrivate).Location = new Point(412, 395);
    ((Control) this.checkPrivate).Name = "checkPrivate";
    ((Control) this.checkPrivate).Size = new Size(60, 20);
    ((Control) this.checkPrivate).TabIndex = 5;
    ((Control) this.checkPrivate).Text = "Private";
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[1]
    {
      (ToolBase) popupMenuTool1
    });
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool2).SharedPropsInternal).Caption = "PopupMenuTool1";
    ((ToolsCollectionBase) popupMenuTool2.Tools).AddRange(new ToolBase[1]
    {
      (ToolBase) buttonTool1
    });
    ((AppearanceBase) appearance6).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance6;
    ((ToolPropsBase) ((ToolBase) buttonTool2).SharedPropsInternal).Caption = "Delete Template";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) popupMenuTool2,
      (ToolBase) buttonTool2
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Left).Name = "_FormJournalEntryTemplates_Toolbars_Dock_Area_Left";
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Left).Size = new Size(0, 426);
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Right).Location = new Point(704, 0);
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Right).Name = "_FormJournalEntryTemplates_Toolbars_Dock_Area_Right";
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Right).Size = new Size(0, 426);
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Top).Name = "_FormJournalEntryTemplates_Toolbars_Dock_Area_Top";
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Top).Size = new Size(704, 0);
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom).Location = new Point(0, 426);
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom).Name = "_FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom).Size = new Size(704, 0);
    this._FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(704, 426);
    this.ControlBox = false;
    this.Controls.Add((Control) this.checkPrivate);
    this.Controls.Add((Control) this.textTemplateName);
    this.Controls.Add((Control) this.ultraLabel1);
    this.Controls.Add((Control) this.buttonSave);
    this.Controls.Add((Control) this.buttonCancel);
    this.Controls.Add((Control) this.listViewTemplates);
    this.Controls.Add((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormJournalEntryTemplates_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximumSize = new Size(720, 465);
    this.MinimumSize = new Size(720, 465);
    this.Name = nameof (FormJournalEntryTemplates);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Journal Entry Templates";
    this.Load += new EventHandler(this.FormJournalEntryTemplates_Load);
    ((ISupportInitialize) this.listViewTemplates).EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.textTemplateName).EndInit();
    ((ISupportInitialize) this.checkPrivate).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
    this.PerformLayout();
  }
}
