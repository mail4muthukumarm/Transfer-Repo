// Decompiled with JetBrains decompiler
// Type: MgaSystems.Ims.Fortegra.Overrides.Claims.Fortegra_FormClaimCloseReason
// Assembly: MgaSystems.Ims.Fortegra, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 27007E94-85B4-4A1A-9444-255CCA5487B0
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Fortegra.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.Layout;
using Infragistics.Win.Misc;
using Infragistics.Win.UltraWinEditors;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Data;
using MGASystems.Tools;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

#nullable disable
namespace MgaSystems.Ims.Fortegra.Overrides.Claims;

public class Fortegra_FormClaimCloseReason : Form
{
  public const string CLAIM_CLAIMCLOSEREASONS = "0BE7E7AB-3829-4BD9-97A1-45EBF05FDC3B";
  private int _currentClaimCloseReasonId = -1;
  private int _claimCloseReasonId = -1;
  private IContainer components;
  internal UltraPanel Fortegra_ClaimCloseReason_Fill_Panel;
  private UltraGrid gridClaimCloseReasons;
  private MGAButton buttonCancel;
  private MGAButton buttonSave;
  private MGATextBox textReason;
  private Label label1;
  private dsClaimCloseReason dsClaimCloseReason1;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _FormClaimCloseReason_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _FormClaimCloseReason_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _FormClaimCloseReason_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _FormClaimCloseReason_Toolbars_Dock_Area_Top;

  public Fortegra_FormClaimCloseReason() => this.InitializeComponent();

  private void LoadClaimCloseReasons()
  {
    ((UltraControlBase) this.gridClaimCloseReasons).BeginUpdate();
    this.dsClaimCloseReason1.Clear();
    DefaultDatabase.LoadDataSet((DataSet) this.dsClaimCloseReason1, new string[1]
    {
      "ClaimCloseReasons"
    }, "Fortegra_spClaims_GetCloseReasonList");
    ((UltraControlBase) this.gridClaimCloseReasons).EndUpdate();
  }

  private void Fortegra_FormClaimCloseReason_Load(object sender, EventArgs e)
  {
    this.LoadClaimCloseReasons();
  }

  private void buttonCancel_Click(object sender, EventArgs e) => this.Close();

  private void ClearScreen()
  {
    this._currentClaimCloseReasonId = -1;
    ((Control) this.textReason).Text = string.Empty;
  }

