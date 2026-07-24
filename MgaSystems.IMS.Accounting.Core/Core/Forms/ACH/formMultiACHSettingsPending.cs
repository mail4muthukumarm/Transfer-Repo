// Decompiled with JetBrains decompiler
// Type: MGASystems.IMS.Accounting.Core.Forms.ACH.formMultiACHSettingsPending
// Assembly: MgaSystems.IMS.Accounting.Core, Version=2.0.0.0, Culture=neutral, PublicKeyToken=e175cb7c4ce15bbd
// MVID: 923053EF-B70A-44B5-B8DA-B227263F4FD2
// Assembly location: D:\augusta\fortegra\IMS Project\MgaSystems.IMS.Accounting.Core.dll

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using Infragistics.Win.UltraWinScrollBar;
using Infragistics.Win.UltraWinToolbars;
using MGASystems.Common;
using MGASystems.Data;
using MGASystems.IMS.Accounting.Core.Properties;
using MGASystems.IMS.Accounting.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#nullable disable
namespace MGASystems.IMS.Accounting.Core.Forms.ACH;

public class formMultiACHSettingsPending : FormBase
{
  protected string _getACHSettingsPendingProc = "dbo.spFin_GetACHSettings_Pending";
  private Panel gridPanel;
  protected UltraGrid settingsGrid;
  private UltraToolbarsManager ultraToolbarsManager;
  private IContainer components;
  private UltraToolbarsDockArea _formACHSettingsManagement_Toolbars_Dock_Area_Left;
  private UltraToolbarsDockArea _formACHSettingsManagement_Toolbars_Dock_Area_Right;
  private UltraToolbarsDockArea _formACHSettingsManagement_Toolbars_Dock_Area_Bottom;
  private UltraToolbarsDockArea _formACHSettingsManagement_Toolbars_Dock_Area_Top;

  public formMultiACHSettingsPending() => this.InitializeComponent();

  private void formMultiACHSettingsPending_Load(object sender, EventArgs e)
  {
    this.LoadSettings();
    this.ActiveControl = (Control) this.settingsGrid;
  }

  private void settingsGrid_ClickCell(object sender, ClickCellEventArgs e)
  {
    if (e.Cell.Row.ParentRow == null || e.Cell.Row.Cells["ApprovalCheckBox"].Hidden)
      return;
    e.Cell.Row.Cells["ApprovalCheckBox"].Value = (object) !(bool) e.Cell.Row.Cells["ApprovalCheckBox"].Value;
    if (!(bool) e.Cell.Row.Cells["ApprovalCheckBox"].Value || !((KeyedSubObjectsCollectionBase) e.Cell.Row.ParentRow.Cells).Exists("ApprovalCheckBox"))
      return;
    e.Cell.Row.ParentRow.Cells["ApprovalCheckBox"].Value = (object) true;
  }

  private void settingsGrid_InitializeLayout(object sender, InitializeLayoutEventArgs e)
  {
    e.Layout.Override.ExpansionIndicator = (ShowExpansionIndicator) 3;
  }

  private void ultraToolbarsManager_ToolClick(object sender, ToolClickEventArgs e)
  {
    switch (((KeyedSubObjectBase) ((ToolEventArgs) e).Tool).Key)
    {
      case "APPROVE":
        this.ApproveSettings();
        break;
      case "APPROVEALL":
        this.ApproveAllSettings();
        break;
    }
  }

