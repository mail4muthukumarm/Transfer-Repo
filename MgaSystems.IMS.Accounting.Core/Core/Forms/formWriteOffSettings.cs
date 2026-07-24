// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.formWriteOffSettings
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Forms.WriteOffSettings;
using MGASystems.IMS.Accounting.Core.Properties;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms;

public class formWriteOffSettings : Form
{
  private IContainer components;
  private UltraGrid gridSettings;
  private dsWriteOffSettings dsWriteOffSettings1;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _formWriteOffSettings_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formWriteOffSettings_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formWriteOffSettings_Toolbars_Dock_Area_Top;
  private UltraToolbarsDockArea _formWriteOffSettings_Toolbars_Dock_Area_Bottom;

  public formWriteOffSettings()
  {
    this.InitializeComponent();
    this.LoadSettings();
  }

  private void LoadSettings()
  {
    this.dsWriteOffSettings1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsWriteOffSettings1, new string[1]
    {
      "Settings"
    }, "spFin_GetWriteOffSettings");
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "EDIT":
        using (formEditWriteOffSettings writeOffSettings = new formEditWriteOffSettings(((UltraGridBase) this.gridSettings).ActiveRow))
        {
          if (writeOffSettings.ShowDialog() != DialogResult.OK)
            break;
          this.LoadSettings();
          break;
        }
      case "DELETE":
        if (((UltraGridBase) this.gridSettings).ActiveRow == null)
          break;
        DefaultDatabase.ExecuteNonQuery("spFin_DeleteWriteOffSetting", new object[2]
        {
          (object) "@glcompanyid",
          (object) int.Parse(((UltraGridBase) this.gridSettings).ActiveRow.Cells["glcompanyid"].Value.ToString())
        });
        this.LoadSettings();
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
    UltraGridBand ultraGridBand = new UltraGridBand("Settings", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("GlCompanyId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("OfficeLocation");
    Appearance appearance2 = new Appearance();
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("GLAcctId_AR");
    Appearance appearance3 = new Appearance();
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("ARAccount");
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("GLAcctId_AP");
    Appearance appearance6 = new Appearance();
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("APAccount");
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("GLAcctId_EX");
    Appearance appearance9 = new Appearance();
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("EXAccount");
    Appearance appearance10 = new Appearance();
    Appearance appearance11 = new Appearance();
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("GLAcctId_UA");
    Appearance appearance12 = new Appearance();
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("UAAccount");
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    Appearance appearance16 = new Appearance();
    Appearance appearance17 = new Appearance();
    Appearance appearance18 = new Appearance();
    Appearance appearance19 = new Appearance();
    Appearance appearance20 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance21 = new Appearance();
    Appearance appearance22 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool = new PopupMenuTool("GridContext");
    ButtonTool buttonTool1 = new ButtonTool("EDIT");
    ButtonTool buttonTool2 = new ButtonTool("DELETE");
    ButtonTool buttonTool3 = new ButtonTool("EDIT");
    Appearance appearance23 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("DELETE");
    Appearance appearance24 = new Appearance();
    this.gridSettings = new UltraGrid();
    this.dsWriteOffSettings1 = new dsWriteOffSettings();
    this._formWriteOffSettings_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formWriteOffSettings_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formWriteOffSettings_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formWriteOffSettings_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.gridSettings).BeginInit();
    this.dsWriteOffSettings1.BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridSettings, "GridContext");
    ((UltraGridBase) this.gridSettings).DataSource = (object) this.dsWriteOffSettings1;
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridSettings).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridSettings).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridColumn1.AutoCompleteMode = (AutoCompleteMode) 2;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 116;
    ultraGridColumn2.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance2).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn2.Header).Appearance = (AppearanceBase) appearance2;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Office Location";
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 194;
    ultraGridColumn3.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn3.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridColumn3.Hidden = true;
    ultraGridColumn3.Width = 85;
    ultraGridColumn4.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ultraGridColumn4.CellAppearance = (AppearanceBase) appearance4;
    ((AppearanceBase) appearance5).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn4.Header).Appearance = (AppearanceBase) appearance5;
    ((HeaderBase) ultraGridColumn4.Header).Caption = "Receivables";
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 3;
    ultraGridColumn4.Width = 129;
    ultraGridColumn5.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance6).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn5.Header).Appearance = (AppearanceBase) appearance6;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 4;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 85;
    ultraGridColumn6.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance7).TextHAlignAsString = "Left";
    ultraGridColumn6.CellAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn6.Header).Appearance = (AppearanceBase) appearance8;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Payables";
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 6;
    ultraGridColumn6.Width = 126;
    ultraGridColumn7.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance9).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn7.Header).Appearance = (AppearanceBase) appearance9;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 5;
    ultraGridColumn7.Hidden = true;
    ultraGridColumn7.Width = 85;
    ultraGridColumn8.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance10).TextHAlignAsString = "Left";
    ultraGridColumn8.CellAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn8.Header).Appearance = (AppearanceBase) appearance11;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Exchange";
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 8;
    ultraGridColumn8.Width = 126;
    ultraGridColumn9.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance12).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn9.Header).Appearance = (AppearanceBase) appearance12;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 7;
    ultraGridColumn9.Hidden = true;
    ultraGridColumn9.Width = 85;
    ultraGridColumn10.AutoCompleteMode = (AutoCompleteMode) 2;
    ((AppearanceBase) appearance13).TextHAlignAsString = "Left";
    ultraGridColumn10.CellAppearance = (AppearanceBase) appearance13;
    ((AppearanceBase) appearance14).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridColumn10.Header).Appearance = (AppearanceBase) appearance14;
    ((HeaderBase) ultraGridColumn10.Header).Caption = "Un-Accounted";
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 9;
    ultraGridColumn10.Width = 126;
    ultraGridBand.Columns.AddRange(new object[10]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3,
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10
    });
    ((UltraGridBase) this.gridSettings).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridSettings).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance15).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance15;
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance16).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance16;
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance17).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance17;
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance18).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance18;
    ((AppearanceBase) appearance19).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance19;
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance20).BackColor = Color.Transparent;
    ((AppearanceBase) appearance20).ForeColor = Color.Black;
    ((UltraGridBase) this.gridSettings).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance20;
    ((AppearanceBase) appearance21).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance21).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance21;
    ((AppearanceBase) appearance22).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance22;
    ((UltraGridBase) this.gridSettings).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridSettings).Dock = DockStyle.Fill;
    ((Control) this.gridSettings).Location = new Point(0, 0);
    ((Control) this.gridSettings).Name = "gridSettings";
    ((Control) this.gridSettings).Size = new Size(703, 272);
    ((Control) this.gridSettings).TabIndex = 0;
    ((UltraControlBase) this.gridSettings).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridSettings).UseOsThemes = (DefaultableBoolean) 2;
    this.dsWriteOffSettings1.DataSetName = "dsWriteOffSettings";
    this.dsWriteOffSettings1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._formWriteOffSettings_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Left).Location = new Point(0, 0);
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Left).Name = "_formWriteOffSettings_Toolbars_Dock_Area_Left";
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Left).Size = new Size(0, 272);
    this._formWriteOffSettings_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingSize = new Size(102, 22);
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedProps).Caption = "GridContext";
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((AppearanceBase) appearance23).Image = (object) Resources.action_refresh_blue;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance23;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedProps).Caption = "Edit Settings";
    ((AppearanceBase) appearance24).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).AppearancesSmall.Appearance = (AppearanceBase) appearance24;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedProps).Caption = "Delete Setting";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._formWriteOffSettings_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Right).Location = new Point(703, 0);
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Right).Name = "_formWriteOffSettings_Toolbars_Dock_Area_Right";
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Right).Size = new Size(0, 272);
    this._formWriteOffSettings_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._formWriteOffSettings_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Top).Name = "_formWriteOffSettings_Toolbars_Dock_Area_Top";
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Top).Size = new Size(703, 0);
    this._formWriteOffSettings_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._formWriteOffSettings_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Bottom).Location = new Point(0, 272);
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Bottom).Name = "_formWriteOffSettings_Toolbars_Dock_Area_Bottom";
    ((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Bottom).Size = new Size(703, 0);
    this._formWriteOffSettings_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(703, 272);
    this.Controls.Add((Control) this.gridSettings);
    this.Controls.Add((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Top);
    this.Controls.Add((Control) this._formWriteOffSettings_Toolbars_Dock_Area_Bottom);
    this.Font = new Font("Tahoma", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formWriteOffSettings);
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Write-Off Settings";
    ((ISupportInitialize) this.gridSettings).EndInit();
    this.dsWriteOffSettings1.EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