  private bool ValidateForm()
  {
    if (!string.IsNullOrEmpty(((Control) this.textReason).Text))
      return true;
    int num = (int) MessageBox.Show("You must enter a claim close reason to continue.", "Required Field Missing!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    return false;
  }

  private void buttonSave_Click(object sender, EventArgs e)
  {
    if (!this.ValidateForm())
      return;
    try
    {
      this.SaveClaimCloseReason();
      this.LoadClaimCloseReasons();
      this.ClearScreen();
    }
    catch (Exception ex)
    {
      int num = (int) MessageBox.Show(ex.Message, "Cannot Save Claim Close Reason", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    UltraGridRow activeRow = ((UltraGridBase) this.gridClaimCloseReasons).ActiveRow;
    if (activeRow == null)
      return;
    this._currentClaimCloseReasonId = int.Parse(activeRow.Cells["ClaimCloseReasonId"].Value.ToString());
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "DELETE":
        this.DeleteClaimCloseReason();
        break;
      case "EDIT":
        this.EditClaimCloseReason(activeRow);
        break;
    }
  }

  private void SaveClaimCloseReason()
  {
    if (this._currentClaimCloseReasonId == -1)
      DefaultDatabase.ExecuteNonQuery("Fortegra_SaveClaimCloseReason", new object[2]
      {
        (object) "@ClaimCloseReason",
        (object) ((Control) this.textReason).Text
      });
    else
      DefaultDatabase.ExecuteNonQuery("Fortegra_SaveClaimCloseReason", new object[4]
      {
        (object) "@ClaimCloseReasonId",
        (object) this._currentClaimCloseReasonId,
        (object) "@ClaimCloseReason",
        (object) ((Control) this.textReason).Text
      });
  }

  private void DeleteClaimCloseReason()
  {
    if (MessageBox.Show("This will delete the selected claim close reason, continue?", "Delete Claim Close Reason?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
      return;
    DefaultDatabase.ExecuteTransaction((EventHandler<ExecuteTransactionEventArgs>) ((s, ev) =>
    {
      try
      {
        DefaultDatabase.ExecuteNonQuery("Fortegra_DeleteClaimCloseReason", new object[2]
        {
          (object) "@ClaimCloseReasonId",
          (object) this._currentClaimCloseReasonId
        });
        this.LoadClaimCloseReasons();
        this.ClearScreen();
        ev.Transaction.Commit();
      }
      catch (Exception ex)
      {
        if (ex.Message.ToString().ToLower().Contains("does not currently exist"))
        {
          int num = (int) MessageBox.Show("The selected claim close reason does not currently exist. Please close and reopen the form to refresh the list.", "Cannot Delete Claim Close Reason", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        ev.Transaction.Rollback();
      }
    }));
  }

  private void EditClaimCloseReason(UltraGridRow row)
  {
    ((Control) this.textReason).Text = row.Cells["ClaimCloseReason"].Value.ToString();
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
    UltraGridBand ultraGridBand = new UltraGridBand("ClaimCloseReasons", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("ClaimCloseReasonId");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("ClaimCloseReason", -1, (object) null, 0, (SortIndicator) 2, false);
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    Appearance appearance10 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance11 = new Appearance();
    Appearance appearance12 = new Appearance();
    Appearance appearance13 = new Appearance();
    Appearance appearance14 = new Appearance();
    Appearance appearance15 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    PopupMenuTool popupMenuTool = new PopupMenuTool("GridContext");
    ButtonTool buttonTool1 = new ButtonTool("EDIT");
    ButtonTool buttonTool2 = new ButtonTool("DELETE");
    ButtonTool buttonTool3 = new ButtonTool("EDIT");
    Appearance appearance16 = new Appearance();
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Fortegra_FormClaimCloseReason));
    ButtonTool buttonTool4 = new ButtonTool("DELETE");
    this.Fortegra_ClaimCloseReason_Fill_Panel = new UltraPanel();
    this.gridClaimCloseReasons = new UltraGrid();
    this.dsClaimCloseReason1 = new dsClaimCloseReason();
    this.buttonCancel = new MGAButton();
    this.buttonSave = new MGAButton();
    this.textReason = new MGATextBox();
    this.label1 = new Label();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._FormClaimCloseReason_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._FormClaimCloseReason_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this._FormClaimCloseReason_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._FormClaimCloseReason_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel.ClientArea).SuspendLayout();
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel).SuspendLayout();
    ((ISupportInitialize) this.gridClaimCloseReasons).BeginInit();
    this.dsClaimCloseReason1.BeginInit();
    ((ISupportInitialize) this.buttonCancel).BeginInit();
    ((ISupportInitialize) this.buttonSave).BeginInit();
    ((ISupportInitialize) this.textReason).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    ((AppearanceBase) appearance1).BackColor = Color.Transparent;
    this.Fortegra_ClaimCloseReason_Fill_Panel.Appearance = (AppearanceBase) appearance1;
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel.ClientArea).Controls.Add((Control) this.gridClaimCloseReasons);
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel.ClientArea).Controls.Add((Control) this.buttonCancel);
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel.ClientArea).Controls.Add((Control) this.buttonSave);
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel.ClientArea).Controls.Add((Control) this.textReason);
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel.ClientArea).Controls.Add((Control) this.label1);
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel).Cursor = Cursors.Default;
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel).Dock = DockStyle.Fill;
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel).Location = new Point(0, 25);
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel).Name = "Fortegra_ClaimCloseReason_Fill_Panel";
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel).Size = new Size(800, 425);
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel).TabIndex = 17;
    ((Control) this.gridClaimCloseReasons).Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
    this.ultraToolbarsManager1.SetContextMenuUltra((Component) this.gridClaimCloseReasons, "GridContext");
    ((UltraGridBase) this.gridClaimCloseReasons).DataSource = (object) this.dsClaimCloseReason1;
    ((AppearanceBase) appearance2).BackColor = Color.White;
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Appearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ultraGridBand.AddButtonCaption = "ClaimCloseReason";
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 216;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Claim Close Reason";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 491;
    ultraGridBand.Columns.AddRange(new object[2]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2
    });
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((HeaderBase) ultraGridBand.Header).Appearance = (AppearanceBase) appearance3;
    ((HeaderBase) ultraGridBand.Header).Caption = "Claim Close Reason";
    ((HeaderBase) ultraGridBand.Header).Editor = (EmbeddableEditorBase) null;
    ultraGridBand.Override.AllowAddNew = (AllowAddNew) 2;
    ultraGridBand.Override.AllowColMoving = (AllowColMoving) 1;
    ultraGridBand.Override.AllowColSizing = (AllowColSizing) 1;
    ultraGridBand.Override.AllowColSwapping = (AllowColSwapping) 1;
    ultraGridBand.Override.AllowDelete = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowGroupBy = (DefaultableBoolean) 2;
    ultraGridBand.Override.AllowGroupMoving = (AllowGroupMoving) 1;
    ultraGridBand.Override.AllowGroupSwapping = (AllowGroupSwapping) 1;
    ultraGridBand.Override.AllowMultiCellOperations = (AllowMultiCellOperation) 0;
    ultraGridBand.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ultraGridBand.Override.AllowRowLayoutCellSizing = (RowLayoutSizing) 1;
    ultraGridBand.Override.AllowRowLayoutCellSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand.Override.AllowRowLayoutColMoving = (GridBagLayoutAllowMoving) 1;
    ultraGridBand.Override.AllowRowLayoutLabelSizing = (RowLayoutSizing) 1;
    ultraGridBand.Override.AllowRowLayoutLabelSpanSizing = (GridBagLayoutAllowSpanSizing) 1;
    ultraGridBand.Override.AllowRowSummaries = (AllowRowSummaries) 2;
    ultraGridBand.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ultraGridBand.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ultraGridBand.Override.HeaderClickAction = (HeaderClickAction) 2;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.BandsSerializer.Add((object) ultraGridBand);
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance5).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance5).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance5;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.CellClickAction = (CellClickAction) 2;
    ((AppearanceBase) appearance7).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance8).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance10).BackColor = Color.Transparent;
    ((AppearanceBase) appearance10).ForeColor = Color.Black;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance10;
    ((AppearanceBase) appearance11).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance11).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance11;
    ((AppearanceBase) appearance12).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance12;
    ((UltraGridBase) this.gridClaimCloseReasons).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridClaimCloseReasons).Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
    ((Control) this.gridClaimCloseReasons).Location = new Point(295, 12);
    ((Control) this.gridClaimCloseReasons).Name = "gridClaimCloseReasons";
    ((Control) this.gridClaimCloseReasons).Size = new Size(493, 401);
    ((Control) this.gridClaimCloseReasons).TabIndex = 0;
    ((UltraControlBase) this.gridClaimCloseReasons).UseAppStyling = false;
    ((UltraControlBase) this.gridClaimCloseReasons).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridClaimCloseReasons).UseOsThemes = (DefaultableBoolean) 2;
    this.dsClaimCloseReason1.DataSetName = "dsClaimCloseReason";
    this.dsClaimCloseReason1.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
    ((AppearanceBase) appearance13).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance13).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance13).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance13).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance13).ImageHAlign = (HAlign) 1;
    ((AppearanceBase) appearance13).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonCancel).Appearance = (AppearanceBase) appearance13;
    ((UltraButtonBase) this.buttonCancel).DialogResult = DialogResult.Cancel;
    ((Control) this.buttonCancel).Location = new Point(183, 53);
    ((Control) this.buttonCancel).Name = "buttonCancel";
    ((Control) this.buttonCancel).Size = new Size(88, 31 /*0x1F*/);
    ((Control) this.buttonCancel).TabIndex = 5;
    ((Control) this.buttonCancel).Text = "&Cancel";
    ((UltraControlBase) this.buttonCancel).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonCancel).Click += new EventHandler(this.buttonCancel_Click);
    ((AppearanceBase) appearance14).BackColor = Color.FromArgb(248, 248, 248);
    ((AppearanceBase) appearance14).BackColor2 = Color.FromArgb(250, 250, 250);
    ((AppearanceBase) appearance14).BackGradientStyle = (GradientStyle) 2;
    ((AppearanceBase) appearance14).BorderColor = Color.DarkGray;
    ((AppearanceBase) appearance14).ImageVAlign = (VAlign) 2;
    ((ControlBase) this.buttonSave).Appearance = (AppearanceBase) appearance14;
    ((Control) this.buttonSave).Location = new Point(89, 53);
    ((Control) this.buttonSave).Name = "buttonSave";
    ((Control) this.buttonSave).Size = new Size(88, 31 /*0x1F*/);
    ((Control) this.buttonSave).TabIndex = 4;
    ((Control) this.buttonSave).Text = "&Save";
    ((UltraControlBase) this.buttonSave).UseOsThemes = (DefaultableBoolean) 2;
    ((Control) this.buttonSave).Click += new EventHandler(this.buttonSave_Click);
    ((AppearanceBase) appearance15).BackColor = Color.White;
    ((AppearanceBase) appearance15).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance15).ForeColor = Color.Black;
    ((TextEditorControlBase) this.textReason).Appearance = (AppearanceBase) appearance15;
    ((Control) this.textReason).BackColor = Color.White;
    ((Control) this.textReason).Location = new Point(11, 28);
    ((TextEditorControlBase) this.textReason).MaxLength = 100;
    this.textReason.MGAStyle = MGAStyles.Blue;
    ((Control) this.textReason).Name = "textReason";
    ((Control) this.textReason).Size = new Size(260, 19);
    ((Control) this.textReason).TabIndex = 1;
    ((UltraControlBase) this.textReason).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.textReason).UseOsThemes = (DefaultableBoolean) 2;
    this.label1.AutoSize = true;
    this.label1.BackColor = Color.Transparent;
    this.label1.Location = new Point(8, 12);
    this.label1.Name = "label1";
    this.label1.Size = new Size(104, 13);
    this.label1.TabIndex = 0;
    this.label1.Text = "Claim Close Reason:";
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (Form);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.Text = "UltraToolbar1";
    ultraToolbar.Visible = false;
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((ToolPropsBase) ((ToolBase) popupMenuTool).SharedPropsInternal).Caption = "GridContext";
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolsCollectionBase) popupMenuTool.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2
    });
    ((AppearanceBase) appearance16).Image = componentResourceManager.GetObject("appearance2.Image");
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Edit Claim Close Reason";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Delete Claim Close Reason";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[3]
    {
      (ToolBase) popupMenuTool,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Top).BackColor = SystemColors.Control;
    this._FormClaimCloseReason_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Top).Name = "_FormClaimCloseReason_Toolbars_Dock_Area_Top";
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Top).Size = new Size(800, 25);
    this._FormClaimCloseReason_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Bottom).BackColor = SystemColors.Control;
    this._FormClaimCloseReason_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Bottom).Location = new Point(0, 450);
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Bottom).Name = "_FormClaimCloseReason_Toolbars_Dock_Area_Bottom";
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Bottom).Size = new Size(800, 0);
    this._FormClaimCloseReason_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Left).BackColor = SystemColors.Control;
    this._FormClaimCloseReason_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Left).Location = new Point(0, 25);
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Left).Name = "_FormClaimCloseReason_Toolbars_Dock_Area_Left";
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Left).Size = new Size(0, 425);
    this._FormClaimCloseReason_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Right).BackColor = SystemColors.Control;
    this._FormClaimCloseReason_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Right).Location = new Point(800, 25);
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Right).Name = "_FormClaimCloseReason_Toolbars_Dock_Area_Right";
    ((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Right).Size = new Size(0, 425);
    this._FormClaimCloseReason_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(800, 450);
    this.Controls.Add((Control) this.Fortegra_ClaimCloseReason_Fill_Panel);
    this.Controls.Add((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._FormClaimCloseReason_Toolbars_Dock_Area_Top);
    this.Name = nameof (Fortegra_FormClaimCloseReason);
    this.Text = "Fortegra Claim Close Reason Management";
    this.Load += new EventHandler(this.Fortegra_FormClaimCloseReason_Load);
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel.ClientArea).ResumeLayout(false);
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel.ClientArea).PerformLayout();
    ((Control) this.Fortegra_ClaimCloseReason_Fill_Panel).ResumeLayout(false);
    ((ISupportInitialize) this.gridClaimCloseReasons).EndInit();
    this.dsClaimCloseReason1.EndInit();
    ((ISupportInitialize) this.buttonCancel).EndInit();
    ((ISupportInitialize) this.buttonSave).EndInit();
    ((ISupportInitialize) this.textReason).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }
}