  private void AddApprovalCheckBox(int band)
  {
    if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[band].Columns).Exists("ApprovalCheckBox"))
      return;
    UltraGridColumn ultraGridColumn = ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[band].Columns.Add("ApprovalCheckBox", string.Empty);
    ultraGridColumn.DataType = typeof (bool);
    ((HeaderBase) ultraGridColumn.Header).VisiblePosition = 0;
  }

  private void ApproveAllSettings()
  {
    foreach (UltraGridRow ultraGridRow in ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (entityRow => entityRow.ChildBands.HasChildRows)).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (entityRow => ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (r => (IEnumerable<UltraGridRow>) r.ChildBands[0].Rows)))))
    {
      if (!ultraGridRow.Cells["ApprovalCheckBox"].Hidden)
        ultraGridRow.Cells["ApprovalCheckBox"].Value = (object) true;
      if (ultraGridRow.ChildBands.HasChildRows)
      {
        foreach (UltraGridRow row in ultraGridRow.ChildBands[0].Rows)
          row.Cells["ApprovalCheckBox"].Value = (object) true;
      }
    }
    this.ApproveSettings();
  }

  private void ApproveSettings()
  {
    List<\u003C\u003Ef__AnonymousType0<object, object>> list1 = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (r => (IEnumerable<UltraGridRow>) r.ChildBands[0].Rows)).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (cr => cr.Cells["ApprovalCheckBox"].Value.Equals((object) true))).Select(cr => new
    {
      ID = cr.Cells["ACHSettingsBankID"].Value,
      EntityGuid = cr.Cells["EntityGuid"].Value
    }).ToList();
    List<\u003C\u003Ef__AnonymousType0<object, object>> list2 = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (r => (IEnumerable<UltraGridRow>) r.ChildBands[0].Rows)).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (br => (IEnumerable<UltraGridRow>) br.ChildBands[0].Rows)).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (ar => ar.Cells["ApprovalCheckBox"].Value.Equals((object) true))).Select(ar => new
    {
      ID = ar.Cells["ACHSettingsAccountID"].Value,
      EntityGuid = ar.Cells["EntityGuid"].Value
    }).ToList();
    if (list1.Count == 0 && list2.Count == 0)
      return;
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      foreach (var data in list1)
      {
        DataSet dataSet = DefaultDatabase.ExecuteDataSet("dbo.spFin_ApproveACHSetting_Bank", new object[6]
        {
          (object) "@ACHSettingsBankID",
          data.ID,
          (object) "@EntityGuid",
          data.EntityGuid,
          (object) "@ApprovedBy",
          (object) CurrentUser.Instance.UserGUID
        });
        if (dataSet.Tables[0].Rows.Count != 0)
        {
          foreach (DataRow row in (InternalDataCollectionBase) dataSet.Tables[0].Rows)
          {
            StringBuilder stringBuilder = new StringBuilder(200);
            stringBuilder.Append("Approved ACH bank setting:" + Environment.NewLine);
            stringBuilder.Append($"   Entity: {ExtensionsMethods.FieldAs<string>(row, "EntityName", DataRowVersion.Current)} ({data.EntityGuid}){Environment.NewLine}");
            stringBuilder.Append($"   Bank Name: {ExtensionsMethods.FieldAs<string>(row, "BankName", DataRowVersion.Current)}{Environment.NewLine}");
            CurrentUser.Instance.LogAction(stringBuilder.ToString(), MultiACHSettingsSecurity.LogContext);
          }
        }
      }
      foreach (var data in list2)
      {
        DataSet dataSet = DefaultDatabase.ExecuteDataSet("dbo.spFin_ApproveACHSetting_Account", new object[6]
        {
          (object) "@ACHSettingsAccountID",
          data.ID,
          (object) "@EntityGuid",
          data.EntityGuid,
          (object) "@ApprovedBy",
          (object) CurrentUser.Instance.UserGUID
        });
        if (dataSet.Tables[0].Rows.Count != 0)
        {
          foreach (DataRow row in (InternalDataCollectionBase) dataSet.Tables[0].Rows)
          {
            StringBuilder stringBuilder = new StringBuilder(200);
            stringBuilder.Append("Approved ACH account setting:" + Environment.NewLine);
            stringBuilder.Append($"   Entity: {ExtensionsMethods.FieldAs<string>(row, "EntityName", DataRowVersion.Current)} ({data.EntityGuid}){Environment.NewLine}");
            stringBuilder.Append($"   Bank Name: {ExtensionsMethods.FieldAs<string>(row, "BankName", DataRowVersion.Current)}{Environment.NewLine}");
            stringBuilder.Append($"   Account Name: {ExtensionsMethods.FieldAs<string>(row, "AccountName", DataRowVersion.Current)}{Environment.NewLine}");
            CurrentUser.Instance.LogAction(stringBuilder.ToString(), MultiACHSettingsSecurity.LogContext);
          }
        }
      }
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
    this.ReloadSettings();
  }

  private static string GetAccountType(object value)
  {
    if (value == null)
      return string.Empty;
    switch (value.ToString().ToLowerInvariant())
    {
      case "c":
        return "Checking";
      case "s":
        return "Savings";
      default:
        return string.Empty;
    }
  }

  private void LoadSettings()
  {
    try
    {
      this.Cursor = MgaCursors.WaitCursor;
      DataSet dataSet = DefaultDatabase.ExecuteDataSet(this._getACHSettingsPendingProc);
      dataSet.Relations.Add("ACHSettings", dataSet.Tables[0].Columns["EntityGuid"], dataSet.Tables[1].Columns["EntityGuid"]);
      dataSet.Relations.Add("ACHSettingsDetails", dataSet.Tables[1].Columns["ACHSettingsBankID"], dataSet.Tables[2].Columns["ACHSettingsBankID"]);
      ((UltraControlBase) this.settingsGrid).BeginUpdate();
      ((UltraGridBase) this.settingsGrid).SetDataBinding((object) dataSet, string.Empty);
      UltraGridColumn column1 = ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[2].Columns["AccountNumber"];
      column1.Hidden = true;
      if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[2].Columns).Exists("AccountNumberMasked"))
      {
        UltraGridColumn ultraGridColumn = ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[2].Columns.Add("AccountNumberMasked", "Account Number");
        ultraGridColumn.DataType = typeof (string);
        ((HeaderBase) ultraGridColumn.Header).VisiblePosition = ((HeaderBase) column1.Header).VisiblePosition;
        ultraGridColumn.Width = column1.Width;
      }
      if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[1].Columns).Exists("SWIFTCode"))
      {
        UltraGridColumn column2 = ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[1].Columns["SWIFTCode"];
        column2.Hidden = true;
        if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[1].Columns).Exists("SWIFTCodeMasked"))
        {
          UltraGridColumn ultraGridColumn = ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[1].Columns.Add("SWIFTCodeMasked", "SWIFT Code");
          ultraGridColumn.DataType = typeof (string);
          ((HeaderBase) ultraGridColumn.Header).VisiblePosition = ((HeaderBase) column2.Header).VisiblePosition;
          ultraGridColumn.Width = column2.Width;
        }
      }
      if (((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[1].Columns).Exists("SortCode"))
      {
        UltraGridColumn column3 = ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[1].Columns["SortCode"];
        column3.Hidden = true;
        if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[1].Columns).Exists("SortCodeMasked"))
        {
          UltraGridColumn ultraGridColumn = ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[1].Columns.Add("SortCodeMasked", "Sort Code");
          ultraGridColumn.DataType = typeof (string);
          ((HeaderBase) ultraGridColumn.Header).VisiblePosition = ((HeaderBase) column3.Header).VisiblePosition;
          ultraGridColumn.Width = column3.Width;
        }
      }
      UltraGridColumn column4 = ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[2].Columns["IBAN"];
      column4.Hidden = true;
      if (!((KeyedSubObjectsCollectionBase) ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[2].Columns).Exists("IBANMasked"))
      {
        UltraGridColumn ultraGridColumn = ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[2].Columns.Add("IBANMasked", "IBAN");
        ultraGridColumn.DataType = typeof (string);
        ((HeaderBase) ultraGridColumn.Header).VisiblePosition = ((HeaderBase) column4.Header).VisiblePosition;
        ultraGridColumn.Width = column4.Width;
      }
      this.AddApprovalCheckBox(1);
      this.AddApprovalCheckBox(2);
      foreach (UltraGridRow ultraGridRow in ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (r => (IEnumerable<UltraGridRow>) r.ChildBands[0].Rows)))
      {
        ultraGridRow.Cells["SWIFTCode"].Value = (object) MultiACHSettingsSecurity.Decrypt(ultraGridRow.Cells["SWIFTCode"].Value);
        ultraGridRow.Cells["SWIFTCodeMasked"].Value = (object) ultraGridRow.Cells["SWIFTCode"].Value.ToString().TruncateToLastFour();
        ultraGridRow.Cells["SortCode"].Value = (object) MultiACHSettingsSecurity.Decrypt(ultraGridRow.Cells["SortCode"].Value);
        ultraGridRow.Cells["SortCodeMasked"].Value = (object) ultraGridRow.Cells["SortCode"].Value.ToString().TruncateToLastFour();
        ultraGridRow.Cells["DateEntered"].Value = (object) DateTime.SpecifyKind(DateTime.Parse(ultraGridRow.Cells["DateEntered"].Value.ToString()), DateTimeKind.Utc).ToLocalTime();
        if (ultraGridRow.Cells["IsApproved"].Value.Equals((object) true))
          ultraGridRow.Cells["ApprovalCheckBox"].Hidden = true;
        if (!ultraGridRow.ChildBands.HasChildRows)
        {
          if (ultraGridRow.Cells["ApprovalCheckBox"].Hidden)
            ultraGridRow.Hidden = true;
        }
        else
        {
          foreach (UltraGridRow row in ultraGridRow.ChildBands[0].Rows)
          {
            row.Cells["AccountNumber"].Value = (object) MultiACHSettingsSecurity.Decrypt(row.Cells["AccountNumber"].Value);
            row.Cells["AccountNumberMasked"].Value = (object) row.Cells["AccountNumber"].Value.ToString().TruncateToLastFour();
            row.Cells["AccountType"].Value = (object) formMultiACHSettingsPending.GetAccountType(row.Cells["AccountType"].Value);
            row.Cells["CHIPNumber"].Value = (object) MultiACHSettingsSecurity.Decrypt(row.Cells["CHIPNumber"].Value);
            row.Cells["IBAN"].Value = (object) MultiACHSettingsSecurity.Decrypt(row.Cells["IBAN"].Value);
            row.Cells["IBANMasked"].Value = (object) row.Cells["IBAN"].Value.ToString().TruncateToLastFour();
          }
        }
      }
      ((UltraGridBase) this.settingsGrid).DisplayLayout.Bands[2].Columns["AccountName"].SortIndicator = (SortIndicator) 1;
      ((UltraControlBase) this.settingsGrid).EndUpdate();
      if (((DisposableObjectCollectionBase) ((UltraGridBase) this.settingsGrid).Rows).Count <= 0)
        return;
      this.SelectRow(((UltraGridBase) this.settingsGrid).Rows[0]);
    }
    finally
    {
      this.Cursor = MgaCursors.Default;
    }
  }

  private void ReloadSettings()
  {
    HashSet<object> expandedEntityRows = new HashSet<object>(((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (r => r.Expanded)).Select<UltraGridRow, object>((System.Func<UltraGridRow, object>) (r => r.Cells["EntityGuid"].Value)));
    HashSet<object> expandedBankRows = new HashSet<object>(((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (r => (IEnumerable<UltraGridRow>) r.ChildBands[0].Rows)).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (cr => cr.Expanded)).Select<UltraGridRow, object>((System.Func<UltraGridRow, object>) (cr => cr.Cells["ACHSettingsBankID"].Value)));
    formMultiACHSettingsEditor.ActiveRow activeRow;
    object activeRowId;
    if (((UltraGridBase) this.settingsGrid).ActiveRow.ParentRow == null)
    {
      activeRowId = ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["EntityGUid"].Value;
      activeRow = formMultiACHSettingsEditor.ActiveRow.Entity;
    }
    else if (((UltraGridBase) this.settingsGrid).ActiveRow.ParentRow.ParentRow == null)
    {
      activeRowId = ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["ACHSettingsBankID"].Value;
      activeRow = formMultiACHSettingsEditor.ActiveRow.Bank;
    }
    else
    {
      activeRowId = ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["ACHSettingsAccountID"].Value;
      activeRow = formMultiACHSettingsEditor.ActiveRow.Account;
    }
    this.LoadSettings();
    ((UltraControlBase) this.settingsGrid).BeginUpdate();
    foreach (UltraGridRow ultraGridRow in ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (r => expandedEntityRows.Contains(r.Cells["EntityGuid"].Value))))
      ultraGridRow.Expanded = true;
    foreach (UltraGridRow ultraGridRow in ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (r => (IEnumerable<UltraGridRow>) r.ChildBands[0].Rows)).Where<UltraGridRow>((System.Func<UltraGridRow, bool>) (cr => expandedBankRows.Contains(cr.Cells["ACHSettingsBankID"].Value))))
      ultraGridRow.Expanded = true;
    UltraGridRow row = (UltraGridRow) null;
    switch (activeRow)
    {
      case formMultiACHSettingsEditor.ActiveRow.Entity:
        row = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).FirstOrDefault<UltraGridRow>((System.Func<UltraGridRow, bool>) (r => r.Cells["EntityGuid"].Value.Equals(activeRowId)));
        break;
      case formMultiACHSettingsEditor.ActiveRow.Bank:
        row = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (er => (IEnumerable<UltraGridRow>) er.ChildBands[0].Rows)).FirstOrDefault<UltraGridRow>((System.Func<UltraGridRow, bool>) (br => br.Cells["ACHSettingsBankID"].Value.Equals(activeRowId)));
        break;
      case formMultiACHSettingsEditor.ActiveRow.Account:
        row = ((IEnumerable<UltraGridRow>) ((UltraGridBase) this.settingsGrid).Rows).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (er => (IEnumerable<UltraGridRow>) er.ChildBands[0].Rows)).SelectMany<UltraGridRow, UltraGridRow>((System.Func<UltraGridRow, IEnumerable<UltraGridRow>>) (br => (IEnumerable<UltraGridRow>) br.ChildBands[0].Rows)).FirstOrDefault<UltraGridRow>((System.Func<UltraGridRow, bool>) (ar => ar.Cells["ACHSettingsAccountID"].Value.Equals(activeRowId)));
        break;
    }
    if (row != null)
      this.SelectRow(row);
    ((UltraControlBase) this.settingsGrid).EndUpdate();
  }

  private void SelectRow(UltraGridRow row)
  {
    this.settingsGrid.Selected.Rows.Clear();
    this.settingsGrid.Selected.Rows.Add(row);
    ((UltraGridBase) this.settingsGrid).ActiveRow = row;
  }

  private void settingsGrid_DoubleClick(object sender, EventArgs e) => this.ViewSetting();

  private void ViewSetting()
  {
    if (((UltraGridBase) this.settingsGrid).ActiveRow == null)
      return;
    Guid entityGuid = (Guid) ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["EntityGuid"].Value;
    formMultiACHSettingsEditor.ActiveRow activeRow = formMultiACHSettingsEditor.ActiveRow.Entity;
    int rowId = 0;
    if (((UltraGridBase) this.settingsGrid).ActiveRow.ParentRow != null)
    {
      if (((UltraGridBase) this.settingsGrid).ActiveRow.ParentRow.ParentRow == null)
      {
        activeRow = formMultiACHSettingsEditor.ActiveRow.Bank;
        rowId = (int) ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["ACHSettingsBankID"].Value;
      }
      else
      {
        activeRow = formMultiACHSettingsEditor.ActiveRow.Account;
        rowId = (int) ((UltraGridBase) this.settingsGrid).ActiveRow.Cells["ACHSettingsAccountID"].Value;
      }
    }
    using (formMultiACHSettingsEditor achSettingsEditor = new formMultiACHSettingsEditor(entityGuid, activeRow, rowId, false))
    {
      int num = (int) achSettingsEditor.ShowDialog();
    }
  }

  private void InitializeComponent()
  {
    this.components = (IContainer) new System.ComponentModel.Container();
    Appearance appearance1 = new Appearance();
    UltraGridBand ultraGridBand1 = new UltraGridBand("ACHSettingsEntity", -1);
    UltraGridColumn ultraGridColumn1 = new UltraGridColumn("EntityGuid");
    UltraGridColumn ultraGridColumn2 = new UltraGridColumn("EntityName");
    UltraGridColumn ultraGridColumn3 = new UltraGridColumn("ACHSettings");
    UltraGridBand ultraGridBand2 = new UltraGridBand("ACHSettings", 0);
    UltraGridColumn ultraGridColumn4 = new UltraGridColumn("EntityGuid");
    UltraGridColumn ultraGridColumn5 = new UltraGridColumn("ACHSettingsBankID");
    UltraGridColumn ultraGridColumn6 = new UltraGridColumn("BankName");
    UltraGridColumn ultraGridColumn7 = new UltraGridColumn("SWIFTCode");
    UltraGridColumn ultraGridColumn8 = new UltraGridColumn("DateEntered");
    UltraGridColumn ultraGridColumn9 = new UltraGridColumn("EnteredBy");
    UltraGridColumn ultraGridColumn10 = new UltraGridColumn("IsApproved");
    UltraGridColumn ultraGridColumn11 = new UltraGridColumn("ACHSettingsDetails");
    UltraGridColumn ultraGridColumn12 = new UltraGridColumn("SortCode");
    UltraGridBand ultraGridBand3 = new UltraGridBand("ACHSettingsDetails", 1);
    UltraGridColumn ultraGridColumn13 = new UltraGridColumn("ACHSettingsAccountID");
    UltraGridColumn ultraGridColumn14 = new UltraGridColumn("ACHSettingsBankID");
    UltraGridColumn ultraGridColumn15 = new UltraGridColumn("EntityGuid");
    UltraGridColumn ultraGridColumn16 = new UltraGridColumn("AccountName");
    UltraGridColumn ultraGridColumn17 = new UltraGridColumn("AlternativePayee");
    UltraGridColumn ultraGridColumn18 = new UltraGridColumn("AccountNumber");
    UltraGridColumn ultraGridColumn19 = new UltraGridColumn("AccountType");
    UltraGridColumn ultraGridColumn20 = new UltraGridColumn("IBAN");
    UltraGridColumn ultraGridColumn21 = new UltraGridColumn("CHIPNumber");
    UltraGridColumn ultraGridColumn22 = new UltraGridColumn("PaymentFormat");
    UltraGridColumn ultraGridColumn23 = new UltraGridColumn("DateEntered");
    UltraGridColumn ultraGridColumn24 = new UltraGridColumn("EnteredBy");
    Appearance appearance2 = new Appearance();
    Appearance appearance3 = new Appearance();
    Appearance appearance4 = new Appearance();
    Appearance appearance5 = new Appearance();
    Appearance appearance6 = new Appearance();
    Appearance appearance7 = new Appearance();
    ScrollBarLook scrollBarLook = new ScrollBarLook();
    Appearance appearance8 = new Appearance();
    Appearance appearance9 = new Appearance();
    UltraToolbar ultraToolbar = new UltraToolbar("mainToolbar");
    ButtonTool buttonTool1 = new ButtonTool("APPROVE");
    ButtonTool buttonTool2 = new ButtonTool("APPROVEALL");
    ButtonTool buttonTool3 = new ButtonTool("APPROVEALL");
    Appearance appearance10 = new Appearance();
    ButtonTool buttonTool4 = new ButtonTool("APPROVE");
    Appearance appearance11 = new Appearance();
    this.gridPanel = new Panel();
    this.settingsGrid = new UltraGrid();
    this._formACHSettingsManagement_Toolbars_Dock_Area_Left = new UltraToolbarsDockArea();
    this.ultraToolbarsManager = new UltraToolbarsManager(this.components);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Right = new UltraToolbarsDockArea();
    this._formACHSettingsManagement_Toolbars_Dock_Area_Top = new UltraToolbarsDockArea();
    this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom = new UltraToolbarsDockArea();
    this.gridPanel.SuspendLayout();
    ((ISupportInitialize) this.settingsGrid).BeginInit();
    ((ISupportInitialize) this.ultraToolbarsManager).BeginInit();
    this.SuspendLayout();
    this.gridPanel.BackColor = Color.Transparent;
    this.gridPanel.Controls.Add((Control) this.settingsGrid);
    this.gridPanel.Dock = DockStyle.Fill;
    this.gridPanel.Location = new Point(0, 45);
    this.gridPanel.Name = "gridPanel";
    this.gridPanel.Size = new Size(1109, 467);
    this.gridPanel.TabIndex = 15;
    this.ultraToolbarsManager.SetContextMenuUltra((Component) this.settingsGrid, "gridContext");
    ((AppearanceBase) appearance1).BackColor = Color.White;
    ((AppearanceBase) appearance1).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Appearance = (AppearanceBase) appearance1;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.AutoFitStyle = (AutoFitStyle) 1;
    ((HeaderBase) ultraGridColumn1.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn1.Header).VisiblePosition = 0;
    ultraGridColumn1.Hidden = true;
    ultraGridColumn1.Width = 536;
    ultraGridColumn2.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn2.Header).Caption = "Entity Name";
    ((HeaderBase) ultraGridColumn2.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn2.Header).VisiblePosition = 1;
    ultraGridColumn2.Width = 1071;
    ((HeaderBase) ultraGridColumn3.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn3.Header).VisiblePosition = 2;
    ultraGridBand1.Columns.AddRange(new object[3]
    {
      (object) ultraGridColumn1,
      (object) ultraGridColumn2,
      (object) ultraGridColumn3
    });
    ultraGridBand1.Override.AllowRowFiltering = (DefaultableBoolean) 1;
    ((HeaderBase) ultraGridColumn4.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn4.Header).VisiblePosition = 0;
    ultraGridColumn4.Hidden = true;
    ultraGridColumn4.Width = 128 /*0x80*/;
    ((HeaderBase) ultraGridColumn5.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn5.Header).VisiblePosition = 1;
    ultraGridColumn5.Hidden = true;
    ultraGridColumn5.Width = 162;
    ultraGridColumn6.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn6.Header).Caption = "Bank Name";
    ((HeaderBase) ultraGridColumn6.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn6.Header).VisiblePosition = 2;
    ultraGridColumn6.Width = 212;
    ultraGridColumn7.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn7.Header).Caption = "SWIFT Code";
    ((HeaderBase) ultraGridColumn7.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn7.Header).VisiblePosition = 3;
    ultraGridColumn7.Width = 213;
    ultraGridColumn8.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn8.Header).Caption = "Date Entered";
    ((HeaderBase) ultraGridColumn8.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn8.Header).VisiblePosition = 5;
    ultraGridColumn8.Width = 209;
    ultraGridColumn9.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn9.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn9.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn9.Header).VisiblePosition = 6;
    ultraGridColumn9.Width = 209;
    ((HeaderBase) ultraGridColumn10.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn10.Header).VisiblePosition = 7;
    ultraGridColumn10.Hidden = true;
    ultraGridColumn10.Width = 175;
    ((HeaderBase) ultraGridColumn11.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn11.Header).VisiblePosition = 8;
    ultraGridColumn12.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn12.Header).Caption = "Sort Code";
    ((HeaderBase) ultraGridColumn12.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn12.Header).VisiblePosition = 4;
    ultraGridColumn12.Width = 209;
    ultraGridBand2.Columns.AddRange(new object[9]
    {
      (object) ultraGridColumn4,
      (object) ultraGridColumn5,
      (object) ultraGridColumn6,
      (object) ultraGridColumn7,
      (object) ultraGridColumn8,
      (object) ultraGridColumn9,
      (object) ultraGridColumn10,
      (object) ultraGridColumn11,
      (object) ultraGridColumn12
    });
    ((HeaderBase) ultraGridColumn13.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn13.Header).VisiblePosition = 0;
    ultraGridColumn13.Hidden = true;
    ultraGridColumn13.Width = 92;
    ((HeaderBase) ultraGridColumn14.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn14.Header).VisiblePosition = 1;
    ultraGridColumn14.Hidden = true;
    ultraGridColumn14.Width = 99;
    ((HeaderBase) ultraGridColumn15.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn15.Header).VisiblePosition = 2;
    ultraGridColumn15.Hidden = true;
    ultraGridColumn15.Width = 75;
    ultraGridColumn16.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn16.Header).Caption = "Account Name";
    ((HeaderBase) ultraGridColumn16.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn16.Header).VisiblePosition = 3;
    ultraGridColumn16.Width = 113;
    ultraGridColumn17.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn17.Header).Caption = "Alternative Payee";
    ((HeaderBase) ultraGridColumn17.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn17.Header).VisiblePosition = 6;
    ultraGridColumn17.Width = 121;
    ultraGridColumn18.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn18.Header).Caption = "Account Number";
    ((HeaderBase) ultraGridColumn18.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn18.Header).VisiblePosition = 4;
    ultraGridColumn18.Width = (int) sbyte.MaxValue;
    ultraGridColumn19.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn19.Header).Caption = "Type";
    ((HeaderBase) ultraGridColumn19.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn19.Header).VisiblePosition = 5;
    ultraGridColumn19.Width = 111;
    ultraGridColumn20.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn20.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn20.Header).VisiblePosition = 7;
    ultraGridColumn20.Width = 111;
    ultraGridColumn21.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn21.Header).Caption = "CHIP Number";
    ((HeaderBase) ultraGridColumn21.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn21.Header).VisiblePosition = 8;
    ultraGridColumn21.Width = 111;
    ultraGridColumn22.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn22.Header).Caption = "Payment Format";
    ((HeaderBase) ultraGridColumn22.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn22.Header).VisiblePosition = 9;
    ultraGridColumn22.Width = 117;
    ultraGridColumn23.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn23.Header).Caption = "Date Entered";
    ((HeaderBase) ultraGridColumn23.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn23.Header).VisiblePosition = 11;
    ultraGridColumn23.Width = 111;
    ultraGridColumn24.CellActivation = (Activation) 3;
    ((HeaderBase) ultraGridColumn24.Header).Caption = "Entered By";
    ((HeaderBase) ultraGridColumn24.Header).Editor = (EmbeddableEditorBase) null;
    ((HeaderBase) ultraGridColumn24.Header).VisiblePosition = 12;
    ultraGridColumn24.Width = 111;
    ultraGridBand3.Columns.AddRange(new object[12]
    {
      (object) ultraGridColumn13,
      (object) ultraGridColumn14,
      (object) ultraGridColumn15,
      (object) ultraGridColumn16,
      (object) ultraGridColumn17,
      (object) ultraGridColumn18,
      (object) ultraGridColumn19,
      (object) ultraGridColumn20,
      (object) ultraGridColumn21,
      (object) ultraGridColumn22,
      (object) ultraGridColumn23,
      (object) ultraGridColumn24
    });
    ((UltraGridBase) this.settingsGrid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand1);
    ((UltraGridBase) this.settingsGrid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand2);
    ((UltraGridBase) this.settingsGrid).DisplayLayout.BandsSerializer.Add((object) ultraGridBand3);
    ((UltraGridBase) this.settingsGrid).DisplayLayout.BorderStyle = (UIElementBorderStyle) 4;
    ((AppearanceBase) appearance2).BackColor = Color.FromArgb((int) byte.MaxValue, 240 /*0xF0*/, 194);
    ((AppearanceBase) appearance2).BorderColor = Color.FromArgb((int) sbyte.MaxValue, 157, 185);
    ((AppearanceBase) appearance2).ForeColor = Color.Black;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.ActiveRowAppearance = (AppearanceBase) appearance2;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.AllowColMoving = (AllowColMoving) 3;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.AllowColSizing = (AllowColSizing) 3;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.AllowColSwapping = (AllowColSwapping) 3;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.AllowDelete = (DefaultableBoolean) 2;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.AllowUpdate = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance3).BorderColor = Color.LightGray;
    ((AppearanceBase) appearance3).TextHAlignAsString = "Left";
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.CellAppearance = (AppearanceBase) appearance3;
    ((AppearanceBase) appearance4).BackColor = Color.FromArgb(207, 221, 240 /*0xF0*/);
    ((AppearanceBase) appearance4).TextHAlignAsString = "Left";
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.HeaderAppearance = (AppearanceBase) appearance4;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.HeaderClickAction = (HeaderClickAction) 3;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.MaxSelectedRows = 1;
    ((AppearanceBase) appearance5).BackColor = Color.FromArgb(246, 250, 253);
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.RowAlternateAppearance = (AppearanceBase) appearance5;
    ((AppearanceBase) appearance6).BorderColor = Color.LightGray;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.RowAppearance = (AppearanceBase) appearance6;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.RowSelectors = (DefaultableBoolean) 2;
    ((AppearanceBase) appearance7).BackColor = Color.Transparent;
    ((AppearanceBase) appearance7).ForeColor = Color.Black;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.SelectedRowAppearance = (AppearanceBase) appearance7;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.Override.SelectTypeCell = (SelectType) 1;
    ((AppearanceBase) appearance8).BackColor = Color.WhiteSmoke;
    ((AppearanceBase) appearance8).BorderColor = Color.Silver;
    scrollBarLook.ButtonAppearance = (AppearanceBase) appearance8;
    ((AppearanceBase) appearance9).BackColor = Color.White;
    scrollBarLook.TrackAppearance = (AppearanceBase) appearance9;
    ((UltraGridBase) this.settingsGrid).DisplayLayout.ScrollBarLook = scrollBarLook;
    ((Control) this.settingsGrid).Dock = DockStyle.Fill;
    ((Control) this.settingsGrid).Font = new Font("Tahoma", 8.25f);
    ((Control) this.settingsGrid).Location = new Point(0, 0);
    ((Control) this.settingsGrid).Name = "settingsGrid";
    ((Control) this.settingsGrid).Size = new Size(1109, 467);
    ((Control) this.settingsGrid).TabIndex = 9;
    ((UltraControlBase) this.settingsGrid).UseFlatMode = (DefaultableBoolean) 1;
    ((UltraControlBase) this.settingsGrid).UseOsThemes = (DefaultableBoolean) 2;
    this.settingsGrid.InitializeLayout += new InitializeLayoutEventHandler(this.settingsGrid_InitializeLayout);
    this.settingsGrid.ClickCell += new ClickCellEventHandler(this.settingsGrid_ClickCell);
    ((Control) this.settingsGrid).DoubleClick += new EventHandler(this.settingsGrid_DoubleClick);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Left.DockedPosition = (DockedPosition) 2;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).ForeColor = SystemColors.ControlText;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).Location = new Point(0, 45);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).Name = "_formACHSettingsManagement_Toolbars_Dock_Area_Left";
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left).Size = new Size(0, 467);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Left.ToolbarsManager = this.ultraToolbarsManager;
    this.ultraToolbarsManager.DesignerFlags = 1;
    this.ultraToolbarsManager.DockWithinContainer = (Control) this;
    this.ultraToolbarsManager.DockWithinContainerBaseType = typeof (FormBase);
    this.ultraToolbarsManager.MdiMergeable = false;
    this.ultraToolbarsManager.ShowFullMenusDelay = 500;
    this.ultraToolbarsManager.Style = (ToolbarStyle) 5;
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
    ultraToolbar.Settings.CaptionPlacement = (TextPlacement) 2;
    ultraToolbar.Settings.FillEntireRow = (DefaultableBoolean) 1;
    ultraToolbar.Settings.GrabHandleStyle = (GrabHandleStyle) 1;
    ultraToolbar.Text = "mainToolbar";
    this.ultraToolbarsManager.Toolbars.AddRange(new UltraToolbar[1]
    {
      ultraToolbar
    });
    ((AppearanceBase) appearance10).Image = (object) Resources.book_add;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance10;
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).Caption = "Approve All";
    ((ToolPropsBase) ((ToolBase) buttonTool3).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((AppearanceBase) appearance11).Image = (object) Resources.accept;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).AppearancesSmall.Appearance = (AppearanceBase) appearance11;
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).Caption = "Approve";
    ((ToolPropsBase) ((ToolBase) buttonTool4).SharedPropsInternal).DisplayStyle = (ToolDisplayStyle) 4;
    ((ToolsCollectionBase) this.ultraToolbarsManager.Tools).AddRange(new ToolBase[2]
    {
      (ToolBase) buttonTool3,
      (ToolBase) buttonTool4
    });
    this.ultraToolbarsManager.ToolClick += new ToolClickEventHandler(this.ultraToolbarsManager_ToolClick);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Right.DockedPosition = (DockedPosition) 3;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).ForeColor = SystemColors.ControlText;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).Location = new Point(1109, 45);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).Name = "_formACHSettingsManagement_Toolbars_Dock_Area_Right";
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right).Size = new Size(0, 467);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Right.ToolbarsManager = this.ultraToolbarsManager;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Top.DockedPosition = (DockedPosition) 0;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).ForeColor = SystemColors.ControlText;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).Location = new Point(0, 0);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).Name = "_formACHSettingsManagement_Toolbars_Dock_Area_Top";
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top).Size = new Size(1109, 45);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Top.ToolbarsManager = this.ultraToolbarsManager;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).AccessibleRole = AccessibleRole.Grouping;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).BackColor = Color.FromArgb(191, 219, (int) byte.MaxValue);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom.DockedPosition = (DockedPosition) 1;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).ForeColor = SystemColors.ControlText;
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).Location = new Point(0, 512 /*0x0200*/);
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).Name = "_formACHSettingsManagement_Toolbars_Dock_Area_Bottom";
    ((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom).Size = new Size(1109, 0);
    this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom.ToolbarsManager = this.ultraToolbarsManager;
    this.ClientSize = new Size(1109, 512 /*0x0200*/);
    this.Controls.Add((Control) this.gridPanel);
    this.Controls.Add((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Left);
    this.Controls.Add((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Right);
    this.Controls.Add((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Bottom);
    this.Controls.Add((Control) this._formACHSettingsManagement_Toolbars_Dock_Area_Top);
    this.Font = new Font("Tahoma", 8.25f);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Name = nameof (formMultiACHSettingsPending);
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "ACH Settings Pending Approval";
    this.Load += new EventHandler(this.formMultiACHSettingsPending_Load);
    this.gridPanel.ResumeLayout(false);
    ((ISupportInitialize) this.settingsGrid).EndInit();
    ((ISupportInitialize) this.ultraToolbarsManager).EndInit();
    this.ResumeLayout(false);
  }
}
