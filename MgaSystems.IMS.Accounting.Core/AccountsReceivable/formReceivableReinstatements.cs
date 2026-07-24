// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.AccountsReceivable.formReceivableReinstatements
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using GrapeCity.ActiveReports;
using GrapeCity.ActiveReports.Document.Section;
using GrapeCity.ActiveReports.SectionReportModel;
using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Services;
using MGASystems.IMS.Reporting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.AccountsReceivable;

public class formReceivableReinstatements : AccountingNoteDocumentSupport
{
  private IContainer components;
  private int _transactionNumber;
  private Label label1;
  private UltraGrid gridReinstatements;
  private UltraToolbarsManager ultraToolbarsManager1;
  private UltraToolbarsDockArea _formReceivableReinstatements_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formReceivableReinstatements_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formReceivableReinstatements_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formReceivableReinstatements_Toolbars_Dock_Area_Top;
  private int[] _invoiceArray;

  protected formReceivableReinstatements() => this.InitializeComponent();

  public formReceivableReinstatements(SortedList reinstatementList, int transactionNumber)
  {
    this.InitializeComponent();
    this._transactionNumber = transactionNumber;
    this._invoiceArray = new int[reinstatementList.Count];
    for (int index = 0; index < reinstatementList.Count; ++index)
      this._invoiceArray[index] = (int) reinstatementList.GetValueList()[index];
    this.LoadPolicies();
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
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (formReceivableReinstatements));
    Appearance appearance1 = new Appearance();
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("UltraToolbar1");
    ButtonTool buttonTool1 = new ButtonTool("PROCESS");
    ButtonTool buttonTool2 = new ButtonTool("CANCEL");
    ButtonTool buttonTool3 = new ButtonTool("SELECTALL");
    ButtonTool buttonTool4 = new ButtonTool("DESELECTALL");
    ButtonTool buttonTool5 = new ButtonTool("PRINTALLENVELOPES");
    ButtonTool buttonTool6 = new ButtonTool("NOENVELOPES");
    ButtonTool buttonTool7 = new ButtonTool("PRINTALL");
    ButtonTool buttonTool8 = new ButtonTool("PRINTNONE");
    ButtonTool buttonTool9 = new ButtonTool("SAVEALL");
    ButtonTool buttonTool10 = new ButtonTool("SAVENONE");
    ButtonTool buttonTool11 = new ButtonTool("PRINT");
    ButtonTool buttonTool12 = new ButtonTool("PROCESS");
    Appearance appearance10 = new Appearance();
    ButtonTool buttonTool13 = new ButtonTool("CANCEL");
    Appearance appearance11 = new Appearance();
    ButtonTool buttonTool14 = new ButtonTool("SELECTALL");
    Appearance appearance12 = new Appearance();
    ButtonTool buttonTool15 = new ButtonTool("DESELECTALL");
    Appearance appearance13 = new Appearance();
    ButtonTool buttonTool16 = new ButtonTool("PRINT");
    Appearance appearance14 = new Appearance();
    ButtonTool buttonTool17 = new ButtonTool("PRINTALLENVELOPES");
    Appearance appearance15 = new Appearance();
    ButtonTool buttonTool18 = new ButtonTool("NOENVELOPES");
    Appearance appearance16 = new Appearance();
    ButtonTool buttonTool19 = new ButtonTool("PRINTALL");
    Appearance appearance17 = new Appearance();
    ButtonTool buttonTool20 = new ButtonTool("PRINTNONE");
    Appearance appearance18 = new Appearance();
    ButtonTool buttonTool21 = new ButtonTool("SAVEALL");
    Appearance appearance19 = new Appearance();
    ButtonTool buttonTool22 = new ButtonTool("SAVENONE");
    Appearance appearance20 = new Appearance();
    this.label1 = new Label();
    this.gridReinstatements = new UltraGrid();
    this.ultraToolbarsManager1 = new UltraToolbarsManager(this.components);
    this._formReceivableReinstatements_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this._formReceivableReinstatements_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formReceivableReinstatements_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formReceivableReinstatements_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    ((ISupportInitialize) this.gridReinstatements).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).BeginInit();
    this.SuspendLayout();
    this.label1.BackColor = Color.FromArgb(200, 210, 225);
    this.label1.BorderStyle = BorderStyle.Fixed3D;
    this.label1.Dock = DockStyle.Top;
    this.label1.Font = new Font("Tahoma", 9f);
    this.label1.Location = new Point(0, 45);
    this.label1.Name = "label1";
    this.label1.Padding = new Padding(3);
    this.label1.Size = new Size(1008, 42);
    this.label1.TabIndex = 0;
    this.label1.Text = componentResourceManager.GetString("label1.Text");
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.AllowAddNew = (AllowAddNew) 2;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.CellClickAction = (CellClickAction) 1;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(215, 220, 215);
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.gridReinstatements).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.gridReinstatements).Dock = DockStyle.Fill;
    ((Control) this.gridReinstatements).Location = new Point(0, 87);
    ((Control) this.gridReinstatements).Name = "gridReinstatements";
    ((Control) this.gridReinstatements).Size = new Size(1008, 532);
    ((Control) this.gridReinstatements).TabIndex = 1;
    this.gridReinstatements.UpdateMode = (UpdateMode) 3;
    ((UltraControlBase) this.gridReinstatements).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.gridReinstatements).UseOsThemes = (DefaultableBoolean) 2;
    this.ultraToolbarsManager1.DesignerFlags = 1;
    this.ultraToolbarsManager1.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager1.DockWithinContainerBaseType = typeof (AccountingNoteDocumentSupport);
    this.ultraToolbarsManager1.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager1.Style = (ToolbarStyle) 5;
    ultraToolbar.DockedColumn = 0;
    ultraToolbar.DockedRow = 0;
    ultraToolbar.FloatingLocation = new Point(648, 371);
    ultraToolbar.FloatingSize = new Size(553, 86);
    ultraToolbar.IsMainMenuBar = true;
    ((ToolBase) buttonTool2).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool3).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool5).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool7).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool9).InstanceProps.IsFirstInGroup = true;
    ((ToolBase) buttonTool11).InstanceProps.IsFirstInGroup = true;
    ((UltraToolbarBase) ultraToolbar).NonInheritedTools.AddRange(new ToolBase[11]
    {
      (ToolBase) buttonTool1,
      (ToolBase) buttonTool2,
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4,
      (ToolBase) buttonTool5,
      (ToolBase) buttonTool6,
      (ToolBase) buttonTool7,
      (ToolBase) buttonTool8,
      (ToolBase) buttonTool9,
      (ToolBase) buttonTool10,
      (ToolBase) buttonTool11
    });
    ultraToolbar.Settings.AllowCustomize = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockBottom = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockLeft = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockRight = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowDockTop = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowFloating = (DefaultableBoolean) 2;
    ultraToolbar.Settings.AllowHiding = (DefaultableBoolean) 2;
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ((SettingsBase) ultraToolbar.Settings).ToolDisplayStyle = (ToolDisplayStyle) 4;
    ultraToolbar.Text = "UltraToolbar1";
    this.ultraToolbarsManager1.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance10).Image = (object) Resources.disk;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance10;
    ((ToolPropsBase) ((ToolBase) buttonTool12).SharedPropsInternal).Caption = "Process Reinstatements";
    ((AppearanceBase) appearance11).Image = (object) Resources.delete;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance11;
    ((ToolPropsBase) ((ToolBase) buttonTool13).SharedPropsInternal).Caption = "Cancel";
    ((AppearanceBase) appearance12).Image = (object) Resources.picture_add;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance12;
    ((ToolPropsBase) ((ToolBase) buttonTool14).SharedPropsInternal).Caption = "Select All";
    ((AppearanceBase) appearance13).Image = (object) Resources.picture_delete;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance13;
    ((ToolPropsBase) ((ToolBase) buttonTool15).SharedPropsInternal).Caption = "Un-Select All";
    ((AppearanceBase) appearance14).Image = (object) Resources.AccountingPrinters;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance14;
    ((ToolPropsBase) ((ToolBase) buttonTool16).SharedPropsInternal).Caption = "Print Report";
    ((AppearanceBase) appearance15).Image = (object) Resources.email_open_image;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance15;
    ((ToolPropsBase) ((ToolBase) buttonTool17).SharedPropsInternal).Caption = "All Envelopes";
    ((AppearanceBase) appearance16).Image = (object) Resources.email_delete;
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance16;
    ((ToolPropsBase) ((ToolBase) buttonTool18).SharedPropsInternal).Caption = "No Envelopes";
    ((AppearanceBase) appearance17).Image = (object) Resources.printer_add;
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance17;
    ((ToolPropsBase) ((ToolBase) buttonTool19).SharedPropsInternal).Caption = "Print All";
    ((AppearanceBase) appearance18).Image = (object) Resources.printer_delete;
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance18;
    ((ToolPropsBase) ((ToolBase) buttonTool20).SharedPropsInternal).Caption = "Print None";
    ((AppearanceBase) appearance19).Image = (object) Resources.disk_multiple;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance19;
    ((ToolPropsBase) ((ToolBase) buttonTool21).SharedPropsInternal).Caption = "Save All";
    ((AppearanceBase) appearance20).Image = (object) Resources.exclamation;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance20;
    ((ToolPropsBase) ((ToolBase) buttonTool22).SharedPropsInternal).Caption = "Save None";
    ((ToolsCollectionBase) this.ultraToolbarsManager1.Tools).AddRange(new ToolBase[11]
    {
      (ToolBase) buttonTool12,
      (ToolBase) buttonTool13,
      (ToolBase) buttonTool14,
      (ToolBase) buttonTool15,
      (ToolBase) buttonTool16,
      (ToolBase) buttonTool17,
      (ToolBase) buttonTool18,
      (ToolBase) buttonTool19,
      (ToolBase) buttonTool20,
      (ToolBase) buttonTool21,
      (ToolBase) buttonTool22
    });
    this.ultraToolbarsManager1.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager1_ToolClick);
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formReceivableReinstatements_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Left).ForeColor = Color.Black;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Left).Location = new Point(0, 45);
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Left).Name = "_formReceivableReinstatements_Toolbars_Dock_Area_Left";
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Left).Size = new Size(0, 574);
    this._formReceivableReinstatements_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formReceivableReinstatements_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Right).ForeColor = Color.Black;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Right).Location = new Point(1008, 45);
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Right).Name = "_formReceivableReinstatements_Toolbars_Dock_Area_Right";
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Right).Size = new Size(0, 574);
    this._formReceivableReinstatements_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formReceivableReinstatements_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Top).ForeColor = Color.Black;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Top).Name = "_formReceivableReinstatements_Toolbars_Dock_Area_Top";
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Top).Size = new Size(1008, 45);
    this._formReceivableReinstatements_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager1;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formReceivableReinstatements_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Bottom).ForeColor = Color.Black;
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Bottom).Location = new Point(0, 619);
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Bottom).Name = "_formReceivableReinstatements_Toolbars_Dock_Area_Bottom";
    ((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Bottom).Size = new Size(1008, 0);
    this._formReceivableReinstatements_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager1;
    this.AutoScaleBaseSize = new Size(5, 13);
    this.BackColor = Color.White;
    this.ClientSize = new Size(1008, 619);
    this.Controls.Add((Control) this.gridReinstatements);
    this.Controls.Add((Control) this.label1);
    this.Controls.Add((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formReceivableReinstatements_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8f);
    this.ForeColor = Color.Black;
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = nameof (formReceivableReinstatements);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterScreen;
    this.Text = "Receivable Reinstatements";
    ((ISupportInitialize) this.gridReinstatements).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager1).EndInit();
    this.ResumeLayout(false);
  }

  protected DataTable ReinstatementDataTable { get; private set; }

  private void LoadPolicies()
  {
    this.ReinstatementDataTable = DefaultDatabase.ExecuteDataTable("spFin_GetRemittanceReinstatements", new object[4]
    {
      (object) "@invs",
      (object) string.Join<int>(",", (IEnumerable<int>) this._invoiceArray),
      (object) "@trxNum",
      (object) this._transactionNumber
    });
    ((UltraGridBase) this.gridReinstatements).DataSource = (object) this.ReinstatementDataTable;
    this.FormatGrid();
    this.SetDefaultData();
  }

  protected virtual void SetDefaultData()
  {
  }

  private void FormatGrid()
  {
    ColumnsCollection columns = ((UltraGridBase) this.gridReinstatements).DisplayLayout.Bands[0].Columns;
    columns[formReceivableReinstatements.ColumnKeys.ControlNumber].Hidden = true;
    columns[formReceivableReinstatements.ColumnKeys.QuoteId].Hidden = true;
    columns[formReceivableReinstatements.ColumnKeys.Underwriter].Hidden = true;
    columns[formReceivableReinstatements.ColumnKeys.Carrier].Hidden = true;
    columns[formReceivableReinstatements.ColumnKeys.Producer].Hidden = true;
    foreach (UltraGridColumn column in ((UltraGridBase) this.gridReinstatements).DisplayLayout.Bands[0].Columns)
    {
      ((HeaderBase) column.Header).Appearance.TextHAlign = (HAlign) 1;
      column.CellActivation = (Activation) 3;
    }
    columns[formReceivableReinstatements.ColumnKeys.NetReceivable].Format = "c";
    ((HeaderBase) columns[formReceivableReinstatements.ColumnKeys.NetReceivable].Header).Appearance.TextHAlign = (HAlign) 3;
    columns[formReceivableReinstatements.ColumnKeys.NetReceivable].CellAppearance.TextHAlign = (HAlign) 3;
    columns[formReceivableReinstatements.ColumnKeys.PaidNow].Format = "c";
    ((HeaderBase) columns[formReceivableReinstatements.ColumnKeys.PaidNow].Header).Appearance.TextHAlign = (HAlign) 3;
    columns[formReceivableReinstatements.ColumnKeys.PaidNow].CellAppearance.TextHAlign = (HAlign) 3;
    columns[formReceivableReinstatements.ColumnKeys.CurrentBalance].Format = "c";
    ((HeaderBase) columns[formReceivableReinstatements.ColumnKeys.CurrentBalance].Header).Appearance.TextHAlign = (HAlign) 3;
    columns[formReceivableReinstatements.ColumnKeys.CurrentBalance].CellAppearance.TextHAlign = (HAlign) 3;
    columns[formReceivableReinstatements.ColumnKeys.Select].CellActivation = (Activation) 0;
    ((HeaderBase) columns[formReceivableReinstatements.ColumnKeys.Select].Header).Caption = string.Empty;
    columns[formReceivableReinstatements.ColumnKeys.Select].Width = 10;
    columns[formReceivableReinstatements.ColumnKeys.PrintDate].CellActivation = (Activation) 0;
    columns[formReceivableReinstatements.ColumnKeys.ReinstatementDate].CellActivation = (Activation) 0;
    columns[formReceivableReinstatements.ColumnKeys.PrintNotice].CellActivation = (Activation) 0;
    columns[formReceivableReinstatements.ColumnKeys.PrintEnvelopes].CellActivation = (Activation) 0;
    columns[formReceivableReinstatements.ColumnKeys.SaveDocument].CellActivation = (Activation) 0;
  }

  private void ultraToolbarsManager1_ToolClick(object sender, ToolClickEventArgs e)
  {
    string key = ((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key;
    if (key == null)
      return;
    switch (key.Length)
    {
      case 5:
        if (!(key == "PRINT"))
          break;
        this.ExecutePrintData();
        break;
      case 6:
        if (!(key == "CANCEL"))
          break;
        this.Close();
        break;
      case 7:
        switch (key[0])
        {
          case 'P':
            if (!(key == "PROCESS"))
              return;
            this.ExecuteProcess();
            return;
          case 'S':
            if (!(key == "SAVEALL"))
              return;
            this.SetAllRowsForColumn(formReceivableReinstatements.ColumnKeys.SaveDocument, true);
            return;
          default:
            return;
        }
      case 8:
        switch (key[0])
        {
          case 'P':
            if (!(key == "PRINTALL"))
              return;
            this.SetAllRowsForColumn(formReceivableReinstatements.ColumnKeys.PrintNotice, true);
            return;
          case 'S':
            if (!(key == "SAVENONE"))
              return;
            this.SetAllRowsForColumn(formReceivableReinstatements.ColumnKeys.SaveDocument, false);
            return;
          default:
            return;
        }
      case 9:
        switch (key[0])
        {
          case 'P':
            if (!(key == "PRINTNONE"))
              return;
            this.SetAllRowsForColumn(formReceivableReinstatements.ColumnKeys.PrintNotice, false);
            return;
          case 'S':
            if (!(key == "SELECTALL"))
              return;
            this.SetAllRowsForColumn(formReceivableReinstatements.ColumnKeys.Select, true);
            return;
          default:
            return;
        }
      case 11:
        switch (key[0])
        {
          case 'D':
            if (!(key == "DESELECTALL"))
              return;
            this.SetAllRowsForColumn(formReceivableReinstatements.ColumnKeys.Select, false);
            return;
          case 'N':
            if (!(key == "NOENVELOPES"))
              return;
            this.SetAllRowsForColumn(formReceivableReinstatements.ColumnKeys.PrintEnvelopes, false);
            return;
          default:
            return;
        }
      case 17:
        if (!(key == "PRINTALLENVELOPES"))
          break;
        this.SetAllRowsForColumn(formReceivableReinstatements.ColumnKeys.PrintEnvelopes, true);
        break;
    }
  }

  protected void SetAllRowsForColumn(string columnName, bool isSelected)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridReinstatements).Rows)
      row.Cells[columnName].Value = (object) isSelected;
  }

  private void ExecuteProcess()
  {
    try
    {
      this.UpdateGrid();
      string envelopePrinterName = string.Empty;
      string envelopePrinterTray = string.Empty;
      using (PrintDialog printDialog = new PrintDialog())
      {
        using (PrintDocument printDocument = new PrintDocument())
        {
          printDocument.DocumentName = "Notice Of Cancellation Envelopes";
          printDialog.Document = printDocument;
          printDialog.AllowPrintToFile = false;
          printDialog.AllowSelection = true;
          if (printDialog.ShowDialog() == DialogResult.OK)
          {
            envelopePrinterName = printDialog.PrinterSettings.PrinterName;
            envelopePrinterTray = printDialog.Document.DefaultPageSettings.PaperSource.SourceName;
          }
        }
      }
      this.ReinstateSelected(envelopePrinterName, envelopePrinterTray);
    }
    catch
    {
      throw;
    }
    finally
    {
      this.Close();
    }
  }

  private void ReinstateSelected(string envelopePrinterName, string envelopePrinterTray)
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridReinstatements).Rows)
    {
      if ((bool) row.Cells[formReceivableReinstatements.ColumnKeys.Select].Value)
        PolicyServices.ReinstatePolicy((int) row.Cells[formReceivableReinstatements.ColumnKeys.QuoteId].Value, (DateTime) row.Cells[formReceivableReinstatements.ColumnKeys.PrintDate].Value, (DateTime) row.Cells[formReceivableReinstatements.ColumnKeys.ReinstatementDate].Value, (bool) row.Cells[formReceivableReinstatements.ColumnKeys.PrintNotice].Value, (bool) row.Cells[formReceivableReinstatements.ColumnKeys.PrintEnvelopes].Value, (bool) row.Cells[formReceivableReinstatements.ColumnKeys.SaveDocument].Value, envelopePrinterName, envelopePrinterTray);
    }
  }

  private void ExecutePrintData()
  {
    DataTable printDt = DefaultDatabase.ExecuteDataTable("spFin_GetRemittanceReinstatements", new object[6]
    {
      (object) "@invs",
      (object) string.Join<int>(",", (IEnumerable<int>) this._invoiceArray),
      (object) "@trxNum",
      (object) this._transactionNumber,
      (object) "@forPrint",
      (object) true
    });
    SectionReport report = formReceivableReinstatements.GetReport();
    GrapeCity.ActiveReports.SectionReportModel.Section groupHeaderSection = formReceivableReinstatements.GetGroupHeaderSection(report);
    GrapeCity.ActiveReports.SectionReportModel.Section detailSection = formReceivableReinstatements.GetDetailSection(report);
    GrapeCity.ActiveReports.SectionReportModel.Section groupFooterSection = formReceivableReinstatements.GetGroupFooterSection(report);
    GrapeCity.ActiveReports.SectionReportModel.Section reportFooterSection = formReceivableReinstatements.GetReportFooterSection(report);
    GrapeCity.ActiveReports.SectionReportModel.Section reportHeaderSection = formReceivableReinstatements.GetReportHeaderSection(report);
    try
    {
      float controlWidth = 0.95f;
      formReceivableReinstatements.AddColumnHeaders(printDt, groupHeaderSection, controlWidth);
      formReceivableReinstatements.AddDetailControls(printDt, detailSection, controlWidth);
      formReceivableReinstatements.AddSummaries(printDt, groupFooterSection, controlWidth);
      report.DataSource = (object) printDt;
      report.Run();
      using (frmPrint frmPrint = new frmPrint())
      {
        frmPrint.Report = report;
        frmPrint.ShowReport();
        frmPrint.WindowState = FormWindowState.Maximized;
        int num = (int) frmPrint.ShowDialog();
      }
    }
    catch
    {
      throw;
    }
    finally
    {
      reportHeaderSection.Dispose();
      groupHeaderSection.Dispose();
      detailSection.Dispose();
      groupFooterSection.Dispose();
      reportFooterSection.Dispose();
      report.Dispose();
      printDt.Dispose();
    }
  }

  private static GrapeCity.ActiveReports.SectionReportModel.Section GetGroupFooterSection(
    SectionReport report)
  {
    GrapeCity.ActiveReports.SectionReportModel.Section groupFooterSection = report.Sections.Add((SectionType) 4, "grpFooter");
    groupFooterSection.CanGrow = true;
    groupFooterSection.CanShrink = true;
    groupFooterSection.Height = 0.0f;
    return groupFooterSection;
  }

  private static SectionReport GetReport()
  {
    return new SectionReport()
    {
      PageSettings = {
        Orientation = (PageOrientation) 2,
        Margins = {
          Top = 0.07f,
          Left = 0.07f,
          Right = 0.07f
        }
      },
      PrintWidth = 10.85f
    };
  }

  private static GrapeCity.ActiveReports.SectionReportModel.Section GetDetailSection(
    SectionReport rpt)
  {
    GrapeCity.ActiveReports.SectionReportModel.Section detailSection = rpt.Sections.Add((SectionType) 3, "detail");
    detailSection.Height = 0.0f;
    return detailSection;
  }

  private static GrapeCity.ActiveReports.SectionReportModel.Section GetGroupHeaderSection(
    SectionReport report)
  {
    GrapeCity.ActiveReports.SectionReportModel.Section groupHeaderSection = report.Sections.Add((SectionType) 2, "grpHeader");
    groupHeaderSection.Height = 0.0f;
    return groupHeaderSection;
  }

  private static GrapeCity.ActiveReports.SectionReportModel.Section GetReportFooterSection(
    SectionReport report)
  {
    return report.Sections.Add((SectionType) 6, "rptFooter");
  }

  private static GrapeCity.ActiveReports.SectionReportModel.Section GetReportHeaderSection(
    SectionReport report)
  {
    GrapeCity.ActiveReports.SectionReportModel.Section reportHeaderSection = report.Sections.Add((SectionType) 0, "rptHeader");
    TextBox textBox = new TextBox();
    reportHeaderSection.Height = 0.5f;
    ((ARControl) textBox).Width = 5f;
    ((ARControl) textBox).Height = 0.1f;
    textBox.Text = "Receivable Reinstatements";
    textBox.Style = "font-weight: bold; font-size: 14pt;";
    ((ARControl) textBox).Location = new PointF(0.0f, 0.0f);
    reportHeaderSection.Controls.Add((ARControl) textBox);
    return reportHeaderSection;
  }

  private static void AddSummaries(DataTable printDt, GrapeCity.ActiveReports.SectionReportModel.Section grpFooterSec, float controlWidth)
  {
    for (int index = 0; index < printDt.Columns.Count; ++index)
    {
      if (!(printDt.Columns[index].DataType != typeof (Decimal)))
      {
        TextBox textBox = new TextBox();
        ((ARControl) textBox).Width = 1f;
        ((ARControl) textBox).Height = 0.1f;
        ((ARControl) textBox).DataField = printDt.Columns[index].ColumnName;
        textBox.SummaryFunc = (SummaryFunc) 0;
        textBox.SummaryType = (SummaryType) 1;
        if (printDt.Columns[index].DataType == typeof (Decimal))
        {
          textBox.OutputFormat = "$#,##0.00";
          textBox.Style = "font-weight: bold; font-size: 8pt; text-align: right;";
        }
        else
          textBox.Style = "font-weight: bold; font-size: 8pt; ; text-align: right;";
        grpFooterSec.Controls.Add((ARControl) textBox);
        ((ARControl) textBox).Location = new PointF(controlWidth * (float) index, 0.0f);
        grpFooterSec.SizeToFit();
      }
    }
  }

  private static void AddDetailControls(DataTable printDt, GrapeCity.ActiveReports.SectionReportModel.Section detailSec, float controlWidth)
  {
    for (int index = 0; index < printDt.Columns.Count; ++index)
    {
      TextBox textBox = new TextBox();
      ((ARControl) textBox).Width = 1f;
      ((ARControl) textBox).Height = 0.1f;
      ((ARControl) textBox).DataField = printDt.Columns[index].ColumnName;
      if (printDt.Columns[index].DataType == typeof (DateTime))
        textBox.OutputFormat = "MM/dd/yyyy";
      if (printDt.Columns[index].DataType == typeof (Decimal))
      {
        textBox.OutputFormat = "$#,##0.00";
        textBox.Style = "font-size: 8pt; text-align: right;";
      }
      else
        textBox.Style = "font-size: 8pt; text-align: left;";
      detailSec.Controls.Add((ARControl) textBox);
      ((ARControl) textBox).Location = new PointF(controlWidth * (float) index, 0.0f);
      detailSec.SizeToFit();
    }
    detailSec.CanGrow = true;
    detailSec.CanShrink = true;
  }

  private static void AddColumnHeaders(DataTable printDt, GrapeCity.ActiveReports.SectionReportModel.Section grpHeaderSec, float controlWidth)
  {
    for (int index = 0; index < printDt.Columns.Count; ++index)
    {
      TextBox textBox = new TextBox();
      ((ARControl) textBox).Width = 1f;
      ((ARControl) textBox).Height = 0.1f;
      textBox.Text = printDt.Columns[index].ColumnName;
      textBox.Style = !(printDt.Columns[index].DataType == typeof (Decimal)) ? "font-weight: bold; font-size: 8pt; text-align: left;" : "font-weight: bold; font-size: 8pt; text-align: right;";
      grpHeaderSec.Controls.Add((ARControl) textBox);
      ((ARControl) textBox).Location = new PointF(controlWidth * (float) index, 0.0f);
    }
    grpHeaderSec.CanGrow = true;
    grpHeaderSec.CanShrink = true;
  }

  private void UpdateGrid()
  {
    foreach (UltraGridRow row in ((UltraGridBase) this.gridReinstatements).Rows)
      row.Update();
  }

  protected static class ColumnKeys
  {
    public static readonly string PrintEnvelopes = "Print Envelopes?";
    public static readonly string NetReceivable = "Net Receivable";
    public static readonly string ControlNumber = "ControlNo";
    public static readonly string QuoteId = nameof (QuoteId);
    public static readonly string Underwriter = nameof (Underwriter);
    public static readonly string Carrier = nameof (Carrier);
    public static readonly string Producer = nameof (Producer);
    public static readonly string PaidNow = "Paid Now";
    public static readonly string CurrentBalance = "Current Balance";
    public static readonly string Select = nameof (Select);
    public static readonly string PrintDate = "Print Date";
    public static readonly string ReinstatementDate = "Reinstatement Date";
    public static readonly string PrintNotice = "Print Notice?";
    public static readonly string SaveDocument = "Save Document?";
  }
}
